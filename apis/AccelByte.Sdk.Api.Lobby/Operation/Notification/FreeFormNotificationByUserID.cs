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

using AccelByte.Sdk.Api.Lobby.Model;

namespace AccelByte.Sdk.Api.Lobby.Operation
{
    /// <summary>
    /// freeFormNotificationByUserID
    ///
    /// Sends notification to a user.
    /// </summary>
    public class FreeFormNotificationByUserID : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static FreeFormNotificationByUserIDBuilder Builder { get => new FreeFormNotificationByUserIDBuilder(); }

        public class FreeFormNotificationByUserIDBuilder
            : OperationBuilder<FreeFormNotificationByUserIDBuilder>
        {





            internal FreeFormNotificationByUserIDBuilder() { }

            internal FreeFormNotificationByUserIDBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public FreeFormNotificationByUserID Build(
                ModelFreeFormNotificationRequest body,
                string namespace_,
                string userId
            )
            {
                FreeFormNotificationByUserID op = new FreeFormNotificationByUserID(this,
                    body,                    
                    namespace_,                    
                    userId                    
                );

                op.SetBaseFields<FreeFormNotificationByUserIDBuilder>(this);
                return op;
            }

            public FreeFormNotificationByUserID.Response Execute(
                ModelFreeFormNotificationRequest body,
                string namespace_,
                string userId
            )
            {
                FreeFormNotificationByUserID op = Build(
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
            public async Task<FreeFormNotificationByUserID.Response> ExecuteAsync(
                ModelFreeFormNotificationRequest body,
                string namespace_,
                string userId
            )
            {
                FreeFormNotificationByUserID op = Build(
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

        private FreeFormNotificationByUserID(FreeFormNotificationByUserIDBuilder builder,
            ModelFreeFormNotificationRequest body,
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

            public RestapiErrorResponseBody? Error400 { get; set; } = null;

            public RestapiErrorResponseBody? Error401 { get; set; } = null;

            public RestapiErrorResponseBody? Error403 { get; set; } = null;

            public RestapiErrorResponseBody? Error404 { get; set; } = null;


            protected override string GetFullOperationId() => "Lobby::Notification::FreeFormNotificationByUserID";
        }

        #endregion

        public FreeFormNotificationByUserID(
            string namespace_,            
            string userId,            
            Model.ModelFreeFormNotificationRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/notification/namespaces/{namespace}/users/{userId}/freeform";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public FreeFormNotificationByUserID.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new FreeFormNotificationByUserID.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };

            if (code == (HttpStatusCode)400)
            
            {
                response.Error400 = JsonSerializer.Deserialize<RestapiErrorResponseBody>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            
            {
                response.Error401 = JsonSerializer.Deserialize<RestapiErrorResponseBody>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            
            {
                response.Error403 = JsonSerializer.Deserialize<RestapiErrorResponseBody>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)
            
            {
                response.Error404 = JsonSerializer.Deserialize<RestapiErrorResponseBody>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }

            return response;
        }
    }

}