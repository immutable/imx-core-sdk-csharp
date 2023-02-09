# Imx.Sdk.Gen.Api.WithdrawalsApi

All URIs are relative to *https://api.sandbox.x.immutable.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetWithdrawal**](WithdrawalsApi.md#getwithdrawal) | **GET** /v1/withdrawals/{id} | Gets details of withdrawal with the given ID |
| [**ListWithdrawals**](WithdrawalsApi.md#listwithdrawals) | **GET** /v1/withdrawals | Get a list of withdrawals |

<a name="getwithdrawal"></a>
# **GetWithdrawal**
> Withdrawal GetWithdrawal (string id)

Gets details of withdrawal with the given ID

Gets details of withdrawal with the given ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Imx.Sdk.Gen.Api;
using Imx.Sdk.Gen.Client;
using Imx.Sdk.Gen.Model;

namespace Example
{
    public class GetWithdrawalExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sandbox.x.immutable.com";
            var apiInstance = new WithdrawalsApi(config);
            var id = "id_example";  // string | Withdrawal ID

            try
            {
                // Gets details of withdrawal with the given ID
                Withdrawal result = apiInstance.GetWithdrawal(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WithdrawalsApi.GetWithdrawal: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWithdrawalWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets details of withdrawal with the given ID
    ApiResponse<Withdrawal> response = apiInstance.GetWithdrawalWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WithdrawalsApi.GetWithdrawalWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Withdrawal ID |  |

### Return type

[**Withdrawal**](Withdrawal.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listwithdrawals"></a>
# **ListWithdrawals**
> ListWithdrawalsResponse ListWithdrawals (bool? withdrawnToWallet = null, string rollupStatus = null, int? pageSize = null, string cursor = null, string orderBy = null, string direction = null, string user = null, string status = null, string minTimestamp = null, string maxTimestamp = null, string tokenType = null, string tokenId = null, string assetId = null, string tokenAddress = null, string tokenName = null, string minQuantity = null, string maxQuantity = null, string metadata = null)

Get a list of withdrawals

Get a list of withdrawals

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Imx.Sdk.Gen.Api;
using Imx.Sdk.Gen.Client;
using Imx.Sdk.Gen.Model;

namespace Example
{
    public class ListWithdrawalsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sandbox.x.immutable.com";
            var apiInstance = new WithdrawalsApi(config);
            var withdrawnToWallet = true;  // bool? | Withdrawal has been transferred to user's Layer 1 wallet (optional) 
            var rollupStatus = "rollupStatus_example";  // string | Status of the on-chain batch confirmation for this withdrawal (optional) 
            var pageSize = 56;  // int? | Page size of the result (optional) 
            var cursor = "cursor_example";  // string | Cursor (optional) 
            var orderBy = "orderBy_example";  // string | Property to sort by (optional) 
            var direction = "direction_example";  // string | Direction to sort (asc/desc) (optional) 
            var user = "user_example";  // string | Ethereum address of the user who submitted this withdrawal (optional) 
            var status = "status_example";  // string | Status of this withdrawal (optional) 
            var minTimestamp = "minTimestamp_example";  // string | Minimum timestamp for this deposit, in ISO 8601 UTC format. Example: '2022-05-27T00:10:22Z' (optional) 
            var maxTimestamp = "maxTimestamp_example";  // string | Maximum timestamp for this deposit, in ISO 8601 UTC format. Example: '2022-05-27T00:10:22Z' (optional) 
            var tokenType = "tokenType_example";  // string | Token type of the withdrawn asset (optional) 
            var tokenId = "tokenId_example";  // string | ERC721 Token ID of the minted asset (optional) 
            var assetId = "assetId_example";  // string | Internal IMX ID of the minted asset (optional) 
            var tokenAddress = "tokenAddress_example";  // string | Token address of the withdrawn asset (optional) 
            var tokenName = "tokenName_example";  // string | Token name of the withdrawn asset (optional) 
            var minQuantity = "minQuantity_example";  // string | Min quantity for the withdrawn asset (optional) 
            var maxQuantity = "maxQuantity_example";  // string | Max quantity for the withdrawn asset (optional) 
            var metadata = "metadata_example";  // string | JSON-encoded metadata filters for the withdrawn asset (optional) 

            try
            {
                // Get a list of withdrawals
                ListWithdrawalsResponse result = apiInstance.ListWithdrawals(withdrawnToWallet, rollupStatus, pageSize, cursor, orderBy, direction, user, status, minTimestamp, maxTimestamp, tokenType, tokenId, assetId, tokenAddress, tokenName, minQuantity, maxQuantity, metadata);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WithdrawalsApi.ListWithdrawals: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListWithdrawalsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a list of withdrawals
    ApiResponse<ListWithdrawalsResponse> response = apiInstance.ListWithdrawalsWithHttpInfo(withdrawnToWallet, rollupStatus, pageSize, cursor, orderBy, direction, user, status, minTimestamp, maxTimestamp, tokenType, tokenId, assetId, tokenAddress, tokenName, minQuantity, maxQuantity, metadata);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WithdrawalsApi.ListWithdrawalsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **withdrawnToWallet** | **bool?** | Withdrawal has been transferred to user&#39;s Layer 1 wallet | [optional]  |
| **rollupStatus** | **string** | Status of the on-chain batch confirmation for this withdrawal | [optional]  |
| **pageSize** | **int?** | Page size of the result | [optional]  |
| **cursor** | **string** | Cursor | [optional]  |
| **orderBy** | **string** | Property to sort by | [optional]  |
| **direction** | **string** | Direction to sort (asc/desc) | [optional]  |
| **user** | **string** | Ethereum address of the user who submitted this withdrawal | [optional]  |
| **status** | **string** | Status of this withdrawal | [optional]  |
| **minTimestamp** | **string** | Minimum timestamp for this deposit, in ISO 8601 UTC format. Example: &#39;2022-05-27T00:10:22Z&#39; | [optional]  |
| **maxTimestamp** | **string** | Maximum timestamp for this deposit, in ISO 8601 UTC format. Example: &#39;2022-05-27T00:10:22Z&#39; | [optional]  |
| **tokenType** | **string** | Token type of the withdrawn asset | [optional]  |
| **tokenId** | **string** | ERC721 Token ID of the minted asset | [optional]  |
| **assetId** | **string** | Internal IMX ID of the minted asset | [optional]  |
| **tokenAddress** | **string** | Token address of the withdrawn asset | [optional]  |
| **tokenName** | **string** | Token name of the withdrawn asset | [optional]  |
| **minQuantity** | **string** | Min quantity for the withdrawn asset | [optional]  |
| **maxQuantity** | **string** | Max quantity for the withdrawn asset | [optional]  |
| **metadata** | **string** | JSON-encoded metadata filters for the withdrawn asset | [optional]  |

### Return type

[**ListWithdrawalsResponse**](ListWithdrawalsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

