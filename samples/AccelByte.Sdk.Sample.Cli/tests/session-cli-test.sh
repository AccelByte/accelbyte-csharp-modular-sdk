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
echo "1..94"

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
echo '{"logLevel": "error"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminPatchUpdateLogConfig \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 5 'AdminPatchUpdateLogConfig' test.out

#- 6 AdminGetDSMCConfigurationDefault
eval_tap 0 6 'AdminGetDSMCConfigurationDefault # SKIP deprecated' test.out

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
echo '{"metricExcludedNamespaces": ["px5wjFYK", "IMBA6VQy", "4b0GuMCu"], "regionRetryMapping": {"En9ABRmq": ["LV8hKBEQ", "hxD5SBHX", "Jhunxx7M"], "wUYAW21n": ["IW0vMwNI", "CUdBJxai", "ot6It9mk"], "HspnRiB1": ["4SX9nqd3", "qbwC83NQ", "WJwQKpFI"]}, "regionURLMapping": ["YgQLkgIv", "PV9bN0On", "o0KwDfoB"], "testGameMode": "bikd60YT", "testRegionURLMapping": ["DIMANIcd", "2NG6VjSm", "wowB1naF"], "testTargetUserIDs": ["d24gQNi3", "7wx8SKp4", "ec9dhKy7"]}' > $TEMP_JSON_INPUT
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
echo '{"durationDays": 22}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminUpdateConfigurationAlertV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 12 'AdminUpdateConfigurationAlertV1' test.out

#- 13 AdminCreateConfigurationAlertV1
# body param: body
echo '{"durationDays": 70}' > $TEMP_JSON_INPUT
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

#- 15 AdminUploadXBoxCertificate
eval_tap 0 15 'AdminUploadXBoxCertificate # SKIP deprecated' test.out

#- 16 AdminCreateConfigurationTemplateV1
# body param: body
echo '{"NativeSessionSetting": {"PSNDisableSystemUIMenu": ["PROMOTE_TO_LEADER", "PROMOTE_TO_LEADER", "UPDATE_JOINABLE_USER_TYPE"], "PSNServiceLabel": 48, "PSNSupportedPlatforms": ["9lX1yH9N", "Ye1SmlHW", "PINAlMxR"], "SessionTitle": "V4iNs5T6", "ShouldSync": false, "XboxAllowCrossPlatform": true, "XboxSandboxID": "Uo9e6j46", "XboxServiceConfigID": "7ANGFSIh", "XboxSessionTemplateName": "VYelvLSB", "XboxTitleID": "GDQ4Tnbq", "localizedSessionName": {"Dm7FwYpO": {}, "Uy9QBf1o": {}, "PekRxywM": {}}}, "PSNBaseUrl": "di6bCFsR", "amsClaimTimeoutMinutes": 0, "appName": "f974EYSI", "asyncProcessDSRequest": {"async": false, "timeout": 17}, "attributes": {"wETvrAWC": {}, "0Dv92SKA": {}, "1XU3y5Uu": {}}, "autoJoin": false, "autoLeaveSession": true, "clientVersion": "tKEzPRdf", "customURLGRPC": "1vwQfd9C", "deployment": "VyrZGcAi", "disableCodeGeneration": true, "disableResendInvite": false, "dsManualSetReady": false, "dsSource": "Yp5xXLvg", "enableSecret": false, "fallbackClaimKeys": ["d7hMH36l", "84MpruUK", "fHvOTzww"], "grpcSessionConfig": {"appName": "MK0AlcR3", "customURL": "BlZTVgQl", "functionFlag": 28}, "immutableStorage": true, "inactiveTimeout": 57, "inviteTimeout": 50, "joinability": "mbu5j0dd", "leaderElectionGracePeriod": 77, "manualRejoin": true, "maxActiveSessions": 36, "maxPlayers": 51, "minPlayers": 40, "name": "jyzEw6e6", "persistent": false, "preferredClaimKeys": ["RDlw0YLx", "AcEXsTmG", "jkl6Bw1w"], "requestedRegions": ["WJf6HmBG", "B6XKs6wr", "08sMqLZb"], "textChat": false, "textChatMode": "TEAM", "tieTeamsSessionLifetime": false, "ttlHours": 45, "type": "4XZnADZy"}' > $TEMP_JSON_INPUT
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
    --limit '49' \
    --name 'IJVhOvR3' \
    --offset '87' \
    --order 'wlavElvW' \
    --orderBy '299evxzA' \
    > test.out 2>&1
eval_tap $? 17 'AdminGetAllConfigurationTemplatesV1' test.out

#- 18 AdminGetConfigurationTemplateV1
$CLI_EXE \
    --sn session \
    --op AdminGetConfigurationTemplateV1 \
    --name 'dsGd9fvC' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 18 'AdminGetConfigurationTemplateV1' test.out

#- 19 AdminUpdateConfigurationTemplateV1
# body param: body
echo '{"NativeSessionSetting": {"PSNDisableSystemUIMenu": ["PROMOTE_TO_LEADER", "PROMOTE_TO_LEADER", "PROMOTE_TO_LEADER"], "PSNServiceLabel": 46, "PSNSupportedPlatforms": ["zuyZwfj1", "hyf2tqqD", "OKZhrT8m"], "SessionTitle": "L4CUXouB", "ShouldSync": true, "XboxAllowCrossPlatform": false, "XboxSandboxID": "1pWd3I8y", "XboxServiceConfigID": "86UsrzKU", "XboxSessionTemplateName": "GKu8Bs0b", "XboxTitleID": "NJpuH2Yn", "localizedSessionName": {"j5jPDUbR": {}, "CaZJNNOj": {}, "c1gtrabt": {}}}, "PSNBaseUrl": "OoL1FSac", "amsClaimTimeoutMinutes": 71, "appName": "3tNlVJsS", "asyncProcessDSRequest": {"async": true, "timeout": 12}, "attributes": {"gNUJj64I": {}, "LXvPGSOU": {}, "jIcuARg1": {}}, "autoJoin": false, "autoLeaveSession": true, "clientVersion": "iV7PO9M2", "customURLGRPC": "i4yZIDbv", "deployment": "kA0N6kc3", "disableCodeGeneration": true, "disableResendInvite": false, "dsManualSetReady": false, "dsSource": "2eyMDLdF", "enableSecret": false, "fallbackClaimKeys": ["R8CkLATP", "IqXJYgTR", "xER4S3Fs"], "grpcSessionConfig": {"appName": "Qq1ZyHR3", "customURL": "2DU9lTHv", "functionFlag": 58}, "immutableStorage": true, "inactiveTimeout": 100, "inviteTimeout": 19, "joinability": "dWXQQ8xL", "leaderElectionGracePeriod": 42, "manualRejoin": false, "maxActiveSessions": 87, "maxPlayers": 7, "minPlayers": 69, "name": "ehr8GZ5q", "persistent": false, "preferredClaimKeys": ["VyjF9Sv4", "ZlKPhIlI", "CvnJo3ZX"], "requestedRegions": ["3H63L6Yl", "pFoXy63c", "gioWV7hl"], "textChat": true, "textChatMode": "TEAM", "tieTeamsSessionLifetime": true, "ttlHours": 57, "type": "jJkUHRgl"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminUpdateConfigurationTemplateV1 \
    --name 'DndCD7u0' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 19 'AdminUpdateConfigurationTemplateV1' test.out

#- 20 AdminDeleteConfigurationTemplateV1
$CLI_EXE \
    --sn session \
    --op AdminDeleteConfigurationTemplateV1 \
    --name '0kzd1F2o' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 20 'AdminDeleteConfigurationTemplateV1' test.out

#- 21 AdminGetMemberActiveSession
$CLI_EXE \
    --sn session \
    --op AdminGetMemberActiveSession \
    --name 'JQZEyKOe' \
    --namespace $AB_NAMESPACE \
    --userId 'NCFvwhOm' \
    > test.out 2>&1
eval_tap $? 21 'AdminGetMemberActiveSession' test.out

#- 22 AdminReconcileMaxActiveSession
# body param: body
echo '{"userID": "I0JLt6jC"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminReconcileMaxActiveSession \
    --name 'JWYcj8bc' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 22 'AdminReconcileMaxActiveSession' test.out

#- 23 AdminGetDSMCConfiguration
eval_tap 0 23 'AdminGetDSMCConfiguration # SKIP deprecated' test.out

#- 24 AdminSyncDSMCConfiguration
eval_tap 0 24 'AdminSyncDSMCConfiguration # SKIP deprecated' test.out

#- 25 AdminQueryGameSessions
$CLI_EXE \
    --sn session \
    --op AdminQueryGameSessions \
    --namespace $AB_NAMESPACE \
    --configurationName '0ut3R0dX' \
    --dsPodName 'HXk03olp' \
    --fromTime 'ZWl9EvCY' \
    --gameMode 'f5lfGjxr' \
    --isPersistent 'qP9yG2kH' \
    --isSoftDeleted 'o4GKczvP' \
    --joinability 'ogFCGR5t' \
    --limit '97' \
    --matchPool 'DguKmiW8' \
    --memberID '9LPG6Yrr' \
    --offset '73' \
    --order 'GKCNHKLR' \
    --orderBy 'RQkB27V2' \
    --sessionID 'q6nnrb9j' \
    --status 'R4BoHxdF' \
    --statusV2 'w52ITZl9' \
    --toTime 'edrLmk47' \
    > test.out 2>&1
eval_tap $? 25 'AdminQueryGameSessions' test.out

#- 26 AdminQueryGameSessionsByAttributes
# body param: body
echo '{"IzOx20E4": {}, "j1yWBKD4": {}, "UpMGmnME": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminQueryGameSessionsByAttributes \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 26 'AdminQueryGameSessionsByAttributes' test.out

#- 27 AdminDeleteBulkGameSessions
# body param: body
echo '{"ids": ["LG6CVDLY", "QPCSzMaY", "ZkTOp4P7"]}' > $TEMP_JSON_INPUT
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
    --sessionId 'mnx7Lfm7' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 28 'AdminSetDSReady' test.out

#- 29 AdminUpdateDSInformation
# body param: body
echo '{"createdRegion": "bLOkiHM0", "deployment": "IvZODlOA", "description": "esaGM8Jr", "ip": "Cc7WjUY2", "port": 94, "region": "jdXFMrbT", "serverId": "YWmqQzCb", "source": "SkI963vK", "status": "Er5VRV34"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminUpdateDSInformation \
    --namespace $AB_NAMESPACE \
    --sessionId 'QVKwiXWA' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 29 'AdminUpdateDSInformation' test.out

#- 30 AdminKickGameSessionMember
$CLI_EXE \
    --sn session \
    --op AdminKickGameSessionMember \
    --memberId 'YS0hyDrR' \
    --namespace $AB_NAMESPACE \
    --sessionId 'S0gXSF0a' \
    > test.out 2>&1
eval_tap $? 30 'AdminKickGameSessionMember' test.out

#- 31 AdminUpdateGameSessionMember
$CLI_EXE \
    --sn session \
    --op AdminUpdateGameSessionMember \
    --memberId 'aA0MFgom' \
    --namespace $AB_NAMESPACE \
    --sessionId 'BoqiDcTB' \
    --statusType 'NRAvtQty' \
    > test.out 2>&1
eval_tap $? 31 'AdminUpdateGameSessionMember' test.out

#- 32 AdminGetListNativeSession
$CLI_EXE \
    --sn session \
    --op AdminGetListNativeSession \
    --namespace $AB_NAMESPACE \
    --limit '46' \
    --offset '91' \
    --order 'JK3KmrJA' \
    > test.out 2>&1
eval_tap $? 32 'AdminGetListNativeSession' test.out

#- 33 AdminQueryParties
$CLI_EXE \
    --sn session \
    --op AdminQueryParties \
    --namespace $AB_NAMESPACE \
    --fromTime 'bPYshnMh' \
    --isSoftDeleted 'rEWrf124' \
    --joinability '26K56HEc' \
    --key 't2A5ZMw6' \
    --leaderID 'U5Ts8dUS' \
    --limit '40' \
    --memberID 'Om54c7zd' \
    --memberStatus 'OxxkVOsk' \
    --offset '59' \
    --order 'cuTp8pKi' \
    --orderBy 'yY95tMlL' \
    --partyID 'Bm8Z8xPF' \
    --toTime 'ctiem4ZW' \
    --value 'o2Mf9Rab' \
    > test.out 2>&1
eval_tap $? 33 'AdminQueryParties' test.out

#- 34 AdminDeleteBulkParties
# body param: body
echo '{"ids": ["MWZAknUh", "EPndJ6mQ", "4fH24D5s"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminDeleteBulkParties \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 34 'AdminDeleteBulkParties' test.out

#- 35 AdminReadPartySessionStorage
$CLI_EXE \
    --sn session \
    --op AdminReadPartySessionStorage \
    --namespace $AB_NAMESPACE \
    --partyId '5QEMytc8' \
    > test.out 2>&1
eval_tap $? 35 'AdminReadPartySessionStorage' test.out

#- 36 AdminGetPlatformCredentials
$CLI_EXE \
    --sn session \
    --op AdminGetPlatformCredentials \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 36 'AdminGetPlatformCredentials' test.out

#- 37 AdminUpdatePlatformCredentials
# body param: body
echo '{"psn": {"clientId": "AeTiuQJm", "clientSecret": "0bBYFYp2", "scope": "WvhBAEDZ"}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminUpdatePlatformCredentials \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 37 'AdminUpdatePlatformCredentials' test.out

#- 38 AdminDeletePlatformCredentials
$CLI_EXE \
    --sn session \
    --op AdminDeletePlatformCredentials \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 38 'AdminDeletePlatformCredentials' test.out

#- 39 AdminDeletePlatformCredentialsByPlatformId
$CLI_EXE \
    --sn session \
    --op AdminDeletePlatformCredentialsByPlatformId \
    --namespace $AB_NAMESPACE \
    --platformId 'XBOX' \
    > test.out 2>&1
eval_tap $? 39 'AdminDeletePlatformCredentialsByPlatformId' test.out

#- 40 AdminSyncPlatformCredentials
$CLI_EXE \
    --sn session \
    --op AdminSyncPlatformCredentials \
    --namespace $AB_NAMESPACE \
    --platformId 'XBOX' \
    > test.out 2>&1
eval_tap $? 40 'AdminSyncPlatformCredentials' test.out

#- 41 AdminGetRecentPlayer
$CLI_EXE \
    --sn session \
    --op AdminGetRecentPlayer \
    --namespace $AB_NAMESPACE \
    --limit '6' \
    --userId 'uvUj1M3b' \
    > test.out 2>&1
eval_tap $? 41 'AdminGetRecentPlayer' test.out

#- 42 AdminGetRecentTeamPlayer
$CLI_EXE \
    --sn session \
    --op AdminGetRecentTeamPlayer \
    --namespace $AB_NAMESPACE \
    --limit '61' \
    --userId 'ZgWbMsuA' \
    > test.out 2>&1
eval_tap $? 42 'AdminGetRecentTeamPlayer' test.out

#- 43 AdminReadSessionStorage
$CLI_EXE \
    --sn session \
    --op AdminReadSessionStorage \
    --namespace $AB_NAMESPACE \
    --sessionId 'F0qSJokY' \
    > test.out 2>&1
eval_tap $? 43 'AdminReadSessionStorage' test.out

#- 44 AdminDeleteUserSessionStorage
$CLI_EXE \
    --sn session \
    --op AdminDeleteUserSessionStorage \
    --namespace $AB_NAMESPACE \
    --sessionId 'f9m59f1O' \
    > test.out 2>&1
eval_tap $? 44 'AdminDeleteUserSessionStorage' test.out

#- 45 AdminReadUserSessionStorage
$CLI_EXE \
    --sn session \
    --op AdminReadUserSessionStorage \
    --namespace $AB_NAMESPACE \
    --sessionId 'TM4hHPWz' \
    --userId 'ivRAwCRK' \
    > test.out 2>&1
eval_tap $? 45 'AdminReadUserSessionStorage' test.out

#- 46 AdminQueryPlayerAttributes
$CLI_EXE \
    --sn session \
    --op AdminQueryPlayerAttributes \
    --namespace $AB_NAMESPACE \
    --users 'QqPNT9aZ' \
    > test.out 2>&1
eval_tap $? 46 'AdminQueryPlayerAttributes' test.out

#- 47 AdminGetPlayerAttributes
$CLI_EXE \
    --sn session \
    --op AdminGetPlayerAttributes \
    --namespace $AB_NAMESPACE \
    --userId 'nzELwWND' \
    > test.out 2>&1
eval_tap $? 47 'AdminGetPlayerAttributes' test.out

#- 48 AdminSyncNativeSession
$CLI_EXE \
    --sn session \
    --op AdminSyncNativeSession \
    --namespace $AB_NAMESPACE \
    --userId 'N9cEDYi3' \
    > test.out 2>&1
eval_tap $? 48 'AdminSyncNativeSession' test.out

#- 49 CreateGameSession
# body param: body
echo '{"appName": "xA3bBiJS", "attributes": {"JBEtI8Yu": {}, "a6rQ1Zjz": {}, "CWfuaYMI": {}}, "autoJoin": false, "backfillTicketID": "0qoqFmI2", "clientVersion": "zUVTjjM0", "configurationName": "WYf1pTSN", "customURLGRPC": "OTmybjyB", "deployment": "jJjbtr4k", "dsSource": "BrztZdge", "fallbackClaimKeys": ["BmxY7zga", "KYTONXzW", "gfb6gvxI"], "inactiveTimeout": 90, "inviteTimeout": 93, "joinability": "9L3JzZMA", "matchPool": "FcBThXDA", "maxPlayers": 54, "minPlayers": 45, "preferredClaimKeys": ["R0Cb3Dli", "Kl1upuf0", "McUYdBSl"], "requestedRegions": ["AyYxKwFl", "0uUJaQiC", "uIjpKBU7"], "serverName": "f6TP1RLI", "storage": {"leader": {"76jjHQgb": {}, "jRdaIPbl": {}, "FCwzWYgC": {}}}, "teams": [{"parties": [{"partyID": "VoYr85CF", "userIDs": ["B9MW2nah", "5GL6HPHp", "LHeQUjHo"]}, {"partyID": "W4Y1EJBN", "userIDs": ["TiPN9vbk", "N8KFbnZU", "KgrUNMxC"]}, {"partyID": "fIkTsaHk", "userIDs": ["gzLrC04g", "8emRaS1c", "QkfP9SOZ"]}], "teamID": "bFWSjlrG", "userIDs": ["SvBcInL7", "FonKxyD7", "vdMQ3KdM"]}, {"parties": [{"partyID": "L856ocmo", "userIDs": ["O9VF0aF8", "4uxJMn8l", "LSRjj7QL"]}, {"partyID": "HCngMnfa", "userIDs": ["6qYmldOt", "KZyp9F0B", "LRSMMKQh"]}, {"partyID": "oh3zCDA4", "userIDs": ["sMbNc8LA", "mAhuxtuj", "xxknLf4g"]}], "teamID": "A0n4YlKq", "userIDs": ["H478NCig", "syP4TkEk", "bSWwkLsA"]}, {"parties": [{"partyID": "DDHxpPza", "userIDs": ["3iWWCH73", "plN9QX17", "n5lJMlMl"]}, {"partyID": "8BDZqEHC", "userIDs": ["LywZvmh3", "O29wrYCd", "4FCgpw94"]}, {"partyID": "kcBsPf9r", "userIDs": ["puLoOn7O", "BrGLzCA9", "iMfEBDwp"]}], "teamID": "5AvKqGJK", "userIDs": ["Y8RQkwXV", "c1ntEPys", "YYPgN3Zb"]}], "textChat": true, "textChatMode": "GAME", "ticketIDs": ["6ZRZnXp4", "3ItcXo41", "ak4RSFJR"], "tieTeamsSessionLifetime": false, "type": "1vFCAQYv"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op CreateGameSession \
    --namespace $AB_NAMESPACE \
    --resolveMaxActiveSession 'true' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 49 'CreateGameSession' test.out

#- 50 PublicQueryGameSessionsByAttributes
# body param: body
echo '{"XKpsJslb": {}, "39PYr5vD": {}, "U2W3LHoX": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicQueryGameSessionsByAttributes \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 50 'PublicQueryGameSessionsByAttributes' test.out

#- 51 PublicSessionJoinCode
# body param: body
echo '{"code": "AxABJNvM"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicSessionJoinCode \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 51 'PublicSessionJoinCode' test.out

#- 52 GetGameSessionByPodName
$CLI_EXE \
    --sn session \
    --op GetGameSessionByPodName \
    --namespace $AB_NAMESPACE \
    --podName 'yGacK1zu' \
    > test.out 2>&1
eval_tap $? 52 'GetGameSessionByPodName' test.out

#- 53 GetGameSession
$CLI_EXE \
    --sn session \
    --op GetGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'rptOMvSc' \
    > test.out 2>&1
eval_tap $? 53 'GetGameSession' test.out

#- 54 UpdateGameSession
# body param: body
echo '{"attributes": {"jNI2rIvr": {}, "NCHkDnBA": {}, "QHDSarQz": {}}, "backfillTicketID": "SntXYVkk", "clientVersion": "NL1htlJN", "deployment": "XDndL1AR", "fallbackClaimKeys": ["VnyfnwOJ", "eBfyt4mX", "DJae70We"], "inactiveTimeout": 19, "inviteTimeout": 64, "joinability": "4CIAU6Q6", "matchPool": "0zqbPShn", "maxPlayers": 19, "minPlayers": 4, "preferredClaimKeys": ["ClDVIB1e", "35auYEKr", "kXMx2DpK"], "requestedRegions": ["AuRwE8RD", "I4ECLoJH", "64v85bZx"], "teams": [{"parties": [{"partyID": "7dg2DF3r", "userIDs": ["s8SxR4R0", "VgSuclGR", "xhUxIUjk"]}, {"partyID": "NTIA2Xen", "userIDs": ["IBwzse8E", "uZgLD3VU", "irePFLEg"]}, {"partyID": "xfgx0uDt", "userIDs": ["k44ixSh5", "X1hP4TtS", "goXL9eKV"]}], "teamID": "x0rCGNXR", "userIDs": ["ZQOrB3gm", "kjU0Q5Mx", "ZrkjspU9"]}, {"parties": [{"partyID": "9qtK0MG0", "userIDs": ["pR5YxmVF", "4kSl0UnN", "fph5nB9I"]}, {"partyID": "8X3Q6xlj", "userIDs": ["GyFFoKKa", "pJwtu0P3", "qmoS8gQE"]}, {"partyID": "JZ205lE8", "userIDs": ["8tnYBq7F", "cn2gIKZs", "WPD6xCLn"]}], "teamID": "O4jcElIr", "userIDs": ["G0eJLcLd", "lnKnjBmZ", "4fpknAKY"]}, {"parties": [{"partyID": "UpV1naIc", "userIDs": ["rQnyyOsd", "1ofkTbsN", "LFzwPn86"]}, {"partyID": "Wp9eF24Y", "userIDs": ["NmIl7pFH", "2vavxKZW", "lBqmLgxZ"]}, {"partyID": "OfpZLhAt", "userIDs": ["GDwm6ANa", "5sePK82g", "3t7iddkO"]}], "teamID": "uioxLXkT", "userIDs": ["WXV78aDo", "inkmzfei", "WAFDsdXR"]}], "ticketIDs": ["9HBLu8RP", "W0a3Rkvi", "S7TeUXZr"], "tieTeamsSessionLifetime": true, "type": "hfh9HXZt", "version": 48}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op UpdateGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'CZrFwoxR' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 54 'UpdateGameSession' test.out

#- 55 DeleteGameSession
$CLI_EXE \
    --sn session \
    --op DeleteGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'WqGMyDZF' \
    > test.out 2>&1
eval_tap $? 55 'DeleteGameSession' test.out

#- 56 PatchUpdateGameSession
# body param: body
echo '{"attributes": {"9Y4OrKDm": {}, "ANunTkVn": {}, "G2WKaGHO": {}}, "backfillTicketID": "i3iIRM1r", "clientVersion": "Ge2hpS6x", "deployment": "dcjET5VL", "fallbackClaimKeys": ["by2QlQx1", "idkJCSVh", "dmQNUT5s"], "inactiveTimeout": 56, "inviteTimeout": 1, "joinability": "07cvdiBU", "matchPool": "GneaGzDH", "maxPlayers": 77, "minPlayers": 31, "preferredClaimKeys": ["106gaEau", "CbVl0XqC", "So7KEdQ8"], "requestedRegions": ["8tp7iqUW", "8cd3Ai5S", "0PNYXu9D"], "teams": [{"parties": [{"partyID": "wuUXa1cS", "userIDs": ["Tu7lEzVW", "qPxhK7dC", "RasAmdAp"]}, {"partyID": "nyZInAVL", "userIDs": ["8Ok5hR9h", "pfN1l6c2", "HkeB0ICV"]}, {"partyID": "snEjYbKO", "userIDs": ["mK9lTSbX", "AgYnN2ZB", "oxntUrPd"]}], "teamID": "IUlVvGdQ", "userIDs": ["VMNRK1B7", "NkZLajtv", "HPUxvwyq"]}, {"parties": [{"partyID": "10lEZjR2", "userIDs": ["kMkuJ7rL", "PkUzgpdd", "J4mV07kL"]}, {"partyID": "ZgB07Lnq", "userIDs": ["0ApIw9HB", "2iQBwo8J", "3qkOSkvt"]}, {"partyID": "peDOzD1J", "userIDs": ["nOhyuIs5", "JJPlcYUM", "WgAZNMqx"]}], "teamID": "v6Ce5aJs", "userIDs": ["5srruaa7", "3ax5tMLf", "yHOnQFCc"]}, {"parties": [{"partyID": "8U7DiwY3", "userIDs": ["JHnbQgoB", "I31es8sh", "wlFp4QPe"]}, {"partyID": "nrwNXfyO", "userIDs": ["oMIUpKPf", "lLYfw14v", "lrlz8Oc7"]}, {"partyID": "pHLpVIfm", "userIDs": ["sRY05D9M", "hcC6jgM9", "RqDEh8Ng"]}], "teamID": "fcpBbPun", "userIDs": ["TcQArlLe", "3w8dj6rE", "hnriloBL"]}], "ticketIDs": ["S15Wk6Ib", "wNNPgGne", "Oq9tUyJA"], "tieTeamsSessionLifetime": false, "type": "6QvI8nGh", "version": 79}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PatchUpdateGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'MwvSR69X' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 56 'PatchUpdateGameSession' test.out

#- 57 UpdateGameSessionBackfillTicketID
# body param: body
echo '{"backfillTicketID": "gyrTopzm"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op UpdateGameSessionBackfillTicketID \
    --namespace $AB_NAMESPACE \
    --sessionId 'hGWn3uVm' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 57 'UpdateGameSessionBackfillTicketID' test.out

#- 58 GameSessionGenerateCode
$CLI_EXE \
    --sn session \
    --op GameSessionGenerateCode \
    --namespace $AB_NAMESPACE \
    --sessionId 'ZqpGjWpP' \
    > test.out 2>&1
eval_tap $? 58 'GameSessionGenerateCode' test.out

#- 59 PublicRevokeGameSessionCode
$CLI_EXE \
    --sn session \
    --op PublicRevokeGameSessionCode \
    --namespace $AB_NAMESPACE \
    --sessionId 'sUAT1fiH' \
    > test.out 2>&1
eval_tap $? 59 'PublicRevokeGameSessionCode' test.out

#- 60 PublicGameSessionInvite
# body param: body
echo '{"metadata": {"12v6lJSZ": "iHGOSFAg", "l9gECuVy": "Z8PP85mv", "343a6tmb": "uizErGrM"}, "platformID": "4RDl05DU", "userID": "ekWAmVra"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicGameSessionInvite \
    --namespace $AB_NAMESPACE \
    --sessionId 'OSXlBy1l' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 60 'PublicGameSessionInvite' test.out

#- 61 JoinGameSession
$CLI_EXE \
    --sn session \
    --op JoinGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'SEZsZdBN' \
    > test.out 2>&1
eval_tap $? 61 'JoinGameSession' test.out

#- 62 PublicPromoteGameSessionLeader
# body param: body
echo '{"leaderID": "kr3PatlQ"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPromoteGameSessionLeader \
    --namespace $AB_NAMESPACE \
    --sessionId 'CDNjRWiX' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 62 'PublicPromoteGameSessionLeader' test.out

#- 63 LeaveGameSession
$CLI_EXE \
    --sn session \
    --op LeaveGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'yFyf2RUZ' \
    > test.out 2>&1
eval_tap $? 63 'LeaveGameSession' test.out

#- 64 PublicKickGameSessionMember
$CLI_EXE \
    --sn session \
    --op PublicKickGameSessionMember \
    --memberId 'Z05ZERFG' \
    --namespace $AB_NAMESPACE \
    --sessionId '9DQXWWrU' \
    > test.out 2>&1
eval_tap $? 64 'PublicKickGameSessionMember' test.out

#- 65 PublicGameSessionReject
$CLI_EXE \
    --sn session \
    --op PublicGameSessionReject \
    --namespace $AB_NAMESPACE \
    --sessionId 'TKpmB3D3' \
    > test.out 2>&1
eval_tap $? 65 'PublicGameSessionReject' test.out

#- 66 GetSessionServerSecret
$CLI_EXE \
    --sn session \
    --op GetSessionServerSecret \
    --namespace $AB_NAMESPACE \
    --sessionId 'TjO5tLfi' \
    > test.out 2>&1
eval_tap $? 66 'GetSessionServerSecret' test.out

#- 67 AppendTeamGameSession
eval_tap 0 67 'AppendTeamGameSession # SKIP deprecated' test.out

#- 68 PublicGameSessionCancel
$CLI_EXE \
    --sn session \
    --op PublicGameSessionCancel \
    --namespace $AB_NAMESPACE \
    --sessionId 'TM5qwowm' \
    --userId 'Hh5fewRp' \
    > test.out 2>&1
eval_tap $? 68 'PublicGameSessionCancel' test.out

#- 69 PublicPartyJoinCode
# body param: body
echo '{"code": "6oFuBqDo"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPartyJoinCode \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 69 'PublicPartyJoinCode' test.out

#- 70 PublicGetParty
$CLI_EXE \
    --sn session \
    --op PublicGetParty \
    --namespace $AB_NAMESPACE \
    --partyId 'MZVoDvu8' \
    > test.out 2>&1
eval_tap $? 70 'PublicGetParty' test.out

#- 71 PublicUpdateParty
# body param: body
echo '{"attributes": {"TiccflFi": {}, "iUc8ELwW": {}, "03x9FlBK": {}}, "inactiveTimeout": 84, "inviteTimeout": 69, "joinability": "NXN1mEQO", "maxPlayers": 36, "minPlayers": 24, "type": "GsconEtC", "version": 24}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicUpdateParty \
    --namespace $AB_NAMESPACE \
    --partyId 'VySpdfGU' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 71 'PublicUpdateParty' test.out

#- 72 PublicPatchUpdateParty
# body param: body
echo '{"attributes": {"Md0dIFvm": {}, "7NlT4WCV": {}, "yjIDnxXh": {}}, "inactiveTimeout": 0, "inviteTimeout": 80, "joinability": "MFm1wz2f", "maxPlayers": 33, "minPlayers": 55, "type": "RQqhTkJt", "version": 63}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPatchUpdateParty \
    --namespace $AB_NAMESPACE \
    --partyId 'Sb0w4QAS' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 72 'PublicPatchUpdateParty' test.out

#- 73 PublicGeneratePartyCode
$CLI_EXE \
    --sn session \
    --op PublicGeneratePartyCode \
    --namespace $AB_NAMESPACE \
    --partyId '4MWbqX9f' \
    > test.out 2>&1
eval_tap $? 73 'PublicGeneratePartyCode' test.out

#- 74 PublicRevokePartyCode
$CLI_EXE \
    --sn session \
    --op PublicRevokePartyCode \
    --namespace $AB_NAMESPACE \
    --partyId 'JSGBlmtR' \
    > test.out 2>&1
eval_tap $? 74 'PublicRevokePartyCode' test.out

#- 75 PublicPartyInvite
# body param: body
echo '{"metadata": {"rO2F5vOk": "LWEUdMzH", "Rv5mFY0D": "IvBitulF", "VsYX1Q2X": "QTFFXISA"}, "platformID": "aD2I6G5v", "userID": "eF7lnP02"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPartyInvite \
    --namespace $AB_NAMESPACE \
    --partyId 't5y7JElo' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 75 'PublicPartyInvite' test.out

#- 76 PublicPromotePartyLeader
# body param: body
echo '{"leaderID": "E9uA66bX"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPromotePartyLeader \
    --namespace $AB_NAMESPACE \
    --partyId 'j6gY1IyT' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 76 'PublicPromotePartyLeader' test.out

#- 77 PublicReadPartySessionStorage
$CLI_EXE \
    --sn session \
    --op PublicReadPartySessionStorage \
    --namespace $AB_NAMESPACE \
    --partyId 'm8KfHNv3' \
    > test.out 2>&1
eval_tap $? 77 'PublicReadPartySessionStorage' test.out

#- 78 PublicUpdateInsertPartySessionStorageReserved
# body param: body
echo '{"iuLFpQaG": {}, "r3TFFS90": {}, "pSH1LcCQ": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicUpdateInsertPartySessionStorageReserved \
    --namespace $AB_NAMESPACE \
    --partyId 'bGVjJM5r' \
    --userId 'OJIE5TXJ' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 78 'PublicUpdateInsertPartySessionStorageReserved' test.out

#- 79 PublicPartyJoin
$CLI_EXE \
    --sn session \
    --op PublicPartyJoin \
    --namespace $AB_NAMESPACE \
    --partyId 'uZh4vndh' \
    > test.out 2>&1
eval_tap $? 79 'PublicPartyJoin' test.out

#- 80 PublicPartyLeave
$CLI_EXE \
    --sn session \
    --op PublicPartyLeave \
    --namespace $AB_NAMESPACE \
    --partyId '4rGxoSQ7' \
    > test.out 2>&1
eval_tap $? 80 'PublicPartyLeave' test.out

#- 81 PublicPartyReject
$CLI_EXE \
    --sn session \
    --op PublicPartyReject \
    --namespace $AB_NAMESPACE \
    --partyId 'CebXOY5o' \
    > test.out 2>&1
eval_tap $? 81 'PublicPartyReject' test.out

#- 82 PublicPartyCancel
$CLI_EXE \
    --sn session \
    --op PublicPartyCancel \
    --namespace $AB_NAMESPACE \
    --partyId 'MRCEgPia' \
    --userId 'sUZj4qXo' \
    > test.out 2>&1
eval_tap $? 82 'PublicPartyCancel' test.out

#- 83 PublicPartyKick
$CLI_EXE \
    --sn session \
    --op PublicPartyKick \
    --namespace $AB_NAMESPACE \
    --partyId 'NdFrg2gL' \
    --userId 'uJTrPyyk' \
    > test.out 2>&1
eval_tap $? 83 'PublicPartyKick' test.out

#- 84 PublicCreateParty
# body param: body
echo '{"attributes": {"Zy5cjiV7": {}, "XwpXBjT7": {}, "1U3DBzlJ": {}}, "configurationName": "BEFPLHNn", "inactiveTimeout": 94, "inviteTimeout": 6, "joinability": "YOvSD1YV", "maxPlayers": 61, "members": [{"ID": "E7kyrlUI", "PlatformID": "EZWqSUmZ", "PlatformUserID": "pToS08qW"}, {"ID": "DptFR1Gf", "PlatformID": "xlqz9PGK", "PlatformUserID": "7YzKXs7G"}, {"ID": "xnqR6xbR", "PlatformID": "u26w4jJW", "PlatformUserID": "tlvsSlWC"}], "minPlayers": 19, "textChat": false, "type": "kkkPpNnl"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicCreateParty \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 84 'PublicCreateParty' test.out

#- 85 PublicGetRecentPlayer
$CLI_EXE \
    --sn session \
    --op PublicGetRecentPlayer \
    --namespace $AB_NAMESPACE \
    --limit '70' \
    > test.out 2>&1
eval_tap $? 85 'PublicGetRecentPlayer' test.out

#- 86 PublicGetRecentTeamPlayer
$CLI_EXE \
    --sn session \
    --op PublicGetRecentTeamPlayer \
    --namespace $AB_NAMESPACE \
    --limit '67' \
    > test.out 2>&1
eval_tap $? 86 'PublicGetRecentTeamPlayer' test.out

#- 87 PublicUpdateInsertSessionStorageLeader
# body param: body
echo '{"w6RtKbLP": {}, "EVExLleR": {}, "pk3WD5So": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicUpdateInsertSessionStorageLeader \
    --namespace $AB_NAMESPACE \
    --sessionId 'CuIrxU5R' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 87 'PublicUpdateInsertSessionStorageLeader' test.out

#- 88 PublicUpdateInsertSessionStorage
# body param: body
echo '{"V8iNtTg3": {}, "vk0DjEJ1": {}, "yz8JhZu0": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicUpdateInsertSessionStorage \
    --namespace $AB_NAMESPACE \
    --sessionId '5lRAtWsO' \
    --userId 'pZd1gshP' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 88 'PublicUpdateInsertSessionStorage' test.out

#- 89 PublicGetBulkPlayerCurrentPlatform
# body param: body
echo '{"userIDs": ["4tdAWXmr", "PFYkLQx2", "FhSon3ff"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicGetBulkPlayerCurrentPlatform \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 89 'PublicGetBulkPlayerCurrentPlatform' test.out

#- 90 PublicGetPlayerAttributes
$CLI_EXE \
    --sn session \
    --op PublicGetPlayerAttributes \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 90 'PublicGetPlayerAttributes' test.out

#- 91 PublicStorePlayerAttributes
# body param: body
echo '{"crossplayEnabled": true, "currentPlatform": "bOqjN6vg", "data": {"QsEi5Lvj": {}, "Rn08m1Mn": {}, "R2aj4okk": {}}, "platforms": [{"name": "6NiGsBe4", "userID": "DxZgknih"}, {"name": "XQ5XXAaj", "userID": "NCRKypEs"}, {"name": "XN0JkKaZ", "userID": "tA8WCa9C"}], "roles": ["3aMFZ81F", "zYl2tx9Q", "FAdsbEtv"], "simultaneousPlatform": "kjhH1RmH"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicStorePlayerAttributes \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 91 'PublicStorePlayerAttributes' test.out

#- 92 PublicDeletePlayerAttributes
$CLI_EXE \
    --sn session \
    --op PublicDeletePlayerAttributes \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 92 'PublicDeletePlayerAttributes' test.out

#- 93 PublicQueryMyGameSessions
$CLI_EXE \
    --sn session \
    --op PublicQueryMyGameSessions \
    --namespace $AB_NAMESPACE \
    --order '6dNQzHrl' \
    --orderBy 'q8cEAwzT' \
    --status '62lInANv' \
    > test.out 2>&1
eval_tap $? 93 'PublicQueryMyGameSessions' test.out

#- 94 PublicQueryMyParties
$CLI_EXE \
    --sn session \
    --op PublicQueryMyParties \
    --namespace $AB_NAMESPACE \
    --order 'WmtbcLJY' \
    --orderBy 'YO4mnMXt' \
    --status 'YNpSIgqv' \
    > test.out 2>&1
eval_tap $? 94 'PublicQueryMyParties' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE