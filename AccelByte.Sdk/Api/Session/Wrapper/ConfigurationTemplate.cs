// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Session.Model;
using AccelByte.Sdk.Api.Session.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Session.Wrapper
{
    public class ConfigurationTemplate
    {
        private readonly AccelByteSDK _sdk;

        public ConfigurationTemplate(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminCreateConfigurationTemplateV1.AdminCreateConfigurationTemplateV1Builder AdminCreateConfigurationTemplateV1Op
        {
            get { return Operation.AdminCreateConfigurationTemplateV1.Builder.SetWrapperObject(this); }
        }
        public AdminGetAllConfigurationTemplatesV1.AdminGetAllConfigurationTemplatesV1Builder AdminGetAllConfigurationTemplatesV1Op
        {
            get { return Operation.AdminGetAllConfigurationTemplatesV1.Builder.SetWrapperObject(this); }
        }
        public AdminGetConfigurationTemplateV1.AdminGetConfigurationTemplateV1Builder AdminGetConfigurationTemplateV1Op
        {
            get { return Operation.AdminGetConfigurationTemplateV1.Builder.SetWrapperObject(this); }
        }
        public AdminUpdateConfigurationTemplateV1.AdminUpdateConfigurationTemplateV1Builder AdminUpdateConfigurationTemplateV1Op
        {
            get { return Operation.AdminUpdateConfigurationTemplateV1.Builder.SetWrapperObject(this); }
        }
        public AdminDeleteConfigurationTemplateV1.AdminDeleteConfigurationTemplateV1Builder AdminDeleteConfigurationTemplateV1Op
        {
            get { return Operation.AdminDeleteConfigurationTemplateV1.Builder.SetWrapperObject(this); }
        }
        public AdminGetDSMCConfiguration.AdminGetDSMCConfigurationBuilder AdminGetDSMCConfigurationOp
        {
            get { return Operation.AdminGetDSMCConfiguration.Builder.SetWrapperObject(this); }
        }
        public AdminSyncDSMCConfiguration.AdminSyncDSMCConfigurationBuilder AdminSyncDSMCConfigurationOp
        {
            get { return Operation.AdminSyncDSMCConfiguration.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.ApimodelsConfigurationTemplateResponse? AdminCreateConfigurationTemplateV1(AdminCreateConfigurationTemplateV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsConfigurationTemplatesResponse? AdminGetAllConfigurationTemplatesV1(AdminGetAllConfigurationTemplatesV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsConfigurationTemplateResponse? AdminGetConfigurationTemplateV1(AdminGetConfigurationTemplateV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsConfigurationTemplateResponse? AdminUpdateConfigurationTemplateV1(AdminUpdateConfigurationTemplateV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDeleteConfigurationTemplateV1(AdminDeleteConfigurationTemplateV1 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsDSMConfigRecord? AdminGetDSMCConfiguration(AdminGetDSMCConfiguration input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsDSMConfigRecord? AdminSyncDSMCConfiguration(AdminSyncDSMCConfiguration input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}