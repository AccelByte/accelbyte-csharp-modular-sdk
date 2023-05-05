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
    /// getUserAppEntitlementByAppId
    ///
    /// Get user app entitlement by appId.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:ENTITLEMENT", action=2 (READ)
    /// </summary>
    public class GetUserAppEntitlementByAppId : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetUserAppEntitlementByAppIdBuilder Builder { get => new GetUserAppEntitlementByAppIdBuilder(); }

        public class GetUserAppEntitlementByAppIdBuilder
            : OperationBuilder<GetUserAppEntitlementByAppIdBuilder>
        {

            public bool? ActiveOnly { get; set; }





            internal GetUserAppEntitlementByAppIdBuilder() { }

            internal GetUserAppEntitlementByAppIdBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetUserAppEntitlementByAppIdBuilder SetActiveOnly(bool _activeOnly)
            {
                ActiveOnly = _activeOnly;
                return this;
            }





            public GetUserAppEntitlementByAppId Build(
                string namespace_,
                string userId,
                string appId
            )
            {
                GetUserAppEntitlementByAppId op = new GetUserAppEntitlementByAppId(this,
                    namespace_,                    
                    userId,                    
                    appId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.AppEntitlementInfo? Execute(
                string namespace_,
                string userId,
                string appId
            )
            {
                GetUserAppEntitlementByAppId op = Build(
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

        private GetUserAppEntitlementByAppId(GetUserAppEntitlementByAppIdBuilder builder,
            string namespace_,
            string userId,
            string appId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (builder.ActiveOnly != null) QueryParams["activeOnly"] = Convert.ToString(builder.ActiveOnly)!;
            if (appId is not null) QueryParams["appId"] = appId;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetUserAppEntitlementByAppId(
            string namespace_,            
            string userId,            
            bool? activeOnly,            
            string appId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (activeOnly != null) QueryParams["activeOnly"] = Convert.ToString(activeOnly)!;
            if (appId is not null) QueryParams["appId"] = appId;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/byAppId";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.AppEntitlementInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.AppEntitlementInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.AppEntitlementInfo>(payload);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}