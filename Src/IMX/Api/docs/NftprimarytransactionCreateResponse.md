# Imx.Sdk.Gen.Model.NftprimarytransactionCreateResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ContractAddress** | **string** | Contract address of the asset to be created | [optional] 
**OfferId** | **string** | Temporary asset id. Might be a token id if the token id is known or a generic description if it&#39;s not | [optional] 
**Provider** | **string** | Provider name | [optional] 
**SellerWalletAddress** | **string** | Wallet address that will receive the payment (in crypto) from the checkout provider for the minted NFT | [optional] 
**TokenId** | **string** | ID of the token that has been successfully minted - should be the same as &#x60;offer_id&#x60; | [optional] 
**TransactionId** | **string** | Transaction id | [optional] 
**Url** | **string** | NFT purchase URL given by the checkout provider that the user can use to complete payment | [optional] 
**UserWalletAddress** | **string** | Ethereum address of the user who wants to create transaction | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

