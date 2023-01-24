# api.Model.GetSignableOrderResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AmountBuy** | **string** | Fee-exclusive amount to buy | 
**AmountSell** | **string** | Amount to sell | 
**AssetIdBuy** | **string** | ID of the asset to buy | 
**AssetIdSell** | **string** | ID of the asset to sell | 
**ExpirationTimestamp** | **int** | Expiration timestamp for this order | 
**FeeInfo** | [**FeeInfo**](FeeInfo.md) |  | [optional] 
**Nonce** | **int** | Nonce of the order | 
**PayloadHash** | **string** | Hash of the payload to be signed for signable order | 
**SignableMessage** | **string** | Message to sign with L1 wallet to confirm order request | 
**StarkKey** | **string** | Public stark key of the created user | 
**VaultIdBuy** | **int** | ID of the vault into which the bought asset will be placed | 
**VaultIdSell** | **int** | ID of the vault to sell from | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

