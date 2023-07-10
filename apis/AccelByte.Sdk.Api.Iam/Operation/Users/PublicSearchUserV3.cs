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

using AccelByte.Sdk.Api.Iam.Model;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// PublicSearchUserV3
    ///
    /// 
    /// 
    /// Requires valid user access token
    /// 
    /// 
    /// 
    /// 
    /// This endpoint search all users on the specified namespace that match the query on these fields: display name, and username.
    /// The query length should greater than 1ï¼otherwise will not query the database. The default limit value is 100
    /// 
    /// 
    /// 
    /// action code : 10132
    /// </summary>
    public class PublicSearchUserV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicSearchUserV3Builder Builder { get => new PublicSearchUserV3Builder(); }

        public class PublicSearchUserV3Builder
            : OperationBuilder<PublicSearchUserV3Builder>
        {

            public string? By { get; set; }

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public string? Query { get; set; }





            internal PublicSearchUserV3Builder() { }

            internal PublicSearchUserV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public PublicSearchUserV3Builder SetBy(string _by)
            {
                By = _by;
                return this;
            }

            public PublicSearchUserV3Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public PublicSearchUserV3Builder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public PublicSearchUserV3Builder SetQuery(string _query)
            {
                Query = _query;
                return this;
            }





            public PublicSearchUserV3 Build(
                string namespace_
            )
            {
                PublicSearchUserV3 op = new PublicSearchUserV3(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelPublicUserInformationResponseV3? Execute(
                string namespace_
            )
            {
                PublicSearchUserV3 op = Build(
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

        private PublicSearchUserV3(PublicSearchUserV3Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.By is not null) QueryParams["by"] = builder.By;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Query is not null) QueryParams["query"] = builder.Query;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicSearchUserV3(
            string namespace_,
            string? by,
            long? limit,
            long? offset,
            string? query
        )
        {
            PathParams["namespace"] = namespace_;

            if (by is not null) QueryParams["by"] = by;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (query is not null) QueryParams["query"] = query;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/users";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelPublicUserInformationResponseV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelPublicUserInformationResponseV3>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelPublicUserInformationResponseV3>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}