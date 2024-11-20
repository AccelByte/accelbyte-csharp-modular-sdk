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

using AccelByte.Sdk.Api.Legal.Model;

namespace AccelByte.Sdk.Api.Legal.Operation
{
    /// <summary>
    /// updatePolicy
    ///
    /// Update country-specific and country-group policy.
    /// </summary>
    public class UpdatePolicy : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdatePolicyBuilder Builder { get => new UpdatePolicyBuilder(); }

        public class UpdatePolicyBuilder
            : OperationBuilder<UpdatePolicyBuilder>
        {


            public Model.UpdatePolicyRequest? Body { get; set; }




            internal UpdatePolicyBuilder() { }

            internal UpdatePolicyBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public UpdatePolicyBuilder SetBody(Model.UpdatePolicyRequest _body)
            {
                Body = _body;
                return this;
            }




            public UpdatePolicy Build(
                string policyId
            )
            {
                UpdatePolicy op = new UpdatePolicy(this,
                    policyId                    
                );

                op.SetBaseFields<UpdatePolicyBuilder>(this);
                return op;
            }

            public UpdatePolicy.Response Execute(
                string policyId
            )
            {
                UpdatePolicy op = Build(
                    policyId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<UpdatePolicy.Response> ExecuteAsync(
                string policyId
            )
            {
                UpdatePolicy op = Build(
                    policyId
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

        private UpdatePolicy(UpdatePolicyBuilder builder,
            string policyId
        )
        {
            PathParams["policyId"] = policyId;
            
            

            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {

            public ErrorEntity? Error400 { get; set; } = null;


            protected override string GetFullOperationId() => "Legal::Policies::UpdatePolicy";
        }

        #endregion

        public UpdatePolicy(
            string policyId,            
            Model.UpdatePolicyRequest body            
        )
        {
            PathParams["policyId"] = policyId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/admin/policies/{policyId}";

        public override HttpMethod Method => HttpMethod.Patch;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public UpdatePolicy.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new UpdatePolicy.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };

            if (code == (HttpStatusCode)400)
            
            {
                response.Error400 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }

            return response;
        }
    }

}