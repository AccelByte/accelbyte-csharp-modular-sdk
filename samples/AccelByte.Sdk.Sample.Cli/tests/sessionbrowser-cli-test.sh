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
    --gameMode 'oMMnDykX' \
    --gameVersion 'wbpEyJdT' \
    --joinable 'Hz2IFS6G' \
    --limit '59' \
    --matchExist 'wLorWOqj' \
    --matchId 'FvhuQ5xR' \
    --offset '81' \
    --serverStatus 'MFAQDtIA' \
    --userId 'w2s2te2p' \
    --sessionType '3YY3cfG8' \
    > test.out 2>&1
eval_tap $? 2 'AdminQuerySession' test.out

#- 3 GetTotalActiveSession
$CLI_EXE \
    --sn sessionbrowser \
    --op GetTotalActiveSession \
    --namespace $AB_NAMESPACE \
    --sessionType 'Q4VfVyLQ' \
    > test.out 2>&1
eval_tap $? 3 'GetTotalActiveSession' test.out

#- 4 GetActiveCustomGameSessions
$CLI_EXE \
    --sn sessionbrowser \
    --op GetActiveCustomGameSessions \
    --namespace $AB_NAMESPACE \
    --limit '30' \
    --offset '83' \
    --serverRegion '4XkraD27' \
    --sessionId 'pzZwgEHT' \
    > test.out 2>&1
eval_tap $? 4 'GetActiveCustomGameSessions' test.out

#- 5 GetActiveMatchmakingGameSessions
$CLI_EXE \
    --sn sessionbrowser \
    --op GetActiveMatchmakingGameSessions \
    --namespace $AB_NAMESPACE \
    --limit '71' \
    --matchId 'nXx1mzQw' \
    --offset '29' \
    --serverRegion '6y3SBgIt' \
    --sessionId 'Ps6q3Gdl' \
    > test.out 2>&1
eval_tap $? 5 'GetActiveMatchmakingGameSessions' test.out

#- 6 AdminGetSession
$CLI_EXE \
    --sn sessionbrowser \
    --op AdminGetSession \
    --namespace $AB_NAMESPACE \
    --sessionID 'd4B2MBVo' \
    > test.out 2>&1
eval_tap $? 6 'AdminGetSession' test.out

#- 7 AdminDeleteSession
$CLI_EXE \
    --sn sessionbrowser \
    --op AdminDeleteSession \
    --namespace $AB_NAMESPACE \
    --sessionID 'IK9Bu68y' \
    > test.out 2>&1
eval_tap $? 7 'AdminDeleteSession' test.out

#- 8 AdminSearchSessionsV2
$CLI_EXE \
    --sn sessionbrowser \
    --op AdminSearchSessionsV2 \
    --namespace $AB_NAMESPACE \
    --channel 'vqhhxkFO' \
    --deleted 'true' \
    --matchID 'yo0efEfR' \
    --partyID 'HOYsTwfC' \
    --sessionType 'TrCyvlXK' \
    --status 'j6EhHWrr' \
    --userID 'P0BcuLHs' \
    --limit '27' \
    --offset '35' \
    > test.out 2>&1
eval_tap $? 8 'AdminSearchSessionsV2' test.out

#- 9 GetSessionHistoryDetailed
$CLI_EXE \
    --sn sessionbrowser \
    --op GetSessionHistoryDetailed \
    --matchID 'pgQsK2xw' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 9 'GetSessionHistoryDetailed' test.out

#- 10 UserQuerySession
$CLI_EXE \
    --sn sessionbrowser \
    --op UserQuerySession \
    --namespace $AB_NAMESPACE \
    --gameMode 'qP97IDtv' \
    --gameVersion '2Cja8Nfl' \
    --joinable 'gtWvNA2z' \
    --limit '43' \
    --matchExist '5Tls41W7' \
    --matchId '6LcAl9dD' \
    --offset '63' \
    --serverStatus 'ys5WfD9j' \
    --userId 'y1AkIBse' \
    --sessionType 'QA4PJOav' \
    > test.out 2>&1
eval_tap $? 10 'UserQuerySession' test.out

#- 11 CreateSession
# body param: body
echo '{"game_session_setting": {"allow_join_in_progress": true, "current_internal_player": 5, "current_player": 24, "map_name": "YHitzLva", "max_internal_player": 48, "max_player": 3, "mode": "QOzk0IXk", "num_bot": 21, "password": "PCHTpeKv", "settings": {"2qCdYPWW": {}, "tbTboS2u": {}, "OakKq7WX": {}}}, "game_version": "YXy5clwy", "namespace": "s8jFze6z", "session_type": "tGVibVtq", "username": "yoBeMsIH"}' > $TEMP_JSON_INPUT
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
    --userIds 'v2afoquf' \
    > test.out 2>&1
eval_tap $? 12 'GetSessionByUserIDs' test.out

#- 13 GetSession
$CLI_EXE \
    --sn sessionbrowser \
    --op GetSession \
    --namespace $AB_NAMESPACE \
    --sessionID 'W0A068qw' \
    > test.out 2>&1
eval_tap $? 13 'GetSession' test.out

#- 14 UpdateSession
# body param: body
echo '{"game_max_player": 39}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn sessionbrowser \
    --op UpdateSession \
    --namespace $AB_NAMESPACE \
    --sessionID 'U3ZTeh2H' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 14 'UpdateSession' test.out

#- 15 DeleteSession
$CLI_EXE \
    --sn sessionbrowser \
    --op DeleteSession \
    --namespace $AB_NAMESPACE \
    --sessionID '4ZP5T1lp' \
    > test.out 2>&1
eval_tap $? 15 'DeleteSession' test.out

#- 16 JoinSession
# body param: body
echo '{"password": "ciu6qfHK"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn sessionbrowser \
    --op JoinSession \
    --namespace $AB_NAMESPACE \
    --sessionID 'VfXJXQWW' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 16 'JoinSession' test.out

#- 17 DeleteSessionLocalDS
$CLI_EXE \
    --sn sessionbrowser \
    --op DeleteSessionLocalDS \
    --namespace $AB_NAMESPACE \
    --sessionID 'TeoU3Yql' \
    > test.out 2>&1
eval_tap $? 17 'DeleteSessionLocalDS' test.out

#- 18 AddPlayerToSession
# body param: body
echo '{"as_spectator": true, "user_id": "oR0vN1SI"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn sessionbrowser \
    --op AddPlayerToSession \
    --namespace $AB_NAMESPACE \
    --sessionID 'ch25J6mI' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 18 'AddPlayerToSession' test.out

#- 19 RemovePlayerFromSession
$CLI_EXE \
    --sn sessionbrowser \
    --op RemovePlayerFromSession \
    --namespace $AB_NAMESPACE \
    --sessionID 'zMAz640b' \
    --userID 'kIOerrrH' \
    > test.out 2>&1
eval_tap $? 19 'RemovePlayerFromSession' test.out

#- 20 UpdateSettings
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn sessionbrowser \
    --op UpdateSettings \
    --namespace $AB_NAMESPACE \
    --sessionID 'O8hh2QkX' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 20 'UpdateSettings' test.out

#- 21 GetRecentPlayer
$CLI_EXE \
    --sn sessionbrowser \
    --op GetRecentPlayer \
    --namespace $AB_NAMESPACE \
    --userID 'vn60zsjh' \
    > test.out 2>&1
eval_tap $? 21 'GetRecentPlayer' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE