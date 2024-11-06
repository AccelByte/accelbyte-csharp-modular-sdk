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
    /// publicCancelSubscription
    ///
    /// Cancel a subscription, only ACTIVE subscription can be cancelled. Ensure successfully cancel, recommend at least 1 day before current period ends, otherwise it may be charging or charged.
    /// Set immediate true, the subscription will be terminated immediately, otherwise till the end of current billing cycle.
    /// Other detail info:
    /// 
    ///   * Returns : cancelled subscription
    /// </summary>
    public class PublicCancelSubscription : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicCancelSubscriptionBuilder Builder { get => new PublicCancelSubscriptionBuilder(); }

        public class PublicCancelSubscriptionBuilder
            : OperationBuilder<PublicCancelSubscriptionBuilder>
        {





            internal PublicCancelSubscriptionBuilder() { }

            internal PublicCancelSubscriptionBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicCancelSubscription Build(
                CancelRequest body,
                string namespace_,
                string subscriptionId,
                string userId
            )
            {
                PublicCancelSubscription op = new PublicCancelSubscription(this,
                    body,                    
                    namespace_,                    
                    subscriptionId,                    
                    userId                    
                );

                op.SetBaseFields<PublicCancelSubscriptionBuilder>(this);
                return op;
            }

            public PublicCancelSubscription.Response Execute(
                CancelRequest body,
                string namespace_,
                string subscriptionId,
                string userId
            )
            {
                PublicCancelSubscription op = Build(
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
            public async Task<PublicCancelSubscription.Response> ExecuteAsync(
                CancelRequest body,
                string namespace_,
                string subscriptionId,
                string userId
            )
            {
                PublicCancelSubscription op = Build(
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

        private PublicCancelSubscription(PublicCancelSubscriptionBuilder builder,
            CancelRequest body,
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
        public class Response : ApiResponse<Model.SubscriptionInfo>
        {

            public ErrorEntity? Error404 { get; set; } = null;

            public ErrorEntity? Error409 { get; set; } = null;


            protected override string GetFullOperationId() => "Platform::Subscription::PublicCancelSubscription";
        }

        #endregion

        public PublicCancelSubscription(
            string namespace_,            
            string subscriptionId,            
            string userId,            
            Model.CancelRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["subscriptionId"] = subscriptionId;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/subscriptions/{subscriptionId}/cancel";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public PublicCancelSubscription.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new PublicCancelSubscription.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.SubscriptionInfo>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)409)
            {
                response.Error409 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error409!.TranslateToApiError();
            }

            return response;
        }
    }

}