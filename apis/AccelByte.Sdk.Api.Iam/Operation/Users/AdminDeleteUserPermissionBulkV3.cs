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
    /// AdminDeleteUserPermissionBulkV3
    ///
    /// Delete User Permission
    /// </summary>
    public class AdminDeleteUserPermissionBulkV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDeleteUserPermissionBulkV3Builder Builder { get => new AdminDeleteUserPermissionBulkV3Builder(); }

        public class AdminDeleteUserPermissionBulkV3Builder
            : OperationBuilder<AdminDeleteUserPermissionBulkV3Builder>
        {





            internal AdminDeleteUserPermissionBulkV3Builder() { }

            internal AdminDeleteUserPermissionBulkV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminDeleteUserPermissionBulkV3 Build(
                List<ModelPermissionDeleteRequest> body,
                string namespace_,
                string userId
            )
            {
                AdminDeleteUserPermissionBulkV3 op = new AdminDeleteUserPermissionBulkV3(this,
                    body,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public void Execute(
                List<ModelPermissionDeleteRequest> body,
                string namespace_,
                string userId
            )
            {
                AdminDeleteUserPermissionBulkV3 op = Build(
                    body,
                    namespace_,
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

        private AdminDeleteUserPermissionBulkV3(AdminDeleteUserPermissionBulkV3Builder builder,
            List<ModelPermissionDeleteRequest> body,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminDeleteUserPermissionBulkV3(
            string namespace_,
            string userId,
            List<Model.ModelPermissionDeleteRequest> body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/users/{userId}/permissions";

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