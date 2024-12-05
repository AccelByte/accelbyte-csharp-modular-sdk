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

using AccelByte.Sdk.Api.Achievement.Model;

namespace AccelByte.Sdk.Api.Achievement.Operation
{
    /// <summary>
    /// PublicListTags
    ///
    /// 
    /// 
    /// Required permission
    /// `NAMESPACE:{namespace}:ACHIEVEMENT [READ]` and scope `social`
    /// </summary>
    public class PublicListTags : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicListTagsBuilder Builder { get => new PublicListTagsBuilder(); }

        public class PublicListTagsBuilder
            : OperationBuilder<PublicListTagsBuilder>
        {

            public long? Limit { get; set; }

            public string? Name { get; set; }

            public long? Offset { get; set; }

            public PublicListTagsSortBy? SortBy { get; set; }





            internal PublicListTagsBuilder() { }

            internal PublicListTagsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public PublicListTagsBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public PublicListTagsBuilder SetName(string _name)
            {
                Name = _name;
                return this;
            }

            public PublicListTagsBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public PublicListTagsBuilder SetSortBy(PublicListTagsSortBy _sortBy)
            {
                SortBy = _sortBy;
                return this;
            }





            public PublicListTags Build(
                string namespace_
            )
            {
                PublicListTags op = new PublicListTags(this,
                    namespace_
                );

                op.SetBaseFields<PublicListTagsBuilder>(this);
                return op;
            }

            public PublicListTags.Response Execute(
                string namespace_
            )
            {
                PublicListTags op = Build(
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
            public async Task<PublicListTags.Response> ExecuteAsync(
                string namespace_
            )
            {
                PublicListTags op = Build(
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

        private PublicListTags(PublicListTagsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Name is not null) QueryParams["name"] = builder.Name;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.SortBy is not null) QueryParams["sortBy"] = builder.SortBy.Value;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelsPaginatedTagResponse>
        {

            public ResponseError? Error400 { get; set; } = null;

            public ResponseError? Error401 { get; set; } = null;

            public ResponseError? Error404 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Achievement::Tags::PublicListTags";
        }

        #endregion

        public PublicListTags(
            string namespace_,
            long? limit,
            string? name,
            long? offset,
            PublicListTagsSortBy? sortBy
        )
        {
            PathParams["namespace"] = namespace_;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (name is not null) QueryParams["name"] = name;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (sortBy is not null) QueryParams["sortBy"] = sortBy.Value;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/achievement/v1/public/namespaces/{namespace}/tags";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public PublicListTags.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new PublicListTags.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelsPaginatedTagResponse>(payload, ResponseJsonOptions);
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
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

    public class PublicListTagsSortBy : StringEnum<PublicListTagsSortBy>
    {
        public static readonly PublicListTagsSortBy CreatedAt
            = new PublicListTagsSortBy("createdAt");

        public static readonly PublicListTagsSortBy CreatedAtasc
            = new PublicListTagsSortBy("createdAt:asc");

        public static readonly PublicListTagsSortBy CreatedAtdesc
            = new PublicListTagsSortBy("createdAt:desc");

        public static readonly PublicListTagsSortBy Name
            = new PublicListTagsSortBy("name");

        public static readonly PublicListTagsSortBy Nameasc
            = new PublicListTagsSortBy("name:asc");

        public static readonly PublicListTagsSortBy Namedesc
            = new PublicListTagsSortBy("name:desc");


        public static implicit operator PublicListTagsSortBy(string value)
        {
            return NewValue(value);
        }

        public PublicListTagsSortBy(string enumValue)
            : base(enumValue)
        {

        }
    }

}