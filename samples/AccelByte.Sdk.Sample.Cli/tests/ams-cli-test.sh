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
echo "1..46"

#- 1 Login
$CLI_EXE --op login --lt user --user user --pass user > test.out 2>&1
eval_tap $? 1 'Login' test.out

if [ $EXIT_CODE -ne 0 ]; then
  echo "Bail out! Login failed."
  exit $EXIT_CODE
fi

# echo "foo" > "$CLI_TOKEN_FILE"

#- 2 AuthCheck
$CLI_EXE \
    --sn ams \
    --op AuthCheck \
    > test.out 2>&1
eval_tap $? 2 'AuthCheck' test.out

#- 3 PortalHealthCheck
$CLI_EXE \
    --sn ams \
    --op PortalHealthCheck \
    > test.out 2>&1
eval_tap $? 3 'PortalHealthCheck' test.out

#- 4 AdminAccountGet
$CLI_EXE \
    --sn ams \
    --op AdminAccountGet \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 4 'AdminAccountGet' test.out

#- 5 AdminAccountCreate
# body param: body
echo '{"name": "9jmRhtVG"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ams \
    --op AdminAccountCreate \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 5 'AdminAccountCreate' test.out

#- 6 AdminAccountLinkTokenGet
$CLI_EXE \
    --sn ams \
    --op AdminAccountLinkTokenGet \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 6 'AdminAccountLinkTokenGet' test.out

#- 7 AdminAccountLinkTokenPost
# body param: body
echo '{"token": "QnKbAgzg"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ams \
    --op AdminAccountLinkTokenPost \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 7 'AdminAccountLinkTokenPost' test.out

#- 8 ArtifactGet
$CLI_EXE \
    --sn ams \
    --op ArtifactGet \
    --namespace $AB_NAMESPACE \
    --artifactType 'uxab4bvm' \
    --count '245' \
    --endDate 'jrLzUdWb' \
    --fleetID 'lGyQMSJZ' \
    --imageID 'vh7Gvyjd' \
    --maxSize '41' \
    --minSize '77' \
    --offset '35' \
    --region 'Cojga9LK' \
    --serverId 'bh41wNGn' \
    --startDate 'FAnZwelL' \
    --status '5utnTd6Z' \
    > test.out 2>&1
eval_tap $? 8 'ArtifactGet' test.out

#- 9 ArtifactBulkDelete
$CLI_EXE \
    --sn ams \
    --op ArtifactBulkDelete \
    --namespace $AB_NAMESPACE \
    --artifactType 'fvptFMsU' \
    --fleetId '7xYbgZO8' \
    --uploadedBefore '1984-03-23' \
    > test.out 2>&1
eval_tap $? 9 'ArtifactBulkDelete' test.out

#- 10 ArtifactUsageGet
$CLI_EXE \
    --sn ams \
    --op ArtifactUsageGet \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 10 'ArtifactUsageGet' test.out

#- 11 ArtifactDelete
$CLI_EXE \
    --sn ams \
    --op ArtifactDelete \
    --artifactID '92IQSfft' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 11 'ArtifactDelete' test.out

#- 12 ArtifactGetURL
$CLI_EXE \
    --sn ams \
    --op ArtifactGetURL \
    --artifactID '2AZPgeti' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 12 'ArtifactGetURL' test.out

#- 13 DevelopmentServerConfigurationList
$CLI_EXE \
    --sn ams \
    --op DevelopmentServerConfigurationList \
    --namespace $AB_NAMESPACE \
    --count '67' \
    --offset '39' \
    > test.out 2>&1
eval_tap $? 13 'DevelopmentServerConfigurationList' test.out

#- 14 DevelopmentServerConfigurationCreate
# body param: body
echo '{"commandLineArguments": "OGmczqMJ", "imageId": "nv3E9wbo", "name": "0PjiNrKg"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ams \
    --op DevelopmentServerConfigurationCreate \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 14 'DevelopmentServerConfigurationCreate' test.out

#- 15 DevelopmentServerConfigurationGet
$CLI_EXE \
    --sn ams \
    --op DevelopmentServerConfigurationGet \
    --developmentServerConfigID 'CEK02NpE' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 15 'DevelopmentServerConfigurationGet' test.out

#- 16 DevelopmentServerConfigurationDelete
$CLI_EXE \
    --sn ams \
    --op DevelopmentServerConfigurationDelete \
    --developmentServerConfigID 'KS314Zxc' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 16 'DevelopmentServerConfigurationDelete' test.out

#- 17 FleetList
$CLI_EXE \
    --sn ams \
    --op FleetList \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 17 'FleetList' test.out

#- 18 FleetCreate
# body param: body
echo '{"active": true, "claimKeys": ["xwHoaC4m", "oWlnSiIA", "xqyRgtiY"], "dsHostConfiguration": {"instanceId": "sY900SvD", "instanceType": "SAb5fEG5", "serversPerVm": 38}, "imageDeploymentProfile": {"commandLine": "Up7nCD7b", "imageId": "un5U0OFQ", "portConfigurations": [{"name": "wzDjI8Rj", "protocol": "v7b9flkz"}, {"name": "0e3r0c7v", "protocol": "hOpig3mn"}, {"name": "y8UokKyb", "protocol": "TQ37Csjo"}], "timeout": {"creation": 41, "drain": 61, "session": 12, "unresponsive": 46}}, "name": "y26m1EyF", "onDemand": true, "regions": [{"bufferSize": 37, "dynamicBuffer": true, "maxServerCount": 27, "minServerCount": 42, "region": "T6iUs7pm"}, {"bufferSize": 34, "dynamicBuffer": false, "maxServerCount": 100, "minServerCount": 25, "region": "1azijFFo"}, {"bufferSize": 32, "dynamicBuffer": true, "maxServerCount": 84, "minServerCount": 61, "region": "yqbw0pbk"}], "samplingRules": {"coredumps": {"crashed": {"collect": false, "percentage": 67}, "success": {"collect": true, "percentage": 36}}, "logs": {"crashed": {"collect": true, "percentage": 30}, "success": {"collect": true, "percentage": 21}}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ams \
    --op FleetCreate \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 18 'FleetCreate' test.out

#- 19 FleetGet
$CLI_EXE \
    --sn ams \
    --op FleetGet \
    --fleetID 'UtlDBbUF' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 19 'FleetGet' test.out

#- 20 FleetUpdate
# body param: body
echo '{"active": false, "claimKeys": ["EClF9fye", "ujzURTVJ", "PU7NM33V"], "dsHostConfiguration": {"instanceId": "jgCQ2xnk", "instanceType": "Ii1CnPff", "serversPerVm": 76}, "imageDeploymentProfile": {"commandLine": "MAOP7WbM", "imageId": "ZNbBILIa", "portConfigurations": [{"name": "HflZJRVV", "protocol": "3KDLqKtm"}, {"name": "WoFhcirz", "protocol": "HxhxV2JF"}, {"name": "RATRNPHv", "protocol": "gjtf0ZZW"}], "timeout": {"creation": 65, "drain": 9, "session": 74, "unresponsive": 58}}, "name": "eDd9ms0z", "onDemand": true, "regions": [{"bufferSize": 53, "dynamicBuffer": false, "maxServerCount": 13, "minServerCount": 62, "region": "he6wvGrP"}, {"bufferSize": 18, "dynamicBuffer": true, "maxServerCount": 67, "minServerCount": 51, "region": "bwXHxcfR"}, {"bufferSize": 34, "dynamicBuffer": false, "maxServerCount": 16, "minServerCount": 76, "region": "8afPrckj"}], "samplingRules": {"coredumps": {"crashed": {"collect": true, "percentage": 80}, "success": {"collect": false, "percentage": 6}}, "logs": {"crashed": {"collect": true, "percentage": 95}, "success": {"collect": false, "percentage": 89}}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ams \
    --op FleetUpdate \
    --fleetID 'mr0oNNtj' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 20 'FleetUpdate' test.out

#- 21 FleetDelete
$CLI_EXE \
    --sn ams \
    --op FleetDelete \
    --fleetID 'PM9ytn8b' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 21 'FleetDelete' test.out

#- 22 FleetArtifactSamplingRulesGet
$CLI_EXE \
    --sn ams \
    --op FleetArtifactSamplingRulesGet \
    --fleetID 'KlFATec4' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 22 'FleetArtifactSamplingRulesGet' test.out

#- 23 FleetArtifactSamplingRulesSet
# body param: body
echo '{"coredumps": {"crashed": {"collect": true, "percentage": 8}, "success": {"collect": false, "percentage": 14}}, "logs": {"crashed": {"collect": false, "percentage": 10}, "success": {"collect": false, "percentage": 45}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ams \
    --op FleetArtifactSamplingRulesSet \
    --fleetID 'ohcVYgTj' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 23 'FleetArtifactSamplingRulesSet' test.out

#- 24 FleetServers
$CLI_EXE \
    --sn ams \
    --op FleetServers \
    --fleetID '0JOQfW1A' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 24 'FleetServers' test.out

#- 25 FleetServerHistory
$CLI_EXE \
    --sn ams \
    --op FleetServerHistory \
    --fleetID 'nlGTSw99' \
    --namespace $AB_NAMESPACE \
    --count '3' \
    --offset '97' \
    --reason 'mezwGh4i' \
    --region 'tfK8qzno' \
    --serverId 'okbjQmJV' \
    --sortDirection 'd1OS3KAU' \
    --status 'rVi77uGu' \
    > test.out 2>&1
eval_tap $? 25 'FleetServerHistory' test.out

#- 26 ImageList
$CLI_EXE \
    --sn ams \
    --op ImageList \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 26 'ImageList' test.out

#- 27 ImagesStorage
$CLI_EXE \
    --sn ams \
    --op ImagesStorage \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 27 'ImagesStorage' test.out

#- 28 ImageGet
$CLI_EXE \
    --sn ams \
    --op ImageGet \
    --imageID 'RbrcFI0B' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 28 'ImageGet' test.out

#- 29 ImageMarkForDeletion
$CLI_EXE \
    --sn ams \
    --op ImageMarkForDeletion \
    --imageID '2Y9jnasE' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 29 'ImageMarkForDeletion' test.out

#- 30 ImagePatch
# body param: body
echo '{"addedTags": ["yo2GTebq", "r9yYl997", "1ghGLxyY"], "isProtected": false, "name": "VsjkPpBx", "removedTags": ["r8s3ij0n", "EWPlpuKR", "zntBoTBI"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ams \
    --op ImagePatch \
    --imageID 'HUcLcens' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 30 'ImagePatch' test.out

#- 31 ImageUnmarkForDeletion
$CLI_EXE \
    --sn ams \
    --op ImageUnmarkForDeletion \
    --imageID 'AS16Xpcw' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 31 'ImageUnmarkForDeletion' test.out

#- 32 QoSRegionsGet
$CLI_EXE \
    --sn ams \
    --op QoSRegionsGet \
    --namespace $AB_NAMESPACE \
    --status 'JFrBwcsi' \
    > test.out 2>&1
eval_tap $? 32 'QoSRegionsGet' test.out

#- 33 QoSRegionsUpdate
# body param: body
echo '{"status": "NIQNHo6j"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ams \
    --op QoSRegionsUpdate \
    --namespace $AB_NAMESPACE \
    --region 'LmvjvuHp' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 33 'QoSRegionsUpdate' test.out

#- 34 InfoRegions
$CLI_EXE \
    --sn ams \
    --op InfoRegions \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 34 'InfoRegions' test.out

#- 35 FleetServerInfo
$CLI_EXE \
    --sn ams \
    --op FleetServerInfo \
    --namespace $AB_NAMESPACE \
    --serverID 'gIjIimWT' \
    > test.out 2>&1
eval_tap $? 35 'FleetServerInfo' test.out

#- 36 FleetServerConnectionInfo
$CLI_EXE \
    --sn ams \
    --op FleetServerConnectionInfo \
    --namespace $AB_NAMESPACE \
    --serverID 'y80WKi7O' \
    > test.out 2>&1
eval_tap $? 36 'FleetServerConnectionInfo' test.out

#- 37 ServerHistory
$CLI_EXE \
    --sn ams \
    --op ServerHistory \
    --namespace $AB_NAMESPACE \
    --serverID 'inopgPsn' \
    > test.out 2>&1
eval_tap $? 37 'ServerHistory' test.out

#- 38 InfoSupportedInstances
$CLI_EXE \
    --sn ams \
    --op InfoSupportedInstances \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 38 'InfoSupportedInstances' test.out

#- 39 AccountGet
$CLI_EXE \
    --sn ams \
    --op AccountGet \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 39 'AccountGet' test.out

#- 40 FleetClaimByID
# body param: body
echo '{"region": "uazqCSnX", "sessionId": "ddSdpbMO"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ams \
    --op FleetClaimByID \
    --fleetID 'LyE20a3L' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 40 'FleetClaimByID' test.out

#- 41 LocalWatchdogConnect
$CLI_EXE \
    --sn ams \
    --op LocalWatchdogConnect \
    --namespace $AB_NAMESPACE \
    --watchdogID 'pqVRaTrS' \
    > test.out 2>&1
eval_tap $? 41 'LocalWatchdogConnect' test.out

#- 42 FleetClaimByKeys
# body param: body
echo '{"claimKeys": ["jRsjStrW", "A6gaBuIJ", "svvihwb6"], "regions": ["OdfV7ybB", "0LKYGlbf", "V6xlRZoS"], "sessionId": "OvZYkuVi"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ams \
    --op FleetClaimByKeys \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 42 'FleetClaimByKeys' test.out

#- 43 WatchdogConnect
$CLI_EXE \
    --sn ams \
    --op WatchdogConnect \
    --namespace $AB_NAMESPACE \
    --watchdogID '5KzjLSYZ' \
    > test.out 2>&1
eval_tap $? 43 'WatchdogConnect' test.out

#- 44 UploadURLGet
$CLI_EXE \
    --sn ams \
    --op UploadURLGet \
    > test.out 2>&1
eval_tap $? 44 'UploadURLGet' test.out

#- 45 Func1
$CLI_EXE \
    --sn ams \
    --op Func1 \
    > test.out 2>&1
eval_tap $? 45 'Func1' test.out

#- 46 BasicHealthCheck
$CLI_EXE \
    --sn ams \
    --op BasicHealthCheck \
    > test.out 2>&1
eval_tap $? 46 'BasicHealthCheck' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE