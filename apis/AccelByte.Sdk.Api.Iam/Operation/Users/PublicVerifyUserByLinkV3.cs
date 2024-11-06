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
    /// PublicVerifyUserByLinkV3
    /// </summary>
    public class PublicVerifyUserByLinkV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicVerifyUserByLinkV3Builder Builder { get => new PublicVerifyUserByLinkV3Builder(); }

        public class PublicVerifyUserByLinkV3Builder
            : OperationBuilder<PublicVerifyUserByLinkV3Builder>
        {

            public string? Code { get; set; }





            internal PublicVerifyUserByLinkV3Builder() { }

            internal PublicVerifyUserByLinkV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public PublicVerifyUserByLinkV3Builder SetCode(string _code)
            {
                Code = _code;
                return this;
            }





            public PublicVerifyUserByLinkV3 Build(
            )
            {
                PublicVerifyUserByLinkV3 op = new PublicVerifyUserByLinkV3(this
                );

                op.SetBaseFields<PublicVerifyUserByLinkV3Builder>(this);
                return op;
            }

            public PublicVerifyUserByLinkV3.Response Execute(
            )
            {
                PublicVerifyUserByLinkV3 op = Build(
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<PublicVerifyUserByLinkV3.Response> ExecuteAsync(
            )
            {
                PublicVerifyUserByLinkV3 op = Build(
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

        private PublicVerifyUserByLinkV3(PublicVerifyUserByLinkV3Builder builder
        )
        {
            
            if (builder.Code is not null) QueryParams["code"] = builder.Code;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<string>
        {

            public string Error302 { get; set; } = "";


            protected override string GetFullOperationId() => "Iam::Users::PublicVerifyUserByLinkV3";
        }

        #endregion

        public PublicVerifyUserByLinkV3(
            string? code            
        )
        {
            
            if (code is not null) QueryParams["code"] = code;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/public/users/verify_link/verify";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public PublicVerifyUserByLinkV3.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new PublicVerifyUserByLinkV3.Response()
            {
                StatusCode = code,
                ContentType = contentType
            };

            if (code == (HttpStatusCode)302)
            {
                response.Data = payload.ReadToString();
                response.IsSuccess = true;
            }

            return response;
        }
    }

}