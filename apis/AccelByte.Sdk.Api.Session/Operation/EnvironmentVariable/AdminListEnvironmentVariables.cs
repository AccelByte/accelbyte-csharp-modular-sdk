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

using AccelByte.Sdk.Api.Session.Model;

namespace AccelByte.Sdk.Api.Session.Operation
{
    /// <summary>
    /// adminListEnvironmentVariables
    ///
    /// List of environment variables.
    /// </summary>
    public class AdminListEnvironmentVariables : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminListEnvironmentVariablesBuilder Builder { get => new AdminListEnvironmentVariablesBuilder(); }

        public class AdminListEnvironmentVariablesBuilder
            : OperationBuilder<AdminListEnvironmentVariablesBuilder>
        {





            internal AdminListEnvironmentVariablesBuilder() { }

            internal AdminListEnvironmentVariablesBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminListEnvironmentVariables Build(
            )
            {
                AdminListEnvironmentVariables op = new AdminListEnvironmentVariables(this
                );

                op.SetBaseFields<AdminListEnvironmentVariablesBuilder>(this);
                return op;
            }

            public AdminListEnvironmentVariables.Response Execute(
            )
            {
                AdminListEnvironmentVariables op = Build(
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<AdminListEnvironmentVariables.Response> ExecuteAsync(
            )
            {
                AdminListEnvironmentVariables op = Build(
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

        private AdminListEnvironmentVariables(AdminListEnvironmentVariablesBuilder builder
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ApimodelsEnvironmentVariableListResponse>
        {

            public ResponseError? Error401 { get; set; } = null;

            public ResponseError? Error403 { get; set; } = null;


            protected override string GetFullOperationId() => "Session::EnvironmentVariable::AdminListEnvironmentVariables";
        }

        #endregion

        public AdminListEnvironmentVariables(
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/admin/environment-variables";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public AdminListEnvironmentVariables.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminListEnvironmentVariables.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ApimodelsEnvironmentVariableListResponse>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }

            return response;
        }
    }

}