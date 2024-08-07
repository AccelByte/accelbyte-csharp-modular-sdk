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
    /// AdminUpdateAchievementListOrder
    ///
    /// 
    /// 
    /// Required permission
    /// `ADMIN:NAMESPACE:{namespace}:ACHIEVEMENT [UPDATE]` and scope `social`
    /// </summary>
    public class AdminUpdateAchievementListOrder : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpdateAchievementListOrderBuilder Builder { get => new AdminUpdateAchievementListOrderBuilder(); }

        public class AdminUpdateAchievementListOrderBuilder
            : OperationBuilder<AdminUpdateAchievementListOrderBuilder>
        {





            internal AdminUpdateAchievementListOrderBuilder() { }

            internal AdminUpdateAchievementListOrderBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminUpdateAchievementListOrder Build(
                ModelsAchievementOrderUpdateRequest body,
                string achievementCode,
                string namespace_
            )
            {
                AdminUpdateAchievementListOrder op = new AdminUpdateAchievementListOrder(this,
                    body,
                    achievementCode,
                    namespace_
                );

                op.SetBaseFields<AdminUpdateAchievementListOrderBuilder>(this);
                return op;
            }

            public void Execute(
                ModelsAchievementOrderUpdateRequest body,
                string achievementCode,
                string namespace_
            )
            {
                AdminUpdateAchievementListOrder op = Build(
                    body,
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
                ModelsAchievementOrderUpdateRequest body,
                string achievementCode,
                string namespace_
            )
            {
                AdminUpdateAchievementListOrder op = Build(
                    body,
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

        private AdminUpdateAchievementListOrder(AdminUpdateAchievementListOrderBuilder builder,
            ModelsAchievementOrderUpdateRequest body,
            string achievementCode,
            string namespace_
        )
        {
            PathParams["achievementCode"] = achievementCode;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminUpdateAchievementListOrder(
            string achievementCode,
            string namespace_,
            Model.ModelsAchievementOrderUpdateRequest body
        )
        {
            PathParams["achievementCode"] = achievementCode;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/achievement/v1/admin/namespaces/{namespace}/achievements/{achievementCode}";

        public override HttpMethod Method => HttpMethod.Patch;

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