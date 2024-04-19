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
    public class AdminModerationRule
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public AdminModerationRule(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public AdminModerationRule(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        public CreateModerationRule.CreateModerationRuleBuilder CreateModerationRuleOp
        {
            get
            {
                var opBuilder = new Operation.CreateModerationRule.CreateModerationRuleBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public UpdateModerationRule.UpdateModerationRuleBuilder UpdateModerationRuleOp
        {
            get
            {
                var opBuilder = new Operation.UpdateModerationRule.UpdateModerationRuleBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public DeleteModerationRule.DeleteModerationRuleBuilder DeleteModerationRuleOp
        {
            get
            {
                var opBuilder = new Operation.DeleteModerationRule.DeleteModerationRuleBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public UpdateModerationRuleStatus.UpdateModerationRuleStatusBuilder UpdateModerationRuleStatusOp
        {
            get
            {
                var opBuilder = new Operation.UpdateModerationRuleStatus.UpdateModerationRuleStatusBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetModerationRules.GetModerationRulesBuilder GetModerationRulesOp
        {
            get
            {
                var opBuilder = new Operation.GetModerationRules.GetModerationRulesBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetModerationRuleDetails.GetModerationRuleDetailsBuilder GetModerationRuleDetailsOp
        {
            get
            {
                var opBuilder = new Operation.GetModerationRuleDetails.GetModerationRuleDetailsBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

        public void CreateModerationRule(CreateModerationRule input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task CreateModerationRuleAsync(CreateModerationRule input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.RestapiModerationRuleResponse? UpdateModerationRule(UpdateModerationRule input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.RestapiModerationRuleResponse?> UpdateModerationRuleAsync(UpdateModerationRule input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteModerationRule(DeleteModerationRule input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task DeleteModerationRuleAsync(DeleteModerationRule input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void UpdateModerationRuleStatus(UpdateModerationRuleStatus input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task UpdateModerationRuleStatusAsync(UpdateModerationRuleStatus input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.RestapiModerationRulesList? GetModerationRules(GetModerationRules input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.RestapiModerationRulesList?> GetModerationRulesAsync(GetModerationRules input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.RestapiModerationRuleResponse? GetModerationRuleDetails(GetModerationRuleDetails input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.RestapiModerationRuleResponse?> GetModerationRuleDetailsAsync(GetModerationRuleDetails input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}