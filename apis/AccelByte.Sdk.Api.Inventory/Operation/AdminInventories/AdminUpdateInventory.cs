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
    /// AdminUpdateInventory
    ///
    /// 
    /// Updating an inventory.
    /// Positive value will increase MaxSlots from existing value
    /// Negative value will decrease MaxSlots from existing value
    /// Limited slots can not be changed to unlimited, vice versa
    /// 
    /// Permission: ADMIN:NAMESPACE:{namespace}:USER:{userId}:INVENTORY [UPDATE]
    /// </summary>
    public class AdminUpdateInventory : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpdateInventoryBuilder Builder { get => new AdminUpdateInventoryBuilder(); }

        public class AdminUpdateInventoryBuilder
            : OperationBuilder<AdminUpdateInventoryBuilder>
        {





            internal AdminUpdateInventoryBuilder() { }

            internal AdminUpdateInventoryBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminUpdateInventory Build(
                ApimodelsUpdateInventoryReq body,
                string inventoryId,
                string namespace_
            )
            {
                AdminUpdateInventory op = new AdminUpdateInventory(this,
                    body,                    
                    inventoryId,                    
                    namespace_                    
                );

                op.SetBaseFields<AdminUpdateInventoryBuilder>(this);
                return op;
            }

            public AdminUpdateInventory.Response Execute(
                ApimodelsUpdateInventoryReq body,
                string inventoryId,
                string namespace_
            )
            {
                AdminUpdateInventory op = Build(
                    body,
                    inventoryId,
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<AdminUpdateInventory.Response> ExecuteAsync(
                ApimodelsUpdateInventoryReq body,
                string inventoryId,
                string namespace_
            )
            {
                AdminUpdateInventory op = Build(
                    body,
                    inventoryId,
                    namespace_
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

        private AdminUpdateInventory(AdminUpdateInventoryBuilder builder,
            ApimodelsUpdateInventoryReq body,
            string inventoryId,
            string namespace_
        )
        {
            PathParams["inventoryId"] = inventoryId;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ApimodelsInventoryResp>
        {

            public ApimodelsErrorResponse? Error400 { get; set; } = null;

            public ApimodelsErrorResponse? Error404 { get; set; } = null;

            public ApimodelsErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Inventory::AdminInventories::AdminUpdateInventory";
        }

        #endregion

        public AdminUpdateInventory(
            string inventoryId,            
            string namespace_,            
            Model.ApimodelsUpdateInventoryReq body            
        )
        {
            PathParams["inventoryId"] = inventoryId;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/inventory/v1/admin/namespaces/{namespace}/inventories/{inventoryId}";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public AdminUpdateInventory.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminUpdateInventory.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ApimodelsInventoryResp>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ApimodelsErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<ApimodelsErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
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