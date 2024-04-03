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
    /// AdminDisableUserMFAV4
    ///
    /// **This endpoint is used to disable user 2FA.**
    /// </summary>
    public class AdminDisableUserMFAV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDisableUserMFAV4Builder Builder { get => new AdminDisableUserMFAV4Builder(); }

        public class AdminDisableUserMFAV4Builder
            : OperationBuilder<AdminDisableUserMFAV4Builder>
        {





            internal AdminDisableUserMFAV4Builder() { }

            internal AdminDisableUserMFAV4Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminDisableUserMFAV4 Build(
                string namespace_,
                string userId
            )
            {
                AdminDisableUserMFAV4 op = new AdminDisableUserMFAV4(this,
                    namespace_,
                    userId
                );

                op.SetBaseFields<AdminDisableUserMFAV4Builder>(this);
                return op;
            }

            public void Execute(
                string namespace_,
                string userId
            )
            {
                AdminDisableUserMFAV4 op = Build(
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
            public async Task ExecuteAsync(
                string namespace_,
                string userId
            )
            {
                AdminDisableUserMFAV4 op = Build(
                    namespace_,
                    userId
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

        private AdminDisableUserMFAV4(AdminDisableUserMFAV4Builder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminDisableUserMFAV4(
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/admin/namespaces/{namespace}/users/{userId}/mfa/disable";

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