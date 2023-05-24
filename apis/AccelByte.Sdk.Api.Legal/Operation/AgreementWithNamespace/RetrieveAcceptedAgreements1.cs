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
    /// retrieveAcceptedAgreements_1
    ///
    /// This API will return all accepted Legal Agreements for specified user. Other detail info:
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:LEGAL", action=2 (READ)
    /// </summary>
    public class RetrieveAcceptedAgreements1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RetrieveAcceptedAgreements1Builder Builder { get => new RetrieveAcceptedAgreements1Builder(); }

        public class RetrieveAcceptedAgreements1Builder
            : OperationBuilder<RetrieveAcceptedAgreements1Builder>
        {

            public bool? ExcludeOtherNamespacesPolicies { get; set; }





            internal RetrieveAcceptedAgreements1Builder() { }

            internal RetrieveAcceptedAgreements1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public RetrieveAcceptedAgreements1Builder SetExcludeOtherNamespacesPolicies(bool _excludeOtherNamespacesPolicies)
            {
                ExcludeOtherNamespacesPolicies = _excludeOtherNamespacesPolicies;
                return this;
            }





            public RetrieveAcceptedAgreements1 Build(
                string namespace_,
                string userId
            )
            {
                RetrieveAcceptedAgreements1 op = new RetrieveAcceptedAgreements1(this,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public List<Model.RetrieveAcceptedAgreementResponse>? Execute(
                string namespace_,
                string userId
            )
            {
                RetrieveAcceptedAgreements1 op = Build(
                    namespace_,
                    userId
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

        private RetrieveAcceptedAgreements1(RetrieveAcceptedAgreements1Builder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (builder.ExcludeOtherNamespacesPolicies != null) QueryParams["excludeOtherNamespacesPolicies"] = Convert.ToString(builder.ExcludeOtherNamespacesPolicies)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public RetrieveAcceptedAgreements1(
            string namespace_,
            string userId,
            bool? excludeOtherNamespacesPolicies
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (excludeOtherNamespacesPolicies != null) QueryParams["excludeOtherNamespacesPolicies"] = Convert.ToString(excludeOtherNamespacesPolicies)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/admin/namespaces/{namespace}/agreements/policies/users/{userId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public List<Model.RetrieveAcceptedAgreementResponse>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.RetrieveAcceptedAgreementResponse>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.RetrieveAcceptedAgreementResponse>>(payload);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}