# Matchmaking Service Index

&nbsp;

## Operations

### Matchmaking Operations Wrapper:  [MatchmakingOperations](../../apis/AccelByte.Sdk.Api.Matchmaking/Wrapper/MatchmakingOperations.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/healthz` | GET | GetHealthcheckInfo | [GetHealthcheckInfo](../../apis/AccelByte.Sdk.Api.Matchmaking/Operation/MatchmakingOperations/GetHealthcheckInfo.cs) | [GetHealthcheckInfo](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/MatchmakingOperations/GetHealthcheckInfo.cs) |
| `/matchmaking/healthz` | GET | HandlerV3Healthz | [HandlerV3Healthz](../../apis/AccelByte.Sdk.Api.Matchmaking/Operation/MatchmakingOperations/HandlerV3Healthz.cs) | [HandlerV3Healthz](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/MatchmakingOperations/HandlerV3Healthz.cs) |
| `/matchmaking/v1/messages` | GET | PublicGetMessages | [PublicGetMessages](../../apis/AccelByte.Sdk.Api.Matchmaking/Operation/MatchmakingOperations/PublicGetMessages.cs) | [PublicGetMessages](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/MatchmakingOperations/PublicGetMessages.cs) |
| `/matchmaking/version` | GET | VersionCheckHandler | [VersionCheckHandler](../../apis/AccelByte.Sdk.Api.Matchmaking/Operation/MatchmakingOperations/VersionCheckHandler.cs) | [VersionCheckHandler](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/MatchmakingOperations/VersionCheckHandler.cs) |

### Matchmaking Wrapper:  [Matchmaking](../../apis/AccelByte.Sdk.Api.Matchmaking/Wrapper/Matchmaking.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/matchmaking/namespaces/{namespace}/channels` | GET | GetAllChannelsHandler | [GetAllChannelsHandler](../../apis/AccelByte.Sdk.Api.Matchmaking/Operation/Matchmaking/GetAllChannelsHandler.cs) | [GetAllChannelsHandler](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/Matchmaking/GetAllChannelsHandler.cs) |
| `/matchmaking/namespaces/{namespace}/channels` | POST | CreateChannelHandler | [CreateChannelHandler](../../apis/AccelByte.Sdk.Api.Matchmaking/Operation/Matchmaking/CreateChannelHandler.cs) | [CreateChannelHandler](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/Matchmaking/CreateChannelHandler.cs) |
| `/matchmaking/namespaces/{namespace}/channels/{channelName}/metrics` | GET | GetMatchPoolMetric | [GetMatchPoolMetric](../../apis/AccelByte.Sdk.Api.Matchmaking/Operation/Matchmaking/GetMatchPoolMetric.cs) | [GetMatchPoolMetric](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/Matchmaking/GetMatchPoolMetric.cs) |
| `/matchmaking/namespaces/{namespace}/channels/{channel}` | DELETE | DeleteChannelHandler | [DeleteChannelHandler](../../apis/AccelByte.Sdk.Api.Matchmaking/Operation/Matchmaking/DeleteChannelHandler.cs) | [DeleteChannelHandler](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/Matchmaking/DeleteChannelHandler.cs) |
| `/matchmaking/namespaces/{namespace}/matchresult` | POST | StoreMatchResults | [StoreMatchResults](../../apis/AccelByte.Sdk.Api.Matchmaking/Operation/Matchmaking/StoreMatchResults.cs) | [StoreMatchResults](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/Matchmaking/StoreMatchResults.cs) |
| `/matchmaking/namespaces/{namespace}/rebalance` | POST | Rebalance | [Rebalance](../../apis/AccelByte.Sdk.Api.Matchmaking/Operation/Matchmaking/Rebalance.cs) | [Rebalance](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/Matchmaking/Rebalance.cs) |
| `/matchmaking/namespaces/{namespace}/sessions` | POST | QueueSessionHandler | [QueueSessionHandler](../../apis/AccelByte.Sdk.Api.Matchmaking/Operation/Matchmaking/QueueSessionHandler.cs) | [QueueSessionHandler](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/Matchmaking/QueueSessionHandler.cs) |
| `/matchmaking/namespaces/{namespace}/sessions/dequeue` | POST | DequeueSessionHandler | [DequeueSessionHandler](../../apis/AccelByte.Sdk.Api.Matchmaking/Operation/Matchmaking/DequeueSessionHandler.cs) | [DequeueSessionHandler](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/Matchmaking/DequeueSessionHandler.cs) |
| `/matchmaking/namespaces/{namespace}/sessions/{matchID}/status` | GET | QuerySessionHandler | [QuerySessionHandler](../../apis/AccelByte.Sdk.Api.Matchmaking/Operation/Matchmaking/QuerySessionHandler.cs) | [QuerySessionHandler](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/Matchmaking/QuerySessionHandler.cs) |
| `/matchmaking/v1/admin/namespaces/{namespace}/channels/all/parties` | GET | GetAllPartyInAllChannel | [GetAllPartyInAllChannel](../../apis/AccelByte.Sdk.Api.Matchmaking/Operation/Matchmaking/GetAllPartyInAllChannel.cs) | [GetAllPartyInAllChannel](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/Matchmaking/GetAllPartyInAllChannel.cs) |
| `/matchmaking/v1/admin/namespaces/{namespace}/channels/all/sessions/bulk` | GET | BulkGetSessions | [BulkGetSessions](../../apis/AccelByte.Sdk.Api.Matchmaking/Operation/Matchmaking/BulkGetSessions.cs) | [BulkGetSessions](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/Matchmaking/BulkGetSessions.cs) |
| `/matchmaking/v1/admin/namespaces/{namespace}/channels/export` | GET | ExportChannels | [ExportChannels](../../apis/AccelByte.Sdk.Api.Matchmaking/Operation/Matchmaking/ExportChannels.cs) | [ExportChannels](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/Matchmaking/ExportChannels.cs) |
| `/matchmaking/v1/admin/namespaces/{namespace}/channels/import` | POST | ImportChannels | [ImportChannels](../../apis/AccelByte.Sdk.Api.Matchmaking/Operation/Matchmaking/ImportChannels.cs) | [ImportChannels](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/Matchmaking/ImportChannels.cs) |
| `/matchmaking/v1/admin/namespaces/{namespace}/channels/{channelName}` | GET | GetSingleMatchmakingChannel | [GetSingleMatchmakingChannel](../../apis/AccelByte.Sdk.Api.Matchmaking/Operation/Matchmaking/GetSingleMatchmakingChannel.cs) | [GetSingleMatchmakingChannel](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/Matchmaking/GetSingleMatchmakingChannel.cs) |
| `/matchmaking/v1/admin/namespaces/{namespace}/channels/{channelName}` | PATCH | UpdateMatchmakingChannel | [UpdateMatchmakingChannel](../../apis/AccelByte.Sdk.Api.Matchmaking/Operation/Matchmaking/UpdateMatchmakingChannel.cs) | [UpdateMatchmakingChannel](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/Matchmaking/UpdateMatchmakingChannel.cs) |
| `/matchmaking/v1/admin/namespaces/{namespace}/channels/{channelName}/parties` | GET | GetAllPartyInChannel | [GetAllPartyInChannel](../../apis/AccelByte.Sdk.Api.Matchmaking/Operation/Matchmaking/GetAllPartyInChannel.cs) | [GetAllPartyInChannel](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/Matchmaking/GetAllPartyInChannel.cs) |
| `/matchmaking/v1/admin/namespaces/{namespace}/channels/{channelName}/sessions` | GET | GetAllSessionsInChannel | [GetAllSessionsInChannel](../../apis/AccelByte.Sdk.Api.Matchmaking/Operation/Matchmaking/GetAllSessionsInChannel.cs) | [GetAllSessionsInChannel](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/Matchmaking/GetAllSessionsInChannel.cs) |
| `/matchmaking/v1/admin/namespaces/{namespace}/channels/{channelName}/sessions/{matchID}` | POST | AddUserIntoSessionInChannel | [AddUserIntoSessionInChannel](../../apis/AccelByte.Sdk.Api.Matchmaking/Operation/Matchmaking/AddUserIntoSessionInChannel.cs) | [AddUserIntoSessionInChannel](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/Matchmaking/AddUserIntoSessionInChannel.cs) |
| `/matchmaking/v1/admin/namespaces/{namespace}/channels/{channelName}/sessions/{matchID}` | DELETE | DeleteSessionInChannel | [DeleteSessionInChannel](../../apis/AccelByte.Sdk.Api.Matchmaking/Operation/Matchmaking/DeleteSessionInChannel.cs) | [DeleteSessionInChannel](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/Matchmaking/DeleteSessionInChannel.cs) |
| `/matchmaking/v1/admin/namespaces/{namespace}/channels/{channelName}/sessions/{matchID}/users/{userID}` | DELETE | DeleteUserFromSessionInChannel | [DeleteUserFromSessionInChannel](../../apis/AccelByte.Sdk.Api.Matchmaking/Operation/Matchmaking/DeleteUserFromSessionInChannel.cs) | [DeleteUserFromSessionInChannel](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/Matchmaking/DeleteUserFromSessionInChannel.cs) |
| `/matchmaking/v1/admin/namespaces/{namespace}/channels/{channelName}/stats` | GET | GetStatData | [GetStatData](../../apis/AccelByte.Sdk.Api.Matchmaking/Operation/Matchmaking/GetStatData.cs) | [GetStatData](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/Matchmaking/GetStatData.cs) |
| [DEPRECATED] `/matchmaking/v1/admin/namespaces/{namespace}/sessions/history/search` | GET | SearchSessions | [SearchSessions](../../apis/AccelByte.Sdk.Api.Matchmaking/Operation/Matchmaking/SearchSessions.cs) | [SearchSessions](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/Matchmaking/SearchSessions.cs) |
| [DEPRECATED] `/matchmaking/v1/admin/namespaces/{namespace}/sessions/{matchID}/history/detailed` | GET | GetSessionHistoryDetailed | [GetSessionHistoryDetailed](../../apis/AccelByte.Sdk.Api.Matchmaking/Operation/Matchmaking/GetSessionHistoryDetailed.cs) | [GetSessionHistoryDetailed](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/Matchmaking/GetSessionHistoryDetailed.cs) |
| `/matchmaking/v1/public/namespaces/{namespace}/channels` | GET | PublicGetAllMatchmakingChannel | [PublicGetAllMatchmakingChannel](../../apis/AccelByte.Sdk.Api.Matchmaking/Operation/Matchmaking/PublicGetAllMatchmakingChannel.cs) | [PublicGetAllMatchmakingChannel](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/Matchmaking/PublicGetAllMatchmakingChannel.cs) |
| `/matchmaking/v1/public/namespaces/{namespace}/channels/{channelName}` | GET | PublicGetSingleMatchmakingChannel | [PublicGetSingleMatchmakingChannel](../../apis/AccelByte.Sdk.Api.Matchmaking/Operation/Matchmaking/PublicGetSingleMatchmakingChannel.cs) | [PublicGetSingleMatchmakingChannel](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/Matchmaking/PublicGetSingleMatchmakingChannel.cs) |
| [DEPRECATED] `/matchmaking/v2/admin/namespaces/{namespace}/sessions/history/search` | GET | SearchSessionsV2 | [SearchSessionsV2](../../apis/AccelByte.Sdk.Api.Matchmaking/Operation/Matchmaking/SearchSessionsV2.cs) | [SearchSessionsV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/Matchmaking/SearchSessionsV2.cs) |

### Social Matchmaking Wrapper:  [SocialMatchmaking](../../apis/AccelByte.Sdk.Api.Matchmaking/Wrapper/SocialMatchmaking.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/matchmaking/social/playtime/namespaces/{namespace}/weight` | PATCH | UpdatePlayTimeWeight | [UpdatePlayTimeWeight](../../apis/AccelByte.Sdk.Api.Matchmaking/Operation/SocialMatchmaking/UpdatePlayTimeWeight.cs) | [UpdatePlayTimeWeight](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/SocialMatchmaking/UpdatePlayTimeWeight.cs) |

### Mock Matchmaking Wrapper:  [MockMatchmaking](../../apis/AccelByte.Sdk.Api.Matchmaking/Wrapper/MockMatchmaking.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/matchmaking/v1/admin/namespaces/{namespace}/channels/{channelName}/mocks` | DELETE | CleanAllMocks | [CleanAllMocks](../../apis/AccelByte.Sdk.Api.Matchmaking/Operation/MockMatchmaking/CleanAllMocks.cs) | [CleanAllMocks](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/MockMatchmaking/CleanAllMocks.cs) |
| `/matchmaking/v1/admin/namespaces/{namespace}/channels/{channelName}/mocks/matches` | GET | GetAllMockMatches | [GetAllMockMatches](../../apis/AccelByte.Sdk.Api.Matchmaking/Operation/MockMatchmaking/GetAllMockMatches.cs) | [GetAllMockMatches](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/MockMatchmaking/GetAllMockMatches.cs) |
| `/matchmaking/v1/admin/namespaces/{namespace}/channels/{channelName}/mocks/matches` | POST | GetMockMatchesByTimestamp | [GetMockMatchesByTimestamp](../../apis/AccelByte.Sdk.Api.Matchmaking/Operation/MockMatchmaking/GetMockMatchesByTimestamp.cs) | [GetMockMatchesByTimestamp](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/MockMatchmaking/GetMockMatchesByTimestamp.cs) |
| `/matchmaking/v1/admin/namespaces/{namespace}/channels/{channelName}/mocks/tickets` | GET | GetAllMockTickets | [GetAllMockTickets](../../apis/AccelByte.Sdk.Api.Matchmaking/Operation/MockMatchmaking/GetAllMockTickets.cs) | [GetAllMockTickets](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/MockMatchmaking/GetAllMockTickets.cs) |
| `/matchmaking/v1/admin/namespaces/{namespace}/channels/{channelName}/mocks/tickets` | POST | CreateMockTickets | [CreateMockTickets](../../apis/AccelByte.Sdk.Api.Matchmaking/Operation/MockMatchmaking/CreateMockTickets.cs) | [CreateMockTickets](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/MockMatchmaking/CreateMockTickets.cs) |
| `/matchmaking/v1/admin/namespaces/{namespace}/channels/{channelName}/mocks/tickets/bulk` | POST | BulkCreateMockTickets | [BulkCreateMockTickets](../../apis/AccelByte.Sdk.Api.Matchmaking/Operation/MockMatchmaking/BulkCreateMockTickets.cs) | [BulkCreateMockTickets](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/MockMatchmaking/BulkCreateMockTickets.cs) |
| `/matchmaking/v1/admin/namespaces/{namespace}/channels/{channelName}/mocks/tickets/query` | POST | GetMockTicketsByTimestamp | [GetMockTicketsByTimestamp](../../apis/AccelByte.Sdk.Api.Matchmaking/Operation/MockMatchmaking/GetMockTicketsByTimestamp.cs) | [GetMockTicketsByTimestamp](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/MockMatchmaking/GetMockTicketsByTimestamp.cs) |


&nbsp;

## Operations with Generic Response

### Matchmaking Operations Wrapper:  [MatchmakingOperations](../../apis/AccelByte.Sdk.Api.Matchmaking/Wrapper/MatchmakingOperations.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Matchmaking Wrapper:  [Matchmaking](../../apis/AccelByte.Sdk.Api.Matchmaking/Wrapper/Matchmaking.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/matchmaking/namespaces/{namespace}/sessions/{matchID}/status` | GET | QuerySessionHandler | [QuerySessionHandler](../../apis/AccelByte.Sdk.Api.Matchmaking/Operation/Matchmaking/QuerySessionHandler.cs) | [QuerySessionHandler](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/Matchmaking/QuerySessionHandler.cs) |
| `/matchmaking/v1/admin/namespaces/{namespace}/channels/all/parties` | GET | GetAllPartyInAllChannel | [GetAllPartyInAllChannel](../../apis/AccelByte.Sdk.Api.Matchmaking/Operation/Matchmaking/GetAllPartyInAllChannel.cs) | [GetAllPartyInAllChannel](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/Matchmaking/GetAllPartyInAllChannel.cs) |
| `/matchmaking/v1/admin/namespaces/{namespace}/channels/all/sessions/bulk` | GET | BulkGetSessions | [BulkGetSessions](../../apis/AccelByte.Sdk.Api.Matchmaking/Operation/Matchmaking/BulkGetSessions.cs) | [BulkGetSessions](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/Matchmaking/BulkGetSessions.cs) |
| `/matchmaking/v1/admin/namespaces/{namespace}/channels/{channelName}/parties` | GET | GetAllPartyInChannel | [GetAllPartyInChannel](../../apis/AccelByte.Sdk.Api.Matchmaking/Operation/Matchmaking/GetAllPartyInChannel.cs) | [GetAllPartyInChannel](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/Matchmaking/GetAllPartyInChannel.cs) |
| `/matchmaking/v1/admin/namespaces/{namespace}/channels/{channelName}/sessions` | GET | GetAllSessionsInChannel | [GetAllSessionsInChannel](../../apis/AccelByte.Sdk.Api.Matchmaking/Operation/Matchmaking/GetAllSessionsInChannel.cs) | [GetAllSessionsInChannel](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/Matchmaking/GetAllSessionsInChannel.cs) |

### Social Matchmaking Wrapper:  [SocialMatchmaking](../../apis/AccelByte.Sdk.Api.Matchmaking/Wrapper/SocialMatchmaking.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Mock Matchmaking Wrapper:  [MockMatchmaking](../../apis/AccelByte.Sdk.Api.Matchmaking/Wrapper/MockMatchmaking.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/matchmaking/v1/admin/namespaces/{namespace}/channels/{channelName}/mocks/tickets` | POST | CreateMockTickets | [CreateMockTickets](../../apis/AccelByte.Sdk.Api.Matchmaking/Operation/MockMatchmaking/CreateMockTickets.cs) | [CreateMockTickets](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/MockMatchmaking/CreateMockTickets.cs) |


&nbsp;

## Models

| Model | Class |
|---|---|
| `log.AppMessageDeclaration` | [LogAppMessageDeclaration](../../apis/AccelByte.Sdk.Api.Matchmaking/Model/LogAppMessageDeclaration.cs) |
| `models.AllianceFlexingRule` | [ModelsAllianceFlexingRule](../../apis/AccelByte.Sdk.Api.Matchmaking/Model/ModelsAllianceFlexingRule.cs) |
| `models.AllianceRule` | [ModelsAllianceRule](../../apis/AccelByte.Sdk.Api.Matchmaking/Model/ModelsAllianceRule.cs) |
| `models.AllianceRuleV1` | [ModelsAllianceRuleV1](../../apis/AccelByte.Sdk.Api.Matchmaking/Model/ModelsAllianceRuleV1.cs) |
| `models.BucketMMRRule` | [ModelsBucketMMRRule](../../apis/AccelByte.Sdk.Api.Matchmaking/Model/ModelsBucketMMRRule.cs) |
| `models.Channel` | [ModelsChannel](../../apis/AccelByte.Sdk.Api.Matchmaking/Model/ModelsChannel.cs) |
| `models.ChannelRequest` | [ModelsChannelRequest](../../apis/AccelByte.Sdk.Api.Matchmaking/Model/ModelsChannelRequest.cs) |
| `models.ChannelV1` | [ModelsChannelV1](../../apis/AccelByte.Sdk.Api.Matchmaking/Model/ModelsChannelV1.cs) |
| `models.Combination` | [ModelsCombination](../../apis/AccelByte.Sdk.Api.Matchmaking/Model/ModelsCombination.cs) |
| `models.CreateChannelResponse` | [ModelsCreateChannelResponse](../../apis/AccelByte.Sdk.Api.Matchmaking/Model/ModelsCreateChannelResponse.cs) |
| `models.CreateMockTicket` | [ModelsCreateMockTicket](../../apis/AccelByte.Sdk.Api.Matchmaking/Model/ModelsCreateMockTicket.cs) |
| `models.DequeueRequest` | [ModelsDequeueRequest](../../apis/AccelByte.Sdk.Api.Matchmaking/Model/ModelsDequeueRequest.cs) |
| `models.FlexingRule` | [ModelsFlexingRule](../../apis/AccelByte.Sdk.Api.Matchmaking/Model/ModelsFlexingRule.cs) |
| `models.GetChannelsResponse` | [ModelsGetChannelsResponse](../../apis/AccelByte.Sdk.Api.Matchmaking/Model/ModelsGetChannelsResponse.cs) |
| `models.GetMockMatchesResponse` | [ModelsGetMockMatchesResponse](../../apis/AccelByte.Sdk.Api.Matchmaking/Model/ModelsGetMockMatchesResponse.cs) |
| `models.GetMockTicketsResponse` | [ModelsGetMockTicketsResponse](../../apis/AccelByte.Sdk.Api.Matchmaking/Model/ModelsGetMockTicketsResponse.cs) |
| `models.ImportConfigResponse` | [ModelsImportConfigResponse](../../apis/AccelByte.Sdk.Api.Matchmaking/Model/ModelsImportConfigResponse.cs) |
| `models.MatchAddUserIntoSessionRequest` | [ModelsMatchAddUserIntoSessionRequest](../../apis/AccelByte.Sdk.Api.Matchmaking/Model/ModelsMatchAddUserIntoSessionRequest.cs) |
| `models.MatchOption` | [ModelsMatchOption](../../apis/AccelByte.Sdk.Api.Matchmaking/Model/ModelsMatchOption.cs) |
| `models.MatchOptionRule` | [ModelsMatchOptionRule](../../apis/AccelByte.Sdk.Api.Matchmaking/Model/ModelsMatchOptionRule.cs) |
| `models.MatchResultRequest` | [ModelsMatchResultRequest](../../apis/AccelByte.Sdk.Api.Matchmaking/Model/ModelsMatchResultRequest.cs) |
| `models.MatchResultResponse` | [ModelsMatchResultResponse](../../apis/AccelByte.Sdk.Api.Matchmaking/Model/ModelsMatchResultResponse.cs) |
| `models.MatchingAlly` | [ModelsMatchingAlly](../../apis/AccelByte.Sdk.Api.Matchmaking/Model/ModelsMatchingAlly.cs) |
| `models.MatchingParty` | [ModelsMatchingParty](../../apis/AccelByte.Sdk.Api.Matchmaking/Model/ModelsMatchingParty.cs) |
| `models.MatchingRule` | [ModelsMatchingRule](../../apis/AccelByte.Sdk.Api.Matchmaking/Model/ModelsMatchingRule.cs) |
| `models.MatchmakingResult` | [ModelsMatchmakingResult](../../apis/AccelByte.Sdk.Api.Matchmaking/Model/ModelsMatchmakingResult.cs) |
| `models.MockMatch` | [ModelsMockMatch](../../apis/AccelByte.Sdk.Api.Matchmaking/Model/ModelsMockMatch.cs) |
| `models.MockTicket` | [ModelsMockTicket](../../apis/AccelByte.Sdk.Api.Matchmaking/Model/ModelsMockTicket.cs) |
| `models.Pagination` | [ModelsPagination](../../apis/AccelByte.Sdk.Api.Matchmaking/Model/ModelsPagination.cs) |
| `models.PartyMember` | [ModelsPartyMember](../../apis/AccelByte.Sdk.Api.Matchmaking/Model/ModelsPartyMember.cs) |
| `models.PlayerResultRequest` | [ModelsPlayerResultRequest](../../apis/AccelByte.Sdk.Api.Matchmaking/Model/ModelsPlayerResultRequest.cs) |
| `models.PlayerResultResponse` | [ModelsPlayerResultResponse](../../apis/AccelByte.Sdk.Api.Matchmaking/Model/ModelsPlayerResultResponse.cs) |
| `models.QueryMockBy` | [ModelsQueryMockBy](../../apis/AccelByte.Sdk.Api.Matchmaking/Model/ModelsQueryMockBy.cs) |
| `models.RebalanceRequest` | [ModelsRebalanceRequest](../../apis/AccelByte.Sdk.Api.Matchmaking/Model/ModelsRebalanceRequest.cs) |
| `models.RebalanceResponse` | [ModelsRebalanceResponse](../../apis/AccelByte.Sdk.Api.Matchmaking/Model/ModelsRebalanceResponse.cs) |
| `models.Region` | [ModelsRegion](../../apis/AccelByte.Sdk.Api.Matchmaking/Model/ModelsRegion.cs) |
| `models.ResultAttributeRequest` | [ModelsResultAttributeRequest](../../apis/AccelByte.Sdk.Api.Matchmaking/Model/ModelsResultAttributeRequest.cs) |
| `models.ResultAttributeResponse` | [ModelsResultAttributeResponse](../../apis/AccelByte.Sdk.Api.Matchmaking/Model/ModelsResultAttributeResponse.cs) |
| `models.Role` | [ModelsRole](../../apis/AccelByte.Sdk.Api.Matchmaking/Model/ModelsRole.cs) |
| `models.RuleSet` | [ModelsRuleSet](../../apis/AccelByte.Sdk.Api.Matchmaking/Model/ModelsRuleSet.cs) |
| `models.RuleSetV1` | [ModelsRuleSetV1](../../apis/AccelByte.Sdk.Api.Matchmaking/Model/ModelsRuleSetV1.cs) |
| `models.SelectionRule` | [ModelsSelectionRule](../../apis/AccelByte.Sdk.Api.Matchmaking/Model/ModelsSelectionRule.cs) |
| `models.SortTicket` | [ModelsSortTicket](../../apis/AccelByte.Sdk.Api.Matchmaking/Model/ModelsSortTicket.cs) |
| `models.SortTicketRule` | [ModelsSortTicketRule](../../apis/AccelByte.Sdk.Api.Matchmaking/Model/ModelsSortTicketRule.cs) |
| `models.StatResumeResponse` | [ModelsStatResumeResponse](../../apis/AccelByte.Sdk.Api.Matchmaking/Model/ModelsStatResumeResponse.cs) |
| `models.SubGameMode` | [ModelsSubGameMode](../../apis/AccelByte.Sdk.Api.Matchmaking/Model/ModelsSubGameMode.cs) |
| `models.TicketMetricResultRecord` | [ModelsTicketMetricResultRecord](../../apis/AccelByte.Sdk.Api.Matchmaking/Model/ModelsTicketMetricResultRecord.cs) |
| `models.UpdateAllianceRule` | [ModelsUpdateAllianceRule](../../apis/AccelByte.Sdk.Api.Matchmaking/Model/ModelsUpdateAllianceRule.cs) |
| `models.UpdateChannelRequest` | [ModelsUpdateChannelRequest](../../apis/AccelByte.Sdk.Api.Matchmaking/Model/ModelsUpdateChannelRequest.cs) |
| `models.UpdatePlayTimeWeightRequest` | [ModelsUpdatePlayTimeWeightRequest](../../apis/AccelByte.Sdk.Api.Matchmaking/Model/ModelsUpdatePlayTimeWeightRequest.cs) |
| `models.UpdatePlayerPlaytimeWeightResponse` | [ModelsUpdatePlayerPlaytimeWeightResponse](../../apis/AccelByte.Sdk.Api.Matchmaking/Model/ModelsUpdatePlayerPlaytimeWeightResponse.cs) |
| `models.UpdateRuleset` | [ModelsUpdateRuleset](../../apis/AccelByte.Sdk.Api.Matchmaking/Model/ModelsUpdateRuleset.cs) |
| `models.UpdateRuleset.sub_game_modes` | [ModelsUpdateRulesetSubGameModes](../../apis/AccelByte.Sdk.Api.Matchmaking/Model/ModelsUpdateRulesetSubGameModes.cs) |
| `response.Error` | [ResponseError](../../apis/AccelByte.Sdk.Api.Matchmaking/Model/ResponseError.cs) |
| `response.ErrorV1` | [ResponseErrorV1](../../apis/AccelByte.Sdk.Api.Matchmaking/Model/ResponseErrorV1.cs) |
| `service.GetSessionHistoryDetailedResponseItem` | [ServiceGetSessionHistoryDetailedResponseItem](../../apis/AccelByte.Sdk.Api.Matchmaking/Model/ServiceGetSessionHistoryDetailedResponseItem.cs) |
| `service.GetSessionHistorySearchResponse` | [ServiceGetSessionHistorySearchResponse](../../apis/AccelByte.Sdk.Api.Matchmaking/Model/ServiceGetSessionHistorySearchResponse.cs) |
| `service.GetSessionHistorySearchResponseItem` | [ServiceGetSessionHistorySearchResponseItem](../../apis/AccelByte.Sdk.Api.Matchmaking/Model/ServiceGetSessionHistorySearchResponseItem.cs) |
| `service.GetSessionHistorySearchResponseItemV2` | [ServiceGetSessionHistorySearchResponseItemV2](../../apis/AccelByte.Sdk.Api.Matchmaking/Model/ServiceGetSessionHistorySearchResponseItemV2.cs) |
| `service.GetSessionHistorySearchResponseV2` | [ServiceGetSessionHistorySearchResponseV2](../../apis/AccelByte.Sdk.Api.Matchmaking/Model/ServiceGetSessionHistorySearchResponseV2.cs) |
