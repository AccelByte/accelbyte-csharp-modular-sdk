# Migration Guide from Monolithic SDK to Modular SDK

The Modular SDK version has several key differences compared to the monolithic version, particularly in namespace structure and fluent interface style. In the modular SDK version, almost all class implementations have their own abstractions. Users are recommended to use abstraction objects wherever possible.

Below is the list of changes.

## Obsolete Components
All non-API obsolete classes, methods, and properties have been removed in the Modular SDK. It is recommended to upgrade to the latest monolithic version and remove any usage of obsolete components before migrating to the Modular SDK.


## Project Structure
- All API wrappers are now in their own separate libraries.
- `AccelByte.Sdk.Abstractions` - Contains all interfaces and common types.
- `AccelByte.Sdk.Core` - Contains all core classes without any dependencies on a specific API.
- `AccelByte.Sdk.Authentication` - Contains SDK method extensions that implement authentication such as login and logout.
- `AccelByte.Sdk.Feature.*` - Contains optional features.
- `AccelByte.Sdk.Compat` - Contains classes that mimic the monolithic version mapped to the modular version. This library aims to ease the migration from the monolithic version to the modular version.
- `AccelByte.Sdk.Tests` - Contains all tests that use the compatibility layer provided by the compat library.
- `AccelByte.Sdk.Tests.Mod` - Contains all tests that fully use the modular version of the SDK.


## Classes
||Monolithic|Modular|
|-|-|-|
|SDK Class|`AccelByteSDK`|`AccelByteSdk` that implements `IAccelByteSdk`. To access most features, it is recommended to use `IAccelByteSdk`.|
|SDK Builder Class|`AccelByteSdkBuilder`|`AccelByteSdkBuilder<T>` that implements `IAccelByteSdkBuilder<T>`|


## Namespaces
||Monolithic|Modular|
|-|-|-|
|Network components|`AccelByte.Sdk.Core.Client`|HTTP-related classes moved to `AccelByte.Sdk.Core.Net.Http`, and other network-related classes to `AccelByte.Sdk.Core.Net`.|
|Utilities|`AccelByte.Sdk.Core.Util`|Removed. All helper methods have been moved to extension methods inside `AccelByte.Sdk.Core`.|
|Security-related classes|None (inside the classes folder)|`AccelByte.Sdk.Core.Security`|


## Fluent Access
||Monolithic|Modular|
|-|-|-|
||`sdk.<ApiName>`|`sdk.Get<ApiName>Api()`|


## SDK Initialization
In the monolithic version, using default implementations only requires including a single namespace, which is `AccelByte.Sdk.Core`. In the modular version, you will need to include the respective namespace for each default implementation. For example, if you want to include default repositories, you will need to include `AccelByte.Sdk.Core.Repository`. For HTTP clients, you will need to include `AccelByte.Sdk.Core.Net.Http`.

## Refresh Token on Login
Every login will now attempt to use a refresh token first if available. To disable this behavior, you can call `.DisableRefreshIfPossible()` while building the SDK object.

## Token Validation
In the monolithic version, the default token validator is assigned by default. In the modular version, you will need to explicitly set it in the SDK builder using the `UseDefaultTokenValidator` method. Refer to the [README](./README.md) for usage instructions.

## Custom Operation
The `Consumes` and `Produces` properties now use `List<string>` instead of string arrays. Additionally, the `Security` property has been removed in favor of the `Securities` field.

## Call Response
Unlike the monolithic version, each operation call will return a response object that contains both the response data (if any) and a possible error. Use the `EnsureSuccess` method on the response object to achieve similar behavior to the monolithic version. This method also checks whether the response data is null. If it is null, it will throw an exception.

For example:
```csharp
// Monolithic version
List<RetrieveAcceptedAgreementResponse>? response = sdk.GetLegal().Agreement.RetrieveAgreementsPublicOp
    .Execute();

// Modular version
List<RetrieveAcceptedAgreementResponse> response = sdk.GetLegal().Agreement.RetrieveAgreementsPublicOp
    .Execute()
    .EnsureSuccess();
```

## Exception
Any call will now throw `ApiResponseException` instead of `HttpResponseException` with more exposed properties.

## HTTP Logger
In the Modular SDK, implementing a custom HTTP logger is slightly different due to interface changes. The `OutputWriter` property has been replaced by the `Writer` property.
Use `AccelByte.Sdk.Core.Net.Logging` instead of `AccelByte.Sdk.Core.Logging` to access logger components.

## Custom Repositories
If you develop a custom configuration repository, you will need to implement the `GetCustomServiceBasePath` method in the Modular SDK.

# Compatibility Library (Compat Project)

The `AccelByte.Sdk.Compat` library provides classes as adapters to the monolithic version:
- Provides an `AccelByteSDK` object that has the monolithic version's fluent interface access.
- Provides an SDK Builder with the default token validator already set.
- Provides a `Helper` class in `AccelByte.Sdk.Core.Util` that maps to each respective extension method.
- Added `UseRefreshIfPossible` in the SDK Builder to prevent build errors, but this method does nothing since this is enabled by default in the Modular SDK.
- Added `SetOnAfterLoginAction` to add an after-login event.
- When an error occurs, all calls will throw `HttpResponseException`, translated from `ApiResponseException` to mimic monolithic SDK behavior.

See the [Tests Project](AccelByte.Sdk.Tests) for more examples of how the compat project works.

**Note:** This compatibility library does not change the default behavior of on-demand refresh token.
