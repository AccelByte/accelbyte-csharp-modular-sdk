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
    /// publicGetUserAppEntitlementOwnershipByAppId
    ///
    /// Get user app entitlement ownership by appId.
    /// </summary>
    public class PublicGetUserAppEntitlementOwnershipByAppId : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetUserAppEntitlementOwnershipByAppIdBuilder Builder { get => new PublicGetUserAppEntitlementOwnershipByAppIdBuilder(); }

        public class PublicGetUserAppEntitlementOwnershipByAppIdBuilder
            : OperationBuilder<PublicGetUserAppEntitlementOwnershipByAppIdBuilder>
        {





            internal PublicGetUserAppEntitlementOwnershipByAppIdBuilder() { }

            internal PublicGetUserAppEntitlementOwnershipByAppIdBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicGetUserAppEntitlementOwnershipByAppId Build(
                string namespace_,
                string userId,
                string appId
            )
            {
                PublicGetUserAppEntitlementOwnershipByAppId op = new PublicGetUserAppEntitlementOwnershipByAppId(this,
                    namespace_,                    
                    userId,                    
                    appId                    
                );

                op.SetBaseFields<PublicGetUserAppEntitlementOwnershipByAppIdBuilder>(this);
                return op;
            }

            public PublicGetUserAppEntitlementOwnershipByAppId.Response Execute(
                string namespace_,
                string userId,
                string appId
            )
            {
                PublicGetUserAppEntitlementOwnershipByAppId op = Build(
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
            public async Task<PublicGetUserAppEntitlementOwnershipByAppId.Response> ExecuteAsync(
                string namespace_,
                string userId,
                string appId
            )
            {
                PublicGetUserAppEntitlementOwnershipByAppId op = Build(
                    namespace_,
                    userId,
                    appId
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

        private PublicGetUserAppEntitlementOwnershipByAppId(PublicGetUserAppEntitlementOwnershipByAppIdBuilder builder,
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

        #region Response Part        
        public class Response : ApiResponse<Model.Ownership>
        {


            protected override string GetFullOperationId() => "Platform::Entitlement::PublicGetUserAppEntitlementOwnershipByAppId";
        }

        #endregion

        public PublicGetUserAppEntitlementOwnershipByAppId(
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

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/entitlements/ownership/byAppId";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public PublicGetUserAppEntitlementOwnershipByAppId.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new PublicGetUserAppEntitlementOwnershipByAppId.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.Ownership>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }

            return response;
        }
    }

}