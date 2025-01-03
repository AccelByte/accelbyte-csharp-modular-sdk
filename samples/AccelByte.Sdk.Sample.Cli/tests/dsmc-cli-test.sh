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
echo '{"artifactPath": "gvl81QcG", "coreDumpEnabled": true, "image": "VN0B3khO", "imageReplicationsMap": {"EqPzhaA5": {"failure_code": "ELBTPXvL", "region": "ODzKVqJW", "status": "d4AACDki", "uri": "XwnFt589"}, "dSy3aiSs": {"failure_code": "EorfdYnp", "region": "GubP1JG4", "status": "an69NDnE", "uri": "8bdt1kDP"}, "mCHaRJze": {"failure_code": "o63bzJ8x", "region": "CXB1cqfT", "status": "GzNDUUqA", "uri": "PfyRRACP"}}, "namespace": "U06N8rcM", "patchVersion": "EYny7HA5", "persistent": true, "ulimitFileSize": 44, "version": "riHD8gRn"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op UpdateImage \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 4 'UpdateImage' test.out

#- 5 CreateImage
# body param: body
echo '{"artifactPath": "YCfs3Wqq", "coreDumpEnabled": true, "dockerPath": "HzhIQtoX", "image": "wN4VYPhO", "imageSize": 28, "namespace": "HZl6ri3v", "persistent": false, "ulimitFileSize": 14, "version": "g6kzrqKr"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreateImage \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 5 'CreateImage' test.out

#- 6 CreateImagePatch
# body param: body
echo '{"artifactPath": "K6VRJhZU", "coreDumpEnabled": true, "dockerPath": "7csAGVmI", "image": "IeO6lKPR", "imageSize": 95, "namespace": "iotcxiYE", "patchVersion": "QTLmyNh0", "persistent": true, "ulimitFileSize": 17, "uploaderFlag": "jtJl40A9", "version": "Mmg59dcT"}' > $TEMP_JSON_INPUT
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
echo '{"auto_deletion": false, "ghost_worker": true, "manual_buffer_override": false, "zombie_worker": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op UpdateWorkerConfig \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 9 'UpdateWorkerConfig' test.out

#- 10 CreateWorkerConfig
# body param: body
echo '{"auto_deletion": false, "ghost_worker": true, "manual_buffer_override": true, "zombie_worker": false}' > $TEMP_JSON_INPUT
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
echo '{"claim_timeout": 27, "creation_timeout": 22, "default_version": "7KomDith", "port": 12, "ports": {"iFXPI3Wd": 23, "qKKiFqGY": 100, "DMZwnfHb": 57}, "protocol": "vcafwUCt", "providers": ["nLfNjKb2", "6RLI1Ni7", "Ft9ziNgA"], "session_timeout": 3, "unreachable_timeout": 3}' > $TEMP_JSON_INPUT
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
echo '{"claim_timeout": 27, "creation_timeout": 64, "default_version": "f0zF7lKd", "port": 71, "protocol": "PvgcI9jX", "providers": ["O4IOZC5A", "Ze1mFoZb", "e8Ge63SW"], "session_timeout": 81, "unreachable_timeout": 82}' > $TEMP_JSON_INPUT
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
    --name 's27NHHwB' \
    --count '93' \
    --offset '15' \
    > test.out 2>&1
eval_tap $? 16 'GetAllDeployment' test.out

#- 17 GetDeployment
$CLI_EXE \
    --sn dsmc \
    --op GetDeployment \
    --deployment '6oStiRdI' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 17 'GetDeployment' test.out

#- 18 CreateDeployment
# body param: body
echo '{"allow_version_override": false, "buffer_count": 54, "buffer_percent": 48, "configuration": "uaUB2T6a", "enable_region_overrides": false, "extendable_session": false, "game_version": "l76SzeNr", "max_count": 20, "min_count": 55, "overrides": {"m2F88OrD": {"buffer_count": 34, "buffer_percent": 41, "configuration": "aY2U6Xgr", "enable_region_overrides": true, "extendable_session": true, "game_version": "3Gjun0jE", "max_count": 2, "min_count": 5, "name": "mz3yJx4l", "region_overrides": {"C887EU50": {"buffer_count": 53, "buffer_percent": 55, "max_count": 51, "min_count": 17, "name": "pF4o6PrR", "unlimited": false, "use_buffer_percent": false}, "O3jUzmoL": {"buffer_count": 16, "buffer_percent": 46, "max_count": 78, "min_count": 35, "name": "0VoD4mHW", "unlimited": false, "use_buffer_percent": false}, "Eg7BQd3l": {"buffer_count": 97, "buffer_percent": 6, "max_count": 15, "min_count": 5, "name": "4RJw5nJX", "unlimited": true, "use_buffer_percent": true}}, "regions": ["HzkKhuuo", "PktxrZrQ", "BuSSAP4n"], "session_timeout": 2, "unlimited": false, "use_buffer_percent": true}, "akHFKNjK": {"buffer_count": 53, "buffer_percent": 18, "configuration": "I2Yc7XdK", "enable_region_overrides": false, "extendable_session": false, "game_version": "0TTolFhT", "max_count": 90, "min_count": 68, "name": "945MW3Gb", "region_overrides": {"cXMJq6jy": {"buffer_count": 34, "buffer_percent": 88, "max_count": 22, "min_count": 2, "name": "DBsAnLBq", "unlimited": false, "use_buffer_percent": false}, "lhTJ1QjP": {"buffer_count": 40, "buffer_percent": 10, "max_count": 70, "min_count": 61, "name": "dGt7SFYs", "unlimited": false, "use_buffer_percent": true}, "lXxw3HFz": {"buffer_count": 75, "buffer_percent": 86, "max_count": 5, "min_count": 43, "name": "gr5C5fFX", "unlimited": false, "use_buffer_percent": true}}, "regions": ["gXvWA410", "TQlEpBZ0", "yA0j434d"], "session_timeout": 43, "unlimited": false, "use_buffer_percent": false}, "ibIOqMY9": {"buffer_count": 19, "buffer_percent": 67, "configuration": "bBK4CG4G", "enable_region_overrides": true, "extendable_session": true, "game_version": "Ym92oHwV", "max_count": 78, "min_count": 94, "name": "SvDTGiIr", "region_overrides": {"RfAkj2ba": {"buffer_count": 12, "buffer_percent": 14, "max_count": 35, "min_count": 3, "name": "kIS0caFP", "unlimited": true, "use_buffer_percent": false}, "fjfno1vl": {"buffer_count": 36, "buffer_percent": 27, "max_count": 96, "min_count": 35, "name": "pnkllv2K", "unlimited": true, "use_buffer_percent": false}, "mCY7lVkY": {"buffer_count": 98, "buffer_percent": 59, "max_count": 17, "min_count": 57, "name": "7aJMZveJ", "unlimited": true, "use_buffer_percent": false}}, "regions": ["xvWp8QEc", "l7XomGun", "GB2ecddm"], "session_timeout": 75, "unlimited": false, "use_buffer_percent": false}}, "region_overrides": {"D6hquNyU": {"buffer_count": 99, "buffer_percent": 13, "max_count": 81, "min_count": 56, "name": "I8tgfk5v", "unlimited": true, "use_buffer_percent": false}, "Zoe5ynYb": {"buffer_count": 62, "buffer_percent": 39, "max_count": 24, "min_count": 38, "name": "Bo5HBGSE", "unlimited": true, "use_buffer_percent": false}, "r5OI0IpT": {"buffer_count": 22, "buffer_percent": 69, "max_count": 36, "min_count": 88, "name": "PssfR4Re", "unlimited": true, "use_buffer_percent": true}}, "regions": ["yxXJnUqC", "ejeVQNtv", "JiW1xiW2"], "session_timeout": 98, "unlimited": false, "use_buffer_percent": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreateDeployment \
    --deployment 'BvGsvEqc' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 18 'CreateDeployment' test.out

#- 19 DeleteDeployment
$CLI_EXE \
    --sn dsmc \
    --op DeleteDeployment \
    --deployment '7ALoNOkD' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 19 'DeleteDeployment' test.out

#- 20 UpdateDeployment
# body param: body
echo '{"allow_version_override": true, "buffer_count": 48, "buffer_percent": 63, "configuration": "u1EDmQED", "enable_region_overrides": false, "extendable_session": true, "game_version": "pGKzsRRK", "max_count": 30, "min_count": 89, "regions": ["i7m5WrLU", "ydfn7F8T", "SvwUHdDv"], "session_timeout": 44, "unlimited": false, "use_buffer_percent": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op UpdateDeployment \
    --deployment '3HUNNOeA' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 20 'UpdateDeployment' test.out

