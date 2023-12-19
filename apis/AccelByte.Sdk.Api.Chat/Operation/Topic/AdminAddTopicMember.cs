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

using AccelByte.Sdk.Api.Chat.Model;

namespace AccelByte.Sdk.Api.Chat.Operation
{
    /// <summary>
    /// adminAddTopicMember
    ///
    /// Add new member for topic in a namespace.
    /// </summary>
    public class AdminAddTopicMember : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminAddTopicMemberBuilder Builder { get => new AdminAddTopicMemberBuilder(); }

        public class AdminAddTopicMemberBuilder
            : OperationBuilder<AdminAddTopicMemberBuilder>
        {





            internal AdminAddTopicMemberBuilder() { }

            internal AdminAddTopicMemberBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminAddTopicMember Build(
                ApiAddMemberParams body,
                string namespace_,
                string topic,
                string userId
            )
            {
                AdminAddTopicMember op = new AdminAddTopicMember(this,
                    body,
                    namespace_,
                    topic,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.MessageActionAddUserToTopicResult? Execute(
                ApiAddMemberParams body,
                string namespace_,
                string topic,
                string userId
            )
            {
                AdminAddTopicMember op = Build(
                    body,
                    namespace_,
                    topic,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private AdminAddTopicMember(AdminAddTopicMemberBuilder builder,
            ApiAddMemberParams body,
            string namespace_,
            string topic,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["topic"] = topic;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminAddTopicMember(
            string namespace_,
            string topic,
            string userId,
            Model.ApiAddMemberParams body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["topic"] = topic;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/chat/admin/namespaces/{namespace}/topic/{topic}/user/{userId}";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.MessageActionAddUserToTopicResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.MessageActionAddUserToTopicResult>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.MessageActionAddUserToTopicResult>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}