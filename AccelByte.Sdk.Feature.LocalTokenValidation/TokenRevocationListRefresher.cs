// Copyright (c) 2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Threading;
using System.Threading.Tasks;

using AccelByte.Sdk;
using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api;
using AccelByte.Sdk.Api.Iam.Model;

namespace AccelByte.Sdk.Feature.LocalTokenValidation
{
    public class TokenRevocationListRefresher : ISdkService
    {
        private IAccelByteSdk? _Sdk = null;

        private Timer _Timer;

        private int _RefreshInterval;

        private void _TimerCallback(object? state)
        {
            if (_Sdk == null)
                return;

            var revList = FetchRevocationList(_Sdk);
            if (revList == null)
                return;

            _Sdk.LocalData[TokenRevocationData.DATA_KEY] = new TokenRevocationData(revList);
        }

        protected OauthapiRevocationList? FetchRevocationList(IAccelByteSdk sdk)
        {
            var revList = sdk.GetIamApi().OAuth20.GetRevocationListV3Op
                .SetPreferredSecurityMethod(Operation.SECURITY_BASIC)
                .Execute();
            revList.ThrowExceptionIfError();
            if (revList.Data == null)
                throw new Exception("Could not get revocation list.");

            return revList.Data;
        }

        public TokenRevocationListRefresher(int refreshInterval)
        {
            _RefreshInterval = refreshInterval;
            _Timer = new Timer(_TimerCallback);
        }

        public void Start(IAccelByteSdk sdk)
        {
            _Sdk = sdk;
            _Timer.Change(0, _RefreshInterval);
        }

        public void Stop()
        {
            _Timer.Change(Timeout.Infinite, Timeout.Infinite);
        }
    }
}