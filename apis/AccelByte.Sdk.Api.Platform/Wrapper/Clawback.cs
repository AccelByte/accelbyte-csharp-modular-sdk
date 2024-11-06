// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;

namespace AccelByte.Sdk.Api.Platform.Wrapper
{
    public class Clawback
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public Clawback(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public Clawback(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        public QueryIAPClawbackHistory.QueryIAPClawbackHistoryBuilder QueryIAPClawbackHistoryOp
        {
            get
            {
                var opBuilder = new Operation.QueryIAPClawbackHistory.QueryIAPClawbackHistoryBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public MockPlayStationStreamEvent.MockPlayStationStreamEventBuilder MockPlayStationStreamEventOp
        {
            get
            {
                var opBuilder = new Operation.MockPlayStationStreamEvent.MockPlayStationStreamEventBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

        public QueryIAPClawbackHistory.Response QueryIAPClawbackHistory(QueryIAPClawbackHistory input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<QueryIAPClawbackHistory.Response> QueryIAPClawbackHistoryAsync(QueryIAPClawbackHistory input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public MockPlayStationStreamEvent.Response MockPlayStationStreamEvent(MockPlayStationStreamEvent input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<MockPlayStationStreamEvent.Response> MockPlayStationStreamEventAsync(MockPlayStationStreamEvent input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public MockPlayStationStreamEvent.Response<T1, T2> MockPlayStationStreamEvent<T1, T2>(MockPlayStationStreamEvent input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<MockPlayStationStreamEvent.Response<T1, T2>> MockPlayStationStreamEventAsync<T1, T2>(MockPlayStationStreamEvent input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}