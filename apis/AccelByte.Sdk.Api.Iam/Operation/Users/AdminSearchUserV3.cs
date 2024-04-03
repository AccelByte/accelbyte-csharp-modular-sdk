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

using AccelByte.Sdk.Api.Iam.Model;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// AdminSearchUserV3
    ///
    /// Endpoint behavior :
    /// - by default this endpoint searches all users on the specified namespace
    /// - if query parameter is defined, endpoint will search users whose email address, display name, username, or third party partially match with the query
    /// - if startDate and endDate parameters is defined, endpoint will search users which created on the certain date range
    /// - if query, startDate and endDate parameters are defined, endpoint will search users whose email address and display name match and created on the certain date range
    /// - if startDate parameter is defined, endpoint will search users that created start from the defined date
    /// - if endDate parameter is defined, endpoint will search users that created until the defined date
    /// - if platformId parameter is defined and by parameter is using thirdparty, endpoint will search users based on the platformId they have linked to
    /// - if platformBy parameter is defined and by parameter is using thirdparty, endpoint will search users based on the platformUserId or platformDisplayName they have linked to, example value: platformUserId or platformDisplayName
    /// - if limit is not defined, The default limit is 100
    /// 
    /// In multi tenant mode :
    /// 
    /// - if super admin search in super admin namespace, the result will be all game admin user
    /// - if super admin search in game studio namespace, the result will be all game admin user and players under the game studio namespace
    /// - if super admin search in game namespace, the result will be all game admin users and players under the game namespace
    /// - if game admin search in their game studio namespace, the result will be all game admin user in the studio namespace
    /// - if game admin search in their game namespace, the result will be all player in the game namespace
    /// 
    /// action code : 10133
    /// </summary>
    public class AdminSearchUserV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminSearchUserV3Builder Builder { get => new AdminSearchUserV3Builder(); }

        public class AdminSearchUserV3Builder
            : OperationBuilder<AdminSearchUserV3Builder>
        {

            public string? By { get; set; }

            public string? EndDate { get; set; }

            public bool? IncludeTotal { get; set; }

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public string? PlatformBy { get; set; }

            public string? PlatformId { get; set; }

            public string? Query { get; set; }

            public string? RoleIds { get; set; }

            public bool? SkipLoginQueue { get; set; }

            public string? StartDate { get; set; }

            public bool? TestAccount { get; set; }





            internal AdminSearchUserV3Builder() { }

            internal AdminSearchUserV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminSearchUserV3Builder SetBy(string _by)
            {
                By = _by;
                return this;
            }

            public AdminSearchUserV3Builder SetEndDate(string _endDate)
            {
                EndDate = _endDate;
                return this;
            }

            public AdminSearchUserV3Builder SetIncludeTotal(bool _includeTotal)
            {
                IncludeTotal = _includeTotal;
                return this;
            }

            public AdminSearchUserV3Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminSearchUserV3Builder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public AdminSearchUserV3Builder SetPlatformBy(string _platformBy)
            {
                PlatformBy = _platformBy;
                return this;
            }

            public AdminSearchUserV3Builder SetPlatformId(string _platformId)
            {
                PlatformId = _platformId;
                return this;
            }

            public AdminSearchUserV3Builder SetQuery(string _query)
            {
                Query = _query;
                return this;
            }

            public AdminSearchUserV3Builder SetRoleIds(string _roleIds)
            {
                RoleIds = _roleIds;
                return this;
            }

            public AdminSearchUserV3Builder SetSkipLoginQueue(bool _skipLoginQueue)
            {
                SkipLoginQueue = _skipLoginQueue;
                return this;
            }

            public AdminSearchUserV3Builder SetStartDate(string _startDate)
            {
                StartDate = _startDate;
                return this;
            }

            public AdminSearchUserV3Builder SetTestAccount(bool _testAccount)
            {
                TestAccount = _testAccount;
                return this;
            }





            public AdminSearchUserV3 Build(
                string namespace_
            )
            {
                AdminSearchUserV3 op = new AdminSearchUserV3(this,
                    namespace_
                );

                op.SetBaseFields<AdminSearchUserV3Builder>(this);
                return op;
            }

            public Model.ModelSearchUsersResponseWithPaginationV3? Execute(
                string namespace_
            )
            {
                AdminSearchUserV3 op = Build(
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
            public async Task<Model.ModelSearchUsersResponseWithPaginationV3?> ExecuteAsync(
                string namespace_
            )
            {
                AdminSearchUserV3 op = Build(
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

        private AdminSearchUserV3(AdminSearchUserV3Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.By is not null) QueryParams["by"] = builder.By;
            if (builder.EndDate is not null) QueryParams["endDate"] = builder.EndDate;
            if (builder.IncludeTotal != null) QueryParams["includeTotal"] = Convert.ToString(builder.IncludeTotal)!;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.PlatformBy is not null) QueryParams["platformBy"] = builder.PlatformBy;
            if (builder.PlatformId is not null) QueryParams["platformId"] = builder.PlatformId;
            if (builder.Query is not null) QueryParams["query"] = builder.Query;
            if (builder.RoleIds is not null) QueryParams["roleIds"] = builder.RoleIds;
            if (builder.SkipLoginQueue != null) QueryParams["skipLoginQueue"] = Convert.ToString(builder.SkipLoginQueue)!;
            if (builder.StartDate is not null) QueryParams["startDate"] = builder.StartDate;
            if (builder.TestAccount != null) QueryParams["testAccount"] = Convert.ToString(builder.TestAccount)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminSearchUserV3(
            string namespace_,
            string? by,
            string? endDate,
            bool? includeTotal,
            long? limit,
            long? offset,
            string? platformBy,
            string? platformId,
            string? query,
            string? roleIds,
            bool? skipLoginQueue,
            string? startDate,
            bool? testAccount
        )
        {
            PathParams["namespace"] = namespace_;

            if (by is not null) QueryParams["by"] = by;
            if (endDate is not null) QueryParams["endDate"] = endDate;
            if (includeTotal != null) QueryParams["includeTotal"] = Convert.ToString(includeTotal)!;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (platformBy is not null) QueryParams["platformBy"] = platformBy;
            if (platformId is not null) QueryParams["platformId"] = platformId;
            if (query is not null) QueryParams["query"] = query;
            if (roleIds is not null) QueryParams["roleIds"] = roleIds;
            if (skipLoginQueue != null) QueryParams["skipLoginQueue"] = Convert.ToString(skipLoginQueue)!;
            if (startDate is not null) QueryParams["startDate"] = startDate;
            if (testAccount != null) QueryParams["testAccount"] = Convert.ToString(testAccount)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/users/search";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelSearchUsersResponseWithPaginationV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelSearchUsersResponseWithPaginationV3>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelSearchUsersResponseWithPaginationV3>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}