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
    /// processUserSubscriptionNotification
    ///
    ///  [SERVICE COMMUNICATION ONLY] This API is used as a web hook for payment notification from justice payment service.
    /// Other detail info:
    /// 
    ///   * Returns : Process result
    /// </summary>
    public class ProcessUserSubscriptionNotification : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ProcessUserSubscriptionNotificationBuilder Builder { get => new ProcessUserSubscriptionNotificationBuilder(); }

        public class ProcessUserSubscriptionNotificationBuilder
            : OperationBuilder<ProcessUserSubscriptionNotificationBuilder>
        {





            internal ProcessUserSubscriptionNotificationBuilder() { }

            internal ProcessUserSubscriptionNotificationBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public ProcessUserSubscriptionNotification Build(
                TradeNotification body,
                string namespace_,
                string subscriptionId,
                string userId
            )
            {
                ProcessUserSubscriptionNotification op = new ProcessUserSubscriptionNotification(this,
                    body,                    
                    namespace_,                    
                    subscriptionId,                    
                    userId                    
                );

                op.SetBaseFields<ProcessUserSubscriptionNotificationBuilder>(this);
                return op;
            }

            public ProcessUserSubscriptionNotification.Response Execute(
                TradeNotification body,
                string namespace_,
                string subscriptionId,
                string userId
            )
            {
                ProcessUserSubscriptionNotification op = Build(
                    body,
                    namespace_,
                    subscriptionId,
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
            public async Task<ProcessUserSubscriptionNotification.Response> ExecuteAsync(
                TradeNotification body,
                string namespace_,
                string subscriptionId,
                string userId
            )
            {
                ProcessUserSubscriptionNotification op = Build(
                    body,
                    namespace_,
                    subscriptionId,
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

        private ProcessUserSubscriptionNotification(ProcessUserSubscriptionNotificationBuilder builder,
            TradeNotification body,
            string namespace_,
            string subscriptionId,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["subscriptionId"] = subscriptionId;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {

            public string Error400 { get; set; } = "";


            protected override string GetFullOperationId() => "Platform::Subscription::ProcessUserSubscriptionNotification";
        }

        #endregion

        public ProcessUserSubscriptionNotification(
            string namespace_,            
            string subscriptionId,            
            string userId,            
            Model.TradeNotification body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["subscriptionId"] = subscriptionId;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/subscriptions/{subscriptionId}/notifications";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public ProcessUserSubscriptionNotification.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new ProcessUserSubscriptionNotification.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };

            if (code == (HttpStatusCode)400)
            
            {
                response.Error400 = payload.ReadToString();
                response.Error = new ApiError("-1", response.Error400!);
            }

            return response;
        }
    }

}