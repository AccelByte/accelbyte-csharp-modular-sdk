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
    /// AdminListContentV2
    ///
    /// For advance tag filtering supports & as AND operator and | as OR operator and parentheses ( ) for priority. e.g:
    /// 
    /// 
    /// *tags=red*
    /// *tags=red&animal;*
    /// *tags=red|animal*
    /// *tags=red&animal;|wild*
    /// *tags=red&(animal|wild)*
    /// 
    /// The precedence of logical operator is AND > OR, so if no parentheses, AND logical operator will be executed first.
    /// 
    /// Allowed character for operand: alphanumeric, underscore _ and dash -
    /// 
    /// Allowed character for operator: & | ( )
    /// 
    /// 
    /// **Please note that value of tags query param should be URL encoded**
    /// </summary>
    public class AdminListContentV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminListContentV2Builder Builder { get => new AdminListContentV2Builder(); }

        public class AdminListContentV2Builder
            : OperationBuilder<AdminListContentV2Builder>
        {

            public bool? IsOfficial { get; set; }

            public long? Limit { get; set; }

            public string? Name { get; set; }

            public long? Offset { get; set; }

            public string? SortBy { get; set; }

            public string? SubType { get; set; }

            public List<string>? Tags { get; set; }

            public string? Type { get; set; }





            internal AdminListContentV2Builder() { }

            internal AdminListContentV2Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminListContentV2Builder SetIsOfficial(bool _isOfficial)
            {
                IsOfficial = _isOfficial;
                return this;
            }

            public AdminListContentV2Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminListContentV2Builder SetName(string _name)
            {
                Name = _name;
                return this;
            }

            public AdminListContentV2Builder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public AdminListContentV2Builder SetSortBy(string _sortBy)
            {
                SortBy = _sortBy;
                return this;
            }

            public AdminListContentV2Builder SetSubType(string _subType)
            {
                SubType = _subType;
                return this;
            }

            public AdminListContentV2Builder SetTags(List<string> _tags)
            {
                Tags = _tags;
                return this;
            }

            public AdminListContentV2Builder SetType(string _type)
            {
                Type = _type;
                return this;
            }





            public AdminListContentV2 Build(
                string namespace_
            )
            {
                AdminListContentV2 op = new AdminListContentV2(this,
                    namespace_                    
                );

                op.SetBaseFields<AdminListContentV2Builder>(this);
                return op;
            }

            public AdminListContentV2.Response Execute(
                string namespace_
            )
            {
                AdminListContentV2 op = Build(
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
            public async Task<AdminListContentV2.Response> ExecuteAsync(
                string namespace_
            )
            {
                AdminListContentV2 op = Build(
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

        private AdminListContentV2(AdminListContentV2Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.IsOfficial != null) QueryParams["isOfficial"] = Convert.ToString(builder.IsOfficial)!;
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

        #region Response Part        
        public class Response : ApiResponse<Model.ModelsPaginatedContentDownloadResponseV2>
        {

            public ResponseError? Error400 { get; set; } = null;

            public ResponseError? Error401 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Ugc::AdminContentV2::AdminListContentV2";
        }

        #endregion

        public AdminListContentV2(
            string namespace_,            
            bool? isOfficial,            
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
            
            if (isOfficial != null) QueryParams["isOfficial"] = Convert.ToString(isOfficial)!;
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

        public override string Path => "/ugc/v2/admin/namespaces/{namespace}/contents";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public AdminListContentV2.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminListContentV2.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelsPaginatedContentDownloadResponseV2>(payload, ResponseJsonOptions);
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