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
    /// AdminInviteUserNewV4
    ///
    /// Use this endpoint to invite admin or non-admin user and assign role to them. The role must be scoped to namespace. An admin user can only
    /// assign role with **assignedNamespaces** if the admin user has required permission which is same as the required permission of endpoint: [AdminAddUserRoleV4].
    /// 
    /// Detail request body :
    /// - **emailAddresses** is required, List of email addresses that will be invited
    /// - **isAdmin** is required, true if user is admin, false if user is not admin
    /// - **namespace** is optional. Only works on multi tenant mode,
    /// if not specified then it will be assigned Publisher namespace,
    /// if specified, it will become that studio/publisher where user is invited to.
    /// - **roleId** is optional, if not specified then it will only assign User role.
    /// - **assignedNamespaces** is optional, List of namespaces which the Role will be assigned to the user, only works when Role is not empty.
    /// 
    /// The invited admin will also assigned with "User" role by default.
    /// </summary>
    public class AdminInviteUserNewV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminInviteUserNewV4Builder Builder { get => new AdminInviteUserNewV4Builder(); }

        public class AdminInviteUserNewV4Builder
            : OperationBuilder<AdminInviteUserNewV4Builder>
        {





            internal AdminInviteUserNewV4Builder() { }

            internal AdminInviteUserNewV4Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminInviteUserNewV4 Build(
                ModelInviteUserRequestV4 body
            )
            {
                AdminInviteUserNewV4 op = new AdminInviteUserNewV4(this,
                    body                    
                );

                op.SetBaseFields<AdminInviteUserNewV4Builder>(this);
                return op;
            }

            public AdminInviteUserNewV4.Response Execute(
                ModelInviteUserRequestV4 body
            )
            {
                AdminInviteUserNewV4 op = Build(
                    body
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<AdminInviteUserNewV4.Response> ExecuteAsync(
                ModelInviteUserRequestV4 body
            )
            {
                AdminInviteUserNewV4 op = Build(
                    body
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

        private AdminInviteUserNewV4(AdminInviteUserNewV4Builder builder,
            ModelInviteUserRequestV4 body
        )
        {
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelInviteUserResponseV3>
        {

            public RestErrorResponse? Error400 { get; set; } = null;

            public RestErrorResponse? Error401 { get; set; } = null;

            public RestErrorResponse? Error403 { get; set; } = null;

            public RestErrorResponse? Error404 { get; set; } = null;

            public RestErrorResponse? Error409 { get; set; } = null;

            public RestErrorResponse? Error422 { get; set; } = null;

            public RestErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Iam::UsersV4::AdminInviteUserNewV4";
        }

        #endregion

        public AdminInviteUserNewV4(
            Model.ModelInviteUserRequestV4 body            
        )
        {
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/admin/users/invite";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public AdminInviteUserNewV4.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminInviteUserNewV4.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelInviteUserResponseV3>(payload, ResponseJsonOptions);
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
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}