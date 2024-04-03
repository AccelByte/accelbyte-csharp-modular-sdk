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
    /// PublicGetCountryListV3
    ///
    /// Public get country list, will filter out countries in black list
    /// </summary>
    public class PublicGetCountryListV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetCountryListV3Builder Builder { get => new PublicGetCountryListV3Builder(); }

        public class PublicGetCountryListV3Builder
            : OperationBuilder<PublicGetCountryListV3Builder>
        {





            internal PublicGetCountryListV3Builder() { }

            internal PublicGetCountryListV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicGetCountryListV3 Build(
                string namespace_
            )
            {
                PublicGetCountryListV3 op = new PublicGetCountryListV3(this,
                    namespace_
                );

                op.SetBaseFields<PublicGetCountryListV3Builder>(this);
                return op;
            }

            public List<Model.ModelCountryResponse>? Execute(
                string namespace_
            )
            {
                PublicGetCountryListV3 op = Build(
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
            public async Task<List<Model.ModelCountryResponse>?> ExecuteAsync(
                string namespace_
            )
            {
                PublicGetCountryListV3 op = Build(
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

        private PublicGetCountryListV3(PublicGetCountryListV3Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGetCountryListV3(
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/countries";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public List<Model.ModelCountryResponse>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ModelCountryResponse>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ModelCountryResponse>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}