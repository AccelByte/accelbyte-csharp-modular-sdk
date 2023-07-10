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
    /// DeleteUserFromSessionInChannel
    ///
    /// Required Permission: ADMIN:NAMESPACE:{namespace}:MATCHMAKING:CHANNEL [Delete]
    /// 
    /// Required Scope: social
    /// 
    /// Delete a user from a session in the channel.
    /// </summary>
    public class DeleteUserFromSessionInChannel : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteUserFromSessionInChannelBuilder Builder { get => new DeleteUserFromSessionInChannelBuilder(); }

        public class DeleteUserFromSessionInChannelBuilder
            : OperationBuilder<DeleteUserFromSessionInChannelBuilder>
        {





            internal DeleteUserFromSessionInChannelBuilder() { }

            internal DeleteUserFromSessionInChannelBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteUserFromSessionInChannel Build(
                string channelName,
                string matchID,
                string namespace_,
                string userID
            )
            {
                DeleteUserFromSessionInChannel op = new DeleteUserFromSessionInChannel(this,
                    channelName,
                    matchID,
                    namespace_,
                    userID
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public void Execute(
                string channelName,
                string matchID,
                string namespace_,
                string userID
            )
            {
                DeleteUserFromSessionInChannel op = Build(
                    channelName,
                    matchID,
                    namespace_,
                    userID
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

        private DeleteUserFromSessionInChannel(DeleteUserFromSessionInChannelBuilder builder,
            string channelName,
            string matchID,
            string namespace_,
            string userID
        )
        {
            PathParams["channelName"] = channelName;
            PathParams["matchID"] = matchID;
            PathParams["namespace"] = namespace_;
            PathParams["userID"] = userID;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteUserFromSessionInChannel(
            string channelName,
            string matchID,
            string namespace_,
            string userID
        )
        {
            PathParams["channelName"] = channelName;
            PathParams["matchID"] = matchID;
            PathParams["namespace"] = namespace_;
            PathParams["userID"] = userID;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/matchmaking/v1/admin/namespaces/{namespace}/channels/{channelName}/sessions/{matchID}/users/{userID}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return;
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}