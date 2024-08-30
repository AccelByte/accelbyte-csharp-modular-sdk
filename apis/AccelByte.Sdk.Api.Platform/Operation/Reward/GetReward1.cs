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
    /// getReward_1
    ///
    /// This API is used to get reward by reward Id.
    /// Other detail info:
    /// 
    ///   * Returns : reward instance
    /// </summary>
    public class GetReward1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetReward1Builder Builder { get => new GetReward1Builder(); }

        public class GetReward1Builder
            : OperationBuilder<GetReward1Builder>
        {





            internal GetReward1Builder() { }

            internal GetReward1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetReward1 Build(
                string namespace_,
                string rewardId
            )
            {
                GetReward1 op = new GetReward1(this,
                    namespace_,
                    rewardId
                );

                op.SetBaseFields<GetReward1Builder>(this);
                return op;
            }

            public Model.RewardInfo? Execute(
                string namespace_,
                string rewardId
            )
            {
                GetReward1 op = Build(
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
            public async Task<Model.RewardInfo?> ExecuteAsync(
                string namespace_,
                string rewardId
            )
            {
                GetReward1 op = Build(
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

        private GetReward1(GetReward1Builder builder,
            string namespace_,
            string rewardId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["rewardId"] = rewardId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetReward1(
            string namespace_,
            string rewardId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["rewardId"] = rewardId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/rewards/{rewardId}";

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