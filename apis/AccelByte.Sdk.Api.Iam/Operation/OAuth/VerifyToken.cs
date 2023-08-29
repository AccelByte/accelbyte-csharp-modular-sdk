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
    /// VerifyToken
    ///
    /// 
    /// 
    /// ## The endpoint is going to be deprecated
    /// 
    /// 
    /// This endpoint requires all requests to have Authorization header set with Basic access authentication constructed from client id and client secret.
    /// Endpoint migration guide
    /// 
    /// 
    ///           * Substitute endpoint: /iam/v3/oauth/verify [POST]
    /// 
    /// 
    ///           * Note: difference in V3 response:
    ///     1. format differenceï¼Pascal case => Camel case): permissions field from Action => action, Resource => resource
    /// </summary>
    [Obsolete(DiagnosticId ="ab_deprecated_operation")]
    public class VerifyToken : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static VerifyTokenBuilder Builder { get => new VerifyTokenBuilder(); }

        public class VerifyTokenBuilder
            : OperationBuilder<VerifyTokenBuilder>
        {





            internal VerifyTokenBuilder() { }

            internal VerifyTokenBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public VerifyToken Build(
                string token
            )
            {
                VerifyToken op = new VerifyToken(this,
                    token                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
            public Model.OauthmodelTokenResponse? Execute(
                string token
            )
            {
                VerifyToken op = Build(
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

        private VerifyToken(VerifyTokenBuilder builder,
            string token
        )
        {
            
            
            if (token is not null) FormParams["token"] = token;

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BASIC);
        }
        #endregion

        public VerifyToken(
            string token            
        )
        {
            
            
            if (token is not null) FormParams["token"] = token;

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BASIC);
        }

        public override string Path => "/iam/oauth/verify";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/x-www-form-urlencoded" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.OauthmodelTokenResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.OauthmodelTokenResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.OauthmodelTokenResponse>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}