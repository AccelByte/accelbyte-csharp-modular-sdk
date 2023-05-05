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
    /// getItemTypeConfig
    ///
    /// This API is used to get an item type config.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:ITEM:CONFIG", action=2 (READ)
    ///   *  Returns : item type config data
    /// </summary>
    public class GetItemTypeConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetItemTypeConfigBuilder Builder { get => new GetItemTypeConfigBuilder(); }

        public class GetItemTypeConfigBuilder
            : OperationBuilder<GetItemTypeConfigBuilder>
        {





            internal GetItemTypeConfigBuilder() { }

            internal GetItemTypeConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetItemTypeConfig Build(
                string id
            )
            {
                GetItemTypeConfig op = new GetItemTypeConfig(this,
                    id                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.ItemTypeConfigInfo? Execute(
                string id
            )
            {
                GetItemTypeConfig op = Build(
                    id
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

        private GetItemTypeConfig(GetItemTypeConfigBuilder builder,
            string id
        )
        {
            PathParams["id"] = id;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetItemTypeConfig(
            string id            
        )
        {
            PathParams["id"] = id;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/items/configs/{id}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.ItemTypeConfigInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ItemTypeConfigInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ItemTypeConfigInfo>(payload);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}