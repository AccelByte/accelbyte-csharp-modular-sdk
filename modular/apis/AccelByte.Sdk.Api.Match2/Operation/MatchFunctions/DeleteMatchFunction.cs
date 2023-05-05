// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Net;
using System.Net.Http;
using System.IO;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Net.Http;

using AccelByte.Sdk.Api.Match2.Model;

namespace AccelByte.Sdk.Api.Match2.Operation
{
    /// <summary>
    /// DeleteMatchFunction
    ///
    /// Required Permission: NAMESPACE:{namespace}:MATCHMAKING:FUNCTIONS [DELETE]
    /// 
    /// Required Scope: social
    /// 
    /// Deletes an existing match function.
    /// </summary>
    public class DeleteMatchFunction : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteMatchFunctionBuilder Builder { get => new DeleteMatchFunctionBuilder(); }

        public class DeleteMatchFunctionBuilder
            : OperationBuilder<DeleteMatchFunctionBuilder>
        {





            internal DeleteMatchFunctionBuilder() { }

            internal DeleteMatchFunctionBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteMatchFunction Build(
                string name,
                string namespace_
            )
            {
                DeleteMatchFunction op = new DeleteMatchFunction(this,
                    name,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public void Execute(
                string name,
                string namespace_
            )
            {
                DeleteMatchFunction op = Build(
                    name,
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
        }

        private DeleteMatchFunction(DeleteMatchFunctionBuilder builder,
            string name,
            string namespace_
        )
        {
            PathParams["name"] = name;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteMatchFunction(
            string name,            
            string namespace_            
        )
        {
            PathParams["name"] = name;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/match2/v1/namespaces/{namespace}/match-functions/{name}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return;
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}