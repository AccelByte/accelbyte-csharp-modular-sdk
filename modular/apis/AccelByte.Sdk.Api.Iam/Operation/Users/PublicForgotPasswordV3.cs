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
    /// PublicForgotPasswordV3
    ///
    /// 
    /// 
    ///  Special note for publisher-game scenario:
    /// Game Client should provide game namespace path parameter and Publisher
    /// Client should provide publisher namespace path parameter.
    /// 
    /// 
    /// 
    /// 
    /// The password reset code will be sent to the publisher account's email address.
    /// 
    /// 
    /// 
    /// 
    /// action code : 10104
    /// </summary>
    public class PublicForgotPasswordV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicForgotPasswordV3Builder Builder { get => new PublicForgotPasswordV3Builder(); }

        public class PublicForgotPasswordV3Builder
            : OperationBuilder<PublicForgotPasswordV3Builder>
        {





            internal PublicForgotPasswordV3Builder() { }

            internal PublicForgotPasswordV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicForgotPasswordV3 Build(
                ModelForgotPasswordRequestV3 body,
                string namespace_
            )
            {
                PublicForgotPasswordV3 op = new PublicForgotPasswordV3(this,
                    body,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public void Execute(
                ModelForgotPasswordRequestV3 body,
                string namespace_
            )
            {
                PublicForgotPasswordV3 op = Build(
                    body,
                    namespace_
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

        private PublicForgotPasswordV3(PublicForgotPasswordV3Builder builder,
            ModelForgotPasswordRequestV3 body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicForgotPasswordV3(
            string namespace_,            
            Model.ModelForgotPasswordRequestV3 body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/users/forgot";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

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