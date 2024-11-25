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
    --app 'uEWVofOA' \
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
echo '{"appNames": ["zolyBedI", "Tubl6hMG", "UTGHtFdp"], "appStatuses": ["M5urEMOh", "wqv3iish", "xUGdAulG"], "fuzzyAppName": "ZK3kIMls", "scenario": "cYr5e0iw"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn csm \
    --op GetAppListV2 \
    --namespace $AB_NAMESPACE \
    --limit '57' \
    --offset '23' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 25 'GetAppListV2' test.out

#- 26 GetAppV2
$CLI_EXE \
    --sn csm \
    --op GetAppV2 \
    --app 'YYyScA3h' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 26 'GetAppV2' test.out

#- 27 CreateAppV2
# body param: body
echo '{"autoscaling": {"targetCPUUtilizationPercent": 84}, "cpu": {"requestCPU": 15}, "description": "fjp6uJmB", "memory": {"requestMemory": 12}, "replica": {"maxReplica": 35, "minReplica": 41}, "scenario": "L9df0SHE"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn csm \
    --op CreateAppV2 \
    --app 'zN2GlPFB' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 27 'CreateAppV2' test.out

#- 28 DeleteAppV2
$CLI_EXE \
    --sn csm \
    --op DeleteAppV2 \
    --app 'TfCXmeN4' \
    --namespace $AB_NAMESPACE \
    --forced '3lTPU3GX' \
    > test.out 2>&1
eval_tap $? 28 'DeleteAppV2' test.out

#- 29 UpdateAppV2
# body param: body
echo '{"description": "kjeWoFP5"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn csm \
    --op UpdateAppV2 \
    --app 'd0sS1CL3' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 29 'UpdateAppV2' test.out

#- 30 CreateDeploymentV2
# body param: body
echo '{"imageTag": "pO4DPK6i"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn csm \
    --op CreateDeploymentV2 \
    --app 'iTs8o5th' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 30 'CreateDeploymentV2' test.out

#- 31 GetAppImageListV2
$CLI_EXE \
    --sn csm \
    --op GetAppImageListV2 \
    --app 'CjYh5h5K' \
    --namespace $AB_NAMESPACE \
    --cached 'mq9p2XEU' \
    > test.out 2>&1
eval_tap $? 31 'GetAppImageListV2' test.out

#- 32 DeleteAppImagesV2
# body param: body
echo '{"imageTags": ["3G6uyMCE", "y6v0kcAV", "hm5L0mzO"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn csm \
    --op DeleteAppImagesV2 \
    --app 'arAZSKQb' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 32 'DeleteAppImagesV2' test.out

#- 33 UpdateAppResourcesV2
# body param: body
echo '{"autoscaling": {"targetCPUUtilizationPercent": 53}, "cpu": {"requestCPU": 31}, "memory": {"requestMemory": 0}, "replica": {"maxReplica": 14, "minReplica": 80}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn csm \
    --op UpdateAppResourcesV2 \
    --app 'E8IV3fmP' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 33 'UpdateAppResourcesV2' test.out

#- 34 UpdateAppResourcesResourceLimitFormV2
# body param: body
echo '{"clientEmail": "9J8d9wWn", "preferredLimitReplica": 9, "requestReason": "iQ6jdCP5"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn csm \
    --op UpdateAppResourcesResourceLimitFormV2 \
    --app 'JuvKyj2o' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 34 'UpdateAppResourcesResourceLimitFormV2' test.out

#- 35 GetListOfSecretsV2
$CLI_EXE \
    --sn csm \
    --op GetListOfSecretsV2 \
    --app '5ldmyYDf' \
    --namespace $AB_NAMESPACE \
    --limit '37' \
    --offset '27' \
    > test.out 2>&1
eval_tap $? 35 'GetListOfSecretsV2' test.out

#- 36 SaveSecretV2
# body param: body
echo '{"applyMask": true, "configName": "jW8cU3TU", "description": "hOmP5aIm", "source": "l95DZgyu", "value": "ov4YUEe4"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn csm \
    --op SaveSecretV2 \
    --app 'mW7LdSlx' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 36 'SaveSecretV2' test.out

#- 37 UpdateSecretV2
# body param: body
echo '{"applyMask": true, "description": "TuAtbaXn", "value": "PM0l1Rzz"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn csm \
    --op UpdateSecretV2 \
    --app 'tW1TcsPu' \
    --configId 'B9FKOhTg' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 37 'UpdateSecretV2' test.out

#- 38 DeleteSecretV2
$CLI_EXE \
    --sn csm \
    --op DeleteSecretV2 \
    --app 'tdImLNU5' \
    --configId 'PYdrdKfT' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 38 'DeleteSecretV2' test.out

#- 39 StartAppV2
$CLI_EXE \
    --sn csm \
    --op StartAppV2 \
    --app 'kaAmLaz1' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 39 'StartAppV2' test.out

#- 40 StopAppV2
$CLI_EXE \
    --sn csm \
    --op StopAppV2 \
    --app 'Ssk1APqa' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 40 'StopAppV2' test.out

#- 41 GetNotificationSubscriberListV2
$CLI_EXE \
    --sn csm \
    --op GetNotificationSubscriberListV2 \
    --app '8MkDjTnQ' \
    --namespace $AB_NAMESPACE \
    --notificationType 'DQh4Xa1F' \
    > test.out 2>&1
eval_tap $? 41 'GetNotificationSubscriberListV2' test.out

#- 42 BulkSaveSubscriptionAppNotificationV2
# body param: body
echo '{"subscribers": [{"notificationType": {"QjBVogQp": false, "Tua9TXFD": false, "P8v47oLM": true}, "userId": "DHHD1FCM"}, {"notificationType": {"Br5PD57F": false, "RYFCRrLd": false, "ZZkDh6xU": false}, "userId": "KoWQ74PF"}, {"notificationType": {"iIiFLPQG": false, "WF8HzQ8W": false, "FVOxcerK": true}, "userId": "VaXXoOmg"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn csm \
    --op BulkSaveSubscriptionAppNotificationV2 \
    --app 'YznS961u' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 42 'BulkSaveSubscriptionAppNotificationV2' test.out

#- 43 SubscribeAppNotificationV2
# body param: body
echo '{"notificationType": "TjP462dO", "subscribers": [{"userId": "h8iTP369"}, {"userId": "bMJ6K688"}, {"userId": "H1RwXLYd"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn csm \
    --op SubscribeAppNotificationV2 \
    --app 'SUeMxeJK' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 43 'SubscribeAppNotificationV2' test.out

#- 44 GetSubscriptionV2Handler
$CLI_EXE \
    --sn csm \
    --op GetSubscriptionV2Handler \
    --app 'y9HUfbYg' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 44 'GetSubscriptionV2Handler' test.out

#- 45 SubscribeV2Handler
# body param: body
echo '{"notificationType": "SRwTw6cq"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn csm \
    --op SubscribeV2Handler \
    --app 'S7jXNGqQ' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 45 'SubscribeV2Handler' test.out

#- 46 UnsubscribeV2Handler
$CLI_EXE \
    --sn csm \
    --op UnsubscribeV2Handler \
    --app 'duTTjubW' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 46 'UnsubscribeV2Handler' test.out

#- 47 DeleteSubscriptionAppNotificationByUserIDV2
$CLI_EXE \
    --sn csm \
    --op DeleteSubscriptionAppNotificationByUserIDV2 \
    --app '6E94oulB' \
    --namespace $AB_NAMESPACE \
    --userId 'rWCishV9' \
    > test.out 2>&1
eval_tap $? 47 'DeleteSubscriptionAppNotificationByUserIDV2' test.out

#- 48 DeleteSubscriptionAppNotificationV2
eval_tap 0 48 'DeleteSubscriptionAppNotificationV2 # SKIP deprecated' test.out

#- 49 GetListOfVariablesV2
$CLI_EXE \
    --sn csm \
    --op GetListOfVariablesV2 \
    --app 'WeGNUsq3' \
    --namespace $AB_NAMESPACE \
    --limit '18' \
    --offset '41' \
    > test.out 2>&1
eval_tap $? 49 'GetListOfVariablesV2' test.out

#- 50 SaveVariableV2
# body param: body
echo '{"applyMask": false, "configName": "VnwBBhiy", "description": "QTwmNYG5", "source": "pv0D8iRF", "value": "LF6UzPt4"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn csm \
    --op SaveVariableV2 \
    --app '0rha5WuH' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 50 'SaveVariableV2' test.out

#- 51 UpdateVariableV2
# body param: body
echo '{"applyMask": false, "description": "2gVOl4o9", "value": "iebeBCFu"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn csm \
    --op UpdateVariableV2 \
    --app 'XRXXFeSo' \
    --configId 'GGbgbKH8' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 51 'UpdateVariableV2' test.out

#- 52 DeleteVariableV2
$CLI_EXE \
    --sn csm \
    --op DeleteVariableV2 \
    --app 'CBS296Qc' \
    --configId 'bsfgnVuY' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 52 'DeleteVariableV2' test.out

#- 53 GetListOfDeploymentV2
# body param: body
echo '{"appIds": ["8x0oTEbH", "OlNRN3gb", "iboGXuNE"], "deploymentIds": ["T6WN3Q9e", "EbDnnezU", "evKj7xrh"], "statuses": ["E01NAyku", "VoFLwznB", "hNQJzPw4"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn csm \
    --op GetListOfDeploymentV2 \
    --namespace $AB_NAMESPACE \
    --limit '22' \
    --offset '61' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 53 'GetListOfDeploymentV2' test.out

#- 54 GetDeploymentV2
$CLI_EXE \
    --sn csm \
    --op GetDeploymentV2 \
    --deploymentId 'pUgg9bnA' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 54 'GetDeploymentV2' test.out

#- 55 DeleteDeploymentV2
$CLI_EXE \
    --sn csm \
    --op DeleteDeploymentV2 \
    --deploymentId 'cLsCDzFN' \
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