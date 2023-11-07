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
    /// PublicListContentV2
    ///
    /// 
    /// For advance tag filtering supports & as AND operator and | as OR operator and parentheses () for priority. e.g:
    /// 
    /// `tags=red`
    /// `tags=red&animal;`
    /// `tags=red|animal`
    /// `tags=red&animal;|wild`
    /// `tags=red&(animal|wild)`
    /// 
    /// The precedence of logical operator is AND > OR, so if no parentheses, AND logical operator will be executed first.
    /// 
    /// Allowed character for operand: alphanumeric, underscore `_` and dash `-`
    /// Allowed character for operator: `&` `|` `(` `)`
    /// 
    ///  Please note that value of tags query param should be URL encoded
    /// </summary>
    public class PublicListContentV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicListContentV2Builder Builder { get => new PublicListContentV2Builder(); }

        public class PublicListContentV2Builder
            : OperationBuilder<PublicListContentV2Builder>
        {

            public long? Limit { get; set; }

            public string? Name { get; set; }

            public long? Offset { get; set; }

            public string? SortBy { get; set; }

            public string? SubType { get; set; }

            public List<string>? Tags { get; set; }

            public string? Type { get; set; }





            internal PublicListContentV2Builder() { }

            internal PublicListContentV2Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public PublicListContentV2Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public PublicListContentV2Builder SetName(string _name)
            {
                Name = _name;
                return this;
            }

            public PublicListContentV2Builder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public PublicListContentV2Builder SetSortBy(string _sortBy)
            {
                SortBy = _sortBy;
                return this;
            }

            public PublicListContentV2Builder SetSubType(string _subType)
            {
                SubType = _subType;
                return this;
            }

            public PublicListContentV2Builder SetTags(List<string> _tags)
            {
                Tags = _tags;
                return this;
            }

            public PublicListContentV2Builder SetType(string _type)
            {
                Type = _type;
                return this;
            }





            public PublicListContentV2 Build(
                string namespace_
            )
            {
                PublicListContentV2 op = new PublicListContentV2(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelsPaginatedContentDownloadResponseV2? Execute(
                string namespace_
            )
            {
                PublicListContentV2 op = Build(
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

        private PublicListContentV2(PublicListContentV2Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Name is not null) QueryParams["name"] = builder.Name;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.SortBy is not null) QueryParams["sortBy"] = builder.SortBy;
            if (builder.SubType is not null) QueryParams["subType"] = builder.SubType;
            if (builder.Tags is not null) QueryParams["tags"] = builder.Tags;
            if (builder.Type is not null) QueryParams["type"] = builder.Type;



            CollectionFormatMap["tags"] = "csv";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicListContentV2(
            string namespace_,
            long? limit,
            string? name,
            long? offset,
            string? sortBy,
            string? subType,
            List<string>? tags,
            string? type
        )
        {
            PathParams["namespace"] = namespace_;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (name is not null) QueryParams["name"] = name;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (sortBy is not null) QueryParams["sortBy"] = sortBy;
            if (subType is not null) QueryParams["subType"] = subType;
            if (tags is not null) QueryParams["tags"] = tags;
            if (type is not null) QueryParams["type"] = type;



            CollectionFormatMap["tags"] = "csv";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v2/public/namespaces/{namespace}/contents";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json", "application/octet-stream" };

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