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
    public class AdminContent
    {
        private readonly IAccelByteSdk _sdk;

        public AdminContent(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public AdminUploadContentDirect.AdminUploadContentDirectBuilder AdminUploadContentDirectOp
        {
            get { return new Operation.AdminUploadContentDirect.AdminUploadContentDirectBuilder(_sdk); }
        }
        public AdminUploadContentS3.AdminUploadContentS3Builder AdminUploadContentS3Op
        {
            get { return new Operation.AdminUploadContentS3.AdminUploadContentS3Builder(_sdk); }
        }
        public SingleAdminUpdateContentS3.SingleAdminUpdateContentS3Builder SingleAdminUpdateContentS3Op
        {
            get { return new Operation.SingleAdminUpdateContentS3.SingleAdminUpdateContentS3Builder(_sdk); }
        }
        public AdminSearchChannelSpecificContent.AdminSearchChannelSpecificContentBuilder AdminSearchChannelSpecificContentOp
        {
            get { return new Operation.AdminSearchChannelSpecificContent.AdminSearchChannelSpecificContentBuilder(_sdk); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public SingleAdminUpdateContentDirect.SingleAdminUpdateContentDirectBuilder SingleAdminUpdateContentDirectOp
        {
            get { return new Operation.SingleAdminUpdateContentDirect.SingleAdminUpdateContentDirectBuilder(_sdk); }
        }
        public SingleAdminDeleteContent.SingleAdminDeleteContentBuilder SingleAdminDeleteContentOp
        {
            get { return new Operation.SingleAdminDeleteContent.SingleAdminDeleteContentBuilder(_sdk); }
        }
        public SingleAdminGetContent.SingleAdminGetContentBuilder SingleAdminGetContentOp
        {
            get { return new Operation.SingleAdminGetContent.SingleAdminGetContentBuilder(_sdk); }
        }
        public AdminGetContentBulk.AdminGetContentBulkBuilder AdminGetContentBulkOp
        {
            get { return new Operation.AdminGetContentBulk.AdminGetContentBulkBuilder(_sdk); }
        }
        public AdminSearchContent.AdminSearchContentBuilder AdminSearchContentOp
        {
            get { return new Operation.AdminSearchContent.AdminSearchContentBuilder(_sdk); }
        }
        public AdminGetUserContentByShareCode.AdminGetUserContentByShareCodeBuilder AdminGetUserContentByShareCodeOp
        {
            get { return new Operation.AdminGetUserContentByShareCode.AdminGetUserContentByShareCodeBuilder(_sdk); }
        }
        public AdminGetSpecificContent.AdminGetSpecificContentBuilder AdminGetSpecificContentOp
        {
            get { return new Operation.AdminGetSpecificContent.AdminGetSpecificContentBuilder(_sdk); }
        }
        public AdminDownloadContentPreview.AdminDownloadContentPreviewBuilder AdminDownloadContentPreviewOp
        {
            get { return new Operation.AdminDownloadContentPreview.AdminDownloadContentPreviewBuilder(_sdk); }
        }
        public AdminUpdateScreenshots.AdminUpdateScreenshotsBuilder AdminUpdateScreenshotsOp
        {
            get { return new Operation.AdminUpdateScreenshots.AdminUpdateScreenshotsBuilder(_sdk); }
        }
        public AdminUploadContentScreenshot.AdminUploadContentScreenshotBuilder AdminUploadContentScreenshotOp
        {
            get { return new Operation.AdminUploadContentScreenshot.AdminUploadContentScreenshotBuilder(_sdk); }
        }
        public AdminDeleteContentScreenshot.AdminDeleteContentScreenshotBuilder AdminDeleteContentScreenshotOp
        {
            get { return new Operation.AdminDeleteContentScreenshot.AdminDeleteContentScreenshotBuilder(_sdk); }
        }
        public AdminUpdateContentS3.AdminUpdateContentS3Builder AdminUpdateContentS3Op
        {
            get { return new Operation.AdminUpdateContentS3.AdminUpdateContentS3Builder(_sdk); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public AdminUpdateContentDirect.AdminUpdateContentDirectBuilder AdminUpdateContentDirectOp
        {
            get { return new Operation.AdminUpdateContentDirect.AdminUpdateContentDirectBuilder(_sdk); }
        }
        public AdminDeleteContent.AdminDeleteContentBuilder AdminDeleteContentOp
        {
            get { return new Operation.AdminDeleteContent.AdminDeleteContentBuilder(_sdk); }
        }
        public AdminGetContent.AdminGetContentBuilder AdminGetContentOp
        {
            get { return new Operation.AdminGetContent.AdminGetContentBuilder(_sdk); }
        }
        public AdminHideUserContent.AdminHideUserContentBuilder AdminHideUserContentOp
        {
            get { return new Operation.AdminHideUserContent.AdminHideUserContentBuilder(_sdk); }
        }
        #endregion
        
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public Model.ModelsCreateContentResponse? AdminUploadContentDirect(AdminUploadContentDirect input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        
        public Model.ModelsCreateContentResponse<T1>? AdminUploadContentDirect<T1>(AdminUploadContentDirect input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        public Model.ModelsCreateContentResponse? AdminUploadContentS3(AdminUploadContentS3 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        
        public Model.ModelsCreateContentResponse<T1>? AdminUploadContentS3<T1>(AdminUploadContentS3 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsCreateContentResponse? SingleAdminUpdateContentS3(SingleAdminUpdateContentS3 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        
        public Model.ModelsCreateContentResponse<T1>? SingleAdminUpdateContentS3<T1>(SingleAdminUpdateContentS3 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPaginatedContentDownloadResponse? AdminSearchChannelSpecificContent(AdminSearchChannelSpecificContent input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public Model.ModelsCreateContentResponse? SingleAdminUpdateContentDirect(SingleAdminUpdateContentDirect input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        
        public Model.ModelsCreateContentResponse<T1>? SingleAdminUpdateContentDirect<T1>(SingleAdminUpdateContentDirect input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        public void SingleAdminDeleteContent(SingleAdminDeleteContent input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPaginatedContentDownloadResponse? SingleAdminGetContent(SingleAdminGetContent input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ModelsContentDownloadResponse>? AdminGetContentBulk(AdminGetContentBulk input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        
        public List<Model.ModelsContentDownloadResponse<T1>>? AdminGetContentBulk<T1>(AdminGetContentBulk input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPaginatedContentDownloadResponse? AdminSearchContent(AdminSearchContent input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsContentDownloadResponse? AdminGetUserContentByShareCode(AdminGetUserContentByShareCode input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        
        public Model.ModelsContentDownloadResponse<T1>? AdminGetUserContentByShareCode<T1>(AdminGetUserContentByShareCode input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsContentDownloadResponse? AdminGetSpecificContent(AdminGetSpecificContent input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        
        public Model.ModelsContentDownloadResponse<T1>? AdminGetSpecificContent<T1>(AdminGetSpecificContent input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetContentPreviewResponse? AdminDownloadContentPreview(AdminDownloadContentPreview input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsUpdateScreenshotResponse? AdminUpdateScreenshots(AdminUpdateScreenshots input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsCreateScreenshotResponse? AdminUploadContentScreenshot(AdminUploadContentScreenshot input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDeleteContentScreenshot(AdminDeleteContentScreenshot input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsCreateContentResponse? AdminUpdateContentS3(AdminUpdateContentS3 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        
        public Model.ModelsCreateContentResponse<T1>? AdminUpdateContentS3<T1>(AdminUpdateContentS3 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public Model.ModelsCreateContentResponse? AdminUpdateContentDirect(AdminUpdateContentDirect input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        
        public Model.ModelsCreateContentResponse<T1>? AdminUpdateContentDirect<T1>(AdminUpdateContentDirect input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        public void AdminDeleteContent(AdminDeleteContent input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPaginatedContentDownloadResponse? AdminGetContent(AdminGetContent input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsCreateContentResponse? AdminHideUserContent(AdminHideUserContent input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        
        public Model.ModelsCreateContentResponse<T1>? AdminHideUserContent<T1>(AdminHideUserContent input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}