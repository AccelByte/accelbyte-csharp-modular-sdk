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
    /// revokeItems
    ///
    ///  [Not supported yet in AGS Shared Cloud] Revoke items by transactionId.
    /// Other detail info:
    /// 
    ///   * Returns : revoke fulfillment v2 result, storeId field can be ignored.
    /// </summary>
    public class RevokeItems : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RevokeItemsBuilder Builder { get => new RevokeItemsBuilder(); }

        public class RevokeItemsBuilder
            : OperationBuilder<RevokeItemsBuilder>
        {





            internal RevokeItemsBuilder() { }

            internal RevokeItemsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public RevokeItems Build(
                string namespace_,
                string transactionId,
                string userId
            )
            {
                RevokeItems op = new RevokeItems(this,
                    namespace_,                    
                    transactionId,                    
                    userId                    
                );

                op.SetBaseFields<RevokeItemsBuilder>(this);
                return op;
            }

            public Model.RevokeFulfillmentV2Result? Execute(
                string namespace_,
                string transactionId,
                string userId
            )
            {
                RevokeItems op = Build(
                    namespace_,
                    transactionId,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<Model.RevokeFulfillmentV2Result?> ExecuteAsync(
                string namespace_,
                string transactionId,
                string userId
            )
            {
                RevokeItems op = Build(
                    namespace_,
                    transactionId,
                    userId
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

        private RevokeItems(RevokeItemsBuilder builder,
            string namespace_,
            string transactionId,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["transactionId"] = transactionId;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public RevokeItems(
            string namespace_,            
            string transactionId,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["transactionId"] = transactionId;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/v2/admin/namespaces/{namespace}/users/{userId}/fulfillments/{transactionId}/revoke";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.RevokeFulfillmentV2Result? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.RevokeFulfillmentV2Result>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.RevokeFulfillmentV2Result>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}