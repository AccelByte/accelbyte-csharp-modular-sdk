// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;

namespace AccelByte.Sdk.Api.Iam.Wrapper
{
    public class OAuth20Extension
    {
        private readonly IAccelByteSdk _sdk;

        public OAuth20Extension(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public UserAuthenticationV3.UserAuthenticationV3Builder UserAuthenticationV3Op
        {
            get { return new Operation.UserAuthenticationV3.UserAuthenticationV3Builder(_sdk); }
        }
        public AuthenticationWithPlatformLinkV3.AuthenticationWithPlatformLinkV3Builder AuthenticationWithPlatformLinkV3Op
        {
            get { return new Operation.AuthenticationWithPlatformLinkV3.AuthenticationWithPlatformLinkV3Builder(_sdk); }
        }
        public GenerateTokenByNewHeadlessAccountV3.GenerateTokenByNewHeadlessAccountV3Builder GenerateTokenByNewHeadlessAccountV3Op
        {
            get { return new Operation.GenerateTokenByNewHeadlessAccountV3.GenerateTokenByNewHeadlessAccountV3Builder(_sdk); }
        }
        public RequestOneTimeLinkingCodeV3.RequestOneTimeLinkingCodeV3Builder RequestOneTimeLinkingCodeV3Op
        {
            get { return new Operation.RequestOneTimeLinkingCodeV3.RequestOneTimeLinkingCodeV3Builder(_sdk); }
        }
        public ValidateOneTimeLinkingCodeV3.ValidateOneTimeLinkingCodeV3Builder ValidateOneTimeLinkingCodeV3Op
        {
            get { return new Operation.ValidateOneTimeLinkingCodeV3.ValidateOneTimeLinkingCodeV3Builder(_sdk); }
        }
        public RequestTokenByOneTimeLinkCodeResponseV3.RequestTokenByOneTimeLinkCodeResponseV3Builder RequestTokenByOneTimeLinkCodeResponseV3Op
        {
            get { return new Operation.RequestTokenByOneTimeLinkCodeResponseV3.RequestTokenByOneTimeLinkCodeResponseV3Builder(_sdk); }
        }
        public GetCountryLocationV3.GetCountryLocationV3Builder GetCountryLocationV3Op
        {
            get { return new Operation.GetCountryLocationV3.GetCountryLocationV3Builder(_sdk); }
        }
        public Logout.LogoutBuilder LogoutOp
        {
            get { return new Operation.Logout.LogoutBuilder(_sdk); }
        }
        public RequestGameTokenCodeResponseV3.RequestGameTokenCodeResponseV3Builder RequestGameTokenCodeResponseV3Op
        {
            get { return new Operation.RequestGameTokenCodeResponseV3.RequestGameTokenCodeResponseV3Builder(_sdk); }
        }
        public PlatformAuthenticationV3.PlatformAuthenticationV3Builder PlatformAuthenticationV3Op
        {
            get { return new Operation.PlatformAuthenticationV3.PlatformAuthenticationV3Builder(_sdk); }
        }
        public RequestGameTokenResponseV3.RequestGameTokenResponseV3Builder RequestGameTokenResponseV3Op
        {
            get { return new Operation.RequestGameTokenResponseV3.RequestGameTokenResponseV3Builder(_sdk); }
        }
        #endregion
        
        public string UserAuthenticationV3(UserAuthenticationV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.OauthmodelTokenResponseV3? AuthenticationWithPlatformLinkV3(AuthenticationWithPlatformLinkV3 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.OauthmodelTokenResponseV3? GenerateTokenByNewHeadlessAccountV3(GenerateTokenByNewHeadlessAccountV3 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.OauthmodelOneTimeLinkingCodeResponse? RequestOneTimeLinkingCodeV3(RequestOneTimeLinkingCodeV3 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.OauthmodelOneTimeLinkingCodeValidationResponse? ValidateOneTimeLinkingCodeV3(ValidateOneTimeLinkingCodeV3 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.OauthmodelTokenResponseV3? RequestTokenByOneTimeLinkCodeResponseV3(RequestTokenByOneTimeLinkCodeResponseV3 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.OauthmodelCountryLocationResponse? GetCountryLocationV3(GetCountryLocationV3 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void Logout(Logout input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.OauthmodelGameTokenCodeResponse? RequestGameTokenCodeResponseV3(RequestGameTokenCodeResponseV3 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public string PlatformAuthenticationV3(PlatformAuthenticationV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.OauthmodelTokenResponseV3? RequestGameTokenResponseV3(RequestGameTokenResponseV3 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}