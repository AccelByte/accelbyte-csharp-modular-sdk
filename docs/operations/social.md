# Social Service Index

&nbsp;

## Operations

### SlotConfig Wrapper:  [SlotConfig](../../apis/AccelByte.Sdk.Api.Social/Wrapper/SlotConfig.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| [DEPRECATED] `/social/admin/namespaces/{namespace}/config` | GET | GetNamespaceSlotConfig | [GetNamespaceSlotConfig](../../apis/AccelByte.Sdk.Api.Social/Operation/SlotConfig/GetNamespaceSlotConfig.cs) | [GetNamespaceSlotConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/SlotConfig/GetNamespaceSlotConfig.cs) |
| [DEPRECATED] `/social/admin/namespaces/{namespace}/config` | PUT | UpdateNamespaceSlotConfig | [UpdateNamespaceSlotConfig](../../apis/AccelByte.Sdk.Api.Social/Operation/SlotConfig/UpdateNamespaceSlotConfig.cs) | [UpdateNamespaceSlotConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/SlotConfig/UpdateNamespaceSlotConfig.cs) |
| [DEPRECATED] `/social/admin/namespaces/{namespace}/config` | DELETE | DeleteNamespaceSlotConfig | [DeleteNamespaceSlotConfig](../../apis/AccelByte.Sdk.Api.Social/Operation/SlotConfig/DeleteNamespaceSlotConfig.cs) | [DeleteNamespaceSlotConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/SlotConfig/DeleteNamespaceSlotConfig.cs) |
| [DEPRECATED] `/social/admin/namespaces/{namespace}/users/{userId}/config` | GET | GetUserSlotConfig | [GetUserSlotConfig](../../apis/AccelByte.Sdk.Api.Social/Operation/SlotConfig/GetUserSlotConfig.cs) | [GetUserSlotConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/SlotConfig/GetUserSlotConfig.cs) |
| [DEPRECATED] `/social/admin/namespaces/{namespace}/users/{userId}/config` | PUT | UpdateUserSlotConfig | [UpdateUserSlotConfig](../../apis/AccelByte.Sdk.Api.Social/Operation/SlotConfig/UpdateUserSlotConfig.cs) | [UpdateUserSlotConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/SlotConfig/UpdateUserSlotConfig.cs) |
| [DEPRECATED] `/social/admin/namespaces/{namespace}/users/{userId}/config` | DELETE | DeleteUserSlotConfig | [DeleteUserSlotConfig](../../apis/AccelByte.Sdk.Api.Social/Operation/SlotConfig/DeleteUserSlotConfig.cs) | [DeleteUserSlotConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/SlotConfig/DeleteUserSlotConfig.cs) |

### GameProfile Wrapper:  [GameProfile](../../apis/AccelByte.Sdk.Api.Social/Wrapper/GameProfile.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/social/admin/namespaces/{namespace}/users/{userId}/profiles` | GET | GetUserProfiles | [GetUserProfiles](../../apis/AccelByte.Sdk.Api.Social/Operation/GameProfile/GetUserProfiles.cs) | [GetUserProfiles](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/GameProfile/GetUserProfiles.cs) |
| `/social/admin/namespaces/{namespace}/users/{userId}/profiles/{profileId}` | GET | GetProfile | [GetProfile](../../apis/AccelByte.Sdk.Api.Social/Operation/GameProfile/GetProfile.cs) | [GetProfile](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/GameProfile/GetProfile.cs) |
| `/social/public/namespaces/{namespace}/profiles` | GET | PublicGetUserGameProfiles | [PublicGetUserGameProfiles](../../apis/AccelByte.Sdk.Api.Social/Operation/GameProfile/PublicGetUserGameProfiles.cs) | [PublicGetUserGameProfiles](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/GameProfile/PublicGetUserGameProfiles.cs) |
| `/social/public/namespaces/{namespace}/users/{userId}/profiles` | GET | PublicGetUserProfiles | [PublicGetUserProfiles](../../apis/AccelByte.Sdk.Api.Social/Operation/GameProfile/PublicGetUserProfiles.cs) | [PublicGetUserProfiles](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/GameProfile/PublicGetUserProfiles.cs) |
| `/social/public/namespaces/{namespace}/users/{userId}/profiles` | POST | PublicCreateProfile | [PublicCreateProfile](../../apis/AccelByte.Sdk.Api.Social/Operation/GameProfile/PublicCreateProfile.cs) | [PublicCreateProfile](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/GameProfile/PublicCreateProfile.cs) |
| `/social/public/namespaces/{namespace}/users/{userId}/profiles/{profileId}` | GET | PublicGetProfile | [PublicGetProfile](../../apis/AccelByte.Sdk.Api.Social/Operation/GameProfile/PublicGetProfile.cs) | [PublicGetProfile](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/GameProfile/PublicGetProfile.cs) |
| `/social/public/namespaces/{namespace}/users/{userId}/profiles/{profileId}` | PUT | PublicUpdateProfile | [PublicUpdateProfile](../../apis/AccelByte.Sdk.Api.Social/Operation/GameProfile/PublicUpdateProfile.cs) | [PublicUpdateProfile](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/GameProfile/PublicUpdateProfile.cs) |
| `/social/public/namespaces/{namespace}/users/{userId}/profiles/{profileId}` | DELETE | PublicDeleteProfile | [PublicDeleteProfile](../../apis/AccelByte.Sdk.Api.Social/Operation/GameProfile/PublicDeleteProfile.cs) | [PublicDeleteProfile](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/GameProfile/PublicDeleteProfile.cs) |
| `/social/public/namespaces/{namespace}/users/{userId}/profiles/{profileId}/attributes/{attributeName}` | GET | PublicGetProfileAttribute | [PublicGetProfileAttribute](../../apis/AccelByte.Sdk.Api.Social/Operation/GameProfile/PublicGetProfileAttribute.cs) | [PublicGetProfileAttribute](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/GameProfile/PublicGetProfileAttribute.cs) |
| `/social/public/namespaces/{namespace}/users/{userId}/profiles/{profileId}/attributes/{attributeName}` | PUT | PublicUpdateAttribute | [PublicUpdateAttribute](../../apis/AccelByte.Sdk.Api.Social/Operation/GameProfile/PublicUpdateAttribute.cs) | [PublicUpdateAttribute](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/GameProfile/PublicUpdateAttribute.cs) |

### Slot Wrapper:  [Slot](../../apis/AccelByte.Sdk.Api.Social/Wrapper/Slot.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| [DEPRECATED] `/social/admin/namespaces/{namespace}/users/{userId}/slots` | GET | GetUserNamespaceSlots | [GetUserNamespaceSlots](../../apis/AccelByte.Sdk.Api.Social/Operation/Slot/GetUserNamespaceSlots.cs) | [GetUserNamespaceSlots](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/Slot/GetUserNamespaceSlots.cs) |
| [DEPRECATED] `/social/admin/namespaces/{namespace}/users/{userId}/slots/{slotId}` | GET | GetSlotData | [GetSlotData](../../apis/AccelByte.Sdk.Api.Social/Operation/Slot/GetSlotData.cs) | [GetSlotData](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/Slot/GetSlotData.cs) |
| [DEPRECATED] `/social/public/namespaces/{namespace}/users/{userId}/slots` | GET | PublicGetUserNamespaceSlots | [PublicGetUserNamespaceSlots](../../apis/AccelByte.Sdk.Api.Social/Operation/Slot/PublicGetUserNamespaceSlots.cs) | [PublicGetUserNamespaceSlots](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/Slot/PublicGetUserNamespaceSlots.cs) |
| [DEPRECATED] `/social/public/namespaces/{namespace}/users/{userId}/slots` | POST | PublicCreateUserNamespaceSlot | [PublicCreateUserNamespaceSlot](../../apis/AccelByte.Sdk.Api.Social/Operation/Slot/PublicCreateUserNamespaceSlot.cs) | [PublicCreateUserNamespaceSlot](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/Slot/PublicCreateUserNamespaceSlot.cs) |
| [DEPRECATED] `/social/public/namespaces/{namespace}/users/{userId}/slots/{slotId}` | GET | PublicGetSlotData | [PublicGetSlotData](../../apis/AccelByte.Sdk.Api.Social/Operation/Slot/PublicGetSlotData.cs) | [PublicGetSlotData](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/Slot/PublicGetSlotData.cs) |
| [DEPRECATED] `/social/public/namespaces/{namespace}/users/{userId}/slots/{slotId}` | PUT | PublicUpdateUserNamespaceSlot | [PublicUpdateUserNamespaceSlot](../../apis/AccelByte.Sdk.Api.Social/Operation/Slot/PublicUpdateUserNamespaceSlot.cs) | [PublicUpdateUserNamespaceSlot](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/Slot/PublicUpdateUserNamespaceSlot.cs) |
| [DEPRECATED] `/social/public/namespaces/{namespace}/users/{userId}/slots/{slotId}` | DELETE | PublicDeleteUserNamespaceSlot | [PublicDeleteUserNamespaceSlot](../../apis/AccelByte.Sdk.Api.Social/Operation/Slot/PublicDeleteUserNamespaceSlot.cs) | [PublicDeleteUserNamespaceSlot](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/Slot/PublicDeleteUserNamespaceSlot.cs) |
| [DEPRECATED] `/social/public/namespaces/{namespace}/users/{userId}/slots/{slotId}/metadata` | PUT | PublicUpdateUserNamespaceSlotMetadata | [PublicUpdateUserNamespaceSlotMetadata](../../apis/AccelByte.Sdk.Api.Social/Operation/Slot/PublicUpdateUserNamespaceSlotMetadata.cs) | [PublicUpdateUserNamespaceSlotMetadata](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/Slot/PublicUpdateUserNamespaceSlotMetadata.cs) |

### GlobalStatistic Wrapper:  [GlobalStatistic](../../apis/AccelByte.Sdk.Api.Social/Wrapper/GlobalStatistic.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/social/v1/admin/namespaces/{namespace}/globalstatitems` | GET | GetGlobalStatItems | [GetGlobalStatItems](../../apis/AccelByte.Sdk.Api.Social/Operation/GlobalStatistic/GetGlobalStatItems.cs) | [GetGlobalStatItems](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/GlobalStatistic/GetGlobalStatItems.cs) |
| `/social/v1/admin/namespaces/{namespace}/globalstatitems/{statCode}` | GET | GetGlobalStatItemByStatCode | [GetGlobalStatItemByStatCode](../../apis/AccelByte.Sdk.Api.Social/Operation/GlobalStatistic/GetGlobalStatItemByStatCode.cs) | [GetGlobalStatItemByStatCode](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/GlobalStatistic/GetGlobalStatItemByStatCode.cs) |
| `/social/v1/public/namespaces/{namespace}/globalstatitems` | GET | GetGlobalStatItems1 | [GetGlobalStatItems1](../../apis/AccelByte.Sdk.Api.Social/Operation/GlobalStatistic/GetGlobalStatItems1.cs) | [GetGlobalStatItems1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/GlobalStatistic/GetGlobalStatItems1.cs) |
| `/social/v1/public/namespaces/{namespace}/globalstatitems/{statCode}` | GET | GetGlobalStatItemByStatCode1 | [GetGlobalStatItemByStatCode1](../../apis/AccelByte.Sdk.Api.Social/Operation/GlobalStatistic/GetGlobalStatItemByStatCode1.cs) | [GetGlobalStatItemByStatCode1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/GlobalStatistic/GetGlobalStatItemByStatCode1.cs) |

### StatCycleConfiguration Wrapper:  [StatCycleConfiguration](../../apis/AccelByte.Sdk.Api.Social/Wrapper/StatCycleConfiguration.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/social/v1/admin/namespaces/{namespace}/statCycles` | GET | GetStatCycles | [GetStatCycles](../../apis/AccelByte.Sdk.Api.Social/Operation/StatCycleConfiguration/GetStatCycles.cs) | [GetStatCycles](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/StatCycleConfiguration/GetStatCycles.cs) |
| `/social/v1/admin/namespaces/{namespace}/statCycles` | POST | CreateStatCycle | [CreateStatCycle](../../apis/AccelByte.Sdk.Api.Social/Operation/StatCycleConfiguration/CreateStatCycle.cs) | [CreateStatCycle](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/StatCycleConfiguration/CreateStatCycle.cs) |
| `/social/v1/admin/namespaces/{namespace}/statCycles/bulk` | POST | BulkGetStatCycle | [BulkGetStatCycle](../../apis/AccelByte.Sdk.Api.Social/Operation/StatCycleConfiguration/BulkGetStatCycle.cs) | [BulkGetStatCycle](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/StatCycleConfiguration/BulkGetStatCycle.cs) |
| `/social/v1/admin/namespaces/{namespace}/statCycles/{cycleId}` | GET | GetStatCycle | [GetStatCycle](../../apis/AccelByte.Sdk.Api.Social/Operation/StatCycleConfiguration/GetStatCycle.cs) | [GetStatCycle](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/StatCycleConfiguration/GetStatCycle.cs) |
| `/social/v1/admin/namespaces/{namespace}/statCycles/{cycleId}` | PUT | UpdateStatCycle | [UpdateStatCycle](../../apis/AccelByte.Sdk.Api.Social/Operation/StatCycleConfiguration/UpdateStatCycle.cs) | [UpdateStatCycle](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/StatCycleConfiguration/UpdateStatCycle.cs) |
| `/social/v1/admin/namespaces/{namespace}/statCycles/{cycleId}` | DELETE | DeleteStatCycle | [DeleteStatCycle](../../apis/AccelByte.Sdk.Api.Social/Operation/StatCycleConfiguration/DeleteStatCycle.cs) | [DeleteStatCycle](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/StatCycleConfiguration/DeleteStatCycle.cs) |
| `/social/v1/admin/namespaces/{namespace}/statCycles/{cycleId}/stats/add/bulk` | POST | BulkAddStats | [BulkAddStats](../../apis/AccelByte.Sdk.Api.Social/Operation/StatCycleConfiguration/BulkAddStats.cs) | [BulkAddStats](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/StatCycleConfiguration/BulkAddStats.cs) |
| `/social/v1/admin/namespaces/{namespace}/statCycles/{cycleId}/stop` | PUT | StopStatCycle | [StopStatCycle](../../apis/AccelByte.Sdk.Api.Social/Operation/StatCycleConfiguration/StopStatCycle.cs) | [StopStatCycle](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/StatCycleConfiguration/StopStatCycle.cs) |
| `/social/v1/public/namespaces/{namespace}/statCycles` | GET | GetStatCycles1 | [GetStatCycles1](../../apis/AccelByte.Sdk.Api.Social/Operation/StatCycleConfiguration/GetStatCycles1.cs) | [GetStatCycles1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/StatCycleConfiguration/GetStatCycles1.cs) |
| `/social/v1/public/namespaces/{namespace}/statCycles/bulk` | POST | BulkGetStatCycle1 | [BulkGetStatCycle1](../../apis/AccelByte.Sdk.Api.Social/Operation/StatCycleConfiguration/BulkGetStatCycle1.cs) | [BulkGetStatCycle1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/StatCycleConfiguration/BulkGetStatCycle1.cs) |
| `/social/v1/public/namespaces/{namespace}/statCycles/{cycleId}` | GET | GetStatCycle1 | [GetStatCycle1](../../apis/AccelByte.Sdk.Api.Social/Operation/StatCycleConfiguration/GetStatCycle1.cs) | [GetStatCycle1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/StatCycleConfiguration/GetStatCycle1.cs) |

