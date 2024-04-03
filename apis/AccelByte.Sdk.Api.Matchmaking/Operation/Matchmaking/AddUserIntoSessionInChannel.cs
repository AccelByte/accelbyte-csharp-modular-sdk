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

using AccelByte.Sdk.Api.Matchmaking.Model;

namespace AccelByte.Sdk.Api.Matchmaking.Operation
{
    /// <summary>
    /// AddUserIntoSessionInChannel
    ///
    /// Add user into the session in a channel.
    /// </summary>
    public class AddUserIntoSessionInChannel : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AddUserIntoSessionInChannelBuilder Builder { get => new AddUserIntoSessionInChannelBuilder(); }

        public class AddUserIntoSessionInChannelBuilder
            : OperationBuilder<AddUserIntoSessionInChannelBuilder>
        {





            internal AddUserIntoSessionInChannelBuilder() { }

            internal AddUserIntoSessionInChannelBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AddUserIntoSessionInChannel Build(
                ModelsMatchAddUserIntoSessionRequest body,
                string channelName,
                string matchID,
                string namespace_
            )
            {
                AddUserIntoSessionInChannel op = new AddUserIntoSessionInChannel(this,
                    body,
                    channelName,
                    matchID,
                    namespace_
                );

                op.SetBaseFields<AddUserIntoSessionInChannelBuilder>(this);
                return op;
            }

            public void Execute(
                ModelsMatchAddUserIntoSessionRequest body,
                string channelName,
                string matchID,
                string namespace_
            )
            {
                AddUserIntoSessionInChannel op = Build(
                    body,
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
            public async Task ExecuteAsync(
                ModelsMatchAddUserIntoSessionRequest body,
                string channelName,
                string matchID,
                string namespace_
            )
            {
                AddUserIntoSessionInChannel op = Build(
                    body,
                    channelName,
                    matchID,
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

        private AddUserIntoSessionInChannel(AddUserIntoSessionInChannelBuilder builder,
            ModelsMatchAddUserIntoSessionRequest body,
            string channelName,
            string matchID,
            string namespace_
        )
        {
            PathParams["channelName"] = channelName;
            PathParams["matchID"] = matchID;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AddUserIntoSessionInChannel(
            string channelName,
            string matchID,
            string namespace_,
            Model.ModelsMatchAddUserIntoSessionRequest body
        )
        {
            PathParams["channelName"] = channelName;
            PathParams["matchID"] = matchID;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/matchmaking/v1/admin/namespaces/{namespace}/channels/{channelName}/sessions/{matchID}";

        public override HttpMethod Method => HttpMethod.Post;

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