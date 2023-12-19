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
    /// AdminVerifyUserWithoutVerificationCodeV3
    ///
    /// This endpoint force verify user
    /// action code: 10118
    /// </summary>
    public class AdminVerifyUserWithoutVerificationCodeV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminVerifyUserWithoutVerificationCodeV3Builder Builder { get => new AdminVerifyUserWithoutVerificationCodeV3Builder(); }

        public class AdminVerifyUserWithoutVerificationCodeV3Builder
            : OperationBuilder<AdminVerifyUserWithoutVerificationCodeV3Builder>
        {





            internal AdminVerifyUserWithoutVerificationCodeV3Builder() { }

            internal AdminVerifyUserWithoutVerificationCodeV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminVerifyUserWithoutVerificationCodeV3 Build(
                string namespace_,
                string userId
            )
            {
                AdminVerifyUserWithoutVerificationCodeV3 op = new AdminVerifyUserWithoutVerificationCodeV3(this,
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
                AdminVerifyUserWithoutVerificationCodeV3 op = Build(
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

        private AdminVerifyUserWithoutVerificationCodeV3(AdminVerifyUserWithoutVerificationCodeV3Builder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminVerifyUserWithoutVerificationCodeV3(
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/users/{userId}/verify";

        public override HttpMethod Method => HttpMethod.Put;

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