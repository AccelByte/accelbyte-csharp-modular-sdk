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
    /// adminUnbanTopicMembers
    ///
    /// Unban users in some topic.
    /// </summary>
    public class AdminUnbanTopicMembers : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUnbanTopicMembersBuilder Builder { get => new AdminUnbanTopicMembersBuilder(); }

        public class AdminUnbanTopicMembersBuilder
            : OperationBuilder<AdminUnbanTopicMembersBuilder>
        {





            internal AdminUnbanTopicMembersBuilder() { }

            internal AdminUnbanTopicMembersBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminUnbanTopicMembers Build(
                ModelsUnbanTopicMemberParam body,
                string namespace_,
                string topic
            )
            {
                AdminUnbanTopicMembers op = new AdminUnbanTopicMembers(this,
                    body,
                    namespace_,
                    topic
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelsUnbanTopicMemberResult? Execute(
                ModelsUnbanTopicMemberParam body,
                string namespace_,
                string topic
            )
            {
                AdminUnbanTopicMembers op = Build(
                    body,
                    namespace_,
                    topic
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

        private AdminUnbanTopicMembers(AdminUnbanTopicMembersBuilder builder,
            ModelsUnbanTopicMemberParam body,
            string namespace_,
            string topic
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["topic"] = topic;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminUnbanTopicMembers(
            string namespace_,
            string topic,
            Model.ModelsUnbanTopicMemberParam body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["topic"] = topic;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/chat/admin/namespaces/{namespace}/topic/{topic}/unban-members";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsUnbanTopicMemberResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsUnbanTopicMemberResult>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsUnbanTopicMemberResult>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}