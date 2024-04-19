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

using AccelByte.Sdk.Api.Group.Model;
using AccelByte.Sdk.Api.Group.Operation;

namespace AccelByte.Sdk.Api.Group.Wrapper
{
    public class Group
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public Group(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public Group(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        public GetGroupListAdminV1.GetGroupListAdminV1Builder GetGroupListAdminV1Op
        {
            get
            {
                var opBuilder = new Operation.GetGroupListAdminV1.GetGroupListAdminV1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetSingleGroupAdminV1.GetSingleGroupAdminV1Builder GetSingleGroupAdminV1Op
        {
            get
            {
                var opBuilder = new Operation.GetSingleGroupAdminV1.GetSingleGroupAdminV1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public DeleteGroupAdminV1.DeleteGroupAdminV1Builder DeleteGroupAdminV1Op
        {
            get
            {
                var opBuilder = new Operation.DeleteGroupAdminV1.DeleteGroupAdminV1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetGroupListPublicV1.GetGroupListPublicV1Builder GetGroupListPublicV1Op
        {
            get
            {
                var opBuilder = new Operation.GetGroupListPublicV1.GetGroupListPublicV1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public CreateNewGroupPublicV1.CreateNewGroupPublicV1Builder CreateNewGroupPublicV1Op
        {
            get
            {
                var opBuilder = new Operation.CreateNewGroupPublicV1.CreateNewGroupPublicV1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetSingleGroupPublicV1.GetSingleGroupPublicV1Builder GetSingleGroupPublicV1Op
        {
            get
            {
                var opBuilder = new Operation.GetSingleGroupPublicV1.GetSingleGroupPublicV1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public UpdateSingleGroupV1.UpdateSingleGroupV1Builder UpdateSingleGroupV1Op
        {
            get
            {
                var opBuilder = new Operation.UpdateSingleGroupV1.UpdateSingleGroupV1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public DeleteGroupPublicV1.DeleteGroupPublicV1Builder DeleteGroupPublicV1Op
        {
            get
            {
                var opBuilder = new Operation.DeleteGroupPublicV1.DeleteGroupPublicV1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public UpdatePatchSingleGroupPublicV1.UpdatePatchSingleGroupPublicV1Builder UpdatePatchSingleGroupPublicV1Op
        {
            get
            {
                var opBuilder = new Operation.UpdatePatchSingleGroupPublicV1.UpdatePatchSingleGroupPublicV1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public UpdateGroupCustomAttributesPublicV1.UpdateGroupCustomAttributesPublicV1Builder UpdateGroupCustomAttributesPublicV1Op
        {
            get
            {
                var opBuilder = new Operation.UpdateGroupCustomAttributesPublicV1.UpdateGroupCustomAttributesPublicV1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public UpdateGroupCustomRulePublicV1.UpdateGroupCustomRulePublicV1Builder UpdateGroupCustomRulePublicV1Op
        {
            get
            {
                var opBuilder = new Operation.UpdateGroupCustomRulePublicV1.UpdateGroupCustomRulePublicV1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public UpdateGroupPredefinedRulePublicV1.UpdateGroupPredefinedRulePublicV1Builder UpdateGroupPredefinedRulePublicV1Op
        {
            get
            {
                var opBuilder = new Operation.UpdateGroupPredefinedRulePublicV1.UpdateGroupPredefinedRulePublicV1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public DeleteGroupPredefinedRulePublicV1.DeleteGroupPredefinedRulePublicV1Builder DeleteGroupPredefinedRulePublicV1Op
        {
            get
            {
                var opBuilder = new Operation.DeleteGroupPredefinedRulePublicV1.DeleteGroupPredefinedRulePublicV1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetListGroupByIDsAdminV2.GetListGroupByIDsAdminV2Builder GetListGroupByIDsAdminV2Op
        {
            get
            {
                var opBuilder = new Operation.GetListGroupByIDsAdminV2.GetListGroupByIDsAdminV2Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public CreateNewGroupPublicV2.CreateNewGroupPublicV2Builder CreateNewGroupPublicV2Op
        {
            get
            {
                var opBuilder = new Operation.CreateNewGroupPublicV2.CreateNewGroupPublicV2Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetListGroupByIDsV2.GetListGroupByIDsV2Builder GetListGroupByIDsV2Op
        {
            get
            {
                var opBuilder = new Operation.GetListGroupByIDsV2.GetListGroupByIDsV2Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public UpdatePutSingleGroupPublicV2.UpdatePutSingleGroupPublicV2Builder UpdatePutSingleGroupPublicV2Op
        {
            get
            {
                var opBuilder = new Operation.UpdatePutSingleGroupPublicV2.UpdatePutSingleGroupPublicV2Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public DeleteGroupPublicV2.DeleteGroupPublicV2Builder DeleteGroupPublicV2Op
        {
            get
            {
                var opBuilder = new Operation.DeleteGroupPublicV2.DeleteGroupPublicV2Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public UpdatePatchSingleGroupPublicV2.UpdatePatchSingleGroupPublicV2Builder UpdatePatchSingleGroupPublicV2Op
        {
            get
            {
                var opBuilder = new Operation.UpdatePatchSingleGroupPublicV2.UpdatePatchSingleGroupPublicV2Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public UpdateGroupCustomAttributesPublicV2.UpdateGroupCustomAttributesPublicV2Builder UpdateGroupCustomAttributesPublicV2Op
        {
            get
            {
                var opBuilder = new Operation.UpdateGroupCustomAttributesPublicV2.UpdateGroupCustomAttributesPublicV2Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public UpdateGroupCustomRulePublicV2.UpdateGroupCustomRulePublicV2Builder UpdateGroupCustomRulePublicV2Op
        {
            get
            {
                var opBuilder = new Operation.UpdateGroupCustomRulePublicV2.UpdateGroupCustomRulePublicV2Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public UpdateGroupPredefinedRulePublicV2.UpdateGroupPredefinedRulePublicV2Builder UpdateGroupPredefinedRulePublicV2Op
        {
            get
            {
                var opBuilder = new Operation.UpdateGroupPredefinedRulePublicV2.UpdateGroupPredefinedRulePublicV2Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public DeleteGroupPredefinedRulePublicV2.DeleteGroupPredefinedRulePublicV2Builder DeleteGroupPredefinedRulePublicV2Op
        {
            get
            {
                var opBuilder = new Operation.DeleteGroupPredefinedRulePublicV2.DeleteGroupPredefinedRulePublicV2Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

        public Model.ModelsGetGroupsListResponseV1? GetGroupListAdminV1(GetGroupListAdminV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGetGroupsListResponseV1?> GetGroupListAdminV1Async(GetGroupListAdminV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGroupResponseV1? GetSingleGroupAdminV1(GetSingleGroupAdminV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGroupResponseV1?> GetSingleGroupAdminV1Async(GetSingleGroupAdminV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ModelsGroupResponseV1<T1>? GetSingleGroupAdminV1<T1>(GetSingleGroupAdminV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGroupResponseV1<T1>?> GetSingleGroupAdminV1Async<T1>(GetSingleGroupAdminV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteGroupAdminV1(DeleteGroupAdminV1 input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task DeleteGroupAdminV1Async(DeleteGroupAdminV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetGroupsListResponseV1? GetGroupListPublicV1(GetGroupListPublicV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGetGroupsListResponseV1?> GetGroupListPublicV1Async(GetGroupListPublicV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGroupResponseV1? CreateNewGroupPublicV1(CreateNewGroupPublicV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGroupResponseV1?> CreateNewGroupPublicV1Async(CreateNewGroupPublicV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ModelsGroupResponseV1<T1>? CreateNewGroupPublicV1<T1>(CreateNewGroupPublicV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGroupResponseV1<T1>?> CreateNewGroupPublicV1Async<T1>(CreateNewGroupPublicV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGroupResponseV1? GetSingleGroupPublicV1(GetSingleGroupPublicV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGroupResponseV1?> GetSingleGroupPublicV1Async(GetSingleGroupPublicV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ModelsGroupResponseV1<T1>? GetSingleGroupPublicV1<T1>(GetSingleGroupPublicV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGroupResponseV1<T1>?> GetSingleGroupPublicV1Async<T1>(GetSingleGroupPublicV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGroupResponseV1? UpdateSingleGroupV1(UpdateSingleGroupV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGroupResponseV1?> UpdateSingleGroupV1Async(UpdateSingleGroupV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ModelsGroupResponseV1<T1>? UpdateSingleGroupV1<T1>(UpdateSingleGroupV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGroupResponseV1<T1>?> UpdateSingleGroupV1Async<T1>(UpdateSingleGroupV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteGroupPublicV1(DeleteGroupPublicV1 input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task DeleteGroupPublicV1Async(DeleteGroupPublicV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGroupResponseV1? UpdatePatchSingleGroupPublicV1(UpdatePatchSingleGroupPublicV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGroupResponseV1?> UpdatePatchSingleGroupPublicV1Async(UpdatePatchSingleGroupPublicV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ModelsGroupResponseV1<T1>? UpdatePatchSingleGroupPublicV1<T1>(UpdatePatchSingleGroupPublicV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGroupResponseV1<T1>?> UpdatePatchSingleGroupPublicV1Async<T1>(UpdatePatchSingleGroupPublicV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGroupResponseV1? UpdateGroupCustomAttributesPublicV1(UpdateGroupCustomAttributesPublicV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGroupResponseV1?> UpdateGroupCustomAttributesPublicV1Async(UpdateGroupCustomAttributesPublicV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ModelsGroupResponseV1<T1>? UpdateGroupCustomAttributesPublicV1<T1>(UpdateGroupCustomAttributesPublicV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGroupResponseV1<T1>?> UpdateGroupCustomAttributesPublicV1Async<T1>(UpdateGroupCustomAttributesPublicV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGroupResponseV1? UpdateGroupCustomRulePublicV1(UpdateGroupCustomRulePublicV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGroupResponseV1?> UpdateGroupCustomRulePublicV1Async(UpdateGroupCustomRulePublicV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ModelsGroupResponseV1<T1>? UpdateGroupCustomRulePublicV1<T1>(UpdateGroupCustomRulePublicV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGroupResponseV1<T1>?> UpdateGroupCustomRulePublicV1Async<T1>(UpdateGroupCustomRulePublicV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGroupResponseV1? UpdateGroupPredefinedRulePublicV1(UpdateGroupPredefinedRulePublicV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGroupResponseV1?> UpdateGroupPredefinedRulePublicV1Async(UpdateGroupPredefinedRulePublicV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ModelsGroupResponseV1<T1>? UpdateGroupPredefinedRulePublicV1<T1>(UpdateGroupPredefinedRulePublicV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGroupResponseV1<T1>?> UpdateGroupPredefinedRulePublicV1Async<T1>(UpdateGroupPredefinedRulePublicV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteGroupPredefinedRulePublicV1(DeleteGroupPredefinedRulePublicV1 input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task DeleteGroupPredefinedRulePublicV1Async(DeleteGroupPredefinedRulePublicV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetGroupsResponseV1? GetListGroupByIDsAdminV2(GetListGroupByIDsAdminV2 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGetGroupsResponseV1?> GetListGroupByIDsAdminV2Async(GetListGroupByIDsAdminV2 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGroupResponseV1? CreateNewGroupPublicV2(CreateNewGroupPublicV2 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGroupResponseV1?> CreateNewGroupPublicV2Async(CreateNewGroupPublicV2 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ModelsGroupResponseV1<T1>? CreateNewGroupPublicV2<T1>(CreateNewGroupPublicV2 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGroupResponseV1<T1>?> CreateNewGroupPublicV2Async<T1>(CreateNewGroupPublicV2 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetGroupsResponseV1? GetListGroupByIDsV2(GetListGroupByIDsV2 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGetGroupsResponseV1?> GetListGroupByIDsV2Async(GetListGroupByIDsV2 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGroupResponseV1? UpdatePutSingleGroupPublicV2(UpdatePutSingleGroupPublicV2 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGroupResponseV1?> UpdatePutSingleGroupPublicV2Async(UpdatePutSingleGroupPublicV2 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ModelsGroupResponseV1<T1>? UpdatePutSingleGroupPublicV2<T1>(UpdatePutSingleGroupPublicV2 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGroupResponseV1<T1>?> UpdatePutSingleGroupPublicV2Async<T1>(UpdatePutSingleGroupPublicV2 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteGroupPublicV2(DeleteGroupPublicV2 input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task DeleteGroupPublicV2Async(DeleteGroupPublicV2 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGroupResponseV1? UpdatePatchSingleGroupPublicV2(UpdatePatchSingleGroupPublicV2 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGroupResponseV1?> UpdatePatchSingleGroupPublicV2Async(UpdatePatchSingleGroupPublicV2 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ModelsGroupResponseV1<T1>? UpdatePatchSingleGroupPublicV2<T1>(UpdatePatchSingleGroupPublicV2 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGroupResponseV1<T1>?> UpdatePatchSingleGroupPublicV2Async<T1>(UpdatePatchSingleGroupPublicV2 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGroupResponseV1? UpdateGroupCustomAttributesPublicV2(UpdateGroupCustomAttributesPublicV2 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGroupResponseV1?> UpdateGroupCustomAttributesPublicV2Async(UpdateGroupCustomAttributesPublicV2 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ModelsGroupResponseV1<T1>? UpdateGroupCustomAttributesPublicV2<T1>(UpdateGroupCustomAttributesPublicV2 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGroupResponseV1<T1>?> UpdateGroupCustomAttributesPublicV2Async<T1>(UpdateGroupCustomAttributesPublicV2 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGroupResponseV1? UpdateGroupCustomRulePublicV2(UpdateGroupCustomRulePublicV2 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGroupResponseV1?> UpdateGroupCustomRulePublicV2Async(UpdateGroupCustomRulePublicV2 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ModelsGroupResponseV1<T1>? UpdateGroupCustomRulePublicV2<T1>(UpdateGroupCustomRulePublicV2 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGroupResponseV1<T1>?> UpdateGroupCustomRulePublicV2Async<T1>(UpdateGroupCustomRulePublicV2 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGroupResponseV1? UpdateGroupPredefinedRulePublicV2(UpdateGroupPredefinedRulePublicV2 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGroupResponseV1?> UpdateGroupPredefinedRulePublicV2Async(UpdateGroupPredefinedRulePublicV2 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ModelsGroupResponseV1<T1>? UpdateGroupPredefinedRulePublicV2<T1>(UpdateGroupPredefinedRulePublicV2 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGroupResponseV1<T1>?> UpdateGroupPredefinedRulePublicV2Async<T1>(UpdateGroupPredefinedRulePublicV2 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteGroupPredefinedRulePublicV2(DeleteGroupPredefinedRulePublicV2 input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task DeleteGroupPredefinedRulePublicV2Async(DeleteGroupPredefinedRulePublicV2 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}