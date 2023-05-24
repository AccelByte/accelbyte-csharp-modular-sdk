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

using AccelByte.Sdk.Api.Leaderboard.Model;

namespace AccelByte.Sdk.Api.Leaderboard.Operation
{
    /// <summary>
    /// getLeaderboardConfigurationsAdminV1
    ///
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:LEADERBOARD [READ]'
    /// 
    /// 
    /// 
    /// 
    /// This endpoint return all leaderboard configurations
    /// </summary>
    public class GetLeaderboardConfigurationsAdminV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetLeaderboardConfigurationsAdminV1Builder Builder { get => new GetLeaderboardConfigurationsAdminV1Builder(); }

        public class GetLeaderboardConfigurationsAdminV1Builder
            : OperationBuilder<GetLeaderboardConfigurationsAdminV1Builder>
        {

            public bool? IsArchived { get; set; }

            public bool? IsDeleted { get; set; }

            public long? Limit { get; set; }

            public long? Offset { get; set; }





            internal GetLeaderboardConfigurationsAdminV1Builder() { }

            internal GetLeaderboardConfigurationsAdminV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetLeaderboardConfigurationsAdminV1Builder SetIsArchived(bool _isArchived)
            {
                IsArchived = _isArchived;
                return this;
            }

            public GetLeaderboardConfigurationsAdminV1Builder SetIsDeleted(bool _isDeleted)
            {
                IsDeleted = _isDeleted;
                return this;
            }

            public GetLeaderboardConfigurationsAdminV1Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetLeaderboardConfigurationsAdminV1Builder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }





            public GetLeaderboardConfigurationsAdminV1 Build(
                string namespace_
            )
            {
                GetLeaderboardConfigurationsAdminV1 op = new GetLeaderboardConfigurationsAdminV1(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.ModelsGetAllLeaderboardConfigsResp? Execute(
                string namespace_
            )
            {
                GetLeaderboardConfigurationsAdminV1 op = Build(
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

        private GetLeaderboardConfigurationsAdminV1(GetLeaderboardConfigurationsAdminV1Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.IsArchived != null) QueryParams["isArchived"] = Convert.ToString(builder.IsArchived)!;
            if (builder.IsDeleted != null) QueryParams["isDeleted"] = Convert.ToString(builder.IsDeleted)!;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetLeaderboardConfigurationsAdminV1(
            string namespace_,
            bool? isArchived,
            bool? isDeleted,
            long? limit,
            long? offset
        )
        {
            PathParams["namespace"] = namespace_;

            if (isArchived != null) QueryParams["isArchived"] = Convert.ToString(isArchived)!;
            if (isDeleted != null) QueryParams["isDeleted"] = Convert.ToString(isDeleted)!;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/leaderboard/v1/admin/namespaces/{namespace}/leaderboards";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsGetAllLeaderboardConfigsResp? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetAllLeaderboardConfigsResp>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetAllLeaderboardConfigsResp>(payload);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}