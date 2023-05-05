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
    /// getUserEntitlementOwnershipByItemId
    ///
    /// Get user entitlement ownership by itemId.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:ENTITLEMENT", action=2 (READ)
    /// </summary>
    public class GetUserEntitlementOwnershipByItemId : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetUserEntitlementOwnershipByItemIdBuilder Builder { get => new GetUserEntitlementOwnershipByItemIdBuilder(); }

        public class GetUserEntitlementOwnershipByItemIdBuilder
            : OperationBuilder<GetUserEntitlementOwnershipByItemIdBuilder>
        {

            public GetUserEntitlementOwnershipByItemIdEntitlementClazz? EntitlementClazz { get; set; }





            internal GetUserEntitlementOwnershipByItemIdBuilder() { }

            internal GetUserEntitlementOwnershipByItemIdBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetUserEntitlementOwnershipByItemIdBuilder SetEntitlementClazz(GetUserEntitlementOwnershipByItemIdEntitlementClazz _entitlementClazz)
            {
                EntitlementClazz = _entitlementClazz;
                return this;
            }





            public GetUserEntitlementOwnershipByItemId Build(
                string namespace_,
                string userId,
                string itemId
            )
            {
                GetUserEntitlementOwnershipByItemId op = new GetUserEntitlementOwnershipByItemId(this,
                    namespace_,                    
                    userId,                    
                    itemId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.TimedOwnership? Execute(
                string namespace_,
                string userId,
                string itemId
            )
            {
                GetUserEntitlementOwnershipByItemId op = Build(
                    namespace_,
                    userId,
                    itemId
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

        private GetUserEntitlementOwnershipByItemId(GetUserEntitlementOwnershipByItemIdBuilder builder,
            string namespace_,
            string userId,
            string itemId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (builder.EntitlementClazz is not null) QueryParams["entitlementClazz"] = builder.EntitlementClazz.Value;
            if (itemId is not null) QueryParams["itemId"] = itemId;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetUserEntitlementOwnershipByItemId(
            string namespace_,            
            string userId,            
            GetUserEntitlementOwnershipByItemIdEntitlementClazz? entitlementClazz,            
            string itemId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (entitlementClazz is not null) QueryParams["entitlementClazz"] = entitlementClazz.Value;
            if (itemId is not null) QueryParams["itemId"] = itemId;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/ownership/byItemId";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.TimedOwnership? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.TimedOwnership>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.TimedOwnership>(payload);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

    public class GetUserEntitlementOwnershipByItemIdEntitlementClazz : StringEnum<GetUserEntitlementOwnershipByItemIdEntitlementClazz>
    {
        public static readonly GetUserEntitlementOwnershipByItemIdEntitlementClazz APP
            = new GetUserEntitlementOwnershipByItemIdEntitlementClazz("APP");

        public static readonly GetUserEntitlementOwnershipByItemIdEntitlementClazz CODE
            = new GetUserEntitlementOwnershipByItemIdEntitlementClazz("CODE");

        public static readonly GetUserEntitlementOwnershipByItemIdEntitlementClazz ENTITLEMENT
            = new GetUserEntitlementOwnershipByItemIdEntitlementClazz("ENTITLEMENT");

        public static readonly GetUserEntitlementOwnershipByItemIdEntitlementClazz LOOTBOX
            = new GetUserEntitlementOwnershipByItemIdEntitlementClazz("LOOTBOX");

        public static readonly GetUserEntitlementOwnershipByItemIdEntitlementClazz MEDIA
            = new GetUserEntitlementOwnershipByItemIdEntitlementClazz("MEDIA");

        public static readonly GetUserEntitlementOwnershipByItemIdEntitlementClazz OPTIONBOX
            = new GetUserEntitlementOwnershipByItemIdEntitlementClazz("OPTIONBOX");

        public static readonly GetUserEntitlementOwnershipByItemIdEntitlementClazz SUBSCRIPTION
            = new GetUserEntitlementOwnershipByItemIdEntitlementClazz("SUBSCRIPTION");


        public static implicit operator GetUserEntitlementOwnershipByItemIdEntitlementClazz(string value)
        {
            return NewValue(value);
        }

        public GetUserEntitlementOwnershipByItemIdEntitlementClazz(string enumValue)
            : base(enumValue)
        {

        }
    }

}