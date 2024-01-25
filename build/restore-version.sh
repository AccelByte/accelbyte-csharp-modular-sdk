#!/usr/bin/env bash

set -e
set -o pipefail

find spec -type f -iname '*.json' | sort | grep -oP '(?<=/)\w+(?=.json)' | while read line
do
    SERVICE_API_NAME=`echo $line | sed -r 's/(^|_)([a-z])/\U\2/g'`
    CONFIG_KEY="Api"$SERVICE_API_NAME"Version"

    echo $line
    echo -e "\t"$SERVICE_API_NAME
    echo -e "\t"$CONFIG_KEY

    LAST_VERSION=`cat build/version.props | grep -oP "(?<=<"$CONFIG_KEY">)([a-zA-Z0-9\.]*)"`
    echo -e "\tVersion: "$LAST_VERSION

    echo $LAST_VERSION > "apis/AccelByte.Sdk.Api."$SERVICE_API_NAME"/version.txt"
done