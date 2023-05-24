// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Reporting.Model;
using AccelByte.Sdk.Api.Reporting.Operation;

namespace AccelByte.Sdk.Api.Reporting.Wrapper
{
    public class PublicReasons
    {
        private readonly IAccelByteSdk _sdk;

        public PublicReasons(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public PublicListReasonGroups.PublicListReasonGroupsBuilder PublicListReasonGroupsOp
        {
            get { return new Operation.PublicListReasonGroups.PublicListReasonGroupsBuilder(_sdk); }
        }
        public PublicGetReasons.PublicGetReasonsBuilder PublicGetReasonsOp
        {
            get { return new Operation.PublicGetReasons.PublicGetReasonsBuilder(_sdk); }
        }
        #endregion

        public Model.RestapiReasonGroupListResponse? PublicListReasonGroups(PublicListReasonGroups input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.RestapiPublicReasonListResponse? PublicGetReasons(PublicGetReasons input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}