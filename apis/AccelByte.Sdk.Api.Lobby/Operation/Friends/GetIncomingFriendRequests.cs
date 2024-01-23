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
    /// get incoming friend requests
    ///
    /// Get list of incoming friend requests.
    /// </summary>
    public class GetIncomingFriendRequests : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetIncomingFriendRequestsBuilder Builder { get => new GetIncomingFriendRequestsBuilder(); }

        public class GetIncomingFriendRequestsBuilder
            : OperationBuilder<GetIncomingFriendRequestsBuilder>
        {

            public string? FriendId { get; set; }

            public long? Limit { get; set; }

            public long? Offset { get; set; }





            internal GetIncomingFriendRequestsBuilder() { }

            internal GetIncomingFriendRequestsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetIncomingFriendRequestsBuilder SetFriendId(string _friendId)
            {
                FriendId = _friendId;
                return this;
            }

            public GetIncomingFriendRequestsBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetIncomingFriendRequestsBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }





            public GetIncomingFriendRequests Build(
                string namespace_,
                string userId
            )
            {
                GetIncomingFriendRequests op = new GetIncomingFriendRequests(this,
                    namespace_,
                    userId
                );

                op.SetBaseFields<GetIncomingFriendRequestsBuilder>(this);
                return op;
            }

            public Model.ModelLoadIncomingFriendsWithTimeResponse? Execute(
                string namespace_,
                string userId
            )
            {
                GetIncomingFriendRequests op = Build(
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

        private GetIncomingFriendRequests(GetIncomingFriendRequestsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (builder.FriendId is not null) QueryParams["friendId"] = builder.FriendId;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetIncomingFriendRequests(
            string namespace_,
            string userId,
            string? friendId,
            long? limit,
            long? offset
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (friendId is not null) QueryParams["friendId"] = friendId;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/lobby/v1/admin/friend/namespaces/{namespace}/users/{userId}/incoming";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelLoadIncomingFriendsWithTimeResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelLoadIncomingFriendsWithTimeResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelLoadIncomingFriendsWithTimeResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}