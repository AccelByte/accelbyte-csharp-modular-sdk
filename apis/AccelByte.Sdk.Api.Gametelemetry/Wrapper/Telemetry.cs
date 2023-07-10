// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Gametelemetry.Model;
using AccelByte.Sdk.Api.Gametelemetry.Operation;

namespace AccelByte.Sdk.Api.Gametelemetry.Wrapper
{
    public class Telemetry
    {
        private readonly IAccelByteSdk _sdk;

        public Telemetry(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGet.GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGetBuilder GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGetOp
        {
            get { return new Operation.GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGet.GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGetBuilder(_sdk); }
        }
        #endregion

        public void GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGet(GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGet input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}