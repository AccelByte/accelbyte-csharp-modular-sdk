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
echo "1..35"

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
echo '{"message": "F5My5nT0", "operations": [{"consumeItems": [{"inventoryId": "qFZOGcAh", "qty": 72, "slotId": "bmWN1uLh", "sourceItemId": "acPXLAjx"}, {"inventoryId": "OaMnUZp2", "qty": 69, "slotId": "0HqYoPPm", "sourceItemId": "8kTYnQ7A"}, {"inventoryId": "KcZJTMDH", "qty": 82, "slotId": "UV3yZCOi", "sourceItemId": "tV3pFhpn"}], "createItems": [{"customAttributes": {"QyXEdYEv": {}, "J9iDTyJ4": {}, "SjvkAZsF": {}}, "inventoryConfigurationCode": "P0IgsnWc", "inventoryId": "5jpKOrGn", "qty": 85, "serverCustomAttributes": {"DwZeCXvd": {}, "lUXg4hbz": {}, "Vc5vrlIJ": {}}, "slotId": "cIbOxDed", "slotUsed": 8, "sourceItemId": "o6GR1cBf", "tags": ["FkpWAo6b", "AszusYnM", "WqGUG0iQ"], "toSpecificInventory": true, "type": "JzVG8Mvf"}, {"customAttributes": {"8vH9zDxN": {}, "KpottiIA": {}, "zCbHxoqj": {}}, "inventoryConfigurationCode": "HBMT63l5", "inventoryId": "LgRlCYmb", "qty": 8, "serverCustomAttributes": {"JnUPf69p": {}, "C7g6VTnR": {}, "4NMQ69qf": {}}, "slotId": "0oLa3Bjj", "slotUsed": 16, "sourceItemId": "2HCMHA4h", "tags": ["YSyzZjVz", "0ktqm8Pu", "PgWnhbzw"], "toSpecificInventory": true, "type": "4ygTIwDc"}, {"customAttributes": {"xFDRKWGn": {}, "B46TtpA4": {}, "qfP108ZF": {}}, "inventoryConfigurationCode": "cEkMh8hC", "inventoryId": "I0DAwEry", "qty": 74, "serverCustomAttributes": {"8j01SBmy": {}, "aAKQVxS9": {}, "ZiWV4BTc": {}}, "slotId": "6be5Hwug", "slotUsed": 25, "sourceItemId": "E7ZNT1Ms", "tags": ["6nK9QWr3", "43aFzq3V", "Kmzyq2S1"], "toSpecificInventory": true, "type": "7EaCQ7zC"}], "removeItems": [{"inventoryId": "iOQzZThn", "slotId": "RXxl0loO", "sourceItemId": "OZ5FW2z5"}, {"inventoryId": "iEzUo3rc", "slotId": "F3dEx4jo", "sourceItemId": "M7rlxJyj"}, {"inventoryId": "vweqcs3Z", "slotId": "0m33JdEv", "sourceItemId": "rqMq5fnG"}], "targetUserId": "bvxwh5Pm", "updateItems": [{"customAttributes": {"oBHfjBqH": {}, "5iEtenco": {}, "SBFjp1Lh": {}}, "inventoryId": "nrtopRs3", "serverCustomAttributes": {"an9Esg4W": {}, "5ipAklPo": {}, "WgRAvl4F": {}}, "slotId": "CuiQhmr8", "sourceItemId": "J9KQXgmT", "tags": ["J0kefBSD", "fO0U6nzq", "30U7t8sg"], "type": "UqOKDOj5"}, {"customAttributes": {"BF7zkKr4": {}, "3sHNuWsV": {}, "7Asuutg7": {}}, "inventoryId": "D8BNPxjn", "serverCustomAttributes": {"Svp9pAhd": {}, "nbK5faXI": {}, "aye6WjHA": {}}, "slotId": "M37jR4xc", "sourceItemId": "dlxkLEKA", "tags": ["su2KV0y6", "KcmWm6z2", "6mAcQeLr"], "type": "zaCYUNch"}, {"customAttributes": {"RdXLOl2f": {}, "cOZA1rFa": {}, "1eF3gldg": {}}, "inventoryId": "9cXtH64r", "serverCustomAttributes": {"giHlSDcs": {}, "XzYRB8ao": {}, "ru5uG5pp": {}}, "slotId": "qcWUfnrc", "sourceItemId": "UyL4UtNP", "tags": ["8rZynXhi", "4YaSQTS6", "LhwCrX0n"], "type": "GdoYoQ96"}]}, {"consumeItems": [{"inventoryId": "ErVsw2nl", "qty": 40, "slotId": "s4d9BD5c", "sourceItemId": "aB1tiaWC"}, {"inventoryId": "u4AaB2ot", "qty": 43, "slotId": "bJksK4Tw", "sourceItemId": "IPIwSFCv"}, {"inventoryId": "NhDh6cNj", "qty": 75, "slotId": "OeIcyyTR", "sourceItemId": "4neopgwM"}], "createItems": [{"customAttributes": {"eimBYu1q": {}, "w85ORmTQ": {}, "VGowZyRj": {}}, "inventoryConfigurationCode": "XQlimIf4", "inventoryId": "b6PyFHm4", "qty": 92, "serverCustomAttributes": {"NsdPyJZK": {}, "k3xjgxkr": {}, "hVkTLop4": {}}, "slotId": "FDDEC9zw", "slotUsed": 5, "sourceItemId": "Sg2mHNcw", "tags": ["0efqmd8y", "QSaAmIhP", "czb7lLz3"], "toSpecificInventory": false, "type": "SDaOjPJo"}, {"customAttributes": {"IaGYdqw2": {}, "qGEADERb": {}, "ZmdYPKBB": {}}, "inventoryConfigurationCode": "MhO26of5", "inventoryId": "u70WXl3Y", "qty": 31, "serverCustomAttributes": {"OlRtjcDr": {}, "DvsUmCaL": {}, "5WFjJNxn": {}}, "slotId": "aPzUbrNy", "slotUsed": 44, "sourceItemId": "FDitYM0w", "tags": ["cWJSXLCP", "wj6pC34Z", "r41Fudmh"], "toSpecificInventory": false, "type": "3Xa6sVfK"}, {"customAttributes": {"RheusMgn": {}, "s7tP7g8B": {}, "Z2pyvc3d": {}}, "inventoryConfigurationCode": "wHmEorZc", "inventoryId": "23Y5TD9Z", "qty": 7, "serverCustomAttributes": {"eHVmDJXJ": {}, "CB7qFqHR": {}, "ZMqkjLmV": {}}, "slotId": "u3r2tPYh", "slotUsed": 19, "sourceItemId": "urnhfTG2", "tags": ["wgml8ww4", "wBEoiQT8", "TRYaw6CE"], "toSpecificInventory": false, "type": "t6QFcDFy"}], "removeItems": [{"inventoryId": "ANBtOvud", "slotId": "wNKDuMTw", "sourceItemId": "nJ00LZ1Z"}, {"inventoryId": "ArtAaqkp", "slotId": "GO7GNNKm", "sourceItemId": "H9uBd4Tj"}, {"inventoryId": "Vake5OBO", "slotId": "J2XlgjIY", "sourceItemId": "24XXXZz1"}], "targetUserId": "apocnciE", "updateItems": [{"customAttributes": {"FmQHmRbo": {}, "KvvU0zRN": {}, "o8eD98N6": {}}, "inventoryId": "H6PDktCH", "serverCustomAttributes": {"pB6tMiKw": {}, "g5p27mhp": {}, "pTxztFxC": {}}, "slotId": "2vv0hOWk", "sourceItemId": "rt9eGxz4", "tags": ["E7IloQPK", "e84L6FnX", "LLmsjzre"], "type": "NWe5ymEu"}, {"customAttributes": {"KrIlejwq": {}, "RYuGJ9pD": {}, "DPyPNegf": {}}, "inventoryId": "pG900WeN", "serverCustomAttributes": {"S0YkoppM": {}, "ymGY5K6o": {}, "rCzVXKpg": {}}, "slotId": "PkYSXFUu", "sourceItemId": "14fi4n5X", "tags": ["BYF4T3PN", "J32V1Hgh", "iG4I7VhC"], "type": "YL9nGmFA"}, {"customAttributes": {"OosTguWh": {}, "VgLLcVGF": {}, "88CqgIyd": {}}, "inventoryId": "jHYsY0LX", "serverCustomAttributes": {"cFMhFhlK": {}, "78W2SqfD": {}, "sxT0VyHf": {}}, "slotId": "N4KiJBV2", "sourceItemId": "ArLDZzwr", "tags": ["vpP6TO3F", "8x2ElDWF", "Dvzce1Ga"], "type": "RRxSCA5V"}]}, {"consumeItems": [{"inventoryId": "fp1jubGQ", "qty": 89, "slotId": "877zGJbr", "sourceItemId": "PbyqARnF"}, {"inventoryId": "Oe7RyEyd", "qty": 58, "slotId": "t4e5wfCX", "sourceItemId": "mSPgo3mk"}, {"inventoryId": "9HpcqD70", "qty": 39, "slotId": "5GTsSDw8", "sourceItemId": "7dMmBm25"}], "createItems": [{"customAttributes": {"fOPoZAkE": {}, "qqUpttbq": {}, "zhs934Zv": {}}, "inventoryConfigurationCode": "Psz3tRZN", "inventoryId": "w0Da3Ncl", "qty": 60, "serverCustomAttributes": {"hImpe9Mh": {}, "oG5yIepf": {}, "EJyzxJip": {}}, "slotId": "afASrJxG", "slotUsed": 78, "sourceItemId": "NP9mltVB", "tags": ["JSJpPSbc", "1h7NxPeH", "Re5iWqNm"], "toSpecificInventory": true, "type": "vKa9SOQu"}, {"customAttributes": {"1veQ7ZaL": {}, "yDP3wI7e": {}, "KIElaGAh": {}}, "inventoryConfigurationCode": "bvPkszKa", "inventoryId": "hg5bSJAP", "qty": 41, "serverCustomAttributes": {"CjspuOIz": {}, "yiM94pgc": {}, "cHufzMPH": {}}, "slotId": "JsxzGvdR", "slotUsed": 28, "sourceItemId": "QKF07tDp", "tags": ["0NagnXdX", "qH7d7fw7", "9dct2S84"], "toSpecificInventory": false, "type": "ABQYPA2z"}, {"customAttributes": {"fPiDDpi7": {}, "KCtJqvRo": {}, "niPbfbvd": {}}, "inventoryConfigurationCode": "Vc3N2z04", "inventoryId": "hXV5DrsQ", "qty": 28, "serverCustomAttributes": {"sBHhsnFS": {}, "bGP6piob": {}, "P45dZFyj": {}}, "slotId": "RrUCg1OW", "slotUsed": 64, "sourceItemId": "VhO5mumU", "tags": ["meqI6LLz", "RdKdIYko", "Kxa05lLy"], "toSpecificInventory": false, "type": "mS4YMcz9"}], "removeItems": [{"inventoryId": "OTFeR4m8", "slotId": "hRh0nMUi", "sourceItemId": "ziGiCmr3"}, {"inventoryId": "573cvWW4", "slotId": "3umfzlos", "sourceItemId": "JyJZJHJv"}, {"inventoryId": "w9GS7ZsV", "slotId": "6E10jGsT", "sourceItemId": "JycyEYgX"}], "targetUserId": "jc1FRGZt", "updateItems": [{"customAttributes": {"aVtHjvB8": {}, "A2ncqwMX": {}, "MdVskfW3": {}}, "inventoryId": "LGVJt6ad", "serverCustomAttributes": {"iuUsRvJG": {}, "4g62FToz": {}, "lCzXcX6O": {}}, "slotId": "r9RGiBRw", "sourceItemId": "5tLBawLL", "tags": ["5U6cOAR7", "Heu0dsPd", "aQRfc4Ol"], "type": "0GJsKZE5"}, {"customAttributes": {"4glhTgdp": {}, "EA6kZR82": {}, "2qg90FwQ": {}}, "inventoryId": "kS8FvCxb", "serverCustomAttributes": {"kpl2ITsP": {}, "I8976e9L": {}, "90IM2j6v": {}}, "slotId": "sKmsg0JN", "sourceItemId": "BE0s2Lj4", "tags": ["QNuDkAsB", "yBuuHf5j", "10OvspDm"], "type": "uLCqZhnp"}, {"customAttributes": {"cfWcaRAW": {}, "7wmQNcFq": {}, "nFjJfG83": {}}, "inventoryId": "uuPhk182", "serverCustomAttributes": {"Ssby2a1R": {}, "9483SUeQ": {}, "Ch11yDfT": {}}, "slotId": "BhhGJJIV", "sourceItemId": "UbGpsOYa", "tags": ["nU8KlTuz", "HHIwRMXw", "fg41V1JW"], "type": "mMkjWw7f"}]}], "requestId": "Pe2NRjKZ"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op AdminCreateChainingOperations \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 2 'AdminCreateChainingOperations' test.out

#- 3 AdminListInventories
$CLI_EXE \
    --sn inventory \
    --op AdminListInventories \
    --namespace $AB_NAMESPACE \
    --inventoryConfigurationCode 'xKO7vOFx' \
    --limit '16' \
    --offset '50' \
    --sortBy 'inventoryConfigurationCode' \
    --userId '8CUMWOKs' \
    > test.out 2>&1
eval_tap $? 3 'AdminListInventories' test.out

#- 4 AdminCreateInventory
# body param: body
echo '{"inventoryConfigurationCode": "XO6iRxkW", "userId": "I4qBtKgy"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op AdminCreateInventory \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 4 'AdminCreateInventory' test.out

#- 5 AdminGetInventory
$CLI_EXE \
    --sn inventory \
    --op AdminGetInventory \
    --inventoryId 'goIGruXy' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 5 'AdminGetInventory' test.out

#- 6 AdminUpdateInventory
# body param: body
echo '{"incMaxSlots": 29}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op AdminUpdateInventory \
    --inventoryId 'kv2RRH4O' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 6 'AdminUpdateInventory' test.out

#- 7 DeleteInventory
# body param: body
echo '{"message": "fGxxCOs8"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op DeleteInventory \
    --inventoryId 'xsPwOCbZ' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 7 'DeleteInventory' test.out

#- 8 AdminListItems
$CLI_EXE \
    --sn inventory \
    --op AdminListItems \
    --inventoryId 'ZBIhF85i' \
    --namespace $AB_NAMESPACE \
    --limit '82' \
    --offset '49' \
    --qtyGte '34' \
    --sortBy 'createdAt' \
    --sourceItemId 'HtjPKM05' \
    --tags 'qrafbIII' \
    > test.out 2>&1
eval_tap $? 8 'AdminListItems' test.out

#- 9 AdminGetInventoryItem
$CLI_EXE \
    --sn inventory \
    --op AdminGetInventoryItem \
    --inventoryId 'dwuyN1oa' \
    --namespace $AB_NAMESPACE \
    --slotId 'iE470nF2' \
    --sourceItemId 'RXN4RdkG' \
    > test.out 2>&1
eval_tap $? 9 'AdminGetInventoryItem' test.out

#- 10 AdminListInventoryConfigurations
$CLI_EXE \
    --sn inventory \
    --op AdminListInventoryConfigurations \
    --namespace $AB_NAMESPACE \
    --code 'lwr4vPmV' \
    --limit '77' \
    --offset '76' \
    --sortBy 'updatedAt' \
    > test.out 2>&1
eval_tap $? 10 'AdminListInventoryConfigurations' test.out

#- 11 AdminCreateInventoryConfiguration
# body param: body
echo '{"code": "PDLomvG8", "description": "guaeRxlJ", "initialMaxSlots": 6, "maxInstancesPerUser": 47, "maxUpgradeSlots": 5, "name": "kcTLcwgf"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op AdminCreateInventoryConfiguration \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 11 'AdminCreateInventoryConfiguration' test.out

#- 12 AdminGetInventoryConfiguration
$CLI_EXE \
    --sn inventory \
    --op AdminGetInventoryConfiguration \
    --inventoryConfigurationId 'sUyhZWU5' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 12 'AdminGetInventoryConfiguration' test.out

#- 13 AdminUpdateInventoryConfiguration
# body param: body
echo '{"code": "WwQuNTzh", "description": "ObIWz1QJ", "initialMaxSlots": 29, "maxInstancesPerUser": 70, "maxUpgradeSlots": 43, "name": "S1hvQWSI"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op AdminUpdateInventoryConfiguration \
    --inventoryConfigurationId 'ClLykCgX' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 13 'AdminUpdateInventoryConfiguration' test.out

#- 14 AdminDeleteInventoryConfiguration
$CLI_EXE \
    --sn inventory \
    --op AdminDeleteInventoryConfiguration \
    --inventoryConfigurationId '12DdFQ08' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 14 'AdminDeleteInventoryConfiguration' test.out

#- 15 AdminListItemTypes
$CLI_EXE \
    --sn inventory \
    --op AdminListItemTypes \
    --namespace $AB_NAMESPACE \
    --limit '60' \
    --offset '4' \
    --sortBy 'createdAt:desc' \
    > test.out 2>&1
eval_tap $? 15 'AdminListItemTypes' test.out

#- 16 AdminCreateItemType
# body param: body
echo '{"name": "jkwQEltG"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op AdminCreateItemType \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 16 'AdminCreateItemType' test.out

#- 17 AdminDeleteItemType
$CLI_EXE \
    --sn inventory \
    --op AdminDeleteItemType \
    --itemTypeName '8O44Wi44' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 17 'AdminDeleteItemType' test.out

#- 18 AdminListTags
$CLI_EXE \
    --sn inventory \
    --op AdminListTags \
    --namespace $AB_NAMESPACE \
    --limit '63' \
    --offset '85' \
    --owner '9kQHncqG' \
    --sortBy 'createdAt' \
    > test.out 2>&1
eval_tap $? 18 'AdminListTags' test.out

#- 19 AdminCreateTag
# body param: body
echo '{"name": "bVIzaZrK", "owner": "CLIENT"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op AdminCreateTag \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 19 'AdminCreateTag' test.out

#- 20 AdminDeleteTag
$CLI_EXE \
    --sn inventory \
    --op AdminDeleteTag \
    --namespace $AB_NAMESPACE \
    --tagName '2UNtRezh' \
    > test.out 2>&1
eval_tap $? 20 'AdminDeleteTag' test.out

#- 21 AdminConsumeUserItem
# body param: body
echo '{"qty": 73, "slotId": "AT9Ji3Uy", "sourceItemId": "y14SSv3z"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op AdminConsumeUserItem \
    --inventoryId 'b5wBX5RM' \
    --namespace $AB_NAMESPACE \
    --userId 'irzJyzIR' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 21 'AdminConsumeUserItem' test.out

#- 22 AdminBulkUpdateMyItems
# body param: body
echo '[{"customAttributes": {"yDiOW4oc": {}, "n5hxFjZt": {}, "DyyQofY2": {}}, "serverCustomAttributes": {"uW3JiuBH": {}, "Sl68sOD8": {}, "0xzZhP9S": {}}, "slotId": "QxKkQm4L", "sourceItemId": "osFFbbKM", "tags": ["Arckr2uS", "bl2PpWip", "BqEbybMM"], "type": "Tj7OE1DI"}, {"customAttributes": {"aPt80Abl": {}, "HAmg7oab": {}, "4rq1OwDP": {}}, "serverCustomAttributes": {"LjZHAadk": {}, "m2vqIcw3": {}, "Puo05ql5": {}}, "slotId": "xJL9zOWN", "sourceItemId": "HpyUHDte", "tags": ["ETWE57Kd", "lIzB6jAD", "ArMBW568"], "type": "LZOYcMrT"}, {"customAttributes": {"ND9i1XZ9": {}, "5KVcYqkG": {}, "z7EoEXZi": {}}, "serverCustomAttributes": {"raI9lwjg": {}, "ztKTWbFX": {}, "IQAoBlrx": {}}, "slotId": "ELWkyBY2", "sourceItemId": "aQd46lAD", "tags": ["0vipYfhA", "FaDX6dFR", "YPnBTzZY"], "type": "TuCpUhF1"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op AdminBulkUpdateMyItems \
    --inventoryId 'vIKzNcyX' \
    --namespace $AB_NAMESPACE \
    --userId 'viXOCZfl' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 22 'AdminBulkUpdateMyItems' test.out

#- 23 AdminSaveItemToInventory
# body param: body
echo '{"customAttributes": {"uoDYEno2": {}, "UjRHVyEK": {}, "ekNvmMlu": {}}, "qty": 35, "serverCustomAttributes": {"DMcyIyQA": {}, "mPIBqH2g": {}, "FXAknG06": {}}, "slotId": "QaWeyVIg", "slotUsed": 81, "sourceItemId": "kbioJm3C", "tags": ["ne7CgfqH", "s3rLQM4U", "ege1ASxp"], "type": "HZl6TEHp"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op AdminSaveItemToInventory \
    --inventoryId 'etHKyBBk' \
    --namespace $AB_NAMESPACE \
    --userId 'zcwDIPIz' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 23 'AdminSaveItemToInventory' test.out

#- 24 AdminBulkRemoveItems
# body param: body
echo '[{"slotId": "J0xja3Uo", "sourceItemId": "xminEc80"}, {"slotId": "npJ9G2uB", "sourceItemId": "1CSH6vHU"}, {"slotId": "TywIJWa7", "sourceItemId": "VQaZJlJb"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op AdminBulkRemoveItems \
    --inventoryId 'wr6WBIEz' \
    --namespace $AB_NAMESPACE \
    --userId '9YXaaIye' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 24 'AdminBulkRemoveItems' test.out

#- 25 AdminSaveItem
# body param: body
echo '{"customAttributes": {"7FPK4RO2": {}, "kTxl8e3r": {}, "KcKTkLhG": {}}, "inventoryConfigurationCode": "drAcJs8C", "qty": 29, "serverCustomAttributes": {"F1vVdIym": {}, "4RF8OEGD": {}, "GxzHs0RO": {}}, "slotId": "9MscWmHj", "slotUsed": 30, "sourceItemId": "b5twUh81", "tags": ["nWSbmndP", "Zoz9q8A0", "TIlRngXi"], "type": "ErNmYqCY"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op AdminSaveItem \
    --namespace $AB_NAMESPACE \
    --userId 'diU0Z32f' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 25 'AdminSaveItem' test.out

#- 26 PublicListInventoryConfigurations
$CLI_EXE \
    --sn inventory \
    --op PublicListInventoryConfigurations \
    --namespace $AB_NAMESPACE \
    --code 'V2qNNck2' \
    --limit '85' \
    --offset '78' \
    --sortBy 'updatedAt:desc' \
    > test.out 2>&1
eval_tap $? 26 'PublicListInventoryConfigurations' test.out

#- 27 PublicListItemTypes
$CLI_EXE \
    --sn inventory \
    --op PublicListItemTypes \
    --namespace $AB_NAMESPACE \
    --limit '47' \
    --offset '36' \
    --sortBy 'createdAt:desc' \
    > test.out 2>&1
eval_tap $? 27 'PublicListItemTypes' test.out

#- 28 PublicListTags
$CLI_EXE \
    --sn inventory \
    --op PublicListTags \
    --namespace $AB_NAMESPACE \
    --limit '86' \
    --offset '63' \
    --sortBy 'createdAt:desc' \
    > test.out 2>&1
eval_tap $? 28 'PublicListTags' test.out

#- 29 PublicListInventories
$CLI_EXE \
    --sn inventory \
    --op PublicListInventories \
    --namespace $AB_NAMESPACE \
    --inventoryConfigurationCode 'zWqO0lB5' \
    --limit '84' \
    --offset '8' \
    --sortBy 'createdAt:asc' \
    > test.out 2>&1
eval_tap $? 29 'PublicListInventories' test.out

#- 30 PublicConsumeMyItem
# body param: body
echo '{"qty": 88, "slotId": "tygmZ06P", "sourceItemId": "SxfZFpxR"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op PublicConsumeMyItem \
    --inventoryId 'RdPN0Glv' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 30 'PublicConsumeMyItem' test.out

#- 31 PublicListItems
$CLI_EXE \
    --sn inventory \
    --op PublicListItems \
    --inventoryId 'DDmNoJgB' \
    --namespace $AB_NAMESPACE \
    --limit '44' \
    --offset '52' \
    --qtyGte '28' \
    --sortBy 'createdAt' \
    --sourceItemId 'tGYTFtBA' \
    --tags 'Tsb82lbD' \
    > test.out 2>&1
eval_tap $? 31 'PublicListItems' test.out

#- 32 PublicBulkUpdateMyItems
# body param: body
echo '[{"customAttributes": {"8JzW9Hzn": {}, "0ZYzJOoU": {}, "4qLuwc1E": {}}, "slotId": "HdSuqfYQ", "sourceItemId": "k3mg6n62", "tags": ["PxZDY2lx", "4fpZFxZ2", "iL9zUrIH"]}, {"customAttributes": {"kYBfmZUX": {}, "TsgqXF3t": {}, "ZXfFgFQP": {}}, "slotId": "CS3fWX5H", "sourceItemId": "dZQyyYgu", "tags": ["r4nwKU74", "UdeDEGVk", "u82IPusM"]}, {"customAttributes": {"xVI9eJrP": {}, "CCcvJphU": {}, "zKomwsuP": {}}, "slotId": "85KZcSzA", "sourceItemId": "PvX2x1zl", "tags": ["01faqrEw", "4eRPW6l3", "vQpRjaEZ"]}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op PublicBulkUpdateMyItems \
    --inventoryId 'SjQ8IUyr' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 32 'PublicBulkUpdateMyItems' test.out

#- 33 PublicBulkRemoveMyItems
# body param: body
echo '[{"slotId": "kmdBYdeB", "sourceItemId": "rVXGXeNY"}, {"slotId": "9XaFXXfb", "sourceItemId": "pBL7XkEq"}, {"slotId": "7oaazpeu", "sourceItemId": "slOHNlvY"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op PublicBulkRemoveMyItems \
    --inventoryId 'hdNQGs7d' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 33 'PublicBulkRemoveMyItems' test.out

#- 34 PublicMoveMyItems
# body param: body
echo '{"items": [{"qty": 89, "slotId": "Vn14mTcM", "sourceItemId": "MQAss9Di"}, {"qty": 46, "slotId": "rmAULyp7", "sourceItemId": "Qdqd0ibh"}, {"qty": 0, "slotId": "33JHIKUk", "sourceItemId": "qqHN1Q58"}], "srcInventoryId": "tOidCfrK"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn inventory \
    --op PublicMoveMyItems \
    --inventoryId 'aCtULEWm' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 34 'PublicMoveMyItems' test.out

#- 35 PublicGetItem
$CLI_EXE \
    --sn inventory \
    --op PublicGetItem \
    --inventoryId 'cbKFztrz' \
    --namespace $AB_NAMESPACE \
    --slotId 'RC1BJxlE' \
    --sourceItemId '0J8RbfwD' \
    > test.out 2>&1
eval_tap $? 35 'PublicGetItem' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE