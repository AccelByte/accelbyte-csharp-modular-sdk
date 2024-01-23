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
    /// GetPublicFollowers
    /// </summary>
    public class GetPublicFollowers : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetPublicFollowersBuilder Builder { get => new GetPublicFollowersBuilder(); }

        public class GetPublicFollowersBuilder
            : OperationBuilder<GetPublicFollowersBuilder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }





            internal GetPublicFollowersBuilder() { }

            internal GetPublicFollowersBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetPublicFollowersBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetPublicFollowersBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }





            public GetPublicFollowers Build(
                string namespace_,
                string userId
            )
            {
                GetPublicFollowers op = new GetPublicFollowers(this,
                    namespace_,
                    userId
                );

                op.SetBaseFields<GetPublicFollowersBuilder>(this);
                return op;
            }

            public Model.ModelsPaginatedCreatorOverviewResponse? Execute(
                string namespace_,
                string userId
            )
            {
                GetPublicFollowers op = Build(
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

        private GetPublicFollowers(GetPublicFollowersBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetPublicFollowers(
            string namespace_,
            string userId,
            long? limit,
            long? offset
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v1/public/namespaces/{namespace}/users/{userId}/followers";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json", "application/octet-stream" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsPaginatedCreatorOverviewResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsPaginatedCreatorOverviewResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsPaginatedCreatorOverviewResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}