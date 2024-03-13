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
echo "1..39"

#- 1 Login
$CLI_EXE --op login --lt user --user user --pass user > test.out 2>&1
eval_tap $? 1 'Login' test.out

if [ $EXIT_CODE -ne 0 ]; then
  echo "Bail out! Login failed."
  exit $EXIT_CODE
fi

# echo "foo" > "$CLI_TOKEN_FILE"

#- 2 GetHealthcheckInfo
$CLI_EXE \
    --sn matchmaking \
    --op GetHealthcheckInfo \
    > test.out 2>&1
eval_tap $? 2 'GetHealthcheckInfo' test.out

#- 3 HandlerV3Healthz
$CLI_EXE \
    --sn matchmaking \
    --op HandlerV3Healthz \
    > test.out 2>&1
eval_tap $? 3 'HandlerV3Healthz' test.out

#- 4 GetAllChannelsHandler
$CLI_EXE \
    --sn matchmaking \
    --op GetAllChannelsHandler \
    --namespace $AB_NAMESPACE \
    --limit '28' \
    --offset '80' \
    > test.out 2>&1
eval_tap $? 4 'GetAllChannelsHandler' test.out

#- 5 CreateChannelHandler
# body param: body
echo '{"blocked_player_option": "blockedPlayerCannotMatch", "deployment": "bEfbHwxM", "description": "b0rSBToO", "find_match_timeout_seconds": 0, "game_mode": "xmFAWn7o", "joinable": false, "max_delay_ms": 66, "region_expansion_range_ms": 92, "region_expansion_rate_ms": 84, "region_latency_initial_range_ms": 22, "region_latency_max_ms": 93, "rule_set": {"alliance": {"combination": {"alliances": [[{"max": 22, "min": 77, "name": "Ysm49FfI"}, {"max": 48, "min": 44, "name": "9FLToUKe"}, {"max": 60, "min": 81, "name": "mDGOcWZN"}], [{"max": 62, "min": 9, "name": "stiPMobC"}, {"max": 96, "min": 44, "name": "a8gqY0EG"}, {"max": 85, "min": 87, "name": "jYyfRMT1"}], [{"max": 19, "min": 80, "name": "oN9bx2B7"}, {"max": 17, "min": 92, "name": "bAGM2ezt"}, {"max": 35, "min": 89, "name": "9AkEWMVx"}]], "has_combination": true, "role_flexing_enable": true, "role_flexing_player": 37, "role_flexing_second": 20}, "max_number": 56, "min_number": 67, "player_max_number": 90, "player_min_number": 23}, "alliance_flexing_rule": [{"combination": {"alliances": [[{"max": 79, "min": 80, "name": "90ZIKtQb"}, {"max": 37, "min": 96, "name": "5vPkV1na"}, {"max": 73, "min": 58, "name": "d3Vef7Do"}], [{"max": 65, "min": 75, "name": "IXBieLuL"}, {"max": 12, "min": 46, "name": "q46DgLBu"}, {"max": 34, "min": 32, "name": "V0yX1tCI"}], [{"max": 37, "min": 40, "name": "qY7Z0BXu"}, {"max": 68, "min": 57, "name": "bUDEQD82"}, {"max": 96, "min": 70, "name": "o1NtGMDJ"}]], "has_combination": true, "role_flexing_enable": true, "role_flexing_player": 19, "role_flexing_second": 60}, "duration": 18, "max_number": 16, "min_number": 86, "player_max_number": 84, "player_min_number": 30}, {"combination": {"alliances": [[{"max": 67, "min": 76, "name": "JdMPh9Tc"}, {"max": 13, "min": 68, "name": "xytd7n65"}, {"max": 100, "min": 19, "name": "MYyoWjNA"}], [{"max": 7, "min": 61, "name": "3wBIWR5r"}, {"max": 85, "min": 33, "name": "wbPCUDZ9"}, {"max": 51, "min": 88, "name": "nwrhfhdN"}], [{"max": 49, "min": 62, "name": "h1sTs0cB"}, {"max": 91, "min": 87, "name": "rUzQOmwz"}, {"max": 61, "min": 59, "name": "reYpEjJf"}]], "has_combination": false, "role_flexing_enable": true, "role_flexing_player": 45, "role_flexing_second": 45}, "duration": 17, "max_number": 46, "min_number": 35, "player_max_number": 81, "player_min_number": 98}, {"combination": {"alliances": [[{"max": 14, "min": 85, "name": "s6HMZS3Y"}, {"max": 32, "min": 75, "name": "PE1q5evS"}, {"max": 57, "min": 37, "name": "wNoomM95"}], [{"max": 25, "min": 52, "name": "5q2N63b8"}, {"max": 66, "min": 50, "name": "5QFiJh0i"}, {"max": 41, "min": 54, "name": "oOPx6p1v"}], [{"max": 96, "min": 53, "name": "p4W12TKH"}, {"max": 100, "min": 27, "name": "8JMAqlBp"}, {"max": 52, "min": 77, "name": "FKnpJGeu"}]], "has_combination": true, "role_flexing_enable": false, "role_flexing_player": 3, "role_flexing_second": 10}, "duration": 2, "max_number": 56, "min_number": 88, "player_max_number": 67, "player_min_number": 49}], "batch_size": 56, "bucket_mmr_rule": {"disable_authority": false, "flex_authority_count": 38, "flex_flat_step_range": 79, "flex_immunity_count": 1, "flex_range_max": 49, "flex_rate_ms": 4, "flex_step_max": 68, "force_authority_match": true, "initial_step_range": 62, "mmr_max": 65, "mmr_mean": 43, "mmr_min": 46, "mmr_std_dev": 27, "override_mmr_data": false, "use_bucket_mmr": false, "use_flat_flex_step": true}, "flexing_rule": [{"attribute": "Ig13eslN", "criteria": "E9e3VwAL", "duration": 58, "reference": 0.7463599522054545}, {"attribute": "u7fIL9V2", "criteria": "gl9HwtGt", "duration": 11, "reference": 0.23046023660384818}, {"attribute": "a9SEgMFK", "criteria": "FBqfMe5Z", "duration": 99, "reference": 0.7335502817963383}], "match_options": {"options": [{"name": "7n952G7w", "type": "h5LxWK7r"}, {"name": "KvkumplK", "type": "fqX5kDXI"}, {"name": "nr31DcWi", "type": "KA7PsI2A"}]}, "matching_rule": [{"attribute": "dF2N1W8i", "criteria": "7dte6LoA", "reference": 0.4655930698861329}, {"attribute": "ZihOg51e", "criteria": "EUvZndRf", "reference": 0.2214456364752424}, {"attribute": "ITkb5827", "criteria": "NOUuuKs5", "reference": 0.7099686563151401}], "rebalance_enable": false, "sort_ticket": {"search_result": "none", "ticket_queue": "oldestTicketAge"}, "sort_tickets": [{"search_result": "none", "threshold": 95, "ticket_queue": "oldestTicketAge"}, {"search_result": "distance", "threshold": 96, "ticket_queue": "oldestTicketAge"}, {"search_result": "random", "threshold": 43, "ticket_queue": "random"}], "sub_game_modes": {"gZWswzuG": {"alliance": {"combination": {"alliances": [[{"max": 68, "min": 2, "name": "Jf0piKgR"}, {"max": 76, "min": 71, "name": "ov9WiguO"}, {"max": 45, "min": 27, "name": "ksUsdNgG"}], [{"max": 12, "min": 10, "name": "0hkkx8mi"}, {"max": 71, "min": 55, "name": "33JLZ7Yo"}, {"max": 64, "min": 25, "name": "hVS3cMgT"}], [{"max": 78, "min": 12, "name": "hTcmO8Eo"}, {"max": 67, "min": 29, "name": "kJuwRFTr"}, {"max": 72, "min": 75, "name": "cM5m07FG"}]], "has_combination": true, "role_flexing_enable": false, "role_flexing_player": 61, "role_flexing_second": 57}, "max_number": 53, "min_number": 8, "player_max_number": 36, "player_min_number": 73}, "alliance_flexing_rule": [{"combination": {"alliances": [[{"max": 43, "min": 21, "name": "R4J7dZb8"}, {"max": 20, "min": 64, "name": "XTNcIoJZ"}, {"max": 37, "min": 90, "name": "BvThhwA5"}], [{"max": 51, "min": 47, "name": "8lnEpRjx"}, {"max": 25, "min": 46, "name": "83UFJwD2"}, {"max": 30, "min": 38, "name": "YbLTU2YX"}], [{"max": 85, "min": 7, "name": "KroPiJLF"}, {"max": 22, "min": 6, "name": "k64Agrjc"}, {"max": 46, "min": 5, "name": "nw2YNWpU"}]], "has_combination": false, "role_flexing_enable": true, "role_flexing_player": 22, "role_flexing_second": 41}, "duration": 5, "max_number": 12, "min_number": 46, "player_max_number": 28, "player_min_number": 83}, {"combination": {"alliances": [[{"max": 18, "min": 32, "name": "6ZwX985M"}, {"max": 43, "min": 41, "name": "bbnvlVwv"}, {"max": 85, "min": 94, "name": "zmz0734N"}], [{"max": 86, "min": 4, "name": "ixpToJdy"}, {"max": 87, "min": 50, "name": "KHysbCmD"}, {"max": 60, "min": 84, "name": "u8QfIDhy"}], [{"max": 39, "min": 82, "name": "TElbAtH0"}, {"max": 88, "min": 79, "name": "MWX7HRks"}, {"max": 72, "min": 48, "name": "2NMdK3NC"}]], "has_combination": false, "role_flexing_enable": true, "role_flexing_player": 54, "role_flexing_second": 68}, "duration": 68, "max_number": 84, "min_number": 16, "player_max_number": 53, "player_min_number": 65}, {"combination": {"alliances": [[{"max": 15, "min": 24, "name": "VX8YebAP"}, {"max": 90, "min": 55, "name": "Fmaff4Zy"}, {"max": 9, "min": 1, "name": "zYV26x1O"}], [{"max": 68, "min": 58, "name": "y9LNcCJw"}, {"max": 13, "min": 50, "name": "p1LgXOFC"}, {"max": 46, "min": 89, "name": "aNCWfcpH"}], [{"max": 82, "min": 59, "name": "9JQlsOgs"}, {"max": 3, "min": 90, "name": "uNcuOUTt"}, {"max": 31, "min": 73, "name": "fuJskpNM"}]], "has_combination": true, "role_flexing_enable": true, "role_flexing_player": 27, "role_flexing_second": 36}, "duration": 91, "max_number": 27, "min_number": 54, "player_max_number": 42, "player_min_number": 38}], "name": "xTBcOQyq"}, "tN9yKD9P": {"alliance": {"combination": {"alliances": [[{"max": 92, "min": 76, "name": "mb4u00pi"}, {"max": 5, "min": 20, "name": "wsgRNoa4"}, {"max": 16, "min": 88, "name": "2FfS0oFd"}], [{"max": 36, "min": 4, "name": "LjuVndHi"}, {"max": 57, "min": 2, "name": "AqKsAqGg"}, {"max": 11, "min": 17, "name": "MOnFWjH5"}], [{"max": 26, "min": 98, "name": "raLGg98g"}, {"max": 44, "min": 62, "name": "UMOjHYV7"}, {"max": 71, "min": 73, "name": "3jIi4gJX"}]], "has_combination": true, "role_flexing_enable": true, "role_flexing_player": 77, "role_flexing_second": 2}, "max_number": 19, "min_number": 20, "player_max_number": 30, "player_min_number": 1}, "alliance_flexing_rule": [{"combination": {"alliances": [[{"max": 25, "min": 48, "name": "ngVt4P67"}, {"max": 94, "min": 51, "name": "pzHJq0Bj"}, {"max": 2, "min": 99, "name": "sgWH5wFk"}], [{"max": 44, "min": 86, "name": "66WNP0Rt"}, {"max": 74, "min": 59, "name": "tpj9QK3q"}, {"max": 15, "min": 51, "name": "0y9oqjFH"}], [{"max": 3, "min": 96, "name": "mVr04BUp"}, {"max": 44, "min": 25, "name": "3NUtgkQW"}, {"max": 70, "min": 31, "name": "Wu8YaRFU"}]], "has_combination": true, "role_flexing_enable": true, "role_flexing_player": 53, "role_flexing_second": 7}, "duration": 44, "max_number": 79, "min_number": 81, "player_max_number": 13, "player_min_number": 68}, {"combination": {"alliances": [[{"max": 33, "min": 15, "name": "6tCvO8lW"}, {"max": 67, "min": 21, "name": "hdts7t5W"}, {"max": 89, "min": 1, "name": "PcgIQCys"}], [{"max": 90, "min": 91, "name": "wSZsmsPS"}, {"max": 49, "min": 86, "name": "YeL87Hki"}, {"max": 62, "min": 63, "name": "nMPRjWXE"}], [{"max": 41, "min": 69, "name": "tB42a5GU"}, {"max": 66, "min": 51, "name": "VJ9NJbGO"}, {"max": 71, "min": 53, "name": "4eXWCpVc"}]], "has_combination": true, "role_flexing_enable": false, "role_flexing_player": 58, "role_flexing_second": 30}, "duration": 72, "max_number": 84, "min_number": 63, "player_max_number": 13, "player_min_number": 84}, {"combination": {"alliances": [[{"max": 80, "min": 26, "name": "G3OmVTC9"}, {"max": 35, "min": 35, "name": "oSy7xvUa"}, {"max": 20, "min": 75, "name": "hjmr2qlf"}], [{"max": 58, "min": 63, "name": "UiarMfP5"}, {"max": 38, "min": 43, "name": "9t2cpkfO"}, {"max": 10, "min": 22, "name": "5rSjl2fQ"}], [{"max": 69, "min": 11, "name": "wyXeoIhj"}, {"max": 25, "min": 55, "name": "ZEcUapKb"}, {"max": 50, "min": 100, "name": "jGZ9HTmH"}]], "has_combination": false, "role_flexing_enable": false, "role_flexing_player": 58, "role_flexing_second": 75}, "duration": 65, "max_number": 84, "min_number": 83, "player_max_number": 47, "player_min_number": 34}], "name": "RGSw64di"}, "QuUh1boU": {"alliance": {"combination": {"alliances": [[{"max": 28, "min": 64, "name": "Cqey2udw"}, {"max": 9, "min": 9, "name": "2MjkD5U6"}, {"max": 29, "min": 75, "name": "D3qp8FaW"}], [{"max": 74, "min": 54, "name": "EdZADkMz"}, {"max": 77, "min": 23, "name": "qxZdgRlb"}, {"max": 1, "min": 95, "name": "abahJrT3"}], [{"max": 64, "min": 43, "name": "cfR9fu9A"}, {"max": 76, "min": 50, "name": "ivDt2Zjt"}, {"max": 10, "min": 36, "name": "xOX5tiVK"}]], "has_combination": false, "role_flexing_enable": true, "role_flexing_player": 67, "role_flexing_second": 28}, "max_number": 41, "min_number": 21, "player_max_number": 76, "player_min_number": 2}, "alliance_flexing_rule": [{"combination": {"alliances": [[{"max": 51, "min": 72, "name": "QAD1W4lt"}, {"max": 100, "min": 74, "name": "FYXe1P0X"}, {"max": 77, "min": 44, "name": "zbpIb20f"}], [{"max": 59, "min": 4, "name": "1pLh7MRg"}, {"max": 65, "min": 53, "name": "PBnxdITx"}, {"max": 78, "min": 7, "name": "J5slTRzz"}], [{"max": 93, "min": 19, "name": "887K6ZdC"}, {"max": 13, "min": 18, "name": "zxq9PJiM"}, {"max": 57, "min": 31, "name": "xPkCf76q"}]], "has_combination": false, "role_flexing_enable": true, "role_flexing_player": 21, "role_flexing_second": 24}, "duration": 68, "max_number": 24, "min_number": 72, "player_max_number": 6, "player_min_number": 25}, {"combination": {"alliances": [[{"max": 25, "min": 53, "name": "lT0NsvWV"}, {"max": 20, "min": 0, "name": "WWOfzt5H"}, {"max": 71, "min": 82, "name": "rLbF0V05"}], [{"max": 39, "min": 13, "name": "MxR6O32D"}, {"max": 12, "min": 11, "name": "0MStxcV9"}, {"max": 70, "min": 18, "name": "0apMVp2i"}], [{"max": 70, "min": 14, "name": "6I69CS0R"}, {"max": 54, "min": 48, "name": "fBxRrzqI"}, {"max": 92, "min": 36, "name": "33V4Bsy5"}]], "has_combination": true, "role_flexing_enable": false, "role_flexing_player": 82, "role_flexing_second": 57}, "duration": 11, "max_number": 71, "min_number": 81, "player_max_number": 92, "player_min_number": 18}, {"combination": {"alliances": [[{"max": 46, "min": 76, "name": "s9zzIsX5"}, {"max": 9, "min": 43, "name": "yIUIX0Px"}, {"max": 21, "min": 81, "name": "AYqofpzt"}], [{"max": 89, "min": 93, "name": "Hw8Bts6r"}, {"max": 34, "min": 78, "name": "1sEFMtD3"}, {"max": 84, "min": 70, "name": "am0bXi3W"}], [{"max": 72, "min": 49, "name": "itFX0Wv5"}, {"max": 1, "min": 78, "name": "C82uAp2F"}, {"max": 94, "min": 81, "name": "FlGB6Nb9"}]], "has_combination": false, "role_flexing_enable": false, "role_flexing_player": 35, "role_flexing_second": 42}, "duration": 67, "max_number": 17, "min_number": 24, "player_max_number": 33, "player_min_number": 59}], "name": "NPdy8Qb8"}}, "ticket_flexing_selection": "random", "ticket_flexing_selections": [{"selection": "oldest", "threshold": 73}, {"selection": "newest", "threshold": 100}, {"selection": "oldest", "threshold": 93}], "use_newest_ticket_for_flexing": true}, "session_queue_timeout_seconds": 77, "social_matchmaking": true, "sub_gamemode_selection": "random", "ticket_observability_enable": false, "use_sub_gamemode": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op CreateChannelHandler \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 5 'CreateChannelHandler' test.out

