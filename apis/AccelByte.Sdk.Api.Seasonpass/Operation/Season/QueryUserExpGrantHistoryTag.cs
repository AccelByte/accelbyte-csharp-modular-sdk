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
    ///   *  Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:SEASONPASS", action=2 (READ)
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
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ReasonTagsResult? Execute(
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

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.ReasonTagsResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ReasonTagsResult>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ReasonTagsResult>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}