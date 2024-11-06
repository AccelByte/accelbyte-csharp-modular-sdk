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
    /// AdminDeleteRolePermissionsV3
    /// </summary>
    public class AdminDeleteRolePermissionsV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDeleteRolePermissionsV3Builder Builder { get => new AdminDeleteRolePermissionsV3Builder(); }

        public class AdminDeleteRolePermissionsV3Builder
            : OperationBuilder<AdminDeleteRolePermissionsV3Builder>
        {





            internal AdminDeleteRolePermissionsV3Builder() { }

            internal AdminDeleteRolePermissionsV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminDeleteRolePermissionsV3 Build(
                List<string> body,
                string roleId
            )
            {
                AdminDeleteRolePermissionsV3 op = new AdminDeleteRolePermissionsV3(this,
                    body,                    
                    roleId                    
                );

                op.SetBaseFields<AdminDeleteRolePermissionsV3Builder>(this);
                return op;
            }

            public AdminDeleteRolePermissionsV3.Response Execute(
                List<string> body,
                string roleId
            )
            {
                AdminDeleteRolePermissionsV3 op = Build(
                    body,
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
            public async Task<AdminDeleteRolePermissionsV3.Response> ExecuteAsync(
                List<string> body,
                string roleId
            )
            {
                AdminDeleteRolePermissionsV3 op = Build(
                    body,
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

        private AdminDeleteRolePermissionsV3(AdminDeleteRolePermissionsV3Builder builder,
            List<string> body,
            string roleId
        )
        {
            PathParams["roleId"] = roleId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {

            public RestErrorResponse? Error401 { get; set; } = null;

            public RestErrorResponse? Error403 { get; set; } = null;

            public string Error404 { get; set; } = "";


            protected override string GetFullOperationId() => "Iam::Roles::AdminDeleteRolePermissionsV3";
        }

        #endregion

        public AdminDeleteRolePermissionsV3(
            string roleId,            
            List<string> body            
        )
        {
            PathParams["roleId"] = roleId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/roles/{roleId}/permissions";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public AdminDeleteRolePermissionsV3.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminDeleteRolePermissionsV3.Response()
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

            return response;
        }
    }

}