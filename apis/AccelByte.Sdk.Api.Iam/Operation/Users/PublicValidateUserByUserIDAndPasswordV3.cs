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
    /// PublicValidateUserByUserIDAndPasswordV3
    ///
    /// This endpoint is used to validate the user password.
    /// This endpoint validate the user password by specifying the userId and password.
    /// 
    /// 
    /// **Authentication:**
    /// The _**userId**_ parameter should match the one in the access token.
    /// </summary>
    public class PublicValidateUserByUserIDAndPasswordV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicValidateUserByUserIDAndPasswordV3Builder Builder { get => new PublicValidateUserByUserIDAndPasswordV3Builder(); }

        public class PublicValidateUserByUserIDAndPasswordV3Builder
            : OperationBuilder<PublicValidateUserByUserIDAndPasswordV3Builder>
        {





            internal PublicValidateUserByUserIDAndPasswordV3Builder() { }

            internal PublicValidateUserByUserIDAndPasswordV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicValidateUserByUserIDAndPasswordV3 Build(
                string password,
                string namespace_,
                string userId
            )
            {
                PublicValidateUserByUserIDAndPasswordV3 op = new PublicValidateUserByUserIDAndPasswordV3(this,
                    password,                    
                    namespace_,                    
                    userId                    
                );

                op.SetBaseFields<PublicValidateUserByUserIDAndPasswordV3Builder>(this);
                return op;
            }

            public PublicValidateUserByUserIDAndPasswordV3.Response Execute(
                string password,
                string namespace_,
                string userId
            )
            {
                PublicValidateUserByUserIDAndPasswordV3 op = Build(
                    password,
                    namespace_,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<PublicValidateUserByUserIDAndPasswordV3.Response> ExecuteAsync(
                string password,
                string namespace_,
                string userId
            )
            {
                PublicValidateUserByUserIDAndPasswordV3 op = Build(
                    password,
                    namespace_,
                    userId
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

        private PublicValidateUserByUserIDAndPasswordV3(PublicValidateUserByUserIDAndPasswordV3Builder builder,
            string password,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            if (password is not null) FormParams["password"] = password;

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {

            public RestErrorResponse? Error400 { get; set; } = null;

            public RestErrorResponse? Error401 { get; set; } = null;

            public RestErrorResponse? Error403 { get; set; } = null;

            public RestErrorResponse? Error404 { get; set; } = null;

            public RestErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Iam::Users::PublicValidateUserByUserIDAndPasswordV3";
        }

        #endregion

        public PublicValidateUserByUserIDAndPasswordV3(
            string namespace_,            
            string userId,            
            string password            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            if (password is not null) FormParams["password"] = password;

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/users/{userId}/validate";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/x-www-form-urlencoded" };

        public override List<string> Produces => new() { "application/json" };
        
        public PublicValidateUserByUserIDAndPasswordV3.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new PublicValidateUserByUserIDAndPasswordV3.Response()
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
            else if (code == (HttpStatusCode)403)
            
            {
                response.Error403 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)
            
            {
                response.Error404 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            
            {
                response.Error500 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}