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
echo "1..36"

#- 1 Login
$CLI_EXE --op login --lt user --user user --pass user > test.out 2>&1
eval_tap $? 1 'Login' test.out

if [ $EXIT_CODE -ne 0 ]; then
  echo "Bail out! Login failed."
  exit $EXIT_CODE
fi

# echo "foo" > "$CLI_TOKEN_FILE"

#- 2 AdminFindActionList
$CLI_EXE \
    --sn reporting \
    --op AdminFindActionList \
    > test.out 2>&1
eval_tap $? 2 'AdminFindActionList' test.out

#- 3 AdminCreateModAction
# body param: body
echo '{"actionId": "wtBdVBZW", "actionName": "E8po9BxE", "eventName": "1CPBu5Mn"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn reporting \
    --op AdminCreateModAction \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 3 'AdminCreateModAction' test.out

#- 4 AdminFindExtensionCategoryList
$CLI_EXE \
    --sn reporting \
    --op AdminFindExtensionCategoryList \
    --order 'descending' \
    --sortBy 'extensionCategoryName' \
    > test.out 2>&1
eval_tap $? 4 'AdminFindExtensionCategoryList' test.out

#- 5 AdminCreateExtensionCategory
# body param: body
echo '{"extensionCategory": "UHAqDSie", "extensionCategoryName": "1jHzvbwO", "serviceSource": "fLWaOeRH"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn reporting \
    --op AdminCreateExtensionCategory \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 5 'AdminCreateExtensionCategory' test.out

#- 6 Get
$CLI_EXE \
    --sn reporting \
    --op Get \
    --namespace $AB_NAMESPACE \
    --category 'extension' \
    > test.out 2>&1
eval_tap $? 6 'Get' test.out

#- 7 Upsert
# body param: body
echo '{"categoryLimits": [{"extensionCategory": "98zBS1jD", "maxReportPerTicket": 9, "name": "gww2vq4u"}, {"extensionCategory": "ygzJUCsT", "maxReportPerTicket": 52, "name": "i1M6PAyd"}, {"extensionCategory": "9YV5lK7u", "maxReportPerTicket": 1, "name": "AVDyrQTE"}], "timeInterval": 17, "userMaxReportPerTimeInterval": 33}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn reporting \
    --op Upsert \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 7 'Upsert' test.out

#- 8 AdminListReasonGroups
$CLI_EXE \
    --sn reporting \
    --op AdminListReasonGroups \
    --namespace $AB_NAMESPACE \
    --limit '79' \
    --offset '55' \
    > test.out 2>&1
eval_tap $? 8 'AdminListReasonGroups' test.out

#- 9 CreateReasonGroup
# body param: body
echo '{"reasonIds": ["y0IVgmfI", "HVUel5uz", "ZiqvqJFc"], "title": "6RwdXeGW"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn reporting \
    --op CreateReasonGroup \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 9 'CreateReasonGroup' test.out

#- 10 GetReasonGroup
$CLI_EXE \
    --sn reporting \
    --op GetReasonGroup \
    --groupId 'RUsiCFFL' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 10 'GetReasonGroup' test.out

#- 11 DeleteReasonGroup
$CLI_EXE \
    --sn reporting \
    --op DeleteReasonGroup \
    --groupId 'NYyOlHgZ' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 11 'DeleteReasonGroup' test.out

#- 12 UpdateReasonGroup
# body param: body
echo '{"reasonIds": ["lYrgo7tW", "YiPvdAoj", "tFhbCCoK"], "title": "MqBz0hYi"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn reporting \
    --op UpdateReasonGroup \
    --groupId 'TQpg2lpi' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 12 'UpdateReasonGroup' test.out

#- 13 AdminGetReasons
$CLI_EXE \
    --sn reporting \
    --op AdminGetReasons \
    --namespace $AB_NAMESPACE \
    --group 'hiqTtEs5' \
    --limit '39' \
    --offset '15' \
    --title 'Pjyb4Huz' \
    > test.out 2>&1
eval_tap $? 13 'AdminGetReasons' test.out

#- 14 CreateReason
# body param: body
echo '{"description": "iKSMZ6to", "groupIds": ["jJlaP3wz", "gX3rt8yu", "13evMS1Q"], "title": "xgcBa24o"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn reporting \
    --op CreateReason \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 14 'CreateReason' test.out

#- 15 AdminGetAllReasons
$CLI_EXE \
    --sn reporting \
    --op AdminGetAllReasons \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 15 'AdminGetAllReasons' test.out

#- 16 AdminGetUnusedReasons
$CLI_EXE \
    --sn reporting \
    --op AdminGetUnusedReasons \
    --namespace $AB_NAMESPACE \
    --extensionCategory 'PjydPfG6' \
    --category '1oOrmOgg' \
    > test.out 2>&1
eval_tap $? 16 'AdminGetUnusedReasons' test.out

#- 17 AdminGetReason
$CLI_EXE \
    --sn reporting \
    --op AdminGetReason \
    --namespace $AB_NAMESPACE \
    --reasonId '1vTbPK44' \
    > test.out 2>&1
eval_tap $? 17 'AdminGetReason' test.out

#- 18 DeleteReason
$CLI_EXE \
    --sn reporting \
    --op DeleteReason \
    --namespace $AB_NAMESPACE \
    --reasonId '5DwIRVqN' \
    > test.out 2>&1
eval_tap $? 18 'DeleteReason' test.out

#- 19 UpdateReason
# body param: body
echo '{"description": "mngf0XhJ", "groupIds": ["RD8MYmol", "dPilRWrW", "6qO9yUoD"], "title": "0D3xQeBH"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn reporting \
    --op UpdateReason \
    --namespace $AB_NAMESPACE \
    --reasonId '5KRDCDaq' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 19 'UpdateReason' test.out

#- 20 ListReports
$CLI_EXE \
    --sn reporting \
    --op ListReports \
    --namespace $AB_NAMESPACE \
    --category 'kNrkXsY7' \
    --limit '72' \
    --offset '39' \
    --reportedUserId 'O6Qxwxxq' \
    --sortBy 'gpnTgYsB' \
    > test.out 2>&1
eval_tap $? 20 'ListReports' test.out

#- 21 AdminSubmitReport
# body param: body
echo '{"additionalInfo": {"qAqg5TTS": {}, "6VlpQKIx": {}, "fmI75oMB": {}}, "category": "USER", "comment": "l0iEEGUn", "extensionCategory": "pgNRhsdd", "objectId": "gqZEEizH", "objectType": "R7yHUK4f", "reason": "8WVb2493", "userId": "bA6pjxUU"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn reporting \
    --op AdminSubmitReport \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 21 'AdminSubmitReport' test.out

#- 22 CreateModerationRule
# body param: body
echo '{"action": "HideContent", "actions": {"banAccount": {"comment": "eErybVvS", "duration": 15, "reason": "c3Nui1Er", "skipNotif": true, "type": "gcT7VyET"}, "deleteChat": true, "extensionActionIds": ["f9hEQcEW", "lSAZko6N", "aLOK8VqT"], "hideContent": true}, "active": true, "category": "CHAT", "extensionCategory": "Kvo4Us7p", "reason": "dDNEbOrj", "threshold": 58}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn reporting \
    --op CreateModerationRule \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 22 'CreateModerationRule' test.out

#- 23 UpdateModerationRule
# body param: body
echo '{"action": "HideContent", "actions": {"banAccount": {"comment": "Mf84thT7", "duration": 62, "reason": "92KaZdCY", "skipNotif": true, "type": "819NT5nj"}, "deleteChat": false, "extensionActionIds": ["1wxjELPt", "EEYDNqQw", "ooe8xtCA"], "hideContent": true}, "active": true, "category": "EXTENSION", "extensionCategory": "KmDJOxG9", "reason": "VmW1DxhH", "threshold": 58}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn reporting \
    --op UpdateModerationRule \
    --namespace $AB_NAMESPACE \
    --ruleId '86Pg0P0i' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 23 'UpdateModerationRule' test.out

#- 24 DeleteModerationRule
$CLI_EXE \
    --sn reporting \
    --op DeleteModerationRule \
    --namespace $AB_NAMESPACE \
    --ruleId '8XGwFX9u' \
    > test.out 2>&1
eval_tap $? 24 'DeleteModerationRule' test.out

#- 25 UpdateModerationRuleStatus
# body param: body
echo '{"active": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn reporting \
    --op UpdateModerationRuleStatus \
    --namespace $AB_NAMESPACE \
    --ruleId 'rmcE1AVr' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 25 'UpdateModerationRuleStatus' test.out

#- 26 GetModerationRules
$CLI_EXE \
    --sn reporting \
    --op GetModerationRules \
    --namespace $AB_NAMESPACE \
    --category 'eCRrEChB' \
    --extensionCategory 'AMyjRH7Y' \
    --limit '34' \
    --offset '52' \
    > test.out 2>&1
eval_tap $? 26 'GetModerationRules' test.out

#- 27 GetModerationRuleDetails
$CLI_EXE \
    --sn reporting \
    --op GetModerationRuleDetails \
    --namespace $AB_NAMESPACE \
    --ruleId 'STTQjND5' \
    > test.out 2>&1
eval_tap $? 27 'GetModerationRuleDetails' test.out

#- 28 ListTickets
$CLI_EXE \
    --sn reporting \
    --op ListTickets \
    --namespace $AB_NAMESPACE \
    --category '8FtgIRLA' \
    --extensionCategory 'cX0Lpql8' \
    --limit '42' \
    --offset '81' \
    --order 'DtWWpEYn' \
    --reportedUserId '4mGOPC08' \
    --sortBy '9AQSkgnc' \
    --status 'sAPA28vH' \
    > test.out 2>&1
eval_tap $? 28 'ListTickets' test.out

#- 29 TicketStatistic
$CLI_EXE \
    --sn reporting \
    --op TicketStatistic \
    --namespace $AB_NAMESPACE \
    --extensionCategory 'VeLrSL0o' \
    --category 'LjIOEdEg' \
    > test.out 2>&1
eval_tap $? 29 'TicketStatistic' test.out

#- 30 GetTicketDetail
$CLI_EXE \
    --sn reporting \
    --op GetTicketDetail \
    --namespace $AB_NAMESPACE \
    --ticketId 'BpVb9rfP' \
    > test.out 2>&1
eval_tap $? 30 'GetTicketDetail' test.out

#- 31 DeleteTicket
$CLI_EXE \
    --sn reporting \
    --op DeleteTicket \
    --namespace $AB_NAMESPACE \
    --ticketId 'gMvNu6Pb' \
    > test.out 2>&1
eval_tap $? 31 'DeleteTicket' test.out

#- 32 GetReportsByTicket
$CLI_EXE \
    --sn reporting \
    --op GetReportsByTicket \
    --namespace $AB_NAMESPACE \
    --ticketId 'mSQeJEXA' \
    --limit '1' \
    --offset '70' \
    > test.out 2>&1
eval_tap $? 32 'GetReportsByTicket' test.out

#- 33 UpdateTicketResolutions
# body param: body
echo '{"notes": "uq2145pe", "status": "CLOSED"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn reporting \
    --op UpdateTicketResolutions \
    --namespace $AB_NAMESPACE \
    --ticketId 'pXMh6XQ3' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 33 'UpdateTicketResolutions' test.out

#- 34 PublicListReasonGroups
$CLI_EXE \
    --sn reporting \
    --op PublicListReasonGroups \
    --namespace $AB_NAMESPACE \
    --limit '15' \
    --offset '82' \
    > test.out 2>&1
eval_tap $? 34 'PublicListReasonGroups' test.out

#- 35 PublicGetReasons
$CLI_EXE \
    --sn reporting \
    --op PublicGetReasons \
    --namespace $AB_NAMESPACE \
    --group 'XG7R3wx6' \
    --limit '19' \
    --offset '63' \
    --title 'qulp8ZUe' \
    > test.out 2>&1
eval_tap $? 35 'PublicGetReasons' test.out

#- 36 SubmitReport
# body param: body
echo '{"additionalInfo": {"M9cOSdho": {}, "zFygDyHw": {}, "MeSVebhT": {}}, "category": "CHAT", "comment": "PKZLNwxi", "extensionCategory": "XFht187J", "objectId": "atNgM16s", "objectType": "159dJnnm", "reason": "q7h209hZ", "userId": "uKleG2LH"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn reporting \
    --op SubmitReport \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 36 'SubmitReport' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE