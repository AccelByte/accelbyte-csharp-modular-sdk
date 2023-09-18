# Achievement Service Index

&nbsp;

## Operations

### Achievements Wrapper:  [Achievements](../../apis/AccelByte.Sdk.Api.Achievement/Wrapper/Achievements.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/achievement/v1/admin/namespaces/{namespace}/achievements` | GET | AdminListAchievements | [AdminListAchievements](../../apis/AccelByte.Sdk.Api.Achievement/Operation/Achievements/AdminListAchievements.cs) | [AdminListAchievements](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Achievement/Achievements/AdminListAchievements.cs) |
| `/achievement/v1/admin/namespaces/{namespace}/achievements` | POST | AdminCreateNewAchievement | [AdminCreateNewAchievement](../../apis/AccelByte.Sdk.Api.Achievement/Operation/Achievements/AdminCreateNewAchievement.cs) | [AdminCreateNewAchievement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Achievement/Achievements/AdminCreateNewAchievement.cs) |
| `/achievement/v1/admin/namespaces/{namespace}/achievements/export` | GET | ExportAchievements | [ExportAchievements](../../apis/AccelByte.Sdk.Api.Achievement/Operation/Achievements/ExportAchievements.cs) | [ExportAchievements](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Achievement/Achievements/ExportAchievements.cs) |
| `/achievement/v1/admin/namespaces/{namespace}/achievements/import` | POST | ImportAchievements | [ImportAchievements](../../apis/AccelByte.Sdk.Api.Achievement/Operation/Achievements/ImportAchievements.cs) | [ImportAchievements](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Achievement/Achievements/ImportAchievements.cs) |
| `/achievement/v1/admin/namespaces/{namespace}/achievements/{achievementCode}` | GET | AdminGetAchievement | [AdminGetAchievement](../../apis/AccelByte.Sdk.Api.Achievement/Operation/Achievements/AdminGetAchievement.cs) | [AdminGetAchievement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Achievement/Achievements/AdminGetAchievement.cs) |
| `/achievement/v1/admin/namespaces/{namespace}/achievements/{achievementCode}` | PUT | AdminUpdateAchievement | [AdminUpdateAchievement](../../apis/AccelByte.Sdk.Api.Achievement/Operation/Achievements/AdminUpdateAchievement.cs) | [AdminUpdateAchievement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Achievement/Achievements/AdminUpdateAchievement.cs) |
| `/achievement/v1/admin/namespaces/{namespace}/achievements/{achievementCode}` | DELETE | AdminDeleteAchievement | [AdminDeleteAchievement](../../apis/AccelByte.Sdk.Api.Achievement/Operation/Achievements/AdminDeleteAchievement.cs) | [AdminDeleteAchievement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Achievement/Achievements/AdminDeleteAchievement.cs) |
| `/achievement/v1/admin/namespaces/{namespace}/achievements/{achievementCode}` | PATCH | AdminUpdateAchievementListOrder | [AdminUpdateAchievementListOrder](../../apis/AccelByte.Sdk.Api.Achievement/Operation/Achievements/AdminUpdateAchievementListOrder.cs) | [AdminUpdateAchievementListOrder](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Achievement/Achievements/AdminUpdateAchievementListOrder.cs) |
| `/achievement/v1/public/namespaces/{namespace}/achievements` | GET | PublicListAchievements | [PublicListAchievements](../../apis/AccelByte.Sdk.Api.Achievement/Operation/Achievements/PublicListAchievements.cs) | [PublicListAchievements](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Achievement/Achievements/PublicListAchievements.cs) |
| `/achievement/v1/public/namespaces/{namespace}/achievements/{achievementCode}` | GET | PublicGetAchievement | [PublicGetAchievement](../../apis/AccelByte.Sdk.Api.Achievement/Operation/Achievements/PublicGetAchievement.cs) | [PublicGetAchievement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Achievement/Achievements/PublicGetAchievement.cs) |

### Global Achievements Wrapper:  [GlobalAchievements](../../apis/AccelByte.Sdk.Api.Achievement/Wrapper/GlobalAchievements.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/achievement/v1/admin/namespaces/{namespace}/global/achievements` | GET | AdminListGlobalAchievements | [AdminListGlobalAchievements](../../apis/AccelByte.Sdk.Api.Achievement/Operation/GlobalAchievements/AdminListGlobalAchievements.cs) | [AdminListGlobalAchievements](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Achievement/GlobalAchievements/AdminListGlobalAchievements.cs) |
| `/achievement/v1/admin/namespaces/{namespace}/global/achievements/{achievementCode}/contributors` | GET | AdminListGlobalAchievementContributors | [AdminListGlobalAchievementContributors](../../apis/AccelByte.Sdk.Api.Achievement/Operation/GlobalAchievements/AdminListGlobalAchievementContributors.cs) | [AdminListGlobalAchievementContributors](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Achievement/GlobalAchievements/AdminListGlobalAchievementContributors.cs) |
| `/achievement/v1/admin/namespaces/{namespace}/global/achievements/{achievementCode}/reset` | DELETE | ResetGlobalAchievement | [ResetGlobalAchievement](../../apis/AccelByte.Sdk.Api.Achievement/Operation/GlobalAchievements/ResetGlobalAchievement.cs) | [ResetGlobalAchievement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Achievement/GlobalAchievements/ResetGlobalAchievement.cs) |
| `/achievement/v1/admin/namespaces/{namespace}/users/{userId}/global/achievements` | GET | AdminListUserContributions | [AdminListUserContributions](../../apis/AccelByte.Sdk.Api.Achievement/Operation/GlobalAchievements/AdminListUserContributions.cs) | [AdminListUserContributions](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Achievement/GlobalAchievements/AdminListUserContributions.cs) |
| `/achievement/v1/public/namespaces/{namespace}/global/achievements` | GET | PublicListGlobalAchievements | [PublicListGlobalAchievements](../../apis/AccelByte.Sdk.Api.Achievement/Operation/GlobalAchievements/PublicListGlobalAchievements.cs) | [PublicListGlobalAchievements](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Achievement/GlobalAchievements/PublicListGlobalAchievements.cs) |
| `/achievement/v1/public/namespaces/{namespace}/global/achievements/{achievementCode}/contributors` | GET | ListGlobalAchievementContributors | [ListGlobalAchievementContributors](../../apis/AccelByte.Sdk.Api.Achievement/Operation/GlobalAchievements/ListGlobalAchievementContributors.cs) | [ListGlobalAchievementContributors](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Achievement/GlobalAchievements/ListGlobalAchievementContributors.cs) |
| `/achievement/v1/public/namespaces/{namespace}/users/{userId}/global/achievements` | GET | ListUserContributions | [ListUserContributions](../../apis/AccelByte.Sdk.Api.Achievement/Operation/GlobalAchievements/ListUserContributions.cs) | [ListUserContributions](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Achievement/GlobalAchievements/ListUserContributions.cs) |
| `/achievement/v1/public/namespaces/{namespace}/users/{userId}/global/achievements/{achievementCode}/claim` | POST | ClaimGlobalAchievementReward | [ClaimGlobalAchievementReward](../../apis/AccelByte.Sdk.Api.Achievement/Operation/GlobalAchievements/ClaimGlobalAchievementReward.cs) | [ClaimGlobalAchievementReward](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Achievement/GlobalAchievements/ClaimGlobalAchievementReward.cs) |

### Tags Wrapper:  [Tags](../../apis/AccelByte.Sdk.Api.Achievement/Wrapper/Tags.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/achievement/v1/admin/namespaces/{namespace}/tags` | GET | AdminListTags | [AdminListTags](../../apis/AccelByte.Sdk.Api.Achievement/Operation/Tags/AdminListTags.cs) | [AdminListTags](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Achievement/Tags/AdminListTags.cs) |
| `/achievement/v1/public/namespaces/{namespace}/tags` | GET | PublicListTags | [PublicListTags](../../apis/AccelByte.Sdk.Api.Achievement/Operation/Tags/PublicListTags.cs) | [PublicListTags](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Achievement/Tags/PublicListTags.cs) |

### User Achievements Wrapper:  [UserAchievements](../../apis/AccelByte.Sdk.Api.Achievement/Wrapper/UserAchievements.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/achievement/v1/admin/namespaces/{namespace}/users/{userId}/achievements` | GET | AdminListUserAchievements | [AdminListUserAchievements](../../apis/AccelByte.Sdk.Api.Achievement/Operation/UserAchievements/AdminListUserAchievements.cs) | [AdminListUserAchievements](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Achievement/UserAchievements/AdminListUserAchievements.cs) |
| `/achievement/v1/admin/namespaces/{namespace}/users/{userId}/achievements/{achievementCode}/reset` | DELETE | AdminResetAchievement | [AdminResetAchievement](../../apis/AccelByte.Sdk.Api.Achievement/Operation/UserAchievements/AdminResetAchievement.cs) | [AdminResetAchievement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Achievement/UserAchievements/AdminResetAchievement.cs) |
| `/achievement/v1/admin/namespaces/{namespace}/users/{userId}/achievements/{achievementCode}/unlock` | PUT | AdminUnlockAchievement | [AdminUnlockAchievement](../../apis/AccelByte.Sdk.Api.Achievement/Operation/UserAchievements/AdminUnlockAchievement.cs) | [AdminUnlockAchievement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Achievement/UserAchievements/AdminUnlockAchievement.cs) |
| `/achievement/v1/public/namespaces/{namespace}/users/{userId}/achievements` | GET | PublicListUserAchievements | [PublicListUserAchievements](../../apis/AccelByte.Sdk.Api.Achievement/Operation/UserAchievements/PublicListUserAchievements.cs) | [PublicListUserAchievements](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Achievement/UserAchievements/PublicListUserAchievements.cs) |
| `/achievement/v1/public/namespaces/{namespace}/users/{userId}/achievements/{achievementCode}/unlock` | PUT | PublicUnlockAchievement | [PublicUnlockAchievement](../../apis/AccelByte.Sdk.Api.Achievement/Operation/UserAchievements/PublicUnlockAchievement.cs) | [PublicUnlockAchievement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Achievement/UserAchievements/PublicUnlockAchievement.cs) |

### Anonymization Wrapper:  [Anonymization](../../apis/AccelByte.Sdk.Api.Achievement/Wrapper/Anonymization.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/achievement/v1/admin/namespaces/{namespace}/users/{userId}/anonymization/achievements` | DELETE | AdminAnonymizeUserAchievement | [AdminAnonymizeUserAchievement](../../apis/AccelByte.Sdk.Api.Achievement/Operation/Anonymization/AdminAnonymizeUserAchievement.cs) | [AdminAnonymizeUserAchievement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Achievement/Anonymization/AdminAnonymizeUserAchievement.cs) |


&nbsp;

## Operations with Generic Response

### Achievements Wrapper:  [Achievements](../../apis/AccelByte.Sdk.Api.Achievement/Wrapper/Achievements.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/achievement/v1/admin/namespaces/{namespace}/achievements` | POST | AdminCreateNewAchievement | [AdminCreateNewAchievement](../../apis/AccelByte.Sdk.Api.Achievement/Operation/Achievements/AdminCreateNewAchievement.cs) | [AdminCreateNewAchievement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Achievement/Achievements/AdminCreateNewAchievement.cs) |
| `/achievement/v1/admin/namespaces/{namespace}/achievements/{achievementCode}` | GET | AdminGetAchievement | [AdminGetAchievement](../../apis/AccelByte.Sdk.Api.Achievement/Operation/Achievements/AdminGetAchievement.cs) | [AdminGetAchievement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Achievement/Achievements/AdminGetAchievement.cs) |
| `/achievement/v1/admin/namespaces/{namespace}/achievements/{achievementCode}` | PUT | AdminUpdateAchievement | [AdminUpdateAchievement](../../apis/AccelByte.Sdk.Api.Achievement/Operation/Achievements/AdminUpdateAchievement.cs) | [AdminUpdateAchievement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Achievement/Achievements/AdminUpdateAchievement.cs) |
| `/achievement/v1/public/namespaces/{namespace}/achievements/{achievementCode}` | GET | PublicGetAchievement | [PublicGetAchievement](../../apis/AccelByte.Sdk.Api.Achievement/Operation/Achievements/PublicGetAchievement.cs) | [PublicGetAchievement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Achievement/Achievements/PublicGetAchievement.cs) |

### Global Achievements Wrapper:  [GlobalAchievements](../../apis/AccelByte.Sdk.Api.Achievement/Wrapper/GlobalAchievements.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Tags Wrapper:  [Tags](../../apis/AccelByte.Sdk.Api.Achievement/Wrapper/Tags.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### User Achievements Wrapper:  [UserAchievements](../../apis/AccelByte.Sdk.Api.Achievement/Wrapper/UserAchievements.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Anonymization Wrapper:  [Anonymization](../../apis/AccelByte.Sdk.Api.Achievement/Wrapper/Anonymization.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|


&nbsp;

## Models

| Model | Class |
|---|---|
| `models.AchievementOrderUpdateRequest` | [ModelsAchievementOrderUpdateRequest](../../apis/AccelByte.Sdk.Api.Achievement/Model/ModelsAchievementOrderUpdateRequest.cs) |
| `models.AchievementRequest` | [ModelsAchievementRequest](../../apis/AccelByte.Sdk.Api.Achievement/Model/ModelsAchievementRequest.cs) |
| `models.AchievementResponse` | [ModelsAchievementResponse](../../apis/AccelByte.Sdk.Api.Achievement/Model/ModelsAchievementResponse.cs) |
| `models.AchievementUpdateRequest` | [ModelsAchievementUpdateRequest](../../apis/AccelByte.Sdk.Api.Achievement/Model/ModelsAchievementUpdateRequest.cs) |
| `models.AdditionalInfo` | [ModelsAdditionalInfo](../../apis/AccelByte.Sdk.Api.Achievement/Model/ModelsAdditionalInfo.cs) |
| `models.ContributorResponse` | [ModelsContributorResponse](../../apis/AccelByte.Sdk.Api.Achievement/Model/ModelsContributorResponse.cs) |
| `models.GlobalAchievementResponse` | [ModelsGlobalAchievementResponse](../../apis/AccelByte.Sdk.Api.Achievement/Model/ModelsGlobalAchievementResponse.cs) |
| `models.Icon` | [ModelsIcon](../../apis/AccelByte.Sdk.Api.Achievement/Model/ModelsIcon.cs) |
| `models.PaginatedAchievementResponse` | [ModelsPaginatedAchievementResponse](../../apis/AccelByte.Sdk.Api.Achievement/Model/ModelsPaginatedAchievementResponse.cs) |
| `models.PaginatedContributorResponse` | [ModelsPaginatedContributorResponse](../../apis/AccelByte.Sdk.Api.Achievement/Model/ModelsPaginatedContributorResponse.cs) |
| `models.PaginatedGlobalAchievementResponse` | [ModelsPaginatedGlobalAchievementResponse](../../apis/AccelByte.Sdk.Api.Achievement/Model/ModelsPaginatedGlobalAchievementResponse.cs) |
| `models.PaginatedTagResponse` | [ModelsPaginatedTagResponse](../../apis/AccelByte.Sdk.Api.Achievement/Model/ModelsPaginatedTagResponse.cs) |
| `models.PaginatedUserAchievementResponse` | [ModelsPaginatedUserAchievementResponse](../../apis/AccelByte.Sdk.Api.Achievement/Model/ModelsPaginatedUserAchievementResponse.cs) |
| `models.PaginatedUserContributionResponse` | [ModelsPaginatedUserContributionResponse](../../apis/AccelByte.Sdk.Api.Achievement/Model/ModelsPaginatedUserContributionResponse.cs) |
| `models.Pagination` | [ModelsPagination](../../apis/AccelByte.Sdk.Api.Achievement/Model/ModelsPagination.cs) |
| `models.PublicAchievementResponse` | [ModelsPublicAchievementResponse](../../apis/AccelByte.Sdk.Api.Achievement/Model/ModelsPublicAchievementResponse.cs) |
| `models.PublicAchievementsResponse` | [ModelsPublicAchievementsResponse](../../apis/AccelByte.Sdk.Api.Achievement/Model/ModelsPublicAchievementsResponse.cs) |
| `models.TagResponse` | [ModelsTagResponse](../../apis/AccelByte.Sdk.Api.Achievement/Model/ModelsTagResponse.cs) |
| `models.UserAchievementResponse` | [ModelsUserAchievementResponse](../../apis/AccelByte.Sdk.Api.Achievement/Model/ModelsUserAchievementResponse.cs) |
| `models.UserContributionResponse` | [ModelsUserContributionResponse](../../apis/AccelByte.Sdk.Api.Achievement/Model/ModelsUserContributionResponse.cs) |
| `response.Error` | [ResponseError](../../apis/AccelByte.Sdk.Api.Achievement/Model/ResponseError.cs) |
| `service.ImportConfigResponse` | [ServiceImportConfigResponse](../../apis/AccelByte.Sdk.Api.Achievement/Model/ServiceImportConfigResponse.cs) |
