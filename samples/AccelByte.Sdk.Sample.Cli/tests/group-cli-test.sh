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

#- 2 ListGroupConfigurationAdminV1
$CLI_EXE \
    --sn group \
    --op ListGroupConfigurationAdminV1 \
    --namespace $AB_NAMESPACE \
    --limit '48' \
    --offset '59' \
    > test.out 2>&1
eval_tap $? 2 'ListGroupConfigurationAdminV1' test.out

#- 3 CreateGroupConfigurationAdminV1
# body param: body
echo '{"allowMultiple": false, "configurationCode": "qttKEMCv", "description": "wbkY3sTM", "globalRules": [{"allowedAction": "M2BpsjOk", "ruleDetail": [{"ruleAttribute": "3Bn5s3sP", "ruleCriteria": "MINIMUM", "ruleValue": 0.8564355873307923}, {"ruleAttribute": "1aQKSiaq", "ruleCriteria": "MAXIMUM", "ruleValue": 0.6835566411612561}, {"ruleAttribute": "YySFVA0j", "ruleCriteria": "EQUAL", "ruleValue": 0.35539645349889526}]}, {"allowedAction": "CEry9Gl4", "ruleDetail": [{"ruleAttribute": "YjxwZf5I", "ruleCriteria": "MINIMUM", "ruleValue": 0.8531803307976851}, {"ruleAttribute": "tIx3OSmc", "ruleCriteria": "EQUAL", "ruleValue": 0.4140514683162855}, {"ruleAttribute": "8IFBEJ6U", "ruleCriteria": "MAXIMUM", "ruleValue": 0.3358083329194267}]}, {"allowedAction": "eFNLeCsD", "ruleDetail": [{"ruleAttribute": "VysFWp5Z", "ruleCriteria": "MAXIMUM", "ruleValue": 0.22844143559581476}, {"ruleAttribute": "GCIOKA0O", "ruleCriteria": "MINIMUM", "ruleValue": 0.29076495190451446}, {"ruleAttribute": "dU1q9tq1", "ruleCriteria": "MAXIMUM", "ruleValue": 0.48246967867750035}]}], "groupAdminRoleId": "PwnpTFfb", "groupMaxMember": 58, "groupMemberRoleId": "x0Qq9E2k", "name": "2xhclD4X"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op CreateGroupConfigurationAdminV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 3 'CreateGroupConfigurationAdminV1' test.out

#- 4 InitiateGroupConfigurationAdminV1
$CLI_EXE \
    --sn group \
    --op InitiateGroupConfigurationAdminV1 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 4 'InitiateGroupConfigurationAdminV1' test.out

#- 5 GetGroupConfigurationAdminV1
$CLI_EXE \
    --sn group \
    --op GetGroupConfigurationAdminV1 \
    --configurationCode 'Wb91z3uV' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 5 'GetGroupConfigurationAdminV1' test.out

#- 6 DeleteGroupConfigurationV1
$CLI_EXE \
    --sn group \
    --op DeleteGroupConfigurationV1 \
    --configurationCode 'ea6hsCiM' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 6 'DeleteGroupConfigurationV1' test.out

#- 7 UpdateGroupConfigurationAdminV1
# body param: body
echo '{"description": "Bekf6555", "groupMaxMember": 8, "name": "i4REWbaw"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateGroupConfigurationAdminV1 \
    --configurationCode 'opDp0KJ0' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 7 'UpdateGroupConfigurationAdminV1' test.out

#- 8 UpdateGroupConfigurationGlobalRuleAdminV1
# body param: body
echo '{"ruleDetail": [{"ruleAttribute": "rGPfjfCY", "ruleCriteria": "MINIMUM", "ruleValue": 0.4210025127153373}, {"ruleAttribute": "pFjfMMP4", "ruleCriteria": "MAXIMUM", "ruleValue": 0.21252701628356774}, {"ruleAttribute": "C3Hxhn9K", "ruleCriteria": "MINIMUM", "ruleValue": 0.5322120355120062}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateGroupConfigurationGlobalRuleAdminV1 \
    --allowedAction 'BQLdjyn6' \
    --configurationCode 'ziiUT4Fj' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 8 'UpdateGroupConfigurationGlobalRuleAdminV1' test.out

#- 9 DeleteGroupConfigurationGlobalRuleAdminV1
$CLI_EXE \
    --sn group \
    --op DeleteGroupConfigurationGlobalRuleAdminV1 \
    --allowedAction 'jxpRj8Sg' \
    --configurationCode '99vB9xM0' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 9 'DeleteGroupConfigurationGlobalRuleAdminV1' test.out

#- 10 GetGroupListAdminV1
$CLI_EXE \
    --sn group \
    --op GetGroupListAdminV1 \
    --namespace $AB_NAMESPACE \
    --configurationCode 'jo3WJ9tk' \
    --groupName 'CK69CZm9' \
    --groupRegion '8NWaZemD' \
    --limit '96' \
    --offset '90' \
    > test.out 2>&1
eval_tap $? 10 'GetGroupListAdminV1' test.out

#- 11 GetSingleGroupAdminV1
$CLI_EXE \
    --sn group \
    --op GetSingleGroupAdminV1 \
    --groupId 'x61E57Lr' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 11 'GetSingleGroupAdminV1' test.out

#- 12 DeleteGroupAdminV1
$CLI_EXE \
    --sn group \
    --op DeleteGroupAdminV1 \
    --groupId '6n2hbNge' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 12 'DeleteGroupAdminV1' test.out

#- 13 GetGroupMembersListAdminV1
$CLI_EXE \
    --sn group \
    --op GetGroupMembersListAdminV1 \
    --groupId 'zqDy8FWS' \
    --namespace $AB_NAMESPACE \
    --limit '91' \
    --offset '4' \
    --order 'nMugdxZs' \
    > test.out 2>&1
eval_tap $? 13 'GetGroupMembersListAdminV1' test.out

#- 14 GetMemberRolesListAdminV1
$CLI_EXE \
    --sn group \
    --op GetMemberRolesListAdminV1 \
    --namespace $AB_NAMESPACE \
    --limit '53' \
    --offset '81' \
    > test.out 2>&1
eval_tap $? 14 'GetMemberRolesListAdminV1' test.out

#- 15 CreateMemberRoleAdminV1
# body param: body
echo '{"memberRoleName": "ZJRmeXkv", "memberRolePermissions": [{"action": 79, "resourceName": "xkReBg8m"}, {"action": 70, "resourceName": "GkAjnEU4"}, {"action": 88, "resourceName": "RcVOaGzE"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op CreateMemberRoleAdminV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 15 'CreateMemberRoleAdminV1' test.out

#- 16 GetSingleMemberRoleAdminV1
$CLI_EXE \
    --sn group \
    --op GetSingleMemberRoleAdminV1 \
    --memberRoleId 'FBIQYMnR' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 16 'GetSingleMemberRoleAdminV1' test.out

#- 17 DeleteMemberRoleAdminV1
$CLI_EXE \
    --sn group \
    --op DeleteMemberRoleAdminV1 \
    --memberRoleId 'fjGm5BL4' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 17 'DeleteMemberRoleAdminV1' test.out

#- 18 UpdateMemberRoleAdminV1
# body param: body
echo '{"memberRoleName": "hQPN4z9E"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateMemberRoleAdminV1 \
    --memberRoleId 'q4ISxE8J' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 18 'UpdateMemberRoleAdminV1' test.out

#- 19 UpdateMemberRolePermissionAdminV1
# body param: body
echo '{"memberRolePermissions": [{"action": 44, "resourceName": "XKwJW1j1"}, {"action": 88, "resourceName": "RcdmYu2N"}, {"action": 78, "resourceName": "NkwcA4Zc"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateMemberRolePermissionAdminV1 \
    --memberRoleId 'EfjUwClt' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 19 'UpdateMemberRolePermissionAdminV1' test.out

#- 20 GetGroupListPublicV1
$CLI_EXE \
    --sn group \
    --op GetGroupListPublicV1 \
    --namespace $AB_NAMESPACE \
    --groupName '5xyl8sEI' \
    --groupRegion 'NAXGD9UR' \
    --limit '5' \
    --offset '35' \
    > test.out 2>&1
eval_tap $? 20 'GetGroupListPublicV1' test.out

#- 21 CreateNewGroupPublicV1
# body param: body
echo '{"configurationCode": "no1ZmDqR", "customAttributes": {"wEf80vCI": {}, "QbqEMZMo": {}, "GatCrMVR": {}}, "groupDescription": "tcYGZ0WQ", "groupIcon": "gKMfom1Q", "groupMaxMember": 64, "groupName": "Orm2nQxx", "groupRegion": "GjqQe2sN", "groupRules": {"groupCustomRule": {}, "groupPredefinedRules": [{"allowedAction": "ec49U8bJ", "ruleDetail": [{"ruleAttribute": "ZFygjCw2", "ruleCriteria": "MINIMUM", "ruleValue": 0.9362851772655587}, {"ruleAttribute": "Fs7Ma1U7", "ruleCriteria": "MAXIMUM", "ruleValue": 0.9904800500214622}, {"ruleAttribute": "X9XHN4Vb", "ruleCriteria": "MINIMUM", "ruleValue": 0.08340272195599707}]}, {"allowedAction": "FXML75NL", "ruleDetail": [{"ruleAttribute": "tPodiDgo", "ruleCriteria": "MAXIMUM", "ruleValue": 0.09293001094516917}, {"ruleAttribute": "T3CLm0RH", "ruleCriteria": "EQUAL", "ruleValue": 0.9884022128967728}, {"ruleAttribute": "yxTrP5fU", "ruleCriteria": "EQUAL", "ruleValue": 0.7011184841035637}]}, {"allowedAction": "9QgJNoMI", "ruleDetail": [{"ruleAttribute": "E72icNzW", "ruleCriteria": "MAXIMUM", "ruleValue": 0.9329080059164294}, {"ruleAttribute": "Y2xI6lZT", "ruleCriteria": "EQUAL", "ruleValue": 0.06942586068109602}, {"ruleAttribute": "fUrf1tSO", "ruleCriteria": "EQUAL", "ruleValue": 0.04415025774886028}]}]}, "groupType": "PUBLIC"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op CreateNewGroupPublicV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 21 'CreateNewGroupPublicV1' test.out

#- 22 GetSingleGroupPublicV1
$CLI_EXE \
    --sn group \
    --op GetSingleGroupPublicV1 \
    --groupId 'VlltF1xS' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 22 'GetSingleGroupPublicV1' test.out

#- 23 UpdateSingleGroupV1
# body param: body
echo '{"customAttributes": {}, "groupDescription": "YKTbBjOQ", "groupIcon": "Hkvx2Btd", "groupName": "p5E1fqtw", "groupRegion": "SyiLPnl0", "groupType": "PRIVATE"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateSingleGroupV1 \
    --groupId 'sgXYy1Ff' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 23 'UpdateSingleGroupV1' test.out

#- 24 DeleteGroupPublicV1
$CLI_EXE \
    --sn group \
    --op DeleteGroupPublicV1 \
    --groupId 'CoZMmtVh' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 24 'DeleteGroupPublicV1' test.out

#- 25 UpdatePatchSingleGroupPublicV1
# body param: body
echo '{"customAttributes": {}, "groupDescription": "fpQ7fzPe", "groupIcon": "ERbEfKVb", "groupName": "YQ9aMYvt", "groupRegion": "diKL0st6", "groupType": "PUBLIC"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdatePatchSingleGroupPublicV1 \
    --groupId '9bhtDgI4' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 25 'UpdatePatchSingleGroupPublicV1' test.out

#- 26 UpdateGroupCustomAttributesPublicV1
# body param: body
echo '{"customAttributes": {"ImFQtIMc": {}, "bz12669k": {}, "MdNqrv3g": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateGroupCustomAttributesPublicV1 \
    --groupId 'ZDjBN1Yd' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 26 'UpdateGroupCustomAttributesPublicV1' test.out

#- 27 AcceptGroupInvitationPublicV1
$CLI_EXE \
    --sn group \
    --op AcceptGroupInvitationPublicV1 \
    --groupId 'Hw8ut1Zm' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 27 'AcceptGroupInvitationPublicV1' test.out

#- 28 RejectGroupInvitationPublicV1
$CLI_EXE \
    --sn group \
    --op RejectGroupInvitationPublicV1 \
    --groupId 'xpfKhTp2' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 28 'RejectGroupInvitationPublicV1' test.out

#- 29 JoinGroupV1
$CLI_EXE \
    --sn group \
    --op JoinGroupV1 \
    --groupId 'E3ZrcXiF' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 29 'JoinGroupV1' test.out

#- 30 CancelGroupJoinRequestV1
$CLI_EXE \
    --sn group \
    --op CancelGroupJoinRequestV1 \
    --groupId 'rEs9FAxi' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 30 'CancelGroupJoinRequestV1' test.out

#- 31 GetGroupJoinRequestPublicV1
$CLI_EXE \
    --sn group \
    --op GetGroupJoinRequestPublicV1 \
    --groupId 'AFnN7AJB' \
    --namespace $AB_NAMESPACE \
    --limit '80' \
    --offset '57' \
    > test.out 2>&1
eval_tap $? 31 'GetGroupJoinRequestPublicV1' test.out

#- 32 GetGroupMembersListPublicV1
$CLI_EXE \
    --sn group \
    --op GetGroupMembersListPublicV1 \
    --groupId 'h5cx5OzT' \
    --namespace $AB_NAMESPACE \
    --limit '32' \
    --offset '79' \
    --order 'EivwKIcG' \
    > test.out 2>&1
eval_tap $? 32 'GetGroupMembersListPublicV1' test.out

#- 33 UpdateGroupCustomRulePublicV1
# body param: body
echo '{"groupCustomRule": {"n6di0SPL": {}, "kS3LmwnO": {}, "a8OlnlEh": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateGroupCustomRulePublicV1 \
    --groupId 'LDRomDAb' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 33 'UpdateGroupCustomRulePublicV1' test.out

#- 34 UpdateGroupPredefinedRulePublicV1
# body param: body
echo '{"ruleDetail": [{"ruleAttribute": "TMWhvKEn", "ruleCriteria": "EQUAL", "ruleValue": 0.8210389271002932}, {"ruleAttribute": "4PjCU5LJ", "ruleCriteria": "MAXIMUM", "ruleValue": 0.06947001820261789}, {"ruleAttribute": "8dMyorCa", "ruleCriteria": "EQUAL", "ruleValue": 0.7119645390500912}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateGroupPredefinedRulePublicV1 \
    --allowedAction 'GAugCQWW' \
    --groupId 'sIzfYO4g' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 34 'UpdateGroupPredefinedRulePublicV1' test.out

#- 35 DeleteGroupPredefinedRulePublicV1
$CLI_EXE \
    --sn group \
    --op DeleteGroupPredefinedRulePublicV1 \
    --allowedAction '4NMtGe1y' \
    --groupId 'JLqNQKAo' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 35 'DeleteGroupPredefinedRulePublicV1' test.out

#- 36 LeaveGroupPublicV1
$CLI_EXE \
    --sn group \
    --op LeaveGroupPublicV1 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 36 'LeaveGroupPublicV1' test.out

#- 37 GetMemberRolesListPublicV1
$CLI_EXE \
    --sn group \
    --op GetMemberRolesListPublicV1 \
    --namespace $AB_NAMESPACE \
    --limit '19' \
    --offset '75' \
    > test.out 2>&1
eval_tap $? 37 'GetMemberRolesListPublicV1' test.out

#- 38 UpdateMemberRolePublicV1
# body param: body
echo '{"userId": "BKKbpRbJ"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateMemberRolePublicV1 \
    --memberRoleId 'ikFAFzkp' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 38 'UpdateMemberRolePublicV1' test.out

#- 39 DeleteMemberRolePublicV1
# body param: body
echo '{"userId": "d1tKcorv"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op DeleteMemberRolePublicV1 \
    --memberRoleId 'zGxfvjAA' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 39 'DeleteMemberRolePublicV1' test.out

#- 40 GetGroupInvitationRequestPublicV1
$CLI_EXE \
    --sn group \
    --op GetGroupInvitationRequestPublicV1 \
    --namespace $AB_NAMESPACE \
    --limit '95' \
    --offset '0' \
    > test.out 2>&1
eval_tap $? 40 'GetGroupInvitationRequestPublicV1' test.out

#- 41 GetUserGroupInformationPublicV1
$CLI_EXE \
    --sn group \
    --op GetUserGroupInformationPublicV1 \
    --namespace $AB_NAMESPACE \
    --userId '8awKvMPe' \
    > test.out 2>&1
eval_tap $? 41 'GetUserGroupInformationPublicV1' test.out

#- 42 InviteGroupPublicV1
$CLI_EXE \
    --sn group \
    --op InviteGroupPublicV1 \
    --namespace $AB_NAMESPACE \
    --userId 'fAg1KcOL' \
    > test.out 2>&1
eval_tap $? 42 'InviteGroupPublicV1' test.out

#- 43 AcceptGroupJoinRequestPublicV1
$CLI_EXE \
    --sn group \
    --op AcceptGroupJoinRequestPublicV1 \
    --namespace $AB_NAMESPACE \
    --userId 'cfYlpgAK' \
    > test.out 2>&1
eval_tap $? 43 'AcceptGroupJoinRequestPublicV1' test.out

#- 44 RejectGroupJoinRequestPublicV1
$CLI_EXE \
    --sn group \
    --op RejectGroupJoinRequestPublicV1 \
    --namespace $AB_NAMESPACE \
    --userId 'BsZz74F6' \
    > test.out 2>&1
eval_tap $? 44 'RejectGroupJoinRequestPublicV1' test.out

#- 45 KickGroupMemberPublicV1
$CLI_EXE \
    --sn group \
    --op KickGroupMemberPublicV1 \
    --namespace $AB_NAMESPACE \
    --userId 'bDp34ae3' \
    > test.out 2>&1
eval_tap $? 45 'KickGroupMemberPublicV1' test.out

#- 46 GetListGroupByIDsAdminV2
# body param: body
echo '{"groupIDs": ["mIaYrTTn", "olW56ubW", "oMcZs2ER"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op GetListGroupByIDsAdminV2 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 46 'GetListGroupByIDsAdminV2' test.out

#- 47 GetUserJoinedGroupInformationPublicV2
$CLI_EXE \
    --sn group \
    --op GetUserJoinedGroupInformationPublicV2 \
    --namespace $AB_NAMESPACE \
    --userId '9McMhKKO' \
    --limit '18' \
    --offset '100' \
    > test.out 2>&1
eval_tap $? 47 'GetUserJoinedGroupInformationPublicV2' test.out

#- 48 AdminGetUserGroupStatusInformationV2
$CLI_EXE \
    --sn group \
    --op AdminGetUserGroupStatusInformationV2 \
    --groupId 'mFZXCNAK' \
    --namespace $AB_NAMESPACE \
    --userId 'ow8hdkBr' \
    > test.out 2>&1
eval_tap $? 48 'AdminGetUserGroupStatusInformationV2' test.out

#- 49 CreateNewGroupPublicV2
# body param: body
echo '{"configurationCode": "oY11UuJ8", "customAttributes": {"4jpBfedf": {}, "jSCwwG7T": {}, "DdyBWYyK": {}}, "groupDescription": "XXGnXyuS", "groupIcon": "b3S1l8xz", "groupMaxMember": 95, "groupName": "lOW6aWKv", "groupRegion": "skFRnFMV", "groupRules": {"groupCustomRule": {}, "groupPredefinedRules": [{"allowedAction": "BR1wiHAg", "ruleDetail": [{"ruleAttribute": "XRoRw5q8", "ruleCriteria": "MINIMUM", "ruleValue": 0.8217534400611074}, {"ruleAttribute": "kTRaizRS", "ruleCriteria": "EQUAL", "ruleValue": 0.11230130816610884}, {"ruleAttribute": "Q6UkyToc", "ruleCriteria": "MAXIMUM", "ruleValue": 0.8455824839034227}]}, {"allowedAction": "3trZyZES", "ruleDetail": [{"ruleAttribute": "h2yslGJ9", "ruleCriteria": "EQUAL", "ruleValue": 0.45924771705855283}, {"ruleAttribute": "6hgkNIW5", "ruleCriteria": "MAXIMUM", "ruleValue": 0.5283357121729708}, {"ruleAttribute": "CYPoOj5r", "ruleCriteria": "MINIMUM", "ruleValue": 0.17050399790451143}]}, {"allowedAction": "Q3KXuALy", "ruleDetail": [{"ruleAttribute": "XsIPHhk3", "ruleCriteria": "EQUAL", "ruleValue": 0.5396339039539143}, {"ruleAttribute": "aREjNNbp", "ruleCriteria": "EQUAL", "ruleValue": 0.19156034567737834}, {"ruleAttribute": "IfnI4np1", "ruleCriteria": "MINIMUM", "ruleValue": 0.9140830938035316}]}]}, "groupType": "PUBLIC"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op CreateNewGroupPublicV2 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 49 'CreateNewGroupPublicV2' test.out

#- 50 GetListGroupByIDsV2
# body param: body
echo '{"groupIDs": ["ZJtqOYxc", "DHh7Enn5", "My8JFgpl"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op GetListGroupByIDsV2 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 50 'GetListGroupByIDsV2' test.out

#- 51 UpdatePutSingleGroupPublicV2
# body param: body
echo '{"customAttributes": {}, "groupDescription": "aUNuybPu", "groupIcon": "he73zm3a", "groupName": "7NRHBDHn", "groupRegion": "ZOrMQs0T", "groupType": "OPEN"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdatePutSingleGroupPublicV2 \
    --groupId 'HzT4VspT' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 51 'UpdatePutSingleGroupPublicV2' test.out

#- 52 DeleteGroupPublicV2
$CLI_EXE \
    --sn group \
    --op DeleteGroupPublicV2 \
    --groupId 'zuu9JrWh' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 52 'DeleteGroupPublicV2' test.out

#- 53 UpdatePatchSingleGroupPublicV2
# body param: body
echo '{"customAttributes": {}, "groupDescription": "uAdcpsla", "groupIcon": "PxpAAUuU", "groupName": "rfVBPJuK", "groupRegion": "MZZHyOpY", "groupType": "PUBLIC"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdatePatchSingleGroupPublicV2 \
    --groupId 'DGqj8Alm' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 53 'UpdatePatchSingleGroupPublicV2' test.out

#- 54 UpdateGroupCustomAttributesPublicV2
# body param: body
echo '{"customAttributes": {"dGKaS8kS": {}, "vLSzbbWI": {}, "39a43C6E": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateGroupCustomAttributesPublicV2 \
    --groupId '3KyjYLfj' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 54 'UpdateGroupCustomAttributesPublicV2' test.out

#- 55 AcceptGroupInvitationPublicV2
$CLI_EXE \
    --sn group \
    --op AcceptGroupInvitationPublicV2 \
    --groupId '6T5gtrqo' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 55 'AcceptGroupInvitationPublicV2' test.out

#- 56 RejectGroupInvitationPublicV2
$CLI_EXE \
    --sn group \
    --op RejectGroupInvitationPublicV2 \
    --groupId 'sZXp58NW' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 56 'RejectGroupInvitationPublicV2' test.out

#- 57 GetGroupInviteRequestPublicV2
$CLI_EXE \
    --sn group \
    --op GetGroupInviteRequestPublicV2 \
    --groupId 'kvsPeriH' \
    --namespace $AB_NAMESPACE \
    --limit '46' \
    --offset '87' \
    > test.out 2>&1
eval_tap $? 57 'GetGroupInviteRequestPublicV2' test.out

#- 58 JoinGroupV2
$CLI_EXE \
    --sn group \
    --op JoinGroupV2 \
    --groupId 'ZBI0ksox' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 58 'JoinGroupV2' test.out

#- 59 GetGroupJoinRequestPublicV2
$CLI_EXE \
    --sn group \
    --op GetGroupJoinRequestPublicV2 \
    --groupId '5B3fOfoP' \
    --namespace $AB_NAMESPACE \
    --limit '98' \
    --offset '36' \
    > test.out 2>&1
eval_tap $? 59 'GetGroupJoinRequestPublicV2' test.out

#- 60 LeaveGroupPublicV2
$CLI_EXE \
    --sn group \
    --op LeaveGroupPublicV2 \
    --groupId 'n0UAqi37' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 60 'LeaveGroupPublicV2' test.out

#- 61 UpdateGroupCustomRulePublicV2
# body param: body
echo '{"groupCustomRule": {"GeurgAMW": {}, "GrGoFbQ4": {}, "nIAaOxej": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateGroupCustomRulePublicV2 \
    --groupId 'eDFzTDlM' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 61 'UpdateGroupCustomRulePublicV2' test.out

#- 62 UpdateGroupPredefinedRulePublicV2
# body param: body
echo '{"ruleDetail": [{"ruleAttribute": "ErvjndzZ", "ruleCriteria": "MAXIMUM", "ruleValue": 0.37329601006733504}, {"ruleAttribute": "CxPRvPnl", "ruleCriteria": "EQUAL", "ruleValue": 0.6464732097750294}, {"ruleAttribute": "4VeO8WYq", "ruleCriteria": "EQUAL", "ruleValue": 0.38745746645684154}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateGroupPredefinedRulePublicV2 \
    --allowedAction 'bFwL3k2k' \
    --groupId '9O2j4pXV' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 62 'UpdateGroupPredefinedRulePublicV2' test.out

#- 63 DeleteGroupPredefinedRulePublicV2
$CLI_EXE \
    --sn group \
    --op DeleteGroupPredefinedRulePublicV2 \
    --allowedAction 'N9j1kquZ' \
    --groupId '6yoMxltg' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 63 'DeleteGroupPredefinedRulePublicV2' test.out

#- 64 GetMemberRolesListPublicV2
$CLI_EXE \
    --sn group \
    --op GetMemberRolesListPublicV2 \
    --namespace $AB_NAMESPACE \
    --limit '69' \
    --offset '39' \
    > test.out 2>&1
eval_tap $? 64 'GetMemberRolesListPublicV2' test.out

#- 65 UpdateMemberRolePublicV2
# body param: body
echo '{"userId": "xhnfDFFD"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateMemberRolePublicV2 \
    --groupId 'StUiY8KQ' \
    --memberRoleId 'qknCDL2p' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 65 'UpdateMemberRolePublicV2' test.out

#- 66 DeleteMemberRolePublicV2
# body param: body
echo '{"userId": "S4OhPzmA"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op DeleteMemberRolePublicV2 \
    --groupId 'cNPOORab' \
    --memberRoleId 'HSajhooU' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 66 'DeleteMemberRolePublicV2' test.out

#- 67 GetUserGroupInformationPublicV2
$CLI_EXE \
    --sn group \
    --op GetUserGroupInformationPublicV2 \
    --namespace $AB_NAMESPACE \
    --limit '68' \
    --offset '47' \
    > test.out 2>&1
eval_tap $? 67 'GetUserGroupInformationPublicV2' test.out

#- 68 GetMyGroupJoinRequestV2
$CLI_EXE \
    --sn group \
    --op GetMyGroupJoinRequestV2 \
    --namespace $AB_NAMESPACE \
    --limit '42' \
    --offset '96' \
    > test.out 2>&1
eval_tap $? 68 'GetMyGroupJoinRequestV2' test.out

#- 69 InviteGroupPublicV2
$CLI_EXE \
    --sn group \
    --op InviteGroupPublicV2 \
    --groupId 'rPnuL3so' \
    --namespace $AB_NAMESPACE \
    --userId 'HpLTgVZd' \
    > test.out 2>&1
eval_tap $? 69 'InviteGroupPublicV2' test.out

#- 70 CancelInvitationGroupMemberV2
$CLI_EXE \
    --sn group \
    --op CancelInvitationGroupMemberV2 \
    --groupId 'yrvBEICW' \
    --namespace $AB_NAMESPACE \
    --userId '1OLVX11l' \
    > test.out 2>&1
eval_tap $? 70 'CancelInvitationGroupMemberV2' test.out

#- 71 AcceptGroupJoinRequestPublicV2
$CLI_EXE \
    --sn group \
    --op AcceptGroupJoinRequestPublicV2 \
    --groupId 'WfLryTrg' \
    --namespace $AB_NAMESPACE \
    --userId 'auXaqfg9' \
    > test.out 2>&1
eval_tap $? 71 'AcceptGroupJoinRequestPublicV2' test.out

#- 72 RejectGroupJoinRequestPublicV2
$CLI_EXE \
    --sn group \
    --op RejectGroupJoinRequestPublicV2 \
    --groupId 'SlRyrSyd' \
    --namespace $AB_NAMESPACE \
    --userId 'QBvNeq07' \
    > test.out 2>&1
eval_tap $? 72 'RejectGroupJoinRequestPublicV2' test.out

#- 73 KickGroupMemberPublicV2
$CLI_EXE \
    --sn group \
    --op KickGroupMemberPublicV2 \
    --groupId '4WgqoivX' \
    --namespace $AB_NAMESPACE \
    --userId 'tlpaKBs7' \
    > test.out 2>&1
eval_tap $? 73 'KickGroupMemberPublicV2' test.out

#- 74 GetUserGroupStatusInformationV2
$CLI_EXE \
    --sn group \
    --op GetUserGroupStatusInformationV2 \
    --groupId 'lz21pAKn' \
    --namespace $AB_NAMESPACE \
    --userId 'UY6jrtcZ' \
    > test.out 2>&1
eval_tap $? 74 'GetUserGroupStatusInformationV2' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE