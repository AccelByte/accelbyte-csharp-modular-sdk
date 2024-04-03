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

using AccelByte.Sdk.Api.Matchmaking.Model;
using AccelByte.Sdk.Api.Matchmaking.Operation;

namespace AccelByte.Sdk.Api.Matchmaking.Wrapper
{
    public class SocialMatchmaking
    {
        private readonly IAccelByteSdk _sdk;

        public SocialMatchmaking(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public UpdatePlayTimeWeight.UpdatePlayTimeWeightBuilder UpdatePlayTimeWeightOp
        {
            get { return new Operation.UpdatePlayTimeWeight.UpdatePlayTimeWeightBuilder(_sdk); }
        }
        #endregion

        public Model.ModelsUpdatePlayerPlaytimeWeightResponse? UpdatePlayTimeWeight(UpdatePlayTimeWeight input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsUpdatePlayerPlaytimeWeightResponse?> UpdatePlayTimeWeightAsync(UpdatePlayTimeWeight input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}