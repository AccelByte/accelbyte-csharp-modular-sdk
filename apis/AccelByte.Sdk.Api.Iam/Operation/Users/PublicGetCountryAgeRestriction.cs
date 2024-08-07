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
    /// PublicGetCountryAgeRestriction
    ///
    /// ## The endpoint is going to be deprecated
    /// **Endpoint migration guide**
    /// - **Substitute endpoint: _/iam/v3/public/namespaces/{namespace}/agerestrictions/countries/{countryCode} [GET]_**
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class PublicGetCountryAgeRestriction : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetCountryAgeRestrictionBuilder Builder { get => new PublicGetCountryAgeRestrictionBuilder(); }

        public class PublicGetCountryAgeRestrictionBuilder
            : OperationBuilder<PublicGetCountryAgeRestrictionBuilder>
        {





            internal PublicGetCountryAgeRestrictionBuilder() { }

            internal PublicGetCountryAgeRestrictionBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicGetCountryAgeRestriction Build(
                string countryCode,
                string namespace_
            )
            {
                PublicGetCountryAgeRestriction op = new PublicGetCountryAgeRestriction(this,
                    countryCode,
                    namespace_
                );

                op.SetBaseFields<PublicGetCountryAgeRestrictionBuilder>(this);
                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public Model.AccountcommonCountry? Execute(
                string countryCode,
                string namespace_
            )
            {
                PublicGetCountryAgeRestriction op = Build(
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
            public async Task<Model.AccountcommonCountry?> ExecuteAsync(
                string countryCode,
                string namespace_
            )
            {
                PublicGetCountryAgeRestriction op = Build(
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

        private PublicGetCountryAgeRestriction(PublicGetCountryAgeRestrictionBuilder builder,
            string countryCode,
            string namespace_
        )
        {
            PathParams["countryCode"] = countryCode;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGetCountryAgeRestriction(
            string countryCode,
            string namespace_
        )
        {
            PathParams["countryCode"] = countryCode;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v2/public/namespaces/{namespace}/countries/{countryCode}/agerestrictions";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.AccountcommonCountry? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.AccountcommonCountry>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.AccountcommonCountry>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}