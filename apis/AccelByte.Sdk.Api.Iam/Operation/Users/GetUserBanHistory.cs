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
    /// GetUserBanHistory
    ///
    /// 
    /// 
    /// ## The endpoint is going to be deprecated
    /// 
    /// 
    /// Endpoint migration guide
    /// 
    /// 
    ///     * Substitute endpoint: /iam/v3/admin/namespaces/{namespace}/users/{userId}/bans [GET]
    /// 
    /// 
    /// 
    /// 
    /// Required permissions 'ADMIN:NAMESPACE:{namespace}:BAN:USER:{userId} [READ]'.
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class GetUserBanHistory : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetUserBanHistoryBuilder Builder { get => new GetUserBanHistoryBuilder(); }

        public class GetUserBanHistoryBuilder
            : OperationBuilder<GetUserBanHistoryBuilder>
        {





            internal GetUserBanHistoryBuilder() { }

            internal GetUserBanHistoryBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetUserBanHistory Build(
                string namespace_,
                string userId
            )
            {
                GetUserBanHistory op = new GetUserBanHistory(this,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public List<Model.ModelUserBanResponse>? Execute(
                string namespace_,
                string userId
            )
            {
                GetUserBanHistory op = Build(
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

        private GetUserBanHistory(GetUserBanHistoryBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetUserBanHistory(
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/namespaces/{namespace}/users/{userId}/bans";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public List<Model.ModelUserBanResponse>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ModelUserBanResponse>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ModelUserBanResponse>>(payload);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}