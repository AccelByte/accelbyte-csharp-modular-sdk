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

using AccelByte.Sdk.Api.Iam.Model;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// AdminGetConfigValueV3
    ///
    /// This endpoint return the value of config key. The namespace should be publisher namespace or studio namespace.
    /// 
    /// **Supported config key:**
    /// * uniqueDisplayNameEnabled
    /// * usernameDisabled
    /// * mandatoryEmailVerificationEnabled
    /// </summary>
    public class AdminGetConfigValueV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetConfigValueV3Builder Builder { get => new AdminGetConfigValueV3Builder(); }

        public class AdminGetConfigValueV3Builder
            : OperationBuilder<AdminGetConfigValueV3Builder>
        {





            internal AdminGetConfigValueV3Builder() { }

            internal AdminGetConfigValueV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminGetConfigValueV3 Build(
                string configKey,
                string namespace_
            )
            {
                AdminGetConfigValueV3 op = new AdminGetConfigValueV3(this,
                    configKey,                    
                    namespace_                    
                );

                op.SetBaseFields<AdminGetConfigValueV3Builder>(this);
                return op;
            }

            public AdminGetConfigValueV3.Response Execute(
                string configKey,
                string namespace_
            )
            {
                AdminGetConfigValueV3 op = Build(
                    configKey,
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
            public async Task<AdminGetConfigValueV3.Response> ExecuteAsync(
                string configKey,
                string namespace_
            )
            {
                AdminGetConfigValueV3 op = Build(
                    configKey,
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

            public AdminGetConfigValueV3.Response<T1> Execute<T1>(
                string configKey,
                string namespace_
            )
            {
                AdminGetConfigValueV3 op = Build(
                    configKey,
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse<T1>(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<AdminGetConfigValueV3.Response<T1>> ExecuteAsync<T1>(
                string configKey,
                string namespace_
            )
            {
                AdminGetConfigValueV3 op = Build(
                    configKey,
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse<T1>(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
        }

        private AdminGetConfigValueV3(AdminGetConfigValueV3Builder builder,
            string configKey,
            string namespace_
        )
        {
            PathParams["configKey"] = configKey;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelConfigValueResponseV3>
        {

            public RestErrorResponse? Error400 { get; set; } = null;

            public RestErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Iam::Config::AdminGetConfigValueV3";
        }

        public class Response<T1> : ApiResponse<Model.ModelConfigValueResponseV3<T1>>
        {
            public RestErrorResponse? Error400 { get; set; } = null;

            public RestErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Iam::Config::AdminGetConfigValueV3";
        }
        #endregion

        public AdminGetConfigValueV3(
            string configKey,            
            string namespace_            
        )
        {
            PathParams["configKey"] = configKey;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/config/{configKey}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public AdminGetConfigValueV3.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminGetConfigValueV3.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelConfigValueResponseV3>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }

        public AdminGetConfigValueV3.Response<T1> ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminGetConfigValueV3.Response<T1>()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelConfigValueResponseV3<T1>>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }
            
            return response;
        }
    }

}