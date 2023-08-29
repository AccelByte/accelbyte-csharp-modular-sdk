// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Api.Ugc.Operation;

namespace AccelByte.Sdk.Api.Ugc.Wrapper
{
    public class AdminTag
    {
        private readonly IAccelByteSdk _sdk;

        public AdminTag(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminGetTag.AdminGetTagBuilder AdminGetTagOp
        {
            get { return new Operation.AdminGetTag.AdminGetTagBuilder(_sdk); }
        }
        public AdminCreateTag.AdminCreateTagBuilder AdminCreateTagOp
        {
            get { return new Operation.AdminCreateTag.AdminCreateTagBuilder(_sdk); }
        }
        public AdminUpdateTag.AdminUpdateTagBuilder AdminUpdateTagOp
        {
            get { return new Operation.AdminUpdateTag.AdminUpdateTagBuilder(_sdk); }
        }
        public AdminDeleteTag.AdminDeleteTagBuilder AdminDeleteTagOp
        {
            get { return new Operation.AdminDeleteTag.AdminDeleteTagBuilder(_sdk); }
        }
        #endregion

        public Model.ModelsPaginatedGetTagResponse? AdminGetTag(AdminGetTag input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsCreateTagResponse? AdminCreateTag(AdminCreateTag input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsCreateTagResponse? AdminUpdateTag(AdminUpdateTag input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDeleteTag(AdminDeleteTag input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}