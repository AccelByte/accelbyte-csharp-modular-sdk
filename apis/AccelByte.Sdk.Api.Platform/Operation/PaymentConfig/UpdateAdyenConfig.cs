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
    /// updateAdyenConfig
    ///
    ///  [Not Supported Yet In Starter] Update adyen config.
    /// Other detail info:
    /// 
    ///   * Returns : updated payment merchant config
    /// </summary>
    public class UpdateAdyenConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateAdyenConfigBuilder Builder { get => new UpdateAdyenConfigBuilder(); }

        public class UpdateAdyenConfigBuilder
            : OperationBuilder<UpdateAdyenConfigBuilder>
        {

            public bool? Sandbox { get; set; }

            public bool? Validate { get; set; }


            public Model.AdyenConfig? Body { get; set; }




            internal UpdateAdyenConfigBuilder() { }

            internal UpdateAdyenConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public UpdateAdyenConfigBuilder SetSandbox(bool _sandbox)
            {
                Sandbox = _sandbox;
                return this;
            }

            public UpdateAdyenConfigBuilder SetValidate(bool _validate)
            {
                Validate = _validate;
                return this;
            }


            public UpdateAdyenConfigBuilder SetBody(Model.AdyenConfig _body)
            {
                Body = _body;
                return this;
            }




            public UpdateAdyenConfig Build(
                string id
            )
            {
                UpdateAdyenConfig op = new UpdateAdyenConfig(this,
                    id
                );

                op.SetBaseFields<UpdateAdyenConfigBuilder>(this);
                return op;
            }

            public Model.PaymentMerchantConfigInfo? Execute(
                string id
            )
            {
                UpdateAdyenConfig op = Build(
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
            public async Task<Model.PaymentMerchantConfigInfo?> ExecuteAsync(
                string id
            )
            {
                UpdateAdyenConfig op = Build(
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

        private UpdateAdyenConfig(UpdateAdyenConfigBuilder builder,
            string id
        )
        {
            PathParams["id"] = id;

            if (builder.Sandbox != null) QueryParams["sandbox"] = Convert.ToString(builder.Sandbox)!;
            if (builder.Validate != null) QueryParams["validate"] = Convert.ToString(builder.Validate)!;




            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateAdyenConfig(
            string id,
            bool? sandbox,
            bool? validate,
            Model.AdyenConfig body
        )
        {
            PathParams["id"] = id;

            if (sandbox != null) QueryParams["sandbox"] = Convert.ToString(sandbox)!;
            if (validate != null) QueryParams["validate"] = Convert.ToString(validate)!;




            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/payment/config/merchant/{id}/adyenconfig";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.PaymentMerchantConfigInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.PaymentMerchantConfigInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.PaymentMerchantConfigInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}