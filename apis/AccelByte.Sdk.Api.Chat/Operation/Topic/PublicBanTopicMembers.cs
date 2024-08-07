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
    /// publicBanTopicMembers
    ///
    /// Ban topic members in a group topic.
    /// </summary>
    public class PublicBanTopicMembers : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicBanTopicMembersBuilder Builder { get => new PublicBanTopicMembersBuilder(); }

        public class PublicBanTopicMembersBuilder
            : OperationBuilder<PublicBanTopicMembersBuilder>
        {





            internal PublicBanTopicMembersBuilder() { }

            internal PublicBanTopicMembersBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicBanTopicMembers Build(
                ModelsPublicBanTopicMembersRequest body,
                string namespace_,
                string topic
            )
            {
                PublicBanTopicMembers op = new PublicBanTopicMembers(this,
                    body,
                    namespace_,
                    topic
                );

                op.SetBaseFields<PublicBanTopicMembersBuilder>(this);
                return op;
            }

            public Model.ModelsPublicBanTopicMembersResponse? Execute(
                ModelsPublicBanTopicMembersRequest body,
                string namespace_,
                string topic
            )
            {
                PublicBanTopicMembers op = Build(
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
            public async Task<Model.ModelsPublicBanTopicMembersResponse?> ExecuteAsync(
                ModelsPublicBanTopicMembersRequest body,
                string namespace_,
                string topic
            )
            {
                PublicBanTopicMembers op = Build(
                    body,
                    namespace_,
                    topic
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

        private PublicBanTopicMembers(PublicBanTopicMembersBuilder builder,
            ModelsPublicBanTopicMembersRequest body,
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

        public PublicBanTopicMembers(
            string namespace_,
            string topic,
            Model.ModelsPublicBanTopicMembersRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["topic"] = topic;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/chat/public/namespaces/{namespace}/topic/{topic}/ban-members";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsPublicBanTopicMembersResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsPublicBanTopicMembersResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsPublicBanTopicMembersResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}