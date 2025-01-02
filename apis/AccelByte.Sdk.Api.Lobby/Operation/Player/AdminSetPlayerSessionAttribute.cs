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
    /// adminSetPlayerSessionAttribute
    ///
    /// Set player's session attribute by user id in a namespace.
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class AdminSetPlayerSessionAttribute : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminSetPlayerSessionAttributeBuilder Builder { get => new AdminSetPlayerSessionAttributeBuilder(); }

        public class AdminSetPlayerSessionAttributeBuilder
            : OperationBuilder<AdminSetPlayerSessionAttributeBuilder>
        {





            internal AdminSetPlayerSessionAttributeBuilder() { }

            internal AdminSetPlayerSessionAttributeBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminSetPlayerSessionAttribute Build(
                ModelsSetPlayerSessionAttributeRequest body,
                string namespace_,
                string userId
            )
            {
                AdminSetPlayerSessionAttribute op = new AdminSetPlayerSessionAttribute(this,
                    body,
                    namespace_,
                    userId
                );

                op.SetBaseFields<AdminSetPlayerSessionAttributeBuilder>(this);
                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public AdminSetPlayerSessionAttribute.Response Execute(
                ModelsSetPlayerSessionAttributeRequest body,
                string namespace_,
                string userId
            )
            {
                AdminSetPlayerSessionAttribute op = Build(
                    body,
                    namespace_,
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
            public async Task<AdminSetPlayerSessionAttribute.Response> ExecuteAsync(
                ModelsSetPlayerSessionAttributeRequest body,
                string namespace_,
                string userId
            )
            {
                AdminSetPlayerSessionAttribute op = Build(
                    body,
                    namespace_,
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

        private AdminSetPlayerSessionAttribute(AdminSetPlayerSessionAttributeBuilder builder,
            ModelsSetPlayerSessionAttributeRequest body,
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

        #region Response Part        
        public class Response : ApiResponse
        {

            public RestapiErrorResponseBody? Error400 { get; set; } = null;

            public RestapiErrorResponseBody? Error401 { get; set; } = null;

            public RestapiErrorResponseBody? Error403 { get; set; } = null;

            public RestapiErrorResponseBody? Error404 { get; set; } = null;

            public RestapiErrorResponseBody? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Lobby::Player::AdminSetPlayerSessionAttribute";
        }

        #endregion

        public AdminSetPlayerSessionAttribute(
            string namespace_,
            string userId,
            Model.ModelsSetPlayerSessionAttributeRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/lobby/v1/admin/player/namespaces/{namespace}/users/{userId}/attributes";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public AdminSetPlayerSessionAttribute.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminSetPlayerSessionAttribute.Response()
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