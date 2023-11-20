#!/usr/bin/env bash

set -e
set -o pipefail

AGS_VERSION=$1
test -n "$AGS_VERSION" || (echo "AGS_VERSION is not set"; exit 1)

# Pick selected nupkg file which correspond to AGS version tag since `make pack` will create all packages.
mkdir -p .publish_pick

# Get api- tag only
git tag --contains $(git rev-list -n 1 "ags/v$AGS_VERSION") | grep -v "ags/v$AGS_VERSION" | sed -nr "s/api-(\S*)\/v(\S*)/\1|\2/p" | while read line
do    
    SERVICE_KEY=$(echo $line | cut -f1 -d'|')
    SERVICE_VER=$(echo $line | cut -f2 -d'|')
    SERVICE_API_NAME=`echo $SERVICE_KEY | sed -r 's/(^|_)([a-z])/\U\2/g'`

    PKG_NAME="AccelByte.Sdk.Api."$SERVICE_API_NAME"."$SERVICE_VER".nupkg"
    cp ".publish/"$PKG_NAME .publish_pick/
    echo $PKG_NAME
done

# Get non api (core/feature modules) tag
find . -type f -path "./AccelByte.Sdk.*/module.txt" | while read line
do
    SERVICE_PKG_NAME=$(echo $line | sed -nr "s/.\/(\S*)\/(\S*)/\1/p")
    SERVICE_TAG_PREFIX=$(cat $line)
    SERVICE_VER=$(git tag --contains $(git rev-list -n 1 "ags/v$AGS_VERSION") | grep "$SERVICE_TAG_PREFIX" | sed -nr "s/(\S*)\/v(\S*)/\2/p")
    
    PKG_NAME=$SERVICE_PKG_NAME"."$SERVICE_VER".nupkg"
    cp ".publish/"$PKG_NAME .publish_pick/
    echo $PKG_NAME
done