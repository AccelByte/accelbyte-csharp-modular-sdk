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

using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;

namespace AccelByte.Sdk.Api.Iam.Wrapper
{
    public class SSOSAML20
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public SSOSAML20(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public SSOSAML20(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        public PlatformAuthenticateSAMLV3Handler.PlatformAuthenticateSAMLV3HandlerBuilder PlatformAuthenticateSAMLV3HandlerOp
        {
            get
            {
                var opBuilder = new Operation.PlatformAuthenticateSAMLV3Handler.PlatformAuthenticateSAMLV3HandlerBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

        public PlatformAuthenticateSAMLV3Handler.Response PlatformAuthenticateSAMLV3Handler(PlatformAuthenticateSAMLV3Handler input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PlatformAuthenticateSAMLV3Handler.Response> PlatformAuthenticateSAMLV3HandlerAsync(PlatformAuthenticateSAMLV3Handler input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}