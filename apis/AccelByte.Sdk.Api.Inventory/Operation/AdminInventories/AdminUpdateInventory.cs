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

using AccelByte.Sdk.Api.Inventory.Model;

namespace AccelByte.Sdk.Api.Inventory.Operation
{
    /// <summary>
    /// AdminUpdateInventory
    ///
    /// 
    /// Updating an inventory.
    /// MaxSlots will be increased from existing value
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
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ApimodelsInventoryResp? Execute(
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

        public Model.ApimodelsInventoryResp? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsInventoryResp>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsInventoryResp>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}