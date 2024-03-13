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
    /// createLeaderboardConfigurationAdminV1
    ///
    /// 
    /// 
    ///  Fields :
    /// 
    /// 
    /// 
    /// 
    ///   * LeaderboardConfig code must be lowercase and maximum length is 48 characters. (required).
    /// 
    /// 
    ///   * Maximum length for leaderboard name is 128 characters. (required).
    /// 
    /// 
    ///   * Start time must be follow RFC3339 standard. e.g. 2020-10-02T15:00:00.05Z (required).
    /// 
    /// 
    ///   * Season period must be greater than 31 days.
    /// 
    /// 
    ///   * If seasonPeriod is filled, the LeaderboardConfig would have seasonal leaderboard.
    /// 
    /// 
    ///   * Reset Date must be a number 1 - 31. Default is '1'.
    /// 
    /// 
    ///   * Reset Day must be a number 0 - 6. 0 = Sunday, 1 = Monday, 2 = Tuesday, 3 = Wednesday, 4 = Thursday, 5 = Friday, 6 = Saturday (day of week). Default is '0'.
    /// 
    /// 
    ///   * Reset time must be hours:minutes in 24 hours format e.g. 01:30, 10:30, 15:30, 23:15.Default is '00:00'.
    /// 
    /// 
    ///   * Stat Code is related with statistic code in statistic service. (required).
    /// </summary>
    public class CreateLeaderboardConfigurationAdminV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateLeaderboardConfigurationAdminV1Builder Builder { get => new CreateLeaderboardConfigurationAdminV1Builder(); }

        public class CreateLeaderboardConfigurationAdminV1Builder
            : OperationBuilder<CreateLeaderboardConfigurationAdminV1Builder>
        {





            internal CreateLeaderboardConfigurationAdminV1Builder() { }

            internal CreateLeaderboardConfigurationAdminV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public CreateLeaderboardConfigurationAdminV1 Build(
                ModelsLeaderboardConfigReq body,
                string namespace_
            )
            {
                CreateLeaderboardConfigurationAdminV1 op = new CreateLeaderboardConfigurationAdminV1(this,
                    body,
                    namespace_
                );

                op.SetBaseFields<CreateLeaderboardConfigurationAdminV1Builder>(this);
                return op;
            }

            public Model.ModelsLeaderboardConfigReq? Execute(
                ModelsLeaderboardConfigReq body,
                string namespace_
            )
            {
                CreateLeaderboardConfigurationAdminV1 op = Build(
                    body,
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

        private CreateLeaderboardConfigurationAdminV1(CreateLeaderboardConfigurationAdminV1Builder builder,
            ModelsLeaderboardConfigReq body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CreateLeaderboardConfigurationAdminV1(
            string namespace_,
            Model.ModelsLeaderboardConfigReq body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/leaderboard/v1/admin/namespaces/{namespace}/leaderboards";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsLeaderboardConfigReq? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsLeaderboardConfigReq>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsLeaderboardConfigReq>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}