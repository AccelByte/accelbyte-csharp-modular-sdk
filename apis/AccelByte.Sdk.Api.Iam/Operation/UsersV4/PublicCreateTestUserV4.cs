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
    /// PublicCreateTestUserV4
    ///
    /// Create a test user and not send verification code email
    /// **Required attributes:**
    /// - verified: this new user is verified or not
    /// - authType: possible value is EMAILPASSWD
    /// - emailAddress: Please refer to the rule from /v3/public/inputValidations API.
    /// - username: Please refer to the rule from /v3/public/inputValidations API.
    /// - password: Please refer to the rule from /v3/public/inputValidations API.
    /// - country: ISO3166-1 alpha-2 two letter, e.g. US.
    /// - dateOfBirth: YYYY-MM-DD, e.g. 1990-01-01. valid values are between 1905-01-01 until current date.
    /// 
    /// **Not required attributes:**
    /// - displayName: Please refer to the rule from /v3/public/inputValidations API.
    /// 
    /// This endpoint support accepting agreements for the created user. Supply the accepted agreements in acceptedPolicies attribute.
    /// </summary>
    public class PublicCreateTestUserV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicCreateTestUserV4Builder Builder { get => new PublicCreateTestUserV4Builder(); }

        public class PublicCreateTestUserV4Builder
            : OperationBuilder<PublicCreateTestUserV4Builder>
        {





            internal PublicCreateTestUserV4Builder() { }

            internal PublicCreateTestUserV4Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicCreateTestUserV4 Build(
                AccountCreateTestUserRequestV4 body,
                string namespace_
            )
            {
                PublicCreateTestUserV4 op = new PublicCreateTestUserV4(this,
                    body,                    
                    namespace_                    
                );

                op.SetBaseFields<PublicCreateTestUserV4Builder>(this);
                return op;
            }

            public PublicCreateTestUserV4.Response Execute(
                AccountCreateTestUserRequestV4 body,
                string namespace_
            )
            {
                PublicCreateTestUserV4 op = Build(
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
            public async Task<PublicCreateTestUserV4.Response> ExecuteAsync(
                AccountCreateTestUserRequestV4 body,
                string namespace_
            )
            {
                PublicCreateTestUserV4 op = Build(
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

        private PublicCreateTestUserV4(PublicCreateTestUserV4Builder builder,
            AccountCreateTestUserRequestV4 body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.AccountCreateUserResponseV4>
        {

            public RestErrorResponse? Error400 { get; set; } = null;

            public RestErrorResponse? Error404 { get; set; } = null;

            public RestErrorResponse? Error409 { get; set; } = null;

            public RestErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Iam::UsersV4::PublicCreateTestUserV4";
        }

        #endregion

        public PublicCreateTestUserV4(
            string namespace_,            
            Model.AccountCreateTestUserRequestV4 body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/public/namespaces/{namespace}/test_users";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public PublicCreateTestUserV4.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new PublicCreateTestUserV4.Response()
            {
                StatusCode = code,
                ContentType = contentType
            };

            if (code == (HttpStatusCode)204)
            {
                response.IsSuccess = true;
            }
            else if ((code == (HttpStatusCode)201) || (code == (HttpStatusCode)202) || (code == (HttpStatusCode)200))
            {
                response.Data = JsonSerializer.Deserialize<Model.AccountCreateUserResponseV4>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)409)
            {
                response.Error409 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error409!.TranslateToApiError();
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