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
printf 'type: acceptFriendsNotif\nfriendId: TlEUuCSq' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 2 'AcceptFriendsNotif' test.out

#- 3 AcceptFriendsRequest
# echo "Testing 'AcceptFriendsRequest'"
printf 'type: acceptFriendsRequest\nid: HaQqsFWW\nfriendId: vbbUbl0O' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 3 'AcceptFriendsRequest' test.out

#- 4 AcceptFriendsResponse
# echo "Testing 'AcceptFriendsResponse'"
printf 'type: acceptFriendsResponse\nid: wGlQaY17\ncode: 18' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 4 'AcceptFriendsResponse' test.out

#- 5 BlockPlayerNotif
# echo "Testing 'BlockPlayerNotif'"
printf 'type: blockPlayerNotif\nblockedUserId: cgJNrXpU\nuserId: zU7WOzOb' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 5 'BlockPlayerNotif' test.out

#- 6 BlockPlayerRequest
# echo "Testing 'BlockPlayerRequest'"
printf 'type: blockPlayerRequest\nid: YSuBZiXq\nblockUserId: uF96hE5W\nnamespace: l2TclMy7' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 6 'BlockPlayerRequest' test.out

#- 7 BlockPlayerResponse
# echo "Testing 'BlockPlayerResponse'"
printf 'type: blockPlayerResponse\nid: EQt2Mrcv\nblockUserId: STBxasQK\ncode: 55\nnamespace: IcJuAQCX' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 7 'BlockPlayerResponse' test.out

#- 8 CancelFriendsNotif
# echo "Testing 'CancelFriendsNotif'"
printf 'type: cancelFriendsNotif\nuserId: SEWMOIBi' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 8 'CancelFriendsNotif' test.out

#- 9 CancelFriendsRequest
# echo "Testing 'CancelFriendsRequest'"
printf 'type: cancelFriendsRequest\nid: Q8y4hLii\nfriendId: yIb3MtAs' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 9 'CancelFriendsRequest' test.out

#- 10 CancelFriendsResponse
# echo "Testing 'CancelFriendsResponse'"
printf 'type: cancelFriendsResponse\nid: SspCsdN8\ncode: 94' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 10 'CancelFriendsResponse' test.out

#- 11 CancelMatchmakingRequest
# echo "Testing 'CancelMatchmakingRequest'"
printf 'type: cancelMatchmakingRequest\nid: sv6U1P4j\ngameMode: 8jzjQftM\nisTempParty: True' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 11 'CancelMatchmakingRequest' test.out

#- 12 CancelMatchmakingResponse
# echo "Testing 'CancelMatchmakingResponse'"
printf 'type: cancelMatchmakingResponse\nid: zx8riOns\ncode: 23' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 12 'CancelMatchmakingResponse' test.out

#- 13 ChannelChatNotif
# echo "Testing 'ChannelChatNotif'"
printf 'type: channelChatNotif\nchannelSlug: CdSXfze8\nfrom: 1oEzy0J2\npayload: W2PhdfHZ\nsentAt: g9il611I' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 13 'ChannelChatNotif' test.out

#- 14 ClientResetRequest
# echo "Testing 'ClientResetRequest'"
printf 'type: clientResetRequest\nnamespace: xec7DNme\nuserId: 3mkFhokt' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 14 'ClientResetRequest' test.out

#- 15 ConnectNotif
# echo "Testing 'ConnectNotif'"
printf 'type: connectNotif\nlobbySessionId: 1rYpjEjC' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 15 'ConnectNotif' test.out

#- 16 DisconnectNotif
# echo "Testing 'DisconnectNotif'"
printf 'type: disconnectNotif\nconnectionId: hNWxWBmy\nnamespace: CAhZTzG5' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 16 'DisconnectNotif' test.out

