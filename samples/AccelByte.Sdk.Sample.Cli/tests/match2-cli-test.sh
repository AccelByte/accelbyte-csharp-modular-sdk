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
echo "1..32"

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
    --sn match2 \
    --op GetHealthcheckInfo \
    > test.out 2>&1
eval_tap $? 2 'GetHealthcheckInfo' test.out

#- 3 GetHealthcheckInfoV1
$CLI_EXE \
    --sn match2 \
    --op GetHealthcheckInfoV1 \
    > test.out 2>&1
eval_tap $? 3 'GetHealthcheckInfoV1' test.out

#- 4 EnvironmentVariableList
$CLI_EXE \
    --sn match2 \
    --op EnvironmentVariableList \
    > test.out 2>&1
eval_tap $? 4 'EnvironmentVariableList' test.out

#- 5 CreateBackfill
# body param: body
echo '{"matchPool": "K94sPEzS", "sessionId": "TLMFiC6Q"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op CreateBackfill \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 5 'CreateBackfill' test.out

#- 6 GetBackfillProposal
$CLI_EXE \
    --sn match2 \
    --op GetBackfillProposal \
    --namespace $AB_NAMESPACE \
    --sessionID 'NpK3iiPm' \
    > test.out 2>&1
eval_tap $? 6 'GetBackfillProposal' test.out

#- 7 GetBackfill
$CLI_EXE \
    --sn match2 \
    --op GetBackfill \
    --backfillID 'surUh2wP' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 7 'GetBackfill' test.out

#- 8 DeleteBackfill
$CLI_EXE \
    --sn match2 \
    --op DeleteBackfill \
    --backfillID 'HVmKWXXT' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 8 'DeleteBackfill' test.out

#- 9 AcceptBackfill
# body param: body
echo '{"proposalId": "9PXVLhQY", "stop": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op AcceptBackfill \
    --backfillID '0EqEZGHz' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 9 'AcceptBackfill' test.out

#- 10 RejectBackfill
# body param: body
echo '{"proposalId": "1HJXbFhk", "stop": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op RejectBackfill \
    --backfillID '9Z9XdbVG' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 10 'RejectBackfill' test.out

#- 11 MatchFunctionList
$CLI_EXE \
    --sn match2 \
    --op MatchFunctionList \
    --namespace $AB_NAMESPACE \
    --limit '0' \
    --offset '79' \
    > test.out 2>&1
eval_tap $? 11 'MatchFunctionList' test.out

#- 12 CreateMatchFunction
# body param: body
echo '{"match_function": "0YTmapPS", "serviceAppName": "knoZ9Qww", "url": "kAxkcf2O"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op CreateMatchFunction \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 12 'CreateMatchFunction' test.out

#- 13 UpdateMatchFunction
# body param: body
echo '{"match_function": "hnNLqwOo", "serviceAppName": "8Xk3TuBI", "url": "xSLo5sAo"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op UpdateMatchFunction \
    --name 'pqiIEBMG' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 13 'UpdateMatchFunction' test.out

#- 14 DeleteMatchFunction
$CLI_EXE \
    --sn match2 \
    --op DeleteMatchFunction \
    --name 'x9oJrMsY' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 14 'DeleteMatchFunction' test.out

#- 15 MatchPoolList
$CLI_EXE \
    --sn match2 \
    --op MatchPoolList \
    --namespace $AB_NAMESPACE \
    --limit '11' \
    --name '4yvq0ivw' \
    --offset '99' \
    > test.out 2>&1
eval_tap $? 15 'MatchPoolList' test.out

#- 16 CreateMatchPool
# body param: body
echo '{"auto_accept_backfill_proposal": false, "backfill_proposal_expiration_seconds": 4, "backfill_ticket_expiration_seconds": 20, "match_function": "H8BfZMHz", "match_function_override": {"backfill_matches": "QImkN1oA", "enrichment": ["iSs5DQeH", "IobPlx16", "mVSWJswo"], "make_matches": "cMFjW5Cw", "stat_codes": ["YvvNedcF", "mR6rsaTh", "QGSN4N4A"], "validation": ["DLq2rerZ", "negERFWU", "Q8T14mzh"]}, "name": "4MplM0wA", "rule_set": "ELbDRZY7", "session_template": "3jmddo7b", "ticket_expiration_seconds": 20}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op CreateMatchPool \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 16 'CreateMatchPool' test.out

#- 17 MatchPoolDetails
$CLI_EXE \
    --sn match2 \
    --op MatchPoolDetails \
    --namespace $AB_NAMESPACE \
    --pool 'ihlnNGje' \
    > test.out 2>&1
eval_tap $? 17 'MatchPoolDetails' test.out

#- 18 UpdateMatchPool
# body param: body
echo '{"auto_accept_backfill_proposal": false, "backfill_proposal_expiration_seconds": 42, "backfill_ticket_expiration_seconds": 89, "match_function": "nn99OKqQ", "match_function_override": {"backfill_matches": "Hcb8KaUc", "enrichment": ["zJbSWExV", "EO2AJ1xi", "CWty2fqf"], "make_matches": "t0oHbUHp", "stat_codes": ["UDIB5CSq", "CtgtERXf", "DvVJgvXx"], "validation": ["GAKPbRFL", "1RxtrYmM", "ZPlSmGOu"]}, "rule_set": "RjB3WfTF", "session_template": "yPzIHAjl", "ticket_expiration_seconds": 76}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op UpdateMatchPool \
    --namespace $AB_NAMESPACE \
    --pool 'WWDJnKs8' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 18 'UpdateMatchPool' test.out

#- 19 DeleteMatchPool
$CLI_EXE \
    --sn match2 \
    --op DeleteMatchPool \
    --namespace $AB_NAMESPACE \
    --pool 'KwsN0DHN' \
    > test.out 2>&1
eval_tap $? 19 'DeleteMatchPool' test.out

#- 20 MatchPoolMetric
$CLI_EXE \
    --sn match2 \
    --op MatchPoolMetric \
    --namespace $AB_NAMESPACE \
    --pool 'BwXHTb8U' \
    > test.out 2>&1
eval_tap $? 20 'MatchPoolMetric' test.out

#- 21 GetPlayerMetric
$CLI_EXE \
    --sn match2 \
    --op GetPlayerMetric \
    --namespace $AB_NAMESPACE \
    --pool 'p8QzFK4Q' \
    > test.out 2>&1
eval_tap $? 21 'GetPlayerMetric' test.out

#- 22 AdminGetMatchPoolTickets
$CLI_EXE \
    --sn match2 \
    --op AdminGetMatchPoolTickets \
    --namespace $AB_NAMESPACE \
    --pool '0wQ7gkRW' \
    --limit '25' \
    --offset '14' \
    > test.out 2>&1
eval_tap $? 22 'AdminGetMatchPoolTickets' test.out

#- 23 CreateMatchTicket
# body param: body
echo '{"attributes": {"LhrrIflR": {}, "q22Y9v2l": {}, "mSSZyDNr": {}}, "latencies": {"75LDbKI6": 35, "OU3kJ6uu": 58, "Z4Xk0GJI": 59}, "matchPool": "xELCItgn", "sessionID": "dbUosFHo"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op CreateMatchTicket \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 23 'CreateMatchTicket' test.out

#- 24 GetMyMatchTickets
$CLI_EXE \
    --sn match2 \
    --op GetMyMatchTickets \
    --namespace $AB_NAMESPACE \
    --limit '43' \
    --matchPool 'SyPOKsx8' \
    --offset '46' \
    > test.out 2>&1
eval_tap $? 24 'GetMyMatchTickets' test.out

#- 25 MatchTicketDetails
$CLI_EXE \
    --sn match2 \
    --op MatchTicketDetails \
    --namespace $AB_NAMESPACE \
    --ticketid 'VlEU5XVi' \
    > test.out 2>&1
eval_tap $? 25 'MatchTicketDetails' test.out

#- 26 DeleteMatchTicket
$CLI_EXE \
    --sn match2 \
    --op DeleteMatchTicket \
    --namespace $AB_NAMESPACE \
    --ticketid 'd3JiBnCq' \
    > test.out 2>&1
eval_tap $? 26 'DeleteMatchTicket' test.out

#- 27 RuleSetList
$CLI_EXE \
    --sn match2 \
    --op RuleSetList \
    --namespace $AB_NAMESPACE \
    --limit '33' \
    --name 'Lsuv3y0D' \
    --offset '8' \
    > test.out 2>&1
eval_tap $? 27 'RuleSetList' test.out

#- 28 CreateRuleSet
# body param: body
echo '{"data": {"ncJXQPrS": {}, "QD5tuecE": {}, "edvWYxHo": {}}, "enable_custom_match_function": true, "name": "5bbFDhvX"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op CreateRuleSet \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 28 'CreateRuleSet' test.out

#- 29 RuleSetDetails
$CLI_EXE \
    --sn match2 \
    --op RuleSetDetails \
    --namespace $AB_NAMESPACE \
    --ruleset 'nPN5Nth4' \
    > test.out 2>&1
eval_tap $? 29 'RuleSetDetails' test.out

#- 30 UpdateRuleSet
# body param: body
echo '{"data": {"wRQYYvg5": {}, "onb6KaDl": {}, "QUvS9u9i": {}}, "enable_custom_match_function": false, "name": "Uy7r6TQt"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op UpdateRuleSet \
    --namespace $AB_NAMESPACE \
    --ruleset 'vRUSmgwm' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 30 'UpdateRuleSet' test.out

#- 31 DeleteRuleSet
$CLI_EXE \
    --sn match2 \
    --op DeleteRuleSet \
    --namespace $AB_NAMESPACE \
    --ruleset 'vpmjborY' \
    > test.out 2>&1
eval_tap $? 31 'DeleteRuleSet' test.out

#- 32 VersionCheckHandler
$CLI_EXE \
    --sn match2 \
    --op VersionCheckHandler \
    > test.out 2>&1
eval_tap $? 32 'VersionCheckHandler' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE