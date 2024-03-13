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
    --limit '39' \
    --offset '98' \
    --status '["PUBLISHED", "DRAFT", "DRAFT"]' \
    > test.out 2>&1
eval_tap $? 3 'QuerySeasons' test.out

#- 4 CreateSeason
# body param: body
echo '{"autoClaim": true, "defaultLanguage": "61aAAOTt", "defaultRequiredExp": 4, "draftStoreId": "6YQZowZU", "end": "1979-11-05T00:00:00Z", "excessStrategy": {"currency": "MrgqGulR", "method": "NONE", "percentPerExp": 87}, "images": [{"as": "q6AksSo8", "caption": "NhlaMCi8", "height": 8, "imageUrl": "fCapuSdu", "smallImageUrl": "Z7yYKvNF", "width": 82}, {"as": "8voqlsPK", "caption": "IVgEOHXF", "height": 66, "imageUrl": "2TMBJxKO", "smallImageUrl": "8SWuAxo5", "width": 31}, {"as": "gTgpu5Re", "caption": "mkzuGTJr", "height": 61, "imageUrl": "SmUDsD8Y", "smallImageUrl": "DgxlkzP9", "width": 78}], "localizations": {"AJ2sPDE5": {"description": "PmlxQkF5", "title": "DeMmQYPX"}, "HrlFWvsF": {"description": "sH6dkoLe", "title": "EEDpK94A"}, "QH8Y8aGE": {"description": "5Zrh4QZb", "title": "bHtDr79G"}}, "name": "oJEiEvUs", "start": "1986-02-22T00:00:00Z", "tierItemId": "RG4msPZx"}' > $TEMP_JSON_INPUT
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
echo '{"userIds": ["uVqT3ClW", "N5y5rsYQ", "yWx4VG4h"]}' > $TEMP_JSON_INPUT
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
    --seasonId 'vc8swGP7' \
    > test.out 2>&1
eval_tap $? 7 'GetSeason' test.out

#- 8 DeleteSeason
$CLI_EXE \
    --sn seasonpass \
    --op DeleteSeason \
    --namespace $AB_NAMESPACE \
    --seasonId 'ImNXdNb5' \
    > test.out 2>&1
eval_tap $? 8 'DeleteSeason' test.out

#- 9 UpdateSeason
# body param: body
echo '{"autoClaim": false, "defaultLanguage": "dzR2VTmK", "defaultRequiredExp": 60, "draftStoreId": "vLDAcnPk", "end": "1985-10-15T00:00:00Z", "excessStrategy": {"currency": "pVyoTPck", "method": "NONE", "percentPerExp": 70}, "images": [{"as": "DjaP6vhE", "caption": "vzWdRffa", "height": 59, "imageUrl": "F668K0mr", "smallImageUrl": "DbAJHEkN", "width": 66}, {"as": "9lU0Fj2Q", "caption": "Ck6KS7J8", "height": 4, "imageUrl": "X5p8MzsV", "smallImageUrl": "9fk1UbJb", "width": 65}, {"as": "ude91Wpi", "caption": "UrVJTyFJ", "height": 70, "imageUrl": "EM6Zpwrh", "smallImageUrl": "Y8T0uAnX", "width": 99}], "localizations": {"BfXSOTMI": {"description": "Kyh2YLmg", "title": "88vrfVZ5"}, "wxVYHAfe": {"description": "qkz3ooMX", "title": "TEjsvC0X"}, "E0ywCt4D": {"description": "XxfXZmtu", "title": "lyw1vqkz"}}, "name": "AR1T4aoC", "start": "1985-08-14T00:00:00Z", "tierItemId": "1jT5XvtS"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op UpdateSeason \
    --namespace $AB_NAMESPACE \
    --seasonId '1IAYIPue' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 9 'UpdateSeason' test.out

#- 10 CloneSeason
# body param: body
echo '{"end": "1978-10-20T00:00:00Z", "name": "kkvaMrmk", "start": "1990-06-11T00:00:00Z"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op CloneSeason \
    --namespace $AB_NAMESPACE \
    --seasonId 'ZOvyzuc8' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 10 'CloneSeason' test.out

#- 11 GetFullSeason
$CLI_EXE \
    --sn seasonpass \
    --op GetFullSeason \
    --namespace $AB_NAMESPACE \
    --seasonId 'a5CnDHCc' \
    > test.out 2>&1
eval_tap $? 11 'GetFullSeason' test.out

#- 12 QueryPasses
$CLI_EXE \
    --sn seasonpass \
    --op QueryPasses \
    --namespace $AB_NAMESPACE \
    --seasonId 'bAI1hhDU' \
    > test.out 2>&1
eval_tap $? 12 'QueryPasses' test.out

#- 13 CreatePass
# body param: body
echo '{"autoEnroll": false, "code": "9RiQ5rxB", "displayOrder": 28, "images": [{"as": "s9sCfNnQ", "caption": "Shoie20Q", "height": 29, "imageUrl": "yU4tc9y4", "smallImageUrl": "lm17LfKc", "width": 15}, {"as": "1PuazGNe", "caption": "y9Kl0qzk", "height": 33, "imageUrl": "G7zU1n6N", "smallImageUrl": "0ka2ZFZI", "width": 6}, {"as": "uqrp3dUx", "caption": "xW0WMihI", "height": 91, "imageUrl": "kGvIMPGA", "smallImageUrl": "zaYDke8A", "width": 90}], "localizations": {"xp1fqDuk": {"description": "7dZSnnrz", "title": "jk1pAqqg"}, "g3vu1wuQ": {"description": "nkQWEeHS", "title": "t2ugBEjv"}, "UvB8ALlo": {"description": "hRDKFGPL", "title": "6nhJnIDG"}}, "passItemId": "f7okxkza"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op CreatePass \
    --namespace $AB_NAMESPACE \
    --seasonId 'VrV6BWD8' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 13 'CreatePass' test.out

#- 14 GetPass
$CLI_EXE \
    --sn seasonpass \
    --op GetPass \
    --code 'Jl7nDjJ9' \
    --namespace $AB_NAMESPACE \
    --seasonId 'yDWsYZg5' \
    > test.out 2>&1
eval_tap $? 14 'GetPass' test.out

#- 15 DeletePass
$CLI_EXE \
    --sn seasonpass \
    --op DeletePass \
    --code 'v6zSHXuM' \
    --namespace $AB_NAMESPACE \
    --seasonId 'xkmZnbEy' \
    > test.out 2>&1
eval_tap $? 15 'DeletePass' test.out

#- 16 UpdatePass
# body param: body
echo '{"autoEnroll": true, "displayOrder": 65, "images": [{"as": "EAj8liOJ", "caption": "KYxbbbEA", "height": 10, "imageUrl": "0JYJQtHK", "smallImageUrl": "vlC21SpW", "width": 57}, {"as": "jBtMYSKA", "caption": "DQFoLwDc", "height": 28, "imageUrl": "08lq57v4", "smallImageUrl": "K8H0fQc8", "width": 79}, {"as": "QHda6eKJ", "caption": "IipDh0Dk", "height": 61, "imageUrl": "BNHAzPqQ", "smallImageUrl": "L3L41zfS", "width": 54}], "localizations": {"8T8SJy1j": {"description": "J1qkBNDM", "title": "2aLXmpE7"}, "uc6KQsEA": {"description": "gC5IfeVk", "title": "vpBUj5xZ"}, "sLRMYPyg": {"description": "A3nuaMVB", "title": "Dz7gnrYu"}}, "passItemId": "K3OHfZP0"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op UpdatePass \
    --code 'c108cd7d' \
    --namespace $AB_NAMESPACE \
    --seasonId 'EG9CvcI2' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 16 'UpdatePass' test.out

#- 17 PublishSeason
$CLI_EXE \
    --sn seasonpass \
    --op PublishSeason \
    --namespace $AB_NAMESPACE \
    --seasonId 'Mywrllym' \
    > test.out 2>&1
eval_tap $? 17 'PublishSeason' test.out

#- 18 RetireSeason
$CLI_EXE \
    --sn seasonpass \
    --op RetireSeason \
    --namespace $AB_NAMESPACE \
    --seasonId 'bAUeontY' \
    --force 'true' \
    > test.out 2>&1
eval_tap $? 18 'RetireSeason' test.out

#- 19 QueryRewards
$CLI_EXE \
    --sn seasonpass \
    --op QueryRewards \
    --namespace $AB_NAMESPACE \
    --seasonId '4QLKKRpQ' \
    --q 'ZWxFFgu2' \
    > test.out 2>&1
eval_tap $? 19 'QueryRewards' test.out

#- 20 CreateReward
# body param: body
echo '{"code": "4FGUtck7", "currency": {"currencyCode": "EdFOrAgv", "namespace": "EDaYtl7Y"}, "image": {"as": "nZfuLRPg", "caption": "1MwDX2Zh", "height": 10, "imageUrl": "vMb9pvYp", "smallImageUrl": "ChwaLLpW", "width": 13}, "itemId": "9k25wcpG", "quantity": 83, "type": "CURRENCY"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op CreateReward \
    --namespace $AB_NAMESPACE \
    --seasonId '8hP8G6Rp' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 20 'CreateReward' test.out

#- 21 GetReward
$CLI_EXE \
    --sn seasonpass \
    --op GetReward \
    --code 'omq1XfnP' \
    --namespace $AB_NAMESPACE \
    --seasonId '788o9B05' \
    > test.out 2>&1
eval_tap $? 21 'GetReward' test.out

#- 22 DeleteReward
$CLI_EXE \
    --sn seasonpass \
    --op DeleteReward \
    --code 'X3KzoHpc' \
    --namespace $AB_NAMESPACE \
    --seasonId '2EUUaedN' \
    > test.out 2>&1
eval_tap $? 22 'DeleteReward' test.out

#- 23 UpdateReward
# body param: body
echo '{"currency": {"currencyCode": "zy3QTqXa", "namespace": "OZ2LQJ7g"}, "image": {"as": "NECmWImK", "caption": "QdH6Tg0s", "height": 84, "imageUrl": "FHQfmU0O", "smallImageUrl": "Z105n7Xy", "width": 61}, "itemId": "Vg7c1TIt", "nullFields": ["rKhCBmst", "tgJd4X0R", "8VRiBmPJ"], "quantity": 97, "type": "CURRENCY"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op UpdateReward \
    --code 'izWY1tiJ' \
    --namespace $AB_NAMESPACE \
    --seasonId 'ehqM5UBD' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 23 'UpdateReward' test.out

#- 24 QueryTiers
$CLI_EXE \
    --sn seasonpass \
    --op QueryTiers \
    --namespace $AB_NAMESPACE \
    --seasonId 'MSb5ycm3' \
    --limit '97' \
    --offset '38' \
    > test.out 2>&1
eval_tap $? 24 'QueryTiers' test.out

#- 25 CreateTier
# body param: body
echo '{"index": 55, "quantity": 38, "tier": {"requiredExp": 0, "rewards": {"MZtK5WsF": ["awp85nIm", "YfvWHfbZ", "TIitdiVH"], "QU9fG9xX": ["fKQ32ChG", "tnd9oqcr", "ferTznhL"], "Qsi9Eh9A": ["rFJmmLaU", "KldfKWjJ", "oRZRRi7z"]}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op CreateTier \
    --namespace $AB_NAMESPACE \
    --seasonId 'BAwDghqc' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 25 'CreateTier' test.out

#- 26 UpdateTier
# body param: body
echo '{"requiredExp": 19, "rewards": {"PCuFJb2U": ["3bJEfQWW", "Po78Ch6k", "q8Ppd22x"], "UwWu4QLI": ["HcNKJcZu", "Mb6Rqh4l", "V9pyOT8U"], "HQFyGxnR": ["sOc4kFlq", "i8vauCSY", "tW6VaAkY"]}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op UpdateTier \
    --id 'z9QLngaG' \
    --namespace $AB_NAMESPACE \
    --seasonId '3htU01sL' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 26 'UpdateTier' test.out

#- 27 DeleteTier
$CLI_EXE \
    --sn seasonpass \
    --op DeleteTier \
    --id 'RepkPxDH' \
    --namespace $AB_NAMESPACE \
    --seasonId 'tWLsm8lu' \
    > test.out 2>&1
eval_tap $? 27 'DeleteTier' test.out

#- 28 ReorderTier
# body param: body
echo '{"newIndex": 93}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op ReorderTier \
    --id 'jthBYUEx' \
    --namespace $AB_NAMESPACE \
    --seasonId 'tBawe2Ek' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 28 'ReorderTier' test.out

#- 29 UnpublishSeason
$CLI_EXE \
    --sn seasonpass \
    --op UnpublishSeason \
    --namespace $AB_NAMESPACE \
    --seasonId '3kIoc9lH' \
    --force 'true' \
    > test.out 2>&1
eval_tap $? 29 'UnpublishSeason' test.out

#- 30 GetUserParticipatedSeasons
$CLI_EXE \
    --sn seasonpass \
    --op GetUserParticipatedSeasons \
    --namespace $AB_NAMESPACE \
    --userId 'dAaJphdg' \
    --limit '12' \
    --offset '92' \
    > test.out 2>&1
eval_tap $? 30 'GetUserParticipatedSeasons' test.out

#- 31 GrantUserExp
# body param: body
echo '{"exp": 12, "source": "PAID_FOR", "tags": ["8yPIXoFB", "84dOfUcA", "0BrrRpMP"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op GrantUserExp \
    --namespace $AB_NAMESPACE \
    --userId 'VC4C9zEg' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 31 'GrantUserExp' test.out

#- 32 GrantUserPass
# body param: body
echo '{"passCode": "63SaJkEb", "passItemId": "e2BDxsaY"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op GrantUserPass \
    --namespace $AB_NAMESPACE \
    --userId 'C57eLJsm' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 32 'GrantUserPass' test.out

#- 33 ExistsAnyPassByPassCodes
$CLI_EXE \
    --sn seasonpass \
    --op ExistsAnyPassByPassCodes \
    --namespace $AB_NAMESPACE \
    --userId 'dn867e6z' \
    --passCodes '["x41lFg3V", "MbpKcOTd", "ScvmXJHB"]' \
    > test.out 2>&1
eval_tap $? 33 'ExistsAnyPassByPassCodes' test.out

#- 34 GetCurrentUserSeasonProgression
$CLI_EXE \
    --sn seasonpass \
    --op GetCurrentUserSeasonProgression \
    --namespace $AB_NAMESPACE \
    --userId 'DcQeMBux' \
    > test.out 2>&1
eval_tap $? 34 'GetCurrentUserSeasonProgression' test.out

#- 35 CheckSeasonPurchasable
# body param: body
echo '{"passItemId": "OjyC77Ra", "tierItemCount": 20, "tierItemId": "FpW6LhrP"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op CheckSeasonPurchasable \
    --namespace $AB_NAMESPACE \
    --userId '73wkZv9A' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 35 'CheckSeasonPurchasable' test.out

#- 36 ResetUserSeason
$CLI_EXE \
    --sn seasonpass \
    --op ResetUserSeason \
    --namespace $AB_NAMESPACE \
    --userId 'BAO1mvLN' \
    > test.out 2>&1
eval_tap $? 36 'ResetUserSeason' test.out

#- 37 GrantUserTier
# body param: body
echo '{"count": 73, "source": "PAID_FOR", "tags": ["D6H3gfUa", "MolH2b3g", "oxKRbH1j"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op GrantUserTier \
    --namespace $AB_NAMESPACE \
    --userId 'kqAlycSc' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 37 'GrantUserTier' test.out

#- 38 QueryUserExpGrantHistory
$CLI_EXE \
    --sn seasonpass \
    --op QueryUserExpGrantHistory \
    --namespace $AB_NAMESPACE \
    --userId 'Rri0vcn3' \
    --from 'XDgl4kJg' \
    --limit '43' \
    --offset '45' \
    --seasonId 'jCNgh3wh' \
    --source 'PAID_FOR' \
    --tags '["2N2Va4II", "iqv3xpCq", "iBoMoPqo"]' \
    --to 'rxEZq6ZU' \
    > test.out 2>&1
eval_tap $? 38 'QueryUserExpGrantHistory' test.out

#- 39 QueryUserExpGrantHistoryTag
$CLI_EXE \
    --sn seasonpass \
    --op QueryUserExpGrantHistoryTag \
    --namespace $AB_NAMESPACE \
    --userId 'BzjQcV1J' \
    --seasonId 'iIWUKQCQ' \
    > test.out 2>&1
eval_tap $? 39 'QueryUserExpGrantHistoryTag' test.out

#- 40 GetUserSeason
$CLI_EXE \
    --sn seasonpass \
    --op GetUserSeason \
    --namespace $AB_NAMESPACE \
    --seasonId 'PKMOEhkW' \
    --userId '5m96dKQ2' \
    > test.out 2>&1
eval_tap $? 40 'GetUserSeason' test.out

#- 41 PublicGetCurrentSeason
$CLI_EXE \
    --sn seasonpass \
    --op PublicGetCurrentSeason \
    --namespace $AB_NAMESPACE \
    --language 'sxWrnjKp' \
    > test.out 2>&1
eval_tap $? 41 'PublicGetCurrentSeason' test.out

#- 42 PublicGetCurrentUserSeason
$CLI_EXE \
    --sn seasonpass \
    --op PublicGetCurrentUserSeason \
    --namespace $AB_NAMESPACE \
    --userId 'Xo72nRjt' \
    > test.out 2>&1
eval_tap $? 42 'PublicGetCurrentUserSeason' test.out

#- 43 PublicClaimUserReward
# body param: body
echo '{"passCode": "4750kws2", "rewardCode": "r1Roppy8", "tierIndex": 78}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op PublicClaimUserReward \
    --namespace $AB_NAMESPACE \
    --userId 'KY2T9ob5' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 43 'PublicClaimUserReward' test.out

#- 44 PublicBulkClaimUserRewards
$CLI_EXE \
    --sn seasonpass \
    --op PublicBulkClaimUserRewards \
    --namespace $AB_NAMESPACE \
    --userId 'L8sUESLV' \
    > test.out 2>&1
eval_tap $? 44 'PublicBulkClaimUserRewards' test.out

#- 45 PublicGetUserSeason
$CLI_EXE \
    --sn seasonpass \
    --op PublicGetUserSeason \
    --namespace $AB_NAMESPACE \
    --seasonId 'zVLi0KOl' \
    --userId '5LcWPBo7' \
    > test.out 2>&1
eval_tap $? 45 'PublicGetUserSeason' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE