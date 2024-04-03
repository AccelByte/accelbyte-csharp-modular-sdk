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

using AccelByte.Sdk.Api.Inventory.Model;

namespace AccelByte.Sdk.Api.Inventory.Operation
{
    /// <summary>
    /// AdminListTags
    ///
    /// 
    /// This endpoint will list all tags in a namespace.
    /// The response body will be in the form of standard pagination.
    /// 
    /// Permission: ADMIN:NAMESPACE:{namespace}:INVENTORY:TAG [READ]
    /// </summary>
    public class AdminListTags : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminListTagsBuilder Builder { get => new AdminListTagsBuilder(); }

        public class AdminListTagsBuilder
            : OperationBuilder<AdminListTagsBuilder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public string? Owner { get; set; }

            public AdminListTagsSortBy? SortBy { get; set; }





            internal AdminListTagsBuilder() { }

            internal AdminListTagsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminListTagsBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminListTagsBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public AdminListTagsBuilder SetOwner(string _owner)
            {
                Owner = _owner;
                return this;
            }

            public AdminListTagsBuilder SetSortBy(AdminListTagsSortBy _sortBy)
            {
                SortBy = _sortBy;
                return this;
            }





            public AdminListTags Build(
                string namespace_
            )
            {
                AdminListTags op = new AdminListTags(this,
                    namespace_
                );

                op.SetBaseFields<AdminListTagsBuilder>(this);
                return op;
            }

            public Model.ApimodelsListTagsResp? Execute(
                string namespace_
            )
            {
                AdminListTags op = Build(
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
            public async Task<Model.ApimodelsListTagsResp?> ExecuteAsync(
                string namespace_
            )
            {
                AdminListTags op = Build(
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

        private AdminListTags(AdminListTagsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Owner is not null) QueryParams["owner"] = builder.Owner;
            if (builder.SortBy is not null) QueryParams["sortBy"] = builder.SortBy.Value;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminListTags(
            string namespace_,
            long? limit,
            long? offset,
            string? owner,
            AdminListTagsSortBy? sortBy
        )
        {
            PathParams["namespace"] = namespace_;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (owner is not null) QueryParams["owner"] = owner;
            if (sortBy is not null) QueryParams["sortBy"] = sortBy.Value;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/inventory/v1/admin/namespaces/{namespace}/tags";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ApimodelsListTagsResp? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsListTagsResp>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsListTagsResp>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

    public class AdminListTagsSortBy : StringEnum<AdminListTagsSortBy>
    {
        public static readonly AdminListTagsSortBy CreatedAt
            = new AdminListTagsSortBy("createdAt");

        public static readonly AdminListTagsSortBy CreatedAtasc
            = new AdminListTagsSortBy("createdAt:asc");

        public static readonly AdminListTagsSortBy CreatedAtdesc
            = new AdminListTagsSortBy("createdAt:desc");

        public static readonly AdminListTagsSortBy Name
            = new AdminListTagsSortBy("name");

        public static readonly AdminListTagsSortBy Nameasc
            = new AdminListTagsSortBy("name:asc");

        public static readonly AdminListTagsSortBy Namedesc
            = new AdminListTagsSortBy("name:desc");


        public static implicit operator AdminListTagsSortBy(string value)
        {
            return NewValue(value);
        }

        public AdminListTagsSortBy(string enumValue)
            : base(enumValue)
        {

        }
    }

}