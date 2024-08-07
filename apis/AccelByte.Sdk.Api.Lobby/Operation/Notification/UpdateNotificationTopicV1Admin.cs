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
    /// updateNotificationTopicV1Admin
    ///
    /// Update topic information by topic name.
    /// 
    /// topic should be alphabets, no special char except underscore, uppercase and no spacing. for example: TOPIC_TEST.
    /// Already existing topic can not be created
    /// 
    /// Action Code: 50216
    /// </summary>
    public class UpdateNotificationTopicV1Admin : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateNotificationTopicV1AdminBuilder Builder { get => new UpdateNotificationTopicV1AdminBuilder(); }

        public class UpdateNotificationTopicV1AdminBuilder
            : OperationBuilder<UpdateNotificationTopicV1AdminBuilder>
        {





            internal UpdateNotificationTopicV1AdminBuilder() { }

            internal UpdateNotificationTopicV1AdminBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UpdateNotificationTopicV1Admin Build(
                ModelUpdateTopicRequest body,
                string namespace_,
                string topicName
            )
            {
                UpdateNotificationTopicV1Admin op = new UpdateNotificationTopicV1Admin(this,
                    body,
                    namespace_,
                    topicName
                );

                op.SetBaseFields<UpdateNotificationTopicV1AdminBuilder>(this);
                return op;
            }

            public void Execute(
                ModelUpdateTopicRequest body,
                string namespace_,
                string topicName
            )
            {
                UpdateNotificationTopicV1Admin op = Build(
                    body,
                    namespace_,
                    topicName
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
                ModelUpdateTopicRequest body,
                string namespace_,
                string topicName
            )
            {
                UpdateNotificationTopicV1Admin op = Build(
                    body,
                    namespace_,
                    topicName
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

        private UpdateNotificationTopicV1Admin(UpdateNotificationTopicV1AdminBuilder builder,
            ModelUpdateTopicRequest body,
            string namespace_,
            string topicName
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["topicName"] = topicName;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateNotificationTopicV1Admin(
            string namespace_,
            string topicName,
            Model.ModelUpdateTopicRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["topicName"] = topicName;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/lobby/v1/admin/notification/namespaces/{namespace}/topics/{topicName}";

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