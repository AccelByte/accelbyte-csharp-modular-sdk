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
    /// AdminListUserStagingContents
    ///
    /// List user content's that need admin approval
    /// </summary>
    public class AdminListUserStagingContents : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminListUserStagingContentsBuilder Builder { get => new AdminListUserStagingContentsBuilder(); }

        public class AdminListUserStagingContentsBuilder
            : OperationBuilder<AdminListUserStagingContentsBuilder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public string? SortBy { get; set; }

            public string? Status { get; set; }





            internal AdminListUserStagingContentsBuilder() { }

            internal AdminListUserStagingContentsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminListUserStagingContentsBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminListUserStagingContentsBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public AdminListUserStagingContentsBuilder SetSortBy(string _sortBy)
            {
                SortBy = _sortBy;
                return this;
            }

            public AdminListUserStagingContentsBuilder SetStatus(string _status)
            {
                Status = _status;
                return this;
            }





            public AdminListUserStagingContents Build(
                string namespace_,
                string userId
            )
            {
                AdminListUserStagingContents op = new AdminListUserStagingContents(this,
                    namespace_,
                    userId
                );

                op.SetBaseFields<AdminListUserStagingContentsBuilder>(this);
                return op;
            }

            public Model.ModelsPaginatedListStagingContentResponse? Execute(
                string namespace_,
                string userId
            )
            {
                AdminListUserStagingContents op = Build(
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

        private AdminListUserStagingContents(AdminListUserStagingContentsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.SortBy is not null) QueryParams["sortBy"] = builder.SortBy;
            if (builder.Status is not null) QueryParams["status"] = builder.Status;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminListUserStagingContents(
            string namespace_,
            string userId,
            long? limit,
            long? offset,
            string? sortBy,
            string? status
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (sortBy is not null) QueryParams["sortBy"] = sortBy;
            if (status is not null) QueryParams["status"] = status;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v2/admin/namespaces/{namespace}/users/{userId}/staging-contents";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsPaginatedListStagingContentResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsPaginatedListStagingContentResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsPaginatedListStagingContentResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}