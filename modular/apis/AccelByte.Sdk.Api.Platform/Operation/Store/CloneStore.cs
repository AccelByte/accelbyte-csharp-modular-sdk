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
    /// cloneStore
    ///
    /// This API is used to clone a store. Usually clone a draft store to published store because published store can't directly edit content.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:STORE", action=1 (CREATE)
    ///   *  Returns : clone store info
    /// </summary>
    public class CloneStore : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CloneStoreBuilder Builder { get => new CloneStoreBuilder(); }

        public class CloneStoreBuilder
            : OperationBuilder<CloneStoreBuilder>
        {

            public string? TargetStoreId { get; set; }





            internal CloneStoreBuilder() { }

            internal CloneStoreBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public CloneStoreBuilder SetTargetStoreId(string _targetStoreId)
            {
                TargetStoreId = _targetStoreId;
                return this;
            }





            public CloneStore Build(
                string namespace_,
                string storeId
            )
            {
                CloneStore op = new CloneStore(this,
                    namespace_,                    
                    storeId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.StoreInfo? Execute(
                string namespace_,
                string storeId
            )
            {
                CloneStore op = Build(
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
        }

        private CloneStore(CloneStoreBuilder builder,
            string namespace_,
            string storeId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["storeId"] = storeId;
            
            if (builder.TargetStoreId is not null) QueryParams["targetStoreId"] = builder.TargetStoreId;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CloneStore(
            string namespace_,            
            string storeId,            
            string? targetStoreId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["storeId"] = storeId;
            
            if (targetStoreId is not null) QueryParams["targetStoreId"] = targetStoreId;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/stores/{storeId}/clone";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.StoreInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.StoreInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.StoreInfo>(payload);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}