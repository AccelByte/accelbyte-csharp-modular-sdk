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

using AccelByte.Sdk.Api.Legal.Model;

namespace AccelByte.Sdk.Api.Legal.Operation
{
    /// <summary>
    /// createPolicy
    ///
    /// Create a legal policy.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:*:LEGAL", action=1 (CREATE)
    /// </summary>
    public class CreatePolicy : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreatePolicyBuilder Builder { get => new CreatePolicyBuilder(); }

        public class CreatePolicyBuilder
            : OperationBuilder<CreatePolicyBuilder>
        {


            public Model.CreateBasePolicyRequest? Body { get; set; }




            internal CreatePolicyBuilder() { }

            internal CreatePolicyBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public CreatePolicyBuilder SetBody(Model.CreateBasePolicyRequest _body)
            {
                Body = _body;
                return this;
            }




            public CreatePolicy Build(
            )
            {
                CreatePolicy op = new CreatePolicy(this
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.CreateBasePolicyResponse? Execute(
            )
            {
                CreatePolicy op = Build(
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
        }

        private CreatePolicy(CreatePolicyBuilder builder
        )
        {
            
            

            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CreatePolicy(
            Model.CreateBasePolicyRequest body            
        )
        {
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/admin/base-policies";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.CreateBasePolicyResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.CreateBasePolicyResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.CreateBasePolicyResponse>(payload);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}