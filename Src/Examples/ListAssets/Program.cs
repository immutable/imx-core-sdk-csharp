using api.Api;
using api.Client;
using api.Model;
using Sdk;

try
{
    Client client = new Client(EnvironmentSelector.Sandbox);
    
    // Get a list of assets
    ListAssetsResponse result = client.AssetsApi.ListAssets();
    Console.WriteLine(result.ToJson());
}
catch (ApiException  e)
{
    Console.WriteLine("Exception when calling AssetsApi.ListAssets: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}