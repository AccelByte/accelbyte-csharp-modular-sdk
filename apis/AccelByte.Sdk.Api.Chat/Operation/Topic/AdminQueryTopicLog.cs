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
    /// adminQueryTopicLog
    ///
    /// Get chat log of topic in a namespace.
    /// </summary>
    public class AdminQueryTopicLog : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminQueryTopicLogBuilder Builder { get => new AdminQueryTopicLogBuilder(); }

        public class AdminQueryTopicLogBuilder
            : OperationBuilder<AdminQueryTopicLogBuilder>
        {

            public long? EndCreatedAt { get; set; }

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public string? SenderUserId { get; set; }

            public long? StartCreatedAt { get; set; }

            public string? TopicId { get; set; }

            public List<string>? TopicIds { get; set; }

            public string? UserId { get; set; }





            internal AdminQueryTopicLogBuilder() { }

            internal AdminQueryTopicLogBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminQueryTopicLogBuilder SetEndCreatedAt(long _endCreatedAt)
            {
                EndCreatedAt = _endCreatedAt;
                return this;
            }

            public AdminQueryTopicLogBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminQueryTopicLogBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public AdminQueryTopicLogBuilder SetSenderUserId(string _senderUserId)
            {
                SenderUserId = _senderUserId;
                return this;
            }

            public AdminQueryTopicLogBuilder SetStartCreatedAt(long _startCreatedAt)
            {
                StartCreatedAt = _startCreatedAt;
                return this;
            }

            public AdminQueryTopicLogBuilder SetTopicId(string _topicId)
            {
                TopicId = _topicId;
                return this;
            }

            public AdminQueryTopicLogBuilder SetTopicIds(List<string> _topicIds)
            {
                TopicIds = _topicIds;
                return this;
            }

            public AdminQueryTopicLogBuilder SetUserId(string _userId)
            {
                UserId = _userId;
                return this;
            }





            public AdminQueryTopicLog Build(
                string namespace_
            )
            {
                AdminQueryTopicLog op = new AdminQueryTopicLog(this,
                    namespace_                    
                );

                op.SetBaseFields<AdminQueryTopicLogBuilder>(this);
                return op;
            }

            public AdminQueryTopicLog.Response Execute(
                string namespace_
            )
            {
                AdminQueryTopicLog op = Build(
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
            public async Task<AdminQueryTopicLog.Response> ExecuteAsync(
                string namespace_
            )
            {
                AdminQueryTopicLog op = Build(
                    namespace_
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

        private AdminQueryTopicLog(AdminQueryTopicLogBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.EndCreatedAt != null) QueryParams["endCreatedAt"] = Convert.ToString(builder.EndCreatedAt)!;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.SenderUserId is not null) QueryParams["senderUserId"] = builder.SenderUserId;
            if (builder.StartCreatedAt != null) QueryParams["startCreatedAt"] = Convert.ToString(builder.StartCreatedAt)!;
            if (builder.TopicId is not null) QueryParams["topicId"] = builder.TopicId;
            if (builder.TopicIds is not null) QueryParams["topicIds"] = builder.TopicIds;
            if (builder.UserId is not null) QueryParams["userId"] = builder.UserId;
            

            
            CollectionFormatMap["topicIds"] = "multi";
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelsTopicLogWithPaginationResponse>
        {

            public RestapiErrorResponseBody? Error400 { get; set; } = null;

            public RestapiErrorResponseBody? Error401 { get; set; } = null;

            public RestapiErrorResponseBody? Error403 { get; set; } = null;

            public RestapiErrorResponseBody? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Chat::Topic::AdminQueryTopicLog";
        }

        #endregion

        public AdminQueryTopicLog(
            string namespace_,            
            long? endCreatedAt,            
            long? limit,            
            long? offset,            
            string? senderUserId,            
            long? startCreatedAt,            
            string? topicId,            
            List<string>? topicIds,            
            string? userId            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (endCreatedAt != null) QueryParams["endCreatedAt"] = Convert.ToString(endCreatedAt)!;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (senderUserId is not null) QueryParams["senderUserId"] = senderUserId;
            if (startCreatedAt != null) QueryParams["startCreatedAt"] = Convert.ToString(startCreatedAt)!;
            if (topicId is not null) QueryParams["topicId"] = topicId;
            if (topicIds is not null) QueryParams["topicIds"] = topicIds;
            if (userId is not null) QueryParams["userId"] = userId;
            

            
            CollectionFormatMap["topicIds"] = "multi";
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/chat/admin/namespaces/{namespace}/topic/log";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public AdminQueryTopicLog.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminQueryTopicLog.Response()
            {
                StatusCode = code,
                ContentType = contentType
            };

            if (code == (HttpStatusCode)204)
            {
                response.IsSuccess = true;
            }
            else if ((code == (HttpStatusCode)201) || (code == (HttpStatusCode)202) || (code == (HttpStatusCode)200))
            {
                response.Data = JsonSerializer.Deserialize<Model.ModelsTopicLogWithPaginationResponse>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<RestapiErrorResponseBody>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<RestapiErrorResponseBody>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<RestapiErrorResponseBody>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<RestapiErrorResponseBody>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}