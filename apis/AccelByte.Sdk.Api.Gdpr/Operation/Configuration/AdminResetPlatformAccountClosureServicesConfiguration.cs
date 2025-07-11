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

using AccelByte.Sdk.Api.Gdpr.Model;

namespace AccelByte.Sdk.Api.Gdpr.Operation
{
    /// <summary>
    /// AdminResetPlatformAccountClosureServicesConfiguration
    ///
    /// **[TEST FACILITY ONLY]**
    /// Reset registered platform account closure services configuration to use the default configuration.
    /// Scope: account
    /// </summary>
    public class AdminResetPlatformAccountClosureServicesConfiguration : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminResetPlatformAccountClosureServicesConfigurationBuilder Builder { get => new AdminResetPlatformAccountClosureServicesConfigurationBuilder(); }

        public class AdminResetPlatformAccountClosureServicesConfigurationBuilder
            : OperationBuilder<AdminResetPlatformAccountClosureServicesConfigurationBuilder>
        {





            internal AdminResetPlatformAccountClosureServicesConfigurationBuilder() { }

            internal AdminResetPlatformAccountClosureServicesConfigurationBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminResetPlatformAccountClosureServicesConfiguration Build(
                string namespace_
            )
            {
                AdminResetPlatformAccountClosureServicesConfiguration op = new AdminResetPlatformAccountClosureServicesConfiguration(this,
                    namespace_                    
                );

                op.SetBaseFields<AdminResetPlatformAccountClosureServicesConfigurationBuilder>(this);
                return op;
            }

            public AdminResetPlatformAccountClosureServicesConfiguration.Response Execute(
                string namespace_
            )
            {
                AdminResetPlatformAccountClosureServicesConfiguration op = Build(
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
            public async Task<AdminResetPlatformAccountClosureServicesConfiguration.Response> ExecuteAsync(
                string namespace_
            )
            {
                AdminResetPlatformAccountClosureServicesConfiguration op = Build(
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

        private AdminResetPlatformAccountClosureServicesConfiguration(AdminResetPlatformAccountClosureServicesConfigurationBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {

            public ResponseError? Error401 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Gdpr::Configuration::AdminResetPlatformAccountClosureServicesConfiguration";
        }

        #endregion

        public AdminResetPlatformAccountClosureServicesConfiguration(
            string namespace_            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/gdpr/admin/namespaces/{namespace}/services/platforms/closure/config";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public AdminResetPlatformAccountClosureServicesConfiguration.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminResetPlatformAccountClosureServicesConfiguration.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };

            if (code == (HttpStatusCode)401)
            
            {
                response.Error401 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            
            {
                response.Error500 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}