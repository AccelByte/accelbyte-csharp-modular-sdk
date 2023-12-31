// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Api.Legal.Operation;

namespace AccelByte.Sdk.Api.Legal.Wrapper
{
    public class Eligibilities
    {
        private readonly IAccelByteSdk _sdk;

        public Eligibilities(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public RetrieveEligibilitiesPublic.RetrieveEligibilitiesPublicBuilder RetrieveEligibilitiesPublicOp
        {
            get { return new Operation.RetrieveEligibilitiesPublic.RetrieveEligibilitiesPublicBuilder(_sdk); }
        }
        public RetrieveEligibilitiesPublicIndirect.RetrieveEligibilitiesPublicIndirectBuilder RetrieveEligibilitiesPublicIndirectOp
        {
            get { return new Operation.RetrieveEligibilitiesPublicIndirect.RetrieveEligibilitiesPublicIndirectBuilder(_sdk); }
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
        public Model.RetrieveUserEligibilitiesIndirectResponse? RetrieveEligibilitiesPublicIndirect(RetrieveEligibilitiesPublicIndirect input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}