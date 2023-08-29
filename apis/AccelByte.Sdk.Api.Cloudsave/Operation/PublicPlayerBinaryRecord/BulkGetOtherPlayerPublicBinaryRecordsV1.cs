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

using AccelByte.Sdk.Api.Cloudsave.Model;

namespace AccelByte.Sdk.Api.Cloudsave.Operation
{
    /// <summary>
    /// bulkGetOtherPlayerPublicBinaryRecordsV1
    ///
    /// Required Permission: `NAMESPACE:{namespace}:USER:{userId}:PUBLIC:CLOUDSAVE:RECORD [READ]`
    /// Required Scope: `social`
    /// 
    /// Retrieve other player public binary record in bulk under given namespace.
    /// Maximum bulk key limit per request 20
    /// </summary>
    public class BulkGetOtherPlayerPublicBinaryRecordsV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static BulkGetOtherPlayerPublicBinaryRecordsV1Builder Builder { get => new BulkGetOtherPlayerPublicBinaryRecordsV1Builder(); }

        public class BulkGetOtherPlayerPublicBinaryRecordsV1Builder
            : OperationBuilder<BulkGetOtherPlayerPublicBinaryRecordsV1Builder>
        {





            internal BulkGetOtherPlayerPublicBinaryRecordsV1Builder() { }

            internal BulkGetOtherPlayerPublicBinaryRecordsV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public BulkGetOtherPlayerPublicBinaryRecordsV1 Build(
                ModelsBulkGetPlayerRecordsRequest body,
                string namespace_,
                string userId
            )
            {
                BulkGetOtherPlayerPublicBinaryRecordsV1 op = new BulkGetOtherPlayerPublicBinaryRecordsV1(this,
                    body,                    
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelsBulkGetPlayerBinaryRecordResponse? Execute(
                ModelsBulkGetPlayerRecordsRequest body,
                string namespace_,
                string userId
            )
            {
                BulkGetOtherPlayerPublicBinaryRecordsV1 op = Build(
                    body,
                    namespace_,
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
        }

        private BulkGetOtherPlayerPublicBinaryRecordsV1(BulkGetOtherPlayerPublicBinaryRecordsV1Builder builder,
            ModelsBulkGetPlayerRecordsRequest body,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public BulkGetOtherPlayerPublicBinaryRecordsV1(
            string namespace_,            
            string userId,            
            Model.ModelsBulkGetPlayerRecordsRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/cloudsave/v1/namespaces/{namespace}/users/{userId}/binaries/public/bulk";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.ModelsBulkGetPlayerBinaryRecordResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsBulkGetPlayerBinaryRecordResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsBulkGetPlayerBinaryRecordResponse>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}