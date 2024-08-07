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

        private string _CustomBasePath = String.Empty;

        public AdminReasons(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public AdminReasons(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        public AdminListReasonGroups.AdminListReasonGroupsBuilder AdminListReasonGroupsOp
        {
            get
            {
                var opBuilder = new Operation.AdminListReasonGroups.AdminListReasonGroupsBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public CreateReasonGroup.CreateReasonGroupBuilder CreateReasonGroupOp
        {
            get
            {
                var opBuilder = new Operation.CreateReasonGroup.CreateReasonGroupBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetReasonGroup.GetReasonGroupBuilder GetReasonGroupOp
        {
            get
            {
                var opBuilder = new Operation.GetReasonGroup.GetReasonGroupBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public DeleteReasonGroup.DeleteReasonGroupBuilder DeleteReasonGroupOp
        {
            get
            {
                var opBuilder = new Operation.DeleteReasonGroup.DeleteReasonGroupBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public UpdateReasonGroup.UpdateReasonGroupBuilder UpdateReasonGroupOp
        {
            get
            {
                var opBuilder = new Operation.UpdateReasonGroup.UpdateReasonGroupBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminGetReasons.AdminGetReasonsBuilder AdminGetReasonsOp
        {
            get
            {
                var opBuilder = new Operation.AdminGetReasons.AdminGetReasonsBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public CreateReason.CreateReasonBuilder CreateReasonOp
        {
            get
            {
                var opBuilder = new Operation.CreateReason.CreateReasonBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminGetAllReasons.AdminGetAllReasonsBuilder AdminGetAllReasonsOp
        {
            get
            {
                var opBuilder = new Operation.AdminGetAllReasons.AdminGetAllReasonsBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminGetUnusedReasons.AdminGetUnusedReasonsBuilder AdminGetUnusedReasonsOp
        {
            get
            {
                var opBuilder = new Operation.AdminGetUnusedReasons.AdminGetUnusedReasonsBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminGetReason.AdminGetReasonBuilder AdminGetReasonOp
        {
            get
            {
                var opBuilder = new Operation.AdminGetReason.AdminGetReasonBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public DeleteReason.DeleteReasonBuilder DeleteReasonOp
        {
            get
            {
                var opBuilder = new Operation.DeleteReason.DeleteReasonBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public UpdateReason.UpdateReasonBuilder UpdateReasonOp
        {
            get
            {
                var opBuilder = new Operation.UpdateReason.UpdateReasonBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
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