#- 21 CreateRootRegionOverride
# body param: body
echo '{"buffer_count": 3, "buffer_percent": 47, "max_count": 44, "min_count": 50, "unlimited": false, "use_buffer_percent": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreateRootRegionOverride \
    --deployment '1XHn8RSB' \
    --namespace $AB_NAMESPACE \
    --region 'jypweipQ' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 21 'CreateRootRegionOverride' test.out

#- 22 DeleteRootRegionOverride
$CLI_EXE \
    --sn dsmc \
    --op DeleteRootRegionOverride \
    --deployment '2rYJbEbr' \
    --namespace $AB_NAMESPACE \
    --region 'vCOQo0b2' \
    > test.out 2>&1
eval_tap $? 22 'DeleteRootRegionOverride' test.out

#- 23 UpdateRootRegionOverride
# body param: body
echo '{"buffer_count": 44, "buffer_percent": 4, "max_count": 71, "min_count": 22, "unlimited": false, "use_buffer_percent": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op UpdateRootRegionOverride \
    --deployment 'e47HghEj' \
    --namespace $AB_NAMESPACE \
    --region 'GAvsFMtq' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 23 'UpdateRootRegionOverride' test.out

#- 24 CreateDeploymentOverride
# body param: body
echo '{"buffer_count": 11, "buffer_percent": 96, "configuration": "QSgprJtw", "enable_region_overrides": false, "extendable_session": true, "game_version": "DWDhWXOd", "max_count": 90, "min_count": 77, "region_overrides": {"Z4xPWOSD": {"buffer_count": 77, "buffer_percent": 4, "max_count": 66, "min_count": 33, "name": "y9pRgEjT", "unlimited": false, "use_buffer_percent": false}, "zUmTrN8n": {"buffer_count": 48, "buffer_percent": 70, "max_count": 32, "min_count": 73, "name": "lpw9Wodn", "unlimited": true, "use_buffer_percent": false}, "IjLxZsbU": {"buffer_count": 48, "buffer_percent": 39, "max_count": 99, "min_count": 100, "name": "VuCekZ4g", "unlimited": true, "use_buffer_percent": false}}, "regions": ["HWr941bW", "VEZkvrqV", "qu1i3rRD"], "session_timeout": 29, "unlimited": false, "use_buffer_percent": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreateDeploymentOverride \
    --deployment 'l5YuoDwP' \
    --namespace $AB_NAMESPACE \
    --version '8GndA1fO' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 24 'CreateDeploymentOverride' test.out

#- 25 DeleteDeploymentOverride
$CLI_EXE \
    --sn dsmc \
    --op DeleteDeploymentOverride \
    --deployment 'Ubu6FNDS' \
    --namespace $AB_NAMESPACE \
    --version 'EaqLwK8M' \
    > test.out 2>&1
eval_tap $? 25 'DeleteDeploymentOverride' test.out

#- 26 UpdateDeploymentOverride
# body param: body
echo '{"buffer_count": 49, "buffer_percent": 61, "configuration": "xIK64r2Q", "enable_region_overrides": true, "game_version": "AnE9THXv", "max_count": 36, "min_count": 25, "regions": ["uwj9Ah5T", "RgJgQCUp", "zhzuclUz"], "session_timeout": 44, "unlimited": false, "use_buffer_percent": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op UpdateDeploymentOverride \
    --deployment 'zm6X57HH' \
    --namespace $AB_NAMESPACE \
    --version 'tTGFjNmP' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 26 'UpdateDeploymentOverride' test.out

#- 27 CreateOverrideRegionOverride
# body param: body
echo '{"buffer_count": 19, "buffer_percent": 33, "max_count": 51, "min_count": 49, "unlimited": true, "use_buffer_percent": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreateOverrideRegionOverride \
    --deployment '0bmb7wxp' \
    --namespace $AB_NAMESPACE \
    --region '1IGLU8pv' \
    --version 'Qu8jyHqz' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 27 'CreateOverrideRegionOverride' test.out

#- 28 DeleteOverrideRegionOverride
$CLI_EXE \
    --sn dsmc \
    --op DeleteOverrideRegionOverride \
    --deployment 'gA0PrNZH' \
    --namespace $AB_NAMESPACE \
    --region 'jQcTxyKg' \
    --version '909bTfYs' \
    > test.out 2>&1
eval_tap $? 28 'DeleteOverrideRegionOverride' test.out

#- 29 UpdateOverrideRegionOverride
# body param: body
echo '{"buffer_count": 95, "buffer_percent": 60, "max_count": 91, "min_count": 79, "unlimited": false, "use_buffer_percent": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op UpdateOverrideRegionOverride \
    --deployment 'JY8ignEC' \
    --namespace $AB_NAMESPACE \
    --region '1DRsVdvm' \
    --version 'iEDKVWqu' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 29 'UpdateOverrideRegionOverride' test.out

#- 30 DeleteCreatingServerCountQueue
$CLI_EXE \
    --sn dsmc \
    --op DeleteCreatingServerCountQueue \
    --deployment 'mLH6ndno' \
    --namespace $AB_NAMESPACE \
    --version 'Ap1l9pXw' \
    > test.out 2>&1
eval_tap $? 30 'DeleteCreatingServerCountQueue' test.out

#- 31 GetAllPodConfig
$CLI_EXE \
    --sn dsmc \
    --op GetAllPodConfig \
    --namespace $AB_NAMESPACE \
    --count '14' \
    --offset '29' \
    > test.out 2>&1
eval_tap $? 31 'GetAllPodConfig' test.out

#- 32 GetPodConfig
$CLI_EXE \
    --sn dsmc \
    --op GetPodConfig \
    --name 'fzXZwlQf' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 32 'GetPodConfig' test.out

#- 33 CreatePodConfig
# body param: body
echo '{"cpu_limit": 35, "mem_limit": 84, "params": "MuiHWwIN"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreatePodConfig \
    --name 'EuvsMoz5' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 33 'CreatePodConfig' test.out

#- 34 DeletePodConfig
$CLI_EXE \
    --sn dsmc \
    --op DeletePodConfig \
    --name 'g9rgmnQp' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 34 'DeletePodConfig' test.out

#- 35 UpdatePodConfig
# body param: body
echo '{"cpu_limit": 90, "mem_limit": 5, "name": "RQrFDTGC", "params": "33jD0SS9"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op UpdatePodConfig \
    --name 'Yo6cjTSr' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 35 'UpdatePodConfig' test.out

#- 36 AddPort
# body param: body
echo '{"port": 60}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op AddPort \
    --name 'whySSY9v' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 36 'AddPort' test.out

#- 37 DeletePort
$CLI_EXE \
    --sn dsmc \
    --op DeletePort \
    --name 'dc6QiVDU' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 37 'DeletePort' test.out

#- 38 UpdatePort
# body param: body
echo '{"name": "6V1GuWpb", "port": 73}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op UpdatePort \
    --name '5yOICx9p' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 38 'UpdatePort' test.out

#- 39 ListImages
$CLI_EXE \
    --sn dsmc \
    --op ListImages \
    --namespace $AB_NAMESPACE \
    --q 'C28rR2O4' \
    --sortBy 'updatedAt' \
    --sortDirection 'desc' \
    --count '38' \
    --offset '58' \
    > test.out 2>&1
eval_tap $? 39 'ListImages' test.out

#- 40 DeleteImage
$CLI_EXE \
    --sn dsmc \
    --op DeleteImage \
    --namespace $AB_NAMESPACE \
    --imageURI 'TxNqo9TK' \
    --version 'NaZTUI2u' \
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
    --imageURI 'ktOn6IuF' \
    --version '9oZVFHXk' \
    --versionPatch '6IZAW2Up' \
    > test.out 2>&1
eval_tap $? 42 'DeleteImagePatch' test.out

#- 43 GetImageDetail
$CLI_EXE \
    --sn dsmc \
    --op GetImageDetail \
    --namespace $AB_NAMESPACE \
    --version '0hfORZ6A' \
    > test.out 2>&1
eval_tap $? 43 'GetImageDetail' test.out

#- 44 GetImagePatches
$CLI_EXE \
    --sn dsmc \
    --op GetImagePatches \
    --namespace $AB_NAMESPACE \
    --version '5mVDwZcJ' \
    > test.out 2>&1
eval_tap $? 44 'GetImagePatches' test.out

#- 45 GetImagePatchDetail
$CLI_EXE \
    --sn dsmc \
    --op GetImagePatchDetail \
    --namespace $AB_NAMESPACE \
    --version 'ZJdYjGw6' \
    --versionPatch 'DBzQgFpz' \
    > test.out 2>&1
eval_tap $? 45 'GetImagePatchDetail' test.out

#- 46 AddBuffer
# body param: body
echo '{"AllocCount": 77, "DeploymentName": "wXcvVznB", "JobCount": 96, "JobPriority": 35, "OverrideVersion": "XIwUBe1w", "Region": "7aU5Nwr5"}' > $TEMP_JSON_INPUT
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
    --region 'u01XM6QV' \
    --count '18' \
    --offset '66' \
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
    --region 'lRtsAxCI' \
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
    --name 'PVcJOd6B' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 52 'DeleteLocalServer' test.out

#- 53 GetServer
$CLI_EXE \
    --sn dsmc \
    --op GetServer \
    --namespace $AB_NAMESPACE \
    --podName 'LfPnUvGT' \
    > test.out 2>&1
eval_tap $? 53 'GetServer' test.out

#- 54 DeleteServer
$CLI_EXE \
    --sn dsmc \
    --op DeleteServer \
    --namespace $AB_NAMESPACE \
    --podName '9IvI1ZMP' \
    > test.out 2>&1
eval_tap $? 54 'DeleteServer' test.out

#- 55 ListSession
$CLI_EXE \
    --sn dsmc \
    --op ListSession \
    --namespace $AB_NAMESPACE \
    --region 'OfWALBNU' \
    --withServer 'false' \
    --count '63' \
    --offset '14' \
    > test.out 2>&1
eval_tap $? 55 'ListSession' test.out

#- 56 CountSession
$CLI_EXE \
    --sn dsmc \
    --op CountSession \
    --namespace $AB_NAMESPACE \
    --region 'QbEKyAQi' \
    > test.out 2>&1
eval_tap $? 56 'CountSession' test.out

#- 57 DeleteSession
$CLI_EXE \
    --sn dsmc \
    --op DeleteSession \
    --namespace $AB_NAMESPACE \
    --sessionID 'Md04RyRe' \
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
echo '{"JobCount": 96, "Region": "U4BvGdEq", "TimeoutSecond": 89, "ZombieCount": 27}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op RunZombieCleanerRequestHandler \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 59 'RunZombieCleanerRequestHandler' test.out

#- 60 CreateRepository
# body param: body
echo '{"namespace": "tv7iOCJq", "repository": "s6Fer3d5"}' > $TEMP_JSON_INPUT
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
    --name 'SafcLIOt' \
    --count '55' \
    --offset '60' \
    > test.out 2>&1
eval_tap $? 63 'GetAllDeploymentClient' test.out

#- 64 GetDeploymentClient
$CLI_EXE \
    --sn dsmc \
    --op GetDeploymentClient \
    --deployment 'mP3AtQGe' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 64 'GetDeploymentClient' test.out

#- 65 CreateDeploymentClient
# body param: body
echo '{"allow_version_override": true, "buffer_count": 80, "buffer_percent": 16, "configuration": "R2lb1C9Q", "enable_region_overrides": false, "extendable_session": false, "game_version": "EXHOtOsk", "max_count": 87, "min_count": 57, "overrides": {"gTqn8Jtq": {"buffer_count": 0, "buffer_percent": 34, "configuration": "MmywlVkv", "enable_region_overrides": true, "extendable_session": false, "game_version": "0EWwhTgA", "max_count": 58, "min_count": 96, "name": "FpBRuesA", "region_overrides": {"Q5t8RAgX": {"buffer_count": 10, "buffer_percent": 83, "max_count": 28, "min_count": 4, "name": "1n7dg81q", "unlimited": false, "use_buffer_percent": true}, "AAY8r1qM": {"buffer_count": 37, "buffer_percent": 9, "max_count": 9, "min_count": 99, "name": "I40TNLo6", "unlimited": false, "use_buffer_percent": false}, "q9dweNjW": {"buffer_count": 77, "buffer_percent": 0, "max_count": 47, "min_count": 55, "name": "TqbCSgH9", "unlimited": true, "use_buffer_percent": false}}, "regions": ["sK8gSgo7", "fr4vw8Ah", "hhMAHg0d"], "session_timeout": 77, "unlimited": true, "use_buffer_percent": true}, "bdkyE6O5": {"buffer_count": 76, "buffer_percent": 91, "configuration": "X8Un0CF4", "enable_region_overrides": false, "extendable_session": false, "game_version": "cflx1TlV", "max_count": 10, "min_count": 46, "name": "UpNmqbhQ", "region_overrides": {"vFyLBdNI": {"buffer_count": 75, "buffer_percent": 32, "max_count": 44, "min_count": 30, "name": "jcBmegpi", "unlimited": true, "use_buffer_percent": false}, "BkuPCque": {"buffer_count": 44, "buffer_percent": 80, "max_count": 12, "min_count": 74, "name": "AN5F6LNM", "unlimited": false, "use_buffer_percent": true}, "Yl34PtxB": {"buffer_count": 60, "buffer_percent": 81, "max_count": 9, "min_count": 22, "name": "RX6GWdmN", "unlimited": false, "use_buffer_percent": false}}, "regions": ["prPl7Erx", "QaVxHalu", "gRRrJdIl"], "session_timeout": 25, "unlimited": false, "use_buffer_percent": true}, "MPOawYM6": {"buffer_count": 5, "buffer_percent": 63, "configuration": "dz8s58qK", "enable_region_overrides": false, "extendable_session": false, "game_version": "NxVcqMK9", "max_count": 63, "min_count": 79, "name": "Dkz0DpQp", "region_overrides": {"SOeaErQ2": {"buffer_count": 51, "buffer_percent": 74, "max_count": 54, "min_count": 59, "name": "JPiiLxtx", "unlimited": true, "use_buffer_percent": false}, "2JxZLWrj": {"buffer_count": 54, "buffer_percent": 82, "max_count": 66, "min_count": 81, "name": "d9Cn0xAB", "unlimited": true, "use_buffer_percent": true}, "AMVJMvbK": {"buffer_count": 19, "buffer_percent": 14, "max_count": 50, "min_count": 40, "name": "TlIms4IS", "unlimited": true, "use_buffer_percent": false}}, "regions": ["fCFbdXEP", "MVZRrwFI", "02ltzGH2"], "session_timeout": 0, "unlimited": true, "use_buffer_percent": false}}, "region_overrides": {"IvVt4nxr": {"buffer_count": 5, "buffer_percent": 41, "max_count": 67, "min_count": 44, "name": "ate30L4Y", "unlimited": true, "use_buffer_percent": true}, "clPHdQWV": {"buffer_count": 35, "buffer_percent": 17, "max_count": 98, "min_count": 85, "name": "w6nnsSzZ", "unlimited": true, "use_buffer_percent": true}, "F04mRAoN": {"buffer_count": 49, "buffer_percent": 19, "max_count": 62, "min_count": 26, "name": "TX005S80", "unlimited": false, "use_buffer_percent": false}}, "regions": ["N5ESdscB", "A8Y86c1a", "UBo717E5"], "session_timeout": 75, "unlimited": true, "use_buffer_percent": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreateDeploymentClient \
    --deployment 'kh0WBSXw' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 65 'CreateDeploymentClient' test.out

#- 66 DeleteDeploymentClient
$CLI_EXE \
    --sn dsmc \
    --op DeleteDeploymentClient \
    --deployment 'Jz4dJExc' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 66 'DeleteDeploymentClient' test.out

#- 67 GetAllPodConfigClient
$CLI_EXE \
    --sn dsmc \
    --op GetAllPodConfigClient \
    --namespace $AB_NAMESPACE \
    --count '33' \
    --offset '37' \
    > test.out 2>&1
eval_tap $? 67 'GetAllPodConfigClient' test.out

#- 68 CreatePodConfigClient
# body param: body
echo '{"cpu_limit": 74, "mem_limit": 61, "params": "2gk1GKHk"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreatePodConfigClient \
    --name 'wCmGhDwN' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 68 'CreatePodConfigClient' test.out

#- 69 DeletePodConfigClient
$CLI_EXE \
    --sn dsmc \
    --op DeletePodConfigClient \
    --name 'HPDsV1Ar' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 69 'DeletePodConfigClient' test.out

#- 70 ListImagesClient
$CLI_EXE \
    --sn dsmc \
    --op ListImagesClient \
    --namespace $AB_NAMESPACE \
    --count '96' \
    --offset '32' \
    --q 'SyvnJIGM' \
    --sortBy 'version' \
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
    --version 'tC9Ftcga' \
    > test.out 2>&1
eval_tap $? 72 'ImageDetailClient' test.out

#- 73 ListServerClient
$CLI_EXE \
    --sn dsmc \
    --op ListServerClient \
    --namespace $AB_NAMESPACE \
    --region 'brNKnOZS' \
    --count '23' \
    --offset '76' \
    > test.out 2>&1
eval_tap $? 73 'ListServerClient' test.out

#- 74 CountServerDetailedClient
$CLI_EXE \
    --sn dsmc \
    --op CountServerDetailedClient \
    --namespace $AB_NAMESPACE \
    --region 'OgcraJYv' \
    > test.out 2>&1
eval_tap $? 74 'CountServerDetailedClient' test.out

#- 75 ServerHeartbeat
# body param: body
echo '{"podName": "UkzItjCP"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op ServerHeartbeat \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 75 'ServerHeartbeat' test.out

#- 76 DeregisterLocalServer
# body param: body
echo '{"name": "T66t4g2b"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op DeregisterLocalServer \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 76 'DeregisterLocalServer' test.out

#- 77 RegisterLocalServer
# body param: body
echo '{"custom_attribute": "5f6dCiZC", "ip": "H1AUcJmF", "name": "6jkDbJ1I", "port": 11}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op RegisterLocalServer \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 77 'RegisterLocalServer' test.out

#- 78 RegisterServer
# body param: body
echo '{"custom_attribute": "IBHAJOGP", "pod_name": "eC9m1ewM"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op RegisterServer \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 78 'RegisterServer' test.out

#- 79 ShutdownServer
# body param: body
echo '{"kill_me": false, "pod_name": "hyUVEk10"}' > $TEMP_JSON_INPUT
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
    --podName 'nv9x1DLL' \
    > test.out 2>&1
eval_tap $? 80 'GetServerSessionTimeout' test.out

#- 81 GetServerSession
$CLI_EXE \
    --sn dsmc \
    --op GetServerSession \
    --namespace $AB_NAMESPACE \
    --podName '9jTcvAhK' \
    > test.out 2>&1
eval_tap $? 81 'GetServerSession' test.out

#- 82 CreateSession
# body param: body
echo '{"client_version": "PpQBiqu1", "configuration": "DI0Vjtl5", "deployment": "anewfZif", "game_mode": "ZhNySsA0", "matching_allies": [{"matching_parties": [{"party_attributes": {"vu1VZTwc": {}, "6CLyyZKZ": {}, "g69mMNnD": {}}, "party_id": "SML1ZG2B", "party_members": [{"user_id": "24VWBUfU"}, {"user_id": "6YJuBDlD"}, {"user_id": "ro6uzGM4"}]}, {"party_attributes": {"0Gahco8C": {}, "ig6hHGvj": {}, "kIkivyjh": {}}, "party_id": "WNyXzoMM", "party_members": [{"user_id": "nEHX84ZU"}, {"user_id": "GqiIzN6V"}, {"user_id": "0I3CqUGj"}]}, {"party_attributes": {"LfsLlhGV": {}, "eV01YHAV": {}, "kO1c3tlM": {}}, "party_id": "GA4UYmvT", "party_members": [{"user_id": "i8q9StOE"}, {"user_id": "LOmsbV00"}, {"user_id": "GqqBWI4n"}]}]}, {"matching_parties": [{"party_attributes": {"zfKxOmER": {}, "mgS3InoX": {}, "dqia3ij9": {}}, "party_id": "hiMCY3Ao", "party_members": [{"user_id": "yn3D1t4K"}, {"user_id": "OvzY6drT"}, {"user_id": "n1WEbBk0"}]}, {"party_attributes": {"HC3XxZQu": {}, "iNIntzHK": {}, "8CFxMV9c": {}}, "party_id": "Q3QdLUgk", "party_members": [{"user_id": "bPhEC2n8"}, {"user_id": "zbjLVwCX"}, {"user_id": "UkhNSLqp"}]}, {"party_attributes": {"nas173Nk": {}, "I8IgQMeP": {}, "tpTlWY1D": {}}, "party_id": "2TWhfQ3C", "party_members": [{"user_id": "SdI5G1h6"}, {"user_id": "S30ab2wm"}, {"user_id": "F4l7e8Hx"}]}]}, {"matching_parties": [{"party_attributes": {"3mOjlVF4": {}, "eEq9iDXk": {}, "cp4Vgfvw": {}}, "party_id": "um42uju6", "party_members": [{"user_id": "8Ork7g2Y"}, {"user_id": "NIEdRgdw"}, {"user_id": "WH5e1XHb"}]}, {"party_attributes": {"StHh62sC": {}, "oQyobf4j": {}, "Da6LdTvI": {}}, "party_id": "xUlM5hIS", "party_members": [{"user_id": "nN3NWuke"}, {"user_id": "QKF5pGkb"}, {"user_id": "mpn1hxXB"}]}, {"party_attributes": {"iygT4MNm": {}, "y1NBeFqJ": {}, "QoKDXHZi": {}}, "party_id": "p2EWLvQu", "party_members": [{"user_id": "fBFbHH0P"}, {"user_id": "jh0RDYsW"}, {"user_id": "nRndyOhe"}]}]}], "namespace": "IuZgxRNK", "notification_payload": {}, "pod_name": "x8VeWfw6", "region": "Q36z3tir", "session_id": "JZ2gcx5J"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreateSession \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 82 'CreateSession' test.out

#- 83 ClaimServer
# body param: body
echo '{"game_mode": "6lEiRHIu", "matching_allies": [{"matching_parties": [{"party_attributes": {"nuPUePLf": {}, "9rCxT1XW": {}, "t7eE0BAI": {}}, "party_id": "Swcqaz1J", "party_members": [{"user_id": "g8hdXDNC"}, {"user_id": "NBTGUBO8"}, {"user_id": "Py99r2HB"}]}, {"party_attributes": {"znbz44eX": {}, "HPwZiP98": {}, "SB1M4ipt": {}}, "party_id": "pFWES7qd", "party_members": [{"user_id": "0MvKO4UI"}, {"user_id": "rU6OyNla"}, {"user_id": "r5wmzjeM"}]}, {"party_attributes": {"rgZwxQEi": {}, "dmiaCPBW": {}, "a1MwVcVv": {}}, "party_id": "LIMoVyyF", "party_members": [{"user_id": "ioXKkoCN"}, {"user_id": "kJbxp195"}, {"user_id": "ags6fDGE"}]}]}, {"matching_parties": [{"party_attributes": {"FZFiFOhb": {}, "kKBSzR7y": {}, "nr24hQBT": {}}, "party_id": "w3KMvU0e", "party_members": [{"user_id": "QGuvfOqg"}, {"user_id": "jauR06mA"}, {"user_id": "jKMMicuX"}]}, {"party_attributes": {"UzbmzZQZ": {}, "fEpTA6dh": {}, "VXjtbLfQ": {}}, "party_id": "17hBpIkE", "party_members": [{"user_id": "Gwl1Ve8D"}, {"user_id": "Gzbd4lUT"}, {"user_id": "Pyo5IGHW"}]}, {"party_attributes": {"ZDpvWKgg": {}, "H7HrxbDZ": {}, "PUwkzAyu": {}}, "party_id": "TF5OOLrs", "party_members": [{"user_id": "PnM3h4mX"}, {"user_id": "EoHr98QH"}, {"user_id": "LI4KpZsa"}]}]}, {"matching_parties": [{"party_attributes": {"lYYkLhLY": {}, "dAmiu9dy": {}, "Rx0eNFJR": {}}, "party_id": "Wlnc9z7A", "party_members": [{"user_id": "fz5nkYQ1"}, {"user_id": "08KsU4Gu"}, {"user_id": "vVilP31j"}]}, {"party_attributes": {"ypbIKH4W": {}, "z4DkkrmQ": {}, "vI0huMNk": {}}, "party_id": "iCalkuAI", "party_members": [{"user_id": "WFlWhtDn"}, {"user_id": "dSKS41fN"}, {"user_id": "DwD1rDwp"}]}, {"party_attributes": {"B4YaiTDe": {}, "4FsIT2eN": {}, "UBgqQsq5": {}}, "party_id": "YohClXFj", "party_members": [{"user_id": "IaxOWNv9"}, {"user_id": "CLse7ifV"}, {"user_id": "awls9GLY"}]}]}], "namespace": "TWgYejX7", "notification_payload": {}, "session_id": "Z4T4KKwu"}' > $TEMP_JSON_INPUT
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
    --sessionID '4cS59hdB' \
    > test.out 2>&1
eval_tap $? 84 'GetSession' test.out

#- 85 CancelSession
$CLI_EXE \
    --sn dsmc \
    --op CancelSession \
    --namespace $AB_NAMESPACE \
    --sessionID '4Cr50BhR' \
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
    --region 'rRPrUnVl' \
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