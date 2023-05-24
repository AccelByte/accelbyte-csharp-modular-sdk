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

using AccelByte.Sdk.Api.Platform.Model;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// consumeUserEntitlement
    ///
    /// Consume user entitlement. If the entitlement useCount is 0, the status will be CONSUMED.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:ENTITLEMENT", action=4 (UPDATE)
    ///   *  Returns : consumed entitlement
    /// </summary>
    public class ConsumeUserEntitlement : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ConsumeUserEntitlementBuilder Builder { get => new ConsumeUserEntitlementBuilder(); }

        public class ConsumeUserEntitlementBuilder
            : OperationBuilder<ConsumeUserEntitlementBuilder>
        {


            public Model.EntitlementDecrement? Body { get; set; }




            internal ConsumeUserEntitlementBuilder() { }

            internal ConsumeUserEntitlementBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public ConsumeUserEntitlementBuilder SetBody(Model.EntitlementDecrement _body)
            {
                Body = _body;
                return this;
            }




            public ConsumeUserEntitlement Build(
                string entitlementId,
                string namespace_,
                string userId
            )
            {
                ConsumeUserEntitlement op = new ConsumeUserEntitlement(this,
                    entitlementId,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.EntitlementDecrementResult? Execute(
                string entitlementId,
                string namespace_,
                string userId
            )
            {
                ConsumeUserEntitlement op = Build(
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
        }

        private ConsumeUserEntitlement(ConsumeUserEntitlementBuilder builder,
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

        public ConsumeUserEntitlement(
            string entitlementId,
            string namespace_,
            string userId,
            Model.EntitlementDecrement body
        )
        {
            PathParams["entitlementId"] = entitlementId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId}/decrement";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.EntitlementDecrementResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.EntitlementDecrementResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.EntitlementDecrementResult>(payload);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}