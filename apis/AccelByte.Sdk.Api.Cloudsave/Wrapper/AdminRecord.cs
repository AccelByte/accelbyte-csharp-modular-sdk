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
    public class AdminRecord
    {
        private readonly IAccelByteSdk _sdk;

        public AdminRecord(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminListAdminGameRecordV1.AdminListAdminGameRecordV1Builder AdminListAdminGameRecordV1Op
        {
            get { return new Operation.AdminListAdminGameRecordV1.AdminListAdminGameRecordV1Builder(_sdk); }
        }
        public AdminBulkGetAdminGameRecordV1.AdminBulkGetAdminGameRecordV1Builder AdminBulkGetAdminGameRecordV1Op
        {
            get { return new Operation.AdminBulkGetAdminGameRecordV1.AdminBulkGetAdminGameRecordV1Builder(_sdk); }
        }
        public AdminGetAdminGameRecordV1.AdminGetAdminGameRecordV1Builder AdminGetAdminGameRecordV1Op
        {
            get { return new Operation.AdminGetAdminGameRecordV1.AdminGetAdminGameRecordV1Builder(_sdk); }
        }
        public AdminPutAdminGameRecordV1.AdminPutAdminGameRecordV1Builder AdminPutAdminGameRecordV1Op
        {
            get { return new Operation.AdminPutAdminGameRecordV1.AdminPutAdminGameRecordV1Builder(_sdk); }
        }
        public AdminPostAdminGameRecordV1.AdminPostAdminGameRecordV1Builder AdminPostAdminGameRecordV1Op
        {
            get { return new Operation.AdminPostAdminGameRecordV1.AdminPostAdminGameRecordV1Builder(_sdk); }
        }
        public AdminDeleteAdminGameRecordV1.AdminDeleteAdminGameRecordV1Builder AdminDeleteAdminGameRecordV1Op
        {
            get { return new Operation.AdminDeleteAdminGameRecordV1.AdminDeleteAdminGameRecordV1Builder(_sdk); }
        }
        public BulkGetAdminPlayerRecordByUserIdsV1.BulkGetAdminPlayerRecordByUserIdsV1Builder BulkGetAdminPlayerRecordByUserIdsV1Op
        {
            get { return new Operation.BulkGetAdminPlayerRecordByUserIdsV1.BulkGetAdminPlayerRecordByUserIdsV1Builder(_sdk); }
        }
        public AdminListAdminUserRecordsV1.AdminListAdminUserRecordsV1Builder AdminListAdminUserRecordsV1Op
        {
            get { return new Operation.AdminListAdminUserRecordsV1.AdminListAdminUserRecordsV1Builder(_sdk); }
        }
        public AdminBulkGetAdminPlayerRecordV1.AdminBulkGetAdminPlayerRecordV1Builder AdminBulkGetAdminPlayerRecordV1Op
        {
            get { return new Operation.AdminBulkGetAdminPlayerRecordV1.AdminBulkGetAdminPlayerRecordV1Builder(_sdk); }
        }
        public AdminGetAdminPlayerRecordV1.AdminGetAdminPlayerRecordV1Builder AdminGetAdminPlayerRecordV1Op
        {
            get { return new Operation.AdminGetAdminPlayerRecordV1.AdminGetAdminPlayerRecordV1Builder(_sdk); }
        }
        public AdminPutAdminPlayerRecordV1.AdminPutAdminPlayerRecordV1Builder AdminPutAdminPlayerRecordV1Op
        {
            get { return new Operation.AdminPutAdminPlayerRecordV1.AdminPutAdminPlayerRecordV1Builder(_sdk); }
        }
        public AdminPostPlayerAdminRecordV1.AdminPostPlayerAdminRecordV1Builder AdminPostPlayerAdminRecordV1Op
        {
            get { return new Operation.AdminPostPlayerAdminRecordV1.AdminPostPlayerAdminRecordV1Builder(_sdk); }
        }
        public AdminDeleteAdminPlayerRecordV1.AdminDeleteAdminPlayerRecordV1Builder AdminDeleteAdminPlayerRecordV1Op
        {
            get { return new Operation.AdminDeleteAdminPlayerRecordV1.AdminDeleteAdminPlayerRecordV1Builder(_sdk); }
        }
        #endregion

        public Model.ModelsListAdminGameRecordKeysResponse? AdminListAdminGameRecordV1(AdminListAdminGameRecordV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsListAdminGameRecordKeysResponse?> AdminListAdminGameRecordV1Async(AdminListAdminGameRecordV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsBulkGetAdminGameRecordResponse? AdminBulkGetAdminGameRecordV1(AdminBulkGetAdminGameRecordV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsBulkGetAdminGameRecordResponse?> AdminBulkGetAdminGameRecordV1Async(AdminBulkGetAdminGameRecordV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsAdminGameRecordResponse? AdminGetAdminGameRecordV1(AdminGetAdminGameRecordV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsAdminGameRecordResponse?> AdminGetAdminGameRecordV1Async(AdminGetAdminGameRecordV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ModelsAdminGameRecordResponse<T1>? AdminGetAdminGameRecordV1<T1>(AdminGetAdminGameRecordV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsAdminGameRecordResponse<T1>?> AdminGetAdminGameRecordV1Async<T1>(AdminGetAdminGameRecordV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsAdminGameRecordResponse? AdminPutAdminGameRecordV1(AdminPutAdminGameRecordV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsAdminGameRecordResponse?> AdminPutAdminGameRecordV1Async(AdminPutAdminGameRecordV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ModelsAdminGameRecordResponse<T1>? AdminPutAdminGameRecordV1<T1>(AdminPutAdminGameRecordV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsAdminGameRecordResponse<T1>?> AdminPutAdminGameRecordV1Async<T1>(AdminPutAdminGameRecordV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsAdminGameRecordResponse? AdminPostAdminGameRecordV1(AdminPostAdminGameRecordV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsAdminGameRecordResponse?> AdminPostAdminGameRecordV1Async(AdminPostAdminGameRecordV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ModelsAdminGameRecordResponse<T1>? AdminPostAdminGameRecordV1<T1>(AdminPostAdminGameRecordV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsAdminGameRecordResponse<T1>?> AdminPostAdminGameRecordV1Async<T1>(AdminPostAdminGameRecordV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDeleteAdminGameRecordV1(AdminDeleteAdminGameRecordV1 input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task AdminDeleteAdminGameRecordV1Async(AdminDeleteAdminGameRecordV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsBulkGetAdminPlayerRecordResponse? BulkGetAdminPlayerRecordByUserIdsV1(BulkGetAdminPlayerRecordByUserIdsV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsBulkGetAdminPlayerRecordResponse?> BulkGetAdminPlayerRecordByUserIdsV1Async(BulkGetAdminPlayerRecordByUserIdsV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsListAdminPlayerRecordKeysResponse? AdminListAdminUserRecordsV1(AdminListAdminUserRecordsV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsListAdminPlayerRecordKeysResponse?> AdminListAdminUserRecordsV1Async(AdminListAdminUserRecordsV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsBulkGetAdminPlayerRecordResponse? AdminBulkGetAdminPlayerRecordV1(AdminBulkGetAdminPlayerRecordV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsBulkGetAdminPlayerRecordResponse?> AdminBulkGetAdminPlayerRecordV1Async(AdminBulkGetAdminPlayerRecordV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsAdminPlayerRecordResponse? AdminGetAdminPlayerRecordV1(AdminGetAdminPlayerRecordV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsAdminPlayerRecordResponse?> AdminGetAdminPlayerRecordV1Async(AdminGetAdminPlayerRecordV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ModelsAdminPlayerRecordResponse<T1>? AdminGetAdminPlayerRecordV1<T1>(AdminGetAdminPlayerRecordV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsAdminPlayerRecordResponse<T1>?> AdminGetAdminPlayerRecordV1Async<T1>(AdminGetAdminPlayerRecordV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsAdminPlayerRecordResponse? AdminPutAdminPlayerRecordV1(AdminPutAdminPlayerRecordV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsAdminPlayerRecordResponse?> AdminPutAdminPlayerRecordV1Async(AdminPutAdminPlayerRecordV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ModelsAdminPlayerRecordResponse<T1>? AdminPutAdminPlayerRecordV1<T1>(AdminPutAdminPlayerRecordV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsAdminPlayerRecordResponse<T1>?> AdminPutAdminPlayerRecordV1Async<T1>(AdminPutAdminPlayerRecordV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsAdminPlayerRecordResponse? AdminPostPlayerAdminRecordV1(AdminPostPlayerAdminRecordV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsAdminPlayerRecordResponse?> AdminPostPlayerAdminRecordV1Async(AdminPostPlayerAdminRecordV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ModelsAdminPlayerRecordResponse<T1>? AdminPostPlayerAdminRecordV1<T1>(AdminPostPlayerAdminRecordV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsAdminPlayerRecordResponse<T1>?> AdminPostPlayerAdminRecordV1Async<T1>(AdminPostPlayerAdminRecordV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDeleteAdminPlayerRecordV1(AdminDeleteAdminPlayerRecordV1 input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task AdminDeleteAdminPlayerRecordV1Async(AdminDeleteAdminPlayerRecordV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}