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
    /// updateAliPayConfig
    ///
    ///  [Not supported yet in AGS Shared Cloud] Update alipay configuration.
    /// Other detail info:
    /// 
    ///   * Returns : updated payment merchant config
    /// </summary>
    public class UpdateAliPayConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateAliPayConfigBuilder Builder { get => new UpdateAliPayConfigBuilder(); }

        public class UpdateAliPayConfigBuilder
            : OperationBuilder<UpdateAliPayConfigBuilder>
        {

            public bool? Sandbox { get; set; }

            public bool? Validate { get; set; }





            internal UpdateAliPayConfigBuilder() { }

            internal UpdateAliPayConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public UpdateAliPayConfigBuilder SetSandbox(bool _sandbox)
            {
                Sandbox = _sandbox;
                return this;
            }

            public UpdateAliPayConfigBuilder SetValidate(bool _validate)
            {
                Validate = _validate;
                return this;
            }





            public UpdateAliPayConfig Build(
                AliPayConfig body,
                string id
            )
            {
                UpdateAliPayConfig op = new UpdateAliPayConfig(this,
                    body,
                    id
                );

                op.SetBaseFields<UpdateAliPayConfigBuilder>(this);
                return op;
            }

            public Model.PaymentMerchantConfigInfo? Execute(
                AliPayConfig body,
                string id
            )
            {
                UpdateAliPayConfig op = Build(
                    body,
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
                AliPayConfig body,
                string id
            )
            {
                UpdateAliPayConfig op = Build(
                    body,
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

        private UpdateAliPayConfig(UpdateAliPayConfigBuilder builder,
            AliPayConfig body,
            string id
        )
        {
            PathParams["id"] = id;

            if (builder.Sandbox != null) QueryParams["sandbox"] = Convert.ToString(builder.Sandbox)!;
            if (builder.Validate != null) QueryParams["validate"] = Convert.ToString(builder.Validate)!;




            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateAliPayConfig(
            string id,
            bool? sandbox,
            bool? validate,
            Model.AliPayConfig body
        )
        {
            PathParams["id"] = id;

            if (sandbox != null) QueryParams["sandbox"] = Convert.ToString(sandbox)!;
            if (validate != null) QueryParams["validate"] = Convert.ToString(validate)!;




            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/payment/config/merchant/{id}/alipayconfig";

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