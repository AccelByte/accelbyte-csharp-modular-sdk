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
    /// disableUserEntitlement
    ///
    /// Disable user entitlement if entitlement, only active entitlement can be disable, disabled entitlement can't consume.
    ///  Like revoke, it will lose the entitlement ownership, except disabled entitlement can enable.
    /// Other detail info:
    /// 
    ///   * Returns : disable entitlement
    /// </summary>
    public class DisableUserEntitlement : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DisableUserEntitlementBuilder Builder { get => new DisableUserEntitlementBuilder(); }

        public class DisableUserEntitlementBuilder
            : OperationBuilder<DisableUserEntitlementBuilder>
        {





            internal DisableUserEntitlementBuilder() { }

            internal DisableUserEntitlementBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DisableUserEntitlement Build(
                string entitlementId,
                string namespace_,
                string userId
            )
            {
                DisableUserEntitlement op = new DisableUserEntitlement(this,
                    entitlementId,
                    namespace_,
                    userId
                );

                op.SetBaseFields<DisableUserEntitlementBuilder>(this);
                return op;
            }

            public Model.EntitlementInfo? Execute(
                string entitlementId,
                string namespace_,
                string userId
            )
            {
                DisableUserEntitlement op = Build(
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
            public async Task<Model.EntitlementInfo?> ExecuteAsync(
                string entitlementId,
                string namespace_,
                string userId
            )
            {
                DisableUserEntitlement op = Build(
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

        private DisableUserEntitlement(DisableUserEntitlementBuilder builder,
            string entitlementId,
            string namespace_,
            string userId
        )
        {
            PathParams["entitlementId"] = entitlementId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DisableUserEntitlement(
            string entitlementId,
            string namespace_,
            string userId
        )
        {
            PathParams["entitlementId"] = entitlementId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId}/disable";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.EntitlementInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.EntitlementInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.EntitlementInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}