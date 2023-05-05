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
    /// AdminEnableMyAuthenticatorV4
    ///
    /// 
    /// 
    /// This endpoint is used to enable 2FA authenticator.
    /// 
    /// 
    /// 
    /// 
    /// This endpoint Requires valid user access token
    /// </summary>
    public class AdminEnableMyAuthenticatorV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminEnableMyAuthenticatorV4Builder Builder { get => new AdminEnableMyAuthenticatorV4Builder(); }

        public class AdminEnableMyAuthenticatorV4Builder
            : OperationBuilder<AdminEnableMyAuthenticatorV4Builder>
        {



            public string? Code { get; set; }



            internal AdminEnableMyAuthenticatorV4Builder() { }

            internal AdminEnableMyAuthenticatorV4Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }




            public AdminEnableMyAuthenticatorV4Builder SetCode(string _code)
            {
                Code = _code;
                return this;
            }



            public AdminEnableMyAuthenticatorV4 Build(
            )
            {
                AdminEnableMyAuthenticatorV4 op = new AdminEnableMyAuthenticatorV4(this
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public void Execute(
            )
            {
                AdminEnableMyAuthenticatorV4 op = Build(
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

        private AdminEnableMyAuthenticatorV4(AdminEnableMyAuthenticatorV4Builder builder
        )
        {
            
            
            if (builder.Code is not null) FormParams["code"] = builder.Code;

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminEnableMyAuthenticatorV4(
            string? code            
        )
        {
            
            
            if (code is not null) FormParams["code"] = code;

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/admin/users/me/mfa/authenticator/enable";

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