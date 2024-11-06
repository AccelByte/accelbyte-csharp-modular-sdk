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
    /// adminListGlobalConfiguration
    ///
    /// Record of global configuration data.
    /// </summary>
    public class AdminListGlobalConfiguration : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminListGlobalConfigurationBuilder Builder { get => new AdminListGlobalConfigurationBuilder(); }

        public class AdminListGlobalConfigurationBuilder
            : OperationBuilder<AdminListGlobalConfigurationBuilder>
        {





            internal AdminListGlobalConfigurationBuilder() { }

            internal AdminListGlobalConfigurationBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminListGlobalConfiguration Build(
            )
            {
                AdminListGlobalConfiguration op = new AdminListGlobalConfiguration(this
                );

                op.SetBaseFields<AdminListGlobalConfigurationBuilder>(this);
                return op;
            }

            public AdminListGlobalConfiguration.Response Execute(
            )
            {
                AdminListGlobalConfiguration op = Build(
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<AdminListGlobalConfiguration.Response> ExecuteAsync(
            )
            {
                AdminListGlobalConfiguration op = Build(
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

        private AdminListGlobalConfiguration(AdminListGlobalConfigurationBuilder builder
        )
        {
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ApimodelsGlobalConfigurationResponse>
        {

            public ResponseError? Error401 { get; set; } = null;

            public ResponseError? Error403 { get; set; } = null;


            protected override string GetFullOperationId() => "Session::GlobalConfiguration::AdminListGlobalConfiguration";
        }

        #endregion

        public AdminListGlobalConfiguration(
        )
        {
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/admin/global-configurations";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public AdminListGlobalConfiguration.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminListGlobalConfiguration.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ApimodelsGlobalConfigurationResponse>(payload, ResponseJsonOptions);
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