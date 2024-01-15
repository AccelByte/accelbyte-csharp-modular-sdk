// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Ams.Model;
using AccelByte.Sdk.Api.Ams.Operation;

namespace AccelByte.Sdk.Api.Ams.Wrapper
{
    public class AMSInfo
    {
        private readonly IAccelByteSdk _sdk;

        public AMSInfo(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public InfoRegions.InfoRegionsBuilder InfoRegionsOp
        {
            get { return new Operation.InfoRegions.InfoRegionsBuilder(_sdk); }
        }
        public InfoSupportedInstances.InfoSupportedInstancesBuilder InfoSupportedInstancesOp
        {
            get { return new Operation.InfoSupportedInstances.InfoSupportedInstancesBuilder(_sdk); }
        }
        public UploadURLGet.UploadURLGetBuilder UploadURLGetOp
        {
            get { return new Operation.UploadURLGet.UploadURLGetBuilder(_sdk); }
        }
        #endregion

        public Model.ApiAMSRegionsResponse? InfoRegions(InfoRegions input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApiAvailableInstanceTypesResponse? InfoSupportedInstances(InfoSupportedInstances input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void UploadURLGet(UploadURLGet input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}