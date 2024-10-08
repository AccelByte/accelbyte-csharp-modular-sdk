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

using AccelByte.Sdk.Api.Platform.Model;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// publicTransferUserEntitlement
    ///
    /// Transfer a specified use count from entitlement A to B..Other detail info:
    ///   * Returns : entitlement
    /// </summary>
    public class PublicTransferUserEntitlement : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicTransferUserEntitlementBuilder Builder { get => new PublicTransferUserEntitlementBuilder(); }

        public class PublicTransferUserEntitlementBuilder
            : OperationBuilder<PublicTransferUserEntitlementBuilder>
        {





            internal PublicTransferUserEntitlementBuilder() { }

            internal PublicTransferUserEntitlementBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicTransferUserEntitlement Build(
                EntitlementTransferRequest body,
                string entitlementId,
                string namespace_,
                string userId
            )
            {
                PublicTransferUserEntitlement op = new PublicTransferUserEntitlement(this,
                    body,
                    entitlementId,
                    namespace_,
                    userId
                );

                op.SetBaseFields<PublicTransferUserEntitlementBuilder>(this);
                return op;
            }

            public Model.EntitlementTransferResult? Execute(
                EntitlementTransferRequest body,
                string entitlementId,
                string namespace_,
                string userId
            )
            {
                PublicTransferUserEntitlement op = Build(
                    body,
                    entitlementId,
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
            public async Task<Model.EntitlementTransferResult?> ExecuteAsync(
                EntitlementTransferRequest body,
                string entitlementId,
                string namespace_,
                string userId
            )
            {
                PublicTransferUserEntitlement op = Build(
                    body,
                    entitlementId,
                    namespace_,
                    userId
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

        private PublicTransferUserEntitlement(PublicTransferUserEntitlementBuilder builder,
            EntitlementTransferRequest body,
            string entitlementId,
            string namespace_,
            string userId
        )
        {
            PathParams["entitlementId"] = entitlementId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicTransferUserEntitlement(
            string entitlementId,
            string namespace_,
            string userId,
            Model.EntitlementTransferRequest body
        )
        {
            PathParams["entitlementId"] = entitlementId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId}/transfer";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.EntitlementTransferResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.EntitlementTransferResult>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.EntitlementTransferResult>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}