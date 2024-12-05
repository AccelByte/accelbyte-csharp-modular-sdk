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
    /// deleteUserRankingAdminV1
    ///
    /// Delete user ranking
    /// 
    /// Remove entry with provided userId from leaderboard.
    /// If leaderboard with given leaderboard code not found, it will return http status not found (404).
    /// If the leaderboard is found and no entry found in it, it will still return success (204)
    /// </summary>
    public class DeleteUserRankingAdminV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteUserRankingAdminV1Builder Builder { get => new DeleteUserRankingAdminV1Builder(); }

        public class DeleteUserRankingAdminV1Builder
            : OperationBuilder<DeleteUserRankingAdminV1Builder>
        {





            internal DeleteUserRankingAdminV1Builder() { }

            internal DeleteUserRankingAdminV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteUserRankingAdminV1 Build(
                string leaderboardCode,
                string namespace_,
                string userId
            )
            {
                DeleteUserRankingAdminV1 op = new DeleteUserRankingAdminV1(this,
                    leaderboardCode,
                    namespace_,
                    userId
                );

                op.SetBaseFields<DeleteUserRankingAdminV1Builder>(this);
                return op;
            }

            public DeleteUserRankingAdminV1.Response Execute(
                string leaderboardCode,
                string namespace_,
                string userId
            )
            {
                DeleteUserRankingAdminV1 op = Build(
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
            public async Task<DeleteUserRankingAdminV1.Response> ExecuteAsync(
                string leaderboardCode,
                string namespace_,
                string userId
            )
            {
                DeleteUserRankingAdminV1 op = Build(
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

        private DeleteUserRankingAdminV1(DeleteUserRankingAdminV1Builder builder,
            string leaderboardCode,
            string namespace_,
            string userId
        )
        {
            PathParams["leaderboardCode"] = leaderboardCode;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {

            public ResponseErrorResponse? Error401 { get; set; } = null;

            public ResponseErrorResponse? Error403 { get; set; } = null;

            public ResponseErrorResponse? Error404 { get; set; } = null;

            public ResponseErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Leaderboard::LeaderboardData::DeleteUserRankingAdminV1";
        }

        #endregion

        public DeleteUserRankingAdminV1(
            string leaderboardCode,
            string namespace_,
            string userId
        )
        {
            PathParams["leaderboardCode"] = leaderboardCode;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/leaderboard/v1/admin/namespaces/{namespace}/leaderboards/{leaderboardCode}/users/{userId}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public DeleteUserRankingAdminV1.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new DeleteUserRankingAdminV1.Response()
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