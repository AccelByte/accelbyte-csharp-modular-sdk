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
    /// publicGetUserEntitlementOwnershipByItemIds
    ///
    /// Get user entitlement ownership by itemIds.
    /// </summary>
    public class PublicGetUserEntitlementOwnershipByItemIds : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetUserEntitlementOwnershipByItemIdsBuilder Builder { get => new PublicGetUserEntitlementOwnershipByItemIdsBuilder(); }

        public class PublicGetUserEntitlementOwnershipByItemIdsBuilder
            : OperationBuilder<PublicGetUserEntitlementOwnershipByItemIdsBuilder>
        {

            public List<string>? Ids { get; set; }





            internal PublicGetUserEntitlementOwnershipByItemIdsBuilder() { }

            internal PublicGetUserEntitlementOwnershipByItemIdsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public PublicGetUserEntitlementOwnershipByItemIdsBuilder SetIds(List<string> _ids)
            {
                Ids = _ids;
                return this;
            }





            public PublicGetUserEntitlementOwnershipByItemIds Build(
                string namespace_,
                string userId
            )
            {
                PublicGetUserEntitlementOwnershipByItemIds op = new PublicGetUserEntitlementOwnershipByItemIds(this,
                    namespace_,                    
                    userId                    
                );

                op.SetBaseFields<PublicGetUserEntitlementOwnershipByItemIdsBuilder>(this);
                return op;
            }

            public List<Model.EntitlementOwnership>? Execute(
                string namespace_,
                string userId
            )
            {
                PublicGetUserEntitlementOwnershipByItemIds op = Build(
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
            public async Task<List<Model.EntitlementOwnership>?> ExecuteAsync(
                string namespace_,
                string userId
            )
            {
                PublicGetUserEntitlementOwnershipByItemIds op = Build(
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

        private PublicGetUserEntitlementOwnershipByItemIds(PublicGetUserEntitlementOwnershipByItemIdsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (builder.Ids is not null) QueryParams["ids"] = builder.Ids;
            

            
            CollectionFormatMap["ids"] = "multi";
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGetUserEntitlementOwnershipByItemIds(
            string namespace_,            
            string userId,            
            List<string>? ids            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (ids is not null) QueryParams["ids"] = ids;
            

            
            CollectionFormatMap["ids"] = "multi";
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/entitlements/ownership/byItemIds";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };        
        
        public List<Model.EntitlementOwnership>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.EntitlementOwnership>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.EntitlementOwnership>>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}