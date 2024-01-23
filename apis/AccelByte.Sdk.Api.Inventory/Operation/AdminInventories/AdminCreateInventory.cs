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
    /// AdminCreateInventory
    ///
    /// 
    /// Creating an inventory.
    /// The inventory configuration must exists otherwise it will fail.
    /// The max slots and max upgrade slots of an inventory will be initialized according to the inventory configuration it used,
    /// but it can be changed later when using AdminUpdateInventory endpoint.
    /// 
    /// Permission: ADMIN:NAMESPACE:{namespace}:USER:{userId}:INVENTORY [CREATE]
    /// </summary>
    public class AdminCreateInventory : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminCreateInventoryBuilder Builder { get => new AdminCreateInventoryBuilder(); }

        public class AdminCreateInventoryBuilder
            : OperationBuilder<AdminCreateInventoryBuilder>
        {





            internal AdminCreateInventoryBuilder() { }

            internal AdminCreateInventoryBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminCreateInventory Build(
                ApimodelsCreateInventoryReq body,
                string namespace_
            )
            {
                AdminCreateInventory op = new AdminCreateInventory(this,
                    body,
                    namespace_
                );

                op.SetBaseFields<AdminCreateInventoryBuilder>(this);
                return op;
            }

            public Model.ApimodelsInventoryResp? Execute(
                ApimodelsCreateInventoryReq body,
                string namespace_
            )
            {
                AdminCreateInventory op = Build(
                    body,
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

        private AdminCreateInventory(AdminCreateInventoryBuilder builder,
            ApimodelsCreateInventoryReq body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminCreateInventory(
            string namespace_,
            Model.ApimodelsCreateInventoryReq body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/inventory/v1/admin/namespaces/{namespace}/inventories";

        public override HttpMethod Method => HttpMethod.Post;

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