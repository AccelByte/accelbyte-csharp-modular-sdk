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
    /// GetNotificationSubscriberListV2
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:EXTEND:APP:ALERT:SUBSCRIPTION [READ]`
    /// 
    /// Request param:
    /// - notificationType : type of the subscribed app notification
    /// - values:
    /// - all
    /// - app-down
    /// - critical-vulnerability
    /// 
    /// Get a list of the app notification subscriber
    /// </summary>
    public class GetNotificationSubscriberListV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetNotificationSubscriberListV2Builder Builder { get => new GetNotificationSubscriberListV2Builder(); }

        public class GetNotificationSubscriberListV2Builder
            : OperationBuilder<GetNotificationSubscriberListV2Builder>
        {

            public string? NotificationType { get; set; }





            internal GetNotificationSubscriberListV2Builder() { }

            internal GetNotificationSubscriberListV2Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetNotificationSubscriberListV2Builder SetNotificationType(string _notificationType)
            {
                NotificationType = _notificationType;
                return this;
            }





            public GetNotificationSubscriberListV2 Build(
                string app,
                string namespace_
            )
            {
                GetNotificationSubscriberListV2 op = new GetNotificationSubscriberListV2(this,
                    app,                    
                    namespace_                    
                );

                op.SetBaseFields<GetNotificationSubscriberListV2Builder>(this);
                return op;
            }

            public GetNotificationSubscriberListV2.Response Execute(
                string app,
                string namespace_
            )
            {
                GetNotificationSubscriberListV2 op = Build(
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
            public async Task<GetNotificationSubscriberListV2.Response> ExecuteAsync(
                string app,
                string namespace_
            )
            {
                GetNotificationSubscriberListV2 op = Build(
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

        private GetNotificationSubscriberListV2(GetNotificationSubscriberListV2Builder builder,
            string app,
            string namespace_
        )
        {
            PathParams["app"] = app;
            PathParams["namespace"] = namespace_;
            
            if (builder.NotificationType is not null) QueryParams["notificationType"] = builder.NotificationType;
            

            
            
            

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


            protected override string GetFullOperationId() => "Csm::NotificationSubscription::GetNotificationSubscriberListV2";
        }

        #endregion

        public GetNotificationSubscriberListV2(
            string app,            
            string namespace_,            
            string? notificationType            
        )
        {
            PathParams["app"] = app;
            PathParams["namespace"] = namespace_;
            
            if (notificationType is not null) QueryParams["notificationType"] = notificationType;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/csm/v2/admin/namespaces/{namespace}/apps/{app}/subscriptions";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public GetNotificationSubscriberListV2.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GetNotificationSubscriberListV2.Response()
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