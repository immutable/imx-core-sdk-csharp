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
            EthereumRpc = "https://eth-sepolia.alchemyapi.io/v2/",
            RegistrationContractAddress = "0xDbA6129C02E69405622fAdc3d5A7f8d23eac3b97",
            CoreContractAddress = "0x2d5C349fD8464DA06a3f90b4B0E9195F3d1b7F98",
            ChainId = 11155111, // Sepolia
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

        /// <summary>
        /// Get details of an asset
        /// </summary>
        /// <remarks>
        /// Get details of an asset
        /// </remarks>
        /// <exception cref="api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenAddress">Address of the ERC721 contract</param>
        /// <param name="tokenId">Either ERC721 token ID or internal IMX ID</param>
        /// <param name="includeFees">Set flag to include fees associated with the asset (optional)</param>
        public Asset GetAsset(string tokenAddress, string tokenId, bool? includeFees = default(bool?))
        {
            return AssetsApi.GetAsset(tokenAddress, tokenId, includeFees);
        }

        /// <summary>
        /// Get details of an asset
        /// </summary>
        /// <remarks>
        /// Get details of an asset
        /// </remarks>
        /// <exception cref="api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenAddress">Address of the ERC721 contract</param>
        /// <param name="tokenId">Either ERC721 token ID or internal IMX ID</param>
        /// <param name="includeFees">Set flag to include fees associated with the asset (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Asset</returns>
        public async System.Threading.Tasks.Task<Asset> GetAssetAsync(string tokenAddress, string tokenId, bool? includeFees = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await AssetsApi.GetAssetAsync(tokenAddress, tokenId, includeFees, 0, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a list of assets Get a list of assets
        /// </summary>
        /// <exception cref="api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size of the result (optional)</param>
        /// <param name="cursor">Cursor (optional)</param>
        /// <param name="orderBy">Property to sort by (optional)</param>
        /// <param name="direction">Direction to sort (asc/desc) (optional)</param>
        /// <param name="user">Ethereum address of the user who owns these assets (optional)</param>
        /// <param name="status">Status of these assets (optional)</param>
        /// <param name="name">Name of the asset to search (optional)</param>
        /// <param name="metadata">URL JSON-encoded metadata filters for these assets. Javascript example: encodeURI(JSON.stringify({&#39;proto&#39;:[&#39;1147&#39;],&#39;quality&#39;:[&#39;Meteorite&#39;]})) (optional)</param>
        /// <param name="sellOrders">Set flag to true to fetch an array of sell order details with accepted status associated with the asset (optional)</param>
        /// <param name="buyOrders">Set flag to true to fetch an array of buy order details  with accepted status associated with the asset (optional)</param>
        /// <param name="includeFees">Set flag to include fees associated with the asset (optional)</param>
        /// <param name="collection">Collection contract address (optional)</param>
        /// <param name="updatedMinTimestamp">Minimum timestamp for when these assets were last updated, in ISO 8601 UTC format. Example: &#39;2022-05-27T00:10:22Z&#39; (optional)</param>
        /// <param name="updatedMaxTimestamp">Maximum timestamp for when these assets were last updated, in ISO 8601 UTC format. Example: &#39;2022-05-27T00:10:22Z&#39; (optional)</param>
        /// <param name="auxiliaryFeePercentages">Comma separated string of fee percentages that are to be paired with auxiliary_fee_recipients (optional)</param>
        /// <param name="auxiliaryFeeRecipients">Comma separated string of fee recipients that are to be paired with auxiliary_fee_percentages (optional)</param>
        /// <returns>ListAssetsResponse</returns>
        public ListAssetsResponse ListAssets(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string user = default(string), string status = default(string), string name = default(string), string metadata = default(string), bool? sellOrders = default(bool?), bool? buyOrders = default(bool?), bool? includeFees = default(bool?), string collection = default(string), string updatedMinTimestamp = default(string), string updatedMaxTimestamp = default(string), string auxiliaryFeePercentages = default(string), string auxiliaryFeeRecipients = default(string))
        {
            return AssetsApi.ListAssets(pageSize, cursor, orderBy, direction, user, status, name, metadata, sellOrders, buyOrders, includeFees, collection, updatedMinTimestamp, updatedMaxTimestamp, auxiliaryFeePercentages, auxiliaryFeeRecipients);
        }

        /// <summary>
        /// Get a list of assets Get a list of assets
        /// </summary>
        /// <exception cref="api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size of the result (optional)</param>
        /// <param name="cursor">Cursor (optional)</param>
        /// <param name="orderBy">Property to sort by (optional)</param>
        /// <param name="direction">Direction to sort (asc/desc) (optional)</param>
        /// <param name="user">Ethereum address of the user who owns these assets (optional)</param>
        /// <param name="status">Status of these assets (optional)</param>
        /// <param name="name">Name of the asset to search (optional)</param>
        /// <param name="metadata">URL JSON-encoded metadata filters for these assets. Javascript example: encodeURI(JSON.stringify({&#39;proto&#39;:[&#39;1147&#39;],&#39;quality&#39;:[&#39;Meteorite&#39;]})) (optional)</param>
        /// <param name="sellOrders">Set flag to true to fetch an array of sell order details with accepted status associated with the asset (optional)</param>
        /// <param name="buyOrders">Set flag to true to fetch an array of buy order details  with accepted status associated with the asset (optional)</param>
        /// <param name="includeFees">Set flag to include fees associated with the asset (optional)</param>
        /// <param name="collection">Collection contract address (optional)</param>
        /// <param name="updatedMinTimestamp">Minimum timestamp for when these assets were last updated, in ISO 8601 UTC format. Example: &#39;2022-05-27T00:10:22Z&#39; (optional)</param>
        /// <param name="updatedMaxTimestamp">Maximum timestamp for when these assets were last updated, in ISO 8601 UTC format. Example: &#39;2022-05-27T00:10:22Z&#39; (optional)</param>
        /// <param name="auxiliaryFeePercentages">Comma separated string of fee percentages that are to be paired with auxiliary_fee_recipients (optional)</param>
        /// <param name="auxiliaryFeeRecipients">Comma separated string of fee recipients that are to be paired with auxiliary_fee_percentages (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ListAssetsResponse</returns>
        public async System.Threading.Tasks.Task<ListAssetsResponse> ListAssetsAsync(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string user = default(string), string status = default(string), string name = default(string), string metadata = default(string), bool? sellOrders = default(bool?), bool? buyOrders = default(bool?), bool? includeFees = default(bool?), string collection = default(string), string updatedMinTimestamp = default(string), string updatedMaxTimestamp = default(string), string auxiliaryFeePercentages = default(string), string auxiliaryFeeRecipients = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await AssetsApi.ListAssetsAsync(pageSize, cursor, orderBy, direction, user, status, name, metadata, sellOrders, buyOrders, includeFees, collection, updatedMinTimestamp, updatedMaxTimestamp, auxiliaryFeePercentages, auxiliaryFeeRecipients, 0, cancellationToken).ConfigureAwait(false);
        }
        #endregion Assets

        #region Balances

        /// <summary>
        /// Fetches the token balances of the user
        /// </summary>
        /// <remarks>
        /// Fetches the token balances of the user
        /// </remarks>
        /// <exception cref="Imx.Sdk.Gen.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="owner">Address of the owner/user</param>
        /// <param name="address">Token address or 'eth'</param>
        /// <returns>Balance</returns>
        public Balance GetBalance(string owner, string address = "eth")
        {
            return BalancesApi.GetBalance(owner, address);
        }

        /// <summary>
        /// Fetches the token balances of the user
        /// </summary>
        /// <remarks>
        /// Fetches the token balances of the user
        /// </remarks>
        /// <exception cref="Imx.Sdk.Gen.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="owner">Address of the owner/user</param>
        /// <param name="address">Token address or 'eth'</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Balance</returns>
        public async System.Threading.Tasks.Task<Balance> GetBalanceAsync(string owner, string address = "eth", System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await BalancesApi.GetBalanceAsync(owner, address, 0, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a list of balances for given user
        /// </summary>
        /// <remarks>
        /// Get a list of balances for given user
        /// </remarks>
        /// <exception cref="Imx.Sdk.Gen.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="owner">Ethereum wallet address for user</param>
        /// <param name="pageSize">Page size of the result (optional)</param>
        /// <param name="cursor">Cursor (optional)</param>
        /// <param name="orderBy">Property to sort by (optional)</param>
        /// <param name="direction">Direction to sort (asc/desc) (optional)</param>
        /// <returns>ListBalancesResponse</returns>
        public ListBalancesResponse ListBalances(string owner, int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string))
        {
            return BalancesApi.ListBalances(owner, pageSize, cursor, orderBy, direction);
        }

        /// <summary>
        /// Get a list of balances for given user
        /// </summary>
        /// <remarks>
        /// Get a list of balances for given user
        /// </remarks>
        /// <exception cref="Imx.Sdk.Gen.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="owner">Ethereum wallet address for user</param>
        /// <param name="pageSize">Page size of the result (optional)</param>
        /// <param name="cursor">Cursor (optional)</param>
        /// <param name="orderBy">Property to sort by (optional)</param>
        /// <param name="direction">Direction to sort (asc/desc) (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ListBalancesResponse</returns>
        public async System.Threading.Tasks.Task<ListBalancesResponse> ListBalancesAsync(string owner, int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await BalancesApi.ListBalancesAsync(owner, pageSize, cursor, orderBy, direction, 0, cancellationToken).ConfigureAwait(false);
        }

        #endregion Balances

        #region Collections

        /// <summary>
        /// Get details of a collection at the given address
        /// </summary>
        /// <remarks>
        /// Get details of a collection at the given address
        /// </remarks>
        /// <exception cref="Imx.Sdk.Gen.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Collection contract address</param>
        /// <returns>Collection</returns>
        public Collection GetCollection(string address)
        {
            return CollectionsApi.GetCollection(address);
        }

        /// <summary>
        /// Get details of a collection at the given address
        /// </summary>
        /// <remarks>
        /// Get details of a collection at the given address
        /// </remarks>
        /// <exception cref="Imx.Sdk.Gen.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Collection contract address</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Collection</returns>
        public async System.Threading.Tasks.Task<Collection> GetCollectionAsync(string address, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await CollectionsApi.GetCollectionAsync(address, 0, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a list of collection filters
        /// </summary>
        /// <remarks>
        /// Get a list of collection filters
        /// </remarks>
        /// <exception cref="Imx.Sdk.Gen.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Collection contract address</param>
        /// <param name="pageSize">Page size of the result (optional)</param>
        /// <param name="nextPageToken">Next page token (optional)</param>
        /// <returns>CollectionFilter</returns>
        public CollectionFilter ListCollectionFilters(string address, int? pageSize = default(int?), string nextPageToken = default(string))
        {
            return CollectionsApi.ListCollectionFilters(address, pageSize, nextPageToken);
        }

        public async System.Threading.Tasks.Task<CollectionFilter> ListCollectionFiltersAsync(string address, int? pageSize = default(int?), string nextPageToken = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await CollectionsApi.ListCollectionFiltersAsync(address, pageSize, nextPageToken, 0, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a list of collections
        /// </summary>
        /// <remarks>
        /// Get a list of collections
        /// </remarks>
        /// <exception cref="Imx.Sdk.Gen.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size of the result (optional)</param>
        /// <param name="cursor">Cursor (optional)</param>
        /// <param name="orderBy">Property to sort by (optional)</param>
        /// <param name="direction">Direction to sort (asc/desc) (optional)</param>
        /// <param name="blacklist">List of collections not to be included, separated by commas (optional)</param>
        /// <param name="whitelist">List of collections to be included, separated by commas (optional)</param>
        /// <param name="keyword">Keyword to search in collection name and description (optional)</param>
        /// <returns>ListCollectionsResponse</returns>
        public ListCollectionsResponse ListCollections(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string blacklist = default(string), string whitelist = default(string), string keyword = default(string))
        {
            return CollectionsApi.ListCollections(pageSize, cursor, orderBy, direction, blacklist, whitelist, keyword);
        }

        /// <summary>
        /// Get a list of collections
        /// </summary>
        /// <remarks>
        /// Get a list of collections
        /// </remarks>
        /// <exception cref="Imx.Sdk.Gen.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size of the result (optional)</param>
        /// <param name="cursor">Cursor (optional)</param>
        /// <param name="orderBy">Property to sort by (optional)</param>
        /// <param name="direction">Direction to sort (asc/desc) (optional)</param>
        /// <param name="blacklist">List of collections not to be included, separated by commas (optional)</param>
        /// <param name="whitelist">List of collections to be included, separated by commas (optional)</param>
        /// <param name="keyword">Keyword to search in collection name and description (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ListCollectionsResponse</returns>
        public async System.Threading.Tasks.Task<ListCollectionsResponse> ListCollectionsAsync(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string blacklist = default(string), string whitelist = default(string), string keyword = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await CollectionsApi.ListCollectionsAsync(pageSize, cursor, orderBy, direction, blacklist, whitelist, keyword, 0, cancellationToken).ConfigureAwait(false);
        }

        #endregion Collections

        #region Deposits

        /// <summary>
        /// Get details of a deposit with the given ID
        /// </summary>
        /// <remarks>
        /// Get details of a deposit with the given ID
        /// </remarks>
        /// <exception cref="api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Deposit ID</param>
        /// <returns>Deposit</returns>
        public Deposit GetDeposit(string id)
        {
            return DepositsApi.GetDeposit(id);
        }

        /// <summary>
        /// Get details of a deposit with the given ID
        /// </summary>
        /// <remarks>
        /// Get details of a deposit with the given ID
        /// </remarks>
        /// <exception cref="api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Deposit ID</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Deposit</returns>
        public async System.Threading.Tasks.Task<Deposit> GetDepositAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await DepositsApi.GetDepositAsync(id, 0, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a list of deposits
        /// </summary>
        /// <remarks>
        /// Get a list of deposits
        /// </remarks>
        /// <exception cref="api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size of the result (optional)</param>
        /// <param name="cursor">Cursor (optional)</param>
        /// <param name="orderBy">Property to sort by (optional)</param>
        /// <param name="direction">Direction to sort (asc/desc) (optional)</param>
        /// <param name="user">Ethereum address of the user who submitted this deposit (optional)</param>
        /// <param name="status">Status of this deposit (optional)</param>
        /// <param name="minTimestamp">Minimum timestamp for this deposit, in ISO 8601 UTC format. Example: &#39;2022-05-27T00:10:22Z&#39; (optional)</param>
        /// <param name="maxTimestamp">Maximum timestamp for this deposit, in ISO 8601 UTC format. Example: &#39;2022-05-27T00:10:22Z&#39; (optional)</param>
        /// <param name="tokenType">Token type of the deposited asset (optional)</param>
        /// <param name="tokenId">ERC721 Token ID of the minted asset (optional)</param>
        /// <param name="assetId">Internal IMX ID of the minted asset (optional)</param>
        /// <param name="tokenAddress">Token address of the deposited asset (optional)</param>
        /// <param name="tokenName">Token name of the deposited asset (optional)</param>
        /// <param name="minQuantity">Min quantity for the deposited asset (optional)</param>
        /// <param name="maxQuantity">Max quantity for the deposited asset (optional)</param>
        /// <param name="metadata">JSON-encoded metadata filters for the deposited asset (optional)</param>
        /// <returns>ListDepositsResponse</returns>
        public ListDepositsResponse ListDeposits(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string user = default(string), string status = default(string), string minTimestamp = default(string), string maxTimestamp = default(string), string tokenType = default(string), string tokenId = default(string), string assetId = default(string), string tokenAddress = default(string), string tokenName = default(string), string minQuantity = default(string), string maxQuantity = default(string), string metadata = default(string))
        {
            return DepositsApi.ListDeposits(pageSize, cursor, orderBy, direction, user, status, minTimestamp, maxTimestamp, tokenType, tokenId, assetId, tokenAddress, tokenName, minQuantity, maxQuantity, metadata);
        }

        /// <summary>
        /// Get a list of deposits
        /// </summary>
        /// <remarks>
        /// Get a list of deposits
        /// </remarks>
        /// <exception cref="api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size of the result (optional)</param>
        /// <param name="cursor">Cursor (optional)</param>
        /// <param name="orderBy">Property to sort by (optional)</param>
        /// <param name="direction">Direction to sort (asc/desc) (optional)</param>
        /// <param name="user">Ethereum address of the user who submitted this deposit (optional)</param>
        /// <param name="status">Status of this deposit (optional)</param>
        /// <param name="minTimestamp">Minimum timestamp for this deposit, in ISO 8601 UTC format. Example: &#39;2022-05-27T00:10:22Z&#39; (optional)</param>
        /// <param name="maxTimestamp">Maximum timestamp for this deposit, in ISO 8601 UTC format. Example: &#39;2022-05-27T00:10:22Z&#39; (optional)</param>
        /// <param name="tokenType">Token type of the deposited asset (optional)</param>
        /// <param name="tokenId">ERC721 Token ID of the minted asset (optional)</param>
        /// <param name="assetId">Internal IMX ID of the minted asset (optional)</param>
        /// <param name="tokenAddress">Token address of the deposited asset (optional)</param>
        /// <param name="tokenName">Token name of the deposited asset (optional)</param>
        /// <param name="minQuantity">Min quantity for the deposited asset (optional)</param>
        /// <param name="maxQuantity">Max quantity for the deposited asset (optional)</param>
        /// <param name="metadata">JSON-encoded metadata filters for the deposited asset (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ListDepositsResponse</returns>
        public async System.Threading.Tasks.Task<ListDepositsResponse> ListDepositsAsync(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string user = default(string), string status = default(string), string minTimestamp = default(string), string maxTimestamp = default(string), string tokenType = default(string), string tokenId = default(string), string assetId = default(string), string tokenAddress = default(string), string tokenName = default(string), string minQuantity = default(string), string maxQuantity = default(string), string metadata = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await DepositsApi.ListDepositsAsync(pageSize, cursor, orderBy, direction, user, status, minTimestamp, maxTimestamp, tokenType, tokenId, assetId, tokenAddress, tokenName, minQuantity, maxQuantity, metadata, 0, cancellationToken).ConfigureAwait(false);
        }

        #endregion Deposits

        #region Exchanges

        /// <summary>
        /// Get an exchange by ID
        /// </summary>
        /// <remarks>
        /// Get an exchange by ID
        /// </remarks>
        /// <exception cref="Imx.Sdk.Gen.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Exchange ID</param>
        /// <returns>Exchange</returns>
        public Exchange GetExchange(string id)
        {
            return ExchangesApi.GetExchange(id);
        }

        /// <summary>
        /// Get an exchange by ID
        /// </summary>
        /// <remarks>
        /// Get an exchange by ID
        /// </remarks>
        /// <exception cref="Imx.Sdk.Gen.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Exchange ID</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Exchange</returns>
        public async System.Threading.Tasks.Task<Exchange> GetExchangeAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await ExchangesApi.GetExchangeAsync(id, 0, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns a list of exchanges based on the request
        /// </summary>
        /// <remarks>
        /// Returns a list of exchanges based on the request
        /// </remarks>
        /// <exception cref="Imx.Sdk.Gen.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size of the result (optional)</param>
        /// <param name="cursor">Cursor (optional)</param>
        /// <param name="orderBy">Property to sort by (optional)</param>
        /// <param name="direction">Direction to sort (optional)</param>
        /// <param name="id">Transaction ID (optional)</param>
        /// <param name="walletAddress">Ethereum address of the user who created transaction (optional)</param>
        /// <param name="status">Transaction status (optional)</param>
        /// <param name="provider">Provider name (optional)</param>
        /// <param name="transferId">Transfer ID (optional)</param>
        /// <returns>GetTransactionsResponse</returns>
        public GetTransactionsResponse GetExchanges(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), int? id = default(int?), string walletAddress = default(string), string status = default(string), string provider = default(string), string transferId = default(string))
        {
            return ExchangesApi.GetExchanges(pageSize, cursor, orderBy, direction, id, walletAddress, status, provider, transferId);
        }

        /// <summary>
        /// Returns a list of exchanges based on the request
        /// </summary>
        /// <remarks>
        /// Returns a list of exchanges based on the request
        /// </remarks>
        /// <exception cref="Imx.Sdk.Gen.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size of the result (optional)</param>
        /// <param name="cursor">Cursor (optional)</param>
        /// <param name="orderBy">Property to sort by (optional)</param>
        /// <param name="direction">Direction to sort (optional)</param>
        /// <param name="id">Transaction ID (optional)</param>
        /// <param name="walletAddress">Ethereum address of the user who created transaction (optional)</param>
        /// <param name="status">Transaction status (optional)</param>
        /// <param name="provider">Provider name (optional)</param>
        /// <param name="transferId">Transfer ID (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GetTransactionsResponse</returns>
        public async System.Threading.Tasks.Task<GetTransactionsResponse> GetExchangesAsync(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), int? id = default(int?), string walletAddress = default(string), string status = default(string), string provider = default(string), string transferId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await ExchangesApi.GetExchangesAsync(pageSize, cursor, orderBy, direction, id, walletAddress, status, provider, transferId, 0, cancellationToken).ConfigureAwait(false);
        }

        #endregion Exchanges

        #region Metadata

        /// <summary>
        /// Get collection metadata schema
        /// </summary>
        /// <remarks>
        /// Get collection metadata schema
        /// </remarks>
        /// <exception cref="Imx.Sdk.Gen.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Collection contract address</param>
        /// <returns>List&lt;MetadataSchemaProperty&gt;</returns>
        public List<MetadataSchemaProperty> GetMetadataSchema(string address)
        {
            return MetadataApi.GetMetadataSchema(address);
        }

        /// <summary>
        /// Get collection metadata schema
        /// </summary>
        /// <remarks>
        /// Get collection metadata schema
        /// </remarks>
        /// <exception cref="Imx.Sdk.Gen.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Collection contract address</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;MetadataSchemaProperty&gt;</returns>
        public async System.Threading.Tasks.Task<List<MetadataSchemaProperty>> GetMetadataSchemaAsync(string address, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await MetadataApi.GetMetadataSchemaAsync(address, 0, cancellationToken).ConfigureAwait(false);
        }
        #endregion Metadata

        #region Mints

        /// <summary>
        /// Get details of a mint with the given ID
        /// </summary>
        /// <remarks>
        /// Get details of a mint with the given ID
        /// </remarks>
        /// <exception cref="api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Mint ID. This is the transaction_id returned from listMints</param>
        /// <returns>Mint</returns>
        public Mint GetMint(string id)
        {
            return MintsApi.GetMint(id);
        }

        /// <summary>
        /// Get details of a mint with the given ID
        /// </summary>
        /// <remarks>
        /// Get details of a mint with the given ID
        /// </remarks>
        /// <exception cref="api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Mint ID. This is the transaction_id returned from listMints</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Mint</returns>
        public async System.Threading.Tasks.Task<Mint> GetMintAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await MintsApi.GetMintAsync(id, 0, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get details of a mintable token with the given token address and token ID
        /// </summary>
        /// <remarks>
        /// Get details of a mintable token with the given token address and token ID
        /// </remarks>
        /// <exception cref="Imx.Sdk.Gen.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenAddress">Address of the ERC721 contract</param>
        /// <param name="tokenId">ERC721 token ID</param>
        /// <returns>MintableTokenDetails</returns>
        public MintableTokenDetails GetMintableTokenDetailsByClientTokenId(string tokenAddress, string tokenId)
        {
            return MintsApi.GetMintableTokenDetailsByClientTokenId(tokenAddress, tokenId);
        }

        /// <summary>
        /// Get details of a mintable token with the given token address and token ID
        /// </summary>
        /// <remarks>
        /// Get details of a mintable token with the given token address and token ID
        /// </remarks>
        /// <exception cref="Imx.Sdk.Gen.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenAddress">Address of the ERC721 contract</param>
        /// <param name="tokenId">ERC721 token ID</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of MintableTokenDetails</returns>
        public async System.Threading.Tasks.Task<MintableTokenDetails> GetMintableTokenDetailsByClientTokenIdAsync(string tokenAddress, string tokenId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await MintsApi.GetMintableTokenDetailsByClientTokenIdAsync(tokenAddress, tokenId, 0, cancellationToken);
        }

        /// <summary>
        /// Get a list of mints
        /// </summary>
        /// <remarks>
        /// Get information about token mints. If you want to get information about tokens that have already been minted, use the listAssets endpoint.
        /// </remarks>
        /// <exception cref="api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size of the result (optional)</param>
        /// <param name="cursor">Cursor (optional)</param>
        /// <param name="orderBy">Property to sort by (optional)</param>
        /// <param name="direction">Direction to sort (asc/desc) (optional)</param>
        /// <param name="user">Ethereum address of the user who submitted this mint (optional)</param>
        /// <param name="status">Status of this mint (optional)</param>
        /// <param name="minTimestamp">Minimum timestamp for this mint, in ISO 8601 UTC format. Example: &#39;2022-05-27T00:10:22Z&#39; (optional)</param>
        /// <param name="maxTimestamp">Maximum timestamp for this mint, in ISO 8601 UTC format. Example: &#39;2022-05-27T00:10:22Z&#39; (optional)</param>
        /// <param name="tokenType">Token type of the minted asset (optional)</param>
        /// <param name="tokenId">ERC721 Token ID of the minted asset (optional)</param>
        /// <param name="assetId">[DEPRECATED] Internal IMX ID of the minted asset (optional)</param>
        /// <param name="tokenName">Token Name of the minted asset (optional)</param>
        /// <param name="tokenAddress">Token address of the minted asset (optional)</param>
        /// <param name="minQuantity">Min quantity for the minted asset (optional)</param>
        /// <param name="maxQuantity">Max quantity for the minted asset (optional)</param>
        /// <param name="metadata">JSON-encoded metadata filters for the minted asset (optional)</param>
        /// <returns>ListMintsResponse</returns>
        public ListMintsResponse ListMints(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string user = default(string), string status = default(string), string minTimestamp = default(string), string maxTimestamp = default(string), string tokenType = default(string), string tokenId = default(string), string assetId = default(string), string tokenName = default(string), string tokenAddress = default(string), string minQuantity = default(string), string maxQuantity = default(string), string metadata = default(string))
        {
            return MintsApi.ListMints(pageSize, cursor, orderBy, direction, user, status, minTimestamp, maxTimestamp, tokenType, tokenId, assetId, tokenName, tokenAddress, minQuantity, maxQuantity, metadata);
        }

        /// <summary>
        /// Get a list of mints
        /// </summary>
        /// <remarks>
        /// Get information about token mints. If you want to get information about tokens that have already been minted, use the listAssets endpoint.
        /// </remarks>
        /// <exception cref="api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size of the result (optional)</param>
        /// <param name="cursor">Cursor (optional)</param>
        /// <param name="orderBy">Property to sort by (optional)</param>
        /// <param name="direction">Direction to sort (asc/desc) (optional)</param>
        /// <param name="user">Ethereum address of the user who submitted this mint (optional)</param>
        /// <param name="status">Status of this mint (optional)</param>
        /// <param name="minTimestamp">Minimum timestamp for this mint, in ISO 8601 UTC format. Example: &#39;2022-05-27T00:10:22Z&#39; (optional)</param>
        /// <param name="maxTimestamp">Maximum timestamp for this mint, in ISO 8601 UTC format. Example: &#39;2022-05-27T00:10:22Z&#39; (optional)</param>
        /// <param name="tokenType">Token type of the minted asset (optional)</param>
        /// <param name="tokenId">ERC721 Token ID of the minted asset (optional)</param>
        /// <param name="assetId">[DEPRECATED] Internal IMX ID of the minted asset (optional)</param>
        /// <param name="tokenName">Token Name of the minted asset (optional)</param>
        /// <param name="tokenAddress">Token address of the minted asset (optional)</param>
        /// <param name="minQuantity">Min quantity for the minted asset (optional)</param>
        /// <param name="maxQuantity">Max quantity for the minted asset (optional)</param>
        /// <param name="metadata">JSON-encoded metadata filters for the minted asset (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ListMintsResponse</returns>
        public async System.Threading.Tasks.Task<ListMintsResponse> ListMintsAsync(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string user = default(string), string status = default(string), string minTimestamp = default(string), string maxTimestamp = default(string), string tokenType = default(string), string tokenId = default(string), string assetId = default(string), string tokenName = default(string), string tokenAddress = default(string), string minQuantity = default(string), string maxQuantity = default(string), string metadata = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await MintsApi.ListMintsAsync(pageSize, cursor, orderBy, direction, user, status, minTimestamp, maxTimestamp, tokenType, tokenId, assetId, tokenName, tokenAddress, minQuantity, maxQuantity, metadata, 0, cancellationToken).ConfigureAwait(false);
        }

        #endregion Mints

        #region NftCheckoutPrimary

        /// <summary>
        /// Get NFT primary sale transaction by id
        /// </summary>
        /// <remarks>
        /// given a transaction id, returns the corresponding transaction representing a mint executed from a card payment
        /// </remarks>
        /// <exception cref="Imx.Sdk.Gen.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionId">Transaction id</param>
        /// <returns>NftprimarytransactionGetResponse</returns>
        public NftprimarytransactionGetResponse GetNftPrimaryTransaction(string transactionId)
        {
            return NftCheckoutPrimaryApi.GetNftPrimaryTransaction(transactionId);
        }

        /// <summary>
        /// Get NFT primary sale transaction by id
        /// </summary>
        /// <remarks>
        /// given a transaction id, returns the corresponding transaction representing a mint executed from a card payment
        /// </remarks>
        /// <exception cref="Imx.Sdk.Gen.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionId">Transaction id</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of NftprimarytransactionGetResponse</returns>
        public async System.Threading.Tasks.Task<NftprimarytransactionGetResponse> GetNftPrimaryTransactionAsync(string transactionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await NftCheckoutPrimaryApi.GetNftPrimaryTransactionAsync(transactionId, 0, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a list of NFT primary sales transactions
        /// </summary>
        /// <remarks>
        /// Returns a list of NFT primary sales transactions
        /// </remarks>
        /// <exception cref="Imx.Sdk.Gen.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size of the result (optional)</param>
        /// <param name="cursor">Cursor (optional)</param>
        /// <param name="orderBy">Property to sort by (optional)</param>
        /// <param name="direction">Direction to sort (asc/desc) (optional)</param>
        /// <param name="transactionId">Transaction id (optional)</param>
        /// <param name="contractAddress">Contract address of the asset (optional)</param>
        /// <param name="sellerWalletAddress">Ethereum address of the seller (optional)</param>
        /// <param name="userWalletAddress">Ethereum address of the user who wants to create transaction (optional)</param>
        /// <param name="status">Transaction status (optional)</param>
        /// <param name="provider">Checkout provider name (optional)</param>
        /// <param name="mintId">Minting transaction ID - see mintTokens response (optional)</param>
        /// <returns>NftprimarytransactionListTransactionsResponse</returns>
        public NftprimarytransactionListTransactionsResponse ListNftPrimaryTransactions(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string transactionId = default(string), string contractAddress = default(string), string sellerWalletAddress = default(string), string userWalletAddress = default(string), string status = default(string), string provider = default(string), string mintId = default(string))
        {
            return NftCheckoutPrimaryApi.GetNftPrimaryTransactions(pageSize, cursor, orderBy, direction, transactionId, contractAddress, sellerWalletAddress, userWalletAddress, status, provider, mintId);
        }

        /// <summary>
        /// Get a list of NFT primary sales transactions
        /// </summary>
        /// <remarks>
        /// Returns a list of NFT primary sales transactions
        /// </remarks>
        /// <exception cref="Imx.Sdk.Gen.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size of the result (optional)</param>
        /// <param name="cursor">Cursor (optional)</param>
        /// <param name="orderBy">Property to sort by (optional)</param>
        /// <param name="direction">Direction to sort (asc/desc) (optional)</param>
        /// <param name="transactionId">Transaction id (optional)</param>
        /// <param name="contractAddress">Contract address of the asset (optional)</param>
        /// <param name="sellerWalletAddress">Ethereum address of the seller (optional)</param>
        /// <param name="userWalletAddress">Ethereum address of the user who wants to create transaction (optional)</param>
        /// <param name="status">Transaction status (optional)</param>
        /// <param name="provider">Checkout provider name (optional)</param>
        /// <param name="mintId">Minting transaction ID - see mintTokens response (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of NftprimarytransactionListTransactionsResponse</returns>
        public async System.Threading.Tasks.Task<NftprimarytransactionListTransactionsResponse> ListNftPrimaryTransactionsAsync(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string transactionId = default(string), string contractAddress = default(string), string sellerWalletAddress = default(string), string userWalletAddress = default(string), string status = default(string), string provider = default(string), string mintId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await NftCheckoutPrimaryApi.GetNftPrimaryTransactionsAsync(pageSize, cursor, orderBy, direction, transactionId, contractAddress, sellerWalletAddress, userWalletAddress, status, provider, mintId, 0, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get currencies with limits
        /// </summary>
        /// <remarks>
        /// Returns a list of supported currencies and their limits
        /// </remarks>
        /// <exception cref="Imx.Sdk.Gen.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="provider">Provider name (optional)</param>
        /// <param name="includeLimits">Flag if limits should be included in the response or not (optional)</param>
        /// <returns>CurrencyWithLimits</returns>
        public CurrencyWithLimits GetCurrenciesNFTCheckoutPrimary(string provider = default(string), bool? includeLimits = default(bool?))
        {
            return NftCheckoutPrimaryApi.GetCurrenciesNFTCheckoutPrimary(provider, includeLimits);
        }

        /// <summary>
        /// Get currencies with limits
        /// </summary>
        /// <remarks>
        /// Returns a list of supported currencies and their limits
        /// </remarks>
        /// <exception cref="Imx.Sdk.Gen.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="provider">Provider name (optional)</param>
        /// <param name="includeLimits">Flag if limits should be included in the response or not (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CurrencyWithLimits</returns>
        public async System.Threading.Tasks.Task<CurrencyWithLimits> GetCurrenciesNFTCheckoutPrimaryAsync(string provider = default(string), bool? includeLimits = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await NftCheckoutPrimaryApi.GetCurrenciesNFTCheckoutPrimaryAsync(provider, includeLimits, 0, cancellationToken).ConfigureAwait(false);
        }

        #endregion NftCheckoutPrimary

        #region Orders

        /// <summary>
        /// Get details of an order with the given ID
        /// </summary>
        /// <remarks>
        /// Get details of an order with the given ID
        /// </remarks>
        /// <exception cref="api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Order ID</param>
        /// <param name="includeFees">Set flag to true to include fee body for the order (optional)</param>
        /// <param name="auxiliaryFeePercentages">Comma separated string of fee percentages that are to be paired with auxiliary_fee_recipients (optional)</param>
        /// <param name="auxiliaryFeeRecipients">Comma separated string of fee recipients that are to be paired with auxiliary_fee_percentages (optional)</param>
        /// <returns>Order</returns>
        public Order GetOrder(string id, bool? includeFees = default(bool?), string auxiliaryFeePercentages = default(string), string auxiliaryFeeRecipients = default(string))
        {
            return OrdersApi.GetOrder(id, includeFees, auxiliaryFeePercentages, auxiliaryFeeRecipients);
        }

        /// <summary>
        /// Get details of an order with the given ID
        /// </summary>
        /// <remarks>
        /// Get details of an order with the given ID
        /// </remarks>
        /// <exception cref="api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Order ID</param>
        /// <param name="includeFees">Set flag to true to include fee body for the order (optional)</param>
        /// <param name="auxiliaryFeePercentages">Comma separated string of fee percentages that are to be paired with auxiliary_fee_recipients (optional)</param>
        /// <param name="auxiliaryFeeRecipients">Comma separated string of fee recipients that are to be paired with auxiliary_fee_percentages (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Order</returns>
        public async System.Threading.Tasks.Task<Order> GetOrderAsync(string id, bool? includeFees = default(bool?), string auxiliaryFeePercentages = default(string), string auxiliaryFeeRecipients = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await OrdersApi.GetOrderAsync(id, includeFees, auxiliaryFeePercentages, auxiliaryFeeRecipients, 0, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a list of orders
        /// </summary>
        /// <remarks>
        /// Get a list of orders
        /// </remarks>
        /// <exception cref="api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size of the result (optional)</param>
        /// <param name="cursor">Cursor (optional)</param>
        /// <param name="orderBy">Property to sort by (optional)</param>
        /// <param name="direction">Direction to sort (asc/desc) (optional)</param>
        /// <param name="user">Ethereum address of the user who submitted this order (optional)</param>
        /// <param name="status">Status of this order (optional)</param>
        /// <param name="minTimestamp">Minimum created at timestamp for this order, in ISO 8601 UTC format. Example: &#39;2022-05-27T00:10:22Z&#39; (optional)</param>
        /// <param name="maxTimestamp">Maximum created at timestamp for this order, in ISO 8601 UTC format. Example: &#39;2022-05-27T00:10:22Z&#39; (optional)</param>
        /// <param name="updatedMinTimestamp">Minimum updated at timestamp for this order, in ISO 8601 UTC format. Example: &#39;2022-05-27T00:10:22Z&#39; (optional)</param>
        /// <param name="updatedMaxTimestamp">Maximum updated at timestamp for this order, in ISO 8601 UTC format. Example: &#39;2022-05-27T00:10:22Z&#39; (optional)</param>
        /// <param name="buyTokenType">Token type of the asset this order buys (optional)</param>
        /// <param name="buyTokenId">ERC721 Token ID of the asset this order buys (optional)</param>
        /// <param name="buyAssetId">Internal IMX ID of the asset this order buys (optional)</param>
        /// <param name="buyTokenAddress">Token address of the asset this order buys (optional)</param>
        /// <param name="buyTokenName">Token name of the asset this order buys (optional)</param>
        /// <param name="buyMinQuantity">Min quantity for the asset this order buys (optional)</param>
        /// <param name="buyMaxQuantity">Max quantity for the asset this order buys (optional)</param>
        /// <param name="buyMetadata">JSON-encoded metadata filters for the asset this order buys (optional)</param>
        /// <param name="sellTokenType">Token type of the asset this order sells (optional)</param>
        /// <param name="sellTokenId">ERC721 Token ID of the asset this order sells (optional)</param>
        /// <param name="sellAssetId">Internal IMX ID of the asset this order sells (optional)</param>
        /// <param name="sellTokenAddress">Token address of the asset this order sells (optional)</param>
        /// <param name="sellTokenName">Token name of the asset this order sells (optional)</param>
        /// <param name="sellMinQuantity">Min quantity for the asset this order sells (optional)</param>
        /// <param name="sellMaxQuantity">Max quantity for the asset this order sells (optional)</param>
        /// <param name="sellMetadata">JSON-encoded metadata filters for the asset this order sells (optional)</param>
        /// <param name="auxiliaryFeePercentages">Comma separated string of fee percentages that are to be paired with auxiliary_fee_recipients (optional)</param>
        /// <param name="auxiliaryFeeRecipients">Comma separated string of fee recipients that are to be paired with auxiliary_fee_percentages (optional)</param>
        /// <param name="includeFees">Set flag to true to include fee object for orders (optional)</param>
        /// <returns>ListOrdersResponse</returns>
        public ListOrdersResponse ListOrders(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string user = default(string), string status = default(string), string minTimestamp = default(string), string maxTimestamp = default(string), string updatedMinTimestamp = default(string), string updatedMaxTimestamp = default(string), string buyTokenType = default(string), string buyTokenId = default(string), string buyAssetId = default(string), string buyTokenAddress = default(string), string buyTokenName = default(string), string buyMinQuantity = default(string), string buyMaxQuantity = default(string), string buyMetadata = default(string), string sellTokenType = default(string), string sellTokenId = default(string), string sellAssetId = default(string), string sellTokenAddress = default(string), string sellTokenName = default(string), string sellMinQuantity = default(string), string sellMaxQuantity = default(string), string sellMetadata = default(string), string auxiliaryFeePercentages = default(string), string auxiliaryFeeRecipients = default(string), bool? includeFees = default(bool?))
        {
            return OrdersApi.ListOrders(pageSize, cursor, orderBy, direction, user, status, minTimestamp, maxTimestamp, updatedMinTimestamp, updatedMaxTimestamp, buyTokenType, buyTokenId, buyAssetId, buyTokenAddress, buyTokenName, buyMinQuantity, buyMaxQuantity, buyMetadata, sellTokenType, sellTokenId, sellAssetId, sellTokenAddress, sellTokenName, sellMinQuantity, sellMaxQuantity, sellMetadata, auxiliaryFeePercentages, auxiliaryFeeRecipients, includeFees);
        }

        /// <summary>
        /// Get a list of orders
        /// </summary>
        /// <remarks>
        /// Get a list of orders
        /// </remarks>
        /// <exception cref="api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size of the result (optional)</param>
        /// <param name="cursor">Cursor (optional)</param>
        /// <param name="orderBy">Property to sort by (optional)</param>
        /// <param name="direction">Direction to sort (asc/desc) (optional)</param>
        /// <param name="user">Ethereum address of the user who submitted this order (optional)</param>
        /// <param name="status">Status of this order (optional)</param>
        /// <param name="minTimestamp">Minimum created at timestamp for this order, in ISO 8601 UTC format. Example: &#39;2022-05-27T00:10:22Z&#39; (optional)</param>
        /// <param name="maxTimestamp">Maximum created at timestamp for this order, in ISO 8601 UTC format. Example: &#39;2022-05-27T00:10:22Z&#39; (optional)</param>
        /// <param name="updatedMinTimestamp">Minimum updated at timestamp for this order, in ISO 8601 UTC format. Example: &#39;2022-05-27T00:10:22Z&#39; (optional)</param>
        /// <param name="updatedMaxTimestamp">Maximum updated at timestamp for this order, in ISO 8601 UTC format. Example: &#39;2022-05-27T00:10:22Z&#39; (optional)</param>
        /// <param name="buyTokenType">Token type of the asset this order buys (optional)</param>
        /// <param name="buyTokenId">ERC721 Token ID of the asset this order buys (optional)</param>
        /// <param name="buyAssetId">Internal IMX ID of the asset this order buys (optional)</param>
        /// <param name="buyTokenAddress">Token address of the asset this order buys (optional)</param>
        /// <param name="buyTokenName">Token name of the asset this order buys (optional)</param>
        /// <param name="buyMinQuantity">Min quantity for the asset this order buys (optional)</param>
        /// <param name="buyMaxQuantity">Max quantity for the asset this order buys (optional)</param>
        /// <param name="buyMetadata">JSON-encoded metadata filters for the asset this order buys (optional)</param>
        /// <param name="sellTokenType">Token type of the asset this order sells (optional)</param>
        /// <param name="sellTokenId">ERC721 Token ID of the asset this order sells (optional)</param>
        /// <param name="sellAssetId">Internal IMX ID of the asset this order sells (optional)</param>
        /// <param name="sellTokenAddress">Token address of the asset this order sells (optional)</param>
        /// <param name="sellTokenName">Token name of the asset this order sells (optional)</param>
        /// <param name="sellMinQuantity">Min quantity for the asset this order sells (optional)</param>
        /// <param name="sellMaxQuantity">Max quantity for the asset this order sells (optional)</param>
        /// <param name="sellMetadata">JSON-encoded metadata filters for the asset this order sells (optional)</param>
        /// <param name="auxiliaryFeePercentages">Comma separated string of fee percentages that are to be paired with auxiliary_fee_recipients (optional)</param>
        /// <param name="auxiliaryFeeRecipients">Comma separated string of fee recipients that are to be paired with auxiliary_fee_percentages (optional)</param>
        /// <param name="includeFees">Set flag to true to include fee object for orders (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ListOrdersResponse</returns>
        public async System.Threading.Tasks.Task<ListOrdersResponse> ListOrdersAsync(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string user = default(string), string status = default(string), string minTimestamp = default(string), string maxTimestamp = default(string), string updatedMinTimestamp = default(string), string updatedMaxTimestamp = default(string), string buyTokenType = default(string), string buyTokenId = default(string), string buyAssetId = default(string), string buyTokenAddress = default(string), string buyTokenName = default(string), string buyMinQuantity = default(string), string buyMaxQuantity = default(string), string buyMetadata = default(string), string sellTokenType = default(string), string sellTokenId = default(string), string sellAssetId = default(string), string sellTokenAddress = default(string), string sellTokenName = default(string), string sellMinQuantity = default(string), string sellMaxQuantity = default(string), string sellMetadata = default(string), string auxiliaryFeePercentages = default(string), string auxiliaryFeeRecipients = default(string), bool? includeFees = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await OrdersApi.ListOrdersAsync(pageSize, cursor, orderBy, direction, user, status, minTimestamp, maxTimestamp, updatedMinTimestamp, updatedMaxTimestamp, buyTokenType, buyTokenId, buyAssetId, buyTokenAddress, buyTokenName, buyMinQuantity, buyMaxQuantity, buyMetadata, sellTokenType, sellTokenId, sellAssetId, sellTokenAddress, sellTokenName, sellMinQuantity, sellMaxQuantity, sellMetadata, auxiliaryFeePercentages, auxiliaryFeeRecipients, includeFees, 0, cancellationToken).ConfigureAwait(false);
        }

        #endregion Orders

        #region Tokens

        /// <summary>
        /// Get details of a token
        /// </summary>
        /// <remarks>
        /// Get details of a token
        /// </remarks>
        /// <exception cref="api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Token Contract Address</param>
        /// <returns>TokenDetails</returns>
        public TokenDetails GetToken(string address)
        {
            return TokensApi.GetToken(address);
        }

        /// <summary>
        /// Get details of a token
        /// </summary>
        /// <remarks>
        /// Get details of a token
        /// </remarks>
        /// <exception cref="api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">Token Contract Address</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of TokenDetails</returns>
        public async System.Threading.Tasks.Task<TokenDetails> GetTokenAsync(string address, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await TokensApi.GetTokenAsync(address, 0, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a list of tokens
        /// </summary>
        /// <remarks>
        /// Get a list of tokens
        /// </remarks>
        /// <exception cref="api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size of the result (optional)</param>
        /// <param name="cursor">Cursor (optional)</param>
        /// <param name="orderBy">Property to sort by (optional)</param>
        /// <param name="direction">Direction to sort (asc/desc) (optional)</param>
        /// <param name="address">Contract address of the token (optional)</param>
        /// <param name="symbols">Token symbols for the token, e.g. ?symbols&#x3D;IMX,ETH (optional)</param>
        /// <returns>ListTokensResponse</returns>
        public ListTokensResponse ListTokens(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string address = default(string), string symbols = default(string))
        {
            return TokensApi.ListTokens(pageSize, cursor, orderBy, direction, address, symbols);
        }

        /// <summary>
        /// Get a list of tokens
        /// </summary>
        /// <remarks>
        /// Get a list of tokens
        /// </remarks>
        /// <exception cref="api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size of the result (optional)</param>
        /// <param name="cursor">Cursor (optional)</param>
        /// <param name="orderBy">Property to sort by (optional)</param>
        /// <param name="direction">Direction to sort (asc/desc) (optional)</param>
        /// <param name="address">Contract address of the token (optional)</param>
        /// <param name="symbols">Token symbols for the token, e.g. ?symbols&#x3D;IMX,ETH (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ListTokensResponse</returns>
        public async System.Threading.Tasks.Task<ListTokensResponse> ListTokensAsync(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string address = default(string), string symbols = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await TokensApi.ListTokensAsync(pageSize, cursor, orderBy, direction, address, symbols, 0, cancellationToken).ConfigureAwait(false);
        }

        #endregion Tokens

        #region Transfers

        /// <summary>
        /// Get details of a transfer with the given ID
        /// </summary>
        /// <remarks>
        /// Get details of a transfer with the given ID
        /// </remarks>
        /// <exception cref="api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Transfer ID</param>
        /// <returns>Transfer</returns>
        public Transfer GetTransfer(string id)
        {
            return TransfersApi.GetTransfer(id);
        }

        /// <summary>
        /// Get details of a transfer with the given ID
        /// </summary>
        /// <remarks>
        /// Get details of a transfer with the given ID
        /// </remarks>
        /// <exception cref="api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Transfer ID</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Transfer</returns>
        public async System.Threading.Tasks.Task<Transfer> GetTransferAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await TransfersApi.GetTransferAsync(id, 0, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a list of transfers
        /// </summary>
        /// <remarks>
        /// Get a list of transfers
        /// </remarks>
        /// <exception cref="api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size of the result (optional)</param>
        /// <param name="cursor">Cursor (optional)</param>
        /// <param name="orderBy">Property to sort by (optional)</param>
        /// <param name="direction">Direction to sort (asc/desc) (optional)</param>
        /// <param name="user">Ethereum address of the user who submitted this transfer (optional)</param>
        /// <param name="receiver">Ethereum address of the user who received this transfer (optional)</param>
        /// <param name="status">Status of this transfer (optional)</param>
        /// <param name="minTimestamp">Minimum timestamp for this transfer, in ISO 8601 UTC format. Example: &#39;2022-05-27T00:10:22Z&#39; (optional)</param>
        /// <param name="maxTimestamp">Maximum timestamp for this transfer, in ISO 8601 UTC format. Example: &#39;2022-05-27T00:10:22Z&#39; (optional)</param>
        /// <param name="tokenType">Token type of the transferred asset (optional)</param>
        /// <param name="tokenId">ERC721 Token ID of the minted asset (optional)</param>
        /// <param name="assetId">Internal IMX ID of the minted asset (optional)</param>
        /// <param name="tokenAddress">Token address of the transferred asset (optional)</param>
        /// <param name="tokenName">Token name of the transferred asset (optional)</param>
        /// <param name="minQuantity">Max quantity for the transferred asset (optional)</param>
        /// <param name="maxQuantity">Max quantity for the transferred asset (optional)</param>
        /// <param name="metadata">JSON-encoded metadata filters for the transferred asset (optional)</param>
        /// <returns>ListTransfersResponse</returns>
        public ListTransfersResponse ListTransfers(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string user = default(string), string receiver = default(string), string status = default(string), string minTimestamp = default(string), string maxTimestamp = default(string), string tokenType = default(string), string tokenId = default(string), string assetId = default(string), string tokenAddress = default(string), string tokenName = default(string), string minQuantity = default(string), string maxQuantity = default(string), string metadata = default(string))
        {
            return TransfersApi.ListTransfers(pageSize, cursor, orderBy, direction, user, receiver, status, minTimestamp, maxTimestamp, tokenType, tokenId, assetId, tokenAddress, tokenName, minQuantity, maxQuantity, metadata);
        }

        /// <summary>
        /// Get a list of transfers
        /// </summary>
        /// <remarks>
        /// Get a list of transfers
        /// </remarks>
        /// <exception cref="api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size of the result (optional)</param>
        /// <param name="cursor">Cursor (optional)</param>
        /// <param name="orderBy">Property to sort by (optional)</param>
        /// <param name="direction">Direction to sort (asc/desc) (optional)</param>
        /// <param name="user">Ethereum address of the user who submitted this transfer (optional)</param>
        /// <param name="receiver">Ethereum address of the user who received this transfer (optional)</param>
        /// <param name="status">Status of this transfer (optional)</param>
        /// <param name="minTimestamp">Minimum timestamp for this transfer, in ISO 8601 UTC format. Example: &#39;2022-05-27T00:10:22Z&#39; (optional)</param>
        /// <param name="maxTimestamp">Maximum timestamp for this transfer, in ISO 8601 UTC format. Example: &#39;2022-05-27T00:10:22Z&#39; (optional)</param>
        /// <param name="tokenType">Token type of the transferred asset (optional)</param>
        /// <param name="tokenId">ERC721 Token ID of the minted asset (optional)</param>
        /// <param name="assetId">Internal IMX ID of the minted asset (optional)</param>
        /// <param name="tokenAddress">Token address of the transferred asset (optional)</param>
        /// <param name="tokenName">Token name of the transferred asset (optional)</param>
        /// <param name="minQuantity">Max quantity for the transferred asset (optional)</param>
        /// <param name="maxQuantity">Max quantity for the transferred asset (optional)</param>
        /// <param name="metadata">JSON-encoded metadata filters for the transferred asset (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ListTransfersResponse</returns>
        public async System.Threading.Tasks.Task<ListTransfersResponse> ListTransfersAsync(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string user = default(string), string receiver = default(string), string status = default(string), string minTimestamp = default(string), string maxTimestamp = default(string), string tokenType = default(string), string tokenId = default(string), string assetId = default(string), string tokenAddress = default(string), string tokenName = default(string), string minQuantity = default(string), string maxQuantity = default(string), string metadata = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await TransfersApi.ListTransfersAsync(pageSize, cursor, orderBy, direction, user, receiver, status, minTimestamp, maxTimestamp, tokenType, tokenId, assetId, tokenAddress, tokenName, minQuantity, maxQuantity, metadata, 0, cancellationToken).ConfigureAwait(false);
        }

        #endregion Transfers

        #region Trades


        /// <summary>
        /// Get details of a trade with the given ID
        /// </summary>
        /// <remarks>
        /// Get details of a trade with the given ID
        /// </remarks>
        /// <exception cref="api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Trade ID</param>
        /// <returns>Trade</returns>
        public Trade GetTrade(string id)
        {
            return TradesApi.GetTrade(id);
        }

        /// <summary>
        /// Get details of a trade with the given ID
        /// </summary>
        /// <remarks>
        /// Get details of a trade with the given ID
        /// </remarks>
        /// <exception cref="api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Trade ID</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Trade</returns>
        public async System.Threading.Tasks.Task<Trade> GetTradeAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await TradesApi.GetTradeAsync(id, 0, cancellationToken).ConfigureAwait(false);
        }


        /// <summary>
        /// Get a list of trades
        /// </summary>
        /// <remarks>
        /// Get a list of trades
        /// </remarks>
        /// <exception cref="api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="partyATokenType">Party A&#39;s (buy order) token type of currency used to buy (optional)</param>
        /// <param name="partyATokenAddress">Party A&#39;s (buy order) token address of currency used to buy (optional)</param>
        /// <param name="partyBTokenType">Party B&#39;s (sell order) token type of NFT sold - always ERC721 (optional)</param>
        /// <param name="partyBTokenAddress">Party B&#39;s (sell order) collection address of NFT sold (optional)</param>
        /// <param name="partyBTokenId">Party B&#39;s (sell order) token id of NFT sold (optional)</param>
        /// <param name="pageSize">Page size of the result (optional)</param>
        /// <param name="cursor">Cursor (optional)</param>
        /// <param name="orderBy">Property to sort by (optional)</param>
        /// <param name="direction">Direction to sort (asc/desc) (optional)</param>
        /// <param name="minTimestamp">Minimum timestamp for this trade, in ISO 8601 UTC format. Example: &#39;2022-05-27T00:10:22Z&#39; (optional)</param>
        /// <param name="maxTimestamp">Maximum timestamp for this trade, in ISO 8601 UTC format. Example: &#39;2022-05-27T00:10:22Z&#39; (optional)</param>
        /// <returns>ListTradesResponse</returns>
        public ListTradesResponse ListTrades(string partyATokenType = default(string), string partyATokenAddress = default(string), string partyBTokenType = default(string), string partyBTokenAddress = default(string), string partyBTokenId = default(string), int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string minTimestamp = default(string), string maxTimestamp = default(string))
        {
            return TradesApi.ListTrades(partyATokenType, partyATokenAddress, partyBTokenType, partyBTokenAddress, partyBTokenId, pageSize, cursor, orderBy, direction, minTimestamp, maxTimestamp);
        }

        /// <summary>
        /// Get a list of trades
        /// </summary>
        /// <remarks>
        /// Get a list of trades
        /// </remarks>
        /// <exception cref="api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="partyATokenType">Party A&#39;s (buy order) token type of currency used to buy (optional)</param>
        /// <param name="partyATokenAddress">Party A&#39;s (buy order) token address of currency used to buy (optional)</param>
        /// <param name="partyBTokenType">Party B&#39;s (sell order) token type of NFT sold - always ERC721 (optional)</param>
        /// <param name="partyBTokenAddress">Party B&#39;s (sell order) collection address of NFT sold (optional)</param>
        /// <param name="partyBTokenId">Party B&#39;s (sell order) token id of NFT sold (optional)</param>
        /// <param name="pageSize">Page size of the result (optional)</param>
        /// <param name="cursor">Cursor (optional)</param>
        /// <param name="orderBy">Property to sort by (optional)</param>
        /// <param name="direction">Direction to sort (asc/desc) (optional)</param>
        /// <param name="minTimestamp">Minimum timestamp for this trade, in ISO 8601 UTC format. Example: &#39;2022-05-27T00:10:22Z&#39; (optional)</param>
        /// <param name="maxTimestamp">Maximum timestamp for this trade, in ISO 8601 UTC format. Example: &#39;2022-05-27T00:10:22Z&#39; (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ListTradesResponse</returns>
        public async System.Threading.Tasks.Task<ListTradesResponse> ListTradesAsync(string partyATokenType = default(string), string partyATokenAddress = default(string), string partyBTokenType = default(string), string partyBTokenAddress = default(string), string partyBTokenId = default(string), int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string minTimestamp = default(string), string maxTimestamp = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await TradesApi.ListTradesAsync(partyATokenType, partyATokenAddress, partyBTokenType, partyBTokenAddress, partyBTokenId, pageSize, cursor, orderBy, direction, minTimestamp, maxTimestamp, 0, cancellationToken).ConfigureAwait(false);
        }

        #endregion Trades

        #region Users

        /// <summary>
        /// Get stark keys for a registered user
        /// </summary>
        /// <remarks>
        /// Get stark keys for a registered user
        /// </remarks>
        /// <exception cref="api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user">User</param>
        /// <returns>GetUsersApiResponse</returns>
        public GetUsersApiResponse GetUsers(string user)
        {
            return UsersApi.GetUsers(user);
        }

        /// <summary>
        /// Get stark keys for a registered user
        /// </summary>
        /// <remarks>
        /// Get stark keys for a registered user
        /// </remarks>
        /// <exception cref="api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user">User</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GetUsersApiResponse</returns>
        public async System.Threading.Tasks.Task<GetUsersApiResponse> GetUsersAsync(string user, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await UsersApi.GetUsersAsync(user, 0, cancellationToken).ConfigureAwait(false);
        }

        #endregion Users

        #region Withdrawals

        /// <summary>
        /// Gets details of withdrawal with the given ID
        /// </summary>
        /// <remarks>
        /// Gets details of withdrawal with the given ID
        /// </remarks>
        /// <exception cref="api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Withdrawal ID</param>
        /// <returns>Withdrawal</returns>
        public Withdrawal GetWithdrawal(string id)
        {
            return WithdrawalsApi.GetWithdrawal(id);
        }

        /// <summary>
        /// Gets details of withdrawal with the given ID
        /// </summary>
        /// <remarks>
        /// Gets details of withdrawal with the given ID
        /// </remarks>
        /// <exception cref="api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Withdrawal ID</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Withdrawal</returns>
        public async System.Threading.Tasks.Task<Withdrawal> GetWithdrawalAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await WithdrawalsApi.GetWithdrawalAsync(id, 0, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a list of withdrawals Get a list of withdrawals
        /// </summary>
        /// <exception cref="api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="withdrawnToWallet">Withdrawal has been transferred to user&#39;s Layer 1 wallet (optional)</param>
        /// <param name="rollupStatus">Status of the on-chain batch confirmation for this withdrawal (optional)</param>
        /// <param name="pageSize">Page size of the result (optional)</param>
        /// <param name="cursor">Cursor (optional)</param>
        /// <param name="orderBy">Property to sort by (optional)</param>
        /// <param name="direction">Direction to sort (asc/desc) (optional)</param>
        /// <param name="user">Ethereum address of the user who submitted this withdrawal (optional)</param>
        /// <param name="status">Status of this withdrawal (optional)</param>
        /// <param name="minTimestamp">Minimum timestamp for this deposit, in ISO 8601 UTC format. Example: &#39;2022-05-27T00:10:22Z&#39; (optional)</param>
        /// <param name="maxTimestamp">Maximum timestamp for this deposit, in ISO 8601 UTC format. Example: &#39;2022-05-27T00:10:22Z&#39; (optional)</param>
        /// <param name="tokenType">Token type of the withdrawn asset (optional)</param>
        /// <param name="tokenId">ERC721 Token ID of the minted asset (optional)</param>
        /// <param name="assetId">Internal IMX ID of the minted asset (optional)</param>
        /// <param name="tokenAddress">Token address of the withdrawn asset (optional)</param>
        /// <param name="tokenName">Token name of the withdrawn asset (optional)</param>
        /// <param name="minQuantity">Min quantity for the withdrawn asset (optional)</param>
        /// <param name="maxQuantity">Max quantity for the withdrawn asset (optional)</param>
        /// <param name="metadata">JSON-encoded metadata filters for the withdrawn asset (optional)</param>
        /// <returns>ListWithdrawalsResponse</returns>
        public ListWithdrawalsResponse ListWithdrawals(bool? withdrawnToWallet = default(bool?), string rollupStatus = default(string), int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string user = default(string), string status = default(string), string minTimestamp = default(string), string maxTimestamp = default(string), string tokenType = default(string), string tokenId = default(string), string assetId = default(string), string tokenAddress = default(string), string tokenName = default(string), string minQuantity = default(string), string maxQuantity = default(string), string metadata = default(string))
        {
            return WithdrawalsApi.ListWithdrawals(withdrawnToWallet, rollupStatus, pageSize, cursor, orderBy, direction, user, status, minTimestamp, maxTimestamp, tokenType, tokenId, assetId, tokenAddress, tokenName, minQuantity, maxQuantity, metadata);
        }

        /// <summary>
        /// Get a list of withdrawals
        /// </summary>
        /// <remarks>
        /// Get a list of withdrawals
        /// </remarks>
        /// <exception cref="api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="withdrawnToWallet">Withdrawal has been transferred to user&#39;s Layer 1 wallet (optional)</param>
        /// <param name="rollupStatus">Status of the on-chain batch confirmation for this withdrawal (optional)</param>
        /// <param name="pageSize">Page size of the result (optional)</param>
        /// <param name="cursor">Cursor (optional)</param>
        /// <param name="orderBy">Property to sort by (optional)</param>
        /// <param name="direction">Direction to sort (asc/desc) (optional)</param>
        /// <param name="user">Ethereum address of the user who submitted this withdrawal (optional)</param>
        /// <param name="status">Status of this withdrawal (optional)</param>
        /// <param name="minTimestamp">Minimum timestamp for this deposit, in ISO 8601 UTC format. Example: &#39;2022-05-27T00:10:22Z&#39; (optional)</param>
        /// <param name="maxTimestamp">Maximum timestamp for this deposit, in ISO 8601 UTC format. Example: &#39;2022-05-27T00:10:22Z&#39; (optional)</param>
        /// <param name="tokenType">Token type of the withdrawn asset (optional)</param>
        /// <param name="tokenId">ERC721 Token ID of the minted asset (optional)</param>
        /// <param name="assetId">Internal IMX ID of the minted asset (optional)</param>
        /// <param name="tokenAddress">Token address of the withdrawn asset (optional)</param>
        /// <param name="tokenName">Token name of the withdrawn asset (optional)</param>
        /// <param name="minQuantity">Min quantity for the withdrawn asset (optional)</param>
        /// <param name="maxQuantity">Max quantity for the withdrawn asset (optional)</param>
        /// <param name="metadata">JSON-encoded metadata filters for the withdrawn asset (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ListWithdrawalsResponse</returns>
        public async System.Threading.Tasks.Task<ListWithdrawalsResponse> ListWithdrawalsAsync(bool? withdrawnToWallet = default(bool?), string rollupStatus = default(string), int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string user = default(string), string status = default(string), string minTimestamp = default(string), string maxTimestamp = default(string), string tokenType = default(string), string tokenId = default(string), string assetId = default(string), string tokenAddress = default(string), string tokenName = default(string), string minQuantity = default(string), string maxQuantity = default(string), string metadata = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            return await WithdrawalsApi.ListWithdrawalsAsync(withdrawnToWallet, rollupStatus, pageSize, cursor, orderBy, direction, user, status, minTimestamp, maxTimestamp, tokenType, tokenId, assetId, tokenAddress, tokenName, minQuantity, maxQuantity, metadata, 0, cancellationToken).ConfigureAwait(false);
        }

        #endregion Withdrawals
    }
}