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
    /// AdminDeleteRolePermissionV3
    ///
    /// action code: 10406
    /// </summary>
    public class AdminDeleteRolePermissionV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDeleteRolePermissionV3Builder Builder { get => new AdminDeleteRolePermissionV3Builder(); }

        public class AdminDeleteRolePermissionV3Builder
            : OperationBuilder<AdminDeleteRolePermissionV3Builder>
        {





            internal AdminDeleteRolePermissionV3Builder() { }

            internal AdminDeleteRolePermissionV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminDeleteRolePermissionV3 Build(
                long action,
                string resource,
                string roleId
            )
            {
                AdminDeleteRolePermissionV3 op = new AdminDeleteRolePermissionV3(this,
                    action,                    
                    resource,                    
                    roleId                    
                );

                op.SetBaseFields<AdminDeleteRolePermissionV3Builder>(this);
                return op;
            }

            public AdminDeleteRolePermissionV3.Response Execute(
                long action,
                string resource,
                string roleId
            )
            {
                AdminDeleteRolePermissionV3 op = Build(
                    action,
                    resource,
                    roleId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<AdminDeleteRolePermissionV3.Response> ExecuteAsync(
                long action,
                string resource,
                string roleId
            )
            {
                AdminDeleteRolePermissionV3 op = Build(
                    action,
                    resource,
                    roleId
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

        private AdminDeleteRolePermissionV3(AdminDeleteRolePermissionV3Builder builder,
            long action,
            string resource,
            string roleId
        )
        {
            PathParams["action"] = Convert.ToString(action);
            PathParams["resource"] = resource;
            PathParams["roleId"] = roleId;
            
            

            
            
            

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

            public RestErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Iam::Roles::AdminDeleteRolePermissionV3";
        }

        #endregion

        public AdminDeleteRolePermissionV3(
            long action,            
            string resource,            
            string roleId            
        )
        {
            PathParams["action"] = Convert.ToString(action);
            PathParams["resource"] = resource;
            PathParams["roleId"] = roleId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/roles/{roleId}/permissions/{resource}/{action}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public AdminDeleteRolePermissionV3.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminDeleteRolePermissionV3.Response()
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
            else if (code == (HttpStatusCode)500)
            
            {
                response.Error500 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}