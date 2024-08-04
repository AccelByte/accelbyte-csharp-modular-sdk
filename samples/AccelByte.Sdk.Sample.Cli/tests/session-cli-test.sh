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
echo "1..85"

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

#- 4 AdminGetLogConfig
$CLI_EXE \
    --sn session \
    --op AdminGetLogConfig \
    > test.out 2>&1
eval_tap $? 4 'AdminGetLogConfig' test.out

#- 5 AdminPatchUpdateLogConfig
# body param: body
echo '{"logLevel": "info"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminPatchUpdateLogConfig \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 5 'AdminPatchUpdateLogConfig' test.out

#- 6 AdminGetDSMCConfigurationDefault
$CLI_EXE \
    --sn session \
    --op AdminGetDSMCConfigurationDefault \
    > test.out 2>&1
eval_tap $? 6 'AdminGetDSMCConfigurationDefault' test.out

#- 7 AdminListEnvironmentVariables
$CLI_EXE \
    --sn session \
    --op AdminListEnvironmentVariables \
    > test.out 2>&1
eval_tap $? 7 'AdminListEnvironmentVariables' test.out

#- 8 AdminListGlobalConfiguration
$CLI_EXE \
    --sn session \
    --op AdminListGlobalConfiguration \
    > test.out 2>&1
eval_tap $? 8 'AdminListGlobalConfiguration' test.out

#- 9 AdminUpdateGlobalConfiguration
# body param: body
echo '{"metricExcludedNamespaces": ["OG8fylR8", "BXaFETbp", "ysPCN4p6"], "regionRetryMapping": {"pS7fvjBQ": ["vVsOQj8p", "TdcIKVB0", "jFUlhOZs"], "meZSBINz": ["ccd5wD5E", "R1PxxGwl", "mHNaduPP"], "j6nbheb7": ["tmqtFPvn", "MN3aLDUC", "Hsg3C6h3"]}, "regionURLMapping": ["sRxR4Zik", "De8XaIaK", "qcquvGgg"], "testGameMode": "WuvSoMaM", "testRegionURLMapping": ["Zk0ul8b1", "nYG8ONev", "Hr30MjHi"], "testTargetUserIDs": ["uc9GiDQ1", "FO5xJFBP", "QWisawjW"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminUpdateGlobalConfiguration \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 9 'AdminUpdateGlobalConfiguration' test.out

#- 10 AdminDeleteGlobalConfiguration
$CLI_EXE \
    --sn session \
    --op AdminDeleteGlobalConfiguration \
    > test.out 2>&1
eval_tap $? 10 'AdminDeleteGlobalConfiguration' test.out

#- 11 AdminGetConfigurationAlertV1
$CLI_EXE \
    --sn session \
    --op AdminGetConfigurationAlertV1 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 11 'AdminGetConfigurationAlertV1' test.out

#- 12 AdminUpdateConfigurationAlertV1
# body param: body
echo '{"durationDays": 62}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminUpdateConfigurationAlertV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 12 'AdminUpdateConfigurationAlertV1' test.out

#- 13 AdminCreateConfigurationAlertV1
# body param: body
echo '{"durationDays": 38}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminCreateConfigurationAlertV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 13 'AdminCreateConfigurationAlertV1' test.out

#- 14 AdminDeleteConfigurationAlertV1
$CLI_EXE \
    --sn session \
    --op AdminDeleteConfigurationAlertV1 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 14 'AdminDeleteConfigurationAlertV1' test.out

#- 15 HandleUploadXboxPFXCertificate
# form data upload: file
echo 'tmp.dat' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --sn session \
    --op HandleUploadXboxPFXCertificate \
    --namespace $AB_NAMESPACE \
    --description 'WjuQwz3x' \
    --certname 'LtZB46FB' \
    --upload file $TEMP_FILE_UPLOAD \
    --password 'lEb2r1Th' \
    > test.out 2>&1
eval_tap $? 15 'HandleUploadXboxPFXCertificate' test.out

#- 16 AdminCreateConfigurationTemplateV1
# body param: body
echo '{"NativeSessionSetting": {"PSNServiceLabel": 8, "PSNSupportedPlatforms": ["Fj9xToEG", "vyIrFOrW", "GRpE18og"], "SessionTitle": "XOpm6t7s", "ShouldSync": false, "XboxAllowCrossPlatform": false, "XboxSandboxID": "hMH3ZgRu", "XboxServiceConfigID": "yJ0PeVoF", "XboxSessionTemplateName": "bYEtMMGj", "XboxTitleID": "hRND71Cc", "localizedSessionName": {"LUeAg9YH": {}, "aajvfbXR": {}, "KJ33l7gB": {}}}, "PSNBaseUrl": "vMn9voEX", "appName": "ODyCDXCC", "attributes": {"pLQAFhM5": {}, "cZFVrGcn": {}, "07QWJLY7": {}}, "autoJoin": false, "autoLeaveSession": true, "clientVersion": "0gSnuDbF", "customURLGRPC": "iccnxov3", "deployment": "1XJYJzsO", "disableCodeGeneration": true, "disableResendInvite": false, "dsManualSetReady": true, "dsSource": "iIIwpg61", "enableSecret": true, "fallbackClaimKeys": ["GJW1vNdb", "XQYGaFZY", "C4cnrHkf"], "immutableStorage": true, "inactiveTimeout": 50, "inviteTimeout": 53, "joinability": "SIu7z2xL", "leaderElectionGracePeriod": 95, "manualRejoin": true, "maxActiveSessions": 69, "maxPlayers": 46, "minPlayers": 93, "name": "SJ279g2J", "persistent": false, "preferredClaimKeys": ["zrMxFKVf", "thD0qPBC", "2cTkyB5K"], "requestedRegions": ["qnlUSYOl", "4BFMELZM", "8P5AXT3T"], "textChat": true, "tieTeamsSessionLifetime": true, "type": "CZfrdsWZ"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminCreateConfigurationTemplateV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 16 'AdminCreateConfigurationTemplateV1' test.out

#- 17 AdminGetAllConfigurationTemplatesV1
$CLI_EXE \
    --sn session \
    --op AdminGetAllConfigurationTemplatesV1 \
    --namespace $AB_NAMESPACE \
    --limit '75' \
    --name '6KByPj12' \
    --offset '18' \
    --order 'C9KfhY85' \
    --orderBy 'ZaTIvJMO' \
    > test.out 2>&1
eval_tap $? 17 'AdminGetAllConfigurationTemplatesV1' test.out

#- 18 AdminGetConfigurationTemplateV1
$CLI_EXE \
    --sn session \
    --op AdminGetConfigurationTemplateV1 \
    --name 'El8J3Bph' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 18 'AdminGetConfigurationTemplateV1' test.out

#- 19 AdminUpdateConfigurationTemplateV1
# body param: body
echo '{"NativeSessionSetting": {"PSNServiceLabel": 1, "PSNSupportedPlatforms": ["GO5CZsJl", "Rrdq9GbV", "nKITeLML"], "SessionTitle": "I84NFnpm", "ShouldSync": false, "XboxAllowCrossPlatform": false, "XboxSandboxID": "9IAvxPpZ", "XboxServiceConfigID": "1JJdTa7v", "XboxSessionTemplateName": "l1otrE0V", "XboxTitleID": "lDLQXMux", "localizedSessionName": {"H0BCdfWy": {}, "wtD33kOO": {}, "8UxNU1HS": {}}}, "PSNBaseUrl": "xMp0Yyde", "appName": "3b8HCHDg", "attributes": {"L9a30a9m": {}, "m1lPgKyk": {}, "9HT1D66c": {}}, "autoJoin": true, "autoLeaveSession": false, "clientVersion": "1Lhq6ONi", "customURLGRPC": "juxWHb9u", "deployment": "NXp98YvI", "disableCodeGeneration": false, "disableResendInvite": false, "dsManualSetReady": false, "dsSource": "XwPWcX7K", "enableSecret": true, "fallbackClaimKeys": ["PrTS2Q8m", "IQpNwyCa", "1ywLPX2T"], "immutableStorage": true, "inactiveTimeout": 20, "inviteTimeout": 83, "joinability": "7VdfSzTR", "leaderElectionGracePeriod": 47, "manualRejoin": false, "maxActiveSessions": 89, "maxPlayers": 96, "minPlayers": 18, "name": "jlhlQ1aH", "persistent": false, "preferredClaimKeys": ["d6xqU1qs", "cMzqC0S3", "PEmBOJLg"], "requestedRegions": ["L59JZpZ7", "JLTfBz84", "8KqvDjQV"], "textChat": false, "tieTeamsSessionLifetime": false, "type": "m1iABlPB"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminUpdateConfigurationTemplateV1 \
    --name 'ySJie0oC' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 19 'AdminUpdateConfigurationTemplateV1' test.out

#- 20 AdminDeleteConfigurationTemplateV1
$CLI_EXE \
    --sn session \
    --op AdminDeleteConfigurationTemplateV1 \
    --name 'mkQyrMfe' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 20 'AdminDeleteConfigurationTemplateV1' test.out

#- 21 AdminGetMemberActiveSession
$CLI_EXE \
    --sn session \
    --op AdminGetMemberActiveSession \
    --name 'gxqjGzIB' \
    --namespace $AB_NAMESPACE \
    --userId 'AvActcFF' \
    > test.out 2>&1
eval_tap $? 21 'AdminGetMemberActiveSession' test.out

#- 22 AdminReconcileMaxActiveSession
# body param: body
echo '{"userID": "YubStCD5"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminReconcileMaxActiveSession \
    --name 'QosqLP1f' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 22 'AdminReconcileMaxActiveSession' test.out

#- 23 AdminGetDSMCConfiguration
$CLI_EXE \
    --sn session \
    --op AdminGetDSMCConfiguration \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 23 'AdminGetDSMCConfiguration' test.out

#- 24 AdminSyncDSMCConfiguration
$CLI_EXE \
    --sn session \
    --op AdminSyncDSMCConfiguration \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 24 'AdminSyncDSMCConfiguration' test.out

#- 25 AdminQueryGameSessions
$CLI_EXE \
    --sn session \
    --op AdminQueryGameSessions \
    --namespace $AB_NAMESPACE \
    --configurationName 'N9sIlfXM' \
    --dsPodName 'Z3TpKLJ5' \
    --fromTime 'uPQuS9q6' \
    --gameMode 'xhOz70qr' \
    --isPersistent 'cXxr5WSh' \
    --isSoftDeleted 'JhdP3duo' \
    --joinability 'JWEXioAX' \
    --limit '86' \
    --matchPool 'rtUL8gx1' \
    --memberID '1RmlObKd' \
    --offset '49' \
    --order '39FoF9KN' \
    --orderBy '8z9Xkw7S' \
    --sessionID 'JzQOAFIF' \
    --status 'ASJIbx35' \
    --statusV2 'Z6gt9Xmt' \
    --toTime 'DcI09Ym7' \
    > test.out 2>&1
eval_tap $? 25 'AdminQueryGameSessions' test.out

#- 26 AdminQueryGameSessionsByAttributes
# body param: body
echo '{"xtd2pcJ4": {}, "UpxzTHzR": {}, "o7L9BjvP": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminQueryGameSessionsByAttributes \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 26 'AdminQueryGameSessionsByAttributes' test.out

#- 27 AdminDeleteBulkGameSessions
# body param: body
echo '{"ids": ["zwxr9yOt", "sbePcDYH", "V9TSfHfY"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminDeleteBulkGameSessions \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 27 'AdminDeleteBulkGameSessions' test.out

#- 28 AdminSetDSReady
# body param: body
echo '{"ready": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminSetDSReady \
    --namespace $AB_NAMESPACE \
    --sessionId 'ysdyU3tO' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 28 'AdminSetDSReady' test.out

#- 29 AdminUpdateGameSessionMember
$CLI_EXE \
    --sn session \
    --op AdminUpdateGameSessionMember \
    --memberId 'tmBLq4lj' \
    --namespace $AB_NAMESPACE \
    --sessionId 'D8peY68m' \
    --statusType 'VttvLOBC' \
    > test.out 2>&1
eval_tap $? 29 'AdminUpdateGameSessionMember' test.out

#- 30 AdminGetListNativeSession
$CLI_EXE \
    --sn session \
    --op AdminGetListNativeSession \
    --namespace $AB_NAMESPACE \
    --limit '78' \
    --offset '81' \
    --order 'Mgl6WtSO' \
    > test.out 2>&1
eval_tap $? 30 'AdminGetListNativeSession' test.out

#- 31 AdminQueryParties
$CLI_EXE \
    --sn session \
    --op AdminQueryParties \
    --namespace $AB_NAMESPACE \
    --isSoftDeleted 'KszNwaWE' \
    --joinability 'hZkJ91R6' \
    --key 'Vh1lmo9z' \
    --leaderID 'Kk2zivSc' \
    --limit '68' \
    --memberID '2DQrItQb' \
    --memberStatus 'cXTQYTcM' \
    --offset '8' \
    --order 'rxf6VvVB' \
    --orderBy 'MrhV4aKJ' \
    --partyID 'rw3w1i1c' \
    --value '4ykJMVlK' \
    > test.out 2>&1
eval_tap $? 31 'AdminQueryParties' test.out

#- 32 AdminGetPlatformCredentials
$CLI_EXE \
    --sn session \
    --op AdminGetPlatformCredentials \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 32 'AdminGetPlatformCredentials' test.out

#- 33 AdminUpdatePlatformCredentials
# body param: body
echo '{"psn": {"clientId": "CSpMjEBb", "clientSecret": "U8DUFnRZ", "scope": "y1O289yx"}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminUpdatePlatformCredentials \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 33 'AdminUpdatePlatformCredentials' test.out

#- 34 AdminDeletePlatformCredentials
$CLI_EXE \
    --sn session \
    --op AdminDeletePlatformCredentials \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 34 'AdminDeletePlatformCredentials' test.out

#- 35 AdminGetRecentPlayer
$CLI_EXE \
    --sn session \
    --op AdminGetRecentPlayer \
    --namespace $AB_NAMESPACE \
    --limit '39' \
    --userId '4ZkJgc4c' \
    > test.out 2>&1
eval_tap $? 35 'AdminGetRecentPlayer' test.out

#- 36 AdminGetRecentTeamPlayer
$CLI_EXE \
    --sn session \
    --op AdminGetRecentTeamPlayer \
    --namespace $AB_NAMESPACE \
    --limit '2' \
    --userId 'v1PyRbm2' \
    > test.out 2>&1
eval_tap $? 36 'AdminGetRecentTeamPlayer' test.out

#- 37 AdminReadSessionStorage
$CLI_EXE \
    --sn session \
    --op AdminReadSessionStorage \
    --namespace $AB_NAMESPACE \
    --sessionId 'L4VKhRfP' \
    > test.out 2>&1
eval_tap $? 37 'AdminReadSessionStorage' test.out

#- 38 AdminDeleteUserSessionStorage
$CLI_EXE \
    --sn session \
    --op AdminDeleteUserSessionStorage \
    --namespace $AB_NAMESPACE \
    --sessionId '1Vd0l4yB' \
    > test.out 2>&1
eval_tap $? 38 'AdminDeleteUserSessionStorage' test.out

#- 39 AdminReadUserSessionStorage
$CLI_EXE \
    --sn session \
    --op AdminReadUserSessionStorage \
    --namespace $AB_NAMESPACE \
    --sessionId 'Hfy8cJUe' \
    --userId '2YGMo9G0' \
    > test.out 2>&1
eval_tap $? 39 'AdminReadUserSessionStorage' test.out

#- 40 AdminQueryPlayerAttributes
$CLI_EXE \
    --sn session \
    --op AdminQueryPlayerAttributes \
    --namespace $AB_NAMESPACE \
    --users 'Co28l1qC' \
    > test.out 2>&1
eval_tap $? 40 'AdminQueryPlayerAttributes' test.out

#- 41 AdminGetPlayerAttributes
$CLI_EXE \
    --sn session \
    --op AdminGetPlayerAttributes \
    --namespace $AB_NAMESPACE \
    --userId '6Lgn9eFf' \
    > test.out 2>&1
eval_tap $? 41 'AdminGetPlayerAttributes' test.out

#- 42 AdminSyncNativeSession
$CLI_EXE \
    --sn session \
    --op AdminSyncNativeSession \
    --namespace $AB_NAMESPACE \
    --userId 'lLkjzADC' \
    > test.out 2>&1
eval_tap $? 42 'AdminSyncNativeSession' test.out

#- 43 CreateGameSession
# body param: body
echo '{"appName": "yql1Oo6G", "attributes": {"tdGD8pq3": {}, "1Ob9aTcr": {}, "NyvxwWlw": {}}, "autoJoin": false, "backfillTicketID": "6Ja6XsFU", "clientVersion": "Bu55UjeS", "configurationName": "M3JNBnlb", "customURLGRPC": "yLv3gVe3", "deployment": "J4nONO9J", "dsSource": "jNvkWCd7", "fallbackClaimKeys": ["i7nB3fQB", "LKxv6Iyl", "omksekb6"], "inactiveTimeout": 22, "inviteTimeout": 22, "joinability": "V3cDd0RO", "matchPool": "L2ES2o0s", "maxPlayers": 45, "minPlayers": 35, "preferredClaimKeys": ["zEQtfZM2", "Afcw9bt2", "MCjN0bT5"], "requestedRegions": ["orZKwnJD", "LInu93wW", "lcDYQQyo"], "serverName": "aJQGZUql", "storage": {"leader": {"fVycH8sj": {}, "gwJuO7oE": {}, "BT2u1sCv": {}}}, "teams": [{"UserIDs": ["KVUFBjBL", "YlKT0FJg", "Mpy1ju6n"], "parties": [{"partyID": "45D4m6ly", "userIDs": ["sY9FHY1N", "36i86Sov", "abny4m3R"]}, {"partyID": "DPsAfBC6", "userIDs": ["mCulEFo5", "hylYGS9w", "XaO6gFoO"]}, {"partyID": "jo8v6qxp", "userIDs": ["DD5OVFMZ", "tX1R6XqH", "I3r1yy1u"]}]}, {"UserIDs": ["krpE9eoI", "KikhOMgY", "1T4VQERs"], "parties": [{"partyID": "QtKMiKOO", "userIDs": ["CBVMdOHg", "PxjC9InE", "lNPmSDzA"]}, {"partyID": "tlgzCsOK", "userIDs": ["oB7QG7HL", "8dfQ2hIu", "mS4UqPe5"]}, {"partyID": "HxyBEUIf", "userIDs": ["G92PbxTd", "t6N0yNPy", "rOZhro3A"]}]}, {"UserIDs": ["OvXGrGHW", "3yYFYWyx", "OFXwY0Yb"], "parties": [{"partyID": "jWq2YQR7", "userIDs": ["aPaqG8xv", "TaGhpaVG", "ruZA0yar"]}, {"partyID": "ddlNpOdY", "userIDs": ["YldYTe9B", "qbonpSHO", "PxfApShy"]}, {"partyID": "QjiF7eu2", "userIDs": ["2UnQ4n2G", "ScMw5wLo", "ScvUazgk"]}]}], "textChat": false, "ticketIDs": ["OCaHcOHY", "MSswuzI7", "U23Ii8qw"], "tieTeamsSessionLifetime": false, "type": "cjK9JS3I"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op CreateGameSession \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 43 'CreateGameSession' test.out

#- 44 PublicQueryGameSessionsByAttributes
# body param: body
echo '{"utCPLeC1": {}, "RtDgKisP": {}, "2e9lQgtf": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicQueryGameSessionsByAttributes \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 44 'PublicQueryGameSessionsByAttributes' test.out

#- 45 PublicSessionJoinCode
# body param: body
echo '{"code": "NwnzSMfO"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicSessionJoinCode \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 45 'PublicSessionJoinCode' test.out

#- 46 GetGameSessionByPodName
$CLI_EXE \
    --sn session \
    --op GetGameSessionByPodName \
    --namespace $AB_NAMESPACE \
    --podName 'AYtd3PK6' \
    > test.out 2>&1
eval_tap $? 46 'GetGameSessionByPodName' test.out

#- 47 GetGameSession
$CLI_EXE \
    --sn session \
    --op GetGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'TyV9rSsw' \
    > test.out 2>&1
eval_tap $? 47 'GetGameSession' test.out

#- 48 UpdateGameSession
# body param: body
echo '{"attributes": {"cSbwC7bV": {}, "xPGBi5eg": {}, "s20FBKT8": {}}, "backfillTicketID": "uSW70Bss", "clientVersion": "vKxSfp1y", "deployment": "yGT0IZBC", "fallbackClaimKeys": ["wPujLAKq", "G3luDJsy", "aCFoBfQD"], "inactiveTimeout": 58, "inviteTimeout": 37, "joinability": "rm6fU8b6", "matchPool": "nME9rBZa", "maxPlayers": 81, "minPlayers": 5, "preferredClaimKeys": ["PZF1YveK", "xOcD4wwe", "Z3KnaEhE"], "requestedRegions": ["l6sIY4IA", "IVue3KXm", "Cz3WmjN1"], "teams": [{"UserIDs": ["InTq8zHd", "TPVDoROJ", "belruPa8"], "parties": [{"partyID": "6rZLHYUG", "userIDs": ["rQIV4YcU", "FfyodTmw", "IAcz999a"]}, {"partyID": "5fGz19yc", "userIDs": ["XxZEr0Qu", "U8JlfdR3", "0uli9yXQ"]}, {"partyID": "o6Mvtes5", "userIDs": ["YFMS4Ugb", "FytKT39g", "4Ktp4Api"]}]}, {"UserIDs": ["UhLV17e3", "OWZY4TOt", "zevb4cy7"], "parties": [{"partyID": "2YJkMhz0", "userIDs": ["oBMmWpiK", "KkQnraAG", "8pw4p6UH"]}, {"partyID": "rIADSzpb", "userIDs": ["qqqdE2ru", "AmXBUdjO", "mYEk6HIn"]}, {"partyID": "ejAJzWVR", "userIDs": ["4KEEbjZP", "JExuKuxj", "vjZv2T5C"]}]}, {"UserIDs": ["hE2Y6JmL", "ROB94N0V", "kDbrfazE"], "parties": [{"partyID": "Qzpb0urX", "userIDs": ["VCTn0Ite", "gdLrG9QN", "ksbFGnFr"]}, {"partyID": "qO868eQK", "userIDs": ["RzgQJDIY", "IYUp0mTS", "TpKPVLAu"]}, {"partyID": "s5sTJLzr", "userIDs": ["VCydJ99v", "C9QLIp1x", "LYdi80oT"]}]}], "ticketIDs": ["hSR7DJEb", "vvSYW0vf", "XQOIbyLo"], "tieTeamsSessionLifetime": true, "type": "12zwXmK9", "version": 62}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op UpdateGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId '4gkXGBXM' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 48 'UpdateGameSession' test.out

#- 49 DeleteGameSession
$CLI_EXE \
    --sn session \
    --op DeleteGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'RCEi0Ll3' \
    > test.out 2>&1
eval_tap $? 49 'DeleteGameSession' test.out

#- 50 PatchUpdateGameSession
# body param: body
echo '{"attributes": {"SZjYF4CJ": {}, "mKKHXHxz": {}, "2CfNOfU5": {}}, "backfillTicketID": "al4MqlgP", "clientVersion": "Ty0ksKbW", "deployment": "3FDSce86", "fallbackClaimKeys": ["GI944DXr", "qfnKksLk", "h75mPiq2"], "inactiveTimeout": 96, "inviteTimeout": 90, "joinability": "tlDPzv8l", "matchPool": "A1QXfVKF", "maxPlayers": 90, "minPlayers": 18, "preferredClaimKeys": ["uQwb9afc", "RRjnurUF", "914oT9BF"], "requestedRegions": ["5ttbU6SD", "miwQAAYz", "blbVADZV"], "teams": [{"UserIDs": ["5sivxECT", "QGdhSPPr", "eF1mEMlr"], "parties": [{"partyID": "WQbXWgrt", "userIDs": ["dKBCEiFw", "q5fk9fTO", "KFYCoVd9"]}, {"partyID": "ERaIKPas", "userIDs": ["wq1yql7H", "Qmhrelvp", "ywZqvgmN"]}, {"partyID": "Zk6cLJbS", "userIDs": ["ZIh1r7VF", "RDrF2KcL", "o4bWUJmL"]}]}, {"UserIDs": ["CMiosyif", "2cKMZG2K", "lw4BY7j7"], "parties": [{"partyID": "VZpnNHXc", "userIDs": ["ZSenxySj", "yPL6CB75", "xijdmakC"]}, {"partyID": "3PVBk4vs", "userIDs": ["TTVxuGnU", "DBHkLFUn", "d6Av66ab"]}, {"partyID": "VXSDImed", "userIDs": ["Nco7sBnm", "bCxEX4la", "9Y0JtL8E"]}]}, {"UserIDs": ["NyobXEcK", "YWNSk2Wq", "vaMHD792"], "parties": [{"partyID": "Wg4jTr4i", "userIDs": ["aJQnXgh4", "GHc2lFT8", "YiDQ17vY"]}, {"partyID": "LPoUbn0B", "userIDs": ["MXEwW5uo", "noMAX7h6", "rMeMzfBC"]}, {"partyID": "ArKLtvYj", "userIDs": ["tYU05C25", "o0dZm26S", "TugbTEDL"]}]}], "ticketIDs": ["e140kMxI", "jCijYkrB", "0DUyLMR9"], "tieTeamsSessionLifetime": true, "type": "rY0IVUuT", "version": 7}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PatchUpdateGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'NBToDyBV' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 50 'PatchUpdateGameSession' test.out

#- 51 UpdateGameSessionBackfillTicketID
# body param: body
echo '{"backfillTicketID": "ecCyxDVG"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op UpdateGameSessionBackfillTicketID \
    --namespace $AB_NAMESPACE \
    --sessionId 'cuWZjVGy' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 51 'UpdateGameSessionBackfillTicketID' test.out

#- 52 GameSessionGenerateCode
$CLI_EXE \
    --sn session \
    --op GameSessionGenerateCode \
    --namespace $AB_NAMESPACE \
    --sessionId 'lFt0SJFT' \
    > test.out 2>&1
eval_tap $? 52 'GameSessionGenerateCode' test.out

#- 53 PublicRevokeGameSessionCode
$CLI_EXE \
    --sn session \
    --op PublicRevokeGameSessionCode \
    --namespace $AB_NAMESPACE \
    --sessionId 'oqtuobb1' \
    > test.out 2>&1
eval_tap $? 53 'PublicRevokeGameSessionCode' test.out

#- 54 PublicGameSessionInvite
# body param: body
echo '{"platformID": "lpLilbPc", "userID": "aYKE27LI"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicGameSessionInvite \
    --namespace $AB_NAMESPACE \
    --sessionId 'WvpLv7xG' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 54 'PublicGameSessionInvite' test.out

#- 55 JoinGameSession
$CLI_EXE \
    --sn session \
    --op JoinGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'lxwjQd9a' \
    > test.out 2>&1
eval_tap $? 55 'JoinGameSession' test.out

#- 56 PublicPromoteGameSessionLeader
# body param: body
echo '{"leaderID": "tY44DTDw"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPromoteGameSessionLeader \
    --namespace $AB_NAMESPACE \
    --sessionId 'mWMyoKql' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 56 'PublicPromoteGameSessionLeader' test.out

#- 57 LeaveGameSession
$CLI_EXE \
    --sn session \
    --op LeaveGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'WGJoXgSw' \
    > test.out 2>&1
eval_tap $? 57 'LeaveGameSession' test.out

#- 58 PublicGameSessionReject
$CLI_EXE \
    --sn session \
    --op PublicGameSessionReject \
    --namespace $AB_NAMESPACE \
    --sessionId '6YtgWCaB' \
    > test.out 2>&1
eval_tap $? 58 'PublicGameSessionReject' test.out

#- 59 GetSessionServerSecret
$CLI_EXE \
    --sn session \
    --op GetSessionServerSecret \
    --namespace $AB_NAMESPACE \
    --sessionId '2Cp62q11' \
    > test.out 2>&1
eval_tap $? 59 'GetSessionServerSecret' test.out

#- 60 AppendTeamGameSession
# body param: body
echo '{"additionalMembers": [{"partyID": "EFolN6uY", "userIDs": ["4yYHFLzL", "XTDOpTij", "KtY3nOH4"]}, {"partyID": "2uClJWSB", "userIDs": ["Sp45ryTw", "cdwPnrkM", "nLtbyzYb"]}, {"partyID": "f4Yp5KOi", "userIDs": ["IJ2oYt2E", "KKdlkwvr", "si8Puakf"]}], "proposedTeams": [{"UserIDs": ["K0advsCL", "TM1ikcJI", "Rcgnuvgg"], "parties": [{"partyID": "hsRiGFSK", "userIDs": ["dGNsvpPf", "eio4knyN", "IRbIHkpA"]}, {"partyID": "qDqcHAxq", "userIDs": ["kc3fuQWP", "CGKgPaVU", "6V0DwAuL"]}, {"partyID": "8NKNeeVY", "userIDs": ["MCScU14k", "E2gwh9c1", "0PSJS3iG"]}]}, {"UserIDs": ["1ZOi3Nfn", "Y3pJyvEq", "RaTNJga1"], "parties": [{"partyID": "zodNMpl0", "userIDs": ["ZZfQttgB", "itkvxuuH", "xsKnoMX5"]}, {"partyID": "v12L9CCu", "userIDs": ["1PvYa70a", "CPifp9I7", "aQcrgsSU"]}, {"partyID": "lXbo1HRH", "userIDs": ["uRjfixSN", "CLjCg3Hu", "pWCxtCBp"]}]}, {"UserIDs": ["hjrToKOV", "WW2kTSIE", "9D5bVNx0"], "parties": [{"partyID": "Wlxe062F", "userIDs": ["V4vZxRTK", "SJuFPpu2", "SbJWWbwX"]}, {"partyID": "CGTZkASp", "userIDs": ["gUUceIRt", "TArfiUuB", "BIjx1RI1"]}, {"partyID": "bOv6u7B5", "userIDs": ["vo45uyq6", "tVMEXiqI", "fb738ENn"]}]}], "version": 10}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AppendTeamGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'beLIfJbe' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 60 'AppendTeamGameSession' test.out

#- 61 PublicGameSessionCancel
$CLI_EXE \
    --sn session \
    --op PublicGameSessionCancel \
    --namespace $AB_NAMESPACE \
    --sessionId 'cvtzHScr' \
    --userId 'YOGW0HeS' \
    > test.out 2>&1
eval_tap $? 61 'PublicGameSessionCancel' test.out

#- 62 PublicPartyJoinCode
# body param: body
echo '{"code": "xm1HR5OV"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPartyJoinCode \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 62 'PublicPartyJoinCode' test.out

#- 63 PublicGetParty
$CLI_EXE \
    --sn session \
    --op PublicGetParty \
    --namespace $AB_NAMESPACE \
    --partyId 'PrTazDMy' \
    > test.out 2>&1
eval_tap $? 63 'PublicGetParty' test.out

#- 64 PublicUpdateParty
# body param: body
echo '{"attributes": {"fw1DQ0eH": {}, "lx9gGjx8": {}, "PYmWoIyB": {}}, "inactiveTimeout": 42, "inviteTimeout": 2, "joinability": "5GfiMO74", "maxPlayers": 78, "minPlayers": 34, "type": "12mZVJZ6", "version": 25}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicUpdateParty \
    --namespace $AB_NAMESPACE \
    --partyId 'E6F3YZTv' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 64 'PublicUpdateParty' test.out

#- 65 PublicPatchUpdateParty
# body param: body
echo '{"attributes": {"4zN8SccM": {}, "fy4OY7CD": {}, "E5imRjmf": {}}, "inactiveTimeout": 45, "inviteTimeout": 99, "joinability": "lQUIt4jn", "maxPlayers": 79, "minPlayers": 64, "type": "CwTFsbGR", "version": 29}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPatchUpdateParty \
    --namespace $AB_NAMESPACE \
    --partyId 'pzDlxMTB' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 65 'PublicPatchUpdateParty' test.out

#- 66 PublicGeneratePartyCode
$CLI_EXE \
    --sn session \
    --op PublicGeneratePartyCode \
    --namespace $AB_NAMESPACE \
    --partyId 'BRPLFoJb' \
    > test.out 2>&1
eval_tap $? 66 'PublicGeneratePartyCode' test.out

#- 67 PublicRevokePartyCode
$CLI_EXE \
    --sn session \
    --op PublicRevokePartyCode \
    --namespace $AB_NAMESPACE \
    --partyId 'hWsGbrqb' \
    > test.out 2>&1
eval_tap $? 67 'PublicRevokePartyCode' test.out

#- 68 PublicPartyInvite
# body param: body
echo '{"platformID": "gtsz7IHn", "userID": "ituqVD7g"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPartyInvite \
    --namespace $AB_NAMESPACE \
    --partyId 'KRO55ZfG' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 68 'PublicPartyInvite' test.out

#- 69 PublicPromotePartyLeader
# body param: body
echo '{"leaderID": "fAcnZZgn"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPromotePartyLeader \
    --namespace $AB_NAMESPACE \
    --partyId 'buWaYLpB' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 69 'PublicPromotePartyLeader' test.out

#- 70 PublicPartyJoin
$CLI_EXE \
    --sn session \
    --op PublicPartyJoin \
    --namespace $AB_NAMESPACE \
    --partyId 'UEC2T9LI' \
    > test.out 2>&1
eval_tap $? 70 'PublicPartyJoin' test.out

#- 71 PublicPartyLeave
$CLI_EXE \
    --sn session \
    --op PublicPartyLeave \
    --namespace $AB_NAMESPACE \
    --partyId 'wQlwwQRZ' \
    > test.out 2>&1
eval_tap $? 71 'PublicPartyLeave' test.out

#- 72 PublicPartyReject
$CLI_EXE \
    --sn session \
    --op PublicPartyReject \
    --namespace $AB_NAMESPACE \
    --partyId 'En3uVMgx' \
    > test.out 2>&1
eval_tap $? 72 'PublicPartyReject' test.out

#- 73 PublicPartyCancel
$CLI_EXE \
    --sn session \
    --op PublicPartyCancel \
    --namespace $AB_NAMESPACE \
    --partyId 'V688G1H2' \
    --userId 'trVCkZYA' \
    > test.out 2>&1
eval_tap $? 73 'PublicPartyCancel' test.out

#- 74 PublicPartyKick
$CLI_EXE \
    --sn session \
    --op PublicPartyKick \
    --namespace $AB_NAMESPACE \
    --partyId 'mmWXB8nA' \
    --userId 'G8uOTqdI' \
    > test.out 2>&1
eval_tap $? 74 'PublicPartyKick' test.out

#- 75 PublicCreateParty
# body param: body
echo '{"attributes": {"0PUtER1l": {}, "HyxvPjP5": {}, "auhi8Wru": {}}, "configurationName": "3INK1D31", "inactiveTimeout": 82, "inviteTimeout": 21, "joinability": "bLpSnq7e", "maxPlayers": 33, "members": [{"ID": "4YfcD2Uw", "PlatformID": "0OCzE1Jx", "PlatformUserID": "QCyho5bD"}, {"ID": "Al6pJTXA", "PlatformID": "dRiSgS0X", "PlatformUserID": "yB6sGIrx"}, {"ID": "af9Fddtj", "PlatformID": "oq4IqqsQ", "PlatformUserID": "aO8OAe5C"}], "minPlayers": 31, "textChat": false, "type": "i1A7dY3u"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicCreateParty \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 75 'PublicCreateParty' test.out

#- 76 PublicGetRecentPlayer
$CLI_EXE \
    --sn session \
    --op PublicGetRecentPlayer \
    --namespace $AB_NAMESPACE \
    --limit '64' \
    > test.out 2>&1
eval_tap $? 76 'PublicGetRecentPlayer' test.out

#- 77 PublicGetRecentTeamPlayer
$CLI_EXE \
    --sn session \
    --op PublicGetRecentTeamPlayer \
    --namespace $AB_NAMESPACE \
    --limit '33' \
    > test.out 2>&1
eval_tap $? 77 'PublicGetRecentTeamPlayer' test.out

#- 78 PublicUpdateInsertSessionStorageLeader
# body param: body
echo '{"WNWNgRUa": {}, "p33CcTKy": {}, "3a51sK2L": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicUpdateInsertSessionStorageLeader \
    --namespace $AB_NAMESPACE \
    --sessionId 'mOB9ODAI' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 78 'PublicUpdateInsertSessionStorageLeader' test.out

#- 79 PublicUpdateInsertSessionStorage
# body param: body
echo '{"KFLRnSut": {}, "A8iSk03N": {}, "FW1cmijF": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicUpdateInsertSessionStorage \
    --namespace $AB_NAMESPACE \
    --sessionId 'Axusaxm6' \
    --userId 'BW3aTeV7' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 79 'PublicUpdateInsertSessionStorage' test.out

#- 80 PublicGetBulkPlayerCurrentPlatform
# body param: body
echo '{"userIDs": ["pud4RnyJ", "Uipljefa", "IDRwCgPc"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicGetBulkPlayerCurrentPlatform \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 80 'PublicGetBulkPlayerCurrentPlatform' test.out

#- 81 PublicGetPlayerAttributes
$CLI_EXE \
    --sn session \
    --op PublicGetPlayerAttributes \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 81 'PublicGetPlayerAttributes' test.out

#- 82 PublicStorePlayerAttributes
# body param: body
echo '{"crossplayEnabled": false, "currentPlatform": "5YjF5R8P", "data": {"mRRiKg5X": {}, "MCDR5hZq": {}, "KGNuF3hz": {}}, "platforms": [{"name": "3S75OTXf", "userID": "ZNIjRqUD"}, {"name": "pSGmN6e1", "userID": "aVMuZe5E"}, {"name": "8aFEj2ZA", "userID": "mXLpbhg1"}], "roles": ["Ci1TuTDq", "4sntQwHt", "7mxa88cn"], "simultaneousPlatform": "DOpiyGj5"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicStorePlayerAttributes \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 82 'PublicStorePlayerAttributes' test.out

#- 83 PublicDeletePlayerAttributes
$CLI_EXE \
    --sn session \
    --op PublicDeletePlayerAttributes \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 83 'PublicDeletePlayerAttributes' test.out

#- 84 PublicQueryMyGameSessions
$CLI_EXE \
    --sn session \
    --op PublicQueryMyGameSessions \
    --namespace $AB_NAMESPACE \
    --order 'FodsbFZI' \
    --orderBy 't4bHlFmq' \
    --status 'jSow7b2Z' \
    > test.out 2>&1
eval_tap $? 84 'PublicQueryMyGameSessions' test.out

#- 85 PublicQueryMyParties
$CLI_EXE \
    --sn session \
    --op PublicQueryMyParties \
    --namespace $AB_NAMESPACE \
    --order 'vDz2ldjk' \
    --orderBy 'Rh3zfpz5' \
    --status '1qsGx7IZ' \
    > test.out 2>&1
eval_tap $? 85 'PublicQueryMyParties' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE