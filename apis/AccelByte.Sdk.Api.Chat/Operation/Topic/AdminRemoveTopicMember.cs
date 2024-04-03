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

using AccelByte.Sdk.Api.Chat.Model;

namespace AccelByte.Sdk.Api.Chat.Operation
{
    /// <summary>
    /// adminRemoveTopicMember
    ///
    /// Remove member from topic in a namespace.
    /// </summary>
    public class AdminRemoveTopicMember : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminRemoveTopicMemberBuilder Builder { get => new AdminRemoveTopicMemberBuilder(); }

        public class AdminRemoveTopicMemberBuilder
            : OperationBuilder<AdminRemoveTopicMemberBuilder>
        {





            internal AdminRemoveTopicMemberBuilder() { }

            internal AdminRemoveTopicMemberBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminRemoveTopicMember Build(
                string namespace_,
                string topic,
                string userId
            )
            {
                AdminRemoveTopicMember op = new AdminRemoveTopicMember(this,
                    namespace_,
                    topic,
                    userId
                );

                op.SetBaseFields<AdminRemoveTopicMemberBuilder>(this);
                return op;
            }

            public Model.MessageActionAddUserToTopicResult? Execute(
                string namespace_,
                string topic,
                string userId
            )
            {
                AdminRemoveTopicMember op = Build(
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
            public async Task<Model.MessageActionAddUserToTopicResult?> ExecuteAsync(
                string namespace_,
                string topic,
                string userId
            )
            {
                AdminRemoveTopicMember op = Build(
                    namespace_,
                    topic,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private AdminRemoveTopicMember(AdminRemoveTopicMemberBuilder builder,
            string namespace_,
            string topic,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["topic"] = topic;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminRemoveTopicMember(
            string namespace_,
            string topic,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["topic"] = topic;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/chat/admin/namespaces/{namespace}/topic/{topic}/user/{userId}";

        public override HttpMethod Method => HttpMethod.Delete;

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