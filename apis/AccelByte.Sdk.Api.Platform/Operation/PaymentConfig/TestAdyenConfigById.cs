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
    /// testAdyenConfigById
    ///
    ///  [Not supported yet in AGS Shared Cloud] Test adyen configuration in payment merchant config. Other detail info:
    /// 
    ///   * Returns : test adyen config
    /// </summary>
    public class TestAdyenConfigById : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static TestAdyenConfigByIdBuilder Builder { get => new TestAdyenConfigByIdBuilder(); }

        public class TestAdyenConfigByIdBuilder
            : OperationBuilder<TestAdyenConfigByIdBuilder>
        {

            public bool? Sandbox { get; set; }





            internal TestAdyenConfigByIdBuilder() { }

            internal TestAdyenConfigByIdBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public TestAdyenConfigByIdBuilder SetSandbox(bool _sandbox)
            {
                Sandbox = _sandbox;
                return this;
            }





            public TestAdyenConfigById Build(
                string id
            )
            {
                TestAdyenConfigById op = new TestAdyenConfigById(this,
                    id
                );

                op.SetBaseFields<TestAdyenConfigByIdBuilder>(this);
                return op;
            }

            public TestAdyenConfigById.Response Execute(
                string id
            )
            {
                TestAdyenConfigById op = Build(
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
            public async Task<TestAdyenConfigById.Response> ExecuteAsync(
                string id
            )
            {
                TestAdyenConfigById op = Build(
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

        private TestAdyenConfigById(TestAdyenConfigByIdBuilder builder,
            string id
        )
        {
            PathParams["id"] = id;

            if (builder.Sandbox != null) QueryParams["sandbox"] = Convert.ToString(builder.Sandbox)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.TestResult>
        {

            public ErrorEntity? Error404 { get; set; } = null;


            protected override string GetFullOperationId() => "Platform::PaymentConfig::TestAdyenConfigById";
        }

        #endregion

        public TestAdyenConfigById(
            string id,
            bool? sandbox
        )
        {
            PathParams["id"] = id;

            if (sandbox != null) QueryParams["sandbox"] = Convert.ToString(sandbox)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/payment/config/merchant/{id}/adyenconfig/test";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public TestAdyenConfigById.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new TestAdyenConfigById.Response()
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
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }

            return response;
        }
    }

}