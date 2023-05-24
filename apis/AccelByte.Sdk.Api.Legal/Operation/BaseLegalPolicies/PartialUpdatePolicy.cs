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
    /// partialUpdatePolicy
    ///
    /// Update an existing base policy.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:*:LEGAL", action=4 (UPDATE)
    /// </summary>
    public class PartialUpdatePolicy : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PartialUpdatePolicyBuilder Builder { get => new PartialUpdatePolicyBuilder(); }

        public class PartialUpdatePolicyBuilder
            : OperationBuilder<PartialUpdatePolicyBuilder>
        {


            public Model.UpdateBasePolicyRequest? Body { get; set; }




            internal PartialUpdatePolicyBuilder() { }

            internal PartialUpdatePolicyBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public PartialUpdatePolicyBuilder SetBody(Model.UpdateBasePolicyRequest _body)
            {
                Body = _body;
                return this;
            }




            public PartialUpdatePolicy Build(
                string basePolicyId
            )
            {
                PartialUpdatePolicy op = new PartialUpdatePolicy(this,
                    basePolicyId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.UpdateBasePolicyResponse? Execute(
                string basePolicyId
            )
            {
                PartialUpdatePolicy op = Build(
                    basePolicyId
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

        private PartialUpdatePolicy(PartialUpdatePolicyBuilder builder,
            string basePolicyId
        )
        {
            PathParams["basePolicyId"] = basePolicyId;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PartialUpdatePolicy(
            string basePolicyId,
            Model.UpdateBasePolicyRequest body
        )
        {
            PathParams["basePolicyId"] = basePolicyId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/admin/base-policies/{basePolicyId}";

        public override HttpMethod Method => HttpMethod.Patch;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.UpdateBasePolicyResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.UpdateBasePolicyResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.UpdateBasePolicyResponse>(payload);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}