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
    public class AdminPlayerRecord
    {
        private readonly IAccelByteSdk _sdk;

        public AdminPlayerRecord(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public BulkGetPlayerRecordSizeHandlerV1.BulkGetPlayerRecordSizeHandlerV1Builder BulkGetPlayerRecordSizeHandlerV1Op
        {
            get { return new Operation.BulkGetPlayerRecordSizeHandlerV1.BulkGetPlayerRecordSizeHandlerV1Builder(_sdk); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public ListPlayerRecordHandlerV1.ListPlayerRecordHandlerV1Builder ListPlayerRecordHandlerV1Op
        {
            get { return new Operation.ListPlayerRecordHandlerV1.ListPlayerRecordHandlerV1Builder(_sdk); }
        }
        public AdminRetrievePlayerRecords.AdminRetrievePlayerRecordsBuilder AdminRetrievePlayerRecordsOp
        {
            get { return new Operation.AdminRetrievePlayerRecords.AdminRetrievePlayerRecordsBuilder(_sdk); }
        }
        public AdminGetPlayerRecordHandlerV1.AdminGetPlayerRecordHandlerV1Builder AdminGetPlayerRecordHandlerV1Op
        {
            get { return new Operation.AdminGetPlayerRecordHandlerV1.AdminGetPlayerRecordHandlerV1Builder(_sdk); }
        }
        public AdminPutPlayerRecordHandlerV1.AdminPutPlayerRecordHandlerV1Builder AdminPutPlayerRecordHandlerV1Op
        {
            get { return new Operation.AdminPutPlayerRecordHandlerV1.AdminPutPlayerRecordHandlerV1Builder(_sdk); }
        }
        public AdminPostPlayerRecordHandlerV1.AdminPostPlayerRecordHandlerV1Builder AdminPostPlayerRecordHandlerV1Op
        {
            get { return new Operation.AdminPostPlayerRecordHandlerV1.AdminPostPlayerRecordHandlerV1Builder(_sdk); }
        }
        public AdminDeletePlayerRecordHandlerV1.AdminDeletePlayerRecordHandlerV1Builder AdminDeletePlayerRecordHandlerV1Op
        {
            get { return new Operation.AdminDeletePlayerRecordHandlerV1.AdminDeletePlayerRecordHandlerV1Builder(_sdk); }
        }
        public AdminGetPlayerPublicRecordHandlerV1.AdminGetPlayerPublicRecordHandlerV1Builder AdminGetPlayerPublicRecordHandlerV1Op
        {
            get { return new Operation.AdminGetPlayerPublicRecordHandlerV1.AdminGetPlayerPublicRecordHandlerV1Builder(_sdk); }
        }
        public AdminPutPlayerPublicRecordHandlerV1.AdminPutPlayerPublicRecordHandlerV1Builder AdminPutPlayerPublicRecordHandlerV1Op
        {
            get { return new Operation.AdminPutPlayerPublicRecordHandlerV1.AdminPutPlayerPublicRecordHandlerV1Builder(_sdk); }
        }
        public AdminPostPlayerPublicRecordHandlerV1.AdminPostPlayerPublicRecordHandlerV1Builder AdminPostPlayerPublicRecordHandlerV1Op
        {
            get { return new Operation.AdminPostPlayerPublicRecordHandlerV1.AdminPostPlayerPublicRecordHandlerV1Builder(_sdk); }
        }
        public AdminDeletePlayerPublicRecordHandlerV1.AdminDeletePlayerPublicRecordHandlerV1Builder AdminDeletePlayerPublicRecordHandlerV1Op
        {
            get { return new Operation.AdminDeletePlayerPublicRecordHandlerV1.AdminDeletePlayerPublicRecordHandlerV1Builder(_sdk); }
        }
        public AdminGetPlayerRecordSizeHandlerV1.AdminGetPlayerRecordSizeHandlerV1Builder AdminGetPlayerRecordSizeHandlerV1Op
        {
            get { return new Operation.AdminGetPlayerRecordSizeHandlerV1.AdminGetPlayerRecordSizeHandlerV1Builder(_sdk); }
        }
        #endregion
        
        public Model.ModelsBulkGetPlayerRecordSizeResponse? BulkGetPlayerRecordSizeHandlerV1(BulkGetPlayerRecordSizeHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public Model.ModelsListPlayerRecordKeysResponse? ListPlayerRecordHandlerV1(ListPlayerRecordHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        public Model.ModelsListPlayerRecordKeysResponse? AdminRetrievePlayerRecords(AdminRetrievePlayerRecords input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPlayerRecordResponse? AdminGetPlayerRecordHandlerV1(AdminGetPlayerRecordHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        
        public Model.ModelsPlayerRecordResponse<T1>? AdminGetPlayerRecordHandlerV1<T1>(AdminGetPlayerRecordHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPlayerRecordResponse? AdminPutPlayerRecordHandlerV1(AdminPutPlayerRecordHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        
        public Model.ModelsPlayerRecordResponse<T1>? AdminPutPlayerRecordHandlerV1<T1>(AdminPutPlayerRecordHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPlayerRecordResponse? AdminPostPlayerRecordHandlerV1(AdminPostPlayerRecordHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        
        public Model.ModelsPlayerRecordResponse<T1>? AdminPostPlayerRecordHandlerV1<T1>(AdminPostPlayerRecordHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDeletePlayerRecordHandlerV1(AdminDeletePlayerRecordHandlerV1 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPlayerRecordResponse? AdminGetPlayerPublicRecordHandlerV1(AdminGetPlayerPublicRecordHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        
        public Model.ModelsPlayerRecordResponse<T1>? AdminGetPlayerPublicRecordHandlerV1<T1>(AdminGetPlayerPublicRecordHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPlayerRecordResponse? AdminPutPlayerPublicRecordHandlerV1(AdminPutPlayerPublicRecordHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        
        public Model.ModelsPlayerRecordResponse<T1>? AdminPutPlayerPublicRecordHandlerV1<T1>(AdminPutPlayerPublicRecordHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPlayerRecordResponse? AdminPostPlayerPublicRecordHandlerV1(AdminPostPlayerPublicRecordHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        
        public Model.ModelsPlayerRecordResponse<T1>? AdminPostPlayerPublicRecordHandlerV1<T1>(AdminPostPlayerPublicRecordHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDeletePlayerPublicRecordHandlerV1(AdminDeletePlayerPublicRecordHandlerV1 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPlayerRecordSizeResponse? AdminGetPlayerRecordSizeHandlerV1(AdminGetPlayerRecordSizeHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}