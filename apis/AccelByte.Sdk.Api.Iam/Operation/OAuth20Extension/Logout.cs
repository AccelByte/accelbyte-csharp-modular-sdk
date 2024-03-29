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
    /// Logout
    ///
    /// This endpoint is used to remove **access_token**, **refresh_token** from cookie and revoke token from usage.
    /// Supported methods:
    /// - VerifyToken to verify token from header
    /// - AddTokenToRevocationList to revoke token with TTL
    /// </summary>
    public class Logout : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static LogoutBuilder Builder { get => new LogoutBuilder(); }

        public class LogoutBuilder
            : OperationBuilder<LogoutBuilder>
        {





            internal LogoutBuilder() { }

            internal LogoutBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public Logout Build(
            )
            {
                Logout op = new Logout(this
                );

                op.SetBaseFields<LogoutBuilder>(this);
                return op;
            }

            public void Execute(
            )
            {
                Logout op = Build(
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

        private Logout(LogoutBuilder builder
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public Logout(
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/logout";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "*/*" };

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