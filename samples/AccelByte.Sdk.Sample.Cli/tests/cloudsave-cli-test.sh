#!/usr/bin/env bash

# Copyright (c) 2021 AccelByte Inc. All Rights Reserved.
# This is licensed software from AccelByte Inc, for limitations
# and restrictions contact your company contract manager.

# This code is generated by tool. DO NOT EDIT.

# Meta:
# - random seed: 512
# - template file: cli-test.j2

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
echo "1..40"

#- 1 Login
$CLI_EXE --op login --lt user --user user --pass user > test.out 2>&1
eval_tap $? 1 'Login' test.out

if [ $EXIT_CODE -ne 0 ]; then
  echo "Bail out! Login failed."
  exit $EXIT_CODE
fi

# echo "foo" > "$CLI_TOKEN_FILE"

#- 2 AdminPutGameRecordConcurrentHandlerV1
# body param: body
echo '{"set_by": "bBuz5zko", "updatedAt": "aUEzGS3q", "value": {"Zf0PbemS": {}, "BELbZ0VB": {}, "UGA7nkDe": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutGameRecordConcurrentHandlerV1 \
    --key 'ev2Oj060' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 2 'AdminPutGameRecordConcurrentHandlerV1' test.out

#- 3 ListGameRecordsHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op ListGameRecordsHandlerV1 \
    --namespace $AB_NAMESPACE \
    --query 'HnOf5S8X' \
    --limit '65' \
    --offset '77' \
    > test.out 2>&1
eval_tap $? 3 'ListGameRecordsHandlerV1' test.out

#- 4 AdminGetGameRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminGetGameRecordHandlerV1 \
    --key 'bSmeuIBr' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 4 'AdminGetGameRecordHandlerV1' test.out

#- 5 AdminPutGameRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutGameRecordHandlerV1 \
    --key 'oF7bwRgw' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 5 'AdminPutGameRecordHandlerV1' test.out

#- 6 AdminPostGameRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPostGameRecordHandlerV1 \
    --key 'KvzESbhp' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 6 'AdminPostGameRecordHandlerV1' test.out

#- 7 AdminDeleteGameRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminDeleteGameRecordHandlerV1 \
    --key 'xlDdEs4i' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 7 'AdminDeleteGameRecordHandlerV1' test.out

#- 8 BulkGetPlayerRecordSizeHandlerV1
# body param: body
echo '{"data": [{"keys": ["gdKeLmy8", "tZ5GZi5P", "12c61ts3"], "user_id": "fMI04rm2"}, {"keys": ["jUc9iav3", "tTqlE9oL", "DPD0Lfle"], "user_id": "8ESU1MO8"}, {"keys": ["XnVaEyjm", "ifJDYa1T", "JPUszmFG"], "user_id": "EkJVvqDS"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op BulkGetPlayerRecordSizeHandlerV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 8 'BulkGetPlayerRecordSizeHandlerV1' test.out

#- 9 ListPlayerRecordHandlerV1
eval_tap 0 9 'ListPlayerRecordHandlerV1 # SKIP deprecated' test.out

#- 10 AdminPutPlayerRecordConcurrentHandlerV1
# body param: body
echo '{"set_by": "U3PDyIAG", "updatedAt": "fGq1FNmR", "value": {"WvUvDPnK": {}, "oECjGUg8": {}, "67xodwuG": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutPlayerRecordConcurrentHandlerV1 \
    --key '14ID5l5w' \
    --namespace $AB_NAMESPACE \
    --userId 'j6K2wEMn' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 10 'AdminPutPlayerRecordConcurrentHandlerV1' test.out

#- 11 AdminPutPlayerPublicRecordConcurrentHandlerV1
# body param: body
echo '{"set_by": "ckjlW6By", "updatedAt": "wsSSZTGl", "value": {"ubsmhjXc": {}, "ScOUvrjJ": {}, "BO7tbkTG": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutPlayerPublicRecordConcurrentHandlerV1 \
    --key 'YKqRMSTi' \
    --namespace $AB_NAMESPACE \
    --userId 'sP0MrSda' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 11 'AdminPutPlayerPublicRecordConcurrentHandlerV1' test.out

#- 12 AdminRetrievePlayerRecords
$CLI_EXE \
    --sn cloudsave \
    --op AdminRetrievePlayerRecords \
    --namespace $AB_NAMESPACE \
    --userId 'Fy0pJYCd' \
    --limit '12' \
    --offset '45' \
    > test.out 2>&1
eval_tap $? 12 'AdminRetrievePlayerRecords' test.out

#- 13 AdminGetPlayerRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminGetPlayerRecordHandlerV1 \
    --key 'kfyt09ro' \
    --namespace $AB_NAMESPACE \
    --userId '5fHdWqJT' \
    > test.out 2>&1
eval_tap $? 13 'AdminGetPlayerRecordHandlerV1' test.out

#- 14 AdminPutPlayerRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutPlayerRecordHandlerV1 \
    --key 'NjrmpnnE' \
    --namespace $AB_NAMESPACE \
    --userId 'ckHH8kT9' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 14 'AdminPutPlayerRecordHandlerV1' test.out

#- 15 AdminPostPlayerRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPostPlayerRecordHandlerV1 \
    --key 'oXVander' \
    --namespace $AB_NAMESPACE \
    --userId 'cf1nq4Hf' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 15 'AdminPostPlayerRecordHandlerV1' test.out

#- 16 AdminDeletePlayerRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminDeletePlayerRecordHandlerV1 \
    --key '32SL5Pja' \
    --namespace $AB_NAMESPACE \
    --userId 'YEDxaYN8' \
    > test.out 2>&1
eval_tap $? 16 'AdminDeletePlayerRecordHandlerV1' test.out

#- 17 AdminGetPlayerPublicRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminGetPlayerPublicRecordHandlerV1 \
    --key 'w9KUW0py' \
    --namespace $AB_NAMESPACE \
    --userId '8KrcQfuc' \
    > test.out 2>&1
eval_tap $? 17 'AdminGetPlayerPublicRecordHandlerV1' test.out

#- 18 AdminPutPlayerPublicRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutPlayerPublicRecordHandlerV1 \
    --key 'Sq2X8gFu' \
    --namespace $AB_NAMESPACE \
    --userId 'JORk4j04' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 18 'AdminPutPlayerPublicRecordHandlerV1' test.out

#- 19 AdminPostPlayerPublicRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPostPlayerPublicRecordHandlerV1 \
    --key 'YfnXTsQU' \
    --namespace $AB_NAMESPACE \
    --userId 'rA0WWyKl' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 19 'AdminPostPlayerPublicRecordHandlerV1' test.out

#- 20 AdminDeletePlayerPublicRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminDeletePlayerPublicRecordHandlerV1 \
    --key '2K5mCSoG' \
    --namespace $AB_NAMESPACE \
    --userId 'eQCahcox' \
    > test.out 2>&1
eval_tap $? 20 'AdminDeletePlayerPublicRecordHandlerV1' test.out

#- 21 AdminGetPlayerRecordSizeHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminGetPlayerRecordSizeHandlerV1 \
    --key '63cyDxAA' \
    --namespace $AB_NAMESPACE \
    --userId 'YcRXJdoS' \
    > test.out 2>&1
eval_tap $? 21 'AdminGetPlayerRecordSizeHandlerV1' test.out

#- 22 PutGameRecordConcurrentHandlerV1
# body param: body
echo '{"updatedAt": "TxNCK9AI", "value": {"jNmbfoW8": {}, "bDq5jPqz": {}, "hN0YdGSr": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PutGameRecordConcurrentHandlerV1 \
    --key 'A9LXRwU6' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 22 'PutGameRecordConcurrentHandlerV1' test.out

#- 23 GetGameRecordsBulk
# body param: body
echo '{"keys": ["WLgpQE9n", "XzhBC0uy", "MR4Xf2nf"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op GetGameRecordsBulk \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 23 'GetGameRecordsBulk' test.out

#- 24 GetGameRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op GetGameRecordHandlerV1 \
    --key 'YvNvG8uQ' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 24 'GetGameRecordHandlerV1' test.out

#- 25 PutGameRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PutGameRecordHandlerV1 \
    --key '14AhsxaA' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 25 'PutGameRecordHandlerV1' test.out

#- 26 PostGameRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PostGameRecordHandlerV1 \
    --key 'LiBwpNJo' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 26 'PostGameRecordHandlerV1' test.out

#- 27 DeleteGameRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op DeleteGameRecordHandlerV1 \
    --key 'rnrCQpMJ' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 27 'DeleteGameRecordHandlerV1' test.out

#- 28 BulkGetPlayerPublicRecordHandlerV1
# body param: body
echo '{"userIds": ["j5igqat8", "xnPoWTdH", "AkcyAy4d"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op BulkGetPlayerPublicRecordHandlerV1 \
    --key 'rHlPcXGG' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 28 'BulkGetPlayerPublicRecordHandlerV1' test.out

#- 29 RetrievePlayerRecords
$CLI_EXE \
    --sn cloudsave \
    --op RetrievePlayerRecords \
    --namespace $AB_NAMESPACE \
    --limit '23' \
    --offset '26' \
    > test.out 2>&1
eval_tap $? 29 'RetrievePlayerRecords' test.out

#- 30 GetPlayerRecordsBulkHandlerV1
# body param: body
echo '{"keys": ["w3veBfrp", "CrnbaxhE", "vn3SGqcH"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op GetPlayerRecordsBulkHandlerV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 30 'GetPlayerRecordsBulkHandlerV1' test.out

#- 31 PublicDeletePlayerPublicRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op PublicDeletePlayerPublicRecordHandlerV1 \
    --key '91fC3aJE' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 31 'PublicDeletePlayerPublicRecordHandlerV1' test.out

#- 32 PutPlayerRecordConcurrentHandlerV1
# body param: body
echo '{"updatedAt": "oqWaFAGD", "value": {"6PRg95m0": {}, "7l03vtlM": {}, "FzeiMRkc": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PutPlayerRecordConcurrentHandlerV1 \
    --key 'Or1L0TMI' \
    --namespace $AB_NAMESPACE \
    --userId 'czbYilOz' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 32 'PutPlayerRecordConcurrentHandlerV1' test.out

#- 33 PutPlayerPublicRecordConcurrentHandlerV1
# body param: body
echo '{"updatedAt": "iwG8CPLO", "value": {"zSZm9K3c": {}, "MY617HSC": {}, "YZaL46I3": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PutPlayerPublicRecordConcurrentHandlerV1 \
    --key 'PgCcQ0ax' \
    --namespace $AB_NAMESPACE \
    --userId 'TWnmyEYL' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 33 'PutPlayerPublicRecordConcurrentHandlerV1' test.out

#- 34 GetPlayerRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op GetPlayerRecordHandlerV1 \
    --key 'ZQTpvLH6' \
    --namespace $AB_NAMESPACE \
    --userId 'QPEBP8kS' \
    > test.out 2>&1
eval_tap $? 34 'GetPlayerRecordHandlerV1' test.out

#- 35 PutPlayerRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PutPlayerRecordHandlerV1 \
    --key 'SFjeuL3w' \
    --namespace $AB_NAMESPACE \
    --userId 'QQPYwmYF' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 35 'PutPlayerRecordHandlerV1' test.out

#- 36 PostPlayerRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PostPlayerRecordHandlerV1 \
    --key 'bxRvHYDC' \
    --namespace $AB_NAMESPACE \
    --userId 'YwoGdmzX' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 36 'PostPlayerRecordHandlerV1' test.out

#- 37 DeletePlayerRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op DeletePlayerRecordHandlerV1 \
    --key 'gf1ewUTv' \
    --namespace $AB_NAMESPACE \
    --userId 'nu0ensa3' \
    > test.out 2>&1
eval_tap $? 37 'DeletePlayerRecordHandlerV1' test.out

#- 38 GetPlayerPublicRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op GetPlayerPublicRecordHandlerV1 \
    --key 'MZF7DTsw' \
    --namespace $AB_NAMESPACE \
    --userId 'nkSyuJTV' \
    > test.out 2>&1
eval_tap $? 38 'GetPlayerPublicRecordHandlerV1' test.out

#- 39 PutPlayerPublicRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PutPlayerPublicRecordHandlerV1 \
    --key 'jKQ1ORLE' \
    --namespace $AB_NAMESPACE \
    --userId 'IAePvDO2' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 39 'PutPlayerPublicRecordHandlerV1' test.out

#- 40 PostPlayerPublicRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PostPlayerPublicRecordHandlerV1 \
    --key 'xkVgyRk1' \
    --namespace $AB_NAMESPACE \
    --userId '0b27RdU8' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 40 'PostPlayerPublicRecordHandlerV1' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE