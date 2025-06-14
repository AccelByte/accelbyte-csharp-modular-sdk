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
    /// publicGetUserSubscription
    ///
    /// Get user subscription.
    /// Other detail info:
    /// 
    ///   * Returns : subscription
    /// </summary>
    public class PublicGetUserSubscription : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetUserSubscriptionBuilder Builder { get => new PublicGetUserSubscriptionBuilder(); }

        public class PublicGetUserSubscriptionBuilder
            : OperationBuilder<PublicGetUserSubscriptionBuilder>
        {





            internal PublicGetUserSubscriptionBuilder() { }

            internal PublicGetUserSubscriptionBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicGetUserSubscription Build(
                string namespace_,
                string subscriptionId,
                string userId
            )
            {
                PublicGetUserSubscription op = new PublicGetUserSubscription(this,
                    namespace_,                    
                    subscriptionId,                    
                    userId                    
                );

                op.SetBaseFields<PublicGetUserSubscriptionBuilder>(this);
                return op;
            }

            public PublicGetUserSubscription.Response Execute(
                string namespace_,
                string subscriptionId,
                string userId
            )
            {
                PublicGetUserSubscription op = Build(
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
            public async Task<PublicGetUserSubscription.Response> ExecuteAsync(
                string namespace_,
                string subscriptionId,
                string userId
            )
            {
                PublicGetUserSubscription op = Build(
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

        private PublicGetUserSubscription(PublicGetUserSubscriptionBuilder builder,
            string namespace_,
            string subscriptionId,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["subscriptionId"] = subscriptionId;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.SubscriptionInfo>
        {

            public ErrorEntity? Error404 { get; set; } = null;


            protected override string GetFullOperationId() => "Platform::Subscription::PublicGetUserSubscription";
        }

        #endregion

        public PublicGetUserSubscription(
            string namespace_,            
            string subscriptionId,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["subscriptionId"] = subscriptionId;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/subscriptions/{subscriptionId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public PublicGetUserSubscription.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new PublicGetUserSubscription.Response()
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

            return response;
        }
    }

}