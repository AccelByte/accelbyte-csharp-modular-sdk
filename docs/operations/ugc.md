# Ugc Service Index

&nbsp;

## Operations

### Admin Channel Wrapper:  [AdminChannel](../../apis/AccelByte.Sdk.Api.Ugc/Wrapper/AdminChannel.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/ugc/v1/admin/namespaces/{namespace}/channels` | GET | SingleAdminGetChannel | [SingleAdminGetChannel](../../apis/AccelByte.Sdk.Api.Ugc/Operation/AdminChannel/SingleAdminGetChannel.cs) | [SingleAdminGetChannel](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminChannel/SingleAdminGetChannel.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/channels` | POST | AdminCreateChannel | [AdminCreateChannel](../../apis/AccelByte.Sdk.Api.Ugc/Operation/AdminChannel/AdminCreateChannel.cs) | [AdminCreateChannel](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminChannel/AdminCreateChannel.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/channels/{channelId}` | PUT | SingleAdminUpdateChannel | [SingleAdminUpdateChannel](../../apis/AccelByte.Sdk.Api.Ugc/Operation/AdminChannel/SingleAdminUpdateChannel.cs) | [SingleAdminUpdateChannel](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminChannel/SingleAdminUpdateChannel.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/channels/{channelId}` | DELETE | SingleAdminDeleteChannel | [SingleAdminDeleteChannel](../../apis/AccelByte.Sdk.Api.Ugc/Operation/AdminChannel/SingleAdminDeleteChannel.cs) | [SingleAdminDeleteChannel](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminChannel/SingleAdminDeleteChannel.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/users/{userId}/channels` | GET | AdminGetChannel | [AdminGetChannel](../../apis/AccelByte.Sdk.Api.Ugc/Operation/AdminChannel/AdminGetChannel.cs) | [AdminGetChannel](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminChannel/AdminGetChannel.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/users/{userId}/channels/{channelId}` | PUT | AdminUpdateChannel | [AdminUpdateChannel](../../apis/AccelByte.Sdk.Api.Ugc/Operation/AdminChannel/AdminUpdateChannel.cs) | [AdminUpdateChannel](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminChannel/AdminUpdateChannel.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/users/{userId}/channels/{channelId}` | DELETE | AdminDeleteChannel | [AdminDeleteChannel](../../apis/AccelByte.Sdk.Api.Ugc/Operation/AdminChannel/AdminDeleteChannel.cs) | [AdminDeleteChannel](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminChannel/AdminDeleteChannel.cs) |

### Admin Content Wrapper:  [AdminContent](../../apis/AccelByte.Sdk.Api.Ugc/Wrapper/AdminContent.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| [DEPRECATED] `/ugc/v1/admin/namespaces/{namespace}/channels/{channelId}/contents` | POST | AdminUploadContentDirect | [AdminUploadContentDirect](../../apis/AccelByte.Sdk.Api.Ugc/Operation/AdminContent/AdminUploadContentDirect.cs) | [AdminUploadContentDirect](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/AdminUploadContentDirect.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/channels/{channelId}/contents/s3` | POST | AdminUploadContentS3 | [AdminUploadContentS3](../../apis/AccelByte.Sdk.Api.Ugc/Operation/AdminContent/AdminUploadContentS3.cs) | [AdminUploadContentS3](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/AdminUploadContentS3.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/channels/{channelId}/contents/s3/{contentId}` | PUT | SingleAdminUpdateContentS3 | [SingleAdminUpdateContentS3](../../apis/AccelByte.Sdk.Api.Ugc/Operation/AdminContent/SingleAdminUpdateContentS3.cs) | [SingleAdminUpdateContentS3](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/SingleAdminUpdateContentS3.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/channels/{channelId}/contents/search` | GET | AdminSearchChannelSpecificContent | [AdminSearchChannelSpecificContent](../../apis/AccelByte.Sdk.Api.Ugc/Operation/AdminContent/AdminSearchChannelSpecificContent.cs) | [AdminSearchChannelSpecificContent](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/AdminSearchChannelSpecificContent.cs) |
| [DEPRECATED] `/ugc/v1/admin/namespaces/{namespace}/channels/{channelId}/contents/{contentId}` | PUT | SingleAdminUpdateContentDirect | [SingleAdminUpdateContentDirect](../../apis/AccelByte.Sdk.Api.Ugc/Operation/AdminContent/SingleAdminUpdateContentDirect.cs) | [SingleAdminUpdateContentDirect](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/SingleAdminUpdateContentDirect.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/channels/{channelId}/contents/{contentId}` | DELETE | SingleAdminDeleteContent | [SingleAdminDeleteContent](../../apis/AccelByte.Sdk.Api.Ugc/Operation/AdminContent/SingleAdminDeleteContent.cs) | [SingleAdminDeleteContent](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/SingleAdminDeleteContent.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/contents` | GET | SingleAdminGetContent | [SingleAdminGetContent](../../apis/AccelByte.Sdk.Api.Ugc/Operation/AdminContent/SingleAdminGetContent.cs) | [SingleAdminGetContent](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/SingleAdminGetContent.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/contents/bulk` | POST | AdminGetContentBulk | [AdminGetContentBulk](../../apis/AccelByte.Sdk.Api.Ugc/Operation/AdminContent/AdminGetContentBulk.cs) | [AdminGetContentBulk](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/AdminGetContentBulk.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/contents/search` | GET | AdminSearchContent | [AdminSearchContent](../../apis/AccelByte.Sdk.Api.Ugc/Operation/AdminContent/AdminSearchContent.cs) | [AdminSearchContent](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/AdminSearchContent.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/contents/sharecodes/{shareCode}` | GET | AdminGetUserContentByShareCode | [AdminGetUserContentByShareCode](../../apis/AccelByte.Sdk.Api.Ugc/Operation/AdminContent/AdminGetUserContentByShareCode.cs) | [AdminGetUserContentByShareCode](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/AdminGetUserContentByShareCode.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/contents/{contentId}` | GET | AdminGetSpecificContent | [AdminGetSpecificContent](../../apis/AccelByte.Sdk.Api.Ugc/Operation/AdminContent/AdminGetSpecificContent.cs) | [AdminGetSpecificContent](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/AdminGetSpecificContent.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/contents/{contentId}/preview` | GET | AdminDownloadContentPreview | [AdminDownloadContentPreview](../../apis/AccelByte.Sdk.Api.Ugc/Operation/AdminContent/AdminDownloadContentPreview.cs) | [AdminDownloadContentPreview](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/AdminDownloadContentPreview.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/contents/{contentId}/screenshots` | PUT | AdminUpdateScreenshots | [AdminUpdateScreenshots](../../apis/AccelByte.Sdk.Api.Ugc/Operation/AdminContent/AdminUpdateScreenshots.cs) | [AdminUpdateScreenshots](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/AdminUpdateScreenshots.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/contents/{contentId}/screenshots` | POST | AdminUploadContentScreenshot | [AdminUploadContentScreenshot](../../apis/AccelByte.Sdk.Api.Ugc/Operation/AdminContent/AdminUploadContentScreenshot.cs) | [AdminUploadContentScreenshot](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/AdminUploadContentScreenshot.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/contents/{contentId}/screenshots/{screenshotId}` | DELETE | AdminDeleteContentScreenshot | [AdminDeleteContentScreenshot](../../apis/AccelByte.Sdk.Api.Ugc/Operation/AdminContent/AdminDeleteContentScreenshot.cs) | [AdminDeleteContentScreenshot](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/AdminDeleteContentScreenshot.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/s3/{contentId}` | PUT | AdminUpdateContentS3 | [AdminUpdateContentS3](../../apis/AccelByte.Sdk.Api.Ugc/Operation/AdminContent/AdminUpdateContentS3.cs) | [AdminUpdateContentS3](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/AdminUpdateContentS3.cs) |
| [DEPRECATED] `/ugc/v1/admin/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/{contentId}` | PUT | AdminUpdateContentDirect | [AdminUpdateContentDirect](../../apis/AccelByte.Sdk.Api.Ugc/Operation/AdminContent/AdminUpdateContentDirect.cs) | [AdminUpdateContentDirect](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/AdminUpdateContentDirect.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/{contentId}` | DELETE | AdminDeleteContent | [AdminDeleteContent](../../apis/AccelByte.Sdk.Api.Ugc/Operation/AdminContent/AdminDeleteContent.cs) | [AdminDeleteContent](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/AdminDeleteContent.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/users/{userId}/contents` | GET | AdminGetContent | [AdminGetContent](../../apis/AccelByte.Sdk.Api.Ugc/Operation/AdminContent/AdminGetContent.cs) | [AdminGetContent](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/AdminGetContent.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/users/{userId}/contents/{contentId}/hide` | PUT | AdminHideUserContent | [AdminHideUserContent](../../apis/AccelByte.Sdk.Api.Ugc/Operation/AdminContent/AdminHideUserContent.cs) | [AdminHideUserContent](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/AdminHideUserContent.cs) |

### Admin Group Wrapper:  [AdminGroup](../../apis/AccelByte.Sdk.Api.Ugc/Wrapper/AdminGroup.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/ugc/v1/admin/namespaces/{namespace}/groups` | GET | SingleAdminGetAllGroups | [SingleAdminGetAllGroups](../../apis/AccelByte.Sdk.Api.Ugc/Operation/AdminGroup/SingleAdminGetAllGroups.cs) | [SingleAdminGetAllGroups](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminGroup/SingleAdminGetAllGroups.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/groups` | POST | AdminCreateGroup | [AdminCreateGroup](../../apis/AccelByte.Sdk.Api.Ugc/Operation/AdminGroup/AdminCreateGroup.cs) | [AdminCreateGroup](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminGroup/AdminCreateGroup.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/groups/{groupId}` | GET | SingleAdminGetGroup | [SingleAdminGetGroup](../../apis/AccelByte.Sdk.Api.Ugc/Operation/AdminGroup/SingleAdminGetGroup.cs) | [SingleAdminGetGroup](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminGroup/SingleAdminGetGroup.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/groups/{groupId}` | PUT | SingleAdminUpdateGroup | [SingleAdminUpdateGroup](../../apis/AccelByte.Sdk.Api.Ugc/Operation/AdminGroup/SingleAdminUpdateGroup.cs) | [SingleAdminUpdateGroup](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminGroup/SingleAdminUpdateGroup.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/groups/{groupId}` | DELETE | SingleAdminDeleteGroup | [SingleAdminDeleteGroup](../../apis/AccelByte.Sdk.Api.Ugc/Operation/AdminGroup/SingleAdminDeleteGroup.cs) | [SingleAdminDeleteGroup](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminGroup/SingleAdminDeleteGroup.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/groups/{groupId}/contents` | GET | SingleAdminGetGroupContents | [SingleAdminGetGroupContents](../../apis/AccelByte.Sdk.Api.Ugc/Operation/AdminGroup/SingleAdminGetGroupContents.cs) | [SingleAdminGetGroupContents](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminGroup/SingleAdminGetGroupContents.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/users/{userId}/groups` | GET | AdminGetAllGroups | [AdminGetAllGroups](../../apis/AccelByte.Sdk.Api.Ugc/Operation/AdminGroup/AdminGetAllGroups.cs) | [AdminGetAllGroups](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminGroup/AdminGetAllGroups.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/users/{userId}/groups/{groupId}` | GET | AdminGetGroup | [AdminGetGroup](../../apis/AccelByte.Sdk.Api.Ugc/Operation/AdminGroup/AdminGetGroup.cs) | [AdminGetGroup](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminGroup/AdminGetGroup.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/users/{userId}/groups/{groupId}` | PUT | AdminUpdateGroup | [AdminUpdateGroup](../../apis/AccelByte.Sdk.Api.Ugc/Operation/AdminGroup/AdminUpdateGroup.cs) | [AdminUpdateGroup](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminGroup/AdminUpdateGroup.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/users/{userId}/groups/{groupId}` | DELETE | AdminDeleteGroup | [AdminDeleteGroup](../../apis/AccelByte.Sdk.Api.Ugc/Operation/AdminGroup/AdminDeleteGroup.cs) | [AdminDeleteGroup](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminGroup/AdminDeleteGroup.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/users/{userId}/groups/{groupId}/contents` | GET | AdminGetGroupContents | [AdminGetGroupContents](../../apis/AccelByte.Sdk.Api.Ugc/Operation/AdminGroup/AdminGetGroupContents.cs) | [AdminGetGroupContents](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminGroup/AdminGetGroupContents.cs) |

### Admin Tag Wrapper:  [AdminTag](../../apis/AccelByte.Sdk.Api.Ugc/Wrapper/AdminTag.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/ugc/v1/admin/namespaces/{namespace}/tags` | GET | AdminGetTag | [AdminGetTag](../../apis/AccelByte.Sdk.Api.Ugc/Operation/AdminTag/AdminGetTag.cs) | [AdminGetTag](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminTag/AdminGetTag.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/tags` | POST | AdminCreateTag | [AdminCreateTag](../../apis/AccelByte.Sdk.Api.Ugc/Operation/AdminTag/AdminCreateTag.cs) | [AdminCreateTag](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminTag/AdminCreateTag.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/tags/{tagId}` | PUT | AdminUpdateTag | [AdminUpdateTag](../../apis/AccelByte.Sdk.Api.Ugc/Operation/AdminTag/AdminUpdateTag.cs) | [AdminUpdateTag](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminTag/AdminUpdateTag.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/tags/{tagId}` | DELETE | AdminDeleteTag | [AdminDeleteTag](../../apis/AccelByte.Sdk.Api.Ugc/Operation/AdminTag/AdminDeleteTag.cs) | [AdminDeleteTag](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminTag/AdminDeleteTag.cs) |

### Admin Type Wrapper:  [AdminType](../../apis/AccelByte.Sdk.Api.Ugc/Wrapper/AdminType.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/ugc/v1/admin/namespaces/{namespace}/types` | GET | AdminGetType | [AdminGetType](../../apis/AccelByte.Sdk.Api.Ugc/Operation/AdminType/AdminGetType.cs) | [AdminGetType](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminType/AdminGetType.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/types` | POST | AdminCreateType | [AdminCreateType](../../apis/AccelByte.Sdk.Api.Ugc/Operation/AdminType/AdminCreateType.cs) | [AdminCreateType](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminType/AdminCreateType.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/types/{typeId}` | PUT | AdminUpdateType | [AdminUpdateType](../../apis/AccelByte.Sdk.Api.Ugc/Operation/AdminType/AdminUpdateType.cs) | [AdminUpdateType](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminType/AdminUpdateType.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/types/{typeId}` | DELETE | AdminDeleteType | [AdminDeleteType](../../apis/AccelByte.Sdk.Api.Ugc/Operation/AdminType/AdminDeleteType.cs) | [AdminDeleteType](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminType/AdminDeleteType.cs) |

### Anonymization Wrapper:  [Anonymization](../../apis/AccelByte.Sdk.Api.Ugc/Wrapper/Anonymization.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/ugc/v1/admin/namespaces/{namespace}/users/{userId}/channels` | DELETE | AdminDeleteAllUserChannels | [AdminDeleteAllUserChannels](../../apis/AccelByte.Sdk.Api.Ugc/Operation/Anonymization/AdminDeleteAllUserChannels.cs) | [AdminDeleteAllUserChannels](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/Anonymization/AdminDeleteAllUserChannels.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/users/{userId}/contents` | DELETE | AdminDeleteAllUserContents | [AdminDeleteAllUserContents](../../apis/AccelByte.Sdk.Api.Ugc/Operation/Anonymization/AdminDeleteAllUserContents.cs) | [AdminDeleteAllUserContents](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/Anonymization/AdminDeleteAllUserContents.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/users/{userId}/groups` | DELETE | AdminDeleteAllUserGroup | [AdminDeleteAllUserGroup](../../apis/AccelByte.Sdk.Api.Ugc/Operation/Anonymization/AdminDeleteAllUserGroup.cs) | [AdminDeleteAllUserGroup](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/Anonymization/AdminDeleteAllUserGroup.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/users/{userId}/states` | DELETE | AdminDeleteAllUserStates | [AdminDeleteAllUserStates](../../apis/AccelByte.Sdk.Api.Ugc/Operation/Anonymization/AdminDeleteAllUserStates.cs) | [AdminDeleteAllUserStates](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/Anonymization/AdminDeleteAllUserStates.cs) |
| `/ugc/v1/public/namespaces/{namespace}/users/{userId}/channels` | DELETE | DeleteAllUserChannel | [DeleteAllUserChannel](../../apis/AccelByte.Sdk.Api.Ugc/Operation/Anonymization/DeleteAllUserChannel.cs) | [DeleteAllUserChannel](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/Anonymization/DeleteAllUserChannel.cs) |
| `/ugc/v1/public/namespaces/{namespace}/users/{userId}/contents` | DELETE | DeleteAllUserContents | [DeleteAllUserContents](../../apis/AccelByte.Sdk.Api.Ugc/Operation/Anonymization/DeleteAllUserContents.cs) | [DeleteAllUserContents](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/Anonymization/DeleteAllUserContents.cs) |
| `/ugc/v1/public/namespaces/{namespace}/users/{userId}/groups` | DELETE | DeleteAllUserGroup | [DeleteAllUserGroup](../../apis/AccelByte.Sdk.Api.Ugc/Operation/Anonymization/DeleteAllUserGroup.cs) | [DeleteAllUserGroup](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/Anonymization/DeleteAllUserGroup.cs) |
| `/ugc/v1/public/namespaces/{namespace}/users/{userId}/states` | DELETE | DeleteAllUserStates | [DeleteAllUserStates](../../apis/AccelByte.Sdk.Api.Ugc/Operation/Anonymization/DeleteAllUserStates.cs) | [DeleteAllUserStates](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/Anonymization/DeleteAllUserStates.cs) |

### Public Content Wrapper:  [PublicContent](../../apis/AccelByte.Sdk.Api.Ugc/Wrapper/PublicContent.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/ugc/v1/public/namespaces/{namespace}/channels/{channelId}/contents` | GET | SearchChannelSpecificContent | [SearchChannelSpecificContent](../../apis/AccelByte.Sdk.Api.Ugc/Operation/PublicContent/SearchChannelSpecificContent.cs) | [SearchChannelSpecificContent](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContent/SearchChannelSpecificContent.cs) |
| `/ugc/v1/public/namespaces/{namespace}/contents` | GET | PublicSearchContent | [PublicSearchContent](../../apis/AccelByte.Sdk.Api.Ugc/Operation/PublicContent/PublicSearchContent.cs) | [PublicSearchContent](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContent/PublicSearchContent.cs) |
| `/ugc/v1/public/namespaces/{namespace}/contents/bulk` | POST | PublicGetContentBulk | [PublicGetContentBulk](../../apis/AccelByte.Sdk.Api.Ugc/Operation/PublicContent/PublicGetContentBulk.cs) | [PublicGetContentBulk](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContent/PublicGetContentBulk.cs) |
| `/ugc/v1/public/namespaces/{namespace}/contents/sharecodes/{shareCode}` | GET | PublicDownloadContentByShareCode | [PublicDownloadContentByShareCode](../../apis/AccelByte.Sdk.Api.Ugc/Operation/PublicContent/PublicDownloadContentByShareCode.cs) | [PublicDownloadContentByShareCode](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContent/PublicDownloadContentByShareCode.cs) |
| `/ugc/v1/public/namespaces/{namespace}/contents/{contentId}` | GET | PublicDownloadContentByContentID | [PublicDownloadContentByContentID](../../apis/AccelByte.Sdk.Api.Ugc/Operation/PublicContent/PublicDownloadContentByContentID.cs) | [PublicDownloadContentByContentID](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContent/PublicDownloadContentByContentID.cs) |
| `/ugc/v1/public/namespaces/{namespace}/contents/{contentId}/preview` | GET | PublicDownloadContentPreview | [PublicDownloadContentPreview](../../apis/AccelByte.Sdk.Api.Ugc/Operation/PublicContent/PublicDownloadContentPreview.cs) | [PublicDownloadContentPreview](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContent/PublicDownloadContentPreview.cs) |
| [DEPRECATED] `/ugc/v1/public/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents` | POST | CreateContentDirect | [CreateContentDirect](../../apis/AccelByte.Sdk.Api.Ugc/Operation/PublicContent/CreateContentDirect.cs) | [CreateContentDirect](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContent/CreateContentDirect.cs) |
| `/ugc/v1/public/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/s3` | POST | CreateContentS3 | [CreateContentS3](../../apis/AccelByte.Sdk.Api.Ugc/Operation/PublicContent/CreateContentS3.cs) | [CreateContentS3](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContent/CreateContentS3.cs) |
| `/ugc/v1/public/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/s3/{contentId}` | PUT | UpdateContentS3 | [UpdateContentS3](../../apis/AccelByte.Sdk.Api.Ugc/Operation/PublicContent/UpdateContentS3.cs) | [UpdateContentS3](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContent/UpdateContentS3.cs) |
| [DEPRECATED] `/ugc/v1/public/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/{contentId}` | PUT | UpdateContentDirect | [UpdateContentDirect](../../apis/AccelByte.Sdk.Api.Ugc/Operation/PublicContent/UpdateContentDirect.cs) | [UpdateContentDirect](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContent/UpdateContentDirect.cs) |
| `/ugc/v1/public/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/{contentId}` | DELETE | DeleteContent | [DeleteContent](../../apis/AccelByte.Sdk.Api.Ugc/Operation/PublicContent/DeleteContent.cs) | [DeleteContent](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContent/DeleteContent.cs) |
| `/ugc/v1/public/namespaces/{namespace}/users/{userId}/contents` | GET | PublicGetUserContent | [PublicGetUserContent](../../apis/AccelByte.Sdk.Api.Ugc/Operation/PublicContent/PublicGetUserContent.cs) | [PublicGetUserContent](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContent/PublicGetUserContent.cs) |
| `/ugc/v1/public/namespaces/{namespace}/users/{userId}/contents/{contentId}/screenshots` | PUT | UpdateScreenshots | [UpdateScreenshots](../../apis/AccelByte.Sdk.Api.Ugc/Operation/PublicContent/UpdateScreenshots.cs) | [UpdateScreenshots](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContent/UpdateScreenshots.cs) |
| `/ugc/v1/public/namespaces/{namespace}/users/{userId}/contents/{contentId}/screenshots` | POST | UploadContentScreenshot | [UploadContentScreenshot](../../apis/AccelByte.Sdk.Api.Ugc/Operation/PublicContent/UploadContentScreenshot.cs) | [UploadContentScreenshot](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContent/UploadContentScreenshot.cs) |
| `/ugc/v1/public/namespaces/{namespace}/users/{userId}/contents/{contentId}/screenshots/{screenshotId}` | DELETE | DeleteContentScreenshot | [DeleteContentScreenshot](../../apis/AccelByte.Sdk.Api.Ugc/Operation/PublicContent/DeleteContentScreenshot.cs) | [DeleteContentScreenshot](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContent/DeleteContentScreenshot.cs) |

### Public Follow Wrapper:  [PublicFollow](../../apis/AccelByte.Sdk.Api.Ugc/Wrapper/PublicFollow.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/ugc/v1/public/namespaces/{namespace}/contents/followed` | GET | GetFollowedContent | [GetFollowedContent](../../apis/AccelByte.Sdk.Api.Ugc/Operation/PublicFollow/GetFollowedContent.cs) | [GetFollowedContent](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicFollow/GetFollowedContent.cs) |
| `/ugc/v1/public/namespaces/{namespace}/users/followed` | GET | GetFollowedUsers | [GetFollowedUsers](../../apis/AccelByte.Sdk.Api.Ugc/Operation/PublicFollow/GetFollowedUsers.cs) | [GetFollowedUsers](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicFollow/GetFollowedUsers.cs) |
| `/ugc/v1/public/namespaces/{namespace}/users/{userId}/follow` | PUT | UpdateUserFollowStatus | [UpdateUserFollowStatus](../../apis/AccelByte.Sdk.Api.Ugc/Operation/PublicFollow/UpdateUserFollowStatus.cs) | [UpdateUserFollowStatus](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicFollow/UpdateUserFollowStatus.cs) |
| `/ugc/v1/public/namespaces/{namespace}/users/{userId}/followers` | GET | GetPublicFollowers | [GetPublicFollowers](../../apis/AccelByte.Sdk.Api.Ugc/Operation/PublicFollow/GetPublicFollowers.cs) | [GetPublicFollowers](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicFollow/GetPublicFollowers.cs) |
| `/ugc/v1/public/namespaces/{namespace}/users/{userId}/following` | GET | GetPublicFollowing | [GetPublicFollowing](../../apis/AccelByte.Sdk.Api.Ugc/Operation/PublicFollow/GetPublicFollowing.cs) | [GetPublicFollowing](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicFollow/GetPublicFollowing.cs) |

### Public Like Wrapper:  [PublicLike](../../apis/AccelByte.Sdk.Api.Ugc/Wrapper/PublicLike.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/ugc/v1/public/namespaces/{namespace}/contents/liked` | GET | GetLikedContent | [GetLikedContent](../../apis/AccelByte.Sdk.Api.Ugc/Operation/PublicLike/GetLikedContent.cs) | [GetLikedContent](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicLike/GetLikedContent.cs) |
| `/ugc/v1/public/namespaces/{namespace}/contents/{contentId}/like` | PUT | UpdateContentLikeStatus | [UpdateContentLikeStatus](../../apis/AccelByte.Sdk.Api.Ugc/Operation/PublicLike/UpdateContentLikeStatus.cs) | [UpdateContentLikeStatus](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicLike/UpdateContentLikeStatus.cs) |

### Public Download Count Wrapper:  [PublicDownloadCount](../../apis/AccelByte.Sdk.Api.Ugc/Wrapper/PublicDownloadCount.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/ugc/v1/public/namespaces/{namespace}/contents/{contentId}/downloadcount` | POST | AddDownloadCount | [AddDownloadCount](../../apis/AccelByte.Sdk.Api.Ugc/Operation/PublicDownloadCount/AddDownloadCount.cs) | [AddDownloadCount](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicDownloadCount/AddDownloadCount.cs) |

### Public Tag Wrapper:  [PublicTag](../../apis/AccelByte.Sdk.Api.Ugc/Wrapper/PublicTag.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/ugc/v1/public/namespaces/{namespace}/tags` | GET | GetTag | [GetTag](../../apis/AccelByte.Sdk.Api.Ugc/Operation/PublicTag/GetTag.cs) | [GetTag](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicTag/GetTag.cs) |

### Public Type Wrapper:  [PublicType](../../apis/AccelByte.Sdk.Api.Ugc/Wrapper/PublicType.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/ugc/v1/public/namespaces/{namespace}/types` | GET | GetType | [GetType](../../apis/AccelByte.Sdk.Api.Ugc/Operation/PublicType/GetType.cs) | [GetType](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicType/GetType.cs) |

### Public Creator Wrapper:  [PublicCreator](../../apis/AccelByte.Sdk.Api.Ugc/Wrapper/PublicCreator.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/ugc/v1/public/namespaces/{namespace}/users` | GET | PublicSearchCreator | [PublicSearchCreator](../../apis/AccelByte.Sdk.Api.Ugc/Operation/PublicCreator/PublicSearchCreator.cs) | [PublicSearchCreator](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicCreator/PublicSearchCreator.cs) |
| `/ugc/v1/public/namespaces/{namespace}/users/{userId}` | GET | PublicGetCreator | [PublicGetCreator](../../apis/AccelByte.Sdk.Api.Ugc/Operation/PublicCreator/PublicGetCreator.cs) | [PublicGetCreator](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicCreator/PublicGetCreator.cs) |

### Public Channel Wrapper:  [PublicChannel](../../apis/AccelByte.Sdk.Api.Ugc/Wrapper/PublicChannel.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/ugc/v1/public/namespaces/{namespace}/users/{userId}/channels` | GET | GetChannels | [GetChannels](../../apis/AccelByte.Sdk.Api.Ugc/Operation/PublicChannel/GetChannels.cs) | [GetChannels](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicChannel/GetChannels.cs) |
| `/ugc/v1/public/namespaces/{namespace}/users/{userId}/channels` | POST | PublicCreateChannel | [PublicCreateChannel](../../apis/AccelByte.Sdk.Api.Ugc/Operation/PublicChannel/PublicCreateChannel.cs) | [PublicCreateChannel](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicChannel/PublicCreateChannel.cs) |
| `/ugc/v1/public/namespaces/{namespace}/users/{userId}/channels/{channelId}` | PUT | UpdateChannel | [UpdateChannel](../../apis/AccelByte.Sdk.Api.Ugc/Operation/PublicChannel/UpdateChannel.cs) | [UpdateChannel](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicChannel/UpdateChannel.cs) |
| `/ugc/v1/public/namespaces/{namespace}/users/{userId}/channels/{channelId}` | DELETE | DeleteChannel | [DeleteChannel](../../apis/AccelByte.Sdk.Api.Ugc/Operation/PublicChannel/DeleteChannel.cs) | [DeleteChannel](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicChannel/DeleteChannel.cs) |

### Public Group Wrapper:  [PublicGroup](../../apis/AccelByte.Sdk.Api.Ugc/Wrapper/PublicGroup.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/ugc/v1/public/namespaces/{namespace}/users/{userId}/groups` | GET | GetGroups | [GetGroups](../../apis/AccelByte.Sdk.Api.Ugc/Operation/PublicGroup/GetGroups.cs) | [GetGroups](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicGroup/GetGroups.cs) |
| `/ugc/v1/public/namespaces/{namespace}/users/{userId}/groups` | POST | CreateGroup | [CreateGroup](../../apis/AccelByte.Sdk.Api.Ugc/Operation/PublicGroup/CreateGroup.cs) | [CreateGroup](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicGroup/CreateGroup.cs) |
| `/ugc/v1/public/namespaces/{namespace}/users/{userId}/groups/{groupId}` | GET | GetGroup | [GetGroup](../../apis/AccelByte.Sdk.Api.Ugc/Operation/PublicGroup/GetGroup.cs) | [GetGroup](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicGroup/GetGroup.cs) |
| `/ugc/v1/public/namespaces/{namespace}/users/{userId}/groups/{groupId}` | PUT | UpdateGroup | [UpdateGroup](../../apis/AccelByte.Sdk.Api.Ugc/Operation/PublicGroup/UpdateGroup.cs) | [UpdateGroup](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicGroup/UpdateGroup.cs) |
| `/ugc/v1/public/namespaces/{namespace}/users/{userId}/groups/{groupId}` | DELETE | DeleteGroup | [DeleteGroup](../../apis/AccelByte.Sdk.Api.Ugc/Operation/PublicGroup/DeleteGroup.cs) | [DeleteGroup](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicGroup/DeleteGroup.cs) |
| `/ugc/v1/public/namespaces/{namespace}/users/{userId}/groups/{groupId}/contents` | GET | GetGroupContent | [GetGroupContent](../../apis/AccelByte.Sdk.Api.Ugc/Operation/PublicGroup/GetGroupContent.cs) | [GetGroupContent](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicGroup/GetGroupContent.cs) |


&nbsp;

## Operations with Generic Response

### Admin Channel Wrapper:  [AdminChannel](../../apis/AccelByte.Sdk.Api.Ugc/Wrapper/AdminChannel.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Admin Content Wrapper:  [AdminContent](../../apis/AccelByte.Sdk.Api.Ugc/Wrapper/AdminContent.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| [DEPRECATED] `/ugc/v1/admin/namespaces/{namespace}/channels/{channelId}/contents` | POST | AdminUploadContentDirect | [AdminUploadContentDirect](../../apis/AccelByte.Sdk.Api.Ugc/Operation/AdminContent/AdminUploadContentDirect.cs) | [AdminUploadContentDirect](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/AdminUploadContentDirect.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/channels/{channelId}/contents/s3` | POST | AdminUploadContentS3 | [AdminUploadContentS3](../../apis/AccelByte.Sdk.Api.Ugc/Operation/AdminContent/AdminUploadContentS3.cs) | [AdminUploadContentS3](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/AdminUploadContentS3.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/channels/{channelId}/contents/s3/{contentId}` | PUT | SingleAdminUpdateContentS3 | [SingleAdminUpdateContentS3](../../apis/AccelByte.Sdk.Api.Ugc/Operation/AdminContent/SingleAdminUpdateContentS3.cs) | [SingleAdminUpdateContentS3](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/SingleAdminUpdateContentS3.cs) |
| [DEPRECATED] `/ugc/v1/admin/namespaces/{namespace}/channels/{channelId}/contents/{contentId}` | PUT | SingleAdminUpdateContentDirect | [SingleAdminUpdateContentDirect](../../apis/AccelByte.Sdk.Api.Ugc/Operation/AdminContent/SingleAdminUpdateContentDirect.cs) | [SingleAdminUpdateContentDirect](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/SingleAdminUpdateContentDirect.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/contents/bulk` | POST | AdminGetContentBulk | [AdminGetContentBulk](../../apis/AccelByte.Sdk.Api.Ugc/Operation/AdminContent/AdminGetContentBulk.cs) | [AdminGetContentBulk](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/AdminGetContentBulk.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/contents/sharecodes/{shareCode}` | GET | AdminGetUserContentByShareCode | [AdminGetUserContentByShareCode](../../apis/AccelByte.Sdk.Api.Ugc/Operation/AdminContent/AdminGetUserContentByShareCode.cs) | [AdminGetUserContentByShareCode](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/AdminGetUserContentByShareCode.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/contents/{contentId}` | GET | AdminGetSpecificContent | [AdminGetSpecificContent](../../apis/AccelByte.Sdk.Api.Ugc/Operation/AdminContent/AdminGetSpecificContent.cs) | [AdminGetSpecificContent](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/AdminGetSpecificContent.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/s3/{contentId}` | PUT | AdminUpdateContentS3 | [AdminUpdateContentS3](../../apis/AccelByte.Sdk.Api.Ugc/Operation/AdminContent/AdminUpdateContentS3.cs) | [AdminUpdateContentS3](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/AdminUpdateContentS3.cs) |
| [DEPRECATED] `/ugc/v1/admin/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/{contentId}` | PUT | AdminUpdateContentDirect | [AdminUpdateContentDirect](../../apis/AccelByte.Sdk.Api.Ugc/Operation/AdminContent/AdminUpdateContentDirect.cs) | [AdminUpdateContentDirect](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/AdminUpdateContentDirect.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/users/{userId}/contents/{contentId}/hide` | PUT | AdminHideUserContent | [AdminHideUserContent](../../apis/AccelByte.Sdk.Api.Ugc/Operation/AdminContent/AdminHideUserContent.cs) | [AdminHideUserContent](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/AdminHideUserContent.cs) |

### Admin Group Wrapper:  [AdminGroup](../../apis/AccelByte.Sdk.Api.Ugc/Wrapper/AdminGroup.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Admin Tag Wrapper:  [AdminTag](../../apis/AccelByte.Sdk.Api.Ugc/Wrapper/AdminTag.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Admin Type Wrapper:  [AdminType](../../apis/AccelByte.Sdk.Api.Ugc/Wrapper/AdminType.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Anonymization Wrapper:  [Anonymization](../../apis/AccelByte.Sdk.Api.Ugc/Wrapper/Anonymization.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Public Content Wrapper:  [PublicContent](../../apis/AccelByte.Sdk.Api.Ugc/Wrapper/PublicContent.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/ugc/v1/public/namespaces/{namespace}/contents/bulk` | POST | PublicGetContentBulk | [PublicGetContentBulk](../../apis/AccelByte.Sdk.Api.Ugc/Operation/PublicContent/PublicGetContentBulk.cs) | [PublicGetContentBulk](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContent/PublicGetContentBulk.cs) |
| `/ugc/v1/public/namespaces/{namespace}/contents/sharecodes/{shareCode}` | GET | PublicDownloadContentByShareCode | [PublicDownloadContentByShareCode](../../apis/AccelByte.Sdk.Api.Ugc/Operation/PublicContent/PublicDownloadContentByShareCode.cs) | [PublicDownloadContentByShareCode](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContent/PublicDownloadContentByShareCode.cs) |
| `/ugc/v1/public/namespaces/{namespace}/contents/{contentId}` | GET | PublicDownloadContentByContentID | [PublicDownloadContentByContentID](../../apis/AccelByte.Sdk.Api.Ugc/Operation/PublicContent/PublicDownloadContentByContentID.cs) | [PublicDownloadContentByContentID](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContent/PublicDownloadContentByContentID.cs) |
| [DEPRECATED] `/ugc/v1/public/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents` | POST | CreateContentDirect | [CreateContentDirect](../../apis/AccelByte.Sdk.Api.Ugc/Operation/PublicContent/CreateContentDirect.cs) | [CreateContentDirect](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContent/CreateContentDirect.cs) |
| `/ugc/v1/public/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/s3` | POST | CreateContentS3 | [CreateContentS3](../../apis/AccelByte.Sdk.Api.Ugc/Operation/PublicContent/CreateContentS3.cs) | [CreateContentS3](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContent/CreateContentS3.cs) |
| `/ugc/v1/public/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/s3/{contentId}` | PUT | UpdateContentS3 | [UpdateContentS3](../../apis/AccelByte.Sdk.Api.Ugc/Operation/PublicContent/UpdateContentS3.cs) | [UpdateContentS3](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContent/UpdateContentS3.cs) |
| [DEPRECATED] `/ugc/v1/public/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/{contentId}` | PUT | UpdateContentDirect | [UpdateContentDirect](../../apis/AccelByte.Sdk.Api.Ugc/Operation/PublicContent/UpdateContentDirect.cs) | [UpdateContentDirect](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContent/UpdateContentDirect.cs) |

### Public Follow Wrapper:  [PublicFollow](../../apis/AccelByte.Sdk.Api.Ugc/Wrapper/PublicFollow.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Public Like Wrapper:  [PublicLike](../../apis/AccelByte.Sdk.Api.Ugc/Wrapper/PublicLike.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Public Download Count Wrapper:  [PublicDownloadCount](../../apis/AccelByte.Sdk.Api.Ugc/Wrapper/PublicDownloadCount.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Public Tag Wrapper:  [PublicTag](../../apis/AccelByte.Sdk.Api.Ugc/Wrapper/PublicTag.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Public Type Wrapper:  [PublicType](../../apis/AccelByte.Sdk.Api.Ugc/Wrapper/PublicType.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Public Creator Wrapper:  [PublicCreator](../../apis/AccelByte.Sdk.Api.Ugc/Wrapper/PublicCreator.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Public Channel Wrapper:  [PublicChannel](../../apis/AccelByte.Sdk.Api.Ugc/Wrapper/PublicChannel.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Public Group Wrapper:  [PublicGroup](../../apis/AccelByte.Sdk.Api.Ugc/Wrapper/PublicGroup.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|


&nbsp;

## Models

| Model | Class |
|---|---|
| `models.AddDownloadCountResponse` | [ModelsAddDownloadCountResponse](../../apis/AccelByte.Sdk.Api.Ugc/Model/ModelsAddDownloadCountResponse.cs) |
| `models.AdminGetContentBulkRequest` | [ModelsAdminGetContentBulkRequest](../../apis/AccelByte.Sdk.Api.Ugc/Model/ModelsAdminGetContentBulkRequest.cs) |
| `models.AdminUpdateContentRequest` | [ModelsAdminUpdateContentRequest](../../apis/AccelByte.Sdk.Api.Ugc/Model/ModelsAdminUpdateContentRequest.cs) |
| `models.ChannelRequest` | [ModelsChannelRequest](../../apis/AccelByte.Sdk.Api.Ugc/Model/ModelsChannelRequest.cs) |
| `models.ChannelResponse` | [ModelsChannelResponse](../../apis/AccelByte.Sdk.Api.Ugc/Model/ModelsChannelResponse.cs) |
| `models.ContentDownloadResponse` | [ModelsContentDownloadResponse](../../apis/AccelByte.Sdk.Api.Ugc/Model/ModelsContentDownloadResponse.cs) |
| `models.ContentLikeRequest` | [ModelsContentLikeRequest](../../apis/AccelByte.Sdk.Api.Ugc/Model/ModelsContentLikeRequest.cs) |
| `models.ContentLikeResponse` | [ModelsContentLikeResponse](../../apis/AccelByte.Sdk.Api.Ugc/Model/ModelsContentLikeResponse.cs) |
| `models.CreateContentRequest` | [ModelsCreateContentRequest](../../apis/AccelByte.Sdk.Api.Ugc/Model/ModelsCreateContentRequest.cs) |
| `models.CreateContentRequestS3` | [ModelsCreateContentRequestS3](../../apis/AccelByte.Sdk.Api.Ugc/Model/ModelsCreateContentRequestS3.cs) |
| `models.CreateContentResponse` | [ModelsCreateContentResponse](../../apis/AccelByte.Sdk.Api.Ugc/Model/ModelsCreateContentResponse.cs) |
| `models.CreateGroupRequest` | [ModelsCreateGroupRequest](../../apis/AccelByte.Sdk.Api.Ugc/Model/ModelsCreateGroupRequest.cs) |
| `models.CreateGroupResponse` | [ModelsCreateGroupResponse](../../apis/AccelByte.Sdk.Api.Ugc/Model/ModelsCreateGroupResponse.cs) |
| `models.CreateScreenshotRequest` | [ModelsCreateScreenshotRequest](../../apis/AccelByte.Sdk.Api.Ugc/Model/ModelsCreateScreenshotRequest.cs) |
| `models.CreateScreenshotResponse` | [ModelsCreateScreenshotResponse](../../apis/AccelByte.Sdk.Api.Ugc/Model/ModelsCreateScreenshotResponse.cs) |
| `models.CreateTagRequest` | [ModelsCreateTagRequest](../../apis/AccelByte.Sdk.Api.Ugc/Model/ModelsCreateTagRequest.cs) |
| `models.CreateTagResponse` | [ModelsCreateTagResponse](../../apis/AccelByte.Sdk.Api.Ugc/Model/ModelsCreateTagResponse.cs) |
| `models.CreateTypeRequest` | [ModelsCreateTypeRequest](../../apis/AccelByte.Sdk.Api.Ugc/Model/ModelsCreateTypeRequest.cs) |
| `models.CreateTypeResponse` | [ModelsCreateTypeResponse](../../apis/AccelByte.Sdk.Api.Ugc/Model/ModelsCreateTypeResponse.cs) |
| `models.CreatorFollowState` | [ModelsCreatorFollowState](../../apis/AccelByte.Sdk.Api.Ugc/Model/ModelsCreatorFollowState.cs) |
| `models.CreatorOverviewResponse` | [ModelsCreatorOverviewResponse](../../apis/AccelByte.Sdk.Api.Ugc/Model/ModelsCreatorOverviewResponse.cs) |
| `models.CreatorResponse` | [ModelsCreatorResponse](../../apis/AccelByte.Sdk.Api.Ugc/Model/ModelsCreatorResponse.cs) |
| `models.GetContentPreviewResponse` | [ModelsGetContentPreviewResponse](../../apis/AccelByte.Sdk.Api.Ugc/Model/ModelsGetContentPreviewResponse.cs) |
| `models.HideContentRequest` | [ModelsHideContentRequest](../../apis/AccelByte.Sdk.Api.Ugc/Model/ModelsHideContentRequest.cs) |
| `models.LikeState` | [ModelsLikeState](../../apis/AccelByte.Sdk.Api.Ugc/Model/ModelsLikeState.cs) |
| `models.PaginatedContentDownloadResponse` | [ModelsPaginatedContentDownloadResponse](../../apis/AccelByte.Sdk.Api.Ugc/Model/ModelsPaginatedContentDownloadResponse.cs) |
| `models.PaginatedCreatorOverviewResponse` | [ModelsPaginatedCreatorOverviewResponse](../../apis/AccelByte.Sdk.Api.Ugc/Model/ModelsPaginatedCreatorOverviewResponse.cs) |
| `models.PaginatedGetChannelResponse` | [ModelsPaginatedGetChannelResponse](../../apis/AccelByte.Sdk.Api.Ugc/Model/ModelsPaginatedGetChannelResponse.cs) |
| `models.PaginatedGetTagResponse` | [ModelsPaginatedGetTagResponse](../../apis/AccelByte.Sdk.Api.Ugc/Model/ModelsPaginatedGetTagResponse.cs) |
| `models.PaginatedGetTypeResponse` | [ModelsPaginatedGetTypeResponse](../../apis/AccelByte.Sdk.Api.Ugc/Model/ModelsPaginatedGetTypeResponse.cs) |
| `models.PaginatedGroupResponse` | [ModelsPaginatedGroupResponse](../../apis/AccelByte.Sdk.Api.Ugc/Model/ModelsPaginatedGroupResponse.cs) |
| `models.PagingCursor` | [ModelsPagingCursor](../../apis/AccelByte.Sdk.Api.Ugc/Model/ModelsPagingCursor.cs) |
| `models.PayloadURL` | [ModelsPayloadURL](../../apis/AccelByte.Sdk.Api.Ugc/Model/ModelsPayloadURL.cs) |
| `models.PreviewURL` | [ModelsPreviewURL](../../apis/AccelByte.Sdk.Api.Ugc/Model/ModelsPreviewURL.cs) |
| `models.PublicChannelRequest` | [ModelsPublicChannelRequest](../../apis/AccelByte.Sdk.Api.Ugc/Model/ModelsPublicChannelRequest.cs) |
| `models.PublicCreateContentRequestS3` | [ModelsPublicCreateContentRequestS3](../../apis/AccelByte.Sdk.Api.Ugc/Model/ModelsPublicCreateContentRequestS3.cs) |
| `models.PublicGetContentBulkRequest` | [ModelsPublicGetContentBulkRequest](../../apis/AccelByte.Sdk.Api.Ugc/Model/ModelsPublicGetContentBulkRequest.cs) |
| `models.ScreenshotResponse` | [ModelsScreenshotResponse](../../apis/AccelByte.Sdk.Api.Ugc/Model/ModelsScreenshotResponse.cs) |
| `models.UpdateChannelRequest` | [ModelsUpdateChannelRequest](../../apis/AccelByte.Sdk.Api.Ugc/Model/ModelsUpdateChannelRequest.cs) |
| `models.UpdateContentRequest` | [ModelsUpdateContentRequest](../../apis/AccelByte.Sdk.Api.Ugc/Model/ModelsUpdateContentRequest.cs) |
| `models.UpdateScreenshotRequest` | [ModelsUpdateScreenshotRequest](../../apis/AccelByte.Sdk.Api.Ugc/Model/ModelsUpdateScreenshotRequest.cs) |
| `models.UpdateScreenshotResponse` | [ModelsUpdateScreenshotResponse](../../apis/AccelByte.Sdk.Api.Ugc/Model/ModelsUpdateScreenshotResponse.cs) |
| `models.UserFollowRequest` | [ModelsUserFollowRequest](../../apis/AccelByte.Sdk.Api.Ugc/Model/ModelsUserFollowRequest.cs) |
| `models.UserFollowResponse` | [ModelsUserFollowResponse](../../apis/AccelByte.Sdk.Api.Ugc/Model/ModelsUserFollowResponse.cs) |
| `models.createScreenshotRequestItem` | [ModelsCreateScreenshotRequestItem](../../apis/AccelByte.Sdk.Api.Ugc/Model/ModelsCreateScreenshotRequestItem.cs) |
| `models.previewMetadata` | [ModelsPreviewMetadata](../../apis/AccelByte.Sdk.Api.Ugc/Model/ModelsPreviewMetadata.cs) |
| `models.updateScreenshot` | [ModelsUpdateScreenshot](../../apis/AccelByte.Sdk.Api.Ugc/Model/ModelsUpdateScreenshot.cs) |
| `response.Error` | [ResponseError](../../apis/AccelByte.Sdk.Api.Ugc/Model/ResponseError.cs) |
