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

using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Api.Ugc.Operation;

namespace AccelByte.Sdk.Api.Ugc.Wrapper
{
    public class AdminChannel
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public AdminChannel(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public AdminChannel(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        public SingleAdminGetChannel.SingleAdminGetChannelBuilder SingleAdminGetChannelOp
        {
            get
            {
                var opBuilder = new Operation.SingleAdminGetChannel.SingleAdminGetChannelBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminCreateChannel.AdminCreateChannelBuilder AdminCreateChannelOp
        {
            get
            {
                var opBuilder = new Operation.AdminCreateChannel.AdminCreateChannelBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public SingleAdminUpdateChannel.SingleAdminUpdateChannelBuilder SingleAdminUpdateChannelOp
        {
            get
            {
                var opBuilder = new Operation.SingleAdminUpdateChannel.SingleAdminUpdateChannelBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public SingleAdminDeleteChannel.SingleAdminDeleteChannelBuilder SingleAdminDeleteChannelOp
        {
            get
            {
                var opBuilder = new Operation.SingleAdminDeleteChannel.SingleAdminDeleteChannelBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminGetChannel.AdminGetChannelBuilder AdminGetChannelOp
        {
            get
            {
                var opBuilder = new Operation.AdminGetChannel.AdminGetChannelBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminUpdateChannel.AdminUpdateChannelBuilder AdminUpdateChannelOp
        {
            get
            {
                var opBuilder = new Operation.AdminUpdateChannel.AdminUpdateChannelBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminDeleteChannel.AdminDeleteChannelBuilder AdminDeleteChannelOp
        {
            get
            {
                var opBuilder = new Operation.AdminDeleteChannel.AdminDeleteChannelBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

        public SingleAdminGetChannel.Response SingleAdminGetChannel(SingleAdminGetChannel input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<SingleAdminGetChannel.Response> SingleAdminGetChannelAsync(SingleAdminGetChannel input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminCreateChannel.Response AdminCreateChannel(AdminCreateChannel input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminCreateChannel.Response> AdminCreateChannelAsync(AdminCreateChannel input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public SingleAdminUpdateChannel.Response SingleAdminUpdateChannel(SingleAdminUpdateChannel input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<SingleAdminUpdateChannel.Response> SingleAdminUpdateChannelAsync(SingleAdminUpdateChannel input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public SingleAdminDeleteChannel.Response SingleAdminDeleteChannel(SingleAdminDeleteChannel input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<SingleAdminDeleteChannel.Response> SingleAdminDeleteChannelAsync(SingleAdminDeleteChannel input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminGetChannel.Response AdminGetChannel(AdminGetChannel input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminGetChannel.Response> AdminGetChannelAsync(AdminGetChannel input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminUpdateChannel.Response AdminUpdateChannel(AdminUpdateChannel input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminUpdateChannel.Response> AdminUpdateChannelAsync(AdminUpdateChannel input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminDeleteChannel.Response AdminDeleteChannel(AdminDeleteChannel input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminDeleteChannel.Response> AdminDeleteChannelAsync(AdminDeleteChannel input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}