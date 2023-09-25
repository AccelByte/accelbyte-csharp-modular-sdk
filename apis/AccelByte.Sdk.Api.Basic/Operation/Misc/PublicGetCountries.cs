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

using AccelByte.Sdk.Api.Basic.Model;

namespace AccelByte.Sdk.Api.Basic.Operation
{
    /// <summary>
    /// publicGetCountries
    ///
    /// List countries.
    /// Other detail info:
    /// 
    ///   * Returns : country code list
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class PublicGetCountries : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetCountriesBuilder Builder { get => new PublicGetCountriesBuilder(); }

        public class PublicGetCountriesBuilder
            : OperationBuilder<PublicGetCountriesBuilder>
        {

            public string? Lang { get; set; }





            internal PublicGetCountriesBuilder() { }

            internal PublicGetCountriesBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public PublicGetCountriesBuilder SetLang(string _lang)
            {
                Lang = _lang;
                return this;
            }





            public PublicGetCountries Build(
                string namespace_
            )
            {
                PublicGetCountries op = new PublicGetCountries(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public List<Model.CountryObject>? Execute(
                string namespace_
            )
            {
                PublicGetCountries op = Build(
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
        }

        private PublicGetCountries(PublicGetCountriesBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Lang is not null) QueryParams["lang"] = builder.Lang;






        }
        #endregion

        public PublicGetCountries(
            string namespace_,
            string? lang
        )
        {
            PathParams["namespace"] = namespace_;

            if (lang is not null) QueryParams["lang"] = lang;






        }

        public override string Path => "/basic/v1/public/namespaces/{namespace}/misc/countries";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public List<Model.CountryObject>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.CountryObject>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.CountryObject>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}