# Platform Service Index

&nbsp;

## Operations

### FulfillmentScript Wrapper:  [FulfillmentScript](../../apis/AccelByte.Sdk.Api.Platform/Wrapper/FulfillmentScript.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/fulfillment/scripts` | GET | ListFulfillmentScripts | [ListFulfillmentScripts](../../apis/AccelByte.Sdk.Api.Platform/Operation/FulfillmentScript/ListFulfillmentScripts.cs) | [ListFulfillmentScripts](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/FulfillmentScript/ListFulfillmentScripts.cs) |
| `/platform/admin/fulfillment/scripts/tests/eval` | POST | TestFulfillmentScriptEval | [TestFulfillmentScriptEval](../../apis/AccelByte.Sdk.Api.Platform/Operation/FulfillmentScript/TestFulfillmentScriptEval.cs) | [TestFulfillmentScriptEval](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/FulfillmentScript/TestFulfillmentScriptEval.cs) |
| `/platform/admin/fulfillment/scripts/{id}` | GET | GetFulfillmentScript | [GetFulfillmentScript](../../apis/AccelByte.Sdk.Api.Platform/Operation/FulfillmentScript/GetFulfillmentScript.cs) | [GetFulfillmentScript](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/FulfillmentScript/GetFulfillmentScript.cs) |
| `/platform/admin/fulfillment/scripts/{id}` | POST | CreateFulfillmentScript | [CreateFulfillmentScript](../../apis/AccelByte.Sdk.Api.Platform/Operation/FulfillmentScript/CreateFulfillmentScript.cs) | [CreateFulfillmentScript](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/FulfillmentScript/CreateFulfillmentScript.cs) |
| `/platform/admin/fulfillment/scripts/{id}` | DELETE | DeleteFulfillmentScript | [DeleteFulfillmentScript](../../apis/AccelByte.Sdk.Api.Platform/Operation/FulfillmentScript/DeleteFulfillmentScript.cs) | [DeleteFulfillmentScript](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/FulfillmentScript/DeleteFulfillmentScript.cs) |
| `/platform/admin/fulfillment/scripts/{id}` | PATCH | UpdateFulfillmentScript | [UpdateFulfillmentScript](../../apis/AccelByte.Sdk.Api.Platform/Operation/FulfillmentScript/UpdateFulfillmentScript.cs) | [UpdateFulfillmentScript](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/FulfillmentScript/UpdateFulfillmentScript.cs) |

### Item Wrapper:  [Item](../../apis/AccelByte.Sdk.Api.Platform/Wrapper/Item.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/items/configs` | GET | ListItemTypeConfigs | [ListItemTypeConfigs](../../apis/AccelByte.Sdk.Api.Platform/Operation/Item/ListItemTypeConfigs.cs) | [ListItemTypeConfigs](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/ListItemTypeConfigs.cs) |
| `/platform/admin/items/configs` | POST | CreateItemTypeConfig | [CreateItemTypeConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/Item/CreateItemTypeConfig.cs) | [CreateItemTypeConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/CreateItemTypeConfig.cs) |
| `/platform/admin/items/configs/search` | GET | SearchItemTypeConfig | [SearchItemTypeConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/Item/SearchItemTypeConfig.cs) | [SearchItemTypeConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/SearchItemTypeConfig.cs) |
| `/platform/admin/items/configs/{id}` | GET | GetItemTypeConfig | [GetItemTypeConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/Item/GetItemTypeConfig.cs) | [GetItemTypeConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/GetItemTypeConfig.cs) |
| `/platform/admin/items/configs/{id}` | PUT | UpdateItemTypeConfig | [UpdateItemTypeConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/Item/UpdateItemTypeConfig.cs) | [UpdateItemTypeConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/UpdateItemTypeConfig.cs) |
| `/platform/admin/items/configs/{id}` | DELETE | DeleteItemTypeConfig | [DeleteItemTypeConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/Item/DeleteItemTypeConfig.cs) | [DeleteItemTypeConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/DeleteItemTypeConfig.cs) |
| `/platform/admin/namespaces/{namespace}/items` | PUT | SyncInGameItem | [SyncInGameItem](../../apis/AccelByte.Sdk.Api.Platform/Operation/Item/SyncInGameItem.cs) | [SyncInGameItem](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/SyncInGameItem.cs) |
| `/platform/admin/namespaces/{namespace}/items` | POST | CreateItem | [CreateItem](../../apis/AccelByte.Sdk.Api.Platform/Operation/Item/CreateItem.cs) | [CreateItem](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/CreateItem.cs) |
| `/platform/admin/namespaces/{namespace}/items/byAppId` | GET | GetItemByAppId | [GetItemByAppId](../../apis/AccelByte.Sdk.Api.Platform/Operation/Item/GetItemByAppId.cs) | [GetItemByAppId](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/GetItemByAppId.cs) |
| `/platform/admin/namespaces/{namespace}/items/byCriteria` | GET | QueryItems | [QueryItems](../../apis/AccelByte.Sdk.Api.Platform/Operation/Item/QueryItems.cs) | [QueryItems](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/QueryItems.cs) |
| `/platform/admin/namespaces/{namespace}/items/byFeatures/basic` | GET | ListBasicItemsByFeatures | [ListBasicItemsByFeatures](../../apis/AccelByte.Sdk.Api.Platform/Operation/Item/ListBasicItemsByFeatures.cs) | [ListBasicItemsByFeatures](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/ListBasicItemsByFeatures.cs) |
| `/platform/admin/namespaces/{namespace}/items/bySku` | GET | GetItemBySku | [GetItemBySku](../../apis/AccelByte.Sdk.Api.Platform/Operation/Item/GetItemBySku.cs) | [GetItemBySku](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/GetItemBySku.cs) |
| `/platform/admin/namespaces/{namespace}/items/bySku/locale` | GET | GetLocaleItemBySku | [GetLocaleItemBySku](../../apis/AccelByte.Sdk.Api.Platform/Operation/Item/GetLocaleItemBySku.cs) | [GetLocaleItemBySku](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/GetLocaleItemBySku.cs) |
| `/platform/admin/namespaces/{namespace}/items/itemId/bySku` | GET | GetItemIdBySku | [GetItemIdBySku](../../apis/AccelByte.Sdk.Api.Platform/Operation/Item/GetItemIdBySku.cs) | [GetItemIdBySku](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/GetItemIdBySku.cs) |
| `/platform/admin/namespaces/{namespace}/items/itemId/bySkus` | GET | GetBulkItemIdBySkus | [GetBulkItemIdBySkus](../../apis/AccelByte.Sdk.Api.Platform/Operation/Item/GetBulkItemIdBySkus.cs) | [GetBulkItemIdBySkus](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/GetBulkItemIdBySkus.cs) |
| `/platform/admin/namespaces/{namespace}/items/locale/byIds` | GET | BulkGetLocaleItems | [BulkGetLocaleItems](../../apis/AccelByte.Sdk.Api.Platform/Operation/Item/BulkGetLocaleItems.cs) | [BulkGetLocaleItems](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/BulkGetLocaleItems.cs) |
| `/platform/admin/namespaces/{namespace}/items/predicate/types` | GET | GetAvailablePredicateTypes | [GetAvailablePredicateTypes](../../apis/AccelByte.Sdk.Api.Platform/Operation/Item/GetAvailablePredicateTypes.cs) | [GetAvailablePredicateTypes](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/GetAvailablePredicateTypes.cs) |
| `/platform/admin/namespaces/{namespace}/items/purchase/conditions/validate` | POST | ValidateItemPurchaseCondition | [ValidateItemPurchaseCondition](../../apis/AccelByte.Sdk.Api.Platform/Operation/Item/ValidateItemPurchaseCondition.cs) | [ValidateItemPurchaseCondition](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/ValidateItemPurchaseCondition.cs) |
| `/platform/admin/namespaces/{namespace}/items/regiondata` | PUT | BulkUpdateRegionData | [BulkUpdateRegionData](../../apis/AccelByte.Sdk.Api.Platform/Operation/Item/BulkUpdateRegionData.cs) | [BulkUpdateRegionData](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/BulkUpdateRegionData.cs) |
| `/platform/admin/namespaces/{namespace}/items/search` | GET | SearchItems | [SearchItems](../../apis/AccelByte.Sdk.Api.Platform/Operation/Item/SearchItems.cs) | [SearchItems](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/SearchItems.cs) |
| `/platform/admin/namespaces/{namespace}/items/uncategorized` | GET | QueryUncategorizedItems | [QueryUncategorizedItems](../../apis/AccelByte.Sdk.Api.Platform/Operation/Item/QueryUncategorizedItems.cs) | [QueryUncategorizedItems](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/QueryUncategorizedItems.cs) |
| `/platform/admin/namespaces/{namespace}/items/{itemId}` | GET | GetItem | [GetItem](../../apis/AccelByte.Sdk.Api.Platform/Operation/Item/GetItem.cs) | [GetItem](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/GetItem.cs) |
| `/platform/admin/namespaces/{namespace}/items/{itemId}` | PUT | UpdateItem | [UpdateItem](../../apis/AccelByte.Sdk.Api.Platform/Operation/Item/UpdateItem.cs) | [UpdateItem](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/UpdateItem.cs) |
| `/platform/admin/namespaces/{namespace}/items/{itemId}` | DELETE | DeleteItem | [DeleteItem](../../apis/AccelByte.Sdk.Api.Platform/Operation/Item/DeleteItem.cs) | [DeleteItem](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/DeleteItem.cs) |
| `/platform/admin/namespaces/{namespace}/items/{itemId}/acquire` | PUT | AcquireItem | [AcquireItem](../../apis/AccelByte.Sdk.Api.Platform/Operation/Item/AcquireItem.cs) | [AcquireItem](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/AcquireItem.cs) |
| `/platform/admin/namespaces/{namespace}/items/{itemId}/app` | GET | GetApp | [GetApp](../../apis/AccelByte.Sdk.Api.Platform/Operation/Item/GetApp.cs) | [GetApp](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/GetApp.cs) |
| `/platform/admin/namespaces/{namespace}/items/{itemId}/app` | PUT | UpdateApp | [UpdateApp](../../apis/AccelByte.Sdk.Api.Platform/Operation/Item/UpdateApp.cs) | [UpdateApp](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/UpdateApp.cs) |
| `/platform/admin/namespaces/{namespace}/items/{itemId}/disable` | PUT | DisableItem | [DisableItem](../../apis/AccelByte.Sdk.Api.Platform/Operation/Item/DisableItem.cs) | [DisableItem](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/DisableItem.cs) |
| `/platform/admin/namespaces/{namespace}/items/{itemId}/dynamic` | GET | GetItemDynamicData | [GetItemDynamicData](../../apis/AccelByte.Sdk.Api.Platform/Operation/Item/GetItemDynamicData.cs) | [GetItemDynamicData](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/GetItemDynamicData.cs) |
| `/platform/admin/namespaces/{namespace}/items/{itemId}/enable` | PUT | EnableItem | [EnableItem](../../apis/AccelByte.Sdk.Api.Platform/Operation/Item/EnableItem.cs) | [EnableItem](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/EnableItem.cs) |
| `/platform/admin/namespaces/{namespace}/items/{itemId}/features/{feature}` | PUT | FeatureItem | [FeatureItem](../../apis/AccelByte.Sdk.Api.Platform/Operation/Item/FeatureItem.cs) | [FeatureItem](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/FeatureItem.cs) |
| `/platform/admin/namespaces/{namespace}/items/{itemId}/features/{feature}` | DELETE | DefeatureItem | [DefeatureItem](../../apis/AccelByte.Sdk.Api.Platform/Operation/Item/DefeatureItem.cs) | [DefeatureItem](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/DefeatureItem.cs) |
| `/platform/admin/namespaces/{namespace}/items/{itemId}/locale` | GET | GetLocaleItem | [GetLocaleItem](../../apis/AccelByte.Sdk.Api.Platform/Operation/Item/GetLocaleItem.cs) | [GetLocaleItem](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/GetLocaleItem.cs) |
| `/platform/admin/namespaces/{namespace}/items/{itemId}/purchase/condition` | PUT | UpdateItemPurchaseCondition | [UpdateItemPurchaseCondition](../../apis/AccelByte.Sdk.Api.Platform/Operation/Item/UpdateItemPurchaseCondition.cs) | [UpdateItemPurchaseCondition](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/UpdateItemPurchaseCondition.cs) |
| `/platform/admin/namespaces/{namespace}/items/{itemId}/return` | PUT | ReturnItem | [ReturnItem](../../apis/AccelByte.Sdk.Api.Platform/Operation/Item/ReturnItem.cs) | [ReturnItem](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/ReturnItem.cs) |
| `/platform/public/namespaces/{namespace}/items/byAppId` | GET | PublicGetItemByAppId | [PublicGetItemByAppId](../../apis/AccelByte.Sdk.Api.Platform/Operation/Item/PublicGetItemByAppId.cs) | [PublicGetItemByAppId](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/PublicGetItemByAppId.cs) |
| `/platform/public/namespaces/{namespace}/items/byCriteria` | GET | PublicQueryItems | [PublicQueryItems](../../apis/AccelByte.Sdk.Api.Platform/Operation/Item/PublicQueryItems.cs) | [PublicQueryItems](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/PublicQueryItems.cs) |
| `/platform/public/namespaces/{namespace}/items/bySku` | GET | PublicGetItemBySku | [PublicGetItemBySku](../../apis/AccelByte.Sdk.Api.Platform/Operation/Item/PublicGetItemBySku.cs) | [PublicGetItemBySku](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/PublicGetItemBySku.cs) |
| `/platform/public/namespaces/{namespace}/items/locale/byIds` | GET | PublicBulkGetItems | [PublicBulkGetItems](../../apis/AccelByte.Sdk.Api.Platform/Operation/Item/PublicBulkGetItems.cs) | [PublicBulkGetItems](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/PublicBulkGetItems.cs) |
| `/platform/public/namespaces/{namespace}/items/purchase/conditions/validate` | POST | PublicValidateItemPurchaseCondition | [PublicValidateItemPurchaseCondition](../../apis/AccelByte.Sdk.Api.Platform/Operation/Item/PublicValidateItemPurchaseCondition.cs) | [PublicValidateItemPurchaseCondition](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/PublicValidateItemPurchaseCondition.cs) |
| `/platform/public/namespaces/{namespace}/items/search` | GET | PublicSearchItems | [PublicSearchItems](../../apis/AccelByte.Sdk.Api.Platform/Operation/Item/PublicSearchItems.cs) | [PublicSearchItems](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/PublicSearchItems.cs) |
| `/platform/public/namespaces/{namespace}/items/{itemId}/app/locale` | GET | PublicGetApp | [PublicGetApp](../../apis/AccelByte.Sdk.Api.Platform/Operation/Item/PublicGetApp.cs) | [PublicGetApp](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/PublicGetApp.cs) |
| `/platform/public/namespaces/{namespace}/items/{itemId}/dynamic` | GET | PublicGetItemDynamicData | [PublicGetItemDynamicData](../../apis/AccelByte.Sdk.Api.Platform/Operation/Item/PublicGetItemDynamicData.cs) | [PublicGetItemDynamicData](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/PublicGetItemDynamicData.cs) |
| `/platform/public/namespaces/{namespace}/items/{itemId}/locale` | GET | PublicGetItem | [PublicGetItem](../../apis/AccelByte.Sdk.Api.Platform/Operation/Item/PublicGetItem.cs) | [PublicGetItem](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/PublicGetItem.cs) |
| `/platform/v2/admin/namespaces/{namespace}/items/byCriteria` | GET | QueryItems1 | [QueryItems1](../../apis/AccelByte.Sdk.Api.Platform/Operation/Item/QueryItems1.cs) | [QueryItems1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/QueryItems1.cs) |

### Campaign Wrapper:  [Campaign](../../apis/AccelByte.Sdk.Api.Platform/Wrapper/Campaign.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/namespaces/{namespace}/campaigns` | GET | QueryCampaigns | [QueryCampaigns](../../apis/AccelByte.Sdk.Api.Platform/Operation/Campaign/QueryCampaigns.cs) | [QueryCampaigns](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Campaign/QueryCampaigns.cs) |
| `/platform/admin/namespaces/{namespace}/campaigns` | POST | CreateCampaign | [CreateCampaign](../../apis/AccelByte.Sdk.Api.Platform/Operation/Campaign/CreateCampaign.cs) | [CreateCampaign](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Campaign/CreateCampaign.cs) |
| `/platform/admin/namespaces/{namespace}/campaigns/{campaignId}` | GET | GetCampaign | [GetCampaign](../../apis/AccelByte.Sdk.Api.Platform/Operation/Campaign/GetCampaign.cs) | [GetCampaign](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Campaign/GetCampaign.cs) |
| `/platform/admin/namespaces/{namespace}/campaigns/{campaignId}` | PUT | UpdateCampaign | [UpdateCampaign](../../apis/AccelByte.Sdk.Api.Platform/Operation/Campaign/UpdateCampaign.cs) | [UpdateCampaign](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Campaign/UpdateCampaign.cs) |
| `/platform/admin/namespaces/{namespace}/campaigns/{campaignId}/dynamic` | GET | GetCampaignDynamic | [GetCampaignDynamic](../../apis/AccelByte.Sdk.Api.Platform/Operation/Campaign/GetCampaignDynamic.cs) | [GetCampaignDynamic](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Campaign/GetCampaignDynamic.cs) |
| `/platform/admin/namespaces/{namespace}/codes/campaigns/{campaignId}` | GET | QueryCodes | [QueryCodes](../../apis/AccelByte.Sdk.Api.Platform/Operation/Campaign/QueryCodes.cs) | [QueryCodes](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Campaign/QueryCodes.cs) |
| `/platform/admin/namespaces/{namespace}/codes/campaigns/{campaignId}` | POST | CreateCodes | [CreateCodes](../../apis/AccelByte.Sdk.Api.Platform/Operation/Campaign/CreateCodes.cs) | [CreateCodes](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Campaign/CreateCodes.cs) |
| `/platform/admin/namespaces/{namespace}/codes/campaigns/{campaignId}/codes.csv` | GET | Download | [Download](../../apis/AccelByte.Sdk.Api.Platform/Operation/Campaign/Download.cs) | [Download](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Campaign/Download.cs) |
| `/platform/admin/namespaces/{namespace}/codes/campaigns/{campaignId}/disable/bulk` | PUT | BulkDisableCodes | [BulkDisableCodes](../../apis/AccelByte.Sdk.Api.Platform/Operation/Campaign/BulkDisableCodes.cs) | [BulkDisableCodes](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Campaign/BulkDisableCodes.cs) |
| `/platform/admin/namespaces/{namespace}/codes/campaigns/{campaignId}/enable/bulk` | PUT | BulkEnableCodes | [BulkEnableCodes](../../apis/AccelByte.Sdk.Api.Platform/Operation/Campaign/BulkEnableCodes.cs) | [BulkEnableCodes](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Campaign/BulkEnableCodes.cs) |
| `/platform/admin/namespaces/{namespace}/codes/campaigns/{campaignId}/history` | GET | QueryRedeemHistory | [QueryRedeemHistory](../../apis/AccelByte.Sdk.Api.Platform/Operation/Campaign/QueryRedeemHistory.cs) | [QueryRedeemHistory](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Campaign/QueryRedeemHistory.cs) |
| `/platform/admin/namespaces/{namespace}/codes/{code}` | GET | GetCode | [GetCode](../../apis/AccelByte.Sdk.Api.Platform/Operation/Campaign/GetCode.cs) | [GetCode](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Campaign/GetCode.cs) |
| `/platform/admin/namespaces/{namespace}/codes/{code}/disable` | PUT | DisableCode | [DisableCode](../../apis/AccelByte.Sdk.Api.Platform/Operation/Campaign/DisableCode.cs) | [DisableCode](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Campaign/DisableCode.cs) |
| `/platform/admin/namespaces/{namespace}/codes/{code}/enable` | PUT | EnableCode | [EnableCode](../../apis/AccelByte.Sdk.Api.Platform/Operation/Campaign/EnableCode.cs) | [EnableCode](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Campaign/EnableCode.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/redemption` | POST | ApplyUserRedemption | [ApplyUserRedemption](../../apis/AccelByte.Sdk.Api.Platform/Operation/Campaign/ApplyUserRedemption.cs) | [ApplyUserRedemption](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Campaign/ApplyUserRedemption.cs) |

### ServicePluginConfig Wrapper:  [ServicePluginConfig](../../apis/AccelByte.Sdk.Api.Platform/Wrapper/ServicePluginConfig.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/namespaces/{namespace}/catalog/plugins/lootbox` | GET | GetLootBoxPluginConfig | [GetLootBoxPluginConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/ServicePluginConfig/GetLootBoxPluginConfig.cs) | [GetLootBoxPluginConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/ServicePluginConfig/GetLootBoxPluginConfig.cs) |
| `/platform/admin/namespaces/{namespace}/catalog/plugins/lootbox` | PUT | UpdateLootBoxPluginConfig | [UpdateLootBoxPluginConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/ServicePluginConfig/UpdateLootBoxPluginConfig.cs) | [UpdateLootBoxPluginConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/ServicePluginConfig/UpdateLootBoxPluginConfig.cs) |
| `/platform/admin/namespaces/{namespace}/catalog/plugins/lootbox` | DELETE | DeleteLootBoxPluginConfig | [DeleteLootBoxPluginConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/ServicePluginConfig/DeleteLootBoxPluginConfig.cs) | [DeleteLootBoxPluginConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/ServicePluginConfig/DeleteLootBoxPluginConfig.cs) |
| `/platform/admin/namespaces/{namespace}/catalog/plugins/lootbox/customConfig/cert` | PUT | UplodLootBoxPluginConfigCert | [UplodLootBoxPluginConfigCert](../../apis/AccelByte.Sdk.Api.Platform/Operation/ServicePluginConfig/UplodLootBoxPluginConfigCert.cs) | [UplodLootBoxPluginConfigCert](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/ServicePluginConfig/UplodLootBoxPluginConfigCert.cs) |
| `/platform/admin/namespaces/{namespace}/catalog/plugins/lootbox/grpcInfo` | GET | GetLootBoxGrpcInfo | [GetLootBoxGrpcInfo](../../apis/AccelByte.Sdk.Api.Platform/Operation/ServicePluginConfig/GetLootBoxGrpcInfo.cs) | [GetLootBoxGrpcInfo](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/ServicePluginConfig/GetLootBoxGrpcInfo.cs) |
| `/platform/admin/namespaces/{namespace}/catalog/plugins/section` | GET | GetSectionPluginConfig | [GetSectionPluginConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/ServicePluginConfig/GetSectionPluginConfig.cs) | [GetSectionPluginConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/ServicePluginConfig/GetSectionPluginConfig.cs) |
| `/platform/admin/namespaces/{namespace}/catalog/plugins/section` | PUT | UpdateSectionPluginConfig | [UpdateSectionPluginConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/ServicePluginConfig/UpdateSectionPluginConfig.cs) | [UpdateSectionPluginConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/ServicePluginConfig/UpdateSectionPluginConfig.cs) |
| `/platform/admin/namespaces/{namespace}/catalog/plugins/section` | DELETE | DeleteSectionPluginConfig | [DeleteSectionPluginConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/ServicePluginConfig/DeleteSectionPluginConfig.cs) | [DeleteSectionPluginConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/ServicePluginConfig/DeleteSectionPluginConfig.cs) |
| `/platform/admin/namespaces/{namespace}/catalog/plugins/section/customConfig/cert` | PUT | UploadSectionPluginConfigCert | [UploadSectionPluginConfigCert](../../apis/AccelByte.Sdk.Api.Platform/Operation/ServicePluginConfig/UploadSectionPluginConfigCert.cs) | [UploadSectionPluginConfigCert](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/ServicePluginConfig/UploadSectionPluginConfigCert.cs) |
| [DEPRECATED] `/platform/admin/namespaces/{namespace}/configs/servicePlugin` | GET | GetServicePluginConfig | [GetServicePluginConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/ServicePluginConfig/GetServicePluginConfig.cs) | [GetServicePluginConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/ServicePluginConfig/GetServicePluginConfig.cs) |
| [DEPRECATED] `/platform/admin/namespaces/{namespace}/configs/servicePlugin` | PUT | UpdateServicePluginConfig | [UpdateServicePluginConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/ServicePluginConfig/UpdateServicePluginConfig.cs) | [UpdateServicePluginConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/ServicePluginConfig/UpdateServicePluginConfig.cs) |
| [DEPRECATED] `/platform/admin/namespaces/{namespace}/configs/servicePlugin` | DELETE | DeleteServicePluginConfig | [DeleteServicePluginConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/ServicePluginConfig/DeleteServicePluginConfig.cs) | [DeleteServicePluginConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/ServicePluginConfig/DeleteServicePluginConfig.cs) |
| `/platform/admin/namespaces/{namespace}/revocation/plugins/revocation` | GET | GetRevocationPluginConfig | [GetRevocationPluginConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/ServicePluginConfig/GetRevocationPluginConfig.cs) | [GetRevocationPluginConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/ServicePluginConfig/GetRevocationPluginConfig.cs) |
| `/platform/admin/namespaces/{namespace}/revocation/plugins/revocation` | PUT | UpdateRevocationPluginConfig | [UpdateRevocationPluginConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/ServicePluginConfig/UpdateRevocationPluginConfig.cs) | [UpdateRevocationPluginConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/ServicePluginConfig/UpdateRevocationPluginConfig.cs) |
| `/platform/admin/namespaces/{namespace}/revocation/plugins/revocation` | DELETE | DeleteRevocationPluginConfig | [DeleteRevocationPluginConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/ServicePluginConfig/DeleteRevocationPluginConfig.cs) | [DeleteRevocationPluginConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/ServicePluginConfig/DeleteRevocationPluginConfig.cs) |
| `/platform/admin/namespaces/{namespace}/revocation/plugins/revocation/revocation/customConfig/cert` | PUT | UploadRevocationPluginConfigCert | [UploadRevocationPluginConfigCert](../../apis/AccelByte.Sdk.Api.Platform/Operation/ServicePluginConfig/UploadRevocationPluginConfigCert.cs) | [UploadRevocationPluginConfigCert](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/ServicePluginConfig/UploadRevocationPluginConfigCert.cs) |

### Category Wrapper:  [Category](../../apis/AccelByte.Sdk.Api.Platform/Wrapper/Category.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/namespaces/{namespace}/categories` | GET | GetRootCategories | [GetRootCategories](../../apis/AccelByte.Sdk.Api.Platform/Operation/Category/GetRootCategories.cs) | [GetRootCategories](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Category/GetRootCategories.cs) |
| `/platform/admin/namespaces/{namespace}/categories` | POST | CreateCategory | [CreateCategory](../../apis/AccelByte.Sdk.Api.Platform/Operation/Category/CreateCategory.cs) | [CreateCategory](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Category/CreateCategory.cs) |
| `/platform/admin/namespaces/{namespace}/categories/basic` | GET | ListCategoriesBasic | [ListCategoriesBasic](../../apis/AccelByte.Sdk.Api.Platform/Operation/Category/ListCategoriesBasic.cs) | [ListCategoriesBasic](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Category/ListCategoriesBasic.cs) |
| `/platform/admin/namespaces/{namespace}/categories/{categoryPath}` | GET | GetCategory | [GetCategory](../../apis/AccelByte.Sdk.Api.Platform/Operation/Category/GetCategory.cs) | [GetCategory](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Category/GetCategory.cs) |
| `/platform/admin/namespaces/{namespace}/categories/{categoryPath}` | PUT | UpdateCategory | [UpdateCategory](../../apis/AccelByte.Sdk.Api.Platform/Operation/Category/UpdateCategory.cs) | [UpdateCategory](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Category/UpdateCategory.cs) |
| `/platform/admin/namespaces/{namespace}/categories/{categoryPath}` | DELETE | DeleteCategory | [DeleteCategory](../../apis/AccelByte.Sdk.Api.Platform/Operation/Category/DeleteCategory.cs) | [DeleteCategory](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Category/DeleteCategory.cs) |
| `/platform/admin/namespaces/{namespace}/categories/{categoryPath}/children` | GET | GetChildCategories | [GetChildCategories](../../apis/AccelByte.Sdk.Api.Platform/Operation/Category/GetChildCategories.cs) | [GetChildCategories](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Category/GetChildCategories.cs) |
| `/platform/admin/namespaces/{namespace}/categories/{categoryPath}/descendants` | GET | GetDescendantCategories | [GetDescendantCategories](../../apis/AccelByte.Sdk.Api.Platform/Operation/Category/GetDescendantCategories.cs) | [GetDescendantCategories](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Category/GetDescendantCategories.cs) |
| `/platform/public/namespaces/{namespace}/categories` | GET | PublicGetRootCategories | [PublicGetRootCategories](../../apis/AccelByte.Sdk.Api.Platform/Operation/Category/PublicGetRootCategories.cs) | [PublicGetRootCategories](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Category/PublicGetRootCategories.cs) |
| `/platform/public/namespaces/{namespace}/categories/download` | GET | DownloadCategories | [DownloadCategories](../../apis/AccelByte.Sdk.Api.Platform/Operation/Category/DownloadCategories.cs) | [DownloadCategories](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Category/DownloadCategories.cs) |
| `/platform/public/namespaces/{namespace}/categories/{categoryPath}` | GET | PublicGetCategory | [PublicGetCategory](../../apis/AccelByte.Sdk.Api.Platform/Operation/Category/PublicGetCategory.cs) | [PublicGetCategory](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Category/PublicGetCategory.cs) |
| `/platform/public/namespaces/{namespace}/categories/{categoryPath}/children` | GET | PublicGetChildCategories | [PublicGetChildCategories](../../apis/AccelByte.Sdk.Api.Platform/Operation/Category/PublicGetChildCategories.cs) | [PublicGetChildCategories](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Category/PublicGetChildCategories.cs) |
| `/platform/public/namespaces/{namespace}/categories/{categoryPath}/descendants` | GET | PublicGetDescendantCategories | [PublicGetDescendantCategories](../../apis/AccelByte.Sdk.Api.Platform/Operation/Category/PublicGetDescendantCategories.cs) | [PublicGetDescendantCategories](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Category/PublicGetDescendantCategories.cs) |

### Currency Wrapper:  [Currency](../../apis/AccelByte.Sdk.Api.Platform/Wrapper/Currency.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/namespaces/{namespace}/currencies` | GET | ListCurrencies | [ListCurrencies](../../apis/AccelByte.Sdk.Api.Platform/Operation/Currency/ListCurrencies.cs) | [ListCurrencies](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Currency/ListCurrencies.cs) |
| `/platform/admin/namespaces/{namespace}/currencies` | POST | CreateCurrency | [CreateCurrency](../../apis/AccelByte.Sdk.Api.Platform/Operation/Currency/CreateCurrency.cs) | [CreateCurrency](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Currency/CreateCurrency.cs) |
| `/platform/admin/namespaces/{namespace}/currencies/{currencyCode}` | PUT | UpdateCurrency | [UpdateCurrency](../../apis/AccelByte.Sdk.Api.Platform/Operation/Currency/UpdateCurrency.cs) | [UpdateCurrency](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Currency/UpdateCurrency.cs) |
| `/platform/admin/namespaces/{namespace}/currencies/{currencyCode}` | DELETE | DeleteCurrency | [DeleteCurrency](../../apis/AccelByte.Sdk.Api.Platform/Operation/Currency/DeleteCurrency.cs) | [DeleteCurrency](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Currency/DeleteCurrency.cs) |
| `/platform/admin/namespaces/{namespace}/currencies/{currencyCode}/config` | GET | GetCurrencyConfig | [GetCurrencyConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/Currency/GetCurrencyConfig.cs) | [GetCurrencyConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Currency/GetCurrencyConfig.cs) |
| `/platform/admin/namespaces/{namespace}/currencies/{currencyCode}/summary` | GET | GetCurrencySummary | [GetCurrencySummary](../../apis/AccelByte.Sdk.Api.Platform/Operation/Currency/GetCurrencySummary.cs) | [GetCurrencySummary](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Currency/GetCurrencySummary.cs) |
| `/platform/public/namespaces/{namespace}/currencies` | GET | PublicListCurrencies | [PublicListCurrencies](../../apis/AccelByte.Sdk.Api.Platform/Operation/Currency/PublicListCurrencies.cs) | [PublicListCurrencies](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Currency/PublicListCurrencies.cs) |

### DLC Wrapper:  [DLC](../../apis/AccelByte.Sdk.Api.Platform/Wrapper/DLC.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/namespaces/{namespace}/dlc/config/item` | GET | GetDLCItemConfig | [GetDLCItemConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/DLC/GetDLCItemConfig.cs) | [GetDLCItemConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/DLC/GetDLCItemConfig.cs) |
| `/platform/admin/namespaces/{namespace}/dlc/config/item` | PUT | UpdateDLCItemConfig | [UpdateDLCItemConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/DLC/UpdateDLCItemConfig.cs) | [UpdateDLCItemConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/DLC/UpdateDLCItemConfig.cs) |
| `/platform/admin/namespaces/{namespace}/dlc/config/item` | DELETE | DeleteDLCItemConfig | [DeleteDLCItemConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/DLC/DeleteDLCItemConfig.cs) | [DeleteDLCItemConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/DLC/DeleteDLCItemConfig.cs) |
| `/platform/admin/namespaces/{namespace}/dlc/config/platformMap` | GET | GetPlatformDLCConfig | [GetPlatformDLCConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/DLC/GetPlatformDLCConfig.cs) | [GetPlatformDLCConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/DLC/GetPlatformDLCConfig.cs) |
| `/platform/admin/namespaces/{namespace}/dlc/config/platformMap` | PUT | UpdatePlatformDLCConfig | [UpdatePlatformDLCConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/DLC/UpdatePlatformDLCConfig.cs) | [UpdatePlatformDLCConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/DLC/UpdatePlatformDLCConfig.cs) |
| `/platform/admin/namespaces/{namespace}/dlc/config/platformMap` | DELETE | DeletePlatformDLCConfig | [DeletePlatformDLCConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/DLC/DeletePlatformDLCConfig.cs) | [DeletePlatformDLCConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/DLC/DeletePlatformDLCConfig.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/dlc` | GET | GetUserDLCByPlatform | [GetUserDLCByPlatform](../../apis/AccelByte.Sdk.Api.Platform/Operation/DLC/GetUserDLCByPlatform.cs) | [GetUserDLCByPlatform](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/DLC/GetUserDLCByPlatform.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/dlc/records` | GET | GetUserDLC | [GetUserDLC](../../apis/AccelByte.Sdk.Api.Platform/Operation/DLC/GetUserDLC.cs) | [GetUserDLC](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/DLC/GetUserDLC.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/dlc/epicgames/sync` | PUT | SyncEpicGameDLC | [SyncEpicGameDLC](../../apis/AccelByte.Sdk.Api.Platform/Operation/DLC/SyncEpicGameDLC.cs) | [SyncEpicGameDLC](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/DLC/SyncEpicGameDLC.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/dlc/oculus/sync` | PUT | SyncOculusDLC | [SyncOculusDLC](../../apis/AccelByte.Sdk.Api.Platform/Operation/DLC/SyncOculusDLC.cs) | [SyncOculusDLC](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/DLC/SyncOculusDLC.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/dlc/psn/sync` | PUT | PublicSyncPsnDlcInventory | [PublicSyncPsnDlcInventory](../../apis/AccelByte.Sdk.Api.Platform/Operation/DLC/PublicSyncPsnDlcInventory.cs) | [PublicSyncPsnDlcInventory](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/DLC/PublicSyncPsnDlcInventory.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/dlc/psn/sync/multiServiceLabels` | PUT | PublicSyncPsnDlcInventoryWithMultipleServiceLabels | [PublicSyncPsnDlcInventoryWithMultipleServiceLabels](../../apis/AccelByte.Sdk.Api.Platform/Operation/DLC/PublicSyncPsnDlcInventoryWithMultipleServiceLabels.cs) | [PublicSyncPsnDlcInventoryWithMultipleServiceLabels](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/DLC/PublicSyncPsnDlcInventoryWithMultipleServiceLabels.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/dlc/steam/sync` | PUT | SyncSteamDLC | [SyncSteamDLC](../../apis/AccelByte.Sdk.Api.Platform/Operation/DLC/SyncSteamDLC.cs) | [SyncSteamDLC](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/DLC/SyncSteamDLC.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/dlc/xbl/sync` | PUT | SyncXboxDLC | [SyncXboxDLC](../../apis/AccelByte.Sdk.Api.Platform/Operation/DLC/SyncXboxDLC.cs) | [SyncXboxDLC](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/DLC/SyncXboxDLC.cs) |

### Entitlement Wrapper:  [Entitlement](../../apis/AccelByte.Sdk.Api.Platform/Wrapper/Entitlement.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/namespaces/{namespace}/entitlements` | GET | QueryEntitlements | [QueryEntitlements](../../apis/AccelByte.Sdk.Api.Platform/Operation/Entitlement/QueryEntitlements.cs) | [QueryEntitlements](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/QueryEntitlements.cs) |
| `/platform/admin/namespaces/{namespace}/entitlements/byItemIds` | GET | QueryEntitlements1 | [QueryEntitlements1](../../apis/AccelByte.Sdk.Api.Platform/Operation/Entitlement/QueryEntitlements1.cs) | [QueryEntitlements1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/QueryEntitlements1.cs) |
| `/platform/admin/namespaces/{namespace}/entitlements/grant` | POST | GrantEntitlements | [GrantEntitlements](../../apis/AccelByte.Sdk.Api.Platform/Operation/Entitlement/GrantEntitlements.cs) | [GrantEntitlements](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/GrantEntitlements.cs) |
| `/platform/admin/namespaces/{namespace}/entitlements/revoke` | POST | RevokeEntitlements | [RevokeEntitlements](../../apis/AccelByte.Sdk.Api.Platform/Operation/Entitlement/RevokeEntitlements.cs) | [RevokeEntitlements](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/RevokeEntitlements.cs) |
| `/platform/admin/namespaces/{namespace}/entitlements/{entitlementId}` | GET | GetEntitlement | [GetEntitlement](../../apis/AccelByte.Sdk.Api.Platform/Operation/Entitlement/GetEntitlement.cs) | [GetEntitlement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/GetEntitlement.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/entitlements` | GET | QueryUserEntitlements | [QueryUserEntitlements](../../apis/AccelByte.Sdk.Api.Platform/Operation/Entitlement/QueryUserEntitlements.cs) | [QueryUserEntitlements](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/QueryUserEntitlements.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/entitlements` | POST | GrantUserEntitlement | [GrantUserEntitlement](../../apis/AccelByte.Sdk.Api.Platform/Operation/Entitlement/GrantUserEntitlement.cs) | [GrantUserEntitlement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/GrantUserEntitlement.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/byAppId` | GET | GetUserAppEntitlementByAppId | [GetUserAppEntitlementByAppId](../../apis/AccelByte.Sdk.Api.Platform/Operation/Entitlement/GetUserAppEntitlementByAppId.cs) | [GetUserAppEntitlementByAppId](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/GetUserAppEntitlementByAppId.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/byAppType` | GET | QueryUserEntitlementsByAppType | [QueryUserEntitlementsByAppType](../../apis/AccelByte.Sdk.Api.Platform/Operation/Entitlement/QueryUserEntitlementsByAppType.cs) | [QueryUserEntitlementsByAppType](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/QueryUserEntitlementsByAppType.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/byItemId` | GET | GetUserEntitlementByItemId | [GetUserEntitlementByItemId](../../apis/AccelByte.Sdk.Api.Platform/Operation/Entitlement/GetUserEntitlementByItemId.cs) | [GetUserEntitlementByItemId](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/GetUserEntitlementByItemId.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/byItemIds` | GET | GetUserActiveEntitlementsByItemIds | [GetUserActiveEntitlementsByItemIds](../../apis/AccelByte.Sdk.Api.Platform/Operation/Entitlement/GetUserActiveEntitlementsByItemIds.cs) | [GetUserActiveEntitlementsByItemIds](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/GetUserActiveEntitlementsByItemIds.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/bySku` | GET | GetUserEntitlementBySku | [GetUserEntitlementBySku](../../apis/AccelByte.Sdk.Api.Platform/Operation/Entitlement/GetUserEntitlementBySku.cs) | [GetUserEntitlementBySku](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/GetUserEntitlementBySku.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/ownership/any` | GET | ExistsAnyUserActiveEntitlement | [ExistsAnyUserActiveEntitlement](../../apis/AccelByte.Sdk.Api.Platform/Operation/Entitlement/ExistsAnyUserActiveEntitlement.cs) | [ExistsAnyUserActiveEntitlement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/ExistsAnyUserActiveEntitlement.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/ownership/anyOf` | GET | ExistsAnyUserActiveEntitlementByItemIds | [ExistsAnyUserActiveEntitlementByItemIds](../../apis/AccelByte.Sdk.Api.Platform/Operation/Entitlement/ExistsAnyUserActiveEntitlementByItemIds.cs) | [ExistsAnyUserActiveEntitlementByItemIds](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/ExistsAnyUserActiveEntitlementByItemIds.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/ownership/byAppId` | GET | GetUserAppEntitlementOwnershipByAppId | [GetUserAppEntitlementOwnershipByAppId](../../apis/AccelByte.Sdk.Api.Platform/Operation/Entitlement/GetUserAppEntitlementOwnershipByAppId.cs) | [GetUserAppEntitlementOwnershipByAppId](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/GetUserAppEntitlementOwnershipByAppId.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/ownership/byItemId` | GET | GetUserEntitlementOwnershipByItemId | [GetUserEntitlementOwnershipByItemId](../../apis/AccelByte.Sdk.Api.Platform/Operation/Entitlement/GetUserEntitlementOwnershipByItemId.cs) | [GetUserEntitlementOwnershipByItemId](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/GetUserEntitlementOwnershipByItemId.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/ownership/byItemIds` | GET | GetUserEntitlementOwnershipByItemIds | [GetUserEntitlementOwnershipByItemIds](../../apis/AccelByte.Sdk.Api.Platform/Operation/Entitlement/GetUserEntitlementOwnershipByItemIds.cs) | [GetUserEntitlementOwnershipByItemIds](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/GetUserEntitlementOwnershipByItemIds.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/ownership/bySku` | GET | GetUserEntitlementOwnershipBySku | [GetUserEntitlementOwnershipBySku](../../apis/AccelByte.Sdk.Api.Platform/Operation/Entitlement/GetUserEntitlementOwnershipBySku.cs) | [GetUserEntitlementOwnershipBySku](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/GetUserEntitlementOwnershipBySku.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/revoke` | PUT | RevokeAllEntitlements | [RevokeAllEntitlements](../../apis/AccelByte.Sdk.Api.Platform/Operation/Entitlement/RevokeAllEntitlements.cs) | [RevokeAllEntitlements](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/RevokeAllEntitlements.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/revoke/byIds` | PUT | RevokeUserEntitlements | [RevokeUserEntitlements](../../apis/AccelByte.Sdk.Api.Platform/Operation/Entitlement/RevokeUserEntitlements.cs) | [RevokeUserEntitlements](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/RevokeUserEntitlements.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId}` | GET | GetUserEntitlement | [GetUserEntitlement](../../apis/AccelByte.Sdk.Api.Platform/Operation/Entitlement/GetUserEntitlement.cs) | [GetUserEntitlement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/GetUserEntitlement.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId}` | PUT | UpdateUserEntitlement | [UpdateUserEntitlement](../../apis/AccelByte.Sdk.Api.Platform/Operation/Entitlement/UpdateUserEntitlement.cs) | [UpdateUserEntitlement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/UpdateUserEntitlement.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId}/decrement` | PUT | ConsumeUserEntitlement | [ConsumeUserEntitlement](../../apis/AccelByte.Sdk.Api.Platform/Operation/Entitlement/ConsumeUserEntitlement.cs) | [ConsumeUserEntitlement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/ConsumeUserEntitlement.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId}/disable` | PUT | DisableUserEntitlement | [DisableUserEntitlement](../../apis/AccelByte.Sdk.Api.Platform/Operation/Entitlement/DisableUserEntitlement.cs) | [DisableUserEntitlement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/DisableUserEntitlement.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId}/enable` | PUT | EnableUserEntitlement | [EnableUserEntitlement](../../apis/AccelByte.Sdk.Api.Platform/Operation/Entitlement/EnableUserEntitlement.cs) | [EnableUserEntitlement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/EnableUserEntitlement.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId}/history` | GET | GetUserEntitlementHistories | [GetUserEntitlementHistories](../../apis/AccelByte.Sdk.Api.Platform/Operation/Entitlement/GetUserEntitlementHistories.cs) | [GetUserEntitlementHistories](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/GetUserEntitlementHistories.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId}/revoke` | PUT | RevokeUserEntitlement | [RevokeUserEntitlement](../../apis/AccelByte.Sdk.Api.Platform/Operation/Entitlement/RevokeUserEntitlement.cs) | [RevokeUserEntitlement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/RevokeUserEntitlement.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId}/revokeByUseCount` | PUT | RevokeUseCount | [RevokeUseCount](../../apis/AccelByte.Sdk.Api.Platform/Operation/Entitlement/RevokeUseCount.cs) | [RevokeUseCount](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/RevokeUseCount.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId}/sell` | PUT | SellUserEntitlement | [SellUserEntitlement](../../apis/AccelByte.Sdk.Api.Platform/Operation/Entitlement/SellUserEntitlement.cs) | [SellUserEntitlement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/SellUserEntitlement.cs) |
| `/platform/public/namespaces/{namespace}/users/me/entitlements/ownership/any` | GET | PublicExistsAnyMyActiveEntitlement | [PublicExistsAnyMyActiveEntitlement](../../apis/AccelByte.Sdk.Api.Platform/Operation/Entitlement/PublicExistsAnyMyActiveEntitlement.cs) | [PublicExistsAnyMyActiveEntitlement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/PublicExistsAnyMyActiveEntitlement.cs) |
| `/platform/public/namespaces/{namespace}/users/me/entitlements/ownership/byAppId` | GET | PublicGetMyAppEntitlementOwnershipByAppId | [PublicGetMyAppEntitlementOwnershipByAppId](../../apis/AccelByte.Sdk.Api.Platform/Operation/Entitlement/PublicGetMyAppEntitlementOwnershipByAppId.cs) | [PublicGetMyAppEntitlementOwnershipByAppId](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/PublicGetMyAppEntitlementOwnershipByAppId.cs) |
| `/platform/public/namespaces/{namespace}/users/me/entitlements/ownership/byItemId` | GET | PublicGetMyEntitlementOwnershipByItemId | [PublicGetMyEntitlementOwnershipByItemId](../../apis/AccelByte.Sdk.Api.Platform/Operation/Entitlement/PublicGetMyEntitlementOwnershipByItemId.cs) | [PublicGetMyEntitlementOwnershipByItemId](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/PublicGetMyEntitlementOwnershipByItemId.cs) |
| `/platform/public/namespaces/{namespace}/users/me/entitlements/ownership/bySku` | GET | PublicGetMyEntitlementOwnershipBySku | [PublicGetMyEntitlementOwnershipBySku](../../apis/AccelByte.Sdk.Api.Platform/Operation/Entitlement/PublicGetMyEntitlementOwnershipBySku.cs) | [PublicGetMyEntitlementOwnershipBySku](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/PublicGetMyEntitlementOwnershipBySku.cs) |
| `/platform/public/namespaces/{namespace}/users/me/entitlements/ownershipToken` | GET | PublicGetEntitlementOwnershipToken | [PublicGetEntitlementOwnershipToken](../../apis/AccelByte.Sdk.Api.Platform/Operation/Entitlement/PublicGetEntitlementOwnershipToken.cs) | [PublicGetEntitlementOwnershipToken](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/PublicGetEntitlementOwnershipToken.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/entitlements` | GET | PublicQueryUserEntitlements | [PublicQueryUserEntitlements](../../apis/AccelByte.Sdk.Api.Platform/Operation/Entitlement/PublicQueryUserEntitlements.cs) | [PublicQueryUserEntitlements](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/PublicQueryUserEntitlements.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/entitlements/byAppId` | GET | PublicGetUserAppEntitlementByAppId | [PublicGetUserAppEntitlementByAppId](../../apis/AccelByte.Sdk.Api.Platform/Operation/Entitlement/PublicGetUserAppEntitlementByAppId.cs) | [PublicGetUserAppEntitlementByAppId](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/PublicGetUserAppEntitlementByAppId.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/entitlements/byAppType` | GET | PublicQueryUserEntitlementsByAppType | [PublicQueryUserEntitlementsByAppType](../../apis/AccelByte.Sdk.Api.Platform/Operation/Entitlement/PublicQueryUserEntitlementsByAppType.cs) | [PublicQueryUserEntitlementsByAppType](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/PublicQueryUserEntitlementsByAppType.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/entitlements/byItemId` | GET | PublicGetUserEntitlementByItemId | [PublicGetUserEntitlementByItemId](../../apis/AccelByte.Sdk.Api.Platform/Operation/Entitlement/PublicGetUserEntitlementByItemId.cs) | [PublicGetUserEntitlementByItemId](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/PublicGetUserEntitlementByItemId.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/entitlements/bySku` | GET | PublicGetUserEntitlementBySku | [PublicGetUserEntitlementBySku](../../apis/AccelByte.Sdk.Api.Platform/Operation/Entitlement/PublicGetUserEntitlementBySku.cs) | [PublicGetUserEntitlementBySku](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/PublicGetUserEntitlementBySku.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/entitlements/ownership/any` | GET | PublicExistsAnyUserActiveEntitlement | [PublicExistsAnyUserActiveEntitlement](../../apis/AccelByte.Sdk.Api.Platform/Operation/Entitlement/PublicExistsAnyUserActiveEntitlement.cs) | [PublicExistsAnyUserActiveEntitlement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/PublicExistsAnyUserActiveEntitlement.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/entitlements/ownership/byAppId` | GET | PublicGetUserAppEntitlementOwnershipByAppId | [PublicGetUserAppEntitlementOwnershipByAppId](../../apis/AccelByte.Sdk.Api.Platform/Operation/Entitlement/PublicGetUserAppEntitlementOwnershipByAppId.cs) | [PublicGetUserAppEntitlementOwnershipByAppId](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/PublicGetUserAppEntitlementOwnershipByAppId.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/entitlements/ownership/byItemId` | GET | PublicGetUserEntitlementOwnershipByItemId | [PublicGetUserEntitlementOwnershipByItemId](../../apis/AccelByte.Sdk.Api.Platform/Operation/Entitlement/PublicGetUserEntitlementOwnershipByItemId.cs) | [PublicGetUserEntitlementOwnershipByItemId](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/PublicGetUserEntitlementOwnershipByItemId.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/entitlements/ownership/byItemIds` | GET | PublicGetUserEntitlementOwnershipByItemIds | [PublicGetUserEntitlementOwnershipByItemIds](../../apis/AccelByte.Sdk.Api.Platform/Operation/Entitlement/PublicGetUserEntitlementOwnershipByItemIds.cs) | [PublicGetUserEntitlementOwnershipByItemIds](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/PublicGetUserEntitlementOwnershipByItemIds.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/entitlements/ownership/bySku` | GET | PublicGetUserEntitlementOwnershipBySku | [PublicGetUserEntitlementOwnershipBySku](../../apis/AccelByte.Sdk.Api.Platform/Operation/Entitlement/PublicGetUserEntitlementOwnershipBySku.cs) | [PublicGetUserEntitlementOwnershipBySku](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/PublicGetUserEntitlementOwnershipBySku.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId}` | GET | PublicGetUserEntitlement | [PublicGetUserEntitlement](../../apis/AccelByte.Sdk.Api.Platform/Operation/Entitlement/PublicGetUserEntitlement.cs) | [PublicGetUserEntitlement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/PublicGetUserEntitlement.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId}/decrement` | PUT | PublicConsumeUserEntitlement | [PublicConsumeUserEntitlement](../../apis/AccelByte.Sdk.Api.Platform/Operation/Entitlement/PublicConsumeUserEntitlement.cs) | [PublicConsumeUserEntitlement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/PublicConsumeUserEntitlement.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId}/sell` | PUT | PublicSellUserEntitlement | [PublicSellUserEntitlement](../../apis/AccelByte.Sdk.Api.Platform/Operation/Entitlement/PublicSellUserEntitlement.cs) | [PublicSellUserEntitlement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/PublicSellUserEntitlement.cs) |

### Fulfillment Wrapper:  [Fulfillment](../../apis/AccelByte.Sdk.Api.Platform/Wrapper/Fulfillment.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/namespaces/{namespace}/fulfillment/history` | GET | QueryFulfillmentHistories | [QueryFulfillmentHistories](../../apis/AccelByte.Sdk.Api.Platform/Operation/Fulfillment/QueryFulfillmentHistories.cs) | [QueryFulfillmentHistories](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Fulfillment/QueryFulfillmentHistories.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/fulfillment` | POST | FulfillItem | [FulfillItem](../../apis/AccelByte.Sdk.Api.Platform/Operation/Fulfillment/FulfillItem.cs) | [FulfillItem](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Fulfillment/FulfillItem.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/fulfillment/code` | POST | RedeemCode | [RedeemCode](../../apis/AccelByte.Sdk.Api.Platform/Operation/Fulfillment/RedeemCode.cs) | [RedeemCode](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Fulfillment/RedeemCode.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/fulfillment/rewards` | POST | FulfillRewards | [FulfillRewards](../../apis/AccelByte.Sdk.Api.Platform/Operation/Fulfillment/FulfillRewards.cs) | [FulfillRewards](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Fulfillment/FulfillRewards.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/fulfillment/code` | POST | PublicRedeemCode | [PublicRedeemCode](../../apis/AccelByte.Sdk.Api.Platform/Operation/Fulfillment/PublicRedeemCode.cs) | [PublicRedeemCode](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Fulfillment/PublicRedeemCode.cs) |
| `/platform/v2/admin/namespaces/{namespace}/users/{userId}/fulfillment/rewards` | POST | FulfillRewardsV2 | [FulfillRewardsV2](../../apis/AccelByte.Sdk.Api.Platform/Operation/Fulfillment/FulfillRewardsV2.cs) | [FulfillRewardsV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Fulfillment/FulfillRewardsV2.cs) |

### Clawback Wrapper:  [Clawback](../../apis/AccelByte.Sdk.Api.Platform/Wrapper/Clawback.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/namespaces/{namespace}/iap/clawback/histories` | GET | QueryIAPClawbackHistory | [QueryIAPClawbackHistory](../../apis/AccelByte.Sdk.Api.Platform/Operation/Clawback/QueryIAPClawbackHistory.cs) | [QueryIAPClawbackHistory](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Clawback/QueryIAPClawbackHistory.cs) |
| `/platform/admin/namespaces/{namespace}/iap/clawback/playstation/mock` | POST | MockPlayStationStreamEvent | [MockPlayStationStreamEvent](../../apis/AccelByte.Sdk.Api.Platform/Operation/Clawback/MockPlayStationStreamEvent.cs) | [MockPlayStationStreamEvent](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Clawback/MockPlayStationStreamEvent.cs) |

### IAP Wrapper:  [IAP](../../apis/AccelByte.Sdk.Api.Platform/Wrapper/IAP.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/namespaces/{namespace}/iap/config/apple` | GET | GetAppleIAPConfig | [GetAppleIAPConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/IAP/GetAppleIAPConfig.cs) | [GetAppleIAPConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/GetAppleIAPConfig.cs) |
| `/platform/admin/namespaces/{namespace}/iap/config/apple` | PUT | UpdateAppleIAPConfig | [UpdateAppleIAPConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/IAP/UpdateAppleIAPConfig.cs) | [UpdateAppleIAPConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/UpdateAppleIAPConfig.cs) |
| `/platform/admin/namespaces/{namespace}/iap/config/apple` | DELETE | DeleteAppleIAPConfig | [DeleteAppleIAPConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/IAP/DeleteAppleIAPConfig.cs) | [DeleteAppleIAPConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/DeleteAppleIAPConfig.cs) |
| `/platform/admin/namespaces/{namespace}/iap/config/epicgames` | GET | GetEpicGamesIAPConfig | [GetEpicGamesIAPConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/IAP/GetEpicGamesIAPConfig.cs) | [GetEpicGamesIAPConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/GetEpicGamesIAPConfig.cs) |
| `/platform/admin/namespaces/{namespace}/iap/config/epicgames` | PUT | UpdateEpicGamesIAPConfig | [UpdateEpicGamesIAPConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/IAP/UpdateEpicGamesIAPConfig.cs) | [UpdateEpicGamesIAPConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/UpdateEpicGamesIAPConfig.cs) |
| `/platform/admin/namespaces/{namespace}/iap/config/epicgames` | DELETE | DeleteEpicGamesIAPConfig | [DeleteEpicGamesIAPConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/IAP/DeleteEpicGamesIAPConfig.cs) | [DeleteEpicGamesIAPConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/DeleteEpicGamesIAPConfig.cs) |
| `/platform/admin/namespaces/{namespace}/iap/config/google` | GET | GetGoogleIAPConfig | [GetGoogleIAPConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/IAP/GetGoogleIAPConfig.cs) | [GetGoogleIAPConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/GetGoogleIAPConfig.cs) |
| `/platform/admin/namespaces/{namespace}/iap/config/google` | PUT | UpdateGoogleIAPConfig | [UpdateGoogleIAPConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/IAP/UpdateGoogleIAPConfig.cs) | [UpdateGoogleIAPConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/UpdateGoogleIAPConfig.cs) |
| `/platform/admin/namespaces/{namespace}/iap/config/google` | DELETE | DeleteGoogleIAPConfig | [DeleteGoogleIAPConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/IAP/DeleteGoogleIAPConfig.cs) | [DeleteGoogleIAPConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/DeleteGoogleIAPConfig.cs) |
| `/platform/admin/namespaces/{namespace}/iap/config/google/cert` | PUT | UpdateGoogleP12File | [UpdateGoogleP12File](../../apis/AccelByte.Sdk.Api.Platform/Operation/IAP/UpdateGoogleP12File.cs) | [UpdateGoogleP12File](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/UpdateGoogleP12File.cs) |
| `/platform/admin/namespaces/{namespace}/iap/config/item` | GET | GetIAPItemConfig | [GetIAPItemConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/IAP/GetIAPItemConfig.cs) | [GetIAPItemConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/GetIAPItemConfig.cs) |
| `/platform/admin/namespaces/{namespace}/iap/config/item` | PUT | UpdateIAPItemConfig | [UpdateIAPItemConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/IAP/UpdateIAPItemConfig.cs) | [UpdateIAPItemConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/UpdateIAPItemConfig.cs) |
| `/platform/admin/namespaces/{namespace}/iap/config/item` | DELETE | DeleteIAPItemConfig | [DeleteIAPItemConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/IAP/DeleteIAPItemConfig.cs) | [DeleteIAPItemConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/DeleteIAPItemConfig.cs) |
| `/platform/admin/namespaces/{namespace}/iap/config/oculus` | GET | GetOculusIAPConfig | [GetOculusIAPConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/IAP/GetOculusIAPConfig.cs) | [GetOculusIAPConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/GetOculusIAPConfig.cs) |
| `/platform/admin/namespaces/{namespace}/iap/config/oculus` | PUT | UpdateOculusIAPConfig | [UpdateOculusIAPConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/IAP/UpdateOculusIAPConfig.cs) | [UpdateOculusIAPConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/UpdateOculusIAPConfig.cs) |
| `/platform/admin/namespaces/{namespace}/iap/config/oculus` | DELETE | DeleteOculusIAPConfig | [DeleteOculusIAPConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/IAP/DeleteOculusIAPConfig.cs) | [DeleteOculusIAPConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/DeleteOculusIAPConfig.cs) |
| `/platform/admin/namespaces/{namespace}/iap/config/playstation` | GET | GetPlayStationIAPConfig | [GetPlayStationIAPConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/IAP/GetPlayStationIAPConfig.cs) | [GetPlayStationIAPConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/GetPlayStationIAPConfig.cs) |
| `/platform/admin/namespaces/{namespace}/iap/config/playstation` | PUT | UpdatePlaystationIAPConfig | [UpdatePlaystationIAPConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/IAP/UpdatePlaystationIAPConfig.cs) | [UpdatePlaystationIAPConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/UpdatePlaystationIAPConfig.cs) |
| `/platform/admin/namespaces/{namespace}/iap/config/playstation` | DELETE | DeletePlaystationIAPConfig | [DeletePlaystationIAPConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/IAP/DeletePlaystationIAPConfig.cs) | [DeletePlaystationIAPConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/DeletePlaystationIAPConfig.cs) |
| `/platform/admin/namespaces/{namespace}/iap/config/playstation/validate` | GET | ValidateExistedPlaystationIAPConfig | [ValidateExistedPlaystationIAPConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/IAP/ValidateExistedPlaystationIAPConfig.cs) | [ValidateExistedPlaystationIAPConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/ValidateExistedPlaystationIAPConfig.cs) |
| `/platform/admin/namespaces/{namespace}/iap/config/playstation/validate` | PUT | ValidatePlaystationIAPConfig | [ValidatePlaystationIAPConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/IAP/ValidatePlaystationIAPConfig.cs) | [ValidatePlaystationIAPConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/ValidatePlaystationIAPConfig.cs) |
| `/platform/admin/namespaces/{namespace}/iap/config/steam` | GET | GetSteamIAPConfig | [GetSteamIAPConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/IAP/GetSteamIAPConfig.cs) | [GetSteamIAPConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/GetSteamIAPConfig.cs) |
| `/platform/admin/namespaces/{namespace}/iap/config/steam` | PUT | UpdateSteamIAPConfig | [UpdateSteamIAPConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/IAP/UpdateSteamIAPConfig.cs) | [UpdateSteamIAPConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/UpdateSteamIAPConfig.cs) |
| `/platform/admin/namespaces/{namespace}/iap/config/steam` | DELETE | DeleteSteamIAPConfig | [DeleteSteamIAPConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/IAP/DeleteSteamIAPConfig.cs) | [DeleteSteamIAPConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/DeleteSteamIAPConfig.cs) |
| `/platform/admin/namespaces/{namespace}/iap/config/twitch` | GET | GetTwitchIAPConfig | [GetTwitchIAPConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/IAP/GetTwitchIAPConfig.cs) | [GetTwitchIAPConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/GetTwitchIAPConfig.cs) |
| `/platform/admin/namespaces/{namespace}/iap/config/twitch` | PUT | UpdateTwitchIAPConfig | [UpdateTwitchIAPConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/IAP/UpdateTwitchIAPConfig.cs) | [UpdateTwitchIAPConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/UpdateTwitchIAPConfig.cs) |
| `/platform/admin/namespaces/{namespace}/iap/config/twitch` | DELETE | DeleteTwitchIAPConfig | [DeleteTwitchIAPConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/IAP/DeleteTwitchIAPConfig.cs) | [DeleteTwitchIAPConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/DeleteTwitchIAPConfig.cs) |
| `/platform/admin/namespaces/{namespace}/iap/config/xbl` | GET | GetXblIAPConfig | [GetXblIAPConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/IAP/GetXblIAPConfig.cs) | [GetXblIAPConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/GetXblIAPConfig.cs) |
| `/platform/admin/namespaces/{namespace}/iap/config/xbl` | PUT | UpdateXblIAPConfig | [UpdateXblIAPConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/IAP/UpdateXblIAPConfig.cs) | [UpdateXblIAPConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/UpdateXblIAPConfig.cs) |
| `/platform/admin/namespaces/{namespace}/iap/config/xbl` | DELETE | DeleteXblAPConfig | [DeleteXblAPConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/IAP/DeleteXblAPConfig.cs) | [DeleteXblAPConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/DeleteXblAPConfig.cs) |
| `/platform/admin/namespaces/{namespace}/iap/config/xbl/cert` | PUT | UpdateXblBPCertFile | [UpdateXblBPCertFile](../../apis/AccelByte.Sdk.Api.Platform/Operation/IAP/UpdateXblBPCertFile.cs) | [UpdateXblBPCertFile](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/UpdateXblBPCertFile.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/iap` | GET | QueryUserIAPOrders | [QueryUserIAPOrders](../../apis/AccelByte.Sdk.Api.Platform/Operation/IAP/QueryUserIAPOrders.cs) | [QueryUserIAPOrders](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/QueryUserIAPOrders.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/iap/all` | GET | QueryAllUserIAPOrders | [QueryAllUserIAPOrders](../../apis/AccelByte.Sdk.Api.Platform/Operation/IAP/QueryAllUserIAPOrders.cs) | [QueryAllUserIAPOrders](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/QueryAllUserIAPOrders.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/iap/consume/history` | GET | QueryUserIAPConsumeHistory | [QueryUserIAPConsumeHistory](../../apis/AccelByte.Sdk.Api.Platform/Operation/IAP/QueryUserIAPConsumeHistory.cs) | [QueryUserIAPConsumeHistory](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/QueryUserIAPConsumeHistory.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/iap/mock/receipt` | PUT | MockFulfillIAPItem | [MockFulfillIAPItem](../../apis/AccelByte.Sdk.Api.Platform/Operation/IAP/MockFulfillIAPItem.cs) | [MockFulfillIAPItem](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/MockFulfillIAPItem.cs) |
| `/platform/public/namespaces/{namespace}/iap/item/mapping` | GET | GetIAPItemMapping | [GetIAPItemMapping](../../apis/AccelByte.Sdk.Api.Platform/Operation/IAP/GetIAPItemMapping.cs) | [GetIAPItemMapping](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/GetIAPItemMapping.cs) |
| `/platform/public/namespaces/{namespace}/users/me/iap/twitch/sync` | PUT | SyncTwitchDropsEntitlement | [SyncTwitchDropsEntitlement](../../apis/AccelByte.Sdk.Api.Platform/Operation/IAP/SyncTwitchDropsEntitlement.cs) | [SyncTwitchDropsEntitlement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/SyncTwitchDropsEntitlement.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/iap/apple/receipt` | PUT | PublicFulfillAppleIAPItem | [PublicFulfillAppleIAPItem](../../apis/AccelByte.Sdk.Api.Platform/Operation/IAP/PublicFulfillAppleIAPItem.cs) | [PublicFulfillAppleIAPItem](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/PublicFulfillAppleIAPItem.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/iap/epicgames/sync` | PUT | SyncEpicGamesInventory | [SyncEpicGamesInventory](../../apis/AccelByte.Sdk.Api.Platform/Operation/IAP/SyncEpicGamesInventory.cs) | [SyncEpicGamesInventory](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/SyncEpicGamesInventory.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/iap/google/receipt` | PUT | PublicFulfillGoogleIAPItem | [PublicFulfillGoogleIAPItem](../../apis/AccelByte.Sdk.Api.Platform/Operation/IAP/PublicFulfillGoogleIAPItem.cs) | [PublicFulfillGoogleIAPItem](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/PublicFulfillGoogleIAPItem.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/iap/oculus/sync` | PUT | SyncOculusConsumableEntitlements | [SyncOculusConsumableEntitlements](../../apis/AccelByte.Sdk.Api.Platform/Operation/IAP/SyncOculusConsumableEntitlements.cs) | [SyncOculusConsumableEntitlements](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/SyncOculusConsumableEntitlements.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/iap/psn/sync` | PUT | PublicReconcilePlayStationStore | [PublicReconcilePlayStationStore](../../apis/AccelByte.Sdk.Api.Platform/Operation/IAP/PublicReconcilePlayStationStore.cs) | [PublicReconcilePlayStationStore](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/PublicReconcilePlayStationStore.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/iap/psn/sync/multiServiceLabels` | PUT | PublicReconcilePlayStationStoreWithMultipleServiceLabels | [PublicReconcilePlayStationStoreWithMultipleServiceLabels](../../apis/AccelByte.Sdk.Api.Platform/Operation/IAP/PublicReconcilePlayStationStoreWithMultipleServiceLabels.cs) | [PublicReconcilePlayStationStoreWithMultipleServiceLabels](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/PublicReconcilePlayStationStoreWithMultipleServiceLabels.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/iap/steam/sync` | PUT | SyncSteamInventory | [SyncSteamInventory](../../apis/AccelByte.Sdk.Api.Platform/Operation/IAP/SyncSteamInventory.cs) | [SyncSteamInventory](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/SyncSteamInventory.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/iap/twitch/sync` | PUT | SyncTwitchDropsEntitlement1 | [SyncTwitchDropsEntitlement1](../../apis/AccelByte.Sdk.Api.Platform/Operation/IAP/SyncTwitchDropsEntitlement1.cs) | [SyncTwitchDropsEntitlement1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/SyncTwitchDropsEntitlement1.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/iap/xbl/sync` | PUT | SyncXboxInventory | [SyncXboxInventory](../../apis/AccelByte.Sdk.Api.Platform/Operation/IAP/SyncXboxInventory.cs) | [SyncXboxInventory](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/SyncXboxInventory.cs) |

### Invoice Wrapper:  [Invoice](../../apis/AccelByte.Sdk.Api.Platform/Wrapper/Invoice.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/namespaces/{namespace}/invoice/details.csv` | GET | DownloadInvoiceDetails | [DownloadInvoiceDetails](../../apis/AccelByte.Sdk.Api.Platform/Operation/Invoice/DownloadInvoiceDetails.cs) | [DownloadInvoiceDetails](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Invoice/DownloadInvoiceDetails.cs) |
| `/platform/admin/namespaces/{namespace}/invoice/summary` | GET | GenerateInvoiceSummary | [GenerateInvoiceSummary](../../apis/AccelByte.Sdk.Api.Platform/Operation/Invoice/GenerateInvoiceSummary.cs) | [GenerateInvoiceSummary](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Invoice/GenerateInvoiceSummary.cs) |

### KeyGroup Wrapper:  [KeyGroup](../../apis/AccelByte.Sdk.Api.Platform/Wrapper/KeyGroup.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/namespaces/{namespace}/keygroups` | GET | QueryKeyGroups | [QueryKeyGroups](../../apis/AccelByte.Sdk.Api.Platform/Operation/KeyGroup/QueryKeyGroups.cs) | [QueryKeyGroups](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/KeyGroup/QueryKeyGroups.cs) |
| `/platform/admin/namespaces/{namespace}/keygroups` | POST | CreateKeyGroup | [CreateKeyGroup](../../apis/AccelByte.Sdk.Api.Platform/Operation/KeyGroup/CreateKeyGroup.cs) | [CreateKeyGroup](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/KeyGroup/CreateKeyGroup.cs) |
| [DEPRECATED] `/platform/admin/namespaces/{namespace}/keygroups/byBoothName` | GET | GetKeyGroupByBoothName | [GetKeyGroupByBoothName](../../apis/AccelByte.Sdk.Api.Platform/Operation/KeyGroup/GetKeyGroupByBoothName.cs) | [GetKeyGroupByBoothName](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/KeyGroup/GetKeyGroupByBoothName.cs) |
| `/platform/admin/namespaces/{namespace}/keygroups/{keyGroupId}` | GET | GetKeyGroup | [GetKeyGroup](../../apis/AccelByte.Sdk.Api.Platform/Operation/KeyGroup/GetKeyGroup.cs) | [GetKeyGroup](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/KeyGroup/GetKeyGroup.cs) |
| `/platform/admin/namespaces/{namespace}/keygroups/{keyGroupId}` | PUT | UpdateKeyGroup | [UpdateKeyGroup](../../apis/AccelByte.Sdk.Api.Platform/Operation/KeyGroup/UpdateKeyGroup.cs) | [UpdateKeyGroup](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/KeyGroup/UpdateKeyGroup.cs) |
| `/platform/admin/namespaces/{namespace}/keygroups/{keyGroupId}/dynamic` | GET | GetKeyGroupDynamic | [GetKeyGroupDynamic](../../apis/AccelByte.Sdk.Api.Platform/Operation/KeyGroup/GetKeyGroupDynamic.cs) | [GetKeyGroupDynamic](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/KeyGroup/GetKeyGroupDynamic.cs) |
| `/platform/admin/namespaces/{namespace}/keygroups/{keyGroupId}/keys` | GET | ListKeys | [ListKeys](../../apis/AccelByte.Sdk.Api.Platform/Operation/KeyGroup/ListKeys.cs) | [ListKeys](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/KeyGroup/ListKeys.cs) |
| `/platform/admin/namespaces/{namespace}/keygroups/{keyGroupId}/keys` | POST | UploadKeys | [UploadKeys](../../apis/AccelByte.Sdk.Api.Platform/Operation/KeyGroup/UploadKeys.cs) | [UploadKeys](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/KeyGroup/UploadKeys.cs) |

### Order Wrapper:  [Order](../../apis/AccelByte.Sdk.Api.Platform/Wrapper/Order.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/namespaces/{namespace}/orders` | GET | QueryOrders | [QueryOrders](../../apis/AccelByte.Sdk.Api.Platform/Operation/Order/QueryOrders.cs) | [QueryOrders](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Order/QueryOrders.cs) |
| `/platform/admin/namespaces/{namespace}/orders/stats` | GET | GetOrderStatistics | [GetOrderStatistics](../../apis/AccelByte.Sdk.Api.Platform/Operation/Order/GetOrderStatistics.cs) | [GetOrderStatistics](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Order/GetOrderStatistics.cs) |
| `/platform/admin/namespaces/{namespace}/orders/{orderNo}` | GET | GetOrder | [GetOrder](../../apis/AccelByte.Sdk.Api.Platform/Operation/Order/GetOrder.cs) | [GetOrder](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Order/GetOrder.cs) |
| `/platform/admin/namespaces/{namespace}/orders/{orderNo}/refund` | PUT | RefundOrder | [RefundOrder](../../apis/AccelByte.Sdk.Api.Platform/Operation/Order/RefundOrder.cs) | [RefundOrder](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Order/RefundOrder.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/orders` | GET | QueryUserOrders | [QueryUserOrders](../../apis/AccelByte.Sdk.Api.Platform/Operation/Order/QueryUserOrders.cs) | [QueryUserOrders](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Order/QueryUserOrders.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/orders` | POST | AdminCreateUserOrder | [AdminCreateUserOrder](../../apis/AccelByte.Sdk.Api.Platform/Operation/Order/AdminCreateUserOrder.cs) | [AdminCreateUserOrder](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Order/AdminCreateUserOrder.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/orders/countOfItem` | GET | CountOfPurchasedItem | [CountOfPurchasedItem](../../apis/AccelByte.Sdk.Api.Platform/Operation/Order/CountOfPurchasedItem.cs) | [CountOfPurchasedItem](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Order/CountOfPurchasedItem.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/orders/{orderNo}` | GET | GetUserOrder | [GetUserOrder](../../apis/AccelByte.Sdk.Api.Platform/Operation/Order/GetUserOrder.cs) | [GetUserOrder](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Order/GetUserOrder.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/orders/{orderNo}` | PUT | UpdateUserOrderStatus | [UpdateUserOrderStatus](../../apis/AccelByte.Sdk.Api.Platform/Operation/Order/UpdateUserOrderStatus.cs) | [UpdateUserOrderStatus](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Order/UpdateUserOrderStatus.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/orders/{orderNo}/fulfill` | PUT | FulfillUserOrder | [FulfillUserOrder](../../apis/AccelByte.Sdk.Api.Platform/Operation/Order/FulfillUserOrder.cs) | [FulfillUserOrder](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Order/FulfillUserOrder.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/orders/{orderNo}/grant` | GET | GetUserOrderGrant | [GetUserOrderGrant](../../apis/AccelByte.Sdk.Api.Platform/Operation/Order/GetUserOrderGrant.cs) | [GetUserOrderGrant](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Order/GetUserOrderGrant.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/orders/{orderNo}/history` | GET | GetUserOrderHistories | [GetUserOrderHistories](../../apis/AccelByte.Sdk.Api.Platform/Operation/Order/GetUserOrderHistories.cs) | [GetUserOrderHistories](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Order/GetUserOrderHistories.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/orders/{orderNo}/notifications` | POST | ProcessUserOrderNotification | [ProcessUserOrderNotification](../../apis/AccelByte.Sdk.Api.Platform/Operation/Order/ProcessUserOrderNotification.cs) | [ProcessUserOrderNotification](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Order/ProcessUserOrderNotification.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/orders/{orderNo}/receipt.pdf` | GET | DownloadUserOrderReceipt | [DownloadUserOrderReceipt](../../apis/AccelByte.Sdk.Api.Platform/Operation/Order/DownloadUserOrderReceipt.cs) | [DownloadUserOrderReceipt](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Order/DownloadUserOrderReceipt.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/orders` | GET | PublicQueryUserOrders | [PublicQueryUserOrders](../../apis/AccelByte.Sdk.Api.Platform/Operation/Order/PublicQueryUserOrders.cs) | [PublicQueryUserOrders](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Order/PublicQueryUserOrders.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/orders` | POST | PublicCreateUserOrder | [PublicCreateUserOrder](../../apis/AccelByte.Sdk.Api.Platform/Operation/Order/PublicCreateUserOrder.cs) | [PublicCreateUserOrder](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Order/PublicCreateUserOrder.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/orders/{orderNo}` | GET | PublicGetUserOrder | [PublicGetUserOrder](../../apis/AccelByte.Sdk.Api.Platform/Operation/Order/PublicGetUserOrder.cs) | [PublicGetUserOrder](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Order/PublicGetUserOrder.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/orders/{orderNo}/cancel` | PUT | PublicCancelUserOrder | [PublicCancelUserOrder](../../apis/AccelByte.Sdk.Api.Platform/Operation/Order/PublicCancelUserOrder.cs) | [PublicCancelUserOrder](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Order/PublicCancelUserOrder.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/orders/{orderNo}/history` | GET | PublicGetUserOrderHistories | [PublicGetUserOrderHistories](../../apis/AccelByte.Sdk.Api.Platform/Operation/Order/PublicGetUserOrderHistories.cs) | [PublicGetUserOrderHistories](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Order/PublicGetUserOrderHistories.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/orders/{orderNo}/receipt.pdf` | GET | PublicDownloadUserOrderReceipt | [PublicDownloadUserOrderReceipt](../../apis/AccelByte.Sdk.Api.Platform/Operation/Order/PublicDownloadUserOrderReceipt.cs) | [PublicDownloadUserOrderReceipt](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Order/PublicDownloadUserOrderReceipt.cs) |

### PaymentCallbackConfig Wrapper:  [PaymentCallbackConfig](../../apis/AccelByte.Sdk.Api.Platform/Wrapper/PaymentCallbackConfig.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/namespaces/{namespace}/payment/config/callback` | GET | GetPaymentCallbackConfig | [GetPaymentCallbackConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/PaymentCallbackConfig/GetPaymentCallbackConfig.cs) | [GetPaymentCallbackConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentCallbackConfig/GetPaymentCallbackConfig.cs) |
| `/platform/admin/namespaces/{namespace}/payment/config/callback` | PUT | UpdatePaymentCallbackConfig | [UpdatePaymentCallbackConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/PaymentCallbackConfig/UpdatePaymentCallbackConfig.cs) | [UpdatePaymentCallbackConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentCallbackConfig/UpdatePaymentCallbackConfig.cs) |

### Payment Wrapper:  [Payment](../../apis/AccelByte.Sdk.Api.Platform/Wrapper/Payment.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/namespaces/{namespace}/payment/notifications` | GET | QueryPaymentNotifications | [QueryPaymentNotifications](../../apis/AccelByte.Sdk.Api.Platform/Operation/Payment/QueryPaymentNotifications.cs) | [QueryPaymentNotifications](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Payment/QueryPaymentNotifications.cs) |
| `/platform/admin/namespaces/{namespace}/payment/orders` | GET | QueryPaymentOrders | [QueryPaymentOrders](../../apis/AccelByte.Sdk.Api.Platform/Operation/Payment/QueryPaymentOrders.cs) | [QueryPaymentOrders](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Payment/QueryPaymentOrders.cs) |
| `/platform/admin/namespaces/{namespace}/payment/orders/byExtTxId` | GET | ListExtOrderNoByExtTxId | [ListExtOrderNoByExtTxId](../../apis/AccelByte.Sdk.Api.Platform/Operation/Payment/ListExtOrderNoByExtTxId.cs) | [ListExtOrderNoByExtTxId](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Payment/ListExtOrderNoByExtTxId.cs) |
| `/platform/admin/namespaces/{namespace}/payment/orders/{paymentOrderNo}` | GET | GetPaymentOrder | [GetPaymentOrder](../../apis/AccelByte.Sdk.Api.Platform/Operation/Payment/GetPaymentOrder.cs) | [GetPaymentOrder](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Payment/GetPaymentOrder.cs) |
| `/platform/admin/namespaces/{namespace}/payment/orders/{paymentOrderNo}` | PUT | ChargePaymentOrder | [ChargePaymentOrder](../../apis/AccelByte.Sdk.Api.Platform/Operation/Payment/ChargePaymentOrder.cs) | [ChargePaymentOrder](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Payment/ChargePaymentOrder.cs) |
| `/platform/admin/namespaces/{namespace}/payment/orders/{paymentOrderNo}/simulate-notification` | PUT | SimulatePaymentOrderNotification | [SimulatePaymentOrderNotification](../../apis/AccelByte.Sdk.Api.Platform/Operation/Payment/SimulatePaymentOrderNotification.cs) | [SimulatePaymentOrderNotification](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Payment/SimulatePaymentOrderNotification.cs) |
| `/platform/admin/namespaces/{namespace}/payment/orders/{paymentOrderNo}/status` | GET | GetPaymentOrderChargeStatus | [GetPaymentOrderChargeStatus](../../apis/AccelByte.Sdk.Api.Platform/Operation/Payment/GetPaymentOrderChargeStatus.cs) | [GetPaymentOrderChargeStatus](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Payment/GetPaymentOrderChargeStatus.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/payment/orders` | POST | CreateUserPaymentOrder | [CreateUserPaymentOrder](../../apis/AccelByte.Sdk.Api.Platform/Operation/Payment/CreateUserPaymentOrder.cs) | [CreateUserPaymentOrder](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Payment/CreateUserPaymentOrder.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/payment/orders/{paymentOrderNo}/refund` | PUT | RefundUserPaymentOrder | [RefundUserPaymentOrder](../../apis/AccelByte.Sdk.Api.Platform/Operation/Payment/RefundUserPaymentOrder.cs) | [RefundUserPaymentOrder](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Payment/RefundUserPaymentOrder.cs) |

### Payment(Dedicated) Wrapper:  [PaymentDedicated](../../apis/AccelByte.Sdk.Api.Platform/Wrapper/PaymentDedicated.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/namespaces/{namespace}/payment/orders` | POST | CreatePaymentOrderByDedicated | [CreatePaymentOrderByDedicated](../../apis/AccelByte.Sdk.Api.Platform/Operation/PaymentDedicated/CreatePaymentOrderByDedicated.cs) | [CreatePaymentOrderByDedicated](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentDedicated/CreatePaymentOrderByDedicated.cs) |
| `/platform/admin/namespaces/{namespace}/payment/orders/{paymentOrderNo}/refund` | PUT | RefundPaymentOrderByDedicated | [RefundPaymentOrderByDedicated](../../apis/AccelByte.Sdk.Api.Platform/Operation/PaymentDedicated/RefundPaymentOrderByDedicated.cs) | [RefundPaymentOrderByDedicated](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentDedicated/RefundPaymentOrderByDedicated.cs) |
| `/platform/admin/payment/orders` | GET | SyncPaymentOrders | [SyncPaymentOrders](../../apis/AccelByte.Sdk.Api.Platform/Operation/PaymentDedicated/SyncPaymentOrders.cs) | [SyncPaymentOrders](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentDedicated/SyncPaymentOrders.cs) |

### Wallet Wrapper:  [Wallet](../../apis/AccelByte.Sdk.Api.Platform/Wrapper/Wallet.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/namespaces/{namespace}/platforms/{platform}/wallet/config` | GET | GetPlatformWalletConfig | [GetPlatformWalletConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/Wallet/GetPlatformWalletConfig.cs) | [GetPlatformWalletConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Wallet/GetPlatformWalletConfig.cs) |
| `/platform/admin/namespaces/{namespace}/platforms/{platform}/wallet/config` | PUT | UpdatePlatformWalletConfig | [UpdatePlatformWalletConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/Wallet/UpdatePlatformWalletConfig.cs) | [UpdatePlatformWalletConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Wallet/UpdatePlatformWalletConfig.cs) |
| `/platform/admin/namespaces/{namespace}/platforms/{platform}/wallet/config/reset` | PUT | ResetPlatformWalletConfig | [ResetPlatformWalletConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/Wallet/ResetPlatformWalletConfig.cs) | [ResetPlatformWalletConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Wallet/ResetPlatformWalletConfig.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/wallets/currencies/summary` | GET | QueryUserCurrencyWallets | [QueryUserCurrencyWallets](../../apis/AccelByte.Sdk.Api.Platform/Operation/Wallet/QueryUserCurrencyWallets.cs) | [QueryUserCurrencyWallets](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Wallet/QueryUserCurrencyWallets.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/wallets/currencies/{currencyCode}/debit` | PUT | DebitUserWalletByCurrencyCode | [DebitUserWalletByCurrencyCode](../../apis/AccelByte.Sdk.Api.Platform/Operation/Wallet/DebitUserWalletByCurrencyCode.cs) | [DebitUserWalletByCurrencyCode](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Wallet/DebitUserWalletByCurrencyCode.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/wallets/currencies/{currencyCode}/transactions` | GET | ListUserCurrencyTransactions | [ListUserCurrencyTransactions](../../apis/AccelByte.Sdk.Api.Platform/Operation/Wallet/ListUserCurrencyTransactions.cs) | [ListUserCurrencyTransactions](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Wallet/ListUserCurrencyTransactions.cs) |
| [DEPRECATED] `/platform/admin/namespaces/{namespace}/users/{userId}/wallets/{currencyCode}/check` | GET | CheckWallet | [CheckWallet](../../apis/AccelByte.Sdk.Api.Platform/Operation/Wallet/CheckWallet.cs) | [CheckWallet](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Wallet/CheckWallet.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/wallets/{currencyCode}/credit` | PUT | CreditUserWallet | [CreditUserWallet](../../apis/AccelByte.Sdk.Api.Platform/Operation/Wallet/CreditUserWallet.cs) | [CreditUserWallet](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Wallet/CreditUserWallet.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/wallets/{currencyCode}/payment` | PUT | PayWithUserWallet | [PayWithUserWallet](../../apis/AccelByte.Sdk.Api.Platform/Operation/Wallet/PayWithUserWallet.cs) | [PayWithUserWallet](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Wallet/PayWithUserWallet.cs) |
| [DEPRECATED] `/platform/admin/namespaces/{namespace}/users/{userId}/wallets/{walletId}` | GET | GetUserWallet | [GetUserWallet](../../apis/AccelByte.Sdk.Api.Platform/Operation/Wallet/GetUserWallet.cs) | [GetUserWallet](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Wallet/GetUserWallet.cs) |
| [DEPRECATED] `/platform/admin/namespaces/{namespace}/users/{userId}/wallets/{walletId}/debit` | PUT | DebitUserWallet | [DebitUserWallet](../../apis/AccelByte.Sdk.Api.Platform/Operation/Wallet/DebitUserWallet.cs) | [DebitUserWallet](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Wallet/DebitUserWallet.cs) |
| [DEPRECATED] `/platform/admin/namespaces/{namespace}/users/{userId}/wallets/{walletId}/disable` | PUT | DisableUserWallet | [DisableUserWallet](../../apis/AccelByte.Sdk.Api.Platform/Operation/Wallet/DisableUserWallet.cs) | [DisableUserWallet](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Wallet/DisableUserWallet.cs) |
| [DEPRECATED] `/platform/admin/namespaces/{namespace}/users/{userId}/wallets/{walletId}/enable` | PUT | EnableUserWallet | [EnableUserWallet](../../apis/AccelByte.Sdk.Api.Platform/Operation/Wallet/EnableUserWallet.cs) | [EnableUserWallet](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Wallet/EnableUserWallet.cs) |
| [DEPRECATED] `/platform/admin/namespaces/{namespace}/users/{userId}/wallets/{walletId}/transactions` | GET | ListUserWalletTransactions | [ListUserWalletTransactions](../../apis/AccelByte.Sdk.Api.Platform/Operation/Wallet/ListUserWalletTransactions.cs) | [ListUserWalletTransactions](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Wallet/ListUserWalletTransactions.cs) |
| [DEPRECATED] `/platform/admin/namespaces/{namespace}/wallets` | GET | QueryWallets | [QueryWallets](../../apis/AccelByte.Sdk.Api.Platform/Operation/Wallet/QueryWallets.cs) | [QueryWallets](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Wallet/QueryWallets.cs) |
| `/platform/admin/namespaces/{namespace}/wallets/credit` | POST | BulkCredit | [BulkCredit](../../apis/AccelByte.Sdk.Api.Platform/Operation/Wallet/BulkCredit.cs) | [BulkCredit](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Wallet/BulkCredit.cs) |
| `/platform/admin/namespaces/{namespace}/wallets/debit` | POST | BulkDebit | [BulkDebit](../../apis/AccelByte.Sdk.Api.Platform/Operation/Wallet/BulkDebit.cs) | [BulkDebit](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Wallet/BulkDebit.cs) |
| [DEPRECATED] `/platform/admin/namespaces/{namespace}/wallets/{walletId}` | GET | GetWallet | [GetWallet](../../apis/AccelByte.Sdk.Api.Platform/Operation/Wallet/GetWallet.cs) | [GetWallet](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Wallet/GetWallet.cs) |
| `/platform/public/namespaces/{namespace}/users/me/wallets/{currencyCode}` | GET | PublicGetMyWallet | [PublicGetMyWallet](../../apis/AccelByte.Sdk.Api.Platform/Operation/Wallet/PublicGetMyWallet.cs) | [PublicGetMyWallet](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Wallet/PublicGetMyWallet.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/wallets/{currencyCode}` | GET | PublicGetWallet | [PublicGetWallet](../../apis/AccelByte.Sdk.Api.Platform/Operation/Wallet/PublicGetWallet.cs) | [PublicGetWallet](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Wallet/PublicGetWallet.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/wallets/{currencyCode}/transactions` | GET | PublicListUserWalletTransactions | [PublicListUserWalletTransactions](../../apis/AccelByte.Sdk.Api.Platform/Operation/Wallet/PublicListUserWalletTransactions.cs) | [PublicListUserWalletTransactions](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Wallet/PublicListUserWalletTransactions.cs) |

### Revocation Wrapper:  [Revocation](../../apis/AccelByte.Sdk.Api.Platform/Wrapper/Revocation.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/namespaces/{namespace}/revocation/config` | GET | GetRevocationConfig | [GetRevocationConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/Revocation/GetRevocationConfig.cs) | [GetRevocationConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Revocation/GetRevocationConfig.cs) |
| `/platform/admin/namespaces/{namespace}/revocation/config` | PUT | UpdateRevocationConfig | [UpdateRevocationConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/Revocation/UpdateRevocationConfig.cs) | [UpdateRevocationConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Revocation/UpdateRevocationConfig.cs) |
| `/platform/admin/namespaces/{namespace}/revocation/config` | DELETE | DeleteRevocationConfig | [DeleteRevocationConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/Revocation/DeleteRevocationConfig.cs) | [DeleteRevocationConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Revocation/DeleteRevocationConfig.cs) |
| `/platform/admin/namespaces/{namespace}/revocation/history` | GET | QueryRevocationHistories | [QueryRevocationHistories](../../apis/AccelByte.Sdk.Api.Platform/Operation/Revocation/QueryRevocationHistories.cs) | [QueryRevocationHistories](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Revocation/QueryRevocationHistories.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/revocation` | PUT | DoRevocation | [DoRevocation](../../apis/AccelByte.Sdk.Api.Platform/Operation/Revocation/DoRevocation.cs) | [DoRevocation](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Revocation/DoRevocation.cs) |

### Reward Wrapper:  [Reward](../../apis/AccelByte.Sdk.Api.Platform/Wrapper/Reward.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/namespaces/{namespace}/rewards` | POST | CreateReward | [CreateReward](../../apis/AccelByte.Sdk.Api.Platform/Operation/Reward/CreateReward.cs) | [CreateReward](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Reward/CreateReward.cs) |
| `/platform/admin/namespaces/{namespace}/rewards/byCriteria` | GET | QueryRewards | [QueryRewards](../../apis/AccelByte.Sdk.Api.Platform/Operation/Reward/QueryRewards.cs) | [QueryRewards](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Reward/QueryRewards.cs) |
| `/platform/admin/namespaces/{namespace}/rewards/export` | GET | ExportRewards | [ExportRewards](../../apis/AccelByte.Sdk.Api.Platform/Operation/Reward/ExportRewards.cs) | [ExportRewards](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Reward/ExportRewards.cs) |
| `/platform/admin/namespaces/{namespace}/rewards/import` | POST | ImportRewards | [ImportRewards](../../apis/AccelByte.Sdk.Api.Platform/Operation/Reward/ImportRewards.cs) | [ImportRewards](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Reward/ImportRewards.cs) |
| `/platform/admin/namespaces/{namespace}/rewards/{rewardId}` | GET | GetReward | [GetReward](../../apis/AccelByte.Sdk.Api.Platform/Operation/Reward/GetReward.cs) | [GetReward](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Reward/GetReward.cs) |
| `/platform/admin/namespaces/{namespace}/rewards/{rewardId}` | PUT | UpdateReward | [UpdateReward](../../apis/AccelByte.Sdk.Api.Platform/Operation/Reward/UpdateReward.cs) | [UpdateReward](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Reward/UpdateReward.cs) |
| `/platform/admin/namespaces/{namespace}/rewards/{rewardId}` | DELETE | DeleteReward | [DeleteReward](../../apis/AccelByte.Sdk.Api.Platform/Operation/Reward/DeleteReward.cs) | [DeleteReward](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Reward/DeleteReward.cs) |
| `/platform/admin/namespaces/{namespace}/rewards/{rewardId}/match` | PUT | CheckEventCondition | [CheckEventCondition](../../apis/AccelByte.Sdk.Api.Platform/Operation/Reward/CheckEventCondition.cs) | [CheckEventCondition](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Reward/CheckEventCondition.cs) |
| `/platform/admin/namespaces/{namespace}/rewards/{rewardId}/record` | DELETE | DeleteRewardConditionRecord | [DeleteRewardConditionRecord](../../apis/AccelByte.Sdk.Api.Platform/Operation/Reward/DeleteRewardConditionRecord.cs) | [DeleteRewardConditionRecord](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Reward/DeleteRewardConditionRecord.cs) |
| `/platform/public/namespaces/{namespace}/rewards/byCode` | GET | GetRewardByCode | [GetRewardByCode](../../apis/AccelByte.Sdk.Api.Platform/Operation/Reward/GetRewardByCode.cs) | [GetRewardByCode](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Reward/GetRewardByCode.cs) |
| `/platform/public/namespaces/{namespace}/rewards/byCriteria` | GET | QueryRewards1 | [QueryRewards1](../../apis/AccelByte.Sdk.Api.Platform/Operation/Reward/QueryRewards1.cs) | [QueryRewards1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Reward/QueryRewards1.cs) |
| `/platform/public/namespaces/{namespace}/rewards/{rewardId}` | GET | GetReward1 | [GetReward1](../../apis/AccelByte.Sdk.Api.Platform/Operation/Reward/GetReward1.cs) | [GetReward1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Reward/GetReward1.cs) |

### Section Wrapper:  [Section](../../apis/AccelByte.Sdk.Api.Platform/Wrapper/Section.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/namespaces/{namespace}/sections` | GET | QuerySections | [QuerySections](../../apis/AccelByte.Sdk.Api.Platform/Operation/Section/QuerySections.cs) | [QuerySections](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Section/QuerySections.cs) |
| `/platform/admin/namespaces/{namespace}/sections` | POST | CreateSection | [CreateSection](../../apis/AccelByte.Sdk.Api.Platform/Operation/Section/CreateSection.cs) | [CreateSection](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Section/CreateSection.cs) |
| `/platform/admin/namespaces/{namespace}/sections/purge/expired` | DELETE | PurgeExpiredSection | [PurgeExpiredSection](../../apis/AccelByte.Sdk.Api.Platform/Operation/Section/PurgeExpiredSection.cs) | [PurgeExpiredSection](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Section/PurgeExpiredSection.cs) |
| `/platform/admin/namespaces/{namespace}/sections/{sectionId}` | GET | GetSection | [GetSection](../../apis/AccelByte.Sdk.Api.Platform/Operation/Section/GetSection.cs) | [GetSection](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Section/GetSection.cs) |
| `/platform/admin/namespaces/{namespace}/sections/{sectionId}` | PUT | UpdateSection | [UpdateSection](../../apis/AccelByte.Sdk.Api.Platform/Operation/Section/UpdateSection.cs) | [UpdateSection](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Section/UpdateSection.cs) |
| `/platform/admin/namespaces/{namespace}/sections/{sectionId}` | DELETE | DeleteSection | [DeleteSection](../../apis/AccelByte.Sdk.Api.Platform/Operation/Section/DeleteSection.cs) | [DeleteSection](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Section/DeleteSection.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/sections` | GET | PublicListActiveSections | [PublicListActiveSections](../../apis/AccelByte.Sdk.Api.Platform/Operation/Section/PublicListActiveSections.cs) | [PublicListActiveSections](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Section/PublicListActiveSections.cs) |

### Store Wrapper:  [Store](../../apis/AccelByte.Sdk.Api.Platform/Wrapper/Store.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/namespaces/{namespace}/stores` | GET | ListStores | [ListStores](../../apis/AccelByte.Sdk.Api.Platform/Operation/Store/ListStores.cs) | [ListStores](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Store/ListStores.cs) |
| `/platform/admin/namespaces/{namespace}/stores` | POST | CreateStore | [CreateStore](../../apis/AccelByte.Sdk.Api.Platform/Operation/Store/CreateStore.cs) | [CreateStore](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Store/CreateStore.cs) |
| [DEPRECATED] `/platform/admin/namespaces/{namespace}/stores/import` | PUT | ImportStore | [ImportStore](../../apis/AccelByte.Sdk.Api.Platform/Operation/Store/ImportStore.cs) | [ImportStore](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Store/ImportStore.cs) |
| `/platform/admin/namespaces/{namespace}/stores/published` | GET | GetPublishedStore | [GetPublishedStore](../../apis/AccelByte.Sdk.Api.Platform/Operation/Store/GetPublishedStore.cs) | [GetPublishedStore](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Store/GetPublishedStore.cs) |
| `/platform/admin/namespaces/{namespace}/stores/published` | DELETE | DeletePublishedStore | [DeletePublishedStore](../../apis/AccelByte.Sdk.Api.Platform/Operation/Store/DeletePublishedStore.cs) | [DeletePublishedStore](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Store/DeletePublishedStore.cs) |
| `/platform/admin/namespaces/{namespace}/stores/published/backup` | GET | GetPublishedStoreBackup | [GetPublishedStoreBackup](../../apis/AccelByte.Sdk.Api.Platform/Operation/Store/GetPublishedStoreBackup.cs) | [GetPublishedStoreBackup](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Store/GetPublishedStoreBackup.cs) |
| `/platform/admin/namespaces/{namespace}/stores/published/rollback` | PUT | RollbackPublishedStore | [RollbackPublishedStore](../../apis/AccelByte.Sdk.Api.Platform/Operation/Store/RollbackPublishedStore.cs) | [RollbackPublishedStore](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Store/RollbackPublishedStore.cs) |
| `/platform/admin/namespaces/{namespace}/stores/{storeId}` | GET | GetStore | [GetStore](../../apis/AccelByte.Sdk.Api.Platform/Operation/Store/GetStore.cs) | [GetStore](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Store/GetStore.cs) |
| `/platform/admin/namespaces/{namespace}/stores/{storeId}` | PUT | UpdateStore | [UpdateStore](../../apis/AccelByte.Sdk.Api.Platform/Operation/Store/UpdateStore.cs) | [UpdateStore](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Store/UpdateStore.cs) |
| `/platform/admin/namespaces/{namespace}/stores/{storeId}` | DELETE | DeleteStore | [DeleteStore](../../apis/AccelByte.Sdk.Api.Platform/Operation/Store/DeleteStore.cs) | [DeleteStore](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Store/DeleteStore.cs) |
| `/platform/admin/namespaces/{namespace}/stores/{storeId}/clone` | PUT | CloneStore | [CloneStore](../../apis/AccelByte.Sdk.Api.Platform/Operation/Store/CloneStore.cs) | [CloneStore](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Store/CloneStore.cs) |
| [DEPRECATED] `/platform/admin/namespaces/{namespace}/stores/{storeId}/export` | GET | ExportStore | [ExportStore](../../apis/AccelByte.Sdk.Api.Platform/Operation/Store/ExportStore.cs) | [ExportStore](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Store/ExportStore.cs) |
| `/platform/public/namespaces/{namespace}/stores` | GET | PublicListStores | [PublicListStores](../../apis/AccelByte.Sdk.Api.Platform/Operation/Store/PublicListStores.cs) | [PublicListStores](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Store/PublicListStores.cs) |
| `/platform/v2/admin/namespaces/{namespace}/stores/import` | PUT | ImportStore1 | [ImportStore1](../../apis/AccelByte.Sdk.Api.Platform/Operation/Store/ImportStore1.cs) | [ImportStore1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Store/ImportStore1.cs) |
| `/platform/v2/admin/namespaces/{namespace}/stores/{storeId}/export` | POST | ExportStore1 | [ExportStore1](../../apis/AccelByte.Sdk.Api.Platform/Operation/Store/ExportStore1.cs) | [ExportStore1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Store/ExportStore1.cs) |

### CatalogChanges Wrapper:  [CatalogChanges](../../apis/AccelByte.Sdk.Api.Platform/Wrapper/CatalogChanges.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/namespaces/{namespace}/stores/{storeId}/catalogChanges/byCriteria` | GET | QueryChanges | [QueryChanges](../../apis/AccelByte.Sdk.Api.Platform/Operation/CatalogChanges/QueryChanges.cs) | [QueryChanges](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/CatalogChanges/QueryChanges.cs) |
| `/platform/admin/namespaces/{namespace}/stores/{storeId}/catalogChanges/publishAll` | PUT | PublishAll | [PublishAll](../../apis/AccelByte.Sdk.Api.Platform/Operation/CatalogChanges/PublishAll.cs) | [PublishAll](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/CatalogChanges/PublishAll.cs) |
| `/platform/admin/namespaces/{namespace}/stores/{storeId}/catalogChanges/publishSelected` | PUT | PublishSelected | [PublishSelected](../../apis/AccelByte.Sdk.Api.Platform/Operation/CatalogChanges/PublishSelected.cs) | [PublishSelected](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/CatalogChanges/PublishSelected.cs) |
| `/platform/admin/namespaces/{namespace}/stores/{storeId}/catalogChanges/selectAll` | PUT | SelectAllRecords | [SelectAllRecords](../../apis/AccelByte.Sdk.Api.Platform/Operation/CatalogChanges/SelectAllRecords.cs) | [SelectAllRecords](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/CatalogChanges/SelectAllRecords.cs) |
| `/platform/admin/namespaces/{namespace}/stores/{storeId}/catalogChanges/statistics` | GET | GetStatistic | [GetStatistic](../../apis/AccelByte.Sdk.Api.Platform/Operation/CatalogChanges/GetStatistic.cs) | [GetStatistic](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/CatalogChanges/GetStatistic.cs) |
| `/platform/admin/namespaces/{namespace}/stores/{storeId}/catalogChanges/unselectAll` | PUT | UnselectAllRecords | [UnselectAllRecords](../../apis/AccelByte.Sdk.Api.Platform/Operation/CatalogChanges/UnselectAllRecords.cs) | [UnselectAllRecords](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/CatalogChanges/UnselectAllRecords.cs) |
| `/platform/admin/namespaces/{namespace}/stores/{storeId}/catalogChanges/{changeId}/select` | PUT | SelectRecord | [SelectRecord](../../apis/AccelByte.Sdk.Api.Platform/Operation/CatalogChanges/SelectRecord.cs) | [SelectRecord](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/CatalogChanges/SelectRecord.cs) |
| `/platform/admin/namespaces/{namespace}/stores/{storeId}/catalogChanges/{changeId}/unselect` | PUT | UnselectRecord | [UnselectRecord](../../apis/AccelByte.Sdk.Api.Platform/Operation/CatalogChanges/UnselectRecord.cs) | [UnselectRecord](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/CatalogChanges/UnselectRecord.cs) |

### Subscription Wrapper:  [Subscription](../../apis/AccelByte.Sdk.Api.Platform/Wrapper/Subscription.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/namespaces/{namespace}/subscriptions` | GET | QuerySubscriptions | [QuerySubscriptions](../../apis/AccelByte.Sdk.Api.Platform/Operation/Subscription/QuerySubscriptions.cs) | [QuerySubscriptions](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Subscription/QuerySubscriptions.cs) |
| `/platform/admin/namespaces/{namespace}/subscriptions/{subscriptionId}/recurring` | PUT | RecurringChargeSubscription | [RecurringChargeSubscription](../../apis/AccelByte.Sdk.Api.Platform/Operation/Subscription/RecurringChargeSubscription.cs) | [RecurringChargeSubscription](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Subscription/RecurringChargeSubscription.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/subscriptions` | GET | QueryUserSubscriptions | [QueryUserSubscriptions](../../apis/AccelByte.Sdk.Api.Platform/Operation/Subscription/QueryUserSubscriptions.cs) | [QueryUserSubscriptions](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Subscription/QueryUserSubscriptions.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/subscriptions/activities` | GET | GetUserSubscriptionActivities | [GetUserSubscriptionActivities](../../apis/AccelByte.Sdk.Api.Platform/Operation/Subscription/GetUserSubscriptionActivities.cs) | [GetUserSubscriptionActivities](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Subscription/GetUserSubscriptionActivities.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/subscriptions/platformSubscribe` | POST | PlatformSubscribeSubscription | [PlatformSubscribeSubscription](../../apis/AccelByte.Sdk.Api.Platform/Operation/Subscription/PlatformSubscribeSubscription.cs) | [PlatformSubscribeSubscription](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Subscription/PlatformSubscribeSubscription.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/subscriptions/subscribable/byItemId` | GET | CheckUserSubscriptionSubscribableByItemId | [CheckUserSubscriptionSubscribableByItemId](../../apis/AccelByte.Sdk.Api.Platform/Operation/Subscription/CheckUserSubscriptionSubscribableByItemId.cs) | [CheckUserSubscriptionSubscribableByItemId](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Subscription/CheckUserSubscriptionSubscribableByItemId.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/subscriptions/{subscriptionId}` | GET | GetUserSubscription | [GetUserSubscription](../../apis/AccelByte.Sdk.Api.Platform/Operation/Subscription/GetUserSubscription.cs) | [GetUserSubscription](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Subscription/GetUserSubscription.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/subscriptions/{subscriptionId}` | DELETE | DeleteUserSubscription | [DeleteUserSubscription](../../apis/AccelByte.Sdk.Api.Platform/Operation/Subscription/DeleteUserSubscription.cs) | [DeleteUserSubscription](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Subscription/DeleteUserSubscription.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/subscriptions/{subscriptionId}/cancel` | PUT | CancelSubscription | [CancelSubscription](../../apis/AccelByte.Sdk.Api.Platform/Operation/Subscription/CancelSubscription.cs) | [CancelSubscription](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Subscription/CancelSubscription.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/subscriptions/{subscriptionId}/grant` | PUT | GrantDaysToSubscription | [GrantDaysToSubscription](../../apis/AccelByte.Sdk.Api.Platform/Operation/Subscription/GrantDaysToSubscription.cs) | [GrantDaysToSubscription](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Subscription/GrantDaysToSubscription.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/subscriptions/{subscriptionId}/history` | GET | GetUserSubscriptionBillingHistories | [GetUserSubscriptionBillingHistories](../../apis/AccelByte.Sdk.Api.Platform/Operation/Subscription/GetUserSubscriptionBillingHistories.cs) | [GetUserSubscriptionBillingHistories](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Subscription/GetUserSubscriptionBillingHistories.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/subscriptions/{subscriptionId}/notifications` | POST | ProcessUserSubscriptionNotification | [ProcessUserSubscriptionNotification](../../apis/AccelByte.Sdk.Api.Platform/Operation/Subscription/ProcessUserSubscriptionNotification.cs) | [ProcessUserSubscriptionNotification](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Subscription/ProcessUserSubscriptionNotification.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/subscriptions` | GET | PublicQueryUserSubscriptions | [PublicQueryUserSubscriptions](../../apis/AccelByte.Sdk.Api.Platform/Operation/Subscription/PublicQueryUserSubscriptions.cs) | [PublicQueryUserSubscriptions](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Subscription/PublicQueryUserSubscriptions.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/subscriptions` | POST | PublicSubscribeSubscription | [PublicSubscribeSubscription](../../apis/AccelByte.Sdk.Api.Platform/Operation/Subscription/PublicSubscribeSubscription.cs) | [PublicSubscribeSubscription](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Subscription/PublicSubscribeSubscription.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/subscriptions/subscribable/byItemId` | GET | PublicCheckUserSubscriptionSubscribableByItemId | [PublicCheckUserSubscriptionSubscribableByItemId](../../apis/AccelByte.Sdk.Api.Platform/Operation/Subscription/PublicCheckUserSubscriptionSubscribableByItemId.cs) | [PublicCheckUserSubscriptionSubscribableByItemId](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Subscription/PublicCheckUserSubscriptionSubscribableByItemId.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/subscriptions/{subscriptionId}` | GET | PublicGetUserSubscription | [PublicGetUserSubscription](../../apis/AccelByte.Sdk.Api.Platform/Operation/Subscription/PublicGetUserSubscription.cs) | [PublicGetUserSubscription](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Subscription/PublicGetUserSubscription.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/subscriptions/{subscriptionId}/billingAccount` | PUT | PublicChangeSubscriptionBillingAccount | [PublicChangeSubscriptionBillingAccount](../../apis/AccelByte.Sdk.Api.Platform/Operation/Subscription/PublicChangeSubscriptionBillingAccount.cs) | [PublicChangeSubscriptionBillingAccount](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Subscription/PublicChangeSubscriptionBillingAccount.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/subscriptions/{subscriptionId}/cancel` | PUT | PublicCancelSubscription | [PublicCancelSubscription](../../apis/AccelByte.Sdk.Api.Platform/Operation/Subscription/PublicCancelSubscription.cs) | [PublicCancelSubscription](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Subscription/PublicCancelSubscription.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/subscriptions/{subscriptionId}/history` | GET | PublicGetUserSubscriptionBillingHistories | [PublicGetUserSubscriptionBillingHistories](../../apis/AccelByte.Sdk.Api.Platform/Operation/Subscription/PublicGetUserSubscriptionBillingHistories.cs) | [PublicGetUserSubscriptionBillingHistories](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Subscription/PublicGetUserSubscriptionBillingHistories.cs) |

### Ticket Wrapper:  [Ticket](../../apis/AccelByte.Sdk.Api.Platform/Wrapper/Ticket.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/namespaces/{namespace}/tickets/{boothName}` | GET | GetTicketDynamic | [GetTicketDynamic](../../apis/AccelByte.Sdk.Api.Platform/Operation/Ticket/GetTicketDynamic.cs) | [GetTicketDynamic](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Ticket/GetTicketDynamic.cs) |
| `/platform/admin/namespaces/{namespace}/tickets/{boothName}/decrement` | PUT | DecreaseTicketSale | [DecreaseTicketSale](../../apis/AccelByte.Sdk.Api.Platform/Operation/Ticket/DecreaseTicketSale.cs) | [DecreaseTicketSale](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Ticket/DecreaseTicketSale.cs) |
| `/platform/admin/namespaces/{namespace}/tickets/{boothName}/id` | GET | GetTicketBoothID | [GetTicketBoothID](../../apis/AccelByte.Sdk.Api.Platform/Operation/Ticket/GetTicketBoothID.cs) | [GetTicketBoothID](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Ticket/GetTicketBoothID.cs) |
| `/platform/admin/namespaces/{namespace}/tickets/{boothName}/increment` | PUT | IncreaseTicketSale | [IncreaseTicketSale](../../apis/AccelByte.Sdk.Api.Platform/Operation/Ticket/IncreaseTicketSale.cs) | [IncreaseTicketSale](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Ticket/IncreaseTicketSale.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/tickets/{boothName}` | POST | AcquireUserTicket | [AcquireUserTicket](../../apis/AccelByte.Sdk.Api.Platform/Operation/Ticket/AcquireUserTicket.cs) | [AcquireUserTicket](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Ticket/AcquireUserTicket.cs) |

### Achievement(Platform) Wrapper:  [AchievementPlatform](../../apis/AccelByte.Sdk.Api.Platform/Wrapper/AchievementPlatform.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/namespaces/{namespace}/users/{userId}/achievement/steam` | PUT | UnlockSteamUserAchievement | [UnlockSteamUserAchievement](../../apis/AccelByte.Sdk.Api.Platform/Operation/AchievementPlatform/UnlockSteamUserAchievement.cs) | [UnlockSteamUserAchievement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/AchievementPlatform/UnlockSteamUserAchievement.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/achievement/xbl` | GET | GetXblUserAchievements | [GetXblUserAchievements](../../apis/AccelByte.Sdk.Api.Platform/Operation/AchievementPlatform/GetXblUserAchievements.cs) | [GetXblUserAchievements](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/AchievementPlatform/GetXblUserAchievements.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/achievement/xbl` | PUT | UpdateXblUserAchievement | [UpdateXblUserAchievement](../../apis/AccelByte.Sdk.Api.Platform/Operation/AchievementPlatform/UpdateXblUserAchievement.cs) | [UpdateXblUserAchievement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/AchievementPlatform/UpdateXblUserAchievement.cs) |

### Anonymization Wrapper:  [Anonymization](../../apis/AccelByte.Sdk.Api.Platform/Wrapper/Anonymization.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/namespaces/{namespace}/users/{userId}/anonymization/campaign` | DELETE | AnonymizeCampaign | [AnonymizeCampaign](../../apis/AccelByte.Sdk.Api.Platform/Operation/Anonymization/AnonymizeCampaign.cs) | [AnonymizeCampaign](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Anonymization/AnonymizeCampaign.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/anonymization/entitlements` | DELETE | AnonymizeEntitlement | [AnonymizeEntitlement](../../apis/AccelByte.Sdk.Api.Platform/Operation/Anonymization/AnonymizeEntitlement.cs) | [AnonymizeEntitlement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Anonymization/AnonymizeEntitlement.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/anonymization/fulfillment` | DELETE | AnonymizeFulfillment | [AnonymizeFulfillment](../../apis/AccelByte.Sdk.Api.Platform/Operation/Anonymization/AnonymizeFulfillment.cs) | [AnonymizeFulfillment](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Anonymization/AnonymizeFulfillment.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/anonymization/integrations` | DELETE | AnonymizeIntegration | [AnonymizeIntegration](../../apis/AccelByte.Sdk.Api.Platform/Operation/Anonymization/AnonymizeIntegration.cs) | [AnonymizeIntegration](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Anonymization/AnonymizeIntegration.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/anonymization/orders` | DELETE | AnonymizeOrder | [AnonymizeOrder](../../apis/AccelByte.Sdk.Api.Platform/Operation/Anonymization/AnonymizeOrder.cs) | [AnonymizeOrder](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Anonymization/AnonymizeOrder.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/anonymization/payment` | DELETE | AnonymizePayment | [AnonymizePayment](../../apis/AccelByte.Sdk.Api.Platform/Operation/Anonymization/AnonymizePayment.cs) | [AnonymizePayment](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Anonymization/AnonymizePayment.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/anonymization/revocation` | DELETE | AnonymizeRevocation | [AnonymizeRevocation](../../apis/AccelByte.Sdk.Api.Platform/Operation/Anonymization/AnonymizeRevocation.cs) | [AnonymizeRevocation](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Anonymization/AnonymizeRevocation.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/anonymization/subscriptions` | DELETE | AnonymizeSubscription | [AnonymizeSubscription](../../apis/AccelByte.Sdk.Api.Platform/Operation/Anonymization/AnonymizeSubscription.cs) | [AnonymizeSubscription](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Anonymization/AnonymizeSubscription.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/anonymization/wallets` | DELETE | AnonymizeWallet | [AnonymizeWallet](../../apis/AccelByte.Sdk.Api.Platform/Operation/Anonymization/AnonymizeWallet.cs) | [AnonymizeWallet](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Anonymization/AnonymizeWallet.cs) |

### Session(Platform) Wrapper:  [SessionPlatform](../../apis/AccelByte.Sdk.Api.Platform/Wrapper/SessionPlatform.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/namespaces/{namespace}/users/{userId}/session/xbl` | PUT | RegisterXblSessions | [RegisterXblSessions](../../apis/AccelByte.Sdk.Api.Platform/Operation/SessionPlatform/RegisterXblSessions.cs) | [RegisterXblSessions](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/SessionPlatform/RegisterXblSessions.cs) |

### View Wrapper:  [View](../../apis/AccelByte.Sdk.Api.Platform/Wrapper/View.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/namespaces/{namespace}/views` | GET | ListViews | [ListViews](../../apis/AccelByte.Sdk.Api.Platform/Operation/View/ListViews.cs) | [ListViews](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/View/ListViews.cs) |
| `/platform/admin/namespaces/{namespace}/views` | POST | CreateView | [CreateView](../../apis/AccelByte.Sdk.Api.Platform/Operation/View/CreateView.cs) | [CreateView](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/View/CreateView.cs) |
| `/platform/admin/namespaces/{namespace}/views/{viewId}` | GET | GetView | [GetView](../../apis/AccelByte.Sdk.Api.Platform/Operation/View/GetView.cs) | [GetView](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/View/GetView.cs) |
| `/platform/admin/namespaces/{namespace}/views/{viewId}` | PUT | UpdateView | [UpdateView](../../apis/AccelByte.Sdk.Api.Platform/Operation/View/UpdateView.cs) | [UpdateView](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/View/UpdateView.cs) |
| `/platform/admin/namespaces/{namespace}/views/{viewId}` | DELETE | DeleteView | [DeleteView](../../apis/AccelByte.Sdk.Api.Platform/Operation/View/DeleteView.cs) | [DeleteView](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/View/DeleteView.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/views` | GET | PublicListViews | [PublicListViews](../../apis/AccelByte.Sdk.Api.Platform/Operation/View/PublicListViews.cs) | [PublicListViews](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/View/PublicListViews.cs) |

### Order(Dedicated) Wrapper:  [OrderDedicated](../../apis/AccelByte.Sdk.Api.Platform/Wrapper/OrderDedicated.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/orders` | GET | SyncOrders | [SyncOrders](../../apis/AccelByte.Sdk.Api.Platform/Operation/OrderDedicated/SyncOrders.cs) | [SyncOrders](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/OrderDedicated/SyncOrders.cs) |

### PaymentConfig Wrapper:  [PaymentConfig](../../apis/AccelByte.Sdk.Api.Platform/Wrapper/PaymentConfig.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/payment/config/merchant/adyenconfig/test` | POST | TestAdyenConfig | [TestAdyenConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/PaymentConfig/TestAdyenConfig.cs) | [TestAdyenConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/TestAdyenConfig.cs) |
| `/platform/admin/payment/config/merchant/alipayconfig/test` | POST | TestAliPayConfig | [TestAliPayConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/PaymentConfig/TestAliPayConfig.cs) | [TestAliPayConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/TestAliPayConfig.cs) |
| `/platform/admin/payment/config/merchant/checkoutconfig/test` | POST | TestCheckoutConfig | [TestCheckoutConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/PaymentConfig/TestCheckoutConfig.cs) | [TestCheckoutConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/TestCheckoutConfig.cs) |
| `/platform/admin/payment/config/merchant/matched` | GET | DebugMatchedPaymentMerchantConfig | [DebugMatchedPaymentMerchantConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/PaymentConfig/DebugMatchedPaymentMerchantConfig.cs) | [DebugMatchedPaymentMerchantConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/DebugMatchedPaymentMerchantConfig.cs) |
| `/platform/admin/payment/config/merchant/paypalconfig/test` | POST | TestPayPalConfig | [TestPayPalConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/PaymentConfig/TestPayPalConfig.cs) | [TestPayPalConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/TestPayPalConfig.cs) |
| `/platform/admin/payment/config/merchant/stripeconfig/test` | POST | TestStripeConfig | [TestStripeConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/PaymentConfig/TestStripeConfig.cs) | [TestStripeConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/TestStripeConfig.cs) |
| `/platform/admin/payment/config/merchant/wxpayconfig/test` | POST | TestWxPayConfig | [TestWxPayConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/PaymentConfig/TestWxPayConfig.cs) | [TestWxPayConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/TestWxPayConfig.cs) |
| `/platform/admin/payment/config/merchant/xsollaconfig/test` | POST | TestXsollaConfig | [TestXsollaConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/PaymentConfig/TestXsollaConfig.cs) | [TestXsollaConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/TestXsollaConfig.cs) |
| `/platform/admin/payment/config/merchant/{id}` | GET | GetPaymentMerchantConfig | [GetPaymentMerchantConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/PaymentConfig/GetPaymentMerchantConfig.cs) | [GetPaymentMerchantConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/GetPaymentMerchantConfig.cs) |
| `/platform/admin/payment/config/merchant/{id}/adyenconfig` | PUT | UpdateAdyenConfig | [UpdateAdyenConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/PaymentConfig/UpdateAdyenConfig.cs) | [UpdateAdyenConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/UpdateAdyenConfig.cs) |
| `/platform/admin/payment/config/merchant/{id}/adyenconfig/test` | GET | TestAdyenConfigById | [TestAdyenConfigById](../../apis/AccelByte.Sdk.Api.Platform/Operation/PaymentConfig/TestAdyenConfigById.cs) | [TestAdyenConfigById](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/TestAdyenConfigById.cs) |
| `/platform/admin/payment/config/merchant/{id}/alipayconfig` | PUT | UpdateAliPayConfig | [UpdateAliPayConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/PaymentConfig/UpdateAliPayConfig.cs) | [UpdateAliPayConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/UpdateAliPayConfig.cs) |
| `/platform/admin/payment/config/merchant/{id}/alipayconfig/test` | GET | TestAliPayConfigById | [TestAliPayConfigById](../../apis/AccelByte.Sdk.Api.Platform/Operation/PaymentConfig/TestAliPayConfigById.cs) | [TestAliPayConfigById](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/TestAliPayConfigById.cs) |
| `/platform/admin/payment/config/merchant/{id}/checkoutconfig` | PUT | UpdateCheckoutConfig | [UpdateCheckoutConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/PaymentConfig/UpdateCheckoutConfig.cs) | [UpdateCheckoutConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/UpdateCheckoutConfig.cs) |
| `/platform/admin/payment/config/merchant/{id}/checkoutconfig/test` | GET | TestCheckoutConfigById | [TestCheckoutConfigById](../../apis/AccelByte.Sdk.Api.Platform/Operation/PaymentConfig/TestCheckoutConfigById.cs) | [TestCheckoutConfigById](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/TestCheckoutConfigById.cs) |
| `/platform/admin/payment/config/merchant/{id}/paypalconfig` | PUT | UpdatePayPalConfig | [UpdatePayPalConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/PaymentConfig/UpdatePayPalConfig.cs) | [UpdatePayPalConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/UpdatePayPalConfig.cs) |
| `/platform/admin/payment/config/merchant/{id}/paypalconfig/test` | GET | TestPayPalConfigById | [TestPayPalConfigById](../../apis/AccelByte.Sdk.Api.Platform/Operation/PaymentConfig/TestPayPalConfigById.cs) | [TestPayPalConfigById](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/TestPayPalConfigById.cs) |
| `/platform/admin/payment/config/merchant/{id}/stripeconfig` | PUT | UpdateStripeConfig | [UpdateStripeConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/PaymentConfig/UpdateStripeConfig.cs) | [UpdateStripeConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/UpdateStripeConfig.cs) |
| `/platform/admin/payment/config/merchant/{id}/stripeconfig/test` | GET | TestStripeConfigById | [TestStripeConfigById](../../apis/AccelByte.Sdk.Api.Platform/Operation/PaymentConfig/TestStripeConfigById.cs) | [TestStripeConfigById](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/TestStripeConfigById.cs) |
| `/platform/admin/payment/config/merchant/{id}/wxpayconfig` | PUT | UpdateWxPayConfig | [UpdateWxPayConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/PaymentConfig/UpdateWxPayConfig.cs) | [UpdateWxPayConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/UpdateWxPayConfig.cs) |
| `/platform/admin/payment/config/merchant/{id}/wxpayconfig/cert` | PUT | UpdateWxPayConfigCert | [UpdateWxPayConfigCert](../../apis/AccelByte.Sdk.Api.Platform/Operation/PaymentConfig/UpdateWxPayConfigCert.cs) | [UpdateWxPayConfigCert](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/UpdateWxPayConfigCert.cs) |
| `/platform/admin/payment/config/merchant/{id}/wxpayconfig/test` | GET | TestWxPayConfigById | [TestWxPayConfigById](../../apis/AccelByte.Sdk.Api.Platform/Operation/PaymentConfig/TestWxPayConfigById.cs) | [TestWxPayConfigById](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/TestWxPayConfigById.cs) |
| `/platform/admin/payment/config/merchant/{id}/xsollaconfig` | PUT | UpdateXsollaConfig | [UpdateXsollaConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/PaymentConfig/UpdateXsollaConfig.cs) | [UpdateXsollaConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/UpdateXsollaConfig.cs) |
| `/platform/admin/payment/config/merchant/{id}/xsollaconfig/test` | GET | TestXsollaConfigById | [TestXsollaConfigById](../../apis/AccelByte.Sdk.Api.Platform/Operation/PaymentConfig/TestXsollaConfigById.cs) | [TestXsollaConfigById](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/TestXsollaConfigById.cs) |
| `/platform/admin/payment/config/merchant/{id}/xsollauiconfig` | PUT | UpdateXsollaUIConfig | [UpdateXsollaUIConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/PaymentConfig/UpdateXsollaUIConfig.cs) | [UpdateXsollaUIConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/UpdateXsollaUIConfig.cs) |
| `/platform/admin/payment/config/provider` | GET | QueryPaymentProviderConfig | [QueryPaymentProviderConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/PaymentConfig/QueryPaymentProviderConfig.cs) | [QueryPaymentProviderConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/QueryPaymentProviderConfig.cs) |
| `/platform/admin/payment/config/provider` | POST | CreatePaymentProviderConfig | [CreatePaymentProviderConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/PaymentConfig/CreatePaymentProviderConfig.cs) | [CreatePaymentProviderConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/CreatePaymentProviderConfig.cs) |
| `/platform/admin/payment/config/provider/aggregate` | GET | GetAggregatePaymentProviders | [GetAggregatePaymentProviders](../../apis/AccelByte.Sdk.Api.Platform/Operation/PaymentConfig/GetAggregatePaymentProviders.cs) | [GetAggregatePaymentProviders](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/GetAggregatePaymentProviders.cs) |
| `/platform/admin/payment/config/provider/matched` | GET | DebugMatchedPaymentProviderConfig | [DebugMatchedPaymentProviderConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/PaymentConfig/DebugMatchedPaymentProviderConfig.cs) | [DebugMatchedPaymentProviderConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/DebugMatchedPaymentProviderConfig.cs) |
| `/platform/admin/payment/config/provider/special` | GET | GetSpecialPaymentProviders | [GetSpecialPaymentProviders](../../apis/AccelByte.Sdk.Api.Platform/Operation/PaymentConfig/GetSpecialPaymentProviders.cs) | [GetSpecialPaymentProviders](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/GetSpecialPaymentProviders.cs) |
| `/platform/admin/payment/config/provider/{id}` | PUT | UpdatePaymentProviderConfig | [UpdatePaymentProviderConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/PaymentConfig/UpdatePaymentProviderConfig.cs) | [UpdatePaymentProviderConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/UpdatePaymentProviderConfig.cs) |
| `/platform/admin/payment/config/provider/{id}` | DELETE | DeletePaymentProviderConfig | [DeletePaymentProviderConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/PaymentConfig/DeletePaymentProviderConfig.cs) | [DeletePaymentProviderConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/DeletePaymentProviderConfig.cs) |
| `/platform/admin/payment/config/tax` | GET | GetPaymentTaxConfig | [GetPaymentTaxConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/PaymentConfig/GetPaymentTaxConfig.cs) | [GetPaymentTaxConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/GetPaymentTaxConfig.cs) |
| `/platform/admin/payment/config/tax` | PUT | UpdatePaymentTaxConfig | [UpdatePaymentTaxConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/PaymentConfig/UpdatePaymentTaxConfig.cs) | [UpdatePaymentTaxConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/UpdatePaymentTaxConfig.cs) |

### PaymentStation Wrapper:  [PaymentStation](../../apis/AccelByte.Sdk.Api.Platform/Wrapper/PaymentStation.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| [DEPRECATED] `/platform/public/namespaces/{namespace}/payment/customization` | GET | GetPaymentCustomization | [GetPaymentCustomization](../../apis/AccelByte.Sdk.Api.Platform/Operation/PaymentStation/GetPaymentCustomization.cs) | [GetPaymentCustomization](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentStation/GetPaymentCustomization.cs) |
| `/platform/public/namespaces/{namespace}/payment/link` | POST | PublicGetPaymentUrl | [PublicGetPaymentUrl](../../apis/AccelByte.Sdk.Api.Platform/Operation/PaymentStation/PublicGetPaymentUrl.cs) | [PublicGetPaymentUrl](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentStation/PublicGetPaymentUrl.cs) |
| `/platform/public/namespaces/{namespace}/payment/methods` | GET | PublicGetPaymentMethods | [PublicGetPaymentMethods](../../apis/AccelByte.Sdk.Api.Platform/Operation/PaymentStation/PublicGetPaymentMethods.cs) | [PublicGetPaymentMethods](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentStation/PublicGetPaymentMethods.cs) |
| `/platform/public/namespaces/{namespace}/payment/orders/{paymentOrderNo}/info` | GET | PublicGetUnpaidPaymentOrder | [PublicGetUnpaidPaymentOrder](../../apis/AccelByte.Sdk.Api.Platform/Operation/PaymentStation/PublicGetUnpaidPaymentOrder.cs) | [PublicGetUnpaidPaymentOrder](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentStation/PublicGetUnpaidPaymentOrder.cs) |
| `/platform/public/namespaces/{namespace}/payment/orders/{paymentOrderNo}/pay` | POST | Pay | [Pay](../../apis/AccelByte.Sdk.Api.Platform/Operation/PaymentStation/Pay.cs) | [Pay](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentStation/Pay.cs) |
| `/platform/public/namespaces/{namespace}/payment/orders/{paymentOrderNo}/status` | GET | PublicCheckPaymentOrderPaidStatus | [PublicCheckPaymentOrderPaidStatus](../../apis/AccelByte.Sdk.Api.Platform/Operation/PaymentStation/PublicCheckPaymentOrderPaidStatus.cs) | [PublicCheckPaymentOrderPaidStatus](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentStation/PublicCheckPaymentOrderPaidStatus.cs) |
| `/platform/public/namespaces/{namespace}/payment/publicconfig` | GET | GetPaymentPublicConfig | [GetPaymentPublicConfig](../../apis/AccelByte.Sdk.Api.Platform/Operation/PaymentStation/GetPaymentPublicConfig.cs) | [GetPaymentPublicConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentStation/GetPaymentPublicConfig.cs) |
| `/platform/public/namespaces/{namespace}/payment/qrcode` | GET | PublicGetQRCode | [PublicGetQRCode](../../apis/AccelByte.Sdk.Api.Platform/Operation/PaymentStation/PublicGetQRCode.cs) | [PublicGetQRCode](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentStation/PublicGetQRCode.cs) |
| `/platform/public/namespaces/{namespace}/payment/returnurl` | GET | PublicNormalizePaymentReturnUrl | [PublicNormalizePaymentReturnUrl](../../apis/AccelByte.Sdk.Api.Platform/Operation/PaymentStation/PublicNormalizePaymentReturnUrl.cs) | [PublicNormalizePaymentReturnUrl](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentStation/PublicNormalizePaymentReturnUrl.cs) |
| `/platform/public/namespaces/{namespace}/payment/tax` | GET | GetPaymentTaxValue | [GetPaymentTaxValue](../../apis/AccelByte.Sdk.Api.Platform/Operation/PaymentStation/GetPaymentTaxValue.cs) | [GetPaymentTaxValue](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentStation/GetPaymentTaxValue.cs) |

### PaymentAccount Wrapper:  [PaymentAccount](../../apis/AccelByte.Sdk.Api.Platform/Wrapper/PaymentAccount.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/public/namespaces/{namespace}/users/{userId}/payment/accounts` | GET | PublicGetPaymentAccounts | [PublicGetPaymentAccounts](../../apis/AccelByte.Sdk.Api.Platform/Operation/PaymentAccount/PublicGetPaymentAccounts.cs) | [PublicGetPaymentAccounts](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentAccount/PublicGetPaymentAccounts.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/payment/accounts/{type}/{id}` | DELETE | PublicDeletePaymentAccount | [PublicDeletePaymentAccount](../../apis/AccelByte.Sdk.Api.Platform/Operation/PaymentAccount/PublicDeletePaymentAccount.cs) | [PublicDeletePaymentAccount](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentAccount/PublicDeletePaymentAccount.cs) |


&nbsp;

## Operations with Generic Response

### FulfillmentScript Wrapper:  [FulfillmentScript](../../apis/AccelByte.Sdk.Api.Platform/Wrapper/FulfillmentScript.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/fulfillment/scripts/tests/eval` | POST | TestFulfillmentScriptEval | [TestFulfillmentScriptEval](../../apis/AccelByte.Sdk.Api.Platform/Operation/FulfillmentScript/TestFulfillmentScriptEval.cs) | [TestFulfillmentScriptEval](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/FulfillmentScript/TestFulfillmentScriptEval.cs) |

### Item Wrapper:  [Item](../../apis/AccelByte.Sdk.Api.Platform/Wrapper/Item.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Campaign Wrapper:  [Campaign](../../apis/AccelByte.Sdk.Api.Platform/Wrapper/Campaign.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### ServicePluginConfig Wrapper:  [ServicePluginConfig](../../apis/AccelByte.Sdk.Api.Platform/Wrapper/ServicePluginConfig.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Category Wrapper:  [Category](../../apis/AccelByte.Sdk.Api.Platform/Wrapper/Category.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Currency Wrapper:  [Currency](../../apis/AccelByte.Sdk.Api.Platform/Wrapper/Currency.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### DLC Wrapper:  [DLC](../../apis/AccelByte.Sdk.Api.Platform/Wrapper/DLC.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/namespaces/{namespace}/users/{userId}/dlc/records` | GET | GetUserDLC | [GetUserDLC](../../apis/AccelByte.Sdk.Api.Platform/Operation/DLC/GetUserDLC.cs) | [GetUserDLC](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/DLC/GetUserDLC.cs) |

### Entitlement Wrapper:  [Entitlement](../../apis/AccelByte.Sdk.Api.Platform/Wrapper/Entitlement.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Fulfillment Wrapper:  [Fulfillment](../../apis/AccelByte.Sdk.Api.Platform/Wrapper/Fulfillment.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Clawback Wrapper:  [Clawback](../../apis/AccelByte.Sdk.Api.Platform/Wrapper/Clawback.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### IAP Wrapper:  [IAP](../../apis/AccelByte.Sdk.Api.Platform/Wrapper/IAP.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Invoice Wrapper:  [Invoice](../../apis/AccelByte.Sdk.Api.Platform/Wrapper/Invoice.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### KeyGroup Wrapper:  [KeyGroup](../../apis/AccelByte.Sdk.Api.Platform/Wrapper/KeyGroup.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Order Wrapper:  [Order](../../apis/AccelByte.Sdk.Api.Platform/Wrapper/Order.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### PaymentCallbackConfig Wrapper:  [PaymentCallbackConfig](../../apis/AccelByte.Sdk.Api.Platform/Wrapper/PaymentCallbackConfig.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Payment Wrapper:  [Payment](../../apis/AccelByte.Sdk.Api.Platform/Wrapper/Payment.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Payment(Dedicated) Wrapper:  [PaymentDedicated](../../apis/AccelByte.Sdk.Api.Platform/Wrapper/PaymentDedicated.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Wallet Wrapper:  [Wallet](../../apis/AccelByte.Sdk.Api.Platform/Wrapper/Wallet.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Revocation Wrapper:  [Revocation](../../apis/AccelByte.Sdk.Api.Platform/Wrapper/Revocation.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Reward Wrapper:  [Reward](../../apis/AccelByte.Sdk.Api.Platform/Wrapper/Reward.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Section Wrapper:  [Section](../../apis/AccelByte.Sdk.Api.Platform/Wrapper/Section.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Store Wrapper:  [Store](../../apis/AccelByte.Sdk.Api.Platform/Wrapper/Store.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### CatalogChanges Wrapper:  [CatalogChanges](../../apis/AccelByte.Sdk.Api.Platform/Wrapper/CatalogChanges.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Subscription Wrapper:  [Subscription](../../apis/AccelByte.Sdk.Api.Platform/Wrapper/Subscription.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Ticket Wrapper:  [Ticket](../../apis/AccelByte.Sdk.Api.Platform/Wrapper/Ticket.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Achievement(Platform) Wrapper:  [AchievementPlatform](../../apis/AccelByte.Sdk.Api.Platform/Wrapper/AchievementPlatform.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Anonymization Wrapper:  [Anonymization](../../apis/AccelByte.Sdk.Api.Platform/Wrapper/Anonymization.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Session(Platform) Wrapper:  [SessionPlatform](../../apis/AccelByte.Sdk.Api.Platform/Wrapper/SessionPlatform.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### View Wrapper:  [View](../../apis/AccelByte.Sdk.Api.Platform/Wrapper/View.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/public/namespaces/{namespace}/users/{userId}/views` | GET | PublicListViews | [PublicListViews](../../apis/AccelByte.Sdk.Api.Platform/Operation/View/PublicListViews.cs) | [PublicListViews](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/View/PublicListViews.cs) |

### Order(Dedicated) Wrapper:  [OrderDedicated](../../apis/AccelByte.Sdk.Api.Platform/Wrapper/OrderDedicated.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### PaymentConfig Wrapper:  [PaymentConfig](../../apis/AccelByte.Sdk.Api.Platform/Wrapper/PaymentConfig.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### PaymentStation Wrapper:  [PaymentStation](../../apis/AccelByte.Sdk.Api.Platform/Wrapper/PaymentStation.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### PaymentAccount Wrapper:  [PaymentAccount](../../apis/AccelByte.Sdk.Api.Platform/Wrapper/PaymentAccount.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|


&nbsp;

## Models

| Model | Class |
|---|---|
| `AchievementInfo` | [AchievementInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/AchievementInfo.cs) |
| `AdditionalData` | [AdditionalData](../../apis/AccelByte.Sdk.Api.Platform/Model/AdditionalData.cs) |
| `AdditionalDataEntitlement` | [AdditionalDataEntitlement](../../apis/AccelByte.Sdk.Api.Platform/Model/AdditionalDataEntitlement.cs) |
| `AdminOrderCreate` | [AdminOrderCreate](../../apis/AccelByte.Sdk.Api.Platform/Model/AdminOrderCreate.cs) |
| `AdyenConfig` | [AdyenConfig](../../apis/AccelByte.Sdk.Api.Platform/Model/AdyenConfig.cs) |
| `AliPayConfig` | [AliPayConfig](../../apis/AccelByte.Sdk.Api.Platform/Model/AliPayConfig.cs) |
| `AppConfig` | [AppConfig](../../apis/AccelByte.Sdk.Api.Platform/Model/AppConfig.cs) |
| `AppEntitlementInfo` | [AppEntitlementInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/AppEntitlementInfo.cs) |
| `AppEntitlementPagingSlicedResult` | [AppEntitlementPagingSlicedResult](../../apis/AccelByte.Sdk.Api.Platform/Model/AppEntitlementPagingSlicedResult.cs) |
| `AppInfo` | [AppInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/AppInfo.cs) |
| `AppLocalization` | [AppLocalization](../../apis/AccelByte.Sdk.Api.Platform/Model/AppLocalization.cs) |
| `AppUpdate` | [AppUpdate](../../apis/AccelByte.Sdk.Api.Platform/Model/AppUpdate.cs) |
| `AppleIAPConfigInfo` | [AppleIAPConfigInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/AppleIAPConfigInfo.cs) |
| `AppleIAPConfigRequest` | [AppleIAPConfigRequest](../../apis/AccelByte.Sdk.Api.Platform/Model/AppleIAPConfigRequest.cs) |
| `AppleIAPReceipt` | [AppleIAPReceipt](../../apis/AccelByte.Sdk.Api.Platform/Model/AppleIAPReceipt.cs) |
| `AvailableComparison` | [AvailableComparison](../../apis/AccelByte.Sdk.Api.Platform/Model/AvailableComparison.cs) |
| `AvailablePredicate` | [AvailablePredicate](../../apis/AccelByte.Sdk.Api.Platform/Model/AvailablePredicate.cs) |
| `BaseCustomConfig` | [BaseCustomConfig](../../apis/AccelByte.Sdk.Api.Platform/Model/BaseCustomConfig.cs) |
| `BaseTLSConfig` | [BaseTLSConfig](../../apis/AccelByte.Sdk.Api.Platform/Model/BaseTLSConfig.cs) |
| `BasicCategoryInfo` | [BasicCategoryInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/BasicCategoryInfo.cs) |
| `BasicItem` | [BasicItem](../../apis/AccelByte.Sdk.Api.Platform/Model/BasicItem.cs) |
| `BillingAccount` | [BillingAccount](../../apis/AccelByte.Sdk.Api.Platform/Model/BillingAccount.cs) |
| `BillingHistoryInfo` | [BillingHistoryInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/BillingHistoryInfo.cs) |
| `BillingHistoryPagingSlicedResult` | [BillingHistoryPagingSlicedResult](../../apis/AccelByte.Sdk.Api.Platform/Model/BillingHistoryPagingSlicedResult.cs) |
| `BoxItem` | [BoxItem](../../apis/AccelByte.Sdk.Api.Platform/Model/BoxItem.cs) |
| `BulkCreditRequest` | [BulkCreditRequest](../../apis/AccelByte.Sdk.Api.Platform/Model/BulkCreditRequest.cs) |
| `BulkCreditResult` | [BulkCreditResult](../../apis/AccelByte.Sdk.Api.Platform/Model/BulkCreditResult.cs) |
| `BulkDebitRequest` | [BulkDebitRequest](../../apis/AccelByte.Sdk.Api.Platform/Model/BulkDebitRequest.cs) |
| `BulkDebitResult` | [BulkDebitResult](../../apis/AccelByte.Sdk.Api.Platform/Model/BulkDebitResult.cs) |
| `BulkEntitlementGrantRequest` | [BulkEntitlementGrantRequest](../../apis/AccelByte.Sdk.Api.Platform/Model/BulkEntitlementGrantRequest.cs) |
| `BulkEntitlementGrantResult` | [BulkEntitlementGrantResult](../../apis/AccelByte.Sdk.Api.Platform/Model/BulkEntitlementGrantResult.cs) |
| `BulkEntitlementRevokeResult` | [BulkEntitlementRevokeResult](../../apis/AccelByte.Sdk.Api.Platform/Model/BulkEntitlementRevokeResult.cs) |
| `BulkOperationResult` | [BulkOperationResult](../../apis/AccelByte.Sdk.Api.Platform/Model/BulkOperationResult.cs) |
| `BulkRegionDataChangeRequest` | [BulkRegionDataChangeRequest](../../apis/AccelByte.Sdk.Api.Platform/Model/BulkRegionDataChangeRequest.cs) |
| `BundledItemInfo` | [BundledItemInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/BundledItemInfo.cs) |
| `CampaignCreate` | [CampaignCreate](../../apis/AccelByte.Sdk.Api.Platform/Model/CampaignCreate.cs) |
| `CampaignDynamicInfo` | [CampaignDynamicInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/CampaignDynamicInfo.cs) |
| `CampaignInfo` | [CampaignInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/CampaignInfo.cs) |
| `CampaignPagingSlicedResult` | [CampaignPagingSlicedResult](../../apis/AccelByte.Sdk.Api.Platform/Model/CampaignPagingSlicedResult.cs) |
| `CampaignUpdate` | [CampaignUpdate](../../apis/AccelByte.Sdk.Api.Platform/Model/CampaignUpdate.cs) |
| `CancelRequest` | [CancelRequest](../../apis/AccelByte.Sdk.Api.Platform/Model/CancelRequest.cs) |
| `CatalogChangeInfo` | [CatalogChangeInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/CatalogChangeInfo.cs) |
| `CatalogChangePagingSlicedResult` | [CatalogChangePagingSlicedResult](../../apis/AccelByte.Sdk.Api.Platform/Model/CatalogChangePagingSlicedResult.cs) |
| `CatalogChangeStatistics` | [CatalogChangeStatistics](../../apis/AccelByte.Sdk.Api.Platform/Model/CatalogChangeStatistics.cs) |
| `CategoryCreate` | [CategoryCreate](../../apis/AccelByte.Sdk.Api.Platform/Model/CategoryCreate.cs) |
| `CategoryInfo` | [CategoryInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/CategoryInfo.cs) |
| `CategoryUpdate` | [CategoryUpdate](../../apis/AccelByte.Sdk.Api.Platform/Model/CategoryUpdate.cs) |
| `CheckoutConfig` | [CheckoutConfig](../../apis/AccelByte.Sdk.Api.Platform/Model/CheckoutConfig.cs) |
| `ClawbackInfo` | [ClawbackInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/ClawbackInfo.cs) |
| `ClientRequestParameter` | [ClientRequestParameter](../../apis/AccelByte.Sdk.Api.Platform/Model/ClientRequestParameter.cs) |
| `ClientTransaction` | [ClientTransaction](../../apis/AccelByte.Sdk.Api.Platform/Model/ClientTransaction.cs) |
| `CodeCreate` | [CodeCreate](../../apis/AccelByte.Sdk.Api.Platform/Model/CodeCreate.cs) |
| `CodeCreateResult` | [CodeCreateResult](../../apis/AccelByte.Sdk.Api.Platform/Model/CodeCreateResult.cs) |
| `CodeInfo` | [CodeInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/CodeInfo.cs) |
| `CodeInfoPagingSlicedResult` | [CodeInfoPagingSlicedResult](../../apis/AccelByte.Sdk.Api.Platform/Model/CodeInfoPagingSlicedResult.cs) |
| `ConditionGroup` | [ConditionGroup](../../apis/AccelByte.Sdk.Api.Platform/Model/ConditionGroup.cs) |
| `ConditionGroupValidateResult` | [ConditionGroupValidateResult](../../apis/AccelByte.Sdk.Api.Platform/Model/ConditionGroupValidateResult.cs) |
| `ConditionMatchResult` | [ConditionMatchResult](../../apis/AccelByte.Sdk.Api.Platform/Model/ConditionMatchResult.cs) |
| `ConsumableEntitlementRevocationConfig` | [ConsumableEntitlementRevocationConfig](../../apis/AccelByte.Sdk.Api.Platform/Model/ConsumableEntitlementRevocationConfig.cs) |
| `ConsumeItem` | [ConsumeItem](../../apis/AccelByte.Sdk.Api.Platform/Model/ConsumeItem.cs) |
| `CreditRequest` | [CreditRequest](../../apis/AccelByte.Sdk.Api.Platform/Model/CreditRequest.cs) |
| `CreditResult` | [CreditResult](../../apis/AccelByte.Sdk.Api.Platform/Model/CreditResult.cs) |
| `CreditRevocation` | [CreditRevocation](../../apis/AccelByte.Sdk.Api.Platform/Model/CreditRevocation.cs) |
| `CreditSummary` | [CreditSummary](../../apis/AccelByte.Sdk.Api.Platform/Model/CreditSummary.cs) |
| `CurrencyConfig` | [CurrencyConfig](../../apis/AccelByte.Sdk.Api.Platform/Model/CurrencyConfig.cs) |
| `CurrencyCreate` | [CurrencyCreate](../../apis/AccelByte.Sdk.Api.Platform/Model/CurrencyCreate.cs) |
| `CurrencyInfo` | [CurrencyInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/CurrencyInfo.cs) |
| `CurrencySummary` | [CurrencySummary](../../apis/AccelByte.Sdk.Api.Platform/Model/CurrencySummary.cs) |
| `CurrencyUpdate` | [CurrencyUpdate](../../apis/AccelByte.Sdk.Api.Platform/Model/CurrencyUpdate.cs) |
| `CurrencyWallet` | [CurrencyWallet](../../apis/AccelByte.Sdk.Api.Platform/Model/CurrencyWallet.cs) |
| `Customization` | [Customization](../../apis/AccelByte.Sdk.Api.Platform/Model/Customization.cs) |
| `DLCItem` | [DLCItem](../../apis/AccelByte.Sdk.Api.Platform/Model/DLCItem.cs) |
| `DLCItemConfigInfo` | [DLCItemConfigInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/DLCItemConfigInfo.cs) |
| `DLCItemConfigUpdate` | [DLCItemConfigUpdate](../../apis/AccelByte.Sdk.Api.Platform/Model/DLCItemConfigUpdate.cs) |
| `DLCRecord` | [DLCRecord](../../apis/AccelByte.Sdk.Api.Platform/Model/DLCRecord.cs) |
| `DebitByCurrencyCodeRequest` | [DebitByCurrencyCodeRequest](../../apis/AccelByte.Sdk.Api.Platform/Model/DebitByCurrencyCodeRequest.cs) |
| `DebitRequest` | [DebitRequest](../../apis/AccelByte.Sdk.Api.Platform/Model/DebitRequest.cs) |
| `DebitResult` | [DebitResult](../../apis/AccelByte.Sdk.Api.Platform/Model/DebitResult.cs) |
| `DeleteRewardConditionRequest` | [DeleteRewardConditionRequest](../../apis/AccelByte.Sdk.Api.Platform/Model/DeleteRewardConditionRequest.cs) |
| `DetailedWalletTransactionInfo` | [DetailedWalletTransactionInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/DetailedWalletTransactionInfo.cs) |
| `DetailedWalletTransactionPagingSlicedResult` | [DetailedWalletTransactionPagingSlicedResult](../../apis/AccelByte.Sdk.Api.Platform/Model/DetailedWalletTransactionPagingSlicedResult.cs) |
| `DurableEntitlementRevocationConfig` | [DurableEntitlementRevocationConfig](../../apis/AccelByte.Sdk.Api.Platform/Model/DurableEntitlementRevocationConfig.cs) |
| `EntitlementDecrement` | [EntitlementDecrement](../../apis/AccelByte.Sdk.Api.Platform/Model/EntitlementDecrement.cs) |
| `EntitlementDecrementResult` | [EntitlementDecrementResult](../../apis/AccelByte.Sdk.Api.Platform/Model/EntitlementDecrementResult.cs) |
| `EntitlementGrant` | [EntitlementGrant](../../apis/AccelByte.Sdk.Api.Platform/Model/EntitlementGrant.cs) |
| `EntitlementGrantResult` | [EntitlementGrantResult](../../apis/AccelByte.Sdk.Api.Platform/Model/EntitlementGrantResult.cs) |
| `EntitlementHistoryInfo` | [EntitlementHistoryInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/EntitlementHistoryInfo.cs) |
| `EntitlementInfo` | [EntitlementInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/EntitlementInfo.cs) |
| `EntitlementLootBoxReward` | [EntitlementLootBoxReward](../../apis/AccelByte.Sdk.Api.Platform/Model/EntitlementLootBoxReward.cs) |
| `EntitlementOwnership` | [EntitlementOwnership](../../apis/AccelByte.Sdk.Api.Platform/Model/EntitlementOwnership.cs) |
| `EntitlementPagingSlicedResult` | [EntitlementPagingSlicedResult](../../apis/AccelByte.Sdk.Api.Platform/Model/EntitlementPagingSlicedResult.cs) |
| `EntitlementRevocation` | [EntitlementRevocation](../../apis/AccelByte.Sdk.Api.Platform/Model/EntitlementRevocation.cs) |
| `EntitlementRevocationConfig` | [EntitlementRevocationConfig](../../apis/AccelByte.Sdk.Api.Platform/Model/EntitlementRevocationConfig.cs) |
| `EntitlementRevokeResult` | [EntitlementRevokeResult](../../apis/AccelByte.Sdk.Api.Platform/Model/EntitlementRevokeResult.cs) |
| `EntitlementSoldRequest` | [EntitlementSoldRequest](../../apis/AccelByte.Sdk.Api.Platform/Model/EntitlementSoldRequest.cs) |
| `EntitlementSoldResult` | [EntitlementSoldResult](../../apis/AccelByte.Sdk.Api.Platform/Model/EntitlementSoldResult.cs) |
| `EntitlementSummary` | [EntitlementSummary](../../apis/AccelByte.Sdk.Api.Platform/Model/EntitlementSummary.cs) |
| `EntitlementUpdate` | [EntitlementUpdate](../../apis/AccelByte.Sdk.Api.Platform/Model/EntitlementUpdate.cs) |
| `EpicGamesDLCSyncRequest` | [EpicGamesDLCSyncRequest](../../apis/AccelByte.Sdk.Api.Platform/Model/EpicGamesDLCSyncRequest.cs) |
| `EpicGamesIAPConfigInfo` | [EpicGamesIAPConfigInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/EpicGamesIAPConfigInfo.cs) |
| `EpicGamesIAPConfigRequest` | [EpicGamesIAPConfigRequest](../../apis/AccelByte.Sdk.Api.Platform/Model/EpicGamesIAPConfigRequest.cs) |
| `EpicGamesReconcileRequest` | [EpicGamesReconcileRequest](../../apis/AccelByte.Sdk.Api.Platform/Model/EpicGamesReconcileRequest.cs) |
| `EpicGamesReconcileResult` | [EpicGamesReconcileResult](../../apis/AccelByte.Sdk.Api.Platform/Model/EpicGamesReconcileResult.cs) |
| `ErrorEntity` | [ErrorEntity](../../apis/AccelByte.Sdk.Api.Platform/Model/ErrorEntity.cs) |
| `EventAdditionalData` | [EventAdditionalData](../../apis/AccelByte.Sdk.Api.Platform/Model/EventAdditionalData.cs) |
| `EventPayload` | [EventPayload](../../apis/AccelByte.Sdk.Api.Platform/Model/EventPayload.cs) |
| `ExportStoreRequest` | [ExportStoreRequest](../../apis/AccelByte.Sdk.Api.Platform/Model/ExportStoreRequest.cs) |
| `ExtensionFulfillmentSummary` | [ExtensionFulfillmentSummary](../../apis/AccelByte.Sdk.Api.Platform/Model/ExtensionFulfillmentSummary.cs) |
| `ExternalPaymentOrderCreate` | [ExternalPaymentOrderCreate](../../apis/AccelByte.Sdk.Api.Platform/Model/ExternalPaymentOrderCreate.cs) |
| `FieldValidationError` | [FieldValidationError](../../apis/AccelByte.Sdk.Api.Platform/Model/FieldValidationError.cs) |
| `FixedPeriodRotationConfig` | [FixedPeriodRotationConfig](../../apis/AccelByte.Sdk.Api.Platform/Model/FixedPeriodRotationConfig.cs) |
| `FulfillCodeRequest` | [FulfillCodeRequest](../../apis/AccelByte.Sdk.Api.Platform/Model/FulfillCodeRequest.cs) |
| `FulfillmentError` | [FulfillmentError](../../apis/AccelByte.Sdk.Api.Platform/Model/FulfillmentError.cs) |
| `FulfillmentHistoryInfo` | [FulfillmentHistoryInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/FulfillmentHistoryInfo.cs) |
| `FulfillmentHistoryPagingSlicedResult` | [FulfillmentHistoryPagingSlicedResult](../../apis/AccelByte.Sdk.Api.Platform/Model/FulfillmentHistoryPagingSlicedResult.cs) |
| `FulfillmentItem` | [FulfillmentItem](../../apis/AccelByte.Sdk.Api.Platform/Model/FulfillmentItem.cs) |
| `FulfillmentRequest` | [FulfillmentRequest](../../apis/AccelByte.Sdk.Api.Platform/Model/FulfillmentRequest.cs) |
| `FulfillmentResult` | [FulfillmentResult](../../apis/AccelByte.Sdk.Api.Platform/Model/FulfillmentResult.cs) |
| `FulfillmentScriptContext` | [FulfillmentScriptContext](../../apis/AccelByte.Sdk.Api.Platform/Model/FulfillmentScriptContext.cs) |
| `FulfillmentScriptCreate` | [FulfillmentScriptCreate](../../apis/AccelByte.Sdk.Api.Platform/Model/FulfillmentScriptCreate.cs) |
| `FulfillmentScriptEvalTestRequest` | [FulfillmentScriptEvalTestRequest](../../apis/AccelByte.Sdk.Api.Platform/Model/FulfillmentScriptEvalTestRequest.cs) |
| `FulfillmentScriptEvalTestResult` | [FulfillmentScriptEvalTestResult](../../apis/AccelByte.Sdk.Api.Platform/Model/FulfillmentScriptEvalTestResult.cs) |
| `FulfillmentScriptInfo` | [FulfillmentScriptInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/FulfillmentScriptInfo.cs) |
| `FulfillmentScriptUpdate` | [FulfillmentScriptUpdate](../../apis/AccelByte.Sdk.Api.Platform/Model/FulfillmentScriptUpdate.cs) |
| `FullAppInfo` | [FullAppInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/FullAppInfo.cs) |
| `FullCategoryInfo` | [FullCategoryInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/FullCategoryInfo.cs) |
| `FullItemInfo` | [FullItemInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/FullItemInfo.cs) |
| `FullItemPagingSlicedResult` | [FullItemPagingSlicedResult](../../apis/AccelByte.Sdk.Api.Platform/Model/FullItemPagingSlicedResult.cs) |
| `FullSectionInfo` | [FullSectionInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/FullSectionInfo.cs) |
| `FullViewInfo` | [FullViewInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/FullViewInfo.cs) |
| `GoogleIAPConfigInfo` | [GoogleIAPConfigInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/GoogleIAPConfigInfo.cs) |
| `GoogleIAPConfigRequest` | [GoogleIAPConfigRequest](../../apis/AccelByte.Sdk.Api.Platform/Model/GoogleIAPConfigRequest.cs) |
| `GoogleIAPReceipt` | [GoogleIAPReceipt](../../apis/AccelByte.Sdk.Api.Platform/Model/GoogleIAPReceipt.cs) |
| `GoogleReceiptResolveResult` | [GoogleReceiptResolveResult](../../apis/AccelByte.Sdk.Api.Platform/Model/GoogleReceiptResolveResult.cs) |
| `GrantSubscriptionDaysRequest` | [GrantSubscriptionDaysRequest](../../apis/AccelByte.Sdk.Api.Platform/Model/GrantSubscriptionDaysRequest.cs) |
| `GrpcServerInfo` | [GrpcServerInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/GrpcServerInfo.cs) |
| `HierarchicalCategoryInfo` | [HierarchicalCategoryInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/HierarchicalCategoryInfo.cs) |
| `IAPClawbackPagingSlicedResult` | [IAPClawbackPagingSlicedResult](../../apis/AccelByte.Sdk.Api.Platform/Model/IAPClawbackPagingSlicedResult.cs) |
| `IAPConsumeHistoryInfo` | [IAPConsumeHistoryInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/IAPConsumeHistoryInfo.cs) |
| `IAPConsumeHistoryPagingSlicedResult` | [IAPConsumeHistoryPagingSlicedResult](../../apis/AccelByte.Sdk.Api.Platform/Model/IAPConsumeHistoryPagingSlicedResult.cs) |
| `IAPItemConfigInfo` | [IAPItemConfigInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/IAPItemConfigInfo.cs) |
| `IAPItemConfigUpdate` | [IAPItemConfigUpdate](../../apis/AccelByte.Sdk.Api.Platform/Model/IAPItemConfigUpdate.cs) |
| `IAPItemEntry` | [IAPItemEntry](../../apis/AccelByte.Sdk.Api.Platform/Model/IAPItemEntry.cs) |
| `IAPItemFlatEntry` | [IAPItemFlatEntry](../../apis/AccelByte.Sdk.Api.Platform/Model/IAPItemFlatEntry.cs) |
| `IAPItemMappingInfo` | [IAPItemMappingInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/IAPItemMappingInfo.cs) |
| `IAPOrderInfo` | [IAPOrderInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/IAPOrderInfo.cs) |
| `IAPOrderPagingSlicedResult` | [IAPOrderPagingSlicedResult](../../apis/AccelByte.Sdk.Api.Platform/Model/IAPOrderPagingSlicedResult.cs) |
| `Image` | [Image](../../apis/AccelByte.Sdk.Api.Platform/Model/Image.cs) |
| `ImportErrorDetails` | [ImportErrorDetails](../../apis/AccelByte.Sdk.Api.Platform/Model/ImportErrorDetails.cs) |
| `ImportStoreError` | [ImportStoreError](../../apis/AccelByte.Sdk.Api.Platform/Model/ImportStoreError.cs) |
| `ImportStoreItemInfo` | [ImportStoreItemInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/ImportStoreItemInfo.cs) |
| `ImportStoreResult` | [ImportStoreResult](../../apis/AccelByte.Sdk.Api.Platform/Model/ImportStoreResult.cs) |
| `InGameItemSync` | [InGameItemSync](../../apis/AccelByte.Sdk.Api.Platform/Model/InGameItemSync.cs) |
| `InvoiceCurrencySummary` | [InvoiceCurrencySummary](../../apis/AccelByte.Sdk.Api.Platform/Model/InvoiceCurrencySummary.cs) |
| `InvoiceSummary` | [InvoiceSummary](../../apis/AccelByte.Sdk.Api.Platform/Model/InvoiceSummary.cs) |
| `ItemAcquireRequest` | [ItemAcquireRequest](../../apis/AccelByte.Sdk.Api.Platform/Model/ItemAcquireRequest.cs) |
| `ItemAcquireResult` | [ItemAcquireResult](../../apis/AccelByte.Sdk.Api.Platform/Model/ItemAcquireResult.cs) |
| `ItemCreate` | [ItemCreate](../../apis/AccelByte.Sdk.Api.Platform/Model/ItemCreate.cs) |
| `ItemDynamicDataInfo` | [ItemDynamicDataInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/ItemDynamicDataInfo.cs) |
| `ItemId` | [ItemId](../../apis/AccelByte.Sdk.Api.Platform/Model/ItemId.cs) |
| `ItemInfo` | [ItemInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/ItemInfo.cs) |
| `ItemNaming` | [ItemNaming](../../apis/AccelByte.Sdk.Api.Platform/Model/ItemNaming.cs) |
| `ItemPagingSlicedResult` | [ItemPagingSlicedResult](../../apis/AccelByte.Sdk.Api.Platform/Model/ItemPagingSlicedResult.cs) |
| `ItemPurchaseConditionValidateRequest` | [ItemPurchaseConditionValidateRequest](../../apis/AccelByte.Sdk.Api.Platform/Model/ItemPurchaseConditionValidateRequest.cs) |
| `ItemPurchaseConditionValidateResult` | [ItemPurchaseConditionValidateResult](../../apis/AccelByte.Sdk.Api.Platform/Model/ItemPurchaseConditionValidateResult.cs) |
| `ItemReturnRequest` | [ItemReturnRequest](../../apis/AccelByte.Sdk.Api.Platform/Model/ItemReturnRequest.cs) |
| `ItemRevocation` | [ItemRevocation](../../apis/AccelByte.Sdk.Api.Platform/Model/ItemRevocation.cs) |
| `ItemSnapshot` | [ItemSnapshot](../../apis/AccelByte.Sdk.Api.Platform/Model/ItemSnapshot.cs) |
| `ItemTypeConfigCreate` | [ItemTypeConfigCreate](../../apis/AccelByte.Sdk.Api.Platform/Model/ItemTypeConfigCreate.cs) |
| `ItemTypeConfigInfo` | [ItemTypeConfigInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/ItemTypeConfigInfo.cs) |
| `ItemTypeConfigUpdate` | [ItemTypeConfigUpdate](../../apis/AccelByte.Sdk.Api.Platform/Model/ItemTypeConfigUpdate.cs) |
| `ItemUpdate` | [ItemUpdate](../../apis/AccelByte.Sdk.Api.Platform/Model/ItemUpdate.cs) |
| `KeyGroupCreate` | [KeyGroupCreate](../../apis/AccelByte.Sdk.Api.Platform/Model/KeyGroupCreate.cs) |
| `KeyGroupDynamicInfo` | [KeyGroupDynamicInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/KeyGroupDynamicInfo.cs) |
| `KeyGroupInfo` | [KeyGroupInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/KeyGroupInfo.cs) |
| `KeyGroupPagingSlicedResult` | [KeyGroupPagingSlicedResult](../../apis/AccelByte.Sdk.Api.Platform/Model/KeyGroupPagingSlicedResult.cs) |
| `KeyGroupUpdate` | [KeyGroupUpdate](../../apis/AccelByte.Sdk.Api.Platform/Model/KeyGroupUpdate.cs) |
| `KeyInfo` | [KeyInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/KeyInfo.cs) |
| `KeyPagingSliceResult` | [KeyPagingSliceResult](../../apis/AccelByte.Sdk.Api.Platform/Model/KeyPagingSliceResult.cs) |
| `ListViewInfo` | [ListViewInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/ListViewInfo.cs) |
| `Localization` | [Localization](../../apis/AccelByte.Sdk.Api.Platform/Model/Localization.cs) |
| `LootBoxConfig` | [LootBoxConfig](../../apis/AccelByte.Sdk.Api.Platform/Model/LootBoxConfig.cs) |
| `LootBoxPluginConfigInfo` | [LootBoxPluginConfigInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/LootBoxPluginConfigInfo.cs) |
| `LootBoxPluginConfigUpdate` | [LootBoxPluginConfigUpdate](../../apis/AccelByte.Sdk.Api.Platform/Model/LootBoxPluginConfigUpdate.cs) |
| `LootBoxReward` | [LootBoxReward](../../apis/AccelByte.Sdk.Api.Platform/Model/LootBoxReward.cs) |
| `MockIAPReceipt` | [MockIAPReceipt](../../apis/AccelByte.Sdk.Api.Platform/Model/MockIAPReceipt.cs) |
| `NotificationProcessResult` | [NotificationProcessResult](../../apis/AccelByte.Sdk.Api.Platform/Model/NotificationProcessResult.cs) |
| `OculusIAPConfigInfo` | [OculusIAPConfigInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/OculusIAPConfigInfo.cs) |
| `OculusIAPConfigRequest` | [OculusIAPConfigRequest](../../apis/AccelByte.Sdk.Api.Platform/Model/OculusIAPConfigRequest.cs) |
| `OculusReconcileResult` | [OculusReconcileResult](../../apis/AccelByte.Sdk.Api.Platform/Model/OculusReconcileResult.cs) |
| `OptionBoxConfig` | [OptionBoxConfig](../../apis/AccelByte.Sdk.Api.Platform/Model/OptionBoxConfig.cs) |
| `Order` | [Order](../../apis/AccelByte.Sdk.Api.Platform/Model/Order.cs) |
| `OrderCreate` | [OrderCreate](../../apis/AccelByte.Sdk.Api.Platform/Model/OrderCreate.cs) |
| `OrderCreationOptions` | [OrderCreationOptions](../../apis/AccelByte.Sdk.Api.Platform/Model/OrderCreationOptions.cs) |
| `OrderGrantInfo` | [OrderGrantInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/OrderGrantInfo.cs) |
| `OrderHistoryInfo` | [OrderHistoryInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/OrderHistoryInfo.cs) |
| `OrderInfo` | [OrderInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/OrderInfo.cs) |
| `OrderPagingResult` | [OrderPagingResult](../../apis/AccelByte.Sdk.Api.Platform/Model/OrderPagingResult.cs) |
| `OrderPagingSlicedResult` | [OrderPagingSlicedResult](../../apis/AccelByte.Sdk.Api.Platform/Model/OrderPagingSlicedResult.cs) |
| `OrderRefundCreate` | [OrderRefundCreate](../../apis/AccelByte.Sdk.Api.Platform/Model/OrderRefundCreate.cs) |
| `OrderStatistics` | [OrderStatistics](../../apis/AccelByte.Sdk.Api.Platform/Model/OrderStatistics.cs) |
| `OrderSummary` | [OrderSummary](../../apis/AccelByte.Sdk.Api.Platform/Model/OrderSummary.cs) |
| `OrderSyncResult` | [OrderSyncResult](../../apis/AccelByte.Sdk.Api.Platform/Model/OrderSyncResult.cs) |
| `OrderUpdate` | [OrderUpdate](../../apis/AccelByte.Sdk.Api.Platform/Model/OrderUpdate.cs) |
| `Ownership` | [Ownership](../../apis/AccelByte.Sdk.Api.Platform/Model/Ownership.cs) |
| `OwnershipToken` | [OwnershipToken](../../apis/AccelByte.Sdk.Api.Platform/Model/OwnershipToken.cs) |
| `Paging` | [Paging](../../apis/AccelByte.Sdk.Api.Platform/Model/Paging.cs) |
| `PayPalConfig` | [PayPalConfig](../../apis/AccelByte.Sdk.Api.Platform/Model/PayPalConfig.cs) |
| `PaymentAccount` | [PaymentAccount](../../apis/AccelByte.Sdk.Api.Platform/Model/PaymentAccount.cs) |
| `PaymentCallbackConfigInfo` | [PaymentCallbackConfigInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/PaymentCallbackConfigInfo.cs) |
| `PaymentCallbackConfigUpdate` | [PaymentCallbackConfigUpdate](../../apis/AccelByte.Sdk.Api.Platform/Model/PaymentCallbackConfigUpdate.cs) |
| `PaymentMerchantConfigInfo` | [PaymentMerchantConfigInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/PaymentMerchantConfigInfo.cs) |
| `PaymentMethod` | [PaymentMethod](../../apis/AccelByte.Sdk.Api.Platform/Model/PaymentMethod.cs) |
| `PaymentNotificationInfo` | [PaymentNotificationInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/PaymentNotificationInfo.cs) |
| `PaymentNotificationPagingSlicedResult` | [PaymentNotificationPagingSlicedResult](../../apis/AccelByte.Sdk.Api.Platform/Model/PaymentNotificationPagingSlicedResult.cs) |
| `PaymentOrder` | [PaymentOrder](../../apis/AccelByte.Sdk.Api.Platform/Model/PaymentOrder.cs) |
| `PaymentOrderChargeRequest` | [PaymentOrderChargeRequest](../../apis/AccelByte.Sdk.Api.Platform/Model/PaymentOrderChargeRequest.cs) |
| `PaymentOrderChargeStatus` | [PaymentOrderChargeStatus](../../apis/AccelByte.Sdk.Api.Platform/Model/PaymentOrderChargeStatus.cs) |
| `PaymentOrderCreate` | [PaymentOrderCreate](../../apis/AccelByte.Sdk.Api.Platform/Model/PaymentOrderCreate.cs) |
| `PaymentOrderCreateResult` | [PaymentOrderCreateResult](../../apis/AccelByte.Sdk.Api.Platform/Model/PaymentOrderCreateResult.cs) |
| `PaymentOrderDetails` | [PaymentOrderDetails](../../apis/AccelByte.Sdk.Api.Platform/Model/PaymentOrderDetails.cs) |
| `PaymentOrderInfo` | [PaymentOrderInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/PaymentOrderInfo.cs) |
| `PaymentOrderNotifySimulation` | [PaymentOrderNotifySimulation](../../apis/AccelByte.Sdk.Api.Platform/Model/PaymentOrderNotifySimulation.cs) |
| `PaymentOrderPagingSlicedResult` | [PaymentOrderPagingSlicedResult](../../apis/AccelByte.Sdk.Api.Platform/Model/PaymentOrderPagingSlicedResult.cs) |
| `PaymentOrderPaidResult` | [PaymentOrderPaidResult](../../apis/AccelByte.Sdk.Api.Platform/Model/PaymentOrderPaidResult.cs) |
| `PaymentOrderRefund` | [PaymentOrderRefund](../../apis/AccelByte.Sdk.Api.Platform/Model/PaymentOrderRefund.cs) |
| `PaymentOrderRefundResult` | [PaymentOrderRefundResult](../../apis/AccelByte.Sdk.Api.Platform/Model/PaymentOrderRefundResult.cs) |
| `PaymentOrderSyncResult` | [PaymentOrderSyncResult](../../apis/AccelByte.Sdk.Api.Platform/Model/PaymentOrderSyncResult.cs) |
| `PaymentProcessResult` | [PaymentProcessResult](../../apis/AccelByte.Sdk.Api.Platform/Model/PaymentProcessResult.cs) |
| `PaymentProviderConfigEdit` | [PaymentProviderConfigEdit](../../apis/AccelByte.Sdk.Api.Platform/Model/PaymentProviderConfigEdit.cs) |
| `PaymentProviderConfigInfo` | [PaymentProviderConfigInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/PaymentProviderConfigInfo.cs) |
| `PaymentProviderConfigPagingSlicedResult` | [PaymentProviderConfigPagingSlicedResult](../../apis/AccelByte.Sdk.Api.Platform/Model/PaymentProviderConfigPagingSlicedResult.cs) |
| `PaymentRequest` | [PaymentRequest](../../apis/AccelByte.Sdk.Api.Platform/Model/PaymentRequest.cs) |
| `PaymentTaxConfigEdit` | [PaymentTaxConfigEdit](../../apis/AccelByte.Sdk.Api.Platform/Model/PaymentTaxConfigEdit.cs) |
| `PaymentTaxConfigInfo` | [PaymentTaxConfigInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/PaymentTaxConfigInfo.cs) |
| `PaymentToken` | [PaymentToken](../../apis/AccelByte.Sdk.Api.Platform/Model/PaymentToken.cs) |
| `PaymentUrl` | [PaymentUrl](../../apis/AccelByte.Sdk.Api.Platform/Model/PaymentUrl.cs) |
| `PaymentUrlCreate` | [PaymentUrlCreate](../../apis/AccelByte.Sdk.Api.Platform/Model/PaymentUrlCreate.cs) |
| `PlatformDLCConfigInfo` | [PlatformDLCConfigInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/PlatformDLCConfigInfo.cs) |
| `PlatformDLCConfigUpdate` | [PlatformDLCConfigUpdate](../../apis/AccelByte.Sdk.Api.Platform/Model/PlatformDLCConfigUpdate.cs) |
| `PlatformDlcEntry` | [PlatformDlcEntry](../../apis/AccelByte.Sdk.Api.Platform/Model/PlatformDlcEntry.cs) |
| `PlatformReward` | [PlatformReward](../../apis/AccelByte.Sdk.Api.Platform/Model/PlatformReward.cs) |
| `PlatformRewardCurrency` | [PlatformRewardCurrency](../../apis/AccelByte.Sdk.Api.Platform/Model/PlatformRewardCurrency.cs) |
| `PlatformRewardItem` | [PlatformRewardItem](../../apis/AccelByte.Sdk.Api.Platform/Model/PlatformRewardItem.cs) |
| `PlatformSubscribeRequest` | [PlatformSubscribeRequest](../../apis/AccelByte.Sdk.Api.Platform/Model/PlatformSubscribeRequest.cs) |
| `PlatformWallet` | [PlatformWallet](../../apis/AccelByte.Sdk.Api.Platform/Model/PlatformWallet.cs) |
| `PlatformWalletConfigInfo` | [PlatformWalletConfigInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/PlatformWalletConfigInfo.cs) |
| `PlatformWalletConfigUpdate` | [PlatformWalletConfigUpdate](../../apis/AccelByte.Sdk.Api.Platform/Model/PlatformWalletConfigUpdate.cs) |
| `PlayStationDLCSyncMultiServiceLabelsRequest` | [PlayStationDLCSyncMultiServiceLabelsRequest](../../apis/AccelByte.Sdk.Api.Platform/Model/PlayStationDLCSyncMultiServiceLabelsRequest.cs) |
| `PlayStationDLCSyncRequest` | [PlayStationDLCSyncRequest](../../apis/AccelByte.Sdk.Api.Platform/Model/PlayStationDLCSyncRequest.cs) |
| `PlayStationIAPConfigInfo` | [PlayStationIAPConfigInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/PlayStationIAPConfigInfo.cs) |
| `PlayStationMultiServiceLabelsReconcileRequest` | [PlayStationMultiServiceLabelsReconcileRequest](../../apis/AccelByte.Sdk.Api.Platform/Model/PlayStationMultiServiceLabelsReconcileRequest.cs) |
| `PlayStationReconcileRequest` | [PlayStationReconcileRequest](../../apis/AccelByte.Sdk.Api.Platform/Model/PlayStationReconcileRequest.cs) |
| `PlayStationReconcileResult` | [PlayStationReconcileResult](../../apis/AccelByte.Sdk.Api.Platform/Model/PlayStationReconcileResult.cs) |
| `PlaystationIAPConfigRequest` | [PlaystationIAPConfigRequest](../../apis/AccelByte.Sdk.Api.Platform/Model/PlaystationIAPConfigRequest.cs) |
| `PopulatedItemInfo` | [PopulatedItemInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/PopulatedItemInfo.cs) |
| `Predicate` | [Predicate](../../apis/AccelByte.Sdk.Api.Platform/Model/Predicate.cs) |
| `PredicateValidateResult` | [PredicateValidateResult](../../apis/AccelByte.Sdk.Api.Platform/Model/PredicateValidateResult.cs) |
| `PublicCustomConfigInfo` | [PublicCustomConfigInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/PublicCustomConfigInfo.cs) |
| `PurchaseCondition` | [PurchaseCondition](../../apis/AccelByte.Sdk.Api.Platform/Model/PurchaseCondition.cs) |
| `PurchaseConditionUpdate` | [PurchaseConditionUpdate](../../apis/AccelByte.Sdk.Api.Platform/Model/PurchaseConditionUpdate.cs) |
| `PurchasedItemCount` | [PurchasedItemCount](../../apis/AccelByte.Sdk.Api.Platform/Model/PurchasedItemCount.cs) |
| `Recurring` | [Recurring](../../apis/AccelByte.Sdk.Api.Platform/Model/Recurring.cs) |
| `RecurringChargeResult` | [RecurringChargeResult](../../apis/AccelByte.Sdk.Api.Platform/Model/RecurringChargeResult.cs) |
| `RedeemHistoryInfo` | [RedeemHistoryInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/RedeemHistoryInfo.cs) |
| `RedeemHistoryPagingSlicedResult` | [RedeemHistoryPagingSlicedResult](../../apis/AccelByte.Sdk.Api.Platform/Model/RedeemHistoryPagingSlicedResult.cs) |
| `RedeemRequest` | [RedeemRequest](../../apis/AccelByte.Sdk.Api.Platform/Model/RedeemRequest.cs) |
| `RedeemResult` | [RedeemResult](../../apis/AccelByte.Sdk.Api.Platform/Model/RedeemResult.cs) |
| `RedeemableItem` | [RedeemableItem](../../apis/AccelByte.Sdk.Api.Platform/Model/RedeemableItem.cs) |
| `RegionDataChange` | [RegionDataChange](../../apis/AccelByte.Sdk.Api.Platform/Model/RegionDataChange.cs) |
| `RegionDataItem` | [RegionDataItem](../../apis/AccelByte.Sdk.Api.Platform/Model/RegionDataItem.cs) |
| `RegionDataItemDTO` | [RegionDataItemDTO](../../apis/AccelByte.Sdk.Api.Platform/Model/RegionDataItemDTO.cs) |
| `RequestHistory` | [RequestHistory](../../apis/AccelByte.Sdk.Api.Platform/Model/RequestHistory.cs) |
| `Requirement` | [Requirement](../../apis/AccelByte.Sdk.Api.Platform/Model/Requirement.cs) |
| `RevocationConfigInfo` | [RevocationConfigInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/RevocationConfigInfo.cs) |
| `RevocationConfigUpdate` | [RevocationConfigUpdate](../../apis/AccelByte.Sdk.Api.Platform/Model/RevocationConfigUpdate.cs) |
| `RevocationError` | [RevocationError](../../apis/AccelByte.Sdk.Api.Platform/Model/RevocationError.cs) |
| `RevocationHistoryInfo` | [RevocationHistoryInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/RevocationHistoryInfo.cs) |
| `RevocationHistoryPagingSlicedResult` | [RevocationHistoryPagingSlicedResult](../../apis/AccelByte.Sdk.Api.Platform/Model/RevocationHistoryPagingSlicedResult.cs) |
| `RevocationPluginConfigInfo` | [RevocationPluginConfigInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/RevocationPluginConfigInfo.cs) |
| `RevocationPluginConfigUpdate` | [RevocationPluginConfigUpdate](../../apis/AccelByte.Sdk.Api.Platform/Model/RevocationPluginConfigUpdate.cs) |
| `RevocationRequest` | [RevocationRequest](../../apis/AccelByte.Sdk.Api.Platform/Model/RevocationRequest.cs) |
| `RevocationResult` | [RevocationResult](../../apis/AccelByte.Sdk.Api.Platform/Model/RevocationResult.cs) |
| `RevokeCurrency` | [RevokeCurrency](../../apis/AccelByte.Sdk.Api.Platform/Model/RevokeCurrency.cs) |
| `RevokeEntitlement` | [RevokeEntitlement](../../apis/AccelByte.Sdk.Api.Platform/Model/RevokeEntitlement.cs) |
| `RevokeEntry` | [RevokeEntry](../../apis/AccelByte.Sdk.Api.Platform/Model/RevokeEntry.cs) |
| `RevokeItem` | [RevokeItem](../../apis/AccelByte.Sdk.Api.Platform/Model/RevokeItem.cs) |
| `RevokeItemSummary` | [RevokeItemSummary](../../apis/AccelByte.Sdk.Api.Platform/Model/RevokeItemSummary.cs) |
| `RevokeResult` | [RevokeResult](../../apis/AccelByte.Sdk.Api.Platform/Model/RevokeResult.cs) |
| `RevokeUseCountRequest` | [RevokeUseCountRequest](../../apis/AccelByte.Sdk.Api.Platform/Model/RevokeUseCountRequest.cs) |
| `RewardCondition` | [RewardCondition](../../apis/AccelByte.Sdk.Api.Platform/Model/RewardCondition.cs) |
| `RewardCreate` | [RewardCreate](../../apis/AccelByte.Sdk.Api.Platform/Model/RewardCreate.cs) |
| `RewardInfo` | [RewardInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/RewardInfo.cs) |
| `RewardItem` | [RewardItem](../../apis/AccelByte.Sdk.Api.Platform/Model/RewardItem.cs) |
| `RewardPagingSlicedResult` | [RewardPagingSlicedResult](../../apis/AccelByte.Sdk.Api.Platform/Model/RewardPagingSlicedResult.cs) |
| `RewardUpdate` | [RewardUpdate](../../apis/AccelByte.Sdk.Api.Platform/Model/RewardUpdate.cs) |
| `RewardsRequest` | [RewardsRequest](../../apis/AccelByte.Sdk.Api.Platform/Model/RewardsRequest.cs) |
| `SaleConfig` | [SaleConfig](../../apis/AccelByte.Sdk.Api.Platform/Model/SaleConfig.cs) |
| `SectionCreate` | [SectionCreate](../../apis/AccelByte.Sdk.Api.Platform/Model/SectionCreate.cs) |
| `SectionInfo` | [SectionInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/SectionInfo.cs) |
| `SectionItem` | [SectionItem](../../apis/AccelByte.Sdk.Api.Platform/Model/SectionItem.cs) |
| `SectionPagingSlicedResult` | [SectionPagingSlicedResult](../../apis/AccelByte.Sdk.Api.Platform/Model/SectionPagingSlicedResult.cs) |
| `SectionPluginConfigInfo` | [SectionPluginConfigInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/SectionPluginConfigInfo.cs) |
| `SectionPluginConfigUpdate` | [SectionPluginConfigUpdate](../../apis/AccelByte.Sdk.Api.Platform/Model/SectionPluginConfigUpdate.cs) |
| `SectionUpdate` | [SectionUpdate](../../apis/AccelByte.Sdk.Api.Platform/Model/SectionUpdate.cs) |
| `ServicePluginConfigInfo` | [ServicePluginConfigInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/ServicePluginConfigInfo.cs) |
| `ServicePluginConfigUpdate` | [ServicePluginConfigUpdate](../../apis/AccelByte.Sdk.Api.Platform/Model/ServicePluginConfigUpdate.cs) |
| `Slide` | [Slide](../../apis/AccelByte.Sdk.Api.Platform/Model/Slide.cs) |
| `StackableEntitlementInfo` | [StackableEntitlementInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/StackableEntitlementInfo.cs) |
| `SteamAchievementUpdateRequest` | [SteamAchievementUpdateRequest](../../apis/AccelByte.Sdk.Api.Platform/Model/SteamAchievementUpdateRequest.cs) |
| `SteamDLCSyncRequest` | [SteamDLCSyncRequest](../../apis/AccelByte.Sdk.Api.Platform/Model/SteamDLCSyncRequest.cs) |
| `SteamIAPConfig` | [SteamIAPConfig](../../apis/AccelByte.Sdk.Api.Platform/Model/SteamIAPConfig.cs) |
| `SteamIAPConfigInfo` | [SteamIAPConfigInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/SteamIAPConfigInfo.cs) |
| `SteamIAPConfigRequest` | [SteamIAPConfigRequest](../../apis/AccelByte.Sdk.Api.Platform/Model/SteamIAPConfigRequest.cs) |
| `SteamSyncRequest` | [SteamSyncRequest](../../apis/AccelByte.Sdk.Api.Platform/Model/SteamSyncRequest.cs) |
| `StoreBackupInfo` | [StoreBackupInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/StoreBackupInfo.cs) |
| `StoreCreate` | [StoreCreate](../../apis/AccelByte.Sdk.Api.Platform/Model/StoreCreate.cs) |
| `StoreInfo` | [StoreInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/StoreInfo.cs) |
| `StoreUpdate` | [StoreUpdate](../../apis/AccelByte.Sdk.Api.Platform/Model/StoreUpdate.cs) |
| `StreamEvent` | [StreamEvent](../../apis/AccelByte.Sdk.Api.Platform/Model/StreamEvent.cs) |
| `StreamEventBody` | [StreamEventBody](../../apis/AccelByte.Sdk.Api.Platform/Model/StreamEventBody.cs) |
| `StripeConfig` | [StripeConfig](../../apis/AccelByte.Sdk.Api.Platform/Model/StripeConfig.cs) |
| `Subscribable` | [Subscribable](../../apis/AccelByte.Sdk.Api.Platform/Model/Subscribable.cs) |
| `SubscribeRequest` | [SubscribeRequest](../../apis/AccelByte.Sdk.Api.Platform/Model/SubscribeRequest.cs) |
| `SubscriptionActivityInfo` | [SubscriptionActivityInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/SubscriptionActivityInfo.cs) |
| `SubscriptionActivityPagingSlicedResult` | [SubscriptionActivityPagingSlicedResult](../../apis/AccelByte.Sdk.Api.Platform/Model/SubscriptionActivityPagingSlicedResult.cs) |
| `SubscriptionInfo` | [SubscriptionInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/SubscriptionInfo.cs) |
| `SubscriptionPagingSlicedResult` | [SubscriptionPagingSlicedResult](../../apis/AccelByte.Sdk.Api.Platform/Model/SubscriptionPagingSlicedResult.cs) |
| `SubscriptionSummary` | [SubscriptionSummary](../../apis/AccelByte.Sdk.Api.Platform/Model/SubscriptionSummary.cs) |
| `TLSConfig` | [TLSConfig](../../apis/AccelByte.Sdk.Api.Platform/Model/TLSConfig.cs) |
| `TaxResult` | [TaxResult](../../apis/AccelByte.Sdk.Api.Platform/Model/TaxResult.cs) |
| `TestResult` | [TestResult](../../apis/AccelByte.Sdk.Api.Platform/Model/TestResult.cs) |
| `TicketAcquireRequest` | [TicketAcquireRequest](../../apis/AccelByte.Sdk.Api.Platform/Model/TicketAcquireRequest.cs) |
| `TicketAcquireResult` | [TicketAcquireResult](../../apis/AccelByte.Sdk.Api.Platform/Model/TicketAcquireResult.cs) |
| `TicketBoothID` | [TicketBoothID](../../apis/AccelByte.Sdk.Api.Platform/Model/TicketBoothID.cs) |
| `TicketDynamicInfo` | [TicketDynamicInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/TicketDynamicInfo.cs) |
| `TicketSaleDecrementRequest` | [TicketSaleDecrementRequest](../../apis/AccelByte.Sdk.Api.Platform/Model/TicketSaleDecrementRequest.cs) |
| `TicketSaleIncrementRequest` | [TicketSaleIncrementRequest](../../apis/AccelByte.Sdk.Api.Platform/Model/TicketSaleIncrementRequest.cs) |
| `TicketSaleIncrementResult` | [TicketSaleIncrementResult](../../apis/AccelByte.Sdk.Api.Platform/Model/TicketSaleIncrementResult.cs) |
| `Time-limited balance` | [TimeLimitedBalance](../../apis/AccelByte.Sdk.Api.Platform/Model/TimeLimitedBalance.cs) |
| `TimedOwnership` | [TimedOwnership](../../apis/AccelByte.Sdk.Api.Platform/Model/TimedOwnership.cs) |
| `TradeNotification` | [TradeNotification](../../apis/AccelByte.Sdk.Api.Platform/Model/TradeNotification.cs) |
| `Transaction` | [Transaction](../../apis/AccelByte.Sdk.Api.Platform/Model/Transaction.cs) |
| `TransactionAmountDetails` | [TransactionAmountDetails](../../apis/AccelByte.Sdk.Api.Platform/Model/TransactionAmountDetails.cs) |
| `TwitchIAPConfigInfo` | [TwitchIAPConfigInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/TwitchIAPConfigInfo.cs) |
| `TwitchIAPConfigRequest` | [TwitchIAPConfigRequest](../../apis/AccelByte.Sdk.Api.Platform/Model/TwitchIAPConfigRequest.cs) |
| `TwitchSyncRequest` | [TwitchSyncRequest](../../apis/AccelByte.Sdk.Api.Platform/Model/TwitchSyncRequest.cs) |
| `TwitchSyncResult` | [TwitchSyncResult](../../apis/AccelByte.Sdk.Api.Platform/Model/TwitchSyncResult.cs) |
| `UserDLC` | [UserDLC](../../apis/AccelByte.Sdk.Api.Platform/Model/UserDLC.cs) |
| `UserDLCRecord` | [UserDLCRecord](../../apis/AccelByte.Sdk.Api.Platform/Model/UserDLCRecord.cs) |
| `ValidationErrorEntity` | [ValidationErrorEntity](../../apis/AccelByte.Sdk.Api.Platform/Model/ValidationErrorEntity.cs) |
| `ViewCreate` | [ViewCreate](../../apis/AccelByte.Sdk.Api.Platform/Model/ViewCreate.cs) |
| `ViewInfo` | [ViewInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/ViewInfo.cs) |
| `ViewUpdate` | [ViewUpdate](../../apis/AccelByte.Sdk.Api.Platform/Model/ViewUpdate.cs) |
| `WalletInfo` | [WalletInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/WalletInfo.cs) |
| `WalletPagingSlicedResult` | [WalletPagingSlicedResult](../../apis/AccelByte.Sdk.Api.Platform/Model/WalletPagingSlicedResult.cs) |
| `WalletRevocationConfig` | [WalletRevocationConfig](../../apis/AccelByte.Sdk.Api.Platform/Model/WalletRevocationConfig.cs) |
| `WalletTransactionInfo` | [WalletTransactionInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/WalletTransactionInfo.cs) |
| `WalletTransactionPagingSlicedResult` | [WalletTransactionPagingSlicedResult](../../apis/AccelByte.Sdk.Api.Platform/Model/WalletTransactionPagingSlicedResult.cs) |
| `WxPayConfigInfo` | [WxPayConfigInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/WxPayConfigInfo.cs) |
| `WxPayConfigRequest` | [WxPayConfigRequest](../../apis/AccelByte.Sdk.Api.Platform/Model/WxPayConfigRequest.cs) |
| `XblAchievementUpdateRequest` | [XblAchievementUpdateRequest](../../apis/AccelByte.Sdk.Api.Platform/Model/XblAchievementUpdateRequest.cs) |
| `XblDLCSyncRequest` | [XblDLCSyncRequest](../../apis/AccelByte.Sdk.Api.Platform/Model/XblDLCSyncRequest.cs) |
| `XblIAPConfigInfo` | [XblIAPConfigInfo](../../apis/AccelByte.Sdk.Api.Platform/Model/XblIAPConfigInfo.cs) |
| `XblIAPConfigRequest` | [XblIAPConfigRequest](../../apis/AccelByte.Sdk.Api.Platform/Model/XblIAPConfigRequest.cs) |
| `XblReconcileRequest` | [XblReconcileRequest](../../apis/AccelByte.Sdk.Api.Platform/Model/XblReconcileRequest.cs) |
| `XblReconcileResult` | [XblReconcileResult](../../apis/AccelByte.Sdk.Api.Platform/Model/XblReconcileResult.cs) |
| `XblUserAchievements` | [XblUserAchievements](../../apis/AccelByte.Sdk.Api.Platform/Model/XblUserAchievements.cs) |
| `XblUserSessionRequest` | [XblUserSessionRequest](../../apis/AccelByte.Sdk.Api.Platform/Model/XblUserSessionRequest.cs) |
| `XsollaConfig` | [XsollaConfig](../../apis/AccelByte.Sdk.Api.Platform/Model/XsollaConfig.cs) |
| `XsollaPaywallConfig` | [XsollaPaywallConfig](../../apis/AccelByte.Sdk.Api.Platform/Model/XsollaPaywallConfig.cs) |
| `XsollaPaywallConfigRequest` | [XsollaPaywallConfigRequest](../../apis/AccelByte.Sdk.Api.Platform/Model/XsollaPaywallConfigRequest.cs) |
| `steam achievement` | [SteamAchievement](../../apis/AccelByte.Sdk.Api.Platform/Model/SteamAchievement.cs) |
| `xbox achievement` | [XboxAchievement](../../apis/AccelByte.Sdk.Api.Platform/Model/XboxAchievement.cs) |