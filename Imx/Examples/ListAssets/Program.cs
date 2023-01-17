using api.Api;
using api.Client;
using api.Model;
using System;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Configuration config = new Configuration();
config.BasePath = "https://api.sandbox.x.immutable.com";
var apiInstance = new AssetsApi(config);

try
{
    // Get a list of assets
    ListAssetsResponse result = apiInstance.ListAssets();
    Console.WriteLine(result.ToJson());
}
catch (ApiException  e)
{
    Console.WriteLine("Exception when calling AssetsApi.ListAssets: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}