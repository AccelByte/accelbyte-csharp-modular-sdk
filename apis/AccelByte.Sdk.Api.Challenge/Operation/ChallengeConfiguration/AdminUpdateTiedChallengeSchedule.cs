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
    /// adminUpdateTiedChallengeSchedule
    ///
    /// 
    ///     * Required permission: ADMIN:NAMESPACE:{namespace}:CHALLENGE [UPDATE]
    /// 
    /// Request body:
    ///     * action: Update the challenge schedule. The available options are:
    ///       * STOP: Ends the challenge, changing its status to RETIRED. This option supports all types of challenges.
    ///       * ACCELERATE: Speeds up the challenge's end time. Note that this option does not apply to challenges with an 'endAfter' value.
    ///     * endDate: The timestamp specifying when the challenge should end (required if the action is ACCELERATE).
    /// </summary>
    public class AdminUpdateTiedChallengeSchedule : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpdateTiedChallengeScheduleBuilder Builder { get => new AdminUpdateTiedChallengeScheduleBuilder(); }

        public class AdminUpdateTiedChallengeScheduleBuilder
            : OperationBuilder<AdminUpdateTiedChallengeScheduleBuilder>
        {





            internal AdminUpdateTiedChallengeScheduleBuilder() { }

            internal AdminUpdateTiedChallengeScheduleBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminUpdateTiedChallengeSchedule Build(
                ModelUpdateChallengeScheduleRequest body,
                string challengeCode,
                string namespace_
            )
            {
                AdminUpdateTiedChallengeSchedule op = new AdminUpdateTiedChallengeSchedule(this,
                    body,                    
                    challengeCode,                    
                    namespace_                    
                );

                op.SetBaseFields<AdminUpdateTiedChallengeScheduleBuilder>(this);
                return op;
            }

            public AdminUpdateTiedChallengeSchedule.Response Execute(
                ModelUpdateChallengeScheduleRequest body,
                string challengeCode,
                string namespace_
            )
            {
                AdminUpdateTiedChallengeSchedule op = Build(
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
            public async Task<AdminUpdateTiedChallengeSchedule.Response> ExecuteAsync(
                ModelUpdateChallengeScheduleRequest body,
                string challengeCode,
                string namespace_
            )
            {
                AdminUpdateTiedChallengeSchedule op = Build(
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

        private AdminUpdateTiedChallengeSchedule(AdminUpdateTiedChallengeScheduleBuilder builder,
            ModelUpdateChallengeScheduleRequest body,
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
        public class Response : ApiResponse<Model.ModelChallengeResponse>
        {

            public ResponseError? Error400 { get; set; } = null;

            public ResponseError? Error401 { get; set; } = null;

            public ResponseError? Error403 { get; set; } = null;

            public ResponseError? Error404 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Challenge::ChallengeConfiguration::AdminUpdateTiedChallengeSchedule";
        }

        #endregion

        public AdminUpdateTiedChallengeSchedule(
            string challengeCode,            
            string namespace_,            
            Model.ModelUpdateChallengeScheduleRequest body            
        )
        {
            PathParams["challengeCode"] = challengeCode;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/challenge/v1/admin/namespaces/{namespace}/challenges/{challengeCode}/tied/schedule";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public AdminUpdateTiedChallengeSchedule.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminUpdateTiedChallengeSchedule.Response()
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
                response.Error401 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
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