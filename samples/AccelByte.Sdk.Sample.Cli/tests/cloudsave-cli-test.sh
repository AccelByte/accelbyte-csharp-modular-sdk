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
echo "1..105"

#- 1 Login
$CLI_EXE --op login --lt user --user user --pass user > test.out 2>&1
eval_tap $? 1 'Login' test.out

if [ $EXIT_CODE -ne 0 ]; then
  echo "Bail out! Login failed."
  exit $EXIT_CODE
fi

# echo "foo" > "$CLI_TOKEN_FILE"

#- 2 AdminListAdminGameRecordV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminListAdminGameRecordV1 \
    --namespace $AB_NAMESPACE \
    --limit '68' \
    --offset '61' \
    --query 'CymzDxtE' \
    --tags '["SvCYDr5n", "nBJMjXqV", "DjZwlIbM"]' \
    > test.out 2>&1
eval_tap $? 2 'AdminListAdminGameRecordV1' test.out

#- 3 AdminBulkGetAdminGameRecordV1
# body param: body
echo '{"keys": ["HWe4VEyL", "TDtB10nh", "ZgWVoFPE"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminBulkGetAdminGameRecordV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 3 'AdminBulkGetAdminGameRecordV1' test.out

#- 4 AdminGetAdminGameRecordV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminGetAdminGameRecordV1 \
    --key 'ClD2qsEo' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 4 'AdminGetAdminGameRecordV1' test.out

#- 5 AdminPutAdminGameRecordV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutAdminGameRecordV1 \
    --key 'bGpNXLwz' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 5 'AdminPutAdminGameRecordV1' test.out

#- 6 AdminPostAdminGameRecordV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPostAdminGameRecordV1 \
    --key '1JmMtrM9' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 6 'AdminPostAdminGameRecordV1' test.out

#- 7 AdminDeleteAdminGameRecordV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminDeleteAdminGameRecordV1 \
    --key 'Iiqf8oPb' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 7 'AdminDeleteAdminGameRecordV1' test.out

#- 8 DeleteAdminGameRecordTTLConfig
$CLI_EXE \
    --sn cloudsave \
    --op DeleteAdminGameRecordTTLConfig \
    --key 'CssezNy5' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 8 'DeleteAdminGameRecordTTLConfig' test.out

#- 9 AdminListGameBinaryRecordsV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminListGameBinaryRecordsV1 \
    --namespace $AB_NAMESPACE \
    --limit '4' \
    --offset '74' \
    --query 'UktRUiw4' \
    --tags '["G4iUCm3z", "E5Jt4t3L", "mbFtsbqv"]' \
    > test.out 2>&1
eval_tap $? 9 'AdminListGameBinaryRecordsV1' test.out

#- 10 AdminPostGameBinaryRecordV1
# body param: body
echo '{"file_type": "OZaD7zk6", "key": "IPytDLzw", "set_by": "SERVER", "ttl_config": {"action": "DELETE", "expires_at": "1987-06-09T00:00:00Z"}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPostGameBinaryRecordV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 10 'AdminPostGameBinaryRecordV1' test.out

#- 11 AdminGetGameBinaryRecordV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminGetGameBinaryRecordV1 \
    --key 'OLHwLOsS' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 11 'AdminGetGameBinaryRecordV1' test.out

#- 12 AdminPutGameBinaryRecordV1
# body param: body
echo '{"content_type": "mbPL6GJT", "file_location": "HlWyqG49"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutGameBinaryRecordV1 \
    --key 'mdnWXh9f' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 12 'AdminPutGameBinaryRecordV1' test.out

#- 13 AdminDeleteGameBinaryRecordV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminDeleteGameBinaryRecordV1 \
    --key 'rSKL1fVy' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 13 'AdminDeleteGameBinaryRecordV1' test.out

#- 14 AdminPutGameBinaryRecorMetadataV1
# body param: body
echo '{"set_by": "CLIENT", "tags": ["0cD4Q8Gb", "TG0lxesp", "UDyhJpBg"], "ttl_config": {"action": "DELETE", "expires_at": "1972-06-08T00:00:00Z"}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutGameBinaryRecorMetadataV1 \
    --key 'hvWXl4q5' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 14 'AdminPutGameBinaryRecorMetadataV1' test.out

#- 15 AdminPostGameBinaryPresignedURLV1
# body param: body
echo '{"file_type": "V7qo1gJO"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPostGameBinaryPresignedURLV1 \
    --key 'czUmIh4I' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 15 'AdminPostGameBinaryPresignedURLV1' test.out

#- 16 DeleteGameBinaryRecordTTLConfig
$CLI_EXE \
    --sn cloudsave \
    --op DeleteGameBinaryRecordTTLConfig \
    --key 'HiUdrqKc' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 16 'DeleteGameBinaryRecordTTLConfig' test.out

#- 17 AdminPutAdminGameRecordConcurrentHandlerV1
# body param: body
echo '{"tags": ["l13ENL4q", "MapYCP7Z", "RQYItFtU"], "ttl_config": {"action": "DELETE", "expires_at": "1989-07-25T00:00:00Z"}, "updatedAt": "1979-04-29T00:00:00Z", "value": {"kGe1J6gf": {}, "LIxJOuF6": {}, "hz4ZOzuR": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutAdminGameRecordConcurrentHandlerV1 \
    --key 'ft7omlfq' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 17 'AdminPutAdminGameRecordConcurrentHandlerV1' test.out

#- 18 AdminPutGameRecordConcurrentHandlerV1
# body param: body
echo '{"set_by": "CLIENT", "tags": ["CRzA15SE", "qd6vB3be", "HIwQ7zsV"], "ttl_config": {"action": "DELETE", "expires_at": "1980-04-03T00:00:00Z"}, "updatedAt": "1996-12-22T00:00:00Z", "value": {"tX7XBJDl": {}, "23VFPT8K": {}, "3GKluY8I": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutGameRecordConcurrentHandlerV1 \
    --key '1uMDoe4U' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 18 'AdminPutGameRecordConcurrentHandlerV1' test.out

#- 19 GetPluginConfig
$CLI_EXE \
    --sn cloudsave \
    --op GetPluginConfig \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 19 'GetPluginConfig' test.out

#- 20 CreatePluginConfig
# body param: body
echo '{"appConfig": {"appName": "8C5uQmVg"}, "customConfig": {"GRPCAddress": "VELO9EbA"}, "customFunction": {"afterBulkReadGameBinaryRecord": false, "afterBulkReadGameRecord": true, "afterBulkReadPlayerBinaryRecord": true, "afterBulkReadPlayerRecord": false, "afterReadGameBinaryRecord": true, "afterReadGameRecord": true, "afterReadPlayerBinaryRecord": false, "afterReadPlayerRecord": true, "beforeWriteAdminGameRecord": true, "beforeWriteAdminPlayerRecord": true, "beforeWriteGameBinaryRecord": false, "beforeWriteGameRecord": false, "beforeWritePlayerBinaryRecord": true, "beforeWritePlayerRecord": false}, "extendType": "CUSTOM"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op CreatePluginConfig \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 20 'CreatePluginConfig' test.out

#- 21 DeletePluginConfig
$CLI_EXE \
    --sn cloudsave \
    --op DeletePluginConfig \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 21 'DeletePluginConfig' test.out

#- 22 UpdatePluginConfig
# body param: body
echo '{"appConfig": {"appName": "PnD0iOSZ"}, "customConfig": {"GRPCAddress": "S0LC7Gf2"}, "customFunction": {"afterBulkReadGameBinaryRecord": false, "afterBulkReadGameRecord": true, "afterBulkReadPlayerBinaryRecord": true, "afterBulkReadPlayerRecord": false, "afterReadGameBinaryRecord": true, "afterReadGameRecord": true, "afterReadPlayerBinaryRecord": true, "afterReadPlayerRecord": false, "beforeWriteAdminGameRecord": true, "beforeWriteAdminPlayerRecord": false, "beforeWriteGameBinaryRecord": true, "beforeWriteGameRecord": true, "beforeWritePlayerBinaryRecord": false, "beforeWritePlayerRecord": true}, "extendType": "CUSTOM"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op UpdatePluginConfig \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 22 'UpdatePluginConfig' test.out

#- 23 ListGameRecordsHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op ListGameRecordsHandlerV1 \
    --namespace $AB_NAMESPACE \
    --query '5o11KHx0' \
    --tags '["oIBwIc8k", "fnsKCaHB", "VuFFtc7u"]' \
    --limit '55' \
    --offset '82' \
    > test.out 2>&1
eval_tap $? 23 'ListGameRecordsHandlerV1' test.out

#- 24 AdminGetGameRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminGetGameRecordHandlerV1 \
    --key 'fsXSKige' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 24 'AdminGetGameRecordHandlerV1' test.out

#- 25 AdminPutGameRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutGameRecordHandlerV1 \
    --key 'FhhNSsGU' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 25 'AdminPutGameRecordHandlerV1' test.out

#- 26 AdminPostGameRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPostGameRecordHandlerV1 \
    --key 'Gm3tLs8W' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 26 'AdminPostGameRecordHandlerV1' test.out

#- 27 AdminDeleteGameRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminDeleteGameRecordHandlerV1 \
    --key 'mvRyszry' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 27 'AdminDeleteGameRecordHandlerV1' test.out

#- 28 DeleteGameRecordTTLConfig
$CLI_EXE \
    --sn cloudsave \
    --op DeleteGameRecordTTLConfig \
    --key 'qUgQVQTN' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 28 'DeleteGameRecordTTLConfig' test.out

#- 29 AdminListTagsHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminListTagsHandlerV1 \
    --namespace $AB_NAMESPACE \
    --limit '58' \
    --offset '68' \
    > test.out 2>&1
eval_tap $? 29 'AdminListTagsHandlerV1' test.out

#- 30 AdminPostTagHandlerV1
# body param: body
echo '{"tag": "A6ofWg61"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPostTagHandlerV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 30 'AdminPostTagHandlerV1' test.out

#- 31 AdminDeleteTagHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminDeleteTagHandlerV1 \
    --namespace $AB_NAMESPACE \
    --tag 'lcNv3dcN' \
    > test.out 2>&1
eval_tap $? 31 'AdminDeleteTagHandlerV1' test.out

#- 32 BulkGetAdminPlayerRecordByUserIdsV1
# body param: body
echo '{"userIds": ["0KB2W0bI", "uxg1uBPs", "BsoCn3Q0"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op BulkGetAdminPlayerRecordByUserIdsV1 \
    --key '8GiNHjMz' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 32 'BulkGetAdminPlayerRecordByUserIdsV1' test.out

#- 33 BulkGetPlayerRecordSizeHandlerV1
# body param: body
echo '{"data": [{"keys": ["6hPR9XHl", "14aum9yn", "3UJNbLZi"], "user_id": "Yh4InnZP"}, {"keys": ["ZSWF39nC", "ThJwvLxo", "6AfKDziH"], "user_id": "FDVca6Q9"}, {"keys": ["mkTyl2Jm", "KMtU3PUh", "Pm01fD42"], "user_id": "lOnVkdKf"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op BulkGetPlayerRecordSizeHandlerV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 33 'BulkGetPlayerRecordSizeHandlerV1' test.out

#- 34 ListPlayerRecordHandlerV1
eval_tap 0 34 'ListPlayerRecordHandlerV1 # SKIP deprecated' test.out

#- 35 AdminBulkPutPlayerRecordsByKeyHandlerV1
# body param: body
echo '{"data": [{"user_id": "ZPPIPJN9", "value": {"gPQ4APEE": {}, "WSfdZdy3": {}, "PBtru2nt": {}}}, {"user_id": "2nUuy1qg", "value": {"cM6Ptqu5": {}, "NnvXWZyj": {}, "sNjp1WxR": {}}}, {"user_id": "06mnUIm4", "value": {"dXCV5IQk": {}, "QFd7oc0n": {}, "5FVd1btC": {}}}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminBulkPutPlayerRecordsByKeyHandlerV1 \
    --key 'ZXVRmHgf' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 35 'AdminBulkPutPlayerRecordsByKeyHandlerV1' test.out

#- 36 AdminBulkGetPlayerRecordsByUserIDsHandlerV1
# body param: body
echo '{"userIds": ["KeGFTzHx", "dndmNnUy", "bDnHXl57"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminBulkGetPlayerRecordsByUserIDsHandlerV1 \
    --key 'uP0bapKa' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 36 'AdminBulkGetPlayerRecordsByUserIDsHandlerV1' test.out

#- 37 AdminListAdminUserRecordsV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminListAdminUserRecordsV1 \
    --namespace $AB_NAMESPACE \
    --userId 'EKlwm85N' \
    --limit '78' \
    --offset '59' \
    --query 'fi8BAoiQ' \
    --tags '["Ra7wJCoB", "K3pWXnPN", "BeRC3NP4"]' \
    > test.out 2>&1
eval_tap $? 37 'AdminListAdminUserRecordsV1' test.out

#- 38 AdminBulkGetAdminPlayerRecordV1
# body param: body
echo '{"keys": ["TAZMxlFn", "O6x4DOj6", "MXiJfEky"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminBulkGetAdminPlayerRecordV1 \
    --namespace $AB_NAMESPACE \
    --userId 'Fl9omr7n' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 38 'AdminBulkGetAdminPlayerRecordV1' test.out

#- 39 AdminGetAdminPlayerRecordV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminGetAdminPlayerRecordV1 \
    --key 'T8aTtWat' \
    --namespace $AB_NAMESPACE \
    --userId 'Eewefjwu' \
    > test.out 2>&1
eval_tap $? 39 'AdminGetAdminPlayerRecordV1' test.out

#- 40 AdminPutAdminPlayerRecordV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutAdminPlayerRecordV1 \
    --key 'zg28encP' \
    --namespace $AB_NAMESPACE \
    --userId '87nOvDBZ' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 40 'AdminPutAdminPlayerRecordV1' test.out

#- 41 AdminPostPlayerAdminRecordV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPostPlayerAdminRecordV1 \
    --key 'y0D41Pvv' \
    --namespace $AB_NAMESPACE \
    --userId 'cUBmeEnz' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 41 'AdminPostPlayerAdminRecordV1' test.out

#- 42 AdminDeleteAdminPlayerRecordV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminDeleteAdminPlayerRecordV1 \
    --key 'hHJzBHlQ' \
    --namespace $AB_NAMESPACE \
    --userId 'eyd3I14R' \
    > test.out 2>&1
eval_tap $? 42 'AdminDeleteAdminPlayerRecordV1' test.out

#- 43 AdminListPlayerBinaryRecordsV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminListPlayerBinaryRecordsV1 \
    --namespace $AB_NAMESPACE \
    --userId '9AxwON6v' \
    --limit '23' \
    --offset '95' \
    --query 'VoqJgPlO' \
    --tags '["jdAeW9ve", "oC64zGJz", "OBjqeVVn"]' \
    > test.out 2>&1
eval_tap $? 43 'AdminListPlayerBinaryRecordsV1' test.out

#- 44 AdminPostPlayerBinaryRecordV1
# body param: body
echo '{"file_type": "KnW2dsUy", "is_public": true, "key": "ErYA8A3f", "set_by": "SERVER"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPostPlayerBinaryRecordV1 \
    --namespace $AB_NAMESPACE \
    --userId 'Jqdrar9M' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 44 'AdminPostPlayerBinaryRecordV1' test.out

#- 45 AdminGetPlayerBinaryRecordV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminGetPlayerBinaryRecordV1 \
    --key 'cfls3EWi' \
    --namespace $AB_NAMESPACE \
    --userId 'ByVtHqgp' \
    > test.out 2>&1
eval_tap $? 45 'AdminGetPlayerBinaryRecordV1' test.out

#- 46 AdminPutPlayerBinaryRecordV1
# body param: body
echo '{"content_type": "ZnmNDQ3j", "file_location": "W4XpgGqU"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutPlayerBinaryRecordV1 \
    --key '8SLIy4V4' \
    --namespace $AB_NAMESPACE \
    --userId 'LoToa8uH' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 46 'AdminPutPlayerBinaryRecordV1' test.out

#- 47 AdminDeletePlayerBinaryRecordV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminDeletePlayerBinaryRecordV1 \
    --key 'EXKx2YWj' \
    --namespace $AB_NAMESPACE \
    --userId 'qe5NYqAO' \
    > test.out 2>&1
eval_tap $? 47 'AdminDeletePlayerBinaryRecordV1' test.out

#- 48 AdminPutPlayerBinaryRecorMetadataV1
# body param: body
echo '{"is_public": true, "set_by": "SERVER", "tags": ["fGoiRk7a", "LZxyuc6X", "ysl2tMnR"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutPlayerBinaryRecorMetadataV1 \
    --key '67iS6Sn2' \
    --namespace $AB_NAMESPACE \
    --userId 'VnoBLukt' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 48 'AdminPutPlayerBinaryRecorMetadataV1' test.out

#- 49 AdminPostPlayerBinaryPresignedURLV1
# body param: body
echo '{"file_type": "MncVVdDS"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPostPlayerBinaryPresignedURLV1 \
    --key 'xqKQeejN' \
    --namespace $AB_NAMESPACE \
    --userId 'dBsAeXXf' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 49 'AdminPostPlayerBinaryPresignedURLV1' test.out

#- 50 AdminPutAdminPlayerRecordConcurrentHandlerV1
# body param: body
echo '{"tags": ["siq85SHs", "BWoIJksp", "pBVlGhFn"], "updatedAt": "1972-11-21T00:00:00Z", "value": {"qLlu5Srp": {}, "iBHUFWLi": {}, "o09VD9cY": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutAdminPlayerRecordConcurrentHandlerV1 \
    --key 'nH1HsIzy' \
    --namespace $AB_NAMESPACE \
    --userId '7hMJFnZk' \
    --responseBody 'false' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 50 'AdminPutAdminPlayerRecordConcurrentHandlerV1' test.out

#- 51 AdminPutPlayerRecordConcurrentHandlerV1
# body param: body
echo '{"set_by": "SERVER", "tags": ["QRUYkauS", "ovbwA2AF", "8Vu8u7Wj"], "ttl_config": {"action": "DELETE", "expires_at": "1999-07-25T00:00:00Z"}, "updatedAt": "1991-06-15T00:00:00Z", "value": {"QuJrwqfI": {}, "Hyi3Eorb": {}, "lNKuHzx7": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutPlayerRecordConcurrentHandlerV1 \
    --key 'zik6GQal' \
    --namespace $AB_NAMESPACE \
    --userId 'Zye3dCEw' \
    --responseBody 'true' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 51 'AdminPutPlayerRecordConcurrentHandlerV1' test.out

#- 52 AdminPutPlayerPublicRecordConcurrentHandlerV1
# body param: body
echo '{"set_by": "CLIENT", "tags": ["j2VMevLm", "YGp48e7a", "j5AP0eRW"], "ttl_config": {"action": "DELETE", "expires_at": "1980-06-02T00:00:00Z"}, "updatedAt": "1992-02-29T00:00:00Z", "value": {"7EaCS5WV": {}, "Yzulv6Iy": {}, "ipew0hwX": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutPlayerPublicRecordConcurrentHandlerV1 \
    --key 'xBOYBdOd' \
    --namespace $AB_NAMESPACE \
    --userId 'Q7tXakkV' \
    --responseBody 'false' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 52 'AdminPutPlayerPublicRecordConcurrentHandlerV1' test.out

#- 53 AdminRetrievePlayerRecords
$CLI_EXE \
    --sn cloudsave \
    --op AdminRetrievePlayerRecords \
    --namespace $AB_NAMESPACE \
    --userId 'VUAWIlOO' \
    --limit '58' \
    --offset '65' \
    --query 'J6U9eMdY' \
    --tags '["y6ZHnKmL", "3ZBegLit", "sB8t4vb8"]' \
    > test.out 2>&1
eval_tap $? 53 'AdminRetrievePlayerRecords' test.out

#- 54 AdminPutPlayerRecordsHandlerV1
# body param: body
echo '{"data": [{"key": "Dz4kLWcK", "value": {"YFJiZYlC": {}, "aY75NEJ3": {}, "PrnsIKHF": {}}}, {"key": "ZqCchLML", "value": {"1ZbMZWnx": {}, "pRGBO31x": {}, "aPDHFnwS": {}}}, {"key": "tbmsakUp", "value": {"vfpMmwAL": {}, "x4ZbCJOv": {}, "IFtwcZhC": {}}}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutPlayerRecordsHandlerV1 \
    --namespace $AB_NAMESPACE \
    --userId 'ajzTZvGM' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 54 'AdminPutPlayerRecordsHandlerV1' test.out

#- 55 AdminGetPlayerRecordsHandlerV1
# body param: body
echo '{"keys": ["g1oMRuZJ", "UJXuNald", "WpZpNWWO"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminGetPlayerRecordsHandlerV1 \
    --namespace $AB_NAMESPACE \
    --userId 'XZcMzSNq' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 55 'AdminGetPlayerRecordsHandlerV1' test.out

#- 56 AdminGetPlayerRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminGetPlayerRecordHandlerV1 \
    --key '7epOgBKJ' \
    --namespace $AB_NAMESPACE \
    --userId 'd7T36rsj' \
    > test.out 2>&1
eval_tap $? 56 'AdminGetPlayerRecordHandlerV1' test.out

#- 57 AdminPutPlayerRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutPlayerRecordHandlerV1 \
    --key 'Jl2Bushs' \
    --namespace $AB_NAMESPACE \
    --userId 'aVmUpJWB' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 57 'AdminPutPlayerRecordHandlerV1' test.out

#- 58 AdminPostPlayerRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPostPlayerRecordHandlerV1 \
    --key 'rZaQwOtA' \
    --namespace $AB_NAMESPACE \
    --userId 'BisAVhLo' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 58 'AdminPostPlayerRecordHandlerV1' test.out

#- 59 AdminDeletePlayerRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminDeletePlayerRecordHandlerV1 \
    --key 'u20zBPYe' \
    --namespace $AB_NAMESPACE \
    --userId 'rsD7MsLb' \
    > test.out 2>&1
eval_tap $? 59 'AdminDeletePlayerRecordHandlerV1' test.out

#- 60 AdminGetPlayerPublicRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminGetPlayerPublicRecordHandlerV1 \
    --key 'josOW4fN' \
    --namespace $AB_NAMESPACE \
    --userId 'awo4V1bg' \
    > test.out 2>&1
eval_tap $? 60 'AdminGetPlayerPublicRecordHandlerV1' test.out

#- 61 AdminPutPlayerPublicRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutPlayerPublicRecordHandlerV1 \
    --key 'sYPRyAqC' \
    --namespace $AB_NAMESPACE \
    --userId 'KtlKNO7k' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 61 'AdminPutPlayerPublicRecordHandlerV1' test.out

#- 62 AdminPostPlayerPublicRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPostPlayerPublicRecordHandlerV1 \
    --key '5ghHeZ9Z' \
    --namespace $AB_NAMESPACE \
    --userId 'TyQQFeRO' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 62 'AdminPostPlayerPublicRecordHandlerV1' test.out

#- 63 AdminDeletePlayerPublicRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminDeletePlayerPublicRecordHandlerV1 \
    --key 'Zup1IN8j' \
    --namespace $AB_NAMESPACE \
    --userId '6SO7sc10' \
    > test.out 2>&1
eval_tap $? 63 'AdminDeletePlayerPublicRecordHandlerV1' test.out

#- 64 AdminGetPlayerRecordSizeHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminGetPlayerRecordSizeHandlerV1 \
    --key 'ymb8CFoI' \
    --namespace $AB_NAMESPACE \
    --userId 'lN5oC7i9' \
    > test.out 2>&1
eval_tap $? 64 'AdminGetPlayerRecordSizeHandlerV1' test.out

#- 65 ListGameBinaryRecordsV1
$CLI_EXE \
    --sn cloudsave \
    --op ListGameBinaryRecordsV1 \
    --namespace $AB_NAMESPACE \
    --limit '63' \
    --offset '50' \
    --query 'VuwAsejo' \
    --tags '["21CrAmwV", "lVbbPoTt", "ClK04YJr"]' \
    > test.out 2>&1
eval_tap $? 65 'ListGameBinaryRecordsV1' test.out

#- 66 PostGameBinaryRecordV1
# body param: body
echo '{"file_type": "Rkd6Gs2B", "key": "SPOQilTz"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PostGameBinaryRecordV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 66 'PostGameBinaryRecordV1' test.out

#- 67 BulkGetGameBinaryRecordV1
# body param: body
echo '{"keys": ["VB9GRd4l", "uT5yawUa", "SLGEMa1H"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op BulkGetGameBinaryRecordV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 67 'BulkGetGameBinaryRecordV1' test.out

#- 68 GetGameBinaryRecordV1
$CLI_EXE \
    --sn cloudsave \
    --op GetGameBinaryRecordV1 \
    --key 'xORV5bjM' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 68 'GetGameBinaryRecordV1' test.out

#- 69 PutGameBinaryRecordV1
# body param: body
echo '{"content_type": "WB8IRULP", "file_location": "WR1k3Emb"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PutGameBinaryRecordV1 \
    --key 'K3qYOMbx' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 69 'PutGameBinaryRecordV1' test.out

#- 70 DeleteGameBinaryRecordV1
$CLI_EXE \
    --sn cloudsave \
    --op DeleteGameBinaryRecordV1 \
    --key 'sM1KVqFx' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 70 'DeleteGameBinaryRecordV1' test.out

#- 71 PostGameBinaryPresignedURLV1
# body param: body
echo '{"file_type": "mnot1IfA"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PostGameBinaryPresignedURLV1 \
    --key 'hL6IIGOj' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 71 'PostGameBinaryPresignedURLV1' test.out

#- 72 PutGameRecordConcurrentHandlerV1
# body param: body
echo '{"updatedAt": "1992-04-11T00:00:00Z", "value": {"dLeFX6ow": {}, "DGYVgtDG": {}, "noUTbLyZ": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PutGameRecordConcurrentHandlerV1 \
    --key 'Ql7MnxBZ' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 72 'PutGameRecordConcurrentHandlerV1' test.out

#- 73 GetGameRecordsBulk
# body param: body
echo '{"keys": ["UbmtnAkU", "Bg3LtKMH", "apZaQvFC"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op GetGameRecordsBulk \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 73 'GetGameRecordsBulk' test.out

#- 74 GetGameRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op GetGameRecordHandlerV1 \
    --key 'zGw2HYnn' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 74 'GetGameRecordHandlerV1' test.out

#- 75 PutGameRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PutGameRecordHandlerV1 \
    --key 'ZfiBwP90' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 75 'PutGameRecordHandlerV1' test.out

#- 76 PostGameRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PostGameRecordHandlerV1 \
    --key 'UPKbhi5j' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 76 'PostGameRecordHandlerV1' test.out

#- 77 DeleteGameRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op DeleteGameRecordHandlerV1 \
    --key 'uM9mRmWZ' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 77 'DeleteGameRecordHandlerV1' test.out

#- 78 PublicListTagsHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op PublicListTagsHandlerV1 \
    --namespace $AB_NAMESPACE \
    --limit '23' \
    --offset '72' \
    > test.out 2>&1
eval_tap $? 78 'PublicListTagsHandlerV1' test.out

#- 79 BulkGetPlayerPublicBinaryRecordsV1
# body param: body
echo '{"userIds": ["7Ru9DYa5", "6Thg6jqh", "TW5IDWB2"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op BulkGetPlayerPublicBinaryRecordsV1 \
    --key 'dmDltBbY' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 79 'BulkGetPlayerPublicBinaryRecordsV1' test.out

#- 80 BulkGetPlayerPublicRecordHandlerV1
# body param: body
echo '{"userIds": ["hY6FJKQh", "Zzpi3Lmz", "Kwa0MEVr"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op BulkGetPlayerPublicRecordHandlerV1 \
    --key 'oc30MvGD' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 80 'BulkGetPlayerPublicRecordHandlerV1' test.out

#- 81 ListMyBinaryRecordsV1
$CLI_EXE \
    --sn cloudsave \
    --op ListMyBinaryRecordsV1 \
    --namespace $AB_NAMESPACE \
    --limit '38' \
    --offset '25' \
    --query 'jTYWOd49' \
    --tags '["ENbpvNie", "NMpeLzCR", "TAwr3lSY"]' \
    > test.out 2>&1
eval_tap $? 81 'ListMyBinaryRecordsV1' test.out

#- 82 BulkGetMyBinaryRecordV1
# body param: body
echo '{"keys": ["z3Fomoix", "lcVwGNMT", "ubdEfOXr"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op BulkGetMyBinaryRecordV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 82 'BulkGetMyBinaryRecordV1' test.out

#- 83 RetrievePlayerRecords
$CLI_EXE \
    --sn cloudsave \
    --op RetrievePlayerRecords \
    --namespace $AB_NAMESPACE \
    --limit '61' \
    --offset '95' \
    --tags '["V6QeKpew", "ByigBx7l", "Uo0yxFPJ"]' \
    > test.out 2>&1
eval_tap $? 83 'RetrievePlayerRecords' test.out

#- 84 GetPlayerRecordsBulkHandlerV1
# body param: body
echo '{"keys": ["XO3jGTHg", "nQrh46Fz", "5sRfZqMY"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op GetPlayerRecordsBulkHandlerV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 84 'GetPlayerRecordsBulkHandlerV1' test.out

#- 85 PublicDeletePlayerPublicRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op PublicDeletePlayerPublicRecordHandlerV1 \
    --key 'YIZBv0GC' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 85 'PublicDeletePlayerPublicRecordHandlerV1' test.out

#- 86 PostPlayerBinaryRecordV1
# body param: body
echo '{"file_type": "gqN2oKEU", "is_public": false, "key": "YCS0uk1u"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PostPlayerBinaryRecordV1 \
    --namespace $AB_NAMESPACE \
    --userId 'm1VUcMOt' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 86 'PostPlayerBinaryRecordV1' test.out

#- 87 ListOtherPlayerPublicBinaryRecordsV1
$CLI_EXE \
    --sn cloudsave \
    --op ListOtherPlayerPublicBinaryRecordsV1 \
    --namespace $AB_NAMESPACE \
    --userId '38NwUnaY' \
    --limit '44' \
    --offset '100' \
    --tags '["Spc85TQ2", "mMTNRIda", "TJrBznFI"]' \
    > test.out 2>&1
eval_tap $? 87 'ListOtherPlayerPublicBinaryRecordsV1' test.out

#- 88 BulkGetOtherPlayerPublicBinaryRecordsV1
# body param: body
echo '{"keys": ["wLM7P9KN", "m5VpgJcx", "XmK30ly4"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op BulkGetOtherPlayerPublicBinaryRecordsV1 \
    --namespace $AB_NAMESPACE \
    --userId '3CDC3Jyz' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 88 'BulkGetOtherPlayerPublicBinaryRecordsV1' test.out

#- 89 GetPlayerBinaryRecordV1
$CLI_EXE \
    --sn cloudsave \
    --op GetPlayerBinaryRecordV1 \
    --key 'RHm8Jit2' \
    --namespace $AB_NAMESPACE \
    --userId 'sneppx3f' \
    > test.out 2>&1
eval_tap $? 89 'GetPlayerBinaryRecordV1' test.out

#- 90 PutPlayerBinaryRecordV1
# body param: body
echo '{"content_type": "GzUNBP4m", "file_location": "ORTY1P2l"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PutPlayerBinaryRecordV1 \
    --key 'wRs76AVy' \
    --namespace $AB_NAMESPACE \
    --userId 'XlhwNjIP' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 90 'PutPlayerBinaryRecordV1' test.out

#- 91 DeletePlayerBinaryRecordV1
$CLI_EXE \
    --sn cloudsave \
    --op DeletePlayerBinaryRecordV1 \
    --key 'mb18PsgY' \
    --namespace $AB_NAMESPACE \
    --userId 'MjY5o95O' \
    > test.out 2>&1
eval_tap $? 91 'DeletePlayerBinaryRecordV1' test.out

#- 92 PutPlayerBinaryRecorMetadataV1
# body param: body
echo '{"is_public": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PutPlayerBinaryRecorMetadataV1 \
    --key '2ewqbAC2' \
    --namespace $AB_NAMESPACE \
    --userId 'i060N9af' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 92 'PutPlayerBinaryRecorMetadataV1' test.out

#- 93 PostPlayerBinaryPresignedURLV1
# body param: body
echo '{"file_type": "YH25DIKR"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PostPlayerBinaryPresignedURLV1 \
    --key 'rwyithYs' \
    --namespace $AB_NAMESPACE \
    --userId '2fPyc0KQ' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 93 'PostPlayerBinaryPresignedURLV1' test.out

#- 94 GetPlayerPublicBinaryRecordsV1
$CLI_EXE \
    --sn cloudsave \
    --op GetPlayerPublicBinaryRecordsV1 \
    --key 'L1p0iN3a' \
    --namespace $AB_NAMESPACE \
    --userId 'zH0VbpY8' \
    > test.out 2>&1
eval_tap $? 94 'GetPlayerPublicBinaryRecordsV1' test.out

#- 95 PutPlayerRecordConcurrentHandlerV1
# body param: body
echo '{"updatedAt": "1978-08-04T00:00:00Z", "value": {"88rf1HVV": {}, "krrRZ7zn": {}, "t5NVT56H": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PutPlayerRecordConcurrentHandlerV1 \
    --key 'e8akutgB' \
    --namespace $AB_NAMESPACE \
    --userId 'VegL8ABD' \
    --responseBody 'false' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 95 'PutPlayerRecordConcurrentHandlerV1' test.out

#- 96 PutPlayerPublicRecordConcurrentHandlerV1
# body param: body
echo '{"updatedAt": "1988-06-12T00:00:00Z", "value": {"Gv2MAdLt": {}, "swa7Km91": {}, "sywSQyQp": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PutPlayerPublicRecordConcurrentHandlerV1 \
    --key 'uOyc9PFd' \
    --namespace $AB_NAMESPACE \
    --userId 'AZejnRx0' \
    --responseBody 'false' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 96 'PutPlayerPublicRecordConcurrentHandlerV1' test.out

#- 97 GetOtherPlayerPublicRecordKeyHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op GetOtherPlayerPublicRecordKeyHandlerV1 \
    --namespace $AB_NAMESPACE \
    --userId 'BBaWGSme' \
    --limit '20' \
    --offset '63' \
    --tags '["A1qWdsyL", "0KhCJIeF", "p8oISlKE"]' \
    > test.out 2>&1
eval_tap $? 97 'GetOtherPlayerPublicRecordKeyHandlerV1' test.out

#- 98 GetOtherPlayerPublicRecordHandlerV1
# body param: body
echo '{"keys": ["ThZ987PQ", "dxhMueYZ", "toQciGyu"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op GetOtherPlayerPublicRecordHandlerV1 \
    --namespace $AB_NAMESPACE \
    --userId 'L2tyx5Rv' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 98 'GetOtherPlayerPublicRecordHandlerV1' test.out

#- 99 GetPlayerRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op GetPlayerRecordHandlerV1 \
    --key 'wtoNYzyH' \
    --namespace $AB_NAMESPACE \
    --userId 'U2STOOIa' \
    > test.out 2>&1
eval_tap $? 99 'GetPlayerRecordHandlerV1' test.out

#- 100 PutPlayerRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PutPlayerRecordHandlerV1 \
    --key 'JRWAbUIM' \
    --namespace $AB_NAMESPACE \
    --userId 'yEy2peDq' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 100 'PutPlayerRecordHandlerV1' test.out

#- 101 PostPlayerRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PostPlayerRecordHandlerV1 \
    --key 'IYSS0iR7' \
    --namespace $AB_NAMESPACE \
    --userId 'JuT0hq4O' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 101 'PostPlayerRecordHandlerV1' test.out

#- 102 DeletePlayerRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op DeletePlayerRecordHandlerV1 \
    --key 'wIFC7eHi' \
    --namespace $AB_NAMESPACE \
    --userId 'ynKUsfZ5' \
    > test.out 2>&1
eval_tap $? 102 'DeletePlayerRecordHandlerV1' test.out

#- 103 GetPlayerPublicRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op GetPlayerPublicRecordHandlerV1 \
    --key 'C6DAPXxv' \
    --namespace $AB_NAMESPACE \
    --userId 'TsQc6N2O' \
    > test.out 2>&1
eval_tap $? 103 'GetPlayerPublicRecordHandlerV1' test.out

#- 104 PutPlayerPublicRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PutPlayerPublicRecordHandlerV1 \
    --key 'bHCRakKO' \
    --namespace $AB_NAMESPACE \
    --userId 'af0b8uC5' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 104 'PutPlayerPublicRecordHandlerV1' test.out

#- 105 PostPlayerPublicRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PostPlayerPublicRecordHandlerV1 \
    --key 'IZIDf4Yk' \
    --namespace $AB_NAMESPACE \
    --userId 'k3Yqhy4M' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 105 'PostPlayerPublicRecordHandlerV1' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE