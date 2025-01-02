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
echo "1..44"

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
echo '{"message": "DSCbZOR1", "operations": [{"consumeItems": [{"dateRangeValidation": true, "inventoryId": "ZpcxR8CH", "options": ["foi1Zqo4", "qYQw6B8H", "TGFungix"], "qty": 29, "slotId": "zvRmLxC2", "sourceItemId": "IJePAoKJ"}, {"dateRangeValidation": false, "inventoryId": "HL4z7zQK", "options": ["zB54cx59", "WC6azDsT", "S6Grdrhv"], "qty": 61, "slotId": "1IiIr1qe", "sourceItemId": "0UScDAjw"}, {"dateRangeValidation": true, "inventoryId": "0Gi4rPdU", "options": ["EumScm7L", "YX1mb4BV", "5iJbH0zO"], "qty": 49, "slotId": "lWaCfyDc", "sourceItemId": "SezJRzHq"}], "createItems": [{"customAttributes": {"KNJCMZZd": {}, "s58HMc82": {}, "c5lLQ0EI": {}}, "inventoryConfigurationCode": "IEAP7M7Y", "inventoryId": "h14Pzv9E", "qty": 53, "serverCustomAttributes": {"iKRHFcdT": {}, "rXXTvWqU": {}, "llI0wROV": {}}, "slotId": "2zaswueq", "slotUsed": 73, "source": "OTHER", "sourceItemId": "4VxCWLTC", "tags": ["QqQnH8h2", "nwjmF0at", "XOmF810h"], "toSpecificInventory": true, "type": "MhT7iIxD"}, {"customAttributes": {"5tEIldG5": {}, "44uYguKl": {}, "TD1wqlWx": {}}, "inventoryConfigurationCode": "IMDBsfRI", "inventoryId": "3s9aWM9N", "qty": 8, "serverCustomAttributes": {"l8GX30cV": {}, "ycXKfXeD": {}, "b2qGELd0": {}}, "slotId": "GsukcFll", "slotUsed": 53, "source": "ECOMMERCE", "sourceItemId": "1aKyPsDD", "tags": ["EURqvQdS", "jX0lSAWU", "KP8ac808"], "toSpecificInventory": true, "type": "xeieV1r1"}, {"customAttributes": {"rJRjt7hF": {}, "3pbgBvBz": {}, "YyJ1Z2j8": {}}, "inventoryConfigurationCode": "mkwmZqfl", "inventoryId": "RTzAZnq1", "qty": 52, "serverCustomAttributes": {"ZA9lLqdz": {}, "XYCZyJQy": {}, "HLjRskb4": {}}, "slotId": "aQi2zWRr", "slotUsed": 35, "source": "OTHER", "sourceItemId": "vlp04nMW", "tags": ["MDnRkF4D", "RCgkvld7", "VcssVdFg"], "toSpecificInventory": true, "type": "0PA0VoQD"}], "removeItems": [{"inventoryId": "sGBYXmJ8", "slotId": "pWbMKhsz", "sourceItemId": "vePwSqiW"}, {"inventoryId": "OcoC5SK0", "slotId": "bNfqh2AP", "sourceItemId": "v2THDQ48"}, {"inventoryId": "8iPPDKZv", "slotId": "jExF6hdc", "sourceItemId": "puGWkMcR"}], "targetUserId": "T4giPmlR", "updateItems": [{"customAttributes": {"O8fnRSy2": {}, "yJfoYelX": {}, "tgVZaLfJ": {}}, "inventoryId": "N4tefwUm", "serverCustomAttributes": {"2BxDzrxE": {}, "Ii3B0G01": {}, "Gro9eQ3i": {}}, "slotId": "1SwmPRm8", "sourceItemId": "c8f5HQEI", "tags": ["gCHxZqOt", "w3INQgfb", "IgJ37g49"], "type": "LLJ56Uk5"}, {"customAttributes": {"kyDPnFKl": {}, "t6n8IAbM": {}, "1OosWKq5": {}}, "inventoryId": "EU0XHXrw", "serverCustomAttributes": {"ELLC5XsV": {}, "DCzUScQV": {}, "8BsTuuqZ": {}}, "slotId": "YYDtIdZW", "sourceItemId": "etPUDAnI", "tags": ["rcHxgQin", "1EiUzjtO", "YnO9CUMV"], "type": "7ZYtKJyM"}, {"customAttributes": {"19bysdmp": {}, "VexRxWwd": {}, "U5RlCWO6": {}}, "inventoryId": "hPs1QBFL", "serverCustomAttributes": {"cnynzsfV": {}, "MYiiaeKS": {}, "absY1HHH": {}}, "slotId": "CYDo9Vjf", "sourceItemId": "oMNLfA1c", "tags": ["HPnhTwjZ", "QzhNkSsT", "YFIk5e7u"], "type": "YCgrBTtQ"}]}, {"consumeItems": [{"dateRangeValidation": false, "inventoryId": "bjfpllVq", "options": ["R4cKmgqV", "dvapMcKg", "MdDML7wl"], "qty": 43, "slotId": "cCyLQCPl", "sourceItemId": "s268xzJY"}, {"dateRangeValidation": true, "inventoryId": "3ATJP6fB", "options": ["hDI6idKF", "NrhwNe8C", "uvAmScMu"], "qty": 13, "slotId": "O7s7Mx1q", "sourceItemId": "HgmrU399"}, {"dateRangeValidation": false, "inventoryId": "QHjnGryX", "options": ["WRnlnzfT", "0qm2P3Bx", "7DOpDkqJ"], "qty": 51, "slotId": "Yv9oEgLl", "sourceItemId": "DnegQjBk"}], "createItems": [{"customAttributes": {"mASYysNv": {}, "ANNp552L": {}, "uYYTEwqK": {}}, "inventoryConfigurationCode": "mIFfsSDy", "inventoryId": "ItYW43vq", "qty": 6, "serverCustomAttributes": {"gtoAk8CH": {}, "PjWhqfuP": {}, "3CcXDO7P": {}}, "slotId": "KpvNwqza", "slotUsed": 64, "source": "OTHER", "sourceItemId": "vak30nJ7", "tags": ["WNNHHSOr", "bkTJ2u5p", "Cij5Zhbg"], "toSpecificInventory": false, "type": "wzySzhpT"}, {"customAttributes": {"qEdVzMpn": {}, "3ZyDnwhV": {}, "r1m34mIs": {}}, "inventoryConfigurationCode": "Cumuv02s", "inventoryId": "PMJS6zIU", "qty": 8, "serverCustomAttributes": {"0O1fEUvj": {}, "G3Vl8rkl": {}, "9ftDi2ZC": {}}, "slotId": "mKh6fUfy", "slotUsed": 87, "source": "OTHER", "sourceItemId": "YDYCtiLp", "tags": ["3VkeGRJi", "CrWVOqz3", "oVxesw35"], "toSpecificInventory": true, "type": "9LV9KKsM"}, {"customAttributes": {"A4SqtwN1": {}, "jahFLlCo": {}, "ZjK0lwoc": {}}, "inventoryConfigurationCode": "AkWlyUyF", "inventoryId": "ZCm464Pd", "qty": 51, "serverCustomAttributes": {"qWkd2K44": {}, "HzqbVzCK": {}, "yrUfE6nR": {}}, "slotId": "j9pdxlVQ", "slotUsed": 72, "source": "OTHER", "sourceItemId": "AuVS6uM6", "tags": ["mMU6N1Gh", "8wZbpngh", "SOdtt8tn"], "toSpecificInventory": false, "type": "apTVW9Ah"}], "removeItems": [{"inventoryId": "pVwmqdsI", "slotId": "w7O8UqHU", "sourceItemId": "ZjzkJQxz"}, {"inventoryId": "wmxsFiqI", "slotId": "oH0adho3", "sourceItemId": "YLAUAaUD"}, {"inventoryId": "PJSStG9M", "slotId": "xmgCvUhn", "sourceItemId": "zIPYcInA"}], "targetUserId": "yjtt3H1k", "updateItems": [{"customAttributes": {"tSSyyzVB": {}, "17KeVk1b": {}, "BFvYHla0": {}}, "inventoryId": "Ry5d3Ou7", "serverCustomAttributes": {"wUB9SNr1": {}, "wfifW1gq": {}, "1AGTcwt8": {}}, "slotId": "7tlgkPND", "sourceItemId": "Bq2exrzU", "tags": ["gERgWt4W", "cOuFmzsn", "kqOo6mhG"], "type": "eQXOCgul"}, {"customAttributes": {"O6e3BTYk": {}, "eW9BzyrT": {}, "9zm5k01S": {}}, "inventoryId": "ytWMpQgo", "serverCustomAttributes": {"ReQD6r7v": {}, "xcTc2MDD": {}, "dgVdfq8Z": {}}, "slotId": "tmTplmae", "sourceItemId": "36euqfdY", "tags": ["dSp8FRyn", "H8XlzbXH", "hZHbQuNA"], "type": "5PoYQoTq"}, {"customAttributes": {"xQt8wvxj": {}, "oh3mn7BF": {}, "zvYlZHyv": {}}, "inventoryId": "MMs9qYfn", "serverCustomAttributes": {"suLPbUXR": {}, "pzbR8mnJ": {}, "fYoa7fAR": {}}, "slotId": "2l2tZ7S4", "sourceItemId": "hvsqkjci", "tags": ["Kxgw4UWt", "Kqjjy97y", "6RDO8GYM"], "type": "qK8wYmtL"}]}, {"consumeItems": [{"dateRangeValidation": true, "inventoryId": "7ESgmq4T", "options": ["2c9CHuQm", "VzTndHx3", "UtyKeiAo"], "qty": 14, "slotId": "1tZfw7tU", "sourceItemId": "MaswkmZ8"}, {"dateRangeValidation": false, "inventoryId": "FVcjRfE9", "options": ["UmQREWH1", "qATxm4xs", "ibcTzDpk"], "qty": 93, "slotId": "EAcHqgw9", "sourceItemId": "3Ct6EfZK"}, {"dateRangeValidation": true, "inventoryId": "UZxDQNGn", "options": ["4KdBKyuM", "DukbcvFo", "elA9bhWO"], "qty": 94, "slotId": "6PBY979Y", "sourceItemId": "5dRSYbQe"}], "createItems": [{"customAttributes": {"hOlCJf1h": {}, "dCoZ13mi": {}, "kxoS1Zep": {}}, "inventoryConfigurationCode": "6D2S7Q91", "inventoryId": "0du0o7D2", "qty": 79, "serverCustomAttributes": {"yQSZVrLE": {}, "4U7jzCYm": {}, "okf5x9X5": {}}, "slotId": "fp3mA48O", "slotUsed": 94, "source": "ECOMMERCE", "sourceItemId": "OirbAJQ3", "tags": ["tY1LvLWa", "R55edlYL", "m4Mf1EDr"], "toSpecificInventory": true, "type": "g0TvW5Yd"}, {"customAttributes": {"rETYopFE": {}, "xrAYtMKi": {}, "mT83wj8F": {}}, "inventoryConfigurationCode": "sbe8vkHi", "inventoryId": "rFQEWRjF", "qty": 96, "serverCustomAttributes": {"L17KpUc0": {}, "uAq3vbQn": {}, "16X5b6Ju": {}}, "slotId": "clHHzNKd", "slotUsed": 60, "source": "OTHER", "sourceItemId": "1HcFw7zo", "tags": ["gjCsYiG6", "lfw90hwS", "AKxCTrT1"], "toSpecificInventory": true, "type": "btyE1Dg9"}, {"customAttributes": {"np5nEUT6": {}, "zsalYrJV": {}, "2tfpHPTe": {}}, "inventoryConfigurationCode": "Qnv0GNj3", "inventoryId": "K6uftOJW", "qty": 52, "serverCustomAttributes": {"5XVKZvN2": {}, "XJLMDYMV": {}, "WOUFHZ1y": {}}, "slotId": "EGucCGNV", "slotUsed": 73, "source": "ECOMMERCE", "sourceItemId": "pT4eBIst", "tags": ["3lteR0B9", "2v1GJfx0", "n6CSDhr9"], "toSpecificInventory": false, "type": "pBscpX3i"}], "removeItems": [{"inventoryId": "GG2CY6z1", "slotId": "aaHeFWVN", "sourceItemId": "ieMAEaoN"}, {"inventoryId": "FGeMvVm8", "slotId": "BsF0ca0r", "sourceItemId": "wrFtdI3M"}, {"inventoryId": "WHceuQOb", "slotId": "NzrmJyDG", "sourceItemId": "WholZ8Gu"}], "targetUserId": "8SjO9YXR", "updateItems": [{"customAttributes": {"wLwWFGzk": {}, "gPrhHBCg": {}, "rCOn2HiU": {}}, "inventoryId": "bllqLATl", "serverCustomAttributes": {"b2wc3HBI": {}, "G2iuhLdQ": {}, "PCusVx7D": {}}, "slotId": "v7cj1dTo", "sourceItemId": "7PfqWu7L", "tags": ["ZB9DM5le", "U3HrOsxn", "a2y0g22w"], "type": "kY0H6pT4"}, {"customAttributes": {"xHwQCwkJ": {}, "b6z0xBvm": {}, "dkmv2wbX": {}}, "inventoryId": "eAOFSY8P", "serverCustomAttributes": {"wVzP6Lza": {}, "IIHShKg9": {}, "1DGU07vA": {}}, "slotId": "q3sHP3FX", "sourceItemId": "LFcmnr4j", "tags": ["vZM9UpSL", "aV8qh2Yp", "69vkUzEW"], "type": "Yda9FDng"}, {"customAttributes": {"Ykaf9VyU": {}, "NiFpcdr1": {}, "1RH6eMYR": {}}, "inventoryId": "8wGRJicz", "serverCustomAttributes": {"SQltx8FH": {}, "s16WjsMo": {}, "XBeEXIcA": {}}, "slotId": "ixN9wUDo", "sourceItemId": "ggHSqENs", "tags": ["54hgREjL", "wyi8NBCB", "pVFF9buB"], "type": "LJCGybfo"}]}], "requestId": "f9wePYeY"}' > $TEMP_JSON_INPUT
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
    --limit '20' \
    --offset '31' \
    --sortBy 'createdAt' \
    > test.out 2>&1
eval_tap $? 3 'AdminListIntegrationConfigurations' test.out

#- 4 AdminCreateIntegrationConfiguration
# body param: body
echo '{"mapItemType": ["lUjMZ1Vg", "Dnus8csV", "KQXjeFxA"], "serviceName": "q7UaJMOd", "targetInventoryCode": "vw6oUH4B"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op AdminCreateIntegrationConfiguration \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 4 'AdminCreateIntegrationConfiguration' test.out

#- 5 AdminUpdateIntegrationConfiguration
# body param: body
echo '{"mapItemType": ["lz9G3o11", "xIZ7YGkk", "rB7KQNND"], "serviceName": "ZV7IlqX8", "targetInventoryCode": "NJGNUa9c"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op AdminUpdateIntegrationConfiguration \
    --integrationConfigurationId 'UTLsS0nf' \
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
    --integrationConfigurationId '1E3V7SsO' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 6 'AdminUpdateStatusIntegrationConfiguration' test.out

#- 7 AdminListInventories
$CLI_EXE \
    --sn inventory \
    --op AdminListInventories \
    --namespace $AB_NAMESPACE \
    --inventoryConfigurationCode 'GSb8uLbI' \
    --limit '19' \
    --offset '92' \
    --sortBy 'inventoryConfigurationCode' \
    --userId 'fCjmILuK' \
    > test.out 2>&1
eval_tap $? 7 'AdminListInventories' test.out

#- 8 AdminCreateInventory
# body param: body
echo '{"inventoryConfigurationCode": "u2KqLcm3", "userId": "9DRglGIg"}' > $TEMP_JSON_INPUT
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
    --inventoryId '10Sfl2yR' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 9 'AdminGetInventory' test.out

#- 10 AdminUpdateInventory
# body param: body
echo '{"incMaxSlots": 7}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op AdminUpdateInventory \
    --inventoryId 'QxCd5Oag' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 10 'AdminUpdateInventory' test.out

#- 11 DeleteInventory
# body param: body
echo '{"message": "cvle01uc"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op DeleteInventory \
    --inventoryId 'KNpbhYEX' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 11 'DeleteInventory' test.out

#- 12 AdminListItems
$CLI_EXE \
    --sn inventory \
    --op AdminListItems \
    --inventoryId 'H40fvSAf' \
    --namespace $AB_NAMESPACE \
    --limit '66' \
    --offset '80' \
    --sortBy 'createdAt:desc' \
    --sourceItemId 'LWc8kvrD' \
    --tags 'PBQ6fD6s' \
    > test.out 2>&1
eval_tap $? 12 'AdminListItems' test.out

#- 13 AdminGetInventoryItem
$CLI_EXE \
    --sn inventory \
    --op AdminGetInventoryItem \
    --inventoryId 'BV5FEKsS' \
    --namespace $AB_NAMESPACE \
    --slotId 'brT2rMbq' \
    --sourceItemId 'GlLNhaF0' \
    > test.out 2>&1
eval_tap $? 13 'AdminGetInventoryItem' test.out

#- 14 AdminListInventoryConfigurations
$CLI_EXE \
    --sn inventory \
    --op AdminListInventoryConfigurations \
    --namespace $AB_NAMESPACE \
    --code 'nQOewh3I' \
    --limit '25' \
    --offset '19' \
    --sortBy 'createdAt' \
    > test.out 2>&1
eval_tap $? 14 'AdminListInventoryConfigurations' test.out

#- 15 AdminCreateInventoryConfiguration
# body param: body
echo '{"code": "cP2X1Q2V", "description": "o1jIAoxf", "initialMaxSlots": 60, "maxInstancesPerUser": 37, "maxUpgradeSlots": 72, "name": "n3zN8Xtl"}' > $TEMP_JSON_INPUT
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
    --inventoryConfigurationId '6JYe3ZJG' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 16 'AdminGetInventoryConfiguration' test.out

#- 17 AdminUpdateInventoryConfiguration
# body param: body
echo '{"code": "8Dh0iccL", "description": "VAY24kFs", "initialMaxSlots": 54, "maxInstancesPerUser": 48, "maxUpgradeSlots": 7, "name": "D0idJOmj"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op AdminUpdateInventoryConfiguration \
    --inventoryConfigurationId '9YkD4bqG' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 17 'AdminUpdateInventoryConfiguration' test.out

#- 18 AdminDeleteInventoryConfiguration
$CLI_EXE \
    --sn inventory \
    --op AdminDeleteInventoryConfiguration \
    --inventoryConfigurationId 'yzYyNThi' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 18 'AdminDeleteInventoryConfiguration' test.out

#- 19 AdminListItemTypes
$CLI_EXE \
    --sn inventory \
    --op AdminListItemTypes \
    --namespace $AB_NAMESPACE \
    --limit '87' \
    --offset '81' \
    --sortBy 'name:desc' \
    > test.out 2>&1
eval_tap $? 19 'AdminListItemTypes' test.out

#- 20 AdminCreateItemType
# body param: body
echo '{"name": "EXAJktp0"}' > $TEMP_JSON_INPUT
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
    --itemTypeName 'Y9wrlm2A' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 21 'AdminDeleteItemType' test.out

#- 22 AdminListTags
$CLI_EXE \
    --sn inventory \
    --op AdminListTags \
    --namespace $AB_NAMESPACE \
    --limit '41' \
    --offset '61' \
    --owner 'wjE987uY' \
    --sortBy 'name:desc' \
    > test.out 2>&1
eval_tap $? 22 'AdminListTags' test.out

#- 23 AdminCreateTag
# body param: body
echo '{"name": "LNAeEQYD", "owner": "SERVER"}' > $TEMP_JSON_INPUT
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
    --tagName 'gDwn5CRZ' \
    > test.out 2>&1
eval_tap $? 24 'AdminDeleteTag' test.out

#- 25 AdminConsumeUserItem
# body param: body
echo '{"options": ["iOmqJys7", "ICpfieXA", "7Hl7ZrNk"], "qty": 88, "slotId": "finzNvCh", "sourceItemId": "yZ7bpxSS"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op AdminConsumeUserItem \
    --inventoryId 'Lw7fnmVD' \
    --namespace $AB_NAMESPACE \
    --userId 'X1f4u9iA' \
    --dateRangeValidation 'xP4QoSk5' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 25 'AdminConsumeUserItem' test.out

#- 26 AdminBulkUpdateMyItems
# body param: body
echo '[{"customAttributes": {"cJOX1j8E": {}, "SbujPiXy": {}, "bJ0HPTgL": {}}, "serverCustomAttributes": {"rDl6gzIQ": {}, "XKOSwpq1": {}, "IfTFUgo0": {}}, "slotId": "rKSxRkym", "sourceItemId": "m7Ip4qNQ", "tags": ["CeQQYAPG", "uZYo0uUf", "L165wZ27"], "type": "15nm6kXs"}, {"customAttributes": {"ZvgLkFba": {}, "kmFrp3nc": {}, "jaKepyjG": {}}, "serverCustomAttributes": {"VWEyfhcH": {}, "If5OJv7D": {}, "3QmQoCMs": {}}, "slotId": "aHaWwFM9", "sourceItemId": "MLphWJ16", "tags": ["nBHrJVjn", "yVTRY9Qn", "eNfxCzvo"], "type": "j6cdC0Pr"}, {"customAttributes": {"8NctAuKH": {}, "Ewe8ZOss": {}, "J8LQEZCP": {}}, "serverCustomAttributes": {"OU9Ke9a5": {}, "zz8DIWlg": {}, "OJCJpFtj": {}}, "slotId": "vFF7Ce5u", "sourceItemId": "Si3e7Orc", "tags": ["V6VNAkX6", "vvF3Z026", "X8RhfUfF"], "type": "ThgwuoED"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op AdminBulkUpdateMyItems \
    --inventoryId '243RhdGe' \
    --namespace $AB_NAMESPACE \
    --userId 'xFisnq2c' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 26 'AdminBulkUpdateMyItems' test.out

#- 27 AdminSaveItemToInventory
# body param: body
echo '{"customAttributes": {"YMGesPHo": {}, "Ut35WVl0": {}, "IDsgQU9Y": {}}, "qty": 8, "serverCustomAttributes": {"2FsUSied": {}, "ihOOR7u8": {}, "PwQHDgWT": {}}, "slotId": "5HklzY3V", "slotUsed": 57, "source": "OTHER", "sourceItemId": "kdaodxRR", "tags": ["ke3PxKHN", "VCvOnHOO", "hbnwyEOO"], "type": "WSS5SO6c"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op AdminSaveItemToInventory \
    --inventoryId 'wCCo79pJ' \
    --namespace $AB_NAMESPACE \
    --userId 'ZNv7uONF' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 27 'AdminSaveItemToInventory' test.out

#- 28 AdminBulkRemoveItems
# body param: body
echo '[{"slotId": "EdjHwolc", "sourceItemId": "iumhGqqq"}, {"slotId": "3sdH48bp", "sourceItemId": "tNauH81q"}, {"slotId": "UwCguWyQ", "sourceItemId": "RUgRusIT"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op AdminBulkRemoveItems \
    --inventoryId 'zjh42lgd' \
    --namespace $AB_NAMESPACE \
    --userId 'KdCyMkPL' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 28 'AdminBulkRemoveItems' test.out

#- 29 AdminBulkSaveItemToInventory
# body param: body
echo '[{"customAttributes": {"rtqRYBXk": {}, "SAQtcobM": {}, "Ar6Qu668": {}}, "qty": 15, "serverCustomAttributes": {"S1uYNAVm": {}, "sqxb8hO1": {}, "xPVK9Gnm": {}}, "slotId": "0rohOqzb", "slotUsed": 22, "source": "OTHER", "sourceItemId": "ImBCyhaF", "tags": ["AxVIIGua", "7NKiQ8wh", "c1IEv3Bg"], "type": "TWVAxpmm"}, {"customAttributes": {"xOFmDa3g": {}, "7umvmnH1": {}, "oeDKCXuq": {}}, "qty": 89, "serverCustomAttributes": {"kduzMmMu": {}, "SUC4JJaZ": {}, "SvB9fsDg": {}}, "slotId": "GQS5Nm60", "slotUsed": 48, "source": "ECOMMERCE", "sourceItemId": "tVzGfArQ", "tags": ["RnHrDnW1", "DzYdqGVg", "jB90bSVT"], "type": "ZXP52zXw"}, {"customAttributes": {"AVLBYKnU": {}, "r2Xrvy5Q": {}, "ECRjgO2j": {}}, "qty": 21, "serverCustomAttributes": {"E6vOkJ3o": {}, "lsXHXa5q": {}, "4Fljx4dS": {}}, "slotId": "EMNLKdFQ", "slotUsed": 47, "source": "ECOMMERCE", "sourceItemId": "gdxgB6CC", "tags": ["79mqJV7S", "p2FiHg94", "0ICM90Wj"], "type": "jGvwWCGS"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op AdminBulkSaveItemToInventory \
    --inventoryId 'rzLW4ngq' \
    --namespace $AB_NAMESPACE \
    --userId 'E6ZqUDzi' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 29 'AdminBulkSaveItemToInventory' test.out

#- 30 AdminUpdateUserInventoriesByInventoryCode
# body param: body
echo '{"incMaxSlots": 64}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op AdminUpdateUserInventoriesByInventoryCode \
    --inventoryConfigurationCode 'W41kJHmW' \
    --namespace $AB_NAMESPACE \
    --userId 'IqjacG3L' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 30 'AdminUpdateUserInventoriesByInventoryCode' test.out

#- 31 AdminSaveItem
# body param: body
echo '{"customAttributes": {"udHLYqWa": {}, "LVhE88SB": {}, "P519ByxW": {}}, "inventoryConfigurationCode": "u9ACdcwv", "qty": 19, "serverCustomAttributes": {"3sI0UWwo": {}, "h4KC9ON5": {}, "egYHVYzC": {}}, "slotId": "PbKWCJTc", "slotUsed": 23, "source": "OTHER", "sourceItemId": "fqKDA7jI", "tags": ["Eclt4Y87", "GlprXnwe", "Nt4jt7VL"], "type": "JSGKkxce"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op AdminSaveItem \
    --namespace $AB_NAMESPACE \
    --userId 'sgIJt8Ri' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 31 'AdminSaveItem' test.out

#- 32 AdminBulkSaveItem
# body param: body
echo '[{"customAttributes": {"uClEhysr": {}, "aPNsPHnL": {}, "ip8i9rrN": {}}, "inventoryConfigurationCode": "U902azem", "qty": 98, "serverCustomAttributes": {"6SoKLLtu": {}, "CrSXsLZv": {}, "Go4dEzYG": {}}, "slotId": "spjJIr3T", "slotUsed": 14, "source": "OTHER", "sourceItemId": "Uh0IPV1i", "tags": ["7vqQRdM1", "KAgbPvm0", "Afm8z8oY"], "type": "zMELRsLM"}, {"customAttributes": {"eDUXjfGE": {}, "bH3A9Cwd": {}, "BHLoXf9t": {}}, "inventoryConfigurationCode": "ZqaycrTj", "qty": 18, "serverCustomAttributes": {"s8ssb7Qx": {}, "CdHPPKlX": {}, "cnX8lnTP": {}}, "slotId": "poPVZBId", "slotUsed": 58, "source": "ECOMMERCE", "sourceItemId": "f9vG22eR", "tags": ["PmoUkCcm", "HFedlmC2", "yyjnbdTn"], "type": "3Nxaq2Si"}, {"customAttributes": {"EST7ymmg": {}, "yFXZMflR": {}, "0PFMeKQp": {}}, "inventoryConfigurationCode": "TtdqSwib", "qty": 29, "serverCustomAttributes": {"a2uJ99cF": {}, "cR79mZpG": {}, "S9vw9LWu": {}}, "slotId": "4eWZmCuU", "slotUsed": 76, "source": "ECOMMERCE", "sourceItemId": "1F2BGwFs", "tags": ["jy6ZW0cU", "fRZMyG4H", "5CH5sdfU"], "type": "ryl4slKL"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op AdminBulkSaveItem \
    --namespace $AB_NAMESPACE \
    --userId '4p265XT1' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 32 'AdminBulkSaveItem' test.out

#- 33 AdminSyncUserEntitlements
$CLI_EXE \
    --sn inventory \
    --op AdminSyncUserEntitlements \
    --namespace $AB_NAMESPACE \
    --userId 'FhQGh5tx' \
    > test.out 2>&1
eval_tap $? 33 'AdminSyncUserEntitlements' test.out

#- 34 AdminPurchasable
# body param: body
echo '{"entitlementType": "W9Jebhy0", "inventoryConfig": {"slotUsed": 42}, "itemId": "1LHR71ET", "itemType": "tBxjYhOZ", "items": [{"bundledQty": 8, "entitlementType": "FLQQdo8w", "inventoryConfig": {"slotUsed": 5}, "itemId": "Jcmlqj2Y", "itemType": "uxuwcIqK", "sku": "8DUJMYcP", "stackable": true, "useCount": 91}, {"bundledQty": 75, "entitlementType": "A8gFO8DB", "inventoryConfig": {"slotUsed": 71}, "itemId": "MO0X3zcN", "itemType": "lGVokDP6", "sku": "vZUMX7xg", "stackable": true, "useCount": 54}, {"bundledQty": 68, "entitlementType": "lrBInnZ8", "inventoryConfig": {"slotUsed": 56}, "itemId": "x4GyHVY3", "itemType": "I7uYIo9a", "sku": "rRhBq7VP", "stackable": false, "useCount": 91}], "quantity": 43, "sku": "RYkUnLGZ", "stackable": true, "useCount": 9}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op AdminPurchasable \
    --namespace $AB_NAMESPACE \
    --userId 'biBoVTAP' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 34 'AdminPurchasable' test.out

#- 35 PublicListInventoryConfigurations
$CLI_EXE \
    --sn inventory \
    --op PublicListInventoryConfigurations \
    --namespace $AB_NAMESPACE \
    --code 'GRxRBgnY' \
    --limit '83' \
    --offset '31' \
    --sortBy 'updatedAt' \
    > test.out 2>&1
eval_tap $? 35 'PublicListInventoryConfigurations' test.out

#- 36 PublicListItemTypes
$CLI_EXE \
    --sn inventory \
    --op PublicListItemTypes \
    --namespace $AB_NAMESPACE \
    --limit '63' \
    --offset '65' \
    --sortBy 'name:desc' \
    > test.out 2>&1
eval_tap $? 36 'PublicListItemTypes' test.out

#- 37 PublicListTags
$CLI_EXE \
    --sn inventory \
    --op PublicListTags \
    --namespace $AB_NAMESPACE \
    --limit '36' \
    --offset '91' \
    --sortBy 'name:desc' \
    > test.out 2>&1
eval_tap $? 37 'PublicListTags' test.out

#- 38 PublicListInventories
$CLI_EXE \
    --sn inventory \
    --op PublicListInventories \
    --namespace $AB_NAMESPACE \
    --inventoryConfigurationCode 'PUikSbdd' \
    --limit '16' \
    --offset '93' \
    --sortBy 'createdAt:desc' \
    > test.out 2>&1
eval_tap $? 38 'PublicListInventories' test.out

#- 39 PublicConsumeMyItem
# body param: body
echo '{"options": ["pip1LBJd", "xGg81pst", "5GT10KFY"], "qty": 22, "slotId": "NLW17bxx", "sourceItemId": "QBimor26"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op PublicConsumeMyItem \
    --inventoryId '5t8VurZp' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 39 'PublicConsumeMyItem' test.out

#- 40 PublicListItems
$CLI_EXE \
    --sn inventory \
    --op PublicListItems \
    --inventoryId 'LC4KuRBD' \
    --namespace $AB_NAMESPACE \
    --limit '68' \
    --offset '45' \
    --sortBy 'createdAt:desc' \
    --sourceItemId 'yzJfdmK1' \
    --tags 'z0EhvF2E' \
    > test.out 2>&1
eval_tap $? 40 'PublicListItems' test.out

#- 41 PublicBulkUpdateMyItems
# body param: body
echo '[{"customAttributes": {"UwcVP2Ti": {}, "tXOPY6tE": {}, "1qQLfDOg": {}}, "slotId": "kkF5JBiM", "sourceItemId": "4J2nD0f1", "tags": ["6KprImcg", "x4XEPjIv", "XxbCq4Me"]}, {"customAttributes": {"VJ5PG1aQ": {}, "hvD7O75k": {}, "EgPoEtIH": {}}, "slotId": "zoFkGkD2", "sourceItemId": "cKwUdhQH", "tags": ["OAqnqp6O", "GHbavwJ4", "gKCiMqbA"]}, {"customAttributes": {"RkjfJ4Ja": {}, "3oOfPUdG": {}, "fewBLUaZ": {}}, "slotId": "ZpZpPp0q", "sourceItemId": "0mUxDo9d", "tags": ["0N75EtyB", "3eMuweg8", "AOSk033e"]}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op PublicBulkUpdateMyItems \
    --inventoryId '3t9Ya0f2' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 41 'PublicBulkUpdateMyItems' test.out

#- 42 PublicBulkRemoveMyItems
# body param: body
echo '[{"slotId": "WnpG30Pc", "sourceItemId": "xbTRcP47"}, {"slotId": "k0RvrhRn", "sourceItemId": "jBLHYbEe"}, {"slotId": "YGHJYXv9", "sourceItemId": "Z1MpImAL"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op PublicBulkRemoveMyItems \
    --inventoryId 'b2LZ3XEi' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 42 'PublicBulkRemoveMyItems' test.out

#- 43 PublicMoveMyItems
# body param: body
echo '{"items": [{"qty": 19, "slotId": "GlaDwwAA", "sourceItemId": "TqPfr4Vn"}, {"qty": 77, "slotId": "ooJMgmG6", "sourceItemId": "6aUhAa32"}, {"qty": 84, "slotId": "5L41kZHS", "sourceItemId": "JPLfFiVa"}], "srcInventoryId": "uOSpFHbO"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op PublicMoveMyItems \
    --inventoryId '4Je7RCGP' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 43 'PublicMoveMyItems' test.out

#- 44 PublicGetItem
$CLI_EXE \
    --sn inventory \
    --op PublicGetItem \
    --inventoryId 'M4eJRMXU' \
    --namespace $AB_NAMESPACE \
    --slotId 'pWXIudbv' \
    --sourceItemId 'ad8dV5XH' \
    > test.out 2>&1
eval_tap $? 44 'PublicGetItem' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE