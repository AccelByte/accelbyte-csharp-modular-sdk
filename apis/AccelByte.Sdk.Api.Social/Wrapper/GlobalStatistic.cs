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
    public class GlobalStatistic
    {
        private readonly IAccelByteSdk _sdk;

        public GlobalStatistic(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetGlobalStatItems.GetGlobalStatItemsBuilder GetGlobalStatItemsOp
        {
            get { return new Operation.GetGlobalStatItems.GetGlobalStatItemsBuilder(_sdk); }
        }
        public GetGlobalStatItemByStatCode.GetGlobalStatItemByStatCodeBuilder GetGlobalStatItemByStatCodeOp
        {
            get { return new Operation.GetGlobalStatItemByStatCode.GetGlobalStatItemByStatCodeBuilder(_sdk); }
        }
        public GetGlobalStatItems1.GetGlobalStatItems1Builder GetGlobalStatItems1Op
        {
            get { return new Operation.GetGlobalStatItems1.GetGlobalStatItems1Builder(_sdk); }
        }
        public GetGlobalStatItemByStatCode1.GetGlobalStatItemByStatCode1Builder GetGlobalStatItemByStatCode1Op
        {
            get { return new Operation.GetGlobalStatItemByStatCode1.GetGlobalStatItemByStatCode1Builder(_sdk); }
        }
        #endregion

        public Model.GlobalStatItemPagingSlicedResult? GetGlobalStatItems(GetGlobalStatItems input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.GlobalStatItemPagingSlicedResult?> GetGlobalStatItemsAsync(GetGlobalStatItems input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.GlobalStatItemInfo? GetGlobalStatItemByStatCode(GetGlobalStatItemByStatCode input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.GlobalStatItemInfo?> GetGlobalStatItemByStatCodeAsync(GetGlobalStatItemByStatCode input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.GlobalStatItemPagingSlicedResult? GetGlobalStatItems1(GetGlobalStatItems1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.GlobalStatItemPagingSlicedResult?> GetGlobalStatItems1Async(GetGlobalStatItems1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.GlobalStatItemInfo? GetGlobalStatItemByStatCode1(GetGlobalStatItemByStatCode1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.GlobalStatItemInfo?> GetGlobalStatItemByStatCode1Async(GetGlobalStatItemByStatCode1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}