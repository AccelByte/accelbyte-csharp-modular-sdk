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

using AccelByte.Sdk.Api.Legal.Model;

namespace AccelByte.Sdk.Api.Legal.Operation
{
    /// <summary>
    /// retrievePolicyCountry_1
    ///
    /// Retrieve a Base Legal Policy based on a Particular Country.
    /// </summary>
    public class RetrievePolicyCountry1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RetrievePolicyCountry1Builder Builder { get => new RetrievePolicyCountry1Builder(); }

        public class RetrievePolicyCountry1Builder
            : OperationBuilder<RetrievePolicyCountry1Builder>
        {





            internal RetrievePolicyCountry1Builder() { }

            internal RetrievePolicyCountry1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public RetrievePolicyCountry1 Build(
                string basePolicyId,
                string countryCode,
                string namespace_
            )
            {
                RetrievePolicyCountry1 op = new RetrievePolicyCountry1(this,
                    basePolicyId,
                    countryCode,
                    namespace_
                );

                op.SetBaseFields<RetrievePolicyCountry1Builder>(this);
                return op;
            }

            public RetrievePolicyCountry1.Response Execute(
                string basePolicyId,
                string countryCode,
                string namespace_
            )
            {
                RetrievePolicyCountry1 op = Build(
                    basePolicyId,
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
            public async Task<RetrievePolicyCountry1.Response> ExecuteAsync(
                string basePolicyId,
                string countryCode,
                string namespace_
            )
            {
                RetrievePolicyCountry1 op = Build(
                    basePolicyId,
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

        private RetrievePolicyCountry1(RetrievePolicyCountry1Builder builder,
            string basePolicyId,
            string countryCode,
            string namespace_
        )
        {
            PathParams["basePolicyId"] = basePolicyId;
            PathParams["countryCode"] = countryCode;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.RetrievePolicyResponse>
        {

            public ErrorEntity? Error404 { get; set; } = null;


            protected override string GetFullOperationId() => "Legal::BaseLegalPoliciesWithNamespace::RetrievePolicyCountry1";
        }

        #endregion

        public RetrievePolicyCountry1(
            string basePolicyId,
            string countryCode,
            string namespace_
        )
        {
            PathParams["basePolicyId"] = basePolicyId;
            PathParams["countryCode"] = countryCode;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/admin/namespaces/{namespace}/base-policies/{basePolicyId}/countries/{countryCode}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public RetrievePolicyCountry1.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new RetrievePolicyCountry1.Response()
            {
                StatusCode = code,
                ContentType = contentType
            };

            if (code == (HttpStatusCode)204)
            {
                response.IsSuccess = true;
            }
            else if ((code == (HttpStatusCode)201) || (code == (HttpStatusCode)202) || (code == (HttpStatusCode)200))
            {
                response.Data = JsonSerializer.Deserialize<Model.RetrievePolicyResponse>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }

            return response;
        }
    }

}