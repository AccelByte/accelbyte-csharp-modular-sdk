// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace AccelByte.Sdk.Core.Net.Http
{
    public class DefaultRetryLogicHandler : IRetryLogicHandler
    {
        public bool ExecuteRetryLogic(IHttpClientPolicy policy, int retryCount, Exception exception)
        {
            if (!policy.RetryOnException!.Value)
                return false;

            if (retryCount >= policy.MaxRetryCount)
                return false;

            if (policy.IntervalType == RetryIntervalType.Linear)
                Thread.Sleep(policy.RetryInterval!.Value);
            else if (policy.IntervalType == RetryIntervalType.Exponential)
            {
                int nextDelay = (policy.RetryInterval!.Value * retryCount);
                Thread.Sleep(nextDelay);
            }

            return true;
        }
    }
}
