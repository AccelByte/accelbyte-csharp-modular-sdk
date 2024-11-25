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
    /// BulkSaveSubscriptionAppNotificationV2
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:EXTEND:APP:ALERT:SUBSCRIPTION [UPDATE]`
    /// 
    /// Update the subscription the user(s) is an app notification.
    /// 
    /// Request body:
    /// - notificationType : type of the app notification to be subscribed - Required.
    /// - values:
    /// - "all"
    /// - "app-down"
    /// - "critical-vulnerability"
    /// - subscribers : user(s) notification subscription to be updated - Required.
    /// </summary>
    public class BulkSaveSubscriptionAppNotificationV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static BulkSaveSubscriptionAppNotificationV2Builder Builder { get => new BulkSaveSubscriptionAppNotificationV2Builder(); }

        public class BulkSaveSubscriptionAppNotificationV2Builder
            : OperationBuilder<BulkSaveSubscriptionAppNotificationV2Builder>
        {





            internal BulkSaveSubscriptionAppNotificationV2Builder() { }

            internal BulkSaveSubscriptionAppNotificationV2Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public BulkSaveSubscriptionAppNotificationV2 Build(
                ApimodelBulkSubscribeRequest body,
                string app,
                string namespace_
            )
            {
                BulkSaveSubscriptionAppNotificationV2 op = new BulkSaveSubscriptionAppNotificationV2(this,
                    body,                    
                    app,                    
                    namespace_                    
                );

                op.SetBaseFields<BulkSaveSubscriptionAppNotificationV2Builder>(this);
                return op;
            }

            public BulkSaveSubscriptionAppNotificationV2.Response Execute(
                ApimodelBulkSubscribeRequest body,
                string app,
                string namespace_
            )
            {
                BulkSaveSubscriptionAppNotificationV2 op = Build(
                    body,
                    app,
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
            public async Task<BulkSaveSubscriptionAppNotificationV2.Response> ExecuteAsync(
                ApimodelBulkSubscribeRequest body,
                string app,
                string namespace_
            )
            {
                BulkSaveSubscriptionAppNotificationV2 op = Build(
                    body,
                    app,
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

        private BulkSaveSubscriptionAppNotificationV2(BulkSaveSubscriptionAppNotificationV2Builder builder,
            ApimodelBulkSubscribeRequest body,
            string app,
            string namespace_
        )
        {
            PathParams["app"] = app;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ApimodelGetNotificationSubscriberListResponse>
        {

            public ResponseErrorResponse? Error401 { get; set; } = null;

            public ResponseErrorResponse? Error403 { get; set; } = null;

            public ResponseErrorResponse? Error404 { get; set; } = null;

            public ResponseErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Csm::NotificationSubscription::BulkSaveSubscriptionAppNotificationV2";
        }

        #endregion

        public BulkSaveSubscriptionAppNotificationV2(
            string app,            
            string namespace_,            
            Model.ApimodelBulkSubscribeRequest body            
        )
        {
            PathParams["app"] = app;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/csm/v2/admin/namespaces/{namespace}/apps/{app}/subscriptions";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public BulkSaveSubscriptionAppNotificationV2.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new BulkSaveSubscriptionAppNotificationV2.Response()
            {
                StatusCode = code,
                ContentType = contentType
            };

            if (code == (HttpStatusCode)204)
            {
                response.IsSuccess = true;
            }
            else if ((code == (HttpStatusCode)201) || (code == (HttpStatusCode)202) || (code == (HttpStatusCode)200))
            {
                response.Data = JsonSerializer.Deserialize<Model.ApimodelGetNotificationSubscriberListResponse>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)401)
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