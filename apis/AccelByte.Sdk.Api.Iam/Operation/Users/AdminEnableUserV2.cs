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
    /// AdminEnableUserV2
    ///
    /// ## The endpoint is going to be deprecated
    /// **Endpoint migration guide**
    /// - **Substitute endpoint: _/iam/v3/admin/namespaces/{namespace}/users/{userId}/status [PATCH]_**
    /// </summary>
    [Obsolete(DiagnosticId ="ab_deprecated_operation")]
    public class AdminEnableUserV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminEnableUserV2Builder Builder { get => new AdminEnableUserV2Builder(); }

        public class AdminEnableUserV2Builder
            : OperationBuilder<AdminEnableUserV2Builder>
        {





            internal AdminEnableUserV2Builder() { }

            internal AdminEnableUserV2Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminEnableUserV2 Build(
                string namespace_,
                string userId
            )
            {
                AdminEnableUserV2 op = new AdminEnableUserV2(this,
                    namespace_,                    
                    userId                    
                );

                op.SetBaseFields<AdminEnableUserV2Builder>(this);
                return op;
            }

            [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
            public AdminEnableUserV2.Response Execute(
                string namespace_,
                string userId
            )
            {
                AdminEnableUserV2 op = Build(
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
            public async Task<AdminEnableUserV2.Response> ExecuteAsync(
                string namespace_,
                string userId
            )
            {
                AdminEnableUserV2 op = Build(
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

        private AdminEnableUserV2(AdminEnableUserV2Builder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {

            public RestErrorResponse? Error401 { get; set; } = null;

            public RestErrorResponse? Error403 { get; set; } = null;

            public string Error404 { get; set; } = "";

            public string Error500 { get; set; } = "";


            protected override string GetFullOperationId() => "Iam::Users::AdminEnableUserV2";
        }

        #endregion

        public AdminEnableUserV2(
            string namespace_,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v2/admin/namespaces/{namespace}/users/{userId}/enable";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "*/*" };

        public override List<string> Produces => new() { "application/json" };
        
        public AdminEnableUserV2.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminEnableUserV2.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };

            if (code == (HttpStatusCode)401)
            
            {
                response.Error401 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            
            {
                response.Error403 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)
            
            {
                response.Error404 = payload.ReadToString();
                response.Error = new ApiError("-1", response.Error404!);
            }
            else if (code == (HttpStatusCode)500)
            
            {
                response.Error500 = payload.ReadToString();
                response.Error = new ApiError("-1", response.Error500!);
            }

            return response;
        }
    }

}