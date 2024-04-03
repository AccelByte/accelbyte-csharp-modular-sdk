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
    public class OAuth20V4
    {
        private readonly IAccelByteSdk _sdk;

        public OAuth20V4(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AuthenticationWithPlatformLinkV4.AuthenticationWithPlatformLinkV4Builder AuthenticationWithPlatformLinkV4Op
        {
            get { return new Operation.AuthenticationWithPlatformLinkV4.AuthenticationWithPlatformLinkV4Builder(_sdk); }
        }
        public GenerateTokenByNewHeadlessAccountV4.GenerateTokenByNewHeadlessAccountV4Builder GenerateTokenByNewHeadlessAccountV4Op
        {
            get { return new Operation.GenerateTokenByNewHeadlessAccountV4.GenerateTokenByNewHeadlessAccountV4Builder(_sdk); }
        }
        public Verify2faCodeV4.Verify2faCodeV4Builder Verify2faCodeV4Op
        {
            get { return new Operation.Verify2faCodeV4.Verify2faCodeV4Builder(_sdk); }
        }
        public PlatformTokenGrantV4.PlatformTokenGrantV4Builder PlatformTokenGrantV4Op
        {
            get { return new Operation.PlatformTokenGrantV4.PlatformTokenGrantV4Builder(_sdk); }
        }
        public SimultaneousLoginV4.SimultaneousLoginV4Builder SimultaneousLoginV4Op
        {
            get { return new Operation.SimultaneousLoginV4.SimultaneousLoginV4Builder(_sdk); }
        }
        public TokenGrantV4.TokenGrantV4Builder TokenGrantV4Op
        {
            get { return new Operation.TokenGrantV4.TokenGrantV4Builder(_sdk); }
        }
        public RequestTargetTokenResponseV4.RequestTargetTokenResponseV4Builder RequestTargetTokenResponseV4Op
        {
            get { return new Operation.RequestTargetTokenResponseV4.RequestTargetTokenResponseV4Builder(_sdk); }
        }
        #endregion

        public Model.OauthmodelTokenResponseV3? AuthenticationWithPlatformLinkV4(AuthenticationWithPlatformLinkV4 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.OauthmodelTokenResponseV3?> AuthenticationWithPlatformLinkV4Async(AuthenticationWithPlatformLinkV4 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.OauthmodelTokenResponseV3? GenerateTokenByNewHeadlessAccountV4(GenerateTokenByNewHeadlessAccountV4 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.OauthmodelTokenResponseV3?> GenerateTokenByNewHeadlessAccountV4Async(GenerateTokenByNewHeadlessAccountV4 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.OauthmodelTokenResponseV3? Verify2faCodeV4(Verify2faCodeV4 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.OauthmodelTokenResponseV3?> Verify2faCodeV4Async(Verify2faCodeV4 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.OauthmodelTokenResponseV3? PlatformTokenGrantV4(PlatformTokenGrantV4 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.OauthmodelTokenResponseV3?> PlatformTokenGrantV4Async(PlatformTokenGrantV4 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.OauthmodelTokenResponseV3? SimultaneousLoginV4(SimultaneousLoginV4 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.OauthmodelTokenResponseV3?> SimultaneousLoginV4Async(SimultaneousLoginV4 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.OauthmodelTokenWithDeviceCookieResponseV3? TokenGrantV4(TokenGrantV4 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.OauthmodelTokenWithDeviceCookieResponseV3?> TokenGrantV4Async(TokenGrantV4 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.OauthmodelTokenResponseV3? RequestTargetTokenResponseV4(RequestTargetTokenResponseV4 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.OauthmodelTokenResponseV3?> RequestTargetTokenResponseV4Async(RequestTargetTokenResponseV4 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}