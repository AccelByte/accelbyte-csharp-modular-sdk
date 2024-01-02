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
echo "1..8"

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
    --podName '9nY7SyMG' \
    --logType 'x690YVpD' \
    --offset '25' \
    --origin 'nCCSYHq7' \
    > test.out 2>&1
eval_tap $? 2 'GetServerLogs' test.out

#- 3 ListTerminatedServers
$CLI_EXE \
    --sn dslogmanager \
    --op ListTerminatedServers \
    --namespace $AB_NAMESPACE \
    --deployment 'Y47IbBmO' \
    --endDate 'b6BFD25V' \
    --gameMode 'uhbVFioT' \
    --limit '41' \
    --next 'zQNdhK4o' \
    --partyId 'TsQw4YWy' \
    --podName 'KMoWaMnk' \
    --previous 'Q4CpwEbr' \
    --provider 'xsAXWYUd' \
    --region 'XE1Q5zCT' \
    --sessionId 'rBzb03yO' \
    --source 'RZLA4jI8' \
    --startDate '3XDgbBte' \
    --status 'MM1oiXHu' \
    --userId 'GLrCgG6Y' \
    > test.out 2>&1
eval_tap $? 3 'ListTerminatedServers' test.out

#- 4 DownloadServerLogs
$CLI_EXE \
    --sn dslogmanager \
    --op DownloadServerLogs \
    --namespace $AB_NAMESPACE \
    --podName 'LKgsuCwW' \
    > test.out 2>&1
eval_tap $? 4 'DownloadServerLogs' test.out

#- 5 CheckServerLogs
$CLI_EXE \
    --sn dslogmanager \
    --op CheckServerLogs \
    --namespace $AB_NAMESPACE \
    --podName 'F6rZFB1q' \
    > test.out 2>&1
eval_tap $? 5 'CheckServerLogs' test.out

#- 6 BatchDownloadServerLogs
# body param: body
echo '{"Downloads": [{"alloc_id": "UaGlVyjD", "namespace": "ZXnq4tFN", "pod_name": "vHLu13zJ"}, {"alloc_id": "VE04jttO", "namespace": "bsbHQZa0", "pod_name": "j9psKc6B"}, {"alloc_id": "JRM7nOSx", "namespace": "QVYvxqN3", "pod_name": "k0b766Xj"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dslogmanager \
    --op BatchDownloadServerLogs \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 6 'BatchDownloadServerLogs' test.out

#- 7 ListAllTerminatedServers
$CLI_EXE \
    --sn dslogmanager \
    --op ListAllTerminatedServers \
    --deployment 'kSwLOl2z' \
    --endDate '75EUoKlu' \
    --gameMode '1o3fMtnB' \
    --limit '49' \
    --namespace_ 'zn9yEJqb' \
    --next 'Ok3BUzsf' \
    --partyId 'Zv7g0PfZ' \
    --podName '3S7OaytP' \
    --previous '8XC7F9U6' \
    --provider 'x03YYpxu' \
    --region 'h2jG6bwV' \
    --sessionId 'IA3WI6yL' \
    --startDate 'kLsNQLrc' \
    --status '3j0FdAHG' \
    --userId '1qvewLZo' \
    > test.out 2>&1
eval_tap $? 7 'ListAllTerminatedServers' test.out

#- 8 PublicGetMessages
$CLI_EXE \
    --sn dslogmanager \
    --op PublicGetMessages \
    > test.out 2>&1
eval_tap $? 8 'PublicGetMessages' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE