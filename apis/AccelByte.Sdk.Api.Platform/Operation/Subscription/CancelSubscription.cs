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
    /// cancelSubscription
    ///
    /// Cancel a subscription, only ACTIVE subscription can be cancelled. Ensure successfully cancel, recommend at least 1 day before current period ends, otherwise it may be charging or charged.
    /// Set immediate true, the subscription will be terminated immediately, otherwise till the end of current billing cycle.
    /// Set force true, will ignore the error if subscription is during recurring charging.
    /// Other detail info:
    /// 
    ///   * Returns : cancelled subscription
    /// </summary>
    public class CancelSubscription : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CancelSubscriptionBuilder Builder { get => new CancelSubscriptionBuilder(); }

        public class CancelSubscriptionBuilder
            : OperationBuilder<CancelSubscriptionBuilder>
        {

            public bool? Force { get; set; }





            internal CancelSubscriptionBuilder() { }

            internal CancelSubscriptionBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public CancelSubscriptionBuilder SetForce(bool _force)
            {
                Force = _force;
                return this;
            }





            public CancelSubscription Build(
                CancelRequest body,
                string namespace_,
                string subscriptionId,
                string userId
            )
            {
                CancelSubscription op = new CancelSubscription(this,
                    body,
                    namespace_,
                    subscriptionId,
                    userId
                );

                op.SetBaseFields<CancelSubscriptionBuilder>(this);
                return op;
            }

            public Model.SubscriptionInfo? Execute(
                CancelRequest body,
                string namespace_,
                string subscriptionId,
                string userId
            )
            {
                CancelSubscription op = Build(
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
            public async Task<Model.SubscriptionInfo?> ExecuteAsync(
                CancelRequest body,
                string namespace_,
                string subscriptionId,
                string userId
            )
            {
                CancelSubscription op = Build(
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

        private CancelSubscription(CancelSubscriptionBuilder builder,
            CancelRequest body,
            string namespace_,
            string subscriptionId,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["subscriptionId"] = subscriptionId;
            PathParams["userId"] = userId;

            if (builder.Force != null) QueryParams["force"] = Convert.ToString(builder.Force)!;




            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CancelSubscription(
            string namespace_,
            string subscriptionId,
            string userId,
            bool? force,
            Model.CancelRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["subscriptionId"] = subscriptionId;
            PathParams["userId"] = userId;

            if (force != null) QueryParams["force"] = Convert.ToString(force)!;




            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/subscriptions/{subscriptionId}/cancel";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.SubscriptionInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.SubscriptionInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.SubscriptionInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}