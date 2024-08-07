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

using AccelByte.Sdk.Api.Basic.Model;

namespace AccelByte.Sdk.Api.Basic.Operation
{
    /// <summary>
    /// getCountries
    ///
    /// List countries.
    /// Other detail info:
    /// 
    ///   * Action code : 11204
    ///   *  Returns : country code list
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class GetCountries : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetCountriesBuilder Builder { get => new GetCountriesBuilder(); }

        public class GetCountriesBuilder
            : OperationBuilder<GetCountriesBuilder>
        {

            public string? Lang { get; set; }





            internal GetCountriesBuilder() { }

            internal GetCountriesBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetCountriesBuilder SetLang(string _lang)
            {
                Lang = _lang;
                return this;
            }





            public GetCountries Build(
                string namespace_
            )
            {
                GetCountries op = new GetCountries(this,
                    namespace_
                );

                op.SetBaseFields<GetCountriesBuilder>(this);
                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public List<Model.CountryObject>? Execute(
                string namespace_
            )
            {
                GetCountries op = Build(
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
            public async Task<List<Model.CountryObject>?> ExecuteAsync(
                string namespace_
            )
            {
                GetCountries op = Build(
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

        private GetCountries(GetCountriesBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Lang is not null) QueryParams["lang"] = builder.Lang;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetCountries(
            string namespace_,
            string? lang
        )
        {
            PathParams["namespace"] = namespace_;

            if (lang is not null) QueryParams["lang"] = lang;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/basic/v1/admin/namespaces/{namespace}/misc/countries";

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