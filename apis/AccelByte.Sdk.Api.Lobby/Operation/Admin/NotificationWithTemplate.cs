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
    /// notificationWithTemplate
    ///
    /// Required permission : `NAMESPACE:{namespace}:NOTIFICATION [CREATE]` with scope `social`
    /// 
    /// Sends notification to all connected users in a namespace with predefined template.
    /// 
    /// In the request body, specify which template slug (template identifier) to use and the template language.
    /// 
    /// NotificationTemplate context is the key-value pair defining the value of each handlebar specified in the template content.
    /// Template need to be published before it can be use to send notifications
    /// </summary>
    public class NotificationWithTemplate : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static NotificationWithTemplateBuilder Builder { get => new NotificationWithTemplateBuilder(); }

        public class NotificationWithTemplateBuilder
            : OperationBuilder<NotificationWithTemplateBuilder>
        {





            internal NotificationWithTemplateBuilder() { }

            internal NotificationWithTemplateBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public NotificationWithTemplate Build(
                ModelNotificationWithTemplateRequest body,
                string namespace_
            )
            {
                NotificationWithTemplate op = new NotificationWithTemplate(this,
                    body,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public void Execute(
                ModelNotificationWithTemplateRequest body,
                string namespace_
            )
            {
                NotificationWithTemplate op = Build(
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

        private NotificationWithTemplate(NotificationWithTemplateBuilder builder,
            ModelNotificationWithTemplateRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public NotificationWithTemplate(
            string namespace_,
            Model.ModelNotificationWithTemplateRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/notification/namespaces/{namespace}/templated";

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