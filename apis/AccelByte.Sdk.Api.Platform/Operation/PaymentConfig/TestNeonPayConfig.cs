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
    /// testNeonPayConfig
    ///
    ///  [Not supported yet in AGS Shared Cloud] Check Neon Pay configuration, Reference: [Neon Pay Document](https://docs.neonpay.com/docs/checkout).
    /// 
    /// #### Check List:
    /// 
    ///   * apiKey
    ///   * webhookSecretKey
    /// 
    /// Other detail info:
    ///   * Returns : test result
    /// </summary>
    public class TestNeonPayConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static TestNeonPayConfigBuilder Builder { get => new TestNeonPayConfigBuilder(); }

        public class TestNeonPayConfigBuilder
            : OperationBuilder<TestNeonPayConfigBuilder>
        {

            public bool? Sandbox { get; set; }





            internal TestNeonPayConfigBuilder() { }

            internal TestNeonPayConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public TestNeonPayConfigBuilder SetSandbox(bool _sandbox)
            {
                Sandbox = _sandbox;
                return this;
            }





            public TestNeonPayConfig Build(
                NeonPayConfig body
            )
            {
                TestNeonPayConfig op = new TestNeonPayConfig(this,
                    body
                );

                op.SetBaseFields<TestNeonPayConfigBuilder>(this);
                return op;
            }

            public Model.TestResult? Execute(
                NeonPayConfig body
            )
            {
                TestNeonPayConfig op = Build(
                    body
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<Model.TestResult?> ExecuteAsync(
                NeonPayConfig body
            )
            {
                TestNeonPayConfig op = Build(
                    body
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

        private TestNeonPayConfig(TestNeonPayConfigBuilder builder,
            NeonPayConfig body
        )
        {

            if (builder.Sandbox != null) QueryParams["sandbox"] = Convert.ToString(builder.Sandbox)!;




            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public TestNeonPayConfig(
            bool? sandbox,
            Model.NeonPayConfig body
        )
        {

            if (sandbox != null) QueryParams["sandbox"] = Convert.ToString(sandbox)!;




            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/payment/config/merchant/neonpayconfig/test";

        public override HttpMethod Method => HttpMethod.Post;

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