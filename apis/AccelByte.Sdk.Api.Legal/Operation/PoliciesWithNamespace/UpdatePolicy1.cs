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
    /// updatePolicy_1
    ///
    /// Update country-specific policy.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:LEGAL", action=4 (UPDATE)
    /// </summary>
    public class UpdatePolicy1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdatePolicy1Builder Builder { get => new UpdatePolicy1Builder(); }

        public class UpdatePolicy1Builder
            : OperationBuilder<UpdatePolicy1Builder>
        {


            public Model.UpdatePolicyRequest? Body { get; set; }




            internal UpdatePolicy1Builder() { }

            internal UpdatePolicy1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public UpdatePolicy1Builder SetBody(Model.UpdatePolicyRequest _body)
            {
                Body = _body;
                return this;
            }




            public UpdatePolicy1 Build(
                string namespace_,
                string policyId
            )
            {
                UpdatePolicy1 op = new UpdatePolicy1(this,
                    namespace_,
                    policyId
                );

                op.SetBaseFields<UpdatePolicy1Builder>(this);
                return op;
            }

            public void Execute(
                string namespace_,
                string policyId
            )
            {
                UpdatePolicy1 op = Build(
                    namespace_,
                    policyId
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

        private UpdatePolicy1(UpdatePolicy1Builder builder,
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

        public UpdatePolicy1(
            string namespace_,
            string policyId,
            Model.UpdatePolicyRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["policyId"] = policyId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/admin/namespaces/{namespace}/policies/{policyId}";

        public override HttpMethod Method => HttpMethod.Patch;

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