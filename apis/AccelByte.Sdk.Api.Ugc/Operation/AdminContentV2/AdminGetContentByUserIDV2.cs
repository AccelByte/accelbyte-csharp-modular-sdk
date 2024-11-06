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
    /// AdminGetContentByUserIDV2
    ///
    /// Get user cotent
    /// </summary>
    public class AdminGetContentByUserIDV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetContentByUserIDV2Builder Builder { get => new AdminGetContentByUserIDV2Builder(); }

        public class AdminGetContentByUserIDV2Builder
            : OperationBuilder<AdminGetContentByUserIDV2Builder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public string? SortBy { get; set; }





            internal AdminGetContentByUserIDV2Builder() { }

            internal AdminGetContentByUserIDV2Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminGetContentByUserIDV2Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminGetContentByUserIDV2Builder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public AdminGetContentByUserIDV2Builder SetSortBy(string _sortBy)
            {
                SortBy = _sortBy;
                return this;
            }





            public AdminGetContentByUserIDV2 Build(
                string namespace_,
                string userId
            )
            {
                AdminGetContentByUserIDV2 op = new AdminGetContentByUserIDV2(this,
                    namespace_,                    
                    userId                    
                );

                op.SetBaseFields<AdminGetContentByUserIDV2Builder>(this);
                return op;
            }

            public AdminGetContentByUserIDV2.Response Execute(
                string namespace_,
                string userId
            )
            {
                AdminGetContentByUserIDV2 op = Build(
                    namespace_,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<AdminGetContentByUserIDV2.Response> ExecuteAsync(
                string namespace_,
                string userId
            )
            {
                AdminGetContentByUserIDV2 op = Build(
                    namespace_,
                    userId
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

        private AdminGetContentByUserIDV2(AdminGetContentByUserIDV2Builder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.SortBy is not null) QueryParams["sortBy"] = builder.SortBy;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelsPaginatedContentDownloadResponseV2>
        {

            public ResponseError? Error400 { get; set; } = null;

            public ResponseError? Error401 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Ugc::AdminContentV2::AdminGetContentByUserIDV2";
        }

        #endregion

        public AdminGetContentByUserIDV2(
            string namespace_,            
            string userId,            
            long? limit,            
            long? offset,            
            string? sortBy            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (sortBy is not null) QueryParams["sortBy"] = sortBy;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v2/admin/namespaces/{namespace}/users/{userId}/contents";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public AdminGetContentByUserIDV2.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminGetContentByUserIDV2.Response()
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