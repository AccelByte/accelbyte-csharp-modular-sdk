# Add Custom Operation into AccelByte SDK

## Background
Majority of C# Extend SDK codes are generated from [spec json files](../spec) using codegen tools. Any attemp to customize C# Extend SDK must avoid editing files that are marked as `DO NOT EDIT`.
Also it is best practice to extend the functionality of C# Extend SDK by inherit the base classes or add new implementation for partial classes to ensure less complications when upgrading C# Extend SDK.

## How to Create a Custom Operation
In this guide, we will explain on how to use our AccelByte Sdk C# (.NET) to create a sdk module for your custom operation for custom endpoint.

### Preparation
Create a new .NET 6.0 class library project and include dependency to [AccelByte.Sdk](https://www.nuget.org/packages/AccelByte.Sdk/). Refer to these articles for more information on how to create new project.
- Create a class library [using Visual Studio](https://learn.microsoft.com/en-us/dotnet/core/tutorials/library-with-visual-studio?pivots=dotnet-6-0).
- Create a class library [using Visual Studio Code](https://learn.microsoft.com/en-us/dotnet/core/tutorials/library-with-visual-studio-code?pivots=dotnet-6-0).

### Goal
Create an operation class and its wrapper for custom endpoint (for this guide, let's use `GET /achievement/v1/public/namespaces/{namespace}/tags` as an example of custom endpoint).
This endpoints requires `namespace` as path parameter and a few optional query parameters. Will returns HTTP 200 if success along with the data.
Let's use `SdkCustomization.CustomOperation` as namespace. (Usually the namespace is the name of the project).
And let us name this custom operation `MyCustomOperation`.

## Create Model classes
Our example endpoint has this output
```json
{
  "data": [
    {
      "createdAt": "2023-02-02T02:49:34.767Z",
      "name": "string",
      "namespace": "string"
    }
  ],
  "paging": {
    "next": "string",
    "previous": "string"
  }
}
```
We need to create model classes that reflect the output.
```csharp
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SdkCustomization.CustomOperation
{
    public class MyCustomResponseModel
    {
        public class TagData
        {
            [JsonPropertyName("createdAt")]
            public DateTime? CreatedAt { get; set; }

            [JsonPropertyName("name")]
            public string? Name { get; set; }

            [JsonPropertyName("namespace")]
            public string? Namespace { get; set; }
        }

        public class Pagination
        {
            [JsonPropertyName("next")]
            public string? Next { get; set; }

            [JsonPropertyName("previous")]
            public string? Previous { get; set; }
        }



        [JsonPropertyName("data")]
        public List<TagData>? Data { get; set; }

        [JsonPropertyName("paging")]
        public Pagination? Paging { get; set; }
    }
}
```

## Create an Operation Class
You can create an operation class following this example. This operation class already include operation builder class.
```csharp
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Net;
using System.Net.Http;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Net.Http;

namespace SdkCustomization.CustomOp
{
    public class MyCustomOperation : Operation
    {
        #region Builder Part
        public static MyCustomOperationBuilder Builder { get => new MyCustomOperationBuilder(); }

        public class MyCustomOperationBuilder : OperationBuilder<MyCustomOperationBuilder>
        {
            public long? Limit { get; set; }

            public string? Name { get; set; }

            public long? Offset { get; set; }

            public string? SortBy { get; set; }

            internal MyCustomOperationBuilder() { }

            internal MyCustomOperationBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }

            public MyCustomOperationBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public MyCustomOperationBuilder SetName(string _name)
            {
                Name = _name;
                return this;
            }

            public MyCustomOperationBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public MyCustomOperationBuilder SetSortBy(string _sortBy)
            {
                SortBy = _sortBy;
                return this;
            }

            public MyCustomOperation Build(
                string namespace_
            )
            {
                MyCustomOperation op = new MyCustomOperation(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public MyCustomResponseModel? Execute(string namespace_)
            {
                MyCustomOperation op = Build(
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private MyCustomOperation(MyCustomOperationBuilder builder, string namespace_)
        {
            PathParams["namespace"] = namespace_;

            if (builder.Limit != null)
                QueryParams["limit"] = Convert.ToString(builder.Limit)!;

            if (builder.Name is not null)
                QueryParams["name"] = builder.Name;

            if (builder.Offset != null)
                QueryParams["offset"] = Convert.ToString(builder.Offset)!;

            if (builder.SortBy is not null)
                QueryParams["sortBy"] = builder.SortBy;

            //Use SECURITY_BEARER for endpoint that need authorization token,
            //or use SECURITY_BASIC for endpoint that only need basic auth using client id and secret._
            Securities.Add(SECURITY_BEARER);
        }
        #endregion

        //Use existing endpoint only for this sample.
        public override string Path => "/achievement/v1/public/namespaces/{namespace}/tags";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public MyCustomOperation(string namespace_, long? limit, string? name, long? offset, string? sortBy)
        {
            PathParams["namespace"] = namespace_;

            if (limit != null)
                QueryParams["limit"] = Convert.ToString(limit)!;

            if (name != null)
                QueryParams["name"] = name;

            if (offset != null)
                QueryParams["offset"] = Convert.ToString(offset)!;

            if (sortBy != null)
                QueryParams["sortBy"] = sortBy;

            //Use SECURITY_BEARER for endpoint that need authorization token,
            //or use SECURITY_BASIC for endpoint that only need basic auth using client id and secret._
            Securities.Add(SECURITY_BEARER);
        }

        public MyCustomResponseModel? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<MyCustomResponseModel>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<MyCustomResponseModel>(payload);
            }

            var payloadString = payload.ReadToString();
            throw new HttpResponseException(code, payloadString);
        }
    }
}
```

## Create a Wrapper Class
You can create a wrapper class following this example
```csharp
using System;
using AccelByte.Sdk.Core;

namespace SdkCustomization.CustomOperation
{
    public class MyCustomWrapper
    {
        private readonly IAccelByteSdk _sdk;

        public MyCustomWrapper(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public MyCustomResponseModel? CallMyCustomOperation(MyCustomOperation input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public MyCustomOperation.MyCustomOperationBuilder MyCustomOperationOp
        {
            get { return new MyCustomOperation.MyCustomOperationBuilder(_sdk); }
        }
    }
}
```

## Create a Custom Api Class
You'll need to create a custom api class that wraps all of your wrappers (if you have more than one). You'll need a static class to add extension method for `IAccelByteSdk`.
```csharp
using System;
using AccelByte.Sdk.Core;

namespace SdkCustomization.CustomOperation
{
    public class MyCustomApi : ISdkApi
    {
        private IAccelByteSdk _Sdk;

        private MyCustomWrapper? _MyCustomWrapper = null;

        public MyCustomWrapper MyCustomWrapper
        {
            get
            {
                if (_MyCustomWrapper == null)
                    _MyCustomWrapper = new MyCustomWrapper(_Sdk);
                return _MyCustomWrapper;
            }
        }

        internal MyCustomApi(IAccelByteSdk sdk)
        {
            _Sdk = sdk;
        }
    }
}

//You can use "AccelByte.Sdk.Api" to put your sdk object extension, or use your own namespace.
namespace AccelByte.Sdk.Api
{
    public static class MyCustomApi_SdkExts
    {
        public static MyCustomApi GetMyCustomApi(this IAccelByteSdk sdk)
        {
            //use unique key for your custom api. If you have more than one custom api(s), you will need unique key for each of your custom api.
            return sdk.GetApi<MyCustomApi>("my_custom_api", () =>
            {
                return new MyCustomApi(sdk);
            });
        }
    }
}
```

## Use Custom Operation
After you create necessary classes, you can use it with AccelByte Sdk.
```csharp
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;

using SdkCustomization.CustomOp;

AccelByteSDK sdk = AccelByteSDK.Builder
    .UseDefaultHttpClient()
    .UseDefaultConfigRepository()
    .UseDefaultTokenRepository()
    .Build();

var response = sdk.GetMyCustomApi().MyCustomWrapper.MyCustomOperationOp
    .Execute(sdk.Namespace);
```

## Testing
Create a .NET 6 `NUnit Test Project` and include AccelByte C# (.NET) Extend SDK dependency as mentioned [here](../README.md)

Add reference to your custom operation project inside this test project.

You can use the code template below to start your sdk test class.
```csharp
using System;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;
using SdkCustomization.CustomOperation;

namespace SdkCustomization.Test1
{
    public class CustomSdkTests
    {
        protected IAccelByteSdk? _Sdk = null;

        [OneTimeSetUp]
        public void Setup()
        {
            _Sdk = AccelByteSdk.Builder
                .UseDefaultHttpClient()
                .UseDefaultConfigRepository()
                .UseDefaultTokenRepository()
                .UseDefaultCredentialRepository()
                .EnableLog()
                .Build();

            _Sdk.LoginUser();
        }

        [Test]
        public void CustomOpTest1()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            MyCustomResponseModel? response = _Sdk.GetMyCustomApi().MyCustomWrapper.MyCustomOperationOp
                .Execute(_Sdk.Namespace);
            Assert.IsNotNull(response);

            //You can fill with your test logic after the response is received.
        }
    }
}
```

You will need environment variables mentioned in [README](../README.md) to run the tests.
If you are using Visual Studio, you can create `.runsettings` file. Here is the example
```xml
<?xml version="1.0" encoding="utf-8"?>
<RunSettings>
    <RunConfiguration>
        <EnvironmentVariables>
            <AB_BASE_URL>https://test.accelbyte.io</AB_BASE_URL>
            <AB_CLIENT_ID>abcdef0123456789abcdef0123456789</AB_CLIENT_ID>
            <AB_CLIENT_SECRET>ab#c,d)ef(ab#c,d)ef(ab#c,d)ef(ab</AB_CLIENT_SECRET>
            <AB_NAMESPACE>accelbyte</AB_NAMESPACE>
            <AB_APP_NAME>CustomOpTest</AB_APP_NAME>
            <AB_APP_VERSION>0.1.0</AB_APP_VERSION>
            <AB_USERNAME>example_user@dummy.com</AB_USERNAME>
            <AB_PASSWORD>1234567890!!</AB_PASSWORD>
        </EnvironmentVariables>
    </RunConfiguration>
</RunSettings>
```
Replace the variables with any valid AccelByte credentials. If all of your tests did not use user's authorization token. You can skip `AB_USERNAME` and `AB_PASSWORD`.
Then go to `Test` -> `Configure Run Settings` -> `Select Solutions Wide runsettings File` and select your newly created  `.runsettings` file.

> You can use `.runsettings` file also for dotnet cli, in case you did not want to add environment variable in your system.
> You can use this command to execute dotnet cli test
> ```bash
> dotnet test -s ~/config.runsettings
> ```

## References
Please see [api modules](../apis) for more examples on how to create custom operation from generated code.