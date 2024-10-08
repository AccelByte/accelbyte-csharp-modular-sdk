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
    /// updateWxPayConfigCert
    ///
    ///  [Not supported yet in AGS Shared Cloud] Upload wxpay cert file.
    /// Other detail info:
    /// 
    ///   * Returns : updated payment merchant config
    /// </summary>
    public class UpdateWxPayConfigCert : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateWxPayConfigCertBuilder Builder { get => new UpdateWxPayConfigCertBuilder(); }

        public class UpdateWxPayConfigCertBuilder
            : OperationBuilder<UpdateWxPayConfigCertBuilder>
        {



            public Stream? File { get; set; }



            internal UpdateWxPayConfigCertBuilder() { }

            internal UpdateWxPayConfigCertBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }




            public UpdateWxPayConfigCertBuilder SetFile(Stream _file)
            {
                File = _file;
                return this;
            }



            public UpdateWxPayConfigCert Build(
                string id
            )
            {
                UpdateWxPayConfigCert op = new UpdateWxPayConfigCert(this,
                    id
                );

                op.SetBaseFields<UpdateWxPayConfigCertBuilder>(this);
                return op;
            }

            public Model.PaymentMerchantConfigInfo? Execute(
                string id
            )
            {
                UpdateWxPayConfigCert op = Build(
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
                UpdateWxPayConfigCert op = Build(
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

        private UpdateWxPayConfigCert(UpdateWxPayConfigCertBuilder builder,
            string id
        )
        {
            PathParams["id"] = id;


            if (builder.File is not null) FormParams["file"] = builder.File;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateWxPayConfigCert(
            string id,
            Stream? file
        )
        {
            PathParams["id"] = id;


            if (file is not null) FormParams["file"] = file;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/payment/config/merchant/{id}/wxpayconfig/cert";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "multipart/form-data" };

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