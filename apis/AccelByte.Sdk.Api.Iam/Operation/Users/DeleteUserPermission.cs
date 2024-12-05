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
    /// DeleteUserPermission
    ///
    /// ## The endpoint is going to be deprecated
    /// ### Endpoint migration guide
    /// - **Substitute endpoint: _/iam/v3/admin/namespaces/{namespace}/users/{userId}/permissions/{resource}/{action} [DELETE]_**
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class DeleteUserPermission : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteUserPermissionBuilder Builder { get => new DeleteUserPermissionBuilder(); }

        public class DeleteUserPermissionBuilder
            : OperationBuilder<DeleteUserPermissionBuilder>
        {





            internal DeleteUserPermissionBuilder() { }

            internal DeleteUserPermissionBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteUserPermission Build(
                long action,
                string namespace_,
                string resource,
                string userId
            )
            {
                DeleteUserPermission op = new DeleteUserPermission(this,
                    action,
                    namespace_,
                    resource,
                    userId
                );

                op.SetBaseFields<DeleteUserPermissionBuilder>(this);
                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public DeleteUserPermission.Response Execute(
                long action,
                string namespace_,
                string resource,
                string userId
            )
            {
                DeleteUserPermission op = Build(
                    action,
                    namespace_,
                    resource,
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
            public async Task<DeleteUserPermission.Response> ExecuteAsync(
                long action,
                string namespace_,
                string resource,
                string userId
            )
            {
                DeleteUserPermission op = Build(
                    action,
                    namespace_,
                    resource,
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

        private DeleteUserPermission(DeleteUserPermissionBuilder builder,
            long action,
            string namespace_,
            string resource,
            string userId
        )
        {
            PathParams["action"] = Convert.ToString(action);
            PathParams["namespace"] = namespace_;
            PathParams["resource"] = resource;
            PathParams["userId"] = userId;







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


            protected override string GetFullOperationId() => "Iam::Users::DeleteUserPermission";
        }

        #endregion

        public DeleteUserPermission(
            long action,
            string namespace_,
            string resource,
            string userId
        )
        {
            PathParams["action"] = Convert.ToString(action);
            PathParams["namespace"] = namespace_;
            PathParams["resource"] = resource;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/namespaces/{namespace}/users/{userId}/permissions/{resource}/{action}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public DeleteUserPermission.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new DeleteUserPermission.Response()
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