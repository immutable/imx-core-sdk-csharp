# Imx.Sdk.Gen.Model.NftprimarytransactionGetResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ContractAddress** | **string** | Contract address of the asset | [optional] 
**OfferId** | **string** | Temporary asset id. Might be a token id if the token id is known or a generic description if it&#39;s not | [optional] 
**Provider** | **string** | Provider name | [optional] 
**SellerWalletAddress** | **string** | Ethereum address of the seller | [optional] 
**Status** | **string** | Transaction status enums(created, waitingPayment, pending, completed, failed) | [optional] 
**TokenId** | **string** | ID of the token that has been successfully minted - might or not be the same as &#x60;offer_id&#x60; | [optional] 
**TransactionId** | **string** | Transaction id | [optional] 
**UserWalletAddress** | **string** | Wallet address that receives the minted NFT | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

