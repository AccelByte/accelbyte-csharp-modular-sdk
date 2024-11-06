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
    /// get list of friends
    ///
    /// Get list of friends in a namespace.
    /// </summary>
    public class GetListOfFriends : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetListOfFriendsBuilder Builder { get => new GetListOfFriendsBuilder(); }

        public class GetListOfFriendsBuilder
            : OperationBuilder<GetListOfFriendsBuilder>
        {

            public string? FriendId { get; set; }

            public List<string>? FriendIds { get; set; }

            public long? Limit { get; set; }

            public long? Offset { get; set; }





            internal GetListOfFriendsBuilder() { }

            internal GetListOfFriendsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetListOfFriendsBuilder SetFriendId(string _friendId)
            {
                FriendId = _friendId;
                return this;
            }

            public GetListOfFriendsBuilder SetFriendIds(List<string> _friendIds)
            {
                FriendIds = _friendIds;
                return this;
            }

            public GetListOfFriendsBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetListOfFriendsBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }





            public GetListOfFriends Build(
                string namespace_,
                string userId
            )
            {
                GetListOfFriends op = new GetListOfFriends(this,
                    namespace_,                    
                    userId                    
                );

                op.SetBaseFields<GetListOfFriendsBuilder>(this);
                return op;
            }

            public GetListOfFriends.Response Execute(
                string namespace_,
                string userId
            )
            {
                GetListOfFriends op = Build(
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
            public async Task<GetListOfFriends.Response> ExecuteAsync(
                string namespace_,
                string userId
            )
            {
                GetListOfFriends op = Build(
                    namespace_,
                    userId
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

        private GetListOfFriends(GetListOfFriendsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (builder.FriendId is not null) QueryParams["friendId"] = builder.FriendId;
            if (builder.FriendIds is not null) QueryParams["friendIds"] = builder.FriendIds;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            

            
            CollectionFormatMap["friendIds"] = "csv";
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelGetFriendsResponse>
        {

            public RestapiErrorResponseBody? Error400 { get; set; } = null;

            public RestapiErrorResponseBody? Error401 { get; set; } = null;

            public RestapiErrorResponseBody? Error403 { get; set; } = null;

            public RestapiErrorResponseBody? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Lobby::Friends::GetListOfFriends";
        }

        #endregion

        public GetListOfFriends(
            string namespace_,            
            string userId,            
            string? friendId,            
            List<string>? friendIds,            
            long? limit,            
            long? offset            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (friendId is not null) QueryParams["friendId"] = friendId;
            if (friendIds is not null) QueryParams["friendIds"] = friendIds;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            

            
            CollectionFormatMap["friendIds"] = "csv";
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/lobby/v1/admin/friend/namespaces/{namespace}/users/{userId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public GetListOfFriends.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GetListOfFriends.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelGetFriendsResponse>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<RestapiErrorResponseBody>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<RestapiErrorResponseBody>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<RestapiErrorResponseBody>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<RestapiErrorResponseBody>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}