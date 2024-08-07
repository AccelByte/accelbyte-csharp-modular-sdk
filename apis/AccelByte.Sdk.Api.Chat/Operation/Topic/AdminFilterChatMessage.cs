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
    /// adminFilterChatMessage
    ///
    /// For testing purpose, doesn't send any message to the topic. Always do filter regardless of enableProfanityFilter configuration.
    /// </summary>
    public class AdminFilterChatMessage : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminFilterChatMessageBuilder Builder { get => new AdminFilterChatMessageBuilder(); }

        public class AdminFilterChatMessageBuilder
            : OperationBuilder<AdminFilterChatMessageBuilder>
        {

            public bool? Detail { get; set; }





            internal AdminFilterChatMessageBuilder() { }

            internal AdminFilterChatMessageBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminFilterChatMessageBuilder SetDetail(bool _detail)
            {
                Detail = _detail;
                return this;
            }





            public AdminFilterChatMessage Build(
                ModelsMessageRequest body,
                string namespace_
            )
            {
                AdminFilterChatMessage op = new AdminFilterChatMessage(this,
                    body,
                    namespace_
                );

                op.SetBaseFields<AdminFilterChatMessageBuilder>(this);
                return op;
            }

            public Model.ModelsMessageResultWithAttributes? Execute(
                ModelsMessageRequest body,
                string namespace_
            )
            {
                AdminFilterChatMessage op = Build(
                    body,
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<Model.ModelsMessageResultWithAttributes?> ExecuteAsync(
                ModelsMessageRequest body,
                string namespace_
            )
            {
                AdminFilterChatMessage op = Build(
                    body,
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }

            public Model.ModelsMessageResultWithAttributes<T1>? Execute<T1>(
                ModelsMessageRequest body,
                string namespace_
            )
            {
                AdminFilterChatMessage op = Build(
                    body,
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<Model.ModelsMessageResultWithAttributes<T1>?> ExecuteAsync<T1>(
                ModelsMessageRequest body,
                string namespace_
            )
            {
                AdminFilterChatMessage op = Build(
                    body,
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private AdminFilterChatMessage(AdminFilterChatMessageBuilder builder,
            ModelsMessageRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Detail != null) QueryParams["detail"] = Convert.ToString(builder.Detail)!;




            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminFilterChatMessage(
            string namespace_,
            bool? detail,
            Model.ModelsMessageRequest body
        )
        {
            PathParams["namespace"] = namespace_;

            if (detail != null) QueryParams["detail"] = Convert.ToString(detail)!;




            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/chat/admin/namespaces/{namespace}/chat/filter";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsMessageResultWithAttributes? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsMessageResultWithAttributes>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsMessageResultWithAttributes>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }

        public Model.ModelsMessageResultWithAttributes<T1>? ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsMessageResultWithAttributes<T1>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsMessageResultWithAttributes<T1>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();
            throw new HttpResponseException(code, payloadString);
        }
    }

}