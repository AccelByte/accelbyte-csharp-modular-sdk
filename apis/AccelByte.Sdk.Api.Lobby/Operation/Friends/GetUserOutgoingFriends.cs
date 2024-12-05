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

            public GetUserOutgoingFriends.Response Execute(
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
            public async Task<GetUserOutgoingFriends.Response> ExecuteAsync(
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

        #region Response Part        
        public class Response : ApiResponse<List<Model.ModelGetUserOutgoingFriendsResponse>>
        {

            public RestapiErrorResponseV1? Error400 { get; set; } = null;

            public RestapiErrorResponseV1? Error401 { get; set; } = null;

            public RestapiErrorResponseV1? Error403 { get; set; } = null;

            public RestapiErrorResponseV1? Error404 { get; set; } = null;

            public RestapiErrorResponseV1? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Lobby::Friends::GetUserOutgoingFriends";
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

        public GetUserOutgoingFriends.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GetUserOutgoingFriends.Response()
            {
                StatusCode = code,
                ContentType = contentType
            };

            if (code == (HttpStatusCode)204)
            {
                response.IsSuccess = true;
            }
            else if ((code == (HttpStatusCode)201) || (code == (HttpStatusCode)202) || (code == (HttpStatusCode)200))
            {
                response.Data = JsonSerializer.Deserialize<List<Model.ModelGetUserOutgoingFriendsResponse>>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<RestapiErrorResponseV1>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<RestapiErrorResponseV1>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<RestapiErrorResponseV1>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<RestapiErrorResponseV1>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<RestapiErrorResponseV1>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}