// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Api.Social.Operation;

namespace AccelByte.Sdk.Api.Social.Wrapper
{
    public class SlotConfig
    {
        private readonly IAccelByteSdk _sdk;

        public SlotConfig(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetNamespaceSlotConfig.GetNamespaceSlotConfigBuilder GetNamespaceSlotConfigOp
        {
            get { return new Operation.GetNamespaceSlotConfig.GetNamespaceSlotConfigBuilder(_sdk); }
        }
        public UpdateNamespaceSlotConfig.UpdateNamespaceSlotConfigBuilder UpdateNamespaceSlotConfigOp
        {
            get { return new Operation.UpdateNamespaceSlotConfig.UpdateNamespaceSlotConfigBuilder(_sdk); }
        }
        public DeleteNamespaceSlotConfig.DeleteNamespaceSlotConfigBuilder DeleteNamespaceSlotConfigOp
        {
            get { return new Operation.DeleteNamespaceSlotConfig.DeleteNamespaceSlotConfigBuilder(_sdk); }
        }
        public GetUserSlotConfig.GetUserSlotConfigBuilder GetUserSlotConfigOp
        {
            get { return new Operation.GetUserSlotConfig.GetUserSlotConfigBuilder(_sdk); }
        }
        public UpdateUserSlotConfig.UpdateUserSlotConfigBuilder UpdateUserSlotConfigOp
        {
            get { return new Operation.UpdateUserSlotConfig.UpdateUserSlotConfigBuilder(_sdk); }
        }
        public DeleteUserSlotConfig.DeleteUserSlotConfigBuilder DeleteUserSlotConfigOp
        {
            get { return new Operation.DeleteUserSlotConfig.DeleteUserSlotConfigBuilder(_sdk); }
        }
        #endregion

        public Model.NamespaceSlotConfigInfo? GetNamespaceSlotConfig(GetNamespaceSlotConfig input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.NamespaceSlotConfigInfo? UpdateNamespaceSlotConfig(UpdateNamespaceSlotConfig input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteNamespaceSlotConfig(DeleteNamespaceSlotConfig input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.UserSlotConfigInfo? GetUserSlotConfig(GetUserSlotConfig input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.UserSlotConfigInfo? UpdateUserSlotConfig(UpdateUserSlotConfig input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteUserSlotConfig(DeleteUserSlotConfig input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}