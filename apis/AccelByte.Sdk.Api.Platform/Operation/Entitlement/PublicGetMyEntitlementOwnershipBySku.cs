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
    /// publicGetMyEntitlementOwnershipBySku
    ///
    /// Get my entitlement ownership by sku.
    /// 
    /// Other detail info:
    /// 
    ///   * Path's namespace :
    ///     * can be filled with publisher namespace in order to get publisher namespace entitlement ownership by sku
    ///     * can be filled with game namespace in order to get game namespace entitlement ownership by sku
    /// </summary>
    public class PublicGetMyEntitlementOwnershipBySku : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetMyEntitlementOwnershipBySkuBuilder Builder { get => new PublicGetMyEntitlementOwnershipBySkuBuilder(); }

        public class PublicGetMyEntitlementOwnershipBySkuBuilder
            : OperationBuilder<PublicGetMyEntitlementOwnershipBySkuBuilder>
        {

            public PublicGetMyEntitlementOwnershipBySkuEntitlementClazz? EntitlementClazz { get; set; }





            internal PublicGetMyEntitlementOwnershipBySkuBuilder() { }

            internal PublicGetMyEntitlementOwnershipBySkuBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public PublicGetMyEntitlementOwnershipBySkuBuilder SetEntitlementClazz(PublicGetMyEntitlementOwnershipBySkuEntitlementClazz _entitlementClazz)
            {
                EntitlementClazz = _entitlementClazz;
                return this;
            }





            public PublicGetMyEntitlementOwnershipBySku Build(
                string namespace_,
                string sku
            )
            {
                PublicGetMyEntitlementOwnershipBySku op = new PublicGetMyEntitlementOwnershipBySku(this,
                    namespace_,                    
                    sku                    
                );

                op.SetBaseFields<PublicGetMyEntitlementOwnershipBySkuBuilder>(this);
                return op;
            }

            public PublicGetMyEntitlementOwnershipBySku.Response Execute(
                string namespace_,
                string sku
            )
            {
                PublicGetMyEntitlementOwnershipBySku op = Build(
                    namespace_,
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
            public async Task<PublicGetMyEntitlementOwnershipBySku.Response> ExecuteAsync(
                string namespace_,
                string sku
            )
            {
                PublicGetMyEntitlementOwnershipBySku op = Build(
                    namespace_,
                    sku
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

        private PublicGetMyEntitlementOwnershipBySku(PublicGetMyEntitlementOwnershipBySkuBuilder builder,
            string namespace_,
            string sku
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.EntitlementClazz is not null) QueryParams["entitlementClazz"] = builder.EntitlementClazz.Value;
            if (sku is not null) QueryParams["sku"] = sku;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.TimedOwnership>
        {


            protected override string GetFullOperationId() => "Platform::Entitlement::PublicGetMyEntitlementOwnershipBySku";
        }

        #endregion

        public PublicGetMyEntitlementOwnershipBySku(
            string namespace_,            
            PublicGetMyEntitlementOwnershipBySkuEntitlementClazz? entitlementClazz,            
            string sku            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (entitlementClazz is not null) QueryParams["entitlementClazz"] = entitlementClazz.Value;
            if (sku is not null) QueryParams["sku"] = sku;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/me/entitlements/ownership/bySku";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public PublicGetMyEntitlementOwnershipBySku.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new PublicGetMyEntitlementOwnershipBySku.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.TimedOwnership>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }

            return response;
        }
    }

    public class PublicGetMyEntitlementOwnershipBySkuEntitlementClazz : StringEnum<PublicGetMyEntitlementOwnershipBySkuEntitlementClazz>
    {
        public static readonly PublicGetMyEntitlementOwnershipBySkuEntitlementClazz APP
            = new PublicGetMyEntitlementOwnershipBySkuEntitlementClazz("APP");

        public static readonly PublicGetMyEntitlementOwnershipBySkuEntitlementClazz CODE
            = new PublicGetMyEntitlementOwnershipBySkuEntitlementClazz("CODE");

        public static readonly PublicGetMyEntitlementOwnershipBySkuEntitlementClazz ENTITLEMENT
            = new PublicGetMyEntitlementOwnershipBySkuEntitlementClazz("ENTITLEMENT");

        public static readonly PublicGetMyEntitlementOwnershipBySkuEntitlementClazz LOOTBOX
            = new PublicGetMyEntitlementOwnershipBySkuEntitlementClazz("LOOTBOX");

        public static readonly PublicGetMyEntitlementOwnershipBySkuEntitlementClazz MEDIA
            = new PublicGetMyEntitlementOwnershipBySkuEntitlementClazz("MEDIA");

        public static readonly PublicGetMyEntitlementOwnershipBySkuEntitlementClazz OPTIONBOX
            = new PublicGetMyEntitlementOwnershipBySkuEntitlementClazz("OPTIONBOX");

        public static readonly PublicGetMyEntitlementOwnershipBySkuEntitlementClazz SUBSCRIPTION
            = new PublicGetMyEntitlementOwnershipBySkuEntitlementClazz("SUBSCRIPTION");


        public static implicit operator PublicGetMyEntitlementOwnershipBySkuEntitlementClazz(string value)
        {
            return NewValue(value);
        }

        public PublicGetMyEntitlementOwnershipBySkuEntitlementClazz(string enumValue)
            : base(enumValue)
        {

        }
    }

}