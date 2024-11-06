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
    /// testXsollaConfig
    ///
    ///  [Not supported yet in AGS Shared Cloud] Check xsolla configuration, Reference: [Xsolla Document](https://developers.xsolla.com/?#simple-checkout).
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
    ///   * Returns : test result
    /// </summary>
    public class TestXsollaConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static TestXsollaConfigBuilder Builder { get => new TestXsollaConfigBuilder(); }

        public class TestXsollaConfigBuilder
            : OperationBuilder<TestXsollaConfigBuilder>
        {





            internal TestXsollaConfigBuilder() { }

            internal TestXsollaConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public TestXsollaConfig Build(
                XsollaConfig body
            )
            {
                TestXsollaConfig op = new TestXsollaConfig(this,
                    body                    
                );

                op.SetBaseFields<TestXsollaConfigBuilder>(this);
                return op;
            }

            public TestXsollaConfig.Response Execute(
                XsollaConfig body
            )
            {
                TestXsollaConfig op = Build(
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
            public async Task<TestXsollaConfig.Response> ExecuteAsync(
                XsollaConfig body
            )
            {
                TestXsollaConfig op = Build(
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

        private TestXsollaConfig(TestXsollaConfigBuilder builder,
            XsollaConfig body
        )
        {
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.TestResult>
        {


            protected override string GetFullOperationId() => "Platform::PaymentConfig::TestXsollaConfig";
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
        
        public TestXsollaConfig.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new TestXsollaConfig.Response()
            {
                StatusCode = code,
                ContentType = contentType
            };

            if (code == (HttpStatusCode)204)
            {
                response.IsSuccess = true;
            }
            else if ((code == (HttpStatusCode)201) || (code == (HttpStatusCode)202) || (code == (HttpStatusCode)200))
            {
                response.Data = JsonSerializer.Deserialize<Model.TestResult>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }

            return response;
        }
    }

}