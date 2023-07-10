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
    /// userAcceptFriendRequest
    /// </summary>
    public class UserAcceptFriendRequest : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UserAcceptFriendRequestBuilder Builder { get => new UserAcceptFriendRequestBuilder(); }

        public class UserAcceptFriendRequestBuilder
            : OperationBuilder<UserAcceptFriendRequestBuilder>
        {





            internal UserAcceptFriendRequestBuilder() { }

            internal UserAcceptFriendRequestBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UserAcceptFriendRequest Build(
                ModelUserAcceptFriendRequest body,
                string namespace_
            )
            {
                UserAcceptFriendRequest op = new UserAcceptFriendRequest(this,
                    body,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public void Execute(
                ModelUserAcceptFriendRequest body,
                string namespace_
            )
            {
                UserAcceptFriendRequest op = Build(
                    body,
                    namespace_
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

        private UserAcceptFriendRequest(UserAcceptFriendRequestBuilder builder,
            ModelUserAcceptFriendRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UserAcceptFriendRequest(
            string namespace_,
            Model.ModelUserAcceptFriendRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/friends/namespaces/{namespace}/me/request/accept";

        public override HttpMethod Method => HttpMethod.Post;

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