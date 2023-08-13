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
    public class Party
    {
        private readonly IAccelByteSdk _sdk;

        public Party(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminQueryParties.AdminQueryPartiesBuilder AdminQueryPartiesOp
        {
            get { return new Operation.AdminQueryParties.AdminQueryPartiesBuilder(_sdk); }
        }
        public PublicPartyJoinCode.PublicPartyJoinCodeBuilder PublicPartyJoinCodeOp
        {
            get { return new Operation.PublicPartyJoinCode.PublicPartyJoinCodeBuilder(_sdk); }
        }
        public PublicGetParty.PublicGetPartyBuilder PublicGetPartyOp
        {
            get { return new Operation.PublicGetParty.PublicGetPartyBuilder(_sdk); }
        }
        public PublicUpdateParty.PublicUpdatePartyBuilder PublicUpdatePartyOp
        {
            get { return new Operation.PublicUpdateParty.PublicUpdatePartyBuilder(_sdk); }
        }
        public PublicPatchUpdateParty.PublicPatchUpdatePartyBuilder PublicPatchUpdatePartyOp
        {
            get { return new Operation.PublicPatchUpdateParty.PublicPatchUpdatePartyBuilder(_sdk); }
        }
        public PublicGeneratePartyCode.PublicGeneratePartyCodeBuilder PublicGeneratePartyCodeOp
        {
            get { return new Operation.PublicGeneratePartyCode.PublicGeneratePartyCodeBuilder(_sdk); }
        }
        public PublicRevokePartyCode.PublicRevokePartyCodeBuilder PublicRevokePartyCodeOp
        {
            get { return new Operation.PublicRevokePartyCode.PublicRevokePartyCodeBuilder(_sdk); }
        }
        public PublicPartyInvite.PublicPartyInviteBuilder PublicPartyInviteOp
        {
            get { return new Operation.PublicPartyInvite.PublicPartyInviteBuilder(_sdk); }
        }
        public PublicPromotePartyLeader.PublicPromotePartyLeaderBuilder PublicPromotePartyLeaderOp
        {
            get { return new Operation.PublicPromotePartyLeader.PublicPromotePartyLeaderBuilder(_sdk); }
        }
        public PublicPartyJoin.PublicPartyJoinBuilder PublicPartyJoinOp
        {
            get { return new Operation.PublicPartyJoin.PublicPartyJoinBuilder(_sdk); }
        }
        public PublicPartyLeave.PublicPartyLeaveBuilder PublicPartyLeaveOp
        {
            get { return new Operation.PublicPartyLeave.PublicPartyLeaveBuilder(_sdk); }
        }
        public PublicPartyReject.PublicPartyRejectBuilder PublicPartyRejectOp
        {
            get { return new Operation.PublicPartyReject.PublicPartyRejectBuilder(_sdk); }
        }
        public PublicPartyKick.PublicPartyKickBuilder PublicPartyKickOp
        {
            get { return new Operation.PublicPartyKick.PublicPartyKickBuilder(_sdk); }
        }
        public PublicCreateParty.PublicCreatePartyBuilder PublicCreatePartyOp
        {
            get { return new Operation.PublicCreateParty.PublicCreatePartyBuilder(_sdk); }
        }
        public PublicQueryMyParties.PublicQueryMyPartiesBuilder PublicQueryMyPartiesOp
        {
            get { return new Operation.PublicQueryMyParties.PublicQueryMyPartiesBuilder(_sdk); }
        }
        #endregion

        public Model.ApimodelsPartyQueryResponse? AdminQueryParties(AdminQueryParties input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsPartySessionResponse? PublicPartyJoinCode(PublicPartyJoinCode input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ApimodelsPartySessionResponse<T1>? PublicPartyJoinCode<T1>(PublicPartyJoinCode input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsPartySessionResponse? PublicGetParty(PublicGetParty input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ApimodelsPartySessionResponse<T1>? PublicGetParty<T1>(PublicGetParty input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsPartySessionResponse? PublicUpdateParty(PublicUpdateParty input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ApimodelsPartySessionResponse<T1>? PublicUpdateParty<T1>(PublicUpdateParty input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsPartySessionResponse? PublicPatchUpdateParty(PublicPatchUpdateParty input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ApimodelsPartySessionResponse<T1>? PublicPatchUpdateParty<T1>(PublicPatchUpdateParty input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsPartySessionResponse? PublicGeneratePartyCode(PublicGeneratePartyCode input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ApimodelsPartySessionResponse<T1>? PublicGeneratePartyCode<T1>(PublicGeneratePartyCode input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsPartySessionResponse? PublicRevokePartyCode(PublicRevokePartyCode input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ApimodelsPartySessionResponse<T1>? PublicRevokePartyCode<T1>(PublicRevokePartyCode input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void PublicPartyInvite(PublicPartyInvite input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsPartySessionResponse? PublicPromotePartyLeader(PublicPromotePartyLeader input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ApimodelsPartySessionResponse<T1>? PublicPromotePartyLeader<T1>(PublicPromotePartyLeader input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsPartySessionResponse? PublicPartyJoin(PublicPartyJoin input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ApimodelsPartySessionResponse<T1>? PublicPartyJoin<T1>(PublicPartyJoin input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void PublicPartyLeave(PublicPartyLeave input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void PublicPartyReject(PublicPartyReject input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsKickResponse? PublicPartyKick(PublicPartyKick input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsPartySessionResponse? PublicCreateParty(PublicCreateParty input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ApimodelsPartySessionResponse<T1>? PublicCreateParty<T1>(PublicCreateParty input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsPartyQueryResponse? PublicQueryMyParties(PublicQueryMyParties input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}