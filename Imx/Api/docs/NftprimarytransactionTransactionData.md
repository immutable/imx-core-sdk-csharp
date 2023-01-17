# api.Model.NftprimarytransactionTransactionData

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ContractAddress** | **string** | Contract address of the asset | [optional] 
**CreatedAt** | **string** | Timestamp when the transaction was created | [optional] 
**ExternalId** | **string** | External transaction id | [optional] 
**FeesAmount** | **decimal** | Fees to pay on this transaction | [optional] 
**FromAmount** | **decimal** | Amount of the currency specified in &#x60;from_currency&#x60; that the buyer paid for the transaction | [optional] 
**FromCurrency** | **string** | Currency that the buyer used for the transaction | [optional] 
**MintId** | **string** | Minting transaction ID - see mintTokens response | [optional] 
**MintStatus** | **string** | Mint status | [optional] 
**OfferId** | **string** | Temporary asset id. Might be a token id if the token id is known or a generic description if it&#39;s not | [optional] 
**Provider** | **string** | Provider name | [optional] 
**SellerWalletAddress** | **string** | Ethereum address of the seller | [optional] 
**Status** | **string** | Transaction status enums(created, waitingPayment, pending, completed, failed) | [optional] 
**ToAmount** | **decimal** | Amount of the currency specified in &#x60;to_currency&#x60; that the seller received from the checkout provider for the transaction | [optional] 
**ToCurrency** | **string** | Currency (crypto) that the checkout provider sent to the seller for the transaction | [optional] 
**TokenId** | **string** | ID of the token that has been successfully minted - should be the same as &#x60;offer_id&#x60; | [optional] 
**TransactionId** | **string** | Transaction id | [optional] 
**UpdatedAt** | **string** | Timestamp when the transaction was updated | [optional] 
**UserWalletAddress** | **string** | Wallet address that receives the minted NFT | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

