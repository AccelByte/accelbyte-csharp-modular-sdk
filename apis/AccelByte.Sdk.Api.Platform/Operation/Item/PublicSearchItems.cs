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
    /// publicSearchItems
    ///
    /// This API is used to search items by keyword in title, description and long description, It's language constrained, also if item not exist in specific region, default region item will return.
    /// 
    /// Other detail info:
    /// 
    ///   * Optional permission : resource="PREVIEW", action=1(CREATE) (user with this permission can view draft store item)
    ///   *  Optional permission : resource="SANDBOX", action=1(CREATE) (user with this permission can view draft store item)
    ///   *  Returns : the list of items
    /// </summary>
    public class PublicSearchItems : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicSearchItemsBuilder Builder { get => new PublicSearchItemsBuilder(); }

        public class PublicSearchItemsBuilder
            : OperationBuilder<PublicSearchItemsBuilder>
        {

            public PublicSearchItemsItemType? ItemType { get; set; }

            public int? Limit { get; set; }

            public int? Offset { get; set; }

            public string? Region { get; set; }

            public string? StoreId { get; set; }





            internal PublicSearchItemsBuilder() { }

            internal PublicSearchItemsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public PublicSearchItemsBuilder SetItemType(PublicSearchItemsItemType _itemType)
            {
                ItemType = _itemType;
                return this;
            }

            public PublicSearchItemsBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public PublicSearchItemsBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }

            public PublicSearchItemsBuilder SetRegion(string _region)
            {
                Region = _region;
                return this;
            }

            public PublicSearchItemsBuilder SetStoreId(string _storeId)
            {
                StoreId = _storeId;
                return this;
            }





            public PublicSearchItems Build(
                string namespace_,
                string keyword,
                string language
            )
            {
                PublicSearchItems op = new PublicSearchItems(this,
                    namespace_,
                    keyword,
                    language
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ItemPagingSlicedResult? Execute(
                string namespace_,
                string keyword,
                string language
            )
            {
                PublicSearchItems op = Build(
                    namespace_,
                    keyword,
                    language
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

        private PublicSearchItems(PublicSearchItemsBuilder builder,
            string namespace_,
            string keyword,
            string language
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.ItemType is not null) QueryParams["itemType"] = builder.ItemType.Value;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Region is not null) QueryParams["region"] = builder.Region;
            if (builder.StoreId is not null) QueryParams["storeId"] = builder.StoreId;
            if (keyword is not null) QueryParams["keyword"] = keyword;
            if (language is not null) QueryParams["language"] = language;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicSearchItems(
            string namespace_,
            PublicSearchItemsItemType? itemType,
            int? limit,
            int? offset,
            string? region,
            string? storeId,
            string keyword,
            string language
        )
        {
            PathParams["namespace"] = namespace_;

            if (itemType is not null) QueryParams["itemType"] = itemType.Value;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (region is not null) QueryParams["region"] = region;
            if (storeId is not null) QueryParams["storeId"] = storeId;
            if (keyword is not null) QueryParams["keyword"] = keyword;
            if (language is not null) QueryParams["language"] = language;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/items/search";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.ItemPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ItemPagingSlicedResult>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ItemPagingSlicedResult>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

    public class PublicSearchItemsItemType : StringEnum<PublicSearchItemsItemType>
    {
        public static readonly PublicSearchItemsItemType APP
            = new PublicSearchItemsItemType("APP");

        public static readonly PublicSearchItemsItemType BUNDLE
            = new PublicSearchItemsItemType("BUNDLE");

        public static readonly PublicSearchItemsItemType CODE
            = new PublicSearchItemsItemType("CODE");

        public static readonly PublicSearchItemsItemType COINS
            = new PublicSearchItemsItemType("COINS");

        public static readonly PublicSearchItemsItemType EXTENSION
            = new PublicSearchItemsItemType("EXTENSION");

        public static readonly PublicSearchItemsItemType INGAMEITEM
            = new PublicSearchItemsItemType("INGAMEITEM");

        public static readonly PublicSearchItemsItemType LOOTBOX
            = new PublicSearchItemsItemType("LOOTBOX");

        public static readonly PublicSearchItemsItemType MEDIA
            = new PublicSearchItemsItemType("MEDIA");

        public static readonly PublicSearchItemsItemType OPTIONBOX
            = new PublicSearchItemsItemType("OPTIONBOX");

        public static readonly PublicSearchItemsItemType SEASON
            = new PublicSearchItemsItemType("SEASON");

        public static readonly PublicSearchItemsItemType SUBSCRIPTION
            = new PublicSearchItemsItemType("SUBSCRIPTION");


        public static implicit operator PublicSearchItemsItemType(string value)
        {
            return NewValue(value);
        }

        public PublicSearchItemsItemType(string enumValue)
            : base(enumValue)
        {

        }
    }

}