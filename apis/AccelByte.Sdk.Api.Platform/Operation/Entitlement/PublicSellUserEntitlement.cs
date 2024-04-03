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
    /// publicSellUserEntitlement
    ///
    /// Sell user entitlement. If the entitlement is consumable, useCount is 0, the status will be CONSUMED. If the entitlement is durable, the status will be SOLD. Other detail info:
    ///   * Required permission : resource="NAMESPACE:{namespace}:USER:{userId}:ENTITLEMENT", action=4 (UPDATE)
    ///   *  Returns : entitlement
    /// </summary>
    public class PublicSellUserEntitlement : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicSellUserEntitlementBuilder Builder { get => new PublicSellUserEntitlementBuilder(); }

        public class PublicSellUserEntitlementBuilder
            : OperationBuilder<PublicSellUserEntitlementBuilder>
        {


            public Model.EntitlementSoldRequest? Body { get; set; }




            internal PublicSellUserEntitlementBuilder() { }

            internal PublicSellUserEntitlementBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public PublicSellUserEntitlementBuilder SetBody(Model.EntitlementSoldRequest _body)
            {
                Body = _body;
                return this;
            }




            public PublicSellUserEntitlement Build(
                string entitlementId,
                string namespace_,
                string userId
            )
            {
                PublicSellUserEntitlement op = new PublicSellUserEntitlement(this,
                    entitlementId,
                    namespace_,
                    userId
                );

                op.SetBaseFields<PublicSellUserEntitlementBuilder>(this);
                return op;
            }

            public Model.EntitlementSoldResult? Execute(
                string entitlementId,
                string namespace_,
                string userId
            )
            {
                PublicSellUserEntitlement op = Build(
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
            public async Task<Model.EntitlementSoldResult?> ExecuteAsync(
                string entitlementId,
                string namespace_,
                string userId
            )
            {
                PublicSellUserEntitlement op = Build(
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

        private PublicSellUserEntitlement(PublicSellUserEntitlementBuilder builder,
            string entitlementId,
            string namespace_,
            string userId
        )
        {
            PathParams["entitlementId"] = entitlementId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicSellUserEntitlement(
            string entitlementId,
            string namespace_,
            string userId,
            Model.EntitlementSoldRequest body
        )
        {
            PathParams["entitlementId"] = entitlementId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId}/sell";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.EntitlementSoldResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.EntitlementSoldResult>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.EntitlementSoldResult>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}