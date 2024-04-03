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
    /// updateCurrency
    ///
    /// Update a currency by currency code.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:CURRENCY", action=4 (UPDATE)
    ///   *  Returns : updated currency
    /// </summary>
    public class UpdateCurrency : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateCurrencyBuilder Builder { get => new UpdateCurrencyBuilder(); }

        public class UpdateCurrencyBuilder
            : OperationBuilder<UpdateCurrencyBuilder>
        {


            public Model.CurrencyUpdate? Body { get; set; }




            internal UpdateCurrencyBuilder() { }

            internal UpdateCurrencyBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public UpdateCurrencyBuilder SetBody(Model.CurrencyUpdate _body)
            {
                Body = _body;
                return this;
            }




            public UpdateCurrency Build(
                string currencyCode,
                string namespace_
            )
            {
                UpdateCurrency op = new UpdateCurrency(this,
                    currencyCode,
                    namespace_
                );

                op.SetBaseFields<UpdateCurrencyBuilder>(this);
                return op;
            }

            public Model.CurrencyInfo? Execute(
                string currencyCode,
                string namespace_
            )
            {
                UpdateCurrency op = Build(
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
            public async Task<Model.CurrencyInfo?> ExecuteAsync(
                string currencyCode,
                string namespace_
            )
            {
                UpdateCurrency op = Build(
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

        private UpdateCurrency(UpdateCurrencyBuilder builder,
            string currencyCode,
            string namespace_
        )
        {
            PathParams["currencyCode"] = currencyCode;
            PathParams["namespace"] = namespace_;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateCurrency(
            string currencyCode,
            string namespace_,
            Model.CurrencyUpdate body
        )
        {
            PathParams["currencyCode"] = currencyCode;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/currencies/{currencyCode}";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.CurrencyInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.CurrencyInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.CurrencyInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}