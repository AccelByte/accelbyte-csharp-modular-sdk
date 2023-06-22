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
    /// AdminDeleteRolePermissionsV4
    ///
    /// Required permission ADMIN:ROLE [UPDATE]
    /// </summary>
    public class AdminDeleteRolePermissionsV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDeleteRolePermissionsV4Builder Builder { get => new AdminDeleteRolePermissionsV4Builder(); }

        public class AdminDeleteRolePermissionsV4Builder
            : OperationBuilder<AdminDeleteRolePermissionsV4Builder>
        {





            internal AdminDeleteRolePermissionsV4Builder() { }

            internal AdminDeleteRolePermissionsV4Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminDeleteRolePermissionsV4 Build(
                List<string> body,
                string roleId
            )
            {
                AdminDeleteRolePermissionsV4 op = new AdminDeleteRolePermissionsV4(this,
                    body,
                    roleId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public void Execute(
                List<string> body,
                string roleId
            )
            {
                AdminDeleteRolePermissionsV4 op = Build(
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
        }

        private AdminDeleteRolePermissionsV4(AdminDeleteRolePermissionsV4Builder builder,
            List<string> body,
            string roleId
        )
        {
            PathParams["roleId"] = roleId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminDeleteRolePermissionsV4(
            string roleId,
            List<string> body
        )
        {
            PathParams["roleId"] = roleId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/admin/roles/{roleId}/permissions";

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