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
    /// publicGetPlayerBlockedPlayersV1
    ///
    /// Required valid user authorization
    /// 
    /// 
    /// load blocked players in a namespace based on user id
    /// 
    /// Action Code: 50101
    /// </summary>
    public class PublicGetPlayerBlockedPlayersV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetPlayerBlockedPlayersV1Builder Builder { get => new PublicGetPlayerBlockedPlayersV1Builder(); }

        public class PublicGetPlayerBlockedPlayersV1Builder
            : OperationBuilder<PublicGetPlayerBlockedPlayersV1Builder>
        {





            internal PublicGetPlayerBlockedPlayersV1Builder() { }

            internal PublicGetPlayerBlockedPlayersV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicGetPlayerBlockedPlayersV1 Build(
                string namespace_
            )
            {
                PublicGetPlayerBlockedPlayersV1 op = new PublicGetPlayerBlockedPlayersV1(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.ModelsGetAllPlayerBlockedUsersResponse? Execute(
                string namespace_
            )
            {
                PublicGetPlayerBlockedPlayersV1 op = Build(
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

        private PublicGetPlayerBlockedPlayersV1(PublicGetPlayerBlockedPlayersV1Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGetPlayerBlockedPlayersV1(
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/lobby/v1/public/player/namespaces/{namespace}/users/me/blocked";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsGetAllPlayerBlockedUsersResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetAllPlayerBlockedUsersResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetAllPlayerBlockedUsersResponse>(payload);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}