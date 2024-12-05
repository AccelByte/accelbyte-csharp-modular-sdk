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
    /// adminClaimUserRewardsByGoalCode
    ///
    /// 
    ///     * Required permission: ADMIN:NAMESPACE:{namespace}:CHALLENGE:REWARD [UPDATE]
    /// </summary>
    public class AdminClaimUserRewardsByGoalCode : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminClaimUserRewardsByGoalCodeBuilder Builder { get => new AdminClaimUserRewardsByGoalCodeBuilder(); }

        public class AdminClaimUserRewardsByGoalCodeBuilder
            : OperationBuilder<AdminClaimUserRewardsByGoalCodeBuilder>
        {





            internal AdminClaimUserRewardsByGoalCodeBuilder() { }

            internal AdminClaimUserRewardsByGoalCodeBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminClaimUserRewardsByGoalCode Build(
                ModelClaimUserRewardsByGoalCodeRequest body,
                string challengeCode,
                string namespace_,
                string userId
            )
            {
                AdminClaimUserRewardsByGoalCode op = new AdminClaimUserRewardsByGoalCode(this,
                    body,
                    challengeCode,
                    namespace_,
                    userId
                );

                op.SetBaseFields<AdminClaimUserRewardsByGoalCodeBuilder>(this);
                return op;
            }

            public AdminClaimUserRewardsByGoalCode.Response Execute(
                ModelClaimUserRewardsByGoalCodeRequest body,
                string challengeCode,
                string namespace_,
                string userId
            )
            {
                AdminClaimUserRewardsByGoalCode op = Build(
                    body,
                    challengeCode,
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
            public async Task<AdminClaimUserRewardsByGoalCode.Response> ExecuteAsync(
                ModelClaimUserRewardsByGoalCodeRequest body,
                string challengeCode,
                string namespace_,
                string userId
            )
            {
                AdminClaimUserRewardsByGoalCode op = Build(
                    body,
                    challengeCode,
                    namespace_,
                    userId
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

        private AdminClaimUserRewardsByGoalCode(AdminClaimUserRewardsByGoalCodeBuilder builder,
            ModelClaimUserRewardsByGoalCodeRequest body,
            string challengeCode,
            string namespace_,
            string userId
        )
        {
            PathParams["challengeCode"] = challengeCode;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<List<Model.ModelUserReward>>
        {

            public IamErrorResponse? Error400 { get; set; } = null;

            public IamErrorResponse? Error401 { get; set; } = null;

            public IamErrorResponse? Error403 { get; set; } = null;

            public IamErrorResponse? Error404 { get; set; } = null;

            public IamErrorResponse? Error422 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Challenge::PlayerReward::AdminClaimUserRewardsByGoalCode";
        }

        #endregion

        public AdminClaimUserRewardsByGoalCode(
            string challengeCode,
            string namespace_,
            string userId,
            Model.ModelClaimUserRewardsByGoalCodeRequest body
        )
        {
            PathParams["challengeCode"] = challengeCode;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/challenge/v1/admin/namespaces/{namespace}/users/{userId}/challenges/{challengeCode}/rewards/claim";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public AdminClaimUserRewardsByGoalCode.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminClaimUserRewardsByGoalCode.Response()
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
                response.Data = JsonSerializer.Deserialize<List<Model.ModelUserReward>>(payload, ResponseJsonOptions);
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
                response.Error404 = JsonSerializer.Deserialize<IamErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
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