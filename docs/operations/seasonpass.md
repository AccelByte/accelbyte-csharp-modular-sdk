[//]: # (This code is generated by tool. DO NOT EDIT.)

# Seasonpass Service Index

&nbsp;

## Operations

### Export Wrapper:  [Export](../../apis/AccelByte.Sdk.Api.Seasonpass/Wrapper/Export.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/seasonpass/admin/namespace/{namespace}/export` | GET | ExportSeason | [ExportSeason](../../apis/AccelByte.Sdk.Api.Seasonpass/Operation/Export/ExportSeason.cs) | [ExportSeason](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Export/ExportSeason.cs) |

### Season Wrapper:  [Season](../../apis/AccelByte.Sdk.Api.Seasonpass/Wrapper/Season.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/seasonpass/admin/namespaces/{namespace}/seasons` | GET | QuerySeasons | [QuerySeasons](../../apis/AccelByte.Sdk.Api.Seasonpass/Operation/Season/QuerySeasons.cs) | [QuerySeasons](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Season/QuerySeasons.cs) |
| `/seasonpass/admin/namespaces/{namespace}/seasons` | POST | CreateSeason | [CreateSeason](../../apis/AccelByte.Sdk.Api.Seasonpass/Operation/Season/CreateSeason.cs) | [CreateSeason](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Season/CreateSeason.cs) |
| `/seasonpass/admin/namespaces/{namespace}/seasons/current` | GET | GetCurrentSeason | [GetCurrentSeason](../../apis/AccelByte.Sdk.Api.Seasonpass/Operation/Season/GetCurrentSeason.cs) | [GetCurrentSeason](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Season/GetCurrentSeason.cs) |
| `/seasonpass/admin/namespaces/{namespace}/seasons/current/users/bulk/progression` | POST | BulkGetUserSeasonProgression | [BulkGetUserSeasonProgression](../../apis/AccelByte.Sdk.Api.Seasonpass/Operation/Season/BulkGetUserSeasonProgression.cs) | [BulkGetUserSeasonProgression](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Season/BulkGetUserSeasonProgression.cs) |
| `/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}` | GET | GetSeason | [GetSeason](../../apis/AccelByte.Sdk.Api.Seasonpass/Operation/Season/GetSeason.cs) | [GetSeason](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Season/GetSeason.cs) |
| `/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}` | DELETE | DeleteSeason | [DeleteSeason](../../apis/AccelByte.Sdk.Api.Seasonpass/Operation/Season/DeleteSeason.cs) | [DeleteSeason](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Season/DeleteSeason.cs) |
| `/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}` | PATCH | UpdateSeason | [UpdateSeason](../../apis/AccelByte.Sdk.Api.Seasonpass/Operation/Season/UpdateSeason.cs) | [UpdateSeason](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Season/UpdateSeason.cs) |
| `/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/clone` | POST | CloneSeason | [CloneSeason](../../apis/AccelByte.Sdk.Api.Seasonpass/Operation/Season/CloneSeason.cs) | [CloneSeason](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Season/CloneSeason.cs) |
| `/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/full` | GET | GetFullSeason | [GetFullSeason](../../apis/AccelByte.Sdk.Api.Seasonpass/Operation/Season/GetFullSeason.cs) | [GetFullSeason](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Season/GetFullSeason.cs) |
| `/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/publish` | PUT | PublishSeason | [PublishSeason](../../apis/AccelByte.Sdk.Api.Seasonpass/Operation/Season/PublishSeason.cs) | [PublishSeason](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Season/PublishSeason.cs) |
| `/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/retire` | PUT | RetireSeason | [RetireSeason](../../apis/AccelByte.Sdk.Api.Seasonpass/Operation/Season/RetireSeason.cs) | [RetireSeason](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Season/RetireSeason.cs) |
| `/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/unpublish` | PUT | UnpublishSeason | [UnpublishSeason](../../apis/AccelByte.Sdk.Api.Seasonpass/Operation/Season/UnpublishSeason.cs) | [UnpublishSeason](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Season/UnpublishSeason.cs) |
| `/seasonpass/admin/namespaces/{namespace}/users/{userId}/seasons` | GET | GetUserParticipatedSeasons | [GetUserParticipatedSeasons](../../apis/AccelByte.Sdk.Api.Seasonpass/Operation/Season/GetUserParticipatedSeasons.cs) | [GetUserParticipatedSeasons](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Season/GetUserParticipatedSeasons.cs) |
| `/seasonpass/admin/namespaces/{namespace}/users/{userId}/seasons/current/passes/ownership/any` | GET | ExistsAnyPassByPassCodes | [ExistsAnyPassByPassCodes](../../apis/AccelByte.Sdk.Api.Seasonpass/Operation/Season/ExistsAnyPassByPassCodes.cs) | [ExistsAnyPassByPassCodes](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Season/ExistsAnyPassByPassCodes.cs) |
| `/seasonpass/admin/namespaces/{namespace}/users/{userId}/seasons/current/progression` | GET | GetCurrentUserSeasonProgression | [GetCurrentUserSeasonProgression](../../apis/AccelByte.Sdk.Api.Seasonpass/Operation/Season/GetCurrentUserSeasonProgression.cs) | [GetCurrentUserSeasonProgression](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Season/GetCurrentUserSeasonProgression.cs) |
| `/seasonpass/admin/namespaces/{namespace}/users/{userId}/seasons/current/purchasable` | POST | CheckSeasonPurchasable | [CheckSeasonPurchasable](../../apis/AccelByte.Sdk.Api.Seasonpass/Operation/Season/CheckSeasonPurchasable.cs) | [CheckSeasonPurchasable](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Season/CheckSeasonPurchasable.cs) |
| `/seasonpass/admin/namespaces/{namespace}/users/{userId}/seasons/current/reset` | DELETE | ResetUserSeason | [ResetUserSeason](../../apis/AccelByte.Sdk.Api.Seasonpass/Operation/Season/ResetUserSeason.cs) | [ResetUserSeason](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Season/ResetUserSeason.cs) |
| `/seasonpass/admin/namespaces/{namespace}/users/{userId}/seasons/exp/history` | GET | QueryUserExpGrantHistory | [QueryUserExpGrantHistory](../../apis/AccelByte.Sdk.Api.Seasonpass/Operation/Season/QueryUserExpGrantHistory.cs) | [QueryUserExpGrantHistory](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Season/QueryUserExpGrantHistory.cs) |
| `/seasonpass/admin/namespaces/{namespace}/users/{userId}/seasons/exp/history/tags` | GET | QueryUserExpGrantHistoryTag | [QueryUserExpGrantHistoryTag](../../apis/AccelByte.Sdk.Api.Seasonpass/Operation/Season/QueryUserExpGrantHistoryTag.cs) | [QueryUserExpGrantHistoryTag](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Season/QueryUserExpGrantHistoryTag.cs) |
| `/seasonpass/admin/namespaces/{namespace}/users/{userId}/seasons/{seasonId}/data` | GET | GetUserSeason | [GetUserSeason](../../apis/AccelByte.Sdk.Api.Seasonpass/Operation/Season/GetUserSeason.cs) | [GetUserSeason](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Season/GetUserSeason.cs) |
| `/seasonpass/public/namespaces/{namespace}/seasons/current` | GET | PublicGetCurrentSeason | [PublicGetCurrentSeason](../../apis/AccelByte.Sdk.Api.Seasonpass/Operation/Season/PublicGetCurrentSeason.cs) | [PublicGetCurrentSeason](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Season/PublicGetCurrentSeason.cs) |
| `/seasonpass/public/namespaces/{namespace}/users/{userId}/seasons/current/data` | GET | PublicGetCurrentUserSeason | [PublicGetCurrentUserSeason](../../apis/AccelByte.Sdk.Api.Seasonpass/Operation/Season/PublicGetCurrentUserSeason.cs) | [PublicGetCurrentUserSeason](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Season/PublicGetCurrentUserSeason.cs) |
| `/seasonpass/public/namespaces/{namespace}/users/{userId}/seasons/{seasonId}/data` | GET | PublicGetUserSeason | [PublicGetUserSeason](../../apis/AccelByte.Sdk.Api.Seasonpass/Operation/Season/PublicGetUserSeason.cs) | [PublicGetUserSeason](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Season/PublicGetUserSeason.cs) |

### Utilities Wrapper:  [Utilities](../../apis/AccelByte.Sdk.Api.Seasonpass/Wrapper/Utilities.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/seasonpass/admin/namespaces/{namespace}/seasons/item/references` | GET | GetItemReferences | [GetItemReferences](../../apis/AccelByte.Sdk.Api.Seasonpass/Operation/Utilities/GetItemReferences.cs) | [GetItemReferences](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Utilities/GetItemReferences.cs) |

### Pass Wrapper:  [Pass](../../apis/AccelByte.Sdk.Api.Seasonpass/Wrapper/Pass.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/passes` | GET | QueryPasses | [QueryPasses](../../apis/AccelByte.Sdk.Api.Seasonpass/Operation/Pass/QueryPasses.cs) | [QueryPasses](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Pass/QueryPasses.cs) |
| `/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/passes` | POST | CreatePass | [CreatePass](../../apis/AccelByte.Sdk.Api.Seasonpass/Operation/Pass/CreatePass.cs) | [CreatePass](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Pass/CreatePass.cs) |
| `/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/passes/{code}` | GET | GetPass | [GetPass](../../apis/AccelByte.Sdk.Api.Seasonpass/Operation/Pass/GetPass.cs) | [GetPass](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Pass/GetPass.cs) |
| `/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/passes/{code}` | DELETE | DeletePass | [DeletePass](../../apis/AccelByte.Sdk.Api.Seasonpass/Operation/Pass/DeletePass.cs) | [DeletePass](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Pass/DeletePass.cs) |
| `/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/passes/{code}` | PATCH | UpdatePass | [UpdatePass](../../apis/AccelByte.Sdk.Api.Seasonpass/Operation/Pass/UpdatePass.cs) | [UpdatePass](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Pass/UpdatePass.cs) |
| `/seasonpass/admin/namespaces/{namespace}/users/{userId}/seasons/current/passes` | POST | GrantUserPass | [GrantUserPass](../../apis/AccelByte.Sdk.Api.Seasonpass/Operation/Pass/GrantUserPass.cs) | [GrantUserPass](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Pass/GrantUserPass.cs) |

### Reward Wrapper:  [Reward](../../apis/AccelByte.Sdk.Api.Seasonpass/Wrapper/Reward.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/rewards` | GET | QueryRewards | [QueryRewards](../../apis/AccelByte.Sdk.Api.Seasonpass/Operation/Reward/QueryRewards.cs) | [QueryRewards](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Reward/QueryRewards.cs) |
| `/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/rewards` | POST | CreateReward | [CreateReward](../../apis/AccelByte.Sdk.Api.Seasonpass/Operation/Reward/CreateReward.cs) | [CreateReward](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Reward/CreateReward.cs) |
| `/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/rewards/{code}` | GET | GetReward | [GetReward](../../apis/AccelByte.Sdk.Api.Seasonpass/Operation/Reward/GetReward.cs) | [GetReward](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Reward/GetReward.cs) |
| `/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/rewards/{code}` | DELETE | DeleteReward | [DeleteReward](../../apis/AccelByte.Sdk.Api.Seasonpass/Operation/Reward/DeleteReward.cs) | [DeleteReward](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Reward/DeleteReward.cs) |
| `/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/rewards/{code}` | PATCH | UpdateReward | [UpdateReward](../../apis/AccelByte.Sdk.Api.Seasonpass/Operation/Reward/UpdateReward.cs) | [UpdateReward](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Reward/UpdateReward.cs) |
| `/seasonpass/public/namespaces/{namespace}/users/{userId}/seasons/current/rewards` | POST | PublicClaimUserReward | [PublicClaimUserReward](../../apis/AccelByte.Sdk.Api.Seasonpass/Operation/Reward/PublicClaimUserReward.cs) | [PublicClaimUserReward](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Reward/PublicClaimUserReward.cs) |
| `/seasonpass/public/namespaces/{namespace}/users/{userId}/seasons/current/rewards/bulk` | POST | PublicBulkClaimUserRewards | [PublicBulkClaimUserRewards](../../apis/AccelByte.Sdk.Api.Seasonpass/Operation/Reward/PublicBulkClaimUserRewards.cs) | [PublicBulkClaimUserRewards](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Reward/PublicBulkClaimUserRewards.cs) |

### Tier Wrapper:  [Tier](../../apis/AccelByte.Sdk.Api.Seasonpass/Wrapper/Tier.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/tiers` | GET | QueryTiers | [QueryTiers](../../apis/AccelByte.Sdk.Api.Seasonpass/Operation/Tier/QueryTiers.cs) | [QueryTiers](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Tier/QueryTiers.cs) |
| `/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/tiers` | POST | CreateTier | [CreateTier](../../apis/AccelByte.Sdk.Api.Seasonpass/Operation/Tier/CreateTier.cs) | [CreateTier](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Tier/CreateTier.cs) |
| `/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/tiers/{id}` | PUT | UpdateTier | [UpdateTier](../../apis/AccelByte.Sdk.Api.Seasonpass/Operation/Tier/UpdateTier.cs) | [UpdateTier](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Tier/UpdateTier.cs) |
| `/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/tiers/{id}` | DELETE | DeleteTier | [DeleteTier](../../apis/AccelByte.Sdk.Api.Seasonpass/Operation/Tier/DeleteTier.cs) | [DeleteTier](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Tier/DeleteTier.cs) |
| `/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/tiers/{id}/reorder` | PUT | ReorderTier | [ReorderTier](../../apis/AccelByte.Sdk.Api.Seasonpass/Operation/Tier/ReorderTier.cs) | [ReorderTier](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Tier/ReorderTier.cs) |
| `/seasonpass/admin/namespaces/{namespace}/users/{userId}/seasons/current/exp` | POST | GrantUserExp | [GrantUserExp](../../apis/AccelByte.Sdk.Api.Seasonpass/Operation/Tier/GrantUserExp.cs) | [GrantUserExp](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Tier/GrantUserExp.cs) |
| `/seasonpass/admin/namespaces/{namespace}/users/{userId}/seasons/current/tiers` | POST | GrantUserTier | [GrantUserTier](../../apis/AccelByte.Sdk.Api.Seasonpass/Operation/Tier/GrantUserTier.cs) | [GrantUserTier](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Tier/GrantUserTier.cs) |


&nbsp;

## Operations with Generic Response

### Export Wrapper:  [Export](../../apis/AccelByte.Sdk.Api.Seasonpass/Wrapper/Export.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Season Wrapper:  [Season](../../apis/AccelByte.Sdk.Api.Seasonpass/Wrapper/Season.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/seasonpass/admin/namespaces/{namespace}/users/{userId}/seasons/{seasonId}/data` | GET | GetUserSeason | [GetUserSeason](../../apis/AccelByte.Sdk.Api.Seasonpass/Operation/Season/GetUserSeason.cs) | [GetUserSeason](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Season/GetUserSeason.cs) |
| `/seasonpass/public/namespaces/{namespace}/users/{userId}/seasons/current/data` | GET | PublicGetCurrentUserSeason | [PublicGetCurrentUserSeason](../../apis/AccelByte.Sdk.Api.Seasonpass/Operation/Season/PublicGetCurrentUserSeason.cs) | [PublicGetCurrentUserSeason](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Season/PublicGetCurrentUserSeason.cs) |
| `/seasonpass/public/namespaces/{namespace}/users/{userId}/seasons/{seasonId}/data` | GET | PublicGetUserSeason | [PublicGetUserSeason](../../apis/AccelByte.Sdk.Api.Seasonpass/Operation/Season/PublicGetUserSeason.cs) | [PublicGetUserSeason](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Season/PublicGetUserSeason.cs) |

### Utilities Wrapper:  [Utilities](../../apis/AccelByte.Sdk.Api.Seasonpass/Wrapper/Utilities.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Pass Wrapper:  [Pass](../../apis/AccelByte.Sdk.Api.Seasonpass/Wrapper/Pass.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Reward Wrapper:  [Reward](../../apis/AccelByte.Sdk.Api.Seasonpass/Wrapper/Reward.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/seasonpass/public/namespaces/{namespace}/users/{userId}/seasons/current/rewards` | POST | PublicClaimUserReward | [PublicClaimUserReward](../../apis/AccelByte.Sdk.Api.Seasonpass/Operation/Reward/PublicClaimUserReward.cs) | [PublicClaimUserReward](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Reward/PublicClaimUserReward.cs) |
| `/seasonpass/public/namespaces/{namespace}/users/{userId}/seasons/current/rewards/bulk` | POST | PublicBulkClaimUserRewards | [PublicBulkClaimUserRewards](../../apis/AccelByte.Sdk.Api.Seasonpass/Operation/Reward/PublicBulkClaimUserRewards.cs) | [PublicBulkClaimUserRewards](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Reward/PublicBulkClaimUserRewards.cs) |

### Tier Wrapper:  [Tier](../../apis/AccelByte.Sdk.Api.Seasonpass/Wrapper/Tier.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|


&nbsp;

## Models

| Model | Class |
|---|---|
| `BulkUserProgressionRequest` | [BulkUserProgressionRequest](../../apis/AccelByte.Sdk.Api.Seasonpass/Model/BulkUserProgressionRequest.cs) |
| `ClaimableRewards` | [ClaimableRewards](../../apis/AccelByte.Sdk.Api.Seasonpass/Model/ClaimableRewards.cs) |
| `ClaimableUserSeasonInfo` | [ClaimableUserSeasonInfo](../../apis/AccelByte.Sdk.Api.Seasonpass/Model/ClaimableUserSeasonInfo.cs) |
| `ErrorEntity` | [ErrorEntity](../../apis/AccelByte.Sdk.Api.Seasonpass/Model/ErrorEntity.cs) |
| `ExcessStrategy` | [ExcessStrategy](../../apis/AccelByte.Sdk.Api.Seasonpass/Model/ExcessStrategy.cs) |
| `ExpGrantHistoryInfo` | [ExpGrantHistoryInfo](../../apis/AccelByte.Sdk.Api.Seasonpass/Model/ExpGrantHistoryInfo.cs) |
| `ExpGrantHistoryPagingSlicedResult` | [ExpGrantHistoryPagingSlicedResult](../../apis/AccelByte.Sdk.Api.Seasonpass/Model/ExpGrantHistoryPagingSlicedResult.cs) |
| `FieldValidationError` | [FieldValidationError](../../apis/AccelByte.Sdk.Api.Seasonpass/Model/FieldValidationError.cs) |
| `FullSeasonInfo` | [FullSeasonInfo](../../apis/AccelByte.Sdk.Api.Seasonpass/Model/FullSeasonInfo.cs) |
| `Image` | [Image](../../apis/AccelByte.Sdk.Api.Seasonpass/Model/Image.cs) |
| `ItemReference` | [ItemReference](../../apis/AccelByte.Sdk.Api.Seasonpass/Model/ItemReference.cs) |
| `ItemReferenceInfo` | [ItemReferenceInfo](../../apis/AccelByte.Sdk.Api.Seasonpass/Model/ItemReferenceInfo.cs) |
| `ListSeasonInfo` | [ListSeasonInfo](../../apis/AccelByte.Sdk.Api.Seasonpass/Model/ListSeasonInfo.cs) |
| `ListSeasonInfoPagingSlicedResult` | [ListSeasonInfoPagingSlicedResult](../../apis/AccelByte.Sdk.Api.Seasonpass/Model/ListSeasonInfoPagingSlicedResult.cs) |
| `ListUserSeasonInfo` | [ListUserSeasonInfo](../../apis/AccelByte.Sdk.Api.Seasonpass/Model/ListUserSeasonInfo.cs) |
| `ListUserSeasonInfoPagingSlicedResult` | [ListUserSeasonInfoPagingSlicedResult](../../apis/AccelByte.Sdk.Api.Seasonpass/Model/ListUserSeasonInfoPagingSlicedResult.cs) |
| `Localization` | [Localization](../../apis/AccelByte.Sdk.Api.Seasonpass/Model/Localization.cs) |
| `LocalizedPassInfo` | [LocalizedPassInfo](../../apis/AccelByte.Sdk.Api.Seasonpass/Model/LocalizedPassInfo.cs) |
| `LocalizedSeasonInfo` | [LocalizedSeasonInfo](../../apis/AccelByte.Sdk.Api.Seasonpass/Model/LocalizedSeasonInfo.cs) |
| `Ownership` | [Ownership](../../apis/AccelByte.Sdk.Api.Seasonpass/Model/Ownership.cs) |
| `Paging` | [Paging](../../apis/AccelByte.Sdk.Api.Seasonpass/Model/Paging.cs) |
| `PassCreate` | [PassCreate](../../apis/AccelByte.Sdk.Api.Seasonpass/Model/PassCreate.cs) |
| `PassInfo` | [PassInfo](../../apis/AccelByte.Sdk.Api.Seasonpass/Model/PassInfo.cs) |
| `PassUpdate` | [PassUpdate](../../apis/AccelByte.Sdk.Api.Seasonpass/Model/PassUpdate.cs) |
| `Permission` | [Permission](../../apis/AccelByte.Sdk.Api.Seasonpass/Model/Permission.cs) |
| `ReasonTagsResult` | [ReasonTagsResult](../../apis/AccelByte.Sdk.Api.Seasonpass/Model/ReasonTagsResult.cs) |
| `RewardCreate` | [RewardCreate](../../apis/AccelByte.Sdk.Api.Seasonpass/Model/RewardCreate.cs) |
| `RewardCurrency` | [RewardCurrency](../../apis/AccelByte.Sdk.Api.Seasonpass/Model/RewardCurrency.cs) |
| `RewardInfo` | [RewardInfo](../../apis/AccelByte.Sdk.Api.Seasonpass/Model/RewardInfo.cs) |
| `RewardUpdate` | [RewardUpdate](../../apis/AccelByte.Sdk.Api.Seasonpass/Model/RewardUpdate.cs) |
| `SeasonCloneRequest` | [SeasonCloneRequest](../../apis/AccelByte.Sdk.Api.Seasonpass/Model/SeasonCloneRequest.cs) |
| `SeasonCreate` | [SeasonCreate](../../apis/AccelByte.Sdk.Api.Seasonpass/Model/SeasonCreate.cs) |
| `SeasonInfo` | [SeasonInfo](../../apis/AccelByte.Sdk.Api.Seasonpass/Model/SeasonInfo.cs) |
| `SeasonSummary` | [SeasonSummary](../../apis/AccelByte.Sdk.Api.Seasonpass/Model/SeasonSummary.cs) |
| `SeasonUpdate` | [SeasonUpdate](../../apis/AccelByte.Sdk.Api.Seasonpass/Model/SeasonUpdate.cs) |
| `Tier` | [Tier](../../apis/AccelByte.Sdk.Api.Seasonpass/Model/Tier.cs) |
| `TierCreate` | [TierCreate](../../apis/AccelByte.Sdk.Api.Seasonpass/Model/TierCreate.cs) |
| `TierInput` | [TierInput](../../apis/AccelByte.Sdk.Api.Seasonpass/Model/TierInput.cs) |
| `TierPagingSlicedResult` | [TierPagingSlicedResult](../../apis/AccelByte.Sdk.Api.Seasonpass/Model/TierPagingSlicedResult.cs) |
| `TierReorder` | [TierReorder](../../apis/AccelByte.Sdk.Api.Seasonpass/Model/TierReorder.cs) |
| `UserExpGrant` | [UserExpGrant](../../apis/AccelByte.Sdk.Api.Seasonpass/Model/UserExpGrant.cs) |
| `UserPassGrant` | [UserPassGrant](../../apis/AccelByte.Sdk.Api.Seasonpass/Model/UserPassGrant.cs) |
| `UserPurchasable` | [UserPurchasable](../../apis/AccelByte.Sdk.Api.Seasonpass/Model/UserPurchasable.cs) |
| `UserRewardClaim` | [UserRewardClaim](../../apis/AccelByte.Sdk.Api.Seasonpass/Model/UserRewardClaim.cs) |
| `UserSeasonSummary` | [UserSeasonSummary](../../apis/AccelByte.Sdk.Api.Seasonpass/Model/UserSeasonSummary.cs) |
| `UserTierGrant` | [UserTierGrant](../../apis/AccelByte.Sdk.Api.Seasonpass/Model/UserTierGrant.cs) |
| `ValidationErrorEntity` | [ValidationErrorEntity](../../apis/AccelByte.Sdk.Api.Seasonpass/Model/ValidationErrorEntity.cs) |
