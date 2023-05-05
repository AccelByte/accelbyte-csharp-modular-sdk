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
    /// getView
    ///
    /// This API is used to get a view.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:STORE", action=2 (READ)
    ///   *  Returns : view data
    /// </summary>
    public class GetView : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetViewBuilder Builder { get => new GetViewBuilder(); }

        public class GetViewBuilder
            : OperationBuilder<GetViewBuilder>
        {

            public string? StoreId { get; set; }





            internal GetViewBuilder() { }

            internal GetViewBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetViewBuilder SetStoreId(string _storeId)
            {
                StoreId = _storeId;
                return this;
            }





            public GetView Build(
                string namespace_,
                string viewId
            )
            {
                GetView op = new GetView(this,
                    namespace_,                    
                    viewId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.FullViewInfo? Execute(
                string namespace_,
                string viewId
            )
            {
                GetView op = Build(
                    namespace_,
                    viewId
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

        private GetView(GetViewBuilder builder,
            string namespace_,
            string viewId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["viewId"] = viewId;
            
            if (builder.StoreId is not null) QueryParams["storeId"] = builder.StoreId;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetView(
            string namespace_,            
            string viewId,            
            string? storeId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["viewId"] = viewId;
            
            if (storeId is not null) QueryParams["storeId"] = storeId;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/views/{viewId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.FullViewInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.FullViewInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.FullViewInfo>(payload);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}