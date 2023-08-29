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
    /// TokenIntrospectionV3
    ///
    /// 
    /// 
    /// This endpoint returns information about an access token intended to be used by resource servers or other internal servers.
    /// 
    /// 
    /// 
    /// 
    /// This endpoint requires authorized requests header with valid basic or bearer token.
    /// 
    /// 
    /// 
    /// 
    /// action code : 10705
    /// </summary>
    public class TokenIntrospectionV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static TokenIntrospectionV3Builder Builder { get => new TokenIntrospectionV3Builder(); }

        public class TokenIntrospectionV3Builder
            : OperationBuilder<TokenIntrospectionV3Builder>
        {





            internal TokenIntrospectionV3Builder() { }

            internal TokenIntrospectionV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public TokenIntrospectionV3 Build(
                string token
            )
            {
                TokenIntrospectionV3 op = new TokenIntrospectionV3(this,
                    token                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.OauthmodelTokenIntrospectResponse? Execute(
                string token
            )
            {
                TokenIntrospectionV3 op = Build(
                    token
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

        private TokenIntrospectionV3(TokenIntrospectionV3Builder builder,
            string token
        )
        {
            
            
            if (token is not null) FormParams["token"] = token;

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BASIC);
        }
        #endregion

        public TokenIntrospectionV3(
            string token            
        )
        {
            
            
            if (token is not null) FormParams["token"] = token;

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BASIC);
        }

        public override string Path => "/iam/v3/oauth/introspect";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/x-www-form-urlencoded" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.OauthmodelTokenIntrospectResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.OauthmodelTokenIntrospectResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.OauthmodelTokenIntrospectResponse>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}