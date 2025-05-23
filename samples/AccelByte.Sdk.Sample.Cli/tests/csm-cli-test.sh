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
echo "1..56"

#- 1 Login
$CLI_EXE --op login --lt user --user user --pass user > test.out 2>&1
eval_tap $? 1 'Login' test.out

if [ $EXIT_CODE -ne 0 ]; then
  echo "Bail out! Login failed."
  exit $EXIT_CODE
fi

# echo "foo" > "$CLI_TOKEN_FILE"

#- 2 GetAppListV1
eval_tap 0 2 'GetAppListV1 # SKIP deprecated' test.out

#- 3 GetAppV1
eval_tap 0 3 'GetAppV1 # SKIP deprecated' test.out

#- 4 CreateAppV1
eval_tap 0 4 'CreateAppV1 # SKIP deprecated' test.out

#- 5 DeleteAppV1
eval_tap 0 5 'DeleteAppV1 # SKIP deprecated' test.out

#- 6 UpdateAppV1
eval_tap 0 6 'UpdateAppV1 # SKIP deprecated' test.out

#- 7 CreateDeploymentV1
eval_tap 0 7 'CreateDeploymentV1 # SKIP deprecated' test.out

#- 8 GetAppImageListV1
eval_tap 0 8 'GetAppImageListV1 # SKIP deprecated' test.out

#- 9 DeleteAppImagesV1
eval_tap 0 9 'DeleteAppImagesV1 # SKIP deprecated' test.out

#- 10 GetAppReleaseV1
$CLI_EXE \
    --sn csm \
    --op GetAppReleaseV1 \
    --app '9s068BlU' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 10 'GetAppReleaseV1' test.out

#- 11 GetListOfSecretsV1
eval_tap 0 11 'GetListOfSecretsV1 # SKIP deprecated' test.out

#- 12 SaveSecretV1
eval_tap 0 12 'SaveSecretV1 # SKIP deprecated' test.out

#- 13 UpdateSecretV1
eval_tap 0 13 'UpdateSecretV1 # SKIP deprecated' test.out

#- 14 DeleteSecretV1
eval_tap 0 14 'DeleteSecretV1 # SKIP deprecated' test.out

#- 15 StartAppV1
eval_tap 0 15 'StartAppV1 # SKIP deprecated' test.out

#- 16 StopAppV1
eval_tap 0 16 'StopAppV1 # SKIP deprecated' test.out

#- 17 GetListOfVariablesV1
eval_tap 0 17 'GetListOfVariablesV1 # SKIP deprecated' test.out

#- 18 SaveVariableV1
eval_tap 0 18 'SaveVariableV1 # SKIP deprecated' test.out

#- 19 UpdateVariableV1
eval_tap 0 19 'UpdateVariableV1 # SKIP deprecated' test.out

#- 20 DeleteVariableV1
eval_tap 0 20 'DeleteVariableV1 # SKIP deprecated' test.out

#- 21 GetListOfDeploymentV1
eval_tap 0 21 'GetListOfDeploymentV1 # SKIP deprecated' test.out

#- 22 GetDeploymentV1
eval_tap 0 22 'GetDeploymentV1 # SKIP deprecated' test.out

#- 23 DeleteDeploymentV1
eval_tap 0 23 'DeleteDeploymentV1 # SKIP deprecated' test.out

#- 24 PublicGetMessages
$CLI_EXE \
    --sn csm \
    --op PublicGetMessages \
    > test.out 2>&1
eval_tap $? 24 'PublicGetMessages' test.out

#- 25 GetAppListV2
# body param: body
echo '{"appNames": ["RuJMoXLX", "Iq96oYaL", "rsxK0pPN"], "appStatuses": ["1chg9wQs", "tGdKsG30", "Rw9hogyp"], "fuzzyAppName": "bJg1CG3n", "scenario": "xvkX2R94"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn csm \
    --op GetAppListV2 \
    --namespace $AB_NAMESPACE \
    --limit '72' \
    --offset '54' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 25 'GetAppListV2' test.out

#- 26 GetAppV2
$CLI_EXE \
    --sn csm \
    --op GetAppV2 \
    --app '09ghpYZz' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 26 'GetAppV2' test.out

#- 27 CreateAppV2
# body param: body
echo '{"autoscaling": {"targetCPUUtilizationPercent": 32}, "cpu": {"requestCPU": 38}, "description": "MJbc7nEm", "memory": {"requestMemory": 82}, "replica": {"maxReplica": 94, "minReplica": 100}, "scenario": "OHOaLZH6", "vmSharingConfiguration": "2KrF3cJt"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn csm \
    --op CreateAppV2 \
    --app 'nChfWY3U' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 27 'CreateAppV2' test.out

#- 28 DeleteAppV2
$CLI_EXE \
    --sn csm \
    --op DeleteAppV2 \
    --app '7OMHnTY2' \
    --namespace $AB_NAMESPACE \
    --forced 'kQ7QAdAu' \
    > test.out 2>&1
eval_tap $? 28 'DeleteAppV2' test.out

#- 29 UpdateAppV2
# body param: body
echo '{"description": "b6M149xx"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn csm \
    --op UpdateAppV2 \
    --app 'tXCwDvHz' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 29 'UpdateAppV2' test.out

#- 30 CreateDeploymentV2
# body param: body
echo '{"imageTag": "G56VRWsr"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn csm \
    --op CreateDeploymentV2 \
    --app 'EWC9mRoZ' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 30 'CreateDeploymentV2' test.out

#- 31 GetAppImageListV2
$CLI_EXE \
    --sn csm \
    --op GetAppImageListV2 \
    --app 'O6h8b24H' \
    --namespace $AB_NAMESPACE \
    --cached 'NIM9d1Xm' \
    > test.out 2>&1
eval_tap $? 31 'GetAppImageListV2' test.out

#- 32 DeleteAppImagesV2
# body param: body
echo '{"imageTags": ["cd06UUXN", "0WWo7rOO", "cZUhXrIs"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn csm \
    --op DeleteAppImagesV2 \
    --app 'fD1ryNDN' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 32 'DeleteAppImagesV2' test.out

#- 33 UpdateAppResourcesV2
# body param: body
echo '{"autoscaling": {"targetCPUUtilizationPercent": 4}, "cpu": {"requestCPU": 85}, "memory": {"requestMemory": 21}, "replica": {"maxReplica": 26, "minReplica": 69}, "vmSharingConfiguration": "L0mhcExU"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn csm \
    --op UpdateAppResourcesV2 \
    --app 'cUkOte2r' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 33 'UpdateAppResourcesV2' test.out

#- 34 UpdateAppResourcesResourceLimitFormV2
# body param: body
echo '{"clientEmail": "att2PkOl", "preferredLimitReplica": 77, "requestReason": "PMY2ZeNy"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn csm \
    --op UpdateAppResourcesResourceLimitFormV2 \
    --app 'B1wTsyaw' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 34 'UpdateAppResourcesResourceLimitFormV2' test.out

#- 35 GetListOfSecretsV2
$CLI_EXE \
    --sn csm \
    --op GetListOfSecretsV2 \
    --app 'eCLOeCWv' \
    --namespace $AB_NAMESPACE \
    --limit '7' \
    --offset '47' \
    > test.out 2>&1
eval_tap $? 35 'GetListOfSecretsV2' test.out

#- 36 SaveSecretV2
# body param: body
echo '{"configName": "PQwJvkbs", "description": "tmj83hrQ", "source": "Gj8eABrm", "value": "nt2hRaF1"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn csm \
    --op SaveSecretV2 \
    --app '0Fq4HpOG' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 36 'SaveSecretV2' test.out

#- 37 UpdateSecretV2
# body param: body
echo '{"description": "wYEhqcDZ", "value": "D8zBq8BN"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn csm \
    --op UpdateSecretV2 \
    --app '8hYmivGK' \
    --configId 'tp75CcrJ' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 37 'UpdateSecretV2' test.out

#- 38 DeleteSecretV2
$CLI_EXE \
    --sn csm \
    --op DeleteSecretV2 \
    --app 'O3JW8Wdk' \
    --configId '0PEcKZno' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 38 'DeleteSecretV2' test.out

#- 39 StartAppV2
$CLI_EXE \
    --sn csm \
    --op StartAppV2 \
    --app '17qVCS81' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 39 'StartAppV2' test.out

#- 40 StopAppV2
$CLI_EXE \
    --sn csm \
    --op StopAppV2 \
    --app 'MozHbNJK' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 40 'StopAppV2' test.out

#- 41 GetNotificationSubscriberListV2
$CLI_EXE \
    --sn csm \
    --op GetNotificationSubscriberListV2 \
    --app '9xY328FD' \
    --namespace $AB_NAMESPACE \
    --notificationType 'ShiGGIPn' \
    > test.out 2>&1
eval_tap $? 41 'GetNotificationSubscriberListV2' test.out

#- 42 BulkSaveSubscriptionAppNotificationV2
# body param: body
echo '{"subscribers": [{"notificationType": {"nMfMehgg": false, "sINcwRHF": true, "8mI2dXvT": true}, "userId": "st0jYSJy"}, {"notificationType": {"BMH5zYt7": true, "ZRCiaGIl": true, "MlgtyHhy": true}, "userId": "0KCFr7Lp"}, {"notificationType": {"Ve5XUCfS": true, "N0f4vFBe": true, "H6fyexaW": true}, "userId": "6mEjQVwN"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn csm \
    --op BulkSaveSubscriptionAppNotificationV2 \
    --app 'cKtYgpWq' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 42 'BulkSaveSubscriptionAppNotificationV2' test.out

#- 43 SubscribeAppNotificationV2
# body param: body
echo '{"notificationType": "OZrQ7iBg", "subscribers": [{"userId": "pSjNAIzd"}, {"userId": "Ub68bpgc"}, {"userId": "e9TGlWP5"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn csm \
    --op SubscribeAppNotificationV2 \
    --app 'ae1xuxQU' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 43 'SubscribeAppNotificationV2' test.out

#- 44 GetSubscriptionV2Handler
$CLI_EXE \
    --sn csm \
    --op GetSubscriptionV2Handler \
    --app 'Otg1Pp66' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 44 'GetSubscriptionV2Handler' test.out

#- 45 SubscribeV2Handler
# body param: body
echo '{"notificationType": "cHFNldYB"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn csm \
    --op SubscribeV2Handler \
    --app 'fXPMOwKC' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 45 'SubscribeV2Handler' test.out

#- 46 UnsubscribeV2Handler
$CLI_EXE \
    --sn csm \
    --op UnsubscribeV2Handler \
    --app 'FkmGNsEB' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 46 'UnsubscribeV2Handler' test.out

#- 47 DeleteSubscriptionAppNotificationByUserIDV2
$CLI_EXE \
    --sn csm \
    --op DeleteSubscriptionAppNotificationByUserIDV2 \
    --app 'jWSqLB79' \
    --namespace $AB_NAMESPACE \
    --userId 'vEjXistm' \
    > test.out 2>&1
eval_tap $? 47 'DeleteSubscriptionAppNotificationByUserIDV2' test.out

#- 48 DeleteSubscriptionAppNotificationV2
eval_tap 0 48 'DeleteSubscriptionAppNotificationV2 # SKIP deprecated' test.out

#- 49 GetListOfVariablesV2
$CLI_EXE \
    --sn csm \
    --op GetListOfVariablesV2 \
    --app 'KdB1DMw2' \
    --namespace $AB_NAMESPACE \
    --limit '95' \
    --offset '74' \
    > test.out 2>&1
eval_tap $? 49 'GetListOfVariablesV2' test.out

#- 50 SaveVariableV2
# body param: body
echo '{"applyMask": false, "configName": "sucvrMoW", "description": "SRVtbvzz", "source": "zpam1X6k", "value": "IuoUrHTM"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn csm \
    --op SaveVariableV2 \
    --app 'SFrnOq93' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 50 'SaveVariableV2' test.out

#- 51 UpdateVariableV2
# body param: body
echo '{"applyMask": false, "description": "jvMLA82r", "value": "qCmC2kk8"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn csm \
    --op UpdateVariableV2 \
    --app 'qhJGMOZw' \
    --configId 'Teeg3f8J' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 51 'UpdateVariableV2' test.out

#- 52 DeleteVariableV2
$CLI_EXE \
    --sn csm \
    --op DeleteVariableV2 \
    --app 'coIvyP1I' \
    --configId 'KeVcDbKA' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 52 'DeleteVariableV2' test.out

#- 53 GetListOfDeploymentV2
# body param: body
echo '{"appIds": ["X1NIRimW", "fgJpqNmZ", "2aZcmD0V"], "deploymentIds": ["v0lWRoUN", "au8pxFZP", "TvTRZFGe"], "statuses": ["7M8BGPtw", "iPDsRFuH", "UGSYTw87"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn csm \
    --op GetListOfDeploymentV2 \
    --namespace $AB_NAMESPACE \
    --limit '31' \
    --offset '1' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 53 'GetListOfDeploymentV2' test.out

#- 54 GetDeploymentV2
$CLI_EXE \
    --sn csm \
    --op GetDeploymentV2 \
    --deploymentId 'hxd5206y' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 54 'GetDeploymentV2' test.out

#- 55 DeleteDeploymentV2
$CLI_EXE \
    --sn csm \
    --op DeleteDeploymentV2 \
    --deploymentId '3kgoi0MC' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 55 'DeleteDeploymentV2' test.out

#- 56 GetResourcesLimits
$CLI_EXE \
    --sn csm \
    --op GetResourcesLimits \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 56 'GetResourcesLimits' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE