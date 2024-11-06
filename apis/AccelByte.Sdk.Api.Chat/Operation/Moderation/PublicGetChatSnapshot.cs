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

using AccelByte.Sdk.Api.Chat.Model;

namespace AccelByte.Sdk.Api.Chat.Operation
{
    /// <summary>
    /// publicGetChatSnapshot
    ///
    /// Get the chat snapshot
    /// </summary>
    public class PublicGetChatSnapshot : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetChatSnapshotBuilder Builder { get => new PublicGetChatSnapshotBuilder(); }

        public class PublicGetChatSnapshotBuilder
            : OperationBuilder<PublicGetChatSnapshotBuilder>
        {





            internal PublicGetChatSnapshotBuilder() { }

            internal PublicGetChatSnapshotBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicGetChatSnapshot Build(
                string chatId,
                string namespace_,
                string topic
            )
            {
                PublicGetChatSnapshot op = new PublicGetChatSnapshot(this,
                    chatId,                    
                    namespace_,                    
                    topic                    
                );

                op.SetBaseFields<PublicGetChatSnapshotBuilder>(this);
                return op;
            }

            public PublicGetChatSnapshot.Response Execute(
                string chatId,
                string namespace_,
                string topic
            )
            {
                PublicGetChatSnapshot op = Build(
                    chatId,
                    namespace_,
                    topic
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<PublicGetChatSnapshot.Response> ExecuteAsync(
                string chatId,
                string namespace_,
                string topic
            )
            {
                PublicGetChatSnapshot op = Build(
                    chatId,
                    namespace_,
                    topic
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

        private PublicGetChatSnapshot(PublicGetChatSnapshotBuilder builder,
            string chatId,
            string namespace_,
            string topic
        )
        {
            PathParams["chatId"] = chatId;
            PathParams["namespace"] = namespace_;
            PathParams["topic"] = topic;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelsChatSnapshots>
        {

            public RestapiErrorResponseBody? Error400 { get; set; } = null;

            public RestapiErrorResponseBody? Error401 { get; set; } = null;

            public RestapiErrorResponseBody? Error403 { get; set; } = null;

            public RestapiErrorResponseBody? Error404 { get; set; } = null;

            public RestapiErrorResponseBody? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Chat::Moderation::PublicGetChatSnapshot";
        }

        #endregion

        public PublicGetChatSnapshot(
            string chatId,            
            string namespace_,            
            string topic            
        )
        {
            PathParams["chatId"] = chatId;
            PathParams["namespace"] = namespace_;
            PathParams["topic"] = topic;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/chat/v1/public/namespaces/{namespace}/topic/{topic}/snapshot/{chatId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public PublicGetChatSnapshot.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new PublicGetChatSnapshot.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelsChatSnapshots>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
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