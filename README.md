<div align="center">
  <p align="center">
    <a  href="https://docs.x.immutable.com/docs">
      <img src="https://cdn.dribbble.com/users/1299339/screenshots/7133657/media/837237d447d36581ebd59ec36d30daea.gif" width="280"/>
    </a>
  </p>
</div>

# 🚨 This library is no longer maintained 🚨

If you're building apps with Immutable, please use [Immutable's Unified SDK](https://github.com/immutable/ts-immutable-sdk)

# Immutable Core SDK in C#

The Immutable Core SDK in C# provides convenient access to the ImmutableX API and Ethereum smart contracts for applications written on the ImmutableX platform.

Currently, this SDK supports interactions with our application-specific rollup based on StarkWare's [StarkEx](https://starkware.co/starkex/). In the future, when we start supporting other rollups, this SDK will also provide access to those.

> **Note**
> Currently, the C# Core SDK provides ***read-only*** functionality. The endpoints supported are (from [this Changelog entry](./CHANGELOG.md#010---2023-01-31)):
> * Assets: Get & List
> * Balances: Get & List
> * Collections: Get & List & List with filters
> * Exchanges: Get & List
> * Metadata: Get
> * Mints: Get & List
> * NFT Checkout Primary: Get & List transactions, Get currencies
> * Deposits: Get & List
> * Withdrawals: Get & List
> * Transfers: Get & List
> * Trades: Get & List
> * Orders: Get & List
> * Users: Get
> * Tokens: Get & List
> 
> ***Implementation roadmap:***
> ![image](https://user-images.githubusercontent.com/96668470/217699376-86d904c2-3355-4e9a-bb34-feae034e8494.png)

## Documentation

See the [Developer homepage](https://docs.x.immutable.com/) for general information on building on ImmutableX.

* Get started building on ImmutableX with the [Developer docs](https://docs.x.immutable.com/docs/welcome/)
* Check out the [API reference documentation](https://docs.x.immutable.com/reference)
* For the C# Core SDK reference documentation, please see [here](https://docs.x.immutable.com/sdk-docs/core-sdk-csharp/overview)

The following sections provide information on how to set up and use the most common functions of the C# SDK. For any other questions, please reach out to the team (see [Getting Help](#getting-help)).

## Examples
* **Sample code** - see the [examples](https://github.com/immutable/imx-core-sdk-csharp/tree/main/Src/Examples) folder for sample code for key SDK functionality.

## Installation

Add following nuget packages

https://www.nuget.org/packages/Imx.Sdk
https://www.nuget.org/packages/Imx.Sdk.Gen

```sh
dotnet add package Imx.Sdk --version 0.1.1
dotnet add package Imx.Sdk.Gen --version 0.1.1
```
## Initialization

Initialize the Core SDK client with the network on which you want your application to run (see [all networks available](https://github.com/immutable/imx-core-sdk-csharp/blob/main/Src/IMX/Imx.Sdk/Client.cs#L17)):

Select one of the following Ethereum networks ImmutableX platform currently supports.

| Environment | Description   |  
|-------------|---------------|
| Sandbox     | The default test network (currently, it is Goërli)  |
| Mainnet     | Ethereum network    | 

```csharp
using Imx.Sdk;

try
{
    Client client = new Client(new Config()
    {
        Environment = EnvironmentSelector.Sandbox
    });
}
catch (Exception e)
{
    Console.WriteLine("Error message: " + e.Message);
    Console.WriteLine(e.StackTrace);
}
```

## Get data

These methods allow you to read data about events, transactions or current state on ImmutableX (layer 2). They do not require any user authentication because no state is being changed.

Examples of the types of data that are typically retrieved include:

- Assets or details of a particular asset
- Token balances for a particular user
- Orders or details about a particular order
- Historical trades and transfers

### Examples

#### Get all collections and get assets from a particular collection:

```csharp
using Imx.Sdk.Gen.Client;
using Imx.Sdk.Gen.Model;
using Imx.Sdk;

try
{
    Client client = new Client(new Config() {
        Environment = EnvironmentSelector.Sandbox
    });

    // List collections
    ListCollectionsResponse resultListCollections = client.ListCollections(pageSize: 2);
    
    if (resultListCollections.Result.Count > 0)
    {
        Console.WriteLine("List Collections Response: " + resultListCollections.ToJson());
        
        // Get the first item in collection
        var collection = resultListCollections.Result[0];
        // Get a list of assets
        ListAssetsResponse resultListAssets = client.ListAssets(collection: collection.Address, pageSize: 10);
        Console.WriteLine("List Assets Response: " + resultListAssets.ToJson());
    }
    else
    {
        Console.WriteLine("No Collections found!");
    }
}
catch (ApiException  e)
{
    Console.WriteLine("Exception when calling Api: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
catch (Exception e)
{
    Console.WriteLine("Error message: " + e.Message);
    Console.WriteLine(e.StackTrace);
}
```

## API autogenerated code

We use OpenAPI (formally known as Swagger) to auto-generate the API clients that connect to the [public APIs](https://docs.x.immutable.com/reference). The OpenAPI spec is retrieved from https://api.x.immutable.com/openapi and also saved in the repo.

To re-generate the API client, run:

```make
make generate-openapi-prod
```

## Changelog management

This repository is using [release-it](https://github.com/release-it/release-it) to manage the CHANGELOG.md.

The following headings should be used as appropriate

- **Added**
- **Changed**
- **Deprecated**
- **Removed**
- **Fixed**

This is an example with all the change headings. For actual usage, use only the one heading that is relevant. This goes at the top of the CHANGELOG.md above the most recent release.

```markdown
...

## [Unreleased]

### Added

For new features.

### Changed

For changes in existing functionality.

### Deprecated

For soon-to-be removed features.

### Removed

For now removed features.

### Fixed

For any bug fixes.

...
```

## Getting help

ImmutableX is open to all to build on, with no approvals required. If you want to talk to us to learn more, or apply for developer grants, click below:

[Contact us](https://www.immutable.com/contact)

### Project support

To get help from other developers, discuss ideas, and stay up-to-date on what's happening, become a part of our community on Discord.

[Join us on Discord](https://discord.gg/TkVumkJ9D6)

You can also join the conversation, connect with other projects, and ask questions in our ImmutableX Discourse forum.

[Visit the forum](https://forum.immutable.com/)

### Still need help?

You can also apply for marketing support for your project. Or, if you need help with an issue related to what you're building with ImmutableX, click below to submit an issue. Select _I have a question_ or _issue related to building on Immutable X_ as your issue type.

[Contact support](https://support.immutable.com/hc/en-us/requests/new)
