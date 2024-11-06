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
    /// PublicSendVerificationLinkV3
    ///
    /// The verification link is sent to email address
    /// It will not send request if user email is already verified
    /// </summary>
    public class PublicSendVerificationLinkV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicSendVerificationLinkV3Builder Builder { get => new PublicSendVerificationLinkV3Builder(); }

        public class PublicSendVerificationLinkV3Builder
            : OperationBuilder<PublicSendVerificationLinkV3Builder>
        {





            internal PublicSendVerificationLinkV3Builder() { }

            internal PublicSendVerificationLinkV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicSendVerificationLinkV3 Build(
                ModelSendVerificationLinkRequest body
            )
            {
                PublicSendVerificationLinkV3 op = new PublicSendVerificationLinkV3(this,
                    body                    
                );

                op.SetBaseFields<PublicSendVerificationLinkV3Builder>(this);
                return op;
            }

            public PublicSendVerificationLinkV3.Response Execute(
                ModelSendVerificationLinkRequest body
            )
            {
                PublicSendVerificationLinkV3 op = Build(
                    body
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<PublicSendVerificationLinkV3.Response> ExecuteAsync(
                ModelSendVerificationLinkRequest body
            )
            {
                PublicSendVerificationLinkV3 op = Build(
                    body
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

        private PublicSendVerificationLinkV3(PublicSendVerificationLinkV3Builder builder,
            ModelSendVerificationLinkRequest body
        )
        {
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {

            public RestErrorResponse? Error400 { get; set; } = null;

            public RestErrorResponse? Error401 { get; set; } = null;

            public RestErrorResponse? Error409 { get; set; } = null;

            public RestErrorResponse? Error429 { get; set; } = null;


            protected override string GetFullOperationId() => "Iam::Users::PublicSendVerificationLinkV3";
        }

        #endregion

        public PublicSendVerificationLinkV3(
            Model.ModelSendVerificationLinkRequest body            
        )
        {
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/public/users/me/verify_link/request";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public PublicSendVerificationLinkV3.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new PublicSendVerificationLinkV3.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };

            if (code == (HttpStatusCode)400)
            
            {
                response.Error400 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            
            {
                response.Error401 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)409)
            
            {
                response.Error409 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error409!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)429)
            
            {
                response.Error429 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error429!.TranslateToApiError();
            }

            return response;
        }
    }

}