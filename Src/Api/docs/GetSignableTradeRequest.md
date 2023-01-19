# api.Model.GetSignableTradeRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExpirationTimestamp** | **int** | ExpirationTimestamp in Unix time. Note: will be rounded down to the nearest hour | [optional] 
**Fees** | [**List&lt;FeeEntry&gt;**](FeeEntry.md) | Inclusion of either maker or taker fees | [optional] 
**OrderId** | **int** | The ID of the maker order involved | 
**User** | **string** | Ethereum address of the submitting user | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

