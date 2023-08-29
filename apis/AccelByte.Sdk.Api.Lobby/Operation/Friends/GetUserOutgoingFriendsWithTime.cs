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
    /// getUserOutgoingFriendsWithTime
    /// </summary>
    public class GetUserOutgoingFriendsWithTime : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetUserOutgoingFriendsWithTimeBuilder Builder { get => new GetUserOutgoingFriendsWithTimeBuilder(); }

        public class GetUserOutgoingFriendsWithTimeBuilder
            : OperationBuilder<GetUserOutgoingFriendsWithTimeBuilder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }





            internal GetUserOutgoingFriendsWithTimeBuilder() { }

            internal GetUserOutgoingFriendsWithTimeBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetUserOutgoingFriendsWithTimeBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetUserOutgoingFriendsWithTimeBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }





            public GetUserOutgoingFriendsWithTime Build(
                string namespace_
            )
            {
                GetUserOutgoingFriendsWithTime op = new GetUserOutgoingFriendsWithTime(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public List<Model.ModelLoadOutgoingFriendsWithTimeResponse>? Execute(
                string namespace_
            )
            {
                GetUserOutgoingFriendsWithTime op = Build(
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

        private GetUserOutgoingFriendsWithTime(GetUserOutgoingFriendsWithTimeBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetUserOutgoingFriendsWithTime(
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

        public override string Path => "/friends/namespaces/{namespace}/me/outgoing-time";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public List<Model.ModelLoadOutgoingFriendsWithTimeResponse>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ModelLoadOutgoingFriendsWithTimeResponse>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ModelLoadOutgoingFriendsWithTimeResponse>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}