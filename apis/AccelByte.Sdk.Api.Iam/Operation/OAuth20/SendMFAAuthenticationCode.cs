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
    /// SendMFAAuthenticationCode
    ///
    /// Send 2FA code
    /// 
    /// 
    /// 
    /// This endpoint is used for sending 2FA code.
    /// </summary>
    public class SendMFAAuthenticationCode : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SendMFAAuthenticationCodeBuilder Builder { get => new SendMFAAuthenticationCodeBuilder(); }

        public class SendMFAAuthenticationCodeBuilder
            : OperationBuilder<SendMFAAuthenticationCodeBuilder>
        {





            internal SendMFAAuthenticationCodeBuilder() { }

            internal SendMFAAuthenticationCodeBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public SendMFAAuthenticationCode Build(
                string clientId,
                string factor,
                string mfaToken
            )
            {
                SendMFAAuthenticationCode op = new SendMFAAuthenticationCode(this,
                    clientId,
                    factor,
                    mfaToken
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public void Execute(
                string clientId,
                string factor,
                string mfaToken
            )
            {
                SendMFAAuthenticationCode op = Build(
                    clientId,
                    factor,
                    mfaToken
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

        private SendMFAAuthenticationCode(SendMFAAuthenticationCodeBuilder builder,
            string clientId,
            string factor,
            string mfaToken
        )
        {


            if (clientId is not null) FormParams["clientId"] = clientId;
            if (factor is not null) FormParams["factor"] = factor;
            if (mfaToken is not null) FormParams["mfaToken"] = mfaToken;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public SendMFAAuthenticationCode(
            string clientId,
            string factor,
            string mfaToken
        )
        {


            if (clientId is not null) FormParams["clientId"] = clientId;
            if (factor is not null) FormParams["factor"] = factor;
            if (mfaToken is not null) FormParams["mfaToken"] = mfaToken;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/oauth/mfa/code";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/x-www-form-urlencoded" };

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