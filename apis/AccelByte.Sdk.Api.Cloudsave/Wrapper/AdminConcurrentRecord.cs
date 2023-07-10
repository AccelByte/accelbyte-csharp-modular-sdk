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
    public class AdminConcurrentRecord
    {
        private readonly IAccelByteSdk _sdk;

        public AdminConcurrentRecord(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminPutGameRecordConcurrentHandlerV1.AdminPutGameRecordConcurrentHandlerV1Builder AdminPutGameRecordConcurrentHandlerV1Op
        {
            get { return new Operation.AdminPutGameRecordConcurrentHandlerV1.AdminPutGameRecordConcurrentHandlerV1Builder(_sdk); }
        }
        public AdminPutPlayerRecordConcurrentHandlerV1.AdminPutPlayerRecordConcurrentHandlerV1Builder AdminPutPlayerRecordConcurrentHandlerV1Op
        {
            get { return new Operation.AdminPutPlayerRecordConcurrentHandlerV1.AdminPutPlayerRecordConcurrentHandlerV1Builder(_sdk); }
        }
        public AdminPutPlayerPublicRecordConcurrentHandlerV1.AdminPutPlayerPublicRecordConcurrentHandlerV1Builder AdminPutPlayerPublicRecordConcurrentHandlerV1Op
        {
            get { return new Operation.AdminPutPlayerPublicRecordConcurrentHandlerV1.AdminPutPlayerPublicRecordConcurrentHandlerV1Builder(_sdk); }
        }
        #endregion

        public void AdminPutGameRecordConcurrentHandlerV1(AdminPutGameRecordConcurrentHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AdminPutPlayerRecordConcurrentHandlerV1(AdminPutPlayerRecordConcurrentHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AdminPutPlayerPublicRecordConcurrentHandlerV1(AdminPutPlayerPublicRecordConcurrentHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}