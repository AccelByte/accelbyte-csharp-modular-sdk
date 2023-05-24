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
    /// getLeaderboardConfigurationAdminV3
    ///
    /// 
    /// 
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:LEADERBOARD [READ]'
    /// 
    /// 
    /// 
    /// 
    /// This endpoint returns a leaderboard configuration
    /// </summary>
    public class GetLeaderboardConfigurationAdminV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetLeaderboardConfigurationAdminV3Builder Builder { get => new GetLeaderboardConfigurationAdminV3Builder(); }

        public class GetLeaderboardConfigurationAdminV3Builder
            : OperationBuilder<GetLeaderboardConfigurationAdminV3Builder>
        {





            internal GetLeaderboardConfigurationAdminV3Builder() { }

            internal GetLeaderboardConfigurationAdminV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetLeaderboardConfigurationAdminV3 Build(
                string leaderboardCode,
                string namespace_
            )
            {
                GetLeaderboardConfigurationAdminV3 op = new GetLeaderboardConfigurationAdminV3(this,
                    leaderboardCode,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.ModelsGetLeaderboardConfigRespV3? Execute(
                string leaderboardCode,
                string namespace_
            )
            {
                GetLeaderboardConfigurationAdminV3 op = Build(
                    leaderboardCode,
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

        private GetLeaderboardConfigurationAdminV3(GetLeaderboardConfigurationAdminV3Builder builder,
            string leaderboardCode,
            string namespace_
        )
        {
            PathParams["leaderboardCode"] = leaderboardCode;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetLeaderboardConfigurationAdminV3(
            string leaderboardCode,
            string namespace_
        )
        {
            PathParams["leaderboardCode"] = leaderboardCode;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/leaderboard/v3/admin/namespaces/{namespace}/leaderboards/{leaderboardCode}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsGetLeaderboardConfigRespV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetLeaderboardConfigRespV3>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetLeaderboardConfigRespV3>(payload);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}