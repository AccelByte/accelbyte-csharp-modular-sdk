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
echo "1..60"

#- 1 Login
$CLI_EXE --op login --lt user --user user --pass user > test.out 2>&1
eval_tap $? 1 'Login' test.out

if [ $EXIT_CODE -ne 0 ]; then
  echo "Bail out! Login failed."
  exit $EXIT_CODE
fi

# echo "foo" > "$CLI_TOKEN_FILE"

#- 2 AdminChatHistory
$CLI_EXE \
    --sn chat \
    --op AdminChatHistory \
    --namespace $AB_NAMESPACE \
    --chatId '["ZiUunacP", "VkeRdaY0", "y3vyU0Pe"]' \
    --endCreatedAt '88' \
    --keyword 'WawTtNIS' \
    --limit '39' \
    --offset '51' \
    --order 'zPSUkicG' \
    --senderUserId 'GG10A8hb' \
    --shardId '85Xan7PF' \
    --startCreatedAt '98' \
    --topic '["CK98Qe57", "4m4KxlyP", "qkqKK6RB"]' \
    > test.out 2>&1
eval_tap $? 2 'AdminChatHistory' test.out

#- 3 AdminCreateNamespaceTopic
# body param: body
echo '{"description": "LxaKn1Lh", "name": "3jJOP1TY"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminCreateNamespaceTopic \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 3 'AdminCreateNamespaceTopic' test.out

#- 4 AdminTopicList
$CLI_EXE \
    --sn chat \
    --op AdminTopicList \
    --namespace $AB_NAMESPACE \
    --limit '3' \
    --offset '88' \
    --topicType 'vwc3QaU9' \
    > test.out 2>&1
eval_tap $? 4 'AdminTopicList' test.out

#- 5 AdminCreateTopic
# body param: body
echo '{"admins": ["31HUqUAe", "Hwqka6E9", "X1u2g72E"], "description": "DDCGkijY", "isChannel": true, "isJoinable": true, "members": ["0sK1tNPW", "pXOgNcgC", "ckzrfgFz"], "name": "ykTUbeOk", "shardLimit": 73, "type": "wIBiIlUb"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminCreateTopic \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 5 'AdminCreateTopic' test.out

#- 6 AdminChannelTopicList
$CLI_EXE \
    --sn chat \
    --op AdminChannelTopicList \
    --namespace $AB_NAMESPACE \
    --limit '75' \
    --offset '43' \
    --topicName 'RHPhQKgD' \
    > test.out 2>&1
eval_tap $? 6 'AdminChannelTopicList' test.out

#- 7 AdminChannelTopicSummary
$CLI_EXE \
    --sn chat \
    --op AdminChannelTopicSummary \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 7 'AdminChannelTopicSummary' test.out

#- 8 AdminQueryTopicLog
$CLI_EXE \
    --sn chat \
    --op AdminQueryTopicLog \
    --namespace $AB_NAMESPACE \
    --endCreatedAt '89' \
    --limit '29' \
    --offset '0' \
    --senderUserId 'mSRLFnTl' \
    --startCreatedAt '11' \
    --topicId '0Wf8Pamv' \
    --topicIds '["1VBmESue", "uuPzmUoE", "eRlG8iON"]' \
    --userId '5q1o7xCq' \
    > test.out 2>&1
eval_tap $? 8 'AdminQueryTopicLog' test.out

#- 9 AdminUpdateTopic
# body param: body
echo '{"description": "nExFnuvj", "isJoinable": true, "name": "EsJXza4Q"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminUpdateTopic \
    --namespace $AB_NAMESPACE \
    --topic 'SvqWy43q' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 9 'AdminUpdateTopic' test.out

#- 10 AdminDeleteTopic
$CLI_EXE \
    --sn chat \
    --op AdminDeleteTopic \
    --namespace $AB_NAMESPACE \
    --topic 'wMUuG0Uk' \
    > test.out 2>&1
eval_tap $? 10 'AdminDeleteTopic' test.out

#- 11 AdminBanTopicMembers
# body param: body
echo '{"userIds": ["E5uiP3wt", "gBoq5D2N", "9TOYxmyR"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminBanTopicMembers \
    --namespace $AB_NAMESPACE \
    --topic 'mPgrGUag' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 11 'AdminBanTopicMembers' test.out

#- 12 AdminChannelTopicInfo
$CLI_EXE \
    --sn chat \
    --op AdminChannelTopicInfo \
    --namespace $AB_NAMESPACE \
    --topic 'PkzvDFAG' \
    > test.out 2>&1
eval_tap $? 12 'AdminChannelTopicInfo' test.out

#- 13 AdminTopicChatHistory
eval_tap 0 13 'AdminTopicChatHistory # SKIP deprecated' test.out

#- 14 AdminSendChat
# body param: body
echo '{"message": "SPwK1rar"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminSendChat \
    --namespace $AB_NAMESPACE \
    --topic 'eVFuZg8l' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 14 'AdminSendChat' test.out

#- 15 AdminDeleteChat
$CLI_EXE \
    --sn chat \
    --op AdminDeleteChat \
    --chatId 'OBNcywCd' \
    --namespace $AB_NAMESPACE \
    --topic 'ZTANHEOv' \
    > test.out 2>&1
eval_tap $? 15 'AdminDeleteChat' test.out

#- 16 AdminTopicMembers
$CLI_EXE \
    --sn chat \
    --op AdminTopicMembers \
    --namespace $AB_NAMESPACE \
    --topic 'XTcvazDY' \
    --isBanned 'true' \
    --isModerator 'false' \
    --limit '57' \
    --offset '72' \
    --shardId 'NUM2bmu1' \
    > test.out 2>&1
eval_tap $? 16 'AdminTopicMembers' test.out

#- 17 AdminTopicShards
$CLI_EXE \
    --sn chat \
    --op AdminTopicShards \
    --namespace $AB_NAMESPACE \
    --topic 'UPhWRUR0' \
    > test.out 2>&1
eval_tap $? 17 'AdminTopicShards' test.out

#- 18 AdminUnbanTopicMembers
# body param: body
echo '{"userIds": ["gdzTBMJJ", "ZLsMmb9m", "Hw4erKDg"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminUnbanTopicMembers \
    --namespace $AB_NAMESPACE \
    --topic '0peNiCSG' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 18 'AdminUnbanTopicMembers' test.out

#- 19 AdminAddTopicMember
# body param: body
echo '{"isAdmin": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminAddTopicMember \
    --namespace $AB_NAMESPACE \
    --topic 'NRCybPPj' \
    --userId '278REIwM' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 19 'AdminAddTopicMember' test.out

#- 20 AdminRemoveTopicMember
$CLI_EXE \
    --sn chat \
    --op AdminRemoveTopicMember \
    --namespace $AB_NAMESPACE \
    --topic 'GZE6BNHa' \
    --userId 'flNXAJVv' \
    > test.out 2>&1
eval_tap $? 20 'AdminRemoveTopicMember' test.out

#- 21 AdminQueryTopic
$CLI_EXE \
    --sn chat \
    --op AdminQueryTopic \
    --namespace $AB_NAMESPACE \
    --includeMembers 'true' \
    --includePastMembers 'false' \
    --includePastTopics 'false' \
    --limit '83' \
    --offset '58' \
    --topic '["HBCvYUvW", "PAG53ByI", "Vl6h1FKo"]' \
    --topicSubType 'SESSION' \
    --topicType 'PERSONAL' \
    --userId 'UhCwvVeD' \
    > test.out 2>&1
eval_tap $? 21 'AdminQueryTopic' test.out

#- 22 AdminQueryUsersTopic
$CLI_EXE \
    --sn chat \
    --op AdminQueryUsersTopic \
    --namespace $AB_NAMESPACE \
    --userId 'bEfH05M8' \
    --includePastTopics 'true' \
    --limit '42' \
    --offset '2' \
    --topicSubType 'CLAN' \
    --topicType 'GROUP' \
    > test.out 2>&1
eval_tap $? 22 'AdminQueryUsersTopic' test.out

#- 23 PublicGetMutedTopics
$CLI_EXE \
    --sn chat \
    --op PublicGetMutedTopics \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 23 'PublicGetMutedTopics' test.out

#- 24 PublicTopicList
$CLI_EXE \
    --sn chat \
    --op PublicTopicList \
    --namespace $AB_NAMESPACE \
    --limit '51' \
    --offset '98' \
    --topicType 'JdpFkN2e' \
    > test.out 2>&1
eval_tap $? 24 'PublicTopicList' test.out

#- 25 PublicBanTopicMembers
# body param: body
echo '{"userIDs": ["trE4f4GB", "BJjve8ob", "oagZkWa7"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op PublicBanTopicMembers \
    --namespace $AB_NAMESPACE \
    --topic 'aUCirPeg' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 25 'PublicBanTopicMembers' test.out

#- 26 PublicChatHistory
$CLI_EXE \
    --sn chat \
    --op PublicChatHistory \
    --namespace $AB_NAMESPACE \
    --topic 'QDqVjDDp' \
    --limit '78' \
    --order 'vo8uB3EX' \
    --startCreatedAt '79' \
    > test.out 2>&1
eval_tap $? 26 'PublicChatHistory' test.out

#- 27 PublicDeleteChat
$CLI_EXE \
    --sn chat \
    --op PublicDeleteChat \
    --chatId 'Rmm1bHHH' \
    --namespace $AB_NAMESPACE \
    --topic 'dAfCCpAO' \
    > test.out 2>&1
eval_tap $? 27 'PublicDeleteChat' test.out

#- 28 PublicMuteUser
# body param: body
echo '{"duration": 63, "userId": "QWQiGXmn"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op PublicMuteUser \
    --namespace $AB_NAMESPACE \
    --topic 'Xg9xcaAX' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 28 'PublicMuteUser' test.out

#- 29 PublicUnbanTopicMembers
# body param: body
echo '{"userIDs": ["yOevVaQE", "Hvgz5xZ5", "ddwh4KJf"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op PublicUnbanTopicMembers \
    --namespace $AB_NAMESPACE \
    --topic 'THaAa2Ja' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 29 'PublicUnbanTopicMembers' test.out

#- 30 PublicUnmuteUser
# body param: body
echo '{"userId": "rK6HKe92"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op PublicUnmuteUser \
    --namespace $AB_NAMESPACE \
    --topic 'Nr1t3hBh' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 30 'PublicUnmuteUser' test.out

#- 31 AdminGetAllConfigV1
$CLI_EXE \
    --sn chat \
    --op AdminGetAllConfigV1 \
    > test.out 2>&1
eval_tap $? 31 'AdminGetAllConfigV1' test.out

#- 32 AdminGetConfigV1
$CLI_EXE \
    --sn chat \
    --op AdminGetConfigV1 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 32 'AdminGetConfigV1' test.out

#- 33 AdminUpdateConfigV1
# body param: body
echo '{"chatRateLimitBurst": 92, "chatRateLimitDuration": 96, "concurrentUsersLimit": 16, "enableClanChat": false, "enableManualTopicCreation": true, "enableProfanityFilter": false, "filterAppName": "zcekDBX4", "filterParam": "x3lVRa1B", "filterType": "8OJUgF9V", "generalRateLimitBurst": 55, "generalRateLimitDuration": 93, "shardCapacityLimit": 1, "shardDefaultLimit": 39, "shardHardLimit": 72, "spamChatBurst": 75, "spamChatDuration": 78, "spamMuteDuration": 62}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminUpdateConfigV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 33 'AdminUpdateConfigV1' test.out

#- 34 ExportConfig
$CLI_EXE \
    --sn chat \
    --op ExportConfig \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 34 'ExportConfig' test.out

#- 35 ImportConfig
# form data upload: file
echo 'tmp.dat' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --sn chat \
    --op ImportConfig \
    --namespace $AB_NAMESPACE \
    --upload file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 35 'ImportConfig' test.out

#- 36 AdminGetInboxCategories
$CLI_EXE \
    --sn chat \
    --op AdminGetInboxCategories \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 36 'AdminGetInboxCategories' test.out

#- 37 AdminAddInboxCategory
# body param: body
echo '{"enabled": true, "expiresIn": 48, "hook": {"driver": "KAFKA", "params": "rl29lpO3"}, "jsonSchema": {"kAESELDI": {}, "MN09lKG7": {}, "kY59UKJA": {}}, "name": "JFJ1vZyE", "saveInbox": true, "sendNotification": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminAddInboxCategory \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 37 'AdminAddInboxCategory' test.out

#- 38 AdminDeleteInboxCategory
$CLI_EXE \
    --sn chat \
    --op AdminDeleteInboxCategory \
    --category 'yiY2OXGP' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 38 'AdminDeleteInboxCategory' test.out

#- 39 AdminUpdateInboxCategory
# body param: body
echo '{"enabled": true, "expiresIn": 23, "hook": {"driver": "KAFKA", "params": "glMKohaW"}, "jsonSchema": {"FVZ3svPO": {}, "CDNnlYA5": {}, "CDzCm71x": {}}, "saveInbox": true, "sendNotification": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminUpdateInboxCategory \
    --category 'HFcWMrXU' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 39 'AdminUpdateInboxCategory' test.out

#- 40 AdminGetCategorySchema
$CLI_EXE \
    --sn chat \
    --op AdminGetCategorySchema \
    --category 'ebz7Jy82' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 40 'AdminGetCategorySchema' test.out

#- 41 AdminDeleteInboxMessage
$CLI_EXE \
    --sn chat \
    --op AdminDeleteInboxMessage \
    --messageId 'zfIBJx9V' \
    --namespace $AB_NAMESPACE \
    --force 'false' \
    > test.out 2>&1
eval_tap $? 41 'AdminDeleteInboxMessage' test.out

#- 42 AdminGetInboxMessages
$CLI_EXE \
    --sn chat \
    --op AdminGetInboxMessages \
    --namespace $AB_NAMESPACE \
    --activeOnly 'false' \
    --endCreatedAt '37' \
    --limit '8' \
    --messageId '["d0Eyu78n", "xj3Jc79Z", "bM6PUNp0"]' \
    --offset '42' \
    --order 'X9gPp4LH' \
    --scope 'NAMESPACE' \
    --startCreatedAt '38' \
    --status 'SENT' \
    --transient 'true' \
    > test.out 2>&1
eval_tap $? 42 'AdminGetInboxMessages' test.out

#- 43 AdminSaveInboxMessage
# body param: body
echo '{"category": "RqljP2iL", "expiredAt": 31, "message": {"KZG2ijx7": {}, "v9VThW6S": {}, "cwGyDr5N": {}}, "scope": "USER", "status": "DRAFT", "userIds": ["HxYuT4oS", "TEMbqfsy", "dzux9yyI"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminSaveInboxMessage \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 43 'AdminSaveInboxMessage' test.out

#- 44 AdminUnsendInboxMessage
# body param: body
echo '{"userIds": ["BlMwT1pK", "zZZzzDR1", "XtgEiyZ5"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminUnsendInboxMessage \
    --inbox 'fKmrOrXr' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 44 'AdminUnsendInboxMessage' test.out

#- 45 AdminGetInboxUsers
$CLI_EXE \
    --sn chat \
    --op AdminGetInboxUsers \
    --inbox 'gSasixbG' \
    --namespace $AB_NAMESPACE \
    --limit '61' \
    --offset '56' \
    --status 'UNREAD' \
    --userId 'skTkpd32' \
    > test.out 2>&1
eval_tap $? 45 'AdminGetInboxUsers' test.out

#- 46 AdminUpdateInboxMessage
# body param: body
echo '{"expiredAt": 27, "message": {"K91c2egt": {}, "HeUMTtnH": {}, "HXmPGwVh": {}}, "scope": "NAMESPACE", "userIds": ["IjylTvAM", "awWMjlJs", "geFYEnZq"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminUpdateInboxMessage \
    --messageId '9RFPUr0e' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 46 'AdminUpdateInboxMessage' test.out

#- 47 AdminSendInboxMessage
# body param: body
echo '{}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminSendInboxMessage \
    --messageId 'uRVawlfs' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 47 'AdminSendInboxMessage' test.out

#- 48 AdminGetInboxStats
$CLI_EXE \
    --sn chat \
    --op AdminGetInboxStats \
    --namespace $AB_NAMESPACE \
    --messageId '["oJkecSzF", "2iKZax5C", "vk8CQHNT"]' \
    > test.out 2>&1
eval_tap $? 48 'AdminGetInboxStats' test.out

#- 49 AdminGetChatSnapshot
$CLI_EXE \
    --sn chat \
    --op AdminGetChatSnapshot \
    --chatId '8ObNlVVy' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 49 'AdminGetChatSnapshot' test.out

#- 50 AdminDeleteChatSnapshot
$CLI_EXE \
    --sn chat \
    --op AdminDeleteChatSnapshot \
    --chatId 'bVPxmxJo' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 50 'AdminDeleteChatSnapshot' test.out

#- 51 AdminProfanityQuery
$CLI_EXE \
    --sn chat \
    --op AdminProfanityQuery \
    --namespace $AB_NAMESPACE \
    --filterMask 'wqtCCKAk' \
    --includeChildren 'true' \
    --limit '57' \
    --offset '90' \
    --parentId '7v8idtBs' \
    --startWith 'U7oTe0xN' \
    --wordType 'A2UqNPAQ' \
    > test.out 2>&1
eval_tap $? 51 'AdminProfanityQuery' test.out

#- 52 AdminProfanityCreate
# body param: body
echo '{"falseNegative": ["9EDdKPZ6", "26fMfdJV", "UElu7NUI"], "falsePositive": ["doiFEV5S", "WXP6ZSqL", "NsLtVb2s"], "word": "dNwz5UNZ", "wordType": "CrVOjQqR"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminProfanityCreate \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 52 'AdminProfanityCreate' test.out

#- 53 AdminProfanityCreateBulk
# body param: body
echo '{"dictionaries": [{"falseNegative": ["LtKLTXbO", "xeHYkShQ", "Le5ToU36"], "falsePositive": ["RTzbRCOF", "aTfwWEl5", "GEMtBZxE"], "word": "sUDKfaUS", "wordType": "NJf0ldHI"}, {"falseNegative": ["9jtYnTBM", "SDK2SUYE", "2AMfLBNv"], "falsePositive": ["PuVQp78Y", "drUYR3aH", "JrWSdDHt"], "word": "lDp7Nbbo", "wordType": "nPp8Zfy3"}, {"falseNegative": ["56G0M3FC", "X5W69tJ9", "IDliawju"], "falsePositive": ["IL9dqnFl", "S0h4wn4M", "oJjdrA4y"], "word": "3cIDa5h1", "wordType": "d6ArYgLz"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminProfanityCreateBulk \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 53 'AdminProfanityCreateBulk' test.out

#- 54 AdminProfanityExport
$CLI_EXE \
    --sn chat \
    --op AdminProfanityExport \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 54 'AdminProfanityExport' test.out

#- 55 AdminProfanityGroup
$CLI_EXE \
    --sn chat \
    --op AdminProfanityGroup \
    --namespace $AB_NAMESPACE \
    --limit '50' \
    --offset '95' \
    > test.out 2>&1
eval_tap $? 55 'AdminProfanityGroup' test.out

#- 56 AdminProfanityImport
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
eval_tap $? 56 'AdminProfanityImport' test.out

#- 57 AdminProfanityUpdate
# body param: body
echo '{"falseNegative": ["bMJm6Ucx", "Uo5jTevw", "h4UmyeFw"], "falsePositive": ["kMuJXfIX", "TOAhgXHI", "sBvtCVvb"], "word": "UyaGWSmC", "wordType": "CgwH70Aw"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminProfanityUpdate \
    --id 'RwGCJtBE' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 57 'AdminProfanityUpdate' test.out

#- 58 AdminProfanityDelete
$CLI_EXE \
    --sn chat \
    --op AdminProfanityDelete \
    --id 'fHKCf1bo' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 58 'AdminProfanityDelete' test.out

#- 59 PublicGetMessages
$CLI_EXE \
    --sn chat \
    --op PublicGetMessages \
    > test.out 2>&1
eval_tap $? 59 'PublicGetMessages' test.out

#- 60 PublicGetChatSnapshot
$CLI_EXE \
    --sn chat \
    --op PublicGetChatSnapshot \
    --chatId 'AR2fAYGa' \
    --namespace $AB_NAMESPACE \
    --topic '1cQt9T8o' \
    > test.out 2>&1
eval_tap $? 60 'PublicGetChatSnapshot' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE