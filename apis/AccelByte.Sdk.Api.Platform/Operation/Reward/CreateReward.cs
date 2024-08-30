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
    /// createReward
    ///
    /// This API is used to create a reward.
    /// Other detail info:
    /// 
    ///   * Returns : created reward data
    ///   *  Acceptable values for rewardItem's identityType are : ITEM_ID or ITEM_SKU
    /// </summary>
    public class CreateReward : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateRewardBuilder Builder { get => new CreateRewardBuilder(); }

        public class CreateRewardBuilder
            : OperationBuilder<CreateRewardBuilder>
        {





            internal CreateRewardBuilder() { }

            internal CreateRewardBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public CreateReward Build(
                RewardCreate body,
                string namespace_
            )
            {
                CreateReward op = new CreateReward(this,
                    body,
                    namespace_
                );

                op.SetBaseFields<CreateRewardBuilder>(this);
                return op;
            }

            public Model.RewardInfo? Execute(
                RewardCreate body,
                string namespace_
            )
            {
                CreateReward op = Build(
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
            public async Task<Model.RewardInfo?> ExecuteAsync(
                RewardCreate body,
                string namespace_
            )
            {
                CreateReward op = Build(
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

        private CreateReward(CreateRewardBuilder builder,
            RewardCreate body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CreateReward(
            string namespace_,
            Model.RewardCreate body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/rewards";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

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