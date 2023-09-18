# Match2 Service Index

&nbsp;

## Operations

### Operations Wrapper:  [Operations](../../apis/AccelByte.Sdk.Api.Match2/Wrapper/Operations.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/healthz` | GET | GetHealthcheckInfo | [GetHealthcheckInfo](../../apis/AccelByte.Sdk.Api.Match2/Operation/Operations/GetHealthcheckInfo.cs) | [GetHealthcheckInfo](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/Operations/GetHealthcheckInfo.cs) |
| `/match2/healthz` | GET | GetHealthcheckInfoV1 | [GetHealthcheckInfoV1](../../apis/AccelByte.Sdk.Api.Match2/Operation/Operations/GetHealthcheckInfoV1.cs) | [GetHealthcheckInfoV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/Operations/GetHealthcheckInfoV1.cs) |
| `/match2/version` | GET | VersionCheckHandler | [VersionCheckHandler](../../apis/AccelByte.Sdk.Api.Match2/Operation/Operations/VersionCheckHandler.cs) | [VersionCheckHandler](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/Operations/VersionCheckHandler.cs) |

### Environment-Variables Wrapper:  [EnvironmentVariables](../../apis/AccelByte.Sdk.Api.Match2/Wrapper/EnvironmentVariables.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/match2/v1/environment-variables` | GET | EnvironmentVariableList | [EnvironmentVariableList](../../apis/AccelByte.Sdk.Api.Match2/Operation/EnvironmentVariables/EnvironmentVariableList.cs) | [EnvironmentVariableList](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/EnvironmentVariables/EnvironmentVariableList.cs) |

### Backfill Wrapper:  [Backfill](../../apis/AccelByte.Sdk.Api.Match2/Wrapper/Backfill.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/match2/v1/namespaces/{namespace}/backfill` | POST | CreateBackfill | [CreateBackfill](../../apis/AccelByte.Sdk.Api.Match2/Operation/Backfill/CreateBackfill.cs) | [CreateBackfill](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/Backfill/CreateBackfill.cs) |
| `/match2/v1/namespaces/{namespace}/backfill/proposal` | GET | GetBackfillProposal | [GetBackfillProposal](../../apis/AccelByte.Sdk.Api.Match2/Operation/Backfill/GetBackfillProposal.cs) | [GetBackfillProposal](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/Backfill/GetBackfillProposal.cs) |
| `/match2/v1/namespaces/{namespace}/backfill/{backfillID}` | GET | GetBackfill | [GetBackfill](../../apis/AccelByte.Sdk.Api.Match2/Operation/Backfill/GetBackfill.cs) | [GetBackfill](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/Backfill/GetBackfill.cs) |
| `/match2/v1/namespaces/{namespace}/backfill/{backfillID}` | DELETE | DeleteBackfill | [DeleteBackfill](../../apis/AccelByte.Sdk.Api.Match2/Operation/Backfill/DeleteBackfill.cs) | [DeleteBackfill](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/Backfill/DeleteBackfill.cs) |
| `/match2/v1/namespaces/{namespace}/backfill/{backfillID}/proposal/accept` | PUT | AcceptBackfill | [AcceptBackfill](../../apis/AccelByte.Sdk.Api.Match2/Operation/Backfill/AcceptBackfill.cs) | [AcceptBackfill](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/Backfill/AcceptBackfill.cs) |
| `/match2/v1/namespaces/{namespace}/backfill/{backfillID}/proposal/reject` | PUT | RejectBackfill | [RejectBackfill](../../apis/AccelByte.Sdk.Api.Match2/Operation/Backfill/RejectBackfill.cs) | [RejectBackfill](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/Backfill/RejectBackfill.cs) |

### Match-Functions Wrapper:  [MatchFunctions](../../apis/AccelByte.Sdk.Api.Match2/Wrapper/MatchFunctions.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/match2/v1/namespaces/{namespace}/match-functions` | GET | MatchFunctionList | [MatchFunctionList](../../apis/AccelByte.Sdk.Api.Match2/Operation/MatchFunctions/MatchFunctionList.cs) | [MatchFunctionList](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/MatchFunctions/MatchFunctionList.cs) |
| `/match2/v1/namespaces/{namespace}/match-functions` | POST | CreateMatchFunction | [CreateMatchFunction](../../apis/AccelByte.Sdk.Api.Match2/Operation/MatchFunctions/CreateMatchFunction.cs) | [CreateMatchFunction](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/MatchFunctions/CreateMatchFunction.cs) |
| `/match2/v1/namespaces/{namespace}/match-functions/{name}` | PUT | UpdateMatchFunction | [UpdateMatchFunction](../../apis/AccelByte.Sdk.Api.Match2/Operation/MatchFunctions/UpdateMatchFunction.cs) | [UpdateMatchFunction](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/MatchFunctions/UpdateMatchFunction.cs) |
| `/match2/v1/namespaces/{namespace}/match-functions/{name}` | DELETE | DeleteMatchFunction | [DeleteMatchFunction](../../apis/AccelByte.Sdk.Api.Match2/Operation/MatchFunctions/DeleteMatchFunction.cs) | [DeleteMatchFunction](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/MatchFunctions/DeleteMatchFunction.cs) |

### Match-Pools Wrapper:  [MatchPools](../../apis/AccelByte.Sdk.Api.Match2/Wrapper/MatchPools.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/match2/v1/namespaces/{namespace}/match-pools` | GET | MatchPoolList | [MatchPoolList](../../apis/AccelByte.Sdk.Api.Match2/Operation/MatchPools/MatchPoolList.cs) | [MatchPoolList](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/MatchPools/MatchPoolList.cs) |
| `/match2/v1/namespaces/{namespace}/match-pools` | POST | CreateMatchPool | [CreateMatchPool](../../apis/AccelByte.Sdk.Api.Match2/Operation/MatchPools/CreateMatchPool.cs) | [CreateMatchPool](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/MatchPools/CreateMatchPool.cs) |
| `/match2/v1/namespaces/{namespace}/match-pools/{pool}` | GET | MatchPoolDetails | [MatchPoolDetails](../../apis/AccelByte.Sdk.Api.Match2/Operation/MatchPools/MatchPoolDetails.cs) | [MatchPoolDetails](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/MatchPools/MatchPoolDetails.cs) |
| `/match2/v1/namespaces/{namespace}/match-pools/{pool}` | PUT | UpdateMatchPool | [UpdateMatchPool](../../apis/AccelByte.Sdk.Api.Match2/Operation/MatchPools/UpdateMatchPool.cs) | [UpdateMatchPool](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/MatchPools/UpdateMatchPool.cs) |
| `/match2/v1/namespaces/{namespace}/match-pools/{pool}` | DELETE | DeleteMatchPool | [DeleteMatchPool](../../apis/AccelByte.Sdk.Api.Match2/Operation/MatchPools/DeleteMatchPool.cs) | [DeleteMatchPool](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/MatchPools/DeleteMatchPool.cs) |
| `/match2/v1/namespaces/{namespace}/match-pools/{pool}/metrics` | GET | MatchPoolMetric | [MatchPoolMetric](../../apis/AccelByte.Sdk.Api.Match2/Operation/MatchPools/MatchPoolMetric.cs) | [MatchPoolMetric](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/MatchPools/MatchPoolMetric.cs) |
| `/match2/v1/namespaces/{namespace}/match-pools/{pool}/metrics/player` | GET | GetPlayerMetric | [GetPlayerMetric](../../apis/AccelByte.Sdk.Api.Match2/Operation/MatchPools/GetPlayerMetric.cs) | [GetPlayerMetric](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/MatchPools/GetPlayerMetric.cs) |

### Match-Tickets Wrapper:  [MatchTickets](../../apis/AccelByte.Sdk.Api.Match2/Wrapper/MatchTickets.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/match2/v1/namespaces/{namespace}/match-tickets` | POST | CreateMatchTicket | [CreateMatchTicket](../../apis/AccelByte.Sdk.Api.Match2/Operation/MatchTickets/CreateMatchTicket.cs) | [CreateMatchTicket](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/MatchTickets/CreateMatchTicket.cs) |
| `/match2/v1/namespaces/{namespace}/match-tickets/me` | GET | GetMyMatchTickets | [GetMyMatchTickets](../../apis/AccelByte.Sdk.Api.Match2/Operation/MatchTickets/GetMyMatchTickets.cs) | [GetMyMatchTickets](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/MatchTickets/GetMyMatchTickets.cs) |
| `/match2/v1/namespaces/{namespace}/match-tickets/{ticketid}` | GET | MatchTicketDetails | [MatchTicketDetails](../../apis/AccelByte.Sdk.Api.Match2/Operation/MatchTickets/MatchTicketDetails.cs) | [MatchTicketDetails](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/MatchTickets/MatchTicketDetails.cs) |
| `/match2/v1/namespaces/{namespace}/match-tickets/{ticketid}` | DELETE | DeleteMatchTicket | [DeleteMatchTicket](../../apis/AccelByte.Sdk.Api.Match2/Operation/MatchTickets/DeleteMatchTicket.cs) | [DeleteMatchTicket](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/MatchTickets/DeleteMatchTicket.cs) |

### Rule-Sets Wrapper:  [RuleSets](../../apis/AccelByte.Sdk.Api.Match2/Wrapper/RuleSets.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/match2/v1/namespaces/{namespace}/rulesets` | GET | RuleSetList | [RuleSetList](../../apis/AccelByte.Sdk.Api.Match2/Operation/RuleSets/RuleSetList.cs) | [RuleSetList](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/RuleSets/RuleSetList.cs) |
| `/match2/v1/namespaces/{namespace}/rulesets` | POST | CreateRuleSet | [CreateRuleSet](../../apis/AccelByte.Sdk.Api.Match2/Operation/RuleSets/CreateRuleSet.cs) | [CreateRuleSet](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/RuleSets/CreateRuleSet.cs) |
| `/match2/v1/namespaces/{namespace}/rulesets/{ruleset}` | GET | RuleSetDetails | [RuleSetDetails](../../apis/AccelByte.Sdk.Api.Match2/Operation/RuleSets/RuleSetDetails.cs) | [RuleSetDetails](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/RuleSets/RuleSetDetails.cs) |
| `/match2/v1/namespaces/{namespace}/rulesets/{ruleset}` | PUT | UpdateRuleSet | [UpdateRuleSet](../../apis/AccelByte.Sdk.Api.Match2/Operation/RuleSets/UpdateRuleSet.cs) | [UpdateRuleSet](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/RuleSets/UpdateRuleSet.cs) |
| `/match2/v1/namespaces/{namespace}/rulesets/{ruleset}` | DELETE | DeleteRuleSet | [DeleteRuleSet](../../apis/AccelByte.Sdk.Api.Match2/Operation/RuleSets/DeleteRuleSet.cs) | [DeleteRuleSet](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/RuleSets/DeleteRuleSet.cs) |


&nbsp;

## Operations with Generic Response

### Operations Wrapper:  [Operations](../../apis/AccelByte.Sdk.Api.Match2/Wrapper/Operations.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Environment-Variables Wrapper:  [EnvironmentVariables](../../apis/AccelByte.Sdk.Api.Match2/Wrapper/EnvironmentVariables.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Backfill Wrapper:  [Backfill](../../apis/AccelByte.Sdk.Api.Match2/Wrapper/Backfill.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/match2/v1/namespaces/{namespace}/backfill/{backfillID}/proposal/accept` | PUT | AcceptBackfill | [AcceptBackfill](../../apis/AccelByte.Sdk.Api.Match2/Operation/Backfill/AcceptBackfill.cs) | [AcceptBackfill](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/Backfill/AcceptBackfill.cs) |

### Match-Functions Wrapper:  [MatchFunctions](../../apis/AccelByte.Sdk.Api.Match2/Wrapper/MatchFunctions.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Match-Pools Wrapper:  [MatchPools](../../apis/AccelByte.Sdk.Api.Match2/Wrapper/MatchPools.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Match-Tickets Wrapper:  [MatchTickets](../../apis/AccelByte.Sdk.Api.Match2/Wrapper/MatchTickets.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Rule-Sets Wrapper:  [RuleSets](../../apis/AccelByte.Sdk.Api.Match2/Wrapper/RuleSets.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/match2/v1/namespaces/{namespace}/rulesets/{ruleset}` | GET | RuleSetDetails | [RuleSetDetails](../../apis/AccelByte.Sdk.Api.Match2/Operation/RuleSets/RuleSetDetails.cs) | [RuleSetDetails](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/RuleSets/RuleSetDetails.cs) |
| `/match2/v1/namespaces/{namespace}/rulesets/{ruleset}` | PUT | UpdateRuleSet | [UpdateRuleSet](../../apis/AccelByte.Sdk.Api.Match2/Operation/RuleSets/UpdateRuleSet.cs) | [UpdateRuleSet](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/RuleSets/UpdateRuleSet.cs) |


&nbsp;

## Models

| Model | Class |
|---|---|
| `api.BackFillAcceptRequest` | [ApiBackFillAcceptRequest](../../apis/AccelByte.Sdk.Api.Match2/Model/ApiBackFillAcceptRequest.cs) |
| `api.BackFillCreateRequest` | [ApiBackFillCreateRequest](../../apis/AccelByte.Sdk.Api.Match2/Model/ApiBackFillCreateRequest.cs) |
| `api.BackfillCreateResponse` | [ApiBackfillCreateResponse](../../apis/AccelByte.Sdk.Api.Match2/Model/ApiBackfillCreateResponse.cs) |
| `api.BackfillGetResponse` | [ApiBackfillGetResponse](../../apis/AccelByte.Sdk.Api.Match2/Model/ApiBackfillGetResponse.cs) |
| `api.BackfillProposalResponse` | [ApiBackfillProposalResponse](../../apis/AccelByte.Sdk.Api.Match2/Model/ApiBackfillProposalResponse.cs) |
| `api.ListEnvironmentVariablesResponse` | [ApiListEnvironmentVariablesResponse](../../apis/AccelByte.Sdk.Api.Match2/Model/ApiListEnvironmentVariablesResponse.cs) |
| `api.ListMatchFunctionsResponse` | [ApiListMatchFunctionsResponse](../../apis/AccelByte.Sdk.Api.Match2/Model/ApiListMatchFunctionsResponse.cs) |
| `api.ListMatchPoolsResponse` | [ApiListMatchPoolsResponse](../../apis/AccelByte.Sdk.Api.Match2/Model/ApiListMatchPoolsResponse.cs) |
| `api.ListRuleSetsResponse` | [ApiListRuleSetsResponse](../../apis/AccelByte.Sdk.Api.Match2/Model/ApiListRuleSetsResponse.cs) |
| `api.Match` | [ApiMatch](../../apis/AccelByte.Sdk.Api.Match2/Model/ApiMatch.cs) |
| `api.MatchFunctionConfig` | [ApiMatchFunctionConfig](../../apis/AccelByte.Sdk.Api.Match2/Model/ApiMatchFunctionConfig.cs) |
| `api.MatchFunctionOverride` | [ApiMatchFunctionOverride](../../apis/AccelByte.Sdk.Api.Match2/Model/ApiMatchFunctionOverride.cs) |
| `api.MatchFunctionRequest` | [ApiMatchFunctionRequest](../../apis/AccelByte.Sdk.Api.Match2/Model/ApiMatchFunctionRequest.cs) |
| `api.MatchPool` | [ApiMatchPool](../../apis/AccelByte.Sdk.Api.Match2/Model/ApiMatchPool.cs) |
| `api.MatchPoolConfig` | [ApiMatchPoolConfig](../../apis/AccelByte.Sdk.Api.Match2/Model/ApiMatchPoolConfig.cs) |
| `api.MatchRuleSetNameData` | [ApiMatchRuleSetNameData](../../apis/AccelByte.Sdk.Api.Match2/Model/ApiMatchRuleSetNameData.cs) |
| `api.MatchTicketRequest` | [ApiMatchTicketRequest](../../apis/AccelByte.Sdk.Api.Match2/Model/ApiMatchTicketRequest.cs) |
| `api.MatchTicketResponse` | [ApiMatchTicketResponse](../../apis/AccelByte.Sdk.Api.Match2/Model/ApiMatchTicketResponse.cs) |
| `api.MatchTicketStatus` | [ApiMatchTicketStatus](../../apis/AccelByte.Sdk.Api.Match2/Model/ApiMatchTicketStatus.cs) |
| `api.MatchTicketStatuses` | [ApiMatchTicketStatuses](../../apis/AccelByte.Sdk.Api.Match2/Model/ApiMatchTicketStatuses.cs) |
| `api.Party` | [ApiParty](../../apis/AccelByte.Sdk.Api.Match2/Model/ApiParty.cs) |
| `api.PlayerData` | [ApiPlayerData](../../apis/AccelByte.Sdk.Api.Match2/Model/ApiPlayerData.cs) |
| `api.PlayerMetricRecord` | [ApiPlayerMetricRecord](../../apis/AccelByte.Sdk.Api.Match2/Model/ApiPlayerMetricRecord.cs) |
| `api.ProposedProposal` | [ApiProposedProposal](../../apis/AccelByte.Sdk.Api.Match2/Model/ApiProposedProposal.cs) |
| `api.RuleSetPayload` | [ApiRuleSetPayload](../../apis/AccelByte.Sdk.Api.Match2/Model/ApiRuleSetPayload.cs) |
| `api.Team` | [ApiTeam](../../apis/AccelByte.Sdk.Api.Match2/Model/ApiTeam.cs) |
| `api.Ticket` | [ApiTicket](../../apis/AccelByte.Sdk.Api.Match2/Model/ApiTicket.cs) |
| `api.TicketMetricResultRecord` | [ApiTicketMetricResultRecord](../../apis/AccelByte.Sdk.Api.Match2/Model/ApiTicketMetricResultRecord.cs) |
| `api.backFillRejectRequest` | [ApiBackFillRejectRequest](../../apis/AccelByte.Sdk.Api.Match2/Model/ApiBackFillRejectRequest.cs) |
| `config.EnvironmentVariable` | [ConfigEnvironmentVariable](../../apis/AccelByte.Sdk.Api.Match2/Model/ConfigEnvironmentVariable.cs) |
| `matchmaker.Party` | [MatchmakerParty](../../apis/AccelByte.Sdk.Api.Match2/Model/MatchmakerParty.cs) |
| `matchmaker.Team` | [MatchmakerTeam](../../apis/AccelByte.Sdk.Api.Match2/Model/MatchmakerTeam.cs) |
| `models.Configuration` | [ModelsConfiguration](../../apis/AccelByte.Sdk.Api.Match2/Model/ModelsConfiguration.cs) |
| `models.DSInformation` | [ModelsDSInformation](../../apis/AccelByte.Sdk.Api.Match2/Model/ModelsDSInformation.cs) |
| `models.GameSession` | [ModelsGameSession](../../apis/AccelByte.Sdk.Api.Match2/Model/ModelsGameSession.cs) |
| `models.Pagination` | [ModelsPagination](../../apis/AccelByte.Sdk.Api.Match2/Model/ModelsPagination.cs) |
| `models.Server` | [ModelsServer](../../apis/AccelByte.Sdk.Api.Match2/Model/ModelsServer.cs) |
| `models.User` | [ModelsUser](../../apis/AccelByte.Sdk.Api.Match2/Model/ModelsUser.cs) |
| `response.Error` | [ResponseError](../../apis/AccelByte.Sdk.Api.Match2/Model/ResponseError.cs) |