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
    /// bulkUpdateRegionData
    ///
    /// This API is used to update region data of items in bulk
    /// </summary>
    public class BulkUpdateRegionData : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static BulkUpdateRegionDataBuilder Builder { get => new BulkUpdateRegionDataBuilder(); }

        public class BulkUpdateRegionDataBuilder
            : OperationBuilder<BulkUpdateRegionDataBuilder>
        {


            public Model.BulkRegionDataChangeRequest? Body { get; set; }




            internal BulkUpdateRegionDataBuilder() { }

            internal BulkUpdateRegionDataBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public BulkUpdateRegionDataBuilder SetBody(Model.BulkRegionDataChangeRequest _body)
            {
                Body = _body;
                return this;
            }




            public BulkUpdateRegionData Build(
                string namespace_,
                string storeId
            )
            {
                BulkUpdateRegionData op = new BulkUpdateRegionData(this,
                    namespace_,                    
                    storeId                    
                );

                op.SetBaseFields<BulkUpdateRegionDataBuilder>(this);
                return op;
            }

            public void Execute(
                string namespace_,
                string storeId
            )
            {
                BulkUpdateRegionData op = Build(
                    namespace_,
                    storeId
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
                string namespace_,
                string storeId
            )
            {
                BulkUpdateRegionData op = Build(
                    namespace_,
                    storeId
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

        private BulkUpdateRegionData(BulkUpdateRegionDataBuilder builder,
            string namespace_,
            string storeId
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (storeId is not null) QueryParams["storeId"] = storeId;
            

            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public BulkUpdateRegionData(
            string namespace_,            
            string storeId,            
            Model.BulkRegionDataChangeRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (storeId is not null) QueryParams["storeId"] = storeId;
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/items/regiondata";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

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