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

using AccelByte.Sdk.Api.Session.Model;
using AccelByte.Sdk.Api.Session.Operation;

namespace AccelByte.Sdk.Api.Session.Wrapper
{
    public class ConfigurationTemplate
    {
        private readonly IAccelByteSdk _sdk;

        public ConfigurationTemplate(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminGetConfigurationAlertV1.AdminGetConfigurationAlertV1Builder AdminGetConfigurationAlertV1Op
        {
            get { return new Operation.AdminGetConfigurationAlertV1.AdminGetConfigurationAlertV1Builder(_sdk); }
        }
        public AdminUpdateConfigurationAlertV1.AdminUpdateConfigurationAlertV1Builder AdminUpdateConfigurationAlertV1Op
        {
            get { return new Operation.AdminUpdateConfigurationAlertV1.AdminUpdateConfigurationAlertV1Builder(_sdk); }
        }
        public AdminCreateConfigurationAlertV1.AdminCreateConfigurationAlertV1Builder AdminCreateConfigurationAlertV1Op
        {
            get { return new Operation.AdminCreateConfigurationAlertV1.AdminCreateConfigurationAlertV1Builder(_sdk); }
        }
        public AdminDeleteConfigurationAlertV1.AdminDeleteConfigurationAlertV1Builder AdminDeleteConfigurationAlertV1Op
        {
            get { return new Operation.AdminDeleteConfigurationAlertV1.AdminDeleteConfigurationAlertV1Builder(_sdk); }
        }
        public AdminCreateConfigurationTemplateV1.AdminCreateConfigurationTemplateV1Builder AdminCreateConfigurationTemplateV1Op
        {
            get { return new Operation.AdminCreateConfigurationTemplateV1.AdminCreateConfigurationTemplateV1Builder(_sdk); }
        }
        public AdminGetAllConfigurationTemplatesV1.AdminGetAllConfigurationTemplatesV1Builder AdminGetAllConfigurationTemplatesV1Op
        {
            get { return new Operation.AdminGetAllConfigurationTemplatesV1.AdminGetAllConfigurationTemplatesV1Builder(_sdk); }
        }
        public AdminGetConfigurationTemplateV1.AdminGetConfigurationTemplateV1Builder AdminGetConfigurationTemplateV1Op
        {
            get { return new Operation.AdminGetConfigurationTemplateV1.AdminGetConfigurationTemplateV1Builder(_sdk); }
        }
        public AdminUpdateConfigurationTemplateV1.AdminUpdateConfigurationTemplateV1Builder AdminUpdateConfigurationTemplateV1Op
        {
            get { return new Operation.AdminUpdateConfigurationTemplateV1.AdminUpdateConfigurationTemplateV1Builder(_sdk); }
        }
        public AdminDeleteConfigurationTemplateV1.AdminDeleteConfigurationTemplateV1Builder AdminDeleteConfigurationTemplateV1Op
        {
            get { return new Operation.AdminDeleteConfigurationTemplateV1.AdminDeleteConfigurationTemplateV1Builder(_sdk); }
        }
        public AdminGetDSMCConfiguration.AdminGetDSMCConfigurationBuilder AdminGetDSMCConfigurationOp
        {
            get { return new Operation.AdminGetDSMCConfiguration.AdminGetDSMCConfigurationBuilder(_sdk); }
        }
        public AdminSyncDSMCConfiguration.AdminSyncDSMCConfigurationBuilder AdminSyncDSMCConfigurationOp
        {
            get { return new Operation.AdminSyncDSMCConfiguration.AdminSyncDSMCConfigurationBuilder(_sdk); }
        }
        #endregion

        public Model.ApimodelsConfigAlertResponse? AdminGetConfigurationAlertV1(AdminGetConfigurationAlertV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApimodelsConfigAlertResponse?> AdminGetConfigurationAlertV1Async(AdminGetConfigurationAlertV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsConfigAlertResponse? AdminUpdateConfigurationAlertV1(AdminUpdateConfigurationAlertV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApimodelsConfigAlertResponse?> AdminUpdateConfigurationAlertV1Async(AdminUpdateConfigurationAlertV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsConfigAlertResponse? AdminCreateConfigurationAlertV1(AdminCreateConfigurationAlertV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApimodelsConfigAlertResponse?> AdminCreateConfigurationAlertV1Async(AdminCreateConfigurationAlertV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDeleteConfigurationAlertV1(AdminDeleteConfigurationAlertV1 input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task AdminDeleteConfigurationAlertV1Async(AdminDeleteConfigurationAlertV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsConfigurationTemplateResponse? AdminCreateConfigurationTemplateV1(AdminCreateConfigurationTemplateV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApimodelsConfigurationTemplateResponse?> AdminCreateConfigurationTemplateV1Async(AdminCreateConfigurationTemplateV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ApimodelsConfigurationTemplateResponse<T1>? AdminCreateConfigurationTemplateV1<T1>(AdminCreateConfigurationTemplateV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApimodelsConfigurationTemplateResponse<T1>?> AdminCreateConfigurationTemplateV1Async<T1>(AdminCreateConfigurationTemplateV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
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
        public async Task<Model.ApimodelsConfigurationTemplatesResponse?> AdminGetAllConfigurationTemplatesV1Async(AdminGetAllConfigurationTemplatesV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
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
        public async Task<Model.ApimodelsConfigurationTemplateResponse?> AdminGetConfigurationTemplateV1Async(AdminGetConfigurationTemplateV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ApimodelsConfigurationTemplateResponse<T1>? AdminGetConfigurationTemplateV1<T1>(AdminGetConfigurationTemplateV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApimodelsConfigurationTemplateResponse<T1>?> AdminGetConfigurationTemplateV1Async<T1>(AdminGetConfigurationTemplateV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
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
        public async Task<Model.ApimodelsConfigurationTemplateResponse?> AdminUpdateConfigurationTemplateV1Async(AdminUpdateConfigurationTemplateV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ApimodelsConfigurationTemplateResponse<T1>? AdminUpdateConfigurationTemplateV1<T1>(AdminUpdateConfigurationTemplateV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApimodelsConfigurationTemplateResponse<T1>?> AdminUpdateConfigurationTemplateV1Async<T1>(AdminUpdateConfigurationTemplateV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDeleteConfigurationTemplateV1(AdminDeleteConfigurationTemplateV1 input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task AdminDeleteConfigurationTemplateV1Async(AdminDeleteConfigurationTemplateV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
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
        public async Task<Model.ModelsDSMConfigRecord?> AdminGetDSMCConfigurationAsync(AdminGetDSMCConfiguration input)
        {
            var response = await _sdk.RunRequestAsync(input);
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
        public async Task<Model.ModelsDSMConfigRecord?> AdminSyncDSMCConfigurationAsync(AdminSyncDSMCConfiguration input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}