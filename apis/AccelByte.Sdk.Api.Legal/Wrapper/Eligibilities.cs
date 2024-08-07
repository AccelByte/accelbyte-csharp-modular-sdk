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
    public class Eligibilities
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public Eligibilities(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public Eligibilities(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        public RetrieveEligibilitiesPublic.RetrieveEligibilitiesPublicBuilder RetrieveEligibilitiesPublicOp
        {
            get
            {
                var opBuilder = new Operation.RetrieveEligibilitiesPublic.RetrieveEligibilitiesPublicBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public RetrieveEligibilitiesPublicIndirect.RetrieveEligibilitiesPublicIndirectBuilder RetrieveEligibilitiesPublicIndirectOp
        {
            get
            {
                var opBuilder = new Operation.RetrieveEligibilitiesPublicIndirect.RetrieveEligibilitiesPublicIndirectBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

        public List<Model.RetrieveUserEligibilitiesResponse>? RetrieveEligibilitiesPublic(RetrieveEligibilitiesPublic input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<List<Model.RetrieveUserEligibilitiesResponse>?> RetrieveEligibilitiesPublicAsync(RetrieveEligibilitiesPublic input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.RetrieveUserEligibilitiesIndirectResponse? RetrieveEligibilitiesPublicIndirect(RetrieveEligibilitiesPublicIndirect input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.RetrieveUserEligibilitiesIndirectResponse?> RetrieveEligibilitiesPublicIndirectAsync(RetrieveEligibilitiesPublicIndirect input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}