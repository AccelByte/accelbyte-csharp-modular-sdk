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

        public Model.SubscriptionPagingSlicedResult? QuerySubscriptions(QuerySubscriptions input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.SubscriptionPagingSlicedResult?> QuerySubscriptionsAsync(QuerySubscriptions input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.RecurringChargeResult? RecurringChargeSubscription(RecurringChargeSubscription input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.RecurringChargeResult?> RecurringChargeSubscriptionAsync(RecurringChargeSubscription input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.SubscriptionPagingSlicedResult? QueryUserSubscriptions(QueryUserSubscriptions input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.SubscriptionPagingSlicedResult?> QueryUserSubscriptionsAsync(QueryUserSubscriptions input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.SubscriptionActivityPagingSlicedResult? GetUserSubscriptionActivities(GetUserSubscriptionActivities input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.SubscriptionActivityPagingSlicedResult?> GetUserSubscriptionActivitiesAsync(GetUserSubscriptionActivities input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.SubscriptionInfo? PlatformSubscribeSubscription(PlatformSubscribeSubscription input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.SubscriptionInfo?> PlatformSubscribeSubscriptionAsync(PlatformSubscribeSubscription input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.Subscribable? CheckUserSubscriptionSubscribableByItemId(CheckUserSubscriptionSubscribableByItemId input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.Subscribable?> CheckUserSubscriptionSubscribableByItemIdAsync(CheckUserSubscriptionSubscribableByItemId input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.SubscriptionInfo? GetUserSubscription(GetUserSubscription input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.SubscriptionInfo?> GetUserSubscriptionAsync(GetUserSubscription input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteUserSubscription(DeleteUserSubscription input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task DeleteUserSubscriptionAsync(DeleteUserSubscription input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.SubscriptionInfo? CancelSubscription(CancelSubscription input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.SubscriptionInfo?> CancelSubscriptionAsync(CancelSubscription input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.SubscriptionInfo? GrantDaysToSubscription(GrantDaysToSubscription input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.SubscriptionInfo?> GrantDaysToSubscriptionAsync(GrantDaysToSubscription input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.BillingHistoryPagingSlicedResult? GetUserSubscriptionBillingHistories(GetUserSubscriptionBillingHistories input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.BillingHistoryPagingSlicedResult?> GetUserSubscriptionBillingHistoriesAsync(GetUserSubscriptionBillingHistories input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void ProcessUserSubscriptionNotification(ProcessUserSubscriptionNotification input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task ProcessUserSubscriptionNotificationAsync(ProcessUserSubscriptionNotification input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.SubscriptionPagingSlicedResult? PublicQueryUserSubscriptions(PublicQueryUserSubscriptions input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.SubscriptionPagingSlicedResult?> PublicQueryUserSubscriptionsAsync(PublicQueryUserSubscriptions input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void PublicSubscribeSubscription(PublicSubscribeSubscription input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task PublicSubscribeSubscriptionAsync(PublicSubscribeSubscription input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.Subscribable? PublicCheckUserSubscriptionSubscribableByItemId(PublicCheckUserSubscriptionSubscribableByItemId input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.Subscribable?> PublicCheckUserSubscriptionSubscribableByItemIdAsync(PublicCheckUserSubscriptionSubscribableByItemId input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.SubscriptionInfo? PublicGetUserSubscription(PublicGetUserSubscription input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.SubscriptionInfo?> PublicGetUserSubscriptionAsync(PublicGetUserSubscription input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.SubscriptionInfo? PublicChangeSubscriptionBillingAccount(PublicChangeSubscriptionBillingAccount input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.SubscriptionInfo?> PublicChangeSubscriptionBillingAccountAsync(PublicChangeSubscriptionBillingAccount input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.SubscriptionInfo? PublicCancelSubscription(PublicCancelSubscription input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.SubscriptionInfo?> PublicCancelSubscriptionAsync(PublicCancelSubscription input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.BillingHistoryPagingSlicedResult? PublicGetUserSubscriptionBillingHistories(PublicGetUserSubscriptionBillingHistories input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.BillingHistoryPagingSlicedResult?> PublicGetUserSubscriptionBillingHistoriesAsync(PublicGetUserSubscriptionBillingHistories input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}