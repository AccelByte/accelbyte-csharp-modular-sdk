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
echo "1..99"

#- 1 Login
$CLI_EXE --op login --lt user --user user --pass user > test.out 2>&1
eval_tap $? 1 'Login' test.out

if [ $EXIT_CODE -ne 0 ]; then
  echo "Bail out! Login failed."
  exit $EXIT_CODE
fi

# echo "foo" > "$CLI_TOKEN_FILE"

#- 2 GetNamespaceSlotConfig
eval_tap 0 2 'GetNamespaceSlotConfig # SKIP deprecated' test.out

#- 3 UpdateNamespaceSlotConfig
eval_tap 0 3 'UpdateNamespaceSlotConfig # SKIP deprecated' test.out

#- 4 DeleteNamespaceSlotConfig
eval_tap 0 4 'DeleteNamespaceSlotConfig # SKIP deprecated' test.out

#- 5 GetUserSlotConfig
eval_tap 0 5 'GetUserSlotConfig # SKIP deprecated' test.out

#- 6 UpdateUserSlotConfig
eval_tap 0 6 'UpdateUserSlotConfig # SKIP deprecated' test.out

#- 7 DeleteUserSlotConfig
eval_tap 0 7 'DeleteUserSlotConfig # SKIP deprecated' test.out

#- 8 GetUserProfiles
$CLI_EXE \
    --sn social \
    --op GetUserProfiles \
    --namespace $AB_NAMESPACE \
    --userId 'ui3nk617' \
    > test.out 2>&1
eval_tap $? 8 'GetUserProfiles' test.out

#- 9 GetProfile
$CLI_EXE \
    --sn social \
    --op GetProfile \
    --namespace $AB_NAMESPACE \
    --profileId 'u3RsuUPY' \
    --userId 'xCEiStMa' \
    > test.out 2>&1
eval_tap $? 9 'GetProfile' test.out

#- 10 GetUserNamespaceSlots
eval_tap 0 10 'GetUserNamespaceSlots # SKIP deprecated' test.out

#- 11 GetSlotData
eval_tap 0 11 'GetSlotData # SKIP deprecated' test.out

#- 12 PublicGetUserGameProfiles
$CLI_EXE \
    --sn social \
    --op PublicGetUserGameProfiles \
    --namespace $AB_NAMESPACE \
    --userIds '["Voo0qswF", "xc62TV2H", "JTGLr1g6"]' \
    > test.out 2>&1
eval_tap $? 12 'PublicGetUserGameProfiles' test.out

#- 13 PublicGetUserProfiles
$CLI_EXE \
    --sn social \
    --op PublicGetUserProfiles \
    --namespace $AB_NAMESPACE \
    --userId 'v1iqgnPx' \
    > test.out 2>&1
eval_tap $? 13 'PublicGetUserProfiles' test.out

#- 14 PublicCreateProfile
# body param: body
echo '{"achievements": ["yPHB1Igm", "XF8BK9qd", "bE05cmE9"], "attributes": {"kkWD6RrK": "0xmfGcVu", "Y9WeXoZ4": "4uklJkaj", "ao4VHG8I": "PlwCfo4o"}, "avatarUrl": "Vv2X4YPO", "inventories": ["QXQxbjgO", "MvdAXUFF", "mXF5gJss"], "label": "QlricgnT", "profileName": "ttukKZSL", "statistics": ["S1S2VOd6", "EYfcWRI5", "Xf8IbI2E"], "tags": ["cXnqG1oG", "9sii0UGt", "UXxLnduT"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicCreateProfile \
    --namespace $AB_NAMESPACE \
    --userId 'EK4TxORv' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 14 'PublicCreateProfile' test.out

#- 15 PublicGetProfile
$CLI_EXE \
    --sn social \
    --op PublicGetProfile \
    --namespace $AB_NAMESPACE \
    --profileId 'ODlcLiMC' \
    --userId 'jEjW1iR0' \
    > test.out 2>&1
eval_tap $? 15 'PublicGetProfile' test.out

#- 16 PublicUpdateProfile
# body param: body
echo '{"achievements": ["0VsiGO61", "ujIXh7jb", "YBd9ogHH"], "attributes": {"D6Mw9GGV": "4ekfOJC5", "qJ7FxcmM": "GawX53Zh", "hXWemf9Z": "oKNKmpjL"}, "avatarUrl": "M5wlfTSV", "inventories": ["nooGCgis", "AD0Z2pxj", "zJxLCqLs"], "label": "QoZVls6e", "profileName": "jPqHk7wt", "statistics": ["D4KPB6lG", "D3kLZNeY", "mu6bhB3Z"], "tags": ["YuN4Vo61", "ZQ1U4lHp", "2KwIr1OD"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicUpdateProfile \
    --namespace $AB_NAMESPACE \
    --profileId 'jJVeRabE' \
    --userId 'jNK8z57B' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 16 'PublicUpdateProfile' test.out

#- 17 PublicDeleteProfile
$CLI_EXE \
    --sn social \
    --op PublicDeleteProfile \
    --namespace $AB_NAMESPACE \
    --profileId 'SSdODJwY' \
    --userId 'oQbYQUCn' \
    > test.out 2>&1
eval_tap $? 17 'PublicDeleteProfile' test.out

#- 18 PublicGetProfileAttribute
$CLI_EXE \
    --sn social \
    --op PublicGetProfileAttribute \
    --attributeName 'C8EWewV0' \
    --namespace $AB_NAMESPACE \
    --profileId '7bZf5nOY' \
    --userId 'n9aRXTTI' \
    > test.out 2>&1
eval_tap $? 18 'PublicGetProfileAttribute' test.out

#- 19 PublicUpdateAttribute
# body param: body
echo '{"name": "VLE1AnP7", "value": "zRwm5QEQ"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicUpdateAttribute \
    --attributeName 'nfaF7Ubt' \
    --namespace $AB_NAMESPACE \
    --profileId 'VF6tjE0y' \
    --userId 'TnFb46Dl' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 19 'PublicUpdateAttribute' test.out

#- 20 PublicGetUserNamespaceSlots
eval_tap 0 20 'PublicGetUserNamespaceSlots # SKIP deprecated' test.out

#- 21 PublicCreateUserNamespaceSlot
eval_tap 0 21 'PublicCreateUserNamespaceSlot # SKIP deprecated' test.out

#- 22 PublicGetSlotData
eval_tap 0 22 'PublicGetSlotData # SKIP deprecated' test.out

#- 23 PublicUpdateUserNamespaceSlot
eval_tap 0 23 'PublicUpdateUserNamespaceSlot # SKIP deprecated' test.out

#- 24 PublicDeleteUserNamespaceSlot
eval_tap 0 24 'PublicDeleteUserNamespaceSlot # SKIP deprecated' test.out

#- 25 PublicUpdateUserNamespaceSlotMetadata
eval_tap 0 25 'PublicUpdateUserNamespaceSlotMetadata # SKIP deprecated' test.out

#- 26 GetGlobalStatItems
$CLI_EXE \
    --sn social \
    --op GetGlobalStatItems \
    --namespace $AB_NAMESPACE \
    --limit '12' \
    --offset '55' \
    --statCodes '1mUouUBY' \
    > test.out 2>&1
eval_tap $? 26 'GetGlobalStatItems' test.out

#- 27 GetGlobalStatItemByStatCode
$CLI_EXE \
    --sn social \
    --op GetGlobalStatItemByStatCode \
    --namespace $AB_NAMESPACE \
    --statCode 'UuK8XQqE' \
    > test.out 2>&1
eval_tap $? 27 'GetGlobalStatItemByStatCode' test.out

#- 28 GetStatCycles
$CLI_EXE \
    --sn social \
    --op GetStatCycles \
    --namespace $AB_NAMESPACE \
    --cycleType 'WEEKLY' \
    --limit '37' \
    --name 'eXseixQ4' \
    --offset '73' \
    --sortBy 'NWcPDTGi' \
    --status 'INIT' \
    > test.out 2>&1
eval_tap $? 28 'GetStatCycles' test.out

#- 29 CreateStatCycle
# body param: body
echo '{"cycleType": "WEEKLY", "description": "7EM6N5cR", "end": "1977-07-26T00:00:00Z", "id": "X0hciY2y", "name": "L3IGbjCr", "resetDate": 24, "resetDay": 60, "resetMonth": 49, "resetTime": "aCWOTKeX", "seasonPeriod": 92, "start": "1999-04-26T00:00:00Z"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op CreateStatCycle \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 29 'CreateStatCycle' test.out

#- 30 BulkGetStatCycle
# body param: body
echo '{"cycleIds": ["7CUKQEXz", "qWMKt0Zf", "24hOsjmT"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkGetStatCycle \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 30 'BulkGetStatCycle' test.out

#- 31 ExportStatCycle
$CLI_EXE \
    --sn social \
    --op ExportStatCycle \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 31 'ExportStatCycle' test.out

#- 32 ImportStatCycle
# form data upload: file
echo 'tmp.dat' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --sn social \
    --op ImportStatCycle \
    --namespace $AB_NAMESPACE \
    --replaceExisting 'false' \
    --upload file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 32 'ImportStatCycle' test.out

#- 33 GetStatCycle
$CLI_EXE \
    --sn social \
    --op GetStatCycle \
    --cycleId '6fFnHScg' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 33 'GetStatCycle' test.out

#- 34 UpdateStatCycle
# body param: body
echo '{"cycleType": "SEASONAL", "description": "qYCY1uHy", "end": "1990-03-31T00:00:00Z", "name": "okUQBtMc", "resetDate": 78, "resetDay": 35, "resetMonth": 31, "resetTime": "G8geUmm2", "seasonPeriod": 1, "start": "1973-07-19T00:00:00Z"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op UpdateStatCycle \
    --cycleId 'OvHmXs1Z' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 34 'UpdateStatCycle' test.out

#- 35 DeleteStatCycle
$CLI_EXE \
    --sn social \
    --op DeleteStatCycle \
    --cycleId '8ncJLQIy' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 35 'DeleteStatCycle' test.out

#- 36 BulkAddStats
# body param: body
echo '{"statCodes": ["pan9nb3a", "HIeK7D8g", "5GtaeZgp"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkAddStats \
    --cycleId '4TTkYm09' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 36 'BulkAddStats' test.out

#- 37 StopStatCycle
$CLI_EXE \
    --sn social \
    --op StopStatCycle \
    --cycleId 'nCLSs8go' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 37 'StopStatCycle' test.out

#- 38 BulkFetchStatItems
$CLI_EXE \
    --sn social \
    --op BulkFetchStatItems \
    --namespace $AB_NAMESPACE \
    --statCode 'ZRRcbS5C' \
    --userIds 'lKM7hCbH' \
    > test.out 2>&1
eval_tap $? 38 'BulkFetchStatItems' test.out

#- 39 BulkIncUserStatItem
# body param: body
echo '[{"inc": 0.7720421402062466, "statCode": "f1kOkCM5", "userId": "jN489Ruu"}, {"inc": 0.4250203037465702, "statCode": "iyL4Ifj4", "userId": "WOjF2q0l"}, {"inc": 0.5624089548200679, "statCode": "dA0hXw9y", "userId": "llNmsidT"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkIncUserStatItem \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 39 'BulkIncUserStatItem' test.out

#- 40 BulkIncUserStatItemValue
# body param: body
echo '[{"inc": 0.6482259999285255, "statCode": "0BhF4MHT", "userId": "gbpA7bPL"}, {"inc": 0.674712189700734, "statCode": "5CBcFKTN", "userId": "tSpE0cqi"}, {"inc": 0.6223943439239638, "statCode": "32df9fc1", "userId": "ryOCgqtr"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkIncUserStatItemValue \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 40 'BulkIncUserStatItemValue' test.out

#- 41 BulkFetchOrDefaultStatItems
$CLI_EXE \
    --sn social \
    --op BulkFetchOrDefaultStatItems \
    --namespace $AB_NAMESPACE \
    --statCode 'ykrmDuC8' \
    --userIds '["xTeRv7GQ", "0Jutb6hu", "Qg5Al7XH"]' \
    > test.out 2>&1
eval_tap $? 41 'BulkFetchOrDefaultStatItems' test.out

#- 42 BulkResetUserStatItem
# body param: body
echo '[{"statCode": "LALZfp6H", "userId": "AtDbc3t5"}, {"statCode": "Lv6DSk5U", "userId": "pi5g9bYO"}, {"statCode": "gVukNs9H", "userId": "C3X1C5tw"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkResetUserStatItem \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 42 'BulkResetUserStatItem' test.out

#- 43 GetStats
$CLI_EXE \
    --sn social \
    --op GetStats \
    --namespace $AB_NAMESPACE \
    --cycleIds '1CA1GLNv' \
    --isGlobal 'false' \
    --isPublic 'false' \
    --limit '25' \
    --offset '32' \
    > test.out 2>&1
eval_tap $? 43 'GetStats' test.out

#- 44 CreateStat
# body param: body
echo '{"cycleIds": ["fyaDna0f", "Sz5Vamnq", "wbY0z6nN"], "defaultValue": 0.16279537545999012, "description": "CEDDg7mn", "globalAggregationMethod": "TOTAL", "ignoreAdditionalDataOnValueRejected": true, "incrementOnly": true, "isPublic": false, "maximum": 0.5910839113399725, "minimum": 0.7299149980552877, "name": "rsMeu692", "setAsGlobal": true, "setBy": "SERVER", "statCode": "StA8BV4r", "tags": ["n1GkONSU", "dNh9kyeL", "z6v1HKKq"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op CreateStat \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 44 'CreateStat' test.out

#- 45 ExportStats
$CLI_EXE \
    --sn social \
    --op ExportStats \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 45 'ExportStats' test.out

#- 46 ImportStats
# form data upload: file
echo 'tmp.dat' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --sn social \
    --op ImportStats \
    --namespace $AB_NAMESPACE \
    --replaceExisting 'true' \
    --upload file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 46 'ImportStats' test.out

#- 47 QueryStats
$CLI_EXE \
    --sn social \
    --op QueryStats \
    --namespace $AB_NAMESPACE \
    --isGlobal 'false' \
    --isPublic 'false' \
    --limit '39' \
    --offset '57' \
    --keyword 'sZF1zaQi' \
    > test.out 2>&1
eval_tap $? 47 'QueryStats' test.out

#- 48 GetStat
$CLI_EXE \
    --sn social \
    --op GetStat \
    --namespace $AB_NAMESPACE \
    --statCode 'uamU5LXu' \
    > test.out 2>&1
eval_tap $? 48 'GetStat' test.out

#- 49 DeleteStat
$CLI_EXE \
    --sn social \
    --op DeleteStat \
    --namespace $AB_NAMESPACE \
    --statCode 'mh61Gdj0' \
    > test.out 2>&1
eval_tap $? 49 'DeleteStat' test.out

#- 50 UpdateStat
# body param: body
echo '{"cycleIds": ["MMT6bxfa", "0JPhBu9f", "tUk9cfqJ"], "defaultValue": 0.934680685914816, "description": "n2bdZ91u", "globalAggregationMethod": "TOTAL", "ignoreAdditionalDataOnValueRejected": false, "isPublic": true, "name": "iQeTnO8F", "tags": ["ip3raK2O", "bXjgIvhB", "MLiCGSK9"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op UpdateStat \
    --namespace $AB_NAMESPACE \
    --statCode 'HggqSba6' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 50 'UpdateStat' test.out

#- 51 GetStatItems
$CLI_EXE \
    --sn social \
    --op GetStatItems \
    --namespace $AB_NAMESPACE \
    --statCode '1KUMB6D0' \
    --limit '40' \
    --offset '37' \
    --sortBy '9bD6Vv1D' \
    > test.out 2>&1
eval_tap $? 51 'GetStatItems' test.out

#- 52 DeleteTiedStat
$CLI_EXE \
    --sn social \
    --op DeleteTiedStat \
    --namespace $AB_NAMESPACE \
    --statCode 'CU5aBJD9' \
    > test.out 2>&1
eval_tap $? 52 'DeleteTiedStat' test.out

#- 53 GetUserStatCycleItems
$CLI_EXE \
    --sn social \
    --op GetUserStatCycleItems \
    --cycleId 'OH28hCvK' \
    --namespace $AB_NAMESPACE \
    --userId 'khN18eav' \
    --isPublic 'true' \
    --limit '21' \
    --offset '56' \
    --sortBy 'U6z7UZcp' \
    --statCodes 'Mtm1cETE' \
    > test.out 2>&1
eval_tap $? 53 'GetUserStatCycleItems' test.out

#- 54 GetUserStatItems
$CLI_EXE \
    --sn social \
    --op GetUserStatItems \
    --namespace $AB_NAMESPACE \
    --userId 'HNc1nEK1' \
    --isPublic 'false' \
    --limit '3' \
    --offset '62' \
    --sortBy 'LrffSrjp' \
    --statCodes 'SFVkv6td' \
    --tags 'ZhYcJnbc' \
    > test.out 2>&1
eval_tap $? 54 'GetUserStatItems' test.out

#- 55 BulkCreateUserStatItems
# body param: body
echo '[{"statCode": "djxM4Ic8"}, {"statCode": "yRv7jAMj"}, {"statCode": "RangkPUL"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkCreateUserStatItems \
    --namespace $AB_NAMESPACE \
    --userId 'Sg8FvDKu' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 55 'BulkCreateUserStatItems' test.out

#- 56 BulkIncUserStatItem1
# body param: body
echo '[{"inc": 0.5700037045843964, "statCode": "ISmpAjiu"}, {"inc": 0.42346399106734367, "statCode": "73oKk1Ee"}, {"inc": 0.9149243050407394, "statCode": "fF0z3869"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkIncUserStatItem1 \
    --namespace $AB_NAMESPACE \
    --userId 'H2C6F9D6' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 56 'BulkIncUserStatItem1' test.out

#- 57 BulkIncUserStatItemValue1
# body param: body
echo '[{"inc": 0.8795192787095539, "statCode": "lBQcRnK4"}, {"inc": 0.5101387161856336, "statCode": "Mktv9Ztb"}, {"inc": 0.5284589549863196, "statCode": "aHungrzE"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkIncUserStatItemValue1 \
    --namespace $AB_NAMESPACE \
    --userId 'KZnFwRDW' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 57 'BulkIncUserStatItemValue1' test.out

#- 58 BulkResetUserStatItem1
# body param: body
echo '[{"statCode": "E11QJEvz"}, {"statCode": "EosqV1eG"}, {"statCode": "2zHZm1ZA"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkResetUserStatItem1 \
    --namespace $AB_NAMESPACE \
    --userId 'Tz3hXRt1' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 58 'BulkResetUserStatItem1' test.out

#- 59 CreateUserStatItem
$CLI_EXE \
    --sn social \
    --op CreateUserStatItem \
    --namespace $AB_NAMESPACE \
    --statCode 't0o5UmCo' \
    --userId 'lEUsio5t' \
    > test.out 2>&1
eval_tap $? 59 'CreateUserStatItem' test.out

#- 60 DeleteUserStatItems
$CLI_EXE \
    --sn social \
    --op DeleteUserStatItems \
    --namespace $AB_NAMESPACE \
    --statCode 'THDNHCPq' \
    --userId 'ZlRB7YEU' \
    > test.out 2>&1
eval_tap $? 60 'DeleteUserStatItems' test.out

#- 61 IncUserStatItemValue
# body param: body
echo '{"inc": 0.9715595644470265}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op IncUserStatItemValue \
    --namespace $AB_NAMESPACE \
    --statCode 'EwV83HBh' \
    --userId 'NbgkZCiv' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 61 'IncUserStatItemValue' test.out

#- 62 ResetUserStatItemValue
# body param: body
echo '{"additionalData": {"MlsvWq96": {}, "x2XgDgwg": {}, "sKynaS7o": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op ResetUserStatItemValue \
    --namespace $AB_NAMESPACE \
    --statCode '9jLKwVVA' \
    --userId '2p2ho1JC' \
    --additionalKey 'CUpSkV8S' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 62 'ResetUserStatItemValue' test.out

#- 63 GetGlobalStatItems1
$CLI_EXE \
    --sn social \
    --op GetGlobalStatItems1 \
    --namespace $AB_NAMESPACE \
    --limit '75' \
    --offset '95' \
    --statCodes 'kAU05bU4' \
    > test.out 2>&1
eval_tap $? 63 'GetGlobalStatItems1' test.out

#- 64 GetGlobalStatItemByStatCode1
$CLI_EXE \
    --sn social \
    --op GetGlobalStatItemByStatCode1 \
    --namespace $AB_NAMESPACE \
    --statCode 'iMbOqZIs' \
    > test.out 2>&1
eval_tap $? 64 'GetGlobalStatItemByStatCode1' test.out

#- 65 GetStatCycles1
$CLI_EXE \
    --sn social \
    --op GetStatCycles1 \
    --namespace $AB_NAMESPACE \
    --cycleType 'WEEKLY' \
    --limit '45' \
    --name 'iu3lvple' \
    --offset '30' \
    --sortBy 'Tparjnz9' \
    --status 'INIT' \
    > test.out 2>&1
eval_tap $? 65 'GetStatCycles1' test.out

#- 66 BulkGetStatCycle1
# body param: body
echo '{"cycleIds": ["ePXNQRuN", "Zzpjm7ZN", "TSDXh4jp"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkGetStatCycle1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 66 'BulkGetStatCycle1' test.out

#- 67 GetStatCycle1
$CLI_EXE \
    --sn social \
    --op GetStatCycle1 \
    --cycleId 'upy5WMaN' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 67 'GetStatCycle1' test.out

#- 68 BulkFetchStatItems1
$CLI_EXE \
    --sn social \
    --op BulkFetchStatItems1 \
    --namespace $AB_NAMESPACE \
    --statCode '6X3Nu2BV' \
    --userIds 'mUowbRmz' \
    > test.out 2>&1
eval_tap $? 68 'BulkFetchStatItems1' test.out

#- 69 PublicBulkIncUserStatItem
# body param: body
echo '[{"inc": 0.5830200943217954, "statCode": "iEopxXBn", "userId": "7fcAcREl"}, {"inc": 0.9230483007401018, "statCode": "TVMCMpFI", "userId": "A3h03WkJ"}, {"inc": 0.29257560765213275, "statCode": "7ppBb288", "userId": "iaOo6y9C"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicBulkIncUserStatItem \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 69 'PublicBulkIncUserStatItem' test.out

#- 70 PublicBulkIncUserStatItemValue
# body param: body
echo '[{"inc": 0.6864864131022533, "statCode": "QHfnC2CO", "userId": "3PZbDQoE"}, {"inc": 0.8845664414098972, "statCode": "LZ7hPWxN", "userId": "jElROSy0"}, {"inc": 0.22920590577431665, "statCode": "tkkCLTFT", "userId": "5tMn1lih"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicBulkIncUserStatItemValue \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 70 'PublicBulkIncUserStatItemValue' test.out

#- 71 BulkResetUserStatItem2
# body param: body
echo '[{"statCode": "qsww3ezP", "userId": "2oYgHx4G"}, {"statCode": "NPjDcCIO", "userId": "x6jRhRSF"}, {"statCode": "EJ3xm0jv", "userId": "bhE64VJw"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkResetUserStatItem2 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 71 'BulkResetUserStatItem2' test.out

#- 72 CreateStat1
# body param: body
echo '{"cycleIds": ["9XkufyjM", "Par70biw", "GOuHK1MF"], "defaultValue": 0.16330683709403315, "description": "CHRm7z7x", "globalAggregationMethod": "TOTAL", "ignoreAdditionalDataOnValueRejected": false, "incrementOnly": true, "isPublic": false, "maximum": 0.2076751110341678, "minimum": 0.08148098550883809, "name": "h85ZpdEh", "setAsGlobal": false, "setBy": "CLIENT", "statCode": "0HfxPNp8", "tags": ["qQ0JZTJb", "0pt1Y1V2", "KPIn0bXV"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op CreateStat1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 72 'CreateStat1' test.out

#- 73 PublicListMyStatCycleItems
$CLI_EXE \
    --sn social \
    --op PublicListMyStatCycleItems \
    --cycleId '61j6e2Qb' \
    --namespace $AB_NAMESPACE \
    --limit '100' \
    --offset '9' \
    --sortBy 'HM3r5d8X' \
    --statCodes '["9H6L1Si1", "jsBav6Xa", "grU0ibFl"]' \
    > test.out 2>&1
eval_tap $? 73 'PublicListMyStatCycleItems' test.out

#- 74 PublicListMyStatItems
$CLI_EXE \
    --sn social \
    --op PublicListMyStatItems \
    --namespace $AB_NAMESPACE \
    --limit '87' \
    --offset '41' \
    --sortBy 'fCTAsnNq' \
    --statCodes '["08CYGvQ7", "TJFIdy9l", "zY2yh9vy"]' \
    --tags '["LGvO1tkv", "3lV9SXAW", "cilddW0g"]' \
    > test.out 2>&1
eval_tap $? 74 'PublicListMyStatItems' test.out

#- 75 PublicListAllMyStatItems
$CLI_EXE \
    --sn social \
    --op PublicListAllMyStatItems \
    --namespace $AB_NAMESPACE \
    --additionalKey 'sVWgfdT8' \
    --statCodes '["bqTzYaR2", "uQpCWWN5", "Riy0PGDj"]' \
    --tags '["yEw1C0OL", "vI4dPbHZ", "LSTlehKn"]' \
    > test.out 2>&1
eval_tap $? 75 'PublicListAllMyStatItems' test.out

#- 76 GetUserStatCycleItems1
$CLI_EXE \
    --sn social \
    --op GetUserStatCycleItems1 \
    --cycleId 'AMGHMXuu' \
    --namespace $AB_NAMESPACE \
    --userId 'XNb75Y61' \
    --limit '63' \
    --offset '7' \
    --sortBy 'Wj1t486P' \
    --statCodes 'p8JGVqcE' \
    > test.out 2>&1
eval_tap $? 76 'GetUserStatCycleItems1' test.out

#- 77 PublicQueryUserStatItems
$CLI_EXE \
    --sn social \
    --op PublicQueryUserStatItems \
    --namespace $AB_NAMESPACE \
    --userId 'f81r1sWx' \
    --limit '65' \
    --offset '45' \
    --sortBy 'CTPmrzXO' \
    --statCodes 'GaC5iA55' \
    --tags '9wfgDsGI' \
    > test.out 2>&1
eval_tap $? 77 'PublicQueryUserStatItems' test.out

#- 78 PublicBulkCreateUserStatItems
# body param: body
echo '[{"statCode": "kejasa9F"}, {"statCode": "bt95zVoR"}, {"statCode": "njFsZMBm"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicBulkCreateUserStatItems \
    --namespace $AB_NAMESPACE \
    --userId 'oKC9m3kc' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 78 'PublicBulkCreateUserStatItems' test.out

#- 79 PublicQueryUserStatItems1
$CLI_EXE \
    --sn social \
    --op PublicQueryUserStatItems1 \
    --namespace $AB_NAMESPACE \
    --userId 'PDWnnH22' \
    --additionalKey 'ebVYpD5h' \
    --statCodes '["LMqeskJt", "bcHab3l0", "NX9jzN3V"]' \
    --tags '["KJ3Nos35", "vL9bpasm", "n5b8jmdf"]' \
    > test.out 2>&1
eval_tap $? 79 'PublicQueryUserStatItems1' test.out

#- 80 PublicBulkIncUserStatItem1
# body param: body
echo '[{"inc": 0.9172525043600595, "statCode": "WR9sPgdT"}, {"inc": 0.7152507003499614, "statCode": "aJZICoIc"}, {"inc": 0.8685729409161601, "statCode": "hXWQ2G6B"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicBulkIncUserStatItem1 \
    --namespace $AB_NAMESPACE \
    --userId 'AG5R2fp5' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 80 'PublicBulkIncUserStatItem1' test.out

#- 81 BulkIncUserStatItemValue2
# body param: body
echo '[{"inc": 0.39773166548476635, "statCode": "cXBhN8jD"}, {"inc": 0.6096096541975675, "statCode": "p0NQpezR"}, {"inc": 0.9082896223302335, "statCode": "rUR8a8uy"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkIncUserStatItemValue2 \
    --namespace $AB_NAMESPACE \
    --userId 'qsulgx4H' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 81 'BulkIncUserStatItemValue2' test.out

#- 82 BulkResetUserStatItem3
# body param: body
echo '[{"statCode": "rywnS29X"}, {"statCode": "RNb2B6Us"}, {"statCode": "zigtXMWj"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkResetUserStatItem3 \
    --namespace $AB_NAMESPACE \
    --userId 'KWMh4w9z' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 82 'BulkResetUserStatItem3' test.out

#- 83 PublicCreateUserStatItem
$CLI_EXE \
    --sn social \
    --op PublicCreateUserStatItem \
    --namespace $AB_NAMESPACE \
    --statCode 'ztjGjpep' \
    --userId 'N5XnRZDH' \
    > test.out 2>&1
eval_tap $? 83 'PublicCreateUserStatItem' test.out

#- 84 DeleteUserStatItems1
$CLI_EXE \
    --sn social \
    --op DeleteUserStatItems1 \
    --namespace $AB_NAMESPACE \
    --statCode 'kf1Jbfuo' \
    --userId 'SHyRrbv7' \
    > test.out 2>&1
eval_tap $? 84 'DeleteUserStatItems1' test.out

#- 85 PublicIncUserStatItem
# body param: body
echo '{"inc": 0.47380366462897716}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicIncUserStatItem \
    --namespace $AB_NAMESPACE \
    --statCode 'HGOoDbuw' \
    --userId 'k2feDSJG' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 85 'PublicIncUserStatItem' test.out

#- 86 PublicIncUserStatItemValue
# body param: body
echo '{"inc": 0.567161275977556}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicIncUserStatItemValue \
    --namespace $AB_NAMESPACE \
    --statCode 'WMnAskiA' \
    --userId 'Nke5HBiP' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 86 'PublicIncUserStatItemValue' test.out

#- 87 ResetUserStatItemValue1
$CLI_EXE \
    --sn social \
    --op ResetUserStatItemValue1 \
    --namespace $AB_NAMESPACE \
    --statCode 'tQ8adlPv' \
    --userId 'eukVdw8P' \
    > test.out 2>&1
eval_tap $? 87 'ResetUserStatItemValue1' test.out

#- 88 BulkUpdateUserStatItemV2
# body param: body
echo '[{"additionalData": {"3FUma2KW": {}, "SU1CIAWl": {}, "lMuUSbuC": {}}, "additionalKey": "gd3qXB0i", "statCode": "XUgT7LE2", "updateStrategy": "MIN", "userId": "S80LvFW8", "value": 0.16150293966212748}, {"additionalData": {"4u2N1wev": {}, "vwmhQxf7": {}, "nufgwd6A": {}}, "additionalKey": "RV4CWpds", "statCode": "8iVsYpeh", "updateStrategy": "OVERRIDE", "userId": "HwGkS81U", "value": 0.8302647312226052}, {"additionalData": {"r2PIJNnL": {}, "nYMPicnj": {}, "dTH6TkJQ": {}}, "additionalKey": "TKeSI7fL", "statCode": "enqMopZS", "updateStrategy": "MIN", "userId": "h5zu1iMc", "value": 0.379844499347999}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkUpdateUserStatItemV2 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 88 'BulkUpdateUserStatItemV2' test.out

#- 89 BulkFetchOrDefaultStatItems1
$CLI_EXE \
    --sn social \
    --op BulkFetchOrDefaultStatItems1 \
    --namespace $AB_NAMESPACE \
    --additionalKey 'fHtbsBdf' \
    --statCode 'XERbHJwr' \
    --userIds '["vl0etQBy", "WkYDgbIw", "LmELfQnl"]' \
    > test.out 2>&1
eval_tap $? 89 'BulkFetchOrDefaultStatItems1' test.out

#- 90 AdminListUsersStatItems
$CLI_EXE \
    --sn social \
    --op AdminListUsersStatItems \
    --namespace $AB_NAMESPACE \
    --userId 'Y5vpzfKv' \
    --additionalKey 'hufMDWRW' \
    --statCodes '["qs8BBiQs", "QcrIsPPJ", "drw5EE6l"]' \
    --tags '["KXYqSHYd", "6QrOwouR", "97ECHhvX"]' \
    > test.out 2>&1
eval_tap $? 90 'AdminListUsersStatItems' test.out

#- 91 BulkUpdateUserStatItem
# body param: body
echo '[{"additionalData": {"kTFjctdq": {}, "nJP0T6mH": {}, "qsopcTPp": {}}, "statCode": "tkUJsezj", "updateStrategy": "INCREMENT", "value": 0.8764510160442525}, {"additionalData": {"mNMo4YSy": {}, "brIJF1T4": {}, "jGbEjGrR": {}}, "statCode": "1wLgfREz", "updateStrategy": "MAX", "value": 0.08846075459453273}, {"additionalData": {"wrHhtDrV": {}, "54CrFBIB": {}, "ImHIi2B2": {}}, "statCode": "eoPU5R58", "updateStrategy": "MIN", "value": 0.07005510843202023}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkUpdateUserStatItem \
    --namespace $AB_NAMESPACE \
    --userId 'BSdPKNkw' \
    --additionalKey 'BnCSXoBU' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 91 'BulkUpdateUserStatItem' test.out

#- 92 BulkGetOrDefaultByUserId
# body param: body
echo '{"statCodes": ["bjafVk0R", "CNPB5CTy", "PrkXXX0M"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkGetOrDefaultByUserId \
    --namespace $AB_NAMESPACE \
    --userId 'zVxqztBC' \
    --additionalKey 'N015OXUi' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 92 'BulkGetOrDefaultByUserId' test.out

#- 93 BulkResetUserStatItemValues
# body param: body
echo '[{"additionalData": {"zanwHnjZ": {}, "PY3ahWGs": {}, "kWWbXy7z": {}}, "statCode": "e7u8IjAe"}, {"additionalData": {"J95WASjz": {}, "wPg4sXIS": {}, "35x3Z1Pp": {}}, "statCode": "RNHZ5dHz"}, {"additionalData": {"Kui6Lr4q": {}, "uMubWRhD": {}, "JDaeRu6P": {}}, "statCode": "C07lmmIa"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkResetUserStatItemValues \
    --namespace $AB_NAMESPACE \
    --userId '4aoIqQU3' \
    --additionalKey 'FELT7KnP' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 93 'BulkResetUserStatItemValues' test.out

#- 94 DeleteUserStatItems2
$CLI_EXE \
    --sn social \
    --op DeleteUserStatItems2 \
    --namespace $AB_NAMESPACE \
    --statCode 'MVgZWDGg' \
    --userId '1J7yvpwN' \
    --additionalKey 'ydaj5zFM' \
    > test.out 2>&1
eval_tap $? 94 'DeleteUserStatItems2' test.out

#- 95 UpdateUserStatItemValue
# body param: body
echo '{"additionalData": {"nIV7aOEi": {}, "xaQsEUbU": {}, "9UYVWLz8": {}}, "updateStrategy": "OVERRIDE", "value": 0.3972709159548371}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op UpdateUserStatItemValue \
    --namespace $AB_NAMESPACE \
    --statCode 'siK7rOBY' \
    --userId 'fupcYiN2' \
    --additionalKey 'R6z4Vq4j' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 95 'UpdateUserStatItemValue' test.out

#- 96 BulkUpdateUserStatItem1
# body param: body
echo '[{"additionalData": {"di9epEvM": {}, "jrOSfN0P": {}, "xdQ2S8rK": {}}, "additionalKey": "4SHSRydu", "statCode": "1NNqtRWM", "updateStrategy": "MAX", "userId": "wDdRrs6v", "value": 0.36443466491007703}, {"additionalData": {"nchlbBNH": {}, "XbwYUA1K": {}, "aZKJiN7l": {}}, "additionalKey": "mT9mFM5x", "statCode": "RTwFNJk2", "updateStrategy": "INCREMENT", "userId": "OPjwbxUU", "value": 0.5054701744462731}, {"additionalData": {"73nS1NJ4": {}, "UYGnyZV9": {}, "T0iZGezx": {}}, "additionalKey": "zOyXKj1w", "statCode": "DLrTyAuU", "updateStrategy": "MAX", "userId": "zWqvqsKk", "value": 0.33212775699670927}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkUpdateUserStatItem1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 96 'BulkUpdateUserStatItem1' test.out

#- 97 PublicQueryUserStatItems2
$CLI_EXE \
    --sn social \
    --op PublicQueryUserStatItems2 \
    --namespace $AB_NAMESPACE \
    --userId 'sAk9sYQF' \
    --additionalKey '7IzZ6NKp' \
    --statCodes '["KOa736nX", "1k8XBo4o", "khg68PeB"]' \
    --tags '["usboxmoF", "GIkPJ39I", "PyPff6Ye"]' \
    > test.out 2>&1
eval_tap $? 97 'PublicQueryUserStatItems2' test.out

#- 98 BulkUpdateUserStatItem2
# body param: body
echo '[{"additionalData": {"sXO0JnWa": {}, "kbfiELgu": {}, "EV94xhoD": {}}, "statCode": "WSAq51Br", "updateStrategy": "MIN", "value": 0.92225002570238}, {"additionalData": {"cEERS1I5": {}, "jERfSbdm": {}, "aOFUHsvz": {}}, "statCode": "TlI8tQiB", "updateStrategy": "MAX", "value": 0.11507444899512287}, {"additionalData": {"RnPUnIFk": {}, "9qQ2GGKO": {}, "dK9Rd6Kh": {}}, "statCode": "kL03tCMz", "updateStrategy": "OVERRIDE", "value": 0.8070150007341481}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkUpdateUserStatItem2 \
    --namespace $AB_NAMESPACE \
    --userId 'EOWtSMpU' \
    --additionalKey 'cWCp1i1w' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 98 'BulkUpdateUserStatItem2' test.out

#- 99 UpdateUserStatItemValue1
# body param: body
echo '{"additionalData": {"P6NNXf22": {}, "P9aL4dY5": {}, "1qCV2652": {}}, "updateStrategy": "INCREMENT", "value": 0.8598081497192067}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op UpdateUserStatItemValue1 \
    --namespace $AB_NAMESPACE \
    --statCode 'wzLP4IEQ' \
    --userId 'vIsU70u0' \
    --additionalKey 'v0J6tWgx' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 99 'UpdateUserStatItemValue1' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE