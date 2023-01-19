# api.Model.GetSignableTransferResponseV1

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | **string** | Amount of the asset being transferred | 
**AssetId** | **string** | ID of the asset being transferred | 
**ExpirationTimestamp** | **int** | Token in request to match in SDK implementation | 
**Nonce** | **int** | Nonce of the transfer | 
**PayloadHash** | **string** | Hash of the payload | 
**ReceiverStarkKey** | **string** | Receiver of the transfer | 
**ReceiverVaultId** | **int** | ID of the vault being transferred to | 
**SenderStarkKey** | **string** | Sender of the transfer | [optional] 
**SenderVaultId** | **int** | ID of the vault being transferred from | 
**SignableMessage** | **string** | Message to sign with L1 wallet to confirm transfer request | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

