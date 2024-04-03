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

using AccelByte.Sdk.Api.Match2.Model;
using AccelByte.Sdk.Api.Match2.Operation;

namespace AccelByte.Sdk.Api.Match2.Wrapper
{
    public class RuleSets
    {
        private readonly IAccelByteSdk _sdk;

        public RuleSets(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public RuleSetList.RuleSetListBuilder RuleSetListOp
        {
            get { return new Operation.RuleSetList.RuleSetListBuilder(_sdk); }
        }
        public CreateRuleSet.CreateRuleSetBuilder CreateRuleSetOp
        {
            get { return new Operation.CreateRuleSet.CreateRuleSetBuilder(_sdk); }
        }
        public RuleSetDetails.RuleSetDetailsBuilder RuleSetDetailsOp
        {
            get { return new Operation.RuleSetDetails.RuleSetDetailsBuilder(_sdk); }
        }
        public UpdateRuleSet.UpdateRuleSetBuilder UpdateRuleSetOp
        {
            get { return new Operation.UpdateRuleSet.UpdateRuleSetBuilder(_sdk); }
        }
        public DeleteRuleSet.DeleteRuleSetBuilder DeleteRuleSetOp
        {
            get { return new Operation.DeleteRuleSet.DeleteRuleSetBuilder(_sdk); }
        }
        #endregion

        public Model.ApiListRuleSetsResponse? RuleSetList(RuleSetList input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApiListRuleSetsResponse?> RuleSetListAsync(RuleSetList input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void CreateRuleSet(CreateRuleSet input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task CreateRuleSetAsync(CreateRuleSet input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApiRuleSetPayload? RuleSetDetails(RuleSetDetails input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApiRuleSetPayload?> RuleSetDetailsAsync(RuleSetDetails input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ApiRuleSetPayload<T1>? RuleSetDetails<T1>(RuleSetDetails input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApiRuleSetPayload<T1>?> RuleSetDetailsAsync<T1>(RuleSetDetails input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApiRuleSetPayload? UpdateRuleSet(UpdateRuleSet input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApiRuleSetPayload?> UpdateRuleSetAsync(UpdateRuleSet input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ApiRuleSetPayload<T1>? UpdateRuleSet<T1>(UpdateRuleSet input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApiRuleSetPayload<T1>?> UpdateRuleSetAsync<T1>(UpdateRuleSet input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteRuleSet(DeleteRuleSet input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task DeleteRuleSetAsync(DeleteRuleSet input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}