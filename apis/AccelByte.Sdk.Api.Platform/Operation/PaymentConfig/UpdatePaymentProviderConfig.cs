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
    /// updatePaymentProviderConfig
    ///
    /// Update payment provider config.
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
    ///   * Required permission : resource="ADMIN:PAYMENT:CONFIG", action=4 (UPDATE)
    ///   *  Returns : payment provider config
    /// </summary>
    public class UpdatePaymentProviderConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdatePaymentProviderConfigBuilder Builder { get => new UpdatePaymentProviderConfigBuilder(); }

        public class UpdatePaymentProviderConfigBuilder
            : OperationBuilder<UpdatePaymentProviderConfigBuilder>
        {


            public Model.PaymentProviderConfigEdit? Body { get; set; }




            internal UpdatePaymentProviderConfigBuilder() { }

            internal UpdatePaymentProviderConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public UpdatePaymentProviderConfigBuilder SetBody(Model.PaymentProviderConfigEdit _body)
            {
                Body = _body;
                return this;
            }




            public UpdatePaymentProviderConfig Build(
                string id
            )
            {
                UpdatePaymentProviderConfig op = new UpdatePaymentProviderConfig(this,
                    id
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.PaymentProviderConfigInfo? Execute(
                string id
            )
            {
                UpdatePaymentProviderConfig op = Build(
                    id
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

        private UpdatePaymentProviderConfig(UpdatePaymentProviderConfigBuilder builder,
            string id
        )
        {
            PathParams["id"] = id;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdatePaymentProviderConfig(
            string id,
            Model.PaymentProviderConfigEdit body
        )
        {
            PathParams["id"] = id;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/payment/config/provider/{id}";

        public override HttpMethod Method => HttpMethod.Put;

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
                return JsonSerializer.Deserialize<Model.PaymentProviderConfigInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.PaymentProviderConfigInfo>(payload);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}