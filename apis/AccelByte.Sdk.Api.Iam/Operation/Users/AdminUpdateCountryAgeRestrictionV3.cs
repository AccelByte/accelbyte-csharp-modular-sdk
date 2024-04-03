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

            public Model.ModelCountryV3Response? Execute(
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
            public async Task<Model.ModelCountryV3Response?> ExecuteAsync(
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

        public Model.ModelCountryV3Response? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelCountryV3Response>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelCountryV3Response>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}