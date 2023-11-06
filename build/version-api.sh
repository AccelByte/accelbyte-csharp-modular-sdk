#!/usr/bin/env bash

set -e
set -o pipefail

SERVICE_API_KEY=$1
test -n "$SERVICE_API_KEY" || (echo "SERVICE_API_KEY is not set"; exit 1)

SERVICE_API_NAME=`echo $SERVICE_API_KEY | sed -r 's/(^|_)([a-z])/\U\2/g'`
CONFIG_KEY="Api"$SERVICE_API_NAME"Version"

echo $SERVICE_API_KEY

# count changed files based in specified api directory with git diff
CHANGE_COUNT=$(git diff --name-only | { grep -c "apis/AccelByte.Sdk.Api."$SERVICE_API_NAME || test $? = 1; } | { grep -v grep || test $? = 1; })
if [ $CHANGE_COUNT -gt 0 ]; then
    echo -e "\t Changes: "$CHANGE_COUNT
    LAST_VERSION=`cat build/version.props | grep -oP "(?<=<"$CONFIG_KEY">)([a-zA-Z0-9\.]*)"`
    echo -e "\t Last version: "$LAST_VERSION

    # bump minor version only
    VERSION_NEW=`echo $LAST_VERSION | awk -v part=2 -F . '{OFS="."; $part+=1; print $0}'`
    echo -e "\t New version: "$VERSION_NEW

    # update version.props file for specified api
    sed -i "s@<"$CONFIG_KEY">[0-9]\+\.[0-9]\+\.[0-9]\+</"$CONFIG_KEY">@<"$CONFIG_KEY">$VERSION_NEW</"$CONFIG_KEY">@" build/version.props

    # rewrite version.txt file in api directory
    echo $VERSION_NEW > "apis/AccelByte.Sdk.Api."$SERVICE_API_NAME"/version.txt"
else
    echo -e "\t No changes"    
fi

