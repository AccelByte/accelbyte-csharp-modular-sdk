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
    --limit '19' \
    --next 'XubWphdq' \
    --nodeIP 'Mjd3NlJd' \
    --previous 'KRcsuqWm' \
    > test.out 2>&1
eval_tap $? 2 'ListNodesIPAddress' test.out

#- 3 DeleteNodeByID
$CLI_EXE \
    --sn dsartifact \
    --op DeleteNodeByID \
    --nodeIP 'S9L3uyD0' \
    --podName 'W0crGfWf' \
    > test.out 2>&1
eval_tap $? 3 'DeleteNodeByID' test.out

#- 4 ListQueue
$CLI_EXE \
    --sn dsartifact \
    --op ListQueue \
    --limit '63' \
    --next 'u0PJfiA4' \
    --previous 's3BtOMm8' \
    --nodeIP 'AEBlmZiM' \
    > test.out 2>&1
eval_tap $? 4 'ListQueue' test.out

#- 5 GetActiveQueue
$CLI_EXE \
    --sn dsartifact \
    --op GetActiveQueue \
    --nodeIP 'hkSTMPn4' \
    > test.out 2>&1
eval_tap $? 5 'GetActiveQueue' test.out

#- 6 SetActiveQueue
$CLI_EXE \
    --sn dsartifact \
    --op SetActiveQueue \
    --nodeIP 'tya2jwsy' \
    --podName 'DQs2FXOC' \
    > test.out 2>&1
eval_tap $? 6 'SetActiveQueue' test.out

#- 7 DeleteActiveQueue
$CLI_EXE \
    --sn dsartifact \
    --op DeleteActiveQueue \
    --nodeIP '0DlhG264' \
    > test.out 2>&1
eval_tap $? 7 'DeleteActiveQueue' test.out

#- 8 ReportFailedUpload
$CLI_EXE \
    --sn dsartifact \
    --op ReportFailedUpload \
    --nodeIP 'LgutsS2V' \
    --podName 'PJe5zMgl' \
    > test.out 2>&1
eval_tap $? 8 'ReportFailedUpload' test.out

#- 9 DeleteQueue
$CLI_EXE \
    --sn dsartifact \
    --op DeleteQueue \
    --namespace $AB_NAMESPACE \
    --nodeIP '3W9KRM2f' \
    --podName 'FTF35JCM' \
    > test.out 2>&1
eval_tap $? 9 'DeleteQueue' test.out

#- 10 ListAllActiveQueue
$CLI_EXE \
    --sn dsartifact \
    --op ListAllActiveQueue \
    --namespace $AB_NAMESPACE \
    --limit '34' \
    --next 'Wh8GqoeA' \
    --nodeIP '4C0tGFQ2' \
    --podName '0NydE1kA' \
    --previous 'gYmXYh6z' \
    > test.out 2>&1
eval_tap $? 10 'ListAllActiveQueue' test.out

#- 11 ListAllQueue
$CLI_EXE \
    --sn dsartifact \
    --op ListAllQueue \
    --namespace $AB_NAMESPACE \
    --excludeUploading 'false' \
    --limit '84' \
    --next 'ZzFT45N8' \
    --nodeIP 'vzLYYuLp' \
    --order 'WuAUP01t' \
    --podName 'B8Nh15ll' \
    --previous 'tbWiROOC' \
    > test.out 2>&1
eval_tap $? 11 'ListAllQueue' test.out

#- 12 ListTerminatedServersWithNamespace
$CLI_EXE \
    --sn dsartifact \
    --op ListTerminatedServersWithNamespace \
    --namespace $AB_NAMESPACE \
    --deployment 'cWRyUBGp' \
    --gameMode 'iRtiym45' \
    --limit '99' \
    --next 'ZGRjOg3o' \
    --partyId 'KuPdy6v5' \
    --podName 'iHCtUSBU' \
    --previous 'JvuRySkI' \
    --provider '53JdEjmE' \
    --region 'uPVFaTOA' \
    --sessionId 'PXEuETS3' \
    --userId 'sqPZ3xt4' \
    > test.out 2>&1
eval_tap $? 12 'ListTerminatedServersWithNamespace' test.out

#- 13 DownloadServerArtifacts
$CLI_EXE \
    --sn dsartifact \
    --op DownloadServerArtifacts \
    --namespace $AB_NAMESPACE \
    --podName '4jO6Q0yz' \
    > test.out 2>&1
eval_tap $? 13 'DownloadServerArtifacts' test.out

#- 14 CheckServerArtifact
$CLI_EXE \
    --sn dsartifact \
    --op CheckServerArtifact \
    --namespace $AB_NAMESPACE \
    --podName 'xkXqxijx' \
    > test.out 2>&1
eval_tap $? 14 'CheckServerArtifact' test.out

#- 15 ListTerminatedServers
$CLI_EXE \
    --sn dsartifact \
    --op ListTerminatedServers \
    --deployment 'jdjHCN3w' \
    --gameMode 'm8VDNbKj' \
    --limit '98' \
    --next 'Q2v9g52h' \
    --partyId 'IGBk50Wk' \
    --podName 'KQHTFN2g' \
    --previous 'i7vAKrrV' \
    --provider 'qLJKr1hW' \
    --region 'jxq83wMV' \
    --sessionId '66B04s3s' \
    --userId 'eH5YIoND' \
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