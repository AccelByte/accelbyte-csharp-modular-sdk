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
    /// AdminDeleteAchievement
    ///
    /// 
    /// 
    /// Required permission
    /// `ADMIN:NAMESPACE:{namespace}:ACHIEVEMENT [DELETE]` and scope `social`
    /// </summary>
    public class AdminDeleteAchievement : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDeleteAchievementBuilder Builder { get => new AdminDeleteAchievementBuilder(); }

        public class AdminDeleteAchievementBuilder
            : OperationBuilder<AdminDeleteAchievementBuilder>
        {





            internal AdminDeleteAchievementBuilder() { }

            internal AdminDeleteAchievementBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminDeleteAchievement Build(
                string achievementCode,
                string namespace_
            )
            {
                AdminDeleteAchievement op = new AdminDeleteAchievement(this,
                    achievementCode,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public void Execute(
                string achievementCode,
                string namespace_
            )
            {
                AdminDeleteAchievement op = Build(
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
        }

        private AdminDeleteAchievement(AdminDeleteAchievementBuilder builder,
            string achievementCode,
            string namespace_
        )
        {
            PathParams["achievementCode"] = achievementCode;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminDeleteAchievement(
            string achievementCode,            
            string namespace_            
        )
        {
            PathParams["achievementCode"] = achievementCode;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/achievement/v1/admin/namespaces/{namespace}/achievements/{achievementCode}";

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