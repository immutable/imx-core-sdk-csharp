# api.Model.SignableTransferResponseDetails

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | **string** | Amount of the asset being transferred | 
**AssetId** | **string** | ID of the asset being transferred | 
**ExpirationTimestamp** | **int** | Timestamp when this transfer will expire | 
**Nonce** | **int** | Nonce of the transfer | 
**PayloadHash** | **string** | Hash of the payload to be signed for transfer | 
**ReceiverStarkKey** | **string** | Receiver of the transfer | 
**ReceiverVaultId** | **int** | ID of the vault being transferred to | 
**SenderVaultId** | **int** | ID of the vault being transferred from | 
**Token** | [**SignableToken**](SignableToken.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

