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

        public AdminRetrieveUserThirdPartyPlatformTokenV3.Response AdminRetrieveUserThirdPartyPlatformTokenV3(AdminRetrieveUserThirdPartyPlatformTokenV3 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminRetrieveUserThirdPartyPlatformTokenV3.Response> AdminRetrieveUserThirdPartyPlatformTokenV3Async(AdminRetrieveUserThirdPartyPlatformTokenV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public RevokeUserV3.Response RevokeUserV3(RevokeUserV3 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<RevokeUserV3.Response> RevokeUserV3Async(RevokeUserV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AuthorizeV3.Response AuthorizeV3(AuthorizeV3 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AuthorizeV3.Response> AuthorizeV3Async(AuthorizeV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public TokenIntrospectionV3.Response TokenIntrospectionV3(TokenIntrospectionV3 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<TokenIntrospectionV3.Response> TokenIntrospectionV3Async(TokenIntrospectionV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public GetJWKSV3.Response GetJWKSV3(GetJWKSV3 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetJWKSV3.Response> GetJWKSV3Async(GetJWKSV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public SendMFAAuthenticationCode.Response SendMFAAuthenticationCode(SendMFAAuthenticationCode input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<SendMFAAuthenticationCode.Response> SendMFAAuthenticationCodeAsync(SendMFAAuthenticationCode input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Change2faMethod.Response Change2faMethod(Change2faMethod input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Change2faMethod.Response> Change2faMethodAsync(Change2faMethod input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Verify2faCode.Response Verify2faCode(Verify2faCode input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Verify2faCode.Response> Verify2faCodeAsync(Verify2faCode input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public RetrieveUserThirdPartyPlatformTokenV3.Response RetrieveUserThirdPartyPlatformTokenV3(RetrieveUserThirdPartyPlatformTokenV3 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<RetrieveUserThirdPartyPlatformTokenV3.Response> RetrieveUserThirdPartyPlatformTokenV3Async(RetrieveUserThirdPartyPlatformTokenV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AuthCodeRequestV3.Response AuthCodeRequestV3(AuthCodeRequestV3 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AuthCodeRequestV3.Response> AuthCodeRequestV3Async(AuthCodeRequestV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public PlatformTokenGrantV3.Response PlatformTokenGrantV3(PlatformTokenGrantV3 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PlatformTokenGrantV3.Response> PlatformTokenGrantV3Async(PlatformTokenGrantV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public GetRevocationListV3.Response GetRevocationListV3(GetRevocationListV3 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetRevocationListV3.Response> GetRevocationListV3Async(GetRevocationListV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public TokenRevocationV3.Response TokenRevocationV3(TokenRevocationV3 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<TokenRevocationV3.Response> TokenRevocationV3Async(TokenRevocationV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public SimultaneousLoginV3.Response SimultaneousLoginV3(SimultaneousLoginV3 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<SimultaneousLoginV3.Response> SimultaneousLoginV3Async(SimultaneousLoginV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public TokenGrantV3.Response TokenGrantV3(TokenGrantV3 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<TokenGrantV3.Response> TokenGrantV3Async(TokenGrantV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public VerifyTokenV3.Response VerifyTokenV3(VerifyTokenV3 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<VerifyTokenV3.Response> VerifyTokenV3Async(VerifyTokenV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}