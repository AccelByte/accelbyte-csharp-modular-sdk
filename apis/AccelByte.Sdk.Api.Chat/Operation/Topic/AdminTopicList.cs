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
    /// adminTopicList
    ///
    /// Get chat list of topic in a namespace.
    /// </summary>
    public class AdminTopicList : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminTopicListBuilder Builder { get => new AdminTopicListBuilder(); }

        public class AdminTopicListBuilder
            : OperationBuilder<AdminTopicListBuilder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public string? TopicType { get; set; }





            internal AdminTopicListBuilder() { }

            internal AdminTopicListBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminTopicListBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminTopicListBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public AdminTopicListBuilder SetTopicType(string _topicType)
            {
                TopicType = _topicType;
                return this;
            }





            public AdminTopicList Build(
                string namespace_
            )
            {
                AdminTopicList op = new AdminTopicList(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public List<Model.ModelsTopicResponse>? Execute(
                string namespace_
            )
            {
                AdminTopicList op = Build(
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

        private AdminTopicList(AdminTopicListBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.TopicType is not null) QueryParams["topicType"] = builder.TopicType;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminTopicList(
            string namespace_,            
            long? limit,            
            long? offset,            
            string? topicType            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (topicType is not null) QueryParams["topicType"] = topicType;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/chat/admin/namespaces/{namespace}/topic";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public List<Model.ModelsTopicResponse>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ModelsTopicResponse>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ModelsTopicResponse>>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}