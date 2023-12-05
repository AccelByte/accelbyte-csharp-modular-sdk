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
echo "1..64"

#- 1 Login
$CLI_EXE --op login --lt user --user user --pass user > test.out 2>&1
eval_tap $? 1 'Login' test.out

if [ $EXIT_CODE -ne 0 ]; then
  echo "Bail out! Login failed."
  exit $EXIT_CODE
fi

# echo "foo" > "$CLI_TOKEN_FILE"

#- 2 ChangePreferenceConsent
# body param: body
echo '[{"isAccepted": false, "isNeedToSendEventMarketing": true, "localizedPolicyVersionId": "QPbVO8Kx", "policyId": "rKEAC4RH", "policyVersionId": "S4eTmuWH"}, {"isAccepted": true, "isNeedToSendEventMarketing": true, "localizedPolicyVersionId": "tBOJOzHu", "policyId": "1RvMIBhs", "policyVersionId": "tvWsV4gx"}, {"isAccepted": false, "isNeedToSendEventMarketing": false, "localizedPolicyVersionId": "XSfxyDGx", "policyId": "OfuzgjFR", "policyVersionId": "WcPtSF4U"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op ChangePreferenceConsent \
    --namespace $AB_NAMESPACE \
    --userId 'V2ti9pkK' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 2 'ChangePreferenceConsent' test.out

#- 3 RetrieveAcceptedAgreements
$CLI_EXE \
    --sn legal \
    --op RetrieveAcceptedAgreements \
    --userId 'RZQ2TKRv' \
    > test.out 2>&1
eval_tap $? 3 'RetrieveAcceptedAgreements' test.out

#- 4 RetrieveAllUsersByPolicyVersion
$CLI_EXE \
    --sn legal \
    --op RetrieveAllUsersByPolicyVersion \
    --keyword 'c9WG83WH' \
    --limit '96' \
    --offset '37' \
    --policyVersionId 'ljGdmXQj' \
    > test.out 2>&1
eval_tap $? 4 'RetrieveAllUsersByPolicyVersion' test.out

#- 5 RetrieveAllLegalPolicies
$CLI_EXE \
    --sn legal \
    --op RetrieveAllLegalPolicies \
    > test.out 2>&1
eval_tap $? 5 'RetrieveAllLegalPolicies' test.out

#- 6 CreatePolicy
# body param: body
echo '{"affectedClientIds": ["FUVGTdc8", "05eIfmXK", "FdmiMOjG"], "affectedCountries": ["CmnCTNGH", "nHNRyRUc", "bm0xR1YQ"], "basePolicyName": "POgZWvnO", "description": "PyBw34Vu", "namespace": "zcD5kqIk", "tags": ["ZK1edMt0", "6vJP7hlf", "3hW9dLzC"], "typeId": "IVN23JuD"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op CreatePolicy \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 6 'CreatePolicy' test.out

#- 7 RetrieveSinglePolicy
$CLI_EXE \
    --sn legal \
    --op RetrieveSinglePolicy \
    --basePolicyId 'YzkfTXTf' \
    > test.out 2>&1
eval_tap $? 7 'RetrieveSinglePolicy' test.out

#- 8 PartialUpdatePolicy
# body param: body
echo '{"affectedClientIds": ["P9Te5e5I", "ZuUR8Oo0", "bxjgNyJI"], "affectedCountries": ["1T0R51K7", "CFcuDCjb", "nYnftbNo"], "basePolicyName": "IszTgjWx", "description": "zLhW0eZF", "namespace": "GFW7nGY8", "tags": ["PkjcN5xe", "xEksPU9S", "kCVgZ5Yr"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op PartialUpdatePolicy \
    --basePolicyId 'jtDgeE3t' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 8 'PartialUpdatePolicy' test.out

#- 9 RetrievePolicyCountry
$CLI_EXE \
    --sn legal \
    --op RetrievePolicyCountry \
    --basePolicyId 'r31MQKET' \
    --countryCode 'KJPxKMoz' \
    > test.out 2>&1
eval_tap $? 9 'RetrievePolicyCountry' test.out

#- 10 RetrieveLocalizedPolicyVersions
$CLI_EXE \
    --sn legal \
    --op RetrieveLocalizedPolicyVersions \
    --policyVersionId 'YXsvWaV8' \
    > test.out 2>&1
eval_tap $? 10 'RetrieveLocalizedPolicyVersions' test.out

#- 11 CreateLocalizedPolicyVersion
# body param: body
echo '{"contentType": "qSKbfs7G", "description": "bcKjqJn3", "localeCode": "nnRF9XvA"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op CreateLocalizedPolicyVersion \
    --policyVersionId 'FDNwVZDH' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 11 'CreateLocalizedPolicyVersion' test.out

#- 12 RetrieveSingleLocalizedPolicyVersion
$CLI_EXE \
    --sn legal \
    --op RetrieveSingleLocalizedPolicyVersion \
    --localizedPolicyVersionId 'wdgMqkw4' \
    > test.out 2>&1
eval_tap $? 12 'RetrieveSingleLocalizedPolicyVersion' test.out

#- 13 UpdateLocalizedPolicyVersion
# body param: body
echo '{"attachmentChecksum": "NpMHnTQD", "attachmentLocation": "ytC0Bj96", "attachmentVersionIdentifier": "4j9PDtOL", "contentType": "LBl3dVzj", "description": "kXg4w96e"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op UpdateLocalizedPolicyVersion \
    --localizedPolicyVersionId 'CXAbNUBi' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 13 'UpdateLocalizedPolicyVersion' test.out

#- 14 RequestPresignedURL
# body param: body
echo '{"contentMD5": "kdJrOWBS", "contentType": "eBiFfMJZ"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op RequestPresignedURL \
    --localizedPolicyVersionId '9diAj0km' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 14 'RequestPresignedURL' test.out

#- 15 SetDefaultPolicy
$CLI_EXE \
    --sn legal \
    --op SetDefaultPolicy \
    --localizedPolicyVersionId 'lmmRpu7w' \
    > test.out 2>&1
eval_tap $? 15 'SetDefaultPolicy' test.out

#- 16 RetrieveAcceptedAgreementsForMultiUsers
# body param: body
echo '{"currentPublishedOnly": false, "userIds": ["zEAOON2T", "miGZ64kV", "cZl1CND9"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op RetrieveAcceptedAgreementsForMultiUsers \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 16 'RetrieveAcceptedAgreementsForMultiUsers' test.out

#- 17 RetrieveAcceptedAgreements1
$CLI_EXE \
    --sn legal \
    --op RetrieveAcceptedAgreements1 \
    --namespace $AB_NAMESPACE \
    --userId 'HU4opxwB' \
    --excludeOtherNamespacesPolicies 'true' \
    > test.out 2>&1
eval_tap $? 17 'RetrieveAcceptedAgreements1' test.out

#- 18 RetrieveAllUsersByPolicyVersion1
$CLI_EXE \
    --sn legal \
    --op RetrieveAllUsersByPolicyVersion1 \
    --namespace $AB_NAMESPACE \
    --convertGameUserId 'true' \
    --keyword 'bDEJ185Q' \
    --limit '65' \
    --offset '71' \
    --policyVersionId '67yP7V8B' \
    > test.out 2>&1
eval_tap $? 18 'RetrieveAllUsersByPolicyVersion1' test.out

#- 19 RetrieveAllLegalPoliciesByNamespace
$CLI_EXE \
    --sn legal \
    --op RetrieveAllLegalPoliciesByNamespace \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 19 'RetrieveAllLegalPoliciesByNamespace' test.out

#- 20 CreatePolicy1
# body param: body
echo '{"affectedClientIds": ["591SoUym", "7tVmZJGh", "MfzMBEc9"], "affectedCountries": ["Cs5Bj3w7", "MYoMAMgZ", "VmYHX0zU"], "basePolicyName": "LeSeuKFm", "description": "NllxO7bd", "tags": ["pjDfeiZD", "z4EY89PR", "uITCPg1t"], "typeId": "MLvsZ0tK"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op CreatePolicy1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 20 'CreatePolicy1' test.out

#- 21 RetrieveSinglePolicy1
$CLI_EXE \
    --sn legal \
    --op RetrieveSinglePolicy1 \
    --basePolicyId '33O7vRZ4' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 21 'RetrieveSinglePolicy1' test.out

#- 22 PartialUpdatePolicy1
# body param: body
echo '{"affectedClientIds": ["DThBufxb", "cDmIs18d", "gfh7lxLO"], "affectedCountries": ["BbeL9Pe9", "ybGwpc3M", "q8EDRtoi"], "basePolicyName": "ONNfkESd", "description": "9FcIyGNk", "tags": ["08L3ZQQO", "Z3TDjMoL", "hkLExqL1"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op PartialUpdatePolicy1 \
    --basePolicyId 'a9OwoFmi' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 22 'PartialUpdatePolicy1' test.out

#- 23 RetrievePolicyCountry1
$CLI_EXE \
    --sn legal \
    --op RetrievePolicyCountry1 \
    --basePolicyId '8SVQoj25' \
    --countryCode 'u8akITz3' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 23 'RetrievePolicyCountry1' test.out

#- 24 RetrieveLocalizedPolicyVersions1
$CLI_EXE \
    --sn legal \
    --op RetrieveLocalizedPolicyVersions1 \
    --namespace $AB_NAMESPACE \
    --policyVersionId 'OekDKycu' \
    > test.out 2>&1
eval_tap $? 24 'RetrieveLocalizedPolicyVersions1' test.out

#- 25 CreateLocalizedPolicyVersion1
# body param: body
echo '{"contentType": "PTk2sfCJ", "description": "At4Baksy", "localeCode": "Zyvd7hlJ"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op CreateLocalizedPolicyVersion1 \
    --namespace $AB_NAMESPACE \
    --policyVersionId '2RrAJu5u' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 25 'CreateLocalizedPolicyVersion1' test.out

#- 26 RetrieveSingleLocalizedPolicyVersion1
$CLI_EXE \
    --sn legal \
    --op RetrieveSingleLocalizedPolicyVersion1 \
    --localizedPolicyVersionId 'q3ENwTWN' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 26 'RetrieveSingleLocalizedPolicyVersion1' test.out

#- 27 UpdateLocalizedPolicyVersion1
# body param: body
echo '{"attachmentChecksum": "JQqIM0yf", "attachmentLocation": "hLYPhQH8", "attachmentVersionIdentifier": "sRpIawM9", "contentType": "UUnoBvKY", "description": "TAKibwjl"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op UpdateLocalizedPolicyVersion1 \
    --localizedPolicyVersionId 'Kb6yLuqR' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 27 'UpdateLocalizedPolicyVersion1' test.out

#- 28 RequestPresignedURL1
# body param: body
echo '{"contentMD5": "F1Ld772m", "contentType": "TK0JN6v4"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op RequestPresignedURL1 \
    --localizedPolicyVersionId 'Tjd0vRRd' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 28 'RequestPresignedURL1' test.out

#- 29 SetDefaultPolicy1
$CLI_EXE \
    --sn legal \
    --op SetDefaultPolicy1 \
    --localizedPolicyVersionId 'B9r851UV' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 29 'SetDefaultPolicy1' test.out

#- 30 UpdatePolicyVersion1
# body param: body
echo '{"description": "3Hg6QcSE", "displayVersion": "K9g4vrow", "isCommitted": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op UpdatePolicyVersion1 \
    --namespace $AB_NAMESPACE \
    --policyVersionId 'FQOCWXeJ' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 30 'UpdatePolicyVersion1' test.out

#- 31 PublishPolicyVersion1
$CLI_EXE \
    --sn legal \
    --op PublishPolicyVersion1 \
    --namespace $AB_NAMESPACE \
    --policyVersionId '2gU6bFqZ' \
    --shouldNotify 'false' \
    > test.out 2>&1
eval_tap $? 31 'PublishPolicyVersion1' test.out

#- 32 UpdatePolicy1
# body param: body
echo '{"description": "Cr5XzhJ8", "isDefaultOpted": false, "isMandatory": false, "policyName": "gpxs2Ij1", "readableId": "HF59AXBb", "shouldNotifyOnUpdate": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op UpdatePolicy1 \
    --namespace $AB_NAMESPACE \
    --policyId 'bSEeV8y5' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 32 'UpdatePolicy1' test.out

#- 33 SetDefaultPolicy3
$CLI_EXE \
    --sn legal \
    --op SetDefaultPolicy3 \
    --namespace $AB_NAMESPACE \
    --policyId 'MX6evutp' \
    > test.out 2>&1
eval_tap $? 33 'SetDefaultPolicy3' test.out

#- 34 RetrieveSinglePolicyVersion1
$CLI_EXE \
    --sn legal \
    --op RetrieveSinglePolicyVersion1 \
    --namespace $AB_NAMESPACE \
    --policyId 'IauG11FW' \
    --versionId 'QbozojmN' \
    > test.out 2>&1
eval_tap $? 34 'RetrieveSinglePolicyVersion1' test.out

#- 35 CreatePolicyVersion1
# body param: body
echo '{"description": "W4wqYMaw", "displayVersion": "bY80cLIT", "isCommitted": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op CreatePolicyVersion1 \
    --namespace $AB_NAMESPACE \
    --policyId 'hNwlq5Yw' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 35 'CreatePolicyVersion1' test.out

#- 36 RetrieveAllPolicyTypes1
$CLI_EXE \
    --sn legal \
    --op RetrieveAllPolicyTypes1 \
    --namespace $AB_NAMESPACE \
    --offset '27' \
    --limit '67' \
    > test.out 2>&1
eval_tap $? 36 'RetrieveAllPolicyTypes1' test.out

#- 37 IndirectBulkAcceptVersionedPolicy
# body param: body
echo '[{"isAccepted": false, "isNeedToSendEventMarketing": false, "localizedPolicyVersionId": "Exkd3DvI", "policyId": "C7sO6yk1", "policyVersionId": "Q9F0WfS3"}, {"isAccepted": false, "isNeedToSendEventMarketing": true, "localizedPolicyVersionId": "xcPYU2pd", "policyId": "kHYZl9wg", "policyVersionId": "Qwg0WdxD"}, {"isAccepted": false, "isNeedToSendEventMarketing": true, "localizedPolicyVersionId": "9SP2Yj09", "policyId": "H0IAusBt", "policyVersionId": "4G6eP9Oz"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op IndirectBulkAcceptVersionedPolicy \
    --namespace $AB_NAMESPACE \
    --userId 'fEjAvHuu' \
    --publisherUserId '0FridM2J' \
    --clientId 'FoQSgR8u' \
    --countryCode 'YpgHaVJ2' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 37 'IndirectBulkAcceptVersionedPolicy' test.out

#- 38 AdminRetrieveEligibilities
$CLI_EXE \
    --sn legal \
    --op AdminRetrieveEligibilities \
    --namespace $AB_NAMESPACE \
    --userId 'H1jqSrxQ' \
    --publisherUserId 'VosWppzA' \
    --clientId 'Cye9ViLy' \
    --countryCode '1Jna8ECS' \
    > test.out 2>&1
eval_tap $? 38 'AdminRetrieveEligibilities' test.out

#- 39 RetrievePolicies
$CLI_EXE \
    --sn legal \
    --op RetrievePolicies \
    --countryCode 'LUfAklD3' \
    > test.out 2>&1
eval_tap $? 39 'RetrievePolicies' test.out

#- 40 UpdatePolicyVersion
# body param: body
echo '{"description": "EkbNXbng", "displayVersion": "lIbc04S3", "isCommitted": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op UpdatePolicyVersion \
    --policyVersionId 'taOl7khC' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 40 'UpdatePolicyVersion' test.out

#- 41 PublishPolicyVersion
$CLI_EXE \
    --sn legal \
    --op PublishPolicyVersion \
    --policyVersionId 'LGmUb6OA' \
    --shouldNotify 'true' \
    > test.out 2>&1
eval_tap $? 41 'PublishPolicyVersion' test.out

#- 42 UpdatePolicy
# body param: body
echo '{"description": "qjhXLDHz", "isDefaultOpted": true, "isMandatory": true, "policyName": "BpbtpObk", "readableId": "wFSMNPwU", "shouldNotifyOnUpdate": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op UpdatePolicy \
    --policyId 'p9UfgCQH' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 42 'UpdatePolicy' test.out

#- 43 SetDefaultPolicy2
$CLI_EXE \
    --sn legal \
    --op SetDefaultPolicy2 \
    --policyId 'ucjFCXN9' \
    > test.out 2>&1
eval_tap $? 43 'SetDefaultPolicy2' test.out

#- 44 RetrieveSinglePolicyVersion
$CLI_EXE \
    --sn legal \
    --op RetrieveSinglePolicyVersion \
    --policyId 'm38d45mU' \
    --versionId 'YNv0tkyS' \
    > test.out 2>&1
eval_tap $? 44 'RetrieveSinglePolicyVersion' test.out

#- 45 CreatePolicyVersion
# body param: body
echo '{"description": "NnbmJrjJ", "displayVersion": "TbZ9sBZn", "isCommitted": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op CreatePolicyVersion \
    --policyId 'O3mBgGHj' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 45 'CreatePolicyVersion' test.out

#- 46 RetrieveAllPolicyTypes
$CLI_EXE \
    --sn legal \
    --op RetrieveAllPolicyTypes \
    --offset '22' \
    --limit '46' \
    > test.out 2>&1
eval_tap $? 46 'RetrieveAllPolicyTypes' test.out

#- 47 GetUserInfoStatus
$CLI_EXE \
    --sn legal \
    --op GetUserInfoStatus \
    --namespaces 'ffpDlhhl' \
    > test.out 2>&1
eval_tap $? 47 'GetUserInfoStatus' test.out

#- 48 SyncUserInfo
eval_tap 0 48 'SyncUserInfo # SKIP deprecated' test.out

#- 49 InvalidateUserInfoCache
eval_tap 0 49 'InvalidateUserInfoCache # SKIP deprecated' test.out

#- 50 AnonymizeUserAgreement
$CLI_EXE \
    --sn legal \
    --op AnonymizeUserAgreement \
    --userId 'a02tuR7H' \
    > test.out 2>&1
eval_tap $? 50 'AnonymizeUserAgreement' test.out

#- 51 ChangePreferenceConsent1
# body param: body
echo '[{"isAccepted": false, "isNeedToSendEventMarketing": true, "localizedPolicyVersionId": "il4ernlx", "policyId": "IEH7MS7U", "policyVersionId": "qvFMfBZg"}, {"isAccepted": true, "isNeedToSendEventMarketing": true, "localizedPolicyVersionId": "xnsmkO7d", "policyId": "b8e9M4ay", "policyVersionId": "Skcsjck7"}, {"isAccepted": true, "isNeedToSendEventMarketing": false, "localizedPolicyVersionId": "WT0Bt049", "policyId": "Dj66sUtE", "policyVersionId": "TSVDcwQd"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op ChangePreferenceConsent1 \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 51 'ChangePreferenceConsent1' test.out

#- 52 AcceptVersionedPolicy
$CLI_EXE \
    --sn legal \
    --op AcceptVersionedPolicy \
    --localizedPolicyVersionId 'cVOmUlQA' \
    > test.out 2>&1
eval_tap $? 52 'AcceptVersionedPolicy' test.out

#- 53 RetrieveAgreementsPublic
$CLI_EXE \
    --sn legal \
    --op RetrieveAgreementsPublic \
    > test.out 2>&1
eval_tap $? 53 'RetrieveAgreementsPublic' test.out

#- 54 BulkAcceptVersionedPolicy
# body param: body
echo '[{"isAccepted": false, "isNeedToSendEventMarketing": true, "localizedPolicyVersionId": "hD7yiD8X", "policyId": "39UFi4yy", "policyVersionId": "FgqTO2as"}, {"isAccepted": true, "isNeedToSendEventMarketing": true, "localizedPolicyVersionId": "tolzzUOf", "policyId": "aUGD7jik", "policyVersionId": "g460y0JE"}, {"isAccepted": false, "isNeedToSendEventMarketing": false, "localizedPolicyVersionId": "eyPmSg6x", "policyId": "p5zvbUU3", "policyVersionId": "QpgaksDq"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op BulkAcceptVersionedPolicy \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 54 'BulkAcceptVersionedPolicy' test.out

#- 55 IndirectBulkAcceptVersionedPolicyV2
eval_tap 0 55 'IndirectBulkAcceptVersionedPolicyV2 # SKIP deprecated' test.out

#- 56 IndirectBulkAcceptVersionedPolicy1
# body param: body
echo '[{"isAccepted": true, "isNeedToSendEventMarketing": false, "localizedPolicyVersionId": "nbJKB0NW", "policyId": "Zl0v8DB5", "policyVersionId": "Uks98zn5"}, {"isAccepted": true, "isNeedToSendEventMarketing": false, "localizedPolicyVersionId": "yXmpL92H", "policyId": "7q7YlR52", "policyVersionId": "LH4nnlE8"}, {"isAccepted": false, "isNeedToSendEventMarketing": true, "localizedPolicyVersionId": "juru9e4G", "policyId": "ysmCFp3R", "policyVersionId": "2XrOSMpB"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op IndirectBulkAcceptVersionedPolicy1 \
    --userId 'GhsGQqxj' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 56 'IndirectBulkAcceptVersionedPolicy1' test.out

#- 57 RetrieveEligibilitiesPublic
$CLI_EXE \
    --sn legal \
    --op RetrieveEligibilitiesPublic \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 57 'RetrieveEligibilitiesPublic' test.out

#- 58 RetrieveEligibilitiesPublicIndirect
$CLI_EXE \
    --sn legal \
    --op RetrieveEligibilitiesPublicIndirect \
    --clientId 'vdSTkf6X' \
    --countryCode 'YBERAx60' \
    --namespace $AB_NAMESPACE \
    --userId 'QrYlEVjh' \
    > test.out 2>&1
eval_tap $? 58 'RetrieveEligibilitiesPublicIndirect' test.out

#- 59 RetrieveSingleLocalizedPolicyVersion2
$CLI_EXE \
    --sn legal \
    --op RetrieveSingleLocalizedPolicyVersion2 \
    --localizedPolicyVersionId 'dEQvch3N' \
    > test.out 2>&1
eval_tap $? 59 'RetrieveSingleLocalizedPolicyVersion2' test.out

#- 60 RetrieveSingleLocalizedPolicyVersion3
$CLI_EXE \
    --sn legal \
    --op RetrieveSingleLocalizedPolicyVersion3 \
    --localizedPolicyVersionId '8hZXNPLT' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 60 'RetrieveSingleLocalizedPolicyVersion3' test.out

#- 61 RetrieveLatestPolicies
$CLI_EXE \
    --sn legal \
    --op RetrieveLatestPolicies \
    --countryCode 'sN92G9CR' \
    --defaultOnEmpty 'false' \
    --policyType 'LEGAL_DOCUMENT_TYPE' \
    --tags 'xrlJhvZG' \
    > test.out 2>&1
eval_tap $? 61 'RetrieveLatestPolicies' test.out

#- 62 RetrieveLatestPoliciesPublic
$CLI_EXE \
    --sn legal \
    --op RetrieveLatestPoliciesPublic \
    --namespace $AB_NAMESPACE \
    --alwaysIncludeDefault 'false' \
    --defaultOnEmpty 'false' \
    --policyType 'MARKETING_PREFERENCE_TYPE' \
    --tags 'WkfArvR5' \
    > test.out 2>&1
eval_tap $? 62 'RetrieveLatestPoliciesPublic' test.out

#- 63 RetrieveLatestPoliciesByNamespaceAndCountryPublic
$CLI_EXE \
    --sn legal \
    --op RetrieveLatestPoliciesByNamespaceAndCountryPublic \
    --countryCode 'wo5gVrBy' \
    --namespace $AB_NAMESPACE \
    --alwaysIncludeDefault 'true' \
    --defaultOnEmpty 'false' \
    --policyType 'MARKETING_PREFERENCE_TYPE' \
    --tags 'SruuHYpv' \
    > test.out 2>&1
eval_tap $? 63 'RetrieveLatestPoliciesByNamespaceAndCountryPublic' test.out

#- 64 CheckReadiness
$CLI_EXE \
    --sn legal \
    --op CheckReadiness \
    > test.out 2>&1
eval_tap $? 64 'CheckReadiness' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE