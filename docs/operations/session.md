# Session Service Index

&nbsp;

## Operations

### Operations Wrapper:  [Operations](../../apis/AccelByte.Sdk.Api.Session/Wrapper/Operations.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/healthz` | GET | GetHealthcheckInfo | [GetHealthcheckInfo](../../apis/AccelByte.Sdk.Api.Session/Operation/Operations/GetHealthcheckInfo.cs) | [GetHealthcheckInfo](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Operations/GetHealthcheckInfo.cs) |
| `/session/healthz` | GET | GetHealthcheckInfoV1 | [GetHealthcheckInfoV1](../../apis/AccelByte.Sdk.Api.Session/Operation/Operations/GetHealthcheckInfoV1.cs) | [GetHealthcheckInfoV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Operations/GetHealthcheckInfoV1.cs) |

### DSMC Default Configuration Wrapper:  [DSMCDefaultConfiguration](../../apis/AccelByte.Sdk.Api.Session/Wrapper/DSMCDefaultConfiguration.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/session/v1/admin/dsconfigs/default` | GET | AdminGetDSMCConfigurationDefault | [AdminGetDSMCConfigurationDefault](../../apis/AccelByte.Sdk.Api.Session/Operation/DSMCDefaultConfiguration/AdminGetDSMCConfigurationDefault.cs) | [AdminGetDSMCConfigurationDefault](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/DSMCDefaultConfiguration/AdminGetDSMCConfigurationDefault.cs) |

### Environment Variable Wrapper:  [EnvironmentVariable](../../apis/AccelByte.Sdk.Api.Session/Wrapper/EnvironmentVariable.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/session/v1/admin/environment-variables` | GET | AdminListEnvironmentVariables | [AdminListEnvironmentVariables](../../apis/AccelByte.Sdk.Api.Session/Operation/EnvironmentVariable/AdminListEnvironmentVariables.cs) | [AdminListEnvironmentVariables](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/EnvironmentVariable/AdminListEnvironmentVariables.cs) |

### Configuration Template Wrapper:  [ConfigurationTemplate](../../apis/AccelByte.Sdk.Api.Session/Wrapper/ConfigurationTemplate.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/session/v1/admin/namespaces/{namespace}/alerts-configuration` | GET | AdminGetConfigurationAlertV1 | [AdminGetConfigurationAlertV1](../../apis/AccelByte.Sdk.Api.Session/Operation/ConfigurationTemplate/AdminGetConfigurationAlertV1.cs) | [AdminGetConfigurationAlertV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/ConfigurationTemplate/AdminGetConfigurationAlertV1.cs) |
| `/session/v1/admin/namespaces/{namespace}/alerts-configuration` | PUT | AdminUpdateConfigurationAlertV1 | [AdminUpdateConfigurationAlertV1](../../apis/AccelByte.Sdk.Api.Session/Operation/ConfigurationTemplate/AdminUpdateConfigurationAlertV1.cs) | [AdminUpdateConfigurationAlertV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/ConfigurationTemplate/AdminUpdateConfigurationAlertV1.cs) |
| `/session/v1/admin/namespaces/{namespace}/alerts-configuration` | POST | AdminCreateConfigurationAlertV1 | [AdminCreateConfigurationAlertV1](../../apis/AccelByte.Sdk.Api.Session/Operation/ConfigurationTemplate/AdminCreateConfigurationAlertV1.cs) | [AdminCreateConfigurationAlertV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/ConfigurationTemplate/AdminCreateConfigurationAlertV1.cs) |
| `/session/v1/admin/namespaces/{namespace}/alerts-configuration` | DELETE | AdminDeleteConfigurationAlertV1 | [AdminDeleteConfigurationAlertV1](../../apis/AccelByte.Sdk.Api.Session/Operation/ConfigurationTemplate/AdminDeleteConfigurationAlertV1.cs) | [AdminDeleteConfigurationAlertV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/ConfigurationTemplate/AdminDeleteConfigurationAlertV1.cs) |
| `/session/v1/admin/namespaces/{namespace}/configuration` | POST | AdminCreateConfigurationTemplateV1 | [AdminCreateConfigurationTemplateV1](../../apis/AccelByte.Sdk.Api.Session/Operation/ConfigurationTemplate/AdminCreateConfigurationTemplateV1.cs) | [AdminCreateConfigurationTemplateV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/ConfigurationTemplate/AdminCreateConfigurationTemplateV1.cs) |
| `/session/v1/admin/namespaces/{namespace}/configurations` | GET | AdminGetAllConfigurationTemplatesV1 | [AdminGetAllConfigurationTemplatesV1](../../apis/AccelByte.Sdk.Api.Session/Operation/ConfigurationTemplate/AdminGetAllConfigurationTemplatesV1.cs) | [AdminGetAllConfigurationTemplatesV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/ConfigurationTemplate/AdminGetAllConfigurationTemplatesV1.cs) |
| `/session/v1/admin/namespaces/{namespace}/configurations/{name}` | GET | AdminGetConfigurationTemplateV1 | [AdminGetConfigurationTemplateV1](../../apis/AccelByte.Sdk.Api.Session/Operation/ConfigurationTemplate/AdminGetConfigurationTemplateV1.cs) | [AdminGetConfigurationTemplateV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/ConfigurationTemplate/AdminGetConfigurationTemplateV1.cs) |
| `/session/v1/admin/namespaces/{namespace}/configurations/{name}` | PUT | AdminUpdateConfigurationTemplateV1 | [AdminUpdateConfigurationTemplateV1](../../apis/AccelByte.Sdk.Api.Session/Operation/ConfigurationTemplate/AdminUpdateConfigurationTemplateV1.cs) | [AdminUpdateConfigurationTemplateV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/ConfigurationTemplate/AdminUpdateConfigurationTemplateV1.cs) |
| `/session/v1/admin/namespaces/{namespace}/configurations/{name}` | DELETE | AdminDeleteConfigurationTemplateV1 | [AdminDeleteConfigurationTemplateV1](../../apis/AccelByte.Sdk.Api.Session/Operation/ConfigurationTemplate/AdminDeleteConfigurationTemplateV1.cs) | [AdminDeleteConfigurationTemplateV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/ConfigurationTemplate/AdminDeleteConfigurationTemplateV1.cs) |
| `/session/v1/admin/namespaces/{namespace}/dsconfigs` | GET | AdminGetDSMCConfiguration | [AdminGetDSMCConfiguration](../../apis/AccelByte.Sdk.Api.Session/Operation/ConfigurationTemplate/AdminGetDSMCConfiguration.cs) | [AdminGetDSMCConfiguration](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/ConfigurationTemplate/AdminGetDSMCConfiguration.cs) |
| `/session/v1/admin/namespaces/{namespace}/dsconfigs/sync` | GET | AdminSyncDSMCConfiguration | [AdminSyncDSMCConfiguration](../../apis/AccelByte.Sdk.Api.Session/Operation/ConfigurationTemplate/AdminSyncDSMCConfiguration.cs) | [AdminSyncDSMCConfiguration](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/ConfigurationTemplate/AdminSyncDSMCConfiguration.cs) |

### Game Session Wrapper:  [GameSession](../../apis/AccelByte.Sdk.Api.Session/Wrapper/GameSession.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/session/v1/admin/namespaces/{namespace}/gamesessions` | GET | AdminQueryGameSessions | [AdminQueryGameSessions](../../apis/AccelByte.Sdk.Api.Session/Operation/GameSession/AdminQueryGameSessions.cs) | [AdminQueryGameSessions](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/AdminQueryGameSessions.cs) |
| `/session/v1/admin/namespaces/{namespace}/gamesessions/bulk` | DELETE | AdminDeleteBulkGameSessions | [AdminDeleteBulkGameSessions](../../apis/AccelByte.Sdk.Api.Session/Operation/GameSession/AdminDeleteBulkGameSessions.cs) | [AdminDeleteBulkGameSessions](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/AdminDeleteBulkGameSessions.cs) |
| `/session/v1/admin/namespaces/{namespace}/gamesessions/{sessionId}/members/{memberId}/status/{statusType}` | PUT | AdminUpdateGameSessionMember | [AdminUpdateGameSessionMember](../../apis/AccelByte.Sdk.Api.Session/Operation/GameSession/AdminUpdateGameSessionMember.cs) | [AdminUpdateGameSessionMember](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/AdminUpdateGameSessionMember.cs) |
| `/session/v1/public/namespaces/{namespace}/gamesession` | POST | CreateGameSession | [CreateGameSession](../../apis/AccelByte.Sdk.Api.Session/Operation/GameSession/CreateGameSession.cs) | [CreateGameSession](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/CreateGameSession.cs) |
| `/session/v1/public/namespaces/{namespace}/gamesessions` | POST | PublicQueryGameSessions | [PublicQueryGameSessions](../../apis/AccelByte.Sdk.Api.Session/Operation/GameSession/PublicQueryGameSessions.cs) | [PublicQueryGameSessions](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/PublicQueryGameSessions.cs) |
| `/session/v1/public/namespaces/{namespace}/gamesessions/join/code` | POST | PublicSessionJoinCode | [PublicSessionJoinCode](../../apis/AccelByte.Sdk.Api.Session/Operation/GameSession/PublicSessionJoinCode.cs) | [PublicSessionJoinCode](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/PublicSessionJoinCode.cs) |
| `/session/v1/public/namespaces/{namespace}/gamesessions/servers/{podName}` | GET | GetGameSessionByPodName | [GetGameSessionByPodName](../../apis/AccelByte.Sdk.Api.Session/Operation/GameSession/GetGameSessionByPodName.cs) | [GetGameSessionByPodName](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/GetGameSessionByPodName.cs) |
| `/session/v1/public/namespaces/{namespace}/gamesessions/{sessionId}` | GET | GetGameSession | [GetGameSession](../../apis/AccelByte.Sdk.Api.Session/Operation/GameSession/GetGameSession.cs) | [GetGameSession](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/GetGameSession.cs) |
| `/session/v1/public/namespaces/{namespace}/gamesessions/{sessionId}` | PUT | UpdateGameSession | [UpdateGameSession](../../apis/AccelByte.Sdk.Api.Session/Operation/GameSession/UpdateGameSession.cs) | [UpdateGameSession](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/UpdateGameSession.cs) |
| `/session/v1/public/namespaces/{namespace}/gamesessions/{sessionId}` | DELETE | DeleteGameSession | [DeleteGameSession](../../apis/AccelByte.Sdk.Api.Session/Operation/GameSession/DeleteGameSession.cs) | [DeleteGameSession](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/DeleteGameSession.cs) |
| `/session/v1/public/namespaces/{namespace}/gamesessions/{sessionId}` | PATCH | PatchUpdateGameSession | [PatchUpdateGameSession](../../apis/AccelByte.Sdk.Api.Session/Operation/GameSession/PatchUpdateGameSession.cs) | [PatchUpdateGameSession](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/PatchUpdateGameSession.cs) |
| `/session/v1/public/namespaces/{namespace}/gamesessions/{sessionId}/backfill` | PUT | UpdateGameSessionBackfillTicketID | [UpdateGameSessionBackfillTicketID](../../apis/AccelByte.Sdk.Api.Session/Operation/GameSession/UpdateGameSessionBackfillTicketID.cs) | [UpdateGameSessionBackfillTicketID](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/UpdateGameSessionBackfillTicketID.cs) |
| `/session/v1/public/namespaces/{namespace}/gamesessions/{sessionId}/code` | POST | GameSessionGenerateCode | [GameSessionGenerateCode](../../apis/AccelByte.Sdk.Api.Session/Operation/GameSession/GameSessionGenerateCode.cs) | [GameSessionGenerateCode](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/GameSessionGenerateCode.cs) |
| `/session/v1/public/namespaces/{namespace}/gamesessions/{sessionId}/code` | DELETE | PublicRevokeGameSessionCode | [PublicRevokeGameSessionCode](../../apis/AccelByte.Sdk.Api.Session/Operation/GameSession/PublicRevokeGameSessionCode.cs) | [PublicRevokeGameSessionCode](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/PublicRevokeGameSessionCode.cs) |
| `/session/v1/public/namespaces/{namespace}/gamesessions/{sessionId}/invite` | POST | PublicGameSessionInvite | [PublicGameSessionInvite](../../apis/AccelByte.Sdk.Api.Session/Operation/GameSession/PublicGameSessionInvite.cs) | [PublicGameSessionInvite](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/PublicGameSessionInvite.cs) |
| `/session/v1/public/namespaces/{namespace}/gamesessions/{sessionId}/join` | POST | JoinGameSession | [JoinGameSession](../../apis/AccelByte.Sdk.Api.Session/Operation/GameSession/JoinGameSession.cs) | [JoinGameSession](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/JoinGameSession.cs) |
| `/session/v1/public/namespaces/{namespace}/gamesessions/{sessionId}/leader` | POST | PublicPromoteGameSessionLeader | [PublicPromoteGameSessionLeader](../../apis/AccelByte.Sdk.Api.Session/Operation/GameSession/PublicPromoteGameSessionLeader.cs) | [PublicPromoteGameSessionLeader](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/PublicPromoteGameSessionLeader.cs) |
| `/session/v1/public/namespaces/{namespace}/gamesessions/{sessionId}/leave` | DELETE | LeaveGameSession | [LeaveGameSession](../../apis/AccelByte.Sdk.Api.Session/Operation/GameSession/LeaveGameSession.cs) | [LeaveGameSession](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/LeaveGameSession.cs) |
| `/session/v1/public/namespaces/{namespace}/gamesessions/{sessionId}/reject` | DELETE | PublicGameSessionReject | [PublicGameSessionReject](../../apis/AccelByte.Sdk.Api.Session/Operation/GameSession/PublicGameSessionReject.cs) | [PublicGameSessionReject](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/PublicGameSessionReject.cs) |
| `/session/v1/public/namespaces/{namespace}/gamesessions/{sessionId}/teams` | POST | AppendTeamGameSession | [AppendTeamGameSession](../../apis/AccelByte.Sdk.Api.Session/Operation/GameSession/AppendTeamGameSession.cs) | [AppendTeamGameSession](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/AppendTeamGameSession.cs) |
| `/session/v1/public/namespaces/{namespace}/users/me/gamesessions` | GET | PublicQueryMyGameSessions | [PublicQueryMyGameSessions](../../apis/AccelByte.Sdk.Api.Session/Operation/GameSession/PublicQueryMyGameSessions.cs) | [PublicQueryMyGameSessions](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/PublicQueryMyGameSessions.cs) |

### Party Wrapper:  [Party](../../apis/AccelByte.Sdk.Api.Session/Wrapper/Party.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/session/v1/admin/namespaces/{namespace}/parties` | GET | AdminQueryParties | [AdminQueryParties](../../apis/AccelByte.Sdk.Api.Session/Operation/Party/AdminQueryParties.cs) | [AdminQueryParties](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Party/AdminQueryParties.cs) |
| `/session/v1/public/namespaces/{namespace}/parties/users/me/join/code` | POST | PublicPartyJoinCode | [PublicPartyJoinCode](../../apis/AccelByte.Sdk.Api.Session/Operation/Party/PublicPartyJoinCode.cs) | [PublicPartyJoinCode](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Party/PublicPartyJoinCode.cs) |
| `/session/v1/public/namespaces/{namespace}/parties/{partyId}` | GET | PublicGetParty | [PublicGetParty](../../apis/AccelByte.Sdk.Api.Session/Operation/Party/PublicGetParty.cs) | [PublicGetParty](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Party/PublicGetParty.cs) |
| `/session/v1/public/namespaces/{namespace}/parties/{partyId}` | PUT | PublicUpdateParty | [PublicUpdateParty](../../apis/AccelByte.Sdk.Api.Session/Operation/Party/PublicUpdateParty.cs) | [PublicUpdateParty](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Party/PublicUpdateParty.cs) |
| `/session/v1/public/namespaces/{namespace}/parties/{partyId}` | PATCH | PublicPatchUpdateParty | [PublicPatchUpdateParty](../../apis/AccelByte.Sdk.Api.Session/Operation/Party/PublicPatchUpdateParty.cs) | [PublicPatchUpdateParty](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Party/PublicPatchUpdateParty.cs) |
| `/session/v1/public/namespaces/{namespace}/parties/{partyId}/code` | POST | PublicGeneratePartyCode | [PublicGeneratePartyCode](../../apis/AccelByte.Sdk.Api.Session/Operation/Party/PublicGeneratePartyCode.cs) | [PublicGeneratePartyCode](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Party/PublicGeneratePartyCode.cs) |
| `/session/v1/public/namespaces/{namespace}/parties/{partyId}/code` | DELETE | PublicRevokePartyCode | [PublicRevokePartyCode](../../apis/AccelByte.Sdk.Api.Session/Operation/Party/PublicRevokePartyCode.cs) | [PublicRevokePartyCode](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Party/PublicRevokePartyCode.cs) |
| `/session/v1/public/namespaces/{namespace}/parties/{partyId}/invite` | POST | PublicPartyInvite | [PublicPartyInvite](../../apis/AccelByte.Sdk.Api.Session/Operation/Party/PublicPartyInvite.cs) | [PublicPartyInvite](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Party/PublicPartyInvite.cs) |
| `/session/v1/public/namespaces/{namespace}/parties/{partyId}/leader` | POST | PublicPromotePartyLeader | [PublicPromotePartyLeader](../../apis/AccelByte.Sdk.Api.Session/Operation/Party/PublicPromotePartyLeader.cs) | [PublicPromotePartyLeader](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Party/PublicPromotePartyLeader.cs) |
| `/session/v1/public/namespaces/{namespace}/parties/{partyId}/users/me/join` | POST | PublicPartyJoin | [PublicPartyJoin](../../apis/AccelByte.Sdk.Api.Session/Operation/Party/PublicPartyJoin.cs) | [PublicPartyJoin](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Party/PublicPartyJoin.cs) |
| `/session/v1/public/namespaces/{namespace}/parties/{partyId}/users/me/leave` | DELETE | PublicPartyLeave | [PublicPartyLeave](../../apis/AccelByte.Sdk.Api.Session/Operation/Party/PublicPartyLeave.cs) | [PublicPartyLeave](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Party/PublicPartyLeave.cs) |
| `/session/v1/public/namespaces/{namespace}/parties/{partyId}/users/me/reject` | DELETE | PublicPartyReject | [PublicPartyReject](../../apis/AccelByte.Sdk.Api.Session/Operation/Party/PublicPartyReject.cs) | [PublicPartyReject](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Party/PublicPartyReject.cs) |
| `/session/v1/public/namespaces/{namespace}/parties/{partyId}/users/{userId}/kick` | DELETE | PublicPartyKick | [PublicPartyKick](../../apis/AccelByte.Sdk.Api.Session/Operation/Party/PublicPartyKick.cs) | [PublicPartyKick](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Party/PublicPartyKick.cs) |
| `/session/v1/public/namespaces/{namespace}/party` | POST | PublicCreateParty | [PublicCreateParty](../../apis/AccelByte.Sdk.Api.Session/Operation/Party/PublicCreateParty.cs) | [PublicCreateParty](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Party/PublicCreateParty.cs) |
| `/session/v1/public/namespaces/{namespace}/users/me/parties` | GET | PublicQueryMyParties | [PublicQueryMyParties](../../apis/AccelByte.Sdk.Api.Session/Operation/Party/PublicQueryMyParties.cs) | [PublicQueryMyParties](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Party/PublicQueryMyParties.cs) |

### Platform Credential Wrapper:  [PlatformCredential](../../apis/AccelByte.Sdk.Api.Session/Wrapper/PlatformCredential.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/session/v1/admin/namespaces/{namespace}/platform-credentials` | GET | AdminGetPlatformCredentials | [AdminGetPlatformCredentials](../../apis/AccelByte.Sdk.Api.Session/Operation/PlatformCredential/AdminGetPlatformCredentials.cs) | [AdminGetPlatformCredentials](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/PlatformCredential/AdminGetPlatformCredentials.cs) |
| `/session/v1/admin/namespaces/{namespace}/platform-credentials` | PUT | AdminUpdatePlatformCredentials | [AdminUpdatePlatformCredentials](../../apis/AccelByte.Sdk.Api.Session/Operation/PlatformCredential/AdminUpdatePlatformCredentials.cs) | [AdminUpdatePlatformCredentials](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/PlatformCredential/AdminUpdatePlatformCredentials.cs) |
| `/session/v1/admin/namespaces/{namespace}/platform-credentials` | DELETE | AdminDeletePlatformCredentials | [AdminDeletePlatformCredentials](../../apis/AccelByte.Sdk.Api.Session/Operation/PlatformCredential/AdminDeletePlatformCredentials.cs) | [AdminDeletePlatformCredentials](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/PlatformCredential/AdminDeletePlatformCredentials.cs) |

### Session Storage Wrapper:  [SessionStorage](../../apis/AccelByte.Sdk.Api.Session/Wrapper/SessionStorage.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/session/v1/admin/namespaces/{namespace}/sessions/{sessionId}/storage` | GET | AdminReadSessionStorage | [AdminReadSessionStorage](../../apis/AccelByte.Sdk.Api.Session/Operation/SessionStorage/AdminReadSessionStorage.cs) | [AdminReadSessionStorage](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/SessionStorage/AdminReadSessionStorage.cs) |
| `/session/v1/admin/namespaces/{namespace}/sessions/{sessionId}/storage` | DELETE | AdminDeleteUserSessionStorage | [AdminDeleteUserSessionStorage](../../apis/AccelByte.Sdk.Api.Session/Operation/SessionStorage/AdminDeleteUserSessionStorage.cs) | [AdminDeleteUserSessionStorage](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/SessionStorage/AdminDeleteUserSessionStorage.cs) |
| `/session/v1/admin/namespaces/{namespace}/sessions/{sessionId}/storage/users/{userId}` | GET | AdminReadUserSessionStorage | [AdminReadUserSessionStorage](../../apis/AccelByte.Sdk.Api.Session/Operation/SessionStorage/AdminReadUserSessionStorage.cs) | [AdminReadUserSessionStorage](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/SessionStorage/AdminReadUserSessionStorage.cs) |
| `/session/v1/public/namespaces/{namespace}/sessions/{sessionId}/storage/leader` | PATCH | PublicUpdateInsertSessionStorageLeader | [PublicUpdateInsertSessionStorageLeader](../../apis/AccelByte.Sdk.Api.Session/Operation/SessionStorage/PublicUpdateInsertSessionStorageLeader.cs) | [PublicUpdateInsertSessionStorageLeader](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/SessionStorage/PublicUpdateInsertSessionStorageLeader.cs) |
| `/session/v1/public/namespaces/{namespace}/sessions/{sessionId}/storage/users/{userId}` | PATCH | PublicUpdateInsertSessionStorage | [PublicUpdateInsertSessionStorage](../../apis/AccelByte.Sdk.Api.Session/Operation/SessionStorage/PublicUpdateInsertSessionStorage.cs) | [PublicUpdateInsertSessionStorage](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/SessionStorage/PublicUpdateInsertSessionStorage.cs) |

### Player Wrapper:  [Player](../../apis/AccelByte.Sdk.Api.Session/Wrapper/Player.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/session/v1/admin/namespaces/{namespace}/users/attributes` | GET | AdminQueryPlayerAttributes | [AdminQueryPlayerAttributes](../../apis/AccelByte.Sdk.Api.Session/Operation/Player/AdminQueryPlayerAttributes.cs) | [AdminQueryPlayerAttributes](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Player/AdminQueryPlayerAttributes.cs) |
| `/session/v1/admin/namespaces/{namespace}/users/{userId}/attributes` | GET | AdminGetPlayerAttributes | [AdminGetPlayerAttributes](../../apis/AccelByte.Sdk.Api.Session/Operation/Player/AdminGetPlayerAttributes.cs) | [AdminGetPlayerAttributes](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Player/AdminGetPlayerAttributes.cs) |
| `/session/v1/public/namespaces/{namespace}/users/bulk/platform` | POST | PublicGetBulkPlayerCurrentPlatform | [PublicGetBulkPlayerCurrentPlatform](../../apis/AccelByte.Sdk.Api.Session/Operation/Player/PublicGetBulkPlayerCurrentPlatform.cs) | [PublicGetBulkPlayerCurrentPlatform](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Player/PublicGetBulkPlayerCurrentPlatform.cs) |
| `/session/v1/public/namespaces/{namespace}/users/me/attributes` | GET | PublicGetPlayerAttributes | [PublicGetPlayerAttributes](../../apis/AccelByte.Sdk.Api.Session/Operation/Player/PublicGetPlayerAttributes.cs) | [PublicGetPlayerAttributes](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Player/PublicGetPlayerAttributes.cs) |
| `/session/v1/public/namespaces/{namespace}/users/me/attributes` | POST | PublicStorePlayerAttributes | [PublicStorePlayerAttributes](../../apis/AccelByte.Sdk.Api.Session/Operation/Player/PublicStorePlayerAttributes.cs) | [PublicStorePlayerAttributes](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Player/PublicStorePlayerAttributes.cs) |
| `/session/v1/public/namespaces/{namespace}/users/me/attributes` | DELETE | PublicDeletePlayerAttributes | [PublicDeletePlayerAttributes](../../apis/AccelByte.Sdk.Api.Session/Operation/Player/PublicDeletePlayerAttributes.cs) | [PublicDeletePlayerAttributes](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Player/PublicDeletePlayerAttributes.cs) |


&nbsp;

## Operations with Generic Response

### Operations Wrapper:  [Operations](../../apis/AccelByte.Sdk.Api.Session/Wrapper/Operations.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### DSMC Default Configuration Wrapper:  [DSMCDefaultConfiguration](../../apis/AccelByte.Sdk.Api.Session/Wrapper/DSMCDefaultConfiguration.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Environment Variable Wrapper:  [EnvironmentVariable](../../apis/AccelByte.Sdk.Api.Session/Wrapper/EnvironmentVariable.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Configuration Template Wrapper:  [ConfigurationTemplate](../../apis/AccelByte.Sdk.Api.Session/Wrapper/ConfigurationTemplate.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Game Session Wrapper:  [GameSession](../../apis/AccelByte.Sdk.Api.Session/Wrapper/GameSession.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/session/v1/public/namespaces/{namespace}/gamesession` | POST | CreateGameSession | [CreateGameSession](../../apis/AccelByte.Sdk.Api.Session/Operation/GameSession/CreateGameSession.cs) | [CreateGameSession](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/CreateGameSession.cs) |
| `/session/v1/public/namespaces/{namespace}/gamesessions/join/code` | POST | PublicSessionJoinCode | [PublicSessionJoinCode](../../apis/AccelByte.Sdk.Api.Session/Operation/GameSession/PublicSessionJoinCode.cs) | [PublicSessionJoinCode](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/PublicSessionJoinCode.cs) |
| `/session/v1/public/namespaces/{namespace}/gamesessions/servers/{podName}` | GET | GetGameSessionByPodName | [GetGameSessionByPodName](../../apis/AccelByte.Sdk.Api.Session/Operation/GameSession/GetGameSessionByPodName.cs) | [GetGameSessionByPodName](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/GetGameSessionByPodName.cs) |
| `/session/v1/public/namespaces/{namespace}/gamesessions/{sessionId}` | GET | GetGameSession | [GetGameSession](../../apis/AccelByte.Sdk.Api.Session/Operation/GameSession/GetGameSession.cs) | [GetGameSession](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/GetGameSession.cs) |
| `/session/v1/public/namespaces/{namespace}/gamesessions/{sessionId}` | PUT | UpdateGameSession | [UpdateGameSession](../../apis/AccelByte.Sdk.Api.Session/Operation/GameSession/UpdateGameSession.cs) | [UpdateGameSession](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/UpdateGameSession.cs) |
| `/session/v1/public/namespaces/{namespace}/gamesessions/{sessionId}` | PATCH | PatchUpdateGameSession | [PatchUpdateGameSession](../../apis/AccelByte.Sdk.Api.Session/Operation/GameSession/PatchUpdateGameSession.cs) | [PatchUpdateGameSession](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/PatchUpdateGameSession.cs) |
| `/session/v1/public/namespaces/{namespace}/gamesessions/{sessionId}/backfill` | PUT | UpdateGameSessionBackfillTicketID | [UpdateGameSessionBackfillTicketID](../../apis/AccelByte.Sdk.Api.Session/Operation/GameSession/UpdateGameSessionBackfillTicketID.cs) | [UpdateGameSessionBackfillTicketID](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/UpdateGameSessionBackfillTicketID.cs) |
| `/session/v1/public/namespaces/{namespace}/gamesessions/{sessionId}/code` | POST | GameSessionGenerateCode | [GameSessionGenerateCode](../../apis/AccelByte.Sdk.Api.Session/Operation/GameSession/GameSessionGenerateCode.cs) | [GameSessionGenerateCode](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/GameSessionGenerateCode.cs) |
| `/session/v1/public/namespaces/{namespace}/gamesessions/{sessionId}/code` | DELETE | PublicRevokeGameSessionCode | [PublicRevokeGameSessionCode](../../apis/AccelByte.Sdk.Api.Session/Operation/GameSession/PublicRevokeGameSessionCode.cs) | [PublicRevokeGameSessionCode](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/PublicRevokeGameSessionCode.cs) |
| `/session/v1/public/namespaces/{namespace}/gamesessions/{sessionId}/join` | POST | JoinGameSession | [JoinGameSession](../../apis/AccelByte.Sdk.Api.Session/Operation/GameSession/JoinGameSession.cs) | [JoinGameSession](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/JoinGameSession.cs) |
| `/session/v1/public/namespaces/{namespace}/gamesessions/{sessionId}/leader` | POST | PublicPromoteGameSessionLeader | [PublicPromoteGameSessionLeader](../../apis/AccelByte.Sdk.Api.Session/Operation/GameSession/PublicPromoteGameSessionLeader.cs) | [PublicPromoteGameSessionLeader](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/PublicPromoteGameSessionLeader.cs) |
| `/session/v1/public/namespaces/{namespace}/gamesessions/{sessionId}/teams` | POST | AppendTeamGameSession | [AppendTeamGameSession](../../apis/AccelByte.Sdk.Api.Session/Operation/GameSession/AppendTeamGameSession.cs) | [AppendTeamGameSession](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/AppendTeamGameSession.cs) |

### Party Wrapper:  [Party](../../apis/AccelByte.Sdk.Api.Session/Wrapper/Party.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/session/v1/public/namespaces/{namespace}/parties/users/me/join/code` | POST | PublicPartyJoinCode | [PublicPartyJoinCode](../../apis/AccelByte.Sdk.Api.Session/Operation/Party/PublicPartyJoinCode.cs) | [PublicPartyJoinCode](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Party/PublicPartyJoinCode.cs) |
| `/session/v1/public/namespaces/{namespace}/parties/{partyId}` | GET | PublicGetParty | [PublicGetParty](../../apis/AccelByte.Sdk.Api.Session/Operation/Party/PublicGetParty.cs) | [PublicGetParty](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Party/PublicGetParty.cs) |
| `/session/v1/public/namespaces/{namespace}/parties/{partyId}` | PUT | PublicUpdateParty | [PublicUpdateParty](../../apis/AccelByte.Sdk.Api.Session/Operation/Party/PublicUpdateParty.cs) | [PublicUpdateParty](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Party/PublicUpdateParty.cs) |
| `/session/v1/public/namespaces/{namespace}/parties/{partyId}` | PATCH | PublicPatchUpdateParty | [PublicPatchUpdateParty](../../apis/AccelByte.Sdk.Api.Session/Operation/Party/PublicPatchUpdateParty.cs) | [PublicPatchUpdateParty](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Party/PublicPatchUpdateParty.cs) |
| `/session/v1/public/namespaces/{namespace}/parties/{partyId}/code` | POST | PublicGeneratePartyCode | [PublicGeneratePartyCode](../../apis/AccelByte.Sdk.Api.Session/Operation/Party/PublicGeneratePartyCode.cs) | [PublicGeneratePartyCode](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Party/PublicGeneratePartyCode.cs) |
| `/session/v1/public/namespaces/{namespace}/parties/{partyId}/code` | DELETE | PublicRevokePartyCode | [PublicRevokePartyCode](../../apis/AccelByte.Sdk.Api.Session/Operation/Party/PublicRevokePartyCode.cs) | [PublicRevokePartyCode](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Party/PublicRevokePartyCode.cs) |
| `/session/v1/public/namespaces/{namespace}/parties/{partyId}/leader` | POST | PublicPromotePartyLeader | [PublicPromotePartyLeader](../../apis/AccelByte.Sdk.Api.Session/Operation/Party/PublicPromotePartyLeader.cs) | [PublicPromotePartyLeader](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Party/PublicPromotePartyLeader.cs) |
| `/session/v1/public/namespaces/{namespace}/parties/{partyId}/users/me/join` | POST | PublicPartyJoin | [PublicPartyJoin](../../apis/AccelByte.Sdk.Api.Session/Operation/Party/PublicPartyJoin.cs) | [PublicPartyJoin](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Party/PublicPartyJoin.cs) |
| `/session/v1/public/namespaces/{namespace}/party` | POST | PublicCreateParty | [PublicCreateParty](../../apis/AccelByte.Sdk.Api.Session/Operation/Party/PublicCreateParty.cs) | [PublicCreateParty](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Party/PublicCreateParty.cs) |

### Platform Credential Wrapper:  [PlatformCredential](../../apis/AccelByte.Sdk.Api.Session/Wrapper/PlatformCredential.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Session Storage Wrapper:  [SessionStorage](../../apis/AccelByte.Sdk.Api.Session/Wrapper/SessionStorage.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Player Wrapper:  [Player](../../apis/AccelByte.Sdk.Api.Session/Wrapper/Player.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/session/v1/admin/namespaces/{namespace}/users/attributes` | GET | AdminQueryPlayerAttributes | [AdminQueryPlayerAttributes](../../apis/AccelByte.Sdk.Api.Session/Operation/Player/AdminQueryPlayerAttributes.cs) | [AdminQueryPlayerAttributes](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Player/AdminQueryPlayerAttributes.cs) |
| `/session/v1/admin/namespaces/{namespace}/users/{userId}/attributes` | GET | AdminGetPlayerAttributes | [AdminGetPlayerAttributes](../../apis/AccelByte.Sdk.Api.Session/Operation/Player/AdminGetPlayerAttributes.cs) | [AdminGetPlayerAttributes](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Player/AdminGetPlayerAttributes.cs) |
| `/session/v1/public/namespaces/{namespace}/users/me/attributes` | GET | PublicGetPlayerAttributes | [PublicGetPlayerAttributes](../../apis/AccelByte.Sdk.Api.Session/Operation/Player/PublicGetPlayerAttributes.cs) | [PublicGetPlayerAttributes](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Player/PublicGetPlayerAttributes.cs) |
| `/session/v1/public/namespaces/{namespace}/users/me/attributes` | POST | PublicStorePlayerAttributes | [PublicStorePlayerAttributes](../../apis/AccelByte.Sdk.Api.Session/Operation/Player/PublicStorePlayerAttributes.cs) | [PublicStorePlayerAttributes](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Player/PublicStorePlayerAttributes.cs) |


&nbsp;

## Models

| Model | Class |
|---|---|
| `apimodels.AppendTeamGameSessionRequest` | [ApimodelsAppendTeamGameSessionRequest](../../apis/AccelByte.Sdk.Api.Session/Model/ApimodelsAppendTeamGameSessionRequest.cs) |
| `apimodels.ConfigAlertRequestCreate` | [ApimodelsConfigAlertRequestCreate](../../apis/AccelByte.Sdk.Api.Session/Model/ApimodelsConfigAlertRequestCreate.cs) |
| `apimodels.ConfigAlertResponse` | [ApimodelsConfigAlertResponse](../../apis/AccelByte.Sdk.Api.Session/Model/ApimodelsConfigAlertResponse.cs) |
| `apimodels.ConfigurationTemplateResponse` | [ApimodelsConfigurationTemplateResponse](../../apis/AccelByte.Sdk.Api.Session/Model/ApimodelsConfigurationTemplateResponse.cs) |
| `apimodels.ConfigurationTemplatesResponse` | [ApimodelsConfigurationTemplatesResponse](../../apis/AccelByte.Sdk.Api.Session/Model/ApimodelsConfigurationTemplatesResponse.cs) |
| `apimodels.CreateConfigurationTemplateRequest` | [ApimodelsCreateConfigurationTemplateRequest](../../apis/AccelByte.Sdk.Api.Session/Model/ApimodelsCreateConfigurationTemplateRequest.cs) |
| `apimodels.CreateGameSessionRequest` | [ApimodelsCreateGameSessionRequest](../../apis/AccelByte.Sdk.Api.Session/Model/ApimodelsCreateGameSessionRequest.cs) |
| `apimodels.CreatePartyRequest` | [ApimodelsCreatePartyRequest](../../apis/AccelByte.Sdk.Api.Session/Model/ApimodelsCreatePartyRequest.cs) |
| `apimodels.DSInformationResponse` | [ApimodelsDSInformationResponse](../../apis/AccelByte.Sdk.Api.Session/Model/ApimodelsDSInformationResponse.cs) |
| `apimodels.DeleteBulkGameSessionRequest` | [ApimodelsDeleteBulkGameSessionRequest](../../apis/AccelByte.Sdk.Api.Session/Model/ApimodelsDeleteBulkGameSessionRequest.cs) |
| `apimodels.DeleteBulkGameSessionsAPIResponse` | [ApimodelsDeleteBulkGameSessionsAPIResponse](../../apis/AccelByte.Sdk.Api.Session/Model/ApimodelsDeleteBulkGameSessionsAPIResponse.cs) |
| `apimodels.EnvironmentVariableListResponse` | [ApimodelsEnvironmentVariableListResponse](../../apis/AccelByte.Sdk.Api.Session/Model/ApimodelsEnvironmentVariableListResponse.cs) |
| `apimodels.EnvironmentVariableResponse` | [ApimodelsEnvironmentVariableResponse](../../apis/AccelByte.Sdk.Api.Session/Model/ApimodelsEnvironmentVariableResponse.cs) |
| `apimodels.GameSessionQueryResponse` | [ApimodelsGameSessionQueryResponse](../../apis/AccelByte.Sdk.Api.Session/Model/ApimodelsGameSessionQueryResponse.cs) |
| `apimodels.GameSessionResponse` | [ApimodelsGameSessionResponse](../../apis/AccelByte.Sdk.Api.Session/Model/ApimodelsGameSessionResponse.cs) |
| `apimodels.JoinByCodeRequest` | [ApimodelsJoinByCodeRequest](../../apis/AccelByte.Sdk.Api.Session/Model/ApimodelsJoinByCodeRequest.cs) |
| `apimodels.KickResponse` | [ApimodelsKickResponse](../../apis/AccelByte.Sdk.Api.Session/Model/ApimodelsKickResponse.cs) |
| `apimodels.Pagination` | [ApimodelsPagination](../../apis/AccelByte.Sdk.Api.Session/Model/ApimodelsPagination.cs) |
| `apimodels.PartyQueryResponse` | [ApimodelsPartyQueryResponse](../../apis/AccelByte.Sdk.Api.Session/Model/ApimodelsPartyQueryResponse.cs) |
| `apimodels.PartySessionResponse` | [ApimodelsPartySessionResponse](../../apis/AccelByte.Sdk.Api.Session/Model/ApimodelsPartySessionResponse.cs) |
| `apimodels.PlayerAttributesRequestBody` | [ApimodelsPlayerAttributesRequestBody](../../apis/AccelByte.Sdk.Api.Session/Model/ApimodelsPlayerAttributesRequestBody.cs) |
| `apimodels.PlayerAttributesResponseBody` | [ApimodelsPlayerAttributesResponseBody](../../apis/AccelByte.Sdk.Api.Session/Model/ApimodelsPlayerAttributesResponseBody.cs) |
| `apimodels.PlayerPlatform` | [ApimodelsPlayerPlatform](../../apis/AccelByte.Sdk.Api.Session/Model/ApimodelsPlayerPlatform.cs) |
| `apimodels.PlayersCurrentPlatformRequest` | [ApimodelsPlayersCurrentPlatformRequest](../../apis/AccelByte.Sdk.Api.Session/Model/ApimodelsPlayersCurrentPlatformRequest.cs) |
| `apimodels.PlayersCurrentPlatformResponse` | [ApimodelsPlayersCurrentPlatformResponse](../../apis/AccelByte.Sdk.Api.Session/Model/ApimodelsPlayersCurrentPlatformResponse.cs) |
| `apimodels.PromoteLeaderRequest` | [ApimodelsPromoteLeaderRequest](../../apis/AccelByte.Sdk.Api.Session/Model/ApimodelsPromoteLeaderRequest.cs) |
| `apimodels.PublicConfiguration` | [ApimodelsPublicConfiguration](../../apis/AccelByte.Sdk.Api.Session/Model/ApimodelsPublicConfiguration.cs) |
| `apimodels.PutPlatformCredentialsRequest` | [ApimodelsPutPlatformCredentialsRequest](../../apis/AccelByte.Sdk.Api.Session/Model/ApimodelsPutPlatformCredentialsRequest.cs) |
| `apimodels.RequestMember` | [ApimodelsRequestMember](../../apis/AccelByte.Sdk.Api.Session/Model/ApimodelsRequestMember.cs) |
| `apimodels.ResponseDeleteBulkGameSessions` | [ApimodelsResponseDeleteBulkGameSessions](../../apis/AccelByte.Sdk.Api.Session/Model/ApimodelsResponseDeleteBulkGameSessions.cs) |
| `apimodels.SessionInviteRequest` | [ApimodelsSessionInviteRequest](../../apis/AccelByte.Sdk.Api.Session/Model/ApimodelsSessionInviteRequest.cs) |
| `apimodels.UpdateConfigurationTemplateRequest` | [ApimodelsUpdateConfigurationTemplateRequest](../../apis/AccelByte.Sdk.Api.Session/Model/ApimodelsUpdateConfigurationTemplateRequest.cs) |
| `apimodels.UpdateGameSessionBackfillRequest` | [ApimodelsUpdateGameSessionBackfillRequest](../../apis/AccelByte.Sdk.Api.Session/Model/ApimodelsUpdateGameSessionBackfillRequest.cs) |
| `apimodels.UpdateGameSessionMemberStatusResponse` | [ApimodelsUpdateGameSessionMemberStatusResponse](../../apis/AccelByte.Sdk.Api.Session/Model/ApimodelsUpdateGameSessionMemberStatusResponse.cs) |
| `apimodels.UpdateGameSessionRequest` | [ApimodelsUpdateGameSessionRequest](../../apis/AccelByte.Sdk.Api.Session/Model/ApimodelsUpdateGameSessionRequest.cs) |
| `apimodels.UpdatePartyRequest` | [ApimodelsUpdatePartyRequest](../../apis/AccelByte.Sdk.Api.Session/Model/ApimodelsUpdatePartyRequest.cs) |
| `apimodels.UserResponse` | [ApimodelsUserResponse](../../apis/AccelByte.Sdk.Api.Session/Model/ApimodelsUserResponse.cs) |
| `models.DSMConfigRecord` | [ModelsDSMConfigRecord](../../apis/AccelByte.Sdk.Api.Session/Model/ModelsDSMConfigRecord.cs) |
| `models.DefaultDSMCConfig` | [ModelsDefaultDSMCConfig](../../apis/AccelByte.Sdk.Api.Session/Model/ModelsDefaultDSMCConfig.cs) |
| `models.GameServer` | [ModelsGameServer](../../apis/AccelByte.Sdk.Api.Session/Model/ModelsGameServer.cs) |
| `models.NativeSessionSetting` | [ModelsNativeSessionSetting](../../apis/AccelByte.Sdk.Api.Session/Model/ModelsNativeSessionSetting.cs) |
| `models.PSNAppServerCredentials` | [ModelsPSNAppServerCredentials](../../apis/AccelByte.Sdk.Api.Session/Model/ModelsPSNAppServerCredentials.cs) |
| `models.PartyMembers` | [ModelsPartyMembers](../../apis/AccelByte.Sdk.Api.Session/Model/ModelsPartyMembers.cs) |
| `models.PlatformCredentials` | [ModelsPlatformCredentials](../../apis/AccelByte.Sdk.Api.Session/Model/ModelsPlatformCredentials.cs) |
| `models.Team` | [ModelsTeam](../../apis/AccelByte.Sdk.Api.Session/Model/ModelsTeam.cs) |
| `models.UserPlatformInfo` | [ModelsUserPlatformInfo](../../apis/AccelByte.Sdk.Api.Session/Model/ModelsUserPlatformInfo.cs) |
| `response.Error` | [ResponseError](../../apis/AccelByte.Sdk.Api.Session/Model/ResponseError.cs) |