# Migration Guide from Monolithic SDK to Modular SDK

Modular SDK version has a few differences compared to monolithic one especially in namespace structure and fluent interface style. Also, in modular sdk version, almost all class implementation has it owns abstraction. User are recommended to use the abstraction object wherever is possible.

Below are the list of things that changed.


## Project Structure
- All api wrappers are now in their separate library.
- `AccelByte.Sdk.Abstractions`, contains all interfaces and common types.
- `AccelByte.Sdk.Core`, contains all core classes without any dependencies on specified api.
- `AccelByte.Sdk.Authentication`, contains sdk method extensions that implements authentication such as login and logout.
- `AccelByte.Sdk.Feature.*`, contains optional features
- `AccelByte.Sdk.Compat`, contains classes that mimic monolithic version mapped to modular version. This library aims to ease the migration from monolithic version to modular version.
- `AccelByte.Sdk.Tests`, contains all tests that use compatibility layer provided by the compat library.
- `AccelByte.Sdk.Tests.Mod`, contains all tests that fully use modular version of the sdk.


## Classes
||Monolithic|Modular|
|-|-|-|
|Sdk Class|`AccelByteSDK`|`AccelByteSdk` that implements `IAccelByteSdk`. To access most of the feature, it is recommended to use `IAccelByteSdk`.|
|Sdk Builder Class|`AccelByteSdkBuilder`|`AccelByteSdkBuilder<T>` that implements `IAccelByteSdkBuilder<T>`|


## Namespaces
||Monolithic|Modular|
|-|-|-|
|Network components|`AccelByte.Sdk.Core.Client`|Http related to `AccelByte.Sdk.Core.Net.Http`, and other network related to `AccelByte.Sdk.Core.Net`.|
|Utilities|`AccelByte.Sdk.Core.Util`|Removed. All helper methods are moved to extensions form inside `AccelByte.Sdk.Core`|
|Security related classes|none, inside the classes folder|`AccelByte.Sdk.Core.Security`|


## Fluent Access
||Monolithic|Modular|
|-|-|-|
||`sdk.<ApiName>`|`sdk.Get<ApiName>Api()`|


## Sdk Initialization
In monolithic version, using default implementations only need to include single namespace, which is `AccelByte.Sdk.Core`. In modular version, You will need to include respective namespace for each default implementations. For example, if you want to include default repositories, then you will need to include `AccelByte.Sdk.Core.Repository`. For Http clients, you will need to include `AccelByte.Sdk.Core.Net.Http`.

## Refresh token if possible while login
Now every login will try to use refresh token first if available. To disable it, you can call `.DisableRefreshIfPossible()` while building the sdk object.

## Token Validation
In monolithic version, default token validator is assigned by default. Now you will need to explicitly set in in sdk builder with `UseDefaultTokenValidator` method. Refer to [README](./README.md) on how to use it.

## Custom Operation
`Consumes` and `Produces` property is now using `List<string>` instead of string array. Also `Security` property is removed in favor of `Securities` field.

## Call Response
Different from monolithic version, each operation call will return a response object that contains both response data (if any) and possible error. Use `EnsureSuccess` method in response object to get get similar behavior as monolithic version. This method also checks whether the response data is null or not. If it is null, it will throw an exception.
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

# Compatibility Library (Compat Project)

`AccelByte.Sdk.Compat` library provides classes as adapter to monolithic version. `AccelByte.Sdk.Compat` provides `AccelByteSDK` object that has monolithic version of fluent interface access. Also it provides `Helper` class in `AccelByte.Sdk.Core.Util` that map to each respective extension method.
See [Tests Project](AccelByte.Sdk.Tests) for more samples on how the compat project works.

NOTE:
- this compat library does not change the default behaviour  of on-demand refresh token.
