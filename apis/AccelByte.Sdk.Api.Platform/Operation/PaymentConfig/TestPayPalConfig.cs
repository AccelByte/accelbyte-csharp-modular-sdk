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
    /// testPayPalConfig
    ///
    ///  [Not Supported Yet In Starter] Test PayPal configuration.
    /// 
    /// #### Check List:
    /// 
    ///   * clientID
    ///   * clientSecret
    /// 
    /// 
    /// 
    /// #### Non-check list:
    /// 
    ///   * webHookId
    /// 
    /// Other detail info:
    ///   * Required permission : resource="ADMIN:PAYMENT:CONFIG", action=4 (UPDATE)
    ///   *  Returns : test result
    /// </summary>
    public class TestPayPalConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static TestPayPalConfigBuilder Builder { get => new TestPayPalConfigBuilder(); }

        public class TestPayPalConfigBuilder
            : OperationBuilder<TestPayPalConfigBuilder>
        {

            public bool? Sandbox { get; set; }


            public Model.PayPalConfig? Body { get; set; }




            internal TestPayPalConfigBuilder() { }

            internal TestPayPalConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public TestPayPalConfigBuilder SetSandbox(bool _sandbox)
            {
                Sandbox = _sandbox;
                return this;
            }


            public TestPayPalConfigBuilder SetBody(Model.PayPalConfig _body)
            {
                Body = _body;
                return this;
            }




            public TestPayPalConfig Build(
            )
            {
                TestPayPalConfig op = new TestPayPalConfig(this
                );

                op.SetBaseFields<TestPayPalConfigBuilder>(this);
                return op;
            }

            public Model.TestResult? Execute(
            )
            {
                TestPayPalConfig op = Build(
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

        private TestPayPalConfig(TestPayPalConfigBuilder builder
        )
        {

            if (builder.Sandbox != null) QueryParams["sandbox"] = Convert.ToString(builder.Sandbox)!;




            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public TestPayPalConfig(
            bool? sandbox,
            Model.PayPalConfig body
        )
        {

            if (sandbox != null) QueryParams["sandbox"] = Convert.ToString(sandbox)!;




            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/payment/config/merchant/paypalconfig/test";

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