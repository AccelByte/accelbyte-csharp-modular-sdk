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
    /// createUserPaymentOrder
    ///
    ///  [SERVICE COMMUNICATION ONLY] This API is used to create payment order from justice service. The result contains the payment station url.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:PAYMENT", action=1 (CREATE)
    ///   * It will be forbidden while the user is banned: PAYMENT_INITIATE or ORDER_AND_PAYMENT
    ///   *  Returns : created order
    /// </summary>
    public class CreateUserPaymentOrder : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateUserPaymentOrderBuilder Builder { get => new CreateUserPaymentOrderBuilder(); }

        public class CreateUserPaymentOrderBuilder
            : OperationBuilder<CreateUserPaymentOrderBuilder>
        {


            public Model.PaymentOrderCreate? Body { get; set; }




            internal CreateUserPaymentOrderBuilder() { }

            internal CreateUserPaymentOrderBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public CreateUserPaymentOrderBuilder SetBody(Model.PaymentOrderCreate _body)
            {
                Body = _body;
                return this;
            }




            public CreateUserPaymentOrder Build(
                string namespace_,
                string userId
            )
            {
                CreateUserPaymentOrder op = new CreateUserPaymentOrder(this,
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.PaymentOrderInfo? Execute(
                string namespace_,
                string userId
            )
            {
                CreateUserPaymentOrder op = Build(
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

            public Model.PaymentOrderInfo<T1>? Execute<T1>(
                string namespace_,
                string userId
            )
            {
                CreateUserPaymentOrder op = Build(
                    namespace_,
                    userId
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

        private CreateUserPaymentOrder(CreateUserPaymentOrderBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CreateUserPaymentOrder(
            string namespace_,            
            string userId,            
            Model.PaymentOrderCreate body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/payment/orders";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.PaymentOrderInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.PaymentOrderInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.PaymentOrderInfo>(payload);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }

        public Model.PaymentOrderInfo<T1>? ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }            
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.PaymentOrderInfo<T1>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.PaymentOrderInfo<T1>>(payload);
            }
            
            var payloadString = payload.ReadToString();
            throw new HttpResponseException(code, payloadString);
        }
    }

}