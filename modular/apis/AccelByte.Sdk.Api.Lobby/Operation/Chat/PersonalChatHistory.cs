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

using AccelByte.Sdk.Api.Lobby.Model;

namespace AccelByte.Sdk.Api.Lobby.Operation
{
    /// <summary>
    /// personalChatHistory
    ///
    /// Required permission : `NAMESPACE:{namespace}:USER:{userId}:CHAT [READ]` with scope `social`
    /// 
    /// load personal chat history in a namespace.
    /// </summary>
    public class PersonalChatHistory : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PersonalChatHistoryBuilder Builder { get => new PersonalChatHistoryBuilder(); }

        public class PersonalChatHistoryBuilder
            : OperationBuilder<PersonalChatHistoryBuilder>
        {





            internal PersonalChatHistoryBuilder() { }

            internal PersonalChatHistoryBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PersonalChatHistory Build(
                string friendId,
                string namespace_,
                string userId
            )
            {
                PersonalChatHistory op = new PersonalChatHistory(this,
                    friendId,                    
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public List<Model.ModelChatMessageResponse>? Execute(
                string friendId,
                string namespace_,
                string userId
            )
            {
                PersonalChatHistory op = Build(
                    friendId,
                    namespace_,
                    userId
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

        private PersonalChatHistory(PersonalChatHistoryBuilder builder,
            string friendId,
            string namespace_,
            string userId
        )
        {
            PathParams["friendId"] = friendId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PersonalChatHistory(
            string friendId,            
            string namespace_,            
            string userId            
        )
        {
            PathParams["friendId"] = friendId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/lobby/chat/namespaces/{namespace}/users/{userId}/friend/{friendId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public List<Model.ModelChatMessageResponse>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ModelChatMessageResponse>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ModelChatMessageResponse>>(payload);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}