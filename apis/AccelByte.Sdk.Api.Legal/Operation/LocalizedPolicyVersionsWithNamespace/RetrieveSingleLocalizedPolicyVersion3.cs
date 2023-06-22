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
    /// retrieveSingleLocalizedPolicyVersion_3
    ///
    /// Retrieve specific localized policy version including the policy version and base policy version where the localized policy version located.
    /// Other detail info:
    /// </summary>
    public class RetrieveSingleLocalizedPolicyVersion3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RetrieveSingleLocalizedPolicyVersion3Builder Builder { get => new RetrieveSingleLocalizedPolicyVersion3Builder(); }

        public class RetrieveSingleLocalizedPolicyVersion3Builder
            : OperationBuilder<RetrieveSingleLocalizedPolicyVersion3Builder>
        {





            internal RetrieveSingleLocalizedPolicyVersion3Builder() { }

            internal RetrieveSingleLocalizedPolicyVersion3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public RetrieveSingleLocalizedPolicyVersion3 Build(
                string localizedPolicyVersionId,
                string namespace_
            )
            {
                RetrieveSingleLocalizedPolicyVersion3 op = new RetrieveSingleLocalizedPolicyVersion3(this,
                    localizedPolicyVersionId,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.RetrieveLocalizedPolicyVersionPublicResponse? Execute(
                string localizedPolicyVersionId,
                string namespace_
            )
            {
                RetrieveSingleLocalizedPolicyVersion3 op = Build(
                    localizedPolicyVersionId,
                    namespace_
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

        private RetrieveSingleLocalizedPolicyVersion3(RetrieveSingleLocalizedPolicyVersion3Builder builder,
            string localizedPolicyVersionId,
            string namespace_
        )
        {
            PathParams["localizedPolicyVersionId"] = localizedPolicyVersionId;
            PathParams["namespace"] = namespace_;







        }
        #endregion

        public RetrieveSingleLocalizedPolicyVersion3(
            string localizedPolicyVersionId,
            string namespace_
        )
        {
            PathParams["localizedPolicyVersionId"] = localizedPolicyVersionId;
            PathParams["namespace"] = namespace_;







        }

        public override string Path => "/agreement/public/namespaces/{namespace}/localized-policy-versions/{localizedPolicyVersionId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.RetrieveLocalizedPolicyVersionPublicResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.RetrieveLocalizedPolicyVersionPublicResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.RetrieveLocalizedPolicyVersionPublicResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}