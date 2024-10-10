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
    --limit '57' \
    --offset '80' \
    > test.out 2>&1
eval_tap $? 4 'GetAllChannelsHandler' test.out

#- 5 CreateChannelHandler
# body param: body
echo '{"blocked_player_option": "blockedPlayerCanMatch", "deployment": "KSl7j6wC", "description": "9KoDk26N", "find_match_timeout_seconds": 13, "game_mode": "OjoCJ3wP", "joinable": false, "max_delay_ms": 13, "region_expansion_range_ms": 38, "region_expansion_rate_ms": 64, "region_latency_initial_range_ms": 89, "region_latency_max_ms": 95, "rule_set": {"alliance": {"combination": {"alliances": [[{"max": 60, "min": 59, "name": "ctDwtVWZ"}, {"max": 78, "min": 74, "name": "CDte5mww"}, {"max": 53, "min": 91, "name": "wWPqZo0u"}], [{"max": 72, "min": 3, "name": "3Pz3H1vU"}, {"max": 32, "min": 28, "name": "64svExUS"}, {"max": 30, "min": 6, "name": "afAxLW41"}], [{"max": 23, "min": 75, "name": "NENd6MYP"}, {"max": 52, "min": 63, "name": "ohaIeORp"}, {"max": 84, "min": 13, "name": "vF9vIT4H"}]], "has_combination": false, "role_flexing_enable": true, "role_flexing_player": 65, "role_flexing_second": 48}, "max_number": 75, "min_number": 33, "player_max_number": 68, "player_min_number": 31}, "alliance_flexing_rule": [{"combination": {"alliances": [[{"max": 83, "min": 99, "name": "Dqxo9iOp"}, {"max": 79, "min": 92, "name": "suvspbJW"}, {"max": 31, "min": 37, "name": "hr3CTYwP"}], [{"max": 36, "min": 81, "name": "Wr7k3mRd"}, {"max": 82, "min": 68, "name": "p4bdjF0c"}, {"max": 66, "min": 71, "name": "L814xFfB"}], [{"max": 49, "min": 21, "name": "f6aNRpcq"}, {"max": 37, "min": 77, "name": "3idqpcjb"}, {"max": 17, "min": 64, "name": "xqw1Sn1J"}]], "has_combination": false, "role_flexing_enable": false, "role_flexing_player": 43, "role_flexing_second": 59}, "duration": 18, "max_number": 34, "min_number": 0, "player_max_number": 12, "player_min_number": 68}, {"combination": {"alliances": [[{"max": 38, "min": 88, "name": "veY4qayG"}, {"max": 5, "min": 18, "name": "JSq9brXs"}, {"max": 91, "min": 65, "name": "yx5TZc1n"}], [{"max": 59, "min": 25, "name": "Eba45atZ"}, {"max": 47, "min": 15, "name": "yhtg2Nry"}, {"max": 75, "min": 19, "name": "0zlgBuQX"}], [{"max": 46, "min": 85, "name": "KbgFib8L"}, {"max": 83, "min": 25, "name": "Y4ofxPaj"}, {"max": 62, "min": 31, "name": "X5ZmUtEK"}]], "has_combination": true, "role_flexing_enable": true, "role_flexing_player": 98, "role_flexing_second": 2}, "duration": 90, "max_number": 98, "min_number": 16, "player_max_number": 43, "player_min_number": 28}, {"combination": {"alliances": [[{"max": 81, "min": 65, "name": "zCgakPmD"}, {"max": 74, "min": 46, "name": "hmLXyZ85"}, {"max": 38, "min": 55, "name": "wHc4tCef"}], [{"max": 15, "min": 63, "name": "yUcvxhlA"}, {"max": 4, "min": 81, "name": "zoLGUdfe"}, {"max": 84, "min": 15, "name": "3k6Chsi6"}], [{"max": 64, "min": 90, "name": "foZHnbil"}, {"max": 63, "min": 88, "name": "ft32uSCk"}, {"max": 1, "min": 72, "name": "Fv5VBgGF"}]], "has_combination": false, "role_flexing_enable": false, "role_flexing_player": 12, "role_flexing_second": 37}, "duration": 29, "max_number": 77, "min_number": 87, "player_max_number": 52, "player_min_number": 40}], "batch_size": 44, "bucket_mmr_rule": {"disable_authority": false, "flex_authority_count": 25, "flex_flat_step_range": 52, "flex_immunity_count": 43, "flex_range_max": 74, "flex_rate_ms": 69, "flex_step_max": 32, "force_authority_match": true, "initial_step_range": 40, "mmr_max": 4, "mmr_mean": 83, "mmr_min": 45, "mmr_std_dev": 15, "override_mmr_data": true, "use_bucket_mmr": true, "use_flat_flex_step": true}, "flexing_rule": [{"attribute": "JZcaebs9", "criteria": "3sXkWIYP", "duration": 44, "reference": 0.11667051922665073}, {"attribute": "XiyqVUb4", "criteria": "QxMorZEo", "duration": 90, "reference": 0.331116180925627}, {"attribute": "NQjGSMsz", "criteria": "9XNLRlk6", "duration": 0, "reference": 0.3433559083100616}], "match_options": {"options": [{"name": "NKxqyGr7", "type": "wgJ9LNCC"}, {"name": "k925Dowu", "type": "zueRsA9g"}, {"name": "R9HwQ9hN", "type": "SUNt8cQ8"}]}, "matching_rule": [{"attribute": "2o7NVbFo", "criteria": "8LunEm0y", "reference": 0.1997534936901525}, {"attribute": "mKmlk9bn", "criteria": "M0uzPSqH", "reference": 0.9644488551634833}, {"attribute": "p7NhzFYS", "criteria": "Bldf35GA", "reference": 0.0312741158547335}], "rebalance_enable": false, "sort_ticket": {"search_result": "WofilgoV", "ticket_queue": "mg0QRe5M"}, "sort_tickets": [{"search_result": "uIzg4LpR", "threshold": 46, "ticket_queue": "JDYvPhoH"}, {"search_result": "14xHFMJe", "threshold": 22, "ticket_queue": "J20ilXk3"}, {"search_result": "0owgdirv", "threshold": 48, "ticket_queue": "o2Bv4GB1"}], "sub_game_modes": {"qBLkZNVS": {"alliance": {"combination": {"alliances": [[{"max": 100, "min": 81, "name": "scXDZn5s"}, {"max": 68, "min": 11, "name": "4ynfp5m7"}, {"max": 45, "min": 37, "name": "nGGcL4id"}], [{"max": 79, "min": 52, "name": "AB0IRk6G"}, {"max": 57, "min": 83, "name": "2edHU9qQ"}, {"max": 31, "min": 11, "name": "NB4tVGjB"}], [{"max": 57, "min": 99, "name": "rHiSZ0Es"}, {"max": 49, "min": 63, "name": "XhDp9da6"}, {"max": 85, "min": 61, "name": "OiKuM8EI"}]], "has_combination": false, "role_flexing_enable": false, "role_flexing_player": 38, "role_flexing_second": 43}, "max_number": 99, "min_number": 72, "player_max_number": 7, "player_min_number": 46}, "alliance_flexing_rule": [{"combination": {"alliances": [[{"max": 1, "min": 39, "name": "RUbfC7lp"}, {"max": 53, "min": 98, "name": "SUMDOQVL"}, {"max": 1, "min": 4, "name": "HawtZdWm"}], [{"max": 42, "min": 94, "name": "wV0peg50"}, {"max": 20, "min": 32, "name": "bnKkHwUb"}, {"max": 75, "min": 97, "name": "98OLjlLf"}], [{"max": 57, "min": 17, "name": "mMgtejuk"}, {"max": 89, "min": 69, "name": "AUdENu2t"}, {"max": 21, "min": 94, "name": "eSr7DSab"}]], "has_combination": false, "role_flexing_enable": true, "role_flexing_player": 14, "role_flexing_second": 53}, "duration": 100, "max_number": 63, "min_number": 80, "player_max_number": 91, "player_min_number": 21}, {"combination": {"alliances": [[{"max": 84, "min": 5, "name": "9CNVgvUh"}, {"max": 72, "min": 7, "name": "iq0SzC5R"}, {"max": 98, "min": 89, "name": "Wp3GMorD"}], [{"max": 44, "min": 50, "name": "lH1BGzWY"}, {"max": 88, "min": 24, "name": "gYLEtbBz"}, {"max": 61, "min": 65, "name": "I1RVpbGe"}], [{"max": 53, "min": 85, "name": "utL9Vrsa"}, {"max": 40, "min": 97, "name": "yib2caUY"}, {"max": 8, "min": 81, "name": "KUf9kcvj"}]], "has_combination": false, "role_flexing_enable": false, "role_flexing_player": 48, "role_flexing_second": 82}, "duration": 5, "max_number": 23, "min_number": 8, "player_max_number": 29, "player_min_number": 21}, {"combination": {"alliances": [[{"max": 58, "min": 38, "name": "SLbu2LNj"}, {"max": 40, "min": 12, "name": "PTgF8dkV"}, {"max": 100, "min": 89, "name": "yQMmFKqv"}], [{"max": 89, "min": 22, "name": "sy8C6seB"}, {"max": 99, "min": 59, "name": "UfXz1nZB"}, {"max": 92, "min": 44, "name": "CgG6CV89"}], [{"max": 18, "min": 16, "name": "G5jy7can"}, {"max": 91, "min": 53, "name": "2XWg5kY3"}, {"max": 97, "min": 51, "name": "aKfSpxfK"}]], "has_combination": false, "role_flexing_enable": false, "role_flexing_player": 86, "role_flexing_second": 92}, "duration": 6, "max_number": 67, "min_number": 11, "player_max_number": 63, "player_min_number": 19}], "name": "SadgvUOQ"}, "LJs1t1cj": {"alliance": {"combination": {"alliances": [[{"max": 6, "min": 69, "name": "Dg7T6Hbz"}, {"max": 95, "min": 31, "name": "SjBEKiKE"}, {"max": 51, "min": 91, "name": "2EcPzZ95"}], [{"max": 15, "min": 8, "name": "IwtJaEyF"}, {"max": 66, "min": 55, "name": "UoKdyMV9"}, {"max": 2, "min": 90, "name": "qzZQ203b"}], [{"max": 45, "min": 93, "name": "J4R5oNge"}, {"max": 40, "min": 19, "name": "5902Yr0r"}, {"max": 24, "min": 9, "name": "Mtw3Fk0V"}]], "has_combination": true, "role_flexing_enable": false, "role_flexing_player": 20, "role_flexing_second": 35}, "max_number": 57, "min_number": 56, "player_max_number": 8, "player_min_number": 69}, "alliance_flexing_rule": [{"combination": {"alliances": [[{"max": 97, "min": 81, "name": "BEDo729q"}, {"max": 20, "min": 54, "name": "WXG3Ptwu"}, {"max": 60, "min": 58, "name": "yw5l7kQS"}], [{"max": 51, "min": 37, "name": "Au7SCuRj"}, {"max": 96, "min": 31, "name": "Gez0Np4o"}, {"max": 28, "min": 58, "name": "fQ6VvKF1"}], [{"max": 0, "min": 97, "name": "ikKwBbnh"}, {"max": 96, "min": 8, "name": "6pATpvsw"}, {"max": 13, "min": 18, "name": "54A8H4op"}]], "has_combination": true, "role_flexing_enable": true, "role_flexing_player": 3, "role_flexing_second": 68}, "duration": 90, "max_number": 38, "min_number": 88, "player_max_number": 38, "player_min_number": 2}, {"combination": {"alliances": [[{"max": 13, "min": 62, "name": "50Cio9iJ"}, {"max": 28, "min": 15, "name": "McptYtrO"}, {"max": 72, "min": 21, "name": "GkeiWDfL"}], [{"max": 15, "min": 2, "name": "31ABibE4"}, {"max": 83, "min": 13, "name": "58nP6cLj"}, {"max": 76, "min": 36, "name": "BUmJ6mxK"}], [{"max": 53, "min": 34, "name": "y6PKKbK5"}, {"max": 3, "min": 23, "name": "wn2UnNvn"}, {"max": 55, "min": 15, "name": "qeZeNtrs"}]], "has_combination": false, "role_flexing_enable": true, "role_flexing_player": 21, "role_flexing_second": 96}, "duration": 59, "max_number": 35, "min_number": 8, "player_max_number": 17, "player_min_number": 19}, {"combination": {"alliances": [[{"max": 77, "min": 42, "name": "2ntw42WS"}, {"max": 39, "min": 68, "name": "BQtSTHYl"}, {"max": 78, "min": 9, "name": "uohcI8VZ"}], [{"max": 16, "min": 83, "name": "udxe5j5J"}, {"max": 2, "min": 89, "name": "KYNMdhVo"}, {"max": 45, "min": 13, "name": "OOkNTd2e"}], [{"max": 14, "min": 70, "name": "f2Ga2Ufh"}, {"max": 1, "min": 53, "name": "ct1JjEtn"}, {"max": 29, "min": 37, "name": "KqhJG2yD"}]], "has_combination": false, "role_flexing_enable": false, "role_flexing_player": 10, "role_flexing_second": 56}, "duration": 99, "max_number": 34, "min_number": 68, "player_max_number": 10, "player_min_number": 55}], "name": "HizsHuoh"}, "nRkIyCa1": {"alliance": {"combination": {"alliances": [[{"max": 43, "min": 87, "name": "lgNNumLb"}, {"max": 32, "min": 80, "name": "c0vqXSDa"}, {"max": 12, "min": 52, "name": "rkVphCt3"}], [{"max": 30, "min": 72, "name": "IAvcAIXj"}, {"max": 50, "min": 55, "name": "mpqjvo3D"}, {"max": 0, "min": 53, "name": "dmnUN2Zf"}], [{"max": 14, "min": 68, "name": "MXpLCwK7"}, {"max": 50, "min": 64, "name": "KOP2yP5m"}, {"max": 89, "min": 70, "name": "u8KtWt8b"}]], "has_combination": true, "role_flexing_enable": true, "role_flexing_player": 88, "role_flexing_second": 34}, "max_number": 55, "min_number": 90, "player_max_number": 62, "player_min_number": 19}, "alliance_flexing_rule": [{"combination": {"alliances": [[{"max": 39, "min": 82, "name": "i9PDgWYC"}, {"max": 39, "min": 97, "name": "TM4rTzsl"}, {"max": 24, "min": 65, "name": "qoxw4KMo"}], [{"max": 84, "min": 50, "name": "nqqh0K2R"}, {"max": 70, "min": 66, "name": "In86KCxx"}, {"max": 9, "min": 80, "name": "sMI2I7Yy"}], [{"max": 2, "min": 54, "name": "YQLDLH5B"}, {"max": 14, "min": 79, "name": "jXlakiBW"}, {"max": 59, "min": 94, "name": "LAV6oHN4"}]], "has_combination": false, "role_flexing_enable": false, "role_flexing_player": 88, "role_flexing_second": 48}, "duration": 93, "max_number": 47, "min_number": 32, "player_max_number": 24, "player_min_number": 74}, {"combination": {"alliances": [[{"max": 70, "min": 69, "name": "25w2PaMu"}, {"max": 23, "min": 50, "name": "3VPl5oxY"}, {"max": 85, "min": 77, "name": "6Pq766Sh"}], [{"max": 96, "min": 3, "name": "byCjGNVY"}, {"max": 100, "min": 62, "name": "QBq1bloD"}, {"max": 68, "min": 38, "name": "RXcD4JkN"}], [{"max": 88, "min": 27, "name": "H7gKzcmN"}, {"max": 73, "min": 4, "name": "F64SfVcS"}, {"max": 33, "min": 55, "name": "5JkZC9iF"}]], "has_combination": false, "role_flexing_enable": false, "role_flexing_player": 9, "role_flexing_second": 75}, "duration": 29, "max_number": 21, "min_number": 2, "player_max_number": 80, "player_min_number": 64}, {"combination": {"alliances": [[{"max": 36, "min": 50, "name": "oUWrwyTC"}, {"max": 67, "min": 55, "name": "oX4FlUi8"}, {"max": 60, "min": 24, "name": "uzGjNlKa"}], [{"max": 36, "min": 24, "name": "eform03V"}, {"max": 33, "min": 30, "name": "lXnjOwjb"}, {"max": 84, "min": 32, "name": "aB7OlvFm"}], [{"max": 23, "min": 81, "name": "uzpO5rDc"}, {"max": 0, "min": 95, "name": "oSl1wItk"}, {"max": 28, "min": 22, "name": "j18kE4GX"}]], "has_combination": true, "role_flexing_enable": false, "role_flexing_player": 46, "role_flexing_second": 100}, "duration": 18, "max_number": 87, "min_number": 16, "player_max_number": 82, "player_min_number": 79}], "name": "X3uBe7X1"}}, "ticket_flexing_selection": "iO6YwNn7", "ticket_flexing_selections": [{"selection": "zKaWs4FV", "threshold": 61}, {"selection": "6IHs3VUQ", "threshold": 18}, {"selection": "xh4zJlnV", "threshold": 73}], "use_newest_ticket_for_flexing": true}, "session_queue_timeout_seconds": 29, "social_matchmaking": false, "sub_gamemode_selection": "random", "ticket_observability_enable": false, "use_sub_gamemode": false}' > $TEMP_JSON_INPUT
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
    --channelName 'hc3CkQ3A' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 6 'GetMatchPoolMetric' test.out

#- 7 DeleteChannelHandler
$CLI_EXE \
    --sn matchmaking \
    --op DeleteChannelHandler \
    --channel 'CbOT9nKL' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 7 'DeleteChannelHandler' test.out

#- 8 StoreMatchResults
# body param: body
echo '{"match_id": "eUUlzxJv", "players": [{"results": [{"attribute": "8rMvzL2z", "value": 0.0874644322413014}, {"attribute": "Pd4dKKaU", "value": 0.6973252110653682}, {"attribute": "u7P06nef", "value": 0.5925175393675021}], "user_id": "Mwjvoj4m"}, {"results": [{"attribute": "zNHuzrQ8", "value": 0.22691379575238613}, {"attribute": "Gbb9S3vP", "value": 0.6713650564293517}, {"attribute": "xkqHwjih", "value": 0.7435716902606049}], "user_id": "fsYRVUO3"}, {"results": [{"attribute": "2H0QS0Z7", "value": 0.5637930798989249}, {"attribute": "e6Y3WGgn", "value": 0.8971056974177439}, {"attribute": "wF6Eaonm", "value": 0.22005459469881383}], "user_id": "wF7fN8wx"}]}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op StoreMatchResults \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 8 'StoreMatchResults' test.out

#- 9 Rebalance
# body param: body
echo '{"match_id": "x9Rcekpw"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op Rebalance \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 9 'Rebalance' test.out

#- 10 QueueSessionHandler
# body param: body
echo '{"channel": "yhZ1lgUI", "client_version": "xv3MBwDr", "deployment": "camf2qC3", "error_code": 45, "error_message": "LJf5uj57", "game_mode": "1OuT8N60", "is_mock": "Qf7Xjb7O", "joinable": true, "match_id": "OFxa0Li4", "matching_allies": [{"matching_parties": [{"first_ticket_created_at": 88, "party_attributes": {"r4G7ysFc": {}, "OBJE5sOV": {}, "AFbBzdsX": {}}, "party_id": "2WXP3DDF", "party_members": [{"extra_attributes": {"R1ZIYUcU": {}, "uw1kE5Rs": {}, "5rXz3R68": {}}, "user_id": "lLieXqnq"}, {"extra_attributes": {"5H9tzsgu": {}, "s4mSDuXe": {}, "eul17Ekf": {}}, "user_id": "ZMShLPeT"}, {"extra_attributes": {"5yBUUgX1": {}, "yEKvRe1X": {}, "Em2YBCH5": {}}, "user_id": "mcFAF5ca"}], "ticket_created_at": 12, "ticket_id": "rMHo6lXE"}, {"first_ticket_created_at": 82, "party_attributes": {"jkdUoP5y": {}, "UMzPrLxX": {}, "0FQF0uPD": {}}, "party_id": "uWnRk43v", "party_members": [{"extra_attributes": {"zwbGEO2T": {}, "6CnY3ERs": {}, "Dk3GRzYP": {}}, "user_id": "tpi8aZ9p"}, {"extra_attributes": {"5MHOUALZ": {}, "Qq560CvF": {}, "ai2EAOzT": {}}, "user_id": "1tc4c04T"}, {"extra_attributes": {"DeFDXqhN": {}, "GGjj8EUn": {}, "86ag9yR8": {}}, "user_id": "h4D28G3P"}], "ticket_created_at": 11, "ticket_id": "dv2a9QD5"}, {"first_ticket_created_at": 87, "party_attributes": {"Qbh42MGi": {}, "hc5vWB1G": {}, "jTNr8QX6": {}}, "party_id": "qa9vvtk0", "party_members": [{"extra_attributes": {"TNpp7Afo": {}, "1o7h5tj7": {}, "0dwB9TRq": {}}, "user_id": "VQijIOQv"}, {"extra_attributes": {"Ja3P3aNG": {}, "WpqWcrrk": {}, "LjRH3OG1": {}}, "user_id": "pgcPlI9P"}, {"extra_attributes": {"XVy5Xo8j": {}, "65dbrSk8": {}, "wrpdVjD5": {}}, "user_id": "hMEaHwVm"}], "ticket_created_at": 43, "ticket_id": "p2vTudhv"}]}, {"matching_parties": [{"first_ticket_created_at": 99, "party_attributes": {"r5W3pFba": {}, "A575zTV0": {}, "f85pEwvM": {}}, "party_id": "046ikB9K", "party_members": [{"extra_attributes": {"Sa4m7QqX": {}, "R1XY1Cod": {}, "MgzwAXuO": {}}, "user_id": "tOBwi5fj"}, {"extra_attributes": {"v1W71rKF": {}, "A94SuJu1": {}, "4WUYEa4v": {}}, "user_id": "MJ8REV7E"}, {"extra_attributes": {"yM6ATff5": {}, "j7RrAMJe": {}, "hIhifv16": {}}, "user_id": "OysClJUq"}], "ticket_created_at": 70, "ticket_id": "uyMglcpY"}, {"first_ticket_created_at": 10, "party_attributes": {"bJFLOIVr": {}, "6VOn5njC": {}, "qR0Y2XOr": {}}, "party_id": "sp19sER6", "party_members": [{"extra_attributes": {"p9Hk0QKt": {}, "4dSnsAkB": {}, "4Zj9oPJJ": {}}, "user_id": "sZnF8dDz"}, {"extra_attributes": {"9zgEabyI": {}, "kGZWYfDY": {}, "kWIb2OPi": {}}, "user_id": "iLSOfILD"}, {"extra_attributes": {"RpvZOERq": {}, "MY6LkNqA": {}, "xDOmlUL0": {}}, "user_id": "O5oG3tZB"}], "ticket_created_at": 15, "ticket_id": "2rYO5mqk"}, {"first_ticket_created_at": 25, "party_attributes": {"YTgceLUn": {}, "iEnQ2Oph": {}, "l3ZJbPoz": {}}, "party_id": "qIJmoPOa", "party_members": [{"extra_attributes": {"19gPsiap": {}, "j2ler36L": {}, "HkSn3q6A": {}}, "user_id": "hGFIZHLJ"}, {"extra_attributes": {"HP7Ln1hi": {}, "sc3dkqlb": {}, "3iEcIhcB": {}}, "user_id": "iRtAZTf2"}, {"extra_attributes": {"T5GHZNSe": {}, "xED1j8wN": {}, "eMPrQZCX": {}}, "user_id": "4AzxLVqt"}], "ticket_created_at": 38, "ticket_id": "Osj0Gkhc"}]}, {"matching_parties": [{"first_ticket_created_at": 59, "party_attributes": {"wpXsiVJS": {}, "DY01sK69": {}, "GdEDT4cD": {}}, "party_id": "g1GePBid", "party_members": [{"extra_attributes": {"vdGW0laq": {}, "Bq7hUUlA": {}, "jUNdoyRi": {}}, "user_id": "zYDMgYHM"}, {"extra_attributes": {"uDS2tLBt": {}, "rBgxN5Em": {}, "bCEgSF3U": {}}, "user_id": "anbYHEOi"}, {"extra_attributes": {"r73J4k7y": {}, "ILZrOMkQ": {}, "iLZrgNI4": {}}, "user_id": "9XVimtJV"}], "ticket_created_at": 34, "ticket_id": "JeBm9lgU"}, {"first_ticket_created_at": 91, "party_attributes": {"u00tuYmI": {}, "7uXmNT6b": {}, "P7M4ntOF": {}}, "party_id": "GwKcmCem", "party_members": [{"extra_attributes": {"7PwUV907": {}, "lDFbJfk3": {}, "Fn9SnJYs": {}}, "user_id": "6H5lEsXy"}, {"extra_attributes": {"L1EgAE2u": {}, "1Mp63JXL": {}, "zgOvNOtv": {}}, "user_id": "AhsdrQQb"}, {"extra_attributes": {"OxrH6yb8": {}, "Nr0dfj6h": {}, "YpuXiXzR": {}}, "user_id": "UzyoxEDC"}], "ticket_created_at": 39, "ticket_id": "fNURrtr2"}, {"first_ticket_created_at": 85, "party_attributes": {"gf0jhk6H": {}, "pqQWH2uZ": {}, "c2mI6dGt": {}}, "party_id": "bLpaczX1", "party_members": [{"extra_attributes": {"XRbkCyj3": {}, "OnWEuBLw": {}, "39cDdSjm": {}}, "user_id": "sdfLq2XW"}, {"extra_attributes": {"Hvku9qI2": {}, "u9EqWF3U": {}, "mprX9uFE": {}}, "user_id": "WJwUTrCt"}, {"extra_attributes": {"spaYPfyA": {}, "lR9KFyeF": {}, "ReWQ9qLI": {}}, "user_id": "BEbYEXEw"}], "ticket_created_at": 70, "ticket_id": "5xS1PvIJ"}]}], "namespace": "8kmZzpg1", "party_attributes": {"h5akr5Vm": {}, "iPlxbWRS": {}, "SLPKAreZ": {}}, "party_id": "0V40nYf6", "queued_at": 40, "region": "MuuXP2pN", "server_name": "u9Z01pQE", "status": "66oyuFsn", "ticket_id": "a7zHWLfy", "ticket_ids": ["gWJhS0yo", "AOuQn7AA", "zRxytMH3"], "updated_at": "1990-06-22T00:00:00Z"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op QueueSessionHandler \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 10 'QueueSessionHandler' test.out

#- 11 DequeueSessionHandler
# body param: body
echo '{"match_id": "3M8N8yw1"}' > $TEMP_JSON_INPUT
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
    --matchID '8cR1Jxvy' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 12 'QuerySessionHandler' test.out

#- 13 UpdatePlayTimeWeight
# body param: body
echo '{"playtime": 90, "userID": "YhcRBYSR", "weight": 0.12988502387189127}' > $TEMP_JSON_INPUT
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
    --matchIDs 'FlmmfRgS' \
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
    --strategy 'qubgvNRB' \
    > test.out 2>&1
eval_tap $? 17 'ImportChannels' test.out

#- 18 GetSingleMatchmakingChannel
$CLI_EXE \
    --sn matchmaking \
    --op GetSingleMatchmakingChannel \
    --channelName 'QS7HTMnM' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 18 'GetSingleMatchmakingChannel' test.out

#- 19 UpdateMatchmakingChannel
# body param: body
echo '{"blocked_player_option": "blockedPlayerCanMatch", "deployment": "2PUJz78U", "description": "e4scsK0c", "findMatchTimeoutSeconds": 90, "joinable": false, "max_delay_ms": 19, "region_expansion_range_ms": 44, "region_expansion_rate_ms": 2, "region_latency_initial_range_ms": 16, "region_latency_max_ms": 84, "ruleSet": {"alliance": {"combination": {"alliances": [[{"max": 2, "min": 92, "name": "LxHZ7tVk"}, {"max": 66, "min": 36, "name": "CpjwD15j"}, {"max": 36, "min": 95, "name": "RfJmEI8S"}], [{"max": 37, "min": 63, "name": "8yIq2LAN"}, {"max": 70, "min": 57, "name": "5YtubLTa"}, {"max": 52, "min": 78, "name": "2Y5L35ZN"}], [{"max": 34, "min": 13, "name": "HAjlZWZs"}, {"max": 87, "min": 94, "name": "d9dimnPL"}, {"max": 46, "min": 71, "name": "UAInCnmb"}]], "has_combination": true, "role_flexing_enable": false, "role_flexing_player": 24, "role_flexing_second": 29}, "maxNumber": 80, "minNumber": 26, "playerMaxNumber": 90, "playerMinNumber": 5}, "alliance_flexing_rule": [{"combination": {"alliances": [[{"max": 14, "min": 27, "name": "a1Mri3xM"}, {"max": 13, "min": 53, "name": "ShBSCnpG"}, {"max": 30, "min": 95, "name": "uVr3VcLP"}], [{"max": 45, "min": 7, "name": "BqKNLt2L"}, {"max": 16, "min": 91, "name": "onCKWs8L"}, {"max": 72, "min": 16, "name": "IP9QQ1va"}], [{"max": 42, "min": 10, "name": "1vHcKNe4"}, {"max": 56, "min": 24, "name": "7JodQloy"}, {"max": 19, "min": 29, "name": "aEBdQiO5"}]], "has_combination": false, "role_flexing_enable": true, "role_flexing_player": 86, "role_flexing_second": 48}, "duration": 72, "max_number": 24, "min_number": 39, "player_max_number": 11, "player_min_number": 14}, {"combination": {"alliances": [[{"max": 79, "min": 78, "name": "acYQiC02"}, {"max": 60, "min": 53, "name": "Nr4b7P9Q"}, {"max": 31, "min": 6, "name": "nHA2tmS4"}], [{"max": 2, "min": 91, "name": "vOiF2H2b"}, {"max": 80, "min": 96, "name": "u1rOk5FJ"}, {"max": 87, "min": 69, "name": "zc9xHe3k"}], [{"max": 49, "min": 95, "name": "Ba4GtAt4"}, {"max": 77, "min": 34, "name": "kfbRJxYg"}, {"max": 75, "min": 59, "name": "hDhnlHeK"}]], "has_combination": true, "role_flexing_enable": false, "role_flexing_player": 62, "role_flexing_second": 56}, "duration": 71, "max_number": 69, "min_number": 100, "player_max_number": 55, "player_min_number": 11}, {"combination": {"alliances": [[{"max": 52, "min": 89, "name": "y9UJhba4"}, {"max": 5, "min": 3, "name": "Ufc0ZmB9"}, {"max": 38, "min": 51, "name": "640yXgBC"}], [{"max": 62, "min": 35, "name": "03665VRH"}, {"max": 96, "min": 6, "name": "OzpcnIpT"}, {"max": 4, "min": 16, "name": "4aEwuzXP"}], [{"max": 51, "min": 1, "name": "B58Lov5M"}, {"max": 9, "min": 31, "name": "PC877D88"}, {"max": 23, "min": 41, "name": "VQqxA3aa"}]], "has_combination": true, "role_flexing_enable": false, "role_flexing_player": 33, "role_flexing_second": 33}, "duration": 39, "max_number": 73, "min_number": 27, "player_max_number": 68, "player_min_number": 81}], "batch_size": 0, "bucket_mmr_rule": {"disable_authority": true, "flex_authority_count": 5, "flex_flat_step_range": 57, "flex_immunity_count": 98, "flex_range_max": 33, "flex_rate_ms": 9, "flex_step_max": 93, "force_authority_match": false, "initial_step_range": 89, "mmr_max": 35, "mmr_mean": 19, "mmr_min": 7, "mmr_std_dev": 21, "override_mmr_data": false, "use_bucket_mmr": false, "use_flat_flex_step": true}, "flexingRules": [{"attribute": "xq9YgOOy", "criteria": "lm4pGw6o", "duration": 45, "reference": 0.6096231535347583}, {"attribute": "HFas9Tka", "criteria": "Jv6EUVA6", "duration": 90, "reference": 0.8687523341275876}, {"attribute": "rkdrfqev", "criteria": "lrkSqmZI", "duration": 81, "reference": 0.5283541527699089}], "match_options": {"options": [{"name": "vkU7n56i", "type": "0WZB3cfd"}, {"name": "EOCYKlr1", "type": "St2XYabE"}, {"name": "PUPPh2ld", "type": "QFPaqfNE"}]}, "matchingRules": [{"attribute": "NzXJlK4a", "criteria": "mS6duuTf", "reference": 0.15676014071891098}, {"attribute": "CM00wgrz", "criteria": "FhQ0Y2dT", "reference": 0.1337967018280457}, {"attribute": "SiDL3r1M", "criteria": "1nBO5brF", "reference": 0.6179536011924687}], "sort_ticket": {"search_result": "9LxQwFG4", "ticket_queue": "Vxu7DsWa"}, "sort_tickets": [{"search_result": "VeIRBzsN", "threshold": 33, "ticket_queue": "6ZdJhKEp"}, {"search_result": "HGG5zR9I", "threshold": 24, "ticket_queue": "OC7Zxl9M"}, {"search_result": "CvPL5pg3", "threshold": 64, "ticket_queue": "uSybSWeO"}], "sub_game_modes": {}, "ticket_flexing_selection": "RF4RdJZV", "ticket_flexing_selections": [{"selection": "vw8RIPvM", "threshold": 100}, {"selection": "5CkcWzif", "threshold": 11}, {"selection": "cSx4SgjC", "threshold": 38}], "use_newest_ticket_for_flexing": true}, "sessionQueueTimeoutSeconds": 59, "socialMatchmaking": true, "sub_gamemode_selection": "random", "ticket_observability_enable": true, "use_sub_gamemode": false}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op UpdateMatchmakingChannel \
    --channelName 'axcKcSJh' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 19 'UpdateMatchmakingChannel' test.out

#- 20 CleanAllMocks
$CLI_EXE \
    --sn matchmaking \
    --op CleanAllMocks \
    --channelName 'EyZF8cQg' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 20 'CleanAllMocks' test.out

#- 21 GetAllMockMatches
$CLI_EXE \
    --sn matchmaking \
    --op GetAllMockMatches \
    --channelName 'cEpk9FW4' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 21 'GetAllMockMatches' test.out

#- 22 GetMockMatchesByTimestamp
# body param: body
echo '{"timestamp_after": 75}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op GetMockMatchesByTimestamp \
    --channelName 'BaLVeSbq' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 22 'GetMockMatchesByTimestamp' test.out

#- 23 GetAllMockTickets
$CLI_EXE \
    --sn matchmaking \
    --op GetAllMockTickets \
    --channelName 'IsXNU38M' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 23 'GetAllMockTickets' test.out

#- 24 CreateMockTickets
# body param: body
echo '{"attribute_name": "bWfS7pVr", "count": 19, "mmrMax": 0.9887866091891757, "mmrMean": 0.5081929965685053, "mmrMin": 0.06573982024666092, "mmrStdDev": 0.3406707247940012}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op CreateMockTickets \
    --channelName 'x9trbbnh' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 24 'CreateMockTickets' test.out

#- 25 BulkCreateMockTickets
# body param: body
echo '[{"first_ticket_created_at": 9, "party_attributes": {"U9l458Ur": {}, "tzYxrPKD": {}, "Vx8cdb2G": {}}, "party_id": "BZwDHLc6", "party_members": [{"extra_attributes": {"srzShQkz": {}, "V1RkwLox": {}, "j4TzLiVK": {}}, "user_id": "cfuofshf"}, {"extra_attributes": {"GO7IDdHJ": {}, "B8lVv4XJ": {}, "Nc2dHeue": {}}, "user_id": "qow0wHDx"}, {"extra_attributes": {"TMGhvdzT": {}, "S8DgiLF0": {}, "SENDJ1TJ": {}}, "user_id": "dSPeI46e"}], "ticket_created_at": 24, "ticket_id": "b78tTjGE"}, {"first_ticket_created_at": 25, "party_attributes": {"5EUaLfYz": {}, "mHFG63Mt": {}, "fpFpzoqD": {}}, "party_id": "l0Df8zBQ", "party_members": [{"extra_attributes": {"O4D6NtUV": {}, "6hyPSDQu": {}, "90uw6W9L": {}}, "user_id": "S2v4PP6Z"}, {"extra_attributes": {"077BtwBY": {}, "XFAa1fY0": {}, "v22Ib3Ib": {}}, "user_id": "HgvyIk7w"}, {"extra_attributes": {"Caw3cR4b": {}, "eKAXV5KK": {}, "UUgqcQ81": {}}, "user_id": "ec1IzD2N"}], "ticket_created_at": 100, "ticket_id": "JqOSrCZQ"}, {"first_ticket_created_at": 74, "party_attributes": {"ImExBU15": {}, "5HQ5dpTS": {}, "G9Hc5Q40": {}}, "party_id": "UhC9LgYJ", "party_members": [{"extra_attributes": {"CMpxHgif": {}, "ORIlDGvB": {}, "zYoDUJef": {}}, "user_id": "b7cs71fl"}, {"extra_attributes": {"7zTbpy61": {}, "6WwlWieD": {}, "JlUZXQv0": {}}, "user_id": "50MaPf0g"}, {"extra_attributes": {"ZLWbFNPR": {}, "h09I2TJU": {}, "A7kQTD6P": {}}, "user_id": "9rwBr0SA"}], "ticket_created_at": 6, "ticket_id": "lw7HaO4h"}]' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op BulkCreateMockTickets \
    --channelName 'RBe09FBi' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 25 'BulkCreateMockTickets' test.out

#- 26 GetMockTicketsByTimestamp
# body param: body
echo '{"timestamp_after": 80}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op GetMockTicketsByTimestamp \
    --channelName 'X1vwDwu0' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 26 'GetMockTicketsByTimestamp' test.out

#- 27 GetAllPartyInChannel
$CLI_EXE \
    --sn matchmaking \
    --op GetAllPartyInChannel \
    --channelName 'bdf1FetP' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 27 'GetAllPartyInChannel' test.out

#- 28 GetAllSessionsInChannel
$CLI_EXE \
    --sn matchmaking \
    --op GetAllSessionsInChannel \
    --channelName 'Pu92Uekl' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 28 'GetAllSessionsInChannel' test.out

#- 29 AddUserIntoSessionInChannel
# body param: body
echo '{"blocked_players": ["XoUmJtqj", "4wWH89BI", "0Guu1HSH"], "party_id": "6GxMubZW", "user_id": "Xqpk3aJk"}' > $TEMP_JSON_INPUT
$CLI_EXE \
    --sn matchmaking \
    --op AddUserIntoSessionInChannel \
    --channelName '0z0oUd9T' \
    --matchID 'Yhk4lDiS' \
    --namespace $AB_NAMESPACE \
    --reqfile $TEMP_JSON_INPUT \
    > test.out 2>&1
eval_tap $? 29 'AddUserIntoSessionInChannel' test.out

#- 30 DeleteSessionInChannel
$CLI_EXE \
    --sn matchmaking \
    --op DeleteSessionInChannel \
    --channelName '3S2JQQSI' \
    --matchID 'm6ZzD3kA' \
    --namespace $AB_NAMESPACE \
    > test.out 2>&1
eval_tap $? 30 'DeleteSessionInChannel' test.out

#- 31 DeleteUserFromSessionInChannel
$CLI_EXE \
    --sn matchmaking \
    --op DeleteUserFromSessionInChannel \
    --channelName 'DOUXdWMR' \
    --matchID 'ZZFHddKV' \
    --namespace $AB_NAMESPACE \
    --userID 'mfjBi2fd' \
    > test.out 2>&1
eval_tap $? 31 'DeleteUserFromSessionInChannel' test.out

#- 32 GetStatData
$CLI_EXE \
    --sn matchmaking \
    --op GetStatData \
    --channelName 'XYjjU1W5' \
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
    --channelName 'AWpDAWtX' \
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