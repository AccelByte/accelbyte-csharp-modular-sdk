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
    public class AdminPlayerBinaryRecord
    {
        private readonly IAccelByteSdk _sdk;

        public AdminPlayerBinaryRecord(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminListPlayerBinaryRecordsV1.AdminListPlayerBinaryRecordsV1Builder AdminListPlayerBinaryRecordsV1Op
        {
            get { return new Operation.AdminListPlayerBinaryRecordsV1.AdminListPlayerBinaryRecordsV1Builder(_sdk); }
        }
        public AdminPostPlayerBinaryRecordV1.AdminPostPlayerBinaryRecordV1Builder AdminPostPlayerBinaryRecordV1Op
        {
            get { return new Operation.AdminPostPlayerBinaryRecordV1.AdminPostPlayerBinaryRecordV1Builder(_sdk); }
        }
        public AdminGetPlayerBinaryRecordV1.AdminGetPlayerBinaryRecordV1Builder AdminGetPlayerBinaryRecordV1Op
        {
            get { return new Operation.AdminGetPlayerBinaryRecordV1.AdminGetPlayerBinaryRecordV1Builder(_sdk); }
        }
        public AdminPutPlayerBinaryRecordV1.AdminPutPlayerBinaryRecordV1Builder AdminPutPlayerBinaryRecordV1Op
        {
            get { return new Operation.AdminPutPlayerBinaryRecordV1.AdminPutPlayerBinaryRecordV1Builder(_sdk); }
        }
        public AdminDeletePlayerBinaryRecordV1.AdminDeletePlayerBinaryRecordV1Builder AdminDeletePlayerBinaryRecordV1Op
        {
            get { return new Operation.AdminDeletePlayerBinaryRecordV1.AdminDeletePlayerBinaryRecordV1Builder(_sdk); }
        }
        public AdminPutPlayerBinaryRecorMetadataV1.AdminPutPlayerBinaryRecorMetadataV1Builder AdminPutPlayerBinaryRecorMetadataV1Op
        {
            get { return new Operation.AdminPutPlayerBinaryRecorMetadataV1.AdminPutPlayerBinaryRecorMetadataV1Builder(_sdk); }
        }
        public AdminPostPlayerBinaryPresignedURLV1.AdminPostPlayerBinaryPresignedURLV1Builder AdminPostPlayerBinaryPresignedURLV1Op
        {
            get { return new Operation.AdminPostPlayerBinaryPresignedURLV1.AdminPostPlayerBinaryPresignedURLV1Builder(_sdk); }
        }
        #endregion

        public Model.ModelsListPlayerBinaryRecordsResponse? AdminListPlayerBinaryRecordsV1(AdminListPlayerBinaryRecordsV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsUploadBinaryRecordResponse? AdminPostPlayerBinaryRecordV1(AdminPostPlayerBinaryRecordV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPlayerBinaryRecordResponse? AdminGetPlayerBinaryRecordV1(AdminGetPlayerBinaryRecordV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPlayerBinaryRecordResponse? AdminPutPlayerBinaryRecordV1(AdminPutPlayerBinaryRecordV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDeletePlayerBinaryRecordV1(AdminDeletePlayerBinaryRecordV1 input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPlayerBinaryRecordResponse? AdminPutPlayerBinaryRecorMetadataV1(AdminPutPlayerBinaryRecorMetadataV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsUploadBinaryRecordResponse? AdminPostPlayerBinaryPresignedURLV1(AdminPostPlayerBinaryPresignedURLV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}