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
    /// deleteItem
    ///
    /// This API is used to delete an item permanently.
    /// 
    /// force: the default value should be: false. When the value is:
    /// * false: only the items in the draft store that have never been published yet can be removed.
    /// *  true: the item in the draft store(even been published before) can be removed.
    /// </summary>
    public class DeleteItem : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteItemBuilder Builder { get => new DeleteItemBuilder(); }

        public class DeleteItemBuilder
            : OperationBuilder<DeleteItemBuilder>
        {

            public bool? Force { get; set; }

            public string? StoreId { get; set; }





            internal DeleteItemBuilder() { }

            internal DeleteItemBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public DeleteItemBuilder SetForce(bool _force)
            {
                Force = _force;
                return this;
            }

            public DeleteItemBuilder SetStoreId(string _storeId)
            {
                StoreId = _storeId;
                return this;
            }





            public DeleteItem Build(
                string itemId,
                string namespace_
            )
            {
                DeleteItem op = new DeleteItem(this,
                    itemId,
                    namespace_
                );

                op.SetBaseFields<DeleteItemBuilder>(this);
                return op;
            }

            public void Execute(
                string itemId,
                string namespace_
            )
            {
                DeleteItem op = Build(
                    itemId,
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task ExecuteAsync(
                string itemId,
                string namespace_
            )
            {
                DeleteItem op = Build(
                    itemId,
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private DeleteItem(DeleteItemBuilder builder,
            string itemId,
            string namespace_
        )
        {
            PathParams["itemId"] = itemId;
            PathParams["namespace"] = namespace_;

            if (builder.Force != null) QueryParams["force"] = Convert.ToString(builder.Force)!;
            if (builder.StoreId is not null) QueryParams["storeId"] = builder.StoreId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteItem(
            string itemId,
            string namespace_,
            bool? force,
            string? storeId
        )
        {
            PathParams["itemId"] = itemId;
            PathParams["namespace"] = namespace_;

            if (force != null) QueryParams["force"] = Convert.ToString(force)!;
            if (storeId is not null) QueryParams["storeId"] = storeId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/items/{itemId}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}