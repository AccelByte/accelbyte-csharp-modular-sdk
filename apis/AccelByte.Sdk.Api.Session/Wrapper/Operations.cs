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

using AccelByte.Sdk.Api.Session.Model;
using AccelByte.Sdk.Api.Session.Operation;

namespace AccelByte.Sdk.Api.Session.Wrapper
{
    public class Operations
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public Operations(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public Operations(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        public GetHealthcheckInfo.GetHealthcheckInfoBuilder GetHealthcheckInfoOp
        {
            get
            {
                var opBuilder = new Operation.GetHealthcheckInfo.GetHealthcheckInfoBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetHealthcheckInfoV1.GetHealthcheckInfoV1Builder GetHealthcheckInfoV1Op
        {
            get
            {
                var opBuilder = new Operation.GetHealthcheckInfoV1.GetHealthcheckInfoV1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

        public GetHealthcheckInfo.Response GetHealthcheckInfo(GetHealthcheckInfo input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetHealthcheckInfo.Response> GetHealthcheckInfoAsync(GetHealthcheckInfo input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public GetHealthcheckInfoV1.Response GetHealthcheckInfoV1(GetHealthcheckInfoV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetHealthcheckInfoV1.Response> GetHealthcheckInfoV1Async(GetHealthcheckInfoV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}