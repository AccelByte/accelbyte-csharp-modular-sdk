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
echo "1..104"

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
    --limit '43' \
    --offset '42' \
    --query 'hdPaOSeV' \
    --tags '["HHBJRDoh", "AFo88MGn", "vnrCq9aw"]' \
    > test.out 2>&1
eval_tap $? 2 'AdminListAdminGameRecordV1' test.out

#- 3 AdminBulkGetAdminGameRecordV1
# body param: body
echo '{"keys": ["CW4R23rp", "AvlXXHHz", "3VC7bh37"]}' > $TEMP_JSON_INPUT
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
    --key 'VfE4RVk5' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 4 'AdminGetAdminGameRecordV1' test.out

#- 5 AdminPutAdminGameRecordV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutAdminGameRecordV1 \
    --key 'DE22vuTf' \
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
    --key 'qApPpykz' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 6 'AdminPostAdminGameRecordV1' test.out

#- 7 AdminDeleteAdminGameRecordV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminDeleteAdminGameRecordV1 \
    --key 'xCTntCjQ' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 7 'AdminDeleteAdminGameRecordV1' test.out

#- 8 AdminListGameBinaryRecordsV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminListGameBinaryRecordsV1 \
    --namespace $AB_NAMESPACE \
    --limit '5' \
    --offset '73' \
    --query 'ng5wDnq1' \
    --tags '["t58QUvKq", "9vYFbD0T", "hHAEA9bL"]' \
    > test.out 2>&1
eval_tap $? 8 'AdminListGameBinaryRecordsV1' test.out

#- 9 AdminPostGameBinaryRecordV1
# body param: body
echo '{"file_type": "1nJxTyXD", "key": "hQw6PgRl", "set_by": "CLIENT", "ttl_config": {"action": "DELETE", "expires_at": "1996-04-25T00:00:00Z"}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPostGameBinaryRecordV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 9 'AdminPostGameBinaryRecordV1' test.out

#- 10 AdminGetGameBinaryRecordV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminGetGameBinaryRecordV1 \
    --key 'CYLe25ji' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 10 'AdminGetGameBinaryRecordV1' test.out

#- 11 AdminPutGameBinaryRecordV1
# body param: body
echo '{"content_type": "IXNHJ5gn", "file_location": "i8fRk1h5"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutGameBinaryRecordV1 \
    --key '0efNwIdg' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 11 'AdminPutGameBinaryRecordV1' test.out

#- 12 AdminDeleteGameBinaryRecordV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminDeleteGameBinaryRecordV1 \
    --key 'BTFFafqa' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 12 'AdminDeleteGameBinaryRecordV1' test.out

#- 13 AdminPutGameBinaryRecorMetadataV1
# body param: body
echo '{"set_by": "SERVER", "tags": ["AKeix2RX", "ixNLjN7f", "3Q6wHCgV"], "ttl_config": {"action": "DELETE", "expires_at": "1978-09-13T00:00:00Z"}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutGameBinaryRecorMetadataV1 \
    --key 'J07KAZWl' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 13 'AdminPutGameBinaryRecorMetadataV1' test.out

#- 14 AdminPostGameBinaryPresignedURLV1
# body param: body
echo '{"file_type": "QcyMSxhc"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPostGameBinaryPresignedURLV1 \
    --key 'f0zkZZj1' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 14 'AdminPostGameBinaryPresignedURLV1' test.out

#- 15 DeleteGameBinaryRecordTTLConfig
$CLI_EXE \
    --sn cloudsave \
    --op DeleteGameBinaryRecordTTLConfig \
    --key 'kKMUlu3V' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 15 'DeleteGameBinaryRecordTTLConfig' test.out

#- 16 AdminPutAdminGameRecordConcurrentHandlerV1
# body param: body
echo '{"tags": ["y29ih2Al", "hnxWXHrB", "0n6KS0R8"], "updatedAt": "XY5o0XXW", "value": {"hERdvuiB": {}, "q6iMA63e": {}, "SbqJU3ys": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutAdminGameRecordConcurrentHandlerV1 \
    --key 'Zwe5pwrO' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 16 'AdminPutAdminGameRecordConcurrentHandlerV1' test.out

#- 17 AdminPutGameRecordConcurrentHandlerV1
# body param: body
echo '{"set_by": "CLIENT", "tags": ["wwtfOeJ2", "WvdeXhQk", "QBLFo5Pn"], "ttl_config": {"action": "DELETE", "expires_at": "1989-02-25T00:00:00Z"}, "updatedAt": "8FsYmXkA", "value": {"XxhO16wY": {}, "1ut19fTm": {}, "m6mdE2EM": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutGameRecordConcurrentHandlerV1 \
    --key 'DCgcSU6R' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 17 'AdminPutGameRecordConcurrentHandlerV1' test.out

#- 18 GetPluginConfig
$CLI_EXE \
    --sn cloudsave \
    --op GetPluginConfig \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 18 'GetPluginConfig' test.out

#- 19 CreatePluginConfig
# body param: body
echo '{"appConfig": {"appName": "PVVkjSbv"}, "customConfig": {"GRPCAddress": "834DnrWw"}, "customFunction": {"afterBulkReadGameBinaryRecord": true, "afterBulkReadGameRecord": true, "afterBulkReadPlayerBinaryRecord": true, "afterBulkReadPlayerRecord": false, "afterReadGameBinaryRecord": false, "afterReadGameRecord": false, "afterReadPlayerBinaryRecord": false, "afterReadPlayerRecord": true, "beforeWriteAdminGameRecord": false, "beforeWriteAdminPlayerRecord": false, "beforeWriteGameBinaryRecord": false, "beforeWriteGameRecord": false, "beforeWritePlayerBinaryRecord": false, "beforeWritePlayerRecord": true}, "extendType": "CUSTOM"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op CreatePluginConfig \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 19 'CreatePluginConfig' test.out

#- 20 DeletePluginConfig
$CLI_EXE \
    --sn cloudsave \
    --op DeletePluginConfig \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 20 'DeletePluginConfig' test.out

#- 21 UpdatePluginConfig
# body param: body
echo '{"appConfig": {"appName": "iDTsYpwv"}, "customConfig": {"GRPCAddress": "xuKocaoI"}, "customFunction": {"afterBulkReadGameBinaryRecord": false, "afterBulkReadGameRecord": false, "afterBulkReadPlayerBinaryRecord": false, "afterBulkReadPlayerRecord": true, "afterReadGameBinaryRecord": false, "afterReadGameRecord": true, "afterReadPlayerBinaryRecord": true, "afterReadPlayerRecord": false, "beforeWriteAdminGameRecord": false, "beforeWriteAdminPlayerRecord": false, "beforeWriteGameBinaryRecord": false, "beforeWriteGameRecord": false, "beforeWritePlayerBinaryRecord": false, "beforeWritePlayerRecord": false}, "extendType": "APP"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op UpdatePluginConfig \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 21 'UpdatePluginConfig' test.out

#- 22 ListGameRecordsHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op ListGameRecordsHandlerV1 \
    --namespace $AB_NAMESPACE \
    --query '5hno51VG' \
    --tags '["rI7nHyeb", "QEPrPZ1Z", "GgRecJJw"]' \
    --limit '37' \
    --offset '96' \
    > test.out 2>&1
eval_tap $? 22 'ListGameRecordsHandlerV1' test.out

#- 23 AdminGetGameRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminGetGameRecordHandlerV1 \
    --key 'DR640cIP' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 23 'AdminGetGameRecordHandlerV1' test.out

#- 24 AdminPutGameRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutGameRecordHandlerV1 \
    --key '8PRW8Iwc' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 24 'AdminPutGameRecordHandlerV1' test.out

#- 25 AdminPostGameRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPostGameRecordHandlerV1 \
    --key 'BsztFPrH' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 25 'AdminPostGameRecordHandlerV1' test.out

#- 26 AdminDeleteGameRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminDeleteGameRecordHandlerV1 \
    --key 'KPfOseVY' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 26 'AdminDeleteGameRecordHandlerV1' test.out

#- 27 DeleteGameRecordTTLConfig
$CLI_EXE \
    --sn cloudsave \
    --op DeleteGameRecordTTLConfig \
    --key 'EwF6LtPs' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 27 'DeleteGameRecordTTLConfig' test.out

#- 28 AdminListTagsHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminListTagsHandlerV1 \
    --namespace $AB_NAMESPACE \
    --limit '58' \
    --offset '0' \
    > test.out 2>&1
eval_tap $? 28 'AdminListTagsHandlerV1' test.out

#- 29 AdminPostTagHandlerV1
# body param: body
echo '{"tag": "mMgsEzRi"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPostTagHandlerV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 29 'AdminPostTagHandlerV1' test.out

#- 30 AdminDeleteTagHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminDeleteTagHandlerV1 \
    --namespace $AB_NAMESPACE \
    --tag 'Xk962vfs' \
    > test.out 2>&1
eval_tap $? 30 'AdminDeleteTagHandlerV1' test.out

#- 31 BulkGetAdminPlayerRecordByUserIdsV1
# body param: body
echo '{"userIds": ["FbffGteO", "2AFDX8mg", "JRna5BHe"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op BulkGetAdminPlayerRecordByUserIdsV1 \
    --key 'Yzsa2u7M' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 31 'BulkGetAdminPlayerRecordByUserIdsV1' test.out

#- 32 BulkGetPlayerRecordSizeHandlerV1
# body param: body
echo '{"data": [{"keys": ["FEDnqXym", "nbetYKBa", "2QlQZV7K"], "user_id": "YMYyid5L"}, {"keys": ["e3GZph8S", "pyldJnok", "a5FEjSc9"], "user_id": "sm9nBwPz"}, {"keys": ["otj0pcgG", "2XZAvJ7q", "IJG16Idh"], "user_id": "gxeo0fj8"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op BulkGetPlayerRecordSizeHandlerV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 32 'BulkGetPlayerRecordSizeHandlerV1' test.out

#- 33 ListPlayerRecordHandlerV1
eval_tap 0 33 'ListPlayerRecordHandlerV1 # SKIP deprecated' test.out

#- 34 AdminBulkPutPlayerRecordsByKeyHandlerV1
# body param: body
echo '{"data": [{"user_id": "3qlamnUX", "value": {"Ky8CU2KG": {}, "kv7JAi5W": {}, "mjk3TCDA": {}}}, {"user_id": "L8Yw0ysr", "value": {"9fFcRF7k": {}, "V4xcbv9Y": {}, "C5Xb60of": {}}}, {"user_id": "6nFcsnPH", "value": {"98ZWpYyc": {}, "sturn7K5": {}, "IWUlsYIR": {}}}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminBulkPutPlayerRecordsByKeyHandlerV1 \
    --key 'hQyqPOBH' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 34 'AdminBulkPutPlayerRecordsByKeyHandlerV1' test.out

#- 35 AdminBulkGetPlayerRecordsByUserIDsHandlerV1
# body param: body
echo '{"userIds": ["2FcBafX7", "PdMUA3hU", "EnQ2ze1Q"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminBulkGetPlayerRecordsByUserIDsHandlerV1 \
    --key 'qrmyLPeX' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 35 'AdminBulkGetPlayerRecordsByUserIDsHandlerV1' test.out

#- 36 AdminListAdminUserRecordsV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminListAdminUserRecordsV1 \
    --namespace $AB_NAMESPACE \
    --userId 'hBMa3R1z' \
    --limit '21' \
    --offset '73' \
    --tags '["pjLwbAvG", "FAnfE9Od", "Wvf2Awbe"]' \
    > test.out 2>&1
eval_tap $? 36 'AdminListAdminUserRecordsV1' test.out

#- 37 AdminBulkGetAdminPlayerRecordV1
# body param: body
echo '{"keys": ["CPYSUWln", "LYDH0Q9p", "3fHKCrhY"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminBulkGetAdminPlayerRecordV1 \
    --namespace $AB_NAMESPACE \
    --userId '4A6DZ2br' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 37 'AdminBulkGetAdminPlayerRecordV1' test.out

#- 38 AdminGetAdminPlayerRecordV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminGetAdminPlayerRecordV1 \
    --key 'ESnEVkRP' \
    --namespace $AB_NAMESPACE \
    --userId 'eBWDmfvY' \
    > test.out 2>&1
eval_tap $? 38 'AdminGetAdminPlayerRecordV1' test.out

#- 39 AdminPutAdminPlayerRecordV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutAdminPlayerRecordV1 \
    --key '7hsnSb8u' \
    --namespace $AB_NAMESPACE \
    --userId 'CZMHft0m' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 39 'AdminPutAdminPlayerRecordV1' test.out

#- 40 AdminPostPlayerAdminRecordV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPostPlayerAdminRecordV1 \
    --key 'xhW600X9' \
    --namespace $AB_NAMESPACE \
    --userId 'rmydSz5A' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 40 'AdminPostPlayerAdminRecordV1' test.out

#- 41 AdminDeleteAdminPlayerRecordV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminDeleteAdminPlayerRecordV1 \
    --key 'QBFLRmnw' \
    --namespace $AB_NAMESPACE \
    --userId 'tIY9sr52' \
    > test.out 2>&1
eval_tap $? 41 'AdminDeleteAdminPlayerRecordV1' test.out

#- 42 AdminListPlayerBinaryRecordsV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminListPlayerBinaryRecordsV1 \
    --namespace $AB_NAMESPACE \
    --userId 'ls4E09Ok' \
    --limit '53' \
    --offset '8' \
    --query '2BnYI0Zo' \
    --tags '["EncYBQoj", "klL5xKAT", "TLIqz027"]' \
    > test.out 2>&1
eval_tap $? 42 'AdminListPlayerBinaryRecordsV1' test.out

#- 43 AdminPostPlayerBinaryRecordV1
# body param: body
echo '{"file_type": "DO68xUSF", "is_public": true, "key": "3D7hAFDE", "set_by": "CLIENT"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPostPlayerBinaryRecordV1 \
    --namespace $AB_NAMESPACE \
    --userId 'jDr7kHnA' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 43 'AdminPostPlayerBinaryRecordV1' test.out

#- 44 AdminGetPlayerBinaryRecordV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminGetPlayerBinaryRecordV1 \
    --key 'DCqYZ3C8' \
    --namespace $AB_NAMESPACE \
    --userId 'XG2FfluK' \
    > test.out 2>&1
eval_tap $? 44 'AdminGetPlayerBinaryRecordV1' test.out

#- 45 AdminPutPlayerBinaryRecordV1
# body param: body
echo '{"content_type": "cwOe6xhE", "file_location": "5BG2MRpt"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutPlayerBinaryRecordV1 \
    --key 'eOGPCHqu' \
    --namespace $AB_NAMESPACE \
    --userId 'EJ0syw9a' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 45 'AdminPutPlayerBinaryRecordV1' test.out

#- 46 AdminDeletePlayerBinaryRecordV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminDeletePlayerBinaryRecordV1 \
    --key 'Z4WNS4KT' \
    --namespace $AB_NAMESPACE \
    --userId 'yLEst9RR' \
    > test.out 2>&1
eval_tap $? 46 'AdminDeletePlayerBinaryRecordV1' test.out

#- 47 AdminPutPlayerBinaryRecorMetadataV1
# body param: body
echo '{"is_public": true, "set_by": "CLIENT", "tags": ["ctVjmiPp", "NhbDNmtz", "0nJRy4pV"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutPlayerBinaryRecorMetadataV1 \
    --key 'Mqpvvk9h' \
    --namespace $AB_NAMESPACE \
    --userId 'KymGQk6B' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 47 'AdminPutPlayerBinaryRecorMetadataV1' test.out

#- 48 AdminPostPlayerBinaryPresignedURLV1
# body param: body
echo '{"file_type": "DmfgXz0A"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPostPlayerBinaryPresignedURLV1 \
    --key 'qXta5BUh' \
    --namespace $AB_NAMESPACE \
    --userId 'VVU6GvtU' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 48 'AdminPostPlayerBinaryPresignedURLV1' test.out

#- 49 AdminPutAdminPlayerRecordConcurrentHandlerV1
# body param: body
echo '{"tags": ["abG14hne", "dMQ4K5be", "1sK13Qeq"], "updatedAt": "s0yo2NO0", "value": {"IGwvGBNJ": {}, "LoiK1lre": {}, "0URGXYCQ": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutAdminPlayerRecordConcurrentHandlerV1 \
    --key 'JPAlZMa6' \
    --namespace $AB_NAMESPACE \
    --userId '2qmxFPAy' \
    --responseBody 'true' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 49 'AdminPutAdminPlayerRecordConcurrentHandlerV1' test.out

#- 50 AdminPutPlayerRecordConcurrentHandlerV1
# body param: body
echo '{"set_by": "CLIENT", "tags": ["Ao5s2Ye9", "kdZCUaGm", "N7bgWj3h"], "ttl_config": {"action": "DELETE", "expires_at": "1976-03-08T00:00:00Z"}, "updatedAt": "KPMnDwTk", "value": {"I7QpNIYw": {}, "Bh69Hx9Z": {}, "BvLGWCq0": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutPlayerRecordConcurrentHandlerV1 \
    --key 'o5Un9tQn' \
    --namespace $AB_NAMESPACE \
    --userId 'XrHV8nhA' \
    --responseBody 'true' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 50 'AdminPutPlayerRecordConcurrentHandlerV1' test.out

#- 51 AdminPutPlayerPublicRecordConcurrentHandlerV1
# body param: body
echo '{"set_by": "SERVER", "tags": ["PW4KXCTt", "o7snLY9Y", "o47edaI0"], "ttl_config": {"action": "DELETE", "expires_at": "1976-05-16T00:00:00Z"}, "updatedAt": "CkXKvTJp", "value": {"sOiVADEK": {}, "X7tpIxK3": {}, "rZEnDzSe": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutPlayerPublicRecordConcurrentHandlerV1 \
    --key 'H6E9IWZG' \
    --namespace $AB_NAMESPACE \
    --userId 'uUMTglQp' \
    --responseBody 'true' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 51 'AdminPutPlayerPublicRecordConcurrentHandlerV1' test.out

#- 52 AdminRetrievePlayerRecords
$CLI_EXE \
    --sn cloudsave \
    --op AdminRetrievePlayerRecords \
    --namespace $AB_NAMESPACE \
    --userId 'DAKEMA6M' \
    --limit '7' \
    --offset '96' \
    --tags '["O1Jb0rqS", "YTBtmD9X", "Fw8itEXX"]' \
    > test.out 2>&1
eval_tap $? 52 'AdminRetrievePlayerRecords' test.out

#- 53 AdminPutPlayerRecordsHandlerV1
# body param: body
echo '{"data": [{"key": "6dOWwBDm", "value": {"WgF3mQ1r": {}, "VlitSsZc": {}, "4RCVQYjc": {}}}, {"key": "V91EngFV", "value": {"APY7XY9R": {}, "O6N2vNGb": {}, "jGGwxSGv": {}}}, {"key": "kCIzjNZL", "value": {"nu0KKDLS": {}, "uX5y06WR": {}, "UwU5DlIb": {}}}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutPlayerRecordsHandlerV1 \
    --namespace $AB_NAMESPACE \
    --userId 'D8n2kwjQ' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 53 'AdminPutPlayerRecordsHandlerV1' test.out

#- 54 AdminGetPlayerRecordsHandlerV1
# body param: body
echo '{"keys": ["rXmMgBmz", "nqnBOYI6", "emQOqeLw"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminGetPlayerRecordsHandlerV1 \
    --namespace $AB_NAMESPACE \
    --userId 'RIQTdgVM' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 54 'AdminGetPlayerRecordsHandlerV1' test.out

#- 55 AdminGetPlayerRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminGetPlayerRecordHandlerV1 \
    --key 'isLzgQ6C' \
    --namespace $AB_NAMESPACE \
    --userId 'dwyMx8Fs' \
    > test.out 2>&1
eval_tap $? 55 'AdminGetPlayerRecordHandlerV1' test.out

#- 56 AdminPutPlayerRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutPlayerRecordHandlerV1 \
    --key 'kpwVE410' \
    --namespace $AB_NAMESPACE \
    --userId 'fwqo8140' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 56 'AdminPutPlayerRecordHandlerV1' test.out

#- 57 AdminPostPlayerRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPostPlayerRecordHandlerV1 \
    --key 'YURvQt84' \
    --namespace $AB_NAMESPACE \
    --userId 'gZi7ZRw5' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 57 'AdminPostPlayerRecordHandlerV1' test.out

#- 58 AdminDeletePlayerRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminDeletePlayerRecordHandlerV1 \
    --key 'q4oc8C6r' \
    --namespace $AB_NAMESPACE \
    --userId 'mL6ARDuc' \
    > test.out 2>&1
eval_tap $? 58 'AdminDeletePlayerRecordHandlerV1' test.out

#- 59 AdminGetPlayerPublicRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminGetPlayerPublicRecordHandlerV1 \
    --key 'qCae5FIU' \
    --namespace $AB_NAMESPACE \
    --userId 'oEz97wMT' \
    > test.out 2>&1
eval_tap $? 59 'AdminGetPlayerPublicRecordHandlerV1' test.out

#- 60 AdminPutPlayerPublicRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutPlayerPublicRecordHandlerV1 \
    --key '56oCoSjL' \
    --namespace $AB_NAMESPACE \
    --userId 'Oz51R2WF' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 60 'AdminPutPlayerPublicRecordHandlerV1' test.out

#- 61 AdminPostPlayerPublicRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPostPlayerPublicRecordHandlerV1 \
    --key 'N0kmkSli' \
    --namespace $AB_NAMESPACE \
    --userId '3QV5Opir' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 61 'AdminPostPlayerPublicRecordHandlerV1' test.out

#- 62 AdminDeletePlayerPublicRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminDeletePlayerPublicRecordHandlerV1 \
    --key 'qqniOKt3' \
    --namespace $AB_NAMESPACE \
    --userId 'WeLvXtW9' \
    > test.out 2>&1
eval_tap $? 62 'AdminDeletePlayerPublicRecordHandlerV1' test.out

#- 63 AdminGetPlayerRecordSizeHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminGetPlayerRecordSizeHandlerV1 \
    --key 'a8IHtKvu' \
    --namespace $AB_NAMESPACE \
    --userId '2ultD2cX' \
    > test.out 2>&1
eval_tap $? 63 'AdminGetPlayerRecordSizeHandlerV1' test.out

#- 64 ListGameBinaryRecordsV1
$CLI_EXE \
    --sn cloudsave \
    --op ListGameBinaryRecordsV1 \
    --namespace $AB_NAMESPACE \
    --limit '78' \
    --offset '85' \
    --query 'ojUPgvQu' \
    --tags '["kSfKNMn0", "UPQyWHuZ", "qBeD6CB7"]' \
    > test.out 2>&1
eval_tap $? 64 'ListGameBinaryRecordsV1' test.out

#- 65 PostGameBinaryRecordV1
# body param: body
echo '{"file_type": "kMdbDRkl", "key": "G3F3w5kD"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PostGameBinaryRecordV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 65 'PostGameBinaryRecordV1' test.out

#- 66 BulkGetGameBinaryRecordV1
# body param: body
echo '{"keys": ["0QdxE53x", "xgFaXSOT", "Zvy8KIyQ"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op BulkGetGameBinaryRecordV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 66 'BulkGetGameBinaryRecordV1' test.out

#- 67 GetGameBinaryRecordV1
$CLI_EXE \
    --sn cloudsave \
    --op GetGameBinaryRecordV1 \
    --key 'INgtqw9B' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 67 'GetGameBinaryRecordV1' test.out

#- 68 PutGameBinaryRecordV1
# body param: body
echo '{"content_type": "eBWMvLt6", "file_location": "5lMlPPHd"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PutGameBinaryRecordV1 \
    --key 'SKXpBBr0' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 68 'PutGameBinaryRecordV1' test.out

#- 69 DeleteGameBinaryRecordV1
$CLI_EXE \
    --sn cloudsave \
    --op DeleteGameBinaryRecordV1 \
    --key 'kvFf1v6d' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 69 'DeleteGameBinaryRecordV1' test.out

#- 70 PostGameBinaryPresignedURLV1
# body param: body
echo '{"file_type": "zYKlSoQQ"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PostGameBinaryPresignedURLV1 \
    --key 'F4Op60N4' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 70 'PostGameBinaryPresignedURLV1' test.out

#- 71 PutGameRecordConcurrentHandlerV1
# body param: body
echo '{"updatedAt": "k5R4kXdK", "value": {"zOtIJFvY": {}, "q6dMhouV": {}, "Yu6YBi4U": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PutGameRecordConcurrentHandlerV1 \
    --key 'njrW4Vrk' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 71 'PutGameRecordConcurrentHandlerV1' test.out

#- 72 GetGameRecordsBulk
# body param: body
echo '{"keys": ["dN9XCyTT", "lMTcRhYk", "84ku2650"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op GetGameRecordsBulk \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 72 'GetGameRecordsBulk' test.out

#- 73 GetGameRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op GetGameRecordHandlerV1 \
    --key 'buniTtGU' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 73 'GetGameRecordHandlerV1' test.out

#- 74 PutGameRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PutGameRecordHandlerV1 \
    --key 'shncFzr9' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 74 'PutGameRecordHandlerV1' test.out

#- 75 PostGameRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PostGameRecordHandlerV1 \
    --key 'tt17ZH7I' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 75 'PostGameRecordHandlerV1' test.out

#- 76 DeleteGameRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op DeleteGameRecordHandlerV1 \
    --key 'NW7iBG2r' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 76 'DeleteGameRecordHandlerV1' test.out

#- 77 PublicListTagsHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op PublicListTagsHandlerV1 \
    --namespace $AB_NAMESPACE \
    --limit '28' \
    --offset '61' \
    > test.out 2>&1
eval_tap $? 77 'PublicListTagsHandlerV1' test.out

#- 78 BulkGetPlayerPublicBinaryRecordsV1
# body param: body
echo '{"userIds": ["yA9UkesH", "UiT9vtso", "wNOmapws"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op BulkGetPlayerPublicBinaryRecordsV1 \
    --key 'jUiA63FT' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 78 'BulkGetPlayerPublicBinaryRecordsV1' test.out

#- 79 BulkGetPlayerPublicRecordHandlerV1
# body param: body
echo '{"userIds": ["D9M4qYCO", "PjpGCowy", "7Z33YwEz"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op BulkGetPlayerPublicRecordHandlerV1 \
    --key 'vb8hXrka' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 79 'BulkGetPlayerPublicRecordHandlerV1' test.out

#- 80 ListMyBinaryRecordsV1
$CLI_EXE \
    --sn cloudsave \
    --op ListMyBinaryRecordsV1 \
    --namespace $AB_NAMESPACE \
    --limit '8' \
    --offset '0' \
    --query 'snzjmMVk' \
    --tags '["wXau158R", "QAIUmLSw", "FWCtWWgo"]' \
    > test.out 2>&1
eval_tap $? 80 'ListMyBinaryRecordsV1' test.out

#- 81 BulkGetMyBinaryRecordV1
# body param: body
echo '{"keys": ["3cbStG7y", "CywkzI7J", "XJAyG9YG"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op BulkGetMyBinaryRecordV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 81 'BulkGetMyBinaryRecordV1' test.out

#- 82 RetrievePlayerRecords
$CLI_EXE \
    --sn cloudsave \
    --op RetrievePlayerRecords \
    --namespace $AB_NAMESPACE \
    --limit '90' \
    --offset '27' \
    --tags '["ILH6OwcZ", "dqUYtOYv", "eZkl5Hfd"]' \
    > test.out 2>&1
eval_tap $? 82 'RetrievePlayerRecords' test.out

#- 83 GetPlayerRecordsBulkHandlerV1
# body param: body
echo '{"keys": ["i3yrVIYM", "bwdJHEEb", "L0vFIBc1"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op GetPlayerRecordsBulkHandlerV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 83 'GetPlayerRecordsBulkHandlerV1' test.out

#- 84 PublicDeletePlayerPublicRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op PublicDeletePlayerPublicRecordHandlerV1 \
    --key '2H3oVS0x' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 84 'PublicDeletePlayerPublicRecordHandlerV1' test.out

#- 85 PostPlayerBinaryRecordV1
# body param: body
echo '{"file_type": "lB3QZCqD", "is_public": true, "key": "ZCEVPUeE"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PostPlayerBinaryRecordV1 \
    --namespace $AB_NAMESPACE \
    --userId 'HEojXwU2' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 85 'PostPlayerBinaryRecordV1' test.out

#- 86 ListOtherPlayerPublicBinaryRecordsV1
$CLI_EXE \
    --sn cloudsave \
    --op ListOtherPlayerPublicBinaryRecordsV1 \
    --namespace $AB_NAMESPACE \
    --userId 'R92rs66Z' \
    --limit '5' \
    --offset '92' \
    --tags '["daQ93OYn", "VPQGXk0G", "X4usyneX"]' \
    > test.out 2>&1
eval_tap $? 86 'ListOtherPlayerPublicBinaryRecordsV1' test.out

#- 87 BulkGetOtherPlayerPublicBinaryRecordsV1
# body param: body
echo '{"keys": ["WrAbBEsU", "igK2AB9a", "FKKRizft"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op BulkGetOtherPlayerPublicBinaryRecordsV1 \
    --namespace $AB_NAMESPACE \
    --userId 'Y3MKyV6d' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 87 'BulkGetOtherPlayerPublicBinaryRecordsV1' test.out

#- 88 GetPlayerBinaryRecordV1
$CLI_EXE \
    --sn cloudsave \
    --op GetPlayerBinaryRecordV1 \
    --key '290tkVek' \
    --namespace $AB_NAMESPACE \
    --userId 'Hpyg51AC' \
    > test.out 2>&1
eval_tap $? 88 'GetPlayerBinaryRecordV1' test.out

#- 89 PutPlayerBinaryRecordV1
# body param: body
echo '{"content_type": "4c7g6Obq", "file_location": "9tlKOD63"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PutPlayerBinaryRecordV1 \
    --key 'JsEqzERA' \
    --namespace $AB_NAMESPACE \
    --userId 'eLRoYcA4' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 89 'PutPlayerBinaryRecordV1' test.out

#- 90 DeletePlayerBinaryRecordV1
$CLI_EXE \
    --sn cloudsave \
    --op DeletePlayerBinaryRecordV1 \
    --key 'm7H4ZUhf' \
    --namespace $AB_NAMESPACE \
    --userId 'aQ5BhOff' \
    > test.out 2>&1
eval_tap $? 90 'DeletePlayerBinaryRecordV1' test.out

#- 91 PutPlayerBinaryRecorMetadataV1
# body param: body
echo '{"is_public": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PutPlayerBinaryRecorMetadataV1 \
    --key 'vrmq6AF1' \
    --namespace $AB_NAMESPACE \
    --userId 'ZAoJMWMQ' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 91 'PutPlayerBinaryRecorMetadataV1' test.out

#- 92 PostPlayerBinaryPresignedURLV1
# body param: body
echo '{"file_type": "MLe7vcuM"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PostPlayerBinaryPresignedURLV1 \
    --key 'tqXqy2Cy' \
    --namespace $AB_NAMESPACE \
    --userId 'xRQvnC3n' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 92 'PostPlayerBinaryPresignedURLV1' test.out

#- 93 GetPlayerPublicBinaryRecordsV1
$CLI_EXE \
    --sn cloudsave \
    --op GetPlayerPublicBinaryRecordsV1 \
    --key 'jLU6sPuf' \
    --namespace $AB_NAMESPACE \
    --userId 'gBlN9onN' \
    > test.out 2>&1
eval_tap $? 93 'GetPlayerPublicBinaryRecordsV1' test.out

#- 94 PutPlayerRecordConcurrentHandlerV1
# body param: body
echo '{"updatedAt": "ZoHuRvgz", "value": {"riaN8SkV": {}, "i2F0gmCd": {}, "WsKG5ELt": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PutPlayerRecordConcurrentHandlerV1 \
    --key 'ATUTp8QT' \
    --namespace $AB_NAMESPACE \
    --userId 'qtED7eSS' \
    --responseBody 'true' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 94 'PutPlayerRecordConcurrentHandlerV1' test.out

#- 95 PutPlayerPublicRecordConcurrentHandlerV1
# body param: body
echo '{"updatedAt": "Et6HQwti", "value": {"jUyHVndP": {}, "mB85NMrY": {}, "xxkz31TY": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PutPlayerPublicRecordConcurrentHandlerV1 \
    --key 'n3UKAv7F' \
    --namespace $AB_NAMESPACE \
    --userId 'CNxxWqpl' \
    --responseBody 'false' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 95 'PutPlayerPublicRecordConcurrentHandlerV1' test.out

#- 96 GetOtherPlayerPublicRecordKeyHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op GetOtherPlayerPublicRecordKeyHandlerV1 \
    --namespace $AB_NAMESPACE \
    --userId '7k8f8tfU' \
    --limit '55' \
    --offset '61' \
    --tags '["8fCYOItU", "p6S8Zy4y", "dg6QIlHB"]' \
    > test.out 2>&1
eval_tap $? 96 'GetOtherPlayerPublicRecordKeyHandlerV1' test.out

#- 97 GetOtherPlayerPublicRecordHandlerV1
# body param: body
echo '{"keys": ["zkJLjKX4", "yQYGXXw7", "KA7F28pa"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op GetOtherPlayerPublicRecordHandlerV1 \
    --namespace $AB_NAMESPACE \
    --userId 'WA59cBJD' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 97 'GetOtherPlayerPublicRecordHandlerV1' test.out

#- 98 GetPlayerRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op GetPlayerRecordHandlerV1 \
    --key '5iobbzZW' \
    --namespace $AB_NAMESPACE \
    --userId 'O35h35cs' \
    > test.out 2>&1
eval_tap $? 98 'GetPlayerRecordHandlerV1' test.out

#- 99 PutPlayerRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PutPlayerRecordHandlerV1 \
    --key 'Ii7w4DOc' \
    --namespace $AB_NAMESPACE \
    --userId 'VrX9hAsU' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 99 'PutPlayerRecordHandlerV1' test.out

#- 100 PostPlayerRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PostPlayerRecordHandlerV1 \
    --key 'FoX5q4Kh' \
    --namespace $AB_NAMESPACE \
    --userId '1Gp2LNKD' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 100 'PostPlayerRecordHandlerV1' test.out

#- 101 DeletePlayerRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op DeletePlayerRecordHandlerV1 \
    --key 'mJzdH71o' \
    --namespace $AB_NAMESPACE \
    --userId 'tyml4HNv' \
    > test.out 2>&1
eval_tap $? 101 'DeletePlayerRecordHandlerV1' test.out

#- 102 GetPlayerPublicRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op GetPlayerPublicRecordHandlerV1 \
    --key 'nVoNCimJ' \
    --namespace $AB_NAMESPACE \
    --userId 'yfoYTkT8' \
    > test.out 2>&1
eval_tap $? 102 'GetPlayerPublicRecordHandlerV1' test.out

#- 103 PutPlayerPublicRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PutPlayerPublicRecordHandlerV1 \
    --key 'gPatudvx' \
    --namespace $AB_NAMESPACE \
    --userId 'KlaFBBiw' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 103 'PutPlayerPublicRecordHandlerV1' test.out

#- 104 PostPlayerPublicRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PostPlayerPublicRecordHandlerV1 \
    --key 'DJ1lgzKV' \
    --namespace $AB_NAMESPACE \
    --userId 'RuJZLOtV' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 104 'PostPlayerPublicRecordHandlerV1' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE