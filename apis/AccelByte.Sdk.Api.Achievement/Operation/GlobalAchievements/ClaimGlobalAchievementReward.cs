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

using AccelByte.Sdk.Api.Achievement.Model;

namespace AccelByte.Sdk.Api.Achievement.Operation
{
    /// <summary>
    /// ClaimGlobalAchievementReward
    ///
    /// 
    /// 
    /// Required permission
    /// `NAMESPACE:{namespace}:USER:{userId}:ACHIEVEMENT [READ]` and scope `social`
    /// 
    /// 
    /// 
    /// 
    /// Note:
    /// 
    /// 
    /// 
    /// 
    /// Global achievement should be unlocked to claim the reward. Only contributor of global achievement are eligible for rewards
    /// </summary>
    public class ClaimGlobalAchievementReward : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ClaimGlobalAchievementRewardBuilder Builder { get => new ClaimGlobalAchievementRewardBuilder(); }

        public class ClaimGlobalAchievementRewardBuilder
            : OperationBuilder<ClaimGlobalAchievementRewardBuilder>
        {





            internal ClaimGlobalAchievementRewardBuilder() { }

            internal ClaimGlobalAchievementRewardBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public ClaimGlobalAchievementReward Build(
                string achievementCode,
                string namespace_,
                string userId
            )
            {
                ClaimGlobalAchievementReward op = new ClaimGlobalAchievementReward(this,
                    achievementCode,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public void Execute(
                string achievementCode,
                string namespace_,
                string userId
            )
            {
                ClaimGlobalAchievementReward op = Build(
                    achievementCode,
                    namespace_,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private ClaimGlobalAchievementReward(ClaimGlobalAchievementRewardBuilder builder,
            string achievementCode,
            string namespace_,
            string userId
        )
        {
            PathParams["achievementCode"] = achievementCode;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public ClaimGlobalAchievementReward(
            string achievementCode,
            string namespace_,
            string userId
        )
        {
            PathParams["achievementCode"] = achievementCode;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/achievement/v1/public/namespaces/{namespace}/users/{userId}/global/achievements/{achievementCode}/claim";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)202)
            {
                return;
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}