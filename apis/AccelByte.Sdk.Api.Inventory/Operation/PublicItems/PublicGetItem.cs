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

                op.SetBaseFields<PublicGetItemBuilder>(this);
                return op;
            }

            public PublicGetItem.Response Execute(
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
            public async Task<PublicGetItem.Response> ExecuteAsync(
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

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }

            public PublicGetItem.Response<T1, T2, T3> Execute<T1, T2, T3>(
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
                return op.ParseResponse<T1, T2, T3>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<PublicGetItem.Response<T1, T2, T3>> ExecuteAsync<T1, T2, T3>(
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

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse<T1, T2, T3>(
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

        #region Response Part        
        public class Response : ApiResponse<Model.ApimodelsItemResp>
        {

            public ApimodelsErrorResponse? Error400 { get; set; } = null;

            public ApimodelsErrorResponse? Error404 { get; set; } = null;

            public ApimodelsErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Inventory::PublicItems::PublicGetItem";
        }

        public class Response<T1, T2, T3> : ApiResponse<Model.ApimodelsItemResp<T1, T2, T3>>
        {
            public ApimodelsErrorResponse? Error400 { get; set; } = null;

            public ApimodelsErrorResponse? Error404 { get; set; } = null;

            public ApimodelsErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Inventory::PublicItems::PublicGetItem";
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

        public PublicGetItem.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new PublicGetItem.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ApimodelsItemResp>(payload, ResponseJsonOptions);
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

        public PublicGetItem.Response<T1, T2, T3> ParseResponse<T1, T2, T3>(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new PublicGetItem.Response<T1, T2, T3>()
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
                response.Data = JsonSerializer.Deserialize<Model.ApimodelsItemResp<T1, T2, T3>>(payload, ResponseJsonOptions);
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