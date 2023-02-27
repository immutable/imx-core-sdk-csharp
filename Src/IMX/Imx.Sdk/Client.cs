using System.Numerics;
using Imx.Sdk.Gen.Api;
using Imx.Sdk.Gen.Client;
using Imx.Sdk.Gen.Model;
using System.Collections.Generic;

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

        public readonly IAssetsApi AssetsApi;
        public readonly IBalancesApi BalancesApi;
        public readonly ICollectionsApi CollectionsApi;
        public readonly IDepositsApi DepositsApi;
        public readonly IExchangesApi ExchangesApi;
        public readonly IMetadataApi MetadataApi;
        public readonly IMintsApi MintsApi;
        public readonly INftCheckoutPrimaryApi NftCheckoutPrimaryApi;
        public readonly IOrdersApi OrdersApi;
        public readonly ITokensApi TokensApi;
        public readonly ITradesApi TradesApi;
        public readonly ITransfersApi TransfersApi;
        public readonly IUsersApi UsersApi;
        public readonly IWithdrawalsApi WithdrawalsApi;

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
            this.ExchangesApi = new ExchangesApi(config);
            this.MetadataApi = new MetadataApi(config);
            this.MintsApi = new MintsApi(config);
            this.NftCheckoutPrimaryApi = new NftCheckoutPrimaryApi(config);
            this.OrdersApi = new OrdersApi(config);
            this.TokensApi = new TokensApi(config);
            this.TradesApi = new TradesApi(config);
            this.TransfersApi = new TransfersApi(config);
            this.UsersApi = new UsersApi(config);
            this.WithdrawalsApi = new WithdrawalsApi(config);
        }

        #region  Assets

        public Asset GetAsset(string tokenAddress, string tokenId, bool? includeFees = default(bool?))
        {
            return AssetsApi.GetAsset(tokenAddress, tokenId, includeFees);
        }

        public async System.Threading.Tasks.Task<Asset> GetAssetAsync(string tokenAddress, string tokenId, bool? includeFees = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await AssetsApi.GetAssetAsync(tokenAddress, tokenId, includeFees, 0, cancellationToken).ConfigureAwait(false);
        }

        public ListAssetsResponse ListAssets(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string user = default(string), string status = default(string), string name = default(string), string metadata = default(string), bool? sellOrders = default(bool?), bool? buyOrders = default(bool?), bool? includeFees = default(bool?), string collection = default(string), string updatedMinTimestamp = default(string), string updatedMaxTimestamp = default(string), string auxiliaryFeePercentages = default(string), string auxiliaryFeeRecipients = default(string))
        {
            return AssetsApi.ListAssets(pageSize, cursor, orderBy, direction, user, status, name, metadata, sellOrders, buyOrders, includeFees, collection, updatedMinTimestamp, updatedMaxTimestamp, auxiliaryFeePercentages, auxiliaryFeeRecipients);
        }

        public async System.Threading.Tasks.Task<ListAssetsResponse> ListAssetsAsync(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string user = default(string), string status = default(string), string name = default(string), string metadata = default(string), bool? sellOrders = default(bool?), bool? buyOrders = default(bool?), bool? includeFees = default(bool?), string collection = default(string), string updatedMinTimestamp = default(string), string updatedMaxTimestamp = default(string), string auxiliaryFeePercentages = default(string), string auxiliaryFeeRecipients = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await AssetsApi.ListAssetsAsync(pageSize, cursor, orderBy, direction, user, status, name, metadata, sellOrders, buyOrders, includeFees, collection, updatedMinTimestamp, updatedMaxTimestamp, auxiliaryFeePercentages, auxiliaryFeeRecipients, 0, cancellationToken).ConfigureAwait(false);
        }
        #endregion Assets

        #region Balances

        public Balance GetBalance(string owner, string address = "eth")
        {
            return BalancesApi.GetBalance(owner, address);
        }

        public async System.Threading.Tasks.Task<Balance> GetBalanceAsync(string owner, string address = "eth", System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await BalancesApi.GetBalanceAsync(owner, address, 0, cancellationToken).ConfigureAwait(false);
        }

        public ListBalancesResponse ListBalances(string owner, int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string))
        {
            return BalancesApi.ListBalances(owner, pageSize, cursor, orderBy, direction);
        }

        public async System.Threading.Tasks.Task<ListBalancesResponse> ListBalancesAsync(string owner, int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await BalancesApi.ListBalancesAsync(owner, pageSize, cursor, orderBy, direction, 0, cancellationToken).ConfigureAwait(false);
        }

        #endregion Balances

        #region Collections

        public Collection GetCollection(string address)
        {
            return CollectionsApi.GetCollection(address);
        }

        public async System.Threading.Tasks.Task<Collection> GetCollectionAsync(string address, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await CollectionsApi.GetCollectionAsync(address, 0, cancellationToken).ConfigureAwait(false);
        }

        public CollectionFilter ListCollectionFilters(string address, int? pageSize = default(int?), string nextPageToken = default(string))
        {
            return CollectionsApi.ListCollectionFilters(address, pageSize, nextPageToken);
        }

        public async System.Threading.Tasks.Task<CollectionFilter> ListCollectionFiltersAsync(string address, int? pageSize = default(int?), string nextPageToken = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await CollectionsApi.ListCollectionFiltersAsync(address, pageSize, nextPageToken, 0, cancellationToken).ConfigureAwait(false);
        }

        public ListCollectionsResponse ListCollections(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string blacklist = default(string), string whitelist = default(string), string keyword = default(string))
        {
            return CollectionsApi.ListCollections(pageSize, cursor, orderBy, direction, blacklist, whitelist, keyword);
        }

        public async System.Threading.Tasks.Task<ListCollectionsResponse> ListCollectionsAsync(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string blacklist = default(string), string whitelist = default(string), string keyword = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await CollectionsApi.ListCollectionsAsync(pageSize, cursor, orderBy, direction, blacklist, whitelist, keyword, 0, cancellationToken).ConfigureAwait(false);
        }

        #endregion Collections

        #region Deposits

        public Deposit GetDeposit(string id)
        {
            return DepositsApi.GetDeposit(id);
        }

        public async System.Threading.Tasks.Task<Deposit> GetDepositAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await DepositsApi.GetDepositAsync(id, 0, cancellationToken).ConfigureAwait(false);
        }

        public ListDepositsResponse ListDeposits(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string user = default(string), string status = default(string), string minTimestamp = default(string), string maxTimestamp = default(string), string tokenType = default(string), string tokenId = default(string), string assetId = default(string), string tokenAddress = default(string), string tokenName = default(string), string minQuantity = default(string), string maxQuantity = default(string), string metadata = default(string))
        {
            return DepositsApi.ListDeposits(pageSize, cursor, orderBy, direction, user, status, minTimestamp, maxTimestamp, tokenType, tokenId, assetId, tokenAddress, tokenName, minQuantity, maxQuantity, metadata);
        }

        public async System.Threading.Tasks.Task<ListDepositsResponse> ListDepositsAsync(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string user = default(string), string status = default(string), string minTimestamp = default(string), string maxTimestamp = default(string), string tokenType = default(string), string tokenId = default(string), string assetId = default(string), string tokenAddress = default(string), string tokenName = default(string), string minQuantity = default(string), string maxQuantity = default(string), string metadata = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await DepositsApi.ListDepositsAsync(pageSize, cursor, orderBy, direction, user, status, minTimestamp, maxTimestamp, tokenType, tokenId, assetId, tokenAddress, tokenName, minQuantity, maxQuantity, metadata, 0, cancellationToken).ConfigureAwait(false);
        }

        #endregion Deposits

        #region Exchanges

        public Exchange GetExchange(string id)
        {
            return ExchangesApi.GetExchange(id);
        }

        public async System.Threading.Tasks.Task<Exchange> GetExchangeAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await ExchangesApi.GetExchangeAsync(id, 0, cancellationToken).ConfigureAwait(false);
        }

        public GetTransactionsResponse GetExchanges(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), int? id = default(int?), string walletAddress = default(string), string status = default(string), string provider = default(string), string transferId = default(string))
        {
            return ExchangesApi.GetExchanges(pageSize, cursor, orderBy, direction, id, walletAddress, status, provider, transferId);
        }

        public async System.Threading.Tasks.Task<GetTransactionsResponse> GetExchangesAsync(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), int? id = default(int?), string walletAddress = default(string), string status = default(string), string provider = default(string), string transferId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await ExchangesApi.GetExchangesAsync(pageSize, cursor, orderBy, direction, id, walletAddress, status, provider, transferId, 0, cancellationToken).ConfigureAwait(false);
        }

        #endregion Exchanges

        #region Mints

        public Mint GetMint(string id)
        {
            return MintsApi.GetMint(id);
        }

        public async System.Threading.Tasks.Task<Mint> GetMintAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await MintsApi.GetMintAsync(id, 0, cancellationToken).ConfigureAwait(false);
        }

        public MintableTokenDetails GetMintableTokenDetailsByClientTokenId(string tokenAddress, string tokenId)
        {
            return MintsApi.GetMintableTokenDetailsByClientTokenId(tokenAddress, tokenId);
        }

        public async System.Threading.Tasks.Task<MintableTokenDetails> GetMintableTokenDetailsByClientTokenIdAsync(string tokenAddress, string tokenId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await MintsApi.GetMintableTokenDetailsByClientTokenIdAsync(tokenAddress, tokenId, 0, cancellationToken);
        }

        public ListMintsResponse ListMints(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string user = default(string), string status = default(string), string minTimestamp = default(string), string maxTimestamp = default(string), string tokenType = default(string), string tokenId = default(string), string assetId = default(string), string tokenName = default(string), string tokenAddress = default(string), string minQuantity = default(string), string maxQuantity = default(string), string metadata = default(string))
        {
            return MintsApi.ListMints(pageSize, cursor, orderBy, direction, user, status, minTimestamp, maxTimestamp, tokenType, tokenId, assetId, tokenName, tokenAddress, minQuantity, maxQuantity, metadata);
        }

        public async System.Threading.Tasks.Task<ListMintsResponse> ListMintsAsync(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string user = default(string), string status = default(string), string minTimestamp = default(string), string maxTimestamp = default(string), string tokenType = default(string), string tokenId = default(string), string assetId = default(string), string tokenName = default(string), string tokenAddress = default(string), string minQuantity = default(string), string maxQuantity = default(string), string metadata = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await MintsApi.ListMintsAsync(pageSize, cursor, orderBy, direction, user, status, minTimestamp, maxTimestamp, tokenType, tokenId, assetId, tokenName, tokenAddress, minQuantity, maxQuantity, metadata, 0, cancellationToken).ConfigureAwait(false);
        }

        #endregion Mints

        #region Metadata

        public List<MetadataSchemaProperty> GetMetadataSchema(string address)
        {
            return MetadataApi.GetMetadataSchema(address);
        }

        public async System.Threading.Tasks.Task<List<MetadataSchemaProperty>> GetMetadataSchemaAsync(string address, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await MetadataApi.GetMetadataSchemaAsync(address, 0, cancellationToken).ConfigureAwait(false);
        }

        #endregion Metadata

        #region NftCheckoutPrimary

        public NftprimarytransactionGetResponse GetNftPrimaryTransaction(string transactionId)
        {
            return NftCheckoutPrimaryApi.GetNftPrimaryTransaction(transactionId);
        }

        public async System.Threading.Tasks.Task<NftprimarytransactionGetResponse> GetNftPrimaryTransactionAsync(string transactionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await NftCheckoutPrimaryApi.GetNftPrimaryTransactionAsync(transactionId, 0, cancellationToken).ConfigureAwait(false);
        }


        public NftprimarytransactionListTransactionsResponse ListNftPrimaryTransactions(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string transactionId = default(string), string contractAddress = default(string), string sellerWalletAddress = default(string), string userWalletAddress = default(string), string status = default(string), string provider = default(string), string mintId = default(string))
        {
            return NftCheckoutPrimaryApi.GetNftPrimaryTransactions(pageSize, cursor, orderBy, direction, transactionId, contractAddress, sellerWalletAddress, userWalletAddress, status, provider, mintId);
        }

        public async System.Threading.Tasks.Task<NftprimarytransactionListTransactionsResponse> ListNftPrimaryTransactionsAsync(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string transactionId = default(string), string contractAddress = default(string), string sellerWalletAddress = default(string), string userWalletAddress = default(string), string status = default(string), string provider = default(string), string mintId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await NftCheckoutPrimaryApi.GetNftPrimaryTransactionsAsync(pageSize, cursor, orderBy, direction, transactionId, contractAddress, sellerWalletAddress, userWalletAddress, status, provider, mintId, 0, cancellationToken).ConfigureAwait(false);
        }

        public CurrencyWithLimits GetCurrenciesNFTCheckoutPrimary(string provider = default(string), bool? includeLimits = default(bool?))
        {
            return NftCheckoutPrimaryApi.GetCurrenciesNFTCheckoutPrimary(provider, includeLimits);
        }

        public async System.Threading.Tasks.Task<CurrencyWithLimits> GetCurrenciesNFTCheckoutPrimaryAsync(string provider = default(string), bool? includeLimits = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await NftCheckoutPrimaryApi.GetCurrenciesNFTCheckoutPrimaryAsync(provider, includeLimits, 0, cancellationToken).ConfigureAwait(false);
        }

        #endregion NftCheckoutPrimary

        #region Orders

        public Order GetOrder(string id, bool? includeFees = default(bool?), string auxiliaryFeePercentages = default(string), string auxiliaryFeeRecipients = default(string))
        {
            return OrdersApi.GetOrder(id, includeFees, auxiliaryFeePercentages, auxiliaryFeeRecipients);
        }

        public async System.Threading.Tasks.Task<Order> GetOrderAsync(string id, bool? includeFees = default(bool?), string auxiliaryFeePercentages = default(string), string auxiliaryFeeRecipients = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await OrdersApi.GetOrderAsync(id, includeFees, auxiliaryFeePercentages, auxiliaryFeeRecipients, 0, cancellationToken).ConfigureAwait(false);
        }

        public ListOrdersResponse ListOrders(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string user = default(string), string status = default(string), string minTimestamp = default(string), string maxTimestamp = default(string), string updatedMinTimestamp = default(string), string updatedMaxTimestamp = default(string), string buyTokenType = default(string), string buyTokenId = default(string), string buyAssetId = default(string), string buyTokenAddress = default(string), string buyTokenName = default(string), string buyMinQuantity = default(string), string buyMaxQuantity = default(string), string buyMetadata = default(string), string sellTokenType = default(string), string sellTokenId = default(string), string sellAssetId = default(string), string sellTokenAddress = default(string), string sellTokenName = default(string), string sellMinQuantity = default(string), string sellMaxQuantity = default(string), string sellMetadata = default(string), string auxiliaryFeePercentages = default(string), string auxiliaryFeeRecipients = default(string), bool? includeFees = default(bool?))
        {
            return OrdersApi.ListOrders(pageSize, cursor, orderBy, direction, user, status, minTimestamp, maxTimestamp, updatedMinTimestamp, updatedMaxTimestamp, buyTokenType, buyTokenId, buyAssetId, buyTokenAddress, buyTokenName, buyMinQuantity, buyMaxQuantity, buyMetadata, sellTokenType, sellTokenId, sellAssetId, sellTokenAddress, sellTokenName, sellMinQuantity, sellMaxQuantity, sellMetadata, auxiliaryFeePercentages, auxiliaryFeeRecipients, includeFees);
        }

        public async System.Threading.Tasks.Task<ListOrdersResponse> ListOrdersAsync(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string user = default(string), string status = default(string), string minTimestamp = default(string), string maxTimestamp = default(string), string updatedMinTimestamp = default(string), string updatedMaxTimestamp = default(string), string buyTokenType = default(string), string buyTokenId = default(string), string buyAssetId = default(string), string buyTokenAddress = default(string), string buyTokenName = default(string), string buyMinQuantity = default(string), string buyMaxQuantity = default(string), string buyMetadata = default(string), string sellTokenType = default(string), string sellTokenId = default(string), string sellAssetId = default(string), string sellTokenAddress = default(string), string sellTokenName = default(string), string sellMinQuantity = default(string), string sellMaxQuantity = default(string), string sellMetadata = default(string), string auxiliaryFeePercentages = default(string), string auxiliaryFeeRecipients = default(string), bool? includeFees = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await OrdersApi.ListOrdersAsync(pageSize, cursor, orderBy, direction, user, status, minTimestamp, maxTimestamp, updatedMinTimestamp, updatedMaxTimestamp, buyTokenType, buyTokenId, buyAssetId, buyTokenAddress, buyTokenName, buyMinQuantity, buyMaxQuantity, buyMetadata, sellTokenType, sellTokenId, sellAssetId, sellTokenAddress, sellTokenName, sellMinQuantity, sellMaxQuantity, sellMetadata, auxiliaryFeePercentages, auxiliaryFeeRecipients, includeFees, 0, cancellationToken).ConfigureAwait(false);
        }

        #endregion Orders

        #region Tokens

        public TokenDetails GetToken(string address)
        {
            return TokensApi.GetToken(address);
        }

        public async System.Threading.Tasks.Task<TokenDetails> GetTokenAsync(string address, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await TokensApi.GetTokenAsync(address, 0, cancellationToken).ConfigureAwait(false);
        }

        public ListTokensResponse ListTokens(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string address = default(string), string symbols = default(string))
        {
            return TokensApi.ListTokens(pageSize, cursor, orderBy, direction, address, symbols);
        }

        public async System.Threading.Tasks.Task<ListTokensResponse> ListTokensAsync(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string address = default(string), string symbols = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await TokensApi.ListTokensAsync(pageSize, cursor, orderBy, direction, address, symbols, 0, cancellationToken).ConfigureAwait(false);
        }

        #endregion Tokens

        #region Transfers

        public Transfer GetTransfer(string id)
        {
            return TransfersApi.GetTransfer(id);
        }

        public async System.Threading.Tasks.Task<Transfer> GetTransferAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await TransfersApi.GetTransferAsync(id, 0, cancellationToken).ConfigureAwait(false);
        }

        public ListTransfersResponse ListTransfers(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string user = default(string), string receiver = default(string), string status = default(string), string minTimestamp = default(string), string maxTimestamp = default(string), string tokenType = default(string), string tokenId = default(string), string assetId = default(string), string tokenAddress = default(string), string tokenName = default(string), string minQuantity = default(string), string maxQuantity = default(string), string metadata = default(string))
        {
            return TransfersApi.ListTransfers(pageSize, cursor, orderBy, direction, user, receiver, status, minTimestamp, maxTimestamp, tokenType, tokenId, assetId, tokenAddress, tokenName, minQuantity, maxQuantity, metadata);
        }

        public async System.Threading.Tasks.Task<ListTransfersResponse> ListTransfersAsync(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string user = default(string), string receiver = default(string), string status = default(string), string minTimestamp = default(string), string maxTimestamp = default(string), string tokenType = default(string), string tokenId = default(string), string assetId = default(string), string tokenAddress = default(string), string tokenName = default(string), string minQuantity = default(string), string maxQuantity = default(string), string metadata = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await TransfersApi.ListTransfersAsync(pageSize, cursor, orderBy, direction, user, receiver, status, minTimestamp, maxTimestamp, tokenType, tokenId, assetId, tokenAddress, tokenName, minQuantity, maxQuantity, metadata, 0, cancellationToken).ConfigureAwait(false);
        }

        #endregion Transfers

        #region Trades

        public Trade GetTrade(string id)
        {
            return TradesApi.GetTrade(id);
        }

        public async System.Threading.Tasks.Task<Trade> GetTradeAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await TradesApi.GetTradeAsync(id, 0, cancellationToken).ConfigureAwait(false);
        }

        public ListTradesResponse ListTrades(string partyATokenType = default(string), string partyATokenAddress = default(string), string partyBTokenType = default(string), string partyBTokenAddress = default(string), string partyBTokenId = default(string), int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string minTimestamp = default(string), string maxTimestamp = default(string))
        {
            return TradesApi.ListTrades(partyATokenType, partyATokenAddress, partyBTokenType, partyBTokenAddress, partyBTokenId, pageSize, cursor, orderBy, direction, minTimestamp, maxTimestamp);
        }

        public async System.Threading.Tasks.Task<ListTradesResponse> ListTradesAsync(string partyATokenType = default(string), string partyATokenAddress = default(string), string partyBTokenType = default(string), string partyBTokenAddress = default(string), string partyBTokenId = default(string), int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string minTimestamp = default(string), string maxTimestamp = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await TradesApi.ListTradesAsync(partyATokenType, partyATokenAddress, partyBTokenType, partyBTokenAddress, partyBTokenId, pageSize, cursor, orderBy, direction, minTimestamp, maxTimestamp, 0, cancellationToken).ConfigureAwait(false);
        }

        #endregion Trades

        #region Users

        public GetUsersApiResponse GetUsers(string user)
        {
            return UsersApi.GetUsers(user);
        }

        public async System.Threading.Tasks.Task<GetUsersApiResponse> GetUsersAsync(string user, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await UsersApi.GetUsersAsync(user, 0, cancellationToken).ConfigureAwait(false);
        }

        #endregion Users

        #region Withdrawals

        public Withdrawal GetWithdrawal(string id)
        {
            return WithdrawalsApi.GetWithdrawal(id);
        }

        public async System.Threading.Tasks.Task<Withdrawal> GetWithdrawalAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await WithdrawalsApi.GetWithdrawalAsync(id, 0, cancellationToken).ConfigureAwait(false);
        }

        public ListWithdrawalsResponse ListWithdrawals(bool? withdrawnToWallet = default(bool?), string rollupStatus = default(string), int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string user = default(string), string status = default(string), string minTimestamp = default(string), string maxTimestamp = default(string), string tokenType = default(string), string tokenId = default(string), string assetId = default(string), string tokenAddress = default(string), string tokenName = default(string), string minQuantity = default(string), string maxQuantity = default(string), string metadata = default(string))
        {
            return WithdrawalsApi.ListWithdrawals(withdrawnToWallet, rollupStatus, pageSize, cursor, orderBy, direction, user, status, minTimestamp, maxTimestamp, tokenType, tokenId, assetId, tokenAddress, tokenName, minQuantity, maxQuantity, metadata);
        }

        public async System.Threading.Tasks.Task<ListWithdrawalsResponse> ListWithdrawalsAsync(bool? withdrawnToWallet = default(bool?), string rollupStatus = default(string), int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string user = default(string), string status = default(string), string minTimestamp = default(string), string maxTimestamp = default(string), string tokenType = default(string), string tokenId = default(string), string assetId = default(string), string tokenAddress = default(string), string tokenName = default(string), string minQuantity = default(string), string maxQuantity = default(string), string metadata = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await WithdrawalsApi.ListWithdrawalsAsync(withdrawnToWallet, rollupStatus, pageSize, cursor, orderBy, direction, user, status, minTimestamp, maxTimestamp, tokenType, tokenId, assetId, tokenAddress, tokenName, minQuantity, maxQuantity, metadata, 0, cancellationToken).ConfigureAwait(false);
        }

        #endregion Withdrawals
    }
}