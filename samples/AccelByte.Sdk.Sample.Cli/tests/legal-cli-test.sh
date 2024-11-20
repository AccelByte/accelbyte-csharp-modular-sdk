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
echo "1..74"

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
echo '[{"isAccepted": false, "isNeedToSendEventMarketing": false, "localizedPolicyVersionId": "IROjvYvV", "policyId": "3feAdOch", "policyVersionId": "BYk1YWKo"}, {"isAccepted": true, "isNeedToSendEventMarketing": true, "localizedPolicyVersionId": "SDDXikip", "policyId": "J2jekbYK", "policyVersionId": "7uqZWqZb"}, {"isAccepted": false, "isNeedToSendEventMarketing": true, "localizedPolicyVersionId": "PBxzmskS", "policyId": "8G3Iab3v", "policyVersionId": "oMi79OR9"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op ChangePreferenceConsent \
    --namespace $AB_NAMESPACE \
    --userId '52yV16CU' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 2 'ChangePreferenceConsent' test.out

#- 3 RetrieveAcceptedAgreements
$CLI_EXE \
    --sn legal \
    --op RetrieveAcceptedAgreements \
    --userId 'd3nuaY3b' \
    > test.out 2>&1
eval_tap $? 3 'RetrieveAcceptedAgreements' test.out

#- 4 RetrieveAllUsersByPolicyVersion
$CLI_EXE \
    --sn legal \
    --op RetrieveAllUsersByPolicyVersion \
    --keyword '0gcEj9iM' \
    --limit '27' \
    --offset '28' \
    --policyVersionId 'dCZLOMxO' \
    > test.out 2>&1
eval_tap $? 4 'RetrieveAllUsersByPolicyVersion' test.out

#- 5 RetrieveAllLegalPolicies
$CLI_EXE \
    --sn legal \
    --op RetrieveAllLegalPolicies \
    --visibleOnly 'true' \
    > test.out 2>&1
eval_tap $? 5 'RetrieveAllLegalPolicies' test.out

#- 6 CreatePolicy
# body param: body
echo '{"affectedClientIds": ["h5aMqyJv", "Ng7RwJYv", "K6f1mxlI"], "affectedCountries": ["geYIDkS8", "M9bdozez", "OP9L1w3r"], "basePolicyName": "mcjQBjcW", "countryGroupName": "iUgQCZl6", "countryType": "COUNTRY", "description": "Or3bY8Sm", "isHidden": false, "isHiddenPublic": true, "namespace": "64NzQpd6", "tags": ["szYC8jrG", "gqqIp7fz", "Rx4bTZYj"], "typeId": "i97QOek1"}' > $TEMP_JSON_INPUT
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
    --basePolicyId 'Iq0xOqvT' \
    > test.out 2>&1
eval_tap $? 7 'RetrieveSinglePolicy' test.out

#- 8 PartialUpdatePolicy
# body param: body
echo '{"affectedClientIds": ["GM7xIwOp", "07raTfkn", "vb5sgRTp"], "affectedCountries": ["4aNRHCr2", "29s10oDj", "5WBqOv4o"], "basePolicyName": "2gZjF8aZ", "countryGroupName": "zfRZFDVR", "countryType": "COUNTRY", "description": "1MiGH4UG", "isHidden": false, "isHiddenPublic": true, "namespace": "zNap11dK", "tags": ["xhgIZJx5", "omfWtHq3", "N6kMxejk"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op PartialUpdatePolicy \
    --basePolicyId 'xmwwlBGO' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 8 'PartialUpdatePolicy' test.out

#- 9 RetrievePolicyCountry
$CLI_EXE \
    --sn legal \
    --op RetrievePolicyCountry \
    --basePolicyId 'KgnK2M3n' \
    --countryCode 'DTzPDJ6M' \
    > test.out 2>&1
eval_tap $? 9 'RetrievePolicyCountry' test.out

#- 10 RetrieveLocalizedPolicyVersions
$CLI_EXE \
    --sn legal \
    --op RetrieveLocalizedPolicyVersions \
    --policyVersionId 'FGBNiyGz' \
    > test.out 2>&1
eval_tap $? 10 'RetrieveLocalizedPolicyVersions' test.out

#- 11 CreateLocalizedPolicyVersion
# body param: body
echo '{"contentType": "2hv5RFkf", "description": "XVKxv212", "localeCode": "AgRqmuPk"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op CreateLocalizedPolicyVersion \
    --policyVersionId 'KXbLSQj1' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 11 'CreateLocalizedPolicyVersion' test.out

#- 12 RetrieveSingleLocalizedPolicyVersion
$CLI_EXE \
    --sn legal \
    --op RetrieveSingleLocalizedPolicyVersion \
    --localizedPolicyVersionId 'owgkDwlr' \
    > test.out 2>&1
eval_tap $? 12 'RetrieveSingleLocalizedPolicyVersion' test.out

#- 13 UpdateLocalizedPolicyVersion
# body param: body
echo '{"attachmentChecksum": "7RXr0Tkc", "attachmentLocation": "dOuIQ75Y", "attachmentVersionIdentifier": "zEUDHg9g", "contentType": "rstQeaSh", "description": "R6d4MeDJ"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op UpdateLocalizedPolicyVersion \
    --localizedPolicyVersionId 'OAtVLN1t' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 13 'UpdateLocalizedPolicyVersion' test.out

#- 14 RequestPresignedURL
# body param: body
echo '{"contentMD5": "nMfZxcNb", "contentType": "2P2ljsFA"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op RequestPresignedURL \
    --localizedPolicyVersionId 'T7pOCiAq' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 14 'RequestPresignedURL' test.out

#- 15 SetDefaultPolicy
$CLI_EXE \
    --sn legal \
    --op SetDefaultPolicy \
    --localizedPolicyVersionId 'YPYusF0S' \
    > test.out 2>&1
eval_tap $? 15 'SetDefaultPolicy' test.out

#- 16 RetrieveAcceptedAgreementsForMultiUsers
# body param: body
echo '{"currentPublishedOnly": false, "userIds": ["WmqwUSTq", "QNx3ssEW", "5H5FlZeT"]}' > $TEMP_JSON_INPUT
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
    --userId 'KVBhMfze' \
    --excludeOtherNamespacesPolicies 'false' \
    > test.out 2>&1
eval_tap $? 17 'RetrieveAcceptedAgreements1' test.out

#- 18 RetrieveAllUsersByPolicyVersion1
$CLI_EXE \
    --sn legal \
    --op RetrieveAllUsersByPolicyVersion1 \
    --namespace $AB_NAMESPACE \
    --convertGameUserId 'true' \
    --keyword 'QU2rSbuD' \
    --limit '91' \
    --offset '87' \
    --policyVersionId 'FHz1sMYI' \
    > test.out 2>&1
eval_tap $? 18 'RetrieveAllUsersByPolicyVersion1' test.out

#- 19 DownloadExportedAgreementsInCSV
$CLI_EXE \
    --sn legal \
    --op DownloadExportedAgreementsInCSV \
    --namespace $AB_NAMESPACE \
    --exportId 'RPiriL8f' \
    > test.out 2>&1
eval_tap $? 19 'DownloadExportedAgreementsInCSV' test.out

#- 20 InitiateExportAgreementsToCSV
$CLI_EXE \
    --sn legal \
    --op InitiateExportAgreementsToCSV \
    --namespace $AB_NAMESPACE \
    --end '7qLDKxA0' \
    --policyVersionId 'aIPY0BEH' \
    --start 'aqUA0rA6' \
    > test.out 2>&1
eval_tap $? 20 'InitiateExportAgreementsToCSV' test.out

#- 21 RetrieveAllLegalPoliciesByNamespace
$CLI_EXE \
    --sn legal \
    --op RetrieveAllLegalPoliciesByNamespace \
    --namespace $AB_NAMESPACE \
    --visibleOnly 'false' \
    > test.out 2>&1
eval_tap $? 21 'RetrieveAllLegalPoliciesByNamespace' test.out

#- 22 CreatePolicy1
# body param: body
echo '{"affectedClientIds": ["xXlR8rM5", "1qTlvkLt", "tR6gvpzI"], "affectedCountries": ["9Uw4uCEh", "zdlJjA3e", "cBmygm8s"], "basePolicyName": "jfeHbQ91", "countryGroupName": "cG47YxBs", "countryType": "COUNTRY", "description": "DjPQQxak", "isHidden": false, "isHiddenPublic": true, "tags": ["vYDfAibQ", "1obqgjOy", "7ejXwQmF"], "typeId": "pNyqBVQj"}' > $TEMP_JSON_INPUT
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
    --basePolicyId 'LDn55BjW' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 23 'RetrieveSinglePolicy1' test.out

#- 24 DeleteBasePolicy
$CLI_EXE \
    --sn legal \
    --op DeleteBasePolicy \
    --basePolicyId 'MF8dVnIS' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 24 'DeleteBasePolicy' test.out

#- 25 PartialUpdatePolicy1
# body param: body
echo '{"affectedClientIds": ["rA36t30f", "iakFIyEW", "Ci27NI3Y"], "affectedCountries": ["2OLiDGNK", "84zVp2wl", "9NvTtPIV"], "basePolicyName": "5W1YQRo5", "countryGroupName": "QlXn6LaV", "countryType": "COUNTRY_GROUP", "description": "XDK7mIlX", "isHidden": true, "isHiddenPublic": false, "tags": ["u3xucvmg", "OBWuoWkH", "29AWCjqN"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op PartialUpdatePolicy1 \
    --basePolicyId 'o3HyMPoa' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 25 'PartialUpdatePolicy1' test.out

#- 26 RetrievePolicyCountry1
$CLI_EXE \
    --sn legal \
    --op RetrievePolicyCountry1 \
    --basePolicyId 'Gy9V0CLt' \
    --countryCode 'uRZ1yCU8' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 26 'RetrievePolicyCountry1' test.out

#- 27 RetrieveAllPoliciesFromBasePolicy
$CLI_EXE \
    --sn legal \
    --op RetrieveAllPoliciesFromBasePolicy \
    --basePolicyId 'st4e8F8N' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 27 'RetrieveAllPoliciesFromBasePolicy' test.out

#- 28 CreatePolicyUnderBasePolicy
# body param: body
echo '{"countries": ["AgI3ezds", "jYW6YwPn", "tdkSNUzP"], "countryCode": "SAynkn5X", "countryGroupName": "MKwc5n2K", "countryType": "COUNTRY", "description": "azAQHGrT", "isDefaultSelection": false, "isMandatory": false, "policyName": "2NA4j82w", "shouldNotifyOnUpdate": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op CreatePolicyUnderBasePolicy \
    --basePolicyId 'pyNg0psz' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 28 'CreatePolicyUnderBasePolicy' test.out

#- 29 DeleteLocalizedPolicy
$CLI_EXE \
    --sn legal \
    --op DeleteLocalizedPolicy \
    --localizedPolicyVersionId 'EJurAkzy' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 29 'DeleteLocalizedPolicy' test.out

#- 30 RetrieveLocalizedPolicyVersions1
$CLI_EXE \
    --sn legal \
    --op RetrieveLocalizedPolicyVersions1 \
    --namespace $AB_NAMESPACE \
    --policyVersionId 'z4g4QUsl' \
    > test.out 2>&1
eval_tap $? 30 'RetrieveLocalizedPolicyVersions1' test.out

#- 31 CreateLocalizedPolicyVersion1
# body param: body
echo '{"contentType": "X6Wl5oMe", "description": "e9RfmjHQ", "localeCode": "PHedTzao"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op CreateLocalizedPolicyVersion1 \
    --namespace $AB_NAMESPACE \
    --policyVersionId '6MC59IoM' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 31 'CreateLocalizedPolicyVersion1' test.out

#- 32 RetrieveSingleLocalizedPolicyVersion1
$CLI_EXE \
    --sn legal \
    --op RetrieveSingleLocalizedPolicyVersion1 \
    --localizedPolicyVersionId '85Ff1mIQ' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 32 'RetrieveSingleLocalizedPolicyVersion1' test.out

#- 33 UpdateLocalizedPolicyVersion1
# body param: body
echo '{"attachmentChecksum": "L7flHZos", "attachmentLocation": "JHTxBy0G", "attachmentVersionIdentifier": "QIJ8gbUR", "contentType": "uuKSIBqg", "description": "MAugqKvc"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op UpdateLocalizedPolicyVersion1 \
    --localizedPolicyVersionId 'cQDRf55x' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 33 'UpdateLocalizedPolicyVersion1' test.out

#- 34 RequestPresignedURL1
# body param: body
echo '{"contentMD5": "QbkGFrMt", "contentType": "TR9T072z"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op RequestPresignedURL1 \
    --localizedPolicyVersionId '6DpLowkO' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 34 'RequestPresignedURL1' test.out

#- 35 SetDefaultPolicy1
$CLI_EXE \
    --sn legal \
    --op SetDefaultPolicy1 \
    --localizedPolicyVersionId 'X0PYZBBu' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 35 'SetDefaultPolicy1' test.out

#- 36 DeletePolicyVersion
$CLI_EXE \
    --sn legal \
    --op DeletePolicyVersion \
    --namespace $AB_NAMESPACE \
    --policyVersionId 'taUtnOIL' \
    > test.out 2>&1
eval_tap $? 36 'DeletePolicyVersion' test.out

#- 37 UpdatePolicyVersion1
# body param: body
echo '{"description": "1nKN9x4Y", "displayVersion": "XRLrw0GU", "isCommitted": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op UpdatePolicyVersion1 \
    --namespace $AB_NAMESPACE \
    --policyVersionId '5NNW5EZU' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 37 'UpdatePolicyVersion1' test.out

#- 38 PublishPolicyVersion1
$CLI_EXE \
    --sn legal \
    --op PublishPolicyVersion1 \
    --namespace $AB_NAMESPACE \
    --policyVersionId 'S13UgyDU' \
    --shouldNotify 'false' \
    > test.out 2>&1
eval_tap $? 38 'PublishPolicyVersion1' test.out

#- 39 UnpublishPolicyVersion
$CLI_EXE \
    --sn legal \
    --op UnpublishPolicyVersion \
    --namespace $AB_NAMESPACE \
    --policyVersionId 'dnFEJqLM' \
    > test.out 2>&1
eval_tap $? 39 'UnpublishPolicyVersion' test.out

#- 40 DeletePolicy
$CLI_EXE \
    --sn legal \
    --op DeletePolicy \
    --namespace $AB_NAMESPACE \
    --policyId 'yz1ol7dJ' \
    > test.out 2>&1
eval_tap $? 40 'DeletePolicy' test.out

#- 41 UpdatePolicy1
# body param: body
echo '{"countries": ["d6Y26klZ", "zb4M7Gvj", "Ey6ISa4f"], "countryGroupName": "gDidlBtr", "description": "FRkmoVIX", "isDefaultOpted": true, "isMandatory": true, "policyName": "eL0qfKzK", "readableId": "cNgHJwlf", "shouldNotifyOnUpdate": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op UpdatePolicy1 \
    --namespace $AB_NAMESPACE \
    --policyId 'qH8eKive' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 41 'UpdatePolicy1' test.out

#- 42 SetDefaultPolicy3
$CLI_EXE \
    --sn legal \
    --op SetDefaultPolicy3 \
    --namespace $AB_NAMESPACE \
    --policyId 'CHFcca4L' \
    > test.out 2>&1
eval_tap $? 42 'SetDefaultPolicy3' test.out

#- 43 RetrieveSinglePolicyVersion1
$CLI_EXE \
    --sn legal \
    --op RetrieveSinglePolicyVersion1 \
    --namespace $AB_NAMESPACE \
    --policyId 'SzMMf2UL' \
    --versionId 'fgtGXwXE' \
    > test.out 2>&1
eval_tap $? 43 'RetrieveSinglePolicyVersion1' test.out

#- 44 CreatePolicyVersion1
# body param: body
echo '{"description": "IRzBKGZS", "displayVersion": "on7dAymQ", "isCommitted": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op CreatePolicyVersion1 \
    --namespace $AB_NAMESPACE \
    --policyId 'WrXJ25Rv' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 44 'CreatePolicyVersion1' test.out

#- 45 RetrieveAllPolicyTypes1
$CLI_EXE \
    --sn legal \
    --op RetrieveAllPolicyTypes1 \
    --namespace $AB_NAMESPACE \
    --offset '63' \
    --limit '79' \
    > test.out 2>&1
eval_tap $? 45 'RetrieveAllPolicyTypes1' test.out

#- 46 IndirectBulkAcceptVersionedPolicy
# body param: body
echo '[{"isAccepted": false, "isNeedToSendEventMarketing": false, "localizedPolicyVersionId": "CLCGCYav", "policyId": "DvRLCv81", "policyVersionId": "LrvQWHoX"}, {"isAccepted": false, "isNeedToSendEventMarketing": false, "localizedPolicyVersionId": "85LtXnvH", "policyId": "rCfVmkd1", "policyVersionId": "XQenzFzc"}, {"isAccepted": false, "isNeedToSendEventMarketing": false, "localizedPolicyVersionId": "Bvkn08En", "policyId": "Kx5VjS9n", "policyVersionId": "IqbvXIA6"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op IndirectBulkAcceptVersionedPolicy \
    --namespace $AB_NAMESPACE \
    --userId 't4Bg2kCC' \
    --publisherUserId 'uYANPVfs' \
    --clientId 'MpZOSV4z' \
    --countryCode 'VIgNywfY' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 46 'IndirectBulkAcceptVersionedPolicy' test.out

#- 47 AdminRetrieveEligibilities
$CLI_EXE \
    --sn legal \
    --op AdminRetrieveEligibilities \
    --namespace $AB_NAMESPACE \
    --userId 'E4od74H1' \
    --publisherUserId 'UrY35zdA' \
    --clientId 'nH1E5mSk' \
    --countryCode 'Mqi3dUYd' \
    > test.out 2>&1
eval_tap $? 47 'AdminRetrieveEligibilities' test.out

#- 48 RetrievePolicies
$CLI_EXE \
    --sn legal \
    --op RetrievePolicies \
    --countryCode 'tP8IrqNz' \
    > test.out 2>&1
eval_tap $? 48 'RetrievePolicies' test.out

#- 49 UpdatePolicyVersion
# body param: body
echo '{"description": "WjKG2gsx", "displayVersion": "bqImB6fQ", "isCommitted": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op UpdatePolicyVersion \
    --policyVersionId 'S7WKrJmj' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 49 'UpdatePolicyVersion' test.out

#- 50 PublishPolicyVersion
$CLI_EXE \
    --sn legal \
    --op PublishPolicyVersion \
    --policyVersionId 'QkY1Yfk7' \
    --shouldNotify 'false' \
    > test.out 2>&1
eval_tap $? 50 'PublishPolicyVersion' test.out

#- 51 UpdatePolicy
# body param: body
echo '{"countries": ["vtYKdlFf", "ronoVvU7", "pu6KYSpH"], "countryGroupName": "2N1oCo92", "description": "lvvDKABy", "isDefaultOpted": false, "isMandatory": false, "policyName": "DrysrCWV", "readableId": "uwt7qCyU", "shouldNotifyOnUpdate": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op UpdatePolicy \
    --policyId 'r2QOb3z6' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 51 'UpdatePolicy' test.out

#- 52 SetDefaultPolicy2
$CLI_EXE \
    --sn legal \
    --op SetDefaultPolicy2 \
    --policyId 'jZOGqsEV' \
    > test.out 2>&1
eval_tap $? 52 'SetDefaultPolicy2' test.out

#- 53 RetrieveSinglePolicyVersion
$CLI_EXE \
    --sn legal \
    --op RetrieveSinglePolicyVersion \
    --policyId 'tPKEhe46' \
    --versionId 'Aha8f5JY' \
    > test.out 2>&1
eval_tap $? 53 'RetrieveSinglePolicyVersion' test.out

#- 54 CreatePolicyVersion
# body param: body
echo '{"description": "Qep0Cy1f", "displayVersion": "2DXEN42d", "isCommitted": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn legal \
    --op CreatePolicyVersion \
    --policyId 'Cz8lU0GX' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 54 'CreatePolicyVersion' test.out

#- 55 RetrieveAllPolicyTypes
$CLI_EXE \
    --sn legal \
    --op RetrieveAllPolicyTypes \
    --offset '72' \
    --limit '9' \
    > test.out 2>&1
eval_tap $? 55 'RetrieveAllPolicyTypes' test.out

#- 56 GetUserInfoStatus
$CLI_EXE \
    --sn legal \
    --op GetUserInfoStatus \
    --namespaces '0pkYc9sD' \
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
    --userId '6nOpe7Bi' \
    > test.out 2>&1
eval_tap $? 59 'AnonymizeUserAgreement' test.out

#- 60 ChangePreferenceConsent1
# body param: body
echo '[{"isAccepted": true, "isNeedToSendEventMarketing": false, "localizedPolicyVersionId": "gxqyqmIr", "policyId": "sO3i7jrQ", "policyVersionId": "vb4WST3J"}, {"isAccepted": true, "isNeedToSendEventMarketing": false, "localizedPolicyVersionId": "NQAkmWd4", "policyId": "gij1poqw", "policyVersionId": "W8hGM6H4"}, {"isAccepted": false, "isNeedToSendEventMarketing": true, "localizedPolicyVersionId": "a6vYNWdA", "policyId": "ZizHaAMH", "policyVersionId": "KRIz3mA3"}]' > $TEMP_JSON_INPUT
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
    --localizedPolicyVersionId 'CUwhwDRE' \
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
echo '[{"isAccepted": false, "isNeedToSendEventMarketing": true, "localizedPolicyVersionId": "h9l4Pi76", "policyId": "36WVLbiM", "policyVersionId": "Fn72NEoZ"}, {"isAccepted": false, "isNeedToSendEventMarketing": false, "localizedPolicyVersionId": "SMGJ0JVe", "policyId": "OyDONumB", "policyVersionId": "HpfmzD8f"}, {"isAccepted": true, "isNeedToSendEventMarketing": false, "localizedPolicyVersionId": "xZOqnpdM", "policyId": "b5QcVObt", "policyVersionId": "dRb0rTIN"}]' > $TEMP_JSON_INPUT
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
    --clientId 'K8lrmhTC' \
    --countryCode '0vaN1jEp' \
    --namespace $AB_NAMESPACE \
    --userId 'X56R8tMZ' \
    > test.out 2>&1
eval_tap $? 67 'RetrieveEligibilitiesPublicIndirect' test.out

#- 68 RetrieveSingleLocalizedPolicyVersion2
$CLI_EXE \
    --sn legal \
    --op RetrieveSingleLocalizedPolicyVersion2 \
    --localizedPolicyVersionId 'fFya7WGJ' \
    > test.out 2>&1
eval_tap $? 68 'RetrieveSingleLocalizedPolicyVersion2' test.out

#- 69 RetrieveSingleLocalizedPolicyVersion3
$CLI_EXE \
    --sn legal \
    --op RetrieveSingleLocalizedPolicyVersion3 \
    --localizedPolicyVersionId 'uiDHvgkC' \
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
    --countryCode 'nxa7HNZF' \
    --defaultOnEmpty 'true' \
    --policyType 'MARKETING_PREFERENCE_TYPE' \
    --tags 'iC5rJFpt' \
    --visibleOnly 'false' \
    > test.out 2>&1
eval_tap $? 71 'RetrieveLatestPolicies' test.out

#- 72 RetrieveLatestPoliciesPublic
$CLI_EXE \
    --sn legal \
    --op RetrieveLatestPoliciesPublic \
    --namespace $AB_NAMESPACE \
    --alwaysIncludeDefault 'false' \
    --defaultOnEmpty 'true' \
    --policyType 'MARKETING_PREFERENCE_TYPE' \
    --tags 'BEscLmnW' \
    --visibleOnly 'false' \
    > test.out 2>&1
eval_tap $? 72 'RetrieveLatestPoliciesPublic' test.out

#- 73 RetrieveLatestPoliciesByNamespaceAndCountryPublic
$CLI_EXE \
    --sn legal \
    --op RetrieveLatestPoliciesByNamespaceAndCountryPublic \
    --countryCode 'vziyvznJ' \
    --namespace $AB_NAMESPACE \
    --alwaysIncludeDefault 'true' \
    --defaultOnEmpty 'true' \
    --policyType 'LEGAL_DOCUMENT_TYPE' \
    --tags '4t08GXUD' \
    --visibleOnly 'true' \
    > test.out 2>&1
eval_tap $? 73 'RetrieveLatestPoliciesByNamespaceAndCountryPublic' test.out

#- 74 CheckReadiness
$CLI_EXE \
    --sn legal \
    --op CheckReadiness \
    > test.out 2>&1
eval_tap $? 74 'CheckReadiness' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE