# Dsmc Service Index

&nbsp;

## Operations

### Config Wrapper:  [Config](../../apis/AccelByte.Sdk.Api.Dsmc/Wrapper/Config.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/dsmcontroller/admin/configs` | GET | ListConfig | [ListConfig](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/Config/ListConfig.cs) | [ListConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/Config/ListConfig.cs) |
| [DEPRECATED] `/dsmcontroller/admin/configs` | POST | SaveConfig | [SaveConfig](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/Config/SaveConfig.cs) | [SaveConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/Config/SaveConfig.cs) |
| `/dsmcontroller/admin/namespaces/{namespace}/configs` | GET | GetConfig | [GetConfig](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/Config/GetConfig.cs) | [GetConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/Config/GetConfig.cs) |
| `/dsmcontroller/admin/namespaces/{namespace}/configs` | POST | CreateConfig | [CreateConfig](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/Config/CreateConfig.cs) | [CreateConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/Config/CreateConfig.cs) |
| `/dsmcontroller/admin/namespaces/{namespace}/configs` | DELETE | DeleteConfig | [DeleteConfig](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/Config/DeleteConfig.cs) | [DeleteConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/Config/DeleteConfig.cs) |
| `/dsmcontroller/admin/namespaces/{namespace}/configs` | PATCH | UpdateConfig | [UpdateConfig](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/Config/UpdateConfig.cs) | [UpdateConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/Config/UpdateConfig.cs) |
| `/dsmcontroller/admin/namespaces/{namespace}/configs/cache` | DELETE | ClearCache | [ClearCache](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/Config/ClearCache.cs) | [ClearCache](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/Config/ClearCache.cs) |
| `/dsmcontroller/admin/namespaces/{namespace}/configs/ports/{name}` | POST | AddPort | [AddPort](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/Config/AddPort.cs) | [AddPort](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/Config/AddPort.cs) |
| `/dsmcontroller/admin/namespaces/{namespace}/configs/ports/{name}` | DELETE | DeletePort | [DeletePort](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/Config/DeletePort.cs) | [DeletePort](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/Config/DeletePort.cs) |
| `/dsmcontroller/admin/namespaces/{namespace}/configs/ports/{name}` | PATCH | UpdatePort | [UpdatePort](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/Config/UpdatePort.cs) | [UpdatePort](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/Config/UpdatePort.cs) |
| `/dsmcontroller/admin/v1/namespaces/{namespace}/configs/export` | GET | ExportConfigV1 | [ExportConfigV1](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/Config/ExportConfigV1.cs) | [ExportConfigV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/Config/ExportConfigV1.cs) |
| `/dsmcontroller/admin/v1/namespaces/{namespace}/configs/import` | POST | ImportConfigV1 | [ImportConfigV1](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/Config/ImportConfigV1.cs) | [ImportConfigV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/Config/ImportConfigV1.cs) |

### Image Config Wrapper:  [ImageConfig](../../apis/AccelByte.Sdk.Api.Dsmc/Wrapper/ImageConfig.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/dsmcontroller/admin/images` | PUT | UpdateImage | [UpdateImage](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/ImageConfig/UpdateImage.cs) | [UpdateImage](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/ImageConfig/UpdateImage.cs) |
| `/dsmcontroller/admin/images` | POST | CreateImage | [CreateImage](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/ImageConfig/CreateImage.cs) | [CreateImage](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/ImageConfig/CreateImage.cs) |
| `/dsmcontroller/admin/images/import` | POST | ImportImages | [ImportImages](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/ImageConfig/ImportImages.cs) | [ImportImages](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/ImageConfig/ImportImages.cs) |
| `/dsmcontroller/admin/images/patches` | POST | CreateImagePatch | [CreateImagePatch](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/ImageConfig/CreateImagePatch.cs) | [CreateImagePatch](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/ImageConfig/CreateImagePatch.cs) |
| `/dsmcontroller/admin/namespaces/{namespace}/images` | GET | ListImages | [ListImages](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/ImageConfig/ListImages.cs) | [ListImages](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/ImageConfig/ListImages.cs) |
| `/dsmcontroller/admin/namespaces/{namespace}/images` | DELETE | DeleteImage | [DeleteImage](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/ImageConfig/DeleteImage.cs) | [DeleteImage](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/ImageConfig/DeleteImage.cs) |
| `/dsmcontroller/admin/namespaces/{namespace}/images/export` | GET | ExportImages | [ExportImages](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/ImageConfig/ExportImages.cs) | [ExportImages](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/ImageConfig/ExportImages.cs) |
| `/dsmcontroller/admin/namespaces/{namespace}/images/limit` | GET | GetImageLimit | [GetImageLimit](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/ImageConfig/GetImageLimit.cs) | [GetImageLimit](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/ImageConfig/GetImageLimit.cs) |
| `/dsmcontroller/admin/namespaces/{namespace}/images/patches` | DELETE | DeleteImagePatch | [DeleteImagePatch](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/ImageConfig/DeleteImagePatch.cs) | [DeleteImagePatch](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/ImageConfig/DeleteImagePatch.cs) |
| `/dsmcontroller/admin/namespaces/{namespace}/images/versions/{version}` | GET | GetImageDetail | [GetImageDetail](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/ImageConfig/GetImageDetail.cs) | [GetImageDetail](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/ImageConfig/GetImageDetail.cs) |
| `/dsmcontroller/admin/namespaces/{namespace}/images/versions/{version}/patches` | GET | GetImagePatches | [GetImagePatches](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/ImageConfig/GetImagePatches.cs) | [GetImagePatches](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/ImageConfig/GetImagePatches.cs) |
| `/dsmcontroller/admin/namespaces/{namespace}/images/versions/{version}/patches/{versionPatch}` | GET | GetImagePatchDetail | [GetImagePatchDetail](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/ImageConfig/GetImagePatchDetail.cs) | [GetImagePatchDetail](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/ImageConfig/GetImagePatchDetail.cs) |
| `/dsmcontroller/admin/namespaces/{namespace}/repository` | GET | GetRepository | [GetRepository](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/ImageConfig/GetRepository.cs) | [GetRepository](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/ImageConfig/GetRepository.cs) |
| `/dsmcontroller/admin/repository` | POST | CreateRepository | [CreateRepository](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/ImageConfig/CreateRepository.cs) | [CreateRepository](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/ImageConfig/CreateRepository.cs) |
| `/dsmcontroller/namespaces/{namespace}/images/limit` | GET | ImageLimitClient | [ImageLimitClient](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/ImageConfig/ImageLimitClient.cs) | [ImageLimitClient](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/ImageConfig/ImageLimitClient.cs) |
| `/dsmcontroller/namespaces/{namespace}/images/versions/{version}` | GET | ImageDetailClient | [ImageDetailClient](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/ImageConfig/ImageDetailClient.cs) | [ImageDetailClient](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/ImageConfig/ImageDetailClient.cs) |

### Pod Config Wrapper:  [PodConfig](../../apis/AccelByte.Sdk.Api.Dsmc/Wrapper/PodConfig.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/dsmcontroller/admin/instances/spec/lowest` | GET | GetLowestInstanceSpec | [GetLowestInstanceSpec](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/PodConfig/GetLowestInstanceSpec.cs) | [GetLowestInstanceSpec](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/PodConfig/GetLowestInstanceSpec.cs) |
| `/dsmcontroller/admin/namespaces/{namespace}/configs/pods` | GET | GetAllPodConfig | [GetAllPodConfig](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/PodConfig/GetAllPodConfig.cs) | [GetAllPodConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/PodConfig/GetAllPodConfig.cs) |
| `/dsmcontroller/admin/namespaces/{namespace}/configs/pods/{name}` | GET | GetPodConfig | [GetPodConfig](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/PodConfig/GetPodConfig.cs) | [GetPodConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/PodConfig/GetPodConfig.cs) |
| `/dsmcontroller/admin/namespaces/{namespace}/configs/pods/{name}` | POST | CreatePodConfig | [CreatePodConfig](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/PodConfig/CreatePodConfig.cs) | [CreatePodConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/PodConfig/CreatePodConfig.cs) |
| `/dsmcontroller/admin/namespaces/{namespace}/configs/pods/{name}` | DELETE | DeletePodConfig | [DeletePodConfig](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/PodConfig/DeletePodConfig.cs) | [DeletePodConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/PodConfig/DeletePodConfig.cs) |
| `/dsmcontroller/admin/namespaces/{namespace}/configs/pods/{name}` | PATCH | UpdatePodConfig | [UpdatePodConfig](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/PodConfig/UpdatePodConfig.cs) | [UpdatePodConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/PodConfig/UpdatePodConfig.cs) |
| `/dsmcontroller/namespaces/{namespace}/configs/pods` | GET | GetAllPodConfigClient | [GetAllPodConfigClient](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/PodConfig/GetAllPodConfigClient.cs) | [GetAllPodConfigClient](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/PodConfig/GetAllPodConfigClient.cs) |
| `/dsmcontroller/namespaces/{namespace}/configs/pods/{name}` | POST | CreatePodConfigClient | [CreatePodConfigClient](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/PodConfig/CreatePodConfigClient.cs) | [CreatePodConfigClient](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/PodConfig/CreatePodConfigClient.cs) |
| `/dsmcontroller/namespaces/{namespace}/configs/pods/{name}` | DELETE | DeletePodConfigClient | [DeletePodConfigClient](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/PodConfig/DeletePodConfigClient.cs) | [DeletePodConfigClient](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/PodConfig/DeletePodConfigClient.cs) |

### Deployment Config Wrapper:  [DeploymentConfig](../../apis/AccelByte.Sdk.Api.Dsmc/Wrapper/DeploymentConfig.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/dsmcontroller/admin/namespaces/{namespace}/configs/deployments` | GET | GetAllDeployment | [GetAllDeployment](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/DeploymentConfig/GetAllDeployment.cs) | [GetAllDeployment](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/DeploymentConfig/GetAllDeployment.cs) |
| `/dsmcontroller/admin/namespaces/{namespace}/configs/deployments/{deployment}` | GET | GetDeployment | [GetDeployment](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/DeploymentConfig/GetDeployment.cs) | [GetDeployment](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/DeploymentConfig/GetDeployment.cs) |
| `/dsmcontroller/admin/namespaces/{namespace}/configs/deployments/{deployment}` | POST | CreateDeployment | [CreateDeployment](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/DeploymentConfig/CreateDeployment.cs) | [CreateDeployment](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/DeploymentConfig/CreateDeployment.cs) |
| `/dsmcontroller/admin/namespaces/{namespace}/configs/deployments/{deployment}` | DELETE | DeleteDeployment | [DeleteDeployment](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/DeploymentConfig/DeleteDeployment.cs) | [DeleteDeployment](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/DeploymentConfig/DeleteDeployment.cs) |
| `/dsmcontroller/admin/namespaces/{namespace}/configs/deployments/{deployment}` | PATCH | UpdateDeployment | [UpdateDeployment](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/DeploymentConfig/UpdateDeployment.cs) | [UpdateDeployment](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/DeploymentConfig/UpdateDeployment.cs) |
| `/dsmcontroller/admin/namespaces/{namespace}/configs/deployments/{deployment}/overrides/regions/{region}` | POST | CreateRootRegionOverride | [CreateRootRegionOverride](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/DeploymentConfig/CreateRootRegionOverride.cs) | [CreateRootRegionOverride](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/DeploymentConfig/CreateRootRegionOverride.cs) |
| `/dsmcontroller/admin/namespaces/{namespace}/configs/deployments/{deployment}/overrides/regions/{region}` | DELETE | DeleteRootRegionOverride | [DeleteRootRegionOverride](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/DeploymentConfig/DeleteRootRegionOverride.cs) | [DeleteRootRegionOverride](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/DeploymentConfig/DeleteRootRegionOverride.cs) |
| `/dsmcontroller/admin/namespaces/{namespace}/configs/deployments/{deployment}/overrides/regions/{region}` | PATCH | UpdateRootRegionOverride | [UpdateRootRegionOverride](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/DeploymentConfig/UpdateRootRegionOverride.cs) | [UpdateRootRegionOverride](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/DeploymentConfig/UpdateRootRegionOverride.cs) |
| `/dsmcontroller/admin/namespaces/{namespace}/configs/deployments/{deployment}/overrides/version/{version}` | POST | CreateDeploymentOverride | [CreateDeploymentOverride](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/DeploymentConfig/CreateDeploymentOverride.cs) | [CreateDeploymentOverride](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/DeploymentConfig/CreateDeploymentOverride.cs) |
| `/dsmcontroller/admin/namespaces/{namespace}/configs/deployments/{deployment}/overrides/versions/{version}` | DELETE | DeleteDeploymentOverride | [DeleteDeploymentOverride](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/DeploymentConfig/DeleteDeploymentOverride.cs) | [DeleteDeploymentOverride](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/DeploymentConfig/DeleteDeploymentOverride.cs) |
| `/dsmcontroller/admin/namespaces/{namespace}/configs/deployments/{deployment}/overrides/versions/{version}` | PATCH | UpdateDeploymentOverride | [UpdateDeploymentOverride](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/DeploymentConfig/UpdateDeploymentOverride.cs) | [UpdateDeploymentOverride](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/DeploymentConfig/UpdateDeploymentOverride.cs) |
| `/dsmcontroller/admin/namespaces/{namespace}/configs/deployments/{deployment}/overrides/versions/{version}/regions/{region}` | POST | CreateOverrideRegionOverride | [CreateOverrideRegionOverride](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/DeploymentConfig/CreateOverrideRegionOverride.cs) | [CreateOverrideRegionOverride](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/DeploymentConfig/CreateOverrideRegionOverride.cs) |
| `/dsmcontroller/admin/namespaces/{namespace}/configs/deployments/{deployment}/overrides/versions/{version}/regions/{region}` | DELETE | DeleteOverrideRegionOverride | [DeleteOverrideRegionOverride](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/DeploymentConfig/DeleteOverrideRegionOverride.cs) | [DeleteOverrideRegionOverride](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/DeploymentConfig/DeleteOverrideRegionOverride.cs) |
| `/dsmcontroller/admin/namespaces/{namespace}/configs/deployments/{deployment}/overrides/versions/{version}/regions/{region}` | PATCH | UpdateOverrideRegionOverride | [UpdateOverrideRegionOverride](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/DeploymentConfig/UpdateOverrideRegionOverride.cs) | [UpdateOverrideRegionOverride](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/DeploymentConfig/UpdateOverrideRegionOverride.cs) |
| `/dsmcontroller/namespaces/{namespace}/configs/deployments` | GET | GetAllDeploymentClient | [GetAllDeploymentClient](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/DeploymentConfig/GetAllDeploymentClient.cs) | [GetAllDeploymentClient](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/DeploymentConfig/GetAllDeploymentClient.cs) |
| `/dsmcontroller/namespaces/{namespace}/configs/deployments/{deployment}` | POST | CreateDeploymentClient | [CreateDeploymentClient](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/DeploymentConfig/CreateDeploymentClient.cs) | [CreateDeploymentClient](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/DeploymentConfig/CreateDeploymentClient.cs) |
| `/dsmcontroller/namespaces/{namespace}/configs/deployments/{deployment}` | DELETE | DeleteDeploymentClient | [DeleteDeploymentClient](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/DeploymentConfig/DeleteDeploymentClient.cs) | [DeleteDeploymentClient](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/DeploymentConfig/DeleteDeploymentClient.cs) |

### Admin Wrapper:  [Admin](../../apis/AccelByte.Sdk.Api.Dsmc/Wrapper/Admin.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/dsmcontroller/admin/namespaces/{namespace}/servers` | GET | ListServer | [ListServer](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/Admin/ListServer.cs) | [ListServer](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/Admin/ListServer.cs) |
| `/dsmcontroller/admin/namespaces/{namespace}/servers/count` | GET | CountServer | [CountServer](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/Admin/CountServer.cs) | [CountServer](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/Admin/CountServer.cs) |
| `/dsmcontroller/admin/namespaces/{namespace}/servers/count/detailed` | GET | CountServerDetailed | [CountServerDetailed](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/Admin/CountServerDetailed.cs) | [CountServerDetailed](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/Admin/CountServerDetailed.cs) |
| `/dsmcontroller/admin/namespaces/{namespace}/servers/local` | GET | ListLocalServer | [ListLocalServer](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/Admin/ListLocalServer.cs) | [ListLocalServer](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/Admin/ListLocalServer.cs) |
| `/dsmcontroller/admin/namespaces/{namespace}/servers/local/{name}` | DELETE | DeleteLocalServer | [DeleteLocalServer](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/Admin/DeleteLocalServer.cs) | [DeleteLocalServer](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/Admin/DeleteLocalServer.cs) |
| `/dsmcontroller/admin/namespaces/{namespace}/servers/{podName}` | GET | GetServer | [GetServer](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/Admin/GetServer.cs) | [GetServer](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/Admin/GetServer.cs) |
| `/dsmcontroller/admin/namespaces/{namespace}/servers/{podName}` | DELETE | DeleteServer | [DeleteServer](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/Admin/DeleteServer.cs) | [DeleteServer](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/Admin/DeleteServer.cs) |
| `/dsmcontroller/admin/namespaces/{namespace}/sessions` | GET | ListSession | [ListSession](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/Admin/ListSession.cs) | [ListSession](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/Admin/ListSession.cs) |
| `/dsmcontroller/admin/namespaces/{namespace}/sessions/count` | GET | CountSession | [CountSession](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/Admin/CountSession.cs) | [CountSession](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/Admin/CountSession.cs) |
| `/dsmcontroller/admin/namespaces/{namespace}/sessions/{sessionID}` | DELETE | DeleteSession | [DeleteSession](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/Admin/DeleteSession.cs) | [DeleteSession](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/Admin/DeleteSession.cs) |

### Server Wrapper:  [Server](../../apis/AccelByte.Sdk.Api.Dsmc/Wrapper/Server.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/dsmcontroller/namespaces/{namespace}/servers` | GET | ListServerClient | [ListServerClient](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/Server/ListServerClient.cs) | [ListServerClient](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/Server/ListServerClient.cs) |
| `/dsmcontroller/namespaces/{namespace}/servers/heartbeat` | PUT | ServerHeartbeat | [ServerHeartbeat](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/Server/ServerHeartbeat.cs) | [ServerHeartbeat](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/Server/ServerHeartbeat.cs) |
| `/dsmcontroller/namespaces/{namespace}/servers/local/deregister` | POST | DeregisterLocalServer | [DeregisterLocalServer](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/Server/DeregisterLocalServer.cs) | [DeregisterLocalServer](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/Server/DeregisterLocalServer.cs) |
| `/dsmcontroller/namespaces/{namespace}/servers/local/register` | POST | RegisterLocalServer | [RegisterLocalServer](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/Server/RegisterLocalServer.cs) | [RegisterLocalServer](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/Server/RegisterLocalServer.cs) |
| `/dsmcontroller/namespaces/{namespace}/servers/register` | POST | RegisterServer | [RegisterServer](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/Server/RegisterServer.cs) | [RegisterServer](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/Server/RegisterServer.cs) |
| `/dsmcontroller/namespaces/{namespace}/servers/shutdown` | POST | ShutdownServer | [ShutdownServer](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/Server/ShutdownServer.cs) | [ShutdownServer](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/Server/ShutdownServer.cs) |
| `/dsmcontroller/namespaces/{namespace}/servers/{podName}/config/sessiontimeout` | GET | GetServerSessionTimeout | [GetServerSessionTimeout](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/Server/GetServerSessionTimeout.cs) | [GetServerSessionTimeout](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/Server/GetServerSessionTimeout.cs) |
| `/dsmcontroller/namespaces/{namespace}/servers/{podName}/session` | GET | GetServerSession | [GetServerSession](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/Server/GetServerSession.cs) | [GetServerSession](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/Server/GetServerSession.cs) |

### Session Wrapper:  [Session](../../apis/AccelByte.Sdk.Api.Dsmc/Wrapper/Session.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/dsmcontroller/namespaces/{namespace}/sessions` | POST | CreateSession | [CreateSession](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/Session/CreateSession.cs) | [CreateSession](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/Session/CreateSession.cs) |
| `/dsmcontroller/namespaces/{namespace}/sessions/claim` | POST | ClaimServer | [ClaimServer](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/Session/ClaimServer.cs) | [ClaimServer](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/Session/ClaimServer.cs) |
| `/dsmcontroller/namespaces/{namespace}/sessions/{sessionID}` | GET | GetSession | [GetSession](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/Session/GetSession.cs) | [GetSession](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/Session/GetSession.cs) |
| `/dsmcontroller/namespaces/{namespace}/sessions/{sessionID}/cancel` | DELETE | CancelSession | [CancelSession](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/Session/CancelSession.cs) | [CancelSession](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/Session/CancelSession.cs) |

### Public Wrapper:  [Public](../../apis/AccelByte.Sdk.Api.Dsmc/Wrapper/Public.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/dsmcontroller/public/provider/default` | GET | GetDefaultProvider | [GetDefaultProvider](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/Public/GetDefaultProvider.cs) | [GetDefaultProvider](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/Public/GetDefaultProvider.cs) |
| `/dsmcontroller/public/providers` | GET | ListProviders | [ListProviders](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/Public/ListProviders.cs) | [ListProviders](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/Public/ListProviders.cs) |
| `/dsmcontroller/public/providers/regions/{region}` | GET | ListProvidersByRegion | [ListProvidersByRegion](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/Public/ListProvidersByRegion.cs) | [ListProvidersByRegion](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/Public/ListProvidersByRegion.cs) |

### Dsmc Operations Wrapper:  [DsmcOperations](../../apis/AccelByte.Sdk.Api.Dsmc/Wrapper/DsmcOperations.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/dsmcontroller/v1/messages` | GET | PublicGetMessages | [PublicGetMessages](../../apis/AccelByte.Sdk.Api.Dsmc/Operation/DsmcOperations/PublicGetMessages.cs) | [PublicGetMessages](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsmc/DsmcOperations/PublicGetMessages.cs) |


&nbsp;

## Operations with Generic Response

### Config Wrapper:  [Config](../../apis/AccelByte.Sdk.Api.Dsmc/Wrapper/Config.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Image Config Wrapper:  [ImageConfig](../../apis/AccelByte.Sdk.Api.Dsmc/Wrapper/ImageConfig.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Pod Config Wrapper:  [PodConfig](../../apis/AccelByte.Sdk.Api.Dsmc/Wrapper/PodConfig.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Deployment Config Wrapper:  [DeploymentConfig](../../apis/AccelByte.Sdk.Api.Dsmc/Wrapper/DeploymentConfig.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Admin Wrapper:  [Admin](../../apis/AccelByte.Sdk.Api.Dsmc/Wrapper/Admin.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Server Wrapper:  [Server](../../apis/AccelByte.Sdk.Api.Dsmc/Wrapper/Server.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Session Wrapper:  [Session](../../apis/AccelByte.Sdk.Api.Dsmc/Wrapper/Session.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Public Wrapper:  [Public](../../apis/AccelByte.Sdk.Api.Dsmc/Wrapper/Public.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Dsmc Operations Wrapper:  [DsmcOperations](../../apis/AccelByte.Sdk.Api.Dsmc/Wrapper/DsmcOperations.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|


&nbsp;

## Models

| Model | Class |
|---|---|
| `log.AppMessageDeclaration` | [LogAppMessageDeclaration](../../apis/AccelByte.Sdk.Api.Dsmc/Model/LogAppMessageDeclaration.cs) |
| `models.AllocationEvent` | [ModelsAllocationEvent](../../apis/AccelByte.Sdk.Api.Dsmc/Model/ModelsAllocationEvent.cs) |
| `models.ClaimSessionRequest` | [ModelsClaimSessionRequest](../../apis/AccelByte.Sdk.Api.Dsmc/Model/ModelsClaimSessionRequest.cs) |
| `models.CountServerResponse` | [ModelsCountServerResponse](../../apis/AccelByte.Sdk.Api.Dsmc/Model/ModelsCountServerResponse.cs) |
| `models.CountSessionResponse` | [ModelsCountSessionResponse](../../apis/AccelByte.Sdk.Api.Dsmc/Model/ModelsCountSessionResponse.cs) |
| `models.CreateDSMConfigRequest` | [ModelsCreateDSMConfigRequest](../../apis/AccelByte.Sdk.Api.Dsmc/Model/ModelsCreateDSMConfigRequest.cs) |
| `models.CreateDeploymentOverrideRequest` | [ModelsCreateDeploymentOverrideRequest](../../apis/AccelByte.Sdk.Api.Dsmc/Model/ModelsCreateDeploymentOverrideRequest.cs) |
| `models.CreateDeploymentRequest` | [ModelsCreateDeploymentRequest](../../apis/AccelByte.Sdk.Api.Dsmc/Model/ModelsCreateDeploymentRequest.cs) |
| `models.CreateImagePatchRequest` | [ModelsCreateImagePatchRequest](../../apis/AccelByte.Sdk.Api.Dsmc/Model/ModelsCreateImagePatchRequest.cs) |
| `models.CreateImageRequest` | [ModelsCreateImageRequest](../../apis/AccelByte.Sdk.Api.Dsmc/Model/ModelsCreateImageRequest.cs) |
| `models.CreatePodConfigRequest` | [ModelsCreatePodConfigRequest](../../apis/AccelByte.Sdk.Api.Dsmc/Model/ModelsCreatePodConfigRequest.cs) |
| `models.CreatePortRequest` | [ModelsCreatePortRequest](../../apis/AccelByte.Sdk.Api.Dsmc/Model/ModelsCreatePortRequest.cs) |
| `models.CreateRegionOverrideRequest` | [ModelsCreateRegionOverrideRequest](../../apis/AccelByte.Sdk.Api.Dsmc/Model/ModelsCreateRegionOverrideRequest.cs) |
| `models.CreateRepositoryRequest` | [ModelsCreateRepositoryRequest](../../apis/AccelByte.Sdk.Api.Dsmc/Model/ModelsCreateRepositoryRequest.cs) |
| `models.CreateSessionRequest` | [ModelsCreateSessionRequest](../../apis/AccelByte.Sdk.Api.Dsmc/Model/ModelsCreateSessionRequest.cs) |
| `models.DSHeartbeatRequest` | [ModelsDSHeartbeatRequest](../../apis/AccelByte.Sdk.Api.Dsmc/Model/ModelsDSHeartbeatRequest.cs) |
| `models.DSMConfigRecord` | [ModelsDSMConfigRecord](../../apis/AccelByte.Sdk.Api.Dsmc/Model/ModelsDSMConfigRecord.cs) |
| `models.DefaultProvider` | [ModelsDefaultProvider](../../apis/AccelByte.Sdk.Api.Dsmc/Model/ModelsDefaultProvider.cs) |
| `models.DeploymentConfigOverride` | [ModelsDeploymentConfigOverride](../../apis/AccelByte.Sdk.Api.Dsmc/Model/ModelsDeploymentConfigOverride.cs) |
| `models.DeploymentWithOverride` | [ModelsDeploymentWithOverride](../../apis/AccelByte.Sdk.Api.Dsmc/Model/ModelsDeploymentWithOverride.cs) |
| `models.DeregisterLocalServerRequest` | [ModelsDeregisterLocalServerRequest](../../apis/AccelByte.Sdk.Api.Dsmc/Model/ModelsDeregisterLocalServerRequest.cs) |
| `models.DetailedCountServerResponse` | [ModelsDetailedCountServerResponse](../../apis/AccelByte.Sdk.Api.Dsmc/Model/ModelsDetailedCountServerResponse.cs) |
| `models.GetImageDetailResponse` | [ModelsGetImageDetailResponse](../../apis/AccelByte.Sdk.Api.Dsmc/Model/ModelsGetImageDetailResponse.cs) |
| `models.GetImageLimitResponse` | [ModelsGetImageLimitResponse](../../apis/AccelByte.Sdk.Api.Dsmc/Model/ModelsGetImageLimitResponse.cs) |
| `models.GetImageLimitResponseData` | [ModelsGetImageLimitResponseData](../../apis/AccelByte.Sdk.Api.Dsmc/Model/ModelsGetImageLimitResponseData.cs) |
| `models.GetImagePatchDetailResponse` | [ModelsGetImagePatchDetailResponse](../../apis/AccelByte.Sdk.Api.Dsmc/Model/ModelsGetImagePatchDetailResponse.cs) |
| `models.ImageRecord` | [ModelsImageRecord](../../apis/AccelByte.Sdk.Api.Dsmc/Model/ModelsImageRecord.cs) |
| `models.ImageRecordUpdate` | [ModelsImageRecordUpdate](../../apis/AccelByte.Sdk.Api.Dsmc/Model/ModelsImageRecordUpdate.cs) |
| `models.ImportResponse` | [ModelsImportResponse](../../apis/AccelByte.Sdk.Api.Dsmc/Model/ModelsImportResponse.cs) |
| `models.InstanceSpec` | [ModelsInstanceSpec](../../apis/AccelByte.Sdk.Api.Dsmc/Model/ModelsInstanceSpec.cs) |
| `models.ListConfigResponse` | [ModelsListConfigResponse](../../apis/AccelByte.Sdk.Api.Dsmc/Model/ModelsListConfigResponse.cs) |
| `models.ListDeploymentResponse` | [ModelsListDeploymentResponse](../../apis/AccelByte.Sdk.Api.Dsmc/Model/ModelsListDeploymentResponse.cs) |
| `models.ListImagePatchesResponse` | [ModelsListImagePatchesResponse](../../apis/AccelByte.Sdk.Api.Dsmc/Model/ModelsListImagePatchesResponse.cs) |
| `models.ListImageResponse` | [ModelsListImageResponse](../../apis/AccelByte.Sdk.Api.Dsmc/Model/ModelsListImageResponse.cs) |
| `models.ListPodConfigResponse` | [ModelsListPodConfigResponse](../../apis/AccelByte.Sdk.Api.Dsmc/Model/ModelsListPodConfigResponse.cs) |
| `models.ListServerResponse` | [ModelsListServerResponse](../../apis/AccelByte.Sdk.Api.Dsmc/Model/ModelsListServerResponse.cs) |
| `models.ListSessionResponse` | [ModelsListSessionResponse](../../apis/AccelByte.Sdk.Api.Dsmc/Model/ModelsListSessionResponse.cs) |
| `models.MatchResult.notification_payload` | [ModelsMatchResultNotificationPayload](../../apis/AccelByte.Sdk.Api.Dsmc/Model/ModelsMatchResultNotificationPayload.cs) |
| `models.PagingCursor` | [ModelsPagingCursor](../../apis/AccelByte.Sdk.Api.Dsmc/Model/ModelsPagingCursor.cs) |
| `models.PatchImageRecord` | [ModelsPatchImageRecord](../../apis/AccelByte.Sdk.Api.Dsmc/Model/ModelsPatchImageRecord.cs) |
| `models.PodConfigRecord` | [ModelsPodConfigRecord](../../apis/AccelByte.Sdk.Api.Dsmc/Model/ModelsPodConfigRecord.cs) |
| `models.PodCountConfigOverride` | [ModelsPodCountConfigOverride](../../apis/AccelByte.Sdk.Api.Dsmc/Model/ModelsPodCountConfigOverride.cs) |
| `models.RegisterLocalServerRequest` | [ModelsRegisterLocalServerRequest](../../apis/AccelByte.Sdk.Api.Dsmc/Model/ModelsRegisterLocalServerRequest.cs) |
| `models.RegisterServerRequest` | [ModelsRegisterServerRequest](../../apis/AccelByte.Sdk.Api.Dsmc/Model/ModelsRegisterServerRequest.cs) |
| `models.RepositoryRecord` | [ModelsRepositoryRecord](../../apis/AccelByte.Sdk.Api.Dsmc/Model/ModelsRepositoryRecord.cs) |
| `models.RequestMatchMember` | [ModelsRequestMatchMember](../../apis/AccelByte.Sdk.Api.Dsmc/Model/ModelsRequestMatchMember.cs) |
| `models.RequestMatchParty` | [ModelsRequestMatchParty](../../apis/AccelByte.Sdk.Api.Dsmc/Model/ModelsRequestMatchParty.cs) |
| `models.RequestMatchingAlly` | [ModelsRequestMatchingAlly](../../apis/AccelByte.Sdk.Api.Dsmc/Model/ModelsRequestMatchingAlly.cs) |
| `models.Server` | [ModelsServer](../../apis/AccelByte.Sdk.Api.Dsmc/Model/ModelsServer.cs) |
| `models.ServerDeploymentConfigSessionTimeoutResponse` | [ModelsServerDeploymentConfigSessionTimeoutResponse](../../apis/AccelByte.Sdk.Api.Dsmc/Model/ModelsServerDeploymentConfigSessionTimeoutResponse.cs) |
| `models.ServerSessionResponse` | [ModelsServerSessionResponse](../../apis/AccelByte.Sdk.Api.Dsmc/Model/ModelsServerSessionResponse.cs) |
| `models.Session` | [ModelsSession](../../apis/AccelByte.Sdk.Api.Dsmc/Model/ModelsSession.cs) |
| `models.SessionResponse` | [ModelsSessionResponse](../../apis/AccelByte.Sdk.Api.Dsmc/Model/ModelsSessionResponse.cs) |
| `models.ShutdownServerRequest` | [ModelsShutdownServerRequest](../../apis/AccelByte.Sdk.Api.Dsmc/Model/ModelsShutdownServerRequest.cs) |
| `models.StatusHistory` | [ModelsStatusHistory](../../apis/AccelByte.Sdk.Api.Dsmc/Model/ModelsStatusHistory.cs) |
| `models.UpdateDSMConfigRequest` | [ModelsUpdateDSMConfigRequest](../../apis/AccelByte.Sdk.Api.Dsmc/Model/ModelsUpdateDSMConfigRequest.cs) |
| `models.UpdateDeploymentOverrideRequest` | [ModelsUpdateDeploymentOverrideRequest](../../apis/AccelByte.Sdk.Api.Dsmc/Model/ModelsUpdateDeploymentOverrideRequest.cs) |
| `models.UpdateDeploymentRequest` | [ModelsUpdateDeploymentRequest](../../apis/AccelByte.Sdk.Api.Dsmc/Model/ModelsUpdateDeploymentRequest.cs) |
| `models.UpdatePodConfigRequest` | [ModelsUpdatePodConfigRequest](../../apis/AccelByte.Sdk.Api.Dsmc/Model/ModelsUpdatePodConfigRequest.cs) |
| `models.UpdatePortRequest` | [ModelsUpdatePortRequest](../../apis/AccelByte.Sdk.Api.Dsmc/Model/ModelsUpdatePortRequest.cs) |
| `models.UpdateRegionOverrideRequest` | [ModelsUpdateRegionOverrideRequest](../../apis/AccelByte.Sdk.Api.Dsmc/Model/ModelsUpdateRegionOverrideRequest.cs) |
| `models.UploaderFlag` | [ModelsUploaderFlag](../../apis/AccelByte.Sdk.Api.Dsmc/Model/ModelsUploaderFlag.cs) |
| `response.Error` | [ResponseError](../../apis/AccelByte.Sdk.Api.Dsmc/Model/ResponseError.cs) |