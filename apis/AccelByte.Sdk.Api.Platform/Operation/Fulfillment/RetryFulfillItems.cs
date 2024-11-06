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
    /// retryFulfillItems
    ///
    ///  [Not supported yet in AGS Shared Cloud] Retry fulfill items by transactionId without sending the original payload.
    /// Other detail info:
    /// 
    ///   * Returns : fulfillment v2 result, storeId field can be ignored.
    /// </summary>
    public class RetryFulfillItems : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RetryFulfillItemsBuilder Builder { get => new RetryFulfillItemsBuilder(); }

        public class RetryFulfillItemsBuilder
            : OperationBuilder<RetryFulfillItemsBuilder>
        {





            internal RetryFulfillItemsBuilder() { }

            internal RetryFulfillItemsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public RetryFulfillItems Build(
                string namespace_,
                string transactionId,
                string userId
            )
            {
                RetryFulfillItems op = new RetryFulfillItems(this,
                    namespace_,                    
                    transactionId,                    
                    userId                    
                );

                op.SetBaseFields<RetryFulfillItemsBuilder>(this);
                return op;
            }

            public RetryFulfillItems.Response Execute(
                string namespace_,
                string transactionId,
                string userId
            )
            {
                RetryFulfillItems op = Build(
                    namespace_,
                    transactionId,
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
            public async Task<RetryFulfillItems.Response> ExecuteAsync(
                string namespace_,
                string transactionId,
                string userId
            )
            {
                RetryFulfillItems op = Build(
                    namespace_,
                    transactionId,
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

        private RetryFulfillItems(RetryFulfillItemsBuilder builder,
            string namespace_,
            string transactionId,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["transactionId"] = transactionId;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.FulfillmentV2Result>
        {

            public ErrorEntity? Error404 { get; set; } = null;

            public FulfillmentV2Result? Error409 { get; set; } = null;


            protected override string GetFullOperationId() => "Platform::Fulfillment::RetryFulfillItems";
        }

        #endregion

        public RetryFulfillItems(
            string namespace_,            
            string transactionId,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["transactionId"] = transactionId;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/v2/admin/namespaces/{namespace}/users/{userId}/fulfillments/{transactionId}/retry";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public RetryFulfillItems.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new RetryFulfillItems.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.FulfillmentV2Result>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)409)
            {
                response.Error409 = JsonSerializer.Deserialize<FulfillmentV2Result>(payload, ResponseJsonOptions);
                response.Error = response.Error409!.TranslateToApiError();
            }

            return response;
        }
    }

}