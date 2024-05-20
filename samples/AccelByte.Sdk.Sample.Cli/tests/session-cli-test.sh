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
echo "1..82"

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
echo '{"regionRetryMapping": {"tM2WYgp0": ["rFs6a6Kf", "O6onczRd", "1u2vxTfB"], "uSLRfaJH": ["mdKgjnrd", "7htTRQQQ", "e0HGmUnM"], "l29Y9Kpi": ["qkV0khzH", "dO31x4NI", "SunFG5lM"]}, "regionURLMapping": ["6Gjj2g4A", "iTUqdm1k", "bFKExObP"], "testGameMode": "0PHBDF5n", "testRegionURLMapping": ["pqa0o0eM", "ZM9UqGl0", "Q03SICn7"], "testTargetUserIDs": ["MjeRibm7", "Tqt8MsPt", "UNcBZXxe"]}' > $TEMP_JSON_INPUT
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
echo '{"durationDays": 97}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminUpdateConfigurationAlertV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 12 'AdminUpdateConfigurationAlertV1' test.out

#- 13 AdminCreateConfigurationAlertV1
# body param: body
echo '{"durationDays": 25}' > $TEMP_JSON_INPUT
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
    --description 'PLgCxSd5' \
    --certname 'zV0SkLH6' \
    --upload file $TEMP_FILE_UPLOAD \
    --password 'YlDMpOL5' \
    > test.out 2>&1
eval_tap $? 15 'HandleUploadXboxPFXCertificate' test.out

#- 16 AdminCreateConfigurationTemplateV1
# body param: body
echo '{"NativeSessionSetting": {"PSNServiceLabel": 62, "PSNSupportedPlatforms": ["B4TmbOVH", "qhrlcKsZ", "jd3VYITs"], "SessionTitle": "iYYNpuqD", "ShouldSync": false, "XboxAllowCrossPlatform": true, "XboxSandboxID": "ZOxtfLt1", "XboxServiceConfigID": "lQtHnqej", "XboxSessionTemplateName": "VjKpflY0", "XboxTitleID": "ltxshvXP", "localizedSessionName": {"8YanZuEz": {}, "s7ecBLE5": {}, "Q19lt1K9": {}}}, "PSNBaseUrl": "T7PR0nI2", "attributes": {"QxUTd7oo": {}, "FkoCcRqG": {}, "q6GZKNE8": {}}, "autoJoin": true, "autoLeaveSession": false, "clientVersion": "mf1yQjgY", "deployment": "zlQzCd5j", "disableCodeGeneration": true, "dsManualSetReady": true, "dsSource": "UhQjEb1M", "enableSecret": true, "fallbackClaimKeys": ["ZSMCLgb0", "taRks82k", "tS8hwMp8"], "immutableStorage": true, "inactiveTimeout": 74, "inviteTimeout": 62, "joinability": "Rnl5a78t", "leaderElectionGracePeriod": 90, "manualRejoin": false, "maxActiveSessions": 47, "maxPlayers": 13, "minPlayers": 37, "name": "igSaaTut", "persistent": false, "preferredClaimKeys": ["Nx1XWnbZ", "WWkxYYwl", "qIr0V6Ma"], "requestedRegions": ["vMkAkSdr", "NwbccppZ", "GCY080EY"], "textChat": false, "tieTeamsSessionLifetime": false, "type": "7uhTcsCV"}' > $TEMP_JSON_INPUT
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
    --limit '33' \
    --name '0DdX9tc1' \
    --offset '42' \
    --order '6G7rdqa5' \
    --orderBy 'ha0CurPe' \
    > test.out 2>&1
eval_tap $? 17 'AdminGetAllConfigurationTemplatesV1' test.out

#- 18 AdminGetConfigurationTemplateV1
$CLI_EXE \
    --sn session \
    --op AdminGetConfigurationTemplateV1 \
    --name 'SK0tgHwG' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 18 'AdminGetConfigurationTemplateV1' test.out

#- 19 AdminUpdateConfigurationTemplateV1
# body param: body
echo '{"NativeSessionSetting": {"PSNServiceLabel": 44, "PSNSupportedPlatforms": ["tZMaQSOb", "ZbbDq4zp", "UlzWVlIe"], "SessionTitle": "R3xjprqP", "ShouldSync": true, "XboxAllowCrossPlatform": false, "XboxSandboxID": "jmOZkPzh", "XboxServiceConfigID": "nX7Zf7oh", "XboxSessionTemplateName": "wC7yp0Ih", "XboxTitleID": "yXfV8MhL", "localizedSessionName": {"6ns0E4sa": {}, "YxrSpaU2": {}, "qwj1GPNX": {}}}, "PSNBaseUrl": "uaSsu6w5", "attributes": {"t9FFnclo": {}, "HPNACjj8": {}, "WRQu5b82": {}}, "autoJoin": true, "autoLeaveSession": true, "clientVersion": "qTJuXcYZ", "deployment": "gfc0QXQH", "disableCodeGeneration": false, "dsManualSetReady": true, "dsSource": "d7j9qpcE", "enableSecret": true, "fallbackClaimKeys": ["nbug7YoJ", "n3STrCAC", "pBStvb3W"], "immutableStorage": true, "inactiveTimeout": 21, "inviteTimeout": 41, "joinability": "qjMlO1jn", "leaderElectionGracePeriod": 56, "manualRejoin": false, "maxActiveSessions": 80, "maxPlayers": 82, "minPlayers": 35, "name": "8vk6LJ7l", "persistent": true, "preferredClaimKeys": ["pZOtqY9I", "pMh87X0m", "9UTGUNJO"], "requestedRegions": ["4XNDugAr", "sgvc6RgP", "Kvtpxd7D"], "textChat": false, "tieTeamsSessionLifetime": false, "type": "ftZQQvBH"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminUpdateConfigurationTemplateV1 \
    --name 'vvhljvKd' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 19 'AdminUpdateConfigurationTemplateV1' test.out

#- 20 AdminDeleteConfigurationTemplateV1
$CLI_EXE \
    --sn session \
    --op AdminDeleteConfigurationTemplateV1 \
    --name '9yavGIkf' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 20 'AdminDeleteConfigurationTemplateV1' test.out

#- 21 AdminGetMemberActiveSession
$CLI_EXE \
    --sn session \
    --op AdminGetMemberActiveSession \
    --name 'aALhuT6p' \
    --namespace $AB_NAMESPACE \
    --userId 'VGuubS1n' \
    > test.out 2>&1
eval_tap $? 21 'AdminGetMemberActiveSession' test.out

#- 22 AdminReconcileMaxActiveSession
# body param: body
echo '{"userID": "g0CTTjja"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminReconcileMaxActiveSession \
    --name 'MRkxKiw0' \
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
    --configurationName '7uVkAKIG' \
    --dsPodName '9Rctk5cL' \
    --fromTime 'U4yxRcjs' \
    --gameMode 'CQVCrYFu' \
    --isPersistent 'Gv1jnyyK' \
    --isSoftDeleted 'DiQDxwTx' \
    --joinability '5SEUEJYf' \
    --limit '99' \
    --matchPool 'RHDb4p2K' \
    --memberID '8LoB62oS' \
    --offset '45' \
    --order 'Fta89Z0U' \
    --orderBy '41Z4wcVL' \
    --sessionID 'VBrEP8Rv' \
    --status '9dldLn2j' \
    --statusV2 'nvmTotJp' \
    --toTime '1vL9NTuD' \
    > test.out 2>&1
eval_tap $? 25 'AdminQueryGameSessions' test.out

#- 26 AdminQueryGameSessionsByAttributes
# body param: body
echo '{"bxYqsLSW": {}, "V0tRYB7b": {}, "yv7DR6ke": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminQueryGameSessionsByAttributes \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 26 'AdminQueryGameSessionsByAttributes' test.out

#- 27 AdminDeleteBulkGameSessions
# body param: body
echo '{"ids": ["gZIesbSG", "Xhyh4FEv", "e98KR6FB"]}' > $TEMP_JSON_INPUT
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
    --sessionId 'BcPW8LBj' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 28 'AdminSetDSReady' test.out

#- 29 AdminUpdateGameSessionMember
$CLI_EXE \
    --sn session \
    --op AdminUpdateGameSessionMember \
    --memberId '4WJb8q3S' \
    --namespace $AB_NAMESPACE \
    --sessionId 'Oy4kR5hX' \
    --statusType 'ScY0NslV' \
    > test.out 2>&1
eval_tap $? 29 'AdminUpdateGameSessionMember' test.out

#- 30 AdminGetListNativeSession
$CLI_EXE \
    --sn session \
    --op AdminGetListNativeSession \
    --namespace $AB_NAMESPACE \
    --limit '83' \
    --offset '80' \
    --order 'vfAlkO6g' \
    > test.out 2>&1
eval_tap $? 30 'AdminGetListNativeSession' test.out

#- 31 AdminQueryParties
$CLI_EXE \
    --sn session \
    --op AdminQueryParties \
    --namespace $AB_NAMESPACE \
    --isSoftDeleted 'IitR22nf' \
    --joinability 'NaXwaePh' \
    --key 'limzxJxR' \
    --leaderID 'xtGGLP7h' \
    --limit '31' \
    --memberID 'Cldteq0N' \
    --memberStatus 'Oj9PethK' \
    --offset '40' \
    --order 'eTAvbtKf' \
    --orderBy 'ET7Oc1Wn' \
    --partyID '9Dt8yme5' \
    --value 'KZ8NEkGL' \
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
echo '{"psn": {"clientId": "kxFuwW2n", "clientSecret": "kISNzcaM", "scope": "rao5ZNmU"}}' > $TEMP_JSON_INPUT
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
    --limit '38' \
    --userId 'EZDUNgGj' \
    > test.out 2>&1
eval_tap $? 35 'AdminGetRecentPlayer' test.out

#- 36 AdminGetRecentTeamPlayer
$CLI_EXE \
    --sn session \
    --op AdminGetRecentTeamPlayer \
    --namespace $AB_NAMESPACE \
    --limit '42' \
    --userId 'lR4LGDxp' \
    > test.out 2>&1
eval_tap $? 36 'AdminGetRecentTeamPlayer' test.out

#- 37 AdminReadSessionStorage
$CLI_EXE \
    --sn session \
    --op AdminReadSessionStorage \
    --namespace $AB_NAMESPACE \
    --sessionId 'xfrV5scU' \
    > test.out 2>&1
eval_tap $? 37 'AdminReadSessionStorage' test.out

#- 38 AdminDeleteUserSessionStorage
$CLI_EXE \
    --sn session \
    --op AdminDeleteUserSessionStorage \
    --namespace $AB_NAMESPACE \
    --sessionId 'kzVni6jw' \
    > test.out 2>&1
eval_tap $? 38 'AdminDeleteUserSessionStorage' test.out

#- 39 AdminReadUserSessionStorage
$CLI_EXE \
    --sn session \
    --op AdminReadUserSessionStorage \
    --namespace $AB_NAMESPACE \
    --sessionId 'EJXAG81q' \
    --userId 'myTBibk4' \
    > test.out 2>&1
eval_tap $? 39 'AdminReadUserSessionStorage' test.out

#- 40 AdminQueryPlayerAttributes
$CLI_EXE \
    --sn session \
    --op AdminQueryPlayerAttributes \
    --namespace $AB_NAMESPACE \
    --users 'YVQQsf7C' \
    > test.out 2>&1
eval_tap $? 40 'AdminQueryPlayerAttributes' test.out

#- 41 AdminGetPlayerAttributes
$CLI_EXE \
    --sn session \
    --op AdminGetPlayerAttributes \
    --namespace $AB_NAMESPACE \
    --userId 'zRNeHBFk' \
    > test.out 2>&1
eval_tap $? 41 'AdminGetPlayerAttributes' test.out

#- 42 CreateGameSession
# body param: body
echo '{"attributes": {"PDKJkpHh": {}, "eQpwf5TL": {}, "5wNN8xnA": {}}, "autoJoin": false, "backfillTicketID": "Fd6gQOvw", "clientVersion": "S0F5PjK6", "configurationName": "k8mk4Hsy", "deployment": "L2ceiyOL", "dsSource": "vZE2S1qP", "fallbackClaimKeys": ["XPV8jPV6", "AdQwcKTQ", "6wVmya9M"], "inactiveTimeout": 74, "inviteTimeout": 46, "joinability": "CQ9JSZuP", "matchPool": "6IDEdOPQ", "maxPlayers": 88, "minPlayers": 65, "preferredClaimKeys": ["4bjVIdY5", "4kq0UL5J", "FllDMyYI"], "requestedRegions": ["97GzqbSw", "gyhJXY1w", "uiu1mtEp"], "serverName": "GuXtLVfU", "teams": [{"UserIDs": ["gNP7shEP", "xFrGE5RV", "GONyT0iJ"], "parties": [{"partyID": "NmlKEfHW", "userIDs": ["cqHWY16U", "mTjY282Q", "JP8yoygi"]}, {"partyID": "jJheh0zo", "userIDs": ["mbNRJEZc", "sIRdEWCn", "isCwcfgS"]}, {"partyID": "iyDofEVs", "userIDs": ["HZydVRYc", "7b32jnKZ", "aWCBonUy"]}]}, {"UserIDs": ["ZRC1Z6aY", "oWxjaomc", "Y2itStOl"], "parties": [{"partyID": "3FVgTQxs", "userIDs": ["yDumPtWQ", "ykUa4XLv", "NF42WZKW"]}, {"partyID": "wrTJIUam", "userIDs": ["Fcrg3pLs", "al40Owwq", "AwnNt6CA"]}, {"partyID": "S5XsNRPo", "userIDs": ["K5vG5RcZ", "UzYdJuBp", "zvQiZZib"]}]}, {"UserIDs": ["fxFu7VU6", "urOdz25i", "TKYZp6vA"], "parties": [{"partyID": "XnmikXeG", "userIDs": ["oz5W1YGL", "2aplwhRM", "Fyv9xuoD"]}, {"partyID": "bqYBRZs8", "userIDs": ["g3Adzthn", "gUBQcM3F", "M2cQfDpC"]}, {"partyID": "SFyAXeBU", "userIDs": ["1dVnDq9P", "rRfwhhRu", "Zov1ddXO"]}]}], "textChat": true, "ticketIDs": ["mBE7wJUC", "Z0nCYlM8", "7D1i64Wu"], "tieTeamsSessionLifetime": false, "type": "i7FXwXGE"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op CreateGameSession \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 42 'CreateGameSession' test.out

#- 43 PublicQueryGameSessionsByAttributes
# body param: body
echo '{"5PfqfgeA": {}, "6BTIr3Ht": {}, "b1DnzZ57": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicQueryGameSessionsByAttributes \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 43 'PublicQueryGameSessionsByAttributes' test.out

#- 44 PublicSessionJoinCode
# body param: body
echo '{"code": "TqjsrVwa"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicSessionJoinCode \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 44 'PublicSessionJoinCode' test.out

#- 45 GetGameSessionByPodName
$CLI_EXE \
    --sn session \
    --op GetGameSessionByPodName \
    --namespace $AB_NAMESPACE \
    --podName 'KiycpiJo' \
    > test.out 2>&1
eval_tap $? 45 'GetGameSessionByPodName' test.out

#- 46 GetGameSession
$CLI_EXE \
    --sn session \
    --op GetGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'GKKW1tvG' \
    > test.out 2>&1
eval_tap $? 46 'GetGameSession' test.out

#- 47 UpdateGameSession
# body param: body
echo '{"attributes": {"s5J5QMPN": {}, "Y9xM3EUW": {}, "L0v7sjIg": {}}, "backfillTicketID": "htAWXlmh", "clientVersion": "0RQtiEnI", "deployment": "oTWDaT5I", "fallbackClaimKeys": ["ATf6z2d2", "w1016xz1", "hp6jBVbt"], "inactiveTimeout": 17, "inviteTimeout": 23, "joinability": "MFT7yhzv", "matchPool": "ZLBasquH", "maxPlayers": 27, "minPlayers": 25, "preferredClaimKeys": ["5vD90gur", "8TYNjosI", "mpVjeiDl"], "requestedRegions": ["11n4cq58", "8EBiZeLT", "zP2P15eQ"], "teams": [{"UserIDs": ["APuN77wv", "KQOdyRan", "SpbPwVEP"], "parties": [{"partyID": "YJaI5vV6", "userIDs": ["6qvZ6Y5j", "9mDeRiEF", "T0pTjjrU"]}, {"partyID": "9kAlY7Og", "userIDs": ["ovZbLuSt", "eyvpBSgL", "3gK0UX7v"]}, {"partyID": "Uudzj74W", "userIDs": ["XqAaHF4v", "nuor7dQ2", "blqaqQJF"]}]}, {"UserIDs": ["8GwNdblA", "M5dLjjDu", "gWRAbStF"], "parties": [{"partyID": "8fvtayk7", "userIDs": ["tPwDjziA", "hXH8XEBZ", "4HzRHzkx"]}, {"partyID": "Ux7M6Mqh", "userIDs": ["I2981JW2", "Ia0xUqWQ", "b2wKpnH3"]}, {"partyID": "Uy2mV2Uh", "userIDs": ["xj5gpPyu", "woEr2ak5", "CPYTuxEF"]}]}, {"UserIDs": ["aI3Z2CVv", "gqgqlFrA", "rOyESz98"], "parties": [{"partyID": "peXU4Boy", "userIDs": ["X1Mw3km5", "N6LXQVOD", "xUokQwOh"]}, {"partyID": "bYHpcLlv", "userIDs": ["Tzy32v1R", "cEOPoqob", "8VTQ7j6M"]}, {"partyID": "euDQjPp4", "userIDs": ["k0dUtDCo", "qSDNbgvv", "oaLcTWvQ"]}]}], "ticketIDs": ["yKD8IGzW", "ozQB7Er6", "3PhCZmjo"], "tieTeamsSessionLifetime": false, "type": "b72qiBc6", "version": 35}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op UpdateGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 't8HH4Q31' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 47 'UpdateGameSession' test.out

#- 48 DeleteGameSession
$CLI_EXE \
    --sn session \
    --op DeleteGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'hrc2vdr8' \
    > test.out 2>&1
eval_tap $? 48 'DeleteGameSession' test.out

#- 49 PatchUpdateGameSession
# body param: body
echo '{"attributes": {"963LMPHn": {}, "CtgfQq0O": {}, "A4o6l2OF": {}}, "backfillTicketID": "oPGsvc73", "clientVersion": "i6mOxkIn", "deployment": "ScsGNI61", "fallbackClaimKeys": ["W4cndt7N", "v3GNnDKU", "SyOEA5x4"], "inactiveTimeout": 90, "inviteTimeout": 59, "joinability": "7QFlrzz0", "matchPool": "1VoFbx0t", "maxPlayers": 22, "minPlayers": 71, "preferredClaimKeys": ["DPqChS2R", "QMXNIv1T", "czcNtfcv"], "requestedRegions": ["bJz8kIPP", "qozlgRlg", "WbHdnmco"], "teams": [{"UserIDs": ["ObAo3jyx", "q8NRlSw4", "SpMWBF6Q"], "parties": [{"partyID": "ftGGr06J", "userIDs": ["KMyj9I9l", "iWYSXF2T", "Qf4hqiE5"]}, {"partyID": "gtI5hoyT", "userIDs": ["JAX1qdfI", "2sw0aN9O", "28kadDAN"]}, {"partyID": "3kwDcF3K", "userIDs": ["eebVPaL2", "14vV05VH", "6ATBTjvy"]}]}, {"UserIDs": ["gtYHcB4G", "uJGTVufv", "0xN61Wo3"], "parties": [{"partyID": "EQrR7sZA", "userIDs": ["DFwJ1UUl", "LTIcDndD", "jyqA6xTQ"]}, {"partyID": "aJeBKUmM", "userIDs": ["GuoeLMN9", "ff7DSxHg", "DWKeOzft"]}, {"partyID": "tabDM5oX", "userIDs": ["MJn7evRm", "CbgcjGdb", "RuykHfXi"]}]}, {"UserIDs": ["usgyTHKJ", "BfBMGRZI", "2pWVtK3K"], "parties": [{"partyID": "InYOQdQn", "userIDs": ["6Ct5eYZq", "BZjgTsKc", "ssfg0Fce"]}, {"partyID": "mKGa6tpn", "userIDs": ["2o54AcuQ", "rGzzUbaY", "G4L1EBo4"]}, {"partyID": "mXMnTz6y", "userIDs": ["YAqDAX8m", "X4T2UJ2F", "NfjQkW2X"]}]}], "ticketIDs": ["4ldJf7bm", "mATekdPF", "MUUqqWB5"], "tieTeamsSessionLifetime": true, "type": "kiU85XDf", "version": 82}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PatchUpdateGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'LyHDxU6O' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 49 'PatchUpdateGameSession' test.out

#- 50 UpdateGameSessionBackfillTicketID
# body param: body
echo '{"backfillTicketID": "OEUtpSUF"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op UpdateGameSessionBackfillTicketID \
    --namespace $AB_NAMESPACE \
    --sessionId 'HlVPLniF' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 50 'UpdateGameSessionBackfillTicketID' test.out

#- 51 GameSessionGenerateCode
$CLI_EXE \
    --sn session \
    --op GameSessionGenerateCode \
    --namespace $AB_NAMESPACE \
    --sessionId 'kReL1Rhf' \
    > test.out 2>&1
eval_tap $? 51 'GameSessionGenerateCode' test.out

#- 52 PublicRevokeGameSessionCode
$CLI_EXE \
    --sn session \
    --op PublicRevokeGameSessionCode \
    --namespace $AB_NAMESPACE \
    --sessionId 'oOVZmS8c' \
    > test.out 2>&1
eval_tap $? 52 'PublicRevokeGameSessionCode' test.out

#- 53 PublicGameSessionInvite
# body param: body
echo '{"platformID": "arlocQjA", "userID": "SyCMh6ZV"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicGameSessionInvite \
    --namespace $AB_NAMESPACE \
    --sessionId 'rnxsjv9Y' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 53 'PublicGameSessionInvite' test.out

#- 54 JoinGameSession
$CLI_EXE \
    --sn session \
    --op JoinGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'aJyJblgB' \
    > test.out 2>&1
eval_tap $? 54 'JoinGameSession' test.out

#- 55 PublicPromoteGameSessionLeader
# body param: body
echo '{"leaderID": "W2gr2pgn"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPromoteGameSessionLeader \
    --namespace $AB_NAMESPACE \
    --sessionId '5Qgo8DRo' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 55 'PublicPromoteGameSessionLeader' test.out

#- 56 LeaveGameSession
$CLI_EXE \
    --sn session \
    --op LeaveGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'vFy7G2By' \
    > test.out 2>&1
eval_tap $? 56 'LeaveGameSession' test.out

#- 57 PublicGameSessionReject
$CLI_EXE \
    --sn session \
    --op PublicGameSessionReject \
    --namespace $AB_NAMESPACE \
    --sessionId 'bN8cVygY' \
    > test.out 2>&1
eval_tap $? 57 'PublicGameSessionReject' test.out

#- 58 GetSessionServerSecret
$CLI_EXE \
    --sn session \
    --op GetSessionServerSecret \
    --namespace $AB_NAMESPACE \
    --sessionId 'yrZUqqNF' \
    > test.out 2>&1
eval_tap $? 58 'GetSessionServerSecret' test.out

#- 59 AppendTeamGameSession
# body param: body
echo '{"additionalMembers": [{"partyID": "kVhpamaT", "userIDs": ["cyOS2fna", "dqfthWBZ", "3oXnkV13"]}, {"partyID": "ORMCs0tH", "userIDs": ["voYZYqru", "EHYPqbxI", "7UhTn5ks"]}, {"partyID": "a0p0PJqh", "userIDs": ["M3wREJoE", "6CyyCngi", "ad3cXxTV"]}], "proposedTeams": [{"UserIDs": ["FPXkMKb8", "5wK2ymmk", "9cyaFClj"], "parties": [{"partyID": "hwpFHev5", "userIDs": ["e6J7lcPb", "m0Y3TseA", "SKaItX2i"]}, {"partyID": "yqr8euJM", "userIDs": ["343bws5e", "q6BKQ3mC", "s4iFqRGH"]}, {"partyID": "qYWldEqV", "userIDs": ["2UUWs5fl", "Ll5iiQyA", "EnhGo7pi"]}]}, {"UserIDs": ["oEOKn8gM", "0SwBFWxl", "LShaVW4H"], "parties": [{"partyID": "1ssRDyYq", "userIDs": ["N9eNj8zW", "EN3AhyHY", "pEjAHL6Q"]}, {"partyID": "x8wkbNr9", "userIDs": ["ikLsWiqk", "mEFt3Bs7", "v2NV5Xmu"]}, {"partyID": "hXCf0dlF", "userIDs": ["7FsfN8jO", "wl3NT2HK", "VThLf0d1"]}]}, {"UserIDs": ["THBD0lOn", "sWeS8Iab", "dUAKIpZ1"], "parties": [{"partyID": "1MurVv3e", "userIDs": ["dmGZmpkM", "JhI40MAB", "TPNVrCTQ"]}, {"partyID": "q5dFJxWR", "userIDs": ["lHtY3mtf", "vPIszLUR", "0X6FqHxy"]}, {"partyID": "y4d74f4q", "userIDs": ["I0na9XX7", "5LEJdH18", "bq1FMVQ6"]}]}], "version": 1}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AppendTeamGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'xCoC84E2' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 59 'AppendTeamGameSession' test.out

#- 60 PublicPartyJoinCode
# body param: body
echo '{"code": "09TVwJIq"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPartyJoinCode \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 60 'PublicPartyJoinCode' test.out

#- 61 PublicGetParty
$CLI_EXE \
    --sn session \
    --op PublicGetParty \
    --namespace $AB_NAMESPACE \
    --partyId '9813dM6n' \
    > test.out 2>&1
eval_tap $? 61 'PublicGetParty' test.out

#- 62 PublicUpdateParty
# body param: body
echo '{"attributes": {"ToZwjtld": {}, "II3iceqB": {}, "OzG4xmUp": {}}, "inactiveTimeout": 46, "inviteTimeout": 17, "joinability": "sXKfdRdL", "maxPlayers": 63, "minPlayers": 25, "type": "i3GnBFEO", "version": 4}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicUpdateParty \
    --namespace $AB_NAMESPACE \
    --partyId 'uITK36pa' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 62 'PublicUpdateParty' test.out

#- 63 PublicPatchUpdateParty
# body param: body
echo '{"attributes": {"sFd35NPc": {}, "4bu1usN8": {}, "IYeHra6E": {}}, "inactiveTimeout": 78, "inviteTimeout": 65, "joinability": "8cCBuJVG", "maxPlayers": 50, "minPlayers": 23, "type": "uEhKBXbl", "version": 53}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPatchUpdateParty \
    --namespace $AB_NAMESPACE \
    --partyId 'dNsSMunr' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 63 'PublicPatchUpdateParty' test.out

#- 64 PublicGeneratePartyCode
$CLI_EXE \
    --sn session \
    --op PublicGeneratePartyCode \
    --namespace $AB_NAMESPACE \
    --partyId '0v28ExPO' \
    > test.out 2>&1
eval_tap $? 64 'PublicGeneratePartyCode' test.out

#- 65 PublicRevokePartyCode
$CLI_EXE \
    --sn session \
    --op PublicRevokePartyCode \
    --namespace $AB_NAMESPACE \
    --partyId 'ZnUpG1aM' \
    > test.out 2>&1
eval_tap $? 65 'PublicRevokePartyCode' test.out

#- 66 PublicPartyInvite
# body param: body
echo '{"platformID": "WYKaMNIF", "userID": "59o5hROz"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPartyInvite \
    --namespace $AB_NAMESPACE \
    --partyId 'gWzGXfiH' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 66 'PublicPartyInvite' test.out

#- 67 PublicPromotePartyLeader
# body param: body
echo '{"leaderID": "glpo5aEZ"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPromotePartyLeader \
    --namespace $AB_NAMESPACE \
    --partyId 'ANUrW3Gx' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 67 'PublicPromotePartyLeader' test.out

#- 68 PublicPartyJoin
$CLI_EXE \
    --sn session \
    --op PublicPartyJoin \
    --namespace $AB_NAMESPACE \
    --partyId 'mzHlNo2w' \
    > test.out 2>&1
eval_tap $? 68 'PublicPartyJoin' test.out

#- 69 PublicPartyLeave
$CLI_EXE \
    --sn session \
    --op PublicPartyLeave \
    --namespace $AB_NAMESPACE \
    --partyId 'wBhr07WJ' \
    > test.out 2>&1
eval_tap $? 69 'PublicPartyLeave' test.out

#- 70 PublicPartyReject
$CLI_EXE \
    --sn session \
    --op PublicPartyReject \
    --namespace $AB_NAMESPACE \
    --partyId 'Ohs3cfxl' \
    > test.out 2>&1
eval_tap $? 70 'PublicPartyReject' test.out

#- 71 PublicPartyKick
$CLI_EXE \
    --sn session \
    --op PublicPartyKick \
    --namespace $AB_NAMESPACE \
    --partyId 'qOD2RwPp' \
    --userId 'IgQx2V8w' \
    > test.out 2>&1
eval_tap $? 71 'PublicPartyKick' test.out

#- 72 PublicCreateParty
# body param: body
echo '{"attributes": {"Mrsf3w8Q": {}, "xPMIKvb8": {}, "HfFypyhD": {}}, "configurationName": "DOasrISG", "inactiveTimeout": 66, "inviteTimeout": 46, "joinability": "xxkX6gkH", "maxPlayers": 88, "members": [{"ID": "5fE9ZIpo", "PlatformID": "pt76wiar", "PlatformUserID": "SS1CZDBj"}, {"ID": "QQAn5adL", "PlatformID": "PcMUJDCD", "PlatformUserID": "yxS7jAmD"}, {"ID": "p975zLMo", "PlatformID": "xwmxie16", "PlatformUserID": "ThVf5MEi"}], "minPlayers": 0, "textChat": false, "type": "F37mFMoI"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicCreateParty \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 72 'PublicCreateParty' test.out

#- 73 PublicGetRecentPlayer
$CLI_EXE \
    --sn session \
    --op PublicGetRecentPlayer \
    --namespace $AB_NAMESPACE \
    --limit '78' \
    > test.out 2>&1
eval_tap $? 73 'PublicGetRecentPlayer' test.out

#- 74 PublicGetRecentTeamPlayer
$CLI_EXE \
    --sn session \
    --op PublicGetRecentTeamPlayer \
    --namespace $AB_NAMESPACE \
    --limit '73' \
    > test.out 2>&1
eval_tap $? 74 'PublicGetRecentTeamPlayer' test.out

#- 75 PublicUpdateInsertSessionStorageLeader
# body param: body
echo '{"CAIg04jJ": {}, "Hj7W8Q4O": {}, "jOryrF1p": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicUpdateInsertSessionStorageLeader \
    --namespace $AB_NAMESPACE \
    --sessionId 'n71PpIo0' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 75 'PublicUpdateInsertSessionStorageLeader' test.out

#- 76 PublicUpdateInsertSessionStorage
# body param: body
echo '{"ormckwBM": {}, "xmklGum4": {}, "hrvzP9Lq": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicUpdateInsertSessionStorage \
    --namespace $AB_NAMESPACE \
    --sessionId 'G6fIzjhG' \
    --userId 'nlOdlOHw' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 76 'PublicUpdateInsertSessionStorage' test.out

#- 77 PublicGetBulkPlayerCurrentPlatform
# body param: body
echo '{"userIDs": ["9XsrywaX", "ME8ST5xH", "wqk5j9C8"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicGetBulkPlayerCurrentPlatform \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 77 'PublicGetBulkPlayerCurrentPlatform' test.out

#- 78 PublicGetPlayerAttributes
$CLI_EXE \
    --sn session \
    --op PublicGetPlayerAttributes \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 78 'PublicGetPlayerAttributes' test.out

#- 79 PublicStorePlayerAttributes
# body param: body
echo '{"crossplayEnabled": false, "currentPlatform": "8NaV4uNE", "data": {"kZvzd9Z5": {}, "HJt23Jpi": {}, "Huv8hVUq": {}}, "platforms": [{"name": "3paL9X6C", "userID": "2OKYWk7P"}, {"name": "UjyXPmZa", "userID": "453XYpBi"}, {"name": "ny4IU4E1", "userID": "dSr3OiW3"}], "roles": ["dyPt3oyr", "uJi5SmO0", "WxMZwjly"], "simultaneousPlatform": "bTnEFzah"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicStorePlayerAttributes \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 79 'PublicStorePlayerAttributes' test.out

#- 80 PublicDeletePlayerAttributes
$CLI_EXE \
    --sn session \
    --op PublicDeletePlayerAttributes \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 80 'PublicDeletePlayerAttributes' test.out

#- 81 PublicQueryMyGameSessions
$CLI_EXE \
    --sn session \
    --op PublicQueryMyGameSessions \
    --namespace $AB_NAMESPACE \
    --order 'rFKfXJcR' \
    --orderBy 'X7C4BjZW' \
    --status 'tEEiRR5w' \
    > test.out 2>&1
eval_tap $? 81 'PublicQueryMyGameSessions' test.out

#- 82 PublicQueryMyParties
$CLI_EXE \
    --sn session \
    --op PublicQueryMyParties \
    --namespace $AB_NAMESPACE \
    --order 'k1mqFzD5' \
    --orderBy 'qu3LFkrn' \
    --status 'B8E93jOC' \
    > test.out 2>&1
eval_tap $? 82 'PublicQueryMyParties' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE