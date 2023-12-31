// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Session.Model;
using AccelByte.Sdk.Api.Session.Operation;

namespace AccelByte.Sdk.Api.Session.Wrapper
{
    public class Player
    {
        private readonly IAccelByteSdk _sdk;

        public Player(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminQueryPlayerAttributes.AdminQueryPlayerAttributesBuilder AdminQueryPlayerAttributesOp
        {
            get { return new Operation.AdminQueryPlayerAttributes.AdminQueryPlayerAttributesBuilder(_sdk); }
        }
        public AdminGetPlayerAttributes.AdminGetPlayerAttributesBuilder AdminGetPlayerAttributesOp
        {
            get { return new Operation.AdminGetPlayerAttributes.AdminGetPlayerAttributesBuilder(_sdk); }
        }
        public PublicGetBulkPlayerCurrentPlatform.PublicGetBulkPlayerCurrentPlatformBuilder PublicGetBulkPlayerCurrentPlatformOp
        {
            get { return new Operation.PublicGetBulkPlayerCurrentPlatform.PublicGetBulkPlayerCurrentPlatformBuilder(_sdk); }
        }
        public PublicGetPlayerAttributes.PublicGetPlayerAttributesBuilder PublicGetPlayerAttributesOp
        {
            get { return new Operation.PublicGetPlayerAttributes.PublicGetPlayerAttributesBuilder(_sdk); }
        }
        public PublicStorePlayerAttributes.PublicStorePlayerAttributesBuilder PublicStorePlayerAttributesOp
        {
            get { return new Operation.PublicStorePlayerAttributes.PublicStorePlayerAttributesBuilder(_sdk); }
        }
        public PublicDeletePlayerAttributes.PublicDeletePlayerAttributesBuilder PublicDeletePlayerAttributesOp
        {
            get { return new Operation.PublicDeletePlayerAttributes.PublicDeletePlayerAttributesBuilder(_sdk); }
        }
        #endregion

        public List<Model.ApimodelsPlayerAttributesResponseBody>? AdminQueryPlayerAttributes(AdminQueryPlayerAttributes input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public List<Model.ApimodelsPlayerAttributesResponseBody<T1>>? AdminQueryPlayerAttributes<T1>(AdminQueryPlayerAttributes input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsPlayerAttributesResponseBody? AdminGetPlayerAttributes(AdminGetPlayerAttributes input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ApimodelsPlayerAttributesResponseBody<T1>? AdminGetPlayerAttributes<T1>(AdminGetPlayerAttributes input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsPlayersCurrentPlatformResponse? PublicGetBulkPlayerCurrentPlatform(PublicGetBulkPlayerCurrentPlatform input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsPlayerAttributesResponseBody? PublicGetPlayerAttributes(PublicGetPlayerAttributes input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ApimodelsPlayerAttributesResponseBody<T1>? PublicGetPlayerAttributes<T1>(PublicGetPlayerAttributes input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsPlayerAttributesResponseBody? PublicStorePlayerAttributes(PublicStorePlayerAttributes input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ApimodelsPlayerAttributesResponseBody<T1>? PublicStorePlayerAttributes<T1>(PublicStorePlayerAttributes input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void PublicDeletePlayerAttributes(PublicDeletePlayerAttributes input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}