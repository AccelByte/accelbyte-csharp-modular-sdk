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

using AccelByte.Sdk.Api.Csm.Model;

namespace AccelByte.Sdk.Api.Csm.Operation
{
    /// <summary>
    /// SaveSecretV1
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:EXTEND:SECRET [CREATE]`
    /// 
    /// Save an environment secret.
    /// Request body:
    /// - configName : environment secret name - Required.
    /// - source : source of the configuration value (plaintext or ssm) - Required.
    /// - value : configuration value - Required.
    /// - description : description of the configuration - Optional.
    /// - applyMask : mask the value in the Helm manifest for sensitive information (true or false) - Optional.
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class SaveSecretV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SaveSecretV1Builder Builder { get => new SaveSecretV1Builder(); }

        public class SaveSecretV1Builder
            : OperationBuilder<SaveSecretV1Builder>
        {





            internal SaveSecretV1Builder() { }

            internal SaveSecretV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public SaveSecretV1 Build(
                GeneratedSaveConfigurationV1Request body,
                string app,
                string namespace_
            )
            {
                SaveSecretV1 op = new SaveSecretV1(this,
                    body,
                    app,
                    namespace_
                );

                op.SetBaseFields<SaveSecretV1Builder>(this);
                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public SaveSecretV1.Response Execute(
                GeneratedSaveConfigurationV1Request body,
                string app,
                string namespace_
            )
            {
                SaveSecretV1 op = Build(
                    body,
                    app,
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
            public async Task<SaveSecretV1.Response> ExecuteAsync(
                GeneratedSaveConfigurationV1Request body,
                string app,
                string namespace_
            )
            {
                SaveSecretV1 op = Build(
                    body,
                    app,
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

        private SaveSecretV1(SaveSecretV1Builder builder,
            GeneratedSaveConfigurationV1Request body,
            string app,
            string namespace_
        )
        {
            PathParams["app"] = app;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.GeneratedSaveConfigurationV1Response>
        {

            public ResponseErrorResponse? Error400 { get; set; } = null;

            public ResponseErrorResponse? Error401 { get; set; } = null;

            public ResponseErrorResponse? Error403 { get; set; } = null;

            public ResponseErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Csm::Configuration::SaveSecretV1";
        }

        #endregion

        public SaveSecretV1(
            string app,
            string namespace_,
            Model.GeneratedSaveConfigurationV1Request body
        )
        {
            PathParams["app"] = app;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/csm/v1/admin/namespaces/{namespace}/apps/{app}/secrets";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public SaveSecretV1.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new SaveSecretV1.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.GeneratedSaveConfigurationV1Response>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}