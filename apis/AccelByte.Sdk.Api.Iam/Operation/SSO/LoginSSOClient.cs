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
    /// LoginSSOClient
    /// </summary>
    public class LoginSSOClient : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static LoginSSOClientBuilder Builder { get => new LoginSSOClientBuilder(); }

        public class LoginSSOClientBuilder
            : OperationBuilder<LoginSSOClientBuilder>
        {

            public string? Payload { get; set; }





            internal LoginSSOClientBuilder() { }

            internal LoginSSOClientBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public LoginSSOClientBuilder SetPayload(string _payload)
            {
                Payload = _payload;
                return this;
            }





            public LoginSSOClient Build(
                string platformId
            )
            {
                LoginSSOClient op = new LoginSSOClient(this,
                    platformId                    
                );

                op.SetBaseFields<LoginSSOClientBuilder>(this);
                return op;
            }

            public LoginSSOClient.Response Execute(
                string platformId
            )
            {
                LoginSSOClient op = Build(
                    platformId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<LoginSSOClient.Response> ExecuteAsync(
                string platformId
            )
            {
                LoginSSOClient op = Build(
                    platformId
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

        private LoginSSOClient(LoginSSOClientBuilder builder,
            string platformId
        )
        {
            PathParams["platformId"] = platformId;
            
            if (builder.Payload is not null) QueryParams["payload"] = builder.Payload;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {


            protected override string GetFullOperationId() => "Iam::SSO::LoginSSOClient";
        }

        #endregion

        public LoginSSOClient(
            string platformId,            
            string? payload            
        )
        {
            PathParams["platformId"] = platformId;
            
            if (payload is not null) QueryParams["payload"] = payload;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/sso/{platformId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public LoginSSOClient.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new LoginSSOClient.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };


            return response;
        }
    }

}