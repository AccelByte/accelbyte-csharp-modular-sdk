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
printf 'type: acceptFriendsNotif\nfriendId: x0U7inKj' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 2 'AcceptFriendsNotif' test.out

#- 3 AcceptFriendsRequest
# echo "Testing 'AcceptFriendsRequest'"
printf 'type: acceptFriendsRequest\nid: tDhyMXoF\nfriendId: eWZzszNt' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 3 'AcceptFriendsRequest' test.out

#- 4 AcceptFriendsResponse
# echo "Testing 'AcceptFriendsResponse'"
printf 'type: acceptFriendsResponse\nid: DMJsJjkX\ncode: 72' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 4 'AcceptFriendsResponse' test.out

#- 5 BlockPlayerNotif
# echo "Testing 'BlockPlayerNotif'"
printf 'type: blockPlayerNotif\nblockedUserId: TKpxzWlR\nuserId: AdCwEQbi' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 5 'BlockPlayerNotif' test.out

#- 6 BlockPlayerRequest
# echo "Testing 'BlockPlayerRequest'"
printf 'type: blockPlayerRequest\nid: b2Uifsh0\nblockUserId: hQMfJBbP\nnamespace: Uwlj4uj6' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 6 'BlockPlayerRequest' test.out

#- 7 BlockPlayerResponse
# echo "Testing 'BlockPlayerResponse'"
printf 'type: blockPlayerResponse\nid: oPut2CpU\nblockUserId: L5uG1oJ3\ncode: 57\nnamespace: oQeCD25q' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 7 'BlockPlayerResponse' test.out

#- 8 CancelFriendsNotif
# echo "Testing 'CancelFriendsNotif'"
printf 'type: cancelFriendsNotif\nuserId: qDDMgz6R' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 8 'CancelFriendsNotif' test.out

#- 9 CancelFriendsRequest
# echo "Testing 'CancelFriendsRequest'"
printf 'type: cancelFriendsRequest\nid: M1RCYV0H\nfriendId: yh4hCdPN' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 9 'CancelFriendsRequest' test.out

#- 10 CancelFriendsResponse
# echo "Testing 'CancelFriendsResponse'"
printf 'type: cancelFriendsResponse\nid: SOQuHKoh\ncode: 83' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 10 'CancelFriendsResponse' test.out

#- 11 CancelMatchmakingRequest
# echo "Testing 'CancelMatchmakingRequest'"
printf 'type: cancelMatchmakingRequest\nid: fuOYpojv\ngameMode: hXspdpXB\nisTempParty: False' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 11 'CancelMatchmakingRequest' test.out

#- 12 CancelMatchmakingResponse
# echo "Testing 'CancelMatchmakingResponse'"
printf 'type: cancelMatchmakingResponse\nid: jkhNo7Ur\ncode: 20' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 12 'CancelMatchmakingResponse' test.out

#- 13 ChannelChatNotif
# echo "Testing 'ChannelChatNotif'"
printf 'type: channelChatNotif\nchannelSlug: FxhjBBJO\nfrom: H1VaPgHg\npayload: RwFrCk83\nsentAt: nVGjICbt' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 13 'ChannelChatNotif' test.out

#- 14 ClientResetRequest
# echo "Testing 'ClientResetRequest'"
printf 'type: clientResetRequest\nnamespace: zgqYvprM\nuserId: z0TWTNPN' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 14 'ClientResetRequest' test.out

#- 15 ConnectNotif
# echo "Testing 'ConnectNotif'"
printf 'type: connectNotif\nlobbySessionId: XHvVoiQg' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 15 'ConnectNotif' test.out

#- 16 DisconnectNotif
# echo "Testing 'DisconnectNotif'"
printf 'type: disconnectNotif\nconnectionId: bEW1zXLQ\nnamespace: 7ieRT2tB' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 16 'DisconnectNotif' test.out

#- 17 DsNotif
# echo "Testing 'DsNotif'"
printf 'type: dsNotif\nalternateIps: [z0wTP7Ef,Z1SZsO3w,P6KIuej8]\ncustomAttribute: qrsU9bdX\ndeployment: Ad2OpsoT\ngameVersion: sRwlh9uj\nimageVersion: v28ukSMf\nip: 3m2Gtwbf\nisOK: True\nisOverrideGameVersion: True\nlastUpdate: lkcnOteU\nmatchId: fz1nHt49\nmessage: tTBY2Z5c\nnamespace: nGcgjitC\npodName: 7enyM3Kj\nport: 77\nports: {"sMIJKHek":3,"QHAekeHH":4,"rE1Uzxfl":66}\nprotocol: aZmry51z\nprovider: xZXmBiTm\nregion: ejUnxrHi\nsessionId: gU3UexNM\nstatus: vOz299i8' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 17 'DsNotif' test.out

#- 18 ErrorNotif
# echo "Testing 'ErrorNotif'"
printf 'type: errorNotif\nmessage: xnA6fD07' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 18 'ErrorNotif' test.out

#- 19 ExitAllChannel
# echo "Testing 'ExitAllChannel'"
printf 'type: exitAllChannel\nnamespace: xC0xSDVb\nuserId: GygLctGH' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 19 'ExitAllChannel' test.out

#- 20 FriendsStatusRequest
# echo "Testing 'FriendsStatusRequest'"
printf 'type: friendsStatusRequest\nid: j87BP1Dq' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 20 'FriendsStatusRequest' test.out

#- 21 FriendsStatusResponse
# echo "Testing 'FriendsStatusResponse'"
printf 'type: friendsStatusResponse\nid: JIwlskn5\nactivity: [LLufOhAJ,Ovt7tRiH,Og5LCERk]\navailability: [y4BFPImS,bIpMwD0H,UhRwHVaX]\ncode: 21\nfriendIds: [0icn3B7f,yPzLRlGK,EUBz9rMF]\nlastSeenAt: [MNhza8pa,GUEsCtJM,5QGp4x0D]' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 21 'FriendsStatusResponse' test.out

#- 22 GetAllSessionAttributeRequest
# echo "Testing 'GetAllSessionAttributeRequest'"
printf 'type: getAllSessionAttributeRequest\nid: aUONAkSS' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 22 'GetAllSessionAttributeRequest' test.out

#- 23 GetAllSessionAttributeResponse
# echo "Testing 'GetAllSessionAttributeResponse'"
printf 'type: getAllSessionAttributeResponse\nid: AKg08kcH\nattributes: {"2Xvnzja7":"iDPUxQd8","VdEaT4cJ":"OFoYennq","5k1Sv9Y4":"8qtZVNKG"}\ncode: 89' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 23 'GetAllSessionAttributeResponse' test.out

#- 24 GetFriendshipStatusRequest
# echo "Testing 'GetFriendshipStatusRequest'"
printf 'type: getFriendshipStatusRequest\nid: OO8hixlk\nfriendId: BXrpyCoo' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 24 'GetFriendshipStatusRequest' test.out

#- 25 GetFriendshipStatusResponse
# echo "Testing 'GetFriendshipStatusResponse'"
printf 'type: getFriendshipStatusResponse\nid: l9r9YaAK\ncode: 45\nfriendshipStatus: G89qeSEY' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 25 'GetFriendshipStatusResponse' test.out

#- 26 GetSessionAttributeRequest
# echo "Testing 'GetSessionAttributeRequest'"
printf 'type: getSessionAttributeRequest\nid: Cd8U87Cj\nkey: XRIC3GcG' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 26 'GetSessionAttributeRequest' test.out

#- 27 GetSessionAttributeResponse
# echo "Testing 'GetSessionAttributeResponse'"
printf 'type: getSessionAttributeResponse\nid: gVtDRNYL\ncode: 97\nvalue: hg3LNwtk' > $TEMP_FILE_UPLOAD
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
printf 'type: joinDefaultChannelRequest\nid: 3CofWPRF' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 29 'JoinDefaultChannelRequest' test.out

#- 30 JoinDefaultChannelResponse
# echo "Testing 'JoinDefaultChannelResponse'"
printf 'type: joinDefaultChannelResponse\nid: X4NZdCKy\nchannelSlug: 1ZVxrlaZ\ncode: 70' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 30 'JoinDefaultChannelResponse' test.out

#- 31 ListIncomingFriendsRequest
# echo "Testing 'ListIncomingFriendsRequest'"
printf 'type: listIncomingFriendsRequest\nid: eL8MsHiz' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 31 'ListIncomingFriendsRequest' test.out

#- 32 ListIncomingFriendsResponse
# echo "Testing 'ListIncomingFriendsResponse'"
printf 'type: listIncomingFriendsResponse\nid: iislkgKt\ncode: 91\nuserIds: [SiYwBmnh,IngX9VZA,TWXddYVB]' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 32 'ListIncomingFriendsResponse' test.out

#- 33 ListOfFriendsRequest
# echo "Testing 'ListOfFriendsRequest'"
printf 'type: listOfFriendsRequest\nid: LQGrjMQP\nfriendId: QQrUg742' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 33 'ListOfFriendsRequest' test.out

#- 34 ListOfFriendsResponse
# echo "Testing 'ListOfFriendsResponse'"
printf 'type: listOfFriendsResponse\nid: Pg3GRh8u\ncode: 44\nfriendIds: [dJr7GDbJ,egLvO6Kn,5BTb2F4x]' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 34 'ListOfFriendsResponse' test.out

#- 35 ListOnlineFriendsRequest
# echo "Testing 'ListOnlineFriendsRequest'"
printf 'type: listOnlineFriendsRequest\nid: V5qHYujI' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 35 'ListOnlineFriendsRequest' test.out

#- 36 ListOutgoingFriendsRequest
# echo "Testing 'ListOutgoingFriendsRequest'"
printf 'type: listOutgoingFriendsRequest\nid: f14VxyXC' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 36 'ListOutgoingFriendsRequest' test.out

#- 37 ListOutgoingFriendsResponse
# echo "Testing 'ListOutgoingFriendsResponse'"
printf 'type: listOutgoingFriendsResponse\nid: iAP0okTi\ncode: 36\nfriendIds: [WONIw9d4,pE5tRuIs,Tz1DtrnP]' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 37 'ListOutgoingFriendsResponse' test.out

#- 38 MatchmakingNotif
# echo "Testing 'MatchmakingNotif'"
printf 'type: matchmakingNotif\ncounterPartyMember: [5NwVJj5d,qlqP09sY,tROcKywd]\nmatchId: vwKyYjka\nmessage: 3SBFeiSX\npartyMember: [wgjPFdNK,nTioreyO,axm1sEj3]\nreadyDuration: 90\nstatus: IBHh5cVN' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 38 'MatchmakingNotif' test.out

#- 39 MessageNotif
# echo "Testing 'MessageNotif'"
printf 'type: messageNotif\nid: SzaSsQs7\nfrom: ebX5bs5z\npayload: PKpHY73u\nsentAt: 39\nto: TUOTda2D\ntopic: N0rsDFty' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 39 'MessageNotif' test.out

#- 40 OfflineNotificationRequest
# echo "Testing 'OfflineNotificationRequest'"
printf 'type: offlineNotificationRequest\nid: MsKHwqBX' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 40 'OfflineNotificationRequest' test.out

#- 41 OfflineNotificationResponse
# echo "Testing 'OfflineNotificationResponse'"
printf 'type: offlineNotificationResponse\nid: NwQfhPzP\ncode: 59' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 41 'OfflineNotificationResponse' test.out

#- 42 OnlineFriends
# echo "Testing 'OnlineFriends'"
printf 'type: onlineFriends\nid: kwKSSog0\ncode: 64\nonlineFriendIds: [qzyCSb4O,mnWybono,rtfYPgRv]' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 42 'OnlineFriends' test.out

#- 43 PartyChatNotif
# echo "Testing 'PartyChatNotif'"
printf 'type: partyChatNotif\nid: Rknkzz8n\nfrom: WJheVl9S\npayload: UQRpwcqG\nreceivedAt: 26\nto: TdgKvg0y' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 43 'PartyChatNotif' test.out

#- 44 PartyChatRequest
# echo "Testing 'PartyChatRequest'"
printf 'type: partyChatRequest\nid: FCsAlf9b\nfrom: TvgfJsub\npayload: 8PyLBK9A\nreceivedAt: 24\nto: 8u5kzOZI' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 44 'PartyChatRequest' test.out

#- 45 PartyChatResponse
# echo "Testing 'PartyChatResponse'"
printf 'type: partyChatResponse\nid: 3wO9TD6h\ncode: 18' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 45 'PartyChatResponse' test.out

#- 46 PartyCreateRequest
# echo "Testing 'PartyCreateRequest'"
printf 'type: partyCreateRequest\nid: SY1r3MzJ' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 46 'PartyCreateRequest' test.out

#- 47 PartyCreateResponse
# echo "Testing 'PartyCreateResponse'"
printf 'type: partyCreateResponse\nid: ZAIdwSpV\ncode: 89\ninvitationToken: lCXBEUYl\ninvitees: tyUynQgv\nleaderId: F2Ke0Mtk\nmembers: BUDJh2pC\npartyId: FDU27Yrq' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 47 'PartyCreateResponse' test.out

#- 48 PartyDataUpdateNotif
# echo "Testing 'PartyDataUpdateNotif'"
printf 'type: partyDataUpdateNotif\ncustomAttributes: {"281QMeC3":{},"7R9atcp5":{},"psM3YqLp":{}}\ninvitees: [ucZkSJVl,mjGItxnq,9fjtoxr2]\nleader: MlSxNm7m\nmembers: [eW1Pqvd1,GApfC8pc,EQGHLvYK]\nnamespace: kioFPtC8\npartyId: 6Xwyztoo\nupdatedAt: 77' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 48 'PartyDataUpdateNotif' test.out

#- 49 PartyGetInvitedNotif
# echo "Testing 'PartyGetInvitedNotif'"
printf 'type: partyGetInvitedNotif\nfrom: NmTFg94d\ninvitationToken: 4eiaoCwE\npartyId: YdTd0ZOz' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 49 'PartyGetInvitedNotif' test.out

#- 50 PartyInfoRequest
# echo "Testing 'PartyInfoRequest'"
printf 'type: partyInfoRequest\nid: PT5OACiO' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 50 'PartyInfoRequest' test.out

#- 51 PartyInfoResponse
# echo "Testing 'PartyInfoResponse'"
printf 'type: partyInfoResponse\nid: nN6PJVf0\ncode: 43\ncustomAttributes: {"bSQGtsGU":{},"EqnhrbEb":{},"G2HMl4zS":{}}\ninvitationToken: 9rZNCnfA\ninvitees: PDMcr5BP\nleaderId: bqrn52vX\nmembers: bJrYPis0\npartyId: ait85smX' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 51 'PartyInfoResponse' test.out

#- 52 PartyInviteNotif
# echo "Testing 'PartyInviteNotif'"
printf 'type: partyInviteNotif\ninviteeId: fYYvAoVx\ninviterId: H5c1qtzn' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 52 'PartyInviteNotif' test.out

#- 53 PartyInviteRequest
# echo "Testing 'PartyInviteRequest'"
printf 'type: partyInviteRequest\nid: pLcy7xo6\nfriendId: Yrsi6JGg' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 53 'PartyInviteRequest' test.out

#- 54 PartyInviteResponse
# echo "Testing 'PartyInviteResponse'"
printf 'type: partyInviteResponse\nid: uTeJFZB0\ncode: 45' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 54 'PartyInviteResponse' test.out

#- 55 PartyJoinNotif
# echo "Testing 'PartyJoinNotif'"
printf 'type: partyJoinNotif\nuserId: nBHKyWcO' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 55 'PartyJoinNotif' test.out

#- 56 PartyJoinRequest
# echo "Testing 'PartyJoinRequest'"
printf 'type: partyJoinRequest\nid: wi0zBL47\ninvitationToken: KD0Azmje\npartyId: uQiZOPte' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 56 'PartyJoinRequest' test.out

#- 57 PartyJoinResponse
# echo "Testing 'PartyJoinResponse'"
printf 'type: partyJoinResponse\nid: oNciqzTq\ncode: 64\ninvitationToken: pPLjZxkb\ninvitees: SuSbX4X1\nleaderId: q7p3Gdxw\nmembers: FNp4Unra\npartyId: NCJivKdl' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 57 'PartyJoinResponse' test.out

#- 58 PartyKickNotif
# echo "Testing 'PartyKickNotif'"
printf 'type: partyKickNotif\nleaderId: TCZssXoL\npartyId: 0swWVWeK\nuserId: 8BAcfkl9' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 58 'PartyKickNotif' test.out

#- 59 PartyKickRequest
# echo "Testing 'PartyKickRequest'"
printf 'type: partyKickRequest\nid: IgUjNzxb\nmemberId: 1QpdGBYO' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 59 'PartyKickRequest' test.out

#- 60 PartyKickResponse
# echo "Testing 'PartyKickResponse'"
printf 'type: partyKickResponse\nid: VqpId025\ncode: 58' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 60 'PartyKickResponse' test.out

#- 61 PartyLeaveNotif
# echo "Testing 'PartyLeaveNotif'"
printf 'type: partyLeaveNotif\nleaderId: SGDWQEaj\nuserId: Vu9y3WHl' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 61 'PartyLeaveNotif' test.out

#- 62 PartyLeaveRequest
# echo "Testing 'PartyLeaveRequest'"
printf 'type: partyLeaveRequest\nid: 22kH91GE\nignoreUserRegistry: True' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 62 'PartyLeaveRequest' test.out

#- 63 PartyLeaveResponse
# echo "Testing 'PartyLeaveResponse'"
printf 'type: partyLeaveResponse\nid: TVDsJzku\ncode: 19' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 63 'PartyLeaveResponse' test.out

#- 64 PartyPromoteLeaderRequest
# echo "Testing 'PartyPromoteLeaderRequest'"
printf 'type: partyPromoteLeaderRequest\nid: VcC14o4V\nnewLeaderUserId: BWO7m05Y' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 64 'PartyPromoteLeaderRequest' test.out

#- 65 PartyPromoteLeaderResponse
# echo "Testing 'PartyPromoteLeaderResponse'"
printf 'type: partyPromoteLeaderResponse\nid: xsZY89lN\ncode: 41\ninvitationToken: ULjw6Dsz\ninvitees: sZZ9I3xR\nleaderId: lg2HPgVe\nmembers: Ip1avWlM\npartyId: aewbxLdZ' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 65 'PartyPromoteLeaderResponse' test.out

#- 66 PartyRejectNotif
# echo "Testing 'PartyRejectNotif'"
printf 'type: partyRejectNotif\nleaderId: tC5YkhD6\npartyId: blEiJezh\nuserId: ESc8eh0f' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 66 'PartyRejectNotif' test.out

#- 67 PartyRejectRequest
# echo "Testing 'PartyRejectRequest'"
printf 'type: partyRejectRequest\nid: xcmoOJRc\ninvitationToken: mIwhvfWq\npartyId: GphFTkr6' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 67 'PartyRejectRequest' test.out

#- 68 PartyRejectResponse
# echo "Testing 'PartyRejectResponse'"
printf 'type: partyRejectResponse\nid: VXZJYNXk\ncode: 51\npartyId: 2LhaORUN' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 68 'PartyRejectResponse' test.out

#- 69 PersonalChatHistoryRequest
# echo "Testing 'PersonalChatHistoryRequest'"
printf 'type: personalChatHistoryRequest\nid: Y6ihTPld\nfriendId: qPpqJBny' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 69 'PersonalChatHistoryRequest' test.out

#- 70 PersonalChatHistoryResponse
# echo "Testing 'PersonalChatHistoryResponse'"
printf 'type: personalChatHistoryResponse\nid: NLevlRCe\nchat: T4oEAbGr\ncode: 42\nfriendId: WbsCCA7m' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 70 'PersonalChatHistoryResponse' test.out

#- 71 PersonalChatNotif
# echo "Testing 'PersonalChatNotif'"
printf 'type: personalChatNotif\nid: snwKLj1k\nfrom: 5hTSYvwg\npayload: Gm1AbM5k\nreceivedAt: 66\nto: ASoUDxQL' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 71 'PersonalChatNotif' test.out

#- 72 PersonalChatRequest
# echo "Testing 'PersonalChatRequest'"
printf 'type: personalChatRequest\nid: tb3Ep1EA\nfrom: ADPdRaau\npayload: LZrXgB3k\nreceivedAt: 76\nto: xieD4Gea' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 72 'PersonalChatRequest' test.out

#- 73 PersonalChatResponse
# echo "Testing 'PersonalChatResponse'"
printf 'type: personalChatResponse\nid: jK4S1kdv\ncode: 81' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 73 'PersonalChatResponse' test.out

#- 74 RefreshTokenRequest
# echo "Testing 'RefreshTokenRequest'"
printf 'type: refreshTokenRequest\nid: bQb0KBni\ntoken: 5DU9CKww' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 74 'RefreshTokenRequest' test.out

#- 75 RefreshTokenResponse
# echo "Testing 'RefreshTokenResponse'"
printf 'type: refreshTokenResponse\nid: uEDSQG7z\ncode: 32' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 75 'RefreshTokenResponse' test.out

#- 76 RejectFriendsNotif
# echo "Testing 'RejectFriendsNotif'"
printf 'type: rejectFriendsNotif\nuserId: QikXilQE' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 76 'RejectFriendsNotif' test.out

#- 77 RejectFriendsRequest
# echo "Testing 'RejectFriendsRequest'"
printf 'type: rejectFriendsRequest\nid: MBfkV5Xf\nfriendId: LRsD6N0h' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 77 'RejectFriendsRequest' test.out

#- 78 RejectFriendsResponse
# echo "Testing 'RejectFriendsResponse'"
printf 'type: rejectFriendsResponse\nid: LYPxRFW8\ncode: 1' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 78 'RejectFriendsResponse' test.out

#- 79 RematchmakingNotif
# echo "Testing 'RematchmakingNotif'"
printf 'type: rematchmakingNotif\nbanDuration: 7' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 79 'RematchmakingNotif' test.out

#- 80 RequestFriendsNotif
# echo "Testing 'RequestFriendsNotif'"
printf 'type: requestFriendsNotif\nfriendId: kOASNpYN' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 80 'RequestFriendsNotif' test.out

#- 81 RequestFriendsRequest
# echo "Testing 'RequestFriendsRequest'"
printf 'type: requestFriendsRequest\nid: KT9Wt9cl\nfriendId: FL1qGhVt' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 81 'RequestFriendsRequest' test.out

#- 82 RequestFriendsResponse
# echo "Testing 'RequestFriendsResponse'"
printf 'type: requestFriendsResponse\nid: GIjesNf6\ncode: 2' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 82 'RequestFriendsResponse' test.out

#- 83 SendChannelChatRequest
# echo "Testing 'SendChannelChatRequest'"
printf 'type: sendChannelChatRequest\nid: UcmWSdyh\nchannelSlug: UbjV67Oe\npayload: qxAMcO3w' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 83 'SendChannelChatRequest' test.out

#- 84 SendChannelChatResponse
# echo "Testing 'SendChannelChatResponse'"
printf 'type: sendChannelChatResponse\nid: vKE7hzc0\ncode: 100' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 84 'SendChannelChatResponse' test.out

#- 85 SetReadyConsentNotif
# echo "Testing 'SetReadyConsentNotif'"
printf 'type: setReadyConsentNotif\nmatchId: NHgsD8iE\nuserId: oGDLa7gG' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 85 'SetReadyConsentNotif' test.out

#- 86 SetReadyConsentRequest
# echo "Testing 'SetReadyConsentRequest'"
printf 'type: setReadyConsentRequest\nid: ZStGq3ys\nmatchId: hJq0Ebbm' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 86 'SetReadyConsentRequest' test.out

#- 87 SetReadyConsentResponse
# echo "Testing 'SetReadyConsentResponse'"
printf 'type: setReadyConsentResponse\nid: jGpiWEvO\ncode: 86' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 87 'SetReadyConsentResponse' test.out

#- 88 SetSessionAttributeRequest
# echo "Testing 'SetSessionAttributeRequest'"
printf 'type: setSessionAttributeRequest\nid: Ni3OozRh\nkey: KPo7VOxd\nnamespace: lhDp0oDA\nvalue: ZZjVF3Nv' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 88 'SetSessionAttributeRequest' test.out

#- 89 SetSessionAttributeResponse
# echo "Testing 'SetSessionAttributeResponse'"
printf 'type: setSessionAttributeResponse\nid: HeeU8QGA\ncode: 91' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 89 'SetSessionAttributeResponse' test.out

#- 90 SetUserStatusRequest
# echo "Testing 'SetUserStatusRequest'"
printf 'type: setUserStatusRequest\nid: zcpdgSqL\nactivity: sMAH48QK\navailability: 88' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 90 'SetUserStatusRequest' test.out

#- 91 SetUserStatusResponse
# echo "Testing 'SetUserStatusResponse'"
printf 'type: setUserStatusResponse\nid: B8wps3ve\ncode: 59' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 91 'SetUserStatusResponse' test.out

#- 92 ShutdownNotif
# echo "Testing 'ShutdownNotif'"
printf 'type: shutdownNotif\nmessage: VhLz62Wa' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 92 'ShutdownNotif' test.out

#- 93 SignalingP2PNotif
# echo "Testing 'SignalingP2PNotif'"
printf 'type: signalingP2PNotif\ndestinationId: iPMb0tUy\nmessage: fve3NR5H' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 93 'SignalingP2PNotif' test.out

#- 94 StartMatchmakingRequest
# echo "Testing 'StartMatchmakingRequest'"
printf 'type: startMatchmakingRequest\nid: nkB9KAwP\nextraAttributes: dfsvD1Z8\ngameMode: nnTqUhsa\npartyAttributes: {"QtI7vxOY":{},"5A4ZHMvy":{},"hsExvnnZ":{}}\npriority: 32\ntempParty: lQm4WKm3' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 94 'StartMatchmakingRequest' test.out

#- 95 StartMatchmakingResponse
# echo "Testing 'StartMatchmakingResponse'"
printf 'type: startMatchmakingResponse\nid: XAJkueMt\ncode: 52' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 95 'StartMatchmakingResponse' test.out

#- 96 UnblockPlayerNotif
# echo "Testing 'UnblockPlayerNotif'"
printf 'type: unblockPlayerNotif\nunblockedUserId: JBJ8zbRX\nuserId: V910CmXt' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 96 'UnblockPlayerNotif' test.out

#- 97 UnblockPlayerRequest
# echo "Testing 'UnblockPlayerRequest'"
printf 'type: unblockPlayerRequest\nid: 5V7BE8Sq\nnamespace: VW8uVn6C\nunblockedUserId: 7NdAxzuv' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 97 'UnblockPlayerRequest' test.out

#- 98 UnblockPlayerResponse
# echo "Testing 'UnblockPlayerResponse'"
printf 'type: unblockPlayerResponse\nid: 9r69QbJY\ncode: 79\nnamespace: yvfCzqFj\nunblockedUserId: MUEgOjjY' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 98 'UnblockPlayerResponse' test.out

#- 99 UnfriendNotif
# echo "Testing 'UnfriendNotif'"
printf 'type: unfriendNotif\nfriendId: WckwYIzx' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 99 'UnfriendNotif' test.out

#- 100 UnfriendRequest
# echo "Testing 'UnfriendRequest'"
printf 'type: unfriendRequest\nid: kLA5fYo0\nfriendId: FBBvvL9w' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 100 'UnfriendRequest' test.out

#- 101 UnfriendResponse
# echo "Testing 'UnfriendResponse'"
printf 'type: unfriendResponse\nid: OJAHQJq4\ncode: 24' > $TEMP_FILE_UPLOAD
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
printf 'type: userMetricRequest\nid: 0OwoZtwd' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 103 'UserMetricRequest' test.out

#- 104 UserMetricResponse
# echo "Testing 'UserMetricResponse'"
printf 'type: userMetricResponse\nid: kRGr8zns\ncode: 15\nplayerCount: 56' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 104 'UserMetricResponse' test.out

#- 105 UserStatusNotif
# echo "Testing 'UserStatusNotif'"
printf 'type: userStatusNotif\nactivity: rx6Gpdi0\navailability: 7\nlastSeenAt: VqHmvHGA\nuserId: t8eFkAb3' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --ws \
    --sn $SERVICE_NAME \
    --retry-on-ws-message-error \
    --ws-payload-file $TEMP_FILE_UPLOAD \
    > test.out 2>&1
eval_tap $? 105 'UserStatusNotif' test.out


exit $EXIT_CODE