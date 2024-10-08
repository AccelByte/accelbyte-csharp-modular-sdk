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
    /// getPaymentTaxConfig
    ///
    ///  [Not supported yet in AGS Shared Cloud] Get payment global tax config.
    /// Other detail info:
    /// 
    ///   * Returns : payment provider list
    /// </summary>
    public class GetPaymentTaxConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetPaymentTaxConfigBuilder Builder { get => new GetPaymentTaxConfigBuilder(); }

        public class GetPaymentTaxConfigBuilder
            : OperationBuilder<GetPaymentTaxConfigBuilder>
        {





            internal GetPaymentTaxConfigBuilder() { }

            internal GetPaymentTaxConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetPaymentTaxConfig Build(
            )
            {
                GetPaymentTaxConfig op = new GetPaymentTaxConfig(this
                );

                op.SetBaseFields<GetPaymentTaxConfigBuilder>(this);
                return op;
            }

            public Model.PaymentTaxConfigInfo? Execute(
            )
            {
                GetPaymentTaxConfig op = Build(
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<Model.PaymentTaxConfigInfo?> ExecuteAsync(
            )
            {
                GetPaymentTaxConfig op = Build(
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

        private GetPaymentTaxConfig(GetPaymentTaxConfigBuilder builder
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetPaymentTaxConfig(
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/payment/config/tax";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.PaymentTaxConfigInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.PaymentTaxConfigInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.PaymentTaxConfigInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}