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
    /// getPaymentOrderChargeStatus
    ///
    ///  [Not supported yet in AGS Shared Cloud] Get payment order charge status.
    /// Other detail info:
    /// 
    ///   * Returns : payment order charge status
    /// </summary>
    public class GetPaymentOrderChargeStatus : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetPaymentOrderChargeStatusBuilder Builder { get => new GetPaymentOrderChargeStatusBuilder(); }

        public class GetPaymentOrderChargeStatusBuilder
            : OperationBuilder<GetPaymentOrderChargeStatusBuilder>
        {





            internal GetPaymentOrderChargeStatusBuilder() { }

            internal GetPaymentOrderChargeStatusBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetPaymentOrderChargeStatus Build(
                string namespace_,
                string paymentOrderNo
            )
            {
                GetPaymentOrderChargeStatus op = new GetPaymentOrderChargeStatus(this,
                    namespace_,                    
                    paymentOrderNo                    
                );

                op.SetBaseFields<GetPaymentOrderChargeStatusBuilder>(this);
                return op;
            }

            public GetPaymentOrderChargeStatus.Response Execute(
                string namespace_,
                string paymentOrderNo
            )
            {
                GetPaymentOrderChargeStatus op = Build(
                    namespace_,
                    paymentOrderNo
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<GetPaymentOrderChargeStatus.Response> ExecuteAsync(
                string namespace_,
                string paymentOrderNo
            )
            {
                GetPaymentOrderChargeStatus op = Build(
                    namespace_,
                    paymentOrderNo
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

        private GetPaymentOrderChargeStatus(GetPaymentOrderChargeStatusBuilder builder,
            string namespace_,
            string paymentOrderNo
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["paymentOrderNo"] = paymentOrderNo;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.PaymentOrderChargeStatus>
        {

            public ErrorEntity? Error404 { get; set; } = null;


            protected override string GetFullOperationId() => "Platform::Payment::GetPaymentOrderChargeStatus";
        }

        #endregion

        public GetPaymentOrderChargeStatus(
            string namespace_,            
            string paymentOrderNo            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["paymentOrderNo"] = paymentOrderNo;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/payment/orders/{paymentOrderNo}/status";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public GetPaymentOrderChargeStatus.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GetPaymentOrderChargeStatus.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.PaymentOrderChargeStatus>(payload, ResponseJsonOptions);
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