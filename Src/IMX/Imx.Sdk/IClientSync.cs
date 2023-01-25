using Imx.Sdk.Gen.Model;

namespace Imx.Sdk 
{
    interface IClientSync
    {
        #region Assets

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
        /// <param name="operationIndex">Index associated with the operation.</param>
        Asset GetAsset(string tokenAddress, string tokenId, bool? includeFees = default(bool?), int operationIndex = 0);

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
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ListAssetsResponse</returns>
        ListAssetsResponse ListAssets(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string user = default(string), string status = default(string), string name = default(string), string metadata = default(string), bool? sellOrders = default(bool?), bool? buyOrders = default(bool?), bool? includeFees = default(bool?), string collection = default(string), string updatedMinTimestamp = default(string), string updatedMaxTimestamp = default(string), string auxiliaryFeePercentages = default(string), string auxiliaryFeeRecipients = default(string), int operationIndex = 0);
        
        #endregion Assets
    
        #region Deposits

        /// <summary>
        /// Get details of a deposit with the given ID
        /// </summary>
        /// <remarks>
        /// Get details of a deposit with the given ID
        /// </remarks>
        /// <exception cref="api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Deposit ID</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Deposit</returns>
        Deposit GetDeposit(string id, int operationIndex = 0);

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
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ListDepositsResponse</returns>
        ListDepositsResponse ListDeposits(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string user = default(string), string status = default(string), string minTimestamp = default(string), string maxTimestamp = default(string), string tokenType = default(string), string tokenId = default(string), string assetId = default(string), string tokenAddress = default(string), string tokenName = default(string), string minQuantity = default(string), string maxQuantity = default(string), string metadata = default(string), int operationIndex = 0);

        #endregion Deposits
        
        #region Mints

        /// <summary>
        /// Get details of a mint with the given ID
        /// </summary>
        /// <remarks>
        /// Get details of a mint with the given ID
        /// </remarks>
        /// <exception cref="api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Mint ID. This is the transaction_id returned from listMints</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Mint</returns>
        Mint GetMint(string id, int operationIndex = 0);

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
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ListMintsResponse</returns>
        ListMintsResponse ListMints(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string user = default(string), string status = default(string), string minTimestamp = default(string), string maxTimestamp = default(string), string tokenType = default(string), string tokenId = default(string), string assetId = default(string), string tokenName = default(string), string tokenAddress = default(string), string minQuantity = default(string), string maxQuantity = default(string), string metadata = default(string), int operationIndex = 0);

        #endregion Mints

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
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Order</returns>
        Order GetOrder(string id, bool? includeFees = default(bool?), string auxiliaryFeePercentages = default(string), string auxiliaryFeeRecipients = default(string), int operationIndex = 0);

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
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ListOrdersResponse</returns>
        ListOrdersResponse ListOrders(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string user = default(string), string status = default(string), string minTimestamp = default(string), string maxTimestamp = default(string), string updatedMinTimestamp = default(string), string updatedMaxTimestamp = default(string), string buyTokenType = default(string), string buyTokenId = default(string), string buyAssetId = default(string), string buyTokenAddress = default(string), string buyTokenName = default(string), string buyMinQuantity = default(string), string buyMaxQuantity = default(string), string buyMetadata = default(string), string sellTokenType = default(string), string sellTokenId = default(string), string sellAssetId = default(string), string sellTokenAddress = default(string), string sellTokenName = default(string), string sellMinQuantity = default(string), string sellMaxQuantity = default(string), string sellMetadata = default(string), string auxiliaryFeePercentages = default(string), string auxiliaryFeeRecipients = default(string), bool? includeFees = default(bool?), int operationIndex = 0);

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
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>TokenDetails</returns>
        TokenDetails GetToken(string address, int operationIndex = 0);

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
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ListTokensResponse</returns>
        ListTokensResponse ListTokens(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string address = default(string), string symbols = default(string), int operationIndex = 0);

        #endregion Tokens

        #region Trades

        /// <summary>
        /// Get details of a trade with the given ID
        /// </summary>
        /// <remarks>
        /// Get details of a trade with the given ID
        /// </remarks>
        /// <exception cref="api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Trade ID</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Trade</returns>
        Trade GetTrade(string id, int operationIndex = 0);

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
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ListTradesResponse</returns>
        ListTradesResponse ListTrades(string partyATokenType = default(string), string partyATokenAddress = default(string), string partyBTokenType = default(string), string partyBTokenAddress = default(string), string partyBTokenId = default(string), int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string minTimestamp = default(string), string maxTimestamp = default(string), int operationIndex = 0);


        #endregion Trades

        #region Transfers

        /// <summary>
        /// Get details of a transfer with the given ID
        /// </summary>
        /// <remarks>
        /// Get details of a transfer with the given ID
        /// </remarks>
        /// <exception cref="api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Transfer ID</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Transfer</returns>
        Transfer GetTransfer(string id, int operationIndex = 0);

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
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ListTransfersResponse</returns>
        ListTransfersResponse ListTransfers(int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string user = default(string), string receiver = default(string), string status = default(string), string minTimestamp = default(string), string maxTimestamp = default(string), string tokenType = default(string), string tokenId = default(string), string assetId = default(string), string tokenAddress = default(string), string tokenName = default(string), string minQuantity = default(string), string maxQuantity = default(string), string metadata = default(string), int operationIndex = 0);

        #endregion Transfers

        #region Users

        /// <summary>
        /// Get stark keys for a registered user
        /// </summary>
        /// <remarks>
        /// Get stark keys for a registered user
        /// </remarks>
        /// <exception cref="api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user">User</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>GetUsersApiResponse</returns>
        GetUsersApiResponse GetUsers(string user, int operationIndex = 0);
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
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Withdrawal</returns>
        Withdrawal GetWithdrawal(string id, int operationIndex = 0);

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
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ListWithdrawalsResponse</returns>
        ListWithdrawalsResponse ListWithdrawals(bool? withdrawnToWallet = default(bool?), string rollupStatus = default(string), int? pageSize = default(int?), string cursor = default(string), string orderBy = default(string), string direction = default(string), string user = default(string), string status = default(string), string minTimestamp = default(string), string maxTimestamp = default(string), string tokenType = default(string), string tokenId = default(string), string assetId = default(string), string tokenAddress = default(string), string tokenName = default(string), string minQuantity = default(string), string maxQuantity = default(string), string metadata = default(string), int operationIndex = 0);

        #endregion Withdrawals
    }
}