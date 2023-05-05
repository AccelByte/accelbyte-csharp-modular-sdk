// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Achievement.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Achievement.Operation
{
    /// <summary>
    /// AdminListGlobalAchievements
    ///
    /// 
    /// 
    /// Required permission
    /// `ADMIN:NAMESPACE:{namespace}:ACHIEVEMENT [READ]` and scope `social`
    /// 
    /// 
    /// 
    /// 
    /// Note:
    /// 
    /// 
    /// 
    /// 
    /// Global achievement status value mean: `status = 1 (in progress)` and `status = 2 (unlocked)`
    /// </summary>
    public class AdminListGlobalAchievements : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminListGlobalAchievementsBuilder Builder { get => new AdminListGlobalAchievementsBuilder(); }

        public class AdminListGlobalAchievementsBuilder
            : OperationBuilder<AdminListGlobalAchievementsBuilder>
        {

            public string? AchievementCodes { get; set; }

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public string? SortBy { get; set; }

            public string? Status { get; set; }

            public List<string>? Tags { get; set; }





            internal AdminListGlobalAchievementsBuilder() { }


            public AdminListGlobalAchievementsBuilder SetAchievementCodes(string _achievementCodes)
            {
                AchievementCodes = _achievementCodes;
                return this;
            }

            public AdminListGlobalAchievementsBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminListGlobalAchievementsBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public AdminListGlobalAchievementsBuilder SetSortBy(string _sortBy)
            {
                SortBy = _sortBy;
                return this;
            }

            public AdminListGlobalAchievementsBuilder SetStatus(string _status)
            {
                Status = _status;
                return this;
            }

            public AdminListGlobalAchievementsBuilder SetTags(List<string> _tags)
            {
                Tags = _tags;
                return this;
            }





            public AdminListGlobalAchievements Build(
                string namespace_
            )
            {
                AdminListGlobalAchievements op = new AdminListGlobalAchievements(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminListGlobalAchievements(AdminListGlobalAchievementsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.AchievementCodes is not null) QueryParams["achievementCodes"] = builder.AchievementCodes;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.SortBy is not null) QueryParams["sortBy"] = builder.SortBy;
            if (builder.Status is not null) QueryParams["status"] = builder.Status;
            if (builder.Tags is not null) QueryParams["tags"] = builder.Tags;
            

            
            CollectionFormatMap["tags"] = "csv";
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminListGlobalAchievements(
            string namespace_,            
            string? achievementCodes,            
            long? limit,            
            long? offset,            
            string? sortBy,            
            string? status,            
            List<string>? tags            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (achievementCodes is not null) QueryParams["achievementCodes"] = achievementCodes;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (sortBy is not null) QueryParams["sortBy"] = sortBy;
            if (status is not null) QueryParams["status"] = status;
            if (tags is not null) QueryParams["tags"] = tags;
            

            
            CollectionFormatMap["tags"] = "csv";
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/achievement/v1/admin/namespaces/{namespace}/global/achievements";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelsPaginatedGlobalAchievementResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsPaginatedGlobalAchievementResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsPaginatedGlobalAchievementResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}