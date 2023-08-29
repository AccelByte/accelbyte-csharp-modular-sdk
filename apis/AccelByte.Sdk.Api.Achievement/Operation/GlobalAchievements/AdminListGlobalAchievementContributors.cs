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

using AccelByte.Sdk.Api.Achievement.Model;

namespace AccelByte.Sdk.Api.Achievement.Operation
{
    /// <summary>
    /// AdminListGlobalAchievementContributors
    ///
    /// 
    /// 
    /// Required permission
    /// `ADMIN:NAMESPACE:{namespace}:ACHIEVEMENT [READ]` and scope `social`
    /// </summary>
    public class AdminListGlobalAchievementContributors : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminListGlobalAchievementContributorsBuilder Builder { get => new AdminListGlobalAchievementContributorsBuilder(); }

        public class AdminListGlobalAchievementContributorsBuilder
            : OperationBuilder<AdminListGlobalAchievementContributorsBuilder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public string? SortBy { get; set; }





            internal AdminListGlobalAchievementContributorsBuilder() { }

            internal AdminListGlobalAchievementContributorsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminListGlobalAchievementContributorsBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminListGlobalAchievementContributorsBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public AdminListGlobalAchievementContributorsBuilder SetSortBy(string _sortBy)
            {
                SortBy = _sortBy;
                return this;
            }





            public AdminListGlobalAchievementContributors Build(
                string achievementCode,
                string namespace_
            )
            {
                AdminListGlobalAchievementContributors op = new AdminListGlobalAchievementContributors(this,
                    achievementCode,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelsPaginatedContributorResponse? Execute(
                string achievementCode,
                string namespace_
            )
            {
                AdminListGlobalAchievementContributors op = Build(
                    achievementCode,
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

        private AdminListGlobalAchievementContributors(AdminListGlobalAchievementContributorsBuilder builder,
            string achievementCode,
            string namespace_
        )
        {
            PathParams["achievementCode"] = achievementCode;
            PathParams["namespace"] = namespace_;
            
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.SortBy is not null) QueryParams["sortBy"] = builder.SortBy;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminListGlobalAchievementContributors(
            string achievementCode,            
            string namespace_,            
            long? limit,            
            long? offset,            
            string? sortBy            
        )
        {
            PathParams["achievementCode"] = achievementCode;
            PathParams["namespace"] = namespace_;
            
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (sortBy is not null) QueryParams["sortBy"] = sortBy;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/achievement/v1/admin/namespaces/{namespace}/global/achievements/{achievementCode}/contributors";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.ModelsPaginatedContributorResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsPaginatedContributorResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsPaginatedContributorResponse>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}