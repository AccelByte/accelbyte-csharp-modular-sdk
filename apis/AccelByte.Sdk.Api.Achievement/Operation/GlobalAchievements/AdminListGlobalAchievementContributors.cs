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

            public AdminListGlobalAchievementContributorsSortBy? SortBy { get; set; }





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

            public AdminListGlobalAchievementContributorsBuilder SetSortBy(AdminListGlobalAchievementContributorsSortBy _sortBy)
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

                op.SetBaseFields<AdminListGlobalAchievementContributorsBuilder>(this);
                return op;
            }

            public AdminListGlobalAchievementContributors.Response Execute(
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
            public async Task<AdminListGlobalAchievementContributors.Response> ExecuteAsync(
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

                var response = await _Sdk.RunRequestAsync(op);
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
            if (builder.SortBy is not null) QueryParams["sortBy"] = builder.SortBy.Value;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelsPaginatedContributorResponse>
        {

            public ResponseError? Error400 { get; set; } = null;

            public ResponseError? Error401 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Achievement::GlobalAchievements::AdminListGlobalAchievementContributors";
        }

        #endregion

        public AdminListGlobalAchievementContributors(
            string achievementCode,
            string namespace_,
            long? limit,
            long? offset,
            AdminListGlobalAchievementContributorsSortBy? sortBy
        )
        {
            PathParams["achievementCode"] = achievementCode;
            PathParams["namespace"] = namespace_;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (sortBy is not null) QueryParams["sortBy"] = sortBy.Value;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/achievement/v1/admin/namespaces/{namespace}/global/achievements/{achievementCode}/contributors";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public AdminListGlobalAchievementContributors.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminListGlobalAchievementContributors.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelsPaginatedContributorResponse>(payload, ResponseJsonOptions);
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

    public class AdminListGlobalAchievementContributorsSortBy : StringEnum<AdminListGlobalAchievementContributorsSortBy>
    {
        public static readonly AdminListGlobalAchievementContributorsSortBy ContributedValue
            = new AdminListGlobalAchievementContributorsSortBy("contributedValue");

        public static readonly AdminListGlobalAchievementContributorsSortBy ContributedValueasc
            = new AdminListGlobalAchievementContributorsSortBy("contributedValue:asc");

        public static readonly AdminListGlobalAchievementContributorsSortBy ContributedValuedesc
            = new AdminListGlobalAchievementContributorsSortBy("contributedValue:desc");


        public static implicit operator AdminListGlobalAchievementContributorsSortBy(string value)
        {
            return NewValue(value);
        }

        public AdminListGlobalAchievementContributorsSortBy(string enumValue)
            : base(enumValue)
        {

        }
    }

}