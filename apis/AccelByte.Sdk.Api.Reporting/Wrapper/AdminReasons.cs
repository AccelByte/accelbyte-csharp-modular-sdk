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

using AccelByte.Sdk.Api.Reporting.Model;
using AccelByte.Sdk.Api.Reporting.Operation;

namespace AccelByte.Sdk.Api.Reporting.Wrapper
{
    public class AdminReasons
    {
        private readonly IAccelByteSdk _sdk;

        public AdminReasons(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminListReasonGroups.AdminListReasonGroupsBuilder AdminListReasonGroupsOp
        {
            get { return new Operation.AdminListReasonGroups.AdminListReasonGroupsBuilder(_sdk); }
        }
        public CreateReasonGroup.CreateReasonGroupBuilder CreateReasonGroupOp
        {
            get { return new Operation.CreateReasonGroup.CreateReasonGroupBuilder(_sdk); }
        }
        public GetReasonGroup.GetReasonGroupBuilder GetReasonGroupOp
        {
            get { return new Operation.GetReasonGroup.GetReasonGroupBuilder(_sdk); }
        }
        public DeleteReasonGroup.DeleteReasonGroupBuilder DeleteReasonGroupOp
        {
            get { return new Operation.DeleteReasonGroup.DeleteReasonGroupBuilder(_sdk); }
        }
        public UpdateReasonGroup.UpdateReasonGroupBuilder UpdateReasonGroupOp
        {
            get { return new Operation.UpdateReasonGroup.UpdateReasonGroupBuilder(_sdk); }
        }
        public AdminGetReasons.AdminGetReasonsBuilder AdminGetReasonsOp
        {
            get { return new Operation.AdminGetReasons.AdminGetReasonsBuilder(_sdk); }
        }
        public CreateReason.CreateReasonBuilder CreateReasonOp
        {
            get { return new Operation.CreateReason.CreateReasonBuilder(_sdk); }
        }
        public AdminGetAllReasons.AdminGetAllReasonsBuilder AdminGetAllReasonsOp
        {
            get { return new Operation.AdminGetAllReasons.AdminGetAllReasonsBuilder(_sdk); }
        }
        public AdminGetUnusedReasons.AdminGetUnusedReasonsBuilder AdminGetUnusedReasonsOp
        {
            get { return new Operation.AdminGetUnusedReasons.AdminGetUnusedReasonsBuilder(_sdk); }
        }
        public AdminGetReason.AdminGetReasonBuilder AdminGetReasonOp
        {
            get { return new Operation.AdminGetReason.AdminGetReasonBuilder(_sdk); }
        }
        public DeleteReason.DeleteReasonBuilder DeleteReasonOp
        {
            get { return new Operation.DeleteReason.DeleteReasonBuilder(_sdk); }
        }
        public UpdateReason.UpdateReasonBuilder UpdateReasonOp
        {
            get { return new Operation.UpdateReason.UpdateReasonBuilder(_sdk); }
        }
        #endregion

        public Model.RestapiReasonGroupListResponse? AdminListReasonGroups(AdminListReasonGroups input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.RestapiReasonGroupListResponse?> AdminListReasonGroupsAsync(AdminListReasonGroups input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.RestapiReasonGroupResponse? CreateReasonGroup(CreateReasonGroup input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.RestapiReasonGroupResponse?> CreateReasonGroupAsync(CreateReasonGroup input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.RestapiReasonGroupResponse? GetReasonGroup(GetReasonGroup input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.RestapiReasonGroupResponse?> GetReasonGroupAsync(GetReasonGroup input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteReasonGroup(DeleteReasonGroup input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task DeleteReasonGroupAsync(DeleteReasonGroup input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.RestapiReasonGroupResponse? UpdateReasonGroup(UpdateReasonGroup input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.RestapiReasonGroupResponse?> UpdateReasonGroupAsync(UpdateReasonGroup input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.RestapiAdminReasonListResponse? AdminGetReasons(AdminGetReasons input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.RestapiAdminReasonListResponse?> AdminGetReasonsAsync(AdminGetReasons input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.RestapiAdminReasonResponse? CreateReason(CreateReason input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.RestapiAdminReasonResponse?> CreateReasonAsync(CreateReason input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.RestapiAdminAllReasonsResponse? AdminGetAllReasons(AdminGetAllReasons input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.RestapiAdminAllReasonsResponse?> AdminGetAllReasonsAsync(AdminGetAllReasons input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.RestapiUnusedReasonListResponse? AdminGetUnusedReasons(AdminGetUnusedReasons input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.RestapiUnusedReasonListResponse?> AdminGetUnusedReasonsAsync(AdminGetUnusedReasons input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.RestapiAdminReasonResponse? AdminGetReason(AdminGetReason input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.RestapiAdminReasonResponse?> AdminGetReasonAsync(AdminGetReason input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteReason(DeleteReason input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task DeleteReasonAsync(DeleteReason input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.RestapiAdminReasonResponse? UpdateReason(UpdateReason input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.RestapiAdminReasonResponse?> UpdateReasonAsync(UpdateReason input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}