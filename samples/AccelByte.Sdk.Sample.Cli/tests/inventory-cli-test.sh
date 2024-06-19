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
echo "1..41"

#- 1 Login
$CLI_EXE --op login --lt user --user user --pass user > test.out 2>&1
eval_tap $? 1 'Login' test.out

if [ $EXIT_CODE -ne 0 ]; then
  echo "Bail out! Login failed."
  exit $EXIT_CODE
fi

# echo "foo" > "$CLI_TOKEN_FILE"

#- 2 AdminCreateChainingOperations
# body param: body
echo '{"message": "rpRks2Gk", "operations": [{"consumeItems": [{"inventoryId": "1uTS5AS8", "qty": 45, "slotId": "oRCPcY5X", "sourceItemId": "0NPzXLU6"}, {"inventoryId": "9jSuJZy4", "qty": 6, "slotId": "kKfFejwr", "sourceItemId": "J67MD5tz"}, {"inventoryId": "LA1Zn8aZ", "qty": 27, "slotId": "wR6qkqLo", "sourceItemId": "Ws1UTP61"}], "createItems": [{"customAttributes": {"WgPhvV7Z": {}, "6ayfxK29": {}, "Ynu0YEL8": {}}, "inventoryConfigurationCode": "ED0zm4P6", "inventoryId": "oo0EgBCW", "qty": 15, "serverCustomAttributes": {"b3trychs": {}, "aJjBYEd1": {}, "Q4mxEyD8": {}}, "slotId": "HHeo2yqv", "slotUsed": 81, "sourceItemId": "qfGU0fTA", "tags": ["rSmIztBO", "EryCMn3m", "0XoQ977M"], "toSpecificInventory": true, "type": "QgJZ8pe0"}, {"customAttributes": {"qrxfwvdi": {}, "3a8qsRRh": {}, "ASDBc6oK": {}}, "inventoryConfigurationCode": "rDqW6EEf", "inventoryId": "2JAvfNlL", "qty": 100, "serverCustomAttributes": {"DLvYjYD4": {}, "9xr2N7tM": {}, "QALm3ogk": {}}, "slotId": "zl78ZSkg", "slotUsed": 47, "sourceItemId": "nrMxMTml", "tags": ["l0oW355T", "T1xsc7W1", "QHFNwbW2"], "toSpecificInventory": false, "type": "aetOQPme"}, {"customAttributes": {"e2Bu2wTU": {}, "KViDuJwn": {}, "Ez9a0boL": {}}, "inventoryConfigurationCode": "vSA4GHIn", "inventoryId": "niLqHOrw", "qty": 54, "serverCustomAttributes": {"sTNLGdrr": {}, "xjpBK3k6": {}, "D5FPFRPf": {}}, "slotId": "2PsI7CA3", "slotUsed": 63, "sourceItemId": "qoPuXc3g", "tags": ["wmWq0KV7", "f4zqKzlt", "M6NbDWwy"], "toSpecificInventory": false, "type": "dMW6u8TS"}], "removeItems": [{"inventoryId": "pPk6ai0Y", "slotId": "vK4ZQAKB", "sourceItemId": "bA1bqdFm"}, {"inventoryId": "k44KHz8R", "slotId": "kEKPQdhi", "sourceItemId": "hKMMBZzp"}, {"inventoryId": "eNJMSPHM", "slotId": "2Y7oE5Yp", "sourceItemId": "1AZxUVJ3"}], "targetUserId": "VYs0pyjU", "updateItems": [{"customAttributes": {"7ele8F51": {}, "HXJ89CmL": {}, "1xzvsOC3": {}}, "inventoryId": "ob6x7Ie1", "serverCustomAttributes": {"OHaC5tou": {}, "mKy59ViM": {}, "X08Nha3U": {}}, "slotId": "Oyrf4V8M", "sourceItemId": "bo61ciiZ", "tags": ["z3P1GOwc", "83PBOMl2", "RjyRYL4i"], "type": "3I9MmXFL"}, {"customAttributes": {"78TbZN71": {}, "v8DPra7U": {}, "2MNidfZn": {}}, "inventoryId": "C0dZMGdn", "serverCustomAttributes": {"eqcvAZue": {}, "qqYIAoJw": {}, "mt4XT3HO": {}}, "slotId": "sxBmW5Gw", "sourceItemId": "FE8XONr1", "tags": ["AO3NAjqp", "VOzCekvz", "hWN7265s"], "type": "3oWHOFFM"}, {"customAttributes": {"28IamdZ9": {}, "TprOumEU": {}, "aEHPx7ea": {}}, "inventoryId": "WSLW60iV", "serverCustomAttributes": {"7M3rATOz": {}, "dPheBY3Q": {}, "YaOsmgbs": {}}, "slotId": "LH7rIap9", "sourceItemId": "rRt6Dyd4", "tags": ["mlJ3C4gr", "4bGOcdww", "8U6r6KPB"], "type": "J9D8n43H"}]}, {"consumeItems": [{"inventoryId": "5h9q1oy4", "qty": 40, "slotId": "6c0sEA8u", "sourceItemId": "WQE2BIdv"}, {"inventoryId": "tsS2Ikt3", "qty": 42, "slotId": "3m98Qlj3", "sourceItemId": "Xi7DSaO9"}, {"inventoryId": "pVJWEjoI", "qty": 51, "slotId": "xpSP4t9r", "sourceItemId": "Wk3l8DNB"}], "createItems": [{"customAttributes": {"t7Cy2cVs": {}, "EZQDAx9V": {}, "W4iOQvJl": {}}, "inventoryConfigurationCode": "FAZtbX83", "inventoryId": "Al5nsFX4", "qty": 32, "serverCustomAttributes": {"49eQATF7": {}, "rmcEHWeH": {}, "scbPM7Sj": {}}, "slotId": "lVlTfV91", "slotUsed": 45, "sourceItemId": "cuv2Ex8u", "tags": ["x4g5dbAq", "odjPlZM9", "2GcnlcNB"], "toSpecificInventory": false, "type": "cCd9QxXX"}, {"customAttributes": {"difdW7Df": {}, "bcvqhzVz": {}, "MTbEU8Il": {}}, "inventoryConfigurationCode": "ARoaEU11", "inventoryId": "gksIWZ6n", "qty": 34, "serverCustomAttributes": {"xEvWwfkf": {}, "e7F9mzaK": {}, "BC14eMXd": {}}, "slotId": "RupkMVFY", "slotUsed": 94, "sourceItemId": "x9rMa8WG", "tags": ["JSHQauK9", "HRxKfm8h", "PjTLPxPT"], "toSpecificInventory": false, "type": "wcWSY4LM"}, {"customAttributes": {"7r8dm1hw": {}, "RWhgULdw": {}, "MbjtiwMK": {}}, "inventoryConfigurationCode": "XsaKS3aT", "inventoryId": "z9PajXFV", "qty": 18, "serverCustomAttributes": {"MEbil11W": {}, "H9GcSRFy": {}, "BnEh4J20": {}}, "slotId": "6KbsRvaP", "slotUsed": 90, "sourceItemId": "RdNJaW8v", "tags": ["MRH2dAo5", "PrH2dbcU", "UtuEp3zY"], "toSpecificInventory": true, "type": "l8UhBVNG"}], "removeItems": [{"inventoryId": "5qvGMWw0", "slotId": "On8ryaRL", "sourceItemId": "LncszCO7"}, {"inventoryId": "uF6nlgeF", "slotId": "9HpbMxvI", "sourceItemId": "sfUaJglA"}, {"inventoryId": "VGPCCIhR", "slotId": "cRzJsQqm", "sourceItemId": "9W0QsI6S"}], "targetUserId": "zNnE4p1P", "updateItems": [{"customAttributes": {"ZCDupkEy": {}, "DSxvjb1a": {}, "lvZDzGCh": {}}, "inventoryId": "kbA5WokF", "serverCustomAttributes": {"JdxergLY": {}, "LgQLYoqq": {}, "Lzl03HOE": {}}, "slotId": "emAzCu3d", "sourceItemId": "fCTwpuZW", "tags": ["HQXf9z2o", "mo8SAEaH", "38S0N8Ak"], "type": "vPfuvn4H"}, {"customAttributes": {"r9JODwU3": {}, "yRPhDVU5": {}, "kEGZvamH": {}}, "inventoryId": "emC9B58k", "serverCustomAttributes": {"AsGG7HKr": {}, "OzTirjNV": {}, "AytPPnRd": {}}, "slotId": "cmWgiLp7", "sourceItemId": "DO5deWyW", "tags": ["BuTe5MPE", "QO6RdRRM", "Q7B0k8xx"], "type": "p8qLIaU6"}, {"customAttributes": {"LKHZfONQ": {}, "any8VLmv": {}, "yhCPtAXr": {}}, "inventoryId": "7RhWwpsE", "serverCustomAttributes": {"vwJ2mJdG": {}, "oDV3wnOM": {}, "QEev0dsW": {}}, "slotId": "7RPCBbN6", "sourceItemId": "i27o98PP", "tags": ["5Hj02BpL", "tsKeJeKM", "SyPKMG8E"], "type": "Vs0fbk1Z"}]}, {"consumeItems": [{"inventoryId": "MOymoNTY", "qty": 90, "slotId": "gXC6wgDr", "sourceItemId": "l1EqygOS"}, {"inventoryId": "AtoU9orn", "qty": 83, "slotId": "2IOnuCl9", "sourceItemId": "4XuVCUy5"}, {"inventoryId": "sNWl8FMt", "qty": 44, "slotId": "MG2JvBvH", "sourceItemId": "ZO4SL78B"}], "createItems": [{"customAttributes": {"7sqWRadp": {}, "bv5Iee5E": {}, "ab1OTUIu": {}}, "inventoryConfigurationCode": "2PPC7CG9", "inventoryId": "2YCIBI96", "qty": 24, "serverCustomAttributes": {"4XQB8u16": {}, "MMJGgRcu": {}, "ixWyP6S7": {}}, "slotId": "KZkmFGEI", "slotUsed": 58, "sourceItemId": "fy8OvruT", "tags": ["A4SjdZaa", "scKThV8Y", "qLwLzSMo"], "toSpecificInventory": false, "type": "Jlbr6S18"}, {"customAttributes": {"V3trDcMC": {}, "JjnJgkdL": {}, "sDJ7ZIA1": {}}, "inventoryConfigurationCode": "54DnoIt9", "inventoryId": "2K921zkD", "qty": 0, "serverCustomAttributes": {"V1Y5eujs": {}, "v5PbXhda": {}, "l9TXuwow": {}}, "slotId": "fRGfmUlj", "slotUsed": 100, "sourceItemId": "j4y9Vf7K", "tags": ["4GJ4y1a6", "q91JiIgo", "rJFVE7iG"], "toSpecificInventory": false, "type": "GqwsQbdp"}, {"customAttributes": {"UlUzEvXF": {}, "JdiQ7DFg": {}, "cY1flXXK": {}}, "inventoryConfigurationCode": "0RVvKUi2", "inventoryId": "dWeT61qP", "qty": 16, "serverCustomAttributes": {"5pAj4jZz": {}, "8x9MhQav": {}, "VxVxsRU5": {}}, "slotId": "Ug07RgjA", "slotUsed": 82, "sourceItemId": "hodLf58w", "tags": ["52XQ0LQX", "X0XZHohz", "wA1Mlupn"], "toSpecificInventory": true, "type": "a81U6hJ8"}], "removeItems": [{"inventoryId": "AJlYhaND", "slotId": "1gCUOBt2", "sourceItemId": "fzphxczw"}, {"inventoryId": "7fInCUOY", "slotId": "2JXi74Ut", "sourceItemId": "tnY33YIa"}, {"inventoryId": "YmOfOARo", "slotId": "xX0eEpIM", "sourceItemId": "27n3T6aR"}], "targetUserId": "vKk93V3y", "updateItems": [{"customAttributes": {"0nrZkLvn": {}, "zFpl3UBg": {}, "OzMF7F6H": {}}, "inventoryId": "b18fleD7", "serverCustomAttributes": {"KCRn4NQO": {}, "gqB9jxiG": {}, "fRwIrMcS": {}}, "slotId": "S9LMkj3X", "sourceItemId": "mv1fMiDC", "tags": ["lU5Z5x9d", "kgbqk7RK", "LKY9brKF"], "type": "pJSpinLg"}, {"customAttributes": {"oHDzeBih": {}, "vlnSDQbm": {}, "KYA3TRbZ": {}}, "inventoryId": "I1UqCUPu", "serverCustomAttributes": {"M38LsYQ0": {}, "aWb4UzPc": {}, "8HqzTcPk": {}}, "slotId": "a0o32MGI", "sourceItemId": "30papJwb", "tags": ["P3hyrw41", "Z1MDAfhg", "rz1vlo6d"], "type": "MgzvqBTk"}, {"customAttributes": {"EnO9XMwO": {}, "PFjzr2o6": {}, "JACiW9eN": {}}, "inventoryId": "qMl2X7Hf", "serverCustomAttributes": {"s49bBa1K": {}, "F2odjRmx": {}, "wKZfQmNE": {}}, "slotId": "fwHm6ANY", "sourceItemId": "zi0vOe16", "tags": ["c7wRp5O0", "k6gXrPTs", "5TVvi508"], "type": "apP3nXl9"}]}], "requestId": "jHEYfAIE"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op AdminCreateChainingOperations \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 2 'AdminCreateChainingOperations' test.out

#- 3 AdminListIntegrationConfigurations
$CLI_EXE \
    --sn inventory \
    --op AdminListIntegrationConfigurations \
    --namespace $AB_NAMESPACE \
    --limit '30' \
    --offset '72' \
    --sortBy 'createdAt' \
    > test.out 2>&1
eval_tap $? 3 'AdminListIntegrationConfigurations' test.out

#- 4 AdminCreateIntegrationConfiguration
# body param: body
echo '{"mapItemType": ["DH5dUdQz", "qfWrxX0C", "1upDBksh"], "serviceName": "FDtqUCRO", "targetInventoryCode": "ZDqn8o3W"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op AdminCreateIntegrationConfiguration \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 4 'AdminCreateIntegrationConfiguration' test.out

#- 5 AdminUpdateIntegrationConfiguration
# body param: body
echo '{"mapItemType": ["UC1OoLKe", "wIcZpjYR", "JLKUodhf"], "serviceName": "o5JC17Ot", "targetInventoryCode": "oO2su9oM"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op AdminUpdateIntegrationConfiguration \
    --integrationConfigurationId 'RcC4H29X' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 5 'AdminUpdateIntegrationConfiguration' test.out

#- 6 AdminUpdateStatusIntegrationConfiguration
# body param: body
echo '{"status": "TIED"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op AdminUpdateStatusIntegrationConfiguration \
    --integrationConfigurationId 'redJ2loi' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 6 'AdminUpdateStatusIntegrationConfiguration' test.out

#- 7 AdminListInventories
$CLI_EXE \
    --sn inventory \
    --op AdminListInventories \
    --namespace $AB_NAMESPACE \
    --inventoryConfigurationCode 'CcG2hAWH' \
    --limit '29' \
    --offset '68' \
    --sortBy 'createdAt' \
    --userId 'GhvT6idE' \
    > test.out 2>&1
eval_tap $? 7 'AdminListInventories' test.out

#- 8 AdminCreateInventory
# body param: body
echo '{"inventoryConfigurationCode": "b3ym7Enp", "userId": "a8Nbfmbf"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op AdminCreateInventory \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 8 'AdminCreateInventory' test.out

#- 9 AdminGetInventory
$CLI_EXE \
    --sn inventory \
    --op AdminGetInventory \
    --inventoryId 'Y7sH9OZm' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 9 'AdminGetInventory' test.out

#- 10 AdminUpdateInventory
# body param: body
echo '{"incMaxSlots": 38}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op AdminUpdateInventory \
    --inventoryId '0XBnUQCh' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 10 'AdminUpdateInventory' test.out

#- 11 DeleteInventory
# body param: body
echo '{"message": "ASiIEadK"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op DeleteInventory \
    --inventoryId 'Oq73vsRi' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 11 'DeleteInventory' test.out

#- 12 AdminListItems
$CLI_EXE \
    --sn inventory \
    --op AdminListItems \
    --inventoryId 'zRLrUkpo' \
    --namespace $AB_NAMESPACE \
    --limit '8' \
    --offset '76' \
    --sortBy 'updatedAt:asc' \
    --sourceItemId 'bwkCskxz' \
    --tags 'N2oY1nFU' \
    > test.out 2>&1
eval_tap $? 12 'AdminListItems' test.out

#- 13 AdminGetInventoryItem
$CLI_EXE \
    --sn inventory \
    --op AdminGetInventoryItem \
    --inventoryId '0WWE9dTI' \
    --namespace $AB_NAMESPACE \
    --slotId 'vjk0ZyQR' \
    --sourceItemId 'n890n0OW' \
    > test.out 2>&1
eval_tap $? 13 'AdminGetInventoryItem' test.out

#- 14 AdminListInventoryConfigurations
$CLI_EXE \
    --sn inventory \
    --op AdminListInventoryConfigurations \
    --namespace $AB_NAMESPACE \
    --code 'JUTLyLN8' \
    --limit '97' \
    --offset '6' \
    --sortBy 'createdAt:desc' \
    > test.out 2>&1
eval_tap $? 14 'AdminListInventoryConfigurations' test.out

#- 15 AdminCreateInventoryConfiguration
# body param: body
echo '{"code": "MA4rCCf3", "description": "gpepZcbb", "initialMaxSlots": 85, "maxInstancesPerUser": 11, "maxUpgradeSlots": 55, "name": "bUZMVCFu"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op AdminCreateInventoryConfiguration \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 15 'AdminCreateInventoryConfiguration' test.out

#- 16 AdminGetInventoryConfiguration
$CLI_EXE \
    --sn inventory \
    --op AdminGetInventoryConfiguration \
    --inventoryConfigurationId '2VScv1Qr' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 16 'AdminGetInventoryConfiguration' test.out

#- 17 AdminUpdateInventoryConfiguration
# body param: body
echo '{"code": "kbVzRCgR", "description": "gYqEKFmH", "initialMaxSlots": 49, "maxInstancesPerUser": 66, "maxUpgradeSlots": 33, "name": "XFN1eBZm"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op AdminUpdateInventoryConfiguration \
    --inventoryConfigurationId 'Q7vB1wt3' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 17 'AdminUpdateInventoryConfiguration' test.out

#- 18 AdminDeleteInventoryConfiguration
$CLI_EXE \
    --sn inventory \
    --op AdminDeleteInventoryConfiguration \
    --inventoryConfigurationId 'feyGtQmu' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 18 'AdminDeleteInventoryConfiguration' test.out

#- 19 AdminListItemTypes
$CLI_EXE \
    --sn inventory \
    --op AdminListItemTypes \
    --namespace $AB_NAMESPACE \
    --limit '55' \
    --offset '55' \
    --sortBy 'createdAt' \
    > test.out 2>&1
eval_tap $? 19 'AdminListItemTypes' test.out

#- 20 AdminCreateItemType
# body param: body
echo '{"name": "fmUHL0pl"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op AdminCreateItemType \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 20 'AdminCreateItemType' test.out

#- 21 AdminDeleteItemType
$CLI_EXE \
    --sn inventory \
    --op AdminDeleteItemType \
    --itemTypeName 'yaqcROJj' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 21 'AdminDeleteItemType' test.out

#- 22 AdminListTags
$CLI_EXE \
    --sn inventory \
    --op AdminListTags \
    --namespace $AB_NAMESPACE \
    --limit '87' \
    --offset '19' \
    --owner 'so8I4pVz' \
    --sortBy 'createdAt' \
    > test.out 2>&1
eval_tap $? 22 'AdminListTags' test.out

#- 23 AdminCreateTag
# body param: body
echo '{"name": "XQmZ7KSK", "owner": "SERVER"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op AdminCreateTag \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 23 'AdminCreateTag' test.out

#- 24 AdminDeleteTag
$CLI_EXE \
    --sn inventory \
    --op AdminDeleteTag \
    --namespace $AB_NAMESPACE \
    --tagName 'XAHGVqLn' \
    > test.out 2>&1
eval_tap $? 24 'AdminDeleteTag' test.out

#- 25 AdminConsumeUserItem
# body param: body
echo '{"qty": 18, "slotId": "1tzCgCSM", "sourceItemId": "4zCDFWBF"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op AdminConsumeUserItem \
    --inventoryId '8ayTJC7c' \
    --namespace $AB_NAMESPACE \
    --userId 'eA1ZL10m' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 25 'AdminConsumeUserItem' test.out

#- 26 AdminBulkUpdateMyItems
# body param: body
echo '[{"customAttributes": {"Ib1QIy4I": {}, "JADFd1ZB": {}, "T2XmgKKa": {}}, "serverCustomAttributes": {"4G3xm7M3": {}, "nXymBPDE": {}, "bt3H12NZ": {}}, "slotId": "EvSKESKf", "sourceItemId": "hvuPPlFT", "tags": ["RLMVdxwp", "BuJSVFl9", "isjWIOzb"], "type": "kgB6d2XM"}, {"customAttributes": {"2qaREFKR": {}, "3WqfKtmX": {}, "kPIhKgmh": {}}, "serverCustomAttributes": {"pV0aCD8V": {}, "yWkecG4Z": {}, "8YSv09wy": {}}, "slotId": "8dFnPVKZ", "sourceItemId": "OMfKTsyI", "tags": ["AOgMlh5g", "ADwWzXaV", "Eyvkaulk"], "type": "xVIH3mPb"}, {"customAttributes": {"QPPq8JyJ": {}, "DHBuGOjk": {}, "yXE4OqFV": {}}, "serverCustomAttributes": {"LQ0K2b8Y": {}, "GAGKiTh9": {}, "9MMibiM5": {}}, "slotId": "NNJOm7AC", "sourceItemId": "XrbUId9N", "tags": ["jtTx8DRI", "Pjd3rnmb", "7qHJpYo8"], "type": "xuZoL5Yv"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op AdminBulkUpdateMyItems \
    --inventoryId 'cmmBCmhR' \
    --namespace $AB_NAMESPACE \
    --userId 'jrT77IZO' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 26 'AdminBulkUpdateMyItems' test.out

#- 27 AdminSaveItemToInventory
# body param: body
echo '{"customAttributes": {"FDAPe4SM": {}, "3KCwcN02": {}, "NYwqKkHe": {}}, "qty": 97, "serverCustomAttributes": {"wamRIvhU": {}, "4Ge08Ffp": {}, "hXr2Ms2l": {}}, "slotId": "QMFimxbK", "slotUsed": 9, "source": "OTHER", "sourceItemId": "xKmFXUBk", "tags": ["H3ZXingL", "dvoJeUaR", "ecMbsVJG"], "type": "fWyihtTp"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op AdminSaveItemToInventory \
    --inventoryId 'l8Jh6gZb' \
    --namespace $AB_NAMESPACE \
    --userId '7s9hwcII' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 27 'AdminSaveItemToInventory' test.out

#- 28 AdminBulkRemoveItems
# body param: body
echo '[{"slotId": "BxfgB2z7", "sourceItemId": "mB6CykUK"}, {"slotId": "Zt1fIwVR", "sourceItemId": "FejgP7Xz"}, {"slotId": "JxPwi0Sq", "sourceItemId": "BZ2PpC0N"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op AdminBulkRemoveItems \
    --inventoryId 'ggi2KeVM' \
    --namespace $AB_NAMESPACE \
    --userId 'Rhp22bdq' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 28 'AdminBulkRemoveItems' test.out

#- 29 AdminSaveItem
# body param: body
echo '{"customAttributes": {"mZm81zZC": {}, "EA0WpNbB": {}, "AcqX5AAQ": {}}, "inventoryConfigurationCode": "NiZx51oM", "qty": 98, "serverCustomAttributes": {"Pj9VQMEr": {}, "fGBpHTnS": {}, "KIRDV9aj": {}}, "slotId": "eyVXbCez", "slotUsed": 79, "source": "ECOMMERCE", "sourceItemId": "RHZmdkyY", "tags": ["RgOZhM9k", "2IhxVVsl", "5KJDoKUP"], "type": "e4XqMZyY"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op AdminSaveItem \
    --namespace $AB_NAMESPACE \
    --userId 'yf5AOFUf' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 29 'AdminSaveItem' test.out

#- 30 AdminSyncUserEntitlements
$CLI_EXE \
    --sn inventory \
    --op AdminSyncUserEntitlements \
    --namespace $AB_NAMESPACE \
    --userId 'Ys04yek5' \
    > test.out 2>&1
eval_tap $? 30 'AdminSyncUserEntitlements' test.out

#- 31 AdminPurchasable
# body param: body
echo '{"entitlementType": "zLDw2fRp", "inventoryConfig": {"slotUsed": 3}, "itemId": "vNWYTPRz", "itemType": "tthestua", "items": [{"bundledQty": 86, "entitlementType": "pZT4039h", "inventoryConfig": {"slotUsed": 40}, "itemId": "QuoNXT7m", "itemType": "157vrgaA", "sku": "meHXRg0A", "stackable": true, "useCount": 60}, {"bundledQty": 39, "entitlementType": "nEuF7fSB", "inventoryConfig": {"slotUsed": 53}, "itemId": "OUIQNRYi", "itemType": "nlGqbvdM", "sku": "RXy7Avqc", "stackable": false, "useCount": 26}, {"bundledQty": 8, "entitlementType": "ua1wBvHQ", "inventoryConfig": {"slotUsed": 91}, "itemId": "NHXKej1s", "itemType": "tcODCIZH", "sku": "xBQGeiOW", "stackable": false, "useCount": 57}], "quantity": 35, "sku": "W6Ho0lVt", "stackable": true, "useCount": 59}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op AdminPurchasable \
    --namespace $AB_NAMESPACE \
    --userId 'efaHiYdl' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 31 'AdminPurchasable' test.out

#- 32 PublicListInventoryConfigurations
$CLI_EXE \
    --sn inventory \
    --op PublicListInventoryConfigurations \
    --namespace $AB_NAMESPACE \
    --code 'wTDpFLm8' \
    --limit '77' \
    --offset '87' \
    --sortBy 'code' \
    > test.out 2>&1
eval_tap $? 32 'PublicListInventoryConfigurations' test.out

#- 33 PublicListItemTypes
$CLI_EXE \
    --sn inventory \
    --op PublicListItemTypes \
    --namespace $AB_NAMESPACE \
    --limit '13' \
    --offset '97' \
    --sortBy 'name:desc' \
    > test.out 2>&1
eval_tap $? 33 'PublicListItemTypes' test.out

#- 34 PublicListTags
$CLI_EXE \
    --sn inventory \
    --op PublicListTags \
    --namespace $AB_NAMESPACE \
    --limit '10' \
    --offset '77' \
    --sortBy 'createdAt:desc' \
    > test.out 2>&1
eval_tap $? 34 'PublicListTags' test.out

#- 35 PublicListInventories
$CLI_EXE \
    --sn inventory \
    --op PublicListInventories \
    --namespace $AB_NAMESPACE \
    --inventoryConfigurationCode 'OUa1CHi7' \
    --limit '81' \
    --offset '57' \
    --sortBy 'createdAt' \
    > test.out 2>&1
eval_tap $? 35 'PublicListInventories' test.out

#- 36 PublicConsumeMyItem
# body param: body
echo '{"qty": 36, "slotId": "jeTmlfx2", "sourceItemId": "OOuyKMXd"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op PublicConsumeMyItem \
    --inventoryId 'n6Wx1bZT' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 36 'PublicConsumeMyItem' test.out

#- 37 PublicListItems
$CLI_EXE \
    --sn inventory \
    --op PublicListItems \
    --inventoryId 'tjgyi5ts' \
    --namespace $AB_NAMESPACE \
    --limit '12' \
    --offset '45' \
    --sortBy 'createdAt:desc' \
    --sourceItemId 'esRyhHAu' \
    --tags 'kIkO2ycu' \
    > test.out 2>&1
eval_tap $? 37 'PublicListItems' test.out

#- 38 PublicBulkUpdateMyItems
# body param: body
echo '[{"customAttributes": {"qhONRV5p": {}, "6iDkpBmd": {}, "5SkkZqay": {}}, "slotId": "Bhy8GFPw", "sourceItemId": "cZJMGfI4", "tags": ["zUVsQW42", "Hg6FpkoQ", "N5EdObjR"]}, {"customAttributes": {"jOf6gD62": {}, "UWN7HSY7": {}, "fxz50YU9": {}}, "slotId": "quCEMfwG", "sourceItemId": "wLFHmhcT", "tags": ["zyCnPUDe", "TPxmEsGG", "4Q5syYKh"]}, {"customAttributes": {"6lO9Dndq": {}, "1mJJ93Gd": {}, "QOpom3h8": {}}, "slotId": "XLACe99Q", "sourceItemId": "FPfdP2aa", "tags": ["USgzxGy3", "eHWqHC05", "k82R7dMc"]}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op PublicBulkUpdateMyItems \
    --inventoryId 'lAUB9Eh4' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 38 'PublicBulkUpdateMyItems' test.out

#- 39 PublicBulkRemoveMyItems
# body param: body
echo '[{"slotId": "zzbho5jE", "sourceItemId": "GPuviLmZ"}, {"slotId": "ZbhUja1u", "sourceItemId": "eQnDryd0"}, {"slotId": "imEJIroY", "sourceItemId": "vGVe0tbh"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op PublicBulkRemoveMyItems \
    --inventoryId 'tw3o2KBr' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 39 'PublicBulkRemoveMyItems' test.out

#- 40 PublicMoveMyItems
# body param: body
echo '{"items": [{"qty": 25, "slotId": "rJM8SCJ7", "sourceItemId": "Ute693Iq"}, {"qty": 33, "slotId": "XrbZfaf7", "sourceItemId": "s8UhR1xa"}, {"qty": 16, "slotId": "QGLPyFAL", "sourceItemId": "e5hfJlzc"}], "srcInventoryId": "MzVKb53F"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op PublicMoveMyItems \
    --inventoryId 'J1o4W8fg' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 40 'PublicMoveMyItems' test.out

#- 41 PublicGetItem
$CLI_EXE \
    --sn inventory \
    --op PublicGetItem \
    --inventoryId 'Kw55mK0i' \
    --namespace $AB_NAMESPACE \
    --slotId 'oU6BEwn3' \
    --sourceItemId 'EJBDM4hi' \
    > test.out 2>&1
eval_tap $? 41 'PublicGetItem' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE