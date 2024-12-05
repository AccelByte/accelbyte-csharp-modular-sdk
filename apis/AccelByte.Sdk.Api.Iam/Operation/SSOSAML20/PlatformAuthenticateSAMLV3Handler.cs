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
    /// platformAuthenticateSAMLV3Handler
    ///
    /// This endpoint authenticates user platform for SAML protocol. It validates user to its
    /// respective platforms. Deactivated or login-banned users are unable to login.
    /// ## Supported platforms:
    /// - **azure**
    /// Microsoft login page will redirects to this endpoint after login success
    /// as previously defined on authentication request SAML
    /// </summary>
    public class PlatformAuthenticateSAMLV3Handler : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PlatformAuthenticateSAMLV3HandlerBuilder Builder { get => new PlatformAuthenticateSAMLV3HandlerBuilder(); }

        public class PlatformAuthenticateSAMLV3HandlerBuilder
            : OperationBuilder<PlatformAuthenticateSAMLV3HandlerBuilder>
        {

            public string? Code { get; set; }

            public string? Error { get; set; }





            internal PlatformAuthenticateSAMLV3HandlerBuilder() { }

            internal PlatformAuthenticateSAMLV3HandlerBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public PlatformAuthenticateSAMLV3HandlerBuilder SetCode(string _code)
            {
                Code = _code;
                return this;
            }

            public PlatformAuthenticateSAMLV3HandlerBuilder SetError(string _error)
            {
                Error = _error;
                return this;
            }





            public PlatformAuthenticateSAMLV3Handler Build(
                string platformId,
                string state
            )
            {
                PlatformAuthenticateSAMLV3Handler op = new PlatformAuthenticateSAMLV3Handler(this,
                    platformId,
                    state
                );

                op.SetBaseFields<PlatformAuthenticateSAMLV3HandlerBuilder>(this);
                return op;
            }

            public PlatformAuthenticateSAMLV3Handler.Response Execute(
                string platformId,
                string state
            )
            {
                PlatformAuthenticateSAMLV3Handler op = Build(
                    platformId,
                    state
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<PlatformAuthenticateSAMLV3Handler.Response> ExecuteAsync(
                string platformId,
                string state
            )
            {
                PlatformAuthenticateSAMLV3Handler op = Build(
                    platformId,
                    state
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

        private PlatformAuthenticateSAMLV3Handler(PlatformAuthenticateSAMLV3HandlerBuilder builder,
            string platformId,
            string state
        )
        {
            PathParams["platformId"] = platformId;

            if (builder.Code is not null) QueryParams["code"] = builder.Code;
            if (builder.Error is not null) QueryParams["error"] = builder.Error;
            if (state is not null) QueryParams["state"] = state;





            LocationQuery = "PLACEHOLDER";

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<string>
        {

            public string Error302 { get; set; } = "";


            protected override string GetFullOperationId() => "Iam::SSOSAML20::PlatformAuthenticateSAMLV3Handler";
        }

        #endregion

        public PlatformAuthenticateSAMLV3Handler(
            string platformId,
            string? code,
            string? error,
            string state
        )
        {
            PathParams["platformId"] = platformId;

            if (code is not null) QueryParams["code"] = code;
            if (error is not null) QueryParams["error"] = error;
            if (state is not null) QueryParams["state"] = state;





            LocationQuery = "PLACEHOLDER";

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/sso/saml/platforms/{platformId}/authenticate";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/x-www-form-urlencoded" };

        public override List<string> Produces => new() { };

        public PlatformAuthenticateSAMLV3Handler.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new PlatformAuthenticateSAMLV3Handler.Response()
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