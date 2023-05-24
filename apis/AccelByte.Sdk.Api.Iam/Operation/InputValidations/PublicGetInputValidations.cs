// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
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

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Net.Http;

using AccelByte.Sdk.Api.Iam.Model;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// PublicGetInputValidations
    ///
    /// 
    /// 
    /// No role required
    /// 
    /// 
    /// 
    /// 
    /// This endpoint is to get list of input validation configuration.
    /// 
    /// 
    /// 
    /// 
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
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.ModelInputValidationsPublicResponse? Execute(
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
        }

        private PublicGetInputValidations(PublicGetInputValidationsBuilder builder
        )
        {

            if (builder.DefaultOnEmpty != null) QueryParams["defaultOnEmpty"] = Convert.ToString(builder.DefaultOnEmpty)!;
            if (builder.LanguageCode is not null) QueryParams["languageCode"] = builder.LanguageCode;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGetInputValidations(
            bool? defaultOnEmpty,
            string? languageCode
        )
        {

            if (defaultOnEmpty != null) QueryParams["defaultOnEmpty"] = Convert.ToString(defaultOnEmpty)!;
            if (languageCode is not null) QueryParams["languageCode"] = languageCode;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/public/inputValidations";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelInputValidationsPublicResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelInputValidationsPublicResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelInputValidationsPublicResponse>(payload);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}