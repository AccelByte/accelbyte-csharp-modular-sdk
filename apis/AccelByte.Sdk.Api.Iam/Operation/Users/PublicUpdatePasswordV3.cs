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
    /// PublicUpdatePasswordV3
    ///
    /// action code: 10107
    /// </summary>
    public class PublicUpdatePasswordV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicUpdatePasswordV3Builder Builder { get => new PublicUpdatePasswordV3Builder(); }

        public class PublicUpdatePasswordV3Builder
            : OperationBuilder<PublicUpdatePasswordV3Builder>
        {





            internal PublicUpdatePasswordV3Builder() { }

            internal PublicUpdatePasswordV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicUpdatePasswordV3 Build(
                ModelUserPasswordUpdateV3Request body,
                string namespace_
            )
            {
                PublicUpdatePasswordV3 op = new PublicUpdatePasswordV3(this,
                    body,
                    namespace_
                );

                op.SetBaseFields<PublicUpdatePasswordV3Builder>(this);
                return op;
            }

            public PublicUpdatePasswordV3.Response Execute(
                ModelUserPasswordUpdateV3Request body,
                string namespace_
            )
            {
                PublicUpdatePasswordV3 op = Build(
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
            public async Task<PublicUpdatePasswordV3.Response> ExecuteAsync(
                ModelUserPasswordUpdateV3Request body,
                string namespace_
            )
            {
                PublicUpdatePasswordV3 op = Build(
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

        private PublicUpdatePasswordV3(PublicUpdatePasswordV3Builder builder,
            ModelUserPasswordUpdateV3Request body,
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

            public RestErrorResponse? Error401 { get; set; } = null;

            public RestErrorResponse? Error429 { get; set; } = null;

            public RestErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Iam::Users::PublicUpdatePasswordV3";
        }

        #endregion

        public PublicUpdatePasswordV3(
            string namespace_,
            Model.ModelUserPasswordUpdateV3Request body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/users/me/password";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public PublicUpdatePasswordV3.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new PublicUpdatePasswordV3.Response()
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
            else if (code == (HttpStatusCode)429)

            {
                response.Error429 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error429!.TranslateToApiError();
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