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
    /// deleteUserRankingsAdminV1
    ///
    /// Delete user ranking across leaderboard
    /// 
    /// Remove entry with provided userId from leaderboard.
    /// </summary>
    public class DeleteUserRankingsAdminV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteUserRankingsAdminV1Builder Builder { get => new DeleteUserRankingsAdminV1Builder(); }

        public class DeleteUserRankingsAdminV1Builder
            : OperationBuilder<DeleteUserRankingsAdminV1Builder>
        {





            internal DeleteUserRankingsAdminV1Builder() { }

            internal DeleteUserRankingsAdminV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteUserRankingsAdminV1 Build(
                string namespace_,
                string userId,
                List<string> leaderboardCode
            )
            {
                DeleteUserRankingsAdminV1 op = new DeleteUserRankingsAdminV1(this,
                    namespace_,                    
                    userId,                    
                    leaderboardCode                    
                );

                op.SetBaseFields<DeleteUserRankingsAdminV1Builder>(this);
                return op;
            }

            public DeleteUserRankingsAdminV1.Response Execute(
                string namespace_,
                string userId,
                List<string> leaderboardCode
            )
            {
                DeleteUserRankingsAdminV1 op = Build(
                    namespace_,
                    userId,
                    leaderboardCode
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<DeleteUserRankingsAdminV1.Response> ExecuteAsync(
                string namespace_,
                string userId,
                List<string> leaderboardCode
            )
            {
                DeleteUserRankingsAdminV1 op = Build(
                    namespace_,
                    userId,
                    leaderboardCode
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

        private DeleteUserRankingsAdminV1(DeleteUserRankingsAdminV1Builder builder,
            string namespace_,
            string userId,
            List<string> leaderboardCode
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (leaderboardCode is not null) QueryParams["leaderboardCode"] = leaderboardCode;
            

            
            CollectionFormatMap["leaderboardCode"] = "multi";
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {

            public ResponseErrorResponse? Error401 { get; set; } = null;

            public ResponseErrorResponse? Error403 { get; set; } = null;

            public ResponseErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Leaderboard::LeaderboardData::DeleteUserRankingsAdminV1";
        }

        #endregion

        public DeleteUserRankingsAdminV1(
            string namespace_,            
            string userId,            
            List<string> leaderboardCode            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (leaderboardCode is not null) QueryParams["leaderboardCode"] = leaderboardCode;
            

            
            CollectionFormatMap["leaderboardCode"] = "multi";
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/leaderboard/v1/admin/namespaces/{namespace}/users/{userId}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public DeleteUserRankingsAdminV1.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new DeleteUserRankingsAdminV1.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };

            if (code == (HttpStatusCode)401)
            
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