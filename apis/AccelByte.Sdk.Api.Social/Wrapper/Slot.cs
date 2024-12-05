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

using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Api.Social.Operation;

namespace AccelByte.Sdk.Api.Social.Wrapper
{
    public class Slot
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public Slot(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public Slot(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public GetUserNamespaceSlots.GetUserNamespaceSlotsBuilder GetUserNamespaceSlotsOp
        {
            get
            {
                var opBuilder = new Operation.GetUserNamespaceSlots.GetUserNamespaceSlotsBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public GetSlotData.GetSlotDataBuilder GetSlotDataOp
        {
            get
            {
                var opBuilder = new Operation.GetSlotData.GetSlotDataBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public PublicGetUserNamespaceSlots.PublicGetUserNamespaceSlotsBuilder PublicGetUserNamespaceSlotsOp
        {
            get
            {
                var opBuilder = new Operation.PublicGetUserNamespaceSlots.PublicGetUserNamespaceSlotsBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public PublicCreateUserNamespaceSlot.PublicCreateUserNamespaceSlotBuilder PublicCreateUserNamespaceSlotOp
        {
            get
            {
                var opBuilder = new Operation.PublicCreateUserNamespaceSlot.PublicCreateUserNamespaceSlotBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public PublicGetSlotData.PublicGetSlotDataBuilder PublicGetSlotDataOp
        {
            get
            {
                var opBuilder = new Operation.PublicGetSlotData.PublicGetSlotDataBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public PublicUpdateUserNamespaceSlot.PublicUpdateUserNamespaceSlotBuilder PublicUpdateUserNamespaceSlotOp
        {
            get
            {
                var opBuilder = new Operation.PublicUpdateUserNamespaceSlot.PublicUpdateUserNamespaceSlotBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public PublicDeleteUserNamespaceSlot.PublicDeleteUserNamespaceSlotBuilder PublicDeleteUserNamespaceSlotOp
        {
            get
            {
                var opBuilder = new Operation.PublicDeleteUserNamespaceSlot.PublicDeleteUserNamespaceSlotBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public PublicUpdateUserNamespaceSlotMetadata.PublicUpdateUserNamespaceSlotMetadataBuilder PublicUpdateUserNamespaceSlotMetadataOp
        {
            get
            {
                var opBuilder = new Operation.PublicUpdateUserNamespaceSlotMetadata.PublicUpdateUserNamespaceSlotMetadataBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public GetUserNamespaceSlots.Response GetUserNamespaceSlots(GetUserNamespaceSlots input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetUserNamespaceSlots.Response> GetUserNamespaceSlotsAsync(GetUserNamespaceSlots input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public GetSlotData.Response GetSlotData(GetSlotData input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetSlotData.Response> GetSlotDataAsync(GetSlotData input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public PublicGetUserNamespaceSlots.Response PublicGetUserNamespaceSlots(PublicGetUserNamespaceSlots input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicGetUserNamespaceSlots.Response> PublicGetUserNamespaceSlotsAsync(PublicGetUserNamespaceSlots input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public PublicCreateUserNamespaceSlot.Response PublicCreateUserNamespaceSlot(PublicCreateUserNamespaceSlot input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicCreateUserNamespaceSlot.Response> PublicCreateUserNamespaceSlotAsync(PublicCreateUserNamespaceSlot input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public PublicGetSlotData.Response PublicGetSlotData(PublicGetSlotData input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicGetSlotData.Response> PublicGetSlotDataAsync(PublicGetSlotData input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public PublicUpdateUserNamespaceSlot.Response PublicUpdateUserNamespaceSlot(PublicUpdateUserNamespaceSlot input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicUpdateUserNamespaceSlot.Response> PublicUpdateUserNamespaceSlotAsync(PublicUpdateUserNamespaceSlot input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public PublicDeleteUserNamespaceSlot.Response PublicDeleteUserNamespaceSlot(PublicDeleteUserNamespaceSlot input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicDeleteUserNamespaceSlot.Response> PublicDeleteUserNamespaceSlotAsync(PublicDeleteUserNamespaceSlot input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public PublicUpdateUserNamespaceSlotMetadata.Response PublicUpdateUserNamespaceSlotMetadata(PublicUpdateUserNamespaceSlotMetadata input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicUpdateUserNamespaceSlotMetadata.Response> PublicUpdateUserNamespaceSlotMetadataAsync(PublicUpdateUserNamespaceSlotMetadata input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
    }
}