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
    public class MatchFunctions
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public MatchFunctions(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public MatchFunctions(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        public MatchFunctionList.MatchFunctionListBuilder MatchFunctionListOp
        {
            get
            {
                var opBuilder = new Operation.MatchFunctionList.MatchFunctionListBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public CreateMatchFunction.CreateMatchFunctionBuilder CreateMatchFunctionOp
        {
            get
            {
                var opBuilder = new Operation.CreateMatchFunction.CreateMatchFunctionBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public UpdateMatchFunction.UpdateMatchFunctionBuilder UpdateMatchFunctionOp
        {
            get
            {
                var opBuilder = new Operation.UpdateMatchFunction.UpdateMatchFunctionBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public DeleteMatchFunction.DeleteMatchFunctionBuilder DeleteMatchFunctionOp
        {
            get
            {
                var opBuilder = new Operation.DeleteMatchFunction.DeleteMatchFunctionBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

        public Model.ApiListMatchFunctionsResponse? MatchFunctionList(MatchFunctionList input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApiListMatchFunctionsResponse?> MatchFunctionListAsync(MatchFunctionList input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void CreateMatchFunction(CreateMatchFunction input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task CreateMatchFunctionAsync(CreateMatchFunction input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApiMatchFunctionConfig? UpdateMatchFunction(UpdateMatchFunction input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApiMatchFunctionConfig?> UpdateMatchFunctionAsync(UpdateMatchFunction input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteMatchFunction(DeleteMatchFunction input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task DeleteMatchFunctionAsync(DeleteMatchFunction input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}