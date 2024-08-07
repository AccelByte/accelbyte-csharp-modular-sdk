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
    /// AddRoleManagers
    ///
    /// ## The endpoint is going to be deprecated
    /// Role can only be assigned to other users by the role's manager.
    /// 
    /// ### Endpoint migration guide
    /// - **Substitute endpoint: _/iam/v3/admin/roles/{roleId}/managers [POST]_**
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class AddRoleManagers : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AddRoleManagersBuilder Builder { get => new AddRoleManagersBuilder(); }

        public class AddRoleManagersBuilder
            : OperationBuilder<AddRoleManagersBuilder>
        {





            internal AddRoleManagersBuilder() { }

            internal AddRoleManagersBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AddRoleManagers Build(
                ModelRoleManagersRequest body,
                string roleId
            )
            {
                AddRoleManagers op = new AddRoleManagers(this,
                    body,
                    roleId
                );

                op.SetBaseFields<AddRoleManagersBuilder>(this);
                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public void Execute(
                ModelRoleManagersRequest body,
                string roleId
            )
            {
                AddRoleManagers op = Build(
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
                AddRoleManagers op = Build(
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

        private AddRoleManagers(AddRoleManagersBuilder builder,
            ModelRoleManagersRequest body,
            string roleId
        )
        {
            PathParams["roleId"] = roleId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AddRoleManagers(
            string roleId,
            Model.ModelRoleManagersRequest body
        )
        {
            PathParams["roleId"] = roleId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/roles/{roleId}/managers";

        public override HttpMethod Method => HttpMethod.Post;

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