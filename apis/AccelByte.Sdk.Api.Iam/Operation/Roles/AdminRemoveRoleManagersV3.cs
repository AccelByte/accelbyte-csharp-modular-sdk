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
    /// AdminRemoveRoleManagersV3
    ///
    /// Role can only be assigned to other users by the role's manager.
    /// action code: 10409
    /// </summary>
    public class AdminRemoveRoleManagersV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminRemoveRoleManagersV3Builder Builder { get => new AdminRemoveRoleManagersV3Builder(); }

        public class AdminRemoveRoleManagersV3Builder
            : OperationBuilder<AdminRemoveRoleManagersV3Builder>
        {





            internal AdminRemoveRoleManagersV3Builder() { }

            internal AdminRemoveRoleManagersV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminRemoveRoleManagersV3 Build(
                ModelRoleManagersRequestV3 body,
                string roleId
            )
            {
                AdminRemoveRoleManagersV3 op = new AdminRemoveRoleManagersV3(this,
                    body,
                    roleId
                );

                op.SetBaseFields<AdminRemoveRoleManagersV3Builder>(this);
                return op;
            }

            public void Execute(
                ModelRoleManagersRequestV3 body,
                string roleId
            )
            {
                AdminRemoveRoleManagersV3 op = Build(
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
                ModelRoleManagersRequestV3 body,
                string roleId
            )
            {
                AdminRemoveRoleManagersV3 op = Build(
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

        private AdminRemoveRoleManagersV3(AdminRemoveRoleManagersV3Builder builder,
            ModelRoleManagersRequestV3 body,
            string roleId
        )
        {
            PathParams["roleId"] = roleId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminRemoveRoleManagersV3(
            string roleId,
            Model.ModelRoleManagersRequestV3 body
        )
        {
            PathParams["roleId"] = roleId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/roles/{roleId}/managers";

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