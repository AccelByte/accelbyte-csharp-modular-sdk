// Copyright (c) 2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccelByte.Sdk.Tests.Mod.Model
{
    public class HttpbinTestRequest : AccelByte.Sdk.Core.Model
    {
        public string? Name { get; set; }

        public int Quantity { get; set; }

        public double Weight { get; set; }

        public Dictionary<string, double>? Dimensions { get; set; }
    }
}
