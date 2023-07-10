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
    /// DeleteRolePermission
    ///
    /// 
    /// 
    /// ## The endpoint is going to be deprecated
    /// 
    /// 
    /// Required permission 'ROLE:ADMIN [UPDATE]' or 'ADMIN:ROLE [UPDATE]'
    /// Endpoint migration guide
    /// 
    /// 
    ///           * Substitute endpoint: /iam/v3/admin/roles/{roleId}/permissions/{resource}/{action} [DELETE]
    /// 
    /// 
    ///           * Substitute endpoint: /iam/v4/admin/roles/{roleId}/permissions [DELETE]
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class DeleteRolePermission : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteRolePermissionBuilder Builder { get => new DeleteRolePermissionBuilder(); }

        public class DeleteRolePermissionBuilder
            : OperationBuilder<DeleteRolePermissionBuilder>
        {





            internal DeleteRolePermissionBuilder() { }

            internal DeleteRolePermissionBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteRolePermission Build(
                long action,
                string resource,
                string roleId
            )
            {
                DeleteRolePermission op = new DeleteRolePermission(this,
                    action,
                    resource,
                    roleId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public void Execute(
                long action,
                string resource,
                string roleId
            )
            {
                DeleteRolePermission op = Build(
                    action,
                    resource,
                    roleId
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

        private DeleteRolePermission(DeleteRolePermissionBuilder builder,
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

        public DeleteRolePermission(
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

        public override string Path => "/iam/roles/{roleId}/permissions/{resource}/{action}";

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