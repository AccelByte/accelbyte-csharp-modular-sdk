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
    --chatId '["7tPkuQuO", "8OmVLPEO", "97pd4gp9"]' \
    --endCreatedAt '37' \
    --keyword 'cCuUImU7' \
    --limit '28' \
    --offset '82' \
    --order 'HEzV9Xya' \
    --senderUserId 'sI3qij4N' \
    --shardId '7ISZDFLy' \
    --startCreatedAt '11' \
    --topic '["YMh2stnw", "NuxHyW6J", "hJfCZLlB"]' \
    > test.out 2>&1
eval_tap $? 2 'AdminChatHistory' test.out

#- 3 AdminCreateNamespaceTopic
# body param: body
echo '{"description": "wPaV9Ggb", "name": "QgK5bflX"}' > $TEMP_JSON_INPUT
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
    --offset '83' \
    --topicType 'o2F2DojC' \
    > test.out 2>&1
eval_tap $? 4 'AdminTopicList' test.out

#- 5 AdminCreateTopic
# body param: body
echo '{"admins": ["FZpHy46P", "hNU7ZjN9", "lqAPZ6Ht"], "description": "pOwZthV0", "isChannel": false, "isJoinable": true, "members": ["wn8ehzVK", "viSRTIZC", "QWxfVAYf"], "name": "KicCCfv5", "shardLimit": 45, "type": "9biCLGve"}' > $TEMP_JSON_INPUT
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
    --limit '26' \
    --offset '93' \
    --topicName 'mjyGp9dU' \
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
    --endCreatedAt '8' \
    --limit '83' \
    --offset '34' \
    --senderUserId 'wtkbzdVF' \
    --startCreatedAt '94' \
    --topicId 'mcP282Ug' \
    --topicIds '["6zA3YlLh", "p4LCVrnb", "l0YluCeC"]' \
    --userId 'LzVd051P' \
    > test.out 2>&1
eval_tap $? 8 'AdminQueryTopicLog' test.out

#- 9 AdminUpdateTopic
# body param: body
echo '{"description": "fs8Rbaw4", "isJoinable": true, "name": "bxtflQ3m"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminUpdateTopic \
    --namespace $AB_NAMESPACE \
    --topic 'dJ66YfVV' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 9 'AdminUpdateTopic' test.out

#- 10 AdminDeleteTopic
$CLI_EXE \
    --sn chat \
    --op AdminDeleteTopic \
    --namespace $AB_NAMESPACE \
    --topic 'B2SnApxB' \
    > test.out 2>&1
eval_tap $? 10 'AdminDeleteTopic' test.out

#- 11 AdminBanTopicMembers
# body param: body
echo '{"userIds": ["hfuNtWTV", "NNLL3fr6", "ORHwTI0X"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminBanTopicMembers \
    --namespace $AB_NAMESPACE \
    --topic 'WuTyXOqG' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 11 'AdminBanTopicMembers' test.out

#- 12 AdminChannelTopicInfo
$CLI_EXE \
    --sn chat \
    --op AdminChannelTopicInfo \
    --namespace $AB_NAMESPACE \
    --topic 'gj6weBJu' \
    > test.out 2>&1
eval_tap $? 12 'AdminChannelTopicInfo' test.out

#- 13 AdminTopicChatHistory
eval_tap 0 13 'AdminTopicChatHistory # SKIP deprecated' test.out

#- 14 AdminSendChat
# body param: body
echo '{"message": "mUJi1Kjj"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminSendChat \
    --namespace $AB_NAMESPACE \
    --topic 'MjmGqxcl' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 14 'AdminSendChat' test.out

#- 15 AdminDeleteChat
$CLI_EXE \
    --sn chat \
    --op AdminDeleteChat \
    --chatId 'b6v5B40k' \
    --namespace $AB_NAMESPACE \
    --topic 'CVa7kqLy' \
    > test.out 2>&1
eval_tap $? 15 'AdminDeleteChat' test.out

#- 16 AdminTopicMembers
$CLI_EXE \
    --sn chat \
    --op AdminTopicMembers \
    --namespace $AB_NAMESPACE \
    --topic 'bwgPMgVY' \
    --isBanned 'false' \
    --isModerator 'true' \
    --limit '24' \
    --offset '41' \
    --shardId 'qhVPzEST' \
    > test.out 2>&1
eval_tap $? 16 'AdminTopicMembers' test.out

#- 17 AdminTopicShards
$CLI_EXE \
    --sn chat \
    --op AdminTopicShards \
    --namespace $AB_NAMESPACE \
    --topic '4WMMLCZH' \
    > test.out 2>&1
eval_tap $? 17 'AdminTopicShards' test.out

#- 18 AdminUnbanTopicMembers
# body param: body
echo '{"userIds": ["ln8bLeUD", "OxHmYkRQ", "6x9vIrem"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminUnbanTopicMembers \
    --namespace $AB_NAMESPACE \
    --topic 'T0jBuWRQ' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 18 'AdminUnbanTopicMembers' test.out

#- 19 AdminAddTopicMember
# body param: body
echo '{"isAdmin": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminAddTopicMember \
    --namespace $AB_NAMESPACE \
    --topic 'nnlWyYR0' \
    --userId '5OxVoQ1x' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 19 'AdminAddTopicMember' test.out

#- 20 AdminRemoveTopicMember
$CLI_EXE \
    --sn chat \
    --op AdminRemoveTopicMember \
    --namespace $AB_NAMESPACE \
    --topic 'Sx1xbZcM' \
    --userId 'LMJOmdag' \
    > test.out 2>&1
eval_tap $? 20 'AdminRemoveTopicMember' test.out

#- 21 AdminQueryTopic
$CLI_EXE \
    --sn chat \
    --op AdminQueryTopic \
    --namespace $AB_NAMESPACE \
    --includeMembers 'true' \
    --includePastMembers 'false' \
    --includePastTopics 'true' \
    --limit '76' \
    --offset '20' \
    --topic '["9h90oP53", "zNVJeIyh", "THWqkpfb"]' \
    --topicSubType 'CLAN' \
    --topicType 'PERSONAL' \
    --userId 'EoOncvvy' \
    > test.out 2>&1
eval_tap $? 21 'AdminQueryTopic' test.out

#- 22 AdminQueryUsersTopic
$CLI_EXE \
    --sn chat \
    --op AdminQueryUsersTopic \
    --namespace $AB_NAMESPACE \
    --userId 'LDR0HXNe' \
    --includePastTopics 'false' \
    --limit '95' \
    --offset '37' \
    --topicSubType 'SESSION' \
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
    --limit '89' \
    --offset '19' \
    --topicType 'KYpQu5c0' \
    > test.out 2>&1
eval_tap $? 24 'PublicTopicList' test.out

#- 25 PublicBanTopicMembers
# body param: body
echo '{"userIDs": ["Oz7ZMBYI", "e3z8c6y4", "Eh87mWAh"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op PublicBanTopicMembers \
    --namespace $AB_NAMESPACE \
    --topic 'RmMyVaU2' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 25 'PublicBanTopicMembers' test.out

#- 26 PublicChatHistory
$CLI_EXE \
    --sn chat \
    --op PublicChatHistory \
    --namespace $AB_NAMESPACE \
    --topic '8ulyuvay' \
    --limit '86' \
    --order 'SK49izLn' \
    --startCreatedAt '85' \
    > test.out 2>&1
eval_tap $? 26 'PublicChatHistory' test.out

#- 27 PublicDeleteChat
$CLI_EXE \
    --sn chat \
    --op PublicDeleteChat \
    --chatId 'Sz35eRE2' \
    --namespace $AB_NAMESPACE \
    --topic 'TT0kcbkT' \
    > test.out 2>&1
eval_tap $? 27 'PublicDeleteChat' test.out

#- 28 PublicMuteUser
# body param: body
echo '{"duration": 79, "userId": "IpW1Qqje"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op PublicMuteUser \
    --namespace $AB_NAMESPACE \
    --topic 'SAqAGjvs' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 28 'PublicMuteUser' test.out

#- 29 PublicUnbanTopicMembers
# body param: body
echo '{"userIDs": ["DNRdQ20s", "2AlfFe5S", "lxVbnOCS"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op PublicUnbanTopicMembers \
    --namespace $AB_NAMESPACE \
    --topic 'XDUMJIBh' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 29 'PublicUnbanTopicMembers' test.out

#- 30 PublicUnmuteUser
# body param: body
echo '{"userId": "fB118UUc"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op PublicUnmuteUser \
    --namespace $AB_NAMESPACE \
    --topic 'l00vn33p' \
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
echo '{"chatRateLimitBurst": 30, "chatRateLimitDuration": 70, "concurrentUsersLimit": 94, "enableClanChat": true, "enableManualTopicCreation": true, "enableProfanityFilter": false, "filterAppName": "g6XfB1f7", "filterParam": "WWkqxgHy", "filterType": "A1ILIrqv", "generalRateLimitBurst": 39, "generalRateLimitDuration": 58, "shardCapacityLimit": 21, "shardDefaultLimit": 23, "shardHardLimit": 76, "spamChatBurst": 28, "spamChatDuration": 30, "spamMuteDuration": 53}' > $TEMP_JSON_INPUT
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
    --upload $TEMP_FILE_UPLOAD \
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
echo '{"enabled": false, "expiresIn": 1, "hook": {"driver": "KAFKA", "params": "bpVGhEVf"}, "jsonSchema": {"cDCE74fg": {}, "mkhTCtf6": {}, "8uG1LwPH": {}}, "name": "oAi1EXxH", "saveInbox": false, "sendNotification": false}' > $TEMP_JSON_INPUT
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
    --category '0xaA9U9y' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 38 'AdminDeleteInboxCategory' test.out

#- 39 AdminUpdateInboxCategory
# body param: body
echo '{"enabled": true, "expiresIn": 77, "hook": {"driver": "KAFKA", "params": "LlVC57vN"}, "jsonSchema": {"zsLJGyaC": {}, "XkjVmzMJ": {}, "6TAbOPc5": {}}, "saveInbox": true, "sendNotification": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminUpdateInboxCategory \
    --category 'xPbAFp8E' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 39 'AdminUpdateInboxCategory' test.out

#- 40 AdminGetCategorySchema
$CLI_EXE \
    --sn chat \
    --op AdminGetCategorySchema \
    --category 'LyRdprqI' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 40 'AdminGetCategorySchema' test.out

#- 41 AdminDeleteInboxMessage
$CLI_EXE \
    --sn chat \
    --op AdminDeleteInboxMessage \
    --messageId 'Juo7AvKA' \
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
    --endCreatedAt '92' \
    --limit '68' \
    --messageId '["e95gqJfc", "OjbK4R1X", "nKvHQpKY"]' \
    --offset '80' \
    --order 'olXgqtXn' \
    --scope 'USER' \
    --startCreatedAt '58' \
    --status 'DRAFT' \
    --transient 'false' \
    > test.out 2>&1
eval_tap $? 42 'AdminGetInboxMessages' test.out

#- 43 AdminSaveInboxMessage
# body param: body
echo '{"category": "UNmNedXu", "expiredAt": 55, "message": {"hMyFQWlV": {}, "ZuPHHbUB": {}, "QiP6BuXT": {}}, "scope": "NAMESPACE", "status": "SENT", "userIds": ["a7BPXoSl", "9tg0ZgMd", "FbxuhSEa"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminSaveInboxMessage \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 43 'AdminSaveInboxMessage' test.out

#- 44 AdminUnsendInboxMessage
# body param: body
echo '{"userIds": ["VDGjqKl7", "0VbqUTaQ", "g8MBleQ1"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminUnsendInboxMessage \
    --inbox 'xoPUHYDa' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 44 'AdminUnsendInboxMessage' test.out

#- 45 AdminGetInboxUsers
$CLI_EXE \
    --sn chat \
    --op AdminGetInboxUsers \
    --inbox 'Cicqmmj3' \
    --namespace $AB_NAMESPACE \
    --limit '52' \
    --offset '15' \
    --status 'UNREAD' \
    --userId 'AC5Jrv53' \
    > test.out 2>&1
eval_tap $? 45 'AdminGetInboxUsers' test.out

#- 46 AdminUpdateInboxMessage
# body param: body
echo '{"expiredAt": 30, "message": {"ivKQxsSM": {}, "qBU4IEgW": {}, "CPjq91Pr": {}}, "scope": "NAMESPACE", "userIds": ["uTbjaGvd", "shk4yFw0", "KadP7AiQ"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminUpdateInboxMessage \
    --messageId 'JrFOo7EN' \
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
    --messageId '0BLOOTbR' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 47 'AdminSendInboxMessage' test.out

#- 48 AdminGetInboxStats
$CLI_EXE \
    --sn chat \
    --op AdminGetInboxStats \
    --namespace $AB_NAMESPACE \
    --messageId '["isvuAsPD", "1DCN7IzO", "K91cvksw"]' \
    > test.out 2>&1
eval_tap $? 48 'AdminGetInboxStats' test.out

#- 49 AdminGetChatSnapshot
$CLI_EXE \
    --sn chat \
    --op AdminGetChatSnapshot \
    --chatId 'f2aTPzjT' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 49 'AdminGetChatSnapshot' test.out

#- 50 AdminDeleteChatSnapshot
$CLI_EXE \
    --sn chat \
    --op AdminDeleteChatSnapshot \
    --chatId 'XQOgkOUw' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 50 'AdminDeleteChatSnapshot' test.out

#- 51 AdminProfanityQuery
$CLI_EXE \
    --sn chat \
    --op AdminProfanityQuery \
    --namespace $AB_NAMESPACE \
    --filterMask 'RrComBLO' \
    --includeChildren 'true' \
    --limit '22' \
    --offset '94' \
    --parentId 'u3sOgkU5' \
    --startWith 'd96TnIWG' \
    --wordType '63J53lxd' \
    > test.out 2>&1
eval_tap $? 51 'AdminProfanityQuery' test.out

#- 52 AdminProfanityCreate
# body param: body
echo '{"falseNegative": ["8xyToA49", "WlFIw4Uy", "25hVDaxS"], "falsePositive": ["0xdeUwKl", "3rL7QDIK", "XwXLG7mX"], "word": "SzBayw7k", "wordType": "fYFTB1c4"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminProfanityCreate \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 52 'AdminProfanityCreate' test.out

#- 53 AdminProfanityCreateBulk
# body param: body
echo '{"dictionaries": [{"falseNegative": ["VbrtFify", "0ilbVIXE", "4XcdQOwv"], "falsePositive": ["i6Lrfdvp", "rniaKc17", "DxDdT7g6"], "word": "Y4eo4zpY", "wordType": "yNZr9eWU"}, {"falseNegative": ["VDXqyMlA", "j73drkU9", "fzJDcajv"], "falsePositive": ["8Aaqp9kb", "cteuY2oy", "7bNASLoY"], "word": "5V8k0ZKB", "wordType": "E7LOz0Yj"}, {"falseNegative": ["tTKCV85P", "J1a1GB5n", "SZRMu4t5"], "falsePositive": ["3qkhT9gw", "dn9A1fnY", "QxvYigwp"], "word": "8pPYYeHG", "wordType": "c2wuvMLN"}]}' > $TEMP_JSON_INPUT
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
    --limit '27' \
    --offset '54' \
    > test.out 2>&1
eval_tap $? 55 'AdminProfanityGroup' test.out

#- 56 AdminProfanityImport
# form data upload: file
echo 'tmp.dat' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --sn chat \
    --op AdminProfanityImport \
    --namespace $AB_NAMESPACE \
    --action 'LEAVEOUT' \
    --showResult 'true' \
    --upload $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 56 'AdminProfanityImport' test.out

#- 57 AdminProfanityUpdate
# body param: body
echo '{"falseNegative": ["juPIYxGj", "HRoeczYU", "QwjRZKNc"], "falsePositive": ["HAULlbL4", "FmSVdpxk", "H80RTGA8"], "word": "vcc8ShES", "wordType": "0yix8ZYO"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn chat \
    --op AdminProfanityUpdate \
    --id 'WkdzxmIo' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 57 'AdminProfanityUpdate' test.out

#- 58 AdminProfanityDelete
$CLI_EXE \
    --sn chat \
    --op AdminProfanityDelete \
    --id 'ec5YDMbi' \
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
    --chatId 'fJfxBMn3' \
    --namespace $AB_NAMESPACE \
    --topic 'oDEtkIVi' \
    > test.out 2>&1
eval_tap $? 60 'PublicGetChatSnapshot' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE