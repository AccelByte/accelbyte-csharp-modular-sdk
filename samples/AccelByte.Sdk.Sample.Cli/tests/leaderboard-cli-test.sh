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
echo "1..62"

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
    --isArchived 'true' \
    --isDeleted 'false' \
    --limit '64' \
    --offset '63' \
    > test.out 2>&1
eval_tap $? 2 'GetLeaderboardConfigurationsAdminV1' test.out

#- 3 CreateLeaderboardConfigurationAdminV1
# body param: body
echo '{"daily": {"resetTime": "cgZhhwS0"}, "descending": true, "iconURL": "ozceC72Y", "leaderboardCode": "Bq2SZnJh", "monthly": {"resetDate": 80, "resetTime": "nPchMdyG"}, "name": "qsT0yT3d", "seasonPeriod": 92, "startTime": "Lwtri0HI", "statCode": "kypnU2e1", "weekly": {"resetDay": 33, "resetTime": "jz8zyf5F"}}' > $TEMP_JSON_INPUT
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
    --slug 'ggBG7XKY' \
    --leaderboardCodes '651kt3f0' \
    > test.out 2>&1
eval_tap $? 4 'AdminGetArchivedLeaderboardRankingDataV1Handler' test.out

#- 5 CreateArchivedLeaderboardRankingDataV1Handler
# body param: body
echo '{"leaderboardCodes": ["H3Ifa4BI", "uOekCnHs", "kyakfZHH"], "limit": 100, "slug": "c43Yfezd"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn leaderboard \
    --op CreateArchivedLeaderboardRankingDataV1Handler \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 5 'CreateArchivedLeaderboardRankingDataV1Handler' test.out

#- 6 DeleteBulkLeaderboardConfigurationAdminV1
# body param: body
echo '{"leaderboardCodes": ["5ggJkcZb", "m95tOPnI", "bouuBvRX"]}' > $TEMP_JSON_INPUT
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
    --leaderboardCode 'GJWqim48' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 7 'GetLeaderboardConfigurationAdminV1' test.out

#- 8 UpdateLeaderboardConfigurationAdminV1
# body param: body
echo '{"daily": {"resetTime": "w4XWtZ25"}, "descending": true, "iconURL": "vLVuw61j", "monthly": {"resetDate": 80, "resetTime": "DaOTaPAh"}, "name": "K4omkUcv", "seasonPeriod": 39, "startTime": "uB9HZemO", "statCode": "Ho88YjGg", "weekly": {"resetDay": 85, "resetTime": "URh121KO"}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn leaderboard \
    --op UpdateLeaderboardConfigurationAdminV1 \
    --leaderboardCode 'rpwKD0gq' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 8 'UpdateLeaderboardConfigurationAdminV1' test.out

#- 9 DeleteLeaderboardConfigurationAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op DeleteLeaderboardConfigurationAdminV1 \
    --leaderboardCode '9V8LDwGj' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 9 'DeleteLeaderboardConfigurationAdminV1' test.out

#- 10 GetAllTimeLeaderboardRankingAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op GetAllTimeLeaderboardRankingAdminV1 \
    --leaderboardCode 'Batyed7Y' \
    --namespace $AB_NAMESPACE \
    --limit '25' \
    --offset '44' \
    > test.out 2>&1
eval_tap $? 10 'GetAllTimeLeaderboardRankingAdminV1' test.out

#- 11 HardDeleteLeaderboardAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op HardDeleteLeaderboardAdminV1 \
    --leaderboardCode 'fBY962dG' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 11 'HardDeleteLeaderboardAdminV1' test.out

#- 12 GetCurrentMonthLeaderboardRankingAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op GetCurrentMonthLeaderboardRankingAdminV1 \
    --leaderboardCode 'KzZb8WUC' \
    --namespace $AB_NAMESPACE \
    --limit '61' \
    --offset '16' \
    --previousVersion '53' \
    > test.out 2>&1
eval_tap $? 12 'GetCurrentMonthLeaderboardRankingAdminV1' test.out

#- 13 DeleteUserRankingByLeaderboardCodeAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op DeleteUserRankingByLeaderboardCodeAdminV1 \
    --leaderboardCode 'eeX2OoAJ' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 13 'DeleteUserRankingByLeaderboardCodeAdminV1' test.out

#- 14 GetCurrentSeasonLeaderboardRankingAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op GetCurrentSeasonLeaderboardRankingAdminV1 \
    --leaderboardCode 'bDW0KJBt' \
    --namespace $AB_NAMESPACE \
    --limit '50' \
    --offset '23' \
    --previousVersion '6' \
    > test.out 2>&1
eval_tap $? 14 'GetCurrentSeasonLeaderboardRankingAdminV1' test.out

#- 15 GetTodayLeaderboardRankingAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op GetTodayLeaderboardRankingAdminV1 \
    --leaderboardCode 'qyt3V3kW' \
    --namespace $AB_NAMESPACE \
    --limit '74' \
    --offset '16' \
    --previousVersion '8' \
    > test.out 2>&1
eval_tap $? 15 'GetTodayLeaderboardRankingAdminV1' test.out

#- 16 GetUserRankingAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op GetUserRankingAdminV1 \
    --leaderboardCode 'D2Rt123u' \
    --namespace $AB_NAMESPACE \
    --userId 'q1l7TRME' \
    --previousVersion '4' \
    > test.out 2>&1
eval_tap $? 16 'GetUserRankingAdminV1' test.out

#- 17 UpdateUserPointAdminV1
# body param: body
echo '{"inc": 0.9828195788767445, "latestValue": 0.3234519243247397}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn leaderboard \
    --op UpdateUserPointAdminV1 \
    --leaderboardCode 'kBcQR3Ta' \
    --namespace $AB_NAMESPACE \
    --userId 'IWAvHJM8' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 17 'UpdateUserPointAdminV1' test.out

#- 18 DeleteUserRankingAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op DeleteUserRankingAdminV1 \
    --leaderboardCode 'pdKcUJE9' \
    --namespace $AB_NAMESPACE \
    --userId 'WUGihf0J' \
    > test.out 2>&1
eval_tap $? 18 'DeleteUserRankingAdminV1' test.out

#- 19 GetCurrentWeekLeaderboardRankingAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op GetCurrentWeekLeaderboardRankingAdminV1 \
    --leaderboardCode 'TzxyWWo9' \
    --namespace $AB_NAMESPACE \
    --limit '2' \
    --offset '83' \
    --previousVersion '42' \
    > test.out 2>&1
eval_tap $? 19 'GetCurrentWeekLeaderboardRankingAdminV1' test.out

#- 20 DeleteUserRankingsAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op DeleteUserRankingsAdminV1 \
    --namespace $AB_NAMESPACE \
    --userId 'uQua8qwt' \
    --leaderboardCode '["VHAjXMGa", "ZlDRFjhX", "CrLGOv7A"]' \
    > test.out 2>&1
eval_tap $? 20 'DeleteUserRankingsAdminV1' test.out

#- 21 AdminAnonymizeUserLeaderboardAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op AdminAnonymizeUserLeaderboardAdminV1 \
    --namespace $AB_NAMESPACE \
    --userId '25aIIxu6' \
    > test.out 2>&1
eval_tap $? 21 'AdminAnonymizeUserLeaderboardAdminV1' test.out

#- 22 GetUserLeaderboardRankingsAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op GetUserLeaderboardRankingsAdminV1 \
    --namespace $AB_NAMESPACE \
    --userId '9udyXPi5' \
    --limit '90' \
    --offset '66' \
    --previousVersion '61' \
    > test.out 2>&1
eval_tap $? 22 'GetUserLeaderboardRankingsAdminV1' test.out

#- 23 GetLeaderboardConfigurationsPublicV1
$CLI_EXE \
    --sn leaderboard \
    --op GetLeaderboardConfigurationsPublicV1 \
    --namespace $AB_NAMESPACE \
    --isArchived 'true' \
    --isDeleted 'true' \
    --limit '55' \
    --offset '45' \
    > test.out 2>&1
eval_tap $? 23 'GetLeaderboardConfigurationsPublicV1' test.out

#- 24 CreateLeaderboardConfigurationPublicV1
# body param: body
echo '{"daily": {"resetTime": "1lB2HWQW"}, "descending": true, "iconURL": "74W4ne3K", "leaderboardCode": "S8VBffJT", "monthly": {"resetDate": 78, "resetTime": "FzbupfpU"}, "name": "tYhQghv9", "seasonPeriod": 78, "startTime": "04zvv0WA", "statCode": "m58Qyq8y", "weekly": {"resetDay": 48, "resetTime": "TusfTEHT"}}' > $TEMP_JSON_INPUT
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
    --leaderboardCode 'BYfGPNU2' \
    --namespace $AB_NAMESPACE \
    --limit '32' \
    --offset '92' \
    > test.out 2>&1
eval_tap $? 25 'GetAllTimeLeaderboardRankingPublicV1' test.out

#- 26 GetArchivedLeaderboardRankingDataV1Handler
$CLI_EXE \
    --sn leaderboard \
    --op GetArchivedLeaderboardRankingDataV1Handler \
    --leaderboardCode 'HsntBmkk' \
    --namespace $AB_NAMESPACE \
    --slug '1v4ySYy2' \
    --leaderboardCodes 'yNtEecnf' \
    > test.out 2>&1
eval_tap $? 26 'GetArchivedLeaderboardRankingDataV1Handler' test.out

#- 27 GetCurrentMonthLeaderboardRankingPublicV1
$CLI_EXE \
    --sn leaderboard \
    --op GetCurrentMonthLeaderboardRankingPublicV1 \
    --leaderboardCode 'ibG6G8dC' \
    --namespace $AB_NAMESPACE \
    --limit '10' \
    --offset '57' \
    --previousVersion '85' \
    > test.out 2>&1
eval_tap $? 27 'GetCurrentMonthLeaderboardRankingPublicV1' test.out

#- 28 GetCurrentSeasonLeaderboardRankingPublicV1
$CLI_EXE \
    --sn leaderboard \
    --op GetCurrentSeasonLeaderboardRankingPublicV1 \
    --leaderboardCode 'bCkKLJWh' \
    --namespace $AB_NAMESPACE \
    --limit '73' \
    --offset '98' \
    --previousVersion '15' \
    > test.out 2>&1
eval_tap $? 28 'GetCurrentSeasonLeaderboardRankingPublicV1' test.out

#- 29 GetTodayLeaderboardRankingPublicV1
$CLI_EXE \
    --sn leaderboard \
    --op GetTodayLeaderboardRankingPublicV1 \
    --leaderboardCode 'wBwyLR0B' \
    --namespace $AB_NAMESPACE \
    --limit '61' \
    --offset '50' \
    --previousVersion '5' \
    > test.out 2>&1
eval_tap $? 29 'GetTodayLeaderboardRankingPublicV1' test.out

#- 30 GetUserRankingPublicV1
$CLI_EXE \
    --sn leaderboard \
    --op GetUserRankingPublicV1 \
    --leaderboardCode 'BHB3Cp7I' \
    --namespace $AB_NAMESPACE \
    --userId '6THJimLC' \
    --previousVersion '57' \
    > test.out 2>&1
eval_tap $? 30 'GetUserRankingPublicV1' test.out

#- 31 DeleteUserRankingPublicV1
$CLI_EXE \
    --sn leaderboard \
    --op DeleteUserRankingPublicV1 \
    --leaderboardCode 'mqGt8ZM6' \
    --namespace $AB_NAMESPACE \
    --userId 'pHvCdLne' \
    > test.out 2>&1
eval_tap $? 31 'DeleteUserRankingPublicV1' test.out

#- 32 GetCurrentWeekLeaderboardRankingPublicV1
$CLI_EXE \
    --sn leaderboard \
    --op GetCurrentWeekLeaderboardRankingPublicV1 \
    --leaderboardCode 'pzWKnTlL' \
    --namespace $AB_NAMESPACE \
    --limit '64' \
    --offset '49' \
    --previousVersion '19' \
    > test.out 2>&1
eval_tap $? 32 'GetCurrentWeekLeaderboardRankingPublicV1' test.out

#- 33 GetHiddenUsersV2
$CLI_EXE \
    --sn leaderboard \
    --op GetHiddenUsersV2 \
    --leaderboardCode 'J5PCNxp9' \
    --namespace $AB_NAMESPACE \
    --limit '30' \
    --offset '37' \
    > test.out 2>&1
eval_tap $? 33 'GetHiddenUsersV2' test.out

#- 34 GetUserVisibilityStatusV2
$CLI_EXE \
    --sn leaderboard \
    --op GetUserVisibilityStatusV2 \
    --leaderboardCode 'hC1vgxcV' \
    --namespace $AB_NAMESPACE \
    --userId 'NvTpNRPm' \
    > test.out 2>&1
eval_tap $? 34 'GetUserVisibilityStatusV2' test.out

#- 35 SetUserLeaderboardVisibilityStatusV2
# body param: body
echo '{"visibility": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn leaderboard \
    --op SetUserLeaderboardVisibilityStatusV2 \
    --leaderboardCode '5UTglPwO' \
    --namespace $AB_NAMESPACE \
    --userId 'NXCZKvoV' \
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
    --userId 'Tjzb7UOL' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 36 'SetUserVisibilityStatusV2' test.out

#- 37 GetLeaderboardConfigurationsPublicV2
$CLI_EXE \
    --sn leaderboard \
    --op GetLeaderboardConfigurationsPublicV2 \
    --namespace $AB_NAMESPACE \
    --limit '15' \
    --offset '13' \
    > test.out 2>&1
eval_tap $? 37 'GetLeaderboardConfigurationsPublicV2' test.out

#- 38 GetAllTimeLeaderboardRankingPublicV2
$CLI_EXE \
    --sn leaderboard \
    --op GetAllTimeLeaderboardRankingPublicV2 \
    --leaderboardCode 'TSsdFdWK' \
    --namespace $AB_NAMESPACE \
    --limit '25' \
    --offset '76' \
    > test.out 2>&1
eval_tap $? 38 'GetAllTimeLeaderboardRankingPublicV2' test.out

#- 39 GetLeaderboardConfigurationsAdminV3
$CLI_EXE \
    --sn leaderboard \
    --op GetLeaderboardConfigurationsAdminV3 \
    --namespace $AB_NAMESPACE \
    --isDeleted 'false' \
    --limit '78' \
    --offset '48' \
    > test.out 2>&1
eval_tap $? 39 'GetLeaderboardConfigurationsAdminV3' test.out

#- 40 CreateLeaderboardConfigurationAdminV3
# body param: body
echo '{"allTime": false, "cycleIds": ["mevtmrNE", "zVQCEMws", "kJXqSzuS"], "descending": false, "description": "4jQXrVNl", "iconURL": "L3slee3W", "leaderboardCode": "TzGJ7WZh", "name": "XGGJQiBr", "statCode": "AzKCeQfc"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn leaderboard \
    --op CreateLeaderboardConfigurationAdminV3 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 40 'CreateLeaderboardConfigurationAdminV3' test.out

#- 41 DeleteBulkLeaderboardConfigurationAdminV3
# body param: body
echo '{"leaderboardCodes": ["6ZMSX5cU", "tBQaUgT3", "izeIvXrq"]}' > $TEMP_JSON_INPUT
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
    --leaderboardCode 'SkwqDCl7' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 42 'GetLeaderboardConfigurationAdminV3' test.out

