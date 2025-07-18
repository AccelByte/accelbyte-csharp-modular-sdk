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
    /// PublicGetInputValidations
    ///
    /// No role required
    /// This endpoint is to get list of input validation configuration.
    /// `regex` parameter will be returned if `isCustomRegex` is true. Otherwise, it will be empty.
    /// </summary>
    public class PublicGetInputValidations : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetInputValidationsBuilder Builder { get => new PublicGetInputValidationsBuilder(); }

        public class PublicGetInputValidationsBuilder
            : OperationBuilder<PublicGetInputValidationsBuilder>
        {

            public bool? DefaultOnEmpty { get; set; }

            public string? LanguageCode { get; set; }





            internal PublicGetInputValidationsBuilder() { }

            internal PublicGetInputValidationsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public PublicGetInputValidationsBuilder SetDefaultOnEmpty(bool _defaultOnEmpty)
            {
                DefaultOnEmpty = _defaultOnEmpty;
                return this;
            }

            public PublicGetInputValidationsBuilder SetLanguageCode(string _languageCode)
            {
                LanguageCode = _languageCode;
                return this;
            }





            public PublicGetInputValidations Build(
            )
            {
                PublicGetInputValidations op = new PublicGetInputValidations(this
                );

                op.SetBaseFields<PublicGetInputValidationsBuilder>(this);
                return op;
            }

            public PublicGetInputValidations.Response Execute(
            )
            {
                PublicGetInputValidations op = Build(
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<PublicGetInputValidations.Response> ExecuteAsync(
            )
            {
                PublicGetInputValidations op = Build(
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

        private PublicGetInputValidations(PublicGetInputValidationsBuilder builder
        )
        {
            
            if (builder.DefaultOnEmpty != null) QueryParams["defaultOnEmpty"] = Convert.ToString(builder.DefaultOnEmpty)!;
            if (builder.LanguageCode is not null) QueryParams["languageCode"] = builder.LanguageCode;
            

            
            
            

        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelInputValidationsPublicResponse>
        {

            public string Error404 { get; set; } = "";

            public RestErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Iam::InputValidations::PublicGetInputValidations";
        }

        #endregion

        public PublicGetInputValidations(
            bool? defaultOnEmpty,            
            string? languageCode            
        )
        {
            
            if (defaultOnEmpty != null) QueryParams["defaultOnEmpty"] = Convert.ToString(defaultOnEmpty)!;
            if (languageCode is not null) QueryParams["languageCode"] = languageCode;
            

            
            
            

        }

        public override string Path => "/iam/v3/public/inputValidations";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public PublicGetInputValidations.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new PublicGetInputValidations.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelInputValidationsPublicResponse>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = payload.ReadToString();
                response.Error = new ApiError("-1", response.Error404!);
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