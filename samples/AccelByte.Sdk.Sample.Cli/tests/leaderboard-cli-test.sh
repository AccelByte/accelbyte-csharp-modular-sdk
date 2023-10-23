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
    --isArchived 'false' \
    --isDeleted 'true' \
    --limit '63' \
    --offset '11' \
    > test.out 2>&1
eval_tap $? 2 'GetLeaderboardConfigurationsAdminV1' test.out

#- 3 CreateLeaderboardConfigurationAdminV1
# body param: body
echo '{"daily": {"resetTime": "0SDmvBFx"}, "descending": true, "iconURL": "810zrDqM", "leaderboardCode": "YVrwsFYQ", "monthly": {"resetDate": 54, "resetTime": "JzRJaOlL"}, "name": "uMEOM6jk", "seasonPeriod": 46, "startTime": "L2FKIDgt", "statCode": "fI9ny4C2", "weekly": {"resetDay": 7, "resetTime": "tm98Gvvq"}}' > $TEMP_JSON_INPUT
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
    --slug 'diREmUSt' \
    --leaderboardCodes 'g7Mk11vr' \
    > test.out 2>&1
eval_tap $? 4 'AdminGetArchivedLeaderboardRankingDataV1Handler' test.out

#- 5 CreateArchivedLeaderboardRankingDataV1Handler
# body param: body
echo '{"leaderboardCodes": ["zvGj5TM0", "B0mbMO1l", "KlkKLDnc"], "limit": 82, "slug": "6mci12gq"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn leaderboard \
    --op CreateArchivedLeaderboardRankingDataV1Handler \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 5 'CreateArchivedLeaderboardRankingDataV1Handler' test.out

#- 6 DeleteBulkLeaderboardConfigurationAdminV1
# body param: body
echo '{"leaderboardCodes": ["ogX8JJaU", "P7LihHf9", "ETp20jY7"]}' > $TEMP_JSON_INPUT
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
    --leaderboardCode 'gcFDVVe6' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 7 'GetLeaderboardConfigurationAdminV1' test.out

#- 8 UpdateLeaderboardConfigurationAdminV1
# body param: body
echo '{"daily": {"resetTime": "8wgEQPpb"}, "descending": true, "iconURL": "9CLHtINL", "monthly": {"resetDate": 57, "resetTime": "yEp3iqKY"}, "name": "Y15ioGpI", "seasonPeriod": 57, "startTime": "hW4Hgy9R", "statCode": "KRzMhw5J", "weekly": {"resetDay": 39, "resetTime": "MBGAofUi"}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn leaderboard \
    --op UpdateLeaderboardConfigurationAdminV1 \
    --leaderboardCode 'Mv8j4qqP' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 8 'UpdateLeaderboardConfigurationAdminV1' test.out

#- 9 DeleteLeaderboardConfigurationAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op DeleteLeaderboardConfigurationAdminV1 \
    --leaderboardCode 'uJupG5IR' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 9 'DeleteLeaderboardConfigurationAdminV1' test.out

#- 10 GetAllTimeLeaderboardRankingAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op GetAllTimeLeaderboardRankingAdminV1 \
    --leaderboardCode 'W2wwcHZL' \
    --namespace $AB_NAMESPACE \
    --limit '26' \
    --offset '94' \
    > test.out 2>&1
eval_tap $? 10 'GetAllTimeLeaderboardRankingAdminV1' test.out

#- 11 HardDeleteLeaderboardAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op HardDeleteLeaderboardAdminV1 \
    --leaderboardCode '8mvqSEhp' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 11 'HardDeleteLeaderboardAdminV1' test.out

#- 12 GetCurrentMonthLeaderboardRankingAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op GetCurrentMonthLeaderboardRankingAdminV1 \
    --leaderboardCode 'I19Tc1ZS' \
    --namespace $AB_NAMESPACE \
    --limit '33' \
    --offset '48' \
    --previousVersion '42' \
    > test.out 2>&1
eval_tap $? 12 'GetCurrentMonthLeaderboardRankingAdminV1' test.out

#- 13 DeleteUserRankingByLeaderboardCodeAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op DeleteUserRankingByLeaderboardCodeAdminV1 \
    --leaderboardCode '8IbEB5Z6' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 13 'DeleteUserRankingByLeaderboardCodeAdminV1' test.out

#- 14 GetCurrentSeasonLeaderboardRankingAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op GetCurrentSeasonLeaderboardRankingAdminV1 \
    --leaderboardCode 'YzRAyVNa' \
    --namespace $AB_NAMESPACE \
    --limit '96' \
    --offset '65' \
    --previousVersion '95' \
    > test.out 2>&1
eval_tap $? 14 'GetCurrentSeasonLeaderboardRankingAdminV1' test.out

#- 15 GetTodayLeaderboardRankingAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op GetTodayLeaderboardRankingAdminV1 \
    --leaderboardCode 'E1Pbl11O' \
    --namespace $AB_NAMESPACE \
    --limit '19' \
    --offset '13' \
    --previousVersion '76' \
    > test.out 2>&1
eval_tap $? 15 'GetTodayLeaderboardRankingAdminV1' test.out

#- 16 GetUserRankingAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op GetUserRankingAdminV1 \
    --leaderboardCode 'F5sjKU6N' \
    --namespace $AB_NAMESPACE \
    --userId 'rJ1K8LbW' \
    --previousVersion '25' \
    > test.out 2>&1
eval_tap $? 16 'GetUserRankingAdminV1' test.out

#- 17 UpdateUserPointAdminV1
# body param: body
echo '{"inc": 0.1866149263345841, "latestValue": 0.9337823310634673}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn leaderboard \
    --op UpdateUserPointAdminV1 \
    --leaderboardCode 'O6Zy518L' \
    --namespace $AB_NAMESPACE \
    --userId 'djkDIsut' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 17 'UpdateUserPointAdminV1' test.out

#- 18 DeleteUserRankingAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op DeleteUserRankingAdminV1 \
    --leaderboardCode 'ZSKQOpVt' \
    --namespace $AB_NAMESPACE \
    --userId 'B5QH8ThY' \
    > test.out 2>&1
eval_tap $? 18 'DeleteUserRankingAdminV1' test.out

#- 19 GetCurrentWeekLeaderboardRankingAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op GetCurrentWeekLeaderboardRankingAdminV1 \
    --leaderboardCode 'HZKzfMVS' \
    --namespace $AB_NAMESPACE \
    --limit '13' \
    --offset '97' \
    --previousVersion '10' \
    > test.out 2>&1
eval_tap $? 19 'GetCurrentWeekLeaderboardRankingAdminV1' test.out

#- 20 DeleteUserRankingsAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op DeleteUserRankingsAdminV1 \
    --namespace $AB_NAMESPACE \
    --userId 'duM9dSZh' \
    --leaderboardCode '["cZhhqH6P", "JCBmb15X", "qJPtrYME"]' \
    > test.out 2>&1
eval_tap $? 20 'DeleteUserRankingsAdminV1' test.out

#- 21 AdminAnonymizeUserLeaderboardAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op AdminAnonymizeUserLeaderboardAdminV1 \
    --namespace $AB_NAMESPACE \
    --userId '63h5MMdo' \
    > test.out 2>&1
eval_tap $? 21 'AdminAnonymizeUserLeaderboardAdminV1' test.out

#- 22 GetUserLeaderboardRankingsAdminV1
$CLI_EXE \
    --sn leaderboard \
    --op GetUserLeaderboardRankingsAdminV1 \
    --namespace $AB_NAMESPACE \
    --userId 'ZagbVdS0' \
    --limit '80' \
    --offset '33' \
    --previousVersion '40' \
    > test.out 2>&1
eval_tap $? 22 'GetUserLeaderboardRankingsAdminV1' test.out

#- 23 GetLeaderboardConfigurationsPublicV1
$CLI_EXE \
    --sn leaderboard \
    --op GetLeaderboardConfigurationsPublicV1 \
    --namespace $AB_NAMESPACE \
    --isArchived 'false' \
    --isDeleted 'true' \
    --limit '61' \
    --offset '32' \
    > test.out 2>&1
eval_tap $? 23 'GetLeaderboardConfigurationsPublicV1' test.out

#- 24 CreateLeaderboardConfigurationPublicV1
# body param: body
echo '{"daily": {"resetTime": "WqlE1QcM"}, "descending": true, "iconURL": "n0EFCtuh", "leaderboardCode": "cGX08ii4", "monthly": {"resetDate": 37, "resetTime": "S6hDEfRE"}, "name": "dCfizZor", "seasonPeriod": 0, "startTime": "IhINn2Qy", "statCode": "nNiitK5l", "weekly": {"resetDay": 5, "resetTime": "IZm5A2CR"}}' > $TEMP_JSON_INPUT
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
    --leaderboardCode 'mjFBNiUL' \
    --namespace $AB_NAMESPACE \
    --limit '78' \
    --offset '53' \
    > test.out 2>&1
eval_tap $? 25 'GetAllTimeLeaderboardRankingPublicV1' test.out

#- 26 GetArchivedLeaderboardRankingDataV1Handler
$CLI_EXE \
    --sn leaderboard \
    --op GetArchivedLeaderboardRankingDataV1Handler \
    --leaderboardCode 'figr8I1O' \
    --namespace $AB_NAMESPACE \
    --slug 'IHxGg4Zc' \
    --leaderboardCodes 'stwjfxbU' \
    > test.out 2>&1
eval_tap $? 26 'GetArchivedLeaderboardRankingDataV1Handler' test.out

#- 27 GetCurrentMonthLeaderboardRankingPublicV1
$CLI_EXE \
    --sn leaderboard \
    --op GetCurrentMonthLeaderboardRankingPublicV1 \
    --leaderboardCode 'DggU43Na' \
    --namespace $AB_NAMESPACE \
    --limit '43' \
    --offset '26' \
    --previousVersion '98' \
    > test.out 2>&1
eval_tap $? 27 'GetCurrentMonthLeaderboardRankingPublicV1' test.out

#- 28 GetCurrentSeasonLeaderboardRankingPublicV1
$CLI_EXE \
    --sn leaderboard \
    --op GetCurrentSeasonLeaderboardRankingPublicV1 \
    --leaderboardCode 'gSC6Pj9r' \
    --namespace $AB_NAMESPACE \
    --limit '87' \
    --offset '61' \
    --previousVersion '90' \
    > test.out 2>&1
eval_tap $? 28 'GetCurrentSeasonLeaderboardRankingPublicV1' test.out

#- 29 GetTodayLeaderboardRankingPublicV1
$CLI_EXE \
    --sn leaderboard \
    --op GetTodayLeaderboardRankingPublicV1 \
    --leaderboardCode 'JtSrWb0M' \
    --namespace $AB_NAMESPACE \
    --limit '38' \
    --offset '52' \
    --previousVersion '15' \
    > test.out 2>&1
eval_tap $? 29 'GetTodayLeaderboardRankingPublicV1' test.out

#- 30 GetUserRankingPublicV1
$CLI_EXE \
    --sn leaderboard \
    --op GetUserRankingPublicV1 \
    --leaderboardCode 'geFA0eqE' \
    --namespace $AB_NAMESPACE \
    --userId 'IjuIcGfv' \
    --previousVersion '33' \
    > test.out 2>&1
eval_tap $? 30 'GetUserRankingPublicV1' test.out

#- 31 DeleteUserRankingPublicV1
$CLI_EXE \
    --sn leaderboard \
    --op DeleteUserRankingPublicV1 \
    --leaderboardCode 'zitQc4hN' \
    --namespace $AB_NAMESPACE \
    --userId '5JQOK957' \
    > test.out 2>&1
eval_tap $? 31 'DeleteUserRankingPublicV1' test.out

