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
echo "1..45"

#- 1 Login
$CLI_EXE --op login --lt user --user user --pass user > test.out 2>&1
eval_tap $? 1 'Login' test.out

if [ $EXIT_CODE -ne 0 ]; then
  echo "Bail out! Login failed."
  exit $EXIT_CODE
fi

# echo "foo" > "$CLI_TOKEN_FILE"

#- 2 ExportSeason
$CLI_EXE \
    --sn seasonpass \
    --op ExportSeason \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 2 'ExportSeason' test.out

#- 3 QuerySeasons
$CLI_EXE \
    --sn seasonpass \
    --op QuerySeasons \
    --namespace $AB_NAMESPACE \
    --limit '60' \
    --offset '60' \
    --status '["RETIRED", "DRAFT", "PUBLISHED"]' \
    > test.out 2>&1
eval_tap $? 3 'QuerySeasons' test.out

#- 4 CreateSeason
# body param: body
echo '{"autoClaim": true, "defaultLanguage": "bjhIHVbe", "defaultRequiredExp": 39, "draftStoreId": "mPDj3rhM", "end": "1983-06-20T00:00:00Z", "excessStrategy": {"currency": "Wqq8ejcb", "method": "CURRENCY", "percentPerExp": 11}, "images": [{"as": "eKXQqbML", "caption": "YRkRI2br", "height": 41, "imageUrl": "OvaYXRUT", "smallImageUrl": "LjKdfzpn", "width": 50}, {"as": "TtSazOSI", "caption": "7JPbecbY", "height": 42, "imageUrl": "IoehQdVB", "smallImageUrl": "sm5L0T4L", "width": 75}, {"as": "eawEsVg7", "caption": "4llXLORj", "height": 91, "imageUrl": "6aEXa5V9", "smallImageUrl": "qsqe3l20", "width": 39}], "localizations": {"Mqz2ZGnj": {"description": "9QnNih00", "title": "GcLadU1y"}, "n7T86np5": {"description": "uZLaCmai", "title": "U6gtI2tK"}, "PDXuCLK7": {"description": "gEvROY0D", "title": "qNRzHHmW"}}, "name": "Cf0wh8Rv", "start": "1978-10-23T00:00:00Z", "tierItemId": "7se0WuV4"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op CreateSeason \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 4 'CreateSeason' test.out

#- 5 GetCurrentSeason
$CLI_EXE \
    --sn seasonpass \
    --op GetCurrentSeason \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 5 'GetCurrentSeason' test.out

#- 6 BulkGetUserSeasonProgression
# body param: body
echo '{"userIds": ["7sAdZAOr", "T9BWC12g", "AwXXUvRD"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op BulkGetUserSeasonProgression \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 6 'BulkGetUserSeasonProgression' test.out

#- 7 GetSeason
$CLI_EXE \
    --sn seasonpass \
    --op GetSeason \
    --namespace $AB_NAMESPACE \
    --seasonId 'Ryr6vRyr' \
    > test.out 2>&1
eval_tap $? 7 'GetSeason' test.out

#- 8 DeleteSeason
$CLI_EXE \
    --sn seasonpass \
    --op DeleteSeason \
    --namespace $AB_NAMESPACE \
    --seasonId 'vuD36Emv' \
    > test.out 2>&1
eval_tap $? 8 'DeleteSeason' test.out

#- 9 UpdateSeason
# body param: body
echo '{"autoClaim": false, "defaultLanguage": "QkHigoEK", "defaultRequiredExp": 18, "draftStoreId": "orxtwmhW", "end": "1972-07-04T00:00:00Z", "excessStrategy": {"currency": "pfrph5Eb", "method": "NONE", "percentPerExp": 1}, "images": [{"as": "HzTIyGIm", "caption": "ShLe9tre", "height": 32, "imageUrl": "j4W27wRi", "smallImageUrl": "qAglQ2aa", "width": 37}, {"as": "6Sy5V7cr", "caption": "Xm2YrnmV", "height": 61, "imageUrl": "Cgdegkgc", "smallImageUrl": "46mkXPDH", "width": 9}, {"as": "EZKaPgi4", "caption": "WBAUtmoJ", "height": 3, "imageUrl": "8bhpFIyX", "smallImageUrl": "cEX7ypiE", "width": 45}], "localizations": {"MY2KcvRx": {"description": "jmeBOkE6", "title": "gDFeu6Vx"}, "G099tbWB": {"description": "H88yTIUN", "title": "qdWvr7ye"}, "59eq4JtH": {"description": "TOpXkBWC", "title": "w8RVrfRM"}}, "name": "rGiqASAw", "start": "1973-04-11T00:00:00Z", "tierItemId": "k7GDwMOB"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op UpdateSeason \
    --namespace $AB_NAMESPACE \
    --seasonId 'nqiJNDa8' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 9 'UpdateSeason' test.out

#- 10 CloneSeason
# body param: body
echo '{"end": "1983-09-27T00:00:00Z", "name": "zIHAWUtj", "start": "1990-08-11T00:00:00Z"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op CloneSeason \
    --namespace $AB_NAMESPACE \
    --seasonId 'UJLDYiko' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 10 'CloneSeason' test.out

#- 11 GetFullSeason
$CLI_EXE \
    --sn seasonpass \
    --op GetFullSeason \
    --namespace $AB_NAMESPACE \
    --seasonId 'rwWPUYby' \
    > test.out 2>&1
eval_tap $? 11 'GetFullSeason' test.out

#- 12 QueryPasses
$CLI_EXE \
    --sn seasonpass \
    --op QueryPasses \
    --namespace $AB_NAMESPACE \
    --seasonId 'KyhdA71e' \
    > test.out 2>&1
eval_tap $? 12 'QueryPasses' test.out

#- 13 CreatePass
# body param: body
echo '{"autoEnroll": false, "code": "JXvF5oIz", "displayOrder": 50, "images": [{"as": "99wWtK9N", "caption": "PebyPVYc", "height": 63, "imageUrl": "RFnQ6k9S", "smallImageUrl": "t3LX86t8", "width": 28}, {"as": "53FdRa5i", "caption": "XnS1AiPO", "height": 29, "imageUrl": "naEOMOYS", "smallImageUrl": "GwYEhdeS", "width": 88}, {"as": "JE9F0fYL", "caption": "MT1WIO1I", "height": 0, "imageUrl": "Zfux7S5L", "smallImageUrl": "n3zjrudR", "width": 47}], "localizations": {"tziCpCz9": {"description": "7M2ebPVk", "title": "DO7H3jHP"}, "o7GU67Iy": {"description": "qCI97BrL", "title": "MuBbxO8L"}, "0VL69cHE": {"description": "Qd0t4GyQ", "title": "3sUWgZYl"}}, "passItemId": "8uCYJ8ic"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op CreatePass \
    --namespace $AB_NAMESPACE \
    --seasonId 'f8DLieTH' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 13 'CreatePass' test.out

#- 14 GetPass
$CLI_EXE \
    --sn seasonpass \
    --op GetPass \
    --code 'lCsPNR4D' \
    --namespace $AB_NAMESPACE \
    --seasonId 'IeT99CUc' \
    > test.out 2>&1
eval_tap $? 14 'GetPass' test.out

#- 15 DeletePass
$CLI_EXE \
    --sn seasonpass \
    --op DeletePass \
    --code 'B3d20olu' \
    --namespace $AB_NAMESPACE \
    --seasonId 'ekUAVuwv' \
    > test.out 2>&1
eval_tap $? 15 'DeletePass' test.out

#- 16 UpdatePass
# body param: body
echo '{"autoEnroll": true, "displayOrder": 99, "images": [{"as": "waUTDx2V", "caption": "wILQ7xt1", "height": 75, "imageUrl": "rakdY2m2", "smallImageUrl": "Y96DJJwP", "width": 92}, {"as": "TOt1UEa1", "caption": "yKPTUYPL", "height": 34, "imageUrl": "opWF0G0c", "smallImageUrl": "2qBc24Yn", "width": 96}, {"as": "t82hG1lA", "caption": "swZulBZt", "height": 28, "imageUrl": "OorGWNDr", "smallImageUrl": "wr4J3LUA", "width": 36}], "localizations": {"RhZ7awYE": {"description": "BOGuVcvU", "title": "t3Qi6y4L"}, "ONdFyCIy": {"description": "sA1s92lH", "title": "XS44dseA"}, "6wz9CLMy": {"description": "9UMGokU2", "title": "XNxcdppQ"}}, "passItemId": "3hXz6Nbh"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op UpdatePass \
    --code 'x4OvKRGC' \
    --namespace $AB_NAMESPACE \
    --seasonId '8lZCgcHq' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 16 'UpdatePass' test.out

#- 17 PublishSeason
$CLI_EXE \
    --sn seasonpass \
    --op PublishSeason \
    --namespace $AB_NAMESPACE \
    --seasonId 'a7r9AyDs' \
    > test.out 2>&1
eval_tap $? 17 'PublishSeason' test.out

#- 18 RetireSeason
$CLI_EXE \
    --sn seasonpass \
    --op RetireSeason \
    --namespace $AB_NAMESPACE \
    --seasonId 'WLhiQr8T' \
    --force 'false' \
    > test.out 2>&1
eval_tap $? 18 'RetireSeason' test.out

#- 19 QueryRewards
$CLI_EXE \
    --sn seasonpass \
    --op QueryRewards \
    --namespace $AB_NAMESPACE \
    --seasonId '9oRS1fsV' \
    --q 'oI27Niro' \
    > test.out 2>&1
eval_tap $? 19 'QueryRewards' test.out

#- 20 CreateReward
# body param: body
echo '{"code": "lsoBYM6R", "currency": {"currencyCode": "WjnlUwox", "namespace": "z1Yj1KeF"}, "image": {"as": "1zKIklrH", "caption": "oWcl3mxw", "height": 65, "imageUrl": "wjB4HXh4", "smallImageUrl": "z4jFGDyq", "width": 13}, "itemId": "cIHQlLIg", "quantity": 98, "type": "CURRENCY"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op CreateReward \
    --namespace $AB_NAMESPACE \
    --seasonId '6SmFKYeR' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 20 'CreateReward' test.out

#- 21 GetReward
$CLI_EXE \
    --sn seasonpass \
    --op GetReward \
    --code 'NOeApLPf' \
    --namespace $AB_NAMESPACE \
    --seasonId 'KNHjBXjW' \
    > test.out 2>&1
eval_tap $? 21 'GetReward' test.out

#- 22 DeleteReward
$CLI_EXE \
    --sn seasonpass \
    --op DeleteReward \
    --code 'eWg1O76p' \
    --namespace $AB_NAMESPACE \
    --seasonId 'XkDNqxWe' \
    > test.out 2>&1
eval_tap $? 22 'DeleteReward' test.out

#- 23 UpdateReward
# body param: body
echo '{"currency": {"currencyCode": "oZQHQ5o5", "namespace": "EVycT4qk"}, "image": {"as": "DhEsP0Nb", "caption": "G2uvJEH6", "height": 0, "imageUrl": "gXJ81W9t", "smallImageUrl": "lvLQdVim", "width": 54}, "itemId": "bGYPGazs", "nullFields": ["wlcRYOU8", "ORApUSLv", "ZyKJYo9n"], "quantity": 27, "type": "ITEM"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op UpdateReward \
    --code 'aDaNfI5a' \
    --namespace $AB_NAMESPACE \
    --seasonId 'cYawy5eh' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 23 'UpdateReward' test.out

#- 24 QueryTiers
$CLI_EXE \
    --sn seasonpass \
    --op QueryTiers \
    --namespace $AB_NAMESPACE \
    --seasonId 'Ffg3LrJ6' \
    --limit '86' \
    --offset '1' \
    > test.out 2>&1
eval_tap $? 24 'QueryTiers' test.out

#- 25 CreateTier
# body param: body
echo '{"index": 53, "quantity": 61, "tier": {"requiredExp": 75, "rewards": {"Z7WNa3KT": ["KIU406RN", "NPcQO641", "AkdeV07E"], "fwaYN9f3": ["XgyJYtbK", "jqNgPjwQ", "7cCjo2LB"], "AF5Kglmn": ["MpG8yuDv", "zsUqrawR", "980m4cry"]}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op CreateTier \
    --namespace $AB_NAMESPACE \
    --seasonId 'jil7VnuC' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 25 'CreateTier' test.out

#- 26 UpdateTier
# body param: body
echo '{"requiredExp": 7, "rewards": {"6lPniyl2": ["4j9pQL86", "gnSMoX2s", "QB2Yck4d"], "cP0cL4AN": ["6tHqXq1Z", "EkbQFeDq", "vfJpms3N"], "nZ2rPkhx": ["vGacKe9Y", "irEDkVCm", "sMLoJQ6o"]}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op UpdateTier \
    --id 'a4AGxorS' \
    --namespace $AB_NAMESPACE \
    --seasonId 'ULB7omuf' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 26 'UpdateTier' test.out

#- 27 DeleteTier
$CLI_EXE \
    --sn seasonpass \
    --op DeleteTier \
    --id 'fNrliQN7' \
    --namespace $AB_NAMESPACE \
    --seasonId 'UIWFIlRZ' \
    > test.out 2>&1
eval_tap $? 27 'DeleteTier' test.out

#- 28 ReorderTier
# body param: body
echo '{"newIndex": 61}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op ReorderTier \
    --id 'lqUUDKWn' \
    --namespace $AB_NAMESPACE \
    --seasonId 'ygC8K95h' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 28 'ReorderTier' test.out

#- 29 UnpublishSeason
$CLI_EXE \
    --sn seasonpass \
    --op UnpublishSeason \
    --namespace $AB_NAMESPACE \
    --seasonId '0jbsjD75' \
    --force 'true' \
    > test.out 2>&1
eval_tap $? 29 'UnpublishSeason' test.out

#- 30 GetUserParticipatedSeasons
$CLI_EXE \
    --sn seasonpass \
    --op GetUserParticipatedSeasons \
    --namespace $AB_NAMESPACE \
    --userId '5p6n7Gfq' \
    --limit '74' \
    --offset '3' \
    > test.out 2>&1
eval_tap $? 30 'GetUserParticipatedSeasons' test.out

#- 31 GrantUserExp
# body param: body
echo '{"exp": 71, "source": "SWEAT", "tags": ["KbnadYJR", "wC3EgxV9", "DN4kUIr8"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op GrantUserExp \
    --namespace $AB_NAMESPACE \
    --userId 'oSjPxbvZ' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 31 'GrantUserExp' test.out

#- 32 GrantUserPass
# body param: body
echo '{"passCode": "mo1kmi7b", "passItemId": "k69VZ93W"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op GrantUserPass \
    --namespace $AB_NAMESPACE \
    --userId 'wbFZfG5Z' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 32 'GrantUserPass' test.out

#- 33 ExistsAnyPassByPassCodes
$CLI_EXE \
    --sn seasonpass \
    --op ExistsAnyPassByPassCodes \
    --namespace $AB_NAMESPACE \
    --userId 'A3cRacY2' \
    --passCodes '["fOJjcRYq", "qZvmDgbr", "yNgYhVgb"]' \
    > test.out 2>&1
eval_tap $? 33 'ExistsAnyPassByPassCodes' test.out

#- 34 GetCurrentUserSeasonProgression
$CLI_EXE \
    --sn seasonpass \
    --op GetCurrentUserSeasonProgression \
    --namespace $AB_NAMESPACE \
    --userId 'KD9RhGwR' \
    > test.out 2>&1
eval_tap $? 34 'GetCurrentUserSeasonProgression' test.out

#- 35 CheckSeasonPurchasable
# body param: body
echo '{"passItemId": "tdBbL2L6", "tierItemCount": 53, "tierItemId": "GaUT7EvX"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op CheckSeasonPurchasable \
    --namespace $AB_NAMESPACE \
    --userId 'ohQWMR9k' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 35 'CheckSeasonPurchasable' test.out

#- 36 ResetUserSeason
$CLI_EXE \
    --sn seasonpass \
    --op ResetUserSeason \
    --namespace $AB_NAMESPACE \
    --userId 'ST31hfQh' \
    > test.out 2>&1
eval_tap $? 36 'ResetUserSeason' test.out

#- 37 GrantUserTier
# body param: body
echo '{"count": 18, "source": "PAID_FOR", "tags": ["6UvhiWBz", "y5yn16c4", "M9sOs2OE"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op GrantUserTier \
    --namespace $AB_NAMESPACE \
    --userId 'kzfShTOB' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 37 'GrantUserTier' test.out

#- 38 QueryUserExpGrantHistory
$CLI_EXE \
    --sn seasonpass \
    --op QueryUserExpGrantHistory \
    --namespace $AB_NAMESPACE \
    --userId 'vqYcaPmY' \
    --from 'OBK5IdGT' \
    --limit '6' \
    --offset '80' \
    --seasonId 'lI0w56As' \
    --source 'PAID_FOR' \
    --tags '["FfxrTHLE", "58bi5BLy", "TwYymMQo"]' \
    --to '5EX6TEme' \
    > test.out 2>&1
eval_tap $? 38 'QueryUserExpGrantHistory' test.out

#- 39 QueryUserExpGrantHistoryTag
$CLI_EXE \
    --sn seasonpass \
    --op QueryUserExpGrantHistoryTag \
    --namespace $AB_NAMESPACE \
    --userId 'Yec37Zmm' \
    --seasonId 'm3hbsd5w' \
    > test.out 2>&1
eval_tap $? 39 'QueryUserExpGrantHistoryTag' test.out

#- 40 GetUserSeason
$CLI_EXE \
    --sn seasonpass \
    --op GetUserSeason \
    --namespace $AB_NAMESPACE \
    --seasonId 'pVRLVubP' \
    --userId 'FQTU5gKK' \
    > test.out 2>&1
eval_tap $? 40 'GetUserSeason' test.out

#- 41 PublicGetCurrentSeason
$CLI_EXE \
    --sn seasonpass \
    --op PublicGetCurrentSeason \
    --namespace $AB_NAMESPACE \
    --language 'pals7O3s' \
    > test.out 2>&1
eval_tap $? 41 'PublicGetCurrentSeason' test.out

#- 42 PublicGetCurrentUserSeason
$CLI_EXE \
    --sn seasonpass \
    --op PublicGetCurrentUserSeason \
    --namespace $AB_NAMESPACE \
    --userId 'iqlUXuCV' \
    > test.out 2>&1
eval_tap $? 42 'PublicGetCurrentUserSeason' test.out

#- 43 PublicClaimUserReward
# body param: body
echo '{"passCode": "zTyRQMPJ", "rewardCode": "Okkr6SCs", "tierIndex": 18}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op PublicClaimUserReward \
    --namespace $AB_NAMESPACE \
    --userId 'zFkahCcZ' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 43 'PublicClaimUserReward' test.out

#- 44 PublicBulkClaimUserRewards
$CLI_EXE \
    --sn seasonpass \
    --op PublicBulkClaimUserRewards \
    --namespace $AB_NAMESPACE \
    --userId '0HSQtnkY' \
    > test.out 2>&1
eval_tap $? 44 'PublicBulkClaimUserRewards' test.out

#- 45 PublicGetUserSeason
$CLI_EXE \
    --sn seasonpass \
    --op PublicGetUserSeason \
    --namespace $AB_NAMESPACE \
    --seasonId 'VNhbhhwo' \
    --userId 'r6DlMaWu' \
    > test.out 2>&1
eval_tap $? 45 'PublicGetUserSeason' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE