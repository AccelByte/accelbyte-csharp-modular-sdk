// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Basic.Wrapper;
using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Api.Basic.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Basic
{
    [SdkConsoleCommand("basic","updatemyprofile")]
    public class UpdateMyProfileCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Basic"; } }

        public string OperationName{ get { return "UpdateMyProfile"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public UserProfileUpdate Body { get; set; } = new UserProfileUpdate();
                
        public UpdateMyProfileCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Basic.Wrapper.UserProfile wrapper = new AccelByte.Sdk.Api.Basic.Wrapper.UserProfile(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Basic.Operation.UpdateMyProfile.Builder;


            if (Body != null)
                opBuilder.SetBody((AccelByte.Sdk.Api.Basic.Model.UserProfileUpdate)Body);



            UpdateMyProfile operation = opBuilder.Build(
                Namespace
            );

            
            AccelByte.Sdk.Api.Basic.Model.UserProfilePrivateInfo? response = wrapper.UpdateMyProfile(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}