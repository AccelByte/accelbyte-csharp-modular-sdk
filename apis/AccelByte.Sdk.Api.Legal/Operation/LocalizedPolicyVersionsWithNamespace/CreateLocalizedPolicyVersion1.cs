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
    /// createLocalizedPolicyVersion_1
    ///
    /// Create a version of a particular country-specific policy.
    /// </summary>
    public class CreateLocalizedPolicyVersion1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateLocalizedPolicyVersion1Builder Builder { get => new CreateLocalizedPolicyVersion1Builder(); }

        public class CreateLocalizedPolicyVersion1Builder
            : OperationBuilder<CreateLocalizedPolicyVersion1Builder>
        {


            public Model.CreateLocalizedPolicyVersionRequest? Body { get; set; }




            internal CreateLocalizedPolicyVersion1Builder() { }

            internal CreateLocalizedPolicyVersion1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public CreateLocalizedPolicyVersion1Builder SetBody(Model.CreateLocalizedPolicyVersionRequest _body)
            {
                Body = _body;
                return this;
            }




            public CreateLocalizedPolicyVersion1 Build(
                string namespace_,
                string policyVersionId
            )
            {
                CreateLocalizedPolicyVersion1 op = new CreateLocalizedPolicyVersion1(this,
                    namespace_,
                    policyVersionId
                );

                op.SetBaseFields<CreateLocalizedPolicyVersion1Builder>(this);
                return op;
            }

            public Model.CreateLocalizedPolicyVersionResponse? Execute(
                string namespace_,
                string policyVersionId
            )
            {
                CreateLocalizedPolicyVersion1 op = Build(
                    namespace_,
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
            public async Task<Model.CreateLocalizedPolicyVersionResponse?> ExecuteAsync(
                string namespace_,
                string policyVersionId
            )
            {
                CreateLocalizedPolicyVersion1 op = Build(
                    namespace_,
                    policyVersionId
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

        private CreateLocalizedPolicyVersion1(CreateLocalizedPolicyVersion1Builder builder,
            string namespace_,
            string policyVersionId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["policyVersionId"] = policyVersionId;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CreateLocalizedPolicyVersion1(
            string namespace_,
            string policyVersionId,
            Model.CreateLocalizedPolicyVersionRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["policyVersionId"] = policyVersionId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/admin/namespaces/{namespace}/localized-policy-versions/versions/{policyVersionId}";

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