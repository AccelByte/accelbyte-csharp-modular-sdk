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
    /// consumeUserEntitlement
    ///
    /// Consume user entitlement. If the entitlement useCount is 0, the status will be CONSUMED.
    /// Other detail info:
    /// 
    ///   * Returns : consumed entitlement
    /// </summary>
    public class ConsumeUserEntitlement : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ConsumeUserEntitlementBuilder Builder { get => new ConsumeUserEntitlementBuilder(); }

        public class ConsumeUserEntitlementBuilder
            : OperationBuilder<ConsumeUserEntitlementBuilder>
        {





            internal ConsumeUserEntitlementBuilder() { }

            internal ConsumeUserEntitlementBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public ConsumeUserEntitlement Build(
                AdminEntitlementDecrement body,
                string entitlementId,
                string namespace_,
                string userId
            )
            {
                ConsumeUserEntitlement op = new ConsumeUserEntitlement(this,
                    body,
                    entitlementId,
                    namespace_,
                    userId
                );

                op.SetBaseFields<ConsumeUserEntitlementBuilder>(this);
                return op;
            }

            public ConsumeUserEntitlement.Response Execute(
                AdminEntitlementDecrement body,
                string entitlementId,
                string namespace_,
                string userId
            )
            {
                ConsumeUserEntitlement op = Build(
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
            public async Task<ConsumeUserEntitlement.Response> ExecuteAsync(
                AdminEntitlementDecrement body,
                string entitlementId,
                string namespace_,
                string userId
            )
            {
                ConsumeUserEntitlement op = Build(
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

        private ConsumeUserEntitlement(ConsumeUserEntitlementBuilder builder,
            AdminEntitlementDecrement body,
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

        #region Response Part        
        public class Response : ApiResponse<Model.EntitlementDecrementResult>
        {

            public ErrorEntity? Error400 { get; set; } = null;

            public ErrorEntity? Error404 { get; set; } = null;

            public ErrorEntity? Error409 { get; set; } = null;


            protected override string GetFullOperationId() => "Platform::Entitlement::ConsumeUserEntitlement";
        }

        #endregion

        public ConsumeUserEntitlement(
            string entitlementId,
            string namespace_,
            string userId,
            Model.AdminEntitlementDecrement body
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

        public ConsumeUserEntitlement.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new ConsumeUserEntitlement.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.EntitlementDecrementResult>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
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