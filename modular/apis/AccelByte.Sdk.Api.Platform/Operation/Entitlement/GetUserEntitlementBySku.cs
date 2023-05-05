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
    /// getUserEntitlementBySku
    ///
    /// Get user entitlement by sku.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:ENTITLEMENT", action=2 (READ)
    /// </summary>
    public class GetUserEntitlementBySku : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetUserEntitlementBySkuBuilder Builder { get => new GetUserEntitlementBySkuBuilder(); }

        public class GetUserEntitlementBySkuBuilder
            : OperationBuilder<GetUserEntitlementBySkuBuilder>
        {

            public bool? ActiveOnly { get; set; }

            public GetUserEntitlementBySkuEntitlementClazz? EntitlementClazz { get; set; }





            internal GetUserEntitlementBySkuBuilder() { }

            internal GetUserEntitlementBySkuBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetUserEntitlementBySkuBuilder SetActiveOnly(bool _activeOnly)
            {
                ActiveOnly = _activeOnly;
                return this;
            }

            public GetUserEntitlementBySkuBuilder SetEntitlementClazz(GetUserEntitlementBySkuEntitlementClazz _entitlementClazz)
            {
                EntitlementClazz = _entitlementClazz;
                return this;
            }





            public GetUserEntitlementBySku Build(
                string namespace_,
                string userId,
                string sku
            )
            {
                GetUserEntitlementBySku op = new GetUserEntitlementBySku(this,
                    namespace_,                    
                    userId,                    
                    sku                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.EntitlementInfo? Execute(
                string namespace_,
                string userId,
                string sku
            )
            {
                GetUserEntitlementBySku op = Build(
                    namespace_,
                    userId,
                    sku
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

        private GetUserEntitlementBySku(GetUserEntitlementBySkuBuilder builder,
            string namespace_,
            string userId,
            string sku
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (builder.ActiveOnly != null) QueryParams["activeOnly"] = Convert.ToString(builder.ActiveOnly)!;
            if (builder.EntitlementClazz is not null) QueryParams["entitlementClazz"] = builder.EntitlementClazz.Value;
            if (sku is not null) QueryParams["sku"] = sku;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetUserEntitlementBySku(
            string namespace_,            
            string userId,            
            bool? activeOnly,            
            GetUserEntitlementBySkuEntitlementClazz? entitlementClazz,            
            string sku            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (activeOnly != null) QueryParams["activeOnly"] = Convert.ToString(activeOnly)!;
            if (entitlementClazz is not null) QueryParams["entitlementClazz"] = entitlementClazz.Value;
            if (sku is not null) QueryParams["sku"] = sku;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/bySku";

        public override HttpMethod Method => HttpMethod.Get;

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
                return JsonSerializer.Deserialize<Model.EntitlementInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.EntitlementInfo>(payload);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

    public class GetUserEntitlementBySkuEntitlementClazz : StringEnum<GetUserEntitlementBySkuEntitlementClazz>
    {
        public static readonly GetUserEntitlementBySkuEntitlementClazz APP
            = new GetUserEntitlementBySkuEntitlementClazz("APP");

        public static readonly GetUserEntitlementBySkuEntitlementClazz CODE
            = new GetUserEntitlementBySkuEntitlementClazz("CODE");

        public static readonly GetUserEntitlementBySkuEntitlementClazz ENTITLEMENT
            = new GetUserEntitlementBySkuEntitlementClazz("ENTITLEMENT");

        public static readonly GetUserEntitlementBySkuEntitlementClazz LOOTBOX
            = new GetUserEntitlementBySkuEntitlementClazz("LOOTBOX");

        public static readonly GetUserEntitlementBySkuEntitlementClazz MEDIA
            = new GetUserEntitlementBySkuEntitlementClazz("MEDIA");

        public static readonly GetUserEntitlementBySkuEntitlementClazz OPTIONBOX
            = new GetUserEntitlementBySkuEntitlementClazz("OPTIONBOX");

        public static readonly GetUserEntitlementBySkuEntitlementClazz SUBSCRIPTION
            = new GetUserEntitlementBySkuEntitlementClazz("SUBSCRIPTION");


        public static implicit operator GetUserEntitlementBySkuEntitlementClazz(string value)
        {
            return NewValue(value);
        }

        public GetUserEntitlementBySkuEntitlementClazz(string enumValue)
            : base(enumValue)
        {

        }
    }

}