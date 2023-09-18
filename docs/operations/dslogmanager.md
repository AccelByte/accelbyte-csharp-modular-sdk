# Dslogmanager Service Index

&nbsp;

## Operations

### Admin Wrapper:  [Admin](../../apis/AccelByte.Sdk.Api.Dslogmanager/Wrapper/Admin.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/dslogmanager/admin/namespaces/{namespace}/servers/{podName}/logs` | GET | GetServerLogs | [GetServerLogs](../../apis/AccelByte.Sdk.Api.Dslogmanager/Operation/Admin/GetServerLogs.cs) | [GetServerLogs](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dslogmanager/Admin/GetServerLogs.cs) |

### Terminated Servers Wrapper:  [TerminatedServers](../../apis/AccelByte.Sdk.Api.Dslogmanager/Wrapper/TerminatedServers.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/dslogmanager/namespaces/{namespace}/servers/search` | GET | ListTerminatedServers | [ListTerminatedServers](../../apis/AccelByte.Sdk.Api.Dslogmanager/Operation/TerminatedServers/ListTerminatedServers.cs) | [ListTerminatedServers](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dslogmanager/TerminatedServers/ListTerminatedServers.cs) |
| `/dslogmanager/namespaces/{namespace}/servers/{podName}/logs/download` | GET | DownloadServerLogs | [DownloadServerLogs](../../apis/AccelByte.Sdk.Api.Dslogmanager/Operation/TerminatedServers/DownloadServerLogs.cs) | [DownloadServerLogs](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dslogmanager/TerminatedServers/DownloadServerLogs.cs) |
| `/dslogmanager/namespaces/{namespace}/servers/{podName}/logs/exists` | GET | CheckServerLogs | [CheckServerLogs](../../apis/AccelByte.Sdk.Api.Dslogmanager/Operation/TerminatedServers/CheckServerLogs.cs) | [CheckServerLogs](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dslogmanager/TerminatedServers/CheckServerLogs.cs) |

### All Terminated Servers Wrapper:  [AllTerminatedServers](../../apis/AccelByte.Sdk.Api.Dslogmanager/Wrapper/AllTerminatedServers.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/dslogmanager/servers/logs/download` | POST | BatchDownloadServerLogs | [BatchDownloadServerLogs](../../apis/AccelByte.Sdk.Api.Dslogmanager/Operation/AllTerminatedServers/BatchDownloadServerLogs.cs) | [BatchDownloadServerLogs](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dslogmanager/AllTerminatedServers/BatchDownloadServerLogs.cs) |
| `/dslogmanager/servers/search` | GET | ListAllTerminatedServers | [ListAllTerminatedServers](../../apis/AccelByte.Sdk.Api.Dslogmanager/Operation/AllTerminatedServers/ListAllTerminatedServers.cs) | [ListAllTerminatedServers](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dslogmanager/AllTerminatedServers/ListAllTerminatedServers.cs) |

### Dslogmanager Operations Wrapper:  [DslogmanagerOperations](../../apis/AccelByte.Sdk.Api.Dslogmanager/Wrapper/DslogmanagerOperations.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/dslogmanager/v1/messages` | GET | PublicGetMessages | [PublicGetMessages](../../apis/AccelByte.Sdk.Api.Dslogmanager/Operation/DslogmanagerOperations/PublicGetMessages.cs) | [PublicGetMessages](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dslogmanager/DslogmanagerOperations/PublicGetMessages.cs) |


&nbsp;

## Operations with Generic Response

### Admin Wrapper:  [Admin](../../apis/AccelByte.Sdk.Api.Dslogmanager/Wrapper/Admin.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Terminated Servers Wrapper:  [TerminatedServers](../../apis/AccelByte.Sdk.Api.Dslogmanager/Wrapper/TerminatedServers.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### All Terminated Servers Wrapper:  [AllTerminatedServers](../../apis/AccelByte.Sdk.Api.Dslogmanager/Wrapper/AllTerminatedServers.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Dslogmanager Operations Wrapper:  [DslogmanagerOperations](../../apis/AccelByte.Sdk.Api.Dslogmanager/Wrapper/DslogmanagerOperations.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|


&nbsp;

## Models

| Model | Class |
|---|---|
| `log.AppMessageDeclaration` | [LogAppMessageDeclaration](../../apis/AccelByte.Sdk.Api.Dslogmanager/Model/LogAppMessageDeclaration.cs) |
| `models.AllocationEvent` | [ModelsAllocationEvent](../../apis/AccelByte.Sdk.Api.Dslogmanager/Model/ModelsAllocationEvent.cs) |
| `models.BatchDownloadLogsRequest` | [ModelsBatchDownloadLogsRequest](../../apis/AccelByte.Sdk.Api.Dslogmanager/Model/ModelsBatchDownloadLogsRequest.cs) |
| `models.DownloadLogsRequest` | [ModelsDownloadLogsRequest](../../apis/AccelByte.Sdk.Api.Dslogmanager/Model/ModelsDownloadLogsRequest.cs) |
| `models.ListTerminatedServersResponse` | [ModelsListTerminatedServersResponse](../../apis/AccelByte.Sdk.Api.Dslogmanager/Model/ModelsListTerminatedServersResponse.cs) |
| `models.LogFileStatus` | [ModelsLogFileStatus](../../apis/AccelByte.Sdk.Api.Dslogmanager/Model/ModelsLogFileStatus.cs) |
| `models.MatchResult` | [ModelsMatchResult](../../apis/AccelByte.Sdk.Api.Dslogmanager/Model/ModelsMatchResult.cs) |
| `models.NotifPayloadServerStatusChange` | [ModelsNotifPayloadServerStatusChange](../../apis/AccelByte.Sdk.Api.Dslogmanager/Model/ModelsNotifPayloadServerStatusChange.cs) |
| `models.PagingCursor` | [ModelsPagingCursor](../../apis/AccelByte.Sdk.Api.Dslogmanager/Model/ModelsPagingCursor.cs) |
| `models.RequestMatchMember` | [ModelsRequestMatchMember](../../apis/AccelByte.Sdk.Api.Dslogmanager/Model/ModelsRequestMatchMember.cs) |
| `models.RequestMatchParty` | [ModelsRequestMatchParty](../../apis/AccelByte.Sdk.Api.Dslogmanager/Model/ModelsRequestMatchParty.cs) |
| `models.RequestMatchingAlly` | [ModelsRequestMatchingAlly](../../apis/AccelByte.Sdk.Api.Dslogmanager/Model/ModelsRequestMatchingAlly.cs) |
| `models.Server` | [ModelsServer](../../apis/AccelByte.Sdk.Api.Dslogmanager/Model/ModelsServer.cs) |
| `models.ServerLogs` | [ModelsServerLogs](../../apis/AccelByte.Sdk.Api.Dslogmanager/Model/ModelsServerLogs.cs) |
| `models.StatusHistory` | [ModelsStatusHistory](../../apis/AccelByte.Sdk.Api.Dslogmanager/Model/ModelsStatusHistory.cs) |
| `response.Error` | [ResponseError](../../apis/AccelByte.Sdk.Api.Dslogmanager/Model/ResponseError.cs) |
