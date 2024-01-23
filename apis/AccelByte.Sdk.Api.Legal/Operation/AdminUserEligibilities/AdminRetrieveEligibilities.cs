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
    /// adminRetrieveEligibilities
    ///
    /// Retrieve the active policies and its conformance status by user.
    /// This process only supports cross-namespace checking between game namespace and publisher namespace , that means if the active policy already accepted by the same user in publisher namespace, then it will also be considered as eligible in non-publisher namespace.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:LEGAL", action=2 (READ)
    /// </summary>
    public class AdminRetrieveEligibilities : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminRetrieveEligibilitiesBuilder Builder { get => new AdminRetrieveEligibilitiesBuilder(); }

        public class AdminRetrieveEligibilitiesBuilder
            : OperationBuilder<AdminRetrieveEligibilitiesBuilder>
        {

            public string? PublisherUserId { get; set; }





            internal AdminRetrieveEligibilitiesBuilder() { }

            internal AdminRetrieveEligibilitiesBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminRetrieveEligibilitiesBuilder SetPublisherUserId(string _publisherUserId)
            {
                PublisherUserId = _publisherUserId;
                return this;
            }





            public AdminRetrieveEligibilities Build(
                string namespace_,
                string userId,
                string clientId,
                string countryCode
            )
            {
                AdminRetrieveEligibilities op = new AdminRetrieveEligibilities(this,
                    namespace_,
                    userId,
                    clientId,
                    countryCode
                );

                op.SetBaseFields<AdminRetrieveEligibilitiesBuilder>(this);
                return op;
            }

            public Model.RetrieveUserEligibilitiesIndirectResponse? Execute(
                string namespace_,
                string userId,
                string clientId,
                string countryCode
            )
            {
                AdminRetrieveEligibilities op = Build(
                    namespace_,
                    userId,
                    clientId,
                    countryCode
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

        private AdminRetrieveEligibilities(AdminRetrieveEligibilitiesBuilder builder,
            string namespace_,
            string userId,
            string clientId,
            string countryCode
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (builder.PublisherUserId is not null) QueryParams["publisherUserId"] = builder.PublisherUserId;
            if (clientId is not null) QueryParams["clientId"] = clientId;
            if (countryCode is not null) QueryParams["countryCode"] = countryCode;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminRetrieveEligibilities(
            string namespace_,
            string userId,
            string? publisherUserId,
            string clientId,
            string countryCode
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (publisherUserId is not null) QueryParams["publisherUserId"] = publisherUserId;
            if (clientId is not null) QueryParams["clientId"] = clientId;
            if (countryCode is not null) QueryParams["countryCode"] = countryCode;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/admin/namespaces/{namespace}/users/{userId}/eligibilities";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.RetrieveUserEligibilitiesIndirectResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.RetrieveUserEligibilitiesIndirectResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.RetrieveUserEligibilitiesIndirectResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}