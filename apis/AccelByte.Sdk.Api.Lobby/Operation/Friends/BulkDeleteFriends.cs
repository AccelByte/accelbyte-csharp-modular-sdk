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
    /// bulkDeleteFriends
    ///
    /// Friends request in a namespace.
    /// </summary>
    public class BulkDeleteFriends : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static BulkDeleteFriendsBuilder Builder { get => new BulkDeleteFriendsBuilder(); }

        public class BulkDeleteFriendsBuilder
            : OperationBuilder<BulkDeleteFriendsBuilder>
        {





            internal BulkDeleteFriendsBuilder() { }

            internal BulkDeleteFriendsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public BulkDeleteFriends Build(
                ModelBulkFriendsRequest body,
                string namespace_,
                string userId
            )
            {
                BulkDeleteFriends op = new BulkDeleteFriends(this,
                    body,
                    namespace_,
                    userId
                );

                op.SetBaseFields<BulkDeleteFriendsBuilder>(this);
                return op;
            }

            public Model.ModelBulkFriendsResponse? Execute(
                ModelBulkFriendsRequest body,
                string namespace_,
                string userId
            )
            {
                BulkDeleteFriends op = Build(
                    body,
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
            public async Task<Model.ModelBulkFriendsResponse?> ExecuteAsync(
                ModelBulkFriendsRequest body,
                string namespace_,
                string userId
            )
            {
                BulkDeleteFriends op = Build(
                    body,
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

        private BulkDeleteFriends(BulkDeleteFriendsBuilder builder,
            ModelBulkFriendsRequest body,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public BulkDeleteFriends(
            string namespace_,
            string userId,
            Model.ModelBulkFriendsRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/friends/namespaces/{namespace}/users/{userId}/delete/bulk";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelBulkFriendsResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelBulkFriendsResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelBulkFriendsResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}