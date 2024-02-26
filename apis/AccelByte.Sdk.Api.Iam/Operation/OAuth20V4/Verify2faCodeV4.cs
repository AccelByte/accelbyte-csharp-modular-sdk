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
    /// Verify2FACodeV4
    ///
    /// Verify 2FA code
    /// This endpoint is used for verifying 2FA code.
    /// ## 2FA remember device
    /// To remember device for 2FA, should provide cookie: device_token or header: Device-Token
    /// </summary>
    public class Verify2faCodeV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static Verify2faCodeV4Builder Builder { get => new Verify2faCodeV4Builder(); }

        public class Verify2faCodeV4Builder
            : OperationBuilder<Verify2faCodeV4Builder>
        {





            internal Verify2faCodeV4Builder() { }

            internal Verify2faCodeV4Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public Verify2faCodeV4 Build(
                string code,
                string factor,
                string mfaToken,
                bool rememberDevice
            )
            {
                Verify2faCodeV4 op = new Verify2faCodeV4(this,
                    code,
                    factor,
                    mfaToken,
                    rememberDevice
                );

                op.SetBaseFields<Verify2faCodeV4Builder>(this);
                return op;
            }

            public Model.OauthmodelTokenResponseV3? Execute(
                string code,
                string factor,
                string mfaToken,
                bool rememberDevice
            )
            {
                Verify2faCodeV4 op = Build(
                    code,
                    factor,
                    mfaToken,
                    rememberDevice
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

        private Verify2faCodeV4(Verify2faCodeV4Builder builder,
            string code,
            string factor,
            string mfaToken,
            bool rememberDevice
        )
        {


            if (code is not null) FormParams["code"] = code;
            if (factor is not null) FormParams["factor"] = factor;
            if (mfaToken is not null) FormParams["mfaToken"] = mfaToken;
            FormParams["rememberDevice"] = Convert.ToString(rememberDevice)!;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public Verify2faCodeV4(
            string code,
            string factor,
            string mfaToken,
            bool rememberDevice
        )
        {


            if (code is not null) FormParams["code"] = code;
            if (factor is not null) FormParams["factor"] = factor;
            if (mfaToken is not null) FormParams["mfaToken"] = mfaToken;
            FormParams["rememberDevice"] = Convert.ToString(rememberDevice)!;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/oauth/mfa/verify";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/x-www-form-urlencoded" };

        public override List<string> Produces => new() { "application/json" };

        public Model.OauthmodelTokenResponseV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.OauthmodelTokenResponseV3>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.OauthmodelTokenResponseV3>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}