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

using AccelByte.Sdk.Api.Cloudsave.Model;
using AccelByte.Sdk.Api.Cloudsave.Operation;

namespace AccelByte.Sdk.Api.Cloudsave.Wrapper
{
    public class AdminTags
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public AdminTags(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public AdminTags(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        public AdminListTagsHandlerV1.AdminListTagsHandlerV1Builder AdminListTagsHandlerV1Op
        {
            get
            {
                var opBuilder = new Operation.AdminListTagsHandlerV1.AdminListTagsHandlerV1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminPostTagHandlerV1.AdminPostTagHandlerV1Builder AdminPostTagHandlerV1Op
        {
            get
            {
                var opBuilder = new Operation.AdminPostTagHandlerV1.AdminPostTagHandlerV1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminDeleteTagHandlerV1.AdminDeleteTagHandlerV1Builder AdminDeleteTagHandlerV1Op
        {
            get
            {
                var opBuilder = new Operation.AdminDeleteTagHandlerV1.AdminDeleteTagHandlerV1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

        public AdminListTagsHandlerV1.Response AdminListTagsHandlerV1(AdminListTagsHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminListTagsHandlerV1.Response> AdminListTagsHandlerV1Async(AdminListTagsHandlerV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminPostTagHandlerV1.Response AdminPostTagHandlerV1(AdminPostTagHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminPostTagHandlerV1.Response> AdminPostTagHandlerV1Async(AdminPostTagHandlerV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminDeleteTagHandlerV1.Response AdminDeleteTagHandlerV1(AdminDeleteTagHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminDeleteTagHandlerV1.Response> AdminDeleteTagHandlerV1Async(AdminDeleteTagHandlerV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}