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
echo "1..64"

#- 1 Login
$CLI_EXE --op login --lt user --user user --pass user > test.out 2>&1
eval_tap $? 1 'Login' test.out

if [ $EXIT_CODE -ne 0 ]; then
  echo "Bail out! Login failed."
  exit $EXIT_CODE
fi

# echo "foo" > "$CLI_TOKEN_FILE"

#- 2 GetLeaderboardConfigurationsAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op GetLeaderboardConfigurationsAdminV1 \
    --namespace $AB_NAMESPACE \
    --isArchived 'false' \
    --isDeleted 'false' \
    --limit '20' \
    --offset '51' \
    > test.out 2>&1
eval_tap $? 2 'GetLeaderboardConfigurationsAdminV1' test.out

#- 3 CreateLeaderboardConfigurationAdminV1
# body param: body
echo '{"daily": {"resetTime": "QawODeYk"}, "descending": true, "iconURL": "9KUF3oyu", "leaderboardCode": "c8IdLmQY", "monthly": {"resetDate": 14, "resetTime": "R3ITdHL7"}, "name": "UHXasl5o", "seasonPeriod": 34, "startTime": "0mn60Ftd", "statCode": "KMVW259E", "weekly": {"resetDay": 6, "resetTime": "tH2tJy3z"}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn leaderboard \
    --op CreateLeaderboardConfigurationAdminV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 3 'CreateLeaderboardConfigurationAdminV1' test.out

#- 4 AdminGetArchivedLeaderboardRankingDataV1Handler
$CLI_EXE \
    --sn leaderboard \
    --op AdminGetArchivedLeaderboardRankingDataV1Handler \
    --namespace $AB_NAMESPACE \
    --slug 'U3nQZ1Eh' \
    --leaderboardCodes 'gfnqbo0u' \
    > test.out 2>&1
eval_tap $? 4 'AdminGetArchivedLeaderboardRankingDataV1Handler' test.out

#- 5 CreateArchivedLeaderboardRankingDataV1Handler
# body param: body
echo '{"leaderboardCodes": ["SK9fnaEq", "ETofSdtG", "M1Punu7C"], "limit": 11, "slug": "GAgbxfMh"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn leaderboard \
    --op CreateArchivedLeaderboardRankingDataV1Handler \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 5 'CreateArchivedLeaderboardRankingDataV1Handler' test.out

#- 6 DeleteBulkLeaderboardConfigurationAdminV1
# body param: body
echo '{"leaderboardCodes": ["6EynCUgo", "rd1GgWRp", "RgNhjLN4"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn leaderboard \
    --op DeleteBulkLeaderboardConfigurationAdminV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 6 'DeleteBulkLeaderboardConfigurationAdminV1' test.out

#- 7 GetLeaderboardConfigurationAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op GetLeaderboardConfigurationAdminV1 \
    --leaderboardCode 'cctgLasJ' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 7 'GetLeaderboardConfigurationAdminV1' test.out

#- 8 UpdateLeaderboardConfigurationAdminV1
# body param: body
echo '{"daily": {"resetTime": "BR6Rq6pS"}, "descending": false, "iconURL": "XCSuLzjA", "monthly": {"resetDate": 52, "resetTime": "zSzwh7Fh"}, "name": "0bBiuwHk", "seasonPeriod": 71, "startTime": "JujcwVBV", "statCode": "twmmbEpx", "weekly": {"resetDay": 19, "resetTime": "juHqybPa"}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn leaderboard \
    --op UpdateLeaderboardConfigurationAdminV1 \
    --leaderboardCode '4ke1bxB6' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 8 'UpdateLeaderboardConfigurationAdminV1' test.out

#- 9 DeleteLeaderboardConfigurationAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op DeleteLeaderboardConfigurationAdminV1 \
    --leaderboardCode 'z8l8J1lH' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 9 'DeleteLeaderboardConfigurationAdminV1' test.out

#- 10 GetAllTimeLeaderboardRankingAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op GetAllTimeLeaderboardRankingAdminV1 \
    --leaderboardCode 'x9EpIH3n' \
    --namespace $AB_NAMESPACE \
    --limit '47' \
    --offset '37' \
    > test.out 2>&1
eval_tap $? 10 'GetAllTimeLeaderboardRankingAdminV1' test.out

#- 11 HardDeleteLeaderboardAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op HardDeleteLeaderboardAdminV1 \
    --leaderboardCode 'j4CHTv1n' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 11 'HardDeleteLeaderboardAdminV1' test.out

#- 12 GetCurrentMonthLeaderboardRankingAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op GetCurrentMonthLeaderboardRankingAdminV1 \
    --leaderboardCode 'omDTmWPm' \
    --namespace $AB_NAMESPACE \
    --limit '60' \
    --offset '16' \
    --previousVersion '74' \
    > test.out 2>&1
eval_tap $? 12 'GetCurrentMonthLeaderboardRankingAdminV1' test.out

#- 13 DeleteUserRankingByLeaderboardCodeAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op DeleteUserRankingByLeaderboardCodeAdminV1 \
    --leaderboardCode 'fijNZ5A6' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 13 'DeleteUserRankingByLeaderboardCodeAdminV1' test.out

#- 14 GetCurrentSeasonLeaderboardRankingAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op GetCurrentSeasonLeaderboardRankingAdminV1 \
    --leaderboardCode 'Ki1W4U43' \
    --namespace $AB_NAMESPACE \
    --limit '4' \
    --offset '37' \
    --previousVersion '39' \
    > test.out 2>&1
eval_tap $? 14 'GetCurrentSeasonLeaderboardRankingAdminV1' test.out

#- 15 GetTodayLeaderboardRankingAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op GetTodayLeaderboardRankingAdminV1 \
    --leaderboardCode 'NFDbASUZ' \
    --namespace $AB_NAMESPACE \
    --limit '59' \
    --offset '19' \
    --previousVersion '42' \
    > test.out 2>&1
eval_tap $? 15 'GetTodayLeaderboardRankingAdminV1' test.out

#- 16 GetUserRankingAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op GetUserRankingAdminV1 \
    --leaderboardCode 'RcFtNCVF' \
    --namespace $AB_NAMESPACE \
    --userId '2Gqsq0FM' \
    --previousVersion '30' \
    > test.out 2>&1
eval_tap $? 16 'GetUserRankingAdminV1' test.out

#- 17 UpdateUserPointAdminV1
# body param: body
echo '{"inc": 0.11882767266147254, "latestValue": 0.600427078529387}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn leaderboard \
    --op UpdateUserPointAdminV1 \
    --leaderboardCode 'QzrOQVK5' \
    --namespace $AB_NAMESPACE \
    --userId 'vY3hUCQb' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 17 'UpdateUserPointAdminV1' test.out

#- 18 DeleteUserRankingAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op DeleteUserRankingAdminV1 \
    --leaderboardCode 'dZub36ZA' \
    --namespace $AB_NAMESPACE \
    --userId 'V7ezzVDL' \
    > test.out 2>&1
eval_tap $? 18 'DeleteUserRankingAdminV1' test.out

#- 19 GetCurrentWeekLeaderboardRankingAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op GetCurrentWeekLeaderboardRankingAdminV1 \
    --leaderboardCode 's98EonNJ' \
    --namespace $AB_NAMESPACE \
    --limit '50' \
    --offset '25' \
    --previousVersion '98' \
    > test.out 2>&1
eval_tap $? 19 'GetCurrentWeekLeaderboardRankingAdminV1' test.out

#- 20 DeleteUserRankingsAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op DeleteUserRankingsAdminV1 \
    --namespace $AB_NAMESPACE \
    --userId 'FTbfyRYK' \
    --leaderboardCode '["s2K9YXqA", "x0Bhdewe", "UAyVkVYL"]' \
    > test.out 2>&1
eval_tap $? 20 'DeleteUserRankingsAdminV1' test.out

#- 21 AdminAnonymizeUserLeaderboardAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op AdminAnonymizeUserLeaderboardAdminV1 \
    --namespace $AB_NAMESPACE \
    --userId 'Z7aW3Fh9' \
    > test.out 2>&1
eval_tap $? 21 'AdminAnonymizeUserLeaderboardAdminV1' test.out

#- 22 GetUserLeaderboardRankingsAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op GetUserLeaderboardRankingsAdminV1 \
    --namespace $AB_NAMESPACE \
    --userId 'nq19pNNT' \
    --limit '25' \
    --offset '82' \
    --previousVersion '91' \
    > test.out 2>&1
eval_tap $? 22 'GetUserLeaderboardRankingsAdminV1' test.out

#- 23 GetLeaderboardConfigurationsPublicV1
$CLI_EXE \
    --sn leaderboard \
    --op GetLeaderboardConfigurationsPublicV1 \
    --namespace $AB_NAMESPACE \
    --isArchived 'true' \
    --isDeleted 'false' \
    --limit '44' \
    --offset '19' \
    > test.out 2>&1
eval_tap $? 23 'GetLeaderboardConfigurationsPublicV1' test.out

#- 24 CreateLeaderboardConfigurationPublicV1
# body param: body
echo '{"daily": {"resetTime": "48dVNU41"}, "descending": true, "iconURL": "3v3dmibx", "leaderboardCode": "l4JHF4hJ", "monthly": {"resetDate": 77, "resetTime": "WMUOkVcl"}, "name": "kbV7lOL1", "seasonPeriod": 97, "startTime": "1ledbs32", "statCode": "zWNsHOAS", "weekly": {"resetDay": 22, "resetTime": "bNEhMFFa"}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn leaderboard \
    --op CreateLeaderboardConfigurationPublicV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 24 'CreateLeaderboardConfigurationPublicV1' test.out

#- 25 GetAllTimeLeaderboardRankingPublicV1
$CLI_EXE \
    --sn leaderboard \
    --op GetAllTimeLeaderboardRankingPublicV1 \
    --leaderboardCode '3BfhbnRS' \
    --namespace $AB_NAMESPACE \
    --limit '73' \
    --offset '95' \
    > test.out 2>&1
eval_tap $? 25 'GetAllTimeLeaderboardRankingPublicV1' test.out

#- 26 GetArchivedLeaderboardRankingDataV1Handler
$CLI_EXE \
    --sn leaderboard \
    --op GetArchivedLeaderboardRankingDataV1Handler \
    --leaderboardCode '4sL4h4bP' \
    --namespace $AB_NAMESPACE \
    --slug 'QJl532h1' \
    --leaderboardCodes 'PsTA55Bg' \
    > test.out 2>&1
eval_tap $? 26 'GetArchivedLeaderboardRankingDataV1Handler' test.out

#- 27 GetCurrentMonthLeaderboardRankingPublicV1
$CLI_EXE \
    --sn leaderboard \
    --op GetCurrentMonthLeaderboardRankingPublicV1 \
    --leaderboardCode 'Ifb7vprX' \
    --namespace $AB_NAMESPACE \
    --limit '28' \
    --offset '14' \
    --previousVersion '9' \
    > test.out 2>&1
eval_tap $? 27 'GetCurrentMonthLeaderboardRankingPublicV1' test.out

#- 28 GetCurrentSeasonLeaderboardRankingPublicV1
$CLI_EXE \
    --sn leaderboard \
    --op GetCurrentSeasonLeaderboardRankingPublicV1 \
    --leaderboardCode 'aWwxIEMK' \
    --namespace $AB_NAMESPACE \
    --limit '70' \
    --offset '17' \
    --previousVersion '32' \
    > test.out 2>&1
eval_tap $? 28 'GetCurrentSeasonLeaderboardRankingPublicV1' test.out

#- 29 GetTodayLeaderboardRankingPublicV1
$CLI_EXE \
    --sn leaderboard \
    --op GetTodayLeaderboardRankingPublicV1 \
    --leaderboardCode 'c34Rf7Oi' \
    --namespace $AB_NAMESPACE \
    --limit '68' \
    --offset '31' \
    --previousVersion '60' \
    > test.out 2>&1
eval_tap $? 29 'GetTodayLeaderboardRankingPublicV1' test.out

#- 30 GetUserRankingPublicV1
$CLI_EXE \
    --sn leaderboard \
    --op GetUserRankingPublicV1 \
    --leaderboardCode 'ZUt9dtBD' \
    --namespace $AB_NAMESPACE \
    --userId 'mF2Y92BD' \
    --previousVersion '68' \
    > test.out 2>&1
eval_tap $? 30 'GetUserRankingPublicV1' test.out

#- 31 DeleteUserRankingPublicV1
$CLI_EXE \
    --sn leaderboard \
    --op DeleteUserRankingPublicV1 \
    --leaderboardCode 'p6eRAZyd' \
    --namespace $AB_NAMESPACE \
    --userId 'is2A0WAR' \
    > test.out 2>&1
eval_tap $? 31 'DeleteUserRankingPublicV1' test.out

