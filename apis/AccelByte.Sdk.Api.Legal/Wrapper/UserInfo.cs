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
    public class UserInfo
    {
        private readonly IAccelByteSdk _sdk;

        public UserInfo(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetUserInfoStatus.GetUserInfoStatusBuilder GetUserInfoStatusOp
        {
            get { return new Operation.GetUserInfoStatus.GetUserInfoStatusBuilder(_sdk); }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public SyncUserInfo.SyncUserInfoBuilder SyncUserInfoOp
        {
            get { return new Operation.SyncUserInfo.SyncUserInfoBuilder(_sdk); }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public InvalidateUserInfoCache.InvalidateUserInfoCacheBuilder InvalidateUserInfoCacheOp
        {
            get { return new Operation.InvalidateUserInfoCache.InvalidateUserInfoCacheBuilder(_sdk); }
        }
        #endregion

        public List<Model.RetrieveUserInfoCacheStatusResponse>? GetUserInfoStatus(GetUserInfoStatus input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public void SyncUserInfo(SyncUserInfo input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public void InvalidateUserInfoCache(InvalidateUserInfoCache input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
    }
}