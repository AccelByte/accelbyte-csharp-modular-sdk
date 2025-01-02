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
    /// adminDebugProfanityFilters
    ///
    /// Get the list of filters that would modify the phrase
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class AdminDebugProfanityFilters : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDebugProfanityFiltersBuilder Builder { get => new AdminDebugProfanityFiltersBuilder(); }

        public class AdminDebugProfanityFiltersBuilder
            : OperationBuilder<AdminDebugProfanityFiltersBuilder>
        {





            internal AdminDebugProfanityFiltersBuilder() { }

            internal AdminDebugProfanityFiltersBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminDebugProfanityFilters Build(
                ModelsDebugProfanityFilterRequest body,
                string namespace_
            )
            {
                AdminDebugProfanityFilters op = new AdminDebugProfanityFilters(this,
                    body,
                    namespace_
                );

                op.SetBaseFields<AdminDebugProfanityFiltersBuilder>(this);
                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public AdminDebugProfanityFilters.Response Execute(
                ModelsDebugProfanityFilterRequest body,
                string namespace_
            )
            {
                AdminDebugProfanityFilters op = Build(
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
            public async Task<AdminDebugProfanityFilters.Response> ExecuteAsync(
                ModelsDebugProfanityFilterRequest body,
                string namespace_
            )
            {
                AdminDebugProfanityFilters op = Build(
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
        }

        private AdminDebugProfanityFilters(AdminDebugProfanityFiltersBuilder builder,
            ModelsDebugProfanityFilterRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<List<Model.ModelsProfanityFilter>>
        {

            public RestapiErrorResponseBody? Error400 { get; set; } = null;

            public RestapiErrorResponseBody? Error401 { get; set; } = null;

            public RestapiErrorResponseBody? Error403 { get; set; } = null;

            public RestapiErrorResponseBody? Error404 { get; set; } = null;

            public RestapiErrorResponseBody? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Lobby::Profanity::AdminDebugProfanityFilters";
        }

        #endregion

        public AdminDebugProfanityFilters(
            string namespace_,
            Model.ModelsDebugProfanityFilterRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/lobby/v1/admin/profanity/namespaces/{namespace}/filters/debug";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public AdminDebugProfanityFilters.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminDebugProfanityFilters.Response()
            {
                StatusCode = code,
                ContentType = contentType
            };

            if (code == (HttpStatusCode)204)
            {
                response.IsSuccess = true;
            }
            else if ((code == (HttpStatusCode)201) || (code == (HttpStatusCode)202) || (code == (HttpStatusCode)200))
            {
                response.Data = JsonSerializer.Deserialize<List<Model.ModelsProfanityFilter>>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
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