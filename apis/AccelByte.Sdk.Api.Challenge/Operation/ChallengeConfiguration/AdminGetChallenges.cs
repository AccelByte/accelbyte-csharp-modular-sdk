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

using AccelByte.Sdk.Api.Challenge.Model;

namespace AccelByte.Sdk.Api.Challenge.Operation
{
    /// <summary>
    /// adminGetChallenges
    ///
    /// - Required permission: ADMIN:NAMESPACE:{namespace}:CHALLENGE [READ]
    /// </summary>
    public class AdminGetChallenges : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetChallengesBuilder Builder { get => new AdminGetChallengesBuilder(); }

        public class AdminGetChallengesBuilder
            : OperationBuilder<AdminGetChallengesBuilder>
        {

            public string? Keyword { get; set; }

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public AdminGetChallengesSortBy? SortBy { get; set; }

            public AdminGetChallengesStatus? Status { get; set; }

            public List<string>? Tags { get; set; }





            internal AdminGetChallengesBuilder() { }

            internal AdminGetChallengesBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminGetChallengesBuilder SetKeyword(string _keyword)
            {
                Keyword = _keyword;
                return this;
            }

            public AdminGetChallengesBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminGetChallengesBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public AdminGetChallengesBuilder SetSortBy(AdminGetChallengesSortBy _sortBy)
            {
                SortBy = _sortBy;
                return this;
            }

            public AdminGetChallengesBuilder SetStatus(AdminGetChallengesStatus _status)
            {
                Status = _status;
                return this;
            }

            public AdminGetChallengesBuilder SetTags(List<string> _tags)
            {
                Tags = _tags;
                return this;
            }





            public AdminGetChallenges Build(
                string namespace_
            )
            {
                AdminGetChallenges op = new AdminGetChallenges(this,
                    namespace_
                );

                op.SetBaseFields<AdminGetChallengesBuilder>(this);
                return op;
            }

            public AdminGetChallenges.Response Execute(
                string namespace_
            )
            {
                AdminGetChallenges op = Build(
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
            public async Task<AdminGetChallenges.Response> ExecuteAsync(
                string namespace_
            )
            {
                AdminGetChallenges op = Build(
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

        private AdminGetChallenges(AdminGetChallengesBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Keyword is not null) QueryParams["keyword"] = builder.Keyword;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.SortBy is not null) QueryParams["sortBy"] = builder.SortBy.Value;
            if (builder.Status is not null) QueryParams["status"] = builder.Status.Value;
            if (builder.Tags is not null) QueryParams["tags"] = builder.Tags;



            CollectionFormatMap["tags"] = "csv";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelListChallengeResponse>
        {

            public ResponseError? Error400 { get; set; } = null;

            public IamErrorResponse? Error401 { get; set; } = null;

            public IamErrorResponse? Error403 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Challenge::ChallengeConfiguration::AdminGetChallenges";
        }

        #endregion

        public AdminGetChallenges(
            string namespace_,
            string? keyword,
            long? limit,
            long? offset,
            AdminGetChallengesSortBy? sortBy,
            AdminGetChallengesStatus? status,
            List<string>? tags
        )
        {
            PathParams["namespace"] = namespace_;

            if (keyword is not null) QueryParams["keyword"] = keyword;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (sortBy is not null) QueryParams["sortBy"] = sortBy.Value;
            if (status is not null) QueryParams["status"] = status.Value;
            if (tags is not null) QueryParams["tags"] = tags;



            CollectionFormatMap["tags"] = "csv";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/challenge/v1/admin/namespaces/{namespace}/challenges";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public AdminGetChallenges.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminGetChallenges.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelListChallengeResponse>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<IamErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<IamErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

    public class AdminGetChallengesSortBy : StringEnum<AdminGetChallengesSortBy>
    {
        public static readonly AdminGetChallengesSortBy CreatedAt
            = new AdminGetChallengesSortBy("createdAt");

        public static readonly AdminGetChallengesSortBy CreatedAtasc
            = new AdminGetChallengesSortBy("createdAt:asc");

        public static readonly AdminGetChallengesSortBy CreatedAtdesc
            = new AdminGetChallengesSortBy("createdAt:desc");

        public static readonly AdminGetChallengesSortBy UpdatedAt
            = new AdminGetChallengesSortBy("updatedAt");

        public static readonly AdminGetChallengesSortBy UpdatedAtasc
            = new AdminGetChallengesSortBy("updatedAt:asc");

        public static readonly AdminGetChallengesSortBy UpdatedAtdesc
            = new AdminGetChallengesSortBy("updatedAt:desc");


        public static implicit operator AdminGetChallengesSortBy(string value)
        {
            return NewValue(value);
        }

        public AdminGetChallengesSortBy(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class AdminGetChallengesStatus : StringEnum<AdminGetChallengesStatus>
    {
        public static readonly AdminGetChallengesStatus INIT
            = new AdminGetChallengesStatus("INIT");

        public static readonly AdminGetChallengesStatus RETIRED
            = new AdminGetChallengesStatus("RETIRED");

        public static readonly AdminGetChallengesStatus TIED
            = new AdminGetChallengesStatus("TIED");


        public static implicit operator AdminGetChallengesStatus(string value)
        {
            return NewValue(value);
        }

        public AdminGetChallengesStatus(string enumValue)
            : base(enumValue)
        {

        }
    }

}