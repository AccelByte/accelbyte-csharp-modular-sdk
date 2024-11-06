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
    public class AdminConcurrentRecord
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public AdminConcurrentRecord(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public AdminConcurrentRecord(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        public AdminPutAdminGameRecordConcurrentHandlerV1.AdminPutAdminGameRecordConcurrentHandlerV1Builder AdminPutAdminGameRecordConcurrentHandlerV1Op
        {
            get
            {
                var opBuilder = new Operation.AdminPutAdminGameRecordConcurrentHandlerV1.AdminPutAdminGameRecordConcurrentHandlerV1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminPutGameRecordConcurrentHandlerV1.AdminPutGameRecordConcurrentHandlerV1Builder AdminPutGameRecordConcurrentHandlerV1Op
        {
            get
            {
                var opBuilder = new Operation.AdminPutGameRecordConcurrentHandlerV1.AdminPutGameRecordConcurrentHandlerV1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminPutAdminPlayerRecordConcurrentHandlerV1.AdminPutAdminPlayerRecordConcurrentHandlerV1Builder AdminPutAdminPlayerRecordConcurrentHandlerV1Op
        {
            get
            {
                var opBuilder = new Operation.AdminPutAdminPlayerRecordConcurrentHandlerV1.AdminPutAdminPlayerRecordConcurrentHandlerV1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminPutPlayerRecordConcurrentHandlerV1.AdminPutPlayerRecordConcurrentHandlerV1Builder AdminPutPlayerRecordConcurrentHandlerV1Op
        {
            get
            {
                var opBuilder = new Operation.AdminPutPlayerRecordConcurrentHandlerV1.AdminPutPlayerRecordConcurrentHandlerV1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminPutPlayerPublicRecordConcurrentHandlerV1.AdminPutPlayerPublicRecordConcurrentHandlerV1Builder AdminPutPlayerPublicRecordConcurrentHandlerV1Op
        {
            get
            {
                var opBuilder = new Operation.AdminPutPlayerPublicRecordConcurrentHandlerV1.AdminPutPlayerPublicRecordConcurrentHandlerV1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

        public AdminPutAdminGameRecordConcurrentHandlerV1.Response AdminPutAdminGameRecordConcurrentHandlerV1(AdminPutAdminGameRecordConcurrentHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminPutAdminGameRecordConcurrentHandlerV1.Response> AdminPutAdminGameRecordConcurrentHandlerV1Async(AdminPutAdminGameRecordConcurrentHandlerV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminPutGameRecordConcurrentHandlerV1.Response AdminPutGameRecordConcurrentHandlerV1(AdminPutGameRecordConcurrentHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminPutGameRecordConcurrentHandlerV1.Response> AdminPutGameRecordConcurrentHandlerV1Async(AdminPutGameRecordConcurrentHandlerV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminPutAdminPlayerRecordConcurrentHandlerV1.Response AdminPutAdminPlayerRecordConcurrentHandlerV1(AdminPutAdminPlayerRecordConcurrentHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminPutAdminPlayerRecordConcurrentHandlerV1.Response> AdminPutAdminPlayerRecordConcurrentHandlerV1Async(AdminPutAdminPlayerRecordConcurrentHandlerV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminPutPlayerRecordConcurrentHandlerV1.Response AdminPutPlayerRecordConcurrentHandlerV1(AdminPutPlayerRecordConcurrentHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminPutPlayerRecordConcurrentHandlerV1.Response> AdminPutPlayerRecordConcurrentHandlerV1Async(AdminPutPlayerRecordConcurrentHandlerV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminPutPlayerPublicRecordConcurrentHandlerV1.Response AdminPutPlayerPublicRecordConcurrentHandlerV1(AdminPutPlayerPublicRecordConcurrentHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminPutPlayerPublicRecordConcurrentHandlerV1.Response> AdminPutPlayerPublicRecordConcurrentHandlerV1Async(AdminPutPlayerPublicRecordConcurrentHandlerV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}