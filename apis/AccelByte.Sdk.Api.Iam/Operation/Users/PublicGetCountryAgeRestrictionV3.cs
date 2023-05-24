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
    /// PublicGetCountryAgeRestrictionV3
    ///
    /// Get age restriction by country code. It will always get by publisher namespace
    /// </summary>
    public class PublicGetCountryAgeRestrictionV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetCountryAgeRestrictionV3Builder Builder { get => new PublicGetCountryAgeRestrictionV3Builder(); }

        public class PublicGetCountryAgeRestrictionV3Builder
            : OperationBuilder<PublicGetCountryAgeRestrictionV3Builder>
        {





            internal PublicGetCountryAgeRestrictionV3Builder() { }

            internal PublicGetCountryAgeRestrictionV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicGetCountryAgeRestrictionV3 Build(
                string countryCode,
                string namespace_
            )
            {
                PublicGetCountryAgeRestrictionV3 op = new PublicGetCountryAgeRestrictionV3(this,
                    countryCode,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.ModelCountryV3Response? Execute(
                string countryCode,
                string namespace_
            )
            {
                PublicGetCountryAgeRestrictionV3 op = Build(
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
        }

        private PublicGetCountryAgeRestrictionV3(PublicGetCountryAgeRestrictionV3Builder builder,
            string countryCode,
            string namespace_
        )
        {
            PathParams["countryCode"] = countryCode;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGetCountryAgeRestrictionV3(
            string countryCode,
            string namespace_
        )
        {
            PathParams["countryCode"] = countryCode;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/agerestrictions/countries/{countryCode}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelCountryV3Response? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelCountryV3Response>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelCountryV3Response>(payload);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}