// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Api.Basic.Operation;

namespace AccelByte.Sdk.Api.Basic.Wrapper
{
    public class UserAction
    {
        private readonly IAccelByteSdk _sdk;

        public UserAction(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetActions.GetActionsBuilder GetActionsOp
        {
            get { return new Operation.GetActions.GetActionsBuilder(_sdk); }
        }
        public BanUsers.BanUsersBuilder BanUsersOp
        {
            get { return new Operation.BanUsers.BanUsersBuilder(_sdk); }
        }
        public GetBannedUsers.GetBannedUsersBuilder GetBannedUsersOp
        {
            get { return new Operation.GetBannedUsers.GetBannedUsersBuilder(_sdk); }
        }
        public ReportUser.ReportUserBuilder ReportUserOp
        {
            get { return new Operation.ReportUser.ReportUserBuilder(_sdk); }
        }
        public GetUserStatus.GetUserStatusBuilder GetUserStatusOp
        {
            get { return new Operation.GetUserStatus.GetUserStatusBuilder(_sdk); }
        }
        public UnBanUsers.UnBanUsersBuilder UnBanUsersOp
        {
            get { return new Operation.UnBanUsers.UnBanUsersBuilder(_sdk); }
        }
        public PublicReportUser.PublicReportUserBuilder PublicReportUserOp
        {
            get { return new Operation.PublicReportUser.PublicReportUserBuilder(_sdk); }
        }
        #endregion

        public List<Model.Action>? GetActions(GetActions input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void BanUsers(BanUsers input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ADTOObjectForEqu8UserBanStatus>? GetBannedUsers(GetBannedUsers input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void ReportUser(ReportUser input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ADTOObjectForEqu8UserStatus? GetUserStatus(GetUserStatus input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void UnBanUsers(UnBanUsers input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void PublicReportUser(PublicReportUser input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}