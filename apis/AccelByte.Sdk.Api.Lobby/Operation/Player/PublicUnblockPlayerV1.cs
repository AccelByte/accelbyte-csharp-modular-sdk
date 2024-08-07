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
    /// publicUnblockPlayerV1
    ///
    /// Required valid user authorization
    /// 
    /// unblock player in a namespace based on user id
    /// </summary>
    public class PublicUnblockPlayerV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicUnblockPlayerV1Builder Builder { get => new PublicUnblockPlayerV1Builder(); }

        public class PublicUnblockPlayerV1Builder
            : OperationBuilder<PublicUnblockPlayerV1Builder>
        {





            internal PublicUnblockPlayerV1Builder() { }

            internal PublicUnblockPlayerV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicUnblockPlayerV1 Build(
                ModelsUnblockPlayerRequest body,
                string namespace_
            )
            {
                PublicUnblockPlayerV1 op = new PublicUnblockPlayerV1(this,
                    body,
                    namespace_
                );

                op.SetBaseFields<PublicUnblockPlayerV1Builder>(this);
                return op;
            }

            public void Execute(
                ModelsUnblockPlayerRequest body,
                string namespace_
            )
            {
                PublicUnblockPlayerV1 op = Build(
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
            public async Task ExecuteAsync(
                ModelsUnblockPlayerRequest body,
                string namespace_
            )
            {
                PublicUnblockPlayerV1 op = Build(
                    body,
                    namespace_
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

        private PublicUnblockPlayerV1(PublicUnblockPlayerV1Builder builder,
            ModelsUnblockPlayerRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicUnblockPlayerV1(
            string namespace_,
            Model.ModelsUnblockPlayerRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/lobby/v1/public/player/namespaces/{namespace}/users/me/unblock";

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