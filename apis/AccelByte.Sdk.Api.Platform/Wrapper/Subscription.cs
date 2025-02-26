// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;

namespace AccelByte.Sdk.Api.Platform.Wrapper
{
    public class Subscription
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public Subscription(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public Subscription(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        public QuerySubscriptions.QuerySubscriptionsBuilder QuerySubscriptionsOp
        {
            get
            {
                var opBuilder = new Operation.QuerySubscriptions.QuerySubscriptionsBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public RecurringChargeSubscription.RecurringChargeSubscriptionBuilder RecurringChargeSubscriptionOp
        {
            get
            {
                var opBuilder = new Operation.RecurringChargeSubscription.RecurringChargeSubscriptionBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public QueryUserSubscriptions.QueryUserSubscriptionsBuilder QueryUserSubscriptionsOp
        {
            get
            {
                var opBuilder = new Operation.QueryUserSubscriptions.QueryUserSubscriptionsBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetUserSubscriptionActivities.GetUserSubscriptionActivitiesBuilder GetUserSubscriptionActivitiesOp
        {
            get
            {
                var opBuilder = new Operation.GetUserSubscriptionActivities.GetUserSubscriptionActivitiesBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PlatformSubscribeSubscription.PlatformSubscribeSubscriptionBuilder PlatformSubscribeSubscriptionOp
        {
            get
            {
                var opBuilder = new Operation.PlatformSubscribeSubscription.PlatformSubscribeSubscriptionBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public CheckUserSubscriptionSubscribableByItemId.CheckUserSubscriptionSubscribableByItemIdBuilder CheckUserSubscriptionSubscribableByItemIdOp
        {
            get
            {
                var opBuilder = new Operation.CheckUserSubscriptionSubscribableByItemId.CheckUserSubscriptionSubscribableByItemIdBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetUserSubscription.GetUserSubscriptionBuilder GetUserSubscriptionOp
        {
            get
            {
                var opBuilder = new Operation.GetUserSubscription.GetUserSubscriptionBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public DeleteUserSubscription.DeleteUserSubscriptionBuilder DeleteUserSubscriptionOp
        {
            get
            {
                var opBuilder = new Operation.DeleteUserSubscription.DeleteUserSubscriptionBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public CancelSubscription.CancelSubscriptionBuilder CancelSubscriptionOp
        {
            get
            {
                var opBuilder = new Operation.CancelSubscription.CancelSubscriptionBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GrantDaysToSubscription.GrantDaysToSubscriptionBuilder GrantDaysToSubscriptionOp
        {
            get
            {
                var opBuilder = new Operation.GrantDaysToSubscription.GrantDaysToSubscriptionBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetUserSubscriptionBillingHistories.GetUserSubscriptionBillingHistoriesBuilder GetUserSubscriptionBillingHistoriesOp
        {
            get
            {
                var opBuilder = new Operation.GetUserSubscriptionBillingHistories.GetUserSubscriptionBillingHistoriesBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public ProcessUserSubscriptionNotification.ProcessUserSubscriptionNotificationBuilder ProcessUserSubscriptionNotificationOp
        {
            get
            {
                var opBuilder = new Operation.ProcessUserSubscriptionNotification.ProcessUserSubscriptionNotificationBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PublicQueryUserSubscriptions.PublicQueryUserSubscriptionsBuilder PublicQueryUserSubscriptionsOp
        {
            get
            {
                var opBuilder = new Operation.PublicQueryUserSubscriptions.PublicQueryUserSubscriptionsBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PublicSubscribeSubscription.PublicSubscribeSubscriptionBuilder PublicSubscribeSubscriptionOp
        {
            get
            {
                var opBuilder = new Operation.PublicSubscribeSubscription.PublicSubscribeSubscriptionBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PublicCheckUserSubscriptionSubscribableByItemId.PublicCheckUserSubscriptionSubscribableByItemIdBuilder PublicCheckUserSubscriptionSubscribableByItemIdOp
        {
            get
            {
                var opBuilder = new Operation.PublicCheckUserSubscriptionSubscribableByItemId.PublicCheckUserSubscriptionSubscribableByItemIdBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PublicGetUserSubscription.PublicGetUserSubscriptionBuilder PublicGetUserSubscriptionOp
        {
            get
            {
                var opBuilder = new Operation.PublicGetUserSubscription.PublicGetUserSubscriptionBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PublicChangeSubscriptionBillingAccount.PublicChangeSubscriptionBillingAccountBuilder PublicChangeSubscriptionBillingAccountOp
        {
            get
            {
                var opBuilder = new Operation.PublicChangeSubscriptionBillingAccount.PublicChangeSubscriptionBillingAccountBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PublicCancelSubscription.PublicCancelSubscriptionBuilder PublicCancelSubscriptionOp
        {
            get
            {
                var opBuilder = new Operation.PublicCancelSubscription.PublicCancelSubscriptionBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PublicGetUserSubscriptionBillingHistories.PublicGetUserSubscriptionBillingHistoriesBuilder PublicGetUserSubscriptionBillingHistoriesOp
        {
            get
            {
                var opBuilder = new Operation.PublicGetUserSubscriptionBillingHistories.PublicGetUserSubscriptionBillingHistoriesBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

        public QuerySubscriptions.Response QuerySubscriptions(QuerySubscriptions input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<QuerySubscriptions.Response> QuerySubscriptionsAsync(QuerySubscriptions input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public RecurringChargeSubscription.Response RecurringChargeSubscription(RecurringChargeSubscription input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<RecurringChargeSubscription.Response> RecurringChargeSubscriptionAsync(RecurringChargeSubscription input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public QueryUserSubscriptions.Response QueryUserSubscriptions(QueryUserSubscriptions input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<QueryUserSubscriptions.Response> QueryUserSubscriptionsAsync(QueryUserSubscriptions input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public GetUserSubscriptionActivities.Response GetUserSubscriptionActivities(GetUserSubscriptionActivities input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetUserSubscriptionActivities.Response> GetUserSubscriptionActivitiesAsync(GetUserSubscriptionActivities input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public PlatformSubscribeSubscription.Response PlatformSubscribeSubscription(PlatformSubscribeSubscription input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PlatformSubscribeSubscription.Response> PlatformSubscribeSubscriptionAsync(PlatformSubscribeSubscription input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public CheckUserSubscriptionSubscribableByItemId.Response CheckUserSubscriptionSubscribableByItemId(CheckUserSubscriptionSubscribableByItemId input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<CheckUserSubscriptionSubscribableByItemId.Response> CheckUserSubscriptionSubscribableByItemIdAsync(CheckUserSubscriptionSubscribableByItemId input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public GetUserSubscription.Response GetUserSubscription(GetUserSubscription input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetUserSubscription.Response> GetUserSubscriptionAsync(GetUserSubscription input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public DeleteUserSubscription.Response DeleteUserSubscription(DeleteUserSubscription input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<DeleteUserSubscription.Response> DeleteUserSubscriptionAsync(DeleteUserSubscription input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public CancelSubscription.Response CancelSubscription(CancelSubscription input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<CancelSubscription.Response> CancelSubscriptionAsync(CancelSubscription input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public GrantDaysToSubscription.Response GrantDaysToSubscription(GrantDaysToSubscription input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GrantDaysToSubscription.Response> GrantDaysToSubscriptionAsync(GrantDaysToSubscription input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public GetUserSubscriptionBillingHistories.Response GetUserSubscriptionBillingHistories(GetUserSubscriptionBillingHistories input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetUserSubscriptionBillingHistories.Response> GetUserSubscriptionBillingHistoriesAsync(GetUserSubscriptionBillingHistories input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public ProcessUserSubscriptionNotification.Response ProcessUserSubscriptionNotification(ProcessUserSubscriptionNotification input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<ProcessUserSubscriptionNotification.Response> ProcessUserSubscriptionNotificationAsync(ProcessUserSubscriptionNotification input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public PublicQueryUserSubscriptions.Response PublicQueryUserSubscriptions(PublicQueryUserSubscriptions input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicQueryUserSubscriptions.Response> PublicQueryUserSubscriptionsAsync(PublicQueryUserSubscriptions input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public PublicSubscribeSubscription.Response PublicSubscribeSubscription(PublicSubscribeSubscription input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicSubscribeSubscription.Response> PublicSubscribeSubscriptionAsync(PublicSubscribeSubscription input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public PublicCheckUserSubscriptionSubscribableByItemId.Response PublicCheckUserSubscriptionSubscribableByItemId(PublicCheckUserSubscriptionSubscribableByItemId input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicCheckUserSubscriptionSubscribableByItemId.Response> PublicCheckUserSubscriptionSubscribableByItemIdAsync(PublicCheckUserSubscriptionSubscribableByItemId input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public PublicGetUserSubscription.Response PublicGetUserSubscription(PublicGetUserSubscription input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicGetUserSubscription.Response> PublicGetUserSubscriptionAsync(PublicGetUserSubscription input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public PublicChangeSubscriptionBillingAccount.Response PublicChangeSubscriptionBillingAccount(PublicChangeSubscriptionBillingAccount input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicChangeSubscriptionBillingAccount.Response> PublicChangeSubscriptionBillingAccountAsync(PublicChangeSubscriptionBillingAccount input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public PublicCancelSubscription.Response PublicCancelSubscription(PublicCancelSubscription input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicCancelSubscription.Response> PublicCancelSubscriptionAsync(PublicCancelSubscription input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public PublicGetUserSubscriptionBillingHistories.Response PublicGetUserSubscriptionBillingHistories(PublicGetUserSubscriptionBillingHistories input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicGetUserSubscriptionBillingHistories.Response> PublicGetUserSubscriptionBillingHistoriesAsync(PublicGetUserSubscriptionBillingHistories input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}