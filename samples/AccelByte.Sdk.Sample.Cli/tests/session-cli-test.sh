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
echo "1..47"

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

#- 5 AdminCreateConfigurationTemplateV1
# body param: body
echo '{"clientVersion": "bBuz5zko", "deployment": "aUEzGS3q", "inactiveTimeout": 12, "inviteTimeout": 79, "joinability": "0PbemSBE", "maxPlayers": 76, "minPlayers": 69, "name": "bZ0VBUGA", "persistent": false, "requestedRegions": ["LR3IlNJK", "xhPfWV6d", "IabcFbSm"], "textChat": false, "type": "s4233oQW"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminCreateConfigurationTemplateV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 5 'AdminCreateConfigurationTemplateV1' test.out

#- 6 AdminGetAllConfigurationTemplatesV1
$CLI_EXE \
    --sn session \
    --op AdminGetAllConfigurationTemplatesV1 \
    --namespace $AB_NAMESPACE \
    --limit '29' \
    --offset '46' \
    > test.out 2>&1
eval_tap $? 6 'AdminGetAllConfigurationTemplatesV1' test.out

#- 7 AdminGetConfigurationTemplateV1
$CLI_EXE \
    --sn session \
    --op AdminGetConfigurationTemplateV1 \
    --name 'XFeqeuI2' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 7 'AdminGetConfigurationTemplateV1' test.out

#- 8 AdminUpdateConfigurationTemplateV1
# body param: body
echo '{"clientVersion": "oMJ0cgAo", "deployment": "GfXepE3r", "inactiveTimeout": 26, "inviteTimeout": 54, "joinability": "y8tZ5GZi", "maxPlayers": 93, "minPlayers": 84, "name": "YZLJ58Qq", "persistent": false, "requestedRegions": ["fMI04rm2", "jUc9iav3", "tTqlE9oL"], "textChat": true, "type": "C65VJh4q"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AdminUpdateConfigurationTemplateV1 \
    --name '1z1KJmKe' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 8 'AdminUpdateConfigurationTemplateV1' test.out

#- 9 AdminDeleteConfigurationTemplateV1
$CLI_EXE \
    --sn session \
    --op AdminDeleteConfigurationTemplateV1 \
    --name 'dBfbWvKa' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 9 'AdminDeleteConfigurationTemplateV1' test.out

#- 10 AdminGetDSMCConfiguration
$CLI_EXE \
    --sn session \
    --op AdminGetDSMCConfiguration \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 10 'AdminGetDSMCConfiguration' test.out

#- 11 AdminSyncDSMCConfiguration
$CLI_EXE \
    --sn session \
    --op AdminSyncDSMCConfiguration \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 11 'AdminSyncDSMCConfiguration' test.out

#- 12 AdminQueryGameSessions
$CLI_EXE \
    --sn session \
    --op AdminQueryGameSessions \
    --namespace $AB_NAMESPACE \
    --configurationName '5Ou124Ts' \
    --dsPodName 'bQsxYFxG' \
    --fromTime 'GHrfQkgX' \
    --gameMode 'kiA5IZPq' \
    --isPersistent 'Cqp9vcyt' \
    --isSoftDeleted '67WAfWXf' \
    --joinability 'UfwGB03t' \
    --limit '51' \
    --matchPool '7xodwuG1' \
    --memberID '4ID5l5wj' \
    --offset '74' \
    --order 'p8Y5c9eI' \
    --orderBy 'tJtiNmY3' \
    --sessionID 'y3n2Rim4' \
    --status 'NBqhuNtj' \
    --statusV2 '8FOvKZjs' \
    --toTime '1tLpERf7' \
    > test.out 2>&1
eval_tap $? 12 'AdminQueryGameSessions' test.out

#- 13 AdminUpdateGameSessionMember
$CLI_EXE \
    --sn session \
    --op AdminUpdateGameSessionMember \
    --memberId '7LzPoORB' \
    --namespace $AB_NAMESPACE \
    --sessionId 'kRmZ0A2z' \
    --statusType 'yZsb4FvW' \
    > test.out 2>&1
eval_tap $? 13 'AdminUpdateGameSessionMember' test.out

#- 14 AdminQueryParties
$CLI_EXE \
    --sn session \
    --op AdminQueryParties \
    --namespace $AB_NAMESPACE \
    --joinability 'FIHPIbOj' \
    --key 'pls9BZTY' \
    --leaderID 'c5BsdSSV' \
    --limit '0' \
    --memberID 'HH8kT9oX' \
    --memberStatus 'Vandercf' \
    --offset '50' \
    --order 'nq4Hf32S' \
    --orderBy 'L5PjaYED' \
    --value 'xaYN8w9K' \
    > test.out 2>&1
eval_tap $? 14 'AdminQueryParties' test.out

#- 15 AdminQueryPlayerAttributes
$CLI_EXE \
    --sn session \
    --op AdminQueryPlayerAttributes \
    --namespace $AB_NAMESPACE \
    --users 'UW0py8Kr' \
    > test.out 2>&1
eval_tap $? 15 'AdminQueryPlayerAttributes' test.out

#- 16 AdminGetPlayerAttributes
$CLI_EXE \
    --sn session \
    --op AdminGetPlayerAttributes \
    --namespace $AB_NAMESPACE \
    --userId 'cQfucSq2' \
    > test.out 2>&1
eval_tap $? 16 'AdminGetPlayerAttributes' test.out

#- 17 CreateGameSession
# body param: body
echo '{"attributes": {"X8gFuJOR": {}, "k4j04Yfn": {}, "XTsQUrA0": {}}, "backfillTicketID": "WWyKl2K5", "clientVersion": "mCSoGeQC", "configurationName": "ahcox63c", "deployment": "yDxAAYcR", "inactiveTimeout": 30, "inviteTimeout": 73, "joinability": "sbh0fL2h", "matchPool": "7eJvAS2W", "maxPlayers": 29, "minPlayers": 41, "requestedRegions": ["W8bDq5jP", "qzhN0YdG", "SrA9LXRw"], "serverName": "U6WLgpQE", "teams": [{"UserIDs": ["9nXzhBC0", "uyMR4Xf2", "nfYvNvG8"], "parties": [{"partyID": "uQ14Ahsx", "userIDs": ["aALiBwpN", "JornrCQp", "MJj5igqa"]}, {"partyID": "t8xnPoWT", "userIDs": ["dHAkcyAy", "4drHlPcX", "GGl0Xw3v"]}, {"partyID": "eBfrpCrn", "userIDs": ["baxhEvn3", "SGqcH91f", "C3aJEoqW"]}]}, {"UserIDs": ["aFAGD6PR", "g95m07l0", "3vtlMFze"], "parties": [{"partyID": "iMRkcOr1", "userIDs": ["L0TMIczb", "YilOziwG", "8CPLOzSZ"]}, {"partyID": "m9K3cMY6", "userIDs": ["17HSCYZa", "L46I3PgC", "cQ0axTWn"]}, {"partyID": "myEYLZQT", "userIDs": ["pvLH6QPE", "BP8kSSFj", "euL3wQQP"]}]}, {"UserIDs": ["YwmYFbxR", "vHYDCYwo", "GdmzXgf1"], "parties": [{"partyID": "ewUTvnu0", "userIDs": ["ensa3MZF", "7DTswnkS", "yuJTVjKQ"]}, {"partyID": "1ORLEIAe", "userIDs": ["PvDO2xkV", "gyRk10b2", "7RdU8Vce"]}, {"partyID": "YQ9erPYQ", "userIDs": ["5yVcQuvD", "bGMqbEHk", "CQwMBcQU"]}]}], "textChat": true, "ticketIDs": ["HN8YZT0y", "JJ0uCjja", "NCRV3hSI"], "type": "iTEoTCSx"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op CreateGameSession \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 17 'CreateGameSession' test.out

#- 18 PublicQueryGameSessions
# body param: body
echo '{"jAqg9oGV": {}, "EdC8mQir": {}, "1Af0G6Or": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicQueryGameSessions \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 18 'PublicQueryGameSessions' test.out

#- 19 GetGameSessionByPodName
$CLI_EXE \
    --sn session \
    --op GetGameSessionByPodName \
    --namespace $AB_NAMESPACE \
    --podName 'PH6ZsjpP' \
    > test.out 2>&1
eval_tap $? 19 'GetGameSessionByPodName' test.out

#- 20 GetGameSession
$CLI_EXE \
    --sn session \
    --op GetGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'gHKISHtB' \
    > test.out 2>&1
eval_tap $? 20 'GetGameSession' test.out

#- 21 UpdateGameSession
# body param: body
echo '{"attributes": {"8tWdJM9Q": {}, "c5HmR0vk": {}, "nXO45AUt": {}}, "backfillTicketID": "NXSTItt3", "clientVersion": "5OJTfJBZ", "deployment": "X62yI9g5", "inactiveTimeout": 89, "inviteTimeout": 35, "joinability": "DrlzPFQm", "matchPool": "Nu3ERxV0", "maxPlayers": 96, "minPlayers": 93, "requestedRegions": ["k3skhn3m", "WZjTYM95", "e4aa8xOJ"], "teams": [{"UserIDs": ["u7rNRVdy", "gfKmUkzj", "9mHFpff2"], "parties": [{"partyID": "vDkz68zo", "userIDs": ["rEgcExv9", "nKMOgO5W", "8SUaZjCp"]}, {"partyID": "NtJSMm8k", "userIDs": ["Di3Rwubq", "7wtRGdT4", "47Oa51m6"]}, {"partyID": "VLfjsw27", "userIDs": ["0pMmOQJr", "pEBbVvBn", "8Lsf2qSA"]}]}, {"UserIDs": ["tizV9hzs", "VbpJLtEZ", "juyFhvbx"], "parties": [{"partyID": "X2DNbknf", "userIDs": ["Vv4nm70T", "CayYAkF1", "8YBwRxcR"]}, {"partyID": "EyU5CwqG", "userIDs": ["JF6nDi33", "Iztr2Qcw", "lRrReRaj"]}, {"partyID": "lpk8lfui", "userIDs": ["JVcktlx9", "zJZVVCc9", "bpIHEWQM"]}]}, {"UserIDs": ["mCkIqwqp", "oTVCNrca", "VozsjIXO"], "parties": [{"partyID": "2EUsAfBv", "userIDs": ["o6Llcalk", "s2R3VMti", "pTVxXAF8"]}, {"partyID": "KhOKqbrE", "userIDs": ["CijFxOpO", "zxeTLJQs", "ZcTEzXaX"]}, {"partyID": "UzpsAV6c", "userIDs": ["t6XITL0Q", "EkadMSQl", "uAoED9oY"]}]}], "ticketIDs": ["wS8oLyEr", "KvRtHFGJ", "RoGW7VBG"], "type": "1VB2sp2x", "version": 85}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op UpdateGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'mszGGoyh' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 21 'UpdateGameSession' test.out

#- 22 DeleteGameSession
$CLI_EXE \
    --sn session \
    --op DeleteGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'GZAzt2OV' \
    > test.out 2>&1
eval_tap $? 22 'DeleteGameSession' test.out

#- 23 PatchUpdateGameSession
# body param: body
echo '{"attributes": {"BTLwSH8h": {}, "WRU9pbIt": {}, "GQ7VUWBh": {}}, "backfillTicketID": "GolwafIf", "clientVersion": "bF1GLFnr", "deployment": "Q4T5cmw7", "inactiveTimeout": 96, "inviteTimeout": 67, "joinability": "1TxiS06U", "matchPool": "EoaDZpXO", "maxPlayers": 99, "minPlayers": 93, "requestedRegions": ["zpXOi2cp", "ajtqcXjP", "kj2IzU3M"], "teams": [{"UserIDs": ["EpCt1Ijl", "fHJM92t9", "j1XT2Erw"], "parties": [{"partyID": "IxkaTnYt", "userIDs": ["r1YDnaXB", "0JOS4XKV", "T66sHYPg"]}, {"partyID": "VsfhoEid", "userIDs": ["Kw4IP0NV", "naangorh", "VFpTRuQy"]}, {"partyID": "MroT2hNf", "userIDs": ["KJ7q8sif", "SPmYSsBx", "tyKWssEn"]}]}, {"UserIDs": ["5VEvIMEB", "4pl506fL", "CG6EAl7d"], "parties": [{"partyID": "3Ks65tht", "userIDs": ["njcMSw1J", "42fthKUo", "bas2CAlS"]}, {"partyID": "xxVhDR9h", "userIDs": ["laznetBU", "GcQz2Wvd", "iclkYGDL"]}, {"partyID": "2ckC9cdz", "userIDs": ["aLnajQ8G", "nJpALidd", "v9UUtG1t"]}]}, {"UserIDs": ["EECsm8xa", "DOz0tMlp", "FuJVXo9s"], "parties": [{"partyID": "0JPG8cgj", "userIDs": ["HQo9HoLL", "yUnPTiCD", "0038or8w"]}, {"partyID": "R0tuwIJn", "userIDs": ["rSI2IFcR", "wSoMTuJz", "iuDNbOyd"]}, {"partyID": "iu3lOaru", "userIDs": ["uYw0iUut", "s6bChMK1", "gcx8p9fy"]}]}], "ticketIDs": ["v5PoMJeT", "IQix1FEv", "zlipE7r0"], "type": "vhh21v57", "version": 38}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PatchUpdateGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId '2AopmjI7' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 23 'PatchUpdateGameSession' test.out

#- 24 UpdateGameSessionBackfillTicketID
# body param: body
echo '{"backfillTicketID": "CbY2WuwR"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op UpdateGameSessionBackfillTicketID \
    --namespace $AB_NAMESPACE \
    --sessionId 'UT9IivgC' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 24 'UpdateGameSessionBackfillTicketID' test.out

#- 25 PublicGameSessionInvite
# body param: body
echo '{"userID": "4mJ5OHuN"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicGameSessionInvite \
    --namespace $AB_NAMESPACE \
    --sessionId 'EVQK4Mvk' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 25 'PublicGameSessionInvite' test.out

#- 26 JoinGameSession
$CLI_EXE \
    --sn session \
    --op JoinGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId '00I9GqAh' \
    > test.out 2>&1
eval_tap $? 26 'JoinGameSession' test.out

#- 27 LeaveGameSession
$CLI_EXE \
    --sn session \
    --op LeaveGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'hjNIivdI' \
    > test.out 2>&1
eval_tap $? 27 'LeaveGameSession' test.out

#- 28 PublicGameSessionReject
$CLI_EXE \
    --sn session \
    --op PublicGameSessionReject \
    --namespace $AB_NAMESPACE \
    --sessionId 'caEQfNET' \
    > test.out 2>&1
eval_tap $? 28 'PublicGameSessionReject' test.out

#- 29 AppendTeamGameSession
# body param: body
echo '{"additionalMembers": [{"partyID": "QCBPK1mY", "userIDs": ["wKVQoydb", "YjXZyBpq", "hCJBtFOm"]}, {"partyID": "3iCpu0lh", "userIDs": ["hgutt3rQ", "uKP1OEtK", "FBjNihHU"]}, {"partyID": "8GP8TRVy", "userIDs": ["pSvYXKz4", "BGjbsrRB", "V8aztJ86"]}], "proposedTeams": [{"UserIDs": ["yQK1AsC1", "8UO6JcXm", "wQfkseTp"], "parties": [{"partyID": "H6l2Dv8S", "userIDs": ["vqYKc56P", "cPSL2xmj", "ViKkKw4g"]}, {"partyID": "HA4CaLsP", "userIDs": ["qRsTdKzc", "KtkGcvn4", "4NWse6VL"]}, {"partyID": "PkM1VTrQ", "userIDs": ["BywhJ7lb", "BLw9xy1W", "QM5qUS8b"]}]}, {"UserIDs": ["aUqkzSr4", "1y6RPBHJ", "uPjj8zDw"], "parties": [{"partyID": "Ok0IgmYf", "userIDs": ["UTpFzyQh", "PVhRGX9x", "lUKhXI8m"]}, {"partyID": "L8OIhvP6", "userIDs": ["8xE68dzo", "hxhbej2c", "aIIfkXDY"]}, {"partyID": "7jnhp3qY", "userIDs": ["6T7TUEBo", "tSNIwGhi", "a6cqoWmn"]}]}, {"UserIDs": ["htuzxir1", "2r0VUWI0", "kJAczj5A"], "parties": [{"partyID": "pcsiEQ65", "userIDs": ["llgGnTHA", "sTCZa7xE", "4nwGKlbP"]}, {"partyID": "RxfucxoR", "userIDs": ["KFLxxcL9", "SyuHbvRx", "R6LaKWgA"]}, {"partyID": "VjZKDxie", "userIDs": ["zEbuMCz9", "J4dPRGzo", "QLYIWPPZ"]}]}], "version": 45}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op AppendTeamGameSession \
    --namespace $AB_NAMESPACE \
    --sessionId 'gU9406td' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 29 'AppendTeamGameSession' test.out

#- 30 PublicPartyJoinCode
# body param: body
echo '{"code": "RDqr3cpV"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPartyJoinCode \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 30 'PublicPartyJoinCode' test.out

#- 31 PublicGetParty
$CLI_EXE \
    --sn session \
    --op PublicGetParty \
    --namespace $AB_NAMESPACE \
    --partyId 'baH69NyT' \
    > test.out 2>&1
eval_tap $? 31 'PublicGetParty' test.out

#- 32 PublicUpdateParty
# body param: body
echo '{"attributes": {"fGE59942": {}, "bCwgpzUf": {}, "cmTQjRmV": {}}, "inactiveTimeout": 41, "inviteTimeout": 59, "joinability": "kZuhL6qb", "maxPlayers": 53, "minPlayers": 35, "type": "hRExsnbW", "version": 91}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicUpdateParty \
    --namespace $AB_NAMESPACE \
    --partyId 'pTddIA0R' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 32 'PublicUpdateParty' test.out

#- 33 PublicPatchUpdateParty
# body param: body
echo '{"attributes": {"t6wM5oQv": {}, "TMICtWyU": {}, "tVDnhgTG": {}}, "inactiveTimeout": 79, "inviteTimeout": 82, "joinability": "yYp2tSrL", "maxPlayers": 48, "minPlayers": 31, "type": "MpqczRvU", "version": 6}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPatchUpdateParty \
    --namespace $AB_NAMESPACE \
    --partyId 'Wmjx1WuN' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 33 'PublicPatchUpdateParty' test.out

#- 34 PublicGeneratePartyCode
$CLI_EXE \
    --sn session \
    --op PublicGeneratePartyCode \
    --namespace $AB_NAMESPACE \
    --partyId 'Qq4v8FnV' \
    > test.out 2>&1
eval_tap $? 34 'PublicGeneratePartyCode' test.out

#- 35 PublicRevokePartyCode
$CLI_EXE \
    --sn session \
    --op PublicRevokePartyCode \
    --namespace $AB_NAMESPACE \
    --partyId 'zdbNW1xu' \
    > test.out 2>&1
eval_tap $? 35 'PublicRevokePartyCode' test.out

#- 36 PublicPartyInvite
# body param: body
echo '{"userID": "V7rVei1o"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPartyInvite \
    --namespace $AB_NAMESPACE \
    --partyId '9zV6rhVf' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 36 'PublicPartyInvite' test.out

#- 37 PublicPromotePartyLeader
# body param: body
echo '{"leaderID": "cQmLfEn5"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicPromotePartyLeader \
    --namespace $AB_NAMESPACE \
    --partyId 'ZUGeYlOw' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 37 'PublicPromotePartyLeader' test.out

#- 38 PublicPartyJoin
$CLI_EXE \
    --sn session \
    --op PublicPartyJoin \
    --namespace $AB_NAMESPACE \
    --partyId 'ODWBAz6s' \
    > test.out 2>&1
eval_tap $? 38 'PublicPartyJoin' test.out

#- 39 PublicPartyLeave
$CLI_EXE \
    --sn session \
    --op PublicPartyLeave \
    --namespace $AB_NAMESPACE \
    --partyId 'kHMfl4Hj' \
    > test.out 2>&1
eval_tap $? 39 'PublicPartyLeave' test.out

#- 40 PublicPartyReject
$CLI_EXE \
    --sn session \
    --op PublicPartyReject \
    --namespace $AB_NAMESPACE \
    --partyId 'w9KEnx8c' \
    > test.out 2>&1
eval_tap $? 40 'PublicPartyReject' test.out

#- 41 PublicPartyKick
$CLI_EXE \
    --sn session \
    --op PublicPartyKick \
    --namespace $AB_NAMESPACE \
    --partyId 'NfDK45zW' \
    --userId 'twYhRoNP' \
    > test.out 2>&1
eval_tap $? 41 'PublicPartyKick' test.out

#- 42 PublicCreateParty
# body param: body
echo '{"attributes": {"wKema6ca": {}, "MTOcivPA": {}, "kmP8Awb0": {}}, "configurationName": "NqtvSR9q", "inactiveTimeout": 48, "inviteTimeout": 24, "joinability": "Ml5Rw4Ye", "maxPlayers": 70, "members": [{"ID": "PoTuxdzE", "PlatformID": "YAw5VdW0", "PlatformUserID": "5WnQEAbK"}, {"ID": "416LN2N6", "PlatformID": "D6yczitn", "PlatformUserID": "4OkZfx0X"}, {"ID": "a6sgegAW", "PlatformID": "Yz2z4qSP", "PlatformUserID": "PQBDFQsv"}], "minPlayers": 90, "textChat": false, "type": "HbGTC2yn"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicCreateParty \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 42 'PublicCreateParty' test.out

#- 43 PublicGetPlayerAttributes
$CLI_EXE \
    --sn session \
    --op PublicGetPlayerAttributes \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 43 'PublicGetPlayerAttributes' test.out

#- 44 PublicStorePlayerAttributes
# body param: body
echo '{"crossplayEnabled": true, "data": {"Y7yMGOuQ": {}, "Ofx6HIFf": {}, "wBBqG51R": {}}, "platforms": [{"name": "aZY74Cqd", "userID": "vfPAIaPE"}, {"name": "kCIXX7WQ", "userID": "3ytABCzY"}, {"name": "WxYbbphu", "userID": "iQPU0aS2"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn session \
    --op PublicStorePlayerAttributes \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 44 'PublicStorePlayerAttributes' test.out

#- 45 PublicDeletePlayerAttributes
$CLI_EXE \
    --sn session \
    --op PublicDeletePlayerAttributes \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 45 'PublicDeletePlayerAttributes' test.out

#- 46 PublicQueryMyGameSessions
$CLI_EXE \
    --sn session \
    --op PublicQueryMyGameSessions \
    --namespace $AB_NAMESPACE \
    --order 'OIp0B2FW' \
    --orderBy 'iDu7POao' \
    --status 'tJoQQyL1' \
    > test.out 2>&1
eval_tap $? 46 'PublicQueryMyGameSessions' test.out

#- 47 PublicQueryMyParties
$CLI_EXE \
    --sn session \
    --op PublicQueryMyParties \
    --namespace $AB_NAMESPACE \
    --order 'bCDNisOh' \
    --orderBy 'jEKFWmj7' \
    --status 'ioi5WZ6Z' \
    > test.out 2>&1
eval_tap $? 47 'PublicQueryMyParties' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE