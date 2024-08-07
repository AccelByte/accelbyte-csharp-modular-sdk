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

using AccelByte.Sdk.Api.Achievement.Model;

namespace AccelByte.Sdk.Api.Achievement.Operation
{
    /// <summary>
    /// AdminListAchievements
    ///
    /// Required permission
    /// `ADMIN:NAMESPACE:{namespace}:ACHIEVEMENT [READ]` and scope `social`
    /// </summary>
    public class AdminListAchievements : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminListAchievementsBuilder Builder { get => new AdminListAchievementsBuilder(); }

        public class AdminListAchievementsBuilder
            : OperationBuilder<AdminListAchievementsBuilder>
        {

            public bool? Global { get; set; }

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public AdminListAchievementsSortBy? SortBy { get; set; }

            public List<string>? Tags { get; set; }





            internal AdminListAchievementsBuilder() { }

            internal AdminListAchievementsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminListAchievementsBuilder SetGlobal(bool _global)
            {
                Global = _global;
                return this;
            }

            public AdminListAchievementsBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminListAchievementsBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public AdminListAchievementsBuilder SetSortBy(AdminListAchievementsSortBy _sortBy)
            {
                SortBy = _sortBy;
                return this;
            }

            public AdminListAchievementsBuilder SetTags(List<string> _tags)
            {
                Tags = _tags;
                return this;
            }





            public AdminListAchievements Build(
                string namespace_
            )
            {
                AdminListAchievements op = new AdminListAchievements(this,
                    namespace_
                );

                op.SetBaseFields<AdminListAchievementsBuilder>(this);
                return op;
            }

            public Model.ModelsPaginatedAchievementResponse? Execute(
                string namespace_
            )
            {
                AdminListAchievements op = Build(
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
            public async Task<Model.ModelsPaginatedAchievementResponse?> ExecuteAsync(
                string namespace_
            )
            {
                AdminListAchievements op = Build(
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

        private AdminListAchievements(AdminListAchievementsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Global != null) QueryParams["global"] = Convert.ToString(builder.Global)!;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.SortBy is not null) QueryParams["sortBy"] = builder.SortBy.Value;
            if (builder.Tags is not null) QueryParams["tags"] = builder.Tags;



            CollectionFormatMap["tags"] = "csv";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminListAchievements(
            string namespace_,
            bool? global,
            long? limit,
            long? offset,
            AdminListAchievementsSortBy? sortBy,
            List<string>? tags
        )
        {
            PathParams["namespace"] = namespace_;

            if (global != null) QueryParams["global"] = Convert.ToString(global)!;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (sortBy is not null) QueryParams["sortBy"] = sortBy.Value;
            if (tags is not null) QueryParams["tags"] = tags;



            CollectionFormatMap["tags"] = "csv";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/achievement/v1/admin/namespaces/{namespace}/achievements";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsPaginatedAchievementResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsPaginatedAchievementResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsPaginatedAchievementResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

    public class AdminListAchievementsSortBy : StringEnum<AdminListAchievementsSortBy>
    {
        public static readonly AdminListAchievementsSortBy ListOrder
            = new AdminListAchievementsSortBy("listOrder");

        public static readonly AdminListAchievementsSortBy ListOrderasc
            = new AdminListAchievementsSortBy("listOrder:asc");

        public static readonly AdminListAchievementsSortBy ListOrderdesc
            = new AdminListAchievementsSortBy("listOrder:desc");

        public static readonly AdminListAchievementsSortBy CreatedAt
            = new AdminListAchievementsSortBy("createdAt");

        public static readonly AdminListAchievementsSortBy CreatedAtasc
            = new AdminListAchievementsSortBy("createdAt:asc");

        public static readonly AdminListAchievementsSortBy CreatedAtdesc
            = new AdminListAchievementsSortBy("createdAt:desc");

        public static readonly AdminListAchievementsSortBy UpdatedAt
            = new AdminListAchievementsSortBy("updatedAt");

        public static readonly AdminListAchievementsSortBy UpdatedAtasc
            = new AdminListAchievementsSortBy("updatedAt:asc");

        public static readonly AdminListAchievementsSortBy UpdatedAtdesc
            = new AdminListAchievementsSortBy("updatedAt:desc");


        public static implicit operator AdminListAchievementsSortBy(string value)
        {
            return NewValue(value);
        }

        public AdminListAchievementsSortBy(string enumValue)
            : base(enumValue)
        {

        }
    }

}