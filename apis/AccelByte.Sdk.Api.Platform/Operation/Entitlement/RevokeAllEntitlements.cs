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
    /// revokeAllEntitlements
    ///
    /// Revoke all entitlements of a user (This API is for testing purpose only)
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:ENTITLEMENT", action=4 (UPDATE)
    ///   *  Returns : revoked entitlements count
    /// </summary>
    public class RevokeAllEntitlements : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RevokeAllEntitlementsBuilder Builder { get => new RevokeAllEntitlementsBuilder(); }

        public class RevokeAllEntitlementsBuilder
            : OperationBuilder<RevokeAllEntitlementsBuilder>
        {





            internal RevokeAllEntitlementsBuilder() { }

            internal RevokeAllEntitlementsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public RevokeAllEntitlements Build(
                string namespace_,
                string userId
            )
            {
                RevokeAllEntitlements op = new RevokeAllEntitlements(this,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.BulkOperationResult? Execute(
                string namespace_,
                string userId
            )
            {
                RevokeAllEntitlements op = Build(
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

        private RevokeAllEntitlements(RevokeAllEntitlementsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public RevokeAllEntitlements(
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/revoke";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.BulkOperationResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.BulkOperationResult>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.BulkOperationResult>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}