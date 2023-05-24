#!/usr/bin/env bash

# Copyright (c) 2021 AccelByte Inc. All Rights Reserved.
# This is licensed software from AccelByte Inc, for limitations
# and restrictions contact your company contract manager.

# This code is generated by tool. DO NOT EDIT.

# Meta:
# - random seed: 512
# - template file: cli-test.j2

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
echo "1..29"

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

#- 4 CreateBackfill
# body param: body
echo '{"matchPool": "bBuz5zkoaUEzGS3q", "sessionId": "Zf0PbemSBELbZ0VB"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op CreateBackfill \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 4 'CreateBackfill' test.out

#- 5 GetBackfillProposal
$CLI_EXE \
    --sn match2 \
    --op GetBackfillProposal \
    --namespace $AB_NAMESPACE \
    --sessionID 'UGA7nkDeev2Oj060' \
    > test.out 2>&1
eval_tap $? 5 'GetBackfillProposal' test.out

#- 6 GetBackfill
$CLI_EXE \
    --sn match2 \
    --op GetBackfill \
    --backfillID 'HnOf5S8X1LxkZs42' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 6 'GetBackfill' test.out

#- 7 DeleteBackfill
$CLI_EXE \
    --sn match2 \
    --op DeleteBackfill \
    --backfillID '33oQWoXFeqeuI2oM' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 7 'DeleteBackfill' test.out

#- 8 AcceptBackfill
# body param: body
echo '{"proposalId": "J0cgAoGfXepE3r5A", "stop": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op AcceptBackfill \
    --backfillID 'BqS8KtTYZLJ58Qqc' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 8 'AcceptBackfill' test.out

#- 9 RejectBackfill
# body param: body
echo '{"proposalId": "V3IcuNs9MF5BT2KD", "stop": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op RejectBackfill \
    --backfillID 'yrWorpC65VJh4q1z' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 9 'RejectBackfill' test.out

#- 10 MatchFunctionList
$CLI_EXE \
    --sn match2 \
    --op MatchFunctionList \
    --namespace $AB_NAMESPACE \
    --limit '95' \
    --offset '75' \
    > test.out 2>&1
eval_tap $? 10 'MatchFunctionList' test.out

#- 11 CreateMatchFunction
# body param: body
echo '{"match_function": "1MO8XnVaEyjmifJD", "url": "Ya1TJPUszmFGEkJV"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op CreateMatchFunction \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 11 'CreateMatchFunction' test.out

#- 12 UpdateMatchFunction
# body param: body
echo '{"match_function": "vqDSU3PDyIAGfGq1", "url": "FNmRWvUvDPnKoECj"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op UpdateMatchFunction \
    --name 'GUg867xodwuG14ID' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 12 'UpdateMatchFunction' test.out

#- 13 DeleteMatchFunction
$CLI_EXE \
    --sn match2 \
    --op DeleteMatchFunction \
    --name '5l5wj6K2wEMnckjl' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 13 'DeleteMatchFunction' test.out

#- 14 MatchPoolList
$CLI_EXE \
    --sn match2 \
    --op MatchPoolList \
    --namespace $AB_NAMESPACE \
    --limit '100' \
    --offset '40' \
    > test.out 2>&1
eval_tap $? 14 'MatchPoolList' test.out

#- 15 CreateMatchPool
# body param: body
echo '{"auto_accept_backfill_proposal": false, "backfill_proposal_expiration_seconds": 57, "backfill_ticket_expiration_seconds": 82, "match_function": "ywsSSZTGlubsmhjX", "match_function_override": {"backfill_matches": "cScOUvrjJBO7tbkT", "enrichment": ["GYKqRMSTisP0MrSd", "aFy0pJYCdfkfyt09", "ro5fHdWqJTNjrmpn"], "make_matches": "nEckHH8kT9oXVand", "stat_codes": ["ercf1nq4Hf32SL5P", "jaYEDxaYN8w9KUW0", "py8KrcQfucSq2X8g"], "validation": ["FuJORk4j04YfnXTs", "QUrA0WWyKl2K5mCS", "oGeQCahcox63cyDx"]}, "name": "AAYcRXJdoSTxNCK9", "rule_set": "AIjNmbfoW8bDq5jP", "session_template": "qzhN0YdGSrA9LXRw", "ticket_expiration_seconds": 95}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op CreateMatchPool \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 15 'CreateMatchPool' test.out

#- 16 MatchPoolDetails
$CLI_EXE \
    --sn match2 \
    --op MatchPoolDetails \
    --namespace $AB_NAMESPACE \
    --pool '9Njm50xCDlPeNq0C' \
    > test.out 2>&1
eval_tap $? 16 'MatchPoolDetails' test.out

#- 17 UpdateMatchPool
# body param: body
echo '{"auto_accept_backfill_proposal": true, "backfill_proposal_expiration_seconds": 50, "backfill_ticket_expiration_seconds": 78, "match_function": "MR4Xf2nfYvNvG8uQ", "match_function_override": {"backfill_matches": "14AhsxaALiBwpNJo", "enrichment": ["rnrCQpMJj5igqat8", "xnPoWTdHAkcyAy4d", "rHlPcXGGl0Xw3veB"], "make_matches": "frpCrnbaxhEvn3SG", "stat_codes": ["qcH91fC3aJEoqWaF", "AGD6PRg95m07l03v", "tlMFzeiMRkcOr1L0"], "validation": ["TMIczbYilOziwG8C", "PLOzSZm9K3cMY617", "HSCYZaL46I3PgCcQ"]}, "rule_set": "0axTWnmyEYLZQTpv", "session_template": "LH6QPEBP8kSSFjeu", "ticket_expiration_seconds": 78}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op UpdateMatchPool \
    --namespace $AB_NAMESPACE \
    --pool 'beisZelKuD0iJ6fs' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 17 'UpdateMatchPool' test.out

#- 18 DeleteMatchPool
$CLI_EXE \
    --sn match2 \
    --op DeleteMatchPool \
    --namespace $AB_NAMESPACE \
    --pool '3zL9H4WxGWRH7fz4' \
    > test.out 2>&1
eval_tap $? 18 'DeleteMatchPool' test.out

#- 19 MatchPoolMetric
$CLI_EXE \
    --sn match2 \
    --op MatchPoolMetric \
    --namespace $AB_NAMESPACE \
    --pool 'BdPhLtHRJOImSq37' \
    > test.out 2>&1
eval_tap $? 19 'MatchPoolMetric' test.out

#- 20 GetPlayerMetric
$CLI_EXE \
    --sn match2 \
    --op GetPlayerMetric \
    --namespace $AB_NAMESPACE \
    --pool 'aeAaGq0NIj53gXkm' \
    > test.out 2>&1
eval_tap $? 20 'GetPlayerMetric' test.out

#- 21 CreateMatchTicket
# body param: body
echo '{"attributes": {"rayvcIYiWxIAxfvL": {}, "zSpDFY3lxe16KsSR": {}, "zkf2HzBcEio5Uyvu": {}}, "latencies": {"Fv5z6wosJGnUyCME": 3, "N8YZT0yJJ0uCjjaN": 59, "Uw36GtZ83Jp2f9f1": 65}, "matchPool": "qg9oGVEdC8mQir1A", "sessionID": "f0G6OrPH6ZsjpPgH"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op CreateMatchTicket \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 21 'CreateMatchTicket' test.out

#- 22 MatchTicketDetails
$CLI_EXE \
    --sn match2 \
    --op MatchTicketDetails \
    --namespace $AB_NAMESPACE \
    --ticketid 'KISHtB8tWdJM9Qc5' \
    > test.out 2>&1
eval_tap $? 22 'MatchTicketDetails' test.out

#- 23 DeleteMatchTicket
$CLI_EXE \
    --sn match2 \
    --op DeleteMatchTicket \
    --namespace $AB_NAMESPACE \
    --ticketid 'HmR0vknXO45AUtNX' \
    > test.out 2>&1
eval_tap $? 23 'DeleteMatchTicket' test.out

#- 24 RuleSetList
$CLI_EXE \
    --sn match2 \
    --op RuleSetList \
    --namespace $AB_NAMESPACE \
    --limit '92' \
    --offset '34' \
    > test.out 2>&1
eval_tap $? 24 'RuleSetList' test.out

#- 25 CreateRuleSet
# body param: body
echo '{"data": {"TItt35OJTfJBZX62": {}, "yI9g5RDrlzPFQmNu": {}, "3ERxV0UTaiSzfi0F": {}}, "enable_custom_match_function": false, "name": "ZjTYM95e4aa8xOJu"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op CreateRuleSet \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 25 'CreateRuleSet' test.out

#- 26 RuleSetDetails
$CLI_EXE \
    --sn match2 \
    --op RuleSetDetails \
    --namespace $AB_NAMESPACE \
    --ruleset '7rNRVdygfKmUkzj9' \
    > test.out 2>&1
eval_tap $? 26 'RuleSetDetails' test.out

#- 27 UpdateRuleSet
# body param: body
echo '{"data": {"mHFpff2vDkz68zor": {}, "EgcExv9nKMOgO5W8": {}, "SUaZjCpNtJSMm8kD": {}}, "enable_custom_match_function": false, "name": "tdK2r4wWs6IpYBxa"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn match2 \
    --op UpdateRuleSet \
    --namespace $AB_NAMESPACE \
    --ruleset 'fo9b4xJyNnvHKrm8' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 27 'UpdateRuleSet' test.out

#- 28 DeleteRuleSet
$CLI_EXE \
    --sn match2 \
    --op DeleteRuleSet \
    --namespace $AB_NAMESPACE \
    --ruleset 'UuNlT86N9yO0vyD6' \
    > test.out 2>&1
eval_tap $? 28 'DeleteRuleSet' test.out

#- 29 VersionCheckHandler
$CLI_EXE \
    --sn match2 \
    --op VersionCheckHandler \
    > test.out 2>&1
eval_tap $? 29 'VersionCheckHandler' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE