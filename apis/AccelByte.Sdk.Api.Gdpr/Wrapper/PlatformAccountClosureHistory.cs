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

using AccelByte.Sdk.Api.Gdpr.Model;
using AccelByte.Sdk.Api.Gdpr.Operation;

namespace AccelByte.Sdk.Api.Gdpr.Wrapper
{
    public class PlatformAccountClosureHistory
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public PlatformAccountClosureHistory(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public PlatformAccountClosureHistory(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        public AdminGetUserPlatformAccountClosureHistories.AdminGetUserPlatformAccountClosureHistoriesBuilder AdminGetUserPlatformAccountClosureHistoriesOp
        {
            get
            {
                var opBuilder = new Operation.AdminGetUserPlatformAccountClosureHistories.AdminGetUserPlatformAccountClosureHistoriesBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

        public Model.DtoUserPlatformAccountClosureHistoriesResponse? AdminGetUserPlatformAccountClosureHistories(AdminGetUserPlatformAccountClosureHistories input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.DtoUserPlatformAccountClosureHistoriesResponse?> AdminGetUserPlatformAccountClosureHistoriesAsync(AdminGetUserPlatformAccountClosureHistories input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}