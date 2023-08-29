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
    /// AdminSearchContent
    ///
    /// Required permission ADMIN:NAMESPACE:{namespace}:USER:*:CONTENT [READ]
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
    public class AdminSearchContent : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminSearchContentBuilder Builder { get => new AdminSearchContentBuilder(); }

        public class AdminSearchContentBuilder
            : OperationBuilder<AdminSearchContentBuilder>
        {

            public string? Creator { get; set; }

            public string? Isofficial { get; set; }

            public long? Limit { get; set; }

            public string? Name { get; set; }

            public long? Offset { get; set; }

            public string? Orderby { get; set; }

            public string? Sortby { get; set; }

            public string? Subtype { get; set; }

            public List<string>? Tags { get; set; }

            public string? Type { get; set; }

            public string? UserId { get; set; }





            internal AdminSearchContentBuilder() { }

            internal AdminSearchContentBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminSearchContentBuilder SetCreator(string _creator)
            {
                Creator = _creator;
                return this;
            }

            public AdminSearchContentBuilder SetIsofficial(string _isofficial)
            {
                Isofficial = _isofficial;
                return this;
            }

            public AdminSearchContentBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminSearchContentBuilder SetName(string _name)
            {
                Name = _name;
                return this;
            }

            public AdminSearchContentBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public AdminSearchContentBuilder SetOrderby(string _orderby)
            {
                Orderby = _orderby;
                return this;
            }

            public AdminSearchContentBuilder SetSortby(string _sortby)
            {
                Sortby = _sortby;
                return this;
            }

            public AdminSearchContentBuilder SetSubtype(string _subtype)
            {
                Subtype = _subtype;
                return this;
            }

            public AdminSearchContentBuilder SetTags(List<string> _tags)
            {
                Tags = _tags;
                return this;
            }

            public AdminSearchContentBuilder SetType(string _type)
            {
                Type = _type;
                return this;
            }

            public AdminSearchContentBuilder SetUserId(string _userId)
            {
                UserId = _userId;
                return this;
            }





            public AdminSearchContent Build(
                string namespace_
            )
            {
                AdminSearchContent op = new AdminSearchContent(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelsPaginatedContentDownloadResponse? Execute(
                string namespace_
            )
            {
                AdminSearchContent op = Build(
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

        private AdminSearchContent(AdminSearchContentBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.Creator is not null) QueryParams["creator"] = builder.Creator;
            if (builder.Isofficial is not null) QueryParams["isofficial"] = builder.Isofficial;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Name is not null) QueryParams["name"] = builder.Name;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Orderby is not null) QueryParams["orderby"] = builder.Orderby;
            if (builder.Sortby is not null) QueryParams["sortby"] = builder.Sortby;
            if (builder.Subtype is not null) QueryParams["subtype"] = builder.Subtype;
            if (builder.Tags is not null) QueryParams["tags"] = builder.Tags;
            if (builder.Type is not null) QueryParams["type"] = builder.Type;
            if (builder.UserId is not null) QueryParams["userId"] = builder.UserId;
            

            
            CollectionFormatMap["tags"] = "csv";
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminSearchContent(
            string namespace_,            
            string? creator,            
            string? isofficial,            
            long? limit,            
            string? name,            
            long? offset,            
            string? orderby,            
            string? sortby,            
            string? subtype,            
            List<string>? tags,            
            string? type,            
            string? userId            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (creator is not null) QueryParams["creator"] = creator;
            if (isofficial is not null) QueryParams["isofficial"] = isofficial;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (name is not null) QueryParams["name"] = name;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (orderby is not null) QueryParams["orderby"] = orderby;
            if (sortby is not null) QueryParams["sortby"] = sortby;
            if (subtype is not null) QueryParams["subtype"] = subtype;
            if (tags is not null) QueryParams["tags"] = tags;
            if (type is not null) QueryParams["type"] = type;
            if (userId is not null) QueryParams["userId"] = userId;
            

            
            CollectionFormatMap["tags"] = "csv";
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v1/admin/namespaces/{namespace}/contents/search";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.ModelsPaginatedContentDownloadResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsPaginatedContentDownloadResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsPaginatedContentDownloadResponse>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}