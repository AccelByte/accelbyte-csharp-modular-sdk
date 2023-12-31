// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Sessionbrowser.Model;
using AccelByte.Sdk.Api.Sessionbrowser.Operation;

namespace AccelByte.Sdk.Api.Sessionbrowser.Wrapper
{
    public class Session
    {
        private readonly IAccelByteSdk _sdk;

        public Session(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminQuerySession.AdminQuerySessionBuilder AdminQuerySessionOp
        {
            get { return new Operation.AdminQuerySession.AdminQuerySessionBuilder(_sdk); }
        }
        public GetTotalActiveSession.GetTotalActiveSessionBuilder GetTotalActiveSessionOp
        {
            get { return new Operation.GetTotalActiveSession.GetTotalActiveSessionBuilder(_sdk); }
        }
        public GetActiveCustomGameSessions.GetActiveCustomGameSessionsBuilder GetActiveCustomGameSessionsOp
        {
            get { return new Operation.GetActiveCustomGameSessions.GetActiveCustomGameSessionsBuilder(_sdk); }
        }
        public GetActiveMatchmakingGameSessions.GetActiveMatchmakingGameSessionsBuilder GetActiveMatchmakingGameSessionsOp
        {
            get { return new Operation.GetActiveMatchmakingGameSessions.GetActiveMatchmakingGameSessionsBuilder(_sdk); }
        }
        public AdminGetSession.AdminGetSessionBuilder AdminGetSessionOp
        {
            get { return new Operation.AdminGetSession.AdminGetSessionBuilder(_sdk); }
        }
        public AdminDeleteSession.AdminDeleteSessionBuilder AdminDeleteSessionOp
        {
            get { return new Operation.AdminDeleteSession.AdminDeleteSessionBuilder(_sdk); }
        }
        public AdminSearchSessionsV2.AdminSearchSessionsV2Builder AdminSearchSessionsV2Op
        {
            get { return new Operation.AdminSearchSessionsV2.AdminSearchSessionsV2Builder(_sdk); }
        }
        public GetSessionHistoryDetailed.GetSessionHistoryDetailedBuilder GetSessionHistoryDetailedOp
        {
            get { return new Operation.GetSessionHistoryDetailed.GetSessionHistoryDetailedBuilder(_sdk); }
        }
        public UserQuerySession.UserQuerySessionBuilder UserQuerySessionOp
        {
            get { return new Operation.UserQuerySession.UserQuerySessionBuilder(_sdk); }
        }
        public CreateSession.CreateSessionBuilder CreateSessionOp
        {
            get { return new Operation.CreateSession.CreateSessionBuilder(_sdk); }
        }
        public GetSessionByUserIDs.GetSessionByUserIDsBuilder GetSessionByUserIDsOp
        {
            get { return new Operation.GetSessionByUserIDs.GetSessionByUserIDsBuilder(_sdk); }
        }
        public GetSession.GetSessionBuilder GetSessionOp
        {
            get { return new Operation.GetSession.GetSessionBuilder(_sdk); }
        }
        public UpdateSession.UpdateSessionBuilder UpdateSessionOp
        {
            get { return new Operation.UpdateSession.UpdateSessionBuilder(_sdk); }
        }
        public DeleteSession.DeleteSessionBuilder DeleteSessionOp
        {
            get { return new Operation.DeleteSession.DeleteSessionBuilder(_sdk); }
        }
        public JoinSession.JoinSessionBuilder JoinSessionOp
        {
            get { return new Operation.JoinSession.JoinSessionBuilder(_sdk); }
        }
        public DeleteSessionLocalDS.DeleteSessionLocalDSBuilder DeleteSessionLocalDSOp
        {
            get { return new Operation.DeleteSessionLocalDS.DeleteSessionLocalDSBuilder(_sdk); }
        }
        public AddPlayerToSession.AddPlayerToSessionBuilder AddPlayerToSessionOp
        {
            get { return new Operation.AddPlayerToSession.AddPlayerToSessionBuilder(_sdk); }
        }
        public RemovePlayerFromSession.RemovePlayerFromSessionBuilder RemovePlayerFromSessionOp
        {
            get { return new Operation.RemovePlayerFromSession.RemovePlayerFromSessionBuilder(_sdk); }
        }
        public UpdateSettings.UpdateSettingsBuilder UpdateSettingsOp
        {
            get { return new Operation.UpdateSettings.UpdateSettingsBuilder(_sdk); }
        }
        public GetRecentPlayer.GetRecentPlayerBuilder GetRecentPlayerOp
        {
            get { return new Operation.GetRecentPlayer.GetRecentPlayerBuilder(_sdk); }
        }
        #endregion

        public Model.ModelsSessionQueryResponse? AdminQuerySession(AdminQuerySession input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsCountActiveSessionResponse? GetTotalActiveSession(GetTotalActiveSession input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsActiveCustomGameResponse? GetActiveCustomGameSessions(GetActiveCustomGameSessions input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsActiveMatchmakingGameResponse? GetActiveMatchmakingGameSessions(GetActiveMatchmakingGameSessions input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsAdminSessionResponse? AdminGetSession(AdminGetSession input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsAdminSessionResponse? AdminDeleteSession(AdminDeleteSession input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetSessionHistorySearchResponseV2? AdminSearchSessionsV2(AdminSearchSessionsV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ModelsGetSessionHistoryDetailedResponseItem>? GetSessionHistoryDetailed(GetSessionHistoryDetailed input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsSessionQueryResponse? UserQuerySession(UserQuerySession input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsSessionResponse? CreateSession(CreateSession input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsSessionByUserIDsResponse? GetSessionByUserIDs(GetSessionByUserIDs input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsSessionResponse? GetSession(GetSession input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsSessionResponse? UpdateSession(UpdateSession input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsSessionResponse? DeleteSession(DeleteSession input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsSessionResponse? JoinSession(JoinSession input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsSessionResponse? DeleteSessionLocalDS(DeleteSessionLocalDS input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsAddPlayerResponse? AddPlayerToSession(AddPlayerToSession input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsAddPlayerResponse? RemovePlayerFromSession(RemovePlayerFromSession input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsSessionResponse? UpdateSettings(UpdateSettings input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsRecentPlayerQueryResponse? GetRecentPlayer(GetRecentPlayer input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}