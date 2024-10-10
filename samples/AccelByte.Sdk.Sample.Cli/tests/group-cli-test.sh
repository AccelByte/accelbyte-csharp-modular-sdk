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
    --limit '38' \
    --offset '88' \
    > test.out 2>&1
eval_tap $? 2 'ListGroupConfigurationAdminV1' test.out

#- 3 CreateGroupConfigurationAdminV1
# body param: body
echo '{"allowMultiple": true, "configurationCode": "ofWQC6WZ", "description": "Jg9t9EmV", "globalRules": [{"allowedAction": "FECZHlrp", "ruleDetail": [{"ruleAttribute": "tX0xYjS7", "ruleCriteria": "MINIMUM", "ruleValue": 0.19864388649420073}, {"ruleAttribute": "F8LoEfoa", "ruleCriteria": "MINIMUM", "ruleValue": 0.008884803165779664}, {"ruleAttribute": "QLSpktZL", "ruleCriteria": "MINIMUM", "ruleValue": 0.9770350433845707}]}, {"allowedAction": "RAxOTJH9", "ruleDetail": [{"ruleAttribute": "tqUeGKi1", "ruleCriteria": "EQUAL", "ruleValue": 0.4223526106969553}, {"ruleAttribute": "8EKoWPpe", "ruleCriteria": "EQUAL", "ruleValue": 0.5444088156006667}, {"ruleAttribute": "06aBTdqy", "ruleCriteria": "MAXIMUM", "ruleValue": 0.7481310210492024}]}, {"allowedAction": "PpHQzRew", "ruleDetail": [{"ruleAttribute": "K5YIzZMK", "ruleCriteria": "MINIMUM", "ruleValue": 0.07937723971994948}, {"ruleAttribute": "21MZk6vb", "ruleCriteria": "MAXIMUM", "ruleValue": 0.08928320693488145}, {"ruleAttribute": "iS1f7JXR", "ruleCriteria": "EQUAL", "ruleValue": 0.8694290672100389}]}], "groupAdminRoleId": "GstgzWS2", "groupMaxMember": 54, "groupMemberRoleId": "XMJI8Zzg", "name": "3ENQiaGv"}' > $TEMP_JSON_INPUT
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
    --configurationCode 'TnaPvteZ' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 5 'GetGroupConfigurationAdminV1' test.out

#- 6 DeleteGroupConfigurationV1
$CLI_EXE \
    --sn group \
    --op DeleteGroupConfigurationV1 \
    --configurationCode 'ykCkQTxI' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 6 'DeleteGroupConfigurationV1' test.out

#- 7 UpdateGroupConfigurationAdminV1
# body param: body
echo '{"description": "BhJm6aKF", "groupMaxMember": 88, "name": "iC5tt1S2"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateGroupConfigurationAdminV1 \
    --configurationCode 'GYm8dxCY' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 7 'UpdateGroupConfigurationAdminV1' test.out

#- 8 UpdateGroupConfigurationGlobalRuleAdminV1
# body param: body
echo '{"ruleDetail": [{"ruleAttribute": "Qv9oeabm", "ruleCriteria": "MINIMUM", "ruleValue": 0.22024890927417196}, {"ruleAttribute": "uP1auubB", "ruleCriteria": "EQUAL", "ruleValue": 0.639925699550929}, {"ruleAttribute": "vLusYRru", "ruleCriteria": "MINIMUM", "ruleValue": 0.05608604922483351}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateGroupConfigurationGlobalRuleAdminV1 \
    --allowedAction 'SajT3LqZ' \
    --configurationCode 'DTvr3DNU' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 8 'UpdateGroupConfigurationGlobalRuleAdminV1' test.out

#- 9 DeleteGroupConfigurationGlobalRuleAdminV1
$CLI_EXE \
    --sn group \
    --op DeleteGroupConfigurationGlobalRuleAdminV1 \
    --allowedAction 'AK8nyFK4' \
    --configurationCode 'IfpMsfgm' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 9 'DeleteGroupConfigurationGlobalRuleAdminV1' test.out

#- 10 GetGroupListAdminV1
$CLI_EXE \
    --sn group \
    --op GetGroupListAdminV1 \
    --namespace $AB_NAMESPACE \
    --configurationCode 'Z22uM56k' \
    --groupName 'LsRwcAfk' \
    --groupRegion '5XxuKkna' \
    --limit '36' \
    --offset '65' \
    > test.out 2>&1
eval_tap $? 10 'GetGroupListAdminV1' test.out

#- 11 GetSingleGroupAdminV1
$CLI_EXE \
    --sn group \
    --op GetSingleGroupAdminV1 \
    --groupId '2dtd8eiU' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 11 'GetSingleGroupAdminV1' test.out

#- 12 DeleteGroupAdminV1
$CLI_EXE \
    --sn group \
    --op DeleteGroupAdminV1 \
    --groupId '8D6qoRpg' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 12 'DeleteGroupAdminV1' test.out

#- 13 GetGroupMembersListAdminV1
$CLI_EXE \
    --sn group \
    --op GetGroupMembersListAdminV1 \
    --groupId 'QMLLbGjC' \
    --namespace $AB_NAMESPACE \
    --limit '84' \
    --offset '62' \
    --order 'uR2fDriI' \
    > test.out 2>&1
eval_tap $? 13 'GetGroupMembersListAdminV1' test.out

#- 14 GetMemberRolesListAdminV1
$CLI_EXE \
    --sn group \
    --op GetMemberRolesListAdminV1 \
    --namespace $AB_NAMESPACE \
    --limit '62' \
    --offset '80' \
    > test.out 2>&1
eval_tap $? 14 'GetMemberRolesListAdminV1' test.out

#- 15 CreateMemberRoleAdminV1
# body param: body
echo '{"memberRoleName": "73jy4rkI", "memberRolePermissions": [{"action": 86, "resourceName": "pyTr7m8w"}, {"action": 8, "resourceName": "PwQzmOLL"}, {"action": 88, "resourceName": "PHFZwy5d"}]}' > $TEMP_JSON_INPUT
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
    --memberRoleId 's7aztaE0' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 16 'GetSingleMemberRoleAdminV1' test.out

#- 17 DeleteMemberRoleAdminV1
$CLI_EXE \
    --sn group \
    --op DeleteMemberRoleAdminV1 \
    --memberRoleId '9IDzfzt5' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 17 'DeleteMemberRoleAdminV1' test.out

#- 18 UpdateMemberRoleAdminV1
# body param: body
echo '{"memberRoleName": "UEt7AuTH"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateMemberRoleAdminV1 \
    --memberRoleId 'STdh84HI' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 18 'UpdateMemberRoleAdminV1' test.out

#- 19 UpdateMemberRolePermissionAdminV1
# body param: body
echo '{"memberRolePermissions": [{"action": 20, "resourceName": "afrNFXWG"}, {"action": 14, "resourceName": "Q5UXlcnL"}, {"action": 69, "resourceName": "YA7CjdBp"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateMemberRolePermissionAdminV1 \
    --memberRoleId 'boN9oWAE' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 19 'UpdateMemberRolePermissionAdminV1' test.out

#- 20 GetGroupListPublicV1
$CLI_EXE \
    --sn group \
    --op GetGroupListPublicV1 \
    --namespace $AB_NAMESPACE \
    --groupName '8yBkB8aw' \
    --groupRegion 'jxLNp72J' \
    --limit '52' \
    --offset '33' \
    > test.out 2>&1
eval_tap $? 20 'GetGroupListPublicV1' test.out

#- 21 CreateNewGroupPublicV1
# body param: body
echo '{"configurationCode": "KXIbqWqX", "customAttributes": {"iNGTHrkY": {}, "bbgKmv3Y": {}, "VUoDFJzc": {}}, "groupDescription": "WTOPixBk", "groupIcon": "LiOmmkXy", "groupMaxMember": 63, "groupName": "EsXgyXPB", "groupRegion": "KZDfqk63", "groupRules": {"groupCustomRule": {}, "groupPredefinedRules": [{"allowedAction": "Ea6REpFb", "ruleDetail": [{"ruleAttribute": "vMe3rhDy", "ruleCriteria": "EQUAL", "ruleValue": 0.3712815262675707}, {"ruleAttribute": "Ya7KpLiX", "ruleCriteria": "MINIMUM", "ruleValue": 0.6593412039591133}, {"ruleAttribute": "SmvCWa5M", "ruleCriteria": "EQUAL", "ruleValue": 0.2587840607336238}]}, {"allowedAction": "x5UvAvWv", "ruleDetail": [{"ruleAttribute": "uA2ZXC7M", "ruleCriteria": "EQUAL", "ruleValue": 0.826116100715396}, {"ruleAttribute": "SMM7d1vE", "ruleCriteria": "MAXIMUM", "ruleValue": 0.11364121181209108}, {"ruleAttribute": "RRhTXrYC", "ruleCriteria": "MAXIMUM", "ruleValue": 0.9726869320039891}]}, {"allowedAction": "5wROTUu8", "ruleDetail": [{"ruleAttribute": "Rty0E8yc", "ruleCriteria": "MAXIMUM", "ruleValue": 0.7404864775563971}, {"ruleAttribute": "IQmk5q51", "ruleCriteria": "EQUAL", "ruleValue": 0.6848460921538471}, {"ruleAttribute": "4DbMsSH4", "ruleCriteria": "MINIMUM", "ruleValue": 0.6301609475023464}]}]}, "groupType": "PUBLIC"}' > $TEMP_JSON_INPUT
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
    --groupId 'bz1fecUE' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 22 'GetSingleGroupPublicV1' test.out

#- 23 UpdateSingleGroupV1
# body param: body
echo '{"customAttributes": {}, "groupDescription": "vzXiPEiB", "groupIcon": "AcaKYqWE", "groupName": "OsRGTOX2", "groupRegion": "sg170ddY", "groupType": "PRIVATE"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateSingleGroupV1 \
    --groupId 'hxTIqDCj' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 23 'UpdateSingleGroupV1' test.out

#- 24 DeleteGroupPublicV1
$CLI_EXE \
    --sn group \
    --op DeleteGroupPublicV1 \
    --groupId 'YKMCH2X0' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 24 'DeleteGroupPublicV1' test.out

#- 25 UpdatePatchSingleGroupPublicV1
# body param: body
echo '{"customAttributes": {}, "groupDescription": "O4Vthhq2", "groupIcon": "YeOD7l13", "groupName": "Ytnr62G1", "groupRegion": "GeANsSGX", "groupType": "PUBLIC"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdatePatchSingleGroupPublicV1 \
    --groupId 'xaLXfIwA' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 25 'UpdatePatchSingleGroupPublicV1' test.out

#- 26 UpdateGroupCustomAttributesPublicV1
# body param: body
echo '{"customAttributes": {"eGGEfsl3": {}, "EXQTalpE": {}, "0JxESgmY": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateGroupCustomAttributesPublicV1 \
    --groupId 'TK0mdmue' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 26 'UpdateGroupCustomAttributesPublicV1' test.out

#- 27 AcceptGroupInvitationPublicV1
$CLI_EXE \
    --sn group \
    --op AcceptGroupInvitationPublicV1 \
    --groupId 'Mkm7edGi' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 27 'AcceptGroupInvitationPublicV1' test.out

#- 28 RejectGroupInvitationPublicV1
$CLI_EXE \
    --sn group \
    --op RejectGroupInvitationPublicV1 \
    --groupId '0BnYTJtj' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 28 'RejectGroupInvitationPublicV1' test.out

#- 29 JoinGroupV1
$CLI_EXE \
    --sn group \
    --op JoinGroupV1 \
    --groupId 'DpkeTWL7' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 29 'JoinGroupV1' test.out

#- 30 CancelGroupJoinRequestV1
$CLI_EXE \
    --sn group \
    --op CancelGroupJoinRequestV1 \
    --groupId 'WHg8aFRG' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 30 'CancelGroupJoinRequestV1' test.out

#- 31 GetGroupJoinRequestPublicV1
$CLI_EXE \
    --sn group \
    --op GetGroupJoinRequestPublicV1 \
    --groupId 'pYyNGgWp' \
    --namespace $AB_NAMESPACE \
    --limit '0' \
    --offset '46' \
    > test.out 2>&1
eval_tap $? 31 'GetGroupJoinRequestPublicV1' test.out

#- 32 GetGroupMembersListPublicV1
$CLI_EXE \
    --sn group \
    --op GetGroupMembersListPublicV1 \
    --groupId 'LDRtTlwa' \
    --namespace $AB_NAMESPACE \
    --limit '32' \
    --offset '90' \
    --order 'cLtx5oHa' \
    > test.out 2>&1
eval_tap $? 32 'GetGroupMembersListPublicV1' test.out

#- 33 UpdateGroupCustomRulePublicV1
# body param: body
echo '{"groupCustomRule": {"I8HThPYZ": {}, "an4XOcRp": {}, "3rO0wKjh": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateGroupCustomRulePublicV1 \
    --groupId 'c4FaqLuS' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 33 'UpdateGroupCustomRulePublicV1' test.out

#- 34 UpdateGroupPredefinedRulePublicV1
# body param: body
echo '{"ruleDetail": [{"ruleAttribute": "TM2nxBhX", "ruleCriteria": "MINIMUM", "ruleValue": 0.053428027471433825}, {"ruleAttribute": "8032cOP0", "ruleCriteria": "EQUAL", "ruleValue": 0.22821914806294263}, {"ruleAttribute": "eBoj7lqV", "ruleCriteria": "EQUAL", "ruleValue": 0.2203422467819417}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateGroupPredefinedRulePublicV1 \
    --allowedAction 'a0E3GnL1' \
    --groupId 'Da4k77ka' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 34 'UpdateGroupPredefinedRulePublicV1' test.out

#- 35 DeleteGroupPredefinedRulePublicV1
$CLI_EXE \
    --sn group \
    --op DeleteGroupPredefinedRulePublicV1 \
    --allowedAction 'WtnUOvaL' \
    --groupId '4DrzPdpV' \
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
    --limit '68' \
    --offset '79' \
    > test.out 2>&1
eval_tap $? 37 'GetMemberRolesListPublicV1' test.out

#- 38 UpdateMemberRolePublicV1
# body param: body
echo '{"userId": "ueAuUMOq"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateMemberRolePublicV1 \
    --memberRoleId 'bIXxKHgr' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 38 'UpdateMemberRolePublicV1' test.out

#- 39 DeleteMemberRolePublicV1
# body param: body
echo '{"userId": "rmsmueQr"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op DeleteMemberRolePublicV1 \
    --memberRoleId 'CvSga0j5' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 39 'DeleteMemberRolePublicV1' test.out

#- 40 GetGroupInvitationRequestPublicV1
$CLI_EXE \
    --sn group \
    --op GetGroupInvitationRequestPublicV1 \
    --namespace $AB_NAMESPACE \
    --limit '66' \
    --offset '77' \
    > test.out 2>&1
eval_tap $? 40 'GetGroupInvitationRequestPublicV1' test.out

#- 41 GetUserGroupInformationPublicV1
$CLI_EXE \
    --sn group \
    --op GetUserGroupInformationPublicV1 \
    --namespace $AB_NAMESPACE \
    --userId 'myebVVwb' \
    > test.out 2>&1
eval_tap $? 41 'GetUserGroupInformationPublicV1' test.out

#- 42 InviteGroupPublicV1
$CLI_EXE \
    --sn group \
    --op InviteGroupPublicV1 \
    --namespace $AB_NAMESPACE \
    --userId '6OHfj7vV' \
    > test.out 2>&1
eval_tap $? 42 'InviteGroupPublicV1' test.out

#- 43 AcceptGroupJoinRequestPublicV1
$CLI_EXE \
    --sn group \
    --op AcceptGroupJoinRequestPublicV1 \
    --namespace $AB_NAMESPACE \
    --userId 'EEC1kkK1' \
    > test.out 2>&1
eval_tap $? 43 'AcceptGroupJoinRequestPublicV1' test.out

#- 44 RejectGroupJoinRequestPublicV1
$CLI_EXE \
    --sn group \
    --op RejectGroupJoinRequestPublicV1 \
    --namespace $AB_NAMESPACE \
    --userId 'OFSU63dA' \
    > test.out 2>&1
eval_tap $? 44 'RejectGroupJoinRequestPublicV1' test.out

#- 45 KickGroupMemberPublicV1
$CLI_EXE \
    --sn group \
    --op KickGroupMemberPublicV1 \
    --namespace $AB_NAMESPACE \
    --userId '5U9iXkLh' \
    > test.out 2>&1
eval_tap $? 45 'KickGroupMemberPublicV1' test.out

#- 46 GetListGroupByIDsAdminV2
# body param: body
echo '{"groupIDs": ["Mf7z4rFX", "yl02Jlho", "uqYFIvXQ"]}' > $TEMP_JSON_INPUT
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
    --userId '8pp2Gfwy' \
    --limit '57' \
    --offset '56' \
    > test.out 2>&1
eval_tap $? 47 'GetUserJoinedGroupInformationPublicV2' test.out

#- 48 AdminGetUserGroupStatusInformationV2
$CLI_EXE \
    --sn group \
    --op AdminGetUserGroupStatusInformationV2 \
    --groupId 'DNr3Ao1Z' \
    --namespace $AB_NAMESPACE \
    --userId 'FfrLPqXK' \
    > test.out 2>&1
eval_tap $? 48 'AdminGetUserGroupStatusInformationV2' test.out

#- 49 CreateNewGroupPublicV2
# body param: body
echo '{"configurationCode": "E7Hh58d2", "customAttributes": {"JWOq5XMw": {}, "3d8nFsXU": {}, "RiLekUak": {}}, "groupDescription": "v6jdYZrD", "groupIcon": "vrtbUC1y", "groupMaxMember": 9, "groupName": "TAoUcFdA", "groupRegion": "9b13lz4Q", "groupRules": {"groupCustomRule": {}, "groupPredefinedRules": [{"allowedAction": "l66fbgYn", "ruleDetail": [{"ruleAttribute": "2wGdzkZW", "ruleCriteria": "MINIMUM", "ruleValue": 0.2539984045419278}, {"ruleAttribute": "W8FQm1id", "ruleCriteria": "MINIMUM", "ruleValue": 0.8648454198616398}, {"ruleAttribute": "0RT1Zpzr", "ruleCriteria": "MINIMUM", "ruleValue": 0.5667475399967095}]}, {"allowedAction": "28nKoZcI", "ruleDetail": [{"ruleAttribute": "vTDYbPTU", "ruleCriteria": "EQUAL", "ruleValue": 0.5446598816116169}, {"ruleAttribute": "v1iKf4he", "ruleCriteria": "MINIMUM", "ruleValue": 0.32038673376799576}, {"ruleAttribute": "dj5bGyCA", "ruleCriteria": "MINIMUM", "ruleValue": 0.5076949147150815}]}, {"allowedAction": "CpeQDCcW", "ruleDetail": [{"ruleAttribute": "PmWa8dvv", "ruleCriteria": "MINIMUM", "ruleValue": 0.2183601019753304}, {"ruleAttribute": "msJA6Upn", "ruleCriteria": "MINIMUM", "ruleValue": 0.22811424295035976}, {"ruleAttribute": "Ml9UhiEn", "ruleCriteria": "MINIMUM", "ruleValue": 0.7818767555284767}]}]}, "groupType": "OPEN"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op CreateNewGroupPublicV2 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 49 'CreateNewGroupPublicV2' test.out

#- 50 GetListGroupByIDsV2
# body param: body
echo '{"groupIDs": ["SStmB5J5", "p8OmD2tc", "CXLH6LT4"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op GetListGroupByIDsV2 \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 50 'GetListGroupByIDsV2' test.out

#- 51 UpdatePutSingleGroupPublicV2
# body param: body
echo '{"customAttributes": {}, "groupDescription": "qz9lDC2v", "groupIcon": "JS6btsuq", "groupName": "HmTSVcLN", "groupRegion": "YCrKCf0R", "groupType": "PUBLIC"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdatePutSingleGroupPublicV2 \
    --groupId 'ep4Epg2V' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 51 'UpdatePutSingleGroupPublicV2' test.out

#- 52 DeleteGroupPublicV2
$CLI_EXE \
    --sn group \
    --op DeleteGroupPublicV2 \
    --groupId 'zhko4xU3' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 52 'DeleteGroupPublicV2' test.out

#- 53 UpdatePatchSingleGroupPublicV2
# body param: body
echo '{"customAttributes": {}, "groupDescription": "uagrfAdQ", "groupIcon": "I27xi4kn", "groupName": "C4Fw14cN", "groupRegion": "zT2XhvUP", "groupType": "PRIVATE"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdatePatchSingleGroupPublicV2 \
    --groupId 'kkdeFGPb' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 53 'UpdatePatchSingleGroupPublicV2' test.out

#- 54 UpdateGroupCustomAttributesPublicV2
# body param: body
echo '{"customAttributes": {"JU97Ak07": {}, "HVSmdiHo": {}, "VfHq8Xa7": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateGroupCustomAttributesPublicV2 \
    --groupId 'JyB2Mlyy' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 54 'UpdateGroupCustomAttributesPublicV2' test.out

#- 55 AcceptGroupInvitationPublicV2
$CLI_EXE \
    --sn group \
    --op AcceptGroupInvitationPublicV2 \
    --groupId 'Q2Rvba8V' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 55 'AcceptGroupInvitationPublicV2' test.out

#- 56 RejectGroupInvitationPublicV2
$CLI_EXE \
    --sn group \
    --op RejectGroupInvitationPublicV2 \
    --groupId 'znaT8ZM9' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 56 'RejectGroupInvitationPublicV2' test.out

#- 57 GetGroupInviteRequestPublicV2
$CLI_EXE \
    --sn group \
    --op GetGroupInviteRequestPublicV2 \
    --groupId 'bBOFoRkk' \
    --namespace $AB_NAMESPACE \
    --limit '27' \
    --offset '86' \
    > test.out 2>&1
eval_tap $? 57 'GetGroupInviteRequestPublicV2' test.out

#- 58 JoinGroupV2
$CLI_EXE \
    --sn group \
    --op JoinGroupV2 \
    --groupId 'OHZmTdGB' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 58 'JoinGroupV2' test.out

#- 59 GetGroupJoinRequestPublicV2
$CLI_EXE \
    --sn group \
    --op GetGroupJoinRequestPublicV2 \
    --groupId 'EV9oOXm2' \
    --namespace $AB_NAMESPACE \
    --limit '72' \
    --offset '86' \
    > test.out 2>&1
eval_tap $? 59 'GetGroupJoinRequestPublicV2' test.out

#- 60 LeaveGroupPublicV2
$CLI_EXE \
    --sn group \
    --op LeaveGroupPublicV2 \
    --groupId 'UXLVNEtp' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 60 'LeaveGroupPublicV2' test.out

#- 61 UpdateGroupCustomRulePublicV2
# body param: body
echo '{"groupCustomRule": {"XpDdBCSC": {}, "XYCqD7S8": {}, "sJiQR9qK": {}}}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateGroupCustomRulePublicV2 \
    --groupId 'HQbBdPnc' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 61 'UpdateGroupCustomRulePublicV2' test.out

#- 62 UpdateGroupPredefinedRulePublicV2
# body param: body
echo '{"ruleDetail": [{"ruleAttribute": "2vSAFnKt", "ruleCriteria": "MINIMUM", "ruleValue": 0.7883659837238995}, {"ruleAttribute": "mqZoyYjY", "ruleCriteria": "MAXIMUM", "ruleValue": 0.827421429588986}, {"ruleAttribute": "0iT44hQ2", "ruleCriteria": "MINIMUM", "ruleValue": 0.256064714946622}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateGroupPredefinedRulePublicV2 \
    --allowedAction 'pBsN4GdF' \
    --groupId 'T5JnyAxk' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 62 'UpdateGroupPredefinedRulePublicV2' test.out

#- 63 DeleteGroupPredefinedRulePublicV2
$CLI_EXE \
    --sn group \
    --op DeleteGroupPredefinedRulePublicV2 \
    --allowedAction 'oq5KwCex' \
    --groupId 'dP8l0unH' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 63 'DeleteGroupPredefinedRulePublicV2' test.out

#- 64 GetMemberRolesListPublicV2
$CLI_EXE \
    --sn group \
    --op GetMemberRolesListPublicV2 \
    --namespace $AB_NAMESPACE \
    --limit '47' \
    --offset '85' \
    > test.out 2>&1
eval_tap $? 64 'GetMemberRolesListPublicV2' test.out

#- 65 UpdateMemberRolePublicV2
# body param: body
echo '{"userId": "2IACK4rv"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op UpdateMemberRolePublicV2 \
    --groupId 'vsLPW4vp' \
    --memberRoleId 'qnqJupb4' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 65 'UpdateMemberRolePublicV2' test.out

#- 66 DeleteMemberRolePublicV2
# body param: body
echo '{"userId": "CoyjrJuH"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn group \
    --op DeleteMemberRolePublicV2 \
    --groupId 'CBfiz59m' \
    --memberRoleId 'YB7rpa9g' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 66 'DeleteMemberRolePublicV2' test.out

#- 67 GetUserGroupInformationPublicV2
$CLI_EXE \
    --sn group \
    --op GetUserGroupInformationPublicV2 \
    --namespace $AB_NAMESPACE \
    --limit '58' \
    --offset '1' \
    > test.out 2>&1
eval_tap $? 67 'GetUserGroupInformationPublicV2' test.out

#- 68 GetMyGroupJoinRequestV2
$CLI_EXE \
    --sn group \
    --op GetMyGroupJoinRequestV2 \
    --namespace $AB_NAMESPACE \
    --limit '81' \
    --offset '76' \
    > test.out 2>&1
eval_tap $? 68 'GetMyGroupJoinRequestV2' test.out

#- 69 InviteGroupPublicV2
$CLI_EXE \
    --sn group \
    --op InviteGroupPublicV2 \
    --groupId 'vc2mFSt9' \
    --namespace $AB_NAMESPACE \
    --userId 'FozcNFOH' \
    > test.out 2>&1
eval_tap $? 69 'InviteGroupPublicV2' test.out

#- 70 CancelInvitationGroupMemberV2
$CLI_EXE \
    --sn group \
    --op CancelInvitationGroupMemberV2 \
    --groupId 'rlm6UPEP' \
    --namespace $AB_NAMESPACE \
    --userId 'myPqTCfM' \
    > test.out 2>&1
eval_tap $? 70 'CancelInvitationGroupMemberV2' test.out

#- 71 AcceptGroupJoinRequestPublicV2
$CLI_EXE \
    --sn group \
    --op AcceptGroupJoinRequestPublicV2 \
    --groupId 'P9T0L2Pu' \
    --namespace $AB_NAMESPACE \
    --userId 'hMjoqeCR' \
    > test.out 2>&1
eval_tap $? 71 'AcceptGroupJoinRequestPublicV2' test.out

#- 72 RejectGroupJoinRequestPublicV2
$CLI_EXE \
    --sn group \
    --op RejectGroupJoinRequestPublicV2 \
    --groupId 'PWUhMT3W' \
    --namespace $AB_NAMESPACE \
    --userId 'w7GTnFCc' \
    > test.out 2>&1
eval_tap $? 72 'RejectGroupJoinRequestPublicV2' test.out

#- 73 KickGroupMemberPublicV2
$CLI_EXE \
    --sn group \
    --op KickGroupMemberPublicV2 \
    --groupId 'lc8w9oRJ' \
    --namespace $AB_NAMESPACE \
    --userId 'SS3beO46' \
    > test.out 2>&1
eval_tap $? 73 'KickGroupMemberPublicV2' test.out

#- 74 GetUserGroupStatusInformationV2
$CLI_EXE \
    --sn group \
    --op GetUserGroupStatusInformationV2 \
    --groupId 'kYQNm6rD' \
    --namespace $AB_NAMESPACE \
    --userId 'nXrfdoDo' \
    > test.out 2>&1
eval_tap $? 74 'GetUserGroupStatusInformationV2' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE