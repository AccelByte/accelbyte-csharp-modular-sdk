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

using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Api.Basic.Operation;

namespace AccelByte.Sdk.Api.Basic.Wrapper
{
    public class Namespace
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public Namespace(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public Namespace(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        public GetNamespaces.GetNamespacesBuilder GetNamespacesOp
        {
            get
            {
                var opBuilder = new Operation.GetNamespaces.GetNamespacesBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public CreateNamespace.CreateNamespaceBuilder CreateNamespaceOp
        {
            get
            {
                var opBuilder = new Operation.CreateNamespace.CreateNamespaceBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetNamespace.GetNamespaceBuilder GetNamespaceOp
        {
            get
            {
                var opBuilder = new Operation.GetNamespace.GetNamespaceBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public DeleteNamespace.DeleteNamespaceBuilder DeleteNamespaceOp
        {
            get
            {
                var opBuilder = new Operation.DeleteNamespace.DeleteNamespaceBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public UpdateNamespace.UpdateNamespaceBuilder UpdateNamespaceOp
        {
            get
            {
                var opBuilder = new Operation.UpdateNamespace.UpdateNamespaceBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetChildNamespaces.GetChildNamespacesBuilder GetChildNamespacesOp
        {
            get
            {
                var opBuilder = new Operation.GetChildNamespaces.GetChildNamespacesBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetNamespaceContext.GetNamespaceContextBuilder GetNamespaceContextOp
        {
            get
            {
                var opBuilder = new Operation.GetNamespaceContext.GetNamespaceContextBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetGameNamespaces.GetGameNamespacesBuilder GetGameNamespacesOp
        {
            get
            {
                var opBuilder = new Operation.GetGameNamespaces.GetGameNamespacesBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetNamespacePublisher.GetNamespacePublisherBuilder GetNamespacePublisherOp
        {
            get
            {
                var opBuilder = new Operation.GetNamespacePublisher.GetNamespacePublisherBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public ChangeNamespaceStatus.ChangeNamespaceStatusBuilder ChangeNamespaceStatusOp
        {
            get
            {
                var opBuilder = new Operation.ChangeNamespaceStatus.ChangeNamespaceStatusBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PublicGetNamespaces.PublicGetNamespacesBuilder PublicGetNamespacesOp
        {
            get
            {
                var opBuilder = new Operation.PublicGetNamespaces.PublicGetNamespacesBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetNamespace1.GetNamespace1Builder GetNamespace1Op
        {
            get
            {
                var opBuilder = new Operation.GetNamespace1.GetNamespace1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PublicGetNamespacePublisher.PublicGetNamespacePublisherBuilder PublicGetNamespacePublisherOp
        {
            get
            {
                var opBuilder = new Operation.PublicGetNamespacePublisher.PublicGetNamespacePublisherBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

        public GetNamespaces.Response GetNamespaces(GetNamespaces input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetNamespaces.Response> GetNamespacesAsync(GetNamespaces input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public CreateNamespace.Response CreateNamespace(CreateNamespace input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<CreateNamespace.Response> CreateNamespaceAsync(CreateNamespace input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public GetNamespace.Response GetNamespace(GetNamespace input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetNamespace.Response> GetNamespaceAsync(GetNamespace input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public DeleteNamespace.Response DeleteNamespace(DeleteNamespace input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<DeleteNamespace.Response> DeleteNamespaceAsync(DeleteNamespace input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public UpdateNamespace.Response UpdateNamespace(UpdateNamespace input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<UpdateNamespace.Response> UpdateNamespaceAsync(UpdateNamespace input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public GetChildNamespaces.Response GetChildNamespaces(GetChildNamespaces input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetChildNamespaces.Response> GetChildNamespacesAsync(GetChildNamespaces input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public GetNamespaceContext.Response GetNamespaceContext(GetNamespaceContext input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetNamespaceContext.Response> GetNamespaceContextAsync(GetNamespaceContext input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public GetGameNamespaces.Response GetGameNamespaces(GetGameNamespaces input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetGameNamespaces.Response> GetGameNamespacesAsync(GetGameNamespaces input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public GetNamespacePublisher.Response GetNamespacePublisher(GetNamespacePublisher input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetNamespacePublisher.Response> GetNamespacePublisherAsync(GetNamespacePublisher input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public ChangeNamespaceStatus.Response ChangeNamespaceStatus(ChangeNamespaceStatus input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<ChangeNamespaceStatus.Response> ChangeNamespaceStatusAsync(ChangeNamespaceStatus input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public PublicGetNamespaces.Response PublicGetNamespaces(PublicGetNamespaces input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicGetNamespaces.Response> PublicGetNamespacesAsync(PublicGetNamespaces input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public GetNamespace1.Response GetNamespace1(GetNamespace1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetNamespace1.Response> GetNamespace1Async(GetNamespace1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public PublicGetNamespacePublisher.Response PublicGetNamespacePublisher(PublicGetNamespacePublisher input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicGetNamespacePublisher.Response> PublicGetNamespacePublisherAsync(PublicGetNamespacePublisher input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}