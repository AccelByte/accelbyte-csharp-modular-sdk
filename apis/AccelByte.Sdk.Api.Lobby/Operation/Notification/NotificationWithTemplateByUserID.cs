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
    /// notificationWithTemplateByUserID
    ///
    /// Sends notification to a user with predefined template.
    /// 
    /// In the request body, specify which template slug (template identifier) to use and the template language.
    /// 
    /// NotificationTemplate context is the key-value pair defining the value of each handlebar specified in the template content.
    /// Template need to be published before it can be use to send notifications
    /// </summary>
    public class NotificationWithTemplateByUserID : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static NotificationWithTemplateByUserIDBuilder Builder { get => new NotificationWithTemplateByUserIDBuilder(); }

        public class NotificationWithTemplateByUserIDBuilder
            : OperationBuilder<NotificationWithTemplateByUserIDBuilder>
        {





            internal NotificationWithTemplateByUserIDBuilder() { }

            internal NotificationWithTemplateByUserIDBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public NotificationWithTemplateByUserID Build(
                ModelNotificationWithTemplateRequest body,
                string namespace_,
                string userId
            )
            {
                NotificationWithTemplateByUserID op = new NotificationWithTemplateByUserID(this,
                    body,
                    namespace_,
                    userId
                );

                op.SetBaseFields<NotificationWithTemplateByUserIDBuilder>(this);
                return op;
            }

            public void Execute(
                ModelNotificationWithTemplateRequest body,
                string namespace_,
                string userId
            )
            {
                NotificationWithTemplateByUserID op = Build(
                    body,
                    namespace_,
                    userId
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
                ModelNotificationWithTemplateRequest body,
                string namespace_,
                string userId
            )
            {
                NotificationWithTemplateByUserID op = Build(
                    body,
                    namespace_,
                    userId
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

        private NotificationWithTemplateByUserID(NotificationWithTemplateByUserIDBuilder builder,
            ModelNotificationWithTemplateRequest body,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public NotificationWithTemplateByUserID(
            string namespace_,
            string userId,
            Model.ModelNotificationWithTemplateRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/notification/namespaces/{namespace}/users/{userId}/templated";

        public override HttpMethod Method => HttpMethod.Post;

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