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
    /// updateItemTypeConfig
    ///
    ///  [Not supported yet in AGS Shared Cloud] This API is used to update an item type config.
    /// 
    /// *  Returns : item type config data
    /// </summary>
    public class UpdateItemTypeConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateItemTypeConfigBuilder Builder { get => new UpdateItemTypeConfigBuilder(); }

        public class UpdateItemTypeConfigBuilder
            : OperationBuilder<UpdateItemTypeConfigBuilder>
        {





            internal UpdateItemTypeConfigBuilder() { }

            internal UpdateItemTypeConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UpdateItemTypeConfig Build(
                ItemTypeConfigUpdate body,
                string id
            )
            {
                UpdateItemTypeConfig op = new UpdateItemTypeConfig(this,
                    body,                    
                    id                    
                );

                op.SetBaseFields<UpdateItemTypeConfigBuilder>(this);
                return op;
            }

            public Model.ItemTypeConfigInfo? Execute(
                ItemTypeConfigUpdate body,
                string id
            )
            {
                UpdateItemTypeConfig op = Build(
                    body,
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
            public async Task<Model.ItemTypeConfigInfo?> ExecuteAsync(
                ItemTypeConfigUpdate body,
                string id
            )
            {
                UpdateItemTypeConfig op = Build(
                    body,
                    id
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

        private UpdateItemTypeConfig(UpdateItemTypeConfigBuilder builder,
            ItemTypeConfigUpdate body,
            string id
        )
        {
            PathParams["id"] = id;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateItemTypeConfig(
            string id,            
            Model.ItemTypeConfigUpdate body            
        )
        {
            PathParams["id"] = id;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/items/configs/{id}";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.ItemTypeConfigInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ItemTypeConfigInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ItemTypeConfigInfo>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}