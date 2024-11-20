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
    --userId 'K5GjfCLL' \
    > test.out 2>&1
eval_tap $? 8 'GetUserProfiles' test.out

#- 9 GetProfile
$CLI_EXE \
    --sn social \
    --op GetProfile \
    --namespace $AB_NAMESPACE \
    --profileId 'mobnKPTD' \
    --userId 'uC2RvaKQ' \
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
    --userIds '["kAiVsW1f", "QNJou3C3", "OXgkWatg"]' \
    > test.out 2>&1
eval_tap $? 12 'PublicGetUserGameProfiles' test.out

#- 13 PublicGetUserProfiles
$CLI_EXE \
    --sn social \
    --op PublicGetUserProfiles \
    --namespace $AB_NAMESPACE \
    --userId 'tv7wKsEV' \
    > test.out 2>&1
eval_tap $? 13 'PublicGetUserProfiles' test.out

#- 14 PublicCreateProfile
# body param: body
echo '{"achievements": ["30xXeSED", "DEfczAtd", "15chKWOu"], "attributes": {"Hhqf8W37": "iGjbjDCD", "4yj42nxp": "9GB6ghCk", "VLtM4BOz": "ofSTcxhN"}, "avatarUrl": "e9ikFlZB", "inventories": ["XWUKktIx", "3ODPORJF", "0SOk9Ot2"], "label": "KU9m7GuS", "profileName": "xQh6XzlM", "statistics": ["dJkCEyLp", "LK0SuTsK", "3g8DV4FB"], "tags": ["4qy3J13b", "MILkgPnS", "PgQmdoYW"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicCreateProfile \
    --namespace $AB_NAMESPACE \
    --userId 'adjxiwwP' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 14 'PublicCreateProfile' test.out

#- 15 PublicGetProfile
$CLI_EXE \
    --sn social \
    --op PublicGetProfile \
    --namespace $AB_NAMESPACE \
    --profileId 'KNXFSxDm' \
    --userId 'fTfLdukw' \
    > test.out 2>&1
eval_tap $? 15 'PublicGetProfile' test.out

#- 16 PublicUpdateProfile
# body param: body
echo '{"achievements": ["Sd7VkkXB", "rFdJgpxG", "WmSUkFZr"], "attributes": {"RQSxxNZ5": "Gd0RLJ03", "LG5gVhQ2": "tUrsgd8L", "RgloXD7y": "jZmNTBl6"}, "avatarUrl": "W56cWyHV", "inventories": ["O3LULzaD", "AxXXIRfM", "lCc8N0ad"], "label": "BPctFVSE", "profileName": "1zxO4Gtr", "statistics": ["oAAPE0dt", "9jdo0CAF", "myhciQdF"], "tags": ["CUzGN09I", "VtycSVFu", "EC0kONF2"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicUpdateProfile \
    --namespace $AB_NAMESPACE \
    --profileId '9nAbsCEC' \
    --userId 'IbwZBVVh' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 16 'PublicUpdateProfile' test.out

#- 17 PublicDeleteProfile
$CLI_EXE \
    --sn social \
    --op PublicDeleteProfile \
    --namespace $AB_NAMESPACE \
    --profileId 'bkQtId6c' \
    --userId 'qMPoYWuu' \
    > test.out 2>&1
eval_tap $? 17 'PublicDeleteProfile' test.out

#- 18 PublicGetProfileAttribute
$CLI_EXE \
    --sn social \
    --op PublicGetProfileAttribute \
    --attributeName 'gDIY1x9B' \
    --namespace $AB_NAMESPACE \
    --profileId 'r5Tna9A0' \
    --userId 'XeZRoMsp' \
    > test.out 2>&1
eval_tap $? 18 'PublicGetProfileAttribute' test.out

#- 19 PublicUpdateAttribute
# body param: body
echo '{"name": "Vgl77hbq", "value": "xBSD2qbG"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicUpdateAttribute \
    --attributeName 'EyKuqTSI' \
    --namespace $AB_NAMESPACE \
    --profileId 'vbnsasMg' \
    --userId 'MJVKo2Uv' \
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
    --limit '50' \
    --offset '93' \
    --statCodes 'wkJ8Yf1J' \
    > test.out 2>&1
eval_tap $? 26 'GetGlobalStatItems' test.out

#- 27 GetGlobalStatItemByStatCode
$CLI_EXE \
    --sn social \
    --op GetGlobalStatItemByStatCode \
    --namespace $AB_NAMESPACE \
    --statCode 'XbRygQE8' \
    > test.out 2>&1
eval_tap $? 27 'GetGlobalStatItemByStatCode' test.out

#- 28 GetStatCycles
$CLI_EXE \
    --sn social \
    --op GetStatCycles \
    --namespace $AB_NAMESPACE \
    --cycleType 'SEASONAL' \
    --limit '4' \
    --name 'HQZShwtB' \
    --offset '10' \
    --sortBy 'mVyZcMmN' \
    --status 'INIT' \
    > test.out 2>&1
eval_tap $? 28 'GetStatCycles' test.out

#- 29 CreateStatCycle
# body param: body
echo '{"cycleType": "WEEKLY", "description": "LIiSOstx", "end": "1992-11-28T00:00:00Z", "id": "A1DKZsTG", "name": "otb80N2L", "resetDate": 40, "resetDay": 20, "resetMonth": 10, "resetTime": "mBbqRlGh", "seasonPeriod": 59, "start": "1998-04-25T00:00:00Z"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op CreateStatCycle \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 29 'CreateStatCycle' test.out

#- 30 BulkGetStatCycle
# body param: body
echo '{"cycleIds": ["rFAS5veP", "T0QpUdaQ", "RJQRhrLh"]}' > $TEMP_JSON_INPUT
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
    --cycleId 'LquUqSaS' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 33 'GetStatCycle' test.out

#- 34 UpdateStatCycle
# body param: body
echo '{"cycleType": "SEASONAL", "description": "OnPM9dZW", "end": "1998-03-20T00:00:00Z", "name": "FfGen6Ws", "resetDate": 3, "resetDay": 40, "resetMonth": 19, "resetTime": "rfp06ZI4", "seasonPeriod": 65, "start": "1975-12-04T00:00:00Z"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op UpdateStatCycle \
    --cycleId 'duxo2Xey' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 34 'UpdateStatCycle' test.out

#- 35 DeleteStatCycle
$CLI_EXE \
    --sn social \
    --op DeleteStatCycle \
    --cycleId 'GzlNjoTr' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 35 'DeleteStatCycle' test.out

#- 36 BulkAddStats
# body param: body
echo '{"statCodes": ["RXLEotDB", "0jOoy9Eb", "WZgJp5uX"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkAddStats \
    --cycleId 'WG8gTYU5' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 36 'BulkAddStats' test.out

#- 37 StopStatCycle
$CLI_EXE \
    --sn social \
    --op StopStatCycle \
    --cycleId 'zbpR9zMv' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 37 'StopStatCycle' test.out

#- 38 BulkFetchStatItems
$CLI_EXE \
    --sn social \
    --op BulkFetchStatItems \
    --namespace $AB_NAMESPACE \
    --statCode 'yQtnHjXO' \
    --userIds '1ItoEtZd' \
    > test.out 2>&1
eval_tap $? 38 'BulkFetchStatItems' test.out

#- 39 BulkIncUserStatItem
# body param: body
echo '[{"inc": 0.767073510744623, "statCode": "PsXyw8ZN", "userId": "tCb2lnX8"}, {"inc": 0.171073425831071, "statCode": "tr0vJXMm", "userId": "6yIaSVHI"}, {"inc": 0.8532541875560584, "statCode": "PLeqwpl8", "userId": "e7OiZzS6"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkIncUserStatItem \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 39 'BulkIncUserStatItem' test.out

#- 40 BulkIncUserStatItemValue
# body param: body
echo '[{"inc": 0.4619809983822952, "statCode": "fKjvyeW4", "userId": "FXAvsRZr"}, {"inc": 0.36331871606279365, "statCode": "BVtb7Hov", "userId": "uPxAQ15H"}, {"inc": 0.7991548681809525, "statCode": "JeiiZyJo", "userId": "VVqOe7xM"}]' > $TEMP_JSON_INPUT
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
    --statCode 'LXQfqeZw' \
    --userIds '["CJUACKJW", "7nUIQJVl", "BY8YedCu"]' \
    > test.out 2>&1
eval_tap $? 41 'BulkFetchOrDefaultStatItems' test.out

#- 42 BulkResetUserStatItem
# body param: body
echo '[{"statCode": "WWdQXlC9", "userId": "bqHZo5Fa"}, {"statCode": "HWt03GZJ", "userId": "gBtHAAXI"}, {"statCode": "jpThEXMS", "userId": "Y8BkkvUF"}]' > $TEMP_JSON_INPUT
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
    --cycleIds 'lzT9CBq6' \
    --isGlobal 'false' \
    --isPublic 'false' \
    --limit '65' \
    --offset '93' \
    > test.out 2>&1
eval_tap $? 43 'GetStats' test.out

#- 44 CreateStat
# body param: body
echo '{"cycleIds": ["gtRPauzA", "CFber6ac", "jNcHYGrV"], "cycleOverrides": [{"cycleId": "2K2XLp7q", "maximum": 0.4859149187024926, "minimum": 0.5407611040442298}, {"cycleId": "cIyHQY5x", "maximum": 0.22921202786748773, "minimum": 0.06864481554350077}, {"cycleId": "PqyoB0M7", "maximum": 0.7457064262742517, "minimum": 0.48026270261953474}], "defaultValue": 0.1450677352087465, "description": "xLoCk66a", "globalAggregationMethod": "LAST", "ignoreAdditionalDataOnValueRejected": false, "incrementOnly": true, "isPublic": false, "maximum": 0.5196672623933883, "minimum": 0.9745211106517626, "name": "jo3LLDSP", "setAsGlobal": true, "setBy": "SERVER", "statCode": "soOheHeW", "tags": ["6yJRgZAE", "3sO7IkDY", "F6GDj8iF"], "visibility": "SHOWALL"}' > $TEMP_JSON_INPUT
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
    --upload file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 46 'ImportStats' test.out

#- 47 QueryStats
$CLI_EXE \
    --sn social \
    --op QueryStats \
    --namespace $AB_NAMESPACE \
    --isGlobal 'true' \
    --isPublic 'true' \
    --limit '5' \
    --offset '0' \
    --keyword 'fIo9rFAl' \
    > test.out 2>&1
eval_tap $? 47 'QueryStats' test.out

#- 48 GetStat
$CLI_EXE \
    --sn social \
    --op GetStat \
    --namespace $AB_NAMESPACE \
    --statCode 'lEx803tY' \
    > test.out 2>&1
eval_tap $? 48 'GetStat' test.out

#- 49 DeleteStat
$CLI_EXE \
    --sn social \
    --op DeleteStat \
    --namespace $AB_NAMESPACE \
    --statCode 'lSExFfPf' \
    > test.out 2>&1
eval_tap $? 49 'DeleteStat' test.out

#- 50 UpdateStat
# body param: body
echo '{"cycleIds": ["WjArCGtU", "w7VOrc4R", "wv6SyRk5"], "cycleOverrides": [{"cycleId": "8NozEREv", "maximum": 0.5742911143707493, "minimum": 0.04169699218958933}, {"cycleId": "WaoVMqw5", "maximum": 0.13810537665682132, "minimum": 0.35681058015248734}, {"cycleId": "iXPUccW7", "maximum": 0.9422948740943159, "minimum": 0.925563895767213}], "defaultValue": 0.7232938940404416, "description": "XdLRblYg", "globalAggregationMethod": "TOTAL", "ignoreAdditionalDataOnValueRejected": true, "isPublic": false, "name": "kYjF8v2O", "tags": ["IxJBp9Pf", "8wZf6Pzo", "vM6y8EkO"], "visibility": "SHOWALL"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op UpdateStat \
    --namespace $AB_NAMESPACE \
    --statCode 'c24Vy0wu' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 50 'UpdateStat' test.out

#- 51 GetStatItems
$CLI_EXE \
    --sn social \
    --op GetStatItems \
    --namespace $AB_NAMESPACE \
    --statCode 'JwUbBiA5' \
    --limit '34' \
    --offset '3' \
    --sortBy 'huXPuINy' \
    > test.out 2>&1
eval_tap $? 51 'GetStatItems' test.out

#- 52 DeleteTiedStat
$CLI_EXE \
    --sn social \
    --op DeleteTiedStat \
    --namespace $AB_NAMESPACE \
    --statCode 'yZlq6iGt' \
    > test.out 2>&1
eval_tap $? 52 'DeleteTiedStat' test.out

#- 53 GetUserStatCycleItems
$CLI_EXE \
    --sn social \
    --op GetUserStatCycleItems \
    --cycleId 'qrZ1zHqe' \
    --namespace $AB_NAMESPACE \
    --userId 'BehPMsgx' \
    --isPublic 'true' \
    --limit '91' \
    --offset '6' \
    --sortBy 'uFKfa6o8' \
    --statCodes '5st0xDER' \
    > test.out 2>&1
eval_tap $? 53 'GetUserStatCycleItems' test.out

#- 54 GetUserStatItems
$CLI_EXE \
    --sn social \
    --op GetUserStatItems \
    --namespace $AB_NAMESPACE \
    --userId 'PHh4sGfI' \
    --isPublic 'true' \
    --limit '10' \
    --offset '39' \
    --sortBy 'UE1gC3BL' \
    --statCodes 'gdMxTdGG' \
    --tags 'nwKzoghS' \
    > test.out 2>&1
eval_tap $? 54 'GetUserStatItems' test.out

#- 55 BulkCreateUserStatItems
# body param: body
echo '[{"statCode": "KaqSNFQ9"}, {"statCode": "jyTn1beL"}, {"statCode": "434bBUQW"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkCreateUserStatItems \
    --namespace $AB_NAMESPACE \
    --userId 'GE0BfG37' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 55 'BulkCreateUserStatItems' test.out

#- 56 BulkIncUserStatItem1
# body param: body
echo '[{"inc": 0.1137313846024458, "statCode": "AgdDs9Co"}, {"inc": 0.740066248147955, "statCode": "5XXE3kNR"}, {"inc": 0.50440402682051, "statCode": "2AnqqB5H"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkIncUserStatItem1 \
    --namespace $AB_NAMESPACE \
    --userId 'L9HN1eRM' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 56 'BulkIncUserStatItem1' test.out

#- 57 BulkIncUserStatItemValue1
# body param: body
echo '[{"inc": 0.3231604694386806, "statCode": "Hpu1RZsd"}, {"inc": 0.8182195029309047, "statCode": "J940VfMZ"}, {"inc": 0.5536326825627076, "statCode": "NkArnaI2"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkIncUserStatItemValue1 \
    --namespace $AB_NAMESPACE \
    --userId 'H58vutuS' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 57 'BulkIncUserStatItemValue1' test.out

#- 58 BulkResetUserStatItem1
# body param: body
echo '[{"statCode": "v1UI9Bbc"}, {"statCode": "dyVzGdkx"}, {"statCode": "MLJgvvIR"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkResetUserStatItem1 \
    --namespace $AB_NAMESPACE \
    --userId 'dHN7cD2V' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 58 'BulkResetUserStatItem1' test.out

#- 59 CreateUserStatItem
$CLI_EXE \
    --sn social \
    --op CreateUserStatItem \
    --namespace $AB_NAMESPACE \
    --statCode 'vrRNovhe' \
    --userId 'l4kRQkT1' \
    > test.out 2>&1
eval_tap $? 59 'CreateUserStatItem' test.out

#- 60 DeleteUserStatItems
$CLI_EXE \
    --sn social \
    --op DeleteUserStatItems \
    --namespace $AB_NAMESPACE \
    --statCode 'AKmIwNxA' \
    --userId 'ibAuMFYq' \
    > test.out 2>&1
eval_tap $? 60 'DeleteUserStatItems' test.out

#- 61 IncUserStatItemValue
# body param: body
echo '{"inc": 0.4010218528233518}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op IncUserStatItemValue \
    --namespace $AB_NAMESPACE \
    --statCode 'h66wD7SH' \
    --userId 's59L296O' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 61 'IncUserStatItemValue' test.out

#- 62 ResetUserStatItemValue
# body param: body
echo '{"additionalData": {"a11hYm8N": {}, "0H4GX5sK": {}, "n7uJXpfc": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op ResetUserStatItemValue \
    --namespace $AB_NAMESPACE \
    --statCode 'QrNZlcDR' \
    --userId 'jSe6SW9X' \
    --additionalKey 'QaPF5HD0' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 62 'ResetUserStatItemValue' test.out

#- 63 GetGlobalStatItems1
$CLI_EXE \
    --sn social \
    --op GetGlobalStatItems1 \
    --namespace $AB_NAMESPACE \
    --limit '9' \
    --offset '40' \
    --statCodes 'QP2cqquh' \
    > test.out 2>&1
eval_tap $? 63 'GetGlobalStatItems1' test.out

#- 64 GetGlobalStatItemByStatCode1
$CLI_EXE \
    --sn social \
    --op GetGlobalStatItemByStatCode1 \
    --namespace $AB_NAMESPACE \
    --statCode 'pLCOda5y' \
    > test.out 2>&1
eval_tap $? 64 'GetGlobalStatItemByStatCode1' test.out

#- 65 GetStatCycles1
$CLI_EXE \
    --sn social \
    --op GetStatCycles1 \
    --namespace $AB_NAMESPACE \
    --cycleType 'SEASONAL' \
    --limit '92' \
    --name 'NPOqQVr9' \
    --offset '61' \
    --sortBy '4l2O0Fp0' \
    --status 'INIT' \
    > test.out 2>&1
eval_tap $? 65 'GetStatCycles1' test.out

#- 66 BulkGetStatCycle1
# body param: body
echo '{"cycleIds": ["tEbOfF95", "7057VP4D", "5B8T20ms"]}' > $TEMP_JSON_INPUT
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
    --cycleId 'KxXdu3rX' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 67 'GetStatCycle1' test.out

#- 68 BulkFetchStatItems1
$CLI_EXE \
    --sn social \
    --op BulkFetchStatItems1 \
    --namespace $AB_NAMESPACE \
    --statCode '8SD6neDS' \
    --userIds 'Z53DHe9Y' \
    > test.out 2>&1
eval_tap $? 68 'BulkFetchStatItems1' test.out

#- 69 PublicBulkIncUserStatItem
# body param: body
echo '[{"inc": 0.2032757635060708, "statCode": "02DkIgyu", "userId": "XMS6VqgW"}, {"inc": 0.2639653321148552, "statCode": "KBjCBntX", "userId": "SYDlnYDJ"}, {"inc": 0.6312256785363893, "statCode": "Rb3zYMZz", "userId": "aZ7R57Hc"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicBulkIncUserStatItem \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 69 'PublicBulkIncUserStatItem' test.out

#- 70 PublicBulkIncUserStatItemValue
# body param: body
echo '[{"inc": 0.9790103908031348, "statCode": "YWMpc4eq", "userId": "EhFFBMSm"}, {"inc": 0.8552439074094316, "statCode": "9ccaC9sT", "userId": "mh7eWNFW"}, {"inc": 0.6621900300185259, "statCode": "Ub7GSbzZ", "userId": "1rMvoFZi"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicBulkIncUserStatItemValue \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 70 'PublicBulkIncUserStatItemValue' test.out

#- 71 BulkResetUserStatItem2
# body param: body
echo '[{"statCode": "3NUJH83B", "userId": "G0UfZaBT"}, {"statCode": "R43VARlU", "userId": "NQasVmL2"}, {"statCode": "DJtw2qL0", "userId": "17ohwZrl"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkResetUserStatItem2 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 71 'BulkResetUserStatItem2' test.out

#- 72 CreateStat1
# body param: body
echo '{"cycleIds": ["iC18Ka2c", "NnP9WhUp", "2miaPQCh"], "cycleOverrides": [{"cycleId": "wds1YBJi", "maximum": 0.2516558432439371, "minimum": 0.7640096073904165}, {"cycleId": "fqgBPZth", "maximum": 0.9839252612586693, "minimum": 0.16797562577005143}, {"cycleId": "DPNQw9uK", "maximum": 0.39852203826681987, "minimum": 0.6578594212089355}], "defaultValue": 0.2511987752534667, "description": "e065h2l1", "globalAggregationMethod": "MIN", "ignoreAdditionalDataOnValueRejected": false, "incrementOnly": false, "isPublic": true, "maximum": 0.47058343402865743, "minimum": 0.9999294955326349, "name": "omJdw9rn", "setAsGlobal": false, "setBy": "SERVER", "statCode": "eN5LCt2y", "tags": ["MWiNNLBg", "SyCNR6tF", "qlUGiTSL"], "visibility": "SERVERONLY"}' > $TEMP_JSON_INPUT
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
    --cycleId 'EkDLCJ4P' \
    --namespace $AB_NAMESPACE \
    --limit '31' \
    --offset '100' \
    --sortBy 'JfHOJEIf' \
    --statCodes '["1JGTsrps", "4kdN3vFW", "1kVO2309"]' \
    > test.out 2>&1
eval_tap $? 73 'PublicListMyStatCycleItems' test.out

#- 74 PublicListMyStatItems
$CLI_EXE \
    --sn social \
    --op PublicListMyStatItems \
    --namespace $AB_NAMESPACE \
    --limit '73' \
    --offset '27' \
    --sortBy 'uHWXmXPC' \
    --statCodes '["uiSPwag2", "eTZbnX2e", "yCc0U5TO"]' \
    --tags '["MPxaIFns", "UJ0ytU1b", "wdSyLQ2i"]' \
    > test.out 2>&1
eval_tap $? 74 'PublicListMyStatItems' test.out

#- 75 PublicListAllMyStatItems
$CLI_EXE \
    --sn social \
    --op PublicListAllMyStatItems \
    --namespace $AB_NAMESPACE \
    --additionalKey 'uT1x70BG' \
    --statCodes '["qksVMoki", "2LCJRdZK", "NdAJuaeq"]' \
    --tags '["IO2OGhQQ", "olMpWVJP", "4higwhZ6"]' \
    > test.out 2>&1
eval_tap $? 75 'PublicListAllMyStatItems' test.out

#- 76 GetUserStatCycleItems1
$CLI_EXE \
    --sn social \
    --op GetUserStatCycleItems1 \
    --cycleId 'LpN4iPQy' \
    --namespace $AB_NAMESPACE \
    --userId '6FsjwCF1' \
    --limit '58' \
    --offset '97' \
    --sortBy 'C549hzyk' \
    --statCodes 'HPnyBuX6' \
    > test.out 2>&1
eval_tap $? 76 'GetUserStatCycleItems1' test.out

#- 77 PublicQueryUserStatItems
$CLI_EXE \
    --sn social \
    --op PublicQueryUserStatItems \
    --namespace $AB_NAMESPACE \
    --userId 'hyXDDErn' \
    --limit '99' \
    --offset '46' \
    --sortBy 'uIMgHZre' \
    --statCodes 'yGMN3pis' \
    --tags 'ucx6dVQO' \
    > test.out 2>&1
eval_tap $? 77 'PublicQueryUserStatItems' test.out

#- 78 PublicBulkCreateUserStatItems
# body param: body
echo '[{"statCode": "dd8SuMWD"}, {"statCode": "nmc0lZTs"}, {"statCode": "2TmFkAMp"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicBulkCreateUserStatItems \
    --namespace $AB_NAMESPACE \
    --userId '0ULfPF3G' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 78 'PublicBulkCreateUserStatItems' test.out

#- 79 PublicQueryUserStatItems1
$CLI_EXE \
    --sn social \
    --op PublicQueryUserStatItems1 \
    --namespace $AB_NAMESPACE \
    --userId 'QvOFzwTI' \
    --additionalKey 'jvkGql0e' \
    --statCodes '["53Z06agr", "JuFyD0LH", "lReZL6cj"]' \
    --tags '["nQ7DnryR", "wLV6pBp9", "z87aCEix"]' \
    > test.out 2>&1
eval_tap $? 79 'PublicQueryUserStatItems1' test.out

#- 80 PublicBulkIncUserStatItem1
# body param: body
echo '[{"inc": 0.3581332869828239, "statCode": "VEgj5vqc"}, {"inc": 0.9035863586109306, "statCode": "dHAai74a"}, {"inc": 0.41663389507294035, "statCode": "RvYshdlR"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicBulkIncUserStatItem1 \
    --namespace $AB_NAMESPACE \
    --userId 'AbZwNkmb' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 80 'PublicBulkIncUserStatItem1' test.out

#- 81 BulkIncUserStatItemValue2
# body param: body
echo '[{"inc": 0.7164821874819238, "statCode": "SMzkRU20"}, {"inc": 0.5940603691610163, "statCode": "nBMzMHxV"}, {"inc": 0.6196235571319819, "statCode": "ksJPqvae"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkIncUserStatItemValue2 \
    --namespace $AB_NAMESPACE \
    --userId '40FOHwq9' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 81 'BulkIncUserStatItemValue2' test.out

#- 82 BulkResetUserStatItem3
# body param: body
echo '[{"statCode": "Xq3BWFTF"}, {"statCode": "YZWgpOhT"}, {"statCode": "Jr4YPE5r"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkResetUserStatItem3 \
    --namespace $AB_NAMESPACE \
    --userId 'sk9fyVRe' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 82 'BulkResetUserStatItem3' test.out

#- 83 PublicCreateUserStatItem
$CLI_EXE \
    --sn social \
    --op PublicCreateUserStatItem \
    --namespace $AB_NAMESPACE \
    --statCode 'C9pc1W0c' \
    --userId 'j6gQ0tJf' \
    > test.out 2>&1
eval_tap $? 83 'PublicCreateUserStatItem' test.out

#- 84 DeleteUserStatItems1
$CLI_EXE \
    --sn social \
    --op DeleteUserStatItems1 \
    --namespace $AB_NAMESPACE \
    --statCode 'tUJA98hz' \
    --userId 'SZ0Hkz6e' \
    > test.out 2>&1
eval_tap $? 84 'DeleteUserStatItems1' test.out

#- 85 PublicIncUserStatItem
# body param: body
echo '{"inc": 0.7635073097357219}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicIncUserStatItem \
    --namespace $AB_NAMESPACE \
    --statCode 'poaynkYO' \
    --userId 'EeepJcpA' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 85 'PublicIncUserStatItem' test.out

#- 86 PublicIncUserStatItemValue
# body param: body
echo '{"inc": 0.3292504706972501}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicIncUserStatItemValue \
    --namespace $AB_NAMESPACE \
    --statCode 'L487q7g7' \
    --userId '8CKD2MPH' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 86 'PublicIncUserStatItemValue' test.out

#- 87 ResetUserStatItemValue1
$CLI_EXE \
    --sn social \
    --op ResetUserStatItemValue1 \
    --namespace $AB_NAMESPACE \
    --statCode 'tusaWSja' \
    --userId 'SvzpuHO1' \
    > test.out 2>&1
eval_tap $? 87 'ResetUserStatItemValue1' test.out

#- 88 BulkUpdateUserStatItemV2
# body param: body
echo '[{"additionalData": {"a8BVlwOP": {}, "gYhCEiiT": {}, "BHeZg0Wx": {}}, "additionalKey": "NaFSHSrv", "statCode": "oOxsFg2P", "updateStrategy": "OVERRIDE", "userId": "6ZSfyGwd", "value": 0.3626418350260374}, {"additionalData": {"YjcsyTYZ": {}, "0Dls2n5C": {}, "JOQcuOqH": {}}, "additionalKey": "pwiF92tn", "statCode": "XvP9njZw", "updateStrategy": "MIN", "userId": "CcopPyTo", "value": 0.6931579953844553}, {"additionalData": {"yNmOV0pp": {}, "qNft0z3j": {}, "Ktix6Kjk": {}}, "additionalKey": "VMJLCPy8", "statCode": "wg593lV7", "updateStrategy": "OVERRIDE", "userId": "jOdVsWLj", "value": 0.09814185079770854}]' > $TEMP_JSON_INPUT
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
    --additionalKey 'TfeCvX9M' \
    --statCode 'PwrL4JMM' \
    --userIds '["YGu93FAv", "tfPJhwYU", "fJgkRB7U"]' \
    > test.out 2>&1
eval_tap $? 89 'BulkFetchOrDefaultStatItems1' test.out

#- 90 AdminListUsersStatItems
$CLI_EXE \
    --sn social \
    --op AdminListUsersStatItems \
    --namespace $AB_NAMESPACE \
    --userId 'gdCSNHkU' \
    --additionalKey 'zmntHrtn' \
    --statCodes '["VGGHuHjW", "SHaCmvtp", "HH7zZOlE"]' \
    --tags '["77WJpZ3w", "GnxJFwv5", "ZcUch72A"]' \
    > test.out 2>&1
eval_tap $? 90 'AdminListUsersStatItems' test.out

#- 91 BulkUpdateUserStatItem
# body param: body
echo '[{"additionalData": {"Qi1pYtsK": {}, "MMGsih7N": {}, "xCSyOeNE": {}}, "statCode": "x9hSFqRv", "updateStrategy": "INCREMENT", "value": 0.3403891530255265}, {"additionalData": {"g8CX2IYX": {}, "EB621fKm": {}, "v6DTmlcE": {}}, "statCode": "BmZMfijR", "updateStrategy": "MAX", "value": 0.7900952528356918}, {"additionalData": {"GDdp25ZY": {}, "0pVDg18T": {}, "59sfmg1N": {}}, "statCode": "sbkR4Ep6", "updateStrategy": "INCREMENT", "value": 0.9143028832647486}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkUpdateUserStatItem \
    --namespace $AB_NAMESPACE \
    --userId 'gf15Y3Qi' \
    --additionalKey '5unYnGst' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 91 'BulkUpdateUserStatItem' test.out

#- 92 BulkGetOrDefaultByUserId
# body param: body
echo '{"statCodes": ["Au0rHT7J", "qTpvfmyX", "oLTy4Rdw"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkGetOrDefaultByUserId \
    --namespace $AB_NAMESPACE \
    --userId 'uZxAp9I4' \
    --additionalKey '0wJFm22z' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 92 'BulkGetOrDefaultByUserId' test.out

#- 93 BulkResetUserStatItemValues
# body param: body
echo '[{"additionalData": {"Y0fpdJsl": {}, "DWRtZikl": {}, "4tc0iFMB": {}}, "statCode": "vFLLLxW5"}, {"additionalData": {"QmxAGiTJ": {}, "rKEidSpz": {}, "OlmthBQ9": {}}, "statCode": "BHVkSKMR"}, {"additionalData": {"Pwp1WxU9": {}, "FsvHWUB2": {}, "oUBCW2KD": {}}, "statCode": "mnFzmUPV"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkResetUserStatItemValues \
    --namespace $AB_NAMESPACE \
    --userId '8IpzLdQz' \
    --additionalKey 'om4dCQ23' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 93 'BulkResetUserStatItemValues' test.out

#- 94 DeleteUserStatItems2
$CLI_EXE \
    --sn social \
    --op DeleteUserStatItems2 \
    --namespace $AB_NAMESPACE \
    --statCode 'Yvusd1xf' \
    --userId 'Jkwhi1wr' \
    --additionalKey 'ulVVwnZo' \
    > test.out 2>&1
eval_tap $? 94 'DeleteUserStatItems2' test.out

#- 95 UpdateUserStatItemValue
# body param: body
echo '{"additionalData": {"WKGUzBgb": {}, "UjXWqxGK": {}, "EWM5aZrj": {}}, "updateStrategy": "INCREMENT", "value": 0.7369745336752657}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op UpdateUserStatItemValue \
    --namespace $AB_NAMESPACE \
    --statCode 'xdR5ye6q' \
    --userId 'h350hy5Z' \
    --additionalKey 'wkjnqPg1' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 95 'UpdateUserStatItemValue' test.out

#- 96 BulkUpdateUserStatItem1
# body param: body
echo '[{"additionalData": {"kguSKMvC": {}, "E0NyUazw": {}, "OKlZhYHv": {}}, "additionalKey": "RXmkIB49", "statCode": "QLpza5Pn", "updateStrategy": "MIN", "userId": "pXro0SAM", "value": 0.6353054466365089}, {"additionalData": {"EbOT6zb7": {}, "z0k6Gozx": {}, "DsSo0nMd": {}}, "additionalKey": "m3tqHCJo", "statCode": "ouVcV67g", "updateStrategy": "MIN", "userId": "ycFsW3nc", "value": 0.5412632767738902}, {"additionalData": {"GG7hFaI5": {}, "29NG5bY4": {}, "FJ6DJOrk": {}}, "additionalKey": "tnrI86iu", "statCode": "3qmloU7a", "updateStrategy": "OVERRIDE", "userId": "6kbUwnCo", "value": 0.25215974770410954}]' > $TEMP_JSON_INPUT
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
    --userId '2P4OC9dw' \
    --additionalKey 'izVCg6Zp' \
    --statCodes '["3MIklEl1", "5kEu4PUZ", "X602jjUe"]' \
    --tags '["qVz8FBaW", "PmYZjaOY", "lPfItRU5"]' \
    > test.out 2>&1
eval_tap $? 97 'PublicQueryUserStatItems2' test.out

#- 98 BulkUpdateUserStatItem2
# body param: body
echo '[{"additionalData": {"msjjmOvj": {}, "ikOYjIhq": {}, "1CFQRuKV": {}}, "statCode": "MSXGGr6m", "updateStrategy": "MAX", "value": 0.24045862798811002}, {"additionalData": {"JMGVoi7y": {}, "gHlxM4S1": {}, "edV1VLoW": {}}, "statCode": "K8rwnLIx", "updateStrategy": "MAX", "value": 0.3442305710359497}, {"additionalData": {"O2OAq4pM": {}, "oftZoi3N": {}, "RaO60pCD": {}}, "statCode": "VHQuglD1", "updateStrategy": "MAX", "value": 0.8482005498259919}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkUpdateUserStatItem2 \
    --namespace $AB_NAMESPACE \
    --userId 'dLCRS7HT' \
    --additionalKey 'fCzqaA9r' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 98 'BulkUpdateUserStatItem2' test.out

#- 99 UpdateUserStatItemValue1
# body param: body
echo '{"additionalData": {"Gt8uiMqh": {}, "7uvR1UjB": {}, "k0LSy1wb": {}}, "updateStrategy": "INCREMENT", "value": 0.7038317100355855}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op UpdateUserStatItemValue1 \
    --namespace $AB_NAMESPACE \
    --statCode 'AFUxxkAt' \
    --userId 'OOmv7wDv' \
    --additionalKey 'YEE0tPYy' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 99 'UpdateUserStatItemValue1' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE