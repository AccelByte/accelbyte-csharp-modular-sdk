// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;

namespace AccelByte.Sdk.Api.Platform.Wrapper
{
    public class OrderDedicated
    {
        private readonly IAccelByteSdk _sdk;

        public OrderDedicated(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public SyncOrders.SyncOrdersBuilder SyncOrdersOp
        {
            get { return new Operation.SyncOrders.SyncOrdersBuilder(_sdk); }
        }
        #endregion
        
        public Model.OrderSyncResult? SyncOrders(SyncOrders input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}