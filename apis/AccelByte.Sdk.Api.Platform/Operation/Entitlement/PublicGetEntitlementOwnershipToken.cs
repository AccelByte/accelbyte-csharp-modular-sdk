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
    /// publicGetEntitlementOwnershipToken
    ///
    /// Gets an entitlement ownership token of specified itemIds, skus and appIds
    /// 
    /// The decoded ownership token header like below:
    /// 
    /// 
    ///     {
    /// 
    ///       "kid": "9fd4cd5f991cebe3323605cd12d3b8bfdfc73fa4",
    /// 
    ///       "typ": "JWT",
    /// 
    ///       "alg": "RS256"
    /// 
    ///     }
    /// 
    /// 
    /// 
    /// That you can get the jwks by api /platform/jwks, if the configured private key is same as IAM,
    /// 
    /// you can also get jwks from IAM endpoint.
    /// 
    /// The decoded ownership token payload like below:
    /// 
    /// 
    ///     {
    /// 
    ///      "namespace": "accelbyte",
    /// 
    ///      "entitlements": [
    /// 
    ///       {
    /// 
    ///         "itemId": "4c1296291f604c199f7bb7f0ee02e5f8",
    /// 
    ///         "appType": null,
    /// 
    ///         "appId": null,
    /// 
    ///         "namespace": "accelbyte",
    /// 
    ///         "itemNamespace": "accelbyte",
    /// 
    ///         "sku": "prime-plus"
    /// 
    ///       },
    /// 
    ///       {
    /// 
    ///         "itemId": "e8f4974cf45c4e1f8d4f0c6990c518bd",
    /// 
    ///         "appType": "GAME",
    /// 
    ///         "appId": "omeganebula",
    /// 
    ///         "namespace": "accelbyte",
    /// 
    ///         "itemNamespace": "accelbyte",
    /// 
    ///         "sku": "APPG005ON"
    /// 
    ///       }
    /// 
    ///      ],
    /// 
    ///     "sub": "66459eb6a4e44e6fb0040bd20c1079a5",
    /// 
    ///     "exp": 1619624360,
    /// 
    ///     "iat": 1619624060
    /// 
    ///     }
    /// 
    /// 
    /// 
    /// if there's no active entitlement for the specific params, the entitlements section will be omitted.
    /// </summary>
    public class PublicGetEntitlementOwnershipToken : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetEntitlementOwnershipTokenBuilder Builder { get => new PublicGetEntitlementOwnershipTokenBuilder(); }

        public class PublicGetEntitlementOwnershipTokenBuilder
            : OperationBuilder<PublicGetEntitlementOwnershipTokenBuilder>
        {

            public List<string>? AppIds { get; set; }

            public List<string>? ItemIds { get; set; }

            public List<string>? Skus { get; set; }





            internal PublicGetEntitlementOwnershipTokenBuilder() { }

            internal PublicGetEntitlementOwnershipTokenBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public PublicGetEntitlementOwnershipTokenBuilder SetAppIds(List<string> _appIds)
            {
                AppIds = _appIds;
                return this;
            }

            public PublicGetEntitlementOwnershipTokenBuilder SetItemIds(List<string> _itemIds)
            {
                ItemIds = _itemIds;
                return this;
            }

            public PublicGetEntitlementOwnershipTokenBuilder SetSkus(List<string> _skus)
            {
                Skus = _skus;
                return this;
            }





            public PublicGetEntitlementOwnershipToken Build(
                string namespace_
            )
            {
                PublicGetEntitlementOwnershipToken op = new PublicGetEntitlementOwnershipToken(this,
                    namespace_                    
                );

                op.SetBaseFields<PublicGetEntitlementOwnershipTokenBuilder>(this);
                return op;
            }

            public PublicGetEntitlementOwnershipToken.Response Execute(
                string namespace_
            )
            {
                PublicGetEntitlementOwnershipToken op = Build(
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<PublicGetEntitlementOwnershipToken.Response> ExecuteAsync(
                string namespace_
            )
            {
                PublicGetEntitlementOwnershipToken op = Build(
                    namespace_
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

        private PublicGetEntitlementOwnershipToken(PublicGetEntitlementOwnershipTokenBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.AppIds is not null) QueryParams["appIds"] = builder.AppIds;
            if (builder.ItemIds is not null) QueryParams["itemIds"] = builder.ItemIds;
            if (builder.Skus is not null) QueryParams["skus"] = builder.Skus;
            

            
            CollectionFormatMap["appIds"] = "multi";
            CollectionFormatMap["itemIds"] = "multi";
            CollectionFormatMap["skus"] = "multi";
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.OwnershipToken>
        {


            protected override string GetFullOperationId() => "Platform::Entitlement::PublicGetEntitlementOwnershipToken";
        }

        #endregion

        public PublicGetEntitlementOwnershipToken(
            string namespace_,            
            List<string>? appIds,            
            List<string>? itemIds,            
            List<string>? skus            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (appIds is not null) QueryParams["appIds"] = appIds;
            if (itemIds is not null) QueryParams["itemIds"] = itemIds;
            if (skus is not null) QueryParams["skus"] = skus;
            

            
            CollectionFormatMap["appIds"] = "multi";
            CollectionFormatMap["itemIds"] = "multi";
            CollectionFormatMap["skus"] = "multi";
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/me/entitlements/ownershipToken";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public PublicGetEntitlementOwnershipToken.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new PublicGetEntitlementOwnershipToken.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.OwnershipToken>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }

            return response;
        }
    }

}