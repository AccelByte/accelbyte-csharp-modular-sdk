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
echo "1..62"

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
    --activeOnly 'true' \
    > test.out 2>&1
eval_tap $? 2 'GetNamespaces' test.out

#- 3 CreateNamespace
# body param: body
echo '{"displayName": "Fs5kNIBi", "namespace": "4J0a1l58"}' > $TEMP_JSON_INPUT
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

#- 6 UpdateNamespace
# body param: body
echo '{"displayName": "VKA9M2kv"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op UpdateNamespace \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 6 'UpdateNamespace' test.out

#- 7 GetChildNamespaces
$CLI_EXE \
    --sn basic \
    --op GetChildNamespaces \
    --namespace $AB_NAMESPACE \
    --activeOnly 'true' \
    > test.out 2>&1
eval_tap $? 7 'GetChildNamespaces' test.out

#- 8 CreateConfig
# body param: body
echo '{"key": "oQWwRUpF", "value": "dtcr4GN6"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op CreateConfig \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 8 'CreateConfig' test.out

#- 9 GetConfig
$CLI_EXE \
    --sn basic \
    --op GetConfig \
    --configKey 'rmo7Yqw2' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 9 'GetConfig' test.out

#- 10 DeleteConfig
$CLI_EXE \
    --sn basic \
    --op DeleteConfig \
    --configKey 'KXDYDaaC' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 10 'DeleteConfig' test.out

#- 11 UpdateConfig
# body param: body
echo '{"value": "AKknOZoR"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op UpdateConfig \
    --configKey 'krnGXUS7' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 11 'UpdateConfig' test.out

#- 12 GetNamespaceContext
$CLI_EXE \
    --sn basic \
    --op GetNamespaceContext \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 12 'GetNamespaceContext' test.out

#- 13 GeneratedUploadUrl
$CLI_EXE \
    --sn basic \
    --op GeneratedUploadUrl \
    --folder 'CdRHhmfa' \
    --namespace $AB_NAMESPACE \
    --fileType 'ha6w1gCD' \
    > test.out 2>&1
eval_tap $? 13 'GeneratedUploadUrl' test.out

#- 14 GetGameNamespaces
$CLI_EXE \
    --sn basic \
    --op GetGameNamespaces \
    --namespace $AB_NAMESPACE \
    --activeOnly 'false' \
    > test.out 2>&1
eval_tap $? 14 'GetGameNamespaces' test.out

#- 15 GetCountries
eval_tap 0 15 'GetCountries # SKIP deprecated' test.out

#- 16 GetCountryGroups
$CLI_EXE \
    --sn basic \
    --op GetCountryGroups \
    --namespace $AB_NAMESPACE \
    --groupCode 'L1sYEFF8' \
    > test.out 2>&1
eval_tap $? 16 'GetCountryGroups' test.out

#- 17 AddCountryGroup
# body param: body
echo '{"countries": [{"code": "f4Y6q4lX", "name": "R7Hxv2JM"}, {"code": "izp2f0yn", "name": "bM4uDXAc"}, {"code": "lRweqMgi", "name": "SaRnJYHX"}], "countryGroupCode": "oYl39Vdq", "countryGroupName": "UDtvOaJ2"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op AddCountryGroup \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 17 'AddCountryGroup' test.out

#- 18 UpdateCountryGroup
# body param: body
echo '{"countries": [{"code": "H9rgcIko", "name": "XVaRswvs"}, {"code": "ClR8yaPB", "name": "87dwqPNu"}, {"code": "2SDOmv0e", "name": "fJcC8n6z"}], "countryGroupName": "hzUcNFLl"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op UpdateCountryGroup \
    --countryGroupCode 'X0LB22jq' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 18 'UpdateCountryGroup' test.out

#- 19 DeleteCountryGroup
$CLI_EXE \
    --sn basic \
    --op DeleteCountryGroup \
    --countryGroupCode '1FqJ7GB3' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 19 'DeleteCountryGroup' test.out

#- 20 GetLanguages
$CLI_EXE \
    --sn basic \
    --op GetLanguages \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 20 'GetLanguages' test.out

#- 21 GetTimeZones
$CLI_EXE \
    --sn basic \
    --op GetTimeZones \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 21 'GetTimeZones' test.out

#- 22 GetUserProfileInfoByPublicId
$CLI_EXE \
    --sn basic \
    --op GetUserProfileInfoByPublicId \
    --namespace $AB_NAMESPACE \
    --publicId 'nO4RbWam' \
    > test.out 2>&1
eval_tap $? 22 'GetUserProfileInfoByPublicId' test.out