### UserStatistic Wrapper:  [UserStatistic](../../apis/AccelByte.Sdk.Api.Social/Wrapper/UserStatistic.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/social/v1/admin/namespaces/{namespace}/statitems/bulk` | GET | BulkFetchStatItems | [BulkFetchStatItems](../../apis/AccelByte.Sdk.Api.Social/Operation/UserStatistic/BulkFetchStatItems.cs) | [BulkFetchStatItems](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/UserStatistic/BulkFetchStatItems.cs) |
| `/social/v1/admin/namespaces/{namespace}/statitems/value/bulk` | PUT | BulkIncUserStatItem | [BulkIncUserStatItem](../../apis/AccelByte.Sdk.Api.Social/Operation/UserStatistic/BulkIncUserStatItem.cs) | [BulkIncUserStatItem](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/UserStatistic/BulkIncUserStatItem.cs) |
| `/social/v1/admin/namespaces/{namespace}/statitems/value/bulk` | PATCH | BulkIncUserStatItemValue | [BulkIncUserStatItemValue](../../apis/AccelByte.Sdk.Api.Social/Operation/UserStatistic/BulkIncUserStatItemValue.cs) | [BulkIncUserStatItemValue](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/UserStatistic/BulkIncUserStatItemValue.cs) |
| `/social/v1/admin/namespaces/{namespace}/statitems/value/bulk/getOrDefault` | GET | BulkFetchOrDefaultStatItems | [BulkFetchOrDefaultStatItems](../../apis/AccelByte.Sdk.Api.Social/Operation/UserStatistic/BulkFetchOrDefaultStatItems.cs) | [BulkFetchOrDefaultStatItems](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/UserStatistic/BulkFetchOrDefaultStatItems.cs) |
| `/social/v1/admin/namespaces/{namespace}/statitems/value/reset/bulk` | PUT | BulkResetUserStatItem | [BulkResetUserStatItem](../../apis/AccelByte.Sdk.Api.Social/Operation/UserStatistic/BulkResetUserStatItem.cs) | [BulkResetUserStatItem](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/UserStatistic/BulkResetUserStatItem.cs) |
| `/social/v1/admin/namespaces/{namespace}/users/{userId}/statitems` | GET | GetUserStatItems | [GetUserStatItems](../../apis/AccelByte.Sdk.Api.Social/Operation/UserStatistic/GetUserStatItems.cs) | [GetUserStatItems](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/UserStatistic/GetUserStatItems.cs) |
| `/social/v1/admin/namespaces/{namespace}/users/{userId}/statitems/bulk` | POST | BulkCreateUserStatItems | [BulkCreateUserStatItems](../../apis/AccelByte.Sdk.Api.Social/Operation/UserStatistic/BulkCreateUserStatItems.cs) | [BulkCreateUserStatItems](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/UserStatistic/BulkCreateUserStatItems.cs) |
| `/social/v1/admin/namespaces/{namespace}/users/{userId}/statitems/value/bulk` | PUT | BulkIncUserStatItem1 | [BulkIncUserStatItem1](../../apis/AccelByte.Sdk.Api.Social/Operation/UserStatistic/BulkIncUserStatItem1.cs) | [BulkIncUserStatItem1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/UserStatistic/BulkIncUserStatItem1.cs) |
| `/social/v1/admin/namespaces/{namespace}/users/{userId}/statitems/value/bulk` | PATCH | BulkIncUserStatItemValue1 | [BulkIncUserStatItemValue1](../../apis/AccelByte.Sdk.Api.Social/Operation/UserStatistic/BulkIncUserStatItemValue1.cs) | [BulkIncUserStatItemValue1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/UserStatistic/BulkIncUserStatItemValue1.cs) |
| `/social/v1/admin/namespaces/{namespace}/users/{userId}/statitems/value/reset/bulk` | PUT | BulkResetUserStatItem1 | [BulkResetUserStatItem1](../../apis/AccelByte.Sdk.Api.Social/Operation/UserStatistic/BulkResetUserStatItem1.cs) | [BulkResetUserStatItem1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/UserStatistic/BulkResetUserStatItem1.cs) |
| `/social/v1/admin/namespaces/{namespace}/users/{userId}/stats/{statCode}/statitems` | POST | CreateUserStatItem | [CreateUserStatItem](../../apis/AccelByte.Sdk.Api.Social/Operation/UserStatistic/CreateUserStatItem.cs) | [CreateUserStatItem](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/UserStatistic/CreateUserStatItem.cs) |
| `/social/v1/admin/namespaces/{namespace}/users/{userId}/stats/{statCode}/statitems` | DELETE | DeleteUserStatItems | [DeleteUserStatItems](../../apis/AccelByte.Sdk.Api.Social/Operation/UserStatistic/DeleteUserStatItems.cs) | [DeleteUserStatItems](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/UserStatistic/DeleteUserStatItems.cs) |
| `/social/v1/admin/namespaces/{namespace}/users/{userId}/stats/{statCode}/statitems/value` | PATCH | IncUserStatItemValue | [IncUserStatItemValue](../../apis/AccelByte.Sdk.Api.Social/Operation/UserStatistic/IncUserStatItemValue.cs) | [IncUserStatItemValue](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/UserStatistic/IncUserStatItemValue.cs) |
| `/social/v1/admin/namespaces/{namespace}/users/{userId}/stats/{statCode}/statitems/value/reset` | PUT | ResetUserStatItemValue | [ResetUserStatItemValue](../../apis/AccelByte.Sdk.Api.Social/Operation/UserStatistic/ResetUserStatItemValue.cs) | [ResetUserStatItemValue](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/UserStatistic/ResetUserStatItemValue.cs) |
| `/social/v1/public/namespaces/{namespace}/statitems/bulk` | GET | BulkFetchStatItems1 | [BulkFetchStatItems1](../../apis/AccelByte.Sdk.Api.Social/Operation/UserStatistic/BulkFetchStatItems1.cs) | [BulkFetchStatItems1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/UserStatistic/BulkFetchStatItems1.cs) |
| `/social/v1/public/namespaces/{namespace}/statitems/value/bulk` | PUT | PublicBulkIncUserStatItem | [PublicBulkIncUserStatItem](../../apis/AccelByte.Sdk.Api.Social/Operation/UserStatistic/PublicBulkIncUserStatItem.cs) | [PublicBulkIncUserStatItem](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/UserStatistic/PublicBulkIncUserStatItem.cs) |
| `/social/v1/public/namespaces/{namespace}/statitems/value/bulk` | PATCH | PublicBulkIncUserStatItemValue | [PublicBulkIncUserStatItemValue](../../apis/AccelByte.Sdk.Api.Social/Operation/UserStatistic/PublicBulkIncUserStatItemValue.cs) | [PublicBulkIncUserStatItemValue](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/UserStatistic/PublicBulkIncUserStatItemValue.cs) |
| `/social/v1/public/namespaces/{namespace}/statitems/value/reset/bulk` | PUT | BulkResetUserStatItem2 | [BulkResetUserStatItem2](../../apis/AccelByte.Sdk.Api.Social/Operation/UserStatistic/BulkResetUserStatItem2.cs) | [BulkResetUserStatItem2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/UserStatistic/BulkResetUserStatItem2.cs) |
| `/social/v1/public/namespaces/{namespace}/users/me/statitems` | GET | PublicListMyStatItems | [PublicListMyStatItems](../../apis/AccelByte.Sdk.Api.Social/Operation/UserStatistic/PublicListMyStatItems.cs) | [PublicListMyStatItems](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/UserStatistic/PublicListMyStatItems.cs) |
| `/social/v1/public/namespaces/{namespace}/users/me/statitems/value/bulk` | GET | PublicListAllMyStatItems | [PublicListAllMyStatItems](../../apis/AccelByte.Sdk.Api.Social/Operation/UserStatistic/PublicListAllMyStatItems.cs) | [PublicListAllMyStatItems](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/UserStatistic/PublicListAllMyStatItems.cs) |
| `/social/v1/public/namespaces/{namespace}/users/{userId}/statitems` | GET | PublicQueryUserStatItems | [PublicQueryUserStatItems](../../apis/AccelByte.Sdk.Api.Social/Operation/UserStatistic/PublicQueryUserStatItems.cs) | [PublicQueryUserStatItems](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/UserStatistic/PublicQueryUserStatItems.cs) |
| `/social/v1/public/namespaces/{namespace}/users/{userId}/statitems/bulk` | POST | PublicBulkCreateUserStatItems | [PublicBulkCreateUserStatItems](../../apis/AccelByte.Sdk.Api.Social/Operation/UserStatistic/PublicBulkCreateUserStatItems.cs) | [PublicBulkCreateUserStatItems](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/UserStatistic/PublicBulkCreateUserStatItems.cs) |
| `/social/v1/public/namespaces/{namespace}/users/{userId}/statitems/value/bulk` | GET | PublicQueryUserStatItems1 | [PublicQueryUserStatItems1](../../apis/AccelByte.Sdk.Api.Social/Operation/UserStatistic/PublicQueryUserStatItems1.cs) | [PublicQueryUserStatItems1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/UserStatistic/PublicQueryUserStatItems1.cs) |
| `/social/v1/public/namespaces/{namespace}/users/{userId}/statitems/value/bulk` | PUT | PublicBulkIncUserStatItem1 | [PublicBulkIncUserStatItem1](../../apis/AccelByte.Sdk.Api.Social/Operation/UserStatistic/PublicBulkIncUserStatItem1.cs) | [PublicBulkIncUserStatItem1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/UserStatistic/PublicBulkIncUserStatItem1.cs) |
| `/social/v1/public/namespaces/{namespace}/users/{userId}/statitems/value/bulk` | PATCH | BulkIncUserStatItemValue2 | [BulkIncUserStatItemValue2](../../apis/AccelByte.Sdk.Api.Social/Operation/UserStatistic/BulkIncUserStatItemValue2.cs) | [BulkIncUserStatItemValue2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/UserStatistic/BulkIncUserStatItemValue2.cs) |
| `/social/v1/public/namespaces/{namespace}/users/{userId}/statitems/value/reset/bulk` | PUT | BulkResetUserStatItem3 | [BulkResetUserStatItem3](../../apis/AccelByte.Sdk.Api.Social/Operation/UserStatistic/BulkResetUserStatItem3.cs) | [BulkResetUserStatItem3](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/UserStatistic/BulkResetUserStatItem3.cs) |
| `/social/v1/public/namespaces/{namespace}/users/{userId}/stats/{statCode}/statitems` | POST | PublicCreateUserStatItem | [PublicCreateUserStatItem](../../apis/AccelByte.Sdk.Api.Social/Operation/UserStatistic/PublicCreateUserStatItem.cs) | [PublicCreateUserStatItem](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/UserStatistic/PublicCreateUserStatItem.cs) |
| `/social/v1/public/namespaces/{namespace}/users/{userId}/stats/{statCode}/statitems` | DELETE | DeleteUserStatItems1 | [DeleteUserStatItems1](../../apis/AccelByte.Sdk.Api.Social/Operation/UserStatistic/DeleteUserStatItems1.cs) | [DeleteUserStatItems1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/UserStatistic/DeleteUserStatItems1.cs) |
| `/social/v1/public/namespaces/{namespace}/users/{userId}/stats/{statCode}/statitems/value` | PUT | PublicIncUserStatItem | [PublicIncUserStatItem](../../apis/AccelByte.Sdk.Api.Social/Operation/UserStatistic/PublicIncUserStatItem.cs) | [PublicIncUserStatItem](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/UserStatistic/PublicIncUserStatItem.cs) |
| `/social/v1/public/namespaces/{namespace}/users/{userId}/stats/{statCode}/statitems/value` | PATCH | PublicIncUserStatItemValue | [PublicIncUserStatItemValue](../../apis/AccelByte.Sdk.Api.Social/Operation/UserStatistic/PublicIncUserStatItemValue.cs) | [PublicIncUserStatItemValue](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/UserStatistic/PublicIncUserStatItemValue.cs) |
| `/social/v1/public/namespaces/{namespace}/users/{userId}/stats/{statCode}/statitems/value/reset` | PUT | ResetUserStatItemValue1 | [ResetUserStatItemValue1](../../apis/AccelByte.Sdk.Api.Social/Operation/UserStatistic/ResetUserStatItemValue1.cs) | [ResetUserStatItemValue1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/UserStatistic/ResetUserStatItemValue1.cs) |
| `/social/v2/admin/namespaces/{namespace}/statitems/value/bulk` | PUT | BulkUpdateUserStatItemV2 | [BulkUpdateUserStatItemV2](../../apis/AccelByte.Sdk.Api.Social/Operation/UserStatistic/BulkUpdateUserStatItemV2.cs) | [BulkUpdateUserStatItemV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/UserStatistic/BulkUpdateUserStatItemV2.cs) |
| `/social/v2/admin/namespaces/{namespace}/statitems/value/bulk/getOrDefault` | GET | BulkFetchOrDefaultStatItems1 | [BulkFetchOrDefaultStatItems1](../../apis/AccelByte.Sdk.Api.Social/Operation/UserStatistic/BulkFetchOrDefaultStatItems1.cs) | [BulkFetchOrDefaultStatItems1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/UserStatistic/BulkFetchOrDefaultStatItems1.cs) |
| `/social/v2/admin/namespaces/{namespace}/users/{userId}/statitems/value/bulk` | GET | AdminListUsersStatItems | [AdminListUsersStatItems](../../apis/AccelByte.Sdk.Api.Social/Operation/UserStatistic/AdminListUsersStatItems.cs) | [AdminListUsersStatItems](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/UserStatistic/AdminListUsersStatItems.cs) |
| `/social/v2/admin/namespaces/{namespace}/users/{userId}/statitems/value/bulk` | PUT | BulkUpdateUserStatItem | [BulkUpdateUserStatItem](../../apis/AccelByte.Sdk.Api.Social/Operation/UserStatistic/BulkUpdateUserStatItem.cs) | [BulkUpdateUserStatItem](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/UserStatistic/BulkUpdateUserStatItem.cs) |
| `/social/v2/admin/namespaces/{namespace}/users/{userId}/statitems/value/reset/bulk` | PUT | BulkResetUserStatItemValues | [BulkResetUserStatItemValues](../../apis/AccelByte.Sdk.Api.Social/Operation/UserStatistic/BulkResetUserStatItemValues.cs) | [BulkResetUserStatItemValues](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/UserStatistic/BulkResetUserStatItemValues.cs) |
| `/social/v2/admin/namespaces/{namespace}/users/{userId}/stats/{statCode}/statitems` | DELETE | DeleteUserStatItems2 | [DeleteUserStatItems2](../../apis/AccelByte.Sdk.Api.Social/Operation/UserStatistic/DeleteUserStatItems2.cs) | [DeleteUserStatItems2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/UserStatistic/DeleteUserStatItems2.cs) |
| `/social/v2/admin/namespaces/{namespace}/users/{userId}/stats/{statCode}/statitems/value` | PUT | UpdateUserStatItemValue | [UpdateUserStatItemValue](../../apis/AccelByte.Sdk.Api.Social/Operation/UserStatistic/UpdateUserStatItemValue.cs) | [UpdateUserStatItemValue](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/UserStatistic/UpdateUserStatItemValue.cs) |
| `/social/v2/public/namespaces/{namespace}/statitems/value/bulk` | PUT | BulkUpdateUserStatItem1 | [BulkUpdateUserStatItem1](../../apis/AccelByte.Sdk.Api.Social/Operation/UserStatistic/BulkUpdateUserStatItem1.cs) | [BulkUpdateUserStatItem1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/UserStatistic/BulkUpdateUserStatItem1.cs) |
| `/social/v2/public/namespaces/{namespace}/users/{userId}/statitems/value/bulk` | GET | PublicQueryUserStatItems2 | [PublicQueryUserStatItems2](../../apis/AccelByte.Sdk.Api.Social/Operation/UserStatistic/PublicQueryUserStatItems2.cs) | [PublicQueryUserStatItems2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/UserStatistic/PublicQueryUserStatItems2.cs) |
| `/social/v2/public/namespaces/{namespace}/users/{userId}/statitems/value/bulk` | PUT | BulkUpdateUserStatItem2 | [BulkUpdateUserStatItem2](../../apis/AccelByte.Sdk.Api.Social/Operation/UserStatistic/BulkUpdateUserStatItem2.cs) | [BulkUpdateUserStatItem2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/UserStatistic/BulkUpdateUserStatItem2.cs) |
| `/social/v2/public/namespaces/{namespace}/users/{userId}/stats/{statCode}/statitems/value` | PUT | UpdateUserStatItemValue1 | [UpdateUserStatItemValue1](../../apis/AccelByte.Sdk.Api.Social/Operation/UserStatistic/UpdateUserStatItemValue1.cs) | [UpdateUserStatItemValue1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/UserStatistic/UpdateUserStatItemValue1.cs) |

### StatConfiguration Wrapper:  [StatConfiguration](../../apis/AccelByte.Sdk.Api.Social/Wrapper/StatConfiguration.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/social/v1/admin/namespaces/{namespace}/stats` | GET | GetStats | [GetStats](../../apis/AccelByte.Sdk.Api.Social/Operation/StatConfiguration/GetStats.cs) | [GetStats](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/StatConfiguration/GetStats.cs) |
| `/social/v1/admin/namespaces/{namespace}/stats` | POST | CreateStat | [CreateStat](../../apis/AccelByte.Sdk.Api.Social/Operation/StatConfiguration/CreateStat.cs) | [CreateStat](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/StatConfiguration/CreateStat.cs) |
| `/social/v1/admin/namespaces/{namespace}/stats/export` | GET | ExportStats | [ExportStats](../../apis/AccelByte.Sdk.Api.Social/Operation/StatConfiguration/ExportStats.cs) | [ExportStats](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/StatConfiguration/ExportStats.cs) |
| `/social/v1/admin/namespaces/{namespace}/stats/import` | POST | ImportStats | [ImportStats](../../apis/AccelByte.Sdk.Api.Social/Operation/StatConfiguration/ImportStats.cs) | [ImportStats](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/StatConfiguration/ImportStats.cs) |
| `/social/v1/admin/namespaces/{namespace}/stats/search` | GET | QueryStats | [QueryStats](../../apis/AccelByte.Sdk.Api.Social/Operation/StatConfiguration/QueryStats.cs) | [QueryStats](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/StatConfiguration/QueryStats.cs) |
| `/social/v1/admin/namespaces/{namespace}/stats/{statCode}` | GET | GetStat | [GetStat](../../apis/AccelByte.Sdk.Api.Social/Operation/StatConfiguration/GetStat.cs) | [GetStat](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/StatConfiguration/GetStat.cs) |
| `/social/v1/admin/namespaces/{namespace}/stats/{statCode}` | DELETE | DeleteStat | [DeleteStat](../../apis/AccelByte.Sdk.Api.Social/Operation/StatConfiguration/DeleteStat.cs) | [DeleteStat](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/StatConfiguration/DeleteStat.cs) |
| `/social/v1/admin/namespaces/{namespace}/stats/{statCode}` | PATCH | UpdateStat | [UpdateStat](../../apis/AccelByte.Sdk.Api.Social/Operation/StatConfiguration/UpdateStat.cs) | [UpdateStat](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/StatConfiguration/UpdateStat.cs) |
| `/social/v1/admin/namespaces/{namespace}/stats/{statCode}/tied` | DELETE | DeleteTiedStat | [DeleteTiedStat](../../apis/AccelByte.Sdk.Api.Social/Operation/StatConfiguration/DeleteTiedStat.cs) | [DeleteTiedStat](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/StatConfiguration/DeleteTiedStat.cs) |
| `/social/v1/public/namespaces/{namespace}/stats` | POST | CreateStat1 | [CreateStat1](../../apis/AccelByte.Sdk.Api.Social/Operation/StatConfiguration/CreateStat1.cs) | [CreateStat1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/StatConfiguration/CreateStat1.cs) |

### UserStatisticCycle Wrapper:  [UserStatisticCycle](../../apis/AccelByte.Sdk.Api.Social/Wrapper/UserStatisticCycle.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/social/v1/admin/namespaces/{namespace}/users/{userId}/statCycles/{cycleId}/statCycleitems` | GET | GetUserStatCycleItems | [GetUserStatCycleItems](../../apis/AccelByte.Sdk.Api.Social/Operation/UserStatisticCycle/GetUserStatCycleItems.cs) | [GetUserStatCycleItems](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/UserStatisticCycle/GetUserStatCycleItems.cs) |
| `/social/v1/public/namespaces/{namespace}/users/me/statCycles/{cycleId}/statCycleitems` | GET | PublicListMyStatCycleItems | [PublicListMyStatCycleItems](../../apis/AccelByte.Sdk.Api.Social/Operation/UserStatisticCycle/PublicListMyStatCycleItems.cs) | [PublicListMyStatCycleItems](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/UserStatisticCycle/PublicListMyStatCycleItems.cs) |
| `/social/v1/public/namespaces/{namespace}/users/{userId}/statCycles/{cycleId}/statCycleitems` | GET | GetUserStatCycleItems1 | [GetUserStatCycleItems1](../../apis/AccelByte.Sdk.Api.Social/Operation/UserStatisticCycle/GetUserStatCycleItems1.cs) | [GetUserStatCycleItems1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/UserStatisticCycle/GetUserStatCycleItems1.cs) |


&nbsp;

## Operations with Generic Response

### SlotConfig Wrapper:  [SlotConfig](../../apis/AccelByte.Sdk.Api.Social/Wrapper/SlotConfig.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### GameProfile Wrapper:  [GameProfile](../../apis/AccelByte.Sdk.Api.Social/Wrapper/GameProfile.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Slot Wrapper:  [Slot](../../apis/AccelByte.Sdk.Api.Social/Wrapper/Slot.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### GlobalStatistic Wrapper:  [GlobalStatistic](../../apis/AccelByte.Sdk.Api.Social/Wrapper/GlobalStatistic.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### StatCycleConfiguration Wrapper:  [StatCycleConfiguration](../../apis/AccelByte.Sdk.Api.Social/Wrapper/StatCycleConfiguration.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/social/v1/admin/namespaces/{namespace}/statCycles/{cycleId}/stats/add/bulk` | POST | BulkAddStats | [BulkAddStats](../../apis/AccelByte.Sdk.Api.Social/Operation/StatCycleConfiguration/BulkAddStats.cs) | [BulkAddStats](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/StatCycleConfiguration/BulkAddStats.cs) |

### UserStatistic Wrapper:  [UserStatistic](../../apis/AccelByte.Sdk.Api.Social/Wrapper/UserStatistic.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/social/v1/admin/namespaces/{namespace}/statitems/bulk` | GET | BulkFetchStatItems | [BulkFetchStatItems](../../apis/AccelByte.Sdk.Api.Social/Operation/UserStatistic/BulkFetchStatItems.cs) | [BulkFetchStatItems](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/UserStatistic/BulkFetchStatItems.cs) |
| `/social/v1/admin/namespaces/{namespace}/statitems/value/bulk` | PUT | BulkIncUserStatItem | [BulkIncUserStatItem](../../apis/AccelByte.Sdk.Api.Social/Operation/UserStatistic/BulkIncUserStatItem.cs) | [BulkIncUserStatItem](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/UserStatistic/BulkIncUserStatItem.cs) |
| `/social/v1/admin/namespaces/{namespace}/statitems/value/bulk` | PATCH | BulkIncUserStatItemValue | [BulkIncUserStatItemValue](../../apis/AccelByte.Sdk.Api.Social/Operation/UserStatistic/BulkIncUserStatItemValue.cs) | [BulkIncUserStatItemValue](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/UserStatistic/BulkIncUserStatItemValue.cs) |
| `/social/v1/admin/namespaces/{namespace}/statitems/value/reset/bulk` | PUT | BulkResetUserStatItem | [BulkResetUserStatItem](../../apis/AccelByte.Sdk.Api.Social/Operation/UserStatistic/BulkResetUserStatItem.cs) | [BulkResetUserStatItem](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/UserStatistic/BulkResetUserStatItem.cs) |
| `/social/v1/admin/namespaces/{namespace}/users/{userId}/statitems/bulk` | POST | BulkCreateUserStatItems | [BulkCreateUserStatItems](../../apis/AccelByte.Sdk.Api.Social/Operation/UserStatistic/BulkCreateUserStatItems.cs) | [BulkCreateUserStatItems](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/UserStatistic/BulkCreateUserStatItems.cs) |
| `/social/v1/admin/namespaces/{namespace}/users/{userId}/statitems/value/bulk` | PUT | BulkIncUserStatItem1 | [BulkIncUserStatItem1](../../apis/AccelByte.Sdk.Api.Social/Operation/UserStatistic/BulkIncUserStatItem1.cs) | [BulkIncUserStatItem1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/UserStatistic/BulkIncUserStatItem1.cs) |
| `/social/v1/admin/namespaces/{namespace}/users/{userId}/statitems/value/bulk` | PATCH | BulkIncUserStatItemValue1 | [BulkIncUserStatItemValue1](../../apis/AccelByte.Sdk.Api.Social/Operation/UserStatistic/BulkIncUserStatItemValue1.cs) | [BulkIncUserStatItemValue1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/UserStatistic/BulkIncUserStatItemValue1.cs) |
| `/social/v1/admin/namespaces/{namespace}/users/{userId}/statitems/value/reset/bulk` | PUT | BulkResetUserStatItem1 | [BulkResetUserStatItem1](../../apis/AccelByte.Sdk.Api.Social/Operation/UserStatistic/BulkResetUserStatItem1.cs) | [BulkResetUserStatItem1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/UserStatistic/BulkResetUserStatItem1.cs) |
| `/social/v1/public/namespaces/{namespace}/statitems/bulk` | GET | BulkFetchStatItems1 | [BulkFetchStatItems1](../../apis/AccelByte.Sdk.Api.Social/Operation/UserStatistic/BulkFetchStatItems1.cs) | [BulkFetchStatItems1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/UserStatistic/BulkFetchStatItems1.cs) |
| `/social/v1/public/namespaces/{namespace}/statitems/value/bulk` | PUT | PublicBulkIncUserStatItem | [PublicBulkIncUserStatItem](../../apis/AccelByte.Sdk.Api.Social/Operation/UserStatistic/PublicBulkIncUserStatItem.cs) | [PublicBulkIncUserStatItem](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/UserStatistic/PublicBulkIncUserStatItem.cs) |
| `/social/v1/public/namespaces/{namespace}/statitems/value/bulk` | PATCH | PublicBulkIncUserStatItemValue | [PublicBulkIncUserStatItemValue](../../apis/AccelByte.Sdk.Api.Social/Operation/UserStatistic/PublicBulkIncUserStatItemValue.cs) | [PublicBulkIncUserStatItemValue](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/UserStatistic/PublicBulkIncUserStatItemValue.cs) |
| `/social/v1/public/namespaces/{namespace}/statitems/value/reset/bulk` | PUT | BulkResetUserStatItem2 | [BulkResetUserStatItem2](../../apis/AccelByte.Sdk.Api.Social/Operation/UserStatistic/BulkResetUserStatItem2.cs) | [BulkResetUserStatItem2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/UserStatistic/BulkResetUserStatItem2.cs) |
| `/social/v1/public/namespaces/{namespace}/users/{userId}/statitems/bulk` | POST | PublicBulkCreateUserStatItems | [PublicBulkCreateUserStatItems](../../apis/AccelByte.Sdk.Api.Social/Operation/UserStatistic/PublicBulkCreateUserStatItems.cs) | [PublicBulkCreateUserStatItems](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/UserStatistic/PublicBulkCreateUserStatItems.cs) |
| `/social/v1/public/namespaces/{namespace}/users/{userId}/statitems/value/bulk` | PUT | PublicBulkIncUserStatItem1 | [PublicBulkIncUserStatItem1](../../apis/AccelByte.Sdk.Api.Social/Operation/UserStatistic/PublicBulkIncUserStatItem1.cs) | [PublicBulkIncUserStatItem1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/UserStatistic/PublicBulkIncUserStatItem1.cs) |
| `/social/v1/public/namespaces/{namespace}/users/{userId}/statitems/value/bulk` | PATCH | BulkIncUserStatItemValue2 | [BulkIncUserStatItemValue2](../../apis/AccelByte.Sdk.Api.Social/Operation/UserStatistic/BulkIncUserStatItemValue2.cs) | [BulkIncUserStatItemValue2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/UserStatistic/BulkIncUserStatItemValue2.cs) |
| `/social/v1/public/namespaces/{namespace}/users/{userId}/statitems/value/reset/bulk` | PUT | BulkResetUserStatItem3 | [BulkResetUserStatItem3](../../apis/AccelByte.Sdk.Api.Social/Operation/UserStatistic/BulkResetUserStatItem3.cs) | [BulkResetUserStatItem3](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/UserStatistic/BulkResetUserStatItem3.cs) |
| `/social/v2/admin/namespaces/{namespace}/statitems/value/bulk` | PUT | BulkUpdateUserStatItemV2 | [BulkUpdateUserStatItemV2](../../apis/AccelByte.Sdk.Api.Social/Operation/UserStatistic/BulkUpdateUserStatItemV2.cs) | [BulkUpdateUserStatItemV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/UserStatistic/BulkUpdateUserStatItemV2.cs) |
| `/social/v2/admin/namespaces/{namespace}/users/{userId}/statitems/value/bulk` | PUT | BulkUpdateUserStatItem | [BulkUpdateUserStatItem](../../apis/AccelByte.Sdk.Api.Social/Operation/UserStatistic/BulkUpdateUserStatItem.cs) | [BulkUpdateUserStatItem](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/UserStatistic/BulkUpdateUserStatItem.cs) |
| `/social/v2/admin/namespaces/{namespace}/users/{userId}/statitems/value/reset/bulk` | PUT | BulkResetUserStatItemValues | [BulkResetUserStatItemValues](../../apis/AccelByte.Sdk.Api.Social/Operation/UserStatistic/BulkResetUserStatItemValues.cs) | [BulkResetUserStatItemValues](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/UserStatistic/BulkResetUserStatItemValues.cs) |
| `/social/v2/public/namespaces/{namespace}/statitems/value/bulk` | PUT | BulkUpdateUserStatItem1 | [BulkUpdateUserStatItem1](../../apis/AccelByte.Sdk.Api.Social/Operation/UserStatistic/BulkUpdateUserStatItem1.cs) | [BulkUpdateUserStatItem1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/UserStatistic/BulkUpdateUserStatItem1.cs) |
| `/social/v2/public/namespaces/{namespace}/users/{userId}/statitems/value/bulk` | PUT | BulkUpdateUserStatItem2 | [BulkUpdateUserStatItem2](../../apis/AccelByte.Sdk.Api.Social/Operation/UserStatistic/BulkUpdateUserStatItem2.cs) | [BulkUpdateUserStatItem2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Social/UserStatistic/BulkUpdateUserStatItem2.cs) |

