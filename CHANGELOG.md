<a name="v0.32.0"></a>
## [v0.32.0]
### feat
- **core:** added json serialization options and its test
- **core:** added support for custom flags and events
- **auth:** enable on-demand refresh token
- **test:** added integration test for on-demand refresh token
- **mock-server:** change jenkinfile for new mock-server path
- **integration:** add lobby presence tests
- **:** added parse access token function
### docs
- **migration:** added migration info for on-demand refresh token
### fix
- **core:** add missing request json options in http clients
- **compat:** add missing constructors for sdk class
- **integration:** fix get match pool detail integration tests
- **integration:** use admin delete session endpoint for session browser test
- **integration:** try to make lobby presence integration test more reliable
- **ams:** fix ams integration test due to op renaming
- **lobby:** disable lobby presence integration test temporarily
- **integration:** fix ams integration test due to spec changes
### chore
- **sdk:** generated from openapi spec commit: f131e5930c5a8dc3e43bb4f3306baafe7080c3cf
- **sdk:** generated from openapi spec commit: bc8b66d4a19d67ece6b906c42e187cd5d70c747b
- **:** regenerate all services


<a name="v0.32.0"></a>
## [v0.32.0]
### feat
- **core:** added json serialization options and its test
- **core:** added support for custom flags and events
- **auth:** enable on-demand refresh token
- **test:** added integration test for on-demand refresh token
- **mock-server:** change jenkinfile for new mock-server path
- **integration:** add lobby presence tests
### docs
- **migration:** added migration info for on-demand refresh token
### fix
- **core:** add missing request json options in http clients
- **compat:** add missing constructors for sdk class
- **integration:** fix get match pool detail integration tests
- **integration:** use admin delete session endpoint for session browser test
- **integration:** try to make lobby presence integration test more reliable
- **ams:** fix ams integration test due to op renaming
- **lobby:** disable lobby presence integration test temporarily
### chore
- **sdk:** generated from openapi spec commit: f131e5930c5a8dc3e43bb4f3306baafe7080c3cf


<a name="v0.32.0"></a>
## [v0.32.0]
### feat
- **core:** added json serialization options and its test
- **core:** added support for custom flags and events
- **auth:** enable on-demand refresh token
- **test:** added integration test for on-demand refresh token
- **mock-server:** change jenkinfile for new mock-server path
- **integration:** add lobby presence tests
### docs
- **migration:** added migration info for on-demand refresh token
### fix
- **core:** add missing request json options in http clients
- **compat:** add missing constructors for sdk class
- **integration:** fix get match pool detail integration tests
- **integration:** use admin delete session endpoint for session browser test


<a name="v0.31.1"><a>
## [v0.31.1]
- Hotfix: fixed image size model's property for DSMC service.

<a name="v0.31.0"></a>
## [v0.31.0]
- Removed title matchmaking sample app.
- Updated Basic and Session service integration tests.
- Fixed refresh token integration test.

<a name="v0.30.0"></a>
## [v0.30.0]
- Updated documentations due to name change.

<a name="v0.29.0"></a>
## [v0.29.0]
- API models and endpoints changed. See affected items [here](https://github.com/AccelByte/accelbyte-csharp-sdk/blob/main/docs/migration-guides/migration-guide-v0.28-to-v0.29.md)
- Updated AWS Lambda sample app to allow both local tests and FunctionURL invocation.
- Update Lobby integration tests.
- Fixed some minor defects detected by Coverity Scan.
- Added reporting service integration test.

<a name="v0.28.0"></a>
## [v0.28.0]
- Changed operation's static var for builder object to static property.
- Added new generic method for operation that has response with object data type in it.

<a name="v0.27.0"></a>
## [v0.27.0]
- Updated local OAuth Client token validation.
- Fixed Platform integration tests.

<a name="v0.26.0"></a>
## [v0.26.0]
- Fixed MatchV2 integration test for MatchPool.
- Added local OAuth Client token validation (PREVIEW FEATURE).

<a name="v0.25.0"></a>
## [v0.25.0]
- Fixed deprecated messages.

<a name="v0.24.0"></a>
## [v0.24.0]
- Added Create User V3 integration test.
- Namespace changed for some endpoints. See affected endpoint's [here](https://github.com/AccelByte/accelbyte-csharp-sdk/blob/main/docs/migration-guides/migration-guide-v0.23-to-v0.24.md)

<a name="v0.23.0"></a>
## [v0.23.0]
- Added [getting started](samples/AccelByte.Sdk.Sample.GettingStarted) sample app.
- Added OpenAPI 2.0 vendor extension [information](spec/openapi-2.0-vendor-extensions.md).
- Make `AB_APP_NAME` optional in `DefaultConfigRepository`.
- Updated OIDC integration test.

<a name="v0.22.0"></a>
## [v0.22.0]
- Added new Matchmaking V2 API
- Added new Session API
- Added integration tests for both Matchmaking V2 and Session API.
- Updated APIs
	- dslogmanager:
		- updated endpoints
	- dsmc
		- updated endpoints
		- updated model
	- iam
		- added new endpoints
		- updated endpoints
	- matchmaking
		- updated endpoints
	- platform
		- updated models
		- **BREAKING CHANGE** `OptionBoxItem` changed to `EntitlementLootBoxReward`
		- **BREAKING CHANGE** `TrackedEntitlementInfo` changed to `EntitlementDecrementResult`
		- **BREAKING CHANGE** `PlayStationReconcileResult` changed to `LootBoxReward`
		- updated endpoints
	- seasonpass
		- updated model

<a name="v0.21.2"></a>
## [v0.21.2]
- Hotfix: revert breaking change on `TelemetryBody` model in gametelemetry API.

<a name="v0.21.1"></a>
## [v0.21.1]
- Hotfix: revert breaking change on `ModelsUserAchievementResponse` model in achievement API.

<a name="v0.21.0"></a>
## [v0.21.0]
- Updated getting started document.
- Fixed HTTP Clients that always send empty body on GET request.

<a name="v0.20.0"></a>
## [v0.20.0]
- Fixed HTTP Clients to handle upload stream handling.
- **BREAKING CHANGE** Fixed operation's response to output `Stream` object for most of export endpoints.

<a name="v0.19.0"></a>
## [v0.19.0]
- Changed doc folder structure.
- **BREAKING CHANGE** IAM TokenGrantV3 operation's response has changed from `OauthmodelTokenResponseV3` to `OauthmodelTokenWithDeviceCookieResponseV3`.
- **BREAKING CHANGE** `ITokenRepository` interface introduce new methods to accomodate `OauthmodelTokenWithDeviceCookieResponseV3`.

<a name="v0.18.0"></a>
## [v0.18.0]
- Fixed issues detected by coverity scan
- Fixed service integration tests due to retry policy used by all request that expect exception.
- Replaced deprecated operations in IAM service integration tests.
- Fixed WS CLI issues when running on specific AMI image used by jenkins worker.

<a name="v0.17.0"></a>
## [v0.17.0]
- Added Tic Tac Toe sample apps (Local Server, Game Client, and AWS Lambda)
- Fixed awesome message parsing
- Moved integration tests into different classes respective to AB Cloud service name
- Added common use cases documents [here](docs/common_use_cases.md)

<a name="v0.16.0"></a>
## [v0.16.0]
- Fixed bug on web socket execute routing in CLI sample app
- Added web socket interactive mode in CLI sample app
- Added Title Matchmaking sample apps (AWS Lambda, Local Server, and Client)
- Added Json file configuration and credential repository

<a name="v0.15.0"></a>
## [v0.15.0]
- Added integration test for SeasonPass
- Added integration test for QoSM
- Switch public HttpBin with locally deployed HttpBin image for core tests
- **POSSIBLE BREAKING CHANGE** Moved all deprecated operations back from its own namespace respective to each service.

<a name="v0.14.0"></a>
## [v0.14.0]
- Updated APIs
	- achievement
		- updated endpoints
	- cloudsave
		- updated endpoints
	- dsmc
		- updated model
	- eventlog
		- updated endpoints
	- gametelemetry
		- added new endpoints
	- gdpr
		- updated endpoints
	- group
		- updated endpoints
	- iam
		- added new endpoints
		- updated endpoints
	- leaderboard
		- updated endpoints
	- legal
		- updated endpoints
	- platform		
		- added new endpoints
		- updated endpoints
	- seasonpass
		- updated endpoints
	- social
		- updated endpoints
	- ugc
		- updated endpoints
		- added new endpoints

<a name="v0.13.0"></a>
## [v0.13.0]
- Fixed automatic token refresh performance issue.
- Added scheduled token refresh as an alternative to automatic token refresh.
- Added Platform login feature.
- Added OIDC sample web app.
- **BREAKING CHANGE** Moved all deprecated operations into its own namespace respective to each service.
- **POSSIBLE BREAKING CHANGE** There are some deprecated endpoints in IAM service.
- Added new endpoints in Platform service.
- Updated CLI sample app due to token refresh support and deprecation change.

<a name="v0.12.0"></a>
## [v0.12.0]
- Fixed basic user profile integration tests
- Updated gametelemetry integration test
- Updated APIs
	- basic
		- updated endpoints
		- updated model
	- dslogmanager
		- updated endpoints
	- dsmc
		- updated endpoints
	- group
		- updated model
	- iam
		- updated model
		- updated endpoints
	- legal
		- updated endpoints		
	- platform
		- updated models
		- added new endpoints
		- updated endpoints
	- seasonpass
		- updated models
	- social
		- updated models
	- ugc
		- updated model
		- updated endpoints

<a name="v0.11.0"></a>
## [v0.11.0]
- Implemented token auto refresh
- Updated APIs
	- achievement
		- updated endpoints
	- cloudsave
		- added new endpoints
		- updated endpoints
	- dsmc
		- updated endpoints
	- iam
		- updated models
		- updated endpoints
	- lobby
		- added new endpoints
	- platform
		- updated models
	- seasonpass
		- added new endpoints
		- updated models
		- updated endpoints

<a name="v0.10.0"></a>
## [v0.10.0]
- Implemented enum patches in operation's parameter
	- Possible **BREAKING CHANGES**
- Updated operation indexes
- Updated APIs
	- lobby
		- updated endpoints
		- **BREAKING CHANGES**
			- `ModelRequestFriendsRequest` replaced by `ModelUserRequestFriendRequest`

<a name="v0.9.0"></a>		
## [v0.9.0]
- Implemented enum in operation's parameter
	- Possible **BREAKING CHANGES**.
- `StringEnum::Create` function is renamed to `StringEnum::NewValue`.
- Updated APIs
	- dsmc
		- updated models
	- gametelemetry
		- updated endpoints
	- iam
		- updated models
	- platform
		- added new endpoints
		- updated endpoints
		- deprecation notice for some of wallet endpoints
	- ugc
		- updated endpoint

<a name="v0.8.0"></a>
## [v0.8.0]
- Updated core unit tests.
- Moved cli tests to cli project's folder.
- Updated APIs.
	- iam
		- updated endpoints
	- matchmaking
		- updated endpoints
	- platform
		- added new endpoints
		- updated endpoints
	- sessionbrowser
		- added new endpoints
	- social
		- added new endpoints
		- updated endpoints
	- ugc
		- updated endpoints

<a name="v0.7.0"></a>
## [v0.7.0]
- Added support for cookie parameters
- Added fluent interface as an alternative way to access operations and wrappers object directly from sdk object.
- Updated integration tests.
- Updated readme and operation indexes.
- Updated APIs.
	- gametelemetry
		- updated endpoints (exposed optional cookie authentication)
	- iam
		- updated endpoints
		- **BREAKING CHANGES**
			- `PublicRemoveTrustedDeviceV4` now required device token to be specified.
	- platform
		- added new endpoints
	- ugc
		- added new endpoint.

<a name="v0.6.0"></a>
## [v0.6.0]
- Updated integration tests.
- Renamed some operation wrappers for better clarity.
- Updated readme file.
- Added operation indexes at [docs](docs).
- Updated APIs.
	- cloudsave:
		- added new endpoints.
	- dslogmanager:
		- **BREAKING CHANGES**
			- Renamed wrapper Operations class to DslogmanagerOperations.
	- dsmc
		- **BREAKING CHANGES**
			- Renamed wrapper Operations class to DsmcOperations.
	- gametelemetry
		- added new endpoints.
		- **BREAKING CHANGES**
			- Renamed wrapper Operations class to GametelemetryOperations.
	- iam
		- updated endpoints.
	- legal
		- updated endpoints.
	- lobby
		- updated models.
		- **BREAKING CHANGES**
			- Renamed wrapper Operations class to LobbyOperations.
	- matchmaking
		- updated models.
		- **BREAKING CHANGES**
			- Renamed wrapper Operations class to MatchmakingOperations.
	- platform
		- updated endpoints.
	- ugc
		- updated endpoints.
		- added new endpoints.

<a name="v0.5.0"></a>
## [v0.5.0]
- Fixed some of integration tests.
- Added new integration tests for legal service.
- Updated APIs.
	- cloudsave:
		- added new endpoints.
		- updated endpoints.
		- added models.
		- updated models.
		- BREAKING CHANGES (deleted some models related to game reord and player record).
	- dslogmanager:
		- updated models.
	- iam
		- added new endpoints.
		- added models.
		- updated endpoints.
	- legal
		- added new endpoint.
		- updated endpoints.
	- lobby
		- added new endpoints.
		- updated endpoints.
		- updated models.
		- BREAKING CHANGES (deleted some endpoints related to export/import config).
	- platform
		- updated models.
	- sessionbrowser
		- updated endpoints.
	- ugc
		- updated endpoints.

<a name="v0.4.0"></a>
## [v0.4.0]
- Added AWS Lambda sample app. See it's README in samples/AccelByte.Sdk.Sample.Aws.Lambda
- Added integration tests.
- Enabled builder pattern for creating AccelByteSDK object.
- Added optional credential repository to store credential used by client.
- Added logging feature (disabled by default).
- Fixed awesome message parsing.
- Updated APIs.
	- iam:
		- added new endpoints.
		- updated some endpoints.
	- lobby: updated endpoints.
	- platform: updated endpoints.

<a name="v0.3.0"></a>
## [v0.3.0]
- Added lobby service feature.
- Added amazon trace id in every request.
- Added user agent info in every request.
- Added app name in config repository.
- Enabled builder pattern in operation classes.
- Updated APIs.
	- dsmc: added new endpoints.
	- platform: added new endpoints

<a name="v0.2.0"></a>
## [v0.2.0]
- Added CLI sample application.
- Updated tests.
- Added file extension to MIME type converter for file upload.
- Updated APIs.
	- Added summary on each operation
	- iam: added new parameter in TokenGrantV3
	- lobby: added new endpoint.
	- platform: 
		- added new endpoints.
		- updated endpoints.
	- seasonpass: added new endpoint.
	- social: added new endpoint.

<a name="v0.1.0"></a>
## [v0.1.0]

Initial release of C# SDK for AccelByte platform.

Supported APIs:

- achievement
- basic
- cloudsave
- dslogmanager
- dsmc
- eventlog
- gametelemetry
- gdpr
- group
- iam
- leaderboard
- legal
- lobby
- matchmaking
- platform
- qosm
- seasonpass
- sessionbrowser
- social
- ugc
