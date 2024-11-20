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
    /// AdminListUserContributions
    ///
    /// 
    /// 
    /// Required permission
    /// `ADMIN:NAMESPACE:{namespace}:USER:{userId}:ACHIEVEMENT [READ]` and scope `social`
    /// </summary>
    public class AdminListUserContributions : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminListUserContributionsBuilder Builder { get => new AdminListUserContributionsBuilder(); }

        public class AdminListUserContributionsBuilder
            : OperationBuilder<AdminListUserContributionsBuilder>
        {

            public string? AchievementCodes { get; set; }

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public AdminListUserContributionsSortBy? SortBy { get; set; }

            public List<string>? Tags { get; set; }





            internal AdminListUserContributionsBuilder() { }

            internal AdminListUserContributionsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminListUserContributionsBuilder SetAchievementCodes(string _achievementCodes)
            {
                AchievementCodes = _achievementCodes;
                return this;
            }

            public AdminListUserContributionsBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminListUserContributionsBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public AdminListUserContributionsBuilder SetSortBy(AdminListUserContributionsSortBy _sortBy)
            {
                SortBy = _sortBy;
                return this;
            }

            public AdminListUserContributionsBuilder SetTags(List<string> _tags)
            {
                Tags = _tags;
                return this;
            }





            public AdminListUserContributions Build(
                string namespace_,
                string userId
            )
            {
                AdminListUserContributions op = new AdminListUserContributions(this,
                    namespace_,                    
                    userId                    
                );

                op.SetBaseFields<AdminListUserContributionsBuilder>(this);
                return op;
            }

            public AdminListUserContributions.Response Execute(
                string namespace_,
                string userId
            )
            {
                AdminListUserContributions op = Build(
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
            public async Task<AdminListUserContributions.Response> ExecuteAsync(
                string namespace_,
                string userId
            )
            {
                AdminListUserContributions op = Build(
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

        private AdminListUserContributions(AdminListUserContributionsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (builder.AchievementCodes is not null) QueryParams["achievementCodes"] = builder.AchievementCodes;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.SortBy is not null) QueryParams["sortBy"] = builder.SortBy.Value;
            if (builder.Tags is not null) QueryParams["tags"] = builder.Tags;
            

            
            CollectionFormatMap["tags"] = "csv";
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelsPaginatedUserContributionResponse>
        {

            public ResponseError? Error400 { get; set; } = null;

            public ResponseError? Error401 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Achievement::GlobalAchievements::AdminListUserContributions";
        }

        #endregion

        public AdminListUserContributions(
            string namespace_,            
            string userId,            
            string? achievementCodes,            
            long? limit,            
            long? offset,            
            AdminListUserContributionsSortBy? sortBy,            
            List<string>? tags            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (achievementCodes is not null) QueryParams["achievementCodes"] = achievementCodes;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (sortBy is not null) QueryParams["sortBy"] = sortBy.Value;
            if (tags is not null) QueryParams["tags"] = tags;
            

            
            CollectionFormatMap["tags"] = "csv";
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/achievement/v1/admin/namespaces/{namespace}/users/{userId}/global/achievements";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public AdminListUserContributions.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminListUserContributions.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelsPaginatedUserContributionResponse>(payload, ResponseJsonOptions);
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
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

    public class AdminListUserContributionsSortBy : StringEnum<AdminListUserContributionsSortBy>
    {
        public static readonly AdminListUserContributionsSortBy ContributedValue
            = new AdminListUserContributionsSortBy("contributedValue");

        public static readonly AdminListUserContributionsSortBy ContributedValueasc
            = new AdminListUserContributionsSortBy("contributedValue:asc");

        public static readonly AdminListUserContributionsSortBy ContributedValuedesc
            = new AdminListUserContributionsSortBy("contributedValue:desc");


        public static implicit operator AdminListUserContributionsSortBy(string value)
        {
            return NewValue(value);
        }

        public AdminListUserContributionsSortBy(string enumValue)
            : base(enumValue)
        {

        }
    }

}