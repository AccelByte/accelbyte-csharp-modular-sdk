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

using AccelByte.Sdk.Api.Seasonpass.Model;

namespace AccelByte.Sdk.Api.Seasonpass.Operation
{
    /// <summary>
    /// queryUserExpGrantHistoryTag
    ///
    /// This API is used to get user exp acquisition history's tag list.
    /// 
    /// Other detail info:
    /// 
    ///   * default will query from current active season
    ///   *  Returns : exp grant history tags list
    /// </summary>
    public class QueryUserExpGrantHistoryTag : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QueryUserExpGrantHistoryTagBuilder Builder { get => new QueryUserExpGrantHistoryTagBuilder(); }

        public class QueryUserExpGrantHistoryTagBuilder
            : OperationBuilder<QueryUserExpGrantHistoryTagBuilder>
        {

            public string? SeasonId { get; set; }





            internal QueryUserExpGrantHistoryTagBuilder() { }

            internal QueryUserExpGrantHistoryTagBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public QueryUserExpGrantHistoryTagBuilder SetSeasonId(string _seasonId)
            {
                SeasonId = _seasonId;
                return this;
            }





            public QueryUserExpGrantHistoryTag Build(
                string namespace_,
                string userId
            )
            {
                QueryUserExpGrantHistoryTag op = new QueryUserExpGrantHistoryTag(this,
                    namespace_,                    
                    userId                    
                );

                op.SetBaseFields<QueryUserExpGrantHistoryTagBuilder>(this);
                return op;
            }

            public QueryUserExpGrantHistoryTag.Response Execute(
                string namespace_,
                string userId
            )
            {
                QueryUserExpGrantHistoryTag op = Build(
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
            public async Task<QueryUserExpGrantHistoryTag.Response> ExecuteAsync(
                string namespace_,
                string userId
            )
            {
                QueryUserExpGrantHistoryTag op = Build(
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

        private QueryUserExpGrantHistoryTag(QueryUserExpGrantHistoryTagBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (builder.SeasonId is not null) QueryParams["seasonId"] = builder.SeasonId;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ReasonTagsResult>
        {

            public ErrorEntity? Error400 { get; set; } = null;


            protected override string GetFullOperationId() => "Seasonpass::Season::QueryUserExpGrantHistoryTag";
        }

        #endregion

        public QueryUserExpGrantHistoryTag(
            string namespace_,            
            string userId,            
            string? seasonId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (seasonId is not null) QueryParams["seasonId"] = seasonId;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/seasonpass/admin/namespaces/{namespace}/users/{userId}/seasons/exp/history/tags";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public QueryUserExpGrantHistoryTag.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new QueryUserExpGrantHistoryTag.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ReasonTagsResult>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }

            return response;
        }
    }

}