// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
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

            public void Execute(
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
                op.ParseResponse(
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

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}