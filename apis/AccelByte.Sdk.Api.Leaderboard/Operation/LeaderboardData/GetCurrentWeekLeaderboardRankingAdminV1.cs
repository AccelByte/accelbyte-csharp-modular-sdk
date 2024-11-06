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

using AccelByte.Sdk.Api.Leaderboard.Model;

namespace AccelByte.Sdk.Api.Leaderboard.Operation
{
    /// <summary>
    /// GetCurrentWeekLeaderboardRankingAdminV1
    ///
    /// 
    /// 
    /// Get rankings in current week leaderboard.
    /// </summary>
    public class GetCurrentWeekLeaderboardRankingAdminV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetCurrentWeekLeaderboardRankingAdminV1Builder Builder { get => new GetCurrentWeekLeaderboardRankingAdminV1Builder(); }

        public class GetCurrentWeekLeaderboardRankingAdminV1Builder
            : OperationBuilder<GetCurrentWeekLeaderboardRankingAdminV1Builder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public long? PreviousVersion { get; set; }





            internal GetCurrentWeekLeaderboardRankingAdminV1Builder() { }

            internal GetCurrentWeekLeaderboardRankingAdminV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetCurrentWeekLeaderboardRankingAdminV1Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetCurrentWeekLeaderboardRankingAdminV1Builder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public GetCurrentWeekLeaderboardRankingAdminV1Builder SetPreviousVersion(long _previousVersion)
            {
                PreviousVersion = _previousVersion;
                return this;
            }





            public GetCurrentWeekLeaderboardRankingAdminV1 Build(
                string leaderboardCode,
                string namespace_
            )
            {
                GetCurrentWeekLeaderboardRankingAdminV1 op = new GetCurrentWeekLeaderboardRankingAdminV1(this,
                    leaderboardCode,                    
                    namespace_                    
                );

                op.SetBaseFields<GetCurrentWeekLeaderboardRankingAdminV1Builder>(this);
                return op;
            }

            public GetCurrentWeekLeaderboardRankingAdminV1.Response Execute(
                string leaderboardCode,
                string namespace_
            )
            {
                GetCurrentWeekLeaderboardRankingAdminV1 op = Build(
                    leaderboardCode,
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
            public async Task<GetCurrentWeekLeaderboardRankingAdminV1.Response> ExecuteAsync(
                string leaderboardCode,
                string namespace_
            )
            {
                GetCurrentWeekLeaderboardRankingAdminV1 op = Build(
                    leaderboardCode,
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

        private GetCurrentWeekLeaderboardRankingAdminV1(GetCurrentWeekLeaderboardRankingAdminV1Builder builder,
            string leaderboardCode,
            string namespace_
        )
        {
            PathParams["leaderboardCode"] = leaderboardCode;
            PathParams["namespace"] = namespace_;
            
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.PreviousVersion != null) QueryParams["previousVersion"] = Convert.ToString(builder.PreviousVersion)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelsGetLeaderboardRankingResp>
        {

            public ResponseErrorResponse? Error400 { get; set; } = null;

            public ResponseErrorResponse? Error401 { get; set; } = null;

            public ResponseErrorResponse? Error403 { get; set; } = null;

            public ResponseErrorResponse? Error404 { get; set; } = null;

            public ResponseErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Leaderboard::LeaderboardData::GetCurrentWeekLeaderboardRankingAdminV1";
        }

        #endregion

        public GetCurrentWeekLeaderboardRankingAdminV1(
            string leaderboardCode,            
            string namespace_,            
            long? limit,            
            long? offset,            
            long? previousVersion            
        )
        {
            PathParams["leaderboardCode"] = leaderboardCode;
            PathParams["namespace"] = namespace_;
            
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (previousVersion != null) QueryParams["previousVersion"] = Convert.ToString(previousVersion)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/leaderboard/v1/admin/namespaces/{namespace}/leaderboards/{leaderboardCode}/week";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public GetCurrentWeekLeaderboardRankingAdminV1.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GetCurrentWeekLeaderboardRankingAdminV1.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelsGetLeaderboardRankingResp>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}