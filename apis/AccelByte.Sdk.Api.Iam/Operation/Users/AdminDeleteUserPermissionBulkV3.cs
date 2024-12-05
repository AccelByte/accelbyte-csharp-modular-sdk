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
    /// AdminDeleteUserPermissionBulkV3
    ///
    /// Delete User Permission
    /// </summary>
    public class AdminDeleteUserPermissionBulkV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDeleteUserPermissionBulkV3Builder Builder { get => new AdminDeleteUserPermissionBulkV3Builder(); }

        public class AdminDeleteUserPermissionBulkV3Builder
            : OperationBuilder<AdminDeleteUserPermissionBulkV3Builder>
        {





            internal AdminDeleteUserPermissionBulkV3Builder() { }

            internal AdminDeleteUserPermissionBulkV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminDeleteUserPermissionBulkV3 Build(
                List<ModelPermissionDeleteRequest> body,
                string namespace_,
                string userId
            )
            {
                AdminDeleteUserPermissionBulkV3 op = new AdminDeleteUserPermissionBulkV3(this,
                    body,
                    namespace_,
                    userId
                );

                op.SetBaseFields<AdminDeleteUserPermissionBulkV3Builder>(this);
                return op;
            }

            public AdminDeleteUserPermissionBulkV3.Response Execute(
                List<ModelPermissionDeleteRequest> body,
                string namespace_,
                string userId
            )
            {
                AdminDeleteUserPermissionBulkV3 op = Build(
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
            public async Task<AdminDeleteUserPermissionBulkV3.Response> ExecuteAsync(
                List<ModelPermissionDeleteRequest> body,
                string namespace_,
                string userId
            )
            {
                AdminDeleteUserPermissionBulkV3 op = Build(
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

        private AdminDeleteUserPermissionBulkV3(AdminDeleteUserPermissionBulkV3Builder builder,
            List<ModelPermissionDeleteRequest> body,
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

            public string Error404 { get; set; } = "";


            protected override string GetFullOperationId() => "Iam::Users::AdminDeleteUserPermissionBulkV3";
        }

        #endregion

        public AdminDeleteUserPermissionBulkV3(
            string namespace_,
            string userId,
            List<Model.ModelPermissionDeleteRequest> body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/users/{userId}/permissions";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public AdminDeleteUserPermissionBulkV3.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminDeleteUserPermissionBulkV3.Response()
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
                response.Error404 = payload.ReadToString();
                response.Error = new ApiError("-1", response.Error404!);
            }

            return response;
        }
    }

}