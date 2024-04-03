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
    /// createTopic
    ///
    /// Create new notification topic.
    /// 
    /// topic should be alphabets, no special char except underscore, uppercase and no spacing. for example: TOPIC_TEST.
    /// Already existing topic can not be created
    /// </summary>
    public class CreateTopic : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateTopicBuilder Builder { get => new CreateTopicBuilder(); }

        public class CreateTopicBuilder
            : OperationBuilder<CreateTopicBuilder>
        {





            internal CreateTopicBuilder() { }

            internal CreateTopicBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public CreateTopic Build(
                ModelCreateTopicRequest body,
                string namespace_
            )
            {
                CreateTopic op = new CreateTopic(this,
                    body,
                    namespace_
                );

                op.SetBaseFields<CreateTopicBuilder>(this);
                return op;
            }

            public void Execute(
                ModelCreateTopicRequest body,
                string namespace_
            )
            {
                CreateTopic op = Build(
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
                ModelCreateTopicRequest body,
                string namespace_
            )
            {
                CreateTopic op = Build(
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

        private CreateTopic(CreateTopicBuilder builder,
            ModelCreateTopicRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CreateTopic(
            string namespace_,
            Model.ModelCreateTopicRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/notification/namespaces/{namespace}/topics";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)201)
            {
                return;
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}