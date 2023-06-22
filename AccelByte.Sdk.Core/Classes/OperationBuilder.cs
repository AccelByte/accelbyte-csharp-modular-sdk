// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Text.Json;

namespace AccelByte.Sdk.Core
{
    public abstract class OperationBuilder<T> where T : OperationBuilder<T>
    {
        protected IAccelByteSdk? _Sdk = null;

        protected JsonSerializerOptions? RequestJsonOptions { get; set; } = null;

        protected JsonSerializerOptions? ResponseJsonOptions { get; set; } = null;

        internal object? WrapperObject { get; set; } = null;

        protected string PreferredSecurityMethod { get; set; } = String.Empty;

        public T SetPreferredSecurityMethod(string securityMethod)
        {
            PreferredSecurityMethod = securityMethod;
            return (T)this;
        }

        public T SetRequestJsonOptions(JsonSerializerOptions options)
        {
            RequestJsonOptions = options;
            return (T)this;
        }

        public T SetResponseJsonOptions(JsonSerializerOptions options)
        {
            ResponseJsonOptions = options;
            return (T)this;
        }

        public T SetJsonOptions(JsonSerializerOptions options)
        {
            RequestJsonOptions = options;
            ResponseJsonOptions = options;
            return (T)this;
        }

        internal T SetWrapperObject(object wrapperObject)
        {
            WrapperObject = wrapperObject;
            return (T)this;
        }
    }
}