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
    /// syncInGameItem
    ///
    ///  [Not supported yet in AGS Shared Cloud] This API is used to sync an in game item in game namespace to publisher namespace, only INGAMEITEM, CODE, COINS and SEASON are supported
    /// 
    /// The synced item has an additional field targetItemId besides targetNamespace, mostly this item should not modified manually again.
    /// 
    /// Other detail info:
    /// 
    ///   * Returns : item data
    /// </summary>
    public class SyncInGameItem : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SyncInGameItemBuilder Builder { get => new SyncInGameItemBuilder(); }

        public class SyncInGameItemBuilder
            : OperationBuilder<SyncInGameItemBuilder>
        {





            internal SyncInGameItemBuilder() { }

            internal SyncInGameItemBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public SyncInGameItem Build(
                InGameItemSync body,
                string namespace_,
                string storeId
            )
            {
                SyncInGameItem op = new SyncInGameItem(this,
                    body,                    
                    namespace_,                    
                    storeId                    
                );

                op.SetBaseFields<SyncInGameItemBuilder>(this);
                return op;
            }

            public Model.FullItemInfo? Execute(
                InGameItemSync body,
                string namespace_,
                string storeId
            )
            {
                SyncInGameItem op = Build(
                    body,
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
            public async Task<Model.FullItemInfo?> ExecuteAsync(
                InGameItemSync body,
                string namespace_,
                string storeId
            )
            {
                SyncInGameItem op = Build(
                    body,
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

            public Model.FullItemInfo<T1>? Execute<T1>(
                InGameItemSync body,
                string namespace_,
                string storeId
            )
            {
                SyncInGameItem op = Build(
                    body,
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
            public async Task<Model.FullItemInfo<T1>?> ExecuteAsync<T1>(
                InGameItemSync body,
                string namespace_,
                string storeId
            )
            {
                SyncInGameItem op = Build(
                    body,
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

        private SyncInGameItem(SyncInGameItemBuilder builder,
            InGameItemSync body,
            string namespace_,
            string storeId
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (storeId is not null) QueryParams["storeId"] = storeId;
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public SyncInGameItem(
            string namespace_,            
            string storeId,            
            Model.InGameItemSync body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (storeId is not null) QueryParams["storeId"] = storeId;
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/items";

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
                return JsonSerializer.Deserialize<Model.FullItemInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.FullItemInfo>(payload, ResponseJsonOptions);
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
                return JsonSerializer.Deserialize<Model.FullItemInfo<T1>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.FullItemInfo<T1>>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            throw new HttpResponseException(code, payloadString);
        }
    }

}