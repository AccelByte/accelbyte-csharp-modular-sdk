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
echo "1..44"

#- 1 Login
$CLI_EXE --op login --lt user --user user --pass user > test.out 2>&1
eval_tap $? 1 'Login' test.out

if [ $EXIT_CODE -ne 0 ]; then
  echo "Bail out! Login failed."
  exit $EXIT_CODE
fi

# echo "foo" > "$CLI_TOKEN_FILE"

#- 2 QuerySeasons
$CLI_EXE \
    --sn seasonpass \
    --op QuerySeasons \
    --namespace $AB_NAMESPACE \
    --limit '7' \
    --offset '44' \
    --status '["RETIRED", "PUBLISHED", "DRAFT"]' \
    > test.out 2>&1
eval_tap $? 2 'QuerySeasons' test.out

#- 3 CreateSeason
# body param: body
echo '{"autoClaim": false, "defaultLanguage": "E6f7Rlt4", "defaultRequiredExp": 41, "draftStoreId": "pCIpciF7", "end": "1995-06-06T00:00:00Z", "excessStrategy": {"currency": "Y6loazaP", "method": "CURRENCY", "percentPerExp": 27}, "images": [{"as": "IImCovZN", "caption": "S3Dzrx8b", "height": 43, "imageUrl": "rWOmKIxy", "smallImageUrl": "kuZHhEYw", "width": 23}, {"as": "6wQ69G7x", "caption": "ubqm90GA", "height": 50, "imageUrl": "t59WAXdg", "smallImageUrl": "HpjQcxrd", "width": 81}, {"as": "B2nDoiPp", "caption": "D12O0kLW", "height": 27, "imageUrl": "TpFYWVE5", "smallImageUrl": "3aYVUNzH", "width": 1}], "localizations": {"AwZFVacW": {"description": "iRKJENxy", "title": "ZPWa6Pmw"}, "8il7Xbf2": {"description": "ENKa2i4v", "title": "I7IyETrY"}, "VYC4HIeH": {"description": "J7oR90nJ", "title": "P1yYuF6z"}}, "name": "KGHMfom7", "start": "1994-08-13T00:00:00Z", "tierItemId": "OjTBrAyu"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op CreateSeason \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 3 'CreateSeason' test.out

#- 4 GetCurrentSeason
$CLI_EXE \
    --sn seasonpass \
    --op GetCurrentSeason \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 4 'GetCurrentSeason' test.out

#- 5 BulkGetUserSeasonProgression
# body param: body
echo '{"userIds": ["ZMh8vTUw", "zwKMS1Xh", "zLziy7CX"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op BulkGetUserSeasonProgression \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 5 'BulkGetUserSeasonProgression' test.out

#- 6 GetSeason
$CLI_EXE \
    --sn seasonpass \
    --op GetSeason \
    --namespace $AB_NAMESPACE \
    --seasonId 'tzXaIWOl' \
    > test.out 2>&1
eval_tap $? 6 'GetSeason' test.out

#- 7 DeleteSeason
$CLI_EXE \
    --sn seasonpass \
    --op DeleteSeason \
    --namespace $AB_NAMESPACE \
    --seasonId 'aubRwIFa' \
    > test.out 2>&1
eval_tap $? 7 'DeleteSeason' test.out

#- 8 UpdateSeason
# body param: body
echo '{"autoClaim": true, "defaultLanguage": "E6cEiKd6", "defaultRequiredExp": 31, "draftStoreId": "HkSx3Pkv", "end": "1989-04-01T00:00:00Z", "excessStrategy": {"currency": "BcpVWxJD", "method": "CURRENCY", "percentPerExp": 83}, "images": [{"as": "ckFWl5XM", "caption": "PdcvsKPj", "height": 86, "imageUrl": "zZ1KJhEP", "smallImageUrl": "AJmQSdzD", "width": 43}, {"as": "J59SvzQV", "caption": "jFzEeD95", "height": 8, "imageUrl": "rnKFR219", "smallImageUrl": "MqIUOxby", "width": 47}, {"as": "K9SSUn87", "caption": "JNVBPaCf", "height": 20, "imageUrl": "dNFvm3VR", "smallImageUrl": "Seer0WAE", "width": 12}], "localizations": {"1etqczep": {"description": "XWXcUWgM", "title": "qNbMWuZD"}, "Kix66EAE": {"description": "bV3RmiKb", "title": "94VAjIwl"}, "0r4G3llN": {"description": "3bZkeOB4", "title": "PrUnMRZk"}}, "name": "YQEicUXY", "start": "1985-06-21T00:00:00Z", "tierItemId": "aG4iurV6"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op UpdateSeason \
    --namespace $AB_NAMESPACE \
    --seasonId 'HuLbxNSR' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 8 'UpdateSeason' test.out

#- 9 CloneSeason
# body param: body
echo '{"end": "1978-08-27T00:00:00Z", "name": "I7l8W3eL", "start": "1990-12-05T00:00:00Z"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op CloneSeason \
    --namespace $AB_NAMESPACE \
    --seasonId 'yN1zRnKH' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 9 'CloneSeason' test.out

#- 10 GetFullSeason
$CLI_EXE \
    --sn seasonpass \
    --op GetFullSeason \
    --namespace $AB_NAMESPACE \
    --seasonId 'jt0aEinT' \
    > test.out 2>&1
eval_tap $? 10 'GetFullSeason' test.out

#- 11 QueryPasses
$CLI_EXE \
    --sn seasonpass \
    --op QueryPasses \
    --namespace $AB_NAMESPACE \
    --seasonId 'E8kFa7IZ' \
    > test.out 2>&1
eval_tap $? 11 'QueryPasses' test.out

#- 12 CreatePass
# body param: body
echo '{"autoEnroll": false, "code": "Ssw3xuLT", "displayOrder": 100, "images": [{"as": "0ylj8V2z", "caption": "DskyMSzM", "height": 21, "imageUrl": "4mdgydOB", "smallImageUrl": "YHGRTyWJ", "width": 5}, {"as": "jj3pAsbN", "caption": "vRLfKtEI", "height": 85, "imageUrl": "q0c6BG9h", "smallImageUrl": "59QTDHB8", "width": 78}, {"as": "TRUxTgOe", "caption": "bbutdm8U", "height": 20, "imageUrl": "Hg5sHTn7", "smallImageUrl": "87aSwJuc", "width": 20}], "localizations": {"usI0pUgY": {"description": "Y7JZp7fM", "title": "lXXmQrpU"}, "xQb7fvge": {"description": "DL4IytRy", "title": "9Qmkaw5x"}, "czNQBn9B": {"description": "ShVSZVcJ", "title": "MQ7ezuyd"}}, "passItemId": "OSvwoQXe"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op CreatePass \
    --namespace $AB_NAMESPACE \
    --seasonId 'rTsxrEjX' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 12 'CreatePass' test.out

#- 13 GetPass
$CLI_EXE \
    --sn seasonpass \
    --op GetPass \
    --code '2WUydKe4' \
    --namespace $AB_NAMESPACE \
    --seasonId 'mmcpsQWW' \
    > test.out 2>&1
eval_tap $? 13 'GetPass' test.out

#- 14 DeletePass
$CLI_EXE \
    --sn seasonpass \
    --op DeletePass \
    --code '9Hy5rHxp' \
    --namespace $AB_NAMESPACE \
    --seasonId 'BwdpWy5H' \
    > test.out 2>&1
eval_tap $? 14 'DeletePass' test.out

#- 15 UpdatePass
# body param: body
echo '{"autoEnroll": true, "displayOrder": 74, "images": [{"as": "4OVefWUM", "caption": "HjBbFMdj", "height": 69, "imageUrl": "F5QHcbYX", "smallImageUrl": "jZHQeLg5", "width": 79}, {"as": "Qxf4A0zM", "caption": "4ELRIV81", "height": 38, "imageUrl": "DxudKRXX", "smallImageUrl": "BEcqhDqV", "width": 66}, {"as": "VHnxj4EC", "caption": "6ubqHWGW", "height": 29, "imageUrl": "ds1sYURv", "smallImageUrl": "xxnPt0IW", "width": 30}], "localizations": {"I6UbAlXh": {"description": "6qIlgdbM", "title": "OPHho5Js"}, "FLQCuEqj": {"description": "iv9wVyvZ", "title": "xXtmYpLQ"}, "2x8P2iuZ": {"description": "8qKVdfra", "title": "NTbQJqFw"}}, "passItemId": "OJRGLwIX"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op UpdatePass \
    --code 'Rglhvb1s' \
    --namespace $AB_NAMESPACE \
    --seasonId 'rn8sXVNI' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 15 'UpdatePass' test.out

#- 16 PublishSeason
$CLI_EXE \
    --sn seasonpass \
    --op PublishSeason \
    --namespace $AB_NAMESPACE \
    --seasonId 'MZlFhxMi' \
    > test.out 2>&1
eval_tap $? 16 'PublishSeason' test.out

#- 17 RetireSeason
$CLI_EXE \
    --sn seasonpass \
    --op RetireSeason \
    --namespace $AB_NAMESPACE \
    --seasonId '12SXOAZO' \
    --force 'false' \
    > test.out 2>&1
eval_tap $? 17 'RetireSeason' test.out

#- 18 QueryRewards
$CLI_EXE \
    --sn seasonpass \
    --op QueryRewards \
    --namespace $AB_NAMESPACE \
    --seasonId 'cjK27mKR' \
    --q 'a1I1oivs' \
    > test.out 2>&1
eval_tap $? 18 'QueryRewards' test.out

#- 19 CreateReward
# body param: body
echo '{"code": "RU5Jm4Pz", "currency": {"currencyCode": "4d5QBiZr", "namespace": "w2quoxBX"}, "image": {"as": "Yyx1wxgo", "caption": "PWf65Yzz", "height": 60, "imageUrl": "2vRT8QUq", "smallImageUrl": "f9ABOWzz", "width": 40}, "itemId": "rgU2dLVD", "quantity": 68, "type": "ITEM"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op CreateReward \
    --namespace $AB_NAMESPACE \
    --seasonId 'SsxKJJng' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 19 'CreateReward' test.out

#- 20 GetReward
$CLI_EXE \
    --sn seasonpass \
    --op GetReward \
    --code 'WiLCiwlv' \
    --namespace $AB_NAMESPACE \
    --seasonId 'yV8N3GXH' \
    > test.out 2>&1
eval_tap $? 20 'GetReward' test.out

#- 21 DeleteReward
$CLI_EXE \
    --sn seasonpass \
    --op DeleteReward \
    --code 'Zvw3W1lc' \
    --namespace $AB_NAMESPACE \
    --seasonId 'JsDnHGuX' \
    > test.out 2>&1
eval_tap $? 21 'DeleteReward' test.out

#- 22 UpdateReward
# body param: body
echo '{"currency": {"currencyCode": "05vSmzeV", "namespace": "dkmZO5Sp"}, "image": {"as": "MSLnkcw5", "caption": "WZAuaJxF", "height": 21, "imageUrl": "c6VFZZzB", "smallImageUrl": "U5VuENmO", "width": 89}, "itemId": "ftrBZY8E", "nullFields": ["LmxOZQJm", "LTqctNoC", "OT2D4FmL"], "quantity": 28, "type": "ITEM"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op UpdateReward \
    --code 'WYRszLSI' \
    --namespace $AB_NAMESPACE \
    --seasonId 'Yfffa0BE' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 22 'UpdateReward' test.out

#- 23 QueryTiers
$CLI_EXE \
    --sn seasonpass \
    --op QueryTiers \
    --namespace $AB_NAMESPACE \
    --seasonId 'h3swZUMZ' \
    --limit '39' \
    --offset '25' \
    > test.out 2>&1
eval_tap $? 23 'QueryTiers' test.out

#- 24 CreateTier
# body param: body
echo '{"index": 24, "quantity": 85, "tier": {"requiredExp": 68, "rewards": {"U0ID1bjh": ["XRxe3Qbo", "E9GjoPsy", "G6zOz749"], "VQCU1D3F": ["hHbaX8sQ", "m7C4KGXi", "tpAXE8wN"], "0O69yG0y": ["7FjnQQKX", "Ge6XxgGu", "tJbnghir"]}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op CreateTier \
    --namespace $AB_NAMESPACE \
    --seasonId 'nqGl8ujN' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 24 'CreateTier' test.out

#- 25 UpdateTier
# body param: body
echo '{"requiredExp": 21, "rewards": {"G3j44uYf": ["Q4UfJuea", "gzsdjvRP", "DRHGC2m9"], "GFoA7Zre": ["GNucPipQ", "55DiKblq", "2fkiJbmd"], "ItCA7G3w": ["Ijmduzjp", "PhB5H0s2", "UBMZDMb4"]}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op UpdateTier \
    --id 'CmH6tlDZ' \
    --namespace $AB_NAMESPACE \
    --seasonId 'bl1SrKWV' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 25 'UpdateTier' test.out

#- 26 DeleteTier
$CLI_EXE \
    --sn seasonpass \
    --op DeleteTier \
    --id 'NcK64meE' \
    --namespace $AB_NAMESPACE \
    --seasonId 'HMYpQIvi' \
    > test.out 2>&1
eval_tap $? 26 'DeleteTier' test.out

#- 27 ReorderTier
# body param: body
echo '{"newIndex": 66}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op ReorderTier \
    --id 'QTYbLFR1' \
    --namespace $AB_NAMESPACE \
    --seasonId 'STXxXcKd' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 27 'ReorderTier' test.out

#- 28 UnpublishSeason
$CLI_EXE \
    --sn seasonpass \
    --op UnpublishSeason \
    --namespace $AB_NAMESPACE \
    --seasonId 'LXSIybou' \
    --force 'true' \
    > test.out 2>&1
eval_tap $? 28 'UnpublishSeason' test.out

#- 29 GetUserParticipatedSeasons
$CLI_EXE \
    --sn seasonpass \
    --op GetUserParticipatedSeasons \
    --namespace $AB_NAMESPACE \
    --userId 'xz4ZVqn7' \
    --limit '7' \
    --offset '4' \
    > test.out 2>&1
eval_tap $? 29 'GetUserParticipatedSeasons' test.out

#- 30 GrantUserExp
# body param: body
echo '{"exp": 79, "source": "PAID_FOR", "tags": ["5DuDU8Dr", "KoEogINw", "eMhUoz1n"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op GrantUserExp \
    --namespace $AB_NAMESPACE \
    --userId '6ELEM7cC' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 30 'GrantUserExp' test.out

#- 31 GrantUserPass
# body param: body
echo '{"passCode": "ehl0kFLq", "passItemId": "oL8u0bx5"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op GrantUserPass \
    --namespace $AB_NAMESPACE \
    --userId 'xOBdxJrV' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 31 'GrantUserPass' test.out

#- 32 ExistsAnyPassByPassCodes
$CLI_EXE \
    --sn seasonpass \
    --op ExistsAnyPassByPassCodes \
    --namespace $AB_NAMESPACE \
    --userId 'idAgXc56' \
    --passCodes '["JTaxPCfD", "bbmNhVeC", "aCjFwpRW"]' \
    > test.out 2>&1
eval_tap $? 32 'ExistsAnyPassByPassCodes' test.out

#- 33 GetCurrentUserSeasonProgression
$CLI_EXE \
    --sn seasonpass \
    --op GetCurrentUserSeasonProgression \
    --namespace $AB_NAMESPACE \
    --userId 'urVCJs6g' \
    > test.out 2>&1
eval_tap $? 33 'GetCurrentUserSeasonProgression' test.out

#- 34 CheckSeasonPurchasable
# body param: body
echo '{"passItemId": "EmkONLl7", "tierItemCount": 72, "tierItemId": "VDhZX8HY"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op CheckSeasonPurchasable \
    --namespace $AB_NAMESPACE \
    --userId 'cTnPAU8H' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 34 'CheckSeasonPurchasable' test.out

#- 35 ResetUserSeason
$CLI_EXE \
    --sn seasonpass \
    --op ResetUserSeason \
    --namespace $AB_NAMESPACE \
    --userId 'yUl0SoGt' \
    > test.out 2>&1
eval_tap $? 35 'ResetUserSeason' test.out

#- 36 GrantUserTier
# body param: body
echo '{"count": 59, "source": "PAID_FOR", "tags": ["kSTmLnAM", "aOMK3rbY", "kvWzhLMC"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op GrantUserTier \
    --namespace $AB_NAMESPACE \
    --userId 'dtCKxddQ' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 36 'GrantUserTier' test.out

#- 37 QueryUserExpGrantHistory
$CLI_EXE \
    --sn seasonpass \
    --op QueryUserExpGrantHistory \
    --namespace $AB_NAMESPACE \
    --userId 'xoXJiz4R' \
    --from 'ZY4oWVMl' \
    --limit '95' \
    --offset '66' \
    --seasonId 'wEV64Vga' \
    --source 'SWEAT' \
    --tags '["ArpzXV8E", "PSh0vtkF", "khJ7WS5u"]' \
    --to 'oYjNJpAd' \
    > test.out 2>&1
eval_tap $? 37 'QueryUserExpGrantHistory' test.out

#- 38 QueryUserExpGrantHistoryTag
$CLI_EXE \
    --sn seasonpass \
    --op QueryUserExpGrantHistoryTag \
    --namespace $AB_NAMESPACE \
    --userId '7TP9mUFE' \
    --seasonId 'C5NkKUpf' \
    > test.out 2>&1
eval_tap $? 38 'QueryUserExpGrantHistoryTag' test.out

#- 39 GetUserSeason
$CLI_EXE \
    --sn seasonpass \
    --op GetUserSeason \
    --namespace $AB_NAMESPACE \
    --seasonId 'Ci7bVGq9' \
    --userId 'y1cWPIEb' \
    > test.out 2>&1
eval_tap $? 39 'GetUserSeason' test.out

#- 40 PublicGetCurrentSeason
$CLI_EXE \
    --sn seasonpass \
    --op PublicGetCurrentSeason \
    --namespace $AB_NAMESPACE \
    --language 'U2VluqfX' \
    > test.out 2>&1
eval_tap $? 40 'PublicGetCurrentSeason' test.out

#- 41 PublicGetCurrentUserSeason
$CLI_EXE \
    --sn seasonpass \
    --op PublicGetCurrentUserSeason \
    --namespace $AB_NAMESPACE \
    --userId 'pfDn5AhZ' \
    > test.out 2>&1
eval_tap $? 41 'PublicGetCurrentUserSeason' test.out

#- 42 PublicClaimUserReward
# body param: body
echo '{"passCode": "UpKR5B7E", "rewardCode": "GwdZPrfp", "tierIndex": 45}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op PublicClaimUserReward \
    --namespace $AB_NAMESPACE \
    --userId 'QBHZFHjs' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 42 'PublicClaimUserReward' test.out

#- 43 PublicBulkClaimUserRewards
$CLI_EXE \
    --sn seasonpass \
    --op PublicBulkClaimUserRewards \
    --namespace $AB_NAMESPACE \
    --userId 'gHM0gTD1' \
    > test.out 2>&1
eval_tap $? 43 'PublicBulkClaimUserRewards' test.out

#- 44 PublicGetUserSeason
$CLI_EXE \
    --sn seasonpass \
    --op PublicGetUserSeason \
    --namespace $AB_NAMESPACE \
    --seasonId '6TU4xiCS' \
    --userId 'SJ1a4d5d' \
    > test.out 2>&1
eval_tap $? 44 'PublicGetUserSeason' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE