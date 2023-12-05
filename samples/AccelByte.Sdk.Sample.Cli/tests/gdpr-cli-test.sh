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
echo "1..27"

#- 1 Login
$CLI_EXE --op login --lt user --user user --pass user > test.out 2>&1
eval_tap $? 1 'Login' test.out

if [ $EXIT_CODE -ne 0 ]; then
  echo "Bail out! Login failed."
  exit $EXIT_CODE
fi

# echo "foo" > "$CLI_TOKEN_FILE"

#- 2 AdminGetListDeletionDataRequest
$CLI_EXE \
    --sn gdpr \
    --op AdminGetListDeletionDataRequest \
    --namespace $AB_NAMESPACE \
    --after 'Fr5hYRbP' \
    --before 'VKfzWI9y' \
    --limit '58' \
    --offset '14' \
    --requestDate 'THiSk4b9' \
    > test.out 2>&1
eval_tap $? 2 'AdminGetListDeletionDataRequest' test.out

#- 3 GetAdminEmailConfiguration
$CLI_EXE \
    --sn gdpr \
    --op GetAdminEmailConfiguration \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 3 'GetAdminEmailConfiguration' test.out

#- 4 UpdateAdminEmailConfiguration
# body param: body
echo '["An7OHiZO", "1FkrhfcI", "cdxlulIh"]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn gdpr \
    --op UpdateAdminEmailConfiguration \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 4 'UpdateAdminEmailConfiguration' test.out

#- 5 SaveAdminEmailConfiguration
# body param: body
echo '["PRI9YduU", "8wnlmndG", "L7H7qfce"]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn gdpr \
    --op SaveAdminEmailConfiguration \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 5 'SaveAdminEmailConfiguration' test.out

#- 6 DeleteAdminEmailConfiguration
$CLI_EXE \
    --sn gdpr \
    --op DeleteAdminEmailConfiguration \
    --namespace $AB_NAMESPACE \
    --emails '["MHMaeYR1", "jIsOVthU", "A0csVFtd"]' \
    > test.out 2>&1
eval_tap $? 6 'DeleteAdminEmailConfiguration' test.out

#- 7 AdminGetListPersonalDataRequest
$CLI_EXE \
    --sn gdpr \
    --op AdminGetListPersonalDataRequest \
    --namespace $AB_NAMESPACE \
    --limit '23' \
    --offset '34' \
    --requestDate 'uzflIRhY' \
    > test.out 2>&1
eval_tap $? 7 'AdminGetListPersonalDataRequest' test.out

#- 8 AdminGetServicesConfiguration
$CLI_EXE \
    --sn gdpr \
    --op AdminGetServicesConfiguration \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 8 'AdminGetServicesConfiguration' test.out

#- 9 AdminUpdateServicesConfiguration
# body param: body
echo '{"services": [{"extendConfig": {"appName": "QUEOALTc", "namespace": "w8Z9QUan"}, "id": "DZh9IYXd", "serviceConfig": {"protocol": "GRPC", "url": "6oSBoOHS"}, "type": "SERVICE"}, {"extendConfig": {"appName": "FmzrVjJB", "namespace": "U0OR7qvD"}, "id": "SgnTjh1X", "serviceConfig": {"protocol": "GRPC", "url": "EvZ5GOc0"}, "type": "EXTEND"}, {"extendConfig": {"appName": "AYsKKOLu", "namespace": "ny0B10sH"}, "id": "IL9LO7i6", "serviceConfig": {"protocol": "GRPC", "url": "Vqp1b1hm"}, "type": "SERVICE"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn gdpr \
    --op AdminUpdateServicesConfiguration \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 9 'AdminUpdateServicesConfiguration' test.out

#- 10 AdminResetServicesConfiguration
$CLI_EXE \
    --sn gdpr \
    --op AdminResetServicesConfiguration \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 10 'AdminResetServicesConfiguration' test.out

#- 11 AdminGetUserAccountDeletionRequest
$CLI_EXE \
    --sn gdpr \
    --op AdminGetUserAccountDeletionRequest \
    --namespace $AB_NAMESPACE \
    --userId 'qGSRyOiv' \
    > test.out 2>&1
eval_tap $? 11 'AdminGetUserAccountDeletionRequest' test.out

#- 12 AdminSubmitUserAccountDeletionRequest
$CLI_EXE \
    --sn gdpr \
    --op AdminSubmitUserAccountDeletionRequest \
    --namespace $AB_NAMESPACE \
    --userId 'taPn5KuH' \
    > test.out 2>&1
eval_tap $? 12 'AdminSubmitUserAccountDeletionRequest' test.out

#- 13 AdminCancelUserAccountDeletionRequest
$CLI_EXE \
    --sn gdpr \
    --op AdminCancelUserAccountDeletionRequest \
    --namespace $AB_NAMESPACE \
    --userId 'BpEeRlK9' \
    > test.out 2>&1
eval_tap $? 13 'AdminCancelUserAccountDeletionRequest' test.out

#- 14 AdminGetUserPersonalDataRequests
$CLI_EXE \
    --sn gdpr \
    --op AdminGetUserPersonalDataRequests \
    --namespace $AB_NAMESPACE \
    --userId 'VWookw5J' \
    --limit '58' \
    --offset '65' \
    > test.out 2>&1
eval_tap $? 14 'AdminGetUserPersonalDataRequests' test.out

#- 15 AdminRequestDataRetrieval
$CLI_EXE \
    --sn gdpr \
    --op AdminRequestDataRetrieval \
    --namespace $AB_NAMESPACE \
    --userId 'r6YnCVHc' \
    --password '8YawNHSc' \
    > test.out 2>&1
eval_tap $? 15 'AdminRequestDataRetrieval' test.out

#- 16 AdminCancelUserPersonalDataRequest
$CLI_EXE \
    --sn gdpr \
    --op AdminCancelUserPersonalDataRequest \
    --namespace $AB_NAMESPACE \
    --requestDate 'T7ZnJKQ3' \
    --userId 'vIAP7aun' \
    > test.out 2>&1
eval_tap $? 16 'AdminCancelUserPersonalDataRequest' test.out

#- 17 AdminGeneratePersonalDataURL
$CLI_EXE \
    --sn gdpr \
    --op AdminGeneratePersonalDataURL \
    --namespace $AB_NAMESPACE \
    --requestDate 'udUC5iJv' \
    --userId 'FwmuLwSy' \
    --password 'aM7GXaU8' \
    > test.out 2>&1
eval_tap $? 17 'AdminGeneratePersonalDataURL' test.out

#- 18 PublicSubmitUserAccountDeletionRequest
$CLI_EXE \
    --sn gdpr \
    --op PublicSubmitUserAccountDeletionRequest \
    --namespace $AB_NAMESPACE \
    --userId 'hLCaxF9O' \
    --password 'krTbYlYN' \
    > test.out 2>&1
eval_tap $? 18 'PublicSubmitUserAccountDeletionRequest' test.out

#- 19 PublicCancelUserAccountDeletionRequest
$CLI_EXE \
    --sn gdpr \
    --op PublicCancelUserAccountDeletionRequest \
    --namespace $AB_NAMESPACE \
    --userId 'xEimxQqq' \
    > test.out 2>&1
eval_tap $? 19 'PublicCancelUserAccountDeletionRequest' test.out

#- 20 PublicGetUserAccountDeletionStatus
$CLI_EXE \
    --sn gdpr \
    --op PublicGetUserAccountDeletionStatus \
    --namespace $AB_NAMESPACE \
    --userId 'c1Ki4iRt' \
    > test.out 2>&1
eval_tap $? 20 'PublicGetUserAccountDeletionStatus' test.out

#- 21 PublicGetUserPersonalDataRequests
$CLI_EXE \
    --sn gdpr \
    --op PublicGetUserPersonalDataRequests \
    --namespace $AB_NAMESPACE \
    --userId 'Dbejr1Q7' \
    --limit '47' \
    --offset '85' \
    > test.out 2>&1
eval_tap $? 21 'PublicGetUserPersonalDataRequests' test.out

#- 22 PublicRequestDataRetrieval
$CLI_EXE \
    --sn gdpr \
    --op PublicRequestDataRetrieval \
    --namespace $AB_NAMESPACE \
    --userId 'cSwY2AJr' \
    --password 'hT1BVPhE' \
    > test.out 2>&1
eval_tap $? 22 'PublicRequestDataRetrieval' test.out

#- 23 PublicCancelUserPersonalDataRequest
$CLI_EXE \
    --sn gdpr \
    --op PublicCancelUserPersonalDataRequest \
    --namespace $AB_NAMESPACE \
    --requestDate 'Y5BXxP1G' \
    --userId '71cSXSy5' \
    > test.out 2>&1
eval_tap $? 23 'PublicCancelUserPersonalDataRequest' test.out

#- 24 PublicGeneratePersonalDataURL
$CLI_EXE \
    --sn gdpr \
    --op PublicGeneratePersonalDataURL \
    --namespace $AB_NAMESPACE \
    --requestDate 'SbCqXH2V' \
    --userId 'nY18Rfs6' \
    --password 'Vh5iySXM' \
    > test.out 2>&1
eval_tap $? 24 'PublicGeneratePersonalDataURL' test.out

#- 25 PublicSubmitMyAccountDeletionRequest
$CLI_EXE \
    --sn gdpr \
    --op PublicSubmitMyAccountDeletionRequest \
    --platformId '36L2AFyd' \
    --platformToken '9v1IcSMV' \
    > test.out 2>&1
eval_tap $? 25 'PublicSubmitMyAccountDeletionRequest' test.out

#- 26 PublicCancelMyAccountDeletionRequest
$CLI_EXE \
    --sn gdpr \
    --op PublicCancelMyAccountDeletionRequest \
    > test.out 2>&1
eval_tap $? 26 'PublicCancelMyAccountDeletionRequest' test.out

#- 27 PublicGetMyAccountDeletionStatus
$CLI_EXE \
    --sn gdpr \
    --op PublicGetMyAccountDeletionStatus \
    > test.out 2>&1
eval_tap $? 27 'PublicGetMyAccountDeletionStatus' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE