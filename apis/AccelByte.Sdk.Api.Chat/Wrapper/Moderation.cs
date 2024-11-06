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

using AccelByte.Sdk.Api.Chat.Model;
using AccelByte.Sdk.Api.Chat.Operation;

namespace AccelByte.Sdk.Api.Chat.Wrapper
{
    public class Moderation
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public Moderation(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public Moderation(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        public AdminGetChatSnapshot.AdminGetChatSnapshotBuilder AdminGetChatSnapshotOp
        {
            get
            {
                var opBuilder = new Operation.AdminGetChatSnapshot.AdminGetChatSnapshotBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminDeleteChatSnapshot.AdminDeleteChatSnapshotBuilder AdminDeleteChatSnapshotOp
        {
            get
            {
                var opBuilder = new Operation.AdminDeleteChatSnapshot.AdminDeleteChatSnapshotBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PublicGetChatSnapshot.PublicGetChatSnapshotBuilder PublicGetChatSnapshotOp
        {
            get
            {
                var opBuilder = new Operation.PublicGetChatSnapshot.PublicGetChatSnapshotBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

        public AdminGetChatSnapshot.Response AdminGetChatSnapshot(AdminGetChatSnapshot input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminGetChatSnapshot.Response> AdminGetChatSnapshotAsync(AdminGetChatSnapshot input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminDeleteChatSnapshot.Response AdminDeleteChatSnapshot(AdminDeleteChatSnapshot input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminDeleteChatSnapshot.Response> AdminDeleteChatSnapshotAsync(AdminDeleteChatSnapshot input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public PublicGetChatSnapshot.Response PublicGetChatSnapshot(PublicGetChatSnapshot input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicGetChatSnapshot.Response> PublicGetChatSnapshotAsync(PublicGetChatSnapshot input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}