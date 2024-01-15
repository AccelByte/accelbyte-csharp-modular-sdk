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
echo "1..98"

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
    --userId 'slUYBYX3' \
    > test.out 2>&1
eval_tap $? 8 'GetUserProfiles' test.out

#- 9 GetProfile
$CLI_EXE \
    --sn social \
    --op GetProfile \
    --namespace $AB_NAMESPACE \
    --profileId 'A36zv3AU' \
    --userId 'NnJzktna' \
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
    --userIds '["COiCwlqh", "qU2RdOCl", "ICPLI8p9"]' \
    > test.out 2>&1
eval_tap $? 12 'PublicGetUserGameProfiles' test.out

#- 13 PublicGetUserProfiles
$CLI_EXE \
    --sn social \
    --op PublicGetUserProfiles \
    --namespace $AB_NAMESPACE \
    --userId 'c3PJNh64' \
    > test.out 2>&1
eval_tap $? 13 'PublicGetUserProfiles' test.out

#- 14 PublicCreateProfile
# body param: body
echo '{"achievements": ["oamU6ooL", "gNz35dmY", "M9Ke7Dph"], "attributes": {"NHKuVOAl": "A8ZwN5br", "c1KUjCv5": "zNkcpatU", "tWjoKpUl": "AddJLccz"}, "avatarUrl": "X8wEpdTM", "inventories": ["dEQa9YxA", "HyRoOawa", "FwJmZVio"], "label": "d1ma4NUd", "profileName": "qRf30AQf", "statistics": ["8GBbkNnn", "9mufm7VU", "PnjXKFqK"], "tags": ["IGfb37OW", "eR4QgZ1Y", "3VvS3tOd"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicCreateProfile \
    --namespace $AB_NAMESPACE \
    --userId 'MqqfwfDy' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 14 'PublicCreateProfile' test.out

#- 15 PublicGetProfile
$CLI_EXE \
    --sn social \
    --op PublicGetProfile \
    --namespace $AB_NAMESPACE \
    --profileId 'TvKG31Cr' \
    --userId 'Z8MmEd3C' \
    > test.out 2>&1
eval_tap $? 15 'PublicGetProfile' test.out

#- 16 PublicUpdateProfile
# body param: body
echo '{"achievements": ["VSO1MwmH", "GHRB5OSq", "RFvS8ITX"], "attributes": {"w6lv8sff": "e2MAAWzM", "XkpCHEgV": "faAHB29R", "qLdTrhHA": "FNOavRdk"}, "avatarUrl": "QbXjc9uP", "inventories": ["GF4MsBxB", "XEDdhodz", "04lCYe45"], "label": "SsWcOW6d", "profileName": "P7BOATjQ", "statistics": ["bmJAt4Q3", "BiLVHogg", "NKl7g4Vu"], "tags": ["BpDLOoO8", "VwS2O3yE", "tOji9utE"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicUpdateProfile \
    --namespace $AB_NAMESPACE \
    --profileId '0yCYSmWv' \
    --userId 'FxuYh9sV' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 16 'PublicUpdateProfile' test.out

#- 17 PublicDeleteProfile
$CLI_EXE \
    --sn social \
    --op PublicDeleteProfile \
    --namespace $AB_NAMESPACE \
    --profileId 'OiUu4R1D' \
    --userId '4XDqBxMg' \
    > test.out 2>&1
eval_tap $? 17 'PublicDeleteProfile' test.out

#- 18 PublicGetProfileAttribute
$CLI_EXE \
    --sn social \
    --op PublicGetProfileAttribute \
    --attributeName 'kkC7GVoA' \
    --namespace $AB_NAMESPACE \
    --profileId 'ONN1TvHM' \
    --userId 'f9Pqhr6h' \
    > test.out 2>&1
eval_tap $? 18 'PublicGetProfileAttribute' test.out

#- 19 PublicUpdateAttribute
# body param: body
echo '{"name": "Fq2XovlR", "value": "IBGkXPmU"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicUpdateAttribute \
    --attributeName '07EfQDvk' \
    --namespace $AB_NAMESPACE \
    --profileId 'v7PnY5gA' \
    --userId 'fgKY5Gi5' \
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
    --limit '81' \
    --offset '41' \
    --statCodes '9rHTewuN' \
    > test.out 2>&1
eval_tap $? 26 'GetGlobalStatItems' test.out

#- 27 GetGlobalStatItemByStatCode
$CLI_EXE \
    --sn social \
    --op GetGlobalStatItemByStatCode \
    --namespace $AB_NAMESPACE \
    --statCode 'GbPRS6Di' \
    > test.out 2>&1
eval_tap $? 27 'GetGlobalStatItemByStatCode' test.out

#- 28 GetStatCycles
$CLI_EXE \
    --sn social \
    --op GetStatCycles \
    --namespace $AB_NAMESPACE \
    --cycleType 'MONTHLY' \
    --limit '44' \
    --name 'I8OQ0hhv' \
    --offset '44' \
    --sortBy 'oIX5CziU' \
    --status 'STOPPED' \
    > test.out 2>&1
eval_tap $? 28 'GetStatCycles' test.out

#- 29 CreateStatCycle
# body param: body
echo '{"cycleType": "MONTHLY", "description": "NoSuc0mu", "end": "1971-02-27T00:00:00Z", "name": "FbMHP5VS", "resetDate": 40, "resetDay": 54, "resetMonth": 28, "resetTime": "aRp0PTI3", "seasonPeriod": 53, "start": "1992-08-24T00:00:00Z"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op CreateStatCycle \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 29 'CreateStatCycle' test.out

#- 30 BulkGetStatCycle
# body param: body
echo '{"cycleIds": ["m6RDpwo3", "NiLywhFC", "pD3FjfxL"]}' > $TEMP_JSON_INPUT
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
    --replaceExisting 'true' \
    --upload $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 32 'ImportStatCycle' test.out

#- 33 GetStatCycle
$CLI_EXE \
    --sn social \
    --op GetStatCycle \
    --cycleId 'ie9TxzK3' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 33 'GetStatCycle' test.out

#- 34 UpdateStatCycle
# body param: body
echo '{"cycleType": "WEEKLY", "description": "6PdDiVlO", "end": "1982-03-29T00:00:00Z", "name": "uPW1iSHF", "resetDate": 53, "resetDay": 38, "resetMonth": 65, "resetTime": "YFwiTKCv", "seasonPeriod": 21, "start": "1982-09-14T00:00:00Z"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op UpdateStatCycle \
    --cycleId 'VUyE3UHQ' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 34 'UpdateStatCycle' test.out

#- 35 DeleteStatCycle
$CLI_EXE \
    --sn social \
    --op DeleteStatCycle \
    --cycleId 'LY5169E0' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 35 'DeleteStatCycle' test.out

#- 36 BulkAddStats
# body param: body
echo '{"statCodes": ["LeLEduR0", "5MeCHXlY", "ZWXzAlWX"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkAddStats \
    --cycleId 'Imcw1Jgg' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 36 'BulkAddStats' test.out

#- 37 StopStatCycle
$CLI_EXE \
    --sn social \
    --op StopStatCycle \
    --cycleId 'tlXfcDnE' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 37 'StopStatCycle' test.out

#- 38 BulkFetchStatItems
$CLI_EXE \
    --sn social \
    --op BulkFetchStatItems \
    --namespace $AB_NAMESPACE \
    --statCode 'JCNtmLEU' \
    --userIds 'NX0CiCBZ' \
    > test.out 2>&1
eval_tap $? 38 'BulkFetchStatItems' test.out

#- 39 BulkIncUserStatItem
# body param: body
echo '[{"inc": 0.6678929444128379, "statCode": "UeXETdwg", "userId": "nR7R9FQk"}, {"inc": 0.4891466445295518, "statCode": "X2fJNgvO", "userId": "H6hR6s31"}, {"inc": 0.03507696116055037, "statCode": "esMzAkUH", "userId": "kiOeAriX"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkIncUserStatItem \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 39 'BulkIncUserStatItem' test.out

#- 40 BulkIncUserStatItemValue
# body param: body
echo '[{"inc": 0.06142888156435855, "statCode": "M9qIMLDU", "userId": "vQcIfYNi"}, {"inc": 0.672616863972117, "statCode": "mskITJjN", "userId": "mUvvRLV4"}, {"inc": 0.9990748551555733, "statCode": "0yKJa4Y2", "userId": "mT2D4bDU"}]' > $TEMP_JSON_INPUT
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
    --statCode '9q1dmFmB' \
    --userIds '["fXAEcxvP", "jw49Oz6C", "28uGt04w"]' \
    > test.out 2>&1
eval_tap $? 41 'BulkFetchOrDefaultStatItems' test.out

#- 42 BulkResetUserStatItem
# body param: body
echo '[{"statCode": "bSh2KfDP", "userId": "2cLdff6v"}, {"statCode": "bGmcfVmN", "userId": "oBmWIvZW"}, {"statCode": "uS3MChJq", "userId": "qt9raYfN"}]' > $TEMP_JSON_INPUT
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
    --cycleIds '4BLccFLx' \
    --isGlobal 'true' \
    --isPublic 'true' \
    --limit '68' \
    --offset '44' \
    > test.out 2>&1
eval_tap $? 43 'GetStats' test.out

#- 44 CreateStat
# body param: body
echo '{"cycleIds": ["Evt3oqBZ", "JwB2RLYp", "xb0exJoV"], "defaultValue": 0.6885056217567991, "description": "BbXHD7Tv", "ignoreAdditionalDataOnValueRejected": false, "incrementOnly": false, "isPublic": false, "maximum": 0.12345716430244691, "minimum": 0.16059769649798816, "name": "gxhnUjer", "setAsGlobal": true, "setBy": "SERVER", "statCode": "lnNRNM4a", "tags": ["VxlBJZjt", "XIYh0ZA8", "DED2H90d"]}' > $TEMP_JSON_INPUT
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
    --replaceExisting 'false' \
    --upload $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 46 'ImportStats' test.out

#- 47 QueryStats
$CLI_EXE \
    --sn social \
    --op QueryStats \
    --namespace $AB_NAMESPACE \
    --isGlobal 'true' \
    --isPublic 'false' \
    --limit '87' \
    --offset '12' \
    --keyword 'kEQsHuhp' \
    > test.out 2>&1
eval_tap $? 47 'QueryStats' test.out

#- 48 GetStat
$CLI_EXE \
    --sn social \
    --op GetStat \
    --namespace $AB_NAMESPACE \
    --statCode 'YOWDRUc0' \
    > test.out 2>&1
eval_tap $? 48 'GetStat' test.out

#- 49 DeleteStat
$CLI_EXE \
    --sn social \
    --op DeleteStat \
    --namespace $AB_NAMESPACE \
    --statCode 'jeAydPP0' \
    > test.out 2>&1
eval_tap $? 49 'DeleteStat' test.out

#- 50 UpdateStat
# body param: body
echo '{"cycleIds": ["3oLbkbGc", "M4h6YCdF", "9JpD0SfA"], "defaultValue": 0.05702158309022198, "description": "O6VZFNkI", "ignoreAdditionalDataOnValueRejected": true, "isPublic": true, "name": "XyLfmMGI", "tags": ["hNUPajN7", "ySpHl9BL", "fdpHogiw"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op UpdateStat \
    --namespace $AB_NAMESPACE \
    --statCode 'zuk51xgf' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 50 'UpdateStat' test.out

#- 51 GetStatItems
$CLI_EXE \
    --sn social \
    --op GetStatItems \
    --namespace $AB_NAMESPACE \
    --statCode '4DehHok8' \
    --limit '63' \
    --offset '15' \
    --sortBy 'Axth0dbI' \
    > test.out 2>&1
eval_tap $? 51 'GetStatItems' test.out

#- 52 DeleteTiedStat
$CLI_EXE \
    --sn social \
    --op DeleteTiedStat \
    --namespace $AB_NAMESPACE \
    --statCode 'BIn5Prmr' \
    > test.out 2>&1
eval_tap $? 52 'DeleteTiedStat' test.out

#- 53 GetUserStatCycleItems
$CLI_EXE \
    --sn social \
    --op GetUserStatCycleItems \
    --cycleId 'IjYJcBR3' \
    --namespace $AB_NAMESPACE \
    --userId 'eHy39y6J' \
    --isPublic 'false' \
    --limit '10' \
    --offset '54' \
    --sortBy 'rVzJUUQ9' \
    --statCodes 'WMKpjdHb' \
    > test.out 2>&1
eval_tap $? 53 'GetUserStatCycleItems' test.out

#- 54 GetUserStatItems
$CLI_EXE \
    --sn social \
    --op GetUserStatItems \
    --namespace $AB_NAMESPACE \
    --userId '0jWOzTEV' \
    --isPublic 'true' \
    --limit '26' \
    --offset '53' \
    --sortBy 'kMehWiYc' \
    --statCodes 'qcJ0GGJq' \
    --tags '2M6ap9vW' \
    > test.out 2>&1
eval_tap $? 54 'GetUserStatItems' test.out

#- 55 BulkCreateUserStatItems
# body param: body
echo '[{"statCode": "fBYIvlUs"}, {"statCode": "HzX4nWIa"}, {"statCode": "hlK14aYx"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkCreateUserStatItems \
    --namespace $AB_NAMESPACE \
    --userId '8RobO8s3' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 55 'BulkCreateUserStatItems' test.out

#- 56 BulkIncUserStatItem1
# body param: body
echo '[{"inc": 0.7708920758828466, "statCode": "rowoXs1E"}, {"inc": 0.5944915080108067, "statCode": "80mRM9ok"}, {"inc": 0.022210553547947987, "statCode": "ec4BORiQ"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkIncUserStatItem1 \
    --namespace $AB_NAMESPACE \
    --userId 'tl9GHgvC' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 56 'BulkIncUserStatItem1' test.out

#- 57 BulkIncUserStatItemValue1
# body param: body
echo '[{"inc": 0.5564377940723335, "statCode": "r0vvTzW1"}, {"inc": 0.6665823540267495, "statCode": "J29VLxiu"}, {"inc": 0.8870354340893118, "statCode": "EChtxkJA"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkIncUserStatItemValue1 \
    --namespace $AB_NAMESPACE \
    --userId 'UNYcHVjL' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 57 'BulkIncUserStatItemValue1' test.out

#- 58 BulkResetUserStatItem1
# body param: body
echo '[{"statCode": "2VddkBFM"}, {"statCode": "7wyp7Wdd"}, {"statCode": "s4t15vNn"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkResetUserStatItem1 \
    --namespace $AB_NAMESPACE \
    --userId 'V1c6DmGJ' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 58 'BulkResetUserStatItem1' test.out

#- 59 CreateUserStatItem
$CLI_EXE \
    --sn social \
    --op CreateUserStatItem \
    --namespace $AB_NAMESPACE \
    --statCode 'vcLeNJJe' \
    --userId 'jkuvx3g7' \
    > test.out 2>&1
eval_tap $? 59 'CreateUserStatItem' test.out

#- 60 DeleteUserStatItems
$CLI_EXE \
    --sn social \
    --op DeleteUserStatItems \
    --namespace $AB_NAMESPACE \
    --statCode 'vTQVJT8Y' \
    --userId 'EfoLBv8e' \
    > test.out 2>&1
eval_tap $? 60 'DeleteUserStatItems' test.out

#- 61 IncUserStatItemValue
# body param: body
echo '{"inc": 0.7230748802380169}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op IncUserStatItemValue \
    --namespace $AB_NAMESPACE \
    --statCode '9FeXhjf2' \
    --userId 'Lvl4hv0B' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 61 'IncUserStatItemValue' test.out

#- 62 ResetUserStatItemValue
# body param: body
echo '{"additionalData": {"YwRTA422": {}, "S6ZiQRoh": {}, "BtvLbSL6": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op ResetUserStatItemValue \
    --namespace $AB_NAMESPACE \
    --statCode 'q8c0BaYp' \
    --userId 'KxCjLDAW' \
    --additionalKey 'SlZcx2mV' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 62 'ResetUserStatItemValue' test.out

#- 63 GetGlobalStatItems1
$CLI_EXE \
    --sn social \
    --op GetGlobalStatItems1 \
    --namespace $AB_NAMESPACE \
    --limit '19' \
    --offset '68' \
    --statCodes 'v4mhrjJl' \
    > test.out 2>&1
eval_tap $? 63 'GetGlobalStatItems1' test.out

#- 64 GetGlobalStatItemByStatCode1
$CLI_EXE \
    --sn social \
    --op GetGlobalStatItemByStatCode1 \
    --namespace $AB_NAMESPACE \
    --statCode 'fJUDcxDb' \
    > test.out 2>&1
eval_tap $? 64 'GetGlobalStatItemByStatCode1' test.out

#- 65 GetStatCycles1
$CLI_EXE \
    --sn social \
    --op GetStatCycles1 \
    --namespace $AB_NAMESPACE \
    --cycleType 'DAILY' \
    --limit '59' \
    --name 'A885g3gY' \
    --offset '19' \
    --sortBy 'WAVULJIF' \
    --status 'ACTIVE' \
    > test.out 2>&1
eval_tap $? 65 'GetStatCycles1' test.out

#- 66 BulkGetStatCycle1
# body param: body
echo '{"cycleIds": ["oZa93212", "ROT1hsBe", "9EHQex9e"]}' > $TEMP_JSON_INPUT
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
    --cycleId 'YdUmfzBP' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 67 'GetStatCycle1' test.out

#- 68 BulkFetchStatItems1
$CLI_EXE \
    --sn social \
    --op BulkFetchStatItems1 \
    --namespace $AB_NAMESPACE \
    --statCode 'DIkIPHPu' \
    --userIds 'K0GHd8Ej' \
    > test.out 2>&1
eval_tap $? 68 'BulkFetchStatItems1' test.out

#- 69 PublicBulkIncUserStatItem
# body param: body
echo '[{"inc": 0.5280086290826836, "statCode": "0ribh57U", "userId": "PDaC6OKN"}, {"inc": 0.4556292655038714, "statCode": "S3RSgRhz", "userId": "UIyS5ff0"}, {"inc": 0.415406416273963, "statCode": "E6O3KwJR", "userId": "ja8AmjS2"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicBulkIncUserStatItem \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 69 'PublicBulkIncUserStatItem' test.out

#- 70 PublicBulkIncUserStatItemValue
# body param: body
echo '[{"inc": 0.8536109991893547, "statCode": "YSrNbt5R", "userId": "hne6qjWV"}, {"inc": 0.11328246041620638, "statCode": "LEYoH3QE", "userId": "i3VBswRE"}, {"inc": 0.2862589657091098, "statCode": "8nZKElns", "userId": "ypaHUsrk"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicBulkIncUserStatItemValue \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 70 'PublicBulkIncUserStatItemValue' test.out

#- 71 BulkResetUserStatItem2
# body param: body
echo '[{"statCode": "gCoCEaME", "userId": "pYgFm3R1"}, {"statCode": "uPWwAe6Q", "userId": "EupgwwL0"}, {"statCode": "AiKjvAvh", "userId": "TovwATtm"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkResetUserStatItem2 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 71 'BulkResetUserStatItem2' test.out

#- 72 CreateStat1
# body param: body
echo '{"cycleIds": ["jby3SB7p", "4K67NZov", "UniCJqz7"], "defaultValue": 0.8533282847797566, "description": "rhcB5Meb", "ignoreAdditionalDataOnValueRejected": true, "incrementOnly": false, "isPublic": false, "maximum": 0.8091904722732167, "minimum": 0.4115464798869377, "name": "UVvA6brw", "setAsGlobal": true, "setBy": "SERVER", "statCode": "QCd5eaFn", "tags": ["7tii1Btc", "vnweHuHk", "YeaYcOxg"]}' > $TEMP_JSON_INPUT
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
    --cycleId 'DE4oxPgJ' \
    --namespace $AB_NAMESPACE \
    --limit '99' \
    --offset '34' \
    --sortBy 'IQ0QFpMf' \
    --statCodes '["nyhCJjxq", "WxSJf3Eb", "mXxa5Q83"]' \
    > test.out 2>&1
eval_tap $? 73 'PublicListMyStatCycleItems' test.out

#- 74 PublicListMyStatItems
$CLI_EXE \
    --sn social \
    --op PublicListMyStatItems \
    --namespace $AB_NAMESPACE \
    --limit '4' \
    --offset '37' \
    --sortBy 'WxkPwFd6' \
    --statCodes '["ZM4rLqvR", "bm0pQJVz", "wGQmXWGw"]' \
    --tags '["OwsafxDy", "t2pder1d", "3GkGNlYN"]' \
    > test.out 2>&1
eval_tap $? 74 'PublicListMyStatItems' test.out

#- 75 PublicListAllMyStatItems
$CLI_EXE \
    --sn social \
    --op PublicListAllMyStatItems \
    --namespace $AB_NAMESPACE \
    --additionalKey 'AWC2ba2Q' \
    --statCodes '["6BF8oR9a", "8WIJRjIh", "YLT1mEpp"]' \
    --tags '["oaGQmNNH", "IsaJw4re", "Cnn4inA0"]' \
    > test.out 2>&1
eval_tap $? 75 'PublicListAllMyStatItems' test.out

#- 76 GetUserStatCycleItems1
$CLI_EXE \
    --sn social \
    --op GetUserStatCycleItems1 \
    --cycleId '6NkjKHSG' \
    --namespace $AB_NAMESPACE \
    --userId 'Wyr2qtXB' \
    --limit '63' \
    --offset '76' \
    --sortBy 'miJJY77b' \
    --statCodes 'KnvWU7wg' \
    > test.out 2>&1
eval_tap $? 76 'GetUserStatCycleItems1' test.out

#- 77 PublicQueryUserStatItems
$CLI_EXE \
    --sn social \
    --op PublicQueryUserStatItems \
    --namespace $AB_NAMESPACE \
    --userId 'dbeV3abK' \
    --limit '7' \
    --offset '94' \
    --sortBy 'vApOIpfr' \
    --statCodes 'JLT3hzFX' \
    --tags 'qX2MuLg9' \
    > test.out 2>&1
eval_tap $? 77 'PublicQueryUserStatItems' test.out

#- 78 PublicBulkCreateUserStatItems
# body param: body
echo '[{"statCode": "2s1qSTpg"}, {"statCode": "sKaDZJJL"}, {"statCode": "ltI6sblU"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicBulkCreateUserStatItems \
    --namespace $AB_NAMESPACE \
    --userId 'vP6NuBFR' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 78 'PublicBulkCreateUserStatItems' test.out

#- 79 PublicQueryUserStatItems1
$CLI_EXE \
    --sn social \
    --op PublicQueryUserStatItems1 \
    --namespace $AB_NAMESPACE \
    --userId '1oOQelsh' \
    --additionalKey 'D00eEeuD' \
    --statCodes '["jFTgIUTv", "cdsPMhVx", "hgIwYEKR"]' \
    --tags '["jSWSZIEE", "rc3XQI0c", "QZ0R8i0f"]' \
    > test.out 2>&1
eval_tap $? 79 'PublicQueryUserStatItems1' test.out

#- 80 PublicBulkIncUserStatItem1
# body param: body
echo '[{"inc": 0.0005979154290095545, "statCode": "tWE9Tqnf"}, {"inc": 0.38089373215310984, "statCode": "Cf0pazfi"}, {"inc": 0.3055663723596832, "statCode": "fpYfXjn5"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicBulkIncUserStatItem1 \
    --namespace $AB_NAMESPACE \
    --userId 'Qd2Z6rjf' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 80 'PublicBulkIncUserStatItem1' test.out

#- 81 BulkIncUserStatItemValue2
# body param: body
echo '[{"inc": 0.816935805146534, "statCode": "8WqPaL7d"}, {"inc": 0.7695055698449665, "statCode": "A2ovaTp6"}, {"inc": 0.5620897442373697, "statCode": "rSOKNYwi"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkIncUserStatItemValue2 \
    --namespace $AB_NAMESPACE \
    --userId '18t5H1yo' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 81 'BulkIncUserStatItemValue2' test.out

#- 82 BulkResetUserStatItem3
# body param: body
echo '[{"statCode": "bYOrgceY"}, {"statCode": "CzDPC7eH"}, {"statCode": "rdGCT3bk"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkResetUserStatItem3 \
    --namespace $AB_NAMESPACE \
    --userId 'EvWiXgcn' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 82 'BulkResetUserStatItem3' test.out

#- 83 PublicCreateUserStatItem
$CLI_EXE \
    --sn social \
    --op PublicCreateUserStatItem \
    --namespace $AB_NAMESPACE \
    --statCode 'Q2HPdifX' \
    --userId 'QWNHMaio' \
    > test.out 2>&1
eval_tap $? 83 'PublicCreateUserStatItem' test.out

#- 84 DeleteUserStatItems1
$CLI_EXE \
    --sn social \
    --op DeleteUserStatItems1 \
    --namespace $AB_NAMESPACE \
    --statCode '8OEvTBg2' \
    --userId 'lTSFER98' \
    > test.out 2>&1
eval_tap $? 84 'DeleteUserStatItems1' test.out

#- 85 PublicIncUserStatItem
# body param: body
echo '{"inc": 0.3669289111964177}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicIncUserStatItem \
    --namespace $AB_NAMESPACE \
    --statCode 'WGLmFjFS' \
    --userId 'UvSso0ps' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 85 'PublicIncUserStatItem' test.out

#- 86 PublicIncUserStatItemValue
# body param: body
echo '{"inc": 0.43224001280535185}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicIncUserStatItemValue \
    --namespace $AB_NAMESPACE \
    --statCode 'yP9RlK73' \
    --userId 'KASHSPfq' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 86 'PublicIncUserStatItemValue' test.out

#- 87 ResetUserStatItemValue1
$CLI_EXE \
    --sn social \
    --op ResetUserStatItemValue1 \
    --namespace $AB_NAMESPACE \
    --statCode '8eixLGbU' \
    --userId '96zUALVu' \
    > test.out 2>&1
eval_tap $? 87 'ResetUserStatItemValue1' test.out

#- 88 BulkUpdateUserStatItemV2
# body param: body
echo '[{"additionalData": {"SUcgJIyK": {}, "A8J5WmXp": {}, "retP4s7Q": {}}, "additionalKey": "caI10SaZ", "statCode": "KOIpFCkm", "updateStrategy": "INCREMENT", "userId": "WaP8zjCR", "value": 0.9099156714612616}, {"additionalData": {"srkQi1S4": {}, "M0b9YMJU": {}, "hHcsaOOz": {}}, "additionalKey": "WUh01pd6", "statCode": "d711prwO", "updateStrategy": "OVERRIDE", "userId": "gS1mSLHY", "value": 0.13726076433552048}, {"additionalData": {"JprUccT4": {}, "grzMYOIQ": {}, "gDqCwZci": {}}, "additionalKey": "g3rxrSbq", "statCode": "LD5sAdrT", "updateStrategy": "INCREMENT", "userId": "zwZelhuJ", "value": 0.8874466989720221}]' > $TEMP_JSON_INPUT
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
    --additionalKey 'kTBvtjr7' \
    --statCode 'F1YNEK5r' \
    --userIds '["G6sv1mfE", "GaJveKUf", "yRmKVB9f"]' \
    > test.out 2>&1
eval_tap $? 89 'BulkFetchOrDefaultStatItems1' test.out

#- 90 AdminListUsersStatItems
$CLI_EXE \
    --sn social \
    --op AdminListUsersStatItems \
    --namespace $AB_NAMESPACE \
    --userId '8E1XXkXq' \
    --additionalKey 'YUK6YY4J' \
    --statCodes '["RldPdxGd", "7Qbj6Tmq", "RbPr9WGp"]' \
    --tags '["eiGIcssB", "ld6UuAXw", "o1QGjZnR"]' \
    > test.out 2>&1
eval_tap $? 90 'AdminListUsersStatItems' test.out

#- 91 BulkUpdateUserStatItem
# body param: body
echo '[{"additionalData": {"moMmMWVp": {}, "4eS5cyaF": {}, "DBAHWwsq": {}}, "statCode": "w6pNGxv8", "updateStrategy": "MIN", "value": 0.7287242189818444}, {"additionalData": {"2Niu8sG8": {}, "KgOmL0Cv": {}, "Qlpxr25M": {}}, "statCode": "ADxsmfJ6", "updateStrategy": "INCREMENT", "value": 0.9221338924775673}, {"additionalData": {"yRsf8GWw": {}, "9N6BBhNx": {}, "HNFA51Rb": {}}, "statCode": "2bEaI8JR", "updateStrategy": "MIN", "value": 0.868821919836476}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkUpdateUserStatItem \
    --namespace $AB_NAMESPACE \
    --userId 'RCBmjzrG' \
    --additionalKey 'F0m05QC7' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 91 'BulkUpdateUserStatItem' test.out

#- 92 BulkResetUserStatItemValues
# body param: body
echo '[{"additionalData": {"JnUUpg1P": {}, "5bOY0v3A": {}, "t2mGqS05": {}}, "statCode": "ks9v6nRH"}, {"additionalData": {"vKatJKf7": {}, "2Gk9T1WI": {}, "xMS2oKwu": {}}, "statCode": "Zs7PD0P8"}, {"additionalData": {"jYzeYwS0": {}, "vWlv2XaC": {}, "soP13yDt": {}}, "statCode": "qi8xzAlS"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkResetUserStatItemValues \
    --namespace $AB_NAMESPACE \
    --userId 'LjMLhJGC' \
    --additionalKey 'ohksRehL' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 92 'BulkResetUserStatItemValues' test.out

#- 93 DeleteUserStatItems2
$CLI_EXE \
    --sn social \
    --op DeleteUserStatItems2 \
    --namespace $AB_NAMESPACE \
    --statCode 'vti5phjD' \
    --userId '6gps8Gcx' \
    --additionalKey 'WzjcT0QT' \
    > test.out 2>&1
eval_tap $? 93 'DeleteUserStatItems2' test.out

#- 94 UpdateUserStatItemValue
# body param: body
echo '{"additionalData": {"mkW3Tl5V": {}, "m8Emh2qp": {}, "cxhD9BMN": {}}, "updateStrategy": "INCREMENT", "value": 0.8162751851203445}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op UpdateUserStatItemValue \
    --namespace $AB_NAMESPACE \
    --statCode 'uyZl0uS4' \
    --userId 'YlbMMvz9' \
    --additionalKey 'CRCK98d2' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 94 'UpdateUserStatItemValue' test.out

#- 95 BulkUpdateUserStatItem1
# body param: body
echo '[{"additionalData": {"LsobpnEs": {}, "oBiasXbO": {}, "rk7zSi5a": {}}, "additionalKey": "ZqlIElxI", "statCode": "aTnn5jHi", "updateStrategy": "MIN", "userId": "D0z23eYB", "value": 0.0023121427007224415}, {"additionalData": {"cyALYrpD": {}, "VSEcTQuH": {}, "fNr1DBVk": {}}, "additionalKey": "oOV5C3y3", "statCode": "G8DywAYU", "updateStrategy": "MIN", "userId": "RD3H8XOo", "value": 0.5069821118469144}, {"additionalData": {"4qQynDZi": {}, "8MNqSIhU": {}, "Xtbh9er8": {}}, "additionalKey": "5K58UHYY", "statCode": "8vP2GXh6", "updateStrategy": "MIN", "userId": "zSoukowk", "value": 0.4146663395568373}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkUpdateUserStatItem1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 95 'BulkUpdateUserStatItem1' test.out

#- 96 PublicQueryUserStatItems2
$CLI_EXE \
    --sn social \
    --op PublicQueryUserStatItems2 \
    --namespace $AB_NAMESPACE \
    --userId 'wvZFd1jK' \
    --additionalKey 'BOnYYTB0' \
    --statCodes '["cJhhZJMy", "j2svtS3O", "JcLrw2tQ"]' \
    --tags '["FljUZFq7", "BmpNkAg5", "yJEysGnM"]' \
    > test.out 2>&1
eval_tap $? 96 'PublicQueryUserStatItems2' test.out

#- 97 BulkUpdateUserStatItem2
# body param: body
echo '[{"additionalData": {"qO5JzvSn": {}, "lXaIAKxT": {}, "N9DizBLV": {}}, "statCode": "sUnaTLd7", "updateStrategy": "OVERRIDE", "value": 0.04170981839523202}, {"additionalData": {"WCouXXQM": {}, "HIAjePdA": {}, "IR66fgjv": {}}, "statCode": "39ymdGSR", "updateStrategy": "INCREMENT", "value": 0.6981350714165928}, {"additionalData": {"EVNAnvpW": {}, "bDV2DH9L": {}, "Vstr0f9y": {}}, "statCode": "VJIG2F0N", "updateStrategy": "MIN", "value": 0.747732672349342}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkUpdateUserStatItem2 \
    --namespace $AB_NAMESPACE \
    --userId 'kbnwEqna' \
    --additionalKey '7q32zkbP' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 97 'BulkUpdateUserStatItem2' test.out

#- 98 UpdateUserStatItemValue1
# body param: body
echo '{"additionalData": {"ahV7vJew": {}, "QfzETnaZ": {}, "oWJeGgik": {}}, "updateStrategy": "INCREMENT", "value": 0.02264508642991625}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op UpdateUserStatItemValue1 \
    --namespace $AB_NAMESPACE \
    --statCode 'B1d2wVtO' \
    --userId 'zjEo2Mtw' \
    --additionalKey 'vL2cEljh' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 98 'UpdateUserStatItemValue1' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE