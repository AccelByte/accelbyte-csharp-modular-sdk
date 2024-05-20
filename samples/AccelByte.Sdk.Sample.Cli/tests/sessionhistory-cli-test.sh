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
echo "1..34"

#- 1 Login
$CLI_EXE --op login --lt user --user user --pass user > test.out 2>&1
eval_tap $? 1 'Login' test.out

if [ $EXIT_CODE -ne 0 ]; then
  echo "Bail out! Login failed."
  exit $EXIT_CODE
fi

# echo "foo" > "$CLI_TOKEN_FILE"

#- 2 GetHealthcheckInfo
$CLI_EXE \
    --sn sessionhistory \
    --op GetHealthcheckInfo \
    > test.out 2>&1
eval_tap $? 2 'GetHealthcheckInfo' test.out

#- 3 GetHealthcheckInfoV1
$CLI_EXE \
    --sn sessionhistory \
    --op GetHealthcheckInfoV1 \
    > test.out 2>&1
eval_tap $? 3 'GetHealthcheckInfoV1' test.out

#- 4 AdminGetLogConfig
$CLI_EXE \
    --sn sessionhistory \
    --op AdminGetLogConfig \
    > test.out 2>&1
eval_tap $? 4 'AdminGetLogConfig' test.out

#- 5 AdminPatchUpdateLogConfig
# body param: body
echo '{"logLevel": "fatal"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn sessionhistory \
    --op AdminPatchUpdateLogConfig \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 5 'AdminPatchUpdateLogConfig' test.out

#- 6 AdminQueryGameSessionDetail
$CLI_EXE \
    --sn sessionhistory \
    --op AdminQueryGameSessionDetail \
    --namespace $AB_NAMESPACE \
    --gameSessionID 'AGJxkdY4' \
    --limit '38' \
    --offset '65' \
    --order 'iYTZaYmS' \
    --orderBy 'Ay2XC1BH' \
    --userID '4s1EL1kR' \
    > test.out 2>&1
eval_tap $? 6 'AdminQueryGameSessionDetail' test.out

#- 7 GetGameSessionDetail
$CLI_EXE \
    --sn sessionhistory \
    --op GetGameSessionDetail \
    --namespace $AB_NAMESPACE \
    --sessionId 'xsu6XOKS' \
    > test.out 2>&1
eval_tap $? 7 'GetGameSessionDetail' test.out

#- 8 AdminQueryMatchmakingDetail
$CLI_EXE \
    --sn sessionhistory \
    --op AdminQueryMatchmakingDetail \
    --namespace $AB_NAMESPACE \
    --gameSessionID 'DdtWVXAM' \
    --limit '16' \
    --offset '77' \
    --order 'f6cxfi71' \
    --orderBy 'ijoaxAp0' \
    --ticketID '6VVK6YoC' \
    --userID 'g7glPW5l' \
    > test.out 2>&1
eval_tap $? 8 'AdminQueryMatchmakingDetail' test.out

#- 9 AdminGetMatchmakingDetailBySessionID
$CLI_EXE \
    --sn sessionhistory \
    --op AdminGetMatchmakingDetailBySessionID \
    --namespace $AB_NAMESPACE \
    --sessionId 'u2SkwJNr' \
    > test.out 2>&1
eval_tap $? 9 'AdminGetMatchmakingDetailBySessionID' test.out

#- 10 AdminGetMatchmakingDetailByTicketID
$CLI_EXE \
    --sn sessionhistory \
    --op AdminGetMatchmakingDetailByTicketID \
    --namespace $AB_NAMESPACE \
    --ticketId 'Lr5htXSd' \
    > test.out 2>&1
eval_tap $? 10 'AdminGetMatchmakingDetailByTicketID' test.out

#- 11 AdminQueryPartyDetail
$CLI_EXE \
    --sn sessionhistory \
    --op AdminQueryPartyDetail \
    --namespace $AB_NAMESPACE \
    --limit '39' \
    --offset '2' \
    --order 'Had90vV6' \
    --orderBy 'uBIWZ36d' \
    --partyID 'pe9R26G5' \
    --userID '96I54lV7' \
    > test.out 2>&1
eval_tap $? 11 'AdminQueryPartyDetail' test.out

#- 12 GetPartyDetail
$CLI_EXE \
    --sn sessionhistory \
    --op GetPartyDetail \
    --namespace $AB_NAMESPACE \
    --sessionId 'GimQvUaZ' \
    > test.out 2>&1
eval_tap $? 12 'GetPartyDetail' test.out

#- 13 AdminQueryTicketDetail
$CLI_EXE \
    --sn sessionhistory \
    --op AdminQueryTicketDetail \
    --namespace $AB_NAMESPACE \
    --endDate 'aA2rqudI' \
    --gameMode 'evvwDSRm' \
    --limit '79' \
    --offset '21' \
    --order 'eOzHrLrV' \
    --partyID 'wQs6Sgiq' \
    --region 'pnoRcmJJ' \
    --startDate '2wp807Ey' \
    --userIDs 'I37uHXWU' \
    > test.out 2>&1
eval_tap $? 13 'AdminQueryTicketDetail' test.out

#- 14 AdminTicketDetailGetByTicketID
$CLI_EXE \
    --sn sessionhistory \
    --op AdminTicketDetailGetByTicketID \
    --namespace $AB_NAMESPACE \
    --ticketId 'zqHN2gAM' \
    > test.out 2>&1
eval_tap $? 14 'AdminTicketDetailGetByTicketID' test.out

#- 15 QueryXrayMatchPool
$CLI_EXE \
    --sn sessionhistory \
    --op QueryXrayMatchPool \
    --namespace $AB_NAMESPACE \
    --poolName 'XuLgHL4x' \
    --endDate 'Bo4hf2UO' \
    --startDate 'oL06ZWuW' \
    > test.out 2>&1
eval_tap $? 15 'QueryXrayMatchPool' test.out

#- 16 QueryDetailTickMatchPool
$CLI_EXE \
    --sn sessionhistory \
    --op QueryDetailTickMatchPool \
    --namespace $AB_NAMESPACE \
    --podName 'lU5aZ7g2' \
    --poolName 'tRTUEasf' \
    --all 'true' \
    --limit '19' \
    --offset '41' \
    --endDate '2bS6bu4l' \
    --startDate 'Kry0EM3C' \
    > test.out 2>&1
eval_tap $? 16 'QueryDetailTickMatchPool' test.out

#- 17 QueryDetailTickMatchPoolMatches
$CLI_EXE \
    --sn sessionhistory \
    --op QueryDetailTickMatchPoolMatches \
    --namespace $AB_NAMESPACE \
    --podName 'ZUtPndh3' \
    --poolName 't3umnYPZ' \
    --tickId 'IW3GBngj' \
    > test.out 2>&1
eval_tap $? 17 'QueryDetailTickMatchPoolMatches' test.out

#- 18 QueryDetailTickMatchPoolTicket
$CLI_EXE \
    --sn sessionhistory \
    --op QueryDetailTickMatchPoolTicket \
    --namespace $AB_NAMESPACE \
    --podName 'Dd6nxDJx' \
    --poolName '6vKiUGGC' \
    --tickId 'oPUsXncL' \
    > test.out 2>&1
eval_tap $? 18 'QueryDetailTickMatchPoolTicket' test.out

#- 19 QueryMatchHistories
$CLI_EXE \
    --sn sessionhistory \
    --op QueryMatchHistories \
    --matchId '7QrRliGt' \
    --namespace $AB_NAMESPACE \
    --limit '30' \
    --offset '94' \
    > test.out 2>&1
eval_tap $? 19 'QueryMatchHistories' test.out

#- 20 QueryMatchTicketHistories
$CLI_EXE \
    --sn sessionhistory \
    --op QueryMatchTicketHistories \
    --matchId 'Zc6snGrD' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 20 'QueryMatchTicketHistories' test.out

#- 21 QueryXrayMatch
$CLI_EXE \
    --sn sessionhistory \
    --op QueryXrayMatch \
    --matchId 'rClRTWRz' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 21 'QueryXrayMatch' test.out

#- 22 QueryAcquiringDS
$CLI_EXE \
    --sn sessionhistory \
    --op QueryAcquiringDS \
    --namespace $AB_NAMESPACE \
    --endDate 'tGZwBKbO' \
    --startDate 'JlSWi0jO' \
    > test.out 2>&1
eval_tap $? 22 'QueryAcquiringDS' test.out

#- 23 QueryAcquiringDSWaitTimeAvg
$CLI_EXE \
    --sn sessionhistory \
    --op QueryAcquiringDSWaitTimeAvg \
    --namespace $AB_NAMESPACE \
    --endDate 'CQny3ife' \
    --startDate 'cex9E8aD' \
    > test.out 2>&1
eval_tap $? 23 'QueryAcquiringDSWaitTimeAvg' test.out

#- 24 QueryMatchLengthDurationpAvg
$CLI_EXE \
    --sn sessionhistory \
    --op QueryMatchLengthDurationpAvg \
    --namespace $AB_NAMESPACE \
    --endDate '4DucRrE9' \
    --startDate 'zTw2bePI' \
    > test.out 2>&1
eval_tap $? 24 'QueryMatchLengthDurationpAvg' test.out

#- 25 QueryMatchLengthDurationp99
$CLI_EXE \
    --sn sessionhistory \
    --op QueryMatchLengthDurationp99 \
    --namespace $AB_NAMESPACE \
    --endDate 'tBTbvvI1' \
    --startDate 'wl007E5x' \
    > test.out 2>&1
eval_tap $? 25 'QueryMatchLengthDurationp99' test.out

#- 26 QueryTotalActiveSession
$CLI_EXE \
    --sn sessionhistory \
    --op QueryTotalActiveSession \
    --namespace $AB_NAMESPACE \
    --region 'mSKIfSpa' \
    --endDate 'IFIF2sJN' \
    --startDate 'IM0jLVa2' \
    > test.out 2>&1
eval_tap $? 26 'QueryTotalActiveSession' test.out

#- 27 QueryTotalMatchmakingMatch
$CLI_EXE \
    --sn sessionhistory \
    --op QueryTotalMatchmakingMatch \
    --namespace $AB_NAMESPACE \
    --matchPool 'JPZDg1Vm' \
    --endDate 'ctm64QAE' \
    --startDate 'IOHFbYH4' \
    > test.out 2>&1
eval_tap $? 27 'QueryTotalMatchmakingMatch' test.out

#- 28 QueryTotalPlayerPersession
$CLI_EXE \
    --sn sessionhistory \
    --op QueryTotalPlayerPersession \
    --namespace $AB_NAMESPACE \
    --endDate 'vyU09k3D' \
    --startDate 'L7UUgpVj' \
    > test.out 2>&1
eval_tap $? 28 'QueryTotalPlayerPersession' test.out

#- 29 QueryTotalMatchmakingCanceled
$CLI_EXE \
    --sn sessionhistory \
    --op QueryTotalMatchmakingCanceled \
    --namespace $AB_NAMESPACE \
    --matchPool '3UsvswiJ' \
    --endDate 'acoIK0De' \
    --startDate 'NvMESIXs' \
    > test.out 2>&1
eval_tap $? 29 'QueryTotalMatchmakingCanceled' test.out

#- 30 QueryTotalMatchmakingCreated
$CLI_EXE \
    --sn sessionhistory \
    --op QueryTotalMatchmakingCreated \
    --namespace $AB_NAMESPACE \
    --matchPool 'xBC6MytH' \
    --endDate 'WhW6fVau' \
    --startDate '5ryw1TEh' \
    > test.out 2>&1
eval_tap $? 30 'QueryTotalMatchmakingCreated' test.out

#- 31 QueryTotalMatchmakingExpired
$CLI_EXE \
    --sn sessionhistory \
    --op QueryTotalMatchmakingExpired \
    --namespace $AB_NAMESPACE \
    --matchPool 'lEz0iyqn' \
    --endDate '5kx1VA6H' \
    --startDate 'p1lEAJfL' \
    > test.out 2>&1
eval_tap $? 31 'QueryTotalMatchmakingExpired' test.out

#- 32 QueryTotalMatchmakingMatchTicket
$CLI_EXE \
    --sn sessionhistory \
    --op QueryTotalMatchmakingMatchTicket \
    --namespace $AB_NAMESPACE \
    --matchPool 'k7ZuVL7e' \
    --endDate '33mdccjj' \
    --startDate 'Cm7Opo5O' \
    > test.out 2>&1
eval_tap $? 32 'QueryTotalMatchmakingMatchTicket' test.out

#- 33 QueryXrayTimelineByTicketID
$CLI_EXE \
    --sn sessionhistory \
    --op QueryXrayTimelineByTicketID \
    --namespace $AB_NAMESPACE \
    --ticketId 'V3hbK2ly' \
    --limit '58' \
    --offset '31' \
    --endDate 'GVlLikRL' \
    --startDate '4embVDI9' \
    > test.out 2>&1
eval_tap $? 33 'QueryXrayTimelineByTicketID' test.out

#- 34 QueryXrayTimelineByUserID
$CLI_EXE \
    --sn sessionhistory \
    --op QueryXrayTimelineByUserID \
    --namespace $AB_NAMESPACE \
    --userId '0SmmtQMu' \
    --limit '22' \
    --offset '76' \
    --endDate 'gUbtniew' \
    --startDate '5LQc2m4r' \
    > test.out 2>&1
eval_tap $? 34 'QueryXrayTimelineByUserID' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE