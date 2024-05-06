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
echo "1..42"

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
echo '{"name": "TLKrgSA2"}' > $TEMP_JSON_INPUT
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
echo '{"token": "fV2X0BnK"}' > $TEMP_JSON_INPUT
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
    --artifactType 'TmutzXl7' \
    --count '365' \
    --endDate 'mDLJnJtZ' \
    --fleetID 'q1lwYxaV' \
    --imageID 'kPL4sCRt' \
    --maxSize '62' \
    --minSize '79' \
    --offset '29' \
    --region 'UaxQL8i5' \
    --serverId 'oNmxiKpU' \
    --startDate '8ew1glBq' \
    --status 'kJAOFnj1' \
    > test.out 2>&1
eval_tap $? 8 'ArtifactGet' test.out

#- 9 ArtifactUsageGet
$CLI_EXE \
    --sn ams \
    --op ArtifactUsageGet \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 9 'ArtifactUsageGet' test.out

#- 10 ArtifactDelete
$CLI_EXE \
    --sn ams \
    --op ArtifactDelete \
    --artifactID 'Oooy1mX9' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 10 'ArtifactDelete' test.out

#- 11 ArtifactGetURL
$CLI_EXE \
    --sn ams \
    --op ArtifactGetURL \
    --artifactID 'jd0peH5V' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 11 'ArtifactGetURL' test.out

#- 12 DevelopmentServerConfigurationList
$CLI_EXE \
    --sn ams \
    --op DevelopmentServerConfigurationList \
    --namespace $AB_NAMESPACE \
    --count '216' \
    --offset '41' \
    > test.out 2>&1
eval_tap $? 12 'DevelopmentServerConfigurationList' test.out

#- 13 DevelopmentServerConfigurationCreate
# body param: body
echo '{"commandLineArguments": "O7IBIc8p", "imageId": "dylEz278", "name": "uvth5X9j"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ams \
    --op DevelopmentServerConfigurationCreate \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 13 'DevelopmentServerConfigurationCreate' test.out

#- 14 DevelopmentServerConfigurationGet
$CLI_EXE \
    --sn ams \
    --op DevelopmentServerConfigurationGet \
    --developmentServerConfigID '4p6FdjGo' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 14 'DevelopmentServerConfigurationGet' test.out

#- 15 DevelopmentServerConfigurationDelete
$CLI_EXE \
    --sn ams \
    --op DevelopmentServerConfigurationDelete \
    --developmentServerConfigID 'bRXLQ2fX' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 15 'DevelopmentServerConfigurationDelete' test.out

#- 16 FleetList
$CLI_EXE \
    --sn ams \
    --op FleetList \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 16 'FleetList' test.out

#- 17 FleetCreate
# body param: body
echo '{"active": true, "claimKeys": ["L9XgxO5q", "bWaz7uod", "csNbA8JK"], "dsHostConfiguration": {"instanceId": "PozFoga2", "instanceType": "fkxWUOtm", "serversPerVm": 38}, "imageDeploymentProfile": {"commandLine": "VtVbLbZM", "imageId": "ylKDfvoC", "portConfigurations": [{"name": "5pEiysW4", "protocol": "EeQfo01v"}, {"name": "Zqy5NbY1", "protocol": "rS1W7miX"}, {"name": "biHrOOIF", "protocol": "aTtgwf7I"}], "timeout": {"creation": 30, "drain": 25, "session": 25, "unresponsive": 21}}, "name": "krv9STMi", "onDemand": false, "regions": [{"bufferSize": 56, "maxServerCount": 96, "minServerCount": 99, "region": "dJXDYEFL"}, {"bufferSize": 35, "maxServerCount": 2, "minServerCount": 62, "region": "OR6Y0rpo"}, {"bufferSize": 93, "maxServerCount": 46, "minServerCount": 57, "region": "iB3o3VuN"}], "samplingRules": {"coredumps": {"crashed": {"collect": false, "percentage": 29}, "success": {"collect": true, "percentage": 83}}, "logs": {"crashed": {"collect": true, "percentage": 28}, "success": {"collect": true, "percentage": 73}}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ams \
    --op FleetCreate \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 17 'FleetCreate' test.out

#- 18 FleetGet
$CLI_EXE \
    --sn ams \
    --op FleetGet \
    --fleetID 'fCc3VrZC' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 18 'FleetGet' test.out

#- 19 FleetUpdate
# body param: body
echo '{"active": true, "claimKeys": ["uBX9vJ6i", "pggWvo0M", "MrQq7zeZ"], "dsHostConfiguration": {"instanceId": "d4WNzReX", "instanceType": "zsq9SgL1", "serversPerVm": 78}, "imageDeploymentProfile": {"commandLine": "XrZwwyzf", "imageId": "ouhEf3Bj", "portConfigurations": [{"name": "FPo7umUG", "protocol": "sjQbEr4g"}, {"name": "H41k8uJd", "protocol": "Ue45YWEh"}, {"name": "yn4Tp6VI", "protocol": "YMsSjIvy"}], "timeout": {"creation": 15, "drain": 71, "session": 41, "unresponsive": 73}}, "name": "N3GrPKZl", "onDemand": false, "regions": [{"bufferSize": 50, "maxServerCount": 37, "minServerCount": 64, "region": "KySXkWh9"}, {"bufferSize": 85, "maxServerCount": 44, "minServerCount": 28, "region": "If4c3zBW"}, {"bufferSize": 35, "maxServerCount": 22, "minServerCount": 58, "region": "x3dOcksj"}], "samplingRules": {"coredumps": {"crashed": {"collect": false, "percentage": 69}, "success": {"collect": false, "percentage": 38}}, "logs": {"crashed": {"collect": true, "percentage": 81}, "success": {"collect": false, "percentage": 30}}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ams \
    --op FleetUpdate \
    --fleetID 'bbrlFzYx' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 19 'FleetUpdate' test.out

#- 20 FleetDelete
$CLI_EXE \
    --sn ams \
    --op FleetDelete \
    --fleetID 'zuVOdvG5' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 20 'FleetDelete' test.out

#- 21 FleetArtifactSamplingRulesGet
$CLI_EXE \
    --sn ams \
    --op FleetArtifactSamplingRulesGet \
    --fleetID '7zzoq8bv' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 21 'FleetArtifactSamplingRulesGet' test.out

#- 22 FleetArtifactSamplingRulesSet
# body param: body
echo '{"coredumps": {"crashed": {"collect": false, "percentage": 93}, "success": {"collect": true, "percentage": 83}}, "logs": {"crashed": {"collect": true, "percentage": 42}, "success": {"collect": false, "percentage": 68}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ams \
    --op FleetArtifactSamplingRulesSet \
    --fleetID '0EZ3bNwB' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 22 'FleetArtifactSamplingRulesSet' test.out

#- 23 FleetServers
$CLI_EXE \
    --sn ams \
    --op FleetServers \
    --fleetID 'FeSxlEuX' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 23 'FleetServers' test.out

#- 24 FleetServerHistory
$CLI_EXE \
    --sn ams \
    --op FleetServerHistory \
    --fleetID 'qAokZdGw' \
    --namespace $AB_NAMESPACE \
    --count '44' \
    --offset '53' \
    --reason '3ipDI0fY' \
    --region 'fPbB165e' \
    --serverId 'UwGG2FiO' \
    --sortDirection 'apPO0G4I' \
    --status 'VNhQxMOw' \
    > test.out 2>&1
eval_tap $? 24 'FleetServerHistory' test.out

#- 25 ImageList
$CLI_EXE \
    --sn ams \
    --op ImageList \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 25 'ImageList' test.out

#- 26 ImageGet
$CLI_EXE \
    --sn ams \
    --op ImageGet \
    --imageID 'Bof5OKEs' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 26 'ImageGet' test.out

#- 27 ImagePatch
# body param: body
echo '{"addedTags": ["5DG2KIQo", "SGGqQ0Xl", "U7AXY114"], "isProtected": false, "name": "s2MbWWAz", "removedTags": ["Hh3IbZUs", "KsyNIFFf", "kHMAh4aI"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ams \
    --op ImagePatch \
    --imageID 'OYZ2qOdV' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 27 'ImagePatch' test.out

#- 28 QoSRegionsGet
$CLI_EXE \
    --sn ams \
    --op QoSRegionsGet \
    --namespace $AB_NAMESPACE \
    --status 'pijGdI1H' \
    > test.out 2>&1
eval_tap $? 28 'QoSRegionsGet' test.out

#- 29 QoSRegionsUpdate
# body param: body
echo '{"status": "PfdRTOcw"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ams \
    --op QoSRegionsUpdate \
    --namespace $AB_NAMESPACE \
    --region 'JGo4IFR6' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 29 'QoSRegionsUpdate' test.out

#- 30 InfoRegions
$CLI_EXE \
    --sn ams \
    --op InfoRegions \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 30 'InfoRegions' test.out

#- 31 FleetServerInfo
$CLI_EXE \
    --sn ams \
    --op FleetServerInfo \
    --namespace $AB_NAMESPACE \
    --serverID 'fDFgExjk' \
    > test.out 2>&1
eval_tap $? 31 'FleetServerInfo' test.out

#- 32 FleetServerConnectionInfo
$CLI_EXE \
    --sn ams \
    --op FleetServerConnectionInfo \
    --namespace $AB_NAMESPACE \
    --serverID 'NeVeNr5m' \
    > test.out 2>&1
eval_tap $? 32 'FleetServerConnectionInfo' test.out

#- 33 ServerHistory
$CLI_EXE \
    --sn ams \
    --op ServerHistory \
    --namespace $AB_NAMESPACE \
    --serverID 'sErQT5UW' \
    > test.out 2>&1
eval_tap $? 33 'ServerHistory' test.out

#- 34 InfoSupportedInstances
$CLI_EXE \
    --sn ams \
    --op InfoSupportedInstances \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 34 'InfoSupportedInstances' test.out

#- 35 AccountGet
$CLI_EXE \
    --sn ams \
    --op AccountGet \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 35 'AccountGet' test.out

#- 36 FleetClaimByID
# body param: body
echo '{"region": "tYeTb54k", "sessionId": "wFdBM4qL"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ams \
    --op FleetClaimByID \
    --fleetID 'J6AiSR2q' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 36 'FleetClaimByID' test.out

#- 37 LocalWatchdogConnect
$CLI_EXE \
    --sn ams \
    --op LocalWatchdogConnect \
    --namespace $AB_NAMESPACE \
    --watchdogID 'DOhHMmq1' \
    > test.out 2>&1
eval_tap $? 37 'LocalWatchdogConnect' test.out

#- 38 FleetClaimByKeys
# body param: body
echo '{"claimKeys": ["EKDyczQ2", "32n1Pt7x", "JTj8EYWX"], "regions": ["Uvojcafs", "r0Zukm3u", "HTEA90zX"], "sessionId": "jzh5EQlH"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ams \
    --op FleetClaimByKeys \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 38 'FleetClaimByKeys' test.out

#- 39 WatchdogConnect
$CLI_EXE \
    --sn ams \
    --op WatchdogConnect \
    --namespace $AB_NAMESPACE \
    --watchdogID '7blnsVGB' \
    > test.out 2>&1
eval_tap $? 39 'WatchdogConnect' test.out

#- 40 UploadURLGet
$CLI_EXE \
    --sn ams \
    --op UploadURLGet \
    > test.out 2>&1
eval_tap $? 40 'UploadURLGet' test.out

#- 41 Func1
$CLI_EXE \
    --sn ams \
    --op Func1 \
    > test.out 2>&1
eval_tap $? 41 'Func1' test.out

#- 42 BasicHealthCheck
$CLI_EXE \
    --sn ams \
    --op BasicHealthCheck \
    > test.out 2>&1
eval_tap $? 42 'BasicHealthCheck' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE