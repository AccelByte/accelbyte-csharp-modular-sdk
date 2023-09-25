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
echo "1..66"

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

#- 5 AdminListEnvironmentVariables
$CLI_EXE \
    --sn session \
    --op AdminListEnvironmentVariables \
    > test.out 2>&1
eval_tap $? 5 'AdminListEnvironmentVariables' test.out

#- 6 AdminGetConfigurationAlertV1
$CLI_EXE \
    --sn session \
    --op AdminGetConfigurationAlertV1 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 6 'AdminGetConfigurationAlertV1' test.out

#- 7 AdminUpdateConfigurationAlertV1
# body param: body
echo '{"durationDays": 60}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminUpdateConfigurationAlertV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 7 'AdminUpdateConfigurationAlertV1' test.out

#- 8 AdminCreateConfigurationAlertV1
# body param: body
echo '{"durationDays": 10}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminCreateConfigurationAlertV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 8 'AdminCreateConfigurationAlertV1' test.out

#- 9 AdminDeleteConfigurationAlertV1
$CLI_EXE \
    --sn session \
    --op AdminDeleteConfigurationAlertV1 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 9 'AdminDeleteConfigurationAlertV1' test.out

#- 10 AdminCreateConfigurationTemplateV1
# body param: body
echo '{"NativeSessionSetting": {"PSNServiceLabel": 51, "PSNSupportedPlatforms": ["FE5YK8tZ", "fLVZoaSq", "s4AzXjCN"], "SessionTitle": "d90yTiKT", "ShouldSync": false, "XboxServiceConfigID": "bP5OT6S4", "XboxSessionTemplateName": "YlzrIpac", "localizedSessionName": {"emdRitwg": {}, "weXLlSQw": {}, "xP3xVVkd": {}}}, "PSNBaseUrl": "TxD2vsfE", "autoJoin": true, "clientVersion": "3i03rHCT", "deployment": "O7DKGB6H", "dsSource": "v16FBAka", "fallbackClaimKeys": ["kw6mNNqW", "DHonN2Xy", "11Ek3nD6"], "immutableStorage": true, "inactiveTimeout": 40, "inviteTimeout": 88, "joinability": "MWKpjjSH", "maxActiveSessions": 75, "maxPlayers": 22, "minPlayers": 58, "name": "Sm4ELgJt", "persistent": true, "preferredClaimKeys": ["G9p9nQOh", "DIM3qF9u", "YHK8E7Tb"], "requestedRegions": ["fGrb8iLP", "1lfVde1B", "x0NWA0C6"], "textChat": true, "tieTeamsSessionLifetime": true, "type": "8ESY2DlD"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminCreateConfigurationTemplateV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 10 'AdminCreateConfigurationTemplateV1' test.out

#- 11 AdminGetAllConfigurationTemplatesV1
$CLI_EXE \
    --sn session \
    --op AdminGetAllConfigurationTemplatesV1 \
    --namespace $AB_NAMESPACE \
    --limit '28' \
    --name '9rk7BArG' \
    --offset '14' \
    --order 'RvUXZaAS' \
    --orderBy 'GwuiXkdC' \
    > test.out 2>&1
eval_tap $? 11 'AdminGetAllConfigurationTemplatesV1' test.out

#- 12 AdminGetConfigurationTemplateV1
$CLI_EXE \
    --sn session \
    --op AdminGetConfigurationTemplateV1 \
    --name '1KBiDu9y' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 12 'AdminGetConfigurationTemplateV1' test.out

#- 13 AdminUpdateConfigurationTemplateV1
# body param: body
echo '{"NativeSessionSetting": {"PSNServiceLabel": 77, "PSNSupportedPlatforms": ["yN2ofzxI", "APkyf1jD", "x7pe6h2p"], "SessionTitle": "q5gYcrGl", "ShouldSync": true, "XboxServiceConfigID": "aqfp2yMb", "XboxSessionTemplateName": "FuuEG5WB", "localizedSessionName": {"FIWAUbcr": {}, "TwyG9TFx": {}, "7YUqgks6": {}}}, "PSNBaseUrl": "83XkaRxX", "autoJoin": false, "clientVersion": "lc0uYNBv", "deployment": "RSSeofnF", "dsSource": "S7LjkNJd", "fallbackClaimKeys": ["UFV0AX0m", "BOpmdN6o", "m55vmhM5"], "immutableStorage": false, "inactiveTimeout": 36, "inviteTimeout": 74, "joinability": "4YFWsNFV", "maxActiveSessions": 84, "maxPlayers": 66, "minPlayers": 2, "name": "4uYmIrR3", "persistent": false, "preferredClaimKeys": ["wbQxZEX2", "n5R4NxaY", "Akt7Ca6B"], "requestedRegions": ["QRJ5pS4N", "OMM85VIf", "sD0ODNb6"], "textChat": false, "tieTeamsSessionLifetime": false, "type": "GfUsp6Oz"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminUpdateConfigurationTemplateV1 \
    --name '4HENdI5q' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 13 'AdminUpdateConfigurationTemplateV1' test.out

#- 14 AdminDeleteConfigurationTemplateV1
$CLI_EXE \
    --sn session \
    --op AdminDeleteConfigurationTemplateV1 \
    --name 'Y0hgX0dj' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 14 'AdminDeleteConfigurationTemplateV1' test.out

#- 15 AdminGetDSMCConfiguration
$CLI_EXE \
    --sn session \
    --op AdminGetDSMCConfiguration \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 15 'AdminGetDSMCConfiguration' test.out

#- 16 AdminSyncDSMCConfiguration
$CLI_EXE \
    --sn session \
    --op AdminSyncDSMCConfiguration \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 16 'AdminSyncDSMCConfiguration' test.out

#- 17 AdminQueryGameSessions
$CLI_EXE \
    --sn session \
    --op AdminQueryGameSessions \
    --namespace $AB_NAMESPACE \
    --configurationName 'C4ppM1Zg' \
    --dsPodName 'pVsVoDnZ' \
    --fromTime 'rhkIB2ot' \
    --gameMode 'zyFa2bTk' \
    --isPersistent 'w9HjC07U' \
    --isSoftDeleted 'XsKcoCHw' \
    --joinability '9Feg3fmv' \
    --limit '68' \
    --matchPool 'sX3ds0gb' \
    --memberID 'dpSKQTWi' \
    --offset '15' \
    --order 'sJsVKf0z' \
    --orderBy 'tWJVGtrF' \
    --sessionID 'Kd6rX00r' \
    --status 'ovu5tyJ6' \
    --statusV2 '1al14XlC' \
    --toTime 'PovjkmvQ' \
    > test.out 2>&1
eval_tap $? 17 'AdminQueryGameSessions' test.out

#- 18 AdminDeleteBulkGameSessions
# body param: body
echo '{"ids": ["ZBMoq7Kb", "Sfb8gSL1", "GHD9eyvV"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminDeleteBulkGameSessions \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 18 'AdminDeleteBulkGameSessions' test.out

#- 19 AdminUpdateGameSessionMember
$CLI_EXE \
    --sn session \
    --op AdminUpdateGameSessionMember \
    --memberId '4MQngCql' \
    --namespace $AB_NAMESPACE \
    --sessionId 'vS65TVUa' \
    --statusType 'jy4JbFr1' \
    > test.out 2>&1
eval_tap $? 19 'AdminUpdateGameSessionMember' test.out

#- 20 AdminQueryParties
$CLI_EXE \
    --sn session \
    --op AdminQueryParties \
    --namespace $AB_NAMESPACE \
    --joinability 'IRnEjyL0' \
    --key 'esLI4s7w' \
    --leaderID 'r2dAW8ga' \
    --limit '4' \
    --memberID 'ida3Mv2i' \
    --memberStatus '4z6woyGF' \
    --offset '71' \
    --order '3JWuVPQK' \
    --orderBy 'N2IeD1v9' \
    --partyID 'CKAgIYtx' \
    --value 'oBzGVyXt' \
    > test.out 2>&1
eval_tap $? 20 'AdminQueryParties' test.out

#- 21 AdminGetPlatformCredentials
$CLI_EXE \
    --sn session \
    --op AdminGetPlatformCredentials \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 21 'AdminGetPlatformCredentials' test.out

#- 22 AdminUpdatePlatformCredentials
# body param: body
echo '{"psn": {"clientId": "wCvVMAEB", "clientSecret": "J8ef7wXp", "scope": "cqKTbnhu"}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminUpdatePlatformCredentials \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 22 'AdminUpdatePlatformCredentials' test.out

#- 23 AdminDeletePlatformCredentials
$CLI_EXE \
    --sn session \
    --op AdminDeletePlatformCredentials \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 23 'AdminDeletePlatformCredentials' test.out

#- 24 AdminReadSessionStorage
$CLI_EXE \
    --sn session \
    --op AdminReadSessionStorage \
    --namespace $AB_NAMESPACE \
    --sessionId 'YxmFah8Q' \
    > test.out 2>&1
eval_tap $? 24 'AdminReadSessionStorage' test.out

#- 25 AdminDeleteUserSessionStorage
$CLI_EXE \
    --sn session \
    --op AdminDeleteUserSessionStorage \
    --namespace $AB_NAMESPACE \
    --sessionId 'j6zmbfCc' \
    > test.out 2>&1
eval_tap $? 25 'AdminDeleteUserSessionStorage' test.out

#- 26 AdminReadUserSessionStorage
$CLI_EXE \
    --sn session \
    --op AdminReadUserSessionStorage \
    --namespace $AB_NAMESPACE \
    --sessionId '5dTXyNXE' \
    --userId '8UtAWsJm' \
    > test.out 2>&1
eval_tap $? 26 'AdminReadUserSessionStorage' test.out

#- 27 AdminQueryPlayerAttributes
$CLI_EXE \
    --sn session \
    --op AdminQueryPlayerAttributes \
    --namespace $AB_NAMESPACE \
    --users 'nhtFphSW' \
    > test.out 2>&1
eval_tap $? 27 'AdminQueryPlayerAttributes' test.out

#- 28 AdminGetPlayerAttributes
$CLI_EXE \
    --sn session \
    --op AdminGetPlayerAttributes \
    --namespace $AB_NAMESPACE \
    --userId 'RWXrWW2q' \
    > test.out 2>&1
eval_tap $? 28 'AdminGetPlayerAttributes' test.out

#- 29 CreateGameSession
# body param: body
echo '{"attributes": {"BJAhgPUo": {}, "A4x2au3x": {}, "Z9rYG4kM": {}}, "autoJoin": true, "backfillTicketID": "me2ASgIu", "clientVersion": "rJVq0QTW", "configurationName": "inW8dAcr", "deployment": "3190PZG9", "dsSource": "cFULMKSD", "fallbackClaimKeys": ["nKg5ppxt", "TX3MqWz2", "HwoW14Cp"], "inactiveTimeout": 77, "inviteTimeout": 30, "joinability": "AY08w6Y8", "matchPool": "1xTeOIBw", "maxPlayers": 81, "minPlayers": 67, "preferredClaimKeys": ["N0s8lMA1", "9ICHd963", "uuFJITKQ"], "requestedRegions": ["fAFVTKVJ", "pyi3MhFU", "h4aYozQE"], "serverName": "TAoXejh0", "teams": [{"UserIDs": ["gZm6nKxv", "f5ykoBsR", "uyJfhAGX"], "parties": [{"partyID": "Zs16VXH3", "userIDs": ["702f5ZO0", "3xFoajxo", "TZAPQleE"]}, {"partyID": "uyFrKdII", "userIDs": ["Kr3fkDRd", "XLUuFoGQ", "CEVcTxnj"]}, {"partyID": "DJrh3HFE", "userIDs": ["vOFt5dtK", "0Z09QFFi", "oflz7Jhv"]}]}, {"UserIDs": ["tUu7Z8M5", "HG45HmDW", "Uk1G78rd"], "parties": [{"partyID": "e2gh9ZoT", "userIDs": ["RDwhKSeZ", "8ErMNBp8", "AuV7LKKe"]}, {"partyID": "VTYPmTOW", "userIDs": ["UH9DPZ8n", "gLMfRecN", "b6PELJe8"]}, {"partyID": "aN94HE0W", "userIDs": ["h6pNjqtz", "wXxZNt69", "hrDwgY0Z"]}]}, {"UserIDs": ["WsfQpxMb", "IXry8dny", "WNuKzhm0"], "parties": [{"partyID": "WzAza9sm", "userIDs": ["4zLg7JDN", "XcfEVgrM", "IQOGXXgf"]}, {"partyID": "ACEUUKH3", "userIDs": ["hSjfStxP", "u3EBNvmF", "3vKJTOV8"]}, {"partyID": "4w1Rb1tD", "userIDs": ["7erkeqto", "jpuf09GQ", "tHyV99SJ"]}]}], "textChat": true, "ticketIDs": ["gjfJFqdv", "GUL1Vx8X", "8gFoD4CQ"], "tieTeamsSessionLifetime": false, "type": "ku8mbdff"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op CreateGameSession \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 29 'CreateGameSession' test.out

#- 30 PublicQueryGameSessions
# body param: body
echo '{"z3aMVK26": {}, "ODkTQvz9": {}, "lWTpD4Sj": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicQueryGameSessions \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 30 'PublicQueryGameSessions' test.out

#- 31 PublicSessionJoinCode
# body param: body
echo '{"code": "XLVkvcfa"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicSessionJoinCode \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 31 'PublicSessionJoinCode' test.out

#- 32 GetGameSessionByPodName
$CLI_EXE \
    --sn session \
    --op GetGameSessionByPodName \
    --namespace $AB_NAMESPACE \
    --podName 'j4fpRKky' \
    > test.out 2>&1
eval_tap $? 32 'GetGameSessionByPodName' test.out

#- 33 GetGameSession
$CLI_EXE \
    --sn session \
    --op GetGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'Bqe7To9e' \
    > test.out 2>&1
eval_tap $? 33 'GetGameSession' test.out

#- 34 UpdateGameSession
# body param: body
echo '{"attributes": {"8tJ3VSRE": {}, "38HTXgNS": {}, "4VXjcYBs": {}}, "backfillTicketID": "d8I9tKR3", "clientVersion": "I6z3Mubv", "deployment": "nbuBMNev", "fallbackClaimKeys": ["4yeV8VFb", "fxAR3Si6", "tiPSs8k4"], "inactiveTimeout": 90, "inviteTimeout": 61, "joinability": "fukZfPeN", "matchPool": "LFZsEn6j", "maxPlayers": 18, "minPlayers": 21, "preferredClaimKeys": ["B12T73pI", "bq5Eymhq", "snSLJevY"], "requestedRegions": ["8ghlFDrH", "xfrPg27F", "HcDLwvDj"], "teams": [{"UserIDs": ["sJqXD65C", "DG6VCBPw", "0TY9MPco"], "parties": [{"partyID": "hPbwqewu", "userIDs": ["qSitYeQP", "vlnU735x", "LM9jgZuM"]}, {"partyID": "mycaD8pE", "userIDs": ["OBc5z8f0", "YBLMi7tM", "6C0kqj4z"]}, {"partyID": "VrSFDa5H", "userIDs": ["I0IG0m3j", "kzwE0QxK", "aSqLa6Dv"]}]}, {"UserIDs": ["OhJlcaY9", "aFlVkgsS", "aOOC3rlJ"], "parties": [{"partyID": "aIy3K7xs", "userIDs": ["KYAtuGgR", "fdKYBrlo", "UwDAQC72"]}, {"partyID": "ennd6dyM", "userIDs": ["Xxeq1qve", "fSRsY5NS", "lyAEgid3"]}, {"partyID": "ioImTKIZ", "userIDs": ["u29Bo7mt", "R79bDYst", "mqqnZuF9"]}]}, {"UserIDs": ["s6gkejEu", "B5hYUVIG", "mhOpxxrH"], "parties": [{"partyID": "2ovKYRMw", "userIDs": ["MM9zHxNQ", "9GQkFY3W", "On2HnXf1"]}, {"partyID": "l2u1v9lR", "userIDs": ["tE8T4QD4", "r8msNAG3", "mscNtn3C"]}, {"partyID": "ZfVP1fqF", "userIDs": ["JFHTBZwF", "DmgM5Oqv", "ifdefceA"]}]}], "ticketIDs": ["V2SjrhrS", "jDFtnkfH", "NYHp6JQa"], "tieTeamsSessionLifetime": false, "type": "j5MzTIVH", "version": 94}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op UpdateGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'uy9PXTTz' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 34 'UpdateGameSession' test.out

#- 35 DeleteGameSession
$CLI_EXE \
    --sn session \
    --op DeleteGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'ioC4Jvxu' \
    > test.out 2>&1
eval_tap $? 35 'DeleteGameSession' test.out

#- 36 PatchUpdateGameSession
# body param: body
echo '{"attributes": {"vCAZc8QG": {}, "kDGsUOfu": {}, "c7Ib85S2": {}}, "backfillTicketID": "i4HN1zq6", "clientVersion": "rjwvM9Ut", "deployment": "gZssqA9N", "fallbackClaimKeys": ["XbJ0du4G", "LIy4XsAW", "msppX6Xs"], "inactiveTimeout": 39, "inviteTimeout": 27, "joinability": "x8o6etDs", "matchPool": "NMFwV2PO", "maxPlayers": 67, "minPlayers": 36, "preferredClaimKeys": ["KEkC1TUu", "xM1n3YnC", "IJj0Qocr"], "requestedRegions": ["fjjI2Xw7", "Xns29jZE", "1FvaCvuF"], "teams": [{"UserIDs": ["Y4fGD4xk", "AwL87xaV", "PaFKG7mf"], "parties": [{"partyID": "ml72A0rF", "userIDs": ["5PXzmteQ", "xIXU7kdB", "0mbIywHm"]}, {"partyID": "S5cYc0vV", "userIDs": ["AlduthL8", "EqebEfjX", "EYFL2Nzr"]}, {"partyID": "SgBkhz74", "userIDs": ["XNFE6nBu", "VoRfPAQ9", "XqGDAv3o"]}]}, {"UserIDs": ["wftaAEmx", "bHPA0plS", "jfLT3yyq"], "parties": [{"partyID": "oZpmMha8", "userIDs": ["LvKVG3a6", "Xse1YSnn", "lHYXNEal"]}, {"partyID": "u5sGB2te", "userIDs": ["Z6QmKjuM", "W5phCRgb", "rOfbuBEr"]}, {"partyID": "IAcIXppq", "userIDs": ["w19nJHqG", "WAVnSJBr", "DV8oRtYV"]}]}, {"UserIDs": ["BF2DnGbY", "WCrIgYSL", "HpDJOsRg"], "parties": [{"partyID": "vsG2jX4n", "userIDs": ["79WO71dh", "oWuqiRtG", "HnyjJ5XQ"]}, {"partyID": "Vd9k6hAL", "userIDs": ["20vSZnQN", "BcgBEIl7", "lDYJncXy"]}, {"partyID": "HVmVZCXq", "userIDs": ["LlXbMbg1", "HaazE2Y3", "iGdE9U6q"]}]}], "ticketIDs": ["sg0PwvMB", "D7WGWZel", "Z3lbHWX6"], "tieTeamsSessionLifetime": false, "type": "FrEm3wDM", "version": 58}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PatchUpdateGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'gdbV7Tj2' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 36 'PatchUpdateGameSession' test.out

#- 37 UpdateGameSessionBackfillTicketID
# body param: body
echo '{"backfillTicketID": "clKZzW2W"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op UpdateGameSessionBackfillTicketID \
    --namespace $AB_NAMESPACE \
    --sessionId 'yLZkNudt' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 37 'UpdateGameSessionBackfillTicketID' test.out

#- 38 GameSessionGenerateCode
$CLI_EXE \
    --sn session \
    --op GameSessionGenerateCode \
    --namespace $AB_NAMESPACE \
    --sessionId 'sJotT6lT' \
    > test.out 2>&1
eval_tap $? 38 'GameSessionGenerateCode' test.out

#- 39 PublicRevokeGameSessionCode
$CLI_EXE \
    --sn session \
    --op PublicRevokeGameSessionCode \
    --namespace $AB_NAMESPACE \
    --sessionId '55Faz6NJ' \
    > test.out 2>&1
eval_tap $? 39 'PublicRevokeGameSessionCode' test.out

#- 40 PublicGameSessionInvite
# body param: body
echo '{"platformID": "bjNLoT4s", "userID": "vJtOfUNI"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicGameSessionInvite \
    --namespace $AB_NAMESPACE \
    --sessionId 'plS89CWP' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 40 'PublicGameSessionInvite' test.out

#- 41 JoinGameSession
$CLI_EXE \
    --sn session \
    --op JoinGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'AfQltKcx' \
    > test.out 2>&1
eval_tap $? 41 'JoinGameSession' test.out

#- 42 PublicPromoteGameSessionLeader
# body param: body
echo '{"leaderID": "gNc3d6kj"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPromoteGameSessionLeader \
    --namespace $AB_NAMESPACE \
    --sessionId 'uufpNxj3' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 42 'PublicPromoteGameSessionLeader' test.out

#- 43 LeaveGameSession
$CLI_EXE \
    --sn session \
    --op LeaveGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'C6EaNtsw' \
    > test.out 2>&1
eval_tap $? 43 'LeaveGameSession' test.out

#- 44 PublicGameSessionReject
$CLI_EXE \
    --sn session \
    --op PublicGameSessionReject \
    --namespace $AB_NAMESPACE \
    --sessionId 'qrTpwVa2' \
    > test.out 2>&1
eval_tap $? 44 'PublicGameSessionReject' test.out

#- 45 AppendTeamGameSession
# body param: body
echo '{"additionalMembers": [{"partyID": "uWzajfeV", "userIDs": ["ZZtEE2fh", "vWJ5V0LV", "C6t3Gg9T"]}, {"partyID": "svIC4ttl", "userIDs": ["N3SwiB4t", "EHxZLD2l", "o4aJABgL"]}, {"partyID": "AQXUXVxw", "userIDs": ["mK2JXitC", "tSgQgD33", "1ByDivbp"]}], "proposedTeams": [{"UserIDs": ["M4wvMTN1", "jh7vhoCZ", "iQQD5HTN"], "parties": [{"partyID": "gTmv6zPk", "userIDs": ["eO84sXKA", "heY9GW8O", "7gRBjJT7"]}, {"partyID": "scFXejF9", "userIDs": ["CQ6Irb0s", "SimwRau6", "lCz7IcoS"]}, {"partyID": "qKADvcfB", "userIDs": ["4yVAf1cF", "yjnoCV5N", "yzJqb1Nh"]}]}, {"UserIDs": ["IPnMEeaO", "1Q8PxepR", "MqLYEfc5"], "parties": [{"partyID": "N1uibOzy", "userIDs": ["bQRxzXHY", "kucqHGJw", "lpcmKeIX"]}, {"partyID": "OYzMD7Li", "userIDs": ["ab6Hz7ni", "Pnkbsxf5", "VRQt2D2f"]}, {"partyID": "taOyvr7o", "userIDs": ["9Kj2B0Dh", "lIhTpO3K", "JNF0AHyK"]}]}, {"UserIDs": ["VwBsZyde", "y507JKeD", "iK6zEfyB"], "parties": [{"partyID": "Bh71QynB", "userIDs": ["U2xAVchS", "6HZpuzkg", "hlaEU7oW"]}, {"partyID": "vKay8OMl", "userIDs": ["IA611xJN", "ZRMr7LEL", "Ck1pAq6J"]}, {"partyID": "hKaPaCOL", "userIDs": ["4e31GNAU", "yUYqVAPr", "30Xcdyft"]}]}], "version": 34}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AppendTeamGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 't8UfXP6q' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 45 'AppendTeamGameSession' test.out

#- 46 PublicPartyJoinCode
# body param: body
echo '{"code": "CBb6j7UY"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPartyJoinCode \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 46 'PublicPartyJoinCode' test.out

#- 47 PublicGetParty
$CLI_EXE \
    --sn session \
    --op PublicGetParty \
    --namespace $AB_NAMESPACE \
    --partyId 'YyaXm4Xx' \
    > test.out 2>&1
eval_tap $? 47 'PublicGetParty' test.out

#- 48 PublicUpdateParty
# body param: body
echo '{"attributes": {"6ZSEYGKk": {}, "Z45tynzC": {}, "4ArD9Fv8": {}}, "inactiveTimeout": 31, "inviteTimeout": 74, "joinability": "6ys0Wkha", "maxPlayers": 87, "minPlayers": 0, "type": "3EwVihTL", "version": 73}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicUpdateParty \
    --namespace $AB_NAMESPACE \
    --partyId 'TFooQfss' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 48 'PublicUpdateParty' test.out

#- 49 PublicPatchUpdateParty
# body param: body
echo '{"attributes": {"wUQvV9Kv": {}, "YaLwkrWA": {}, "niai1tkN": {}}, "inactiveTimeout": 3, "inviteTimeout": 14, "joinability": "YLBLM86p", "maxPlayers": 67, "minPlayers": 67, "type": "OOk98v4i", "version": 12}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPatchUpdateParty \
    --namespace $AB_NAMESPACE \
    --partyId 'WUsEQpzq' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 49 'PublicPatchUpdateParty' test.out

#- 50 PublicGeneratePartyCode
$CLI_EXE \
    --sn session \
    --op PublicGeneratePartyCode \
    --namespace $AB_NAMESPACE \
    --partyId 'EHBRUjFg' \
    > test.out 2>&1
eval_tap $? 50 'PublicGeneratePartyCode' test.out

#- 51 PublicRevokePartyCode
$CLI_EXE \
    --sn session \
    --op PublicRevokePartyCode \
    --namespace $AB_NAMESPACE \
    --partyId 'cowclSjv' \
    > test.out 2>&1
eval_tap $? 51 'PublicRevokePartyCode' test.out

#- 52 PublicPartyInvite
# body param: body
echo '{"platformID": "8D6CpCYY", "userID": "EDkn8laP"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPartyInvite \
    --namespace $AB_NAMESPACE \
    --partyId 'r3HG2NAC' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 52 'PublicPartyInvite' test.out

#- 53 PublicPromotePartyLeader
# body param: body
echo '{"leaderID": "ZYGtuI85"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPromotePartyLeader \
    --namespace $AB_NAMESPACE \
    --partyId 'KpS9rAcs' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 53 'PublicPromotePartyLeader' test.out

#- 54 PublicPartyJoin
$CLI_EXE \
    --sn session \
    --op PublicPartyJoin \
    --namespace $AB_NAMESPACE \
    --partyId 'DdyL5KLp' \
    > test.out 2>&1
eval_tap $? 54 'PublicPartyJoin' test.out

#- 55 PublicPartyLeave
$CLI_EXE \
    --sn session \
    --op PublicPartyLeave \
    --namespace $AB_NAMESPACE \
    --partyId 'nbg6ZdqA' \
    > test.out 2>&1
eval_tap $? 55 'PublicPartyLeave' test.out

#- 56 PublicPartyReject
$CLI_EXE \
    --sn session \
    --op PublicPartyReject \
    --namespace $AB_NAMESPACE \
    --partyId 'KAosvoiC' \
    > test.out 2>&1
eval_tap $? 56 'PublicPartyReject' test.out

#- 57 PublicPartyKick
$CLI_EXE \
    --sn session \
    --op PublicPartyKick \
    --namespace $AB_NAMESPACE \
    --partyId 'YyhkHjye' \
    --userId 'nH4Hm0VB' \
    > test.out 2>&1
eval_tap $? 57 'PublicPartyKick' test.out

#- 58 PublicCreateParty
# body param: body
echo '{"attributes": {"2ecbaATD": {}, "b0HIEU97": {}, "uCpEi9LB": {}}, "configurationName": "2T9qqhZK", "inactiveTimeout": 95, "inviteTimeout": 62, "joinability": "0fTzuIjG", "maxPlayers": 49, "members": [{"ID": "WxYRjHqm", "PlatformID": "LUeSRPYl", "PlatformUserID": "BMbRvt0C"}, {"ID": "aYp46VRy", "PlatformID": "CtQkzFyP", "PlatformUserID": "aIEPKPmT"}, {"ID": "7UMbFBMP", "PlatformID": "g1a3ffXi", "PlatformUserID": "av1pnNpu"}], "minPlayers": 54, "textChat": false, "type": "ol6OjWpN"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicCreateParty \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 58 'PublicCreateParty' test.out

#- 59 PublicUpdateInsertSessionStorageLeader
# body param: body
echo '{"qx4JUzBe": {}, "xDTueaSs": {}, "JLrVybJz": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicUpdateInsertSessionStorageLeader \
    --namespace $AB_NAMESPACE \
    --sessionId 'Lrl6ywmi' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 59 'PublicUpdateInsertSessionStorageLeader' test.out

#- 60 PublicUpdateInsertSessionStorage
# body param: body
echo '{"26PAoq11": {}, "Vae4cf2y": {}, "Yus4stP5": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicUpdateInsertSessionStorage \
    --namespace $AB_NAMESPACE \
    --sessionId 'fldtprmf' \
    --userId 'eqoyBBb8' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 60 'PublicUpdateInsertSessionStorage' test.out

#- 61 PublicGetBulkPlayerCurrentPlatform
# body param: body
echo '{"userIDs": ["332HnZ45", "IauJyFNp", "TJHZpEtI"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicGetBulkPlayerCurrentPlatform \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 61 'PublicGetBulkPlayerCurrentPlatform' test.out

#- 62 PublicGetPlayerAttributes
$CLI_EXE \
    --sn session \
    --op PublicGetPlayerAttributes \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 62 'PublicGetPlayerAttributes' test.out

#- 63 PublicStorePlayerAttributes
# body param: body
echo '{"crossplayEnabled": false, "currentPlatform": "Us56mbze", "data": {"oVYM8kxi": {}, "Pn05c6k9": {}, "dqg3o8ms": {}}, "platforms": [{"name": "AiVcEDom", "userID": "1cqpgl4U"}, {"name": "JZg0cRUB", "userID": "WMEGeoem"}, {"name": "fyrvCO2w", "userID": "tNa5rwGL"}], "roles": ["ImoiCpRE", "o8LeLP2u", "QUBGkFXT"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicStorePlayerAttributes \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 63 'PublicStorePlayerAttributes' test.out

#- 64 PublicDeletePlayerAttributes
$CLI_EXE \
    --sn session \
    --op PublicDeletePlayerAttributes \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 64 'PublicDeletePlayerAttributes' test.out

#- 65 PublicQueryMyGameSessions
$CLI_EXE \
    --sn session \
    --op PublicQueryMyGameSessions \
    --namespace $AB_NAMESPACE \
    --order 'qSwrh6lF' \
    --orderBy 'KS1V9t1h' \
    --status 'rvP85JJD' \
    > test.out 2>&1
eval_tap $? 65 'PublicQueryMyGameSessions' test.out

#- 66 PublicQueryMyParties
$CLI_EXE \
    --sn session \
    --op PublicQueryMyParties \
    --namespace $AB_NAMESPACE \
    --order 'R0fEpPqS' \
    --orderBy 'OsFm5dY5' \
    --status 'TeBmDO40' \
    > test.out 2>&1
eval_tap $? 66 'PublicQueryMyParties' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE