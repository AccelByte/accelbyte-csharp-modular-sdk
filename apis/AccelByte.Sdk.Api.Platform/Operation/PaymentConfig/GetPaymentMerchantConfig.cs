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
    /// getPaymentMerchantConfig
    ///
    ///  [Not Supported Yet In Starter] Get payment merchant config by id.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:PAYMENT:CONFIG", action=2 (READ)
    ///   *  Returns : payment merchant config info
    /// </summary>
    public class GetPaymentMerchantConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetPaymentMerchantConfigBuilder Builder { get => new GetPaymentMerchantConfigBuilder(); }

        public class GetPaymentMerchantConfigBuilder
            : OperationBuilder<GetPaymentMerchantConfigBuilder>
        {





            internal GetPaymentMerchantConfigBuilder() { }

            internal GetPaymentMerchantConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetPaymentMerchantConfig Build(
                string id
            )
            {
                GetPaymentMerchantConfig op = new GetPaymentMerchantConfig(this,
                    id
                );

                op.SetBaseFields<GetPaymentMerchantConfigBuilder>(this);
                return op;
            }

            public Model.PaymentMerchantConfigInfo? Execute(
                string id
            )
            {
                GetPaymentMerchantConfig op = Build(
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
            public async Task<Model.PaymentMerchantConfigInfo?> ExecuteAsync(
                string id
            )
            {
                GetPaymentMerchantConfig op = Build(
                    id
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

        private GetPaymentMerchantConfig(GetPaymentMerchantConfigBuilder builder,
            string id
        )
        {
            PathParams["id"] = id;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetPaymentMerchantConfig(
            string id
        )
        {
            PathParams["id"] = id;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/payment/config/merchant/{id}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.PaymentMerchantConfigInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.PaymentMerchantConfigInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.PaymentMerchantConfigInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}