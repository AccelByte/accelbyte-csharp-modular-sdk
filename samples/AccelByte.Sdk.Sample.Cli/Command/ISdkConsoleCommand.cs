﻿// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccelByte.Sdk.Sample.Cli.Command
{
    public interface ISdkConsoleCommand
    {
        string ServiceName { get; }

        string OperationName { get; }

        CommandResult Run();
    }
}
