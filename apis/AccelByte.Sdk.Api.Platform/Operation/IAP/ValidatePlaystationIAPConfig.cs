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
    /// validatePlaystationIAPConfig
    ///
    /// Validate playstation iap config. Other detail info:
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:IAP:CONFIG", action=4 (UPDATE)
    ///   *  Returns : Test Results
    /// </summary>
    public class ValidatePlaystationIAPConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ValidatePlaystationIAPConfigBuilder Builder { get => new ValidatePlaystationIAPConfigBuilder(); }

        public class ValidatePlaystationIAPConfigBuilder
            : OperationBuilder<ValidatePlaystationIAPConfigBuilder>
        {


            public Model.PlaystationIAPConfigRequest? Body { get; set; }




            internal ValidatePlaystationIAPConfigBuilder() { }

            internal ValidatePlaystationIAPConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public ValidatePlaystationIAPConfigBuilder SetBody(Model.PlaystationIAPConfigRequest _body)
            {
                Body = _body;
                return this;
            }




            public ValidatePlaystationIAPConfig Build(
                string namespace_
            )
            {
                ValidatePlaystationIAPConfig op = new ValidatePlaystationIAPConfig(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.TestResult? Execute(
                string namespace_
            )
            {
                ValidatePlaystationIAPConfig op = Build(
                    namespace_
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

        private ValidatePlaystationIAPConfig(ValidatePlaystationIAPConfigBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public ValidatePlaystationIAPConfig(
            string namespace_,
            Model.PlaystationIAPConfigRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/iap/config/playstation/validate";

        public override HttpMethod Method => HttpMethod.Put;

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