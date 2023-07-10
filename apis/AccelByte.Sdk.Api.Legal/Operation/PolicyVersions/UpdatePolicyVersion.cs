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
    /// updatePolicyVersion
    ///
    /// Update a particular policy version.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:*:LEGAL", action=4 (UPDATE)
    /// </summary>
    public class UpdatePolicyVersion : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdatePolicyVersionBuilder Builder { get => new UpdatePolicyVersionBuilder(); }

        public class UpdatePolicyVersionBuilder
            : OperationBuilder<UpdatePolicyVersionBuilder>
        {


            public Model.UpdatePolicyVersionRequest? Body { get; set; }




            internal UpdatePolicyVersionBuilder() { }

            internal UpdatePolicyVersionBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public UpdatePolicyVersionBuilder SetBody(Model.UpdatePolicyVersionRequest _body)
            {
                Body = _body;
                return this;
            }




            public UpdatePolicyVersion Build(
                string policyVersionId
            )
            {
                UpdatePolicyVersion op = new UpdatePolicyVersion(this,
                    policyVersionId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.UpdatePolicyVersionResponse? Execute(
                string policyVersionId
            )
            {
                UpdatePolicyVersion op = Build(
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

        private UpdatePolicyVersion(UpdatePolicyVersionBuilder builder,
            string policyVersionId
        )
        {
            PathParams["policyVersionId"] = policyVersionId;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdatePolicyVersion(
            string policyVersionId,
            Model.UpdatePolicyVersionRequest body
        )
        {
            PathParams["policyVersionId"] = policyVersionId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/admin/policies/versions/{policyVersionId}";

        public override HttpMethod Method => HttpMethod.Patch;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.UpdatePolicyVersionResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.UpdatePolicyVersionResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.UpdatePolicyVersionResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}