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

#- 2 IndexHandler
$CLI_EXE \
    --sn group \
    --op IndexHandler \
    > test.out 2>&1
eval_tap $? 2 'IndexHandler' test.out

#- 3 BlockHandler
$CLI_EXE \
    --sn group \
    --op BlockHandler \
    > test.out 2>&1
eval_tap $? 3 'BlockHandler' test.out

#- 4 CmdlineHandler
$CLI_EXE \
    --sn group \
    --op CmdlineHandler \
    > test.out 2>&1
eval_tap $? 4 'CmdlineHandler' test.out

#- 5 GoroutineHandler
$CLI_EXE \
    --sn group \
    --op GoroutineHandler \
    > test.out 2>&1
eval_tap $? 5 'GoroutineHandler' test.out

#- 6 HeapHandler
$CLI_EXE \
    --sn group \
    --op HeapHandler \
    > test.out 2>&1
eval_tap $? 6 'HeapHandler' test.out

#- 7 Profile
$CLI_EXE \
    --sn group \
    --op Profile \
    > test.out 2>&1
eval_tap $? 7 'Profile' test.out

#- 8 SymbolHandler
$CLI_EXE \
    --sn group \
    --op SymbolHandler \
    > test.out 2>&1
eval_tap $? 8 'SymbolHandler' test.out

#- 9 ThreadcreateHandler
$CLI_EXE \
    --sn group \
    --op ThreadcreateHandler \
    > test.out 2>&1
eval_tap $? 9 'ThreadcreateHandler' test.out

#- 10 ListGroupConfigurationAdminV1
$CLI_EXE \
    --sn group \
    --op ListGroupConfigurationAdminV1 \
    --namespace $AB_NAMESPACE \
    --limit '30' \
    --offset '23' \
    > test.out 2>&1
eval_tap $? 10 'ListGroupConfigurationAdminV1' test.out

#- 11 CreateGroupConfigurationAdminV1
# body param: body
echo '{"allowMultiple": true, "configurationCode": "keu0TEg8", "description": "zJ9pD7bb", "globalRules": [{"allowedAction": "s9GZpnvs", "ruleDetail": [{"ruleAttribute": "SUEXZRqk", "ruleCriteria": "MAXIMUM", "ruleValue": 0.674558183049541}, {"ruleAttribute": "H7V437B1", "ruleCriteria": "MAXIMUM", "ruleValue": 0.11179628958797294}, {"ruleAttribute": "oiTg67dO", "ruleCriteria": "MAXIMUM", "ruleValue": 0.5230276995564913}]}, {"allowedAction": "19oKPTJp", "ruleDetail": [{"ruleAttribute": "vOf5Pqlw", "ruleCriteria": "MINIMUM", "ruleValue": 0.5140042894788933}, {"ruleAttribute": "tpDLTfC7", "ruleCriteria": "MAXIMUM", "ruleValue": 0.8231356238723327}, {"ruleAttribute": "MSD4ZwR0", "ruleCriteria": "MINIMUM", "ruleValue": 0.1776485560771489}]}, {"allowedAction": "pvM5BzLm", "ruleDetail": [{"ruleAttribute": "qdxFcCPL", "ruleCriteria": "EQUAL", "ruleValue": 0.8634768802280807}, {"ruleAttribute": "mNqYBYi4", "ruleCriteria": "MAXIMUM", "ruleValue": 0.9691659700189421}, {"ruleAttribute": "bsPoBHur", "ruleCriteria": "EQUAL", "ruleValue": 0.02993115686841563}]}], "groupAdminRoleId": "LJeQ7lqu", "groupMaxMember": 45, "groupMemberRoleId": "DjBvfrS8", "name": "S10qfJvP"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op CreateGroupConfigurationAdminV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 11 'CreateGroupConfigurationAdminV1' test.out

#- 12 InitiateGroupConfigurationAdminV1
$CLI_EXE \
    --sn group \
    --op InitiateGroupConfigurationAdminV1 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 12 'InitiateGroupConfigurationAdminV1' test.out

