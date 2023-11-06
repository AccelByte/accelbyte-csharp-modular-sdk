#!/usr/bin/env bash

set -e
set -o pipefail

SERVICE_API_KEY=$1
test -n "$SERVICE_API_KEY" || (echo "SERVICE_API_KEY is not set"; exit 1)

SERVICE_API_NAME=`echo $SERVICE_API_KEY | sed -r 's/(^|_)([a-z])/\U\2/g'`
CONFIG_KEY="Api"$SERVICE_API_NAME"Version"
LAST_TAG=`git tag --list "api-"$SERVICE_API_KEY"/*" --sort -version:refname | tail -n 1`
LAST_COMMIT=`git log --format="%H" -n 1`

CHANGE_COUNT=`git diff --name-only $LAST_TAG | { grep -c "apis/AccelByte.Sdk.Api."$SERVICE_API_NAME"/version.txt" || test $? = 1; } | { grep -v grep || test $? = 1; }`
if [ $CHANGE_COUNT -gt 0 ]; then
    echo $SERVICE_API_KEY

    VERSION_INFO=`cat "apis/AccelByte.Sdk.Api."$SERVICE_API_NAME"/version.txt" | tail -n 1`
    echo -e "\t New version: "$VERSION_INFO

    NEW_TAG="api-"$SERVICE_API_KEY"/v"$VERSION_INFO
    echo -e "\t New tag: "$NEW_TAG

    git tag $NEW_TAG $LAST_COMMIT
fi