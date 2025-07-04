// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
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
using System.Threading.Tasks;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Net.Http;

using AccelByte.Sdk.Api.Match2.Model;

namespace AccelByte.Sdk.Api.Match2.Operation
{
    /// <summary>
    /// DeleteRuleSet
    ///
    /// Deletes an existing rule set.
    /// </summary>
    public class DeleteRuleSet : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteRuleSetBuilder Builder { get => new DeleteRuleSetBuilder(); }

        public class DeleteRuleSetBuilder
            : OperationBuilder<DeleteRuleSetBuilder>
        {





            internal DeleteRuleSetBuilder() { }

            internal DeleteRuleSetBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteRuleSet Build(
                string namespace_,
                string ruleset
            )
            {
                DeleteRuleSet op = new DeleteRuleSet(this,
                    namespace_,                    
                    ruleset                    
                );

                op.SetBaseFields<DeleteRuleSetBuilder>(this);
                return op;
            }

            public DeleteRuleSet.Response Execute(
                string namespace_,
                string ruleset
            )
            {
                DeleteRuleSet op = Build(
                    namespace_,
                    ruleset
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<DeleteRuleSet.Response> ExecuteAsync(
                string namespace_,
                string ruleset
            )
            {
                DeleteRuleSet op = Build(
                    namespace_,
                    ruleset
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
        }

        private DeleteRuleSet(DeleteRuleSetBuilder builder,
            string namespace_,
            string ruleset
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["ruleset"] = ruleset;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {

            public ResponseError? Error401 { get; set; } = null;

            public ResponseError? Error403 { get; set; } = null;

            public ResponseError? Error404 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Match2::RuleSets::DeleteRuleSet";
        }

        #endregion

        public DeleteRuleSet(
            string namespace_,            
            string ruleset            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["ruleset"] = ruleset;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/match2/v1/namespaces/{namespace}/rulesets/{ruleset}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public DeleteRuleSet.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new DeleteRuleSet.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };

            if (code == (HttpStatusCode)401)
            
            {
                response.Error401 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            
            {
                response.Error403 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)
            
            {
                response.Error404 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            
            {
                response.Error500 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}