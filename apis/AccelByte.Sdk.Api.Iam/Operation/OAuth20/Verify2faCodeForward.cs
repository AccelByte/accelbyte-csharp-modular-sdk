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
    /// Verify2FACodeForward
    ///
    /// This is a forward version for '/mfa/verify'. If there is any error, it will redirect to login website with error details.
    /// If success, it will forward to auth request redirect url
    /// If got error, it will forward to login website
    /// Verify 2FA code
    /// This endpoint is used for verifying 2FA code.
    /// ## 2FA remember device
    /// To remember device for 2FA, should provide cookie: device_token or header: Device-Token
    /// </summary>
    public class Verify2faCodeForward : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static Verify2faCodeForwardBuilder Builder { get => new Verify2faCodeForwardBuilder(); }

        public class Verify2faCodeForwardBuilder
            : OperationBuilder<Verify2faCodeForwardBuilder>
        {



            public string? DefaultFactor { get; set; }

            public string? Factors { get; set; }

            public bool? RememberDevice { get; set; }



            internal Verify2faCodeForwardBuilder() { }

            internal Verify2faCodeForwardBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }




            public Verify2faCodeForwardBuilder SetDefaultFactor(string _defaultFactor)
            {
                DefaultFactor = _defaultFactor;
                return this;
            }

            public Verify2faCodeForwardBuilder SetFactors(string _factors)
            {
                Factors = _factors;
                return this;
            }

            public Verify2faCodeForwardBuilder SetRememberDevice(bool _rememberDevice)
            {
                RememberDevice = _rememberDevice;
                return this;
            }



            public Verify2faCodeForward Build(
                string clientId,
                string code,
                string factor,
                string mfaToken
            )
            {
                Verify2faCodeForward op = new Verify2faCodeForward(this,
                    clientId,
                    code,
                    factor,
                    mfaToken
                );

                op.SetBaseFields<Verify2faCodeForwardBuilder>(this);
                return op;
            }

            public Verify2faCodeForward.Response Execute(
                string clientId,
                string code,
                string factor,
                string mfaToken
            )
            {
                Verify2faCodeForward op = Build(
                    clientId,
                    code,
                    factor,
                    mfaToken
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<Verify2faCodeForward.Response> ExecuteAsync(
                string clientId,
                string code,
                string factor,
                string mfaToken
            )
            {
                Verify2faCodeForward op = Build(
                    clientId,
                    code,
                    factor,
                    mfaToken
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private Verify2faCodeForward(Verify2faCodeForwardBuilder builder,
            string clientId,
            string code,
            string factor,
            string mfaToken
        )
        {


            if (builder.DefaultFactor is not null) FormParams["defaultFactor"] = builder.DefaultFactor;
            if (builder.Factors is not null) FormParams["factors"] = builder.Factors;
            if (builder.RememberDevice != null) FormParams["rememberDevice"] = Convert.ToString(builder.RememberDevice)!;
            if (clientId is not null) FormParams["clientId"] = clientId;
            if (code is not null) FormParams["code"] = code;
            if (factor is not null) FormParams["factor"] = factor;
            if (mfaToken is not null) FormParams["mfaToken"] = mfaToken;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<string>
        {

            public string Error302 { get; set; } = "";


            protected override string GetFullOperationId() => "Iam::OAuth20::Verify2faCodeForward";
        }

        #endregion

        public Verify2faCodeForward(
            string? defaultFactor,
            string? factors,
            bool? rememberDevice,
            string clientId,
            string code,
            string factor,
            string mfaToken
        )
        {


            if (defaultFactor is not null) FormParams["defaultFactor"] = defaultFactor;
            if (factors is not null) FormParams["factors"] = factors;
            if (rememberDevice != null) FormParams["rememberDevice"] = Convert.ToString(rememberDevice)!;
            if (clientId is not null) FormParams["clientId"] = clientId;
            if (code is not null) FormParams["code"] = code;
            if (factor is not null) FormParams["factor"] = factor;
            if (mfaToken is not null) FormParams["mfaToken"] = mfaToken;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/oauth/mfa/verify/forward";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/x-www-form-urlencoded" };

        public override List<string> Produces => new() { "application/json" };

        public Verify2faCodeForward.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new Verify2faCodeForward.Response()
            {
                StatusCode = code,
                ContentType = contentType
            };

            if (code == (HttpStatusCode)302)
            {
                response.Data = payload.ReadToString();
                response.IsSuccess = true;
            }

            return response;
        }
    }

}