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

using AccelByte.Sdk.Api.Matchmaking.Model;

namespace AccelByte.Sdk.Api.Matchmaking.Operation
{
    /// <summary>
    /// CreateChannelHandler
    ///
    /// Creates a new matchmaking channel.
    /// 
    /// Matchmaking channels is a list of pool name that is eligible for matchmaking processes.
    /// GameMode isolates each matchmaking pools.
    /// 
    /// If match timeout is set to 0, by default, incoming matchmaking requests will be timed out after 1 hour.
    /// 
    /// If max worker delay is set to 0, by default, it will wait for at max ~8 seconds during low volume.
    /// 
    /// Rule Set
    /// 
    /// Matching Rule used to classify the player. Player that has matched criteria will be grouped together within an ally.
    /// 
    /// Valid value for criteria is "distance"
    /// </summary>
    public class CreateChannelHandler : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateChannelHandlerBuilder Builder { get => new CreateChannelHandlerBuilder(); }

        public class CreateChannelHandlerBuilder
            : OperationBuilder<CreateChannelHandlerBuilder>
        {





            internal CreateChannelHandlerBuilder() { }

            internal CreateChannelHandlerBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public CreateChannelHandler Build(
                ModelsChannelRequest body,
                string namespace_
            )
            {
                CreateChannelHandler op = new CreateChannelHandler(this,
                    body,
                    namespace_
                );

                op.SetBaseFields<CreateChannelHandlerBuilder>(this);
                return op;
            }

            public CreateChannelHandler.Response Execute(
                ModelsChannelRequest body,
                string namespace_
            )
            {
                CreateChannelHandler op = Build(
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
            public async Task<CreateChannelHandler.Response> ExecuteAsync(
                ModelsChannelRequest body,
                string namespace_
            )
            {
                CreateChannelHandler op = Build(
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

        private CreateChannelHandler(CreateChannelHandlerBuilder builder,
            ModelsChannelRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelsCreateChannelResponse>
        {

            public ResponseError? Error400 { get; set; } = null;

            public ResponseError? Error401 { get; set; } = null;

            public ResponseError? Error403 { get; set; } = null;

            public ResponseError? Error409 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Matchmaking::Matchmaking::CreateChannelHandler";
        }

        #endregion

        public CreateChannelHandler(
            string namespace_,
            Model.ModelsChannelRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/matchmaking/namespaces/{namespace}/channels";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public CreateChannelHandler.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new CreateChannelHandler.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelsCreateChannelResponse>(payload, ResponseJsonOptions);
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
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)409)
            {
                response.Error409 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error409!.TranslateToApiError();
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