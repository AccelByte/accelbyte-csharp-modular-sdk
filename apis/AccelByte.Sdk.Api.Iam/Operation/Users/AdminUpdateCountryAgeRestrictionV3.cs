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
    /// AdminUpdateCountryAgeRestrictionV3
    ///
    /// action code: 10123
    /// </summary>
    public class AdminUpdateCountryAgeRestrictionV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpdateCountryAgeRestrictionV3Builder Builder { get => new AdminUpdateCountryAgeRestrictionV3Builder(); }

        public class AdminUpdateCountryAgeRestrictionV3Builder
            : OperationBuilder<AdminUpdateCountryAgeRestrictionV3Builder>
        {





            internal AdminUpdateCountryAgeRestrictionV3Builder() { }

            internal AdminUpdateCountryAgeRestrictionV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminUpdateCountryAgeRestrictionV3 Build(
                ModelCountryAgeRestrictionV3Request body,
                string countryCode,
                string namespace_
            )
            {
                AdminUpdateCountryAgeRestrictionV3 op = new AdminUpdateCountryAgeRestrictionV3(this,
                    body,
                    countryCode,
                    namespace_
                );

                op.SetBaseFields<AdminUpdateCountryAgeRestrictionV3Builder>(this);
                return op;
            }

            public AdminUpdateCountryAgeRestrictionV3.Response Execute(
                ModelCountryAgeRestrictionV3Request body,
                string countryCode,
                string namespace_
            )
            {
                AdminUpdateCountryAgeRestrictionV3 op = Build(
                    body,
                    countryCode,
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
            public async Task<AdminUpdateCountryAgeRestrictionV3.Response> ExecuteAsync(
                ModelCountryAgeRestrictionV3Request body,
                string countryCode,
                string namespace_
            )
            {
                AdminUpdateCountryAgeRestrictionV3 op = Build(
                    body,
                    countryCode,
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

        private AdminUpdateCountryAgeRestrictionV3(AdminUpdateCountryAgeRestrictionV3Builder builder,
            ModelCountryAgeRestrictionV3Request body,
            string countryCode,
            string namespace_
        )
        {
            PathParams["countryCode"] = countryCode;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelCountryV3Response>
        {

            public RestErrorResponse? Error400 { get; set; } = null;

            public RestErrorResponse? Error401 { get; set; } = null;

            public RestErrorResponse? Error403 { get; set; } = null;

            public RestErrorResponse? Error404 { get; set; } = null;

            public RestErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Iam::Users::AdminUpdateCountryAgeRestrictionV3";
        }

        #endregion

        public AdminUpdateCountryAgeRestrictionV3(
            string countryCode,
            string namespace_,
            Model.ModelCountryAgeRestrictionV3Request body
        )
        {
            PathParams["countryCode"] = countryCode;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/agerestrictions/countries/{countryCode}";

        public override HttpMethod Method => HttpMethod.Patch;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public AdminUpdateCountryAgeRestrictionV3.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminUpdateCountryAgeRestrictionV3.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelCountryV3Response>(payload, ResponseJsonOptions);
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