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

using AccelByte.Sdk.Api.Matchmaking.Model;

namespace AccelByte.Sdk.Api.Matchmaking.Operation
{
    /// <summary>
    /// DeleteChannelHandler
    ///
    /// Required Permission: NAMESPACE:{namespace}:MATCHMAKING:CHANNEL [Delete]
    /// 
    /// Required Scope: social
    /// 
    /// Deletes a matchmaking channel. Matchmaking channels is a list of
    /// pool name that is eligible for matchmaking processes. GameMode isolates each matchmaking pools.
    /// 
    /// Trying to delete non-existent channel will result deletion success
    /// </summary>
    public class DeleteChannelHandler : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteChannelHandlerBuilder Builder { get => new DeleteChannelHandlerBuilder(); }

        public class DeleteChannelHandlerBuilder
            : OperationBuilder<DeleteChannelHandlerBuilder>
        {





            internal DeleteChannelHandlerBuilder() { }

            internal DeleteChannelHandlerBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteChannelHandler Build(
                string channel,
                string namespace_
            )
            {
                DeleteChannelHandler op = new DeleteChannelHandler(this,
                    channel,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public void Execute(
                string channel,
                string namespace_
            )
            {
                DeleteChannelHandler op = Build(
                    channel,
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
        }

        private DeleteChannelHandler(DeleteChannelHandlerBuilder builder,
            string channel,
            string namespace_
        )
        {
            PathParams["channel"] = channel;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteChannelHandler(
            string channel,
            string namespace_
        )
        {
            PathParams["channel"] = channel;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/matchmaking/namespaces/{namespace}/channels/{channel}";

        public override HttpMethod Method => HttpMethod.Delete;

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