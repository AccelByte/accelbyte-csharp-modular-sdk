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
    --limit '2' \
    --offset '90' \
    > test.out 2>&1
eval_tap $? 2 'ListGroupConfigurationAdminV1' test.out

#- 3 CreateGroupConfigurationAdminV1
# body param: body
echo '{"allowMultiple": true, "configurationCode": "TsXX2mvE", "description": "w4w9Wwor", "globalRules": [{"allowedAction": "joinGroup", "ruleDetail": [{"ruleAttribute": "oK4fVxfG", "ruleCriteria": "EQUAL", "ruleValue": 0.6455070086161172}, {"ruleAttribute": "55L7AgZs", "ruleCriteria": "MINIMUM", "ruleValue": 0.5178870103624}, {"ruleAttribute": "qQ2Frmjf", "ruleCriteria": "EQUAL", "ruleValue": 0.8063154579812869}]}, {"allowedAction": "createGroup", "ruleDetail": [{"ruleAttribute": "lz5HCBQO", "ruleCriteria": "MINIMUM", "ruleValue": 0.9933528136647675}, {"ruleAttribute": "Asdd4ycH", "ruleCriteria": "EQUAL", "ruleValue": 0.7563603934222264}, {"ruleAttribute": "SnwXpVyR", "ruleCriteria": "EQUAL", "ruleValue": 0.16354277111772797}]}, {"allowedAction": "joinGroup", "ruleDetail": [{"ruleAttribute": "BAqE2bjV", "ruleCriteria": "MAXIMUM", "ruleValue": 0.336615779070886}, {"ruleAttribute": "gsmGuMBk", "ruleCriteria": "MAXIMUM", "ruleValue": 0.22726193493839775}, {"ruleAttribute": "gws5aM1b", "ruleCriteria": "EQUAL", "ruleValue": 0.3727442827566986}]}], "groupAdminRoleId": "bJePhyzY", "groupMaxMember": 82, "groupMemberRoleId": "Ilvv6vEt", "name": "hEM29OxH"}' > $TEMP_JSON_INPUT
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
    --configurationCode 'pdOv86xs' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 5 'GetGroupConfigurationAdminV1' test.out

#- 6 DeleteGroupConfigurationV1
$CLI_EXE \
    --sn group \
    --op DeleteGroupConfigurationV1 \
    --configurationCode 'aaUYu3sW' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 6 'DeleteGroupConfigurationV1' test.out

#- 7 UpdateGroupConfigurationAdminV1
# body param: body
echo '{"description": "KOhywjBp", "groupMaxMember": 52, "name": "SHur5JDd"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateGroupConfigurationAdminV1 \
    --configurationCode 'fy8ivl8d' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 7 'UpdateGroupConfigurationAdminV1' test.out

#- 8 UpdateGroupConfigurationGlobalRuleAdminV1
# body param: body
echo '{"ruleDetail": [{"ruleAttribute": "TDzQL7iR", "ruleCriteria": "MINIMUM", "ruleValue": 0.8063381995525636}, {"ruleAttribute": "aJb6EoKd", "ruleCriteria": "MINIMUM", "ruleValue": 0.9936968716353497}, {"ruleAttribute": "XukzbDuC", "ruleCriteria": "MAXIMUM", "ruleValue": 0.8078355479337828}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateGroupConfigurationGlobalRuleAdminV1 \
    --allowedAction 'a4q4ZCiX' \
    --configurationCode 'NJN6VWVf' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 8 'UpdateGroupConfigurationGlobalRuleAdminV1' test.out

#- 9 DeleteGroupConfigurationGlobalRuleAdminV1
$CLI_EXE \
    --sn group \
    --op DeleteGroupConfigurationGlobalRuleAdminV1 \
    --allowedAction 'batVy09J' \
    --configurationCode 'PmP3htR7' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 9 'DeleteGroupConfigurationGlobalRuleAdminV1' test.out

#- 10 GetGroupListAdminV1
$CLI_EXE \
    --sn group \
    --op GetGroupListAdminV1 \
    --namespace $AB_NAMESPACE \
    --configurationCode 'BBRzc5Vg' \
    --groupName 'UGPVfniE' \
    --groupRegion 'fcxYl1Rt' \
    --limit '87' \
    --offset '82' \
    > test.out 2>&1
eval_tap $? 10 'GetGroupListAdminV1' test.out

#- 11 GetSingleGroupAdminV1
$CLI_EXE \
    --sn group \
    --op GetSingleGroupAdminV1 \
    --groupId 'NKZkT7XG' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 11 'GetSingleGroupAdminV1' test.out

#- 12 DeleteGroupAdminV1
$CLI_EXE \
    --sn group \
    --op DeleteGroupAdminV1 \
    --groupId 'tYSsXkD4' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 12 'DeleteGroupAdminV1' test.out

#- 13 GetGroupMembersListAdminV1
$CLI_EXE \
    --sn group \
    --op GetGroupMembersListAdminV1 \
    --groupId 'haNLFqkA' \
    --namespace $AB_NAMESPACE \
    --limit '1' \
    --offset '27' \
    --order 'uStgNL11' \
    > test.out 2>&1
eval_tap $? 13 'GetGroupMembersListAdminV1' test.out

#- 14 GetMemberRolesListAdminV1
$CLI_EXE \
    --sn group \
    --op GetMemberRolesListAdminV1 \
    --namespace $AB_NAMESPACE \
    --limit '28' \
    --offset '90' \
    > test.out 2>&1
eval_tap $? 14 'GetMemberRolesListAdminV1' test.out

#- 15 CreateMemberRoleAdminV1
# body param: body
echo '{"memberRoleName": "1P4d4zVj", "memberRolePermissions": [{"action": 29, "resourceName": "rWOhjBXt"}, {"action": 11, "resourceName": "23ZaXAqh"}, {"action": 49, "resourceName": "Hb21gBrN"}]}' > $TEMP_JSON_INPUT
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
    --memberRoleId 'Kkx844Dh' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 16 'GetSingleMemberRoleAdminV1' test.out

#- 17 DeleteMemberRoleAdminV1
$CLI_EXE \
    --sn group \
    --op DeleteMemberRoleAdminV1 \
    --memberRoleId 'h1aUYJYP' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 17 'DeleteMemberRoleAdminV1' test.out

#- 18 UpdateMemberRoleAdminV1
# body param: body
echo '{"memberRoleName": "3LEA93nT"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateMemberRoleAdminV1 \
    --memberRoleId '1KKR9lz3' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 18 'UpdateMemberRoleAdminV1' test.out

#- 19 UpdateMemberRolePermissionAdminV1
# body param: body
echo '{"memberRolePermissions": [{"action": 81, "resourceName": "yWe4Of6q"}, {"action": 100, "resourceName": "7oDNYW6M"}, {"action": 56, "resourceName": "shNs2u9B"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateMemberRolePermissionAdminV1 \
    --memberRoleId 'u2i6V2K6' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 19 'UpdateMemberRolePermissionAdminV1' test.out

#- 20 GetGroupListPublicV1
$CLI_EXE \
    --sn group \
    --op GetGroupListPublicV1 \
    --namespace $AB_NAMESPACE \
    --groupName 'XfqRiu6i' \
    --groupRegion 'v8wMPyNM' \
    --limit '99' \
    --offset '66' \
    > test.out 2>&1
eval_tap $? 20 'GetGroupListPublicV1' test.out

