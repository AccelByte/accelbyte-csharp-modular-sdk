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
    /// publicDeletePaymentAccount
    ///
    ///  [Not supported yet in AGS Shared Cloud] Delete payment account.
    /// Other detail info:
    /// 
    ///   * Returns :
    /// </summary>
    public class PublicDeletePaymentAccount : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicDeletePaymentAccountBuilder Builder { get => new PublicDeletePaymentAccountBuilder(); }

        public class PublicDeletePaymentAccountBuilder
            : OperationBuilder<PublicDeletePaymentAccountBuilder>
        {





            internal PublicDeletePaymentAccountBuilder() { }

            internal PublicDeletePaymentAccountBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicDeletePaymentAccount Build(
                string id,
                string namespace_,
                PublicDeletePaymentAccountType type,
                string userId
            )
            {
                PublicDeletePaymentAccount op = new PublicDeletePaymentAccount(this,
                    id,                    
                    namespace_,                    
                    type,                    
                    userId                    
                );

                op.SetBaseFields<PublicDeletePaymentAccountBuilder>(this);
                return op;
            }

            public PublicDeletePaymentAccount.Response Execute(
                string id,
                string namespace_,
                string type,
                string userId
            )
            {
                PublicDeletePaymentAccount op = Build(
                    id,
                    namespace_,
                    type,
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
            public async Task<PublicDeletePaymentAccount.Response> ExecuteAsync(
                string id,
                string namespace_,
                string type,
                string userId
            )
            {
                PublicDeletePaymentAccount op = Build(
                    id,
                    namespace_,
                    type,
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

        private PublicDeletePaymentAccount(PublicDeletePaymentAccountBuilder builder,
            string id,
            string namespace_,
            PublicDeletePaymentAccountType type,
            string userId
        )
        {
            PathParams["id"] = id;
            PathParams["namespace"] = namespace_;
            PathParams["type"] = type.Value;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {


            protected override string GetFullOperationId() => "Platform::PaymentAccount::PublicDeletePaymentAccount";
        }

        #endregion

        public PublicDeletePaymentAccount(
            string id,            
            string namespace_,            
            PublicDeletePaymentAccountType type,            
            string userId            
        )
        {
            PathParams["id"] = id;
            PathParams["namespace"] = namespace_;
            PathParams["type"] = type.Value;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/payment/accounts/{type}/{id}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public PublicDeletePaymentAccount.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new PublicDeletePaymentAccount.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };


            return response;
        }
    }

    public class PublicDeletePaymentAccountType : StringEnum<PublicDeletePaymentAccountType>
    {
        public static readonly PublicDeletePaymentAccountType Card
            = new PublicDeletePaymentAccountType("card");

        public static readonly PublicDeletePaymentAccountType Paypal
            = new PublicDeletePaymentAccountType("paypal");


        public static implicit operator PublicDeletePaymentAccountType(string value)
        {
            return NewValue(value);
        }

        public PublicDeletePaymentAccountType(string enumValue)
            : base(enumValue)
        {

        }
    }

}