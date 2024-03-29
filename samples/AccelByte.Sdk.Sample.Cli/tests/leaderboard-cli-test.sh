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
    --isDeleted 'true' \
    --limit '84' \
    --offset '41' \
    > test.out 2>&1
eval_tap $? 2 'GetLeaderboardConfigurationsAdminV1' test.out

#- 3 CreateLeaderboardConfigurationAdminV1
# body param: body
echo '{"daily": {"resetTime": "OWxNrhND"}, "descending": false, "iconURL": "gCVYsyY3", "leaderboardCode": "J00Gggc6", "monthly": {"resetDate": 80, "resetTime": "slxB4xZC"}, "name": "6eRSBqrb", "seasonPeriod": 48, "startTime": "UV50hTft", "statCode": "7FcdX2je", "weekly": {"resetDay": 84, "resetTime": "WRUIvxOB"}}' > $TEMP_JSON_INPUT
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
    --slug '2pLydfTv' \
    --leaderboardCodes 'Pq05eXsz' \
    > test.out 2>&1
eval_tap $? 4 'AdminGetArchivedLeaderboardRankingDataV1Handler' test.out

#- 5 CreateArchivedLeaderboardRankingDataV1Handler
# body param: body
echo '{"leaderboardCodes": ["BkpTb80n", "u9WUbLul", "9LL8ynPN"], "limit": 17, "slug": "vsiRvT8i"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn leaderboard \
    --op CreateArchivedLeaderboardRankingDataV1Handler \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 5 'CreateArchivedLeaderboardRankingDataV1Handler' test.out

#- 6 DeleteBulkLeaderboardConfigurationAdminV1
# body param: body
echo '{"leaderboardCodes": ["3IObMwRo", "fjW2mtid", "areMpWDt"]}' > $TEMP_JSON_INPUT
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
    --leaderboardCode 'OV9lxiuD' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 7 'GetLeaderboardConfigurationAdminV1' test.out

#- 8 UpdateLeaderboardConfigurationAdminV1
# body param: body
echo '{"daily": {"resetTime": "bXw4Ns9A"}, "descending": true, "iconURL": "bHKhWwmq", "monthly": {"resetDate": 74, "resetTime": "5dLy5shv"}, "name": "qtsPrOeY", "seasonPeriod": 99, "startTime": "V8sLiwnZ", "statCode": "HWkuxDTb", "weekly": {"resetDay": 39, "resetTime": "neCYFNtK"}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn leaderboard \
    --op UpdateLeaderboardConfigurationAdminV1 \
    --leaderboardCode 'aKD3l683' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 8 'UpdateLeaderboardConfigurationAdminV1' test.out

#- 9 DeleteLeaderboardConfigurationAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op DeleteLeaderboardConfigurationAdminV1 \
    --leaderboardCode '55Y2ftTv' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 9 'DeleteLeaderboardConfigurationAdminV1' test.out

#- 10 GetAllTimeLeaderboardRankingAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op GetAllTimeLeaderboardRankingAdminV1 \
    --leaderboardCode 'AMFMsi5N' \
    --namespace $AB_NAMESPACE \
    --limit '56' \
    --offset '29' \
    > test.out 2>&1
eval_tap $? 10 'GetAllTimeLeaderboardRankingAdminV1' test.out

#- 11 HardDeleteLeaderboardAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op HardDeleteLeaderboardAdminV1 \
    --leaderboardCode 'OzPYMVbZ' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 11 'HardDeleteLeaderboardAdminV1' test.out

#- 12 GetCurrentMonthLeaderboardRankingAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op GetCurrentMonthLeaderboardRankingAdminV1 \
    --leaderboardCode '8udpxJ5R' \
    --namespace $AB_NAMESPACE \
    --limit '25' \
    --offset '57' \
    --previousVersion '7' \
    > test.out 2>&1
eval_tap $? 12 'GetCurrentMonthLeaderboardRankingAdminV1' test.out

#- 13 DeleteUserRankingByLeaderboardCodeAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op DeleteUserRankingByLeaderboardCodeAdminV1 \
    --leaderboardCode 'HxtpHEPQ' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 13 'DeleteUserRankingByLeaderboardCodeAdminV1' test.out

#- 14 GetCurrentSeasonLeaderboardRankingAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op GetCurrentSeasonLeaderboardRankingAdminV1 \
    --leaderboardCode 'YzrAJtbj' \
    --namespace $AB_NAMESPACE \
    --limit '91' \
    --offset '3' \
    --previousVersion '92' \
    > test.out 2>&1
eval_tap $? 14 'GetCurrentSeasonLeaderboardRankingAdminV1' test.out

#- 15 GetTodayLeaderboardRankingAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op GetTodayLeaderboardRankingAdminV1 \
    --leaderboardCode 'EsZprQKx' \
    --namespace $AB_NAMESPACE \
    --limit '94' \
    --offset '15' \
    --previousVersion '87' \
    > test.out 2>&1
eval_tap $? 15 'GetTodayLeaderboardRankingAdminV1' test.out

#- 16 GetUserRankingAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op GetUserRankingAdminV1 \
    --leaderboardCode '5X1Pnxd2' \
    --namespace $AB_NAMESPACE \
    --userId 'wLALtEsm' \
    --previousVersion '73' \
    > test.out 2>&1
eval_tap $? 16 'GetUserRankingAdminV1' test.out

#- 17 UpdateUserPointAdminV1
# body param: body
echo '{"inc": 0.4872262035954321, "latestValue": 0.6744364585073467}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn leaderboard \
    --op UpdateUserPointAdminV1 \
    --leaderboardCode 'lyEf4i00' \
    --namespace $AB_NAMESPACE \
    --userId 'aC9nMvNK' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 17 'UpdateUserPointAdminV1' test.out

#- 18 DeleteUserRankingAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op DeleteUserRankingAdminV1 \
    --leaderboardCode 'ANBSeidi' \
    --namespace $AB_NAMESPACE \
    --userId 'WI0Wpawj' \
    > test.out 2>&1
eval_tap $? 18 'DeleteUserRankingAdminV1' test.out

#- 19 GetCurrentWeekLeaderboardRankingAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op GetCurrentWeekLeaderboardRankingAdminV1 \
    --leaderboardCode 'BGfMX0Rf' \
    --namespace $AB_NAMESPACE \
    --limit '91' \
    --offset '37' \
    --previousVersion '98' \
    > test.out 2>&1
eval_tap $? 19 'GetCurrentWeekLeaderboardRankingAdminV1' test.out

#- 20 DeleteUserRankingsAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op DeleteUserRankingsAdminV1 \
    --namespace $AB_NAMESPACE \
    --userId 'H6mcI94b' \
    --leaderboardCode '["PyM2iJqy", "oV4YxHbe", "zWmK34IS"]' \
    > test.out 2>&1
eval_tap $? 20 'DeleteUserRankingsAdminV1' test.out

#- 21 AdminAnonymizeUserLeaderboardAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op AdminAnonymizeUserLeaderboardAdminV1 \
    --namespace $AB_NAMESPACE \
    --userId '0DhJi4hP' \
    > test.out 2>&1
eval_tap $? 21 'AdminAnonymizeUserLeaderboardAdminV1' test.out

#- 22 GetUserLeaderboardRankingsAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op GetUserLeaderboardRankingsAdminV1 \
    --namespace $AB_NAMESPACE \
    --userId 'kbyttvSE' \
    --limit '26' \
    --offset '92' \
    --previousVersion '46' \
    > test.out 2>&1
eval_tap $? 22 'GetUserLeaderboardRankingsAdminV1' test.out

#- 23 GetLeaderboardConfigurationsPublicV1
$CLI_EXE \
    --sn leaderboard \
    --op GetLeaderboardConfigurationsPublicV1 \
    --namespace $AB_NAMESPACE \
    --isArchived 'false' \
    --isDeleted 'false' \
    --limit '32' \
    --offset '38' \
    > test.out 2>&1
eval_tap $? 23 'GetLeaderboardConfigurationsPublicV1' test.out

#- 24 CreateLeaderboardConfigurationPublicV1
# body param: body
echo '{"daily": {"resetTime": "lxxn2GdK"}, "descending": false, "iconURL": "hrqKrbb2", "leaderboardCode": "EbpYf9Ow", "monthly": {"resetDate": 9, "resetTime": "4TbzEome"}, "name": "pPtMJagG", "seasonPeriod": 100, "startTime": "KMv9K27L", "statCode": "rXj7ssfE", "weekly": {"resetDay": 43, "resetTime": "XnTFFBzj"}}' > $TEMP_JSON_INPUT
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
    --leaderboardCode 'A9C7Fx06' \
    --namespace $AB_NAMESPACE \
    --limit '26' \
    --offset '69' \
    > test.out 2>&1
eval_tap $? 25 'GetAllTimeLeaderboardRankingPublicV1' test.out

#- 26 GetArchivedLeaderboardRankingDataV1Handler
$CLI_EXE \
    --sn leaderboard \
    --op GetArchivedLeaderboardRankingDataV1Handler \
    --leaderboardCode 'wIQMs6Ju' \
    --namespace $AB_NAMESPACE \
    --slug 'zMDat8QC' \
    --leaderboardCodes 'dy3PJzGq' \
    > test.out 2>&1
eval_tap $? 26 'GetArchivedLeaderboardRankingDataV1Handler' test.out

#- 27 GetCurrentMonthLeaderboardRankingPublicV1
$CLI_EXE \
    --sn leaderboard \
    --op GetCurrentMonthLeaderboardRankingPublicV1 \
    --leaderboardCode 'WLpwyRSa' \
    --namespace $AB_NAMESPACE \
    --limit '53' \
    --offset '8' \
    --previousVersion '92' \
    > test.out 2>&1
eval_tap $? 27 'GetCurrentMonthLeaderboardRankingPublicV1' test.out

#- 28 GetCurrentSeasonLeaderboardRankingPublicV1
$CLI_EXE \
    --sn leaderboard \
    --op GetCurrentSeasonLeaderboardRankingPublicV1 \
    --leaderboardCode 'gg7RxD44' \
    --namespace $AB_NAMESPACE \
    --limit '12' \
    --offset '73' \
    --previousVersion '46' \
    > test.out 2>&1
eval_tap $? 28 'GetCurrentSeasonLeaderboardRankingPublicV1' test.out

#- 29 GetTodayLeaderboardRankingPublicV1
$CLI_EXE \
    --sn leaderboard \
    --op GetTodayLeaderboardRankingPublicV1 \
    --leaderboardCode 'puD1NzSK' \
    --namespace $AB_NAMESPACE \
    --limit '50' \
    --offset '7' \
    --previousVersion '75' \
    > test.out 2>&1
eval_tap $? 29 'GetTodayLeaderboardRankingPublicV1' test.out

#- 30 GetUserRankingPublicV1
$CLI_EXE \
    --sn leaderboard \
    --op GetUserRankingPublicV1 \
    --leaderboardCode 'Wj75bqyD' \
    --namespace $AB_NAMESPACE \
    --userId 'QqJN7ax0' \
    --previousVersion '82' \
    > test.out 2>&1
eval_tap $? 30 'GetUserRankingPublicV1' test.out

#- 31 DeleteUserRankingPublicV1
$CLI_EXE \
    --sn leaderboard \
    --op DeleteUserRankingPublicV1 \
    --leaderboardCode 'vaycnUze' \
    --namespace $AB_NAMESPACE \
    --userId 'B9PTcMyL' \
    > test.out 2>&1
eval_tap $? 31 'DeleteUserRankingPublicV1' test.out

#- 32 GetCurrentWeekLeaderboardRankingPublicV1
$CLI_EXE \
    --sn leaderboard \
    --op GetCurrentWeekLeaderboardRankingPublicV1 \
    --leaderboardCode 'NMoAfqEO' \
    --namespace $AB_NAMESPACE \
    --limit '28' \
    --offset '91' \
    --previousVersion '26' \
    > test.out 2>&1
eval_tap $? 32 'GetCurrentWeekLeaderboardRankingPublicV1' test.out

#- 33 GetHiddenUsersV2
$CLI_EXE \
    --sn leaderboard \
    --op GetHiddenUsersV2 \
    --leaderboardCode 'm4Z2Y9Ob' \
    --namespace $AB_NAMESPACE \
    --limit '2' \
    --offset '16' \
    > test.out 2>&1
eval_tap $? 33 'GetHiddenUsersV2' test.out

#- 34 GetUserVisibilityStatusV2
$CLI_EXE \
    --sn leaderboard \
    --op GetUserVisibilityStatusV2 \
    --leaderboardCode 'qyyaCIDA' \
    --namespace $AB_NAMESPACE \
    --userId 'dF9prfpP' \
    > test.out 2>&1
eval_tap $? 34 'GetUserVisibilityStatusV2' test.out

#- 35 SetUserLeaderboardVisibilityStatusV2
# body param: body
echo '{"visibility": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn leaderboard \
    --op SetUserLeaderboardVisibilityStatusV2 \
    --leaderboardCode 'PzToGiNx' \
    --namespace $AB_NAMESPACE \
    --userId 'JtAEJKSt' \
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
    --userId 'CREZfXLM' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 36 'SetUserVisibilityStatusV2' test.out

#- 37 GetLeaderboardConfigurationsPublicV2
$CLI_EXE \
    --sn leaderboard \
    --op GetLeaderboardConfigurationsPublicV2 \
    --namespace $AB_NAMESPACE \
    --limit '50' \
    --offset '75' \
    > test.out 2>&1
eval_tap $? 37 'GetLeaderboardConfigurationsPublicV2' test.out

#- 38 GetAllTimeLeaderboardRankingPublicV2
$CLI_EXE \
    --sn leaderboard \
    --op GetAllTimeLeaderboardRankingPublicV2 \
    --leaderboardCode 'v0jcpPez' \
    --namespace $AB_NAMESPACE \
    --limit '54' \
    --offset '8' \
    > test.out 2>&1
eval_tap $? 38 'GetAllTimeLeaderboardRankingPublicV2' test.out

#- 39 GetLeaderboardConfigurationsAdminV3
$CLI_EXE \
    --sn leaderboard \
    --op GetLeaderboardConfigurationsAdminV3 \
    --namespace $AB_NAMESPACE \
    --isDeleted 'false' \
    --limit '82' \
    --offset '93' \
    > test.out 2>&1
eval_tap $? 39 'GetLeaderboardConfigurationsAdminV3' test.out

#- 40 CreateLeaderboardConfigurationAdminV3
# body param: body
echo '{"allTime": true, "cycleIds": ["LnUwj9XV", "vDKbweIU", "2VWwoPWw"], "descending": false, "description": "297jEXmD", "iconURL": "yyXNk6k3", "leaderboardCode": "T0RWunl6", "name": "zdPP04Zx", "statCode": "jQ885Vos"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn leaderboard \
    --op CreateLeaderboardConfigurationAdminV3 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 40 'CreateLeaderboardConfigurationAdminV3' test.out

#- 41 DeleteBulkLeaderboardConfigurationAdminV3
# body param: body
echo '{"leaderboardCodes": ["ZaCDPuxL", "9C9pau6H", "MRNEhKeG"]}' > $TEMP_JSON_INPUT
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
    --leaderboardCode 'TuvAHZwj' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 42 'GetLeaderboardConfigurationAdminV3' test.out

#- 43 UpdateLeaderboardConfigurationAdminV3
# body param: body
echo '{"allTime": false, "cycleIds": ["iajwnfmM", "42w7RCvR", "inSgZIHj"], "descending": true, "description": "KJ6Q1R9l", "iconURL": "wt2IKHkg", "name": "24TdInI7"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn leaderboard \
    --op UpdateLeaderboardConfigurationAdminV3 \
    --leaderboardCode 't26Wr5V5' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 43 'UpdateLeaderboardConfigurationAdminV3' test.out

#- 44 DeleteLeaderboardConfigurationAdminV3
$CLI_EXE \
    --sn leaderboard \
    --op DeleteLeaderboardConfigurationAdminV3 \
    --leaderboardCode 'H240yzgY' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 44 'DeleteLeaderboardConfigurationAdminV3' test.out

#- 45 GetAllTimeLeaderboardRankingAdminV3
$CLI_EXE \
    --sn leaderboard \
    --op GetAllTimeLeaderboardRankingAdminV3 \
    --leaderboardCode '7q2F3juS' \
    --namespace $AB_NAMESPACE \
    --limit '4' \
    --offset '65' \
    > test.out 2>&1
eval_tap $? 45 'GetAllTimeLeaderboardRankingAdminV3' test.out

#- 46 GetCurrentCycleLeaderboardRankingAdminV3
$CLI_EXE \
    --sn leaderboard \
    --op GetCurrentCycleLeaderboardRankingAdminV3 \
    --cycleId 'FerwGrmD' \
    --leaderboardCode '9h5w3s1D' \
    --namespace $AB_NAMESPACE \
    --limit '45' \
    --offset '23' \
    > test.out 2>&1
eval_tap $? 46 'GetCurrentCycleLeaderboardRankingAdminV3' test.out

#- 47 HardDeleteLeaderboardAdminV3
$CLI_EXE \
    --sn leaderboard \
    --op HardDeleteLeaderboardAdminV3 \
    --leaderboardCode 'mZnG1qvM' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 47 'HardDeleteLeaderboardAdminV3' test.out

#- 48 DeleteUserRankingByLeaderboardCodeAdminV3
$CLI_EXE \
    --sn leaderboard \
    --op DeleteUserRankingByLeaderboardCodeAdminV3 \
    --leaderboardCode 'w4WdH7Mc' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 48 'DeleteUserRankingByLeaderboardCodeAdminV3' test.out

#- 49 GetHiddenUsersV3
$CLI_EXE \
    --sn leaderboard \
    --op GetHiddenUsersV3 \
    --leaderboardCode '2z3ZDvnZ' \
    --namespace $AB_NAMESPACE \
    --limit '92' \
    --offset '8' \
    > test.out 2>&1
eval_tap $? 49 'GetHiddenUsersV3' test.out

#- 50 GetUserRankingAdminV3
$CLI_EXE \
    --sn leaderboard \
    --op GetUserRankingAdminV3 \
    --leaderboardCode 'qjTE7kdv' \
    --namespace $AB_NAMESPACE \
    --userId '21tXKSTK' \
    > test.out 2>&1
eval_tap $? 50 'GetUserRankingAdminV3' test.out

#- 51 DeleteUserRankingAdminV3
$CLI_EXE \
    --sn leaderboard \
    --op DeleteUserRankingAdminV3 \
    --leaderboardCode 'kQOphmS1' \
    --namespace $AB_NAMESPACE \
    --userId 'ThlAx43g' \
    > test.out 2>&1
eval_tap $? 51 'DeleteUserRankingAdminV3' test.out

#- 52 GetUserVisibilityStatusV3
$CLI_EXE \
    --sn leaderboard \
    --op GetUserVisibilityStatusV3 \
    --leaderboardCode 'RkgArLeg' \
    --namespace $AB_NAMESPACE \
    --userId 'zSdwVcys' \
    > test.out 2>&1
eval_tap $? 52 'GetUserVisibilityStatusV3' test.out

#- 53 SetUserLeaderboardVisibilityV3
# body param: body
echo '{"visibility": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn leaderboard \
    --op SetUserLeaderboardVisibilityV3 \
    --leaderboardCode '74TqkqzZ' \
    --namespace $AB_NAMESPACE \
    --userId 'PWgIpAvZ' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 53 'SetUserLeaderboardVisibilityV3' test.out

#- 54 DeleteUserRankingsAdminV3
$CLI_EXE \
    --sn leaderboard \
    --op DeleteUserRankingsAdminV3 \
    --namespace $AB_NAMESPACE \
    --userId 'SHk3FuRg' \
    --leaderboardCode '["cpvMfXgL", "Q6ySZZWd", "jQTs5jIh"]' \
    > test.out 2>&1
eval_tap $? 54 'DeleteUserRankingsAdminV3' test.out

#- 55 GetUserLeaderboardRankingsAdminV3
$CLI_EXE \
    --sn leaderboard \
    --op GetUserLeaderboardRankingsAdminV3 \
    --namespace $AB_NAMESPACE \
    --userId 'Fw25MckO' \
    --limit '91' \
    --offset '22' \
    > test.out 2>&1
eval_tap $? 55 'GetUserLeaderboardRankingsAdminV3' test.out

#- 56 SetUserVisibilityV3
# body param: body
echo '{"visibility": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn leaderboard \
    --op SetUserVisibilityV3 \
    --namespace $AB_NAMESPACE \
    --userId 'xUYiNdcR' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 56 'SetUserVisibilityV3' test.out

#- 57 GetLeaderboardConfigurationsPublicV3
$CLI_EXE \
    --sn leaderboard \
    --op GetLeaderboardConfigurationsPublicV3 \
    --namespace $AB_NAMESPACE \
    --isDeleted 'false' \
    --limit '24' \
    --offset '29' \
    > test.out 2>&1
eval_tap $? 57 'GetLeaderboardConfigurationsPublicV3' test.out

#- 58 GetLeaderboardConfigurationPublicV3
$CLI_EXE \
    --sn leaderboard \
    --op GetLeaderboardConfigurationPublicV3 \
    --leaderboardCode 'YoXYRrHC' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 58 'GetLeaderboardConfigurationPublicV3' test.out

#- 59 GetAllTimeLeaderboardRankingPublicV3
$CLI_EXE \
    --sn leaderboard \
    --op GetAllTimeLeaderboardRankingPublicV3 \
    --leaderboardCode '8POnOjpr' \
    --namespace $AB_NAMESPACE \
    --limit '51' \
    --offset '100' \
    > test.out 2>&1
eval_tap $? 59 'GetAllTimeLeaderboardRankingPublicV3' test.out

#- 60 GetCurrentCycleLeaderboardRankingPublicV3
$CLI_EXE \
    --sn leaderboard \
    --op GetCurrentCycleLeaderboardRankingPublicV3 \
    --cycleId 'pF5nr9xe' \
    --leaderboardCode 'W4XEvDp9' \
    --namespace $AB_NAMESPACE \
    --limit '15' \
    --offset '71' \
    > test.out 2>&1
eval_tap $? 60 'GetCurrentCycleLeaderboardRankingPublicV3' test.out

#- 61 BulkGetUsersRankingPublicV3
# body param: body
echo '{"userIds": ["mZa8bTDr", "FuVwh77w", "E3jBWQXV"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn leaderboard \
    --op BulkGetUsersRankingPublicV3 \
    --leaderboardCode 'W9UejrLi' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 61 'BulkGetUsersRankingPublicV3' test.out

#- 62 GetUserRankingPublicV3
$CLI_EXE \
    --sn leaderboard \
    --op GetUserRankingPublicV3 \
    --leaderboardCode 'eQ26EpGm' \
    --namespace $AB_NAMESPACE \
    --userId 'VceqYt7E' \
    > test.out 2>&1
eval_tap $? 62 'GetUserRankingPublicV3' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE