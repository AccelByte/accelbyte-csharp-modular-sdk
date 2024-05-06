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
    /// updatePaymentCallbackConfig
    ///
    ///  [Not Supported Yet In Starter] Update payment callback configuration.
    /// Other detail info:
    /// 
    ///   * Returns : Payment callback config
    /// </summary>
    public class UpdatePaymentCallbackConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdatePaymentCallbackConfigBuilder Builder { get => new UpdatePaymentCallbackConfigBuilder(); }

        public class UpdatePaymentCallbackConfigBuilder
            : OperationBuilder<UpdatePaymentCallbackConfigBuilder>
        {


            public Model.PaymentCallbackConfigUpdate? Body { get; set; }




            internal UpdatePaymentCallbackConfigBuilder() { }

            internal UpdatePaymentCallbackConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public UpdatePaymentCallbackConfigBuilder SetBody(Model.PaymentCallbackConfigUpdate _body)
            {
                Body = _body;
                return this;
            }




            public UpdatePaymentCallbackConfig Build(
                string namespace_
            )
            {
                UpdatePaymentCallbackConfig op = new UpdatePaymentCallbackConfig(this,
                    namespace_
                );

                op.SetBaseFields<UpdatePaymentCallbackConfigBuilder>(this);
                return op;
            }

            public Model.PaymentCallbackConfigInfo? Execute(
                string namespace_
            )
            {
                UpdatePaymentCallbackConfig op = Build(
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
            public async Task<Model.PaymentCallbackConfigInfo?> ExecuteAsync(
                string namespace_
            )
            {
                UpdatePaymentCallbackConfig op = Build(
                    namespace_
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

        private UpdatePaymentCallbackConfig(UpdatePaymentCallbackConfigBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdatePaymentCallbackConfig(
            string namespace_,
            Model.PaymentCallbackConfigUpdate body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/payment/config/callback";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.PaymentCallbackConfigInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.PaymentCallbackConfigInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.PaymentCallbackConfigInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}