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
    /// PublicUpdatePasswordV2
    ///
    /// ## The endpoint is going to be deprecated
    /// **Endpoint migration guide**
    /// - **Substitute endpoint: _/iam/v3/public/namespaces/{namespace}/users/me/password [PUT]_**
    /// </summary>
    [Obsolete(DiagnosticId ="ab_deprecated_operation")]
    public class PublicUpdatePasswordV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicUpdatePasswordV2Builder Builder { get => new PublicUpdatePasswordV2Builder(); }

        public class PublicUpdatePasswordV2Builder
            : OperationBuilder<PublicUpdatePasswordV2Builder>
        {





            internal PublicUpdatePasswordV2Builder() { }

            internal PublicUpdatePasswordV2Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicUpdatePasswordV2 Build(
                ModelUserPasswordUpdateRequest body,
                string namespace_,
                string userId
            )
            {
                PublicUpdatePasswordV2 op = new PublicUpdatePasswordV2(this,
                    body,                    
                    namespace_,                    
                    userId                    
                );

                op.SetBaseFields<PublicUpdatePasswordV2Builder>(this);
                return op;
            }

            [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
            public PublicUpdatePasswordV2.Response Execute(
                ModelUserPasswordUpdateRequest body,
                string namespace_,
                string userId
            )
            {
                PublicUpdatePasswordV2 op = Build(
                    body,
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
            public async Task<PublicUpdatePasswordV2.Response> ExecuteAsync(
                ModelUserPasswordUpdateRequest body,
                string namespace_,
                string userId
            )
            {
                PublicUpdatePasswordV2 op = Build(
                    body,
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

        private PublicUpdatePasswordV2(PublicUpdatePasswordV2Builder builder,
            ModelUserPasswordUpdateRequest body,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {

            public string Error400 { get; set; } = "";

            public RestErrorResponse? Error401 { get; set; } = null;

            public RestErrorResponse? Error403 { get; set; } = null;

            public string Error404 { get; set; } = "";

            public string Error500 { get; set; } = "";


            protected override string GetFullOperationId() => "Iam::Users::PublicUpdatePasswordV2";
        }

        #endregion

        public PublicUpdatePasswordV2(
            string namespace_,            
            string userId,            
            Model.ModelUserPasswordUpdateRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v2/public/namespaces/{namespace}/users/{userId}/password";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public PublicUpdatePasswordV2.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new PublicUpdatePasswordV2.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };

            if (code == (HttpStatusCode)400)
            
            {
                response.Error400 = payload.ReadToString();
                response.Error = new ApiError("-1", response.Error400!);
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
                response.Error404 = payload.ReadToString();
                response.Error = new ApiError("-1", response.Error404!);
            }
            else if (code == (HttpStatusCode)500)
            
            {
                response.Error500 = payload.ReadToString();
                response.Error = new ApiError("-1", response.Error500!);
            }

            return response;
        }
    }

}