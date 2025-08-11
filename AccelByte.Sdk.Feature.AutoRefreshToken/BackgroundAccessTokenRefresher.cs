// Copyright (c) 2025 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Feature.AutoTokenRefresh
{
    public class BackgroundAccessTokenRefresher : BaseTokenRefresher, ISdkService
    {
        private IAccelByteSdk? _Sdk = null;

        private Timer _Timer;

        private BackgroundTokenRefreshOptions _Options;

        private void _TimerCallback(object? state)
        {
            if (_Sdk == null)
                return;

            Task.Run(() => DoRefreshTokenAsync(_Sdk, _Options.OnTokenRefreshed, _Options.OnRefreshFailed, false));
        }

        public BackgroundAccessTokenRefresher(BackgroundTokenRefreshOptions options)
            : base(options)
        {
            _Options = options;
            _Timer = new Timer(_TimerCallback);
        }

        public void Start(IAccelByteSdk sdk)
        {
            _Sdk = sdk;
            _Timer.Change(0, _Options.Interval);
        }

        public void Stop()
        {
            _Timer.Change(Timeout.Infinite, Timeout.Infinite);
        }
    }
}
