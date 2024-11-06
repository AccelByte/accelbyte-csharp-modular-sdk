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

using AccelByte.Sdk.Api.Inventory.Model;

namespace AccelByte.Sdk.Api.Inventory.Operation
{
    /// <summary>
    /// AdminBulkSaveItem
    ///
    /// 
    /// This endpoint will be used by client to save the purchased item to user's inventory,
    /// since want to integrate the inventory service to e-commerce, source field will be mandatory to determine the item,
    /// supported field âOTHERâ and âECOMMERCEâ
    /// 
    /// Notes :
    /// source ECOMMERCE, the quantity of ecommerce items saved is dynamically adjusted based on an item's useCount configured in Store.
    /// When saving items, the quantity specified for each item will be multiplied by the useCount
    /// i.e. If the store item is configured with a useCount of 5 and the quantity of a particular item is set to 2 during saving, it will be stored as 10
    /// 
    /// Target inventory will be based on the specified inventoryConfigurationCode. If the inventory exist then will put to the existing one,
    /// if not exist at all then will create at least one inventory, if full then will return failed at the response.
    /// We implement the logic as proportional to store the item to inventory, will loop from createdAt until find the available slots at inventory.
    /// 
    /// Type:
    /// - ingame
    /// - app
    /// - coin
    /// etc..
    /// 
    /// Max length of the payload is 10 items
    /// 
    /// Permission: ADMIN:NAMESPACE:{namespace}:USER:{userId}:INVENTORY:ITEM [CREATE]
    /// </summary>
    public class AdminBulkSaveItem : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminBulkSaveItemBuilder Builder { get => new AdminBulkSaveItemBuilder(); }

        public class AdminBulkSaveItemBuilder
            : OperationBuilder<AdminBulkSaveItemBuilder>
        {





            internal AdminBulkSaveItemBuilder() { }

            internal AdminBulkSaveItemBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminBulkSaveItem Build(
                List<ApimodelsSaveItemReq> body,
                string namespace_,
                string userId
            )
            {
                AdminBulkSaveItem op = new AdminBulkSaveItem(this,
                    body,                    
                    namespace_,                    
                    userId                    
                );

                op.SetBaseFields<AdminBulkSaveItemBuilder>(this);
                return op;
            }

            public AdminBulkSaveItem.Response Execute(
                List<ApimodelsSaveItemReq> body,
                string namespace_,
                string userId
            )
            {
                AdminBulkSaveItem op = Build(
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
            public async Task<AdminBulkSaveItem.Response> ExecuteAsync(
                List<ApimodelsSaveItemReq> body,
                string namespace_,
                string userId
            )
            {
                AdminBulkSaveItem op = Build(
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

        private AdminBulkSaveItem(AdminBulkSaveItemBuilder builder,
            List<ApimodelsSaveItemReq> body,
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
        public class Response : ApiResponse<List<Model.ApimodelsBulkSaveItemResp>>
        {

            public ApimodelsErrorResponse? Error400 { get; set; } = null;

            public ApimodelsErrorResponse? Error401 { get; set; } = null;

            public ApimodelsErrorResponse? Error403 { get; set; } = null;

            public ApimodelsErrorResponse? Error404 { get; set; } = null;

            public ApimodelsErrorResponse? Error422 { get; set; } = null;

            public ApimodelsErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Inventory::AdminItems::AdminBulkSaveItem";
        }

        #endregion

        public AdminBulkSaveItem(
            string namespace_,            
            string userId,            
            List<Model.ApimodelsSaveItemReq> body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/inventory/v1/admin/namespaces/{namespace}/users/{userId}/items/bulk";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public AdminBulkSaveItem.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminBulkSaveItem.Response()
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
                response.Data = JsonSerializer.Deserialize<List<Model.ApimodelsBulkSaveItemResp>>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ApimodelsErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<ApimodelsErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<ApimodelsErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<ApimodelsErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)422)
            {
                response.Error422 = JsonSerializer.Deserialize<ApimodelsErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error422!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<ApimodelsErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}