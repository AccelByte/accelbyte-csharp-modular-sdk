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
    /// CreateArchivedLeaderboardRankingDataV1Handler
    ///
    /// 
    /// 
    /// Archive leaderboard ranking data for specified leaderboard codes. NOTE: This will remove all data of the leaderboard on every slug,
    /// remove the leaderboard code on stat mapping, and remove the leaderboard on the queue reset. This will be a bulk endpoint
    /// </summary>
    public class CreateArchivedLeaderboardRankingDataV1Handler : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateArchivedLeaderboardRankingDataV1HandlerBuilder Builder { get => new CreateArchivedLeaderboardRankingDataV1HandlerBuilder(); }

        public class CreateArchivedLeaderboardRankingDataV1HandlerBuilder
            : OperationBuilder<CreateArchivedLeaderboardRankingDataV1HandlerBuilder>
        {





            internal CreateArchivedLeaderboardRankingDataV1HandlerBuilder() { }

            internal CreateArchivedLeaderboardRankingDataV1HandlerBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public CreateArchivedLeaderboardRankingDataV1Handler Build(
                ModelsArchiveLeaderboardReq body,
                string namespace_
            )
            {
                CreateArchivedLeaderboardRankingDataV1Handler op = new CreateArchivedLeaderboardRankingDataV1Handler(this,
                    body,                    
                    namespace_                    
                );

                op.SetBaseFields<CreateArchivedLeaderboardRankingDataV1HandlerBuilder>(this);
                return op;
            }

            public CreateArchivedLeaderboardRankingDataV1Handler.Response Execute(
                ModelsArchiveLeaderboardReq body,
                string namespace_
            )
            {
                CreateArchivedLeaderboardRankingDataV1Handler op = Build(
                    body,
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
            public async Task<CreateArchivedLeaderboardRankingDataV1Handler.Response> ExecuteAsync(
                ModelsArchiveLeaderboardReq body,
                string namespace_
            )
            {
                CreateArchivedLeaderboardRankingDataV1Handler op = Build(
                    body,
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

        private CreateArchivedLeaderboardRankingDataV1Handler(CreateArchivedLeaderboardRankingDataV1HandlerBuilder builder,
            ModelsArchiveLeaderboardReq body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {

            public ResponseErrorResponse? Error400 { get; set; } = null;

            public ResponseErrorResponse? Error401 { get; set; } = null;

            public ResponseErrorResponse? Error403 { get; set; } = null;

            public ResponseErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Leaderboard::LeaderboardData::CreateArchivedLeaderboardRankingDataV1Handler";
        }

        #endregion

        public CreateArchivedLeaderboardRankingDataV1Handler(
            string namespace_,            
            Model.ModelsArchiveLeaderboardReq body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/leaderboard/v1/admin/namespaces/{namespace}/leaderboards/archived";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public CreateArchivedLeaderboardRankingDataV1Handler.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new CreateArchivedLeaderboardRankingDataV1Handler.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };

            if (code == (HttpStatusCode)400)
            
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
            else if (code == (HttpStatusCode)500)
            
            {
                response.Error500 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}