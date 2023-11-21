# AccelByte .NET (C#) Modular SDK Auto Refresh Token Feature Component

A software development kit (SDK) for interacting with AccelByte Gaming Services written in C#.

This library provides auto refresh token feature for C# Extend Modular SDK.

## Setup

This SDK requires .NET 6.0 SDK to be installed.

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

## Further Reading

For more information please read C# Extend Modular SDK Github's [README](https://github.com/AccelByte/accelbyte-csharp-modular-sdk/blob/main/README.md).

Read our [migration info](https://github.com/AccelByte/accelbyte-csharp-modular-sdk/blob/main/MIGRATION.md) for more information on how to migrate from monolithic version.

For documentation about AccelByte Gaming Services and SDK, see [docs.accelbyte.io](https://docs.accelbyte.io/)