#- 32 GetCurrentWeekLeaderboardRankingPublicV1
$CLI_EXE \
    --sn leaderboard \
    --op GetCurrentWeekLeaderboardRankingPublicV1 \
    --leaderboardCode 'QrbwxeYE' \
    --namespace $AB_NAMESPACE \
    --limit '37' \
    --offset '60' \
    --previousVersion '64' \
    > test.out 2>&1
eval_tap $? 32 'GetCurrentWeekLeaderboardRankingPublicV1' test.out

#- 33 GetHiddenUsersV2
$CLI_EXE \
    --sn leaderboard \
    --op GetHiddenUsersV2 \
    --leaderboardCode 'yNIiWP9L' \
    --namespace $AB_NAMESPACE \
    --limit '79' \
    --offset '61' \
    > test.out 2>&1
eval_tap $? 33 'GetHiddenUsersV2' test.out

#- 34 GetUserVisibilityStatusV2
$CLI_EXE \
    --sn leaderboard \
    --op GetUserVisibilityStatusV2 \
    --leaderboardCode '3OSjsVTk' \
    --namespace $AB_NAMESPACE \
    --userId 'NpA8dtTh' \
    > test.out 2>&1
eval_tap $? 34 'GetUserVisibilityStatusV2' test.out

#- 35 SetUserLeaderboardVisibilityStatusV2
# body param: body
echo '{"visibility": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn leaderboard \
    --op SetUserLeaderboardVisibilityStatusV2 \
    --leaderboardCode 'FHSU4i2J' \
    --namespace $AB_NAMESPACE \
    --userId 'pB072jZy' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 35 'SetUserLeaderboardVisibilityStatusV2' test.out

#- 36 SetUserVisibilityStatusV2
# body param: body
echo '{"visibility": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn leaderboard \
    --op SetUserVisibilityStatusV2 \
    --namespace $AB_NAMESPACE \
    --userId 'B39p6ZNG' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 36 'SetUserVisibilityStatusV2' test.out

#- 37 GetLeaderboardConfigurationsPublicV2
$CLI_EXE \
    --sn leaderboard \
    --op GetLeaderboardConfigurationsPublicV2 \
    --namespace $AB_NAMESPACE \
    --limit '12' \
    --offset '1' \
    > test.out 2>&1
eval_tap $? 37 'GetLeaderboardConfigurationsPublicV2' test.out

#- 38 GetAllTimeLeaderboardRankingPublicV2
$CLI_EXE \
    --sn leaderboard \
    --op GetAllTimeLeaderboardRankingPublicV2 \
    --leaderboardCode 'lyWECjoB' \
    --namespace $AB_NAMESPACE \
    --limit '94' \
    --offset '97' \
    > test.out 2>&1
eval_tap $? 38 'GetAllTimeLeaderboardRankingPublicV2' test.out

#- 39 GetLeaderboardConfigurationsAdminV3
$CLI_EXE \
    --sn leaderboard \
    --op GetLeaderboardConfigurationsAdminV3 \
    --namespace $AB_NAMESPACE \
    --isDeleted 'false' \
    --limit '29' \
    --offset '36' \
    > test.out 2>&1
eval_tap $? 39 'GetLeaderboardConfigurationsAdminV3' test.out

#- 40 CreateLeaderboardConfigurationAdminV3
# body param: body
echo '{"allTime": true, "cycleIds": ["vsjcc1ZF", "uzXTQLow", "tCk5cqIF"], "descending": false, "description": "ynncd1Rl", "iconURL": "RuZ2NU33", "leaderboardCode": "K5c0dsbU", "name": "qsF7jcF7", "statCode": "xpvUR3E9"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn leaderboard \
    --op CreateLeaderboardConfigurationAdminV3 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 40 'CreateLeaderboardConfigurationAdminV3' test.out

#- 41 DeleteBulkLeaderboardConfigurationAdminV3
# body param: body
echo '{"leaderboardCodes": ["sDSqrcHd", "zwhqvIMl", "1qe2HUK8"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn leaderboard \
    --op DeleteBulkLeaderboardConfigurationAdminV3 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 41 'DeleteBulkLeaderboardConfigurationAdminV3' test.out

#- 42 GetLeaderboardConfigurationAdminV3
$CLI_EXE \
    --sn leaderboard \
    --op GetLeaderboardConfigurationAdminV3 \
    --leaderboardCode 'QPzspdaZ' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 42 'GetLeaderboardConfigurationAdminV3' test.out

#- 43 UpdateLeaderboardConfigurationAdminV3
# body param: body
echo '{"allTime": false, "cycleIds": ["Rz69nW1e", "ZZjw4fmF", "RutSVx6K"], "descending": true, "description": "ZunBIJEj", "iconURL": "SMVTieHB", "name": "HRMpgH2e"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn leaderboard \
    --op UpdateLeaderboardConfigurationAdminV3 \
    --leaderboardCode 'rpw3xCbC' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 43 'UpdateLeaderboardConfigurationAdminV3' test.out

#- 44 DeleteLeaderboardConfigurationAdminV3
$CLI_EXE \
    --sn leaderboard \
    --op DeleteLeaderboardConfigurationAdminV3 \
    --leaderboardCode 'tDtDxE4W' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 44 'DeleteLeaderboardConfigurationAdminV3' test.out

#- 45 GetAllTimeLeaderboardRankingAdminV3
$CLI_EXE \
    --sn leaderboard \
    --op GetAllTimeLeaderboardRankingAdminV3 \
    --leaderboardCode 'jT1vpFGm' \
    --namespace $AB_NAMESPACE \
    --limit '82' \
    --offset '8' \
    > test.out 2>&1
eval_tap $? 45 'GetAllTimeLeaderboardRankingAdminV3' test.out

#- 46 GetCurrentCycleLeaderboardRankingAdminV3
$CLI_EXE \
    --sn leaderboard \
    --op GetCurrentCycleLeaderboardRankingAdminV3 \
    --cycleId 'iUsxH7I6' \
    --leaderboardCode 'jK4LNKld' \
    --namespace $AB_NAMESPACE \
    --limit '41' \
    --offset '20' \
    > test.out 2>&1
eval_tap $? 46 'GetCurrentCycleLeaderboardRankingAdminV3' test.out

#- 47 DeleteAllUserRankingByCycleIdAdminV3
$CLI_EXE \
    --sn leaderboard \
    --op DeleteAllUserRankingByCycleIdAdminV3 \
    --cycleId 'lIzwZkgu' \
    --leaderboardCode 'XhXqbdgT' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 47 'DeleteAllUserRankingByCycleIdAdminV3' test.out

#- 48 DeleteUserRankingByCycleIdAdminV3
$CLI_EXE \
    --sn leaderboard \
    --op DeleteUserRankingByCycleIdAdminV3 \
    --cycleId 'NXAnz2hE' \
    --leaderboardCode 'ok1VScy8' \
    --namespace $AB_NAMESPACE \
    --userId 'zYMTo1Ic' \
    > test.out 2>&1
eval_tap $? 48 'DeleteUserRankingByCycleIdAdminV3' test.out

#- 49 HardDeleteLeaderboardAdminV3
$CLI_EXE \
    --sn leaderboard \
    --op HardDeleteLeaderboardAdminV3 \
    --leaderboardCode 'hAeei3Kl' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 49 'HardDeleteLeaderboardAdminV3' test.out

#- 50 DeleteUserRankingByLeaderboardCodeAdminV3
$CLI_EXE \
    --sn leaderboard \
    --op DeleteUserRankingByLeaderboardCodeAdminV3 \
    --leaderboardCode 'YnFB24UJ' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 50 'DeleteUserRankingByLeaderboardCodeAdminV3' test.out

#- 51 GetHiddenUsersV3
$CLI_EXE \
    --sn leaderboard \
    --op GetHiddenUsersV3 \
    --leaderboardCode 'jwqVmXUe' \
    --namespace $AB_NAMESPACE \
    --limit '93' \
    --offset '50' \
    > test.out 2>&1
eval_tap $? 51 'GetHiddenUsersV3' test.out

#- 52 GetUserRankingAdminV3
$CLI_EXE \
    --sn leaderboard \
    --op GetUserRankingAdminV3 \
    --leaderboardCode 'DmXePl6L' \
    --namespace $AB_NAMESPACE \
    --userId 'gzHm1MtO' \
    > test.out 2>&1
eval_tap $? 52 'GetUserRankingAdminV3' test.out

#- 53 DeleteUserRankingAdminV3
$CLI_EXE \
    --sn leaderboard \
    --op DeleteUserRankingAdminV3 \
    --leaderboardCode 'UCmbfTAZ' \
    --namespace $AB_NAMESPACE \
    --userId 'E6JKL7qz' \
    > test.out 2>&1
eval_tap $? 53 'DeleteUserRankingAdminV3' test.out

#- 54 GetUserVisibilityStatusV3
$CLI_EXE \
    --sn leaderboard \
    --op GetUserVisibilityStatusV3 \
    --leaderboardCode 'DBFC9L4q' \
    --namespace $AB_NAMESPACE \
    --userId 'u0Q32Ra2' \
    > test.out 2>&1
eval_tap $? 54 'GetUserVisibilityStatusV3' test.out

#- 55 SetUserLeaderboardVisibilityV3
# body param: body
echo '{"visibility": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn leaderboard \
    --op SetUserLeaderboardVisibilityV3 \
    --leaderboardCode 'nerS1Pr4' \
    --namespace $AB_NAMESPACE \
    --userId '0kY3DEV7' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 55 'SetUserLeaderboardVisibilityV3' test.out

#- 56 DeleteUserRankingsAdminV3
$CLI_EXE \
    --sn leaderboard \
    --op DeleteUserRankingsAdminV3 \
    --namespace $AB_NAMESPACE \
    --userId 'QV4iv2lk' \
    --leaderboardCode '["angR3bgJ", "GFvLGVqU", "DmEoDAVg"]' \
    > test.out 2>&1
eval_tap $? 56 'DeleteUserRankingsAdminV3' test.out

#- 57 GetUserLeaderboardRankingsAdminV3
$CLI_EXE \
    --sn leaderboard \
    --op GetUserLeaderboardRankingsAdminV3 \
    --namespace $AB_NAMESPACE \
    --userId 'q6I1JVz2' \
    --limit '57' \
    --offset '42' \
    > test.out 2>&1
eval_tap $? 57 'GetUserLeaderboardRankingsAdminV3' test.out

#- 58 SetUserVisibilityV3
# body param: body
echo '{"visibility": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn leaderboard \
    --op SetUserVisibilityV3 \
    --namespace $AB_NAMESPACE \
    --userId 'hBS2xVih' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 58 'SetUserVisibilityV3' test.out

#- 59 GetLeaderboardConfigurationsPublicV3
$CLI_EXE \
    --sn leaderboard \
    --op GetLeaderboardConfigurationsPublicV3 \
    --namespace $AB_NAMESPACE \
    --isDeleted 'true' \
    --limit '36' \
    --offset '70' \
    > test.out 2>&1
eval_tap $? 59 'GetLeaderboardConfigurationsPublicV3' test.out

#- 60 GetLeaderboardConfigurationPublicV3
$CLI_EXE \
    --sn leaderboard \
    --op GetLeaderboardConfigurationPublicV3 \
    --leaderboardCode 'N5C3G5p8' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 60 'GetLeaderboardConfigurationPublicV3' test.out

#- 61 GetAllTimeLeaderboardRankingPublicV3
$CLI_EXE \
    --sn leaderboard \
    --op GetAllTimeLeaderboardRankingPublicV3 \
    --leaderboardCode 's3GRsleZ' \
    --namespace $AB_NAMESPACE \
    --limit '31' \
    --offset '69' \
    > test.out 2>&1
eval_tap $? 61 'GetAllTimeLeaderboardRankingPublicV3' test.out

#- 62 GetCurrentCycleLeaderboardRankingPublicV3
$CLI_EXE \
    --sn leaderboard \
    --op GetCurrentCycleLeaderboardRankingPublicV3 \
    --cycleId 'BSKw7sDg' \
    --leaderboardCode 'MamIwCfn' \
    --namespace $AB_NAMESPACE \
    --limit '27' \
    --offset '100' \
    > test.out 2>&1
eval_tap $? 62 'GetCurrentCycleLeaderboardRankingPublicV3' test.out

#- 63 BulkGetUsersRankingPublicV3
# body param: body
echo '{"userIds": ["jBHT4p2v", "GFQExCaz", "8FWW3IVf"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn leaderboard \
    --op BulkGetUsersRankingPublicV3 \
    --leaderboardCode '8d61bZDn' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 63 'BulkGetUsersRankingPublicV3' test.out

#- 64 GetUserRankingPublicV3
$CLI_EXE \
    --sn leaderboard \
    --op GetUserRankingPublicV3 \
    --leaderboardCode 'Gl8FgjjZ' \
    --namespace $AB_NAMESPACE \
    --userId '07qOCu78' \
    > test.out 2>&1
eval_tap $? 64 'GetUserRankingPublicV3' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE