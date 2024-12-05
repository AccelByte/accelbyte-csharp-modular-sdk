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
    /// publicPreviewOrderPrice
    ///
    /// Preview order price with discount code, this api is used to auto calc order price with discount code.Notes: this api don't do full order validation, only check discount code and calc final order price.Other detail info:
    /// 
    ///   * Returns : previewed order
    /// </summary>
    public class PublicPreviewOrderPrice : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicPreviewOrderPriceBuilder Builder { get => new PublicPreviewOrderPriceBuilder(); }

        public class PublicPreviewOrderPriceBuilder
            : OperationBuilder<PublicPreviewOrderPriceBuilder>
        {





            internal PublicPreviewOrderPriceBuilder() { }

            internal PublicPreviewOrderPriceBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicPreviewOrderPrice Build(
                OrderDiscountPreviewRequest body,
                string namespace_,
                string userId
            )
            {
                PublicPreviewOrderPrice op = new PublicPreviewOrderPrice(this,
                    body,
                    namespace_,
                    userId
                );

                op.SetBaseFields<PublicPreviewOrderPriceBuilder>(this);
                return op;
            }

            public PublicPreviewOrderPrice.Response Execute(
                OrderDiscountPreviewRequest body,
                string namespace_,
                string userId
            )
            {
                PublicPreviewOrderPrice op = Build(
                    body,
                    namespace_,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<PublicPreviewOrderPrice.Response> ExecuteAsync(
                OrderDiscountPreviewRequest body,
                string namespace_,
                string userId
            )
            {
                PublicPreviewOrderPrice op = Build(
                    body,
                    namespace_,
                    userId
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

        private PublicPreviewOrderPrice(PublicPreviewOrderPriceBuilder builder,
            OrderDiscountPreviewRequest body,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.OrderDiscountPreviewResponse>
        {

            public ErrorEntity? Error400 { get; set; } = null;

            public ErrorEntity? Error403 { get; set; } = null;

            public ErrorEntity? Error404 { get; set; } = null;

            public ErrorEntity? Error409 { get; set; } = null;

            public ValidationErrorEntity? Error422 { get; set; } = null;


            protected override string GetFullOperationId() => "Platform::Order::PublicPreviewOrderPrice";
        }

        #endregion

        public PublicPreviewOrderPrice(
            string namespace_,
            string userId,
            Model.OrderDiscountPreviewRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/orders/discount/preview";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public PublicPreviewOrderPrice.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new PublicPreviewOrderPrice.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.OrderDiscountPreviewResponse>(payload, ResponseJsonOptions);
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
            else if (code == (HttpStatusCode)409)
            {
                response.Error409 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error409!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)422)
            {
                response.Error422 = JsonSerializer.Deserialize<ValidationErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error422!.TranslateToApiError();
            }

            return response;
        }
    }

}