# Inventory Service Index

&nbsp;

## Operations

### Admin Inventories Wrapper:  [AdminInventories](../../apis/AccelByte.Sdk.Api.Inventory/Wrapper/AdminInventories.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/inventory/v1/admin/namespaces/{namespace}/inventories` | GET | AdminListInventories | [AdminListInventories](../../apis/AccelByte.Sdk.Api.Inventory/Operation/AdminInventories/AdminListInventories.cs) | [AdminListInventories](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/AdminInventories/AdminListInventories.cs) |
| `/inventory/v1/admin/namespaces/{namespace}/inventories` | POST | AdminCreateInventory | [AdminCreateInventory](../../apis/AccelByte.Sdk.Api.Inventory/Operation/AdminInventories/AdminCreateInventory.cs) | [AdminCreateInventory](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/AdminInventories/AdminCreateInventory.cs) |
| `/inventory/v1/admin/namespaces/{namespace}/inventories/{inventoryId}` | GET | AdminGetInventory | [AdminGetInventory](../../apis/AccelByte.Sdk.Api.Inventory/Operation/AdminInventories/AdminGetInventory.cs) | [AdminGetInventory](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/AdminInventories/AdminGetInventory.cs) |
| `/inventory/v1/admin/namespaces/{namespace}/inventories/{inventoryId}` | PUT | AdminUpdateInventory | [AdminUpdateInventory](../../apis/AccelByte.Sdk.Api.Inventory/Operation/AdminInventories/AdminUpdateInventory.cs) | [AdminUpdateInventory](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/AdminInventories/AdminUpdateInventory.cs) |
| `/inventory/v1/admin/namespaces/{namespace}/inventories/{inventoryId}` | DELETE | DeleteInventory | [DeleteInventory](../../apis/AccelByte.Sdk.Api.Inventory/Operation/AdminInventories/DeleteInventory.cs) | [DeleteInventory](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/AdminInventories/DeleteInventory.cs) |

### Admin Items Wrapper:  [AdminItems](../../apis/AccelByte.Sdk.Api.Inventory/Wrapper/AdminItems.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/inventory/v1/admin/namespaces/{namespace}/inventories/{inventoryId}/items` | GET | AdminListItems | [AdminListItems](../../apis/AccelByte.Sdk.Api.Inventory/Operation/AdminItems/AdminListItems.cs) | [AdminListItems](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/AdminItems/AdminListItems.cs) |
| `/inventory/v1/admin/namespaces/{namespace}/inventories/{inventoryId}/items/{itemId}` | GET | AdminGetInventoryItem | [AdminGetInventoryItem](../../apis/AccelByte.Sdk.Api.Inventory/Operation/AdminItems/AdminGetInventoryItem.cs) | [AdminGetInventoryItem](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/AdminItems/AdminGetInventoryItem.cs) |
| `/inventory/v1/admin/namespaces/{namespace}/users/{userId}/inventories/{inventoryId}/items` | PUT | AdminBulkUpdateMyItems | [AdminBulkUpdateMyItems](../../apis/AccelByte.Sdk.Api.Inventory/Operation/AdminItems/AdminBulkUpdateMyItems.cs) | [AdminBulkUpdateMyItems](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/AdminItems/AdminBulkUpdateMyItems.cs) |
| `/inventory/v1/admin/namespaces/{namespace}/users/{userId}/inventories/{inventoryId}/items` | POST | AdminSaveItemToInventory | [AdminSaveItemToInventory](../../apis/AccelByte.Sdk.Api.Inventory/Operation/AdminItems/AdminSaveItemToInventory.cs) | [AdminSaveItemToInventory](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/AdminItems/AdminSaveItemToInventory.cs) |
| `/inventory/v1/admin/namespaces/{namespace}/users/{userId}/inventories/{inventoryId}/items` | DELETE | AdminBulkRemoveItems | [AdminBulkRemoveItems](../../apis/AccelByte.Sdk.Api.Inventory/Operation/AdminItems/AdminBulkRemoveItems.cs) | [AdminBulkRemoveItems](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/AdminItems/AdminBulkRemoveItems.cs) |
| `/inventory/v1/admin/namespaces/{namespace}/users/{userId}/inventories/{inventoryId}/items/{itemId}/consume` | POST | AdminConsumeUserItem | [AdminConsumeUserItem](../../apis/AccelByte.Sdk.Api.Inventory/Operation/AdminItems/AdminConsumeUserItem.cs) | [AdminConsumeUserItem](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/AdminItems/AdminConsumeUserItem.cs) |
| `/inventory/v1/admin/namespaces/{namespace}/users/{userId}/items` | POST | AdminSaveItem | [AdminSaveItem](../../apis/AccelByte.Sdk.Api.Inventory/Operation/AdminItems/AdminSaveItem.cs) | [AdminSaveItem](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/AdminItems/AdminSaveItem.cs) |

### Admin Inventory Configurations Wrapper:  [AdminInventoryConfigurations](../../apis/AccelByte.Sdk.Api.Inventory/Wrapper/AdminInventoryConfigurations.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/inventory/v1/admin/namespaces/{namespace}/inventoryConfigurations` | GET | AdminListInventoryConfigurations | [AdminListInventoryConfigurations](../../apis/AccelByte.Sdk.Api.Inventory/Operation/AdminInventoryConfigurations/AdminListInventoryConfigurations.cs) | [AdminListInventoryConfigurations](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/AdminInventoryConfigurations/AdminListInventoryConfigurations.cs) |
| `/inventory/v1/admin/namespaces/{namespace}/inventoryConfigurations` | POST | AdminCreateInventoryConfiguration | [AdminCreateInventoryConfiguration](../../apis/AccelByte.Sdk.Api.Inventory/Operation/AdminInventoryConfigurations/AdminCreateInventoryConfiguration.cs) | [AdminCreateInventoryConfiguration](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/AdminInventoryConfigurations/AdminCreateInventoryConfiguration.cs) |
| `/inventory/v1/admin/namespaces/{namespace}/inventoryConfigurations/{inventoryConfigurationId}` | GET | AdminGetInventoryConfiguration | [AdminGetInventoryConfiguration](../../apis/AccelByte.Sdk.Api.Inventory/Operation/AdminInventoryConfigurations/AdminGetInventoryConfiguration.cs) | [AdminGetInventoryConfiguration](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/AdminInventoryConfigurations/AdminGetInventoryConfiguration.cs) |
| `/inventory/v1/admin/namespaces/{namespace}/inventoryConfigurations/{inventoryConfigurationId}` | PUT | AdminUpdateInventoryConfiguration | [AdminUpdateInventoryConfiguration](../../apis/AccelByte.Sdk.Api.Inventory/Operation/AdminInventoryConfigurations/AdminUpdateInventoryConfiguration.cs) | [AdminUpdateInventoryConfiguration](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/AdminInventoryConfigurations/AdminUpdateInventoryConfiguration.cs) |
| `/inventory/v1/admin/namespaces/{namespace}/inventoryConfigurations/{inventoryConfigurationId}` | DELETE | AdminDeleteInventoryConfiguration | [AdminDeleteInventoryConfiguration](../../apis/AccelByte.Sdk.Api.Inventory/Operation/AdminInventoryConfigurations/AdminDeleteInventoryConfiguration.cs) | [AdminDeleteInventoryConfiguration](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/AdminInventoryConfigurations/AdminDeleteInventoryConfiguration.cs) |

### Admin Item Types Wrapper:  [AdminItemTypes](../../apis/AccelByte.Sdk.Api.Inventory/Wrapper/AdminItemTypes.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/inventory/v1/admin/namespaces/{namespace}/itemtypes` | GET | AdminListItemTypes | [AdminListItemTypes](../../apis/AccelByte.Sdk.Api.Inventory/Operation/AdminItemTypes/AdminListItemTypes.cs) | [AdminListItemTypes](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/AdminItemTypes/AdminListItemTypes.cs) |
| `/inventory/v1/admin/namespaces/{namespace}/itemtypes` | POST | AdminCreateItemType | [AdminCreateItemType](../../apis/AccelByte.Sdk.Api.Inventory/Operation/AdminItemTypes/AdminCreateItemType.cs) | [AdminCreateItemType](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/AdminItemTypes/AdminCreateItemType.cs) |
| `/inventory/v1/admin/namespaces/{namespace}/itemtypes/{itemTypeName}` | DELETE | AdminDeleteItemType | [AdminDeleteItemType](../../apis/AccelByte.Sdk.Api.Inventory/Operation/AdminItemTypes/AdminDeleteItemType.cs) | [AdminDeleteItemType](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/AdminItemTypes/AdminDeleteItemType.cs) |

### Admin Tags Wrapper:  [AdminTags](../../apis/AccelByte.Sdk.Api.Inventory/Wrapper/AdminTags.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/inventory/v1/admin/namespaces/{namespace}/tags` | GET | AdminListTags | [AdminListTags](../../apis/AccelByte.Sdk.Api.Inventory/Operation/AdminTags/AdminListTags.cs) | [AdminListTags](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/AdminTags/AdminListTags.cs) |
| `/inventory/v1/admin/namespaces/{namespace}/tags` | POST | AdminCreateTag | [AdminCreateTag](../../apis/AccelByte.Sdk.Api.Inventory/Operation/AdminTags/AdminCreateTag.cs) | [AdminCreateTag](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/AdminTags/AdminCreateTag.cs) |
| `/inventory/v1/admin/namespaces/{namespace}/tags/{tagName}` | DELETE | AdminDeleteTag | [AdminDeleteTag](../../apis/AccelByte.Sdk.Api.Inventory/Operation/AdminTags/AdminDeleteTag.cs) | [AdminDeleteTag](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/AdminTags/AdminDeleteTag.cs) |

### Public Inventory Configurations Wrapper:  [PublicInventoryConfigurations](../../apis/AccelByte.Sdk.Api.Inventory/Wrapper/PublicInventoryConfigurations.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/inventory/v1/public/namespaces/{namespace}/inventoryConfigurations` | GET | PublicListInventoryConfigurations | [PublicListInventoryConfigurations](../../apis/AccelByte.Sdk.Api.Inventory/Operation/PublicInventoryConfigurations/PublicListInventoryConfigurations.cs) | [PublicListInventoryConfigurations](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/PublicInventoryConfigurations/PublicListInventoryConfigurations.cs) |

### Public Item Types Wrapper:  [PublicItemTypes](../../apis/AccelByte.Sdk.Api.Inventory/Wrapper/PublicItemTypes.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/inventory/v1/public/namespaces/{namespace}/itemtypes` | GET | PublicListItemTypes | [PublicListItemTypes](../../apis/AccelByte.Sdk.Api.Inventory/Operation/PublicItemTypes/PublicListItemTypes.cs) | [PublicListItemTypes](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/PublicItemTypes/PublicListItemTypes.cs) |

### Public Tags Wrapper:  [PublicTags](../../apis/AccelByte.Sdk.Api.Inventory/Wrapper/PublicTags.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/inventory/v1/public/namespaces/{namespace}/tags` | GET | PublicListTags | [PublicListTags](../../apis/AccelByte.Sdk.Api.Inventory/Operation/PublicTags/PublicListTags.cs) | [PublicListTags](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/PublicTags/PublicListTags.cs) |

### Public Inventories Wrapper:  [PublicInventories](../../apis/AccelByte.Sdk.Api.Inventory/Wrapper/PublicInventories.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/inventory/v1/public/namespaces/{namespace}/users/me/inventories` | GET | PublicListInventories | [PublicListInventories](../../apis/AccelByte.Sdk.Api.Inventory/Operation/PublicInventories/PublicListInventories.cs) | [PublicListInventories](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/PublicInventories/PublicListInventories.cs) |

### Public Items Wrapper:  [PublicItems](../../apis/AccelByte.Sdk.Api.Inventory/Wrapper/PublicItems.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/inventory/v1/public/namespaces/{namespace}/users/me/inventories/{inventoryId}/items` | GET | PublicListItems | [PublicListItems](../../apis/AccelByte.Sdk.Api.Inventory/Operation/PublicItems/PublicListItems.cs) | [PublicListItems](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/PublicItems/PublicListItems.cs) |
| `/inventory/v1/public/namespaces/{namespace}/users/me/inventories/{inventoryId}/items` | PUT | PublicBulkUpdateMyItems | [PublicBulkUpdateMyItems](../../apis/AccelByte.Sdk.Api.Inventory/Operation/PublicItems/PublicBulkUpdateMyItems.cs) | [PublicBulkUpdateMyItems](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/PublicItems/PublicBulkUpdateMyItems.cs) |
| `/inventory/v1/public/namespaces/{namespace}/users/me/inventories/{inventoryId}/items` | DELETE | PublicBulkRemoveMyItems | [PublicBulkRemoveMyItems](../../apis/AccelByte.Sdk.Api.Inventory/Operation/PublicItems/PublicBulkRemoveMyItems.cs) | [PublicBulkRemoveMyItems](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/PublicItems/PublicBulkRemoveMyItems.cs) |
| `/inventory/v1/public/namespaces/{namespace}/users/me/inventories/{inventoryId}/items/movement` | POST | PublicMoveMyItems | [PublicMoveMyItems](../../apis/AccelByte.Sdk.Api.Inventory/Operation/PublicItems/PublicMoveMyItems.cs) | [PublicMoveMyItems](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/PublicItems/PublicMoveMyItems.cs) |
| `/inventory/v1/public/namespaces/{namespace}/users/me/inventories/{inventoryId}/items/{itemId}` | GET | PublicGetItem | [PublicGetItem](../../apis/AccelByte.Sdk.Api.Inventory/Operation/PublicItems/PublicGetItem.cs) | [PublicGetItem](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/PublicItems/PublicGetItem.cs) |
| `/inventory/v1/public/namespaces/{namespace}/users/me/inventories/{inventoryId}/items/{itemId}/consume` | POST | PublicConsumeMyItem | [PublicConsumeMyItem](../../apis/AccelByte.Sdk.Api.Inventory/Operation/PublicItems/PublicConsumeMyItem.cs) | [PublicConsumeMyItem](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/PublicItems/PublicConsumeMyItem.cs) |


&nbsp;

## Operations with Generic Response

### Admin Inventories Wrapper:  [AdminInventories](../../apis/AccelByte.Sdk.Api.Inventory/Wrapper/AdminInventories.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Admin Items Wrapper:  [AdminItems](../../apis/AccelByte.Sdk.Api.Inventory/Wrapper/AdminItems.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Admin Inventory Configurations Wrapper:  [AdminInventoryConfigurations](../../apis/AccelByte.Sdk.Api.Inventory/Wrapper/AdminInventoryConfigurations.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Admin Item Types Wrapper:  [AdminItemTypes](../../apis/AccelByte.Sdk.Api.Inventory/Wrapper/AdminItemTypes.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Admin Tags Wrapper:  [AdminTags](../../apis/AccelByte.Sdk.Api.Inventory/Wrapper/AdminTags.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Public Inventory Configurations Wrapper:  [PublicInventoryConfigurations](../../apis/AccelByte.Sdk.Api.Inventory/Wrapper/PublicInventoryConfigurations.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Public Item Types Wrapper:  [PublicItemTypes](../../apis/AccelByte.Sdk.Api.Inventory/Wrapper/PublicItemTypes.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Public Tags Wrapper:  [PublicTags](../../apis/AccelByte.Sdk.Api.Inventory/Wrapper/PublicTags.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Public Inventories Wrapper:  [PublicInventories](../../apis/AccelByte.Sdk.Api.Inventory/Wrapper/PublicInventories.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Public Items Wrapper:  [PublicItems](../../apis/AccelByte.Sdk.Api.Inventory/Wrapper/PublicItems.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|


&nbsp;

## Models

| Model | Class |
|---|---|
| `apimodels.AdminUpdateItemReq` | [ApimodelsAdminUpdateItemReq](../../apis/AccelByte.Sdk.Api.Inventory/Model/ApimodelsAdminUpdateItemReq.cs) |
| `apimodels.BulkRemoveItemsReq` | [ApimodelsBulkRemoveItemsReq](../../apis/AccelByte.Sdk.Api.Inventory/Model/ApimodelsBulkRemoveItemsReq.cs) |
| `apimodels.ConsumeItemReq` | [ApimodelsConsumeItemReq](../../apis/AccelByte.Sdk.Api.Inventory/Model/ApimodelsConsumeItemReq.cs) |
| `apimodels.CreateInventoryConfigurationReq` | [ApimodelsCreateInventoryConfigurationReq](../../apis/AccelByte.Sdk.Api.Inventory/Model/ApimodelsCreateInventoryConfigurationReq.cs) |
| `apimodels.CreateInventoryReq` | [ApimodelsCreateInventoryReq](../../apis/AccelByte.Sdk.Api.Inventory/Model/ApimodelsCreateInventoryReq.cs) |
| `apimodels.CreateItemTypeReq` | [ApimodelsCreateItemTypeReq](../../apis/AccelByte.Sdk.Api.Inventory/Model/ApimodelsCreateItemTypeReq.cs) |
| `apimodels.CreateItemTypeResp` | [ApimodelsCreateItemTypeResp](../../apis/AccelByte.Sdk.Api.Inventory/Model/ApimodelsCreateItemTypeResp.cs) |
| `apimodels.CreateTagReq` | [ApimodelsCreateTagReq](../../apis/AccelByte.Sdk.Api.Inventory/Model/ApimodelsCreateTagReq.cs) |
| `apimodels.CreateTagResp` | [ApimodelsCreateTagResp](../../apis/AccelByte.Sdk.Api.Inventory/Model/ApimodelsCreateTagResp.cs) |
| `apimodels.DeleteInventoryReq` | [ApimodelsDeleteInventoryReq](../../apis/AccelByte.Sdk.Api.Inventory/Model/ApimodelsDeleteInventoryReq.cs) |
| `apimodels.ErrorResponse` | [ApimodelsErrorResponse](../../apis/AccelByte.Sdk.Api.Inventory/Model/ApimodelsErrorResponse.cs) |
| `apimodels.InventoryConfigurationReq` | [ApimodelsInventoryConfigurationReq](../../apis/AccelByte.Sdk.Api.Inventory/Model/ApimodelsInventoryConfigurationReq.cs) |
| `apimodels.InventoryConfigurationResp` | [ApimodelsInventoryConfigurationResp](../../apis/AccelByte.Sdk.Api.Inventory/Model/ApimodelsInventoryConfigurationResp.cs) |
| `apimodels.InventoryResp` | [ApimodelsInventoryResp](../../apis/AccelByte.Sdk.Api.Inventory/Model/ApimodelsInventoryResp.cs) |
| `apimodels.ItemResp` | [ApimodelsItemResp](../../apis/AccelByte.Sdk.Api.Inventory/Model/ApimodelsItemResp.cs) |
| `apimodels.ListInventoryConfigurationsResp` | [ApimodelsListInventoryConfigurationsResp](../../apis/AccelByte.Sdk.Api.Inventory/Model/ApimodelsListInventoryConfigurationsResp.cs) |
| `apimodels.ListInventoryResp` | [ApimodelsListInventoryResp](../../apis/AccelByte.Sdk.Api.Inventory/Model/ApimodelsListInventoryResp.cs) |
| `apimodels.ListItemResp` | [ApimodelsListItemResp](../../apis/AccelByte.Sdk.Api.Inventory/Model/ApimodelsListItemResp.cs) |
| `apimodels.ListItemTypesResp` | [ApimodelsListItemTypesResp](../../apis/AccelByte.Sdk.Api.Inventory/Model/ApimodelsListItemTypesResp.cs) |
| `apimodels.ListTagsResp` | [ApimodelsListTagsResp](../../apis/AccelByte.Sdk.Api.Inventory/Model/ApimodelsListTagsResp.cs) |
| `apimodels.MoveItemsReq` | [ApimodelsMoveItemsReq](../../apis/AccelByte.Sdk.Api.Inventory/Model/ApimodelsMoveItemsReq.cs) |
| `apimodels.MoveItemsResp` | [ApimodelsMoveItemsResp](../../apis/AccelByte.Sdk.Api.Inventory/Model/ApimodelsMoveItemsResp.cs) |
| `apimodels.Paging` | [ApimodelsPaging](../../apis/AccelByte.Sdk.Api.Inventory/Model/ApimodelsPaging.cs) |
| `apimodels.SaveItemReq` | [ApimodelsSaveItemReq](../../apis/AccelByte.Sdk.Api.Inventory/Model/ApimodelsSaveItemReq.cs) |
| `apimodels.SaveItemToInventoryReq` | [ApimodelsSaveItemToInventoryReq](../../apis/AccelByte.Sdk.Api.Inventory/Model/ApimodelsSaveItemToInventoryReq.cs) |
| `apimodels.TradeItem` | [ApimodelsTradeItem](../../apis/AccelByte.Sdk.Api.Inventory/Model/ApimodelsTradeItem.cs) |
| `apimodels.TradeItemResp` | [ApimodelsTradeItemResp](../../apis/AccelByte.Sdk.Api.Inventory/Model/ApimodelsTradeItemResp.cs) |
| `apimodels.UpdateInventoryReq` | [ApimodelsUpdateInventoryReq](../../apis/AccelByte.Sdk.Api.Inventory/Model/ApimodelsUpdateInventoryReq.cs) |
| `apimodels.UpdateItemReq` | [ApimodelsUpdateItemReq](../../apis/AccelByte.Sdk.Api.Inventory/Model/ApimodelsUpdateItemReq.cs) |
| `apimodels.UpdateItemResp` | [ApimodelsUpdateItemResp](../../apis/AccelByte.Sdk.Api.Inventory/Model/ApimodelsUpdateItemResp.cs) |
