// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;

namespace AccelByte.Sdk.Api.Iam.Wrapper
{
    public class OAuth20
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public OAuth20(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public OAuth20(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        public AdminRetrieveUserThirdPartyPlatformTokenV3.AdminRetrieveUserThirdPartyPlatformTokenV3Builder AdminRetrieveUserThirdPartyPlatformTokenV3Op
        {
            get
            {
                var opBuilder = new Operation.AdminRetrieveUserThirdPartyPlatformTokenV3.AdminRetrieveUserThirdPartyPlatformTokenV3Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public RevokeUserV3.RevokeUserV3Builder RevokeUserV3Op
        {
            get
            {
                var opBuilder = new Operation.RevokeUserV3.RevokeUserV3Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AuthorizeV3.AuthorizeV3Builder AuthorizeV3Op
        {
            get
            {
                var opBuilder = new Operation.AuthorizeV3.AuthorizeV3Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public TokenIntrospectionV3.TokenIntrospectionV3Builder TokenIntrospectionV3Op
        {
            get
            {
                var opBuilder = new Operation.TokenIntrospectionV3.TokenIntrospectionV3Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetJWKSV3.GetJWKSV3Builder GetJWKSV3Op
        {
            get
            {
                var opBuilder = new Operation.GetJWKSV3.GetJWKSV3Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public SendMFAAuthenticationCode.SendMFAAuthenticationCodeBuilder SendMFAAuthenticationCodeOp
        {
            get
            {
                var opBuilder = new Operation.SendMFAAuthenticationCode.SendMFAAuthenticationCodeBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public Change2faMethod.Change2faMethodBuilder Change2faMethodOp
        {
            get
            {
                var opBuilder = new Operation.Change2faMethod.Change2faMethodBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public Verify2faCode.Verify2faCodeBuilder Verify2faCodeOp
        {
            get
            {
                var opBuilder = new Operation.Verify2faCode.Verify2faCodeBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public RetrieveUserThirdPartyPlatformTokenV3.RetrieveUserThirdPartyPlatformTokenV3Builder RetrieveUserThirdPartyPlatformTokenV3Op
        {
            get
            {
                var opBuilder = new Operation.RetrieveUserThirdPartyPlatformTokenV3.RetrieveUserThirdPartyPlatformTokenV3Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AuthCodeRequestV3.AuthCodeRequestV3Builder AuthCodeRequestV3Op
        {
            get
            {
                var opBuilder = new Operation.AuthCodeRequestV3.AuthCodeRequestV3Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PlatformTokenGrantV3.PlatformTokenGrantV3Builder PlatformTokenGrantV3Op
        {
            get
            {
                var opBuilder = new Operation.PlatformTokenGrantV3.PlatformTokenGrantV3Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetRevocationListV3.GetRevocationListV3Builder GetRevocationListV3Op
        {
            get
            {
                var opBuilder = new Operation.GetRevocationListV3.GetRevocationListV3Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public TokenRevocationV3.TokenRevocationV3Builder TokenRevocationV3Op
        {
            get
            {
                var opBuilder = new Operation.TokenRevocationV3.TokenRevocationV3Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public SimultaneousLoginV3.SimultaneousLoginV3Builder SimultaneousLoginV3Op
        {
            get
            {
                var opBuilder = new Operation.SimultaneousLoginV3.SimultaneousLoginV3Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public TokenGrantV3.TokenGrantV3Builder TokenGrantV3Op
        {
            get
            {
                var opBuilder = new Operation.TokenGrantV3.TokenGrantV3Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public VerifyTokenV3.VerifyTokenV3Builder VerifyTokenV3Op
        {
            get
            {
                var opBuilder = new Operation.VerifyTokenV3.VerifyTokenV3Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

        public Model.OauthmodelTokenThirdPartyResponse? AdminRetrieveUserThirdPartyPlatformTokenV3(AdminRetrieveUserThirdPartyPlatformTokenV3 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.OauthmodelTokenThirdPartyResponse?> AdminRetrieveUserThirdPartyPlatformTokenV3Async(AdminRetrieveUserThirdPartyPlatformTokenV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void RevokeUserV3(RevokeUserV3 input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task RevokeUserV3Async(RevokeUserV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public string AuthorizeV3(AuthorizeV3 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<string> AuthorizeV3Async(AuthorizeV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.OauthmodelTokenIntrospectResponse? TokenIntrospectionV3(TokenIntrospectionV3 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.OauthmodelTokenIntrospectResponse?> TokenIntrospectionV3Async(TokenIntrospectionV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.OauthcommonJWKSet? GetJWKSV3(GetJWKSV3 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.OauthcommonJWKSet?> GetJWKSV3Async(GetJWKSV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void SendMFAAuthenticationCode(SendMFAAuthenticationCode input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task SendMFAAuthenticationCodeAsync(SendMFAAuthenticationCode input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void Change2faMethod(Change2faMethod input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task Change2faMethodAsync(Change2faMethod input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.OauthmodelTokenResponseV3? Verify2faCode(Verify2faCode input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.OauthmodelTokenResponseV3?> Verify2faCodeAsync(Verify2faCode input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.OauthmodelTokenThirdPartyResponse? RetrieveUserThirdPartyPlatformTokenV3(RetrieveUserThirdPartyPlatformTokenV3 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.OauthmodelTokenThirdPartyResponse?> RetrieveUserThirdPartyPlatformTokenV3Async(RetrieveUserThirdPartyPlatformTokenV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public string AuthCodeRequestV3(AuthCodeRequestV3 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<string> AuthCodeRequestV3Async(AuthCodeRequestV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.OauthmodelTokenResponse? PlatformTokenGrantV3(PlatformTokenGrantV3 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.OauthmodelTokenResponse?> PlatformTokenGrantV3Async(PlatformTokenGrantV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.OauthapiRevocationList? GetRevocationListV3(GetRevocationListV3 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.OauthapiRevocationList?> GetRevocationListV3Async(GetRevocationListV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void TokenRevocationV3(TokenRevocationV3 input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task TokenRevocationV3Async(TokenRevocationV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.OauthmodelTokenResponseV3? SimultaneousLoginV3(SimultaneousLoginV3 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.OauthmodelTokenResponseV3?> SimultaneousLoginV3Async(SimultaneousLoginV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.OauthmodelTokenWithDeviceCookieResponseV3? TokenGrantV3(TokenGrantV3 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.OauthmodelTokenWithDeviceCookieResponseV3?> TokenGrantV3Async(TokenGrantV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.OauthmodelTokenResponseV3? VerifyTokenV3(VerifyTokenV3 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.OauthmodelTokenResponseV3?> VerifyTokenV3Async(VerifyTokenV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}