#- 17 DsNotif
# echo "Testing 'DsNotif'"
printf 'type: dsNotif\nalternateIps: [MKS55tth,W50ENveX,V31zyXIG]\ncustomAttribute: Q2yDKGQ8\ndeployment: s1R2Rxik\ngameVersion: DL6diqOs\nimageVersion: MZjVSIgT\nip: Kr7kb7nj\nisOK: True\nisOverrideGameVersion: True\nlastUpdate: LPej2pDn\nmatchId: tgluyTiw\nmessage: F1XETDMH\nnamespace: SgNq1Q8I\npodName: uyn7udT8\nport: 82\nports: {"fA85mFNr":57,"Ie7bn6US":2,"L4QR0Ea8":31}\nprotocol: oH5WQICz\nprovider: fvPOucnh\nregion: K1jHqh8v\nsessionId: JycEeCMo\nstatus: tQwSPlQw' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 17 'DsNotif' test.out

#- 18 ErrorNotif
# echo "Testing 'ErrorNotif'"
printf 'type: errorNotif\nmessage: us3kX6EA' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 18 'ErrorNotif' test.out

#- 19 ExitAllChannel
# echo "Testing 'ExitAllChannel'"
printf 'type: exitAllChannel\nnamespace: z5PJWIWi\nuserId: 8LRSiYJL' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 19 'ExitAllChannel' test.out

#- 20 FriendsStatusRequest
# echo "Testing 'FriendsStatusRequest'"
printf 'type: friendsStatusRequest\nid: OazgbKjy' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 20 'FriendsStatusRequest' test.out

#- 21 FriendsStatusResponse
# echo "Testing 'FriendsStatusResponse'"
printf 'type: friendsStatusResponse\nid: 82tbcFxH\nactivity: [Vh3JmkOL,9FyECqcG,ZZ5Wg8G4]\navailability: [77,2,1]\ncode: 18\nfriendIds: [X2zbpLWp,JSP7ICM9,2Y2OEwbC]\nlastSeenAt: [SQeseszi,063hu9Y6,QW85J32E]' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 21 'FriendsStatusResponse' test.out

#- 22 GetAllSessionAttributeRequest
# echo "Testing 'GetAllSessionAttributeRequest'"
printf 'type: getAllSessionAttributeRequest\nid: CS247u1P' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 22 'GetAllSessionAttributeRequest' test.out

#- 23 GetAllSessionAttributeResponse
# echo "Testing 'GetAllSessionAttributeResponse'"
printf 'type: getAllSessionAttributeResponse\nid: BXsaa8sg\nattributes: {"ec4iOxNh":"DvzYQIR2","m8gVvl4T":"dtTKFSyM","NvTFe5cF":"6amorTcd"}\ncode: 4' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 23 'GetAllSessionAttributeResponse' test.out

#- 24 GetFriendshipStatusRequest
# echo "Testing 'GetFriendshipStatusRequest'"
printf 'type: getFriendshipStatusRequest\nid: goU9Vnw6\nfriendId: UfHQSr5U' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 24 'GetFriendshipStatusRequest' test.out

#- 25 GetFriendshipStatusResponse
# echo "Testing 'GetFriendshipStatusResponse'"
printf 'type: getFriendshipStatusResponse\nid: Wg7WH5g6\ncode: 100\nfriendshipStatus: csEjhd7M' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 25 'GetFriendshipStatusResponse' test.out

#- 26 GetSessionAttributeRequest
# echo "Testing 'GetSessionAttributeRequest'"
printf 'type: getSessionAttributeRequest\nid: KuJiD4db\nkey: HI8c3HTb' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 26 'GetSessionAttributeRequest' test.out

#- 27 GetSessionAttributeResponse
# echo "Testing 'GetSessionAttributeResponse'"
printf 'type: getSessionAttributeResponse\nid: u33K6XQK\ncode: 14\nvalue: 7odWo1sY' > $TEMP_FILE_UPLOAD
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
printf 'type: joinDefaultChannelRequest\nid: IcPngdmT' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 29 'JoinDefaultChannelRequest' test.out

#- 30 JoinDefaultChannelResponse
# echo "Testing 'JoinDefaultChannelResponse'"
printf 'type: joinDefaultChannelResponse\nid: Gw7X0hrK\nchannelSlug: rU5jTvEs\ncode: 39' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 30 'JoinDefaultChannelResponse' test.out

#- 31 ListIncomingFriendsRequest
# echo "Testing 'ListIncomingFriendsRequest'"
printf 'type: listIncomingFriendsRequest\nid: 0ftxKwJ5' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 31 'ListIncomingFriendsRequest' test.out

#- 32 ListIncomingFriendsResponse
# echo "Testing 'ListIncomingFriendsResponse'"
printf 'type: listIncomingFriendsResponse\nid: sswBXkCE\ncode: 22\nuserIds: [hTdHVy6l,iYEknTxr,TwRbQubw]' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 32 'ListIncomingFriendsResponse' test.out

#- 33 ListOfFriendsRequest
# echo "Testing 'ListOfFriendsRequest'"
printf 'type: listOfFriendsRequest\nid: ZNcMbE2u\nfriendId: IIikoDLV' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 33 'ListOfFriendsRequest' test.out

#- 34 ListOfFriendsResponse
# echo "Testing 'ListOfFriendsResponse'"
printf 'type: listOfFriendsResponse\nid: OyUGynvZ\ncode: 42\nfriendIds: [dnT6sEjv,kRYXRDCn,LaEWCGLg]' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 34 'ListOfFriendsResponse' test.out

#- 35 ListOnlineFriendsRequest
# echo "Testing 'ListOnlineFriendsRequest'"
printf 'type: listOnlineFriendsRequest\nid: E5nETG8o' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 35 'ListOnlineFriendsRequest' test.out

#- 36 ListOutgoingFriendsRequest
# echo "Testing 'ListOutgoingFriendsRequest'"
printf 'type: listOutgoingFriendsRequest\nid: junjacCW' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 36 'ListOutgoingFriendsRequest' test.out

#- 37 ListOutgoingFriendsResponse
# echo "Testing 'ListOutgoingFriendsResponse'"
printf 'type: listOutgoingFriendsResponse\nid: kZLty2ia\ncode: 10\nfriendIds: [flGpTvK8,S75dWrZf,dwhMnV82]' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 37 'ListOutgoingFriendsResponse' test.out

#- 38 MatchmakingNotif
# echo "Testing 'MatchmakingNotif'"
printf 'type: matchmakingNotif\ncounterPartyMember: [Nnop6aMV,MjdpeIHm,PWYqqpEC]\nmatchId: y5LEeQHN\nmessage: vPDPCkZt\npartyMember: [0jAFMPaM,hmM1pWlU,2ht1W1W8]\nreadyDuration: 81\nstatus: AKAlnPlV' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 38 'MatchmakingNotif' test.out

#- 39 MessageNotif
# echo "Testing 'MessageNotif'"
printf 'type: messageNotif\nid: FNdyDI9i\nfrom: 3t5rJLfO\npayload: UFIpLho2\nsentAt: 100\nto: UvyYacYp\ntopic: s4cmh906' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 39 'MessageNotif' test.out

#- 40 OfflineNotificationRequest
# echo "Testing 'OfflineNotificationRequest'"
printf 'type: offlineNotificationRequest\nid: B4JxTsn3' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 40 'OfflineNotificationRequest' test.out

#- 41 OfflineNotificationResponse
# echo "Testing 'OfflineNotificationResponse'"
printf 'type: offlineNotificationResponse\nid: giJwSg6n\ncode: 93' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 41 'OfflineNotificationResponse' test.out

#- 42 OnlineFriends
# echo "Testing 'OnlineFriends'"
printf 'type: onlineFriends\nid: uO0zu4x3\ncode: 95\nonlineFriendIds: [rNVfmilF,LV5T1bmT,bqeffsk4]' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 42 'OnlineFriends' test.out

#- 43 PartyChatNotif
# echo "Testing 'PartyChatNotif'"
printf 'type: partyChatNotif\nid: WnbPnuFx\nfrom: k2KdWkEE\npayload: NEXXx0uj\nreceivedAt: 48\nto: fsHszXEv' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 43 'PartyChatNotif' test.out

#- 44 PartyChatRequest
# echo "Testing 'PartyChatRequest'"
printf 'type: partyChatRequest\nid: 72tvJ9tX\nfrom: FzrW8vwY\npayload: 1pV2NhnP\nreceivedAt: 99\nto: FP46GX4h' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 44 'PartyChatRequest' test.out

#- 45 PartyChatResponse
# echo "Testing 'PartyChatResponse'"
printf 'type: partyChatResponse\nid: AeSGmPPP\ncode: 65' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 45 'PartyChatResponse' test.out

#- 46 PartyCreateRequest
# echo "Testing 'PartyCreateRequest'"
printf 'type: partyCreateRequest\nid: TRqiX5ts' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 46 'PartyCreateRequest' test.out

#- 47 PartyCreateResponse
# echo "Testing 'PartyCreateResponse'"
printf 'type: partyCreateResponse\nid: kT8tFZgn\ncode: 60\ninvitationToken: 3mqZXBkV\ninvitees: DHREvVYy\nleaderId: BjEFuvlx\nmembers: H1s7STsZ\npartyId: 5lODuZxt' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 47 'PartyCreateResponse' test.out

#- 48 PartyDataUpdateNotif
# echo "Testing 'PartyDataUpdateNotif'"
printf 'type: partyDataUpdateNotif\ncustomAttributes: {"tm23PAUI":{},"8HLDazLF":{},"6Hr9sMj1":{}}\ninvitees: [3GSRCNBm,8kghtgHM,Dd6ZnsFm]\nleader: L7e16y5a\nmembers: [UZpItWvu,iZy7tMNz,9KU3tPVC]\nnamespace: LbI5N6pE\npartyId: DA4ohrtZ\nupdatedAt: 83' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 48 'PartyDataUpdateNotif' test.out

#- 49 PartyGetInvitedNotif
# echo "Testing 'PartyGetInvitedNotif'"
printf 'type: partyGetInvitedNotif\nfrom: OOAnfhF6\ninvitationToken: lZsJtTag\npartyId: rkJopfXb' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 49 'PartyGetInvitedNotif' test.out

#- 50 PartyInfoRequest
# echo "Testing 'PartyInfoRequest'"
printf 'type: partyInfoRequest\nid: yBL9jENL' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 50 'PartyInfoRequest' test.out

#- 51 PartyInfoResponse
# echo "Testing 'PartyInfoResponse'"
printf 'type: partyInfoResponse\nid: 3EpLGwvD\ncode: 78\ncustomAttributes: {"CnKVdlCN":{},"sGTcft0i":{},"po1CCXBe":{}}\ninvitationToken: F3lkyQ4Z\ninvitees: 49JmjJRC\nleaderId: TM5a1J8S\nmembers: GYPCVG09\npartyId: grmgchif' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 51 'PartyInfoResponse' test.out

#- 52 PartyInviteNotif
# echo "Testing 'PartyInviteNotif'"
printf 'type: partyInviteNotif\ninviteeId: Np8IOIlr\ninviterId: P5KVBxMC' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 52 'PartyInviteNotif' test.out

#- 53 PartyInviteRequest
# echo "Testing 'PartyInviteRequest'"
printf 'type: partyInviteRequest\nid: BSOMm35y\nfriendId: uwvZqrcR' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 53 'PartyInviteRequest' test.out

#- 54 PartyInviteResponse
# echo "Testing 'PartyInviteResponse'"
printf 'type: partyInviteResponse\nid: SF5rhBIJ\ncode: 65' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 54 'PartyInviteResponse' test.out

#- 55 PartyJoinNotif
# echo "Testing 'PartyJoinNotif'"
printf 'type: partyJoinNotif\nuserId: cVaKwi16' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 55 'PartyJoinNotif' test.out

#- 56 PartyJoinRequest
# echo "Testing 'PartyJoinRequest'"
printf 'type: partyJoinRequest\nid: HPbF7srR\ninvitationToken: zujMQE3E\npartyId: qIX1SrwQ' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 56 'PartyJoinRequest' test.out

#- 57 PartyJoinResponse
# echo "Testing 'PartyJoinResponse'"
printf 'type: partyJoinResponse\nid: 31mo6YpE\ncode: 61\ninvitationToken: GqG2vu3q\ninvitees: eP3jAL1u\nleaderId: YsaukN9V\nmembers: AlZr3cFF\npartyId: PwfGuI0S' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 57 'PartyJoinResponse' test.out

#- 58 PartyKickNotif
# echo "Testing 'PartyKickNotif'"
printf 'type: partyKickNotif\nleaderId: dIHu48m4\npartyId: Kg2zG2j4\nuserId: JM9HyKgh' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 58 'PartyKickNotif' test.out

#- 59 PartyKickRequest
# echo "Testing 'PartyKickRequest'"
printf 'type: partyKickRequest\nid: 44xDR7Dg\nmemberId: xgXMSOUi' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 59 'PartyKickRequest' test.out

#- 60 PartyKickResponse
# echo "Testing 'PartyKickResponse'"
printf 'type: partyKickResponse\nid: hd6wUBN8\ncode: 70' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 60 'PartyKickResponse' test.out

#- 61 PartyLeaveNotif
# echo "Testing 'PartyLeaveNotif'"
printf 'type: partyLeaveNotif\nleaderId: yCR89MJn\nuserId: mqt55HI8' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 61 'PartyLeaveNotif' test.out

#- 62 PartyLeaveRequest
# echo "Testing 'PartyLeaveRequest'"
printf 'type: partyLeaveRequest\nid: u65zCwiQ\nignoreUserRegistry: True' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 62 'PartyLeaveRequest' test.out

#- 63 PartyLeaveResponse
# echo "Testing 'PartyLeaveResponse'"
printf 'type: partyLeaveResponse\nid: jkq6iNrO\ncode: 85' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 63 'PartyLeaveResponse' test.out

#- 64 PartyPromoteLeaderRequest
# echo "Testing 'PartyPromoteLeaderRequest'"
printf 'type: partyPromoteLeaderRequest\nid: iiOxXF4b\nnewLeaderUserId: RlfSOVIw' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 64 'PartyPromoteLeaderRequest' test.out

#- 65 PartyPromoteLeaderResponse
# echo "Testing 'PartyPromoteLeaderResponse'"
printf 'type: partyPromoteLeaderResponse\nid: ZacBS5pc\ncode: 23\ninvitationToken: gfnVOTrk\ninvitees: gtoz8A4q\nleaderId: uEb2w980\nmembers: bXtEx9Z2\npartyId: d8OyR4rC' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 65 'PartyPromoteLeaderResponse' test.out

#- 66 PartyRejectNotif
# echo "Testing 'PartyRejectNotif'"
printf 'type: partyRejectNotif\nleaderId: poneChMA\npartyId: fRVNZBUS\nuserId: xrJ3AFcg' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 66 'PartyRejectNotif' test.out

#- 67 PartyRejectRequest
# echo "Testing 'PartyRejectRequest'"
printf 'type: partyRejectRequest\nid: 42CAdoe2\ninvitationToken: dFR77e6c\npartyId: G3dtFhP4' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 67 'PartyRejectRequest' test.out

#- 68 PartyRejectResponse
# echo "Testing 'PartyRejectResponse'"
printf 'type: partyRejectResponse\nid: nEeXsUBm\ncode: 58\npartyId: XQy7xCzD' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 68 'PartyRejectResponse' test.out

#- 69 PersonalChatHistoryRequest
# echo "Testing 'PersonalChatHistoryRequest'"
printf 'type: personalChatHistoryRequest\nid: oNho1E4z\nfriendId: jn3UtIOS' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 69 'PersonalChatHistoryRequest' test.out

#- 70 PersonalChatHistoryResponse
# echo "Testing 'PersonalChatHistoryResponse'"
printf 'type: personalChatHistoryResponse\nid: l6eeo0et\nchat: e5642Hf2\ncode: 31\nfriendId: XTLuyg42' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 70 'PersonalChatHistoryResponse' test.out

#- 71 PersonalChatNotif
# echo "Testing 'PersonalChatNotif'"
printf 'type: personalChatNotif\nid: 9CsmLTSM\nfrom: vWixNkBK\npayload: breU4p1u\nreceivedAt: 22\nto: fbaXndQM' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 71 'PersonalChatNotif' test.out

#- 72 PersonalChatRequest
# echo "Testing 'PersonalChatRequest'"
printf 'type: personalChatRequest\nid: lfX1KANS\nfrom: OdJiAzqv\npayload: 9QsZJde1\nreceivedAt: 30\nto: WeLavUCY' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 72 'PersonalChatRequest' test.out

#- 73 PersonalChatResponse
# echo "Testing 'PersonalChatResponse'"
printf 'type: personalChatResponse\nid: F80RTbkQ\ncode: 91' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 73 'PersonalChatResponse' test.out

#- 74 RefreshTokenRequest
# echo "Testing 'RefreshTokenRequest'"
printf 'type: refreshTokenRequest\nid: znzZ2ApV\ntoken: 8aeMUys4' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 74 'RefreshTokenRequest' test.out

#- 75 RefreshTokenResponse
# echo "Testing 'RefreshTokenResponse'"
printf 'type: refreshTokenResponse\nid: 982L7bLz\ncode: 76' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 75 'RefreshTokenResponse' test.out

#- 76 RejectFriendsNotif
# echo "Testing 'RejectFriendsNotif'"
printf 'type: rejectFriendsNotif\nuserId: THTHqkJo' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 76 'RejectFriendsNotif' test.out

#- 77 RejectFriendsRequest
# echo "Testing 'RejectFriendsRequest'"
printf 'type: rejectFriendsRequest\nid: 4dJiE9Ez\nfriendId: wQRWMBzk' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 77 'RejectFriendsRequest' test.out

#- 78 RejectFriendsResponse
# echo "Testing 'RejectFriendsResponse'"
printf 'type: rejectFriendsResponse\nid: Q7HMarPQ\ncode: 89' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 78 'RejectFriendsResponse' test.out

#- 79 RematchmakingNotif
# echo "Testing 'RematchmakingNotif'"
printf 'type: rematchmakingNotif\nbanDuration: 34' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 79 'RematchmakingNotif' test.out

#- 80 RequestFriendsNotif
# echo "Testing 'RequestFriendsNotif'"
printf 'type: requestFriendsNotif\nfriendId: OQJYLN4T' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 80 'RequestFriendsNotif' test.out

#- 81 RequestFriendsRequest
# echo "Testing 'RequestFriendsRequest'"
printf 'type: requestFriendsRequest\nid: e28pGrDy\nfriendId: Cna0gXDV' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 81 'RequestFriendsRequest' test.out

#- 82 RequestFriendsResponse
# echo "Testing 'RequestFriendsResponse'"
printf 'type: requestFriendsResponse\nid: ORNx2v3G\ncode: 96' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 82 'RequestFriendsResponse' test.out

#- 83 SendChannelChatRequest
# echo "Testing 'SendChannelChatRequest'"
printf 'type: sendChannelChatRequest\nid: WSXT2iww\nchannelSlug: TOIaksQM\npayload: MSHTxNIp' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 83 'SendChannelChatRequest' test.out

#- 84 SendChannelChatResponse
# echo "Testing 'SendChannelChatResponse'"
printf 'type: sendChannelChatResponse\nid: jDcelB8T\ncode: 7' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 84 'SendChannelChatResponse' test.out

#- 85 SetReadyConsentNotif
# echo "Testing 'SetReadyConsentNotif'"
printf 'type: setReadyConsentNotif\nmatchId: japyqLxl\nuserId: 0KsGnswF' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 85 'SetReadyConsentNotif' test.out

#- 86 SetReadyConsentRequest
# echo "Testing 'SetReadyConsentRequest'"
printf 'type: setReadyConsentRequest\nid: hFx6iQCQ\nmatchId: VzD76p4C' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 86 'SetReadyConsentRequest' test.out

#- 87 SetReadyConsentResponse
# echo "Testing 'SetReadyConsentResponse'"
printf 'type: setReadyConsentResponse\nid: pgLEeadb\ncode: 60' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 87 'SetReadyConsentResponse' test.out

#- 88 SetSessionAttributeRequest
# echo "Testing 'SetSessionAttributeRequest'"
printf 'type: setSessionAttributeRequest\nid: WnhXsG6L\nkey: OLGUkg4Z\nnamespace: IzF5lDZR\nvalue: gStxTpTv' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 88 'SetSessionAttributeRequest' test.out

#- 89 SetSessionAttributeResponse
# echo "Testing 'SetSessionAttributeResponse'"
printf 'type: setSessionAttributeResponse\nid: hhIBxhpj\ncode: 44' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 89 'SetSessionAttributeResponse' test.out

#- 90 SetUserStatusRequest
# echo "Testing 'SetUserStatusRequest'"
printf 'type: setUserStatusRequest\nid: 1l6yiK7w\nactivity: nSAGbX0r\navailability: 95' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 90 'SetUserStatusRequest' test.out

#- 91 SetUserStatusResponse
# echo "Testing 'SetUserStatusResponse'"
printf 'type: setUserStatusResponse\nid: vfin29kq\ncode: 26' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 91 'SetUserStatusResponse' test.out

#- 92 ShutdownNotif
# echo "Testing 'ShutdownNotif'"
printf 'type: shutdownNotif\nmessage: L1TCPqB7' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 92 'ShutdownNotif' test.out

#- 93 SignalingP2PNotif
# echo "Testing 'SignalingP2PNotif'"
printf 'type: signalingP2PNotif\ndestinationId: 0okiF2LJ\nmessage: yBc7DeZL' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 93 'SignalingP2PNotif' test.out

#- 94 StartMatchmakingRequest
# echo "Testing 'StartMatchmakingRequest'"
printf 'type: startMatchmakingRequest\nid: 7NQJn5z2\nextraAttributes: 5Eb3lyqq\ngameMode: OJnSU2My\npartyAttributes: {"UGn19xs0":{},"mnqAFKk8":{},"b7WCszOk":{}}\npriority: 14\ntempParty: jEVMCC6y' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 94 'StartMatchmakingRequest' test.out

#- 95 StartMatchmakingResponse
# echo "Testing 'StartMatchmakingResponse'"
printf 'type: startMatchmakingResponse\nid: xj14Vb1x\ncode: 68' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 95 'StartMatchmakingResponse' test.out

#- 96 UnblockPlayerNotif
# echo "Testing 'UnblockPlayerNotif'"
printf 'type: unblockPlayerNotif\nunblockedUserId: K9lJLdyO\nuserId: 7T7kjXW3' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 96 'UnblockPlayerNotif' test.out

#- 97 UnblockPlayerRequest
# echo "Testing 'UnblockPlayerRequest'"
printf 'type: unblockPlayerRequest\nid: e4dRlt4C\nnamespace: SED0C3Cc\nunblockedUserId: mMjwX3Xx' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 97 'UnblockPlayerRequest' test.out

#- 98 UnblockPlayerResponse
# echo "Testing 'UnblockPlayerResponse'"
printf 'type: unblockPlayerResponse\nid: dOKCtkTL\ncode: 86\nnamespace: kPflNWLw\nunblockedUserId: 4HyfYIg6' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 98 'UnblockPlayerResponse' test.out

#- 99 UnfriendNotif
# echo "Testing 'UnfriendNotif'"
printf 'type: unfriendNotif\nfriendId: KE9keuAN' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 99 'UnfriendNotif' test.out

#- 100 UnfriendRequest
# echo "Testing 'UnfriendRequest'"
printf 'type: unfriendRequest\nid: 1lrd0MiS\nfriendId: Rfhg9uhm' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 100 'UnfriendRequest' test.out

#- 101 UnfriendResponse
# echo "Testing 'UnfriendResponse'"
printf 'type: unfriendResponse\nid: lODt7rn5\ncode: 13' > $TEMP_FILE_UPLOAD
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
printf 'type: userMetricRequest\nid: 7mMl99wW' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 103 'UserMetricRequest' test.out

#- 104 UserMetricResponse
# echo "Testing 'UserMetricResponse'"
printf 'type: userMetricResponse\nid: 33CagqOC\ncode: 72\nplayerCount: 32' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 104 'UserMetricResponse' test.out

#- 105 UserStatusNotif
# echo "Testing 'UserStatusNotif'"
printf 'type: userStatusNotif\nactivity: NCS0iZ9t\navailability: 91\nlastSeenAt: qek7JjtK\nuserId: IbZQ81Ru' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 105 'UserStatusNotif' test.out


exit $EXIT_CODE