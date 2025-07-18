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
    /// recurringChargeSubscription
    ///
    ///  [TEST FACILITY ONLY] Forbidden in live environment. Recurring charge subscription, it will trigger recurring charge if the USER subscription status is ACTIVE, nextBillingDate is before now and no fail recurring charge within X(default 12) hours.
    /// Other detail info:
    /// 
    ///   * Returns : recurring charge result
    /// </summary>
    public class RecurringChargeSubscription : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RecurringChargeSubscriptionBuilder Builder { get => new RecurringChargeSubscriptionBuilder(); }

        public class RecurringChargeSubscriptionBuilder
            : OperationBuilder<RecurringChargeSubscriptionBuilder>
        {





            internal RecurringChargeSubscriptionBuilder() { }

            internal RecurringChargeSubscriptionBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public RecurringChargeSubscription Build(
                string namespace_,
                string subscriptionId
            )
            {
                RecurringChargeSubscription op = new RecurringChargeSubscription(this,
                    namespace_,                    
                    subscriptionId                    
                );

                op.SetBaseFields<RecurringChargeSubscriptionBuilder>(this);
                return op;
            }

            public RecurringChargeSubscription.Response Execute(
                string namespace_,
                string subscriptionId
            )
            {
                RecurringChargeSubscription op = Build(
                    namespace_,
                    subscriptionId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<RecurringChargeSubscription.Response> ExecuteAsync(
                string namespace_,
                string subscriptionId
            )
            {
                RecurringChargeSubscription op = Build(
                    namespace_,
                    subscriptionId
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

        private RecurringChargeSubscription(RecurringChargeSubscriptionBuilder builder,
            string namespace_,
            string subscriptionId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["subscriptionId"] = subscriptionId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.RecurringChargeResult>
        {


            protected override string GetFullOperationId() => "Platform::Subscription::RecurringChargeSubscription";
        }

        #endregion

        public RecurringChargeSubscription(
            string namespace_,            
            string subscriptionId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["subscriptionId"] = subscriptionId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/subscriptions/{subscriptionId}/recurring";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public RecurringChargeSubscription.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new RecurringChargeSubscription.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.RecurringChargeResult>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }

            return response;
        }
    }

}