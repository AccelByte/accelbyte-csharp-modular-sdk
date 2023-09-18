# Ams Service Index

&nbsp;

## Operations

### Auth Wrapper:  [Auth](../../apis/AccelByte.Sdk.Api.Ams/Wrapper/Auth.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/ams/auth` | GET | AuthCheck | [AuthCheck](../../apis/AccelByte.Sdk.Api.Ams/Operation/Auth/AuthCheck.cs) | [AuthCheck](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/Auth/AuthCheck.cs) |

### Fleet Commander Wrapper:  [FleetCommander](../../apis/AccelByte.Sdk.Api.Ams/Wrapper/FleetCommander.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/ams/healthz` | GET | PortalHealthCheck | [PortalHealthCheck](../../apis/AccelByte.Sdk.Api.Ams/Operation/FleetCommander/PortalHealthCheck.cs) | [PortalHealthCheck](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/FleetCommander/PortalHealthCheck.cs) |
| `/ams/version` | GET | Func1 | [Func1](../../apis/AccelByte.Sdk.Api.Ams/Operation/FleetCommander/Func1.cs) | [Func1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/FleetCommander/Func1.cs) |
| `/healthz` | GET | BasicHealthCheck | [BasicHealthCheck](../../apis/AccelByte.Sdk.Api.Ams/Operation/FleetCommander/BasicHealthCheck.cs) | [BasicHealthCheck](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/FleetCommander/BasicHealthCheck.cs) |

### Account Wrapper:  [Account](../../apis/AccelByte.Sdk.Api.Ams/Wrapper/Account.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/ams/v1/admin/namespaces/{namespace}/account` | GET | AccountGet | [AccountGet](../../apis/AccelByte.Sdk.Api.Ams/Operation/Account/AccountGet.cs) | [AccountGet](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/Account/AccountGet.cs) |
| `/ams/v1/admin/namespaces/{namespace}/account` | POST | AccountCreate | [AccountCreate](../../apis/AccelByte.Sdk.Api.Ams/Operation/Account/AccountCreate.cs) | [AccountCreate](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/Account/AccountCreate.cs) |
| `/ams/v1/admin/namespaces/{namespace}/account/link` | GET | AccountLinkTokenGet | [AccountLinkTokenGet](../../apis/AccelByte.Sdk.Api.Ams/Operation/Account/AccountLinkTokenGet.cs) | [AccountLinkTokenGet](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/Account/AccountLinkTokenGet.cs) |
| `/ams/v1/admin/namespaces/{namespace}/account/link` | POST | AccountLink | [AccountLink](../../apis/AccelByte.Sdk.Api.Ams/Operation/Account/AccountLink.cs) | [AccountLink](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/Account/AccountLink.cs) |

### Fleets Wrapper:  [Fleets](../../apis/AccelByte.Sdk.Api.Ams/Wrapper/Fleets.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/ams/v1/admin/namespaces/{namespace}/fleets` | GET | FleetList | [FleetList](../../apis/AccelByte.Sdk.Api.Ams/Operation/Fleets/FleetList.cs) | [FleetList](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/Fleets/FleetList.cs) |
| `/ams/v1/admin/namespaces/{namespace}/fleets` | POST | FleetCreate | [FleetCreate](../../apis/AccelByte.Sdk.Api.Ams/Operation/Fleets/FleetCreate.cs) | [FleetCreate](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/Fleets/FleetCreate.cs) |
| `/ams/v1/admin/namespaces/{namespace}/fleets/{fleetID}` | GET | FleetGet | [FleetGet](../../apis/AccelByte.Sdk.Api.Ams/Operation/Fleets/FleetGet.cs) | [FleetGet](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/Fleets/FleetGet.cs) |
| `/ams/v1/admin/namespaces/{namespace}/fleets/{fleetID}` | PUT | FleetUpdate | [FleetUpdate](../../apis/AccelByte.Sdk.Api.Ams/Operation/Fleets/FleetUpdate.cs) | [FleetUpdate](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/Fleets/FleetUpdate.cs) |
| `/ams/v1/admin/namespaces/{namespace}/fleets/{fleetID}` | DELETE | FleetDelete | [FleetDelete](../../apis/AccelByte.Sdk.Api.Ams/Operation/Fleets/FleetDelete.cs) | [FleetDelete](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/Fleets/FleetDelete.cs) |
| `/ams/v1/admin/namespaces/{namespace}/fleets/{fleetID}/servers` | GET | FleetServers | [FleetServers](../../apis/AccelByte.Sdk.Api.Ams/Operation/Fleets/FleetServers.cs) | [FleetServers](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/Fleets/FleetServers.cs) |
| `/ams/v1/namespaces/{namespace}/fleets/{fleetID}/claim` | PUT | FleetClaimByID | [FleetClaimByID](../../apis/AccelByte.Sdk.Api.Ams/Operation/Fleets/FleetClaimByID.cs) | [FleetClaimByID](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/Fleets/FleetClaimByID.cs) |
| `/ams/v1/namespaces/{namespace}/servers/claim` | PUT | FleetClaimByKeys | [FleetClaimByKeys](../../apis/AccelByte.Sdk.Api.Ams/Operation/Fleets/FleetClaimByKeys.cs) | [FleetClaimByKeys](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/Fleets/FleetClaimByKeys.cs) |

### Servers Wrapper:  [Servers](../../apis/AccelByte.Sdk.Api.Ams/Wrapper/Servers.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/ams/v1/admin/namespaces/{namespace}/fleets/{fleetID}/servers/history` | GET | FleetServerHistory | [FleetServerHistory](../../apis/AccelByte.Sdk.Api.Ams/Operation/Servers/FleetServerHistory.cs) | [FleetServerHistory](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/Servers/FleetServerHistory.cs) |
| `/ams/v1/admin/namespaces/{namespace}/servers/{serverID}` | GET | FleetServerInfo | [FleetServerInfo](../../apis/AccelByte.Sdk.Api.Ams/Operation/Servers/FleetServerInfo.cs) | [FleetServerInfo](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/Servers/FleetServerInfo.cs) |
| `/ams/v1/admin/namespaces/{namespace}/servers/{serverID}/history` | GET | ServerHistory | [ServerHistory](../../apis/AccelByte.Sdk.Api.Ams/Operation/Servers/ServerHistory.cs) | [ServerHistory](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/Servers/ServerHistory.cs) |

### Images Wrapper:  [Images](../../apis/AccelByte.Sdk.Api.Ams/Wrapper/Images.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/ams/v1/admin/namespaces/{namespace}/images` | GET | ImageList | [ImageList](../../apis/AccelByte.Sdk.Api.Ams/Operation/Images/ImageList.cs) | [ImageList](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/Images/ImageList.cs) |
| `/ams/v1/admin/namespaces/{namespace}/images/{imageID}` | GET | ImageGet | [ImageGet](../../apis/AccelByte.Sdk.Api.Ams/Operation/Images/ImageGet.cs) | [ImageGet](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/Images/ImageGet.cs) |
| `/ams/v1/admin/namespaces/{namespace}/images/{imageID}` | PATCH | ImagePatch | [ImagePatch](../../apis/AccelByte.Sdk.Api.Ams/Operation/Images/ImagePatch.cs) | [ImagePatch](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/Images/ImagePatch.cs) |

### AMS Info Wrapper:  [AMSInfo](../../apis/AccelByte.Sdk.Api.Ams/Wrapper/AMSInfo.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/ams/v1/admin/namespaces/{namespace}/regions` | GET | InfoRegions | [InfoRegions](../../apis/AccelByte.Sdk.Api.Ams/Operation/AMSInfo/InfoRegions.cs) | [InfoRegions](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/AMSInfo/InfoRegions.cs) |
| `/ams/v1/admin/namespaces/{namespace}/supported-instances` | GET | InfoSupportedInstances | [InfoSupportedInstances](../../apis/AccelByte.Sdk.Api.Ams/Operation/AMSInfo/InfoSupportedInstances.cs) | [InfoSupportedInstances](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/AMSInfo/InfoSupportedInstances.cs) |

### Watchdogs Wrapper:  [Watchdogs](../../apis/AccelByte.Sdk.Api.Ams/Wrapper/Watchdogs.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/ams/v1/namespaces/{namespace}/watchdogs/{watchdogID}/connect` | GET | WatchdogConnect | [WatchdogConnect](../../apis/AccelByte.Sdk.Api.Ams/Operation/Watchdogs/WatchdogConnect.cs) | [WatchdogConnect](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/Watchdogs/WatchdogConnect.cs) |


&nbsp;

## Operations with Generic Response

### Auth Wrapper:  [Auth](../../apis/AccelByte.Sdk.Api.Ams/Wrapper/Auth.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Fleet Commander Wrapper:  [FleetCommander](../../apis/AccelByte.Sdk.Api.Ams/Wrapper/FleetCommander.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Account Wrapper:  [Account](../../apis/AccelByte.Sdk.Api.Ams/Wrapper/Account.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Fleets Wrapper:  [Fleets](../../apis/AccelByte.Sdk.Api.Ams/Wrapper/Fleets.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Servers Wrapper:  [Servers](../../apis/AccelByte.Sdk.Api.Ams/Wrapper/Servers.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Images Wrapper:  [Images](../../apis/AccelByte.Sdk.Api.Ams/Wrapper/Images.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### AMS Info Wrapper:  [AMSInfo](../../apis/AccelByte.Sdk.Api.Ams/Wrapper/AMSInfo.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Watchdogs Wrapper:  [Watchdogs](../../apis/AccelByte.Sdk.Api.Ams/Wrapper/Watchdogs.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|


&nbsp;

## Models

| Model | Class |
|---|---|
| `api.AccountCreateRequest` | [ApiAccountCreateRequest](../../apis/AccelByte.Sdk.Api.Ams/Model/ApiAccountCreateRequest.cs) |
| `api.AccountCreateResponse` | [ApiAccountCreateResponse](../../apis/AccelByte.Sdk.Api.Ams/Model/ApiAccountCreateResponse.cs) |
| `api.AccountLinkRequest` | [ApiAccountLinkRequest](../../apis/AccelByte.Sdk.Api.Ams/Model/ApiAccountLinkRequest.cs) |
| `api.AccountLinkResponse` | [ApiAccountLinkResponse](../../apis/AccelByte.Sdk.Api.Ams/Model/ApiAccountLinkResponse.cs) |
| `api.AccountLinkTokenResponse` | [ApiAccountLinkTokenResponse](../../apis/AccelByte.Sdk.Api.Ams/Model/ApiAccountLinkTokenResponse.cs) |
| `api.AccountResponse` | [ApiAccountResponse](../../apis/AccelByte.Sdk.Api.Ams/Model/ApiAccountResponse.cs) |
| `api.AvailableInstanceTypesResponse` | [ApiAvailableInstanceTypesResponse](../../apis/AccelByte.Sdk.Api.Ams/Model/ApiAvailableInstanceTypesResponse.cs) |
| `api.DSHistoryEvent` | [ApiDSHistoryEvent](../../apis/AccelByte.Sdk.Api.Ams/Model/ApiDSHistoryEvent.cs) |
| `api.DSHistoryList` | [ApiDSHistoryList](../../apis/AccelByte.Sdk.Api.Ams/Model/ApiDSHistoryList.cs) |
| `api.DSHostConfiguration` | [ApiDSHostConfiguration](../../apis/AccelByte.Sdk.Api.Ams/Model/ApiDSHostConfiguration.cs) |
| `api.FleetClaimByKeysReq` | [ApiFleetClaimByKeysReq](../../apis/AccelByte.Sdk.Api.Ams/Model/ApiFleetClaimByKeysReq.cs) |
| `api.FleetClaimReq` | [ApiFleetClaimReq](../../apis/AccelByte.Sdk.Api.Ams/Model/ApiFleetClaimReq.cs) |
| `api.FleetClaimResponse` | [ApiFleetClaimResponse](../../apis/AccelByte.Sdk.Api.Ams/Model/ApiFleetClaimResponse.cs) |
| `api.FleetCreateResponse` | [ApiFleetCreateResponse](../../apis/AccelByte.Sdk.Api.Ams/Model/ApiFleetCreateResponse.cs) |
| `api.FleetGetResponse` | [ApiFleetGetResponse](../../apis/AccelByte.Sdk.Api.Ams/Model/ApiFleetGetResponse.cs) |
| `api.FleetListItemResponse` | [ApiFleetListItemResponse](../../apis/AccelByte.Sdk.Api.Ams/Model/ApiFleetListItemResponse.cs) |
| `api.FleetListResponse` | [ApiFleetListResponse](../../apis/AccelByte.Sdk.Api.Ams/Model/ApiFleetListResponse.cs) |
| `api.FleetParameters` | [ApiFleetParameters](../../apis/AccelByte.Sdk.Api.Ams/Model/ApiFleetParameters.cs) |
| `api.FleetRegionalServerCounts` | [ApiFleetRegionalServerCounts](../../apis/AccelByte.Sdk.Api.Ams/Model/ApiFleetRegionalServerCounts.cs) |
| `api.FleetServerHistoryEventResponse` | [ApiFleetServerHistoryEventResponse](../../apis/AccelByte.Sdk.Api.Ams/Model/ApiFleetServerHistoryEventResponse.cs) |
| `api.FleetServerHistoryResponse` | [ApiFleetServerHistoryResponse](../../apis/AccelByte.Sdk.Api.Ams/Model/ApiFleetServerHistoryResponse.cs) |
| `api.FleetServerInfoResponse` | [ApiFleetServerInfoResponse](../../apis/AccelByte.Sdk.Api.Ams/Model/ApiFleetServerInfoResponse.cs) |
| `api.FleetServersResponse` | [ApiFleetServersResponse](../../apis/AccelByte.Sdk.Api.Ams/Model/ApiFleetServersResponse.cs) |
| `api.ImageDeploymentProfile` | [ApiImageDeploymentProfile](../../apis/AccelByte.Sdk.Api.Ams/Model/ApiImageDeploymentProfile.cs) |
| `api.ImageDetails` | [ApiImageDetails](../../apis/AccelByte.Sdk.Api.Ams/Model/ApiImageDetails.cs) |
| `api.ImageList` | [ApiImageList](../../apis/AccelByte.Sdk.Api.Ams/Model/ApiImageList.cs) |
| `api.ImageListItem` | [ApiImageListItem](../../apis/AccelByte.Sdk.Api.Ams/Model/ApiImageListItem.cs) |
| `api.ImageUpdate` | [ApiImageUpdate](../../apis/AccelByte.Sdk.Api.Ams/Model/ApiImageUpdate.cs) |
| `api.InstanceTypeDescriptionResponse` | [ApiInstanceTypeDescriptionResponse](../../apis/AccelByte.Sdk.Api.Ams/Model/ApiInstanceTypeDescriptionResponse.cs) |
| `api.PagingInfo` | [ApiPagingInfo](../../apis/AccelByte.Sdk.Api.Ams/Model/ApiPagingInfo.cs) |
| `api.PortConfiguration` | [ApiPortConfiguration](../../apis/AccelByte.Sdk.Api.Ams/Model/ApiPortConfiguration.cs) |
| `api.ReferencingFleet` | [ApiReferencingFleet](../../apis/AccelByte.Sdk.Api.Ams/Model/ApiReferencingFleet.cs) |
| `api.RegionConfig` | [ApiRegionConfig](../../apis/AccelByte.Sdk.Api.Ams/Model/ApiRegionConfig.cs) |
| `api.RegionsResponse` | [ApiRegionsResponse](../../apis/AccelByte.Sdk.Api.Ams/Model/ApiRegionsResponse.cs) |
| `api.Timeout` | [ApiTimeout](../../apis/AccelByte.Sdk.Api.Ams/Model/ApiTimeout.cs) |
| `response.ErrorResponse` | [ResponseErrorResponse](../../apis/AccelByte.Sdk.Api.Ams/Model/ResponseErrorResponse.cs) |