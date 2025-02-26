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
echo "1..89"

#- 1 Login
$CLI_EXE --op login --lt user --user user --pass user > test.out 2>&1
eval_tap $? 1 'Login' test.out

if [ $EXIT_CODE -ne 0 ]; then
  echo "Bail out! Login failed."
  exit $EXIT_CODE
fi

# echo "foo" > "$CLI_TOKEN_FILE"

#- 2 ListConfig
$CLI_EXE \
    --sn dsmc \
    --op ListConfig \
    > test.out 2>&1
eval_tap $? 2 'ListConfig' test.out

#- 3 SaveConfig
eval_tap 0 3 'SaveConfig # SKIP deprecated' test.out

#- 4 UpdateImage
# body param: body
echo '{"artifactPath": "kmIWzLCz", "coreDumpEnabled": true, "image": "IdB9siyT", "imageReplicationsMap": {"6EJFc4IX": {"failure_code": "P9pImteI", "region": "loUrwKUV", "status": "UIijIdzz", "uri": "NlrTPpJC"}, "PwRVdB04": {"failure_code": "YDxiKpvz", "region": "WRx5s3Fc", "status": "IugVPOpR", "uri": "BTv43MOz"}, "HP8b9QH8": {"failure_code": "mL6pX9MH", "region": "BCAor1da", "status": "SSglZLYO", "uri": "dDylayAA"}}, "namespace": "OWEJK6np", "patchVersion": "R6DlueXy", "persistent": true, "ulimitFileSize": 36, "version": "93PBpp2U"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op UpdateImage \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 4 'UpdateImage' test.out

#- 5 CreateImage
# body param: body
echo '{"artifactPath": "hqiuKaXA", "coreDumpEnabled": false, "dockerPath": "9wsopMhS", "image": "rg3Kdqxg", "imageSize": 19, "namespace": "36fYJNOP", "persistent": true, "ulimitFileSize": 84, "version": "yD5oMTCt"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreateImage \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 5 'CreateImage' test.out

#- 6 CreateImagePatch
# body param: body
echo '{"artifactPath": "f2KGPpV2", "coreDumpEnabled": false, "dockerPath": "Ww6O9ZkJ", "image": "Y0rmvVgh", "imageSize": 55, "namespace": "QiLPedWe", "patchVersion": "bbkljOA9", "persistent": false, "ulimitFileSize": 93, "uploaderFlag": "nF8YbZBm", "version": "RTzWNT9X"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreateImagePatch \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 6 'CreateImagePatch' test.out

#- 7 GetLowestInstanceSpec
$CLI_EXE \
    --sn dsmc \
    --op GetLowestInstanceSpec \
    > test.out 2>&1
eval_tap $? 7 'GetLowestInstanceSpec' test.out

#- 8 GetWorkerConfig
$CLI_EXE \
    --sn dsmc \
    --op GetWorkerConfig \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 8 'GetWorkerConfig' test.out

#- 9 UpdateWorkerConfig
# body param: body
echo '{"auto_deletion": true, "ghost_worker": true, "manual_buffer_override": false, "zombie_worker": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op UpdateWorkerConfig \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 9 'UpdateWorkerConfig' test.out

#- 10 CreateWorkerConfig
# body param: body
echo '{"auto_deletion": true, "ghost_worker": true, "manual_buffer_override": false, "zombie_worker": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreateWorkerConfig \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 10 'CreateWorkerConfig' test.out

#- 11 GetConfig
$CLI_EXE \
    --sn dsmc \
    --op GetConfig \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 11 'GetConfig' test.out

#- 12 CreateConfig
# body param: body
echo '{"claim_timeout": 3, "creation_timeout": 31, "default_version": "sAheEtst", "port": 22, "ports": {"h9pFfClT": 94, "fJ3vfsCy": 91, "Bi6tIbcs": 29}, "protocol": "iUEC9aJ5", "providers": ["rGdl815g", "zlDjPhPT", "ibgzO1AM"], "session_timeout": 65, "unreachable_timeout": 50}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreateConfig \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 12 'CreateConfig' test.out

#- 13 DeleteConfig
$CLI_EXE \
    --sn dsmc \
    --op DeleteConfig \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 13 'DeleteConfig' test.out

#- 14 UpdateConfig
# body param: body
echo '{"claim_timeout": 31, "creation_timeout": 23, "default_version": "6PelwFqF", "port": 14, "protocol": "0W13bPTV", "providers": ["G8NS0LoI", "I1Yu4TLV", "lcTisFbN"], "session_timeout": 85, "unreachable_timeout": 89}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op UpdateConfig \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 14 'UpdateConfig' test.out

#- 15 ClearCache
$CLI_EXE \
    --sn dsmc \
    --op ClearCache \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 15 'ClearCache' test.out

#- 16 GetAllDeployment
$CLI_EXE \
    --sn dsmc \
    --op GetAllDeployment \
    --namespace $AB_NAMESPACE \
    --name 'NpT5ZI10' \
    --count '22' \
    --offset '35' \
    > test.out 2>&1
eval_tap $? 16 'GetAllDeployment' test.out

#- 17 GetDeployment
$CLI_EXE \
    --sn dsmc \
    --op GetDeployment \
    --deployment 'I7dxEEqC' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 17 'GetDeployment' test.out

#- 18 CreateDeployment
# body param: body
echo '{"allow_version_override": false, "buffer_count": 96, "buffer_percent": 18, "configuration": "EY1U01Xc", "enable_region_overrides": false, "extendable_session": false, "game_version": "YQdGfu8j", "max_count": 26, "min_count": 42, "overrides": {"MSYEhi1N": {"buffer_count": 93, "buffer_percent": 67, "configuration": "eOr5dkB8", "enable_region_overrides": true, "extendable_session": false, "game_version": "NwkmkEBf", "max_count": 20, "min_count": 93, "name": "1tBAx4qS", "region_overrides": {"laC6sFO3": {"buffer_count": 90, "buffer_percent": 4, "max_count": 86, "min_count": 5, "name": "FRtV4Lqc", "unlimited": true, "use_buffer_percent": false}, "5ZC8GHUq": {"buffer_count": 32, "buffer_percent": 18, "max_count": 49, "min_count": 80, "name": "G5oH8byV", "unlimited": false, "use_buffer_percent": false}, "rhsjy6cg": {"buffer_count": 55, "buffer_percent": 75, "max_count": 74, "min_count": 47, "name": "tuAtKdgY", "unlimited": true, "use_buffer_percent": false}}, "regions": ["EzQVjbfr", "qSm9BQk1", "QjrOsAJy"], "session_timeout": 44, "unlimited": false, "use_buffer_percent": true}, "amzrHRgF": {"buffer_count": 62, "buffer_percent": 37, "configuration": "pXgSVbf6", "enable_region_overrides": true, "extendable_session": false, "game_version": "MxNLa30G", "max_count": 49, "min_count": 64, "name": "nq91m6VX", "region_overrides": {"Kz7wl2H8": {"buffer_count": 11, "buffer_percent": 2, "max_count": 57, "min_count": 51, "name": "kOD1MPno", "unlimited": false, "use_buffer_percent": true}, "BReYTbI7": {"buffer_count": 74, "buffer_percent": 1, "max_count": 42, "min_count": 88, "name": "RrUuGH3N", "unlimited": true, "use_buffer_percent": false}, "jx4LlP3s": {"buffer_count": 76, "buffer_percent": 64, "max_count": 28, "min_count": 41, "name": "BRXbMnnD", "unlimited": false, "use_buffer_percent": true}}, "regions": ["KDF5eWmQ", "9DPLiVbg", "WQNJEoaa"], "session_timeout": 55, "unlimited": true, "use_buffer_percent": false}, "rEEwDWpT": {"buffer_count": 34, "buffer_percent": 5, "configuration": "ilo4FCAp", "enable_region_overrides": false, "extendable_session": true, "game_version": "2XVxC75P", "max_count": 77, "min_count": 24, "name": "tMLWlC3e", "region_overrides": {"IgRGssbP": {"buffer_count": 86, "buffer_percent": 25, "max_count": 100, "min_count": 76, "name": "Dk6ZpB5n", "unlimited": false, "use_buffer_percent": false}, "A7R78LMu": {"buffer_count": 75, "buffer_percent": 68, "max_count": 79, "min_count": 5, "name": "cimVo2uP", "unlimited": false, "use_buffer_percent": true}, "LQv8fwv2": {"buffer_count": 15, "buffer_percent": 99, "max_count": 87, "min_count": 87, "name": "70JsOXIP", "unlimited": true, "use_buffer_percent": true}}, "regions": ["7IiccOQh", "AgeNfbFj", "Jbe3kTBC"], "session_timeout": 74, "unlimited": false, "use_buffer_percent": true}}, "region_overrides": {"djpgvGEW": {"buffer_count": 19, "buffer_percent": 99, "max_count": 72, "min_count": 64, "name": "RSuee9f6", "unlimited": false, "use_buffer_percent": true}, "UDod1zwC": {"buffer_count": 28, "buffer_percent": 70, "max_count": 44, "min_count": 43, "name": "9xnYf12I", "unlimited": true, "use_buffer_percent": true}, "EFhFkxo0": {"buffer_count": 22, "buffer_percent": 17, "max_count": 83, "min_count": 89, "name": "DokQNfCF", "unlimited": true, "use_buffer_percent": false}}, "regions": ["uqiYApNh", "J7bDYYSN", "r94V2efI"], "session_timeout": 90, "unlimited": false, "use_buffer_percent": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreateDeployment \
    --deployment 'su96rrCj' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 18 'CreateDeployment' test.out

#- 19 DeleteDeployment
$CLI_EXE \
    --sn dsmc \
    --op DeleteDeployment \
    --deployment '6cQPUblk' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 19 'DeleteDeployment' test.out

#- 20 UpdateDeployment
# body param: body
echo '{"allow_version_override": false, "buffer_count": 95, "buffer_percent": 16, "configuration": "SXtaZ5ca", "enable_region_overrides": true, "extendable_session": true, "game_version": "Haja0iA3", "max_count": 82, "min_count": 65, "regions": ["FvQVqk5V", "IdNhhaCC", "p9C3KUfF"], "session_timeout": 20, "unlimited": false, "use_buffer_percent": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op UpdateDeployment \
    --deployment 'yIssCIy6' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 20 'UpdateDeployment' test.out

#- 21 CreateRootRegionOverride
# body param: body
echo '{"buffer_count": 46, "buffer_percent": 17, "max_count": 14, "min_count": 14, "unlimited": false, "use_buffer_percent": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreateRootRegionOverride \
    --deployment '3U0MUdaJ' \
    --namespace $AB_NAMESPACE \
    --region 'Xr9wwJVp' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 21 'CreateRootRegionOverride' test.out

#- 22 DeleteRootRegionOverride
$CLI_EXE \
    --sn dsmc \
    --op DeleteRootRegionOverride \
    --deployment 'eyhBKAEL' \
    --namespace $AB_NAMESPACE \
    --region 'vM9QPyMj' \
    > test.out 2>&1
eval_tap $? 22 'DeleteRootRegionOverride' test.out

#- 23 UpdateRootRegionOverride
# body param: body
echo '{"buffer_count": 94, "buffer_percent": 46, "max_count": 89, "min_count": 72, "unlimited": true, "use_buffer_percent": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op UpdateRootRegionOverride \
    --deployment 'tRpINs1i' \
    --namespace $AB_NAMESPACE \
    --region 'nuChPC0D' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 23 'UpdateRootRegionOverride' test.out

#- 24 CreateDeploymentOverride
# body param: body
echo '{"buffer_count": 50, "buffer_percent": 88, "configuration": "SDOC7ET1", "enable_region_overrides": false, "extendable_session": true, "game_version": "SxgJwKEK", "max_count": 46, "min_count": 54, "region_overrides": {"4vp8djz9": {"buffer_count": 98, "buffer_percent": 33, "max_count": 44, "min_count": 48, "name": "dUXfZNk8", "unlimited": false, "use_buffer_percent": false}, "YQYe2pgp": {"buffer_count": 13, "buffer_percent": 54, "max_count": 91, "min_count": 100, "name": "MPk7jVig", "unlimited": true, "use_buffer_percent": false}, "T37Ctggc": {"buffer_count": 50, "buffer_percent": 7, "max_count": 10, "min_count": 43, "name": "Ohk5hm3d", "unlimited": true, "use_buffer_percent": true}}, "regions": ["k4F3psur", "PxMxywM3", "7WAI7VCl"], "session_timeout": 4, "unlimited": true, "use_buffer_percent": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreateDeploymentOverride \
    --deployment 'VvCZKxNy' \
    --namespace $AB_NAMESPACE \
    --version 'vlW6cgFU' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 24 'CreateDeploymentOverride' test.out

#- 25 DeleteDeploymentOverride
$CLI_EXE \
    --sn dsmc \
    --op DeleteDeploymentOverride \
    --deployment '07e03BAa' \
    --namespace $AB_NAMESPACE \
    --version '75LXVMfm' \
    > test.out 2>&1
eval_tap $? 25 'DeleteDeploymentOverride' test.out

#- 26 UpdateDeploymentOverride
# body param: body
echo '{"buffer_count": 30, "buffer_percent": 65, "configuration": "K57ISi8O", "enable_region_overrides": true, "game_version": "i3aFSoPY", "max_count": 25, "min_count": 77, "regions": ["2dGllPig", "Kg6NRbsK", "4F3T3gNh"], "session_timeout": 35, "unlimited": false, "use_buffer_percent": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op UpdateDeploymentOverride \
    --deployment '9x8bvBQC' \
    --namespace $AB_NAMESPACE \
    --version 'QPhK041D' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 26 'UpdateDeploymentOverride' test.out

#- 27 CreateOverrideRegionOverride
# body param: body
echo '{"buffer_count": 82, "buffer_percent": 76, "max_count": 10, "min_count": 53, "unlimited": true, "use_buffer_percent": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreateOverrideRegionOverride \
    --deployment '5BlGxkqJ' \
    --namespace $AB_NAMESPACE \
    --region 'FD51SM4o' \
    --version 'Uyg94dVH' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 27 'CreateOverrideRegionOverride' test.out

#- 28 DeleteOverrideRegionOverride
$CLI_EXE \
    --sn dsmc \
    --op DeleteOverrideRegionOverride \
    --deployment 'O92HQEtc' \
    --namespace $AB_NAMESPACE \
    --region 'EskDkKQT' \
    --version '7vvw3ZDt' \
    > test.out 2>&1
eval_tap $? 28 'DeleteOverrideRegionOverride' test.out

#- 29 UpdateOverrideRegionOverride
# body param: body
echo '{"buffer_count": 36, "buffer_percent": 28, "max_count": 62, "min_count": 85, "unlimited": true, "use_buffer_percent": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op UpdateOverrideRegionOverride \
    --deployment 'gVI0miKB' \
    --namespace $AB_NAMESPACE \
    --region '2Tc2x9S5' \
    --version 'dLnEPjpP' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 29 'UpdateOverrideRegionOverride' test.out

#- 30 DeleteCreatingServerCountQueue
$CLI_EXE \
    --sn dsmc \
    --op DeleteCreatingServerCountQueue \
    --deployment 'yyWAfndo' \
    --namespace $AB_NAMESPACE \
    --version 'EsgTcbOA' \
    > test.out 2>&1
eval_tap $? 30 'DeleteCreatingServerCountQueue' test.out

#- 31 GetAllPodConfig
$CLI_EXE \
    --sn dsmc \
    --op GetAllPodConfig \
    --namespace $AB_NAMESPACE \
    --count '25' \
    --offset '93' \
    > test.out 2>&1
eval_tap $? 31 'GetAllPodConfig' test.out

#- 32 GetPodConfig
$CLI_EXE \
    --sn dsmc \
    --op GetPodConfig \
    --name 'tea7impN' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 32 'GetPodConfig' test.out

#- 33 CreatePodConfig
# body param: body
echo '{"cpu_limit": 34, "mem_limit": 73, "params": "OVMNixiI"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreatePodConfig \
    --name 'A65cphPi' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 33 'CreatePodConfig' test.out

#- 34 DeletePodConfig
$CLI_EXE \
    --sn dsmc \
    --op DeletePodConfig \
    --name 'l9SsvTwS' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 34 'DeletePodConfig' test.out

#- 35 UpdatePodConfig
# body param: body
echo '{"cpu_limit": 99, "mem_limit": 82, "name": "Zox317OT", "params": "MQf7fIZW"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op UpdatePodConfig \
    --name 'IIkCwg0K' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 35 'UpdatePodConfig' test.out

#- 36 AddPort
# body param: body
echo '{"port": 25}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op AddPort \
    --name 'LaZJK46Y' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 36 'AddPort' test.out

#- 37 DeletePort
$CLI_EXE \
    --sn dsmc \
    --op DeletePort \
    --name 'SVKLDi7u' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 37 'DeletePort' test.out

#- 38 UpdatePort
# body param: body
echo '{"name": "JlXhNUt1", "port": 52}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op UpdatePort \
    --name 'mhO6PHSg' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 38 'UpdatePort' test.out

#- 39 ListImages
$CLI_EXE \
    --sn dsmc \
    --op ListImages \
    --namespace $AB_NAMESPACE \
    --q 'JKJbQPfu' \
    --sortBy 'createdAt' \
    --sortDirection 'asc' \
    --count '63' \
    --offset '57' \
    > test.out 2>&1
eval_tap $? 39 'ListImages' test.out

#- 40 DeleteImage
$CLI_EXE \
    --sn dsmc \
    --op DeleteImage \
    --namespace $AB_NAMESPACE \
    --imageURI 'DSh9Dh8G' \
    --version 'nG9tNDLD' \
    > test.out 2>&1
eval_tap $? 40 'DeleteImage' test.out

#- 41 GetImageLimit
$CLI_EXE \
    --sn dsmc \
    --op GetImageLimit \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 41 'GetImageLimit' test.out

#- 42 DeleteImagePatch
$CLI_EXE \
    --sn dsmc \
    --op DeleteImagePatch \
    --namespace $AB_NAMESPACE \
    --imageURI 'aAoRiTjf' \
    --version 'k7JCoeIG' \
    --versionPatch 'HjRKXUzI' \
    > test.out 2>&1
eval_tap $? 42 'DeleteImagePatch' test.out

#- 43 GetImageDetail
$CLI_EXE \
    --sn dsmc \
    --op GetImageDetail \
    --namespace $AB_NAMESPACE \
    --version 'SZk3zpHY' \
    > test.out 2>&1
eval_tap $? 43 'GetImageDetail' test.out

#- 44 GetImagePatches
$CLI_EXE \
    --sn dsmc \
    --op GetImagePatches \
    --namespace $AB_NAMESPACE \
    --version '8m46Yu35' \
    > test.out 2>&1
eval_tap $? 44 'GetImagePatches' test.out

#- 45 GetImagePatchDetail
$CLI_EXE \
    --sn dsmc \
    --op GetImagePatchDetail \
    --namespace $AB_NAMESPACE \
    --version 'm7stYXwT' \
    --versionPatch 'ngKym384' \
    > test.out 2>&1
eval_tap $? 45 'GetImagePatchDetail' test.out

#- 46 AddBuffer
# body param: body
echo '{"AllocCount": 28, "DeploymentName": "BVmoIaOP", "JobCount": 26, "JobPriority": 83, "OverrideVersion": "e0vTSCbw", "Region": "DfoGxdPe"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op AddBuffer \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 46 'AddBuffer' test.out

#- 47 GetRepository
$CLI_EXE \
    --sn dsmc \
    --op GetRepository \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 47 'GetRepository' test.out

#- 48 ListServer
$CLI_EXE \
    --sn dsmc \
    --op ListServer \
    --namespace $AB_NAMESPACE \
    --region '6UxGdKVc' \
    --count '37' \
    --offset '12' \
    > test.out 2>&1
eval_tap $? 48 'ListServer' test.out

#- 49 CountServer
$CLI_EXE \
    --sn dsmc \
    --op CountServer \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 49 'CountServer' test.out

#- 50 CountServerDetailed
$CLI_EXE \
    --sn dsmc \
    --op CountServerDetailed \
    --namespace $AB_NAMESPACE \
    --region '0caykK8l' \
    > test.out 2>&1
eval_tap $? 50 'CountServerDetailed' test.out

#- 51 ListLocalServer
$CLI_EXE \
    --sn dsmc \
    --op ListLocalServer \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 51 'ListLocalServer' test.out

#- 52 DeleteLocalServer
$CLI_EXE \
    --sn dsmc \
    --op DeleteLocalServer \
    --name 'Q4p1LRPU' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 52 'DeleteLocalServer' test.out

#- 53 GetServer
$CLI_EXE \
    --sn dsmc \
    --op GetServer \
    --namespace $AB_NAMESPACE \
    --podName 'Jq3YvmLu' \
    > test.out 2>&1
eval_tap $? 53 'GetServer' test.out

#- 54 DeleteServer
$CLI_EXE \
    --sn dsmc \
    --op DeleteServer \
    --namespace $AB_NAMESPACE \
    --podName 'xaObf68s' \
    > test.out 2>&1
eval_tap $? 54 'DeleteServer' test.out

#- 55 ListSession
$CLI_EXE \
    --sn dsmc \
    --op ListSession \
    --namespace $AB_NAMESPACE \
    --region 'oHyb7dTY' \
    --withServer 'true' \
    --count '37' \
    --offset '1' \
    > test.out 2>&1
eval_tap $? 55 'ListSession' test.out

#- 56 CountSession
$CLI_EXE \
    --sn dsmc \
    --op CountSession \
    --namespace $AB_NAMESPACE \
    --region 'S0xL6voc' \
    > test.out 2>&1
eval_tap $? 56 'CountSession' test.out

#- 57 DeleteSession
$CLI_EXE \
    --sn dsmc \
    --op DeleteSession \
    --namespace $AB_NAMESPACE \
    --sessionID 'xHWE72Zs' \
    > test.out 2>&1
eval_tap $? 57 'DeleteSession' test.out

#- 58 RunGhostCleanerRequestHandler
$CLI_EXE \
    --sn dsmc \
    --op RunGhostCleanerRequestHandler \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 58 'RunGhostCleanerRequestHandler' test.out

#- 59 RunZombieCleanerRequestHandler
# body param: body
echo '{"JobCount": 96, "Region": "2byjFEL5", "TimeoutSecond": 78, "ZombieCount": 86}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op RunZombieCleanerRequestHandler \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 59 'RunZombieCleanerRequestHandler' test.out

#- 60 CreateRepository
# body param: body
echo '{"namespace": "Q4vxX5TS", "repository": "o6TNPrWM"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreateRepository \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 60 'CreateRepository' test.out

#- 61 ExportConfigV1
$CLI_EXE \
    --sn dsmc \
    --op ExportConfigV1 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 61 'ExportConfigV1' test.out

#- 62 ImportConfigV1
# form data upload: file
echo 'tmp.dat' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --sn dsmc \
    --op ImportConfigV1 \
    --namespace $AB_NAMESPACE \
    --upload file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 62 'ImportConfigV1' test.out

#- 63 GetAllDeploymentClient
$CLI_EXE \
    --sn dsmc \
    --op GetAllDeploymentClient \
    --namespace $AB_NAMESPACE \
    --name 'DCtzEXEl' \
    --count '88' \
    --offset '6' \
    > test.out 2>&1
eval_tap $? 63 'GetAllDeploymentClient' test.out

#- 64 GetDeploymentClient
$CLI_EXE \
    --sn dsmc \
    --op GetDeploymentClient \
    --deployment 'WPzZc0gm' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 64 'GetDeploymentClient' test.out

#- 65 CreateDeploymentClient
# body param: body
echo '{"allow_version_override": false, "buffer_count": 85, "buffer_percent": 25, "configuration": "ZSdSKxV9", "enable_region_overrides": true, "extendable_session": false, "game_version": "DLtpYdId", "max_count": 47, "min_count": 53, "overrides": {"NYB2aMIX": {"buffer_count": 14, "buffer_percent": 25, "configuration": "iIsu0FKK", "enable_region_overrides": false, "extendable_session": false, "game_version": "hEdOlCHm", "max_count": 62, "min_count": 10, "name": "0ljiiena", "region_overrides": {"aFsFqQu7": {"buffer_count": 19, "buffer_percent": 42, "max_count": 23, "min_count": 61, "name": "KLoVOM3d", "unlimited": false, "use_buffer_percent": true}, "3dpMPTKe": {"buffer_count": 89, "buffer_percent": 99, "max_count": 29, "min_count": 9, "name": "kc1nlq1v", "unlimited": true, "use_buffer_percent": true}, "YxLOu14f": {"buffer_count": 79, "buffer_percent": 43, "max_count": 71, "min_count": 36, "name": "B9sBljZl", "unlimited": true, "use_buffer_percent": false}}, "regions": ["9okx6qsi", "v9Lb6zzg", "NuebSC4v"], "session_timeout": 10, "unlimited": false, "use_buffer_percent": false}, "NhGa2Xfc": {"buffer_count": 49, "buffer_percent": 63, "configuration": "DLZBsGrR", "enable_region_overrides": false, "extendable_session": false, "game_version": "jUYyqCZz", "max_count": 20, "min_count": 50, "name": "GHmvIA3X", "region_overrides": {"SMMLdpas": {"buffer_count": 28, "buffer_percent": 28, "max_count": 29, "min_count": 41, "name": "PnmtvJuw", "unlimited": false, "use_buffer_percent": true}, "KMlLv9es": {"buffer_count": 60, "buffer_percent": 8, "max_count": 44, "min_count": 48, "name": "TwsxUkdI", "unlimited": true, "use_buffer_percent": true}, "vRlpI6UH": {"buffer_count": 6, "buffer_percent": 90, "max_count": 61, "min_count": 82, "name": "bitwzHIE", "unlimited": false, "use_buffer_percent": true}}, "regions": ["g7GE51XO", "lbUInRCX", "83tJUOL8"], "session_timeout": 61, "unlimited": true, "use_buffer_percent": true}, "OpMt1SI4": {"buffer_count": 16, "buffer_percent": 10, "configuration": "EGXlu29k", "enable_region_overrides": false, "extendable_session": true, "game_version": "keHy74J6", "max_count": 15, "min_count": 80, "name": "eu0KNRTJ", "region_overrides": {"EwYPk4Du": {"buffer_count": 97, "buffer_percent": 28, "max_count": 64, "min_count": 4, "name": "cVK7s1Y9", "unlimited": false, "use_buffer_percent": true}, "06AGbHyQ": {"buffer_count": 100, "buffer_percent": 51, "max_count": 93, "min_count": 67, "name": "WsR5ichk", "unlimited": true, "use_buffer_percent": true}, "lMzm5Yyi": {"buffer_count": 23, "buffer_percent": 13, "max_count": 88, "min_count": 49, "name": "3QE76lQX", "unlimited": true, "use_buffer_percent": true}}, "regions": ["ipsuzhz3", "Q8QL9DFX", "69e8uiR3"], "session_timeout": 35, "unlimited": false, "use_buffer_percent": true}}, "region_overrides": {"MT8Cp1JW": {"buffer_count": 17, "buffer_percent": 69, "max_count": 2, "min_count": 21, "name": "B71sstLF", "unlimited": true, "use_buffer_percent": false}, "2qWSSNiZ": {"buffer_count": 27, "buffer_percent": 50, "max_count": 23, "min_count": 36, "name": "PQJ5DFkS", "unlimited": false, "use_buffer_percent": false}, "KurHiRzF": {"buffer_count": 53, "buffer_percent": 11, "max_count": 40, "min_count": 12, "name": "vsklWONH", "unlimited": true, "use_buffer_percent": true}}, "regions": ["eZqlNPTg", "iLlBNrKS", "3Iqg4cGD"], "session_timeout": 41, "unlimited": false, "use_buffer_percent": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreateDeploymentClient \
    --deployment 'QhklHTHW' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 65 'CreateDeploymentClient' test.out

#- 66 DeleteDeploymentClient
$CLI_EXE \
    --sn dsmc \
    --op DeleteDeploymentClient \
    --deployment 'B9wJ3MVt' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 66 'DeleteDeploymentClient' test.out

#- 67 GetAllPodConfigClient
$CLI_EXE \
    --sn dsmc \
    --op GetAllPodConfigClient \
    --namespace $AB_NAMESPACE \
    --count '72' \
    --offset '38' \
    > test.out 2>&1
eval_tap $? 67 'GetAllPodConfigClient' test.out

#- 68 CreatePodConfigClient
# body param: body
echo '{"cpu_limit": 17, "mem_limit": 87, "params": "P11btdzL"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreatePodConfigClient \
    --name 'oxVYpuUR' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 68 'CreatePodConfigClient' test.out

#- 69 DeletePodConfigClient
$CLI_EXE \
    --sn dsmc \
    --op DeletePodConfigClient \
    --name 'XN9BfIBt' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 69 'DeletePodConfigClient' test.out

#- 70 ListImagesClient
$CLI_EXE \
    --sn dsmc \
    --op ListImagesClient \
    --namespace $AB_NAMESPACE \
    --count '76' \
    --offset '26' \
    --q 'L9IOVmYI' \
    --sortBy 'createdAt' \
    --sortDirection 'desc' \
    > test.out 2>&1
eval_tap $? 70 'ListImagesClient' test.out

#- 71 ImageLimitClient
$CLI_EXE \
    --sn dsmc \
    --op ImageLimitClient \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 71 'ImageLimitClient' test.out

#- 72 ImageDetailClient
$CLI_EXE \
    --sn dsmc \
    --op ImageDetailClient \
    --namespace $AB_NAMESPACE \
    --version 'm50K6Bqx' \
    > test.out 2>&1
eval_tap $? 72 'ImageDetailClient' test.out

#- 73 ListServerClient
$CLI_EXE \
    --sn dsmc \
    --op ListServerClient \
    --namespace $AB_NAMESPACE \
    --region 'VFEzJlbS' \
    --count '82' \
    --offset '74' \
    > test.out 2>&1
eval_tap $? 73 'ListServerClient' test.out

#- 74 CountServerDetailedClient
$CLI_EXE \
    --sn dsmc \
    --op CountServerDetailedClient \
    --namespace $AB_NAMESPACE \
    --region 'SJUDCINx' \
    > test.out 2>&1
eval_tap $? 74 'CountServerDetailedClient' test.out

#- 75 ServerHeartbeat
# body param: body
echo '{"podName": "MrtAQNdA"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op ServerHeartbeat \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 75 'ServerHeartbeat' test.out

#- 76 DeregisterLocalServer
# body param: body
echo '{"name": "eM23XEAk"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op DeregisterLocalServer \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 76 'DeregisterLocalServer' test.out

#- 77 RegisterLocalServer
# body param: body
echo '{"custom_attribute": "k0B5L75M", "ip": "jPvjq0nz", "name": "Z6Dcpxue", "port": 15}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op RegisterLocalServer \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 77 'RegisterLocalServer' test.out

#- 78 RegisterServer
# body param: body
echo '{"custom_attribute": "9SsmSbOZ", "pod_name": "rGHYc2E6"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op RegisterServer \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 78 'RegisterServer' test.out

#- 79 ShutdownServer
# body param: body
echo '{"kill_me": true, "pod_name": "OqqiuwEv"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op ShutdownServer \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 79 'ShutdownServer' test.out

#- 80 GetServerSessionTimeout
$CLI_EXE \
    --sn dsmc \
    --op GetServerSessionTimeout \
    --namespace $AB_NAMESPACE \
    --podName 'rzoevRY5' \
    > test.out 2>&1
eval_tap $? 80 'GetServerSessionTimeout' test.out

#- 81 GetServerSession
$CLI_EXE \
    --sn dsmc \
    --op GetServerSession \
    --namespace $AB_NAMESPACE \
    --podName 'hZaoOkAb' \
    > test.out 2>&1
eval_tap $? 81 'GetServerSession' test.out

#- 82 CreateSession
# body param: body
echo '{"client_version": "E1d5UNQy", "configuration": "LjrcjQ7k", "deployment": "lNeeIj0T", "game_mode": "bfW94llf", "matching_allies": [{"matching_parties": [{"party_attributes": {"FB6UzxN6": {}, "xfLjUU3x": {}, "2TDDR7bc": {}}, "party_id": "gpKCKRYE", "party_members": [{"user_id": "86SVF7P0"}, {"user_id": "t1LHhQwZ"}, {"user_id": "TrtjI1xe"}]}, {"party_attributes": {"pzYiLVw7": {}, "zO54OwsM": {}, "EUp4K9bT": {}}, "party_id": "aAjZAWE6", "party_members": [{"user_id": "mpmGDOHn"}, {"user_id": "BOblFlJ7"}, {"user_id": "GmYYicra"}]}, {"party_attributes": {"2pnBC2aI": {}, "kttikck2": {}, "Wf5mcfY1": {}}, "party_id": "ta7UKcIz", "party_members": [{"user_id": "COrAhzEq"}, {"user_id": "er9LVBok"}, {"user_id": "kZVL8s4n"}]}]}, {"matching_parties": [{"party_attributes": {"6lamGnZP": {}, "HDlxtX9I": {}, "8Jl5a18W": {}}, "party_id": "WR6x71AM", "party_members": [{"user_id": "QuWdOnz2"}, {"user_id": "d6UB5ZEi"}, {"user_id": "6q2tPHE2"}]}, {"party_attributes": {"MzUpPvNt": {}, "QeYGHkVx": {}, "Cl239Rw6": {}}, "party_id": "fcbRJniF", "party_members": [{"user_id": "IU0Ux5FZ"}, {"user_id": "o3GujfpG"}, {"user_id": "xOVzmnbz"}]}, {"party_attributes": {"yZpvXjSg": {}, "ahqHbRID": {}, "z89mqZ1J": {}}, "party_id": "58ctNuDj", "party_members": [{"user_id": "2sJrZc1x"}, {"user_id": "bdxQHaGx"}, {"user_id": "SHA7bXMG"}]}]}, {"matching_parties": [{"party_attributes": {"z67X0tTw": {}, "N8tuxoCZ": {}, "vTdbzfxJ": {}}, "party_id": "mRnket4Z", "party_members": [{"user_id": "pOSYcC59"}, {"user_id": "toDsT6RF"}, {"user_id": "VsqAP4ZK"}]}, {"party_attributes": {"hDC9cjky": {}, "UQvNm2C6": {}, "lWhHHfgI": {}}, "party_id": "6KlC6EyX", "party_members": [{"user_id": "I3YhtBJI"}, {"user_id": "B56zgscN"}, {"user_id": "1HnbcEsR"}]}, {"party_attributes": {"D8putBLa": {}, "11HO4k48": {}, "4CAbReUd": {}}, "party_id": "ePDodp89", "party_members": [{"user_id": "zBC1UFp1"}, {"user_id": "qelcdpou"}, {"user_id": "DzQJpddb"}]}]}], "namespace": "6bo55ALH", "notification_payload": {}, "pod_name": "UaqJYyXX", "region": "mzXEoA6G", "session_id": "albxfnJD"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreateSession \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 82 'CreateSession' test.out

#- 83 ClaimServer
# body param: body
echo '{"game_mode": "QXL5A3C6", "matching_allies": [{"matching_parties": [{"party_attributes": {"EN88Iz0G": {}, "qWC0pBSX": {}, "Ss6i3y7x": {}}, "party_id": "MtY1GSC6", "party_members": [{"user_id": "HKvR8SvA"}, {"user_id": "X9UFDgEf"}, {"user_id": "uhdSTiM3"}]}, {"party_attributes": {"44hxXTwq": {}, "FBOo6C0Q": {}, "sov3tKAv": {}}, "party_id": "S5mz8A2H", "party_members": [{"user_id": "fuq9yz8m"}, {"user_id": "xbEFKAED"}, {"user_id": "ZDM7qHx8"}]}, {"party_attributes": {"MuGBWnAa": {}, "l8WfCCY9": {}, "LBICzolO": {}}, "party_id": "qxYdGy4h", "party_members": [{"user_id": "Vdsdi0GH"}, {"user_id": "tjxZkv5T"}, {"user_id": "vxtNrXzK"}]}]}, {"matching_parties": [{"party_attributes": {"GzqD1RoV": {}, "e0B1fLfr": {}, "KtuDundZ": {}}, "party_id": "sxXEuOgU", "party_members": [{"user_id": "CNj0K9iT"}, {"user_id": "Wig9U3sX"}, {"user_id": "tm0T9MuS"}]}, {"party_attributes": {"lav70SOx": {}, "aCYPl0a8": {}, "FqDTEr6u": {}}, "party_id": "9b562Fiu", "party_members": [{"user_id": "PpGZOi4I"}, {"user_id": "RfIQ2nlC"}, {"user_id": "GkNdYVSH"}]}, {"party_attributes": {"uzUTxS1j": {}, "Isx1NqL8": {}, "fIwFVYXc": {}}, "party_id": "eT4N2Bdt", "party_members": [{"user_id": "wTMizVl1"}, {"user_id": "DGEiEaUO"}, {"user_id": "3O1kbHDa"}]}]}, {"matching_parties": [{"party_attributes": {"sxdFJiRR": {}, "jzeDeWrk": {}, "EIYkpGqG": {}}, "party_id": "lKuFzbDL", "party_members": [{"user_id": "Yh7NufFW"}, {"user_id": "ueKG3V1m"}, {"user_id": "AvrR9XEW"}]}, {"party_attributes": {"EZkD1H5P": {}, "aT5CZaLM": {}, "E4Vno3P5": {}}, "party_id": "AWxCuOrX", "party_members": [{"user_id": "4Ecm1xnP"}, {"user_id": "MvRcsWVR"}, {"user_id": "pEaAJDDc"}]}, {"party_attributes": {"ndUkxQVb": {}, "KkhM6AYI": {}, "moXAsJsH": {}}, "party_id": "oUNogiiN", "party_members": [{"user_id": "J9YdOyGA"}, {"user_id": "q8FZtOvG"}, {"user_id": "6NODNjbh"}]}]}], "namespace": "kwxjJden", "notification_payload": {}, "session_id": "WYAP0aKw"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op ClaimServer \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 83 'ClaimServer' test.out

#- 84 GetSession
$CLI_EXE \
    --sn dsmc \
    --op GetSession \
    --namespace $AB_NAMESPACE \
    --sessionID 'eqPvpg25' \
    > test.out 2>&1
eval_tap $? 84 'GetSession' test.out

#- 85 CancelSession
$CLI_EXE \
    --sn dsmc \
    --op CancelSession \
    --namespace $AB_NAMESPACE \
    --sessionID '4Ytypgk6' \
    > test.out 2>&1
eval_tap $? 85 'CancelSession' test.out

#- 86 GetDefaultProvider
$CLI_EXE \
    --sn dsmc \
    --op GetDefaultProvider \
    > test.out 2>&1
eval_tap $? 86 'GetDefaultProvider' test.out

#- 87 ListProviders
$CLI_EXE \
    --sn dsmc \
    --op ListProviders \
    > test.out 2>&1
eval_tap $? 87 'ListProviders' test.out

#- 88 ListProvidersByRegion
$CLI_EXE \
    --sn dsmc \
    --op ListProvidersByRegion \
    --region 'JvoQZ18A' \
    > test.out 2>&1
eval_tap $? 88 'ListProvidersByRegion' test.out

#- 89 PublicGetMessages
$CLI_EXE \
    --sn dsmc \
    --op PublicGetMessages \
    > test.out 2>&1
eval_tap $? 89 'PublicGetMessages' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE