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
    /// DeleteSessionInChannel
    ///
    /// Required Permission: ADMIN:NAMESPACE:{namespace}:MATCHMAKING:CHANNEL [Delete]
    /// 
    /// Required Scope: social
    /// 
    /// Delete a session in a channel.
    /// </summary>
    public class DeleteSessionInChannel : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteSessionInChannelBuilder Builder { get => new DeleteSessionInChannelBuilder(); }

        public class DeleteSessionInChannelBuilder
            : OperationBuilder<DeleteSessionInChannelBuilder>
        {





            internal DeleteSessionInChannelBuilder() { }

            internal DeleteSessionInChannelBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteSessionInChannel Build(
                string channelName,
                string matchID,
                string namespace_
            )
            {
                DeleteSessionInChannel op = new DeleteSessionInChannel(this,
                    channelName,
                    matchID,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public void Execute(
                string channelName,
                string matchID,
                string namespace_
            )
            {
                DeleteSessionInChannel op = Build(
                    channelName,
                    matchID,
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

        private DeleteSessionInChannel(DeleteSessionInChannelBuilder builder,
            string channelName,
            string matchID,
            string namespace_
        )
        {
            PathParams["channelName"] = channelName;
            PathParams["matchID"] = matchID;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteSessionInChannel(
            string channelName,
            string matchID,
            string namespace_
        )
        {
            PathParams["channelName"] = channelName;
            PathParams["matchID"] = matchID;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/matchmaking/v1/admin/namespaces/{namespace}/channels/{channelName}/sessions/{matchID}";

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