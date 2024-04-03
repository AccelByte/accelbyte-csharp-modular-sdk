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

using AccelByte.Sdk.Api.Dsmc.Model;
using AccelByte.Sdk.Api.Dsmc.Operation;

namespace AccelByte.Sdk.Api.Dsmc.Wrapper
{
    public class Config
    {
        private readonly IAccelByteSdk _sdk;

        public Config(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public ListConfig.ListConfigBuilder ListConfigOp
        {
            get { return new Operation.ListConfig.ListConfigBuilder(_sdk); }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public SaveConfig.SaveConfigBuilder SaveConfigOp
        {
            get { return new Operation.SaveConfig.SaveConfigBuilder(_sdk); }
        }
        public GetConfig.GetConfigBuilder GetConfigOp
        {
            get { return new Operation.GetConfig.GetConfigBuilder(_sdk); }
        }
        public CreateConfig.CreateConfigBuilder CreateConfigOp
        {
            get { return new Operation.CreateConfig.CreateConfigBuilder(_sdk); }
        }
        public DeleteConfig.DeleteConfigBuilder DeleteConfigOp
        {
            get { return new Operation.DeleteConfig.DeleteConfigBuilder(_sdk); }
        }
        public UpdateConfig.UpdateConfigBuilder UpdateConfigOp
        {
            get { return new Operation.UpdateConfig.UpdateConfigBuilder(_sdk); }
        }
        public ClearCache.ClearCacheBuilder ClearCacheOp
        {
            get { return new Operation.ClearCache.ClearCacheBuilder(_sdk); }
        }
        public AddPort.AddPortBuilder AddPortOp
        {
            get { return new Operation.AddPort.AddPortBuilder(_sdk); }
        }
        public DeletePort.DeletePortBuilder DeletePortOp
        {
            get { return new Operation.DeletePort.DeletePortBuilder(_sdk); }
        }
        public UpdatePort.UpdatePortBuilder UpdatePortOp
        {
            get { return new Operation.UpdatePort.UpdatePortBuilder(_sdk); }
        }
        public ExportConfigV1.ExportConfigV1Builder ExportConfigV1Op
        {
            get { return new Operation.ExportConfigV1.ExportConfigV1Builder(_sdk); }
        }
        public ImportConfigV1.ImportConfigV1Builder ImportConfigV1Op
        {
            get { return new Operation.ImportConfigV1.ImportConfigV1Builder(_sdk); }
        }
        #endregion

        public Model.ModelsListConfigResponse? ListConfig(ListConfig input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsListConfigResponse?> ListConfigAsync(ListConfig input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public void SaveConfig(SaveConfig input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task SaveConfigAsync(SaveConfig input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
        public Model.ModelsDSMConfigRecord? GetConfig(GetConfig input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsDSMConfigRecord?> GetConfigAsync(GetConfig input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsDSMConfigRecord? CreateConfig(CreateConfig input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsDSMConfigRecord?> CreateConfigAsync(CreateConfig input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteConfig(DeleteConfig input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task DeleteConfigAsync(DeleteConfig input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsDSMConfigRecord? UpdateConfig(UpdateConfig input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsDSMConfigRecord?> UpdateConfigAsync(UpdateConfig input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void ClearCache(ClearCache input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task ClearCacheAsync(ClearCache input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsDSMConfigRecord? AddPort(AddPort input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsDSMConfigRecord?> AddPortAsync(AddPort input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsDSMConfigRecord? DeletePort(DeletePort input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsDSMConfigRecord?> DeletePortAsync(DeletePort input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsDSMConfigRecord? UpdatePort(UpdatePort input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsDSMConfigRecord?> UpdatePortAsync(UpdatePort input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Stream? ExportConfigV1(ExportConfigV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Stream?> ExportConfigV1Async(ExportConfigV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsImportResponse? ImportConfigV1(ImportConfigV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsImportResponse?> ImportConfigV1Async(ImportConfigV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}