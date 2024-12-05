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
    /// AdminSaveUserRoleV3
    ///
    /// User's roles will be replaced with roles from request body.
    /// An admin user can only assign role with **namespace** (in request body) if the admin user has required permission which is same as the required permission of endpoint: [AdminAddUserRoleV4].
    /// </summary>
    public class AdminSaveUserRoleV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminSaveUserRoleV3Builder Builder { get => new AdminSaveUserRoleV3Builder(); }

        public class AdminSaveUserRoleV3Builder
            : OperationBuilder<AdminSaveUserRoleV3Builder>
        {





            internal AdminSaveUserRoleV3Builder() { }

            internal AdminSaveUserRoleV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminSaveUserRoleV3 Build(
                List<ModelNamespaceRoleRequest> body,
                string namespace_,
                string userId
            )
            {
                AdminSaveUserRoleV3 op = new AdminSaveUserRoleV3(this,
                    body,
                    namespace_,
                    userId
                );

                op.SetBaseFields<AdminSaveUserRoleV3Builder>(this);
                return op;
            }

            public AdminSaveUserRoleV3.Response Execute(
                List<ModelNamespaceRoleRequest> body,
                string namespace_,
                string userId
            )
            {
                AdminSaveUserRoleV3 op = Build(
                    body,
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
            public async Task<AdminSaveUserRoleV3.Response> ExecuteAsync(
                List<ModelNamespaceRoleRequest> body,
                string namespace_,
                string userId
            )
            {
                AdminSaveUserRoleV3 op = Build(
                    body,
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

        private AdminSaveUserRoleV3(AdminSaveUserRoleV3Builder builder,
            List<ModelNamespaceRoleRequest> body,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





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

            public RestErrorResponse? Error422 { get; set; } = null;

            public RestErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Iam::Users::AdminSaveUserRoleV3";
        }

        #endregion

        public AdminSaveUserRoleV3(
            string namespace_,
            string userId,
            List<Model.ModelNamespaceRoleRequest> body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/users/{userId}/roles";

        public override HttpMethod Method => HttpMethod.Patch;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public AdminSaveUserRoleV3.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminSaveUserRoleV3.Response()
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