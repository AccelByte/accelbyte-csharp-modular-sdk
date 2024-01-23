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
    /// AdminResetPasswordV2
    ///
    /// ## The endpoint is going to be deprecated
    /// **Endpoint migration guide**
    /// - **Substitute endpoint: _/iam/v3/admin/namespaces/{namespace}/users/{userId}/password [PUT]_**
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class AdminResetPasswordV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminResetPasswordV2Builder Builder { get => new AdminResetPasswordV2Builder(); }

        public class AdminResetPasswordV2Builder
            : OperationBuilder<AdminResetPasswordV2Builder>
        {





            internal AdminResetPasswordV2Builder() { }

            internal AdminResetPasswordV2Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminResetPasswordV2 Build(
                ModelUserPasswordUpdateRequest body,
                string namespace_,
                string userId
            )
            {
                AdminResetPasswordV2 op = new AdminResetPasswordV2(this,
                    body,
                    namespace_,
                    userId
                );

                op.SetBaseFields<AdminResetPasswordV2Builder>(this);
                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public void Execute(
                ModelUserPasswordUpdateRequest body,
                string namespace_,
                string userId
            )
            {
                AdminResetPasswordV2 op = Build(
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

        private AdminResetPasswordV2(AdminResetPasswordV2Builder builder,
            ModelUserPasswordUpdateRequest body,
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

        public AdminResetPasswordV2(
            string namespace_,
            string userId,
            Model.ModelUserPasswordUpdateRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v2/admin/namespaces/{namespace}/users/{userId}/password";

        public override HttpMethod Method => HttpMethod.Put;

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