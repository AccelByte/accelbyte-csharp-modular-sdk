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

using AccelByte.Sdk.Api.Cloudsave.Model;
using AccelByte.Sdk.Api.Cloudsave.Operation;

namespace AccelByte.Sdk.Api.Cloudsave.Wrapper
{
    public class ConcurrentRecord
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public ConcurrentRecord(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public ConcurrentRecord(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        public PutGameRecordConcurrentHandlerV1.PutGameRecordConcurrentHandlerV1Builder PutGameRecordConcurrentHandlerV1Op
        {
            get
            {
                var opBuilder = new Operation.PutGameRecordConcurrentHandlerV1.PutGameRecordConcurrentHandlerV1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PutPlayerRecordConcurrentHandlerV1.PutPlayerRecordConcurrentHandlerV1Builder PutPlayerRecordConcurrentHandlerV1Op
        {
            get
            {
                var opBuilder = new Operation.PutPlayerRecordConcurrentHandlerV1.PutPlayerRecordConcurrentHandlerV1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PutPlayerPublicRecordConcurrentHandlerV1.PutPlayerPublicRecordConcurrentHandlerV1Builder PutPlayerPublicRecordConcurrentHandlerV1Op
        {
            get
            {
                var opBuilder = new Operation.PutPlayerPublicRecordConcurrentHandlerV1.PutPlayerPublicRecordConcurrentHandlerV1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

        public void PutGameRecordConcurrentHandlerV1(PutGameRecordConcurrentHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task PutGameRecordConcurrentHandlerV1Async(PutGameRecordConcurrentHandlerV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPlayerRecordConcurrentUpdateResponse? PutPlayerRecordConcurrentHandlerV1(PutPlayerRecordConcurrentHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsPlayerRecordConcurrentUpdateResponse?> PutPlayerRecordConcurrentHandlerV1Async(PutPlayerRecordConcurrentHandlerV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPlayerRecordConcurrentUpdateResponse? PutPlayerPublicRecordConcurrentHandlerV1(PutPlayerPublicRecordConcurrentHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsPlayerRecordConcurrentUpdateResponse?> PutPlayerPublicRecordConcurrentHandlerV1Async(PutPlayerPublicRecordConcurrentHandlerV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}