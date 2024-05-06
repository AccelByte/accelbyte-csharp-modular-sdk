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
    /// createPaymentProviderConfig
    ///
    ///  [Not Supported Yet In Starter] Create payment provider config.
    /// 
    /// 
    /// 
    ///      Request Body Parameters:
    /// 
    /// 
    ///      Parameter | Type   | Required | Description
    ///     -----------|--------|----------|-----------------------------------------------------------
    ///     namespace  | String | Yes      | namespace, * indicates all namespace
    ///     region     | String | Yes      | region, * indicates all regions
    ///     aggregate  | String | No       | aggregate payment provider, such as XSOLLA, ADYEN, STRIPE
    ///     specials   | List   | No       | special payment provider, such as ALIPAY, WXPAY
    /// 
    /// 
    /// 
    /// payment provider applied has priority:
    /// 
    ///   1. namespace and region match
    ///   2. namespace matches and region is *
    ///   3. region matches and namespace is *
    ///   4. namespace and region are *
    /// 
    /// Other detail info:
    ///   * Returns : payment provider config
    /// </summary>
    public class CreatePaymentProviderConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreatePaymentProviderConfigBuilder Builder { get => new CreatePaymentProviderConfigBuilder(); }

        public class CreatePaymentProviderConfigBuilder
            : OperationBuilder<CreatePaymentProviderConfigBuilder>
        {


            public Model.PaymentProviderConfigEdit? Body { get; set; }




            internal CreatePaymentProviderConfigBuilder() { }

            internal CreatePaymentProviderConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public CreatePaymentProviderConfigBuilder SetBody(Model.PaymentProviderConfigEdit _body)
            {
                Body = _body;
                return this;
            }




            public CreatePaymentProviderConfig Build(
            )
            {
                CreatePaymentProviderConfig op = new CreatePaymentProviderConfig(this
                );

                op.SetBaseFields<CreatePaymentProviderConfigBuilder>(this);
                return op;
            }

            public Model.PaymentProviderConfigInfo? Execute(
            )
            {
                CreatePaymentProviderConfig op = Build(
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<Model.PaymentProviderConfigInfo?> ExecuteAsync(
            )
            {
                CreatePaymentProviderConfig op = Build(
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

        private CreatePaymentProviderConfig(CreatePaymentProviderConfigBuilder builder
        )
        {





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CreatePaymentProviderConfig(
            Model.PaymentProviderConfigEdit body
        )
        {





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/payment/config/provider";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.PaymentProviderConfigInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.PaymentProviderConfigInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.PaymentProviderConfigInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}