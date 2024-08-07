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

using AccelByte.Sdk.Api.Chat.Model;

namespace AccelByte.Sdk.Api.Chat.Operation
{
    /// <summary>
    /// publicUnmuteUser
    ///
    /// Unmute user.
    /// </summary>
    public class PublicUnmuteUser : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicUnmuteUserBuilder Builder { get => new PublicUnmuteUserBuilder(); }

        public class PublicUnmuteUserBuilder
            : OperationBuilder<PublicUnmuteUserBuilder>
        {





            internal PublicUnmuteUserBuilder() { }

            internal PublicUnmuteUserBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicUnmuteUser Build(
                ApiUnmuteUserRequest body,
                string namespace_,
                string topic
            )
            {
                PublicUnmuteUser op = new PublicUnmuteUser(this,
                    body,
                    namespace_,
                    topic
                );

                op.SetBaseFields<PublicUnmuteUserBuilder>(this);
                return op;
            }

            public void Execute(
                ApiUnmuteUserRequest body,
                string namespace_,
                string topic
            )
            {
                PublicUnmuteUser op = Build(
                    body,
                    namespace_,
                    topic
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
                ApiUnmuteUserRequest body,
                string namespace_,
                string topic
            )
            {
                PublicUnmuteUser op = Build(
                    body,
                    namespace_,
                    topic
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

        private PublicUnmuteUser(PublicUnmuteUserBuilder builder,
            ApiUnmuteUserRequest body,
            string namespace_,
            string topic
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["topic"] = topic;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicUnmuteUser(
            string namespace_,
            string topic,
            Model.ApiUnmuteUserRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["topic"] = topic;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/chat/public/namespaces/{namespace}/topic/{topic}/unmute";

        public override HttpMethod Method => HttpMethod.Put;

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