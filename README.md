# AccelByte Modular .NET (C#) SDK

> :warning: **This [accelbyte-csharp-modular-sdk](https://github.com/AccelByte/accelbyte-csharp-modular-sdk) 
> is not to be confused with [accelbyte-csharp-sdk](https://github.com/AccelByte/accelbyte-csharp-sdk):** 
> * The former (modular SDK) is **experimental** and is planned to be the sucessor for the latter (monolithic SDK).
> * The modular SDK allows developers to include only the required modules in projects.
> * If you are starting a new project, you may try to use modular SDK.
> * If you use monolithic SDK in an existing project, a migration path is available via compatibility layer in modular SDK.
> * Both monolithic and modular SDK will be maintained for some time to give time for migration until monolithic SDK is deprecated in the future.

A software development kit (SDK) for interacting with AccelByte Gaming Services (AGS) written in C#.

This SDK was generated from AGS OpenAPI spec files included in the [spec](spec) directory.

## Setup

This SDK requires .NET 8.0 SDK to be installed.

## Usage

```bash
# always include these package to use AccelByte .NET SDK
$ dotnet add package AccelByte.Sdk.Abstractions
$ dotnet add package AccelByte.Sdk.Core

# include this package to do authentication to AGS or token validation
$ dotnet add package AccelByte.Sdk.Authentication

# feature packages, these are optional
$ dotnet add package AccelByte.Sdk.Feature.AutoRefreshToken
$ dotnet add package AccelByte.Sdk.Feature.LocalTokenValidation

# Api packages. You can include only one or more packages depending on your need.
$ dotnet add package AccelByte.Sdk.Api.<ApiName>

# Compatibility layer. Use this package to enable compatibility layer with monolithic sdk version.
$ dotnet add package AccelByte.Sdk.Api.Compat
```

See the list of api packages [here](apis/).

### Environment Variables

The following environment variables need to be set when using `DefaultConfigRepository`.

| Name               | Required                                         | Example                          |
|--------------------|--------------------------------------------------|----------------------------------|
| `AB_BASE_URL`      | Yes                                              | https://test.accelbyte.io        |
| `AB_CLIENT_ID`     | Yes                                              | abcdef0123456789abcdef0123456789 |
| `AB_CLIENT_SECRET` | Yes, but only if you use a private `AB_CLIENT_ID`| ab#c,d)ef(ab#c,d)ef(ab#c,d)ef(ab |
| `AB_NAMESPACE`     | Yes                                              | accelbyte                        |

### Instantiation
    
```csharp
//Add core namespace
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Net.Http;
using AccelByte.Sdk.Core.Repository;

IAccelByteSdk sdk = AccelByteSdk.Builder
    .UseDefaultHttpClient()
    .UseDefaultConfigRepository() // Using DefaultConfigRepository, make sure the required environment variables are set
    .UseDefaultTokenRepository()
    .UseDefaultCredentialRepository() // Required if you want to load user's credential via environment variables.
    .UseDefaultTokenValidator() // Required if you want to use ValidateToken method.
    .Build();
```

## Login

### Login Using Username and Password

```csharp
bool login = sdk.LoginUser("myUsername", "myPassword");
if (!login)
{
    // Login failed  
}
```

### Login Using Username and Password with Defined Scopes

```csharp
bool login = sdk.LoginUser("myUsername", "myPassword", "<selected scopes>", null);
if (!login)
{
    // Login failed  
}
```

### Login Using Username and Password without Scopes

```csharp
bool login = sdk.LoginUser("myUsername", "myPassword", null, null);
if (!login)
{
    // Login failed  
}
```


### Login Using OAuth Client

```csharp
bool login = sdk.LoginClient();
if (!login)
{
    // Login failed  
}
```
> :warning: **Please use LoginClient() function with confidential OAuth client:** Using LoginClient() function with public OAuth client is not supported.

## Interacting with a Service Endpoint

As an example, we will get current user profile info using [getMyProfileInfo](https://docs.accelbyte.io/api-explorer/#Basic/getMyProfileInfo) endpoint available in [basic](https://docs.accelbyte.io/api-explorer/#Basic) service.

```csharp
//Add api namespace
using AccelByte.Sdk.Api;

//Add basic service model namespace
using AccelByte.Sdk.Api.Basic.Model;

// Login using username and password

bool login = sdk.LoginUser("myUsername", "myPassword");
if (!login)
{
    Console.WriteLine("Login failed");
}


// Make a call to getMyProfileInfo endpoint
var response = sdk.GetBasicApi().UserProfile.GetMyProfileInfoOp.Execute(sdk.Namespace);
if (response.IsSuccess && response.Data != null)
{
    UserProfilePrivateInfo profileData = response.Data;
        
    // do something with user profile data
    Console.WriteLine(response.UserId);
}
else
{
    //if call failed, get the error
    var error = response.Error;
    // do someting with call error.
}

/*
try
{
    // Or, use Ok() method to do use default error checking and get the response data directly
    // Ok() method will throw an exception if there is any error or if the data is null.
    UserProfilePrivateInfo profileData = sdk.GetBasicApi().UserProfile.GetMyProfileInfoOp.Execute(sdk.Namespace).EnsureSuccess();
    
    // do something with user profile data
    Console.WriteLine(response.UserId);
}
catch (HttpResponseException e)
{
    Console.WriteLine(e.Message);
}
*/
```

## Logout
```csharp
bool logout = sdk.Logout();
if (!logout)
{
    // Logout failed
}
```

## Working with Call Response
Every operation in C# Modular SDK will returns a response object. Use this object to do check whether the call is success or not, get the response data or error object.

- `IsSuccess` property will be `true` if the call is success, otherwise `false`.
- `Data` property contains response data from service. This property is **optional** depending whether the endpoint has response or not.
- `Error` property contains error object if call failed, otherwise null.

Known errors are available in `<ServiceName>Errors` static class. E.g `BasicErrors`, `IamErrors`, and so on.
```csharp
var response = sdk.GetBasicApi().UserProfile.GetMyProfileInfoOp.Execute(sdk.Namespace);
if (response.IsSuccess)
{
    // do something with response.Data
}
else
{
    // do something with response.Error

    // get error code
    string errorCode = response.Error.Code;

    // get error message
    string errorMessage = response.Error.Message;

    // or throw an exception
    response.Error.ThrowException();

    // compare to known error to handle more specific error
    if (response.Error == BasicErrors.Error11440)
    {
        //do something if user profile not found.
    }
}
```

Use `EnsureSuccess()` method as a shorthand to do default error and null checking in response object. This method will return response data directly if the endpoint has response.
```csharp
UserProfilePrivateInfo profileData = sdk.GetBasicApi().UserProfile.GetMyProfileInfoOp
    .Execute(sdk.Namespace)
    .EnsureSuccess();
```


## Enable HTTP Logging
To enable http logging feature, build the sdk with `EnableLog()`.
```csharp
using AccelByte.Sdk.Core;

IAccelByteSdk sdk = AccelByteSdk.Builder
    .UseDefaultHttpClient()
    .UseDefaultConfigRepository()
    .UseDefaultTokenRepository()
    .EnableLog()
    .Build();
```

## HTTP Retry Example
If retry feature is required, instantiate the sdk with `ReliableHttpClient` object.
```csharp
//Add core namespace
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Net.Http;

//Using default retry policy 
HttpClientPolicy policy = HttpClientPolicy.Default;

IAccelByteSdk sdk = AccelByteSdk.Builder
    .SetHttpClient(ReliableHttpClient.Builder
        .SetDefaultPolicy(policy)                    
        .Build())    
    .UseDefaultConfigRepository()
    .UseDefaultTokenRepository()
    .Build();
```

For `HttpClientPolicy` properties, refer to [this code](AccelByte.Sdk.Core/Net/Http/HttpClientPolicy.cs).

## Automatically Refresh Access Token

To enable automatic access token refresh, add the `AccelByte.Sdk.Feature.AutoRefreshToken package` and include the corresponding namespace. Then, instantiate the SDK using the following code.

```csharp
//Add core namespace
using AccelByte.Sdk.Core;

//Add feature namespace
using AccelByte.Sdk.Feature.AutoRefreshToken;

IAccelByteSdk sdk = AccelByteSdk.Builder
    .UseDefaultHttpClient()
    // Use DefaultConfigRepository: ensure the required environment variables are set
    .UseDefaultConfigRepository()    
    // Call this to enable background token refresh
    .UseBackgroundTokenRefresh()
    .Build();
```

To configure background token refresh, set following environment variables.

| Name                             | Required | Description                                                                                    |
|----------------------------------|--------- |------------------------------------------------------------------------------------------------|
| `AB_REFRESH_RATE`                | No       | Fraction of token lifetime before it is refreshed. Value between`0.0` to `1.0`. Default: `0.8` |
| `AB_REFRESH_MAX_RETRY`           | No       | Maximum number of retries for refresh token requests before failing. Default: `2`              |
| `AB_REFRESH_BACKGROUND_INTERVAL` | No       | Timer interval (in seconds) to check token expiry. Default: `10`                               |
| `AB_REFRESH_BACKGROUND_ENABLED`  | No       | Enables background token refresh. Default: `true`                                              |

NOTE: The `AB_REFRESH_RATE` uses a float value between `0` and `1` representing the fraction of the token's lifetime. For example, if a token is valid for 1 hour (3600 seconds), and `AB_REFRESH_RATE` is set to `0.5`, the SDK will attempt to refresh the token after it has less than 1800 seconds remaining (3600 x 0.5).

Background token refresh runs on a timer at a specified interval to check for token expiry. If the token is nearing its expiration time (as determined by the `AB_REFRESH_RATE` value), it will be refreshed automatically.

If a periodic background process is not preferred, use `.UseOnDemandTokenRefresh()` instead. This method triggers automatic token refresh whenever the SDK calls any AGS endpoint.
Please note that this type of token refresh is recommended only for OAuth client logins (using the LoginClient method), as it relies solely on the configured client ID and client secret values. It can be used for other login types, but once the refresh token expires, any subsequent calls will be unauthorized.

```csharp
//Add core namespace
using AccelByte.Sdk.Core;

//Add feature namespace
using AccelByte.Sdk.Feature.AutoRefreshToken;

IAccelByteSdk sdk = AccelByteSdk.Builder
    .UseDefaultHttpClient()
    // Use DefaultConfigRepository: ensure the required environment variables are set
    .UseDefaultConfigRepository()
    // call this to enable the feature
    .UseOnDemandTokenRefresh()
    .Build();
```

To configure on-demand token refresh, set the following environment variables.

| Name                          | Required | Description                                                                                    |
|-------------------------------|--------- |------------------------------------------------------------------------------------------------|
| `AB_REFRESH_RATE`             | No       | Fraction of token lifetime before it is refreshed. Value between`0.0` to `1.0`. Default: `0.8` |
| `AB_REFRESH_MAX_RETRY`        | No       | Maximum number of retries for refresh token requests before failing. Default: `2`              |
| `AB_REFRESH_ONDEMAND_ENABLED` | No       | Enables token refresh. Default: `true`                                                         |

NOTE: Avoid using both `.UseOnDemandTokenRefresh()` and `.UseBackgroundTokenRefresh()` together, as it introduces unnecessary overhead and may lead to unexpected behavior.

## Token Validation
To use token validation, add `AccelByte.Sdk.Authentication` package and instantiate the sdk with following code.
```csharp
//Add core namespace
using AccelByte.Sdk.Core;

IAccelByteSdk sdk = AccelByteSdk.Builder
    .UseDefaultHttpClient()
    // Using DefaultConfigRepository, make sure the required environment variables are set
    .UseDefaultConfigRepository()
    // Credential repository is required for auto refresh token to works
    .UseDefaultCredentialRepository()
    // call this to enable the feature
    .UseDefaultTokenValidator()    
    .Build();
```

Use following method to validate access token.
```csharp
bool isValid = sdk.ValidateToken(accessTokenStr);
```

To validate permission and action, use following method.
```csharp
bool isValid = sdk.ValidateToken(accessTokenStr, permissionStr, actionInt);
```

To validate permission and action with specified namespace and/or userid, use following method.
```csharp
bool isValid = sdk.ValidateToken(accessTokenStr, permissionStr, actionInt, namespaceId, userId);
```

Note: To validate permission from user token, you need to instantiate the SDK with OAuth Client that has `ADMIN:ROLE [READ]` permission assigned to it.

## Local Token Validation
Enable this feature to use local token validation instead of default token validation.
To enable it, add `AccelByte.Sdk.Feature.LocalTokenValidation` package, include `AccelByte.Sdk.Feature.LocalTokenValidation` namespace and then instantiate the sdk with following code.
```csharp
//Add core namespace
using AccelByte.Sdk.Core;

//Add feature namespace
using AccelByte.Sdk.Feature.LocalTokenValidation;

IAccelByteSdk sdk = AccelByteSdk.Builder
    .UseDefaultHttpClient()
    // Using DefaultConfigRepository, make sure the required environment variables are set
    .UseDefaultConfigRepository()
    // Credential repository is required for auto refresh token to works
    .UseDefaultCredentialRepository()
    // call this to enable the feature
    .UseLocalTokenValidator()
    // call this to enable auto refresh for token revocation list
    .UseAutoRefreshForTokenRevocationList()
    // call this to enable auto cache clear for token validator
    .UseTokenValidatorAutoClearCache()
    .Build();
```

Then use the usual `ValidateToken` methods.

If you only want to parse the access token.
```csharp
var payload = sdk.ParseAccessToken(accessTokenStr, false);
```
Or, you want to validate the token first before parse it.
```csharp
var payload = sdk.ParseAccessToken('<access token>', true);
//payload will be null if the access token is invalid.
```

Permission and namespace context cache can be cleared manually or automatically with set interval.
- To use it manually, call `sdk.Configuration.TokenValidator.InvalidateCache()`.
- to enable auto clear, instantiate the sdk with `UseTokenValidatorAutoClearCache(<interval in seconds>)` method.

## Operation with Generic Response
C# Extend SDK enable overloaded `ParseOperation` method with generic data type that applies to almost all operations with response model which has one or more object data type in it.
For example:
```csharp
using AccelByte.Sdk.Api.Cloudsave.Model;
using AccelByte.Sdk.Api.Cloudsave.Operation;

GameRecordExample myGameRecord = new GameRecordExample()
{
    MyStatus = "ALIVE",
    Location = "MOUNTAIN",
    Character = new GameRecordExample.CharacterClass()
    {
        Name = "Character",
        Strength = 10,
        Agility = 15,
        Intelligence = 20
    }
};

ModelsGameRecordResponse<GameRecordExample> response = sdk.GetCloudsaveApi().PublicGameRecord.PostGameRecordHandlerV1Op
    .Execute<GameRecordExample>(myGameRecord, "test_record", sdk.Namespace)
    .EnsureSuccess();
```
The list of which endpoints that support it can be found in [here](docs/operations/)

## FlightID
C# Extend SDK enable support for FlightID transmission during Http request. By default, new flight id will be generated when the sdk is loaded. There will be some case that this default value need to be updated with new value.
-   To update default flight id globally, use following code:
    ```csharp
    AccelByteConfig.UpdateDefaultFlightId("<new flight id value>");
    ```
    This will update the default flight id, and will be used by newly created sdk object (won't affect existing sdk object created before this code get executed).

-   To update flight id value in sdk object, use following code:
    ```csharp
    sdk.UpdateFlightId("<new flight id value>");
    ```
    This will update the flight id value stored inside the sdk object. Will be used for all operations executed by the sdk object.

-   To update flight id value for specific operation, use `UpdateFlightId` method when building the operation object.
    ```csharp
    // Make a call to getMyProfileInfo endpoint
    UserProfilePrivateInfo response = sdk.Basic.UserProfile.GetMyProfileInfoOp
        .UpdateFlightId("<new flight id value>")
        .Execute(sdk.Namespace)
        .EnsureSuccess()
    ```

## Web Socket Service

C# Extend SDK is able to connect to Lobby Web Socket Service. Following code demonstrate on how to use it.
```csharp

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api.Lobby;

var sdk = AccelByteSdk.Builder
    .UseDefaultHttpClient()
    .UseDefaultConfigRepository()
    .Build();

// do login first

var lobbyWs = new LobbyService(sdk.Configuration);

//start connect
await lobbyWs.Connect(false);

//listen to message, this will block the execution
await lobbyWs.Listen();

//disconnect
await lobbyWs.Disconnect();
```

By default, web socket service is allowed to reconnect when not normal closure is received. To disable it, set `AllowReconnect` to false.
```csharp
lobbyWs.AllowReconnect = false;
```

To handle message, register the event on which message type. For example:
```csharp
lobbyWs.OnFriendsStatusResponse = (data) =>
{

};
```

In some cases, it is probably desired to handle all incoming message in single handler. To do this, set `RedirectAllReceivedMessagesToMessageReceivedEvent` to true and register an action to `OnMessageReceived`.
```csharp
lobbyWs.RedirectAllReceivedMessagesToMessageReceivedEvent = true;
lobbyWs.OnMessageReceived = (message) =>
{
    
};
```

## Migrate from Monolithic Version
See this [migration info](MIGRATION.md).

## Documentation
For documentation about AccelByte Gaming Services and SDK, see [docs.accelbyte.io](https://docs.accelbyte.io/)
