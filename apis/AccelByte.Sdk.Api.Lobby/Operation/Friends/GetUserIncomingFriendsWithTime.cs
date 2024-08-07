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
    /// getUserIncomingFriendsWithTime
    ///
    /// Get list of incoming friends with requested time info in a namespace.
    /// </summary>
    public class GetUserIncomingFriendsWithTime : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetUserIncomingFriendsWithTimeBuilder Builder { get => new GetUserIncomingFriendsWithTimeBuilder(); }

        public class GetUserIncomingFriendsWithTimeBuilder
            : OperationBuilder<GetUserIncomingFriendsWithTimeBuilder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }





            internal GetUserIncomingFriendsWithTimeBuilder() { }

            internal GetUserIncomingFriendsWithTimeBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetUserIncomingFriendsWithTimeBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetUserIncomingFriendsWithTimeBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }





            public GetUserIncomingFriendsWithTime Build(
                string namespace_
            )
            {
                GetUserIncomingFriendsWithTime op = new GetUserIncomingFriendsWithTime(this,
                    namespace_
                );

                op.SetBaseFields<GetUserIncomingFriendsWithTimeBuilder>(this);
                return op;
            }

            public List<Model.ModelLoadIncomingFriendsWithTimeResponse>? Execute(
                string namespace_
            )
            {
                GetUserIncomingFriendsWithTime op = Build(
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
            public async Task<List<Model.ModelLoadIncomingFriendsWithTimeResponse>?> ExecuteAsync(
                string namespace_
            )
            {
                GetUserIncomingFriendsWithTime op = Build(
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

        private GetUserIncomingFriendsWithTime(GetUserIncomingFriendsWithTimeBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetUserIncomingFriendsWithTime(
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

        public override string Path => "/friends/namespaces/{namespace}/me/incoming-time";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public List<Model.ModelLoadIncomingFriendsWithTimeResponse>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ModelLoadIncomingFriendsWithTimeResponse>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ModelLoadIncomingFriendsWithTimeResponse>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}