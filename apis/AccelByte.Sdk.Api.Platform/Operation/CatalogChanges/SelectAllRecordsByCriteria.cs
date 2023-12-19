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
    /// selectAllRecordsByCriteria
    ///
    /// Select all changes by criteria
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:STORE", action=4 (UPDATE)
    /// </summary>
    public class SelectAllRecordsByCriteria : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SelectAllRecordsByCriteriaBuilder Builder { get => new SelectAllRecordsByCriteriaBuilder(); }

        public class SelectAllRecordsByCriteriaBuilder
            : OperationBuilder<SelectAllRecordsByCriteriaBuilder>
        {

            public SelectAllRecordsByCriteriaAction? Action { get; set; }

            public string? ItemSku { get; set; }

            public SelectAllRecordsByCriteriaItemType? ItemType { get; set; }

            public bool? Selected { get; set; }

            public SelectAllRecordsByCriteriaType? Type { get; set; }

            public string? UpdatedAtEnd { get; set; }

            public string? UpdatedAtStart { get; set; }





            internal SelectAllRecordsByCriteriaBuilder() { }

            internal SelectAllRecordsByCriteriaBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public SelectAllRecordsByCriteriaBuilder SetAction(SelectAllRecordsByCriteriaAction _action)
            {
                Action = _action;
                return this;
            }

            public SelectAllRecordsByCriteriaBuilder SetItemSku(string _itemSku)
            {
                ItemSku = _itemSku;
                return this;
            }

            public SelectAllRecordsByCriteriaBuilder SetItemType(SelectAllRecordsByCriteriaItemType _itemType)
            {
                ItemType = _itemType;
                return this;
            }

            public SelectAllRecordsByCriteriaBuilder SetSelected(bool _selected)
            {
                Selected = _selected;
                return this;
            }

            public SelectAllRecordsByCriteriaBuilder SetType(SelectAllRecordsByCriteriaType _type)
            {
                Type = _type;
                return this;
            }

            public SelectAllRecordsByCriteriaBuilder SetUpdatedAtEnd(string _updatedAtEnd)
            {
                UpdatedAtEnd = _updatedAtEnd;
                return this;
            }

            public SelectAllRecordsByCriteriaBuilder SetUpdatedAtStart(string _updatedAtStart)
            {
                UpdatedAtStart = _updatedAtStart;
                return this;
            }





            public SelectAllRecordsByCriteria Build(
                string namespace_,
                string storeId
            )
            {
                SelectAllRecordsByCriteria op = new SelectAllRecordsByCriteria(this,
                    namespace_,
                    storeId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public void Execute(
                string namespace_,
                string storeId
            )
            {
                SelectAllRecordsByCriteria op = Build(
                    namespace_,
                    storeId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private SelectAllRecordsByCriteria(SelectAllRecordsByCriteriaBuilder builder,
            string namespace_,
            string storeId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["storeId"] = storeId;

            if (builder.Action is not null) QueryParams["action"] = builder.Action.Value;
            if (builder.ItemSku is not null) QueryParams["itemSku"] = builder.ItemSku;
            if (builder.ItemType is not null) QueryParams["itemType"] = builder.ItemType.Value;
            if (builder.Selected != null) QueryParams["selected"] = Convert.ToString(builder.Selected)!;
            if (builder.Type is not null) QueryParams["type"] = builder.Type.Value;
            if (builder.UpdatedAtEnd is not null) QueryParams["updatedAtEnd"] = builder.UpdatedAtEnd;
            if (builder.UpdatedAtStart is not null) QueryParams["updatedAtStart"] = builder.UpdatedAtStart;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public SelectAllRecordsByCriteria(
            string namespace_,
            string storeId,
            SelectAllRecordsByCriteriaAction? action,
            string? itemSku,
            SelectAllRecordsByCriteriaItemType? itemType,
            bool? selected,
            SelectAllRecordsByCriteriaType? type,
            string? updatedAtEnd,
            string? updatedAtStart
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["storeId"] = storeId;

            if (action is not null) QueryParams["action"] = action.Value;
            if (itemSku is not null) QueryParams["itemSku"] = itemSku;
            if (itemType is not null) QueryParams["itemType"] = itemType.Value;
            if (selected != null) QueryParams["selected"] = Convert.ToString(selected)!;
            if (type is not null) QueryParams["type"] = type.Value;
            if (updatedAtEnd is not null) QueryParams["updatedAtEnd"] = updatedAtEnd;
            if (updatedAtStart is not null) QueryParams["updatedAtStart"] = updatedAtStart;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/stores/{storeId}/catalogChanges/selectAllByCriteria";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

    public class SelectAllRecordsByCriteriaAction : StringEnum<SelectAllRecordsByCriteriaAction>
    {
        public static readonly SelectAllRecordsByCriteriaAction CREATE
            = new SelectAllRecordsByCriteriaAction("CREATE");

        public static readonly SelectAllRecordsByCriteriaAction DELETE
            = new SelectAllRecordsByCriteriaAction("DELETE");

        public static readonly SelectAllRecordsByCriteriaAction UPDATE
            = new SelectAllRecordsByCriteriaAction("UPDATE");


        public static implicit operator SelectAllRecordsByCriteriaAction(string value)
        {
            return NewValue(value);
        }

        public SelectAllRecordsByCriteriaAction(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class SelectAllRecordsByCriteriaItemType : StringEnum<SelectAllRecordsByCriteriaItemType>
    {
        public static readonly SelectAllRecordsByCriteriaItemType APP
            = new SelectAllRecordsByCriteriaItemType("APP");

        public static readonly SelectAllRecordsByCriteriaItemType BUNDLE
            = new SelectAllRecordsByCriteriaItemType("BUNDLE");

        public static readonly SelectAllRecordsByCriteriaItemType CODE
            = new SelectAllRecordsByCriteriaItemType("CODE");

        public static readonly SelectAllRecordsByCriteriaItemType COINS
            = new SelectAllRecordsByCriteriaItemType("COINS");

        public static readonly SelectAllRecordsByCriteriaItemType EXTENSION
            = new SelectAllRecordsByCriteriaItemType("EXTENSION");

        public static readonly SelectAllRecordsByCriteriaItemType INGAMEITEM
            = new SelectAllRecordsByCriteriaItemType("INGAMEITEM");

        public static readonly SelectAllRecordsByCriteriaItemType LOOTBOX
            = new SelectAllRecordsByCriteriaItemType("LOOTBOX");

        public static readonly SelectAllRecordsByCriteriaItemType MEDIA
            = new SelectAllRecordsByCriteriaItemType("MEDIA");

        public static readonly SelectAllRecordsByCriteriaItemType OPTIONBOX
            = new SelectAllRecordsByCriteriaItemType("OPTIONBOX");

        public static readonly SelectAllRecordsByCriteriaItemType SEASON
            = new SelectAllRecordsByCriteriaItemType("SEASON");

        public static readonly SelectAllRecordsByCriteriaItemType SUBSCRIPTION
            = new SelectAllRecordsByCriteriaItemType("SUBSCRIPTION");


        public static implicit operator SelectAllRecordsByCriteriaItemType(string value)
        {
            return NewValue(value);
        }

        public SelectAllRecordsByCriteriaItemType(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class SelectAllRecordsByCriteriaType : StringEnum<SelectAllRecordsByCriteriaType>
    {
        public static readonly SelectAllRecordsByCriteriaType CATEGORY
            = new SelectAllRecordsByCriteriaType("CATEGORY");

        public static readonly SelectAllRecordsByCriteriaType ITEM
            = new SelectAllRecordsByCriteriaType("ITEM");

        public static readonly SelectAllRecordsByCriteriaType SECTION
            = new SelectAllRecordsByCriteriaType("SECTION");

        public static readonly SelectAllRecordsByCriteriaType STORE
            = new SelectAllRecordsByCriteriaType("STORE");

        public static readonly SelectAllRecordsByCriteriaType VIEW
            = new SelectAllRecordsByCriteriaType("VIEW");


        public static implicit operator SelectAllRecordsByCriteriaType(string value)
        {
            return NewValue(value);
        }

        public SelectAllRecordsByCriteriaType(string enumValue)
            : base(enumValue)
        {

        }
    }

}