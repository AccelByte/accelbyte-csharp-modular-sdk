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
    /// getUserRankingPublicV3
    ///
    /// 
    /// 
    /// Get user ranking in leaderboard
    /// </summary>
    public class GetUserRankingPublicV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetUserRankingPublicV3Builder Builder { get => new GetUserRankingPublicV3Builder(); }

        public class GetUserRankingPublicV3Builder
            : OperationBuilder<GetUserRankingPublicV3Builder>
        {

            public long? PreviousVersion { get; set; }





            internal GetUserRankingPublicV3Builder() { }

            internal GetUserRankingPublicV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetUserRankingPublicV3Builder SetPreviousVersion(long _previousVersion)
            {
                PreviousVersion = _previousVersion;
                return this;
            }





            public GetUserRankingPublicV3 Build(
                string leaderboardCode,
                string namespace_,
                string userId
            )
            {
                GetUserRankingPublicV3 op = new GetUserRankingPublicV3(this,
                    leaderboardCode,                    
                    namespace_,                    
                    userId                    
                );

                op.SetBaseFields<GetUserRankingPublicV3Builder>(this);
                return op;
            }

            public GetUserRankingPublicV3.Response Execute(
                string leaderboardCode,
                string namespace_,
                string userId
            )
            {
                GetUserRankingPublicV3 op = Build(
                    leaderboardCode,
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
            public async Task<GetUserRankingPublicV3.Response> ExecuteAsync(
                string leaderboardCode,
                string namespace_,
                string userId
            )
            {
                GetUserRankingPublicV3 op = Build(
                    leaderboardCode,
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

        private GetUserRankingPublicV3(GetUserRankingPublicV3Builder builder,
            string leaderboardCode,
            string namespace_,
            string userId
        )
        {
            PathParams["leaderboardCode"] = leaderboardCode;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (builder.PreviousVersion != null) QueryParams["previousVersion"] = Convert.ToString(builder.PreviousVersion)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelsUserRankingResponseV3>
        {

            public ResponseErrorResponse? Error400 { get; set; } = null;

            public ResponseErrorResponse? Error401 { get; set; } = null;

            public ResponseErrorResponse? Error403 { get; set; } = null;

            public ResponseErrorResponse? Error404 { get; set; } = null;

            public ResponseErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Leaderboard::LeaderboardDataV3::GetUserRankingPublicV3";
        }

        #endregion

        public GetUserRankingPublicV3(
            string leaderboardCode,            
            string namespace_,            
            string userId,            
            long? previousVersion            
        )
        {
            PathParams["leaderboardCode"] = leaderboardCode;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (previousVersion != null) QueryParams["previousVersion"] = Convert.ToString(previousVersion)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/leaderboard/v3/public/namespaces/{namespace}/leaderboards/{leaderboardCode}/users/{userId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public GetUserRankingPublicV3.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GetUserRankingPublicV3.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelsUserRankingResponseV3>(payload, ResponseJsonOptions);
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