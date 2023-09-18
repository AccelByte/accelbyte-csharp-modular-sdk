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
    --podName '3LZg52pM' \
    --logType 'EyN3zvyr' \
    --offset '3' \
    --origin 'uL7QuByr' \
    > test.out 2>&1
eval_tap $? 2 'GetServerLogs' test.out

#- 3 ListTerminatedServers
$CLI_EXE \
    --sn dslogmanager \
    --op ListTerminatedServers \
    --namespace $AB_NAMESPACE \
    --deployment 'yiVr74Ae' \
    --endDate 'uSnhaMkv' \
    --gameMode '9FdChCe9' \
    --limit '32' \
    --next 'ANub1n0t' \
    --partyId 'g0bXEhoq' \
    --podName 'jLkV2UiX' \
    --previous '9DFieASu' \
    --provider 'auXIcaIg' \
    --region 'EOMm1LAe' \
    --sessionId 'sRVIF5WW' \
    --startDate 'DsrDM0hF' \
    --status 'OEUhyU1w' \
    --userId 'LBT8hEfT' \
    > test.out 2>&1
eval_tap $? 3 'ListTerminatedServers' test.out

#- 4 DownloadServerLogs
$CLI_EXE \
    --sn dslogmanager \
    --op DownloadServerLogs \
    --namespace $AB_NAMESPACE \
    --podName 'RSiobbyc' \
    > test.out 2>&1
eval_tap $? 4 'DownloadServerLogs' test.out

#- 5 CheckServerLogs
$CLI_EXE \
    --sn dslogmanager \
    --op CheckServerLogs \
    --namespace $AB_NAMESPACE \
    --podName 'UEolItXI' \
    > test.out 2>&1
eval_tap $? 5 'CheckServerLogs' test.out

#- 6 BatchDownloadServerLogs
# body param: body
echo '{"Downloads": [{"alloc_id": "EEux3PDJ", "namespace": "p79bXoUQ", "pod_name": "chaNXxXL"}, {"alloc_id": "Mqqk3VLT", "namespace": "pt1NhcDE", "pod_name": "Z7ZN38MN"}, {"alloc_id": "reXiRUSu", "namespace": "AbtCq6JL", "pod_name": "aUToDTXk"}]}' > $TEMP_JSON_INPUT
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
    --deployment 'ljnmxge7' \
    --endDate 'DLcgGH0I' \
    --gameMode 'f7N25zFM' \
    --limit '30' \
    --namespace_ 'tJE3g5vm' \
    --next '8nULfmD8' \
    --partyId 'XJix0BEY' \
    --podName '2CfnIWh5' \
    --previous 't81ClbqP' \
    --provider 'xd0WAoPH' \
    --region '2CmPhYzR' \
    --sessionId 'VUjIspdw' \
    --startDate 'xM8SuUsn' \
    --status 'CCao3Kqq' \
    --userId 'mJLuflNU' \
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