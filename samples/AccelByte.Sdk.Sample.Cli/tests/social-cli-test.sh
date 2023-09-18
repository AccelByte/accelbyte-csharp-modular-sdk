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
echo "1..95"

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
    --userId '9Ay7vIPV' \
    > test.out 2>&1
eval_tap $? 8 'GetUserProfiles' test.out

#- 9 GetProfile
$CLI_EXE \
    --sn social \
    --op GetProfile \
    --namespace $AB_NAMESPACE \
    --profileId 'ntml4E6B' \
    --userId 'p8llnp5u' \
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
    --userIds '["bCi14WVb", "xylTXbgJ", "UTPS1Dvp"]' \
    > test.out 2>&1
eval_tap $? 12 'PublicGetUserGameProfiles' test.out

#- 13 PublicGetUserProfiles
$CLI_EXE \
    --sn social \
    --op PublicGetUserProfiles \
    --namespace $AB_NAMESPACE \
    --userId 'PGJFzxWj' \
    > test.out 2>&1
eval_tap $? 13 'PublicGetUserProfiles' test.out

#- 14 PublicCreateProfile
# body param: body
echo '{"achievements": ["zHZ5NgBk", "8YxTNBuf", "BRmO9oGy"], "attributes": {"cWZErr1Q": "FhKjDAgC", "Z9DLC4x1": "lvZK8lUt", "fL3mdUZY": "vJ4iJVVQ"}, "avatarUrl": "6BoG1sx3", "inventories": ["sB6DyNiU", "czFrjvdN", "7wNXnhuz"], "label": "1jYni9Ri", "profileName": "7wBAO9j1", "statistics": ["ngMs0dBf", "Vt4u8IrS", "oOBqQTZZ"], "tags": ["0JRRMmYF", "6WN5ZBs9", "iUAvUY9Y"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicCreateProfile \
    --namespace $AB_NAMESPACE \
    --userId 'eCtiUdVf' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 14 'PublicCreateProfile' test.out

#- 15 PublicGetProfile
$CLI_EXE \
    --sn social \
    --op PublicGetProfile \
    --namespace $AB_NAMESPACE \
    --profileId 'V98NHyHQ' \
    --userId 'BBisljG1' \
    > test.out 2>&1
eval_tap $? 15 'PublicGetProfile' test.out

#- 16 PublicUpdateProfile
# body param: body
echo '{"achievements": ["ePOncUU7", "XZsCwt1F", "FjPB7YmC"], "attributes": {"csjp3TZW": "NEC5YKTb", "Yf1RpMcy": "24sbNs1a", "4VA2RESN": "hSbWxNMs"}, "avatarUrl": "wh4g1UT6", "inventories": ["fjVg1oX4", "X1tPntgu", "VL37iDnz"], "label": "cSVF7wEd", "profileName": "0BnWP1Ea", "statistics": ["jv2acO3K", "uR6qZ87q", "gnw9zdJS"], "tags": ["blu5L6cz", "10VFls7F", "mMH9wSPI"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicUpdateProfile \
    --namespace $AB_NAMESPACE \
    --profileId 'liokodOL' \
    --userId 'BmQxi8Sv' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 16 'PublicUpdateProfile' test.out

#- 17 PublicDeleteProfile
$CLI_EXE \
    --sn social \
    --op PublicDeleteProfile \
    --namespace $AB_NAMESPACE \
    --profileId 'w62OF7GF' \
    --userId 'Ezo6858e' \
    > test.out 2>&1
eval_tap $? 17 'PublicDeleteProfile' test.out

#- 18 PublicGetProfileAttribute
$CLI_EXE \
    --sn social \
    --op PublicGetProfileAttribute \
    --attributeName 'KSsbdUMY' \
    --namespace $AB_NAMESPACE \
    --profileId 'CmhZH4LJ' \
    --userId 'dCdWMyoB' \
    > test.out 2>&1
eval_tap $? 18 'PublicGetProfileAttribute' test.out

#- 19 PublicUpdateAttribute
# body param: body
echo '{"name": "B5EDNxun", "value": "AEaGxOA1"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicUpdateAttribute \
    --attributeName 'akosUoUb' \
    --namespace $AB_NAMESPACE \
    --profileId 'U1gm1g1N' \
    --userId 'mcjmLLxX' \
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
    --limit '33' \
    --offset '64' \
    --statCodes 'Yw11YkYN' \
    > test.out 2>&1
eval_tap $? 26 'GetGlobalStatItems' test.out

#- 27 GetGlobalStatItemByStatCode
$CLI_EXE \
    --sn social \
    --op GetGlobalStatItemByStatCode \
    --namespace $AB_NAMESPACE \
    --statCode 'JtVVfWtv' \
    > test.out 2>&1
eval_tap $? 27 'GetGlobalStatItemByStatCode' test.out

#- 28 GetStatCycles
$CLI_EXE \
    --sn social \
    --op GetStatCycles \
    --namespace $AB_NAMESPACE \
    --cycleType 'ANNUALLY' \
    --limit '89' \
    --name 'l6xj7t26' \
    --offset '18' \
    --sortBy 'pFRfHxRS' \
    --status 'ACTIVE' \
    > test.out 2>&1
eval_tap $? 28 'GetStatCycles' test.out

#- 29 CreateStatCycle
# body param: body
echo '{"cycleType": "SEASONAL", "description": "FBZrjgCW", "end": "1971-04-08T00:00:00Z", "name": "UCMH937D", "resetDate": 52, "resetDay": 2, "resetMonth": 8, "resetTime": "NKXVjSy5", "seasonPeriod": 29, "start": "1974-03-16T00:00:00Z"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op CreateStatCycle \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 29 'CreateStatCycle' test.out

#- 30 BulkGetStatCycle
# body param: body
echo '{"cycleIds": ["Ee9IuIN8", "KKcnqgOs", "iknCpPoF"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkGetStatCycle \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 30 'BulkGetStatCycle' test.out

#- 31 GetStatCycle
$CLI_EXE \
    --sn social \
    --op GetStatCycle \
    --cycleId 'eofSOSEy' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 31 'GetStatCycle' test.out

#- 32 UpdateStatCycle
# body param: body
echo '{"cycleType": "ANNUALLY", "description": "Xu1PuTEl", "end": "1999-03-16T00:00:00Z", "name": "g0fOFlTX", "resetDate": 17, "resetDay": 21, "resetMonth": 4, "resetTime": "v8cRzw6a", "seasonPeriod": 52, "start": "1980-10-15T00:00:00Z"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op UpdateStatCycle \
    --cycleId 'LiBdRaUg' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 32 'UpdateStatCycle' test.out

#- 33 DeleteStatCycle
$CLI_EXE \
    --sn social \
    --op DeleteStatCycle \
    --cycleId '7lMqL86H' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 33 'DeleteStatCycle' test.out

#- 34 BulkAddStats
# body param: body
echo '{"statCodes": ["k50y6tWB", "RssN7EIr", "WEKURuYp"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkAddStats \
    --cycleId 'Z4UJntgY' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 34 'BulkAddStats' test.out

#- 35 StopStatCycle
$CLI_EXE \
    --sn social \
    --op StopStatCycle \
    --cycleId 'dVX3Gdvq' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 35 'StopStatCycle' test.out

#- 36 BulkFetchStatItems
$CLI_EXE \
    --sn social \
    --op BulkFetchStatItems \
    --namespace $AB_NAMESPACE \
    --statCode 'S5WNF4qq' \
    --userIds 'RlqLXmQD' \
    > test.out 2>&1
eval_tap $? 36 'BulkFetchStatItems' test.out

#- 37 BulkIncUserStatItem
# body param: body
echo '[{"inc": 0.25425604506395183, "statCode": "NJ5iGBso", "userId": "Uz5sF4A0"}, {"inc": 0.7001646161110949, "statCode": "G1V7s2rI", "userId": "DOSs4wqF"}, {"inc": 0.9329864507216769, "statCode": "IxEk05Nu", "userId": "B98YwYKK"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkIncUserStatItem \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 37 'BulkIncUserStatItem' test.out

#- 38 BulkIncUserStatItemValue
# body param: body
echo '[{"inc": 0.6110303058568216, "statCode": "fOSOdREa", "userId": "QuISGz5m"}, {"inc": 0.7844978820275897, "statCode": "njHFeHeS", "userId": "fKF3CaiG"}, {"inc": 0.26125082588774984, "statCode": "WveU1Tcx", "userId": "HJ3K17K6"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkIncUserStatItemValue \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 38 'BulkIncUserStatItemValue' test.out

#- 39 BulkFetchOrDefaultStatItems
$CLI_EXE \
    --sn social \
    --op BulkFetchOrDefaultStatItems \
    --namespace $AB_NAMESPACE \
    --statCode 'zg0j4YFm' \
    --userIds '["2OP0q5Ei", "Y6B5nAwo", "K8XSviYA"]' \
    > test.out 2>&1
eval_tap $? 39 'BulkFetchOrDefaultStatItems' test.out

#- 40 BulkResetUserStatItem
# body param: body
echo '[{"statCode": "RvyALXrs", "userId": "ZSuCfN6x"}, {"statCode": "fCPS7aD3", "userId": "NXtM7gwu"}, {"statCode": "fpx2yyZM", "userId": "MbnroB8x"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkResetUserStatItem \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 40 'BulkResetUserStatItem' test.out

#- 41 GetStats
$CLI_EXE \
    --sn social \
    --op GetStats \
    --namespace $AB_NAMESPACE \
    --cycleIds '2Bf7LrBV' \
    --isGlobal 'true' \
    --isPublic 'true' \
    --limit '29' \
    --offset '10' \
    > test.out 2>&1
eval_tap $? 41 'GetStats' test.out

#- 42 CreateStat
# body param: body
echo '{"cycleIds": ["WDt9X5KG", "BmZQBT57", "Y5eT5vyw"], "defaultValue": 0.4439167787952949, "description": "YwXaXsrs", "ignoreAdditionalDataOnValueRejected": false, "incrementOnly": false, "isPublic": false, "maximum": 0.4607064202948906, "minimum": 0.07690157217909566, "name": "PXKR76r2", "setAsGlobal": false, "setBy": "SERVER", "statCode": "JME3gKdt", "tags": ["Js2ccDVc", "orYLttI5", "Zt0Rgsxt"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op CreateStat \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 42 'CreateStat' test.out

#- 43 ExportStats
$CLI_EXE \
    --sn social \
    --op ExportStats \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 43 'ExportStats' test.out

#- 44 ImportStats
# form data upload: file
echo 'tmp.dat' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --sn social \
    --op ImportStats \
    --namespace $AB_NAMESPACE \
    --replaceExisting 'false' \
    --upload $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 44 'ImportStats' test.out

#- 45 QueryStats
$CLI_EXE \
    --sn social \
    --op QueryStats \
    --namespace $AB_NAMESPACE \
    --isGlobal 'true' \
    --isPublic 'false' \
    --limit '20' \
    --offset '25' \
    --keyword 'fxDS56RS' \
    > test.out 2>&1
eval_tap $? 45 'QueryStats' test.out

#- 46 GetStat
$CLI_EXE \
    --sn social \
    --op GetStat \
    --namespace $AB_NAMESPACE \
    --statCode 'feZ1I5qk' \
    > test.out 2>&1
eval_tap $? 46 'GetStat' test.out

#- 47 DeleteStat
$CLI_EXE \
    --sn social \
    --op DeleteStat \
    --namespace $AB_NAMESPACE \
    --statCode 'WYZOF0Bz' \
    > test.out 2>&1
eval_tap $? 47 'DeleteStat' test.out

#- 48 UpdateStat
# body param: body
echo '{"cycleIds": ["1bFDBYth", "C8jnQx0u", "7EDhWVTm"], "defaultValue": 0.5469668591631324, "description": "HXnt3zqj", "ignoreAdditionalDataOnValueRejected": false, "isPublic": false, "name": "zbApGIHT", "tags": ["pDlprxV3", "2UmmMRJY", "fYYvV5Ym"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op UpdateStat \
    --namespace $AB_NAMESPACE \
    --statCode '29n2a9uw' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 48 'UpdateStat' test.out

#- 49 DeleteTiedStat
$CLI_EXE \
    --sn social \
    --op DeleteTiedStat \
    --namespace $AB_NAMESPACE \
    --statCode 'VdHcapsm' \
    > test.out 2>&1
eval_tap $? 49 'DeleteTiedStat' test.out

#- 50 GetUserStatCycleItems
$CLI_EXE \
    --sn social \
    --op GetUserStatCycleItems \
    --cycleId 'Nq9cITuU' \
    --namespace $AB_NAMESPACE \
    --userId '6ZySuYr1' \
    --isPublic 'true' \
    --limit '15' \
    --offset '36' \
    --sortBy '4G3mGOWI' \
    --statCodes 'UDlO7oRT' \
    > test.out 2>&1
eval_tap $? 50 'GetUserStatCycleItems' test.out

#- 51 GetUserStatItems
$CLI_EXE \
    --sn social \
    --op GetUserStatItems \
    --namespace $AB_NAMESPACE \
    --userId 'j2yhygru' \
    --isPublic 'true' \
    --limit '3' \
    --offset '88' \
    --sortBy '5vhgm2ZK' \
    --statCodes 'hfS96TKh' \
    --tags 'Y1sQLkAo' \
    > test.out 2>&1
eval_tap $? 51 'GetUserStatItems' test.out

#- 52 BulkCreateUserStatItems
# body param: body
echo '[{"statCode": "vvlIxV6N"}, {"statCode": "R05eotyv"}, {"statCode": "grrQyLbz"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkCreateUserStatItems \
    --namespace $AB_NAMESPACE \
    --userId 'Ee5L5nyj' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 52 'BulkCreateUserStatItems' test.out

#- 53 BulkIncUserStatItem1
# body param: body
echo '[{"inc": 0.8772792788358459, "statCode": "UpDgxIa4"}, {"inc": 0.6233949933575275, "statCode": "P2oIvikn"}, {"inc": 0.5187494910159062, "statCode": "WzD0octQ"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkIncUserStatItem1 \
    --namespace $AB_NAMESPACE \
    --userId 'n9RabGsJ' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 53 'BulkIncUserStatItem1' test.out

#- 54 BulkIncUserStatItemValue1
# body param: body
echo '[{"inc": 0.8355251975976596, "statCode": "3hAIv0aU"}, {"inc": 0.7589359178010054, "statCode": "FU1pF237"}, {"inc": 0.09273758197877491, "statCode": "5NESuydE"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkIncUserStatItemValue1 \
    --namespace $AB_NAMESPACE \
    --userId 'whN0Mr0Z' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 54 'BulkIncUserStatItemValue1' test.out

#- 55 BulkResetUserStatItem1
# body param: body
echo '[{"statCode": "clymTS6V"}, {"statCode": "59jnY6h8"}, {"statCode": "Y4Ryzutr"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkResetUserStatItem1 \
    --namespace $AB_NAMESPACE \
    --userId 'iCmWRg6R' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 55 'BulkResetUserStatItem1' test.out

#- 56 CreateUserStatItem
$CLI_EXE \
    --sn social \
    --op CreateUserStatItem \
    --namespace $AB_NAMESPACE \
    --statCode 'U2jqKwkr' \
    --userId 'VSrStbsi' \
    > test.out 2>&1
eval_tap $? 56 'CreateUserStatItem' test.out

#- 57 DeleteUserStatItems
$CLI_EXE \
    --sn social \
    --op DeleteUserStatItems \
    --namespace $AB_NAMESPACE \
    --statCode 'D8KDgyvS' \
    --userId 'YzomkQzQ' \
    > test.out 2>&1
eval_tap $? 57 'DeleteUserStatItems' test.out

#- 58 IncUserStatItemValue
# body param: body
echo '{"inc": 0.9798362064598412}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op IncUserStatItemValue \
    --namespace $AB_NAMESPACE \
    --statCode '8est0oUD' \
    --userId 'BhUNCpVK' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 58 'IncUserStatItemValue' test.out

#- 59 ResetUserStatItemValue
# body param: body
echo '{"additionalData": {"MeClMwSf": {}, "81l8zJqM": {}, "GHMp8ITB": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op ResetUserStatItemValue \
    --namespace $AB_NAMESPACE \
    --statCode 'gTuxXR8H' \
    --userId 'fRvR3AcY' \
    --additionalKey 'sItWBaNO' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 59 'ResetUserStatItemValue' test.out

#- 60 GetGlobalStatItems1
$CLI_EXE \
    --sn social \
    --op GetGlobalStatItems1 \
    --namespace $AB_NAMESPACE \
    --limit '23' \
    --offset '29' \
    --statCodes 'JyjQEM7B' \
    > test.out 2>&1
eval_tap $? 60 'GetGlobalStatItems1' test.out

#- 61 GetGlobalStatItemByStatCode1
$CLI_EXE \
    --sn social \
    --op GetGlobalStatItemByStatCode1 \
    --namespace $AB_NAMESPACE \
    --statCode 'Rae8diUM' \
    > test.out 2>&1
eval_tap $? 61 'GetGlobalStatItemByStatCode1' test.out

#- 62 GetStatCycles1
$CLI_EXE \
    --sn social \
    --op GetStatCycles1 \
    --namespace $AB_NAMESPACE \
    --cycleType 'MONTHLY' \
    --limit '10' \
    --name 'sddWc7fo' \
    --offset '21' \
    --sortBy 'TDwpcZy2' \
    --status 'STOPPED' \
    > test.out 2>&1
eval_tap $? 62 'GetStatCycles1' test.out

#- 63 BulkGetStatCycle1
# body param: body
echo '{"cycleIds": ["RAjxF32B", "EYbMDV0D", "DADzbx9i"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkGetStatCycle1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 63 'BulkGetStatCycle1' test.out

#- 64 GetStatCycle1
$CLI_EXE \
    --sn social \
    --op GetStatCycle1 \
    --cycleId 'UEjwLNmp' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 64 'GetStatCycle1' test.out

#- 65 BulkFetchStatItems1
$CLI_EXE \
    --sn social \
    --op BulkFetchStatItems1 \
    --namespace $AB_NAMESPACE \
    --statCode 'F4ADFMTR' \
    --userIds 'lAc5WaIe' \
    > test.out 2>&1
eval_tap $? 65 'BulkFetchStatItems1' test.out

#- 66 PublicBulkIncUserStatItem
# body param: body
echo '[{"inc": 0.18240421978139754, "statCode": "wSb4ywwq", "userId": "vXGYZXtQ"}, {"inc": 0.43760115107418807, "statCode": "eydJGIWa", "userId": "zZE2or6M"}, {"inc": 0.6306627208118925, "statCode": "834Zqya3", "userId": "4J19J3AK"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicBulkIncUserStatItem \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 66 'PublicBulkIncUserStatItem' test.out

#- 67 PublicBulkIncUserStatItemValue
# body param: body
echo '[{"inc": 0.7609430530092782, "statCode": "4qsDoXBT", "userId": "8z5SSs4W"}, {"inc": 0.07432772036791924, "statCode": "QvoSk1ho", "userId": "KZpmPiA2"}, {"inc": 0.8184166725889757, "statCode": "AUg0eFYP", "userId": "MM4owh0y"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicBulkIncUserStatItemValue \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 67 'PublicBulkIncUserStatItemValue' test.out

#- 68 BulkResetUserStatItem2
# body param: body
echo '[{"statCode": "3oeN8UMq", "userId": "Gm3Sma45"}, {"statCode": "KBj3gDLN", "userId": "S6gQ5PlC"}, {"statCode": "Oq4rXGoX", "userId": "WGIb7icJ"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkResetUserStatItem2 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 68 'BulkResetUserStatItem2' test.out

#- 69 CreateStat1
# body param: body
echo '{"cycleIds": ["EQwKW3Oj", "JCDiAD0G", "LqgbLye4"], "defaultValue": 0.2034339010870524, "description": "UfolYJxS", "ignoreAdditionalDataOnValueRejected": true, "incrementOnly": false, "isPublic": false, "maximum": 0.9236043148469034, "minimum": 0.4363697294872205, "name": "PYBeIqnY", "setAsGlobal": true, "setBy": "CLIENT", "statCode": "sQpGFDbB", "tags": ["kmVF0Of5", "8KpQNB1x", "6nnU4wVH"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op CreateStat1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 69 'CreateStat1' test.out

#- 70 PublicListMyStatCycleItems
$CLI_EXE \
    --sn social \
    --op PublicListMyStatCycleItems \
    --cycleId '21Whn8x4' \
    --namespace $AB_NAMESPACE \
    --limit '33' \
    --offset '92' \
    --sortBy '2QWg29A1' \
    --statCodes '["NCg1AcaC", "5rFOgvbm", "47DE63ak"]' \
    > test.out 2>&1
eval_tap $? 70 'PublicListMyStatCycleItems' test.out

#- 71 PublicListMyStatItems
$CLI_EXE \
    --sn social \
    --op PublicListMyStatItems \
    --namespace $AB_NAMESPACE \
    --limit '37' \
    --offset '51' \
    --sortBy 'J4E45xPw' \
    --statCodes '["aFfmDTES", "TM4JcswS", "8MUTzlcK"]' \
    --tags '["OjVnJngz", "uyFZce8h", "YzRlfaUX"]' \
    > test.out 2>&1
eval_tap $? 71 'PublicListMyStatItems' test.out

#- 72 PublicListAllMyStatItems
$CLI_EXE \
    --sn social \
    --op PublicListAllMyStatItems \
    --namespace $AB_NAMESPACE \
    --additionalKey 'jAoXd96Y' \
    --statCodes '["d82xZuLE", "qg0mv33a", "9ie2yJiH"]' \
    --tags '["HFebT6z2", "0H9nKLPN", "tOkjTUay"]' \
    > test.out 2>&1
eval_tap $? 72 'PublicListAllMyStatItems' test.out

#- 73 GetUserStatCycleItems1
$CLI_EXE \
    --sn social \
    --op GetUserStatCycleItems1 \
    --cycleId 'BWKtLLQY' \
    --namespace $AB_NAMESPACE \
    --userId '7xTIlGZr' \
    --limit '77' \
    --offset '85' \
    --sortBy 'FzY6ih6k' \
    --statCodes 'v0ElhLO9' \
    > test.out 2>&1
eval_tap $? 73 'GetUserStatCycleItems1' test.out

#- 74 PublicQueryUserStatItems
$CLI_EXE \
    --sn social \
    --op PublicQueryUserStatItems \
    --namespace $AB_NAMESPACE \
    --userId 'NawtpLN3' \
    --limit '6' \
    --offset '68' \
    --sortBy 'fv2mfpMo' \
    --statCodes 'ivPq8rqq' \
    --tags 'qP0DBil1' \
    > test.out 2>&1
eval_tap $? 74 'PublicQueryUserStatItems' test.out

#- 75 PublicBulkCreateUserStatItems
# body param: body
echo '[{"statCode": "alpsk0yP"}, {"statCode": "ceylHJbA"}, {"statCode": "47NJgyX2"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicBulkCreateUserStatItems \
    --namespace $AB_NAMESPACE \
    --userId 'FuBcF6kU' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 75 'PublicBulkCreateUserStatItems' test.out

#- 76 PublicQueryUserStatItems1
$CLI_EXE \
    --sn social \
    --op PublicQueryUserStatItems1 \
    --namespace $AB_NAMESPACE \
    --userId 'hklXVsxt' \
    --additionalKey 'xPk1hUuO' \
    --statCodes '["wp0beMHa", "bEUeKUZ0", "BhfqFBmf"]' \
    --tags '["RfH2dDIE", "8RjLZh04", "koRpvtNx"]' \
    > test.out 2>&1
eval_tap $? 76 'PublicQueryUserStatItems1' test.out

#- 77 PublicBulkIncUserStatItem1
# body param: body
echo '[{"inc": 0.21185262142836137, "statCode": "a2X4IIDU"}, {"inc": 0.26111292947695053, "statCode": "kO4S5dVB"}, {"inc": 0.6645022946113086, "statCode": "a9s1zqpi"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicBulkIncUserStatItem1 \
    --namespace $AB_NAMESPACE \
    --userId '162gK9oY' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 77 'PublicBulkIncUserStatItem1' test.out

#- 78 BulkIncUserStatItemValue2
# body param: body
echo '[{"inc": 0.2007917921616551, "statCode": "D4ErhLHD"}, {"inc": 0.5449304289887686, "statCode": "s7cbXtqH"}, {"inc": 0.43388953868307756, "statCode": "2yuGwwRM"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkIncUserStatItemValue2 \
    --namespace $AB_NAMESPACE \
    --userId 'LX2NE9xU' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 78 'BulkIncUserStatItemValue2' test.out

#- 79 BulkResetUserStatItem3
# body param: body
echo '[{"statCode": "ecXO18oo"}, {"statCode": "Pe7vOCYO"}, {"statCode": "tpXQu9rT"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkResetUserStatItem3 \
    --namespace $AB_NAMESPACE \
    --userId 'HUDUmi2H' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 79 'BulkResetUserStatItem3' test.out

#- 80 PublicCreateUserStatItem
$CLI_EXE \
    --sn social \
    --op PublicCreateUserStatItem \
    --namespace $AB_NAMESPACE \
    --statCode '2nYCQN7W' \
    --userId 'xhpcPkGS' \
    > test.out 2>&1
eval_tap $? 80 'PublicCreateUserStatItem' test.out

#- 81 DeleteUserStatItems1
$CLI_EXE \
    --sn social \
    --op DeleteUserStatItems1 \
    --namespace $AB_NAMESPACE \
    --statCode 'odTpvKz4' \
    --userId 'rpS23DqK' \
    > test.out 2>&1
eval_tap $? 81 'DeleteUserStatItems1' test.out

#- 82 PublicIncUserStatItem
# body param: body
echo '{"inc": 0.6043800257042612}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicIncUserStatItem \
    --namespace $AB_NAMESPACE \
    --statCode '18FzHKAj' \
    --userId 'GbvxYcco' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 82 'PublicIncUserStatItem' test.out

#- 83 PublicIncUserStatItemValue
# body param: body
echo '{"inc": 0.3760399741578352}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicIncUserStatItemValue \
    --namespace $AB_NAMESPACE \
    --statCode 'Mk45A6WM' \
    --userId 'Sv4lHvmY' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 83 'PublicIncUserStatItemValue' test.out

#- 84 ResetUserStatItemValue1
$CLI_EXE \
    --sn social \
    --op ResetUserStatItemValue1 \
    --namespace $AB_NAMESPACE \
    --statCode 'mF2JjGsB' \
    --userId 'ZF8oHZoF' \
    > test.out 2>&1
eval_tap $? 84 'ResetUserStatItemValue1' test.out

#- 85 BulkUpdateUserStatItemV2
# body param: body
echo '[{"additionalData": {"pqH89hye": {}, "6tyHdwE7": {}, "UN4RwcgT": {}}, "additionalKey": "AWiVB9FQ", "statCode": "VmQexDXV", "updateStrategy": "MIN", "userId": "YfUPJvZ7", "value": 0.5142145391240329}, {"additionalData": {"SmxNC3yC": {}, "N4JV5hn9": {}, "ykAXQGyN": {}}, "additionalKey": "mFSSurHM", "statCode": "DkqOVdHJ", "updateStrategy": "MIN", "userId": "8YOyCyzF", "value": 0.10907365437993377}, {"additionalData": {"BqL0m8uo": {}, "6xNTPQUM": {}, "xHndzS03": {}}, "additionalKey": "qL2REwoj", "statCode": "OaEsKtNG", "updateStrategy": "MAX", "userId": "FsnMM97H", "value": 0.5336883672620086}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkUpdateUserStatItemV2 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 85 'BulkUpdateUserStatItemV2' test.out

#- 86 BulkFetchOrDefaultStatItems1
$CLI_EXE \
    --sn social \
    --op BulkFetchOrDefaultStatItems1 \
    --namespace $AB_NAMESPACE \
    --additionalKey '9nGAzygl' \
    --statCode 'lHdeEggH' \
    --userIds '["ZVjLyccJ", "FwtJB8zg", "Ezy1s8b0"]' \
    > test.out 2>&1
eval_tap $? 86 'BulkFetchOrDefaultStatItems1' test.out

#- 87 AdminListUsersStatItems
$CLI_EXE \
    --sn social \
    --op AdminListUsersStatItems \
    --namespace $AB_NAMESPACE \
    --userId 'EpSijDYS' \
    --additionalKey 'hvc8D74p' \
    --statCodes '["r0CPEziU", "9VFHYRI0", "NqZfDUlZ"]' \
    --tags '["UyJXCLqw", "za6zKDLW", "6R9MD8p5"]' \
    > test.out 2>&1
eval_tap $? 87 'AdminListUsersStatItems' test.out

#- 88 BulkUpdateUserStatItem
# body param: body
echo '[{"additionalData": {"pvzTTyN5": {}, "7D8JFnFv": {}, "f0WdfXLh": {}}, "statCode": "OJLPMt1q", "updateStrategy": "MIN", "value": 0.0641916809199532}, {"additionalData": {"Iu8ghpFE": {}, "sT01NzoP": {}, "gkXqvFv0": {}}, "statCode": "8bcjHnPp", "updateStrategy": "MAX", "value": 0.7436722350863014}, {"additionalData": {"XHqU9hdA": {}, "50Z2nxD4": {}, "vZyizRyd": {}}, "statCode": "vmhywVxE", "updateStrategy": "MIN", "value": 0.7690075556454018}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkUpdateUserStatItem \
    --namespace $AB_NAMESPACE \
    --userId 'kGY6h0Mr' \
    --additionalKey 'Ta1kTfBy' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 88 'BulkUpdateUserStatItem' test.out

#- 89 BulkResetUserStatItemValues
# body param: body
echo '[{"additionalData": {"cvak1JpD": {}, "voliAwIf": {}, "EMwFqD0f": {}}, "statCode": "aJsk7ZI2"}, {"additionalData": {"DQ8rhg1Z": {}, "ZC4a4gu1": {}, "GhM6Ljvr": {}}, "statCode": "BW4Cg0q3"}, {"additionalData": {"7Yvi4Mto": {}, "5G9j9nMQ": {}, "TU4nXapW": {}}, "statCode": "yCL6eeFu"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkResetUserStatItemValues \
    --namespace $AB_NAMESPACE \
    --userId 'Nptt7c2a' \
    --additionalKey 'OB640hj5' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 89 'BulkResetUserStatItemValues' test.out

#- 90 DeleteUserStatItems2
$CLI_EXE \
    --sn social \
    --op DeleteUserStatItems2 \
    --namespace $AB_NAMESPACE \
    --statCode 'P4QAyqwC' \
    --userId '8RYywDC2' \
    --additionalKey 'GDLsvWpN' \
    > test.out 2>&1
eval_tap $? 90 'DeleteUserStatItems2' test.out

#- 91 UpdateUserStatItemValue
# body param: body
echo '{"additionalData": {"11kOSFhu": {}, "p7h9QdDe": {}, "cIYZnKa1": {}}, "updateStrategy": "INCREMENT", "value": 0.8536575545610683}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op UpdateUserStatItemValue \
    --namespace $AB_NAMESPACE \
    --statCode 'nQCCxkae' \
    --userId '19hMquvW' \
    --additionalKey 'lFMqi4gr' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 91 'UpdateUserStatItemValue' test.out

#- 92 BulkUpdateUserStatItem1
# body param: body
echo '[{"additionalData": {"wf2tbNnq": {}, "lCbeCifc": {}, "o7L7CbwB": {}}, "additionalKey": "JRobKjNR", "statCode": "Nud1yKXb", "updateStrategy": "MIN", "userId": "R4snonDu", "value": 0.6339029892720305}, {"additionalData": {"KHnl24iE": {}, "oKMgZ1J7": {}, "IOfqEMeM": {}}, "additionalKey": "Ou1pia5V", "statCode": "61Jnjp8v", "updateStrategy": "OVERRIDE", "userId": "WIx3s8v9", "value": 0.9902821230367788}, {"additionalData": {"ypQALmDW": {}, "Khz31s5O": {}, "buCbdUHe": {}}, "additionalKey": "tEM1LyYt", "statCode": "hO65pqkI", "updateStrategy": "MIN", "userId": "GtpgHP7r", "value": 0.08248015603996162}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkUpdateUserStatItem1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 92 'BulkUpdateUserStatItem1' test.out

#- 93 PublicQueryUserStatItems2
$CLI_EXE \
    --sn social \
    --op PublicQueryUserStatItems2 \
    --namespace $AB_NAMESPACE \
    --userId 'GrMHmQEO' \
    --additionalKey 'NcVQLD5R' \
    --statCodes '["8Sw3urIe", "kuAoICQh", "b1Zo6HZs"]' \
    --tags '["ol2TsGJm", "MMxSERGN", "EF9QSxLU"]' \
    > test.out 2>&1
eval_tap $? 93 'PublicQueryUserStatItems2' test.out

#- 94 BulkUpdateUserStatItem2
# body param: body
echo '[{"additionalData": {"aBEzeH7o": {}, "w0cZoCPD": {}, "brbIJ92Y": {}}, "statCode": "uxIZzU6p", "updateStrategy": "MAX", "value": 0.5214683149470627}, {"additionalData": {"tj1wT5Tn": {}, "2WgGphoN": {}, "hS57ndGt": {}}, "statCode": "Q3t1fsXz", "updateStrategy": "MAX", "value": 0.06481122206177492}, {"additionalData": {"ELu4L2E2": {}, "5dKtH6gB": {}, "ZWiQmgyW": {}}, "statCode": "aXuGD3Pb", "updateStrategy": "INCREMENT", "value": 0.2743863155447658}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkUpdateUserStatItem2 \
    --namespace $AB_NAMESPACE \
    --userId 'NZWVThcn' \
    --additionalKey 'ZulkoxOR' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 94 'BulkUpdateUserStatItem2' test.out

#- 95 UpdateUserStatItemValue1
# body param: body
echo '{"additionalData": {"nMa4mnRU": {}, "uFuyW4VZ": {}, "2auxkU3k": {}}, "updateStrategy": "OVERRIDE", "value": 0.22280066812230848}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op UpdateUserStatItemValue1 \
    --namespace $AB_NAMESPACE \
    --statCode 'XMaq5b23' \
    --userId 'HWZwkXTZ' \
    --additionalKey 'IabvnJsu' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 95 'UpdateUserStatItemValue1' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE