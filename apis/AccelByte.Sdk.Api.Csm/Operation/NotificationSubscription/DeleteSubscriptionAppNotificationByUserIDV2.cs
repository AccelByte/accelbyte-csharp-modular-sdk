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

using AccelByte.Sdk.Api.Csm.Model;

namespace AccelByte.Sdk.Api.Csm.Operation
{
    /// <summary>
    /// DeleteSubscriptionAppNotificationByUserIDV2
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:EXTEND:APP:ALERT:SUBSCRIPTION [DELETE]`
    /// 
    /// Remove a user from the notification subscription by user ID.
    /// </summary>
    public class DeleteSubscriptionAppNotificationByUserIDV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteSubscriptionAppNotificationByUserIDV2Builder Builder { get => new DeleteSubscriptionAppNotificationByUserIDV2Builder(); }

        public class DeleteSubscriptionAppNotificationByUserIDV2Builder
            : OperationBuilder<DeleteSubscriptionAppNotificationByUserIDV2Builder>
        {





            internal DeleteSubscriptionAppNotificationByUserIDV2Builder() { }

            internal DeleteSubscriptionAppNotificationByUserIDV2Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteSubscriptionAppNotificationByUserIDV2 Build(
                string app,
                string namespace_,
                string userId
            )
            {
                DeleteSubscriptionAppNotificationByUserIDV2 op = new DeleteSubscriptionAppNotificationByUserIDV2(this,
                    app,                    
                    namespace_,                    
                    userId                    
                );

                op.SetBaseFields<DeleteSubscriptionAppNotificationByUserIDV2Builder>(this);
                return op;
            }

            public DeleteSubscriptionAppNotificationByUserIDV2.Response Execute(
                string app,
                string namespace_,
                string userId
            )
            {
                DeleteSubscriptionAppNotificationByUserIDV2 op = Build(
                    app,
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
            public async Task<DeleteSubscriptionAppNotificationByUserIDV2.Response> ExecuteAsync(
                string app,
                string namespace_,
                string userId
            )
            {
                DeleteSubscriptionAppNotificationByUserIDV2 op = Build(
                    app,
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

        private DeleteSubscriptionAppNotificationByUserIDV2(DeleteSubscriptionAppNotificationByUserIDV2Builder builder,
            string app,
            string namespace_,
            string userId
        )
        {
            PathParams["app"] = app;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {

            public ResponseErrorResponse? Error401 { get; set; } = null;

            public ResponseErrorResponse? Error403 { get; set; } = null;

            public ResponseErrorResponse? Error404 { get; set; } = null;

            public ResponseErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Csm::NotificationSubscription::DeleteSubscriptionAppNotificationByUserIDV2";
        }

        #endregion

        public DeleteSubscriptionAppNotificationByUserIDV2(
            string app,            
            string namespace_,            
            string userId            
        )
        {
            PathParams["app"] = app;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/csm/v2/admin/namespaces/{namespace}/apps/{app}/subscriptions/users/{userId}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public DeleteSubscriptionAppNotificationByUserIDV2.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new DeleteSubscriptionAppNotificationByUserIDV2.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };

            if (code == (HttpStatusCode)401)
            
            {
                response.Error401 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            
            {
                response.Error403 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)
            
            {
                response.Error404 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            
            {
                response.Error500 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}