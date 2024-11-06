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
    /// publicGetPaymentUrl
    ///
    ///  [Not supported yet in AGS Shared Cloud] Get payment url.
    /// Other detail info:
    /// 
    ///   * For Neon Pay payment provider, the 'neonPayConfig' field can be used to provide success and cancel URL. If 'neonPayConfig' field is not present, the 'returnUrl' will be used for both success and cancel URL.
    ///   *  Returns : Get payment link
    /// </summary>
    public class PublicGetPaymentUrl : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetPaymentUrlBuilder Builder { get => new PublicGetPaymentUrlBuilder(); }

        public class PublicGetPaymentUrlBuilder
            : OperationBuilder<PublicGetPaymentUrlBuilder>
        {





            internal PublicGetPaymentUrlBuilder() { }

            internal PublicGetPaymentUrlBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicGetPaymentUrl Build(
                PaymentUrlCreate body,
                string namespace_
            )
            {
                PublicGetPaymentUrl op = new PublicGetPaymentUrl(this,
                    body,                    
                    namespace_                    
                );

                op.SetBaseFields<PublicGetPaymentUrlBuilder>(this);
                return op;
            }

            public PublicGetPaymentUrl.Response Execute(
                PaymentUrlCreate body,
                string namespace_
            )
            {
                PublicGetPaymentUrl op = Build(
                    body,
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
            public async Task<PublicGetPaymentUrl.Response> ExecuteAsync(
                PaymentUrlCreate body,
                string namespace_
            )
            {
                PublicGetPaymentUrl op = Build(
                    body,
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

        private PublicGetPaymentUrl(PublicGetPaymentUrlBuilder builder,
            PaymentUrlCreate body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.PaymentUrl>
        {

            public ErrorEntity? Error400 { get; set; } = null;

            public ErrorEntity? Error403 { get; set; } = null;

            public ErrorEntity? Error404 { get; set; } = null;


            protected override string GetFullOperationId() => "Platform::PaymentStation::PublicGetPaymentUrl";
        }

        #endregion

        public PublicGetPaymentUrl(
            string namespace_,            
            Model.PaymentUrlCreate body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

        }

        public override string Path => "/platform/public/namespaces/{namespace}/payment/link";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public PublicGetPaymentUrl.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new PublicGetPaymentUrl.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.PaymentUrl>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
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