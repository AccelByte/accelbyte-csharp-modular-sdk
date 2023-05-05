// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Session.Model;
using AccelByte.Sdk.Api.Session.Operation;
using AccelByte.Sdk.Api.Session.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class SessionParty_OpExts
    {
        public static Session.Model.ApimodelsPartyQueryResponse? Execute(
            this AdminQueryParties.AdminQueryPartiesBuilder builder,
            string namespace_
        )
        {
            AdminQueryParties op = builder.Build(
                namespace_
            );

            return ((Session.Wrapper.Party)builder.WrapperObject!).AdminQueryParties(op);
        }
        public static Session.Model.ApimodelsPartySessionResponse? Execute(
            this PublicPartyJoinCode.PublicPartyJoinCodeBuilder builder,
            ApimodelsJoinByCodeRequest body,
            string namespace_
        )
        {
            PublicPartyJoinCode op = builder.Build(
                body,
                namespace_
            );

            return ((Session.Wrapper.Party)builder.WrapperObject!).PublicPartyJoinCode(op);
        }

        public static Session.Model.ApimodelsPartySessionResponse<T1>? Execute<T1>(
            this PublicPartyJoinCode.PublicPartyJoinCodeBuilder builder,
            ApimodelsJoinByCodeRequest body,
            string namespace_
        )
        {
            PublicPartyJoinCode op = builder.Build(
                body,
                namespace_
            );

            return ((Session.Wrapper.Party)builder.WrapperObject!).PublicPartyJoinCode<T1>(op);
        }
        public static Session.Model.ApimodelsPartySessionResponse? Execute(
            this PublicGetParty.PublicGetPartyBuilder builder,
            string namespace_,
            string partyId
        )
        {
            PublicGetParty op = builder.Build(
                namespace_,
                partyId
            );

            return ((Session.Wrapper.Party)builder.WrapperObject!).PublicGetParty(op);
        }

        public static Session.Model.ApimodelsPartySessionResponse<T1>? Execute<T1>(
            this PublicGetParty.PublicGetPartyBuilder builder,
            string namespace_,
            string partyId
        )
        {
            PublicGetParty op = builder.Build(
                namespace_,
                partyId
            );

            return ((Session.Wrapper.Party)builder.WrapperObject!).PublicGetParty<T1>(op);
        }
        public static Session.Model.ApimodelsPartySessionResponse? Execute(
            this PublicUpdateParty.PublicUpdatePartyBuilder builder,
            ApimodelsUpdatePartyRequest body,
            string namespace_,
            string partyId
        )
        {
            PublicUpdateParty op = builder.Build(
                body,
                namespace_,
                partyId
            );

            return ((Session.Wrapper.Party)builder.WrapperObject!).PublicUpdateParty(op);
        }

        public static Session.Model.ApimodelsPartySessionResponse<T1>? Execute<T1>(
            this PublicUpdateParty.PublicUpdatePartyBuilder builder,
            ApimodelsUpdatePartyRequest body,
            string namespace_,
            string partyId
        )
        {
            PublicUpdateParty op = builder.Build(
                body,
                namespace_,
                partyId
            );

            return ((Session.Wrapper.Party)builder.WrapperObject!).PublicUpdateParty<T1>(op);
        }
        public static Session.Model.ApimodelsPartySessionResponse? Execute(
            this PublicPatchUpdateParty.PublicPatchUpdatePartyBuilder builder,
            ApimodelsUpdatePartyRequest body,
            string namespace_,
            string partyId
        )
        {
            PublicPatchUpdateParty op = builder.Build(
                body,
                namespace_,
                partyId
            );

            return ((Session.Wrapper.Party)builder.WrapperObject!).PublicPatchUpdateParty(op);
        }

        public static Session.Model.ApimodelsPartySessionResponse<T1>? Execute<T1>(
            this PublicPatchUpdateParty.PublicPatchUpdatePartyBuilder builder,
            ApimodelsUpdatePartyRequest body,
            string namespace_,
            string partyId
        )
        {
            PublicPatchUpdateParty op = builder.Build(
                body,
                namespace_,
                partyId
            );

            return ((Session.Wrapper.Party)builder.WrapperObject!).PublicPatchUpdateParty<T1>(op);
        }
        public static Session.Model.ApimodelsPartySessionResponse? Execute(
            this PublicGeneratePartyCode.PublicGeneratePartyCodeBuilder builder,
            string namespace_,
            string partyId
        )
        {
            PublicGeneratePartyCode op = builder.Build(
                namespace_,
                partyId
            );

            return ((Session.Wrapper.Party)builder.WrapperObject!).PublicGeneratePartyCode(op);
        }

        public static Session.Model.ApimodelsPartySessionResponse<T1>? Execute<T1>(
            this PublicGeneratePartyCode.PublicGeneratePartyCodeBuilder builder,
            string namespace_,
            string partyId
        )
        {
            PublicGeneratePartyCode op = builder.Build(
                namespace_,
                partyId
            );

            return ((Session.Wrapper.Party)builder.WrapperObject!).PublicGeneratePartyCode<T1>(op);
        }
        public static Session.Model.ApimodelsPartySessionResponse? Execute(
            this PublicRevokePartyCode.PublicRevokePartyCodeBuilder builder,
            string namespace_,
            string partyId
        )
        {
            PublicRevokePartyCode op = builder.Build(
                namespace_,
                partyId
            );

            return ((Session.Wrapper.Party)builder.WrapperObject!).PublicRevokePartyCode(op);
        }

        public static Session.Model.ApimodelsPartySessionResponse<T1>? Execute<T1>(
            this PublicRevokePartyCode.PublicRevokePartyCodeBuilder builder,
            string namespace_,
            string partyId
        )
        {
            PublicRevokePartyCode op = builder.Build(
                namespace_,
                partyId
            );

            return ((Session.Wrapper.Party)builder.WrapperObject!).PublicRevokePartyCode<T1>(op);
        }
        public static void Execute(
            this PublicPartyInvite.PublicPartyInviteBuilder builder,
            ApimodelsSessionInviteRequest body,
            string namespace_,
            string partyId
        )
        {
            PublicPartyInvite op = builder.Build(
                body,
                namespace_,
                partyId
            );

            ((Session.Wrapper.Party)builder.WrapperObject!).PublicPartyInvite(op);
        }
        public static Session.Model.ApimodelsPartySessionResponse? Execute(
            this PublicPromotePartyLeader.PublicPromotePartyLeaderBuilder builder,
            ApimodelsPromoteLeaderRequest body,
            string namespace_,
            string partyId
        )
        {
            PublicPromotePartyLeader op = builder.Build(
                body,
                namespace_,
                partyId
            );

            return ((Session.Wrapper.Party)builder.WrapperObject!).PublicPromotePartyLeader(op);
        }

        public static Session.Model.ApimodelsPartySessionResponse<T1>? Execute<T1>(
            this PublicPromotePartyLeader.PublicPromotePartyLeaderBuilder builder,
            ApimodelsPromoteLeaderRequest body,
            string namespace_,
            string partyId
        )
        {
            PublicPromotePartyLeader op = builder.Build(
                body,
                namespace_,
                partyId
            );

            return ((Session.Wrapper.Party)builder.WrapperObject!).PublicPromotePartyLeader<T1>(op);
        }
        public static Session.Model.ApimodelsPartySessionResponse? Execute(
            this PublicPartyJoin.PublicPartyJoinBuilder builder,
            string namespace_,
            string partyId
        )
        {
            PublicPartyJoin op = builder.Build(
                namespace_,
                partyId
            );

            return ((Session.Wrapper.Party)builder.WrapperObject!).PublicPartyJoin(op);
        }

        public static Session.Model.ApimodelsPartySessionResponse<T1>? Execute<T1>(
            this PublicPartyJoin.PublicPartyJoinBuilder builder,
            string namespace_,
            string partyId
        )
        {
            PublicPartyJoin op = builder.Build(
                namespace_,
                partyId
            );

            return ((Session.Wrapper.Party)builder.WrapperObject!).PublicPartyJoin<T1>(op);
        }
        public static void Execute(
            this PublicPartyLeave.PublicPartyLeaveBuilder builder,
            string namespace_,
            string partyId
        )
        {
            PublicPartyLeave op = builder.Build(
                namespace_,
                partyId
            );

            ((Session.Wrapper.Party)builder.WrapperObject!).PublicPartyLeave(op);
        }
        public static void Execute(
            this PublicPartyReject.PublicPartyRejectBuilder builder,
            string namespace_,
            string partyId
        )
        {
            PublicPartyReject op = builder.Build(
                namespace_,
                partyId
            );

            ((Session.Wrapper.Party)builder.WrapperObject!).PublicPartyReject(op);
        }
        public static Session.Model.ApimodelsKickResponse? Execute(
            this PublicPartyKick.PublicPartyKickBuilder builder,
            string namespace_,
            string partyId,
            string userId
        )
        {
            PublicPartyKick op = builder.Build(
                namespace_,
                partyId,
                userId
            );

            return ((Session.Wrapper.Party)builder.WrapperObject!).PublicPartyKick(op);
        }
        public static Session.Model.ApimodelsPartySessionResponse? Execute(
            this PublicCreateParty.PublicCreatePartyBuilder builder,
            ApimodelsCreatePartyRequest body,
            string namespace_
        )
        {
            PublicCreateParty op = builder.Build(
                body,
                namespace_
            );

            return ((Session.Wrapper.Party)builder.WrapperObject!).PublicCreateParty(op);
        }

        public static Session.Model.ApimodelsPartySessionResponse<T1>? Execute<T1>(
            this PublicCreateParty.PublicCreatePartyBuilder builder,
            ApimodelsCreatePartyRequest body,
            string namespace_
        )
        {
            PublicCreateParty op = builder.Build(
                body,
                namespace_
            );

            return ((Session.Wrapper.Party)builder.WrapperObject!).PublicCreateParty<T1>(op);
        }
        public static List<Session.Model.ApimodelsPartySessionResponse>? Execute(
            this PublicQueryMyParties.PublicQueryMyPartiesBuilder builder,
            string namespace_
        )
        {
            PublicQueryMyParties op = builder.Build(
                namespace_
            );

            return ((Session.Wrapper.Party)builder.WrapperObject!).PublicQueryMyParties(op);
        }

        public static List<Session.Model.ApimodelsPartySessionResponse<T1>>? Execute<T1>(
            this PublicQueryMyParties.PublicQueryMyPartiesBuilder builder,
            string namespace_
        )
        {
            PublicQueryMyParties op = builder.Build(
                namespace_
            );

            return ((Session.Wrapper.Party)builder.WrapperObject!).PublicQueryMyParties<T1>(op);
        }
    }
}