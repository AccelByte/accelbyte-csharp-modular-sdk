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
    /// adminUpdateChallenge
    ///
    /// 
    ///   * Required permission: ADMIN:NAMESPACE:{namespace}:CHALLENGE [UPDATE]
    /// 
    /// 
    /// 
    /// Request body:
    /// 
    ///   * name: name of the challenge
    ///   * description: text describing about the challenge (optional)
    ///   * startDate: timestamp of when the challenge is started
    ///   * endDate: timestamp of when the challenge is ended (optional)
    ///   * endAfter: describe number of period challenge will be retired after (optional)
    /// To configure challenge that never end, leave the endDate and endAfter field null/empty.
    ///   * repeatAfter: describe number of period challenge's goals will be repeated after. Leave it empty if you don't want to repeat the challenge.
    ///   * rotation: describe how long goals in a challenge will be available for players to progress before rotated with another goals. (DAILY|WEEKLY|MONTHLY|NONE)
    ///   * activeGoalsPerRotation: number of goals per rotation (currently only applicable for RANDOMIZE assignment)
    ///   * assignmentRule: describe how the goals will be assigned and scheduled to users. (FIXED|RANDOMIZED|UNSCHEDULED)
    ///   * goalsVisibility: describe whether users can see all goals under challenge, or only active goal in one rotation period only. (SHOWALL|PERIODONLY)
    /// </summary>
    public class AdminUpdateChallenge : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpdateChallengeBuilder Builder { get => new AdminUpdateChallengeBuilder(); }

        public class AdminUpdateChallengeBuilder
            : OperationBuilder<AdminUpdateChallengeBuilder>
        {





            internal AdminUpdateChallengeBuilder() { }

            internal AdminUpdateChallengeBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminUpdateChallenge Build(
                ModelUpdateChallengeRequest body,
                string challengeCode,
                string namespace_
            )
            {
                AdminUpdateChallenge op = new AdminUpdateChallenge(this,
                    body,
                    challengeCode,
                    namespace_
                );

                op.SetBaseFields<AdminUpdateChallengeBuilder>(this);
                return op;
            }

            public Model.ModelChallengeResponse? Execute(
                ModelUpdateChallengeRequest body,
                string challengeCode,
                string namespace_
            )
            {
                AdminUpdateChallenge op = Build(
                    body,
                    challengeCode,
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
            public async Task<Model.ModelChallengeResponse?> ExecuteAsync(
                ModelUpdateChallengeRequest body,
                string challengeCode,
                string namespace_
            )
            {
                AdminUpdateChallenge op = Build(
                    body,
                    challengeCode,
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

        private AdminUpdateChallenge(AdminUpdateChallengeBuilder builder,
            ModelUpdateChallengeRequest body,
            string challengeCode,
            string namespace_
        )
        {
            PathParams["challengeCode"] = challengeCode;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminUpdateChallenge(
            string challengeCode,
            string namespace_,
            Model.ModelUpdateChallengeRequest body
        )
        {
            PathParams["challengeCode"] = challengeCode;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/challenge/v1/admin/namespaces/{namespace}/challenges/{challengeCode}";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelChallengeResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelChallengeResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelChallengeResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}