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
echo "1..98"

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

#- 3 PprofHandler
$CLI_EXE \
    --sn session \
    --op PprofHandler \
    > test.out 2>&1
eval_tap $? 3 'PprofHandler' test.out

#- 4 AllocsHandler
$CLI_EXE \
    --sn session \
    --op AllocsHandler \
    > test.out 2>&1
eval_tap $? 4 'AllocsHandler' test.out

#- 5 BlockHandler
$CLI_EXE \
    --sn session \
    --op BlockHandler \
    > test.out 2>&1
eval_tap $? 5 'BlockHandler' test.out

#- 6 CmdlineHandler
$CLI_EXE \
    --sn session \
    --op CmdlineHandler \
    > test.out 2>&1
eval_tap $? 6 'CmdlineHandler' test.out

#- 7 GoroutineHandler
$CLI_EXE \
    --sn session \
    --op GoroutineHandler \
    > test.out 2>&1
eval_tap $? 7 'GoroutineHandler' test.out

#- 8 HeapHandler
$CLI_EXE \
    --sn session \
    --op HeapHandler \
    > test.out 2>&1
eval_tap $? 8 'HeapHandler' test.out

#- 9 MutexHandler
$CLI_EXE \
    --sn session \
    --op MutexHandler \
    > test.out 2>&1
eval_tap $? 9 'MutexHandler' test.out

#- 10 Profile
$CLI_EXE \
    --sn session \
    --op Profile \
    > test.out 2>&1
eval_tap $? 10 'Profile' test.out

#- 11 SymbolHandler
$CLI_EXE \
    --sn session \
    --op SymbolHandler \
    > test.out 2>&1
eval_tap $? 11 'SymbolHandler' test.out

#- 12 ThreadcreateHandler
$CLI_EXE \
    --sn session \
    --op ThreadcreateHandler \
    > test.out 2>&1
eval_tap $? 12 'ThreadcreateHandler' test.out

#- 13 TraceHandler
$CLI_EXE \
    --sn session \
    --op TraceHandler \
    > test.out 2>&1
eval_tap $? 13 'TraceHandler' test.out

#- 14 GetHealthcheckInfoV1
$CLI_EXE \
    --sn session \
    --op GetHealthcheckInfoV1 \
    > test.out 2>&1
eval_tap $? 14 'GetHealthcheckInfoV1' test.out

#- 15 AdminGetLogConfig
$CLI_EXE \
    --sn session \
    --op AdminGetLogConfig \
    > test.out 2>&1
eval_tap $? 15 'AdminGetLogConfig' test.out

#- 16 AdminPatchUpdateLogConfig
# body param: body
echo '{"logLevel": "info"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminPatchUpdateLogConfig \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 16 'AdminPatchUpdateLogConfig' test.out

#- 17 AdminGetDSMCConfigurationDefault
$CLI_EXE \
    --sn session \
    --op AdminGetDSMCConfigurationDefault \
    > test.out 2>&1
eval_tap $? 17 'AdminGetDSMCConfigurationDefault' test.out

#- 18 AdminListEnvironmentVariables
$CLI_EXE \
    --sn session \
    --op AdminListEnvironmentVariables \
    > test.out 2>&1
eval_tap $? 18 'AdminListEnvironmentVariables' test.out

#- 19 AdminListGlobalConfiguration
$CLI_EXE \
    --sn session \
    --op AdminListGlobalConfiguration \
    > test.out 2>&1
eval_tap $? 19 'AdminListGlobalConfiguration' test.out

#- 20 AdminUpdateGlobalConfiguration
# body param: body
echo '{"metricExcludedNamespaces": ["hDh9naaT", "ZIVrzEUa", "i1ll7RqJ"], "regionRetryMapping": {"p6ctTlH7": ["vo17naPa", "dYepDruc", "DVagbNpn"], "ZZcSgLd6": ["OZqP3IuW", "1friZ5zN", "XdT3L6PN"], "7gPQNHcI": ["lmpshp2R", "V3RNoG3a", "OHHJVDAi"]}, "regionURLMapping": ["aLcXINZa", "FYBMm6ku", "C1GvwbjF"], "testGameMode": "saF9Regk", "testRegionURLMapping": ["xpsRiDcA", "GhJwD7I0", "krkWgnx7"], "testTargetUserIDs": ["yZGhFjVV", "Vf2K8CC9", "PHAKdPoN"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminUpdateGlobalConfiguration \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 20 'AdminUpdateGlobalConfiguration' test.out

#- 21 AdminDeleteGlobalConfiguration
$CLI_EXE \
    --sn session \
    --op AdminDeleteGlobalConfiguration \
    > test.out 2>&1
eval_tap $? 21 'AdminDeleteGlobalConfiguration' test.out

#- 22 AdminGetConfigurationAlertV1
$CLI_EXE \
    --sn session \
    --op AdminGetConfigurationAlertV1 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 22 'AdminGetConfigurationAlertV1' test.out

#- 23 AdminUpdateConfigurationAlertV1
# body param: body
echo '{"durationDays": 6}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminUpdateConfigurationAlertV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 23 'AdminUpdateConfigurationAlertV1' test.out

#- 24 AdminCreateConfigurationAlertV1
# body param: body
echo '{"durationDays": 33}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminCreateConfigurationAlertV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 24 'AdminCreateConfigurationAlertV1' test.out

#- 25 AdminDeleteConfigurationAlertV1
$CLI_EXE \
    --sn session \
    --op AdminDeleteConfigurationAlertV1 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 25 'AdminDeleteConfigurationAlertV1' test.out

#- 26 HandleUploadXboxPFXCertificate
# form data upload: file
echo 'tmp.dat' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --sn session \
    --op HandleUploadXboxPFXCertificate \
    --namespace $AB_NAMESPACE \
    --description '3bmRlmMM' \
    --certname 'gqZ8BFO6' \
    --upload file $TEMP_FILE_UPLOAD \
    --password 'xjLtab35' \
    > test.out 2>&1
eval_tap $? 26 'HandleUploadXboxPFXCertificate' test.out

#- 27 AdminCreateConfigurationTemplateV1
# body param: body
echo '{"NativeSessionSetting": {"PSNServiceLabel": 63, "PSNSupportedPlatforms": ["QlH0pmn2", "gBsBY8yP", "CN5q2Drf"], "SessionTitle": "vGfeXxCL", "ShouldSync": true, "XboxAllowCrossPlatform": false, "XboxSandboxID": "q8XCrW5J", "XboxServiceConfigID": "Vl6quz71", "XboxSessionTemplateName": "Es2iW8cv", "XboxTitleID": "v8J7MJBX", "localizedSessionName": {"pUf6uGNi": {}, "633pgIEP": {}, "uuet0pnx": {}}}, "PSNBaseUrl": "MR4vY3Hr", "appName": "OZZ37Y2a", "attributes": {"qtNVGYDv": {}, "d1S28tPV": {}, "d0Wt1xFn": {}}, "autoJoin": false, "autoLeaveSession": true, "clientVersion": "WOtsiNxN", "customURLGRPC": "Zqg1uv7Y", "deployment": "n9yfwf4F", "disableCodeGeneration": true, "disableResendInvite": true, "dsManualSetReady": false, "dsSource": "AsgZCUHm", "enableSecret": false, "fallbackClaimKeys": ["RSvrnTkA", "X3Juia0k", "NfFXN53c"], "immutableStorage": true, "inactiveTimeout": 57, "inviteTimeout": 7, "joinability": "LTHLdtTL", "leaderElectionGracePeriod": 42, "manualRejoin": false, "maxActiveSessions": 51, "maxPlayers": 81, "minPlayers": 94, "name": "k5BV1D5L", "persistent": false, "preferredClaimKeys": ["Aaxf5rZA", "OyM8Xvm1", "N59kXsfG"], "requestedRegions": ["qeYaoeNE", "NHuFDkH9", "PYZzWy2m"], "textChat": false, "tieTeamsSessionLifetime": true, "type": "xEF6lVwH"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminCreateConfigurationTemplateV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 27 'AdminCreateConfigurationTemplateV1' test.out

#- 28 AdminGetAllConfigurationTemplatesV1
$CLI_EXE \
    --sn session \
    --op AdminGetAllConfigurationTemplatesV1 \
    --namespace $AB_NAMESPACE \
    --limit '21' \
    --name 'njaMxBJ7' \
    --offset '65' \
    --order 'jlsv1z4b' \
    --orderBy 'k15d9eVk' \
    > test.out 2>&1
eval_tap $? 28 'AdminGetAllConfigurationTemplatesV1' test.out

#- 29 AdminGetConfigurationTemplateV1
$CLI_EXE \
    --sn session \
    --op AdminGetConfigurationTemplateV1 \
    --name 'CLIa6yTO' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 29 'AdminGetConfigurationTemplateV1' test.out

#- 30 AdminUpdateConfigurationTemplateV1
# body param: body
echo '{"NativeSessionSetting": {"PSNServiceLabel": 4, "PSNSupportedPlatforms": ["9OZcWCGW", "7hKKAC3Q", "KoUlsppa"], "SessionTitle": "GsIruk7W", "ShouldSync": false, "XboxAllowCrossPlatform": true, "XboxSandboxID": "xtQK9YdI", "XboxServiceConfigID": "oO8QkuaH", "XboxSessionTemplateName": "vDrUElcA", "XboxTitleID": "BGytjDGf", "localizedSessionName": {"G85Ieqc8": {}, "SO9HqvNY": {}, "Buw1dRlo": {}}}, "PSNBaseUrl": "R930cdtn", "appName": "Q5T6rBY9", "attributes": {"T9IxCO3a": {}, "Gfhw8o0z": {}, "pOHeycLu": {}}, "autoJoin": false, "autoLeaveSession": false, "clientVersion": "9lcmBci5", "customURLGRPC": "OuO7FkO5", "deployment": "l5Hw9FpZ", "disableCodeGeneration": true, "disableResendInvite": true, "dsManualSetReady": false, "dsSource": "tqfJUyAj", "enableSecret": false, "fallbackClaimKeys": ["qd1IeCR3", "3CA2rU92", "i7jPCGMh"], "immutableStorage": true, "inactiveTimeout": 89, "inviteTimeout": 79, "joinability": "tCW530MK", "leaderElectionGracePeriod": 58, "manualRejoin": true, "maxActiveSessions": 60, "maxPlayers": 99, "minPlayers": 27, "name": "yzMKiJBS", "persistent": false, "preferredClaimKeys": ["oqG1Tvo5", "RvoZRkKX", "PoyHCmsP"], "requestedRegions": ["28O2XQoF", "MMpYFR6Z", "QSEof70m"], "textChat": true, "tieTeamsSessionLifetime": false, "type": "bRLxnEzs"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminUpdateConfigurationTemplateV1 \
    --name '420zHGWp' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 30 'AdminUpdateConfigurationTemplateV1' test.out

#- 31 AdminDeleteConfigurationTemplateV1
$CLI_EXE \
    --sn session \
    --op AdminDeleteConfigurationTemplateV1 \
    --name 'CemHv7av' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 31 'AdminDeleteConfigurationTemplateV1' test.out

#- 32 AdminGetMemberActiveSession
$CLI_EXE \
    --sn session \
    --op AdminGetMemberActiveSession \
    --name 'OC6fRiE7' \
    --namespace $AB_NAMESPACE \
    --userId '4d726EFl' \
    > test.out 2>&1
eval_tap $? 32 'AdminGetMemberActiveSession' test.out

#- 33 AdminReconcileMaxActiveSession
# body param: body
echo '{"userID": "yewObxIo"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminReconcileMaxActiveSession \
    --name 'iJijzLxX' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 33 'AdminReconcileMaxActiveSession' test.out

#- 34 AdminGetDSMCConfiguration
$CLI_EXE \
    --sn session \
    --op AdminGetDSMCConfiguration \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 34 'AdminGetDSMCConfiguration' test.out

#- 35 AdminSyncDSMCConfiguration
$CLI_EXE \
    --sn session \
    --op AdminSyncDSMCConfiguration \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 35 'AdminSyncDSMCConfiguration' test.out

#- 36 AdminQueryGameSessions
$CLI_EXE \
    --sn session \
    --op AdminQueryGameSessions \
    --namespace $AB_NAMESPACE \
    --configurationName 'RjQ6Ys6j' \
    --dsPodName '7wn9oKHq' \
    --fromTime 'VoUwJURS' \
    --gameMode 'cGw8iU2l' \
    --isPersistent '9sZ1mYn8' \
    --isSoftDeleted 'RPJSWk5j' \
    --joinability 'gDlaxeeL' \
    --limit '52' \
    --matchPool 'AGbR0bnu' \
    --memberID 'Wz9CUQYf' \
    --offset '31' \
    --order '346PzLwn' \
    --orderBy 'piLDRNVi' \
    --sessionID 'TKZFcVUl' \
    --status 'e8FFtZVE' \
    --statusV2 '54MuSyxe' \
    --toTime 'opQxuHqJ' \
    > test.out 2>&1
eval_tap $? 36 'AdminQueryGameSessions' test.out

#- 37 AdminQueryGameSessionsByAttributes
# body param: body
echo '{"MbJMwEI4": {}, "935IShzQ": {}, "twzxLXOl": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminQueryGameSessionsByAttributes \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 37 'AdminQueryGameSessionsByAttributes' test.out

#- 38 AdminDeleteBulkGameSessions
# body param: body
echo '{"ids": ["8KZhVhOg", "Ipb8oYLz", "XlaIcXqy"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminDeleteBulkGameSessions \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 38 'AdminDeleteBulkGameSessions' test.out

#- 39 AdminSetDSReady
# body param: body
echo '{"ready": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminSetDSReady \
    --namespace $AB_NAMESPACE \
    --sessionId 'zl7Xm2pB' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 39 'AdminSetDSReady' test.out

#- 40 AdminKickGameSessionMember
$CLI_EXE \
    --sn session \
    --op AdminKickGameSessionMember \
    --memberId 'crdtrPLB' \
    --namespace $AB_NAMESPACE \
    --sessionId 'Y9YcBge3' \
    > test.out 2>&1
eval_tap $? 40 'AdminKickGameSessionMember' test.out

#- 41 AdminUpdateGameSessionMember
$CLI_EXE \
    --sn session \
    --op AdminUpdateGameSessionMember \
    --memberId 'B9YXCoxR' \
    --namespace $AB_NAMESPACE \
    --sessionId 'Eq46sLOp' \
    --statusType 'DuiKuXIU' \
    > test.out 2>&1
eval_tap $? 41 'AdminUpdateGameSessionMember' test.out

#- 42 AdminGetListNativeSession
$CLI_EXE \
    --sn session \
    --op AdminGetListNativeSession \
    --namespace $AB_NAMESPACE \
    --limit '89' \
    --offset '21' \
    --order 'VtShSy5q' \
    > test.out 2>&1
eval_tap $? 42 'AdminGetListNativeSession' test.out

#- 43 AdminQueryParties
$CLI_EXE \
    --sn session \
    --op AdminQueryParties \
    --namespace $AB_NAMESPACE \
    --isSoftDeleted 'eigTIdtA' \
    --joinability 'KDKHcrAH' \
    --key 'vFcDdhvo' \
    --leaderID 'SpOsOkO5' \
    --limit '42' \
    --memberID 'GnwM9Pws' \
    --memberStatus 'PTD7k2mU' \
    --offset '59' \
    --order 'FEyMtgql' \
    --orderBy 'Vdk21XvN' \
    --partyID '7PSOwJdu' \
    --value 'XIDBApnn' \
    > test.out 2>&1
eval_tap $? 43 'AdminQueryParties' test.out

#- 44 AdminGetPlatformCredentials
$CLI_EXE \
    --sn session \
    --op AdminGetPlatformCredentials \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 44 'AdminGetPlatformCredentials' test.out

#- 45 AdminUpdatePlatformCredentials
# body param: body
echo '{"psn": {"clientId": "0xHTvVVH", "clientSecret": "NAaH37aN", "scope": "0n9FrUme"}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminUpdatePlatformCredentials \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 45 'AdminUpdatePlatformCredentials' test.out

#- 46 AdminDeletePlatformCredentials
$CLI_EXE \
    --sn session \
    --op AdminDeletePlatformCredentials \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 46 'AdminDeletePlatformCredentials' test.out

#- 47 AdminGetRecentPlayer
$CLI_EXE \
    --sn session \
    --op AdminGetRecentPlayer \
    --namespace $AB_NAMESPACE \
    --limit '54' \
    --userId 'nH2kayaW' \
    > test.out 2>&1
eval_tap $? 47 'AdminGetRecentPlayer' test.out

#- 48 AdminGetRecentTeamPlayer
$CLI_EXE \
    --sn session \
    --op AdminGetRecentTeamPlayer \
    --namespace $AB_NAMESPACE \
    --limit '16' \
    --userId '2zH8D0zX' \
    > test.out 2>&1
eval_tap $? 48 'AdminGetRecentTeamPlayer' test.out

#- 49 AdminReadSessionStorage
$CLI_EXE \
    --sn session \
    --op AdminReadSessionStorage \
    --namespace $AB_NAMESPACE \
    --sessionId 'YloEbii3' \
    > test.out 2>&1
eval_tap $? 49 'AdminReadSessionStorage' test.out

#- 50 AdminDeleteUserSessionStorage
$CLI_EXE \
    --sn session \
    --op AdminDeleteUserSessionStorage \
    --namespace $AB_NAMESPACE \
    --sessionId 'xdmcNvbY' \
    > test.out 2>&1
eval_tap $? 50 'AdminDeleteUserSessionStorage' test.out

#- 51 AdminReadUserSessionStorage
$CLI_EXE \
    --sn session \
    --op AdminReadUserSessionStorage \
    --namespace $AB_NAMESPACE \
    --sessionId 'QYvTSVg5' \
    --userId 'VoozAN63' \
    > test.out 2>&1
eval_tap $? 51 'AdminReadUserSessionStorage' test.out

#- 52 AdminQueryPlayerAttributes
$CLI_EXE \
    --sn session \
    --op AdminQueryPlayerAttributes \
    --namespace $AB_NAMESPACE \
    --users 'Q4IchU2W' \
    > test.out 2>&1
eval_tap $? 52 'AdminQueryPlayerAttributes' test.out

#- 53 AdminGetPlayerAttributes
$CLI_EXE \
    --sn session \
    --op AdminGetPlayerAttributes \
    --namespace $AB_NAMESPACE \
    --userId 'MO5cxgxt' \
    > test.out 2>&1
eval_tap $? 53 'AdminGetPlayerAttributes' test.out

#- 54 AdminSyncNativeSession
$CLI_EXE \
    --sn session \
    --op AdminSyncNativeSession \
    --namespace $AB_NAMESPACE \
    --userId 'Oyh0VcHS' \
    > test.out 2>&1
eval_tap $? 54 'AdminSyncNativeSession' test.out

#- 55 CreateGameSession
# body param: body
echo '{"appName": "ezQ69TcA", "attributes": {"ZBSAI445": {}, "D0xJNR2u": {}, "5f1NezP2": {}}, "autoJoin": true, "backfillTicketID": "yNtWxHga", "clientVersion": "ER3Eowci", "configurationName": "ZtCKVoQI", "customURLGRPC": "Q0FwkMNA", "deployment": "s0GJjppO", "dsSource": "dmTD9p5T", "fallbackClaimKeys": ["3PZOj2Rm", "uEVWffuK", "wRBmqihJ"], "inactiveTimeout": 1, "inviteTimeout": 68, "joinability": "UAMXJZdH", "matchPool": "louzxej8", "maxPlayers": 61, "minPlayers": 45, "preferredClaimKeys": ["RPHwOpvq", "Fc854w0y", "cEHYfJpU"], "requestedRegions": ["ywz5iwoq", "Sxz7259j", "YP0xqbhv"], "serverName": "ZWDcDEBj", "storage": {"leader": {"gJEdXsyD": {}, "CYrhWjyN": {}, "G4eJ9o6S": {}}}, "teams": [{"parties": [{"partyID": "i3KIWx6N", "userIDs": ["m60oNsIk", "GVEiSp6I", "kT8QFy54"]}, {"partyID": "M87gz1L4", "userIDs": ["YedJskYa", "1xVIbtyC", "xbXBSxo3"]}, {"partyID": "Z1Lm0OH3", "userIDs": ["TqSXNYjP", "C2wnUYne", "XNHjp723"]}], "userIDs": ["xPMqYAEy", "srWktyn8", "unxkCwyL"]}, {"parties": [{"partyID": "iWNki2pR", "userIDs": ["uEYusZxq", "LauH2QCV", "Z0LgKeuA"]}, {"partyID": "bDqqWAaH", "userIDs": ["HOzjfoqu", "tmRZNgLG", "qpG4XA1j"]}, {"partyID": "yupqOxdz", "userIDs": ["VZe9d576", "q2YYazl4", "j9IPjWNz"]}], "userIDs": ["oRdFyAGW", "RhrsvpIH", "wA5nDrS0"]}, {"parties": [{"partyID": "rUwLatpa", "userIDs": ["t27cPKt9", "o6pGCqSD", "Apz5kpPp"]}, {"partyID": "sQNUgsN4", "userIDs": ["BnNuXfuR", "hCScUhKZ", "dCbk3ofO"]}, {"partyID": "0ntbx9TN", "userIDs": ["pYXp9xp2", "T0SQ5anV", "EshFdsLy"]}], "userIDs": ["0mi4kBSZ", "r7EL5jmw", "YShQpKm9"]}], "textChat": true, "ticketIDs": ["YUtRfGD0", "Q7lpIhTa", "LOQdM56G"], "tieTeamsSessionLifetime": false, "type": "Qwy2Awk5"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op CreateGameSession \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 55 'CreateGameSession' test.out

#- 56 PublicQueryGameSessionsByAttributes
# body param: body
echo '{"UfaqhhWt": {}, "h9UtbEAw": {}, "ipor9Q84": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicQueryGameSessionsByAttributes \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 56 'PublicQueryGameSessionsByAttributes' test.out

#- 57 PublicSessionJoinCode
# body param: body
echo '{"code": "SMPBFdBN"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicSessionJoinCode \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 57 'PublicSessionJoinCode' test.out

#- 58 GetGameSessionByPodName
$CLI_EXE \
    --sn session \
    --op GetGameSessionByPodName \
    --namespace $AB_NAMESPACE \
    --podName 'wEjYDisS' \
    > test.out 2>&1
eval_tap $? 58 'GetGameSessionByPodName' test.out

#- 59 GetGameSession
$CLI_EXE \
    --sn session \
    --op GetGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'Er6uzVnA' \
    > test.out 2>&1
eval_tap $? 59 'GetGameSession' test.out

#- 60 UpdateGameSession
# body param: body
echo '{"attributes": {"gIw1fTEV": {}, "f3w6OkX5": {}, "TOVjjnch": {}}, "backfillTicketID": "OxgOLDlB", "clientVersion": "ehJLeRBD", "deployment": "U6wdoCe3", "fallbackClaimKeys": ["PPiRPwtD", "XsN3u6P3", "xqS4UvEM"], "inactiveTimeout": 68, "inviteTimeout": 52, "joinability": "f1Pgig9j", "matchPool": "LRM6REGm", "maxPlayers": 47, "minPlayers": 98, "preferredClaimKeys": ["Q8mVzyPh", "6m1lRqvd", "LeGMvnVi"], "requestedRegions": ["rPTRlxgC", "oU8t3BIg", "3aLlGom3"], "teams": [{"parties": [{"partyID": "jkLxegGS", "userIDs": ["hhWP7UVz", "LxqVz05x", "rsy7dvAk"]}, {"partyID": "X4dHSe1B", "userIDs": ["4KgwCWc5", "8GsW2zzO", "xDncPdgq"]}, {"partyID": "kQHl5uLm", "userIDs": ["bdsBNnHd", "l0MwUW2Z", "fPe3BeBi"]}], "userIDs": ["0EuqXUDa", "lSL18gM1", "Lpbv0yvi"]}, {"parties": [{"partyID": "NpVCObCE", "userIDs": ["BRlVuXnI", "9h6R6HaA", "weorIUbt"]}, {"partyID": "i4zMoDI9", "userIDs": ["HVfeFpmr", "NZjjZlz4", "1MGfW1iy"]}, {"partyID": "oryJ2IHD", "userIDs": ["K4o3bIFE", "seHpC9ra", "2RljHXMF"]}], "userIDs": ["skKw6Tp9", "Xfn19FSa", "KxYdgOeL"]}, {"parties": [{"partyID": "gyWocPOK", "userIDs": ["jJGaOmuC", "SEx61XI4", "Ra5HBu0t"]}, {"partyID": "qzD88fXd", "userIDs": ["wBStFZ75", "bjJT6TMy", "CNEIPRJP"]}, {"partyID": "UO6apWfD", "userIDs": ["ak9AteK1", "JH5utBD8", "di25GzlP"]}], "userIDs": ["OQMmwuqa", "ZSqA0Oth", "RpHRDK51"]}], "ticketIDs": ["baF2kP64", "hDxHRRx5", "ejXw8h7o"], "tieTeamsSessionLifetime": false, "type": "eA7c31nd", "version": 6}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op UpdateGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'w0o3OVMO' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 60 'UpdateGameSession' test.out

#- 61 DeleteGameSession
$CLI_EXE \
    --sn session \
    --op DeleteGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'Cw2G4VqD' \
    > test.out 2>&1
eval_tap $? 61 'DeleteGameSession' test.out

#- 62 PatchUpdateGameSession
# body param: body
echo '{"attributes": {"T8pWGyOB": {}, "IgzFPsuJ": {}, "St9qHUJ0": {}}, "backfillTicketID": "ZADW5RSe", "clientVersion": "oa9wr4QY", "deployment": "9NFUxnwh", "fallbackClaimKeys": ["JXSiGqbL", "UkVJWcHh", "tCTTLVb8"], "inactiveTimeout": 98, "inviteTimeout": 10, "joinability": "SPZm6PlY", "matchPool": "D95FkIKj", "maxPlayers": 38, "minPlayers": 25, "preferredClaimKeys": ["eDdUIyxP", "BIGwAsRs", "gQ7hdMHq"], "requestedRegions": ["taJEuOb0", "VbnfEQWx", "mjvrmQYQ"], "teams": [{"parties": [{"partyID": "Y1vJyeVY", "userIDs": ["wPDydya0", "n5mtxzXT", "WxZZUNgF"]}, {"partyID": "3uRFpeLj", "userIDs": ["4jeZLXng", "7qmdmsIH", "JfNC7iTE"]}, {"partyID": "T6McYieL", "userIDs": ["ofC5WiX0", "jZ5t1XGy", "rwmR9Nah"]}], "userIDs": ["lQ53xZdt", "VR2rvrwz", "xYIen3oE"]}, {"parties": [{"partyID": "u8hL0st1", "userIDs": ["IH7yBvrH", "pQcCNFrt", "L1bp7wuL"]}, {"partyID": "A6n66jJ6", "userIDs": ["35xMP64M", "PNpHvv8o", "7JdoORPP"]}, {"partyID": "tWbLx6TU", "userIDs": ["4f6gCYEo", "qvtY5DCX", "wSCZyigI"]}], "userIDs": ["6ZIUrowU", "AHbhocbG", "mmsDdS8f"]}, {"parties": [{"partyID": "GRl3iUOC", "userIDs": ["MVVUZHbw", "TZFfs9fK", "QND07VAX"]}, {"partyID": "eYKimDA8", "userIDs": ["fS1doIPY", "r4fGMDTX", "plVycFR3"]}, {"partyID": "5JtoxePI", "userIDs": ["mT2dg3Bo", "wOoVfIhH", "lxJmX6fM"]}], "userIDs": ["G4eEYFyD", "1a5BzYet", "3yQWysCa"]}], "ticketIDs": ["mSy5RVgT", "LRyeTrRh", "SQQ3VGii"], "tieTeamsSessionLifetime": true, "type": "ah0WzOel", "version": 15}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PatchUpdateGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId '9lw4CA2I' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 62 'PatchUpdateGameSession' test.out

#- 63 UpdateGameSessionBackfillTicketID
# body param: body
echo '{"backfillTicketID": "tcN0C9Lp"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op UpdateGameSessionBackfillTicketID \
    --namespace $AB_NAMESPACE \
    --sessionId '8XNZSbJt' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 63 'UpdateGameSessionBackfillTicketID' test.out

#- 64 GameSessionGenerateCode
$CLI_EXE \
    --sn session \
    --op GameSessionGenerateCode \
    --namespace $AB_NAMESPACE \
    --sessionId 'yj5hScz6' \
    > test.out 2>&1
eval_tap $? 64 'GameSessionGenerateCode' test.out

#- 65 PublicRevokeGameSessionCode
$CLI_EXE \
    --sn session \
    --op PublicRevokeGameSessionCode \
    --namespace $AB_NAMESPACE \
    --sessionId 'BAJryFFx' \
    > test.out 2>&1
eval_tap $? 65 'PublicRevokeGameSessionCode' test.out

#- 66 PublicGameSessionInvite
# body param: body
echo '{"platformID": "TuAdo4RD", "userID": "EzG5Dutc"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicGameSessionInvite \
    --namespace $AB_NAMESPACE \
    --sessionId 'L7wu9owg' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 66 'PublicGameSessionInvite' test.out

#- 67 JoinGameSession
$CLI_EXE \
    --sn session \
    --op JoinGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'mW5MmGwx' \
    > test.out 2>&1
eval_tap $? 67 'JoinGameSession' test.out

#- 68 PublicPromoteGameSessionLeader
# body param: body
echo '{"leaderID": "8ZPz6Qc2"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPromoteGameSessionLeader \
    --namespace $AB_NAMESPACE \
    --sessionId '7ZIyXfdk' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 68 'PublicPromoteGameSessionLeader' test.out

#- 69 LeaveGameSession
$CLI_EXE \
    --sn session \
    --op LeaveGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'CO4dMlVp' \
    > test.out 2>&1
eval_tap $? 69 'LeaveGameSession' test.out

#- 70 PublicKickGameSessionMember
$CLI_EXE \
    --sn session \
    --op PublicKickGameSessionMember \
    --memberId 'AXmNg8yz' \
    --namespace $AB_NAMESPACE \
    --sessionId 'FjGEVpQU' \
    > test.out 2>&1
eval_tap $? 70 'PublicKickGameSessionMember' test.out

#- 71 PublicGameSessionReject
$CLI_EXE \
    --sn session \
    --op PublicGameSessionReject \
    --namespace $AB_NAMESPACE \
    --sessionId '2lQRAs8d' \
    > test.out 2>&1
eval_tap $? 71 'PublicGameSessionReject' test.out

#- 72 GetSessionServerSecret
$CLI_EXE \
    --sn session \
    --op GetSessionServerSecret \
    --namespace $AB_NAMESPACE \
    --sessionId 'vD49mVAb' \
    > test.out 2>&1
eval_tap $? 72 'GetSessionServerSecret' test.out

#- 73 AppendTeamGameSession
# body param: body
echo '{"additionalMembers": [{"partyID": "GARAPd4k", "userIDs": ["eC1RtUDz", "d8SaSvz8", "485Jc6de"]}, {"partyID": "E3ixlgKH", "userIDs": ["XTgyxCGJ", "QLBnaxbz", "wXIHXZsW"]}, {"partyID": "YLUFcgLT", "userIDs": ["zGyaFQ0p", "juvsDwPG", "Z8MgA0fw"]}], "proposedTeams": [{"parties": [{"partyID": "OFW5k8M4", "userIDs": ["Gs3sQQsa", "pIwdA9w6", "t9KGgENd"]}, {"partyID": "62NXfIar", "userIDs": ["Dx5ilpGe", "FbKPme47", "2rlTj8sF"]}, {"partyID": "G3ifuEwp", "userIDs": ["2rdSNzWg", "s4nMgydA", "vaSEgH2L"]}], "userIDs": ["hg9JTxtG", "o6SR3OCG", "pEfJGnt1"]}, {"parties": [{"partyID": "MXOxWmi0", "userIDs": ["alCTTEhs", "k46aKO4z", "zHJdv0GE"]}, {"partyID": "NU5UM3Zt", "userIDs": ["mlwojlwu", "aFhBAqf4", "vN25xi9N"]}, {"partyID": "XVgFF48y", "userIDs": ["wA0falkL", "jO0ABlGG", "jv8eNaC4"]}], "userIDs": ["9dgozMdo", "aBpFC4Zr", "H0nwmcng"]}, {"parties": [{"partyID": "Lz7aIYPP", "userIDs": ["hxPRW5UX", "NNcwcYMY", "pQ2xOQj1"]}, {"partyID": "CWejOm9F", "userIDs": ["bHf0oiKE", "Aay4mXLh", "1McSYTJZ"]}, {"partyID": "YX5Gqjg5", "userIDs": ["nfMHcH9T", "pgCKkdik", "5Bn9i8mX"]}], "userIDs": ["56FkEA38", "CbWwj0LM", "BVlZt5kU"]}], "version": 19}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AppendTeamGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'XeK4yxN4' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 73 'AppendTeamGameSession' test.out

#- 74 PublicGameSessionCancel
$CLI_EXE \
    --sn session \
    --op PublicGameSessionCancel \
    --namespace $AB_NAMESPACE \
    --sessionId 'Of0vrqHX' \
    --userId 'T8lp1Pnu' \
    > test.out 2>&1
eval_tap $? 74 'PublicGameSessionCancel' test.out

#- 75 PublicPartyJoinCode
# body param: body
echo '{"code": "1UKuiFcs"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPartyJoinCode \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 75 'PublicPartyJoinCode' test.out

#- 76 PublicGetParty
$CLI_EXE \
    --sn session \
    --op PublicGetParty \
    --namespace $AB_NAMESPACE \
    --partyId 'L8pPIGZj' \
    > test.out 2>&1
eval_tap $? 76 'PublicGetParty' test.out

#- 77 PublicUpdateParty
# body param: body
echo '{"attributes": {"dkU3AeqM": {}, "WFyc5mLW": {}, "6ErKp0xg": {}}, "inactiveTimeout": 6, "inviteTimeout": 94, "joinability": "GnK2Yk4R", "maxPlayers": 90, "minPlayers": 41, "type": "crdu4Gu7", "version": 48}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicUpdateParty \
    --namespace $AB_NAMESPACE \
    --partyId 'VowU8tsd' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 77 'PublicUpdateParty' test.out

#- 78 PublicPatchUpdateParty
# body param: body
echo '{"attributes": {"fLyNoTNZ": {}, "QAtjasIE": {}, "4VSapjo7": {}}, "inactiveTimeout": 51, "inviteTimeout": 23, "joinability": "AaoMNwNS", "maxPlayers": 80, "minPlayers": 43, "type": "jmo3sLbg", "version": 97}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPatchUpdateParty \
    --namespace $AB_NAMESPACE \
    --partyId 'YVR6J2fH' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 78 'PublicPatchUpdateParty' test.out

#- 79 PublicGeneratePartyCode
$CLI_EXE \
    --sn session \
    --op PublicGeneratePartyCode \
    --namespace $AB_NAMESPACE \
    --partyId '1a91xQRA' \
    > test.out 2>&1
eval_tap $? 79 'PublicGeneratePartyCode' test.out

#- 80 PublicRevokePartyCode
$CLI_EXE \
    --sn session \
    --op PublicRevokePartyCode \
    --namespace $AB_NAMESPACE \
    --partyId 'wzjRFlyo' \
    > test.out 2>&1
eval_tap $? 80 'PublicRevokePartyCode' test.out

#- 81 PublicPartyInvite
# body param: body
echo '{"platformID": "d8OpGPcu", "userID": "S3UrScxF"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPartyInvite \
    --namespace $AB_NAMESPACE \
    --partyId 'paKtKCZ3' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 81 'PublicPartyInvite' test.out

#- 82 PublicPromotePartyLeader
# body param: body
echo '{"leaderID": "1N5AhDM6"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPromotePartyLeader \
    --namespace $AB_NAMESPACE \
    --partyId 'q6weSZig' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 82 'PublicPromotePartyLeader' test.out

#- 83 PublicPartyJoin
$CLI_EXE \
    --sn session \
    --op PublicPartyJoin \
    --namespace $AB_NAMESPACE \
    --partyId 'KQF6E4Sf' \
    > test.out 2>&1
eval_tap $? 83 'PublicPartyJoin' test.out

#- 84 PublicPartyLeave
$CLI_EXE \
    --sn session \
    --op PublicPartyLeave \
    --namespace $AB_NAMESPACE \
    --partyId 'qYjQsNsT' \
    > test.out 2>&1
eval_tap $? 84 'PublicPartyLeave' test.out

#- 85 PublicPartyReject
$CLI_EXE \
    --sn session \
    --op PublicPartyReject \
    --namespace $AB_NAMESPACE \
    --partyId 'pz2zxkpU' \
    > test.out 2>&1
eval_tap $? 85 'PublicPartyReject' test.out

#- 86 PublicPartyCancel
$CLI_EXE \
    --sn session \
    --op PublicPartyCancel \
    --namespace $AB_NAMESPACE \
    --partyId 'pR6bFpp4' \
    --userId 'euh7fnC6' \
    > test.out 2>&1
eval_tap $? 86 'PublicPartyCancel' test.out

#- 87 PublicPartyKick
$CLI_EXE \
    --sn session \
    --op PublicPartyKick \
    --namespace $AB_NAMESPACE \
    --partyId 'sFa8lFHV' \
    --userId 'wp9kocaf' \
    > test.out 2>&1
eval_tap $? 87 'PublicPartyKick' test.out

#- 88 PublicCreateParty
# body param: body
echo '{"attributes": {"oJZatVFO": {}, "QxZAJSDo": {}, "o4c8tUAn": {}}, "configurationName": "6wjgjyod", "inactiveTimeout": 29, "inviteTimeout": 92, "joinability": "F7oJW3dV", "maxPlayers": 42, "members": [{"ID": "BoG8ZsPb", "PlatformID": "l07UacXw", "PlatformUserID": "xiNC4FCp"}, {"ID": "D6Om2dNB", "PlatformID": "094Y6w2c", "PlatformUserID": "c3HQTYbs"}, {"ID": "gSHTa959", "PlatformID": "Q6sKRCep", "PlatformUserID": "fyBI1Xmv"}], "minPlayers": 69, "textChat": true, "type": "Wkx0H5i9"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicCreateParty \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 88 'PublicCreateParty' test.out

#- 89 PublicGetRecentPlayer
$CLI_EXE \
    --sn session \
    --op PublicGetRecentPlayer \
    --namespace $AB_NAMESPACE \
    --limit '40' \
    > test.out 2>&1
eval_tap $? 89 'PublicGetRecentPlayer' test.out

#- 90 PublicGetRecentTeamPlayer
$CLI_EXE \
    --sn session \
    --op PublicGetRecentTeamPlayer \
    --namespace $AB_NAMESPACE \
    --limit '57' \
    > test.out 2>&1
eval_tap $? 90 'PublicGetRecentTeamPlayer' test.out

#- 91 PublicUpdateInsertSessionStorageLeader
# body param: body
echo '{"oSROtw6w": {}, "yqZUoRfQ": {}, "bYa2GNeZ": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicUpdateInsertSessionStorageLeader \
    --namespace $AB_NAMESPACE \
    --sessionId 'sENimj2F' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 91 'PublicUpdateInsertSessionStorageLeader' test.out

#- 92 PublicUpdateInsertSessionStorage
# body param: body
echo '{"dhZRqM1T": {}, "X68Mh0ew": {}, "NUreff8r": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicUpdateInsertSessionStorage \
    --namespace $AB_NAMESPACE \
    --sessionId 'hObYRoKJ' \
    --userId '7gIFl6NB' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 92 'PublicUpdateInsertSessionStorage' test.out

#- 93 PublicGetBulkPlayerCurrentPlatform
# body param: body
echo '{"userIDs": ["lxKU6fJM", "ycgh4gEf", "6NjtThy7"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicGetBulkPlayerCurrentPlatform \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 93 'PublicGetBulkPlayerCurrentPlatform' test.out

#- 94 PublicGetPlayerAttributes
$CLI_EXE \
    --sn session \
    --op PublicGetPlayerAttributes \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 94 'PublicGetPlayerAttributes' test.out

#- 95 PublicStorePlayerAttributes
# body param: body
echo '{"crossplayEnabled": true, "currentPlatform": "hq5SLFJQ", "data": {"0KviPOHn": {}, "l2WWcM2g": {}, "r0RVmu4Z": {}}, "platforms": [{"name": "Zl6NAcTf", "userID": "07CMiL1I"}, {"name": "IEAZkwH0", "userID": "iS3jbCOm"}, {"name": "Fu2sbEKO", "userID": "AdLsy926"}], "roles": ["r5YjqaFA", "0YwJFQas", "4LQ857VI"], "simultaneousPlatform": "QLMN8a1D"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicStorePlayerAttributes \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 95 'PublicStorePlayerAttributes' test.out

#- 96 PublicDeletePlayerAttributes
$CLI_EXE \
    --sn session \
    --op PublicDeletePlayerAttributes \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 96 'PublicDeletePlayerAttributes' test.out

#- 97 PublicQueryMyGameSessions
$CLI_EXE \
    --sn session \
    --op PublicQueryMyGameSessions \
    --namespace $AB_NAMESPACE \
    --order 'vzM16FRt' \
    --orderBy 'IwpnXPap' \
    --status 'cUBuij4Y' \
    > test.out 2>&1
eval_tap $? 97 'PublicQueryMyGameSessions' test.out

#- 98 PublicQueryMyParties
$CLI_EXE \
    --sn session \
    --op PublicQueryMyParties \
    --namespace $AB_NAMESPACE \
    --order 'bsI4ps3y' \
    --orderBy 'LO7wfjN0' \
    --status 'a1kQfW4v' \
    > test.out 2>&1
eval_tap $? 98 'PublicQueryMyParties' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE