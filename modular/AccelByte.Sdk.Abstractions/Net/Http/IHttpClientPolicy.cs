// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;

namespace AccelByte.Sdk.Core.Net.Http
{
    public interface IHttpClientPolicy
    {
        /// <summary>
        /// Flag to enable or disable retry on exception.
        /// </summary>
        bool? RetryOnException { get; }

        /// <summary>
        /// No. of retry before it considered failed.
        /// </summary>
        int? MaxRetryCount { get; }

        /// <summary>
        /// Interval between retry, in milliseconds.
        /// </summary>
        int? RetryInterval { get; }

        /// <summary>
        /// Retry interval growth type. Linear or exponential.
        /// For linear type, interval time between retry is specified by RetryInterval.
        /// For Exponential type, interval time betwen retry is calculated from RetryInterval multiplied by the number of retries.
        /// </summary>
        RetryIntervalType? IntervalType { get; }

        /// <summary>
        /// Set request timeout in seconds
        /// </summary>
        int? RequestTimeOut { get; }

        /// <summary>
        /// Add the number of retry into request header with name X-Client-Retry-Count
        /// First request contains 0
        /// </summary>
        bool? AddRetryCountToHeaders { get; }

        /// <summary>
        /// Set a retry logic handler object for this policy.
        /// </summary>
        IRetryLogicHandler? RetryLogicHandler { get; }

        /// <summary>
        /// Merge current policy with other policy specified in parameter.
        /// Each value will be merge if the value in other policy is not null, and different from current policy.
        /// Returns a new policy with combined value from both policies.
        /// </summary>
        /// <param name="policy">The other policy</param>
        /// <returns>New policy</returns>
        IHttpClientPolicy MergeWith(IHttpClientPolicy policy);
    }
}
