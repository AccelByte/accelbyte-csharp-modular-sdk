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
    /// AdminAddRoleManagersV3
    ///
    /// Role can only be assigned to other users by the role's manager.
    /// action code: 10408
    /// </summary>
    public class AdminAddRoleManagersV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminAddRoleManagersV3Builder Builder { get => new AdminAddRoleManagersV3Builder(); }

        public class AdminAddRoleManagersV3Builder
            : OperationBuilder<AdminAddRoleManagersV3Builder>
        {





            internal AdminAddRoleManagersV3Builder() { }

            internal AdminAddRoleManagersV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminAddRoleManagersV3 Build(
                ModelRoleManagersRequestV3 body,
                string roleId
            )
            {
                AdminAddRoleManagersV3 op = new AdminAddRoleManagersV3(this,
                    body,
                    roleId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public void Execute(
                ModelRoleManagersRequestV3 body,
                string roleId
            )
            {
                AdminAddRoleManagersV3 op = Build(
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

        private AdminAddRoleManagersV3(AdminAddRoleManagersV3Builder builder,
            ModelRoleManagersRequestV3 body,
            string roleId
        )
        {
            PathParams["roleId"] = roleId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminAddRoleManagersV3(
            string roleId,
            Model.ModelRoleManagersRequestV3 body
        )
        {
            PathParams["roleId"] = roleId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/roles/{roleId}/managers";

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