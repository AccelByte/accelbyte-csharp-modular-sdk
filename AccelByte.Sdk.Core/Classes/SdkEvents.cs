// Copyright (c) 2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccelByte.Sdk.Core
{
    public class SdkEvents : ISdkEvents
    {
        private Dictionary<string, object> _Events = new();

        public void RegisterEvent(string key, object eventAction)
        {
            if (_Events.ContainsKey(key))
                _Events[key] = eventAction;
            else
                _Events.Add(key, eventAction);
        }

        public T? GetEventAs<T>(string key)
        {
            if (!_Events.ContainsKey(key))
                return default;

            object eventAction = _Events[key];
            if (eventAction is T)
                return (T)eventAction;
            else
                throw new Exception($"Event object is not {typeof(T).FullName}");
        }
    }
}
