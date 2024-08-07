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

using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;

namespace AccelByte.Sdk.Api.Platform.Wrapper
{
    public class DLC
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public DLC(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public DLC(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        public GetDLCItemConfig.GetDLCItemConfigBuilder GetDLCItemConfigOp
        {
            get
            {
                var opBuilder = new Operation.GetDLCItemConfig.GetDLCItemConfigBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public UpdateDLCItemConfig.UpdateDLCItemConfigBuilder UpdateDLCItemConfigOp
        {
            get
            {
                var opBuilder = new Operation.UpdateDLCItemConfig.UpdateDLCItemConfigBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public DeleteDLCItemConfig.DeleteDLCItemConfigBuilder DeleteDLCItemConfigOp
        {
            get
            {
                var opBuilder = new Operation.DeleteDLCItemConfig.DeleteDLCItemConfigBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetPlatformDLCConfig.GetPlatformDLCConfigBuilder GetPlatformDLCConfigOp
        {
            get
            {
                var opBuilder = new Operation.GetPlatformDLCConfig.GetPlatformDLCConfigBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public UpdatePlatformDLCConfig.UpdatePlatformDLCConfigBuilder UpdatePlatformDLCConfigOp
        {
            get
            {
                var opBuilder = new Operation.UpdatePlatformDLCConfig.UpdatePlatformDLCConfigBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public DeletePlatformDLCConfig.DeletePlatformDLCConfigBuilder DeletePlatformDLCConfigOp
        {
            get
            {
                var opBuilder = new Operation.DeletePlatformDLCConfig.DeletePlatformDLCConfigBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetUserDLCByPlatform.GetUserDLCByPlatformBuilder GetUserDLCByPlatformOp
        {
            get
            {
                var opBuilder = new Operation.GetUserDLCByPlatform.GetUserDLCByPlatformBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetUserDLC.GetUserDLCBuilder GetUserDLCOp
        {
            get
            {
                var opBuilder = new Operation.GetUserDLC.GetUserDLCBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GeDLCDurableRewardShortMap.GeDLCDurableRewardShortMapBuilder GeDLCDurableRewardShortMapOp
        {
            get
            {
                var opBuilder = new Operation.GeDLCDurableRewardShortMap.GeDLCDurableRewardShortMapBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public SyncEpicGameDLC.SyncEpicGameDLCBuilder SyncEpicGameDLCOp
        {
            get
            {
                var opBuilder = new Operation.SyncEpicGameDLC.SyncEpicGameDLCBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public SyncOculusDLC.SyncOculusDLCBuilder SyncOculusDLCOp
        {
            get
            {
                var opBuilder = new Operation.SyncOculusDLC.SyncOculusDLCBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PublicSyncPsnDlcInventory.PublicSyncPsnDlcInventoryBuilder PublicSyncPsnDlcInventoryOp
        {
            get
            {
                var opBuilder = new Operation.PublicSyncPsnDlcInventory.PublicSyncPsnDlcInventoryBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PublicSyncPsnDlcInventoryWithMultipleServiceLabels.PublicSyncPsnDlcInventoryWithMultipleServiceLabelsBuilder PublicSyncPsnDlcInventoryWithMultipleServiceLabelsOp
        {
            get
            {
                var opBuilder = new Operation.PublicSyncPsnDlcInventoryWithMultipleServiceLabels.PublicSyncPsnDlcInventoryWithMultipleServiceLabelsBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public SyncSteamDLC.SyncSteamDLCBuilder SyncSteamDLCOp
        {
            get
            {
                var opBuilder = new Operation.SyncSteamDLC.SyncSteamDLCBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public SyncXboxDLC.SyncXboxDLCBuilder SyncXboxDLCOp
        {
            get
            {
                var opBuilder = new Operation.SyncXboxDLC.SyncXboxDLCBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PublicGetMyDLCContent.PublicGetMyDLCContentBuilder PublicGetMyDLCContentOp
        {
            get
            {
                var opBuilder = new Operation.PublicGetMyDLCContent.PublicGetMyDLCContentBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

        public Model.DLCItemConfigInfo? GetDLCItemConfig(GetDLCItemConfig input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.DLCItemConfigInfo?> GetDLCItemConfigAsync(GetDLCItemConfig input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.DLCItemConfigInfo? UpdateDLCItemConfig(UpdateDLCItemConfig input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.DLCItemConfigInfo?> UpdateDLCItemConfigAsync(UpdateDLCItemConfig input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteDLCItemConfig(DeleteDLCItemConfig input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task DeleteDLCItemConfigAsync(DeleteDLCItemConfig input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.PlatformDLCConfigInfo? GetPlatformDLCConfig(GetPlatformDLCConfig input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.PlatformDLCConfigInfo?> GetPlatformDLCConfigAsync(GetPlatformDLCConfig input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.PlatformDLCConfigInfo? UpdatePlatformDLCConfig(UpdatePlatformDLCConfig input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.PlatformDLCConfigInfo?> UpdatePlatformDLCConfigAsync(UpdatePlatformDLCConfig input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeletePlatformDLCConfig(DeletePlatformDLCConfig input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task DeletePlatformDLCConfigAsync(DeletePlatformDLCConfig input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.UserDLC? GetUserDLCByPlatform(GetUserDLCByPlatform input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.UserDLC?> GetUserDLCByPlatformAsync(GetUserDLCByPlatform input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.UserDLCRecord>? GetUserDLC(GetUserDLC input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<List<Model.UserDLCRecord>?> GetUserDLCAsync(GetUserDLC input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public List<Model.UserDLCRecord<T1>>? GetUserDLC<T1>(GetUserDLC input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<List<Model.UserDLCRecord<T1>>?> GetUserDLCAsync<T1>(GetUserDLC input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.DLCConfigRewardShortInfo? GeDLCDurableRewardShortMap(GeDLCDurableRewardShortMap input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.DLCConfigRewardShortInfo?> GeDLCDurableRewardShortMapAsync(GeDLCDurableRewardShortMap input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void SyncEpicGameDLC(SyncEpicGameDLC input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task SyncEpicGameDLCAsync(SyncEpicGameDLC input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void SyncOculusDLC(SyncOculusDLC input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task SyncOculusDLCAsync(SyncOculusDLC input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void PublicSyncPsnDlcInventory(PublicSyncPsnDlcInventory input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task PublicSyncPsnDlcInventoryAsync(PublicSyncPsnDlcInventory input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void PublicSyncPsnDlcInventoryWithMultipleServiceLabels(PublicSyncPsnDlcInventoryWithMultipleServiceLabels input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task PublicSyncPsnDlcInventoryWithMultipleServiceLabelsAsync(PublicSyncPsnDlcInventoryWithMultipleServiceLabels input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void SyncSteamDLC(SyncSteamDLC input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task SyncSteamDLCAsync(SyncSteamDLC input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void SyncXboxDLC(SyncXboxDLC input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task SyncXboxDLCAsync(SyncXboxDLC input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.SimpleUserDLCRewardContentsResponse? PublicGetMyDLCContent(PublicGetMyDLCContent input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.SimpleUserDLCRewardContentsResponse?> PublicGetMyDLCContentAsync(PublicGetMyDLCContent input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}