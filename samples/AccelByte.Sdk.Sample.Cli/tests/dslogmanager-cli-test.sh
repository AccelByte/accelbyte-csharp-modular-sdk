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
echo "1..9"

#- 1 Login
$CLI_EXE --op login --lt user --user user --pass user > test.out 2>&1
eval_tap $? 1 'Login' test.out

if [ $EXIT_CODE -ne 0 ]; then
  echo "Bail out! Login failed."
  exit $EXIT_CODE
fi

# echo "foo" > "$CLI_TOKEN_FILE"

#- 2 GetServerLogs
$CLI_EXE \
    --sn dslogmanager \
    --op GetServerLogs \
    --namespace $AB_NAMESPACE \
    --podName 'n6DFg3Bx' \
    --logType 'KOSTxbtD' \
    --offset '86' \
    --origin 'WS4Pz5KI' \
    > test.out 2>&1
eval_tap $? 2 'GetServerLogs' test.out

#- 3 ListTerminatedServers
$CLI_EXE \
    --sn dslogmanager \
    --op ListTerminatedServers \
    --namespace $AB_NAMESPACE \
    --deployment 'O6AX5Cjc' \
    --endDate 'du3UBq8v' \
    --gameMode '156hdvix' \
    --limit '72' \
    --next 'XI3bY8zE' \
    --partyId 'BqaBdFJ7' \
    --podName 'Cux3hErt' \
    --previous 'dUSan9Vh' \
    --provider '9PW8gT5B' \
    --region 'WahwPcgx' \
    --sessionId 'XygZZ9eq' \
    --source 'W4AsAalI' \
    --startDate 'E3vLXkh6' \
    --status 'VnTBfamb' \
    --userId 'U6btpuYg' \
    > test.out 2>&1
eval_tap $? 3 'ListTerminatedServers' test.out

#- 4 DownloadServerLogs
$CLI_EXE \
    --sn dslogmanager \
    --op DownloadServerLogs \
    --namespace $AB_NAMESPACE \
    --podName 'zYS3fTwz' \
    > test.out 2>&1
eval_tap $? 4 'DownloadServerLogs' test.out

#- 5 CheckServerLogs
$CLI_EXE \
    --sn dslogmanager \
    --op CheckServerLogs \
    --namespace $AB_NAMESPACE \
    --podName '81xmY9fA' \
    > test.out 2>&1
eval_tap $? 5 'CheckServerLogs' test.out

#- 6 BatchDownloadServerLogs
# body param: body
echo '{"Downloads": [{"alloc_id": "asfIX7es", "namespace": "fW3Z7R7R", "pod_name": "jmBQH8Ki"}, {"alloc_id": "oV4p0PMK", "namespace": "1erPdRob", "pod_name": "eg0sRkdi"}, {"alloc_id": "c9Mlm8WE", "namespace": "N0AVB4eM", "pod_name": "MSfH19wL"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dslogmanager \
    --op BatchDownloadServerLogs \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 6 'BatchDownloadServerLogs' test.out

#- 7 ListMetadataServers
# body param: body
echo '{"pod_names": ["uahbmr06", "qwj5C5gm", "pDt0EEso"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dslogmanager \
    --op ListMetadataServers \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 7 'ListMetadataServers' test.out

#- 8 ListAllTerminatedServers
$CLI_EXE \
    --sn dslogmanager \
    --op ListAllTerminatedServers \
    --deployment '1vPNRng2' \
    --endDate 'G0t89DWs' \
    --gameMode 'YPZJAq2d' \
    --limit '59' \
    --namespace_ 'unBBP9hT' \
    --next 'hzOBckb1' \
    --partyId 'n2ZlwDCa' \
    --podName 'i2XwsGCU' \
    --previous 'pD2b6HNM' \
    --provider 'B54e0DIe' \
    --region 'XdRfgHxI' \
    --sessionId 'JNAy9Gbq' \
    --startDate 'wg4NERp9' \
    --status 'gFkYCZro' \
    --userId 'DDgJfRSn' \
    > test.out 2>&1
eval_tap $? 8 'ListAllTerminatedServers' test.out

#- 9 PublicGetMessages
$CLI_EXE \
    --sn dslogmanager \
    --op PublicGetMessages \
    > test.out 2>&1
eval_tap $? 9 'PublicGetMessages' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE