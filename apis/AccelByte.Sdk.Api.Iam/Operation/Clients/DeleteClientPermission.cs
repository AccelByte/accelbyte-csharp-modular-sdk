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
    /// DeleteClientPermission
    ///
    /// ## The endpoint is going to be deprecated
    /// **Endpoint migration guide**
    /// - **Substitute endpoint: _/iam/v3/admin/namespaces/{namespace}/clients/{clientId}/permissions/{resource}/{action} [DELETE]_**
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class DeleteClientPermission : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteClientPermissionBuilder Builder { get => new DeleteClientPermissionBuilder(); }

        public class DeleteClientPermissionBuilder
            : OperationBuilder<DeleteClientPermissionBuilder>
        {





            internal DeleteClientPermissionBuilder() { }

            internal DeleteClientPermissionBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteClientPermission Build(
                long action,
                string clientId,
                string resource
            )
            {
                DeleteClientPermission op = new DeleteClientPermission(this,
                    action,
                    clientId,
                    resource
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public void Execute(
                long action,
                string clientId,
                string resource
            )
            {
                DeleteClientPermission op = Build(
                    action,
                    clientId,
                    resource
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

        private DeleteClientPermission(DeleteClientPermissionBuilder builder,
            long action,
            string clientId,
            string resource
        )
        {
            PathParams["action"] = Convert.ToString(action);
            PathParams["clientId"] = clientId;
            PathParams["resource"] = resource;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteClientPermission(
            long action,
            string clientId,
            string resource
        )
        {
            PathParams["action"] = Convert.ToString(action);
            PathParams["clientId"] = clientId;
            PathParams["resource"] = resource;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/clients/{clientId}/clientpermissions/{resource}/{action}";

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