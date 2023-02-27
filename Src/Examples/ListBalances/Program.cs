using Imx.Sdk.Gen.Client;
using Imx.Sdk.Gen.Model;
using Imx.Sdk;

// Address of the owner/user
var ownerAddress = "0x2d0ad946788938B9044ed72b1C464e1e9bb9d401"; // Swap this out for your own address
// Token address for 'eth'
var tokenAddress = "eth"; // Only for the token eth we pass in the string 'eth' for all other token types need to pass in the token address like '0x5c9f1680bb6a4b4fc698e0cf702e0cc34aed91b7' (this is GODS token address)

Client client = new Client(new Config()
{
    Environment = EnvironmentSelector.Sandbox
});

// Get ETH balance for owner token example
try
{
    var balance = client.GetBalance(ownerAddress, tokenAddress);
    Console.WriteLine($"ETH balance for owner token {ownerAddress}: " + balance.ToJson());
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
    var balances = client.ListBalances(ownerAddress);
    Console.WriteLine($"List of balances for owner token {ownerAddress}: " + balances.ToJson());
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ListBalances: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
