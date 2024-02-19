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
echo "1..70"

#- 1 Login
$CLI_EXE --op login --lt user --user user --pass user > test.out 2>&1
eval_tap $? 1 'Login' test.out

if [ $EXIT_CODE -ne 0 ]; then
  echo "Bail out! Login failed."
  exit $EXIT_CODE
fi

# echo "foo" > "$CLI_TOKEN_FILE"

#- 2 GetNamespaces
$CLI_EXE \
    --sn basic \
    --op GetNamespaces \
    --activeOnly 'false' \
    > test.out 2>&1
eval_tap $? 2 'GetNamespaces' test.out

#- 3 CreateNamespace
# body param: body
echo '{"displayName": "K5jIB8HG", "namespace": "7tE6FSTQ"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op CreateNamespace \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 3 'CreateNamespace' test.out

#- 4 GetNamespace
$CLI_EXE \
    --sn basic \
    --op GetNamespace \
    --namespace $AB_NAMESPACE \
    --activeOnly 'true' \
    > test.out 2>&1
eval_tap $? 4 'GetNamespace' test.out

#- 5 DeleteNamespace
$CLI_EXE \
    --sn basic \
    --op DeleteNamespace \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 5 'DeleteNamespace' test.out

#- 6 GetActions
$CLI_EXE \
    --sn basic \
    --op GetActions \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 6 'GetActions' test.out

#- 7 BanUsers
# body param: body
echo '{"actionId": 44, "comment": "GA4UGyqV", "userIds": ["WUxKY5nj", "uehvmExz", "pktWx2jq"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op BanUsers \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 7 'BanUsers' test.out

#- 8 GetBannedUsers
$CLI_EXE \
    --sn basic \
    --op GetBannedUsers \
    --namespace $AB_NAMESPACE \
    --userIds '["zAgPYAPD", "0FgDaFiC", "ld6d08iN"]' \
    > test.out 2>&1
eval_tap $? 8 'GetBannedUsers' test.out

#- 9 ReportUser
# body param: body
echo '{"category": "nR6Eo8w4", "description": "SEZ4qoYL", "gameSessionId": "2xivNZZe", "subcategory": "1321ytBu", "userId": "tVEMZolN"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op ReportUser \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 9 'ReportUser' test.out

#- 10 GetUserStatus
$CLI_EXE \
    --sn basic \
    --op GetUserStatus \
    --namespace $AB_NAMESPACE \
    --userId 'X5rf8wU0' \
    > test.out 2>&1
eval_tap $? 10 'GetUserStatus' test.out

#- 11 UnBanUsers
# body param: body
echo '{"comment": "iMYoShRL", "userIds": ["z0nrA2dY", "WemHcPyB", "2gRmfmLm"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op UnBanUsers \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 11 'UnBanUsers' test.out

#- 12 UpdateNamespace
# body param: body
echo '{"displayName": "hHQi0Lo2"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op UpdateNamespace \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 12 'UpdateNamespace' test.out

#- 13 GetChildNamespaces
$CLI_EXE \
    --sn basic \
    --op GetChildNamespaces \
    --namespace $AB_NAMESPACE \
    --activeOnly 'false' \
    > test.out 2>&1
eval_tap $? 13 'GetChildNamespaces' test.out

#- 14 CreateConfig
# body param: body
echo '{"key": "WbbajFMt", "value": "D97RlgMs"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op CreateConfig \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 14 'CreateConfig' test.out

#- 15 GetConfig1
$CLI_EXE \
    --sn basic \
    --op GetConfig1 \
    --configKey 'ZkgJblya' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 15 'GetConfig1' test.out

#- 16 DeleteConfig1
$CLI_EXE \
    --sn basic \
    --op DeleteConfig1 \
    --configKey 'QvIH4yK8' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 16 'DeleteConfig1' test.out

#- 17 UpdateConfig1
# body param: body
echo '{"value": "5Dmr4VtY"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op UpdateConfig1 \
    --configKey 'iew8cRct' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 17 'UpdateConfig1' test.out

#- 18 GetNamespaceContext
$CLI_EXE \
    --sn basic \
    --op GetNamespaceContext \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 18 'GetNamespaceContext' test.out

#- 19 GetConfig
$CLI_EXE \
    --sn basic \
    --op GetConfig \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 19 'GetConfig' test.out

#- 20 DeleteConfig
$CLI_EXE \
    --sn basic \
    --op DeleteConfig \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 20 'DeleteConfig' test.out

#- 21 UpdateConfig
# body param: body
echo '{"apiKey": "nPRKHBQl"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op UpdateConfig \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 21 'UpdateConfig' test.out

#- 22 GeneratedUploadUrl
$CLI_EXE \
    --sn basic \
    --op GeneratedUploadUrl \
    --folder 'd3tUqfzU' \
    --namespace $AB_NAMESPACE \
    --fileType 'YrWPSiX6' \
    > test.out 2>&1
eval_tap $? 22 'GeneratedUploadUrl' test.out

#- 23 GetGameNamespaces
$CLI_EXE \
    --sn basic \
    --op GetGameNamespaces \
    --namespace $AB_NAMESPACE \
    --activeOnly 'true' \
    > test.out 2>&1
eval_tap $? 23 'GetGameNamespaces' test.out

#- 24 GetCountries
eval_tap 0 24 'GetCountries # SKIP deprecated' test.out

#- 25 GetCountryGroups
$CLI_EXE \
    --sn basic \
    --op GetCountryGroups \
    --namespace $AB_NAMESPACE \
    --groupCode 'mLGzyUp0' \
    > test.out 2>&1
eval_tap $? 25 'GetCountryGroups' test.out

#- 26 AddCountryGroup
# body param: body
echo '{"countries": [{"code": "mxZTvQHm", "name": "HgKlR5O3"}, {"code": "5U9F98Tg", "name": "H2S3H2Bs"}, {"code": "HR8aNokT", "name": "CjGqL2mY"}], "countryGroupCode": "WzcgXNTK", "countryGroupName": "9DIHxWhM"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op AddCountryGroup \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 26 'AddCountryGroup' test.out

#- 27 UpdateCountryGroup
# body param: body
echo '{"countries": [{"code": "RsaLEig2", "name": "r0uqSVgF"}, {"code": "vzPnz50F", "name": "bt0UXdXA"}, {"code": "ccNvo2nB", "name": "VeLHhbxL"}], "countryGroupName": "XdHIYESn"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op UpdateCountryGroup \
    --countryGroupCode 'OywDdJXH' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 27 'UpdateCountryGroup' test.out

#- 28 DeleteCountryGroup
$CLI_EXE \
    --sn basic \
    --op DeleteCountryGroup \
    --countryGroupCode 'P4nhDop0' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 28 'DeleteCountryGroup' test.out

#- 29 GetLanguages
$CLI_EXE \
    --sn basic \
    --op GetLanguages \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 29 'GetLanguages' test.out

#- 30 GetTimeZones
$CLI_EXE \
    --sn basic \
    --op GetTimeZones \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 30 'GetTimeZones' test.out

#- 31 GetUserProfileInfoByPublicId
$CLI_EXE \
    --sn basic \
    --op GetUserProfileInfoByPublicId \
    --namespace $AB_NAMESPACE \
    --publicId 'Wp4GALWM' \
    > test.out 2>&1
eval_tap $? 31 'GetUserProfileInfoByPublicId' test.out

#- 32 AdminGetUserProfilePublicInfoByIds
# body param: body
echo '{"userIds": ["JyaUd4S9", "6OrkpSBk", "QNYSxzme"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op AdminGetUserProfilePublicInfoByIds \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 32 'AdminGetUserProfilePublicInfoByIds' test.out

#- 33 GetNamespacePublisher
$CLI_EXE \
    --sn basic \
    --op GetNamespacePublisher \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 33 'GetNamespacePublisher' test.out

#- 34 GetPublisherConfig
$CLI_EXE \
    --sn basic \
    --op GetPublisherConfig \
    --configKey '4dPC4MKw' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 34 'GetPublisherConfig' test.out

#- 35 ChangeNamespaceStatus
# body param: body
echo '{"status": "ACTIVE"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op ChangeNamespaceStatus \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 35 'ChangeNamespaceStatus' test.out

#- 36 AnonymizeUserProfile
$CLI_EXE \
    --sn basic \
    --op AnonymizeUserProfile \
    --namespace $AB_NAMESPACE \
    --userId 'h76oGxJy' \
    > test.out 2>&1
eval_tap $? 36 'AnonymizeUserProfile' test.out

#- 37 GeneratedUserUploadContentUrl
$CLI_EXE \
    --sn basic \
    --op GeneratedUserUploadContentUrl \
    --namespace $AB_NAMESPACE \
    --userId 'pFr92Dta' \
    --category 'DLrIsDaP' \
    --fileType 'rP9SjSJJ' \
    > test.out 2>&1
eval_tap $? 37 'GeneratedUserUploadContentUrl' test.out

#- 38 GetUserProfileInfo
$CLI_EXE \
    --sn basic \
    --op GetUserProfileInfo \
    --namespace $AB_NAMESPACE \
    --userId 'idERSjgn' \
    > test.out 2>&1
eval_tap $? 38 'GetUserProfileInfo' test.out

#- 39 UpdateUserProfile
# body param: body
echo '{"avatarLargeUrl": "TlmuNV3J", "avatarSmallUrl": "8AEOq2fd", "avatarUrl": "wqEle9Rr", "customAttributes": {"4fwU2V64": {}, "2ryIum2o": {}, "4EZLI6iz": {}}, "dateOfBirth": "1972-03-26", "firstName": "S9idgq3h", "language": "Knf-IpOJ", "lastName": "C1yAJk0r", "privateCustomAttributes": {"PBWJGvv1": {}, "PnMqoc3f": {}, "VhdyXuge": {}}, "status": "ACTIVE", "timeZone": "DUPVOjpJ", "zipCode": "hQlt89oG"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op UpdateUserProfile \
    --namespace $AB_NAMESPACE \
    --userId 'CdPd3rzA' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 39 'UpdateUserProfile' test.out

#- 40 DeleteUserProfile
$CLI_EXE \
    --sn basic \
    --op DeleteUserProfile \
    --namespace $AB_NAMESPACE \
    --userId 'TFHGic3H' \
    > test.out 2>&1
eval_tap $? 40 'DeleteUserProfile' test.out

#- 41 GetCustomAttributesInfo
$CLI_EXE \
    --sn basic \
    --op GetCustomAttributesInfo \
    --namespace $AB_NAMESPACE \
    --userId 'mYRaoBuM' \
    > test.out 2>&1
eval_tap $? 41 'GetCustomAttributesInfo' test.out

#- 42 UpdateCustomAttributesPartially
# body param: body
echo '{"QlFVk9kw": {}, "0iRqXwsi": {}, "4WjHKBYE": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op UpdateCustomAttributesPartially \
    --namespace $AB_NAMESPACE \
    --userId 'XCoGxYCS' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 42 'UpdateCustomAttributesPartially' test.out

#- 43 GetPrivateCustomAttributesInfo
$CLI_EXE \
    --sn basic \
    --op GetPrivateCustomAttributesInfo \
    --namespace $AB_NAMESPACE \
    --userId 'C2la5GfO' \
    > test.out 2>&1
eval_tap $? 43 'GetPrivateCustomAttributesInfo' test.out

#- 44 UpdatePrivateCustomAttributesPartially
# body param: body
echo '{"AfQLeKST": {}, "RJ6q1k6d": {}, "NNRvv3MF": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op UpdatePrivateCustomAttributesPartially \
    --namespace $AB_NAMESPACE \
    --userId 'eiKw9cqY' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 44 'UpdatePrivateCustomAttributesPartially' test.out

#- 45 UpdateUserProfileStatus
# body param: body
echo '{"status": "ACTIVE"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op UpdateUserProfileStatus \
    --namespace $AB_NAMESPACE \
    --userId '5nZ1QkXy' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 45 'UpdateUserProfileStatus' test.out

#- 46 PublicGetTime
$CLI_EXE \
    --sn basic \
    --op PublicGetTime \
    > test.out 2>&1
eval_tap $? 46 'PublicGetTime' test.out

#- 47 PublicGetNamespaces
$CLI_EXE \
    --sn basic \
    --op PublicGetNamespaces \
    --activeOnly 'true' \
    > test.out 2>&1
eval_tap $? 47 'PublicGetNamespaces' test.out

#- 48 PublicGeneratedUploadUrl
$CLI_EXE \
    --sn basic \
    --op PublicGeneratedUploadUrl \
    --folder '6WIg0Zup' \
    --namespace $AB_NAMESPACE \
    --fileType 'wPjN4XDU' \
    > test.out 2>&1
eval_tap $? 48 'PublicGeneratedUploadUrl' test.out

#- 49 PublicGetCountries
eval_tap 0 49 'PublicGetCountries # SKIP deprecated' test.out

#- 50 PublicGetLanguages
$CLI_EXE \
    --sn basic \
    --op PublicGetLanguages \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 50 'PublicGetLanguages' test.out

#- 51 PublicGetTimeZones
$CLI_EXE \
    --sn basic \
    --op PublicGetTimeZones \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 51 'PublicGetTimeZones' test.out

#- 52 PublicGetUserProfilePublicInfoByIds
$CLI_EXE \
    --sn basic \
    --op PublicGetUserProfilePublicInfoByIds \
    --namespace $AB_NAMESPACE \
    --userIds 'RKTToH93' \
    > test.out 2>&1
eval_tap $? 52 'PublicGetUserProfilePublicInfoByIds' test.out

#- 53 PublicGetUserProfileInfoByPublicId
$CLI_EXE \
    --sn basic \
    --op PublicGetUserProfileInfoByPublicId \
    --namespace $AB_NAMESPACE \
    --publicId 'HBZX7khu' \
    > test.out 2>&1
eval_tap $? 53 'PublicGetUserProfileInfoByPublicId' test.out

#- 54 PublicGetNamespacePublisher
$CLI_EXE \
    --sn basic \
    --op PublicGetNamespacePublisher \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 54 'PublicGetNamespacePublisher' test.out

#- 55 GetMyProfileInfo
$CLI_EXE \
    --sn basic \
    --op GetMyProfileInfo \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 55 'GetMyProfileInfo' test.out

#- 56 UpdateMyProfile
# body param: body
echo '{"avatarLargeUrl": "GB57jp2j", "avatarSmallUrl": "Fya1beGh", "avatarUrl": "hjX4Npc0", "customAttributes": {"kziLvOCr": {}, "68CjpeBO": {}, "mE7rnciH": {}}, "dateOfBirth": "1977-05-12", "firstName": "SmTLl84R", "language": "nhhz-Puxp_580", "lastName": "UQxhUDPW", "privateCustomAttributes": {"0EwuqtCd": {}, "1pA1qrlP": {}, "XYgdCfnZ": {}}, "timeZone": "1AePlzuz", "zipCode": "WCjOjBV0"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op UpdateMyProfile \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 56 'UpdateMyProfile' test.out

#- 57 CreateMyProfile
# body param: body
echo '{"avatarLargeUrl": "9f8yRwhD", "avatarSmallUrl": "84KuXI9p", "avatarUrl": "BH2UGj6D", "customAttributes": {"mI9khOQq": {}, "m7CQkjhF": {}, "VPOHMK02": {}}, "dateOfBirth": "1973-01-23", "firstName": "1iUjLplj", "language": "an_662", "lastName": "Zm5D1kTp", "privateCustomAttributes": {"y44eQslX": {}, "p5V4fRUs": {}, "Nrd5vikd": {}}, "timeZone": "4Xnyf2Pj"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op CreateMyProfile \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 57 'CreateMyProfile' test.out

#- 58 GetMyPrivateCustomAttributesInfo
$CLI_EXE \
    --sn basic \
    --op GetMyPrivateCustomAttributesInfo \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 58 'GetMyPrivateCustomAttributesInfo' test.out

#- 59 UpdateMyPrivateCustomAttributesPartially
# body param: body
echo '{"4jqYtjXF": {}, "dIdxI4Fg": {}, "hi1PjEZM": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op UpdateMyPrivateCustomAttributesPartially \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 59 'UpdateMyPrivateCustomAttributesPartially' test.out

#- 60 GetMyZipCode
$CLI_EXE \
    --sn basic \
    --op GetMyZipCode \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 60 'GetMyZipCode' test.out

#- 61 UpdateMyZipCode
# body param: userZipCodeUpdate
echo '{"zipCode": "PC1POoyf"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op UpdateMyZipCode \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 61 'UpdateMyZipCode' test.out

#- 62 PublicReportUser
# body param: body
echo '{"category": "qCuXKT7c", "description": "PpmaQyve", "gameSessionId": "Q7oVd2g1", "subcategory": "9KdjM2sr", "userId": "JB1FUlFi"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op PublicReportUser \
    --namespace $AB_NAMESPACE \
    --userId 'zK1GbinU' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 62 'PublicReportUser' test.out

#- 63 PublicGeneratedUserUploadContentUrl
$CLI_EXE \
    --sn basic \
    --op PublicGeneratedUserUploadContentUrl \
    --namespace $AB_NAMESPACE \
    --userId 'hi590v82' \
    --category 'WewLPjF6' \
    --fileType 'CqFmhFKq' \
    > test.out 2>&1
eval_tap $? 63 'PublicGeneratedUserUploadContentUrl' test.out

#- 64 PublicGetUserProfileInfo
$CLI_EXE \
    --sn basic \
    --op PublicGetUserProfileInfo \
    --namespace $AB_NAMESPACE \
    --userId '5B4nUOAY' \
    > test.out 2>&1
eval_tap $? 64 'PublicGetUserProfileInfo' test.out

#- 65 PublicUpdateUserProfile
# body param: body
echo '{"avatarLargeUrl": "rkNse1vm", "avatarSmallUrl": "xJjy65Ox", "avatarUrl": "Q10luTjA", "customAttributes": {"1tBez9N2": {}, "gaYvJ1ZD": {}, "JwUXYsOH": {}}, "dateOfBirth": "1991-05-20", "firstName": "1H4lzcnX", "language": "sq-877", "lastName": "DbPGirJZ", "privateCustomAttributes": {"toAzSzse": {}, "1NsTZF75": {}, "rkxIrcyP": {}}, "timeZone": "RJ5bnFSM", "zipCode": "mGdgc6sI"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op PublicUpdateUserProfile \
    --namespace $AB_NAMESPACE \
    --userId 'jm8TN5d1' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 65 'PublicUpdateUserProfile' test.out

#- 66 PublicCreateUserProfile
# body param: body
echo '{"avatarLargeUrl": "rFFlmYQU", "avatarSmallUrl": "TGJJvGyi", "avatarUrl": "ftA1o7Dh", "customAttributes": {"wBparaxv": {}, "vq3HDlTL": {}, "zKOoQEje": {}}, "dateOfBirth": "1995-03-06", "firstName": "8NXKoaVo", "language": "Rr_uXxS-IM", "lastName": "WavePKlO", "timeZone": "p4YSmr7n"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op PublicCreateUserProfile \
    --namespace $AB_NAMESPACE \
    --userId 'KaEasZjb' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 66 'PublicCreateUserProfile' test.out

#- 67 PublicGetCustomAttributesInfo
$CLI_EXE \
    --sn basic \
    --op PublicGetCustomAttributesInfo \
    --namespace $AB_NAMESPACE \
    --userId '2SWqcHnY' \
    > test.out 2>&1
eval_tap $? 67 'PublicGetCustomAttributesInfo' test.out

#- 68 PublicUpdateCustomAttributesPartially
# body param: body
echo '{"60ZLl1Zv": {}, "zxaY8UQm": {}, "oeY9uZlt": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op PublicUpdateCustomAttributesPartially \
    --namespace $AB_NAMESPACE \
    --userId 'D8CMkMQn' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 68 'PublicUpdateCustomAttributesPartially' test.out

#- 69 PublicGetUserProfilePublicInfo
$CLI_EXE \
    --sn basic \
    --op PublicGetUserProfilePublicInfo \
    --namespace $AB_NAMESPACE \
    --userId 'ad1vnuFh' \
    > test.out 2>&1
eval_tap $? 69 'PublicGetUserProfilePublicInfo' test.out

#- 70 PublicUpdateUserProfileStatus
# body param: body
echo '{"status": "ACTIVE"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op PublicUpdateUserProfileStatus \
    --namespace $AB_NAMESPACE \
    --userId 'fmi9PhFP' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 70 'PublicUpdateUserProfileStatus' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE