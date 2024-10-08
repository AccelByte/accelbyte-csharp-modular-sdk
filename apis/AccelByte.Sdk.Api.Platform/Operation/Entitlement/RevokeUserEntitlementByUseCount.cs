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
    /// revokeUserEntitlementByUseCount
    ///
    /// Revoke specified count of user entitlement.
    /// Other detail info:
    /// 
    ///   * Returns : The revoked entitlement
    /// </summary>
    public class RevokeUserEntitlementByUseCount : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RevokeUserEntitlementByUseCountBuilder Builder { get => new RevokeUserEntitlementByUseCountBuilder(); }

        public class RevokeUserEntitlementByUseCountBuilder
            : OperationBuilder<RevokeUserEntitlementByUseCountBuilder>
        {





            internal RevokeUserEntitlementByUseCountBuilder() { }

            internal RevokeUserEntitlementByUseCountBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public RevokeUserEntitlementByUseCount Build(
                RevokeUseCountRequest body,
                string entitlementId,
                string namespace_,
                string userId
            )
            {
                RevokeUserEntitlementByUseCount op = new RevokeUserEntitlementByUseCount(this,
                    body,
                    entitlementId,
                    namespace_,
                    userId
                );

                op.SetBaseFields<RevokeUserEntitlementByUseCountBuilder>(this);
                return op;
            }

            public Model.EntitlementIfc? Execute(
                RevokeUseCountRequest body,
                string entitlementId,
                string namespace_,
                string userId
            )
            {
                RevokeUserEntitlementByUseCount op = Build(
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
            public async Task<Model.EntitlementIfc?> ExecuteAsync(
                RevokeUseCountRequest body,
                string entitlementId,
                string namespace_,
                string userId
            )
            {
                RevokeUserEntitlementByUseCount op = Build(
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

        private RevokeUserEntitlementByUseCount(RevokeUserEntitlementByUseCountBuilder builder,
            RevokeUseCountRequest body,
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

        public RevokeUserEntitlementByUseCount(
            string entitlementId,
            string namespace_,
            string userId,
            Model.RevokeUseCountRequest body
        )
        {
            PathParams["entitlementId"] = entitlementId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId}/revoke/byUseCount";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.EntitlementIfc? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.EntitlementIfc>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.EntitlementIfc>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}