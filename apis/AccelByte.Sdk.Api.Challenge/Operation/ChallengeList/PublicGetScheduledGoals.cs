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
    /// publicGetScheduledGoals
    ///
    /// - Required permission: NAMESPACE:{namespace}:CHALLENGE [READ]
    /// </summary>
    public class PublicGetScheduledGoals : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetScheduledGoalsBuilder Builder { get => new PublicGetScheduledGoalsBuilder(); }

        public class PublicGetScheduledGoalsBuilder
            : OperationBuilder<PublicGetScheduledGoalsBuilder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public PublicGetScheduledGoalsSortBy? SortBy { get; set; }

            public List<string>? Tags { get; set; }





            internal PublicGetScheduledGoalsBuilder() { }

            internal PublicGetScheduledGoalsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public PublicGetScheduledGoalsBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public PublicGetScheduledGoalsBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public PublicGetScheduledGoalsBuilder SetSortBy(PublicGetScheduledGoalsSortBy _sortBy)
            {
                SortBy = _sortBy;
                return this;
            }

            public PublicGetScheduledGoalsBuilder SetTags(List<string> _tags)
            {
                Tags = _tags;
                return this;
            }





            public PublicGetScheduledGoals Build(
                string challengeCode,
                string namespace_
            )
            {
                PublicGetScheduledGoals op = new PublicGetScheduledGoals(this,
                    challengeCode,                    
                    namespace_                    
                );

                op.SetBaseFields<PublicGetScheduledGoalsBuilder>(this);
                return op;
            }

            public PublicGetScheduledGoals.Response Execute(
                string challengeCode,
                string namespace_
            )
            {
                PublicGetScheduledGoals op = Build(
                    challengeCode,
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
            public async Task<PublicGetScheduledGoals.Response> ExecuteAsync(
                string challengeCode,
                string namespace_
            )
            {
                PublicGetScheduledGoals op = Build(
                    challengeCode,
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

        private PublicGetScheduledGoals(PublicGetScheduledGoalsBuilder builder,
            string challengeCode,
            string namespace_
        )
        {
            PathParams["challengeCode"] = challengeCode;
            PathParams["namespace"] = namespace_;
            
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.SortBy is not null) QueryParams["sortBy"] = builder.SortBy.Value;
            if (builder.Tags is not null) QueryParams["tags"] = builder.Tags;
            

            
            CollectionFormatMap["tags"] = "csv";
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelGetGoalsResponse>
        {

            public IamErrorResponse? Error401 { get; set; } = null;

            public IamErrorResponse? Error403 { get; set; } = null;

            public ResponseError? Error404 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Challenge::ChallengeList::PublicGetScheduledGoals";
        }

        #endregion

        public PublicGetScheduledGoals(
            string challengeCode,            
            string namespace_,            
            long? limit,            
            long? offset,            
            PublicGetScheduledGoalsSortBy? sortBy,            
            List<string>? tags            
        )
        {
            PathParams["challengeCode"] = challengeCode;
            PathParams["namespace"] = namespace_;
            
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (sortBy is not null) QueryParams["sortBy"] = sortBy.Value;
            if (tags is not null) QueryParams["tags"] = tags;
            

            
            CollectionFormatMap["tags"] = "csv";
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/challenge/v1/public/namespaces/{namespace}/challenges/{challengeCode}/goals";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public PublicGetScheduledGoals.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new PublicGetScheduledGoals.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelGetGoalsResponse>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
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

    public class PublicGetScheduledGoalsSortBy : StringEnum<PublicGetScheduledGoalsSortBy>
    {
        public static readonly PublicGetScheduledGoalsSortBy CreatedAt
            = new PublicGetScheduledGoalsSortBy("createdAt");

        public static readonly PublicGetScheduledGoalsSortBy CreatedAtasc
            = new PublicGetScheduledGoalsSortBy("createdAt:asc");

        public static readonly PublicGetScheduledGoalsSortBy CreatedAtdesc
            = new PublicGetScheduledGoalsSortBy("createdAt:desc");

        public static readonly PublicGetScheduledGoalsSortBy UpdatedAt
            = new PublicGetScheduledGoalsSortBy("updatedAt");

        public static readonly PublicGetScheduledGoalsSortBy UpdatedAtasc
            = new PublicGetScheduledGoalsSortBy("updatedAt:asc");

        public static readonly PublicGetScheduledGoalsSortBy UpdatedAtdesc
            = new PublicGetScheduledGoalsSortBy("updatedAt:desc");


        public static implicit operator PublicGetScheduledGoalsSortBy(string value)
        {
            return NewValue(value);
        }

        public PublicGetScheduledGoalsSortBy(string enumValue)
            : base(enumValue)
        {

        }
    }

}