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
    /// PublicSearchContent
    ///
    /// Public user can access without token or if token specified, requires valid user token.
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
    public class PublicSearchContent : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicSearchContentBuilder Builder { get => new PublicSearchContentBuilder(); }

        public class PublicSearchContentBuilder
            : OperationBuilder<PublicSearchContentBuilder>
        {

            public string? Creator { get; set; }

            public string? Ishidden { get; set; }

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





            internal PublicSearchContentBuilder() { }

            internal PublicSearchContentBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public PublicSearchContentBuilder SetCreator(string _creator)
            {
                Creator = _creator;
                return this;
            }

            public PublicSearchContentBuilder SetIshidden(string _ishidden)
            {
                Ishidden = _ishidden;
                return this;
            }

            public PublicSearchContentBuilder SetIsofficial(string _isofficial)
            {
                Isofficial = _isofficial;
                return this;
            }

            public PublicSearchContentBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public PublicSearchContentBuilder SetName(string _name)
            {
                Name = _name;
                return this;
            }

            public PublicSearchContentBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public PublicSearchContentBuilder SetOrderby(string _orderby)
            {
                Orderby = _orderby;
                return this;
            }

            public PublicSearchContentBuilder SetSortby(string _sortby)
            {
                Sortby = _sortby;
                return this;
            }

            public PublicSearchContentBuilder SetSubtype(string _subtype)
            {
                Subtype = _subtype;
                return this;
            }

            public PublicSearchContentBuilder SetTags(List<string> _tags)
            {
                Tags = _tags;
                return this;
            }

            public PublicSearchContentBuilder SetType(string _type)
            {
                Type = _type;
                return this;
            }

            public PublicSearchContentBuilder SetUserId(string _userId)
            {
                UserId = _userId;
                return this;
            }





            public PublicSearchContent Build(
                string namespace_
            )
            {
                PublicSearchContent op = new PublicSearchContent(this,
                    namespace_                    
                );

                op.SetBaseFields<PublicSearchContentBuilder>(this);
                return op;
            }

            public PublicSearchContent.Response Execute(
                string namespace_
            )
            {
                PublicSearchContent op = Build(
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
            public async Task<PublicSearchContent.Response> ExecuteAsync(
                string namespace_
            )
            {
                PublicSearchContent op = Build(
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

        private PublicSearchContent(PublicSearchContentBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.Creator is not null) QueryParams["creator"] = builder.Creator;
            if (builder.Ishidden is not null) QueryParams["ishidden"] = builder.Ishidden;
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

        #region Response Part        
        public class Response : ApiResponse<Model.ModelsPaginatedContentDownloadResponse>
        {

            public ResponseError? Error400 { get; set; } = null;

            public ResponseError? Error401 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Ugc::PublicContentLegacy::PublicSearchContent";
        }

        #endregion

        public PublicSearchContent(
            string namespace_,            
            string? creator,            
            string? ishidden,            
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
            if (ishidden is not null) QueryParams["ishidden"] = ishidden;
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

        public override string Path => "/ugc/v1/public/namespaces/{namespace}/contents";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json","application/octet-stream" };

        public override List<string> Produces => new() { "application/json" };
        
        public PublicSearchContent.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new PublicSearchContent.Response()
            {
                StatusCode = code,
                ContentType = contentType
            };

            if (code == (HttpStatusCode)204)
            {
                response.IsSuccess = true;
            }
            else if ((code == (HttpStatusCode)201) || (code == (HttpStatusCode)202) || (code == (HttpStatusCode)200))
            {
                response.Data = JsonSerializer.Deserialize<Model.ModelsPaginatedContentDownloadResponse>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}