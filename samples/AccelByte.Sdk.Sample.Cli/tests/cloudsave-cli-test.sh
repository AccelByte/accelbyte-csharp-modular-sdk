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
echo "1..42"

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
echo '{"set_by": "bBuz5zkoaUEzGS3q", "updatedAt": "Zf0PbemSBELbZ0VB", "value": {"UGA7nkDeev2Oj060": {}, "HnOf5S8X1LxkZs42": {}, "33oQWoXFeqeuI2oM": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutGameRecordConcurrentHandlerV1 \
    --key 'J0cgAoGfXepE3r5A' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 2 'AdminPutGameRecordConcurrentHandlerV1' test.out

#- 3 ListGameRecordsHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op ListGameRecordsHandlerV1 \
    --namespace $AB_NAMESPACE \
    --query 'QUBqS8KtTYZLJ58Q' \
    --limit '34' \
    --offset '4' \
    > test.out 2>&1
eval_tap $? 3 'ListGameRecordsHandlerV1' test.out

#- 4 AdminGetGameRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminGetGameRecordHandlerV1 \
    --key 'fMI04rm2jUc9iav3' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 4 'AdminGetGameRecordHandlerV1' test.out

#- 5 AdminPutGameRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutGameRecordHandlerV1 \
    --key 'tTqlE9oLDPD0Lfle' \
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
    --key '8ESU1MO8XnVaEyjm' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 6 'AdminPostGameRecordHandlerV1' test.out

#- 7 AdminDeleteGameRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminDeleteGameRecordHandlerV1 \
    --key 'ifJDYa1TJPUszmFG' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 7 'AdminDeleteGameRecordHandlerV1' test.out

#- 8 BulkGetPlayerRecordSizeHandlerV1
# body param: body
echo '{"data": [{"keys": ["EkJVvqDSU3PDyIAG", "fGq1FNmRWvUvDPnK", "oECjGUg867xodwuG"], "user_id": "14ID5l5wj6K2wEMn"}, {"keys": ["ckjlW6BywsSSZTGl", "ubsmhjXcScOUvrjJ", "BO7tbkTGYKqRMSTi"], "user_id": "sP0MrSdaFy0pJYCd"}, {"keys": ["fkfyt09ro5fHdWqJ", "TNjrmpnnEckHH8kT", "9oXVandercf1nq4H"], "user_id": "f32SL5PjaYEDxaYN"}]}' > $TEMP_JSON_INPUT
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
echo '{"set_by": "8w9KUW0py8KrcQfu", "updatedAt": "cSq2X8gFuJORk4j0", "value": {"4YfnXTsQUrA0WWyK": {}, "l2K5mCSoGeQCahco": {}, "x63cyDxAAYcRXJdo": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutPlayerRecordConcurrentHandlerV1 \
    --key 'STxNCK9AIjNmbfoW' \
    --namespace $AB_NAMESPACE \
    --userId '8bDq5jPqzhN0YdGS' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 10 'AdminPutPlayerRecordConcurrentHandlerV1' test.out

#- 11 AdminPutPlayerPublicRecordConcurrentHandlerV1
# body param: body
echo '{"set_by": "rA9LXRwU6WLgpQE9", "updatedAt": "nXzhBC0uyMR4Xf2n", "value": {"fYvNvG8uQ14Ahsxa": {}, "ALiBwpNJornrCQpM": {}, "Jj5igqat8xnPoWTd": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutPlayerPublicRecordConcurrentHandlerV1 \
    --key 'HAkcyAy4drHlPcXG' \
    --namespace $AB_NAMESPACE \
    --userId 'Gl0Xw3veBfrpCrnb' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 11 'AdminPutPlayerPublicRecordConcurrentHandlerV1' test.out

#- 12 AdminRetrievePlayerRecords
$CLI_EXE \
    --sn cloudsave \
    --op AdminRetrievePlayerRecords \
    --namespace $AB_NAMESPACE \
    --userId 'axhEvn3SGqcH91fC' \
    --limit '82' \
    --offset '0' \
    > test.out 2>&1
eval_tap $? 12 'AdminRetrievePlayerRecords' test.out

#- 13 AdminGetPlayerRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminGetPlayerRecordHandlerV1 \
    --key 'AsW8wYh4gq7pRVZV' \
    --namespace $AB_NAMESPACE \
    --userId 'LJiDx3au9b9QjhzD' \
    > test.out 2>&1
eval_tap $? 13 'AdminGetPlayerRecordHandlerV1' test.out

#- 14 AdminPutPlayerRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutPlayerRecordHandlerV1 \
    --key 'lnJmi4XaBTgoXjfd' \
    --namespace $AB_NAMESPACE \
    --userId 'UQHa3RxspSqwdbTR' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 14 'AdminPutPlayerRecordHandlerV1' test.out

#- 15 AdminPostPlayerRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPostPlayerRecordHandlerV1 \
    --key '2sgzfaQrUCW9fgo6' \
    --namespace $AB_NAMESPACE \
    --userId '9uv1bkFx8DmbC9Uq' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 15 'AdminPostPlayerRecordHandlerV1' test.out

#- 16 AdminDeletePlayerRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminDeletePlayerRecordHandlerV1 \
    --key 'YdYrdxNnuMcAwrSz' \
    --namespace $AB_NAMESPACE \
    --userId 'YnrcetxObeisZelK' \
    > test.out 2>&1
eval_tap $? 16 'AdminDeletePlayerRecordHandlerV1' test.out

#- 17 AdminGetPlayerPublicRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminGetPlayerPublicRecordHandlerV1 \
    --key 'uD0iJ6fs3zL9H4Wx' \
    --namespace $AB_NAMESPACE \
    --userId 'GWRH7fz4BdPhLtHR' \
    > test.out 2>&1
eval_tap $? 17 'AdminGetPlayerPublicRecordHandlerV1' test.out

#- 18 AdminPutPlayerPublicRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPutPlayerPublicRecordHandlerV1 \
    --key 'JOImSq37aeAaGq0N' \
    --namespace $AB_NAMESPACE \
    --userId 'Ij53gXkmrayvcIYi' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 18 'AdminPutPlayerPublicRecordHandlerV1' test.out

#- 19 AdminPostPlayerPublicRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op AdminPostPlayerPublicRecordHandlerV1 \
    --key 'WxIAxfvLzSpDFY3l' \
    --namespace $AB_NAMESPACE \
    --userId 'xe16KsSRzkf2HzBc' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 19 'AdminPostPlayerPublicRecordHandlerV1' test.out

#- 20 AdminDeletePlayerPublicRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminDeletePlayerPublicRecordHandlerV1 \
    --key 'Eio5UyvuFv5z6wos' \
    --namespace $AB_NAMESPACE \
    --userId 'JGnUyCMEbHh1uE4D' \
    > test.out 2>&1
eval_tap $? 20 'AdminDeletePlayerPublicRecordHandlerV1' test.out

#- 21 AdminGetPlayerRecordSizeHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op AdminGetPlayerRecordSizeHandlerV1 \
    --key 'mJ4Suj6DjUw36GtZ' \
    --namespace $AB_NAMESPACE \
    --userId '83Jp2f9f1FCoIo3L' \
    > test.out 2>&1
eval_tap $? 21 'AdminGetPlayerRecordSizeHandlerV1' test.out

#- 22 PutGameRecordConcurrentHandlerV1
# body param: body
echo '{"updatedAt": "24DKGwgZ85vyFJR8", "value": {"euQBLVu27iwplLJd": {}, "zYS9K0VvwE6MAqPc": {}, "8lGIYWTwxyqQQIXV": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PutGameRecordConcurrentHandlerV1 \
    --key 'mrtRlq1jv60HTnmF' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 22 'PutGameRecordConcurrentHandlerV1' test.out

#- 23 GetGameRecordsBulk
# body param: body
echo '{"keys": ["rl3gYx6Xmv1DzPHu", "x3k3skhn3mWZjTYM", "95e4aa8xOJu7rNRV"]}' > $TEMP_JSON_INPUT
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
    --key 'dygfKmUkzj9mHFpf' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 24 'GetGameRecordHandlerV1' test.out

#- 25 PutGameRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PutGameRecordHandlerV1 \
    --key 'f2vDkz68zorEgcEx' \
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
    --key 'v9nKMOgO5W8SUaZj' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 26 'PostGameRecordHandlerV1' test.out

#- 27 DeleteGameRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op DeleteGameRecordHandlerV1 \
    --key 'CpNtJSMm8kDi3Rwu' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 27 'DeleteGameRecordHandlerV1' test.out

#- 28 BulkGetPlayerPublicRecordHandlerV1
# body param: body
echo '{"userIds": ["bq7wtRGdT447Oa51", "m6VLfjsw270pMmOQ", "JrpEBbVvBn8Lsf2q"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op BulkGetPlayerPublicRecordHandlerV1 \
    --key 'SAtizV9hzsVbpJLt' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 28 'BulkGetPlayerPublicRecordHandlerV1' test.out

#- 29 RetrievePlayerRecords
$CLI_EXE \
    --sn cloudsave \
    --op RetrievePlayerRecords \
    --namespace $AB_NAMESPACE \
    --limit '63' \
    --offset '43' \
    > test.out 2>&1
eval_tap $? 29 'RetrievePlayerRecords' test.out

#- 30 GetPlayerRecordsBulkHandlerV1
# body param: body
echo '{"keys": ["ZjuyFhvbxX2DNbkn", "fVv4nm70TCayYAkF", "18YBwRxcREyU5Cwq"]}' > $TEMP_JSON_INPUT
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
    --key 'GJF6nDi33Iztr2Qc' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 31 'PublicDeletePlayerPublicRecordHandlerV1' test.out

#- 32 PutPlayerRecordConcurrentHandlerV1
# body param: body
echo '{"updatedAt": "wlRrReRajlpk8lfu", "value": {"iJVcktlx9zJZVVCc": {}, "9bpIHEWQMmCkIqwq": {}, "poTVCNrcaVozsjIX": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PutPlayerRecordConcurrentHandlerV1 \
    --key 'O2EUsAfBvo6Llcal' \
    --namespace $AB_NAMESPACE \
    --userId 'ks2R3VMtipTVxXAF' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 32 'PutPlayerRecordConcurrentHandlerV1' test.out

#- 33 PutPlayerPublicRecordConcurrentHandlerV1
# body param: body
echo '{"updatedAt": "8KhOKqbrECijFxOp", "value": {"OzxeTLJQsZcTEzXa": {}, "XUzpsAV6ct6XITL0": {}, "QEkadMSQluAoED9o": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PutPlayerPublicRecordConcurrentHandlerV1 \
    --key 'YwS8oLyErKvRtHFG' \
    --namespace $AB_NAMESPACE \
    --userId 'JRoGW7VBG1VB2sp2' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 33 'PutPlayerPublicRecordConcurrentHandlerV1' test.out

#- 34 GetOtherPlayerPublicRecordKeyHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op GetOtherPlayerPublicRecordKeyHandlerV1 \
    --namespace $AB_NAMESPACE \
    --userId 'x9mszGGoyhGZAzt2' \
    --limit '84' \
    --offset '81' \
    > test.out 2>&1
eval_tap $? 34 'GetOtherPlayerPublicRecordKeyHandlerV1' test.out

#- 35 GetOtherPlayerPublicRecordHandlerV1
# body param: body
echo '{"keys": ["VBTLwSH8hWRU9pbI", "tGQ7VUWBhGolwafI", "fbF1GLFnrQ4T5cmw"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op GetOtherPlayerPublicRecordHandlerV1 \
    --namespace $AB_NAMESPACE \
    --userId '7U1TxiS06UEoaDZp' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 35 'GetOtherPlayerPublicRecordHandlerV1' test.out

#- 36 GetPlayerRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op GetPlayerRecordHandlerV1 \
    --key 'XOWzpXOi2cpajtqc' \
    --namespace $AB_NAMESPACE \
    --userId 'XjPkj2IzU3MEpCt1' \
    > test.out 2>&1
eval_tap $? 36 'GetPlayerRecordHandlerV1' test.out

#- 37 PutPlayerRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PutPlayerRecordHandlerV1 \
    --key 'IjlfHJM92t9j1XT2' \
    --namespace $AB_NAMESPACE \
    --userId 'ErwIxkaTnYtr1YDn' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 37 'PutPlayerRecordHandlerV1' test.out

#- 38 PostPlayerRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PostPlayerRecordHandlerV1 \
    --key 'aXB0JOS4XKVT66sH' \
    --namespace $AB_NAMESPACE \
    --userId 'YPgVsfhoEidKw4IP' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 38 'PostPlayerRecordHandlerV1' test.out

#- 39 DeletePlayerRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op DeletePlayerRecordHandlerV1 \
    --key '0NVnaangorhVFpTR' \
    --namespace $AB_NAMESPACE \
    --userId 'uQyMroT2hNfKJ7q8' \
    > test.out 2>&1
eval_tap $? 39 'DeletePlayerRecordHandlerV1' test.out

#- 40 GetPlayerPublicRecordHandlerV1
$CLI_EXE \
    --sn cloudsave \
    --op GetPlayerPublicRecordHandlerV1 \
    --key 'sifSPmYSsBxtyKWs' \
    --namespace $AB_NAMESPACE \
    --userId 'sEn5VEvIMEB4pl50' \
    > test.out 2>&1
eval_tap $? 40 'GetPlayerPublicRecordHandlerV1' test.out

#- 41 PutPlayerPublicRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PutPlayerPublicRecordHandlerV1 \
    --key '6fLCG6EAl7d3Ks65' \
    --namespace $AB_NAMESPACE \
    --userId 'thtnjcMSw1J42fth' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 41 'PutPlayerPublicRecordHandlerV1' test.out

#- 42 PostPlayerPublicRecordHandlerV1
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn cloudsave \
    --op PostPlayerPublicRecordHandlerV1 \
    --key 'KUobas2CAlSxxVhD' \
    --namespace $AB_NAMESPACE \
    --userId 'R9hlaznetBUGcQz2' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 42 'PostPlayerPublicRecordHandlerV1' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE