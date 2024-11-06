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
    /// adminDeleteChat
    ///
    /// Delete chat.
    /// </summary>
    public class AdminDeleteChat : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDeleteChatBuilder Builder { get => new AdminDeleteChatBuilder(); }

        public class AdminDeleteChatBuilder
            : OperationBuilder<AdminDeleteChatBuilder>
        {





            internal AdminDeleteChatBuilder() { }

            internal AdminDeleteChatBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminDeleteChat Build(
                string chatId,
                string namespace_,
                string topic
            )
            {
                AdminDeleteChat op = new AdminDeleteChat(this,
                    chatId,                    
                    namespace_,                    
                    topic                    
                );

                op.SetBaseFields<AdminDeleteChatBuilder>(this);
                return op;
            }

            public AdminDeleteChat.Response Execute(
                string chatId,
                string namespace_,
                string topic
            )
            {
                AdminDeleteChat op = Build(
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
            public async Task<AdminDeleteChat.Response> ExecuteAsync(
                string chatId,
                string namespace_,
                string topic
            )
            {
                AdminDeleteChat op = Build(
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

        private AdminDeleteChat(AdminDeleteChatBuilder builder,
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
        public class Response : ApiResponse
        {

            public RestapiErrorResponseBody? Error400 { get; set; } = null;

            public RestapiErrorResponseBody? Error401 { get; set; } = null;

            public RestapiErrorResponseBody? Error403 { get; set; } = null;

            public RestapiErrorResponseBody? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Chat::Topic::AdminDeleteChat";
        }

        #endregion

        public AdminDeleteChat(
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

        public override string Path => "/chat/admin/namespaces/{namespace}/topic/{topic}/chats/{chatId}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public AdminDeleteChat.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminDeleteChat.Response()
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
            else if (code == (HttpStatusCode)500)
            
            {
                response.Error500 = JsonSerializer.Deserialize<RestapiErrorResponseBody>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}