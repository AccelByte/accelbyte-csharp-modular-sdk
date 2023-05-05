// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccelByte.Sdk.Core.Net.Http
{
    public class HttpRequestTimeoutException : Exception
    {
        public HttpRequestTimeoutException(Exception inner)
            : base("Request timeout", inner)
        {

        }
    }
}