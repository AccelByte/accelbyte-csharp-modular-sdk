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
    /// LogoutSSOClient
    ///
    /// Logout user's session on platform that logged in using SSO.
    /// 
    /// Supported platforms:
    /// - discourse
    /// </summary>
    public class LogoutSSOClient : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static LogoutSSOClientBuilder Builder { get => new LogoutSSOClientBuilder(); }

        public class LogoutSSOClientBuilder
            : OperationBuilder<LogoutSSOClientBuilder>
        {





            internal LogoutSSOClientBuilder() { }

            internal LogoutSSOClientBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public LogoutSSOClient Build(
                string platformId
            )
            {
                LogoutSSOClient op = new LogoutSSOClient(this,
                    platformId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public void Execute(
                string platformId
            )
            {
                LogoutSSOClient op = Build(
                    platformId
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

        private LogoutSSOClient(LogoutSSOClientBuilder builder,
            string platformId
        )
        {
            PathParams["platformId"] = platformId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public LogoutSSOClient(
            string platformId            
        )
        {
            PathParams["platformId"] = platformId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/sso/{platformId}/logout";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() {  };

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