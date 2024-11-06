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
    /// adminClaimUsersRewards
    ///
    /// 
    ///     * Required permission: ADMIN:NAMESPACE:{namespace}:CHALLENGE:REWARD [UPDATE]
    /// </summary>
    public class AdminClaimUsersRewards : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminClaimUsersRewardsBuilder Builder { get => new AdminClaimUsersRewardsBuilder(); }

        public class AdminClaimUsersRewardsBuilder
            : OperationBuilder<AdminClaimUsersRewardsBuilder>
        {





            internal AdminClaimUsersRewardsBuilder() { }

            internal AdminClaimUsersRewardsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminClaimUsersRewards Build(
                List<ModelClaimUsersRewardsRequest> body,
                string namespace_
            )
            {
                AdminClaimUsersRewards op = new AdminClaimUsersRewards(this,
                    body,                    
                    namespace_                    
                );

                op.SetBaseFields<AdminClaimUsersRewardsBuilder>(this);
                return op;
            }

            public AdminClaimUsersRewards.Response Execute(
                List<ModelClaimUsersRewardsRequest> body,
                string namespace_
            )
            {
                AdminClaimUsersRewards op = Build(
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
            public async Task<AdminClaimUsersRewards.Response> ExecuteAsync(
                List<ModelClaimUsersRewardsRequest> body,
                string namespace_
            )
            {
                AdminClaimUsersRewards op = Build(
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

        private AdminClaimUsersRewards(AdminClaimUsersRewardsBuilder builder,
            List<ModelClaimUsersRewardsRequest> body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<List<Model.ModelClaimUsersRewardsResponse>>
        {

            public ResponseError? Error400 { get; set; } = null;

            public IamErrorResponse? Error401 { get; set; } = null;

            public IamErrorResponse? Error403 { get; set; } = null;

            public IamErrorResponse? Error404 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Challenge::PlayerReward::AdminClaimUsersRewards";
        }

        #endregion

        public AdminClaimUsersRewards(
            string namespace_,            
            List<Model.ModelClaimUsersRewardsRequest> body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/challenge/v1/admin/namespaces/{namespace}/users/rewards/claim";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public AdminClaimUsersRewards.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminClaimUsersRewards.Response()
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
                response.Data = JsonSerializer.Deserialize<List<Model.ModelClaimUsersRewardsResponse>>(payload, ResponseJsonOptions);
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
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<IamErrorResponse>(payload, ResponseJsonOptions);
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