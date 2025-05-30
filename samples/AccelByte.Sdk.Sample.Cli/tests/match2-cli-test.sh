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
echo "1..41"

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

#- 4 AdminGetLogConfig
$CLI_EXE \
    --sn match2 \
    --op AdminGetLogConfig \
    > test.out 2>&1
eval_tap $? 4 'AdminGetLogConfig' test.out

#- 5 AdminPatchUpdateLogConfig
# body param: body
echo '{"logLevel": "panic"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op AdminPatchUpdateLogConfig \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 5 'AdminPatchUpdateLogConfig' test.out

#- 6 AdminGetAllConfigV1
$CLI_EXE \
    --sn match2 \
    --op AdminGetAllConfigV1 \
    > test.out 2>&1
eval_tap $? 6 'AdminGetAllConfigV1' test.out

#- 7 AdminGetConfigV1
$CLI_EXE \
    --sn match2 \
    --op AdminGetConfigV1 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 7 'AdminGetConfigV1' test.out

#- 8 AdminPatchConfigV1
# body param: body
echo '{"crossPlatformNoCurrentPlatform": true, "extraPlatforms": ["WwBGsUxP", "kwwXhUza", "kSe1YIoU"], "matchAnyCommon": false, "platformGroup": {"rDiRgpjM": ["RJKwXyTl", "GOAPtZdX", "rtjUhZCb"], "pUDHAIco": ["USAiNnWz", "VYw5GZFz", "x75epDFo"], "7F45hGMQ": ["QWFfORuV", "r5obCZVx", "xDJDooFx"]}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op AdminPatchConfigV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 8 'AdminPatchConfigV1' test.out

#- 9 EnvironmentVariableList
$CLI_EXE \
    --sn match2 \
    --op EnvironmentVariableList \
    > test.out 2>&1
eval_tap $? 9 'EnvironmentVariableList' test.out

#- 10 AdminQueryBackfill
$CLI_EXE \
    --sn match2 \
    --op AdminQueryBackfill \
    --namespace $AB_NAMESPACE \
    --fromTime '1984-08-06T00:00:00Z' \
    --isActive 'true' \
    --limit '55' \
    --matchPool 'WQx7Rb3n' \
    --offset '47' \
    --playerID 'wQVdxIIv' \
    --region 'lfdPiXPL' \
    --sessionID 'mEd3hQ99' \
    --toTime '1978-05-17T00:00:00Z' \
    > test.out 2>&1
eval_tap $? 10 'AdminQueryBackfill' test.out

#- 11 CreateBackfill
# body param: body
echo '{"matchPool": "hNEE5Rm6", "sessionId": "PxlxAgvZ"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op CreateBackfill \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 11 'CreateBackfill' test.out

#- 12 GetBackfillProposal
$CLI_EXE \
    --sn match2 \
    --op GetBackfillProposal \
    --namespace $AB_NAMESPACE \
    --sessionID '39gUc7i1' \
    > test.out 2>&1
eval_tap $? 12 'GetBackfillProposal' test.out

#- 13 GetBackfill
$CLI_EXE \
    --sn match2 \
    --op GetBackfill \
    --backfillID 'FzskI8Md' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 13 'GetBackfill' test.out

#- 14 DeleteBackfill
$CLI_EXE \
    --sn match2 \
    --op DeleteBackfill \
    --backfillID 'PZ6n2k1s' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 14 'DeleteBackfill' test.out

#- 15 AcceptBackfill
# body param: body
echo '{"acceptedTicketIds": ["K2DdtHlI", "VWkXrBCO", "KP0Hsq2M"], "proposalId": "Zk3qavSk", "stop": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op AcceptBackfill \
    --backfillID 'veTjASX9' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 15 'AcceptBackfill' test.out

#- 16 RejectBackfill
# body param: body
echo '{"proposalId": "jjv3OSOB", "stop": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op RejectBackfill \
    --backfillID 'qyWEs3uZ' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 16 'RejectBackfill' test.out

#- 17 MatchFunctionList
$CLI_EXE \
    --sn match2 \
    --op MatchFunctionList \
    --namespace $AB_NAMESPACE \
    --limit '20' \
    --offset '72' \
    > test.out 2>&1
eval_tap $? 17 'MatchFunctionList' test.out

#- 18 CreateMatchFunction
# body param: body
echo '{"match_function": "jcDz82RF", "serviceAppName": "I2cEj224", "url": "2JhZWLAG"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op CreateMatchFunction \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 18 'CreateMatchFunction' test.out

#- 19 MatchFunctionGet
$CLI_EXE \
    --sn match2 \
    --op MatchFunctionGet \
    --name '14ZYTQlU' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 19 'MatchFunctionGet' test.out

#- 20 UpdateMatchFunction
# body param: body
echo '{"match_function": "7aWbzBVm", "serviceAppName": "Lmwa3uQz", "url": "YOHDhRKq"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op UpdateMatchFunction \
    --name 'OVmdOrkK' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 20 'UpdateMatchFunction' test.out

#- 21 DeleteMatchFunction
$CLI_EXE \
    --sn match2 \
    --op DeleteMatchFunction \
    --name 'VAZXcm1V' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 21 'DeleteMatchFunction' test.out

#- 22 MatchPoolList
$CLI_EXE \
    --sn match2 \
    --op MatchPoolList \
    --namespace $AB_NAMESPACE \
    --limit '14' \
    --name 'fZgHez83' \
    --offset '15' \
    > test.out 2>&1
eval_tap $? 22 'MatchPoolList' test.out

#- 23 CreateMatchPool
# body param: body
echo '{"auto_accept_backfill_proposal": false, "backfill_proposal_expiration_seconds": 13, "backfill_ticket_expiration_seconds": 80, "best_latency_calculation_method": "Rwt4XQgF", "crossplay_disabled": false, "match_function": "bAmOxKKq", "match_function_override": {"backfill_matches": "aXeVehN9", "enrichment": ["jCyJtgCN", "sJRH5U0J", "XX13vSOZ"], "make_matches": "8n7jkTwV", "stat_codes": ["ajsCw3yh", "MgP2wM6t", "5IGBOIbL"], "validation": ["1q8ILQ3P", "IfszILA2", "SYOxRB06"]}, "name": "hjc1EiZ4", "platform_group_enabled": false, "rule_set": "hYnumh1p", "session_template": "S8CHEHKM", "ticket_expiration_seconds": 50}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op CreateMatchPool \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 23 'CreateMatchPool' test.out

#- 24 MatchPoolDetails
$CLI_EXE \
    --sn match2 \
    --op MatchPoolDetails \
    --namespace $AB_NAMESPACE \
    --pool '9SVR3IQO' \
    > test.out 2>&1
eval_tap $? 24 'MatchPoolDetails' test.out

#- 25 UpdateMatchPool
# body param: body
echo '{"auto_accept_backfill_proposal": true, "backfill_proposal_expiration_seconds": 39, "backfill_ticket_expiration_seconds": 6, "best_latency_calculation_method": "2WKFQfhy", "crossplay_disabled": false, "match_function": "pAD2EA7B", "match_function_override": {"backfill_matches": "dcyNDkv1", "enrichment": ["SMSRRgll", "eksDNE7b", "E1zHMe8E"], "make_matches": "dZ4pxxcJ", "stat_codes": ["uumEyEcb", "Sd1h3b6X", "6jzJ8ifW"], "validation": ["DR6v4CaP", "Ek9IGUMt", "nPCApz52"]}, "platform_group_enabled": false, "rule_set": "8iccpcYn", "session_template": "UQRmR5c5", "ticket_expiration_seconds": 34}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op UpdateMatchPool \
    --namespace $AB_NAMESPACE \
    --pool 'PFURCCdE' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 25 'UpdateMatchPool' test.out

#- 26 DeleteMatchPool
$CLI_EXE \
    --sn match2 \
    --op DeleteMatchPool \
    --namespace $AB_NAMESPACE \
    --pool 'rEVrE7T2' \
    > test.out 2>&1
eval_tap $? 26 'DeleteMatchPool' test.out

#- 27 MatchPoolMetric
$CLI_EXE \
    --sn match2 \
    --op MatchPoolMetric \
    --namespace $AB_NAMESPACE \
    --pool 'i9L5AScu' \
    > test.out 2>&1
eval_tap $? 27 'MatchPoolMetric' test.out

#- 28 PostMatchErrorMetric
# body param: body
echo '{"type": "getExternalDS"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op PostMatchErrorMetric \
    --namespace $AB_NAMESPACE \
    --pool 'nAZXYSL6' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 28 'PostMatchErrorMetric' test.out

#- 29 GetPlayerMetric
$CLI_EXE \
    --sn match2 \
    --op GetPlayerMetric \
    --namespace $AB_NAMESPACE \
    --pool 'L7JTZp40' \
    > test.out 2>&1
eval_tap $? 29 'GetPlayerMetric' test.out

#- 30 AdminGetMatchPoolTickets
$CLI_EXE \
    --sn match2 \
    --op AdminGetMatchPoolTickets \
    --namespace $AB_NAMESPACE \
    --pool '4iNTbR3P' \
    --limit '53' \
    --offset '73' \
    > test.out 2>&1
eval_tap $? 30 'AdminGetMatchPoolTickets' test.out

#- 31 CreateMatchTicket
# body param: body
echo '{"attributes": {"HhO1vsiG": {}, "ZlSxYrbw": {}, "qULrzyoW": {}}, "excludedSessions": ["hVZD5rSp", "FJv6uKMB", "juz0qFBh"], "latencies": {"bxLa153R": 84, "RvPRYcwU": 69, "g06qbAhL": 48}, "matchPool": "hPcwSJgs", "sessionID": "PLWzeBFU", "storage": {"dtTSSDuV": {}, "AtlI9cQP": {}, "hpw4EqDD": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op CreateMatchTicket \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 31 'CreateMatchTicket' test.out

#- 32 GetMyMatchTickets
$CLI_EXE \
    --sn match2 \
    --op GetMyMatchTickets \
    --namespace $AB_NAMESPACE \
    --limit '88' \
    --matchPool 'Z9umDiNX' \
    --offset '52' \
    > test.out 2>&1
eval_tap $? 32 'GetMyMatchTickets' test.out

#- 33 MatchTicketDetails
$CLI_EXE \
    --sn match2 \
    --op MatchTicketDetails \
    --namespace $AB_NAMESPACE \
    --ticketid 'pTlOd23d' \
    > test.out 2>&1
eval_tap $? 33 'MatchTicketDetails' test.out

#- 34 DeleteMatchTicket
$CLI_EXE \
    --sn match2 \
    --op DeleteMatchTicket \
    --namespace $AB_NAMESPACE \
    --ticketid 'i3hxNr7d' \
    > test.out 2>&1
eval_tap $? 34 'DeleteMatchTicket' test.out

#- 35 RuleSetList
$CLI_EXE \
    --sn match2 \
    --op RuleSetList \
    --namespace $AB_NAMESPACE \
    --limit '20' \
    --name 'tdtSP1ws' \
    --offset '0' \
    > test.out 2>&1
eval_tap $? 35 'RuleSetList' test.out

#- 36 CreateRuleSet
# body param: body
echo '{"data": {"wmRIFnce": {}, "6K00vYBV": {}, "Pe7gmW0O": {}}, "enable_custom_match_function": true, "name": "o1VofsL5"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op CreateRuleSet \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 36 'CreateRuleSet' test.out

#- 37 RuleSetDetails
$CLI_EXE \
    --sn match2 \
    --op RuleSetDetails \
    --namespace $AB_NAMESPACE \
    --ruleset '8FOuQoDo' \
    > test.out 2>&1
eval_tap $? 37 'RuleSetDetails' test.out

#- 38 UpdateRuleSet
# body param: body
echo '{"data": {"0KZgbqgW": {}, "N39DQ5xB": {}, "5rvvK6Ri": {}}, "enable_custom_match_function": false, "name": "vhn0mRwD"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op UpdateRuleSet \
    --namespace $AB_NAMESPACE \
    --ruleset '1ARrSaX9' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 38 'UpdateRuleSet' test.out

#- 39 DeleteRuleSet
$CLI_EXE \
    --sn match2 \
    --op DeleteRuleSet \
    --namespace $AB_NAMESPACE \
    --ruleset 'x9mxxbFr' \
    > test.out 2>&1
eval_tap $? 39 'DeleteRuleSet' test.out

#- 40 PublicGetPlayerMetric
$CLI_EXE \
    --sn match2 \
    --op PublicGetPlayerMetric \
    --namespace $AB_NAMESPACE \
    --pool 'l3U9P2BK' \
    > test.out 2>&1
eval_tap $? 40 'PublicGetPlayerMetric' test.out

#- 41 VersionCheckHandler
$CLI_EXE \
    --sn match2 \
    --op VersionCheckHandler \
    > test.out 2>&1
eval_tap $? 41 'VersionCheckHandler' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE