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
    /// unlockSteamUserAchievement
    ///
    /// This API is used to unlock steam achievement.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource=ADMIN:NAMESPACE:{namespace}:USER:{userId}:ACHIEVEMENT, action=4 (UPDATE)
    /// </summary>
    public class UnlockSteamUserAchievement : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UnlockSteamUserAchievementBuilder Builder { get => new UnlockSteamUserAchievementBuilder(); }

        public class UnlockSteamUserAchievementBuilder
            : OperationBuilder<UnlockSteamUserAchievementBuilder>
        {


            public Model.SteamAchievementUpdateRequest? Body { get; set; }




            internal UnlockSteamUserAchievementBuilder() { }

            internal UnlockSteamUserAchievementBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public UnlockSteamUserAchievementBuilder SetBody(Model.SteamAchievementUpdateRequest _body)
            {
                Body = _body;
                return this;
            }




            public UnlockSteamUserAchievement Build(
                string namespace_,
                string userId
            )
            {
                UnlockSteamUserAchievement op = new UnlockSteamUserAchievement(this,
                    namespace_,
                    userId
                );

                op.SetBaseFields<UnlockSteamUserAchievementBuilder>(this);
                return op;
            }

            public void Execute(
                string namespace_,
                string userId
            )
            {
                UnlockSteamUserAchievement op = Build(
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
                UnlockSteamUserAchievement op = Build(
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

        private UnlockSteamUserAchievement(UnlockSteamUserAchievementBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UnlockSteamUserAchievement(
            string namespace_,
            string userId,
            Model.SteamAchievementUpdateRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/achievement/steam";

        public override HttpMethod Method => HttpMethod.Put;

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