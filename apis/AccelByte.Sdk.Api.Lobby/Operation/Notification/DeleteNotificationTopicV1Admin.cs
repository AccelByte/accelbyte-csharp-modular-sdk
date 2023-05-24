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
    /// deleteNotificationTopicV1Admin
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:NOTIFICATION [DELETE]` with scope `social`
    /// 
    /// delete topic information by topic name.
    /// 
    /// topic should be alphabets, no special char except underscore, uppercase and no spacing. for example: TOPIC_TEST.
    /// Already existing topic can not be created
    /// 
    /// Action Code: 50217
    /// </summary>
    public class DeleteNotificationTopicV1Admin : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteNotificationTopicV1AdminBuilder Builder { get => new DeleteNotificationTopicV1AdminBuilder(); }

        public class DeleteNotificationTopicV1AdminBuilder
            : OperationBuilder<DeleteNotificationTopicV1AdminBuilder>
        {





            internal DeleteNotificationTopicV1AdminBuilder() { }

            internal DeleteNotificationTopicV1AdminBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteNotificationTopicV1Admin Build(
                string namespace_,
                string topicName
            )
            {
                DeleteNotificationTopicV1Admin op = new DeleteNotificationTopicV1Admin(this,
                    namespace_,
                    topicName
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public void Execute(
                string namespace_,
                string topicName
            )
            {
                DeleteNotificationTopicV1Admin op = Build(
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
        }

        private DeleteNotificationTopicV1Admin(DeleteNotificationTopicV1AdminBuilder builder,
            string namespace_,
            string topicName
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["topicName"] = topicName;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteNotificationTopicV1Admin(
            string namespace_,
            string topicName
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["topicName"] = topicName;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/lobby/v1/admin/notification/namespaces/{namespace}/topics/{topicName}";

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