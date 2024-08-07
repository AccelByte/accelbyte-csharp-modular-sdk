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

using AccelByte.Sdk.Api.Leaderboard.Model;

namespace AccelByte.Sdk.Api.Leaderboard.Operation
{
    /// <summary>
    /// deleteLeaderboardConfigurationAdminV3
    ///
    /// 
    /// 
    /// This endpoint delete a leaderboard configuration
    /// </summary>
    public class DeleteLeaderboardConfigurationAdminV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteLeaderboardConfigurationAdminV3Builder Builder { get => new DeleteLeaderboardConfigurationAdminV3Builder(); }

        public class DeleteLeaderboardConfigurationAdminV3Builder
            : OperationBuilder<DeleteLeaderboardConfigurationAdminV3Builder>
        {





            internal DeleteLeaderboardConfigurationAdminV3Builder() { }

            internal DeleteLeaderboardConfigurationAdminV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteLeaderboardConfigurationAdminV3 Build(
                string leaderboardCode,
                string namespace_
            )
            {
                DeleteLeaderboardConfigurationAdminV3 op = new DeleteLeaderboardConfigurationAdminV3(this,
                    leaderboardCode,
                    namespace_
                );

                op.SetBaseFields<DeleteLeaderboardConfigurationAdminV3Builder>(this);
                return op;
            }

            public void Execute(
                string leaderboardCode,
                string namespace_
            )
            {
                DeleteLeaderboardConfigurationAdminV3 op = Build(
                    leaderboardCode,
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task ExecuteAsync(
                string leaderboardCode,
                string namespace_
            )
            {
                DeleteLeaderboardConfigurationAdminV3 op = Build(
                    leaderboardCode,
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private DeleteLeaderboardConfigurationAdminV3(DeleteLeaderboardConfigurationAdminV3Builder builder,
            string leaderboardCode,
            string namespace_
        )
        {
            PathParams["leaderboardCode"] = leaderboardCode;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteLeaderboardConfigurationAdminV3(
            string leaderboardCode,
            string namespace_
        )
        {
            PathParams["leaderboardCode"] = leaderboardCode;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/leaderboard/v3/admin/namespaces/{namespace}/leaderboards/{leaderboardCode}";

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