#- 43 UpdateLeaderboardConfigurationAdminV3
# body param: body
echo '{"allTime": false, "cycleIds": ["rVpleTGS", "zrzNnvyY", "RsM3vZbs"], "descending": true, "description": "9LdbPahD", "iconURL": "65ysNct8", "name": "mujwjwIf"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn leaderboard \
    --op UpdateLeaderboardConfigurationAdminV3 \
    --leaderboardCode 'vH2nJ3P0' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 43 'UpdateLeaderboardConfigurationAdminV3' test.out

#- 44 DeleteLeaderboardConfigurationAdminV3
$CLI_EXE \
    --sn leaderboard \
    --op DeleteLeaderboardConfigurationAdminV3 \
    --leaderboardCode 'ulPYP2zl' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 44 'DeleteLeaderboardConfigurationAdminV3' test.out

#- 45 GetAllTimeLeaderboardRankingAdminV3
$CLI_EXE \
    --sn leaderboard \
    --op GetAllTimeLeaderboardRankingAdminV3 \
    --leaderboardCode 'lw87uvzT' \
    --namespace $AB_NAMESPACE \
    --limit '66' \
    --offset '79' \
    > test.out 2>&1
eval_tap $? 45 'GetAllTimeLeaderboardRankingAdminV3' test.out

#- 46 GetCurrentCycleLeaderboardRankingAdminV3
$CLI_EXE \
    --sn leaderboard \
    --op GetCurrentCycleLeaderboardRankingAdminV3 \
    --cycleId 'cAmTS8do' \
    --leaderboardCode '6TYZwr0S' \
    --namespace $AB_NAMESPACE \
    --limit '47' \
    --offset '25' \
    > test.out 2>&1
eval_tap $? 46 'GetCurrentCycleLeaderboardRankingAdminV3' test.out

#- 47 HardDeleteLeaderboardAdminV3
$CLI_EXE \
    --sn leaderboard \
    --op HardDeleteLeaderboardAdminV3 \
    --leaderboardCode 'T6oHu8MG' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 47 'HardDeleteLeaderboardAdminV3' test.out

#- 48 DeleteUserRankingByLeaderboardCodeAdminV3
$CLI_EXE \
    --sn leaderboard \
    --op DeleteUserRankingByLeaderboardCodeAdminV3 \
    --leaderboardCode 'gmqULKYF' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 48 'DeleteUserRankingByLeaderboardCodeAdminV3' test.out

#- 49 GetHiddenUsersV3
$CLI_EXE \
    --sn leaderboard \
    --op GetHiddenUsersV3 \
    --leaderboardCode 'uA95yNI2' \
    --namespace $AB_NAMESPACE \
    --limit '97' \
    --offset '1' \
    > test.out 2>&1
eval_tap $? 49 'GetHiddenUsersV3' test.out

#- 50 GetUserRankingAdminV3
$CLI_EXE \
    --sn leaderboard \
    --op GetUserRankingAdminV3 \
    --leaderboardCode 'w9m7rkRJ' \
    --namespace $AB_NAMESPACE \
    --userId 'syrDJbGq' \
    > test.out 2>&1
eval_tap $? 50 'GetUserRankingAdminV3' test.out

#- 51 DeleteUserRankingAdminV3
$CLI_EXE \
    --sn leaderboard \
    --op DeleteUserRankingAdminV3 \
    --leaderboardCode 'Kxj24iqG' \
    --namespace $AB_NAMESPACE \
    --userId 'dDsURmGO' \
    > test.out 2>&1
eval_tap $? 51 'DeleteUserRankingAdminV3' test.out

#- 52 GetUserVisibilityStatusV3
$CLI_EXE \
    --sn leaderboard \
    --op GetUserVisibilityStatusV3 \
    --leaderboardCode 'agJpQ9Et' \
    --namespace $AB_NAMESPACE \
    --userId 'wfQl07p1' \
    > test.out 2>&1
eval_tap $? 52 'GetUserVisibilityStatusV3' test.out

#- 53 SetUserLeaderboardVisibilityV3
# body param: body
echo '{"visibility": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn leaderboard \
    --op SetUserLeaderboardVisibilityV3 \
    --leaderboardCode 'XREqXKen' \
    --namespace $AB_NAMESPACE \
    --userId 'N5kUfGDf' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 53 'SetUserLeaderboardVisibilityV3' test.out

#- 54 DeleteUserRankingsAdminV3
$CLI_EXE \
    --sn leaderboard \
    --op DeleteUserRankingsAdminV3 \
    --namespace $AB_NAMESPACE \
    --userId 'GY3P600b' \
    --leaderboardCode '["ooSgeGvt", "DqVsk46n", "RrvVjDEs"]' \
    > test.out 2>&1
eval_tap $? 54 'DeleteUserRankingsAdminV3' test.out

#- 55 GetUserLeaderboardRankingsAdminV3
$CLI_EXE \
    --sn leaderboard \
    --op GetUserLeaderboardRankingsAdminV3 \
    --namespace $AB_NAMESPACE \
    --userId '6eOvEB1S' \
    --limit '57' \
    --offset '2' \
    > test.out 2>&1
eval_tap $? 55 'GetUserLeaderboardRankingsAdminV3' test.out

#- 56 SetUserVisibilityV3
# body param: body
echo '{"visibility": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn leaderboard \
    --op SetUserVisibilityV3 \
    --namespace $AB_NAMESPACE \
    --userId 'lT3jC3fO' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 56 'SetUserVisibilityV3' test.out

#- 57 GetLeaderboardConfigurationsPublicV3
$CLI_EXE \
    --sn leaderboard \
    --op GetLeaderboardConfigurationsPublicV3 \
    --namespace $AB_NAMESPACE \
    --isDeleted 'true' \
    --limit '27' \
    --offset '78' \
    > test.out 2>&1
eval_tap $? 57 'GetLeaderboardConfigurationsPublicV3' test.out

#- 58 GetLeaderboardConfigurationPublicV3
$CLI_EXE \
    --sn leaderboard \
    --op GetLeaderboardConfigurationPublicV3 \
    --leaderboardCode 'dT2B62Dw' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 58 'GetLeaderboardConfigurationPublicV3' test.out

#- 59 GetAllTimeLeaderboardRankingPublicV3
$CLI_EXE \
    --sn leaderboard \
    --op GetAllTimeLeaderboardRankingPublicV3 \
    --leaderboardCode 'txxS3Rk4' \
    --namespace $AB_NAMESPACE \
    --limit '68' \
    --offset '71' \
    > test.out 2>&1
eval_tap $? 59 'GetAllTimeLeaderboardRankingPublicV3' test.out

#- 60 GetCurrentCycleLeaderboardRankingPublicV3
$CLI_EXE \
    --sn leaderboard \
    --op GetCurrentCycleLeaderboardRankingPublicV3 \
    --cycleId 'cJsULLI5' \
    --leaderboardCode 'cuMl5qmo' \
    --namespace $AB_NAMESPACE \
    --limit '97' \
    --offset '39' \
    > test.out 2>&1
eval_tap $? 60 'GetCurrentCycleLeaderboardRankingPublicV3' test.out

#- 61 BulkGetUsersRankingPublicV3
# body param: body
echo '{"userIds": ["7DC1uv9b", "C1tlFMqd", "vJ2gth4C"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn leaderboard \
    --op BulkGetUsersRankingPublicV3 \
    --leaderboardCode 'fe6SqVne' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 61 'BulkGetUsersRankingPublicV3' test.out

#- 62 GetUserRankingPublicV3
$CLI_EXE \
    --sn leaderboard \
    --op GetUserRankingPublicV3 \
    --leaderboardCode '7obD3Cqh' \
    --namespace $AB_NAMESPACE \
    --userId 'dUSchbXZ' \
    > test.out 2>&1
eval_tap $? 62 'GetUserRankingPublicV3' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE