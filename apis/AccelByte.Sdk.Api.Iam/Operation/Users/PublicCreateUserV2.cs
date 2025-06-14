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
    /// PublicCreateUserV2
    ///
    /// ## The endpoint is going to be deprecated
    /// **Endpoint migration guide**
    /// - **Substitute endpoint: _/iam/v3/public/namespaces/{namespace}/users [POST]_**
    /// - **Substitute endpoint: _/iam/v4/public/namespaces/{namespace}/users [POST]_**
    /// - **Note:**
    /// 1. v3 & v4 introduce optional verification code
    /// 2. format differenceï¼Pascal case => Camel case)
    /// 
    /// Available Authentication Types:
    /// 1. *EMAILPASSWD*: an authentication type used for new user registration through email.
    /// Country use ISO3166-1 alpha-2 two letter, e.g. US.
    /// </summary>
    [Obsolete(DiagnosticId ="ab_deprecated_operation")]
    public class PublicCreateUserV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicCreateUserV2Builder Builder { get => new PublicCreateUserV2Builder(); }

        public class PublicCreateUserV2Builder
            : OperationBuilder<PublicCreateUserV2Builder>
        {





            internal PublicCreateUserV2Builder() { }

            internal PublicCreateUserV2Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicCreateUserV2 Build(
                ModelUserCreateRequest body,
                string namespace_
            )
            {
                PublicCreateUserV2 op = new PublicCreateUserV2(this,
                    body,                    
                    namespace_                    
                );

                op.SetBaseFields<PublicCreateUserV2Builder>(this);
                return op;
            }

            [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
            public PublicCreateUserV2.Response Execute(
                ModelUserCreateRequest body,
                string namespace_
            )
            {
                PublicCreateUserV2 op = Build(
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
            public async Task<PublicCreateUserV2.Response> ExecuteAsync(
                ModelUserCreateRequest body,
                string namespace_
            )
            {
                PublicCreateUserV2 op = Build(
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

        private PublicCreateUserV2(PublicCreateUserV2Builder builder,
            ModelUserCreateRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelUserCreateResponse>
        {

            public RestErrorResponse? Error400 { get; set; } = null;

            public RestErrorResponse? Error401 { get; set; } = null;

            public RestErrorResponse? Error403 { get; set; } = null;

            public string Error409 { get; set; } = "";


            protected override string GetFullOperationId() => "Iam::Users::PublicCreateUserV2";
        }

        #endregion

        public PublicCreateUserV2(
            string namespace_,            
            Model.ModelUserCreateRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v2/public/namespaces/{namespace}/users";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public PublicCreateUserV2.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new PublicCreateUserV2.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelUserCreateResponse>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
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
            else if (code == (HttpStatusCode)409)
            {
                response.Error409 = payload.ReadToString();
                response.Error = new ApiError("-1", response.Error409!);
            }

            return response;
        }
    }

}