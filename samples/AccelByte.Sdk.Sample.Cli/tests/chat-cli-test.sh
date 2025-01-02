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
echo "1..64"

#- 1 Login
$CLI_EXE --op login --lt user --user user --pass user > test.out 2>&1
eval_tap $? 1 'Login' test.out

if [ $EXIT_CODE -ne 0 ]; then
  echo "Bail out! Login failed."
  exit $EXIT_CODE
fi

# echo "foo" > "$CLI_TOKEN_FILE"

#- 2 AdminFilterChatMessage
# body param: body
echo '{"message": "ODn7DO18", "timestamp": 15, "topicId": "SWQhFQ8m", "topicType": "PERSONAL", "userId": "jHzMZFa2"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminFilterChatMessage \
    --namespace $AB_NAMESPACE \
    --detail 'true' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 2 'AdminFilterChatMessage' test.out

#- 3 AdminChatHistory
$CLI_EXE \
    --sn chat \
    --op AdminChatHistory \
    --namespace $AB_NAMESPACE \
    --chatId '["lsxreV7X", "eyoHu7Kk", "rbZXKMuY"]' \
    --endCreatedAt '23' \
    --keyword 'tHRzi1Su' \
    --limit '79' \
    --offset '94' \
    --order 'u6btbaWA' \
    --senderUserId 'mniwtjvv' \
    --shardId 'X2AZ326f' \
    --startCreatedAt '86' \
    --topic '["AtKSBbu1", "Eo2RBG4j", "pFDOLXqK"]' \
    --unfiltered 'true' \
    > test.out 2>&1
eval_tap $? 3 'AdminChatHistory' test.out

#- 4 AdminCreateNamespaceTopic
# body param: body
echo '{"description": "lPEBShsF", "name": "Bsz3cEX2"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminCreateNamespaceTopic \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 4 'AdminCreateNamespaceTopic' test.out

#- 5 AdminTopicList
$CLI_EXE \
    --sn chat \
    --op AdminTopicList \
    --namespace $AB_NAMESPACE \
    --limit '2' \
    --offset '85' \
    --topicType 'IEcYc4QZ' \
    > test.out 2>&1
eval_tap $? 5 'AdminTopicList' test.out

#- 6 AdminCreateTopic
# body param: body
echo '{"admins": ["jQJC1GOV", "zomXmMnx", "KOPAkLs6"], "description": "MFaUkuyW", "isChannel": false, "isJoinable": false, "members": ["5RQGIO6X", "h8ZlG1kE", "9yhTS0Ro"], "name": "wXodVvyT", "shardLimit": 34, "type": "KLh6plhg"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminCreateTopic \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 6 'AdminCreateTopic' test.out

#- 7 AdminChannelTopicList
$CLI_EXE \
    --sn chat \
    --op AdminChannelTopicList \
    --namespace $AB_NAMESPACE \
    --limit '18' \
    --offset '49' \
    --topicName 'PnrpxwlS' \
    > test.out 2>&1
eval_tap $? 7 'AdminChannelTopicList' test.out

#- 8 AdminChannelTopicSummary
$CLI_EXE \
    --sn chat \
    --op AdminChannelTopicSummary \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 8 'AdminChannelTopicSummary' test.out

#- 9 AdminQueryTopicLog
$CLI_EXE \
    --sn chat \
    --op AdminQueryTopicLog \
    --namespace $AB_NAMESPACE \
    --endCreatedAt '100' \
    --limit '33' \
    --offset '39' \
    --senderUserId 'PPUl7vC1' \
    --startCreatedAt '7' \
    --topicId 'wZRkLWnb' \
    --topicIds '["79BkzBho", "61QNywRL", "NCybBqgX"]' \
    --userId 'XjC9KqUb' \
    > test.out 2>&1
eval_tap $? 9 'AdminQueryTopicLog' test.out

#- 10 AdminUpdateTopic
# body param: body
echo '{"description": "KYUsyjwv", "isJoinable": false, "name": "3f8jCCzW"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminUpdateTopic \
    --namespace $AB_NAMESPACE \
    --topic 'MA7R7JNm' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 10 'AdminUpdateTopic' test.out

#- 11 AdminDeleteTopic
$CLI_EXE \
    --sn chat \
    --op AdminDeleteTopic \
    --namespace $AB_NAMESPACE \
    --topic 'O6IJ3Yd8' \
    > test.out 2>&1
eval_tap $? 11 'AdminDeleteTopic' test.out

#- 12 AdminBanTopicMembers
# body param: body
echo '{"userIds": ["ugzX0GGk", "Klu5wI1x", "u1Lx6dgp"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminBanTopicMembers \
    --namespace $AB_NAMESPACE \
    --topic 'wRReW2j6' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 12 'AdminBanTopicMembers' test.out

#- 13 AdminChannelTopicInfo
$CLI_EXE \
    --sn chat \
    --op AdminChannelTopicInfo \
    --namespace $AB_NAMESPACE \
    --topic 'IHhsO2lO' \
    > test.out 2>&1
eval_tap $? 13 'AdminChannelTopicInfo' test.out

#- 14 AdminTopicChatHistory
eval_tap 0 14 'AdminTopicChatHistory # SKIP deprecated' test.out

#- 15 AdminSendChat
# body param: body
echo '{"message": "s7ToxMqv"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminSendChat \
    --namespace $AB_NAMESPACE \
    --topic 'ECS6qStD' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 15 'AdminSendChat' test.out

#- 16 AdminDeleteChat
$CLI_EXE \
    --sn chat \
    --op AdminDeleteChat \
    --chatId 'FFO4OCqM' \
    --namespace $AB_NAMESPACE \
    --topic '3OQBMAam' \
    > test.out 2>&1
eval_tap $? 16 'AdminDeleteChat' test.out

#- 17 AdminTopicMembers
$CLI_EXE \
    --sn chat \
    --op AdminTopicMembers \
    --namespace $AB_NAMESPACE \
    --topic 'mKQQXteF' \
    --isBanned 'true' \
    --isModerator 'false' \
    --limit '60' \
    --offset '24' \
    --shardId 'iwJozois' \
    > test.out 2>&1
eval_tap $? 17 'AdminTopicMembers' test.out

#- 18 AdminTopicShards
$CLI_EXE \
    --sn chat \
    --op AdminTopicShards \
    --namespace $AB_NAMESPACE \
    --topic 'upyjJWD3' \
    > test.out 2>&1
eval_tap $? 18 'AdminTopicShards' test.out

#- 19 AdminUnbanTopicMembers
# body param: body
echo '{"userIds": ["2Lb8JHL9", "cq4taQz6", "fOHHtpWy"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminUnbanTopicMembers \
    --namespace $AB_NAMESPACE \
    --topic 'lhRnPEJM' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 19 'AdminUnbanTopicMembers' test.out

#- 20 AdminAddTopicMember
# body param: body
echo '{"isAdmin": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminAddTopicMember \
    --namespace $AB_NAMESPACE \
    --topic 'rrZpupts' \
    --userId 'pxK3fsn3' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 20 'AdminAddTopicMember' test.out

#- 21 AdminRemoveTopicMember
$CLI_EXE \
    --sn chat \
    --op AdminRemoveTopicMember \
    --namespace $AB_NAMESPACE \
    --topic '8DRyBo3D' \
    --userId 'evWBcaVm' \
    > test.out 2>&1
eval_tap $? 21 'AdminRemoveTopicMember' test.out

#- 22 AdminQueryTopic
$CLI_EXE \
    --sn chat \
    --op AdminQueryTopic \
    --namespace $AB_NAMESPACE \
    --includeMembers 'true' \
    --includePastMembers 'true' \
    --includePastTopics 'true' \
    --limit '64' \
    --offset '94' \
    --topic '["RAICxkUY", "0mSPlcqW", "Wlg7whv8"]' \
    --topicSubType 'PARTY' \
    --topicType 'PERSONAL' \
    --userId 'OD2h9lIV' \
    > test.out 2>&1
eval_tap $? 22 'AdminQueryTopic' test.out

#- 23 AdminQueryUsersTopic
$CLI_EXE \
    --sn chat \
    --op AdminQueryUsersTopic \
    --namespace $AB_NAMESPACE \
    --userId 'UfxlDeLZ' \
    --includePastTopics 'false' \
    --limit '76' \
    --offset '81' \
    --topicSubType 'CLAN' \
    --topicType 'PERSONAL' \
    > test.out 2>&1
eval_tap $? 23 'AdminQueryUsersTopic' test.out

#- 24 PublicGetMutedTopics
$CLI_EXE \
    --sn chat \
    --op PublicGetMutedTopics \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 24 'PublicGetMutedTopics' test.out

#- 25 PublicTopicList
$CLI_EXE \
    --sn chat \
    --op PublicTopicList \
    --namespace $AB_NAMESPACE \
    --limit '70' \
    --offset '18' \
    --topicType '8ACXcawG' \
    > test.out 2>&1
eval_tap $? 25 'PublicTopicList' test.out

#- 26 PublicBanTopicMembers
# body param: body
echo '{"userIDs": ["l2pxRxcO", "i2VTTYdr", "YyyrxlT0"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op PublicBanTopicMembers \
    --namespace $AB_NAMESPACE \
    --topic '32DEdjgL' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 26 'PublicBanTopicMembers' test.out

#- 27 PublicChatHistory
$CLI_EXE \
    --sn chat \
    --op PublicChatHistory \
    --namespace $AB_NAMESPACE \
    --topic 'Uce2gIeU' \
    --limit '87' \
    --order 'l0ZJIlEZ' \
    --startCreatedAt '2' \
    > test.out 2>&1
eval_tap $? 27 'PublicChatHistory' test.out

#- 28 PublicDeleteChat
$CLI_EXE \
    --sn chat \
    --op PublicDeleteChat \
    --chatId '9hH9ssbA' \
    --namespace $AB_NAMESPACE \
    --topic 'BWwZfC7g' \
    > test.out 2>&1
eval_tap $? 28 'PublicDeleteChat' test.out

#- 29 PublicMuteUser
# body param: body
echo '{"duration": 52, "userId": "TuU0he0C"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op PublicMuteUser \
    --namespace $AB_NAMESPACE \
    --topic 'FCIHe5SJ' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 29 'PublicMuteUser' test.out

#- 30 PublicUnbanTopicMembers
# body param: body
echo '{"userIDs": ["fZBh0qT6", "fueJUZJb", "DgbOV8m4"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op PublicUnbanTopicMembers \
    --namespace $AB_NAMESPACE \
    --topic 'jcZsm5Tm' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 30 'PublicUnbanTopicMembers' test.out

#- 31 PublicUnmuteUser
# body param: body
echo '{"userId": "Y6IzujYB"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op PublicUnmuteUser \
    --namespace $AB_NAMESPACE \
    --topic 'Hm9GZcff' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 31 'PublicUnmuteUser' test.out

#- 32 AdminGetAllConfigV1
$CLI_EXE \
    --sn chat \
    --op AdminGetAllConfigV1 \
    > test.out 2>&1
eval_tap $? 32 'AdminGetAllConfigV1' test.out

#- 33 AdminGetLogConfig
$CLI_EXE \
    --sn chat \
    --op AdminGetLogConfig \
    > test.out 2>&1
eval_tap $? 33 'AdminGetLogConfig' test.out

#- 34 AdminPatchUpdateLogConfig
# body param: body
echo '{"logLevel": "panic", "logLevelDB": "debug", "slowQueryThreshold": 36, "socketLogEnabled": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminPatchUpdateLogConfig \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 34 'AdminPatchUpdateLogConfig' test.out

#- 35 AdminGetConfigV1
$CLI_EXE \
    --sn chat \
    --op AdminGetConfigV1 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 35 'AdminGetConfigV1' test.out

#- 36 AdminUpdateConfigV1
# body param: body
echo '{"chatRateLimitBurst": 87, "chatRateLimitDuration": 13, "concurrentUsersLimit": 74, "enableClanChat": false, "enableManualTopicCreation": false, "enableProfanityFilter": false, "filterAppName": "8ADHnXxH", "filterParam": "buwTUGcT", "filterType": "qeQA39gx", "generalRateLimitBurst": 76, "generalRateLimitDuration": 14, "maxChatMessageLength": 6, "shardCapacityLimit": 60, "shardDefaultLimit": 86, "shardHardLimit": 92, "spamChatBurst": 38, "spamChatDuration": 1, "spamMuteDuration": 7}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminUpdateConfigV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 36 'AdminUpdateConfigV1' test.out

#- 37 ExportConfig
$CLI_EXE \
    --sn chat \
    --op ExportConfig \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 37 'ExportConfig' test.out

#- 38 ImportConfig
# form data upload: file
echo 'tmp.dat' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --sn chat \
    --op ImportConfig \
    --namespace $AB_NAMESPACE \
    --upload file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 38 'ImportConfig' test.out

#- 39 AdminGetInboxCategories
$CLI_EXE \
    --sn chat \
    --op AdminGetInboxCategories \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 39 'AdminGetInboxCategories' test.out

#- 40 AdminAddInboxCategory
# body param: body
echo '{"enabled": false, "expiresIn": 32, "hook": {"driver": "cBOW8nWe", "params": {"eRYAd8Rk": {}, "xEyjIe9o": {}, "8jvlNbF9": {}}}, "jsonSchema": {"jextbtW6": {}, "ZG4ar2ZE": {}, "jQq8TINy": {}}, "name": "79jdcE5e", "saveInbox": true, "sendNotification": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminAddInboxCategory \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 40 'AdminAddInboxCategory' test.out

#- 41 AdminDeleteInboxCategory
$CLI_EXE \
    --sn chat \
    --op AdminDeleteInboxCategory \
    --category 'T9fuAVQp' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 41 'AdminDeleteInboxCategory' test.out

#- 42 AdminUpdateInboxCategory
# body param: body
echo '{"enabled": false, "expiresIn": 19, "hook": {"driver": "6yaUCWhZ", "params": {"LlinRoUF": {}, "oFOBLfRK": {}, "EXCCfNve": {}}}, "jsonSchema": {"AWtaXSi1": {}, "TVTwBMao": {}, "bXmsLZSK": {}}, "saveInbox": false, "sendNotification": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminUpdateInboxCategory \
    --category 'aGnzhl8A' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 42 'AdminUpdateInboxCategory' test.out

#- 43 AdminGetCategorySchema
$CLI_EXE \
    --sn chat \
    --op AdminGetCategorySchema \
    --category 'O0oIcSWR' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 43 'AdminGetCategorySchema' test.out

#- 44 AdminDeleteInboxMessage
$CLI_EXE \
    --sn chat \
    --op AdminDeleteInboxMessage \
    --messageId '1huf0ldX' \
    --namespace $AB_NAMESPACE \
    --force 'true' \
    > test.out 2>&1
eval_tap $? 44 'AdminDeleteInboxMessage' test.out

#- 45 AdminGetInboxMessages
$CLI_EXE \
    --sn chat \
    --op AdminGetInboxMessages \
    --namespace $AB_NAMESPACE \
    --activeOnly 'true' \
    --endCreatedAt '10' \
    --limit '88' \
    --messageId '["fwtgjOcW", "p6ppgMeb", "EYv6FM1u"]' \
    --offset '63' \
    --order 'LdTmJEZJ' \
    --scope 'NAMESPACE' \
    --startCreatedAt '45' \
    --status 'UNSENT' \
    --transient 'true' \
    > test.out 2>&1
eval_tap $? 45 'AdminGetInboxMessages' test.out

#- 46 AdminSaveInboxMessage
# body param: body
echo '{"category": "P4STQngE", "expiredAt": 57, "message": {"eWoHi6nl": {}, "zXM8g1bv": {}, "iFs0g0eW": {}}, "scope": "NAMESPACE", "status": "DRAFT", "userIds": ["Tjm4V4u6", "f1doba9i", "RXFaMHL1"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminSaveInboxMessage \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 46 'AdminSaveInboxMessage' test.out

#- 47 AdminUnsendInboxMessage
# body param: body
echo '{"userIds": ["9OmkhMux", "cl1FL6d6", "F1IELjBv"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminUnsendInboxMessage \
    --inbox 'FNkKqyME' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 47 'AdminUnsendInboxMessage' test.out

#- 48 AdminGetInboxUsers
$CLI_EXE \
    --sn chat \
    --op AdminGetInboxUsers \
    --inbox 'ql8IVEwm' \
    --namespace $AB_NAMESPACE \
    --limit '96' \
    --offset '52' \
    --status 'UNREAD' \
    --userId '98Y9hyeq' \
    > test.out 2>&1
eval_tap $? 48 'AdminGetInboxUsers' test.out

#- 49 AdminUpdateInboxMessage
# body param: body
echo '{"expiredAt": 64, "message": {"73rtQ7CP": {}, "VwJd66Un": {}, "TD9PGZgr": {}}, "scope": "NAMESPACE", "userIds": ["jkDtl4Uj", "Nw039Tx9", "R8IuX275"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminUpdateInboxMessage \
    --messageId 'e3WGFv93' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 49 'AdminUpdateInboxMessage' test.out

#- 50 AdminSendInboxMessage
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminSendInboxMessage \
    --messageId 'HHtFO00J' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 50 'AdminSendInboxMessage' test.out

#- 51 AdminGetInboxStats
$CLI_EXE \
    --sn chat \
    --op AdminGetInboxStats \
    --namespace $AB_NAMESPACE \
    --messageId '["QghTcBSQ", "QayRo0fY", "lHC4PNXV"]' \
    > test.out 2>&1
eval_tap $? 51 'AdminGetInboxStats' test.out

#- 52 AdminGetChatSnapshot
$CLI_EXE \
    --sn chat \
    --op AdminGetChatSnapshot \
    --chatId 'e5UeMYNP' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 52 'AdminGetChatSnapshot' test.out

#- 53 AdminDeleteChatSnapshot
$CLI_EXE \
    --sn chat \
    --op AdminDeleteChatSnapshot \
    --chatId 'UFG0kVNP' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 53 'AdminDeleteChatSnapshot' test.out

#- 54 AdminProfanityQuery
$CLI_EXE \
    --sn chat \
    --op AdminProfanityQuery \
    --namespace $AB_NAMESPACE \
    --filterMask 'Ra2U7zaS' \
    --includeChildren 'true' \
    --limit '51' \
    --offset '91' \
    --parentId 'uWdJpPxV' \
    --startWith 'OeGC0Owi' \
    --wordType 'r07HJEza' \
    > test.out 2>&1
eval_tap $? 54 'AdminProfanityQuery' test.out

#- 55 AdminProfanityCreate
# body param: body
echo '{"falseNegative": ["61lIgRJN", "QnWbC67i", "pAenRnuM"], "falsePositive": ["BfXPbD0b", "XftpavjM", "icGiJE39"], "word": "440tI4XE", "wordType": "sJlb2LmF"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminProfanityCreate \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 55 'AdminProfanityCreate' test.out

#- 56 AdminProfanityCreateBulk
# body param: body
echo '{"dictionaries": [{"falseNegative": ["GKLlVajp", "NFQohxwS", "TQt6L3Sn"], "falsePositive": ["NuAg6U0i", "jJFuM0qY", "hwnez7LI"], "word": "OtohTFgq", "wordType": "0VCw3qxu"}, {"falseNegative": ["RFnYedaS", "Rpyp7rCV", "aG9kSh5z"], "falsePositive": ["VNCK9jfm", "Id8hACaE", "n0q10JKQ"], "word": "8jkrleS8", "wordType": "0waWVa8M"}, {"falseNegative": ["hWxFgYaR", "ky3Prs5g", "AWuAiPXr"], "falsePositive": ["fAeadJCb", "6jWxruGi", "SK5a1GtK"], "word": "MA8EKLpR", "wordType": "i8gtwiDD"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminProfanityCreateBulk \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 56 'AdminProfanityCreateBulk' test.out

#- 57 AdminProfanityExport
$CLI_EXE \
    --sn chat \
    --op AdminProfanityExport \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 57 'AdminProfanityExport' test.out

#- 58 AdminProfanityGroup
$CLI_EXE \
    --sn chat \
    --op AdminProfanityGroup \
    --namespace $AB_NAMESPACE \
    --limit '87' \
    --offset '70' \
    > test.out 2>&1
eval_tap $? 58 'AdminProfanityGroup' test.out

#- 59 AdminProfanityImport
# form data upload: file
echo 'tmp.dat' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --sn chat \
    --op AdminProfanityImport \
    --namespace $AB_NAMESPACE \
    --action 'REPLACE' \
    --showResult 'false' \
    --upload file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 59 'AdminProfanityImport' test.out

#- 60 AdminProfanityUpdate
# body param: body
echo '{"falseNegative": ["jwF0e2Jc", "EKHa3LQ2", "n0YC5o1K"], "falsePositive": ["LrH27MeZ", "6g7W6ZR4", "PWhb7aus"], "word": "R2hbn97O", "wordType": "td4UfWNd"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminProfanityUpdate \
    --id 't4cSOa2u' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 60 'AdminProfanityUpdate' test.out

#- 61 AdminProfanityDelete
$CLI_EXE \
    --sn chat \
    --op AdminProfanityDelete \
    --id 'TX1lM5N9' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 61 'AdminProfanityDelete' test.out

#- 62 PublicGetMessages
$CLI_EXE \
    --sn chat \
    --op PublicGetMessages \
    > test.out 2>&1
eval_tap $? 62 'PublicGetMessages' test.out

#- 63 PublicGetConfigV1
$CLI_EXE \
    --sn chat \
    --op PublicGetConfigV1 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 63 'PublicGetConfigV1' test.out

#- 64 PublicGetChatSnapshot
$CLI_EXE \
    --sn chat \
    --op PublicGetChatSnapshot \
    --chatId 'vg0fhWYP' \
    --namespace $AB_NAMESPACE \
    --topic 'uyEuRCKU' \
    > test.out 2>&1
eval_tap $? 64 'PublicGetChatSnapshot' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE