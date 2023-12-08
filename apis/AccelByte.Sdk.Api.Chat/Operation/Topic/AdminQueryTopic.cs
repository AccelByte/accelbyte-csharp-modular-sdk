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
    /// adminQueryTopic
    ///
    /// Get topics in a namespace.
    /// </summary>
    public class AdminQueryTopic : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminQueryTopicBuilder Builder { get => new AdminQueryTopicBuilder(); }

        public class AdminQueryTopicBuilder
            : OperationBuilder<AdminQueryTopicBuilder>
        {

            public bool? IncludeMembers { get; set; }

            public bool? IncludePastMembers { get; set; }

            public bool? IncludePastTopics { get; set; }

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public List<string>? Topic { get; set; }

            public AdminQueryTopicTopicSubType? TopicSubType { get; set; }

            public AdminQueryTopicTopicType? TopicType { get; set; }

            public string? UserId { get; set; }





            internal AdminQueryTopicBuilder() { }

            internal AdminQueryTopicBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminQueryTopicBuilder SetIncludeMembers(bool _includeMembers)
            {
                IncludeMembers = _includeMembers;
                return this;
            }

            public AdminQueryTopicBuilder SetIncludePastMembers(bool _includePastMembers)
            {
                IncludePastMembers = _includePastMembers;
                return this;
            }

            public AdminQueryTopicBuilder SetIncludePastTopics(bool _includePastTopics)
            {
                IncludePastTopics = _includePastTopics;
                return this;
            }

            public AdminQueryTopicBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminQueryTopicBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public AdminQueryTopicBuilder SetTopic(List<string> _topic)
            {
                Topic = _topic;
                return this;
            }

            public AdminQueryTopicBuilder SetTopicSubType(AdminQueryTopicTopicSubType _topicSubType)
            {
                TopicSubType = _topicSubType;
                return this;
            }

            public AdminQueryTopicBuilder SetTopicType(AdminQueryTopicTopicType _topicType)
            {
                TopicType = _topicType;
                return this;
            }

            public AdminQueryTopicBuilder SetUserId(string _userId)
            {
                UserId = _userId;
                return this;
            }





            public AdminQueryTopic Build(
                string namespace_
            )
            {
                AdminQueryTopic op = new AdminQueryTopic(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public List<Model.ModelsTopicInfo>? Execute(
                string namespace_
            )
            {
                AdminQueryTopic op = Build(
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

        private AdminQueryTopic(AdminQueryTopicBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.IncludeMembers != null) QueryParams["includeMembers"] = Convert.ToString(builder.IncludeMembers)!;
            if (builder.IncludePastMembers != null) QueryParams["includePastMembers"] = Convert.ToString(builder.IncludePastMembers)!;
            if (builder.IncludePastTopics != null) QueryParams["includePastTopics"] = Convert.ToString(builder.IncludePastTopics)!;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Topic is not null) QueryParams["topic"] = builder.Topic;
            if (builder.TopicSubType is not null) QueryParams["topicSubType"] = builder.TopicSubType.Value;
            if (builder.TopicType is not null) QueryParams["topicType"] = builder.TopicType.Value;
            if (builder.UserId is not null) QueryParams["userId"] = builder.UserId;
            

            
            CollectionFormatMap["topic"] = "multi";
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminQueryTopic(
            string namespace_,            
            bool? includeMembers,            
            bool? includePastMembers,            
            bool? includePastTopics,            
            long? limit,            
            long? offset,            
            List<string>? topic,            
            AdminQueryTopicTopicSubType? topicSubType,            
            AdminQueryTopicTopicType? topicType,            
            string? userId            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (includeMembers != null) QueryParams["includeMembers"] = Convert.ToString(includeMembers)!;
            if (includePastMembers != null) QueryParams["includePastMembers"] = Convert.ToString(includePastMembers)!;
            if (includePastTopics != null) QueryParams["includePastTopics"] = Convert.ToString(includePastTopics)!;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (topic is not null) QueryParams["topic"] = topic;
            if (topicSubType is not null) QueryParams["topicSubType"] = topicSubType.Value;
            if (topicType is not null) QueryParams["topicType"] = topicType.Value;
            if (userId is not null) QueryParams["userId"] = userId;
            

            
            CollectionFormatMap["topic"] = "multi";
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/chat/admin/namespaces/{namespace}/topics";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public List<Model.ModelsTopicInfo>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ModelsTopicInfo>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ModelsTopicInfo>>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

    public class AdminQueryTopicTopicSubType : StringEnum<AdminQueryTopicTopicSubType>
    {
        public static readonly AdminQueryTopicTopicSubType CLAN
            = new AdminQueryTopicTopicSubType("CLAN");

        public static readonly AdminQueryTopicTopicSubType NAMESPACE
            = new AdminQueryTopicTopicSubType("NAMESPACE");

        public static readonly AdminQueryTopicTopicSubType NORMAL
            = new AdminQueryTopicTopicSubType("NORMAL");

        public static readonly AdminQueryTopicTopicSubType PARTY
            = new AdminQueryTopicTopicSubType("PARTY");

        public static readonly AdminQueryTopicTopicSubType SESSION
            = new AdminQueryTopicTopicSubType("SESSION");


        public static implicit operator AdminQueryTopicTopicSubType(string value)
        {
            return NewValue(value);
        }

        public AdminQueryTopicTopicSubType(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class AdminQueryTopicTopicType : StringEnum<AdminQueryTopicTopicType>
    {
        public static readonly AdminQueryTopicTopicType GROUP
            = new AdminQueryTopicTopicType("GROUP");

        public static readonly AdminQueryTopicTopicType PERSONAL
            = new AdminQueryTopicTopicType("PERSONAL");


        public static implicit operator AdminQueryTopicTopicType(string value)
        {
            return NewValue(value);
        }

        public AdminQueryTopicTopicType(string enumValue)
            : base(enumValue)
        {

        }
    }

}