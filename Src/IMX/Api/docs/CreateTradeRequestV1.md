# Imx.Sdk.Gen.Model.CreateTradeRequestV1

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AmountBuy** | **string** | Amount to buy | 
**AmountSell** | **string** | Amount to sell | 
**AssetIdBuy** | **string** | ID of the asset to buy | 
**AssetIdSell** | **string** | ID of the asset to sell | 
**ExpirationTimestamp** | **int** | Expiration timestamp for this trade | 
**FeeInfo** | [**FeeInfo**](FeeInfo.md) |  | [optional] 
**Fees** | [**List&lt;FeeEntry&gt;**](FeeEntry.md) | Fee information | [optional] 
**IncludeFees** | **bool** | [deprecated] All orders include fees since the introduction of protocol fees | [optional] 
**Nonce** | **int** | Nonce of the trade | 
**OrderId** | **int** | ID of the order | 
**StarkKey** | **string** | Public stark key of the user creating trade | 
**StarkSignature** | **string** | Payload signature | 
**VaultIdBuy** | **int** | ID of the vault into which the traded asset will be placed | 
**VaultIdSell** | **int** | ID of the vault to sell from | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

