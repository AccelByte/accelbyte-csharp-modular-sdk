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
    /// AdminDeleteUserInformationV3
    ///
    /// [WARNING] This endpoint is deleting user data from database directly by skipping GDPR flow.Required permissions 'ADMIN:NAMESPACE:{namespace}:INFORMATION:USER:{userId} [DELETE]'.
    /// </summary>
    public class AdminDeleteUserInformationV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDeleteUserInformationV3Builder Builder { get => new AdminDeleteUserInformationV3Builder(); }

        public class AdminDeleteUserInformationV3Builder
            : OperationBuilder<AdminDeleteUserInformationV3Builder>
        {





            internal AdminDeleteUserInformationV3Builder() { }

            internal AdminDeleteUserInformationV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminDeleteUserInformationV3 Build(
                string namespace_,
                string userId
            )
            {
                AdminDeleteUserInformationV3 op = new AdminDeleteUserInformationV3(this,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public void Execute(
                string namespace_,
                string userId
            )
            {
                AdminDeleteUserInformationV3 op = Build(
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

        private AdminDeleteUserInformationV3(AdminDeleteUserInformationV3Builder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminDeleteUserInformationV3(
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/users/{userId}/information";

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