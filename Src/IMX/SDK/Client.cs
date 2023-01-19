using System;
using System.Numerics;
using api.Api;
using api.Client;
using api.Model;

namespace Sdk
{
	public struct Environment
	{
		public string BaseApiPath;
		public string EthereumRpc;
		public string RegistrationContractAddress;
		public string CoreContractAddress;
		public  BigInteger ChainId;
	}

	public static class EnvironmentSelector
	{
		public static Environment Sandbox = new Environment()
		{
			BaseApiPath = "https://api.sandbox.x.immutable.com",
			EthereumRpc = "https://eth-goerli.alchemyapi.io/v2/",
			RegistrationContractAddress = "0x1C97Ada273C9A52253f463042f29117090Cd7D83",
			CoreContractAddress = "0x7917eDb51ecD6CdB3F9854c3cc593F33de10c623",
			ChainId = 5, // Goërli
		};
		public static Environment Mainnet = new Environment()
		{
			BaseApiPath = "https://api.x.immutable.com",
			EthereumRpc = "https://eth-mainnet.alchemyapi.io/v2/",
			RegistrationContractAddress = "0x72a06bf2a1CE5e39cBA06c0CAb824960B587d64c",
			CoreContractAddress = "0x5FDCCA53617f4d2b9134B29090C87D01058e27e9",
			ChainId = 1, // Mainnet
		};
	}
	
	public struct Config
	{
		public string AlchemyApiKey;
		public Configuration ApiConfig;
		public Environment Environment;
	}
		
    public class Client
    {
	    public Environment Environment;
	    
	    public readonly AssetsApi AssetsApi;
	    public readonly BalancesApi BalancesApi;
	    public readonly CollectionsApi CollectionsApi;
	    public readonly DepositsApi DepositsApi;
	    public readonly EncodingApi EncodingApi;
	    public readonly ExchangesApi ExchangesApi;
	    public readonly MetadataApi MetadataApi;
	    public readonly MetadataRefreshesApi MetadataRefreshesApi;
	    public readonly MintsApi MintsApi;
	    public readonly NftCheckoutPrimaryApi NftCheckoutPrimaryApi;
	    public readonly OrdersApi OrdersApi;
	    public readonly ProjectsApi ProjectsApi;
	    public readonly TradesApi TradesApi;
	    public readonly TransfersApi TransfersApi;
	    public readonly UsersApi UsersApi;
	    public readonly WithdrawalsApi WithdrawalsApi;

	    public Client(Config cfg)
        {
	        this.Environment = cfg.Environment;
            Configuration config = new Configuration
            {
	            BasePath = this.Environment.BaseApiPath
            };
            
            this.AssetsApi = new AssetsApi(config);
            this.BalancesApi = new BalancesApi(config);
            this.CollectionsApi = new CollectionsApi(config);
            this.DepositsApi = new DepositsApi(config);
            this.EncodingApi = new EncodingApi(config);
            this.ExchangesApi = new ExchangesApi(config);
            this.MetadataApi = new MetadataApi(config);
            this.MetadataRefreshesApi = new MetadataRefreshesApi(config);
            this.MintsApi = new MintsApi(config);
            this.NftCheckoutPrimaryApi = new NftCheckoutPrimaryApi(config);
            this.OrdersApi = new OrdersApi(config);
            this.ProjectsApi = new ProjectsApi(config);
            this.TradesApi = new TradesApi(config);
            this.TransfersApi = new TransfersApi(config);
            this.UsersApi = new UsersApi(config);
            this.WithdrawalsApi = new WithdrawalsApi(config);
        }
    }
}