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
    /// sendUsersTemplatedNotificationV1Admin
    ///
    /// Sends notification to all connected users in a namespace with predefined template.
    /// 
    /// In the request body, specify which template slug (template identifier) to use and the template language.
    /// 
    /// NotificationTemplate context is the key-value pair defining the value of each handlebar specified in the template content.
    /// Template need to be published before it can be use to send notifications
    /// 
    /// Action Code: 50202
    /// </summary>
    public class SendUsersTemplatedNotificationV1Admin : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SendUsersTemplatedNotificationV1AdminBuilder Builder { get => new SendUsersTemplatedNotificationV1AdminBuilder(); }

        public class SendUsersTemplatedNotificationV1AdminBuilder
            : OperationBuilder<SendUsersTemplatedNotificationV1AdminBuilder>
        {





            internal SendUsersTemplatedNotificationV1AdminBuilder() { }

            internal SendUsersTemplatedNotificationV1AdminBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public SendUsersTemplatedNotificationV1Admin Build(
                ModelNotificationWithTemplateRequestV1 body,
                string namespace_
            )
            {
                SendUsersTemplatedNotificationV1Admin op = new SendUsersTemplatedNotificationV1Admin(this,
                    body,
                    namespace_
                );

                op.SetBaseFields<SendUsersTemplatedNotificationV1AdminBuilder>(this);
                return op;
            }

            public void Execute(
                ModelNotificationWithTemplateRequestV1 body,
                string namespace_
            )
            {
                SendUsersTemplatedNotificationV1Admin op = Build(
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
        }

        private SendUsersTemplatedNotificationV1Admin(SendUsersTemplatedNotificationV1AdminBuilder builder,
            ModelNotificationWithTemplateRequestV1 body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public SendUsersTemplatedNotificationV1Admin(
            string namespace_,
            Model.ModelNotificationWithTemplateRequestV1 body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/lobby/v1/admin/notification/namespaces/{namespace}/templates/notify";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)202)
            {
                return;
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}