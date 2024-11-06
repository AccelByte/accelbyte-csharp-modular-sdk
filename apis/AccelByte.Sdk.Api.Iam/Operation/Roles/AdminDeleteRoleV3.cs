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
    /// AdminDeleteRoleV3
    ///
    /// action code: 10403
    /// </summary>
    public class AdminDeleteRoleV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDeleteRoleV3Builder Builder { get => new AdminDeleteRoleV3Builder(); }

        public class AdminDeleteRoleV3Builder
            : OperationBuilder<AdminDeleteRoleV3Builder>
        {





            internal AdminDeleteRoleV3Builder() { }

            internal AdminDeleteRoleV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminDeleteRoleV3 Build(
                string roleId
            )
            {
                AdminDeleteRoleV3 op = new AdminDeleteRoleV3(this,
                    roleId                    
                );

                op.SetBaseFields<AdminDeleteRoleV3Builder>(this);
                return op;
            }

            public AdminDeleteRoleV3.Response Execute(
                string roleId
            )
            {
                AdminDeleteRoleV3 op = Build(
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
            public async Task<AdminDeleteRoleV3.Response> ExecuteAsync(
                string roleId
            )
            {
                AdminDeleteRoleV3 op = Build(
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

        private AdminDeleteRoleV3(AdminDeleteRoleV3Builder builder,
            string roleId
        )
        {
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

            public RestErrorResponse? Error409 { get; set; } = null;

            public RestErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Iam::Roles::AdminDeleteRoleV3";
        }

        #endregion

        public AdminDeleteRoleV3(
            string roleId            
        )
        {
            PathParams["roleId"] = roleId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/roles/{roleId}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public AdminDeleteRoleV3.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminDeleteRoleV3.Response()
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
            else if (code == (HttpStatusCode)409)
            
            {
                response.Error409 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error409!.TranslateToApiError();
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