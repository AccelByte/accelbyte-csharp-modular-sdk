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

        public Slot(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public GetUserNamespaceSlots.GetUserNamespaceSlotsBuilder GetUserNamespaceSlotsOp
        {
            get { return new Operation.GetUserNamespaceSlots.GetUserNamespaceSlotsBuilder(_sdk); }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public GetSlotData.GetSlotDataBuilder GetSlotDataOp
        {
            get { return new Operation.GetSlotData.GetSlotDataBuilder(_sdk); }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public PublicGetUserNamespaceSlots.PublicGetUserNamespaceSlotsBuilder PublicGetUserNamespaceSlotsOp
        {
            get { return new Operation.PublicGetUserNamespaceSlots.PublicGetUserNamespaceSlotsBuilder(_sdk); }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public PublicCreateUserNamespaceSlot.PublicCreateUserNamespaceSlotBuilder PublicCreateUserNamespaceSlotOp
        {
            get { return new Operation.PublicCreateUserNamespaceSlot.PublicCreateUserNamespaceSlotBuilder(_sdk); }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public PublicGetSlotData.PublicGetSlotDataBuilder PublicGetSlotDataOp
        {
            get { return new Operation.PublicGetSlotData.PublicGetSlotDataBuilder(_sdk); }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public PublicUpdateUserNamespaceSlot.PublicUpdateUserNamespaceSlotBuilder PublicUpdateUserNamespaceSlotOp
        {
            get { return new Operation.PublicUpdateUserNamespaceSlot.PublicUpdateUserNamespaceSlotBuilder(_sdk); }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public PublicDeleteUserNamespaceSlot.PublicDeleteUserNamespaceSlotBuilder PublicDeleteUserNamespaceSlotOp
        {
            get { return new Operation.PublicDeleteUserNamespaceSlot.PublicDeleteUserNamespaceSlotBuilder(_sdk); }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public PublicUpdateUserNamespaceSlotMetadata.PublicUpdateUserNamespaceSlotMetadataBuilder PublicUpdateUserNamespaceSlotMetadataOp
        {
            get { return new Operation.PublicUpdateUserNamespaceSlotMetadata.PublicUpdateUserNamespaceSlotMetadataBuilder(_sdk); }
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