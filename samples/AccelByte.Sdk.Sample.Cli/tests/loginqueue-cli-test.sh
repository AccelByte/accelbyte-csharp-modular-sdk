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
echo "1..6"

#- 1 Login
$CLI_EXE --op login --lt user --user user --pass user > test.out 2>&1
eval_tap $? 1 'Login' test.out

if [ $EXIT_CODE -ne 0 ]; then
  echo "Bail out! Login failed."
  exit $EXIT_CODE
fi

# echo "foo" > "$CLI_TOKEN_FILE"

#- 2 AdminGetConfiguration
$CLI_EXE \
    --sn loginqueue \
    --op AdminGetConfiguration \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 2 'AdminGetConfiguration' test.out

#- 3 AdminUpdateConfiguration
# body param: body
echo '{"enabled": false, "maxConcurrency": 67, "maxLoginRate": 24, "minActivationPeriodInSecond": 62, "playerPollingTimeInSecond": 23, "playerReconnectGracePeriodInSecond": 34, "queueReconnectGracePeriodInSecond": 88, "safetyMarginPercentage": 76}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn loginqueue \
    --op AdminUpdateConfiguration \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 3 'AdminUpdateConfiguration' test.out

#- 4 AdminGetStatus
$CLI_EXE \
    --sn loginqueue \
    --op AdminGetStatus \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 4 'AdminGetStatus' test.out

#- 5 RefreshTicket
$CLI_EXE \
    --sn loginqueue \
    --op RefreshTicket \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 5 'RefreshTicket' test.out

#- 6 CancelTicket
$CLI_EXE \
    --sn loginqueue \
    --op CancelTicket \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 6 'CancelTicket' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE