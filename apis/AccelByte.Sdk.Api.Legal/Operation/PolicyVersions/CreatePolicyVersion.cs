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
    /// createPolicyVersion
    ///
    /// Create a version of a particular country-specific policy.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:*:LEGAL", action=1 (CREATE)
    /// </summary>
    public class CreatePolicyVersion : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreatePolicyVersionBuilder Builder { get => new CreatePolicyVersionBuilder(); }

        public class CreatePolicyVersionBuilder
            : OperationBuilder<CreatePolicyVersionBuilder>
        {


            public Model.CreatePolicyVersionRequest? Body { get; set; }




            internal CreatePolicyVersionBuilder() { }

            internal CreatePolicyVersionBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public CreatePolicyVersionBuilder SetBody(Model.CreatePolicyVersionRequest _body)
            {
                Body = _body;
                return this;
            }




            public CreatePolicyVersion Build(
                string policyId
            )
            {
                CreatePolicyVersion op = new CreatePolicyVersion(this,
                    policyId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.CreatePolicyVersionResponse? Execute(
                string policyId
            )
            {
                CreatePolicyVersion op = Build(
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

        private CreatePolicyVersion(CreatePolicyVersionBuilder builder,
            string policyId
        )
        {
            PathParams["policyId"] = policyId;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CreatePolicyVersion(
            string policyId,
            Model.CreatePolicyVersionRequest body
        )
        {
            PathParams["policyId"] = policyId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/admin/policies/{policyId}/versions";

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