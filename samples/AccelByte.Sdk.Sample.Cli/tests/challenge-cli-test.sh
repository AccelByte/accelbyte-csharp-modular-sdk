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

#- 2 AdminGetChallenges
$CLI_EXE \
    --sn challenge \
    --op AdminGetChallenges \
    --namespace $AB_NAMESPACE \
    --limit '48' \
    --offset '82' \
    --sortBy 'createdAt' \
    --status 'INIT' \
    > test.out 2>&1
eval_tap $? 2 'AdminGetChallenges' test.out

#- 3 AdminCreateChallenge
# body param: body
echo '{"activeGoalsPerRotation": 34, "assignmentRule": "FIXED", "code": "GJKgVxxX", "description": "QEyZTHwC", "endAfter": 58, "endDate": "1977-04-11T00:00:00Z", "goalsVisibility": "SHOWALL", "name": "tP6Ob5qv", "randomizedPerRotation": false, "repeatAfter": 63, "resetConfig": {"resetDate": 36, "resetDay": 85, "resetTime": "eMuCJQ7e"}, "rotation": "DAILY", "startDate": "1994-05-14T00:00:00Z"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn challenge \
    --op AdminCreateChallenge \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 3 'AdminCreateChallenge' test.out

#- 4 AdminGetActiveChallenges
$CLI_EXE \
    --sn challenge \
    --op AdminGetActiveChallenges \
    --namespace $AB_NAMESPACE \
    --userId 'SxyjgHWK' \
    --limit '49' \
    --offset '26' \
    > test.out 2>&1
eval_tap $? 4 'AdminGetActiveChallenges' test.out

#- 5 AdminGetChallenge
$CLI_EXE \
    --sn challenge \
    --op AdminGetChallenge \
    --challengeCode 'f9gwRUzL' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 5 'AdminGetChallenge' test.out

#- 6 AdminUpdateChallenge
# body param: body
echo '{"activeGoalsPerRotation": 22, "assignmentRule": "RANDOMIZED", "description": "L1GXhpMo", "endAfter": 24, "endDate": "1989-03-13T00:00:00Z", "goalsVisibility": "SHOWALL", "name": "bwK3OPhx", "randomizedPerRotation": true, "repeatAfter": 53, "resetConfig": {"resetDate": 72, "resetDay": 43, "resetTime": "GbUfjG9h"}, "rotation": "DAILY", "startDate": "1998-06-11T00:00:00Z"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn challenge \
    --op AdminUpdateChallenge \
    --challengeCode '0UQhirS2' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 6 'AdminUpdateChallenge' test.out

#- 7 AdminDeleteChallenge
$CLI_EXE \
    --sn challenge \
    --op AdminDeleteChallenge \
    --challengeCode '5Vj3Xb2G' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 7 'AdminDeleteChallenge' test.out

#- 8 AdminGetGoals
$CLI_EXE \
    --sn challenge \
    --op AdminGetGoals \
    --challengeCode 'Hj8ZFW7G' \
    --namespace $AB_NAMESPACE \
    --limit '81' \
    --offset '96' \
    --sortBy 'updatedAt:asc' \
    > test.out 2>&1
eval_tap $? 8 'AdminGetGoals' test.out

#- 9 AdminCreateGoal
# body param: body
echo '{"code": "QpnrpJSa", "description": "lCkUpE3z", "isActive": false, "name": "Ygzeq758", "requirementGroups": [{"operator": "AND", "predicates": [{"matcher": "EQUAL", "parameterName": "7sMbbNr9", "parameterType": "STATISTIC", "statCycleId": "HxkyRyzK", "targetValue": 0.4469777696597962}, {"matcher": "GREATER_THAN_EQUAL", "parameterName": "DD3LLdV9", "parameterType": "ACHIEVEMENT", "statCycleId": "fSgG7qpZ", "targetValue": 0.8756387953269947}, {"matcher": "LESS_THAN", "parameterName": "DvCXQxo4", "parameterType": "STATISTIC", "statCycleId": "6SYBza0O", "targetValue": 0.24770680720525162}]}, {"operator": "AND", "predicates": [{"matcher": "GREATER_THAN_EQUAL", "parameterName": "q6Ufy0bm", "parameterType": "USERACCOUNT", "statCycleId": "RlcUsSRX", "targetValue": 0.7535201636443296}, {"matcher": "EQUAL", "parameterName": "mgPMxg4f", "parameterType": "ENTITLEMENT", "statCycleId": "HxsD6L7k", "targetValue": 0.5405897767058851}, {"matcher": "LESS_THAN", "parameterName": "FiwrPPpI", "parameterType": "STATISTIC", "statCycleId": "lX7HwN1u", "targetValue": 0.056421950447133606}]}, {"operator": "AND", "predicates": [{"matcher": "EQUAL", "parameterName": "GXFK2xw9", "parameterType": "STATISTIC", "statCycleId": "qGmCTw5I", "targetValue": 0.2592686960633922}, {"matcher": "GREATER_THAN", "parameterName": "LPgmpg10", "parameterType": "STATISTIC_CYCLE", "statCycleId": "ZMpsbyUc", "targetValue": 0.4582095735279754}, {"matcher": "EQUAL", "parameterName": "3jyZH9Jv", "parameterType": "ACHIEVEMENT", "statCycleId": "mCqsnxRf", "targetValue": 0.7370099418503566}]}], "rewards": [{"itemId": "rCbAGYvd", "itemName": "fUYw6SfA", "qty": 0.7869166479796703, "type": "STATISTIC"}, {"itemId": "LIU2hFeB", "itemName": "9iae2Vn8", "qty": 0.6804479495412461, "type": "STATISTIC"}, {"itemId": "fds42bT6", "itemName": "2D1rkq0X", "qty": 0.278810310471013, "type": "STATISTIC"}], "schedule": {"endTime": "1997-10-26T00:00:00Z", "order": 31, "startTime": "1976-06-05T00:00:00Z"}, "tags": ["P8KQoN9X", "1jXbY0rs", "0fRjYWYF"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn challenge \
    --op AdminCreateGoal \
    --challengeCode 'LIqXbs2V' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 9 'AdminCreateGoal' test.out

#- 10 AdminGetGoal
$CLI_EXE \
    --sn challenge \
    --op AdminGetGoal \
    --challengeCode 'A6Po0KxU' \
    --code 'nffY7Rkc' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 10 'AdminGetGoal' test.out

#- 11 AdminUpdateGoals
# body param: body
echo '{"description": "8lyLTwiG", "isActive": true, "name": "GhCKNJ9g", "requirementGroups": [{"operator": "AND", "predicates": [{"matcher": "LESS_THAN_EQUAL", "parameterName": "KtsAWSM1", "parameterType": "ACHIEVEMENT", "statCycleId": "o83tX5cg", "targetValue": 0.39701134992008025}, {"matcher": "LESS_THAN", "parameterName": "02bH5Us1", "parameterType": "STATISTIC_CYCLE", "statCycleId": "cfgY2uu4", "targetValue": 0.6298175393171984}, {"matcher": "EQUAL", "parameterName": "jORNVbDF", "parameterType": "STATISTIC", "statCycleId": "jqS2fzPw", "targetValue": 0.223720575793657}]}, {"operator": "AND", "predicates": [{"matcher": "GREATER_THAN_EQUAL", "parameterName": "1Ir1cpRI", "parameterType": "USERACCOUNT", "statCycleId": "j7N8hOym", "targetValue": 0.21048875776148634}, {"matcher": "LESS_THAN_EQUAL", "parameterName": "qIpsZk1V", "parameterType": "ENTITLEMENT", "statCycleId": "PMFCu07T", "targetValue": 0.2665854079531894}, {"matcher": "LESS_THAN", "parameterName": "QcFLPWks", "parameterType": "ENTITLEMENT", "statCycleId": "DGP7kCNh", "targetValue": 0.16863265924081483}]}, {"operator": "AND", "predicates": [{"matcher": "GREATER_THAN", "parameterName": "ICxNeROl", "parameterType": "STATISTIC", "statCycleId": "iq7WQpz4", "targetValue": 0.077774519090401}, {"matcher": "LESS_THAN", "parameterName": "socC4niv", "parameterType": "STATISTIC", "statCycleId": "uGhq22aR", "targetValue": 0.12042952013729624}, {"matcher": "EQUAL", "parameterName": "o2MlMRHl", "parameterType": "USERACCOUNT", "statCycleId": "aKEnwiLc", "targetValue": 0.3266689465784788}]}], "rewards": [{"itemId": "ASQsEFfU", "itemName": "hsZe7bu6", "qty": 0.5059609742923113, "type": "STATISTIC"}, {"itemId": "SOfskxY1", "itemName": "8V76FSMe", "qty": 0.0033731848721665347, "type": "ENTITLEMENT"}, {"itemId": "HgUD7S2j", "itemName": "JLwDdtUw", "qty": 0.31591981385057344, "type": "STATISTIC"}], "schedule": {"endTime": "1997-03-03T00:00:00Z", "order": 2, "startTime": "1985-05-15T00:00:00Z"}, "tags": ["azXawgee", "M82RH201", "zkyKJLe8"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn challenge \
    --op AdminUpdateGoals \
    --challengeCode 'ja5l8q4c' \
    --code 'RG4IGyB2' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 11 'AdminUpdateGoals' test.out

#- 12 AdminDeleteGoal
$CLI_EXE \
    --sn challenge \
    --op AdminDeleteGoal \
    --challengeCode '1vkgwHAn' \
    --code 'luMMIZfm' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 12 'AdminDeleteGoal' test.out

#- 13 AdminListSchedulesByGoal
$CLI_EXE \
    --sn challenge \
    --op AdminListSchedulesByGoal \
    --challengeCode 'zhkukONE' \
    --code 'FgtRKI4q' \
    --namespace $AB_NAMESPACE \
    --limit '90' \
    --offset '93' \
    --userId 'qf5MtgE3' \
    > test.out 2>&1
eval_tap $? 13 'AdminListSchedulesByGoal' test.out

#- 14 AdminGetPeriods
$CLI_EXE \
    --sn challenge \
    --op AdminGetPeriods \
    --challengeCode 'EIms52r7' \
    --namespace $AB_NAMESPACE \
    --limit '99' \
    --offset '49' \
    > test.out 2>&1
eval_tap $? 14 'AdminGetPeriods' test.out

#- 15 AdminRandomizeChallenge
$CLI_EXE \
    --sn challenge \
    --op AdminRandomizeChallenge \
    --challengeCode 'PQEroWIK' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 15 'AdminRandomizeChallenge' test.out

#- 16 AdminListSchedules
$CLI_EXE \
    --sn challenge \
    --op AdminListSchedules \
    --challengeCode 'FA7K8u9R' \
    --namespace $AB_NAMESPACE \
    --dateTime '1991-06-27T00:00:00Z' \
    --limit '73' \
    --offset '95' \
    --userId '21glysL3' \
    > test.out 2>&1
eval_tap $? 16 'AdminListSchedules' test.out

#- 17 AdminDeleteTiedChallenge
$CLI_EXE \
    --sn challenge \
    --op AdminDeleteTiedChallenge \
    --challengeCode 'EBZtxAD0' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 17 'AdminDeleteTiedChallenge' test.out

#- 18 AdminUpdateTiedChallengeSchedule
# body param: body
echo '{"action": "ACCELERATE", "endDate": "1995-12-12T00:00:00Z"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn challenge \
    --op AdminUpdateTiedChallengeSchedule \
    --challengeCode 'x7nlFUKE' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 18 'AdminUpdateTiedChallengeSchedule' test.out

#- 19 AdminGetAssignmentPlugin
$CLI_EXE \
    --sn challenge \
    --op AdminGetAssignmentPlugin \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 19 'AdminGetAssignmentPlugin' test.out

#- 20 AdminUpdateAssignmentPlugin
# body param: body
echo '{"appName": "UuFxtgU7", "extendType": "CUSTOM", "grpcServerAddress": "U2889XDJ"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn challenge \
    --op AdminUpdateAssignmentPlugin \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 20 'AdminUpdateAssignmentPlugin' test.out

#- 21 AdminCreateAssignmentPlugin
# body param: body
echo '{"appName": "ZTSk2c4l", "extendType": "APP", "grpcServerAddress": "Re1UtZ4k"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn challenge \
    --op AdminCreateAssignmentPlugin \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 21 'AdminCreateAssignmentPlugin' test.out

#- 22 AdminDeleteAssignmentPlugin
$CLI_EXE \
    --sn challenge \
    --op AdminDeleteAssignmentPlugin \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 22 'AdminDeleteAssignmentPlugin' test.out

#- 23 AdminEvaluateProgress
# body param: body
echo '{"userIds": ["wBRzLfZq", "rKvvBY1X", "pcJSwXbj"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn challenge \
    --op AdminEvaluateProgress \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 23 'AdminEvaluateProgress' test.out

#- 24 AdminClaimUsersRewards
# body param: body
echo '[{"rewardIds": ["k72B2u8f", "ppSIK6el", "J8r3Mh5r"], "userId": "4H2P1xST"}, {"rewardIds": ["ZAAf5jlF", "ae3bxnSt", "Dh6B73Oc"], "userId": "95sUr0eN"}, {"rewardIds": ["7JrxElXI", "XFdPvSIw", "qMHMRKLt"], "userId": "NVqlx0Uh"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn challenge \
    --op AdminClaimUsersRewards \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 24 'AdminClaimUsersRewards' test.out

#- 25 AdminClaimUserRewardsByGoalCode
# body param: body
echo '{"goalCode": "6MuaC2fN"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn challenge \
    --op AdminClaimUserRewardsByGoalCode \
    --challengeCode 'YXyErBU8' \
    --namespace $AB_NAMESPACE \
    --userId 'OP8usZTU' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 25 'AdminClaimUserRewardsByGoalCode' test.out

#- 26 AdminGetUserProgression
$CLI_EXE \
    --sn challenge \
    --op AdminGetUserProgression \
    --challengeCode 'EiLMDGKm' \
    --namespace $AB_NAMESPACE \
    --userId 'DyNTO6gh' \
    --dateTime '1974-11-08T00:00:00Z' \
    --goalCode 'bfpK1Ax2' \
    --limit '97' \
    --offset '90' \
    --tags '["YNLrPErU", "wVUWEJSn", "eyqiz89S"]' \
    > test.out 2>&1
eval_tap $? 26 'AdminGetUserProgression' test.out

#- 27 AdminGetUserRewards
$CLI_EXE \
    --sn challenge \
    --op AdminGetUserRewards \
    --namespace $AB_NAMESPACE \
    --userId 'cjyhFSNL' \
    --challengeCode 'emTSxMNx' \
    --goalProgressionId 'Bi1z3kJH' \
    --limit '54' \
    --offset '9' \
    --sortBy 'createdAt:desc' \
    --status 'UNCLAIMED' \
    > test.out 2>&1
eval_tap $? 27 'AdminGetUserRewards' test.out

#- 28 AdminClaimUserRewards
# body param: body
echo '{"rewardIDs": ["mlfEAT3C", "SuYgyITq", "vIhao2iL"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn challenge \
    --op AdminClaimUserRewards \
    --namespace $AB_NAMESPACE \
    --userId 'lua72vbD' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 28 'AdminClaimUserRewards' test.out

#- 29 GetChallenges
$CLI_EXE \
    --sn challenge \
    --op GetChallenges \
    --namespace $AB_NAMESPACE \
    --limit '58' \
    --offset '22' \
    --sortBy 'updatedAt:desc' \
    --status 'RETIRED' \
    > test.out 2>&1
eval_tap $? 29 'GetChallenges' test.out

#- 30 PublicGetScheduledGoals
$CLI_EXE \
    --sn challenge \
    --op PublicGetScheduledGoals \
    --challengeCode 'J24d4Yko' \
    --namespace $AB_NAMESPACE \
    --limit '80' \
    --offset '57' \
    --tags '["mOgxPClx", "QnSdmNi6", "miMynHEK"]' \
    > test.out 2>&1
eval_tap $? 30 'PublicGetScheduledGoals' test.out

#- 31 PublicListSchedulesByGoal
$CLI_EXE \
    --sn challenge \
    --op PublicListSchedulesByGoal \
    --challengeCode 'fMDnljRa' \
    --code 'MtmG90c7' \
    --namespace $AB_NAMESPACE \
    --limit '85' \
    --offset '83' \
    > test.out 2>&1
eval_tap $? 31 'PublicListSchedulesByGoal' test.out

#- 32 PublicListSchedules
$CLI_EXE \
    --sn challenge \
    --op PublicListSchedules \
    --challengeCode '4rmHpYNs' \
    --namespace $AB_NAMESPACE \
    --dateTime '1971-02-12T00:00:00Z' \
    --limit '25' \
    --offset '27' \
    > test.out 2>&1
eval_tap $? 32 'PublicListSchedules' test.out

#- 33 PublicClaimUserRewardsByGoalCode
# body param: body
echo '{"goalCode": "9eRr3tdE"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn challenge \
    --op PublicClaimUserRewardsByGoalCode \
    --challengeCode 'q86bAKB2' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 33 'PublicClaimUserRewardsByGoalCode' test.out

#- 34 EvaluateMyProgress
$CLI_EXE \
    --sn challenge \
    --op EvaluateMyProgress \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 34 'EvaluateMyProgress' test.out

#- 35 PublicGetUserProgression
$CLI_EXE \
    --sn challenge \
    --op PublicGetUserProgression \
    --challengeCode 'WKkwazg8' \
    --namespace $AB_NAMESPACE \
    --dateTime '1977-07-21T00:00:00Z' \
    --goalCode 'Yv1ZtnxG' \
    --limit '69' \
    --offset '96' \
    --tags '["v58Zjf0s", "xu4omIvk", "31OfhoAz"]' \
    > test.out 2>&1
eval_tap $? 35 'PublicGetUserProgression' test.out

#- 36 PublicGetPastUserProgression
$CLI_EXE \
    --sn challenge \
    --op PublicGetPastUserProgression \
    --challengeCode 'ugE7AWtP' \
    --index '79' \
    --namespace $AB_NAMESPACE \
    --goalCode 'SjP1Jlt9' \
    --limit '9' \
    --offset '67' \
    --tags '["bpJvzuoH", "qCdtwz1M", "76oPSjWR"]' \
    > test.out 2>&1
eval_tap $? 36 'PublicGetPastUserProgression' test.out

#- 37 PublicGetUserRewards
$CLI_EXE \
    --sn challenge \
    --op PublicGetUserRewards \
    --namespace $AB_NAMESPACE \
    --challengeCode 'RKUKoaGQ' \
    --goalProgressionId '4UwSUOvu' \
    --limit '11' \
    --offset '69' \
    --sortBy 'createdAt' \
    --status 'CLAIMED' \
    > test.out 2>&1
eval_tap $? 37 'PublicGetUserRewards' test.out

#- 38 PublicClaimUserRewards
# body param: body
echo '{"rewardIDs": ["S6H6NT4O", "0xaIf9oR", "C3cyR5UU"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn challenge \
    --op PublicClaimUserRewards \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 38 'PublicClaimUserRewards' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE