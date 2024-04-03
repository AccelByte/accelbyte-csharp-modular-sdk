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
    /// AdminDisableMyAuthenticatorV4
    ///
    /// This endpoint is used to disable 2FA authenticator.
    /// </summary>
    public class AdminDisableMyAuthenticatorV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDisableMyAuthenticatorV4Builder Builder { get => new AdminDisableMyAuthenticatorV4Builder(); }

        public class AdminDisableMyAuthenticatorV4Builder
            : OperationBuilder<AdminDisableMyAuthenticatorV4Builder>
        {





            internal AdminDisableMyAuthenticatorV4Builder() { }

            internal AdminDisableMyAuthenticatorV4Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminDisableMyAuthenticatorV4 Build(
            )
            {
                AdminDisableMyAuthenticatorV4 op = new AdminDisableMyAuthenticatorV4(this
                );

                op.SetBaseFields<AdminDisableMyAuthenticatorV4Builder>(this);
                return op;
            }

            public void Execute(
            )
            {
                AdminDisableMyAuthenticatorV4 op = Build(
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
            )
            {
                AdminDisableMyAuthenticatorV4 op = Build(
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

        private AdminDisableMyAuthenticatorV4(AdminDisableMyAuthenticatorV4Builder builder
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminDisableMyAuthenticatorV4(
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/admin/users/me/mfa/authenticator/disable";

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