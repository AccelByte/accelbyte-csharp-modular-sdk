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
    /// adminListPlayerBinaryRecordsV1
    ///
    /// Required permission: `ADMIN:NAMESPACE:{namespace}:USER:{userId}:CLOUDSAVE:RECORD [READ]`
    /// Required scope: `social`
    /// 
    /// Retrieve list of player binary records by namespace.
    /// </summary>
    public class AdminListPlayerBinaryRecordsV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminListPlayerBinaryRecordsV1Builder Builder { get => new AdminListPlayerBinaryRecordsV1Builder(); }

        public class AdminListPlayerBinaryRecordsV1Builder
            : OperationBuilder<AdminListPlayerBinaryRecordsV1Builder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public string? Query { get; set; }





            internal AdminListPlayerBinaryRecordsV1Builder() { }

            internal AdminListPlayerBinaryRecordsV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminListPlayerBinaryRecordsV1Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminListPlayerBinaryRecordsV1Builder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public AdminListPlayerBinaryRecordsV1Builder SetQuery(string _query)
            {
                Query = _query;
                return this;
            }





            public AdminListPlayerBinaryRecordsV1 Build(
                string namespace_,
                string userId
            )
            {
                AdminListPlayerBinaryRecordsV1 op = new AdminListPlayerBinaryRecordsV1(this,
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelsListPlayerBinaryRecordsResponse? Execute(
                string namespace_,
                string userId
            )
            {
                AdminListPlayerBinaryRecordsV1 op = Build(
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

        private AdminListPlayerBinaryRecordsV1(AdminListPlayerBinaryRecordsV1Builder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Query is not null) QueryParams["query"] = builder.Query;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminListPlayerBinaryRecordsV1(
            string namespace_,            
            string userId,            
            long? limit,            
            long? offset,            
            string? query            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (query is not null) QueryParams["query"] = query;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/binaries";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.ModelsListPlayerBinaryRecordsResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsListPlayerBinaryRecordsResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsListPlayerBinaryRecordsResponse>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}