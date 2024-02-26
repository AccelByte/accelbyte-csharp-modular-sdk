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
echo "1..16"

#- 1 Login
$CLI_EXE --op login --lt user --user user --pass user > test.out 2>&1
eval_tap $? 1 'Login' test.out

if [ $EXIT_CODE -ne 0 ]; then
  echo "Bail out! Login failed."
  exit $EXIT_CODE
fi

# echo "foo" > "$CLI_TOKEN_FILE"

#- 2 ListNodesIPAddress
$CLI_EXE \
    --sn dsartifact \
    --op ListNodesIPAddress \
    --limit '79' \
    --next 'cwwQUiih' \
    --nodeIP 'EhsMhdDP' \
    --previous 'HialI0Mg' \
    > test.out 2>&1
eval_tap $? 2 'ListNodesIPAddress' test.out

#- 3 DeleteNodeByID
$CLI_EXE \
    --sn dsartifact \
    --op DeleteNodeByID \
    --nodeIP 'FreBxYzk' \
    --podName '2dQ9ujna' \
    > test.out 2>&1
eval_tap $? 3 'DeleteNodeByID' test.out

#- 4 ListQueue
$CLI_EXE \
    --sn dsartifact \
    --op ListQueue \
    --limit '69' \
    --next 'q6WtesXI' \
    --previous 'kq9PHXBa' \
    --nodeIP 'bqB8bpDo' \
    > test.out 2>&1
eval_tap $? 4 'ListQueue' test.out

#- 5 GetActiveQueue
$CLI_EXE \
    --sn dsartifact \
    --op GetActiveQueue \
    --nodeIP 'EOHfpLZA' \
    > test.out 2>&1
eval_tap $? 5 'GetActiveQueue' test.out

#- 6 SetActiveQueue
$CLI_EXE \
    --sn dsartifact \
    --op SetActiveQueue \
    --nodeIP 'ytjfhgx8' \
    --podName '8d10NdlL' \
    > test.out 2>&1
eval_tap $? 6 'SetActiveQueue' test.out

#- 7 DeleteActiveQueue
$CLI_EXE \
    --sn dsartifact \
    --op DeleteActiveQueue \
    --nodeIP 'vGstDHa7' \
    > test.out 2>&1
eval_tap $? 7 'DeleteActiveQueue' test.out

#- 8 ReportFailedUpload
$CLI_EXE \
    --sn dsartifact \
    --op ReportFailedUpload \
    --nodeIP 'cHkHOulx' \
    --podName '1crf4Q73' \
    > test.out 2>&1
eval_tap $? 8 'ReportFailedUpload' test.out

#- 9 DeleteQueue
$CLI_EXE \
    --sn dsartifact \
    --op DeleteQueue \
    --namespace $AB_NAMESPACE \
    --nodeIP 'KGuR04uF' \
    --podName 'P7hSogFm' \
    > test.out 2>&1
eval_tap $? 9 'DeleteQueue' test.out

#- 10 ListAllActiveQueue
$CLI_EXE \
    --sn dsartifact \
    --op ListAllActiveQueue \
    --namespace $AB_NAMESPACE \
    --limit '32' \
    --next 'cGuKfThN' \
    --nodeIP 'oQIL2h09' \
    --podName 'uRIp9u7a' \
    --previous 'xXkUhB2Z' \
    > test.out 2>&1
eval_tap $? 10 'ListAllActiveQueue' test.out

#- 11 ListAllQueue
$CLI_EXE \
    --sn dsartifact \
    --op ListAllQueue \
    --namespace $AB_NAMESPACE \
    --excludeUploading 'false' \
    --limit '11' \
    --next 'HNjUerhP' \
    --nodeIP 'vzqAM6Eq' \
    --order 'IC8OG91d' \
    --podName 'mGbySHFW' \
    --previous 'aOgOksfP' \
    > test.out 2>&1
eval_tap $? 11 'ListAllQueue' test.out

#- 12 ListTerminatedServersWithNamespace
$CLI_EXE \
    --sn dsartifact \
    --op ListTerminatedServersWithNamespace \
    --namespace $AB_NAMESPACE \
    --deployment 'c073grxj' \
    --gameMode 'UaZTPMoS' \
    --limit '47' \
    --next 'jGsVCOvZ' \
    --partyId 'WvvdYJZp' \
    --podName 'cxuue4ko' \
    --previous 'EJsqFblw' \
    --provider 'IbnesrJR' \
    --region 'V8Chah3a' \
    --sessionId 'AGMhQf83' \
    --userId 'zCZYQ5YG' \
    > test.out 2>&1
eval_tap $? 12 'ListTerminatedServersWithNamespace' test.out

#- 13 DownloadServerArtifacts
$CLI_EXE \
    --sn dsartifact \
    --op DownloadServerArtifacts \
    --namespace $AB_NAMESPACE \
    --podName 'ECJXAys6' \
    > test.out 2>&1
eval_tap $? 13 'DownloadServerArtifacts' test.out

#- 14 CheckServerArtifact
$CLI_EXE \
    --sn dsartifact \
    --op CheckServerArtifact \
    --namespace $AB_NAMESPACE \
    --podName 'u4Qua4iT' \
    > test.out 2>&1
eval_tap $? 14 'CheckServerArtifact' test.out

#- 15 ListTerminatedServers
$CLI_EXE \
    --sn dsartifact \
    --op ListTerminatedServers \
    --deployment 'whe0ZN3e' \
    --gameMode '7aEDzooC' \
    --limit '48' \
    --next 'x2wAfER5' \
    --partyId 'PhDxGbWA' \
    --podName 'DhnR6NsD' \
    --previous 'AKnFd3SH' \
    --provider 'Y9TDdOm1' \
    --region 'ywHOp2w9' \
    --sessionId '1gQP2k6s' \
    --userId 'aETtiRuM' \
    > test.out 2>&1
eval_tap $? 15 'ListTerminatedServers' test.out

#- 16 PublicGetMessages
$CLI_EXE \
    --sn dsartifact \
    --op PublicGetMessages \
    > test.out 2>&1
eval_tap $? 16 'PublicGetMessages' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE