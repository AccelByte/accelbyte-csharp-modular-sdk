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
    /// AdminDeleteClientPermissionV3
    ///
    /// **Note for Multi Tenant Mode:**
    /// This is for super admin only.
    /// action code : 10304
    /// </summary>
    public class AdminDeleteClientPermissionV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDeleteClientPermissionV3Builder Builder { get => new AdminDeleteClientPermissionV3Builder(); }

        public class AdminDeleteClientPermissionV3Builder
            : OperationBuilder<AdminDeleteClientPermissionV3Builder>
        {





            internal AdminDeleteClientPermissionV3Builder() { }

            internal AdminDeleteClientPermissionV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminDeleteClientPermissionV3 Build(
                long action,
                string clientId,
                string namespace_,
                string resource
            )
            {
                AdminDeleteClientPermissionV3 op = new AdminDeleteClientPermissionV3(this,
                    action,                    
                    clientId,                    
                    namespace_,                    
                    resource                    
                );

                op.SetBaseFields<AdminDeleteClientPermissionV3Builder>(this);
                return op;
            }

            public AdminDeleteClientPermissionV3.Response Execute(
                long action,
                string clientId,
                string namespace_,
                string resource
            )
            {
                AdminDeleteClientPermissionV3 op = Build(
                    action,
                    clientId,
                    namespace_,
                    resource
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<AdminDeleteClientPermissionV3.Response> ExecuteAsync(
                long action,
                string clientId,
                string namespace_,
                string resource
            )
            {
                AdminDeleteClientPermissionV3 op = Build(
                    action,
                    clientId,
                    namespace_,
                    resource
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

        private AdminDeleteClientPermissionV3(AdminDeleteClientPermissionV3Builder builder,
            long action,
            string clientId,
            string namespace_,
            string resource
        )
        {
            PathParams["action"] = Convert.ToString(action);
            PathParams["clientId"] = clientId;
            PathParams["namespace"] = namespace_;
            PathParams["resource"] = resource;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {

            public RestErrorResponse? Error400 { get; set; } = null;

            public RestErrorResponse? Error401 { get; set; } = null;

            public RestErrorResponse? Error403 { get; set; } = null;

            public RestErrorResponse? Error404 { get; set; } = null;


            protected override string GetFullOperationId() => "Iam::Clients::AdminDeleteClientPermissionV3";
        }

        #endregion

        public AdminDeleteClientPermissionV3(
            long action,            
            string clientId,            
            string namespace_,            
            string resource            
        )
        {
            PathParams["action"] = Convert.ToString(action);
            PathParams["clientId"] = clientId;
            PathParams["namespace"] = namespace_;
            PathParams["resource"] = resource;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/clients/{clientId}/permissions/{resource}/{action}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public AdminDeleteClientPermissionV3.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminDeleteClientPermissionV3.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };

            if (code == (HttpStatusCode)400)
            
            {
                response.Error400 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            
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
                response.Error404 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }

            return response;
        }
    }

}