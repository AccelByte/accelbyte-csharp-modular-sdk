// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Cloudsave.Model;
using AccelByte.Sdk.Api.Cloudsave.Operation;

namespace AccelByte.Sdk.Api.Cloudsave.Wrapper
{
    public class AdminGameBinaryRecord
    {
        private readonly IAccelByteSdk _sdk;

        public AdminGameBinaryRecord(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminListGameBinaryRecordsV1.AdminListGameBinaryRecordsV1Builder AdminListGameBinaryRecordsV1Op
        {
            get { return new Operation.AdminListGameBinaryRecordsV1.AdminListGameBinaryRecordsV1Builder(_sdk); }
        }
        public AdminPostGameBinaryRecordV1.AdminPostGameBinaryRecordV1Builder AdminPostGameBinaryRecordV1Op
        {
            get { return new Operation.AdminPostGameBinaryRecordV1.AdminPostGameBinaryRecordV1Builder(_sdk); }
        }
        public AdminGetGameBinaryRecordV1.AdminGetGameBinaryRecordV1Builder AdminGetGameBinaryRecordV1Op
        {
            get { return new Operation.AdminGetGameBinaryRecordV1.AdminGetGameBinaryRecordV1Builder(_sdk); }
        }
        public AdminPutGameBinaryRecordV1.AdminPutGameBinaryRecordV1Builder AdminPutGameBinaryRecordV1Op
        {
            get { return new Operation.AdminPutGameBinaryRecordV1.AdminPutGameBinaryRecordV1Builder(_sdk); }
        }
        public AdminDeleteGameBinaryRecordV1.AdminDeleteGameBinaryRecordV1Builder AdminDeleteGameBinaryRecordV1Op
        {
            get { return new Operation.AdminDeleteGameBinaryRecordV1.AdminDeleteGameBinaryRecordV1Builder(_sdk); }
        }
        public AdminPutGameBinaryRecorMetadataV1.AdminPutGameBinaryRecorMetadataV1Builder AdminPutGameBinaryRecorMetadataV1Op
        {
            get { return new Operation.AdminPutGameBinaryRecorMetadataV1.AdminPutGameBinaryRecorMetadataV1Builder(_sdk); }
        }
        public AdminPostGameBinaryPresignedURLV1.AdminPostGameBinaryPresignedURLV1Builder AdminPostGameBinaryPresignedURLV1Op
        {
            get { return new Operation.AdminPostGameBinaryPresignedURLV1.AdminPostGameBinaryPresignedURLV1Builder(_sdk); }
        }
        #endregion

        public Model.ModelsListGameBinaryRecordsAdminResponse? AdminListGameBinaryRecordsV1(AdminListGameBinaryRecordsV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsUploadBinaryRecordResponse? AdminPostGameBinaryRecordV1(AdminPostGameBinaryRecordV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGameBinaryRecordAdminResponse? AdminGetGameBinaryRecordV1(AdminGetGameBinaryRecordV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGameBinaryRecordAdminResponse? AdminPutGameBinaryRecordV1(AdminPutGameBinaryRecordV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDeleteGameBinaryRecordV1(AdminDeleteGameBinaryRecordV1 input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGameBinaryRecordAdminResponse? AdminPutGameBinaryRecorMetadataV1(AdminPutGameBinaryRecorMetadataV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsUploadBinaryRecordResponse? AdminPostGameBinaryPresignedURLV1(AdminPostGameBinaryPresignedURLV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}