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
    /// simulatePaymentOrderNotification
    ///
    ///  [TEST FACILITY ONLY] Forbidden in live environment. Simulate payment notification on sandbox payment order, usually for test usage to simulate real currency payment notification.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:PAYMENT", action=4 (UPDATE)
    ///   *  Returns : notification process result
    /// </summary>
    public class SimulatePaymentOrderNotification : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SimulatePaymentOrderNotificationBuilder Builder { get => new SimulatePaymentOrderNotificationBuilder(); }

        public class SimulatePaymentOrderNotificationBuilder
            : OperationBuilder<SimulatePaymentOrderNotificationBuilder>
        {


            public Model.PaymentOrderNotifySimulation? Body { get; set; }




            internal SimulatePaymentOrderNotificationBuilder() { }

            internal SimulatePaymentOrderNotificationBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public SimulatePaymentOrderNotificationBuilder SetBody(Model.PaymentOrderNotifySimulation _body)
            {
                Body = _body;
                return this;
            }




            public SimulatePaymentOrderNotification Build(
                string namespace_,
                string paymentOrderNo
            )
            {
                SimulatePaymentOrderNotification op = new SimulatePaymentOrderNotification(this,
                    namespace_,                    
                    paymentOrderNo                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.NotificationProcessResult? Execute(
                string namespace_,
                string paymentOrderNo
            )
            {
                SimulatePaymentOrderNotification op = Build(
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

            public Model.NotificationProcessResult<T1>? Execute<T1>(
                string namespace_,
                string paymentOrderNo
            )
            {
                SimulatePaymentOrderNotification op = Build(
                    namespace_,
                    paymentOrderNo
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse<T1>(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
        }

        private SimulatePaymentOrderNotification(SimulatePaymentOrderNotificationBuilder builder,
            string namespace_,
            string paymentOrderNo
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["paymentOrderNo"] = paymentOrderNo;
            
            

            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public SimulatePaymentOrderNotification(
            string namespace_,            
            string paymentOrderNo,            
            Model.PaymentOrderNotifySimulation body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["paymentOrderNo"] = paymentOrderNo;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/payment/orders/{paymentOrderNo}/simulate-notification";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.NotificationProcessResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.NotificationProcessResult>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.NotificationProcessResult>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }

        public Model.NotificationProcessResult<T1>? ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }            
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.NotificationProcessResult<T1>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.NotificationProcessResult<T1>>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            throw new HttpResponseException(code, payloadString);
        }
    }

}