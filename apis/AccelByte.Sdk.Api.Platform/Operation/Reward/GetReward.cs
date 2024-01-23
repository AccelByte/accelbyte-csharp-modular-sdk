// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
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

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Net.Http;

using AccelByte.Sdk.Api.Platform.Model;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// getReward
    ///
    /// This API is used to get reward by reward Id.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:REWARD", action=2 (READ)
    ///   *  Returns : reward instance
    /// </summary>
    public class GetReward : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetRewardBuilder Builder { get => new GetRewardBuilder(); }

        public class GetRewardBuilder
            : OperationBuilder<GetRewardBuilder>
        {





            internal GetRewardBuilder() { }

            internal GetRewardBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetReward Build(
                string namespace_,
                string rewardId
            )
            {
                GetReward op = new GetReward(this,
                    namespace_,
                    rewardId
                );

                op.SetBaseFields<GetRewardBuilder>(this);
                return op;
            }

            public Model.RewardInfo? Execute(
                string namespace_,
                string rewardId
            )
            {
                GetReward op = Build(
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
        }

        private GetReward(GetRewardBuilder builder,
            string namespace_,
            string rewardId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["rewardId"] = rewardId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetReward(
            string namespace_,
            string rewardId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["rewardId"] = rewardId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/rewards/{rewardId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.RewardInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.RewardInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.RewardInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}