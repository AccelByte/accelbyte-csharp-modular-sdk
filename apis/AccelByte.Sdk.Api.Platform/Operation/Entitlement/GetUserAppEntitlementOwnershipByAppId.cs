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
    /// getUserAppEntitlementOwnershipByAppId
    ///
    /// Get user app entitlement ownership by appId.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:ENTITLEMENT", action=2 (READ)
    /// </summary>
    public class GetUserAppEntitlementOwnershipByAppId : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetUserAppEntitlementOwnershipByAppIdBuilder Builder { get => new GetUserAppEntitlementOwnershipByAppIdBuilder(); }

        public class GetUserAppEntitlementOwnershipByAppIdBuilder
            : OperationBuilder<GetUserAppEntitlementOwnershipByAppIdBuilder>
        {





            internal GetUserAppEntitlementOwnershipByAppIdBuilder() { }

            internal GetUserAppEntitlementOwnershipByAppIdBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetUserAppEntitlementOwnershipByAppId Build(
                string namespace_,
                string userId,
                string appId
            )
            {
                GetUserAppEntitlementOwnershipByAppId op = new GetUserAppEntitlementOwnershipByAppId(this,
                    namespace_,
                    userId,
                    appId
                );

                op.SetBaseFields<GetUserAppEntitlementOwnershipByAppIdBuilder>(this);
                return op;
            }

            public Model.Ownership? Execute(
                string namespace_,
                string userId,
                string appId
            )
            {
                GetUserAppEntitlementOwnershipByAppId op = Build(
                    namespace_,
                    userId,
                    appId
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

        private GetUserAppEntitlementOwnershipByAppId(GetUserAppEntitlementOwnershipByAppIdBuilder builder,
            string namespace_,
            string userId,
            string appId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (appId is not null) QueryParams["appId"] = appId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetUserAppEntitlementOwnershipByAppId(
            string namespace_,
            string userId,
            string appId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (appId is not null) QueryParams["appId"] = appId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/ownership/byAppId";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.Ownership? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.Ownership>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.Ownership>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}