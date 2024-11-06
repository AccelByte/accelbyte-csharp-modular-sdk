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
    /// updateItemPurchaseCondition
    ///
    /// This API is used to update item purchase condition
    /// </summary>
    public class UpdateItemPurchaseCondition : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateItemPurchaseConditionBuilder Builder { get => new UpdateItemPurchaseConditionBuilder(); }

        public class UpdateItemPurchaseConditionBuilder
            : OperationBuilder<UpdateItemPurchaseConditionBuilder>
        {





            internal UpdateItemPurchaseConditionBuilder() { }

            internal UpdateItemPurchaseConditionBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UpdateItemPurchaseCondition Build(
                PurchaseConditionUpdate body,
                string itemId,
                string namespace_,
                string storeId
            )
            {
                UpdateItemPurchaseCondition op = new UpdateItemPurchaseCondition(this,
                    body,                    
                    itemId,                    
                    namespace_,                    
                    storeId                    
                );

                op.SetBaseFields<UpdateItemPurchaseConditionBuilder>(this);
                return op;
            }

            public UpdateItemPurchaseCondition.Response Execute(
                PurchaseConditionUpdate body,
                string itemId,
                string namespace_,
                string storeId
            )
            {
                UpdateItemPurchaseCondition op = Build(
                    body,
                    itemId,
                    namespace_,
                    storeId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<UpdateItemPurchaseCondition.Response> ExecuteAsync(
                PurchaseConditionUpdate body,
                string itemId,
                string namespace_,
                string storeId
            )
            {
                UpdateItemPurchaseCondition op = Build(
                    body,
                    itemId,
                    namespace_,
                    storeId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }

            public UpdateItemPurchaseCondition.Response<T1> Execute<T1>(
                PurchaseConditionUpdate body,
                string itemId,
                string namespace_,
                string storeId
            )
            {
                UpdateItemPurchaseCondition op = Build(
                    body,
                    itemId,
                    namespace_,
                    storeId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse<T1>(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<UpdateItemPurchaseCondition.Response<T1>> ExecuteAsync<T1>(
                PurchaseConditionUpdate body,
                string itemId,
                string namespace_,
                string storeId
            )
            {
                UpdateItemPurchaseCondition op = Build(
                    body,
                    itemId,
                    namespace_,
                    storeId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse<T1>(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
        }

        private UpdateItemPurchaseCondition(UpdateItemPurchaseConditionBuilder builder,
            PurchaseConditionUpdate body,
            string itemId,
            string namespace_,
            string storeId
        )
        {
            PathParams["itemId"] = itemId;
            PathParams["namespace"] = namespace_;
            
            if (storeId is not null) QueryParams["storeId"] = storeId;
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.FullItemInfo>
        {

            public ErrorEntity? Error400 { get; set; } = null;

            public ErrorEntity? Error404 { get; set; } = null;

            public ErrorEntity? Error409 { get; set; } = null;

            public ValidationErrorEntity? Error422 { get; set; } = null;


            protected override string GetFullOperationId() => "Platform::Item::UpdateItemPurchaseCondition";
        }

        public class Response<T1> : ApiResponse<Model.FullItemInfo<T1>>
        {
            public ErrorEntity? Error400 { get; set; } = null;

            public ErrorEntity? Error404 { get; set; } = null;

            public ErrorEntity? Error409 { get; set; } = null;

            public ValidationErrorEntity? Error422 { get; set; } = null;


            protected override string GetFullOperationId() => "Platform::Item::UpdateItemPurchaseCondition";
        }
        #endregion

        public UpdateItemPurchaseCondition(
            string itemId,            
            string namespace_,            
            string storeId,            
            Model.PurchaseConditionUpdate body            
        )
        {
            PathParams["itemId"] = itemId;
            PathParams["namespace"] = namespace_;
            
            if (storeId is not null) QueryParams["storeId"] = storeId;
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/items/{itemId}/purchase/condition";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public UpdateItemPurchaseCondition.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new UpdateItemPurchaseCondition.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.FullItemInfo>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
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

        public UpdateItemPurchaseCondition.Response<T1> ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new UpdateItemPurchaseCondition.Response<T1>()
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
                response.Data = JsonSerializer.Deserialize<Model.FullItemInfo<T1>>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
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