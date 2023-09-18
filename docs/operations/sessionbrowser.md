# Sessionbrowser Service Index

&nbsp;

## Operations

### Session Wrapper:  [Session](../../apis/AccelByte.Sdk.Api.Sessionbrowser/Wrapper/Session.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/sessionbrowser/admin/namespaces/{namespace}/gamesession` | GET | AdminQuerySession | [AdminQuerySession](../../apis/AccelByte.Sdk.Api.Sessionbrowser/Operation/Session/AdminQuerySession.cs) | [AdminQuerySession](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionbrowser/Session/AdminQuerySession.cs) |
| `/sessionbrowser/admin/namespaces/{namespace}/gamesession/active/count` | GET | GetTotalActiveSession | [GetTotalActiveSession](../../apis/AccelByte.Sdk.Api.Sessionbrowser/Operation/Session/GetTotalActiveSession.cs) | [GetTotalActiveSession](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionbrowser/Session/GetTotalActiveSession.cs) |
| `/sessionbrowser/admin/namespaces/{namespace}/gamesession/active/custom-game` | GET | GetActiveCustomGameSessions | [GetActiveCustomGameSessions](../../apis/AccelByte.Sdk.Api.Sessionbrowser/Operation/Session/GetActiveCustomGameSessions.cs) | [GetActiveCustomGameSessions](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionbrowser/Session/GetActiveCustomGameSessions.cs) |
| `/sessionbrowser/admin/namespaces/{namespace}/gamesession/active/matchmaking-game` | GET | GetActiveMatchmakingGameSessions | [GetActiveMatchmakingGameSessions](../../apis/AccelByte.Sdk.Api.Sessionbrowser/Operation/Session/GetActiveMatchmakingGameSessions.cs) | [GetActiveMatchmakingGameSessions](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionbrowser/Session/GetActiveMatchmakingGameSessions.cs) |
| `/sessionbrowser/admin/namespaces/{namespace}/gamesession/{sessionID}` | GET | AdminGetSession | [AdminGetSession](../../apis/AccelByte.Sdk.Api.Sessionbrowser/Operation/Session/AdminGetSession.cs) | [AdminGetSession](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionbrowser/Session/AdminGetSession.cs) |
| `/sessionbrowser/admin/namespaces/{namespace}/gamesession/{sessionID}` | DELETE | AdminDeleteSession | [AdminDeleteSession](../../apis/AccelByte.Sdk.Api.Sessionbrowser/Operation/Session/AdminDeleteSession.cs) | [AdminDeleteSession](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionbrowser/Session/AdminDeleteSession.cs) |
| `/sessionbrowser/admin/namespaces/{namespace}/sessions/history/search` | GET | AdminSearchSessionsV2 | [AdminSearchSessionsV2](../../apis/AccelByte.Sdk.Api.Sessionbrowser/Operation/Session/AdminSearchSessionsV2.cs) | [AdminSearchSessionsV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionbrowser/Session/AdminSearchSessionsV2.cs) |
| `/sessionbrowser/admin/namespaces/{namespace}/sessions/{matchID}/history/detailed` | GET | GetSessionHistoryDetailed | [GetSessionHistoryDetailed](../../apis/AccelByte.Sdk.Api.Sessionbrowser/Operation/Session/GetSessionHistoryDetailed.cs) | [GetSessionHistoryDetailed](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionbrowser/Session/GetSessionHistoryDetailed.cs) |
| `/sessionbrowser/namespaces/{namespace}/gamesession` | GET | UserQuerySession | [UserQuerySession](../../apis/AccelByte.Sdk.Api.Sessionbrowser/Operation/Session/UserQuerySession.cs) | [UserQuerySession](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionbrowser/Session/UserQuerySession.cs) |
| `/sessionbrowser/namespaces/{namespace}/gamesession` | POST | CreateSession | [CreateSession](../../apis/AccelByte.Sdk.Api.Sessionbrowser/Operation/Session/CreateSession.cs) | [CreateSession](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionbrowser/Session/CreateSession.cs) |
| `/sessionbrowser/namespaces/{namespace}/gamesession/bulk` | GET | GetSessionByUserIDs | [GetSessionByUserIDs](../../apis/AccelByte.Sdk.Api.Sessionbrowser/Operation/Session/GetSessionByUserIDs.cs) | [GetSessionByUserIDs](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionbrowser/Session/GetSessionByUserIDs.cs) |
| `/sessionbrowser/namespaces/{namespace}/gamesession/{sessionID}` | GET | GetSession | [GetSession](../../apis/AccelByte.Sdk.Api.Sessionbrowser/Operation/Session/GetSession.cs) | [GetSession](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionbrowser/Session/GetSession.cs) |
| `/sessionbrowser/namespaces/{namespace}/gamesession/{sessionID}` | PUT | UpdateSession | [UpdateSession](../../apis/AccelByte.Sdk.Api.Sessionbrowser/Operation/Session/UpdateSession.cs) | [UpdateSession](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionbrowser/Session/UpdateSession.cs) |
| `/sessionbrowser/namespaces/{namespace}/gamesession/{sessionID}` | DELETE | DeleteSession | [DeleteSession](../../apis/AccelByte.Sdk.Api.Sessionbrowser/Operation/Session/DeleteSession.cs) | [DeleteSession](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionbrowser/Session/DeleteSession.cs) |
| `/sessionbrowser/namespaces/{namespace}/gamesession/{sessionID}/join` | POST | JoinSession | [JoinSession](../../apis/AccelByte.Sdk.Api.Sessionbrowser/Operation/Session/JoinSession.cs) | [JoinSession](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionbrowser/Session/JoinSession.cs) |
| `/sessionbrowser/namespaces/{namespace}/gamesession/{sessionID}/localds` | DELETE | DeleteSessionLocalDS | [DeleteSessionLocalDS](../../apis/AccelByte.Sdk.Api.Sessionbrowser/Operation/Session/DeleteSessionLocalDS.cs) | [DeleteSessionLocalDS](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionbrowser/Session/DeleteSessionLocalDS.cs) |
| `/sessionbrowser/namespaces/{namespace}/gamesession/{sessionID}/player` | POST | AddPlayerToSession | [AddPlayerToSession](../../apis/AccelByte.Sdk.Api.Sessionbrowser/Operation/Session/AddPlayerToSession.cs) | [AddPlayerToSession](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionbrowser/Session/AddPlayerToSession.cs) |
| `/sessionbrowser/namespaces/{namespace}/gamesession/{sessionID}/player/{userID}` | DELETE | RemovePlayerFromSession | [RemovePlayerFromSession](../../apis/AccelByte.Sdk.Api.Sessionbrowser/Operation/Session/RemovePlayerFromSession.cs) | [RemovePlayerFromSession](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionbrowser/Session/RemovePlayerFromSession.cs) |
| `/sessionbrowser/namespaces/{namespace}/gamesession/{sessionID}/settings` | PUT | UpdateSettings | [UpdateSettings](../../apis/AccelByte.Sdk.Api.Sessionbrowser/Operation/Session/UpdateSettings.cs) | [UpdateSettings](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionbrowser/Session/UpdateSettings.cs) |
| `/sessionbrowser/namespaces/{namespace}/recentplayer/{userID}` | GET | GetRecentPlayer | [GetRecentPlayer](../../apis/AccelByte.Sdk.Api.Sessionbrowser/Operation/Session/GetRecentPlayer.cs) | [GetRecentPlayer](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionbrowser/Session/GetRecentPlayer.cs) |


&nbsp;

## Operations with Generic Response

### Session Wrapper:  [Session](../../apis/AccelByte.Sdk.Api.Sessionbrowser/Wrapper/Session.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|


&nbsp;

## Models

| Model | Class |
|---|---|
| `models.ActiveCustomGameResponse` | [ModelsActiveCustomGameResponse](../../apis/AccelByte.Sdk.Api.Sessionbrowser/Model/ModelsActiveCustomGameResponse.cs) |
| `models.ActiveMatchmakingGameResponse` | [ModelsActiveMatchmakingGameResponse](../../apis/AccelByte.Sdk.Api.Sessionbrowser/Model/ModelsActiveMatchmakingGameResponse.cs) |
| `models.AddPlayerRequest` | [ModelsAddPlayerRequest](../../apis/AccelByte.Sdk.Api.Sessionbrowser/Model/ModelsAddPlayerRequest.cs) |
| `models.AddPlayerResponse` | [ModelsAddPlayerResponse](../../apis/AccelByte.Sdk.Api.Sessionbrowser/Model/ModelsAddPlayerResponse.cs) |
| `models.AdminSessionResponse` | [ModelsAdminSessionResponse](../../apis/AccelByte.Sdk.Api.Sessionbrowser/Model/ModelsAdminSessionResponse.cs) |
| `models.CountActiveSessionResponse` | [ModelsCountActiveSessionResponse](../../apis/AccelByte.Sdk.Api.Sessionbrowser/Model/ModelsCountActiveSessionResponse.cs) |
| `models.CreateSessionRequest` | [ModelsCreateSessionRequest](../../apis/AccelByte.Sdk.Api.Sessionbrowser/Model/ModelsCreateSessionRequest.cs) |
| `models.CustomGameResponse` | [ModelsCustomGameResponse](../../apis/AccelByte.Sdk.Api.Sessionbrowser/Model/ModelsCustomGameResponse.cs) |
| `models.GameSession` | [ModelsGameSession](../../apis/AccelByte.Sdk.Api.Sessionbrowser/Model/ModelsGameSession.cs) |
| `models.GameSessionSetting` | [ModelsGameSessionSetting](../../apis/AccelByte.Sdk.Api.Sessionbrowser/Model/ModelsGameSessionSetting.cs) |
| `models.GetSessionHistoryDetailedResponseItem` | [ModelsGetSessionHistoryDetailedResponseItem](../../apis/AccelByte.Sdk.Api.Sessionbrowser/Model/ModelsGetSessionHistoryDetailedResponseItem.cs) |
| `models.GetSessionHistorySearchResponseItemV2` | [ModelsGetSessionHistorySearchResponseItemV2](../../apis/AccelByte.Sdk.Api.Sessionbrowser/Model/ModelsGetSessionHistorySearchResponseItemV2.cs) |
| `models.GetSessionHistorySearchResponseV2` | [ModelsGetSessionHistorySearchResponseV2](../../apis/AccelByte.Sdk.Api.Sessionbrowser/Model/ModelsGetSessionHistorySearchResponseV2.cs) |
| `models.JoinGameSessionRequest` | [ModelsJoinGameSessionRequest](../../apis/AccelByte.Sdk.Api.Sessionbrowser/Model/ModelsJoinGameSessionRequest.cs) |
| `models.MatchAttributes` | [ModelsMatchAttributes](../../apis/AccelByte.Sdk.Api.Sessionbrowser/Model/ModelsMatchAttributes.cs) |
| `models.MatchMaking` | [ModelsMatchMaking](../../apis/AccelByte.Sdk.Api.Sessionbrowser/Model/ModelsMatchMaking.cs) |
| `models.MatchingAlly` | [ModelsMatchingAlly](../../apis/AccelByte.Sdk.Api.Sessionbrowser/Model/ModelsMatchingAlly.cs) |
| `models.MatchingParty` | [ModelsMatchingParty](../../apis/AccelByte.Sdk.Api.Sessionbrowser/Model/ModelsMatchingParty.cs) |
| `models.Pagination` | [ModelsPagination](../../apis/AccelByte.Sdk.Api.Sessionbrowser/Model/ModelsPagination.cs) |
| `models.PagingCursor` | [ModelsPagingCursor](../../apis/AccelByte.Sdk.Api.Sessionbrowser/Model/ModelsPagingCursor.cs) |
| `models.PartyMember` | [ModelsPartyMember](../../apis/AccelByte.Sdk.Api.Sessionbrowser/Model/ModelsPartyMember.cs) |
| `models.RecentPlayerHistory` | [ModelsRecentPlayerHistory](../../apis/AccelByte.Sdk.Api.Sessionbrowser/Model/ModelsRecentPlayerHistory.cs) |
| `models.RecentPlayerQueryResponse` | [ModelsRecentPlayerQueryResponse](../../apis/AccelByte.Sdk.Api.Sessionbrowser/Model/ModelsRecentPlayerQueryResponse.cs) |
| `models.Server` | [ModelsServer](../../apis/AccelByte.Sdk.Api.Sessionbrowser/Model/ModelsServer.cs) |
| `models.SessionByUserIDsResponse` | [ModelsSessionByUserIDsResponse](../../apis/AccelByte.Sdk.Api.Sessionbrowser/Model/ModelsSessionByUserIDsResponse.cs) |
| `models.SessionPlayerHistory` | [ModelsSessionPlayerHistory](../../apis/AccelByte.Sdk.Api.Sessionbrowser/Model/ModelsSessionPlayerHistory.cs) |
| `models.SessionPlayerJoining` | [ModelsSessionPlayerJoining](../../apis/AccelByte.Sdk.Api.Sessionbrowser/Model/ModelsSessionPlayerJoining.cs) |
| `models.SessionQueryResponse` | [ModelsSessionQueryResponse](../../apis/AccelByte.Sdk.Api.Sessionbrowser/Model/ModelsSessionQueryResponse.cs) |
| `models.SessionResponse` | [ModelsSessionResponse](../../apis/AccelByte.Sdk.Api.Sessionbrowser/Model/ModelsSessionResponse.cs) |
| `models.StatusHistory` | [ModelsStatusHistory](../../apis/AccelByte.Sdk.Api.Sessionbrowser/Model/ModelsStatusHistory.cs) |
| `models.UpdateSessionRequest` | [ModelsUpdateSessionRequest](../../apis/AccelByte.Sdk.Api.Sessionbrowser/Model/ModelsUpdateSessionRequest.cs) |
| `models.UpdateSettingsRequest` | [ModelsUpdateSettingsRequest](../../apis/AccelByte.Sdk.Api.Sessionbrowser/Model/ModelsUpdateSettingsRequest.cs) |
| `response.Error` | [ResponseError](../../apis/AccelByte.Sdk.Api.Sessionbrowser/Model/ResponseError.cs) |
| `restapi.ErrorResponseV2` | [RestapiErrorResponseV2](../../apis/AccelByte.Sdk.Api.Sessionbrowser/Model/RestapiErrorResponseV2.cs) |
| `restapi.ErrorV1` | [RestapiErrorV1](../../apis/AccelByte.Sdk.Api.Sessionbrowser/Model/RestapiErrorV1.cs) |