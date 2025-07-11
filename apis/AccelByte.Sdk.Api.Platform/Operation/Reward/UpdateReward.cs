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

using AccelByte.Sdk.Api.Platform.Model;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// updateReward
    ///
    /// This API is used to update a reward.
    /// Other detail info:
    /// 
    ///   * Returns : reward instance
    ///   *  Acceptable values for rewardItem's identityType are : ITEM_ID or ITEM_SKU
    /// </summary>
    public class UpdateReward : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateRewardBuilder Builder { get => new UpdateRewardBuilder(); }

        public class UpdateRewardBuilder
            : OperationBuilder<UpdateRewardBuilder>
        {





            internal UpdateRewardBuilder() { }

            internal UpdateRewardBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UpdateReward Build(
                RewardUpdate body,
                string namespace_,
                string rewardId
            )
            {
                UpdateReward op = new UpdateReward(this,
                    body,                    
                    namespace_,                    
                    rewardId                    
                );

                op.SetBaseFields<UpdateRewardBuilder>(this);
                return op;
            }

            public UpdateReward.Response Execute(
                RewardUpdate body,
                string namespace_,
                string rewardId
            )
            {
                UpdateReward op = Build(
                    body,
                    namespace_,
                    rewardId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<UpdateReward.Response> ExecuteAsync(
                RewardUpdate body,
                string namespace_,
                string rewardId
            )
            {
                UpdateReward op = Build(
                    body,
                    namespace_,
                    rewardId
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

        private UpdateReward(UpdateRewardBuilder builder,
            RewardUpdate body,
            string namespace_,
            string rewardId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["rewardId"] = rewardId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.RewardInfo>
        {

            public ErrorEntity? Error400 { get; set; } = null;

            public ErrorEntity? Error404 { get; set; } = null;

            public ErrorEntity? Error409 { get; set; } = null;


            protected override string GetFullOperationId() => "Platform::Reward::UpdateReward";
        }

        #endregion

        public UpdateReward(
            string namespace_,            
            string rewardId,            
            Model.RewardUpdate body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["rewardId"] = rewardId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/rewards/{rewardId}";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public UpdateReward.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new UpdateReward.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.RewardInfo>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)409)
            {
                response.Error409 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error409!.TranslateToApiError();
            }

            return response;
        }
    }

}