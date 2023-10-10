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
echo "1..95"

#- 1 Login
$CLI_EXE --op login --lt user --user user --pass user > test.out 2>&1
eval_tap $? 1 'Login' test.out

if [ $EXIT_CODE -ne 0 ]; then
  echo "Bail out! Login failed."
  exit $EXIT_CODE
fi

# echo "foo" > "$CLI_TOKEN_FILE"

#- 2 SingleAdminGetChannel
$CLI_EXE \
    --sn ugc \
    --op SingleAdminGetChannel \
    --namespace $AB_NAMESPACE \
    --limit '84' \
    --offset '86' \
    > test.out 2>&1
eval_tap $? 2 'SingleAdminGetChannel' test.out

#- 3 AdminCreateChannel
# body param: body
echo '{"id": "21aI5Rxo", "name": "Pz88T6Or"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminCreateChannel \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 3 'AdminCreateChannel' test.out

#- 4 SingleAdminUpdateChannel
# body param: body
echo '{"name": "AJ0V5kVX"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op SingleAdminUpdateChannel \
    --channelId 'gB6NGqzG' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 4 'SingleAdminUpdateChannel' test.out

#- 5 SingleAdminDeleteChannel
$CLI_EXE \
    --sn ugc \
    --op SingleAdminDeleteChannel \
    --channelId '2rN5MQ6V' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 5 'SingleAdminDeleteChannel' test.out

#- 6 AdminUploadContentDirect
eval_tap 0 6 'AdminUploadContentDirect # SKIP deprecated' test.out

#- 7 AdminUploadContentS3
# body param: body
echo '{"contentType": "fo3mULUv", "customAttributes": {"TUezqUEN": {}, "DhAqyfn0": {}, "lUe3LQpc": {}}, "fileExtension": "Vybd3w51", "name": "A8EaPrDT", "preview": "l4WSRzcP", "previewMetadata": {"previewContentType": "8yuSd0Xs", "previewFileExtension": "9oiib5Nr"}, "shareCode": "ts50FFUZ", "subType": "oDYBbLPQ", "tags": ["ougmQSBl", "uVCobMmz", "RSevzSMa"], "type": "JD6TrC95"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminUploadContentS3 \
    --channelId 'MfQj6FSv' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 7 'AdminUploadContentS3' test.out

#- 8 SingleAdminUpdateContentS3
# body param: body
echo '{"contentType": "ftVdvId1", "customAttributes": {"M65L8cOd": {}, "SO1EXkuZ": {}, "ptuqQkMt": {}}, "fileExtension": "35a2uBiQ", "name": "Z60laLHs", "payload": "xkgQ8T0B", "preview": "CHuIxWxK", "previewMetadata": {"previewContentType": "ytU7JMqf", "previewFileExtension": "MOx9jWmj"}, "shareCode": "ApESvSla", "subType": "H6LREyGE", "tags": ["i7ctlPtv", "cuc2QFHW", "sL0UdTZr"], "type": "lQ2hBD1T", "updateContentFile": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op SingleAdminUpdateContentS3 \
    --channelId 'FUwILuzN' \
    --contentId 'RtwMErqu' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 8 'SingleAdminUpdateContentS3' test.out

#- 9 AdminSearchChannelSpecificContent
$CLI_EXE \
    --sn ugc \
    --op AdminSearchChannelSpecificContent \
    --channelId 'ZTy9MOYl' \
    --namespace $AB_NAMESPACE \
    --creator '8gBdUGk1' \
    --isofficial 'OrY157Re' \
    --limit '52' \
    --name '0ZfKG93A' \
    --offset '97' \
    --orderby 'c4rIe8f4' \
    --sortby 'MoerEmzX' \
    --subtype 'AnygeW3i' \
    --tags '["6AoFIw4z", "2kvxHzZE", "3WNEEc09"]' \
    --type '5unmx02s' \
    --userId 'YwsEO7DC' \
    > test.out 2>&1
eval_tap $? 9 'AdminSearchChannelSpecificContent' test.out

#- 10 SingleAdminUpdateContentDirect
eval_tap 0 10 'SingleAdminUpdateContentDirect # SKIP deprecated' test.out

#- 11 SingleAdminDeleteContent
$CLI_EXE \
    --sn ugc \
    --op SingleAdminDeleteContent \
    --channelId 'k5784vEe' \
    --contentId 'QaGvotX5' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 11 'SingleAdminDeleteContent' test.out

#- 12 SingleAdminGetContent
$CLI_EXE \
    --sn ugc \
    --op SingleAdminGetContent \
    --namespace $AB_NAMESPACE \
    --limit '76' \
    --offset '26' \
    > test.out 2>&1
eval_tap $? 12 'SingleAdminGetContent' test.out

#- 13 AdminGetContentBulk
# body param: body
echo '{"contentIds": ["ZyXf0Fb9", "baakRz3X", "DJHtWuNQ"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminGetContentBulk \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 13 'AdminGetContentBulk' test.out

#- 14 AdminSearchContent
$CLI_EXE \
    --sn ugc \
    --op AdminSearchContent \
    --namespace $AB_NAMESPACE \
    --creator 'sRtaEJV7' \
    --isofficial '9CULb8bQ' \
    --limit '75' \
    --name 'cuJDEM4u' \
    --offset '28' \
    --orderby 'e09Jrfi2' \
    --sortby 'x0sFcIIy' \
    --subtype 'ZtYKD5jT' \
    --tags '["7A16KAbb", "EBFefL7E", "sp8Rxdhv"]' \
    --type 'fvcRPPZv' \
    --userId 'VUxfV10M' \
    > test.out 2>&1
eval_tap $? 14 'AdminSearchContent' test.out

#- 15 AdminGetContentBulkByShareCodes
# body param: body
echo '{"shareCodes": ["ouSu3wJb", "ljSf6sHV", "iKAmNsPR"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminGetContentBulkByShareCodes \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 15 'AdminGetContentBulkByShareCodes' test.out

#- 16 AdminGetUserContentByShareCode
$CLI_EXE \
    --sn ugc \
    --op AdminGetUserContentByShareCode \
    --namespace $AB_NAMESPACE \
    --shareCode 'm9RMPyNs' \
    > test.out 2>&1
eval_tap $? 16 'AdminGetUserContentByShareCode' test.out

#- 17 AdminGetSpecificContent
$CLI_EXE \
    --sn ugc \
    --op AdminGetSpecificContent \
    --contentId '3mfmycDT' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 17 'AdminGetSpecificContent' test.out

#- 18 AdminDownloadContentPreview
$CLI_EXE \
    --sn ugc \
    --op AdminDownloadContentPreview \
    --contentId 'DYtCW6Dp' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 18 'AdminDownloadContentPreview' test.out

#- 19 RollbackContentVersion
$CLI_EXE \
    --sn ugc \
    --op RollbackContentVersion \
    --contentId '2A0YzVpL' \
    --namespace $AB_NAMESPACE \
    --versionId 'JEHTN8sg' \
    > test.out 2>&1
eval_tap $? 19 'RollbackContentVersion' test.out

#- 20 AdminUpdateScreenshots
# body param: body
echo '{"screenshots": [{"description": "4KJi3Ode", "screenshotId": "oe8U3ArX"}, {"description": "GXlrgRYH", "screenshotId": "6mqu1zMg"}, {"description": "xFvQ5oyE", "screenshotId": "BIQblcOG"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminUpdateScreenshots \
    --contentId 'voccm5Eb' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 20 'AdminUpdateScreenshots' test.out

#- 21 AdminUploadContentScreenshot
# body param: body
echo '{"screenshots": [{"contentType": "GO3S7SGd", "description": "mkjoZ03L", "fileExtension": "jfif"}, {"contentType": "g46xiP4p", "description": "T8HLW9PJ", "fileExtension": "bmp"}, {"contentType": "oH0U1Pv1", "description": "XFbhMj5Z", "fileExtension": "jpeg"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminUploadContentScreenshot \
    --contentId '2toHSq7v' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 21 'AdminUploadContentScreenshot' test.out

#- 22 AdminDeleteContentScreenshot
$CLI_EXE \
    --sn ugc \
    --op AdminDeleteContentScreenshot \
    --contentId 'sFPPSsQ0' \
    --namespace $AB_NAMESPACE \
    --screenshotId 'OOULXYqy' \
    > test.out 2>&1
