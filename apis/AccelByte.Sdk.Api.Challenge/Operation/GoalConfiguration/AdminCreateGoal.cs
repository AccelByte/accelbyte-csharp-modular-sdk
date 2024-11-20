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
    /// adminCreateGoal
    ///
    /// 
    ///   * Required permission: ADMIN:NAMESPACE:{namespace}:CHALLENGE [CREATE]
    /// 
    /// Request body:
    ///     * code: unique within a challenge.
    ///     * name: name of the goal.
    ///     * description: text describing the goal (optional).
    ///     * schedule: a time range that indicated the availability of a goal within a timeframe. Used in FIXED assignment rule, this will be required in that case.
    ///     * requirementGroups: contains array of objects consisting of operator and predicates attribute. When requirements evaluation happened, each item's predicates will be evaluated first, by operating the predicates with given operator. After all items evaluated, the results of the evaluation on each item then will be logically evaluated using OR operator.
    ///       * operator: logical operator used to validate the completion of a goal. a goal is considered complete once complete predicates operated with operator result in true.
    ///       * predicates: list of progression parameters to be tracked.
    ///         * parameterType: the type of parameter for challenge to be progressed with. the available options are:
    ///           * STATISTIC: progress by user statistic item value.
    ///           * STATISTIC_CYCLE: progress user statistic cycle item value. statCycleId must be included.
    ///           * ACHIEVEMENT: progress by user achievement.
    ///           * USERACCOUNT: progress by user account event.
    ///           * ENTITLEMENT: progress by user's item entitlement ownership. Supported item types are APP, CODE, INGAMEITEM, LOOTBOX, MEDIA, and OPTIONBOX.
    ///         * parameterName: the name of the parameter for challenge to be progressed with.
    ///           * STATISTIC: refers to stat code.
    ///           * STATISTIC_CYCLE: refers to stat code with statCycleId must be included.
    ///           * ACHIEVEMENT: refers to achievement code.
    ///           * USERACCOUNT: refers to a specific event related to user accounts. The current possible events include: userAccountCreated, gameUserAccountCreated, userAccountVerified, userAccountLinked, userAccountUpgraded, thirdPartyAccountCreated, and userLoggedIn.
    ///             * For the userAccountLinked event, parameterName will utilize platformId rather than the event name. This will be validated against the list of active third-party accounts configuration within the namespace, such as psn , steam , or device.
    ///           * ENTITLEMENT: ecommerce store's item SKU.
    ///         * matcher: the comparison operator used to compare the curent value of a parameter and targetValue to validate the completion of a predicate. Possible values are EQUAL, LESS_THAN, GREATER_THAN, LESS_THAN_EQUAL, and GREATER_THAN_EQUAL.
    ///         * targetValue: the target number to be reached by the parameter.
    ///         * statCycleId: specify the statCycleId used to track statistic value in a cycle with STATISTIC_CYCLE parameterType (optional).
    ///     * rewards: list of rewards that will be claimable once a goal is complete.
    ///     * tag: goal's labels.
    ///     * isActive: when goal is in a schedule, isActive determine whether goal is active to progress or not.
    /// Goal describe set of requirements that need to be fulfilled by players in order to complete it and describe what is the rewards given to player when they complete the goal.
    /// The requirement will have target value and a operator that will evaluate that against an observable playerâs attribute (e.g. statistic, entitlement). Goal belongs to a challenge.
    /// Supported item type for ENTITLEMENT reward type: APP, BUNDLE, CODE, COINS, EXTENSION, INGAMEITEM, LOOTBOX, MEDIA, OPTIONBOX.
    /// Number of goals per challenge is limited to 100 goals.
    /// </summary>
    public class AdminCreateGoal : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminCreateGoalBuilder Builder { get => new AdminCreateGoalBuilder(); }

        public class AdminCreateGoalBuilder
            : OperationBuilder<AdminCreateGoalBuilder>
        {





            internal AdminCreateGoalBuilder() { }

            internal AdminCreateGoalBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminCreateGoal Build(
                ModelCreateGoalRequest body,
                string challengeCode,
                string namespace_
            )
            {
                AdminCreateGoal op = new AdminCreateGoal(this,
                    body,                    
                    challengeCode,                    
                    namespace_                    
                );

                op.SetBaseFields<AdminCreateGoalBuilder>(this);
                return op;
            }

            public AdminCreateGoal.Response Execute(
                ModelCreateGoalRequest body,
                string challengeCode,
                string namespace_
            )
            {
                AdminCreateGoal op = Build(
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
            public async Task<AdminCreateGoal.Response> ExecuteAsync(
                ModelCreateGoalRequest body,
                string challengeCode,
                string namespace_
            )
            {
                AdminCreateGoal op = Build(
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

        private AdminCreateGoal(AdminCreateGoalBuilder builder,
            ModelCreateGoalRequest body,
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

        #region Response Part        
        public class Response : ApiResponse<Model.ModelGoalResponse>
        {

            public IamErrorResponse? Error400 { get; set; } = null;

            public IamErrorResponse? Error401 { get; set; } = null;

            public IamErrorResponse? Error403 { get; set; } = null;

            public ResponseError? Error404 { get; set; } = null;

            public ResponseError? Error409 { get; set; } = null;

            public IamErrorResponse? Error422 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Challenge::GoalConfiguration::AdminCreateGoal";
        }

        #endregion

        public AdminCreateGoal(
            string challengeCode,            
            string namespace_,            
            Model.ModelCreateGoalRequest body            
        )
        {
            PathParams["challengeCode"] = challengeCode;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/challenge/v1/admin/namespaces/{namespace}/challenges/{challengeCode}/goals";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public AdminCreateGoal.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminCreateGoal.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelGoalResponse>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<IamErrorResponse>(payload, ResponseJsonOptions);
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
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)409)
            {
                response.Error409 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error409!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)422)
            {
                response.Error422 = JsonSerializer.Deserialize<IamErrorResponse>(payload, ResponseJsonOptions);
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