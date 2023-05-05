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
    /// AdminMakeFactorMyDefaultV4
    ///
    /// 
    /// 
    /// This endpoint is used to make 2FA factor default.
    /// 
    /// 
    /// 
    /// 
    /// This endpoint Requires valid user access token
    /// </summary>
    public class AdminMakeFactorMyDefaultV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminMakeFactorMyDefaultV4Builder Builder { get => new AdminMakeFactorMyDefaultV4Builder(); }

        public class AdminMakeFactorMyDefaultV4Builder
            : OperationBuilder<AdminMakeFactorMyDefaultV4Builder>
        {





            internal AdminMakeFactorMyDefaultV4Builder() { }

            internal AdminMakeFactorMyDefaultV4Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminMakeFactorMyDefaultV4 Build(
                string factor
            )
            {
                AdminMakeFactorMyDefaultV4 op = new AdminMakeFactorMyDefaultV4(this,
                    factor                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public void Execute(
                string factor
            )
            {
                AdminMakeFactorMyDefaultV4 op = Build(
                    factor
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

        private AdminMakeFactorMyDefaultV4(AdminMakeFactorMyDefaultV4Builder builder,
            string factor
        )
        {
            
            
            if (factor is not null) FormParams["factor"] = factor;

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminMakeFactorMyDefaultV4(
            string factor            
        )
        {
            
            
            if (factor is not null) FormParams["factor"] = factor;

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/admin/users/me/mfa/factor";

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