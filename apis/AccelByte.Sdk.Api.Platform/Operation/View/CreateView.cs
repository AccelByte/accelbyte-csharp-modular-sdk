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
    /// createView
    ///
    /// This API is used to create a view.
    /// 
    /// Other detail info:
    /// 
    ///   * Returns : created a view
    /// 
    /// 
    /// 
    /// ## Restrictions for localization extension
    /// 
    /// 
    /// 1. Cannot use "." as the key name
    /// -
    /// 
    /// 
    ///     { "data.2": "value" }
    /// 
    /// 
    /// 2. Cannot use "$" as the prefix in key names
    /// -
    /// 
    /// 
    ///     { "$data": "value" }
    /// </summary>
    public class CreateView : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateViewBuilder Builder { get => new CreateViewBuilder(); }

        public class CreateViewBuilder
            : OperationBuilder<CreateViewBuilder>
        {





            internal CreateViewBuilder() { }

            internal CreateViewBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public CreateView Build(
                ViewCreate body,
                string namespace_,
                string storeId
            )
            {
                CreateView op = new CreateView(this,
                    body,                    
                    namespace_,                    
                    storeId                    
                );

                op.SetBaseFields<CreateViewBuilder>(this);
                return op;
            }

            public Model.FullViewInfo? Execute(
                ViewCreate body,
                string namespace_,
                string storeId
            )
            {
                CreateView op = Build(
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
            public async Task<Model.FullViewInfo?> ExecuteAsync(
                ViewCreate body,
                string namespace_,
                string storeId
            )
            {
                CreateView op = Build(
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
        }

        private CreateView(CreateViewBuilder builder,
            ViewCreate body,
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

        public CreateView(
            string namespace_,            
            string storeId,            
            Model.ViewCreate body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (storeId is not null) QueryParams["storeId"] = storeId;
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/views";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.FullViewInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.FullViewInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.FullViewInfo>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}