using api.Api;
using api.Client;
using api.Model;
using Sdk;

try
{
    Client client = new Client(new Config() {
        Environment = EnvironmentSelector.Sandbox
    });
    
    // Get a list of assets
    ListAssetsResponse result = client.ListAssets();
    Console.WriteLine(result.ToJson());

    EthereumSigner signer = new EthereumSigner("5c7b4b5cad9a3fc7b1ba235a49cd74e615488a18b0d6a531739fd1062935104d");
    string timestamp = "1609462141000";
    string signedHash = signer.SignMessage(timestamp);
    if (signedHash ==
        "31043c2584b8f20d67c4d895f8e385e0d5c0ecb8bfb34e76874da4c27660c13d0cdbdf4bb9fe6473614d400e90a846ee25271f5a102a5c3162e3f84321a2113a00")
    {
        Console.WriteLine("HURRAY");
    }
    Console.WriteLine(signedHash);

}
catch (ApiException  e)
{
    Console.WriteLine("Exception when calling AssetsApi.ListAssets: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}