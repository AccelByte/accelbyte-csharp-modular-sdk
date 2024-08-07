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
    /// adminBulkBlockPlayersV1
    ///
    /// Bulk block player in a namespace by list of user id
    /// </summary>
    public class AdminBulkBlockPlayersV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminBulkBlockPlayersV1Builder Builder { get => new AdminBulkBlockPlayersV1Builder(); }

        public class AdminBulkBlockPlayersV1Builder
            : OperationBuilder<AdminBulkBlockPlayersV1Builder>
        {





            internal AdminBulkBlockPlayersV1Builder() { }

            internal AdminBulkBlockPlayersV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminBulkBlockPlayersV1 Build(
                ModelsListBlockedPlayerRequest body,
                string namespace_,
                string userId
            )
            {
                AdminBulkBlockPlayersV1 op = new AdminBulkBlockPlayersV1(this,
                    body,
                    namespace_,
                    userId
                );

                op.SetBaseFields<AdminBulkBlockPlayersV1Builder>(this);
                return op;
            }

            public void Execute(
                ModelsListBlockedPlayerRequest body,
                string namespace_,
                string userId
            )
            {
                AdminBulkBlockPlayersV1 op = Build(
                    body,
                    namespace_,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task ExecuteAsync(
                ModelsListBlockedPlayerRequest body,
                string namespace_,
                string userId
            )
            {
                AdminBulkBlockPlayersV1 op = Build(
                    body,
                    namespace_,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private AdminBulkBlockPlayersV1(AdminBulkBlockPlayersV1Builder builder,
            ModelsListBlockedPlayerRequest body,
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

        public AdminBulkBlockPlayersV1(
            string namespace_,
            string userId,
            Model.ModelsListBlockedPlayerRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/lobby/v1/admin/player/namespaces/{namespace}/users/{userId}/bulk/block";

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