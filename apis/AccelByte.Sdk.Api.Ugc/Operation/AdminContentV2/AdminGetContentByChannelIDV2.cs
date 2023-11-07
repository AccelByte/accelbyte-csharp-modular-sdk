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

using AccelByte.Sdk.Api.Ugc.Model;

namespace AccelByte.Sdk.Api.Ugc.Operation
{
    /// <summary>
    /// AdminGetContentByChannelIDV2
    ///
    /// Required permission ADMIN:NAMESPACE:{namespace}:USER:{userId}:CONTENT [READ].
    /// </summary>
    public class AdminGetContentByChannelIDV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetContentByChannelIDV2Builder Builder { get => new AdminGetContentByChannelIDV2Builder(); }

        public class AdminGetContentByChannelIDV2Builder
            : OperationBuilder<AdminGetContentByChannelIDV2Builder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public string? SortBy { get; set; }





            internal AdminGetContentByChannelIDV2Builder() { }

            internal AdminGetContentByChannelIDV2Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminGetContentByChannelIDV2Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminGetContentByChannelIDV2Builder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public AdminGetContentByChannelIDV2Builder SetSortBy(string _sortBy)
            {
                SortBy = _sortBy;
                return this;
            }





            public AdminGetContentByChannelIDV2 Build(
                string channelId,
                string namespace_
            )
            {
                AdminGetContentByChannelIDV2 op = new AdminGetContentByChannelIDV2(this,
                    channelId,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelsPaginatedContentDownloadResponseV2? Execute(
                string channelId,
                string namespace_
            )
            {
                AdminGetContentByChannelIDV2 op = Build(
                    channelId,
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

        private AdminGetContentByChannelIDV2(AdminGetContentByChannelIDV2Builder builder,
            string channelId,
            string namespace_
        )
        {
            PathParams["channelId"] = channelId;
            PathParams["namespace"] = namespace_;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.SortBy is not null) QueryParams["sortBy"] = builder.SortBy;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetContentByChannelIDV2(
            string channelId,
            string namespace_,
            long? limit,
            long? offset,
            string? sortBy
        )
        {
            PathParams["channelId"] = channelId;
            PathParams["namespace"] = namespace_;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (sortBy is not null) QueryParams["sortBy"] = sortBy;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v2/admin/namespaces/{namespace}/channels/{channelId}/contents";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsPaginatedContentDownloadResponseV2? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsPaginatedContentDownloadResponseV2>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsPaginatedContentDownloadResponseV2>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}