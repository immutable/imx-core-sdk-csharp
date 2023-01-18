# api.Model.GetSignableWithdrawalResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | **string** | Amount of the token we are withdrawing | 
**AssetId** | **string** | ID of the asset to be withdrawn | 
**Nonce** | **int** | Nonce of this transaction | 
**PayloadHash** | **string** | Encoded payload hash | 
**SignableMessage** | **string** | Message to sign with L1 wallet to verity withdrawal request | 
**StarkKey** | **string** | Public stark key of this user | 
**VaultId** | **int** | ID of the vault we are withdrawing from | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

