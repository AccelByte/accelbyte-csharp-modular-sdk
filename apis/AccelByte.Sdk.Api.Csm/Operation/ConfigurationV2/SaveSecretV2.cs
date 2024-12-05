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
    /// SaveSecretV2
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
    public class SaveSecretV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SaveSecretV2Builder Builder { get => new SaveSecretV2Builder(); }

        public class SaveSecretV2Builder
            : OperationBuilder<SaveSecretV2Builder>
        {





            internal SaveSecretV2Builder() { }

            internal SaveSecretV2Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public SaveSecretV2 Build(
                ApimodelSaveConfigurationV2Request body,
                string app,
                string namespace_
            )
            {
                SaveSecretV2 op = new SaveSecretV2(this,
                    body,
                    app,
                    namespace_
                );

                op.SetBaseFields<SaveSecretV2Builder>(this);
                return op;
            }

            public SaveSecretV2.Response Execute(
                ApimodelSaveConfigurationV2Request body,
                string app,
                string namespace_
            )
            {
                SaveSecretV2 op = Build(
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
            public async Task<SaveSecretV2.Response> ExecuteAsync(
                ApimodelSaveConfigurationV2Request body,
                string app,
                string namespace_
            )
            {
                SaveSecretV2 op = Build(
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

        private SaveSecretV2(SaveSecretV2Builder builder,
            ApimodelSaveConfigurationV2Request body,
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
        public class Response : ApiResponse<Model.ApimodelSaveConfigurationV2Response>
        {

            public ResponseErrorResponse? Error400 { get; set; } = null;

            public ResponseErrorResponse? Error401 { get; set; } = null;

            public ResponseErrorResponse? Error403 { get; set; } = null;

            public ResponseErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Csm::ConfigurationV2::SaveSecretV2";
        }

        #endregion

        public SaveSecretV2(
            string app,
            string namespace_,
            Model.ApimodelSaveConfigurationV2Request body
        )
        {
            PathParams["app"] = app;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/csm/v2/admin/namespaces/{namespace}/apps/{app}/secrets";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public SaveSecretV2.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new SaveSecretV2.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ApimodelSaveConfigurationV2Response>(payload, ResponseJsonOptions);
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