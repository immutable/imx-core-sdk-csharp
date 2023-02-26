using Imx.Sdk.Gen.Client;
using Imx.Sdk.Gen.Model;
using Imx.Sdk;

// Address of the owner/user
var ownerToken = "0x2d0ad946788938B9044ed72b1C464e1e9bb9d401"; // Swap this out for your own owner token address

// Token address of 'eth'
var ethTokenAddress = "eth";

// Token address of Gods Unchained
var guTokenAddress = "0x5c9f1680bb6a4b4fc698e0cf702e0cc34aed91b7";

Client client = new Client(new Config()
{
    Environment = EnvironmentSelector.Sandbox
});

// Get ETH balance for owner token example
try
{
    var balance = client.GetBalance(ownerToken, ethTokenAddress);
    Console.WriteLine($"ETH balance for owner token {ownerToken}: " + balance.ToJson());
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling GetBalance: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}

// Get Gods Unchained balance for owner token example
try
{
    var balance = client.GetBalance(ownerToken, guTokenAddress);
    Console.WriteLine($"ETH balance for owner token {ownerToken}: " + balance.ToJson());
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling GetBalance: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}

// List balances for owner token example
try
{
    var balances = client.ListBalances(ownerToken);
    Console.WriteLine($"List of balances for owner token {ownerToken}: " + balances.ToJson());
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ListBalances: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
