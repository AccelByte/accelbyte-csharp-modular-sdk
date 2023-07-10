// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Qosm.Model;
using AccelByte.Sdk.Api.Qosm.Operation;

namespace AccelByte.Sdk.Api.Qosm.Wrapper
{
    public class Public
    {
        private readonly IAccelByteSdk _sdk;

        public Public(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public ListServerPerNamespace.ListServerPerNamespaceBuilder ListServerPerNamespaceOp
        {
            get { return new Operation.ListServerPerNamespace.ListServerPerNamespaceBuilder(_sdk); }
        }
        public ListServer.ListServerBuilder ListServerOp
        {
            get { return new Operation.ListServer.ListServerBuilder(_sdk); }
        }
        #endregion

        public Model.ModelsListServerResponse? ListServerPerNamespace(ListServerPerNamespace input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsListServerResponse? ListServer(ListServer input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}