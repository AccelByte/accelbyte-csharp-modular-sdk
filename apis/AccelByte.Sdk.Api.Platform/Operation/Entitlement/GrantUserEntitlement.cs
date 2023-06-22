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
    /// grantUserEntitlement
    ///
    /// Grant user entitlement.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:ENTITLEMENT", action=1 (CREATE)
    ///   *  Returns : granted entitlement
    /// </summary>
    public class GrantUserEntitlement : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GrantUserEntitlementBuilder Builder { get => new GrantUserEntitlementBuilder(); }

        public class GrantUserEntitlementBuilder
            : OperationBuilder<GrantUserEntitlementBuilder>
        {


            public List<Model.EntitlementGrant>? Body { get; set; }




            internal GrantUserEntitlementBuilder() { }

            internal GrantUserEntitlementBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public GrantUserEntitlementBuilder SetBody(List<Model.EntitlementGrant> _body)
            {
                Body = _body;
                return this;
            }




            public GrantUserEntitlement Build(
                string namespace_,
                string userId
            )
            {
                GrantUserEntitlement op = new GrantUserEntitlement(this,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public List<Model.StackableEntitlementInfo>? Execute(
                string namespace_,
                string userId
            )
            {
                GrantUserEntitlement op = Build(
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

        private GrantUserEntitlement(GrantUserEntitlementBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GrantUserEntitlement(
            string namespace_,
            string userId,
            List<Model.EntitlementGrant> body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/entitlements";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public List<Model.StackableEntitlementInfo>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.StackableEntitlementInfo>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.StackableEntitlementInfo>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}