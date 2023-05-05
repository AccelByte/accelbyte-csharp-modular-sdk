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

using AccelByte.Sdk.Api.Ugc.Model;

namespace AccelByte.Sdk.Api.Ugc.Operation
{
    /// <summary>
    /// GetGroupContent
    ///
    /// Required permission NAMESPACE:{namespace}:USER:{userId}:CONTENT [READ].
    /// </summary>
    public class GetGroupContent : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetGroupContentBuilder Builder { get => new GetGroupContentBuilder(); }

        public class GetGroupContentBuilder
            : OperationBuilder<GetGroupContentBuilder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }





            internal GetGroupContentBuilder() { }

            internal GetGroupContentBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetGroupContentBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetGroupContentBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }





            public GetGroupContent Build(
                string groupId,
                string namespace_,
                string userId
            )
            {
                GetGroupContent op = new GetGroupContent(this,
                    groupId,                    
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.ModelsPaginatedContentDownloadResponse? Execute(
                string groupId,
                string namespace_,
                string userId
            )
            {
                GetGroupContent op = Build(
                    groupId,
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

        private GetGroupContent(GetGroupContentBuilder builder,
            string groupId,
            string namespace_,
            string userId
        )
        {
            PathParams["groupId"] = groupId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetGroupContent(
            string groupId,            
            string namespace_,            
            string userId,            
            long? limit,            
            long? offset            
        )
        {
            PathParams["groupId"] = groupId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v1/public/namespaces/{namespace}/users/{userId}/groups/{groupId}/contents";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json","application/octet-stream" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.ModelsPaginatedContentDownloadResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsPaginatedContentDownloadResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsPaginatedContentDownloadResponse>(payload);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}