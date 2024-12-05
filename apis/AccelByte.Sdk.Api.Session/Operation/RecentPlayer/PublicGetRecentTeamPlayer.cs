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

using AccelByte.Sdk.Api.Session.Model;

namespace AccelByte.Sdk.Api.Session.Operation
{
    /// <summary>
    /// publicGetRecentTeamPlayer
    ///
    /// Query user's recent player who were on the same team.
    /// 
    /// Please ensure environment variable "RECENT_TEAM_PLAYER_ENABLED" is set to "TRUE" to use this feature.
    /// </summary>
    public class PublicGetRecentTeamPlayer : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetRecentTeamPlayerBuilder Builder { get => new PublicGetRecentTeamPlayerBuilder(); }

        public class PublicGetRecentTeamPlayerBuilder
            : OperationBuilder<PublicGetRecentTeamPlayerBuilder>
        {

            public long? Limit { get; set; }





            internal PublicGetRecentTeamPlayerBuilder() { }

            internal PublicGetRecentTeamPlayerBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public PublicGetRecentTeamPlayerBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }





            public PublicGetRecentTeamPlayer Build(
                string namespace_
            )
            {
                PublicGetRecentTeamPlayer op = new PublicGetRecentTeamPlayer(this,
                    namespace_
                );

                op.SetBaseFields<PublicGetRecentTeamPlayerBuilder>(this);
                return op;
            }

            public PublicGetRecentTeamPlayer.Response Execute(
                string namespace_
            )
            {
                PublicGetRecentTeamPlayer op = Build(
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
            public async Task<PublicGetRecentTeamPlayer.Response> ExecuteAsync(
                string namespace_
            )
            {
                PublicGetRecentTeamPlayer op = Build(
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

        private PublicGetRecentTeamPlayer(PublicGetRecentTeamPlayerBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelsRecentPlayerQueryResponse>
        {

            public ResponseError? Error400 { get; set; } = null;

            public ResponseError? Error401 { get; set; } = null;

            public ResponseError? Error404 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Session::RecentPlayer::PublicGetRecentTeamPlayer";
        }

        #endregion

        public PublicGetRecentTeamPlayer(
            string namespace_,
            long? limit
        )
        {
            PathParams["namespace"] = namespace_;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/public/namespaces/{namespace}/recent-team-player";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public PublicGetRecentTeamPlayer.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new PublicGetRecentTeamPlayer.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelsRecentPlayerQueryResponse>(payload, ResponseJsonOptions);
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

}