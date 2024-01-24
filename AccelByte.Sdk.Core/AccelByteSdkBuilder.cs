// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AccelByte.Sdk.Core.Net.Http;
using AccelByte.Sdk.Core.Net.Logging;
using AccelByte.Sdk.Core.Repository;
using AccelByte.Sdk.Core.Security;
using AccelByte.Sdk.Core.Pipeline;

namespace AccelByte.Sdk.Core
{
    public class AccelByteSdkBuilder<T> : IAccelByteSdkBuilder<T> where T : IAccelByteSdk
    {
        private IHttpClient? _Client = null;

        private ITokenRepository? _TokenRepository = null;

        private IConfigRepository? _ConfigRepository = null;

        private ICredentialRepository? _Credential = null;

        private IHttpLogger? _Logger = null;

        private ITokenValidator? _TokenValidator = null;

        private bool _EnableLogging = false;

        private List<IOperationProcess> _OpProcesses = new List<IOperationProcess>();

        private List<ISdkService> _Services = new List<ISdkService>();

        private Dictionary<string, bool> _Flags = new();

        private ISdkEvents _Events = new SdkEvents();

        private string _FlightId = "";

        public IAccelByteSdkBuilder<T> SetHttpClient(IHttpClient client)
        {
            _Client = client;
            return this;
        }

        public IAccelByteSdkBuilder<T> SetTokenRepository(ITokenRepository repository)
        {
            _TokenRepository = repository;
            return this;
        }

        public IAccelByteSdkBuilder<T> SetConfigRepository(IConfigRepository repository)
        {
            _ConfigRepository = repository;
            return this;
        }

        public IAccelByteSdkBuilder<T> SetCredentialRepository(ICredentialRepository credential)
        {
            _Credential = credential;
            return this;
        }

        public IAccelByteSdkBuilder<T> EnableLog()
        {
            _EnableLogging = true;
            return this;
        }

        public IAccelByteSdkBuilder<T> SetLogger(IHttpLogger logger)
        {
            _Logger = logger;
            return this;
        }

        public IAccelByteSdkBuilder<T> SetTokenValidator(ITokenValidator tokenValidator)
        {
            _TokenValidator = tokenValidator;
            return this;
        }

        public IAccelByteSdkBuilder<T> AddOperationProcess(IOperationProcess opProcess)
        {
            _OpProcesses.Add(opProcess);
            return this;
        }

        public IAccelByteSdkBuilder<T> RegisterService(ISdkService service)
        {
            _Services.Add(service);
            return this;
        }

        public IAccelByteSdkBuilder<T> SetFlag(string key, bool value)
        {
            if (_Flags.ContainsKey(key))
                _Flags[key] = value;
            else
                _Flags.Add(key, value);
            return this;
        }

        public IAccelByteSdkBuilder<T> UnsetFlag(string key)
        {
            if (_Flags.ContainsKey(key))
                _Flags.Remove(key);
            return this;
        }

        public IAccelByteSdkBuilder<T> RegisterEvent(string key, object eventAction)
        {
            _Events.RegisterEvent(key, eventAction);
            return this;
        }

        public IAccelByteSdkBuilder<T> SetFlightId(string flightId)
        {
            _FlightId = flightId;
            return this;
        }

        public T Build()
        {
            if (_Client == null)
                throw IncompleteComponentException.NoHttpClient;
            if (_TokenRepository == null)
                throw IncompleteComponentException.NoTokenRepository;
            if (_ConfigRepository == null)
                throw IncompleteComponentException.NoConfigRepository;

            if (_EnableLogging)
            {
                if (_Logger == null)
                {
                    IHttpLogger logger = new DefaultHttpLogger();
                    _Client.SetLogger(logger);
                }
                else
                    _Client.SetLogger(_Logger);
            }

            IAccelByteConfig config = new AccelByteConfig(_Client, _TokenRepository, _ConfigRepository, _Flags);
            if (_Credential != null)
                config.Credential = _Credential;
            if (_TokenValidator != null)
                config.TokenValidator = _TokenValidator;

            T? sdk;
            if (_Services.Count > 0)
                sdk = (T?)Activator.CreateInstance(typeof(T), config, _Events, _Services);
            else
                sdk = (T?)Activator.CreateInstance(typeof(T), config, _Events);
            if (sdk == null)
                throw new Exception("Could not create sdk object");

            if (_TokenRepository is ISdkConsumerRepository tRepository)
                tRepository.SetSdkObject(sdk);
            if (_ConfigRepository is ISdkConsumerRepository cRepository)
                cRepository.SetSdkObject(sdk);
            if ((_Credential != null) && (_Credential is ISdkConsumerRepository dRepository))
                dRepository.SetSdkObject(sdk);

            if (_OpProcesses.Count > 0)
            {
                foreach (IOperationProcess opp in _OpProcesses)
                    sdk.OpProcess.AppendToChain(opp);
            }

            if (_FlightId == "")
                _FlightId = AccelByteConfig.DefaultFlightId;
            sdk.UpdateFlightId(_FlightId);

            return sdk;
        }
    }
}