#- 32 GetCurrentWeekLeaderboardRankingPublicV1
$CLI_EXE \
    --sn leaderboard \
    --op GetCurrentWeekLeaderboardRankingPublicV1 \
    --leaderboardCode 'EiGK2K6a' \
    --namespace $AB_NAMESPACE \
    --limit '46' \
    --offset '67' \
    --previousVersion '78' \
    > test.out 2>&1
eval_tap $? 32 'GetCurrentWeekLeaderboardRankingPublicV1' test.out

#- 33 GetHiddenUsersV2
$CLI_EXE \
    --sn leaderboard \
    --op GetHiddenUsersV2 \
    --leaderboardCode 'vzKTdMZa' \
    --namespace $AB_NAMESPACE \
    --limit '53' \
    --offset '16' \
    > test.out 2>&1
eval_tap $? 33 'GetHiddenUsersV2' test.out

#- 34 GetUserVisibilityStatusV2
$CLI_EXE \
    --sn leaderboard \
    --op GetUserVisibilityStatusV2 \
    --leaderboardCode 'sRC5CKSX' \
    --namespace $AB_NAMESPACE \
    --userId 'kyVmpioY' \
    > test.out 2>&1
eval_tap $? 34 'GetUserVisibilityStatusV2' test.out

#- 35 SetUserLeaderboardVisibilityStatusV2
# body param: body
echo '{"visibility": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn leaderboard \
    --op SetUserLeaderboardVisibilityStatusV2 \
    --leaderboardCode 'ekh1Am5G' \
    --namespace $AB_NAMESPACE \
    --userId 'ShY5cdM7' \
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
    --userId 'PxJKv7bz' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 36 'SetUserVisibilityStatusV2' test.out

#- 37 GetLeaderboardConfigurationsPublicV2
$CLI_EXE \
    --sn leaderboard \
    --op GetLeaderboardConfigurationsPublicV2 \
    --namespace $AB_NAMESPACE \
    --limit '82' \
    --offset '70' \
    > test.out 2>&1
eval_tap $? 37 'GetLeaderboardConfigurationsPublicV2' test.out

#- 38 GetAllTimeLeaderboardRankingPublicV2
$CLI_EXE \
    --sn leaderboard \
    --op GetAllTimeLeaderboardRankingPublicV2 \
    --leaderboardCode 'U5SulKOa' \
    --namespace $AB_NAMESPACE \
    --limit '95' \
    --offset '64' \
    > test.out 2>&1
eval_tap $? 38 'GetAllTimeLeaderboardRankingPublicV2' test.out

#- 39 GetLeaderboardConfigurationsAdminV3
$CLI_EXE \
    --sn leaderboard \
    --op GetLeaderboardConfigurationsAdminV3 \
    --namespace $AB_NAMESPACE \
    --isDeleted 'true' \
    --limit '43' \
    --offset '85' \
    > test.out 2>&1
eval_tap $? 39 'GetLeaderboardConfigurationsAdminV3' test.out

#- 40 CreateLeaderboardConfigurationAdminV3
# body param: body
echo '{"allTime": false, "cycleIds": ["BtFbPnsH", "3H0XOuiI", "sAZuxZDc"], "descending": true, "description": "mbultf6C", "iconURL": "XdxmRwXA", "leaderboardCode": "oILDOjW0", "name": "t4puHdXs", "statCode": "DhYT4b1M"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn leaderboard \
    --op CreateLeaderboardConfigurationAdminV3 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 40 'CreateLeaderboardConfigurationAdminV3' test.out

#- 41 DeleteBulkLeaderboardConfigurationAdminV3
# body param: body
echo '{"leaderboardCodes": ["RQEIvAin", "ayPzNLnK", "3bQK0UvO"]}' > $TEMP_JSON_INPUT
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
    --leaderboardCode 'e7QvnIJO' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 42 'GetLeaderboardConfigurationAdminV3' test.out

#- 43 UpdateLeaderboardConfigurationAdminV3
# body param: body
echo '{"allTime": false, "cycleIds": ["OPK7emtF", "ITnwS0h7", "Dr5uQ9FU"], "descending": false, "description": "ye1DYUqA", "iconURL": "gnXKMLGp", "name": "Eih3xM40"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn leaderboard \
    --op UpdateLeaderboardConfigurationAdminV3 \
    --leaderboardCode 'SOXe9YYo' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 43 'UpdateLeaderboardConfigurationAdminV3' test.out

#- 44 DeleteLeaderboardConfigurationAdminV3
$CLI_EXE \
    --sn leaderboard \
    --op DeleteLeaderboardConfigurationAdminV3 \
    --leaderboardCode 'EM4H45GF' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 44 'DeleteLeaderboardConfigurationAdminV3' test.out

#- 45 GetAllTimeLeaderboardRankingAdminV3
$CLI_EXE \
    --sn leaderboard \
    --op GetAllTimeLeaderboardRankingAdminV3 \
    --leaderboardCode 'B7OPBFHE' \
    --namespace $AB_NAMESPACE \
    --limit '71' \
    --offset '5' \
    > test.out 2>&1
eval_tap $? 45 'GetAllTimeLeaderboardRankingAdminV3' test.out

#- 46 GetCurrentCycleLeaderboardRankingAdminV3
$CLI_EXE \
    --sn leaderboard \
    --op GetCurrentCycleLeaderboardRankingAdminV3 \
    --cycleId 'Hhe1ldJX' \
    --leaderboardCode 'pA5TsKrF' \
    --namespace $AB_NAMESPACE \
    --limit '43' \
    --offset '78' \
    > test.out 2>&1
eval_tap $? 46 'GetCurrentCycleLeaderboardRankingAdminV3' test.out

#- 47 HardDeleteLeaderboardAdminV3
$CLI_EXE \
    --sn leaderboard \
    --op HardDeleteLeaderboardAdminV3 \
    --leaderboardCode 'fOUcAmJm' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 47 'HardDeleteLeaderboardAdminV3' test.out

#- 48 DeleteUserRankingByLeaderboardCodeAdminV3
$CLI_EXE \
    --sn leaderboard \
    --op DeleteUserRankingByLeaderboardCodeAdminV3 \
    --leaderboardCode 'wY2nMi66' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 48 'DeleteUserRankingByLeaderboardCodeAdminV3' test.out

#- 49 GetHiddenUsersV3
$CLI_EXE \
    --sn leaderboard \
    --op GetHiddenUsersV3 \
    --leaderboardCode 'rxLE2OjD' \
    --namespace $AB_NAMESPACE \
    --limit '44' \
    --offset '58' \
    > test.out 2>&1
eval_tap $? 49 'GetHiddenUsersV3' test.out

#- 50 GetUserRankingAdminV3
$CLI_EXE \
    --sn leaderboard \
    --op GetUserRankingAdminV3 \
    --leaderboardCode 'LPpH74Qj' \
    --namespace $AB_NAMESPACE \
    --userId '8nYwWgvm' \
    > test.out 2>&1
eval_tap $? 50 'GetUserRankingAdminV3' test.out

#- 51 DeleteUserRankingAdminV3
$CLI_EXE \
    --sn leaderboard \
    --op DeleteUserRankingAdminV3 \
    --leaderboardCode '6QPMb4bg' \
    --namespace $AB_NAMESPACE \
    --userId 'Vg4ZcoeY' \
    > test.out 2>&1
eval_tap $? 51 'DeleteUserRankingAdminV3' test.out

#- 52 GetUserVisibilityStatusV3
$CLI_EXE \
    --sn leaderboard \
    --op GetUserVisibilityStatusV3 \
    --leaderboardCode 'tDM7hYL2' \
    --namespace $AB_NAMESPACE \
    --userId 'awozNLQI' \
    > test.out 2>&1
eval_tap $? 52 'GetUserVisibilityStatusV3' test.out

