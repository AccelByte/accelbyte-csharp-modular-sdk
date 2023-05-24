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
    /// publicExistsAnyUserActiveEntitlement
    ///
    /// Exists any user active entitlement of specified itemIds, skus and appIds
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="NAMESPACE:{namespace}:USER:{userId}:ENTITLEMENT", action=2 (READ)
    /// </summary>
    public class PublicExistsAnyUserActiveEntitlement : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicExistsAnyUserActiveEntitlementBuilder Builder { get => new PublicExistsAnyUserActiveEntitlementBuilder(); }

        public class PublicExistsAnyUserActiveEntitlementBuilder
            : OperationBuilder<PublicExistsAnyUserActiveEntitlementBuilder>
        {

            public List<string>? AppIds { get; set; }

            public List<string>? ItemIds { get; set; }

            public List<string>? Skus { get; set; }





            internal PublicExistsAnyUserActiveEntitlementBuilder() { }

            internal PublicExistsAnyUserActiveEntitlementBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public PublicExistsAnyUserActiveEntitlementBuilder SetAppIds(List<string> _appIds)
            {
                AppIds = _appIds;
                return this;
            }

            public PublicExistsAnyUserActiveEntitlementBuilder SetItemIds(List<string> _itemIds)
            {
                ItemIds = _itemIds;
                return this;
            }

            public PublicExistsAnyUserActiveEntitlementBuilder SetSkus(List<string> _skus)
            {
                Skus = _skus;
                return this;
            }





            public PublicExistsAnyUserActiveEntitlement Build(
                string namespace_,
                string userId
            )
            {
                PublicExistsAnyUserActiveEntitlement op = new PublicExistsAnyUserActiveEntitlement(this,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.Ownership? Execute(
                string namespace_,
                string userId
            )
            {
                PublicExistsAnyUserActiveEntitlement op = Build(
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

        private PublicExistsAnyUserActiveEntitlement(PublicExistsAnyUserActiveEntitlementBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (builder.AppIds is not null) QueryParams["appIds"] = builder.AppIds;
            if (builder.ItemIds is not null) QueryParams["itemIds"] = builder.ItemIds;
            if (builder.Skus is not null) QueryParams["skus"] = builder.Skus;



            CollectionFormatMap["appIds"] = "multi";
            CollectionFormatMap["itemIds"] = "multi";
            CollectionFormatMap["skus"] = "multi";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicExistsAnyUserActiveEntitlement(
            string namespace_,
            string userId,
            List<string>? appIds,
            List<string>? itemIds,
            List<string>? skus
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (appIds is not null) QueryParams["appIds"] = appIds;
            if (itemIds is not null) QueryParams["itemIds"] = itemIds;
            if (skus is not null) QueryParams["skus"] = skus;



            CollectionFormatMap["appIds"] = "multi";
            CollectionFormatMap["itemIds"] = "multi";
            CollectionFormatMap["skus"] = "multi";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/entitlements/ownership/any";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

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