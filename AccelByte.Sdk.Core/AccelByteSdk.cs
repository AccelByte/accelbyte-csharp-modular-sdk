// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using AccelByte.Sdk.Core.Net.Http;
using AccelByte.Sdk.Core.Pipeline;
using AccelByte.Sdk.Core.Security;

namespace AccelByte.Sdk.Core
{
    public class AccelByteSdk : IAccelByteSdk
    {
        public static IAccelByteSdkBuilder<AccelByteSdk> Builder { get => new AccelByteSdkBuilder<AccelByteSdk>(); }

        private readonly Dictionary<string, ISdkApi> _ApiObjects = new();

        private readonly List<ISdkService> _Services = new();

        public IAccelByteConfig Configuration { get; private set; }

        public ISdkLocalData LocalData { get; } = new SdkLocalData();

        public ISdkEvents Events { get; } = new SdkEvents();

        public IOperationProcessPipeline OpProcess { get; } = new OperationProcessPipeline();

        public string Namespace { get => Configuration.ConfigRepository.Namespace; }

        public string FlightId { get; private set; } = String.Empty;

        public AccelByteSdk(IAccelByteConfig config)
        {
            Configuration = config;
            OpProcess.AppendToChain(new MandatoryOperationProcess());
        }

        public AccelByteSdk(IAccelByteConfig config, ISdkEvents events)
        {
            Configuration = config;
            Events = events;
            OpProcess.AppendToChain(new MandatoryOperationProcess());
        }

        public AccelByteSdk(IAccelByteConfig config, List<ISdkService> services)
        {
            Configuration = config;
            OpProcess.AppendToChain(new MandatoryOperationProcess());

            _Services = services;
            foreach (var service in _Services)
                service.Start(this);
        }

        public AccelByteSdk(IAccelByteConfig config, ISdkEvents events, List<ISdkService> services)
        {
            Configuration = config;
            Events = events;
            OpProcess.AppendToChain(new MandatoryOperationProcess());

            _Services = services;
            foreach (var service in _Services)
                service.Start(this);
        }

        public void Dispose()
        {
            foreach (var service in _Services)
            {
                service.Stop();
                if (service is IDisposable disposable)
                    disposable.Dispose();
            }
        }

        public void StopServices()
        {
            foreach (var service in _Services)
                service.Stop();
        }

        public T? GetService<T>() where T : ISdkService
        {
            foreach (var service in _Services)
            {
                if (service is T t)
                    return t;
            }
            return default;
        }

        public IHttpResponse RunRequest(IOperation operation)
        {
            IOperation pOperation = OpProcess.RunProcessPipeline(operation, this);

            var baseUrl = Configuration.ConfigRepository.BaseUrl;
            return Configuration.HttpClient.SendRequest(pOperation, baseUrl);
        }

        public async Task<IHttpResponse> RunRequestAsync(IOperation operation)
        {
            IOperation pOperation = await OpProcess.RunProcessPipelineAsync(operation, this);

            var baseUrl = Configuration.ConfigRepository.BaseUrl;
            return await Configuration.HttpClient.SendRequestAsync(pOperation, baseUrl);
        }

        public T GetApi<T>(string key) where T : ISdkApi
        {
            if (!_ApiObjects.ContainsKey(key))
            {
                object? apiObj = Activator.CreateInstance(typeof(T), this);
                if (apiObj == null)
                    throw new Exception($"Could not create api object {key}.");
                _ApiObjects.TryAdd(key, (T)apiObj);
            }
            return (T)_ApiObjects[key];
        }

        public T GetApi<T>() where T : ISdkApi
        {
            string key = typeof(T).FullName!.ToLower();
            return GetApi<T>(key);
        }

        public T GetApi<T>(string key, Func<T> activatorFunc) where T : ISdkApi
        {
            if (!_ApiObjects.ContainsKey(key))
            {
                T apiObj = activatorFunc.Invoke();
                _ApiObjects.TryAdd(key, apiObj);
            }
            return (T)_ApiObjects[key];
        }

        public bool ValidateToken(string accessToken)
        {
            if (Configuration.TokenValidator != null)
                return Configuration.TokenValidator.Validate(this, accessToken);
            else
                throw new Exception("Could not validate token. No token validator assigned.");
        }

        public bool ValidateToken(string accessToken, string permission, int action)
        {
            if (Configuration.TokenValidator != null)
                return Configuration.TokenValidator.Validate(this, accessToken, permission, action);
            else
                throw new Exception("Could not validate token. No token validator assigned.");
        }

        public bool ValidateToken(string accessToken, string permission, int action, string? aNamespace, string? userId)
        {
            if (Configuration.TokenValidator != null)
                return Configuration.TokenValidator.Validate(this, accessToken, permission, action, aNamespace, userId);
            else
                throw new Exception("Could not validate token. No token validator assigned.");
        }

        public async Task<bool> ValidateTokenAsync(string accessToken)
        {
            if ((Configuration.TokenValidator != null) && (Configuration.TokenValidator is IAsyncTokenValidator))
                return await ((IAsyncTokenValidator)Configuration.TokenValidator).ValidateAsync(this, accessToken);
            else
                throw new Exception("Could not validate token. No token validator assigned or invalid token validator.");
        }

        public async Task<bool> ValidateTokenAsync(string accessToken, string permission, int action)
        {
            if ((Configuration.TokenValidator != null) && (Configuration.TokenValidator is IAsyncTokenValidator))
                return await ((IAsyncTokenValidator)Configuration.TokenValidator).ValidateAsync(this, accessToken, permission, action);
            else
                throw new Exception("Could not validate token. No token validator assigned.");
        }

        public async Task<bool> ValidateTokenAsync(string accessToken, string permission, int action, string? aNamespace, string? userId)
        {
            if ((Configuration.TokenValidator != null) && (Configuration.TokenValidator is IAsyncTokenValidator))
                return await ((IAsyncTokenValidator)Configuration.TokenValidator).ValidateAsync(this, accessToken, permission, action, aNamespace, userId);
            else
                throw new Exception("Could not validate token. No token validator assigned.");
        }

        public void UpdateFlightId(string flightId)
        {
            FlightId = flightId;
        }
    }
}