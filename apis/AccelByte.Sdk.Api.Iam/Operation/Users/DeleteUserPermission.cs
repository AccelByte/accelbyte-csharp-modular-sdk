// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
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

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Net.Http;

using AccelByte.Sdk.Api.Iam.Model;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// DeleteUserPermission
    ///
    /// 
    /// 
    /// ## The endpoint is going to be deprecated
    /// 
    /// 
    /// Endpoint migration guide
    /// 
    /// 
    ///           * Substitute endpoint: /iam/v3/admin/namespaces/{namespace}/users/{userId}/permissions/{resource}/{action} [DELETE]
    /// 
    /// 
    /// 
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:PERMISSION:USER:{userId} [DELETE]'
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
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public void Execute(
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
                op.ParseResponse(
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

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}