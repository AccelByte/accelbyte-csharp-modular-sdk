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
    /// updateXsollaConfig
    ///
    ///  [Not Supported Yet In Starter] Update xsolla configuration. Reference: [Xsolla Document](https://developers.xsolla.com/?#simple-checkout).
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:PAYMENT:CONFIG", action=4 (UPDATE)
    ///   *  Returns : updated payment merchant config
    /// </summary>
    public class UpdateXsollaConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateXsollaConfigBuilder Builder { get => new UpdateXsollaConfigBuilder(); }

        public class UpdateXsollaConfigBuilder
            : OperationBuilder<UpdateXsollaConfigBuilder>
        {

            public bool? Validate { get; set; }


            public Model.XsollaConfig? Body { get; set; }




            internal UpdateXsollaConfigBuilder() { }

            internal UpdateXsollaConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public UpdateXsollaConfigBuilder SetValidate(bool _validate)
            {
                Validate = _validate;
                return this;
            }


            public UpdateXsollaConfigBuilder SetBody(Model.XsollaConfig _body)
            {
                Body = _body;
                return this;
            }




            public UpdateXsollaConfig Build(
                string id
            )
            {
                UpdateXsollaConfig op = new UpdateXsollaConfig(this,
                    id
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.PaymentMerchantConfigInfo? Execute(
                string id
            )
            {
                UpdateXsollaConfig op = Build(
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

        private UpdateXsollaConfig(UpdateXsollaConfigBuilder builder,
            string id
        )
        {
            PathParams["id"] = id;

            if (builder.Validate != null) QueryParams["validate"] = Convert.ToString(builder.Validate)!;




            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateXsollaConfig(
            string id,
            bool? validate,
            Model.XsollaConfig body
        )
        {
            PathParams["id"] = id;

            if (validate != null) QueryParams["validate"] = Convert.ToString(validate)!;




            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/payment/config/merchant/{id}/xsollaconfig";

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