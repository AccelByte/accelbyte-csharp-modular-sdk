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
    public class KeyGroup
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public KeyGroup(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public KeyGroup(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        public QueryKeyGroups.QueryKeyGroupsBuilder QueryKeyGroupsOp
        {
            get
            {
                var opBuilder = new Operation.QueryKeyGroups.QueryKeyGroupsBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public CreateKeyGroup.CreateKeyGroupBuilder CreateKeyGroupOp
        {
            get
            {
                var opBuilder = new Operation.CreateKeyGroup.CreateKeyGroupBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public GetKeyGroupByBoothName.GetKeyGroupByBoothNameBuilder GetKeyGroupByBoothNameOp
        {
            get
            {
                var opBuilder = new Operation.GetKeyGroupByBoothName.GetKeyGroupByBoothNameBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetKeyGroup.GetKeyGroupBuilder GetKeyGroupOp
        {
            get
            {
                var opBuilder = new Operation.GetKeyGroup.GetKeyGroupBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public UpdateKeyGroup.UpdateKeyGroupBuilder UpdateKeyGroupOp
        {
            get
            {
                var opBuilder = new Operation.UpdateKeyGroup.UpdateKeyGroupBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetKeyGroupDynamic.GetKeyGroupDynamicBuilder GetKeyGroupDynamicOp
        {
            get
            {
                var opBuilder = new Operation.GetKeyGroupDynamic.GetKeyGroupDynamicBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public ListKeys.ListKeysBuilder ListKeysOp
        {
            get
            {
                var opBuilder = new Operation.ListKeys.ListKeysBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public UploadKeys.UploadKeysBuilder UploadKeysOp
        {
            get
            {
                var opBuilder = new Operation.UploadKeys.UploadKeysBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

        public Model.KeyGroupPagingSlicedResult? QueryKeyGroups(QueryKeyGroups input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.KeyGroupPagingSlicedResult?> QueryKeyGroupsAsync(QueryKeyGroups input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.KeyGroupInfo? CreateKeyGroup(CreateKeyGroup input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.KeyGroupInfo?> CreateKeyGroupAsync(CreateKeyGroup input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public Model.KeyGroupInfo? GetKeyGroupByBoothName(GetKeyGroupByBoothName input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.KeyGroupInfo?> GetKeyGroupByBoothNameAsync(GetKeyGroupByBoothName input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        public Model.KeyGroupInfo? GetKeyGroup(GetKeyGroup input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.KeyGroupInfo?> GetKeyGroupAsync(GetKeyGroup input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.KeyGroupInfo? UpdateKeyGroup(UpdateKeyGroup input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.KeyGroupInfo?> UpdateKeyGroupAsync(UpdateKeyGroup input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.KeyGroupDynamicInfo? GetKeyGroupDynamic(GetKeyGroupDynamic input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.KeyGroupDynamicInfo?> GetKeyGroupDynamicAsync(GetKeyGroupDynamic input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.KeyPagingSliceResult? ListKeys(ListKeys input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.KeyPagingSliceResult?> ListKeysAsync(ListKeys input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.BulkOperationResult? UploadKeys(UploadKeys input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.BulkOperationResult?> UploadKeysAsync(UploadKeys input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}