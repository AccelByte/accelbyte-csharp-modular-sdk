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
    /// getUserEntitlementHistories
    ///
    /// Get user entitlement histories.
    /// 
    /// Other detail info:
    /// 
    ///   * Returns : list of entitlement history
    /// </summary>
    public class GetUserEntitlementHistories : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetUserEntitlementHistoriesBuilder Builder { get => new GetUserEntitlementHistoriesBuilder(); }

        public class GetUserEntitlementHistoriesBuilder
            : OperationBuilder<GetUserEntitlementHistoriesBuilder>
        {





            internal GetUserEntitlementHistoriesBuilder() { }

            internal GetUserEntitlementHistoriesBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetUserEntitlementHistories Build(
                string entitlementId,
                string namespace_,
                string userId
            )
            {
                GetUserEntitlementHistories op = new GetUserEntitlementHistories(this,
                    entitlementId,                    
                    namespace_,                    
                    userId                    
                );

                op.SetBaseFields<GetUserEntitlementHistoriesBuilder>(this);
                return op;
            }

            public GetUserEntitlementHistories.Response Execute(
                string entitlementId,
                string namespace_,
                string userId
            )
            {
                GetUserEntitlementHistories op = Build(
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
            public async Task<GetUserEntitlementHistories.Response> ExecuteAsync(
                string entitlementId,
                string namespace_,
                string userId
            )
            {
                GetUserEntitlementHistories op = Build(
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

        private GetUserEntitlementHistories(GetUserEntitlementHistoriesBuilder builder,
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
        public class Response : ApiResponse<List<Model.EntitlementHistoryInfo>>
        {


            protected override string GetFullOperationId() => "Platform::Entitlement::GetUserEntitlementHistories";
        }

        #endregion

        public GetUserEntitlementHistories(
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

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId}/history";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public GetUserEntitlementHistories.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GetUserEntitlementHistories.Response()
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
                response.Data = JsonSerializer.Deserialize<List<Model.EntitlementHistoryInfo>>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }

            return response;
        }
    }

}