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
    public class AdminTags
    {
        private readonly IAccelByteSdk _sdk;

        public AdminTags(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminListTags.AdminListTagsBuilder AdminListTagsOp
        {
            get { return new Operation.AdminListTags.AdminListTagsBuilder(_sdk); }
        }
        public AdminCreateTag.AdminCreateTagBuilder AdminCreateTagOp
        {
            get { return new Operation.AdminCreateTag.AdminCreateTagBuilder(_sdk); }
        }
        public AdminDeleteTag.AdminDeleteTagBuilder AdminDeleteTagOp
        {
            get { return new Operation.AdminDeleteTag.AdminDeleteTagBuilder(_sdk); }
        }
        #endregion

        public Model.ApimodelsListTagsResp? AdminListTags(AdminListTags input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsCreateTagResp? AdminCreateTag(AdminCreateTag input)
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