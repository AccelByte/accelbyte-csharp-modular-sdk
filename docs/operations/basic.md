# Basic Service Index

&nbsp;

## Operations

### Namespace Wrapper:  [Namespace](../../apis/AccelByte.Sdk.Api.Basic/Wrapper/Namespace.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/basic/v1/admin/namespaces` | GET | GetNamespaces | [GetNamespaces](../../apis/AccelByte.Sdk.Api.Basic/Operation/Namespace/GetNamespaces.cs) | [GetNamespaces](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/Namespace/GetNamespaces.cs) |
| `/basic/v1/admin/namespaces` | POST | CreateNamespace | [CreateNamespace](../../apis/AccelByte.Sdk.Api.Basic/Operation/Namespace/CreateNamespace.cs) | [CreateNamespace](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/Namespace/CreateNamespace.cs) |
| `/basic/v1/admin/namespaces/{namespace}` | GET | GetNamespace | [GetNamespace](../../apis/AccelByte.Sdk.Api.Basic/Operation/Namespace/GetNamespace.cs) | [GetNamespace](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/Namespace/GetNamespace.cs) |
| `/basic/v1/admin/namespaces/{namespace}` | DELETE | DeleteNamespace | [DeleteNamespace](../../apis/AccelByte.Sdk.Api.Basic/Operation/Namespace/DeleteNamespace.cs) | [DeleteNamespace](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/Namespace/DeleteNamespace.cs) |
| `/basic/v1/admin/namespaces/{namespace}/basic` | PATCH | UpdateNamespace | [UpdateNamespace](../../apis/AccelByte.Sdk.Api.Basic/Operation/Namespace/UpdateNamespace.cs) | [UpdateNamespace](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/Namespace/UpdateNamespace.cs) |
| `/basic/v1/admin/namespaces/{namespace}/game` | GET | GetGameNamespaces | [GetGameNamespaces](../../apis/AccelByte.Sdk.Api.Basic/Operation/Namespace/GetGameNamespaces.cs) | [GetGameNamespaces](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/Namespace/GetGameNamespaces.cs) |
| `/basic/v1/admin/namespaces/{namespace}/publisher` | GET | GetNamespacePublisher | [GetNamespacePublisher](../../apis/AccelByte.Sdk.Api.Basic/Operation/Namespace/GetNamespacePublisher.cs) | [GetNamespacePublisher](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/Namespace/GetNamespacePublisher.cs) |
| `/basic/v1/admin/namespaces/{namespace}/status` | PATCH | ChangeNamespaceStatus | [ChangeNamespaceStatus](../../apis/AccelByte.Sdk.Api.Basic/Operation/Namespace/ChangeNamespaceStatus.cs) | [ChangeNamespaceStatus](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/Namespace/ChangeNamespaceStatus.cs) |
| `/basic/v1/public/namespaces` | GET | PublicGetNamespaces | [PublicGetNamespaces](../../apis/AccelByte.Sdk.Api.Basic/Operation/Namespace/PublicGetNamespaces.cs) | [PublicGetNamespaces](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/Namespace/PublicGetNamespaces.cs) |
| `/basic/v1/public/namespaces/{namespace}/publisher` | GET | PublicGetNamespacePublisher | [PublicGetNamespacePublisher](../../apis/AccelByte.Sdk.Api.Basic/Operation/Namespace/PublicGetNamespacePublisher.cs) | [PublicGetNamespacePublisher](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/Namespace/PublicGetNamespacePublisher.cs) |

### UserAction Wrapper:  [UserAction](../../apis/AccelByte.Sdk.Api.Basic/Wrapper/UserAction.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/basic/v1/admin/namespaces/{namespace}/actions` | GET | GetActions | [GetActions](../../apis/AccelByte.Sdk.Api.Basic/Operation/UserAction/GetActions.cs) | [GetActions](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/UserAction/GetActions.cs) |
| `/basic/v1/admin/namespaces/{namespace}/actions/ban` | POST | BanUsers | [BanUsers](../../apis/AccelByte.Sdk.Api.Basic/Operation/UserAction/BanUsers.cs) | [BanUsers](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/UserAction/BanUsers.cs) |
| `/basic/v1/admin/namespaces/{namespace}/actions/banned` | GET | GetBannedUsers | [GetBannedUsers](../../apis/AccelByte.Sdk.Api.Basic/Operation/UserAction/GetBannedUsers.cs) | [GetBannedUsers](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/UserAction/GetBannedUsers.cs) |
| `/basic/v1/admin/namespaces/{namespace}/actions/report` | POST | ReportUser | [ReportUser](../../apis/AccelByte.Sdk.Api.Basic/Operation/UserAction/ReportUser.cs) | [ReportUser](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/UserAction/ReportUser.cs) |
| `/basic/v1/admin/namespaces/{namespace}/actions/status` | GET | GetUserStatus | [GetUserStatus](../../apis/AccelByte.Sdk.Api.Basic/Operation/UserAction/GetUserStatus.cs) | [GetUserStatus](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/UserAction/GetUserStatus.cs) |
| `/basic/v1/admin/namespaces/{namespace}/actions/unban` | POST | UnBanUsers | [UnBanUsers](../../apis/AccelByte.Sdk.Api.Basic/Operation/UserAction/UnBanUsers.cs) | [UnBanUsers](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/UserAction/UnBanUsers.cs) |
| `/basic/v1/public/namespaces/{namespace}/users/{userId}/actions/report` | POST | PublicReportUser | [PublicReportUser](../../apis/AccelByte.Sdk.Api.Basic/Operation/UserAction/PublicReportUser.cs) | [PublicReportUser](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/UserAction/PublicReportUser.cs) |

### Config Wrapper:  [Config](../../apis/AccelByte.Sdk.Api.Basic/Wrapper/Config.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/basic/v1/admin/namespaces/{namespace}/configs` | POST | CreateConfig | [CreateConfig](../../apis/AccelByte.Sdk.Api.Basic/Operation/Config/CreateConfig.cs) | [CreateConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/Config/CreateConfig.cs) |
| `/basic/v1/admin/namespaces/{namespace}/configs/{configKey}` | GET | GetConfig1 | [GetConfig1](../../apis/AccelByte.Sdk.Api.Basic/Operation/Config/GetConfig1.cs) | [GetConfig1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/Config/GetConfig1.cs) |
| `/basic/v1/admin/namespaces/{namespace}/configs/{configKey}` | DELETE | DeleteConfig1 | [DeleteConfig1](../../apis/AccelByte.Sdk.Api.Basic/Operation/Config/DeleteConfig1.cs) | [DeleteConfig1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/Config/DeleteConfig1.cs) |
| `/basic/v1/admin/namespaces/{namespace}/configs/{configKey}` | PATCH | UpdateConfig1 | [UpdateConfig1](../../apis/AccelByte.Sdk.Api.Basic/Operation/Config/UpdateConfig1.cs) | [UpdateConfig1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/Config/UpdateConfig1.cs) |
| `/basic/v1/admin/namespaces/{namespace}/publisher/configs/{configKey}` | GET | GetPublisherConfig | [GetPublisherConfig](../../apis/AccelByte.Sdk.Api.Basic/Operation/Config/GetPublisherConfig.cs) | [GetPublisherConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/Config/GetPublisherConfig.cs) |

### EQU8Config Wrapper:  [EQU8Config](../../apis/AccelByte.Sdk.Api.Basic/Wrapper/EQU8Config.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/basic/v1/admin/namespaces/{namespace}/equ8/config` | GET | GetConfig | [GetConfig](../../apis/AccelByte.Sdk.Api.Basic/Operation/EQU8Config/GetConfig.cs) | [GetConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/EQU8Config/GetConfig.cs) |
| `/basic/v1/admin/namespaces/{namespace}/equ8/config` | DELETE | DeleteConfig | [DeleteConfig](../../apis/AccelByte.Sdk.Api.Basic/Operation/EQU8Config/DeleteConfig.cs) | [DeleteConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/EQU8Config/DeleteConfig.cs) |
| `/basic/v1/admin/namespaces/{namespace}/equ8/config` | PATCH | UpdateConfig | [UpdateConfig](../../apis/AccelByte.Sdk.Api.Basic/Operation/EQU8Config/UpdateConfig.cs) | [UpdateConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/EQU8Config/UpdateConfig.cs) |

### FileUpload Wrapper:  [FileUpload](../../apis/AccelByte.Sdk.Api.Basic/Wrapper/FileUpload.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/basic/v1/admin/namespaces/{namespace}/folders/{folder}/files` | POST | GeneratedUploadUrl | [GeneratedUploadUrl](../../apis/AccelByte.Sdk.Api.Basic/Operation/FileUpload/GeneratedUploadUrl.cs) | [GeneratedUploadUrl](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/FileUpload/GeneratedUploadUrl.cs) |
| `/basic/v1/admin/namespaces/{namespace}/users/{userId}/files` | POST | GeneratedUserUploadContentUrl | [GeneratedUserUploadContentUrl](../../apis/AccelByte.Sdk.Api.Basic/Operation/FileUpload/GeneratedUserUploadContentUrl.cs) | [GeneratedUserUploadContentUrl](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/FileUpload/GeneratedUserUploadContentUrl.cs) |
| `/basic/v1/public/namespaces/{namespace}/folders/{folder}/files` | POST | PublicGeneratedUploadUrl | [PublicGeneratedUploadUrl](../../apis/AccelByte.Sdk.Api.Basic/Operation/FileUpload/PublicGeneratedUploadUrl.cs) | [PublicGeneratedUploadUrl](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/FileUpload/PublicGeneratedUploadUrl.cs) |
| `/basic/v1/public/namespaces/{namespace}/users/{userId}/files` | POST | PublicGeneratedUserUploadContentUrl | [PublicGeneratedUserUploadContentUrl](../../apis/AccelByte.Sdk.Api.Basic/Operation/FileUpload/PublicGeneratedUserUploadContentUrl.cs) | [PublicGeneratedUserUploadContentUrl](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/FileUpload/PublicGeneratedUserUploadContentUrl.cs) |

### Misc Wrapper:  [Misc](../../apis/AccelByte.Sdk.Api.Basic/Wrapper/Misc.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| [DEPRECATED] `/basic/v1/admin/namespaces/{namespace}/misc/countries` | GET | GetCountries | [GetCountries](../../apis/AccelByte.Sdk.Api.Basic/Operation/Misc/GetCountries.cs) | [GetCountries](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/Misc/GetCountries.cs) |
| `/basic/v1/admin/namespaces/{namespace}/misc/countrygroups` | GET | GetCountryGroups | [GetCountryGroups](../../apis/AccelByte.Sdk.Api.Basic/Operation/Misc/GetCountryGroups.cs) | [GetCountryGroups](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/Misc/GetCountryGroups.cs) |
| `/basic/v1/admin/namespaces/{namespace}/misc/countrygroups` | POST | AddCountryGroup | [AddCountryGroup](../../apis/AccelByte.Sdk.Api.Basic/Operation/Misc/AddCountryGroup.cs) | [AddCountryGroup](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/Misc/AddCountryGroup.cs) |
| `/basic/v1/admin/namespaces/{namespace}/misc/countrygroups/{countryGroupCode}` | PUT | UpdateCountryGroup | [UpdateCountryGroup](../../apis/AccelByte.Sdk.Api.Basic/Operation/Misc/UpdateCountryGroup.cs) | [UpdateCountryGroup](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/Misc/UpdateCountryGroup.cs) |
| `/basic/v1/admin/namespaces/{namespace}/misc/countrygroups/{countryGroupCode}` | DELETE | DeleteCountryGroup | [DeleteCountryGroup](../../apis/AccelByte.Sdk.Api.Basic/Operation/Misc/DeleteCountryGroup.cs) | [DeleteCountryGroup](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/Misc/DeleteCountryGroup.cs) |
| `/basic/v1/admin/namespaces/{namespace}/misc/languages` | GET | GetLanguages | [GetLanguages](../../apis/AccelByte.Sdk.Api.Basic/Operation/Misc/GetLanguages.cs) | [GetLanguages](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/Misc/GetLanguages.cs) |
| `/basic/v1/admin/namespaces/{namespace}/misc/timezones` | GET | GetTimeZones | [GetTimeZones](../../apis/AccelByte.Sdk.Api.Basic/Operation/Misc/GetTimeZones.cs) | [GetTimeZones](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/Misc/GetTimeZones.cs) |
| `/basic/v1/public/misc/time` | GET | PublicGetTime | [PublicGetTime](../../apis/AccelByte.Sdk.Api.Basic/Operation/Misc/PublicGetTime.cs) | [PublicGetTime](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/Misc/PublicGetTime.cs) |
| [DEPRECATED] `/basic/v1/public/namespaces/{namespace}/misc/countries` | GET | PublicGetCountries | [PublicGetCountries](../../apis/AccelByte.Sdk.Api.Basic/Operation/Misc/PublicGetCountries.cs) | [PublicGetCountries](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/Misc/PublicGetCountries.cs) |
| `/basic/v1/public/namespaces/{namespace}/misc/languages` | GET | PublicGetLanguages | [PublicGetLanguages](../../apis/AccelByte.Sdk.Api.Basic/Operation/Misc/PublicGetLanguages.cs) | [PublicGetLanguages](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/Misc/PublicGetLanguages.cs) |
| `/basic/v1/public/namespaces/{namespace}/misc/timezones` | GET | PublicGetTimeZones | [PublicGetTimeZones](../../apis/AccelByte.Sdk.Api.Basic/Operation/Misc/PublicGetTimeZones.cs) | [PublicGetTimeZones](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/Misc/PublicGetTimeZones.cs) |

### UserProfile Wrapper:  [UserProfile](../../apis/AccelByte.Sdk.Api.Basic/Wrapper/UserProfile.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/basic/v1/admin/namespaces/{namespace}/profiles/byPublicId` | GET | GetUserProfileInfoByPublicId | [GetUserProfileInfoByPublicId](../../apis/AccelByte.Sdk.Api.Basic/Operation/UserProfile/GetUserProfileInfoByPublicId.cs) | [GetUserProfileInfoByPublicId](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/UserProfile/GetUserProfileInfoByPublicId.cs) |
| `/basic/v1/admin/namespaces/{namespace}/profiles/public` | POST | AdminGetUserProfilePublicInfoByIds | [AdminGetUserProfilePublicInfoByIds](../../apis/AccelByte.Sdk.Api.Basic/Operation/UserProfile/AdminGetUserProfilePublicInfoByIds.cs) | [AdminGetUserProfilePublicInfoByIds](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/UserProfile/AdminGetUserProfilePublicInfoByIds.cs) |
| `/basic/v1/admin/namespaces/{namespace}/users/{userId}/profiles` | GET | GetUserProfileInfo | [GetUserProfileInfo](../../apis/AccelByte.Sdk.Api.Basic/Operation/UserProfile/GetUserProfileInfo.cs) | [GetUserProfileInfo](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/UserProfile/GetUserProfileInfo.cs) |
| `/basic/v1/admin/namespaces/{namespace}/users/{userId}/profiles` | PUT | UpdateUserProfile | [UpdateUserProfile](../../apis/AccelByte.Sdk.Api.Basic/Operation/UserProfile/UpdateUserProfile.cs) | [UpdateUserProfile](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/UserProfile/UpdateUserProfile.cs) |
| `/basic/v1/admin/namespaces/{namespace}/users/{userId}/profiles` | DELETE | DeleteUserProfile | [DeleteUserProfile](../../apis/AccelByte.Sdk.Api.Basic/Operation/UserProfile/DeleteUserProfile.cs) | [DeleteUserProfile](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/UserProfile/DeleteUserProfile.cs) |
| `/basic/v1/admin/namespaces/{namespace}/users/{userId}/profiles/customAttributes` | GET | GetCustomAttributesInfo | [GetCustomAttributesInfo](../../apis/AccelByte.Sdk.Api.Basic/Operation/UserProfile/GetCustomAttributesInfo.cs) | [GetCustomAttributesInfo](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/UserProfile/GetCustomAttributesInfo.cs) |
| `/basic/v1/admin/namespaces/{namespace}/users/{userId}/profiles/customAttributes` | PUT | UpdateCustomAttributesPartially | [UpdateCustomAttributesPartially](../../apis/AccelByte.Sdk.Api.Basic/Operation/UserProfile/UpdateCustomAttributesPartially.cs) | [UpdateCustomAttributesPartially](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/UserProfile/UpdateCustomAttributesPartially.cs) |
| `/basic/v1/admin/namespaces/{namespace}/users/{userId}/profiles/privateCustomAttributes` | GET | GetPrivateCustomAttributesInfo | [GetPrivateCustomAttributesInfo](../../apis/AccelByte.Sdk.Api.Basic/Operation/UserProfile/GetPrivateCustomAttributesInfo.cs) | [GetPrivateCustomAttributesInfo](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/UserProfile/GetPrivateCustomAttributesInfo.cs) |
| `/basic/v1/admin/namespaces/{namespace}/users/{userId}/profiles/privateCustomAttributes` | PUT | UpdatePrivateCustomAttributesPartially | [UpdatePrivateCustomAttributesPartially](../../apis/AccelByte.Sdk.Api.Basic/Operation/UserProfile/UpdatePrivateCustomAttributesPartially.cs) | [UpdatePrivateCustomAttributesPartially](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/UserProfile/UpdatePrivateCustomAttributesPartially.cs) |
| `/basic/v1/admin/namespaces/{namespace}/users/{userId}/profiles/status` | PATCH | UpdateUserProfileStatus | [UpdateUserProfileStatus](../../apis/AccelByte.Sdk.Api.Basic/Operation/UserProfile/UpdateUserProfileStatus.cs) | [UpdateUserProfileStatus](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/UserProfile/UpdateUserProfileStatus.cs) |
| `/basic/v1/public/namespaces/{namespace}/profiles/public` | GET | PublicGetUserProfilePublicInfoByIds | [PublicGetUserProfilePublicInfoByIds](../../apis/AccelByte.Sdk.Api.Basic/Operation/UserProfile/PublicGetUserProfilePublicInfoByIds.cs) | [PublicGetUserProfilePublicInfoByIds](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/UserProfile/PublicGetUserProfilePublicInfoByIds.cs) |
| `/basic/v1/public/namespaces/{namespace}/profiles/public/byPublicId` | GET | PublicGetUserProfileInfoByPublicId | [PublicGetUserProfileInfoByPublicId](../../apis/AccelByte.Sdk.Api.Basic/Operation/UserProfile/PublicGetUserProfileInfoByPublicId.cs) | [PublicGetUserProfileInfoByPublicId](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/UserProfile/PublicGetUserProfileInfoByPublicId.cs) |
| `/basic/v1/public/namespaces/{namespace}/users/me/profiles` | GET | GetMyProfileInfo | [GetMyProfileInfo](../../apis/AccelByte.Sdk.Api.Basic/Operation/UserProfile/GetMyProfileInfo.cs) | [GetMyProfileInfo](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/UserProfile/GetMyProfileInfo.cs) |
| `/basic/v1/public/namespaces/{namespace}/users/me/profiles` | PUT | UpdateMyProfile | [UpdateMyProfile](../../apis/AccelByte.Sdk.Api.Basic/Operation/UserProfile/UpdateMyProfile.cs) | [UpdateMyProfile](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/UserProfile/UpdateMyProfile.cs) |
| `/basic/v1/public/namespaces/{namespace}/users/me/profiles` | POST | CreateMyProfile | [CreateMyProfile](../../apis/AccelByte.Sdk.Api.Basic/Operation/UserProfile/CreateMyProfile.cs) | [CreateMyProfile](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/UserProfile/CreateMyProfile.cs) |
| `/basic/v1/public/namespaces/{namespace}/users/me/profiles/privateCustomAttributes` | GET | GetMyPrivateCustomAttributesInfo | [GetMyPrivateCustomAttributesInfo](../../apis/AccelByte.Sdk.Api.Basic/Operation/UserProfile/GetMyPrivateCustomAttributesInfo.cs) | [GetMyPrivateCustomAttributesInfo](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/UserProfile/GetMyPrivateCustomAttributesInfo.cs) |
| `/basic/v1/public/namespaces/{namespace}/users/me/profiles/privateCustomAttributes` | PUT | UpdateMyPrivateCustomAttributesPartially | [UpdateMyPrivateCustomAttributesPartially](../../apis/AccelByte.Sdk.Api.Basic/Operation/UserProfile/UpdateMyPrivateCustomAttributesPartially.cs) | [UpdateMyPrivateCustomAttributesPartially](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/UserProfile/UpdateMyPrivateCustomAttributesPartially.cs) |
| `/basic/v1/public/namespaces/{namespace}/users/me/profiles/zipCode` | GET | GetMyZipCode | [GetMyZipCode](../../apis/AccelByte.Sdk.Api.Basic/Operation/UserProfile/GetMyZipCode.cs) | [GetMyZipCode](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/UserProfile/GetMyZipCode.cs) |
| `/basic/v1/public/namespaces/{namespace}/users/me/profiles/zipCode` | PATCH | UpdateMyZipCode | [UpdateMyZipCode](../../apis/AccelByte.Sdk.Api.Basic/Operation/UserProfile/UpdateMyZipCode.cs) | [UpdateMyZipCode](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/UserProfile/UpdateMyZipCode.cs) |
| `/basic/v1/public/namespaces/{namespace}/users/{userId}/profiles` | GET | PublicGetUserProfileInfo | [PublicGetUserProfileInfo](../../apis/AccelByte.Sdk.Api.Basic/Operation/UserProfile/PublicGetUserProfileInfo.cs) | [PublicGetUserProfileInfo](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/UserProfile/PublicGetUserProfileInfo.cs) |
| `/basic/v1/public/namespaces/{namespace}/users/{userId}/profiles` | PUT | PublicUpdateUserProfile | [PublicUpdateUserProfile](../../apis/AccelByte.Sdk.Api.Basic/Operation/UserProfile/PublicUpdateUserProfile.cs) | [PublicUpdateUserProfile](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/UserProfile/PublicUpdateUserProfile.cs) |
| `/basic/v1/public/namespaces/{namespace}/users/{userId}/profiles` | POST | PublicCreateUserProfile | [PublicCreateUserProfile](../../apis/AccelByte.Sdk.Api.Basic/Operation/UserProfile/PublicCreateUserProfile.cs) | [PublicCreateUserProfile](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/UserProfile/PublicCreateUserProfile.cs) |
| `/basic/v1/public/namespaces/{namespace}/users/{userId}/profiles/customAttributes` | GET | PublicGetCustomAttributesInfo | [PublicGetCustomAttributesInfo](../../apis/AccelByte.Sdk.Api.Basic/Operation/UserProfile/PublicGetCustomAttributesInfo.cs) | [PublicGetCustomAttributesInfo](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/UserProfile/PublicGetCustomAttributesInfo.cs) |
| `/basic/v1/public/namespaces/{namespace}/users/{userId}/profiles/customAttributes` | PUT | PublicUpdateCustomAttributesPartially | [PublicUpdateCustomAttributesPartially](../../apis/AccelByte.Sdk.Api.Basic/Operation/UserProfile/PublicUpdateCustomAttributesPartially.cs) | [PublicUpdateCustomAttributesPartially](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/UserProfile/PublicUpdateCustomAttributesPartially.cs) |
| `/basic/v1/public/namespaces/{namespace}/users/{userId}/profiles/public` | GET | PublicGetUserProfilePublicInfo | [PublicGetUserProfilePublicInfo](../../apis/AccelByte.Sdk.Api.Basic/Operation/UserProfile/PublicGetUserProfilePublicInfo.cs) | [PublicGetUserProfilePublicInfo](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/UserProfile/PublicGetUserProfilePublicInfo.cs) |
| `/basic/v1/public/namespaces/{namespace}/users/{userId}/profiles/status` | PATCH | PublicUpdateUserProfileStatus | [PublicUpdateUserProfileStatus](../../apis/AccelByte.Sdk.Api.Basic/Operation/UserProfile/PublicUpdateUserProfileStatus.cs) | [PublicUpdateUserProfileStatus](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/UserProfile/PublicUpdateUserProfileStatus.cs) |

### Anonymization Wrapper:  [Anonymization](../../apis/AccelByte.Sdk.Api.Basic/Wrapper/Anonymization.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/basic/v1/admin/namespaces/{namespace}/users/{userId}/anonymization/profiles` | DELETE | AnonymizeUserProfile | [AnonymizeUserProfile](../../apis/AccelByte.Sdk.Api.Basic/Operation/Anonymization/AnonymizeUserProfile.cs) | [AnonymizeUserProfile](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/Anonymization/AnonymizeUserProfile.cs) |


&nbsp;

## Operations with Generic Response

### Namespace Wrapper:  [Namespace](../../apis/AccelByte.Sdk.Api.Basic/Wrapper/Namespace.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### UserAction Wrapper:  [UserAction](../../apis/AccelByte.Sdk.Api.Basic/Wrapper/UserAction.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Config Wrapper:  [Config](../../apis/AccelByte.Sdk.Api.Basic/Wrapper/Config.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### EQU8Config Wrapper:  [EQU8Config](../../apis/AccelByte.Sdk.Api.Basic/Wrapper/EQU8Config.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### FileUpload Wrapper:  [FileUpload](../../apis/AccelByte.Sdk.Api.Basic/Wrapper/FileUpload.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Misc Wrapper:  [Misc](../../apis/AccelByte.Sdk.Api.Basic/Wrapper/Misc.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### UserProfile Wrapper:  [UserProfile](../../apis/AccelByte.Sdk.Api.Basic/Wrapper/UserProfile.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/basic/v1/admin/namespaces/{namespace}/profiles/public` | POST | AdminGetUserProfilePublicInfoByIds | [AdminGetUserProfilePublicInfoByIds](../../apis/AccelByte.Sdk.Api.Basic/Operation/UserProfile/AdminGetUserProfilePublicInfoByIds.cs) | [AdminGetUserProfilePublicInfoByIds](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/UserProfile/AdminGetUserProfilePublicInfoByIds.cs) |
| `/basic/v1/public/namespaces/{namespace}/profiles/public` | GET | PublicGetUserProfilePublicInfoByIds | [PublicGetUserProfilePublicInfoByIds](../../apis/AccelByte.Sdk.Api.Basic/Operation/UserProfile/PublicGetUserProfilePublicInfoByIds.cs) | [PublicGetUserProfilePublicInfoByIds](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Basic/UserProfile/PublicGetUserProfilePublicInfoByIds.cs) |

### Anonymization Wrapper:  [Anonymization](../../apis/AccelByte.Sdk.Api.Basic/Wrapper/Anonymization.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|


&nbsp;

## Models

| Model | Class |
|---|---|
| `A DTO for unban user API call.` | [ADTOForUnbanUserAPICall](../../apis/AccelByte.Sdk.Api.Basic/Model/ADTOForUnbanUserAPICall.cs) |
| `A DTO for update equ8 config API call.` | [ADTOForUpdateEqu8ConfigAPICall](../../apis/AccelByte.Sdk.Api.Basic/Model/ADTOForUpdateEqu8ConfigAPICall.cs) |
| `A DTO object for equ8 user ban status` | [ADTOObjectForEqu8UserBanStatus](../../apis/AccelByte.Sdk.Api.Basic/Model/ADTOObjectForEqu8UserBanStatus.cs) |
| `A DTO object for equ8 user status` | [ADTOObjectForEqu8UserStatus](../../apis/AccelByte.Sdk.Api.Basic/Model/ADTOObjectForEqu8UserStatus.cs) |
| `Action` | [Action](../../apis/AccelByte.Sdk.Api.Basic/Model/Action.cs) |
| `AddCountryGroupRequest` | [AddCountryGroupRequest](../../apis/AccelByte.Sdk.Api.Basic/Model/AddCountryGroupRequest.cs) |
| `AddCountryGroupResponse` | [AddCountryGroupResponse](../../apis/AccelByte.Sdk.Api.Basic/Model/AddCountryGroupResponse.cs) |
| `ConfigCreate` | [ConfigCreate](../../apis/AccelByte.Sdk.Api.Basic/Model/ConfigCreate.cs) |
| `ConfigInfo` | [ConfigInfo](../../apis/AccelByte.Sdk.Api.Basic/Model/ConfigInfo.cs) |
| `ConfigUpdate` | [ConfigUpdate](../../apis/AccelByte.Sdk.Api.Basic/Model/ConfigUpdate.cs) |
| `CountryGroupObject` | [CountryGroupObject](../../apis/AccelByte.Sdk.Api.Basic/Model/CountryGroupObject.cs) |
| `CountryObject` | [CountryObject](../../apis/AccelByte.Sdk.Api.Basic/Model/CountryObject.cs) |
| `Equ8Config` | [Equ8Config](../../apis/AccelByte.Sdk.Api.Basic/Model/Equ8Config.cs) |
| `ErrorEntity` | [ErrorEntity](../../apis/AccelByte.Sdk.Api.Basic/Model/ErrorEntity.cs) |
| `FieldValidationError` | [FieldValidationError](../../apis/AccelByte.Sdk.Api.Basic/Model/FieldValidationError.cs) |
| `FileUploadUrlInfo` | [FileUploadUrlInfo](../../apis/AccelByte.Sdk.Api.Basic/Model/FileUploadUrlInfo.cs) |
| `NamespaceCreate` | [NamespaceCreate](../../apis/AccelByte.Sdk.Api.Basic/Model/NamespaceCreate.cs) |
| `NamespaceInfo` | [NamespaceInfo](../../apis/AccelByte.Sdk.Api.Basic/Model/NamespaceInfo.cs) |
| `NamespacePublisherInfo` | [NamespacePublisherInfo](../../apis/AccelByte.Sdk.Api.Basic/Model/NamespacePublisherInfo.cs) |
| `NamespaceStatusUpdate` | [NamespaceStatusUpdate](../../apis/AccelByte.Sdk.Api.Basic/Model/NamespaceStatusUpdate.cs) |
| `NamespaceUpdate` | [NamespaceUpdate](../../apis/AccelByte.Sdk.Api.Basic/Model/NamespaceUpdate.cs) |
| `RetrieveCountryGroupResponse` | [RetrieveCountryGroupResponse](../../apis/AccelByte.Sdk.Api.Basic/Model/RetrieveCountryGroupResponse.cs) |
| `RetrieveTimeResponse` | [RetrieveTimeResponse](../../apis/AccelByte.Sdk.Api.Basic/Model/RetrieveTimeResponse.cs) |
| `UpdateCountryGroupRequest` | [UpdateCountryGroupRequest](../../apis/AccelByte.Sdk.Api.Basic/Model/UpdateCountryGroupRequest.cs) |
| `UserBanRequest` | [UserBanRequest](../../apis/AccelByte.Sdk.Api.Basic/Model/UserBanRequest.cs) |
| `UserProfileAdmin` | [UserProfileAdmin](../../apis/AccelByte.Sdk.Api.Basic/Model/UserProfileAdmin.cs) |
| `UserProfileBulkRequest` | [UserProfileBulkRequest](../../apis/AccelByte.Sdk.Api.Basic/Model/UserProfileBulkRequest.cs) |
| `UserProfileCreate` | [UserProfileCreate](../../apis/AccelByte.Sdk.Api.Basic/Model/UserProfileCreate.cs) |
| `UserProfileInfo` | [UserProfileInfo](../../apis/AccelByte.Sdk.Api.Basic/Model/UserProfileInfo.cs) |
| `UserProfilePrivateCreate` | [UserProfilePrivateCreate](../../apis/AccelByte.Sdk.Api.Basic/Model/UserProfilePrivateCreate.cs) |
| `UserProfilePrivateInfo` | [UserProfilePrivateInfo](../../apis/AccelByte.Sdk.Api.Basic/Model/UserProfilePrivateInfo.cs) |
| `UserProfilePublicInfo` | [UserProfilePublicInfo](../../apis/AccelByte.Sdk.Api.Basic/Model/UserProfilePublicInfo.cs) |
| `UserProfileStatusUpdate` | [UserProfileStatusUpdate](../../apis/AccelByte.Sdk.Api.Basic/Model/UserProfileStatusUpdate.cs) |
| `UserProfileUpdate` | [UserProfileUpdate](../../apis/AccelByte.Sdk.Api.Basic/Model/UserProfileUpdate.cs) |
| `UserReportRequest` | [UserReportRequest](../../apis/AccelByte.Sdk.Api.Basic/Model/UserReportRequest.cs) |
| `UserZipCode` | [UserZipCode](../../apis/AccelByte.Sdk.Api.Basic/Model/UserZipCode.cs) |
| `UserZipCodeUpdate` | [UserZipCodeUpdate](../../apis/AccelByte.Sdk.Api.Basic/Model/UserZipCodeUpdate.cs) |
| `ValidationErrorEntity` | [ValidationErrorEntity](../../apis/AccelByte.Sdk.Api.Basic/Model/ValidationErrorEntity.cs) |
