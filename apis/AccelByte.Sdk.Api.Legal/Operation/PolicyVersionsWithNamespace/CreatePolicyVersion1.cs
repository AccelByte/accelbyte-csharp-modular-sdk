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
    /// createPolicyVersion_1
    ///
    /// Create a version of a particular country-specific policy.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:*:LEGAL", action=1 (CREATE)
    /// </summary>
    public class CreatePolicyVersion1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreatePolicyVersion1Builder Builder { get => new CreatePolicyVersion1Builder(); }

        public class CreatePolicyVersion1Builder
            : OperationBuilder<CreatePolicyVersion1Builder>
        {


            public Model.CreatePolicyVersionRequest? Body { get; set; }




            internal CreatePolicyVersion1Builder() { }

            internal CreatePolicyVersion1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public CreatePolicyVersion1Builder SetBody(Model.CreatePolicyVersionRequest _body)
            {
                Body = _body;
                return this;
            }




            public CreatePolicyVersion1 Build(
                string namespace_,
                string policyId
            )
            {
                CreatePolicyVersion1 op = new CreatePolicyVersion1(this,
                    namespace_,
                    policyId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.CreatePolicyVersionResponse? Execute(
                string namespace_,
                string policyId
            )
            {
                CreatePolicyVersion1 op = Build(
                    namespace_,
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
        }

        private CreatePolicyVersion1(CreatePolicyVersion1Builder builder,
            string namespace_,
            string policyId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["policyId"] = policyId;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CreatePolicyVersion1(
            string namespace_,
            string policyId,
            Model.CreatePolicyVersionRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["policyId"] = policyId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/admin/namespaces/{namespace}/policies/{policyId}/versions";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.CreatePolicyVersionResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.CreatePolicyVersionResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.CreatePolicyVersionResponse>(payload);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}