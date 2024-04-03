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

using AccelByte.Sdk.Api.Ugc.Model;

namespace AccelByte.Sdk.Api.Ugc.Operation
{
    /// <summary>
    /// PublicListContentLikeV2
    ///
    /// This endpoint will only display the list of users who performed like from v2 endpoint.
    /// </summary>
    public class PublicListContentLikeV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicListContentLikeV2Builder Builder { get => new PublicListContentLikeV2Builder(); }

        public class PublicListContentLikeV2Builder
            : OperationBuilder<PublicListContentLikeV2Builder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public string? SortBy { get; set; }





            internal PublicListContentLikeV2Builder() { }

            internal PublicListContentLikeV2Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public PublicListContentLikeV2Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public PublicListContentLikeV2Builder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public PublicListContentLikeV2Builder SetSortBy(string _sortBy)
            {
                SortBy = _sortBy;
                return this;
            }





            public PublicListContentLikeV2 Build(
                string contentId,
                string namespace_
            )
            {
                PublicListContentLikeV2 op = new PublicListContentLikeV2(this,
                    contentId,
                    namespace_
                );

                op.SetBaseFields<PublicListContentLikeV2Builder>(this);
                return op;
            }

            public Model.ModelsPaginatedContentLikersResponse? Execute(
                string contentId,
                string namespace_
            )
            {
                PublicListContentLikeV2 op = Build(
                    contentId,
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
            public async Task<Model.ModelsPaginatedContentLikersResponse?> ExecuteAsync(
                string contentId,
                string namespace_
            )
            {
                PublicListContentLikeV2 op = Build(
                    contentId,
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

        private PublicListContentLikeV2(PublicListContentLikeV2Builder builder,
            string contentId,
            string namespace_
        )
        {
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.SortBy is not null) QueryParams["sortBy"] = builder.SortBy;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicListContentLikeV2(
            string contentId,
            string namespace_,
            long? limit,
            long? offset,
            string? sortBy
        )
        {
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (sortBy is not null) QueryParams["sortBy"] = sortBy;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v2/public/namespaces/{namespace}/contents/{contentId}/like";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json", "application/octet-stream" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsPaginatedContentLikersResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsPaginatedContentLikersResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsPaginatedContentLikersResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}