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
    /// enableUserEntitlement
    ///
    /// Enable user entitlement.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:ENTITLEMENT", action=4 (UPDATE)
    ///   *  Returns : enable entitlement
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
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.EntitlementInfo? Execute(
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

        public override List<string> Consumes => new() {  };

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