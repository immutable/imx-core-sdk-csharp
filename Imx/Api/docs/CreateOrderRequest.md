# api.Model.CreateOrderRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AmountBuy** | **string** | Amount to buy | 
**AmountSell** | **string** | Amount to sell | 
**AssetIdBuy** | **string** | ID of the asset to buy | 
**AssetIdSell** | **string** | ID of the asset to sell | 
**ExpirationTimestamp** | **int** | Expiration timestamp for this order | 
**Fees** | [**List&lt;FeeEntry&gt;**](FeeEntry.md) | Fee information | [optional] 
**IncludeFees** | **bool** | Whether to include fees in order | [optional] 
**Nonce** | **int** | Nonce of the order | 
**StarkKey** | **string** | Public stark key of the user creating order | 
**StarkSignature** | **string** | Payload signature | 
**VaultIdBuy** | **int** | ID of the vault into which the bought asset will be placed | 
**VaultIdSell** | **int** | ID of the vault to sell from | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

