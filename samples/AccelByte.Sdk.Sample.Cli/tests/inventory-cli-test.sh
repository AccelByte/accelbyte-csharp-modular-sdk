#!/usr/bin/env bash

# Copyright (c) 2021 AccelByte Inc. All Rights Reserved.
# This is licensed software from AccelByte Inc, for limitations
# and restrictions contact your company contract manager.

# This code is generated by tool. DO NOT EDIT.

# Meta:
# - random seed: 
# - template file: 

# Instructions:
# - Run the Justice SDK Mock Server first before running this script.

export AB_BASE_URL="http://127.0.0.1:8080"
export AB_CLIENT_ID="admin"
export AB_CLIENT_SECRET="admin"
export AB_NAMESPACE="test"
export AB_APP_NAME="UnitTest"

EXIT_CODE=0

eval_tap() {
  if [ $1 -eq 0 ]; then
    echo "ok $2 - $3"
  else
    EXIT_CODE=1
    echo "not ok $2 - $3"
    sed 's/^/# /g' $4
  fi
  rm -f $4
}

CLI_EXE="AccelByte.Sdk.Sample.Cli"
CLI_TOKEN_FILE="$(dirname "$(which $CLI_EXE)")/token.json"
TEMP_JSON_INPUT="input_json.json"
TEMP_FILE_UPLOAD="file_upload.bin"

echo "TAP version 13"
echo "1..34"

#- 1 Login
$CLI_EXE --op login --lt user --user user --pass user > test.out 2>&1
eval_tap $? 1 'Login' test.out

if [ $EXIT_CODE -ne 0 ]; then
  echo "Bail out! Login failed."
  exit $EXIT_CODE
fi

# echo "foo" > "$CLI_TOKEN_FILE"

#- 2 AdminListInventories
$CLI_EXE \
    --sn inventory \
    --op AdminListInventories \
    --namespace $AB_NAMESPACE \
    --inventoryConfigurationCode 'mUTlQQAi' \
    --limit '13' \
    --offset '46' \
    --sortBy 'inventoryConfigurationCode' \
    --userId 'uqpeS4bd' \
    > test.out 2>&1
eval_tap $? 2 'AdminListInventories' test.out

#- 3 AdminCreateInventory
# body param: body
echo '{"inventoryConfigurationCode": "QPcVVp5p", "userId": "1EeBm8Ll"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op AdminCreateInventory \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 3 'AdminCreateInventory' test.out

#- 4 AdminGetInventory
$CLI_EXE \
    --sn inventory \
    --op AdminGetInventory \
    --inventoryId 'lgVe8kCd' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 4 'AdminGetInventory' test.out

#- 5 AdminUpdateInventory
# body param: body
echo '{"incMaxSlots": 12}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op AdminUpdateInventory \
    --inventoryId 'kHXARDJK' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 5 'AdminUpdateInventory' test.out

#- 6 DeleteInventory
# body param: body
echo '{"message": "yjgprc7K"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op DeleteInventory \
    --inventoryId 'IMKT5NGi' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 6 'DeleteInventory' test.out

#- 7 AdminListItems
$CLI_EXE \
    --sn inventory \
    --op AdminListItems \
    --inventoryId 'LFOQu9lJ' \
    --namespace $AB_NAMESPACE \
    --limit '22' \
    --offset '19' \
    --qtyGte '16' \
    --sortBy 'qty:desc' \
    --sourceItemId 'X6UCG6XG' \
    --tags 'TwoybT3z' \
    > test.out 2>&1
eval_tap $? 7 'AdminListItems' test.out

#- 8 AdminGetInventoryItem
$CLI_EXE \
    --sn inventory \
    --op AdminGetInventoryItem \
    --inventoryId '2imjjE0b' \
    --itemId '9KFy2um0' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 8 'AdminGetInventoryItem' test.out

#- 9 AdminListInventoryConfigurations
$CLI_EXE \
    --sn inventory \
    --op AdminListInventoryConfigurations \
    --namespace $AB_NAMESPACE \
    --code 'DbrbcAUX' \
    --limit '89' \
    --offset '60' \
    --sortBy 'createdAt:asc' \
    > test.out 2>&1
eval_tap $? 9 'AdminListInventoryConfigurations' test.out

#- 10 AdminCreateInventoryConfiguration
# body param: body
echo '{"code": "GEVlEnXz", "description": "041cZc1A", "initialMaxSlots": 19, "maxInstancesPerUser": 49, "maxUpgradeSlots": 11, "name": "qg11RPX6"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op AdminCreateInventoryConfiguration \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 10 'AdminCreateInventoryConfiguration' test.out

#- 11 AdminGetInventoryConfiguration
$CLI_EXE \
    --sn inventory \
    --op AdminGetInventoryConfiguration \
    --inventoryConfigurationId '3mJHPvzW' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 11 'AdminGetInventoryConfiguration' test.out

#- 12 AdminUpdateInventoryConfiguration
# body param: body
echo '{"code": "Ieyrx2oO", "description": "NWW0B2EF", "initialMaxSlots": 18, "maxInstancesPerUser": 32, "maxUpgradeSlots": 50, "name": "6dRWusNa"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op AdminUpdateInventoryConfiguration \
    --inventoryConfigurationId 'HQOXZEJY' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 12 'AdminUpdateInventoryConfiguration' test.out

#- 13 AdminDeleteInventoryConfiguration
$CLI_EXE \
    --sn inventory \
    --op AdminDeleteInventoryConfiguration \
    --inventoryConfigurationId 'lCBiHmGj' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 13 'AdminDeleteInventoryConfiguration' test.out

#- 14 AdminListItemTypes
$CLI_EXE \
    --sn inventory \
    --op AdminListItemTypes \
    --namespace $AB_NAMESPACE \
    --limit '19' \
    --offset '48' \
    --sortBy 'createdAt:asc' \
    > test.out 2>&1
eval_tap $? 14 'AdminListItemTypes' test.out

#- 15 AdminCreateItemType
# body param: body
echo '{"name": "RbyvbUCy"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op AdminCreateItemType \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 15 'AdminCreateItemType' test.out

#- 16 AdminDeleteItemType
$CLI_EXE \
    --sn inventory \
    --op AdminDeleteItemType \
    --itemTypeName 'vtQqPFyn' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 16 'AdminDeleteItemType' test.out

#- 17 AdminListTags
$CLI_EXE \
    --sn inventory \
    --op AdminListTags \
    --namespace $AB_NAMESPACE \
    --limit '13' \
    --offset '33' \
    --owner 'BboeqhGa' \
    --sortBy 'name' \
    > test.out 2>&1
eval_tap $? 17 'AdminListTags' test.out

#- 18 AdminCreateTag
# body param: body
echo '{"name": "YqpAfkGB", "owner": "SERVER"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op AdminCreateTag \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 18 'AdminCreateTag' test.out

#- 19 AdminDeleteTag
$CLI_EXE \
    --sn inventory \
    --op AdminDeleteTag \
    --namespace $AB_NAMESPACE \
    --tagName 'ydtSQ5mD' \
    > test.out 2>&1
eval_tap $? 19 'AdminDeleteTag' test.out

#- 20 AdminBulkUpdateMyItems
# body param: body
echo '[{"customAttributes": {"LRfOTGtK": {}, "59qi7Ajo": {}, "dfFjOSI4": {}}, "id": "L1sf1wda", "serverCustomAttributes": {"J3L3n7Vc": {}, "V3zZXIHP": {}, "mQ8f48Q3": {}}, "tags": ["9q0h6cqT", "owUKwDk1", "2wgDEEAv"], "type": "jhaL1f7T"}, {"customAttributes": {"CdnbAwG9": {}, "qdt2LMcR": {}, "jyOzdRdV": {}}, "id": "fOCx53BF", "serverCustomAttributes": {"7kTD6kxA": {}, "zZw8bVMM": {}, "DksytDzU": {}}, "tags": ["0tdCnA0O", "KogsALm3", "eaDZl4R9"], "type": "9Lz3YCmt"}, {"customAttributes": {"GiMURMfG": {}, "DcNSTGWQ": {}, "1rbwVNxA": {}}, "id": "q0ploj7S", "serverCustomAttributes": {"vlofEf9f": {}, "TjWnoZVv": {}, "u3enfwrQ": {}}, "tags": ["17LOUIKh", "viRM5MRq", "AyRLNLLg"], "type": "vCA0tfLQ"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op AdminBulkUpdateMyItems \
    --inventoryId 'wkiESqqf' \
    --namespace $AB_NAMESPACE \
    --userId 'G1cxTixU' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 20 'AdminBulkUpdateMyItems' test.out

#- 21 AdminSaveItemToInventory
# body param: body
echo '{"customAttributes": {"oDngcxQE": {}, "KThkpmOh": {}, "4d1L8egl": {}}, "qty": 35, "serverCustomAttributes": {"2dTLSv8p": {}, "He4NBPCb": {}, "ieApUW1C": {}}, "sourceItemId": "Z6k2gUZd", "tags": ["e7n3Zt57", "5HT9YGjm", "WylaK7UO"], "type": "RBmAaM0N"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op AdminSaveItemToInventory \
    --inventoryId '74A9j3jn' \
    --namespace $AB_NAMESPACE \
    --userId 'MIqVAQR3' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 21 'AdminSaveItemToInventory' test.out

#- 22 AdminBulkRemoveItems
# body param: body
echo '{"ids": ["uD8fVvYj", "xOwxjjpk", "Zlr7OmdR"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op AdminBulkRemoveItems \
    --inventoryId '8d1ehLog' \
    --namespace $AB_NAMESPACE \
    --userId 'QgZOkQO7' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 22 'AdminBulkRemoveItems' test.out

#- 23 AdminConsumeUserItem
# body param: body
echo '{"qty": 76}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op AdminConsumeUserItem \
    --inventoryId 'BESwwZiL' \
    --itemId 'y57vYQsP' \
    --namespace $AB_NAMESPACE \
    --userId 'j0iDp3er' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 23 'AdminConsumeUserItem' test.out

#- 24 AdminSaveItem
# body param: body
echo '{"customAttributes": {"wu8wF4VB": {}, "33aNUj7m": {}, "LmLjAeDA": {}}, "inventoryConfigurationCode": "xXv6EuwW", "qty": 46, "serverCustomAttributes": {"skb4Qt0F": {}, "TNbIj5Ep": {}, "Q6bNFRLl": {}}, "sourceItemId": "8wK4NZA9", "tags": ["ADw74m21", "99CrmlzL", "UDrsZPIz"], "type": "DI3Qy6OK"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op AdminSaveItem \
    --namespace $AB_NAMESPACE \
    --userId 'mq3pSvUi' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 24 'AdminSaveItem' test.out

#- 25 PublicListInventoryConfigurations
$CLI_EXE \
    --sn inventory \
    --op PublicListInventoryConfigurations \
    --namespace $AB_NAMESPACE \
    --code 'Pm91NQ4q' \
    --limit '52' \
    --offset '42' \
    --sortBy 'createdAt' \
    > test.out 2>&1
eval_tap $? 25 'PublicListInventoryConfigurations' test.out

#- 26 PublicListItemTypes
$CLI_EXE \
    --sn inventory \
    --op PublicListItemTypes \
    --namespace $AB_NAMESPACE \
    --limit '100' \
    --offset '87' \
    --sortBy 'name:desc' \
    > test.out 2>&1
eval_tap $? 26 'PublicListItemTypes' test.out

#- 27 PublicListTags
$CLI_EXE \
    --sn inventory \
    --op PublicListTags \
    --namespace $AB_NAMESPACE \
    --limit '45' \
    --offset '1' \
    --sortBy 'name:desc' \
    > test.out 2>&1
eval_tap $? 27 'PublicListTags' test.out

#- 28 PublicListInventories
$CLI_EXE \
    --sn inventory \
    --op PublicListInventories \
    --namespace $AB_NAMESPACE \
    --inventoryConfigurationCode 'xD1uT4jB' \
    --limit '61' \
    --offset '60' \
    --sortBy 'createdAt:desc' \
    > test.out 2>&1
eval_tap $? 28 'PublicListInventories' test.out

#- 29 PublicListItems
$CLI_EXE \
    --sn inventory \
    --op PublicListItems \
    --inventoryId 'wQpQdfXi' \
    --namespace $AB_NAMESPACE \
    --limit '91' \
    --offset '39' \
    --qtyGte '64' \
    --sortBy 'qty:asc' \
    --sourceItemId 'd1Nkt5Kc' \
    --tags 'GO9PYS31' \
    > test.out 2>&1
eval_tap $? 29 'PublicListItems' test.out

#- 30 PublicBulkUpdateMyItems
# body param: body
echo '[{"customAttributes": {"XOUdWjdX": {}, "uBZIekMA": {}, "aByqLQEW": {}}, "id": "K9fT0nvx", "tags": ["09WwLkfM", "E5aTp1eo", "3nChklmw"]}, {"customAttributes": {"bByvsIIP": {}, "EML7xznA": {}, "NZq6eT7A": {}}, "id": "qzMnvB6q", "tags": ["0RnCSJga", "4VSzUsIO", "l6Duab15"]}, {"customAttributes": {"DrYb9gA7": {}, "aLZY8QQa": {}, "zq7DM1GY": {}}, "id": "PLrC9VNa", "tags": ["iLQ0T3mG", "vjAbuL7b", "sI5fIACI"]}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op PublicBulkUpdateMyItems \
    --inventoryId 'Ir4SceW1' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 30 'PublicBulkUpdateMyItems' test.out

#- 31 PublicBulkRemoveMyItems
# body param: body
echo '{"ids": ["NsqcDmYW", "rvoByKgN", "vlGiKjBI"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op PublicBulkRemoveMyItems \
    --inventoryId 'Bx6TmZ6K' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 31 'PublicBulkRemoveMyItems' test.out

#- 32 PublicMoveMyItems
# body param: body
echo '{"items": [{"id": "LFlZCd4X", "qty": 35}, {"id": "uGdjmdhc", "qty": 12}, {"id": "WA0dQ98I", "qty": 34}], "srcInventoryId": "KZSEY7bA"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op PublicMoveMyItems \
    --inventoryId 'rCJTCm5A' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 32 'PublicMoveMyItems' test.out

#- 33 PublicGetItem
$CLI_EXE \
    --sn inventory \
    --op PublicGetItem \
    --inventoryId 'WHJJzABn' \
    --itemId '1dNLL01F' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 33 'PublicGetItem' test.out

#- 34 PublicConsumeMyItem
# body param: body
echo '{"qty": 60}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op PublicConsumeMyItem \
    --inventoryId 'fu7hO4TR' \
    --itemId '4EmM0cpf' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 34 'PublicConsumeMyItem' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE