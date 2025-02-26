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
echo "1..75"

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
echo '[{"isAccepted": true, "isNeedToSendEventMarketing": false, "localizedPolicyVersionId": "UOs6bXQC", "policyId": "nY70t1dD", "policyVersionId": "jDNQXzy7"}, {"isAccepted": true, "isNeedToSendEventMarketing": false, "localizedPolicyVersionId": "cDsrqpNs", "policyId": "2HRRPkb4", "policyVersionId": "vUOtduyz"}, {"isAccepted": false, "isNeedToSendEventMarketing": false, "localizedPolicyVersionId": "gGTpCb2d", "policyId": "V0QmH1HL", "policyVersionId": "T0B37Fzy"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op ChangePreferenceConsent \
    --namespace $AB_NAMESPACE \
    --userId 'UkYWbxGK' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 2 'ChangePreferenceConsent' test.out

#- 3 RetrieveAcceptedAgreements
$CLI_EXE \
    --sn legal \
    --op RetrieveAcceptedAgreements \
    --userId '3IIOf3gc' \
    > test.out 2>&1
eval_tap $? 3 'RetrieveAcceptedAgreements' test.out

#- 4 RetrieveAllUsersByPolicyVersion
$CLI_EXE \
    --sn legal \
    --op RetrieveAllUsersByPolicyVersion \
    --keyword 'VMyWr9mO' \
    --limit '49' \
    --offset '65' \
    --policyVersionId 'jEV5vrik' \
    > test.out 2>&1
eval_tap $? 4 'RetrieveAllUsersByPolicyVersion' test.out

#- 5 RetrieveAllLegalPolicies
$CLI_EXE \
    --sn legal \
    --op RetrieveAllLegalPolicies \
    --visibleOnly 'false' \
    > test.out 2>&1
eval_tap $? 5 'RetrieveAllLegalPolicies' test.out

#- 6 CreatePolicy
# body param: body
echo '{"affectedClientIds": ["yDW9qZEu", "mTu6bvmI", "ApAgMbD5"], "affectedCountries": ["ekqLwaq0", "sNOulpwf", "mPTUysTR"], "basePolicyName": "mggN2JUE", "countryGroupName": "6ZcUBQhd", "countryType": "COUNTRY", "description": "9r0Lecpg", "isHidden": true, "isHiddenPublic": true, "namespace": "KRoHQj98", "tags": ["3bPa2h17", "PPdzeBZn", "PiMdhAWP"], "typeId": "MxCKzHaj"}' > $TEMP_JSON_INPUT
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
    --basePolicyId 'eGb10qdn' \
    > test.out 2>&1
eval_tap $? 7 'RetrieveSinglePolicy' test.out

#- 8 PartialUpdatePolicy
# body param: body
echo '{"affectedClientIds": ["VnX4qIrl", "qF5kPrvH", "ItStY4ht"], "affectedCountries": ["UUZE43ZY", "8DsWS77i", "0ExctWFG"], "basePolicyName": "CyUKQvLq", "countryGroupName": "ymj2HBul", "countryType": "COUNTRY", "description": "8ojL2QgK", "isHidden": true, "isHiddenPublic": true, "namespace": "EklPcY5c", "tags": ["dVLPIyqE", "SaxpiwEA", "NtzWdXbF"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op PartialUpdatePolicy \
    --basePolicyId 'JUeoOYnb' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 8 'PartialUpdatePolicy' test.out

#- 9 RetrievePolicyCountry
$CLI_EXE \
    --sn legal \
    --op RetrievePolicyCountry \
    --basePolicyId 'lOHSLxMq' \
    --countryCode 'mEqRaa24' \
    > test.out 2>&1
eval_tap $? 9 'RetrievePolicyCountry' test.out

#- 10 RetrieveLocalizedPolicyVersions
$CLI_EXE \
    --sn legal \
    --op RetrieveLocalizedPolicyVersions \
    --policyVersionId 'LgYNRiP2' \
    > test.out 2>&1
eval_tap $? 10 'RetrieveLocalizedPolicyVersions' test.out

#- 11 CreateLocalizedPolicyVersion
# body param: body
echo '{"contentType": "2omlxEuF", "description": "nxw2FtXA", "localeCode": "lJRjqSjd"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op CreateLocalizedPolicyVersion \
    --policyVersionId 'DmlgSF3M' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 11 'CreateLocalizedPolicyVersion' test.out

#- 12 RetrieveSingleLocalizedPolicyVersion
$CLI_EXE \
    --sn legal \
    --op RetrieveSingleLocalizedPolicyVersion \
    --localizedPolicyVersionId '76036x4Q' \
    > test.out 2>&1
eval_tap $? 12 'RetrieveSingleLocalizedPolicyVersion' test.out

#- 13 UpdateLocalizedPolicyVersion
# body param: body
echo '{"attachmentChecksum": "rAF5Zg8I", "attachmentLocation": "zsWAnJbX", "attachmentVersionIdentifier": "iWO8FKPe", "contentType": "RvGf3OTp", "description": "cUne5hzR"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op UpdateLocalizedPolicyVersion \
    --localizedPolicyVersionId 'pt62HOOT' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 13 'UpdateLocalizedPolicyVersion' test.out

#- 14 RequestPresignedURL
# body param: body
echo '{"contentMD5": "O9KHI6rh", "contentType": "AbSHH4DG"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op RequestPresignedURL \
    --localizedPolicyVersionId 'u5CijxNi' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 14 'RequestPresignedURL' test.out

#- 15 SetDefaultPolicy
$CLI_EXE \
    --sn legal \
    --op SetDefaultPolicy \
    --localizedPolicyVersionId 'gonfXgC9' \
    > test.out 2>&1
eval_tap $? 15 'SetDefaultPolicy' test.out

#- 16 RetrieveAcceptedAgreementsForMultiUsers
# body param: body
echo '{"currentPublishedOnly": true, "userIds": ["l8IBMHTT", "XDfB2uDk", "VJVMAbU8"]}' > $TEMP_JSON_INPUT
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
    --userId 'zftkiRpo' \
    --excludeOtherNamespacesPolicies 'false' \
    > test.out 2>&1
eval_tap $? 17 'RetrieveAcceptedAgreements1' test.out

#- 18 RetrieveAllUsersByPolicyVersion1
$CLI_EXE \
    --sn legal \
    --op RetrieveAllUsersByPolicyVersion1 \
    --namespace $AB_NAMESPACE \
    --convertGameUserId 'true' \
    --keyword '0TyFP6mx' \
    --limit '54' \
    --offset '70' \
    --policyVersionId 'x1iM9uGb' \
    > test.out 2>&1
eval_tap $? 18 'RetrieveAllUsersByPolicyVersion1' test.out

#- 19 DownloadExportedAgreementsInCSV
$CLI_EXE \
    --sn legal \
    --op DownloadExportedAgreementsInCSV \
    --namespace $AB_NAMESPACE \
    --exportId 'frpgjA6b' \
    > test.out 2>&1
eval_tap $? 19 'DownloadExportedAgreementsInCSV' test.out

#- 20 InitiateExportAgreementsToCSV
$CLI_EXE \
    --sn legal \
    --op InitiateExportAgreementsToCSV \
    --namespace $AB_NAMESPACE \
    --end 'zpJScnHI' \
    --policyVersionId 'bPoY7BSE' \
    --start 'hZpElEsy' \
    > test.out 2>&1
eval_tap $? 20 'InitiateExportAgreementsToCSV' test.out

#- 21 RetrieveAllLegalPoliciesByNamespace
$CLI_EXE \
    --sn legal \
    --op RetrieveAllLegalPoliciesByNamespace \
    --namespace $AB_NAMESPACE \
    --visibleOnly 'true' \
    > test.out 2>&1
eval_tap $? 21 'RetrieveAllLegalPoliciesByNamespace' test.out

#- 22 CreatePolicy1
# body param: body
echo '{"affectedClientIds": ["xXuxEuOz", "WOx9Z7Pz", "vx6JXGkG"], "affectedCountries": ["3BS2UN9s", "uCVCvCQe", "cXdA0fOF"], "basePolicyName": "OLMMhWZx", "countryGroupName": "4URhYUwB", "countryType": "COUNTRY", "description": "zJcaIMfY", "isHidden": true, "isHiddenPublic": true, "tags": ["E0MsJlec", "YOAWJObu", "1rZcKpZx"], "typeId": "efqqOpWC"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op CreatePolicy1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 22 'CreatePolicy1' test.out

#- 23 RetrieveSinglePolicy1
$CLI_EXE \
    --sn legal \
    --op RetrieveSinglePolicy1 \
    --basePolicyId 'z4k1zs7o' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 23 'RetrieveSinglePolicy1' test.out

#- 24 DeleteBasePolicy
$CLI_EXE \
    --sn legal \
    --op DeleteBasePolicy \
    --basePolicyId 'EoVvGe2t' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 24 'DeleteBasePolicy' test.out

#- 25 PartialUpdatePolicy1
# body param: body
echo '{"affectedClientIds": ["pzmXPxfV", "mh7TGLOa", "OOOqWEHZ"], "affectedCountries": ["HtQhxjkH", "IfYvo7xK", "nfRGNSPp"], "basePolicyName": "DClQtBMR", "countryGroupName": "2eA9LvPD", "countryType": "COUNTRY_GROUP", "description": "ivOth8jE", "isHidden": true, "isHiddenPublic": true, "tags": ["OlrDGNcR", "258ASKXp", "9fMvOyjy"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op PartialUpdatePolicy1 \
    --basePolicyId '52rnnU2Q' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 25 'PartialUpdatePolicy1' test.out

#- 26 RetrievePolicyCountry1
$CLI_EXE \
    --sn legal \
    --op RetrievePolicyCountry1 \
    --basePolicyId 'MIYBOSyY' \
    --countryCode 'QAUDblif' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 26 'RetrievePolicyCountry1' test.out

#- 27 RetrieveAllPoliciesFromBasePolicy
$CLI_EXE \
    --sn legal \
    --op RetrieveAllPoliciesFromBasePolicy \
    --basePolicyId '91zeQLor' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 27 'RetrieveAllPoliciesFromBasePolicy' test.out

#- 28 CreatePolicyUnderBasePolicy
# body param: body
echo '{"countries": ["qEGtkJ8C", "PEVDcbLF", "xPiT2aCO"], "countryCode": "3BfTShgM", "countryGroupName": "HJWbVrBN", "countryType": "COUNTRY_GROUP", "description": "twUIi8Ay", "isDefaultSelection": false, "isMandatory": true, "policyName": "6OUYVXl9", "shouldNotifyOnUpdate": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op CreatePolicyUnderBasePolicy \
    --basePolicyId 'wTTuSeuw' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 28 'CreatePolicyUnderBasePolicy' test.out

#- 29 DeleteLocalizedPolicy
$CLI_EXE \
    --sn legal \
    --op DeleteLocalizedPolicy \
    --localizedPolicyVersionId 'B5N7Z2tl' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 29 'DeleteLocalizedPolicy' test.out

#- 30 RetrieveLocalizedPolicyVersions1
$CLI_EXE \
    --sn legal \
    --op RetrieveLocalizedPolicyVersions1 \
    --namespace $AB_NAMESPACE \
    --policyVersionId 'p7bNjSVT' \
    > test.out 2>&1
eval_tap $? 30 'RetrieveLocalizedPolicyVersions1' test.out

#- 31 CreateLocalizedPolicyVersion1
# body param: body
echo '{"contentType": "PJoPPLnn", "description": "nxP7hyI5", "localeCode": "XZMSm3N2"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op CreateLocalizedPolicyVersion1 \
    --namespace $AB_NAMESPACE \
    --policyVersionId 'Sv4hMfgB' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 31 'CreateLocalizedPolicyVersion1' test.out

#- 32 RetrieveSingleLocalizedPolicyVersion1
$CLI_EXE \
    --sn legal \
    --op RetrieveSingleLocalizedPolicyVersion1 \
    --localizedPolicyVersionId 'T32t4F4n' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 32 'RetrieveSingleLocalizedPolicyVersion1' test.out

#- 33 UpdateLocalizedPolicyVersion1
# body param: body
echo '{"attachmentChecksum": "3oAQPBvI", "attachmentLocation": "FQN9jgeV", "attachmentVersionIdentifier": "fNd813wr", "contentType": "Nh2QDIZQ", "description": "U1Bdvznc"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op UpdateLocalizedPolicyVersion1 \
    --localizedPolicyVersionId 'NivEDpxN' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 33 'UpdateLocalizedPolicyVersion1' test.out

#- 34 RequestPresignedURL1
# body param: body
echo '{"contentMD5": "Nd0792U3", "contentType": "7OwmlNZB"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op RequestPresignedURL1 \
    --localizedPolicyVersionId 'Awv4bvLD' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 34 'RequestPresignedURL1' test.out

#- 35 SetDefaultPolicy1
$CLI_EXE \
    --sn legal \
    --op SetDefaultPolicy1 \
    --localizedPolicyVersionId 'm7cP8Jju' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 35 'SetDefaultPolicy1' test.out

#- 36 DeletePolicyVersion
$CLI_EXE \
    --sn legal \
    --op DeletePolicyVersion \
    --namespace $AB_NAMESPACE \
    --policyVersionId 'ZFvWCUoG' \
    > test.out 2>&1
eval_tap $? 36 'DeletePolicyVersion' test.out

#- 37 UpdatePolicyVersion1
# body param: body
echo '{"description": "U8kxIfvZ", "displayVersion": "sea1I48c", "isCommitted": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op UpdatePolicyVersion1 \
    --namespace $AB_NAMESPACE \
    --policyVersionId 'OwsownNT' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 37 'UpdatePolicyVersion1' test.out

#- 38 PublishPolicyVersion1
$CLI_EXE \
    --sn legal \
    --op PublishPolicyVersion1 \
    --namespace $AB_NAMESPACE \
    --policyVersionId 'NPMAwbDk' \
    --shouldNotify 'true' \
    > test.out 2>&1
eval_tap $? 38 'PublishPolicyVersion1' test.out

#- 39 UnpublishPolicyVersion
$CLI_EXE \
    --sn legal \
    --op UnpublishPolicyVersion \
    --namespace $AB_NAMESPACE \
    --policyVersionId '8q0Uvo8Y' \
    > test.out 2>&1
eval_tap $? 39 'UnpublishPolicyVersion' test.out

#- 40 DeletePolicy
$CLI_EXE \
    --sn legal \
    --op DeletePolicy \
    --namespace $AB_NAMESPACE \
    --policyId 'YDWJYMOJ' \
    > test.out 2>&1
eval_tap $? 40 'DeletePolicy' test.out

#- 41 UpdatePolicy1
# body param: body
echo '{"countries": ["FX1ZBqHA", "wb7F5aMV", "8LcLCmQI"], "countryGroupName": "gPo47dsq", "description": "KIFrcNco", "isDefaultOpted": false, "isMandatory": true, "policyName": "UkTxRV4Y", "readableId": "4QvpVdP7", "shouldNotifyOnUpdate": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op UpdatePolicy1 \
    --namespace $AB_NAMESPACE \
    --policyId 'PLLgx9WL' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 41 'UpdatePolicy1' test.out

#- 42 SetDefaultPolicy3
$CLI_EXE \
    --sn legal \
    --op SetDefaultPolicy3 \
    --namespace $AB_NAMESPACE \
    --policyId 'fBYneFNB' \
    > test.out 2>&1
eval_tap $? 42 'SetDefaultPolicy3' test.out

#- 43 RetrieveSinglePolicyVersion1
$CLI_EXE \
    --sn legal \
    --op RetrieveSinglePolicyVersion1 \
    --namespace $AB_NAMESPACE \
    --policyId 'NAt50nm0' \
    --versionId 'vMH9rHHD' \
    > test.out 2>&1
eval_tap $? 43 'RetrieveSinglePolicyVersion1' test.out

#- 44 CreatePolicyVersion1
# body param: body
echo '{"description": "ptE7UAt7", "displayVersion": "MS6HY7WG", "isCommitted": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op CreatePolicyVersion1 \
    --namespace $AB_NAMESPACE \
    --policyId 'CTZdi25B' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 44 'CreatePolicyVersion1' test.out

#- 45 RetrieveAllPolicyTypes1
$CLI_EXE \
    --sn legal \
    --op RetrieveAllPolicyTypes1 \
    --namespace $AB_NAMESPACE \
    --offset '31' \
    --limit '79' \
    > test.out 2>&1
eval_tap $? 45 'RetrieveAllPolicyTypes1' test.out

#- 46 IndirectBulkAcceptVersionedPolicy
# body param: body
echo '[{"isAccepted": false, "isNeedToSendEventMarketing": true, "localizedPolicyVersionId": "tQcJZnOk", "policyId": "M8wZcMYO", "policyVersionId": "iBBOByGk"}, {"isAccepted": true, "isNeedToSendEventMarketing": false, "localizedPolicyVersionId": "9hmfLtRo", "policyId": "L3bGHrzG", "policyVersionId": "lO1j0zbu"}, {"isAccepted": true, "isNeedToSendEventMarketing": true, "localizedPolicyVersionId": "pYrIwLYD", "policyId": "HrQLTzod", "policyVersionId": "HxnqJcMK"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op IndirectBulkAcceptVersionedPolicy \
    --namespace $AB_NAMESPACE \
    --userId 'r2B6VvP6' \
    --publisherUserId '6wztk0eE' \
    --clientId 'SmWr7Ara' \
    --countryCode 'wuPWvUxl' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 46 'IndirectBulkAcceptVersionedPolicy' test.out

#- 47 AdminRetrieveEligibilities
$CLI_EXE \
    --sn legal \
    --op AdminRetrieveEligibilities \
    --namespace $AB_NAMESPACE \
    --userId 'NBGHXU0k' \
    --publisherUserId 'ziugJHN1' \
    --clientId 'RKgDvy7d' \
    --countryCode 'Gmq9JY9N' \
    > test.out 2>&1
eval_tap $? 47 'AdminRetrieveEligibilities' test.out

#- 48 RetrievePolicies
$CLI_EXE \
    --sn legal \
    --op RetrievePolicies \
    --countryCode 'khHM8Mf4' \
    > test.out 2>&1
eval_tap $? 48 'RetrievePolicies' test.out

#- 49 UpdatePolicyVersion
# body param: body
echo '{"description": "tyJ3NEry", "displayVersion": "lWAQ3Jc5", "isCommitted": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op UpdatePolicyVersion \
    --policyVersionId 'F0C9nn9V' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 49 'UpdatePolicyVersion' test.out

#- 50 PublishPolicyVersion
$CLI_EXE \
    --sn legal \
    --op PublishPolicyVersion \
    --policyVersionId 'ouKmQbkZ' \
    --shouldNotify 'false' \
    > test.out 2>&1
eval_tap $? 50 'PublishPolicyVersion' test.out

#- 51 UpdatePolicy
# body param: body
echo '{"countries": ["5qzcV0qk", "ESx2kwFI", "tY8WU9l3"], "countryGroupName": "RVaEGa2h", "description": "QS7iqxTN", "isDefaultOpted": true, "isMandatory": false, "policyName": "RrZ4ulPk", "readableId": "cYZrOYUC", "shouldNotifyOnUpdate": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op UpdatePolicy \
    --policyId 's5GbTOrJ' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 51 'UpdatePolicy' test.out

#- 52 SetDefaultPolicy2
$CLI_EXE \
    --sn legal \
    --op SetDefaultPolicy2 \
    --policyId 'Pqyuvua2' \
    > test.out 2>&1
eval_tap $? 52 'SetDefaultPolicy2' test.out

#- 53 RetrieveSinglePolicyVersion
$CLI_EXE \
    --sn legal \
    --op RetrieveSinglePolicyVersion \
    --policyId 'Pu25Jo62' \
    --versionId 'BgMwhEx4' \
    > test.out 2>&1
eval_tap $? 53 'RetrieveSinglePolicyVersion' test.out

#- 54 CreatePolicyVersion
# body param: body
echo '{"description": "V34Q7QU3", "displayVersion": "cNpn7dGx", "isCommitted": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op CreatePolicyVersion \
    --policyId 'uUstAt0T' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 54 'CreatePolicyVersion' test.out

#- 55 RetrieveAllPolicyTypes
$CLI_EXE \
    --sn legal \
    --op RetrieveAllPolicyTypes \
    --offset '10' \
    --limit '91' \
    > test.out 2>&1
eval_tap $? 55 'RetrieveAllPolicyTypes' test.out

#- 56 GetUserInfoStatus
$CLI_EXE \
    --sn legal \
    --op GetUserInfoStatus \
    --namespaces 'AzgTfzdb' \
    > test.out 2>&1
eval_tap $? 56 'GetUserInfoStatus' test.out

#- 57 SyncUserInfo
eval_tap 0 57 'SyncUserInfo # SKIP deprecated' test.out

#- 58 InvalidateUserInfoCache
eval_tap 0 58 'InvalidateUserInfoCache # SKIP deprecated' test.out

#- 59 AnonymizeUserAgreement
$CLI_EXE \
    --sn legal \
    --op AnonymizeUserAgreement \
    --userId 'ED7CEKwg' \
    > test.out 2>&1
eval_tap $? 59 'AnonymizeUserAgreement' test.out

#- 60 ChangePreferenceConsent1
# body param: body
echo '[{"isAccepted": false, "isNeedToSendEventMarketing": true, "localizedPolicyVersionId": "NLfEodwv", "policyId": "R8QBkjd5", "policyVersionId": "A0ngK041"}, {"isAccepted": true, "isNeedToSendEventMarketing": false, "localizedPolicyVersionId": "eYB9D0av", "policyId": "9sj1jI95", "policyVersionId": "RpqnBrJc"}, {"isAccepted": true, "isNeedToSendEventMarketing": true, "localizedPolicyVersionId": "cMPzMgdC", "policyId": "16yR6SVy", "policyVersionId": "pSTk81YF"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op ChangePreferenceConsent1 \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 60 'ChangePreferenceConsent1' test.out

#- 61 AcceptVersionedPolicy
$CLI_EXE \
    --sn legal \
    --op AcceptVersionedPolicy \
    --localizedPolicyVersionId 'GTSvoMxB' \
    > test.out 2>&1
eval_tap $? 61 'AcceptVersionedPolicy' test.out

#- 62 RetrieveAgreementsPublic
$CLI_EXE \
    --sn legal \
    --op RetrieveAgreementsPublic \
    > test.out 2>&1
eval_tap $? 62 'RetrieveAgreementsPublic' test.out

#- 63 BulkAcceptVersionedPolicy
# body param: body
echo '[{"isAccepted": false, "isNeedToSendEventMarketing": true, "localizedPolicyVersionId": "dHlF5dvV", "policyId": "fhFIyZ5B", "policyVersionId": "6bQawHt9"}, {"isAccepted": true, "isNeedToSendEventMarketing": true, "localizedPolicyVersionId": "fF3JO2cH", "policyId": "vrwACPCz", "policyVersionId": "4Sv1Q8Q5"}, {"isAccepted": false, "isNeedToSendEventMarketing": false, "localizedPolicyVersionId": "V8ZVaZU3", "policyId": "EfDF9xGC", "policyVersionId": "47FAwFOx"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op BulkAcceptVersionedPolicy \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 63 'BulkAcceptVersionedPolicy' test.out

#- 64 IndirectBulkAcceptVersionedPolicyV2
eval_tap 0 64 'IndirectBulkAcceptVersionedPolicyV2 # SKIP deprecated' test.out

#- 65 IndirectBulkAcceptVersionedPolicy1
eval_tap 0 65 'IndirectBulkAcceptVersionedPolicy1 # SKIP deprecated' test.out

#- 66 RetrieveEligibilitiesPublic
$CLI_EXE \
    --sn legal \
    --op RetrieveEligibilitiesPublic \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 66 'RetrieveEligibilitiesPublic' test.out

#- 67 RetrieveEligibilitiesPublicIndirect
$CLI_EXE \
    --sn legal \
    --op RetrieveEligibilitiesPublicIndirect \
    --clientId 'O6y1O4UK' \
    --countryCode 'DIxNCKdS' \
    --namespace $AB_NAMESPACE \
    --userId 'ruGM13wp' \
    > test.out 2>&1
eval_tap $? 67 'RetrieveEligibilitiesPublicIndirect' test.out

#- 68 RetrieveSingleLocalizedPolicyVersion2
$CLI_EXE \
    --sn legal \
    --op RetrieveSingleLocalizedPolicyVersion2 \
    --localizedPolicyVersionId 'yZBB8xxC' \
    > test.out 2>&1
eval_tap $? 68 'RetrieveSingleLocalizedPolicyVersion2' test.out

#- 69 RetrieveSingleLocalizedPolicyVersion3
$CLI_EXE \
    --sn legal \
    --op RetrieveSingleLocalizedPolicyVersion3 \
    --localizedPolicyVersionId 'IV9xphMx' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 69 'RetrieveSingleLocalizedPolicyVersion3' test.out

#- 70 RetrieveCountryListWithPolicies
$CLI_EXE \
    --sn legal \
    --op RetrieveCountryListWithPolicies \
    > test.out 2>&1
eval_tap $? 70 'RetrieveCountryListWithPolicies' test.out

#- 71 RetrieveLatestPolicies
$CLI_EXE \
    --sn legal \
    --op RetrieveLatestPolicies \
    --countryCode 'D9Wcrf1L' \
    --defaultOnEmpty 'true' \
    --policyType 'MARKETING_PREFERENCE_TYPE' \
    --tags 'pONBXyJn' \
    --visibleOnly 'false' \
    > test.out 2>&1
eval_tap $? 71 'RetrieveLatestPolicies' test.out

#- 72 RetrieveLatestPoliciesPublic
$CLI_EXE \
    --sn legal \
    --op RetrieveLatestPoliciesPublic \
    --namespace $AB_NAMESPACE \
    --alwaysIncludeDefault 'false' \
    --defaultOnEmpty 'false' \
    --policyType 'LEGAL_DOCUMENT_TYPE' \
    --tags 'txPBN2vq' \
    --visibleOnly 'true' \
    > test.out 2>&1
eval_tap $? 72 'RetrieveLatestPoliciesPublic' test.out

#- 73 RetrieveLatestPoliciesByNamespaceAndCountryPublic
$CLI_EXE \
    --sn legal \
    --op RetrieveLatestPoliciesByNamespaceAndCountryPublic \
    --countryCode 'uldY1VEw' \
    --namespace $AB_NAMESPACE \
    --alwaysIncludeDefault 'false' \
    --defaultOnEmpty 'true' \
    --policyType 'MARKETING_PREFERENCE_TYPE' \
    --tags '2jFKVn0Q' \
    --visibleOnly 'true' \
    > test.out 2>&1
eval_tap $? 73 'RetrieveLatestPoliciesByNamespaceAndCountryPublic' test.out

#- 74 CheckReadiness
$CLI_EXE \
    --sn legal \
    --op CheckReadiness \
    > test.out 2>&1
eval_tap $? 74 'CheckReadiness' test.out

#- 75 RetrieveLatestPoliciesByNamespaceAndCountryPublic1
$CLI_EXE \
    --sn legal \
    --op RetrieveLatestPoliciesByNamespaceAndCountryPublic1 \
    --countryCode 'BnJHp3bZ' \
    --namespace $AB_NAMESPACE \
    --clientId 'dZadtvXk' \
    > test.out 2>&1
eval_tap $? 75 'RetrieveLatestPoliciesByNamespaceAndCountryPublic1' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE