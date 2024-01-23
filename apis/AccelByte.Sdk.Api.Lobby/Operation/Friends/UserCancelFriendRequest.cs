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
    /// userCancelFriendRequest
    ///
    /// User cancel a friend request.
    /// </summary>
    public class UserCancelFriendRequest : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UserCancelFriendRequestBuilder Builder { get => new UserCancelFriendRequestBuilder(); }

        public class UserCancelFriendRequestBuilder
            : OperationBuilder<UserCancelFriendRequestBuilder>
        {





            internal UserCancelFriendRequestBuilder() { }

            internal UserCancelFriendRequestBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UserCancelFriendRequest Build(
                ModelUserCancelFriendRequest body,
                string namespace_
            )
            {
                UserCancelFriendRequest op = new UserCancelFriendRequest(this,
                    body,
                    namespace_
                );

                op.SetBaseFields<UserCancelFriendRequestBuilder>(this);
                return op;
            }

            public void Execute(
                ModelUserCancelFriendRequest body,
                string namespace_
            )
            {
                UserCancelFriendRequest op = Build(
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

        private UserCancelFriendRequest(UserCancelFriendRequestBuilder builder,
            ModelUserCancelFriendRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UserCancelFriendRequest(
            string namespace_,
            Model.ModelUserCancelFriendRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/friends/namespaces/{namespace}/me/request/cancel";

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