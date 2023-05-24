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

using AccelByte.Sdk.Api.Seasonpass.Model;

namespace AccelByte.Sdk.Api.Seasonpass.Operation
{
    /// <summary>
    /// publicGetCurrentSeason
    ///
    /// This API is used to get current published season, season only located in non-publisher namespace.
    /// 
    /// Other detail info:
    /// 
    ///   * Returns : localized season data
    /// </summary>
    public class PublicGetCurrentSeason : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetCurrentSeasonBuilder Builder { get => new PublicGetCurrentSeasonBuilder(); }

        public class PublicGetCurrentSeasonBuilder
            : OperationBuilder<PublicGetCurrentSeasonBuilder>
        {

            public string? Language { get; set; }





            internal PublicGetCurrentSeasonBuilder() { }

            internal PublicGetCurrentSeasonBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public PublicGetCurrentSeasonBuilder SetLanguage(string _language)
            {
                Language = _language;
                return this;
            }





            public PublicGetCurrentSeason Build(
                string namespace_
            )
            {
                PublicGetCurrentSeason op = new PublicGetCurrentSeason(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.LocalizedSeasonInfo? Execute(
                string namespace_
            )
            {
                PublicGetCurrentSeason op = Build(
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

        private PublicGetCurrentSeason(PublicGetCurrentSeasonBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Language is not null) QueryParams["language"] = builder.Language;






        }
        #endregion

        public PublicGetCurrentSeason(
            string namespace_,
            string? language
        )
        {
            PathParams["namespace"] = namespace_;

            if (language is not null) QueryParams["language"] = language;






        }

        public override string Path => "/seasonpass/public/namespaces/{namespace}/seasons/current";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.LocalizedSeasonInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.LocalizedSeasonInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.LocalizedSeasonInfo>(payload);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}