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
    public class Anonymization
    {
        private readonly IAccelByteSdk _sdk;

        public Anonymization(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AnonymizeUserAgreement.AnonymizeUserAgreementBuilder AnonymizeUserAgreementOp
        {
            get { return new Operation.AnonymizeUserAgreement.AnonymizeUserAgreementBuilder(_sdk); }
        }
        #endregion

        public void AnonymizeUserAgreement(AnonymizeUserAgreement input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task AnonymizeUserAgreementAsync(AnonymizeUserAgreement input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}