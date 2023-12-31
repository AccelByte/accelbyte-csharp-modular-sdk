// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Api.Ugc.Operation;

namespace AccelByte.Sdk.Api.Ugc.Wrapper
{
    public class AdminContentV2
    {
        private readonly IAccelByteSdk _sdk;

        public AdminContentV2(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminGetContentByChannelIDV2.AdminGetContentByChannelIDV2Builder AdminGetContentByChannelIDV2Op
        {
            get { return new Operation.AdminGetContentByChannelIDV2.AdminGetContentByChannelIDV2Builder(_sdk); }
        }
        public AdminCreateContentV2.AdminCreateContentV2Builder AdminCreateContentV2Op
        {
            get { return new Operation.AdminCreateContentV2.AdminCreateContentV2Builder(_sdk); }
        }
        public AdminDeleteOfficialContentV2.AdminDeleteOfficialContentV2Builder AdminDeleteOfficialContentV2Op
        {
            get { return new Operation.AdminDeleteOfficialContentV2.AdminDeleteOfficialContentV2Builder(_sdk); }
        }
        public AdminUpdateOfficialContentV2.AdminUpdateOfficialContentV2Builder AdminUpdateOfficialContentV2Op
        {
            get { return new Operation.AdminUpdateOfficialContentV2.AdminUpdateOfficialContentV2Builder(_sdk); }
        }
        public AdminUpdateOfficialContentFileLocation.AdminUpdateOfficialContentFileLocationBuilder AdminUpdateOfficialContentFileLocationOp
        {
            get { return new Operation.AdminUpdateOfficialContentFileLocation.AdminUpdateOfficialContentFileLocationBuilder(_sdk); }
        }
        public AdminGenerateOfficialContentUploadURLV2.AdminGenerateOfficialContentUploadURLV2Builder AdminGenerateOfficialContentUploadURLV2Op
        {
            get { return new Operation.AdminGenerateOfficialContentUploadURLV2.AdminGenerateOfficialContentUploadURLV2Builder(_sdk); }
        }
        public AdminListContentV2.AdminListContentV2Builder AdminListContentV2Op
        {
            get { return new Operation.AdminListContentV2.AdminListContentV2Builder(_sdk); }
        }
        public AdminBulkGetContentByIDsV2.AdminBulkGetContentByIDsV2Builder AdminBulkGetContentByIDsV2Op
        {
            get { return new Operation.AdminBulkGetContentByIDsV2.AdminBulkGetContentByIDsV2Builder(_sdk); }
        }
        public AdminGetContentBulkByShareCodesV2.AdminGetContentBulkByShareCodesV2Builder AdminGetContentBulkByShareCodesV2Op
        {
            get { return new Operation.AdminGetContentBulkByShareCodesV2.AdminGetContentBulkByShareCodesV2Builder(_sdk); }
        }
        public AdminGetContentByShareCodeV2.AdminGetContentByShareCodeV2Builder AdminGetContentByShareCodeV2Op
        {
            get { return new Operation.AdminGetContentByShareCodeV2.AdminGetContentByShareCodeV2Builder(_sdk); }
        }
        public AdminGetContentByContentIDV2.AdminGetContentByContentIDV2Builder AdminGetContentByContentIDV2Op
        {
            get { return new Operation.AdminGetContentByContentIDV2.AdminGetContentByContentIDV2Builder(_sdk); }
        }
        public RollbackContentVersionV2.RollbackContentVersionV2Builder RollbackContentVersionV2Op
        {
            get { return new Operation.RollbackContentVersionV2.RollbackContentVersionV2Builder(_sdk); }
        }
        public AdminUpdateScreenshotsV2.AdminUpdateScreenshotsV2Builder AdminUpdateScreenshotsV2Op
        {
            get { return new Operation.AdminUpdateScreenshotsV2.AdminUpdateScreenshotsV2Builder(_sdk); }
        }
        public AdminUploadContentScreenshotV2.AdminUploadContentScreenshotV2Builder AdminUploadContentScreenshotV2Op
        {
            get { return new Operation.AdminUploadContentScreenshotV2.AdminUploadContentScreenshotV2Builder(_sdk); }
        }
        public AdminDeleteContentScreenshotV2.AdminDeleteContentScreenshotV2Builder AdminDeleteContentScreenshotV2Op
        {
            get { return new Operation.AdminDeleteContentScreenshotV2.AdminDeleteContentScreenshotV2Builder(_sdk); }
        }
        public ListContentVersionsV2.ListContentVersionsV2Builder ListContentVersionsV2Op
        {
            get { return new Operation.ListContentVersionsV2.ListContentVersionsV2Builder(_sdk); }
        }
        public AdminUpdateContentByShareCodeV2.AdminUpdateContentByShareCodeV2Builder AdminUpdateContentByShareCodeV2Op
        {
            get { return new Operation.AdminUpdateContentByShareCodeV2.AdminUpdateContentByShareCodeV2Builder(_sdk); }
        }
        public AdminDeleteContentByShareCodeV2.AdminDeleteContentByShareCodeV2Builder AdminDeleteContentByShareCodeV2Op
        {
            get { return new Operation.AdminDeleteContentByShareCodeV2.AdminDeleteContentByShareCodeV2Builder(_sdk); }
        }
        public AdminDeleteUserContentV2.AdminDeleteUserContentV2Builder AdminDeleteUserContentV2Op
        {
            get { return new Operation.AdminDeleteUserContentV2.AdminDeleteUserContentV2Builder(_sdk); }
        }
        public AdminUpdateUserContentV2.AdminUpdateUserContentV2Builder AdminUpdateUserContentV2Op
        {
            get { return new Operation.AdminUpdateUserContentV2.AdminUpdateUserContentV2Builder(_sdk); }
        }
        public AdminUpdateUserContentFileLocation.AdminUpdateUserContentFileLocationBuilder AdminUpdateUserContentFileLocationOp
        {
            get { return new Operation.AdminUpdateUserContentFileLocation.AdminUpdateUserContentFileLocationBuilder(_sdk); }
        }
        public AdminGenerateUserContentUploadURLV2.AdminGenerateUserContentUploadURLV2Builder AdminGenerateUserContentUploadURLV2Op
        {
            get { return new Operation.AdminGenerateUserContentUploadURLV2.AdminGenerateUserContentUploadURLV2Builder(_sdk); }
        }
        public AdminGetContentByUserIDV2.AdminGetContentByUserIDV2Builder AdminGetContentByUserIDV2Op
        {
            get { return new Operation.AdminGetContentByUserIDV2.AdminGetContentByUserIDV2Builder(_sdk); }
        }
        public AdminUpdateContentHideStatusV2.AdminUpdateContentHideStatusV2Builder AdminUpdateContentHideStatusV2Op
        {
            get { return new Operation.AdminUpdateContentHideStatusV2.AdminUpdateContentHideStatusV2Builder(_sdk); }
        }
        #endregion

        public Model.ModelsPaginatedContentDownloadResponseV2? AdminGetContentByChannelIDV2(AdminGetContentByChannelIDV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsCreateContentResponseV2? AdminCreateContentV2(AdminCreateContentV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ModelsCreateContentResponseV2<T1>? AdminCreateContentV2<T1>(AdminCreateContentV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDeleteOfficialContentV2(AdminDeleteOfficialContentV2 input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsUpdateContentResponseV2? AdminUpdateOfficialContentV2(AdminUpdateOfficialContentV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ModelsUpdateContentResponseV2<T1>? AdminUpdateOfficialContentV2<T1>(AdminUpdateOfficialContentV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsUpdateContentResponseV2? AdminUpdateOfficialContentFileLocation(AdminUpdateOfficialContentFileLocation input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ModelsUpdateContentResponseV2<T1>? AdminUpdateOfficialContentFileLocation<T1>(AdminUpdateOfficialContentFileLocation input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGenerateContentUploadURLResponse? AdminGenerateOfficialContentUploadURLV2(AdminGenerateOfficialContentUploadURLV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPaginatedContentDownloadResponseV2? AdminListContentV2(AdminListContentV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ModelsContentDownloadResponseV2>? AdminBulkGetContentByIDsV2(AdminBulkGetContentByIDsV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public List<Model.ModelsContentDownloadResponseV2<T1>>? AdminBulkGetContentByIDsV2<T1>(AdminBulkGetContentByIDsV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ModelsContentDownloadResponseV2>? AdminGetContentBulkByShareCodesV2(AdminGetContentBulkByShareCodesV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public List<Model.ModelsContentDownloadResponseV2<T1>>? AdminGetContentBulkByShareCodesV2<T1>(AdminGetContentBulkByShareCodesV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsContentDownloadResponseV2? AdminGetContentByShareCodeV2(AdminGetContentByShareCodeV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ModelsContentDownloadResponseV2<T1>? AdminGetContentByShareCodeV2<T1>(AdminGetContentByShareCodeV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsContentDownloadResponseV2? AdminGetContentByContentIDV2(AdminGetContentByContentIDV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ModelsContentDownloadResponseV2<T1>? AdminGetContentByContentIDV2<T1>(AdminGetContentByContentIDV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsContentDownloadResponse? RollbackContentVersionV2(RollbackContentVersionV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ModelsContentDownloadResponse<T1>? RollbackContentVersionV2<T1>(RollbackContentVersionV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsUpdateScreenshotResponse? AdminUpdateScreenshotsV2(AdminUpdateScreenshotsV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsCreateScreenshotResponse? AdminUploadContentScreenshotV2(AdminUploadContentScreenshotV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDeleteContentScreenshotV2(AdminDeleteContentScreenshotV2 input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsListContentVersionsResponse? ListContentVersionsV2(ListContentVersionsV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsCreateContentResponseV2? AdminUpdateContentByShareCodeV2(AdminUpdateContentByShareCodeV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ModelsCreateContentResponseV2<T1>? AdminUpdateContentByShareCodeV2<T1>(AdminUpdateContentByShareCodeV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDeleteContentByShareCodeV2(AdminDeleteContentByShareCodeV2 input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDeleteUserContentV2(AdminDeleteUserContentV2 input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsUpdateContentResponseV2? AdminUpdateUserContentV2(AdminUpdateUserContentV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ModelsUpdateContentResponseV2<T1>? AdminUpdateUserContentV2<T1>(AdminUpdateUserContentV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsUpdateContentResponseV2? AdminUpdateUserContentFileLocation(AdminUpdateUserContentFileLocation input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ModelsUpdateContentResponseV2<T1>? AdminUpdateUserContentFileLocation<T1>(AdminUpdateUserContentFileLocation input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGenerateContentUploadURLResponse? AdminGenerateUserContentUploadURLV2(AdminGenerateUserContentUploadURLV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPaginatedContentDownloadResponseV2? AdminGetContentByUserIDV2(AdminGetContentByUserIDV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsCreateContentResponseV2? AdminUpdateContentHideStatusV2(AdminUpdateContentHideStatusV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ModelsCreateContentResponseV2<T1>? AdminUpdateContentHideStatusV2<T1>(AdminUpdateContentHideStatusV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}