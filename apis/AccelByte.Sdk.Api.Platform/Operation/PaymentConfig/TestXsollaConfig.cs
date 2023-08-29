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
    /// testXsollaConfig
    ///
    /// Check xsolla configuration, Reference: [Xsolla Document](https://developers.xsolla.com/?#simple-checkout).
    /// 
    /// #### Check List:
    /// 
    ///   * merchantId
    ///   * projectId
    ///   * apiKey
    /// 
    /// 
    /// 
    /// #### Non-check list:
    /// 
    ///   * projectSecretKey
    /// 
    /// Other detail info:
    ///   * Required permission : resource="ADMIN:PAYMENT:CONFIG", action=4 (UPDATE)
    ///   *  Returns : test result
    /// </summary>
    public class TestXsollaConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static TestXsollaConfigBuilder Builder { get => new TestXsollaConfigBuilder(); }

        public class TestXsollaConfigBuilder
            : OperationBuilder<TestXsollaConfigBuilder>
        {


            public Model.XsollaConfig? Body { get; set; }




            internal TestXsollaConfigBuilder() { }

            internal TestXsollaConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public TestXsollaConfigBuilder SetBody(Model.XsollaConfig _body)
            {
                Body = _body;
                return this;
            }




            public TestXsollaConfig Build(
            )
            {
                TestXsollaConfig op = new TestXsollaConfig(this
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.TestResult? Execute(
            )
            {
                TestXsollaConfig op = Build(
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

        private TestXsollaConfig(TestXsollaConfigBuilder builder
        )
        {
            
            

            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public TestXsollaConfig(
            Model.XsollaConfig body            
        )
        {
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/payment/config/merchant/xsollaconfig/test";

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