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
    /// enableUserEntitlement
    ///
    /// Enable user entitlement.
    /// Other detail info:
    /// 
    ///   * Returns : enable entitlement
    /// </summary>
    public class EnableUserEntitlement : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static EnableUserEntitlementBuilder Builder { get => new EnableUserEntitlementBuilder(); }

        public class EnableUserEntitlementBuilder
            : OperationBuilder<EnableUserEntitlementBuilder>
        {





            internal EnableUserEntitlementBuilder() { }

            internal EnableUserEntitlementBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public EnableUserEntitlement Build(
                string entitlementId,
                string namespace_,
                string userId
            )
            {
                EnableUserEntitlement op = new EnableUserEntitlement(this,
                    entitlementId,
                    namespace_,
                    userId
                );

                op.SetBaseFields<EnableUserEntitlementBuilder>(this);
                return op;
            }

            public EnableUserEntitlement.Response Execute(
                string entitlementId,
                string namespace_,
                string userId
            )
            {
                EnableUserEntitlement op = Build(
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
            public async Task<EnableUserEntitlement.Response> ExecuteAsync(
                string entitlementId,
                string namespace_,
                string userId
            )
            {
                EnableUserEntitlement op = Build(
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

        private EnableUserEntitlement(EnableUserEntitlementBuilder builder,
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

        #region Response Part        
        public class Response : ApiResponse<Model.EntitlementInfo>
        {

            public ErrorEntity? Error404 { get; set; } = null;

            public ErrorEntity? Error409 { get; set; } = null;


            protected override string GetFullOperationId() => "Platform::Entitlement::EnableUserEntitlement";
        }

        #endregion

        public EnableUserEntitlement(
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

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId}/enable";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public EnableUserEntitlement.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new EnableUserEntitlement.Response()
            {
                StatusCode = code,
                ContentType = contentType
            };

            if (code == (HttpStatusCode)204)
            {
                response.IsSuccess = true;
            }
            else if ((code == (HttpStatusCode)201) || (code == (HttpStatusCode)202) || (code == (HttpStatusCode)200))
            {
                response.Data = JsonSerializer.Deserialize<Model.EntitlementInfo>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)409)
            {
                response.Error409 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error409!.TranslateToApiError();
            }

            return response;
        }
    }

}