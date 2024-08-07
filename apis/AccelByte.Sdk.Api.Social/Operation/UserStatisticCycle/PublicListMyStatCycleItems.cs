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
    /// publicListMyStatCycleItems
    ///
    /// List user's statCycleItems by statCycle.
    /// Other detail info:
    ///             *  Returns : stat cycle items
    /// </summary>
    public class PublicListMyStatCycleItems : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicListMyStatCycleItemsBuilder Builder { get => new PublicListMyStatCycleItemsBuilder(); }

        public class PublicListMyStatCycleItemsBuilder
            : OperationBuilder<PublicListMyStatCycleItemsBuilder>
        {

            public int? Limit { get; set; }

            public int? Offset { get; set; }

            public string? SortBy { get; set; }

            public List<string>? StatCodes { get; set; }





            internal PublicListMyStatCycleItemsBuilder() { }

            internal PublicListMyStatCycleItemsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public PublicListMyStatCycleItemsBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public PublicListMyStatCycleItemsBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }

            public PublicListMyStatCycleItemsBuilder SetSortBy(string _sortBy)
            {
                SortBy = _sortBy;
                return this;
            }

            public PublicListMyStatCycleItemsBuilder SetStatCodes(List<string> _statCodes)
            {
                StatCodes = _statCodes;
                return this;
            }





            public PublicListMyStatCycleItems Build(
                string cycleId,
                string namespace_
            )
            {
                PublicListMyStatCycleItems op = new PublicListMyStatCycleItems(this,
                    cycleId,
                    namespace_
                );

                op.SetBaseFields<PublicListMyStatCycleItemsBuilder>(this);
                return op;
            }

            public Model.UserStatCycleItemPagingSlicedResult? Execute(
                string cycleId,
                string namespace_
            )
            {
                PublicListMyStatCycleItems op = Build(
                    cycleId,
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
            public async Task<Model.UserStatCycleItemPagingSlicedResult?> ExecuteAsync(
                string cycleId,
                string namespace_
            )
            {
                PublicListMyStatCycleItems op = Build(
                    cycleId,
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

        private PublicListMyStatCycleItems(PublicListMyStatCycleItemsBuilder builder,
            string cycleId,
            string namespace_
        )
        {
            PathParams["cycleId"] = cycleId;
            PathParams["namespace"] = namespace_;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.SortBy is not null) QueryParams["sortBy"] = builder.SortBy;
            if (builder.StatCodes is not null) QueryParams["statCodes"] = builder.StatCodes;



            CollectionFormatMap["statCodes"] = "multi";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicListMyStatCycleItems(
            string cycleId,
            string namespace_,
            int? limit,
            int? offset,
            string? sortBy,
            List<string>? statCodes
        )
        {
            PathParams["cycleId"] = cycleId;
            PathParams["namespace"] = namespace_;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (sortBy is not null) QueryParams["sortBy"] = sortBy;
            if (statCodes is not null) QueryParams["statCodes"] = statCodes;



            CollectionFormatMap["statCodes"] = "multi";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/v1/public/namespaces/{namespace}/users/me/statCycles/{cycleId}/statCycleitems";

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