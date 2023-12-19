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

using AccelByte.Sdk.Api.Chat.Model;

namespace AccelByte.Sdk.Api.Chat.Operation
{
    /// <summary>
    /// publicMuteUser
    ///
    /// Mute user.
    /// </summary>
    public class PublicMuteUser : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicMuteUserBuilder Builder { get => new PublicMuteUserBuilder(); }

        public class PublicMuteUserBuilder
            : OperationBuilder<PublicMuteUserBuilder>
        {





            internal PublicMuteUserBuilder() { }

            internal PublicMuteUserBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicMuteUser Build(
                ApiMuteUserRequest body,
                string namespace_,
                string topic
            )
            {
                PublicMuteUser op = new PublicMuteUser(this,
                    body,
                    namespace_,
                    topic
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public void Execute(
                ApiMuteUserRequest body,
                string namespace_,
                string topic
            )
            {
                PublicMuteUser op = Build(
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
        }

        private PublicMuteUser(PublicMuteUserBuilder builder,
            ApiMuteUserRequest body,
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

        public PublicMuteUser(
            string namespace_,
            string topic,
            Model.ApiMuteUserRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["topic"] = topic;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/chat/public/namespaces/{namespace}/topic/{topic}/mute";

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