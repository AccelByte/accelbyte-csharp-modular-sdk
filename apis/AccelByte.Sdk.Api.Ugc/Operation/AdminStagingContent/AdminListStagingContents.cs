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
    /// AdminListStagingContents
    ///
    /// Required permission ADMIN:NAMESPACE:{namespace}:USER:{userId}:CONTENT [READ].
    /// </summary>
    public class AdminListStagingContents : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminListStagingContentsBuilder Builder { get => new AdminListStagingContentsBuilder(); }

        public class AdminListStagingContentsBuilder
            : OperationBuilder<AdminListStagingContentsBuilder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public string? SortBy { get; set; }

            public string? Status { get; set; }





            internal AdminListStagingContentsBuilder() { }

            internal AdminListStagingContentsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminListStagingContentsBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminListStagingContentsBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public AdminListStagingContentsBuilder SetSortBy(string _sortBy)
            {
                SortBy = _sortBy;
                return this;
            }

            public AdminListStagingContentsBuilder SetStatus(string _status)
            {
                Status = _status;
                return this;
            }





            public AdminListStagingContents Build(
                string namespace_
            )
            {
                AdminListStagingContents op = new AdminListStagingContents(this,
                    namespace_
                );

                op.SetBaseFields<AdminListStagingContentsBuilder>(this);
                return op;
            }

            public Model.ModelsPaginatedListStagingContentResponse? Execute(
                string namespace_
            )
            {
                AdminListStagingContents op = Build(
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

        private AdminListStagingContents(AdminListStagingContentsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.SortBy is not null) QueryParams["sortBy"] = builder.SortBy;
            if (builder.Status is not null) QueryParams["status"] = builder.Status;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminListStagingContents(
            string namespace_,
            long? limit,
            long? offset,
            string? sortBy,
            string? status
        )
        {
            PathParams["namespace"] = namespace_;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (sortBy is not null) QueryParams["sortBy"] = sortBy;
            if (status is not null) QueryParams["status"] = status;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v2/admin/namespaces/{namespace}/staging-contents";

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