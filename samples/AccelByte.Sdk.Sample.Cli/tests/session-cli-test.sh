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
echo "1..75"

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
echo '{"regionRetryMapping": {"UoLo5vAN": ["wmuq5PMy", "iT3MAFtH", "V5XEFXke"], "9mWRZRmt": ["uR2PrtYD", "j6i7VUnV", "5JehJxOM"], "kZbH0wqh": ["cME8oK8K", "PZATg0zk", "CNjaBQNq"]}, "regionURLMapping": ["l0nNYi9y", "m6GxAnqy", "pQKSqZp9"], "testGameMode": "7v1GA8N6", "testRegionURLMapping": ["kFB3Kizc", "Q7uh0AhA", "3XYbmicW"], "testTargetUserIDs": ["ZdbkyrAu", "Hjb3o8NA", "k3n6CHkd"]}' > $TEMP_JSON_INPUT
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
echo '{"durationDays": 70}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminUpdateConfigurationAlertV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 10 'AdminUpdateConfigurationAlertV1' test.out

#- 11 AdminCreateConfigurationAlertV1
# body param: body
echo '{"durationDays": 38}' > $TEMP_JSON_INPUT
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
    --description 'FUlClPX0' \
    --certname 'NiwKJuqo' \
    --upload $TEMP_FILE_UPLOAD \
    --password 'Y16b4dhd' \
    > test.out 2>&1
eval_tap $? 13 'HandleUploadXboxPFXCertificate' test.out

#- 14 AdminCreateConfigurationTemplateV1
# body param: body
echo '{"NativeSessionSetting": {"PSNServiceLabel": 32, "PSNSupportedPlatforms": ["5qBoc4xf", "Vg4hVdEx", "2aPVLkTI"], "SessionTitle": "lsNVbvEe", "ShouldSync": true, "XboxAllowCrossPlatform": true, "XboxSandboxID": "AhcLI3kM", "XboxServiceConfigID": "dxXkJ8kl", "XboxSessionTemplateName": "1ulSAdnx", "XboxTitleID": "jCxDvOA9", "localizedSessionName": {"H9SboHsJ": {}, "epG0Tuvg": {}, "1mRMvrI4": {}}}, "PSNBaseUrl": "KbqQxZtK", "attributes": {"n2I97bad": {}, "haSMLqdZ": {}, "qGUIeXr1": {}}, "autoJoin": true, "clientVersion": "EoDHSeEK", "deployment": "WMRwm7bl", "disableCodeGeneration": true, "dsManualSetReady": true, "dsSource": "AmDvOj49", "enableSecret": true, "fallbackClaimKeys": ["Hb5mLorp", "eB8U7a8M", "OD9Ibjj2"], "immutableStorage": true, "inactiveTimeout": 51, "inviteTimeout": 79, "joinability": "AVnlShHn", "maxActiveSessions": 74, "maxPlayers": 12, "minPlayers": 97, "name": "s0CbqMlD", "persistent": true, "preferredClaimKeys": ["ctTuWXul", "QXAVWXU3", "k8cQxDJN"], "requestedRegions": ["oXxP8oZp", "yXbNetHh", "HHCkzTYn"], "textChat": false, "tieTeamsSessionLifetime": true, "type": "9uPrSyla"}' > $TEMP_JSON_INPUT
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
    --limit '96' \
    --name '4fd1mQ08' \
    --offset '57' \
    --order 'XMiw1DSd' \
    --orderBy 'a6MuzfWe' \
    > test.out 2>&1
eval_tap $? 15 'AdminGetAllConfigurationTemplatesV1' test.out

#- 16 AdminGetConfigurationTemplateV1
$CLI_EXE \
    --sn session \
    --op AdminGetConfigurationTemplateV1 \
    --name 'v68BejlI' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 16 'AdminGetConfigurationTemplateV1' test.out

#- 17 AdminUpdateConfigurationTemplateV1
# body param: body
echo '{"NativeSessionSetting": {"PSNServiceLabel": 15, "PSNSupportedPlatforms": ["LfX7nuB0", "tvdD6tQB", "8Ge3Rkmq"], "SessionTitle": "mHVCBywz", "ShouldSync": false, "XboxAllowCrossPlatform": false, "XboxSandboxID": "LeUrjQsN", "XboxServiceConfigID": "Tgl73n6b", "XboxSessionTemplateName": "IBPtnfFy", "XboxTitleID": "Dcx5lVbt", "localizedSessionName": {"Lrxhydvi": {}, "2rR474fv": {}, "PgyKL5ZK": {}}}, "PSNBaseUrl": "NSzgQKOc", "attributes": {"vEUP4Ll5": {}, "eZqempgP": {}, "DuYxOmXw": {}}, "autoJoin": false, "clientVersion": "UcKxnhCq", "deployment": "Af0mlBRA", "disableCodeGeneration": false, "dsManualSetReady": true, "dsSource": "8fn3iQav", "enableSecret": false, "fallbackClaimKeys": ["rcJIMXSv", "ZdqeY8Pr", "cHOkqmWd"], "immutableStorage": false, "inactiveTimeout": 43, "inviteTimeout": 69, "joinability": "8brurYzD", "maxActiveSessions": 17, "maxPlayers": 7, "minPlayers": 8, "name": "sC9Jh5sh", "persistent": false, "preferredClaimKeys": ["4sLplHPo", "XWHjsuMX", "VxIwvs3e"], "requestedRegions": ["YeGDZ760", "rTfPArAp", "d59VqTd6"], "textChat": true, "tieTeamsSessionLifetime": true, "type": "1eHtK9p2"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminUpdateConfigurationTemplateV1 \
    --name 'uWb44Ykv' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 17 'AdminUpdateConfigurationTemplateV1' test.out

#- 18 AdminDeleteConfigurationTemplateV1
$CLI_EXE \
    --sn session \
    --op AdminDeleteConfigurationTemplateV1 \
    --name '7UsLGfcx' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 18 'AdminDeleteConfigurationTemplateV1' test.out

#- 19 AdminGetMemberActiveSession
$CLI_EXE \
    --sn session \
    --op AdminGetMemberActiveSession \
    --name 'Nc4aODhn' \
    --namespace $AB_NAMESPACE \
    --userId 'AHaStPc0' \
    > test.out 2>&1
eval_tap $? 19 'AdminGetMemberActiveSession' test.out

#- 20 AdminReconcileMaxActiveSession
# body param: body
echo '{"userID": "WHukghou"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminReconcileMaxActiveSession \
    --name 'hElKV1Xd' \
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
    --configurationName 'drbBjuG7' \
    --dsPodName 'VBZIS4UQ' \
    --fromTime 'oX6wmJpE' \
    --gameMode '3C5oMpcJ' \
    --isPersistent 'm3n4d9TX' \
    --isSoftDeleted 'Wdz3akpa' \
    --joinability 'Ev9Y7iYT' \
    --limit '46' \
    --matchPool 'C4cOlVQc' \
    --memberID 'j8GczN1T' \
    --offset '27' \
    --order 'lveH7ckx' \
    --orderBy 'ty0gGT5i' \
    --sessionID '1ANdEty7' \
    --status 'UihLxpKO' \
    --statusV2 'UgmyCAr2' \
    --toTime 'gF7QwsSf' \
    > test.out 2>&1
eval_tap $? 23 'AdminQueryGameSessions' test.out

#- 24 AdminQueryGameSessionsByAttributes
# body param: body
echo '{"ZquidWAk": {}, "XfbyYYjg": {}, "ruJcbeva": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminQueryGameSessionsByAttributes \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 24 'AdminQueryGameSessionsByAttributes' test.out

#- 25 AdminDeleteBulkGameSessions
# body param: body
echo '{"ids": ["OsNOrjGA", "E7w1Hhy3", "iEOq5N5G"]}' > $TEMP_JSON_INPUT
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
    --sessionId 'IbIwurLd' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 26 'AdminSetDSReady' test.out

#- 27 AdminUpdateGameSessionMember
$CLI_EXE \
    --sn session \
    --op AdminUpdateGameSessionMember \
    --memberId 'PvuzcMYM' \
    --namespace $AB_NAMESPACE \
    --sessionId 'YgR4rBaq' \
    --statusType 'i7l56HNd' \
    > test.out 2>&1
eval_tap $? 27 'AdminUpdateGameSessionMember' test.out

#- 28 AdminQueryParties
$CLI_EXE \
    --sn session \
    --op AdminQueryParties \
    --namespace $AB_NAMESPACE \
    --joinability 'P7216UnK' \
    --key 'aEo0VERI' \
    --leaderID '1cClL1ei' \
    --limit '27' \
    --memberID '7Inab1YZ' \
    --memberStatus '5SBY81aM' \
    --offset '92' \
    --order 'gWPUWvRw' \
    --orderBy '35hYLd5B' \
    --partyID 'azE8cSMX' \
    --value '5Y0qFKxR' \
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
echo '{"psn": {"clientId": "wr71IDXB", "clientSecret": "LNmqicAE", "scope": "T4yn17TK"}}' > $TEMP_JSON_INPUT
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
    --sessionId 'Eqv61pl4' \
    > test.out 2>&1
eval_tap $? 32 'AdminReadSessionStorage' test.out

#- 33 AdminDeleteUserSessionStorage
$CLI_EXE \
    --sn session \
    --op AdminDeleteUserSessionStorage \
    --namespace $AB_NAMESPACE \
    --sessionId '5WJILlvD' \
    > test.out 2>&1
eval_tap $? 33 'AdminDeleteUserSessionStorage' test.out

#- 34 AdminReadUserSessionStorage
$CLI_EXE \
    --sn session \
    --op AdminReadUserSessionStorage \
    --namespace $AB_NAMESPACE \
    --sessionId 'JcwBlULC' \
    --userId 'LeG3oBNW' \
    > test.out 2>&1
eval_tap $? 34 'AdminReadUserSessionStorage' test.out

#- 35 AdminQueryPlayerAttributes
$CLI_EXE \
    --sn session \
    --op AdminQueryPlayerAttributes \
    --namespace $AB_NAMESPACE \
    --users 'b23WfrT1' \
    > test.out 2>&1
eval_tap $? 35 'AdminQueryPlayerAttributes' test.out

#- 36 AdminGetPlayerAttributes
$CLI_EXE \
    --sn session \
    --op AdminGetPlayerAttributes \
    --namespace $AB_NAMESPACE \
    --userId 'gbk2pniQ' \
    > test.out 2>&1
eval_tap $? 36 'AdminGetPlayerAttributes' test.out

#- 37 CreateGameSession
# body param: body
echo '{"attributes": {"4GYk8c7M": {}, "vLJjr9NZ": {}, "SxsaTUpx": {}}, "autoJoin": false, "backfillTicketID": "QXGlLCr7", "clientVersion": "6jXB1JiQ", "configurationName": "9ueREIi5", "deployment": "bINsJRiE", "dsSource": "noPBiPZ2", "fallbackClaimKeys": ["d189BW84", "Y0SUKogD", "tjR79MUa"], "inactiveTimeout": 22, "inviteTimeout": 51, "joinability": "YfroRFlR", "matchPool": "wHztxlWp", "maxPlayers": 38, "minPlayers": 61, "preferredClaimKeys": ["1JadwwBw", "z9XM5m5F", "xJzo4Ke2"], "requestedRegions": ["Of4TWsNo", "sEywmdJw", "9nToz1fo"], "serverName": "HfMfVPTQ", "teams": [{"UserIDs": ["YGOUYfEM", "43iG4e8d", "FuNN2uIG"], "parties": [{"partyID": "4p9cAxWu", "userIDs": ["4HlbKVs9", "DReKxQAB", "jLckayeh"]}, {"partyID": "BuuwKpG6", "userIDs": ["OQhXwgkn", "uoObWBNA", "diuo9CrG"]}, {"partyID": "ErP2FhMc", "userIDs": ["WAAeuQtw", "VF2JHcT7", "oYRA8n3C"]}]}, {"UserIDs": ["5nitEzsz", "IF5S5UoS", "zpt0h8lb"], "parties": [{"partyID": "2KqoKQ8o", "userIDs": ["vGKyA1S0", "TSa0cZw1", "hn3BSNmd"]}, {"partyID": "0yRXFMeM", "userIDs": ["zpjRfQZS", "A5xgfWcV", "oiq2XM8p"]}, {"partyID": "IvSyqi7j", "userIDs": ["EvgoDVB6", "WtqLhVGU", "hCiLe9OR"]}]}, {"UserIDs": ["0mgh8MKo", "qHYarHsH", "p03NM6nT"], "parties": [{"partyID": "86G52Cm0", "userIDs": ["LiBxU5nb", "yuTPSBS2", "DiCg8UeI"]}, {"partyID": "lA7HvZIT", "userIDs": ["lshLJNWn", "zLOiNLPG", "yTJgZ04G"]}, {"partyID": "u8Rm9wsT", "userIDs": ["19rDuUOu", "ZER2rsaq", "lO0zxO2Y"]}]}], "textChat": false, "ticketIDs": ["mNoMGDKt", "7tBAb8Gi", "TJQFv4SD"], "tieTeamsSessionLifetime": false, "type": "cQW0FClG"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op CreateGameSession \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 37 'CreateGameSession' test.out

#- 38 PublicQueryGameSessionsByAttributes
# body param: body
echo '{"mc2Hdny5": {}, "EeiIrXy0": {}, "pxMMahc8": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicQueryGameSessionsByAttributes \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 38 'PublicQueryGameSessionsByAttributes' test.out

#- 39 PublicSessionJoinCode
# body param: body
echo '{"code": "C42e2np3"}' > $TEMP_JSON_INPUT
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
    --podName 'aJi9qOS7' \
    > test.out 2>&1
eval_tap $? 40 'GetGameSessionByPodName' test.out

#- 41 GetGameSession
$CLI_EXE \
    --sn session \
    --op GetGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'xWQ4GOhj' \
    > test.out 2>&1
eval_tap $? 41 'GetGameSession' test.out

#- 42 UpdateGameSession
# body param: body
echo '{"attributes": {"55ZrRMC9": {}, "VCx36cil": {}, "D5zXZtpH": {}}, "backfillTicketID": "t9lELpbN", "clientVersion": "jl06hFY4", "deployment": "a7ZCEU9j", "fallbackClaimKeys": ["cDMfy4SV", "LfA2oPky", "7xD0PPxQ"], "inactiveTimeout": 31, "inviteTimeout": 32, "joinability": "EW4jbXch", "matchPool": "wyi3Gp8X", "maxPlayers": 54, "minPlayers": 26, "preferredClaimKeys": ["tiGI4BV0", "nEczu6GG", "4EGlS455"], "requestedRegions": ["RkcsQtn1", "5mf3bZwC", "pTxIKyTZ"], "teams": [{"UserIDs": ["9VR6U5nW", "pJzq6Dek", "6ovXAvoT"], "parties": [{"partyID": "hITZnJmq", "userIDs": ["vJfxZuDj", "B2AODAdw", "eapgP1BX"]}, {"partyID": "snIvfstL", "userIDs": ["yH0lzsrd", "xDVXOocS", "GBnRtfqf"]}, {"partyID": "i1h7zfnc", "userIDs": ["p4KkKxua", "7O8s9e7n", "lHM4J1EL"]}]}, {"UserIDs": ["ODM4n1SQ", "dx9qed13", "SNFOqtsT"], "parties": [{"partyID": "5pWZd364", "userIDs": ["KPyv2ork", "KXz6JeHV", "9iAa8sWQ"]}, {"partyID": "KDVNZdUv", "userIDs": ["n69HQQqa", "qRDeyaDa", "XvC14ugS"]}, {"partyID": "yWzj1PJv", "userIDs": ["zmaagih9", "91PhxWGA", "1ELwAYwC"]}]}, {"UserIDs": ["4QhM23a4", "7kdINI4I", "sEUYlkiH"], "parties": [{"partyID": "M8fbD9Tb", "userIDs": ["tXyRL7Ow", "wXsnDgWa", "oSaLdyv0"]}, {"partyID": "NuxPPXmX", "userIDs": ["LIpUSw1E", "SitNlCNu", "mVviFTD1"]}, {"partyID": "zOlLnTyL", "userIDs": ["jQu4fBWg", "muq0u5aj", "TR2M3jDy"]}]}], "ticketIDs": ["upAgrwtt", "9Y8xchjp", "xV82717B"], "tieTeamsSessionLifetime": true, "type": "4ld0wS75", "version": 53}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op UpdateGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'hkwhd5pH' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 42 'UpdateGameSession' test.out

#- 43 DeleteGameSession
$CLI_EXE \
    --sn session \
    --op DeleteGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'OwvxOdAJ' \
    > test.out 2>&1
eval_tap $? 43 'DeleteGameSession' test.out

#- 44 PatchUpdateGameSession
# body param: body
echo '{"attributes": {"DcvwPWtp": {}, "f50Nkg4q": {}, "UJ1ecUzM": {}}, "backfillTicketID": "dTBjdnQx", "clientVersion": "jZ9knccH", "deployment": "4ZfdiDKm", "fallbackClaimKeys": ["Jtpfo3bZ", "qP34LIpu", "62oLW9Dj"], "inactiveTimeout": 51, "inviteTimeout": 38, "joinability": "5b4Hbztq", "matchPool": "2qeScFdS", "maxPlayers": 44, "minPlayers": 88, "preferredClaimKeys": ["G2euwIx8", "HJ65UxXS", "TLvDEni7"], "requestedRegions": ["0k2zlmDK", "bMH7fmce", "2RSXQeNi"], "teams": [{"UserIDs": ["EN0z4U9Z", "bqqYiYUk", "0hyDwxz1"], "parties": [{"partyID": "fj09E9XA", "userIDs": ["GjnqUZvk", "HaPuTQrd", "aMciHW7M"]}, {"partyID": "X29BMnoY", "userIDs": ["KXEbWzEB", "BKE6fAOZ", "yQfzi1t3"]}, {"partyID": "PZdFGOMY", "userIDs": ["ePSNpdTY", "VGZkOfD7", "Bth3Z64i"]}]}, {"UserIDs": ["ZG5cCVeQ", "4ecCop3a", "931BfpIf"], "parties": [{"partyID": "6dDey6F2", "userIDs": ["LNjt1YuL", "49OXiKoC", "Zv4J47eD"]}, {"partyID": "o2b5VqgT", "userIDs": ["Qcua3tYO", "d5Hek7xc", "lIS3Xyrp"]}, {"partyID": "rcGMEMFG", "userIDs": ["DwfQgzJ7", "bcSANx5L", "Vz5aMvno"]}]}, {"UserIDs": ["Se8n7NkM", "qI31OK16", "F8phssAH"], "parties": [{"partyID": "bi6HiCGc", "userIDs": ["n7IAyAgP", "Q1wI1sOP", "1YpWSEaS"]}, {"partyID": "FQpz31s1", "userIDs": ["wQR18GFQ", "l7QDp9F3", "0y3vYLk2"]}, {"partyID": "VX5yVPSI", "userIDs": ["lBrgDuC3", "uq1Hq6Mo", "46K37LLK"]}]}], "ticketIDs": ["WUZI0BZW", "zVPmXaYy", "G87LRiXX"], "tieTeamsSessionLifetime": true, "type": "iicJcTPQ", "version": 25}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PatchUpdateGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'wsCBYe6k' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 44 'PatchUpdateGameSession' test.out

#- 45 UpdateGameSessionBackfillTicketID
# body param: body
echo '{"backfillTicketID": "ufpozIim"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op UpdateGameSessionBackfillTicketID \
    --namespace $AB_NAMESPACE \
    --sessionId 'flYgXzUd' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 45 'UpdateGameSessionBackfillTicketID' test.out

#- 46 GameSessionGenerateCode
$CLI_EXE \
    --sn session \
    --op GameSessionGenerateCode \
    --namespace $AB_NAMESPACE \
    --sessionId 'riLpUFCw' \
    > test.out 2>&1
eval_tap $? 46 'GameSessionGenerateCode' test.out

#- 47 PublicRevokeGameSessionCode
$CLI_EXE \
    --sn session \
    --op PublicRevokeGameSessionCode \
    --namespace $AB_NAMESPACE \
    --sessionId 'aosUNRzv' \
    > test.out 2>&1
eval_tap $? 47 'PublicRevokeGameSessionCode' test.out

#- 48 PublicGameSessionInvite
# body param: body
echo '{"platformID": "5sAhNAMd", "userID": "Eny6HKsd"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicGameSessionInvite \
    --namespace $AB_NAMESPACE \
    --sessionId 'HQYeUb0d' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 48 'PublicGameSessionInvite' test.out

#- 49 JoinGameSession
$CLI_EXE \
    --sn session \
    --op JoinGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'JPd2WmkA' \
    > test.out 2>&1
eval_tap $? 49 'JoinGameSession' test.out

#- 50 PublicPromoteGameSessionLeader
# body param: body
echo '{"leaderID": "EXDMdNqA"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPromoteGameSessionLeader \
    --namespace $AB_NAMESPACE \
    --sessionId 'XcTqWvYC' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 50 'PublicPromoteGameSessionLeader' test.out

#- 51 LeaveGameSession
$CLI_EXE \
    --sn session \
    --op LeaveGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId '8BrxSnSu' \
    > test.out 2>&1
eval_tap $? 51 'LeaveGameSession' test.out

#- 52 PublicGameSessionReject
$CLI_EXE \
    --sn session \
    --op PublicGameSessionReject \
    --namespace $AB_NAMESPACE \
    --sessionId 'yIlfQ96r' \
    > test.out 2>&1
eval_tap $? 52 'PublicGameSessionReject' test.out

#- 53 GetSessionServerSecret
# body param: body
echo '{"secret": "kbUBCtOJ"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op GetSessionServerSecret \
    --namespace $AB_NAMESPACE \
    --sessionId 'fe72WJZ5' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 53 'GetSessionServerSecret' test.out

#- 54 AppendTeamGameSession
# body param: body
echo '{"additionalMembers": [{"partyID": "sEAjt2TL", "userIDs": ["7dRtF8je", "4O4XshUo", "WlATkqVp"]}, {"partyID": "9dT9F6Kq", "userIDs": ["Ylsnf2VY", "AMHeLHjS", "p6KkqHIg"]}, {"partyID": "ml37k8CZ", "userIDs": ["fu8yScNI", "unh0mvqD", "I78wuD1V"]}], "proposedTeams": [{"UserIDs": ["qfvZWUou", "ei4bRx1Z", "oCg99nkt"], "parties": [{"partyID": "tWjhzgct", "userIDs": ["YNBjOjIJ", "5iln6NFI", "RovB94gx"]}, {"partyID": "P9ktpWOr", "userIDs": ["LEMe1dHZ", "DIjEIt5k", "9yqpOm5Y"]}, {"partyID": "6X7nIHD3", "userIDs": ["G8vrgoRN", "336VnPf8", "bLM5w181"]}]}, {"UserIDs": ["6RbOIdfL", "tPa600gJ", "ptkIwm99"], "parties": [{"partyID": "ebFiRaOI", "userIDs": ["8WwunOMH", "MNvgbizF", "UaouSY2C"]}, {"partyID": "QNZGO1IY", "userIDs": ["CUJghlPx", "ETzSLsjK", "B1BvNfQR"]}, {"partyID": "TVRdsqec", "userIDs": ["marRDGYV", "tKbqHomz", "ITGn43OB"]}]}, {"UserIDs": ["IGzZ6Hi7", "mmFaG2P3", "YwnyhAw1"], "parties": [{"partyID": "9LJBTQyn", "userIDs": ["QkDGNvMY", "KhiebL7o", "FSUKme1a"]}, {"partyID": "9ivnGcZw", "userIDs": ["xWzfknk9", "K6hskV9W", "AqvofXh3"]}, {"partyID": "8kG1aveV", "userIDs": ["UEQZCJuF", "tqSgjBP3", "2YzyChNp"]}]}], "version": 57}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AppendTeamGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'uXB2y5E1' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 54 'AppendTeamGameSession' test.out

#- 55 PublicPartyJoinCode
# body param: body
echo '{"code": "aanfPKy8"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPartyJoinCode \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 55 'PublicPartyJoinCode' test.out

#- 56 PublicGetParty
$CLI_EXE \
    --sn session \
    --op PublicGetParty \
    --namespace $AB_NAMESPACE \
    --partyId '23kIIyOC' \
    > test.out 2>&1
eval_tap $? 56 'PublicGetParty' test.out

#- 57 PublicUpdateParty
# body param: body
echo '{"attributes": {"bQGbfAUV": {}, "he7ZwfBw": {}, "JSt5M7pE": {}}, "inactiveTimeout": 93, "inviteTimeout": 95, "joinability": "Zqm7J6sN", "maxPlayers": 38, "minPlayers": 55, "type": "MivIX5uF", "version": 22}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicUpdateParty \
    --namespace $AB_NAMESPACE \
    --partyId 'GC4i061F' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 57 'PublicUpdateParty' test.out

#- 58 PublicPatchUpdateParty
# body param: body
echo '{"attributes": {"QaptaES3": {}, "T25pnWBv": {}, "wNV5Fl2B": {}}, "inactiveTimeout": 69, "inviteTimeout": 43, "joinability": "QmJCVvta", "maxPlayers": 73, "minPlayers": 6, "type": "owrWU3VZ", "version": 12}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPatchUpdateParty \
    --namespace $AB_NAMESPACE \
    --partyId 'awAhM9Rh' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 58 'PublicPatchUpdateParty' test.out

#- 59 PublicGeneratePartyCode
$CLI_EXE \
    --sn session \
    --op PublicGeneratePartyCode \
    --namespace $AB_NAMESPACE \
    --partyId 'bPWLSo5Q' \
    > test.out 2>&1
eval_tap $? 59 'PublicGeneratePartyCode' test.out

#- 60 PublicRevokePartyCode
$CLI_EXE \
    --sn session \
    --op PublicRevokePartyCode \
    --namespace $AB_NAMESPACE \
    --partyId 'Li1tY0ZI' \
    > test.out 2>&1
eval_tap $? 60 'PublicRevokePartyCode' test.out

#- 61 PublicPartyInvite
# body param: body
echo '{"platformID": "gTbrKKjO", "userID": "8vBh8bDW"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPartyInvite \
    --namespace $AB_NAMESPACE \
    --partyId 'V0JdaFZr' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 61 'PublicPartyInvite' test.out

#- 62 PublicPromotePartyLeader
# body param: body
echo '{"leaderID": "y5RCEnDe"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPromotePartyLeader \
    --namespace $AB_NAMESPACE \
    --partyId 'EqGXrmUD' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 62 'PublicPromotePartyLeader' test.out

#- 63 PublicPartyJoin
$CLI_EXE \
    --sn session \
    --op PublicPartyJoin \
    --namespace $AB_NAMESPACE \
    --partyId 'lOwFJO1P' \
    > test.out 2>&1
eval_tap $? 63 'PublicPartyJoin' test.out

#- 64 PublicPartyLeave
$CLI_EXE \
    --sn session \
    --op PublicPartyLeave \
    --namespace $AB_NAMESPACE \
    --partyId 'uxD0iIho' \
    > test.out 2>&1
eval_tap $? 64 'PublicPartyLeave' test.out

#- 65 PublicPartyReject
$CLI_EXE \
    --sn session \
    --op PublicPartyReject \
    --namespace $AB_NAMESPACE \
    --partyId 'lKTntGDl' \
    > test.out 2>&1
eval_tap $? 65 'PublicPartyReject' test.out

#- 66 PublicPartyKick
$CLI_EXE \
    --sn session \
    --op PublicPartyKick \
    --namespace $AB_NAMESPACE \
    --partyId 'Fk5r8wu5' \
    --userId '2zC1Oc0w' \
    > test.out 2>&1
eval_tap $? 66 'PublicPartyKick' test.out

#- 67 PublicCreateParty
# body param: body
echo '{"attributes": {"xYOMgVKq": {}, "HnckZhW5": {}, "neGmZEHv": {}}, "configurationName": "k4eOqEgc", "inactiveTimeout": 82, "inviteTimeout": 11, "joinability": "iENCa7eW", "maxPlayers": 60, "members": [{"ID": "Yqv50tM1", "PlatformID": "7CRWNwfZ", "PlatformUserID": "GX5egPT9"}, {"ID": "sqArI4aM", "PlatformID": "Uk1NdVfR", "PlatformUserID": "CETWdCkS"}, {"ID": "OGmQVJgF", "PlatformID": "mIqKmE5g", "PlatformUserID": "tJxhkoFI"}], "minPlayers": 50, "textChat": false, "type": "RyBXacQf"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicCreateParty \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 67 'PublicCreateParty' test.out

#- 68 PublicUpdateInsertSessionStorageLeader
# body param: body
echo '{"3cKVxDWv": {}, "GleaEKX8": {}, "M5AYvYSd": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicUpdateInsertSessionStorageLeader \
    --namespace $AB_NAMESPACE \
    --sessionId 'wbVp0tYV' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 68 'PublicUpdateInsertSessionStorageLeader' test.out

#- 69 PublicUpdateInsertSessionStorage
# body param: body
echo '{"okVzaEX1": {}, "DAhfLkLI": {}, "lGi9dLqp": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicUpdateInsertSessionStorage \
    --namespace $AB_NAMESPACE \
    --sessionId 'NdbRNdis' \
    --userId 'VrtEKWGP' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 69 'PublicUpdateInsertSessionStorage' test.out

#- 70 PublicGetBulkPlayerCurrentPlatform
# body param: body
echo '{"userIDs": ["UPz0fXEs", "lwOHeP1N", "ATAXzFRP"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicGetBulkPlayerCurrentPlatform \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 70 'PublicGetBulkPlayerCurrentPlatform' test.out

#- 71 PublicGetPlayerAttributes
$CLI_EXE \
    --sn session \
    --op PublicGetPlayerAttributes \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 71 'PublicGetPlayerAttributes' test.out

#- 72 PublicStorePlayerAttributes
# body param: body
echo '{"crossplayEnabled": true, "currentPlatform": "YgQdhP7d", "data": {"rysunBQN": {}, "LJT6rICV": {}, "atXm1Tzs": {}}, "platforms": [{"name": "fKIqOkIC", "userID": "dsvG8yj9"}, {"name": "MmqeO4GZ", "userID": "yk4wQzXi"}, {"name": "OzWIYlmB", "userID": "rLxHRO3m"}], "roles": ["75atF2ES", "4TpHqxZr", "cO4YYnfd"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicStorePlayerAttributes \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 72 'PublicStorePlayerAttributes' test.out

#- 73 PublicDeletePlayerAttributes
$CLI_EXE \
    --sn session \
    --op PublicDeletePlayerAttributes \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 73 'PublicDeletePlayerAttributes' test.out

#- 74 PublicQueryMyGameSessions
$CLI_EXE \
    --sn session \
    --op PublicQueryMyGameSessions \
    --namespace $AB_NAMESPACE \
    --order 'ORdRlHYq' \
    --orderBy '0AxA5adx' \
    --status 'JbFeKuj4' \
    > test.out 2>&1
eval_tap $? 74 'PublicQueryMyGameSessions' test.out

#- 75 PublicQueryMyParties
$CLI_EXE \
    --sn session \
    --op PublicQueryMyParties \
    --namespace $AB_NAMESPACE \
    --order '3uOkVGmW' \
    --orderBy 'NhjRWy5R' \
    --status 'bG9hYXtM' \
    > test.out 2>&1
eval_tap $? 75 'PublicQueryMyParties' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE