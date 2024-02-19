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
echo "1..21"

#- 1 Login
$CLI_EXE --op login --lt user --user user --pass user > test.out 2>&1
eval_tap $? 1 'Login' test.out

if [ $EXIT_CODE -ne 0 ]; then
  echo "Bail out! Login failed."
  exit $EXIT_CODE
fi

# echo "foo" > "$CLI_TOKEN_FILE"

#- 2 AdminQuerySession
$CLI_EXE \
    --sn sessionbrowser \
    --op AdminQuerySession \
    --namespace $AB_NAMESPACE \
    --gameMode 'diCIePBi' \
    --gameVersion '3tbu8QtH' \
    --joinable 'Q4AZ7UZe' \
    --limit '74' \
    --matchExist 'RNUiryHC' \
    --matchId 'nz5friaO' \
    --offset '5' \
    --serverStatus '7BEDlLrP' \
    --userId 'DpGmMluv' \
    --sessionType '44PoHrYh' \
    > test.out 2>&1
eval_tap $? 2 'AdminQuerySession' test.out

#- 3 GetTotalActiveSession
$CLI_EXE \
    --sn sessionbrowser \
    --op GetTotalActiveSession \
    --namespace $AB_NAMESPACE \
    --sessionType 'pxkQANNc' \
    > test.out 2>&1
eval_tap $? 3 'GetTotalActiveSession' test.out

#- 4 GetActiveCustomGameSessions
$CLI_EXE \
    --sn sessionbrowser \
    --op GetActiveCustomGameSessions \
    --namespace $AB_NAMESPACE \
    --limit '26' \
    --offset '57' \
    --serverRegion 'SuAcQ2Co' \
    --sessionId 'Eh8Fp69Y' \
    > test.out 2>&1
eval_tap $? 4 'GetActiveCustomGameSessions' test.out

#- 5 GetActiveMatchmakingGameSessions
$CLI_EXE \
    --sn sessionbrowser \
    --op GetActiveMatchmakingGameSessions \
    --namespace $AB_NAMESPACE \
    --limit '98' \
    --matchId 'qkdczO5F' \
    --offset '41' \
    --serverRegion 'za1uKSvD' \
    --sessionId 'gsXxQ1fM' \
    > test.out 2>&1
eval_tap $? 5 'GetActiveMatchmakingGameSessions' test.out

#- 6 AdminGetSession
$CLI_EXE \
    --sn sessionbrowser \
    --op AdminGetSession \
    --namespace $AB_NAMESPACE \
    --sessionID 'JgeeRvTC' \
    > test.out 2>&1
eval_tap $? 6 'AdminGetSession' test.out

#- 7 AdminDeleteSession
$CLI_EXE \
    --sn sessionbrowser \
    --op AdminDeleteSession \
    --namespace $AB_NAMESPACE \
    --sessionID 'E2O6oWLm' \
    > test.out 2>&1
eval_tap $? 7 'AdminDeleteSession' test.out

#- 8 AdminSearchSessionsV2
$CLI_EXE \
    --sn sessionbrowser \
    --op AdminSearchSessionsV2 \
    --namespace $AB_NAMESPACE \
    --channel 'dxYOzaLE' \
    --deleted 'true' \
    --matchID 'Xoi9OlUd' \
    --partyID 'TJI8Ocmt' \
    --sessionType '1wnw4uQc' \
    --status '9MOMTXji' \
    --userID '0q03kHIy' \
    --limit '63' \
    --offset '29' \
    > test.out 2>&1
eval_tap $? 8 'AdminSearchSessionsV2' test.out

#- 9 GetSessionHistoryDetailed
$CLI_EXE \
    --sn sessionbrowser \
    --op GetSessionHistoryDetailed \
    --matchID 'BNvDFL9q' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 9 'GetSessionHistoryDetailed' test.out

#- 10 UserQuerySession
$CLI_EXE \
    --sn sessionbrowser \
    --op UserQuerySession \
    --namespace $AB_NAMESPACE \
    --gameMode 'x04lDlQz' \
    --gameVersion 'hdprGh8M' \
    --joinable 'W7zbbuE2' \
    --limit '19' \
    --matchExist 'apbhyMNn' \
    --matchId 'O8HEHhX6' \
    --offset '32' \
    --serverStatus 'dI9IZqu7' \
    --userId '9J794302' \
    --sessionType 'PjFCHkB0' \
    > test.out 2>&1
eval_tap $? 10 'UserQuerySession' test.out

#- 11 CreateSession
# body param: body
echo '{"game_session_setting": {"allow_join_in_progress": true, "current_internal_player": 64, "current_player": 7, "map_name": "jsexPKNV", "max_internal_player": 20, "max_player": 49, "mode": "Uzy0AhHH", "num_bot": 23, "password": "mUHp6zFP", "settings": {"79LgR7XK": {}, "w45B29Wr": {}, "54B715ZZ": {}}}, "game_version": "m1oCO1UK", "namespace": "u7CvL9gu", "session_type": "jgIP9VrY", "username": "SwW8LK6Z"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn sessionbrowser \
    --op CreateSession \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 11 'CreateSession' test.out

#- 12 GetSessionByUserIDs
$CLI_EXE \
    --sn sessionbrowser \
    --op GetSessionByUserIDs \
    --namespace $AB_NAMESPACE \
    --userIds 'OzQ4xD7G' \
    > test.out 2>&1
eval_tap $? 12 'GetSessionByUserIDs' test.out

#- 13 GetSession
$CLI_EXE \
    --sn sessionbrowser \
    --op GetSession \
    --namespace $AB_NAMESPACE \
    --sessionID 'IuLmxkCM' \
    > test.out 2>&1
eval_tap $? 13 'GetSession' test.out

#- 14 UpdateSession
# body param: body
echo '{"game_max_player": 38}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn sessionbrowser \
    --op UpdateSession \
    --namespace $AB_NAMESPACE \
    --sessionID '0YPJGGOu' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 14 'UpdateSession' test.out

#- 15 DeleteSession
$CLI_EXE \
    --sn sessionbrowser \
    --op DeleteSession \
    --namespace $AB_NAMESPACE \
    --sessionID '7hSNBIFn' \
    > test.out 2>&1
eval_tap $? 15 'DeleteSession' test.out

#- 16 JoinSession
# body param: body
echo '{"password": "TOXW0srB"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn sessionbrowser \
    --op JoinSession \
    --namespace $AB_NAMESPACE \
    --sessionID 'cEN7Oc8M' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 16 'JoinSession' test.out

#- 17 DeleteSessionLocalDS
$CLI_EXE \
    --sn sessionbrowser \
    --op DeleteSessionLocalDS \
    --namespace $AB_NAMESPACE \
    --sessionID 'WeQYdrig' \
    > test.out 2>&1
eval_tap $? 17 'DeleteSessionLocalDS' test.out

#- 18 AddPlayerToSession
# body param: body
echo '{"as_spectator": true, "user_id": "UJ120h5I"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn sessionbrowser \
    --op AddPlayerToSession \
    --namespace $AB_NAMESPACE \
    --sessionID 'FOqoIw0Y' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 18 'AddPlayerToSession' test.out

#- 19 RemovePlayerFromSession
$CLI_EXE \
    --sn sessionbrowser \
    --op RemovePlayerFromSession \
    --namespace $AB_NAMESPACE \
    --sessionID 'bVdGARZ4' \
    --userID 'XRANMyIq' \
    > test.out 2>&1
eval_tap $? 19 'RemovePlayerFromSession' test.out

#- 20 UpdateSettings
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn sessionbrowser \
    --op UpdateSettings \
    --namespace $AB_NAMESPACE \
    --sessionID 'YzksgTOc' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 20 'UpdateSettings' test.out

#- 21 GetRecentPlayer
$CLI_EXE \
    --sn sessionbrowser \
    --op GetRecentPlayer \
    --namespace $AB_NAMESPACE \
    --userID 'CkD8CnTG' \
    > test.out 2>&1
eval_tap $? 21 'GetRecentPlayer' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE