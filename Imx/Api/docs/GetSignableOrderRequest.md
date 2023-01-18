# api.Model.GetSignableOrderRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AmountBuy** | **string** | Fee-exclusive amount to buy the asset | 
**AmountSell** | **string** | Amount to sell (quantity) | 
**ExpirationTimestamp** | **int** | ExpirationTimestamp in Unix time. Note: will be rounded down to the nearest hour | [optional] 
**Fees** | [**List&lt;FeeEntry&gt;**](FeeEntry.md) | Inclusion of either maker or taker fees | [optional] 
**TokenBuy** | [**SignableToken**](SignableToken.md) |  | 
**TokenSell** | [**SignableToken**](SignableToken.md) |  | 
**User** | **string** | Ethereum address of the submitting user | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

