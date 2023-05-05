// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// adminCreateUserOrder
    ///
    /// Admin Create an order. The result contains the checkout link and payment token. User with permission SANDBOX will create sandbox order that not real paid for xsolla/alipay and not validate price for wxpay.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:ORDER", action=1 (CREATE)
    ///   * It will be forbidden while the user is banned: ORDER_INITIATE or ORDER_AND_PAYMENT
    ///   * sandbox default value is false
    ///   * platform default value is Other
    ///   *  Returns : created order
    /// </summary>
    public class AdminCreateUserOrder : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminCreateUserOrderBuilder Builder { get => new AdminCreateUserOrderBuilder(); }

        public class AdminCreateUserOrderBuilder
            : OperationBuilder<AdminCreateUserOrderBuilder>
        {


            public Model.AdminOrderCreate? Body { get; set; }




            internal AdminCreateUserOrderBuilder() { }



            public AdminCreateUserOrderBuilder SetBody(Model.AdminOrderCreate _body)
            {
                Body = _body;
                return this;
            }




            public AdminCreateUserOrder Build(
                string namespace_,
                string userId
            )
            {
                AdminCreateUserOrder op = new AdminCreateUserOrder(this,
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminCreateUserOrder(AdminCreateUserOrderBuilder builder,
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

        public AdminCreateUserOrder(
            string namespace_,            
            string userId,            
            Model.AdminOrderCreate body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/orders";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.OrderInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.OrderInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.OrderInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }

        public Model.OrderInfo<T1>? ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }            
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.OrderInfo<T1>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.OrderInfo<T1>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);            
            throw new HttpResponseException(code, payloadString);
        }
    }

}