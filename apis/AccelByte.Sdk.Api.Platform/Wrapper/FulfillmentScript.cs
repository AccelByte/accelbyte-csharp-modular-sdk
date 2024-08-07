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

using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;

namespace AccelByte.Sdk.Api.Platform.Wrapper
{
    public class FulfillmentScript
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public FulfillmentScript(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public FulfillmentScript(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        public ListFulfillmentScripts.ListFulfillmentScriptsBuilder ListFulfillmentScriptsOp
        {
            get
            {
                var opBuilder = new Operation.ListFulfillmentScripts.ListFulfillmentScriptsBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetFulfillmentScript.GetFulfillmentScriptBuilder GetFulfillmentScriptOp
        {
            get
            {
                var opBuilder = new Operation.GetFulfillmentScript.GetFulfillmentScriptBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public CreateFulfillmentScript.CreateFulfillmentScriptBuilder CreateFulfillmentScriptOp
        {
            get
            {
                var opBuilder = new Operation.CreateFulfillmentScript.CreateFulfillmentScriptBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public DeleteFulfillmentScript.DeleteFulfillmentScriptBuilder DeleteFulfillmentScriptOp
        {
            get
            {
                var opBuilder = new Operation.DeleteFulfillmentScript.DeleteFulfillmentScriptBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public UpdateFulfillmentScript.UpdateFulfillmentScriptBuilder UpdateFulfillmentScriptOp
        {
            get
            {
                var opBuilder = new Operation.UpdateFulfillmentScript.UpdateFulfillmentScriptBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

        public List<Model.FulfillmentScriptInfo>? ListFulfillmentScripts(ListFulfillmentScripts input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<List<Model.FulfillmentScriptInfo>?> ListFulfillmentScriptsAsync(ListFulfillmentScripts input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.FulfillmentScriptInfo? GetFulfillmentScript(GetFulfillmentScript input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.FulfillmentScriptInfo?> GetFulfillmentScriptAsync(GetFulfillmentScript input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.FulfillmentScriptInfo? CreateFulfillmentScript(CreateFulfillmentScript input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.FulfillmentScriptInfo?> CreateFulfillmentScriptAsync(CreateFulfillmentScript input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteFulfillmentScript(DeleteFulfillmentScript input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task DeleteFulfillmentScriptAsync(DeleteFulfillmentScript input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.FulfillmentScriptInfo? UpdateFulfillmentScript(UpdateFulfillmentScript input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.FulfillmentScriptInfo?> UpdateFulfillmentScriptAsync(UpdateFulfillmentScript input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}