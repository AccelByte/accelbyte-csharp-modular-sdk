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
    /// publicClaimUserRewardsByGoalCode
    ///
    /// 
    ///     * Required permission: NAMESPACE:{namespace}:CHALLENGE:REWARD [UPDATE]
    /// </summary>
    public class PublicClaimUserRewardsByGoalCode : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicClaimUserRewardsByGoalCodeBuilder Builder { get => new PublicClaimUserRewardsByGoalCodeBuilder(); }

        public class PublicClaimUserRewardsByGoalCodeBuilder
            : OperationBuilder<PublicClaimUserRewardsByGoalCodeBuilder>
        {





            internal PublicClaimUserRewardsByGoalCodeBuilder() { }

            internal PublicClaimUserRewardsByGoalCodeBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicClaimUserRewardsByGoalCode Build(
                ModelClaimUserRewardsByGoalCodeRequest body,
                string challengeCode,
                string namespace_
            )
            {
                PublicClaimUserRewardsByGoalCode op = new PublicClaimUserRewardsByGoalCode(this,
                    body,                    
                    challengeCode,                    
                    namespace_                    
                );

                op.SetBaseFields<PublicClaimUserRewardsByGoalCodeBuilder>(this);
                return op;
            }

            public PublicClaimUserRewardsByGoalCode.Response Execute(
                ModelClaimUserRewardsByGoalCodeRequest body,
                string challengeCode,
                string namespace_
            )
            {
                PublicClaimUserRewardsByGoalCode op = Build(
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
            public async Task<PublicClaimUserRewardsByGoalCode.Response> ExecuteAsync(
                ModelClaimUserRewardsByGoalCodeRequest body,
                string challengeCode,
                string namespace_
            )
            {
                PublicClaimUserRewardsByGoalCode op = Build(
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

        private PublicClaimUserRewardsByGoalCode(PublicClaimUserRewardsByGoalCodeBuilder builder,
            ModelClaimUserRewardsByGoalCodeRequest body,
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
        public class Response : ApiResponse<List<Model.ModelUserReward>>
        {

            public IamErrorResponse? Error400 { get; set; } = null;

            public IamErrorResponse? Error401 { get; set; } = null;

            public IamErrorResponse? Error403 { get; set; } = null;

            public IamErrorResponse? Error404 { get; set; } = null;

            public IamErrorResponse? Error422 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Challenge::PlayerReward::PublicClaimUserRewardsByGoalCode";
        }

        #endregion

        public PublicClaimUserRewardsByGoalCode(
            string challengeCode,            
            string namespace_,            
            Model.ModelClaimUserRewardsByGoalCodeRequest body            
        )
        {
            PathParams["challengeCode"] = challengeCode;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/challenge/v1/public/namespaces/{namespace}/users/me/challenges/{challengeCode}/rewards/claim";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public PublicClaimUserRewardsByGoalCode.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new PublicClaimUserRewardsByGoalCode.Response()
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