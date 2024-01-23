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

using AccelByte.Sdk.Api.Inventory.Model;

namespace AccelByte.Sdk.Api.Inventory.Operation
{
    /// <summary>
    /// PublicListItemTypes
    ///
    /// 
    /// This endpoint will list all item types in a namespace.
    /// The response body will be in the form of standard pagination.
    /// </summary>
    public class PublicListItemTypes : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicListItemTypesBuilder Builder { get => new PublicListItemTypesBuilder(); }

        public class PublicListItemTypesBuilder
            : OperationBuilder<PublicListItemTypesBuilder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public PublicListItemTypesSortBy? SortBy { get; set; }





            internal PublicListItemTypesBuilder() { }

            internal PublicListItemTypesBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public PublicListItemTypesBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public PublicListItemTypesBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public PublicListItemTypesBuilder SetSortBy(PublicListItemTypesSortBy _sortBy)
            {
                SortBy = _sortBy;
                return this;
            }





            public PublicListItemTypes Build(
                string namespace_
            )
            {
                PublicListItemTypes op = new PublicListItemTypes(this,
                    namespace_
                );

                op.SetBaseFields<PublicListItemTypesBuilder>(this);
                return op;
            }

            public Model.ApimodelsListItemTypesResp? Execute(
                string namespace_
            )
            {
                PublicListItemTypes op = Build(
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
        }

        private PublicListItemTypes(PublicListItemTypesBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.SortBy is not null) QueryParams["sortBy"] = builder.SortBy.Value;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicListItemTypes(
            string namespace_,
            long? limit,
            long? offset,
            PublicListItemTypesSortBy? sortBy
        )
        {
            PathParams["namespace"] = namespace_;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (sortBy is not null) QueryParams["sortBy"] = sortBy.Value;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/inventory/v1/public/namespaces/{namespace}/itemtypes";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ApimodelsListItemTypesResp? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsListItemTypesResp>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsListItemTypesResp>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

    public class PublicListItemTypesSortBy : StringEnum<PublicListItemTypesSortBy>
    {
        public static readonly PublicListItemTypesSortBy CreatedAt
            = new PublicListItemTypesSortBy("createdAt");

        public static readonly PublicListItemTypesSortBy CreatedAtasc
            = new PublicListItemTypesSortBy("createdAt:asc");

        public static readonly PublicListItemTypesSortBy CreatedAtdesc
            = new PublicListItemTypesSortBy("createdAt:desc");

        public static readonly PublicListItemTypesSortBy Name
            = new PublicListItemTypesSortBy("name");

        public static readonly PublicListItemTypesSortBy Nameasc
            = new PublicListItemTypesSortBy("name:asc");

        public static readonly PublicListItemTypesSortBy Namedesc
            = new PublicListItemTypesSortBy("name:desc");


        public static implicit operator PublicListItemTypesSortBy(string value)
        {
            return NewValue(value);
        }

        public PublicListItemTypesSortBy(string enumValue)
            : base(enumValue)
        {

        }
    }

}