#- 6 GetMatchPoolMetric
$CLI_EXE \
    --sn matchmaking \
    --op GetMatchPoolMetric \
    --channelName 'zdU8vhJv' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 6 'GetMatchPoolMetric' test.out

#- 7 DeleteChannelHandler
$CLI_EXE \
    --sn matchmaking \
    --op DeleteChannelHandler \
    --channel '9sQYYKxa' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 7 'DeleteChannelHandler' test.out

#- 8 StoreMatchResults
# body param: body
echo '{"match_id": "oE6vaiGs", "players": [{"results": [{"attribute": "4SpNYxyV", "value": 0.9464983628780648}, {"attribute": "4sLNBG7n", "value": 0.854785577301641}, {"attribute": "tABWo9ay", "value": 0.1326703721394853}], "user_id": "73TvUgEa"}, {"results": [{"attribute": "vCCAjThz", "value": 0.05523225186886127}, {"attribute": "jfVKisrl", "value": 0.377291270484728}, {"attribute": "WDLuBx3q", "value": 0.3955180613481277}], "user_id": "kDoMPJhX"}, {"results": [{"attribute": "rNEFP0Vi", "value": 0.05512122245356388}, {"attribute": "C9ivq4Wp", "value": 0.128074302357589}, {"attribute": "Wpl6WQyj", "value": 0.8552808694469332}], "user_id": "sGd31PWy"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op StoreMatchResults \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 8 'StoreMatchResults' test.out

#- 9 Rebalance
# body param: body
echo '{"match_id": "sOsUkFBZ"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op Rebalance \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 9 'Rebalance' test.out

#- 10 QueueSessionHandler
# body param: body
echo '{"channel": "Gq1JHTxH", "client_version": "OfxSkaTk", "deployment": "C3fi1xwa", "error_code": 90, "error_message": "sIsaTcUh", "game_mode": "3H1TCh6D", "is_mock": "jMxKHDVm", "joinable": true, "match_id": "gcpTf62X", "matching_allies": [{"matching_parties": [{"first_ticket_created_at": 57, "party_attributes": {"eqaThtkz": {}, "lBMbPNUd": {}, "sXqVgU6A": {}}, "party_id": "A2BTi1FL", "party_members": [{"extra_attributes": {"YCkWVKBc": {}, "zqZb0hwy": {}, "MDprFKfy": {}}, "user_id": "M7WfOPYJ"}, {"extra_attributes": {"YZf2Gphn": {}, "1w0Wgjfy": {}, "vFoxJSev": {}}, "user_id": "pILnAYzM"}, {"extra_attributes": {"T3fTJSTw": {}, "TBqbyppW": {}, "dqZ5Qtjr": {}}, "user_id": "QeGTjRxe"}], "ticket_created_at": 16, "ticket_id": "LIv628ZA"}, {"first_ticket_created_at": 17, "party_attributes": {"t7eCJsC6": {}, "UCbb41BP": {}, "gJH3bb4K": {}}, "party_id": "pVJMmi3F", "party_members": [{"extra_attributes": {"M988NyBo": {}, "QU0J18yF": {}, "5NyuSuvc": {}}, "user_id": "Qcf02wJw"}, {"extra_attributes": {"Pfxi9R9W": {}, "N0e6ia0a": {}, "xAvJlKuP": {}}, "user_id": "IpKJZzeo"}, {"extra_attributes": {"Ey3j9bo3": {}, "nUigg7N0": {}, "jiDZNxrb": {}}, "user_id": "4nVlzMy6"}], "ticket_created_at": 95, "ticket_id": "ys69nWN0"}, {"first_ticket_created_at": 98, "party_attributes": {"kEykIBl5": {}, "fAbrXwiV": {}, "Hjj7jomH": {}}, "party_id": "fBv3dm4s", "party_members": [{"extra_attributes": {"AdMsFoKW": {}, "QKMWWCrt": {}, "4OCx24W1": {}}, "user_id": "XT25qAKc"}, {"extra_attributes": {"7mg7gT7D": {}, "zx9k29ru": {}, "j6E5pCvY": {}}, "user_id": "i6Tc8D9R"}, {"extra_attributes": {"bqZ1500D": {}, "vYYPbJXY": {}, "nZwvGi1c": {}}, "user_id": "w3F6vLmQ"}], "ticket_created_at": 35, "ticket_id": "JmXdMZ3E"}]}, {"matching_parties": [{"first_ticket_created_at": 61, "party_attributes": {"eEFS4Z2w": {}, "8lTyvxJJ": {}, "qtKc8Ty4": {}}, "party_id": "phNbCvWs", "party_members": [{"extra_attributes": {"anxviB9v": {}, "Jl6cmRdg": {}, "EBuTYXZ6": {}}, "user_id": "69AnsG8G"}, {"extra_attributes": {"uSnISlDC": {}, "3XNUO5LQ": {}, "Lok66tvi": {}}, "user_id": "JwZW4cN4"}, {"extra_attributes": {"7bWbYImN": {}, "IgWfw4WR": {}, "HbQBrOez": {}}, "user_id": "96TRnYcW"}], "ticket_created_at": 44, "ticket_id": "cKU7JHjS"}, {"first_ticket_created_at": 80, "party_attributes": {"juDK5yNF": {}, "faLH3mfr": {}, "eI7AHFu1": {}}, "party_id": "VdfWbCA0", "party_members": [{"extra_attributes": {"1P3MFFyi": {}, "Ae0MxQJM": {}, "0THL3AUx": {}}, "user_id": "4o6WFIQU"}, {"extra_attributes": {"1PcYSUQJ": {}, "43o0vT3p": {}, "vrsYg1CC": {}}, "user_id": "zjlcoSBB"}, {"extra_attributes": {"L5M0Wlda": {}, "SIP8pFYY": {}, "raTQ75d1": {}}, "user_id": "H7AfEnhN"}], "ticket_created_at": 11, "ticket_id": "84hmN1ph"}, {"first_ticket_created_at": 14, "party_attributes": {"w0pRHf4H": {}, "1RSZlkpC": {}, "uAEVKMVi": {}}, "party_id": "21mDXQis", "party_members": [{"extra_attributes": {"cHIEHfdX": {}, "rkJ6SRvp": {}, "ZuVUxBgW": {}}, "user_id": "hCmrEKPC"}, {"extra_attributes": {"97I6rKhZ": {}, "xAyhOnvh": {}, "Sz0CmhnE": {}}, "user_id": "vcuxRNZY"}, {"extra_attributes": {"DrKL4dSH": {}, "IKOIKrTt": {}, "jwTltVbY": {}}, "user_id": "5PBO19AK"}], "ticket_created_at": 80, "ticket_id": "oW2DYspm"}]}, {"matching_parties": [{"first_ticket_created_at": 33, "party_attributes": {"c5iQOtqm": {}, "yS2gx6PY": {}, "PJ1figNE": {}}, "party_id": "2dcxSSRS", "party_members": [{"extra_attributes": {"KuNjfYof": {}, "7q30kv4G": {}, "7i6osZmK": {}}, "user_id": "gdLq8C6r"}, {"extra_attributes": {"xtzaepmm": {}, "fFPUKNg5": {}, "bBbEd7VL": {}}, "user_id": "31gOoKcv"}, {"extra_attributes": {"7ntfcA6E": {}, "uRKt9NTi": {}, "m2fe8Udj": {}}, "user_id": "BQGGHgW6"}], "ticket_created_at": 92, "ticket_id": "4Q8wU4IF"}, {"first_ticket_created_at": 11, "party_attributes": {"gBrwrnF9": {}, "EQeBxvKJ": {}, "wdOtmI3v": {}}, "party_id": "KGjZfQaG", "party_members": [{"extra_attributes": {"1QM5jNkT": {}, "DQ9rTY5k": {}, "M8RiWcjj": {}}, "user_id": "3zR8t4T0"}, {"extra_attributes": {"kZ3KMGzo": {}, "R0oUDDUd": {}, "eA4ZVaZd": {}}, "user_id": "Jf4ex1zt"}, {"extra_attributes": {"CiYlfRTX": {}, "auDHBCc2": {}, "6hDwXy2t": {}}, "user_id": "ijpIDZxX"}], "ticket_created_at": 98, "ticket_id": "ab8z7R0D"}, {"first_ticket_created_at": 39, "party_attributes": {"RYSNkkjj": {}, "d62fANoT": {}, "O8eYlyWQ": {}}, "party_id": "QqVlL594", "party_members": [{"extra_attributes": {"SuDK8VXO": {}, "zdhSagF8": {}, "kCLZrSPx": {}}, "user_id": "ieipLZzW"}, {"extra_attributes": {"7liCQTCG": {}, "HYGa3k4n": {}, "bvx1iXNJ": {}}, "user_id": "g66Rs3b2"}, {"extra_attributes": {"OpLEtEfw": {}, "OM3wFqNE": {}, "8PPYRdGC": {}}, "user_id": "bEzQsOKO"}], "ticket_created_at": 2, "ticket_id": "7eB9FMvu"}]}], "namespace": "hNsAJRQ6", "party_attributes": {"dokUfbQO": {}, "EC0evKul": {}, "CBCj2IcX": {}}, "party_id": "sAx8dfLB", "queued_at": 38, "region": "63i5g3Fq", "server_name": "DKayWKxP", "status": "pTfnp9yY", "ticket_id": "zgkwehW4", "ticket_ids": ["gxZjkx2p", "uDyO3fAo", "q8oum2Kw"], "updated_at": "1972-10-17T00:00:00Z"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op QueueSessionHandler \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 10 'QueueSessionHandler' test.out

#- 11 DequeueSessionHandler
# body param: body
echo '{"match_id": "G1qnWpZE"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op DequeueSessionHandler \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 11 'DequeueSessionHandler' test.out

#- 12 QuerySessionHandler
$CLI_EXE \
    --sn matchmaking \
    --op QuerySessionHandler \
    --matchID 'I5AuS6Kp' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 12 'QuerySessionHandler' test.out

#- 13 UpdatePlayTimeWeight
# body param: body
echo '{"playtime": 87, "userID": "OduP0SdO", "weight": 0.3845552840114128}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op UpdatePlayTimeWeight \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 13 'UpdatePlayTimeWeight' test.out

#- 14 GetAllPartyInAllChannel
$CLI_EXE \
    --sn matchmaking \
    --op GetAllPartyInAllChannel \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 14 'GetAllPartyInAllChannel' test.out

#- 15 BulkGetSessions
$CLI_EXE \
    --sn matchmaking \
    --op BulkGetSessions \
    --namespace $AB_NAMESPACE \
    --matchIDs 'Jnw2LSLw' \
    > test.out 2>&1
eval_tap $? 15 'BulkGetSessions' test.out

#- 16 ExportChannels
$CLI_EXE \
    --sn matchmaking \
    --op ExportChannels \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 16 'ExportChannels' test.out

#- 17 ImportChannels
# form data upload: file
echo 'tmp.dat' > $TEMP_FILE_UPLOAD
$CLI_EXE \
    --sn matchmaking \
    --op ImportChannels \
    --namespace $AB_NAMESPACE \
    --upload file $TEMP_FILE_UPLOAD \
    --strategy '3WkOllft' \
    > test.out 2>&1
eval_tap $? 17 'ImportChannels' test.out

#- 18 GetSingleMatchmakingChannel
$CLI_EXE \
    --sn matchmaking \
    --op GetSingleMatchmakingChannel \
    --channelName 'K42Z1ISI' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 18 'GetSingleMatchmakingChannel' test.out

#- 19 UpdateMatchmakingChannel
# body param: body
echo '{"blocked_player_option": "blockedPlayerCanMatch", "deployment": "JKhgDlQy", "description": "kFqdAJzw", "findMatchTimeoutSeconds": 42, "joinable": true, "max_delay_ms": 31, "region_expansion_range_ms": 10, "region_expansion_rate_ms": 89, "region_latency_initial_range_ms": 5, "region_latency_max_ms": 17, "ruleSet": {"alliance": {"combination": {"alliances": [[{"max": 15, "min": 14, "name": "oIwCQWJc"}, {"max": 14, "min": 16, "name": "TnEZTLRB"}, {"max": 31, "min": 25, "name": "vBFLNyVo"}], [{"max": 82, "min": 75, "name": "uL2PbPLR"}, {"max": 98, "min": 6, "name": "lJCVE46x"}, {"max": 11, "min": 58, "name": "ysbZU74L"}], [{"max": 25, "min": 70, "name": "3xwuvuh4"}, {"max": 60, "min": 30, "name": "eyaGi3HB"}, {"max": 27, "min": 57, "name": "ArLH9xUz"}]], "has_combination": false, "role_flexing_enable": true, "role_flexing_player": 4, "role_flexing_second": 100}, "maxNumber": 65, "minNumber": 62, "playerMaxNumber": 59, "playerMinNumber": 19}, "alliance_flexing_rule": [{"combination": {"alliances": [[{"max": 39, "min": 95, "name": "AaYRcsx2"}, {"max": 69, "min": 1, "name": "hMzEwj5m"}, {"max": 13, "min": 19, "name": "ABtoSW00"}], [{"max": 79, "min": 87, "name": "2bNklRnK"}, {"max": 33, "min": 41, "name": "63hlzHYs"}, {"max": 43, "min": 56, "name": "DScZHafb"}], [{"max": 42, "min": 47, "name": "E0OFYbU3"}, {"max": 27, "min": 37, "name": "HklEYdyv"}, {"max": 60, "min": 69, "name": "YtRdgvrM"}]], "has_combination": true, "role_flexing_enable": true, "role_flexing_player": 94, "role_flexing_second": 77}, "duration": 77, "max_number": 25, "min_number": 39, "player_max_number": 59, "player_min_number": 49}, {"combination": {"alliances": [[{"max": 81, "min": 32, "name": "lRkAS9L1"}, {"max": 13, "min": 92, "name": "7xSR8bYX"}, {"max": 30, "min": 28, "name": "4jQ6uBPq"}], [{"max": 70, "min": 41, "name": "C6jINR6G"}, {"max": 77, "min": 75, "name": "eccmTTYN"}, {"max": 82, "min": 13, "name": "MzHcCs7b"}], [{"max": 42, "min": 53, "name": "5SSLax6C"}, {"max": 10, "min": 14, "name": "sXn5d9Sb"}, {"max": 22, "min": 5, "name": "fKdcfC82"}]], "has_combination": false, "role_flexing_enable": false, "role_flexing_player": 97, "role_flexing_second": 31}, "duration": 33, "max_number": 65, "min_number": 85, "player_max_number": 55, "player_min_number": 57}, {"combination": {"alliances": [[{"max": 54, "min": 100, "name": "tX2RyKnr"}, {"max": 71, "min": 49, "name": "dqjryJOC"}, {"max": 1, "min": 93, "name": "41HoVgTY"}], [{"max": 4, "min": 31, "name": "xw7qyDac"}, {"max": 65, "min": 77, "name": "Npxkz7lG"}, {"max": 28, "min": 62, "name": "PYZMNSQd"}], [{"max": 35, "min": 9, "name": "YHPViSKC"}, {"max": 78, "min": 90, "name": "RRKKRTAi"}, {"max": 92, "min": 55, "name": "ZeROiMU5"}]], "has_combination": false, "role_flexing_enable": true, "role_flexing_player": 60, "role_flexing_second": 100}, "duration": 59, "max_number": 19, "min_number": 64, "player_max_number": 15, "player_min_number": 98}], "batch_size": 37, "bucket_mmr_rule": {"disable_authority": true, "flex_authority_count": 14, "flex_flat_step_range": 66, "flex_immunity_count": 0, "flex_range_max": 83, "flex_rate_ms": 45, "flex_step_max": 46, "force_authority_match": true, "initial_step_range": 54, "mmr_max": 3, "mmr_mean": 64, "mmr_min": 76, "mmr_std_dev": 20, "override_mmr_data": true, "use_bucket_mmr": false, "use_flat_flex_step": false}, "flexingRules": [{"attribute": "GOyxbVLv", "criteria": "sO5sWNhe", "duration": 79, "reference": 0.2053808176336671}, {"attribute": "tJSO5R58", "criteria": "0s26gHXy", "duration": 67, "reference": 0.6567485418367374}, {"attribute": "qWvxf9ve", "criteria": "eatGL3aW", "duration": 100, "reference": 0.5608433549989613}], "match_options": {"options": [{"name": "nNHxzBWH", "type": "vgycRl6b"}, {"name": "yzOPnplC", "type": "D91jZxwg"}, {"name": "HORyHGaT", "type": "DF7Y0f6o"}]}, "matchingRules": [{"attribute": "8zvdzSbq", "criteria": "TorWduut", "reference": 0.823168341986678}, {"attribute": "Cgr3i2qo", "criteria": "oXfEJmcc", "reference": 0.37874868135421125}, {"attribute": "otJnPmJJ", "criteria": "VPClS3MZ", "reference": 0.3047070369710726}], "sort_ticket": {"search_result": "oldestTicketAge", "ticket_queue": "random"}, "sort_tickets": [{"search_result": "distance", "threshold": 20, "ticket_queue": "oldestTicketAge"}, {"search_result": "random", "threshold": 44, "ticket_queue": "none"}, {"search_result": "oldestTicketAge", "threshold": 1, "ticket_queue": "random"}], "sub_game_modes": {}, "ticket_flexing_selection": "pivot", "ticket_flexing_selections": [{"selection": "pivot", "threshold": 85}, {"selection": "newest", "threshold": 66}, {"selection": "random", "threshold": 50}], "use_newest_ticket_for_flexing": true}, "sessionQueueTimeoutSeconds": 20, "socialMatchmaking": true, "sub_gamemode_selection": "ticketOrder", "ticket_observability_enable": true, "use_sub_gamemode": true}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op UpdateMatchmakingChannel \
    --channelName 'gpV0IymW' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 19 'UpdateMatchmakingChannel' test.out

#- 20 CleanAllMocks
$CLI_EXE \
    --sn matchmaking \
    --op CleanAllMocks \
    --channelName 'tV6NEBzC' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 20 'CleanAllMocks' test.out

#- 21 GetAllMockMatches
$CLI_EXE \
    --sn matchmaking \
    --op GetAllMockMatches \
    --channelName 'VA0QCR7R' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 21 'GetAllMockMatches' test.out

#- 22 GetMockMatchesByTimestamp
# body param: body
echo '{"timestamp_after": 74}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op GetMockMatchesByTimestamp \
    --channelName 'LWlUAzBo' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 22 'GetMockMatchesByTimestamp' test.out

#- 23 GetAllMockTickets
$CLI_EXE \
    --sn matchmaking \
    --op GetAllMockTickets \
    --channelName 'C2JrOvYt' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 23 'GetAllMockTickets' test.out

#- 24 CreateMockTickets
# body param: body
echo '{"attribute_name": "BL8n4Oo6", "count": 30, "mmrMax": 0.20119015669631712, "mmrMean": 0.5693322573471025, "mmrMin": 0.2816200761079678, "mmrStdDev": 0.010946716662214473}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op CreateMockTickets \
    --channelName '5aiAE91t' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 24 'CreateMockTickets' test.out

#- 25 BulkCreateMockTickets
# body param: body
echo '[{"first_ticket_created_at": 85, "party_attributes": {"h9dGMTI7": {}, "i5kZZnkX": {}, "51Bvbj1s": {}}, "party_id": "0HdVcdFz", "party_members": [{"extra_attributes": {"LvxLpHam": {}, "9kitjeVu": {}, "vrktjq0c": {}}, "user_id": "nlDirmTv"}, {"extra_attributes": {"88KD3QhV": {}, "ri7yyjDk": {}, "ORbnjxgp": {}}, "user_id": "rlusjEz4"}, {"extra_attributes": {"D5Jw6TAP": {}, "6YcOEkqQ": {}, "O8R3YeJB": {}}, "user_id": "vPossHyP"}], "ticket_created_at": 61, "ticket_id": "TTGvgnQo"}, {"first_ticket_created_at": 46, "party_attributes": {"ztP3gvVl": {}, "YoCu322W": {}, "b7MI1jp8": {}}, "party_id": "kvXYKdaY", "party_members": [{"extra_attributes": {"Jer8Xyso": {}, "KSt3iAhl": {}, "6oLTeLM8": {}}, "user_id": "vai7t2V7"}, {"extra_attributes": {"pgLVxdaE": {}, "uOmHWWf8": {}, "CRyikUid": {}}, "user_id": "vGDaWwOy"}, {"extra_attributes": {"QRJO7ZLa": {}, "lEJwQ2Rs": {}, "lSSXRYfO": {}}, "user_id": "QgQVteJY"}], "ticket_created_at": 0, "ticket_id": "hyehkiWj"}, {"first_ticket_created_at": 79, "party_attributes": {"6QJdXuoD": {}, "PzT2YRan": {}, "wpL3BRlG": {}}, "party_id": "xAwGytEX", "party_members": [{"extra_attributes": {"i5Pmb9sW": {}, "v2UlerH1": {}, "knoyBEOL": {}}, "user_id": "mKNvRZ6Y"}, {"extra_attributes": {"LAizoI8y": {}, "ofQwIiMj": {}, "PCfKWKV2": {}}, "user_id": "iBCsbv4X"}, {"extra_attributes": {"xOPnJZ3z": {}, "DSyADkgr": {}, "WFP4vsd8": {}}, "user_id": "l28clcwx"}], "ticket_created_at": 67, "ticket_id": "NFZ1JWmP"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op BulkCreateMockTickets \
    --channelName 'EjyTnHe7' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 25 'BulkCreateMockTickets' test.out

#- 26 GetMockTicketsByTimestamp
# body param: body
echo '{"timestamp_after": 13}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op GetMockTicketsByTimestamp \
    --channelName 'IjZzyF4z' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 26 'GetMockTicketsByTimestamp' test.out

#- 27 GetAllPartyInChannel
$CLI_EXE \
    --sn matchmaking \
    --op GetAllPartyInChannel \
    --channelName 'gOmFNzk8' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 27 'GetAllPartyInChannel' test.out

#- 28 GetAllSessionsInChannel
$CLI_EXE \
    --sn matchmaking \
    --op GetAllSessionsInChannel \
    --channelName 'GTVMLbNe' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 28 'GetAllSessionsInChannel' test.out

#- 29 AddUserIntoSessionInChannel
# body param: body
echo '{"blocked_players": ["wqZsgnnd", "51Xl4OEC", "y1OKAgMB"], "party_id": "lmErA1Sd", "user_id": "tDRKvqGC"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op AddUserIntoSessionInChannel \
    --channelName '6n8xgjLn' \
    --matchID '0l8YXXre' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 29 'AddUserIntoSessionInChannel' test.out

#- 30 DeleteSessionInChannel
$CLI_EXE \
    --sn matchmaking \
    --op DeleteSessionInChannel \
    --channelName 'adz4JZvq' \
    --matchID 'mf0MjURc' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 30 'DeleteSessionInChannel' test.out

#- 31 DeleteUserFromSessionInChannel
$CLI_EXE \
    --sn matchmaking \
    --op DeleteUserFromSessionInChannel \
    --channelName 'vHR7Rfbl' \
    --matchID 'uBscDbmq' \
    --namespace $AB_NAMESPACE \
    --userID 'cIDmq8fG' \
    > test.out 2>&1
eval_tap $? 31 'DeleteUserFromSessionInChannel' test.out

#- 32 GetStatData
$CLI_EXE \
    --sn matchmaking \
    --op GetStatData \
    --channelName 'a2aGQT54' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 32 'GetStatData' test.out

#- 33 SearchSessions
eval_tap 0 33 'SearchSessions # SKIP deprecated' test.out

#- 34 GetSessionHistoryDetailed
eval_tap 0 34 'GetSessionHistoryDetailed # SKIP deprecated' test.out

#- 35 PublicGetMessages
$CLI_EXE \
    --sn matchmaking \
    --op PublicGetMessages \
    > test.out 2>&1
eval_tap $? 35 'PublicGetMessages' test.out

#- 36 PublicGetAllMatchmakingChannel
$CLI_EXE \
    --sn matchmaking \
    --op PublicGetAllMatchmakingChannel \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 36 'PublicGetAllMatchmakingChannel' test.out

#- 37 PublicGetSingleMatchmakingChannel
$CLI_EXE \
    --sn matchmaking \
    --op PublicGetSingleMatchmakingChannel \
    --channelName 'sBPMXpy0' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 37 'PublicGetSingleMatchmakingChannel' test.out

#- 38 SearchSessionsV2
eval_tap 0 38 'SearchSessionsV2 # SKIP deprecated' test.out

#- 39 VersionCheckHandler
$CLI_EXE \
    --sn matchmaking \
    --op VersionCheckHandler \
    > test.out 2>&1
eval_tap $? 39 'VersionCheckHandler' test.out


# remove artifacts
rm -f "$CLI_TOKEN_FILE"
rm -f "$TEMP_JSON_INPUT"
rm -f "$TEMP_FILE_UPLOAD"

exit $EXIT_CODE