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

using AccelByte.Sdk.Api.Chat.Model;

namespace AccelByte.Sdk.Api.Chat.Operation
{
    /// <summary>
    /// adminProfanityQuery
    ///
    /// Query all profanity words.
    /// </summary>
    public class AdminProfanityQuery : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminProfanityQueryBuilder Builder { get => new AdminProfanityQueryBuilder(); }

        public class AdminProfanityQueryBuilder
            : OperationBuilder<AdminProfanityQueryBuilder>
        {

            public string? FilterMask { get; set; }

            public bool? IncludeChildren { get; set; }

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public string? ParentId { get; set; }

            public string? StartWith { get; set; }

            public string? WordType { get; set; }





            internal AdminProfanityQueryBuilder() { }

            internal AdminProfanityQueryBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminProfanityQueryBuilder SetFilterMask(string _filterMask)
            {
                FilterMask = _filterMask;
                return this;
            }

            public AdminProfanityQueryBuilder SetIncludeChildren(bool _includeChildren)
            {
                IncludeChildren = _includeChildren;
                return this;
            }

            public AdminProfanityQueryBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminProfanityQueryBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public AdminProfanityQueryBuilder SetParentId(string _parentId)
            {
                ParentId = _parentId;
                return this;
            }

            public AdminProfanityQueryBuilder SetStartWith(string _startWith)
            {
                StartWith = _startWith;
                return this;
            }

            public AdminProfanityQueryBuilder SetWordType(string _wordType)
            {
                WordType = _wordType;
                return this;
            }





            public AdminProfanityQuery Build(
                string namespace_
            )
            {
                AdminProfanityQuery op = new AdminProfanityQuery(this,
                    namespace_                    
                );

                op.SetBaseFields<AdminProfanityQueryBuilder>(this);
                return op;
            }

            public AdminProfanityQuery.Response Execute(
                string namespace_
            )
            {
                AdminProfanityQuery op = Build(
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
            public async Task<AdminProfanityQuery.Response> ExecuteAsync(
                string namespace_
            )
            {
                AdminProfanityQuery op = Build(
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

        private AdminProfanityQuery(AdminProfanityQueryBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.FilterMask is not null) QueryParams["filterMask"] = builder.FilterMask;
            if (builder.IncludeChildren != null) QueryParams["includeChildren"] = Convert.ToString(builder.IncludeChildren)!;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.ParentId is not null) QueryParams["parentId"] = builder.ParentId;
            if (builder.StartWith is not null) QueryParams["startWith"] = builder.StartWith;
            if (builder.WordType is not null) QueryParams["wordType"] = builder.WordType;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelsDictionaryQueryResult>
        {

            public RestapiErrorResponseBody? Error400 { get; set; } = null;

            public RestapiErrorResponseBody? Error401 { get; set; } = null;

            public RestapiErrorResponseBody? Error403 { get; set; } = null;

            public RestapiErrorResponseBody? Error404 { get; set; } = null;

            public RestapiErrorResponseBody? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Chat::Profanity::AdminProfanityQuery";
        }

        #endregion

        public AdminProfanityQuery(
            string namespace_,            
            string? filterMask,            
            bool? includeChildren,            
            long? limit,            
            long? offset,            
            string? parentId,            
            string? startWith,            
            string? wordType            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (filterMask is not null) QueryParams["filterMask"] = filterMask;
            if (includeChildren != null) QueryParams["includeChildren"] = Convert.ToString(includeChildren)!;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (parentId is not null) QueryParams["parentId"] = parentId;
            if (startWith is not null) QueryParams["startWith"] = startWith;
            if (wordType is not null) QueryParams["wordType"] = wordType;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/chat/v1/admin/profanity/namespaces/{namespace}/dictionary";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public AdminProfanityQuery.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminProfanityQuery.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelsDictionaryQueryResult>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<RestapiErrorResponseBody>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<RestapiErrorResponseBody>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<RestapiErrorResponseBody>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<RestapiErrorResponseBody>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<RestapiErrorResponseBody>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}