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

using AccelByte.Sdk.Api.Lobby.Model;

namespace AccelByte.Sdk.Api.Lobby.Operation
{
    /// <summary>
    /// getUserOutgoingFriends
    ///
    /// Get list of outgoing friends in a namespace.
    /// </summary>
    public class GetUserOutgoingFriends : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetUserOutgoingFriendsBuilder Builder { get => new GetUserOutgoingFriendsBuilder(); }

        public class GetUserOutgoingFriendsBuilder
            : OperationBuilder<GetUserOutgoingFriendsBuilder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }





            internal GetUserOutgoingFriendsBuilder() { }

            internal GetUserOutgoingFriendsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetUserOutgoingFriendsBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetUserOutgoingFriendsBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }





            public GetUserOutgoingFriends Build(
                string namespace_
            )
            {
                GetUserOutgoingFriends op = new GetUserOutgoingFriends(this,
                    namespace_
                );

                op.SetBaseFields<GetUserOutgoingFriendsBuilder>(this);
                return op;
            }

            public List<Model.ModelGetUserOutgoingFriendsResponse>? Execute(
                string namespace_
            )
            {
                GetUserOutgoingFriends op = Build(
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
            public async Task<List<Model.ModelGetUserOutgoingFriendsResponse>?> ExecuteAsync(
                string namespace_
            )
            {
                GetUserOutgoingFriends op = Build(
                    namespace_
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

        private GetUserOutgoingFriends(GetUserOutgoingFriendsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetUserOutgoingFriends(
            string namespace_,
            long? limit,
            long? offset
        )
        {
            PathParams["namespace"] = namespace_;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/friends/namespaces/{namespace}/me/outgoing";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public List<Model.ModelGetUserOutgoingFriendsResponse>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ModelGetUserOutgoingFriendsResponse>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ModelGetUserOutgoingFriendsResponse>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}