// Copyright (c) 2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Gametelemetry;

namespace AccelByte.Sdk.Api.Gametelemetry
{
    public class GametelemetryApi : ISdkApi
    {
        private IAccelByteSdk _Sdk;

        public Wrapper.Telemetry Telemetry
        {
            get
            {
                if (_Telemetry == null)
                    _Telemetry = new Wrapper.Telemetry(_Sdk);
                return _Telemetry;
            }
        }
        private Wrapper.Telemetry? _Telemetry = null;

        public Wrapper.GametelemetryOperations GametelemetryOperations
        {
            get
            {
                if (_GametelemetryOperations == null)
                    _GametelemetryOperations = new Wrapper.GametelemetryOperations(_Sdk);
                return _GametelemetryOperations;
            }
        }
        private Wrapper.GametelemetryOperations? _GametelemetryOperations = null;

        internal GametelemetryApi(IAccelByteSdk sdk)
        {
            _Sdk = sdk;
        }
    }
}

namespace AccelByte.Sdk.Api
{
    public static class GametelemetryApi_SdkExts
    {
        public static GametelemetryApi GetGametelemetryApi(this IAccelByteSdk sdk)
        {
            return sdk.GetApi<GametelemetryApi>("gametelemetry", () =>
            {
                return new GametelemetryApi(sdk);
            });
        }
    }
}