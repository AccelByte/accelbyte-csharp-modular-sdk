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
echo "1..82"

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
echo '{"artifactPath": "bDHclLWI", "coreDumpEnabled": true, "image": "15a9uatb", "imageReplicationsMap": {"uqLpC4dv": {"failure_code": "Dvp2pOZK", "region": "A6cMh6f5", "status": "0k7qL1ya", "uri": "wsbYRsUr"}, "G2zsvaBk": {"failure_code": "NErh76OK", "region": "sz52cVas", "status": "J9yhTUGM", "uri": "TtYXtj5z"}, "Z81Z1nRA": {"failure_code": "guerkFFl", "region": "bY1Cn8KE", "status": "qEfjr0Bg", "uri": "WcKdBhS4"}}, "namespace": "6jENt8gZ", "patchVersion": "8g1gymSp", "persistent": false, "version": "SJs43g7A"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op UpdateImage \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 4 'UpdateImage' test.out

#- 5 CreateImage
# body param: body
echo '{"artifactPath": "zCE61ZwU", "coreDumpEnabled": true, "dockerPath": "GSkURAdr", "image": "58Q3GGdC", "imageSize": 24, "namespace": "7uAfhvFY", "persistent": false, "ulimitFileSize": 31, "version": "ujvoutFm"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreateImage \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 5 'CreateImage' test.out

#- 6 ImportImages
# form data upload: file
echo 'tmp.dat' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --sn dsmc \
    --op ImportImages \
    --upload file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 6 'ImportImages' test.out

#- 7 CreateImagePatch
# body param: body
echo '{"artifactPath": "bNo9sztB", "coreDumpEnabled": true, "dockerPath": "eCWHfABk", "image": "rLohV8SM", "imageSize": 54, "namespace": "5QhacAos", "patchVersion": "VgdC4EPO", "persistent": false, "ulimitFileSize": 94, "uploaderFlag": "IjMAKXZu", "version": "9AS0Hl9Z"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreateImagePatch \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 7 'CreateImagePatch' test.out

#- 8 GetLowestInstanceSpec
$CLI_EXE \
    --sn dsmc \
    --op GetLowestInstanceSpec \
    > test.out 2>&1
eval_tap $? 8 'GetLowestInstanceSpec' test.out

#- 9 GetConfig
$CLI_EXE \
    --sn dsmc \
    --op GetConfig \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 9 'GetConfig' test.out

#- 10 CreateConfig
# body param: body
echo '{"claim_timeout": 50, "creation_timeout": 28, "default_version": "ZgR6bwkC", "port": 55, "ports": {"aiklT0Gp": 84, "4H91MtL6": 98, "vStwOmoe": 73}, "protocol": "bh0Lf7lw", "providers": ["7ssEJOKL", "XKGP7Kmz", "WcNDDHyJ"], "session_timeout": 54, "unreachable_timeout": 73}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreateConfig \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 10 'CreateConfig' test.out

#- 11 DeleteConfig
$CLI_EXE \
    --sn dsmc \
    --op DeleteConfig \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 11 'DeleteConfig' test.out

#- 12 UpdateConfig
# body param: body
echo '{"claim_timeout": 50, "creation_timeout": 43, "default_version": "cGVJ56oA", "port": 73, "protocol": "xUaMmM5m", "providers": ["hAuPf9FE", "qa0zJGYQ", "GXB0znvU"], "session_timeout": 35, "unreachable_timeout": 26}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op UpdateConfig \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 12 'UpdateConfig' test.out

#- 13 ClearCache
$CLI_EXE \
    --sn dsmc \
    --op ClearCache \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 13 'ClearCache' test.out

#- 14 GetAllDeployment
$CLI_EXE \
    --sn dsmc \
    --op GetAllDeployment \
    --namespace $AB_NAMESPACE \
    --name 'I3Ri0Xw3' \
    --count '75' \
    --offset '9' \
    > test.out 2>&1
eval_tap $? 14 'GetAllDeployment' test.out

#- 15 GetDeployment
$CLI_EXE \
    --sn dsmc \
    --op GetDeployment \
    --deployment '05pJLMOz' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 15 'GetDeployment' test.out

#- 16 CreateDeployment
# body param: body
echo '{"allow_version_override": true, "buffer_count": 29, "buffer_percent": 95, "configuration": "1Z3XfDtP", "enable_region_overrides": false, "extendable_session": false, "game_version": "W21Ho0Iu", "max_count": 55, "min_count": 31, "overrides": {"KDFJkO9g": {"buffer_count": 34, "buffer_percent": 2, "configuration": "CcIkOAz1", "enable_region_overrides": false, "extendable_session": false, "game_version": "nZxq9ulp", "max_count": 76, "min_count": 65, "name": "nbI7RN18", "region_overrides": {"OZ2YpT6J": {"buffer_count": 64, "buffer_percent": 53, "max_count": 41, "min_count": 77, "name": "B9PEZxCK", "unlimited": true, "use_buffer_percent": false}, "tjPQgXzL": {"buffer_count": 39, "buffer_percent": 62, "max_count": 65, "min_count": 56, "name": "bed70yrQ", "unlimited": false, "use_buffer_percent": false}, "n6exBlgh": {"buffer_count": 42, "buffer_percent": 63, "max_count": 6, "min_count": 32, "name": "bCtr5ZtW", "unlimited": true, "use_buffer_percent": true}}, "regions": ["vR5gpROD", "HVKTZPRf", "6rJk88kI"], "session_timeout": 23, "unlimited": true, "use_buffer_percent": true}, "iDv1mvQv": {"buffer_count": 2, "buffer_percent": 67, "configuration": "FwfaOb5H", "enable_region_overrides": true, "extendable_session": true, "game_version": "7GOIHWxF", "max_count": 42, "min_count": 80, "name": "H13CFDYm", "region_overrides": {"WYyNoPIn": {"buffer_count": 89, "buffer_percent": 28, "max_count": 11, "min_count": 69, "name": "83t4UGR8", "unlimited": false, "use_buffer_percent": false}, "JAdhMopU": {"buffer_count": 49, "buffer_percent": 53, "max_count": 45, "min_count": 75, "name": "m1D8PZ3V", "unlimited": false, "use_buffer_percent": true}, "16k4ikYd": {"buffer_count": 57, "buffer_percent": 8, "max_count": 31, "min_count": 53, "name": "sxnDksdB", "unlimited": false, "use_buffer_percent": false}}, "regions": ["xpF43Gmu", "eOZjoJ3B", "vdtBAezN"], "session_timeout": 99, "unlimited": false, "use_buffer_percent": false}, "qMpFwZo1": {"buffer_count": 76, "buffer_percent": 40, "configuration": "DoR3IZdg", "enable_region_overrides": true, "extendable_session": true, "game_version": "jnQCes11", "max_count": 13, "min_count": 57, "name": "kGoi92WT", "region_overrides": {"KbQuZlX8": {"buffer_count": 65, "buffer_percent": 40, "max_count": 58, "min_count": 16, "name": "0wvNGf9T", "unlimited": true, "use_buffer_percent": false}, "TduZS0Ci": {"buffer_count": 71, "buffer_percent": 87, "max_count": 74, "min_count": 91, "name": "sSDLtzYr", "unlimited": false, "use_buffer_percent": true}, "dkFajgfa": {"buffer_count": 74, "buffer_percent": 4, "max_count": 71, "min_count": 38, "name": "xsJ3ty2u", "unlimited": true, "use_buffer_percent": false}}, "regions": ["G9VGhuIH", "OMqY313L", "vX7O4VTE"], "session_timeout": 19, "unlimited": true, "use_buffer_percent": true}}, "region_overrides": {"5tx0gQof": {"buffer_count": 69, "buffer_percent": 79, "max_count": 5, "min_count": 45, "name": "89ERFZQR", "unlimited": true, "use_buffer_percent": false}, "WC8dBf1h": {"buffer_count": 16, "buffer_percent": 89, "max_count": 6, "min_count": 42, "name": "rsmkIcqD", "unlimited": false, "use_buffer_percent": true}, "Cj70qV9G": {"buffer_count": 72, "buffer_percent": 28, "max_count": 58, "min_count": 5, "name": "1TNyhxob", "unlimited": true, "use_buffer_percent": false}}, "regions": ["La0bzbfg", "OtSoJeYW", "3yOmb4NY"], "session_timeout": 57, "unlimited": true, "use_buffer_percent": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreateDeployment \
    --deployment '6BYXNbwk' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 16 'CreateDeployment' test.out

#- 17 DeleteDeployment
$CLI_EXE \
    --sn dsmc \
    --op DeleteDeployment \
    --deployment 'VTRK9C6y' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 17 'DeleteDeployment' test.out

#- 18 UpdateDeployment
# body param: body
echo '{"allow_version_override": false, "buffer_count": 81, "buffer_percent": 76, "configuration": "w4gOvPGZ", "enable_region_overrides": true, "extendable_session": false, "game_version": "1t8fF6nH", "max_count": 40, "min_count": 9, "regions": ["KQAv7FNu", "T19w3Dwx", "df5GNQBY"], "session_timeout": 35, "unlimited": true, "use_buffer_percent": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op UpdateDeployment \
    --deployment 'sQtoFLsg' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 18 'UpdateDeployment' test.out

#- 19 CreateRootRegionOverride
# body param: body
echo '{"buffer_count": 28, "buffer_percent": 83, "max_count": 8, "min_count": 90, "unlimited": true, "use_buffer_percent": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreateRootRegionOverride \
    --deployment 'AmyEujuU' \
    --namespace $AB_NAMESPACE \
    --region '8Hh4Oy14' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 19 'CreateRootRegionOverride' test.out

#- 20 DeleteRootRegionOverride
$CLI_EXE \
    --sn dsmc \
    --op DeleteRootRegionOverride \
    --deployment 'hmTbEIBW' \
    --namespace $AB_NAMESPACE \
    --region 'h85d0d6H' \
    > test.out 2>&1
eval_tap $? 20 'DeleteRootRegionOverride' test.out

#- 21 UpdateRootRegionOverride
# body param: body
echo '{"buffer_count": 97, "buffer_percent": 70, "max_count": 48, "min_count": 18, "unlimited": true, "use_buffer_percent": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op UpdateRootRegionOverride \
    --deployment 'MHT6imWg' \
    --namespace $AB_NAMESPACE \
    --region 'h0ZrZLqQ' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 21 'UpdateRootRegionOverride' test.out

#- 22 CreateDeploymentOverride
# body param: body
echo '{"buffer_count": 82, "buffer_percent": 100, "configuration": "ZKhKmF9F", "enable_region_overrides": false, "extendable_session": false, "game_version": "M6VIsboz", "max_count": 32, "min_count": 71, "region_overrides": {"l3gMtBjg": {"buffer_count": 60, "buffer_percent": 7, "max_count": 97, "min_count": 30, "name": "ILq3qyJT", "unlimited": false, "use_buffer_percent": false}, "LRYDfqql": {"buffer_count": 38, "buffer_percent": 95, "max_count": 13, "min_count": 31, "name": "Xj6fQoeU", "unlimited": true, "use_buffer_percent": false}, "XGor18Fy": {"buffer_count": 43, "buffer_percent": 13, "max_count": 86, "min_count": 67, "name": "r2pvTkYg", "unlimited": true, "use_buffer_percent": true}}, "regions": ["Nhdfu4du", "HnLaSIBU", "ht5zYZDD"], "session_timeout": 51, "unlimited": true, "use_buffer_percent": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreateDeploymentOverride \
    --deployment 'K1dgrAxz' \
    --namespace $AB_NAMESPACE \
    --version 'Wl695k2y' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 22 'CreateDeploymentOverride' test.out

#- 23 DeleteDeploymentOverride
$CLI_EXE \
    --sn dsmc \
    --op DeleteDeploymentOverride \
    --deployment 'julmshW3' \
    --namespace $AB_NAMESPACE \
    --version '643Ni9eF' \
    > test.out 2>&1
eval_tap $? 23 'DeleteDeploymentOverride' test.out

#- 24 UpdateDeploymentOverride
# body param: body
echo '{"buffer_count": 3, "buffer_percent": 61, "configuration": "oor21MEe", "enable_region_overrides": false, "game_version": "qSI37nqw", "max_count": 66, "min_count": 61, "regions": ["NpwUSFCS", "r1cO8WdS", "WXrAbmTK"], "session_timeout": 81, "unlimited": false, "use_buffer_percent": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op UpdateDeploymentOverride \
    --deployment '0zLezjdu' \
    --namespace $AB_NAMESPACE \
    --version 'HA6IT5R1' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 24 'UpdateDeploymentOverride' test.out

#- 25 CreateOverrideRegionOverride
# body param: body
echo '{"buffer_count": 63, "buffer_percent": 51, "max_count": 72, "min_count": 46, "unlimited": false, "use_buffer_percent": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreateOverrideRegionOverride \
    --deployment 'm1RnknPQ' \
    --namespace $AB_NAMESPACE \
    --region 'aUgmaltM' \
    --version '6FtI6aMh' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 25 'CreateOverrideRegionOverride' test.out

#- 26 DeleteOverrideRegionOverride
$CLI_EXE \
    --sn dsmc \
    --op DeleteOverrideRegionOverride \
    --deployment 'NPAJ7kpM' \
    --namespace $AB_NAMESPACE \
    --region 'TpKHDorF' \
    --version 'jdvQMYxC' \
    > test.out 2>&1
eval_tap $? 26 'DeleteOverrideRegionOverride' test.out

#- 27 UpdateOverrideRegionOverride
# body param: body
echo '{"buffer_count": 30, "buffer_percent": 31, "max_count": 37, "min_count": 31, "unlimited": false, "use_buffer_percent": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op UpdateOverrideRegionOverride \
    --deployment 'zIJHh294' \
    --namespace $AB_NAMESPACE \
    --region 'a7hdTdhJ' \
    --version 'Z2QVdibD' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 27 'UpdateOverrideRegionOverride' test.out

#- 28 GetAllPodConfig
$CLI_EXE \
    --sn dsmc \
    --op GetAllPodConfig \
    --namespace $AB_NAMESPACE \
    --count '26' \
    --offset '6' \
    > test.out 2>&1
eval_tap $? 28 'GetAllPodConfig' test.out

#- 29 GetPodConfig
$CLI_EXE \
    --sn dsmc \
    --op GetPodConfig \
    --name '3fBT0okb' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 29 'GetPodConfig' test.out

#- 30 CreatePodConfig
# body param: body
echo '{"cpu_limit": 6, "mem_limit": 96, "params": "g69VoiIf"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreatePodConfig \
    --name 'TX0NE27N' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 30 'CreatePodConfig' test.out

#- 31 DeletePodConfig
$CLI_EXE \
    --sn dsmc \
    --op DeletePodConfig \
    --name '4DalrTAs' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 31 'DeletePodConfig' test.out

#- 32 UpdatePodConfig
# body param: body
echo '{"cpu_limit": 67, "mem_limit": 35, "name": "QllVCd4z", "params": "dvT9ORGC"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op UpdatePodConfig \
    --name 'PP9I5MrC' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 32 'UpdatePodConfig' test.out

#- 33 AddPort
# body param: body
echo '{"port": 27}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op AddPort \
    --name 'feqXprhu' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 33 'AddPort' test.out

#- 34 DeletePort
$CLI_EXE \
    --sn dsmc \
    --op DeletePort \
    --name '7pgnVMWB' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 34 'DeletePort' test.out

#- 35 UpdatePort
# body param: body
echo '{"name": "QUOuxSFn", "port": 35}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op UpdatePort \
    --name 's1v8fYWM' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 35 'UpdatePort' test.out

#- 36 ListImages
$CLI_EXE \
    --sn dsmc \
    --op ListImages \
    --namespace $AB_NAMESPACE \
    --q 'CJmbxknT' \
    --sortBy 'updatedAt' \
    --sortDirection 'desc' \
    --count '63' \
    --offset '36' \
    > test.out 2>&1
eval_tap $? 36 'ListImages' test.out

#- 37 DeleteImage
$CLI_EXE \
    --sn dsmc \
    --op DeleteImage \
    --namespace $AB_NAMESPACE \
    --imageURI 'DTvHlMo3' \
    --version 'nm9WLZfB' \
    > test.out 2>&1
eval_tap $? 37 'DeleteImage' test.out

#- 38 ExportImages
$CLI_EXE \
    --sn dsmc \
    --op ExportImages \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 38 'ExportImages' test.out

#- 39 GetImageLimit
$CLI_EXE \
    --sn dsmc \
    --op GetImageLimit \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 39 'GetImageLimit' test.out

#- 40 DeleteImagePatch
$CLI_EXE \
    --sn dsmc \
    --op DeleteImagePatch \
    --namespace $AB_NAMESPACE \
    --imageURI 'G8OlCsKP' \
    --version 'lc9DgxJP' \
    --versionPatch 'P1CU3BlH' \
    > test.out 2>&1
eval_tap $? 40 'DeleteImagePatch' test.out

#- 41 GetImageDetail
$CLI_EXE \
    --sn dsmc \
    --op GetImageDetail \
    --namespace $AB_NAMESPACE \
    --version 'kM8iqjsq' \
    > test.out 2>&1
eval_tap $? 41 'GetImageDetail' test.out

#- 42 GetImagePatches
$CLI_EXE \
    --sn dsmc \
    --op GetImagePatches \
    --namespace $AB_NAMESPACE \
    --version 'KwPwO6rr' \
    > test.out 2>&1
eval_tap $? 42 'GetImagePatches' test.out

#- 43 GetImagePatchDetail
$CLI_EXE \
    --sn dsmc \
    --op GetImagePatchDetail \
    --namespace $AB_NAMESPACE \
    --version 'BuwZKS2k' \
    --versionPatch 'q3jaZ1Ek' \
    > test.out 2>&1
eval_tap $? 43 'GetImagePatchDetail' test.out

#- 44 GetRepository
$CLI_EXE \
    --sn dsmc \
    --op GetRepository \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 44 'GetRepository' test.out

#- 45 ListServer
$CLI_EXE \
    --sn dsmc \
    --op ListServer \
    --namespace $AB_NAMESPACE \
    --region '8ktNlk46' \
    --count '79' \
    --offset '29' \
    > test.out 2>&1
eval_tap $? 45 'ListServer' test.out

#- 46 CountServer
$CLI_EXE \
    --sn dsmc \
    --op CountServer \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 46 'CountServer' test.out

#- 47 CountServerDetailed
$CLI_EXE \
    --sn dsmc \
    --op CountServerDetailed \
    --namespace $AB_NAMESPACE \
    --region 'xkiLdd1s' \
    > test.out 2>&1
eval_tap $? 47 'CountServerDetailed' test.out

#- 48 ListLocalServer
$CLI_EXE \
    --sn dsmc \
    --op ListLocalServer \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 48 'ListLocalServer' test.out

#- 49 DeleteLocalServer
$CLI_EXE \
    --sn dsmc \
    --op DeleteLocalServer \
    --name 'MirtYrau' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 49 'DeleteLocalServer' test.out

#- 50 GetServer
$CLI_EXE \
    --sn dsmc \
    --op GetServer \
    --namespace $AB_NAMESPACE \
    --podName 'EE99LV9k' \
    > test.out 2>&1
eval_tap $? 50 'GetServer' test.out

#- 51 DeleteServer
$CLI_EXE \
    --sn dsmc \
    --op DeleteServer \
    --namespace $AB_NAMESPACE \
    --podName '6DDuZKm5' \
    > test.out 2>&1
eval_tap $? 51 'DeleteServer' test.out

#- 52 ListSession
$CLI_EXE \
    --sn dsmc \
    --op ListSession \
    --namespace $AB_NAMESPACE \
    --region 'NLJodeDh' \
    --withServer 'true' \
    --count '22' \
    --offset '8' \
    > test.out 2>&1
eval_tap $? 52 'ListSession' test.out

#- 53 CountSession
$CLI_EXE \
    --sn dsmc \
    --op CountSession \
    --namespace $AB_NAMESPACE \
    --region 'nBV1uuRZ' \
    > test.out 2>&1
eval_tap $? 53 'CountSession' test.out

#- 54 DeleteSession
$CLI_EXE \
    --sn dsmc \
    --op DeleteSession \
    --namespace $AB_NAMESPACE \
    --sessionID 'sWnaOn4o' \
    > test.out 2>&1
eval_tap $? 54 'DeleteSession' test.out

#- 55 CreateRepository
# body param: body
echo '{"namespace": "ZTZnf4fs", "repository": "1pDwkThs"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreateRepository \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 55 'CreateRepository' test.out

#- 56 ExportConfigV1
$CLI_EXE \
    --sn dsmc \
    --op ExportConfigV1 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 56 'ExportConfigV1' test.out

#- 57 ImportConfigV1
# form data upload: file
echo 'tmp.dat' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --sn dsmc \
    --op ImportConfigV1 \
    --namespace $AB_NAMESPACE \
    --upload file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 57 'ImportConfigV1' test.out

#- 58 GetAllDeploymentClient
$CLI_EXE \
    --sn dsmc \
    --op GetAllDeploymentClient \
    --namespace $AB_NAMESPACE \
    --name '8Ni68x6s' \
    --count '87' \
    --offset '11' \
    > test.out 2>&1
eval_tap $? 58 'GetAllDeploymentClient' test.out

#- 59 CreateDeploymentClient
# body param: body
echo '{"allow_version_override": true, "buffer_count": 43, "buffer_percent": 88, "configuration": "GOV28Isa", "enable_region_overrides": true, "extendable_session": true, "game_version": "HniDeeQX", "max_count": 62, "min_count": 50, "overrides": {"iJ6RNcvw": {"buffer_count": 86, "buffer_percent": 30, "configuration": "wd7H0g31", "enable_region_overrides": true, "extendable_session": true, "game_version": "gHSZv9DE", "max_count": 21, "min_count": 57, "name": "G9nGEReY", "region_overrides": {"9u82LuNv": {"buffer_count": 52, "buffer_percent": 15, "max_count": 87, "min_count": 29, "name": "9Uz9IdLy", "unlimited": true, "use_buffer_percent": true}, "tzNrSdLC": {"buffer_count": 40, "buffer_percent": 53, "max_count": 95, "min_count": 46, "name": "pc9UQc8e", "unlimited": false, "use_buffer_percent": true}, "ANkbseSC": {"buffer_count": 64, "buffer_percent": 44, "max_count": 77, "min_count": 22, "name": "g0sRjCHH", "unlimited": false, "use_buffer_percent": false}}, "regions": ["fFJWHe4W", "YoOv5vt0", "DDYJPmwv"], "session_timeout": 78, "unlimited": false, "use_buffer_percent": false}, "ZQvzIHFp": {"buffer_count": 100, "buffer_percent": 91, "configuration": "3oTcE6bV", "enable_region_overrides": true, "extendable_session": true, "game_version": "tBlPwTGQ", "max_count": 24, "min_count": 37, "name": "53wTFAic", "region_overrides": {"1hx2NbFn": {"buffer_count": 33, "buffer_percent": 97, "max_count": 65, "min_count": 55, "name": "fu5IC3Ph", "unlimited": true, "use_buffer_percent": false}, "CuOyjDEz": {"buffer_count": 30, "buffer_percent": 81, "max_count": 33, "min_count": 24, "name": "yIOSmHCw", "unlimited": true, "use_buffer_percent": false}, "mpKn49MT": {"buffer_count": 78, "buffer_percent": 43, "max_count": 21, "min_count": 65, "name": "Yj6kvzNq", "unlimited": true, "use_buffer_percent": true}}, "regions": ["ZP8HFkwN", "nvpU5lBo", "6SSSOlhF"], "session_timeout": 7, "unlimited": true, "use_buffer_percent": true}, "dVqb4yPR": {"buffer_count": 90, "buffer_percent": 78, "configuration": "yqutJ789", "enable_region_overrides": false, "extendable_session": false, "game_version": "o4WS9fgl", "max_count": 69, "min_count": 74, "name": "MqHYC7gx", "region_overrides": {"CpooOe4W": {"buffer_count": 70, "buffer_percent": 78, "max_count": 38, "min_count": 76, "name": "AyVll2QG", "unlimited": false, "use_buffer_percent": false}, "HqvMtsOm": {"buffer_count": 80, "buffer_percent": 62, "max_count": 7, "min_count": 77, "name": "9UJRNIrM", "unlimited": false, "use_buffer_percent": false}, "ex9Qd1yQ": {"buffer_count": 17, "buffer_percent": 47, "max_count": 79, "min_count": 45, "name": "U7Uk6uTa", "unlimited": false, "use_buffer_percent": false}}, "regions": ["z42apefG", "iyDpA8Mg", "AVPRzoFk"], "session_timeout": 14, "unlimited": true, "use_buffer_percent": true}}, "region_overrides": {"OUAzY9NW": {"buffer_count": 79, "buffer_percent": 73, "max_count": 91, "min_count": 24, "name": "BFV8fEtq", "unlimited": false, "use_buffer_percent": true}, "aAhGIECy": {"buffer_count": 25, "buffer_percent": 49, "max_count": 95, "min_count": 98, "name": "C1tM7zMt", "unlimited": true, "use_buffer_percent": true}, "gBfo0BQY": {"buffer_count": 90, "buffer_percent": 14, "max_count": 49, "min_count": 40, "name": "V15blJO8", "unlimited": true, "use_buffer_percent": false}}, "regions": ["OuPZuak3", "GMY8r3vo", "IH4ylMDN"], "session_timeout": 25, "unlimited": false, "use_buffer_percent": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreateDeploymentClient \
    --deployment 'CS3MkCHx' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 59 'CreateDeploymentClient' test.out

#- 60 DeleteDeploymentClient
$CLI_EXE \
    --sn dsmc \
    --op DeleteDeploymentClient \
    --deployment 'sf7Qv9yN' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 60 'DeleteDeploymentClient' test.out

#- 61 GetAllPodConfigClient
$CLI_EXE \
    --sn dsmc \
    --op GetAllPodConfigClient \
    --namespace $AB_NAMESPACE \
    --count '19' \
    --offset '96' \
    > test.out 2>&1
eval_tap $? 61 'GetAllPodConfigClient' test.out

#- 62 CreatePodConfigClient
# body param: body
echo '{"cpu_limit": 15, "mem_limit": 65, "params": "3RQlJaUG"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreatePodConfigClient \
    --name 'zF6PirYU' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 62 'CreatePodConfigClient' test.out

#- 63 DeletePodConfigClient
$CLI_EXE \
    --sn dsmc \
    --op DeletePodConfigClient \
    --name 'lOtwYWhx' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 63 'DeletePodConfigClient' test.out

#- 64 ListImagesClient
$CLI_EXE \
    --sn dsmc \
    --op ListImagesClient \
    --namespace $AB_NAMESPACE \
    --count '52' \
    --offset '9' \
    --q 'dsBfrCCV' \
    --sortBy 'version' \
    --sortDirection 'desc' \
    > test.out 2>&1
eval_tap $? 64 'ListImagesClient' test.out

#- 65 ImageLimitClient
$CLI_EXE \
    --sn dsmc \
    --op ImageLimitClient \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 65 'ImageLimitClient' test.out

#- 66 ImageDetailClient
$CLI_EXE \
    --sn dsmc \
    --op ImageDetailClient \
    --namespace $AB_NAMESPACE \
    --version '1QRikdrB' \
    > test.out 2>&1
eval_tap $? 66 'ImageDetailClient' test.out

#- 67 ListServerClient
$CLI_EXE \
    --sn dsmc \
    --op ListServerClient \
    --namespace $AB_NAMESPACE \
    --region 'NfA749MS' \
    --count '14' \
    --offset '0' \
    > test.out 2>&1
eval_tap $? 67 'ListServerClient' test.out

#- 68 ServerHeartbeat
# body param: body
echo '{"podName": "sEvoMa55"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op ServerHeartbeat \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 68 'ServerHeartbeat' test.out

#- 69 DeregisterLocalServer
# body param: body
echo '{"name": "ge7gYejH"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op DeregisterLocalServer \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 69 'DeregisterLocalServer' test.out

#- 70 RegisterLocalServer
# body param: body
echo '{"custom_attribute": "cjmqYcAx", "ip": "AgCVVVGn", "name": "nUVl0fhZ", "port": 56}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op RegisterLocalServer \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 70 'RegisterLocalServer' test.out

#- 71 RegisterServer
# body param: body
echo '{"custom_attribute": "way3t1ja", "pod_name": "DN9iOwtb"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op RegisterServer \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 71 'RegisterServer' test.out

#- 72 ShutdownServer
# body param: body
echo '{"kill_me": false, "pod_name": "WBsQMLQO"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op ShutdownServer \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 72 'ShutdownServer' test.out

#- 73 GetServerSessionTimeout
$CLI_EXE \
    --sn dsmc \
    --op GetServerSessionTimeout \
    --namespace $AB_NAMESPACE \
    --podName 'CRWuLV7h' \
    > test.out 2>&1
eval_tap $? 73 'GetServerSessionTimeout' test.out

#- 74 GetServerSession
$CLI_EXE \
    --sn dsmc \
    --op GetServerSession \
    --namespace $AB_NAMESPACE \
    --podName 'GwFX4VGD' \
    > test.out 2>&1
eval_tap $? 74 'GetServerSession' test.out

#- 75 CreateSession
# body param: body
echo '{"client_version": "It2kI2WP", "configuration": "Y0jDca5w", "deployment": "5uTmT1Am", "game_mode": "HDRl3Vgk", "matching_allies": [{"matching_parties": [{"party_attributes": {"GlT1KFGq": {}, "AI7Jbobm": {}, "pRkDnxzT": {}}, "party_id": "wbrEmdYq", "party_members": [{"user_id": "wz2CIxPQ"}, {"user_id": "rM1p8Ix0"}, {"user_id": "S6GhH1ML"}]}, {"party_attributes": {"jCAYk4gi": {}, "JwBSsHpu": {}, "vDFPqtaW": {}}, "party_id": "7xVOgEcM", "party_members": [{"user_id": "zTTAYAF7"}, {"user_id": "8XqSxRS0"}, {"user_id": "77Uozry7"}]}, {"party_attributes": {"CgoHhfKG": {}, "OMYVXhdS": {}, "tj5hb7lA": {}}, "party_id": "E7d6lbVr", "party_members": [{"user_id": "ovnUvmiO"}, {"user_id": "qb0hZsTE"}, {"user_id": "gb0MsFZs"}]}]}, {"matching_parties": [{"party_attributes": {"a6MPDUHT": {}, "oU73LSRK": {}, "BF5cfqJI": {}}, "party_id": "EgsiSOnP", "party_members": [{"user_id": "YCRthGCs"}, {"user_id": "dow1aCy9"}, {"user_id": "xvMcI1TG"}]}, {"party_attributes": {"dkFStR6u": {}, "wW9O9jI9": {}, "T7ohbcTv": {}}, "party_id": "GOtqv7fS", "party_members": [{"user_id": "ow2nXC0X"}, {"user_id": "CELWHnYQ"}, {"user_id": "LOUJjKi8"}]}, {"party_attributes": {"NH8oMftQ": {}, "ntSdhtl8": {}, "VFyYwcPo": {}}, "party_id": "XxDqwGl7", "party_members": [{"user_id": "IN0DXrVC"}, {"user_id": "nz8UbwoW"}, {"user_id": "SsSfX7Xv"}]}]}, {"matching_parties": [{"party_attributes": {"JjKuDDVr": {}, "JxXA9tTh": {}, "VejzZtfl": {}}, "party_id": "6pvkV5rR", "party_members": [{"user_id": "sXPFFVmj"}, {"user_id": "UvlTh3pB"}, {"user_id": "iTB7BVkx"}]}, {"party_attributes": {"1lqncSiX": {}, "VW3DRvvV": {}, "PbBbe9WM": {}}, "party_id": "oBB15QOo", "party_members": [{"user_id": "VVU69hZB"}, {"user_id": "EZ5yuTpq"}, {"user_id": "agvbMt1O"}]}, {"party_attributes": {"y5DhYfMJ": {}, "FJEct3zc": {}, "Bit7WTl1": {}}, "party_id": "EtQETu3t", "party_members": [{"user_id": "VSP5q0X7"}, {"user_id": "zPz9BRCf"}, {"user_id": "8eX6ERM9"}]}]}], "namespace": "RIvvwyAc", "notification_payload": {}, "pod_name": "g1Vosdm3", "region": "tHI3d62c", "session_id": "jR8GyhUg"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op CreateSession \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 75 'CreateSession' test.out

#- 76 ClaimServer
# body param: body
echo '{"session_id": "7oqiMFFz"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn dsmc \
    --op ClaimServer \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 76 'ClaimServer' test.out

#- 77 GetSession
$CLI_EXE \
    --sn dsmc \
    --op GetSession \
    --namespace $AB_NAMESPACE \
    --sessionID '5ifwhCxx' \
    > test.out 2>&1
eval_tap $? 77 'GetSession' test.out

#- 78 CancelSession
$CLI_EXE \
    --sn dsmc \
    --op CancelSession \
    --namespace $AB_NAMESPACE \
    --sessionID 'e2LEqUvN' \
    > test.out 2>&1
eval_tap $? 78 'CancelSession' test.out

#- 79 GetDefaultProvider
$CLI_EXE \
    --sn dsmc \
    --op GetDefaultProvider \
    > test.out 2>&1
eval_tap $? 79 'GetDefaultProvider' test.out

#- 80 ListProviders
$CLI_EXE \
    --sn dsmc \
    --op ListProviders \
    > test.out 2>&1
eval_tap $? 80 'ListProviders' test.out

#- 81 ListProvidersByRegion
$CLI_EXE \
    --sn dsmc \
    --op ListProvidersByRegion \
    --region 'qBxrQDPA' \
    > test.out 2>&1
eval_tap $? 81 'ListProvidersByRegion' test.out

#- 82 PublicGetMessages
$CLI_EXE \
    --sn dsmc \
    --op PublicGetMessages \
    > test.out 2>&1
eval_tap $? 82 'PublicGetMessages' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE