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
    /// AdminGetUserLoginHistoriesV3
    ///
    /// Notes for this endpoint:
    /// This endpoint retrieve the first page of the data if `after` and `before` parameters is empty.
    /// - The maximum value of the limit is 100 and the minimum value of the limit is 1.
    /// - This endpoint retrieve the next page of the data if we provide `after` parameters with valid Unix timestamp.
    /// - This endpoint retrieve the previous page of the data if we provide `before` parameter with valid data Unix timestamp."
    /// </summary>
    public class AdminGetUserLoginHistoriesV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetUserLoginHistoriesV3Builder Builder { get => new AdminGetUserLoginHistoriesV3Builder(); }

        public class AdminGetUserLoginHistoriesV3Builder
            : OperationBuilder<AdminGetUserLoginHistoriesV3Builder>
        {

            public double? After { get; set; }

            public double? Before { get; set; }

            public long? Limit { get; set; }





            internal AdminGetUserLoginHistoriesV3Builder() { }

            internal AdminGetUserLoginHistoriesV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminGetUserLoginHistoriesV3Builder SetAfter(double _after)
            {
                After = _after;
                return this;
            }

            public AdminGetUserLoginHistoriesV3Builder SetBefore(double _before)
            {
                Before = _before;
                return this;
            }

            public AdminGetUserLoginHistoriesV3Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }





            public AdminGetUserLoginHistoriesV3 Build(
                string namespace_,
                string userId
            )
            {
                AdminGetUserLoginHistoriesV3 op = new AdminGetUserLoginHistoriesV3(this,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelLoginHistoriesResponse? Execute(
                string namespace_,
                string userId
            )
            {
                AdminGetUserLoginHistoriesV3 op = Build(
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

        private AdminGetUserLoginHistoriesV3(AdminGetUserLoginHistoriesV3Builder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (builder.After != null) QueryParams["after"] = Convert.ToString(builder.After)!;
            if (builder.Before != null) QueryParams["before"] = Convert.ToString(builder.Before)!;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetUserLoginHistoriesV3(
            string namespace_,
            string userId,
            double? after,
            double? before,
            long? limit
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (after != null) QueryParams["after"] = Convert.ToString(after)!;
            if (before != null) QueryParams["before"] = Convert.ToString(before)!;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/users/{userId}/logins/histories";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelLoginHistoriesResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelLoginHistoriesResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelLoginHistoriesResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}