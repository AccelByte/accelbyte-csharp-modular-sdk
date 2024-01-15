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
    --limit '50' \
    --offset '28' \
    --status '["RETIRED", "RETIRED", "DRAFT"]' \
    > test.out 2>&1
eval_tap $? 3 'QuerySeasons' test.out

#- 4 CreateSeason
# body param: body
echo '{"autoClaim": false, "defaultLanguage": "EaKu53To", "defaultRequiredExp": 94, "draftStoreId": "3cOpKrMl", "end": "1981-03-11T00:00:00Z", "excessStrategy": {"currency": "ouFXymVb", "method": "CURRENCY", "percentPerExp": 22}, "images": [{"as": "bpQyiC1m", "caption": "OGb2Y072", "height": 43, "imageUrl": "dn09x0dB", "smallImageUrl": "5ZOZWBnK", "width": 50}, {"as": "ATG8Rw4J", "caption": "3SNlQWOi", "height": 61, "imageUrl": "Wiiy0d5b", "smallImageUrl": "licyzeEF", "width": 11}, {"as": "Y1p9XbED", "caption": "btRn4nPS", "height": 13, "imageUrl": "MgV9Ag3y", "smallImageUrl": "HKll2IRO", "width": 21}], "localizations": {"83qLtL57": {"description": "FLkZn34i", "title": "BFOISAGb"}, "nWdlNNSR": {"description": "Q83BK0zt", "title": "bvzQXYoe"}, "UMQx9ka9": {"description": "AqW1BkLc", "title": "uVsVajI3"}}, "name": "ptwvfFXk", "start": "1986-04-19T00:00:00Z", "tierItemId": "odeTIHnB"}' > $TEMP_JSON_INPUT
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
echo '{"userIds": ["DcBcCrnC", "O9iu18Wh", "k3EMTLPl"]}' > $TEMP_JSON_INPUT
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
    --seasonId 'QNmSOmSY' \
    > test.out 2>&1
eval_tap $? 7 'GetSeason' test.out

#- 8 DeleteSeason
$CLI_EXE \
    --sn seasonpass \
    --op DeleteSeason \
    --namespace $AB_NAMESPACE \
    --seasonId '2nq6qbBs' \
    > test.out 2>&1
eval_tap $? 8 'DeleteSeason' test.out

#- 9 UpdateSeason
# body param: body
echo '{"autoClaim": false, "defaultLanguage": "JS22wHWz", "defaultRequiredExp": 77, "draftStoreId": "yxEeggyX", "end": "1988-10-04T00:00:00Z", "excessStrategy": {"currency": "gBZE5XzE", "method": "NONE", "percentPerExp": 15}, "images": [{"as": "H69gXgbx", "caption": "eD23K8Db", "height": 94, "imageUrl": "wA266Eps", "smallImageUrl": "uedDtjqD", "width": 62}, {"as": "GatEMiDA", "caption": "kwgN3VFJ", "height": 60, "imageUrl": "vCNXB02X", "smallImageUrl": "p39YY8N0", "width": 73}, {"as": "6IVVZ2uK", "caption": "P4lBTVsC", "height": 82, "imageUrl": "q74XOoSY", "smallImageUrl": "6XI8Y3aH", "width": 35}], "localizations": {"ZvJETpEZ": {"description": "AHe3ykHs", "title": "7ErLXBoS"}, "cWNzmj4C": {"description": "bV3qyTui", "title": "YUbxQFpk"}, "JRtqEnkM": {"description": "ZDAALx6c", "title": "N4pvR1Gf"}}, "name": "l9nngQk6", "start": "1980-03-27T00:00:00Z", "tierItemId": "fxSgoP98"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op UpdateSeason \
    --namespace $AB_NAMESPACE \
    --seasonId '0D5mIZ1l' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 9 'UpdateSeason' test.out

#- 10 CloneSeason
# body param: body
echo '{"end": "1996-04-11T00:00:00Z", "name": "McSWivDS", "start": "1985-07-07T00:00:00Z"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op CloneSeason \
    --namespace $AB_NAMESPACE \
    --seasonId 'l7FP0TlA' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 10 'CloneSeason' test.out

#- 11 GetFullSeason
$CLI_EXE \
    --sn seasonpass \
    --op GetFullSeason \
    --namespace $AB_NAMESPACE \
    --seasonId 'SUqgRlsc' \
    > test.out 2>&1
eval_tap $? 11 'GetFullSeason' test.out

#- 12 QueryPasses
$CLI_EXE \
    --sn seasonpass \
    --op QueryPasses \
    --namespace $AB_NAMESPACE \
    --seasonId 'jRGAg6Ko' \
    > test.out 2>&1
eval_tap $? 12 'QueryPasses' test.out

#- 13 CreatePass
# body param: body
echo '{"autoEnroll": true, "code": "hFevxAvm", "displayOrder": 78, "images": [{"as": "fW9YOwyB", "caption": "OrxpTrQZ", "height": 44, "imageUrl": "V5GlXeo0", "smallImageUrl": "a7pcDOJ2", "width": 37}, {"as": "JocH5VP6", "caption": "Oe1U3ukZ", "height": 5, "imageUrl": "vHoIbtHL", "smallImageUrl": "q2JF0Eg3", "width": 90}, {"as": "lVTxX077", "caption": "geblGnP7", "height": 61, "imageUrl": "BKwIE5ZK", "smallImageUrl": "GKBESSIA", "width": 56}], "localizations": {"JKpAFYvY": {"description": "TIE4YKNb", "title": "7SqdTOiF"}, "Egj1RxI8": {"description": "3X16MCsk", "title": "6iXMRZhm"}, "BQBSe36K": {"description": "kFa4kGZF", "title": "ukCbskuD"}}, "passItemId": "ohNjCq8P"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op CreatePass \
    --namespace $AB_NAMESPACE \
    --seasonId 'v7FSCu82' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 13 'CreatePass' test.out

#- 14 GetPass
$CLI_EXE \
    --sn seasonpass \
    --op GetPass \
    --code 'plT4mF8y' \
    --namespace $AB_NAMESPACE \
    --seasonId '21Dwtx08' \
    > test.out 2>&1
eval_tap $? 14 'GetPass' test.out

#- 15 DeletePass
$CLI_EXE \
    --sn seasonpass \
    --op DeletePass \
    --code 'El8qxZsI' \
    --namespace $AB_NAMESPACE \
    --seasonId 'fwPHBbT4' \
    > test.out 2>&1
eval_tap $? 15 'DeletePass' test.out

#- 16 UpdatePass
# body param: body
echo '{"autoEnroll": false, "displayOrder": 76, "images": [{"as": "82YzbwQr", "caption": "1I0zmAts", "height": 39, "imageUrl": "3Kebg611", "smallImageUrl": "A2Z7d1xw", "width": 69}, {"as": "4iyIgjwN", "caption": "Xo2ql2Je", "height": 45, "imageUrl": "6WWEspmA", "smallImageUrl": "Xk3vuDQj", "width": 23}, {"as": "W1USbzXs", "caption": "WQdW13kT", "height": 94, "imageUrl": "zLkahqHB", "smallImageUrl": "uIk8Gpwg", "width": 78}], "localizations": {"AQp3kAdd": {"description": "xEJvRHJv", "title": "VJHypJ2f"}, "giRAGUAG": {"description": "92SOHcOB", "title": "PG56NI8C"}, "UTRAQhFH": {"description": "wkaPqnmT", "title": "GQp6hcvJ"}}, "passItemId": "417Nh3zY"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op UpdatePass \
    --code 'mbtkgfYc' \
    --namespace $AB_NAMESPACE \
    --seasonId 'JpXKP1RS' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 16 'UpdatePass' test.out

#- 17 PublishSeason
$CLI_EXE \
    --sn seasonpass \
    --op PublishSeason \
    --namespace $AB_NAMESPACE \
    --seasonId 'k081g0oO' \
    > test.out 2>&1
eval_tap $? 17 'PublishSeason' test.out

#- 18 RetireSeason
$CLI_EXE \
    --sn seasonpass \
    --op RetireSeason \
    --namespace $AB_NAMESPACE \
    --seasonId 'N7mb5xBl' \
    --force 'false' \
    > test.out 2>&1
eval_tap $? 18 'RetireSeason' test.out

#- 19 QueryRewards
$CLI_EXE \
    --sn seasonpass \
    --op QueryRewards \
    --namespace $AB_NAMESPACE \
    --seasonId 'TFeIyuUH' \
    --q 'WCBFty1z' \
    > test.out 2>&1
eval_tap $? 19 'QueryRewards' test.out

#- 20 CreateReward
# body param: body
echo '{"code": "XvZ976Ds", "currency": {"currencyCode": "ch1dM4lm", "namespace": "Odt7blHm"}, "image": {"as": "IajikrK7", "caption": "czASaMv3", "height": 16, "imageUrl": "M5HRNC6z", "smallImageUrl": "2mtn3dON", "width": 8}, "itemId": "eWC9CX9q", "quantity": 45, "type": "ITEM"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op CreateReward \
    --namespace $AB_NAMESPACE \
    --seasonId 'AhnRnDIi' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 20 'CreateReward' test.out

#- 21 GetReward
$CLI_EXE \
    --sn seasonpass \
    --op GetReward \
    --code 'lT17WaV7' \
    --namespace $AB_NAMESPACE \
    --seasonId 'mlOxfbVT' \
    > test.out 2>&1
eval_tap $? 21 'GetReward' test.out

#- 22 DeleteReward
$CLI_EXE \
    --sn seasonpass \
    --op DeleteReward \
    --code 'R7whfuoI' \
    --namespace $AB_NAMESPACE \
    --seasonId 'B6vhGuE6' \
    > test.out 2>&1
eval_tap $? 22 'DeleteReward' test.out

#- 23 UpdateReward
# body param: body
echo '{"currency": {"currencyCode": "4qjzktfW", "namespace": "pRzS0zQM"}, "image": {"as": "CQTEtmnv", "caption": "z3rKXH0V", "height": 55, "imageUrl": "AynGZMuX", "smallImageUrl": "XtvxXaAb", "width": 7}, "itemId": "N2RBizEx", "nullFields": ["vbaPs9ah", "vPrvlo0Y", "exrLzedf"], "quantity": 64, "type": "ITEM"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op UpdateReward \
    --code 'T25FP5Ys' \
    --namespace $AB_NAMESPACE \
    --seasonId '9D4NfdcT' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 23 'UpdateReward' test.out

#- 24 QueryTiers
$CLI_EXE \
    --sn seasonpass \
    --op QueryTiers \
    --namespace $AB_NAMESPACE \
    --seasonId 'bCXvHcpC' \
    --limit '56' \
    --offset '45' \
    > test.out 2>&1
eval_tap $? 24 'QueryTiers' test.out

#- 25 CreateTier
# body param: body
echo '{"index": 8, "quantity": 4, "tier": {"requiredExp": 34, "rewards": {"GeKfh8Gh": ["Q5eA7usf", "DvVOjDXt", "b2TGMNgK"], "VyOTzAb5": ["DfrR0rUR", "OgZYuR0Q", "mn0ZAl8d"], "dqjwaojj": ["rIoXNfku", "CNH1aXBq", "bAQT5Y6e"]}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op CreateTier \
    --namespace $AB_NAMESPACE \
    --seasonId 'kgmf4wYz' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 25 'CreateTier' test.out

#- 26 UpdateTier
# body param: body
echo '{"requiredExp": 77, "rewards": {"1S6vIYRm": ["jXdRJJBv", "WEdSRtLm", "QVwbJnV5"], "ZlvVZ6Jj": ["ofEjDoFH", "htT7IiEh", "XzlCcyPx"], "6d3kWxM9": ["boMSEZi5", "B3MGX7mn", "Y1uOrKfl"]}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op UpdateTier \
    --id '6dvzdvkY' \
    --namespace $AB_NAMESPACE \
    --seasonId 'vlVYTVIA' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 26 'UpdateTier' test.out

#- 27 DeleteTier
$CLI_EXE \
    --sn seasonpass \
    --op DeleteTier \
    --id 'KFpnX24D' \
    --namespace $AB_NAMESPACE \
    --seasonId 'OoxzVyIn' \
    > test.out 2>&1
eval_tap $? 27 'DeleteTier' test.out

#- 28 ReorderTier
# body param: body
echo '{"newIndex": 46}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op ReorderTier \
    --id 'c6zEbfyM' \
    --namespace $AB_NAMESPACE \
    --seasonId '3cMxmC9P' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 28 'ReorderTier' test.out

#- 29 UnpublishSeason
$CLI_EXE \
    --sn seasonpass \
    --op UnpublishSeason \
    --namespace $AB_NAMESPACE \
    --seasonId 'YdVww6Bg' \
    --force 'false' \
    > test.out 2>&1
eval_tap $? 29 'UnpublishSeason' test.out

#- 30 GetUserParticipatedSeasons
$CLI_EXE \
    --sn seasonpass \
    --op GetUserParticipatedSeasons \
    --namespace $AB_NAMESPACE \
    --userId 'cUkjMbUr' \
    --limit '49' \
    --offset '37' \
    > test.out 2>&1
eval_tap $? 30 'GetUserParticipatedSeasons' test.out

#- 31 GrantUserExp
# body param: body
echo '{"exp": 4, "source": "PAID_FOR", "tags": ["HchZbyx3", "mi94NE7y", "yCnH8OIX"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op GrantUserExp \
    --namespace $AB_NAMESPACE \
    --userId 'FnMWrat9' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 31 'GrantUserExp' test.out

#- 32 GrantUserPass
# body param: body
echo '{"passCode": "h2GbKi0S", "passItemId": "JguvzT3Y"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op GrantUserPass \
    --namespace $AB_NAMESPACE \
    --userId 'nUE1xGg0' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 32 'GrantUserPass' test.out

#- 33 ExistsAnyPassByPassCodes
$CLI_EXE \
    --sn seasonpass \
    --op ExistsAnyPassByPassCodes \
    --namespace $AB_NAMESPACE \
    --userId 'NEgy2faO' \
    --passCodes '["FKjaxeBe", "AIV5d0ft", "BwVEjiBK"]' \
    > test.out 2>&1
eval_tap $? 33 'ExistsAnyPassByPassCodes' test.out

#- 34 GetCurrentUserSeasonProgression
$CLI_EXE \
    --sn seasonpass \
    --op GetCurrentUserSeasonProgression \
    --namespace $AB_NAMESPACE \
    --userId 'HyAzfhCs' \
    > test.out 2>&1
eval_tap $? 34 'GetCurrentUserSeasonProgression' test.out

#- 35 CheckSeasonPurchasable
# body param: body
echo '{"passItemId": "AKjEsm8y", "tierItemCount": 39, "tierItemId": "feU9zi6E"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op CheckSeasonPurchasable \
    --namespace $AB_NAMESPACE \
    --userId 'Qxi7pHLz' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 35 'CheckSeasonPurchasable' test.out

#- 36 ResetUserSeason
$CLI_EXE \
    --sn seasonpass \
    --op ResetUserSeason \
    --namespace $AB_NAMESPACE \
    --userId 'PULz6zGe' \
    > test.out 2>&1
eval_tap $? 36 'ResetUserSeason' test.out

#- 37 GrantUserTier
# body param: body
echo '{"count": 53, "source": "PAID_FOR", "tags": ["oyCBRwNW", "UKVIAx2N", "3hlNsZeD"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op GrantUserTier \
    --namespace $AB_NAMESPACE \
    --userId '3zpbrErL' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 37 'GrantUserTier' test.out

#- 38 QueryUserExpGrantHistory
$CLI_EXE \
    --sn seasonpass \
    --op QueryUserExpGrantHistory \
    --namespace $AB_NAMESPACE \
    --userId 'S755NYdm' \
    --from 'sSVDRlUS' \
    --limit '59' \
    --offset '2' \
    --seasonId 'bLdKg8JN' \
    --source 'PAID_FOR' \
    --tags '["hJI0N0my", "xVOj0GIL", "620ZBsWk"]' \
    --to 'dJnoku7L' \
    > test.out 2>&1
eval_tap $? 38 'QueryUserExpGrantHistory' test.out

#- 39 QueryUserExpGrantHistoryTag
$CLI_EXE \
    --sn seasonpass \
    --op QueryUserExpGrantHistoryTag \
    --namespace $AB_NAMESPACE \
    --userId 'wMwyzSuZ' \
    --seasonId 'S2MIelFl' \
    > test.out 2>&1
eval_tap $? 39 'QueryUserExpGrantHistoryTag' test.out

#- 40 GetUserSeason
$CLI_EXE \
    --sn seasonpass \
    --op GetUserSeason \
    --namespace $AB_NAMESPACE \
    --seasonId '8Vsybf5z' \
    --userId 'Ec42UtS1' \
    > test.out 2>&1
eval_tap $? 40 'GetUserSeason' test.out

#- 41 PublicGetCurrentSeason
$CLI_EXE \
    --sn seasonpass \
    --op PublicGetCurrentSeason \
    --namespace $AB_NAMESPACE \
    --language 's3G6TlLT' \
    > test.out 2>&1
eval_tap $? 41 'PublicGetCurrentSeason' test.out

#- 42 PublicGetCurrentUserSeason
$CLI_EXE \
    --sn seasonpass \
    --op PublicGetCurrentUserSeason \
    --namespace $AB_NAMESPACE \
    --userId 'QXa6Iowo' \
    > test.out 2>&1
eval_tap $? 42 'PublicGetCurrentUserSeason' test.out

#- 43 PublicClaimUserReward
# body param: body
echo '{"passCode": "G04wasqX", "rewardCode": "dFRUwopK", "tierIndex": 32}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn seasonpass \
    --op PublicClaimUserReward \
    --namespace $AB_NAMESPACE \
    --userId 'ft2D5Fvf' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 43 'PublicClaimUserReward' test.out

#- 44 PublicBulkClaimUserRewards
$CLI_EXE \
    --sn seasonpass \
    --op PublicBulkClaimUserRewards \
    --namespace $AB_NAMESPACE \
    --userId 'SSP224O1' \
    > test.out 2>&1
eval_tap $? 44 'PublicBulkClaimUserRewards' test.out

#- 45 PublicGetUserSeason
$CLI_EXE \
    --sn seasonpass \
    --op PublicGetUserSeason \
    --namespace $AB_NAMESPACE \
    --seasonId 'KEGYTEcf' \
    --userId '6vWKzwFk' \
    > test.out 2>&1
eval_tap $? 45 'PublicGetUserSeason' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE