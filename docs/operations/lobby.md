# Lobby Service Index

&nbsp;

## Operations

### friends Wrapper:  [Friends](../../apis/AccelByte.Sdk.Api.Lobby/Wrapper/Friends.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/friends/namespaces/{namespace}/me` | GET | GetUserFriendsUpdated | [GetUserFriendsUpdated](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Friends/GetUserFriendsUpdated.cs) | [GetUserFriendsUpdated](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Friends/GetUserFriendsUpdated.cs) |
| `/friends/namespaces/{namespace}/me/incoming` | GET | GetUserIncomingFriends | [GetUserIncomingFriends](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Friends/GetUserIncomingFriends.cs) | [GetUserIncomingFriends](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Friends/GetUserIncomingFriends.cs) |
| `/friends/namespaces/{namespace}/me/incoming-time` | GET | GetUserIncomingFriendsWithTime | [GetUserIncomingFriendsWithTime](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Friends/GetUserIncomingFriendsWithTime.cs) | [GetUserIncomingFriendsWithTime](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Friends/GetUserIncomingFriendsWithTime.cs) |
| `/friends/namespaces/{namespace}/me/outgoing` | GET | GetUserOutgoingFriends | [GetUserOutgoingFriends](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Friends/GetUserOutgoingFriends.cs) | [GetUserOutgoingFriends](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Friends/GetUserOutgoingFriends.cs) |
| `/friends/namespaces/{namespace}/me/outgoing-time` | GET | GetUserOutgoingFriendsWithTime | [GetUserOutgoingFriendsWithTime](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Friends/GetUserOutgoingFriendsWithTime.cs) | [GetUserOutgoingFriendsWithTime](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Friends/GetUserOutgoingFriendsWithTime.cs) |
| `/friends/namespaces/{namespace}/me/platforms` | GET | GetUserFriendsWithPlatform | [GetUserFriendsWithPlatform](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Friends/GetUserFriendsWithPlatform.cs) | [GetUserFriendsWithPlatform](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Friends/GetUserFriendsWithPlatform.cs) |
| `/friends/namespaces/{namespace}/me/request` | POST | UserRequestFriend | [UserRequestFriend](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Friends/UserRequestFriend.cs) | [UserRequestFriend](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Friends/UserRequestFriend.cs) |
| `/friends/namespaces/{namespace}/me/request/accept` | POST | UserAcceptFriendRequest | [UserAcceptFriendRequest](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Friends/UserAcceptFriendRequest.cs) | [UserAcceptFriendRequest](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Friends/UserAcceptFriendRequest.cs) |
| `/friends/namespaces/{namespace}/me/request/cancel` | POST | UserCancelFriendRequest | [UserCancelFriendRequest](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Friends/UserCancelFriendRequest.cs) | [UserCancelFriendRequest](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Friends/UserCancelFriendRequest.cs) |
| `/friends/namespaces/{namespace}/me/request/reject` | POST | UserRejectFriendRequest | [UserRejectFriendRequest](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Friends/UserRejectFriendRequest.cs) | [UserRejectFriendRequest](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Friends/UserRejectFriendRequest.cs) |
| `/friends/namespaces/{namespace}/me/status/{friendId}` | GET | UserGetFriendshipStatus | [UserGetFriendshipStatus](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Friends/UserGetFriendshipStatus.cs) | [UserGetFriendshipStatus](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Friends/UserGetFriendshipStatus.cs) |
| `/friends/namespaces/{namespace}/me/unfriend` | POST | UserUnfriendRequest | [UserUnfriendRequest](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Friends/UserUnfriendRequest.cs) | [UserUnfriendRequest](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Friends/UserUnfriendRequest.cs) |
| `/friends/namespaces/{namespace}/users/{userId}/add/bulk` | POST | AddFriendsWithoutConfirmation | [AddFriendsWithoutConfirmation](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Friends/AddFriendsWithoutConfirmation.cs) | [AddFriendsWithoutConfirmation](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Friends/AddFriendsWithoutConfirmation.cs) |
| `/friends/namespaces/{namespace}/users/{userId}/delete/bulk` | POST | BulkDeleteFriends | [BulkDeleteFriends](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Friends/BulkDeleteFriends.cs) | [BulkDeleteFriends](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Friends/BulkDeleteFriends.cs) |
| `/lobby/v1/admin/friend/namespaces/{namespace}/users/{userId}` | GET | GetListOfFriends | [GetListOfFriends](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Friends/GetListOfFriends.cs) | [GetListOfFriends](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Friends/GetListOfFriends.cs) |
| `/lobby/v1/admin/friend/namespaces/{namespace}/users/{userId}/incoming` | GET | GetIncomingFriendRequests | [GetIncomingFriendRequests](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Friends/GetIncomingFriendRequests.cs) | [GetIncomingFriendRequests](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Friends/GetIncomingFriendRequests.cs) |
| `/lobby/v1/admin/friend/namespaces/{namespace}/users/{userId}/outgoing` | GET | GetOutgoingFriendRequests | [GetOutgoingFriendRequests](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Friends/GetOutgoingFriendRequests.cs) | [GetOutgoingFriendRequests](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Friends/GetOutgoingFriendRequests.cs) |

### config Wrapper:  [Config](../../apis/AccelByte.Sdk.Api.Lobby/Wrapper/Config.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/lobby/v1/admin/config` | GET | AdminGetAllConfigV1 | [AdminGetAllConfigV1](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Config/AdminGetAllConfigV1.cs) | [AdminGetAllConfigV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Config/AdminGetAllConfigV1.cs) |
| `/lobby/v1/admin/config/namespaces/{namespace}` | GET | AdminGetConfigV1 | [AdminGetConfigV1](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Config/AdminGetConfigV1.cs) | [AdminGetConfigV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Config/AdminGetConfigV1.cs) |
| `/lobby/v1/admin/config/namespaces/{namespace}` | PUT | AdminUpdateConfigV1 | [AdminUpdateConfigV1](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Config/AdminUpdateConfigV1.cs) | [AdminUpdateConfigV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Config/AdminUpdateConfigV1.cs) |
| `/lobby/v1/admin/config/namespaces/{namespace}/export` | GET | AdminExportConfigV1 | [AdminExportConfigV1](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Config/AdminExportConfigV1.cs) | [AdminExportConfigV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Config/AdminExportConfigV1.cs) |
| `/lobby/v1/admin/config/namespaces/{namespace}/import` | POST | AdminImportConfigV1 | [AdminImportConfigV1](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Config/AdminImportConfigV1.cs) | [AdminImportConfigV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Config/AdminImportConfigV1.cs) |

### notification Wrapper:  [Notification](../../apis/AccelByte.Sdk.Api.Lobby/Wrapper/Notification.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/lobby/v1/admin/notification/namespaces/{namespace}/bulkUsers/freeform/notify` | POST | SendMultipleUsersFreeformNotificationV1Admin | [SendMultipleUsersFreeformNotificationV1Admin](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Notification/SendMultipleUsersFreeformNotificationV1Admin.cs) | [SendMultipleUsersFreeformNotificationV1Admin](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Notification/SendMultipleUsersFreeformNotificationV1Admin.cs) |
| `/lobby/v1/admin/notification/namespaces/{namespace}/freeform/notify` | POST | SendUsersFreeformNotificationV1Admin | [SendUsersFreeformNotificationV1Admin](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Notification/SendUsersFreeformNotificationV1Admin.cs) | [SendUsersFreeformNotificationV1Admin](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Notification/SendUsersFreeformNotificationV1Admin.cs) |
| `/lobby/v1/admin/notification/namespaces/{namespace}/parties/{partyId}/freeform/notify` | POST | SendPartyFreeformNotificationV1Admin | [SendPartyFreeformNotificationV1Admin](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Notification/SendPartyFreeformNotificationV1Admin.cs) | [SendPartyFreeformNotificationV1Admin](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Notification/SendPartyFreeformNotificationV1Admin.cs) |
| `/lobby/v1/admin/notification/namespaces/{namespace}/parties/{partyId}/templates/notify` | POST | SendPartyTemplatedNotificationV1Admin | [SendPartyTemplatedNotificationV1Admin](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Notification/SendPartyTemplatedNotificationV1Admin.cs) | [SendPartyTemplatedNotificationV1Admin](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Notification/SendPartyTemplatedNotificationV1Admin.cs) |
| `/lobby/v1/admin/notification/namespaces/{namespace}/templates` | GET | GetAllNotificationTemplatesV1Admin | [GetAllNotificationTemplatesV1Admin](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Notification/GetAllNotificationTemplatesV1Admin.cs) | [GetAllNotificationTemplatesV1Admin](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Notification/GetAllNotificationTemplatesV1Admin.cs) |
| `/lobby/v1/admin/notification/namespaces/{namespace}/templates` | POST | CreateNotificationTemplateV1Admin | [CreateNotificationTemplateV1Admin](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Notification/CreateNotificationTemplateV1Admin.cs) | [CreateNotificationTemplateV1Admin](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Notification/CreateNotificationTemplateV1Admin.cs) |
| `/lobby/v1/admin/notification/namespaces/{namespace}/templates/notify` | POST | SendUsersTemplatedNotificationV1Admin | [SendUsersTemplatedNotificationV1Admin](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Notification/SendUsersTemplatedNotificationV1Admin.cs) | [SendUsersTemplatedNotificationV1Admin](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Notification/SendUsersTemplatedNotificationV1Admin.cs) |
| `/lobby/v1/admin/notification/namespaces/{namespace}/templates/{templateSlug}` | GET | GetTemplateSlugLocalizationsTemplateV1Admin | [GetTemplateSlugLocalizationsTemplateV1Admin](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Notification/GetTemplateSlugLocalizationsTemplateV1Admin.cs) | [GetTemplateSlugLocalizationsTemplateV1Admin](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Notification/GetTemplateSlugLocalizationsTemplateV1Admin.cs) |
| `/lobby/v1/admin/notification/namespaces/{namespace}/templates/{templateSlug}` | DELETE | DeleteNotificationTemplateSlugV1Admin | [DeleteNotificationTemplateSlugV1Admin](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Notification/DeleteNotificationTemplateSlugV1Admin.cs) | [DeleteNotificationTemplateSlugV1Admin](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Notification/DeleteNotificationTemplateSlugV1Admin.cs) |
| `/lobby/v1/admin/notification/namespaces/{namespace}/templates/{templateSlug}/languages/{templateLanguage}` | GET | GetSingleTemplateLocalizationV1Admin | [GetSingleTemplateLocalizationV1Admin](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Notification/GetSingleTemplateLocalizationV1Admin.cs) | [GetSingleTemplateLocalizationV1Admin](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Notification/GetSingleTemplateLocalizationV1Admin.cs) |
| `/lobby/v1/admin/notification/namespaces/{namespace}/templates/{templateSlug}/languages/{templateLanguage}` | PUT | UpdateTemplateLocalizationV1Admin | [UpdateTemplateLocalizationV1Admin](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Notification/UpdateTemplateLocalizationV1Admin.cs) | [UpdateTemplateLocalizationV1Admin](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Notification/UpdateTemplateLocalizationV1Admin.cs) |
| `/lobby/v1/admin/notification/namespaces/{namespace}/templates/{templateSlug}/languages/{templateLanguage}` | DELETE | DeleteTemplateLocalizationV1Admin | [DeleteTemplateLocalizationV1Admin](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Notification/DeleteTemplateLocalizationV1Admin.cs) | [DeleteTemplateLocalizationV1Admin](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Notification/DeleteTemplateLocalizationV1Admin.cs) |
| `/lobby/v1/admin/notification/namespaces/{namespace}/templates/{templateSlug}/languages/{templateLanguage}/publish` | POST | PublishTemplateLocalizationV1Admin | [PublishTemplateLocalizationV1Admin](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Notification/PublishTemplateLocalizationV1Admin.cs) | [PublishTemplateLocalizationV1Admin](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Notification/PublishTemplateLocalizationV1Admin.cs) |
| `/lobby/v1/admin/notification/namespaces/{namespace}/topics` | GET | GetAllNotificationTopicsV1Admin | [GetAllNotificationTopicsV1Admin](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Notification/GetAllNotificationTopicsV1Admin.cs) | [GetAllNotificationTopicsV1Admin](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Notification/GetAllNotificationTopicsV1Admin.cs) |
| `/lobby/v1/admin/notification/namespaces/{namespace}/topics` | POST | CreateNotificationTopicV1Admin | [CreateNotificationTopicV1Admin](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Notification/CreateNotificationTopicV1Admin.cs) | [CreateNotificationTopicV1Admin](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Notification/CreateNotificationTopicV1Admin.cs) |
| `/lobby/v1/admin/notification/namespaces/{namespace}/topics/{topicName}` | GET | GetNotificationTopicV1Admin | [GetNotificationTopicV1Admin](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Notification/GetNotificationTopicV1Admin.cs) | [GetNotificationTopicV1Admin](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Notification/GetNotificationTopicV1Admin.cs) |
| `/lobby/v1/admin/notification/namespaces/{namespace}/topics/{topicName}` | PUT | UpdateNotificationTopicV1Admin | [UpdateNotificationTopicV1Admin](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Notification/UpdateNotificationTopicV1Admin.cs) | [UpdateNotificationTopicV1Admin](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Notification/UpdateNotificationTopicV1Admin.cs) |
| `/lobby/v1/admin/notification/namespaces/{namespace}/topics/{topicName}` | DELETE | DeleteNotificationTopicV1Admin | [DeleteNotificationTopicV1Admin](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Notification/DeleteNotificationTopicV1Admin.cs) | [DeleteNotificationTopicV1Admin](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Notification/DeleteNotificationTopicV1Admin.cs) |
| `/lobby/v1/admin/notification/namespaces/{namespace}/users/{userId}/freeform/notify` | POST | SendSpecificUserFreeformNotificationV1Admin | [SendSpecificUserFreeformNotificationV1Admin](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Notification/SendSpecificUserFreeformNotificationV1Admin.cs) | [SendSpecificUserFreeformNotificationV1Admin](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Notification/SendSpecificUserFreeformNotificationV1Admin.cs) |
| `/lobby/v1/admin/notification/namespaces/{namespace}/users/{userId}/templates/notify` | POST | SendSpecificUserTemplatedNotificationV1Admin | [SendSpecificUserTemplatedNotificationV1Admin](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Notification/SendSpecificUserTemplatedNotificationV1Admin.cs) | [SendSpecificUserTemplatedNotificationV1Admin](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Notification/SendSpecificUserTemplatedNotificationV1Admin.cs) |
| `/notification/namespaces/{namespace}/topics` | GET | GetTopicByNamespace | [GetTopicByNamespace](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Notification/GetTopicByNamespace.cs) | [GetTopicByNamespace](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Notification/GetTopicByNamespace.cs) |
| `/notification/namespaces/{namespace}/topics` | POST | CreateTopic | [CreateTopic](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Notification/CreateTopic.cs) | [CreateTopic](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Notification/CreateTopic.cs) |
| `/notification/namespaces/{namespace}/topics/{topic}` | GET | GetTopicByTopicName | [GetTopicByTopicName](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Notification/GetTopicByTopicName.cs) | [GetTopicByTopicName](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Notification/GetTopicByTopicName.cs) |
| `/notification/namespaces/{namespace}/topics/{topic}` | PUT | UpdateTopicByTopicName | [UpdateTopicByTopicName](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Notification/UpdateTopicByTopicName.cs) | [UpdateTopicByTopicName](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Notification/UpdateTopicByTopicName.cs) |
| `/notification/namespaces/{namespace}/topics/{topic}` | DELETE | DeleteTopicByTopicName | [DeleteTopicByTopicName](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Notification/DeleteTopicByTopicName.cs) | [DeleteTopicByTopicName](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Notification/DeleteTopicByTopicName.cs) |
| `/notification/namespaces/{namespace}/users/{userId}/freeform` | POST | FreeFormNotificationByUserID | [FreeFormNotificationByUserID](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Notification/FreeFormNotificationByUserID.cs) | [FreeFormNotificationByUserID](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Notification/FreeFormNotificationByUserID.cs) |
| `/notification/namespaces/{namespace}/users/{userId}/templated` | POST | NotificationWithTemplateByUserID | [NotificationWithTemplateByUserID](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Notification/NotificationWithTemplateByUserID.cs) | [NotificationWithTemplateByUserID](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Notification/NotificationWithTemplateByUserID.cs) |

### party Wrapper:  [Party](../../apis/AccelByte.Sdk.Api.Lobby/Wrapper/Party.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/lobby/v1/admin/party/namespaces/{namespace}/parties/{partyId}` | GET | AdminGetPartyDataV1 | [AdminGetPartyDataV1](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Party/AdminGetPartyDataV1.cs) | [AdminGetPartyDataV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Party/AdminGetPartyDataV1.cs) |
| `/lobby/v1/admin/party/namespaces/{namespace}/users/{userId}/party` | GET | AdminGetUserPartyV1 | [AdminGetUserPartyV1](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Party/AdminGetUserPartyV1.cs) | [AdminGetUserPartyV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Party/AdminGetUserPartyV1.cs) |
| `/lobby/v1/public/party/namespaces/{namespace}/parties/{partyId}` | GET | PublicGetPartyDataV1 | [PublicGetPartyDataV1](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Party/PublicGetPartyDataV1.cs) | [PublicGetPartyDataV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Party/PublicGetPartyDataV1.cs) |
| `/lobby/v1/public/party/namespaces/{namespace}/parties/{partyId}/attributes` | PUT | PublicUpdatePartyAttributesV1 | [PublicUpdatePartyAttributesV1](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Party/PublicUpdatePartyAttributesV1.cs) | [PublicUpdatePartyAttributesV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Party/PublicUpdatePartyAttributesV1.cs) |
| `/lobby/v1/public/party/namespaces/{namespace}/parties/{partyId}/limit` | PUT | PublicSetPartyLimitV1 | [PublicSetPartyLimitV1](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Party/PublicSetPartyLimitV1.cs) | [PublicSetPartyLimitV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Party/PublicSetPartyLimitV1.cs) |

### Lobby Operations Wrapper:  [LobbyOperations](../../apis/AccelByte.Sdk.Api.Lobby/Wrapper/LobbyOperations.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/lobby/v1/admin/party/namespaces/{namespace}/parties/{partyId}/attributes` | PUT | AdminUpdatePartyAttributesV1 | [AdminUpdatePartyAttributesV1](../../apis/AccelByte.Sdk.Api.Lobby/Operation/LobbyOperations/AdminUpdatePartyAttributesV1.cs) | [AdminUpdatePartyAttributesV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/LobbyOperations/AdminUpdatePartyAttributesV1.cs) |
| `/lobby/v1/admin/party/namespaces/{namespace}/parties/{partyId}/join/{userId}` | POST | AdminJoinPartyV1 | [AdminJoinPartyV1](../../apis/AccelByte.Sdk.Api.Lobby/Operation/LobbyOperations/AdminJoinPartyV1.cs) | [AdminJoinPartyV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/LobbyOperations/AdminJoinPartyV1.cs) |
| `/lobby/v1/messages` | GET | PublicGetMessages | [PublicGetMessages](../../apis/AccelByte.Sdk.Api.Lobby/Operation/LobbyOperations/PublicGetMessages.cs) | [PublicGetMessages](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/LobbyOperations/PublicGetMessages.cs) |

### player Wrapper:  [Player](../../apis/AccelByte.Sdk.Api.Lobby/Wrapper/Player.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/lobby/v1/admin/player/namespaces/{namespace}/ccu` | GET | AdminGetLobbyCCU | [AdminGetLobbyCCU](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Player/AdminGetLobbyCCU.cs) | [AdminGetLobbyCCU](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Player/AdminGetLobbyCCU.cs) |
| `/lobby/v1/admin/player/namespaces/{namespace}/users/bulk/blocked` | POST | AdminGetBulkPlayerBlockedPlayersV1 | [AdminGetBulkPlayerBlockedPlayersV1](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Player/AdminGetBulkPlayerBlockedPlayersV1.cs) | [AdminGetBulkPlayerBlockedPlayersV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Player/AdminGetBulkPlayerBlockedPlayersV1.cs) |
| `/lobby/v1/admin/player/namespaces/{namespace}/users/{userId}/attributes` | GET | AdminGetAllPlayerSessionAttribute | [AdminGetAllPlayerSessionAttribute](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Player/AdminGetAllPlayerSessionAttribute.cs) | [AdminGetAllPlayerSessionAttribute](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Player/AdminGetAllPlayerSessionAttribute.cs) |
| `/lobby/v1/admin/player/namespaces/{namespace}/users/{userId}/attributes` | PUT | AdminSetPlayerSessionAttribute | [AdminSetPlayerSessionAttribute](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Player/AdminSetPlayerSessionAttribute.cs) | [AdminSetPlayerSessionAttribute](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Player/AdminSetPlayerSessionAttribute.cs) |
| `/lobby/v1/admin/player/namespaces/{namespace}/users/{userId}/attributes/{attribute}` | GET | AdminGetPlayerSessionAttribute | [AdminGetPlayerSessionAttribute](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Player/AdminGetPlayerSessionAttribute.cs) | [AdminGetPlayerSessionAttribute](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Player/AdminGetPlayerSessionAttribute.cs) |
| `/lobby/v1/admin/player/namespaces/{namespace}/users/{userId}/blocked` | GET | AdminGetPlayerBlockedPlayersV1 | [AdminGetPlayerBlockedPlayersV1](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Player/AdminGetPlayerBlockedPlayersV1.cs) | [AdminGetPlayerBlockedPlayersV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Player/AdminGetPlayerBlockedPlayersV1.cs) |
| `/lobby/v1/admin/player/namespaces/{namespace}/users/{userId}/blocked-by` | GET | AdminGetPlayerBlockedByPlayersV1 | [AdminGetPlayerBlockedByPlayersV1](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Player/AdminGetPlayerBlockedByPlayersV1.cs) | [AdminGetPlayerBlockedByPlayersV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Player/AdminGetPlayerBlockedByPlayersV1.cs) |
| `/lobby/v1/admin/player/namespaces/{namespace}/users/{userId}/bulk/block` | POST | AdminBulkBlockPlayersV1 | [AdminBulkBlockPlayersV1](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Player/AdminBulkBlockPlayersV1.cs) | [AdminBulkBlockPlayersV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Player/AdminBulkBlockPlayersV1.cs) |
| `/lobby/v1/public/player/namespaces/{namespace}/users/me/blocked` | GET | PublicGetPlayerBlockedPlayersV1 | [PublicGetPlayerBlockedPlayersV1](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Player/PublicGetPlayerBlockedPlayersV1.cs) | [PublicGetPlayerBlockedPlayersV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Player/PublicGetPlayerBlockedPlayersV1.cs) |
| `/lobby/v1/public/player/namespaces/{namespace}/users/me/blocked-by` | GET | PublicGetPlayerBlockedByPlayersV1 | [PublicGetPlayerBlockedByPlayersV1](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Player/PublicGetPlayerBlockedByPlayersV1.cs) | [PublicGetPlayerBlockedByPlayersV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Player/PublicGetPlayerBlockedByPlayersV1.cs) |

### profanity Wrapper:  [Profanity](../../apis/AccelByte.Sdk.Api.Lobby/Wrapper/Profanity.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/lobby/v1/admin/profanity/namespaces/{namespace}/filters/debug` | POST | AdminDebugProfanityFilters | [AdminDebugProfanityFilters](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Profanity/AdminDebugProfanityFilters.cs) | [AdminDebugProfanityFilters](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Profanity/AdminDebugProfanityFilters.cs) |
| `/lobby/v1/admin/profanity/namespaces/{namespace}/list/{list}/filters` | GET | AdminGetProfanityListFiltersV1 | [AdminGetProfanityListFiltersV1](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Profanity/AdminGetProfanityListFiltersV1.cs) | [AdminGetProfanityListFiltersV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Profanity/AdminGetProfanityListFiltersV1.cs) |
| `/lobby/v1/admin/profanity/namespaces/{namespace}/list/{list}/filters` | POST | AdminAddProfanityFilterIntoList | [AdminAddProfanityFilterIntoList](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Profanity/AdminAddProfanityFilterIntoList.cs) | [AdminAddProfanityFilterIntoList](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Profanity/AdminAddProfanityFilterIntoList.cs) |
| `/lobby/v1/admin/profanity/namespaces/{namespace}/list/{list}/filters/bulk` | POST | AdminAddProfanityFilters | [AdminAddProfanityFilters](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Profanity/AdminAddProfanityFilters.cs) | [AdminAddProfanityFilters](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Profanity/AdminAddProfanityFilters.cs) |
| `/lobby/v1/admin/profanity/namespaces/{namespace}/list/{list}/filters/bulk-file` | POST | AdminImportProfanityFiltersFromFile | [AdminImportProfanityFiltersFromFile](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Profanity/AdminImportProfanityFiltersFromFile.cs) | [AdminImportProfanityFiltersFromFile](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Profanity/AdminImportProfanityFiltersFromFile.cs) |
| `/lobby/v1/admin/profanity/namespaces/{namespace}/list/{list}/filters/delete` | POST | AdminDeleteProfanityFilter | [AdminDeleteProfanityFilter](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Profanity/AdminDeleteProfanityFilter.cs) | [AdminDeleteProfanityFilter](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Profanity/AdminDeleteProfanityFilter.cs) |
| `/lobby/v1/admin/profanity/namespaces/{namespace}/lists` | GET | AdminGetProfanityLists | [AdminGetProfanityLists](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Profanity/AdminGetProfanityLists.cs) | [AdminGetProfanityLists](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Profanity/AdminGetProfanityLists.cs) |
| `/lobby/v1/admin/profanity/namespaces/{namespace}/lists` | POST | AdminCreateProfanityList | [AdminCreateProfanityList](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Profanity/AdminCreateProfanityList.cs) | [AdminCreateProfanityList](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Profanity/AdminCreateProfanityList.cs) |
| `/lobby/v1/admin/profanity/namespaces/{namespace}/lists/{list}` | POST | AdminUpdateProfanityList | [AdminUpdateProfanityList](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Profanity/AdminUpdateProfanityList.cs) | [AdminUpdateProfanityList](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Profanity/AdminUpdateProfanityList.cs) |
| `/lobby/v1/admin/profanity/namespaces/{namespace}/lists/{list}` | DELETE | AdminDeleteProfanityList | [AdminDeleteProfanityList](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Profanity/AdminDeleteProfanityList.cs) | [AdminDeleteProfanityList](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Profanity/AdminDeleteProfanityList.cs) |
| `/lobby/v1/admin/profanity/namespaces/{namespace}/rule` | GET | AdminGetProfanityRule | [AdminGetProfanityRule](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Profanity/AdminGetProfanityRule.cs) | [AdminGetProfanityRule](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Profanity/AdminGetProfanityRule.cs) |
| `/lobby/v1/admin/profanity/namespaces/{namespace}/rule` | POST | AdminSetProfanityRuleForNamespace | [AdminSetProfanityRuleForNamespace](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Profanity/AdminSetProfanityRuleForNamespace.cs) | [AdminSetProfanityRuleForNamespace](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Profanity/AdminSetProfanityRuleForNamespace.cs) |
| `/lobby/v1/admin/profanity/namespaces/{namespace}/verify` | POST | AdminVerifyMessageProfanityResponse | [AdminVerifyMessageProfanityResponse](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Profanity/AdminVerifyMessageProfanityResponse.cs) | [AdminVerifyMessageProfanityResponse](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Profanity/AdminVerifyMessageProfanityResponse.cs) |

### thirdParty Wrapper:  [ThirdParty](../../apis/AccelByte.Sdk.Api.Lobby/Wrapper/ThirdParty.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/lobby/v1/admin/thirdparty/namespaces/{namespace}/config/steam` | GET | AdminGetThirdPartyConfig | [AdminGetThirdPartyConfig](../../apis/AccelByte.Sdk.Api.Lobby/Operation/ThirdParty/AdminGetThirdPartyConfig.cs) | [AdminGetThirdPartyConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/ThirdParty/AdminGetThirdPartyConfig.cs) |
| `/lobby/v1/admin/thirdparty/namespaces/{namespace}/config/steam` | PUT | AdminUpdateThirdPartyConfig | [AdminUpdateThirdPartyConfig](../../apis/AccelByte.Sdk.Api.Lobby/Operation/ThirdParty/AdminUpdateThirdPartyConfig.cs) | [AdminUpdateThirdPartyConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/ThirdParty/AdminUpdateThirdPartyConfig.cs) |
| `/lobby/v1/admin/thirdparty/namespaces/{namespace}/config/steam` | POST | AdminCreateThirdPartyConfig | [AdminCreateThirdPartyConfig](../../apis/AccelByte.Sdk.Api.Lobby/Operation/ThirdParty/AdminCreateThirdPartyConfig.cs) | [AdminCreateThirdPartyConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/ThirdParty/AdminCreateThirdPartyConfig.cs) |
| `/lobby/v1/admin/thirdparty/namespaces/{namespace}/config/steam` | DELETE | AdminDeleteThirdPartyConfig | [AdminDeleteThirdPartyConfig](../../apis/AccelByte.Sdk.Api.Lobby/Operation/ThirdParty/AdminDeleteThirdPartyConfig.cs) | [AdminDeleteThirdPartyConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/ThirdParty/AdminDeleteThirdPartyConfig.cs) |

### presence Wrapper:  [Presence](../../apis/AccelByte.Sdk.Api.Lobby/Wrapper/Presence.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/lobby/v1/public/presence/namespaces/{namespace}/users/presence` | GET | UsersPresenceHandlerV1 | [UsersPresenceHandlerV1](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Presence/UsersPresenceHandlerV1.cs) | [UsersPresenceHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Presence/UsersPresenceHandlerV1.cs) |

