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
    /// updateXsollaConfig
    ///
    ///  [Not supported yet in AGS Shared Cloud] Update xsolla configuration. Reference: [Xsolla Document](https://developers.xsolla.com/?#simple-checkout).
    /// Other detail info:
    /// 
    ///   * Returns : updated payment merchant config
    /// </summary>
    public class UpdateXsollaConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateXsollaConfigBuilder Builder { get => new UpdateXsollaConfigBuilder(); }

        public class UpdateXsollaConfigBuilder
            : OperationBuilder<UpdateXsollaConfigBuilder>
        {

            public bool? Validate { get; set; }





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





            public UpdateXsollaConfig Build(
                XsollaConfig body,
                string id
            )
            {
                UpdateXsollaConfig op = new UpdateXsollaConfig(this,
                    body,                    
                    id                    
                );

                op.SetBaseFields<UpdateXsollaConfigBuilder>(this);
                return op;
            }

            public UpdateXsollaConfig.Response Execute(
                XsollaConfig body,
                string id
            )
            {
                UpdateXsollaConfig op = Build(
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
            public async Task<UpdateXsollaConfig.Response> ExecuteAsync(
                XsollaConfig body,
                string id
            )
            {
                UpdateXsollaConfig op = Build(
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

        private UpdateXsollaConfig(UpdateXsollaConfigBuilder builder,
            XsollaConfig body,
            string id
        )
        {
            PathParams["id"] = id;
            
            if (builder.Validate != null) QueryParams["validate"] = Convert.ToString(builder.Validate)!;
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.PaymentMerchantConfigInfo>
        {

            public ErrorEntity? Error404 { get; set; } = null;


            protected override string GetFullOperationId() => "Platform::PaymentConfig::UpdateXsollaConfig";
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
        
        public UpdateXsollaConfig.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new UpdateXsollaConfig.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.PaymentMerchantConfigInfo>(payload, ResponseJsonOptions);
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