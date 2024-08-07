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
    /// deleteReward
    ///
    /// This API is used to delete a reward by reward Id.
    /// 
    /// Other detail info:
    /// 
    ///   * Returns : the deleted reward data
    /// </summary>
    public class DeleteReward : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteRewardBuilder Builder { get => new DeleteRewardBuilder(); }

        public class DeleteRewardBuilder
            : OperationBuilder<DeleteRewardBuilder>
        {





            internal DeleteRewardBuilder() { }

            internal DeleteRewardBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteReward Build(
                string namespace_,
                string rewardId
            )
            {
                DeleteReward op = new DeleteReward(this,
                    namespace_,
                    rewardId
                );

                op.SetBaseFields<DeleteRewardBuilder>(this);
                return op;
            }

            public Model.RewardInfo? Execute(
                string namespace_,
                string rewardId
            )
            {
                DeleteReward op = Build(
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
                DeleteReward op = Build(
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

        private DeleteReward(DeleteRewardBuilder builder,
            string namespace_,
            string rewardId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["rewardId"] = rewardId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteReward(
            string namespace_,
            string rewardId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["rewardId"] = rewardId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/rewards/{rewardId}";

        public override HttpMethod Method => HttpMethod.Delete;

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