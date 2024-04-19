// Copyright (c) 2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Chat;

namespace AccelByte.Sdk.Api.Chat
{
    public class ChatApi : ISdkApi
    {
        private IAccelByteSdk _Sdk;

        private string _CustomBasePath = String.Empty;

        public Wrapper.Topic Topic
        {
            get
            {
                if (_Topic == null)
                    _Topic = new Wrapper.Topic(_Sdk, _CustomBasePath);
                return _Topic;
            }
        }
        private Wrapper.Topic? _Topic = null;

        public Wrapper.Config Config
        {
            get
            {
                if (_Config == null)
                    _Config = new Wrapper.Config(_Sdk, _CustomBasePath);
                return _Config;
            }
        }
        private Wrapper.Config? _Config = null;

        public Wrapper.Inbox Inbox
        {
            get
            {
                if (_Inbox == null)
                    _Inbox = new Wrapper.Inbox(_Sdk, _CustomBasePath);
                return _Inbox;
            }
        }
        private Wrapper.Inbox? _Inbox = null;

        public Wrapper.Moderation Moderation
        {
            get
            {
                if (_Moderation == null)
                    _Moderation = new Wrapper.Moderation(_Sdk, _CustomBasePath);
                return _Moderation;
            }
        }
        private Wrapper.Moderation? _Moderation = null;

        public Wrapper.Profanity Profanity
        {
            get
            {
                if (_Profanity == null)
                    _Profanity = new Wrapper.Profanity(_Sdk, _CustomBasePath);
                return _Profanity;
            }
        }
        private Wrapper.Profanity? _Profanity = null;

        public Wrapper.Operations Operations
        {
            get
            {
                if (_Operations == null)
                    _Operations = new Wrapper.Operations(_Sdk, _CustomBasePath);
                return _Operations;
            }
        }
        private Wrapper.Operations? _Operations = null;

        internal ChatApi(IAccelByteSdk sdk)
        {
            _Sdk = sdk;
        }

        public ChatApi WithCustomBasePath(string value)
        {
            _CustomBasePath = value;
            return this;
        }
    }
}

namespace AccelByte.Sdk.Api
{
    public static class ChatApi_SdkExts
    {
        public static ChatApi GetChatApi(this IAccelByteSdk sdk)
        {
            return sdk.GetApi<ChatApi>("chat", () =>
            {
                string customPath = sdk.Configuration.ConfigRepository.GetCustomServiceBasePath("chat");
                if (customPath != "")
                    return (new ChatApi(sdk)).WithCustomBasePath(customPath);
                else
                    return new ChatApi(sdk);
            });
        }
    }
}