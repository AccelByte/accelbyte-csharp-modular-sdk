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
    --userId 'XMBo6j5n' \
    > test.out 2>&1
eval_tap $? 8 'GetUserProfiles' test.out

#- 9 GetProfile
$CLI_EXE \
    --sn social \
    --op GetProfile \
    --namespace $AB_NAMESPACE \
    --profileId 'IJBtJAYc' \
    --userId 'JJZAttEj' \
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
    --userIds '["XYUdgRyO", "ybGXca8N", "wul9UKKu"]' \
    > test.out 2>&1
eval_tap $? 12 'PublicGetUserGameProfiles' test.out

#- 13 PublicGetUserProfiles
$CLI_EXE \
    --sn social \
    --op PublicGetUserProfiles \
    --namespace $AB_NAMESPACE \
    --userId 'lWFhVmdD' \
    > test.out 2>&1
eval_tap $? 13 'PublicGetUserProfiles' test.out

#- 14 PublicCreateProfile
# body param: body
echo '{"achievements": ["OPzYC4D5", "VeSuGw2o", "CO6Lxlcq"], "attributes": {"1gNa6Wqx": "CxWd97Cp", "iIPz3YeN": "H1hdoGXI", "30lmUqYk": "sSTNlJex"}, "avatarUrl": "TzEMyYwR", "inventories": ["Kw8PYhKU", "VTSsgPML", "8BdhtYGY"], "label": "4EhwoCko", "profileName": "sybPoSXT", "statistics": ["IPTftMBn", "ZNcvXDa7", "NzikUJ4h"], "tags": ["Iu9gOnpw", "bOBT5AyQ", "yZEmS9C0"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicCreateProfile \
    --namespace $AB_NAMESPACE \
    --userId '0V2In9yq' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 14 'PublicCreateProfile' test.out

#- 15 PublicGetProfile
$CLI_EXE \
    --sn social \
    --op PublicGetProfile \
    --namespace $AB_NAMESPACE \
    --profileId '5aMCb6pz' \
    --userId '9Qh52J1U' \
    > test.out 2>&1
eval_tap $? 15 'PublicGetProfile' test.out

#- 16 PublicUpdateProfile
# body param: body
echo '{"achievements": ["ZqB3Tdn4", "Ro2Vx6Wz", "cg6egNqI"], "attributes": {"bmM2lPYq": "fQuZbfqN", "iHinqW2t": "97Xo9d3t", "eIPM4kvl": "Vxn0Rd9N"}, "avatarUrl": "J6YvqWJc", "inventories": ["GRlXYLM9", "yAaW5AFv", "c2ORFCYk"], "label": "aVRIzETr", "profileName": "fXBMBjwp", "statistics": ["VGtRmsUs", "Fjrw3qbF", "oYv0WnxY"], "tags": ["ncEFHqPI", "1BR47oTT", "eXBSxx06"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicUpdateProfile \
    --namespace $AB_NAMESPACE \
    --profileId 'pLKAmDNo' \
    --userId 'ieC5UJQe' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 16 'PublicUpdateProfile' test.out

#- 17 PublicDeleteProfile
$CLI_EXE \
    --sn social \
    --op PublicDeleteProfile \
    --namespace $AB_NAMESPACE \
    --profileId 'vLC28zhM' \
    --userId 'qhqYGVNy' \
    > test.out 2>&1
eval_tap $? 17 'PublicDeleteProfile' test.out

#- 18 PublicGetProfileAttribute
$CLI_EXE \
    --sn social \
    --op PublicGetProfileAttribute \
    --attributeName 'UNCC3mGt' \
    --namespace $AB_NAMESPACE \
    --profileId 'ChYRztVY' \
    --userId '7ckosbsd' \
    > test.out 2>&1
eval_tap $? 18 'PublicGetProfileAttribute' test.out

#- 19 PublicUpdateAttribute
# body param: body
echo '{"name": "NgWcA9jr", "value": "eUVvDpki"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicUpdateAttribute \
    --attributeName 'bZy9rSxW' \
    --namespace $AB_NAMESPACE \
    --profileId 'hkSDbAU3' \
    --userId 'eRqO81iE' \
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
    --limit '1' \
    --offset '41' \
    --statCodes 'MlGzLHPQ' \
    > test.out 2>&1
eval_tap $? 26 'GetGlobalStatItems' test.out

#- 27 GetGlobalStatItemByStatCode
$CLI_EXE \
    --sn social \
    --op GetGlobalStatItemByStatCode \
    --namespace $AB_NAMESPACE \
    --statCode 'pdXXxEGA' \
    > test.out 2>&1
eval_tap $? 27 'GetGlobalStatItemByStatCode' test.out

#- 28 GetStatCycles
$CLI_EXE \
    --sn social \
    --op GetStatCycles \
    --namespace $AB_NAMESPACE \
    --cycleType 'ANNUALLY' \
    --limit '50' \
    --name 'jgyC6HdC' \
    --offset '49' \
    --sortBy '52y1Uo0U' \
    --status 'STOPPED' \
    > test.out 2>&1
eval_tap $? 28 'GetStatCycles' test.out

#- 29 CreateStatCycle
# body param: body
echo '{"cycleType": "SEASONAL", "description": "0TmPkCHZ", "end": "1998-07-15T00:00:00Z", "name": "imboZykh", "resetDate": 36, "resetDay": 42, "resetMonth": 52, "resetTime": "9wScH98G", "seasonPeriod": 98, "start": "1987-11-09T00:00:00Z"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op CreateStatCycle \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 29 'CreateStatCycle' test.out

#- 30 BulkGetStatCycle
# body param: body
echo '{"cycleIds": ["qqZF3ivj", "kcECyxhV", "Q0w0dFRw"]}' > $TEMP_JSON_INPUT
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
    --cycleId 'QR9PmeOf' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 33 'GetStatCycle' test.out

#- 34 UpdateStatCycle
# body param: body
echo '{"cycleType": "DAILY", "description": "DUbiuvLe", "end": "1972-04-04T00:00:00Z", "name": "qxdsW3Nr", "resetDate": 18, "resetDay": 89, "resetMonth": 62, "resetTime": "ADEGLyol", "seasonPeriod": 83, "start": "1977-03-29T00:00:00Z"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op UpdateStatCycle \
    --cycleId 'YlJ28fRF' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 34 'UpdateStatCycle' test.out

#- 35 DeleteStatCycle
$CLI_EXE \
    --sn social \
    --op DeleteStatCycle \
    --cycleId 'JoyCGqwE' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 35 'DeleteStatCycle' test.out

#- 36 BulkAddStats
# body param: body
echo '{"statCodes": ["usTOg9bV", "mxL3RSmL", "MPAbZGSz"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkAddStats \
    --cycleId 'yplmQY0D' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 36 'BulkAddStats' test.out

#- 37 StopStatCycle
$CLI_EXE \
    --sn social \
    --op StopStatCycle \
    --cycleId 'hxW9kCBo' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 37 'StopStatCycle' test.out

#- 38 BulkFetchStatItems
$CLI_EXE \
    --sn social \
    --op BulkFetchStatItems \
    --namespace $AB_NAMESPACE \
    --statCode 'qVlvnOSk' \
    --userIds 'rbrz06iy' \
    > test.out 2>&1
eval_tap $? 38 'BulkFetchStatItems' test.out

#- 39 BulkIncUserStatItem
# body param: body
echo '[{"inc": 0.4188945951110664, "statCode": "xHDrYeTK", "userId": "kaYHsttk"}, {"inc": 0.18060633098989798, "statCode": "kN9zr5HQ", "userId": "l4CryIOr"}, {"inc": 0.3174680727523621, "statCode": "2AgSdfWx", "userId": "XmforcbA"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkIncUserStatItem \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 39 'BulkIncUserStatItem' test.out

#- 40 BulkIncUserStatItemValue
# body param: body
echo '[{"inc": 0.17738595909395205, "statCode": "xOALbfRz", "userId": "35rxjptI"}, {"inc": 0.4161443740396451, "statCode": "0XKG6icR", "userId": "u0gWDObk"}, {"inc": 0.21471185721842012, "statCode": "cCtZarHH", "userId": "p16hfG0I"}]' > $TEMP_JSON_INPUT
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
    --statCode '9GO1CoD0' \
    --userIds '["dNctWSjg", "VwXrDcyK", "GpgJBuB8"]' \
    > test.out 2>&1
eval_tap $? 41 'BulkFetchOrDefaultStatItems' test.out

#- 42 BulkResetUserStatItem
# body param: body
echo '[{"statCode": "BO7CDIHZ", "userId": "q5osvzkV"}, {"statCode": "HfQZxq4v", "userId": "lDeTDAxy"}, {"statCode": "f1IFiODy", "userId": "nvsOdgxx"}]' > $TEMP_JSON_INPUT
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
    --cycleIds 'qJOVQIH0' \
    --isGlobal 'true' \
    --isPublic 'false' \
    --limit '13' \
    --offset '82' \
    > test.out 2>&1
eval_tap $? 43 'GetStats' test.out

#- 44 CreateStat
# body param: body
echo '{"cycleIds": ["24rS1tiI", "y1xps5Qd", "kRvSNkJJ"], "defaultValue": 0.31484065017350116, "description": "LTIu60Vb", "ignoreAdditionalDataOnValueRejected": true, "incrementOnly": false, "isPublic": false, "maximum": 0.6918649935613719, "minimum": 0.2887268779294244, "name": "tmLA0wXv", "setAsGlobal": true, "setBy": "SERVER", "statCode": "4TF9G0v0", "tags": ["QS67q8RM", "xCiKc8dl", "AX0ygjDp"]}' > $TEMP_JSON_INPUT
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
    --upload $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 46 'ImportStats' test.out

#- 47 QueryStats
$CLI_EXE \
    --sn social \
    --op QueryStats \
    --namespace $AB_NAMESPACE \
    --isGlobal 'true' \
    --isPublic 'true' \
    --limit '84' \
    --offset '37' \
    --keyword 'Vayv5DZM' \
    > test.out 2>&1
eval_tap $? 47 'QueryStats' test.out

#- 48 GetStat
$CLI_EXE \
    --sn social \
    --op GetStat \
    --namespace $AB_NAMESPACE \
    --statCode 'liNSEJFU' \
    > test.out 2>&1
eval_tap $? 48 'GetStat' test.out

#- 49 DeleteStat
$CLI_EXE \
    --sn social \
    --op DeleteStat \
    --namespace $AB_NAMESPACE \
    --statCode 'OPODrlex' \
    > test.out 2>&1
eval_tap $? 49 'DeleteStat' test.out

#- 50 UpdateStat
# body param: body
echo '{"cycleIds": ["RWroruPq", "jbaLrf3q", "qBinufbz"], "defaultValue": 0.8740183380012594, "description": "qncNeifh", "ignoreAdditionalDataOnValueRejected": false, "isPublic": false, "name": "wzfJV1CN", "tags": ["RUOKfap0", "aiZqojAM", "DQbsgb6u"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op UpdateStat \
    --namespace $AB_NAMESPACE \
    --statCode '48t0lxp3' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 50 'UpdateStat' test.out

#- 51 GetStatItems
$CLI_EXE \
    --sn social \
    --op GetStatItems \
    --namespace $AB_NAMESPACE \
    --statCode 'wP0zJDKY' \
    --limit '36' \
    --offset '84' \
    --sortBy '8aKAUJU7' \
    > test.out 2>&1
eval_tap $? 51 'GetStatItems' test.out

#- 52 DeleteTiedStat
$CLI_EXE \
    --sn social \
    --op DeleteTiedStat \
    --namespace $AB_NAMESPACE \
    --statCode 'rKHcFCB6' \
    > test.out 2>&1
eval_tap $? 52 'DeleteTiedStat' test.out

#- 53 GetUserStatCycleItems
$CLI_EXE \
    --sn social \
    --op GetUserStatCycleItems \
    --cycleId 'E14v9aTg' \
    --namespace $AB_NAMESPACE \
    --userId 'NlRPz6JO' \
    --isPublic 'true' \
    --limit '88' \
    --offset '23' \
    --sortBy 'o4PAOEox' \
    --statCodes 'Bd8sCmfb' \
    > test.out 2>&1
eval_tap $? 53 'GetUserStatCycleItems' test.out

#- 54 GetUserStatItems
$CLI_EXE \
    --sn social \
    --op GetUserStatItems \
    --namespace $AB_NAMESPACE \
    --userId 'PwvC96g6' \
    --isPublic 'false' \
    --limit '67' \
    --offset '36' \
    --sortBy 'kvsxdeKa' \
    --statCodes 'SpeO3cRB' \
    --tags 'VYJ3Ihp6' \
    > test.out 2>&1
eval_tap $? 54 'GetUserStatItems' test.out

#- 55 BulkCreateUserStatItems
# body param: body
echo '[{"statCode": "9Oa4qxKA"}, {"statCode": "6d3fko7a"}, {"statCode": "BFkyzF10"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkCreateUserStatItems \
    --namespace $AB_NAMESPACE \
    --userId '5A6NrMA8' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 55 'BulkCreateUserStatItems' test.out

#- 56 BulkIncUserStatItem1
# body param: body
echo '[{"inc": 0.4383383273771835, "statCode": "9YDOfzun"}, {"inc": 0.9505659865552369, "statCode": "HoUAKwZE"}, {"inc": 0.8934692015581636, "statCode": "yJ28BLQ9"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkIncUserStatItem1 \
    --namespace $AB_NAMESPACE \
    --userId 'lbrV57O7' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 56 'BulkIncUserStatItem1' test.out

#- 57 BulkIncUserStatItemValue1
# body param: body
echo '[{"inc": 0.6169255734268352, "statCode": "fwpJq3uK"}, {"inc": 0.3036948697627613, "statCode": "UiAynh02"}, {"inc": 0.9684190673094686, "statCode": "NipZIOel"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkIncUserStatItemValue1 \
    --namespace $AB_NAMESPACE \
    --userId 'ndPkWrkO' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 57 'BulkIncUserStatItemValue1' test.out

#- 58 BulkResetUserStatItem1
# body param: body
echo '[{"statCode": "dTfpWTdd"}, {"statCode": "jTAzoqzJ"}, {"statCode": "bGAgPsW7"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkResetUserStatItem1 \
    --namespace $AB_NAMESPACE \
    --userId 'jkTGWcca' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 58 'BulkResetUserStatItem1' test.out

#- 59 CreateUserStatItem
$CLI_EXE \
    --sn social \
    --op CreateUserStatItem \
    --namespace $AB_NAMESPACE \
    --statCode 'gcgSuT7F' \
    --userId 'OtlZMIod' \
    > test.out 2>&1
eval_tap $? 59 'CreateUserStatItem' test.out

#- 60 DeleteUserStatItems
$CLI_EXE \
    --sn social \
    --op DeleteUserStatItems \
    --namespace $AB_NAMESPACE \
    --statCode '9ahXKNVk' \
    --userId 'WkcKkuZZ' \
    > test.out 2>&1
eval_tap $? 60 'DeleteUserStatItems' test.out

#- 61 IncUserStatItemValue
# body param: body
echo '{"inc": 0.47820371249906257}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op IncUserStatItemValue \
    --namespace $AB_NAMESPACE \
    --statCode 'DWdJuPxG' \
    --userId 'UsrbrYgw' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 61 'IncUserStatItemValue' test.out

#- 62 ResetUserStatItemValue
# body param: body
echo '{"additionalData": {"mFylsknx": {}, "hZWmgvoA": {}, "uF44wMd1": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op ResetUserStatItemValue \
    --namespace $AB_NAMESPACE \
    --statCode 'Je3saXsb' \
    --userId '7SnBpTLN' \
    --additionalKey 'jMIjyj5T' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 62 'ResetUserStatItemValue' test.out

#- 63 GetGlobalStatItems1
$CLI_EXE \
    --sn social \
    --op GetGlobalStatItems1 \
    --namespace $AB_NAMESPACE \
    --limit '11' \
    --offset '99' \
    --statCodes 'UsZpxcLq' \
    > test.out 2>&1
eval_tap $? 63 'GetGlobalStatItems1' test.out

#- 64 GetGlobalStatItemByStatCode1
$CLI_EXE \
    --sn social \
    --op GetGlobalStatItemByStatCode1 \
    --namespace $AB_NAMESPACE \
    --statCode 'cBbroY9D' \
    > test.out 2>&1
eval_tap $? 64 'GetGlobalStatItemByStatCode1' test.out

#- 65 GetStatCycles1
$CLI_EXE \
    --sn social \
    --op GetStatCycles1 \
    --namespace $AB_NAMESPACE \
    --cycleType 'ANNUALLY' \
    --limit '46' \
    --name 'AKCC9dKy' \
    --offset '14' \
    --sortBy 'aQN44kdB' \
    --status 'STOPPED' \
    > test.out 2>&1
eval_tap $? 65 'GetStatCycles1' test.out

#- 66 BulkGetStatCycle1
# body param: body
echo '{"cycleIds": ["uyDsPEQy", "KjM5srJy", "SX54iUxp"]}' > $TEMP_JSON_INPUT
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
    --cycleId 'ZqndO9TK' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 67 'GetStatCycle1' test.out

#- 68 BulkFetchStatItems1
$CLI_EXE \
    --sn social \
    --op BulkFetchStatItems1 \
    --namespace $AB_NAMESPACE \
    --statCode 'Wj8JNE5X' \
    --userIds 'ySRT2fLQ' \
    > test.out 2>&1
eval_tap $? 68 'BulkFetchStatItems1' test.out

#- 69 PublicBulkIncUserStatItem
# body param: body
echo '[{"inc": 0.6933212368195004, "statCode": "4j9etpQn", "userId": "lPUD1MsS"}, {"inc": 0.8399106032830294, "statCode": "whN4Pq9Y", "userId": "tB1M7e7J"}, {"inc": 0.9743520434263873, "statCode": "kdlAVfXh", "userId": "1923uBSn"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicBulkIncUserStatItem \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 69 'PublicBulkIncUserStatItem' test.out

#- 70 PublicBulkIncUserStatItemValue
# body param: body
echo '[{"inc": 0.11514222313972156, "statCode": "NSL4BCX7", "userId": "7AvF01z7"}, {"inc": 0.9232869928618458, "statCode": "ep7rbsT6", "userId": "B91YoHmO"}, {"inc": 0.80450192317205, "statCode": "a1cvtyyJ", "userId": "NKyEefmP"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicBulkIncUserStatItemValue \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 70 'PublicBulkIncUserStatItemValue' test.out

#- 71 BulkResetUserStatItem2
# body param: body
echo '[{"statCode": "nEAmZXQX", "userId": "BoJrq9hW"}, {"statCode": "4OXbj62U", "userId": "G62CGHtx"}, {"statCode": "VL9d1nPt", "userId": "v4WAnaef"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkResetUserStatItem2 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 71 'BulkResetUserStatItem2' test.out

#- 72 CreateStat1
# body param: body
echo '{"cycleIds": ["m5k2cJyF", "hoV95OvT", "7luRtKLQ"], "defaultValue": 0.2938846671795248, "description": "iZVkJrKE", "ignoreAdditionalDataOnValueRejected": false, "incrementOnly": false, "isPublic": false, "maximum": 0.2643691730107792, "minimum": 0.3210771001318965, "name": "JU5i4YIc", "setAsGlobal": true, "setBy": "CLIENT", "statCode": "TkmUPVWl", "tags": ["6EDPc4mf", "CpiqZlkS", "27cBbnDo"]}' > $TEMP_JSON_INPUT
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
    --cycleId 'ULfZCTc3' \
    --namespace $AB_NAMESPACE \
    --limit '34' \
    --offset '72' \
    --sortBy 'TjA5tpO9' \
    --statCodes '["V1Ih92ve", "4bBeIQjo", "oY4ELyP8"]' \
    > test.out 2>&1
eval_tap $? 73 'PublicListMyStatCycleItems' test.out

#- 74 PublicListMyStatItems
$CLI_EXE \
    --sn social \
    --op PublicListMyStatItems \
    --namespace $AB_NAMESPACE \
    --limit '63' \
    --offset '86' \
    --sortBy '289Fjpjt' \
    --statCodes '["nN8rtVfg", "nsl5Oihh", "y5aO3BEn"]' \
    --tags '["2Nuxy9cM", "lDa6ht6t", "qBbZX8u3"]' \
    > test.out 2>&1
eval_tap $? 74 'PublicListMyStatItems' test.out

#- 75 PublicListAllMyStatItems
$CLI_EXE \
    --sn social \
    --op PublicListAllMyStatItems \
    --namespace $AB_NAMESPACE \
    --additionalKey 'V9rUXjeI' \
    --statCodes '["Odo7zCCe", "jAyHYaUw", "DGTNcfD1"]' \
    --tags '["3dqF5JlO", "iGC270tY", "1kxhyt7N"]' \
    > test.out 2>&1
eval_tap $? 75 'PublicListAllMyStatItems' test.out

#- 76 GetUserStatCycleItems1
$CLI_EXE \
    --sn social \
    --op GetUserStatCycleItems1 \
    --cycleId 'AbR4xkOH' \
    --namespace $AB_NAMESPACE \
    --userId 'ECr7a219' \
    --limit '64' \
    --offset '9' \
    --sortBy 'fECe7ehj' \
    --statCodes '1FLlWduN' \
    > test.out 2>&1
eval_tap $? 76 'GetUserStatCycleItems1' test.out

#- 77 PublicQueryUserStatItems
$CLI_EXE \
    --sn social \
    --op PublicQueryUserStatItems \
    --namespace $AB_NAMESPACE \
    --userId 'xsf8wsDQ' \
    --limit '47' \
    --offset '35' \
    --sortBy 'V6O6PxRa' \
    --statCodes 'jNmdlzZV' \
    --tags '4KwZmF65' \
    > test.out 2>&1
eval_tap $? 77 'PublicQueryUserStatItems' test.out

#- 78 PublicBulkCreateUserStatItems
# body param: body
echo '[{"statCode": "Ub9qM0LW"}, {"statCode": "a6FL7TxX"}, {"statCode": "ZxEVEKR0"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicBulkCreateUserStatItems \
    --namespace $AB_NAMESPACE \
    --userId 'jpY3G8Ru' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 78 'PublicBulkCreateUserStatItems' test.out

#- 79 PublicQueryUserStatItems1
$CLI_EXE \
    --sn social \
    --op PublicQueryUserStatItems1 \
    --namespace $AB_NAMESPACE \
    --userId 'ZeWkaClT' \
    --additionalKey 'bt4AchCd' \
    --statCodes '["Du8sFzRj", "LXOdsdDI", "7qXS7Ixb"]' \
    --tags '["0ElhdvWn", "soVp3GlA", "XQM7HIA8"]' \
    > test.out 2>&1
eval_tap $? 79 'PublicQueryUserStatItems1' test.out

#- 80 PublicBulkIncUserStatItem1
# body param: body
echo '[{"inc": 0.6253784428784918, "statCode": "XNk96c0M"}, {"inc": 0.9148739255631606, "statCode": "r3GY76Eg"}, {"inc": 0.0336318552730428, "statCode": "RmaeyQWf"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicBulkIncUserStatItem1 \
    --namespace $AB_NAMESPACE \
    --userId 'Qk9d9Bqt' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 80 'PublicBulkIncUserStatItem1' test.out

#- 81 BulkIncUserStatItemValue2
# body param: body
echo '[{"inc": 0.6698258279964311, "statCode": "9ZmSY0Sc"}, {"inc": 0.5599857171267545, "statCode": "73pKhr2c"}, {"inc": 0.43131087892385767, "statCode": "4NmsrXB1"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkIncUserStatItemValue2 \
    --namespace $AB_NAMESPACE \
    --userId '4W4MYbFS' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 81 'BulkIncUserStatItemValue2' test.out

#- 82 BulkResetUserStatItem3
# body param: body
echo '[{"statCode": "xtTHD6Q7"}, {"statCode": "XU7ZgQC9"}, {"statCode": "1u0BLXZs"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkResetUserStatItem3 \
    --namespace $AB_NAMESPACE \
    --userId 'cP7s3nUz' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 82 'BulkResetUserStatItem3' test.out

#- 83 PublicCreateUserStatItem
$CLI_EXE \
    --sn social \
    --op PublicCreateUserStatItem \
    --namespace $AB_NAMESPACE \
    --statCode 'OYyQ20lb' \
    --userId 'gjk0SVQv' \
    > test.out 2>&1
eval_tap $? 83 'PublicCreateUserStatItem' test.out

#- 84 DeleteUserStatItems1
$CLI_EXE \
    --sn social \
    --op DeleteUserStatItems1 \
    --namespace $AB_NAMESPACE \
    --statCode 'Uj4G8ERI' \
    --userId '9vK5AvAX' \
    > test.out 2>&1
eval_tap $? 84 'DeleteUserStatItems1' test.out

#- 85 PublicIncUserStatItem
# body param: body
echo '{"inc": 0.051809407585096445}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicIncUserStatItem \
    --namespace $AB_NAMESPACE \
    --statCode 'eHLkBOKJ' \
    --userId 'M5hIKhKE' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 85 'PublicIncUserStatItem' test.out

#- 86 PublicIncUserStatItemValue
# body param: body
echo '{"inc": 0.6617061408571134}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op PublicIncUserStatItemValue \
    --namespace $AB_NAMESPACE \
    --statCode '4vuBpskc' \
    --userId '8k4xUBoW' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 86 'PublicIncUserStatItemValue' test.out

#- 87 ResetUserStatItemValue1
$CLI_EXE \
    --sn social \
    --op ResetUserStatItemValue1 \
    --namespace $AB_NAMESPACE \
    --statCode 'gkDVUNGy' \
    --userId 'mR6gyox2' \
    > test.out 2>&1
eval_tap $? 87 'ResetUserStatItemValue1' test.out

#- 88 BulkUpdateUserStatItemV2
# body param: body
echo '[{"additionalData": {"hyQ0sNsp": {}, "UPmlCtK7": {}, "Lfj0IbQr": {}}, "additionalKey": "8oF1I5O9", "statCode": "Z5DvVMmL", "updateStrategy": "MAX", "userId": "SYRqpRxb", "value": 0.7168350045430334}, {"additionalData": {"gYLK4249": {}, "eHe4elrH": {}, "xEF7UsVo": {}}, "additionalKey": "o2xZADiV", "statCode": "sMaKxmzL", "updateStrategy": "OVERRIDE", "userId": "MDcTJ7DI", "value": 0.04022599906264912}, {"additionalData": {"WIv2myL5": {}, "nEE5qrmU": {}, "2ropb7Qa": {}}, "additionalKey": "WtTGDvWq", "statCode": "iC21QE6d", "updateStrategy": "MAX", "userId": "cPkH5reV", "value": 0.9871050800354964}]' > $TEMP_JSON_INPUT
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
    --additionalKey 'PUr9q2ef' \
    --statCode 'O3fa5tra' \
    --userIds '["8fwhd1sE", "AEX8rE0U", "YX44CPOI"]' \
    > test.out 2>&1
eval_tap $? 89 'BulkFetchOrDefaultStatItems1' test.out

#- 90 AdminListUsersStatItems
$CLI_EXE \
    --sn social \
    --op AdminListUsersStatItems \
    --namespace $AB_NAMESPACE \
    --userId 'onU7Cus7' \
    --additionalKey 'g4W7UzGT' \
    --statCodes '["32S5tGKs", "OBfcp7kh", "RGfCqfzj"]' \
    --tags '["5WHm2aYK", "JcPEyAff", "bjRaW6cr"]' \
    > test.out 2>&1
eval_tap $? 90 'AdminListUsersStatItems' test.out

#- 91 BulkUpdateUserStatItem
# body param: body
echo '[{"additionalData": {"eaaQWzBO": {}, "SJCCc0RB": {}, "MNzJPMpO": {}}, "statCode": "u0yMWxEr", "updateStrategy": "INCREMENT", "value": 0.6203341098304829}, {"additionalData": {"fHA0a5WA": {}, "cVwRjbku": {}, "Q45R62G4": {}}, "statCode": "ARbeROph", "updateStrategy": "MIN", "value": 0.8085152075790514}, {"additionalData": {"2yDLCH4W": {}, "xZbgnIct": {}, "Ab11MSS2": {}}, "statCode": "a8MM9JJV", "updateStrategy": "OVERRIDE", "value": 0.5552027481219677}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkUpdateUserStatItem \
    --namespace $AB_NAMESPACE \
    --userId 'z0U672Ym' \
    --additionalKey '1NGgKnJS' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 91 'BulkUpdateUserStatItem' test.out

#- 92 BulkResetUserStatItemValues
# body param: body
echo '[{"additionalData": {"XzcsiVTQ": {}, "PMBrt2Uj": {}, "2L837ow0": {}}, "statCode": "Pfa5Ba3R"}, {"additionalData": {"1J7RsPfb": {}, "jxPJwJK4": {}, "0oW78mVW": {}}, "statCode": "woBlo85V"}, {"additionalData": {"swMFkuuZ": {}, "GTDNH8AB": {}, "TmtnhOv2": {}}, "statCode": "DehMG64I"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkResetUserStatItemValues \
    --namespace $AB_NAMESPACE \
    --userId 'IlK6ebxa' \
    --additionalKey '1A4zP0az' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 92 'BulkResetUserStatItemValues' test.out

#- 93 DeleteUserStatItems2
$CLI_EXE \
    --sn social \
    --op DeleteUserStatItems2 \
    --namespace $AB_NAMESPACE \
    --statCode 'CscahF1n' \
    --userId 'gJpNqdvp' \
    --additionalKey 'aBgmFcG4' \
    > test.out 2>&1
eval_tap $? 93 'DeleteUserStatItems2' test.out

#- 94 UpdateUserStatItemValue
# body param: body
echo '{"additionalData": {"nced27YY": {}, "RFDxd7Sq": {}, "QPV2xIDT": {}}, "updateStrategy": "MIN", "value": 0.10739006851649213}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op UpdateUserStatItemValue \
    --namespace $AB_NAMESPACE \
    --statCode 'DMEvOxKA' \
    --userId '4Q12pxMD' \
    --additionalKey 'ZI4QIay3' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 94 'UpdateUserStatItemValue' test.out

#- 95 BulkUpdateUserStatItem1
# body param: body
echo '[{"additionalData": {"ycspwh0A": {}, "03C3yxU4": {}, "nw29ge5F": {}}, "additionalKey": "zWltT3eh", "statCode": "kdpJSikX", "updateStrategy": "INCREMENT", "userId": "SZRLZL8c", "value": 0.4078463827045796}, {"additionalData": {"kFzovvyF": {}, "rTU5rCzi": {}, "6TCoqIuq": {}}, "additionalKey": "P57qQxEV", "statCode": "tRPXFTeR", "updateStrategy": "MIN", "userId": "nW01UYv5", "value": 0.2139091835977398}, {"additionalData": {"HEJXTrY7": {}, "Kym1pmaW": {}, "zyL48MPh": {}}, "additionalKey": "pKpfRquk", "statCode": "eOmNsNpp", "updateStrategy": "INCREMENT", "userId": "PkUDbDTU", "value": 0.22194858902259018}]' > $TEMP_JSON_INPUT
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
    --userId 'qhe7b5FQ' \
    --additionalKey 'kjkhmUY5' \
    --statCodes '["rR1JC4VF", "Pye8wxOc", "M5zXPNRb"]' \
    --tags '["YoTszyTt", "AoETxOxe", "LsCKHzAE"]' \
    > test.out 2>&1
eval_tap $? 96 'PublicQueryUserStatItems2' test.out

#- 97 BulkUpdateUserStatItem2
# body param: body
echo '[{"additionalData": {"sjwdbTJA": {}, "nLS6IOaG": {}, "EOac4NY0": {}}, "statCode": "LwCqnBYS", "updateStrategy": "INCREMENT", "value": 0.01196266801452095}, {"additionalData": {"Zwc69xFB": {}, "krE2B51M": {}, "CnZ7CxXD": {}}, "statCode": "qRmvYQuL", "updateStrategy": "MIN", "value": 0.5896745678738522}, {"additionalData": {"yhE3cnSX": {}, "RVo5hEtm": {}, "p3U9DAMR": {}}, "statCode": "9kgycqcs", "updateStrategy": "MIN", "value": 0.32669952525611345}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op BulkUpdateUserStatItem2 \
    --namespace $AB_NAMESPACE \
    --userId '9w7hEmy2' \
    --additionalKey 'ZpTCcNOL' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 97 'BulkUpdateUserStatItem2' test.out

#- 98 UpdateUserStatItemValue1
# body param: body
echo '{"additionalData": {"IBFtmevQ": {}, "Yq2zIEJi": {}, "9mKN2r1k": {}}, "updateStrategy": "INCREMENT", "value": 0.461913591292896}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn social \
    --op UpdateUserStatItemValue1 \
    --namespace $AB_NAMESPACE \
    --statCode 'a5VrvKLa' \
    --userId 'V5w8vupg' \
    --additionalKey 'WbWql3xz' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 98 'UpdateUserStatItemValue1' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE