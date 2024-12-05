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
    /// adminUpdateGlobalConfig
    ///
    /// Upsert global configuration data.
    /// </summary>
    public class AdminUpdateGlobalConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpdateGlobalConfigBuilder Builder { get => new AdminUpdateGlobalConfigBuilder(); }

        public class AdminUpdateGlobalConfigBuilder
            : OperationBuilder<AdminUpdateGlobalConfigBuilder>
        {





            internal AdminUpdateGlobalConfigBuilder() { }

            internal AdminUpdateGlobalConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminUpdateGlobalConfig Build(
                ModelPutGlobalConfigurationRequest body
            )
            {
                AdminUpdateGlobalConfig op = new AdminUpdateGlobalConfig(this,
                    body
                );

                op.SetBaseFields<AdminUpdateGlobalConfigBuilder>(this);
                return op;
            }

            public AdminUpdateGlobalConfig.Response Execute(
                ModelPutGlobalConfigurationRequest body
            )
            {
                AdminUpdateGlobalConfig op = Build(
                    body
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<AdminUpdateGlobalConfig.Response> ExecuteAsync(
                ModelPutGlobalConfigurationRequest body
            )
            {
                AdminUpdateGlobalConfig op = Build(
                    body
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

        private AdminUpdateGlobalConfig(AdminUpdateGlobalConfigBuilder builder,
            ModelPutGlobalConfigurationRequest body
        )
        {





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelGlobalConfiguration>
        {

            public RestapiErrorResponseBody? Error401 { get; set; } = null;

            public RestapiErrorResponseBody? Error403 { get; set; } = null;


            protected override string GetFullOperationId() => "Lobby::Admin::AdminUpdateGlobalConfig";
        }

        #endregion

        public AdminUpdateGlobalConfig(
            Model.ModelPutGlobalConfigurationRequest body
        )
        {





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/lobby/v1/admin/global-configurations";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public AdminUpdateGlobalConfig.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminUpdateGlobalConfig.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelGlobalConfiguration>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
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

            return response;
        }
    }

}