### admin Wrapper:  [Admin](../../apis/AccelByte.Sdk.Api.Lobby/Wrapper/Admin.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/notification/namespaces/{namespace}/freeform` | POST | FreeFormNotification | [FreeFormNotification](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Admin/FreeFormNotification.cs) | [FreeFormNotification](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Admin/FreeFormNotification.cs) |
| `/notification/namespaces/{namespace}/templated` | POST | NotificationWithTemplate | [NotificationWithTemplate](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Admin/NotificationWithTemplate.cs) | [NotificationWithTemplate](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Admin/NotificationWithTemplate.cs) |
| `/notification/namespaces/{namespace}/templates` | GET | GetGameTemplate | [GetGameTemplate](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Admin/GetGameTemplate.cs) | [GetGameTemplate](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Admin/GetGameTemplate.cs) |
| `/notification/namespaces/{namespace}/templates` | POST | CreateTemplate | [CreateTemplate](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Admin/CreateTemplate.cs) | [CreateTemplate](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Admin/CreateTemplate.cs) |
| `/notification/namespaces/{namespace}/templates/{templateSlug}` | GET | GetSlugTemplate | [GetSlugTemplate](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Admin/GetSlugTemplate.cs) | [GetSlugTemplate](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Admin/GetSlugTemplate.cs) |
| `/notification/namespaces/{namespace}/templates/{templateSlug}` | DELETE | DeleteTemplateSlug | [DeleteTemplateSlug](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Admin/DeleteTemplateSlug.cs) | [DeleteTemplateSlug](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Admin/DeleteTemplateSlug.cs) |
| `/notification/namespaces/{namespace}/templates/{templateSlug}/languages/{templateLanguage}` | GET | GetLocalizationTemplate | [GetLocalizationTemplate](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Admin/GetLocalizationTemplate.cs) | [GetLocalizationTemplate](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Admin/GetLocalizationTemplate.cs) |
| `/notification/namespaces/{namespace}/templates/{templateSlug}/languages/{templateLanguage}` | PUT | UpdateLocalizationTemplate | [UpdateLocalizationTemplate](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Admin/UpdateLocalizationTemplate.cs) | [UpdateLocalizationTemplate](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Admin/UpdateLocalizationTemplate.cs) |
| `/notification/namespaces/{namespace}/templates/{templateSlug}/languages/{templateLanguage}` | DELETE | DeleteTemplateLocalization | [DeleteTemplateLocalization](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Admin/DeleteTemplateLocalization.cs) | [DeleteTemplateLocalization](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Admin/DeleteTemplateLocalization.cs) |
| `/notification/namespaces/{namespace}/templates/{templateSlug}/languages/{templateLanguage}/publish` | POST | PublishTemplate | [PublishTemplate](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Admin/PublishTemplate.cs) | [PublishTemplate](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Admin/PublishTemplate.cs) |


&nbsp;

## Operations with Generic Response

### friends Wrapper:  [Friends](../../apis/AccelByte.Sdk.Api.Lobby/Wrapper/Friends.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### config Wrapper:  [Config](../../apis/AccelByte.Sdk.Api.Lobby/Wrapper/Config.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### notification Wrapper:  [Notification](../../apis/AccelByte.Sdk.Api.Lobby/Wrapper/Notification.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### party Wrapper:  [Party](../../apis/AccelByte.Sdk.Api.Lobby/Wrapper/Party.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/lobby/v1/admin/party/namespaces/{namespace}/parties/{partyId}` | GET | AdminGetPartyDataV1 | [AdminGetPartyDataV1](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Party/AdminGetPartyDataV1.cs) | [AdminGetPartyDataV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Party/AdminGetPartyDataV1.cs) |
| `/lobby/v1/admin/party/namespaces/{namespace}/users/{userId}/party` | GET | AdminGetUserPartyV1 | [AdminGetUserPartyV1](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Party/AdminGetUserPartyV1.cs) | [AdminGetUserPartyV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Party/AdminGetUserPartyV1.cs) |
| `/lobby/v1/public/party/namespaces/{namespace}/parties/{partyId}` | GET | PublicGetPartyDataV1 | [PublicGetPartyDataV1](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Party/PublicGetPartyDataV1.cs) | [PublicGetPartyDataV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Party/PublicGetPartyDataV1.cs) |
| `/lobby/v1/public/party/namespaces/{namespace}/parties/{partyId}/attributes` | PUT | PublicUpdatePartyAttributesV1 | [PublicUpdatePartyAttributesV1](../../apis/AccelByte.Sdk.Api.Lobby/Operation/Party/PublicUpdatePartyAttributesV1.cs) | [PublicUpdatePartyAttributesV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Party/PublicUpdatePartyAttributesV1.cs) |

### Lobby Operations Wrapper:  [LobbyOperations](../../apis/AccelByte.Sdk.Api.Lobby/Wrapper/LobbyOperations.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/lobby/v1/admin/party/namespaces/{namespace}/parties/{partyId}/attributes` | PUT | AdminUpdatePartyAttributesV1 | [AdminUpdatePartyAttributesV1](../../apis/AccelByte.Sdk.Api.Lobby/Operation/LobbyOperations/AdminUpdatePartyAttributesV1.cs) | [AdminUpdatePartyAttributesV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/LobbyOperations/AdminUpdatePartyAttributesV1.cs) |

### player Wrapper:  [Player](../../apis/AccelByte.Sdk.Api.Lobby/Wrapper/Player.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### profanity Wrapper:  [Profanity](../../apis/AccelByte.Sdk.Api.Lobby/Wrapper/Profanity.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### thirdParty Wrapper:  [ThirdParty](../../apis/AccelByte.Sdk.Api.Lobby/Wrapper/ThirdParty.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### presence Wrapper:  [Presence](../../apis/AccelByte.Sdk.Api.Lobby/Wrapper/Presence.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### admin Wrapper:  [Admin](../../apis/AccelByte.Sdk.Api.Lobby/Wrapper/Admin.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|


&nbsp;

## Models

| Model | Class |
|---|---|
| `handlers.GetUsersPresenceResponse` | [HandlersGetUsersPresenceResponse](../../apis/AccelByte.Sdk.Api.Lobby/Model/HandlersGetUsersPresenceResponse.cs) |
| `handlers.UserPresence` | [HandlersUserPresence](../../apis/AccelByte.Sdk.Api.Lobby/Model/HandlersUserPresence.cs) |
| `log.AppMessageDeclaration` | [LogAppMessageDeclaration](../../apis/AccelByte.Sdk.Api.Lobby/Model/LogAppMessageDeclaration.cs) |
| `model.BulkFriendsRequest` | [ModelBulkFriendsRequest](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelBulkFriendsRequest.cs) |
| `model.BulkFriendsResponse` | [ModelBulkFriendsResponse](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelBulkFriendsResponse.cs) |
| `model.BulkUsersFreeFormNotificationRequestV1` | [ModelBulkUsersFreeFormNotificationRequestV1](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelBulkUsersFreeFormNotificationRequestV1.cs) |
| `model.CreateTemplateRequest` | [ModelCreateTemplateRequest](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelCreateTemplateRequest.cs) |
| `model.CreateTopicRequest` | [ModelCreateTopicRequest](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelCreateTopicRequest.cs) |
| `model.CreateTopicRequestV1` | [ModelCreateTopicRequestV1](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelCreateTopicRequestV1.cs) |
| `model.FreeFormNotificationRequest` | [ModelFreeFormNotificationRequest](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelFreeFormNotificationRequest.cs) |
| `model.FreeFormNotificationRequestV1` | [ModelFreeFormNotificationRequestV1](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelFreeFormNotificationRequestV1.cs) |
| `model.GetAllNotificationTemplateSlugResp` | [ModelGetAllNotificationTemplateSlugResp](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelGetAllNotificationTemplateSlugResp.cs) |
| `model.GetAllNotificationTopicsResponse` | [ModelGetAllNotificationTopicsResponse](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelGetAllNotificationTopicsResponse.cs) |
| `model.GetFriendsResponse` | [ModelGetFriendsResponse](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelGetFriendsResponse.cs) |
| `model.GetUserFriendsResponse` | [ModelGetUserFriendsResponse](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelGetUserFriendsResponse.cs) |
| `model.GetUserIncomingFriendsResponse` | [ModelGetUserIncomingFriendsResponse](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelGetUserIncomingFriendsResponse.cs) |
| `model.GetUserOutgoingFriendsResponse` | [ModelGetUserOutgoingFriendsResponse](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelGetUserOutgoingFriendsResponse.cs) |
| `model.IncomingFriendsWithTimeData` | [ModelIncomingFriendsWithTimeData](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelIncomingFriendsWithTimeData.cs) |
| `model.ListBulkUserPlatformsResponse` | [ModelListBulkUserPlatformsResponse](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelListBulkUserPlatformsResponse.cs) |
| `model.LoadIncomingFriendsWithTimeResponse` | [ModelLoadIncomingFriendsWithTimeResponse](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelLoadIncomingFriendsWithTimeResponse.cs) |
| `model.LoadOutgoingFriendsWithTimeResponse` | [ModelLoadOutgoingFriendsWithTimeResponse](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelLoadOutgoingFriendsWithTimeResponse.cs) |
| `model.Localization` | [ModelLocalization](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelLocalization.cs) |
| `model.NotificationTemplateResponse` | [ModelNotificationTemplateResponse](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelNotificationTemplateResponse.cs) |
| `model.NotificationTopicResponse` | [ModelNotificationTopicResponse](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelNotificationTopicResponse.cs) |
| `model.NotificationTopicResponseV1` | [ModelNotificationTopicResponseV1](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelNotificationTopicResponseV1.cs) |
| `model.NotificationWithTemplateRequest` | [ModelNotificationWithTemplateRequest](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelNotificationWithTemplateRequest.cs) |
| `model.NotificationWithTemplateRequestV1` | [ModelNotificationWithTemplateRequestV1](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelNotificationWithTemplateRequestV1.cs) |
| `model.OutgoingFriendsWithTimeData` | [ModelOutgoingFriendsWithTimeData](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelOutgoingFriendsWithTimeData.cs) |
| `model.Pagination` | [ModelPagination](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelPagination.cs) |
| `model.TemplateContent` | [ModelTemplateContent](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelTemplateContent.cs) |
| `model.TemplateLocalization` | [ModelTemplateLocalization](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelTemplateLocalization.cs) |
| `model.TemplateLocalizationResponse` | [ModelTemplateLocalizationResponse](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelTemplateLocalizationResponse.cs) |
| `model.TemplateResponse` | [ModelTemplateResponse](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelTemplateResponse.cs) |
| `model.TopicByNamespacesResponse` | [ModelTopicByNamespacesResponse](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelTopicByNamespacesResponse.cs) |
| `model.UpdateTemplateRequest` | [ModelUpdateTemplateRequest](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelUpdateTemplateRequest.cs) |
| `model.UpdateTopicRequest` | [ModelUpdateTopicRequest](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelUpdateTopicRequest.cs) |
| `model.UserAcceptFriendRequest` | [ModelUserAcceptFriendRequest](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelUserAcceptFriendRequest.cs) |
| `model.UserCancelFriendRequest` | [ModelUserCancelFriendRequest](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelUserCancelFriendRequest.cs) |
| `model.UserGetFriendshipStatusResponse` | [ModelUserGetFriendshipStatusResponse](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelUserGetFriendshipStatusResponse.cs) |
| `model.UserPlatformInfo` | [ModelUserPlatformInfo](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelUserPlatformInfo.cs) |
| `model.UserRejectFriendRequest` | [ModelUserRejectFriendRequest](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelUserRejectFriendRequest.cs) |
| `model.UserRequestFriendRequest` | [ModelUserRequestFriendRequest](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelUserRequestFriendRequest.cs) |
| `model.UserUnfriendRequest` | [ModelUserUnfriendRequest](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelUserUnfriendRequest.cs) |
| `model.UserWithPlatformInfo` | [ModelUserWithPlatformInfo](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelUserWithPlatformInfo.cs) |
| `models.AdminAddProfanityFilterIntoListRequest` | [ModelsAdminAddProfanityFilterIntoListRequest](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelsAdminAddProfanityFilterIntoListRequest.cs) |
| `models.AdminAddProfanityFiltersFilterRequest` | [ModelsAdminAddProfanityFiltersFilterRequest](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelsAdminAddProfanityFiltersFilterRequest.cs) |
| `models.AdminAddProfanityFiltersRequest` | [ModelsAdminAddProfanityFiltersRequest](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelsAdminAddProfanityFiltersRequest.cs) |
| `models.AdminCreateProfanityListRequest` | [ModelsAdminCreateProfanityListRequest](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelsAdminCreateProfanityListRequest.cs) |
| `models.AdminDeleteProfanityFilterRequest` | [ModelsAdminDeleteProfanityFilterRequest](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelsAdminDeleteProfanityFilterRequest.cs) |
| `models.AdminGetProfanityListFiltersV1Response` | [ModelsAdminGetProfanityListFiltersV1Response](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelsAdminGetProfanityListFiltersV1Response.cs) |
| `models.AdminGetProfanityListsListResponse` | [ModelsAdminGetProfanityListsListResponse](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelsAdminGetProfanityListsListResponse.cs) |
| `models.AdminSetProfanityRuleForNamespaceRequest` | [ModelsAdminSetProfanityRuleForNamespaceRequest](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelsAdminSetProfanityRuleForNamespaceRequest.cs) |
| `models.AdminUpdateProfanityList` | [ModelsAdminUpdateProfanityList](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelsAdminUpdateProfanityList.cs) |
| `models.AdminVerifyMessageProfanityRequest` | [ModelsAdminVerifyMessageProfanityRequest](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelsAdminVerifyMessageProfanityRequest.cs) |
| `models.AdminVerifyMessageProfanityResponse` | [ModelsAdminVerifyMessageProfanityResponse](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelsAdminVerifyMessageProfanityResponse.cs) |
| `models.BlockedByPlayerData` | [ModelsBlockedByPlayerData](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelsBlockedByPlayerData.cs) |
| `models.BlockedPlayerData` | [ModelsBlockedPlayerData](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelsBlockedPlayerData.cs) |
| `models.Config` | [ModelsConfig](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelsConfig.cs) |
| `models.ConfigList` | [ModelsConfigList](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelsConfigList.cs) |
| `models.ConfigReq` | [ModelsConfigReq](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelsConfigReq.cs) |
| `models.CreateConfigRequest` | [ModelsCreateConfigRequest](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelsCreateConfigRequest.cs) |
| `models.CreateConfigResponse` | [ModelsCreateConfigResponse](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelsCreateConfigResponse.cs) |
| `models.DebugProfanityFilterRequest` | [ModelsDebugProfanityFilterRequest](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelsDebugProfanityFilterRequest.cs) |
| `models.GetAllPlayerBlockedByUsersResponse` | [ModelsGetAllPlayerBlockedByUsersResponse](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelsGetAllPlayerBlockedByUsersResponse.cs) |
| `models.GetAllPlayerBlockedUsersResponse` | [ModelsGetAllPlayerBlockedUsersResponse](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelsGetAllPlayerBlockedUsersResponse.cs) |
| `models.GetAllPlayerSessionAttributeResponse` | [ModelsGetAllPlayerSessionAttributeResponse](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelsGetAllPlayerSessionAttributeResponse.cs) |
| `models.GetBulkAllPlayerBlockedUsersRequest` | [ModelsGetBulkAllPlayerBlockedUsersRequest](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelsGetBulkAllPlayerBlockedUsersRequest.cs) |
| `models.GetBulkAllPlayerBlockedUsersResponse` | [ModelsGetBulkAllPlayerBlockedUsersResponse](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelsGetBulkAllPlayerBlockedUsersResponse.cs) |
| `models.GetConfigResponse` | [ModelsGetConfigResponse](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelsGetConfigResponse.cs) |
| `models.GetLobbyCcuResponse` | [ModelsGetLobbyCcuResponse](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelsGetLobbyCcuResponse.cs) |
| `models.GetPlayerSessionAttributeResponse` | [ModelsGetPlayerSessionAttributeResponse](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelsGetPlayerSessionAttributeResponse.cs) |
| `models.ImportConfigResponse` | [ModelsImportConfigResponse](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelsImportConfigResponse.cs) |
| `models.ListBlockedPlayerRequest` | [ModelsListBlockedPlayerRequest](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelsListBlockedPlayerRequest.cs) |
| `models.PartyData` | [ModelsPartyData](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelsPartyData.cs) |
| `models.PartyPUTCustomAttributesRequest` | [ModelsPartyPUTCustomAttributesRequest](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelsPartyPUTCustomAttributesRequest.cs) |
| `models.PartyPUTLimitSizeRequest` | [ModelsPartyPUTLimitSizeRequest](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelsPartyPUTLimitSizeRequest.cs) |
| `models.ProfanityFilter` | [ModelsProfanityFilter](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelsProfanityFilter.cs) |
| `models.ProfanityRule` | [ModelsProfanityRule](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelsProfanityRule.cs) |
| `models.SetPlayerSessionAttributeRequest` | [ModelsSetPlayerSessionAttributeRequest](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelsSetPlayerSessionAttributeRequest.cs) |
| `models.UpdateConfigRequest` | [ModelsUpdateConfigRequest](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelsUpdateConfigRequest.cs) |
| `models.UpdateConfigResponse` | [ModelsUpdateConfigResponse](../../apis/AccelByte.Sdk.Api.Lobby/Model/ModelsUpdateConfigResponse.cs) |
| `response.Error` | [ResponseError](../../apis/AccelByte.Sdk.Api.Lobby/Model/ResponseError.cs) |
| `restapi.ErrorResponseBody` | [RestapiErrorResponseBody](../../apis/AccelByte.Sdk.Api.Lobby/Model/RestapiErrorResponseBody.cs) |
| `restapi.ErrorResponseV1` | [RestapiErrorResponseV1](../../apis/AccelByte.Sdk.Api.Lobby/Model/RestapiErrorResponseV1.cs) |