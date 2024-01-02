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
    --limit '21' \
    --offset '98' \
    --sortBy 'listOrder:desc' \
    --tags '["egdLncZw", "i7yryIvZ", "7wLgjQlQ"]' \
    > test.out 2>&1
eval_tap $? 2 'AdminListAchievements' test.out

#- 3 AdminCreateNewAchievement
# body param: body
echo '{"achievementCode": "18chJ3J7", "customAttributes": {"mUjXh3nq": {}, "fWYUKyM9": {}, "F1Mrm7Go": {}}, "defaultLanguage": "tJUpdU0d", "description": {"zWzQu0QR": "Xq10mdsm", "p3fG0PFo": "qq3haKn2", "ZWXjHOoO": "1kXhEY23"}, "global": true, "goalValue": 0.46759483771986565, "hidden": false, "incremental": true, "lockedIcons": [{"slug": "EM15eqFk", "url": "2DQlTzmN"}, {"slug": "Qx6PmQXF", "url": "YYXZv8la"}, {"slug": "oGA49gl3", "url": "cToVBAT6"}], "name": {"7Z6NsZab": "zsLETi7l", "lbU40RWi": "4M1lCwzb", "pU4TCEAi": "dlixhvIB"}, "statCode": "y0VDaV3R", "tags": ["DjeScSQB", "IL2a8wHx", "6sTBsWst"], "unlockedIcons": [{"slug": "LqyDM9yQ", "url": "iJGNzKYF"}, {"slug": "g9Mz0YyM", "url": "OxIH8GYW"}, {"slug": "XFmrfndH", "url": "UwgW4Dzq"}]}' > $TEMP_JSON_INPUT
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
    --tags '["4gGegJPX", "Y31TQCa1", "LzLHlpcd"]' \
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
    --strategy 'v9xgSzHK' \
    > test.out 2>&1
eval_tap $? 5 'ImportAchievements' test.out

#- 6 AdminGetAchievement
$CLI_EXE \
    --sn achievement \
    --op AdminGetAchievement \
    --achievementCode 'NRikPPVG' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 6 'AdminGetAchievement' test.out

#- 7 AdminUpdateAchievement
# body param: body
echo '{"customAttributes": {"4AbanYdQ": {}, "4AEgx7S5": {}, "etcy2rdG": {}}, "defaultLanguage": "jsEt64B5", "description": {"cvIiWuSY": "8DEZaswI", "Clfobe4F": "LPOFH94Q", "sEYdp0IR": "YoCKIqmX"}, "global": false, "goalValue": 0.0953264668355811, "hidden": false, "incremental": false, "lockedIcons": [{"slug": "V7OVq3qn", "url": "YqrCB3ZP"}, {"slug": "QLgGrW47", "url": "ic0N5Ce0"}, {"slug": "BpOxeDhx", "url": "knksgA3O"}], "name": {"jvH7hsM7": "R4HF6OvC", "Aei07zKz": "Aoi367I0", "86k6rNFP": "vGlhdSp8"}, "statCode": "7XFijml1", "tags": ["MKRa94dq", "QBZyMuO8", "ypagNLte"], "unlockedIcons": [{"slug": "cTeQW1cJ", "url": "qJKIyn5q"}, {"slug": "bcFN9QKt", "url": "HrvgAFn8"}, {"slug": "Iryz6rP4", "url": "8uD2bcNV"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn achievement \
    --op AdminUpdateAchievement \
    --achievementCode 'ALuOKyG6' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 7 'AdminUpdateAchievement' test.out

#- 8 AdminDeleteAchievement
$CLI_EXE \
    --sn achievement \
    --op AdminDeleteAchievement \
    --achievementCode 'kiZbCQPw' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 8 'AdminDeleteAchievement' test.out

#- 9 AdminUpdateAchievementListOrder
# body param: body
echo '{"targetOrder": 65}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn achievement \
    --op AdminUpdateAchievementListOrder \
    --achievementCode 'DKz48vxW' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 9 'AdminUpdateAchievementListOrder' test.out

#- 10 AdminListGlobalAchievements
$CLI_EXE \
    --sn achievement \
    --op AdminListGlobalAchievements \
    --namespace $AB_NAMESPACE \
    --achievementCodes 'BjPPUyWe' \
    --limit '61' \
    --offset '23' \
    --sortBy 'LGaqAuYx' \
    --status 'uz7VOAGz' \
    --tags '["qx22KkGB", "EDg2Jb6g", "of2CvaT1"]' \
    > test.out 2>&1
eval_tap $? 10 'AdminListGlobalAchievements' test.out

#- 11 AdminListGlobalAchievementContributors
$CLI_EXE \
    --sn achievement \
    --op AdminListGlobalAchievementContributors \
    --achievementCode '6qctk3i6' \
    --namespace $AB_NAMESPACE \
    --limit '16' \
    --offset '99' \
    --sortBy 'hHNe1qVu' \
    > test.out 2>&1
eval_tap $? 11 'AdminListGlobalAchievementContributors' test.out

#- 12 ResetGlobalAchievement
$CLI_EXE \
    --sn achievement \
    --op ResetGlobalAchievement \
    --achievementCode 'P39snRkU' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 12 'ResetGlobalAchievement' test.out

#- 13 AdminListTags
$CLI_EXE \
    --sn achievement \
    --op AdminListTags \
    --namespace $AB_NAMESPACE \
    --limit '60' \
    --name 'ER062L1e' \
    --offset '77' \
    --sortBy '7yevxVGh' \
    > test.out 2>&1
eval_tap $? 13 'AdminListTags' test.out

#- 14 AdminListUserAchievements
$CLI_EXE \
    --sn achievement \
    --op AdminListUserAchievements \
    --namespace $AB_NAMESPACE \
    --userId 'sHtxvdWv' \
    --limit '26' \
    --offset '71' \
    --preferUnlocked 'true' \
    --sortBy 'qEZDBvAk' \
    --tags '["MiDvSBxh", "9fRRep02", "9R07TlSO"]' \
    > test.out 2>&1
eval_tap $? 14 'AdminListUserAchievements' test.out

#- 15 AdminResetAchievement
$CLI_EXE \
    --sn achievement \
    --op AdminResetAchievement \
    --achievementCode 'vthX0bQA' \
    --namespace $AB_NAMESPACE \
    --userId '4taNSpKt' \
    > test.out 2>&1
eval_tap $? 15 'AdminResetAchievement' test.out

#- 16 AdminUnlockAchievement
$CLI_EXE \
    --sn achievement \
    --op AdminUnlockAchievement \
    --achievementCode 'JEc7Ctly' \
    --namespace $AB_NAMESPACE \
    --userId 'G0zXUU9I' \
    > test.out 2>&1
eval_tap $? 16 'AdminUnlockAchievement' test.out

#- 17 AdminAnonymizeUserAchievement
$CLI_EXE \
    --sn achievement \
    --op AdminAnonymizeUserAchievement \
    --namespace $AB_NAMESPACE \
    --userId 'Tjjrocwo' \
    > test.out 2>&1
eval_tap $? 17 'AdminAnonymizeUserAchievement' test.out

#- 18 AdminListUserContributions
$CLI_EXE \
    --sn achievement \
    --op AdminListUserContributions \
    --namespace $AB_NAMESPACE \
    --userId 'YSz7tcjS' \
    --achievementCodes 'E7hFm5f7' \
    --limit '12' \
    --offset '24' \
    --sortBy 'DTe0ouH4' \
    --tags '["DjXewdKO", "6kvxnhzt", "5eIdgTFm"]' \
    > test.out 2>&1
eval_tap $? 18 'AdminListUserContributions' test.out

#- 19 PublicListAchievements
$CLI_EXE \
    --sn achievement \
    --op PublicListAchievements \
    --namespace $AB_NAMESPACE \
    --global 'true' \
    --limit '60' \
    --offset '86' \
    --sortBy 'listOrder:asc' \
    --tags '["LH8Zto58", "5wvUBTzc", "wvHtOKVH"]' \
    --language 'PAkD3FCP' \
    > test.out 2>&1
eval_tap $? 19 'PublicListAchievements' test.out

#- 20 PublicGetAchievement
$CLI_EXE \
    --sn achievement \
    --op PublicGetAchievement \
    --achievementCode '9RHgi1PY' \
    --namespace $AB_NAMESPACE \
    --language 'INEhmkEW' \
    > test.out 2>&1
eval_tap $? 20 'PublicGetAchievement' test.out

#- 21 PublicListGlobalAchievements
$CLI_EXE \
    --sn achievement \
    --op PublicListGlobalAchievements \
    --namespace $AB_NAMESPACE \
    --achievementCodes 'cRZYyW0M' \
    --limit '35' \
    --offset '65' \
    --sortBy 'MAoQFk39' \
    --status 'Gvznr4yP' \
    --tags '["xahGKKnm", "sooLS6fV", "UdQ7xaIt"]' \
    > test.out 2>&1
eval_tap $? 21 'PublicListGlobalAchievements' test.out

#- 22 ListGlobalAchievementContributors
$CLI_EXE \
    --sn achievement \
    --op ListGlobalAchievementContributors \
    --achievementCode 'SfJxGOrL' \
    --namespace $AB_NAMESPACE \
    --limit '28' \
    --offset '95' \
    --sortBy 'BYqQ11uw' \
    > test.out 2>&1
eval_tap $? 22 'ListGlobalAchievementContributors' test.out

#- 23 PublicListTags
$CLI_EXE \
    --sn achievement \
    --op PublicListTags \
    --namespace $AB_NAMESPACE \
    --limit '79' \
    --name 'jk5mu9R9' \
    --offset '47' \
    --sortBy 'jqSFkbUh' \
    > test.out 2>&1
eval_tap $? 23 'PublicListTags' test.out

#- 24 PublicListUserAchievements
$CLI_EXE \
    --sn achievement \
    --op PublicListUserAchievements \
    --namespace $AB_NAMESPACE \
    --userId 'QxympzF1' \
    --limit '78' \
    --offset '9' \
    --preferUnlocked 'true' \
    --sortBy 'EyPzUkyb' \
    --tags '["75BvGEwe", "h6tsgoFj", "kdUqSlLy"]' \
    > test.out 2>&1
eval_tap $? 24 'PublicListUserAchievements' test.out

#- 25 PublicUnlockAchievement
$CLI_EXE \
    --sn achievement \
    --op PublicUnlockAchievement \
    --achievementCode 'bN3h4oH8' \
    --namespace $AB_NAMESPACE \
    --userId 'mVuHTkEo' \
    > test.out 2>&1
eval_tap $? 25 'PublicUnlockAchievement' test.out

#- 26 ListUserContributions
$CLI_EXE \
    --sn achievement \
    --op ListUserContributions \
    --namespace $AB_NAMESPACE \
    --userId 'owDsmbY7' \
    --achievementCodes 'VSiWDdtE' \
    --limit '58' \
    --offset '71' \
    --sortBy 'MdCVWcul' \
    --tags '["JHjhfG1A", "5kf3Ma2R", "IPDwP6Tq"]' \
    > test.out 2>&1
eval_tap $? 26 'ListUserContributions' test.out

#- 27 ClaimGlobalAchievementReward
$CLI_EXE \
    --sn achievement \
    --op ClaimGlobalAchievementReward \
    --achievementCode 'uS4SDbQ2' \
    --namespace $AB_NAMESPACE \
    --userId 'USk90ZUA' \
    > test.out 2>&1
eval_tap $? 27 'ClaimGlobalAchievementReward' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE