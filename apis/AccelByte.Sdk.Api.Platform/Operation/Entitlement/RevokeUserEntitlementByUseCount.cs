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

            public RevokeUserEntitlementByUseCount.Response Execute(
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
            public async Task<RevokeUserEntitlementByUseCount.Response> ExecuteAsync(
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

        #region Response Part        
        public class Response : ApiResponse<Model.EntitlementIfc>
        {

            public ErrorEntity? Error404 { get; set; } = null;


            protected override string GetFullOperationId() => "Platform::Entitlement::RevokeUserEntitlementByUseCount";
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

        public RevokeUserEntitlementByUseCount.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new RevokeUserEntitlementByUseCount.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.EntitlementIfc>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }

            return response;
        }
    }

}