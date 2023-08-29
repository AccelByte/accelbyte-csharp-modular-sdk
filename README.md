# AccelByte .NET (C#) SDK (Modular Version)

A software development kit (SDK) for interacting with AccelByte Gaming Services written in C#.

This SDK was generated from OpenAPI spec included in the [spec](spec) directory.

## Setup

This SDK requires .NET 6.0 SDK to be installed.

## Usage

```bash
# always include these package to use AccelByte .NET SDK
$ dotnet add package AccelByte.Sdk.Abstractions
$ dotnet add package AccelByte.Sdk.Core

# include this package to do authentication to AGS
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
| `AB_BASE_URL`      | Yes                                              | https://demo.accelbyte.io        |
| `AB_CLIENT_ID`     | Yes                                              | abcdef0123456789abcdef0123456789 |
| `AB_CLIENT_SECRET` | Yes, but only if you use a private `AB_CLIENT_ID`| ab#c,d)ef(ab#c,d)ef(ab#c,d)ef(ab |
| `AB_NAMESPACE`     | Yes                                              | accelbyte                        |

### Instantiation
    
```csharp
//Add core namespace
using AccelByte.Sdk.Core;

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

### Login Using OAuth Client (Public or Private)

```csharp
bool login = sdk.LoginClient();
if (!login)
{
    // Login failed  
}
```

## Interacting with a Service Endpoint

As an example, we will get current user profile info using [getMyProfileInfo](https://demo.accelbyte.io/basic/apidocs/#/UserProfile/getMyProfileInfo) endpoint available in [basic](https://demo.accelbyte.io/basic/apidocs) service.

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

try
{
    // Make a call to getMyProfileInfo endpoint
    UserProfilePrivateInfo? response = sdk.GetBasicApi().UserProfile.GetMyProfileInfoOp.Execute(sdk.Namespace);

    /*
    
    // If you need to modify operation object, first you can build the operation object
    GetMyProfileInfo operation = sdk.GetBasicApi().UserProfile.GetMyProfileInfoOp
        .Build(sdk.Namespace);

    // then
    UserProfilePrivateInfo? response = sdk.GetBasicApi().UserProfile.GetMyProfileInfo(operation);

    */

    Console.WriteLine(response.UserId); // Success response
}
catch (HttpResponseException e)
{
    Console.WriteLine(e.Message);
}
```

## Logout
```csharp
bool logout = sdk.Logout();
if (!logout)
{
    // Logout failed
}
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
To enable automatic access token refresh, include `AccelByte.Sdk.Feature.AutoRefreshToken` and instantiate the sdk with following code.
```csharp
//Add core namespace
using AccelByte.Sdk.Core;

//Add feature namespace
using AccelByte.Sdk.Feature.AutoRefreshToken;

IAccelByteSdk sdk = AccelByteSdk.Builder
    .UseDefaultHttpClient()
    // Using DefaultConfigRepository, make sure the required environment variables are set
    .UseDefaultConfigRepository()
    // Credential repository is required for auto refresh token to works
    .UseDefaultCredentialRepository()
    // call this to enable the feature
    .UseAutoTokenRefresh()
    .Build();
```
Then when login, use the extension method provided.
```csharp
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Feature.AutoRefreshToken;

//pass true to the third parameter
bool login = sdk.LoginUser("myUsername", "myPassword", true);
if (!login)
{
    Console.WriteLine("Login failed");
}

//Or simply pass true to the first parameter if username and password are stored and retrieved by credential repository
bool login = sdk.LoginUser(true);
if (!login)
{
    Console.WriteLine("Login failed");
}

Alternative to automatic access token refresh is scheduled access token refresh. Scheduled access tokend refresh is using a timer that periodically refresh the access token. To enable it, instead of using `.UseAutoTokenRefresh()`, use `.UseScheduledTokenRefresh()` while instantiate the sdk.
```csharp
//Add core namespace
using AccelByte.Sdk.Core;

//Add feature namespace
using AccelByte.Sdk.Feature.AutoRefreshToken;

IAccelByteSdk sdk = AccelByteSdk.Builder
    .UseDefaultHttpClient()
    // Using DefaultConfigRepository, make sure the required environment variables are set
    .UseDefaultConfigRepository()
    // Credential repository is required for auto refresh token to works
    .UseDefaultCredentialRepository()
    // call this to enable the scheduled access token refresh
    .UseScheduledTokenRefresh()
    .Build();
```
NOTE: Do not use `.UseAutoTokenRefresh()` together with `.UseScheduledTokenRefresh()`. It will introduce unnecessary overhead and possibility of unexpected behaviour.

## Local Token Validation
Enable this feature to use local token validation instead of default token validation. Token validation and parse access token can support all access token type (user, client, or platform) while permission validation only support for oauth client token only.
To enable it, include `AccelByte.Sdk.Feature.LocalTokenValidation` and instantiate the sdk with following code.
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
    .Build();
```

And then use following method to validate access token.
```csharp
bool isValid = sdk.ValidateToken(accessTokenStr);
```
Or, if you need to validate permission and action, use following method.
```csharp
bool isValid = sdk.ValidateToken(accessTokenStr, permissionStr, actionInt);
```

If you only want to parse the access token.
```csharp
var payload = sdk.ParseAccessToken(accessTokenStr, false);
```
Or, you want to validate the token first before parse it.
```csharp
var payload = sdk.ParseAccessToken('<access token>', true);
//payload will be null if the access token is invalid.
```

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

ModelsGameRecordResponse<GameRecordExample>? response = sdk.GetCloudsaveApi().PublicGameRecord.PostGameRecordHandlerV1Op
    .Execute<GameRecordExample>(myGameRecord, "test_record", sdk.Namespace);
```
The list of which endpoints that support it can be found in [here](../docs/operations/)

## Documentation
For documentation about AccelByte Gaming Services and SDK, see [docs.accelbyte.io](https://docs.accelbyte.io/)
