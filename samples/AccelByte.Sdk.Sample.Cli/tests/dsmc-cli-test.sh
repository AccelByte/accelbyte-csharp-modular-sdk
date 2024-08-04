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
echo '{"artifactPath": "Pcf2416y", "coreDumpEnabled": false, "image": "feAujeV6", "imageReplicationsMap": {"Q1G8QNvw": {"failure_code": "Bm0XY6jr", "region": "BjaQXB3m", "status": "GDV3DHX6", "uri": "58X5FhJM"}, "cpXwh1Ay": {"failure_code": "3GvhczXp", "region": "JrdSHSSV", "status": "H3MhZyQs", "uri": "B1rG0rmv"}, "9PSlUFcv": {"failure_code": "XDWPw0ww", "region": "kAG6pKo1", "status": "b6qxXHMy", "uri": "WkrJQf8g"}}, "namespace": "Xulzpdiv", "patchVersion": "ftOST1xd", "persistent": false, "ulimitFileSize": 100, "version": "k9aEyKlt"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op UpdateImage \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 4 'UpdateImage' test.out

#- 5 CreateImage
# body param: body
echo '{"artifactPath": "r4YVHEkS", "coreDumpEnabled": false, "dockerPath": "79soBsbA", "image": "K8Z4YYNX", "imageSize": 86, "namespace": "jmOlpQmw", "persistent": true, "ulimitFileSize": 43, "version": "NYSltq6c"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreateImage \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 5 'CreateImage' test.out

#- 6 CreateImagePatch
# body param: body
echo '{"artifactPath": "VLTB6pGg", "coreDumpEnabled": true, "dockerPath": "kgGMdag8", "image": "FOuNhUn9", "imageSize": 18, "namespace": "jXWTO8Uy", "patchVersion": "55gjxL5f", "persistent": false, "ulimitFileSize": 46, "uploaderFlag": "pWFyAVIJ", "version": "3X7o9LX1"}' > $TEMP_JSON_INPUT
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
echo '{"auto_deletion": true, "ghost_worker": false, "manual_buffer_override": false, "zombie_worker": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op UpdateWorkerConfig \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 9 'UpdateWorkerConfig' test.out

#- 10 CreateWorkerConfig
# body param: body
echo '{"auto_deletion": false, "ghost_worker": false, "manual_buffer_override": false, "zombie_worker": true}' > $TEMP_JSON_INPUT
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
echo '{"claim_timeout": 43, "creation_timeout": 32, "default_version": "vFvvtRZW", "port": 0, "ports": {"gxpoiL0n": 19, "f9lNxxrZ": 50, "xsYwBt6q": 100}, "protocol": "RT9s67CJ", "providers": ["GarUHuwJ", "hLDsl8uO", "JXOYm5bl"], "session_timeout": 2, "unreachable_timeout": 65}' > $TEMP_JSON_INPUT
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
echo '{"claim_timeout": 16, "creation_timeout": 10, "default_version": "9w6soHHU", "port": 79, "protocol": "n4X68k6a", "providers": ["7Uu96naR", "w5wOifXV", "QeuIRgU1"], "session_timeout": 43, "unreachable_timeout": 69}' > $TEMP_JSON_INPUT
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
    --name 'D3LWYMyt' \
    --count '56' \
    --offset '25' \
    > test.out 2>&1
eval_tap $? 16 'GetAllDeployment' test.out

#- 17 GetDeployment
$CLI_EXE \
    --sn dsmc \
    --op GetDeployment \
    --deployment 'SduuDRqU' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 17 'GetDeployment' test.out

#- 18 CreateDeployment
# body param: body
echo '{"allow_version_override": false, "buffer_count": 69, "buffer_percent": 81, "configuration": "ikEr8fiC", "enable_region_overrides": false, "extendable_session": false, "game_version": "ar9qBkxI", "max_count": 26, "min_count": 57, "overrides": {"XJ0Vahnv": {"buffer_count": 87, "buffer_percent": 90, "configuration": "8xS766go", "enable_region_overrides": true, "extendable_session": false, "game_version": "DWHrtHHy", "max_count": 82, "min_count": 47, "name": "VUWBvR8i", "region_overrides": {"TGOmUByJ": {"buffer_count": 71, "buffer_percent": 31, "max_count": 93, "min_count": 64, "name": "1K4JN0f2", "unlimited": false, "use_buffer_percent": true}, "Id3tmRsd": {"buffer_count": 17, "buffer_percent": 7, "max_count": 4, "min_count": 73, "name": "3f47KF5V", "unlimited": true, "use_buffer_percent": false}, "RuTrFN2d": {"buffer_count": 51, "buffer_percent": 92, "max_count": 41, "min_count": 47, "name": "wWkXoh57", "unlimited": true, "use_buffer_percent": true}}, "regions": ["I1Hx384U", "zKJTKH1z", "zCICMHqG"], "session_timeout": 28, "unlimited": true, "use_buffer_percent": false}, "fa11fFCX": {"buffer_count": 49, "buffer_percent": 51, "configuration": "DM1KnsG0", "enable_region_overrides": false, "extendable_session": false, "game_version": "I1kxFlgE", "max_count": 35, "min_count": 13, "name": "dxqCUFQd", "region_overrides": {"0dYnqy7T": {"buffer_count": 23, "buffer_percent": 29, "max_count": 85, "min_count": 53, "name": "7VYhX8e6", "unlimited": false, "use_buffer_percent": true}, "JPcHHASC": {"buffer_count": 44, "buffer_percent": 7, "max_count": 32, "min_count": 57, "name": "ZfXEJDIG", "unlimited": true, "use_buffer_percent": true}, "zM0yhu3d": {"buffer_count": 34, "buffer_percent": 72, "max_count": 8, "min_count": 43, "name": "OMwUfx7s", "unlimited": false, "use_buffer_percent": false}}, "regions": ["NCIyP6u2", "IbZu6Z9p", "74ZY70lW"], "session_timeout": 42, "unlimited": false, "use_buffer_percent": true}, "Knjeres5": {"buffer_count": 85, "buffer_percent": 46, "configuration": "dreP4wHx", "enable_region_overrides": false, "extendable_session": false, "game_version": "vOzGf3kS", "max_count": 3, "min_count": 41, "name": "M9kDXUKE", "region_overrides": {"PRoq6I6V": {"buffer_count": 3, "buffer_percent": 29, "max_count": 3, "min_count": 83, "name": "SImC0mup", "unlimited": false, "use_buffer_percent": true}, "FfhnzJLD": {"buffer_count": 9, "buffer_percent": 70, "max_count": 53, "min_count": 41, "name": "QRbM2YjG", "unlimited": false, "use_buffer_percent": true}, "IlGbojdl": {"buffer_count": 15, "buffer_percent": 69, "max_count": 80, "min_count": 80, "name": "qvq9CJfg", "unlimited": true, "use_buffer_percent": false}}, "regions": ["ej2MqbTT", "Smb0kDff", "yR4vx7eU"], "session_timeout": 0, "unlimited": true, "use_buffer_percent": false}}, "region_overrides": {"LfgyxEQg": {"buffer_count": 51, "buffer_percent": 94, "max_count": 27, "min_count": 23, "name": "IT48Qotl", "unlimited": true, "use_buffer_percent": true}, "S6SyigXh": {"buffer_count": 72, "buffer_percent": 61, "max_count": 58, "min_count": 49, "name": "W56zg4RY", "unlimited": true, "use_buffer_percent": true}, "ZGg9B5Ap": {"buffer_count": 43, "buffer_percent": 46, "max_count": 58, "min_count": 16, "name": "JMS0yajl", "unlimited": false, "use_buffer_percent": true}}, "regions": ["wEa8sc8l", "S4gBCids", "fZAW3iQz"], "session_timeout": 22, "unlimited": false, "use_buffer_percent": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreateDeployment \
    --deployment 'nkcwkKWk' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 18 'CreateDeployment' test.out

#- 19 DeleteDeployment
$CLI_EXE \
    --sn dsmc \
    --op DeleteDeployment \
    --deployment 'fFB927tD' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 19 'DeleteDeployment' test.out

#- 20 UpdateDeployment
# body param: body
echo '{"allow_version_override": true, "buffer_count": 48, "buffer_percent": 14, "configuration": "W8yIGjt9", "enable_region_overrides": false, "extendable_session": false, "game_version": "MpMilIQj", "max_count": 10, "min_count": 73, "regions": ["ZO9Mm3xx", "3zCaknex", "9dVnK0KQ"], "session_timeout": 83, "unlimited": true, "use_buffer_percent": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op UpdateDeployment \
    --deployment 'FTLfDZOd' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 20 'UpdateDeployment' test.out

#- 21 CreateRootRegionOverride
# body param: body
echo '{"buffer_count": 90, "buffer_percent": 65, "max_count": 24, "min_count": 61, "unlimited": true, "use_buffer_percent": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreateRootRegionOverride \
    --deployment 'EoadeD6u' \
    --namespace $AB_NAMESPACE \
    --region 'FxwhHphn' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 21 'CreateRootRegionOverride' test.out

#- 22 DeleteRootRegionOverride
$CLI_EXE \
    --sn dsmc \
    --op DeleteRootRegionOverride \
    --deployment 'VOJV3JEB' \
    --namespace $AB_NAMESPACE \
    --region '3zc0KZNx' \
    > test.out 2>&1
eval_tap $? 22 'DeleteRootRegionOverride' test.out

#- 23 UpdateRootRegionOverride
# body param: body
echo '{"buffer_count": 13, "buffer_percent": 62, "max_count": 53, "min_count": 17, "unlimited": true, "use_buffer_percent": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op UpdateRootRegionOverride \
    --deployment 'ZApqWPdO' \
    --namespace $AB_NAMESPACE \
    --region 'lmYCP2Oq' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 23 'UpdateRootRegionOverride' test.out

#- 24 CreateDeploymentOverride
# body param: body
echo '{"buffer_count": 16, "buffer_percent": 14, "configuration": "EsXWKhhm", "enable_region_overrides": true, "extendable_session": true, "game_version": "TMKZSYe0", "max_count": 73, "min_count": 36, "region_overrides": {"PS8wTNzQ": {"buffer_count": 59, "buffer_percent": 73, "max_count": 94, "min_count": 71, "name": "qGBsq8zK", "unlimited": true, "use_buffer_percent": true}, "tYvvRhHv": {"buffer_count": 93, "buffer_percent": 47, "max_count": 50, "min_count": 100, "name": "X8gebL7M", "unlimited": true, "use_buffer_percent": false}, "mrQVlhrx": {"buffer_count": 70, "buffer_percent": 24, "max_count": 72, "min_count": 43, "name": "xDkjbFsw", "unlimited": false, "use_buffer_percent": true}}, "regions": ["DdtMAk9u", "fujtXB3c", "aelD054V"], "session_timeout": 78, "unlimited": false, "use_buffer_percent": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreateDeploymentOverride \
    --deployment 'a72zx1ka' \
    --namespace $AB_NAMESPACE \
    --version 'MLZgNWpj' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 24 'CreateDeploymentOverride' test.out

#- 25 DeleteDeploymentOverride
$CLI_EXE \
    --sn dsmc \
    --op DeleteDeploymentOverride \
    --deployment '0MEbJv6y' \
    --namespace $AB_NAMESPACE \
    --version 'PryQmUeW' \
    > test.out 2>&1
eval_tap $? 25 'DeleteDeploymentOverride' test.out

#- 26 UpdateDeploymentOverride
# body param: body
echo '{"buffer_count": 1, "buffer_percent": 19, "configuration": "GpeQrmFo", "enable_region_overrides": true, "game_version": "ZswrDlky", "max_count": 81, "min_count": 51, "regions": ["O8vkJsBS", "OMR0aAVE", "QYyLWnK3"], "session_timeout": 18, "unlimited": true, "use_buffer_percent": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op UpdateDeploymentOverride \
    --deployment '0GBCE45M' \
    --namespace $AB_NAMESPACE \
    --version 'HvRU2pIQ' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 26 'UpdateDeploymentOverride' test.out

#- 27 CreateOverrideRegionOverride
# body param: body
echo '{"buffer_count": 84, "buffer_percent": 74, "max_count": 36, "min_count": 0, "unlimited": false, "use_buffer_percent": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreateOverrideRegionOverride \
    --deployment 'NQDduuLE' \
    --namespace $AB_NAMESPACE \
    --region 'dS5XJEYE' \
    --version 'nEM9CuVQ' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 27 'CreateOverrideRegionOverride' test.out

#- 28 DeleteOverrideRegionOverride
$CLI_EXE \
    --sn dsmc \
    --op DeleteOverrideRegionOverride \
    --deployment 'St02CE0n' \
    --namespace $AB_NAMESPACE \
    --region 'BVR1SzdJ' \
    --version 'x7SxAWnR' \
    > test.out 2>&1
eval_tap $? 28 'DeleteOverrideRegionOverride' test.out

#- 29 UpdateOverrideRegionOverride
# body param: body
echo '{"buffer_count": 0, "buffer_percent": 54, "max_count": 27, "min_count": 99, "unlimited": false, "use_buffer_percent": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op UpdateOverrideRegionOverride \
    --deployment 'KHhor1oe' \
    --namespace $AB_NAMESPACE \
    --region 'AohzWiBx' \
    --version 'z5GuOZsx' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 29 'UpdateOverrideRegionOverride' test.out

#- 30 DeleteCreatingServerCountQueue
$CLI_EXE \
    --sn dsmc \
    --op DeleteCreatingServerCountQueue \
    --deployment '0RdW7Jyx' \
    --namespace $AB_NAMESPACE \
    --version 'rUrODvdV' \
    > test.out 2>&1
eval_tap $? 30 'DeleteCreatingServerCountQueue' test.out

#- 31 GetAllPodConfig
$CLI_EXE \
    --sn dsmc \
    --op GetAllPodConfig \
    --namespace $AB_NAMESPACE \
    --count '37' \
    --offset '5' \
    > test.out 2>&1
eval_tap $? 31 'GetAllPodConfig' test.out

#- 32 GetPodConfig
$CLI_EXE \
    --sn dsmc \
    --op GetPodConfig \
    --name 'mtQPGy6b' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 32 'GetPodConfig' test.out

#- 33 CreatePodConfig
# body param: body
echo '{"cpu_limit": 94, "mem_limit": 91, "params": "lJsANJ4U"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreatePodConfig \
    --name 'oGM0ohwd' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 33 'CreatePodConfig' test.out

#- 34 DeletePodConfig
$CLI_EXE \
    --sn dsmc \
    --op DeletePodConfig \
    --name 'zCQJruFO' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 34 'DeletePodConfig' test.out

#- 35 UpdatePodConfig
# body param: body
echo '{"cpu_limit": 83, "mem_limit": 31, "name": "IeBeuVFc", "params": "zMusT0Ah"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op UpdatePodConfig \
    --name 'GfGtr2ra' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 35 'UpdatePodConfig' test.out

#- 36 AddPort
# body param: body
echo '{"port": 34}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op AddPort \
    --name 'pGmQIZ42' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 36 'AddPort' test.out

#- 37 DeletePort
$CLI_EXE \
    --sn dsmc \
    --op DeletePort \
    --name 'dKXnkuc1' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 37 'DeletePort' test.out

#- 38 UpdatePort
# body param: body
echo '{"name": "w4IsfQoD", "port": 96}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op UpdatePort \
    --name 'nU3jXr2u' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 38 'UpdatePort' test.out

#- 39 ListImages
$CLI_EXE \
    --sn dsmc \
    --op ListImages \
    --namespace $AB_NAMESPACE \
    --q 'T5W09sra' \
    --sortBy 'updatedAt' \
    --sortDirection 'asc' \
    --count '29' \
    --offset '76' \
    > test.out 2>&1
eval_tap $? 39 'ListImages' test.out

#- 40 DeleteImage
$CLI_EXE \
    --sn dsmc \
    --op DeleteImage \
    --namespace $AB_NAMESPACE \
    --imageURI 'ERhmO9NH' \
    --version 'pyDbTvXH' \
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
    --imageURI 'Txl3RfTY' \
    --version 'DQkRRbOm' \
    --versionPatch 'Mc8kjE7s' \
    > test.out 2>&1
eval_tap $? 42 'DeleteImagePatch' test.out

#- 43 GetImageDetail
$CLI_EXE \
    --sn dsmc \
    --op GetImageDetail \
    --namespace $AB_NAMESPACE \
    --version 'uMXTBQTV' \
    > test.out 2>&1
eval_tap $? 43 'GetImageDetail' test.out

#- 44 GetImagePatches
$CLI_EXE \
    --sn dsmc \
    --op GetImagePatches \
    --namespace $AB_NAMESPACE \
    --version 'vPfE4K9S' \
    > test.out 2>&1
eval_tap $? 44 'GetImagePatches' test.out

#- 45 GetImagePatchDetail
$CLI_EXE \
    --sn dsmc \
    --op GetImagePatchDetail \
    --namespace $AB_NAMESPACE \
    --version 'giCzjoMx' \
    --versionPatch 'YDAoUSa5' \
    > test.out 2>&1
eval_tap $? 45 'GetImagePatchDetail' test.out

#- 46 AddBuffer
# body param: body
echo '{"AllocCount": 92, "DeploymentName": "dNTCPdlL", "JobCount": 75, "JobPriority": 25, "OverrideVersion": "5EeMaTQ1", "Region": "i6y6NGvH"}' > $TEMP_JSON_INPUT
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
    --region 'rxDO4x4g' \
    --count '93' \
    --offset '18' \
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
    --region 'QUF4lqGo' \
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
    --name 'SpgU50qx' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 52 'DeleteLocalServer' test.out

#- 53 GetServer
$CLI_EXE \
    --sn dsmc \
    --op GetServer \
    --namespace $AB_NAMESPACE \
    --podName 'NxKLD16e' \
    > test.out 2>&1
eval_tap $? 53 'GetServer' test.out

#- 54 DeleteServer
$CLI_EXE \
    --sn dsmc \
    --op DeleteServer \
    --namespace $AB_NAMESPACE \
    --podName 'fYg7drzg' \
    > test.out 2>&1
eval_tap $? 54 'DeleteServer' test.out

#- 55 ListSession
$CLI_EXE \
    --sn dsmc \
    --op ListSession \
    --namespace $AB_NAMESPACE \
    --region 'Vqg91jku' \
    --withServer 'false' \
    --count '92' \
    --offset '8' \
    > test.out 2>&1
eval_tap $? 55 'ListSession' test.out

#- 56 CountSession
$CLI_EXE \
    --sn dsmc \
    --op CountSession \
    --namespace $AB_NAMESPACE \
    --region 'Ru3aJhrs' \
    > test.out 2>&1
eval_tap $? 56 'CountSession' test.out

#- 57 DeleteSession
$CLI_EXE \
    --sn dsmc \
    --op DeleteSession \
    --namespace $AB_NAMESPACE \
    --sessionID 'xkokvEC8' \
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
echo '{"JobCount": 5, "Region": "ZgtUHL0d", "TimeoutSecond": 43, "ZombieCount": 79}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op RunZombieCleanerRequestHandler \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 59 'RunZombieCleanerRequestHandler' test.out

#- 60 CreateRepository
# body param: body
echo '{"namespace": "R2hLn0su", "repository": "DajwNGur"}' > $TEMP_JSON_INPUT
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
    --name '8O2NPBlm' \
    --count '95' \
    --offset '71' \
    > test.out 2>&1
eval_tap $? 63 'GetAllDeploymentClient' test.out

#- 64 GetDeploymentClient
$CLI_EXE \
    --sn dsmc \
    --op GetDeploymentClient \
    --deployment 'bCJvPogU' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 64 'GetDeploymentClient' test.out

#- 65 CreateDeploymentClient
# body param: body
echo '{"allow_version_override": false, "buffer_count": 8, "buffer_percent": 14, "configuration": "yrGmMZTv", "enable_region_overrides": false, "extendable_session": false, "game_version": "XjQkyn1n", "max_count": 19, "min_count": 91, "overrides": {"J7NFPWwf": {"buffer_count": 28, "buffer_percent": 74, "configuration": "ue8H4T3n", "enable_region_overrides": true, "extendable_session": false, "game_version": "wWHY1Zf1", "max_count": 36, "min_count": 87, "name": "fc4PMIPA", "region_overrides": {"1uMpFK7w": {"buffer_count": 45, "buffer_percent": 79, "max_count": 11, "min_count": 79, "name": "njKCvE7L", "unlimited": true, "use_buffer_percent": false}, "xBS7XMm8": {"buffer_count": 28, "buffer_percent": 20, "max_count": 41, "min_count": 28, "name": "af24fTVF", "unlimited": false, "use_buffer_percent": false}, "xX7jMjEI": {"buffer_count": 19, "buffer_percent": 53, "max_count": 17, "min_count": 51, "name": "e8RZLiUN", "unlimited": false, "use_buffer_percent": true}}, "regions": ["TlyNpcFO", "dHMGmZ5T", "08xJj4dI"], "session_timeout": 34, "unlimited": true, "use_buffer_percent": false}, "y6Kw8VRl": {"buffer_count": 29, "buffer_percent": 40, "configuration": "aIMHlpgw", "enable_region_overrides": false, "extendable_session": true, "game_version": "jjGODH5P", "max_count": 49, "min_count": 55, "name": "fxnt0LEJ", "region_overrides": {"gQnwgE1F": {"buffer_count": 68, "buffer_percent": 45, "max_count": 65, "min_count": 97, "name": "agwdK93Y", "unlimited": true, "use_buffer_percent": true}, "UGMyq8cJ": {"buffer_count": 81, "buffer_percent": 7, "max_count": 21, "min_count": 94, "name": "mRsyJTrP", "unlimited": false, "use_buffer_percent": true}, "bgUJ5zMd": {"buffer_count": 54, "buffer_percent": 67, "max_count": 14, "min_count": 66, "name": "ZjZAVTyC", "unlimited": true, "use_buffer_percent": true}}, "regions": ["JarWJHzx", "B4qvDFI4", "uO8Le5Eb"], "session_timeout": 25, "unlimited": false, "use_buffer_percent": true}, "zrHU7zqo": {"buffer_count": 29, "buffer_percent": 1, "configuration": "51tvJH0P", "enable_region_overrides": true, "extendable_session": false, "game_version": "xpKH8vtD", "max_count": 83, "min_count": 78, "name": "uuz1v99h", "region_overrides": {"EIpK7Hnj": {"buffer_count": 81, "buffer_percent": 48, "max_count": 30, "min_count": 10, "name": "VgCgL7uU", "unlimited": false, "use_buffer_percent": false}, "Yq4NKIVQ": {"buffer_count": 10, "buffer_percent": 34, "max_count": 20, "min_count": 90, "name": "CHJxq5rL", "unlimited": false, "use_buffer_percent": true}, "yHsaYLlA": {"buffer_count": 65, "buffer_percent": 77, "max_count": 23, "min_count": 64, "name": "hH09FFcw", "unlimited": false, "use_buffer_percent": true}}, "regions": ["VWrUSPxE", "RzgAeOWS", "XXYaZnc0"], "session_timeout": 5, "unlimited": true, "use_buffer_percent": true}}, "region_overrides": {"i7MkT5Kv": {"buffer_count": 37, "buffer_percent": 16, "max_count": 88, "min_count": 73, "name": "Hxw5ypa1", "unlimited": true, "use_buffer_percent": true}, "n77uENr5": {"buffer_count": 91, "buffer_percent": 74, "max_count": 92, "min_count": 100, "name": "8Jeh9t5u", "unlimited": false, "use_buffer_percent": true}, "to1o8Zuz": {"buffer_count": 91, "buffer_percent": 10, "max_count": 44, "min_count": 64, "name": "CEqNYZjT", "unlimited": false, "use_buffer_percent": false}}, "regions": ["xil8C5hl", "zxRrYs25", "S5W9ECr6"], "session_timeout": 91, "unlimited": true, "use_buffer_percent": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreateDeploymentClient \
    --deployment 'fsTzDpu5' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 65 'CreateDeploymentClient' test.out

#- 66 DeleteDeploymentClient
$CLI_EXE \
    --sn dsmc \
    --op DeleteDeploymentClient \
    --deployment 'AGYG0nMC' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 66 'DeleteDeploymentClient' test.out

#- 67 GetAllPodConfigClient
$CLI_EXE \
    --sn dsmc \
    --op GetAllPodConfigClient \
    --namespace $AB_NAMESPACE \
    --count '76' \
    --offset '65' \
    > test.out 2>&1
eval_tap $? 67 'GetAllPodConfigClient' test.out

#- 68 CreatePodConfigClient
# body param: body
echo '{"cpu_limit": 71, "mem_limit": 54, "params": "eV5AD0xs"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreatePodConfigClient \
    --name 'MVRlhOHU' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 68 'CreatePodConfigClient' test.out

#- 69 DeletePodConfigClient
$CLI_EXE \
    --sn dsmc \
    --op DeletePodConfigClient \
    --name 'kylczPUv' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 69 'DeletePodConfigClient' test.out

#- 70 ListImagesClient
$CLI_EXE \
    --sn dsmc \
    --op ListImagesClient \
    --namespace $AB_NAMESPACE \
    --count '72' \
    --offset '4' \
    --q 'JTtFmPxK' \
    --sortBy 'version' \
    --sortDirection 'asc' \
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
    --version '7LnuC5wN' \
    > test.out 2>&1
eval_tap $? 72 'ImageDetailClient' test.out

#- 73 ListServerClient
$CLI_EXE \
    --sn dsmc \
    --op ListServerClient \
    --namespace $AB_NAMESPACE \
    --region 'rfT36sBK' \
    --count '14' \
    --offset '51' \
    > test.out 2>&1
eval_tap $? 73 'ListServerClient' test.out

#- 74 CountServerDetailedClient
$CLI_EXE \
    --sn dsmc \
    --op CountServerDetailedClient \
    --namespace $AB_NAMESPACE \
    --region 'joYTS2y2' \
    > test.out 2>&1
eval_tap $? 74 'CountServerDetailedClient' test.out

#- 75 ServerHeartbeat
# body param: body
echo '{"podName": "1sR5wi4T"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op ServerHeartbeat \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 75 'ServerHeartbeat' test.out

#- 76 DeregisterLocalServer
# body param: body
echo '{"name": "VYkYfSd7"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op DeregisterLocalServer \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 76 'DeregisterLocalServer' test.out

#- 77 RegisterLocalServer
# body param: body
echo '{"custom_attribute": "tT81xNzW", "ip": "jSnOU8uo", "name": "HHO17Nts", "port": 63}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op RegisterLocalServer \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 77 'RegisterLocalServer' test.out

#- 78 RegisterServer
# body param: body
echo '{"custom_attribute": "k34zxi5w", "pod_name": "pgbLKIpA"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op RegisterServer \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 78 'RegisterServer' test.out

#- 79 ShutdownServer
# body param: body
echo '{"kill_me": false, "pod_name": "5jDiLsry"}' > $TEMP_JSON_INPUT
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
    --podName 'GU1rUWYS' \
    > test.out 2>&1
eval_tap $? 80 'GetServerSessionTimeout' test.out

#- 81 GetServerSession
$CLI_EXE \
    --sn dsmc \
    --op GetServerSession \
    --namespace $AB_NAMESPACE \
    --podName '9Fr2SWJg' \
    > test.out 2>&1
eval_tap $? 81 'GetServerSession' test.out

#- 82 CreateSession
# body param: body
echo '{"client_version": "p65cM9AU", "configuration": "s5102q4W", "deployment": "Z7yhwZOI", "game_mode": "zafBC02S", "matching_allies": [{"matching_parties": [{"party_attributes": {"WPGhlCqW": {}, "54cJTQGJ": {}, "V4oDPnlr": {}}, "party_id": "XEzJRxa4", "party_members": [{"user_id": "oYiB8FIW"}, {"user_id": "PyR2n55i"}, {"user_id": "yGCxLqTy"}]}, {"party_attributes": {"1qFq3pPR": {}, "C1z0Hmmb": {}, "pyikysUF": {}}, "party_id": "iNR3LFqF", "party_members": [{"user_id": "nnuHIr8k"}, {"user_id": "yKDhNQNq"}, {"user_id": "1A7dUJAR"}]}, {"party_attributes": {"1CmqzOlz": {}, "LWtd7UUt": {}, "rCjE3bel": {}}, "party_id": "Vwoa8m73", "party_members": [{"user_id": "RdDuQXp3"}, {"user_id": "d442SKW8"}, {"user_id": "MMPoQeIY"}]}]}, {"matching_parties": [{"party_attributes": {"eNy3rdnC": {}, "ee8EKt3h": {}, "YQsQ2SOw": {}}, "party_id": "lKFWQ2Pl", "party_members": [{"user_id": "cVqgNTrL"}, {"user_id": "woeZhGGg"}, {"user_id": "2eSzBvsf"}]}, {"party_attributes": {"qUgUzFgv": {}, "qXCXe5xy": {}, "NkBZq2a7": {}}, "party_id": "F60ugnLp", "party_members": [{"user_id": "M72PI3Uk"}, {"user_id": "Vxizlo3S"}, {"user_id": "2SMkOv2i"}]}, {"party_attributes": {"PgNHBEJi": {}, "WGvDIN5H": {}, "O7OWhgSD": {}}, "party_id": "GG9KgSr6", "party_members": [{"user_id": "dn1nB8Gv"}, {"user_id": "dRV26gpx"}, {"user_id": "up0I92Gp"}]}]}, {"matching_parties": [{"party_attributes": {"EqqpNLAx": {}, "tq9vN1Fm": {}, "CazwBWb1": {}}, "party_id": "EzCrZ6TE", "party_members": [{"user_id": "ASN9IQHp"}, {"user_id": "oB4SF3He"}, {"user_id": "sAFbmm4v"}]}, {"party_attributes": {"fN4A1srG": {}, "D7tFjhHX": {}, "TXPT098p": {}}, "party_id": "dtsXBdvq", "party_members": [{"user_id": "niKvGDlh"}, {"user_id": "Z1pMqt6U"}, {"user_id": "APJoxHWE"}]}, {"party_attributes": {"pmjGhkdZ": {}, "PDZBlfko": {}, "8FFzizFL": {}}, "party_id": "BPRuIjWT", "party_members": [{"user_id": "DKY0kcFU"}, {"user_id": "jCF7Y5Ht"}, {"user_id": "Leg0p0Tw"}]}]}], "namespace": "lrHUqRau", "notification_payload": {}, "pod_name": "csv69Rz1", "region": "VaBwIALl", "session_id": "RjsQrZGS"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreateSession \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 82 'CreateSession' test.out

#- 83 ClaimServer
# body param: body
echo '{"game_mode": "a9QiWbcQ", "matching_allies": [{"matching_parties": [{"party_attributes": {"OksiudYL": {}, "sddK2GHA": {}, "Ur1fsnvv": {}}, "party_id": "libAP9I8", "party_members": [{"user_id": "1qxkAbGm"}, {"user_id": "Q7laIkmB"}, {"user_id": "ZcJDUsKW"}]}, {"party_attributes": {"wXBNQ2r9": {}, "zfFefHqi": {}, "WQE7tDC3": {}}, "party_id": "ANSLJS3n", "party_members": [{"user_id": "eRZyskey"}, {"user_id": "fiGo42E7"}, {"user_id": "MCxIKM59"}]}, {"party_attributes": {"jeGX4311": {}, "oAg1dQni": {}, "JFkaX12B": {}}, "party_id": "6LvobHWX", "party_members": [{"user_id": "QMuGjO1N"}, {"user_id": "J0QngqKY"}, {"user_id": "IJG0iXzQ"}]}]}, {"matching_parties": [{"party_attributes": {"4EU9tgT3": {}, "jhuuqkmw": {}, "dEzxzGJZ": {}}, "party_id": "9UkBgJWO", "party_members": [{"user_id": "uA3HC5vv"}, {"user_id": "TrI9EE37"}, {"user_id": "c9wintMM"}]}, {"party_attributes": {"u0em2XWM": {}, "wetopyYW": {}, "mlIbJjue": {}}, "party_id": "7ObOjlC5", "party_members": [{"user_id": "7zi5kRxf"}, {"user_id": "yTGVa1sE"}, {"user_id": "hePSo0ZM"}]}, {"party_attributes": {"8ce1Xiak": {}, "XfarhmIF": {}, "IGb8ebZ8": {}}, "party_id": "vYDCKjK1", "party_members": [{"user_id": "BOk05rl5"}, {"user_id": "zQHWGLiD"}, {"user_id": "D5YzmhT8"}]}]}, {"matching_parties": [{"party_attributes": {"0TIiASE1": {}, "VdMRyG0C": {}, "jIzOGhOX": {}}, "party_id": "UlnPsFL1", "party_members": [{"user_id": "EVwLYBTQ"}, {"user_id": "fXMZ9Oy0"}, {"user_id": "WG6pl8lK"}]}, {"party_attributes": {"h8d5vdom": {}, "0sw9Nsln": {}, "1TQ1d48t": {}}, "party_id": "2r3JNAbo", "party_members": [{"user_id": "Fa0hZRUP"}, {"user_id": "P3cCmTPs"}, {"user_id": "ArqoIseK"}]}, {"party_attributes": {"1kEaBdyT": {}, "3KIfcHvL": {}, "BjsZSiln": {}}, "party_id": "34AjOgDT", "party_members": [{"user_id": "QKuOoFOd"}, {"user_id": "XPx7vZHq"}, {"user_id": "snkdu7lD"}]}]}], "namespace": "bke3P0oP", "notification_payload": {}, "session_id": "E5jzGN6R"}' > $TEMP_JSON_INPUT
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
    --sessionID 'LZrmjYfu' \
    > test.out 2>&1
eval_tap $? 84 'GetSession' test.out

#- 85 CancelSession
$CLI_EXE \
    --sn dsmc \
    --op CancelSession \
    --namespace $AB_NAMESPACE \
    --sessionID 'HlIOvpXo' \
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
    --region '43tSNDbq' \
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