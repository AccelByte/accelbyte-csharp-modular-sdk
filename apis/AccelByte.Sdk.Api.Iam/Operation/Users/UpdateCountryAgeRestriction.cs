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
    /// UpdateCountryAgeRestriction
    ///
    /// ## The endpoint is going to be deprecated
    /// **Endpoint migration guide**
    /// - **Substitute endpoint: _/iam/v3/admin/namespaces/{namespace}/agerestrictions/countries/{countryCode} [PATCH]_**
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class UpdateCountryAgeRestriction : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateCountryAgeRestrictionBuilder Builder { get => new UpdateCountryAgeRestrictionBuilder(); }

        public class UpdateCountryAgeRestrictionBuilder
            : OperationBuilder<UpdateCountryAgeRestrictionBuilder>
        {





            internal UpdateCountryAgeRestrictionBuilder() { }

            internal UpdateCountryAgeRestrictionBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UpdateCountryAgeRestriction Build(
                ModelCountryAgeRestrictionRequest body,
                string countryCode,
                string namespace_
            )
            {
                UpdateCountryAgeRestriction op = new UpdateCountryAgeRestriction(this,
                    body,
                    countryCode,
                    namespace_
                );

                op.SetBaseFields<UpdateCountryAgeRestrictionBuilder>(this);
                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public Model.ModelCountry? Execute(
                ModelCountryAgeRestrictionRequest body,
                string countryCode,
                string namespace_
            )
            {
                UpdateCountryAgeRestriction op = Build(
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
        }

        private UpdateCountryAgeRestriction(UpdateCountryAgeRestrictionBuilder builder,
            ModelCountryAgeRestrictionRequest body,
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

        public UpdateCountryAgeRestriction(
            string countryCode,
            string namespace_,
            Model.ModelCountryAgeRestrictionRequest body
        )
        {
            PathParams["countryCode"] = countryCode;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v2/admin/namespaces/{namespace}/countries/{countryCode}";

        public override HttpMethod Method => HttpMethod.Patch;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelCountry? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelCountry>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelCountry>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}