### StatConfiguration Wrapper:  [StatConfiguration](../../apis/AccelByte.Sdk.Api.Social/Wrapper/StatConfiguration.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### UserStatisticCycle Wrapper:  [UserStatisticCycle](../../apis/AccelByte.Sdk.Api.Social/Wrapper/UserStatisticCycle.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|


&nbsp;

## Models

| Model | Class |
|---|---|
| `A DTO object for resetting user stat items` | [ADTOObjectForResettingUserStatItems](../../apis/AccelByte.Sdk.Api.Social/Model/ADTOObjectForResettingUserStatItems.cs) |
| `A DTO object for user stat item value` | [ADTOObjectForUserStatItemValue](../../apis/AccelByte.Sdk.Api.Social/Model/ADTOObjectForUserStatItemValue.cs) |
| `Attribute` | [Attribute](../../apis/AccelByte.Sdk.Api.Social/Model/Attribute.cs) |
| `BulkCycleStatsAdd` | [BulkCycleStatsAdd](../../apis/AccelByte.Sdk.Api.Social/Model/BulkCycleStatsAdd.cs) |
| `BulkStatCycleOperationResult` | [BulkStatCycleOperationResult](../../apis/AccelByte.Sdk.Api.Social/Model/BulkStatCycleOperationResult.cs) |
| `BulkStatCycleRequest` | [BulkStatCycleRequest](../../apis/AccelByte.Sdk.Api.Social/Model/BulkStatCycleRequest.cs) |
| `BulkStatCycleResult` | [BulkStatCycleResult](../../apis/AccelByte.Sdk.Api.Social/Model/BulkStatCycleResult.cs) |
| `BulkStatItemCreate` | [BulkStatItemCreate](../../apis/AccelByte.Sdk.Api.Social/Model/BulkStatItemCreate.cs) |
| `BulkStatItemInc` | [BulkStatItemInc](../../apis/AccelByte.Sdk.Api.Social/Model/BulkStatItemInc.cs) |
| `BulkStatItemReset` | [BulkStatItemReset](../../apis/AccelByte.Sdk.Api.Social/Model/BulkStatItemReset.cs) |
| `BulkStatItemUpdate` | [BulkStatItemUpdate](../../apis/AccelByte.Sdk.Api.Social/Model/BulkStatItemUpdate.cs) |
| `BulkStatOperationResult` | [BulkStatOperationResult](../../apis/AccelByte.Sdk.Api.Social/Model/BulkStatOperationResult.cs) |
| `BulkUserStatItemInc` | [BulkUserStatItemInc](../../apis/AccelByte.Sdk.Api.Social/Model/BulkUserStatItemInc.cs) |
| `BulkUserStatItemReset` | [BulkUserStatItemReset](../../apis/AccelByte.Sdk.Api.Social/Model/BulkUserStatItemReset.cs) |
| `BulkUserStatItemUpdate` | [BulkUserStatItemUpdate](../../apis/AccelByte.Sdk.Api.Social/Model/BulkUserStatItemUpdate.cs) |
| `ErrorEntity` | [ErrorEntity](../../apis/AccelByte.Sdk.Api.Social/Model/ErrorEntity.cs) |
| `FieldValidationError` | [FieldValidationError](../../apis/AccelByte.Sdk.Api.Social/Model/FieldValidationError.cs) |
| `GameProfileHeader` | [GameProfileHeader](../../apis/AccelByte.Sdk.Api.Social/Model/GameProfileHeader.cs) |
| `GameProfileInfo` | [GameProfileInfo](../../apis/AccelByte.Sdk.Api.Social/Model/GameProfileInfo.cs) |
| `GameProfilePublicInfo` | [GameProfilePublicInfo](../../apis/AccelByte.Sdk.Api.Social/Model/GameProfilePublicInfo.cs) |
| `GameProfileRequest` | [GameProfileRequest](../../apis/AccelByte.Sdk.Api.Social/Model/GameProfileRequest.cs) |
| `GlobalStatItemInfo` | [GlobalStatItemInfo](../../apis/AccelByte.Sdk.Api.Social/Model/GlobalStatItemInfo.cs) |
| `GlobalStatItemPagingSlicedResult` | [GlobalStatItemPagingSlicedResult](../../apis/AccelByte.Sdk.Api.Social/Model/GlobalStatItemPagingSlicedResult.cs) |
| `NamespaceSlotConfigInfo` | [NamespaceSlotConfigInfo](../../apis/AccelByte.Sdk.Api.Social/Model/NamespaceSlotConfigInfo.cs) |
| `Paging` | [Paging](../../apis/AccelByte.Sdk.Api.Social/Model/Paging.cs) |
| `SlotConfigUpdate` | [SlotConfigUpdate](../../apis/AccelByte.Sdk.Api.Social/Model/SlotConfigUpdate.cs) |
| `SlotInfo` | [SlotInfo](../../apis/AccelByte.Sdk.Api.Social/Model/SlotInfo.cs) |
| `SlotMetadataUpdate` | [SlotMetadataUpdate](../../apis/AccelByte.Sdk.Api.Social/Model/SlotMetadataUpdate.cs) |
| `StatCreate` | [StatCreate](../../apis/AccelByte.Sdk.Api.Social/Model/StatCreate.cs) |
| `StatCycleCreate` | [StatCycleCreate](../../apis/AccelByte.Sdk.Api.Social/Model/StatCycleCreate.cs) |
| `StatCycleInfo` | [StatCycleInfo](../../apis/AccelByte.Sdk.Api.Social/Model/StatCycleInfo.cs) |
| `StatCyclePagingSlicedResult` | [StatCyclePagingSlicedResult](../../apis/AccelByte.Sdk.Api.Social/Model/StatCyclePagingSlicedResult.cs) |
| `StatCycleUpdate` | [StatCycleUpdate](../../apis/AccelByte.Sdk.Api.Social/Model/StatCycleUpdate.cs) |
| `StatImportInfo` | [StatImportInfo](../../apis/AccelByte.Sdk.Api.Social/Model/StatImportInfo.cs) |
| `StatInfo` | [StatInfo](../../apis/AccelByte.Sdk.Api.Social/Model/StatInfo.cs) |
| `StatItemInc` | [StatItemInc](../../apis/AccelByte.Sdk.Api.Social/Model/StatItemInc.cs) |
| `StatItemIncResult` | [StatItemIncResult](../../apis/AccelByte.Sdk.Api.Social/Model/StatItemIncResult.cs) |
| `StatItemUpdate` | [StatItemUpdate](../../apis/AccelByte.Sdk.Api.Social/Model/StatItemUpdate.cs) |
| `StatPagingSlicedResult` | [StatPagingSlicedResult](../../apis/AccelByte.Sdk.Api.Social/Model/StatPagingSlicedResult.cs) |
| `StatResetInfo` | [StatResetInfo](../../apis/AccelByte.Sdk.Api.Social/Model/StatResetInfo.cs) |
| `StatUpdate` | [StatUpdate](../../apis/AccelByte.Sdk.Api.Social/Model/StatUpdate.cs) |
| `UserGameProfiles` | [UserGameProfiles](../../apis/AccelByte.Sdk.Api.Social/Model/UserGameProfiles.cs) |
| `UserSlotConfigInfo` | [UserSlotConfigInfo](../../apis/AccelByte.Sdk.Api.Social/Model/UserSlotConfigInfo.cs) |
| `UserStatCycleItemInfo` | [UserStatCycleItemInfo](../../apis/AccelByte.Sdk.Api.Social/Model/UserStatCycleItemInfo.cs) |
| `UserStatCycleItemPagingSlicedResult` | [UserStatCycleItemPagingSlicedResult](../../apis/AccelByte.Sdk.Api.Social/Model/UserStatCycleItemPagingSlicedResult.cs) |
| `UserStatItemInfo` | [UserStatItemInfo](../../apis/AccelByte.Sdk.Api.Social/Model/UserStatItemInfo.cs) |
| `UserStatItemPagingSlicedResult` | [UserStatItemPagingSlicedResult](../../apis/AccelByte.Sdk.Api.Social/Model/UserStatItemPagingSlicedResult.cs) |
| `ValidationErrorEntity` | [ValidationErrorEntity](../../apis/AccelByte.Sdk.Api.Social/Model/ValidationErrorEntity.cs) |