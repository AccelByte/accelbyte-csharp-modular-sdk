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
    /// adminGetRecentTeamPlayer
    ///
    /// Query recent player who were on the same team with given user id.
    /// 
    /// If user id parameter is empty:
    /// 1. Using User Token : It will get the user id from the token
    /// 2. Using client token : it will throw an error
    /// 
    /// Please ensure environment variable "RECENT_TEAM_PLAYER_ENABLED" is set to "TRUE" to use this feature.
    /// </summary>
    public class AdminGetRecentTeamPlayer : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetRecentTeamPlayerBuilder Builder { get => new AdminGetRecentTeamPlayerBuilder(); }

        public class AdminGetRecentTeamPlayerBuilder
            : OperationBuilder<AdminGetRecentTeamPlayerBuilder>
        {

            public long? Limit { get; set; }

            public string? UserId { get; set; }





            internal AdminGetRecentTeamPlayerBuilder() { }

            internal AdminGetRecentTeamPlayerBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminGetRecentTeamPlayerBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminGetRecentTeamPlayerBuilder SetUserId(string _userId)
            {
                UserId = _userId;
                return this;
            }





            public AdminGetRecentTeamPlayer Build(
                string namespace_
            )
            {
                AdminGetRecentTeamPlayer op = new AdminGetRecentTeamPlayer(this,
                    namespace_                    
                );

                op.SetBaseFields<AdminGetRecentTeamPlayerBuilder>(this);
                return op;
            }

            public AdminGetRecentTeamPlayer.Response Execute(
                string namespace_
            )
            {
                AdminGetRecentTeamPlayer op = Build(
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
            public async Task<AdminGetRecentTeamPlayer.Response> ExecuteAsync(
                string namespace_
            )
            {
                AdminGetRecentTeamPlayer op = Build(
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

        private AdminGetRecentTeamPlayer(AdminGetRecentTeamPlayerBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.UserId is not null) QueryParams["userId"] = builder.UserId;
            

            
            
            

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


            protected override string GetFullOperationId() => "Session::RecentPlayer::AdminGetRecentTeamPlayer";
        }

        #endregion

        public AdminGetRecentTeamPlayer(
            string namespace_,            
            long? limit,            
            string? userId            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (userId is not null) QueryParams["userId"] = userId;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/admin/namespaces/{namespace}/recent-team-player";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public AdminGetRecentTeamPlayer.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminGetRecentTeamPlayer.Response()
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