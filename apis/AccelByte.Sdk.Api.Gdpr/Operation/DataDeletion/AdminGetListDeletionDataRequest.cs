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

using AccelByte.Sdk.Api.Gdpr.Model;

namespace AccelByte.Sdk.Api.Gdpr.Operation
{
    /// <summary>
    /// AdminGetListDeletionDataRequest
    ///
    /// Retrieve all user's account deletion requests in specified date
    /// Scope: account
    /// </summary>
    public class AdminGetListDeletionDataRequest : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetListDeletionDataRequestBuilder Builder { get => new AdminGetListDeletionDataRequestBuilder(); }

        public class AdminGetListDeletionDataRequestBuilder
            : OperationBuilder<AdminGetListDeletionDataRequestBuilder>
        {

            public string? After { get; set; }

            public string? Before { get; set; }

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public string? RequestDate { get; set; }





            internal AdminGetListDeletionDataRequestBuilder() { }

            internal AdminGetListDeletionDataRequestBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminGetListDeletionDataRequestBuilder SetAfter(string _after)
            {
                After = _after;
                return this;
            }

            public AdminGetListDeletionDataRequestBuilder SetBefore(string _before)
            {
                Before = _before;
                return this;
            }

            public AdminGetListDeletionDataRequestBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminGetListDeletionDataRequestBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public AdminGetListDeletionDataRequestBuilder SetRequestDate(string _requestDate)
            {
                RequestDate = _requestDate;
                return this;
            }





            public AdminGetListDeletionDataRequest Build(
                string namespace_
            )
            {
                AdminGetListDeletionDataRequest op = new AdminGetListDeletionDataRequest(this,
                    namespace_
                );

                op.SetBaseFields<AdminGetListDeletionDataRequestBuilder>(this);
                return op;
            }

            public Model.ModelsListDeletionDataResponse? Execute(
                string namespace_
            )
            {
                AdminGetListDeletionDataRequest op = Build(
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
            public async Task<Model.ModelsListDeletionDataResponse?> ExecuteAsync(
                string namespace_
            )
            {
                AdminGetListDeletionDataRequest op = Build(
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

        private AdminGetListDeletionDataRequest(AdminGetListDeletionDataRequestBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.After is not null) QueryParams["after"] = builder.After;
            if (builder.Before is not null) QueryParams["before"] = builder.Before;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.RequestDate is not null) QueryParams["requestDate"] = builder.RequestDate;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetListDeletionDataRequest(
            string namespace_,
            string? after,
            string? before,
            long? limit,
            long? offset,
            string? requestDate
        )
        {
            PathParams["namespace"] = namespace_;

            if (after is not null) QueryParams["after"] = after;
            if (before is not null) QueryParams["before"] = before;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (requestDate is not null) QueryParams["requestDate"] = requestDate;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/gdpr/admin/namespaces/{namespace}/deletions";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsListDeletionDataResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsListDeletionDataResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsListDeletionDataResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}