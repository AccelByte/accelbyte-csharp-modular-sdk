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

using AccelByte.Sdk.Api.Sessionbrowser.Model;

namespace AccelByte.Sdk.Api.Sessionbrowser.Operation
{
    /// <summary>
    /// GetActiveCustomGameSessions
    ///
    /// Get all active session for custom game, this return only dedicated session type
    /// </summary>
    public class GetActiveCustomGameSessions : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetActiveCustomGameSessionsBuilder Builder { get => new GetActiveCustomGameSessionsBuilder(); }

        public class GetActiveCustomGameSessionsBuilder
            : OperationBuilder<GetActiveCustomGameSessionsBuilder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public string? ServerRegion { get; set; }

            public string? SessionId { get; set; }





            internal GetActiveCustomGameSessionsBuilder() { }

            internal GetActiveCustomGameSessionsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetActiveCustomGameSessionsBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetActiveCustomGameSessionsBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public GetActiveCustomGameSessionsBuilder SetServerRegion(string _serverRegion)
            {
                ServerRegion = _serverRegion;
                return this;
            }

            public GetActiveCustomGameSessionsBuilder SetSessionId(string _sessionId)
            {
                SessionId = _sessionId;
                return this;
            }





            public GetActiveCustomGameSessions Build(
                string namespace_
            )
            {
                GetActiveCustomGameSessions op = new GetActiveCustomGameSessions(this,
                    namespace_
                );

                op.SetBaseFields<GetActiveCustomGameSessionsBuilder>(this);
                return op;
            }

            public GetActiveCustomGameSessions.Response Execute(
                string namespace_
            )
            {
                GetActiveCustomGameSessions op = Build(
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
            public async Task<GetActiveCustomGameSessions.Response> ExecuteAsync(
                string namespace_
            )
            {
                GetActiveCustomGameSessions op = Build(
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

        private GetActiveCustomGameSessions(GetActiveCustomGameSessionsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.ServerRegion is not null) QueryParams["server_region"] = builder.ServerRegion;
            if (builder.SessionId is not null) QueryParams["session_id"] = builder.SessionId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelsActiveCustomGameResponse>
        {

            public RestapiErrorResponseV2? Error400 { get; set; } = null;

            public RestapiErrorResponseV2? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Sessionbrowser::Session::GetActiveCustomGameSessions";
        }

        #endregion

        public GetActiveCustomGameSessions(
            string namespace_,
            long? limit,
            long? offset,
            string? serverRegion,
            string? sessionId
        )
        {
            PathParams["namespace"] = namespace_;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (serverRegion is not null) QueryParams["server_region"] = serverRegion;
            if (sessionId is not null) QueryParams["session_id"] = sessionId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/sessionbrowser/admin/namespaces/{namespace}/gamesession/active/custom-game";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public GetActiveCustomGameSessions.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GetActiveCustomGameSessions.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelsActiveCustomGameResponse>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<RestapiErrorResponseV2>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<RestapiErrorResponseV2>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}