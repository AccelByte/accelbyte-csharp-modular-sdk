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
    /// PublicBulkRemoveMyItems
    ///
    /// 
    /// Bulk remove user's own items.
    /// </summary>
    public class PublicBulkRemoveMyItems : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicBulkRemoveMyItemsBuilder Builder { get => new PublicBulkRemoveMyItemsBuilder(); }

        public class PublicBulkRemoveMyItemsBuilder
            : OperationBuilder<PublicBulkRemoveMyItemsBuilder>
        {





            internal PublicBulkRemoveMyItemsBuilder() { }

            internal PublicBulkRemoveMyItemsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicBulkRemoveMyItems Build(
                List<ApimodelsRemoveInventoryItemReq> body,
                string inventoryId,
                string namespace_
            )
            {
                PublicBulkRemoveMyItems op = new PublicBulkRemoveMyItems(this,
                    body,
                    inventoryId,
                    namespace_
                );

                op.SetBaseFields<PublicBulkRemoveMyItemsBuilder>(this);
                return op;
            }

            public PublicBulkRemoveMyItems.Response Execute(
                List<ApimodelsRemoveInventoryItemReq> body,
                string inventoryId,
                string namespace_
            )
            {
                PublicBulkRemoveMyItems op = Build(
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
            public async Task<PublicBulkRemoveMyItems.Response> ExecuteAsync(
                List<ApimodelsRemoveInventoryItemReq> body,
                string inventoryId,
                string namespace_
            )
            {
                PublicBulkRemoveMyItems op = Build(
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

        private PublicBulkRemoveMyItems(PublicBulkRemoveMyItemsBuilder builder,
            List<ApimodelsRemoveInventoryItemReq> body,
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
        public class Response : ApiResponse<List<Model.ApimodelsUpdateItemResp>>
        {

            public ApimodelsErrorResponse? Error400 { get; set; } = null;

            public ApimodelsErrorResponse? Error404 { get; set; } = null;

            public ApimodelsErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Inventory::PublicItems::PublicBulkRemoveMyItems";
        }

        #endregion

        public PublicBulkRemoveMyItems(
            string inventoryId,
            string namespace_,
            List<Model.ApimodelsRemoveInventoryItemReq> body
        )
        {
            PathParams["inventoryId"] = inventoryId;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/inventory/v1/public/namespaces/{namespace}/users/me/inventories/{inventoryId}/items";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public PublicBulkRemoveMyItems.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new PublicBulkRemoveMyItems.Response()
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
                response.Data = JsonSerializer.Deserialize<List<Model.ApimodelsUpdateItemResp>>(payload, ResponseJsonOptions);
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