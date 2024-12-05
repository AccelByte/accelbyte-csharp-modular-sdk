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
    /// PublicListUserAchievements
    ///
    /// 
    /// 
    /// Required permission
    /// `NAMESPACE:{namespace}:USER:{userId}:ACHIEVEMENT [READ]` and scope `social`
    /// 
    /// 
    /// 
    /// 
    /// Note:
    /// 
    /// 
    /// 
    /// 
    /// User Achievement status value mean: `status = 1 (in progress)` and `status = 2 (unlocked)`
    /// 
    /// 
    /// 
    /// 
    /// `achievedAt` value will return default value: `0001-01-01T00:00:00Z` for user achievement that locked or in progress
    /// </summary>
    public class PublicListUserAchievements : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicListUserAchievementsBuilder Builder { get => new PublicListUserAchievementsBuilder(); }

        public class PublicListUserAchievementsBuilder
            : OperationBuilder<PublicListUserAchievementsBuilder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public bool? PreferUnlocked { get; set; }

            public PublicListUserAchievementsSortBy? SortBy { get; set; }

            public List<string>? Tags { get; set; }





            internal PublicListUserAchievementsBuilder() { }

            internal PublicListUserAchievementsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public PublicListUserAchievementsBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public PublicListUserAchievementsBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public PublicListUserAchievementsBuilder SetPreferUnlocked(bool _preferUnlocked)
            {
                PreferUnlocked = _preferUnlocked;
                return this;
            }

            public PublicListUserAchievementsBuilder SetSortBy(PublicListUserAchievementsSortBy _sortBy)
            {
                SortBy = _sortBy;
                return this;
            }

            public PublicListUserAchievementsBuilder SetTags(List<string> _tags)
            {
                Tags = _tags;
                return this;
            }





            public PublicListUserAchievements Build(
                string namespace_,
                string userId
            )
            {
                PublicListUserAchievements op = new PublicListUserAchievements(this,
                    namespace_,
                    userId
                );

                op.SetBaseFields<PublicListUserAchievementsBuilder>(this);
                return op;
            }

            public PublicListUserAchievements.Response Execute(
                string namespace_,
                string userId
            )
            {
                PublicListUserAchievements op = Build(
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
            public async Task<PublicListUserAchievements.Response> ExecuteAsync(
                string namespace_,
                string userId
            )
            {
                PublicListUserAchievements op = Build(
                    namespace_,
                    userId
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

        private PublicListUserAchievements(PublicListUserAchievementsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.PreferUnlocked != null) QueryParams["preferUnlocked"] = Convert.ToString(builder.PreferUnlocked)!;
            if (builder.SortBy is not null) QueryParams["sortBy"] = builder.SortBy.Value;
            if (builder.Tags is not null) QueryParams["tags"] = builder.Tags;



            CollectionFormatMap["tags"] = "csv";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelsPaginatedUserAchievementResponse>
        {

            public ResponseError? Error400 { get; set; } = null;

            public ResponseError? Error401 { get; set; } = null;

            public ResponseError? Error404 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Achievement::UserAchievements::PublicListUserAchievements";
        }

        #endregion

        public PublicListUserAchievements(
            string namespace_,
            string userId,
            long? limit,
            long? offset,
            bool? preferUnlocked,
            PublicListUserAchievementsSortBy? sortBy,
            List<string>? tags
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (preferUnlocked != null) QueryParams["preferUnlocked"] = Convert.ToString(preferUnlocked)!;
            if (sortBy is not null) QueryParams["sortBy"] = sortBy.Value;
            if (tags is not null) QueryParams["tags"] = tags;



            CollectionFormatMap["tags"] = "csv";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/achievement/v1/public/namespaces/{namespace}/users/{userId}/achievements";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public PublicListUserAchievements.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new PublicListUserAchievements.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelsPaginatedUserAchievementResponse>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

    public class PublicListUserAchievementsSortBy : StringEnum<PublicListUserAchievementsSortBy>
    {
        public static readonly PublicListUserAchievementsSortBy AchievedAt
            = new PublicListUserAchievementsSortBy("achievedAt");

        public static readonly PublicListUserAchievementsSortBy AchievedAtasc
            = new PublicListUserAchievementsSortBy("achievedAt:asc");

        public static readonly PublicListUserAchievementsSortBy AchievedAtdesc
            = new PublicListUserAchievementsSortBy("achievedAt:desc");

        public static readonly PublicListUserAchievementsSortBy CreatedAt
            = new PublicListUserAchievementsSortBy("createdAt");

        public static readonly PublicListUserAchievementsSortBy CreatedAtasc
            = new PublicListUserAchievementsSortBy("createdAt:asc");

        public static readonly PublicListUserAchievementsSortBy CreatedAtdesc
            = new PublicListUserAchievementsSortBy("createdAt:desc");


        public static implicit operator PublicListUserAchievementsSortBy(string value)
        {
            return NewValue(value);
        }

        public PublicListUserAchievementsSortBy(string enumValue)
            : base(enumValue)
        {

        }
    }

}