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
    /// createItem
    ///
    /// This API is used to create an item. APP item only can created in publisher namespace.
    /// 
    /// An item create example:
    /// 
    /// 
    ///     {
    /// 
    ///        "categoryPath": "/games",
    /// 
    ///        "localizations": {
    /// 
    ///            "en": {
    /// 
    ///                "title":"required",
    /// 
    ///                "description":"optional",
    /// 
    ///                "longDescription":"optional",
    /// 
    ///                "localExt": {
    /// 
    ///                       "properties":[
    /// 
    ///                                        {
    /// 
    ///                                            "key1":"value1",
    /// 
    ///                                            "key2":"value2"
    /// 
    ///                                        }
    /// 
    ///                       ],
    /// 
    ///                       "functions":[
    /// 
    ///                                        {
    /// 
    ///                                            "key1":"value1",
    /// 
    ///                                            "key2":"value2"
    /// 
    ///                                        }
    /// 
    ///                      ]
    /// 
    ///                }
    /// 
    ///             }
    /// 
    ///        },
    /// 
    ///        "images": [
    /// 
    ///          {
    /// 
    ///                "as":"optional, image for",
    /// 
    ///                "caption":"optional",
    /// 
    ///                "height":10,
    /// 
    ///                "width":10,
    /// 
    ///                "imageUrl":"http://img-url-required",
    /// 
    ///                "smallImageUrl":"http://small-img-url-required"
    /// 
    ///          }
    /// 
    ///        ],
    /// 
    ///        "thumbnailUrl": "optional, thumbnail url",
    /// 
    ///        "status": "ACTIVE",
    /// 
    ///        "listable": true,
    /// 
    ///        "purchasable": true,
    /// 
    ///        "itemType": "APP(allowed: [APP,COINS,INGAMEITEM,CODE,BUNDLE])",
    /// 
    ///        "name": "required, also will be used as entitlement name",
    /// 
    ///        "entitlementType": "DURABLE(allowed:[DURABLE,CONSUMABLE], should be CONSUMABLE when item type is COINS)",
    /// 
    ///        "useCount": 1(optional, required if the entitlement type is consumable),
    /// 
    ///        "stackable": false,
    /// 
    ///        "appId": "optional, required if itemType is APP",
    /// 
    ///        "appType": "GAME(optional, required if itemType is APP)",
    /// 
    ///        "seasonType": "PASS(optional, required if itemType is SEASON)",
    /// 
    ///        "baseAppId": "optional, set value of game app id if you want to link to a game",
    /// 
    ///        "targetCurrencyCode": "optional, required if itemType is COINS",
    /// 
    ///        "targetNamespace": "optional, required when itemType is INGAMEITEM, the targetNamespace will only take effect when the item
    /// 
    ///        created belongs to the publisher namespace",
    /// 
    ///        "sku": "optional, commonly unique item code",
    /// 
    ///        "regionData": {
    /// 
    ///            "US(store's default region is required)": [
    /// 
    ///              {
    /// 
    ///                 "price":10,
    /// 
    ///                 "discountPercentage": 0(integer, optional, range[0,100], discountedPrice = price  * ((100 - discountPercentage) * 0.01),
    /// 
    ///                   will use it to calculate discounted price if it is not 0),
    /// 
    ///                 "discountAmount":0(integer, optional, range[0,itemPrice], will use it to calculate discounted price if discountPercentage is 0),
    /// 
    ///                 "currencyCode":"code(required, example: USD)",
    /// 
    ///                 "currencyNamespace":"test-ns-required(allow publisher namespace if namespace is publisher namespace, allow publisher and game namespace if namespace is not publisher namespace)",
    /// 
    ///                 "trialPrice":5(required while fixedTrialCycles set, should >=0 and <= price, will same as price if not present),
    /// 
    ///                 "purchaseAt":"optional yyyy-MM-dd'T'HH:mm:ss.SSS'Z'",
    /// 
    ///                 "expireAt":"optional yyyy-MM-dd'T'HH:mm:ss.SSS'Z'",
    /// 
    ///                 "discountPurchaseAt":"optional yyyy-MM-dd'T'HH:mm:ss.SSS'Z'",
    /// 
    ///                 "discountExpireAt":"optional yyyy-MM-dd'T'HH:mm:ss.SSS'Z'"
    /// 
    ///              }
    /// 
    ///            ]
    /// 
    ///        },
    /// 
    ///        "itemIds": [
    /// 
    ///            "itemId"
    /// 
    ///        ],
    /// 
    ///        "itemQty": {
    /// 
    ///            "itemId":1
    /// 
    ///        },
    /// 
    ///        "recurring": {
    /// 
    ///            "cycle":"MONTHLY(allowed: [WEEKLY,MONTHLY,QUARTERLY,YEARLY])",
    /// 
    ///            "fixedFreeDays":0(integer, fixed free days, 0 means not set),
    /// 
    ///            "fixedTrialCycles":0(integer, fixed trial cycles, 0 means not set, will not take effect if fixedFreeDays set),
    /// 
    ///            "graceDays":7(integer, recurring grace days, retry recurring charge within configured days if charge fail, default 7)
    /// 
    ///        },
    /// 
    ///        "tags": [
    /// 
    ///            "exampleTag24"
    /// 
    ///        ],
    /// 
    ///        "features": [
    /// 
    ///            "feature"
    /// 
    ///        ],
    /// 
    ///        "clazz": "weapon",
    /// 
    ///        "boothName": "C_campaign1",
    /// 
    ///        "displayOrder": 1000,
    /// 
    ///        "ext": {
    /// 
    ///            "properties":[
    /// 
    ///                {
    /// 
    ///                    "key1":"value1",
    /// 
    ///                    "key2":"value2"
    /// 
    ///                }
    /// 
    ///            ],
    /// 
    ///            "functions":[
    /// 
    ///                {
    /// 
    ///                    "key1":"value1",
    /// 
    ///                    "key2":"value2"
    /// 
    ///                }
    /// 
    ///            ]
    /// 
    ///        },
    /// 
    ///        "maxCountPerUser": 1(integer, optional, -1 means UNLIMITED),
    /// 
    ///        "maxCount": 1(integer, optional, -1 means UNLIMITED, unset when itemType is CODE)
    /// 
    ///     }
    /// 
    /// Other detail info:
    /// 
    ///   * Returns : created item data
    /// 
    /// 
    /// 
    /// ## Restrictions for item extension and localization extension and inventory config custom attributes
    /// 
    /// 
    /// 1. Cannot use "." as the key name
    /// -
    /// 
    /// 
    ///     { "data.2": "value" }
    /// 
    /// 
    /// 2. Cannot use "$" as the prefix in key names
    /// -
    /// 
    /// 
    ///     { "$data": "value" }
    /// </summary>
    public class CreateItem : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateItemBuilder Builder { get => new CreateItemBuilder(); }

        public class CreateItemBuilder
            : OperationBuilder<CreateItemBuilder>
        {





            internal CreateItemBuilder() { }

            internal CreateItemBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public CreateItem Build(
                ItemCreate body,
                string namespace_,
                string storeId
            )
            {
                CreateItem op = new CreateItem(this,
                    body,                    
                    namespace_,                    
                    storeId                    
                );

                op.SetBaseFields<CreateItemBuilder>(this);
                return op;
            }

            public CreateItem.Response Execute(
                ItemCreate body,
                string namespace_,
                string storeId
            )
            {
                CreateItem op = Build(
                    body,
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
            public async Task<CreateItem.Response> ExecuteAsync(
                ItemCreate body,
                string namespace_,
                string storeId
            )
            {
                CreateItem op = Build(
                    body,
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

            public CreateItem.Response<T1> Execute<T1>(
                ItemCreate body,
                string namespace_,
                string storeId
            )
            {
                CreateItem op = Build(
                    body,
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
            public async Task<CreateItem.Response<T1>> ExecuteAsync<T1>(
                ItemCreate body,
                string namespace_,
                string storeId
            )
            {
                CreateItem op = Build(
                    body,
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

        private CreateItem(CreateItemBuilder builder,
            ItemCreate body,
            string namespace_,
            string storeId
        )
        {
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


            protected override string GetFullOperationId() => "Platform::Item::CreateItem";
        }

        public class Response<T1> : ApiResponse<Model.FullItemInfo<T1>>
        {
            public ErrorEntity? Error400 { get; set; } = null;

            public ErrorEntity? Error404 { get; set; } = null;

            public ErrorEntity? Error409 { get; set; } = null;

            public ValidationErrorEntity? Error422 { get; set; } = null;


            protected override string GetFullOperationId() => "Platform::Item::CreateItem";
        }
        #endregion

        public CreateItem(
            string namespace_,            
            string storeId,            
            Model.ItemCreate body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (storeId is not null) QueryParams["storeId"] = storeId;
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/items";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public CreateItem.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new CreateItem.Response()
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

        public CreateItem.Response<T1> ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new CreateItem.Response<T1>()
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