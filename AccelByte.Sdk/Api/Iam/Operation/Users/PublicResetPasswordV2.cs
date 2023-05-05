// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// PublicResetPasswordV2
    ///
    /// 
    /// 
    /// ## The endpoint is going to be deprecated
    /// 
    /// 
    /// Endpoint migration guide
    /// 
    /// 
    ///             * Substitute endpoint: /iam/v3/public/namespaces/{namespace}/users/reset [POST]
    /// </summary>
    [Obsolete(DiagnosticId ="ab_deprecated_operation")]
    public class PublicResetPasswordV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicResetPasswordV2Builder Builder { get => new PublicResetPasswordV2Builder(); }

        public class PublicResetPasswordV2Builder
            : OperationBuilder<PublicResetPasswordV2Builder>
        {





            internal PublicResetPasswordV2Builder() { }






            public PublicResetPasswordV2 Build(
                ModelResetPasswordRequest body,
                string namespace_
            )
            {
                PublicResetPasswordV2 op = new PublicResetPasswordV2(this,
                    body,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicResetPasswordV2(PublicResetPasswordV2Builder builder,
            ModelResetPasswordRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicResetPasswordV2(
            string namespace_,            
            Model.ModelResetPasswordRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v2/public/namespaces/{namespace}/users/resetPassword";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}