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
    /// PublicSendRegistrationCode
    ///
    /// This endpoint will validate the request's email address.
    /// If it already been used, will response 409.
    /// If it is available, we will send a verification code to this email address.
    /// This code can be verified by this [endpoint](#operations-Users-PublicVerifyRegistrationCode).
    /// </summary>
    public class PublicSendRegistrationCode : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicSendRegistrationCodeBuilder Builder { get => new PublicSendRegistrationCodeBuilder(); }

        public class PublicSendRegistrationCodeBuilder
            : OperationBuilder<PublicSendRegistrationCodeBuilder>
        {





            internal PublicSendRegistrationCodeBuilder() { }

            internal PublicSendRegistrationCodeBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicSendRegistrationCode Build(
                ModelSendRegisterVerificationCodeRequest body,
                string namespace_
            )
            {
                PublicSendRegistrationCode op = new PublicSendRegistrationCode(this,
                    body,                    
                    namespace_                    
                );

                op.SetBaseFields<PublicSendRegistrationCodeBuilder>(this);
                return op;
            }

            public PublicSendRegistrationCode.Response Execute(
                ModelSendRegisterVerificationCodeRequest body,
                string namespace_
            )
            {
                PublicSendRegistrationCode op = Build(
                    body,
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<PublicSendRegistrationCode.Response> ExecuteAsync(
                ModelSendRegisterVerificationCodeRequest body,
                string namespace_
            )
            {
                PublicSendRegistrationCode op = Build(
                    body,
                    namespace_
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

        private PublicSendRegistrationCode(PublicSendRegistrationCodeBuilder builder,
            ModelSendRegisterVerificationCodeRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {

            public RestErrorResponse? Error400 { get; set; } = null;

            public RestErrorResponse? Error409 { get; set; } = null;

            public RestErrorResponse? Error429 { get; set; } = null;


            protected override string GetFullOperationId() => "Iam::Users::PublicSendRegistrationCode";
        }

        #endregion

        public PublicSendRegistrationCode(
            string namespace_,            
            Model.ModelSendRegisterVerificationCodeRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/users/code/request";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public PublicSendRegistrationCode.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new PublicSendRegistrationCode.Response()
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