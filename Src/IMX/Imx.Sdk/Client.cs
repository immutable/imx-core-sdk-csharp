using System.Numerics;
using Imx.Sdk.Gen.Api;
using Imx.Sdk.Gen.Client;
using Imx.Sdk.Gen.Model;

namespace Imx.Sdk
{
	public struct Environment
	{
		public string BaseApiPath;
		public string EthereumRpc;
		public string RegistrationContractAddress;
		public string CoreContractAddress;
		public BigInteger ChainId;
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
		
    public class Client : IClientSync, IClientAsync
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
	    public readonly TokensApi TokensApi;
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
            this.TokensApi = new TokensApi(config);
            this.ProjectsApi = new ProjectsApi(config);
            this.TradesApi = new TradesApi(config);
            this.TransfersApi = new TransfersApi(config);
            this.UsersApi = new UsersApi(config);
            this.WithdrawalsApi = new WithdrawalsApi(config);
        }
	    
		#region  Assets

		public Asset GetAsset(string tokenAddress, string tokenId, bool? includeFees = default(bool?), int operationIndex = 0)
        {
            return AssetsApi.GetAsset(tokenAddress, tokenId, includeFees);
        }

        public async System.Threading.Tasks.Task<Asset> GetAssetAsync(string tokenAddress, string tokenId, bool? includeFees = default(bool?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await AssetsApi.GetAssetAsync(tokenAddress, tokenId, includeFees, operationIndex, cancellationToken).ConfigureAwait(false);
        }

		public ListAssetsResponse ListAssets(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string user = default(string), string status = default(string), string name = default(string), string metadata = default(string), bool? sellOrders = default(bool?), bool? buyOrders = default(bool?), bool? includeFees = default(bool?), string collection = default(string), string updatedMinTimestamp = default(string), string updatedMaxTimestamp = default(string), string auxiliaryFeePercentages = default(string), string auxiliaryFeeRecipients = default(string), int operationIndex = 0)
        {
            return AssetsApi.ListAssets(pageSize, cursor, orderBy, direction, user, status, name, metadata, sellOrders, buyOrders, includeFees, collection, updatedMinTimestamp, updatedMaxTimestamp, auxiliaryFeePercentages, auxiliaryFeeRecipients);
        }

		public async System.Threading.Tasks.Task<ListAssetsResponse> ListAssetsAsync(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string user = default(string), string status = default(string), string name = default(string), string metadata = default(string), bool? sellOrders = default(bool?), bool? buyOrders = default(bool?), bool? includeFees = default(bool?), string collection = default(string), string updatedMinTimestamp = default(string), string updatedMaxTimestamp = default(string), string auxiliaryFeePercentages = default(string), string auxiliaryFeeRecipients = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await AssetsApi.ListAssetsAsync(pageSize, cursor, orderBy, direction, user, status, name, metadata, sellOrders, buyOrders, includeFees, collection, updatedMinTimestamp, updatedMaxTimestamp, auxiliaryFeePercentages, auxiliaryFeeRecipients, operationIndex, cancellationToken).ConfigureAwait(false);
        }
	    #endregion Assets

		#region Deposits

		public Deposit GetDeposit(string id, int operationIndex = 0)
        {
            return DepositsApi.GetDeposit(id);
        }

        public async System.Threading.Tasks.Task<Deposit> GetDepositAsync(string id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await DepositsApi.GetDepositAsync(id, operationIndex, cancellationToken).ConfigureAwait(false);
		}

        public ListDepositsResponse ListDeposits(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string user = default(string), string status = default(string), string minTimestamp = default(string), string maxTimestamp = default(string), string tokenType = default(string), string tokenId = default(string), string assetId = default(string), string tokenAddress = default(string), string tokenName = default(string), string minQuantity = default(string), string maxQuantity = default(string), string metadata = default(string), int operationIndex = 0)
        {
            return DepositsApi.ListDeposits(pageSize, cursor, orderBy, direction, user, status, minTimestamp, maxTimestamp, tokenType, tokenId, assetId, tokenAddress, tokenName, minQuantity, maxQuantity, metadata);
        }

        public async System.Threading.Tasks.Task<ListDepositsResponse> ListDepositsAsync(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string user = default(string), string status = default(string), string minTimestamp = default(string), string maxTimestamp = default(string), string tokenType = default(string), string tokenId = default(string), string assetId = default(string), string tokenAddress = default(string), string tokenName = default(string), string minQuantity = default(string), string maxQuantity = default(string), string metadata = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await DepositsApi.ListDepositsAsync(pageSize, cursor, orderBy, direction, user, status, minTimestamp, maxTimestamp, tokenType, tokenId, assetId, tokenAddress, tokenName, minQuantity, maxQuantity, metadata, operationIndex, cancellationToken).ConfigureAwait(false);
        }

		#endregion Deposits

		#region Mints

		public Mint GetMint(string id, int operationIndex = 0)
        {
            return MintsApi.GetMint(id);
        }

        public async System.Threading.Tasks.Task<Mint> GetMintAsync(string id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await MintsApi.GetMintAsync(id, operationIndex, cancellationToken).ConfigureAwait(false);
        }

        public ListMintsResponse ListMints(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string user = default(string), string status = default(string), string minTimestamp = default(string), string maxTimestamp = default(string), string tokenType = default(string), string tokenId = default(string), string assetId = default(string), string tokenName = default(string), string tokenAddress = default(string), string minQuantity = default(string), string maxQuantity = default(string), string metadata = default(string), int operationIndex = 0)
        {
            return MintsApi.ListMints(pageSize, cursor, orderBy, direction, user, status, minTimestamp, maxTimestamp, tokenType, tokenId, assetId, tokenName, tokenAddress, minQuantity, maxQuantity, metadata);
        }

		public async System.Threading.Tasks.Task<ListMintsResponse> ListMintsAsync(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string user = default(string), string status = default(string), string minTimestamp = default(string), string maxTimestamp = default(string), string tokenType = default(string), string tokenId = default(string), string assetId = default(string), string tokenName = default(string), string tokenAddress = default(string), string minQuantity = default(string), string maxQuantity = default(string), string metadata = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await MintsApi.ListMintsAsync(pageSize, cursor, orderBy, direction, user, status, minTimestamp, maxTimestamp, tokenType, tokenId, assetId, tokenName, tokenAddress, minQuantity, maxQuantity, metadata, operationIndex, cancellationToken).ConfigureAwait(false);
        }

		#endregion Mints

		#region Orders

        public Order GetOrder(string id, bool? includeFees = default(bool?), string auxiliaryFeePercentages = default(string), string auxiliaryFeeRecipients = default(string), int operationIndex = 0)
        {
            return OrdersApi.GetOrder(id, includeFees, auxiliaryFeePercentages, auxiliaryFeeRecipients);
        }

        public async System.Threading.Tasks.Task<Order> GetOrderAsync(string id, bool? includeFees = default(bool?), string auxiliaryFeePercentages = default(string), string auxiliaryFeeRecipients = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await OrdersApi.GetOrderAsync(id, includeFees, auxiliaryFeePercentages, auxiliaryFeeRecipients, operationIndex, cancellationToken).ConfigureAwait(false);
        }
		
		public ListOrdersResponse ListOrders(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string user = default(string), string status = default(string), string minTimestamp = default(string), string maxTimestamp = default(string), string updatedMinTimestamp = default(string), string updatedMaxTimestamp = default(string), string buyTokenType = default(string), string buyTokenId = default(string), string buyAssetId = default(string), string buyTokenAddress = default(string), string buyTokenName = default(string), string buyMinQuantity = default(string), string buyMaxQuantity = default(string), string buyMetadata = default(string), string sellTokenType = default(string), string sellTokenId = default(string), string sellAssetId = default(string), string sellTokenAddress = default(string), string sellTokenName = default(string), string sellMinQuantity = default(string), string sellMaxQuantity = default(string), string sellMetadata = default(string), string auxiliaryFeePercentages = default(string), string auxiliaryFeeRecipients = default(string), bool? includeFees = default(bool?), int operationIndex = 0)
        {
            return OrdersApi.ListOrders(pageSize, cursor, orderBy, direction, user, status, minTimestamp, maxTimestamp, updatedMinTimestamp, updatedMaxTimestamp, buyTokenType, buyTokenId, buyAssetId, buyTokenAddress, buyTokenName, buyMinQuantity, buyMaxQuantity, buyMetadata, sellTokenType, sellTokenId, sellAssetId, sellTokenAddress, sellTokenName, sellMinQuantity, sellMaxQuantity, sellMetadata, auxiliaryFeePercentages, auxiliaryFeeRecipients, includeFees);
        }

		public async System.Threading.Tasks.Task<ListOrdersResponse> ListOrdersAsync(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string user = default(string), string status = default(string), string minTimestamp = default(string), string maxTimestamp = default(string), string updatedMinTimestamp = default(string), string updatedMaxTimestamp = default(string), string buyTokenType = default(string), string buyTokenId = default(string), string buyAssetId = default(string), string buyTokenAddress = default(string), string buyTokenName = default(string), string buyMinQuantity = default(string), string buyMaxQuantity = default(string), string buyMetadata = default(string), string sellTokenType = default(string), string sellTokenId = default(string), string sellAssetId = default(string), string sellTokenAddress = default(string), string sellTokenName = default(string), string sellMinQuantity = default(string), string sellMaxQuantity = default(string), string sellMetadata = default(string), string auxiliaryFeePercentages = default(string), string auxiliaryFeeRecipients = default(string), bool? includeFees = default(bool?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await OrdersApi.ListOrdersAsync(pageSize, cursor, orderBy, direction, user, status, minTimestamp, maxTimestamp, updatedMinTimestamp, updatedMaxTimestamp, buyTokenType, buyTokenId, buyAssetId, buyTokenAddress, buyTokenName, buyMinQuantity, buyMaxQuantity, buyMetadata, sellTokenType, sellTokenId, sellAssetId, sellTokenAddress, sellTokenName, sellMinQuantity, sellMaxQuantity, sellMetadata, auxiliaryFeePercentages, auxiliaryFeeRecipients, includeFees, operationIndex, cancellationToken).ConfigureAwait(false);
        }
	
		#endregion Orders

		#region Tokens
		
		public TokenDetails GetToken(string address, int operationIndex = 0)
        {
            return TokensApi.GetToken(address);
        }
		
		public async System.Threading.Tasks.Task<TokenDetails> GetTokenAsync(string address, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await TokensApi.GetTokenAsync(address, operationIndex, cancellationToken).ConfigureAwait(false);
        }

		public ListTokensResponse ListTokens(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string address = default(string), string symbols = default(string), int operationIndex = 0)
        {
            return TokensApi.ListTokens(pageSize, cursor, orderBy, direction, address, symbols);
        }

        public async System.Threading.Tasks.Task<ListTokensResponse> ListTokensAsync(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string address = default(string), string symbols = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await TokensApi.ListTokensAsync(pageSize, cursor, orderBy, direction, address, symbols, operationIndex, cancellationToken).ConfigureAwait(false);
        }

		#endregion Tokens

		#region Transfers

		public Transfer GetTransfer(string id, int operationIndex = 0)
        {
            return TransfersApi.GetTransfer(id);
        }

		public async System.Threading.Tasks.Task<Transfer> GetTransferAsync(string id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await TransfersApi.GetTransferAsync(id, operationIndex, cancellationToken).ConfigureAwait(false);
        }

		public ListTransfersResponse ListTransfers(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string user = default(string), string receiver = default(string), string status = default(string), string minTimestamp = default(string), string maxTimestamp = default(string), string tokenType = default(string), string tokenId = default(string), string assetId = default(string), string tokenAddress = default(string), string tokenName = default(string), string minQuantity = default(string), string maxQuantity = default(string), string metadata = default(string), int operationIndex = 0)
        {
            return TransfersApi.ListTransfers(pageSize, cursor, orderBy, direction, user, receiver, status, minTimestamp, maxTimestamp, tokenType, tokenId, assetId, tokenAddress, tokenName, minQuantity, maxQuantity, metadata);
        }

		public async System.Threading.Tasks.Task<ListTransfersResponse> ListTransfersAsync(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string user = default(string), string receiver = default(string), string status = default(string), string minTimestamp = default(string), string maxTimestamp = default(string), string tokenType = default(string), string tokenId = default(string), string assetId = default(string), string tokenAddress = default(string), string tokenName = default(string), string minQuantity = default(string), string maxQuantity = default(string), string metadata = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await TransfersApi.ListTransfersAsync(pageSize, cursor, orderBy, direction, user, receiver, status, minTimestamp, maxTimestamp, tokenType, tokenId, assetId, tokenAddress, tokenName, minQuantity, maxQuantity, metadata, operationIndex, cancellationToken).ConfigureAwait(false);
        }

		#endregion Transfers
		
		#region Trades

        public Trade GetTrade(string id, int operationIndex = 0)
        {
            return TradesApi.GetTrade(id);
        }

        public async System.Threading.Tasks.Task<Trade> GetTradeAsync(string id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await TradesApi.GetTradeAsync(id, operationIndex, cancellationToken).ConfigureAwait(false);
        }

		public ListTradesResponse ListTrades(string partyATokenType = default(string), string partyATokenAddress = default(string), string partyBTokenType = default(string), string partyBTokenAddress = default(string), string partyBTokenId = default(string), int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string minTimestamp = default(string), string maxTimestamp = default(string), int operationIndex = 0)
        {
            return TradesApi.ListTrades(partyATokenType, partyATokenAddress, partyBTokenType, partyBTokenAddress, partyBTokenId, pageSize, cursor, orderBy, direction, minTimestamp, maxTimestamp);
        }

        public async System.Threading.Tasks.Task<ListTradesResponse> ListTradesAsync(string partyATokenType = default(string), string partyATokenAddress = default(string), string partyBTokenType = default(string), string partyBTokenAddress = default(string), string partyBTokenId = default(string), int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string minTimestamp = default(string), string maxTimestamp = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await TradesApi.ListTradesAsync(partyATokenType, partyATokenAddress, partyBTokenType, partyBTokenAddress, partyBTokenId, pageSize, cursor, orderBy, direction, minTimestamp, maxTimestamp, operationIndex, cancellationToken).ConfigureAwait(false);
        }

		#endregion Trades

		#region Users

		public GetUsersApiResponse GetUsers(string user, int operationIndex = 0)
        {
            return UsersApi.GetUsers(user);
        }

        public async System.Threading.Tasks.Task<GetUsersApiResponse> GetUsersAsync(string user, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await UsersApi.GetUsersAsync(user, operationIndex, cancellationToken).ConfigureAwait(false);
        }

		#endregion Users

		#region Withdrawals
		
		public Withdrawal GetWithdrawal(string id, int operationIndex = 0)
        {
            return WithdrawalsApi.GetWithdrawal(id);
        }

        public async System.Threading.Tasks.Task<Withdrawal> GetWithdrawalAsync(string id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await WithdrawalsApi.GetWithdrawalAsync(id, operationIndex, cancellationToken).ConfigureAwait(false);
        }

		public ListWithdrawalsResponse ListWithdrawals(bool? withdrawnToWallet = default(bool?), string rollupStatus = default(string), int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string user = default(string), string status = default(string), string minTimestamp = default(string), string maxTimestamp = default(string), string tokenType = default(string), string tokenId = default(string), string assetId = default(string), string tokenAddress = default(string), string tokenName = default(string), string minQuantity = default(string), string maxQuantity = default(string), string metadata = default(string), int operationIndex = 0)
        {
            return WithdrawalsApi.ListWithdrawals(withdrawnToWallet, rollupStatus, pageSize, cursor, orderBy, direction, user, status, minTimestamp, maxTimestamp, tokenType, tokenId, assetId, tokenAddress, tokenName, minQuantity, maxQuantity, metadata);
        }

		public async System.Threading.Tasks.Task<ListWithdrawalsResponse> ListWithdrawalsAsync(bool? withdrawnToWallet = default(bool?), string rollupStatus = default(string), int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string user = default(string), string status = default(string), string minTimestamp = default(string), string maxTimestamp = default(string), string tokenType = default(string), string tokenId = default(string), string assetId = default(string), string tokenAddress = default(string), string tokenName = default(string), string minQuantity = default(string), string maxQuantity = default(string), string metadata = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
	        return await WithdrawalsApi.ListWithdrawalsAsync(withdrawnToWallet, rollupStatus, pageSize, cursor, orderBy, direction, user, status, minTimestamp, maxTimestamp, tokenType, tokenId, assetId, tokenAddress, tokenName, minQuantity, maxQuantity, metadata, operationIndex, cancellationToken).ConfigureAwait(false);
        }

		#endregion Withdrawals
    }
}