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

using AccelByte.Sdk.Api.Challenge.Model;

namespace AccelByte.Sdk.Api.Challenge.Operation
{
    /// <summary>
    /// adminCreateChallenge
    ///
    /// 
    ///   * Required permission: ADMIN:NAMESPACE:{namespace}:CHALLENGE [CREATE]
    /// 
    /// Challenge is a collection of goals that can be completed by players. Challenge can have rules that specify what and when goals will be available for players to be taken.
    /// 
    /// Request body:
    /// 
    ///   * code: only lowercase letters, numbers, and the separator - are allowed; must start and end with letter
    ///   * name: name of the challenge
    ///   * description: text describing about the challenge (optional)
    ///   * startDate: timestamp of when the challenge is started
    ///   * endDate: timestamp of when the challenge is ended (optional)
    ///   * endAfter: describe number of period challenge will be retired after (optional)
    /// To configure challenge that never end, leave the endDate and endAfter field null/empty.
    ///   * repeatAfter: describe number of period challenge's goals will be repeated after. Leave it empty if you don't want to repeat the challenge.
    ///   * rotation: describe how long goals in a challenge will be available for players to progress before rotated with another goals. (DAILY|WEEKLY|MONTHLY|NONE)
    ///   * activeGoalsPerRotation: number of goals per rotation (currently only applicable for RANDOMIZE assignment)
    ///   * assignmentRule: describe how the goals will be assigned and scheduled to users. (FIXED|RANDOMIZED|UNSCHEDULED|CUSTOM)
    ///   * goalsVisibility: describe whether users can see all goals under challenge, or only active goal in one rotation period only. (SHOWALL|PERIODONLY)
    ///   * resetConfig: describe when rotation reset will happen (optional).
    ///     * resetTime: Reset time must follow hours:minutes in 24 hours format (e.g. 01:30, 23:15) and in UTC timezone. Default to "00:00"
    ///     * resetDay: Reset Day follows the ISO-8601 standard, from 1 (Monday) to 7 (Sunday). Default to 1 in WEEKLY rotation.
    ///     * resetDate: Reset Date must be a number 1 - 31. Default to 1 in MONTHLY rotation.
    ///   * randomizedPerRotation:
    ///     * true: each goal will be randomly assigned to multiple periods
    ///     * false: a goal will only be assigned to one period
    /// </summary>
    public class AdminCreateChallenge : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminCreateChallengeBuilder Builder { get => new AdminCreateChallengeBuilder(); }

        public class AdminCreateChallengeBuilder
            : OperationBuilder<AdminCreateChallengeBuilder>
        {





            internal AdminCreateChallengeBuilder() { }

            internal AdminCreateChallengeBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminCreateChallenge Build(
                ModelCreateChallengeRequest body,
                string namespace_
            )
            {
                AdminCreateChallenge op = new AdminCreateChallenge(this,
                    body,
                    namespace_
                );

                op.SetBaseFields<AdminCreateChallengeBuilder>(this);
                return op;
            }

            public AdminCreateChallenge.Response Execute(
                ModelCreateChallengeRequest body,
                string namespace_
            )
            {
                AdminCreateChallenge op = Build(
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
            public async Task<AdminCreateChallenge.Response> ExecuteAsync(
                ModelCreateChallengeRequest body,
                string namespace_
            )
            {
                AdminCreateChallenge op = Build(
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

        private AdminCreateChallenge(AdminCreateChallengeBuilder builder,
            ModelCreateChallengeRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelChallengeResponse>
        {

            public ResponseError? Error400 { get; set; } = null;

            public IamErrorResponse? Error401 { get; set; } = null;

            public IamErrorResponse? Error403 { get; set; } = null;

            public ResponseError? Error409 { get; set; } = null;

            public ResponseError? Error422 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Challenge::ChallengeConfiguration::AdminCreateChallenge";
        }

        #endregion

        public AdminCreateChallenge(
            string namespace_,
            Model.ModelCreateChallengeRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/challenge/v1/admin/namespaces/{namespace}/challenges";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public AdminCreateChallenge.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminCreateChallenge.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelChallengeResponse>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<IamErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<IamErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)409)
            {
                response.Error409 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error409!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)422)
            {
                response.Error422 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error422!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}