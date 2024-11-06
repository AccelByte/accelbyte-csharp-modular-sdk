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
    /// preCheckRevokeUserEntitlementByUseCount
    ///
    /// Checks if specified use count of user entitlement can be revoked without actually revoking it.
    /// Other detail info:
    /// 
    ///   * Returns : true if revokable, false otherwise
    /// </summary>
    public class PreCheckRevokeUserEntitlementByUseCount : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PreCheckRevokeUserEntitlementByUseCountBuilder Builder { get => new PreCheckRevokeUserEntitlementByUseCountBuilder(); }

        public class PreCheckRevokeUserEntitlementByUseCountBuilder
            : OperationBuilder<PreCheckRevokeUserEntitlementByUseCountBuilder>
        {





            internal PreCheckRevokeUserEntitlementByUseCountBuilder() { }

            internal PreCheckRevokeUserEntitlementByUseCountBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PreCheckRevokeUserEntitlementByUseCount Build(
                string entitlementId,
                string namespace_,
                string userId,
                int quantity
            )
            {
                PreCheckRevokeUserEntitlementByUseCount op = new PreCheckRevokeUserEntitlementByUseCount(this,
                    entitlementId,                    
                    namespace_,                    
                    userId,                    
                    quantity                    
                );

                op.SetBaseFields<PreCheckRevokeUserEntitlementByUseCountBuilder>(this);
                return op;
            }

            public PreCheckRevokeUserEntitlementByUseCount.Response Execute(
                string entitlementId,
                string namespace_,
                string userId,
                int quantity
            )
            {
                PreCheckRevokeUserEntitlementByUseCount op = Build(
                    entitlementId,
                    namespace_,
                    userId,
                    quantity
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<PreCheckRevokeUserEntitlementByUseCount.Response> ExecuteAsync(
                string entitlementId,
                string namespace_,
                string userId,
                int quantity
            )
            {
                PreCheckRevokeUserEntitlementByUseCount op = Build(
                    entitlementId,
                    namespace_,
                    userId,
                    quantity
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

        private PreCheckRevokeUserEntitlementByUseCount(PreCheckRevokeUserEntitlementByUseCountBuilder builder,
            string entitlementId,
            string namespace_,
            string userId,
            int quantity
        )
        {
            PathParams["entitlementId"] = entitlementId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            QueryParams["quantity"] = Convert.ToString(quantity)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.EntitlementPrechekResult>
        {

            public ErrorEntity? Error404 { get; set; } = null;


            protected override string GetFullOperationId() => "Platform::Entitlement::PreCheckRevokeUserEntitlementByUseCount";
        }

        #endregion

        public PreCheckRevokeUserEntitlementByUseCount(
            string entitlementId,            
            string namespace_,            
            string userId,            
            int quantity            
        )
        {
            PathParams["entitlementId"] = entitlementId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            QueryParams["quantity"] = Convert.ToString(quantity)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId}/revoke/byUseCount/preCheck";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public PreCheckRevokeUserEntitlementByUseCount.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new PreCheckRevokeUserEntitlementByUseCount.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.EntitlementPrechekResult>(payload, ResponseJsonOptions);
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