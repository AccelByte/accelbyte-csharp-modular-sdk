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
    public class AdminGameRecord
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public AdminGameRecord(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public AdminGameRecord(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        public ListGameRecordsHandlerV1.ListGameRecordsHandlerV1Builder ListGameRecordsHandlerV1Op
        {
            get
            {
                var opBuilder = new Operation.ListGameRecordsHandlerV1.ListGameRecordsHandlerV1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminGetGameRecordHandlerV1.AdminGetGameRecordHandlerV1Builder AdminGetGameRecordHandlerV1Op
        {
            get
            {
                var opBuilder = new Operation.AdminGetGameRecordHandlerV1.AdminGetGameRecordHandlerV1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminPutGameRecordHandlerV1.AdminPutGameRecordHandlerV1Builder AdminPutGameRecordHandlerV1Op
        {
            get
            {
                var opBuilder = new Operation.AdminPutGameRecordHandlerV1.AdminPutGameRecordHandlerV1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminPostGameRecordHandlerV1.AdminPostGameRecordHandlerV1Builder AdminPostGameRecordHandlerV1Op
        {
            get
            {
                var opBuilder = new Operation.AdminPostGameRecordHandlerV1.AdminPostGameRecordHandlerV1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminDeleteGameRecordHandlerV1.AdminDeleteGameRecordHandlerV1Builder AdminDeleteGameRecordHandlerV1Op
        {
            get
            {
                var opBuilder = new Operation.AdminDeleteGameRecordHandlerV1.AdminDeleteGameRecordHandlerV1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

        public Model.ModelsListGameRecordKeysResponse? ListGameRecordsHandlerV1(ListGameRecordsHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsListGameRecordKeysResponse?> ListGameRecordsHandlerV1Async(ListGameRecordsHandlerV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGameRecordAdminResponse? AdminGetGameRecordHandlerV1(AdminGetGameRecordHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGameRecordAdminResponse?> AdminGetGameRecordHandlerV1Async(AdminGetGameRecordHandlerV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ModelsGameRecordAdminResponse<T1>? AdminGetGameRecordHandlerV1<T1>(AdminGetGameRecordHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGameRecordAdminResponse<T1>?> AdminGetGameRecordHandlerV1Async<T1>(AdminGetGameRecordHandlerV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGameRecordAdminResponse? AdminPutGameRecordHandlerV1(AdminPutGameRecordHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGameRecordAdminResponse?> AdminPutGameRecordHandlerV1Async(AdminPutGameRecordHandlerV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ModelsGameRecordAdminResponse<T1>? AdminPutGameRecordHandlerV1<T1>(AdminPutGameRecordHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGameRecordAdminResponse<T1>?> AdminPutGameRecordHandlerV1Async<T1>(AdminPutGameRecordHandlerV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGameRecordAdminResponse? AdminPostGameRecordHandlerV1(AdminPostGameRecordHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGameRecordAdminResponse?> AdminPostGameRecordHandlerV1Async(AdminPostGameRecordHandlerV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ModelsGameRecordAdminResponse<T1>? AdminPostGameRecordHandlerV1<T1>(AdminPostGameRecordHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGameRecordAdminResponse<T1>?> AdminPostGameRecordHandlerV1Async<T1>(AdminPostGameRecordHandlerV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDeleteGameRecordHandlerV1(AdminDeleteGameRecordHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task AdminDeleteGameRecordHandlerV1Async(AdminDeleteGameRecordHandlerV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}