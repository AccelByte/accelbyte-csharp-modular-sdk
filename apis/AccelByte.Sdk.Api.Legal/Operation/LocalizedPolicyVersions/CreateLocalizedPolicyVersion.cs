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
    /// createLocalizedPolicyVersion
    ///
    /// Create a version of a particular country-specific policy.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:*:LEGAL", action=1 (CREATE)
    /// </summary>
    public class CreateLocalizedPolicyVersion : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateLocalizedPolicyVersionBuilder Builder { get => new CreateLocalizedPolicyVersionBuilder(); }

        public class CreateLocalizedPolicyVersionBuilder
            : OperationBuilder<CreateLocalizedPolicyVersionBuilder>
        {


            public Model.CreateLocalizedPolicyVersionRequest? Body { get; set; }




            internal CreateLocalizedPolicyVersionBuilder() { }

            internal CreateLocalizedPolicyVersionBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public CreateLocalizedPolicyVersionBuilder SetBody(Model.CreateLocalizedPolicyVersionRequest _body)
            {
                Body = _body;
                return this;
            }




            public CreateLocalizedPolicyVersion Build(
                string policyVersionId
            )
            {
                CreateLocalizedPolicyVersion op = new CreateLocalizedPolicyVersion(this,
                    policyVersionId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.CreateLocalizedPolicyVersionResponse? Execute(
                string policyVersionId
            )
            {
                CreateLocalizedPolicyVersion op = Build(
                    policyVersionId
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

        private CreateLocalizedPolicyVersion(CreateLocalizedPolicyVersionBuilder builder,
            string policyVersionId
        )
        {
            PathParams["policyVersionId"] = policyVersionId;
            
            

            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CreateLocalizedPolicyVersion(
            string policyVersionId,            
            Model.CreateLocalizedPolicyVersionRequest body            
        )
        {
            PathParams["policyVersionId"] = policyVersionId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/admin/localized-policy-versions/versions/{policyVersionId}";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.CreateLocalizedPolicyVersionResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.CreateLocalizedPolicyVersionResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.CreateLocalizedPolicyVersionResponse>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}