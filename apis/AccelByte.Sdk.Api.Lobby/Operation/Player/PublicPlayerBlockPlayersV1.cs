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

using AccelByte.Sdk.Api.Lobby.Model;

namespace AccelByte.Sdk.Api.Lobby.Operation
{
    /// <summary>
    /// publicPlayerBlockPlayersV1
    ///
    /// Required valid user authorization
    /// 
    /// 
    /// add blocked players in a namespace based on user id
    /// </summary>
    public class PublicPlayerBlockPlayersV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicPlayerBlockPlayersV1Builder Builder { get => new PublicPlayerBlockPlayersV1Builder(); }

        public class PublicPlayerBlockPlayersV1Builder
            : OperationBuilder<PublicPlayerBlockPlayersV1Builder>
        {





            internal PublicPlayerBlockPlayersV1Builder() { }

            internal PublicPlayerBlockPlayersV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicPlayerBlockPlayersV1 Build(
                ModelsBlockPlayerRequest body,
                string namespace_
            )
            {
                PublicPlayerBlockPlayersV1 op = new PublicPlayerBlockPlayersV1(this,
                    body,
                    namespace_
                );

                op.SetBaseFields<PublicPlayerBlockPlayersV1Builder>(this);
                return op;
            }

            public PublicPlayerBlockPlayersV1.Response Execute(
                ModelsBlockPlayerRequest body,
                string namespace_
            )
            {
                PublicPlayerBlockPlayersV1 op = Build(
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
            public async Task<PublicPlayerBlockPlayersV1.Response> ExecuteAsync(
                ModelsBlockPlayerRequest body,
                string namespace_
            )
            {
                PublicPlayerBlockPlayersV1 op = Build(
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

        private PublicPlayerBlockPlayersV1(PublicPlayerBlockPlayersV1Builder builder,
            ModelsBlockPlayerRequest body,
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

            public RestapiErrorResponseBody? Error400 { get; set; } = null;

            public RestapiErrorResponseBody? Error401 { get; set; } = null;

            public RestapiErrorResponseBody? Error403 { get; set; } = null;

            public RestapiErrorResponseBody? Error404 { get; set; } = null;

            public RestapiErrorResponseBody? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Lobby::Player::PublicPlayerBlockPlayersV1";
        }

        #endregion

        public PublicPlayerBlockPlayersV1(
            string namespace_,
            Model.ModelsBlockPlayerRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/lobby/v1/public/player/namespaces/{namespace}/users/me/block";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public PublicPlayerBlockPlayersV1.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new PublicPlayerBlockPlayersV1.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };

            if (code == (HttpStatusCode)400)

            {
                response.Error400 = JsonSerializer.Deserialize<RestapiErrorResponseBody>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)

            {
                response.Error401 = JsonSerializer.Deserialize<RestapiErrorResponseBody>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)

            {
                response.Error403 = JsonSerializer.Deserialize<RestapiErrorResponseBody>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)

            {
                response.Error404 = JsonSerializer.Deserialize<RestapiErrorResponseBody>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)

            {
                response.Error500 = JsonSerializer.Deserialize<RestapiErrorResponseBody>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}