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
    /// adminGetRecentPlayer
    ///
    /// Query recent player with given user id.
    /// 
    /// If user id parameter is empty:
    /// 1. Using User Token : It will get the user id from the token
    /// 2. Using client token : it will throw an error
    /// 
    /// Please ensure environment variable "RECENT_PLAYER_ENABLED" is set to "TRUE" to use this feature.
    /// </summary>
    public class AdminGetRecentPlayer : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetRecentPlayerBuilder Builder { get => new AdminGetRecentPlayerBuilder(); }

        public class AdminGetRecentPlayerBuilder
            : OperationBuilder<AdminGetRecentPlayerBuilder>
        {

            public long? Limit { get; set; }

            public string? UserId { get; set; }





            internal AdminGetRecentPlayerBuilder() { }

            internal AdminGetRecentPlayerBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminGetRecentPlayerBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminGetRecentPlayerBuilder SetUserId(string _userId)
            {
                UserId = _userId;
                return this;
            }





            public AdminGetRecentPlayer Build(
                string namespace_
            )
            {
                AdminGetRecentPlayer op = new AdminGetRecentPlayer(this,
                    namespace_
                );

                op.SetBaseFields<AdminGetRecentPlayerBuilder>(this);
                return op;
            }

            public Model.ModelsRecentPlayerQueryResponse? Execute(
                string namespace_
            )
            {
                AdminGetRecentPlayer op = Build(
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
            public async Task<Model.ModelsRecentPlayerQueryResponse?> ExecuteAsync(
                string namespace_
            )
            {
                AdminGetRecentPlayer op = Build(
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

        private AdminGetRecentPlayer(AdminGetRecentPlayerBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.UserId is not null) QueryParams["userId"] = builder.UserId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetRecentPlayer(
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

        public override string Path => "/session/v1/admin/namespaces/{namespace}/recent-player";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsRecentPlayerQueryResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsRecentPlayerQueryResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsRecentPlayerQueryResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}