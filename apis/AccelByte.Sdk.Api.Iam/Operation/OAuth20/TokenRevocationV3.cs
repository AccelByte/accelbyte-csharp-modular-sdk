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
    /// TokenRevocationV3
    ///
    /// This endpoint revokes a token.
    /// This endpoint requires authorized requests header with Basic Authentication from client that establish the token.
    /// action code: 10706
    /// </summary>
    public class TokenRevocationV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static TokenRevocationV3Builder Builder { get => new TokenRevocationV3Builder(); }

        public class TokenRevocationV3Builder
            : OperationBuilder<TokenRevocationV3Builder>
        {





            internal TokenRevocationV3Builder() { }

            internal TokenRevocationV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public TokenRevocationV3 Build(
                string token
            )
            {
                TokenRevocationV3 op = new TokenRevocationV3(this,
                    token
                );

                op.SetBaseFields<TokenRevocationV3Builder>(this);
                return op;
            }

            public void Execute(
                string token
            )
            {
                TokenRevocationV3 op = Build(
                    token
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
                string token
            )
            {
                TokenRevocationV3 op = Build(
                    token
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

        private TokenRevocationV3(TokenRevocationV3Builder builder,
            string token
        )
        {


            if (token is not null) FormParams["token"] = token;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BASIC);
        }
        #endregion

        public TokenRevocationV3(
            string token
        )
        {


            if (token is not null) FormParams["token"] = token;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BASIC);
        }

        public override string Path => "/iam/v3/oauth/revoke";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/x-www-form-urlencoded" };

        public override List<string> Produces => new() { "application/json" };

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return;
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}