#- 13 GetGroupConfigurationAdminV1
$CLI_EXE \
    --sn group \
    --op GetGroupConfigurationAdminV1 \
    --configurationCode 'QlAGY9x6' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 13 'GetGroupConfigurationAdminV1' test.out

#- 14 DeleteGroupConfigurationV1
$CLI_EXE \
    --sn group \
    --op DeleteGroupConfigurationV1 \
    --configurationCode 'sYP4PE1O' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 14 'DeleteGroupConfigurationV1' test.out

#- 15 UpdateGroupConfigurationAdminV1
# body param: body
echo '{"description": "yzhCVMZk", "groupMaxMember": 80, "name": "gcuZm4qU"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateGroupConfigurationAdminV1 \
    --configurationCode 'icshGW42' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 15 'UpdateGroupConfigurationAdminV1' test.out

#- 16 UpdateGroupConfigurationGlobalRuleAdminV1
# body param: body
echo '{"ruleDetail": [{"ruleAttribute": "afxKT76k", "ruleCriteria": "MINIMUM", "ruleValue": 0.09043992275716062}, {"ruleAttribute": "lBXX7mlc", "ruleCriteria": "EQUAL", "ruleValue": 0.26296853252995755}, {"ruleAttribute": "lIpGM5oe", "ruleCriteria": "MINIMUM", "ruleValue": 0.3283529884752998}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateGroupConfigurationGlobalRuleAdminV1 \
    --allowedAction 'TtJ1efvI' \
    --configurationCode 'rCsF6Heo' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 16 'UpdateGroupConfigurationGlobalRuleAdminV1' test.out

#- 17 DeleteGroupConfigurationGlobalRuleAdminV1
$CLI_EXE \
    --sn group \
    --op DeleteGroupConfigurationGlobalRuleAdminV1 \
    --allowedAction 'RWlFGv4v' \
    --configurationCode 'D25xwIna' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 17 'DeleteGroupConfigurationGlobalRuleAdminV1' test.out

#- 18 GetGroupListAdminV1
$CLI_EXE \
    --sn group \
    --op GetGroupListAdminV1 \
    --namespace $AB_NAMESPACE \
    --configurationCode '2SjyFCht' \
    --groupName '6Q9ZxgUR' \
    --groupRegion 'mK5fMVuz' \
    --limit '23' \
    --offset '0' \
    > test.out 2>&1
eval_tap $? 18 'GetGroupListAdminV1' test.out

#- 19 GetSingleGroupAdminV1
$CLI_EXE \
    --sn group \
    --op GetSingleGroupAdminV1 \
    --groupId '6oyL0984' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 19 'GetSingleGroupAdminV1' test.out

#- 20 DeleteGroupAdminV1
$CLI_EXE \
    --sn group \
    --op DeleteGroupAdminV1 \
    --groupId 'x2NhO2I6' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 20 'DeleteGroupAdminV1' test.out

#- 21 GetGroupMembersListAdminV1
$CLI_EXE \
    --sn group \
    --op GetGroupMembersListAdminV1 \
    --groupId '4NHq2psm' \
    --namespace $AB_NAMESPACE \
    --limit '80' \
    --offset '53' \
    --order 'NYEg8HKR' \
    > test.out 2>&1
eval_tap $? 21 'GetGroupMembersListAdminV1' test.out

#- 22 GetMemberRolesListAdminV1
$CLI_EXE \
    --sn group \
    --op GetMemberRolesListAdminV1 \
    --namespace $AB_NAMESPACE \
    --limit '80' \
    --offset '9' \
    > test.out 2>&1
eval_tap $? 22 'GetMemberRolesListAdminV1' test.out

#- 23 CreateMemberRoleAdminV1
# body param: body
echo '{"memberRoleName": "C56jVhMz", "memberRolePermissions": [{"action": 100, "resourceName": "Dw2DlZAn"}, {"action": 4, "resourceName": "UfeRUENr"}, {"action": 78, "resourceName": "T7FrmCjH"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op CreateMemberRoleAdminV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 23 'CreateMemberRoleAdminV1' test.out

#- 24 GetSingleMemberRoleAdminV1
$CLI_EXE \
    --sn group \
    --op GetSingleMemberRoleAdminV1 \
    --memberRoleId 'jgnYWb2k' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 24 'GetSingleMemberRoleAdminV1' test.out

#- 25 DeleteMemberRoleAdminV1
$CLI_EXE \
    --sn group \
    --op DeleteMemberRoleAdminV1 \
    --memberRoleId '28XvWnAi' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 25 'DeleteMemberRoleAdminV1' test.out

#- 26 UpdateMemberRoleAdminV1
# body param: body
echo '{"memberRoleName": "iPaOC4fr"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateMemberRoleAdminV1 \
    --memberRoleId '7sEDWXt5' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 26 'UpdateMemberRoleAdminV1' test.out

#- 27 UpdateMemberRolePermissionAdminV1
# body param: body
echo '{"memberRolePermissions": [{"action": 24, "resourceName": "Cv8DrHXr"}, {"action": 71, "resourceName": "sbYKFTt5"}, {"action": 75, "resourceName": "IFrURCxk"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateMemberRolePermissionAdminV1 \
    --memberRoleId 'QywpoVAG' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 27 'UpdateMemberRolePermissionAdminV1' test.out

#- 28 GetGroupListPublicV1
$CLI_EXE \
    --sn group \
    --op GetGroupListPublicV1 \
    --namespace $AB_NAMESPACE \
    --groupName 'Xy472KUz' \
    --groupRegion 'a0CQp2cm' \
    --limit '33' \
    --offset '93' \
    > test.out 2>&1
eval_tap $? 28 'GetGroupListPublicV1' test.out

#- 29 CreateNewGroupPublicV1
# body param: body
echo '{"configurationCode": "C9HbKJEm", "customAttributes": {"CRpZsMjh": {}, "YiJLmXqY": {}, "bGDGTM0S": {}}, "groupDescription": "lJlw62pl", "groupIcon": "pQ2bQ9U8", "groupMaxMember": 18, "groupName": "OQGufH7p", "groupRegion": "BHUcOj79", "groupRules": {"groupCustomRule": {}, "groupPredefinedRules": [{"allowedAction": "CFYphKGW", "ruleDetail": [{"ruleAttribute": "Llc3st2C", "ruleCriteria": "EQUAL", "ruleValue": 0.9425111051580682}, {"ruleAttribute": "cdb5yn9K", "ruleCriteria": "EQUAL", "ruleValue": 0.31813268723993193}, {"ruleAttribute": "pvyvCjS6", "ruleCriteria": "EQUAL", "ruleValue": 0.7829166525560665}]}, {"allowedAction": "05TLx33N", "ruleDetail": [{"ruleAttribute": "J6hF8or2", "ruleCriteria": "EQUAL", "ruleValue": 0.8424002654745378}, {"ruleAttribute": "Tn2uKHlZ", "ruleCriteria": "MINIMUM", "ruleValue": 0.26641772861447655}, {"ruleAttribute": "m0M4Y3wE", "ruleCriteria": "MINIMUM", "ruleValue": 0.5618845066937516}]}, {"allowedAction": "L6bDSBr2", "ruleDetail": [{"ruleAttribute": "Ib4apLNa", "ruleCriteria": "MAXIMUM", "ruleValue": 0.3968757183819974}, {"ruleAttribute": "QhcqTBnv", "ruleCriteria": "MAXIMUM", "ruleValue": 0.15289670514770304}, {"ruleAttribute": "FlEJPhER", "ruleCriteria": "MINIMUM", "ruleValue": 0.7533357350269975}]}]}, "groupType": "OPEN"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op CreateNewGroupPublicV1 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 29 'CreateNewGroupPublicV1' test.out

#- 30 GetSingleGroupPublicV1
$CLI_EXE \
    --sn group \
    --op GetSingleGroupPublicV1 \
    --groupId 'VL8xZWDW' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 30 'GetSingleGroupPublicV1' test.out

#- 31 UpdateSingleGroupV1
# body param: body
echo '{"customAttributes": {}, "groupDescription": "1ZrrPkMQ", "groupIcon": "pvjkyZFB", "groupName": "VWeXk6bD", "groupRegion": "DgZctwJX", "groupType": "PUBLIC"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateSingleGroupV1 \
    --groupId 'OCaCLM2W' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 31 'UpdateSingleGroupV1' test.out

#- 32 DeleteGroupPublicV1
$CLI_EXE \
    --sn group \
    --op DeleteGroupPublicV1 \
    --groupId 'GznDAwuD' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 32 'DeleteGroupPublicV1' test.out

#- 33 UpdatePatchSingleGroupPublicV1
# body param: body
echo '{"customAttributes": {}, "groupDescription": "qvNfTlQ3", "groupIcon": "T4dnvLhs", "groupName": "8vZPo2wm", "groupRegion": "idi6NUcY", "groupType": "OPEN"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdatePatchSingleGroupPublicV1 \
    --groupId 'bAT9hsQt' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 33 'UpdatePatchSingleGroupPublicV1' test.out

#- 34 UpdateGroupCustomAttributesPublicV1
# body param: body
echo '{"customAttributes": {"ux70EgCY": {}, "LwsP7gn3": {}, "zFJgepEO": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateGroupCustomAttributesPublicV1 \
    --groupId 'uU4F1spF' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 34 'UpdateGroupCustomAttributesPublicV1' test.out

#- 35 AcceptGroupInvitationPublicV1
$CLI_EXE \
    --sn group \
    --op AcceptGroupInvitationPublicV1 \
    --groupId 'Mql2MDZf' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 35 'AcceptGroupInvitationPublicV1' test.out

#- 36 RejectGroupInvitationPublicV1
$CLI_EXE \
    --sn group \
    --op RejectGroupInvitationPublicV1 \
    --groupId 'VUVIT6dB' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 36 'RejectGroupInvitationPublicV1' test.out

#- 37 JoinGroupV1
$CLI_EXE \
    --sn group \
    --op JoinGroupV1 \
    --groupId 'xwD44mSu' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 37 'JoinGroupV1' test.out

#- 38 CancelGroupJoinRequestV1
$CLI_EXE \
    --sn group \
    --op CancelGroupJoinRequestV1 \
    --groupId 'biA8OTPz' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 38 'CancelGroupJoinRequestV1' test.out

#- 39 GetGroupJoinRequestPublicV1
$CLI_EXE \
    --sn group \
    --op GetGroupJoinRequestPublicV1 \
    --groupId 'tMHW3NKs' \
    --namespace $AB_NAMESPACE \
    --limit '97' \
    --offset '91' \
    > test.out 2>&1
eval_tap $? 39 'GetGroupJoinRequestPublicV1' test.out

#- 40 GetGroupMembersListPublicV1
$CLI_EXE \
    --sn group \
    --op GetGroupMembersListPublicV1 \
    --groupId 'Yl55Ncp7' \
    --namespace $AB_NAMESPACE \
    --limit '51' \
    --offset '92' \
    --order 'dMwdGhOu' \
    > test.out 2>&1
eval_tap $? 40 'GetGroupMembersListPublicV1' test.out

#- 41 UpdateGroupCustomRulePublicV1
# body param: body
echo '{"groupCustomRule": {"KMgPSuVh": {}, "IH3DmWf4": {}, "g4dTYNZt": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateGroupCustomRulePublicV1 \
    --groupId 'NBW2jbpX' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 41 'UpdateGroupCustomRulePublicV1' test.out

#- 42 UpdateGroupPredefinedRulePublicV1
# body param: body
echo '{"ruleDetail": [{"ruleAttribute": "r7h5EQOi", "ruleCriteria": "MINIMUM", "ruleValue": 0.4939025977889826}, {"ruleAttribute": "fsCmD2PL", "ruleCriteria": "EQUAL", "ruleValue": 0.31749476567242263}, {"ruleAttribute": "EATvgZcF", "ruleCriteria": "EQUAL", "ruleValue": 0.6625868612211203}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateGroupPredefinedRulePublicV1 \
    --allowedAction 'ZjoeU3FB' \
    --groupId 'Q56zhFUp' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 42 'UpdateGroupPredefinedRulePublicV1' test.out

#- 43 DeleteGroupPredefinedRulePublicV1
$CLI_EXE \
    --sn group \
    --op DeleteGroupPredefinedRulePublicV1 \
    --allowedAction 'irlULOq5' \
    --groupId '7W0zgRsJ' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 43 'DeleteGroupPredefinedRulePublicV1' test.out

#- 44 LeaveGroupPublicV1
$CLI_EXE \
    --sn group \
    --op LeaveGroupPublicV1 \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 44 'LeaveGroupPublicV1' test.out

#- 45 GetMemberRolesListPublicV1
$CLI_EXE \
    --sn group \
    --op GetMemberRolesListPublicV1 \
    --namespace $AB_NAMESPACE \
    --limit '23' \
    --offset '6' \
    > test.out 2>&1
eval_tap $? 45 'GetMemberRolesListPublicV1' test.out

#- 46 UpdateMemberRolePublicV1
# body param: body
echo '{"userId": "NID8tDfE"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateMemberRolePublicV1 \
    --memberRoleId 'rZx2rgAc' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 46 'UpdateMemberRolePublicV1' test.out

#- 47 DeleteMemberRolePublicV1
# body param: body
echo '{"userId": "OKx4kQyb"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op DeleteMemberRolePublicV1 \
    --memberRoleId 'IpxKbM8J' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 47 'DeleteMemberRolePublicV1' test.out

#- 48 GetGroupInvitationRequestPublicV1
$CLI_EXE \
    --sn group \
    --op GetGroupInvitationRequestPublicV1 \
    --namespace $AB_NAMESPACE \
    --limit '80' \
    --offset '18' \
    > test.out 2>&1
eval_tap $? 48 'GetGroupInvitationRequestPublicV1' test.out

#- 49 GetUserGroupInformationPublicV1
$CLI_EXE \
    --sn group \
    --op GetUserGroupInformationPublicV1 \
    --namespace $AB_NAMESPACE \
    --userId 'Kqnl9k2Q' \
    > test.out 2>&1
eval_tap $? 49 'GetUserGroupInformationPublicV1' test.out

#- 50 InviteGroupPublicV1
$CLI_EXE \
    --sn group \
    --op InviteGroupPublicV1 \
    --namespace $AB_NAMESPACE \
    --userId 'q79x6fCp' \
    > test.out 2>&1
eval_tap $? 50 'InviteGroupPublicV1' test.out

#- 51 AcceptGroupJoinRequestPublicV1
$CLI_EXE \
    --sn group \
    --op AcceptGroupJoinRequestPublicV1 \
    --namespace $AB_NAMESPACE \
    --userId 'JWBmowGj' \
    > test.out 2>&1
eval_tap $? 51 'AcceptGroupJoinRequestPublicV1' test.out

#- 52 RejectGroupJoinRequestPublicV1
$CLI_EXE \
    --sn group \
    --op RejectGroupJoinRequestPublicV1 \
    --namespace $AB_NAMESPACE \
    --userId '608bCE5A' \
    > test.out 2>&1
eval_tap $? 52 'RejectGroupJoinRequestPublicV1' test.out

#- 53 KickGroupMemberPublicV1
$CLI_EXE \
    --sn group \
    --op KickGroupMemberPublicV1 \
    --namespace $AB_NAMESPACE \
    --userId '5mH8JLsr' \
    > test.out 2>&1
eval_tap $? 53 'KickGroupMemberPublicV1' test.out

#- 54 GetListGroupByIDsAdminV2
# body param: body
echo '{"groupIDs": ["p4BoHKf4", "3iERSdhY", "QtptpS65"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op GetListGroupByIDsAdminV2 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 54 'GetListGroupByIDsAdminV2' test.out

#- 55 GetUserJoinedGroupInformationPublicV2
$CLI_EXE \
    --sn group \
    --op GetUserJoinedGroupInformationPublicV2 \
    --namespace $AB_NAMESPACE \
    --userId 'z1xMYA8R' \
    --limit '40' \
    --offset '29' \
    > test.out 2>&1
eval_tap $? 55 'GetUserJoinedGroupInformationPublicV2' test.out

#- 56 AdminGetUserGroupStatusInformationV2
$CLI_EXE \
    --sn group \
    --op AdminGetUserGroupStatusInformationV2 \
    --groupId 'Hn9TpPB6' \
    --namespace $AB_NAMESPACE \
    --userId '6x2leY1W' \
    > test.out 2>&1
eval_tap $? 56 'AdminGetUserGroupStatusInformationV2' test.out

#- 57 CreateNewGroupPublicV2
# body param: body
echo '{"configurationCode": "xz9scC6G", "customAttributes": {"45KMDSOa": {}, "acZm3ZRn": {}, "4ZVKLg2r": {}}, "groupDescription": "qRFOEM1A", "groupIcon": "iwGuDaj7", "groupMaxMember": 81, "groupName": "K9GDvh4s", "groupRegion": "B80XLwPu", "groupRules": {"groupCustomRule": {}, "groupPredefinedRules": [{"allowedAction": "XGGjSrHI", "ruleDetail": [{"ruleAttribute": "ZA06IOgF", "ruleCriteria": "MAXIMUM", "ruleValue": 0.9234129603373481}, {"ruleAttribute": "NrUxXZav", "ruleCriteria": "MINIMUM", "ruleValue": 0.3058282796550209}, {"ruleAttribute": "ZuX4QvFW", "ruleCriteria": "EQUAL", "ruleValue": 0.635688242399694}]}, {"allowedAction": "5AM6HVKm", "ruleDetail": [{"ruleAttribute": "sUvnf64F", "ruleCriteria": "MAXIMUM", "ruleValue": 0.5277648480647514}, {"ruleAttribute": "WaV7fEzY", "ruleCriteria": "MINIMUM", "ruleValue": 0.26387492362626075}, {"ruleAttribute": "lbHt5p26", "ruleCriteria": "MINIMUM", "ruleValue": 0.6745010391154176}]}, {"allowedAction": "AsjhFxmE", "ruleDetail": [{"ruleAttribute": "oyeTY4YX", "ruleCriteria": "MAXIMUM", "ruleValue": 0.8038486008384595}, {"ruleAttribute": "EyvrX5As", "ruleCriteria": "EQUAL", "ruleValue": 0.8071115414410784}, {"ruleAttribute": "sWyADgBW", "ruleCriteria": "MAXIMUM", "ruleValue": 0.9936125902119695}]}]}, "groupType": "PUBLIC"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op CreateNewGroupPublicV2 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 57 'CreateNewGroupPublicV2' test.out

#- 58 GetListGroupByIDsV2
# body param: body
echo '{"groupIDs": ["VvqmLM5s", "A3riimqD", "V178EfRI"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op GetListGroupByIDsV2 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 58 'GetListGroupByIDsV2' test.out

#- 59 UpdatePutSingleGroupPublicV2
# body param: body
echo '{"customAttributes": {}, "groupDescription": "5BQUvlX2", "groupIcon": "oKKaC2i9", "groupName": "6dkLweBV", "groupRegion": "ztqtbQ9i", "groupType": "PUBLIC"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdatePutSingleGroupPublicV2 \
    --groupId 'RPYxcoa8' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 59 'UpdatePutSingleGroupPublicV2' test.out

#- 60 DeleteGroupPublicV2
$CLI_EXE \
    --sn group \
    --op DeleteGroupPublicV2 \
    --groupId '3sVxVOBt' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 60 'DeleteGroupPublicV2' test.out

#- 61 UpdatePatchSingleGroupPublicV2
# body param: body
echo '{"customAttributes": {}, "groupDescription": "8eXSiVlk", "groupIcon": "ogw0xQAz", "groupName": "SmTA9MAL", "groupRegion": "R5LUOJSV", "groupType": "PUBLIC"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdatePatchSingleGroupPublicV2 \
    --groupId '534wnvWL' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 61 'UpdatePatchSingleGroupPublicV2' test.out

#- 62 UpdateGroupCustomAttributesPublicV2
# body param: body
echo '{"customAttributes": {"cSsp8pak": {}, "cgkW60Wa": {}, "7Ie710ZA": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateGroupCustomAttributesPublicV2 \
    --groupId 'wD7Dn9v3' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 62 'UpdateGroupCustomAttributesPublicV2' test.out

#- 63 AcceptGroupInvitationPublicV2
$CLI_EXE \
    --sn group \
    --op AcceptGroupInvitationPublicV2 \
    --groupId 'nnnKHnTt' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 63 'AcceptGroupInvitationPublicV2' test.out

#- 64 RejectGroupInvitationPublicV2
$CLI_EXE \
    --sn group \
    --op RejectGroupInvitationPublicV2 \
    --groupId 'EC1drlAk' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 64 'RejectGroupInvitationPublicV2' test.out

#- 65 GetGroupInviteRequestPublicV2
$CLI_EXE \
    --sn group \
    --op GetGroupInviteRequestPublicV2 \
    --groupId '9mxOsrNq' \
    --namespace $AB_NAMESPACE \
    --limit '41' \
    --offset '35' \
    > test.out 2>&1
eval_tap $? 65 'GetGroupInviteRequestPublicV2' test.out

#- 66 JoinGroupV2
$CLI_EXE \
    --sn group \
    --op JoinGroupV2 \
    --groupId '0sZB6CE1' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 66 'JoinGroupV2' test.out

#- 67 GetGroupJoinRequestPublicV2
$CLI_EXE \
    --sn group \
    --op GetGroupJoinRequestPublicV2 \
    --groupId 'wxLyIoh1' \
    --namespace $AB_NAMESPACE \
    --limit '81' \
    --offset '75' \
    > test.out 2>&1
eval_tap $? 67 'GetGroupJoinRequestPublicV2' test.out

#- 68 LeaveGroupPublicV2
$CLI_EXE \
    --sn group \
    --op LeaveGroupPublicV2 \
    --groupId 'KBdZdKyy' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 68 'LeaveGroupPublicV2' test.out

#- 69 UpdateGroupCustomRulePublicV2
# body param: body
echo '{"groupCustomRule": {"a8dLpy5G": {}, "5ck4fynM": {}, "ytxG7wzP": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateGroupCustomRulePublicV2 \
    --groupId 'KW7Mlne2' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 69 'UpdateGroupCustomRulePublicV2' test.out

#- 70 UpdateGroupPredefinedRulePublicV2
# body param: body
echo '{"ruleDetail": [{"ruleAttribute": "Y6eLSRaF", "ruleCriteria": "MAXIMUM", "ruleValue": 0.24260075438564588}, {"ruleAttribute": "vKDLTpZD", "ruleCriteria": "EQUAL", "ruleValue": 0.17453283563203148}, {"ruleAttribute": "zi9f4Pse", "ruleCriteria": "MAXIMUM", "ruleValue": 0.7667536808270137}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateGroupPredefinedRulePublicV2 \
    --allowedAction 'wenDYefM' \
    --groupId 'IJX0uhsR' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 70 'UpdateGroupPredefinedRulePublicV2' test.out

#- 71 DeleteGroupPredefinedRulePublicV2
$CLI_EXE \
    --sn group \
    --op DeleteGroupPredefinedRulePublicV2 \
    --allowedAction 'pkMl6RnP' \
    --groupId 'pxwdXIg9' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 71 'DeleteGroupPredefinedRulePublicV2' test.out

#- 72 GetMemberRolesListPublicV2
$CLI_EXE \
    --sn group \
    --op GetMemberRolesListPublicV2 \
    --namespace $AB_NAMESPACE \
    --limit '71' \
    --offset '75' \
    > test.out 2>&1
eval_tap $? 72 'GetMemberRolesListPublicV2' test.out

#- 73 UpdateMemberRolePublicV2
# body param: body
echo '{"userId": "3MEgAG0t"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateMemberRolePublicV2 \
    --groupId '2GFnS8Co' \
    --memberRoleId 'Lw1AwPsJ' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 73 'UpdateMemberRolePublicV2' test.out

#- 74 DeleteMemberRolePublicV2
# body param: body
echo '{"userId": "DT70mr9g"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op DeleteMemberRolePublicV2 \
    --groupId 'L6apWpo9' \
    --memberRoleId 'p5MtW5nS' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 74 'DeleteMemberRolePublicV2' test.out

#- 75 GetUserGroupInformationPublicV2
$CLI_EXE \
    --sn group \
    --op GetUserGroupInformationPublicV2 \
    --namespace $AB_NAMESPACE \
    --limit '99' \
    --offset '22' \
    > test.out 2>&1
eval_tap $? 75 'GetUserGroupInformationPublicV2' test.out

#- 76 GetMyGroupJoinRequestV2
$CLI_EXE \
    --sn group \
    --op GetMyGroupJoinRequestV2 \
    --namespace $AB_NAMESPACE \
    --limit '73' \
    --offset '91' \
    > test.out 2>&1
eval_tap $? 76 'GetMyGroupJoinRequestV2' test.out

#- 77 InviteGroupPublicV2
$CLI_EXE \
    --sn group \
    --op InviteGroupPublicV2 \
    --groupId 'tWmF9O4b' \
    --namespace $AB_NAMESPACE \
    --userId 'UUwrZAiw' \
    > test.out 2>&1
eval_tap $? 77 'InviteGroupPublicV2' test.out

#- 78 CancelInvitationGroupMemberV2
$CLI_EXE \
    --sn group \
    --op CancelInvitationGroupMemberV2 \
    --groupId 'EMDb8TGW' \
    --namespace $AB_NAMESPACE \
    --userId '0teCzQz5' \
    > test.out 2>&1
eval_tap $? 78 'CancelInvitationGroupMemberV2' test.out

#- 79 AcceptGroupJoinRequestPublicV2
$CLI_EXE \
    --sn group \
    --op AcceptGroupJoinRequestPublicV2 \
    --groupId 'xVZIHfHY' \
    --namespace $AB_NAMESPACE \
    --userId 'heq1MLjz' \
    > test.out 2>&1
eval_tap $? 79 'AcceptGroupJoinRequestPublicV2' test.out

#- 80 RejectGroupJoinRequestPublicV2
$CLI_EXE \
    --sn group \
    --op RejectGroupJoinRequestPublicV2 \
    --groupId 'flq8CilQ' \
    --namespace $AB_NAMESPACE \
    --userId 'VMeZlxLG' \
    > test.out 2>&1
eval_tap $? 80 'RejectGroupJoinRequestPublicV2' test.out

#- 81 KickGroupMemberPublicV2
$CLI_EXE \
    --sn group \
    --op KickGroupMemberPublicV2 \
    --groupId 'livGBpeQ' \
    --namespace $AB_NAMESPACE \
    --userId 'H8nJe3wX' \
    > test.out 2>&1
eval_tap $? 81 'KickGroupMemberPublicV2' test.out

#- 82 GetUserGroupStatusInformationV2
$CLI_EXE \
    --sn group \
    --op GetUserGroupStatusInformationV2 \
    --groupId 'Nra70NsV' \
    --namespace $AB_NAMESPACE \
    --userId 'mbfVV8KE' \
    > test.out 2>&1
eval_tap $? 82 'GetUserGroupStatusInformationV2' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE