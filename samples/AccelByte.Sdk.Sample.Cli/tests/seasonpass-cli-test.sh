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
echo "1..46"

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
    --limit '58' \
    --offset '24' \
    --status '["PUBLISHED", "PUBLISHED", "RETIRED"]' \
    > test.out 2>&1
eval_tap $? 3 'QuerySeasons' test.out

#- 4 CreateSeason
# body param: body
echo '{"autoClaim": true, "defaultLanguage": "1AvIMYrZ", "defaultRequiredExp": 47, "draftStoreId": "VshWZNic", "end": "1988-10-18T00:00:00Z", "excessStrategy": {"currency": "53tWcx8d", "method": "NONE", "percentPerExp": 53}, "images": [{"as": "xgzsdCS3", "caption": "l9cjOBec", "height": 95, "imageUrl": "7sU3WO0B", "smallImageUrl": "iNVJk16p", "width": 55}, {"as": "hdt6ed03", "caption": "agNrzlMM", "height": 26, "imageUrl": "cTVU31oa", "smallImageUrl": "w67rUdO7", "width": 29}, {"as": "3RrtT61b", "caption": "rfzLdm9Y", "height": 54, "imageUrl": "mGsFzcQm", "smallImageUrl": "aKUtRfMt", "width": 36}], "localizations": {"6P0yyLS2": {"description": "dzY4sIXL", "title": "w8MKINzN"}, "t63Iv2P3": {"description": "YRiXBg2o", "title": "Ty55mLXO"}, "WmOFc5bd": {"description": "xN76W9fh", "title": "6k5xkkm7"}}, "name": "nNoZPXPD", "start": "1985-06-17T00:00:00Z", "tierItemId": "OQ7sB3Rd"}' > $TEMP_JSON_INPUT
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
echo '{"userIds": ["ZilcMMUs", "yRSzoQaa", "oVrbsh0X"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op BulkGetUserSeasonProgression \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 6 'BulkGetUserSeasonProgression' test.out

#- 7 GetItemReferences
$CLI_EXE \
    --sn seasonpass \
    --op GetItemReferences \
    --namespace $AB_NAMESPACE \
    --itemId 'B3rGa4P6' \
    > test.out 2>&1
eval_tap $? 7 'GetItemReferences' test.out

#- 8 GetSeason
$CLI_EXE \
    --sn seasonpass \
    --op GetSeason \
    --namespace $AB_NAMESPACE \
    --seasonId 'c0WO2q85' \
    > test.out 2>&1
eval_tap $? 8 'GetSeason' test.out

#- 9 DeleteSeason
$CLI_EXE \
    --sn seasonpass \
    --op DeleteSeason \
    --namespace $AB_NAMESPACE \
    --seasonId 'xQJdQdpu' \
    > test.out 2>&1
eval_tap $? 9 'DeleteSeason' test.out

#- 10 UpdateSeason
# body param: body
echo '{"autoClaim": false, "defaultLanguage": "N6WpYvRL", "defaultRequiredExp": 69, "draftStoreId": "iZTco64x", "end": "1997-11-22T00:00:00Z", "excessStrategy": {"currency": "JfGN11tb", "method": "CURRENCY", "percentPerExp": 91}, "images": [{"as": "3eLlcTSx", "caption": "Orgr8eCT", "height": 91, "imageUrl": "6S3w6AUG", "smallImageUrl": "C5UhJT1i", "width": 51}, {"as": "31rfDmYr", "caption": "oBjlpuLY", "height": 100, "imageUrl": "hJhfRTJQ", "smallImageUrl": "pp6DlcTo", "width": 44}, {"as": "2Truedy0", "caption": "ZpF6y9zg", "height": 27, "imageUrl": "I5yjXy7w", "smallImageUrl": "jcxzzadY", "width": 20}], "localizations": {"ASlctEhs": {"description": "WqCvkRgH", "title": "8w46EGy8"}, "sZfpCCXP": {"description": "VB2HTukV", "title": "97keCl2M"}, "ZPQKs0RB": {"description": "TvuFEWhI", "title": "PfVFmp4e"}}, "name": "kLiXWkiJ", "start": "1996-02-05T00:00:00Z", "tierItemId": "4ZT0efcr"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op UpdateSeason \
    --namespace $AB_NAMESPACE \
    --seasonId 'dCFmnGWm' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 10 'UpdateSeason' test.out

#- 11 CloneSeason
# body param: body
echo '{"end": "1998-05-06T00:00:00Z", "name": "QokPQPdt", "start": "1992-09-02T00:00:00Z"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op CloneSeason \
    --namespace $AB_NAMESPACE \
    --seasonId 'dWhWQzxD' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 11 'CloneSeason' test.out

#- 12 GetFullSeason
$CLI_EXE \
    --sn seasonpass \
    --op GetFullSeason \
    --namespace $AB_NAMESPACE \
    --seasonId 'ji3VnPbR' \
    > test.out 2>&1
eval_tap $? 12 'GetFullSeason' test.out

#- 13 QueryPasses
$CLI_EXE \
    --sn seasonpass \
    --op QueryPasses \
    --namespace $AB_NAMESPACE \
    --seasonId 'g6Nmgwnj' \
    > test.out 2>&1
eval_tap $? 13 'QueryPasses' test.out

#- 14 CreatePass
# body param: body
echo '{"autoEnroll": true, "code": "Dnufdl8V", "displayOrder": 77, "images": [{"as": "v2Ws0pr0", "caption": "a5LH5B3H", "height": 12, "imageUrl": "uuAPCGgO", "smallImageUrl": "AnAQ8uu9", "width": 27}, {"as": "wyTb2Aqk", "caption": "WVq4YEif", "height": 16, "imageUrl": "l1fhXkKT", "smallImageUrl": "EaPUUu1S", "width": 71}, {"as": "RHNpn6VB", "caption": "G1t5Yi4f", "height": 19, "imageUrl": "XVe0IiHi", "smallImageUrl": "sdkyA3mm", "width": 91}], "localizations": {"yrqAa5K4": {"description": "MLtjAO79", "title": "ofeJSmvF"}, "LWVf59ZL": {"description": "ecAU4Olr", "title": "jnkov00o"}, "uu95tWFf": {"description": "YwdD6ak0", "title": "mDbNO675"}}, "passItemId": "JVvLpLBZ"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op CreatePass \
    --namespace $AB_NAMESPACE \
    --seasonId '3LIsw1B6' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 14 'CreatePass' test.out

#- 15 GetPass
$CLI_EXE \
    --sn seasonpass \
    --op GetPass \
    --code 'JXRbNjep' \
    --namespace $AB_NAMESPACE \
    --seasonId '3WtMAFBE' \
    > test.out 2>&1
eval_tap $? 15 'GetPass' test.out

#- 16 DeletePass
$CLI_EXE \
    --sn seasonpass \
    --op DeletePass \
    --code 'YpuXuT21' \
    --namespace $AB_NAMESPACE \
    --seasonId 'nppuVT5M' \
    > test.out 2>&1
eval_tap $? 16 'DeletePass' test.out

#- 17 UpdatePass
# body param: body
echo '{"autoEnroll": false, "displayOrder": 61, "images": [{"as": "34zLpQGS", "caption": "YC6fM0Fd", "height": 86, "imageUrl": "56YNhrDb", "smallImageUrl": "ArLnoPPx", "width": 47}, {"as": "7MCgATqP", "caption": "Td28fZSI", "height": 12, "imageUrl": "DjnpFQlg", "smallImageUrl": "wSVayjqJ", "width": 26}, {"as": "3dv1jyTm", "caption": "mn338vHn", "height": 56, "imageUrl": "tbUGYkrK", "smallImageUrl": "k7nsFzpe", "width": 78}], "localizations": {"YNJUttql": {"description": "sAS3Nneb", "title": "bHt9VzDv"}, "sh4DW7K1": {"description": "5yQRF8bS", "title": "83K9jB1k"}, "aiPUyfAE": {"description": "JhpgI4kS", "title": "p1oV1inK"}}, "passItemId": "6FmsglN0"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op UpdatePass \
    --code 'ympJu7St' \
    --namespace $AB_NAMESPACE \
    --seasonId '6EjY29t6' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 17 'UpdatePass' test.out

#- 18 PublishSeason
$CLI_EXE \
    --sn seasonpass \
    --op PublishSeason \
    --namespace $AB_NAMESPACE \
    --seasonId 'Ei2HA5Rr' \
    > test.out 2>&1
eval_tap $? 18 'PublishSeason' test.out

#- 19 RetireSeason
$CLI_EXE \
    --sn seasonpass \
    --op RetireSeason \
    --namespace $AB_NAMESPACE \
    --seasonId 'UzAetazE' \
    --force 'true' \
    > test.out 2>&1
eval_tap $? 19 'RetireSeason' test.out

#- 20 QueryRewards
$CLI_EXE \
    --sn seasonpass \
    --op QueryRewards \
    --namespace $AB_NAMESPACE \
    --seasonId 'Oou40mi6' \
    --q 'kVLAdI9Q' \
    > test.out 2>&1
eval_tap $? 20 'QueryRewards' test.out

#- 21 CreateReward
# body param: body
echo '{"code": "4MyI3hEM", "currency": {"currencyCode": "8XWgiu8b", "namespace": "AkV6byMZ"}, "image": {"as": "4rrC0u5Q", "caption": "VTNu80TA", "height": 85, "imageUrl": "PsK9Ua5C", "smallImageUrl": "81jRRaFt", "width": 5}, "itemId": "DvYP9nsJ", "quantity": 36, "type": "ITEM"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op CreateReward \
    --namespace $AB_NAMESPACE \
    --seasonId 'WatV4oJR' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 21 'CreateReward' test.out

#- 22 GetReward
$CLI_EXE \
    --sn seasonpass \
    --op GetReward \
    --code 'Ah2X8kcR' \
    --namespace $AB_NAMESPACE \
    --seasonId 'w9M5V1hu' \
    > test.out 2>&1
eval_tap $? 22 'GetReward' test.out

#- 23 DeleteReward
$CLI_EXE \
    --sn seasonpass \
    --op DeleteReward \
    --code 'AWQvORgV' \
    --namespace $AB_NAMESPACE \
    --seasonId 'FgrDMasx' \
    > test.out 2>&1
eval_tap $? 23 'DeleteReward' test.out

#- 24 UpdateReward
# body param: body
echo '{"currency": {"currencyCode": "2kmoi5D1", "namespace": "DeSBvuIZ"}, "image": {"as": "jhStgGGN", "caption": "KgxOegVN", "height": 41, "imageUrl": "lb0B2YM3", "smallImageUrl": "2OV8tVpX", "width": 16}, "itemId": "YEiRObuw", "nullFields": ["L7y6yeRS", "4I4LGe9f", "lmVYH4cm"], "quantity": 21, "type": "CURRENCY"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op UpdateReward \
    --code 'Kd7KLGLk' \
    --namespace $AB_NAMESPACE \
    --seasonId 'vAOoly6L' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 24 'UpdateReward' test.out

#- 25 QueryTiers
$CLI_EXE \
    --sn seasonpass \
    --op QueryTiers \
    --namespace $AB_NAMESPACE \
    --seasonId 'IQUs6VEb' \
    --limit '20' \
    --offset '2' \
    > test.out 2>&1
eval_tap $? 25 'QueryTiers' test.out

#- 26 CreateTier
# body param: body
echo '{"index": 66, "quantity": 38, "tier": {"requiredExp": 83, "rewards": {"4TBYJ0kA": ["VKWDBgOh", "D0B7dwky", "XObSvLMe"], "jVJMc7bP": ["HrZG6q5e", "RAS0KmB9", "HaRt1n6D"], "shuNsQIB": ["VbKW7w8U", "znvdkO1k", "Oev8WohE"]}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op CreateTier \
    --namespace $AB_NAMESPACE \
    --seasonId 'lyRI8ZHW' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 26 'CreateTier' test.out

#- 27 UpdateTier
# body param: body
echo '{"requiredExp": 13, "rewards": {"id7fhyr7": ["u31HovBi", "adlAha6i", "z364g006"], "830j7uae": ["YTZZY5em", "7adNXqud", "9MAkS8In"], "sCarkDzD": ["J7Idqmws", "rrpNlGEw", "gygiLMIp"]}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op UpdateTier \
    --id 'KWLvuCc1' \
    --namespace $AB_NAMESPACE \
    --seasonId 'F08Lv9wd' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 27 'UpdateTier' test.out

#- 28 DeleteTier
$CLI_EXE \
    --sn seasonpass \
    --op DeleteTier \
    --id 'H58q7nGs' \
    --namespace $AB_NAMESPACE \
    --seasonId 'Mm1n4X5o' \
    > test.out 2>&1
eval_tap $? 28 'DeleteTier' test.out

#- 29 ReorderTier
# body param: body
echo '{"newIndex": 75}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op ReorderTier \
    --id '8XUsbOxT' \
    --namespace $AB_NAMESPACE \
    --seasonId 'JhdcLuwv' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 29 'ReorderTier' test.out

#- 30 UnpublishSeason
$CLI_EXE \
    --sn seasonpass \
    --op UnpublishSeason \
    --namespace $AB_NAMESPACE \
    --seasonId 'J4AJyuTV' \
    --force 'true' \
    > test.out 2>&1
eval_tap $? 30 'UnpublishSeason' test.out

#- 31 GetUserParticipatedSeasons
$CLI_EXE \
    --sn seasonpass \
    --op GetUserParticipatedSeasons \
    --namespace $AB_NAMESPACE \
    --userId 'Cjg4CpKU' \
    --limit '35' \
    --offset '85' \
    > test.out 2>&1
eval_tap $? 31 'GetUserParticipatedSeasons' test.out

#- 32 GrantUserExp
# body param: body
echo '{"exp": 99, "source": "SWEAT", "tags": ["mYLcnglT", "hHTto46u", "p6R4Couq"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op GrantUserExp \
    --namespace $AB_NAMESPACE \
    --userId 'udfNrgOF' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 32 'GrantUserExp' test.out

#- 33 GrantUserPass
# body param: body
echo '{"passCode": "8ModAwNk", "passItemId": "iJNnh4xY"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op GrantUserPass \
    --namespace $AB_NAMESPACE \
    --userId 'yWUBpiRm' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 33 'GrantUserPass' test.out

#- 34 ExistsAnyPassByPassCodes
$CLI_EXE \
    --sn seasonpass \
    --op ExistsAnyPassByPassCodes \
    --namespace $AB_NAMESPACE \
    --userId '2Jx8AM4a' \
    --passCodes '["6t6RwotO", "HP0qlKEo", "XIRuRCPX"]' \
    > test.out 2>&1
eval_tap $? 34 'ExistsAnyPassByPassCodes' test.out

#- 35 GetCurrentUserSeasonProgression
$CLI_EXE \
    --sn seasonpass \
    --op GetCurrentUserSeasonProgression \
    --namespace $AB_NAMESPACE \
    --userId 'yuEVgDnX' \
    > test.out 2>&1
eval_tap $? 35 'GetCurrentUserSeasonProgression' test.out

#- 36 CheckSeasonPurchasable
# body param: body
echo '{"passItemId": "zw1mmH8w", "tierItemCount": 72, "tierItemId": "TzAwz7lz"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op CheckSeasonPurchasable \
    --namespace $AB_NAMESPACE \
    --userId 'eccnUEVd' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 36 'CheckSeasonPurchasable' test.out

#- 37 ResetUserSeason
$CLI_EXE \
    --sn seasonpass \
    --op ResetUserSeason \
    --namespace $AB_NAMESPACE \
    --userId 'HNEM1Bjc' \
    > test.out 2>&1
eval_tap $? 37 'ResetUserSeason' test.out

#- 38 GrantUserTier
# body param: body
echo '{"count": 94, "source": "SWEAT", "tags": ["oFl5BglA", "LkHGcpoV", "d6upxOfL"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op GrantUserTier \
    --namespace $AB_NAMESPACE \
    --userId '5xMtOvDV' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 38 'GrantUserTier' test.out

#- 39 QueryUserExpGrantHistory
$CLI_EXE \
    --sn seasonpass \
    --op QueryUserExpGrantHistory \
    --namespace $AB_NAMESPACE \
    --userId 'lK2kSMcv' \
    --from 'EcbXvu9W' \
    --limit '13' \
    --offset '10' \
    --seasonId 'DczBRch8' \
    --source 'PAID_FOR' \
    --tags '["i0qyBycJ", "p0GgvDFg", "khARIzpE"]' \
    --to 'wlfK0I6R' \
    > test.out 2>&1
eval_tap $? 39 'QueryUserExpGrantHistory' test.out

#- 40 QueryUserExpGrantHistoryTag
$CLI_EXE \
    --sn seasonpass \
    --op QueryUserExpGrantHistoryTag \
    --namespace $AB_NAMESPACE \
    --userId 'bpSVl9Iq' \
    --seasonId 'TS4u3yIQ' \
    > test.out 2>&1
eval_tap $? 40 'QueryUserExpGrantHistoryTag' test.out

#- 41 GetUserSeason
$CLI_EXE \
    --sn seasonpass \
    --op GetUserSeason \
    --namespace $AB_NAMESPACE \
    --seasonId 'XBlGX7A2' \
    --userId 'IOo00fiW' \
    > test.out 2>&1
eval_tap $? 41 'GetUserSeason' test.out

#- 42 PublicGetCurrentSeason
$CLI_EXE \
    --sn seasonpass \
    --op PublicGetCurrentSeason \
    --namespace $AB_NAMESPACE \
    --language 'PqLSfluH' \
    > test.out 2>&1
eval_tap $? 42 'PublicGetCurrentSeason' test.out

#- 43 PublicGetCurrentUserSeason
$CLI_EXE \
    --sn seasonpass \
    --op PublicGetCurrentUserSeason \
    --namespace $AB_NAMESPACE \
    --userId 'EtdG0YNs' \
    > test.out 2>&1
eval_tap $? 43 'PublicGetCurrentUserSeason' test.out

#- 44 PublicClaimUserReward
# body param: body
echo '{"passCode": "VFgaBRXr", "rewardCode": "N5OYDxii", "tierIndex": 18}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op PublicClaimUserReward \
    --namespace $AB_NAMESPACE \
    --userId 'JmirMX3d' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 44 'PublicClaimUserReward' test.out

#- 45 PublicBulkClaimUserRewards
$CLI_EXE \
    --sn seasonpass \
    --op PublicBulkClaimUserRewards \
    --namespace $AB_NAMESPACE \
    --userId 'nJkcp8WB' \
    > test.out 2>&1
eval_tap $? 45 'PublicBulkClaimUserRewards' test.out

#- 46 PublicGetUserSeason
$CLI_EXE \
    --sn seasonpass \
    --op PublicGetUserSeason \
    --namespace $AB_NAMESPACE \
    --seasonId 'oBXwbBd3' \
    --userId 'KxQlGQFK' \
    > test.out 2>&1
eval_tap $? 46 'PublicGetUserSeason' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE