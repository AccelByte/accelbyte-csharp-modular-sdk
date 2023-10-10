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
echo "1..27"

#- 1 Login
$CLI_EXE --op login --lt user --user user --pass user > test.out 2>&1
eval_tap $? 1 'Login' test.out

if [ $EXIT_CODE -ne 0 ]; then
  echo "Bail out! Login failed."
  exit $EXIT_CODE
fi

# echo "foo" > "$CLI_TOKEN_FILE"

#- 2 AdminListAchievements
$CLI_EXE \
    --sn achievement \
    --op AdminListAchievements \
    --namespace $AB_NAMESPACE \
    --global 'false' \
    --limit '55' \
    --offset '36' \
    --sortBy 'updatedAt' \
    --tags '["GLe3P9WB", "h4w9FofZ", "4yP80243"]' \
    > test.out 2>&1
eval_tap $? 2 'AdminListAchievements' test.out

#- 3 AdminCreateNewAchievement
# body param: body
echo '{"achievementCode": "fc7p9u9c", "customAttributes": {"HOblXkAY": {}, "L3p9xjBw": {}, "e7Jx2TNU": {}}, "defaultLanguage": "y161hQVL", "description": {"JtzxIAcN": "graP7txF", "9qxLgDpj": "qaaYBY69", "ZmDquCXi": "RsmtYCmb"}, "global": true, "goalValue": 0.1513962159903458, "hidden": false, "incremental": false, "lockedIcons": [{"slug": "LaeFGIEV", "url": "vHS24XER"}, {"slug": "aTgN3C9k", "url": "rm9JjdJ0"}, {"slug": "k437AHZ6", "url": "r0Ic9eiL"}], "name": {"qmtDlLKo": "hZ3WrkU4", "dP29EMgX": "VohyaXbt", "vwCVre0w": "40Ar7cf3"}, "statCode": "y792MTfq", "tags": ["wFRjdjhz", "5P9Lifrx", "eqoMaAAT"], "unlockedIcons": [{"slug": "myv9aLY8", "url": "UpOxnpkr"}, {"slug": "rmrmQMVI", "url": "6cL35Hdz"}, {"slug": "en6YYnnd", "url": "WFoVHubj"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn achievement \
    --op AdminCreateNewAchievement \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 3 'AdminCreateNewAchievement' test.out

#- 4 ExportAchievements
$CLI_EXE \
    --sn achievement \
    --op ExportAchievements \
    --namespace $AB_NAMESPACE \
    --tags '["MOZOto84", "ChrIbwfC", "K8fCEZHj"]' \
    > test.out 2>&1
eval_tap $? 4 'ExportAchievements' test.out

#- 5 ImportAchievements
# form data upload: file
echo 'tmp.dat' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --sn achievement \
    --op ImportAchievements \
    --namespace $AB_NAMESPACE \
    --upload $TEMP_FILE_UPLOAD \
    --strategy 'y8MupTFa' \
    > test.out 2>&1
eval_tap $? 5 'ImportAchievements' test.out

#- 6 AdminGetAchievement
$CLI_EXE \
    --sn achievement \
    --op AdminGetAchievement \
    --achievementCode 'Y3QitL3y' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 6 'AdminGetAchievement' test.out

#- 7 AdminUpdateAchievement
# body param: body
echo '{"customAttributes": {"2VRm2VGE": {}, "7Ati4UAi": {}, "5QSt2VSt": {}}, "defaultLanguage": "5qA8ny0n", "description": {"Bn31SMM3": "Yrph4mFJ", "iI2CVCsg": "MqPcrJsL", "Zzf9yqDv": "1DZW2G7S"}, "global": false, "goalValue": 0.43476428850262394, "hidden": false, "incremental": false, "lockedIcons": [{"slug": "UCtJzRrI", "url": "gAvwDvji"}, {"slug": "flg2wyyx", "url": "dKMdmR5x"}, {"slug": "k8O2gAdT", "url": "pRSZfAdY"}], "name": {"k3vXtnkq": "hSkKOSEE", "NlwiVul3": "EHOY8gTx", "pJNrqSuV": "2LEipCry"}, "statCode": "ZN3OECpG", "tags": ["abqMGojV", "Jqk4xO0z", "JEIDMZoO"], "unlockedIcons": [{"slug": "2WMOQuDh", "url": "YjTq3hRi"}, {"slug": "S9TExhiL", "url": "nS7WA69j"}, {"slug": "vDKWRW08", "url": "HdGhkwhy"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn achievement \
    --op AdminUpdateAchievement \
    --achievementCode 'GP56vORh' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 7 'AdminUpdateAchievement' test.out

#- 8 AdminDeleteAchievement
$CLI_EXE \
    --sn achievement \
    --op AdminDeleteAchievement \
    --achievementCode 'v1ayC5Bh' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 8 'AdminDeleteAchievement' test.out

#- 9 AdminUpdateAchievementListOrder
# body param: body
echo '{"targetOrder": 96}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn achievement \
    --op AdminUpdateAchievementListOrder \
    --achievementCode '7oUcAC6J' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 9 'AdminUpdateAchievementListOrder' test.out

#- 10 AdminListGlobalAchievements
$CLI_EXE \
    --sn achievement \
    --op AdminListGlobalAchievements \
    --namespace $AB_NAMESPACE \
    --achievementCodes 'nL5j0nJ9' \
    --limit '14' \
    --offset '48' \
    --sortBy '1etxdhpa' \
    --status 'CbVoE8OZ' \
    --tags '["v6lhKVIa", "QDUhL8IX", "yiRRAzS9"]' \
    > test.out 2>&1
eval_tap $? 10 'AdminListGlobalAchievements' test.out

#- 11 AdminListGlobalAchievementContributors
$CLI_EXE \
    --sn achievement \
    --op AdminListGlobalAchievementContributors \
    --achievementCode 'pRPUQbN0' \
    --namespace $AB_NAMESPACE \
    --limit '42' \
    --offset '46' \
    --sortBy 'drff4Zrg' \
    > test.out 2>&1
eval_tap $? 11 'AdminListGlobalAchievementContributors' test.out

#- 12 ResetGlobalAchievement
$CLI_EXE \
    --sn achievement \
    --op ResetGlobalAchievement \
    --achievementCode 'Gig39xhe' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 12 'ResetGlobalAchievement' test.out

#- 13 AdminListTags
$CLI_EXE \
    --sn achievement \
    --op AdminListTags \
    --namespace $AB_NAMESPACE \
    --limit '16' \
    --name '0wcXghhM' \
    --offset '97' \
    --sortBy 'D5bnKvnl' \
    > test.out 2>&1
eval_tap $? 13 'AdminListTags' test.out

#- 14 AdminListUserAchievements
$CLI_EXE \
    --sn achievement \
    --op AdminListUserAchievements \
    --namespace $AB_NAMESPACE \
    --userId 'eGIoMz0Y' \
    --limit '44' \
    --offset '1' \
    --preferUnlocked 'false' \
    --sortBy 'aryIuI2y' \
    --tags '["EoLQjFep", "8ubAoGzu", "euPX75rO"]' \
    > test.out 2>&1
eval_tap $? 14 'AdminListUserAchievements' test.out

#- 15 AdminResetAchievement
$CLI_EXE \
    --sn achievement \
    --op AdminResetAchievement \
    --achievementCode 'Lq1Lwvfe' \
    --namespace $AB_NAMESPACE \
    --userId 'PPrLIpu3' \
    > test.out 2>&1
eval_tap $? 15 'AdminResetAchievement' test.out

#- 16 AdminUnlockAchievement
$CLI_EXE \
    --sn achievement \
    --op AdminUnlockAchievement \
    --achievementCode 'bPCUoQ8l' \
    --namespace $AB_NAMESPACE \
    --userId 'lElI6jY7' \
    > test.out 2>&1
eval_tap $? 16 'AdminUnlockAchievement' test.out

#- 17 AdminAnonymizeUserAchievement
$CLI_EXE \
    --sn achievement \
    --op AdminAnonymizeUserAchievement \
    --namespace $AB_NAMESPACE \
    --userId 'VZKOLPYC' \
    > test.out 2>&1
eval_tap $? 17 'AdminAnonymizeUserAchievement' test.out

#- 18 AdminListUserContributions
$CLI_EXE \
    --sn achievement \
    --op AdminListUserContributions \
    --namespace $AB_NAMESPACE \
    --userId 'ZxComNAx' \
    --achievementCodes '6G27QhJM' \
    --limit '98' \
    --offset '25' \
    --sortBy 'hBQCbPsI' \
    --tags '["TuShjAA7", "74xkvbj6", "9K4EUilg"]' \
    > test.out 2>&1
eval_tap $? 18 'AdminListUserContributions' test.out

#- 19 PublicListAchievements
$CLI_EXE \
    --sn achievement \
    --op PublicListAchievements \
    --namespace $AB_NAMESPACE \
    --global 'true' \
    --limit '48' \
    --offset '19' \
    --sortBy 'listOrder:asc' \
    --tags '["vghLkHiz", "fCZ3MQj8", "aOinpf3k"]' \
    --language 'HjIjPzYC' \
    > test.out 2>&1
eval_tap $? 19 'PublicListAchievements' test.out

#- 20 PublicGetAchievement
$CLI_EXE \
    --sn achievement \
    --op PublicGetAchievement \
    --achievementCode 'mGOq2sBx' \
    --namespace $AB_NAMESPACE \
    --language '7SqDZfhY' \
    > test.out 2>&1
eval_tap $? 20 'PublicGetAchievement' test.out

#- 21 PublicListGlobalAchievements
$CLI_EXE \
    --sn achievement \
    --op PublicListGlobalAchievements \
    --namespace $AB_NAMESPACE \
    --achievementCodes 'XOKsSRPA' \
    --limit '43' \
    --offset '65' \
    --sortBy '91jINnCe' \
    --status '1G3ZYoCX' \
    --tags '["6LFzXaBK", "FBm4abcr", "8BBMoolw"]' \
    > test.out 2>&1
eval_tap $? 21 'PublicListGlobalAchievements' test.out

#- 22 ListGlobalAchievementContributors
$CLI_EXE \
    --sn achievement \
    --op ListGlobalAchievementContributors \
    --achievementCode 'pOTtzXKx' \
    --namespace $AB_NAMESPACE \
    --limit '0' \
    --offset '82' \
    --sortBy '264sYrmY' \
    > test.out 2>&1
eval_tap $? 22 'ListGlobalAchievementContributors' test.out

#- 23 PublicListTags
$CLI_EXE \
    --sn achievement \
    --op PublicListTags \
    --namespace $AB_NAMESPACE \
    --limit '39' \
    --name 'EdTQDxv5' \
    --offset '90' \
    --sortBy '5lpDPWgY' \
    > test.out 2>&1
eval_tap $? 23 'PublicListTags' test.out

#- 24 PublicListUserAchievements
$CLI_EXE \
    --sn achievement \
    --op PublicListUserAchievements \
    --namespace $AB_NAMESPACE \
    --userId '089ai2Ww' \
    --limit '45' \
    --offset '65' \
    --preferUnlocked 'true' \
    --sortBy 'LPB8oWNx' \
    --tags '["ocM8tZWN", "NTCI7dQ8", "s7mKBYGY"]' \
    > test.out 2>&1
eval_tap $? 24 'PublicListUserAchievements' test.out

#- 25 PublicUnlockAchievement
$CLI_EXE \
    --sn achievement \
    --op PublicUnlockAchievement \
    --achievementCode 'AyoAxIw6' \
    --namespace $AB_NAMESPACE \
    --userId 'qN145dGk' \
    > test.out 2>&1
eval_tap $? 25 'PublicUnlockAchievement' test.out

#- 26 ListUserContributions
$CLI_EXE \
    --sn achievement \
    --op ListUserContributions \
    --namespace $AB_NAMESPACE \
    --userId 'xKhGxXua' \
    --achievementCodes 'LnIiZ2pI' \
    --limit '86' \
    --offset '40' \
    --sortBy '119KiRfa' \
    --tags '["2950PdIV", "qakmQbKV", "zrG1yjNF"]' \
    > test.out 2>&1
eval_tap $? 26 'ListUserContributions' test.out

#- 27 ClaimGlobalAchievementReward
$CLI_EXE \
    --sn achievement \
    --op ClaimGlobalAchievementReward \
    --achievementCode '3dk3Mxrf' \
    --namespace $AB_NAMESPACE \
    --userId 'uypefSZT' \
    > test.out 2>&1
eval_tap $? 27 'ClaimGlobalAchievementReward' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE