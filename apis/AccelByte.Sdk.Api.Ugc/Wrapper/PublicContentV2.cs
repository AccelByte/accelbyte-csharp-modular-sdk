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
    public class PublicContentV2
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public PublicContentV2(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public PublicContentV2(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        public PublicGetContentByChannelIDV2.PublicGetContentByChannelIDV2Builder PublicGetContentByChannelIDV2Op
        {
            get
            {
                var opBuilder = new Operation.PublicGetContentByChannelIDV2.PublicGetContentByChannelIDV2Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PublicListContentV2.PublicListContentV2Builder PublicListContentV2Op
        {
            get
            {
                var opBuilder = new Operation.PublicListContentV2.PublicListContentV2Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PublicBulkGetContentByIDV2.PublicBulkGetContentByIDV2Builder PublicBulkGetContentByIDV2Op
        {
            get
            {
                var opBuilder = new Operation.PublicBulkGetContentByIDV2.PublicBulkGetContentByIDV2Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PublicGetContentBulkByShareCodesV2.PublicGetContentBulkByShareCodesV2Builder PublicGetContentBulkByShareCodesV2Op
        {
            get
            {
                var opBuilder = new Operation.PublicGetContentBulkByShareCodesV2.PublicGetContentBulkByShareCodesV2Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PublicGetContentByShareCodeV2.PublicGetContentByShareCodeV2Builder PublicGetContentByShareCodeV2Op
        {
            get
            {
                var opBuilder = new Operation.PublicGetContentByShareCodeV2.PublicGetContentByShareCodeV2Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PublicGetContentByIDV2.PublicGetContentByIDV2Builder PublicGetContentByIDV2Op
        {
            get
            {
                var opBuilder = new Operation.PublicGetContentByIDV2.PublicGetContentByIDV2Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PublicCreateContentV2.PublicCreateContentV2Builder PublicCreateContentV2Op
        {
            get
            {
                var opBuilder = new Operation.PublicCreateContentV2.PublicCreateContentV2Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PublicUpdateContentByShareCodeV2.PublicUpdateContentByShareCodeV2Builder PublicUpdateContentByShareCodeV2Op
        {
            get
            {
                var opBuilder = new Operation.PublicUpdateContentByShareCodeV2.PublicUpdateContentByShareCodeV2Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PublicDeleteContentByShareCodeV2.PublicDeleteContentByShareCodeV2Builder PublicDeleteContentByShareCodeV2Op
        {
            get
            {
                var opBuilder = new Operation.PublicDeleteContentByShareCodeV2.PublicDeleteContentByShareCodeV2Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PublicDeleteContentV2.PublicDeleteContentV2Builder PublicDeleteContentV2Op
        {
            get
            {
                var opBuilder = new Operation.PublicDeleteContentV2.PublicDeleteContentV2Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PublicUpdateContentV2.PublicUpdateContentV2Builder PublicUpdateContentV2Op
        {
            get
            {
                var opBuilder = new Operation.PublicUpdateContentV2.PublicUpdateContentV2Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PublicUpdateContentFileLocation.PublicUpdateContentFileLocationBuilder PublicUpdateContentFileLocationOp
        {
            get
            {
                var opBuilder = new Operation.PublicUpdateContentFileLocation.PublicUpdateContentFileLocationBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public UpdateContentShareCodeV2.UpdateContentShareCodeV2Builder UpdateContentShareCodeV2Op
        {
            get
            {
                var opBuilder = new Operation.UpdateContentShareCodeV2.UpdateContentShareCodeV2Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PublicGenerateContentUploadURLV2.PublicGenerateContentUploadURLV2Builder PublicGenerateContentUploadURLV2Op
        {
            get
            {
                var opBuilder = new Operation.PublicGenerateContentUploadURLV2.PublicGenerateContentUploadURLV2Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PublicGetContentByUserIDV2.PublicGetContentByUserIDV2Builder PublicGetContentByUserIDV2Op
        {
            get
            {
                var opBuilder = new Operation.PublicGetContentByUserIDV2.PublicGetContentByUserIDV2Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public UpdateScreenshotsV2.UpdateScreenshotsV2Builder UpdateScreenshotsV2Op
        {
            get
            {
                var opBuilder = new Operation.UpdateScreenshotsV2.UpdateScreenshotsV2Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public UploadContentScreenshotV2.UploadContentScreenshotV2Builder UploadContentScreenshotV2Op
        {
            get
            {
                var opBuilder = new Operation.UploadContentScreenshotV2.UploadContentScreenshotV2Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public DeleteContentScreenshotV2.DeleteContentScreenshotV2Builder DeleteContentScreenshotV2Op
        {
            get
            {
                var opBuilder = new Operation.DeleteContentScreenshotV2.DeleteContentScreenshotV2Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

        public PublicGetContentByChannelIDV2.Response PublicGetContentByChannelIDV2(PublicGetContentByChannelIDV2 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicGetContentByChannelIDV2.Response> PublicGetContentByChannelIDV2Async(PublicGetContentByChannelIDV2 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public PublicListContentV2.Response PublicListContentV2(PublicListContentV2 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicListContentV2.Response> PublicListContentV2Async(PublicListContentV2 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public PublicBulkGetContentByIDV2.Response PublicBulkGetContentByIDV2(PublicBulkGetContentByIDV2 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicBulkGetContentByIDV2.Response> PublicBulkGetContentByIDV2Async(PublicBulkGetContentByIDV2 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public PublicBulkGetContentByIDV2.Response<T1> PublicBulkGetContentByIDV2<T1>(PublicBulkGetContentByIDV2 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicBulkGetContentByIDV2.Response<T1>> PublicBulkGetContentByIDV2Async<T1>(PublicBulkGetContentByIDV2 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public PublicGetContentBulkByShareCodesV2.Response PublicGetContentBulkByShareCodesV2(PublicGetContentBulkByShareCodesV2 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicGetContentBulkByShareCodesV2.Response> PublicGetContentBulkByShareCodesV2Async(PublicGetContentBulkByShareCodesV2 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public PublicGetContentBulkByShareCodesV2.Response<T1> PublicGetContentBulkByShareCodesV2<T1>(PublicGetContentBulkByShareCodesV2 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicGetContentBulkByShareCodesV2.Response<T1>> PublicGetContentBulkByShareCodesV2Async<T1>(PublicGetContentBulkByShareCodesV2 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public PublicGetContentByShareCodeV2.Response PublicGetContentByShareCodeV2(PublicGetContentByShareCodeV2 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicGetContentByShareCodeV2.Response> PublicGetContentByShareCodeV2Async(PublicGetContentByShareCodeV2 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public PublicGetContentByShareCodeV2.Response<T1> PublicGetContentByShareCodeV2<T1>(PublicGetContentByShareCodeV2 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicGetContentByShareCodeV2.Response<T1>> PublicGetContentByShareCodeV2Async<T1>(PublicGetContentByShareCodeV2 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public PublicGetContentByIDV2.Response PublicGetContentByIDV2(PublicGetContentByIDV2 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicGetContentByIDV2.Response> PublicGetContentByIDV2Async(PublicGetContentByIDV2 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public PublicGetContentByIDV2.Response<T1> PublicGetContentByIDV2<T1>(PublicGetContentByIDV2 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicGetContentByIDV2.Response<T1>> PublicGetContentByIDV2Async<T1>(PublicGetContentByIDV2 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public PublicCreateContentV2.Response PublicCreateContentV2(PublicCreateContentV2 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicCreateContentV2.Response> PublicCreateContentV2Async(PublicCreateContentV2 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public PublicCreateContentV2.Response<T1> PublicCreateContentV2<T1>(PublicCreateContentV2 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicCreateContentV2.Response<T1>> PublicCreateContentV2Async<T1>(PublicCreateContentV2 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public PublicUpdateContentByShareCodeV2.Response PublicUpdateContentByShareCodeV2(PublicUpdateContentByShareCodeV2 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicUpdateContentByShareCodeV2.Response> PublicUpdateContentByShareCodeV2Async(PublicUpdateContentByShareCodeV2 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public PublicUpdateContentByShareCodeV2.Response<T1> PublicUpdateContentByShareCodeV2<T1>(PublicUpdateContentByShareCodeV2 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicUpdateContentByShareCodeV2.Response<T1>> PublicUpdateContentByShareCodeV2Async<T1>(PublicUpdateContentByShareCodeV2 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public PublicDeleteContentByShareCodeV2.Response PublicDeleteContentByShareCodeV2(PublicDeleteContentByShareCodeV2 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicDeleteContentByShareCodeV2.Response> PublicDeleteContentByShareCodeV2Async(PublicDeleteContentByShareCodeV2 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public PublicDeleteContentV2.Response PublicDeleteContentV2(PublicDeleteContentV2 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicDeleteContentV2.Response> PublicDeleteContentV2Async(PublicDeleteContentV2 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public PublicUpdateContentV2.Response PublicUpdateContentV2(PublicUpdateContentV2 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicUpdateContentV2.Response> PublicUpdateContentV2Async(PublicUpdateContentV2 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public PublicUpdateContentV2.Response<T1> PublicUpdateContentV2<T1>(PublicUpdateContentV2 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicUpdateContentV2.Response<T1>> PublicUpdateContentV2Async<T1>(PublicUpdateContentV2 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public PublicUpdateContentFileLocation.Response PublicUpdateContentFileLocation(PublicUpdateContentFileLocation input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicUpdateContentFileLocation.Response> PublicUpdateContentFileLocationAsync(PublicUpdateContentFileLocation input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public PublicUpdateContentFileLocation.Response<T1> PublicUpdateContentFileLocation<T1>(PublicUpdateContentFileLocation input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicUpdateContentFileLocation.Response<T1>> PublicUpdateContentFileLocationAsync<T1>(PublicUpdateContentFileLocation input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public UpdateContentShareCodeV2.Response UpdateContentShareCodeV2(UpdateContentShareCodeV2 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<UpdateContentShareCodeV2.Response> UpdateContentShareCodeV2Async(UpdateContentShareCodeV2 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public UpdateContentShareCodeV2.Response<T1> UpdateContentShareCodeV2<T1>(UpdateContentShareCodeV2 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<UpdateContentShareCodeV2.Response<T1>> UpdateContentShareCodeV2Async<T1>(UpdateContentShareCodeV2 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public PublicGenerateContentUploadURLV2.Response PublicGenerateContentUploadURLV2(PublicGenerateContentUploadURLV2 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicGenerateContentUploadURLV2.Response> PublicGenerateContentUploadURLV2Async(PublicGenerateContentUploadURLV2 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public PublicGetContentByUserIDV2.Response PublicGetContentByUserIDV2(PublicGetContentByUserIDV2 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicGetContentByUserIDV2.Response> PublicGetContentByUserIDV2Async(PublicGetContentByUserIDV2 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public UpdateScreenshotsV2.Response UpdateScreenshotsV2(UpdateScreenshotsV2 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<UpdateScreenshotsV2.Response> UpdateScreenshotsV2Async(UpdateScreenshotsV2 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public UploadContentScreenshotV2.Response UploadContentScreenshotV2(UploadContentScreenshotV2 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<UploadContentScreenshotV2.Response> UploadContentScreenshotV2Async(UploadContentScreenshotV2 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public DeleteContentScreenshotV2.Response DeleteContentScreenshotV2(DeleteContentScreenshotV2 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<DeleteContentScreenshotV2.Response> DeleteContentScreenshotV2Async(DeleteContentScreenshotV2 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}