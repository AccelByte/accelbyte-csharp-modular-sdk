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
    /// RemoveRoleManagers
    ///
    /// ## The endpoint is going to be deprecated
    /// ### Endpoint migration guide
    /// - **Substitute endpoint: _/iam/v3/admin/roles/{roleId}/managers [DELETE]_**
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class RemoveRoleManagers : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RemoveRoleManagersBuilder Builder { get => new RemoveRoleManagersBuilder(); }

        public class RemoveRoleManagersBuilder
            : OperationBuilder<RemoveRoleManagersBuilder>
        {





            internal RemoveRoleManagersBuilder() { }

            internal RemoveRoleManagersBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public RemoveRoleManagers Build(
                ModelRoleManagersRequest body,
                string roleId
            )
            {
                RemoveRoleManagers op = new RemoveRoleManagers(this,
                    body,
                    roleId
                );

                op.SetBaseFields<RemoveRoleManagersBuilder>(this);
                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public void Execute(
                ModelRoleManagersRequest body,
                string roleId
            )
            {
                RemoveRoleManagers op = Build(
                    body,
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
            public async Task ExecuteAsync(
                ModelRoleManagersRequest body,
                string roleId
            )
            {
                RemoveRoleManagers op = Build(
                    body,
                    roleId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private RemoveRoleManagers(RemoveRoleManagersBuilder builder,
            ModelRoleManagersRequest body,
            string roleId
        )
        {
            PathParams["roleId"] = roleId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public RemoveRoleManagers(
            string roleId,
            Model.ModelRoleManagersRequest body
        )
        {
            PathParams["roleId"] = roleId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/roles/{roleId}/managers";

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