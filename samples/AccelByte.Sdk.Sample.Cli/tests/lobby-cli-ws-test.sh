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
echo "1..106"

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
printf 'type: acceptFriendsNotif\nfriendId: n82U53kD' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 2 'AcceptFriendsNotif' test.out

#- 3 AcceptFriendsRequest
# echo "Testing 'AcceptFriendsRequest'"
printf 'type: acceptFriendsRequest\nid: vMtRupIN\nfriendId: rzZ9DRjd' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 3 'AcceptFriendsRequest' test.out

#- 4 AcceptFriendsResponse
# echo "Testing 'AcceptFriendsResponse'"
printf 'type: acceptFriendsResponse\nid: GJOA65mJ\ncode: 48' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 4 'AcceptFriendsResponse' test.out

#- 5 BlockPlayerNotif
# echo "Testing 'BlockPlayerNotif'"
printf 'type: blockPlayerNotif\nblockedUserId: kRcC0f7J\nuserId: YjSr23XD' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 5 'BlockPlayerNotif' test.out

#- 6 BlockPlayerRequest
# echo "Testing 'BlockPlayerRequest'"
printf 'type: blockPlayerRequest\nid: 7c4bz0Dj\nblockUserId: nwZrTGQu\nnamespace: n6qOyhPF' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 6 'BlockPlayerRequest' test.out

#- 7 BlockPlayerResponse
# echo "Testing 'BlockPlayerResponse'"
printf 'type: blockPlayerResponse\nid: e3mbK0dK\nblockUserId: BvNuMfbh\ncode: 26\nnamespace: sRFfZHQj' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 7 'BlockPlayerResponse' test.out

#- 8 CancelFriendsNotif
# echo "Testing 'CancelFriendsNotif'"
printf 'type: cancelFriendsNotif\nuserId: pcvXXX4l' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 8 'CancelFriendsNotif' test.out

#- 9 CancelFriendsRequest
# echo "Testing 'CancelFriendsRequest'"
printf 'type: cancelFriendsRequest\nid: QSisSk0N\nfriendId: bLhss8PM' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 9 'CancelFriendsRequest' test.out

#- 10 CancelFriendsResponse
# echo "Testing 'CancelFriendsResponse'"
printf 'type: cancelFriendsResponse\nid: pSh8CE6q\ncode: 87' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 10 'CancelFriendsResponse' test.out

#- 11 CancelMatchmakingRequest
# echo "Testing 'CancelMatchmakingRequest'"
printf 'type: cancelMatchmakingRequest\nid: 7uGVkNNd\ngameMode: 2rtk9QvA\nisTempParty: False' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 11 'CancelMatchmakingRequest' test.out

#- 12 CancelMatchmakingResponse
# echo "Testing 'CancelMatchmakingResponse'"
printf 'type: cancelMatchmakingResponse\nid: 6ntJytke\ncode: 47' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 12 'CancelMatchmakingResponse' test.out

#- 13 ChannelChatNotif
# echo "Testing 'ChannelChatNotif'"
printf 'type: channelChatNotif\nchannelSlug: 4e4tHsFP\nfrom: SkJ6cI4t\npayload: jS04iGYv\nsentAt: 1999-10-02T00:00:00Z' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 13 'ChannelChatNotif' test.out

#- 14 ClientResetRequest
# echo "Testing 'ClientResetRequest'"
printf 'type: clientResetRequest\nnamespace: JcZ8hFZu\nuserId: eAZdux2H' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 14 'ClientResetRequest' test.out

#- 15 ConnectNotif
# echo "Testing 'ConnectNotif'"
printf 'type: connectNotif\nlobbySessionId: yS5Igw0S' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 15 'ConnectNotif' test.out

#- 16 DisconnectNotif
# echo "Testing 'DisconnectNotif'"
printf 'type: disconnectNotif\nconnectionId: Qf7mbqV3\nnamespace: SxqXeXD2' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 16 'DisconnectNotif' test.out

#- 17 DsNotif
# echo "Testing 'DsNotif'"
printf 'type: dsNotif\nalternateIps: [7fbP7wdl,gQLogssk,WVF3Gv4p]\ncustomAttribute: GVoPcgr9\ndeployment: hI5nOSwF\ngameVersion: 7A6bDwhb\nimageVersion: cRNXJzTF\nip: wgIVwhIg\nisOK: False\nisOverrideGameVersion: True\nlastUpdate: cda82kQ8\nmatchId: jslMB75L\nmessage: wtUhOvlj\nnamespace: MQRhhl2h\npodName: EgujzfRP\nport: 89\nports: {"M88ibnnY":92,"54YlREuJ":54,"XsL5nemI":32}\nprotocol: ywrqWfE9\nprovider: 3EwOF3Il\nregion: oZZPV9FT\nsessionId: fkIfikUF\nstatus: Q2jp0oQA' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 17 'DsNotif' test.out

#- 18 ErrorNotif
# echo "Testing 'ErrorNotif'"
printf 'type: errorNotif\nmessage: sj3bgXmD' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 18 'ErrorNotif' test.out

#- 19 ExitAllChannel
# echo "Testing 'ExitAllChannel'"
printf 'type: exitAllChannel\nnamespace: NQDeq4FY\nuserId: rQ8pUUq9' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 19 'ExitAllChannel' test.out

#- 20 FriendsStatusRequest
# echo "Testing 'FriendsStatusRequest'"
printf 'type: friendsStatusRequest\nid: CA1UN42s' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 20 'FriendsStatusRequest' test.out

#- 21 FriendsStatusResponse
# echo "Testing 'FriendsStatusResponse'"
printf 'type: friendsStatusResponse\nid: vziYryj4\nactivity: [86qQxwml,XCXr86vS,ySPq68Lp]\navailability: [OX7POB4W,Xiy3USjk,VL8cxhdO]\ncode: 94\nfriendIds: [JtpRFiJT,WMIt5Vw1,WgHRioEb]\nlastSeenAt: [1972-05-18T00:00:00Z,1986-11-21T00:00:00Z,1988-01-05T00:00:00Z]' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 21 'FriendsStatusResponse' test.out

#- 22 GetAllSessionAttributeRequest
# echo "Testing 'GetAllSessionAttributeRequest'"
printf 'type: getAllSessionAttributeRequest\nid: iwHct2dY' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 22 'GetAllSessionAttributeRequest' test.out

#- 23 GetAllSessionAttributeResponse
# echo "Testing 'GetAllSessionAttributeResponse'"
printf 'type: getAllSessionAttributeResponse\nid: pU0pP4nj\nattributes: {"Df4c99Wt":"T5JtS36s","Tz6HRH5Q":"Cat0k5DW","zmBAdJq8":"dHHSvpoG"}\ncode: 7' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 23 'GetAllSessionAttributeResponse' test.out

#- 24 GetFriendshipStatusRequest
# echo "Testing 'GetFriendshipStatusRequest'"
printf 'type: getFriendshipStatusRequest\nid: KdTGFEHt\nfriendId: wfElrTRU' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 24 'GetFriendshipStatusRequest' test.out

#- 25 GetFriendshipStatusResponse
# echo "Testing 'GetFriendshipStatusResponse'"
printf 'type: getFriendshipStatusResponse\nid: simBAFUC\ncode: 31\nfriendshipStatus: F1sZMDx2' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 25 'GetFriendshipStatusResponse' test.out

#- 26 GetSessionAttributeRequest
# echo "Testing 'GetSessionAttributeRequest'"
printf 'type: getSessionAttributeRequest\nid: 8UMeo4GW\nkey: fluD02u6' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 26 'GetSessionAttributeRequest' test.out

#- 27 GetSessionAttributeResponse
# echo "Testing 'GetSessionAttributeResponse'"
printf 'type: getSessionAttributeResponse\nid: Ny1W6ovQ\ncode: 56\nvalue: kudbkqKt' > $TEMP_FILE_UPLOAD
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
printf 'type: joinDefaultChannelRequest\nid: NLYmUbz3' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 29 'JoinDefaultChannelRequest' test.out

#- 30 JoinDefaultChannelResponse
# echo "Testing 'JoinDefaultChannelResponse'"
printf 'type: joinDefaultChannelResponse\nid: Bd2kCUGB\nchannelSlug: j8Pp81ot\ncode: 77' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 30 'JoinDefaultChannelResponse' test.out

#- 31 ListIncomingFriendsRequest
# echo "Testing 'ListIncomingFriendsRequest'"
printf 'type: listIncomingFriendsRequest\nid: 5usm7Wt5' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 31 'ListIncomingFriendsRequest' test.out

#- 32 ListIncomingFriendsResponse
# echo "Testing 'ListIncomingFriendsResponse'"
printf 'type: listIncomingFriendsResponse\nid: x7X7DsNh\ncode: 28\nuserIds: [Rnxwh8VL,JfGKifuX,3VRcngtF]' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 32 'ListIncomingFriendsResponse' test.out

#- 33 ListOfFriendsRequest
# echo "Testing 'ListOfFriendsRequest'"
printf 'type: listOfFriendsRequest\nid: MfkBdD4G\nfriendId: S7bcq3u2' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 33 'ListOfFriendsRequest' test.out

#- 34 ListOfFriendsResponse
# echo "Testing 'ListOfFriendsResponse'"
printf 'type: listOfFriendsResponse\nid: 3l1Y0p21\ncode: 10\nfriendIds: [mKloEefP,VqEtLIIa,WUy6puqQ]' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 34 'ListOfFriendsResponse' test.out

#- 35 ListOnlineFriendsRequest
# echo "Testing 'ListOnlineFriendsRequest'"
printf 'type: listOnlineFriendsRequest\nid: VhFVpE9O' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 35 'ListOnlineFriendsRequest' test.out

#- 36 ListOutgoingFriendsRequest
# echo "Testing 'ListOutgoingFriendsRequest'"
printf 'type: listOutgoingFriendsRequest\nid: QHhsh1eG' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 36 'ListOutgoingFriendsRequest' test.out

#- 37 ListOutgoingFriendsResponse
# echo "Testing 'ListOutgoingFriendsResponse'"
printf 'type: listOutgoingFriendsResponse\nid: ZN9TiMv7\ncode: 95\nfriendIds: [j8MiVDOA,7WWLvLmo,U76bxdI6]' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 37 'ListOutgoingFriendsResponse' test.out

#- 38 MatchmakingNotif
# echo "Testing 'MatchmakingNotif'"
printf 'type: matchmakingNotif\ncounterPartyMember: [9gzyr7Yg,NQPahQ4s,6z458Ra9]\nmatchId: oBMTO6zM\nmessage: ILkAVxyY\npartyMember: [BsjFzGy3,yS5YSGXY,7f6eXLmF]\nreadyDuration: 95\nstatus: KTFZPFpo' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 38 'MatchmakingNotif' test.out

#- 39 MessageNotif
# echo "Testing 'MessageNotif'"
printf 'type: messageNotif\nid: TmFACfrp\nfrom: CGqQr2Jm\npayload: fzO3BOEb\nsentAt: 1988-12-20T00:00:00Z\nto: pUNginAx\ntopic: KrrgfK6b' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 39 'MessageNotif' test.out

#- 40 MessageSessionNotif
# echo "Testing 'MessageSessionNotif'"
printf 'type: messageSessionNotif\nid: ecKvDXRQ\nfrom: 6dy55HId\npayload: asCbwGhz\nsentAt: 1976-04-28T00:00:00Z\nto: 7iPKJX4v\ntopic: ZefxR91V' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 40 'MessageSessionNotif' test.out

#- 41 OfflineNotificationRequest
# echo "Testing 'OfflineNotificationRequest'"
printf 'type: offlineNotificationRequest\nid: 8rLlZNRS' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 41 'OfflineNotificationRequest' test.out

#- 42 OfflineNotificationResponse
# echo "Testing 'OfflineNotificationResponse'"
printf 'type: offlineNotificationResponse\nid: yMBUj2rf\ncode: 26' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 42 'OfflineNotificationResponse' test.out

#- 43 OnlineFriends
# echo "Testing 'OnlineFriends'"
printf 'type: onlineFriends\nid: W9JK0RzW\ncode: 56\nonlineFriendIds: [78pHNmc6,NmXTN2Th,453scdpa]' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 43 'OnlineFriends' test.out

#- 44 PartyChatNotif
# echo "Testing 'PartyChatNotif'"
printf 'type: partyChatNotif\nid: c8IU9Tll\nfrom: Pp1jsbfI\npayload: OCEfrY8K\nreceivedAt: 1971-01-10T00:00:00Z\nto: YbGO6Bte' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 44 'PartyChatNotif' test.out

#- 45 PartyChatRequest
# echo "Testing 'PartyChatRequest'"
printf 'type: partyChatRequest\nid: zAXvvfCz\nfrom: S51UHN3a\npayload: StuFYiy6\nreceivedAt: 1981-04-08T00:00:00Z\nto: s5LUPCX9' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 45 'PartyChatRequest' test.out

#- 46 PartyChatResponse
# echo "Testing 'PartyChatResponse'"
printf 'type: partyChatResponse\nid: D9bpzNph\ncode: 77' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 46 'PartyChatResponse' test.out

#- 47 PartyCreateRequest
# echo "Testing 'PartyCreateRequest'"
printf 'type: partyCreateRequest\nid: 3V1Y4eCE' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 47 'PartyCreateRequest' test.out

#- 48 PartyCreateResponse
# echo "Testing 'PartyCreateResponse'"
printf 'type: partyCreateResponse\nid: rX9Bw52V\ncode: 51\ninvitationToken: 4F66fV5z\ninvitees: v5diSrIH\nleaderId: bCCJAc3w\nmembers: QeZnRijh\npartyId: BxyIKslX' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 48 'PartyCreateResponse' test.out

#- 49 PartyDataUpdateNotif
# echo "Testing 'PartyDataUpdateNotif'"
printf 'type: partyDataUpdateNotif\ncustomAttributes: {"AJlkrN75":{},"SCO7KMVC":{},"IRstwLFX":{}}\ninvitees: [GHNMwVzu,XXfuPJBW,JAkRY2LI]\nleader: PALZgtoO\nmembers: [hDXHWiJX,sX9rg57t,2mvpBwkv]\nnamespace: IN2GK5rc\npartyId: o0Z9eFp8\nupdatedAt: 1992-10-02T00:00:00Z' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 49 'PartyDataUpdateNotif' test.out

#- 50 PartyGetInvitedNotif
# echo "Testing 'PartyGetInvitedNotif'"
printf 'type: partyGetInvitedNotif\nfrom: qV6iCYa8\ninvitationToken: fG4gf9LX\npartyId: crXhwAxA' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 50 'PartyGetInvitedNotif' test.out

#- 51 PartyInfoRequest
# echo "Testing 'PartyInfoRequest'"
printf 'type: partyInfoRequest\nid: crEDj42t' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 51 'PartyInfoRequest' test.out

#- 52 PartyInfoResponse
# echo "Testing 'PartyInfoResponse'"
printf 'type: partyInfoResponse\nid: Dq4LRctF\ncode: 15\ncustomAttributes: {"gytLNO46":{},"pUvUVMws":{},"W2iVfGvE":{}}\ninvitationToken: LY9luhjJ\ninvitees: El03Tq8S\nleaderId: 9CcTIl2D\nmembers: 2OV73STJ\npartyId: mMIoiGXU' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 52 'PartyInfoResponse' test.out

#- 53 PartyInviteNotif
# echo "Testing 'PartyInviteNotif'"
printf 'type: partyInviteNotif\ninviteeId: 0D2RKuLU\ninviterId: bRqta69G' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 53 'PartyInviteNotif' test.out

#- 54 PartyInviteRequest
# echo "Testing 'PartyInviteRequest'"
printf 'type: partyInviteRequest\nid: JHI29Ov2\nfriendId: MlIgu88E' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 54 'PartyInviteRequest' test.out

#- 55 PartyInviteResponse
# echo "Testing 'PartyInviteResponse'"
printf 'type: partyInviteResponse\nid: BjWuG2gf\ncode: 37' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 55 'PartyInviteResponse' test.out

#- 56 PartyJoinNotif
# echo "Testing 'PartyJoinNotif'"
printf 'type: partyJoinNotif\nuserId: 6MYj9oCt' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 56 'PartyJoinNotif' test.out

#- 57 PartyJoinRequest
# echo "Testing 'PartyJoinRequest'"
printf 'type: partyJoinRequest\nid: iBvzlguK\ninvitationToken: 9gIiosSI\npartyId: 8hD7YZwv' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 57 'PartyJoinRequest' test.out

#- 58 PartyJoinResponse
# echo "Testing 'PartyJoinResponse'"
printf 'type: partyJoinResponse\nid: BmmuuWT2\ncode: 56\ninvitationToken: ehSX7tEv\ninvitees: yhHIh4HN\nleaderId: z5MRe9uk\nmembers: ROxL3P8d\npartyId: DBZbq34Q' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 58 'PartyJoinResponse' test.out

#- 59 PartyKickNotif
# echo "Testing 'PartyKickNotif'"
printf 'type: partyKickNotif\nleaderId: 2bfV84f4\npartyId: 1lcXzjS7\nuserId: 5NNqsWXL' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 59 'PartyKickNotif' test.out

#- 60 PartyKickRequest
# echo "Testing 'PartyKickRequest'"
printf 'type: partyKickRequest\nid: Bjvl0AsM\nmemberId: FhmxAc8n' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 60 'PartyKickRequest' test.out

#- 61 PartyKickResponse
# echo "Testing 'PartyKickResponse'"
printf 'type: partyKickResponse\nid: Vbws50WJ\ncode: 46' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 61 'PartyKickResponse' test.out

#- 62 PartyLeaveNotif
# echo "Testing 'PartyLeaveNotif'"
printf 'type: partyLeaveNotif\nleaderId: Xd7xjg0J\nuserId: 6ybBwLj3' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 62 'PartyLeaveNotif' test.out

#- 63 PartyLeaveRequest
# echo "Testing 'PartyLeaveRequest'"
printf 'type: partyLeaveRequest\nid: kNDE1wSc\nignoreUserRegistry: False' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 63 'PartyLeaveRequest' test.out

#- 64 PartyLeaveResponse
# echo "Testing 'PartyLeaveResponse'"
printf 'type: partyLeaveResponse\nid: eHRsqZlZ\ncode: 30' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 64 'PartyLeaveResponse' test.out

#- 65 PartyPromoteLeaderRequest
# echo "Testing 'PartyPromoteLeaderRequest'"
printf 'type: partyPromoteLeaderRequest\nid: PIufqtAD\nnewLeaderUserId: eerANUMc' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 65 'PartyPromoteLeaderRequest' test.out

#- 66 PartyPromoteLeaderResponse
# echo "Testing 'PartyPromoteLeaderResponse'"
printf 'type: partyPromoteLeaderResponse\nid: wlNB1OcA\ncode: 4\ninvitationToken: 7Hm88EPg\ninvitees: jaYKW3gA\nleaderId: JOfZXnGB\nmembers: 2LQ5pTGc\npartyId: qH1odeaw' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 66 'PartyPromoteLeaderResponse' test.out

#- 67 PartyRejectNotif
# echo "Testing 'PartyRejectNotif'"
printf 'type: partyRejectNotif\nleaderId: GiC6vP7q\npartyId: hKIxwd3B\nuserId: EeXdOtAY' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 67 'PartyRejectNotif' test.out

#- 68 PartyRejectRequest
# echo "Testing 'PartyRejectRequest'"
printf 'type: partyRejectRequest\nid: ZopXRAGn\ninvitationToken: w0lofcPx\npartyId: hRmKwbRL' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 68 'PartyRejectRequest' test.out

#- 69 PartyRejectResponse
# echo "Testing 'PartyRejectResponse'"
printf 'type: partyRejectResponse\nid: MdCFx4ZU\ncode: 80\npartyId: shewUgvk' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 69 'PartyRejectResponse' test.out

#- 70 PersonalChatHistoryRequest
# echo "Testing 'PersonalChatHistoryRequest'"
printf 'type: personalChatHistoryRequest\nid: EKy7BWG2\nfriendId: rBHU9Q1f' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 70 'PersonalChatHistoryRequest' test.out

#- 71 PersonalChatHistoryResponse
# echo "Testing 'PersonalChatHistoryResponse'"
printf 'type: personalChatHistoryResponse\nid: DVMAQXkd\nchat: FwYMd7em\ncode: 9\nfriendId: KTlNO0YJ' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 71 'PersonalChatHistoryResponse' test.out

#- 72 PersonalChatNotif
# echo "Testing 'PersonalChatNotif'"
printf 'type: personalChatNotif\nid: 3njLJBzj\nfrom: WH7HgXFU\npayload: oAYAVGV5\nreceivedAt: 1993-10-25T00:00:00Z\nto: arBbVUqM' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 72 'PersonalChatNotif' test.out

#- 73 PersonalChatRequest
# echo "Testing 'PersonalChatRequest'"
printf 'type: personalChatRequest\nid: lUjtciZM\nfrom: FPp1ttuO\npayload: PbBGLJEE\nreceivedAt: 1999-06-18T00:00:00Z\nto: QrgxaXVe' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 73 'PersonalChatRequest' test.out

#- 74 PersonalChatResponse
# echo "Testing 'PersonalChatResponse'"
printf 'type: personalChatResponse\nid: BBIDYkUQ\ncode: 66' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 74 'PersonalChatResponse' test.out

#- 75 RefreshTokenRequest
# echo "Testing 'RefreshTokenRequest'"
printf 'type: refreshTokenRequest\nid: mT7D5Yp6\ntoken: qORyZB5X' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 75 'RefreshTokenRequest' test.out

#- 76 RefreshTokenResponse
# echo "Testing 'RefreshTokenResponse'"
printf 'type: refreshTokenResponse\nid: E6ZruDC4\ncode: 84' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 76 'RefreshTokenResponse' test.out

#- 77 RejectFriendsNotif
# echo "Testing 'RejectFriendsNotif'"
printf 'type: rejectFriendsNotif\nuserId: 2WH3UHS8' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 77 'RejectFriendsNotif' test.out

#- 78 RejectFriendsRequest
# echo "Testing 'RejectFriendsRequest'"
printf 'type: rejectFriendsRequest\nid: Y5tLPdYI\nfriendId: nQETDC6a' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 78 'RejectFriendsRequest' test.out

#- 79 RejectFriendsResponse
# echo "Testing 'RejectFriendsResponse'"
printf 'type: rejectFriendsResponse\nid: 9aC91rLl\ncode: 99' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 79 'RejectFriendsResponse' test.out

#- 80 RematchmakingNotif
# echo "Testing 'RematchmakingNotif'"
printf 'type: rematchmakingNotif\nbanDuration: 4' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 80 'RematchmakingNotif' test.out

#- 81 RequestFriendsNotif
# echo "Testing 'RequestFriendsNotif'"
printf 'type: requestFriendsNotif\nfriendId: KKIV4RYb' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 81 'RequestFriendsNotif' test.out

#- 82 RequestFriendsRequest
# echo "Testing 'RequestFriendsRequest'"
printf 'type: requestFriendsRequest\nid: XQwdWbDt\nfriendId: bGQcxNLV' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 82 'RequestFriendsRequest' test.out

#- 83 RequestFriendsResponse
# echo "Testing 'RequestFriendsResponse'"
printf 'type: requestFriendsResponse\nid: 7QZaIZfe\ncode: 7' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 83 'RequestFriendsResponse' test.out

#- 84 SendChannelChatRequest
# echo "Testing 'SendChannelChatRequest'"
printf 'type: sendChannelChatRequest\nid: 2D0hRKc9\nchannelSlug: T54XIDd7\npayload: juGgUSPi' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 84 'SendChannelChatRequest' test.out

#- 85 SendChannelChatResponse
# echo "Testing 'SendChannelChatResponse'"
printf 'type: sendChannelChatResponse\nid: i2CUU444\ncode: 45' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 85 'SendChannelChatResponse' test.out

#- 86 SetReadyConsentNotif
# echo "Testing 'SetReadyConsentNotif'"
printf 'type: setReadyConsentNotif\nmatchId: fWpHGGgH\nuserId: swLGzGYV' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 86 'SetReadyConsentNotif' test.out

#- 87 SetReadyConsentRequest
# echo "Testing 'SetReadyConsentRequest'"
printf 'type: setReadyConsentRequest\nid: GkUSbmgg\nmatchId: KTaDvK62' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 87 'SetReadyConsentRequest' test.out

#- 88 SetReadyConsentResponse
# echo "Testing 'SetReadyConsentResponse'"
printf 'type: setReadyConsentResponse\nid: DIRU9Jhu\ncode: 3' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 88 'SetReadyConsentResponse' test.out

#- 89 SetSessionAttributeRequest
# echo "Testing 'SetSessionAttributeRequest'"
printf 'type: setSessionAttributeRequest\nid: 3IpOuLp7\nkey: P9LA1IZ6\nnamespace: icUFeRdh\nvalue: hiYhTsGS' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 89 'SetSessionAttributeRequest' test.out

#- 90 SetSessionAttributeResponse
# echo "Testing 'SetSessionAttributeResponse'"
printf 'type: setSessionAttributeResponse\nid: BRvMcEj8\ncode: 92' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 90 'SetSessionAttributeResponse' test.out

#- 91 SetUserStatusRequest
# echo "Testing 'SetUserStatusRequest'"
printf 'type: setUserStatusRequest\nid: ecD0zV0r\nactivity: 4y9LyyJL\navailability: 61' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 91 'SetUserStatusRequest' test.out

#- 92 SetUserStatusResponse
# echo "Testing 'SetUserStatusResponse'"
printf 'type: setUserStatusResponse\nid: LcXKH95Y\ncode: 1' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 92 'SetUserStatusResponse' test.out

#- 93 ShutdownNotif
# echo "Testing 'ShutdownNotif'"
printf 'type: shutdownNotif\nmessage: UPycFbLA' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 93 'ShutdownNotif' test.out

#- 94 SignalingP2PNotif
# echo "Testing 'SignalingP2PNotif'"
printf 'type: signalingP2PNotif\ndestinationId: i9UnMuNX\nmessage: tc28u3qJ' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 94 'SignalingP2PNotif' test.out

#- 95 StartMatchmakingRequest
# echo "Testing 'StartMatchmakingRequest'"
printf 'type: startMatchmakingRequest\nid: DP1Nsf2v\nextraAttributes: MwuUGat1\ngameMode: bNnMLh9P\npartyAttributes: {"nkLd5EGA":{},"XaLg8Ce8":{},"cNozEsB4":{}}\npriority: 75\ntempParty: K7Qyvu7S' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 95 'StartMatchmakingRequest' test.out

#- 96 StartMatchmakingResponse
# echo "Testing 'StartMatchmakingResponse'"
printf 'type: startMatchmakingResponse\nid: jsf8CXUR\ncode: 97' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 96 'StartMatchmakingResponse' test.out

#- 97 UnblockPlayerNotif
# echo "Testing 'UnblockPlayerNotif'"
printf 'type: unblockPlayerNotif\nunblockedUserId: jltjTw0R\nuserId: EWPJvQzt' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 97 'UnblockPlayerNotif' test.out

#- 98 UnblockPlayerRequest
# echo "Testing 'UnblockPlayerRequest'"
printf 'type: unblockPlayerRequest\nid: 16Khjpoy\nnamespace: pgPRE6N2\nunblockedUserId: cj5UtOhJ' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 98 'UnblockPlayerRequest' test.out

#- 99 UnblockPlayerResponse
# echo "Testing 'UnblockPlayerResponse'"
printf 'type: unblockPlayerResponse\nid: 2Fg2WmBK\ncode: 41\nnamespace: IUfo8EGs\nunblockedUserId: X92Uf5bj' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 99 'UnblockPlayerResponse' test.out

#- 100 UnfriendNotif
# echo "Testing 'UnfriendNotif'"
printf 'type: unfriendNotif\nfriendId: icJcytTS' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 100 'UnfriendNotif' test.out

#- 101 UnfriendRequest
# echo "Testing 'UnfriendRequest'"
printf 'type: unfriendRequest\nid: EQwRaD9N\nfriendId: JQx3fiD1' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 101 'UnfriendRequest' test.out

#- 102 UnfriendResponse
# echo "Testing 'UnfriendResponse'"
printf 'type: unfriendResponse\nid: 3fYhehaH\ncode: 49' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 102 'UnfriendResponse' test.out

#- 103 UserBannedNotification
# echo "Testing 'UserBannedNotification'"
printf 'type: userBannedNotification' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 103 'UserBannedNotification' test.out

#- 104 UserMetricRequest
# echo "Testing 'UserMetricRequest'"
printf 'type: userMetricRequest\nid: wcX4hryF' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 104 'UserMetricRequest' test.out

#- 105 UserMetricResponse
# echo "Testing 'UserMetricResponse'"
printf 'type: userMetricResponse\nid: 1Wd996jn\ncode: 73\nplayerCount: 48' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 105 'UserMetricResponse' test.out

#- 106 UserStatusNotif
# echo "Testing 'UserStatusNotif'"
printf 'type: userStatusNotif\nactivity: oWgUuEAe\navailability: 54\nlastSeenAt: 1979-12-20T00:00:00Z\nuserId: TFi3X0EA' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 106 'UserStatusNotif' test.out


exit $EXIT_CODE