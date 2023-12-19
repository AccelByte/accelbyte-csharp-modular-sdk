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
    --limit '45' \
    --offset '70' \
    > test.out 2>&1
eval_tap $? 4 'GetAllChannelsHandler' test.out

#- 5 CreateChannelHandler
# body param: body
echo '{"deployment": "dgzELKpz", "description": "jLlwuXJ2", "find_match_timeout_seconds": 51, "game_mode": "fq9HOey7", "joinable": false, "max_delay_ms": 94, "region_expansion_range_ms": 27, "region_expansion_rate_ms": 81, "region_latency_initial_range_ms": 92, "region_latency_max_ms": 93, "rule_set": {"alliance": {"combination": {"alliances": [[{"max": 99, "min": 51, "name": "QhlWXtYR"}, {"max": 58, "min": 74, "name": "ZJNiPd6V"}, {"max": 96, "min": 60, "name": "Lhzw8XAd"}], [{"max": 52, "min": 0, "name": "EaEzSjat"}, {"max": 65, "min": 72, "name": "iL9hIRzB"}, {"max": 73, "min": 43, "name": "orXCErsO"}], [{"max": 94, "min": 45, "name": "cnHzjGru"}, {"max": 88, "min": 80, "name": "DLu8xukg"}, {"max": 66, "min": 3, "name": "XbyhBVT5"}]], "has_combination": true, "role_flexing_enable": true, "role_flexing_player": 76, "role_flexing_second": 81}, "max_number": 66, "min_number": 16, "player_max_number": 63, "player_min_number": 17}, "alliance_flexing_rule": [{"combination": {"alliances": [[{"max": 38, "min": 98, "name": "EfhJ0GwX"}, {"max": 83, "min": 55, "name": "CnGf4NcB"}, {"max": 39, "min": 73, "name": "44eNZXkp"}], [{"max": 2, "min": 24, "name": "QICD8aKv"}, {"max": 65, "min": 77, "name": "poiF7S7S"}, {"max": 57, "min": 78, "name": "oXivfI7s"}], [{"max": 50, "min": 85, "name": "xq30K7YF"}, {"max": 24, "min": 69, "name": "9RwtDPMd"}, {"max": 11, "min": 12, "name": "DNHv7oKz"}]], "has_combination": true, "role_flexing_enable": false, "role_flexing_player": 84, "role_flexing_second": 40}, "duration": 46, "max_number": 3, "min_number": 70, "player_max_number": 95, "player_min_number": 77}, {"combination": {"alliances": [[{"max": 52, "min": 13, "name": "lr1xFUHJ"}, {"max": 92, "min": 6, "name": "41GwcTds"}, {"max": 56, "min": 82, "name": "sKZACw6F"}], [{"max": 8, "min": 30, "name": "mPyKyg9O"}, {"max": 77, "min": 38, "name": "7gptrbD0"}, {"max": 63, "min": 86, "name": "rCwuhDRs"}], [{"max": 41, "min": 31, "name": "dsgrO5K0"}, {"max": 66, "min": 68, "name": "VwNjKfDq"}, {"max": 75, "min": 56, "name": "l9Qk4wuQ"}]], "has_combination": false, "role_flexing_enable": false, "role_flexing_player": 88, "role_flexing_second": 33}, "duration": 33, "max_number": 39, "min_number": 31, "player_max_number": 69, "player_min_number": 12}, {"combination": {"alliances": [[{"max": 10, "min": 13, "name": "32cbLwkh"}, {"max": 94, "min": 60, "name": "4fq587Up"}, {"max": 84, "min": 24, "name": "Kd7pMD19"}], [{"max": 100, "min": 53, "name": "F2Z8i2EY"}, {"max": 66, "min": 23, "name": "2Eke0eSt"}, {"max": 41, "min": 70, "name": "w7mEuuDQ"}], [{"max": 74, "min": 36, "name": "3TLqcGSW"}, {"max": 14, "min": 57, "name": "nb3vqy0C"}, {"max": 77, "min": 14, "name": "89g0mqhW"}]], "has_combination": true, "role_flexing_enable": true, "role_flexing_player": 83, "role_flexing_second": 10}, "duration": 84, "max_number": 47, "min_number": 45, "player_max_number": 45, "player_min_number": 53}], "batch_size": 26, "bucket_mmr_rule": {"disable_authority": false, "flex_authority_count": 8, "flex_flat_step_range": 93, "flex_immunity_count": 13, "flex_range_max": 15, "flex_rate_ms": 73, "flex_step_max": 3, "force_authority_match": false, "initial_step_range": 64, "mmr_max": 14, "mmr_mean": 8, "mmr_min": 51, "mmr_std_dev": 12, "override_mmr_data": true, "use_bucket_mmr": false, "use_flat_flex_step": false}, "flexing_rule": [{"attribute": "exSgZgTF", "criteria": "MJmlHOeS", "duration": 100, "reference": 0.825933704436876}, {"attribute": "SurGAdxe", "criteria": "wPUp6bjl", "duration": 18, "reference": 0.681636019536268}, {"attribute": "4mxtyIt5", "criteria": "Axuz3v5v", "duration": 2, "reference": 0.8619431018256944}], "match_options": {"options": [{"name": "U9fSAR2A", "type": "VEFOq4Jn"}, {"name": "6Cdv98mq", "type": "LnVBYjDL"}, {"name": "eLk490Sh", "type": "1ApAWVBy"}]}, "matching_rule": [{"attribute": "c5gCXbvF", "criteria": "iS2s5AOj", "reference": 0.2901815592761987}, {"attribute": "Hgp9M1Le", "criteria": "SDOTncO8", "reference": 0.631988717427313}, {"attribute": "g0RT3AAJ", "criteria": "QpN4x8Tr", "reference": 0.038445601348985114}], "rebalance_enable": true, "sort_ticket": {"search_result": "random", "ticket_queue": "none"}, "sort_tickets": [{"search_result": "largestPartySize", "threshold": 17, "ticket_queue": "distance"}, {"search_result": "random", "threshold": 88, "ticket_queue": "random"}, {"search_result": "distance", "threshold": 94, "ticket_queue": "distance"}], "sub_game_modes": {"KxjyxmEf": {"alliance": {"combination": {"alliances": [[{"max": 1, "min": 7, "name": "HWnCCG7w"}, {"max": 53, "min": 12, "name": "aVuAlKT2"}, {"max": 62, "min": 14, "name": "AeOjM7E4"}], [{"max": 48, "min": 77, "name": "aDEA8EIj"}, {"max": 36, "min": 81, "name": "q10XQSuD"}, {"max": 18, "min": 7, "name": "FsqQlrcY"}], [{"max": 99, "min": 36, "name": "8D1F0U9R"}, {"max": 96, "min": 67, "name": "lTOxfwqu"}, {"max": 49, "min": 24, "name": "mZJTJ7yl"}]], "has_combination": false, "role_flexing_enable": true, "role_flexing_player": 74, "role_flexing_second": 12}, "max_number": 82, "min_number": 94, "player_max_number": 89, "player_min_number": 45}, "alliance_flexing_rule": [{"combination": {"alliances": [[{"max": 99, "min": 77, "name": "MiaDVfWm"}, {"max": 25, "min": 86, "name": "HPgplGRN"}, {"max": 93, "min": 11, "name": "8bzFMvsq"}], [{"max": 93, "min": 16, "name": "m4BdXgq7"}, {"max": 69, "min": 84, "name": "59O8L8sn"}, {"max": 10, "min": 20, "name": "qBmZe7pa"}], [{"max": 86, "min": 99, "name": "dhfYcCH3"}, {"max": 10, "min": 94, "name": "avMwdjSq"}, {"max": 3, "min": 98, "name": "ON3K3J7S"}]], "has_combination": true, "role_flexing_enable": false, "role_flexing_player": 47, "role_flexing_second": 18}, "duration": 57, "max_number": 62, "min_number": 51, "player_max_number": 65, "player_min_number": 25}, {"combination": {"alliances": [[{"max": 82, "min": 82, "name": "itxDnGQT"}, {"max": 31, "min": 5, "name": "8v4vp3Tw"}, {"max": 9, "min": 57, "name": "GksjbYGP"}], [{"max": 93, "min": 11, "name": "AlwDepSg"}, {"max": 0, "min": 4, "name": "LfDbepal"}, {"max": 53, "min": 11, "name": "8LDuCOef"}], [{"max": 80, "min": 88, "name": "lodYQZue"}, {"max": 30, "min": 12, "name": "DueSNDsw"}, {"max": 40, "min": 63, "name": "Cl14obm7"}]], "has_combination": false, "role_flexing_enable": false, "role_flexing_player": 30, "role_flexing_second": 9}, "duration": 61, "max_number": 66, "min_number": 79, "player_max_number": 31, "player_min_number": 75}, {"combination": {"alliances": [[{"max": 76, "min": 84, "name": "TsPx5Wpt"}, {"max": 75, "min": 98, "name": "aOiG12VQ"}, {"max": 49, "min": 41, "name": "kemrWp2K"}], [{"max": 64, "min": 70, "name": "j87sZyFO"}, {"max": 96, "min": 3, "name": "HwhMPjVG"}, {"max": 88, "min": 61, "name": "MKUnpqWN"}], [{"max": 28, "min": 0, "name": "DCRYPJvb"}, {"max": 75, "min": 81, "name": "agAYa8zF"}, {"max": 85, "min": 74, "name": "uQ7gQ6NL"}]], "has_combination": true, "role_flexing_enable": false, "role_flexing_player": 75, "role_flexing_second": 95}, "duration": 58, "max_number": 26, "min_number": 36, "player_max_number": 57, "player_min_number": 59}], "name": "Cy3GNzlA"}, "BMqQaptH": {"alliance": {"combination": {"alliances": [[{"max": 91, "min": 15, "name": "dEk2QGXZ"}, {"max": 86, "min": 75, "name": "t05Xdvmy"}, {"max": 2, "min": 70, "name": "AxtdB9Zg"}], [{"max": 57, "min": 58, "name": "VQmjJheW"}, {"max": 39, "min": 23, "name": "BtAohdva"}, {"max": 70, "min": 65, "name": "0j4Het5f"}], [{"max": 0, "min": 14, "name": "m2Ne3KKI"}, {"max": 6, "min": 95, "name": "s5mSHjQ1"}, {"max": 86, "min": 36, "name": "SfLznUYs"}]], "has_combination": true, "role_flexing_enable": true, "role_flexing_player": 25, "role_flexing_second": 16}, "max_number": 27, "min_number": 4, "player_max_number": 43, "player_min_number": 50}, "alliance_flexing_rule": [{"combination": {"alliances": [[{"max": 95, "min": 44, "name": "3kHVVsQq"}, {"max": 49, "min": 44, "name": "0gTqGX2f"}, {"max": 1, "min": 41, "name": "mpmoJ0Gq"}], [{"max": 84, "min": 33, "name": "Sa1fFMHT"}, {"max": 47, "min": 30, "name": "iYBv5qmk"}, {"max": 60, "min": 39, "name": "Ty2quus8"}], [{"max": 96, "min": 81, "name": "P003zAH5"}, {"max": 35, "min": 51, "name": "MeRIalMA"}, {"max": 98, "min": 45, "name": "VBk9XMwH"}]], "has_combination": false, "role_flexing_enable": false, "role_flexing_player": 30, "role_flexing_second": 3}, "duration": 25, "max_number": 8, "min_number": 44, "player_max_number": 16, "player_min_number": 33}, {"combination": {"alliances": [[{"max": 19, "min": 71, "name": "TTkGHtxu"}, {"max": 88, "min": 35, "name": "zHhiWo8x"}, {"max": 34, "min": 94, "name": "QGAcptkl"}], [{"max": 42, "min": 38, "name": "OnVPD9rK"}, {"max": 42, "min": 42, "name": "TqMt6D76"}, {"max": 43, "min": 86, "name": "iNeMBZ7B"}], [{"max": 23, "min": 24, "name": "VM0yYPrj"}, {"max": 12, "min": 92, "name": "P9cHR6Ft"}, {"max": 53, "min": 92, "name": "OUf4zIiy"}]], "has_combination": false, "role_flexing_enable": false, "role_flexing_player": 75, "role_flexing_second": 7}, "duration": 88, "max_number": 7, "min_number": 23, "player_max_number": 54, "player_min_number": 29}, {"combination": {"alliances": [[{"max": 79, "min": 66, "name": "1YDHdjjM"}, {"max": 29, "min": 18, "name": "AeHdFPjq"}, {"max": 85, "min": 62, "name": "iZzNMqyt"}], [{"max": 42, "min": 55, "name": "obpoS9RB"}, {"max": 87, "min": 64, "name": "w6pJ7kpT"}, {"max": 81, "min": 63, "name": "x3zbbhw1"}], [{"max": 21, "min": 65, "name": "4H4tsvdk"}, {"max": 58, "min": 49, "name": "th3OvtZR"}, {"max": 44, "min": 70, "name": "tlniabVI"}]], "has_combination": true, "role_flexing_enable": true, "role_flexing_player": 57, "role_flexing_second": 8}, "duration": 36, "max_number": 34, "min_number": 50, "player_max_number": 93, "player_min_number": 18}], "name": "vhBzqfek"}, "yyCdKTWT": {"alliance": {"combination": {"alliances": [[{"max": 1, "min": 85, "name": "X9pvLLkC"}, {"max": 87, "min": 18, "name": "oYOuflRJ"}, {"max": 4, "min": 57, "name": "in1BF44T"}], [{"max": 17, "min": 20, "name": "IbS33COs"}, {"max": 81, "min": 87, "name": "xXtqgmhT"}, {"max": 15, "min": 41, "name": "mHeB6vXJ"}], [{"max": 73, "min": 44, "name": "OmlMGRrM"}, {"max": 48, "min": 15, "name": "NcAbIlPo"}, {"max": 45, "min": 30, "name": "7fnhjr6f"}]], "has_combination": true, "role_flexing_enable": true, "role_flexing_player": 37, "role_flexing_second": 76}, "max_number": 75, "min_number": 7, "player_max_number": 32, "player_min_number": 90}, "alliance_flexing_rule": [{"combination": {"alliances": [[{"max": 1, "min": 7, "name": "fIF2MK3r"}, {"max": 73, "min": 18, "name": "c5wblvPW"}, {"max": 92, "min": 18, "name": "GPxKpYvX"}], [{"max": 27, "min": 68, "name": "TXyszm4f"}, {"max": 36, "min": 84, "name": "k9fTBa6Y"}, {"max": 23, "min": 45, "name": "0Pob3lsN"}], [{"max": 1, "min": 37, "name": "6ByAd2vm"}, {"max": 48, "min": 80, "name": "KRznzPSf"}, {"max": 70, "min": 59, "name": "hHFZM5Jy"}]], "has_combination": true, "role_flexing_enable": true, "role_flexing_player": 78, "role_flexing_second": 78}, "duration": 76, "max_number": 8, "min_number": 27, "player_max_number": 90, "player_min_number": 96}, {"combination": {"alliances": [[{"max": 7, "min": 19, "name": "sfuLc0Oh"}, {"max": 84, "min": 99, "name": "V1TJnakm"}, {"max": 49, "min": 15, "name": "vwqVcb5g"}], [{"max": 70, "min": 54, "name": "sfEljYqc"}, {"max": 76, "min": 94, "name": "IJKWmseq"}, {"max": 68, "min": 59, "name": "GzQoMwkK"}], [{"max": 91, "min": 31, "name": "e1eT4Rq5"}, {"max": 15, "min": 95, "name": "GSzT8aGf"}, {"max": 46, "min": 18, "name": "djtURpna"}]], "has_combination": false, "role_flexing_enable": true, "role_flexing_player": 51, "role_flexing_second": 96}, "duration": 68, "max_number": 99, "min_number": 76, "player_max_number": 38, "player_min_number": 51}, {"combination": {"alliances": [[{"max": 20, "min": 96, "name": "FrkTWWo9"}, {"max": 96, "min": 87, "name": "XgbvdM8t"}, {"max": 38, "min": 22, "name": "e49jRP8K"}], [{"max": 58, "min": 15, "name": "06Wyvb5J"}, {"max": 32, "min": 83, "name": "LFZaccxI"}, {"max": 35, "min": 77, "name": "6YdsWvPj"}], [{"max": 61, "min": 38, "name": "3xz68p4L"}, {"max": 44, "min": 22, "name": "SrIRf60z"}, {"max": 75, "min": 11, "name": "d1oL5mOG"}]], "has_combination": true, "role_flexing_enable": true, "role_flexing_player": 5, "role_flexing_second": 24}, "duration": 94, "max_number": 84, "min_number": 19, "player_max_number": 88, "player_min_number": 45}], "name": "Q2LBJH6P"}}, "ticket_flexing_selection": "oldest", "ticket_flexing_selections": [{"selection": "newest", "threshold": 11}, {"selection": "newest", "threshold": 62}, {"selection": "oldest", "threshold": 75}], "use_newest_ticket_for_flexing": false}, "session_queue_timeout_seconds": 25, "social_matchmaking": false, "ticket_observability_enable": false, "use_sub_gamemode": false}' > $TEMP_JSON_INPUT
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
    --channelName 'rUKJkDAn' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 6 'GetMatchPoolMetric' test.out

#- 7 DeleteChannelHandler
$CLI_EXE \
    --sn matchmaking \
    --op DeleteChannelHandler \
    --channel 'C7EEMDbo' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 7 'DeleteChannelHandler' test.out

#- 8 StoreMatchResults
# body param: body
echo '{"match_id": "UDwz8oFS", "players": [{"results": [{"attribute": "QnAnV8ML", "value": 0.6004906554129525}, {"attribute": "3hnA5uI3", "value": 0.2238192607145818}, {"attribute": "nseH1NzB", "value": 0.6124840749063047}], "user_id": "dRfnjcyf"}, {"results": [{"attribute": "8ZhaK3nh", "value": 0.08155999913562717}, {"attribute": "AFAZiVhq", "value": 0.4938541653175652}, {"attribute": "bdUWu4Sk", "value": 0.0907742592639591}], "user_id": "Lmx05Q9y"}, {"results": [{"attribute": "8P7YEsfh", "value": 0.7019048671669098}, {"attribute": "JZUNGo34", "value": 0.27600899142786794}, {"attribute": "D9yFvAQP", "value": 0.8903674937084991}], "user_id": "nmI9GqiS"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op StoreMatchResults \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 8 'StoreMatchResults' test.out

#- 9 Rebalance
# body param: body
echo '{"match_id": "kyy54kPC"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op Rebalance \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 9 'Rebalance' test.out

#- 10 QueueSessionHandler
# body param: body
echo '{"channel": "3nUpNePQ", "client_version": "ZA92JTae", "deployment": "Eyi3Nce0", "error_code": 17, "error_message": "fMPMAcH0", "game_mode": "159WF1Wm", "is_mock": "961J85Of", "joinable": true, "match_id": "ra2jfKYZ", "matching_allies": [{"matching_parties": [{"first_ticket_created_at": 59, "party_attributes": {"dIPGb6P3": {}, "AE4eEa4W": {}, "YE8LFp8w": {}}, "party_id": "NXAHYElk", "party_members": [{"extra_attributes": {"6WFTfUwB": {}, "TjGMqXXU": {}, "tfTwjHRJ": {}}, "user_id": "MNg5iR8U"}, {"extra_attributes": {"CIDTYi0n": {}, "QPyBt6yI": {}, "xrS57eSP": {}}, "user_id": "h0uofVds"}, {"extra_attributes": {"HPztg65V": {}, "7ANH0tTA": {}, "xt02QHf5": {}}, "user_id": "JcAq6ihM"}], "ticket_created_at": 14, "ticket_id": "xf2yeMx5"}, {"first_ticket_created_at": 61, "party_attributes": {"KsHjJmpU": {}, "sD56nyvc": {}, "K7aq42cU": {}}, "party_id": "Lddowt3O", "party_members": [{"extra_attributes": {"kHH2ZiDM": {}, "zQbhRQqc": {}, "EUk6jHX5": {}}, "user_id": "y3tfiUgI"}, {"extra_attributes": {"txXZarPQ": {}, "uJSjGg0l": {}, "b0arfNgb": {}}, "user_id": "4RBds97R"}, {"extra_attributes": {"qv8LQ5PY": {}, "B0DuH4U3": {}, "ESePFN27": {}}, "user_id": "t4NvGo3R"}], "ticket_created_at": 26, "ticket_id": "0y31XYnh"}, {"first_ticket_created_at": 54, "party_attributes": {"NJ9OLeMI": {}, "2u4uA2BE": {}, "RLlL9jAA": {}}, "party_id": "2NOCNYuM", "party_members": [{"extra_attributes": {"jXw8isbr": {}, "gzEaerzg": {}, "kSTdl8iz": {}}, "user_id": "pIIWUa64"}, {"extra_attributes": {"ueNsiYQj": {}, "gJo79hjA": {}, "ZkVTwANX": {}}, "user_id": "f69qOi6b"}, {"extra_attributes": {"uD4MRFH1": {}, "ilXbxhVO": {}, "G0etcGOe": {}}, "user_id": "9jyql19W"}], "ticket_created_at": 56, "ticket_id": "vMtUt4Q0"}]}, {"matching_parties": [{"first_ticket_created_at": 70, "party_attributes": {"dPasdm6R": {}, "fnGHyo11": {}, "NapuLlx6": {}}, "party_id": "S6OagBLa", "party_members": [{"extra_attributes": {"SjPzAyAT": {}, "hSWHuZu3": {}, "aOLS7ZZz": {}}, "user_id": "taswrnKt"}, {"extra_attributes": {"6fJPWAY1": {}, "0G3F1j3n": {}, "bB5NNxTt": {}}, "user_id": "nWm619GX"}, {"extra_attributes": {"PK5eJdAM": {}, "xHN0LnlL": {}, "daZO8W9K": {}}, "user_id": "FCT33CAt"}], "ticket_created_at": 65, "ticket_id": "awIVD55w"}, {"first_ticket_created_at": 83, "party_attributes": {"EGDXz7Ee": {}, "QzacaSsF": {}, "a8bVQqCc": {}}, "party_id": "7LlTgHgu", "party_members": [{"extra_attributes": {"9sDnvZ4p": {}, "DrqJmVnd": {}, "0lKaffYE": {}}, "user_id": "Bn89qvDg"}, {"extra_attributes": {"i05NK7ND": {}, "l3idUXHk": {}, "MhOHeFa2": {}}, "user_id": "JoUDn2T8"}, {"extra_attributes": {"paYUcmey": {}, "46WjcsFr": {}, "CwRsqWn1": {}}, "user_id": "GtHrs9TC"}], "ticket_created_at": 56, "ticket_id": "HER3FOtK"}, {"first_ticket_created_at": 71, "party_attributes": {"YPwaclsA": {}, "SOXGJryO": {}, "hbQB79OG": {}}, "party_id": "C00de4lz", "party_members": [{"extra_attributes": {"c1yN1PGf": {}, "D1Qi352B": {}, "etz2g5db": {}}, "user_id": "bDLJ7dSC"}, {"extra_attributes": {"hL2Y8EVf": {}, "4XcC3crN": {}, "XIOY6tJE": {}}, "user_id": "K5aAY5K6"}, {"extra_attributes": {"qdR7MfU0": {}, "jPb3gnrG": {}, "OOcPfoVv": {}}, "user_id": "gBDlsKHI"}], "ticket_created_at": 37, "ticket_id": "YKjiTKa0"}]}, {"matching_parties": [{"first_ticket_created_at": 40, "party_attributes": {"V5WD2bwz": {}, "wgx1oF90": {}, "M14yZHSl": {}}, "party_id": "BGvETa6x", "party_members": [{"extra_attributes": {"V7nUNhOB": {}, "xYgHNAZt": {}, "jgzM408J": {}}, "user_id": "GHzEcRlt"}, {"extra_attributes": {"JDjkYRcm": {}, "Xc1vmWiL": {}, "OTeFeH6N": {}}, "user_id": "7BsbAn7J"}, {"extra_attributes": {"EJTviKXF": {}, "Clhg9l1f": {}, "hR4uIHPq": {}}, "user_id": "eeH7Aigx"}], "ticket_created_at": 52, "ticket_id": "MmozTSpL"}, {"first_ticket_created_at": 23, "party_attributes": {"3CdcjcFI": {}, "vnVYuEcd": {}, "vNtCFpIp": {}}, "party_id": "bow8OzNk", "party_members": [{"extra_attributes": {"2gPvdW4l": {}, "RIKTqI16": {}, "cnvs0cHY": {}}, "user_id": "QEVZcooV"}, {"extra_attributes": {"dtcoDJ8s": {}, "7RTsfL8d": {}, "BHg4MJWh": {}}, "user_id": "8YYy3kDQ"}, {"extra_attributes": {"85P7DY5V": {}, "Q4oX6JcI": {}, "Nk57T5fH": {}}, "user_id": "MAImzYIq"}], "ticket_created_at": 20, "ticket_id": "LIR3hMld"}, {"first_ticket_created_at": 3, "party_attributes": {"HtfGs9CW": {}, "WNpfmgxR": {}, "N5FYAGiX": {}}, "party_id": "IMHT5eOi", "party_members": [{"extra_attributes": {"9mMIClMd": {}, "easmHLv0": {}, "9SaTfQOR": {}}, "user_id": "PzeFZ0RH"}, {"extra_attributes": {"MzaxedDn": {}, "jPLZjKFw": {}, "q36dtm3J": {}}, "user_id": "H1F6tMK0"}, {"extra_attributes": {"ApjPxR8A": {}, "GNhyse0e": {}, "Eh2yGEG4": {}}, "user_id": "GuTtkVhW"}], "ticket_created_at": 67, "ticket_id": "gjbXicI9"}]}], "namespace": "81vHhFsj", "party_attributes": {"RW13jD9V": {}, "qfkNQpp5": {}, "cT6jITYe": {}}, "party_id": "8Owraif1", "queued_at": 28, "region": "eglU6qvl", "server_name": "JS0R2b4I", "status": "szZngeu1", "ticket_id": "4CGHvXND", "ticket_ids": ["dFcCGl2v", "5xHDlCwX", "ubNBSB1l"], "updated_at": "1978-05-25T00:00:00Z"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op QueueSessionHandler \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 10 'QueueSessionHandler' test.out

#- 11 DequeueSessionHandler
# body param: body
echo '{"match_id": "hxfuwEDW"}' > $TEMP_JSON_INPUT
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
    --matchID 'GWiM3Wda' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 12 'QuerySessionHandler' test.out

#- 13 UpdatePlayTimeWeight
# body param: body
echo '{"playtime": 38, "userID": "x4MhNu0T", "weight": 0.29538597124802846}' > $TEMP_JSON_INPUT
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
    --matchIDs 'Vn2lzu88' \
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
    --upload $TEMP_FILE_UPLOAD \
    --strategy '0EAgxToW' \
    > test.out 2>&1
eval_tap $? 17 'ImportChannels' test.out

#- 18 GetSingleMatchmakingChannel
$CLI_EXE \
    --sn matchmaking \
    --op GetSingleMatchmakingChannel \
    --channelName 'P4TQRj23' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 18 'GetSingleMatchmakingChannel' test.out

#- 19 UpdateMatchmakingChannel
# body param: body
echo '{"deployment": "AnwunRFL", "description": "8Wj63CD4", "findMatchTimeoutSeconds": 30, "joinable": false, "max_delay_ms": 15, "region_expansion_range_ms": 100, "region_expansion_rate_ms": 58, "region_latency_initial_range_ms": 34, "region_latency_max_ms": 51, "ruleSet": {"alliance": {"combination": {"alliances": [[{"max": 72, "min": 80, "name": "ld4DtO8c"}, {"max": 75, "min": 62, "name": "tVNBDgtY"}, {"max": 0, "min": 5, "name": "ByB7vILq"}], [{"max": 47, "min": 4, "name": "EFAwhGIz"}, {"max": 58, "min": 61, "name": "9DGQn1U5"}, {"max": 96, "min": 34, "name": "ijG1XORq"}], [{"max": 55, "min": 60, "name": "rAEdPVlp"}, {"max": 62, "min": 82, "name": "SduyTvlk"}, {"max": 87, "min": 44, "name": "kqshYv4T"}]], "has_combination": true, "role_flexing_enable": true, "role_flexing_player": 83, "role_flexing_second": 28}, "maxNumber": 79, "minNumber": 6, "playerMaxNumber": 74, "playerMinNumber": 63}, "alliance_flexing_rule": [{"combination": {"alliances": [[{"max": 57, "min": 41, "name": "RzxNWWTw"}, {"max": 44, "min": 5, "name": "3Hjfu82R"}, {"max": 90, "min": 51, "name": "OWV3etDp"}], [{"max": 92, "min": 47, "name": "tWSt20Y0"}, {"max": 68, "min": 94, "name": "OMw7rShV"}, {"max": 22, "min": 16, "name": "cBMOXEJy"}], [{"max": 11, "min": 91, "name": "M3ztMdKq"}, {"max": 25, "min": 24, "name": "eETi36fG"}, {"max": 49, "min": 84, "name": "tgu2oXye"}]], "has_combination": false, "role_flexing_enable": true, "role_flexing_player": 65, "role_flexing_second": 72}, "duration": 76, "max_number": 52, "min_number": 35, "player_max_number": 30, "player_min_number": 11}, {"combination": {"alliances": [[{"max": 63, "min": 96, "name": "6ZWk3ett"}, {"max": 11, "min": 71, "name": "MSZvh4Px"}, {"max": 6, "min": 0, "name": "GGQjILuG"}], [{"max": 87, "min": 46, "name": "4ICrz1mr"}, {"max": 20, "min": 10, "name": "1pU7lhd6"}, {"max": 68, "min": 68, "name": "JxPgxeSI"}], [{"max": 54, "min": 89, "name": "hxNWo0IY"}, {"max": 69, "min": 25, "name": "cwk2ukB5"}, {"max": 44, "min": 91, "name": "ikjThgjZ"}]], "has_combination": true, "role_flexing_enable": true, "role_flexing_player": 68, "role_flexing_second": 79}, "duration": 56, "max_number": 62, "min_number": 62, "player_max_number": 4, "player_min_number": 15}, {"combination": {"alliances": [[{"max": 15, "min": 81, "name": "YCPF2YDk"}, {"max": 78, "min": 50, "name": "ijB6ZBBP"}, {"max": 42, "min": 66, "name": "NtB5z4Hg"}], [{"max": 6, "min": 94, "name": "vjEdMAWg"}, {"max": 82, "min": 93, "name": "6DL9CUgH"}, {"max": 5, "min": 20, "name": "X3dz7CCu"}], [{"max": 76, "min": 3, "name": "l6bmRhuT"}, {"max": 29, "min": 30, "name": "o0cx2d3A"}, {"max": 90, "min": 30, "name": "sCWYIb9R"}]], "has_combination": false, "role_flexing_enable": false, "role_flexing_player": 88, "role_flexing_second": 50}, "duration": 42, "max_number": 77, "min_number": 77, "player_max_number": 2, "player_min_number": 68}], "batch_size": 1, "bucket_mmr_rule": {"disable_authority": true, "flex_authority_count": 100, "flex_flat_step_range": 50, "flex_immunity_count": 98, "flex_range_max": 73, "flex_rate_ms": 62, "flex_step_max": 78, "force_authority_match": true, "initial_step_range": 78, "mmr_max": 14, "mmr_mean": 99, "mmr_min": 86, "mmr_std_dev": 12, "override_mmr_data": true, "use_bucket_mmr": true, "use_flat_flex_step": false}, "flexingRules": [{"attribute": "eei4CVAU", "criteria": "iXDkuVgi", "duration": 77, "reference": 0.3561560347880175}, {"attribute": "T3fGeRXN", "criteria": "gG2vT4T6", "duration": 11, "reference": 0.29650530727984725}, {"attribute": "1oc21XL1", "criteria": "OBuUVnQe", "duration": 42, "reference": 0.3769124007760065}], "match_options": {"options": [{"name": "Gh5oDphG", "type": "PQhkuwxz"}, {"name": "UyH1ZXBy", "type": "q4PXACHm"}, {"name": "Ov5fp9hI", "type": "GMJrrfNJ"}]}, "matchingRules": [{"attribute": "2YBbWglm", "criteria": "iBdoM2Or", "reference": 0.002073456314941491}, {"attribute": "oVReJm0S", "criteria": "V9qzj6zj", "reference": 0.6367664599696464}, {"attribute": "eKPaN6yu", "criteria": "064zIRlu", "reference": 0.18042542367388803}], "sort_ticket": {"search_result": "none", "ticket_queue": "none"}, "sort_tickets": [{"search_result": "largestPartySize", "threshold": 63, "ticket_queue": "distance"}, {"search_result": "oldestTicketAge", "threshold": 65, "ticket_queue": "largestPartySize"}, {"search_result": "random", "threshold": 13, "ticket_queue": "distance"}], "sub_game_modes": {}, "ticket_flexing_selection": "random", "ticket_flexing_selections": [{"selection": "newest", "threshold": 82}, {"selection": "pivot", "threshold": 19}, {"selection": "random", "threshold": 49}], "use_newest_ticket_for_flexing": false}, "sessionQueueTimeoutSeconds": 1, "socialMatchmaking": false, "ticket_observability_enable": false, "use_sub_gamemode": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op UpdateMatchmakingChannel \
    --channelName 'enoevCRB' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 19 'UpdateMatchmakingChannel' test.out

#- 20 CleanAllMocks
$CLI_EXE \
    --sn matchmaking \
    --op CleanAllMocks \
    --channelName '32lYJHUT' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 20 'CleanAllMocks' test.out

#- 21 GetAllMockMatches
$CLI_EXE \
    --sn matchmaking \
    --op GetAllMockMatches \
    --channelName 'vEY8B2VX' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 21 'GetAllMockMatches' test.out

#- 22 GetMockMatchesByTimestamp
# body param: body
echo '{"timestamp_after": 87}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op GetMockMatchesByTimestamp \
    --channelName 'fEpywmOE' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 22 'GetMockMatchesByTimestamp' test.out

#- 23 GetAllMockTickets
$CLI_EXE \
    --sn matchmaking \
    --op GetAllMockTickets \
    --channelName 'q4bv7ylY' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 23 'GetAllMockTickets' test.out

#- 24 CreateMockTickets
# body param: body
echo '{"attribute_name": "YvaaPi2K", "count": 37, "mmrMax": 0.19884549251473826, "mmrMean": 0.9593505298637409, "mmrMin": 0.7644986218523502, "mmrStdDev": 0.07451761838349813}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op CreateMockTickets \
    --channelName 'DJD3BwR0' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 24 'CreateMockTickets' test.out

#- 25 BulkCreateMockTickets
# body param: body
echo '[{"first_ticket_created_at": 89, "party_attributes": {"B8AXYX0m": {}, "jBX83wox": {}, "QsXwuuPP": {}}, "party_id": "V337p1og", "party_members": [{"extra_attributes": {"XKjASbiP": {}, "sD1EfOI0": {}, "zjtCPqJB": {}}, "user_id": "wi9i9rhT"}, {"extra_attributes": {"foNntOvi": {}, "JYE5NKLH": {}, "yvYYvv2d": {}}, "user_id": "Z4KJbriy"}, {"extra_attributes": {"uiTwcKQA": {}, "oSpFZxPj": {}, "VAH9WhNe": {}}, "user_id": "LqvqdA5N"}], "ticket_created_at": 58, "ticket_id": "GsW2ehS8"}, {"first_ticket_created_at": 14, "party_attributes": {"X26sIXHU": {}, "rLCMKRFR": {}, "dVmm6g9g": {}}, "party_id": "LHEWgxgP", "party_members": [{"extra_attributes": {"WQHrGLkP": {}, "IvvwpSdJ": {}, "AwQBjTv4": {}}, "user_id": "AjP3LcFD"}, {"extra_attributes": {"79WkFetu": {}, "VXXlFvdH": {}, "ZV8ve0fV": {}}, "user_id": "f8ar0b23"}, {"extra_attributes": {"ViNYg1Zx": {}, "ZcUNTMkB": {}, "dlL7jKgx": {}}, "user_id": "Hd8ywTLn"}], "ticket_created_at": 87, "ticket_id": "hPi23Aqz"}, {"first_ticket_created_at": 15, "party_attributes": {"f5vL6Kad": {}, "BWdFRktc": {}, "QAKgbXit": {}}, "party_id": "LGKCEt9E", "party_members": [{"extra_attributes": {"niJR2BYR": {}, "AbrkkL9Z": {}, "bsryowAR": {}}, "user_id": "pniHaOce"}, {"extra_attributes": {"Vzn6fzSp": {}, "6ehMZUH6": {}, "7bOinR7L": {}}, "user_id": "7iJjALNw"}, {"extra_attributes": {"Or4QiEi0": {}, "J4cq8Uy6": {}, "qFnHmDPu": {}}, "user_id": "sdHBCHP1"}], "ticket_created_at": 22, "ticket_id": "NstUlcFQ"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op BulkCreateMockTickets \
    --channelName 'l3K046NY' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 25 'BulkCreateMockTickets' test.out

#- 26 GetMockTicketsByTimestamp
# body param: body
echo '{"timestamp_after": 35}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op GetMockTicketsByTimestamp \
    --channelName 'YjzdS0Tf' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 26 'GetMockTicketsByTimestamp' test.out

#- 27 GetAllPartyInChannel
$CLI_EXE \
    --sn matchmaking \
    --op GetAllPartyInChannel \
    --channelName 'OylNU155' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 27 'GetAllPartyInChannel' test.out

#- 28 GetAllSessionsInChannel
$CLI_EXE \
    --sn matchmaking \
    --op GetAllSessionsInChannel \
    --channelName 'UQBJdyOg' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 28 'GetAllSessionsInChannel' test.out

#- 29 AddUserIntoSessionInChannel
# body param: body
echo '{"blocked_players": ["izEvgQc1", "4pvXGcAy", "ojxDkfry"], "party_id": "eibQyzs7", "user_id": "Z8KSMLpz"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op AddUserIntoSessionInChannel \
    --channelName 'QH4VY0ps' \
    --matchID 'kHda9dXZ' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 29 'AddUserIntoSessionInChannel' test.out

#- 30 DeleteSessionInChannel
$CLI_EXE \
    --sn matchmaking \
    --op DeleteSessionInChannel \
    --channelName 'E82iYQvs' \
    --matchID 'glKWY8QY' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 30 'DeleteSessionInChannel' test.out

#- 31 DeleteUserFromSessionInChannel
$CLI_EXE \
    --sn matchmaking \
    --op DeleteUserFromSessionInChannel \
    --channelName 'nmOoGal8' \
    --matchID 'Acf2lDrt' \
    --namespace $AB_NAMESPACE \
    --userID 'WGIxzOID' \
    > test.out 2>&1
eval_tap $? 31 'DeleteUserFromSessionInChannel' test.out

#- 32 GetStatData
$CLI_EXE \
    --sn matchmaking \
    --op GetStatData \
    --channelName 'Kn4RDSM4' \
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
    --channelName '2INQLS3M' \
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