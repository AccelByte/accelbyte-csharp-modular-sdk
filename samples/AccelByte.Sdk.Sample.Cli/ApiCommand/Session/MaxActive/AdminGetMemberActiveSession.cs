// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Session.Wrapper;
using AccelByte.Sdk.Api.Session.Model;
using AccelByte.Sdk.Api.Session.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Session
{
    [SdkConsoleCommand("session", "admingetmemberactivesession")]
    public class AdminGetMemberActiveSessionCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Session"; } }

        public string OperationName { get { return "AdminGetMemberActiveSession"; } }

        [SdkCommandArgument("name")]
        public string Name { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        public AdminGetMemberActiveSessionCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Session.Wrapper.MaxActive wrapper = new AccelByte.Sdk.Api.Session.Wrapper.MaxActive(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Session.Operation.AdminGetMemberActiveSession.Builder;





            AdminGetMemberActiveSession operation = opBuilder.Build(
                Name,
                Namespace,
                UserId
            );


            AccelByte.Sdk.Api.Session.Model.ModelsMemberActiveSession? response = wrapper.AdminGetMemberActiveSession(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}