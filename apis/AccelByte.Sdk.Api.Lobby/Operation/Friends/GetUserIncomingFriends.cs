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
    /// getUserIncomingFriends
    /// </summary>
    public class GetUserIncomingFriends : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetUserIncomingFriendsBuilder Builder { get => new GetUserIncomingFriendsBuilder(); }

        public class GetUserIncomingFriendsBuilder
            : OperationBuilder<GetUserIncomingFriendsBuilder>
        {





            internal GetUserIncomingFriendsBuilder() { }

            internal GetUserIncomingFriendsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetUserIncomingFriends Build(
                string namespace_
            )
            {
                GetUserIncomingFriends op = new GetUserIncomingFriends(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public List<Model.ModelGetUserIncomingFriendsResponse>? Execute(
                string namespace_
            )
            {
                GetUserIncomingFriends op = Build(
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

        private GetUserIncomingFriends(GetUserIncomingFriendsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetUserIncomingFriends(
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/friends/namespaces/{namespace}/me/incoming";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public List<Model.ModelGetUserIncomingFriendsResponse>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ModelGetUserIncomingFriendsResponse>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ModelGetUserIncomingFriendsResponse>>(payload);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}