// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Text.Json;

namespace AccelByte.Sdk.Core
{
    public abstract class OperationBuilder<T> where T : OperationBuilder<T>
    {
        protected IAccelByteSdk? _Sdk = null;

        public JsonSerializerOptions? RequestJsonOptions { get; protected set; } = null;

        public JsonSerializerOptions? ResponseJsonOptions { get; protected set; } = null;

        internal object? WrapperObject { get; set; } = null;

        public string PreferredSecurityMethod { get; protected set; } = String.Empty;

        public string FlightId { get; protected set; } = String.Empty;

        public string CustomBasePath { get; protected set; } = String.Empty;

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

        public T UpdateFlightId(string flightId)
        {
            FlightId = flightId;
            return (T)this;
        }

        public T UseCustomBasePath(string value)
        {
            CustomBasePath = value;
            return (T)this;
        }

        internal T SetWrapperObject(object wrapperObject)
        {
            WrapperObject = wrapperObject;
            return (T)this;
        }
    }
}