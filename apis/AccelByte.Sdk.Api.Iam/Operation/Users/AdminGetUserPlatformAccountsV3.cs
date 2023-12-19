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
    /// AdminGetUserPlatformAccountsV3
    ///
    /// ## Justice Platform Account
    /// The permission âADMIN:NAMESPACE:{namespace}:JUSTICE:USER:{userId}â [READ]
    /// is required in order to read the UserID who linked with the user.
    /// Gets platform accounts that are already linked with user account
    /// action code : 10128
    /// </summary>
    public class AdminGetUserPlatformAccountsV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetUserPlatformAccountsV3Builder Builder { get => new AdminGetUserPlatformAccountsV3Builder(); }

        public class AdminGetUserPlatformAccountsV3Builder
            : OperationBuilder<AdminGetUserPlatformAccountsV3Builder>
        {

            public string? After { get; set; }

            public string? Before { get; set; }

            public long? Limit { get; set; }

            public string? PlatformId { get; set; }





            internal AdminGetUserPlatformAccountsV3Builder() { }

            internal AdminGetUserPlatformAccountsV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminGetUserPlatformAccountsV3Builder SetAfter(string _after)
            {
                After = _after;
                return this;
            }

            public AdminGetUserPlatformAccountsV3Builder SetBefore(string _before)
            {
                Before = _before;
                return this;
            }

            public AdminGetUserPlatformAccountsV3Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminGetUserPlatformAccountsV3Builder SetPlatformId(string _platformId)
            {
                PlatformId = _platformId;
                return this;
            }





            public AdminGetUserPlatformAccountsV3 Build(
                string namespace_,
                string userId
            )
            {
                AdminGetUserPlatformAccountsV3 op = new AdminGetUserPlatformAccountsV3(this,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.AccountcommonUserLinkedPlatformsResponseV3? Execute(
                string namespace_,
                string userId
            )
            {
                AdminGetUserPlatformAccountsV3 op = Build(
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

        private AdminGetUserPlatformAccountsV3(AdminGetUserPlatformAccountsV3Builder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (builder.After is not null) QueryParams["after"] = builder.After;
            if (builder.Before is not null) QueryParams["before"] = builder.Before;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.PlatformId is not null) QueryParams["platformId"] = builder.PlatformId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetUserPlatformAccountsV3(
            string namespace_,
            string userId,
            string? after,
            string? before,
            long? limit,
            string? platformId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (after is not null) QueryParams["after"] = after;
            if (before is not null) QueryParams["before"] = before;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (platformId is not null) QueryParams["platformId"] = platformId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/users/{userId}/platforms";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.AccountcommonUserLinkedPlatformsResponseV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.AccountcommonUserLinkedPlatformsResponseV3>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.AccountcommonUserLinkedPlatformsResponseV3>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}