#- 23 AdminGetUserProfilePublicInfoByIds
# body param: body
echo '{"userIds": ["gyFO5ZwY", "3m5EFp6O", "1yylhFwx"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op AdminGetUserProfilePublicInfoByIds \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 23 'AdminGetUserProfilePublicInfoByIds' test.out

#- 24 GetNamespacePublisher
$CLI_EXE \
    --sn basic \
    --op GetNamespacePublisher \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 24 'GetNamespacePublisher' test.out

#- 25 GetPublisherConfig
$CLI_EXE \
    --sn basic \
    --op GetPublisherConfig \
    --configKey 'Ho427y7p' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 25 'GetPublisherConfig' test.out

#- 26 ChangeNamespaceStatus
# body param: body
echo '{"status": "ACTIVE"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op ChangeNamespaceStatus \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 26 'ChangeNamespaceStatus' test.out

#- 27 AnonymizeUserProfile
$CLI_EXE \
    --sn basic \
    --op AnonymizeUserProfile \
    --namespace $AB_NAMESPACE \
    --userId 'Gpd49A9C' \
    > test.out 2>&1
eval_tap $? 27 'AnonymizeUserProfile' test.out

#- 28 GeneratedUserUploadContentUrl
$CLI_EXE \
    --sn basic \
    --op GeneratedUserUploadContentUrl \
    --namespace $AB_NAMESPACE \
    --userId 'GxNGCtqp' \
    --category 'OIr8LFEO' \
    --fileType 'jqZGSeF6' \
    > test.out 2>&1
eval_tap $? 28 'GeneratedUserUploadContentUrl' test.out

#- 29 GetUserProfileInfo
$CLI_EXE \
    --sn basic \
    --op GetUserProfileInfo \
    --namespace $AB_NAMESPACE \
    --userId 'vk91HDM8' \
    > test.out 2>&1
eval_tap $? 29 'GetUserProfileInfo' test.out

#- 30 UpdateUserProfile
# body param: body
echo '{"avatarLargeUrl": "R0J5LleH", "avatarSmallUrl": "7sMMeiaI", "avatarUrl": "c0dcpOCL", "customAttributes": {"yz7s2jJc": {}, "YHAykLMl": {}, "SDtil7EQ": {}}, "dateOfBirth": "1993-07-21", "firstName": "fRAVoq5B", "language": "rf_Zhbc-229", "lastName": "yXLMh1Vk", "privateCustomAttributes": {"3WV6OoEu": {}, "KstDp3ox": {}, "HYqQwBoC": {}}, "status": "ACTIVE", "timeZone": "bbSACFes", "zipCode": "skWJqWof"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op UpdateUserProfile \
    --namespace $AB_NAMESPACE \
    --userId 'zuoLXUcF' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 30 'UpdateUserProfile' test.out

#- 31 DeleteUserProfile
$CLI_EXE \
    --sn basic \
    --op DeleteUserProfile \
    --namespace $AB_NAMESPACE \
    --userId 'qkfMdiqi' \
    > test.out 2>&1
eval_tap $? 31 'DeleteUserProfile' test.out

#- 32 GetCustomAttributesInfo
$CLI_EXE \
    --sn basic \
    --op GetCustomAttributesInfo \
    --namespace $AB_NAMESPACE \
    --userId 'BD4RAFzn' \
    > test.out 2>&1
eval_tap $? 32 'GetCustomAttributesInfo' test.out

#- 33 UpdateCustomAttributesPartially
# body param: body
echo '{"vptThk0o": {}, "y1rnCwQR": {}, "puMSkqIJ": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op UpdateCustomAttributesPartially \
    --namespace $AB_NAMESPACE \
    --userId 'wzHRRE85' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 33 'UpdateCustomAttributesPartially' test.out

#- 34 GetPrivateCustomAttributesInfo
$CLI_EXE \
    --sn basic \
    --op GetPrivateCustomAttributesInfo \
    --namespace $AB_NAMESPACE \
    --userId '1pueVhs4' \
    > test.out 2>&1
eval_tap $? 34 'GetPrivateCustomAttributesInfo' test.out

#- 35 UpdatePrivateCustomAttributesPartially
# body param: body
echo '{"fzrDv8ay": {}, "MWfEOzvJ": {}, "SvgVfom6": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op UpdatePrivateCustomAttributesPartially \
    --namespace $AB_NAMESPACE \
    --userId '5F6Dm73c' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 35 'UpdatePrivateCustomAttributesPartially' test.out

#- 36 UpdateUserProfileStatus
# body param: body
echo '{"status": "ACTIVE"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op UpdateUserProfileStatus \
    --namespace $AB_NAMESPACE \
    --userId '6yTMptgj' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 36 'UpdateUserProfileStatus' test.out

#- 37 PublicGetTime
$CLI_EXE \
    --sn basic \
    --op PublicGetTime \
    > test.out 2>&1
eval_tap $? 37 'PublicGetTime' test.out

#- 38 PublicGetNamespaces
$CLI_EXE \
    --sn basic \
    --op PublicGetNamespaces \
    --activeOnly 'true' \
    > test.out 2>&1
eval_tap $? 38 'PublicGetNamespaces' test.out

#- 39 GetNamespace1
$CLI_EXE \
    --sn basic \
    --op GetNamespace1 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 39 'GetNamespace1' test.out

#- 40 PublicGeneratedUploadUrl
$CLI_EXE \
    --sn basic \
    --op PublicGeneratedUploadUrl \
    --folder 'otbtOB3s' \
    --namespace $AB_NAMESPACE \
    --fileType 'gdtAh8Cx' \
    > test.out 2>&1
eval_tap $? 40 'PublicGeneratedUploadUrl' test.out

#- 41 PublicGetCountries
eval_tap 0 41 'PublicGetCountries # SKIP deprecated' test.out

#- 42 PublicGetLanguages
$CLI_EXE \
    --sn basic \
    --op PublicGetLanguages \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 42 'PublicGetLanguages' test.out

#- 43 PublicGetTimeZones
$CLI_EXE \
    --sn basic \
    --op PublicGetTimeZones \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 43 'PublicGetTimeZones' test.out

#- 44 PublicGetUserProfilePublicInfoByIds
$CLI_EXE \
    --sn basic \
    --op PublicGetUserProfilePublicInfoByIds \
    --namespace $AB_NAMESPACE \
    --userIds 'vHBZnrgK' \
    > test.out 2>&1
eval_tap $? 44 'PublicGetUserProfilePublicInfoByIds' test.out

#- 45 PublicBulkGetUserProfilePublicInfo
# body param: body
echo '{"userIds": ["zSb4Ldlq", "N6RKQ84Z", "SVrM5lpy"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op PublicBulkGetUserProfilePublicInfo \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 45 'PublicBulkGetUserProfilePublicInfo' test.out

#- 46 PublicGetUserProfileInfoByPublicId
$CLI_EXE \
    --sn basic \
    --op PublicGetUserProfileInfoByPublicId \
    --namespace $AB_NAMESPACE \
    --publicId 'VLQSbdzf' \
    > test.out 2>&1
eval_tap $? 46 'PublicGetUserProfileInfoByPublicId' test.out

#- 47 PublicGetNamespacePublisher
$CLI_EXE \
    --sn basic \
    --op PublicGetNamespacePublisher \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 47 'PublicGetNamespacePublisher' test.out

#- 48 GetMyProfileInfo
$CLI_EXE \
    --sn basic \
    --op GetMyProfileInfo \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 48 'GetMyProfileInfo' test.out

#- 49 UpdateMyProfile
# body param: body
echo '{"avatarLargeUrl": "7131XkI5", "avatarSmallUrl": "t47jzjCz", "avatarUrl": "hAS8HBFZ", "customAttributes": {"w6rXPycc": {}, "5PHZxxF1": {}, "tJTvT5Ob": {}}, "dateOfBirth": "1982-10-10", "firstName": "soYaIPfe", "language": "kXu_alAB", "lastName": "SS2y3jqE", "privateCustomAttributes": {"g5GOxXx3": {}, "i80S74ln": {}, "pcLz7xRZ": {}}, "timeZone": "raeu4HQT", "zipCode": "2BM8uieF"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op UpdateMyProfile \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 49 'UpdateMyProfile' test.out

#- 50 CreateMyProfile
# body param: body
echo '{"avatarLargeUrl": "YAFbHPpl", "avatarSmallUrl": "fHAlCPFb", "avatarUrl": "Mpih0LPd", "customAttributes": {"Yx5CP0cV": {}, "ZZR5jg1R": {}, "MCyQNEg2": {}}, "dateOfBirth": "1995-08-23", "firstName": "4Yc0cLVx", "language": "VjPT-Jp", "lastName": "nenkLUY5", "privateCustomAttributes": {"wl48rzaX": {}, "7CtmiqwH": {}, "QVjx72i6": {}}, "timeZone": "kSmgFQIp"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op CreateMyProfile \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 50 'CreateMyProfile' test.out

#- 51 GetMyPrivateCustomAttributesInfo
$CLI_EXE \
    --sn basic \
    --op GetMyPrivateCustomAttributesInfo \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 51 'GetMyPrivateCustomAttributesInfo' test.out

#- 52 UpdateMyPrivateCustomAttributesPartially
# body param: body
echo '{"WyFAYP5U": {}, "ZDzVmnCU": {}, "mcoKZvsG": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op UpdateMyPrivateCustomAttributesPartially \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 52 'UpdateMyPrivateCustomAttributesPartially' test.out

#- 53 GetMyZipCode
$CLI_EXE \
    --sn basic \
    --op GetMyZipCode \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 53 'GetMyZipCode' test.out

#- 54 UpdateMyZipCode
# body param: userZipCodeUpdate
echo '{"zipCode": "5nAj1Vra"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op UpdateMyZipCode \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 54 'UpdateMyZipCode' test.out

#- 55 PublicGeneratedUserUploadContentUrl
$CLI_EXE \
    --sn basic \
    --op PublicGeneratedUserUploadContentUrl \
    --namespace $AB_NAMESPACE \
    --userId 'JyzKNl4o' \
    --category '6D81LQZk' \
    --fileType 'mbjcSold' \
    > test.out 2>&1
eval_tap $? 55 'PublicGeneratedUserUploadContentUrl' test.out

#- 56 PublicGetUserProfileInfo
$CLI_EXE \
    --sn basic \
    --op PublicGetUserProfileInfo \
    --namespace $AB_NAMESPACE \
    --userId 'dMM8lyn3' \
    > test.out 2>&1
eval_tap $? 56 'PublicGetUserProfileInfo' test.out

#- 57 PublicUpdateUserProfile
# body param: body
echo '{"avatarLargeUrl": "MKc8t5OE", "avatarSmallUrl": "ZMo24kNB", "avatarUrl": "WkukJU7x", "customAttributes": {"FrnZw03w": {}, "cyZMehQs": {}, "wTEa4rBO": {}}, "dateOfBirth": "1986-12-20", "firstName": "GSgEX5EY", "language": "ytE_LRcf", "lastName": "Q0lOCOII", "privateCustomAttributes": {"ugO4pUGD": {}, "VcErEYt6": {}, "Xzs9aqV5": {}}, "timeZone": "iTTuI0Ui", "zipCode": "6mha7P9U"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op PublicUpdateUserProfile \
    --namespace $AB_NAMESPACE \
    --userId 'Y1boY4tk' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 57 'PublicUpdateUserProfile' test.out

#- 58 PublicCreateUserProfile
# body param: body
echo '{"avatarLargeUrl": "8eEz05Mz", "avatarSmallUrl": "rhnUtZu6", "avatarUrl": "AT3nn9kj", "customAttributes": {"YzBUEwik": {}, "pCEjSKoS": {}, "fYwrBoeZ": {}}, "dateOfBirth": "1973-02-01", "firstName": "e6GjJOBa", "language": "Tbcj_XDII", "lastName": "burM4Pxg", "timeZone": "XrY1J261"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op PublicCreateUserProfile \
    --namespace $AB_NAMESPACE \
    --userId '1olvwdqv' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 58 'PublicCreateUserProfile' test.out

#- 59 PublicGetCustomAttributesInfo
$CLI_EXE \
    --sn basic \
    --op PublicGetCustomAttributesInfo \
    --namespace $AB_NAMESPACE \
    --userId 'jLPZTJWp' \
    > test.out 2>&1
eval_tap $? 59 'PublicGetCustomAttributesInfo' test.out

#- 60 PublicUpdateCustomAttributesPartially
# body param: body
echo '{"dTdQLL8i": {}, "uJH4yyuz": {}, "3cz1GDT0": {}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op PublicUpdateCustomAttributesPartially \
    --namespace $AB_NAMESPACE \
    --userId 'vavEGBNn' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 60 'PublicUpdateCustomAttributesPartially' test.out

#- 61 PublicGetUserProfilePublicInfo
$CLI_EXE \
    --sn basic \
    --op PublicGetUserProfilePublicInfo \
    --namespace $AB_NAMESPACE \
    --userId 'VbhyW0iV' \
    > test.out 2>&1
eval_tap $? 61 'PublicGetUserProfilePublicInfo' test.out

#- 62 PublicUpdateUserProfileStatus
# body param: body
echo '{"status": "INACTIVE"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn basic \
    --op PublicUpdateUserProfileStatus \
    --namespace $AB_NAMESPACE \
    --userId 'ucbgqtTw' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 62 'PublicUpdateUserProfileStatus' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE