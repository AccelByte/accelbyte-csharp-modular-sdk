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
CLI_TOKEN_FILE="$(dirname "$(which $CLI_EXE)")/token.txt"
TEMP_JSON_INPUT="input_json.json"
TEMP_FILE_UPLOAD="file_upload.bin"
SERVICE_NAME="lobby"

echo "TAP version 13"
echo "1..105"

#- 1 Login
$CLI_EXE --op login --lt user --user user --pass user > test.out 2>&1
eval_tap $? 1 'Login' test.out

if [ $EXIT_CODE -ne 0 ]; then
  echo "Bail out! Login failed."
  exit $EXIT_CODE
fi

echo "foo" > "$CLI_TOKEN_FILE"

#- 2 AcceptFriendsNotif
# echo "Testing 'AcceptFriendsNotif'"
printf 'type: acceptFriendsNotif\nfriendId: aeKsx3Y1' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 2 'AcceptFriendsNotif' test.out

#- 3 AcceptFriendsRequest
# echo "Testing 'AcceptFriendsRequest'"
printf 'type: acceptFriendsRequest\nid: 3RNgWyvU\nfriendId: 00OysbI3' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 3 'AcceptFriendsRequest' test.out

#- 4 AcceptFriendsResponse
# echo "Testing 'AcceptFriendsResponse'"
printf 'type: acceptFriendsResponse\nid: oeriCRkv\ncode: 84' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 4 'AcceptFriendsResponse' test.out

#- 5 BlockPlayerNotif
# echo "Testing 'BlockPlayerNotif'"
printf 'type: blockPlayerNotif\nblockedUserId: 3KbNW3FI\nuserId: vomhIxtu' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 5 'BlockPlayerNotif' test.out

#- 6 BlockPlayerRequest
# echo "Testing 'BlockPlayerRequest'"
printf 'type: blockPlayerRequest\nid: v7c7FaEt\nblockUserId: W73i2QDl\nnamespace: FqtNshRB' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 6 'BlockPlayerRequest' test.out

#- 7 BlockPlayerResponse
# echo "Testing 'BlockPlayerResponse'"
printf 'type: blockPlayerResponse\nid: 0smnkOpe\nblockUserId: ccURjbXW\ncode: 54\nnamespace: X3mf91A5' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 7 'BlockPlayerResponse' test.out

#- 8 CancelFriendsNotif
# echo "Testing 'CancelFriendsNotif'"
printf 'type: cancelFriendsNotif\nuserId: yyJDdbbE' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 8 'CancelFriendsNotif' test.out

#- 9 CancelFriendsRequest
# echo "Testing 'CancelFriendsRequest'"
printf 'type: cancelFriendsRequest\nid: OMiBAd05\nfriendId: ZstnSWqG' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 9 'CancelFriendsRequest' test.out

#- 10 CancelFriendsResponse
# echo "Testing 'CancelFriendsResponse'"
printf 'type: cancelFriendsResponse\nid: wrpr2tgl\ncode: 4' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 10 'CancelFriendsResponse' test.out

#- 11 CancelMatchmakingRequest
# echo "Testing 'CancelMatchmakingRequest'"
printf 'type: cancelMatchmakingRequest\nid: x1n6b3dg\ngameMode: 0jvI8Ygs\nisTempParty: True' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 11 'CancelMatchmakingRequest' test.out

#- 12 CancelMatchmakingResponse
# echo "Testing 'CancelMatchmakingResponse'"
printf 'type: cancelMatchmakingResponse\nid: kff9CJaT\ncode: 52' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 12 'CancelMatchmakingResponse' test.out

#- 13 ChannelChatNotif
# echo "Testing 'ChannelChatNotif'"
printf 'type: channelChatNotif\nchannelSlug: tLIa3AFe\nfrom: BPbcNpBf\npayload: KuhXLK6k\nsentAt: XZoc8p0z' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 13 'ChannelChatNotif' test.out

#- 14 ClientResetRequest
# echo "Testing 'ClientResetRequest'"
printf 'type: clientResetRequest\nnamespace: LqqujJad\nuserId: 9sS7n5Ku' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 14 'ClientResetRequest' test.out

#- 15 ConnectNotif
# echo "Testing 'ConnectNotif'"
printf 'type: connectNotif\nlobbySessionId: zRftqXZo' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 15 'ConnectNotif' test.out

#- 16 DisconnectNotif
# echo "Testing 'DisconnectNotif'"
printf 'type: disconnectNotif\nconnectionId: CxNWjFZS\nnamespace: 879wQF6W' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 16 'DisconnectNotif' test.out

#- 17 DsNotif
# echo "Testing 'DsNotif'"
printf 'type: dsNotif\nalternateIps: [bBthXJ1z,W8fTgVou,GEWHhBUy]\ncustomAttribute: 2fvqBjeW\ndeployment: 0taDiVGn\ngameVersion: GB0sE69g\nimageVersion: B6tvSqXY\nip: m6DHdNLO\nisOK: True\nisOverrideGameVersion: False\nlastUpdate: EznvwuT0\nmatchId: cmw4wUUm\nmessage: FWH2kNCP\nnamespace: srJyPWDX\npodName: IImjYv3X\nport: 39\nports: {"RBGoO9HD":38,"QjIBwnAX":94,"kKx0hroD":6}\nprotocol: 1z6nhAUW\nprovider: tfaBNeSq\nregion: S6be8tUk\nsessionId: dyvXD6v2\nstatus: lYIEEXGU' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 17 'DsNotif' test.out

#- 18 ErrorNotif
# echo "Testing 'ErrorNotif'"
printf 'type: errorNotif\nmessage: N7xIDo4D' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 18 'ErrorNotif' test.out

#- 19 ExitAllChannel
# echo "Testing 'ExitAllChannel'"
printf 'type: exitAllChannel\nnamespace: dyu9fZCx\nuserId: JMlrN8MY' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 19 'ExitAllChannel' test.out

#- 20 FriendsStatusRequest
# echo "Testing 'FriendsStatusRequest'"
printf 'type: friendsStatusRequest\nid: ArMmAFyf' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 20 'FriendsStatusRequest' test.out

#- 21 FriendsStatusResponse
# echo "Testing 'FriendsStatusResponse'"
printf 'type: friendsStatusResponse\nid: LpY0Kh07\nactivity: [t8Anm2aB,1d6Na6we,XY61TPCb]\navailability: [21,16,51]\ncode: 80\nfriendIds: [sZfKDERU,Bb7ZzRWt,XWws1fUE]\nlastSeenAt: [Mu7HV300,3FKZipTh,B12fAf8W]' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 21 'FriendsStatusResponse' test.out

#- 22 GetAllSessionAttributeRequest
# echo "Testing 'GetAllSessionAttributeRequest'"
printf 'type: getAllSessionAttributeRequest\nid: 3rXG6njE' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 22 'GetAllSessionAttributeRequest' test.out

#- 23 GetAllSessionAttributeResponse
# echo "Testing 'GetAllSessionAttributeResponse'"
printf 'type: getAllSessionAttributeResponse\nid: qQoCw0TH\nattributes: {"h0TxH7e4":"GljmFg2B","OjGv24iE":"Qo9xiNxR","sLIyV592":"LiSSa4BL"}\ncode: 60' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 23 'GetAllSessionAttributeResponse' test.out

#- 24 GetFriendshipStatusRequest
# echo "Testing 'GetFriendshipStatusRequest'"
printf 'type: getFriendshipStatusRequest\nid: xNyLUR9o\nfriendId: EqPSNYuy' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 24 'GetFriendshipStatusRequest' test.out

#- 25 GetFriendshipStatusResponse
# echo "Testing 'GetFriendshipStatusResponse'"
printf 'type: getFriendshipStatusResponse\nid: lomV7ajr\ncode: 30\nfriendshipStatus: fZnVeuX2' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 25 'GetFriendshipStatusResponse' test.out

#- 26 GetSessionAttributeRequest
# echo "Testing 'GetSessionAttributeRequest'"
printf 'type: getSessionAttributeRequest\nid: QGpi9uwO\nkey: BcdNAShc' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 26 'GetSessionAttributeRequest' test.out

#- 27 GetSessionAttributeResponse
# echo "Testing 'GetSessionAttributeResponse'"
printf 'type: getSessionAttributeResponse\nid: ENU88kkp\ncode: 7\nvalue: 8daiPcPz' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 27 'GetSessionAttributeResponse' test.out

#- 28 Heartbeat
# echo "Testing 'Heartbeat'"
printf 'type: heartbeat' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 28 'Heartbeat' test.out

