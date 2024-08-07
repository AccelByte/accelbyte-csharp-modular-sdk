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
    /// retrieveLocalizedPolicyVersions
    ///
    /// Retrieve versions of a particular country-specific policy.
    /// </summary>
    public class RetrieveLocalizedPolicyVersions : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RetrieveLocalizedPolicyVersionsBuilder Builder { get => new RetrieveLocalizedPolicyVersionsBuilder(); }

        public class RetrieveLocalizedPolicyVersionsBuilder
            : OperationBuilder<RetrieveLocalizedPolicyVersionsBuilder>
        {





            internal RetrieveLocalizedPolicyVersionsBuilder() { }

            internal RetrieveLocalizedPolicyVersionsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public RetrieveLocalizedPolicyVersions Build(
                string policyVersionId
            )
            {
                RetrieveLocalizedPolicyVersions op = new RetrieveLocalizedPolicyVersions(this,
                    policyVersionId
                );

                op.SetBaseFields<RetrieveLocalizedPolicyVersionsBuilder>(this);
                return op;
            }

            public List<Model.RetrieveLocalizedPolicyVersionResponse>? Execute(
                string policyVersionId
            )
            {
                RetrieveLocalizedPolicyVersions op = Build(
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
            public async Task<List<Model.RetrieveLocalizedPolicyVersionResponse>?> ExecuteAsync(
                string policyVersionId
            )
            {
                RetrieveLocalizedPolicyVersions op = Build(
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

        private RetrieveLocalizedPolicyVersions(RetrieveLocalizedPolicyVersionsBuilder builder,
            string policyVersionId
        )
        {
            PathParams["policyVersionId"] = policyVersionId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public RetrieveLocalizedPolicyVersions(
            string policyVersionId
        )
        {
            PathParams["policyVersionId"] = policyVersionId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/admin/localized-policy-versions/versions/{policyVersionId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public List<Model.RetrieveLocalizedPolicyVersionResponse>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.RetrieveLocalizedPolicyVersionResponse>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.RetrieveLocalizedPolicyVersionResponse>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}