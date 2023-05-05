// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Platform.Wrapper
{
    public class Subscription
    {
        private readonly AccelByteSDK _sdk;

        public Subscription(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public QuerySubscriptions.QuerySubscriptionsBuilder QuerySubscriptionsOp
        {
            get { return Operation.QuerySubscriptions.Builder.SetWrapperObject(this); }
        }
        public RecurringChargeSubscription.RecurringChargeSubscriptionBuilder RecurringChargeSubscriptionOp
        {
            get { return Operation.RecurringChargeSubscription.Builder.SetWrapperObject(this); }
        }
        public QueryUserSubscriptions.QueryUserSubscriptionsBuilder QueryUserSubscriptionsOp
        {
            get { return Operation.QueryUserSubscriptions.Builder.SetWrapperObject(this); }
        }
        public GetUserSubscriptionActivities.GetUserSubscriptionActivitiesBuilder GetUserSubscriptionActivitiesOp
        {
            get { return Operation.GetUserSubscriptionActivities.Builder.SetWrapperObject(this); }
        }
        public PlatformSubscribeSubscription.PlatformSubscribeSubscriptionBuilder PlatformSubscribeSubscriptionOp
        {
            get { return Operation.PlatformSubscribeSubscription.Builder.SetWrapperObject(this); }
        }
        public CheckUserSubscriptionSubscribableByItemId.CheckUserSubscriptionSubscribableByItemIdBuilder CheckUserSubscriptionSubscribableByItemIdOp
        {
            get { return Operation.CheckUserSubscriptionSubscribableByItemId.Builder.SetWrapperObject(this); }
        }
        public GetUserSubscription.GetUserSubscriptionBuilder GetUserSubscriptionOp
        {
            get { return Operation.GetUserSubscription.Builder.SetWrapperObject(this); }
        }
        public DeleteUserSubscription.DeleteUserSubscriptionBuilder DeleteUserSubscriptionOp
        {
            get { return Operation.DeleteUserSubscription.Builder.SetWrapperObject(this); }
        }
        public CancelSubscription.CancelSubscriptionBuilder CancelSubscriptionOp
        {
            get { return Operation.CancelSubscription.Builder.SetWrapperObject(this); }
        }
        public GrantDaysToSubscription.GrantDaysToSubscriptionBuilder GrantDaysToSubscriptionOp
        {
            get { return Operation.GrantDaysToSubscription.Builder.SetWrapperObject(this); }
        }
        public GetUserSubscriptionBillingHistories.GetUserSubscriptionBillingHistoriesBuilder GetUserSubscriptionBillingHistoriesOp
        {
            get { return Operation.GetUserSubscriptionBillingHistories.Builder.SetWrapperObject(this); }
        }
        public ProcessUserSubscriptionNotification.ProcessUserSubscriptionNotificationBuilder ProcessUserSubscriptionNotificationOp
        {
            get { return Operation.ProcessUserSubscriptionNotification.Builder.SetWrapperObject(this); }
        }
        public PublicQueryUserSubscriptions.PublicQueryUserSubscriptionsBuilder PublicQueryUserSubscriptionsOp
        {
            get { return Operation.PublicQueryUserSubscriptions.Builder.SetWrapperObject(this); }
        }
        public PublicSubscribeSubscription.PublicSubscribeSubscriptionBuilder PublicSubscribeSubscriptionOp
        {
            get { return Operation.PublicSubscribeSubscription.Builder.SetWrapperObject(this); }
        }
        public PublicCheckUserSubscriptionSubscribableByItemId.PublicCheckUserSubscriptionSubscribableByItemIdBuilder PublicCheckUserSubscriptionSubscribableByItemIdOp
        {
            get { return Operation.PublicCheckUserSubscriptionSubscribableByItemId.Builder.SetWrapperObject(this); }
        }
        public PublicGetUserSubscription.PublicGetUserSubscriptionBuilder PublicGetUserSubscriptionOp
        {
            get { return Operation.PublicGetUserSubscription.Builder.SetWrapperObject(this); }
        }
        public PublicChangeSubscriptionBillingAccount.PublicChangeSubscriptionBillingAccountBuilder PublicChangeSubscriptionBillingAccountOp
        {
            get { return Operation.PublicChangeSubscriptionBillingAccount.Builder.SetWrapperObject(this); }
        }
        public PublicCancelSubscription.PublicCancelSubscriptionBuilder PublicCancelSubscriptionOp
        {
            get { return Operation.PublicCancelSubscription.Builder.SetWrapperObject(this); }
        }
        public PublicGetUserSubscriptionBillingHistories.PublicGetUserSubscriptionBillingHistoriesBuilder PublicGetUserSubscriptionBillingHistoriesOp
        {
            get { return Operation.PublicGetUserSubscriptionBillingHistories.Builder.SetWrapperObject(this); }
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
        public Model.RecurringChargeResult? RecurringChargeSubscription(RecurringChargeSubscription input)
        {
            var response = _sdk.RunRequest(input);

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
        public Model.SubscriptionActivityPagingSlicedResult? GetUserSubscriptionActivities(GetUserSubscriptionActivities input)
        {
            var response = _sdk.RunRequest(input);

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
        public Model.Subscribable? CheckUserSubscriptionSubscribableByItemId(CheckUserSubscriptionSubscribableByItemId input)
        {
            var response = _sdk.RunRequest(input);

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
        public void DeleteUserSubscription(DeleteUserSubscription input) {
            var response = _sdk.RunRequest(input);

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
        public Model.SubscriptionInfo? GrantDaysToSubscription(GrantDaysToSubscription input)
        {
            var response = _sdk.RunRequest(input);

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
        public void ProcessUserSubscriptionNotification(ProcessUserSubscriptionNotification input) {
            var response = _sdk.RunRequest(input);

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
        public void PublicSubscribeSubscription(PublicSubscribeSubscription input) {
            var response = _sdk.RunRequest(input);

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
        public Model.SubscriptionInfo? PublicGetUserSubscription(PublicGetUserSubscription input)
        {
            var response = _sdk.RunRequest(input);

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
        public Model.SubscriptionInfo? PublicCancelSubscription(PublicCancelSubscription input)
        {
            var response = _sdk.RunRequest(input);

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
    }
}