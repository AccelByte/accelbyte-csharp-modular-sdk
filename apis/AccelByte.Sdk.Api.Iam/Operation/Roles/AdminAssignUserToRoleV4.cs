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
    /// AdminAssignUserToRoleV4
    ///
    /// Parameters:
    /// - **userId**: string (required)
    /// - **namespace**: string (userâs namespace) (required)
    /// - **assignedNamespaces**: array of string (namespaces to be assigned on role) (required)
    /// 
    /// action code: 10410
    /// </summary>
    public class AdminAssignUserToRoleV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminAssignUserToRoleV4Builder Builder { get => new AdminAssignUserToRoleV4Builder(); }

        public class AdminAssignUserToRoleV4Builder
            : OperationBuilder<AdminAssignUserToRoleV4Builder>
        {





            internal AdminAssignUserToRoleV4Builder() { }

            internal AdminAssignUserToRoleV4Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminAssignUserToRoleV4 Build(
                ModelAssignUserV4Request body,
                string roleId
            )
            {
                AdminAssignUserToRoleV4 op = new AdminAssignUserToRoleV4(this,
                    body,                    
                    roleId                    
                );

                op.SetBaseFields<AdminAssignUserToRoleV4Builder>(this);
                return op;
            }

            public AdminAssignUserToRoleV4.Response Execute(
                ModelAssignUserV4Request body,
                string roleId
            )
            {
                AdminAssignUserToRoleV4 op = Build(
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
            public async Task<AdminAssignUserToRoleV4.Response> ExecuteAsync(
                ModelAssignUserV4Request body,
                string roleId
            )
            {
                AdminAssignUserToRoleV4 op = Build(
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

        private AdminAssignUserToRoleV4(AdminAssignUserToRoleV4Builder builder,
            ModelAssignUserV4Request body,
            string roleId
        )
        {
            PathParams["roleId"] = roleId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelAssignedUserV4Response>
        {

            public RestErrorResponse? Error400 { get; set; } = null;

            public RestErrorResponse? Error401 { get; set; } = null;

            public RestErrorResponse? Error403 { get; set; } = null;

            public RestErrorResponse? Error404 { get; set; } = null;

            public RestErrorResponse? Error409 { get; set; } = null;

            public RestErrorResponse? Error422 { get; set; } = null;


            protected override string GetFullOperationId() => "Iam::Roles::AdminAssignUserToRoleV4";
        }

        #endregion

        public AdminAssignUserToRoleV4(
            string roleId,            
            Model.ModelAssignUserV4Request body            
        )
        {
            PathParams["roleId"] = roleId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/admin/roles/{roleId}/users";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public AdminAssignUserToRoleV4.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminAssignUserToRoleV4.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelAssignedUserV4Response>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
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
            else if (code == (HttpStatusCode)422)
            {
                response.Error422 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error422!.TranslateToApiError();
            }

            return response;
        }
    }

}