#- 21 CreateNewGroupPublicV1
# body param: body
echo '{"configurationCode": "7KKka8ZB", "customAttributes": {"aDPTgz9a": {}, "Up2S07gG": {}, "XlWwkfv8": {}}, "groupDescription": "yE8eNbrI", "groupIcon": "W0hhj4Z4", "groupMaxMember": 43, "groupName": "qgPqqKF5", "groupRegion": "aClgvVqG", "groupRules": {"groupCustomRule": {}, "groupPredefinedRules": [{"allowedAction": "createGroup", "ruleDetail": [{"ruleAttribute": "JiWtupen", "ruleCriteria": "EQUAL", "ruleValue": 0.5248913753043722}, {"ruleAttribute": "2PlBQyYQ", "ruleCriteria": "EQUAL", "ruleValue": 0.44412794833666325}, {"ruleAttribute": "pp8Ixo0I", "ruleCriteria": "EQUAL", "ruleValue": 0.7319577666123378}]}, {"allowedAction": "createGroup", "ruleDetail": [{"ruleAttribute": "WoMoht4T", "ruleCriteria": "MINIMUM", "ruleValue": 0.8381187480451154}, {"ruleAttribute": "R8nxBUlA", "ruleCriteria": "EQUAL", "ruleValue": 0.2905063694884511}, {"ruleAttribute": "ZLqQOn6Y", "ruleCriteria": "MAXIMUM", "ruleValue": 0.6986841988026459}]}, {"allowedAction": "joinGroup", "ruleDetail": [{"ruleAttribute": "yS47t1VR", "ruleCriteria": "MINIMUM", "ruleValue": 0.224634147917404}, {"ruleAttribute": "hBb44bL9", "ruleCriteria": "MINIMUM", "ruleValue": 0.061947082583444724}, {"ruleAttribute": "gcUZC2Yv", "ruleCriteria": "MAXIMUM", "ruleValue": 0.8665213568024132}]}]}, "groupType": "OPEN"}' > $TEMP_JSON_INPUT
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
    --groupId 'xJ5qLkwL' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 22 'GetSingleGroupPublicV1' test.out

#- 23 UpdateSingleGroupV1
# body param: body
echo '{"customAttributes": {}, "groupDescription": "ka5zmZ9f", "groupIcon": "SXdj8QX4", "groupName": "3Tt0wIGX", "groupRegion": "XwScPJSR", "groupType": "OPEN"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateSingleGroupV1 \
    --groupId 'OJ81gAaE' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 23 'UpdateSingleGroupV1' test.out

#- 24 DeleteGroupPublicV1
$CLI_EXE \
    --sn group \
    --op DeleteGroupPublicV1 \
    --groupId 'IAY1FzM5' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 24 'DeleteGroupPublicV1' test.out

#- 25 UpdatePatchSingleGroupPublicV1
# body param: body
echo '{"customAttributes": {}, "groupDescription": "GiHRsO5E", "groupIcon": "w4Mi2jG1", "groupName": "cnR89lcv", "groupRegion": "bHt2fB2Q", "groupType": "PUBLIC"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdatePatchSingleGroupPublicV1 \
    --groupId 'q2TkhtoB' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 25 'UpdatePatchSingleGroupPublicV1' test.out

#- 26 UpdateGroupCustomAttributesPublicV1
# body param: body
echo '{"customAttributes": {"OOsIpqTV": {}, "PLCBe93h": {}, "ZuUbwJWj": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateGroupCustomAttributesPublicV1 \
    --groupId 'bfopuTCe' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 26 'UpdateGroupCustomAttributesPublicV1' test.out

#- 27 AcceptGroupInvitationPublicV1
$CLI_EXE \
    --sn group \
    --op AcceptGroupInvitationPublicV1 \
    --groupId '1nqtXBsp' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 27 'AcceptGroupInvitationPublicV1' test.out

#- 28 RejectGroupInvitationPublicV1
$CLI_EXE \
    --sn group \
    --op RejectGroupInvitationPublicV1 \
    --groupId 'LqpTqsv1' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 28 'RejectGroupInvitationPublicV1' test.out

#- 29 JoinGroupV1
$CLI_EXE \
    --sn group \
    --op JoinGroupV1 \
    --groupId 'I7nO1HXg' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 29 'JoinGroupV1' test.out

#- 30 CancelGroupJoinRequestV1
$CLI_EXE \
    --sn group \
    --op CancelGroupJoinRequestV1 \
    --groupId 'OLqswPYN' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 30 'CancelGroupJoinRequestV1' test.out

#- 31 GetGroupJoinRequestPublicV1
$CLI_EXE \
    --sn group \
    --op GetGroupJoinRequestPublicV1 \
    --groupId 'Ab8Ppnj0' \
    --namespace $AB_NAMESPACE \
    --limit '20' \
    --offset '55' \
    > test.out 2>&1
eval_tap $? 31 'GetGroupJoinRequestPublicV1' test.out

#- 32 GetGroupMembersListPublicV1
$CLI_EXE \
    --sn group \
    --op GetGroupMembersListPublicV1 \
    --groupId 'raOHGjC4' \
    --namespace $AB_NAMESPACE \
    --limit '54' \
    --offset '68' \
    --order 'txBlDtPk' \
    > test.out 2>&1
eval_tap $? 32 'GetGroupMembersListPublicV1' test.out

#- 33 UpdateGroupCustomRulePublicV1
# body param: body
echo '{"groupCustomRule": {"bysfIwdk": {}, "nFTGTIPg": {}, "a5SJPT7i": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateGroupCustomRulePublicV1 \
    --groupId 'YI9l1GIH' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 33 'UpdateGroupCustomRulePublicV1' test.out

#- 34 UpdateGroupPredefinedRulePublicV1
# body param: body
echo '{"ruleDetail": [{"ruleAttribute": "DmDHYOlD", "ruleCriteria": "EQUAL", "ruleValue": 0.850378330912924}, {"ruleAttribute": "jaNTR51E", "ruleCriteria": "MINIMUM", "ruleValue": 0.7614819815292686}, {"ruleAttribute": "6OrJVgFT", "ruleCriteria": "MINIMUM", "ruleValue": 0.4930881081478736}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateGroupPredefinedRulePublicV1 \
    --allowedAction 'McbruOaw' \
    --groupId 'u2yBTTkT' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 34 'UpdateGroupPredefinedRulePublicV1' test.out

#- 35 DeleteGroupPredefinedRulePublicV1
$CLI_EXE \
    --sn group \
    --op DeleteGroupPredefinedRulePublicV1 \
    --allowedAction 'iQ4DRgZb' \
    --groupId 'ZL4KQTrt' \
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
    --limit '13' \
    --offset '31' \
    > test.out 2>&1
eval_tap $? 37 'GetMemberRolesListPublicV1' test.out

#- 38 UpdateMemberRolePublicV1
# body param: body
echo '{"userId": "ushdjmkY"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateMemberRolePublicV1 \
    --memberRoleId 'PFqVgMit' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 38 'UpdateMemberRolePublicV1' test.out

#- 39 DeleteMemberRolePublicV1
# body param: body
echo '{"userId": "CwXLQ3wQ"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op DeleteMemberRolePublicV1 \
    --memberRoleId 'xtbdd6js' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 39 'DeleteMemberRolePublicV1' test.out

#- 40 GetGroupInvitationRequestPublicV1
$CLI_EXE \
    --sn group \
    --op GetGroupInvitationRequestPublicV1 \
    --namespace $AB_NAMESPACE \
    --limit '35' \
    --offset '70' \
    > test.out 2>&1
eval_tap $? 40 'GetGroupInvitationRequestPublicV1' test.out

#- 41 GetUserGroupInformationPublicV1
$CLI_EXE \
    --sn group \
    --op GetUserGroupInformationPublicV1 \
    --namespace $AB_NAMESPACE \
    --userId 'by1uM3O7' \
    > test.out 2>&1
eval_tap $? 41 'GetUserGroupInformationPublicV1' test.out

#- 42 InviteGroupPublicV1
$CLI_EXE \
    --sn group \
    --op InviteGroupPublicV1 \
    --namespace $AB_NAMESPACE \
    --userId '9BwxjdEM' \
    > test.out 2>&1
eval_tap $? 42 'InviteGroupPublicV1' test.out

#- 43 AcceptGroupJoinRequestPublicV1
$CLI_EXE \
    --sn group \
    --op AcceptGroupJoinRequestPublicV1 \
    --namespace $AB_NAMESPACE \
    --userId 'nTwfpnv0' \
    > test.out 2>&1
eval_tap $? 43 'AcceptGroupJoinRequestPublicV1' test.out

#- 44 RejectGroupJoinRequestPublicV1
$CLI_EXE \
    --sn group \
    --op RejectGroupJoinRequestPublicV1 \
    --namespace $AB_NAMESPACE \
    --userId '7hLDZwp5' \
    > test.out 2>&1
eval_tap $? 44 'RejectGroupJoinRequestPublicV1' test.out

#- 45 KickGroupMemberPublicV1
$CLI_EXE \
    --sn group \
    --op KickGroupMemberPublicV1 \
    --namespace $AB_NAMESPACE \
    --userId 'RAuqC4Rp' \
    > test.out 2>&1
eval_tap $? 45 'KickGroupMemberPublicV1' test.out

#- 46 GetListGroupByIDsAdminV2
# body param: body
echo '{"groupIDs": ["FVt2FpJZ", "YcI7XduV", "vhrQesvX"]}' > $TEMP_JSON_INPUT
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
    --userId 'BQjK0ZuT' \
    --limit '62' \
    --offset '51' \
    > test.out 2>&1
eval_tap $? 47 'GetUserJoinedGroupInformationPublicV2' test.out

#- 48 AdminGetUserGroupStatusInformationV2
$CLI_EXE \
    --sn group \
    --op AdminGetUserGroupStatusInformationV2 \
    --groupId 'C3l2njH2' \
    --namespace $AB_NAMESPACE \
    --userId 'XivU3j8U' \
    > test.out 2>&1
eval_tap $? 48 'AdminGetUserGroupStatusInformationV2' test.out

#- 49 CreateNewGroupPublicV2
# body param: body
echo '{"configurationCode": "C0xxveuD", "customAttributes": {"YLdwvV4Z": {}, "YBjJtUDW": {}, "Av81yI7c": {}}, "groupDescription": "K5vKBvxi", "groupIcon": "2s0v3XgD", "groupMaxMember": 93, "groupName": "fYGelEMv", "groupRegion": "XB9SFUjm", "groupRules": {"groupCustomRule": {}, "groupPredefinedRules": [{"allowedAction": "createGroup", "ruleDetail": [{"ruleAttribute": "vTxOgRNw", "ruleCriteria": "MINIMUM", "ruleValue": 0.8863301976206693}, {"ruleAttribute": "kO5NTHWc", "ruleCriteria": "EQUAL", "ruleValue": 0.36949583433169864}, {"ruleAttribute": "ZUH8i7JH", "ruleCriteria": "EQUAL", "ruleValue": 0.9551359704880291}]}, {"allowedAction": "createGroup", "ruleDetail": [{"ruleAttribute": "UQE5MEBi", "ruleCriteria": "MINIMUM", "ruleValue": 0.34867993917317086}, {"ruleAttribute": "bxX8eOWF", "ruleCriteria": "MINIMUM", "ruleValue": 0.7965372250652267}, {"ruleAttribute": "y7iK69cR", "ruleCriteria": "MINIMUM", "ruleValue": 0.1514546418639795}]}, {"allowedAction": "createGroup", "ruleDetail": [{"ruleAttribute": "5a3alVS5", "ruleCriteria": "EQUAL", "ruleValue": 0.6645793513833513}, {"ruleAttribute": "7mkFY9lH", "ruleCriteria": "MINIMUM", "ruleValue": 0.4731449770205294}, {"ruleAttribute": "xJSelzqc", "ruleCriteria": "MINIMUM", "ruleValue": 0.28712292376720105}]}]}, "groupType": "OPEN"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op CreateNewGroupPublicV2 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 49 'CreateNewGroupPublicV2' test.out

#- 50 GetListGroupByIDsV2
# body param: body
echo '{"groupIDs": ["jblXKJvW", "t810sbHw", "nCYHczQw"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op GetListGroupByIDsV2 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 50 'GetListGroupByIDsV2' test.out

#- 51 UpdatePutSingleGroupPublicV2
# body param: body
echo '{"customAttributes": {}, "groupDescription": "GTkN7cF0", "groupIcon": "XMh4tja4", "groupName": "6cu6ujDJ", "groupRegion": "GYxJpa2N", "groupType": "PRIVATE"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdatePutSingleGroupPublicV2 \
    --groupId 'QFayvauv' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 51 'UpdatePutSingleGroupPublicV2' test.out

#- 52 DeleteGroupPublicV2
$CLI_EXE \
    --sn group \
    --op DeleteGroupPublicV2 \
    --groupId 'l5rcJrn5' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 52 'DeleteGroupPublicV2' test.out

#- 53 UpdatePatchSingleGroupPublicV2
# body param: body
echo '{"customAttributes": {}, "groupDescription": "IfMXaqlS", "groupIcon": "R3Jmo7CA", "groupName": "68lLGu47", "groupRegion": "8B309X4b", "groupType": "PRIVATE"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdatePatchSingleGroupPublicV2 \
    --groupId 'BVgl2kqZ' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 53 'UpdatePatchSingleGroupPublicV2' test.out

#- 54 UpdateGroupCustomAttributesPublicV2
# body param: body
echo '{"customAttributes": {"lderabDo": {}, "MUJoVfkk": {}, "yWnfX547": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateGroupCustomAttributesPublicV2 \
    --groupId 'eBma7au1' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 54 'UpdateGroupCustomAttributesPublicV2' test.out

#- 55 AcceptGroupInvitationPublicV2
$CLI_EXE \
    --sn group \
    --op AcceptGroupInvitationPublicV2 \
    --groupId 'sKAKiE4H' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 55 'AcceptGroupInvitationPublicV2' test.out

#- 56 RejectGroupInvitationPublicV2
$CLI_EXE \
    --sn group \
    --op RejectGroupInvitationPublicV2 \
    --groupId 'y8WZhes7' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 56 'RejectGroupInvitationPublicV2' test.out

#- 57 GetGroupInviteRequestPublicV2
$CLI_EXE \
    --sn group \
    --op GetGroupInviteRequestPublicV2 \
    --groupId 'LiQi0Sxf' \
    --namespace $AB_NAMESPACE \
    --limit '18' \
    --offset '57' \
    > test.out 2>&1
eval_tap $? 57 'GetGroupInviteRequestPublicV2' test.out

#- 58 JoinGroupV2
$CLI_EXE \
    --sn group \
    --op JoinGroupV2 \
    --groupId 'FybL8bxH' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 58 'JoinGroupV2' test.out

#- 59 GetGroupJoinRequestPublicV2
$CLI_EXE \
    --sn group \
    --op GetGroupJoinRequestPublicV2 \
    --groupId 'ewWepDud' \
    --namespace $AB_NAMESPACE \
    --limit '50' \
    --offset '10' \
    > test.out 2>&1
eval_tap $? 59 'GetGroupJoinRequestPublicV2' test.out

#- 60 LeaveGroupPublicV2
$CLI_EXE \
    --sn group \
    --op LeaveGroupPublicV2 \
    --groupId '9ty00WUz' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 60 'LeaveGroupPublicV2' test.out

#- 61 UpdateGroupCustomRulePublicV2
# body param: body
echo '{"groupCustomRule": {"FFdz53AD": {}, "uqKPoQLQ": {}, "C1iDSfAf": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateGroupCustomRulePublicV2 \
    --groupId 'p9Ir1dzN' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 61 'UpdateGroupCustomRulePublicV2' test.out

#- 62 UpdateGroupPredefinedRulePublicV2
# body param: body
echo '{"ruleDetail": [{"ruleAttribute": "PwZRiXQw", "ruleCriteria": "EQUAL", "ruleValue": 0.8952299100585083}, {"ruleAttribute": "xjxjnSu4", "ruleCriteria": "MINIMUM", "ruleValue": 0.5037929035638664}, {"ruleAttribute": "TRrXa793", "ruleCriteria": "EQUAL", "ruleValue": 0.6765735017961191}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateGroupPredefinedRulePublicV2 \
    --allowedAction 'OEdFIlTg' \
    --groupId 'vyGi8MQH' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 62 'UpdateGroupPredefinedRulePublicV2' test.out

#- 63 DeleteGroupPredefinedRulePublicV2
$CLI_EXE \
    --sn group \
    --op DeleteGroupPredefinedRulePublicV2 \
    --allowedAction 'FZQkDDZT' \
    --groupId 'tYxBY33a' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 63 'DeleteGroupPredefinedRulePublicV2' test.out

#- 64 GetMemberRolesListPublicV2
$CLI_EXE \
    --sn group \
    --op GetMemberRolesListPublicV2 \
    --namespace $AB_NAMESPACE \
    --limit '55' \
    --offset '69' \
    > test.out 2>&1
eval_tap $? 64 'GetMemberRolesListPublicV2' test.out

#- 65 UpdateMemberRolePublicV2
# body param: body
echo '{"userId": "GaXI7DNF"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateMemberRolePublicV2 \
    --groupId 'RTIyjQhZ' \
    --memberRoleId '0X1dH2Gr' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 65 'UpdateMemberRolePublicV2' test.out

#- 66 DeleteMemberRolePublicV2
# body param: body
echo '{"userId": "UvGcOt96"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op DeleteMemberRolePublicV2 \
    --groupId 'sAU4RAR0' \
    --memberRoleId 'A8QQQf4n' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 66 'DeleteMemberRolePublicV2' test.out

#- 67 GetUserGroupInformationPublicV2
$CLI_EXE \
    --sn group \
    --op GetUserGroupInformationPublicV2 \
    --namespace $AB_NAMESPACE \
    --limit '24' \
    --offset '40' \
    > test.out 2>&1
eval_tap $? 67 'GetUserGroupInformationPublicV2' test.out

#- 68 GetMyGroupJoinRequestV2
$CLI_EXE \
    --sn group \
    --op GetMyGroupJoinRequestV2 \
    --namespace $AB_NAMESPACE \
    --limit '92' \
    --offset '83' \
    > test.out 2>&1
eval_tap $? 68 'GetMyGroupJoinRequestV2' test.out

#- 69 InviteGroupPublicV2
$CLI_EXE \
    --sn group \
    --op InviteGroupPublicV2 \
    --groupId 'lLUAkWTj' \
    --namespace $AB_NAMESPACE \
    --userId 'FoSS1M6Q' \
    > test.out 2>&1
eval_tap $? 69 'InviteGroupPublicV2' test.out

#- 70 CancelInvitationGroupMemberV2
$CLI_EXE \
    --sn group \
    --op CancelInvitationGroupMemberV2 \
    --groupId 'aYB7Bvwm' \
    --namespace $AB_NAMESPACE \
    --userId 'OpcEKFWm' \
    > test.out 2>&1
eval_tap $? 70 'CancelInvitationGroupMemberV2' test.out

#- 71 AcceptGroupJoinRequestPublicV2
$CLI_EXE \
    --sn group \
    --op AcceptGroupJoinRequestPublicV2 \
    --groupId '3IXEwu99' \
    --namespace $AB_NAMESPACE \
    --userId '9F7x5nfR' \
    > test.out 2>&1
eval_tap $? 71 'AcceptGroupJoinRequestPublicV2' test.out

#- 72 RejectGroupJoinRequestPublicV2
$CLI_EXE \
    --sn group \
    --op RejectGroupJoinRequestPublicV2 \
    --groupId 'cGFTVUiX' \
    --namespace $AB_NAMESPACE \
    --userId 'c54wJ6Bu' \
    > test.out 2>&1
eval_tap $? 72 'RejectGroupJoinRequestPublicV2' test.out

#- 73 KickGroupMemberPublicV2
$CLI_EXE \
    --sn group \
    --op KickGroupMemberPublicV2 \
    --groupId 'S55VCmDH' \
    --namespace $AB_NAMESPACE \
    --userId 'LNzeNCwv' \
    > test.out 2>&1
eval_tap $? 73 'KickGroupMemberPublicV2' test.out

#- 74 GetUserGroupStatusInformationV2
$CLI_EXE \
    --sn group \
    --op GetUserGroupStatusInformationV2 \
    --groupId 'MTMX6wVh' \
    --namespace $AB_NAMESPACE \
    --userId 'SdrhJyGl' \
    > test.out 2>&1
eval_tap $? 74 'GetUserGroupStatusInformationV2' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE