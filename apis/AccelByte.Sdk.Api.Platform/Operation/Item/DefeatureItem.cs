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
    /// defeatureItem
    ///
    /// Remove a feature from an item.
    /// Other detail info:
    /// 
    ///   * Returns : updated item
    /// </summary>
    public class DefeatureItem : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DefeatureItemBuilder Builder { get => new DefeatureItemBuilder(); }

        public class DefeatureItemBuilder
            : OperationBuilder<DefeatureItemBuilder>
        {





            internal DefeatureItemBuilder() { }

            internal DefeatureItemBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DefeatureItem Build(
                string feature,
                string itemId,
                string namespace_,
                string storeId
            )
            {
                DefeatureItem op = new DefeatureItem(this,
                    feature,
                    itemId,
                    namespace_,
                    storeId
                );

                op.SetBaseFields<DefeatureItemBuilder>(this);
                return op;
            }

            public DefeatureItem.Response Execute(
                string feature,
                string itemId,
                string namespace_,
                string storeId
            )
            {
                DefeatureItem op = Build(
                    feature,
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
            public async Task<DefeatureItem.Response> ExecuteAsync(
                string feature,
                string itemId,
                string namespace_,
                string storeId
            )
            {
                DefeatureItem op = Build(
                    feature,
                    itemId,
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

            public DefeatureItem.Response<T1> Execute<T1>(
                string feature,
                string itemId,
                string namespace_,
                string storeId
            )
            {
                DefeatureItem op = Build(
                    feature,
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
            public async Task<DefeatureItem.Response<T1>> ExecuteAsync<T1>(
                string feature,
                string itemId,
                string namespace_,
                string storeId
            )
            {
                DefeatureItem op = Build(
                    feature,
                    itemId,
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

        private DefeatureItem(DefeatureItemBuilder builder,
            string feature,
            string itemId,
            string namespace_,
            string storeId
        )
        {
            PathParams["feature"] = feature;
            PathParams["itemId"] = itemId;
            PathParams["namespace"] = namespace_;

            if (storeId is not null) QueryParams["storeId"] = storeId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.FullItemInfo>
        {

            public ErrorEntity? Error404 { get; set; } = null;

            public ErrorEntity? Error409 { get; set; } = null;


            protected override string GetFullOperationId() => "Platform::Item::DefeatureItem";
        }

        public class Response<T1> : ApiResponse<Model.FullItemInfo<T1>>
        {
            public ErrorEntity? Error404 { get; set; } = null;

            public ErrorEntity? Error409 { get; set; } = null;


            protected override string GetFullOperationId() => "Platform::Item::DefeatureItem";
        }
        #endregion

        public DefeatureItem(
            string feature,
            string itemId,
            string namespace_,
            string storeId
        )
        {
            PathParams["feature"] = feature;
            PathParams["itemId"] = itemId;
            PathParams["namespace"] = namespace_;

            if (storeId is not null) QueryParams["storeId"] = storeId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/items/{itemId}/features/{feature}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public DefeatureItem.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new DefeatureItem.Response()
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

            return response;
        }

        public DefeatureItem.Response<T1> ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new DefeatureItem.Response<T1>()
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

            return response;
        }
    }

}