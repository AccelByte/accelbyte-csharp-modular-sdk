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
    /// GetListCountryAgeRestriction
    ///
    /// ## The endpoint is going to be deprecated
    /// **Endpoint migration guide**
    /// - **Substitute endpoint: _/iam/v3/admin/namespaces/{namespace}/agerestrictions/countries [GET]_**
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class GetListCountryAgeRestriction : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetListCountryAgeRestrictionBuilder Builder { get => new GetListCountryAgeRestrictionBuilder(); }

        public class GetListCountryAgeRestrictionBuilder
            : OperationBuilder<GetListCountryAgeRestrictionBuilder>
        {





            internal GetListCountryAgeRestrictionBuilder() { }

            internal GetListCountryAgeRestrictionBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetListCountryAgeRestriction Build(
                string namespace_
            )
            {
                GetListCountryAgeRestriction op = new GetListCountryAgeRestriction(this,
                    namespace_
                );

                op.SetBaseFields<GetListCountryAgeRestrictionBuilder>(this);
                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public List<Model.AccountcommonCountryAgeRestriction>? Execute(
                string namespace_
            )
            {
                GetListCountryAgeRestriction op = Build(
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
            public async Task<List<Model.AccountcommonCountryAgeRestriction>?> ExecuteAsync(
                string namespace_
            )
            {
                GetListCountryAgeRestriction op = Build(
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

        private GetListCountryAgeRestriction(GetListCountryAgeRestrictionBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetListCountryAgeRestriction(
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v2/admin/namespaces/{namespace}/countries/agerestrictions";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public List<Model.AccountcommonCountryAgeRestriction>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.AccountcommonCountryAgeRestriction>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.AccountcommonCountryAgeRestriction>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}