eval_tap $? 22 'AdminDeleteContentScreenshot' test.out

#- 23 ListContentVersions
$CLI_EXE \
    --sn ugc \
    --op ListContentVersions \
    --contentId 'Geupukuz' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 23 'ListContentVersions' test.out

#- 24 SingleAdminGetAllGroups
$CLI_EXE \
    --sn ugc \
    --op SingleAdminGetAllGroups \
    --namespace $AB_NAMESPACE \
    --limit '79' \
    --offset '19' \
    > test.out 2>&1
eval_tap $? 24 'SingleAdminGetAllGroups' test.out

#- 25 AdminCreateGroup
# body param: body
echo '{"contents": ["A9o885xk", "aAB4DhLK", "ET4PUqI4"], "name": "v4AzuULZ"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminCreateGroup \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 25 'AdminCreateGroup' test.out

#- 26 SingleAdminGetGroup
$CLI_EXE \
    --sn ugc \
    --op SingleAdminGetGroup \
    --groupId 'lA36PqfB' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 26 'SingleAdminGetGroup' test.out

#- 27 SingleAdminUpdateGroup
# body param: body
echo '{"contents": ["ypvpYPpH", "pD0lNo4w", "G2mbQFn5"], "name": "WrBd82zB"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op SingleAdminUpdateGroup \
    --groupId 'owFTaZkV' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 27 'SingleAdminUpdateGroup' test.out

#- 28 SingleAdminDeleteGroup
$CLI_EXE \
    --sn ugc \
    --op SingleAdminDeleteGroup \
    --groupId 'jwuyz5ed' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 28 'SingleAdminDeleteGroup' test.out

#- 29 SingleAdminGetGroupContents
$CLI_EXE \
    --sn ugc \
    --op SingleAdminGetGroupContents \
    --groupId 'L6jFzGVD' \
    --namespace $AB_NAMESPACE \
    --limit '38' \
    --offset '43' \
    > test.out 2>&1
eval_tap $? 29 'SingleAdminGetGroupContents' test.out

#- 30 AdminGetTag
$CLI_EXE \
    --sn ugc \
    --op AdminGetTag \
    --namespace $AB_NAMESPACE \
    --limit '16' \
    --offset '75' \
    > test.out 2>&1
eval_tap $? 30 'AdminGetTag' test.out

#- 31 AdminCreateTag
# body param: body
echo '{"tag": "TAPnTe6s"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminCreateTag \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 31 'AdminCreateTag' test.out

#- 32 AdminUpdateTag
# body param: body
echo '{"tag": "14T2gKmh"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminUpdateTag \
    --namespace $AB_NAMESPACE \
    --tagId 'fH0dogFi' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 32 'AdminUpdateTag' test.out

#- 33 AdminDeleteTag
$CLI_EXE \
    --sn ugc \
    --op AdminDeleteTag \
    --namespace $AB_NAMESPACE \
    --tagId 'DqsHltK7' \
    > test.out 2>&1
eval_tap $? 33 'AdminDeleteTag' test.out

#- 34 AdminGetType
$CLI_EXE \
    --sn ugc \
    --op AdminGetType \
    --namespace $AB_NAMESPACE \
    --limit '54' \
    --offset '11' \
    > test.out 2>&1
eval_tap $? 34 'AdminGetType' test.out

#- 35 AdminCreateType
# body param: body
echo '{"subtype": ["4hqdlDPP", "bZe2ZvDr", "Xg14WKE0"], "type": "kfqTuRd4"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminCreateType \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 35 'AdminCreateType' test.out

#- 36 AdminUpdateType
# body param: body
echo '{"subtype": ["mEtuxxYo", "ZNPSwc4q", "BUQwPyXn"], "type": "Tzqtxw3R"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminUpdateType \
    --namespace $AB_NAMESPACE \
    --typeId 'Jhb13fYa' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 36 'AdminUpdateType' test.out

#- 37 AdminDeleteType
$CLI_EXE \
    --sn ugc \
    --op AdminDeleteType \
    --namespace $AB_NAMESPACE \
    --typeId 'hixU0A7A' \
    > test.out 2>&1
eval_tap $? 37 'AdminDeleteType' test.out

#- 38 AdminGetChannel
$CLI_EXE \
    --sn ugc \
    --op AdminGetChannel \
    --namespace $AB_NAMESPACE \
    --userId 'KD3tUMWa' \
    --limit '97' \
    --name 'gOMOrogh' \
    --offset '81' \
    > test.out 2>&1
eval_tap $? 38 'AdminGetChannel' test.out

#- 39 AdminDeleteAllUserChannels
$CLI_EXE \
    --sn ugc \
    --op AdminDeleteAllUserChannels \
    --namespace $AB_NAMESPACE \
    --userId '59bAZ46N' \
    > test.out 2>&1
eval_tap $? 39 'AdminDeleteAllUserChannels' test.out

#- 40 AdminUpdateChannel
# body param: body
echo '{"name": "SW7ozZIP"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminUpdateChannel \
    --channelId 'EONFCYJb' \
    --namespace $AB_NAMESPACE \
    --userId 'I1k9sBNG' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 40 'AdminUpdateChannel' test.out

#- 41 AdminDeleteChannel
$CLI_EXE \
    --sn ugc \
    --op AdminDeleteChannel \
    --channelId 'bXMDlakV' \
    --namespace $AB_NAMESPACE \
    --userId 'VTp7pwhh' \
    > test.out 2>&1
eval_tap $? 41 'AdminDeleteChannel' test.out

#- 42 AdminUpdateContentS3
# body param: body
echo '{"contentType": "t748SahJ", "customAttributes": {"UpS5vDgc": {}, "GCkgWfbe": {}, "Rgfoalnx": {}}, "fileExtension": "27BKYIus", "name": "HuMtrfE6", "payload": "B8M9xGcy", "preview": "6qVQnBpw", "previewMetadata": {"previewContentType": "qKwoQuHn", "previewFileExtension": "78ffhPve"}, "shareCode": "E7ND8La2", "subType": "068vpwkg", "tags": ["Bkti2U1W", "V6eZXgJz", "mG4hjiG4"], "type": "TMZcjhtk", "updateContentFile": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminUpdateContentS3 \
    --channelId '4H3Btexy' \
    --contentId 'XpksDrGc' \
    --namespace $AB_NAMESPACE \
    --userId '9wgmlevS' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 42 'AdminUpdateContentS3' test.out

#- 43 AdminUpdateContentDirect
eval_tap 0 43 'AdminUpdateContentDirect # SKIP deprecated' test.out

#- 44 AdminDeleteContent
$CLI_EXE \
    --sn ugc \
    --op AdminDeleteContent \
    --channelId 'kCJtuMSx' \
    --contentId 'gvOg443B' \
    --namespace $AB_NAMESPACE \
    --userId 'YhBZQdIW' \
    > test.out 2>&1
eval_tap $? 44 'AdminDeleteContent' test.out

#- 45 AdminGetContent
$CLI_EXE \
    --sn ugc \
    --op AdminGetContent \
    --namespace $AB_NAMESPACE \
    --userId '0WYmsZLL' \
    --limit '11' \
    --offset '56' \
    > test.out 2>&1
eval_tap $? 45 'AdminGetContent' test.out

#- 46 AdminDeleteAllUserContents
$CLI_EXE \
    --sn ugc \
    --op AdminDeleteAllUserContents \
    --namespace $AB_NAMESPACE \
    --userId 'YFYahHvY' \
    > test.out 2>&1
eval_tap $? 46 'AdminDeleteAllUserContents' test.out

#- 47 AdminHideUserContent
# body param: body
echo '{"isHidden": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminHideUserContent \
    --contentId 'mj25Ho95' \
    --namespace $AB_NAMESPACE \
    --userId 'RiEt7950' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 47 'AdminHideUserContent' test.out

#- 48 AdminGetAllGroups
$CLI_EXE \
    --sn ugc \
    --op AdminGetAllGroups \
    --namespace $AB_NAMESPACE \
    --userId 'g7A2loa6' \
    --limit '57' \
    --offset '56' \
    > test.out 2>&1
eval_tap $? 48 'AdminGetAllGroups' test.out

#- 49 AdminDeleteAllUserGroup
$CLI_EXE \
    --sn ugc \
    --op AdminDeleteAllUserGroup \
    --namespace $AB_NAMESPACE \
    --userId 'xiIOUlUO' \
    > test.out 2>&1
eval_tap $? 49 'AdminDeleteAllUserGroup' test.out

#- 50 AdminGetGroup
$CLI_EXE \
    --sn ugc \
    --op AdminGetGroup \
    --groupId 'xdRcIf4Y' \
    --namespace $AB_NAMESPACE \
    --userId 'T8V0pV9A' \
    > test.out 2>&1
eval_tap $? 50 'AdminGetGroup' test.out

#- 51 AdminUpdateGroup
# body param: body
echo '{"contents": ["dbFviEI1", "RWMJ9tLb", "DxNtZoyr"], "name": "LWejMnLh"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op AdminUpdateGroup \
    --groupId '17fhFho3' \
    --namespace $AB_NAMESPACE \
    --userId 'cWv7Hafn' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 51 'AdminUpdateGroup' test.out

#- 52 AdminDeleteGroup
$CLI_EXE \
    --sn ugc \
    --op AdminDeleteGroup \
    --groupId 'H3ou5usm' \
    --namespace $AB_NAMESPACE \
    --userId '7Nf8TSYM' \
    > test.out 2>&1
eval_tap $? 52 'AdminDeleteGroup' test.out

#- 53 AdminGetGroupContents
$CLI_EXE \
    --sn ugc \
    --op AdminGetGroupContents \
    --groupId 'CMNL3Ibn' \
    --namespace $AB_NAMESPACE \
    --userId 'J9Q1uck5' \
    --limit '67' \
    --offset '99' \
    > test.out 2>&1
eval_tap $? 53 'AdminGetGroupContents' test.out

#- 54 AdminDeleteAllUserStates
$CLI_EXE \
    --sn ugc \
    --op AdminDeleteAllUserStates \
    --namespace $AB_NAMESPACE \
    --userId 'x3VtDRDN' \
    > test.out 2>&1
eval_tap $? 54 'AdminDeleteAllUserStates' test.out

#- 55 SearchChannelSpecificContent
$CLI_EXE \
    --sn ugc \
    --op SearchChannelSpecificContent \
    --channelId 'faW4Foz0' \
    --namespace $AB_NAMESPACE \
    --creator 'NpJ2t7Jp' \
    --isofficial 'tAOc7Jkq' \
    --limit '96' \
    --name 'fyAI6sdP' \
    --offset '87' \
    --orderby 'yVtGSZOV' \
    --sortby 'LMGdBSRE' \
    --subtype 'QtkESYXn' \
    --tags '["K5Ny83wQ", "JSjyBVWC", "jPHI5XnO"]' \
    --type 'qWR7UyMQ' \
    --userId 'ynvDJl6D' \
    > test.out 2>&1
eval_tap $? 55 'SearchChannelSpecificContent' test.out

#- 56 PublicSearchContent
$CLI_EXE \
    --sn ugc \
    --op PublicSearchContent \
    --namespace $AB_NAMESPACE \
    --creator 'B3t1PO9Q' \
    --isofficial 'dp8Ht1wt' \
    --limit '63' \
    --name 'mJzu1bxq' \
    --offset '56' \
    --orderby 'asvOAmLl' \
    --sortby 'sQ5ubOSQ' \
    --subtype 'ljW7c64Z' \
    --tags '["tqsK8exM", "2ddvFaXf", "ltOkvbdZ"]' \
    --type '6B4U68nl' \
    --userId '6nriRD65' \
    > test.out 2>&1
eval_tap $? 56 'PublicSearchContent' test.out

#- 57 PublicGetContentBulk
# body param: body
echo '{"contentIds": ["wFoFVGws", "8nutNJMC", "Sgd0HTAp"]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op PublicGetContentBulk \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 57 'PublicGetContentBulk' test.out

#- 58 GetFollowedContent
$CLI_EXE \
    --sn ugc \
    --op GetFollowedContent \
    --namespace $AB_NAMESPACE \
    --limit '40' \
    --offset '76' \
    > test.out 2>&1
eval_tap $? 58 'GetFollowedContent' test.out

#- 59 GetLikedContent
$CLI_EXE \
    --sn ugc \
    --op GetLikedContent \
    --namespace $AB_NAMESPACE \
    --isofficial 'true' \
    --limit '4' \
    --name '7ZnjZOZu' \
    --offset '25' \
    --orderby 'LsMdD1ZO' \
    --sortby 'Rytl3tlY' \
    --subtype '936hz4jH' \
    --tags '["kFGtUvi2", "kj75CBPt", "IhcAXQG2"]' \
    --type 'XrqJUqoH' \
    > test.out 2>&1
eval_tap $? 59 'GetLikedContent' test.out

#- 60 PublicDownloadContentByShareCode
$CLI_EXE \
    --sn ugc \
    --op PublicDownloadContentByShareCode \
    --namespace $AB_NAMESPACE \
    --shareCode 'FQ3vXE5D' \
    > test.out 2>&1
eval_tap $? 60 'PublicDownloadContentByShareCode' test.out

#- 61 PublicDownloadContentByContentID
$CLI_EXE \
    --sn ugc \
    --op PublicDownloadContentByContentID \
    --contentId 'v26udUZL' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 61 'PublicDownloadContentByContentID' test.out

#- 62 AddDownloadCount
$CLI_EXE \
    --sn ugc \
    --op AddDownloadCount \
    --contentId 'LGx2RAFZ' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 62 'AddDownloadCount' test.out

#- 63 UpdateContentLikeStatus
# body param: body
echo '{"likeStatus": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op UpdateContentLikeStatus \
    --contentId '96hXKzVt' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 63 'UpdateContentLikeStatus' test.out

#- 64 PublicDownloadContentPreview
$CLI_EXE \
    --sn ugc \
    --op PublicDownloadContentPreview \
    --contentId 'GyPlNMeA' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 64 'PublicDownloadContentPreview' test.out

#- 65 GetTag
$CLI_EXE \
    --sn ugc \
    --op GetTag \
    --namespace $AB_NAMESPACE \
    --limit '14' \
    --offset '74' \
    > test.out 2>&1
eval_tap $? 65 'GetTag' test.out

#- 66 GetType
$CLI_EXE \
    --sn ugc \
    --op GetType \
    --namespace $AB_NAMESPACE \
    --limit '7' \
    --offset '41' \
    > test.out 2>&1
eval_tap $? 66 'GetType' test.out

#- 67 PublicSearchCreator
$CLI_EXE \
    --sn ugc \
    --op PublicSearchCreator \
    --namespace $AB_NAMESPACE \
    --limit '63' \
    --offset '13' \
    --orderby 'crZReZ0r' \
    --sortby 'm5XANLon' \
    > test.out 2>&1
eval_tap $? 67 'PublicSearchCreator' test.out

#- 68 GetFollowedUsers
$CLI_EXE \
    --sn ugc \
    --op GetFollowedUsers \
    --namespace $AB_NAMESPACE \
    --limit '68' \
    --offset '95' \
    > test.out 2>&1
eval_tap $? 68 'GetFollowedUsers' test.out

#- 69 PublicGetCreator
$CLI_EXE \
    --sn ugc \
    --op PublicGetCreator \
    --namespace $AB_NAMESPACE \
    --userId 'hZhqJIu4' \
    > test.out 2>&1
eval_tap $? 69 'PublicGetCreator' test.out

#- 70 GetChannels
$CLI_EXE \
    --sn ugc \
    --op GetChannels \
    --namespace $AB_NAMESPACE \
    --userId 'xzh57vtm' \
    --limit '84' \
    --name '8iNuKt4I' \
    --offset '96' \
    > test.out 2>&1
eval_tap $? 70 'GetChannels' test.out

#- 71 PublicCreateChannel
# body param: body
echo '{"name": "8GUgF3JP"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op PublicCreateChannel \
    --namespace $AB_NAMESPACE \
    --userId 'gRXRtela' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 71 'PublicCreateChannel' test.out

#- 72 DeleteAllUserChannel
$CLI_EXE \
    --sn ugc \
    --op DeleteAllUserChannel \
    --namespace $AB_NAMESPACE \
    --userId 'sKcazKp7' \
    > test.out 2>&1
eval_tap $? 72 'DeleteAllUserChannel' test.out

#- 73 UpdateChannel
# body param: body
echo '{"name": "jRoiethZ"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op UpdateChannel \
    --channelId 'nBCHDjoh' \
    --namespace $AB_NAMESPACE \
    --userId 'BWNLxMoq' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 73 'UpdateChannel' test.out

#- 74 DeleteChannel
$CLI_EXE \
    --sn ugc \
    --op DeleteChannel \
    --channelId 'A3cnN54z' \
    --namespace $AB_NAMESPACE \
    --userId 'PRzENGiS' \
    > test.out 2>&1
eval_tap $? 74 'DeleteChannel' test.out

#- 75 CreateContentDirect
eval_tap 0 75 'CreateContentDirect # SKIP deprecated' test.out

#- 76 CreateContentS3
# body param: body
echo '{"contentType": "B7bwYyii", "customAttributes": {"2BmK0nh1": {}, "op9ZXbOW": {}, "oLcwXSkr": {}}, "fileExtension": "AjIoAR0r", "name": "tpCf00yM", "preview": "nBKgxS4h", "previewMetadata": {"previewContentType": "IHEawLlb", "previewFileExtension": "NdKfdtTg"}, "subType": "p62102nl", "tags": ["rjW7tRvc", "uJv1ndsl", "5BuLEOUm"], "type": "aTR6HnLJ"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op CreateContentS3 \
    --channelId 'jQhSNDXM' \
    --namespace $AB_NAMESPACE \
    --userId 'dfPIX28m' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 76 'CreateContentS3' test.out

#- 77 UpdateContentS3
# body param: body
echo '{"contentType": "va7GWz3p", "customAttributes": {"sCrWGob1": {}, "kDuULsOe": {}, "pxbsC3Uh": {}}, "fileExtension": "rOzsE75i", "name": "lQrbnJm4", "payload": "neeNtAnQ", "preview": "ty3ure91", "previewMetadata": {"previewContentType": "lDveQiX9", "previewFileExtension": "4LDi44QD"}, "subType": "Q1uK4DcW", "tags": ["8I0kjWJQ", "nhd3wL5m", "lIoArRmB"], "type": "kMfilf1E", "updateContentFile": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op UpdateContentS3 \
    --channelId 'MEnqcEWK' \
    --contentId '5tWrR2D7' \
    --namespace $AB_NAMESPACE \
    --userId 'KzS8vJIs' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 77 'UpdateContentS3' test.out

#- 78 UpdateContentDirect
eval_tap 0 78 'UpdateContentDirect # SKIP deprecated' test.out

#- 79 DeleteContent
$CLI_EXE \
    --sn ugc \
    --op DeleteContent \
    --channelId 'aY67RP2b' \
    --contentId '0cslhj3k' \
    --namespace $AB_NAMESPACE \
    --userId 'hThOGOKr' \
    > test.out 2>&1
eval_tap $? 79 'DeleteContent' test.out

#- 80 PublicGetUserContent
$CLI_EXE \
    --sn ugc \
    --op PublicGetUserContent \
    --namespace $AB_NAMESPACE \
    --userId '6OX2m1ug' \
    --limit '22' \
    --offset '16' \
    > test.out 2>&1
eval_tap $? 80 'PublicGetUserContent' test.out

#- 81 DeleteAllUserContents
$CLI_EXE \
    --sn ugc \
    --op DeleteAllUserContents \
    --namespace $AB_NAMESPACE \
    --userId '9Tqx9BTI' \
    > test.out 2>&1
eval_tap $? 81 'DeleteAllUserContents' test.out

#- 82 UpdateScreenshots
# body param: body
echo '{"screenshots": [{"description": "xdBb8BMC", "screenshotId": "olfrzeLS"}, {"description": "6gSrBeKv", "screenshotId": "TUcOVpNq"}, {"description": "pKjnVjyb", "screenshotId": "7Vwy4YJQ"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op UpdateScreenshots \
    --contentId 'pVVfP0Ai' \
    --namespace $AB_NAMESPACE \
    --userId '9qcYJJn5' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 82 'UpdateScreenshots' test.out

#- 83 UploadContentScreenshot
# body param: body
echo '{"screenshots": [{"contentType": "LFYnzi6D", "description": "4iDHbAaL", "fileExtension": "png"}, {"contentType": "cwZfY7rF", "description": "LTYY9nFS", "fileExtension": "pjp"}, {"contentType": "HElbSyPr", "description": "ppi67hgc", "fileExtension": "pjp"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op UploadContentScreenshot \
    --contentId 'JFhZAjAe' \
    --namespace $AB_NAMESPACE \
    --userId 'h6Fd99A1' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 83 'UploadContentScreenshot' test.out

#- 84 DeleteContentScreenshot
$CLI_EXE \
    --sn ugc \
    --op DeleteContentScreenshot \
    --contentId '5dosyrJM' \
    --namespace $AB_NAMESPACE \
    --screenshotId 'rTxHmSVs' \
    --userId 'VdIW4krZ' \
    > test.out 2>&1
eval_tap $? 84 'DeleteContentScreenshot' test.out

#- 85 UpdateUserFollowStatus
# body param: body
echo '{"followStatus": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op UpdateUserFollowStatus \
    --namespace $AB_NAMESPACE \
    --userId 'gejoC0eg' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 85 'UpdateUserFollowStatus' test.out

#- 86 GetPublicFollowers
$CLI_EXE \
    --sn ugc \
    --op GetPublicFollowers \
    --namespace $AB_NAMESPACE \
    --userId 'iK4jy7SV' \
    --limit '100' \
    --offset '54' \
    > test.out 2>&1
eval_tap $? 86 'GetPublicFollowers' test.out

#- 87 GetPublicFollowing
$CLI_EXE \
    --sn ugc \
    --op GetPublicFollowing \
    --namespace $AB_NAMESPACE \
    --userId 'L7ZNGY1e' \
    --limit '53' \
    --offset '10' \
    > test.out 2>&1
eval_tap $? 87 'GetPublicFollowing' test.out

#- 88 GetGroups
$CLI_EXE \
    --sn ugc \
    --op GetGroups \
    --namespace $AB_NAMESPACE \
    --userId '3hBobgrd' \
    --limit '27' \
    --offset '12' \
    > test.out 2>&1
eval_tap $? 88 'GetGroups' test.out

#- 89 CreateGroup
# body param: body
echo '{"contents": ["7STgHRCz", "hVU0daz0", "3Xd6aghb"], "name": "SvdeObkf"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op CreateGroup \
    --namespace $AB_NAMESPACE \
    --userId 'PqtL7P67' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 89 'CreateGroup' test.out

#- 90 DeleteAllUserGroup
$CLI_EXE \
    --sn ugc \
    --op DeleteAllUserGroup \
    --namespace $AB_NAMESPACE \
    --userId 'gq4h4ebf' \
    > test.out 2>&1
eval_tap $? 90 'DeleteAllUserGroup' test.out

#- 91 GetGroup
$CLI_EXE \
    --sn ugc \
    --op GetGroup \
    --groupId 'HpFkMviq' \
    --namespace $AB_NAMESPACE \
    --userId '6xoWqHpQ' \
    > test.out 2>&1
eval_tap $? 91 'GetGroup' test.out

#- 92 UpdateGroup
# body param: body
echo '{"contents": ["jJstu7Tc", "LWe6EMSj", "nbKTxuGA"], "name": "L4AA6wJr"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn ugc \
    --op UpdateGroup \
    --groupId '7TdYdB0L' \
    --namespace $AB_NAMESPACE \
    --userId 'pkqnphCA' \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 92 'UpdateGroup' test.out

#- 93 DeleteGroup
$CLI_EXE \
    --sn ugc \
    --op DeleteGroup \
    --groupId 'STiSoCrW' \
    --namespace $AB_NAMESPACE \
    --userId 'HV3jYntT' \
    > test.out 2>&1
eval_tap $? 93 'DeleteGroup' test.out

#- 94 GetGroupContent
$CLI_EXE \
    --sn ugc \
    --op GetGroupContent \
    --groupId 'V0BIhKkH' \
    --namespace $AB_NAMESPACE \
    --userId 'PsWp8PaX' \
    --limit '10' \
    --offset '64' \
    > test.out 2>&1
eval_tap $? 94 'GetGroupContent' test.out

#- 95 DeleteAllUserStates
$CLI_EXE \
    --sn ugc \
    --op DeleteAllUserStates \
    --namespace $AB_NAMESPACE \
    --userId 'ezjpXfRx' \
    > test.out 2>&1
eval_tap $? 95 'DeleteAllUserStates' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE