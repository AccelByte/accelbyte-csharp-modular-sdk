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
    /// AdminUpdateUserStatusV3
    ///
    /// This endpoint disable or enable user account. Set the enable status on the request body to true to enable user account or set to false to disable it.
    /// Disable user for **Account Disable** purpose fill the reason with:
    /// - **AdminDeactivateAccount** : if your disable account request comes from admin
    /// 
    /// Enable user ignore field 'reason' in the request body.
    /// action code : 10143
    /// </summary>
    public class AdminUpdateUserStatusV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpdateUserStatusV3Builder Builder { get => new AdminUpdateUserStatusV3Builder(); }

        public class AdminUpdateUserStatusV3Builder
            : OperationBuilder<AdminUpdateUserStatusV3Builder>
        {





            internal AdminUpdateUserStatusV3Builder() { }

            internal AdminUpdateUserStatusV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminUpdateUserStatusV3 Build(
                ModelUpdateUserStatusRequest body,
                string namespace_,
                string userId
            )
            {
                AdminUpdateUserStatusV3 op = new AdminUpdateUserStatusV3(this,
                    body,
                    namespace_,
                    userId
                );

                op.SetBaseFields<AdminUpdateUserStatusV3Builder>(this);
                return op;
            }

            public void Execute(
                ModelUpdateUserStatusRequest body,
                string namespace_,
                string userId
            )
            {
                AdminUpdateUserStatusV3 op = Build(
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

        private AdminUpdateUserStatusV3(AdminUpdateUserStatusV3Builder builder,
            ModelUpdateUserStatusRequest body,
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

        public AdminUpdateUserStatusV3(
            string namespace_,
            string userId,
            Model.ModelUpdateUserStatusRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/users/{userId}/status";

        public override HttpMethod Method => HttpMethod.Patch;

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