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
    /// PublicRemoveTrustedDeviceV4
    ///
    /// 
    /// 
    /// (Only for test)This endpoint is used to remove trusted device.
    /// 
    /// 
    /// 
    /// 
    /// This endpoint Requires valid user access token
    /// 
    /// 
    /// 
    /// 
    /// 
    /// This endpoint Requires device_token in cookie
    /// </summary>
    public class PublicRemoveTrustedDeviceV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicRemoveTrustedDeviceV4Builder Builder { get => new PublicRemoveTrustedDeviceV4Builder(); }

        public class PublicRemoveTrustedDeviceV4Builder
            : OperationBuilder<PublicRemoveTrustedDeviceV4Builder>
        {





            internal PublicRemoveTrustedDeviceV4Builder() { }






            public PublicRemoveTrustedDeviceV4 Build(
                string namespace_,
                string deviceToken            )
            {
                PublicRemoveTrustedDeviceV4 op = new PublicRemoveTrustedDeviceV4(this,
                    namespace_,                    
                    deviceToken
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicRemoveTrustedDeviceV4(PublicRemoveTrustedDeviceV4Builder builder,
            string namespace_,
            string deviceToken            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            Cookies["device_token"] = deviceToken;
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicRemoveTrustedDeviceV4(
            string namespace_,            
            string deviceToken
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            Cookies["device_token"] = deviceToken;
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/public/namespaces/{namespace}/users/me/mfa/device";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] {  };

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