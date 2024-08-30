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
    /// queryRewards
    ///
    /// This API is used to query rewards by criteria.
    /// 
    /// Other detail info:
    /// 
    ///   * Returns : the list of rewards
    /// </summary>
    public class QueryRewards : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QueryRewardsBuilder Builder { get => new QueryRewardsBuilder(); }

        public class QueryRewardsBuilder
            : OperationBuilder<QueryRewardsBuilder>
        {

            public string? EventTopic { get; set; }

            public int? Limit { get; set; }

            public int? Offset { get; set; }

            public List<QueryRewardsSortBy>? SortBy { get; set; }





            internal QueryRewardsBuilder() { }

            internal QueryRewardsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public QueryRewardsBuilder SetEventTopic(string _eventTopic)
            {
                EventTopic = _eventTopic;
                return this;
            }

            public QueryRewardsBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public QueryRewardsBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }

            public QueryRewardsBuilder SetSortBy(List<QueryRewardsSortBy> _sortBy)
            {
                SortBy = _sortBy;
                return this;
            }





            public QueryRewards Build(
                string namespace_
            )
            {
                QueryRewards op = new QueryRewards(this,
                    namespace_                    
                );

                op.SetBaseFields<QueryRewardsBuilder>(this);
                return op;
            }

            public Model.RewardPagingSlicedResult? Execute(
                string namespace_
            )
            {
                QueryRewards op = Build(
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
            public async Task<Model.RewardPagingSlicedResult?> ExecuteAsync(
                string namespace_
            )
            {
                QueryRewards op = Build(
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

        private QueryRewards(QueryRewardsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.EventTopic is not null) QueryParams["eventTopic"] = builder.EventTopic;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.SortBy is not null) QueryParams["sortBy"] = builder.SortBy;
            

            
            CollectionFormatMap["sortBy"] = "csv";
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public QueryRewards(
            string namespace_,            
            string? eventTopic,            
            int? limit,            
            int? offset,            
            List<QueryRewardsSortBy>? sortBy            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (eventTopic is not null) QueryParams["eventTopic"] = eventTopic;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (sortBy is not null) QueryParams["sortBy"] = sortBy;
            

            
            CollectionFormatMap["sortBy"] = "csv";
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/rewards/byCriteria";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.RewardPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.RewardPagingSlicedResult>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.RewardPagingSlicedResult>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

    public class QueryRewardsSortBy : StringEnum<QueryRewardsSortBy>
    {
        public static readonly QueryRewardsSortBy Namespace
            = new QueryRewardsSortBy("namespace");

        public static readonly QueryRewardsSortBy Namespaceasc
            = new QueryRewardsSortBy("namespace:asc");

        public static readonly QueryRewardsSortBy Namespacedesc
            = new QueryRewardsSortBy("namespace:desc");

        public static readonly QueryRewardsSortBy RewardCode
            = new QueryRewardsSortBy("rewardCode");

        public static readonly QueryRewardsSortBy RewardCodeasc
            = new QueryRewardsSortBy("rewardCode:asc");

        public static readonly QueryRewardsSortBy RewardCodedesc
            = new QueryRewardsSortBy("rewardCode:desc");


        public static implicit operator QueryRewardsSortBy(string value)
        {
            return NewValue(value);
        }

        public QueryRewardsSortBy(string enumValue)
            : base(enumValue)
        {

        }
    }

}