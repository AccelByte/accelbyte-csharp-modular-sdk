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
    /// AdminAnonymizeUserAchievement
    ///
    /// 
    /// 
    /// This API will delete specified user achievement
    /// 
    /// 
    /// 
    /// 
    /// Required permission
    /// `ADMIN:NAMESPACE:{namespace}:USER:{userId}:ANONYMIZATION [DELETE]`
    /// </summary>
    public class AdminAnonymizeUserAchievement : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminAnonymizeUserAchievementBuilder Builder { get => new AdminAnonymizeUserAchievementBuilder(); }

        public class AdminAnonymizeUserAchievementBuilder
            : OperationBuilder<AdminAnonymizeUserAchievementBuilder>
        {





            internal AdminAnonymizeUserAchievementBuilder() { }

            internal AdminAnonymizeUserAchievementBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminAnonymizeUserAchievement Build(
                string namespace_,
                string userId
            )
            {
                AdminAnonymizeUserAchievement op = new AdminAnonymizeUserAchievement(this,
                    namespace_,
                    userId
                );

                op.SetBaseFields<AdminAnonymizeUserAchievementBuilder>(this);
                return op;
            }

            public void Execute(
                string namespace_,
                string userId
            )
            {
                AdminAnonymizeUserAchievement op = Build(
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
            public async Task ExecuteAsync(
                string namespace_,
                string userId
            )
            {
                AdminAnonymizeUserAchievement op = Build(
                    namespace_,
                    userId
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

        private AdminAnonymizeUserAchievement(AdminAnonymizeUserAchievementBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminAnonymizeUserAchievement(
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/achievement/v1/admin/namespaces/{namespace}/users/{userId}/anonymization/achievements";

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