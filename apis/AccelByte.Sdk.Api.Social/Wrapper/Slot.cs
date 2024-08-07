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
        public List<Model.SlotInfo>? GetUserNamespaceSlots(GetUserNamespaceSlots input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<List<Model.SlotInfo>?> GetUserNamespaceSlotsAsync(GetUserNamespaceSlots input)
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
        public byte[]? GetSlotData(GetSlotData input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<byte[]?> GetSlotDataAsync(GetSlotData input)
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
        public List<Model.SlotInfo>? PublicGetUserNamespaceSlots(PublicGetUserNamespaceSlots input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<List<Model.SlotInfo>?> PublicGetUserNamespaceSlotsAsync(PublicGetUserNamespaceSlots input)
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
        public void PublicCreateUserNamespaceSlot(PublicCreateUserNamespaceSlot input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task PublicCreateUserNamespaceSlotAsync(PublicCreateUserNamespaceSlot input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public byte[]? PublicGetSlotData(PublicGetSlotData input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<byte[]?> PublicGetSlotDataAsync(PublicGetSlotData input)
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
        public Model.SlotInfo? PublicUpdateUserNamespaceSlot(PublicUpdateUserNamespaceSlot input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.SlotInfo?> PublicUpdateUserNamespaceSlotAsync(PublicUpdateUserNamespaceSlot input)
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
        public void PublicDeleteUserNamespaceSlot(PublicDeleteUserNamespaceSlot input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task PublicDeleteUserNamespaceSlotAsync(PublicDeleteUserNamespaceSlot input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public Model.SlotInfo? PublicUpdateUserNamespaceSlotMetadata(PublicUpdateUserNamespaceSlotMetadata input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.SlotInfo?> PublicUpdateUserNamespaceSlotMetadataAsync(PublicUpdateUserNamespaceSlotMetadata input)
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