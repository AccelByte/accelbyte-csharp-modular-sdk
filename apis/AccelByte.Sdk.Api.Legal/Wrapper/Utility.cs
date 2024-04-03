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

using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Api.Legal.Operation;

namespace AccelByte.Sdk.Api.Legal.Wrapper
{
    public class Utility
    {
        private readonly IAccelByteSdk _sdk;

        public Utility(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public CheckReadiness.CheckReadinessBuilder CheckReadinessOp
        {
            get { return new Operation.CheckReadiness.CheckReadinessBuilder(_sdk); }
        }
        #endregion

        public Model.LegalReadinessStatusResponse? CheckReadiness(CheckReadiness input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.LegalReadinessStatusResponse?> CheckReadinessAsync(CheckReadiness input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}