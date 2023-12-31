// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Inventory.Model;
using AccelByte.Sdk.Api.Inventory.Operation;

namespace AccelByte.Sdk.Api.Inventory.Wrapper
{
    public class PublicInventoryConfigurations
    {
        private readonly IAccelByteSdk _sdk;

        public PublicInventoryConfigurations(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public PublicListInventoryConfigurations.PublicListInventoryConfigurationsBuilder PublicListInventoryConfigurationsOp
        {
            get { return new Operation.PublicListInventoryConfigurations.PublicListInventoryConfigurationsBuilder(_sdk); }
        }
        #endregion

        public Model.ApimodelsListInventoryConfigurationsResp? PublicListInventoryConfigurations(PublicListInventoryConfigurations input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}