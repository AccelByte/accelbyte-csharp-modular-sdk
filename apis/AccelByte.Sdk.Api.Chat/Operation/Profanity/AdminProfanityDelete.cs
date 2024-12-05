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
    /// adminProfanityDelete
    ///
    /// Delete profanity words.
    /// </summary>
    public class AdminProfanityDelete : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminProfanityDeleteBuilder Builder { get => new AdminProfanityDeleteBuilder(); }

        public class AdminProfanityDeleteBuilder
            : OperationBuilder<AdminProfanityDeleteBuilder>
        {





            internal AdminProfanityDeleteBuilder() { }

            internal AdminProfanityDeleteBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminProfanityDelete Build(
                string id,
                string namespace_
            )
            {
                AdminProfanityDelete op = new AdminProfanityDelete(this,
                    id,
                    namespace_
                );

                op.SetBaseFields<AdminProfanityDeleteBuilder>(this);
                return op;
            }

            public AdminProfanityDelete.Response Execute(
                string id,
                string namespace_
            )
            {
                AdminProfanityDelete op = Build(
                    id,
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
            public async Task<AdminProfanityDelete.Response> ExecuteAsync(
                string id,
                string namespace_
            )
            {
                AdminProfanityDelete op = Build(
                    id,
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
        }

        private AdminProfanityDelete(AdminProfanityDeleteBuilder builder,
            string id,
            string namespace_
        )
        {
            PathParams["id"] = id;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {

            public RestapiErrorResponseBody? Error400 { get; set; } = null;

            public RestapiErrorResponseBody? Error401 { get; set; } = null;

            public RestapiErrorResponseBody? Error403 { get; set; } = null;

            public RestapiErrorResponseBody? Error404 { get; set; } = null;

            public RestapiErrorResponseBody? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Chat::Profanity::AdminProfanityDelete";
        }

        #endregion

        public AdminProfanityDelete(
            string id,
            string namespace_
        )
        {
            PathParams["id"] = id;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/chat/v1/admin/profanity/namespaces/{namespace}/dictionary/{id}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public AdminProfanityDelete.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminProfanityDelete.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };

            if (code == (HttpStatusCode)400)

            {
                response.Error400 = JsonSerializer.Deserialize<RestapiErrorResponseBody>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)

            {
                response.Error401 = JsonSerializer.Deserialize<RestapiErrorResponseBody>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)

            {
                response.Error403 = JsonSerializer.Deserialize<RestapiErrorResponseBody>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)

            {
                response.Error404 = JsonSerializer.Deserialize<RestapiErrorResponseBody>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)

            {
                response.Error500 = JsonSerializer.Deserialize<RestapiErrorResponseBody>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}