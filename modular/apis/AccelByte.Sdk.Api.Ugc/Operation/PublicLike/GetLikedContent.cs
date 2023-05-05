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
    /// GetLikedContent
    ///
    /// Requires valid user token.
    /// 
    /// For advance tag filtering supports & as AND operator and | as OR operator and parentheses () for priority. e.g:
    /// 
    /// `tags=red`
    /// 
    /// `tags=red&animal;`
    /// 
    /// `tags=red|animal`
    /// 
    /// `tags=red&animal;|wild`
    /// 
    /// `tags=red&(animal|wild)`
    /// 
    /// The precedence of logical operator is AND > OR, so if no parentheses, AND logical operator will be executed first.
    /// 
    /// Allowed character for operand: alphanumeric, underscore `_` and dash `-`
    /// 
    /// Allowed character for operator: `&` `|` `(` `)`
    /// 
    ///  Please note that value of tags query param should be URL encoded
    /// </summary>
    public class GetLikedContent : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetLikedContentBuilder Builder { get => new GetLikedContentBuilder(); }

        public class GetLikedContentBuilder
            : OperationBuilder<GetLikedContentBuilder>
        {

            public bool? Isofficial { get; set; }

            public long? Limit { get; set; }

            public string? Name { get; set; }

            public long? Offset { get; set; }

            public string? Orderby { get; set; }

            public string? Sortby { get; set; }

            public string? Subtype { get; set; }

            public List<string>? Tags { get; set; }

            public string? Type { get; set; }





            internal GetLikedContentBuilder() { }

            internal GetLikedContentBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetLikedContentBuilder SetIsofficial(bool _isofficial)
            {
                Isofficial = _isofficial;
                return this;
            }

            public GetLikedContentBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetLikedContentBuilder SetName(string _name)
            {
                Name = _name;
                return this;
            }

            public GetLikedContentBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public GetLikedContentBuilder SetOrderby(string _orderby)
            {
                Orderby = _orderby;
                return this;
            }

            public GetLikedContentBuilder SetSortby(string _sortby)
            {
                Sortby = _sortby;
                return this;
            }

            public GetLikedContentBuilder SetSubtype(string _subtype)
            {
                Subtype = _subtype;
                return this;
            }

            public GetLikedContentBuilder SetTags(List<string> _tags)
            {
                Tags = _tags;
                return this;
            }

            public GetLikedContentBuilder SetType(string _type)
            {
                Type = _type;
                return this;
            }





            public GetLikedContent Build(
                string namespace_
            )
            {
                GetLikedContent op = new GetLikedContent(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.ModelsPaginatedContentDownloadResponse? Execute(
                string namespace_
            )
            {
                GetLikedContent op = Build(
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

        private GetLikedContent(GetLikedContentBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.Isofficial != null) QueryParams["isofficial"] = Convert.ToString(builder.Isofficial)!;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Name is not null) QueryParams["name"] = builder.Name;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Orderby is not null) QueryParams["orderby"] = builder.Orderby;
            if (builder.Sortby is not null) QueryParams["sortby"] = builder.Sortby;
            if (builder.Subtype is not null) QueryParams["subtype"] = builder.Subtype;
            if (builder.Tags is not null) QueryParams["tags"] = builder.Tags;
            if (builder.Type is not null) QueryParams["type"] = builder.Type;
            

            
            CollectionFormatMap["tags"] = "csv";
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetLikedContent(
            string namespace_,            
            bool? isofficial,            
            long? limit,            
            string? name,            
            long? offset,            
            string? orderby,            
            string? sortby,            
            string? subtype,            
            List<string>? tags,            
            string? type            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (isofficial != null) QueryParams["isofficial"] = Convert.ToString(isofficial)!;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (name is not null) QueryParams["name"] = name;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (orderby is not null) QueryParams["orderby"] = orderby;
            if (sortby is not null) QueryParams["sortby"] = sortby;
            if (subtype is not null) QueryParams["subtype"] = subtype;
            if (tags is not null) QueryParams["tags"] = tags;
            if (type is not null) QueryParams["type"] = type;
            

            
            CollectionFormatMap["tags"] = "csv";
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v1/public/namespaces/{namespace}/contents/liked";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json","application/octet-stream" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.ModelsPaginatedContentDownloadResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsPaginatedContentDownloadResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsPaginatedContentDownloadResponse>(payload);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}