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
echo "1..38"

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
echo '{"logLevel": "error"}' > $TEMP_JSON_INPUT
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
echo '{"crossPlatformNoCurrentPlatform": true, "extraPlatforms": ["sw8BMTlo", "lNX3a2hJ", "n5fpbarn"], "matchAnyCommon": true, "platformGroup": {"zmLxsxhr": ["8RQ9bHkb", "cRekg5za", "yriD1jUi"], "fW4qCQ51": ["AgdPHZaY", "StvjsaDJ", "4ykTLujk"], "YqR0u7Dn": ["RIpTrVcv", "KKrTYLlX", "ieIUpZJz"]}}' > $TEMP_JSON_INPUT
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

#- 10 CreateBackfill
# body param: body
echo '{"matchPool": "4Va2N1s9", "sessionId": "JpNGNN3D"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op CreateBackfill \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 10 'CreateBackfill' test.out

#- 11 GetBackfillProposal
$CLI_EXE \
    --sn match2 \
    --op GetBackfillProposal \
    --namespace $AB_NAMESPACE \
    --sessionID 'hok6pdi2' \
    > test.out 2>&1
eval_tap $? 11 'GetBackfillProposal' test.out

#- 12 GetBackfill
$CLI_EXE \
    --sn match2 \
    --op GetBackfill \
    --backfillID 'b79jyBMF' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 12 'GetBackfill' test.out

#- 13 DeleteBackfill
$CLI_EXE \
    --sn match2 \
    --op DeleteBackfill \
    --backfillID 'Nvua7kJP' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 13 'DeleteBackfill' test.out

#- 14 AcceptBackfill
# body param: body
echo '{"acceptedTicketIds": ["CoHZOJsq", "ZmZpLie6", "6bXpEhsc"], "proposalId": "gkWp8lPD", "stop": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op AcceptBackfill \
    --backfillID 'JFMEWwFe' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 14 'AcceptBackfill' test.out

#- 15 RejectBackfill
# body param: body
echo '{"proposalId": "PYPfN9iU", "stop": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op RejectBackfill \
    --backfillID 'i175T4wm' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 15 'RejectBackfill' test.out

#- 16 MatchFunctionList
$CLI_EXE \
    --sn match2 \
    --op MatchFunctionList \
    --namespace $AB_NAMESPACE \
    --limit '44' \
    --offset '48' \
    > test.out 2>&1
eval_tap $? 16 'MatchFunctionList' test.out

#- 17 CreateMatchFunction
# body param: body
echo '{"match_function": "Wggx0yt9", "serviceAppName": "jo7C9OXM", "url": "PSrtqBVp"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op CreateMatchFunction \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 17 'CreateMatchFunction' test.out

#- 18 UpdateMatchFunction
# body param: body
echo '{"match_function": "saAO8Dhv", "serviceAppName": "msqBhURU", "url": "Znhl0Ohz"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op UpdateMatchFunction \
    --name 'eRXmVt4F' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 18 'UpdateMatchFunction' test.out

#- 19 DeleteMatchFunction
$CLI_EXE \
    --sn match2 \
    --op DeleteMatchFunction \
    --name '61JSjRxv' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 19 'DeleteMatchFunction' test.out

#- 20 MatchPoolList
$CLI_EXE \
    --sn match2 \
    --op MatchPoolList \
    --namespace $AB_NAMESPACE \
    --limit '32' \
    --name 'bpFwKLWo' \
    --offset '86' \
    > test.out 2>&1
eval_tap $? 20 'MatchPoolList' test.out

#- 21 CreateMatchPool
# body param: body
echo '{"auto_accept_backfill_proposal": false, "backfill_proposal_expiration_seconds": 91, "backfill_ticket_expiration_seconds": 35, "best_latency_calculation_method": "0asuy6oY", "crossplay_disabled": true, "match_function": "Cf7TKQ6A", "match_function_override": {"backfill_matches": "Ld53xKlN", "enrichment": ["UGS0GlcZ", "gN8adVuf", "C2bHUuZN"], "make_matches": "P9CjeVfs", "stat_codes": ["rmIQCHiV", "MjtU3nos", "SyiJwnE0"], "validation": ["x1oeDNx5", "hInHe0pQ", "Uw5781gp"]}, "name": "2bONxF9q", "platform_group_enabled": true, "rule_set": "WqdQAFOq", "session_template": "twk1UjG6", "ticket_expiration_seconds": 65}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op CreateMatchPool \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 21 'CreateMatchPool' test.out

#- 22 MatchPoolDetails
$CLI_EXE \
    --sn match2 \
    --op MatchPoolDetails \
    --namespace $AB_NAMESPACE \
    --pool 'hquNUNhM' \
    > test.out 2>&1
eval_tap $? 22 'MatchPoolDetails' test.out

#- 23 UpdateMatchPool
# body param: body
echo '{"auto_accept_backfill_proposal": false, "backfill_proposal_expiration_seconds": 72, "backfill_ticket_expiration_seconds": 62, "best_latency_calculation_method": "amYPwFJU", "crossplay_disabled": false, "match_function": "RHfaIrOj", "match_function_override": {"backfill_matches": "XICdXXFv", "enrichment": ["WBav7hfl", "A57iwaLu", "jfZXStH0"], "make_matches": "m6MxoNpM", "stat_codes": ["FVntCPmR", "TW1EPbcC", "DbahptYK"], "validation": ["twg8Krb5", "iVUsIlMe", "T92Qquq3"]}, "platform_group_enabled": true, "rule_set": "o5TvJRIs", "session_template": "DEmusbB1", "ticket_expiration_seconds": 19}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op UpdateMatchPool \
    --namespace $AB_NAMESPACE \
    --pool 'HvN8SuN1' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 23 'UpdateMatchPool' test.out

#- 24 DeleteMatchPool
$CLI_EXE \
    --sn match2 \
    --op DeleteMatchPool \
    --namespace $AB_NAMESPACE \
    --pool '3zg9f2bS' \
    > test.out 2>&1
eval_tap $? 24 'DeleteMatchPool' test.out

#- 25 MatchPoolMetric
$CLI_EXE \
    --sn match2 \
    --op MatchPoolMetric \
    --namespace $AB_NAMESPACE \
    --pool 'R2pZ1ZeS' \
    > test.out 2>&1
eval_tap $? 25 'MatchPoolMetric' test.out

#- 26 GetPlayerMetric
$CLI_EXE \
    --sn match2 \
    --op GetPlayerMetric \
    --namespace $AB_NAMESPACE \
    --pool '8mMaLV9F' \
    > test.out 2>&1
eval_tap $? 26 'GetPlayerMetric' test.out

#- 27 AdminGetMatchPoolTickets
$CLI_EXE \
    --sn match2 \
    --op AdminGetMatchPoolTickets \
    --namespace $AB_NAMESPACE \
    --pool 'RbqujZn8' \
    --limit '26' \
    --offset '95' \
    > test.out 2>&1
eval_tap $? 27 'AdminGetMatchPoolTickets' test.out

#- 28 CreateMatchTicket
# body param: body
echo '{"attributes": {"tWKSrK1C": {}, "70HxS5Lv": {}, "sWP8wbrX": {}}, "excludedSessions": ["sHgcw4Ig", "VISenM27", "XIEWS6mX"], "latencies": {"F8dEQZYX": 86, "6D0aHsXJ": 52, "k1toBvfp": 54}, "matchPool": "iBqiaC2f", "sessionID": "wD0ZM35z", "storage": {"W6MeBfaH": {}, "7jRKerOX": {}, "LfI8Dhyq": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op CreateMatchTicket \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 28 'CreateMatchTicket' test.out

#- 29 GetMyMatchTickets
$CLI_EXE \
    --sn match2 \
    --op GetMyMatchTickets \
    --namespace $AB_NAMESPACE \
    --limit '28' \
    --matchPool '6RzpkjxE' \
    --offset '66' \
    > test.out 2>&1
eval_tap $? 29 'GetMyMatchTickets' test.out

#- 30 MatchTicketDetails
$CLI_EXE \
    --sn match2 \
    --op MatchTicketDetails \
    --namespace $AB_NAMESPACE \
    --ticketid 'xOImDF17' \
    > test.out 2>&1
eval_tap $? 30 'MatchTicketDetails' test.out

#- 31 DeleteMatchTicket
$CLI_EXE \
    --sn match2 \
    --op DeleteMatchTicket \
    --namespace $AB_NAMESPACE \
    --ticketid '51FhjnYG' \
    > test.out 2>&1
eval_tap $? 31 'DeleteMatchTicket' test.out

#- 32 RuleSetList
$CLI_EXE \
    --sn match2 \
    --op RuleSetList \
    --namespace $AB_NAMESPACE \
    --limit '63' \
    --name 'yg78M63R' \
    --offset '41' \
    > test.out 2>&1
eval_tap $? 32 'RuleSetList' test.out

#- 33 CreateRuleSet
# body param: body
echo '{"data": {"WRyDJVLA": {}, "WQWlLe6n": {}, "Rfg1YJAz": {}}, "enable_custom_match_function": true, "name": "uTfoCZx6"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op CreateRuleSet \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 33 'CreateRuleSet' test.out

#- 34 RuleSetDetails
$CLI_EXE \
    --sn match2 \
    --op RuleSetDetails \
    --namespace $AB_NAMESPACE \
    --ruleset 'd90UfE1K' \
    > test.out 2>&1
eval_tap $? 34 'RuleSetDetails' test.out

#- 35 UpdateRuleSet
# body param: body
echo '{"data": {"KGGspxjM": {}, "k63mxqiC": {}, "xphEEHmK": {}}, "enable_custom_match_function": false, "name": "vUKyJowy"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op UpdateRuleSet \
    --namespace $AB_NAMESPACE \
    --ruleset 'vMNXWrhm' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 35 'UpdateRuleSet' test.out

#- 36 DeleteRuleSet
$CLI_EXE \
    --sn match2 \
    --op DeleteRuleSet \
    --namespace $AB_NAMESPACE \
    --ruleset 'hKFe6lWV' \
    > test.out 2>&1
eval_tap $? 36 'DeleteRuleSet' test.out

#- 37 PublicGetPlayerMetric
$CLI_EXE \
    --sn match2 \
    --op PublicGetPlayerMetric \
    --namespace $AB_NAMESPACE \
    --pool 'Fw6kCnjL' \
    > test.out 2>&1
eval_tap $? 37 'PublicGetPlayerMetric' test.out

#- 38 VersionCheckHandler
$CLI_EXE \
    --sn match2 \
    --op VersionCheckHandler \
    > test.out 2>&1
eval_tap $? 38 'VersionCheckHandler' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE