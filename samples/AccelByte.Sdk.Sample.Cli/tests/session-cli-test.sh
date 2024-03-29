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
echo "1..78"

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
echo '{"regionRetryMapping": {"wAmK51yk": ["1YQ05Dr9", "Cn8UAkuS", "n6tWwnhk"], "chtKxsPR": ["6E2EGab4", "PisiZbsO", "rJjz96YM"], "vK2CVZ3Y": ["dxeDKGO7", "frB4SLEB", "d5eFhVXh"]}, "regionURLMapping": ["pvzlRGVu", "tghaHEAT", "S6FGTINo"], "testGameMode": "xHL43Glr", "testRegionURLMapping": ["LcU3pKtt", "flhFajbo", "zlORyYR9"], "testTargetUserIDs": ["zUbEj2LN", "kDq3sL0C", "POuc0jCW"]}' > $TEMP_JSON_INPUT
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
echo '{"durationDays": 32}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminUpdateConfigurationAlertV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 10 'AdminUpdateConfigurationAlertV1' test.out

#- 11 AdminCreateConfigurationAlertV1
# body param: body
echo '{"durationDays": 12}' > $TEMP_JSON_INPUT
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
    --description 'Qq28jakP' \
    --certname 'cKEMmhFY' \
    --upload file $TEMP_FILE_UPLOAD \
    --password 'vJJz4DkL' \
    > test.out 2>&1
eval_tap $? 13 'HandleUploadXboxPFXCertificate' test.out

#- 14 AdminCreateConfigurationTemplateV1
# body param: body
echo '{"NativeSessionSetting": {"PSNServiceLabel": 36, "PSNSupportedPlatforms": ["mwut9QtQ", "aV5JhYlx", "6gO261MX"], "SessionTitle": "HAkjJmZo", "ShouldSync": false, "XboxAllowCrossPlatform": true, "XboxSandboxID": "vhh4B81R", "XboxServiceConfigID": "habFzoKP", "XboxSessionTemplateName": "zm4Pn2w8", "XboxTitleID": "wF30Ocbi", "localizedSessionName": {"P5koeixa": {}, "gexgUSvL": {}, "vw0Tc0Sb": {}}}, "PSNBaseUrl": "iGcIcbhy", "attributes": {"6xAQ68dr": {}, "4MqZt1qc": {}, "OgoRVV7d": {}}, "autoJoin": false, "autoLeaveSession": false, "clientVersion": "Uk92MGpp", "deployment": "zYNeb5aB", "disableCodeGeneration": false, "dsManualSetReady": false, "dsSource": "voATg3t4", "enableSecret": true, "fallbackClaimKeys": ["db3JPiWg", "u8Ryt2pd", "55qbga0J"], "immutableStorage": false, "inactiveTimeout": 36, "inviteTimeout": 76, "joinability": "tcNkELrn", "leaderElectionGracePeriod": 28, "manualRejoin": true, "maxActiveSessions": 32, "maxPlayers": 22, "minPlayers": 84, "name": "2zW4MEZj", "persistent": true, "preferredClaimKeys": ["lRxTjDsa", "HAEToNks", "4QwwkENY"], "requestedRegions": ["iraNcj41", "3BC7ar6Q", "gGCBK5JS"], "textChat": true, "tieTeamsSessionLifetime": false, "type": "dx6fuEug"}' > $TEMP_JSON_INPUT
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
    --limit '12' \
    --name 'EQrJh3sf' \
    --offset '86' \
    --order 'z2Med8Zv' \
    --orderBy 'ac7wQnw8' \
    > test.out 2>&1
eval_tap $? 15 'AdminGetAllConfigurationTemplatesV1' test.out

#- 16 AdminGetConfigurationTemplateV1
$CLI_EXE \
    --sn session \
    --op AdminGetConfigurationTemplateV1 \
    --name 'vgPteQZ0' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 16 'AdminGetConfigurationTemplateV1' test.out

#- 17 AdminUpdateConfigurationTemplateV1
# body param: body
echo '{"NativeSessionSetting": {"PSNServiceLabel": 82, "PSNSupportedPlatforms": ["GRNX3NSI", "TEFGF0PA", "aVQOVjgc"], "SessionTitle": "wxiSN539", "ShouldSync": true, "XboxAllowCrossPlatform": true, "XboxSandboxID": "qCBxyUYu", "XboxServiceConfigID": "pLNnmide", "XboxSessionTemplateName": "NUzYn38R", "XboxTitleID": "ZFRps9hc", "localizedSessionName": {"zrm3aolg": {}, "d1jStC8a": {}, "Yz4fDeID": {}}}, "PSNBaseUrl": "EUWPwVrY", "attributes": {"HpuPbl8o": {}, "ePhvo9SG": {}, "1wpefI3k": {}}, "autoJoin": true, "autoLeaveSession": true, "clientVersion": "UnggVft7", "deployment": "vNd9nQBo", "disableCodeGeneration": true, "dsManualSetReady": true, "dsSource": "WwKV7dUp", "enableSecret": true, "fallbackClaimKeys": ["lqPJ6niV", "oPs4j9Dq", "E9E7TZte"], "immutableStorage": false, "inactiveTimeout": 30, "inviteTimeout": 53, "joinability": "e6GWUOEi", "leaderElectionGracePeriod": 61, "manualRejoin": true, "maxActiveSessions": 11, "maxPlayers": 33, "minPlayers": 73, "name": "PSTpTD4S", "persistent": true, "preferredClaimKeys": ["MoftxEB2", "AR1r3rDQ", "AHke6vaj"], "requestedRegions": ["eijPFuem", "fMYLGEXb", "bhB5Tv12"], "textChat": false, "tieTeamsSessionLifetime": false, "type": "Svjukq6O"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminUpdateConfigurationTemplateV1 \
    --name 'e4uAvHfX' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 17 'AdminUpdateConfigurationTemplateV1' test.out

#- 18 AdminDeleteConfigurationTemplateV1
$CLI_EXE \
    --sn session \
    --op AdminDeleteConfigurationTemplateV1 \
    --name 'KlynXHF2' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 18 'AdminDeleteConfigurationTemplateV1' test.out

#- 19 AdminGetMemberActiveSession
$CLI_EXE \
    --sn session \
    --op AdminGetMemberActiveSession \
    --name 'Olhwc4ou' \
    --namespace $AB_NAMESPACE \
    --userId 'NhT7qlAd' \
    > test.out 2>&1
eval_tap $? 19 'AdminGetMemberActiveSession' test.out

#- 20 AdminReconcileMaxActiveSession
# body param: body
echo '{"userID": "zYvMO2rt"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminReconcileMaxActiveSession \
    --name 'nZT7bN57' \
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
    --configurationName 'fSImwzSF' \
    --dsPodName 'xP9oeJmn' \
    --fromTime 'RJHWJIGh' \
    --gameMode 'oau9iuFT' \
    --isPersistent 'CotASwSJ' \
    --isSoftDeleted '83ULQTyg' \
    --joinability 'kBbiKvKs' \
    --limit '79' \
    --matchPool 'KMWqoKj3' \
    --memberID 'MiZsyKzm' \
    --offset '84' \
    --order 'dXXIMHkj' \
    --orderBy 'sx47ZUHn' \
    --sessionID 'JxvNFOK8' \
    --status 'Lb4sB2Ew' \
    --statusV2 't8AKelOO' \
    --toTime 'pmIjPtwr' \
    > test.out 2>&1
eval_tap $? 23 'AdminQueryGameSessions' test.out

#- 24 AdminQueryGameSessionsByAttributes
# body param: body
echo '{"law0AHzd": {}, "w1HPu9Bp": {}, "OIqnmkcu": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminQueryGameSessionsByAttributes \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 24 'AdminQueryGameSessionsByAttributes' test.out

#- 25 AdminDeleteBulkGameSessions
# body param: body
echo '{"ids": ["fjsrD16U", "96nQLEgN", "GRybDDk5"]}' > $TEMP_JSON_INPUT
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
    --sessionId 'a2g0mMPy' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 26 'AdminSetDSReady' test.out

#- 27 AdminUpdateGameSessionMember
$CLI_EXE \
    --sn session \
    --op AdminUpdateGameSessionMember \
    --memberId 'cfTLH6vo' \
    --namespace $AB_NAMESPACE \
    --sessionId 'fvnT8sE3' \
    --statusType 'tLgykSyD' \
    > test.out 2>&1
eval_tap $? 27 'AdminUpdateGameSessionMember' test.out

#- 28 AdminGetListNativeSession
$CLI_EXE \
    --sn session \
    --op AdminGetListNativeSession \
    --namespace $AB_NAMESPACE \
    --limit '93' \
    --offset '37' \
    --order 'agYNr5v7' \
    > test.out 2>&1
eval_tap $? 28 'AdminGetListNativeSession' test.out

#- 29 AdminQueryParties
$CLI_EXE \
    --sn session \
    --op AdminQueryParties \
    --namespace $AB_NAMESPACE \
    --isSoftDeleted 'oUpOSJ7B' \
    --joinability 'xINtphfR' \
    --key 'xPJVlntj' \
    --leaderID 'VxV0Qeoa' \
    --limit '94' \
    --memberID 'erIfUTts' \
    --memberStatus 'BkkZXdds' \
    --offset '0' \
    --order 'gTqLQcXt' \
    --orderBy 'In0PE5Vk' \
    --partyID 'cDfxOjsa' \
    --value 'zQOa4upu' \
    > test.out 2>&1
eval_tap $? 29 'AdminQueryParties' test.out

#- 30 AdminGetPlatformCredentials
$CLI_EXE \
    --sn session \
    --op AdminGetPlatformCredentials \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 30 'AdminGetPlatformCredentials' test.out

#- 31 AdminUpdatePlatformCredentials
# body param: body
echo '{"psn": {"clientId": "G5ka1Ht9", "clientSecret": "DVRuuPYN", "scope": "Au5ENnwg"}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminUpdatePlatformCredentials \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 31 'AdminUpdatePlatformCredentials' test.out

#- 32 AdminDeletePlatformCredentials
$CLI_EXE \
    --sn session \
    --op AdminDeletePlatformCredentials \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 32 'AdminDeletePlatformCredentials' test.out

#- 33 AdminGetRecentPlayer
$CLI_EXE \
    --sn session \
    --op AdminGetRecentPlayer \
    --namespace $AB_NAMESPACE \
    --limit '32' \
    --userId 'rJC3r6nG' \
    > test.out 2>&1
eval_tap $? 33 'AdminGetRecentPlayer' test.out

#- 34 AdminReadSessionStorage
$CLI_EXE \
    --sn session \
    --op AdminReadSessionStorage \
    --namespace $AB_NAMESPACE \
    --sessionId 'n0ERQfRb' \
    > test.out 2>&1
eval_tap $? 34 'AdminReadSessionStorage' test.out

#- 35 AdminDeleteUserSessionStorage
$CLI_EXE \
    --sn session \
    --op AdminDeleteUserSessionStorage \
    --namespace $AB_NAMESPACE \
    --sessionId 'S0qTIU89' \
    > test.out 2>&1
eval_tap $? 35 'AdminDeleteUserSessionStorage' test.out

#- 36 AdminReadUserSessionStorage
$CLI_EXE \
    --sn session \
    --op AdminReadUserSessionStorage \
    --namespace $AB_NAMESPACE \
    --sessionId 'tRGtwQxj' \
    --userId '7dZtXc7b' \
    > test.out 2>&1
eval_tap $? 36 'AdminReadUserSessionStorage' test.out

#- 37 AdminQueryPlayerAttributes
$CLI_EXE \
    --sn session \
    --op AdminQueryPlayerAttributes \
    --namespace $AB_NAMESPACE \
    --users 'qJfEWfKj' \
    > test.out 2>&1
eval_tap $? 37 'AdminQueryPlayerAttributes' test.out

#- 38 AdminGetPlayerAttributes
$CLI_EXE \
    --sn session \
    --op AdminGetPlayerAttributes \
    --namespace $AB_NAMESPACE \
    --userId 'n9QD6Zm8' \
    > test.out 2>&1
eval_tap $? 38 'AdminGetPlayerAttributes' test.out

#- 39 CreateGameSession
# body param: body
echo '{"attributes": {"W1qeUSTk": {}, "gdRBrtwQ": {}, "373Le6nd": {}}, "autoJoin": true, "backfillTicketID": "UuRToK2r", "clientVersion": "HrpoSfkC", "configurationName": "eWKT2XNh", "deployment": "wz9qFIhE", "dsSource": "LWe5a3Ji", "fallbackClaimKeys": ["jHcjAGXd", "1FdYVOrI", "NvFp2pvY"], "inactiveTimeout": 21, "inviteTimeout": 65, "joinability": "kJGMmu9S", "matchPool": "IdcG76sD", "maxPlayers": 9, "minPlayers": 85, "preferredClaimKeys": ["5W6SNiXu", "ybtpaaGf", "zu4STzm3"], "requestedRegions": ["2kcpym4X", "lBSXDM8E", "S4BfUwl1"], "serverName": "MygDGoJf", "teams": [{"UserIDs": ["sK7aDXa3", "EkEUNiIo", "FTMBAAxw"], "parties": [{"partyID": "T2irBd0H", "userIDs": ["nc0owAdU", "fXmxHLKB", "tGXxpDiw"]}, {"partyID": "GoNEzPz3", "userIDs": ["0QbgVQZt", "LfVRxVLz", "J0WAwxnt"]}, {"partyID": "GHu5ExTN", "userIDs": ["L6ATC137", "9FQg1ovv", "165p8OV5"]}]}, {"UserIDs": ["VtVyOyFK", "oMTrO8b9", "3OMV5nCT"], "parties": [{"partyID": "ErKmcf5h", "userIDs": ["kIo4BUi6", "z5cGvujj", "eRkevF6g"]}, {"partyID": "grgmrUGl", "userIDs": ["1RWWSUz3", "sn4ls1rq", "N5gg8xi4"]}, {"partyID": "zGUeXeZW", "userIDs": ["Ne3vaLZf", "h4HqMyiB", "pXP0k2U8"]}]}, {"UserIDs": ["umWuZ7SZ", "Ba0CpKBq", "mAoAanHt"], "parties": [{"partyID": "MPlyEDfr", "userIDs": ["f0CzETNu", "qlgWWaXg", "NUhwxZmj"]}, {"partyID": "6DCPIZ8h", "userIDs": ["wGpOk8Jo", "vajb0nLM", "fowW1RAU"]}, {"partyID": "QasDWbLp", "userIDs": ["FPNhs2ee", "UFCoMltu", "d6Phqvq6"]}]}], "textChat": true, "ticketIDs": ["7xezBpnC", "9ZMt3Z28", "IJcDjAjs"], "tieTeamsSessionLifetime": true, "type": "wZMLYK2t"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op CreateGameSession \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 39 'CreateGameSession' test.out

#- 40 PublicQueryGameSessionsByAttributes
# body param: body
echo '{"Ci8Sl4pH": {}, "pN6471vG": {}, "1PcFGcmH": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicQueryGameSessionsByAttributes \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 40 'PublicQueryGameSessionsByAttributes' test.out

#- 41 PublicSessionJoinCode
# body param: body
echo '{"code": "8mk1TDfO"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicSessionJoinCode \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 41 'PublicSessionJoinCode' test.out

#- 42 GetGameSessionByPodName
$CLI_EXE \
    --sn session \
    --op GetGameSessionByPodName \
    --namespace $AB_NAMESPACE \
    --podName 'o5olbuL3' \
    > test.out 2>&1
eval_tap $? 42 'GetGameSessionByPodName' test.out

#- 43 GetGameSession
$CLI_EXE \
    --sn session \
    --op GetGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'SWryefNn' \
    > test.out 2>&1
eval_tap $? 43 'GetGameSession' test.out

#- 44 UpdateGameSession
# body param: body
echo '{"attributes": {"vonpaomn": {}, "T7ntxZJ6": {}, "1vk70sKs": {}}, "backfillTicketID": "01hA92O3", "clientVersion": "uqX47wlG", "deployment": "9DVKeUY6", "fallbackClaimKeys": ["zNkuqSOZ", "x17GbMXL", "kgHjIBOA"], "inactiveTimeout": 10, "inviteTimeout": 100, "joinability": "dYsXAQRp", "matchPool": "fyw2tJnC", "maxPlayers": 32, "minPlayers": 10, "preferredClaimKeys": ["WjaEjkdo", "uIRND9X1", "9DuNFR9q"], "requestedRegions": ["qWHSykhm", "5qKSwMtH", "S7WzQmKs"], "teams": [{"UserIDs": ["NZnDnBZo", "dLJCbu5y", "OZZ2CqjO"], "parties": [{"partyID": "I2Jr7fpj", "userIDs": ["ueUpZClu", "Ca7hoAWx", "8YgAKi1S"]}, {"partyID": "YOx5FeTP", "userIDs": ["YGm0wHpp", "KsdivkaV", "87t6S0ZB"]}, {"partyID": "FH3scslb", "userIDs": ["VrS89M2e", "rqbQ7yI5", "MOWnPbo9"]}]}, {"UserIDs": ["ENp0pLVH", "JTX1JFGb", "a1GmW1mX"], "parties": [{"partyID": "hQTHXbVi", "userIDs": ["Tw5oidMh", "3Bdw84gp", "CnzFOhvM"]}, {"partyID": "NGOGzdwh", "userIDs": ["u4rB8Rx9", "ta3j7Lkr", "dK7hR1eY"]}, {"partyID": "vvCl461M", "userIDs": ["usWzGF85", "TvvW8CQR", "TA7RTy61"]}]}, {"UserIDs": ["YXm73eYS", "SmKhiPrV", "PGw1fF5t"], "parties": [{"partyID": "EaChrZdp", "userIDs": ["LjxA0Jzx", "JeavCYtv", "48Xzk7hq"]}, {"partyID": "CcixS18Q", "userIDs": ["F1TrUUl9", "aUONgEnj", "bknzD3N4"]}, {"partyID": "sEI0jRZ7", "userIDs": ["PulBc28T", "pzkiam0e", "i9kSu6gL"]}]}], "ticketIDs": ["mHGK88PS", "yQFwCe6r", "e0W83wTO"], "tieTeamsSessionLifetime": true, "type": "8tQdwjgL", "version": 39}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op UpdateGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'n6SH7fhi' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 44 'UpdateGameSession' test.out

#- 45 DeleteGameSession
$CLI_EXE \
    --sn session \
    --op DeleteGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'RGcQGphd' \
    > test.out 2>&1
eval_tap $? 45 'DeleteGameSession' test.out

#- 46 PatchUpdateGameSession
# body param: body
echo '{"attributes": {"M9VigZCR": {}, "lKQIdytI": {}, "L6iNnC5X": {}}, "backfillTicketID": "xZo5uGrE", "clientVersion": "6idygTMk", "deployment": "afNGRWHY", "fallbackClaimKeys": ["HNY2BeUw", "LBl16cVD", "zrBkgbtX"], "inactiveTimeout": 62, "inviteTimeout": 27, "joinability": "o2K9FBEe", "matchPool": "hT3FEKBE", "maxPlayers": 24, "minPlayers": 81, "preferredClaimKeys": ["OTCBNc2s", "uZk4d3Gg", "hXhct1T6"], "requestedRegions": ["YyawlHMx", "xsFRTz0i", "XHVt7b80"], "teams": [{"UserIDs": ["xsUgTNvc", "euFo7csh", "AuzwzmEE"], "parties": [{"partyID": "amDZhFQA", "userIDs": ["01Fdi7vq", "2Nd7y5tM", "1ZIMIKf9"]}, {"partyID": "sgluqByn", "userIDs": ["cHSShnxf", "5Q8n5m7k", "lz05qxIK"]}, {"partyID": "QAEvjYZf", "userIDs": ["E9JHYyEN", "rNQJoM2i", "V6NsPfUD"]}]}, {"UserIDs": ["YjLmzFdw", "Nr5N8PLA", "lK02Fk20"], "parties": [{"partyID": "pnjxi0VH", "userIDs": ["SHjLeHDE", "vwkNekPC", "ZhRUkAHG"]}, {"partyID": "PZl8kBOF", "userIDs": ["AJsw71kz", "GpyDi2P9", "a0x4xrbg"]}, {"partyID": "0NiU99l2", "userIDs": ["QbbLw0Yj", "PFE8HcE6", "GMUXuZSA"]}]}, {"UserIDs": ["gYgT0j6f", "nyCK5PFn", "C3Dhbktb"], "parties": [{"partyID": "wosCR1bj", "userIDs": ["qMSPmKs2", "PiPUdb2P", "aNkAfIA4"]}, {"partyID": "0EW6wJx4", "userIDs": ["Wpw6MvPU", "bpVHqsWA", "4yJzVdxj"]}, {"partyID": "VElH0Mep", "userIDs": ["NGCED0t3", "SbcJyNl4", "LOwY9yjN"]}]}], "ticketIDs": ["1RiG1Bj5", "EQc55JWc", "CoprTtUF"], "tieTeamsSessionLifetime": true, "type": "jEVsSNDg", "version": 74}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PatchUpdateGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId '41flByxh' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 46 'PatchUpdateGameSession' test.out

#- 47 UpdateGameSessionBackfillTicketID
# body param: body
echo '{"backfillTicketID": "zE89xC0s"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op UpdateGameSessionBackfillTicketID \
    --namespace $AB_NAMESPACE \
    --sessionId 'KGkUS5ml' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 47 'UpdateGameSessionBackfillTicketID' test.out

#- 48 GameSessionGenerateCode
$CLI_EXE \
    --sn session \
    --op GameSessionGenerateCode \
    --namespace $AB_NAMESPACE \
    --sessionId 'hlu8Q5Wh' \
    > test.out 2>&1
eval_tap $? 48 'GameSessionGenerateCode' test.out

#- 49 PublicRevokeGameSessionCode
$CLI_EXE \
    --sn session \
    --op PublicRevokeGameSessionCode \
    --namespace $AB_NAMESPACE \
    --sessionId '0xwiERYe' \
    > test.out 2>&1
eval_tap $? 49 'PublicRevokeGameSessionCode' test.out

#- 50 PublicGameSessionInvite
# body param: body
echo '{"platformID": "y9ABggHK", "userID": "3AZOAhHx"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicGameSessionInvite \
    --namespace $AB_NAMESPACE \
    --sessionId 'Zfz07vjg' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 50 'PublicGameSessionInvite' test.out

#- 51 JoinGameSession
$CLI_EXE \
    --sn session \
    --op JoinGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'WyLWpKpt' \
    > test.out 2>&1
eval_tap $? 51 'JoinGameSession' test.out

#- 52 PublicPromoteGameSessionLeader
# body param: body
echo '{"leaderID": "CjjRKv81"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPromoteGameSessionLeader \
    --namespace $AB_NAMESPACE \
    --sessionId 'W87I2uTi' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 52 'PublicPromoteGameSessionLeader' test.out

#- 53 LeaveGameSession
$CLI_EXE \
    --sn session \
    --op LeaveGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'pVdi8I9r' \
    > test.out 2>&1
eval_tap $? 53 'LeaveGameSession' test.out

#- 54 PublicGameSessionReject
$CLI_EXE \
    --sn session \
    --op PublicGameSessionReject \
    --namespace $AB_NAMESPACE \
    --sessionId 'SRKiwH3X' \
    > test.out 2>&1
eval_tap $? 54 'PublicGameSessionReject' test.out

#- 55 GetSessionServerSecret
$CLI_EXE \
    --sn session \
    --op GetSessionServerSecret \
    --namespace $AB_NAMESPACE \
    --sessionId 'cYDhzSkJ' \
    > test.out 2>&1
eval_tap $? 55 'GetSessionServerSecret' test.out

#- 56 AppendTeamGameSession
# body param: body
echo '{"additionalMembers": [{"partyID": "jZwJbxcU", "userIDs": ["4IsJpaRK", "9K394IbC", "4dUc88ZI"]}, {"partyID": "5UwGcHIj", "userIDs": ["gKEpdD71", "YPckMFpo", "swiQAjg6"]}, {"partyID": "QsARRt0J", "userIDs": ["qdBV12No", "SThUfhG6", "ugFOfP6I"]}], "proposedTeams": [{"UserIDs": ["UWONIbIu", "FjuyZD3T", "KIXAtk6R"], "parties": [{"partyID": "Ntc6Sv9J", "userIDs": ["P3NBgDBH", "jY6gSRyn", "ErsHXlTo"]}, {"partyID": "nlHIrIJr", "userIDs": ["YnOGt4rO", "lnnVanYy", "ErQvRg89"]}, {"partyID": "k3XXllVL", "userIDs": ["O8Lbh7Cn", "323flLUr", "igcmpv9a"]}]}, {"UserIDs": ["44EZZTjk", "iRJbtPGj", "V9BVOANK"], "parties": [{"partyID": "Zmuy077E", "userIDs": ["LtSHaDkf", "ZMc9XPHC", "ccMcZxJ2"]}, {"partyID": "KVIKPSaC", "userIDs": ["gysPGQpG", "bKsPnvLE", "e4ZVXuoW"]}, {"partyID": "ssvhG5U0", "userIDs": ["9BhsBCvC", "jlwrln76", "5t6hjyvE"]}]}, {"UserIDs": ["bi0A1wUO", "i5pcnOGJ", "10VCuUy8"], "parties": [{"partyID": "Cv0gICXY", "userIDs": ["3WGKam2j", "Q5N7S6XD", "2lfYk89j"]}, {"partyID": "06eHLnHG", "userIDs": ["lUDuiSfr", "GK2nKc7g", "rXbCcFfQ"]}, {"partyID": "CeWOt8Ol", "userIDs": ["TX1sFpJ4", "xBDTmnWF", "yiRGB3VQ"]}]}], "version": 90}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AppendTeamGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'VHxZfLuF' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 56 'AppendTeamGameSession' test.out

#- 57 PublicPartyJoinCode
# body param: body
echo '{"code": "7KvQaeCP"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPartyJoinCode \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 57 'PublicPartyJoinCode' test.out

#- 58 PublicGetParty
$CLI_EXE \
    --sn session \
    --op PublicGetParty \
    --namespace $AB_NAMESPACE \
    --partyId 'PYR7E0mp' \
    > test.out 2>&1
eval_tap $? 58 'PublicGetParty' test.out

#- 59 PublicUpdateParty
# body param: body
echo '{"attributes": {"5lZruyJi": {}, "TELERqHT": {}, "2FEq6y7v": {}}, "inactiveTimeout": 72, "inviteTimeout": 53, "joinability": "7yzhj2yo", "maxPlayers": 24, "minPlayers": 78, "type": "619mPlPE", "version": 98}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicUpdateParty \
    --namespace $AB_NAMESPACE \
    --partyId 'Tv4KYwNB' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 59 'PublicUpdateParty' test.out

#- 60 PublicPatchUpdateParty
# body param: body
echo '{"attributes": {"ZUPfrpeL": {}, "HvD0ZhQA": {}, "FjmLXWEl": {}}, "inactiveTimeout": 55, "inviteTimeout": 19, "joinability": "OQ17rQ3S", "maxPlayers": 28, "minPlayers": 52, "type": "w5yUOrr9", "version": 99}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPatchUpdateParty \
    --namespace $AB_NAMESPACE \
    --partyId '2jQY4EqC' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 60 'PublicPatchUpdateParty' test.out

#- 61 PublicGeneratePartyCode
$CLI_EXE \
    --sn session \
    --op PublicGeneratePartyCode \
    --namespace $AB_NAMESPACE \
    --partyId 'UCLOiDEV' \
    > test.out 2>&1
eval_tap $? 61 'PublicGeneratePartyCode' test.out

#- 62 PublicRevokePartyCode
$CLI_EXE \
    --sn session \
    --op PublicRevokePartyCode \
    --namespace $AB_NAMESPACE \
    --partyId 'po0n85g8' \
    > test.out 2>&1
eval_tap $? 62 'PublicRevokePartyCode' test.out

#- 63 PublicPartyInvite
# body param: body
echo '{"platformID": "yZ0NK9MC", "userID": "YbqhfFtE"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPartyInvite \
    --namespace $AB_NAMESPACE \
    --partyId 'lkhNJ8Pw' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 63 'PublicPartyInvite' test.out

#- 64 PublicPromotePartyLeader
# body param: body
echo '{"leaderID": "674uurNB"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPromotePartyLeader \
    --namespace $AB_NAMESPACE \
    --partyId 'jeeU5XUd' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 64 'PublicPromotePartyLeader' test.out

#- 65 PublicPartyJoin
$CLI_EXE \
    --sn session \
    --op PublicPartyJoin \
    --namespace $AB_NAMESPACE \
    --partyId 'uLj69f2v' \
    > test.out 2>&1
eval_tap $? 65 'PublicPartyJoin' test.out

#- 66 PublicPartyLeave
$CLI_EXE \
    --sn session \
    --op PublicPartyLeave \
    --namespace $AB_NAMESPACE \
    --partyId '7KHAsSlQ' \
    > test.out 2>&1
eval_tap $? 66 'PublicPartyLeave' test.out

#- 67 PublicPartyReject
$CLI_EXE \
    --sn session \
    --op PublicPartyReject \
    --namespace $AB_NAMESPACE \
    --partyId 'lOdlAWyu' \
    > test.out 2>&1
eval_tap $? 67 'PublicPartyReject' test.out

#- 68 PublicPartyKick
$CLI_EXE \
    --sn session \
    --op PublicPartyKick \
    --namespace $AB_NAMESPACE \
    --partyId 'aoPQRZQG' \
    --userId 'W0Ln7QvU' \
    > test.out 2>&1
eval_tap $? 68 'PublicPartyKick' test.out

#- 69 PublicCreateParty
# body param: body
echo '{"attributes": {"2anYj6Eo": {}, "rcXzlexK": {}, "wBQ049EA": {}}, "configurationName": "deLKVFcV", "inactiveTimeout": 22, "inviteTimeout": 82, "joinability": "EbsGXcz1", "maxPlayers": 94, "members": [{"ID": "7bVwamV3", "PlatformID": "F3b8RRKE", "PlatformUserID": "3BKmMJ0u"}, {"ID": "v31iaf8m", "PlatformID": "n10y6kQz", "PlatformUserID": "v6auwodA"}, {"ID": "n4TofGVi", "PlatformID": "POrggoR3", "PlatformUserID": "yW44PJtO"}], "minPlayers": 60, "textChat": true, "type": "SAysZCtR"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicCreateParty \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 69 'PublicCreateParty' test.out

#- 70 PublicGetRecentPlayer
$CLI_EXE \
    --sn session \
    --op PublicGetRecentPlayer \
    --namespace $AB_NAMESPACE \
    --limit '7' \
    > test.out 2>&1
eval_tap $? 70 'PublicGetRecentPlayer' test.out

#- 71 PublicUpdateInsertSessionStorageLeader
# body param: body
echo '{"VUMNYjW8": {}, "iLwYIGXv": {}, "To7nlHBQ": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicUpdateInsertSessionStorageLeader \
    --namespace $AB_NAMESPACE \
    --sessionId 'WN6X4Unf' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 71 'PublicUpdateInsertSessionStorageLeader' test.out

#- 72 PublicUpdateInsertSessionStorage
# body param: body
echo '{"92DPEWZL": {}, "Yv48ojD0": {}, "aAsBLo5l": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicUpdateInsertSessionStorage \
    --namespace $AB_NAMESPACE \
    --sessionId 'Ejahp0yY' \
    --userId 'cMWQYAOQ' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 72 'PublicUpdateInsertSessionStorage' test.out

#- 73 PublicGetBulkPlayerCurrentPlatform
# body param: body
echo '{"userIDs": ["p9VkFVqI", "UvUjNTDp", "5KaD3bXQ"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicGetBulkPlayerCurrentPlatform \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 73 'PublicGetBulkPlayerCurrentPlatform' test.out

#- 74 PublicGetPlayerAttributes
$CLI_EXE \
    --sn session \
    --op PublicGetPlayerAttributes \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 74 'PublicGetPlayerAttributes' test.out

#- 75 PublicStorePlayerAttributes
# body param: body
echo '{"crossplayEnabled": false, "currentPlatform": "ML1MJ4XM", "data": {"ATecUlHl": {}, "4Sqm4HPM": {}, "0ipUJnfc": {}}, "platforms": [{"name": "wPIy4QIL", "userID": "4gXv2jQH"}, {"name": "VnpVI7x6", "userID": "ZSGzxeSn"}, {"name": "4dKKHFr1", "userID": "MF4v0Ikm"}], "roles": ["aWr8Pzod", "U3LYmNbR", "jZhC9YzY"], "simultaneousPlatform": "S7gSBIyA"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicStorePlayerAttributes \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 75 'PublicStorePlayerAttributes' test.out

#- 76 PublicDeletePlayerAttributes
$CLI_EXE \
    --sn session \
    --op PublicDeletePlayerAttributes \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 76 'PublicDeletePlayerAttributes' test.out

#- 77 PublicQueryMyGameSessions
$CLI_EXE \
    --sn session \
    --op PublicQueryMyGameSessions \
    --namespace $AB_NAMESPACE \
    --order 'Go9kjHxG' \
    --orderBy 'wYactAcI' \
    --status 'ocwwMshZ' \
    > test.out 2>&1
eval_tap $? 77 'PublicQueryMyGameSessions' test.out

#- 78 PublicQueryMyParties
$CLI_EXE \
    --sn session \
    --op PublicQueryMyParties \
    --namespace $AB_NAMESPACE \
    --order 'CMyslr97' \
    --orderBy '5c17hB0u' \
    --status 'lVvFHsoN' \
    > test.out 2>&1
eval_tap $? 78 'PublicQueryMyParties' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE