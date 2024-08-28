# Copyright (c) 2021 AccelByte Inc. All Rights Reserved.
# This is licensed software from AccelByte Inc, for limitations
# and restrictions contact your company contract manager.

SHELL := /bin/bash

DOTNETVER := 6.0.302

.PHONY: build

build:
	docker run --rm -u $$(id -u):$$(id -g) -v $$(pwd):/data/ -w /data/ -e HOME="/data" -e DOTNET_CLI_HOME="/data" mcr.microsoft.com/dotnet/sdk:6.0 dotnet build

# Core and mock-required unit tests
test_core:
	@test -n "$(SDK_MOCK_SERVER_PATH)" || (echo "SDK_MOCK_SERVER_PATH is not set" ; exit 1)
	trap "docker stop justice-codegen-sdk-mock-server justice-codegen-sdk-httpbin" EXIT && \
			docker run --rm -d --name justice-codegen-sdk-httpbin -p 80:80 kennethreitz/httpbin && \
			(bash "$(SDK_MOCK_SERVER_PATH)/mock-server.sh" -s /data/spec &) && \
			(for i in $$(seq 1 10); do curl http://localhost:8080/ 2>/dev/null && exit 0 || sleep 10; done; exit 1) && \
			docker run --rm -u $$(id -u):$$(id -g) -v $$(pwd):/data/ -w /data/ --network host -e AB_HTTPBIN_URL=http://localhost -e HOME="/data" -e DOTNET_CLI_HOME="/data" mcr.microsoft.com/dotnet/sdk:$(DOTNETVER) dotnet test && \
			docker run --rm -u $$(id -u):$$(id -g) -v $$(pwd):/data/ -w /data/ --network host -e AB_HTTPBIN_URL=http://localhost -e HOME="/data" -e DOTNET_CLI_HOME="/data" mcr.microsoft.com/dotnet/sdk:$(DOTNETVER) dotnet test --filter="TestCategory=MockServerTests"

# CLI sample app tests against mock-server
test_cli:
	@test -n "$(SDK_MOCK_SERVER_PATH)" || (echo "SDK_MOCK_SERVER_PATH is not set" ; exit 1)
	rm -f test.err
	docker run --rm -u $$(id -u):$$(id -g) -v $$(pwd):/data/ -w /data/ -e HOME="/data" -e DOTNET_CLI_HOME="/data" mcr.microsoft.com/dotnet/sdk:$(DOTNETVER) dotnet publish -r linux-x64
	trap "docker stop justice-codegen-sdk-mock-server justice-codegen-sdk-ws-mock-server" EXIT && \
			(bash "$(SDK_MOCK_SERVER_PATH)/mock-server.sh" -s /data/spec -l DEBUG &) && \
			(SPEC_DIR=/data/spec bash "$(SDK_MOCK_SERVER_PATH)/ws/ws-mock-server.sh" &) && \
			(for i in $$(seq 1 10); do curl http://localhost:8080/ 2>/dev/null && exit 0 || sleep 10; done; exit 1) && \
			sed -i "s/\r//" samples/AccelByte.Sdk.Sample.Cli/tests/* && \
			rm -f samples/AccelByte.Sdk.Sample.Cli/tests/*.tap && \
			(for FILE in $$(ls samples/AccelByte.Sdk.Sample.Cli/tests/*.sh); do \
					(set -o pipefail; PATH="samples/AccelByte.Sdk.Sample.Cli/bin/Debug/net6.0/linux-x64/publish:$$PATH" bash $$FILE | tee "$${FILE}.tap") || touch test.err; \
			done)
	[ ! -f test.err ]

# Integration tests against AGS environment
test_integration:
	@test -n "$(ENV_FILE_PATH)" || (echo "ENV_FILE_PATH is not set" ; exit 1)
	bash -c 'docker run --rm -u $$(id -u):$$(id -g) -v $$(pwd):/data/ -w /data/ --network host -e HOME="/data" -e DOTNET_CLI_HOME="/data" --env-file "$(ENV_FILE_PATH)" mcr.microsoft.com/dotnet/sdk:$(DOTNETVER) \
		dotnet test --nologo --filter "TestCategory=ServiceIntegration" --verbosity n'

test_broken_link:
	@test -n "$(SDK_MD_CRAWLER_PATH)" || (echo "SDK_MD_CRAWLER_PATH is not set" ; exit 1)
	rm -f test.err
	bash "$(SDK_MD_CRAWLER_PATH)/md-crawler.sh" -i README.md
	DOCKER_SKIP_BUILD=1 bash "$(SDK_MD_CRAWLER_PATH)/md-crawler.sh" -i CHANGELOG.md
	(for FILE in $$(find docs -type f); do \
			(set -o pipefail; DOCKER_SKIP_BUILD=1 bash "$(SDK_MD_CRAWLER_PATH)/md-crawler.sh" -i $$FILE) || touch test.err; \
	done)
	DOCKER_SKIP_BUILD=1 bash "$(SDK_MD_CRAWLER_PATH)/md-crawler.sh" -i "https://docs.accelbyte.io/gaming-services/services/extend/extend-sdk/getting-started-with-the-extend-sdk/"
	[ ! -f test.err ]

#version:
#	if [ -n "$$MAJOR" ]; then VERSION_PART=1; elif [ -n "$$PATCH" ]; then VERSION_PART=3; else VERSION_PART=2; fi &&	# Bump minor version if MAJOR or MINOR is not set \
#			VERSION_OLD=$$(cat version.txt | tr -d '\n') && \
#			VERSION_NEW=$$(awk -v part=$$VERSION_PART -F. "{OFS=\".\"; \$$part+=1; print \$$0}" version.txt) && \
#			echo $${VERSION_NEW} > version.txt &&	# Bump version.txt \
#			sed -i "s@<Version>[0-9]\+\.[0-9]\+\.[0-9]\+</Version>@<Version>$$VERSION_NEW</Version>@" AccelByte.Sdk/AccelByte.Sdk.csproj &&		# Bump SDK \
#			sed -i "s@<AssemblyVersion>[0-9]\+\.[0-9]\+\.[0-9]\+</AssemblyVersion>@<AssemblyVersion>$$VERSION_NEW</AssemblyVersion>@" AccelByte.Sdk/AccelByte.Sdk.csproj &&		# Bump SDK \
#			sed -i "s@Include="AccelByte.Sdk" Version="[0-9]\+\.[0-9]\+\.[0-9]\+"@Include="AccelByte.Sdk" Version="$$VERSION_OLD"@" AccelByte.Sdk/AccelByte.Sdk.csproj			# Bump getting-started sample app

version_api:
	find spec -type f -iname '*.json' | grep -oP '(?<=/)\w+(?=.json)' | xargs -I{} sh -c './build/version-api.sh {} || exit 255'

tag_api:
	find spec -type f -iname '*.json' | grep -oP '(?<=/)\w+(?=.json)' | xargs -I{} sh -c './build/tag-api.sh {} || exit 255'

tag_ags:
	@test -n "$(AGS_VER)" || (echo "AGS_VER is not set" ; exit 1)
	@echo "AGS version: "$(AGS_VER)
	git fetch origin
	@if git rev-parse "ags/v$(AGS_VER)" >/dev/null 2>&1; then \
		echo "AGS tag already exists!"; exit 1; \
		else \
			LAST_COMMIT=$(git log --format="%H" -n 1); \
			git tag "ags/v$(AGS_VER)" $$LAST_COMMIT; \
	fi

push_tags:
	@test -n "$(AGS_VER)" || (echo "AGS_VER is not set" ; exit 1)
	@echo "AGS version: "$(AGS_VER)
	@if git rev-parse "ags/v$(AGS_VER)" >/dev/null 2>&1; then \
		git tag --contains $$(git rev-list -n 1 'ags/v$(AGS_VER)') | \
			grep -v 'ags/v$(AGS_VER)' | \
			xargs -I{} sh -c 'git push origin {} || exit 255'; \
		git push origin ags/v$(AGS_VER); \
	else \
		echo "AGS tag does not exists!"; exit 1; \
	fi

pack:
	docker run --rm -u $$(id -u):$$(id -g) \
		-v $$(pwd):/data/ \
		-w /data/ \
		-e HOME="/data" \
		-e DOTNET_CLI_HOME="/data" \
		mcr.microsoft.com/dotnet/sdk:$(DOTNETVER) \
		dotnet pack --configuration Release --output ./.publish

pack_pick:
	@test -n "$(AGS_VER)" || (echo "AGS_VER is not set" ; exit 1)
	@echo "AGS version: "$(AGS_VER)
	@if git rev-parse "ags/v$(AGS_VER)" >/dev/null 2>&1; then \
		./build/pack-pick.sh $(AGS_VER); \
	else \
		echo "AGS tag does not exists!"; exit 1; \
	fi

pack_push_only:
	@test -n "$(NUGET_API_KEY)" || (echo "NUGET_API_KEY is not set" ; exit 1)
	docker run --rm -u $$(id -u):$$(id -g) \
		-v $$(pwd):/data/ \
		-w /data/ \
		-e HOME="/data" \
		-e DOTNET_CLI_HOME="/data" \
		mcr.microsoft.com/dotnet/sdk:$(DOTNETVER) \
		dotnet nuget push "./.publish_pick/*.nupkg" --skip-duplicate --api-key "$(NUGET_API_KEY)" --source "https://api.nuget.org/v3/index.json"

outstanding_deprecation:
	find * -type f -iname '*.cs' \
		| xargs awk ' \
			BEGIN { \
				count_ok = 0; \
				count_not_ok = 0; \
				"date +%s -d \"6 months ago\"" | getline limit_epoch; \
			} \
			match($$0,/\[Obsolete\("([0-9]{4}-[0-9]{1,2}-[0-9]{1,2})/,since_date) { \
				"date +%s -d " since_date[1] | getline since_epoch; \
				if (limit_epoch < since_epoch) { \
					count_ok += 1; \
					print "ok - " FILENAME ":" $$0; \
				} \
				else { \
					count_not_ok += 1; \
					print "not ok - " FILENAME ":" $$0; \
				} \
			}	\
			END {	\
				exit (count_not_ok ? 1 : 0); \
			}' \
		| tee outstanding_deprecation.out
	@echo 1..$$(grep -c '^\(not \)\?ok' outstanding_deprecation.out)

prep_release:
	@test -n "$(AGS_VER)" || (echo "AGS_VER is not set" ; exit 1)
        @echo "AGS version: "$(AGS_VER)
	git fetch origin
	make tag_api
	make tag_ags AGS_VER=$(AGS_VER)
	# make push_tags # need more test
	make pack
	make pack_pick AGS_VER=$(AGS_VER)
