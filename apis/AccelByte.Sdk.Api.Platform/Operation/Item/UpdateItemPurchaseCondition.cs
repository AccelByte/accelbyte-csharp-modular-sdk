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


            public Model.PurchaseConditionUpdate? Body { get; set; }




            internal UpdateItemPurchaseConditionBuilder() { }

            internal UpdateItemPurchaseConditionBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public UpdateItemPurchaseConditionBuilder SetBody(Model.PurchaseConditionUpdate _body)
            {
                Body = _body;
                return this;
            }




            public UpdateItemPurchaseCondition Build(
                string itemId,
                string namespace_,
                string storeId
            )
            {
                UpdateItemPurchaseCondition op = new UpdateItemPurchaseCondition(this,
                    itemId,
                    namespace_,
                    storeId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.FullItemInfo? Execute(
                string itemId,
                string namespace_,
                string storeId
            )
            {
                UpdateItemPurchaseCondition op = Build(
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

            public Model.FullItemInfo<T1>? Execute<T1>(
                string itemId,
                string namespace_,
                string storeId
            )
            {
                UpdateItemPurchaseCondition op = Build(
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
        }

        private UpdateItemPurchaseCondition(UpdateItemPurchaseConditionBuilder builder,
            string itemId,
            string namespace_,
            string storeId
        )
        {
            PathParams["itemId"] = itemId;
            PathParams["namespace"] = namespace_;

            if (storeId is not null) QueryParams["storeId"] = storeId;




            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
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

        public Model.FullItemInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.FullItemInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.FullItemInfo>(payload);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }

        public Model.FullItemInfo<T1>? ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.FullItemInfo<T1>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.FullItemInfo<T1>>(payload);
            }

            var payloadString = payload.ReadToString();
            throw new HttpResponseException(code, payloadString);
        }
    }

}