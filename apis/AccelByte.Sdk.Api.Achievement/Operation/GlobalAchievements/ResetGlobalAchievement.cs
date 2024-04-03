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

using AccelByte.Sdk.Api.Achievement.Model;

namespace AccelByte.Sdk.Api.Achievement.Operation
{
    /// <summary>
    /// ResetGlobalAchievement
    ///
    /// 
    /// 
    /// [TEST FACILITY ONLY]
    /// 
    /// 
    /// 
    /// 
    /// Required permission
    /// `ADMIN:NAMESPACE:{namespace}:ACHIEVEMENT [DELETE]` and scope `social`
    /// </summary>
    public class ResetGlobalAchievement : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ResetGlobalAchievementBuilder Builder { get => new ResetGlobalAchievementBuilder(); }

        public class ResetGlobalAchievementBuilder
            : OperationBuilder<ResetGlobalAchievementBuilder>
        {





            internal ResetGlobalAchievementBuilder() { }

            internal ResetGlobalAchievementBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public ResetGlobalAchievement Build(
                string achievementCode,
                string namespace_
            )
            {
                ResetGlobalAchievement op = new ResetGlobalAchievement(this,
                    achievementCode,
                    namespace_
                );

                op.SetBaseFields<ResetGlobalAchievementBuilder>(this);
                return op;
            }

            public void Execute(
                string achievementCode,
                string namespace_
            )
            {
                ResetGlobalAchievement op = Build(
                    achievementCode,
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task ExecuteAsync(
                string achievementCode,
                string namespace_
            )
            {
                ResetGlobalAchievement op = Build(
                    achievementCode,
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private ResetGlobalAchievement(ResetGlobalAchievementBuilder builder,
            string achievementCode,
            string namespace_
        )
        {
            PathParams["achievementCode"] = achievementCode;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public ResetGlobalAchievement(
            string achievementCode,
            string namespace_
        )
        {
            PathParams["achievementCode"] = achievementCode;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/achievement/v1/admin/namespaces/{namespace}/global/achievements/{achievementCode}/reset";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}