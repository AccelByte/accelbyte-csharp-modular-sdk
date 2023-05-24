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

using AccelByte.Sdk.Api.Social.Model;

namespace AccelByte.Sdk.Api.Social.Operation
{
    /// <summary>
    /// getUserStatCycleItems_1
    ///
    /// List user's statCycleItems by statCycle.
    /// Other detail info:
    ///           *  Required permission : resource="NAMESPACE:{namespace}:USER:{userId}:STATITEM", action=2 (READ)
    ///           *  Returns : stat cycle items
    /// </summary>
    public class GetUserStatCycleItems1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetUserStatCycleItems1Builder Builder { get => new GetUserStatCycleItems1Builder(); }

        public class GetUserStatCycleItems1Builder
            : OperationBuilder<GetUserStatCycleItems1Builder>
        {

            public int? Limit { get; set; }

            public int? Offset { get; set; }

            public string? SortBy { get; set; }

            public string? StatCodes { get; set; }





            internal GetUserStatCycleItems1Builder() { }

            internal GetUserStatCycleItems1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetUserStatCycleItems1Builder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetUserStatCycleItems1Builder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }

            public GetUserStatCycleItems1Builder SetSortBy(string _sortBy)
            {
                SortBy = _sortBy;
                return this;
            }

            public GetUserStatCycleItems1Builder SetStatCodes(string _statCodes)
            {
                StatCodes = _statCodes;
                return this;
            }





            public GetUserStatCycleItems1 Build(
                string cycleId,
                string namespace_,
                string userId
            )
            {
                GetUserStatCycleItems1 op = new GetUserStatCycleItems1(this,
                    cycleId,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.UserStatCycleItemPagingSlicedResult? Execute(
                string cycleId,
                string namespace_,
                string userId
            )
            {
                GetUserStatCycleItems1 op = Build(
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
        }

        private GetUserStatCycleItems1(GetUserStatCycleItems1Builder builder,
            string cycleId,
            string namespace_,
            string userId
        )
        {
            PathParams["cycleId"] = cycleId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.SortBy is not null) QueryParams["sortBy"] = builder.SortBy;
            if (builder.StatCodes is not null) QueryParams["statCodes"] = builder.StatCodes;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetUserStatCycleItems1(
            string cycleId,
            string namespace_,
            string userId,
            int? limit,
            int? offset,
            string? sortBy,
            string? statCodes
        )
        {
            PathParams["cycleId"] = cycleId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (sortBy is not null) QueryParams["sortBy"] = sortBy;
            if (statCodes is not null) QueryParams["statCodes"] = statCodes;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/v1/public/namespaces/{namespace}/users/{userId}/statCycles/{cycleId}/statCycleitems";

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
                return JsonSerializer.Deserialize<Model.UserStatCycleItemPagingSlicedResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.UserStatCycleItemPagingSlicedResult>(payload);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}