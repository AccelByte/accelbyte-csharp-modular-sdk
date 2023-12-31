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
    public class AdminType
    {
        private readonly IAccelByteSdk _sdk;

        public AdminType(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminGetType.AdminGetTypeBuilder AdminGetTypeOp
        {
            get { return new Operation.AdminGetType.AdminGetTypeBuilder(_sdk); }
        }
        public AdminCreateType.AdminCreateTypeBuilder AdminCreateTypeOp
        {
            get { return new Operation.AdminCreateType.AdminCreateTypeBuilder(_sdk); }
        }
        public AdminUpdateType.AdminUpdateTypeBuilder AdminUpdateTypeOp
        {
            get { return new Operation.AdminUpdateType.AdminUpdateTypeBuilder(_sdk); }
        }
        public AdminDeleteType.AdminDeleteTypeBuilder AdminDeleteTypeOp
        {
            get { return new Operation.AdminDeleteType.AdminDeleteTypeBuilder(_sdk); }
        }
        #endregion

        public Model.ModelsPaginatedGetTypeResponse? AdminGetType(AdminGetType input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsCreateTypeResponse? AdminCreateType(AdminCreateType input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsCreateTypeResponse? AdminUpdateType(AdminUpdateType input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDeleteType(AdminDeleteType input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}