#- 29 JoinDefaultChannelRequest
# echo "Testing 'JoinDefaultChannelRequest'"
printf 'type: joinDefaultChannelRequest\nid: B6eK9B1D' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 29 'JoinDefaultChannelRequest' test.out

#- 30 JoinDefaultChannelResponse
# echo "Testing 'JoinDefaultChannelResponse'"
printf 'type: joinDefaultChannelResponse\nid: oD1ypCQA\nchannelSlug: h7pvRfyp\ncode: 57' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 30 'JoinDefaultChannelResponse' test.out

#- 31 ListIncomingFriendsRequest
# echo "Testing 'ListIncomingFriendsRequest'"
printf 'type: listIncomingFriendsRequest\nid: sY44vYSs' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 31 'ListIncomingFriendsRequest' test.out

#- 32 ListIncomingFriendsResponse
# echo "Testing 'ListIncomingFriendsResponse'"
printf 'type: listIncomingFriendsResponse\nid: 5OaqLtGo\ncode: 37\nuserIds: [KRKND6ds,B8RtAYKD,Vm9lgKLW]' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 32 'ListIncomingFriendsResponse' test.out

#- 33 ListOfFriendsRequest
# echo "Testing 'ListOfFriendsRequest'"
printf 'type: listOfFriendsRequest\nid: P58IrkDC\nfriendId: PhRuhZW3' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 33 'ListOfFriendsRequest' test.out

#- 34 ListOfFriendsResponse
# echo "Testing 'ListOfFriendsResponse'"
printf 'type: listOfFriendsResponse\nid: 5qyN4iNB\ncode: 70\nfriendIds: [W0zYtGxh,Ldd7XC71,4Cjptr32]' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 34 'ListOfFriendsResponse' test.out

#- 35 ListOnlineFriendsRequest
# echo "Testing 'ListOnlineFriendsRequest'"
printf 'type: listOnlineFriendsRequest\nid: yJICLkZy' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 35 'ListOnlineFriendsRequest' test.out

#- 36 ListOutgoingFriendsRequest
# echo "Testing 'ListOutgoingFriendsRequest'"
printf 'type: listOutgoingFriendsRequest\nid: 0iPJ51ev' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 36 'ListOutgoingFriendsRequest' test.out

#- 37 ListOutgoingFriendsResponse
# echo "Testing 'ListOutgoingFriendsResponse'"
printf 'type: listOutgoingFriendsResponse\nid: POhOtE2W\ncode: 71\nfriendIds: [AVUzVKj8,7sjuHQVX,nfrThqS3]' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 37 'ListOutgoingFriendsResponse' test.out

#- 38 MatchmakingNotif
# echo "Testing 'MatchmakingNotif'"
printf 'type: matchmakingNotif\ncounterPartyMember: [STO7uetx,kzdTXYjx,VVl4iFsr]\nmatchId: 8ZYL7uhC\nmessage: CXVfkCEM\npartyMember: [ABt6SKor,sJ4V6aFm,7P2HVdmE]\nreadyDuration: 67\nstatus: NvGtoKYc' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 38 'MatchmakingNotif' test.out

#- 39 MessageNotif
# echo "Testing 'MessageNotif'"
printf 'type: messageNotif\nid: DTXEQ9EZ\nfrom: e2JUUKua\npayload: eNuIoI8r\nsentAt: 52\nto: Hrjw3xwv\ntopic: mtQyoAda' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 39 'MessageNotif' test.out

#- 40 OfflineNotificationRequest
# echo "Testing 'OfflineNotificationRequest'"
printf 'type: offlineNotificationRequest\nid: t26oRjGd' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 40 'OfflineNotificationRequest' test.out

#- 41 OfflineNotificationResponse
# echo "Testing 'OfflineNotificationResponse'"
printf 'type: offlineNotificationResponse\nid: RaBgiMHf\ncode: 49' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 41 'OfflineNotificationResponse' test.out

#- 42 OnlineFriends
# echo "Testing 'OnlineFriends'"
printf 'type: onlineFriends\nid: cqpOeXL9\ncode: 90\nonlineFriendIds: [WDwNkOCk,z6UwZvvP,Ef0XKID0]' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 42 'OnlineFriends' test.out

#- 43 PartyChatNotif
# echo "Testing 'PartyChatNotif'"
printf 'type: partyChatNotif\nid: sF5xjIg6\nfrom: NyIPxTOf\npayload: NQzX39u4\nreceivedAt: 3\nto: vOtdph0M' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 43 'PartyChatNotif' test.out

#- 44 PartyChatRequest
# echo "Testing 'PartyChatRequest'"
printf 'type: partyChatRequest\nid: gm6RU49z\nfrom: 8GbUeJ0f\npayload: ra4hYtv7\nreceivedAt: 46\nto: Si2Bmk8p' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 44 'PartyChatRequest' test.out

#- 45 PartyChatResponse
# echo "Testing 'PartyChatResponse'"
printf 'type: partyChatResponse\nid: 2YBGiWiO\ncode: 2' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 45 'PartyChatResponse' test.out

#- 46 PartyCreateRequest
# echo "Testing 'PartyCreateRequest'"
printf 'type: partyCreateRequest\nid: UoRdUOOg' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 46 'PartyCreateRequest' test.out

#- 47 PartyCreateResponse
# echo "Testing 'PartyCreateResponse'"
printf 'type: partyCreateResponse\nid: BcPne3ih\ncode: 68\ninvitationToken: 3f8fIIVe\ninvitees: P9lxTG9b\nleaderId: QtU38LrS\nmembers: m5H6O9h2\npartyId: 1eC6kGZw' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 47 'PartyCreateResponse' test.out

#- 48 PartyDataUpdateNotif
# echo "Testing 'PartyDataUpdateNotif'"
printf 'type: partyDataUpdateNotif\ncustomAttributes: {"yHzAaj8T":{},"lroyZNah":{},"dUCrZG1W":{}}\ninvitees: [3qyCytuJ,gW2uCogZ,tXGlApA1]\nleader: NNbEpoFt\nmembers: [4btpZB3Q,k5hO9WuI,1mGJMnHn]\nnamespace: nSVSB3Mm\npartyId: eUBWeKz7\nupdatedAt: 91' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 48 'PartyDataUpdateNotif' test.out

#- 49 PartyGetInvitedNotif
# echo "Testing 'PartyGetInvitedNotif'"
printf 'type: partyGetInvitedNotif\nfrom: jgfHmBEF\ninvitationToken: aogQMfc0\npartyId: SxIcZpt5' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 49 'PartyGetInvitedNotif' test.out

#- 50 PartyInfoRequest
# echo "Testing 'PartyInfoRequest'"
printf 'type: partyInfoRequest\nid: 1KGqxucK' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 50 'PartyInfoRequest' test.out

#- 51 PartyInfoResponse
# echo "Testing 'PartyInfoResponse'"
printf 'type: partyInfoResponse\nid: RPzUFpKr\ncode: 84\ncustomAttributes: {"trlAqyCV":{},"EbxBrof3":{},"uRomeIi2":{}}\ninvitationToken: gmnfy8iF\ninvitees: dmkByhgx\nleaderId: 6Q56EZmw\nmembers: zYNvXiaK\npartyId: pEYrKAez' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 51 'PartyInfoResponse' test.out

#- 52 PartyInviteNotif
# echo "Testing 'PartyInviteNotif'"
printf 'type: partyInviteNotif\ninviteeId: gAfwtYTA\ninviterId: Lv9D6dE9' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 52 'PartyInviteNotif' test.out

#- 53 PartyInviteRequest
# echo "Testing 'PartyInviteRequest'"
printf 'type: partyInviteRequest\nid: u3fmcRDq\nfriendId: yRLsr4T1' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 53 'PartyInviteRequest' test.out

#- 54 PartyInviteResponse
# echo "Testing 'PartyInviteResponse'"
printf 'type: partyInviteResponse\nid: V765iq78\ncode: 34' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 54 'PartyInviteResponse' test.out

#- 55 PartyJoinNotif
# echo "Testing 'PartyJoinNotif'"
printf 'type: partyJoinNotif\nuserId: 1ANSKBna' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 55 'PartyJoinNotif' test.out

#- 56 PartyJoinRequest
# echo "Testing 'PartyJoinRequest'"
printf 'type: partyJoinRequest\nid: KSqh8LvX\ninvitationToken: dn9AvJ2s\npartyId: s2NFRFhp' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 56 'PartyJoinRequest' test.out

#- 57 PartyJoinResponse
# echo "Testing 'PartyJoinResponse'"
printf 'type: partyJoinResponse\nid: N6PJawlF\ncode: 15\ninvitationToken: TtjcooCU\ninvitees: 8nrBBe2D\nleaderId: qZvCUdRF\nmembers: ftUhqSSI\npartyId: cC0Yulpl' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 57 'PartyJoinResponse' test.out

#- 58 PartyKickNotif
# echo "Testing 'PartyKickNotif'"
printf 'type: partyKickNotif\nleaderId: k0I6J9Xq\npartyId: wX8ChsUz\nuserId: pKXQJoQc' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 58 'PartyKickNotif' test.out

#- 59 PartyKickRequest
# echo "Testing 'PartyKickRequest'"
printf 'type: partyKickRequest\nid: 3raIaTHo\nmemberId: d8Q60xBq' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 59 'PartyKickRequest' test.out

#- 60 PartyKickResponse
# echo "Testing 'PartyKickResponse'"
printf 'type: partyKickResponse\nid: Ave57zk3\ncode: 91' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 60 'PartyKickResponse' test.out

#- 61 PartyLeaveNotif
# echo "Testing 'PartyLeaveNotif'"
printf 'type: partyLeaveNotif\nleaderId: cbOjOSeJ\nuserId: TlnwfMIt' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 61 'PartyLeaveNotif' test.out

#- 62 PartyLeaveRequest
# echo "Testing 'PartyLeaveRequest'"
printf 'type: partyLeaveRequest\nid: N0ILrvkB\nignoreUserRegistry: True' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 62 'PartyLeaveRequest' test.out

#- 63 PartyLeaveResponse
# echo "Testing 'PartyLeaveResponse'"
printf 'type: partyLeaveResponse\nid: FNWOKXIZ\ncode: 2' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 63 'PartyLeaveResponse' test.out

#- 64 PartyPromoteLeaderRequest
# echo "Testing 'PartyPromoteLeaderRequest'"
printf 'type: partyPromoteLeaderRequest\nid: gdflSEC2\nnewLeaderUserId: cJxEaORP' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 64 'PartyPromoteLeaderRequest' test.out

#- 65 PartyPromoteLeaderResponse
# echo "Testing 'PartyPromoteLeaderResponse'"
printf 'type: partyPromoteLeaderResponse\nid: qAD8kaPW\ncode: 59\ninvitationToken: oYmG8jUX\ninvitees: RC0Qf74i\nleaderId: 6FhgZ4dx\nmembers: rpvLYqlW\npartyId: juzFGcAd' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 65 'PartyPromoteLeaderResponse' test.out

#- 66 PartyRejectNotif
# echo "Testing 'PartyRejectNotif'"
printf 'type: partyRejectNotif\nleaderId: CSm6j7Qf\npartyId: aBbM6G3k\nuserId: eSRkRKMJ' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 66 'PartyRejectNotif' test.out

#- 67 PartyRejectRequest
# echo "Testing 'PartyRejectRequest'"
printf 'type: partyRejectRequest\nid: dqgYrGgE\ninvitationToken: 2cRcoWYj\npartyId: Ibgisz0v' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 67 'PartyRejectRequest' test.out

#- 68 PartyRejectResponse
# echo "Testing 'PartyRejectResponse'"
printf 'type: partyRejectResponse\nid: MlO1Y4Ng\ncode: 23\npartyId: 7o5iVypj' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 68 'PartyRejectResponse' test.out

#- 69 PersonalChatHistoryRequest
# echo "Testing 'PersonalChatHistoryRequest'"
printf 'type: personalChatHistoryRequest\nid: sll6WeUH\nfriendId: fO8glaZn' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 69 'PersonalChatHistoryRequest' test.out

#- 70 PersonalChatHistoryResponse
# echo "Testing 'PersonalChatHistoryResponse'"
printf 'type: personalChatHistoryResponse\nid: wEYL9Z0A\nchat: ZqxEm8SM\ncode: 34\nfriendId: g1jJOKZV' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 70 'PersonalChatHistoryResponse' test.out

#- 71 PersonalChatNotif
# echo "Testing 'PersonalChatNotif'"
printf 'type: personalChatNotif\nid: imhlpylA\nfrom: PQZFpE5S\npayload: 04eyjn6H\nreceivedAt: 14\nto: 6IW1F2ti' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 71 'PersonalChatNotif' test.out

#- 72 PersonalChatRequest
# echo "Testing 'PersonalChatRequest'"
printf 'type: personalChatRequest\nid: zsxBnsEk\nfrom: HUArPVV5\npayload: qdYcYlu1\nreceivedAt: 32\nto: GoOa10tX' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 72 'PersonalChatRequest' test.out

#- 73 PersonalChatResponse
# echo "Testing 'PersonalChatResponse'"
printf 'type: personalChatResponse\nid: zBmpV1Da\ncode: 68' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 73 'PersonalChatResponse' test.out

#- 74 RefreshTokenRequest
# echo "Testing 'RefreshTokenRequest'"
printf 'type: refreshTokenRequest\nid: CWBNiFYu\ntoken: 1iGqEPO5' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 74 'RefreshTokenRequest' test.out

#- 75 RefreshTokenResponse
# echo "Testing 'RefreshTokenResponse'"
printf 'type: refreshTokenResponse\nid: pVoQlk7J\ncode: 12' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 75 'RefreshTokenResponse' test.out

#- 76 RejectFriendsNotif
# echo "Testing 'RejectFriendsNotif'"
printf 'type: rejectFriendsNotif\nuserId: DJWKuv3J' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 76 'RejectFriendsNotif' test.out

#- 77 RejectFriendsRequest
# echo "Testing 'RejectFriendsRequest'"
printf 'type: rejectFriendsRequest\nid: ndF8WEgO\nfriendId: B3wjEe25' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 77 'RejectFriendsRequest' test.out

#- 78 RejectFriendsResponse
# echo "Testing 'RejectFriendsResponse'"
printf 'type: rejectFriendsResponse\nid: oesxm553\ncode: 7' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 78 'RejectFriendsResponse' test.out

#- 79 RematchmakingNotif
# echo "Testing 'RematchmakingNotif'"
printf 'type: rematchmakingNotif\nbanDuration: 94' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 79 'RematchmakingNotif' test.out

#- 80 RequestFriendsNotif
# echo "Testing 'RequestFriendsNotif'"
printf 'type: requestFriendsNotif\nfriendId: LHPu0Git' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 80 'RequestFriendsNotif' test.out

#- 81 RequestFriendsRequest
# echo "Testing 'RequestFriendsRequest'"
printf 'type: requestFriendsRequest\nid: 9nNaOfZx\nfriendId: XQOcczhK' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 81 'RequestFriendsRequest' test.out

#- 82 RequestFriendsResponse
# echo "Testing 'RequestFriendsResponse'"
printf 'type: requestFriendsResponse\nid: ck0q3PHn\ncode: 33' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 82 'RequestFriendsResponse' test.out

#- 83 SendChannelChatRequest
# echo "Testing 'SendChannelChatRequest'"
printf 'type: sendChannelChatRequest\nid: 5v5XmHNh\nchannelSlug: NdGr5tj3\npayload: Ozlu8d7j' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 83 'SendChannelChatRequest' test.out

#- 84 SendChannelChatResponse
# echo "Testing 'SendChannelChatResponse'"
printf 'type: sendChannelChatResponse\nid: KpBpePF7\ncode: 16' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 84 'SendChannelChatResponse' test.out

#- 85 SetReadyConsentNotif
# echo "Testing 'SetReadyConsentNotif'"
printf 'type: setReadyConsentNotif\nmatchId: AwzUdfTj\nuserId: isGF0nOl' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 85 'SetReadyConsentNotif' test.out

#- 86 SetReadyConsentRequest
# echo "Testing 'SetReadyConsentRequest'"
printf 'type: setReadyConsentRequest\nid: E5JsdJHp\nmatchId: PO15B7QV' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 86 'SetReadyConsentRequest' test.out

#- 87 SetReadyConsentResponse
# echo "Testing 'SetReadyConsentResponse'"
printf 'type: setReadyConsentResponse\nid: AefUKMt0\ncode: 86' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 87 'SetReadyConsentResponse' test.out

#- 88 SetSessionAttributeRequest
# echo "Testing 'SetSessionAttributeRequest'"
printf 'type: setSessionAttributeRequest\nid: bfqRBd0D\nkey: ckSlLgts\nnamespace: IyS656Zb\nvalue: vtK8nBeX' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 88 'SetSessionAttributeRequest' test.out

#- 89 SetSessionAttributeResponse
# echo "Testing 'SetSessionAttributeResponse'"
printf 'type: setSessionAttributeResponse\nid: 5svxPOiZ\ncode: 94' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 89 'SetSessionAttributeResponse' test.out

#- 90 SetUserStatusRequest
# echo "Testing 'SetUserStatusRequest'"
printf 'type: setUserStatusRequest\nid: 3pUaVGKV\nactivity: blPvQJp6\navailability: 48' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 90 'SetUserStatusRequest' test.out

#- 91 SetUserStatusResponse
# echo "Testing 'SetUserStatusResponse'"
printf 'type: setUserStatusResponse\nid: k4cqJr4b\ncode: 8' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 91 'SetUserStatusResponse' test.out

#- 92 ShutdownNotif
# echo "Testing 'ShutdownNotif'"
printf 'type: shutdownNotif\nmessage: l7FfUTTg' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 92 'ShutdownNotif' test.out

#- 93 SignalingP2PNotif
# echo "Testing 'SignalingP2PNotif'"
printf 'type: signalingP2PNotif\ndestinationId: 7AjLShv9\nmessage: FerGW4rF' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 93 'SignalingP2PNotif' test.out

#- 94 StartMatchmakingRequest
# echo "Testing 'StartMatchmakingRequest'"
printf 'type: startMatchmakingRequest\nid: wvjRiQ4F\nextraAttributes: wRIMqT5y\ngameMode: hnSp1SKd\npartyAttributes: {"2afFrKdf":{},"dK4JHT9L":{},"rAqk8Jji":{}}\npriority: 18\ntempParty: 6JxpTFyr' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 94 'StartMatchmakingRequest' test.out

#- 95 StartMatchmakingResponse
# echo "Testing 'StartMatchmakingResponse'"
printf 'type: startMatchmakingResponse\nid: Pe74SzHo\ncode: 13' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 95 'StartMatchmakingResponse' test.out

#- 96 UnblockPlayerNotif
# echo "Testing 'UnblockPlayerNotif'"
printf 'type: unblockPlayerNotif\nunblockedUserId: gqGzZUCl\nuserId: GJfX5sKZ' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 96 'UnblockPlayerNotif' test.out

#- 97 UnblockPlayerRequest
# echo "Testing 'UnblockPlayerRequest'"
printf 'type: unblockPlayerRequest\nid: J3QWp0Rk\nnamespace: TwqhKhq0\nunblockedUserId: AFJsTyHM' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 97 'UnblockPlayerRequest' test.out

#- 98 UnblockPlayerResponse
# echo "Testing 'UnblockPlayerResponse'"
printf 'type: unblockPlayerResponse\nid: HgHaevhr\ncode: 42\nnamespace: vFBZGVGz\nunblockedUserId: yht4gWsC' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 98 'UnblockPlayerResponse' test.out

#- 99 UnfriendNotif
# echo "Testing 'UnfriendNotif'"
printf 'type: unfriendNotif\nfriendId: aVjMVBrM' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 99 'UnfriendNotif' test.out

#- 100 UnfriendRequest
# echo "Testing 'UnfriendRequest'"
printf 'type: unfriendRequest\nid: qjlmkD9Q\nfriendId: vHov6EwI' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 100 'UnfriendRequest' test.out

#- 101 UnfriendResponse
# echo "Testing 'UnfriendResponse'"
printf 'type: unfriendResponse\nid: Iyk0eXyy\ncode: 69' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 101 'UnfriendResponse' test.out

#- 102 UserBannedNotification
# echo "Testing 'UserBannedNotification'"
printf 'type: userBannedNotification' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 102 'UserBannedNotification' test.out

#- 103 UserMetricRequest
# echo "Testing 'UserMetricRequest'"
printf 'type: userMetricRequest\nid: nihNZ0W5' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 103 'UserMetricRequest' test.out

#- 104 UserMetricResponse
# echo "Testing 'UserMetricResponse'"
printf 'type: userMetricResponse\nid: obtXfJRk\ncode: 54\nplayerCount: 9' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 104 'UserMetricResponse' test.out

#- 105 UserStatusNotif
# echo "Testing 'UserStatusNotif'"
printf 'type: userStatusNotif\nactivity: csVTyYFa\navailability: 69\nlastSeenAt: X1dNwTZC\nuserId: XOB0CEjO' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 105 'UserStatusNotif' test.out


exit $EXIT_CODE