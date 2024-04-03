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

using AccelByte.Sdk.Api.Platform.Model;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// getCurrencySummary
    ///
    /// Get currency summary by code.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:CURRENCY", action=2 (READ)
    ///   *  Returns : simplified Currency
    /// </summary>
    public class GetCurrencySummary : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetCurrencySummaryBuilder Builder { get => new GetCurrencySummaryBuilder(); }

        public class GetCurrencySummaryBuilder
            : OperationBuilder<GetCurrencySummaryBuilder>
        {





            internal GetCurrencySummaryBuilder() { }

            internal GetCurrencySummaryBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetCurrencySummary Build(
                string currencyCode,
                string namespace_
            )
            {
                GetCurrencySummary op = new GetCurrencySummary(this,
                    currencyCode,
                    namespace_
                );

                op.SetBaseFields<GetCurrencySummaryBuilder>(this);
                return op;
            }

            public Model.CurrencySummary? Execute(
                string currencyCode,
                string namespace_
            )
            {
                GetCurrencySummary op = Build(
                    currencyCode,
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
            public async Task<Model.CurrencySummary?> ExecuteAsync(
                string currencyCode,
                string namespace_
            )
            {
                GetCurrencySummary op = Build(
                    currencyCode,
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

        private GetCurrencySummary(GetCurrencySummaryBuilder builder,
            string currencyCode,
            string namespace_
        )
        {
            PathParams["currencyCode"] = currencyCode;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetCurrencySummary(
            string currencyCode,
            string namespace_
        )
        {
            PathParams["currencyCode"] = currencyCode;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/currencies/{currencyCode}/summary";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.CurrencySummary? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.CurrencySummary>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.CurrencySummary>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}