#- 53 SetUserLeaderboardVisibilityV3
# body param: body
echo '{"visibility": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn leaderboard \
    --op SetUserLeaderboardVisibilityV3 \
    --leaderboardCode 'p13oS0HT' \
    --namespace $AB_NAMESPACE \
    --userId 'Row0ZLPr' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 53 'SetUserLeaderboardVisibilityV3' test.out

#- 54 DeleteUserRankingsAdminV3
$CLI_EXE \
    --sn leaderboard \
    --op DeleteUserRankingsAdminV3 \
    --namespace $AB_NAMESPACE \
    --userId 'QQDjaz50' \
    --leaderboardCode '["TC9egkEe", "Fy799OEu", "9sT8cpeq"]' \
    > test.out 2>&1
eval_tap $? 54 'DeleteUserRankingsAdminV3' test.out

#- 55 GetUserLeaderboardRankingsAdminV3
$CLI_EXE \
    --sn leaderboard \
    --op GetUserLeaderboardRankingsAdminV3 \
    --namespace $AB_NAMESPACE \
    --userId 'wV7Ib0J7' \
    --limit '30' \
    --offset '51' \
    > test.out 2>&1
eval_tap $? 55 'GetUserLeaderboardRankingsAdminV3' test.out

#- 56 SetUserVisibilityV3
# body param: body
echo '{"visibility": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn leaderboard \
    --op SetUserVisibilityV3 \
    --namespace $AB_NAMESPACE \
    --userId 'a47ioLA7' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 56 'SetUserVisibilityV3' test.out

#- 57 GetLeaderboardConfigurationsPublicV3
$CLI_EXE \
    --sn leaderboard \
    --op GetLeaderboardConfigurationsPublicV3 \
    --namespace $AB_NAMESPACE \
    --isDeleted 'true' \
    --limit '99' \
    --offset '36' \
    > test.out 2>&1
eval_tap $? 57 'GetLeaderboardConfigurationsPublicV3' test.out

#- 58 GetLeaderboardConfigurationPublicV3
$CLI_EXE \
    --sn leaderboard \
    --op GetLeaderboardConfigurationPublicV3 \
    --leaderboardCode 'cznjmAjU' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 58 'GetLeaderboardConfigurationPublicV3' test.out

#- 59 GetAllTimeLeaderboardRankingPublicV3
$CLI_EXE \
    --sn leaderboard \
    --op GetAllTimeLeaderboardRankingPublicV3 \
    --leaderboardCode 'c1j0Sk1a' \
    --namespace $AB_NAMESPACE \
    --limit '52' \
    --offset '15' \
    > test.out 2>&1
eval_tap $? 59 'GetAllTimeLeaderboardRankingPublicV3' test.out

#- 60 GetCurrentCycleLeaderboardRankingPublicV3
$CLI_EXE \
    --sn leaderboard \
    --op GetCurrentCycleLeaderboardRankingPublicV3 \
    --cycleId 'O8RbUGM2' \
    --leaderboardCode 'HAGMmxYz' \
    --namespace $AB_NAMESPACE \
    --limit '96' \
    --offset '0' \
    > test.out 2>&1
eval_tap $? 60 'GetCurrentCycleLeaderboardRankingPublicV3' test.out

#- 61 BulkGetUsersRankingPublicV3
# body param: body
echo '{"userIds": ["wRkKA4yR", "Cor4wsu4", "qMHnlMPL"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn leaderboard \
    --op BulkGetUsersRankingPublicV3 \
    --leaderboardCode 'zCWhvOnX' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 61 'BulkGetUsersRankingPublicV3' test.out

#- 62 GetUserRankingPublicV3
$CLI_EXE \
    --sn leaderboard \
    --op GetUserRankingPublicV3 \
    --leaderboardCode 'lvDJu1wT' \
    --namespace $AB_NAMESPACE \
    --userId 'ZtXfqEca' \
    > test.out 2>&1
eval_tap $? 62 'GetUserRankingPublicV3' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE