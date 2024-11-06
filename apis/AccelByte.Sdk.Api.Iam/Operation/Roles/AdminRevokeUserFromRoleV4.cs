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
    /// AdminRevokeUserFromRoleV4
    ///
    /// Current implementation will revoke user from role in all assigned namespaces.
    /// 
    /// Parameters:
    /// - userId: string (required)
    /// - namespace: string (userâs namespace) (required)
    /// 
    /// action code: 10411
    /// </summary>
    public class AdminRevokeUserFromRoleV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminRevokeUserFromRoleV4Builder Builder { get => new AdminRevokeUserFromRoleV4Builder(); }

        public class AdminRevokeUserFromRoleV4Builder
            : OperationBuilder<AdminRevokeUserFromRoleV4Builder>
        {





            internal AdminRevokeUserFromRoleV4Builder() { }

            internal AdminRevokeUserFromRoleV4Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminRevokeUserFromRoleV4 Build(
                ModelRevokeUserV4Request body,
                string roleId
            )
            {
                AdminRevokeUserFromRoleV4 op = new AdminRevokeUserFromRoleV4(this,
                    body,                    
                    roleId                    
                );

                op.SetBaseFields<AdminRevokeUserFromRoleV4Builder>(this);
                return op;
            }

            public AdminRevokeUserFromRoleV4.Response Execute(
                ModelRevokeUserV4Request body,
                string roleId
            )
            {
                AdminRevokeUserFromRoleV4 op = Build(
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
            public async Task<AdminRevokeUserFromRoleV4.Response> ExecuteAsync(
                ModelRevokeUserV4Request body,
                string roleId
            )
            {
                AdminRevokeUserFromRoleV4 op = Build(
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

        private AdminRevokeUserFromRoleV4(AdminRevokeUserFromRoleV4Builder builder,
            ModelRevokeUserV4Request body,
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

            public RestErrorResponse? Error400 { get; set; } = null;

            public RestErrorResponse? Error401 { get; set; } = null;

            public RestErrorResponse? Error403 { get; set; } = null;

            public RestErrorResponse? Error404 { get; set; } = null;


            protected override string GetFullOperationId() => "Iam::Roles::AdminRevokeUserFromRoleV4";
        }

        #endregion

        public AdminRevokeUserFromRoleV4(
            string roleId,            
            Model.ModelRevokeUserV4Request body            
        )
        {
            PathParams["roleId"] = roleId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/admin/roles/{roleId}/users";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public AdminRevokeUserFromRoleV4.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminRevokeUserFromRoleV4.Response()
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