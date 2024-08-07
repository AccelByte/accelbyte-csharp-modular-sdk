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

using AccelByte.Sdk.Api.Social.Model;

namespace AccelByte.Sdk.Api.Social.Operation
{
    /// <summary>
    /// getUserStatCycleItems
    ///
    /// List user's statCycleItems by statCycle.
    /// Other detail info:
    ///         *  Returns : stat cycle items
    /// </summary>
    public class GetUserStatCycleItems : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetUserStatCycleItemsBuilder Builder { get => new GetUserStatCycleItemsBuilder(); }

        public class GetUserStatCycleItemsBuilder
            : OperationBuilder<GetUserStatCycleItemsBuilder>
        {

            public bool? IsPublic { get; set; }

            public int? Limit { get; set; }

            public int? Offset { get; set; }

            public string? SortBy { get; set; }

            public string? StatCodes { get; set; }





            internal GetUserStatCycleItemsBuilder() { }

            internal GetUserStatCycleItemsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetUserStatCycleItemsBuilder SetIsPublic(bool _isPublic)
            {
                IsPublic = _isPublic;
                return this;
            }

            public GetUserStatCycleItemsBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetUserStatCycleItemsBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }

            public GetUserStatCycleItemsBuilder SetSortBy(string _sortBy)
            {
                SortBy = _sortBy;
                return this;
            }

            public GetUserStatCycleItemsBuilder SetStatCodes(string _statCodes)
            {
                StatCodes = _statCodes;
                return this;
            }





            public GetUserStatCycleItems Build(
                string cycleId,
                string namespace_,
                string userId
            )
            {
                GetUserStatCycleItems op = new GetUserStatCycleItems(this,
                    cycleId,
                    namespace_,
                    userId
                );

                op.SetBaseFields<GetUserStatCycleItemsBuilder>(this);
                return op;
            }

            public Model.UserStatCycleItemPagingSlicedResult? Execute(
                string cycleId,
                string namespace_,
                string userId
            )
            {
                GetUserStatCycleItems op = Build(
                    cycleId,
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
            public async Task<Model.UserStatCycleItemPagingSlicedResult?> ExecuteAsync(
                string cycleId,
                string namespace_,
                string userId
            )
            {
                GetUserStatCycleItems op = Build(
                    cycleId,
                    namespace_,
                    userId
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

        private GetUserStatCycleItems(GetUserStatCycleItemsBuilder builder,
            string cycleId,
            string namespace_,
            string userId
        )
        {
            PathParams["cycleId"] = cycleId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (builder.IsPublic != null) QueryParams["isPublic"] = Convert.ToString(builder.IsPublic)!;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.SortBy is not null) QueryParams["sortBy"] = builder.SortBy;
            if (builder.StatCodes is not null) QueryParams["statCodes"] = builder.StatCodes;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetUserStatCycleItems(
            string cycleId,
            string namespace_,
            string userId,
            bool? isPublic,
            int? limit,
            int? offset,
            string? sortBy,
            string? statCodes
        )
        {
            PathParams["cycleId"] = cycleId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (isPublic != null) QueryParams["isPublic"] = Convert.ToString(isPublic)!;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (sortBy is not null) QueryParams["sortBy"] = sortBy;
            if (statCodes is not null) QueryParams["statCodes"] = statCodes;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/v1/admin/namespaces/{namespace}/users/{userId}/statCycles/{cycleId}/statCycleitems";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.UserStatCycleItemPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.UserStatCycleItemPagingSlicedResult>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.UserStatCycleItemPagingSlicedResult>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}