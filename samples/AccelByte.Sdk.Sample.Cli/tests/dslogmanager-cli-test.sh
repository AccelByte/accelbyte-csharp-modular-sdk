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
    --podName '3Xs9YyXZ' \
    --logType 'Xd4CmtzU' \
    --offset '80' \
    --origin 'xyTKHfXx' \
    > test.out 2>&1
eval_tap $? 2 'GetServerLogs' test.out

#- 3 ListTerminatedServers
$CLI_EXE \
    --sn dslogmanager \
    --op ListTerminatedServers \
    --namespace $AB_NAMESPACE \
    --deployment 'j2QpmHDj' \
    --endDate 'pH5LgvI1' \
    --gameMode 'Fx6XO8T6' \
    --limit '87' \
    --next 'Hn011nex' \
    --partyId 'OEEJAvYw' \
    --podName 'TznQzq19' \
    --previous 'AWtKecMv' \
    --provider '2jkc9CQj' \
    --region 'RgzUBh4X' \
    --sessionId 'Sgve7TUG' \
    --source 'HaFaXSm2' \
    --startDate 'maRp4jBi' \
    --status 'QbsY4B78' \
    --userId 'tROSv9hy' \
    > test.out 2>&1
eval_tap $? 3 'ListTerminatedServers' test.out

#- 4 DownloadServerLogs
$CLI_EXE \
    --sn dslogmanager \
    --op DownloadServerLogs \
    --namespace $AB_NAMESPACE \
    --podName '4SXbOXT8' \
    > test.out 2>&1
eval_tap $? 4 'DownloadServerLogs' test.out

#- 5 CheckServerLogs
$CLI_EXE \
    --sn dslogmanager \
    --op CheckServerLogs \
    --namespace $AB_NAMESPACE \
    --podName 'le5CpLay' \
    > test.out 2>&1
eval_tap $? 5 'CheckServerLogs' test.out

#- 6 BatchDownloadServerLogs
# body param: body
echo '{"Downloads": [{"alloc_id": "wYKVMknu", "namespace": "Mo8rgtNf", "pod_name": "NVmRHat7"}, {"alloc_id": "ZD3dEWCj", "namespace": "eaEURW1F", "pod_name": "ETzcOXRz"}, {"alloc_id": "2bwuPllE", "namespace": "8iizxUdc", "pod_name": "Fty7MjQN"}]}' > $TEMP_JSON_INPUT
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
    --deployment 'yzHEI5Uh' \
    --endDate 'HZjgeg8O' \
    --gameMode 'bLRIz7gN' \
    --limit '9' \
    --namespace_ '2o7VHNFy' \
    --next 'VFeu4U02' \
    --partyId 'CPBM6v2B' \
    --podName '4ogXBSKe' \
    --previous 'nLYbyLyd' \
    --provider 'oqD1GiLV' \
    --region 'ZLw4bb4g' \
    --sessionId 'STAfofRL' \
    --startDate 'p7WzpjHX' \
    --status 'UeG95Gs0' \
    --userId '6RgXYnXz' \
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