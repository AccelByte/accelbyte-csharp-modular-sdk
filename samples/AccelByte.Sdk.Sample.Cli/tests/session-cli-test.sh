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
echo "1..74"

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

#- 6 AdminListGlobalConfiguration
$CLI_EXE \
    --sn session \
    --op AdminListGlobalConfiguration \
    > test.out 2>&1
eval_tap $? 6 'AdminListGlobalConfiguration' test.out

#- 7 AdminUpdateGlobalConfiguration
# body param: body
echo '{"regionRetryMapping": {"VljV29Po": ["fTYXaJTA", "anH6nCft", "8gcD1rmh"], "8Odz8nNL": ["YQrsWIRq", "N8ps8q6h", "qmCnrSob"], "oTwD0Jnh": ["9pTn95eT", "d538O7uB", "omiYYRyg"]}, "regionURLMapping": ["MEVxMFjc", "g7UZEAk7", "H2Cqhr8X"], "testGameMode": "meuCc3mw", "testRegionURLMapping": ["zIIUnjuN", "ZI0V89GS", "173AUsT9"], "testTargetUserIDs": ["MeVUfe4R", "4Bu3BexK", "rVqGpiyy"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminUpdateGlobalConfiguration \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 7 'AdminUpdateGlobalConfiguration' test.out

#- 8 AdminDeleteGlobalConfiguration
$CLI_EXE \
    --sn session \
    --op AdminDeleteGlobalConfiguration \
    > test.out 2>&1
eval_tap $? 8 'AdminDeleteGlobalConfiguration' test.out

#- 9 AdminGetConfigurationAlertV1
$CLI_EXE \
    --sn session \
    --op AdminGetConfigurationAlertV1 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 9 'AdminGetConfigurationAlertV1' test.out

#- 10 AdminUpdateConfigurationAlertV1
# body param: body
echo '{"durationDays": 57}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminUpdateConfigurationAlertV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 10 'AdminUpdateConfigurationAlertV1' test.out

#- 11 AdminCreateConfigurationAlertV1
# body param: body
echo '{"durationDays": 51}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminCreateConfigurationAlertV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 11 'AdminCreateConfigurationAlertV1' test.out

#- 12 AdminDeleteConfigurationAlertV1
$CLI_EXE \
    --sn session \
    --op AdminDeleteConfigurationAlertV1 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 12 'AdminDeleteConfigurationAlertV1' test.out

#- 13 HandleUploadXboxPFXCertificate
# form data upload: file
echo 'tmp.dat' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --sn session \
    --op HandleUploadXboxPFXCertificate \
    --namespace $AB_NAMESPACE \
    --description 'xYKwl0YC' \
    --certname 'xzYho5cq' \
    --upload $TEMP_FILE_UPLOAD \
    --password 'es3ucM9Z' \
    > test.out 2>&1
eval_tap $? 13 'HandleUploadXboxPFXCertificate' test.out

#- 14 AdminCreateConfigurationTemplateV1
# body param: body
echo '{"NativeSessionSetting": {"PSNServiceLabel": 6, "PSNSupportedPlatforms": ["411e7JME", "NbP2u66P", "sJ87GGfB"], "SessionTitle": "yuD0ZL6S", "ShouldSync": false, "XboxAllowCrossPlatform": false, "XboxSandboxID": "52Ga0OdE", "XboxServiceConfigID": "ktlDUKFI", "XboxSessionTemplateName": "ox4UpBNq", "XboxTitleID": "weYF1LWz", "localizedSessionName": {"C8KNBtH8": {}, "INSik9Gu": {}, "WIpVoXdd": {}}}, "PSNBaseUrl": "xsC4Aqzg", "autoJoin": false, "clientVersion": "U1nJyA0f", "deployment": "kGDwGA7w", "disableCodeGeneration": false, "dsManualSetReady": true, "dsSource": "lXI7ydrt", "fallbackClaimKeys": ["aAEM3C9n", "xW9PkyGE", "5HeYY9nu"], "immutableStorage": false, "inactiveTimeout": 93, "inviteTimeout": 45, "joinability": "Se7W0W2f", "maxActiveSessions": 14, "maxPlayers": 30, "minPlayers": 26, "name": "VWfA6Wx4", "persistent": false, "preferredClaimKeys": ["dBNvmbgM", "RzFwSwwK", "KBXvVwKG"], "requestedRegions": ["9ou25wVo", "4KKUmGhk", "TubA8bVu"], "textChat": true, "tieTeamsSessionLifetime": false, "type": "b7KFazDS"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminCreateConfigurationTemplateV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 14 'AdminCreateConfigurationTemplateV1' test.out

#- 15 AdminGetAllConfigurationTemplatesV1
$CLI_EXE \
    --sn session \
    --op AdminGetAllConfigurationTemplatesV1 \
    --namespace $AB_NAMESPACE \
    --limit '15' \
    --name 'dw5viWhL' \
    --offset '55' \
    --order '7ybB4e2a' \
    --orderBy 'NFz0OxjV' \
    > test.out 2>&1
eval_tap $? 15 'AdminGetAllConfigurationTemplatesV1' test.out

#- 16 AdminGetConfigurationTemplateV1
$CLI_EXE \
    --sn session \
    --op AdminGetConfigurationTemplateV1 \
    --name 'ErT50JgO' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 16 'AdminGetConfigurationTemplateV1' test.out

#- 17 AdminUpdateConfigurationTemplateV1
# body param: body
echo '{"NativeSessionSetting": {"PSNServiceLabel": 9, "PSNSupportedPlatforms": ["PUi3ZbTL", "gGobxFJL", "4izmzXab"], "SessionTitle": "VHjHoPOg", "ShouldSync": false, "XboxAllowCrossPlatform": false, "XboxSandboxID": "MihiY8Mu", "XboxServiceConfigID": "5ekCU3CN", "XboxSessionTemplateName": "IyPLoPbP", "XboxTitleID": "qOdxNElW", "localizedSessionName": {"ByFCCgjx": {}, "Nd8QTyU2": {}, "fBUN1Z3s": {}}}, "PSNBaseUrl": "2XwUMLmh", "autoJoin": false, "clientVersion": "6SQ2ThH3", "deployment": "rnEuIlgy", "disableCodeGeneration": true, "dsManualSetReady": true, "dsSource": "nsfot0Jf", "fallbackClaimKeys": ["6FKhZQQu", "V1hmHXV5", "YZLn23PJ"], "immutableStorage": false, "inactiveTimeout": 45, "inviteTimeout": 25, "joinability": "q596eRLC", "maxActiveSessions": 69, "maxPlayers": 41, "minPlayers": 6, "name": "rUJaM7rS", "persistent": true, "preferredClaimKeys": ["ltaLWoGn", "aPDitABV", "xjQuyJax"], "requestedRegions": ["ABXNdiq5", "IVJy8H4Q", "BGBQDHC4"], "textChat": false, "tieTeamsSessionLifetime": true, "type": "1qEwnEHL"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminUpdateConfigurationTemplateV1 \
    --name '2hC6foYR' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 17 'AdminUpdateConfigurationTemplateV1' test.out

#- 18 AdminDeleteConfigurationTemplateV1
$CLI_EXE \
    --sn session \
    --op AdminDeleteConfigurationTemplateV1 \
    --name 'V064iffQ' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 18 'AdminDeleteConfigurationTemplateV1' test.out

#- 19 AdminGetMemberActiveSession
$CLI_EXE \
    --sn session \
    --op AdminGetMemberActiveSession \
    --name 'UdOMOWVX' \
    --namespace $AB_NAMESPACE \
    --userId 'niGFhPqG' \
    > test.out 2>&1
eval_tap $? 19 'AdminGetMemberActiveSession' test.out

#- 20 AdminReconcileMaxActiveSession
# body param: body
echo '{"userID": "4BQTJmK2"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminReconcileMaxActiveSession \
    --name 'gSphOKND' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 20 'AdminReconcileMaxActiveSession' test.out

#- 21 AdminGetDSMCConfiguration
$CLI_EXE \
    --sn session \
    --op AdminGetDSMCConfiguration \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 21 'AdminGetDSMCConfiguration' test.out

#- 22 AdminSyncDSMCConfiguration
$CLI_EXE \
    --sn session \
    --op AdminSyncDSMCConfiguration \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 22 'AdminSyncDSMCConfiguration' test.out

#- 23 AdminQueryGameSessions
$CLI_EXE \
    --sn session \
    --op AdminQueryGameSessions \
    --namespace $AB_NAMESPACE \
    --configurationName 'nkpBpYAD' \
    --dsPodName 'v2B30CIx' \
    --fromTime 'Gt8ttFip' \
    --gameMode 'vYDqMyZ5' \
    --isPersistent 'F1yBFSLw' \
    --isSoftDeleted 'af8xZTmF' \
    --joinability '1yKnPMmj' \
    --limit '4' \
    --matchPool 'kJbRnqEw' \
    --memberID 'Gjx6dTMX' \
    --offset '44' \
    --order 'Jf5jnmSq' \
    --orderBy 'LEoruIna' \
    --sessionID 'zhuLvzh3' \
    --status '5k5L5Izm' \
    --statusV2 'ztPx3Ctq' \
    --toTime 'k2keCw3O' \
    > test.out 2>&1
eval_tap $? 23 'AdminQueryGameSessions' test.out

#- 24 AdminQueryGameSessionsByAttributes
# body param: body
echo '{"HVaiOYQR": {}, "WgfhzUmb": {}, "lT3L8SFs": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminQueryGameSessionsByAttributes \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 24 'AdminQueryGameSessionsByAttributes' test.out

#- 25 AdminDeleteBulkGameSessions
# body param: body
echo '{"ids": ["4kp4TVjK", "PsUhmOTh", "D1egLP67"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminDeleteBulkGameSessions \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 25 'AdminDeleteBulkGameSessions' test.out

#- 26 AdminSetDSReady
# body param: body
echo '{"ready": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminSetDSReady \
    --namespace $AB_NAMESPACE \
    --sessionId 'ZsPhHUVb' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 26 'AdminSetDSReady' test.out

#- 27 AdminUpdateGameSessionMember
$CLI_EXE \
    --sn session \
    --op AdminUpdateGameSessionMember \
    --memberId 'k1VRhvOE' \
    --namespace $AB_NAMESPACE \
    --sessionId 'HWDC3Je0' \
    --statusType '7Uob48oQ' \
    > test.out 2>&1
eval_tap $? 27 'AdminUpdateGameSessionMember' test.out

#- 28 AdminQueryParties
$CLI_EXE \
    --sn session \
    --op AdminQueryParties \
    --namespace $AB_NAMESPACE \
    --joinability 'WnIEln5m' \
    --key 'RNdTQEcg' \
    --leaderID 'PpE7vtND' \
    --limit '55' \
    --memberID 'jaW7QcnB' \
    --memberStatus 'OLwcKIhI' \
    --offset '94' \
    --order 'Yb3SocFG' \
    --orderBy 'MwLkcthb' \
    --partyID 'w47tFOEm' \
    --value 'IUuTypei' \
    > test.out 2>&1
eval_tap $? 28 'AdminQueryParties' test.out

#- 29 AdminGetPlatformCredentials
$CLI_EXE \
    --sn session \
    --op AdminGetPlatformCredentials \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 29 'AdminGetPlatformCredentials' test.out

#- 30 AdminUpdatePlatformCredentials
# body param: body
echo '{"psn": {"clientId": "AWlH4Iqu", "clientSecret": "iPz12fFr", "scope": "j4sDenLa"}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminUpdatePlatformCredentials \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 30 'AdminUpdatePlatformCredentials' test.out

#- 31 AdminDeletePlatformCredentials
$CLI_EXE \
    --sn session \
    --op AdminDeletePlatformCredentials \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 31 'AdminDeletePlatformCredentials' test.out

#- 32 AdminReadSessionStorage
$CLI_EXE \
    --sn session \
    --op AdminReadSessionStorage \
    --namespace $AB_NAMESPACE \
    --sessionId 'JySuM762' \
    > test.out 2>&1
eval_tap $? 32 'AdminReadSessionStorage' test.out

#- 33 AdminDeleteUserSessionStorage
$CLI_EXE \
    --sn session \
    --op AdminDeleteUserSessionStorage \
    --namespace $AB_NAMESPACE \
    --sessionId 'IoyUubWf' \
    > test.out 2>&1
eval_tap $? 33 'AdminDeleteUserSessionStorage' test.out

#- 34 AdminReadUserSessionStorage
$CLI_EXE \
    --sn session \
    --op AdminReadUserSessionStorage \
    --namespace $AB_NAMESPACE \
    --sessionId 'aI8gkoZX' \
    --userId '8UsZdv5X' \
    > test.out 2>&1
eval_tap $? 34 'AdminReadUserSessionStorage' test.out

#- 35 AdminQueryPlayerAttributes
$CLI_EXE \
    --sn session \
    --op AdminQueryPlayerAttributes \
    --namespace $AB_NAMESPACE \
    --users 'YAWm6TeK' \
    > test.out 2>&1
eval_tap $? 35 'AdminQueryPlayerAttributes' test.out

#- 36 AdminGetPlayerAttributes
$CLI_EXE \
    --sn session \
    --op AdminGetPlayerAttributes \
    --namespace $AB_NAMESPACE \
    --userId 'QMEFhmuo' \
    > test.out 2>&1
eval_tap $? 36 'AdminGetPlayerAttributes' test.out

#- 37 CreateGameSession
# body param: body
echo '{"attributes": {"7GUebAs5": {}, "MjNV3ahN": {}, "RoloocMt": {}}, "autoJoin": false, "backfillTicketID": "WCK67Ttw", "clientVersion": "lf9wCryN", "configurationName": "q6Z25azg", "deployment": "qoT26Ti2", "dsSource": "jbVBeIxQ", "fallbackClaimKeys": ["9vH2PiLj", "p4v8eC9C", "HwL6WhKc"], "inactiveTimeout": 58, "inviteTimeout": 0, "joinability": "PKw0uBpQ", "matchPool": "3izO9uia", "maxPlayers": 40, "minPlayers": 74, "preferredClaimKeys": ["CElsmqvn", "ob2mXLPk", "sSmlBZrH"], "requestedRegions": ["Zhy28Js8", "lDQ5nW3S", "vVDwYuTf"], "serverName": "7hirYS7C", "teams": [{"UserIDs": ["NCqyI6jX", "t4FWKKv7", "yiqXzU6a"], "parties": [{"partyID": "PxeT4IFA", "userIDs": ["ZhOYcdEE", "End7gFK3", "xJZopwdI"]}, {"partyID": "aNkXWtOg", "userIDs": ["287bkwB8", "j0MwwJyM", "ydRdb8Tv"]}, {"partyID": "Za1wIwUW", "userIDs": ["OsZSy2kT", "v3LPW7qF", "AneyUtrU"]}]}, {"UserIDs": ["VSJJuFTn", "lMN8yOzr", "W7aIE08L"], "parties": [{"partyID": "nktLMBGz", "userIDs": ["oMDGjYUT", "18roiWbB", "Rb5GcPlP"]}, {"partyID": "wPeFPslS", "userIDs": ["gCh4HJEC", "DRU7sa98", "084OzvnE"]}, {"partyID": "TuIGKuNy", "userIDs": ["LhoEIEEG", "aCIdqLZU", "Cg1R25WC"]}]}, {"UserIDs": ["DWnlGN46", "2hrOg7AS", "7hpikQyh"], "parties": [{"partyID": "ra77hQLR", "userIDs": ["sYyVrKfW", "iQkF47LM", "LeYtuQUq"]}, {"partyID": "JR2IPeCH", "userIDs": ["6Wf7Kxfz", "9viMxwK3", "W8ZE4J6E"]}, {"partyID": "n8zr0Cy0", "userIDs": ["7cG5YDl1", "3ZsHWMJJ", "WuyFAdbn"]}]}], "textChat": false, "ticketIDs": ["qx8zkIR7", "8FHFzsfK", "DxJJN9C7"], "tieTeamsSessionLifetime": true, "type": "JiIi6I0V"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op CreateGameSession \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 37 'CreateGameSession' test.out

#- 38 PublicQueryGameSessionsByAttributes
# body param: body
echo '{"bEIb5uXO": {}, "HsN0ERee": {}, "iJzpzWe7": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicQueryGameSessionsByAttributes \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 38 'PublicQueryGameSessionsByAttributes' test.out

#- 39 PublicSessionJoinCode
# body param: body
echo '{"code": "8s9UOjCn"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicSessionJoinCode \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 39 'PublicSessionJoinCode' test.out

#- 40 GetGameSessionByPodName
$CLI_EXE \
    --sn session \
    --op GetGameSessionByPodName \
    --namespace $AB_NAMESPACE \
    --podName 'zCcjNdhg' \
    > test.out 2>&1
eval_tap $? 40 'GetGameSessionByPodName' test.out

#- 41 GetGameSession
$CLI_EXE \
    --sn session \
    --op GetGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'BBUcATAv' \
    > test.out 2>&1
eval_tap $? 41 'GetGameSession' test.out

#- 42 UpdateGameSession
# body param: body
echo '{"attributes": {"dgq8lagx": {}, "4ZmNITmo": {}, "XfNvZhq8": {}}, "backfillTicketID": "h1XlPgyM", "clientVersion": "aC1UnmJr", "deployment": "ZsnOi6pY", "fallbackClaimKeys": ["GTM2vsnU", "yibizIok", "TGOJ1BSd"], "inactiveTimeout": 48, "inviteTimeout": 85, "joinability": "FRZnQJJF", "matchPool": "5nKdnzHe", "maxPlayers": 20, "minPlayers": 69, "preferredClaimKeys": ["lCGqYaiQ", "xByboItL", "uQlVx53M"], "requestedRegions": ["1vO1HczJ", "Ak3Y1mxG", "R96NBFpj"], "teams": [{"UserIDs": ["0IeVZyOV", "YnmHD3tT", "8jFj8a9U"], "parties": [{"partyID": "boNw2syI", "userIDs": ["egZ5t7Bk", "N01cJg17", "JoW3HZIo"]}, {"partyID": "siUa2YRN", "userIDs": ["mrgyuBk3", "yzzuN5FL", "92fF3Ru6"]}, {"partyID": "9I408JdM", "userIDs": ["QQ1nyuz9", "zDccQ7wA", "AnQuQj2C"]}]}, {"UserIDs": ["l4ZsariQ", "zvqLhx8O", "xEllfIRs"], "parties": [{"partyID": "pS811D2X", "userIDs": ["NJCLgK2A", "mIp5vqk5", "eLdO0bvY"]}, {"partyID": "LwAPJs6S", "userIDs": ["Rd9TF2xi", "SZ30MvnJ", "6hXBqYVJ"]}, {"partyID": "fnOmgUrK", "userIDs": ["ERadoxI0", "teqtcTjs", "nB3st9Pa"]}]}, {"UserIDs": ["xYcpeGhH", "N1wO2Vwk", "GnZfEbzH"], "parties": [{"partyID": "EcJrDlZ3", "userIDs": ["J8jzY5i0", "DuicudrA", "hoTCkDl7"]}, {"partyID": "RpncyZNi", "userIDs": ["gmMyVE85", "PjJCB8t1", "c1s9lhf1"]}, {"partyID": "qtwDbTWR", "userIDs": ["HSj9Becn", "ufKAJsml", "mBkLg2ec"]}]}], "ticketIDs": ["qeil6rbP", "3KPFc07M", "F57q9Hp8"], "tieTeamsSessionLifetime": true, "type": "1OQfzrkv", "version": 25}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op UpdateGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId '13NL3B1E' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 42 'UpdateGameSession' test.out

#- 43 DeleteGameSession
$CLI_EXE \
    --sn session \
    --op DeleteGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'mAA1PyWc' \
    > test.out 2>&1
eval_tap $? 43 'DeleteGameSession' test.out

#- 44 PatchUpdateGameSession
# body param: body
echo '{"attributes": {"3uUKO8Lk": {}, "4eAzy91M": {}, "IJP0QFnB": {}}, "backfillTicketID": "JiYRXuLj", "clientVersion": "xQHCqP3X", "deployment": "6oyHInQb", "fallbackClaimKeys": ["NQ9DsaOV", "Ry8y16Lc", "EZG2Dgew"], "inactiveTimeout": 37, "inviteTimeout": 64, "joinability": "qVtZYvVe", "matchPool": "hKBRXs3N", "maxPlayers": 49, "minPlayers": 18, "preferredClaimKeys": ["1hbyaMsm", "l9R9LEp9", "Xz048eWX"], "requestedRegions": ["U3KwHp5P", "ZGgYRsX9", "uZCy7Mqj"], "teams": [{"UserIDs": ["Z2FzkhRJ", "QS5mHZ5d", "FuoJl2jm"], "parties": [{"partyID": "GN1OttdT", "userIDs": ["OMLbivFk", "wG1NEu2y", "eWIFgiLz"]}, {"partyID": "KDZPwq1q", "userIDs": ["jUgURmn2", "nNlubqr6", "NUvXwkuE"]}, {"partyID": "17ZZocdH", "userIDs": ["i0l3xNJq", "B9hwsJVa", "BjfVSaD2"]}]}, {"UserIDs": ["CAOLRHkg", "osm4P1eq", "tvyc2DpM"], "parties": [{"partyID": "fmPasOEs", "userIDs": ["DIcIwere", "Sk5Wgs51", "VrfvETlL"]}, {"partyID": "QumRhN9W", "userIDs": ["qdogCgRp", "DRO0sFyc", "3ZKMHEKq"]}, {"partyID": "Jsx7sUzy", "userIDs": ["nvdvuWgu", "LNnJlIFS", "Dl97iEwS"]}]}, {"UserIDs": ["0Vg5kxfr", "KNcsVfc6", "vvk2btB9"], "parties": [{"partyID": "21dVLN4M", "userIDs": ["Z92uUZOf", "CZSb2Tkn", "PeYjC1un"]}, {"partyID": "A0Pol3fA", "userIDs": ["FIYCwn62", "rd4taJhU", "900fGnf8"]}, {"partyID": "adDWD2cd", "userIDs": ["J8xxkuQe", "0EUP0uIC", "qt1IOIZK"]}]}], "ticketIDs": ["zi8rRIUr", "wkzT3zu0", "eZc7yE2l"], "tieTeamsSessionLifetime": true, "type": "s05dgk09", "version": 56}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PatchUpdateGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId '7TBm0Lsy' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 44 'PatchUpdateGameSession' test.out

#- 45 UpdateGameSessionBackfillTicketID
# body param: body
echo '{"backfillTicketID": "mjhODK7Q"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op UpdateGameSessionBackfillTicketID \
    --namespace $AB_NAMESPACE \
    --sessionId 'KddiilMJ' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 45 'UpdateGameSessionBackfillTicketID' test.out

#- 46 GameSessionGenerateCode
$CLI_EXE \
    --sn session \
    --op GameSessionGenerateCode \
    --namespace $AB_NAMESPACE \
    --sessionId 'aXkddWYj' \
    > test.out 2>&1
eval_tap $? 46 'GameSessionGenerateCode' test.out

#- 47 PublicRevokeGameSessionCode
$CLI_EXE \
    --sn session \
    --op PublicRevokeGameSessionCode \
    --namespace $AB_NAMESPACE \
    --sessionId 'pMe6WP4u' \
    > test.out 2>&1
eval_tap $? 47 'PublicRevokeGameSessionCode' test.out

#- 48 PublicGameSessionInvite
# body param: body
echo '{"platformID": "0N2bciDO", "userID": "W60zMZOA"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicGameSessionInvite \
    --namespace $AB_NAMESPACE \
    --sessionId '4rWxdWqv' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 48 'PublicGameSessionInvite' test.out

#- 49 JoinGameSession
$CLI_EXE \
    --sn session \
    --op JoinGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'i2pTG2TA' \
    > test.out 2>&1
eval_tap $? 49 'JoinGameSession' test.out

#- 50 PublicPromoteGameSessionLeader
# body param: body
echo '{"leaderID": "2EoLLSD5"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPromoteGameSessionLeader \
    --namespace $AB_NAMESPACE \
    --sessionId 'lX41qKBp' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 50 'PublicPromoteGameSessionLeader' test.out

#- 51 LeaveGameSession
$CLI_EXE \
    --sn session \
    --op LeaveGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'yljsDVq7' \
    > test.out 2>&1
eval_tap $? 51 'LeaveGameSession' test.out

#- 52 PublicGameSessionReject
$CLI_EXE \
    --sn session \
    --op PublicGameSessionReject \
    --namespace $AB_NAMESPACE \
    --sessionId 'I0HNT9xY' \
    > test.out 2>&1
eval_tap $? 52 'PublicGameSessionReject' test.out

#- 53 AppendTeamGameSession
# body param: body
echo '{"additionalMembers": [{"partyID": "wxmwgHzm", "userIDs": ["vm8oocRB", "D4Hko6hq", "ETAstZwj"]}, {"partyID": "tVPySW6H", "userIDs": ["dM0dMrLT", "1svZmrVM", "7sWOovpY"]}, {"partyID": "IhrXgoZG", "userIDs": ["uFfbHjiJ", "RWW41XLO", "jPYCI0ED"]}], "proposedTeams": [{"UserIDs": ["kOd7bbBK", "QklI9kw5", "dI56SYOR"], "parties": [{"partyID": "jFRIqBX8", "userIDs": ["OvyK4nQV", "tpiTBAxN", "5HbwHftc"]}, {"partyID": "FQAq3Crr", "userIDs": ["1zV4OrQB", "sAMoi5HL", "ttLY7nN8"]}, {"partyID": "fRdD7rrr", "userIDs": ["hBO9WY6a", "053e8wO7", "Jesh26IY"]}]}, {"UserIDs": ["cdavuGjo", "qH4yAWDK", "MkTjdYav"], "parties": [{"partyID": "JbL2zQgz", "userIDs": ["rINxLZqi", "wUqX0Aqv", "kGnPLNnD"]}, {"partyID": "vcgsyWIz", "userIDs": ["oM8QEQRF", "xBjNqAqx", "J9LyxpxV"]}, {"partyID": "Ce17TFPu", "userIDs": ["frHd62Yg", "yC7Y0Vke", "dkoHIuhn"]}]}, {"UserIDs": ["ygZU6qXW", "fGNrkZIz", "JHPfHRlc"], "parties": [{"partyID": "prmPpZAN", "userIDs": ["eocUOnXS", "kjfaPM0b", "wkbvobzN"]}, {"partyID": "vDjYJIqy", "userIDs": ["OXzHEU0T", "QPhfJ4rS", "Drvy09KS"]}, {"partyID": "N3cic5kE", "userIDs": ["pg7T3JRw", "yynIYmd0", "2i2WzKM1"]}]}], "version": 2}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AppendTeamGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'SktJ5hsl' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 53 'AppendTeamGameSession' test.out

#- 54 PublicPartyJoinCode
# body param: body
echo '{"code": "w6HoGi2g"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPartyJoinCode \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 54 'PublicPartyJoinCode' test.out

#- 55 PublicGetParty
$CLI_EXE \
    --sn session \
    --op PublicGetParty \
    --namespace $AB_NAMESPACE \
    --partyId 'uWtWzDN0' \
    > test.out 2>&1
eval_tap $? 55 'PublicGetParty' test.out

#- 56 PublicUpdateParty
# body param: body
echo '{"attributes": {"oCFizNgl": {}, "grq3i71Q": {}, "W9MnV39X": {}}, "inactiveTimeout": 31, "inviteTimeout": 51, "joinability": "LXw8Rpb8", "maxPlayers": 7, "minPlayers": 45, "type": "y5S6fdUS", "version": 65}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicUpdateParty \
    --namespace $AB_NAMESPACE \
    --partyId '5RJPTp10' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 56 'PublicUpdateParty' test.out

#- 57 PublicPatchUpdateParty
# body param: body
echo '{"attributes": {"VhSmeEzv": {}, "cF6V05Yw": {}, "3VfX1N5D": {}}, "inactiveTimeout": 84, "inviteTimeout": 92, "joinability": "J7jj6dZE", "maxPlayers": 37, "minPlayers": 22, "type": "77ihvSeA", "version": 18}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPatchUpdateParty \
    --namespace $AB_NAMESPACE \
    --partyId 'mMezygG6' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 57 'PublicPatchUpdateParty' test.out

#- 58 PublicGeneratePartyCode
$CLI_EXE \
    --sn session \
    --op PublicGeneratePartyCode \
    --namespace $AB_NAMESPACE \
    --partyId 'vK4uGwGL' \
    > test.out 2>&1
eval_tap $? 58 'PublicGeneratePartyCode' test.out

#- 59 PublicRevokePartyCode
$CLI_EXE \
    --sn session \
    --op PublicRevokePartyCode \
    --namespace $AB_NAMESPACE \
    --partyId 'VlfagAQ2' \
    > test.out 2>&1
eval_tap $? 59 'PublicRevokePartyCode' test.out

#- 60 PublicPartyInvite
# body param: body
echo '{"platformID": "BEEzdkY5", "userID": "Z93ARkLh"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPartyInvite \
    --namespace $AB_NAMESPACE \
    --partyId 'Pp8xYoR3' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 60 'PublicPartyInvite' test.out

#- 61 PublicPromotePartyLeader
# body param: body
echo '{"leaderID": "uVQtfpEj"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPromotePartyLeader \
    --namespace $AB_NAMESPACE \
    --partyId 'phvWUoui' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 61 'PublicPromotePartyLeader' test.out

#- 62 PublicPartyJoin
$CLI_EXE \
    --sn session \
    --op PublicPartyJoin \
    --namespace $AB_NAMESPACE \
    --partyId 'Xfu8wGzG' \
    > test.out 2>&1
eval_tap $? 62 'PublicPartyJoin' test.out

#- 63 PublicPartyLeave
$CLI_EXE \
    --sn session \
    --op PublicPartyLeave \
    --namespace $AB_NAMESPACE \
    --partyId 'Mkk5sWdV' \
    > test.out 2>&1
eval_tap $? 63 'PublicPartyLeave' test.out

#- 64 PublicPartyReject
$CLI_EXE \
    --sn session \
    --op PublicPartyReject \
    --namespace $AB_NAMESPACE \
    --partyId 'q9YjYa2W' \
    > test.out 2>&1
eval_tap $? 64 'PublicPartyReject' test.out

#- 65 PublicPartyKick
$CLI_EXE \
    --sn session \
    --op PublicPartyKick \
    --namespace $AB_NAMESPACE \
    --partyId 'J0KxiMO2' \
    --userId 'QhiVrQMQ' \
    > test.out 2>&1
eval_tap $? 65 'PublicPartyKick' test.out

#- 66 PublicCreateParty
# body param: body
echo '{"attributes": {"TqlYFptg": {}, "6EBRlrnG": {}, "pVCJ7g5V": {}}, "configurationName": "FHGy5QsQ", "inactiveTimeout": 58, "inviteTimeout": 72, "joinability": "fxsdOze6", "maxPlayers": 83, "members": [{"ID": "BtnpXgjY", "PlatformID": "f3UikDPM", "PlatformUserID": "sD0OHFRg"}, {"ID": "uQIp8f06", "PlatformID": "bA55YWj2", "PlatformUserID": "gRaiAgqu"}, {"ID": "ddgPcNRC", "PlatformID": "bVuTE1Az", "PlatformUserID": "g7JPxH7N"}], "minPlayers": 76, "textChat": false, "type": "DKh0NSR6"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicCreateParty \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 66 'PublicCreateParty' test.out

#- 67 PublicUpdateInsertSessionStorageLeader
# body param: body
echo '{"vPmcQWA7": {}, "lhqpVOUv": {}, "6BXWzgva": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicUpdateInsertSessionStorageLeader \
    --namespace $AB_NAMESPACE \
    --sessionId '68FOODgc' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 67 'PublicUpdateInsertSessionStorageLeader' test.out

#- 68 PublicUpdateInsertSessionStorage
# body param: body
echo '{"Xs1Udqns": {}, "dY1wRgB7": {}, "9Q7xmOAE": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicUpdateInsertSessionStorage \
    --namespace $AB_NAMESPACE \
    --sessionId '7noRdHnp' \
    --userId 'Upq3Rmsf' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 68 'PublicUpdateInsertSessionStorage' test.out

#- 69 PublicGetBulkPlayerCurrentPlatform
# body param: body
echo '{"userIDs": ["MixTEkjb", "0rH8RviH", "N8mI5YZn"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicGetBulkPlayerCurrentPlatform \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 69 'PublicGetBulkPlayerCurrentPlatform' test.out

#- 70 PublicGetPlayerAttributes
$CLI_EXE \
    --sn session \
    --op PublicGetPlayerAttributes \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 70 'PublicGetPlayerAttributes' test.out

#- 71 PublicStorePlayerAttributes
# body param: body
echo '{"crossplayEnabled": true, "currentPlatform": "dGjHaLGB", "data": {"qs5OID6B": {}, "3NIWrpBe": {}, "bs5jqC6S": {}}, "platforms": [{"name": "zCTJHW1N", "userID": "Jt0URxUn"}, {"name": "JJ06BiiL", "userID": "TTlfpCUR"}, {"name": "XxMnQuWy", "userID": "pBkkgPzi"}], "roles": ["XsV2j910", "Ts3866Pl", "IlSOJOOk"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicStorePlayerAttributes \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 71 'PublicStorePlayerAttributes' test.out

#- 72 PublicDeletePlayerAttributes
$CLI_EXE \
    --sn session \
    --op PublicDeletePlayerAttributes \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 72 'PublicDeletePlayerAttributes' test.out

#- 73 PublicQueryMyGameSessions
$CLI_EXE \
    --sn session \
    --op PublicQueryMyGameSessions \
    --namespace $AB_NAMESPACE \
    --order 'aVEC7zV1' \
    --orderBy 'pq7HBXV9' \
    --status '4zUHpnJq' \
    > test.out 2>&1
eval_tap $? 73 'PublicQueryMyGameSessions' test.out

#- 74 PublicQueryMyParties
$CLI_EXE \
    --sn session \
    --op PublicQueryMyParties \
    --namespace $AB_NAMESPACE \
    --order 'cKwumunj' \
    --orderBy 'hoSTPgGt' \
    --status 'IS3tY6E5' \
    > test.out 2>&1
eval_tap $? 74 'PublicQueryMyParties' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE