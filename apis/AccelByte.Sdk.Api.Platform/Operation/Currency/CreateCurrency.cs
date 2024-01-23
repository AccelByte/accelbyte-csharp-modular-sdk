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

using AccelByte.Sdk.Api.Platform.Model;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// createCurrency
    ///
    /// Create a currency.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:CURRENCY", action=1 (CREATE)
    ///   *  Returns : created currency
    /// </summary>
    public class CreateCurrency : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateCurrencyBuilder Builder { get => new CreateCurrencyBuilder(); }

        public class CreateCurrencyBuilder
            : OperationBuilder<CreateCurrencyBuilder>
        {


            public Model.CurrencyCreate? Body { get; set; }




            internal CreateCurrencyBuilder() { }

            internal CreateCurrencyBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public CreateCurrencyBuilder SetBody(Model.CurrencyCreate _body)
            {
                Body = _body;
                return this;
            }




            public CreateCurrency Build(
                string namespace_
            )
            {
                CreateCurrency op = new CreateCurrency(this,
                    namespace_
                );

                op.SetBaseFields<CreateCurrencyBuilder>(this);
                return op;
            }

            public Model.CurrencyInfo? Execute(
                string namespace_
            )
            {
                CreateCurrency op = Build(
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

        private CreateCurrency(CreateCurrencyBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CreateCurrency(
            string namespace_,
            Model.CurrencyCreate body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/currencies";

        public override HttpMethod Method => HttpMethod.Post;

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