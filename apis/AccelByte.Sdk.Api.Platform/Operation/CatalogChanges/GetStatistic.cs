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
    /// getStatistic
    ///
    /// This API is used to query catalog changes statistics .
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:STORE", action=2 (READ)
    ///   *  Returns : catalog changes statistics changes
    /// </summary>
    public class GetStatistic : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetStatisticBuilder Builder { get => new GetStatisticBuilder(); }

        public class GetStatisticBuilder
            : OperationBuilder<GetStatisticBuilder>
        {

            public GetStatisticAction? Action { get; set; }

            public string? ItemSku { get; set; }

            public GetStatisticItemType? ItemType { get; set; }

            public GetStatisticType? Type { get; set; }

            public string? UpdatedAtEnd { get; set; }

            public string? UpdatedAtStart { get; set; }





            internal GetStatisticBuilder() { }

            internal GetStatisticBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetStatisticBuilder SetAction(GetStatisticAction _action)
            {
                Action = _action;
                return this;
            }

            public GetStatisticBuilder SetItemSku(string _itemSku)
            {
                ItemSku = _itemSku;
                return this;
            }

            public GetStatisticBuilder SetItemType(GetStatisticItemType _itemType)
            {
                ItemType = _itemType;
                return this;
            }

            public GetStatisticBuilder SetType(GetStatisticType _type)
            {
                Type = _type;
                return this;
            }

            public GetStatisticBuilder SetUpdatedAtEnd(string _updatedAtEnd)
            {
                UpdatedAtEnd = _updatedAtEnd;
                return this;
            }

            public GetStatisticBuilder SetUpdatedAtStart(string _updatedAtStart)
            {
                UpdatedAtStart = _updatedAtStart;
                return this;
            }





            public GetStatistic Build(
                string namespace_,
                string storeId
            )
            {
                GetStatistic op = new GetStatistic(this,
                    namespace_,
                    storeId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.CatalogChangeStatistics? Execute(
                string namespace_,
                string storeId
            )
            {
                GetStatistic op = Build(
                    namespace_,
                    storeId
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

        private GetStatistic(GetStatisticBuilder builder,
            string namespace_,
            string storeId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["storeId"] = storeId;

            if (builder.Action is not null) QueryParams["action"] = builder.Action.Value;
            if (builder.ItemSku is not null) QueryParams["itemSku"] = builder.ItemSku;
            if (builder.ItemType is not null) QueryParams["itemType"] = builder.ItemType.Value;
            if (builder.Type is not null) QueryParams["type"] = builder.Type.Value;
            if (builder.UpdatedAtEnd is not null) QueryParams["updatedAtEnd"] = builder.UpdatedAtEnd;
            if (builder.UpdatedAtStart is not null) QueryParams["updatedAtStart"] = builder.UpdatedAtStart;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetStatistic(
            string namespace_,
            string storeId,
            GetStatisticAction? action,
            string? itemSku,
            GetStatisticItemType? itemType,
            GetStatisticType? type,
            string? updatedAtEnd,
            string? updatedAtStart
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["storeId"] = storeId;

            if (action is not null) QueryParams["action"] = action.Value;
            if (itemSku is not null) QueryParams["itemSku"] = itemSku;
            if (itemType is not null) QueryParams["itemType"] = itemType.Value;
            if (type is not null) QueryParams["type"] = type.Value;
            if (updatedAtEnd is not null) QueryParams["updatedAtEnd"] = updatedAtEnd;
            if (updatedAtStart is not null) QueryParams["updatedAtStart"] = updatedAtStart;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/stores/{storeId}/catalogChanges/statistics";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.CatalogChangeStatistics? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.CatalogChangeStatistics>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.CatalogChangeStatistics>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

    public class GetStatisticAction : StringEnum<GetStatisticAction>
    {
        public static readonly GetStatisticAction CREATE
            = new GetStatisticAction("CREATE");

        public static readonly GetStatisticAction DELETE
            = new GetStatisticAction("DELETE");

        public static readonly GetStatisticAction UPDATE
            = new GetStatisticAction("UPDATE");


        public static implicit operator GetStatisticAction(string value)
        {
            return NewValue(value);
        }

        public GetStatisticAction(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class GetStatisticItemType : StringEnum<GetStatisticItemType>
    {
        public static readonly GetStatisticItemType APP
            = new GetStatisticItemType("APP");

        public static readonly GetStatisticItemType BUNDLE
            = new GetStatisticItemType("BUNDLE");

        public static readonly GetStatisticItemType CODE
            = new GetStatisticItemType("CODE");

        public static readonly GetStatisticItemType COINS
            = new GetStatisticItemType("COINS");

        public static readonly GetStatisticItemType EXTENSION
            = new GetStatisticItemType("EXTENSION");

        public static readonly GetStatisticItemType INGAMEITEM
            = new GetStatisticItemType("INGAMEITEM");

        public static readonly GetStatisticItemType LOOTBOX
            = new GetStatisticItemType("LOOTBOX");

        public static readonly GetStatisticItemType MEDIA
            = new GetStatisticItemType("MEDIA");

        public static readonly GetStatisticItemType OPTIONBOX
            = new GetStatisticItemType("OPTIONBOX");

        public static readonly GetStatisticItemType SEASON
            = new GetStatisticItemType("SEASON");

        public static readonly GetStatisticItemType SUBSCRIPTION
            = new GetStatisticItemType("SUBSCRIPTION");


        public static implicit operator GetStatisticItemType(string value)
        {
            return NewValue(value);
        }

        public GetStatisticItemType(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class GetStatisticType : StringEnum<GetStatisticType>
    {
        public static readonly GetStatisticType CATEGORY
            = new GetStatisticType("CATEGORY");

        public static readonly GetStatisticType ITEM
            = new GetStatisticType("ITEM");

        public static readonly GetStatisticType SECTION
            = new GetStatisticType("SECTION");

        public static readonly GetStatisticType STORE
            = new GetStatisticType("STORE");

        public static readonly GetStatisticType VIEW
            = new GetStatisticType("VIEW");


        public static implicit operator GetStatisticType(string value)
        {
            return NewValue(value);
        }

        public GetStatisticType(string enumValue)
            : base(enumValue)
        {

        }
    }

}