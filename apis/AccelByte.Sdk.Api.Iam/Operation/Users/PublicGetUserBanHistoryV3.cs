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
    /// PublicGetUserBanHistoryV3
    ///
    /// Notes:
    /// - This endpoint retrieve the first page of the data if after and before parameters is empty
    /// - **The pagination is not working yet**
    /// </summary>
    public class PublicGetUserBanHistoryV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetUserBanHistoryV3Builder Builder { get => new PublicGetUserBanHistoryV3Builder(); }

        public class PublicGetUserBanHistoryV3Builder
            : OperationBuilder<PublicGetUserBanHistoryV3Builder>
        {

            public bool? ActiveOnly { get; set; }

            public string? After { get; set; }

            public string? Before { get; set; }

            public long? Limit { get; set; }





            internal PublicGetUserBanHistoryV3Builder() { }

            internal PublicGetUserBanHistoryV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public PublicGetUserBanHistoryV3Builder SetActiveOnly(bool _activeOnly)
            {
                ActiveOnly = _activeOnly;
                return this;
            }

            public PublicGetUserBanHistoryV3Builder SetAfter(string _after)
            {
                After = _after;
                return this;
            }

            public PublicGetUserBanHistoryV3Builder SetBefore(string _before)
            {
                Before = _before;
                return this;
            }

            public PublicGetUserBanHistoryV3Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }





            public PublicGetUserBanHistoryV3 Build(
                string namespace_,
                string userId
            )
            {
                PublicGetUserBanHistoryV3 op = new PublicGetUserBanHistoryV3(this,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelGetUserBanV3Response? Execute(
                string namespace_,
                string userId
            )
            {
                PublicGetUserBanHistoryV3 op = Build(
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

        private PublicGetUserBanHistoryV3(PublicGetUserBanHistoryV3Builder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (builder.ActiveOnly != null) QueryParams["activeOnly"] = Convert.ToString(builder.ActiveOnly)!;
            if (builder.After is not null) QueryParams["after"] = builder.After;
            if (builder.Before is not null) QueryParams["before"] = builder.Before;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGetUserBanHistoryV3(
            string namespace_,
            string userId,
            bool? activeOnly,
            string? after,
            string? before,
            long? limit
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (activeOnly != null) QueryParams["activeOnly"] = Convert.ToString(activeOnly)!;
            if (after is not null) QueryParams["after"] = after;
            if (before is not null) QueryParams["before"] = before;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/users/{userId}/bans";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelGetUserBanV3Response? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelGetUserBanV3Response>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelGetUserBanV3Response>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}