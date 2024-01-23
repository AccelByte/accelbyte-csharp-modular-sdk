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
    /// AdminDeleteRoleV4
    ///
    /// Removes role ID from user's Roles and NamespaceRoles before deleting the role.
    /// action code: 10403
    /// </summary>
    public class AdminDeleteRoleV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDeleteRoleV4Builder Builder { get => new AdminDeleteRoleV4Builder(); }

        public class AdminDeleteRoleV4Builder
            : OperationBuilder<AdminDeleteRoleV4Builder>
        {





            internal AdminDeleteRoleV4Builder() { }

            internal AdminDeleteRoleV4Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminDeleteRoleV4 Build(
                string roleId
            )
            {
                AdminDeleteRoleV4 op = new AdminDeleteRoleV4(this,
                    roleId
                );

                op.SetBaseFields<AdminDeleteRoleV4Builder>(this);
                return op;
            }

            public void Execute(
                string roleId
            )
            {
                AdminDeleteRoleV4 op = Build(
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

        private AdminDeleteRoleV4(AdminDeleteRoleV4Builder builder,
            string roleId
        )
        {
            PathParams["roleId"] = roleId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminDeleteRoleV4(
            string roleId
        )
        {
            PathParams["roleId"] = roleId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/admin/roles/{roleId}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { };

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