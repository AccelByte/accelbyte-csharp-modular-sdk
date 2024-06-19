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
    /// GetArchivedLeaderboardRankingDataV1Handler
    ///
    /// Get signed url in an all time leaderboard that archived. NOTE: This will be a bulk endpoint to get sign url
    /// </summary>
    public class GetArchivedLeaderboardRankingDataV1Handler : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetArchivedLeaderboardRankingDataV1HandlerBuilder Builder { get => new GetArchivedLeaderboardRankingDataV1HandlerBuilder(); }

        public class GetArchivedLeaderboardRankingDataV1HandlerBuilder
            : OperationBuilder<GetArchivedLeaderboardRankingDataV1HandlerBuilder>
        {

            public string? Slug { get; set; }





            internal GetArchivedLeaderboardRankingDataV1HandlerBuilder() { }

            internal GetArchivedLeaderboardRankingDataV1HandlerBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetArchivedLeaderboardRankingDataV1HandlerBuilder SetSlug(string _slug)
            {
                Slug = _slug;
                return this;
            }





            public GetArchivedLeaderboardRankingDataV1Handler Build(
                string leaderboardCode,
                string namespace_,
                string leaderboardCodes
            )
            {
                GetArchivedLeaderboardRankingDataV1Handler op = new GetArchivedLeaderboardRankingDataV1Handler(this,
                    leaderboardCode,
                    namespace_,
                    leaderboardCodes
                );

                op.SetBaseFields<GetArchivedLeaderboardRankingDataV1HandlerBuilder>(this);
                return op;
            }

            public List<Model.ModelsArchiveLeaderboardSignedURLResponse>? Execute(
                string leaderboardCode,
                string namespace_,
                string leaderboardCodes
            )
            {
                GetArchivedLeaderboardRankingDataV1Handler op = Build(
                    leaderboardCode,
                    namespace_,
                    leaderboardCodes
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<List<Model.ModelsArchiveLeaderboardSignedURLResponse>?> ExecuteAsync(
                string leaderboardCode,
                string namespace_,
                string leaderboardCodes
            )
            {
                GetArchivedLeaderboardRankingDataV1Handler op = Build(
                    leaderboardCode,
                    namespace_,
                    leaderboardCodes
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

        private GetArchivedLeaderboardRankingDataV1Handler(GetArchivedLeaderboardRankingDataV1HandlerBuilder builder,
            string leaderboardCode,
            string namespace_,
            string leaderboardCodes
        )
        {
            PathParams["leaderboardCode"] = leaderboardCode;
            PathParams["namespace"] = namespace_;

            if (builder.Slug is not null) QueryParams["slug"] = builder.Slug;
            if (leaderboardCodes is not null) QueryParams["leaderboardCodes"] = leaderboardCodes;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetArchivedLeaderboardRankingDataV1Handler(
            string leaderboardCode,
            string namespace_,
            string? slug,
            string leaderboardCodes
        )
        {
            PathParams["leaderboardCode"] = leaderboardCode;
            PathParams["namespace"] = namespace_;

            if (slug is not null) QueryParams["slug"] = slug;
            if (leaderboardCodes is not null) QueryParams["leaderboardCodes"] = leaderboardCodes;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/leaderboard/v1/public/namespaces/{namespace}/leaderboards/{leaderboardCode}/archived";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public List<Model.ModelsArchiveLeaderboardSignedURLResponse>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ModelsArchiveLeaderboardSignedURLResponse>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ModelsArchiveLeaderboardSignedURLResponse>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}