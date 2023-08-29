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
    public class PublicGameRecord
    {
        private readonly IAccelByteSdk _sdk;

        public PublicGameRecord(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetGameRecordsBulk.GetGameRecordsBulkBuilder GetGameRecordsBulkOp
        {
            get { return new Operation.GetGameRecordsBulk.GetGameRecordsBulkBuilder(_sdk); }
        }
        public GetGameRecordHandlerV1.GetGameRecordHandlerV1Builder GetGameRecordHandlerV1Op
        {
            get { return new Operation.GetGameRecordHandlerV1.GetGameRecordHandlerV1Builder(_sdk); }
        }
        public PutGameRecordHandlerV1.PutGameRecordHandlerV1Builder PutGameRecordHandlerV1Op
        {
            get { return new Operation.PutGameRecordHandlerV1.PutGameRecordHandlerV1Builder(_sdk); }
        }
        public PostGameRecordHandlerV1.PostGameRecordHandlerV1Builder PostGameRecordHandlerV1Op
        {
            get { return new Operation.PostGameRecordHandlerV1.PostGameRecordHandlerV1Builder(_sdk); }
        }
        public DeleteGameRecordHandlerV1.DeleteGameRecordHandlerV1Builder DeleteGameRecordHandlerV1Op
        {
            get { return new Operation.DeleteGameRecordHandlerV1.DeleteGameRecordHandlerV1Builder(_sdk); }
        }
        #endregion
        
        public Model.ModelsBulkGetGameRecordResponse? GetGameRecordsBulk(GetGameRecordsBulk input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGameRecordResponse? GetGameRecordHandlerV1(GetGameRecordHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        
        public Model.ModelsGameRecordResponse<T1>? GetGameRecordHandlerV1<T1>(GetGameRecordHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGameRecordResponse? PutGameRecordHandlerV1(PutGameRecordHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        
        public Model.ModelsGameRecordResponse<T1>? PutGameRecordHandlerV1<T1>(PutGameRecordHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGameRecordResponse? PostGameRecordHandlerV1(PostGameRecordHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        
        public Model.ModelsGameRecordResponse<T1>? PostGameRecordHandlerV1<T1>(PostGameRecordHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteGameRecordHandlerV1(DeleteGameRecordHandlerV1 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}