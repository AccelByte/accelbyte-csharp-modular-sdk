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
    /// createLeaderboardConfigurationAdminV3
    ///
    /// 
    /// 
    ///  Fields :
    /// 
    /// 
    /// 
    /// 
    ///   * leaderboardCode: unique leaderboard config code must be lowercase and maximum length is 48 characters. (required).
    /// 
    /// 
    ///   * name: leaderboard name, maximum length for leaderboard name is 128 characters. (required).
    /// 
    /// 
    ///   * description: leaderboard description, maximum length for leaderboard description is 2048 characters. (optional).
    /// 
    /// 
    ///   * iconURL: leaderboard icon image url. (optional).
    /// 
    /// 
    ///   * allTime: if true, all time leaderboard will be created. (required).
    /// 
    /// 
    ///   * descending: leaderboard order. If true, the points will be sorted in descending order. (required).
    /// 
    /// 
    ///   * statCode: Stat Code is related with statistic code in statistic service. (required).
    /// 
    /// 
    ///   * cycleIds: Statistic cycle ids that will be tracked in the leaderboard. (required).
    /// </summary>
    public class CreateLeaderboardConfigurationAdminV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateLeaderboardConfigurationAdminV3Builder Builder { get => new CreateLeaderboardConfigurationAdminV3Builder(); }

        public class CreateLeaderboardConfigurationAdminV3Builder
            : OperationBuilder<CreateLeaderboardConfigurationAdminV3Builder>
        {





            internal CreateLeaderboardConfigurationAdminV3Builder() { }

            internal CreateLeaderboardConfigurationAdminV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public CreateLeaderboardConfigurationAdminV3 Build(
                ModelsLeaderboardConfigReqV3 body,
                string namespace_
            )
            {
                CreateLeaderboardConfigurationAdminV3 op = new CreateLeaderboardConfigurationAdminV3(this,
                    body,
                    namespace_
                );

                op.SetBaseFields<CreateLeaderboardConfigurationAdminV3Builder>(this);
                return op;
            }

            public CreateLeaderboardConfigurationAdminV3.Response Execute(
                ModelsLeaderboardConfigReqV3 body,
                string namespace_
            )
            {
                CreateLeaderboardConfigurationAdminV3 op = Build(
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
            public async Task<CreateLeaderboardConfigurationAdminV3.Response> ExecuteAsync(
                ModelsLeaderboardConfigReqV3 body,
                string namespace_
            )
            {
                CreateLeaderboardConfigurationAdminV3 op = Build(
                    body,
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private CreateLeaderboardConfigurationAdminV3(CreateLeaderboardConfigurationAdminV3Builder builder,
            ModelsLeaderboardConfigReqV3 body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelsGetLeaderboardConfigRespV3>
        {

            public ResponseErrorResponse? Error400 { get; set; } = null;

            public ResponseErrorResponse? Error401 { get; set; } = null;

            public ResponseErrorResponse? Error403 { get; set; } = null;

            public ResponseErrorResponse? Error409 { get; set; } = null;

            public ResponseErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Leaderboard::LeaderboardConfigurationV3::CreateLeaderboardConfigurationAdminV3";
        }

        #endregion

        public CreateLeaderboardConfigurationAdminV3(
            string namespace_,
            Model.ModelsLeaderboardConfigReqV3 body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/leaderboard/v3/admin/namespaces/{namespace}/leaderboards";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public CreateLeaderboardConfigurationAdminV3.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new CreateLeaderboardConfigurationAdminV3.Response()
            {
                StatusCode = code,
                ContentType = contentType
            };

            if (code == (HttpStatusCode)204)
            {
                response.IsSuccess = true;
            }
            else if ((code == (HttpStatusCode)201) || (code == (HttpStatusCode)202) || (code == (HttpStatusCode)200))
            {
                response.Data = JsonSerializer.Deserialize<Model.ModelsGetLeaderboardConfigRespV3>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)409)
            {
                response.Error409 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error409!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}