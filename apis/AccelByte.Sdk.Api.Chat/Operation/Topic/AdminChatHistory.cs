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
    /// adminChatHistory
    ///
    /// Get chat history in a namespace.
    /// </summary>
    public class AdminChatHistory : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminChatHistoryBuilder Builder { get => new AdminChatHistoryBuilder(); }

        public class AdminChatHistoryBuilder
            : OperationBuilder<AdminChatHistoryBuilder>
        {

            public List<string>? ChatId { get; set; }

            public long? EndCreatedAt { get; set; }

            public string? Keyword { get; set; }

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public string? Order { get; set; }

            public string? SenderUserId { get; set; }

            public string? ShardId { get; set; }

            public long? StartCreatedAt { get; set; }

            public List<string>? Topic { get; set; }





            internal AdminChatHistoryBuilder() { }

            internal AdminChatHistoryBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminChatHistoryBuilder SetChatId(List<string> _chatId)
            {
                ChatId = _chatId;
                return this;
            }

            public AdminChatHistoryBuilder SetEndCreatedAt(long _endCreatedAt)
            {
                EndCreatedAt = _endCreatedAt;
                return this;
            }

            public AdminChatHistoryBuilder SetKeyword(string _keyword)
            {
                Keyword = _keyword;
                return this;
            }

            public AdminChatHistoryBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminChatHistoryBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public AdminChatHistoryBuilder SetOrder(string _order)
            {
                Order = _order;
                return this;
            }

            public AdminChatHistoryBuilder SetSenderUserId(string _senderUserId)
            {
                SenderUserId = _senderUserId;
                return this;
            }

            public AdminChatHistoryBuilder SetShardId(string _shardId)
            {
                ShardId = _shardId;
                return this;
            }

            public AdminChatHistoryBuilder SetStartCreatedAt(long _startCreatedAt)
            {
                StartCreatedAt = _startCreatedAt;
                return this;
            }

            public AdminChatHistoryBuilder SetTopic(List<string> _topic)
            {
                Topic = _topic;
                return this;
            }





            public AdminChatHistory Build(
                string namespace_
            )
            {
                AdminChatHistory op = new AdminChatHistory(this,
                    namespace_
                );

                op.SetBaseFields<AdminChatHistoryBuilder>(this);
                return op;
            }

            public Model.ModelsChatMessageWithPaginationResponse? Execute(
                string namespace_
            )
            {
                AdminChatHistory op = Build(
                    namespace_
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

        private AdminChatHistory(AdminChatHistoryBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.ChatId is not null) QueryParams["chatId"] = builder.ChatId;
            if (builder.EndCreatedAt != null) QueryParams["endCreatedAt"] = Convert.ToString(builder.EndCreatedAt)!;
            if (builder.Keyword is not null) QueryParams["keyword"] = builder.Keyword;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Order is not null) QueryParams["order"] = builder.Order;
            if (builder.SenderUserId is not null) QueryParams["senderUserId"] = builder.SenderUserId;
            if (builder.ShardId is not null) QueryParams["shardId"] = builder.ShardId;
            if (builder.StartCreatedAt != null) QueryParams["startCreatedAt"] = Convert.ToString(builder.StartCreatedAt)!;
            if (builder.Topic is not null) QueryParams["topic"] = builder.Topic;



            CollectionFormatMap["chatId"] = "multi";
            CollectionFormatMap["topic"] = "multi";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminChatHistory(
            string namespace_,
            List<string>? chatId,
            long? endCreatedAt,
            string? keyword,
            long? limit,
            long? offset,
            string? order,
            string? senderUserId,
            string? shardId,
            long? startCreatedAt,
            List<string>? topic
        )
        {
            PathParams["namespace"] = namespace_;

            if (chatId is not null) QueryParams["chatId"] = chatId;
            if (endCreatedAt != null) QueryParams["endCreatedAt"] = Convert.ToString(endCreatedAt)!;
            if (keyword is not null) QueryParams["keyword"] = keyword;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (order is not null) QueryParams["order"] = order;
            if (senderUserId is not null) QueryParams["senderUserId"] = senderUserId;
            if (shardId is not null) QueryParams["shardId"] = shardId;
            if (startCreatedAt != null) QueryParams["startCreatedAt"] = Convert.ToString(startCreatedAt)!;
            if (topic is not null) QueryParams["topic"] = topic;



            CollectionFormatMap["chatId"] = "multi";
            CollectionFormatMap["topic"] = "multi";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/chat/admin/namespaces/{namespace}/chats";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsChatMessageWithPaginationResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsChatMessageWithPaginationResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsChatMessageWithPaginationResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}