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
    /// PublicGetItem
    ///
    /// 
    /// Getting an user's owned item info.
    /// </summary>
    public class PublicGetItem : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetItemBuilder Builder { get => new PublicGetItemBuilder(); }

        public class PublicGetItemBuilder
            : OperationBuilder<PublicGetItemBuilder>
        {





            internal PublicGetItemBuilder() { }

            internal PublicGetItemBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicGetItem Build(
                string inventoryId,
                string namespace_,
                string slotId,
                string sourceItemId
            )
            {
                PublicGetItem op = new PublicGetItem(this,
                    inventoryId,
                    namespace_,
                    slotId,
                    sourceItemId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ApimodelsItemResp? Execute(
                string inventoryId,
                string namespace_,
                string slotId,
                string sourceItemId
            )
            {
                PublicGetItem op = Build(
                    inventoryId,
                    namespace_,
                    slotId,
                    sourceItemId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }

            public Model.ApimodelsItemResp<T1, T2>? Execute<T1, T2>(
                string inventoryId,
                string namespace_,
                string slotId,
                string sourceItemId
            )
            {
                PublicGetItem op = Build(
                    inventoryId,
                    namespace_,
                    slotId,
                    sourceItemId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private PublicGetItem(PublicGetItemBuilder builder,
            string inventoryId,
            string namespace_,
            string slotId,
            string sourceItemId
        )
        {
            PathParams["inventoryId"] = inventoryId;
            PathParams["namespace"] = namespace_;
            PathParams["slotId"] = slotId;
            PathParams["sourceItemId"] = sourceItemId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGetItem(
            string inventoryId,
            string namespace_,
            string slotId,
            string sourceItemId
        )
        {
            PathParams["inventoryId"] = inventoryId;
            PathParams["namespace"] = namespace_;
            PathParams["slotId"] = slotId;
            PathParams["sourceItemId"] = sourceItemId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/inventory/v1/public/namespaces/{namespace}/users/me/inventories/{inventoryId}/slots/{slotId}/sourceItems/{sourceItemId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ApimodelsItemResp? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsItemResp>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsItemResp>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }

        public Model.ApimodelsItemResp<T1, T2>? ParseResponse<T1, T2>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsItemResp<T1, T2>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsItemResp<T1, T2>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();
            throw new HttpResponseException(code, payloadString);
        }
    }

}