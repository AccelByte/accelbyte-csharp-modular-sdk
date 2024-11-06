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
    /// getRewardByCode
    ///
    /// This API is used to get reward by reward code.
    /// Other detail info:
    /// 
    ///   * Returns : reward instance
    /// </summary>
    public class GetRewardByCode : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetRewardByCodeBuilder Builder { get => new GetRewardByCodeBuilder(); }

        public class GetRewardByCodeBuilder
            : OperationBuilder<GetRewardByCodeBuilder>
        {





            internal GetRewardByCodeBuilder() { }

            internal GetRewardByCodeBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetRewardByCode Build(
                string namespace_,
                string rewardCode
            )
            {
                GetRewardByCode op = new GetRewardByCode(this,
                    namespace_,                    
                    rewardCode                    
                );

                op.SetBaseFields<GetRewardByCodeBuilder>(this);
                return op;
            }

            public GetRewardByCode.Response Execute(
                string namespace_,
                string rewardCode
            )
            {
                GetRewardByCode op = Build(
                    namespace_,
                    rewardCode
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<GetRewardByCode.Response> ExecuteAsync(
                string namespace_,
                string rewardCode
            )
            {
                GetRewardByCode op = Build(
                    namespace_,
                    rewardCode
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

        private GetRewardByCode(GetRewardByCodeBuilder builder,
            string namespace_,
            string rewardCode
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (rewardCode is not null) QueryParams["rewardCode"] = rewardCode;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.RewardInfo>
        {

            public ErrorEntity? Error404 { get; set; } = null;


            protected override string GetFullOperationId() => "Platform::Reward::GetRewardByCode";
        }

        #endregion

        public GetRewardByCode(
            string namespace_,            
            string rewardCode            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (rewardCode is not null) QueryParams["rewardCode"] = rewardCode;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/rewards/byCode";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public GetRewardByCode.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GetRewardByCode.Response()
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
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }

            return response;
        }
    }

}