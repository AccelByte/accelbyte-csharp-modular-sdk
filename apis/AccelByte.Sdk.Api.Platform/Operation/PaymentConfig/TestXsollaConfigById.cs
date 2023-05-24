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
    /// testXsollaConfigById
    ///
    /// Test xsolla configuration in payment merchant config. Reference: [Xsolla Document](https://developers.xsolla.com/?#simple-checkout).
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:PAYMENT:CONFIG", action=2 (READ)
    ///   *  Returns : test xsolla config
    /// </summary>
    public class TestXsollaConfigById : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static TestXsollaConfigByIdBuilder Builder { get => new TestXsollaConfigByIdBuilder(); }

        public class TestXsollaConfigByIdBuilder
            : OperationBuilder<TestXsollaConfigByIdBuilder>
        {





            internal TestXsollaConfigByIdBuilder() { }

            internal TestXsollaConfigByIdBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public TestXsollaConfigById Build(
                string id
            )
            {
                TestXsollaConfigById op = new TestXsollaConfigById(this,
                    id
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.TestResult? Execute(
                string id
            )
            {
                TestXsollaConfigById op = Build(
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

        private TestXsollaConfigById(TestXsollaConfigByIdBuilder builder,
            string id
        )
        {
            PathParams["id"] = id;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public TestXsollaConfigById(
            string id
        )
        {
            PathParams["id"] = id;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/payment/config/merchant/{id}/xsollaconfig/test";

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
                return JsonSerializer.Deserialize<Model.TestResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.TestResult>(payload);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}