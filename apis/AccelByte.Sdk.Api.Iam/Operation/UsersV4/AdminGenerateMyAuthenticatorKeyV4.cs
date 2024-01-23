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
    /// AdminGenerateMyAuthenticatorKeyV4
    ///
    /// This endpoint is used to generate a secret key for 3rd-party authenticator app.
    /// A QR code URI is also returned so that frontend can generate QR code image.
    /// </summary>
    public class AdminGenerateMyAuthenticatorKeyV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGenerateMyAuthenticatorKeyV4Builder Builder { get => new AdminGenerateMyAuthenticatorKeyV4Builder(); }

        public class AdminGenerateMyAuthenticatorKeyV4Builder
            : OperationBuilder<AdminGenerateMyAuthenticatorKeyV4Builder>
        {





            internal AdminGenerateMyAuthenticatorKeyV4Builder() { }

            internal AdminGenerateMyAuthenticatorKeyV4Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminGenerateMyAuthenticatorKeyV4 Build(
            )
            {
                AdminGenerateMyAuthenticatorKeyV4 op = new AdminGenerateMyAuthenticatorKeyV4(this
                );

                op.SetBaseFields<AdminGenerateMyAuthenticatorKeyV4Builder>(this);
                return op;
            }

            public Model.ModelAuthenticatorKeyResponseV4? Execute(
            )
            {
                AdminGenerateMyAuthenticatorKeyV4 op = Build(
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private AdminGenerateMyAuthenticatorKeyV4(AdminGenerateMyAuthenticatorKeyV4Builder builder
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGenerateMyAuthenticatorKeyV4(
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/admin/users/me/mfa/authenticator/key";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelAuthenticatorKeyResponseV4? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelAuthenticatorKeyResponseV4>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelAuthenticatorKeyResponseV4>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}