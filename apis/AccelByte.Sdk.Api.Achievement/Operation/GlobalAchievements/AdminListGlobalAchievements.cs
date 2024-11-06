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

            internal AdminListGlobalAchievementsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


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

                op.SetBaseFields<AdminListGlobalAchievementsBuilder>(this);
                return op;
            }

            public AdminListGlobalAchievements.Response Execute(
                string namespace_
            )
            {
                AdminListGlobalAchievements op = Build(
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
            public async Task<AdminListGlobalAchievements.Response> ExecuteAsync(
                string namespace_
            )
            {
                AdminListGlobalAchievements op = Build(
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

        #region Response Part        
        public class Response : ApiResponse<Model.ModelsPaginatedGlobalAchievementResponse>
        {

            public ResponseError? Error400 { get; set; } = null;

            public ResponseError? Error401 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Achievement::GlobalAchievements::AdminListGlobalAchievements";
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

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public AdminListGlobalAchievements.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminListGlobalAchievements.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelsPaginatedGlobalAchievementResponse>(payload, ResponseJsonOptions);
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

}