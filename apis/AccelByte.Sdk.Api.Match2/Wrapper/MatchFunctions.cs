// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Match2.Model;
using AccelByte.Sdk.Api.Match2.Operation;

namespace AccelByte.Sdk.Api.Match2.Wrapper
{
    public class MatchFunctions
    {
        private readonly IAccelByteSdk _sdk;

        public MatchFunctions(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public MatchFunctionList.MatchFunctionListBuilder MatchFunctionListOp
        {
            get { return new Operation.MatchFunctionList.MatchFunctionListBuilder(_sdk); }
        }
        public CreateMatchFunction.CreateMatchFunctionBuilder CreateMatchFunctionOp
        {
            get { return new Operation.CreateMatchFunction.CreateMatchFunctionBuilder(_sdk); }
        }
        public UpdateMatchFunction.UpdateMatchFunctionBuilder UpdateMatchFunctionOp
        {
            get { return new Operation.UpdateMatchFunction.UpdateMatchFunctionBuilder(_sdk); }
        }
        public DeleteMatchFunction.DeleteMatchFunctionBuilder DeleteMatchFunctionOp
        {
            get { return new Operation.DeleteMatchFunction.DeleteMatchFunctionBuilder(_sdk); }
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
        public void CreateMatchFunction(CreateMatchFunction input) {
            var response = _sdk.RunRequest(input);

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
        public void DeleteMatchFunction(DeleteMatchFunction input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}