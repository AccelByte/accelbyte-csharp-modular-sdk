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
    --limit '54' \
    --offset '13' \
    --status '["PUBLISHED", "PUBLISHED", "DRAFT"]' \
    > test.out 2>&1
eval_tap $? 3 'QuerySeasons' test.out

#- 4 CreateSeason
# body param: body
echo '{"autoClaim": false, "defaultLanguage": "3fuEAQsp", "defaultRequiredExp": 56, "draftStoreId": "02eqKibI", "end": "1994-12-25T00:00:00Z", "excessStrategy": {"currency": "tY3iTtsE", "method": "CURRENCY", "percentPerExp": 86}, "images": [{"as": "sqbeZPTj", "caption": "lG9AfiZl", "height": 34, "imageUrl": "g7WQYx3I", "smallImageUrl": "kuJCkoL7", "width": 83}, {"as": "WYChF85V", "caption": "s24Rh4gP", "height": 9, "imageUrl": "722idn8b", "smallImageUrl": "H2w4xf9k", "width": 0}, {"as": "w7zY8nB0", "caption": "okneOgDk", "height": 66, "imageUrl": "xV88VDLe", "smallImageUrl": "NfR3MPx0", "width": 93}], "localizations": {"gwMZ3dcD": {"description": "cNrP97jL", "title": "Uf4t9Usi"}, "smhpHvKP": {"description": "hjoCJ6H1", "title": "1IqWi5Pi"}, "mynhXQBr": {"description": "kCuKZFsC", "title": "YDL6tRoM"}}, "name": "vfF61xz4", "start": "1999-12-16T00:00:00Z", "tierItemId": "RuXdTFH6"}' > $TEMP_JSON_INPUT
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
echo '{"userIds": ["DCzrlay4", "wGPNdWuX", "h9mHAB6N"]}' > $TEMP_JSON_INPUT
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
    --seasonId 'ZpzM6Met' \
    > test.out 2>&1
eval_tap $? 7 'GetSeason' test.out

#- 8 DeleteSeason
$CLI_EXE \
    --sn seasonpass \
    --op DeleteSeason \
    --namespace $AB_NAMESPACE \
    --seasonId 'mycbFvE3' \
    > test.out 2>&1
eval_tap $? 8 'DeleteSeason' test.out

#- 9 UpdateSeason
# body param: body
echo '{"autoClaim": true, "defaultLanguage": "kZM7E57Z", "defaultRequiredExp": 58, "draftStoreId": "7UYELuSh", "end": "1995-04-26T00:00:00Z", "excessStrategy": {"currency": "XTQBasJ1", "method": "CURRENCY", "percentPerExp": 16}, "images": [{"as": "sTLKvFhq", "caption": "OWjg4Eyl", "height": 26, "imageUrl": "WGVfhISE", "smallImageUrl": "t8dr0eO0", "width": 45}, {"as": "VjJAWW7K", "caption": "qZP1s07I", "height": 57, "imageUrl": "95ZBxcLj", "smallImageUrl": "MB03bsAn", "width": 15}, {"as": "KOiALVuI", "caption": "hdzDQjCM", "height": 60, "imageUrl": "nEsG81u6", "smallImageUrl": "k1IDdYQA", "width": 99}], "localizations": {"4S8UXyDl": {"description": "kjLqOmJL", "title": "cSUN9UrY"}, "5N1Gu4m6": {"description": "T2QLTywL", "title": "ZFz4T6TG"}, "sugCNspZ": {"description": "WCbdNFQc", "title": "msuDcxHA"}}, "name": "ojPS0vy8", "start": "1991-06-15T00:00:00Z", "tierItemId": "CfWfVFK3"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op UpdateSeason \
    --namespace $AB_NAMESPACE \
    --seasonId 'IUjmcrBF' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 9 'UpdateSeason' test.out

#- 10 CloneSeason
# body param: body
echo '{"end": "1979-10-03T00:00:00Z", "name": "jOVIYTMG", "start": "1982-09-07T00:00:00Z"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op CloneSeason \
    --namespace $AB_NAMESPACE \
    --seasonId 'pHbQ1hta' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 10 'CloneSeason' test.out

#- 11 GetFullSeason
$CLI_EXE \
    --sn seasonpass \
    --op GetFullSeason \
    --namespace $AB_NAMESPACE \
    --seasonId 'AlaO9n56' \
    > test.out 2>&1
eval_tap $? 11 'GetFullSeason' test.out

#- 12 QueryPasses
$CLI_EXE \
    --sn seasonpass \
    --op QueryPasses \
    --namespace $AB_NAMESPACE \
    --seasonId 'MbodDifM' \
    > test.out 2>&1
eval_tap $? 12 'QueryPasses' test.out

#- 13 CreatePass
# body param: body
echo '{"autoEnroll": false, "code": "L6dAemxf", "displayOrder": 12, "images": [{"as": "CKKyDfiv", "caption": "63REWMrc", "height": 79, "imageUrl": "BxjAVjMn", "smallImageUrl": "axNykLnq", "width": 16}, {"as": "UwyggUvu", "caption": "oqf3uytS", "height": 8, "imageUrl": "TXMY1NFv", "smallImageUrl": "tuzQsk34", "width": 57}, {"as": "v8FskVdp", "caption": "FH5KH7Cx", "height": 6, "imageUrl": "OsdqfN4Y", "smallImageUrl": "1qb3gk1O", "width": 78}], "localizations": {"yx9LP4w7": {"description": "LrAwR6MK", "title": "42DHQZ0l"}, "SJigfRJ0": {"description": "2w7sq7pl", "title": "EkXQFCmD"}, "hJreXUOK": {"description": "HfXlC85P", "title": "vOwstYsq"}}, "passItemId": "xpjkGED7"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op CreatePass \
    --namespace $AB_NAMESPACE \
    --seasonId 'ywzzxDoM' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 13 'CreatePass' test.out

#- 14 GetPass
$CLI_EXE \
    --sn seasonpass \
    --op GetPass \
    --code '97odvn3y' \
    --namespace $AB_NAMESPACE \
    --seasonId '5AgJ08HC' \
    > test.out 2>&1
eval_tap $? 14 'GetPass' test.out

#- 15 DeletePass
$CLI_EXE \
    --sn seasonpass \
    --op DeletePass \
    --code '7jEraUjC' \
    --namespace $AB_NAMESPACE \
    --seasonId 'bnLCzOnG' \
    > test.out 2>&1
eval_tap $? 15 'DeletePass' test.out

#- 16 UpdatePass
# body param: body
echo '{"autoEnroll": true, "displayOrder": 99, "images": [{"as": "UHknNQ0V", "caption": "WnnXoeAm", "height": 70, "imageUrl": "ZbKBTGNp", "smallImageUrl": "igv7wN3n", "width": 29}, {"as": "84YjKI5U", "caption": "EZPDhvj0", "height": 91, "imageUrl": "oV15EoDu", "smallImageUrl": "P20suVbb", "width": 18}, {"as": "RnacWHbV", "caption": "RbjruiCy", "height": 15, "imageUrl": "dPkaXJeh", "smallImageUrl": "iFd2m1Em", "width": 76}], "localizations": {"UfbB7pLv": {"description": "9JAGkh4x", "title": "3sh82ffu"}, "aIRcMXSu": {"description": "ol5QNSEz", "title": "N7pvq1Kd"}, "rtRNtlYB": {"description": "BjmWYcvb", "title": "Mpw5CpXe"}}, "passItemId": "G7npZ3LU"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op UpdatePass \
    --code 'kst0n8yL' \
    --namespace $AB_NAMESPACE \
    --seasonId '7fuDeumH' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 16 'UpdatePass' test.out

#- 17 PublishSeason
$CLI_EXE \
    --sn seasonpass \
    --op PublishSeason \
    --namespace $AB_NAMESPACE \
    --seasonId 'n2jvTIGr' \
    > test.out 2>&1
eval_tap $? 17 'PublishSeason' test.out

#- 18 RetireSeason
$CLI_EXE \
    --sn seasonpass \
    --op RetireSeason \
    --namespace $AB_NAMESPACE \
    --seasonId 'cwnWUslR' \
    --force 'false' \
    > test.out 2>&1
eval_tap $? 18 'RetireSeason' test.out

#- 19 QueryRewards
$CLI_EXE \
    --sn seasonpass \
    --op QueryRewards \
    --namespace $AB_NAMESPACE \
    --seasonId 'vfplggJI' \
    --q 'rIlrlCla' \
    > test.out 2>&1
eval_tap $? 19 'QueryRewards' test.out

#- 20 CreateReward
# body param: body
echo '{"code": "xYVcnZ7R", "currency": {"currencyCode": "4iLS1EzA", "namespace": "rscLh3qp"}, "image": {"as": "45vTqxlI", "caption": "j6rLUCU3", "height": 20, "imageUrl": "2UKLXVzM", "smallImageUrl": "94RI9lvH", "width": 67}, "itemId": "D8wiTcUj", "quantity": 34, "type": "CURRENCY"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op CreateReward \
    --namespace $AB_NAMESPACE \
    --seasonId 'XN3Shfcl' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 20 'CreateReward' test.out

#- 21 GetReward
$CLI_EXE \
    --sn seasonpass \
    --op GetReward \
    --code 'LqsvoY6V' \
    --namespace $AB_NAMESPACE \
    --seasonId 'WT03kNRZ' \
    > test.out 2>&1
eval_tap $? 21 'GetReward' test.out

#- 22 DeleteReward
$CLI_EXE \
    --sn seasonpass \
    --op DeleteReward \
    --code 'V8Je3BVl' \
    --namespace $AB_NAMESPACE \
    --seasonId 'XgidvAG4' \
    > test.out 2>&1
eval_tap $? 22 'DeleteReward' test.out

#- 23 UpdateReward
# body param: body
echo '{"currency": {"currencyCode": "89tLeDNq", "namespace": "jqoq160m"}, "image": {"as": "FVLfTmrG", "caption": "gGknBfzy", "height": 12, "imageUrl": "zYpEzlPg", "smallImageUrl": "tVhNnuRM", "width": 81}, "itemId": "926rPSaQ", "nullFields": ["7BnbDey3", "J1RLLp7u", "gGyHmRgr"], "quantity": 38, "type": "ITEM"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op UpdateReward \
    --code 'jx5ylmvX' \
    --namespace $AB_NAMESPACE \
    --seasonId 'BeDjiZaq' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 23 'UpdateReward' test.out

#- 24 QueryTiers
$CLI_EXE \
    --sn seasonpass \
    --op QueryTiers \
    --namespace $AB_NAMESPACE \
    --seasonId '7LS1UeTV' \
    --limit '86' \
    --offset '38' \
    > test.out 2>&1
eval_tap $? 24 'QueryTiers' test.out

#- 25 CreateTier
# body param: body
echo '{"index": 95, "quantity": 10, "tier": {"requiredExp": 39, "rewards": {"o6sobE80": ["4Mt8vnGX", "4HRmjci1", "xGEsidDg"], "b8ikImku": ["qrJojUNC", "lgCdRp0e", "8j2mESEr"], "UyqEulZh": ["9x6TtQUP", "U73DDiuS", "KhIKVKcH"]}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op CreateTier \
    --namespace $AB_NAMESPACE \
    --seasonId 'cn7gjL0T' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 25 'CreateTier' test.out

#- 26 UpdateTier
# body param: body
echo '{"requiredExp": 16, "rewards": {"5yMMyuGc": ["KZYCzjV4", "cmNJzbVi", "0A2oHPuO"], "Qqgua6tq": ["f37IsuIa", "GEv822VF", "Gfc1rT09"], "8FJ9MNjB": ["02Ib54PM", "hAcPohM9", "AuBSu3Yi"]}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op UpdateTier \
    --id 'yEzIDTng' \
    --namespace $AB_NAMESPACE \
    --seasonId 'NSkyvXh8' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 26 'UpdateTier' test.out

#- 27 DeleteTier
$CLI_EXE \
    --sn seasonpass \
    --op DeleteTier \
    --id 'luc2HznY' \
    --namespace $AB_NAMESPACE \
    --seasonId '8kLOjJjj' \
    > test.out 2>&1
eval_tap $? 27 'DeleteTier' test.out

#- 28 ReorderTier
# body param: body
echo '{"newIndex": 12}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op ReorderTier \
    --id 'qNYrabK5' \
    --namespace $AB_NAMESPACE \
    --seasonId 'Oc9B8v4y' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 28 'ReorderTier' test.out

#- 29 UnpublishSeason
$CLI_EXE \
    --sn seasonpass \
    --op UnpublishSeason \
    --namespace $AB_NAMESPACE \
    --seasonId 'YYJWCf0v' \
    --force 'true' \
    > test.out 2>&1
eval_tap $? 29 'UnpublishSeason' test.out

#- 30 GetUserParticipatedSeasons
$CLI_EXE \
    --sn seasonpass \
    --op GetUserParticipatedSeasons \
    --namespace $AB_NAMESPACE \
    --userId 'fEhjReaM' \
    --limit '93' \
    --offset '41' \
    > test.out 2>&1
eval_tap $? 30 'GetUserParticipatedSeasons' test.out

#- 31 GrantUserExp
# body param: body
echo '{"exp": 25, "source": "SWEAT", "tags": ["34T8uUI6", "wJ7QxxhT", "tsmtEBu4"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op GrantUserExp \
    --namespace $AB_NAMESPACE \
    --userId 'nLdIV8wl' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 31 'GrantUserExp' test.out

#- 32 GrantUserPass
# body param: body
echo '{"passCode": "MKi7ZXMH", "passItemId": "vbXcsGef"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op GrantUserPass \
    --namespace $AB_NAMESPACE \
    --userId 'gtpYyCq4' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 32 'GrantUserPass' test.out

#- 33 ExistsAnyPassByPassCodes
$CLI_EXE \
    --sn seasonpass \
    --op ExistsAnyPassByPassCodes \
    --namespace $AB_NAMESPACE \
    --userId 'WG5CY8TY' \
    --passCodes '["zh0k0Syj", "ooHslTiA", "mmPAlITX"]' \
    > test.out 2>&1
eval_tap $? 33 'ExistsAnyPassByPassCodes' test.out

#- 34 GetCurrentUserSeasonProgression
$CLI_EXE \
    --sn seasonpass \
    --op GetCurrentUserSeasonProgression \
    --namespace $AB_NAMESPACE \
    --userId '59QCoIvd' \
    > test.out 2>&1
eval_tap $? 34 'GetCurrentUserSeasonProgression' test.out

#- 35 CheckSeasonPurchasable
# body param: body
echo '{"passItemId": "XCGFgxZ5", "tierItemCount": 8, "tierItemId": "gCmHvDxC"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op CheckSeasonPurchasable \
    --namespace $AB_NAMESPACE \
    --userId 'BDkmFjly' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 35 'CheckSeasonPurchasable' test.out

#- 36 ResetUserSeason
$CLI_EXE \
    --sn seasonpass \
    --op ResetUserSeason \
    --namespace $AB_NAMESPACE \
    --userId 'LKYDmjFh' \
    > test.out 2>&1
eval_tap $? 36 'ResetUserSeason' test.out

#- 37 GrantUserTier
# body param: body
echo '{"count": 87, "source": "SWEAT", "tags": ["dM8Cm1SV", "sK3Z7Wuw", "ktDHV28t"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op GrantUserTier \
    --namespace $AB_NAMESPACE \
    --userId 'UhmUmEnj' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 37 'GrantUserTier' test.out

#- 38 QueryUserExpGrantHistory
$CLI_EXE \
    --sn seasonpass \
    --op QueryUserExpGrantHistory \
    --namespace $AB_NAMESPACE \
    --userId 'ZthvNyCw' \
    --from 'kZSkJ4oM' \
    --limit '74' \
    --offset '62' \
    --seasonId 'UsF7y3kN' \
    --source 'SWEAT' \
    --tags '["NMUIjNL4", "EsxtbJ6t", "2s1EDOKi"]' \
    --to 'svPwLW4G' \
    > test.out 2>&1
eval_tap $? 38 'QueryUserExpGrantHistory' test.out

#- 39 QueryUserExpGrantHistoryTag
$CLI_EXE \
    --sn seasonpass \
    --op QueryUserExpGrantHistoryTag \
    --namespace $AB_NAMESPACE \
    --userId 'B68tVJzr' \
    --seasonId 'bOClyOpG' \
    > test.out 2>&1
eval_tap $? 39 'QueryUserExpGrantHistoryTag' test.out

#- 40 GetUserSeason
$CLI_EXE \
    --sn seasonpass \
    --op GetUserSeason \
    --namespace $AB_NAMESPACE \
    --seasonId '21Zfscw2' \
    --userId 'pAsbE3bR' \
    > test.out 2>&1
eval_tap $? 40 'GetUserSeason' test.out

#- 41 PublicGetCurrentSeason
$CLI_EXE \
    --sn seasonpass \
    --op PublicGetCurrentSeason \
    --namespace $AB_NAMESPACE \
    --language 'Mz1FClnz' \
    > test.out 2>&1
eval_tap $? 41 'PublicGetCurrentSeason' test.out

#- 42 PublicGetCurrentUserSeason
$CLI_EXE \
    --sn seasonpass \
    --op PublicGetCurrentUserSeason \
    --namespace $AB_NAMESPACE \
    --userId '9x0FcDUM' \
    > test.out 2>&1
eval_tap $? 42 'PublicGetCurrentUserSeason' test.out

#- 43 PublicClaimUserReward
# body param: body
echo '{"passCode": "f008dqc8", "rewardCode": "Q4DoO93d", "tierIndex": 21}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op PublicClaimUserReward \
    --namespace $AB_NAMESPACE \
    --userId 'Ku9w7Dmk' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 43 'PublicClaimUserReward' test.out

#- 44 PublicBulkClaimUserRewards
$CLI_EXE \
    --sn seasonpass \
    --op PublicBulkClaimUserRewards \
    --namespace $AB_NAMESPACE \
    --userId 'JfzMOGsN' \
    > test.out 2>&1
eval_tap $? 44 'PublicBulkClaimUserRewards' test.out

#- 45 PublicGetUserSeason
$CLI_EXE \
    --sn seasonpass \
    --op PublicGetUserSeason \
    --namespace $AB_NAMESPACE \
    --seasonId 'zpVwP0hT' \
    --userId 'VLQxviOA' \
    > test.out 2>&1
eval_tap $? 45 'PublicGetUserSeason' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE