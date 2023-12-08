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

using AccelByte.Sdk.Api.Chat.Model;

namespace AccelByte.Sdk.Api.Chat.Operation
{
    /// <summary>
    /// adminTopicMembers
    ///
    /// Get topic members.
    /// </summary>
    public class AdminTopicMembers : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminTopicMembersBuilder Builder { get => new AdminTopicMembersBuilder(); }

        public class AdminTopicMembersBuilder
            : OperationBuilder<AdminTopicMembersBuilder>
        {

            public bool? IsBanned { get; set; }

            public bool? IsModerator { get; set; }

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public string? ShardId { get; set; }





            internal AdminTopicMembersBuilder() { }

            internal AdminTopicMembersBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminTopicMembersBuilder SetIsBanned(bool _isBanned)
            {
                IsBanned = _isBanned;
                return this;
            }

            public AdminTopicMembersBuilder SetIsModerator(bool _isModerator)
            {
                IsModerator = _isModerator;
                return this;
            }

            public AdminTopicMembersBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminTopicMembersBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public AdminTopicMembersBuilder SetShardId(string _shardId)
            {
                ShardId = _shardId;
                return this;
            }





            public AdminTopicMembers Build(
                string namespace_,
                string topic
            )
            {
                AdminTopicMembers op = new AdminTopicMembers(this,
                    namespace_,                    
                    topic                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelsTopicMemberWithPaginationResponse? Execute(
                string namespace_,
                string topic
            )
            {
                AdminTopicMembers op = Build(
                    namespace_,
                    topic
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

        private AdminTopicMembers(AdminTopicMembersBuilder builder,
            string namespace_,
            string topic
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["topic"] = topic;
            
            if (builder.IsBanned != null) QueryParams["isBanned"] = Convert.ToString(builder.IsBanned)!;
            if (builder.IsModerator != null) QueryParams["isModerator"] = Convert.ToString(builder.IsModerator)!;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.ShardId is not null) QueryParams["shardId"] = builder.ShardId;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminTopicMembers(
            string namespace_,            
            string topic,            
            bool? isBanned,            
            bool? isModerator,            
            long? limit,            
            long? offset,            
            string? shardId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["topic"] = topic;
            
            if (isBanned != null) QueryParams["isBanned"] = Convert.ToString(isBanned)!;
            if (isModerator != null) QueryParams["isModerator"] = Convert.ToString(isModerator)!;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (shardId is not null) QueryParams["shardId"] = shardId;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/chat/admin/namespaces/{namespace}/topic/{topic}/members";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.ModelsTopicMemberWithPaginationResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsTopicMemberWithPaginationResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsTopicMemberWithPaginationResponse>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}