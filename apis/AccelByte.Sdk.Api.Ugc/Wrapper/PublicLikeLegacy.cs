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
    public class PublicLikeLegacy
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public PublicLikeLegacy(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public PublicLikeLegacy(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        public GetLikedContent.GetLikedContentBuilder GetLikedContentOp
        {
            get
            {
                var opBuilder = new Operation.GetLikedContent.GetLikedContentBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public UpdateContentLikeStatus.UpdateContentLikeStatusBuilder UpdateContentLikeStatusOp
        {
            get
            {
                var opBuilder = new Operation.UpdateContentLikeStatus.UpdateContentLikeStatusBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

        public Model.ModelsPaginatedContentDownloadResponse? GetLikedContent(GetLikedContent input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsPaginatedContentDownloadResponse?> GetLikedContentAsync(GetLikedContent input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsContentLikeResponse? UpdateContentLikeStatus(UpdateContentLikeStatus input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsContentLikeResponse?> UpdateContentLikeStatusAsync(UpdateContentLikeStatus input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}