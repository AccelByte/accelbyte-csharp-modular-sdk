// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Reporting.Model;
using AccelByte.Sdk.Api.Reporting.Operation;

namespace AccelByte.Sdk.Api.Reporting.Wrapper
{
    public class AdminModerationRule
    {
        private readonly IAccelByteSdk _sdk;

        public AdminModerationRule(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public CreateModerationRule.CreateModerationRuleBuilder CreateModerationRuleOp
        {
            get { return new Operation.CreateModerationRule.CreateModerationRuleBuilder(_sdk); }
        }
        public UpdateModerationRule.UpdateModerationRuleBuilder UpdateModerationRuleOp
        {
            get { return new Operation.UpdateModerationRule.UpdateModerationRuleBuilder(_sdk); }
        }
        public DeleteModerationRule.DeleteModerationRuleBuilder DeleteModerationRuleOp
        {
            get { return new Operation.DeleteModerationRule.DeleteModerationRuleBuilder(_sdk); }
        }
        public UpdateModerationRuleStatus.UpdateModerationRuleStatusBuilder UpdateModerationRuleStatusOp
        {
            get { return new Operation.UpdateModerationRuleStatus.UpdateModerationRuleStatusBuilder(_sdk); }
        }
        public GetModerationRules.GetModerationRulesBuilder GetModerationRulesOp
        {
            get { return new Operation.GetModerationRules.GetModerationRulesBuilder(_sdk); }
        }
        public GetModerationRuleDetails.GetModerationRuleDetailsBuilder GetModerationRuleDetailsOp
        {
            get { return new Operation.GetModerationRuleDetails.GetModerationRuleDetailsBuilder(_sdk); }
        }
        #endregion
        
        public void CreateModerationRule(CreateModerationRule input) {
            var response = _sdk.RunRequest(input);

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
        public void DeleteModerationRule(DeleteModerationRule input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void UpdateModerationRuleStatus(UpdateModerationRuleStatus input) {
            var response = _sdk.RunRequest(input);

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
        public Model.RestapiModerationRuleResponse? GetModerationRuleDetails(GetModerationRuleDetails input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}