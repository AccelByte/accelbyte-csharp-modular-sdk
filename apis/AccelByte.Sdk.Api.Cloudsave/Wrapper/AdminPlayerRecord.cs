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
    public class AdminPlayerRecord
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public AdminPlayerRecord(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public AdminPlayerRecord(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        public BulkGetPlayerRecordSizeHandlerV1.BulkGetPlayerRecordSizeHandlerV1Builder BulkGetPlayerRecordSizeHandlerV1Op
        {
            get
            {
                var opBuilder = new Operation.BulkGetPlayerRecordSizeHandlerV1.BulkGetPlayerRecordSizeHandlerV1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public ListPlayerRecordHandlerV1.ListPlayerRecordHandlerV1Builder ListPlayerRecordHandlerV1Op
        {
            get
            {
                var opBuilder = new Operation.ListPlayerRecordHandlerV1.ListPlayerRecordHandlerV1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminBulkPutPlayerRecordsByKeyHandlerV1.AdminBulkPutPlayerRecordsByKeyHandlerV1Builder AdminBulkPutPlayerRecordsByKeyHandlerV1Op
        {
            get
            {
                var opBuilder = new Operation.AdminBulkPutPlayerRecordsByKeyHandlerV1.AdminBulkPutPlayerRecordsByKeyHandlerV1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminBulkGetPlayerRecordsByUserIDsHandlerV1.AdminBulkGetPlayerRecordsByUserIDsHandlerV1Builder AdminBulkGetPlayerRecordsByUserIDsHandlerV1Op
        {
            get
            {
                var opBuilder = new Operation.AdminBulkGetPlayerRecordsByUserIDsHandlerV1.AdminBulkGetPlayerRecordsByUserIDsHandlerV1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminRetrievePlayerRecords.AdminRetrievePlayerRecordsBuilder AdminRetrievePlayerRecordsOp
        {
            get
            {
                var opBuilder = new Operation.AdminRetrievePlayerRecords.AdminRetrievePlayerRecordsBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminPutPlayerRecordsHandlerV1.AdminPutPlayerRecordsHandlerV1Builder AdminPutPlayerRecordsHandlerV1Op
        {
            get
            {
                var opBuilder = new Operation.AdminPutPlayerRecordsHandlerV1.AdminPutPlayerRecordsHandlerV1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminGetPlayerRecordsHandlerV1.AdminGetPlayerRecordsHandlerV1Builder AdminGetPlayerRecordsHandlerV1Op
        {
            get
            {
                var opBuilder = new Operation.AdminGetPlayerRecordsHandlerV1.AdminGetPlayerRecordsHandlerV1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminGetPlayerRecordHandlerV1.AdminGetPlayerRecordHandlerV1Builder AdminGetPlayerRecordHandlerV1Op
        {
            get
            {
                var opBuilder = new Operation.AdminGetPlayerRecordHandlerV1.AdminGetPlayerRecordHandlerV1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminPutPlayerRecordHandlerV1.AdminPutPlayerRecordHandlerV1Builder AdminPutPlayerRecordHandlerV1Op
        {
            get
            {
                var opBuilder = new Operation.AdminPutPlayerRecordHandlerV1.AdminPutPlayerRecordHandlerV1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminPostPlayerRecordHandlerV1.AdminPostPlayerRecordHandlerV1Builder AdminPostPlayerRecordHandlerV1Op
        {
            get
            {
                var opBuilder = new Operation.AdminPostPlayerRecordHandlerV1.AdminPostPlayerRecordHandlerV1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminDeletePlayerRecordHandlerV1.AdminDeletePlayerRecordHandlerV1Builder AdminDeletePlayerRecordHandlerV1Op
        {
            get
            {
                var opBuilder = new Operation.AdminDeletePlayerRecordHandlerV1.AdminDeletePlayerRecordHandlerV1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminGetPlayerPublicRecordHandlerV1.AdminGetPlayerPublicRecordHandlerV1Builder AdminGetPlayerPublicRecordHandlerV1Op
        {
            get
            {
                var opBuilder = new Operation.AdminGetPlayerPublicRecordHandlerV1.AdminGetPlayerPublicRecordHandlerV1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminPutPlayerPublicRecordHandlerV1.AdminPutPlayerPublicRecordHandlerV1Builder AdminPutPlayerPublicRecordHandlerV1Op
        {
            get
            {
                var opBuilder = new Operation.AdminPutPlayerPublicRecordHandlerV1.AdminPutPlayerPublicRecordHandlerV1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminPostPlayerPublicRecordHandlerV1.AdminPostPlayerPublicRecordHandlerV1Builder AdminPostPlayerPublicRecordHandlerV1Op
        {
            get
            {
                var opBuilder = new Operation.AdminPostPlayerPublicRecordHandlerV1.AdminPostPlayerPublicRecordHandlerV1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminDeletePlayerPublicRecordHandlerV1.AdminDeletePlayerPublicRecordHandlerV1Builder AdminDeletePlayerPublicRecordHandlerV1Op
        {
            get
            {
                var opBuilder = new Operation.AdminDeletePlayerPublicRecordHandlerV1.AdminDeletePlayerPublicRecordHandlerV1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminGetPlayerRecordSizeHandlerV1.AdminGetPlayerRecordSizeHandlerV1Builder AdminGetPlayerRecordSizeHandlerV1Op
        {
            get
            {
                var opBuilder = new Operation.AdminGetPlayerRecordSizeHandlerV1.AdminGetPlayerRecordSizeHandlerV1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

        public BulkGetPlayerRecordSizeHandlerV1.Response BulkGetPlayerRecordSizeHandlerV1(BulkGetPlayerRecordSizeHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<BulkGetPlayerRecordSizeHandlerV1.Response> BulkGetPlayerRecordSizeHandlerV1Async(BulkGetPlayerRecordSizeHandlerV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public ListPlayerRecordHandlerV1.Response ListPlayerRecordHandlerV1(ListPlayerRecordHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<ListPlayerRecordHandlerV1.Response> ListPlayerRecordHandlerV1Async(ListPlayerRecordHandlerV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        public AdminBulkPutPlayerRecordsByKeyHandlerV1.Response AdminBulkPutPlayerRecordsByKeyHandlerV1(AdminBulkPutPlayerRecordsByKeyHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminBulkPutPlayerRecordsByKeyHandlerV1.Response> AdminBulkPutPlayerRecordsByKeyHandlerV1Async(AdminBulkPutPlayerRecordsByKeyHandlerV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public AdminBulkPutPlayerRecordsByKeyHandlerV1.Response<T1> AdminBulkPutPlayerRecordsByKeyHandlerV1<T1>(AdminBulkPutPlayerRecordsByKeyHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminBulkPutPlayerRecordsByKeyHandlerV1.Response<T1>> AdminBulkPutPlayerRecordsByKeyHandlerV1Async<T1>(AdminBulkPutPlayerRecordsByKeyHandlerV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminBulkGetPlayerRecordsByUserIDsHandlerV1.Response AdminBulkGetPlayerRecordsByUserIDsHandlerV1(AdminBulkGetPlayerRecordsByUserIDsHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminBulkGetPlayerRecordsByUserIDsHandlerV1.Response> AdminBulkGetPlayerRecordsByUserIDsHandlerV1Async(AdminBulkGetPlayerRecordsByUserIDsHandlerV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminRetrievePlayerRecords.Response AdminRetrievePlayerRecords(AdminRetrievePlayerRecords input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminRetrievePlayerRecords.Response> AdminRetrievePlayerRecordsAsync(AdminRetrievePlayerRecords input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminPutPlayerRecordsHandlerV1.Response AdminPutPlayerRecordsHandlerV1(AdminPutPlayerRecordsHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminPutPlayerRecordsHandlerV1.Response> AdminPutPlayerRecordsHandlerV1Async(AdminPutPlayerRecordsHandlerV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public AdminPutPlayerRecordsHandlerV1.Response<T1> AdminPutPlayerRecordsHandlerV1<T1>(AdminPutPlayerRecordsHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminPutPlayerRecordsHandlerV1.Response<T1>> AdminPutPlayerRecordsHandlerV1Async<T1>(AdminPutPlayerRecordsHandlerV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminGetPlayerRecordsHandlerV1.Response AdminGetPlayerRecordsHandlerV1(AdminGetPlayerRecordsHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminGetPlayerRecordsHandlerV1.Response> AdminGetPlayerRecordsHandlerV1Async(AdminGetPlayerRecordsHandlerV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminGetPlayerRecordHandlerV1.Response AdminGetPlayerRecordHandlerV1(AdminGetPlayerRecordHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminGetPlayerRecordHandlerV1.Response> AdminGetPlayerRecordHandlerV1Async(AdminGetPlayerRecordHandlerV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public AdminGetPlayerRecordHandlerV1.Response<T1> AdminGetPlayerRecordHandlerV1<T1>(AdminGetPlayerRecordHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminGetPlayerRecordHandlerV1.Response<T1>> AdminGetPlayerRecordHandlerV1Async<T1>(AdminGetPlayerRecordHandlerV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminPutPlayerRecordHandlerV1.Response AdminPutPlayerRecordHandlerV1(AdminPutPlayerRecordHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminPutPlayerRecordHandlerV1.Response> AdminPutPlayerRecordHandlerV1Async(AdminPutPlayerRecordHandlerV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public AdminPutPlayerRecordHandlerV1.Response<T1> AdminPutPlayerRecordHandlerV1<T1>(AdminPutPlayerRecordHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminPutPlayerRecordHandlerV1.Response<T1>> AdminPutPlayerRecordHandlerV1Async<T1>(AdminPutPlayerRecordHandlerV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminPostPlayerRecordHandlerV1.Response AdminPostPlayerRecordHandlerV1(AdminPostPlayerRecordHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminPostPlayerRecordHandlerV1.Response> AdminPostPlayerRecordHandlerV1Async(AdminPostPlayerRecordHandlerV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public AdminPostPlayerRecordHandlerV1.Response<T1> AdminPostPlayerRecordHandlerV1<T1>(AdminPostPlayerRecordHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminPostPlayerRecordHandlerV1.Response<T1>> AdminPostPlayerRecordHandlerV1Async<T1>(AdminPostPlayerRecordHandlerV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminDeletePlayerRecordHandlerV1.Response AdminDeletePlayerRecordHandlerV1(AdminDeletePlayerRecordHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminDeletePlayerRecordHandlerV1.Response> AdminDeletePlayerRecordHandlerV1Async(AdminDeletePlayerRecordHandlerV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminGetPlayerPublicRecordHandlerV1.Response AdminGetPlayerPublicRecordHandlerV1(AdminGetPlayerPublicRecordHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminGetPlayerPublicRecordHandlerV1.Response> AdminGetPlayerPublicRecordHandlerV1Async(AdminGetPlayerPublicRecordHandlerV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public AdminGetPlayerPublicRecordHandlerV1.Response<T1> AdminGetPlayerPublicRecordHandlerV1<T1>(AdminGetPlayerPublicRecordHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminGetPlayerPublicRecordHandlerV1.Response<T1>> AdminGetPlayerPublicRecordHandlerV1Async<T1>(AdminGetPlayerPublicRecordHandlerV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminPutPlayerPublicRecordHandlerV1.Response AdminPutPlayerPublicRecordHandlerV1(AdminPutPlayerPublicRecordHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminPutPlayerPublicRecordHandlerV1.Response> AdminPutPlayerPublicRecordHandlerV1Async(AdminPutPlayerPublicRecordHandlerV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public AdminPutPlayerPublicRecordHandlerV1.Response<T1> AdminPutPlayerPublicRecordHandlerV1<T1>(AdminPutPlayerPublicRecordHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminPutPlayerPublicRecordHandlerV1.Response<T1>> AdminPutPlayerPublicRecordHandlerV1Async<T1>(AdminPutPlayerPublicRecordHandlerV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminPostPlayerPublicRecordHandlerV1.Response AdminPostPlayerPublicRecordHandlerV1(AdminPostPlayerPublicRecordHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminPostPlayerPublicRecordHandlerV1.Response> AdminPostPlayerPublicRecordHandlerV1Async(AdminPostPlayerPublicRecordHandlerV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public AdminPostPlayerPublicRecordHandlerV1.Response<T1> AdminPostPlayerPublicRecordHandlerV1<T1>(AdminPostPlayerPublicRecordHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminPostPlayerPublicRecordHandlerV1.Response<T1>> AdminPostPlayerPublicRecordHandlerV1Async<T1>(AdminPostPlayerPublicRecordHandlerV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminDeletePlayerPublicRecordHandlerV1.Response AdminDeletePlayerPublicRecordHandlerV1(AdminDeletePlayerPublicRecordHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminDeletePlayerPublicRecordHandlerV1.Response> AdminDeletePlayerPublicRecordHandlerV1Async(AdminDeletePlayerPublicRecordHandlerV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminGetPlayerRecordSizeHandlerV1.Response AdminGetPlayerRecordSizeHandlerV1(AdminGetPlayerRecordSizeHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminGetPlayerRecordSizeHandlerV1.Response> AdminGetPlayerRecordSizeHandlerV1Async(AdminGetPlayerRecordSizeHandlerV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}