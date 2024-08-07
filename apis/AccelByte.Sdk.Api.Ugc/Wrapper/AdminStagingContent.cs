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

using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Api.Ugc.Operation;

namespace AccelByte.Sdk.Api.Ugc.Wrapper
{
    public class AdminStagingContent
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public AdminStagingContent(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public AdminStagingContent(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        public AdminListStagingContents.AdminListStagingContentsBuilder AdminListStagingContentsOp
        {
            get
            {
                var opBuilder = new Operation.AdminListStagingContents.AdminListStagingContentsBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminGetStagingContentByID.AdminGetStagingContentByIDBuilder AdminGetStagingContentByIDOp
        {
            get
            {
                var opBuilder = new Operation.AdminGetStagingContentByID.AdminGetStagingContentByIDBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminApproveStagingContent.AdminApproveStagingContentBuilder AdminApproveStagingContentOp
        {
            get
            {
                var opBuilder = new Operation.AdminApproveStagingContent.AdminApproveStagingContentBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminListUserStagingContents.AdminListUserStagingContentsBuilder AdminListUserStagingContentsOp
        {
            get
            {
                var opBuilder = new Operation.AdminListUserStagingContents.AdminListUserStagingContentsBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

        public Model.ModelsPaginatedListStagingContentResponse? AdminListStagingContents(AdminListStagingContents input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsPaginatedListStagingContentResponse?> AdminListStagingContentsAsync(AdminListStagingContents input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsStagingContentResponse? AdminGetStagingContentByID(AdminGetStagingContentByID input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsStagingContentResponse?> AdminGetStagingContentByIDAsync(AdminGetStagingContentByID input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ModelsStagingContentResponse<T1>? AdminGetStagingContentByID<T1>(AdminGetStagingContentByID input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsStagingContentResponse<T1>?> AdminGetStagingContentByIDAsync<T1>(AdminGetStagingContentByID input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsStagingContentResponse? AdminApproveStagingContent(AdminApproveStagingContent input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsStagingContentResponse?> AdminApproveStagingContentAsync(AdminApproveStagingContent input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ModelsStagingContentResponse<T1>? AdminApproveStagingContent<T1>(AdminApproveStagingContent input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsStagingContentResponse<T1>?> AdminApproveStagingContentAsync<T1>(AdminApproveStagingContent input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPaginatedListStagingContentResponse? AdminListUserStagingContents(AdminListUserStagingContents input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsPaginatedListStagingContentResponse?> AdminListUserStagingContentsAsync(AdminListUserStagingContents input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}