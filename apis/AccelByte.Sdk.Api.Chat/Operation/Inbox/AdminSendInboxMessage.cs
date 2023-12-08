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
    /// adminSendInboxMessage
    ///
    /// Send inbox message
    /// </summary>
    public class AdminSendInboxMessage : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminSendInboxMessageBuilder Builder { get => new AdminSendInboxMessageBuilder(); }

        public class AdminSendInboxMessageBuilder
            : OperationBuilder<AdminSendInboxMessageBuilder>
        {





            internal AdminSendInboxMessageBuilder() { }

            internal AdminSendInboxMessageBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminSendInboxMessage Build(
                ModelsSendInboxMessageRequest body,
                string messageId,
                string namespace_
            )
            {
                AdminSendInboxMessage op = new AdminSendInboxMessage(this,
                    body,                    
                    messageId,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelsSendInboxMessageResponse? Execute(
                ModelsSendInboxMessageRequest body,
                string messageId,
                string namespace_
            )
            {
                AdminSendInboxMessage op = Build(
                    body,
                    messageId,
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
        }

        private AdminSendInboxMessage(AdminSendInboxMessageBuilder builder,
            ModelsSendInboxMessageRequest body,
            string messageId,
            string namespace_
        )
        {
            PathParams["messageId"] = messageId;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminSendInboxMessage(
            string messageId,            
            string namespace_,            
            Model.ModelsSendInboxMessageRequest body            
        )
        {
            PathParams["messageId"] = messageId;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/chat/v1/admin/inbox/namespaces/{namespace}/messages/{messageId}/send";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.ModelsSendInboxMessageResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsSendInboxMessageResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsSendInboxMessageResponse>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}