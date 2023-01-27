using Imx.Sdk.Gen.Client;
using Imx.Sdk.Gen.Model;
using Imx.Sdk;

try
{
    Client client = new Client(new Config()
    {
        Environment = EnvironmentSelector.Sandbox
    });

    // List Collections
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
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AssetsApi.ListAssets: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}