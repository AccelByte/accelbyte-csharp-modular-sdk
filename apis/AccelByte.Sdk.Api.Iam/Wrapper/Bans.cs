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

using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;

namespace AccelByte.Sdk.Api.Iam.Wrapper
{
    public class Bans
    {
        private readonly IAccelByteSdk _sdk;

        public Bans(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public GetBansType.GetBansTypeBuilder GetBansTypeOp
        {
            get { return new Operation.GetBansType.GetBansTypeBuilder(_sdk); }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public GetListBanReason.GetListBanReasonBuilder GetListBanReasonOp
        {
            get { return new Operation.GetListBanReason.GetListBanReasonBuilder(_sdk); }
        }
        public AdminGetBansTypeV3.AdminGetBansTypeV3Builder AdminGetBansTypeV3Op
        {
            get { return new Operation.AdminGetBansTypeV3.AdminGetBansTypeV3Builder(_sdk); }
        }
        public AdminGetListBanReasonV3.AdminGetListBanReasonV3Builder AdminGetListBanReasonV3Op
        {
            get { return new Operation.AdminGetListBanReasonV3.AdminGetListBanReasonV3Builder(_sdk); }
        }
        public AdminGetBannedUsersV3.AdminGetBannedUsersV3Builder AdminGetBannedUsersV3Op
        {
            get { return new Operation.AdminGetBannedUsersV3.AdminGetBannedUsersV3Builder(_sdk); }
        }
        public AdminBanUserBulkV3.AdminBanUserBulkV3Builder AdminBanUserBulkV3Op
        {
            get { return new Operation.AdminBanUserBulkV3.AdminBanUserBulkV3Builder(_sdk); }
        }
        public AdminUnbanUserBulkV3.AdminUnbanUserBulkV3Builder AdminUnbanUserBulkV3Op
        {
            get { return new Operation.AdminUnbanUserBulkV3.AdminUnbanUserBulkV3Builder(_sdk); }
        }
        public AdminGetBansTypeWithNamespaceV3.AdminGetBansTypeWithNamespaceV3Builder AdminGetBansTypeWithNamespaceV3Op
        {
            get { return new Operation.AdminGetBansTypeWithNamespaceV3.AdminGetBansTypeWithNamespaceV3Builder(_sdk); }
        }
        #endregion

#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public Model.AccountcommonBans? GetBansType(GetBansType input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.AccountcommonBans?> GetBansTypeAsync(GetBansType input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public Model.AccountcommonBanReasons? GetListBanReason(GetListBanReason input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.AccountcommonBanReasons?> GetListBanReasonAsync(GetListBanReason input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
        public Model.AccountcommonBansV3? AdminGetBansTypeV3(AdminGetBansTypeV3 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.AccountcommonBansV3?> AdminGetBansTypeV3Async(AdminGetBansTypeV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.AccountcommonBanReasonsV3? AdminGetListBanReasonV3(AdminGetListBanReasonV3 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.AccountcommonBanReasonsV3?> AdminGetListBanReasonV3Async(AdminGetListBanReasonV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelGetUserBanV3Response? AdminGetBannedUsersV3(AdminGetBannedUsersV3 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelGetUserBanV3Response?> AdminGetBannedUsersV3Async(AdminGetBannedUsersV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelListBulkUserBanResponseV3? AdminBanUserBulkV3(AdminBanUserBulkV3 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelListBulkUserBanResponseV3?> AdminBanUserBulkV3Async(AdminBanUserBulkV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelListBulkUserBanResponseV3? AdminUnbanUserBulkV3(AdminUnbanUserBulkV3 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelListBulkUserBanResponseV3?> AdminUnbanUserBulkV3Async(AdminUnbanUserBulkV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.AccountcommonBansV3? AdminGetBansTypeWithNamespaceV3(AdminGetBansTypeWithNamespaceV3 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.AccountcommonBansV3?> AdminGetBansTypeWithNamespaceV3Async(AdminGetBansTypeWithNamespaceV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}