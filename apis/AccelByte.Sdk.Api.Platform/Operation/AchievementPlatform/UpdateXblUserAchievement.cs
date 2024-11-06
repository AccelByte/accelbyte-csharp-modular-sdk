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
    /// updateXblUserAchievement
    ///
    /// This API is used to update xbox live achievements.
    /// </summary>
    public class UpdateXblUserAchievement : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateXblUserAchievementBuilder Builder { get => new UpdateXblUserAchievementBuilder(); }

        public class UpdateXblUserAchievementBuilder
            : OperationBuilder<UpdateXblUserAchievementBuilder>
        {





            internal UpdateXblUserAchievementBuilder() { }

            internal UpdateXblUserAchievementBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UpdateXblUserAchievement Build(
                XblAchievementUpdateRequest body,
                string namespace_,
                string userId
            )
            {
                UpdateXblUserAchievement op = new UpdateXblUserAchievement(this,
                    body,                    
                    namespace_,                    
                    userId                    
                );

                op.SetBaseFields<UpdateXblUserAchievementBuilder>(this);
                return op;
            }

            public UpdateXblUserAchievement.Response Execute(
                XblAchievementUpdateRequest body,
                string namespace_,
                string userId
            )
            {
                UpdateXblUserAchievement op = Build(
                    body,
                    namespace_,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<UpdateXblUserAchievement.Response> ExecuteAsync(
                XblAchievementUpdateRequest body,
                string namespace_,
                string userId
            )
            {
                UpdateXblUserAchievement op = Build(
                    body,
                    namespace_,
                    userId
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

        private UpdateXblUserAchievement(UpdateXblUserAchievementBuilder builder,
            XblAchievementUpdateRequest body,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {

            public ValidationErrorEntity? Error400 { get; set; } = null;


            protected override string GetFullOperationId() => "Platform::AchievementPlatform::UpdateXblUserAchievement";
        }

        #endregion

        public UpdateXblUserAchievement(
            string namespace_,            
            string userId,            
            Model.XblAchievementUpdateRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/achievement/xbl";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public UpdateXblUserAchievement.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new UpdateXblUserAchievement.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };

            if (code == (HttpStatusCode)400)
            
            {
                response.Error400 = JsonSerializer.Deserialize<ValidationErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }

            return response;
        }
    }

}