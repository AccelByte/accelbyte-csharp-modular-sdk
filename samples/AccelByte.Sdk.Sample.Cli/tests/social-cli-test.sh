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
    --userId '3dxNtdFh' \
    > test.out 2>&1
eval_tap $? 8 'GetUserProfiles' test.out

#- 9 GetProfile
$CLI_EXE \
    --sn social \
    --op GetProfile \
    --namespace $AB_NAMESPACE \
    --profileId 'JxXGABH4' \
    --userId 'RGICsrlT' \
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
    --userIds '["Z3J4G2Xs", "6OmHL8hi", "faCmOFgi"]' \
    > test.out 2>&1
eval_tap $? 12 'PublicGetUserGameProfiles' test.out

#- 13 PublicGetUserProfiles
$CLI_EXE \
    --sn social \
    --op PublicGetUserProfiles \
    --namespace $AB_NAMESPACE \
    --userId 'sbXz7c0e' \
    > test.out 2>&1
eval_tap $? 13 'PublicGetUserProfiles' test.out

#- 14 PublicCreateProfile
# body param: body
echo '{"achievements": ["XzKYVh0O", "YDJb7gbT", "CcqrJ0VN"], "attributes": {"DmxhPfSR": "92ORjGwo", "ilSg3xp8": "9GpPblxm", "bYh1G5GQ": "1IzMg9lz"}, "avatarUrl": "BBcUuGZF", "inventories": ["l32WGk2w", "V2utggZw", "XvroXgin"], "label": "9dwktM3E", "profileName": "7idOOry0", "statistics": ["zrMimuez", "O60IoNv0", "TPRAgYvp"], "tags": ["tjdXMzDa", "CU7k3YPT", "Ht3JUOBZ"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicCreateProfile \
    --namespace $AB_NAMESPACE \
    --userId 'qTZ6b5La' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 14 'PublicCreateProfile' test.out

#- 15 PublicGetProfile
$CLI_EXE \
    --sn social \
    --op PublicGetProfile \
    --namespace $AB_NAMESPACE \
    --profileId 'NOsM4zZ6' \
    --userId 'OVLm6A7d' \
    > test.out 2>&1
eval_tap $? 15 'PublicGetProfile' test.out

#- 16 PublicUpdateProfile
# body param: body
echo '{"achievements": ["qZsvLhMO", "Qu6hPKBN", "JYG0UY4v"], "attributes": {"GVIYEf1r": "lYGnuVNV", "mWlE5h3x": "4YUw71nD", "6wWxOxpr": "XDC7bEov"}, "avatarUrl": "uYXrxjXD", "inventories": ["n1modEm2", "bfNxR5JN", "e846d3Nk"], "label": "0d6NPZiV", "profileName": "HJ8iSslM", "statistics": ["Q5WkKJN4", "eqFDdVD3", "lY8hdhkf"], "tags": ["lkDryP1h", "vR2PoMhg", "jM9Jzr1d"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicUpdateProfile \
    --namespace $AB_NAMESPACE \
    --profileId 'aq4CbcAr' \
    --userId 'qPf7llYV' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 16 'PublicUpdateProfile' test.out

#- 17 PublicDeleteProfile
$CLI_EXE \
    --sn social \
    --op PublicDeleteProfile \
    --namespace $AB_NAMESPACE \
    --profileId 'cCNebqkc' \
    --userId 'yhRL1X2V' \
    > test.out 2>&1
eval_tap $? 17 'PublicDeleteProfile' test.out

#- 18 PublicGetProfileAttribute
$CLI_EXE \
    --sn social \
    --op PublicGetProfileAttribute \
    --attributeName 'ejhk31pY' \
    --namespace $AB_NAMESPACE \
    --profileId 'CMRwehrw' \
    --userId 'HxSjxk7l' \
    > test.out 2>&1
eval_tap $? 18 'PublicGetProfileAttribute' test.out

#- 19 PublicUpdateAttribute
# body param: body
echo '{"name": "b5pjNswE", "value": "biE891VF"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicUpdateAttribute \
    --attributeName '6w25vQMF' \
    --namespace $AB_NAMESPACE \
    --profileId 'F5SXOr1Z' \
    --userId 'CzfkVKBj' \
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
    --limit '19' \
    --offset '58' \
    --statCodes 'JLgNdwpM' \
    > test.out 2>&1
eval_tap $? 26 'GetGlobalStatItems' test.out

#- 27 GetGlobalStatItemByStatCode
$CLI_EXE \
    --sn social \
    --op GetGlobalStatItemByStatCode \
    --namespace $AB_NAMESPACE \
    --statCode 'vVBCO8YP' \
    > test.out 2>&1
eval_tap $? 27 'GetGlobalStatItemByStatCode' test.out

#- 28 GetStatCycles
$CLI_EXE \
    --sn social \
    --op GetStatCycles \
    --namespace $AB_NAMESPACE \
    --cycleType 'MONTHLY' \
    --limit '33' \
    --name 'iTwtZl1h' \
    --offset '72' \
    --sortBy 'VriXq8G0' \
    --status 'STOPPED' \
    > test.out 2>&1
eval_tap $? 28 'GetStatCycles' test.out

#- 29 CreateStatCycle
# body param: body
echo '{"cycleType": "ANNUALLY", "description": "SxoxXGzC", "end": "1992-07-20T00:00:00Z", "name": "2vFkuD5i", "resetDate": 19, "resetDay": 6, "resetMonth": 34, "resetTime": "BysM478n", "seasonPeriod": 50, "start": "1976-08-25T00:00:00Z"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op CreateStatCycle \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 29 'CreateStatCycle' test.out

#- 30 BulkGetStatCycle
# body param: body
echo '{"cycleIds": ["PBmogUDj", "hcz6mBoL", "vpO8YhDv"]}' > $TEMP_JSON_INPUT
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
    --upload file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 32 'ImportStatCycle' test.out

#- 33 GetStatCycle
$CLI_EXE \
    --sn social \
    --op GetStatCycle \
    --cycleId 'rsrsPCGz' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 33 'GetStatCycle' test.out

#- 34 UpdateStatCycle
# body param: body
echo '{"cycleType": "DAILY", "description": "r0wZqlJH", "end": "1999-08-05T00:00:00Z", "name": "W9lspWts", "resetDate": 7, "resetDay": 89, "resetMonth": 89, "resetTime": "xu0jkfHp", "seasonPeriod": 89, "start": "1996-01-26T00:00:00Z"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op UpdateStatCycle \
    --cycleId 'tNEeUadA' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 34 'UpdateStatCycle' test.out

#- 35 DeleteStatCycle
$CLI_EXE \
    --sn social \
    --op DeleteStatCycle \
    --cycleId 'k9L0btJ1' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 35 'DeleteStatCycle' test.out

#- 36 BulkAddStats
# body param: body
echo '{"statCodes": ["Ne2HBK7W", "I0UTunuf", "5Tj2Y4O9"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkAddStats \
    --cycleId 'eSRzpTHo' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 36 'BulkAddStats' test.out

#- 37 StopStatCycle
$CLI_EXE \
    --sn social \
    --op StopStatCycle \
    --cycleId 'RlF8fUGM' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 37 'StopStatCycle' test.out

#- 38 BulkFetchStatItems
$CLI_EXE \
    --sn social \
    --op BulkFetchStatItems \
    --namespace $AB_NAMESPACE \
    --statCode 'wuGt43ys' \
    --userIds 'ahYlHhmv' \
    > test.out 2>&1
eval_tap $? 38 'BulkFetchStatItems' test.out

#- 39 BulkIncUserStatItem
# body param: body
echo '[{"inc": 0.03632045859487276, "statCode": "2ynpH2Hv", "userId": "d8HqwwIv"}, {"inc": 0.5781989555345598, "statCode": "C8az1ko5", "userId": "5oDLpX9L"}, {"inc": 0.6213799739211412, "statCode": "3I9RbcOJ", "userId": "4HPXI88b"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkIncUserStatItem \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 39 'BulkIncUserStatItem' test.out

#- 40 BulkIncUserStatItemValue
# body param: body
echo '[{"inc": 0.705036110837382, "statCode": "QWywqUqV", "userId": "VUjvZowF"}, {"inc": 0.5670431218134183, "statCode": "55wQOnLG", "userId": "hKY9lyjW"}, {"inc": 0.9937741961519745, "statCode": "eAMrSBUs", "userId": "5lSAUa4P"}]' > $TEMP_JSON_INPUT
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
    --statCode 'p583ZeQ9' \
    --userIds '["f2DPbHkG", "pdARN5cC", "NGBql3DQ"]' \
    > test.out 2>&1
eval_tap $? 41 'BulkFetchOrDefaultStatItems' test.out

#- 42 BulkResetUserStatItem
# body param: body
echo '[{"statCode": "3O5iTm1X", "userId": "JXmNn1sL"}, {"statCode": "DaSpEHJc", "userId": "yleXrny5"}, {"statCode": "bQBKvjof", "userId": "veqGa1w5"}]' > $TEMP_JSON_INPUT
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
    --cycleIds '3sCw5pfB' \
    --isGlobal 'false' \
    --isPublic 'true' \
    --limit '0' \
    --offset '81' \
    > test.out 2>&1
eval_tap $? 43 'GetStats' test.out

#- 44 CreateStat
# body param: body
echo '{"cycleIds": ["4Sl53iXk", "AjUDvYuB", "mhz6R2ml"], "defaultValue": 0.8712715902316738, "description": "LMVxOiHR", "globalAggregationMethod": "TOTAL", "ignoreAdditionalDataOnValueRejected": false, "incrementOnly": false, "isPublic": true, "maximum": 0.17567430452267885, "minimum": 0.6670152419728943, "name": "YJe6g0ju", "setAsGlobal": true, "setBy": "SERVER", "statCode": "veos4fks", "tags": ["PkEC0S6E", "5OTrE6g1", "fBA37dBg"]}' > $TEMP_JSON_INPUT
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
    --isPublic 'true' \
    --limit '47' \
    --offset '9' \
    --keyword 'CRmYOwRg' \
    > test.out 2>&1
eval_tap $? 47 'QueryStats' test.out

#- 48 GetStat
$CLI_EXE \
    --sn social \
    --op GetStat \
    --namespace $AB_NAMESPACE \
    --statCode 'Yz2n5PD0' \
    > test.out 2>&1
eval_tap $? 48 'GetStat' test.out

#- 49 DeleteStat
$CLI_EXE \
    --sn social \
    --op DeleteStat \
    --namespace $AB_NAMESPACE \
    --statCode 'f5FpIgWa' \
    > test.out 2>&1
eval_tap $? 49 'DeleteStat' test.out

#- 50 UpdateStat
# body param: body
echo '{"cycleIds": ["OTl2XJoe", "L2OrNqgA", "ZbNeqG1f"], "defaultValue": 0.8379663579852039, "description": "lXizyUKv", "globalAggregationMethod": "TOTAL", "ignoreAdditionalDataOnValueRejected": false, "isPublic": false, "name": "wxmghYXC", "tags": ["nPSyetXi", "vh0v2kYG", "vFNh7iNw"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op UpdateStat \
    --namespace $AB_NAMESPACE \
    --statCode 'Ut7Jc3ZZ' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 50 'UpdateStat' test.out

#- 51 GetStatItems
$CLI_EXE \
    --sn social \
    --op GetStatItems \
    --namespace $AB_NAMESPACE \
    --statCode 'oJiFRDQl' \
    --limit '18' \
    --offset '41' \
    --sortBy 'chV2P3i2' \
    > test.out 2>&1
eval_tap $? 51 'GetStatItems' test.out

#- 52 DeleteTiedStat
$CLI_EXE \
    --sn social \
    --op DeleteTiedStat \
    --namespace $AB_NAMESPACE \
    --statCode 'gvLswYqm' \
    > test.out 2>&1
eval_tap $? 52 'DeleteTiedStat' test.out

#- 53 GetUserStatCycleItems
$CLI_EXE \
    --sn social \
    --op GetUserStatCycleItems \
    --cycleId '1jeLo3ws' \
    --namespace $AB_NAMESPACE \
    --userId 'JNN4q7km' \
    --isPublic 'false' \
    --limit '28' \
    --offset '72' \
    --sortBy 'jOX1ktk6' \
    --statCodes '6O0LLSHu' \
    > test.out 2>&1
eval_tap $? 53 'GetUserStatCycleItems' test.out

#- 54 GetUserStatItems
$CLI_EXE \
    --sn social \
    --op GetUserStatItems \
    --namespace $AB_NAMESPACE \
    --userId 'sMbKhikN' \
    --isPublic 'true' \
    --limit '90' \
    --offset '12' \
    --sortBy 'viND9jAz' \
    --statCodes '46XWaRpe' \
    --tags 'QkDGyyRl' \
    > test.out 2>&1
eval_tap $? 54 'GetUserStatItems' test.out

#- 55 BulkCreateUserStatItems
# body param: body
echo '[{"statCode": "iBmRODD8"}, {"statCode": "2YLopbDu"}, {"statCode": "HTZkTgjC"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkCreateUserStatItems \
    --namespace $AB_NAMESPACE \
    --userId 'zQ06Z1Km' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 55 'BulkCreateUserStatItems' test.out

#- 56 BulkIncUserStatItem1
# body param: body
echo '[{"inc": 0.30068160553662004, "statCode": "9a4oe96j"}, {"inc": 0.9392758153841999, "statCode": "SNsHTKPS"}, {"inc": 0.034378143005975526, "statCode": "v3kbXROr"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkIncUserStatItem1 \
    --namespace $AB_NAMESPACE \
    --userId 'sjfu74zt' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 56 'BulkIncUserStatItem1' test.out

#- 57 BulkIncUserStatItemValue1
# body param: body
echo '[{"inc": 0.5940668180498399, "statCode": "teXZShnk"}, {"inc": 0.8320691141306905, "statCode": "5xm8vdGb"}, {"inc": 0.7836052442748681, "statCode": "rzdPU3aV"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkIncUserStatItemValue1 \
    --namespace $AB_NAMESPACE \
    --userId 'fXqXT7Z4' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 57 'BulkIncUserStatItemValue1' test.out

#- 58 BulkResetUserStatItem1
# body param: body
echo '[{"statCode": "pC4XvjdW"}, {"statCode": "J1O1ZZFK"}, {"statCode": "n6tOjfAB"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkResetUserStatItem1 \
    --namespace $AB_NAMESPACE \
    --userId 'ufvhL6WU' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 58 'BulkResetUserStatItem1' test.out

#- 59 CreateUserStatItem
$CLI_EXE \
    --sn social \
    --op CreateUserStatItem \
    --namespace $AB_NAMESPACE \
    --statCode 'NomF5rYh' \
    --userId 'Ke2nEd9m' \
    > test.out 2>&1
eval_tap $? 59 'CreateUserStatItem' test.out

#- 60 DeleteUserStatItems
$CLI_EXE \
    --sn social \
    --op DeleteUserStatItems \
    --namespace $AB_NAMESPACE \
    --statCode 'tzjD6mDi' \
    --userId 'FUR0zvEh' \
    > test.out 2>&1
eval_tap $? 60 'DeleteUserStatItems' test.out

#- 61 IncUserStatItemValue
# body param: body
echo '{"inc": 0.7058867250642773}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op IncUserStatItemValue \
    --namespace $AB_NAMESPACE \
    --statCode 'q59N79W1' \
    --userId 'ISw3O6nu' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 61 'IncUserStatItemValue' test.out

#- 62 ResetUserStatItemValue
# body param: body
echo '{"additionalData": {"Is6MSmSs": {}, "0g2sDlfr": {}, "acipun30": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op ResetUserStatItemValue \
    --namespace $AB_NAMESPACE \
    --statCode 'mZG7VvYr' \
    --userId 'cagvO7ji' \
    --additionalKey 'NVfZFLGi' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 62 'ResetUserStatItemValue' test.out

#- 63 GetGlobalStatItems1
$CLI_EXE \
    --sn social \
    --op GetGlobalStatItems1 \
    --namespace $AB_NAMESPACE \
    --limit '58' \
    --offset '2' \
    --statCodes 'cexbOGWb' \
    > test.out 2>&1
eval_tap $? 63 'GetGlobalStatItems1' test.out

#- 64 GetGlobalStatItemByStatCode1
$CLI_EXE \
    --sn social \
    --op GetGlobalStatItemByStatCode1 \
    --namespace $AB_NAMESPACE \
    --statCode 'jFTLchSa' \
    > test.out 2>&1
eval_tap $? 64 'GetGlobalStatItemByStatCode1' test.out

#- 65 GetStatCycles1
$CLI_EXE \
    --sn social \
    --op GetStatCycles1 \
    --namespace $AB_NAMESPACE \
    --cycleType 'ANNUALLY' \
    --limit '7' \
    --name 'iJtxfpkx' \
    --offset '80' \
    --sortBy 'jzbrtJbS' \
    --status 'INIT' \
    > test.out 2>&1
eval_tap $? 65 'GetStatCycles1' test.out

#- 66 BulkGetStatCycle1
# body param: body
echo '{"cycleIds": ["mkvUYshp", "dcGhPB39", "IuaRSQoM"]}' > $TEMP_JSON_INPUT
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
    --cycleId '2cDdht7m' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 67 'GetStatCycle1' test.out

#- 68 BulkFetchStatItems1
$CLI_EXE \
    --sn social \
    --op BulkFetchStatItems1 \
    --namespace $AB_NAMESPACE \
    --statCode 'xOc8P0sF' \
    --userIds 'bfJI76vN' \
    > test.out 2>&1
eval_tap $? 68 'BulkFetchStatItems1' test.out

#- 69 PublicBulkIncUserStatItem
# body param: body
echo '[{"inc": 0.5482606030368506, "statCode": "qxfLRUKV", "userId": "06Jz1KhW"}, {"inc": 0.4940981350622238, "statCode": "CxFgs9cZ", "userId": "eY6ttcem"}, {"inc": 0.9890343553459124, "statCode": "PriM0dgh", "userId": "v0oUFI43"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicBulkIncUserStatItem \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 69 'PublicBulkIncUserStatItem' test.out

#- 70 PublicBulkIncUserStatItemValue
# body param: body
echo '[{"inc": 0.06906364405209675, "statCode": "OOi4tYuX", "userId": "ubGIR7uc"}, {"inc": 0.7471454441542347, "statCode": "zkMAGIld", "userId": "Ysq2w0IR"}, {"inc": 0.4624688133762228, "statCode": "Kl8NTLKU", "userId": "AWAXjr3Q"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicBulkIncUserStatItemValue \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 70 'PublicBulkIncUserStatItemValue' test.out

#- 71 BulkResetUserStatItem2
# body param: body
echo '[{"statCode": "LVBE6FDi", "userId": "ygxFxgDb"}, {"statCode": "6n5TWnvS", "userId": "sTvcz9MX"}, {"statCode": "rLEknUTB", "userId": "738jpLgc"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkResetUserStatItem2 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 71 'BulkResetUserStatItem2' test.out

#- 72 CreateStat1
# body param: body
echo '{"cycleIds": ["x48dctNN", "BAWpOpdD", "nxSuBAga"], "defaultValue": 0.522785731732651, "description": "WiGnhhpD", "globalAggregationMethod": "MAX", "ignoreAdditionalDataOnValueRejected": false, "incrementOnly": false, "isPublic": true, "maximum": 0.9278738851292538, "minimum": 0.43475483133433557, "name": "cTVcbC2n", "setAsGlobal": true, "setBy": "SERVER", "statCode": "EDY9KyxG", "tags": ["suLQdU8V", "SjJC02Um", "Bne4m5Z6"]}' > $TEMP_JSON_INPUT
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
    --cycleId 'zEbK4q3g' \
    --namespace $AB_NAMESPACE \
    --limit '63' \
    --offset '38' \
    --sortBy 'IQsnedsH' \
    --statCodes '["6XgpYqov", "UFk3jDm4", "zaC1JwzU"]' \
    > test.out 2>&1
eval_tap $? 73 'PublicListMyStatCycleItems' test.out

#- 74 PublicListMyStatItems
$CLI_EXE \
    --sn social \
    --op PublicListMyStatItems \
    --namespace $AB_NAMESPACE \
    --limit '0' \
    --offset '35' \
    --sortBy 'zQ8Yu9hD' \
    --statCodes '["05DFxORf", "gu2wyxUi", "rUQT2HTQ"]' \
    --tags '["cxBkRHbr", "P2yygTsy", "Pv1Tdyvc"]' \
    > test.out 2>&1
eval_tap $? 74 'PublicListMyStatItems' test.out

#- 75 PublicListAllMyStatItems
$CLI_EXE \
    --sn social \
    --op PublicListAllMyStatItems \
    --namespace $AB_NAMESPACE \
    --additionalKey 'i6B2d0TT' \
    --statCodes '["DjbPW8ho", "MQ8OgVJa", "RCJB2zxz"]' \
    --tags '["DnqlI31N", "hWaVXQIS", "JwPVaUda"]' \
    > test.out 2>&1
eval_tap $? 75 'PublicListAllMyStatItems' test.out

#- 76 GetUserStatCycleItems1
$CLI_EXE \
    --sn social \
    --op GetUserStatCycleItems1 \
    --cycleId 'KoWmGo0j' \
    --namespace $AB_NAMESPACE \
    --userId 'AB0CHlMU' \
    --limit '31' \
    --offset '32' \
    --sortBy 'hiaHMTqS' \
    --statCodes '2RpwgCZp' \
    > test.out 2>&1
eval_tap $? 76 'GetUserStatCycleItems1' test.out

#- 77 PublicQueryUserStatItems
$CLI_EXE \
    --sn social \
    --op PublicQueryUserStatItems \
    --namespace $AB_NAMESPACE \
    --userId 's9jThK0n' \
    --limit '14' \
    --offset '38' \
    --sortBy 'dSZ8bmBr' \
    --statCodes 'sPOGYgi2' \
    --tags 'zU9F3aOU' \
    > test.out 2>&1
eval_tap $? 77 'PublicQueryUserStatItems' test.out

#- 78 PublicBulkCreateUserStatItems
# body param: body
echo '[{"statCode": "KRbRAnDJ"}, {"statCode": "LHtdCPv1"}, {"statCode": "hwCKApXM"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicBulkCreateUserStatItems \
    --namespace $AB_NAMESPACE \
    --userId 'cbA6QVZ9' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 78 'PublicBulkCreateUserStatItems' test.out

#- 79 PublicQueryUserStatItems1
$CLI_EXE \
    --sn social \
    --op PublicQueryUserStatItems1 \
    --namespace $AB_NAMESPACE \
    --userId 'JGqcLnA7' \
    --additionalKey 'A6myapo0' \
    --statCodes '["zGL2JRuB", "NNZBaGyw", "JrnXHfoQ"]' \
    --tags '["A9dJ7kU5", "71oT1HwW", "w2wLFlXu"]' \
    > test.out 2>&1
eval_tap $? 79 'PublicQueryUserStatItems1' test.out

#- 80 PublicBulkIncUserStatItem1
# body param: body
echo '[{"inc": 0.46833683260103265, "statCode": "TYy8HOQG"}, {"inc": 0.9272995098829162, "statCode": "JD0H00Dw"}, {"inc": 0.14960222077285534, "statCode": "EXj4SXA0"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicBulkIncUserStatItem1 \
    --namespace $AB_NAMESPACE \
    --userId '5S6e6xHV' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 80 'PublicBulkIncUserStatItem1' test.out

#- 81 BulkIncUserStatItemValue2
# body param: body
echo '[{"inc": 0.6958277230027297, "statCode": "LjJ44dUS"}, {"inc": 0.3189370477261583, "statCode": "qEwWCGZF"}, {"inc": 0.1175832682686263, "statCode": "ZgVKeU97"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkIncUserStatItemValue2 \
    --namespace $AB_NAMESPACE \
    --userId 'BoK1P6l3' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 81 'BulkIncUserStatItemValue2' test.out

#- 82 BulkResetUserStatItem3
# body param: body
echo '[{"statCode": "LUbXifOP"}, {"statCode": "kYfRo2Fc"}, {"statCode": "2xDk4Ipf"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkResetUserStatItem3 \
    --namespace $AB_NAMESPACE \
    --userId 'A3mn0f02' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 82 'BulkResetUserStatItem3' test.out

#- 83 PublicCreateUserStatItem
$CLI_EXE \
    --sn social \
    --op PublicCreateUserStatItem \
    --namespace $AB_NAMESPACE \
    --statCode 'Q2IJrKrt' \
    --userId 'TiYpcoL0' \
    > test.out 2>&1
eval_tap $? 83 'PublicCreateUserStatItem' test.out

#- 84 DeleteUserStatItems1
$CLI_EXE \
    --sn social \
    --op DeleteUserStatItems1 \
    --namespace $AB_NAMESPACE \
    --statCode 'aK9JrzEk' \
    --userId 'zAWFXbm1' \
    > test.out 2>&1
eval_tap $? 84 'DeleteUserStatItems1' test.out

#- 85 PublicIncUserStatItem
# body param: body
echo '{"inc": 0.6354843338102935}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicIncUserStatItem \
    --namespace $AB_NAMESPACE \
    --statCode 'GY2dzcBH' \
    --userId '2GVMP3zu' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 85 'PublicIncUserStatItem' test.out

#- 86 PublicIncUserStatItemValue
# body param: body
echo '{"inc": 0.8107275336966744}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicIncUserStatItemValue \
    --namespace $AB_NAMESPACE \
    --statCode 'zs6wKE6k' \
    --userId 'lTaNrYdj' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 86 'PublicIncUserStatItemValue' test.out

#- 87 ResetUserStatItemValue1
$CLI_EXE \
    --sn social \
    --op ResetUserStatItemValue1 \
    --namespace $AB_NAMESPACE \
    --statCode 'ODewzOqP' \
    --userId 'NbbVo3AK' \
    > test.out 2>&1
eval_tap $? 87 'ResetUserStatItemValue1' test.out

#- 88 BulkUpdateUserStatItemV2
# body param: body
echo '[{"additionalData": {"IoqUX4Rw": {}, "yHGrmwE9": {}, "2nuI8AHi": {}}, "additionalKey": "2WQjTdeF", "statCode": "AMEmtYvs", "updateStrategy": "OVERRIDE", "userId": "UoFytvSz", "value": 0.5525758497319446}, {"additionalData": {"MvfRV7QC": {}, "Wc11A9p5": {}, "IzqK8PRp": {}}, "additionalKey": "bYErJ9yv", "statCode": "5jWLVd9J", "updateStrategy": "INCREMENT", "userId": "wWSNfkEM", "value": 0.15518696305508262}, {"additionalData": {"L2KUXgOL": {}, "xTvqAHL4": {}, "Kpmd0E9e": {}}, "additionalKey": "C9IHDkEM", "statCode": "OpuGYwKH", "updateStrategy": "MIN", "userId": "kUjsGk54", "value": 0.29189616985078815}]' > $TEMP_JSON_INPUT
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
    --additionalKey 'A7exSQRg' \
    --statCode '5kXkn0Il' \
    --userIds '["KkHW9vZn", "HlNyGOP7", "0mIHd2Aj"]' \
    > test.out 2>&1
eval_tap $? 89 'BulkFetchOrDefaultStatItems1' test.out

#- 90 AdminListUsersStatItems
$CLI_EXE \
    --sn social \
    --op AdminListUsersStatItems \
    --namespace $AB_NAMESPACE \
    --userId 'GZvp3buY' \
    --additionalKey 'gYwB06KG' \
    --statCodes '["f4v6Nbgm", "KX1G2phX", "8QZUjJp1"]' \
    --tags '["bsRmGkBF", "qbXLG0Re", "PBDc2eoL"]' \
    > test.out 2>&1
eval_tap $? 90 'AdminListUsersStatItems' test.out

#- 91 BulkUpdateUserStatItem
# body param: body
echo '[{"additionalData": {"2F7ZZNyb": {}, "clIpR86Z": {}, "c1OeiaZM": {}}, "statCode": "wjhBq3mP", "updateStrategy": "INCREMENT", "value": 0.953713347014649}, {"additionalData": {"j7hmg4kB": {}, "lP9A4vOG": {}, "AGRwXk8d": {}}, "statCode": "JW6KOKK5", "updateStrategy": "MIN", "value": 0.1578025814264431}, {"additionalData": {"eipRNQLc": {}, "Q48olwTo": {}, "AsYfwJe1": {}}, "statCode": "uIodBNmc", "updateStrategy": "OVERRIDE", "value": 0.16190963710857054}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkUpdateUserStatItem \
    --namespace $AB_NAMESPACE \
    --userId 'LhfjSoBl' \
    --additionalKey 'C0bBYZu7' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 91 'BulkUpdateUserStatItem' test.out

#- 92 BulkResetUserStatItemValues
# body param: body
echo '[{"additionalData": {"BEDXCiFC": {}, "76jSbmcZ": {}, "qpIcHCsj": {}}, "statCode": "1WuHUGCN"}, {"additionalData": {"1LJEhZXv": {}, "w3lpr2YW": {}, "6WcdgSqj": {}}, "statCode": "Wn1qoCcc"}, {"additionalData": {"n1JK2PwH": {}, "R8UnwaRf": {}, "1YK5v63a": {}}, "statCode": "bdAE9aOo"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkResetUserStatItemValues \
    --namespace $AB_NAMESPACE \
    --userId '0H7ecUQX' \
    --additionalKey 'UeXheUuD' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 92 'BulkResetUserStatItemValues' test.out

#- 93 DeleteUserStatItems2
$CLI_EXE \
    --sn social \
    --op DeleteUserStatItems2 \
    --namespace $AB_NAMESPACE \
    --statCode 'ehFVa6K1' \
    --userId 'HOQhsPsf' \
    --additionalKey 'HB4cHVBs' \
    > test.out 2>&1
eval_tap $? 93 'DeleteUserStatItems2' test.out

#- 94 UpdateUserStatItemValue
# body param: body
echo '{"additionalData": {"Kk3t8YHL": {}, "onB1K9qM": {}, "PGmMTrbF": {}}, "updateStrategy": "OVERRIDE", "value": 0.38672854532207834}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op UpdateUserStatItemValue \
    --namespace $AB_NAMESPACE \
    --statCode 'yDeJUOvs' \
    --userId 'p2qPnm01' \
    --additionalKey 'dL1kggIW' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 94 'UpdateUserStatItemValue' test.out

#- 95 BulkUpdateUserStatItem1
# body param: body
echo '[{"additionalData": {"PzUkxpy3": {}, "J2vuaHpx": {}, "yv4l360s": {}}, "additionalKey": "nTYOH6Wq", "statCode": "1ldGFRx0", "updateStrategy": "MAX", "userId": "prVyZe8N", "value": 0.38157746972884454}, {"additionalData": {"Z2qDV4lq": {}, "eHekkWJh": {}, "hrvtcXYQ": {}}, "additionalKey": "IFVqgz9X", "statCode": "okk6fZkn", "updateStrategy": "MAX", "userId": "VWXk57By", "value": 0.17593288359627257}, {"additionalData": {"0BZpgiI1": {}, "YNaf6gM0": {}, "D9AnmD0S": {}}, "additionalKey": "LE0loocL", "statCode": "sBrosOZa", "updateStrategy": "MAX", "userId": "DJfsWFYC", "value": 0.4755801077692341}]' > $TEMP_JSON_INPUT
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
    --userId 'lGeXFg6K' \
    --additionalKey 'WbwqPuCO' \
    --statCodes '["ZFBmc8wp", "ZrhjHHBO", "j62joyqD"]' \
    --tags '["vwE7Pvqi", "UP2rtRWF", "r8JmcgBS"]' \
    > test.out 2>&1
eval_tap $? 96 'PublicQueryUserStatItems2' test.out

#- 97 BulkUpdateUserStatItem2
# body param: body
echo '[{"additionalData": {"JvCrcU7j": {}, "yF11G73a": {}, "m5817ePQ": {}}, "statCode": "mPwB67UX", "updateStrategy": "MIN", "value": 0.3840382559663217}, {"additionalData": {"SYwvhUPZ": {}, "oTX6xsnJ": {}, "wyAY9SqI": {}}, "statCode": "Zb8Ztymf", "updateStrategy": "INCREMENT", "value": 0.9940521108594137}, {"additionalData": {"6E1aKgZv": {}, "a5y2ZAW8": {}, "ZwI67kl0": {}}, "statCode": "3SJ1q7Lr", "updateStrategy": "MIN", "value": 0.9839709269577022}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkUpdateUserStatItem2 \
    --namespace $AB_NAMESPACE \
    --userId 'Rp7J3XlU' \
    --additionalKey 'Z9fGlnqq' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 97 'BulkUpdateUserStatItem2' test.out

#- 98 UpdateUserStatItemValue1
# body param: body
echo '{"additionalData": {"vUWQFMNh": {}, "DTl2rjIs": {}, "q63Hi7NB": {}}, "updateStrategy": "INCREMENT", "value": 0.052676856287508844}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op UpdateUserStatItemValue1 \
    --namespace $AB_NAMESPACE \
    --statCode 'R8PdgQ4N' \
    --userId 'eyt4RJLB' \
    --additionalKey 'ThcQEJ9O' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 98 'UpdateUserStatItemValue1' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE