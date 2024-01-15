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
    /// testStripeConfigById
    ///
    ///  [Not Supported Yet In Starter] Test stripe configuration in payment merchant config. Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:PAYMENT:CONFIG", action=2 (READ)
    ///   *  Returns : test adyen config
    /// </summary>
    public class TestStripeConfigById : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static TestStripeConfigByIdBuilder Builder { get => new TestStripeConfigByIdBuilder(); }

        public class TestStripeConfigByIdBuilder
            : OperationBuilder<TestStripeConfigByIdBuilder>
        {

            public bool? Sandbox { get; set; }





            internal TestStripeConfigByIdBuilder() { }

            internal TestStripeConfigByIdBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public TestStripeConfigByIdBuilder SetSandbox(bool _sandbox)
            {
                Sandbox = _sandbox;
                return this;
            }





            public TestStripeConfigById Build(
                string id
            )
            {
                TestStripeConfigById op = new TestStripeConfigById(this,
                    id
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.TestResult? Execute(
                string id
            )
            {
                TestStripeConfigById op = Build(
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

        private TestStripeConfigById(TestStripeConfigByIdBuilder builder,
            string id
        )
        {
            PathParams["id"] = id;

            if (builder.Sandbox != null) QueryParams["sandbox"] = Convert.ToString(builder.Sandbox)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public TestStripeConfigById(
            string id,
            bool? sandbox
        )
        {
            PathParams["id"] = id;

            if (sandbox != null) QueryParams["sandbox"] = Convert.ToString(sandbox)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/payment/config/merchant/{id}/stripeconfig/test";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.TestResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.TestResult>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.TestResult>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}