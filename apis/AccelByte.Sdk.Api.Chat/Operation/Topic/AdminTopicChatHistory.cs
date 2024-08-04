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

using AccelByte.Sdk.Api.Chat.Model;

namespace AccelByte.Sdk.Api.Chat.Operation
{
    /// <summary>
    /// adminTopicChatHistory
    ///
    /// Get chat history in a namespace.
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class AdminTopicChatHistory : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminTopicChatHistoryBuilder Builder { get => new AdminTopicChatHistoryBuilder(); }

        public class AdminTopicChatHistoryBuilder
            : OperationBuilder<AdminTopicChatHistoryBuilder>
        {

            public long? EndCreatedAt { get; set; }

            public string? Keyword { get; set; }

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public string? Order { get; set; }

            public string? SenderUserId { get; set; }

            public string? ShardId { get; set; }

            public long? StartCreatedAt { get; set; }

            public bool? Unfiltered { get; set; }





            internal AdminTopicChatHistoryBuilder() { }

            internal AdminTopicChatHistoryBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminTopicChatHistoryBuilder SetEndCreatedAt(long _endCreatedAt)
            {
                EndCreatedAt = _endCreatedAt;
                return this;
            }

            public AdminTopicChatHistoryBuilder SetKeyword(string _keyword)
            {
                Keyword = _keyword;
                return this;
            }

            public AdminTopicChatHistoryBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminTopicChatHistoryBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public AdminTopicChatHistoryBuilder SetOrder(string _order)
            {
                Order = _order;
                return this;
            }

            public AdminTopicChatHistoryBuilder SetSenderUserId(string _senderUserId)
            {
                SenderUserId = _senderUserId;
                return this;
            }

            public AdminTopicChatHistoryBuilder SetShardId(string _shardId)
            {
                ShardId = _shardId;
                return this;
            }

            public AdminTopicChatHistoryBuilder SetStartCreatedAt(long _startCreatedAt)
            {
                StartCreatedAt = _startCreatedAt;
                return this;
            }

            public AdminTopicChatHistoryBuilder SetUnfiltered(bool _unfiltered)
            {
                Unfiltered = _unfiltered;
                return this;
            }





            public AdminTopicChatHistory Build(
                string namespace_,
                string topic
            )
            {
                AdminTopicChatHistory op = new AdminTopicChatHistory(this,
                    namespace_,
                    topic
                );

                op.SetBaseFields<AdminTopicChatHistoryBuilder>(this);
                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public Model.ModelsChatMessageWithPaginationResponse? Execute(
                string namespace_,
                string topic
            )
            {
                AdminTopicChatHistory op = Build(
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
            public async Task<Model.ModelsChatMessageWithPaginationResponse?> ExecuteAsync(
                string namespace_,
                string topic
            )
            {
                AdminTopicChatHistory op = Build(
                    namespace_,
                    topic
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

        private AdminTopicChatHistory(AdminTopicChatHistoryBuilder builder,
            string namespace_,
            string topic
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["topic"] = topic;

            if (builder.EndCreatedAt != null) QueryParams["endCreatedAt"] = Convert.ToString(builder.EndCreatedAt)!;
            if (builder.Keyword is not null) QueryParams["keyword"] = builder.Keyword;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Order is not null) QueryParams["order"] = builder.Order;
            if (builder.SenderUserId is not null) QueryParams["senderUserId"] = builder.SenderUserId;
            if (builder.ShardId is not null) QueryParams["shardId"] = builder.ShardId;
            if (builder.StartCreatedAt != null) QueryParams["startCreatedAt"] = Convert.ToString(builder.StartCreatedAt)!;
            if (builder.Unfiltered != null) QueryParams["unfiltered"] = Convert.ToString(builder.Unfiltered)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminTopicChatHistory(
            string namespace_,
            string topic,
            long? endCreatedAt,
            string? keyword,
            long? limit,
            long? offset,
            string? order,
            string? senderUserId,
            string? shardId,
            long? startCreatedAt,
            bool? unfiltered
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["topic"] = topic;

            if (endCreatedAt != null) QueryParams["endCreatedAt"] = Convert.ToString(endCreatedAt)!;
            if (keyword is not null) QueryParams["keyword"] = keyword;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (order is not null) QueryParams["order"] = order;
            if (senderUserId is not null) QueryParams["senderUserId"] = senderUserId;
            if (shardId is not null) QueryParams["shardId"] = shardId;
            if (startCreatedAt != null) QueryParams["startCreatedAt"] = Convert.ToString(startCreatedAt)!;
            if (unfiltered != null) QueryParams["unfiltered"] = Convert.ToString(unfiltered)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/chat/admin/namespaces/{namespace}/topic/{topic}/chats";

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