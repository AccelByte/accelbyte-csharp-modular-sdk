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

using AccelByte.Sdk.Api.Match2.Model;

namespace AccelByte.Sdk.Api.Match2.Operation
{
    /// <summary>
    /// EnvironmentVariableList
    ///
    /// List environment variables.
    /// </summary>
    public class EnvironmentVariableList : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static EnvironmentVariableListBuilder Builder { get => new EnvironmentVariableListBuilder(); }

        public class EnvironmentVariableListBuilder
            : OperationBuilder<EnvironmentVariableListBuilder>
        {





            internal EnvironmentVariableListBuilder() { }

            internal EnvironmentVariableListBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public EnvironmentVariableList Build(
            )
            {
                EnvironmentVariableList op = new EnvironmentVariableList(this
                );

                op.SetBaseFields<EnvironmentVariableListBuilder>(this);
                return op;
            }

            public EnvironmentVariableList.Response Execute(
            )
            {
                EnvironmentVariableList op = Build(
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<EnvironmentVariableList.Response> ExecuteAsync(
            )
            {
                EnvironmentVariableList op = Build(
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

        private EnvironmentVariableList(EnvironmentVariableListBuilder builder
        )
        {
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ApiListEnvironmentVariablesResponse>
        {

            public ResponseError? Error401 { get; set; } = null;

            public ResponseError? Error403 { get; set; } = null;


            protected override string GetFullOperationId() => "Match2::EnvironmentVariables::EnvironmentVariableList";
        }

        #endregion

        public EnvironmentVariableList(
        )
        {
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/match2/v1/environment-variables";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public EnvironmentVariableList.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new EnvironmentVariableList.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ApiListEnvironmentVariablesResponse>(payload, ResponseJsonOptions);
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