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
    /// UsersPresenceHandlerV1
    ///
    /// Query users presence with given namespace and userIds.
    /// </summary>
    public class UsersPresenceHandlerV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UsersPresenceHandlerV1Builder Builder { get => new UsersPresenceHandlerV1Builder(); }

        public class UsersPresenceHandlerV1Builder
            : OperationBuilder<UsersPresenceHandlerV1Builder>
        {

            public bool? CountOnly { get; set; }





            internal UsersPresenceHandlerV1Builder() { }

            internal UsersPresenceHandlerV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public UsersPresenceHandlerV1Builder SetCountOnly(bool _countOnly)
            {
                CountOnly = _countOnly;
                return this;
            }





            public UsersPresenceHandlerV1 Build(
                string namespace_,
                string userIds
            )
            {
                UsersPresenceHandlerV1 op = new UsersPresenceHandlerV1(this,
                    namespace_,                    
                    userIds                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.HandlersGetUsersPresenceResponse? Execute(
                string namespace_,
                string userIds
            )
            {
                UsersPresenceHandlerV1 op = Build(
                    namespace_,
                    userIds
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

        private UsersPresenceHandlerV1(UsersPresenceHandlerV1Builder builder,
            string namespace_,
            string userIds
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.CountOnly != null) QueryParams["countOnly"] = Convert.ToString(builder.CountOnly)!;
            if (userIds is not null) QueryParams["userIds"] = userIds;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UsersPresenceHandlerV1(
            string namespace_,            
            bool? countOnly,            
            string userIds            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (countOnly != null) QueryParams["countOnly"] = Convert.ToString(countOnly)!;
            if (userIds is not null) QueryParams["userIds"] = userIds;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/lobby/v1/public/presence/namespaces/{namespace}/users/presence";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.HandlersGetUsersPresenceResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.HandlersGetUsersPresenceResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.HandlersGetUsersPresenceResponse>(payload);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}