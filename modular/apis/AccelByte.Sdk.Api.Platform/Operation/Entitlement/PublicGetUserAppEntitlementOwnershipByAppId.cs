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
    /// publicGetUserAppEntitlementOwnershipByAppId
    ///
    /// Get user app entitlement ownership by appId.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="NAMESPACE:{namespace}:USER:{userId}:ENTITLEMENT", action=2 (READ)
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
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.Ownership? Execute(
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
        
        public Model.Ownership? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.Ownership>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.Ownership>(payload);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}