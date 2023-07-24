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
echo "1..60"

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
    --sn session \
    --op GetHealthcheckInfo \
    > test.out 2>&1
eval_tap $? 2 'GetHealthcheckInfo' test.out

#- 3 GetHealthcheckInfoV1
$CLI_EXE \
    --sn session \
    --op GetHealthcheckInfoV1 \
    > test.out 2>&1
eval_tap $? 3 'GetHealthcheckInfoV1' test.out

#- 4 AdminGetDSMCConfigurationDefault
$CLI_EXE \
    --sn session \
    --op AdminGetDSMCConfigurationDefault \
    > test.out 2>&1
eval_tap $? 4 'AdminGetDSMCConfigurationDefault' test.out

#- 5 AdminGetConfigurationAlertV1
$CLI_EXE \
    --sn session \
    --op AdminGetConfigurationAlertV1 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 5 'AdminGetConfigurationAlertV1' test.out

#- 6 AdminUpdateConfigurationAlertV1
# body param: body
echo '{"durationDays": 2}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminUpdateConfigurationAlertV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 6 'AdminUpdateConfigurationAlertV1' test.out

#- 7 AdminCreateConfigurationAlertV1
# body param: body
echo '{"durationDays": 56}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminCreateConfigurationAlertV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 7 'AdminCreateConfigurationAlertV1' test.out

#- 8 AdminDeleteConfigurationAlertV1
$CLI_EXE \
    --sn session \
    --op AdminDeleteConfigurationAlertV1 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 8 'AdminDeleteConfigurationAlertV1' test.out

#- 9 AdminCreateConfigurationTemplateV1
# body param: body
echo '{"NativeSessionSetting": {"PSNServiceLabel": 18, "PSNSupportedPlatforms": ["uz5zkoaUEzGS3qZf", "0PbemSBELbZ0VBUG", "A7nkDeev2Oj060Hn"], "SessionTitle": "Of5S8X1LxkZs4233", "ShouldSync": false, "XboxServiceConfigID": "F7bwRgwKvzESbhpx", "XboxSessionTemplateName": "lDdEs4igdKeLmy8t", "localizedSessionName": {"Z5GZi5P12c61ts3f": {}, "MI04rm2jUc9iav3t": {}, "TqlE9oLDPD0Lfle8": {}}}, "PSNBaseUrl": "ESU1MO8XnVaEyjmi", "autoJoin": false, "clientVersion": "Ou124TsbQsxYFxGG", "deployment": "HrfQkgXkiA5IZPqC", "dsSource": "qp9vcyt67WAfWXfU", "fallbackClaimKeys": ["fwGB03tz8qIH4uRd", "NO08HN6s9p8Y5c9e", "ItJtiNmY3y3n2Rim"], "inactiveTimeout": 38, "inviteTimeout": 82, "joinability": "mhjXcScOUvrjJBO7", "maxActiveSessions": 40, "maxPlayers": 39, "minPlayers": 2, "name": "LpERf77LzPoORBkR", "persistent": false, "preferredClaimKeys": ["SdaFy0pJYCdfkfyt", "09ro5fHdWqJTNjrm", "pnnEckHH8kT9oXVa"], "requestedRegions": ["ndercf1nq4Hf32SL", "5PjaYEDxaYN8w9KU", "W0py8KrcQfucSq2X"], "textChat": false, "tieTeamsSessionLifetime": false, "type": "D9qU89D356pVsUtN"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminCreateConfigurationTemplateV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 9 'AdminCreateConfigurationTemplateV1' test.out

#- 10 AdminGetAllConfigurationTemplatesV1
$CLI_EXE \
    --sn session \
    --op AdminGetAllConfigurationTemplatesV1 \
    --namespace $AB_NAMESPACE \
    --limit '1' \
    --name 'QUrA0WWyKl2K5mCS' \
    --offset '29' \
    > test.out 2>&1
eval_tap $? 10 'AdminGetAllConfigurationTemplatesV1' test.out

#- 11 AdminGetConfigurationTemplateV1
$CLI_EXE \
    --sn session \
    --op AdminGetConfigurationTemplateV1 \
    --name 'fdopcEM0JHfof2Hw' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 11 'AdminGetConfigurationTemplateV1' test.out

#- 12 AdminUpdateConfigurationTemplateV1
# body param: body
echo '{"NativeSessionSetting": {"PSNServiceLabel": 16, "PSNSupportedPlatforms": ["AYcRXJdoSTxNCK9A", "IjNmbfoW8bDq5jPq", "zhN0YdGSrA9LXRwU"], "SessionTitle": "6WLgpQE9nXzhBC0u", "ShouldSync": true, "XboxServiceConfigID": "MXtyUWXrdZaFeacG", "XboxSessionTemplateName": "T2x6o28Njxyw7RHl", "localizedSessionName": {"dq0m7NjUZ95Z5XDL": {}, "BN9YGVPtkjt0OyBl": {}, "Ji4RbZ0Iy11mfOFj": {}}}, "PSNBaseUrl": "CzZVcGomWF1oAqUN", "autoJoin": true, "clientVersion": "DtXnXLvOAsW8wYh4", "deployment": "gq7pRVZVLJiDx3au", "dsSource": "9b9QjhzDlnJmi4Xa", "fallbackClaimKeys": ["BTgoXjfdUQHa3Rxs", "pSqwdbTR2sgzfaQr", "UCW9fgo69uv1bkFx"], "inactiveTimeout": 0, "inviteTimeout": 61, "joinability": "xTWnmyEYLZQTpvLH", "maxActiveSessions": 4, "maxPlayers": 86, "minPlayers": 54, "name": "PEBP8kSSFjeuL3wQ", "persistent": false, "preferredClaimKeys": ["YwmYFbxRvHYDCYwo", "GdmzXgf1ewUTvnu0", "ensa3MZF7DTswnkS"], "requestedRegions": ["yuJTVjKQ1ORLEIAe", "PvDO2xkVgyRk10b2", "7RdU8VceYQ9erPYQ"], "textChat": true, "tieTeamsSessionLifetime": true, "type": "cEio5UyvuFv5z6wo"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminUpdateConfigurationTemplateV1 \
    --name 'sJGnUyCMEbHh1uE4' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 12 'AdminUpdateConfigurationTemplateV1' test.out

#- 13 AdminDeleteConfigurationTemplateV1
$CLI_EXE \
    --sn session \
    --op AdminDeleteConfigurationTemplateV1 \
    --name 'DmJ4Suj6DjUw36Gt' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 13 'AdminDeleteConfigurationTemplateV1' test.out

#- 14 AdminGetDSMCConfiguration
$CLI_EXE \
    --sn session \
    --op AdminGetDSMCConfiguration \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 14 'AdminGetDSMCConfiguration' test.out

#- 15 AdminSyncDSMCConfiguration
$CLI_EXE \
    --sn session \
    --op AdminSyncDSMCConfiguration \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 15 'AdminSyncDSMCConfiguration' test.out

#- 16 AdminQueryGameSessions
$CLI_EXE \
    --sn session \
    --op AdminQueryGameSessions \
    --namespace $AB_NAMESPACE \
    --configurationName 'Z83Jp2f9f1FCoIo3' \
    --dsPodName 'L24DKGwgZ85vyFJR' \
    --fromTime '8euQBLVu27iwplLJ' \
    --gameMode 'dzYS9K0VvwE6MAqP' \
    --isPersistent 'c8lGIYWTwxyqQQIX' \
    --isSoftDeleted 'VmrtRlq1jv60HTnm' \
    --joinability 'Frl3gYx6Xmv1DzPH' \
    --limit '43' \
    --matchPool '0UTaiSzfi0FnBERe' \
    --memberID '8qNYRTYSaZw4NqSN' \
    --offset '51' \
    --order 'dygfKmUkzj9mHFpf' \
    --orderBy 'f2vDkz68zorEgcEx' \
    --sessionID 'v9nKMOgO5W8SUaZj' \
    --status 'CpNtJSMm8kDi3Rwu' \
    --statusV2 'bq7wtRGdT447Oa51' \
    --toTime 'm6VLfjsw270pMmOQ' \
    > test.out 2>&1
eval_tap $? 16 'AdminQueryGameSessions' test.out

#- 17 AdminDeleteBulkGameSessions
# body param: body
echo '{"ids": ["JrpEBbVvBn8Lsf2q", "SAtizV9hzsVbpJLt", "EZjuyFhvbxX2DNbk"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminDeleteBulkGameSessions \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 17 'AdminDeleteBulkGameSessions' test.out

#- 18 AdminUpdateGameSessionMember
$CLI_EXE \
    --sn session \
    --op AdminUpdateGameSessionMember \
    --memberId 'nfVv4nm70TCayYAk' \
    --namespace $AB_NAMESPACE \
    --sessionId 'F18YBwRxcREyU5Cw' \
    --statusType 'qGJF6nDi33Iztr2Q' \
    > test.out 2>&1
eval_tap $? 18 'AdminUpdateGameSessionMember' test.out

#- 19 AdminQueryParties
$CLI_EXE \
    --sn session \
    --op AdminQueryParties \
    --namespace $AB_NAMESPACE \
    --joinability 'cwlRrReRajlpk8lf' \
    --key 'uiJVcktlx9zJZVVC' \
    --leaderID 'c9bpIHEWQMmCkIqw' \
    --limit '33' \
    --memberID 'igVynjGFyVicGQAV' \
    --memberStatus 'v32ftRAsmC0RuRA8' \
    --offset '18' \
    --order 'ks2R3VMtipTVxXAF' \
    --orderBy '8KhOKqbrECijFxOp' \
    --partyID 'OzxeTLJQsZcTEzXa' \
    --value 'XUzpsAV6ct6XITL0' \
    > test.out 2>&1
eval_tap $? 19 'AdminQueryParties' test.out

#- 20 AdminGetPlatformCredentials
$CLI_EXE \
    --sn session \
    --op AdminGetPlatformCredentials \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 20 'AdminGetPlatformCredentials' test.out

#- 21 AdminUpdatePlatformCredentials
# body param: body
echo '{"psn": {"clientId": "QEkadMSQluAoED9o", "clientSecret": "YwS8oLyErKvRtHFG", "scope": "JRoGW7VBG1VB2sp2"}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminUpdatePlatformCredentials \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 21 'AdminUpdatePlatformCredentials' test.out

#- 22 AdminDeletePlatformCredentials
$CLI_EXE \
    --sn session \
    --op AdminDeletePlatformCredentials \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 22 'AdminDeletePlatformCredentials' test.out

#- 23 AdminQueryPlayerAttributes
$CLI_EXE \
    --sn session \
    --op AdminQueryPlayerAttributes \
    --namespace $AB_NAMESPACE \
    --users 'x9mszGGoyhGZAzt2' \
    > test.out 2>&1
eval_tap $? 23 'AdminQueryPlayerAttributes' test.out

#- 24 AdminGetPlayerAttributes
$CLI_EXE \
    --sn session \
    --op AdminGetPlayerAttributes \
    --namespace $AB_NAMESPACE \
    --userId 'OVBTLwSH8hWRU9pb' \
    > test.out 2>&1
eval_tap $? 24 'AdminGetPlayerAttributes' test.out

#- 25 CreateGameSession
# body param: body
echo '{"attributes": {"ItGQ7VUWBhGolwaf": {}, "IfbF1GLFnrQ4T5cm": {}, "w7U1TxiS06UEoaDZ": {}}, "autoJoin": false, "backfillTicketID": "r3oT88Dfc7114QFG", "clientVersion": "wTzBVDg5v71kGCEt", "configurationName": "7h1mVwIQCJmQkvWb", "deployment": "Qrn2W0VkOF0pQOY0", "dsSource": "UCcViiFKNjkT5hcO", "fallbackClaimKeys": ["NCaOyATBFgqLeAzv", "dcUEhWRo6ROvbuPQ", "wl9dVfJQGkDR00of"], "inactiveTimeout": 37, "inviteTimeout": 37, "joinability": "ifSPmYSsBxtyKWss", "matchPool": "En5VEvIMEB4pl506", "maxPlayers": 11, "minPlayers": 15, "preferredClaimKeys": ["LCG6EAl7d3Ks65th", "tnjcMSw1J42fthKU", "obas2CAlSxxVhDR9"], "requestedRegions": ["hlaznetBUGcQz2Wv", "diclkYGDL2ckC9cd", "zaLnajQ8GnJpALid"], "serverName": "dv9UUtG1tEECsm8x", "teams": [{"UserIDs": ["aDOz0tMlpFuJVXo9", "s0JPG8cgjHQo9HoL", "LyUnPTiCD0038or8"], "parties": [{"partyID": "wR0tuwIJnrSI2IFc", "userIDs": ["RwSoMTuJziuDNbOy", "diu3lOaruuYw0iUu", "ts6bChMK1gcx8p9f"]}, {"partyID": "yv5PoMJeTIQix1FE", "userIDs": ["vzlipE7r0vhh21v5", "772AopmjI7CbY2Wu", "wRUT9IivgC4mJ5OH"]}, {"partyID": "uNEVQK4Mvk00I9Gq", "userIDs": ["AhhjNIivdIcaEQfN", "ETQCBPK1mYwKVQoy", "dbYjXZyBpqhCJBtF"]}]}, {"UserIDs": ["Om3iCpu0lhhgutt3", "rQuKP1OEtKFBjNih", "HU8GP8TRVypSvYXK"], "parties": [{"partyID": "z4BGjbsrRBV8aztJ", "userIDs": ["86yQK1AsC18UO6Jc", "XmwQfkseTpH6l2Dv", "8SvqYKc56PcPSL2x"]}, {"partyID": "mjViKkKw4gHA4CaL", "userIDs": ["sPqRsTdKzcKtkGcv", "n44NWse6VLPkM1VT", "rQBywhJ7lbBLw9xy"]}, {"partyID": "1WQM5qUS8baUqkzS", "userIDs": ["r41y6RPBHJuPjj8z", "DwOk0IgmYfUTpFzy", "QhPVhRGX9xlUKhXI"]}]}, {"UserIDs": ["8mL8OIhvP68xE68d", "zohxhbej2caIIfkX", "DY7jnhp3qY6T7TUE"], "parties": [{"partyID": "BotSNIwGhia6cqoW", "userIDs": ["mnhtuzxir12r0VUW", "I0kJAczj5ApcsiEQ", "65llgGnTHAsTCZa7"]}, {"partyID": "xE4nwGKlbPRxfucx", "userIDs": ["oRKFLxxcL9SyuHbv", "RxR6LaKWgAVjZKDx", "iezEbuMCz9J4dPRG"]}, {"partyID": "zoQLYIWPPZvyPupi", "userIDs": ["mCENHEenqjRSxO9o", "Z0fCxLR0GfjwCmDr", "bDR0Q0ixpqYtkZuh"]}]}], "textChat": false, "ticketIDs": ["qbAhRExsnbWSH45L", "arTmOqto4OtwF9uP", "UAxerdIqWmOoMyYp"], "tieTeamsSessionLifetime": true, "type": "tSrLxpJnj9JtgjWm"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op CreateGameSession \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 25 'CreateGameSession' test.out

#- 26 PublicQueryGameSessions
# body param: body
echo '{"jx1WuNQq4v8FnVzd": {}, "bNW1xuV7rVei1o9z": {}, "V6rhVfcQmLfEn5ZU": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicQueryGameSessions \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 26 'PublicQueryGameSessions' test.out

#- 27 PublicSessionJoinCode
# body param: body
echo '{"code": "GeYlOwODWBAz6skH"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicSessionJoinCode \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 27 'PublicSessionJoinCode' test.out

#- 28 GetGameSessionByPodName
$CLI_EXE \
    --sn session \
    --op GetGameSessionByPodName \
    --namespace $AB_NAMESPACE \
    --podName 'Mfl4Hjw9KEnx8cNf' \
    > test.out 2>&1
eval_tap $? 28 'GetGameSessionByPodName' test.out

#- 29 GetGameSession
$CLI_EXE \
    --sn session \
    --op GetGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'DK45zWtwYhRoNPwK' \
    > test.out 2>&1
eval_tap $? 29 'GetGameSession' test.out

#- 30 UpdateGameSession
# body param: body
echo '{"attributes": {"ema6caMTOcivPAkm": {}, "P8Awb0NqtvSR9q6l": {}, "5k9BLQMrPoTuxdzE": {}}, "backfillTicketID": "YAw5VdW05WnQEAbK", "clientVersion": "416LN2N6D6yczitn", "deployment": "4OkZfx0Xa6sgegAW", "fallbackClaimKeys": ["Yz2z4qSPPQBDFQsv", "RHbGTC2ynue7Xk4u", "DF5mdakWJ2AsKf8U"], "inactiveTimeout": 11, "inviteTimeout": 90, "joinability": "QqTQ8v7gXyFuLFZV", "matchPool": "iQbxYQvUyapo6FmM", "maxPlayers": 49, "minPlayers": 99, "preferredClaimKeys": ["6tZYSCe7du68Ce6T", "4pYH3BPyFurT4p8z", "oRYG8WKTaUyB0Uyr"], "requestedRegions": ["KKulHUnompTrS7DI", "OakX65w7RpxY6pd1", "QTpFpaxbCjHSCXM7"], "teams": [{"UserIDs": ["sL1nnOoRIg7oSh4y", "Vttp53wasuHbA0ke", "UomVCh681OMZFNRw"], "parties": [{"partyID": "8YvLGLnB4xfqdHhP", "userIDs": ["HA2ZbIvW1oxENH4M", "sVlbCMc5hx0W14Sk", "vovINegS29legebq"]}, {"partyID": "Gwej59Ok8EM0OFW9", "userIDs": ["3FkJicmK6qeaDEm9", "bPCS2a5WoOtwavdi", "oadjCN0lC0MZRZAv"]}, {"partyID": "hZ7XQmcT57Hl2PvP", "userIDs": ["OKvc25nnSLnEnv4i", "pAVJzPHM6kTwfu1v", "SD9gROMknwVRJfXH"]}]}, {"UserIDs": ["GB1r66lbNcbMIJEY", "0BmpF215jJycJcSy", "XLzU9Uqk079uhBLl"], "parties": [{"partyID": "4yz32RqkNzYSNYl4", "userIDs": ["zvyD8SUZv2LFFZer", "6T3W7TE5WdocKzvg", "r3jBU2g8Eo7uAb4H"]}, {"partyID": "ndxqQYO14lFR2YtI", "userIDs": ["b1fufxJiodJFjEbn", "1ASMAiedHoYv6WmW", "9mRXQwc5sfOZbgnC"]}, {"partyID": "mULqltV5xjjrXKhZ", "userIDs": ["OekpygvRDCk0koCG", "DPfbiGdBQ5DNVJAg", "fAkD0w0H6QM5AsRn"]}]}, {"UserIDs": ["p9a7p0g0szNgC8yV", "FlwGULKeMzn4sG6P", "5R2lHU9mf9rzrxux"], "parties": [{"partyID": "txg98cDF1fsD5miA", "userIDs": ["xHczgRu4VYjQq4VI", "VFUqNPuW223zuUv8", "ShbYBe9hLKcN6myF"]}, {"partyID": "UWf7IuLG63jl9rYX", "userIDs": ["aEFcUySnsIREQUlw", "Dt2XB6DgoJm4dqrL", "VSBWToF03dQYi0Ox"]}, {"partyID": "I4DZZd2V80fjN9Cw", "userIDs": ["M4qNT3awIjWoFCW5", "BTW9laFjsd7gSFkI", "VGnXJLeUdD8XNxAk"]}]}], "ticketIDs": ["oeHk0BXouyKC6RnO", "4PckO3syHJOMlgAq", "tsnZlLvEczKKAyiQ"], "tieTeamsSessionLifetime": true, "type": "NN6m8BLNzJxMR9F8", "version": 87}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op UpdateGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'vScPhhhoeTbxungc' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 30 'UpdateGameSession' test.out

#- 31 DeleteGameSession
$CLI_EXE \
    --sn session \
    --op DeleteGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'a58m1uNcxsQxrsxb' \
    > test.out 2>&1
eval_tap $? 31 'DeleteGameSession' test.out

#- 32 PatchUpdateGameSession
# body param: body
echo '{"attributes": {"LSv7uFZXdW5GyQ2m": {}, "veLZEnmSCeWTCXfA": {}, "RUx3U3KrfqoZi5xi": {}}, "backfillTicketID": "HiQI9ieQ8y75Biw4", "clientVersion": "pKJ8hey5JmuUDloj", "deployment": "Ec712JEhS1VFA1Eo", "fallbackClaimKeys": ["4Rxcnq5DtzSaifBy", "aju2TY0QdHndDWB6", "0eGxKadAf6UL9Mkk"], "inactiveTimeout": 97, "inviteTimeout": 7, "joinability": "f8dHJYJF19NcUSJg", "matchPool": "QSBwkX1FU71K0CzX", "maxPlayers": 52, "minPlayers": 62, "preferredClaimKeys": ["dQIWh5PSp024SIhn", "u3h3uK1jRHhQ2uS2", "7tXHvtxi6EbWHrMr"], "requestedRegions": ["bpZd2bt6P3sZXAZk", "dh450P2HCQEysNYm", "CndtXXQgiHJgjwpC"], "teams": [{"UserIDs": ["xGEBsc3HVarhLlwl", "mf1l5JhrQSpGlguv", "TECefhiKKuc8Urg4"], "parties": [{"partyID": "atANoOfyCbfBoH6z", "userIDs": ["LgTsYmAw4mFyLcIq", "00Vl8sxzC1fJxroZ", "eNIlbxAUeRUjUbaP"]}, {"partyID": "klfVic7zYJTjpmhW", "userIDs": ["VBgTDm8IGJL3sEpn", "q2qNgEjKMemoxx1k", "2s5gW8zADPqu8PVX"]}, {"partyID": "nN0xl48RoZbNL7cX", "userIDs": ["CVaF9U1H9bQv7Eyb", "PwbHEHxSPaGCQl5y", "1gekeqHnzZfY22Z1"]}]}, {"UserIDs": ["SmIc5NTRyLbOzAYD", "5IH4deTFCDORAsuT", "0lseQtOoohdBYhvv"], "parties": [{"partyID": "wspKpEPUUxc2NKFB", "userIDs": ["2qxCiWMNdvN9SDRK", "ye6n1t8RXF5qayS4", "UAMJrRrnNfXdTnJz"]}, {"partyID": "7e3tD8KVlMU17V03", "userIDs": ["QDQjU64lc3oek3RW", "XWJhPXvS9OmmtZ14", "XROPpbgqS9a9eP72"]}, {"partyID": "cbSH4TvY6sMCkitX", "userIDs": ["sNfi8EF3mgABwFe1", "N0QNeryssScV8w2r", "N40y7aLOJoeZqRwJ"]}]}, {"UserIDs": ["zTdMg00KvHLdMiaj", "e6w7YN9MWtYzurSM", "cK8c5xZukais9Top"], "parties": [{"partyID": "wzyVFe9lNT7v5Qyc", "userIDs": ["BCxJG7DehSEc6kg2", "UWX8dfboaqkOS5P8", "ijeU7ceEjsJO7xZU"]}, {"partyID": "K7lMGDnKhxDxWqk0", "userIDs": ["FyDBDBxAznXS1mfs", "6uZ9OaZwm6pPAdF5", "lHMHzBycY7bXyRpF"]}, {"partyID": "Uts9CpuTZNXAvR5m", "userIDs": ["EjDGi8Z9KuTHuT6I", "lImbAYCRvUBIHoIh", "Unq8EtmzVPJFqDDs"]}]}], "ticketIDs": ["FmDKPixcJtgNHrTE", "QpFB5aeIMGxoyLMq", "SLDNxuBA95CXk3K2"], "tieTeamsSessionLifetime": false, "type": "XCnhXRiCBS6wONO7", "version": 62}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PatchUpdateGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'fhWE1OiCOozFmZ3h' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 32 'PatchUpdateGameSession' test.out

#- 33 UpdateGameSessionBackfillTicketID
# body param: body
echo '{"backfillTicketID": "zpayQ1ySXmHgROq1"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op UpdateGameSessionBackfillTicketID \
    --namespace $AB_NAMESPACE \
    --sessionId 'X5e82zDrJtNcl4zt' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 33 'UpdateGameSessionBackfillTicketID' test.out

#- 34 GameSessionGenerateCode
$CLI_EXE \
    --sn session \
    --op GameSessionGenerateCode \
    --namespace $AB_NAMESPACE \
    --sessionId 'saFwrylG42gHaf4X' \
    > test.out 2>&1
eval_tap $? 34 'GameSessionGenerateCode' test.out

#- 35 PublicRevokeGameSessionCode
$CLI_EXE \
    --sn session \
    --op PublicRevokeGameSessionCode \
    --namespace $AB_NAMESPACE \
    --sessionId 'EHX7QBUYvSupGJqp' \
    > test.out 2>&1
eval_tap $? 35 'PublicRevokeGameSessionCode' test.out

#- 36 PublicGameSessionInvite
# body param: body
echo '{"platformID": "wAp0WMu7ZUAbKsKi", "userID": "0fuipdvULHrqNhX3"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicGameSessionInvite \
    --namespace $AB_NAMESPACE \
    --sessionId 'eWB4hfA53Ibtklb9' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 36 'PublicGameSessionInvite' test.out

#- 37 JoinGameSession
$CLI_EXE \
    --sn session \
    --op JoinGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'jB4Gcb0L2EPZQmxE' \
    > test.out 2>&1
eval_tap $? 37 'JoinGameSession' test.out

#- 38 PublicPromoteGameSessionLeader
# body param: body
echo '{"leaderID": "O4oKOcsZUbeZJJJy"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPromoteGameSessionLeader \
    --namespace $AB_NAMESPACE \
    --sessionId 'denJ93Kb1pQleHG1' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 38 'PublicPromoteGameSessionLeader' test.out

#- 39 LeaveGameSession
$CLI_EXE \
    --sn session \
    --op LeaveGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'UoswJzp9GPpGykMe' \
    > test.out 2>&1
eval_tap $? 39 'LeaveGameSession' test.out

#- 40 PublicGameSessionReject
$CLI_EXE \
    --sn session \
    --op PublicGameSessionReject \
    --namespace $AB_NAMESPACE \
    --sessionId 'pZ0J4UuZWR407SE9' \
    > test.out 2>&1
eval_tap $? 40 'PublicGameSessionReject' test.out

#- 41 AppendTeamGameSession
# body param: body
echo '{"additionalMembers": [{"partyID": "ddXzA6F73IwV8d2j", "userIDs": ["vk2NFEPFcj0B4pnG", "V0EaGDNAoaYeee5i", "UyPElT7mmAuOT58y"]}, {"partyID": "Ie9AzmsPC0C5hWQu", "userIDs": ["ueyPPcbPVe3xxdxV", "hu4rkZZo8fTr6agu", "nz2XzHsONpORaUZ5"]}, {"partyID": "73WSpmtV8p2sf0f3", "userIDs": ["uCNxJIMiWHlRKeE5", "RKhreFD6wFvnLOEQ", "R2tp6q9pPGaWcS02"]}], "proposedTeams": [{"UserIDs": ["LciOGbTW0UOPodtV", "EAHUTPJcWSRPDFdk", "QZDrW0M7eIDrifb9"], "parties": [{"partyID": "ovouuoyV36gCehJP", "userIDs": ["43Xpu5gyQ14gMP9Z", "4mEvMNjtERuv6NrO", "6SjBOH0izSSpVoq4"]}, {"partyID": "E6CtycfHMbZoBgzD", "userIDs": ["SnBtqToPbBDwdvFV", "FTK8mQqqA2VoUKBl", "sPXL4ibYVB9w0ETf"]}, {"partyID": "SauutS9JWgSB39nW", "userIDs": ["J0AdErhRmHmtCl6M", "85ELRv5NEe9bR9ck", "NLMJjsgaXBRR415W"]}]}, {"UserIDs": ["Jviuc5vA36xYMMPe", "p0zplFiRg22RpUVt", "QXjItygvyTYykvnB"], "parties": [{"partyID": "2kvfxE0sqbjAHF9Q", "userIDs": ["LlS2lC0QB41qRS25", "yYg5fkChtyUjcBHS", "hoy4rAmtQkeCoVHY"]}, {"partyID": "89b92PWEF9gisons", "userIDs": ["VtIIBDDZzSa012J2", "Vd3MaSmOIA08Q4Pe", "45ZkF7UCeoZEUNVK"]}, {"partyID": "jMQUM30waRuDKnw6", "userIDs": ["3w8ZD7GzTZ0WS0Zf", "kVqKowfa2xO5BhQt", "MYVHJohu8Sfs3a0o"]}]}, {"UserIDs": ["daQ1HgT2WnpHkT1L", "xGYzolfxvDyx6IAA", "OUeURiiiEgBQnBdC"], "parties": [{"partyID": "ORXu3yYfZ5p6HsVO", "userIDs": ["Dk8yYxP6eRLWH719", "H0S96d6o92O9JTph", "nwOfFzh20ovT23Tb"]}, {"partyID": "EK3bM30lxx1rT6fs", "userIDs": ["Ka4IgtUwYePFCH42", "h6LucfBcrN83Rs41", "H9Aya2Ugl7sPCMcC"]}, {"partyID": "q8KOF1FPASWEGLvH", "userIDs": ["i2yA6ZsXJoVWUuZ6", "fQXMhnC8iRACppkc", "2GjnJ6MqokeFNTOa"]}]}], "version": 24}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AppendTeamGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'k6IPw3luGBMK9OmE' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 41 'AppendTeamGameSession' test.out

#- 42 PublicPartyJoinCode
# body param: body
echo '{"code": "mytZjYEiOxHZltYd"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPartyJoinCode \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 42 'PublicPartyJoinCode' test.out

#- 43 PublicGetParty
$CLI_EXE \
    --sn session \
    --op PublicGetParty \
    --namespace $AB_NAMESPACE \
    --partyId 'ZOiBafLm9cc3OUVU' \
    > test.out 2>&1
eval_tap $? 43 'PublicGetParty' test.out

#- 44 PublicUpdateParty
# body param: body
echo '{"attributes": {"dC6vEQ0Fb0fOzSwV": {}, "rTe2Pix8IgOyJOxb": {}, "fiuUDdzfJOveiGtt": {}}, "inactiveTimeout": 18, "inviteTimeout": 36, "joinability": "AMIqwXxAtcjA062e", "maxPlayers": 99, "minPlayers": 28, "type": "CE2BZKl6Ks6ND0ev", "version": 23}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicUpdateParty \
    --namespace $AB_NAMESPACE \
    --partyId 'MbK98KZuPAGpzW8Y' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 44 'PublicUpdateParty' test.out

#- 45 PublicPatchUpdateParty
# body param: body
echo '{"attributes": {"EovlYXMD76ZVrjTw": {}, "BhG6PxRbXyacvJKv": {}, "H2fI227sFhXEPpER": {}}, "inactiveTimeout": 36, "inviteTimeout": 0, "joinability": "10WrTTWC1vHxSVm1", "maxPlayers": 37, "minPlayers": 92, "type": "RLDUorN8n8OKt3eb", "version": 93}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPatchUpdateParty \
    --namespace $AB_NAMESPACE \
    --partyId 'NJu2WkeGDSzlCaFt' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 45 'PublicPatchUpdateParty' test.out

#- 46 PublicGeneratePartyCode
$CLI_EXE \
    --sn session \
    --op PublicGeneratePartyCode \
    --namespace $AB_NAMESPACE \
    --partyId '7Cu0JKjLegxbCcIq' \
    > test.out 2>&1
eval_tap $? 46 'PublicGeneratePartyCode' test.out

#- 47 PublicRevokePartyCode
$CLI_EXE \
    --sn session \
    --op PublicRevokePartyCode \
    --namespace $AB_NAMESPACE \
    --partyId 'hcBHRl1tn7RtEGUE' \
    > test.out 2>&1
eval_tap $? 47 'PublicRevokePartyCode' test.out

#- 48 PublicPartyInvite
# body param: body
echo '{"platformID": "0zrKNm1qW2n5ceom", "userID": "ro5tLlKiW8dBlSc2"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPartyInvite \
    --namespace $AB_NAMESPACE \
    --partyId 'bkfxl91A6ODfId1v' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 48 'PublicPartyInvite' test.out

#- 49 PublicPromotePartyLeader
# body param: body
echo '{"leaderID": "J63xKDRbcNco2qPo"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPromotePartyLeader \
    --namespace $AB_NAMESPACE \
    --partyId 'fshHt88ZrOopYOMq' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 49 'PublicPromotePartyLeader' test.out

#- 50 PublicPartyJoin
$CLI_EXE \
    --sn session \
    --op PublicPartyJoin \
    --namespace $AB_NAMESPACE \
    --partyId 'bJVfyl0ssL0Nn5BZ' \
    > test.out 2>&1
eval_tap $? 50 'PublicPartyJoin' test.out

#- 51 PublicPartyLeave
$CLI_EXE \
    --sn session \
    --op PublicPartyLeave \
    --namespace $AB_NAMESPACE \
    --partyId 'z9qxx7lz9uMrrT54' \
    > test.out 2>&1
eval_tap $? 51 'PublicPartyLeave' test.out

#- 52 PublicPartyReject
$CLI_EXE \
    --sn session \
    --op PublicPartyReject \
    --namespace $AB_NAMESPACE \
    --partyId 'dKxRwFRslFsKiWo4' \
    > test.out 2>&1
eval_tap $? 52 'PublicPartyReject' test.out

#- 53 PublicPartyKick
$CLI_EXE \
    --sn session \
    --op PublicPartyKick \
    --namespace $AB_NAMESPACE \
    --partyId 'atNdaNIXOzCVa9Ca' \
    --userId 'E9mVJJqgitULlhI9' \
    > test.out 2>&1
eval_tap $? 53 'PublicPartyKick' test.out

#- 54 PublicCreateParty
# body param: body
echo '{"attributes": {"rKPyF7ytpQiDiCAh": {}, "2lkPXOOJp91w7ACg": {}, "mrezLCJKLPrwjeYe": {}}, "configurationName": "Ji9q4KUgzZZ6zaaA", "inactiveTimeout": 44, "inviteTimeout": 50, "joinability": "vKi9jeErSpDVNGzT", "maxPlayers": 71, "members": [{"ID": "fYLmyJHWVmJhvzYU", "PlatformID": "D7tt15VYMNdywySd", "PlatformUserID": "XRVEBpthoAfzvXP7"}, {"ID": "hfNyBM3W7FEjbI46", "PlatformID": "oLZUugcyZei70cPK", "PlatformUserID": "SdQKPk36TgDFyRpE"}, {"ID": "bkRLet6qHFzUAAIA", "PlatformID": "1yZDTGyGcJrX2a98", "PlatformUserID": "isrEnWec7CnvrRTj"}], "minPlayers": 98, "textChat": true, "type": "FQkVvDYodu7iPq7D"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicCreateParty \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 54 'PublicCreateParty' test.out

#- 55 PublicGetBulkPlayerCurrentPlatform
# body param: body
echo '{"userIDs": ["zyrwyqgey4TDsTGV", "cn6u2Y8kRSlfFVNt", "TCFUDbhXFUMPgIsF"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicGetBulkPlayerCurrentPlatform \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 55 'PublicGetBulkPlayerCurrentPlatform' test.out

#- 56 PublicGetPlayerAttributes
$CLI_EXE \
    --sn session \
    --op PublicGetPlayerAttributes \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 56 'PublicGetPlayerAttributes' test.out

#- 57 PublicStorePlayerAttributes
# body param: body
echo '{"crossplayEnabled": false, "currentPlatform": "crSgCYgV6hpjYneP", "data": {"7VkRsz0E1TgaU2K2": {}, "n1JMpCmLAckoGMrf": {}, "qXh9Yi9sIBQbGIIT": {}}, "platforms": [{"name": "psIRyQL5qeScWxFq", "userID": "Co2THUCSfVY7SEGO"}, {"name": "wWwVPMXi6TiqSRiB", "userID": "bSv5Mu9psphB22Gw"}, {"name": "YtWzihoA8UZno0up", "userID": "xwRKEKNIlaq2KS5y"}], "roles": ["US265k6o7P49D2nL", "cCMvTgskvERPzKX3", "k2xmrmuw7Xo6c48B"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicStorePlayerAttributes \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 57 'PublicStorePlayerAttributes' test.out

#- 58 PublicDeletePlayerAttributes
$CLI_EXE \
    --sn session \
    --op PublicDeletePlayerAttributes \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 58 'PublicDeletePlayerAttributes' test.out

#- 59 PublicQueryMyGameSessions
$CLI_EXE \
    --sn session \
    --op PublicQueryMyGameSessions \
    --namespace $AB_NAMESPACE \
    --order 'sc3cv7u2wN8c1Kpu' \
    --orderBy '4lqYfwmcvvAUS6Pz' \
    --status 'OOwSik7CwUa7LxQU' \
    > test.out 2>&1
eval_tap $? 59 'PublicQueryMyGameSessions' test.out

#- 60 PublicQueryMyParties
$CLI_EXE \
    --sn session \
    --op PublicQueryMyParties \
    --namespace $AB_NAMESPACE \
    --order 'Nu0laNJx3VND1Gqp' \
    --orderBy 'kJeCMYVGaGlXMirt' \
    --status 'Y3mMswJSdKiaNMrg' \
    > test.out 2>&1
eval_tap $? 60 'PublicQueryMyParties' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE