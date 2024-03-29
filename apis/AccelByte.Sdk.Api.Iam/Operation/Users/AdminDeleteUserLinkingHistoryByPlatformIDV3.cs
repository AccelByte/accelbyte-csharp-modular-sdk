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
    /// AdminDeleteUserLinkingHistoryByPlatformIDV3
    ///
    /// This API is for admin to delete user's linking history with target platform id
    /// </summary>
    public class AdminDeleteUserLinkingHistoryByPlatformIDV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDeleteUserLinkingHistoryByPlatformIDV3Builder Builder { get => new AdminDeleteUserLinkingHistoryByPlatformIDV3Builder(); }

        public class AdminDeleteUserLinkingHistoryByPlatformIDV3Builder
            : OperationBuilder<AdminDeleteUserLinkingHistoryByPlatformIDV3Builder>
        {





            internal AdminDeleteUserLinkingHistoryByPlatformIDV3Builder() { }

            internal AdminDeleteUserLinkingHistoryByPlatformIDV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminDeleteUserLinkingHistoryByPlatformIDV3 Build(
                string namespace_,
                string platformId,
                string userId
            )
            {
                AdminDeleteUserLinkingHistoryByPlatformIDV3 op = new AdminDeleteUserLinkingHistoryByPlatformIDV3(this,
                    namespace_,
                    platformId,
                    userId
                );

                op.SetBaseFields<AdminDeleteUserLinkingHistoryByPlatformIDV3Builder>(this);
                return op;
            }

            public void Execute(
                string namespace_,
                string platformId,
                string userId
            )
            {
                AdminDeleteUserLinkingHistoryByPlatformIDV3 op = Build(
                    namespace_,
                    platformId,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private AdminDeleteUserLinkingHistoryByPlatformIDV3(AdminDeleteUserLinkingHistoryByPlatformIDV3Builder builder,
            string namespace_,
            string platformId,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminDeleteUserLinkingHistoryByPlatformIDV3(
            string namespace_,
            string platformId,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/users/{userId}/platforms/{platformId}/link/histories";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}